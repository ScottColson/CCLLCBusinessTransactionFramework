using System;
using System.Collections.Generic;
using Microsoft.Xrm.Sdk;
using CCLLC.Core;
using CCLLC.BTF.Revenue;

using Xrm.Oss.FluentQuery;

namespace CCLLC.CDS.Test.Fakes
{
    public class FakeAppliedFeeManager : IAppliedFeeManager
    {
        public void AddAppliedFee(IProcessExecutionContext executionContext, IList<IAppliedFee> feeList, IRecordPointer<Guid> transactionId, IRecordPointer<Guid> feeId, decimal? quantity = null)
        {
            var orgService = executionContext.DataService as IOrganizationService;

            var appliedFee = new TestProxy.ccllc_appliedfee()
            {
                ccllc_TransactionId = new EntityReference("ccllc_transaction", transactionId.Id),
                ccllc_FeeId = new EntityReference("ccllc_fee", feeId.Id)
            };

            appliedFee.Id = orgService.Create(appliedFee);
            feeList.Add(new FakeAppliedFee(appliedFee));

        }

        public IList<IAppliedFee> LoadAppliedFees(IProcessExecutionContext executionContext, IRecordPointer<Guid> transactionId, TimeSpan? cacheTimeOut = null)
        {
            var list = new List<IAppliedFee>();
            var service = executionContext.DataService as IOrganizationService;

            var fees = service.Query<TestProxy.ccllc_appliedfee>()
                .IncludeAllColumns()
                .Where(e => e
                    .Attribute(a => a.Named("ccllc_transactionid").Is(Microsoft.Xrm.Sdk.Query.ConditionOperator.Equal).To(transactionId.Id)))
                .RetrieveAll();

            foreach(var f in fees)
            {
                list.Add(new FakeAppliedFee(f));
            }

            return list;
        }

        public void RemoveAppliedFee(IProcessExecutionContext executionContext, IList<IAppliedFee> feeList, IRecordPointer<Guid> feeId, decimal? quantity = null)
        {
            throw new NotImplementedException();
        }
    }
}
