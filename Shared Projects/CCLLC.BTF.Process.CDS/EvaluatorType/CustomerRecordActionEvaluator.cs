using System;
using Microsoft.Xrm.Sdk;
using CCLLC.Core;
using CCLLC.BTF.Platform;


namespace CCLLC.BTF.Process.CDS.EvaluatorType
{
    public class CustomerRecordActionEvaluator : LogicEvaluatorTypeBase
    {
        public CustomerRecordActionEvaluator(string recordType, Guid id, string name, string implementationAssembly, string implementationClass) 
            : base(recordType, id, name, implementationAssembly, implementationClass)
        {
        }

        public override ILogicEvaluationResult Evaluate(IProcessExecutionContext executionContext, ISerializedParameters parameters, Platform.ITransaction transaction)
        {
            try
            {
                _ = executionContext ?? throw new ArgumentNullException("executionContext");
                _ = parameters ?? throw new ArgumentNullException("parameters");
                _ = transaction ?? throw new ArgumentNullException("transaction");
                if (!(transaction is ITransaction)) throw new ArgumentException("transaction does not represent a valid Process Transaction type.");

                ValidateParameters(executionContext, parameters);

                var customer = (transaction as ITransaction).Customer ?? throw new Exception("Transaction is missing required Customer reference.");

                OrganizationRequest req = null;
                if(customer.RecordType == "contact")
                {
                    req = new OrganizationRequest(parameters["ContactActionName"]);
                }
                else
                {
                    req = new OrganizationRequest(parameters["AccountActionName"]);
                }

                if (req is null) throw new Exception("Unsupported customer type.");

                req["Target"] = new EntityReference(customer.RecordType, customer.Id);
                req["Transaction"] = transaction.ToEntityReference();

                //process any additional parameter data passed in from the configuration.
                if (parameters.Count > 1)
                {
                    foreach (var key in parameters.Keys)
                    {
                        if (key != "AccountActionName" && key != "ContactActionName" && !string.IsNullOrEmpty(parameters[key]))
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
                if (response.Results.ContainsKey("Message") && response["Message"] is string)
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
            if (!parameters.ContainsKey("ContactActionName") || string.IsNullOrEmpty(parameters["ContactActionName"]))
            {
                throw new Exception("CustomerRecordActionEvaluator requires a parameter for ContactActionName.");
            }

            if (!parameters.ContainsKey("AccountActionName") || string.IsNullOrEmpty(parameters["AccountActionName"]))
            {
                throw new Exception("CustomerRecordActionEvaluator requires a parameter for AccountActionName.");
            }
        }
    }
}
