using System;
using System.Collections.Generic;
using CCLLC.Core;
using CCLLC.BTF.Platform;

namespace CCLLC.BTF.Process
{
    /// <summary>
    /// Defines information needed to evaluate the context of an existing record
    /// to determine if a transaction can start and provide the information needed
    /// to start a transaction.
    /// </summary>
    public interface ITransactionContext : IRecordPointer<Guid>
    {       
        int RecordStatus { get; }
        ICustomer Customer { get; }

        bool IsContextType(IContextType contextType);
        bool IsContextType(IEnumerable<IContextType> contextTypes);
        
    }
}
