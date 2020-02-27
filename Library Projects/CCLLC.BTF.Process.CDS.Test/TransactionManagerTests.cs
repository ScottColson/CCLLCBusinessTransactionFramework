using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using FakeItEasy;
using DLaB.Xrm.Test;
using CCLLC.Core;
using CCLLC.BTF.Platform;
using CCLLC.CDS.Test.Builders;
using CCLLC.CDS.Test.Fakes;
using CCLLC.CDS.TestBase;


namespace CCLLC.BTF.Process.CDS.Test
{
    [TestClass]
    public class TransactionManagerTests
    {
        #region GetAvailableTransactions_Should_FilterOnContextRecord

        [TestMethod]
        public void Test_GetAvailableTransactions_Should_FilterOnContextRecord()
        {
            new GetAvailableTransactions_Should_FilterOnContextRecord().Test();
        }
      
        private class GetAvailableTransactions_Should_FilterOnContextRecord : Common.TestMethodBase
        {
           
            private struct Ids
            {
                public static readonly Id<TestProxy.Contact> Contact = new Id<TestProxy.Contact>("8713F982-5C62-4B82-984A-6717FD918EB8");

                public static readonly Id<TestProxy.Account> Account = new Id<TestProxy.Account>("BF69B94D-842D-4FC8-9DDA-1771C4C85F00");

                public static readonly Id<TestProxy.ccllc_channel> Channel1 = new Id<TestProxy.ccllc_channel>("DEB16DB0-7870-4D7F-B67A-434234E5A093");               

                public static readonly Id<TestProxy.ccllc_role> Role1 = new Id<TestProxy.ccllc_role>("3C8C6FB0-E8EA-4880-8AD7-A9665A11E0E0");
                
                public static readonly Id<TestProxy.ccllc_transactiongroup> Group1 = new Id<TestProxy.ccllc_transactiongroup>("935A97F8-2865-4C2B-83B8-3362222DC5D9");
               
                public static readonly Id<TestProxy.ccllc_processsteptype> DataFormStepType = new Id<TestProxy.ccllc_processsteptype>("7CED7358-EA2E-430D-B7E5-FB77160FB0C6");
               
                #region Transaction Type 1

                public static readonly Id<TestProxy.ccllc_transactiontype> TransactionType1 = new Id<TestProxy.ccllc_transactiontype>("801AFD70-B737-4764-9DDD-01DC5E51EDE7");

                public static readonly Id<TestProxy.ccllc_transactiontypeauthorizedchannel> TransactionAuthorizedChannel1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedchannel>("73E5610D-1406-4142-88F3-B3566E621F83");
               
                public static readonly Id<TestProxy.ccllc_transactiontypeauthorizedrole> TransactionAuthorizedRole1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedrole>("9CB4EA3E-8D80-4D5B-A623-4BD9D364A9DE");

                public static readonly Id<TestProxy.ccllc_transactiontypecontext> TransactionContext1_1 = new Id<TestProxy.ccllc_transactiontypecontext>("49E25CC9-B88B-4882-9FFA-CBB7602B7EA1");

                public static readonly Id<TestProxy.ccllc_transactionprocess> Process1 = new Id<TestProxy.ccllc_transactionprocess>("480B401D-47EB-4F63-BFF7-0A2BEAB5776C");

                public static readonly Id<TestProxy.ccllc_processstep> Step1_1 = new Id<TestProxy.ccllc_processstep>("2524A076-8C4F-4786-BEA3-A3235DF18A65");

                #endregion

                #region Transaction Type 2

                public static readonly Id<TestProxy.ccllc_transactiontype> TransactionType2 = new Id<TestProxy.ccllc_transactiontype>("EDD81A90-4756-4908-89C4-758695155856");

                public static readonly Id<TestProxy.ccllc_transactiontypeauthorizedchannel> TransactionAuthorizedChannel2_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedchannel>("5C5E02BB-2998-4757-B1AC-B6B7409D65B2");

                public static readonly Id<TestProxy.ccllc_transactiontypeauthorizedrole> TransactionAuthorizedRole2_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedrole>("7B64749E-ED63-45E7-8727-489459B7726F");

                public static readonly Id<TestProxy.ccllc_transactiontypecontext> TransactionContext2_1 = new Id<TestProxy.ccllc_transactiontypecontext>("CF6E4186-74E8-476B-89CC-50AC24AE1038");

                public static readonly Id<TestProxy.ccllc_transactionprocess> Process2 = new Id<TestProxy.ccllc_transactionprocess>("C2E6319A-6C33-4F18-9A50-B3B51ED746B3");

                public static readonly Id<TestProxy.ccllc_processstep> Step2_1 = new Id<TestProxy.ccllc_processstep>("DC30D360-2353-4CE1-B99C-BBCB1618C70A");

                #endregion

                #region Transaction Type 3

                public static readonly Id<TestProxy.ccllc_transactiontype> TransactionType3 = new Id<TestProxy.ccllc_transactiontype>("30781A78-D62C-4829-8306-499966588C9C");

                public static readonly Id<TestProxy.ccllc_transactiontypeauthorizedchannel> TransactionAuthorizedChannel3_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedchannel>("30FA8C74-0C24-4A76-9E0C-9F3DBE39AC71");

                public static readonly Id<TestProxy.ccllc_transactiontypeauthorizedrole> TransactionAuthorizedRole3_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedrole>("CBBEFB9D-12F6-43AA-BB7D-CB119808ED66");

                public static readonly Id<TestProxy.ccllc_transactiontypecontext> TransactionContext3_1 = new Id<TestProxy.ccllc_transactiontypecontext>("A821E9AF-5A18-405C-87E5-40D5A8459002");

                public static readonly Id<TestProxy.ccllc_transactionprocess> Process3 = new Id<TestProxy.ccllc_transactionprocess>("8598ADD7-96F0-4FC1-A1B3-B4CAF3A38B75");

                public static readonly Id<TestProxy.ccllc_processstep> Step3_1 = new Id<TestProxy.ccllc_processstep>("90B5B2FC-9E2F-4E45-9046-071F3581A561");

                #endregion

            }
            
            protected override void InitializeTestData(IOrganizationService service)
            {
                new CrmEnvironmentBuilder()

                #region Step Type Setup

                       .WithBuilder<ProcessStepTypeBuilder>(Ids.DataFormStepType, b => b
                           .WithImplementatingAssembly("CCLLC.BTF.Process.CDS")
                           .WithImplementatingClass("CCLLC.BTF.Process.StepType.DataForm"))

                #endregion

                #region Transaction Type 1 (Contact Context)

                       .WithBuilder<TransactionTypeBuilder>(Ids.TransactionType1, b => b
                           .InGroup(Ids.Group1)
                           .WithDisplayRank(2)
                           .WithDataRecordType("new_dataentity")
                           .WithStartupProcess(Ids.Process1))

                       .WithBuilder<TransactionChannelBulder>(Ids.TransactionAuthorizedChannel1_1, b => b
                           .ForTransctionType(Ids.TransactionType1)
                           .WithChannel(Ids.Channel1))                       

                       .WithBuilder<TransactionRoleBuilder>(Ids.TransactionAuthorizedRole1_1, b => b
                           .ForTransactionType(Ids.TransactionType1)
                           .WithRole(Ids.Role1))           
                           
                        .WithBuilder<TransactionTypeContextBuilder>(Ids.TransactionContext1_1, b => b
                            .ForTransactionType(Ids.TransactionType1)
                            .WithEntityType("contact"))
                            
                       .WithBuilder<TransactionProcessBuilder>(Ids.Process1, b => b
                           .ForTransactionType(Ids.TransactionType1)
                           .WithInitialStep(Ids.Step1_1))

                       .WithBuilder<ProcessStepBuilder>(Ids.Step1_1, b => b
                           .OfType(Ids.DataFormStepType)
                           .WithParameters("{\"FormId\":\"Step1\"}")
                           .ForProcess(Ids.Process1))

                #endregion

                #region Transaction Type 2 (Account Context)

                       .WithBuilder<TransactionTypeBuilder>(Ids.TransactionType2, b => b
                           .InGroup(Ids.Group1)
                           .WithDisplayRank(2)
                           .WithDataRecordType("new_dataentity")
                           .WithStartupProcess(Ids.Process1))

                       .WithBuilder<TransactionChannelBulder>(Ids.TransactionAuthorizedChannel2_1, b => b
                           .ForTransctionType(Ids.TransactionType2)
                           .WithChannel(Ids.Channel1))

                       .WithBuilder<TransactionRoleBuilder>(Ids.TransactionAuthorizedRole2_1, b => b
                           .ForTransactionType(Ids.TransactionType2)
                           .WithRole(Ids.Role1))

                        .WithBuilder<TransactionTypeContextBuilder>(Ids.TransactionContext2_1, b => b
                            .ForTransactionType(Ids.TransactionType2)
                            .WithEntityType("account"))

                       .WithBuilder<TransactionProcessBuilder>(Ids.Process2, b => b
                           .ForTransactionType(Ids.TransactionType2)
                           .WithInitialStep(Ids.Step2_1))

                       .WithBuilder<ProcessStepBuilder>(Ids.Step2_1, b => b
                           .OfType(Ids.DataFormStepType)
                           .WithParameters("{\"FormId\":\"Step1\"}")
                           .ForProcess(Ids.Process1))

                #endregion

                #region Transaction Type 3 (Contact Context)

                       .WithBuilder<TransactionTypeBuilder>(Ids.TransactionType3, b => b
                           .InGroup(Ids.Group1)
                           .WithDisplayRank(2)
                           .WithDataRecordType("new_dataentity")
                           .WithStartupProcess(Ids.Process3))

                       .WithBuilder<TransactionChannelBulder>(Ids.TransactionAuthorizedChannel3_1, b => b
                           .ForTransctionType(Ids.TransactionType3)
                           .WithChannel(Ids.Channel1))

                       .WithBuilder<TransactionRoleBuilder>(Ids.TransactionAuthorizedRole3_1, b => b
                           .ForTransactionType(Ids.TransactionType3)
                           .WithRole(Ids.Role1))

                        .WithBuilder<TransactionTypeContextBuilder>(Ids.TransactionContext3_1, b => b
                            .ForTransactionType(Ids.TransactionType3)
                            .WithEntityType("contact"))

                       .WithBuilder<TransactionProcessBuilder>(Ids.Process3, b => b
                           .ForTransactionType(Ids.TransactionType3)
                           .WithInitialStep(Ids.Step3_1))

                       .WithBuilder<ProcessStepBuilder>(Ids.Step3_1, b => b
                           .OfType(Ids.DataFormStepType)
                           .WithParameters("{\"FormId\":\"Step1\"}")
                           .ForProcess(Ids.Process3))

                #endregion

                       .WithEntities<Ids>()
                       .Create(service);
            }

