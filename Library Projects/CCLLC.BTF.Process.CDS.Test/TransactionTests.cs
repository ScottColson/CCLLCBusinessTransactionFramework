using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using DLaB.Xrm.Test;
using CCLLC.CDS.Test.Builders;
using CCLLC.CDS.Test.Fakes;
using CCLLC.CDS.TestBase;


namespace CCLLC.BTF.Process.CDS.Test
{
    [TestClass]
    public class TransactionTests
    {
        #region NavigateForward_Should_MoveToNextUIStepAndCreateHistory

        [TestMethod]
        public void Test_NavigateForward_Should_MoveToNextUIStepAndCreateHistory()
        {
            new NavigateForward_Should_MoveToNextUIStepAndCreateHistory().Test();
        }

        private class NavigateForward_Should_MoveToNextUIStepAndCreateHistory : Common.TestMethodBase
        {
            private struct Ids
            {
                public static readonly Id Contact = new Id<TestProxy.Contact>("8E81715D-4EFC-49D2-A2CF-A5D7F593D065");

                public static readonly Id Agent = new Id<TestProxy.ccllc_agent>("EC8D5C11-1CF5-44B8-9353-2A97152863E1");

                public static readonly Id Location = new Id<TestProxy.ccllc_location>("3F21AE43-563D-4551-ABB7-8608DE06E68C");

                public static readonly Id Channel1 = new Id<TestProxy.ccllc_channel>("B6266EE9-7A16-44DF-BF2F-3D6333002320");
               
                public static readonly Id Role1 = new Id<TestProxy.ccllc_role>("0FEC63DE-E1E7-43B4-8551-9E31051927DF");

                public static readonly Id DataFormStepType = new Id<TestProxy.ccllc_processsteptype>("4AA5409A-62A6-4FC7-B5C0-F80CA08C6192");
               
                public static readonly Id Group1 = new Id<TestProxy.ccllc_transactiongroup>("FC1557F8-5FF7-4935-B957-6502909C7FBC");
                
                #region Transaction Type 1

                public static readonly Id TransactionType1 = new Id<TestProxy.ccllc_transactiontype>("CDB1D595-B186-4A3C-AE3D-6F574694234A");

                public static readonly Id TransactionAuthorizedChannel1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedchannel>("01B6A7C4-352C-4128-9438-30C273726703");

                public static readonly Id TransactionAuthorizedRole1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedrole>("27342F5B-0FB6-48BA-B91D-30F566D6CDC9");

                public static readonly Id TransactionContext1_1 = new Id<TestProxy.ccllc_transactiontypecontext>("93A93B1C-F02F-41AA-8EAB-E36426858ABE");

                public static readonly Id Process1 = new Id<TestProxy.ccllc_transactionprocess>("59E0717F-02DC-4E7C-A87F-7137C90BE9E0");

                public static readonly Id Step1_1 = new Id<TestProxy.ccllc_processstep>("55A24188-5083-4510-8BC2-070B44608CCB");
                public static readonly Id Step1_2 = new Id<TestProxy.ccllc_processstep>("07B8043C-9E28-4C79-BC08-0CF3224EA554");
                public static readonly Id Step1_3 = new Id<TestProxy.ccllc_processstep>("E4AC29D2-E0F2-4C96-8788-76CEF441DC24");

                #endregion

                public static readonly Id Transaction = new Id<TestProxy.ccllc_transaction>("405CC544-B886-45AC-9DAE-37D74BF0D64B");
                public static readonly Id DataRecord = new Id<TestProxy.new_transactiondatarecord>("A14F915E-1C19-4C2C-A6B7-3B9C8B65C8CE");
                public static readonly Id History1_1 = new Id<TestProxy.ccllc_stephistory>("18FDC053-4E5B-4D10-8D72-59709DDB9BE8");

                public static readonly Id CreatedHistory = new Id<TestProxy.ccllc_stephistory>("3CFA965C-6DCC-40E4-8FAC-14985A075215");
            }

            protected override void InitializeTestData(IOrganizationService service)
            {
                try
                {
                    new CrmEnvironmentBuilder()

                    #region Step Type Setup

                        .WithBuilder<ProcessStepTypeBuilder>(Ids.DataFormStepType, b => b
                            .WithImplementatingAssembly("CCLLC.BTF.Process.CDS")
                            .WithImplementatingClass("CCLLC.BTF.Process.StepType.DataForm"))
                     
                    #endregion                   

                    #region Transaction Type 1 Setup with channels, roles, fees, and requirements

                        .WithBuilder<TransactionTypeBuilder>(Ids.TransactionType1, b => b
                            .InGroup(Ids.Group1)
                            .WithDisplayRank(2)
                            .WithDataRecordType("new_transactiondatarecord")
                            .WithStartupProcess(Ids.Process1))

                        .WithBuilder<TransactionChannelBulder>(Ids.TransactionAuthorizedChannel1_1, b => b
                            .ForTransctionType(Ids.TransactionType1)
                            .WithChannel(Ids.Channel1))

                        .WithBuilder<TransactionRoleBuilder>(Ids.TransactionAuthorizedRole1_1, b => b
                            .ForTransactionType(Ids.TransactionType1)
                            .WithRole(Ids.Role1))
                        
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

                    #region Existing Transaction w/ Existing Data Record and Step History

                        .WithBuilder<TransactionBuilder>(Ids.Transaction, b => b
                            .OfTransactionType(Ids.TransactionType1)
                            .ForCustomer(Ids.Contact)
                            .UsingContextRecord(Ids.Contact)
                            .UsingProcess(Ids.Process1)
                            .AtStep(Ids.Step1_1)
                            .WithAgent(Ids.Agent)
                            .WithLocation(Ids.Location))

                        .WithBuilder<TransactionDataRecordBuilder>(Ids.DataRecord, b => b
                            .ForTransaction(Ids.Transaction)
                            .ForCustomer(Ids.Contact))

                        .WithBuilder<StepHistoryBuilder>(Ids.History1_1, b => b
                            .ForTransaction(Ids.Transaction)
                            .ForStep(Ids.Step1_1))

                    #endregion

                        .WithEntities<Ids>()
                        .ExceptEntities(
                            Ids.CreatedHistory)
                        .Create(service);
                }
                catch (Exception ex)
                {
                    this.Logger.WriteLine(ex.Message);
                }
            }

