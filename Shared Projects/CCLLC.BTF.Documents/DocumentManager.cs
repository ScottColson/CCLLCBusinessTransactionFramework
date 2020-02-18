using System;
using System.Collections.Generic;

namespace CCLLC.BTF.Documents
{
    using CCLLC.Core;

    public class DocumentManager : IDocumentManager
    {
        public IList<IGeneratedDocument> LoadGeneratedDocuments(IProcessExecutionContext executionContext, IRecordPointer<Guid> transactionId, TimeSpan? CacheTimeout = null)
        {
            throw new NotImplementedException();
        }

       
    }
}
