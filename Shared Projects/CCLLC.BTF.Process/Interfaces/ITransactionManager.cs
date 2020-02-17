using System;
using System.Collections.Generic;
using CCLLC.Core;
using CCLLC.BTF.Platform;

namespace CCLLC.BTF.Process
{
    public interface ITransactionManager
    {
        /// <summary>
        /// Returns a read only list of all <see cref="ITransactionType"/> records registered in the system.
        /// </summary>
        IReadOnlyList<ITransactionType> RegisteredTransactionTypes { get; }

        /// <summary>
        /// Returns a read only list of <see cref="ITransactionType"/> records that are available for the current <see cref="IWorkSession"/> and <see cref="IContextRecord"/>.
        /// </summary>
        /// <param name="workSession"></param>
        /// <param name="contextRecord"></param>
        /// <returns></returns>
        IReadOnlyList<ITransactionType> GetAvaialbleTransactionTypes(IProcessExecutionContext executionContext, IWorkSession workSession, ITransactionContext transactionContext);

        /// <summary>
        /// Loads a transaction from the data store using the specified id value.
        /// </summary>
        /// <param name="executionContext"></param>
        /// <param name="transactionId"></param>
        /// <returns></returns>
        ITransaction LoadTransaction(IProcessExecutionContext executionContext, IRecordPointer<Guid> transactionId);

        /// <summary>
        /// Creates a new transaction and saves it to the data store before returning it.
        /// </summary>
        /// <param name="executionContext"></param>
        /// <param name="workSession"></param>
        /// <param name="contextRecord"></param>
        /// <param name="transactionType"></param>
        /// <returns></returns>
        ITransaction NewTransaction(IProcessExecutionContext executionContext, IWorkSession workSession, ITransactionContext transactionContext, ITransactionType transactionType);

        /// <summary>
        /// Loads the transaction data record associated with the specified transaction. Creates a new 
        /// transaction data record if one does not already exist in the data store.
        /// </summary>
        /// <param name="executionContext"></param>
        /// <param name="transaction"></param>

        /// <returns></returns>
        ITransactionDataRecord LoadTransactionDataRecord(IProcessExecutionContext executionContext, ITransaction transaction);

        /// <summary>
        /// Returns a list of <see cref="IDataOfRecord"/> items for data store records that are linked to the specified transaction. The
        /// system only searches for records of data types specified and all specified types must have a customer and transaction reference.
        /// </summary>
        /// <param name="executionContext"></param>
        /// <param name="transactionId"></param>
        /// <param name="affectedRecordTypes"></param>
        /// <returns></returns>
        IList<IDataOfRecord> LoadAffectedRecords(IProcessExecutionContext executionContext, IRecordPointer<Guid> transactionId, IEnumerable<string> affectedRecordTypes);

        /// <summary>
        /// Update the current step for the transaction in the data store.
        /// </summary>
        /// <param name="executionContext"></param>
        /// <param name="transactionId"></param>
        /// <param name="currentStepId"></param>
        void SaveTransactionCurrentStep(IProcessExecutionContext executionContext, IRecordPointer<Guid> transactionId, IRecordPointer<Guid> currentStepId);
       
    }
}
