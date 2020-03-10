using System;
using System.Collections.Generic;
using CCLLC.Core;

namespace CCLLC.BTF.Process
{
    public class DeficiencyManager : IDeficiencyManager
    {
        public IList<IRequirementDeficiency> LoadDeficiencies(IProcessExecutionContext executionContext, Guid transactionId, bool useCache = true)
        {
            throw new NotImplementedException();
        }
    }
}
