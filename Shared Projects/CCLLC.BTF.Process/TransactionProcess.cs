using System;
using System.Collections.Generic;
using System.Linq;
using CCLLC.Core;

namespace CCLLC.BTF.Process
{
    public class TransactionProcess : RecordPointer<Guid>, ITransactionProcess
    {       
        public string Name { get; }

        public IRecordPointer<Guid> TransactionTypeId { get; }

        public Guid InitialStepId { get; }

        private readonly List<IProcessStep> processSteps;
        public IReadOnlyList<IProcessStep> ProcessSteps => processSteps;

        protected internal TransactionProcess (IRecordPointer<Guid> processId, string name, IRecordPointer<Guid> transactionTypeId, Guid initialStepId, IEnumerable<IProcessStep> processSteps)
            : base(processId)
        {
            if(processSteps == null) { throw new ArgumentNullException("processSteps is null."); }

            this.Name = name;
            this.TransactionTypeId = transactionTypeId ?? throw new ArgumentNullException("transactionTypeId is null.");
            this.InitialStepId = initialStepId;
            this.processSteps = processSteps.ToList();
        }

        public virtual IProcessStep GetInitialStep()
        {
            var step = processSteps.Where(s => s.Id == InitialStepId).FirstOrDefault();

            if(step == null) { throw TransactionException.BuildException(TransactionException.ErrorCode.ProcessNotFound); }

            return step;
        }
    }
}
