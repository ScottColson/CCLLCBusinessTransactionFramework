using System;

using CCLLC.BTF.Platform;
using CCLLC.BTF.Revenue;
using CCLLC.Core;

namespace CCLLC.BTF.Process.StepType
{
    public class AddFee : ProcessStepTypeBase
    {
        private const string feeParameter = "FeeReference";
        private const string feeQuantity = "Quantity";

        public AddFee(string recordType, Guid id, string name, string implementationAssembly, string implementationClass)
            : base(recordType, id, name, implementationAssembly, implementationClass)
        {
        }

        public override bool IsReversable => true;

        public override bool IsUIStep => false;

        public override void Execute(IProcessExecutionContext executionContext, IWorkSession session, ITransaction transaction, ISerializedParameters parameters)
        {
            var feeNumber = parameters[feeParameter];
            var quantity = int.Parse(parameters.ContainsKey(feeQuantity) ? parameters[feeQuantity] : "1");

            var feeList = executionContext.Container.Resolve<IFeeList>();

            var fee = feeList.GetFee(executionContext, feeNumber) ?? throw new Exception("Fee not found.");

            transaction.Fees.AddFee(executionContext, session, fee, quantity);

            var contextRecord = transaction.TransactionContext;
            var dataRecord = transaction.DataRecord;
        }




        public override IUIPointer GetUIPointer(IProcessExecutionContext executionContext, ITransaction transaction, ISerializedParameters parameters)
        {
            return null;
        }

        public override bool Rollback(IProcessExecutionContext executionContext, IWorkSession session, ITransaction transaction, ISerializedParameters parameters)
        {
            throw new NotImplementedException();
        }

        public override void ValidateStepParameters(IProcessExecutionContext executionContext, ISerializedParameters parameters)
        {
            if (!parameters.ContainsKey(feeParameter) || string.IsNullOrEmpty(parameters[feeParameter])) throw new Exception(string.Format("AddFee required parameter '{0}'.", feeParameter));
        }
    }
}
