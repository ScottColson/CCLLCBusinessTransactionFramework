using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using DLaB.Xrm.Test;
using CCLLC.CDS.Test.Builders;
using CCLLC.BTF.Platform;
using CCLLC.Core;
using Microsoft.Crm.Sdk.Messages;
using CCLLC.CDS.TestBase;


namespace CCLLC.BTF.Process.CDS.Test
{
    [TestClass]
    public class DataRecordQueryMatchEvaluatorTests
    {
        #region Evaluate_Should_FindDataRecord

        [TestMethod]
        public void Test_Evaluate_Should_FindDataRecord()
        {
            new Evaluate_Should_FindDataRecord().Test();
        }

        private class Evaluate_Should_FindDataRecord : Common.TestMethodBase
        {
            private struct Ids
            {
                public static readonly Id Contact = new Id<TestProxy.Contact>("D0B221DF-DDAB-4EC1-AA7B-B9D8C9D034C7");

                public static readonly Id Agent = new Id<TestProxy.ccllc_agent>("7E80CBEE-8A1C-4F8F-9AFC-C3762B5BEC7F");

                public static readonly Id Location = new Id<TestProxy.ccllc_location>("FE25ACEF-1384-4DC6-A9B9-B1935A60DADA");

                public static readonly Id Channel1 = new Id<TestProxy.ccllc_channel>("E5C32493-CF04-48EC-99D4-C2128423B884");                

                public static readonly Id Role1 = new Id<TestProxy.ccllc_role>("4A9D93F8-71A2-41E8-9290-75F5CDCD1AF6");                
                
                public static readonly Id DataRecordQueryEvaluator = new Id<TestProxy.ccllc_evaluatortype>("D339DC5D-D0C7-457C-A4AC-30806A400875");

                public static readonly Id DataFormStepType = new Id<TestProxy.ccllc_processsteptype>("50AED867-68B9-4C27-B0CA-1CF42B425921");                              

                public static readonly Id Group1 = new Id<TestProxy.ccllc_transactiongroup>("C0A6757F-3A32-4CD1-93B1-A8C4AAC1EC19");
               

                #region Transaction Type 1

                public static readonly Id TransactionType1 = new Id<TestProxy.ccllc_transactiontype>("DB69CFC4-885E-4DF7-9D7D-8CD24CE5A0FA");

                public static readonly Id TransactionAuthorizedChannel1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedchannel>("A4DBC367-6D69-4AC2-AA26-BD270EF3644D");

                public static readonly Id TransactionAuthorizedRole1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedrole>("2B1C1AE1-BDAD-4EB2-8996-5026959DA492");
                             
                public static readonly Id TransactionContext1_1 = new Id<TestProxy.ccllc_transactiontypecontext>("629240A4-7B6A-4EBB-AD00-FA6F817F895B");

                public static readonly Id Process1 = new Id<TestProxy.ccllc_transactionprocess>("9AD59AD9-0786-40A9-98F3-EC22DD678344");

                public static readonly Id Step1_1 = new Id<TestProxy.ccllc_processstep>("EEA0550C-4399-4948-A407-93A7A1AB88EC");
              

                #endregion

                public static readonly Id ExistingTransaction = new Id<TestProxy.ccllc_transaction>("2FB5A3EB-772E-4D3F-8330-96C46D7CBED1");
                public static readonly Id ExistingDataRecord = new Id<TestProxy.new_transactiondatarecord>("E0936AC9-6F3D-4482-B9CF-C5F2CDA0810B");

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
                            .ForCustomer(Ids.Contact)
                            .WithFieldSetTo("new_datafield1","TestValue"))

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
                //Test framework does not support the FetchXmlToQueryExpression so we fake the expected API result for the specified fetchXml.
                var fakedFetchQuery = new Microsoft.Xrm.Sdk.Query.QueryExpression()
                {
                    EntityName = "new_transactiondatarecord",
                    ColumnSet = new Microsoft.Xrm.Sdk.Query.ColumnSet(new string[] { "new_transactiondatarecordid" }),
                    Criteria = new Microsoft.Xrm.Sdk.Query.FilterExpression
                    {
                        FilterOperator = Microsoft.Xrm.Sdk.Query.LogicalOperator.And,
                        Conditions =
                                    {
                                        new Microsoft.Xrm.Sdk.Query.ConditionExpression("new_datafield1", Microsoft.Xrm.Sdk.Query.ConditionOperator.Equal, "TestValue")
                                    }
                    }
                };

