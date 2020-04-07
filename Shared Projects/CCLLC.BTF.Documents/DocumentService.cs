using System;
using System.Collections.Generic;

namespace CCLLC.BTF.Documents
{
    using CCLLC.Core;

    public class DocumentService : IDocumentService
    {
        public IList<IGeneratedDocument> LoadGeneratedDocuments(IProcessExecutionContext executionContext, IRecordPointer<Guid> transactionId, TimeSpan? CacheTimeout = null)
        {
            throw new NotImplementedException();
        }

       
    }
}
