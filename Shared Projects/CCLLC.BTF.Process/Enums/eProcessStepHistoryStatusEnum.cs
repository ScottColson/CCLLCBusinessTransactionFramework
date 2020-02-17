namespace CCLLC.BTF.Process
{
    public enum eProcessStepHistoryStatusEnum
    {                
        Current = 1,    // history is for a process step that has executed and is part of the current process path.
        Archived,       // history is for a process step that is no longer part of the current process path.
        RolledBack      // history is for a process step where execution was rolled back and the step is no longer 
                        // part of the current process path.
    }
}
