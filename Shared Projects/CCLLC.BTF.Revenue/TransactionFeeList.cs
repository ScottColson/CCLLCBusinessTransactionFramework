using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CCLLC.BTF.Revenue
{
    using CCLLC.Core;
    using CCLLC.BTF.Platform;

    public class TransactionFeeList : ITransactionFeeList
    {
        private List<IAppliedFee> FeeList { get; }
        private ITransaction Transaction { get; }
        private IRevenueDataConnector DataConnector { get; }
        private IPriceCalculatorFactory PriceCalculatorFactory { get; }

        public IAppliedFee this[int index] => FeeList?[index];

        public int Count => FeeList?.Count ?? 0;

        public TransactionFeeList(IRevenueDataConnector dataConnector, IPriceCalculatorFactory priceCalculatorFactory, ITransaction transaction, IList<IAppliedFee> existingFees)
        {            
            DataConnector = dataConnector ?? throw new ArgumentNullException("dataConnector");
            PriceCalculatorFactory = priceCalculatorFactory ?? throw new ArgumentNullException("priceCalculatorFactory");
            Transaction = transaction ?? throw new ArgumentNullException("transaction");
            FeeList = new List<IAppliedFee>(existingFees ?? throw new ArgumentNullException("existingFees"));
        }

        public void AddFee(IProcessExecutionContext executionContext, IWorkSession session, IRecordPointer<Guid> feeId, decimal quantity = 1)
        {
            try
            {  
                // check to see if the related fee is already in the list. If so we will update that item rather than create
                // a new one.
                var appliedFee = FeeList.Where(r => r.Fee.Id == feeId.Id).FirstOrDefault();

                if (appliedFee is null)
                {
                    var fee = DataConnector.GetFeeRecord(executionContext.DataService, feeId);

                    var appliedFeeRecord = DataConnector.CreateAppliedTransactionFee(
                        executionContext.DataService,
                        Transaction,
                        fee,
                        fee.Name,
                        quantity);

                    appliedFee = new AppliedFee(appliedFeeRecord, fee);

                    var priceCalculator = PriceCalculatorFactory.CreatePriceCalculator(executionContext, session, Transaction);

                    appliedFee.CalculatePrice(executionContext, null);
                    DataConnector.UpdateAppliedTransactionFee(executionContext.DataService, appliedFee);

                    FeeList.Add(appliedFee);
                }
                else
                {
                    throw new NotImplementedException("Modifying an existing applied fee is not implemented yet.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


            throw new NotImplementedException();
        }

        public void RemoveFee(IProcessExecutionContext executionContext, IWorkSession session, IRecordPointer<Guid> feeId, decimal quantity = 1)
        {
            throw new NotImplementedException();
        }        

        public IEnumerator<IAppliedFee> GetEnumerator()
        {
            return FeeList?.GetEnumerator();
        }        

        IEnumerator IEnumerable.GetEnumerator()
        {
            return FeeList?.GetEnumerator();
        }
    }
}
