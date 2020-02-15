using System;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    /// <summary>
    /// Defines attributes for any record in the system that is considerd Data of Record
    /// for a customer such a a credential. 
    /// </summary>
    public interface IDataOfRecord : IRecordPointer<Guid>
    {       
        string ReferenceNumber { get; }
        ICustomer Customer { get; }
    }
}