            protected override void Test(IOrganizationService service)
            {
                service = new OrganizationServiceBuilder(service)
                    .WithIdsDefaultedForCreate(
                        Ids.CreatedHistory)
                    .Build();

                var executionContext = GetExecutionContext(service);
                                
                var location = new FakeLocation(Ids.Location);
                var agent = new FakeAgent(Ids.Agent);
               
                //Fake Session matches all channels and roles
                var workSession = new FakeWorkSession()
                    .WithAgent(agent)
                    .WithLocation(location)
                    .AllowAllChannels()
                    .AllowAllRoles();

                var transactionManagerFactory = Container.Resolve<ITransactionManagerFactory>();
                var transactionManager = transactionManagerFactory.CreateTransactionManager(executionContext);
                var transaction = transactionManager.LoadTransaction(executionContext, Ids.Transaction.ToRecordPointer());

                //Verify starting on Step 1 and can navigate forward but not backward
                var step = transaction.CurrentStep;
                Assert.AreEqual(Ids.Step1_1.EntityId, step.Id);
                Assert.IsTrue(transaction.CanNavigateForward(workSession));
                Assert.IsFalse(transaction.CanNavigateBackward(workSession));

                //
                //Act: Navigate forward (should land on step 1_2)
                //
                step = transaction.NavigateForward(workSession);

                //Verify navigation succeeded
                Assert.AreEqual(Ids.Step1_2.EntityId, step.Id);                                         //returned correct step
                Assert.AreEqual(Ids.Step1_2.EntityId, transaction.CurrentStep.Id);                      //transaction object updated to correct step

                //Verify transaction record updated
                var transactionRecord = service.Retrieve(
                    Ids.Transaction.LogicalName,
                    Ids.Transaction.EntityId,
                    new Microsoft.Xrm.Sdk.Query.ColumnSet(true))
                    .ToEntity<ccllc_transaction>();

                Assert.AreEqual(Ids.Step1_2.EntityId, transactionRecord.ccllc_CurrentStepId.Id);

                //Verify existing history for step 1_1 updated
                var updatedHistory = service.Retrieve(
                    Ids.History1_1.LogicalName,
                    Ids.History1_1.EntityId,
                    new Microsoft.Xrm.Sdk.Query.ColumnSet(true))
                    .ToEntity<TestProxy.ccllc_stephistory>();

                Assert.AreEqual(Ids.Transaction.EntityId, updatedHistory.ccllc_TransactionId.Id);          //not changed
                Assert.AreEqual(Ids.Step1_1, updatedHistory.ccllc_ProcessStepId.Id);                       //not changed
                Assert.IsNotNull(updatedHistory.ccllc_CompletedOn);                                        //logs time of completion
                Assert.AreEqual(Ids.Location.EntityId, updatedHistory.ccllc_CompletedAtLocationId.Id);     //logs location where step was completed
                Assert.AreEqual(Ids.Agent.EntityId, updatedHistory.ccllc_CompletedByAgentId.Id);           //logs agent that completed step
                Assert.AreEqual((int)ccllc_stephistory_statuscode.Current, (int)updatedHistory.statuscode);//Current status

                //Verify new history record for Step 1_2 created.
                var createdHistory = service.Retrieve(
                    Ids.CreatedHistory.LogicalName, 
                    Ids.CreatedHistory.EntityId, 
                    new Microsoft.Xrm.Sdk.Query.ColumnSet(true))
                    .ToEntity<TestProxy.ccllc_stephistory>();

                Assert.AreEqual(Ids.Transaction.EntityId, createdHistory.ccllc_TransactionId.Id);          //linked to correct transaction
                Assert.AreEqual(Ids.Step1_2, createdHistory.ccllc_ProcessStepId.Id);                       //linked to correct step
                Assert.IsNull(createdHistory.ccllc_CompletedOn);                                           //not complete
                Assert.IsNull(createdHistory.ccllc_CompletedAtLocationId);                                 //not complete
                Assert.IsNull(createdHistory.ccllc_CompletedByAgentId);                                    //not complete
                Assert.AreEqual((int)ccllc_stephistory_statuscode.Current, (int)createdHistory.statuscode);//Current status

            }
        }

        #endregion NavigateForward_Should_MoveToNextUIStep


        #region NavigateForward_Should_AutomaticallyCompleteNonUISteps

        [TestMethod]
        public void Test_NavigateForward_Should_AutomaticallyCompleteNonUISteps()
        {
            new NavigateForward_Should_AutomaticallyCompleteNonUISteps().Test();
        }

        private class NavigateForward_Should_AutomaticallyCompleteNonUISteps : Common.TestMethodBase
        {
            private struct Ids
            {
                public static readonly Id Contact = new Id<TestProxy.Contact>("52877FFA-BB2F-46D8-99A7-649FE874F31D");

                public static readonly Id Agent = new Id<TestProxy.ccllc_agent>("D3A0BF6A-2EBF-4CE1-AF55-456D9D5B3449");

                public static readonly Id Location = new Id<TestProxy.ccllc_location>("693BE3D2-7279-4FA9-8A54-CF4F39304B7C");

                public static readonly Id Channel1 = new Id<TestProxy.ccllc_channel>("F644ECA9-7F04-4B15-A90A-7E309D96CF38");

                public static readonly Id Role1 = new Id<TestProxy.ccllc_role>("DFE46DF4-8132-49F2-82BC-3EDEAA843AEC");             

                public static readonly Id DataFormStepType = new Id<TestProxy.ccllc_processsteptype>("44EF52BD-010A-43C4-B160-B83280D4CF14");
                public static readonly Id RecordActionStepType = new Id<TestProxy.ccllc_processsteptype>("70CAC499-D8B4-47FE-8E23-7D7A635943D2");
               
                public static readonly Id Group1 = new Id<TestProxy.ccllc_transactiongroup>("7906D57B-58E5-4A6B-B194-5E51C264D170");            
               
                #region Transaction Type 1

                public static readonly Id TransactionType1 = new Id<TestProxy.ccllc_transactiontype>("6C417ED7-6B8A-4774-A316-CE98AB492DFA");

                public static readonly Id TransactionAuthorizedChannel1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedchannel>("0048D35D-503D-48A8-B324-908336C83C5A");

                public static readonly Id TransactionAuthorizedRole1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedrole>("4A48C61F-BA3E-4092-AE25-6F23145D0EDA");

                public static readonly Id InitialFee1_1 = new Id<TestProxy.ccllc_transactioninitialfee>("F0103518-855D-456E-B76A-A34A8EE8CDE6");

                public static readonly Id Requirement1_1 = new Id<TestProxy.ccllc_transactionrequirement>("2E827880-6C35-42F6-8B5A-F070FE5F41D2");

                public static readonly Id TransactionContext1_1 = new Id<TestProxy.ccllc_transactiontypecontext>("48E7C987-9160-4F53-9129-51C62DD0564B");

                public static readonly Id Process1 = new Id<TestProxy.ccllc_transactionprocess>("B7C12B19-2424-4A44-8B1B-C243DE2D38D8");

                public static readonly Id Step1_1 = new Id<TestProxy.ccllc_processstep>("9F18BB65-59CC-44AB-8FAC-A07D87EB8FFB");
                public static readonly Id Step1_2 = new Id<TestProxy.ccllc_processstep>("8ABD5004-F3EF-4F46-BF69-0F5D2E8CC482");
                public static readonly Id Step1_3 = new Id<TestProxy.ccllc_processstep>("44BA4B77-EC99-4359-AFBF-90E077D6E837");

                #endregion

                public static readonly Id Transaction = new Id<TestProxy.ccllc_transaction>("9E59EDBE-26FC-4801-97D6-B0F97D87AB34");
                public static readonly Id DataRecord = new Id<TestProxy.new_transactiondatarecord>("7DD65CB1-CF4B-40B8-8288-D74EA8F3690E");               
                public static readonly Id History1_1 = new Id<TestProxy.ccllc_stephistory>("F98EC265-ECAB-4494-922D-C8A9BA75870D");

                public static readonly Id CreatedHistory1_2 = new Id<TestProxy.ccllc_stephistory>("B1DA461B-6118-4CD5-9CD2-D10CB36CF7E8");
                public static readonly Id CreatedHistory1_3 = new Id<TestProxy.ccllc_stephistory>("EC8E8976-D76C-44AC-B49B-F6CEE2DEF75F");
            }

