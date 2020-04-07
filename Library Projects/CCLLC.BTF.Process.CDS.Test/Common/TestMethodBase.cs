using Microsoft.Xrm.Sdk;
using CCLLC.Core;
using CCLLC.CDS.Test;
using CCLLC.BTF.Platform;
using CCLLC.BTF.Platform.CDS;
using CCLLC.BTF.Revenue;
using CCLLC.BTF.Revenue.CDS;
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
            c.Implement<ICustomerFactory>().Using<FakeCustomerFactory>();
            c.Implement<IDeferredActivator>().Using<DeferredActivator>();
            c.Implement<IDocumentService>().Using<FakeDocumentService>();
            c.Implement<IEvidenceManager>().Using<EvidenceManager>();
            c.Implement<IFeeList>().Using<LazyFeeList>();
            c.Implement<ILocationFactory>().Using<FakeLocationFactory>();
            c.Implement<ILogicEvaluatorFactory>().Using<LogicEvaluatorFactory>();
            c.Implement<ILogicEvaluatorTypeFactory>().Using<FakeLogicEvaluatorTypeFactory>();
            c.Implement<IParameterSerializer>().Using<DefaultSerializer>();
            c.Implement<IPlatformDataConnector>().Using<PlatformDataConnector>();
            c.Implement<IPlatformSettingsFactory>().Using<PlatformSettingsFactory>();
            c.Implement<IPlatformService>().Using<FakePlatformService>();
            c.Implement<IPriceCalculatorFactory>().Using<PriceCalculatorFactory>();
            c.Implement<IProcessSettingsFactory>().Using<ProcessSettingsFactory>();
            c.Implement<IProcessStepFactory>().Using<ProcessStepFactory>();
            c.Implement<IProcessStepTypeFactory>().Using<ProcessStepTypeFactory>();
            c.Implement<IRequirementEvaluator>().Using<RequirementEvaluator>();
            c.Implement<IRevenueDataConnector>().Using<RevenueDataConnector>();
            c.Implement<IRevenueSettingsFactory>().Using<RevenueSettingsFactory>();
            c.Implement<IStepHistoryDataConnector>().Using<StepHistoryDataConnector>();
            c.Implement<ITransactionContextFactory>().Using<TransactionContextFactory>();
            c.Implement<ITransactionDataConnector>().Using<TransactionDataConnector>();
            c.Implement<ITransactionDeficienciesFactory>().Using<TransactionDeficienciesFactory>();
            c.Implement<ITransactionFeeListFactory>().Using<TransactionFeeListFactory>();
            c.Implement<ITransactionHistoryFactory>().Using<TransactionHistoryFactory>();
            c.Implement<ITransactionServiceFactory>().Using<TransactionServiceFactory>();
            c.Implement<ITransactionProcessFactory>().Using<TransactionProcessFactory>();
            c.Implement<ITransactionRequirementFactory>().Using<TransactionRequirementFactory>();            
        }

        protected override abstract void Test(IOrganizationService service);
        
    }
}
