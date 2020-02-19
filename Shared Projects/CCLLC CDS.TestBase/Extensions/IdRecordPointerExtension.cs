using System;
using CCLLC.Core;

namespace CCLLC.CDS.TestBase
{
    public static class IdRecordPointerExtension
    {
        public static IRecordPointer<Guid> ToRecordPointer(this DLaB.Xrm.Test.Id id)
        {
            return new RecordPointer<Guid>(id.LogicalName, id.EntityId);
        }
       
    }
}