            protected override void InitializeTestData(IOrganizationService service)
            {
                try
                {

                    new CrmEnvironmentBuilder()

                    #region Step Type Setup

                        .WithBuilder<ProcessStepTypeBuilder>(Ids.DataFormStepType, b => b
                            .WithImplementatingAssembly("CCLLC.BTF.Process.CDS")
                            .WithImplementatingClass("CCLLC.BTF.Process.StepType.DataForm"))

                        .WithBuilder<ProcessStepTypeBuilder>(Ids.RecordActionStepType, b => b
                            .WithImplementatingAssembly("CCLLC.BTF.Process.CDS")
                            .WithImplementatingClass("CCLLC.BTF.Process.CDS.StepType.DataRecordAction"))                        

                    #endregion                   

                    #region Transaction Type 1 Setup with channels, roles, fees, and requirements

                        .WithBuilder<TransactionTypeBuilder>(Ids.TransactionType1, b => b
                            .InGroup(Ids.Group1)
                            .WithDisplayRank(2)
                            .WithDataRecordType("new_transactiondatarecord")
                            .WithStartupProcess(Ids.Process1))

                        .WithBuilder<TransactionChannelBulder>(Ids.TransactionAuthorizedChannel1_1, b => b
                            .ForTransctionType(Ids.TransactionType1)
                            .WithChannel(Ids.Channel1))

                        .WithBuilder<TransactionRoleBuilder>(Ids.TransactionAuthorizedRole1_1, b => b
                            .ForTransactionType(Ids.TransactionType1)
                            .WithRole(Ids.Role1))

                    #endregion

                    #region Process 1 Setup (UI Step followed by Non-UI step and then another UI-Step)

                        .WithBuilder<TransactionProcessBuilder>(Ids.Process1, b => b
                            .ForTransactionType(Ids.TransactionType1)
                            .WithInitialStep(Ids.Step1_1))

                        .WithBuilder<ProcessStepBuilder>(Ids.Step1_1, b => b
                            .OfType(Ids.DataFormStepType)
                            .WithParameters("{\"FormId\":\"Step1\"}")
                            .ForProcess(Ids.Process1)
                            .WithSubsequentStep(Ids.Step1_2))

                        .WithBuilder<ProcessStepBuilder>(Ids.Step1_2, b => b
                            .OfType(Ids.RecordActionStepType)
                            .WithParameters("{\"ActionName\":\"new_Action\"}")
                            .ForProcess(Ids.Process1)
                            .WithSubsequentStep(Ids.Step1_3))

                        .WithBuilder<ProcessStepBuilder>(Ids.Step1_3, b => b
                            .OfType(Ids.DataFormStepType)
                            .WithParameters("{\"FormId\":\"Step3\"}")
                            .ForProcess(Ids.Process1))

                    #endregion

                    #region Existing Transaction w/ Existing Data Record and Step History

                        .WithBuilder<TransactionBuilder>(Ids.Transaction, b => b
                            .OfTransactionType(Ids.TransactionType1)
                            .ForCustomer(Ids.Contact)
                            .UsingContextRecord(Ids.Contact)
                            .UsingProcess(Ids.Process1)
                            .AtStep(Ids.Step1_1)
                            .WithAgent(Ids.Agent)
                            .WithLocation(Ids.Location))

                        .WithBuilder<TransactionDataRecordBuilder>(Ids.DataRecord, b => b
                            .ForTransaction(Ids.Transaction)
                            .ForCustomer(Ids.Contact))

                        .WithBuilder<StepHistoryBuilder>(Ids.History1_1, b => b
                            .ForTransaction(Ids.Transaction)
                            .ForStep(Ids.Step1_1))

                    #endregion

                        .WithEntities<Ids>()
                        .ExceptEntities(
                            Ids.CreatedHistory1_2,
                            Ids.CreatedHistory1_3)
                        .Create(service);
                }
                catch (Exception ex)
                {
                    this.Logger.WriteLine(ex.Message);
                }
            }

            protected override void Test(IOrganizationService service)
            {
                service = new OrganizationServiceBuilder(service)
                   .WithIdsDefaultedForCreate(
                       Ids.CreatedHistory1_2,
                       Ids.CreatedHistory1_3)
                    .WithFakeExecute((s, r) => {
                           if (r.RequestName == "new_Action")
                           {
                               Assert.AreEqual(Ids.DataRecord.EntityId, (r["Target"] as EntityReference).Id);
                               Assert.AreEqual(Ids.Transaction.EntityId, (r["Transaction"] as EntityReference).Id);
                               OrganizationResponse resp = new OrganizationResponse();
                               resp.Results["IsTrue"] = true;                               
                               return resp;
                           }
                           return s.Execute(r);
                       })
                   .Build();

                var executionContext = GetExecutionContext(service);

                var location = new FakeLocation(Ids.Location);
                var agent = new FakeAgent(Ids.Agent);

                //Fake Session matches all channels and roles
                var workSession = new FakeWorkSession()
                    .WithAgent(agent)
                    .WithLocation(location)
                    .AllowAllChannels()
                    .AllowAllRoles();

                var transactionManagerFactory = Container.Resolve<ITransactionManagerFactory>();
                var transactionManager = transactionManagerFactory.CreateTransactionManager(executionContext);
                var transaction = transactionManager.LoadTransaction(executionContext, Ids.Transaction.ToRecordPointer());

                //Verify starting on Step 1 and can navigate forward but not backward
                var step = transaction.CurrentStep;
                Assert.AreEqual(Ids.Step1_1, step.Id);
                Assert.IsTrue(transaction.CanNavigateForward(workSession));
                Assert.IsFalse(transaction.CanNavigateBackward(workSession));

                //
                //Act: Navigate forward (should land on step 1_3 because step 1_2 is not a UI step.)
                //
                step = transaction.NavigateForward(workSession);

                //Verify navigation succeeded
                Assert.AreEqual(Ids.Step1_3, step.Id);                                         //returned correct step
                Assert.AreEqual(Ids.Step1_3, transaction.CurrentStep.Id);                      //transaction object updated to correct step

                //Verify transaction record updated
                var transactionRecord = service.Retrieve(
                    Ids.Transaction.LogicalName,
                    Ids.Transaction.EntityId,
                    new Microsoft.Xrm.Sdk.Query.ColumnSet(true))
                    .ToEntity<ccllc_transaction>();

                Assert.AreEqual(Ids.Step1_3, transactionRecord.ccllc_CurrentStepId);

                //Verify existing history for step 1_1 updated
                var updatedHistory = service.Retrieve(
                    Ids.History1_1.LogicalName,
                    Ids.History1_1.EntityId,
                    new Microsoft.Xrm.Sdk.Query.ColumnSet(true))
                    .ToEntity<TestProxy.ccllc_stephistory>();

                Assert.AreEqual(Ids.Transaction, updatedHistory.ccllc_TransactionId);                      //not changed
                Assert.AreEqual(Ids.Step1_1, updatedHistory.ccllc_ProcessStepId);                          //not changed
                Assert.IsNotNull(updatedHistory.ccllc_CompletedOn);                                        //logs time of completion
                Assert.AreEqual(Ids.Location, updatedHistory.ccllc_CompletedAtLocationId);                 //logs location where step was completed
                Assert.AreEqual(Ids.Agent, updatedHistory.ccllc_CompletedByAgentId);                       //logs agent that completed step
                Assert.AreEqual(Ids.CreatedHistory1_2, updatedHistory.ccllc_NextRecordId);                 //Linked to next history record
                Assert.AreEqual((int)ccllc_stephistory_statuscode.Current, (int)updatedHistory.statuscode);//Current status

                //Verify new history record for Step 1_2 created for non-UI step with proper linking to preveious and next
                //steps.
                var createdHistory = service.Retrieve(
                    Ids.CreatedHistory1_2.LogicalName,
                    Ids.CreatedHistory1_2.EntityId,
                    new Microsoft.Xrm.Sdk.Query.ColumnSet(true))
                    .ToEntity<TestProxy.ccllc_stephistory>();

                Assert.AreEqual(Ids.Transaction, createdHistory.ccllc_TransactionId);                      //linked to correct transaction
                Assert.AreEqual(Ids.Step1_2, createdHistory.ccllc_ProcessStepId);                          //linked to correct step
                Assert.IsNotNull(createdHistory.ccllc_CompletedOn);                                        //logs time of completion
                Assert.AreEqual(Ids.Location, createdHistory.ccllc_CompletedAtLocationId);                 //not complete
                Assert.AreEqual(Ids.Agent, createdHistory.ccllc_CompletedByAgentId);                       //not complete
                Assert.AreEqual(Ids.History1_1, createdHistory.ccllc_PreviousRecordId);                    //Linked to previous history record
                Assert.AreEqual(Ids.CreatedHistory1_3, createdHistory.ccllc_NextRecordId);                 //Linked to next history record
                Assert.AreEqual((int)ccllc_stephistory_statuscode.Current, (int)createdHistory.statuscode);//Current status

                //Verify new history record for Step 1_3 created and linked back to previous history.
                createdHistory = service.Retrieve(
                    Ids.CreatedHistory1_3.LogicalName,
                    Ids.CreatedHistory1_3.EntityId,
                    new Microsoft.Xrm.Sdk.Query.ColumnSet(true))
                    .ToEntity<TestProxy.ccllc_stephistory>();

                Assert.AreEqual(Ids.Transaction.EntityId, createdHistory.ccllc_TransactionId.Id);          //linked to correct transaction
                Assert.AreEqual(Ids.Step1_3, createdHistory.ccllc_ProcessStepId.Id);                       //linked to correct step
                Assert.IsNull(createdHistory.ccllc_CompletedOn);                                           //not complete
                Assert.IsNull(createdHistory.ccllc_CompletedAtLocationId);                                 //not complete
                Assert.IsNull(createdHistory.ccllc_CompletedByAgentId);                                    //not complete
                Assert.IsNull(createdHistory.ccllc_NextRecordId);                                          //not complete
                Assert.AreEqual(Ids.CreatedHistory1_2, createdHistory.ccllc_PreviousRecordId);             //Linked to previous hisotry step
                Assert.AreEqual((int)ccllc_stephistory_statuscode.Current, (int)createdHistory.statuscode);//Current status

            }
        }

