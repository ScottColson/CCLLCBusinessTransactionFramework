using Microsoft.Xrm.Sdk;
using CCLLC.Core;
using CCLLC.CDS.Test;
using CCLLC.BTF.Platform;
using CCLLC.BTF.Platform.CDS;
using CCLLC.BTF.Revenue;
using CCLLC.BTF.Documents;
using CCLLC.CDS.Test.Fakes;


namespace CCLLC.BTF.Process.CDS.Test.Common
{
    public abstract class TestMethodBase : TestMethodClassBase
    {
        public TestMethodBase() : base()
        {
            setupContainer(this.Container);
        }

        private void setupContainer(IIocContainer c)
        {
            c.Implement<IAgentFactory>().Using<FakeAgentFactory>();
            c.Implement<IAlternateBranchFactory>().Using<AlternateBranchFactory>();
            c.Implement<IAppliedFeeManager>().Using<FakeAppliedFeeManager>();
            c.Implement<ITransactionContextFactory>().Using<TransactionContextFactory>();
            c.Implement<ICustomerFactory>().Using<FakeCustomerFactory>();
            c.Implement<IDeferredActivator>().Using<DeferredActivator>();
            c.Implement<IDeficiencyManager>().Using<DeficiencyManager>();
            c.Implement<IDocumentManager>().Using<FakeDocumentManager>();
            c.Implement<IEvidenceManager>().Using<EvidenceManager>();
            c.Implement<ILocationFactory>().Using<FakeLocationFactory>();
            c.Implement<ILogicEvaluatorFactory>().Using<LogicEvaluatorFactory>();
            c.Implement<ILogicEvaluatorTypeFactory>().Using<FakeLogicEvaluatorTypeFactory>();
            c.Implement<IParameterSerializer>().Using<DefaultSerializer>();
            c.Implement<IPlatformManager>().Using<FakePlatformManager>();
            c.Implement<IProcessStepFactory>().Using<ProcessStepFactory>();
            c.Implement<IProcessStepTypeFactory>().Using<ProcessStepTypeFactory>();
            c.Implement<IRequirementEvaluator>().Using<DefaultRequirementEvaluator>();
            c.Implement<IStepHistoryManager>().Using<StepHistoryManager>();
            c.Implement<ITransactionManagerFactory>().Using<TransactionManagerFactory>();
            c.Implement<ITransactionProcessFactory>().Using<TransactionProcessFactory>();
            c.Implement<ITransactionRequirementFactory>().Using<TransactionRequirementFactory>();

            c.Implement<ITransactionDataConnector>().Using<TransactionDataConnector>();
            c.Implement<IStepHistoryDataConnector>().Using<StepHistoryDataConnector>();
            c.Implement<IPlatformDataConnector>().Using<PlatformDataConnector>();
        }

        protected override abstract void Test(IOrganizationService service);
        
    }
}
