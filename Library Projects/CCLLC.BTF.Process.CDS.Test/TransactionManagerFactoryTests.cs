using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using DLaB.Xrm.Test;
using CCLLC.CDS.Test.Builders;

namespace CCLLC.BTF.Process.CDS.Test
{
    [TestClass]
    public class TransactionManagerFactoryTests
    {
        #region BuildTransactionManager_Should_ReturnTransactionManagerFromCache

        [TestMethod]
        public void Test_BuildTransactionManager_Should_ReturnTransactionManagerFromCache()
        {
            new BuildTransactionManager_Should_ReturnTransactionManagerFromCache().Test();
        }

        private class BuildTransactionManager_Should_ReturnTransactionManagerFromCache : Common.TestMethodBase
        {       

            protected override void Test(IOrganizationService service)
            {
                var executionContext = GetExecutionContext(service);

                var factory = Container.Resolve<ITransactionManagerFactory>();                

                var transactionManager1 = factory.CreateTransactionManager(executionContext, new TimeSpan(0, 0, 10));
                var transactionManager2 = factory.CreateTransactionManager(executionContext, new TimeSpan(0, 0, 10));
                var transactionManager3 = factory.CreateTransactionManager(executionContext);

                Assert.AreSame(transactionManager1, transactionManager2);
                Assert.AreNotSame(transactionManager1, transactionManager3);
            }
        }


        #endregion


        #region BuildTransactionManager_Should_CreateTransactionManagerWithTwoConfiguredTransactionTypes

        [TestMethod]
        public void Test_BuildTransactionManager_Should_CreateTransactionManagerWithTwoConfiguredTransactionTypes()
        {
            new BuildTransactionManager_Should_CreateTransactionManagerWithTwoConfiguredTransactionTypes().Test();
        }


        private class BuildTransactionManager_Should_CreateTransactionManagerWithTwoConfiguredTransactionTypes : Common.TestMethodBase
        {
            private struct Ids
            {
                public static readonly Id<TestProxy.ccllc_channel> Channel1 = new Id<TestProxy.ccllc_channel>("E929FD0D-6E6D-4BBC-97D0-967B5969587A");
                public static readonly Id<TestProxy.ccllc_channel> Channel2 = new Id<TestProxy.ccllc_channel>("F760EC44-D86E-4112-9AD9-2C7D8F6B270A");
                public static readonly Id<TestProxy.ccllc_channel> Channel3 = new Id<TestProxy.ccllc_channel>("92769D12-42E6-4766-80C2-53F6589A28C7");

                public static readonly Id<TestProxy.ccllc_role> Role1 = new Id<TestProxy.ccllc_role>("49843265-DF8D-4B35-8E6E-6FE40EEF8765");
                public static readonly Id<TestProxy.ccllc_role> Role2 = new Id<TestProxy.ccllc_role>("9BD67C40-FA5E-4B6C-86B4-760DEFDF5358");
                public static readonly Id<TestProxy.ccllc_role> Role3 = new Id<TestProxy.ccllc_role>("C171D085-DD73-4ED0-BB44-8609BB040367");

                public static readonly Id<TestProxy.ccllc_transactiongroup> Group1 = new Id<TestProxy.ccllc_transactiongroup>("97D33246-53C0-4B88-8F04-802E1F9DDDCE");
                public static readonly Id<TestProxy.ccllc_transactiongroup> Group2 = new Id<TestProxy.ccllc_transactiongroup>("4B2512E3-E447-4F49-B27C-C6D45FCA6047");

                public static readonly Id<TestProxy.ccllc_fee> Fee1 = new Id<TestProxy.ccllc_fee>("9BA4868D-9E17-4090-9E83-B7202196B9E4");
                public static readonly Id<TestProxy.ccllc_fee> Fee2 = new Id<TestProxy.ccllc_fee>("DC77AADA-DF60-4148-8E86-3CD6B359B50B");
                public static readonly Id<TestProxy.ccllc_fee> Fee3 = new Id<TestProxy.ccllc_fee>("CD080A24-D66D-44DB-A950-BDEFEC95DF3B");
                public static readonly Id<TestProxy.ccllc_fee> Fee4 = new Id<TestProxy.ccllc_fee>("C483CFA3-95CB-4C66-9970-A23288E9505D");

                public static readonly Id<TestProxy.ccllc_evaluatortype> DataRecordActionEvaluator = new Id<TestProxy.ccllc_evaluatortype>("BFC7380C-7DFD-4E88-AB29-E38FE6E18E69");
                public static readonly Id<TestProxy.ccllc_evaluatortype> DataRecordQueryEvaluator = new Id<TestProxy.ccllc_evaluatortype>("83E07EFE-CD76-4F72-8073-714C14EF8967");
                
