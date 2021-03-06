﻿using System;
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
    public class DataRecordActionEvaluator
    {
        #region Evaluate_Should_SucceedIfActionReturnsTrue

        [TestMethod]
        public void Test_Evaluate_Should_SucceedIfActionReturnsTrue()
        {
            new Evaluate_Should_SucceedIfActionReturnsTrue().Test();
        }

        private class Evaluate_Should_SucceedIfActionReturnsTrue : Common.TestMethodBase
        {
            private struct Ids
            {
                public static readonly Id Contact = new Id<TestProxy.Contact>("D0B221DF-DDAB-4EC1-AA7B-B9D8C9D034C7");

                public static readonly Id Agent = new Id<TestProxy.ccllc_agent>("7E80CBEE-8A1C-4F8F-9AFC-C3762B5BEC7F");

                public static readonly Id Location = new Id<TestProxy.ccllc_location>("FE25ACEF-1384-4DC6-A9B9-B1935A60DADA");

                public static readonly Id Channel1 = new Id<TestProxy.ccllc_channel>("E5C32493-CF04-48EC-99D4-C2128423B884");

                public static readonly Id Role1 = new Id<TestProxy.ccllc_role>("4A9D93F8-71A2-41E8-9290-75F5CDCD1AF6");

                public static readonly Id DataActionEvaluator = new Id<TestProxy.ccllc_evaluatortype>("D339DC5D-D0C7-457C-A4AC-30806A400875");

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

                    #region Existing Transaction with Existing Data Record

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
                            .WithFieldSetTo("new_datafield1", "TestValue"))

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
                service = new OrganizationServiceBuilder()
                    .WithFakeExecute((s, r) => {
                        if (r.RequestName == "new_Action")
                        {                            
                            Assert.AreEqual(Ids.ExistingDataRecord.EntityId, (r["Target"] as EntityReference).Id);
                            Assert.AreEqual(Ids.ExistingTransaction.EntityId, (r["Transaction"] as EntityReference).Id);
                            OrganizationResponse resp = new OrganizationResponse();
                            resp.Results["IsTrue"] = true;
                            return resp;
                        }
                        return s.Execute(r);
                    })
                    .Build();

                var executionContext = GetExecutionContext(service);
                var serializer = new DefaultSerializer();
                var transactionPointer = new RecordPointer<Guid>(Ids.ExistingTransaction.LogicalName, Ids.ExistingTransaction.EntityId);

                var transactionServiceFactory = Container.Resolve<ITransactionServiceFactory>();
                var transactionService = transactionServiceFactory.CreateTransactionService(executionContext, false);

                var transaction = transactionService.LoadTransaction(executionContext, transactionPointer);


                var evaluatorType = new EvaluatorType.DataRecordActionEvaluator(
                    Ids.DataActionEvaluator.ToRecordPointer(), 
                    "TestEvaluator",
                    "S3.D365.Transactions",
                    "CCLLC.BTF.Process.CDS.EvaluatorType.DataReccordActionEvaluator");

                string parameterJson = "{\"ActionName\":\"new_Action\"}";

                var parameters = serializer.CreateParamters(parameterJson);

                var result = evaluatorType.Evaluate(executionContext, parameters, transaction);

                Assert.AreEqual(true, result.Passed);

            }
        }

        #endregion Evaluate_Should_SucceedIfActionReturnsTrue


        #region Evaluate_Should_FailIfActionReturnsFalse

        [TestMethod]
        public void Test_Evaluate_Should_FailIfActionReturnsFalse()
        {
            new Evaluate_Should_FailIfActionReturnsFalse().Test();
        }

        private class Evaluate_Should_FailIfActionReturnsFalse : Common.TestMethodBase
        {
            private struct Ids
            {
                public static readonly Id Contact = new Id<TestProxy.Contact>("15A8A28D-6D48-4C9C-A444-83ABFC05AD97");

                public static readonly Id Agent = new Id<TestProxy.ccllc_agent>("96D52CEC-9364-4886-B504-D5691834C436");

                public static readonly Id Location = new Id<TestProxy.ccllc_location>("B9B41A95-9E50-4230-A53E-B9DAF7CD09B3");

                public static readonly Id Channel1 = new Id<TestProxy.ccllc_channel>("D917D760-1FF5-4065-A6E1-00E31D9101D5");

                public static readonly Id Role1 = new Id<TestProxy.ccllc_role>("880D4D87-E973-436E-8826-CDECBB4915DD");

                public static readonly Id DataActionEvaluator = new Id<TestProxy.ccllc_evaluatortype>("FAFC4636-CB1E-4C64-9845-4DA9951B4163");

                public static readonly Id DataFormStepType = new Id<TestProxy.ccllc_processsteptype>("7F736280-DAE6-4C4D-AF90-F77EA4767AF1");

                public static readonly Id Group1 = new Id<TestProxy.ccllc_transactiongroup>("4BD3EA95-3132-4690-AAED-2CCA39991F74");

                #region Transaction Type 1

                public static readonly Id TransactionType1 = new Id<TestProxy.ccllc_transactiontype>("C3300A23-F584-4B13-B03F-AC22390A4385");

                public static readonly Id TransactionAuthorizedChannel1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedchannel>("3EDA1C84-7F56-4AE4-A1CE-2187659AA574");

                public static readonly Id TransactionAuthorizedRole1_1 = new Id<TestProxy.ccllc_transactiontypeauthorizedrole>("B691101D-5660-4E7C-9AE1-F58E5AA1FE20");

                public static readonly Id TransactionContext1_1 = new Id<TestProxy.ccllc_transactiontypecontext>("662F3776-1DFF-4B6F-B559-249B5F6B00DF");

                public static readonly Id Process1 = new Id<TestProxy.ccllc_transactionprocess>("D5117E01-D7C5-4AFE-9F8C-58095FC909B8");

                public static readonly Id Step1_1 = new Id<TestProxy.ccllc_processstep>("B7A9A26F-782B-413B-8F87-61FB716F2192");


                #endregion

                public static readonly Id ExistingTransaction = new Id<TestProxy.ccllc_transaction>("2A74D1E5-9102-4ED3-B147-A743AE9487AC");
                public static readonly Id ExistingDataRecord = new Id<TestProxy.new_transactiondatarecord>("229DA240-D0C9-4EE7-AEB3-E807EB9E22FF");

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

                    #region Existing Transaction with Existing Data Record

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
                            .WithFieldSetTo("new_datafield1", "TestValue"))

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
                service = new OrganizationServiceBuilder()
                    .WithFakeExecute((s, r) => {
                        if (r.RequestName == "new_Action")
                        {
                            Assert.AreEqual(Ids.ExistingDataRecord.EntityId, (r["Target"] as EntityReference).Id);
                            Assert.AreEqual(Ids.ExistingTransaction.EntityId, (r["Transaction"] as EntityReference).Id);
                            OrganizationResponse resp = new OrganizationResponse();
                            resp.Results["IsTrue"] = false;
                            resp.Results["Message"] = "Action did not succeed.";
                            return resp;
                        }
                        return s.Execute(r);
                    })
                    .Build();

                var executionContext = GetExecutionContext(service);
                var serializer = new DefaultSerializer();
                var transactionPointer = new RecordPointer<Guid>(Ids.ExistingTransaction.LogicalName, Ids.ExistingTransaction.EntityId);

                var transactionServiceFactory = Container.Resolve<ITransactionServiceFactory>();
                var transactionService = transactionServiceFactory.CreateTransactionService(executionContext, false);

                var transaction = transactionService.LoadTransaction(executionContext, transactionPointer);


                var evaluatorType = new EvaluatorType.DataRecordActionEvaluator(
                    Ids.DataActionEvaluator.ToRecordPointer(),
                    "TestEvaluator",
                    "S3.D365.Transactions",
                    "CCLLC.BTF.Process.CDS.EvaluatorType.DataReccordActionEvaluator");

                string parameterJson = "{\"ActionName\":\"new_Action\"}";

                var parameters = serializer.CreateParamters(parameterJson);

                var result = evaluatorType.Evaluate(executionContext, parameters, transaction);

                Assert.AreEqual(false, result.Passed);
                Assert.AreEqual("Action did not succeed.", result.Message);

            }
        }

        #endregion Evaluate_Should_FailIfActionReturnsFalse



    }
}