                service = new OrganizationServiceBuilder()
                    .WithFakeExecute((s, r) => {
                        if(r.RequestName == "FetchXmlToQueryExpression")
                        {
                            FetchXmlToQueryExpressionResponse resp = new FetchXmlToQueryExpressionResponse();
                            resp.Results.Add("Query", fakedFetchQuery );
                            return resp;
                        }
                        return s.Execute(r);
                    })
                    .Build();

                var executionContext = GetExecutionContext(service);
                var serializer = new DefaultSerializer();
                var transactionPointer = new RecordPointer<Guid>(Ids.ExistingTransaction.LogicalName, Ids.ExistingTransaction.EntityId);

                var transactionManagerFactory = Container.Resolve<ITransactionManagerFactory>();
                var transactionManager = transactionManagerFactory.CreateTransactionManager(executionContext, false);

                var transaction = transactionManager.LoadTransaction(executionContext, transactionPointer);

                var evaluatorType = new EvaluatorType.DataReccordQueryMatchEvaluator(
                   Ids.DataRecordQueryEvaluator.ToRecordPointer(), "TestEvaluator",
                   "S3.D365.Transactions",
                   "CCLLC.BTF.Process.CDS.EvaluatorType.DataReccordQueryMatchEvaluator");

                

                string parameterJson = "{\"FetchXml\":\"<fetch><entity name='new_transactiondatarecord'><filter type='and'><condition value='TestValue' attribute='new_datafield1' operator='eq'/></filter></entity></fetch>\"}";

                var parameters = serializer.CreateParamters(parameterJson);

                var result = evaluatorType.Evaluate(executionContext, parameters, transaction);

                Assert.AreEqual(true, result.Result);

            }
        }

        #endregion Evaluate_Should_FindDataRecord


        #region Evaluate_Should_NotFindDataRecord

        [TestMethod]
        public void Test_Evaluate_Should_NotFindDataRecord()
        {
            new Evaluate_Should_NotFindDataRecord().Test();
        }

        private class Evaluate_Should_NotFindDataRecord : Common.TestMethodBase
        {
            private struct Ids
            {
                public static readonly Id Contact = new Id<TestProxy.Contact>("063EE7EE-2A74-488F-8932-8A6B84898B64");

                public static readonly Id Agent = new Id<TestProxy.ccllc_agent>("480AD819-CAC9-41CE-8A26-EDC03D80AF5B");

                public static readonly Id Location = new Id<TestProxy.ccllc_location>("FB5006A8-829C-4129-880A-70C2A782D104");

                public static readonly Id Channel1 = new Id<TestProxy.ccllc_channel>("C3B11B84-132E-41B4-8D04-63FFBEB464BD");

                public static readonly Id Role1 = new Id<TestProxy.ccllc_role>("0BA535E9-D252-46D1-A9CC-1F1F0662536E");

                public static readonly Id DataRecordQueryEvaluator = new Id<TestProxy.ccllc_evaluatortype>("9659305C-DBA4-42FB-8930-D6C448CB6CAE");

                public static readonly Id DataFormStepType = new Id<TestProxy.ccllc_processsteptype>("F980B778-7752-44CA-84B1-26917B1D2E85");

                public static readonly Id Group1 = new Id<TestProxy.ccllc_transactiongroup>("5AC68CE3-0631-441D-90EB-C5C25A68907C");


                #region Transaction Type 1

                public static readonly Id TransactionType1 = new Id<TestProxy.ccllc_transactiontype>("B9D2F274-BF63-4AE2-B823-EA84032B5FF9");

