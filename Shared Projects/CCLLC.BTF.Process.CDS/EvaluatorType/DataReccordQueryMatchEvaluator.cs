using System;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using CCLLC.Core;
using CCLLC.BTF.Platform;


namespace CCLLC.BTF.Process.CDS.EvaluatorType
{
    public class DataReccordQueryMatchEvaluator : LogicEvaluatorTypeBase
    {
        public DataReccordQueryMatchEvaluator(IRecordPointer<Guid> id, string name, string implementationAssembly, string implementationClass)
            : base(id.RecordType,id.Id, name, implementationAssembly, implementationClass)
        {
        }

        public override ILogicEvaluationResult Evaluate(IProcessExecutionContext executionContext, ISerializedParameters parameters, Platform.ITransaction transaction)
        {
            executionContext.Trace("DataRecordQueryMatchEvaluator is Evaluating.");

            if (executionContext is null) throw new ArgumentNullException("executionContext");
            if (executionContext.Container is null) throw new ArgumentException("executionContext must provide a Container.");
            if (parameters is null) throw new ArgumentNullException("parameters");
            if (transaction is null) throw new ArgumentNullException("transaction");
            if (!(transaction is ITransaction)) throw new ArgumentException("transaction does not represent a valid Process Transaction.");

            ValidateParameters(executionContext, parameters);

                                   
            var dataRecord = (transaction as ITransaction).DataRecord;
            

            var orgService = executionContext.DataService.ToOrgService();

            var fetchXml = parameters["FetchXml"];

            //convert the fetchxml to a query expression
            var req = new FetchXmlToQueryExpressionRequest
            {
                FetchXml = fetchXml
            };

            var resp = (FetchXmlToQueryExpressionResponse)orgService.Execute(req);
            var qry = resp.Query;
            qry.NoLock = true;

            // Wrap the existing filter criteria with an AND clause where record id is equal to the current record. When
            // the query is run it will either return one record indicating that the current data record matches the filter
            // criteria or it will return zero record indicating that the current record does not match the filter criteria.
            var idFieldName = qry.EntityName + "id";

            FilterExpression wrapperFilter = new FilterExpression {
                FilterOperator = LogicalOperator.And,
                Conditions =
                {
                    new ConditionExpression
                    {
                        AttributeName = idFieldName,
                        Operator = ConditionOperator.Equal,
                        Values = {dataRecord.Id}
                    }
                }
            };

            if(qry.Criteria != null)
            {
                wrapperFilter.Filters.Add(qry.Criteria);
            }

            qry.Criteria = wrapperFilter;

            // Execute the query to see if a record is returned or not
            var results = orgService.RetrieveMultiple(qry);

            executionContext.Trace("DataRecordQueryMatchEvaluator found {0} matching records", results.Entities.Count);

            if(results.Entities.Count == 1)
            {
                return new LogicEvaluationResult(true, null);
            }

            return new LogicEvaluationResult(false, null);

        }

        public override void ValidateParameters(IProcessExecutionContext executionContext, ISerializedParameters parameters)
        {
            if (!parameters.ContainsKey("FetchXml") || string.IsNullOrEmpty(parameters["FetchXml"]))
            {
                throw new Exception("DataRecordQueryMatchEvalautor requires a parameter for FetchXml.");
            }
        }
    }
}
