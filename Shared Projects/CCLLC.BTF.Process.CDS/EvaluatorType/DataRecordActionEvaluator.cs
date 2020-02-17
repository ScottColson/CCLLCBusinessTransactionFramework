using System;
using Microsoft.Xrm.Sdk;
using CCLLC.Core;
using CCLLC.BTF.Platform;



namespace CCLLC.BTF.Process.CDS.EvaluatorType
{
    public class DataRecordActionEvaluator : LogicEvaluatorTypeBase
    {
        public DataRecordActionEvaluator(IRecordPointer<Guid> id, string name, string implementationAssembly, string implementationClass) 
            : base(id.RecordType, id.Id, name, implementationAssembly, implementationClass)
        {
        }

        public override ILogicEvaluationResult Evaluate(IProcessExecutionContext executionContext, ISerializedParameters parameters, IRecordPointer<Guid> transactionRecordPointer)
        {           
            try
            {
                if (executionContext is null) throw new ArgumentNullException("executionContext");
                if (executionContext.Container is null) throw new ArgumentException("executionContext must provide a Container.");
                if (parameters is null) throw new ArgumentNullException("parameters");
                if (transactionRecordPointer is null) throw new ArgumentNullException("transactionRecordPointer");
                if (transactionRecordPointer.RecordType != "ccllc_transaction") throw new ArgumentException("transactionRecordPointer must reference a ccllc_transaction record.");

                ValidateParameters(executionContext, parameters);
                
                // get the Transaction Manager from the container and then build a transaction manager using default caching.
                var transMgrFactory = executionContext.Container.Resolve<ITransactionManagerFactory>();
                var transManager = transMgrFactory.CreateTransactionManager(executionContext);
    
                var transaction = transManager.LoadTransaction(executionContext, transactionRecordPointer);
                                
                var dataRecord = transaction.DataRecord;
                var req = new OrganizationRequest(parameters["ActionName"]);
                req["Target"] = new EntityReference(dataRecord.RecordType, dataRecord.Id);
                req["Transaction"] = transaction.ToEntityReference();

                //process any additional parameter data passed in from the configuration.
                if (parameters.Count > 1)
                {
                    foreach (var key in parameters.Keys)
                    {
                        if (key != "ActionName" && !string.IsNullOrEmpty(parameters[key]))
                        {
                            req[key] = parameters[key];
                        }
                    }
                }

                var response = executionContext.DataService.ToOrgService().Execute(req);

                if (!response.Results.ContainsKey("IsTrue")) throw new Exception("Action did not return the required IsTrue output parameter.");

                bool isTrue = (bool)response["IsTrue"];

                string message = null;
                // capture optional message if it exits
                if(response.Results.ContainsKey("Message") && response["Message"] is string)
                {
                    message = response["Message"] as string;
                }


                return new LogicEvaluationResult(isTrue, message);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    

        public override void ValidateParameters(IProcessExecutionContext executionContext, ISerializedParameters parameters)
        {
            if (!parameters.ContainsKey("ActionName") || string.IsNullOrEmpty(parameters["ActionName"]))
            {
                throw new Exception("DataRecordActionEvaluator requires a parameter for ActionName.");
            }
        }
    }
}
