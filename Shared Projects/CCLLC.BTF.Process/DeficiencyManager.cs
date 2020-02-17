using System;
using System.Collections.Generic;
using CCLLC.Core;

namespace CCLLC.BTF.Process
{
    public class DeficiencyManager : IDeficiencyManager
    {
        public IList<IRequirementDeficiency> LoadDeficiencies(IProcessExecutionContext executionContext, Guid transactionId, TimeSpan? cacheTimeOut = null)
        {
            throw new NotImplementedException();
        }
    }
}
