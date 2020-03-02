using System;
using System.Collections.Generic;
using CCLLC.Core;

namespace CCLLC.BTF.Process
{
    public interface IDeficiencyManager
    {
        /// <summary>
        /// Loads all deficiencies for the specififed transaction id. Caches results if cacheTimeOut is set.
        /// </summary>
        /// <param name="executionContext"></param>
        /// <param name="transactionId"></param>
        /// <param name="cacheTimeOut"></param>
        /// <returns></returns>
        IList<IRequirementDeficiency> LoadDeficiencies(IProcessExecutionContext executionContext, Guid transactionId, bool useCache = true);
    }
}