            protected override void Test(IOrganizationService service)
            {
                var executionContext = GetExecutionContext(service);

                //Fake worksession filter will match any customer, role, or channel
                var workSession = A.Fake<IWorkSession>();
                A.CallTo(workSession).WithReturnType<bool>().Returns(true);               

                var transactionManagerFactory = Container.Resolve<ITransactionManagerFactory>();
                var transactionManager = transactionManagerFactory.CreateTransactionManager(executionContext);

                //Generate context based on contact
                var contextFactory = Container.Resolve<ITransactionContextFactory>();
                var customerId = new RecordPointer<Guid>(Ids.Contact.LogicalName, Ids.Contact.EntityId);               
                var contextRecord = contextFactory.CreateTransactionContext(executionContext, customerId);

                //Two transactions match contact context
                var transactionTypes = transactionManager.GetAvaialbleTransactionTypes(executionContext, workSession, contextRecord);
                Assert.AreEqual(2, transactionTypes.Count);

                //Generate context based on account 
                customerId = new RecordPointer<Guid>(Ids.Account.LogicalName, Ids.Account.EntityId);
                contextRecord = contextFactory.CreateTransactionContext(executionContext, customerId);

                //One transaction matches account context
                transactionTypes = transactionManager.GetAvaialbleTransactionTypes(executionContext, workSession, contextRecord);
                Assert.AreEqual(1, transactionTypes.Count);

            }


        }

        #endregion GetAvailableTransactions_Should_FilterOnContextRecord


        #region GetAvailableTransactions_Should_FilterByAgentRole

        [TestMethod]
        public void Test_GetAvailableTransactions_Should_FilterByAgentRole()
        {
            new GetAvailableTransactions_Should_FilterByAgentRole().Test();
        }

        private class GetAvailableTransactions_Should_FilterByAgentRole : Common.TestMethodBase
        {

            private struct Ids
            {
                public static readonly Id<TestProxy.Contact> Contact = new Id<TestProxy.Contact>("022CD264-A5D8-44D5-BB48-1C20C04D0902");

                public static readonly Id<TestProxy.Account> Account = new Id<TestProxy.Account>("34DEAB5B-3543-48EA-BA6B-E1610E3C30BC");

                public static readonly Id<TestProxy.ccllc_channel> Channel1 = new Id<TestProxy.ccllc_channel>("81A3D13B-B4C5-416C-BC57-08AA44B62476");

                public static readonly Id<TestProxy.ccllc_role> Role1 = new Id<TestProxy.ccllc_role>("9AC0BF27-922E-442F-976C-A3E636EE8DAF");
                public static readonly Id<TestProxy.ccllc_role> Role2 = new Id<TestProxy.ccllc_role>("A465195A-5EF8-4CFE-8BB3-2D253B047326");
                public static readonly Id<TestProxy.ccllc_role> Role3 = new Id<TestProxy.ccllc_role>("C36050E9-891C-4B82-B0B5-7175891E9A63");

                public static readonly Id<TestProxy.ccllc_transactiongroup> Group1 = new Id<TestProxy.ccllc_transactiongroup>("274ABC5C-C3FE-4538-A9CB-0537E5549A90");

                public static readonly Id<TestProxy.ccllc_processsteptype> DataFormStepType = new Id<TestProxy.ccllc_processsteptype>("FAA34F2D-2F65-4FF4-B0C6-5E878637E8A1");

                #region Transaction Type 1

                public static readonly Id<TestProxy.ccllc_transactiontype> TransactionType1 = new Id<TestProxy.ccllc_transactiontype>("52C24DA0-A1C7-417A-89AF-1EF585962718");

                public static readonly Id<TestProxy.ccllc_transactiontypeauthorizedchannel> TransactionAuthorizedChannel1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedchannel>("CD541941-E153-47BF-A392-B3C92CA9C1CD");

                public static readonly Id<TestProxy.ccllc_transactiontypeauthorizedrole> TransactionAuthorizedRole1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedrole>("44CFAF3B-A2A9-411C-97F7-4AF1D96B3D17");

                public static readonly Id<TestProxy.ccllc_transactiontypecontext> TransactionContext1_1 = new Id<TestProxy.ccllc_transactiontypecontext>("B5CA9D20-646E-436C-AA7D-D5A634C6D4EA");

                public static readonly Id<TestProxy.ccllc_transactionprocess> Process1 = new Id<TestProxy.ccllc_transactionprocess>("F1C973B4-C0FC-4195-8EDF-3543C8250516");

                public static readonly Id<TestProxy.ccllc_processstep> Step1_1 = new Id<TestProxy.ccllc_processstep>("DBC26FA9-7697-4387-8F73-D1DC91EA6FDC");

                #endregion

                #region Transaction Type 2

                public static readonly Id<TestProxy.ccllc_transactiontype> TransactionType2 = new Id<TestProxy.ccllc_transactiontype>("B1B048AE-8F53-429A-800C-C73435E90508");

                public static readonly Id<TestProxy.ccllc_transactiontypeauthorizedchannel> TransactionAuthorizedChannel2_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedchannel>("D7F7E819-8574-4275-B901-6E2A03D1E63A");

                public static readonly Id<TestProxy.ccllc_transactiontypeauthorizedrole> TransactionAuthorizedRole2_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedrole>("977F796A-C63B-492A-A40E-675A22602C95");

                public static readonly Id<TestProxy.ccllc_transactiontypecontext> TransactionContext2_1 = new Id<TestProxy.ccllc_transactiontypecontext>("149C68B3-B2B1-4043-AE75-2125F7E9EBE5");

                public static readonly Id<TestProxy.ccllc_transactionprocess> Process2 = new Id<TestProxy.ccllc_transactionprocess>("8ED5BC46-EDA3-45CA-8054-B274D8696AEA");

                public static readonly Id<TestProxy.ccllc_processstep> Step2_1 = new Id<TestProxy.ccllc_processstep>("A9D891E6-447D-4F24-893E-DEEBEB6D8D82");

                #endregion

                #region Transaction Type 3

                public static readonly Id<TestProxy.ccllc_transactiontype> TransactionType3 = new Id<TestProxy.ccllc_transactiontype>("4DA0656F-070F-4475-A6E0-1E12170FDE5F");

                public static readonly Id<TestProxy.ccllc_transactiontypeauthorizedchannel> TransactionAuthorizedChannel3_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedchannel>("9A592376-7FF3-4686-AFAE-635D7EDE01D3");

                public static readonly Id<TestProxy.ccllc_transactiontypeauthorizedrole> TransactionAuthorizedRole3_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedrole>("915DFBE3-A776-4557-87C4-CA293E38D072");

                public static readonly Id<TestProxy.ccllc_transactiontypecontext> TransactionContext3_1 = new Id<TestProxy.ccllc_transactiontypecontext>("1CAD164C-09A4-443C-990A-5DE1534FE0A2");

                public static readonly Id<TestProxy.ccllc_transactionprocess> Process3 = new Id<TestProxy.ccllc_transactionprocess>("1B1B42DD-8F4D-4722-AE82-55BBB75A303B");

                public static readonly Id<TestProxy.ccllc_processstep> Step3_1 = new Id<TestProxy.ccllc_processstep>("B732CA81-0864-4070-A3B6-514873232988");

                #endregion

            }