                public static readonly Id<TestProxy.ccllc_processsteptype> DataFormStepType = new Id<TestProxy.ccllc_processsteptype>("E2F6E631-9B1E-4472-BE33-4045353BFB62");
                public static readonly Id<TestProxy.ccllc_processsteptype> RecordActionStepType = new Id<TestProxy.ccllc_processsteptype>("7D3A6AB1-8C81-49F1-83BC-9396BA42B38B");
                public static readonly Id<TestProxy.ccllc_processsteptype> ConditionalStepType = new Id<TestProxy.ccllc_processsteptype>("6652CAD9-ECF7-4016-9E28-BFA1031881A7");

                #region Transaction Type 1

                public static readonly Id<TestProxy.ccllc_transactiontype> TransactionType1 = new Id<TestProxy.ccllc_transactiontype>("906B5118-B624-4648-9E7D-0BC85E1A222D");

                public static readonly Id<TestProxy.ccllc_transactiontypeauthorizedchannel> TransactionAuthorizedChannel1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedchannel>("BEBF3A17-6983-4776-9F29-982F638FB45E");
                public static readonly Id<TestProxy.ccllc_transactiontypeauthorizedchannel> TransactionAuthorizedChannel1_2 = new Id<TestProxy.ccllc_transactiontypeauthorizedchannel>("98697D03-C9A8-4A2B-B7D0-EBC54F30580F");

                public static readonly Id<TestProxy.ccllc_transactiontypeauthorizedrole> TransactionAuthorizedRole1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedrole>("0A9C9845-FAE4-4163-B7AB-C3E1503600B8");
                public static readonly Id<TestProxy.ccllc_transactiontypeauthorizedrole> TransactionAuthorizedRole1_2 = new Id<TestProxy.ccllc_transactiontypeauthorizedrole>("0B3FFC50-080B-41F7-BFCB-4F059F0EAAB8");

                public static readonly Id<TestProxy.ccllc_transactioninitialfee> InitialFee1_1 = new Id<TestProxy.ccllc_transactioninitialfee>("6604E443-1D87-4889-903C-CA2C7670D078");
                public static readonly Id<TestProxy.ccllc_transactioninitialfee> InitialFee1_2 = new Id<TestProxy.ccllc_transactioninitialfee>("16F94594-E1E0-429A-9598-97EBEF463F2C");
               
                public static readonly Id<TestProxy.ccllc_transactionrequirement> Requirement1_1 = new Id<TestProxy.ccllc_transactionrequirement>("67AF501C-1CB2-4A2C-8EAE-FA08661FADE7");
                public static readonly Id<TestProxy.ccllc_transactionrequirement> Requirement1_2 = new Id<TestProxy.ccllc_transactionrequirement>("7BEEEA55-80AF-445F-904D-43C6FFD19E35");
                            
                public static readonly Id<TestProxy.ccllc_transactionprocess> Process1 = new Id<TestProxy.ccllc_transactionprocess>("F70608B4-EC6F-4FDD-9C27-3992F4DFC4D7");

                public static readonly Id<TestProxy.ccllc_processstep> Step1_1 = new Id<TestProxy.ccllc_processstep>("B764A2B2-4C3C-45DB-A218-D4C74392761E");
                public static readonly Id<TestProxy.ccllc_processstep> Step1_2 = new Id<TestProxy.ccllc_processstep>("F7FCBE3B-DBDA-41A0-9003-1D3200F55677");
                public static readonly Id<TestProxy.ccllc_processstep> Step1_3 = new Id<TestProxy.ccllc_processstep>("9CF7DC40-A902-4994-938C-29D478A3CC4D");

                #endregion

                #region Transaction Type 2

                public static readonly Id<TestProxy.ccllc_transactiontype> TransactionType2 = new Id<TestProxy.ccllc_transactiontype>("268015DB-DFD0-4264-8FD1-BCC3AF19F59E");

                public static readonly Id<TestProxy.ccllc_transactiontypeauthorizedchannel> TransactionAuthorizedChannel2_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedchannel>("B95EF141-41A6-4F59-BBBE-9309622EC5BA");

                public static readonly Id<TestProxy.ccllc_transactiontypeauthorizedrole> TransactionAuthorizedRole2_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedrole>("16941E31-69EC-4908-B056-19A370A2F7CB");

                public static readonly Id<TestProxy.ccllc_transactioninitialfee> InitialFee2_1 = new Id<TestProxy.ccllc_transactioninitialfee>("6D146AE5-6A35-4630-B50D-45E3AEED20E0");

                public static readonly Id<TestProxy.ccllc_transactionrequirement> Requirement2_1 = new Id<TestProxy.ccllc_transactionrequirement>("9B50EF32-49E8-45EF-B882-1F06F483CD01");
                
                public static readonly Id<TestProxy.ccllc_transactionprocess> Process2 = new Id<TestProxy.ccllc_transactionprocess>("13232104-69D0-4483-950F-2D20F52692C0");