        #endregion NavigateForward_Should_AutomaticallyCompleteNonUISteps

        
        #region NavigateForward_Should_SelectFirstConditionalBranchThatEvaluatesTrue

        [TestMethod]
        public void Test_NavigateForward_Should_SelectFirstConditionalBranchThatEvaluatesTrue()
        {
            new NavigateForward_Should_SelectFirstConditionalBranchThatEvaluatesTrue().Test();
        }

        private class NavigateForward_Should_SelectFirstConditionalBranchThatEvaluatesTrue : Common.TestMethodBase
        {
            private struct Ids
            {
                public static readonly Id Contact = new Id<TestProxy.Contact>("9781F405-3BA2-4733-A6BE-D4B9D55175D6");

                public static readonly Id Agent = new Id<TestProxy.ccllc_agent>("CA24CA35-79D8-4712-9C4B-F7C689FC01B9");

                public static readonly Id Location = new Id<TestProxy.ccllc_location>("594F3624-7E9A-438A-91A0-07E40C3F916F");

                public static readonly Id Channel1 = new Id<TestProxy.ccllc_channel>("EC60DE36-4ACE-46A3-A41B-A85C3B595832");

                public static readonly Id Role1 = new Id<TestProxy.ccllc_role>("71D9C924-51E2-4284-B438-A170198BE414");

                public static readonly Id DataRecordActionEvaluator = new Id<TestProxy.ccllc_evaluatortype>("8A562158-620C-4C13-B75B-AD879DC4B4AA");
               
                public static readonly Id DataFormStepType = new Id<TestProxy.ccllc_processsteptype>("DE8E53F9-3E30-40A8-B619-8F01CA13FF74");               
                public static readonly Id ConditionalStepType = new Id<TestProxy.ccllc_processsteptype>("C9CDDA83-6EC3-497B-8AFA-78981293B0F3");

                public static readonly Id Group1 = new Id<TestProxy.ccllc_transactiongroup>("4F155C0A-6FED-4BD9-B6D8-251EA77E431D");
              

                #region Transaction Type 1

                public static readonly Id TransactionType1 = new Id<TestProxy.ccllc_transactiontype>("1651B659-347D-4A63-B387-6709818550B7");

                public static readonly Id TransactionAuthorizedChannel1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedchannel>("59F97D7C-01AC-4A36-9481-31C895351728");

                public static readonly Id TransactionAuthorizedRole1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedrole>("0487637A-7A92-4368-BCC4-9FB21EE31739");
                             
                public static readonly Id TransactionContext1_1 = new Id<TestProxy.ccllc_transactiontypecontext>("C8B213BF-1A83-44A6-82EB-ACCF43F759A4");

                public static readonly Id Process1 = new Id<TestProxy.ccllc_transactionprocess>("2D579AEB-F8C0-4DCB-922E-9F6C0BF8EC2B");

                public static readonly Id Step1_1 = new Id<TestProxy.ccllc_processstep>("4B057488-4ADF-4CA2-9727-0B35F0B3B3A6");
                public static readonly Id Step1_2 = new Id<TestProxy.ccllc_processstep>("BFA55B6F-1F2C-4075-813F-F7CA682E27F5");
                public static readonly Id Step1_3 = new Id<TestProxy.ccllc_processstep>("53231424-D8CA-471A-A7FE-36FA489ABFC8");
                public static readonly Id Step1_4 = new Id<TestProxy.ccllc_processstep>("FCF5E8E2-44BE-467A-A341-D57379A35DA9");
                public static readonly Id Step1_5 = new Id<TestProxy.ccllc_processstep>("B50BE88A-81C0-4917-BF7A-17DB5ABF851A");
                public static readonly Id Step1_6 = new Id<TestProxy.ccllc_processstep>("BC667EEA-6810-4C72-89C2-587327B0EC38");

                public static readonly Id Branch1_2_1 = new Id<TestProxy.ccllc_alternatebranch>("0875EFE6-FF3B-4B92-94F1-617388B58916");
                public static readonly Id Branch1_2_2 = new Id<TestProxy.ccllc_alternatebranch>("1473FDE3-F7BB-4582-BDEC-D3832F98B3FE");
                public static readonly Id Branch1_2_3 = new Id<TestProxy.ccllc_alternatebranch>("1E48120C-2CB6-4CA4-B2C7-03BDEF8B5D0B");

                #endregion

                public static readonly Id Transaction = new Id<TestProxy.ccllc_transaction>("71F2A99F-D112-421E-811B-3CCC64B9C3CD");
                public static readonly Id DataRecord = new Id<TestProxy.new_transactiondatarecord>("378D5EEE-9E98-4EC9-B633-3DB99AE981E5");
                public static readonly Id History1_1 = new Id<TestProxy.ccllc_stephistory>("B2BC552B-DF1A-4784-A50B-A78FB3E1E82B");

                public static readonly Id CreatedHistory1_2 = new Id<TestProxy.ccllc_stephistory>("B49321A9-2976-41B7-AB62-35B31C463514");
                public static readonly Id CreatedHistory1_3 = new Id<TestProxy.ccllc_stephistory>("936CB15F-C9AE-422F-95B9-4DC19BF33CB5");

            }

