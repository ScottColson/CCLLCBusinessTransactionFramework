using System;

namespace CCLLC.BTF.Process
{
    [Flags]
    public enum eRequirementTypeFlags
    {
        Evidence = 1,
        Eligibility = 2,
        Prerequisite = 4,
        Validation = 8  
    }
}