                public static readonly Id<TestProxy.ccllc_processstep> Step2_1 = new Id<TestProxy.ccllc_processstep>("5DC626EA-1ED4-45A0-8711-7CAD5942C27B");

                #endregion

                #region Transaction Type 3 (Inactive - should be ignored)

                public static readonly Id<TestProxy.ccllc_transactiontype> TransactionType3 = new Id<TestProxy.ccllc_transactiontype>("C520A6FE-B42C-4F19-A871-F8B4CF7625FC");

                #endregion

            }

            protected override void InitializeTestData(IOrganizationService service)
            {
                try
                {
                                        
                    new CrmEnvironmentBuilder()

                    #region Step Type Setup

                        .WithBuilder<ProcessStepTypeBuilder>(Ids.DataFormStepType, b => b
                            .WithImplementatingAssembly("S3.Domain.Transactions")
                            .WithImplementatingClass("S3.Transactions.StepType.DataForm"))

                        .WithBuilder<ProcessStepTypeBuilder>(Ids.RecordActionStepType, b => b
                            .WithImplementatingAssembly("S3.D365.Transactions")
                            .WithImplementatingClass("CCLLC.BTF.Process.CDS.StepType.DataRecordAction"))

                        .WithBuilder<ProcessStepTypeBuilder>(Ids.ConditionalStepType, b => b
                            .WithImplementatingAssembly("S3.Domain.Transactions")
                            .WithImplementatingClass("S3.Transactions.StepType.Branch"))

                    #endregion

                    #region Evaluator Type Setup

                        .WithBuilder<EvaluatorTypeBuilder>(Ids.DataRecordActionEvaluator, b => b
                            .WithImplementatingAssembly("S3.D365.Transactions")
                            .WithImplementatingClass("CCLLC.BTF.Process.CDS.EvaluatorType.DataRecordActionEvaluator"))

                        .WithBuilder<EvaluatorTypeBuilder>(Ids.DataRecordQueryEvaluator, b => b
                            .WithImplementatingAssembly("S3.D365.Transactions")
                            .WithImplementatingClass("CCLLC.BTF.Process.CDS.EvaluatorType.DataReccordQueryMatchEvaluator"))

                    #endregion

                    #region Transaction Type 1 Setup with channels, roles, fees, and requirements

                        .WithBuilder<TransactionTypeBuilder>(Ids.TransactionType1, b => b
                            .InGroup(Ids.Group1)
                            .WithDisplayRank(2)
                            .WithDataRecordType("new_dataentity")
                            .WithStartupProcess(Ids.Process1))

                        .WithBuilder<TransactionChannelBulder>(Ids.TransactionAuthorizedChannel1_1, b => b
                            .ForTransctionType(Ids.TransactionType1)
                            .WithChannel(Ids.Channel1))

                        .WithBuilder<TransactionChannelBulder>(Ids.TransactionAuthorizedChannel1_2, b => b
                            .ForTransctionType(Ids.TransactionType1)
                            .WithChannel(Ids.Channel2))

                        .WithBuilder<TransactionRoleBuilder>(Ids.TransactionAuthorizedRole1_1, b => b
                            .ForTransactionType(Ids.TransactionType1)
                            .WithRole(Ids.Role1))

                        .WithBuilder<TransactionRoleBuilder>(Ids.TransactionAuthorizedRole1_2, b => b
                            .ForTransactionType(Ids.TransactionType1)
                            .WithRole(Ids.Role2))

                        .WithBuilder<TransactionInitialFeeBuilder>(Ids.InitialFee1_1, b => b
                            .ForTransactionType(Ids.TransactionType1)
                            .WithFee(Ids.Fee1))

                        .WithBuilder<TransactionInitialFeeBuilder>(Ids.InitialFee1_2, b => b
                            .ForTransactionType(Ids.TransactionType1)
                            .WithFee(Ids.Fee2))

                        .WithBuilder<TransactionRequirementBuilder>(Ids.Requirement1_1, b => b
                            .OfType(Ids.DataRecordActionEvaluator)
                            .ForTransactionType(Ids.TransactionType1))

                        .WithBuilder<TransactionRequirementBuilder>(Ids.Requirement1_2, b => b
                            .OfType(Ids.DataRecordQueryEvaluator)
                            .ForTransactionType(Ids.TransactionType1))

                    #endregion

                    #region Process 1 Setup

                        .WithBuilder<TransactionProcessBuilder>(Ids.Process1, b => b
                            .ForTransactionType(Ids.TransactionType1)
                            .WithInitialStep(Ids.Step1_1))

                        .WithBuilder<ProcessStepBuilder>(Ids.Step1_1, b => b
                            .OfType(Ids.DataFormStepType)                            
                            .WithParameters("{\"FormId\":\"Step1\"}")
                            .ForProcess(Ids.Process1)
                            .WithSubsequentStep(Ids.Step1_2))
                           
                        .WithBuilder<ProcessStepBuilder>(Ids.Step1_2, b => b
                            .OfType(Ids.DataFormStepType)
                            .WithParameters("{\"FormId\":\"Step2\"}")
                            .ForProcess(Ids.Process1)
                            .WithSubsequentStep(Ids.Step1_3))

                        .WithBuilder<ProcessStepBuilder>(Ids.Step1_3, b => b
                            .OfType(Ids.DataFormStepType)
                            .WithParameters("{\"FormId\":\"Step3\"}")
                            .ForProcess(Ids.Process1))

                    #endregion

                    #region Transaction Type 2 Setup with channels, roles, fees, and requirements

                        .WithBuilder<TransactionTypeBuilder>(Ids.TransactionType2, b => b
                            .InGroup(Ids.Group2)
                            .WithDisplayRank(1)
                            .WithDataRecordType("new_dataentity")
                            .WithStartupProcess(Ids.Process2))

                        .WithBuilder<TransactionChannelBulder>(Ids.TransactionAuthorizedChannel2_1, b => b
                            .ForTransctionType(Ids.TransactionType2)
                            .WithChannel(Ids.Channel3))                       

                        .WithBuilder<TransactionRoleBuilder>(Ids.TransactionAuthorizedRole2_1, b => b
                            .ForTransactionType(Ids.TransactionType2)
                            .WithRole(Ids.Role3))                       

                        .WithBuilder<TransactionInitialFeeBuilder>(Ids.InitialFee2_1, b => b
                            .ForTransactionType(Ids.TransactionType2)
                            .WithFee(Ids.Fee3))                       

                        .WithBuilder<TransactionRequirementBuilder>(Ids.Requirement2_1, b => b
                            .OfType(Ids.DataRecordActionEvaluator)
                            .ForTransactionType(Ids.TransactionType2))

                    #endregion

                    #region Process 2 Setup

                        .WithBuilder<TransactionProcessBuilder>(Ids.Process2, b => b
                            .ForTransactionType(Ids.TransactionType2)
                            .WithInitialStep(Ids.Step2_1))

                        .WithBuilder<ProcessStepBuilder>(Ids.Step2_1, b => b
                            .OfType(Ids.DataFormStepType)
                            .WithParameters("{\"FormId\":\"Step1\"}")
                            .ForProcess(Ids.Process2))

                    #endregion

                    #region Transaction Type 3 Setup (Will be inactive for test)

                        .WithBuilder<TransactionTypeBuilder>(Ids.TransactionType3, b => b
                            .InGroup(Ids.Group2)
                            .WithDisplayRank(1)
                            .WithDataRecordType("new_dataentity")
                            .WithStartupProcess(Ids.Process2))

                    #endregion

                        .WithEntities<Ids>()
                        .Create(service);
                }
                catch(Exception ex)
                {
                    this.Logger.WriteLine(ex.Message);
                }

            }