            protected override void InitializeTestData(IOrganizationService service)
            {
                new CrmEnvironmentBuilder()

                #region Step Type Setup

                       .WithBuilder<ProcessStepTypeBuilder>(Ids.DataFormStepType, b => b
                           .WithImplementatingAssembly("CCLLC.BTF.Process.CDS")
                           .WithImplementatingClass("CCLLC.BTF.Process.StepType.DataForm"))

                #endregion

                #region Transaction Type 1 (Contact Context)

                       .WithBuilder<TransactionTypeBuilder>(Ids.TransactionType1, b => b
                           .InGroup(Ids.Group1)
                           .WithDisplayRank(2)
                           .WithDataRecordType("new_dataentity")
                           .WithStartupProcess(Ids.Process1))

                       .WithBuilder<TransactionChannelBulder>(Ids.TransactionAuthorizedChannel1_1, b => b
                           .ForTransctionType(Ids.TransactionType1)
                           .WithChannel(Ids.Channel1))

                       .WithBuilder<TransactionRoleBuilder>(Ids.TransactionAuthorizedRole1_1, b => b
                           .ForTransactionType(Ids.TransactionType1)
                           .WithRole(Ids.Role1))

                        .WithBuilder<TransactionTypeContextBuilder>(Ids.TransactionContext1_1, b => b
                            .ForTransactionType(Ids.TransactionType1)
                            .WithEntityType("contact"))

                       .WithBuilder<TransactionProcessBuilder>(Ids.Process1, b => b
                           .ForTransactionType(Ids.TransactionType1)
                           .WithInitialStep(Ids.Step1_1))

                       .WithBuilder<ProcessStepBuilder>(Ids.Step1_1, b => b
                           .OfType(Ids.DataFormStepType)
                           .WithParameters("{\"FormId\":\"Step1\"}")
                           .ForProcess(Ids.Process1))

                #endregion

                #region Transaction Type 2 (Account Context)

                       .WithBuilder<TransactionTypeBuilder>(Ids.TransactionType2, b => b
                           .InGroup(Ids.Group1)
                           .WithDisplayRank(2)
                           .WithDataRecordType("new_dataentity")
                           .WithStartupProcess(Ids.Process1))

                       .WithBuilder<TransactionChannelBulder>(Ids.TransactionAuthorizedChannel2_1, b => b
                           .ForTransctionType(Ids.TransactionType2)
                           .WithChannel(Ids.Channel1))

                       .WithBuilder<TransactionRoleBuilder>(Ids.TransactionAuthorizedRole2_1, b => b
                           .ForTransactionType(Ids.TransactionType2)
                           .WithRole(Ids.Role2))

                        .WithBuilder<TransactionTypeContextBuilder>(Ids.TransactionContext2_1, b => b
                            .ForTransactionType(Ids.TransactionType2)
                            .WithEntityType("account"))

                       .WithBuilder<TransactionProcessBuilder>(Ids.Process2, b => b
                           .ForTransactionType(Ids.TransactionType2)
                           .WithInitialStep(Ids.Step2_1))

                       .WithBuilder<ProcessStepBuilder>(Ids.Step2_1, b => b
                           .OfType(Ids.DataFormStepType)
                           .WithParameters("{\"FormId\":\"Step1\"}")
                           .ForProcess(Ids.Process1))

                #endregion

                #region Transaction Type 3 (Contact Context)

                       .WithBuilder<TransactionTypeBuilder>(Ids.TransactionType3, b => b
                           .InGroup(Ids.Group1)
                           .WithDisplayRank(2)
                           .WithDataRecordType("new_dataentity")
                           .WithStartupProcess(Ids.Process3))

                       .WithBuilder<TransactionChannelBulder>(Ids.TransactionAuthorizedChannel3_1, b => b
                           .ForTransctionType(Ids.TransactionType3)
                           .WithChannel(Ids.Channel1))

                       .WithBuilder<TransactionRoleBuilder>(Ids.TransactionAuthorizedRole3_1, b => b
                           .ForTransactionType(Ids.TransactionType3)
                           .WithRole(Ids.Role3))

                        .WithBuilder<TransactionTypeContextBuilder>(Ids.TransactionContext3_1, b => b
                            .ForTransactionType(Ids.TransactionType3)
                            .WithEntityType("contact"))

                       .WithBuilder<TransactionProcessBuilder>(Ids.Process3, b => b
                           .ForTransactionType(Ids.TransactionType3)
                           .WithInitialStep(Ids.Step3_1))

                       .WithBuilder<ProcessStepBuilder>(Ids.Step3_1, b => b
                           .OfType(Ids.DataFormStepType)
                           .WithParameters("{\"FormId\":\"Step1\"}")
                           .ForProcess(Ids.Process3))

                #endregion

                       .WithEntities<Ids>()
                       .Create(service);
            }

            protected override void Test(IOrganizationService service)
            {
                //Fake context record will always indicate a context match
                var contextRecord = A.Fake<ITransactionContext>();
                A.CallTo(contextRecord).WithReturnType<bool>().Returns(true);
                                
                //Fake Session supports role 1
                var workSession = new FakeWorkSession()
                    .AllowAllChannels()
                    .WithRoles(Ids.Role1);               
               
                
                var executionContext = GetExecutionContext(service);

                var transactionManagerFactory = Container.Resolve<ITransactionManagerFactory>();
                var transactionManager = transactionManagerFactory.CreateTransactionManager(executionContext);

                //Only Transaction Type 1 matches
                var transactionTypes = transactionManager.GetAvaialbleTransactionTypes(executionContext, workSession, contextRecord);
                Assert.AreEqual(1, transactionTypes.Count);
                Assert.AreEqual(Ids.TransactionType1.EntityId, transactionTypes[0].Id);  

              
            }
        }

        #endregion GetAvailableTransactions_Should_FilterByAgentRole


        #region GetAvailableTransactions_Should_FilterBySessionChannel

        [TestMethod]
        public void Test_GetAvailableTransactions_Should_FilterBySessionChannel()
        {
            new GetAvailableTransactions_Should_FilterBySessionChannel().Test();
        }
   
        private class GetAvailableTransactions_Should_FilterBySessionChannel : Common.TestMethodBase
        {
            private struct Ids
            {
                public static readonly Id<TestProxy.Contact> Contact = new Id<TestProxy.Contact>("21ABB65C-FDC6-42E1-87B9-4918EFE7E297");

                public static readonly Id Account = new Id<TestProxy.Account>("A84708DF-0BA6-4E5F-97A8-1F556A344D7E");

                public static readonly Id Channel1 = new Id<TestProxy.ccllc_channel>("397857D5-FF41-4A72-B584-F4999547B332");
                public static readonly Id Channel2 = new Id<TestProxy.ccllc_channel>("7D5D524B-5A25-417B-AD12-BF32C89019E6");
                public static readonly Id Channel3 = new Id<TestProxy.ccllc_channel>("061F76AD-8558-46A4-84CC-4EE6B67D777A");

                public static readonly Id Role1 = new Id<TestProxy.ccllc_role>("46B53846-AF69-4C61-B678-B16318172BC6");
                public static readonly Id Role2 = new Id<TestProxy.ccllc_role>("ECA2585C-F074-4E28-BB02-E3A8C941272D");
                public static readonly Id Role3 = new Id<TestProxy.ccllc_role>("AFB7EFDA-3BE7-4799-9D13-B150A93BDCE4");

                public static readonly Id Fee1 = new Id<TestProxy.ccllc_fee>("A72EF588-B725-4B22-843D-86D26C9CBA2A");
                public static readonly Id Fee2 = new Id<TestProxy.ccllc_fee>("FED1A359-AAA5-4972-957C-996B45D5549B");
                public static readonly Id Fee3 = new Id<TestProxy.ccllc_fee>("2BE2F5E3-ECDC-4C63-9453-4071A0D9D0C5");
                public static readonly Id Fee4 = new Id<TestProxy.ccllc_fee>("691959C8-2177-4A04-A8F0-DA541FE41A15");

                public static readonly Id DataRecordActionEvaluator = new Id<TestProxy.ccllc_evaluatortype>("9F61D86E-92C2-4B93-9881-8FBF118800FD");
                public static readonly Id DataRecordQueryEvaluator = new Id<TestProxy.ccllc_evaluatortype>("717B4423-962A-4310-BEA4-14B61FD9E3CB");

                public static readonly Id DataFormStepType = new Id<TestProxy.ccllc_processsteptype>("C9A66484-8FDA-4FDE-8B12-C4B770880A4E");
                public static readonly Id RecordActionStepType = new Id<TestProxy.ccllc_processsteptype>("38855586-B640-4D97-A8A2-EF79AACC88BC");
                public static readonly Id ConditionalStepType = new Id<TestProxy.ccllc_processsteptype>("B58D2A3E-31D1-4295-B50E-07D8E5255126");

                public static readonly Id Group1 = new Id<TestProxy.ccllc_transactiongroup>("C166CCDD-4714-4CD9-87FB-78462D62B643");
                public static readonly Id Group2 = new Id<TestProxy.ccllc_transactiongroup>("A3248F42-9233-41FF-BBCB-90046F2CDAA0");
                public static readonly Id Group3 = new Id<TestProxy.ccllc_transactiongroup>("BB15C73C-0BE7-45C5-8E5F-774599D9D1FB");

                #region Transaction Type 1

                public static readonly Id TransactionType1 = new Id<TestProxy.ccllc_transactiontype>("689C2C9A-215F-4E5C-9C53-7AAB0D48CE05");

                public static readonly Id TransactionAuthorizedChannel1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedchannel>("08C9567C-16E6-4812-82E9-30C66269E3B5");

                public static readonly Id TransactionAuthorizedRole1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedrole>("94A77283-DE95-4972-AE99-7E25165E6AE9");

                public static readonly Id InitialFee1_1 = new Id<TestProxy.ccllc_transactioninitialfee>("CF08C9D3-5115-4EA4-AE29-E79E5EBA1640");

                public static readonly Id Requirement1_1 = new Id<TestProxy.ccllc_transactionrequirement>("13CA95A6-E593-4A1A-B9DC-D1DBF2576741");

                public static readonly Id TransactionContext1_1 = new Id<TestProxy.ccllc_transactiontypecontext>("8E0B2A57-25F0-498A-93D6-4BD414B89F2A");

                public static readonly Id Process1 = new Id<TestProxy.ccllc_transactionprocess>("5096C212-254E-4B4D-B070-D1F79D844A01");

                public static readonly Id Step1_1 = new Id<TestProxy.ccllc_processstep>("4B72D1F9-EB95-4933-BB1D-9CB58F207010");
                public static readonly Id Step1_2 = new Id<TestProxy.ccllc_processstep>("1985A761-E5EA-48EA-ABE2-F55F16CDD575");
                public static readonly Id Step1_3 = new Id<TestProxy.ccllc_processstep>("3494560F-18A1-4CE6-9343-C052DF89EAA5");