            protected override void InitializeTestData(IOrganizationService service)
            {
                try
                {
                    new CrmEnvironmentBuilder()

                    #region Step Type Setup

                        .WithBuilder<ProcessStepTypeBuilder>(Ids.DataFormStepType, b => b
                            .WithImplementatingAssembly("CCLLC.BTF.Process.CDS")
                            .WithImplementatingClass("CCLLC.BTF.Process.StepType.DataForm"))

                        .WithBuilder<ProcessStepTypeBuilder>(Ids.ConditionalStepType, b => b
                            .WithImplementatingAssembly("CCLLC.BTF.Process.CDS")
                            .WithImplementatingClass("CCLLC.BTF.Process.StepType.Branch")
                            .SupportsConditionalBranching())

                    #endregion

                    #region Evaluator Type Setup

                        .WithBuilder<EvaluatorTypeBuilder>(Ids.DataRecordActionEvaluator, b => b
                            .WithImplementatingAssembly("CCLLC.BTF.Process.CDS")
                            .WithImplementatingClass("CCLLC.BTF.Process.CDS.EvaluatorType.DataRecordActionEvaluator"))

                    #endregion

                    #region Transaction Type 1 Setup

                        .WithBuilder<TransactionTypeBuilder>(Ids.TransactionType1, b => b
                            .InGroup(Ids.Group1)
                            .WithDisplayRank(2)
                            .WithDataRecordType("new_transactiondatarecord")
                            .WithStartupProcess(Ids.Process1))

                        .WithBuilder<TransactionChannelBulder>(Ids.TransactionAuthorizedChannel1_1, b => b
                            .ForTransctionType(Ids.TransactionType1)
                            .WithChannel(Ids.Channel1))

                        .WithBuilder<TransactionRoleBuilder>(Ids.TransactionAuthorizedRole1_1, b => b
                            .ForTransactionType(Ids.TransactionType1)
                            .WithRole(Ids.Role1))

                    #endregion

                    #region Process 1 Setup w/ Alternate Branches

                        .WithBuilder<TransactionProcessBuilder>(Ids.Process1, b => b
                            .ForTransactionType(Ids.TransactionType1)
                            .WithInitialStep(Ids.Step1_1))

                        .WithBuilder<ProcessStepBuilder>(Ids.Step1_1, b => b
                            .OfType(Ids.DataFormStepType)
                            .WithParameters("{\"FormId\":\"Step1\"}")
                            .ForProcess(Ids.Process1)
                            .WithSubsequentStep(Ids.Step1_2))

                        //Conditional branch step with default to step 3 if no alternate branches selected
                        .WithBuilder<ProcessStepBuilder>(Ids.Step1_2, b => b
                            .OfType(Ids.ConditionalStepType)                            
                            .ForProcess(Ids.Process1)
                            .WithSubsequentStep(Ids.Step1_3))  

                    #region Alternate Branches for Step 1_2

                         //Evaluate last -> Evaluates True -> Go to step 4
                        .WithBuilder<AlternateBranchBuilder>(Ids.Branch1_2_1, b => b
                            .ForStep(Ids.Step1_2)
                            .WithEvlauationOrder(3)
                            .WithEvaluatorType(Ids.DataRecordActionEvaluator)
                            .WithParameters("{\"EvaluateAs\":\"true\"}")
                            .GoesToStep(Ids.Step1_4))

                        //Evaluate second -> Evaluates True -> Go to step 5
                        .WithBuilder<AlternateBranchBuilder>(Ids.Branch1_2_2, b => b
                            .ForStep(Ids.Step1_2)
                            .WithEvlauationOrder(2)
                            .WithEvaluatorType(Ids.DataRecordActionEvaluator)
                            .WithParameters("{\"EvaluateAs\":\"true\"}")
                            .GoesToStep(Ids.Step1_5))

                        //Evaluate first -> Evaluates false
                        .WithBuilder<AlternateBranchBuilder>(Ids.Branch1_2_3, b => b
                            .ForStep(Ids.Step1_2)
                            .WithEvlauationOrder(1)
                            .WithEvaluatorType(Ids.DataRecordActionEvaluator)
                            .WithParameters("{\"EvaluateAs\":\"false\"}")
                            .GoesToStep(Ids.Step1_6))

                    #endregion

                        .WithBuilder<ProcessStepBuilder>(Ids.Step1_3, b => b
                            .OfType(Ids.DataFormStepType)
                            .WithParameters("{\"FormId\":\"Step3\"}")
                            .ForProcess(Ids.Process1)
                            .WithSubsequentStep(Ids.Step1_4))

                        .WithBuilder<ProcessStepBuilder>(Ids.Step1_4, b => b
                            .OfType(Ids.DataFormStepType)
                            .WithParameters("{\"FormId\":\"Step4\"}")
                            .ForProcess(Ids.Process1)
                            .WithSubsequentStep(Ids.Step1_5))

                        .WithBuilder<ProcessStepBuilder>(Ids.Step1_5, b => b
                            .OfType(Ids.DataFormStepType)
                            .WithParameters("{\"FormId\":\"Step5\"}")
                            .ForProcess(Ids.Process1)
                            .WithSubsequentStep(Ids.Step1_6))

                        .WithBuilder<ProcessStepBuilder>(Ids.Step1_6, b => b
                            .OfType(Ids.DataFormStepType)
                            .WithParameters("{\"FormId\":\"Step6\"}")
                            .ForProcess(Ids.Process1))                           

                    #endregion

                    #region Existing Transaction with Existing Data Record and History

                        .WithBuilder<TransactionBuilder>(Ids.Transaction, b => b
                            .OfTransactionType(Ids.TransactionType1)
                            .ForCustomer(Ids.Contact)
                            .UsingContextRecord(Ids.Contact)
                            .UsingProcess(Ids.Process1)
                            .AtStep(Ids.Step1_1)
                            .WithAgent(Ids.Agent)
                            .WithLocation(Ids.Location))

                        .WithBuilder<TransactionDataRecordBuilder>(Ids.DataRecord, b => b
                            .ForTransaction(Ids.Transaction)
                            .ForCustomer(Ids.Contact))

                        .WithBuilder<StepHistoryBuilder>(Ids.History1_1, b => b
                            .ForTransaction(Ids.Transaction)
                            .ForStep(Ids.Step1_1))

                    #endregion

                        .WithEntities<Ids>()
                        .ExceptEntities(
                            Ids.CreatedHistory1_2,
                            Ids.CreatedHistory1_3)
                        .Create(service);
                }
                catch (Exception ex)
                {
                    this.Logger.WriteLine(ex.Message);
                }
            }

