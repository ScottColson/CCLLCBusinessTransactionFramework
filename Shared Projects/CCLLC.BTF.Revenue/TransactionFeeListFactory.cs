using System;
using System.Collections.Generic;

namespace CCLLC.BTF.Revenue
{
    using CCLLC.Core;

    public class TransactionFeeListFactory : ITransactionFeeListFactory
    {
        private IRevenueDataConnector DataConnector { get; }
        private IPriceCalculatorFactory PriceCalculatorFactory { get; }
      
        public TransactionFeeListFactory(IRevenueDataConnector dataConnector, IPriceCalculatorFactory priceCalculatorFactory)
        {
            DataConnector = dataConnector ?? throw new ArgumentNullException("dataConnector");
            PriceCalculatorFactory = priceCalculatorFactory ?? throw new ArgumentNullException("pricingCalculatorFactory");
        }

        public ITransactionFeeList CreateFeeList(IProcessExecutionContext executionContext, ITransaction transaction)
        {
            try
            {
                if (executionContext is null) throw new ArgumentNullException("executionContext");
                if (transaction is null) throw new ArgumentNullException("transaction");                             

                IList<ITransactionFee> transactionFees = new List<ITransactionFee>();

                var transactionFeeRecords = DataConnector.GetTransactionFees(executionContext.DataService, transaction);

                foreach (var r in transactionFeeRecords)
                {
                    var fee = r.Fee != null ? DataConnector.GetFee(executionContext.DataService, r.Fee) : null;
                    transactionFees.Add(new TransactionFee(r, fee));
                }

                return new TransactionFeeList(this.DataConnector, this.PriceCalculatorFactory, transaction, transactionFees);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
