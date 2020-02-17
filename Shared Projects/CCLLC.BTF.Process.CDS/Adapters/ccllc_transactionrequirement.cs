using System;
using System.Collections.Generic;
using Microsoft.Xrm.Sdk;
using CCLLC.Core;

namespace CCLLC.BTF.Process.CDS
{
    public partial class ccllc_transactionrequirement : ITransactionRequirementRecord
    {
        public string Name => this.ccllc_name;

        public eTransactionRequirementTypeFlags? TypeFlag
        {
            get
            {
                IEnumerable<OptionSetValue> options = (IEnumerable<OptionSetValue>)this.ccllc_TransactionRequirementTypeCode;

                eTransactionRequirementTypeFlags? flags = null;
                if (options != null)
                {
                    foreach (var o in options)
                    {
                        var val = Enum.IsDefined(typeof(eTransactionRequirementTypeFlags), o.Value) ? (eTransactionRequirementTypeFlags)o.Value : throw new Exception("Invalid transaction requirement type.");
                        if (flags == null)
                        {
                            flags = val;
                        }
                        else
                        {
                            flags = flags & val;
                        }
                    }

                    return flags.Value;
                }

                return null;               
            }
        }

        public IRecordPointer<Guid> TransactionTypeId => this.ccllc_TransactionTypeId?.ToRecordPointer();

        public IRecordPointer<Guid> EvaluatorTypeId => this.ccllc_EvaluatorTypeId?.ToRecordPointer();

        public string RecordType => this.LogicalName;

        public string RequirementParameters => this.ccllc_RequirementParameters;
    }
}
