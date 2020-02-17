using System;
using CCLLC.Core;
using CCLLC.BTF.Platform;

namespace CCLLC.BTF.Process
{
    public class AlternateBranch : RecordPointer<Guid>, IAlternateBranch
    {
        protected ILogicEvaluator LogicEvaluator { get; }
     
        public string Name { get; }

        public int EvaluationOrder { get; }

        public IRecordPointer<Guid> ParentStepPointer { get; }

        public IRecordPointer<Guid> SubsequentStepPointer { get; }

        public ILogicEvaluatorType Type => LogicEvaluator?.Type;

        public ISerializedParameters Parameters => LogicEvaluator?.Parameters;

        internal protected AlternateBranch(string recordType, Guid id, string name, int evaluationOrder, IRecordPointer<Guid> parentStepPointer, IRecordPointer<Guid> subsequentStepPointer, 
            ILogicEvaluator logicEvaluator) : base(recordType, id)
        {
            try
            {               
                Name = name ?? throw new ArgumentNullException("name");
                EvaluationOrder = evaluationOrder;
                ParentStepPointer = parentStepPointer ?? throw new ArgumentNullException("parentStepPointer");
                SubsequentStepPointer = subsequentStepPointer;
                LogicEvaluator = logicEvaluator ?? throw new ArgumentNullException("logicEvaluator");
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public ILogicEvaluationResult Evaluate(IProcessExecutionContext executionContext, IRecordPointer<Guid> transactionRecordPointer)
        {
            return LogicEvaluator?.Evaluate(executionContext, transactionRecordPointer);
        }
    }
}