            protected override void Test(IOrganizationService service)
            {
                // It is not possible to create an inactive record for the test so deactivate Transaction Type 3
                // now to prove that the transaction manager factory ignores inactive transaction types.
                var updateRecord = new Entity(Ids.TransactionType3.LogicalName, Ids.TransactionType3.EntityId).ToEntity<TestProxy.ccllc_transactiontype>();
                updateRecord.statecode = TestProxy.ccllc_transactiontypeState.Inactive;
                updateRecord.statuscode = TestProxy.ccllc_transactiontype_statuscode.Inactive;
                service.Update(updateRecord);

                var executionContext = GetExecutionContext(service);

                var factory = Container.Resolve<ITransactionManagerFactory>();

                var transactionManager = factory.CreateTransactionManager(executionContext);

                Assert.AreEqual(2, transactionManager.RegisteredTransactionTypes.Count);

                var transactionType = transactionManager.RegisteredTransactionTypes.Where(r => r.Id == Ids.TransactionType1.EntityId).First();
                Assert.AreEqual(Ids.TransactionType1.EntityId, transactionType.Id);

                Assert.AreEqual(2, transactionType.AuthorizedChannels.Count);
                Assert.AreEqual(2, transactionType.AuthorizedRoles.Count);
                Assert.AreEqual(1, transactionType.AvailableProcesses.Count);
                Assert.AreEqual(2, transactionType.Requirements.Count);
                Assert.AreEqual(2, transactionType.InitialFeeSchedule.Count);                          

                var process = transactionType.AvailableProcesses[0];
                Assert.AreEqual(transactionType.StartUpProcessId, process.Id);
                Assert.AreEqual(Ids.Process1.EntityId, process.Id);
                Assert.AreEqual(3, process.ProcessSteps.Count);          
            }
        }

        #endregion

    }
}
