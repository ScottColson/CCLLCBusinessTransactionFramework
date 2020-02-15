using System;
using System.Collections.Generic;

namespace CCLLC.BTF.Documents
{
    using CCLLC.Core;

    public interface IDocumentManager
    {
        IList<IGeneratedDocument> LoadGeneratedDocuments(IProcessExecutionContext executionContext, IRecordPointer<Guid> transactionId, TimeSpan? cacheTimeOut = null);
    }
}