            protected override void Test(IOrganizationService service)
            {
                service = new OrganizationServiceBuilder(service)
                   .WithIdsDefaultedForCreate(
                       Ids.CreatedHistory1_2,
                       Ids.CreatedHistory1_3)
                    .WithFakeExecute((s, r) => {
                        if (r.RequestName == "new_Action")
                        {
                            Assert.AreEqual(Ids.DataRecord.EntityId, (r["Target"] as EntityReference).Id);
                            Assert.AreEqual(Ids.Transaction.EntityId, (r["Transaction"] as EntityReference).Id);
                            OrganizationResponse resp = new OrganizationResponse();
                            resp.Results["IsTrue"] = true;
                            return resp;
                        }
                        return s.Execute(r);
                    })
                   .Build();

                var executionContext = GetExecutionContext(service);

                var location = new FakeLocation(Ids.Location);
                var agent = new FakeAgent(Ids.Agent);

                //Fake Session matches all channels and roles
                var workSession = new FakeWorkSession()
                    .WithAgent(agent)
                    .WithLocation(location)
                    .AllowAllChannels()
                    .AllowAllRoles();

                var transactionManagerFactory = Container.Resolve<ITransactionManagerFactory>();
                var transactionManager = transactionManagerFactory.CreateTransactionManager(executionContext);
                var transaction = transactionManager.LoadTransaction(executionContext, Ids.Transaction.ToRecordPointer());

                //Verify starting on Step 1 and can navigate forward but not backward
                var step = transaction.CurrentStep;
                Assert.AreEqual(Ids.Step1_1, step.Id);
                Assert.IsTrue(transaction.CanNavigateForward(workSession));
                Assert.IsFalse(transaction.CanNavigateBackward(workSession));

                //
                //Act: Navigate forward (should land on step 1_5 due to alternate branching)
                //
                step = transaction.NavigateForward(workSession);

                //Verify navigation succeeded
                Assert.AreEqual(Ids.Step1_5, step.Id);                                         //returned correct step
                Assert.AreEqual(Ids.Step1_5, transaction.CurrentStep.Id);                      //transaction object updated to correct step

                //Verify transaction record updated
                var transactionRecord = service.Retrieve(
                    Ids.Transaction.LogicalName,
                    Ids.Transaction.EntityId,
                    new Microsoft.Xrm.Sdk.Query.ColumnSet(true))
                    .ToEntity<ccllc_transaction>();

                Assert.AreEqual(Ids.Step1_5, transactionRecord.ccllc_CurrentStepId);

                //Verify existing history for step 1_1 updated
                var updatedHistory = service.Retrieve(
                    Ids.History1_1.LogicalName,
                    Ids.History1_1.EntityId,
                    new Microsoft.Xrm.Sdk.Query.ColumnSet(true))
                    .ToEntity<TestProxy.ccllc_stephistory>();

                Assert.AreEqual(Ids.Transaction, updatedHistory.ccllc_TransactionId);                      //not changed
                Assert.AreEqual(Ids.Step1_1, updatedHistory.ccllc_ProcessStepId);                          //not changed
                Assert.IsNotNull(updatedHistory.ccllc_CompletedOn);                                        //logs time of completion
                Assert.AreEqual(Ids.Location, updatedHistory.ccllc_CompletedAtLocationId);                 //logs location where step was completed
                Assert.AreEqual(Ids.Agent, updatedHistory.ccllc_CompletedByAgentId);                       //logs agent that completed step
                Assert.AreEqual(Ids.CreatedHistory1_2, updatedHistory.ccllc_NextRecordId);                 //Linked to next history record
                Assert.AreEqual((int)ccllc_stephistory_statuscode.Current, (int)updatedHistory.statuscode);//Current status

                //Verify new history record for Step 1_2 created for non-UI step with proper linking to preveious and next
                //steps.
                var createdHistory = service.Retrieve(
                    Ids.CreatedHistory1_2.LogicalName,
                    Ids.CreatedHistory1_2.EntityId,
                    new Microsoft.Xrm.Sdk.Query.ColumnSet(true))
                    .ToEntity<TestProxy.ccllc_stephistory>();

                Assert.AreEqual(Ids.Transaction, createdHistory.ccllc_TransactionId);                      //linked to correct transaction
                Assert.AreEqual(Ids.Step1_2, createdHistory.ccllc_ProcessStepId);                          //linked to correct step
                Assert.IsNotNull(createdHistory.ccllc_CompletedOn);                                        //logs time of completion
                Assert.AreEqual(Ids.Location, createdHistory.ccllc_CompletedAtLocationId);                 //not complete
                Assert.AreEqual(Ids.Agent, createdHistory.ccllc_CompletedByAgentId);                       //not complete
                Assert.AreEqual(Ids.History1_1, createdHistory.ccllc_PreviousRecordId);                    //Linked to previous history record
                Assert.AreEqual(Ids.CreatedHistory1_3, createdHistory.ccllc_NextRecordId);                 //Linked to next history record
                Assert.AreEqual((int)ccllc_stephistory_statuscode.Current, (int)createdHistory.statuscode);//Current status

                //Verify new history record for Step 1_5 created and linked back to previous history.
                createdHistory = service.Retrieve(
                    Ids.CreatedHistory1_3.LogicalName,
                    Ids.CreatedHistory1_3.EntityId,
                    new Microsoft.Xrm.Sdk.Query.ColumnSet(true))
                    .ToEntity<TestProxy.ccllc_stephistory>();

                Assert.AreEqual(Ids.Transaction.EntityId, createdHistory.ccllc_TransactionId.Id);          //linked to correct transaction
                Assert.AreEqual(Ids.Step1_5, createdHistory.ccllc_ProcessStepId.Id);                       //linked to correct step
                Assert.IsNull(createdHistory.ccllc_CompletedOn);                                           //not complete
                Assert.IsNull(createdHistory.ccllc_CompletedAtLocationId);                                 //not complete
                Assert.IsNull(createdHistory.ccllc_CompletedByAgentId);                                    //not complete
                Assert.IsNull(createdHistory.ccllc_NextRecordId);                                          //not complete
                Assert.AreEqual(Ids.CreatedHistory1_2, createdHistory.ccllc_PreviousRecordId);             //Linked to previous hisotry step
                Assert.AreEqual((int)ccllc_stephistory_statuscode.Current, (int)createdHistory.statuscode);//Current status

            }
        }


        #endregion NavigateForward_Should_SelectFirstConditionalBranchThatEvaluatesTrue


        #region NavigateForward_Should_SelectDefaultBranchWhenNoAlternateBranchesEvaluatesTrue

        [TestMethod]
        public void Test_NavigateForward_Should_SelectDefaultBranchWhenNoAlternateBranchesEvaluatesTrue()
        {
            new NavigateForward_Should_SelectFirstConditionalBranchThatEvaluatesTrue().Test();
        }

        private class NavigateForward_Should_SelectDefaultBranchWhenNoAlternateBranchesEvaluatesTrue : Common.TestMethodBase
        {
            private struct Ids
            {
                public static readonly Id Contact = new Id<TestProxy.Contact>("9781F405-3BA2-4733-A6BE-D4B9D55175D6");

                public static readonly Id Agent = new Id<TestProxy.ccllc_agent>("CA24CA35-79D8-4712-9C4B-F7C689FC01B9");

                public static readonly Id Location = new Id<TestProxy.ccllc_location>("594F3624-7E9A-438A-91A0-07E40C3F916F");

                public static readonly Id Channel1 = new Id<TestProxy.ccllc_channel>("EC60DE36-4ACE-46A3-A41B-A85C3B595832");

                public static readonly Id Role1 = new Id<TestProxy.ccllc_role>("71D9C924-51E2-4284-B438-A170198BE414");

                public static readonly Id DataRecordActionEvaluator = new Id<TestProxy.ccllc_evaluatortype>("8A562158-620C-4C13-B75B-AD879DC4B4AA");

                public static readonly Id DataFormStepType = new Id<TestProxy.ccllc_processsteptype>("DE8E53F9-3E30-40A8-B619-8F01CA13FF74");
                public static readonly Id ConditionalStepType = new Id<TestProxy.ccllc_processsteptype>("C9CDDA83-6EC3-497B-8AFA-78981293B0F3");

                public static readonly Id Group1 = new Id<TestProxy.ccllc_transactiongroup>("4F155C0A-6FED-4BD9-B6D8-251EA77E431D");


                #region Transaction Type 1

                public static readonly Id TransactionType1 = new Id<TestProxy.ccllc_transactiontype>("1651B659-347D-4A63-B387-6709818550B7");

                public static readonly Id TransactionAuthorizedChannel1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedchannel>("59F97D7C-01AC-4A36-9481-31C895351728");

                public static readonly Id TransactionAuthorizedRole1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedrole>("0487637A-7A92-4368-BCC4-9FB21EE31739");

                public static readonly Id TransactionContext1_1 = new Id<TestProxy.ccllc_transactiontypecontext>("C8B213BF-1A83-44A6-82EB-ACCF43F759A4");

                public static readonly Id Process1 = new Id<TestProxy.ccllc_transactionprocess>("2D579AEB-F8C0-4DCB-922E-9F6C0BF8EC2B");