                #endregion

                #region Transaction Type 2

                public static readonly Id TransactionType2 = new Id<TestProxy.ccllc_transactiontype>("0C3741FF-4080-4715-A993-D08DB391AA34");

                public static readonly Id TransactionAuthorizedChannel2_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedchannel>("DADFDAEE-A33B-432B-9D97-DC95C9A81D5A");

                public static readonly Id TransactionAuthorizedRole2_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedrole>("06A176FE-8BD9-4765-8C08-66F13539E1F9");

                public static readonly Id InitialFee2_1 = new Id<TestProxy.ccllc_transactioninitialfee>("583324D5-F846-4B37-A5E2-4FDD72662AEF");

                public static readonly Id Requirement2_1 = new Id<TestProxy.ccllc_transactionrequirement>("7D9C7C23-CAFF-4971-9E84-708C386576F7");

                public static readonly Id TransactionContext2_1 = new Id<TestProxy.ccllc_transactiontypecontext>("44A651BA-597A-4209-A685-ECBFB8F65CC5");

                public static readonly Id Process2 = new Id<TestProxy.ccllc_transactionprocess>("94B55C9B-0D76-43AF-A0A8-239529737E9C");

                public static readonly Id Step2_1 = new Id<TestProxy.ccllc_processstep>("20DE078E-7AD5-46D0-B822-EA1EBF5D91FB");

                #endregion

                #region Transaction Type 3

                public static readonly Id TransactionType3 = new Id<TestProxy.ccllc_transactiontype>("63C64AFF-7559-497A-B2DA-2D5101B370B0");

                public static readonly Id TransactionAuthorizedChannel3_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedchannel>("52091BEA-C024-4B5A-B056-DEB0CC6AC0C7");

                public static readonly Id TransactionAuthorizedRole3_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedrole>("0A9E5886-E9A6-45BB-9EAE-5CABD243A2AF");

                public static readonly Id InitialFee3_1 = new Id<TestProxy.ccllc_transactioninitialfee>("5374EAF6-B0BD-47D7-BC06-C2AD0163A551");

                public static readonly Id Requirement3_1 = new Id<TestProxy.ccllc_transactionrequirement>("97E49765-7539-43FA-B5D5-6FC148FE1DE8");

                public static readonly Id TransactionContext3_1 = new Id<TestProxy.ccllc_transactiontypecontext>("1F1F5C01-EC70-49D1-8787-CA62BEF62736");

                public static readonly Id Process3 = new Id<TestProxy.ccllc_transactionprocess>("36453F98-38A0-4D1F-9883-227EA02E801C");

                public static readonly Id Step3_1 = new Id<TestProxy.ccllc_processstep>("A80267B1-FAB5-43EB-92A7-B3216FC0E346");

                #endregion


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

                        .WithBuilder<ProcessStepTypeBuilder>(Ids.ConditionalStepType, b => b
                            .WithImplementatingAssembly("CCLLC.BTF.Process.CDS")
                            .WithImplementatingClass("CCLLC.BTF.Process.StepType.Branch"))

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

                        .WithBuilder<TransactionRoleBuilder>(Ids.TransactionAuthorizedRole1_1, b => b
                            .ForTransactionType(Ids.TransactionType1)
                            .WithRole(Ids.Role1))

                        .WithBuilder<TransactionInitialFeeBuilder>(Ids.InitialFee1_1, b => b
                            .ForTransactionType(Ids.TransactionType1)
                            .WithFee(Ids.Fee1))

                        .WithBuilder<TransactionRequirementBuilder>(Ids.Requirement1_1, b => b
                            .OfType(Ids.DataRecordActionEvaluator)
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
                            .WithChannel(Ids.Channel2))

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

                    #region Transaction Type 3 Setup

                        .WithBuilder<TransactionTypeBuilder>(Ids.TransactionType3, b => b
                            .InGroup(Ids.Group2)
                            .WithDisplayRank(1)
                            .WithDataRecordType("new_dataentity")
                            .WithStartupProcess(Ids.Process3))

                            .WithBuilder<TransactionChannelBulder>(Ids.TransactionAuthorizedChannel3_1, b => b
                            .ForTransctionType(Ids.TransactionType3)
                            .WithChannel(Ids.Channel3))

                        .WithBuilder<TransactionRoleBuilder>(Ids.TransactionAuthorizedRole3_1, b => b
                            .ForTransactionType(Ids.TransactionType3)
                            .WithRole(Ids.Role3))

                        .WithBuilder<TransactionInitialFeeBuilder>(Ids.InitialFee3_1, b => b
                            .ForTransactionType(Ids.TransactionType3)
                            .WithFee(Ids.Fee3))

                        .WithBuilder<TransactionRequirementBuilder>(Ids.Requirement3_1, b => b
                            .OfType(Ids.DataRecordActionEvaluator)
                            .ForTransactionType(Ids.TransactionType3))

                    #endregion

                    #region Process 3 Setup

                        .WithBuilder<TransactionProcessBuilder>(Ids.Process3, b => b
                            .ForTransactionType(Ids.TransactionType3)
                            .WithInitialStep(Ids.Step3_1))

                        .WithBuilder<ProcessStepBuilder>(Ids.Step3_1, b => b
                            .OfType(Ids.DataFormStepType)
                            .WithParameters("{\"FormId\":\"Step1\"}")
                            .ForProcess(Ids.Process3))

                    #endregion

                        .WithEntities<Ids>()
                        .Create(service);
                }
                catch (Exception ex)
                {
                    this.Logger.WriteLine(ex.Message);
                }
            }

            protected override void Test(IOrganizationService service)
            {
                //Fake context record will always indicate a context match
                var contextRecord = A.Fake<ITransactionContext>();
                A.CallTo(contextRecord).WithReturnType<bool>().Returns(true);

                //Fake Session supports channel 2
                var workSession = new FakeWorkSession()
                    .AllowAllRoles()
                    .WithChannels(Ids.Channel2);               

                var executionContext = GetExecutionContext(service);

                var transactionManagerFactory = Container.Resolve<ITransactionManagerFactory>();
                var transactionManager = transactionManagerFactory.CreateTransactionManager(executionContext);

                //Only Transaction Type 2 matches
                var transactionTypes = transactionManager.GetAvaialbleTransactionTypes(executionContext, workSession, contextRecord);
                Assert.AreEqual(1, transactionTypes.Count);
                Assert.AreEqual(Ids.TransactionType2.EntityId, transactionTypes[0].Id);
            }
        }

        #endregion GetAvailableTransactions_Should_FilterBySessionChannel


        #region GetAvaialbleTransactions_Should_SortByGroupAndTransactionType

        [TestMethod]
        public void Test_GetAvaialbleTransactions_Should_SortByGroupAndTransactionType()
        {
            new GetAvaialbleTransactions_Should_SortByGroupAndTransactionType().Test();
        }

       
        private class GetAvaialbleTransactions_Should_SortByGroupAndTransactionType : Common.TestMethodBase
        {
            private struct Ids
            {
                public static readonly Id Contact = new Id<TestProxy.Contact>("BF000A91-130D-4536-9583-F6E40B3213E3");

                public static readonly Id Account = new Id<TestProxy.Account>("430CAAED-A59E-4663-B375-55A51F19E02E");                

                public static readonly Id Channel1 = new Id<TestProxy.ccllc_channel>("68AAAE4A-4B5D-44D0-ADC1-AF2948D860F9");
                public static readonly Id Channel2 = new Id<TestProxy.ccllc_channel>("4D3E9A43-D5DD-402E-98F9-D64818ED491C");
                public static readonly Id Channel3 = new Id<TestProxy.ccllc_channel>("38EC5D87-4F80-4E45-82D3-F44BFA9DE110");

                public static readonly Id Role1 = new Id<TestProxy.ccllc_role>("F60FC5A7-458F-416C-B043-65986E7E0B23");
                public static readonly Id Role2 = new Id<TestProxy.ccllc_role>("15473CC4-84BB-49D4-9A84-DFC90F5C335E");
                public static readonly Id Role3 = new Id<TestProxy.ccllc_role>("6C717D08-C9BD-415B-AF82-E2A8DDF1421A");

                public static readonly Id Fee1 = new Id<TestProxy.ccllc_fee>("C29893AA-1976-4A97-BEE6-A82B261B4FFF");
                public static readonly Id Fee2 = new Id<TestProxy.ccllc_fee>("CE97F8F4-2359-462B-905C-02E00DB4B6BF");
                public static readonly Id Fee3 = new Id<TestProxy.ccllc_fee>("9FD9027E-6B29-4F07-8255-043FB2CDECCA");
                public static readonly Id Fee4 = new Id<TestProxy.ccllc_fee>("123263E7-F15E-42A7-901A-EA7017C585D6");

                public static readonly Id DataRecordActionEvaluator = new Id<TestProxy.ccllc_evaluatortype>("F713CFE7-D288-4DAD-8A0F-60CC57026B51");
                public static readonly Id DataRecordQueryEvaluator = new Id<TestProxy.ccllc_evaluatortype>("AA61C969-0B8F-4B75-8B2F-C58B3FBD4A37");

                public static readonly Id DataFormStepType = new Id<TestProxy.ccllc_processsteptype>("892B2516-01B8-426E-83CC-429415F2DC57");
                public static readonly Id RecordActionStepType = new Id<TestProxy.ccllc_processsteptype>("85FE26A1-C297-4884-826E-B326A7CC81C5");
                public static readonly Id ConditionalStepType = new Id<TestProxy.ccllc_processsteptype>("49F931DC-FB53-42EC-8E66-27118AC00154");

