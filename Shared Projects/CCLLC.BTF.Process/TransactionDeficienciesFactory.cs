using System;
using System.Collections.Generic;
using System.Linq;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;
    using CCLLC.BTF.Platform;

    public class TransactionDeficienciesFactory : ITransactionDeficienciesFactory
    {
        
        private ITransactionDataConnector DataConnector { get; }
        private IAgentFactory AgentFactory { get; }

        public TransactionDeficienciesFactory(ITransactionDataConnector dataConnector, IAgentFactory agentFactory)
        {
            this.DataConnector = dataConnector ?? throw new ArgumentNullException("dataConnector");
            this.AgentFactory = agentFactory ?? throw new ArgumentNullException("agentFactory");
        }

        public ITransactionDeficiencies CreateTransactionDeficiencies(IProcessExecutionContext executionContext, ITransaction transaction)
        {           
            var deficiencies = new List<IRequirementDeficiency>();

            var records = DataConnector.GetDeficiencyRecords(executionContext.DataService, transaction);

            foreach (var record in records.Where(r => r.Status != eDeficiencyStatusEnum.Cleared))
            {
                var requirement = transaction.TransactionType.Requirements
                    .Where(r => r.Id == record.Requirement.Id).FirstOrDefault() ?? throw new Exception("Requirement id is not valid.");

                var wavingAgent = record.WaivedBy != null ? AgentFactory.BuildAgent(executionContext, record.WaivedBy) : null;

                deficiencies.Add(new RequirementDeficiency(requirement, record.Status, wavingAgent, record.WaivedOn));
            }

            return new TransactionDeficiencies(DataConnector, transaction, deficiencies);


            throw new NotImplementedException();
        }
    }
}
