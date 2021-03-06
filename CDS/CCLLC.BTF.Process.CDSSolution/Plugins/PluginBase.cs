﻿using CCLLC.Core;
using CCLLC.CDS.Sdk;
using CCLLC.BTF.Platform;
using CCLLC.BTF.Platform.CDS;
using CCLLC.BTF.Revenue;
using CCLLC.BTF.Revenue.CDS;
using CCLLC.BTF.Documents;
using CCLLC.Telemetry;

namespace CCLLC.BTF.Process.CDS.Plugins
{
    public class PluginBase : InstrumentedCDSPlugin
    {      

        // Override default container with a static implementation so that all plugins in this 
        // assembly will use the same container and therefore the same instance of components registered
        // as single instance in the container.
        private static IocContainer _container;
        public override IIocContainer Container
        {
            get
            {
                if (_container == null) { _container = new IocContainer(); }
                return _container;
            }
        }


        // Override the telemetry sink to make it static so all plugins use the same sink.
        private static ITelemetrySink telemetrySink;
        public override ITelemetrySink TelemetrySink
        {
            get => telemetrySink;
            protected set => telemetrySink = value;
        }

        public PluginBase(string unsecureConfig, string secureConfig) : base(unsecureConfig, secureConfig)
        {
            // All processes will run with elevated system access.
            this.RunAs = eRunAs.System;

            // Setup ApplicationInsights defaults.
            this.DefaultInstrumentationKey = "7a6ecb67-6c9c-4640-81d2-80ce76c3ca34"; //DEV ApplicationInsights
            this.TrackExecutionPerformance = true;

            // Register implementation classes from the model libraries. The container will 
            // resolve these implementations as needed for dependency injection.
            this.Container.Implement<IAgentFactory>().Using<AgentFactory>().AsSingleInstance();
            this.Container.Implement<IAlternateBranchFactory>().Using<AlternateBranchFactory>().AsSingleInstance();
            this.Container.Implement<ICustomerFactory>().Using<CustomerFactory>().AsSingleInstance();
            this.Container.Implement<IDeferredActivator>().Using<DeferredActivator>().AsSingleInstance();
            this.Container.Implement<IDocumentService>().Using<DocumentService>().AsSingleInstance();
            this.Container.Implement<IEvidenceService>().Using<EvidenceService>().AsSingleInstance();
            this.Container.Implement<IFeeList>().Using<LazyFeeList>().AsSingleInstance();
            this.Container.Implement<ILocationFactory>().Using<LocationFactory>().AsSingleInstance();
            this.Container.Implement<ILogicEvaluatorFactory>().Using<LogicEvaluatorFactory>().AsSingleInstance();
            this.Container.Implement<ILogicEvaluatorTypeFactory>().Using<LogicEvaluatorTypeFactory>().AsSingleInstance();
            this.Container.Implement<IParameterSerializer>().Using<DefaultSerializer>().AsSingleInstance();
            this.Container.Implement<IPlatformDataConnector>().Using<PlatformDataConnector>();
            this.Container.Implement<IPlatformService>().Using<PlatformService>().AsSingleInstance();
            this.Container.Implement<IPriceCalculatorFactory>().Using<PriceCalculatorFactory>();
            this.Container.Implement<IProcessStepFactory>().Using<ProcessStepFactory>().AsSingleInstance();
            this.Container.Implement<IProcessStepTypeFactory>().Using<ProcessStepTypeFactory>().AsSingleInstance();
            this.Container.Implement<IRequirementEvaluator>().Using<RequirementEvaluator>().AsSingleInstance();
            this.Container.Implement<IRevenueDataConnector>().Using<RevenueDataConnector>().AsSingleInstance();
            this.Container.Implement<IStepHistoryDataConnector>().Using<StepHistoryDataConnector>().AsSingleInstance();
            this.Container.Implement<ITransactionContextFactory>().Using<TransactionContextFactory>().AsSingleInstance();
            this.Container.Implement<ITransactionDataConnector>().Using<TransactionDataConnector>().AsSingleInstance();
            this.Container.Implement<ITransactionDeficienciesFactory>().Using<TransactionDeficienciesFactory>().AsSingleInstance();
            this.Container.Implement<ITransactionFeeListFactory>().Using<TransactionFeeListFactory>().AsSingleInstance();
            this.Container.Implement<ITransactionHistoryFactory>().Using<TransactionHistoryFactory>().AsSingleInstance();
            this.Container.Implement<ITransactionServiceFactory>().Using<TransactionServiceFactory>().AsSingleInstance();
            this.Container.Implement<ITransactionProcessFactory>().Using<TransactionProcessFactory>().AsSingleInstance();
            this.Container.Implement<IRequirementFactory>().Using<RequirementFactory>().AsSingleInstance();
        }       

       
    }
}