                public static readonly Id Group1 = new Id<TestProxy.ccllc_transactiongroup>("E2B55850-75A9-4678-A1F5-A6FF58E18B0D");
                public static readonly Id Group2 = new Id<TestProxy.ccllc_transactiongroup>("4EE8431A-07ED-46E5-B1AE-94CA5BFB15B7");
                public static readonly Id Group3 = new Id<TestProxy.ccllc_transactiongroup>("1A7C9CA2-9EB3-40B6-9ADB-E873FA8504B0");

                #region Transaction Type 1

                public static readonly Id TransactionType1 = new Id<TestProxy.ccllc_transactiontype>("AE1D5260-57C5-40C1-9682-C2F16F310401");

                public static readonly Id TransactionAuthorizedChannel1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedchannel>("4F33676A-4BEF-41BC-BC12-21A19D595AFB");

                public static readonly Id TransactionAuthorizedRole1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedrole>("3C6F88AA-5A20-43C6-AA3E-E0DBC1C990C5");

                public static readonly Id InitialFee1_1 = new Id<TestProxy.ccllc_transactioninitialfee>("9E7E5650-6287-4372-A967-DD1B8065E444");

                public static readonly Id Requirement1_1 = new Id<TestProxy.ccllc_transactionrequirement>("FB0B1445-EB9C-45CB-8A79-F18ED84301E8");

                public static readonly Id TransactionContext1_1 = new Id<TestProxy.ccllc_transactiontypecontext>("CC19399D-D661-4EAE-8B49-B83277F9B1C6");

                public static readonly Id Process1 = new Id<TestProxy.ccllc_transactionprocess>("BF1A24DF-2EBE-44AB-A1E7-E5C73C4B0346");

                public static readonly Id Step1_1 = new Id<TestProxy.ccllc_processstep>("DE7D032A-70BD-4B98-9322-AE367D4221E7");
                public static readonly Id Step1_2 = new Id<TestProxy.ccllc_processstep>("3D1BB0E8-B61B-4172-838A-D5159EE8A1D6");
                public static readonly Id Step1_3 = new Id<TestProxy.ccllc_processstep>("11DFDAB4-B484-4ADC-9D84-C252AE069240");

                #endregion

                #region Transaction Type 2

                public static readonly Id TransactionType2 = new Id<TestProxy.ccllc_transactiontype>("35E786C6-3616-4E98-90EC-308B28490D56");

                public static readonly Id TransactionAuthorizedChannel2_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedchannel>("A3DA832A-BD6E-4BE7-9E2B-C7227A0E51A5");

                public static readonly Id TransactionAuthorizedRole2_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedrole>("54D8AB0A-AAD7-40ED-81A0-3B8A9631D079");

                public static readonly Id InitialFee2_1 = new Id<TestProxy.ccllc_transactioninitialfee>("C83DDA40-4C6C-4A1B-8A09-225C6FCAD154");

                public static readonly Id Requirement2_1 = new Id<TestProxy.ccllc_transactionrequirement>("381DB3EF-1207-4142-868C-0F2EE2C3339C");

                public static readonly Id TransactionContext2_1 = new Id<TestProxy.ccllc_transactiontypecontext>("2DCF71B6-42D3-42F6-B3C6-F4EC6A07203A");

                public static readonly Id Process2 = new Id<TestProxy.ccllc_transactionprocess>("8D464A80-281A-4402-89EF-41B3B9320594");

                public static readonly Id Step2_1 = new Id<TestProxy.ccllc_processstep>("FCC62C11-F50D-4DC8-9C41-6EA37107DF75");

                #endregion

                #region Transaction Type 3

                public static readonly Id TransactionType3 = new Id<TestProxy.ccllc_transactiontype>("52073279-2B97-4BD1-A6FF-89E71B5B67F5");

                public static readonly Id TransactionAuthorizedChannel3_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedchannel>("33E4C13B-53B2-4345-9930-1B834DA2D8AE");

                public static readonly Id TransactionAuthorizedRole3_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedrole>("87608448-4508-4DDD-B3EF-D6FACFDC4281");

                public static readonly Id InitialFee3_1 = new Id<TestProxy.ccllc_transactioninitialfee>("02ABE222-6B4E-4567-811B-E63DAA577E8F");

                public static readonly Id Requirement3_1 = new Id<TestProxy.ccllc_transactionrequirement>("ACCBF376-D35B-4ECA-A634-C637A06BBC58");

                public static readonly Id TransactionContext3_1 = new Id<TestProxy.ccllc_transactiontypecontext>("9A61972F-AEEE-4EE0-8156-2538901E7DBF");

                public static readonly Id Process3 = new Id<TestProxy.ccllc_transactionprocess>("48C58C2A-14D2-47B0-A5BE-609134428F91");

                public static readonly Id Step3_1 = new Id<TestProxy.ccllc_processstep>("419142CC-5B83-4D82-84FF-FD942F0BF268");

                #endregion


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

                        .WithBuilder<ProcessStepTypeBuilder>(Ids.ConditionalStepType, b => b
                            .WithImplementatingAssembly("CCLLC.BTF.Process.CDS")
                            .WithImplementatingClass("CCLLC.BTF.Process.StepType.Branch"))

                    #endregion

                    #region Evaluator Type Setup

                        .WithBuilder<EvaluatorTypeBuilder>(Ids.DataRecordActionEvaluator, b => b
                            .WithImplementatingAssembly("S3.D365.Transactions")
                            .WithImplementatingClass("CCLLC.BTF.Process.CDS.EvaluatorType.DataRecordActionEvaluator"))

                        .WithBuilder<EvaluatorTypeBuilder>(Ids.DataRecordQueryEvaluator, b => b
                            .WithImplementatingAssembly("S3.D365.Transactions")
                            .WithImplementatingClass("CCLLC.BTF.Process.CDS.EvaluatorType.DataReccordQueryMatchEvaluator"))

                    #endregion

                    #region Transaction Groups (Orderd as Group3, Group2, Group1)

                        .WithBuilder<TransactionGroupBuilder>(Ids.Group1, b => b
                            .WithDisplayRank(3))

                        .WithBuilder<TransactionGroupBuilder>(Ids.Group2, b => b
                            .WithDisplayRank(2))

                        .WithBuilder<TransactionGroupBuilder>(Ids.Group3, b => b
                            .WithDisplayRank(1))

                    #endregion

                    #region Transaction Type 1 (First item in Group1)

                        .WithBuilder<TransactionTypeBuilder>(Ids.TransactionType1, b => b
                            .InGroup(Ids.Group1)
                            .WithDisplayRank(1)
                            .WithDataRecordType("new_dataentity")
                            .WithStartupProcess(Ids.Process1))

                        .WithBuilder<TransactionChannelBulder>(Ids.TransactionAuthorizedChannel1_1, b => b
                            .ForTransctionType(Ids.TransactionType1)
                            .WithChannel(Ids.Channel1))

                        .WithBuilder<TransactionRoleBuilder>(Ids.TransactionAuthorizedRole1_1, b => b
                            .ForTransactionType(Ids.TransactionType1)
                            .WithRole(Ids.Role1))

                        .WithBuilder<TransactionInitialFeeBuilder>(Ids.InitialFee1_1, b => b
                            .ForTransactionType(Ids.TransactionType1)
                            .WithFee(Ids.Fee1))

                        .WithBuilder<TransactionRequirementBuilder>(Ids.Requirement1_1, b => b
                            .OfType(Ids.DataRecordActionEvaluator)
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

                    #region Transaction Type 2 (Second item in Group2)

                        .WithBuilder<TransactionTypeBuilder>(Ids.TransactionType2, b => b
                            .InGroup(Ids.Group2)
                            .WithDisplayRank(2)
                            .WithDataRecordType("new_dataentity")
                            .WithStartupProcess(Ids.Process2))

                        .WithBuilder<TransactionChannelBulder>(Ids.TransactionAuthorizedChannel2_1, b => b
                            .ForTransctionType(Ids.TransactionType2)
                            .WithChannel(Ids.Channel2))

                        .WithBuilder<TransactionRoleBuilder>(Ids.TransactionAuthorizedRole2_1, b => b
                            .ForTransactionType(Ids.TransactionType2)
                            .WithRole(Ids.Role2))

                        .WithBuilder<TransactionInitialFeeBuilder>(Ids.InitialFee2_1, b => b
                            .ForTransactionType(Ids.TransactionType2)
                            .WithFee(Ids.Fee2))

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

                    #region Transaction Type 3 (First item in Group2)

                        .WithBuilder<TransactionTypeBuilder>(Ids.TransactionType3, b => b
                            .InGroup(Ids.Group2)
                            .WithDisplayRank(1)
                            .WithDataRecordType("new_dataentity")
                            .WithStartupProcess(Ids.Process3))

                            .WithBuilder<TransactionChannelBulder>(Ids.TransactionAuthorizedChannel3_1, b => b
                            .ForTransctionType(Ids.TransactionType3)
                            .WithChannel(Ids.Channel3))

                        .WithBuilder<TransactionRoleBuilder>(Ids.TransactionAuthorizedRole3_1, b => b
                            .ForTransactionType(Ids.TransactionType3)
                            .WithRole(Ids.Role3))

                        .WithBuilder<TransactionInitialFeeBuilder>(Ids.InitialFee3_1, b => b
                            .ForTransactionType(Ids.TransactionType3)
                            .WithFee(Ids.Fee3))

                        .WithBuilder<TransactionRequirementBuilder>(Ids.Requirement3_1, b => b
                            .OfType(Ids.DataRecordActionEvaluator)
                            .ForTransactionType(Ids.TransactionType3))

                    #endregion

                    #region Process 3 Setup

                        .WithBuilder<TransactionProcessBuilder>(Ids.Process3, b => b
                            .ForTransactionType(Ids.TransactionType3)
                            .WithInitialStep(Ids.Step3_1))

                        .WithBuilder<ProcessStepBuilder>(Ids.Step3_1, b => b
                            .OfType(Ids.DataFormStepType)
                            .WithParameters("{\"FormId\":\"Step1\"}")
                            .ForProcess(Ids.Process3))

                    #endregion

                        .WithEntities<Ids>()
                        .Create(service);
                }
                catch (Exception ex)
                {
                    this.Logger.WriteLine(ex.Message);
                }
            }