                public static readonly Id Step1_1 = new Id<TestProxy.ccllc_processstep>("4B057488-4ADF-4CA2-9727-0B35F0B3B3A6");
                public static readonly Id Step1_2 = new Id<TestProxy.ccllc_processstep>("BFA55B6F-1F2C-4075-813F-F7CA682E27F5");
                public static readonly Id Step1_3 = new Id<TestProxy.ccllc_processstep>("53231424-D8CA-471A-A7FE-36FA489ABFC8");
                public static readonly Id Step1_4 = new Id<TestProxy.ccllc_processstep>("FCF5E8E2-44BE-467A-A341-D57379A35DA9");
                public static readonly Id Step1_5 = new Id<TestProxy.ccllc_processstep>("B50BE88A-81C0-4917-BF7A-17DB5ABF851A");
                public static readonly Id Step1_6 = new Id<TestProxy.ccllc_processstep>("BC667EEA-6810-4C72-89C2-587327B0EC38");

                public static readonly Id Branch1_2_1 = new Id<TestProxy.ccllc_alternatebranch>("0875EFE6-FF3B-4B92-94F1-617388B58916");
                public static readonly Id Branch1_2_2 = new Id<TestProxy.ccllc_alternatebranch>("1473FDE3-F7BB-4582-BDEC-D3832F98B3FE");
                public static readonly Id Branch1_2_3 = new Id<TestProxy.ccllc_alternatebranch>("1E48120C-2CB6-4CA4-B2C7-03BDEF8B5D0B");

                #endregion

                public static readonly Id Transaction = new Id<TestProxy.ccllc_transaction>("71F2A99F-D112-421E-811B-3CCC64B9C3CD");
                public static readonly Id DataRecord = new Id<TestProxy.new_transactiondatarecord>("378D5EEE-9E98-4EC9-B633-3DB99AE981E5");
                public static readonly Id History1_1 = new Id<TestProxy.ccllc_stephistory>("B2BC552B-DF1A-4784-A50B-A78FB3E1E82B");

                public static readonly Id CreatedHistory1_2 = new Id<TestProxy.ccllc_stephistory>("B49321A9-2976-41B7-AB62-35B31C463514");
                public static readonly Id CreatedHistory1_3 = new Id<TestProxy.ccllc_stephistory>("936CB15F-C9AE-422F-95B9-4DC19BF33CB5");

            }

            protected override void InitializeTestData(IOrganizationService service)
            {
                try
                {
                    new CrmEnvironmentBuilder()

                    #region Step Type Setup

                        .WithBuilder<ProcessStepTypeBuilder>(Ids.DataFormStepType, b => b
                            .WithImplementatingAssembly("CCLLC.BTF.Process.CDS")
                            .WithImplementatingClass("CCLLC.BTF.Process.StepType.DataForm"))

                        .WithBuilder<ProcessStepTypeBuilder>(Ids.ConditionalStepType, b => b
                            .WithImplementatingAssembly("CCLLC.BTF.Process.CDS")
                            .WithImplementatingClass("CCLLC.BTF.Process.StepType.Branch")
                            .SupportsConditionalBranching())

                    #endregion

                    #region Evaluator Type Setup

                        .WithBuilder<EvaluatorTypeBuilder>(Ids.DataRecordActionEvaluator, b => b
                            .WithImplementatingAssembly("CCLLC.BTF.Process.CDS")
                            .WithImplementatingClass("CCLLC.BTF.Process.CDS.EvaluatorType.DataRecordActionEvaluator"))

                    #endregion

                    #region Transaction Type 1 Setup

                        .WithBuilder<TransactionTypeBuilder>(Ids.TransactionType1, b => b
                            .InGroup(Ids.Group1)
                            .WithDisplayRank(2)
                            .WithDataRecordType("new_transactiondatarecord")
                            .WithStartupProcess(Ids.Process1))

                        .WithBuilder<TransactionChannelBulder>(Ids.TransactionAuthorizedChannel1_1, b => b
                            .ForTransctionType(Ids.TransactionType1)
                            .WithChannel(Ids.Channel1))

                        .WithBuilder<TransactionRoleBuilder>(Ids.TransactionAuthorizedRole1_1, b => b
                            .ForTransactionType(Ids.TransactionType1)
                            .WithRole(Ids.Role1))

                    #endregion

                    #region Process 1 Setup w/ Alternate Branches

                        .WithBuilder<TransactionProcessBuilder>(Ids.Process1, b => b
                            .ForTransactionType(Ids.TransactionType1)
                            .WithInitialStep(Ids.Step1_1))

                        .WithBuilder<ProcessStepBuilder>(Ids.Step1_1, b => b
                            .OfType(Ids.DataFormStepType)
                            .WithParameters("{\"FormId\":\"Step1\"}")
                            .ForProcess(Ids.Process1)
                            .WithSubsequentStep(Ids.Step1_2))

                        //Conditional branch step with default to step 3 if no alternate branches selected
                        .WithBuilder<ProcessStepBuilder>(Ids.Step1_2, b => b
                            .OfType(Ids.ConditionalStepType)
                            .ForProcess(Ids.Process1)
                            .WithSubsequentStep(Ids.Step1_3))

                    #region Alternate Branches for Step 1_2

                        //Evaluate last -> Evaluates flase
                        .WithBuilder<AlternateBranchBuilder>(Ids.Branch1_2_1, b => b
                            .ForStep(Ids.Step1_2)
                            .WithEvlauationOrder(3)
                            .WithEvaluatorType(Ids.DataRecordActionEvaluator)
                            .WithParameters("{\"EvaluateAs\":\"false\"}")
                            .GoesToStep(Ids.Step1_4))

                        //Evaluate second -> Evaluates false
                        .WithBuilder<AlternateBranchBuilder>(Ids.Branch1_2_2, b => b
                            .ForStep(Ids.Step1_2)
                            .WithEvlauationOrder(2)
                            .WithEvaluatorType(Ids.DataRecordActionEvaluator)
                            .WithParameters("{\"EvaluateAs\":\"false\"}")
                            .GoesToStep(Ids.Step1_5))

                        //Evaluate first -> Evaluates false
                        .WithBuilder<AlternateBranchBuilder>(Ids.Branch1_2_3, b => b
                            .ForStep(Ids.Step1_2)
                            .WithEvlauationOrder(1)
                            .WithEvaluatorType(Ids.DataRecordActionEvaluator)
                            .WithParameters("{\"EvaluateAs\":\"false\"}")
                            .GoesToStep(Ids.Step1_6))

                    #endregion

                        .WithBuilder<ProcessStepBuilder>(Ids.Step1_3, b => b
                            .OfType(Ids.DataFormStepType)
                            .WithParameters("{\"FormId\":\"Step3\"}")
                            .ForProcess(Ids.Process1)
                            .WithSubsequentStep(Ids.Step1_4))

                        .WithBuilder<ProcessStepBuilder>(Ids.Step1_4, b => b
                            .OfType(Ids.DataFormStepType)
                            .WithParameters("{\"FormId\":\"Step4\"}")
                            .ForProcess(Ids.Process1)
                            .WithSubsequentStep(Ids.Step1_5))

                        .WithBuilder<ProcessStepBuilder>(Ids.Step1_5, b => b
                            .OfType(Ids.DataFormStepType)
                            .WithParameters("{\"FormId\":\"Step5\"}")
                            .ForProcess(Ids.Process1)
                            .WithSubsequentStep(Ids.Step1_6))

                        .WithBuilder<ProcessStepBuilder>(Ids.Step1_6, b => b
                            .OfType(Ids.DataFormStepType)
                            .WithParameters("{\"FormId\":\"Step6\"}")
                            .ForProcess(Ids.Process1))

                    #endregion

                    #region Existing Transaction with Existing Data Record and History

                        .WithBuilder<TransactionBuilder>(Ids.Transaction, b => b
                            .OfTransactionType(Ids.TransactionType1)
                            .ForCustomer(Ids.Contact)
                            .UsingContextRecord(Ids.Contact)
                            .UsingProcess(Ids.Process1)
                            .AtStep(Ids.Step1_1)
                            .WithAgent(Ids.Agent)
                            .WithLocation(Ids.Location))

                        .WithBuilder<TransactionDataRecordBuilder>(Ids.DataRecord, b => b
                            .ForTransaction(Ids.Transaction)
                            .ForCustomer(Ids.Contact))

                        .WithBuilder<StepHistoryBuilder>(Ids.History1_1, b => b
                            .ForTransaction(Ids.Transaction)
                            .ForStep(Ids.Step1_1))

                    #endregion

                        .WithEntities<Ids>()
                        .ExceptEntities(
                            Ids.CreatedHistory1_2,
                            Ids.CreatedHistory1_3)
                        .Create(service);
                }
                catch (Exception ex)
                {
                    this.Logger.WriteLine(ex.Message);
                }
            }