                public static readonly Id TransactionAuthorizedChannel1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedchannel>("D3F7BA73-4774-4E6D-86F7-17AA7D3E21A1");

                public static readonly Id TransactionAuthorizedRole1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedrole>("CB9C7D0A-4AA6-4A05-BEC4-E26859AD2187");

                public static readonly Id TransactionContext1_1 = new Id<TestProxy.ccllc_transactiontypecontext>("E8F94B6B-BB89-406A-8543-EA5F5A4F7B66");

                public static readonly Id Process1 = new Id<TestProxy.ccllc_transactionprocess>("92C85739-4493-4555-901F-1EEEC3B8B09E");

                public static readonly Id Step1_1 = new Id<TestProxy.ccllc_processstep>("0C0BC070-717C-48D3-972E-8660CA2CE2F8");


                #endregion

                public static readonly Id ExistingTransaction = new Id<TestProxy.ccllc_transaction>("500DE0F4-8803-4C84-B83B-7ADBEC3BC71C");
                public static readonly Id ExistingDataRecord = new Id<TestProxy.new_transactiondatarecord>("106D0B3F-3BA8-4804-82AF-6476865ECD22");

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
                            .ForCustomer(Ids.Contact)
                            .WithFieldSetTo("new_datafield1", "NotTestValue"))

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
                //Test framework does not support the FetchXmlToQueryExpression so we fake the expected API result for the specified fetchXml.
                var fakedFetchQuery = new Microsoft.Xrm.Sdk.Query.QueryExpression()
                {
                    EntityName = "new_transactiondatarecord",
                    ColumnSet = new Microsoft.Xrm.Sdk.Query.ColumnSet(new string[] { "new_transactiondatarecordid" }),
                    Criteria = new Microsoft.Xrm.Sdk.Query.FilterExpression
                    {
                        FilterOperator = Microsoft.Xrm.Sdk.Query.LogicalOperator.And,
                        Conditions =
                                    {
                                        new Microsoft.Xrm.Sdk.Query.ConditionExpression("new_datafield1", Microsoft.Xrm.Sdk.Query.ConditionOperator.Equal, "TestValue")
                                    }
                    }
                };

                service = new OrganizationServiceBuilder()
                    .WithFakeExecute((s, r) => {
                        if (r.RequestName == "FetchXmlToQueryExpression")
                        {
                            FetchXmlToQueryExpressionResponse resp = new FetchXmlToQueryExpressionResponse();
                            resp.Results.Add("Query", fakedFetchQuery);
                            return resp;
                        }
                        return s.Execute(r);
                    })
                    .Build();

                var executionContext = GetExecutionContext(service);
                var serializer = new DefaultSerializer();
                var transactionPointer = new RecordPointer<Guid>(Ids.ExistingTransaction.LogicalName, Ids.ExistingTransaction.EntityId);

                var transactionManagerFactory = Container.Resolve<ITransactionManagerFactory>();
                var transactionManager = transactionManagerFactory.CreateTransactionManager(executionContext, false);

                var transaction = transactionManager.LoadTransaction(executionContext, transactionPointer);


                var evaluatorType = new EvaluatorType.DataReccordQueryMatchEvaluator(
                    Ids.DataRecordQueryEvaluator.ToRecordPointer(), "TestEvaluator",
                    "S3.D365.Transactions",
                    "CCLLC.BTF.Process.CDS.EvaluatorType.DataReccordQueryMatchEvaluator");

                string parameterJson = "{\"FetchXml\":\"<fetch><entity name='new_transactiondatarecord'><filter type='and'><condition value='TestValue' attribute='new_datafield1' operator='eq'/></filter></entity></fetch>\"}";

                var parameters = serializer.CreateParamters(parameterJson);

                var result = evaluatorType.Evaluate(executionContext, parameters, transaction);

                Assert.AreEqual(false, result.Result);

            }
        }

        #endregion Evaluate_Should_FindDataRecord


    }
}