            protected override void Test(IOrganizationService service)
            {
                //Fake context record will always indicate a context match
                var contextRecord = A.Fake<ITransactionContext>();
                A.CallTo(contextRecord).WithReturnType<bool>().Returns(true);

                //Fake Session matches all channels and roles
                var workSession = new FakeWorkSession()
                    .AllowAllChannels()
                    .AllowAllRoles();                               

                var executionContext = GetExecutionContext(service);

                var transactionManagerFactory = Container.Resolve<ITransactionManagerFactory>();
                var transactionManager = transactionManagerFactory.CreateTransactionManager(executionContext);

            
                var transactionTypes = transactionManager.GetAvaialbleTransactionTypes(executionContext, workSession, contextRecord);

                //Should return three transaction types ordered as Type3, Type2, Type1
                Assert.AreEqual(3, transactionTypes.Count);
                Assert.AreEqual(Ids.TransactionType3.EntityId, transactionTypes[0].Id);
                Assert.AreEqual(Ids.TransactionType2.EntityId, transactionTypes[1].Id);
                Assert.AreEqual(Ids.TransactionType1.EntityId, transactionTypes[2].Id);
            }
        }

        #endregion GetAvaialbleTransactions_Should_SortByGroupAndTransactionType


        #region LoadTransaction_Should_RetrieveExistingTransactionRecord

        [TestMethod]
        public void Test_LoadTransaction_Should_RetrieveExistingTransactionRecord()
        {
            new LoadTransaction_Should_RetrieveExistingTransactionRecord().Test();
        }
        
        private class LoadTransaction_Should_RetrieveExistingTransactionRecord : Common.TestMethodBase
        {
            private struct Ids
            {
                public static readonly Id Contact = new Id<TestProxy.Contact>("4790ADB7-E3AA-4A5D-A35F-386168AD101E");

                public static readonly Id Agent = new Id<TestProxy.ccllc_agent>("AEC125E6-CD5C-4BB1-B725-21CD9FFA6974");

                public static readonly Id Location = new Id<TestProxy.ccllc_location>("D6B42714-4DAB-404C-8ECD-28C73F3DB8D9");

                public static readonly Id Channel1 = new Id<TestProxy.ccllc_channel>("9115E8B7-854E-4BA0-95F5-AE2827BFF333");                

                public static readonly Id Role1 = new Id<TestProxy.ccllc_role>("C8D816A9-87F3-4803-82F0-9B757B1D762A");    
                
                public static readonly Id DataFormStepType = new Id<TestProxy.ccllc_processsteptype>("E54F2181-A28A-4476-BA66-F54CC8CA0CC6");
               
                public static readonly Id Group1 = new Id<TestProxy.ccllc_transactiongroup>("05A3DFAE-B62C-4D4C-B252-0A32C1B63963");               

                #region Transaction Type 1

                public static readonly Id TransactionType1 = new Id<TestProxy.ccllc_transactiontype>("09CB45CE-0209-4569-8B4A-A474185B8E0D");

                public static readonly Id TransactionAuthorizedChannel1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedchannel>("46AC0680-67E3-4F80-8B29-30CD607C7EFD");

                public static readonly Id TransactionAuthorizedRole1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedrole>("DF848ACC-856F-4690-865F-473A49383D47");
                              
                public static readonly Id TransactionContext1_1 = new Id<TestProxy.ccllc_transactiontypecontext>("C5C57668-52AB-45CC-8FFF-42A650D98754");

                public static readonly Id Process1 = new Id<TestProxy.ccllc_transactionprocess>("7D0C442F-BCA9-4AAE-BA33-13DA17F55504");

                public static readonly Id Step1_1 = new Id<TestProxy.ccllc_processstep>("98967915-FFBB-4DEE-9921-8A4AD0FE9230");

                #endregion

                public static readonly Id ExistingTransaction = new Id<TestProxy.ccllc_transaction>("E1BE4DFD-18E3-4B04-A9F8-A0D4ED82519D");

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
                            .WithDataRecordType("new_dataentity")
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
                            .ForProcess(Ids.Process1))

                    #endregion

                    #region Existing Transaction Setup

                        .WithBuilder<TransactionBuilder>(Ids.ExistingTransaction, b => b
                            .OfTransactionType(Ids.TransactionType1)
                            .ForCustomer(Ids.Contact)
                            .UsingContextRecord(Ids.Contact)
                            .UsingProcess(Ids.Process1)
                            .AtStep(Ids.Step1_1)
                            .WithAgent(Ids.Agent)
                            .WithLocation(Ids.Location))

                    #endregion

                        .WithEntities<Ids>()
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
                   .Build();

                var executionContext = GetExecutionContext(service);

                var transactionManagerFactory = Container.Resolve<ITransactionManagerFactory>();
                var transactionManager = transactionManagerFactory.CreateTransactionManager(executionContext);

                var transaction = transactionManager.LoadTransaction(executionContext, Ids.ExistingTransaction.ToRecordPointer());

