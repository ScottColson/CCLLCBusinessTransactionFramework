using System;

namespace CCLLC.BTF.Process
{
    [Serializable]
    public static class TransactionException 
    {
        public enum ErrorCode {
            ActionNotAvailable,
            ProcessNotFound,
            ProcessInvalid,
            ProcessStepNotFound,
            ProcessStepInvalid,
            ProcessStepTypeNotFound,
            ProcessStepTypeInvalid,
            ProcessStepTypeActivationFailure,   
            ProcessNavigationError,
            StepHistoryNotFound,
            StepHistoryInvalid,
            DataRecordMissingTransactionId,
            DataRecordMissingCustomerId,
            TransactionMissingTypeId,
            TransactionTypeNotFound
        }
             
        
        public static Exception BuildException(ErrorCode errorCode)
        {
            return new InvalidOperationException(getMessage(errorCode));
        }


        public static Exception BuildException(ErrorCode errorCode, Exception innerException)
        {
            return new InvalidOperationException(string.Format("{0}: {1}",getMessage(errorCode),innerException.Message), innerException);
        }

        private static string getMessage(ErrorCode errorCode)
        {
            switch (errorCode)
            {
                case ErrorCode.ActionNotAvailable:
                    return "The specified action is not avaialble.";

                case ErrorCode.ProcessNotFound:
                    return "The requested transaction process could not be found.";
                case ErrorCode.ProcessInvalid:
                    return "The transaction process configuration is invalid.";

                case ErrorCode.ProcessStepNotFound:
                    return "The transaction process step could not be found.";
                case ErrorCode.ProcessStepInvalid:
                    return "The transaction process step configuration is invalid.";

                case ErrorCode.ProcessStepTypeNotFound:
                    return "The process step type could not be found.";
                case ErrorCode.ProcessStepTypeInvalid:
                    return "The process step type configuration is invalid.";
                case ErrorCode.ProcessStepTypeActivationFailure:
                    return "The implementation for the process step type failed.";

                case ErrorCode.DataRecordMissingTransactionId:
                    return "The data record is missing the transaction id value that links it to the transaction.";
                case ErrorCode.TransactionMissingTypeId:
                    return "The transaction record is missing the required transaction type id.";
                case ErrorCode.TransactionTypeNotFound:
                    return "The requested transaction type was not found.";
                default:
                    return errorCode.ToString();
            }
        }
    }
}
