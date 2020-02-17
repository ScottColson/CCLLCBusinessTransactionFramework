using System;
using System.Collections.Generic;
using CCLLC.Core;
using CCLLC.BTF.Platform;

namespace CCLLC.BTF.Process
{
    public interface IProcessStepFactory
    {
        IProcessStep CreateProcessStep(IProcessExecutionContext executionContext, IRecordPointer<Guid> stepId, string name, IRecordPointer<Guid> transactionProcessPointer,
            IProcessStepType processStepType, string parameters, IRecordPointer<Guid> subsequentStepPointer, IEnumerable<IAlternateBranch> alternateBranches,
            IEnumerable<IChannel> authorizedChannels, IEnumerable<IStepRequirement> validationRequirements, TimeSpan? cacheTimeout = null);
    }
}