                Assert.AreEqual(Ids.ExistingTransaction.EntityId, transaction.Id);                
            }
        }

        #endregion LoadTransaction_Should_RetrieveExistingTransactionRecord
        

        #region NewTransaction_Should_CreateANewTransaction

        [TestMethod]
        public void Test_NewTransaction_Should_CreateANewTransaction()
        {
            new NewTransaction_Should_CreateANewTransaction().Test();
        }
      
        private class NewTransaction_Should_CreateANewTransaction : Common.TestMethodBase
        {
            private struct Ids
            {
                public static readonly Id Contact = new Id<TestProxy.Contact>("3474B591-7E98-4B3B-A7A4-D482C0A2BBB2");

                public static readonly Id Account = new Id<TestProxy.Account>("3425A09E-BD57-4174-B75B-70D40E4AD7BC");

                public static readonly Id Agent = new Id<TestProxy.ccllc_agent>("21595E81-BF7C-4D82-A7F1-9C9D201BD486");

                public static readonly Id Location = new Id<TestProxy.ccllc_location>("080C5D72-026D-43AB-B22A-DD081AFBA370");

                public static readonly Id Channel1 = new Id<TestProxy.ccllc_channel>("F9C05EF7-9F5C-4219-AD06-8B45DDBE149D");
                public static readonly Id Channel2 = new Id<TestProxy.ccllc_channel>("24178099-9F64-433F-8C09-ECFF7D82348C");
                public static readonly Id Channel3 = new Id<TestProxy.ccllc_channel>("B2DD35B6-15DF-4913-B0F8-41BDF40B9190");

                public static readonly Id Role1 = new Id<TestProxy.ccllc_role>("81216C47-34E8-41DF-B073-8B72CDA55616");
                public static readonly Id Role2 = new Id<TestProxy.ccllc_role>("3110EEE5-75F8-418D-9CBB-78CF421CD55E");
                public static readonly Id Role3 = new Id<TestProxy.ccllc_role>("1886EC75-7828-46AD-B973-3999225E6332");

                public static readonly Id Fee1 = new Id<TestProxy.ccllc_fee>("11C70E54-E4DB-4E68-AB81-E55640389663");
                public static readonly Id Fee2 = new Id<TestProxy.ccllc_fee>("79C8E740-8F02-4D4E-BE2F-2069634FCC15");
                public static readonly Id Fee3 = new Id<TestProxy.ccllc_fee>("357071C4-6899-4BFD-BE68-F5CD29EBEB56");
                public static readonly Id Fee4 = new Id<TestProxy.ccllc_fee>("75C3AD41-E730-4445-BCA2-1A4B16D26FE4");

                public static readonly Id DataRecordActionEvaluator = new Id<TestProxy.ccllc_evaluatortype>("8BF9B9D4-B8BB-4819-AF45-CDE47C0358C7");
                public static readonly Id DataRecordQueryEvaluator = new Id<TestProxy.ccllc_evaluatortype>("5802AC7B-085E-4B60-A221-08D23B54CC2D");

                public static readonly Id DataFormStepType = new Id<TestProxy.ccllc_processsteptype>("6131A797-9DF8-4932-9DBA-D19081339E7C");
                public static readonly Id RecordActionStepType = new Id<TestProxy.ccllc_processsteptype>("0451BEF7-56B8-4CB9-851F-F31FEC038870");
                public static readonly Id ConditionalStepType = new Id<TestProxy.ccllc_processsteptype>("5E28C99B-0E84-4BB5-A689-E467BF2A18F2");

                public static readonly Id Group1 = new Id<TestProxy.ccllc_transactiongroup>("D5B465CD-9447-48AB-9487-95EB1BC0A6D6");
                public static readonly Id Group2 = new Id<TestProxy.ccllc_transactiongroup>("1C083760-3BA8-400E-AE56-1EFEE6A28708");
                public static readonly Id Group3 = new Id<TestProxy.ccllc_transactiongroup>("7A6015AB-B484-4824-8BF8-0E428938AF07");

                #region Transaction Type 1

                public static readonly Id TransactionType1 = new Id<TestProxy.ccllc_transactiontype>("00BF1459-636A-4FDC-A1E4-54903518FB42");

                public static readonly Id TransactionAuthorizedChannel1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedchannel>("FC4663CE-1AD5-4C45-87FD-48208BA5DED5");

                public static readonly Id TransactionAuthorizedRole1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedrole>("E0AF3C97-7E06-4664-9DE9-EE8322E4537B");

                public static readonly Id InitialFee1_1 = new Id<TestProxy.ccllc_transactioninitialfee>("19E94816-33D8-44DE-B814-4DF37FA442D4");

                public static readonly Id Requirement1_1 = new Id<TestProxy.ccllc_transactionrequirement>("ED00FA3C-16EB-4874-9FED-4D7B0EFA1B11");

                public static readonly Id TransactionContext1_1 = new Id<TestProxy.ccllc_transactiontypecontext>("8AE081C2-ED4D-482D-BF43-A27847016A1E");

                public static readonly Id Process1 = new Id<TestProxy.ccllc_transactionprocess>("83AD5075-F4C9-4002-9D6D-A88E812AC7B5");

                public static readonly Id Step1_1 = new Id<TestProxy.ccllc_processstep>("AF7C559B-ABD2-4730-BB4E-9359542F4620");
                public static readonly Id Step1_2 = new Id<TestProxy.ccllc_processstep>("4C320CDA-B401-4D2C-85E8-45E212DEF9C2");
                public static readonly Id Step1_3 = new Id<TestProxy.ccllc_processstep>("6B5C2A2D-C887-4F6B-A79A-417E1A0FC844");

                #endregion

                public static readonly Id CreatedTransaction = new Id<TestProxy.ccllc_transaction>("4F4C8FA9-C2ED-4483-BE04-8B45B94F4AA2");
                public static readonly Id CreatedStepHistory = new Id<TestProxy.ccllc_stephistory>("D265A4E8-6F8C-49EC-9429-5CA7FA7AD066");
                public static readonly Id CreatedTransactionFee = new Id<TestProxy.ccllc_transactionfee>("3D864697-B1BC-44CA-A2C9-ED04C975C55D");
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

                        .WithBuilder<ProcessStepTypeBuilder>(Ids.ConditionalStepType, b => b
                            .WithImplementatingAssembly("CCLLC.BTF.Process.CDS")
                            .WithImplementatingClass("CCLLC.BTF.Process.StepType.Branch"))

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

                        .WithBuilder<TransactionRoleBuilder>(Ids.TransactionAuthorizedRole1_1, b => b
                            .ForTransactionType(Ids.TransactionType1)
                            .WithRole(Ids.Role1))

                        .WithBuilder<TransactionInitialFeeBuilder>(Ids.InitialFee1_1, b => b
                            .ForTransactionType(Ids.TransactionType1)
                            .WithFee(Ids.Fee1))

                        .WithBuilder<TransactionRequirementBuilder>(Ids.Requirement1_1, b => b
                            .OfType(Ids.DataRecordActionEvaluator)
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

                        .WithEntities<Ids>()
                        .ExceptEntities(Ids.CreatedTransaction, Ids.CreatedStepHistory, Ids.CreatedTransactionFee)
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
                        Ids.CreatedTransaction,
                        Ids.CreatedStepHistory,
                        Ids.CreatedTransactionFee)                                   
                    .Build();

                var customer = new FakeCustomer(Ids.Contact);
                var location = new FakeLocation(Ids.Location);
                var agent = new FakeAgent(Ids.Agent);

                //Fake context record will always indicate a context match
                var contextRecord = A.Fake<ITransactionContext>();
                A.CallTo(contextRecord).WithReturnType<bool>().Returns(true);
                A.CallTo(contextRecord).WithReturnType<ICustomer>().Returns(customer);

                //Fake Session matches all channels and roles
                var workSession = new FakeWorkSession()
                    .WithAgent(agent)
                    .WithLocation(location)
                    .AllowAllChannels()
                    .AllowAllRoles();                

                var executionContext = GetExecutionContext(service);

                var transactionManagerFactory = Container.Resolve<ITransactionManagerFactory>();
                var transactionManager = transactionManagerFactory.CreateTransactionManager(executionContext);

                var targetTransactionType = transactionManager.RegisteredTransactionTypes.Where(t => t.Id == Ids.TransactionType1.EntityId).First();

                var transaction = transactionManager.NewTransaction(executionContext, workSession, contextRecord, targetTransactionType);

                //correct transaction type, process, and step
                Assert.AreEqual(Ids.TransactionType1.EntityId, transaction.TransactionType.Id);
                Assert.AreEqual(Ids.Process1.EntityId, transaction.CurrentProcess.Id);
                Assert.AreEqual(Ids.Process1.EntityId, transaction.InitiatingProcess.Id);
                Assert.AreEqual(Ids.Step1_1.EntityId, transaction.CurrentStep.Id);

                //capture initiating agent
                Assert.AreEqual(Ids.Agent.EntityId, transaction.InitiatingAgent.Id);

                //capture initiating location
                Assert.AreEqual(Ids.Location.EntityId, transaction.InitiatingLocation.Id);

                //Applied Fee generated based on initial fee schedule
                Assert.AreEqual(1, transaction.Fees.Count);                              
                Assert.AreEqual(Ids.Fee1.EntityId, transaction.Fees[0].Fee.Id);       
            }
        }

        #endregion NewTransaction_Should_ReturnConfiguredTransaction


        #region SaveTransactionCurrentStep_Should_UpdateTheTransactionRecordCurrentStep

        [TestMethod]
        public void Test_SaveTransactionCurrentStep_Should_UpdateTheTransactionRecordCurrentStep()
        {
            new SaveTransactionCurrentStep_Should_UpdateTheTransactionRecordCurrentStep().Test();
        }
                
        private class SaveTransactionCurrentStep_Should_UpdateTheTransactionRecordCurrentStep : Common.TestMethodBase
        {
            private struct Ids
            {
                public static readonly Id Contact = new Id<TestProxy.Contact>("CE2DEFD4-A0AF-45F2-BD10-F0F49CBBD87F");

                public static readonly Id Agent = new Id<TestProxy.ccllc_agent>("7DE97D8B-2B8F-412B-94AB-63BD36C1E6CE");

                public static readonly Id Location = new Id<TestProxy.ccllc_location>("633D624D-479B-40A6-A601-3E271C3F6F6F");

                public static readonly Id Channel1 = new Id<TestProxy.ccllc_channel>("A62AF869-A52A-4CEF-A6F9-39F49768499F");

                public static readonly Id Role1 = new Id<TestProxy.ccllc_role>("17AC137A-4F7A-4C60-B88B-1A0A898C7558");

                public static readonly Id DataFormStepType = new Id<TestProxy.ccllc_processsteptype>("F9417854-7EC3-4C26-9290-C14B3B842B2B");

                public static readonly Id Group1 = new Id<TestProxy.ccllc_transactiongroup>("155EBC46-860E-46B5-B4FD-48A37DA4D381");

                #region Transaction Type 1

                public static readonly Id TransactionType1 = new Id<TestProxy.ccllc_transactiontype>("A753B700-CD33-4632-87B4-A53A5175E83F");

                public static readonly Id TransactionAuthorizedChannel1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedchannel>("D7D70169-BBAD-45FC-A115-FDA1F3FEFCA3");

                public static readonly Id TransactionAuthorizedRole1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedrole>("91BAE4CF-EFF0-4739-BFBF-2872E2BD63F4");

                public static readonly Id TransactionContext1_1 = new Id<TestProxy.ccllc_transactiontypecontext>("5EF4126F-EA0A-41FA-A4EF-E847469E96AD");

                public static readonly Id Process1 = new Id<TestProxy.ccllc_transactionprocess>("C58F3EAD-F465-4BA5-A278-B5FCAC073E35");

                public static readonly Id Step1_1 = new Id<TestProxy.ccllc_processstep>("D27D2FFE-60F6-49FD-B9C2-E4711D404D13");
                public static readonly Id Step1_2 = new Id<TestProxy.ccllc_processstep>("3B6D3ED4-5B69-491E-893B-8AA9B68FA685");

                #endregion

                public static readonly Id ExistingTransaction = new Id<TestProxy.ccllc_transaction>("51996DD4-0242-4D16-A465-AA0AF6D3E054");

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
                            .WithDataRecordType("new_dataentity")
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
                            .ForProcess(Ids.Process1))

                    #endregion

                    #region Existing Transaction Setup

                        .WithBuilder<TransactionBuilder>(Ids.ExistingTransaction, b => b
                            .OfTransactionType(Ids.TransactionType1)
                            .ForCustomer(Ids.Contact)
                            .UsingContextRecord(Ids.Contact)
                            .UsingProcess(Ids.Process1)
                            .AtStep(Ids.Step1_1)
                            .WithAgent(Ids.Agent)
                            .WithLocation(Ids.Location))

                    #endregion

                        .WithEntities<Ids>()
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
                   .Build();

                var executionContext = GetExecutionContext(service);

                var transactionManagerFactory = Container.Resolve<ITransactionManagerFactory>();
                var transactionManager = transactionManagerFactory.CreateTransactionManager(executionContext);
                
                transactionManager.SaveTransactionCurrentStep(executionContext, Ids.ExistingTransaction.ToRecordPointer(), Ids.Step1_2.ToRecordPointer());

                var record = service.Retrieve(Ids.ExistingTransaction.LogicalName, Ids.ExistingTransaction.EntityId, new Microsoft.Xrm.Sdk.Query.ColumnSet(true)).ToEntity<TestProxy.ccllc_transaction>();

                Assert.AreEqual(Ids.Step1_2.EntityId, record.ccllc_CurrentStepId.Id);
            }
        }

        #endregion SaveTransactionCurrentStep_Should_UpdateTheTransactionRecordCurrentStep


        #region LoadTransactionDataRecord_Should_LoadExistingRecord

        [TestMethod]
        public void Test_LoadTransactionDataRecord_Should_LoadExistingRecord()
        {
            new LoadTransactionDataRecord_Should_LoadExistingRecord().Test();
        }

        // ReSharper disable once InconsistentNaming
        private class LoadTransactionDataRecord_Should_LoadExistingRecord : Common.TestMethodBase
        {
            private struct Ids
            {
                public static readonly Id Contact = new Id<TestProxy.Contact>("98E46945-7CF6-4BE6-8180-CBDF67F50E03");

                public static readonly Id Agent = new Id<TestProxy.ccllc_agent>("14DCFF38-16BA-43A9-AF63-DD3A61AD68DB");

                public static readonly Id Location = new Id<TestProxy.ccllc_location>("0986F8F0-CB9E-44AD-AFDB-52767A06AF01");

                public static readonly Id Channel1 = new Id<TestProxy.ccllc_channel>("8FB7C156-F295-47D5-BDC9-DB076F5F395A");
                
                public static readonly Id Role1 = new Id<TestProxy.ccllc_role>("DB8CC4B7-CC88-4313-AAF1-D09440C86303");
               
                public static readonly Id DataFormStepType = new Id<TestProxy.ccllc_processsteptype>("887CAF60-A93A-4CAF-8562-1745EF7C96E7");
               
                public static readonly Id Group1 = new Id<TestProxy.ccllc_transactiongroup>("4E2F6E8D-987C-49B4-9A9D-B05D67BCD460");
               
                #region Transaction Type 1

                public static readonly Id TransactionType1 = new Id<TestProxy.ccllc_transactiontype>("FFBD0B05-84C9-4520-AD4E-051028178343");

                public static readonly Id TransactionAuthorizedChannel1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedchannel>("F0879565-DAFB-4B4A-98C1-48F3A9C7CFCF");

                public static readonly Id TransactionAuthorizedRole1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedrole>("C67559ED-8E58-4934-B214-7B6C4177F1DB");
               
                public static readonly Id TransactionContext1_1 = new Id<TestProxy.ccllc_transactiontypecontext>("A3499561-9FB3-41E4-B9E1-96ECE35FE8E6");

                public static readonly Id Process1 = new Id<TestProxy.ccllc_transactionprocess>("A8AE5064-ACA4-49EF-9F8D-8FD418DC8688");

                public static readonly Id Step1_1 = new Id<TestProxy.ccllc_processstep>("6B85D77C-C0A6-44D2-9768-3E603B3B1E42");

                #endregion

                public static readonly Id ExistingTransaction = new Id<TestProxy.ccllc_transaction>("5521AA6C-2A5D-4267-B2A3-395E4D34CF4A");

                public static readonly Id ExistingDataRecord = new Id<TestProxy.new_transactiondatarecord>("87B5D9DE-D77F-4C2B-932D-4A28F82EA6CA");


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
                            .ForProcess(Ids.Process1))

                    #endregion

                    #region Existing Transaction wiht Existing Data Record

                        .WithBuilder<TransactionBuilder>(Ids.ExistingTransaction, b => b
                            .OfTransactionType(Ids.TransactionType1)
                            .ForCustomer(Ids.Contact)
                            .UsingContextRecord(Ids.Contact)
                            .UsingProcess(Ids.Process1)
                            .AtStep(Ids.Step1_1)
                            .WithAgent(Ids.Agent)
                            .WithLocation(Ids.Location))

                        .WithBuilder<TransactionDataRecordBuilder>(Ids.ExistingDataRecord, b => b
                            .ForTransaction(Ids.ExistingTransaction)
                            .ForCustomer(Ids.Contact))

                    #endregion

                        .WithEntities<Ids>()                       
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
                   .Build();

                var executionContext = GetExecutionContext(service);

                var transactionManagerFactory = Container.Resolve<ITransactionManagerFactory>();
                var transactionManager = transactionManagerFactory.CreateTransactionManager(executionContext);
                var transaction = transactionManager.LoadTransaction(executionContext, Ids.ExistingTransaction.ToRecordPointer());

                var dataRecord = transactionManager.LoadTransactionDataRecord(executionContext, transaction);

                Assert.AreEqual(Ids.ExistingDataRecord.EntityId, dataRecord.Id);
                Assert.AreEqual(Ids.ExistingTransaction.EntityId, dataRecord.TransactionId.Id);
                Assert.AreEqual(Ids.Contact.EntityId, dataRecord.CustomerId.Id);
            }
        }

        #endregion LoadTransactionDataRecord_Should_LoadExistingRecord


        #region LoadTransactionDataRecord_Should_CreateDataRecordLinkedToTransaction

        [TestMethod]
        public void Test_LoadTransactionDataRecord_Should_CreateDataRecordLinkedToTransaction()
        {
            new LoadTransactionDataRecord_Should_CreateDataRecordLinkedToTransaction().Test();
        }

        private class LoadTransactionDataRecord_Should_CreateDataRecordLinkedToTransaction : Common.TestMethodBase
        {
            private struct Ids
            {
                public static readonly Id Contact = new Id<TestProxy.Contact>("779D56ED-E876-430B-B14D-1202911365F3");
              
                public static readonly Id Agent = new Id<TestProxy.ccllc_agent>("54A67BA1-36E1-40E0-B7F1-19979CFA4489");

                public static readonly Id Location = new Id<TestProxy.ccllc_location>("6084E5A6-1B43-4F76-A305-4448743E671D");

                public static readonly Id Channel1 = new Id<TestProxy.ccllc_channel>("FE415749-3C39-4644-B9E5-55142D88D79F");
               
                public static readonly Id Role1 = new Id<TestProxy.ccllc_role>("E231AD99-3564-41A4-80B1-CD3A2E4276A8");
                             
                public static readonly Id DataFormStepType = new Id<TestProxy.ccllc_processsteptype>("DEC62C81-AF1B-4B43-9F91-798D2E6C0E5F");
               
                public static readonly Id Group1 = new Id<TestProxy.ccllc_transactiongroup>("EB5D4131-AE06-4BEA-A2B5-E79240382A28");
              
                #region Transaction Type 1

                public static readonly Id TransactionType1 = new Id<TestProxy.ccllc_transactiontype>("8CDB20BC-EE3F-4EB5-BF00-0DABE973CC53");

                public static readonly Id TransactionAuthorizedChannel1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedchannel>("96635121-ABFE-49BF-97F5-C1FEC430A7D2");

                public static readonly Id TransactionAuthorizedRole1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedrole>("084911D4-FAF8-407F-B2B9-AFCDF07FD258");
                               
                public static readonly Id TransactionContext1_1 = new Id<TestProxy.ccllc_transactiontypecontext>("B0BBE5B0-91B5-400C-B5D4-AEF1325CAA48");

                public static readonly Id Process1 = new Id<TestProxy.ccllc_transactionprocess>("3EB84AA1-BA97-4E69-BBE1-6DC71BA6FB00");

                public static readonly Id Step1_1 = new Id<TestProxy.ccllc_processstep>("A8227634-3A46-4EA0-BC16-6F096A637CF8");

                #endregion

                public static readonly Id ExistingTransaction = new Id<TestProxy.ccllc_transaction>("82A50229-60C0-4A78-90DB-3BD215CDAAFB");
                           
                public static readonly Id CreatedDataRecord = new Id<TestProxy.new_transactiondatarecord>("1AFD3820-DC26-4228-A9D0-F6D408354C84");
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
                            .ForProcess(Ids.Process1))

                    #endregion

                    #region Existing Transaction Setup

                        .WithBuilder<TransactionBuilder>(Ids.ExistingTransaction, b => b
                            .OfTransactionType(Ids.TransactionType1)
                            .ForCustomer(Ids.Contact)
                            .UsingContextRecord(Ids.Contact)
                            .UsingProcess(Ids.Process1)
                            .AtStep(Ids.Step1_1)
                            .WithAgent(Ids.Agent)
                            .WithLocation(Ids.Location))

                    #endregion

                        .WithEntities<Ids>()
                        .ExceptEntities(                            
                            Ids.CreatedDataRecord)
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
                        Ids.CreatedDataRecord)                      
                   .Build();

                var executionContext = GetExecutionContext(service);

                var transactionManagerFactory = Container.Resolve<ITransactionManagerFactory>();
                var transactionManager = transactionManagerFactory.CreateTransactionManager(executionContext);
                var transaction = transactionManager.LoadTransaction(executionContext, Ids.ExistingTransaction.ToRecordPointer());

                var dataRecord = transactionManager.LoadTransactionDataRecord(executionContext, transaction);

                Assert.AreEqual(Ids.CreatedDataRecord.EntityId, dataRecord.Id);
                Assert.AreEqual(Ids.ExistingTransaction.EntityId, dataRecord.TransactionId.Id);
                Assert.AreEqual(Ids.Contact.EntityId, dataRecord.CustomerId.Id);

            }
        }

        #endregion LoadTransactionDataRecord_Should_CreateDataRecordLinkedToTransaction

    }
}
