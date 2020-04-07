using System;
using System.Collections.Generic;
using CCLLC.BTF.Documents;
using CCLLC.Core;

namespace CCLLC.CDS.Test.Fakes
{
    public class FakeDocumentService : IDocumentService
    {       
        public IList<IGeneratedDocument> LoadGeneratedDocuments(IProcessExecutionContext executionContext, IRecordPointer<Guid> transactionId, TimeSpan? cacheTimeOut = null)
        {
            throw new NotImplementedException();
        }
    }
}