            protected override void Test(IOrganizationService service)
            {
                service = new OrganizationServiceBuilder(service)
                   .WithIdsDefaultedForCreate(
                       Ids.CreatedHistory1_2,
                       Ids.CreatedHistory1_3)
                    .WithFakeExecute((s, r) => {
                        if (r.RequestName == "new_Action")
                        {
                            Assert.AreEqual(Ids.DataRecord.EntityId, (r["Target"] as EntityReference).Id);
                            Assert.AreEqual(Ids.Transaction.EntityId, (r["Transaction"] as EntityReference).Id);
                            OrganizationResponse resp = new OrganizationResponse();
                            resp.Results["IsTrue"] = true;
                            return resp;
                        }
                        return s.Execute(r);
                    })
                   .Build();

                var executionContext = GetExecutionContext(service);

                var location = new FakeLocation(Ids.Location);
                var agent = new FakeAgent(Ids.Agent);

                //Fake Session matches all channels and roles
                var workSession = new FakeWorkSession()
                    .WithAgent(agent)
                    .WithLocation(location)
                    .AllowAllChannels()
                    .AllowAllRoles();

                var transactionManagerFactory = Container.Resolve<ITransactionManagerFactory>();
                var transactionManager = transactionManagerFactory.CreateTransactionManager(executionContext);
                var transaction = transactionManager.LoadTransaction(executionContext, Ids.Transaction.ToRecordPointer());

                //Verify starting on Step 1 and can navigate forward but not backward
                var step = transaction.CurrentStep;
                Assert.AreEqual(Ids.Step1_1, step.Id);
                Assert.IsTrue(transaction.CanNavigateForward(workSession));
                Assert.IsFalse(transaction.CanNavigateBackward(workSession));

                //
                //Act: Navigate forward (should land on step 1_3 due to no alternate branches evaluating true)
                //
                step = transaction.NavigateForward(workSession);

                //Verify navigation succeeded
                Assert.AreEqual(Ids.Step1_3, step.Id);                                         //returned correct step
                Assert.AreEqual(Ids.Step1_3, transaction.CurrentStep.Id);                      //transaction object updated to correct step

                //Verify transaction record updated
                var transactionRecord = service.Retrieve(
                    Ids.Transaction.LogicalName,
                    Ids.Transaction.EntityId,
                    new Microsoft.Xrm.Sdk.Query.ColumnSet(true))
                    .ToEntity<ccllc_transaction>();

                Assert.AreEqual(Ids.Step1_3, transactionRecord.ccllc_CurrentStepId);

                //Verify existing history for step 1_1 updated
                var updatedHistory = service.Retrieve(
                    Ids.History1_1.LogicalName,
                    Ids.History1_1.EntityId,
                    new Microsoft.Xrm.Sdk.Query.ColumnSet(true))
                    .ToEntity<TestProxy.ccllc_stephistory>();

                Assert.AreEqual(Ids.Transaction, updatedHistory.ccllc_TransactionId);                      //not changed
                Assert.AreEqual(Ids.Step1_1, updatedHistory.ccllc_ProcessStepId);                          //not changed
                Assert.IsNotNull(updatedHistory.ccllc_CompletedOn);                                        //logs time of completion
                Assert.AreEqual(Ids.Location, updatedHistory.ccllc_CompletedAtLocationId);                 //logs location where step was completed
                Assert.AreEqual(Ids.Agent, updatedHistory.ccllc_CompletedByAgentId);                       //logs agent that completed step
                Assert.AreEqual(Ids.CreatedHistory1_2, updatedHistory.ccllc_NextRecordId);                 //Linked to next history record
                Assert.AreEqual((int)ccllc_stephistory_statuscode.Current, (int)updatedHistory.statuscode);//Current status

                //Verify new history record for Step 1_2 created for non-UI step with proper linking to preveious and next
                //steps.
                var createdHistory = service.Retrieve(
                    Ids.CreatedHistory1_2.LogicalName,
                    Ids.CreatedHistory1_2.EntityId,
                    new Microsoft.Xrm.Sdk.Query.ColumnSet(true))
                    .ToEntity<TestProxy.ccllc_stephistory>();

                Assert.AreEqual(Ids.Transaction, createdHistory.ccllc_TransactionId);                      //linked to correct transaction
                Assert.AreEqual(Ids.Step1_2, createdHistory.ccllc_ProcessStepId);                          //linked to correct step
                Assert.IsNotNull(createdHistory.ccllc_CompletedOn);                                        //logs time of completion
                Assert.AreEqual(Ids.Location, createdHistory.ccllc_CompletedAtLocationId);                 //not complete
                Assert.AreEqual(Ids.Agent, createdHistory.ccllc_CompletedByAgentId);                       //not complete
                Assert.AreEqual(Ids.History1_1, createdHistory.ccllc_PreviousRecordId);                    //Linked to previous history record
                Assert.AreEqual(Ids.CreatedHistory1_3, createdHistory.ccllc_NextRecordId);                 //Linked to next history record
                Assert.AreEqual((int)ccllc_stephistory_statuscode.Current, (int)createdHistory.statuscode);//Current status

                //Verify new history record for Step 1_3 created and linked back to previous history.
                createdHistory = service.Retrieve(
                    Ids.CreatedHistory1_3.LogicalName,
                    Ids.CreatedHistory1_3.EntityId,
                    new Microsoft.Xrm.Sdk.Query.ColumnSet(true))
                    .ToEntity<TestProxy.ccllc_stephistory>();

                Assert.AreEqual(Ids.Transaction.EntityId, createdHistory.ccllc_TransactionId.Id);          //linked to correct transaction
                Assert.AreEqual(Ids.Step1_3, createdHistory.ccllc_ProcessStepId.Id);                       //linked to correct step
                Assert.IsNull(createdHistory.ccllc_CompletedOn);                                           //not complete
                Assert.IsNull(createdHistory.ccllc_CompletedAtLocationId);                                 //not complete
                Assert.IsNull(createdHistory.ccllc_CompletedByAgentId);                                    //not complete
                Assert.IsNull(createdHistory.ccllc_NextRecordId);                                          //not complete
                Assert.AreEqual(Ids.CreatedHistory1_2, createdHistory.ccllc_PreviousRecordId);             //Linked to previous hisotry step
                Assert.AreEqual((int)ccllc_stephistory_statuscode.Current, (int)createdHistory.statuscode);//Current status

            }
        }


        #endregion NavigateForward_Should_SelectDefaultBranchWhenNoAlternateBranchesEvaluatesTrue
    }
}
