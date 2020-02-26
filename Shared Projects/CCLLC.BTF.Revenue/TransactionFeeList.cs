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
        private List<ITransactionFee> FeeList { get; }
        private ITransaction Transaction { get; }
        private IRevenueDataConnector DataConnector { get; }
        private IPriceCalculatorFactory PriceCalculatorFactory { get; }

        public ITransactionFee this[int index] => FeeList?[index];

        public int Count => FeeList?.Count ?? 0;

        public TransactionFeeList(IRevenueDataConnector dataConnector, IPriceCalculatorFactory priceCalculatorFactory, ITransaction transaction, IList<ITransactionFee> existingFees)
        {            
            DataConnector = dataConnector ?? throw new ArgumentNullException("dataConnector");
            PriceCalculatorFactory = priceCalculatorFactory ?? throw new ArgumentNullException("priceCalculatorFactory");
            Transaction = transaction ?? throw new ArgumentNullException("transaction");
            FeeList = new List<ITransactionFee>(existingFees ?? throw new ArgumentNullException("existingFees"));
        }

        public void AddFee(IProcessExecutionContext executionContext, IWorkSession session, IRecordPointer<Guid> feeId, decimal quantity = 1)
        {
            try
            {
               
                // check to see if the related fee is already in the list. If so we will update that item rather than create
                // a new one.
                var transactionFee = FeeList.Where(r => r.Fee.Id == feeId.Id).FirstOrDefault();

                if (transactionFee is null)
                {
                    var fee = DataConnector.GetFee(executionContext.DataService, feeId);

                    var transactionFeeRecord = DataConnector.CreateTransactionFee(
                        executionContext.DataService,
                        Transaction,
                        fee,
                        fee.Name,
                        quantity);

                    transactionFee = new TransactionFee(transactionFeeRecord, fee);
                    FeeList.Add(transactionFee);                                   
                }
                else
                {
                    transactionFee.IncrementQuantity(quantity);                                        
                }

                var priceCalculator = PriceCalculatorFactory.CreatePriceCalculator(executionContext, session, Transaction);
                transactionFee.CalculatePrice(executionContext, priceCalculator);

                DataConnector.UpdateTransactionFee(executionContext.DataService, transactionFee);                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void RemoveFee(IProcessExecutionContext executionContext, IWorkSession session, IRecordPointer<Guid> feeId, decimal quantity = 1)
        {
            throw new NotImplementedException();
        }        

        public IEnumerator<ITransactionFee> GetEnumerator()
        {
            return FeeList?.GetEnumerator();
        }        

        IEnumerator IEnumerable.GetEnumerator()
        {
            return FeeList?.GetEnumerator();
        }
    }
}
