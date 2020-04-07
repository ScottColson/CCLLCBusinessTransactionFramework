using System;
using System.Collections.Generic;

namespace CCLLC.BTF.Documents
{
    using CCLLC.Core;

    public interface IDocumentService
    {
        IList<IGeneratedDocument> LoadGeneratedDocuments(IProcessExecutionContext executionContext, IRecordPointer<Guid> transactionId, TimeSpan? cacheTimeOut = null);
    }
}
