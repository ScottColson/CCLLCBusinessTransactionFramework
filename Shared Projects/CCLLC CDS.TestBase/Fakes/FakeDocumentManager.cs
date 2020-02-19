using System;
using System.Collections.Generic;
using CCLLC.BTF.Documents;
using CCLLC.Core;

namespace CCLLC.CDS.Test.Fakes
{
    public class FakeDocumentManager : IDocumentManager
    {       
        public IList<IGeneratedDocument> LoadGeneratedDocuments(IProcessExecutionContext executionContext, IRecordPointer<Guid> transactionId, TimeSpan? cacheTimeOut = null)
        {
            throw new NotImplementedException();
        }
    }
}
