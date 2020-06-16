/// <reference path="ribbon-lib.ts" />
/// <reference path="../legacywebapi.ts" />
/// <reference path="../../../node_modules/@types/xrm/index.d.ts" />
namespace CCLLC.Transactions.CommandBar {

    interface IRequestMetaData {
        boundParameter: string,
        operationName: string,
        operationType: number,
        parameterTypes: object
    }

    interface IExecuteRequest {
        getMetadata: () => IRequestMetaData
    }

    interface IBTF_GetAvailableTransactionTypesRequest extends IExecuteRequest {
        ContextRecordType: string;
        ContextRecordId: string;
    }

    /*
     * Response from the ccllc_BTF_GetAvailableTransactionTypes action.
     */
    export interface IBTF_GetAvailableTransactionTypesResponse {
        TransactionTypes: string
    }

    /*
     * Response from the ccllc_BTF_InitiateTransaction action.
     */
    export interface IBTF_InitiateTransactionResponse {
        UIPointer: string;
    }

    /*
     * Response from the ccllc_BTF_CanNavigateForward action.
     */
    export interface IBTF_CanNavigateForwardResponse {
        IsAllowed: boolean;
    }

    /*
     * Response from the ccllc_BTF_CanNavigateBackward action.
     */
    export interface IBTF_CanNavigateBackwardResponse {
        IsAllowed: boolean;
    }

    /*
     * Response from the ccllc_BTF_NavigateForward action.
     */
    export interface IBTF_NavigateForwardResponse {
        UIPointer: string;
    }

    /*
     * Response from the ccllc_BTF_NavigateBackward action.
     */
    export interface IBTF_NavigateBackwardResponse {
        UIPointer: string;
    }
  
    interface IBTF_InitiateTransactionRequest extends IExecuteRequest {
        ContextRecordType: string;
        ContextRecordId: string;
        TransactionTypeId: string
        UserId?: string;
    }

    class BTF_GetAvailableTransactionTypesRequest implements IBTF_GetAvailableTransactionTypesRequest {

        constructor(public ContextRecordType: string, public ContextRecordId: string) {
        }

        getMetadata = () => {

            var metadata: IRequestMetaData = {
                boundParameter: null,
                operationName: "ccllc_BTF_GetAvailableTransactionTypes",
                operationType: 0,
                parameterTypes: {
                    "ContextRecordType": {
                        "typeName": "Edm.String",
                        "structuralProperty": 1
                    },
                    "ContextRecordId": {
                        "typeName": "Edm.String",
                        "structuralProperty": 1
                    },
                    "UserId": {
                        "typeName": "mscrm.systemuser",
                        "structuralProperty": 5 //Entity Type
                    }
                }
            }

            return metadata;
        }
    }

    class TMF_InitiateTransactionRequest implements IBTF_InitiateTransactionRequest {

        ContextRecordType: string;
        ContextRecordId: string;
        TransactionTypeId: string;
        UserId: string;

        constructor(public contextRecordType: string, public contextRecordId: string, public transactionTypeId, string, public userId?: string) {
            this.ContextRecordType = contextRecordType;
            this.ContextRecordId = contextRecordId;
            this.transactionTypeId = transactionTypeId;
            this.UserId = userId;
        }

        getMetadata = () => {

            var metadata: IRequestMetaData = {
                boundParameter: null,
                operationName: "ccllc_BTF_GetAvailableTransactionTypes",
                operationType: 0,
                parameterTypes: {
                    "ContextyRecordType": {
                        "typeName": "Edm.String",
                        "structuralProperty": 1
                    },
                    "ContextyRecordId": {
                        "typeName": "Edm.String",
                        "structuralProperty": 1
                    },
                    "TransactionTypeId": {
                        "typeName": "mscrm.ccllc_transactiontype",
                        "structuralProperty": 5 //Entity Type
                    },
                    "UserId": {
                        "typeName": "mscrm.systemuser",
                        "structuralProperty": 5 //Entity Type
                    }
                }
            }

            return metadata;
        }
    }

    
    export class Actions {

        /*
         * Call the unbound ccllc_BTF_GetAvailableTransactionTypes action to get a list of registered transaction types that
         * are authorized for the current Agent (user) and the current record. 
        */
        static async GetTransactionTypesAsync(contextRecordType: string, contextRecordId: string) {
            
            var params = {
                "ContextRecordType": contextRecordType,
                "ContextRecordId": contextRecordId
            };

            var result = await CCLLC.Common.LegacyWebApi.executeGlobalActionAsync("ccllc_BTF_GetAvailableTransactionTypes", params) as IBTF_GetAvailableTransactionTypesResponse;
            return result;
        }

        /*
         * Call the unbound ccllc_BTF_InitiateTransactionAction to create a new Transaction and initiate the transaction process 
         * for that Transaction. Return the UI Pointer required to update the user screens.
         */
        static async InitiateTransactionAsync(contextRecordType: string, contextRecordId: string, transactionTypeId: string): Promise<IBTF_InitiateTransactionResponse> {
          

            var transactionType = {
                "ccllc_transactiontypeid": transactionTypeId
            };
            transactionType["@odata.type"] = "Microsoft.Dynamics.CRM.ccllc_transactiontype";
            
            var params = {
                "ContextRecordType": contextRecordType,
                "ContextRecordId": contextRecordId,
                "TransactionTypeId": transactionType
            };

            var result = await CCLLC.Common.LegacyWebApi.executeGlobalActionAsync("ccllc_BTF_InitiateTransaction", params) as IBTF_InitiateTransactionResponse;
            return result;
        }
        
        static async CanNavigateForwardAsync(transactionId: string): Promise<IBTF_CanNavigateForwardResponse> {

            var params = {};
            var result = await CCLLC.Common.LegacyWebApi.executeActionAsync("ccllc_transactions", transactionId, "ccllc_BTF_CanNavigateForward", params) as IBTF_CanNavigateForwardResponse
            return result;            
        }

        static async CanNavigateBackwardAsync(transactionId: string): Promise<IBTF_CanNavigateBackwardResponse> {

            var params = {};

            var result = await CCLLC.Common.LegacyWebApi.executeActionAsync("ccllc_transactions", transactionId, "ccllc_BTF_CanNavigateBackward", params) as IBTF_CanNavigateBackwardResponse
            return result;
        }

        static async NavigateForwardAsync(transactionId: string): Promise<IBTF_NavigateForwardResponse> {

            var params = {};

            var result = await CCLLC.Common.LegacyWebApi.executeActionAsync("ccllc_transactions", transactionId, "ccllc_BTF_NavigateForward", params) as IBTF_NavigateForwardResponse
            return result;
        }

        static async NavigateBackwardAsync(transactionId: string): Promise<IBTF_NavigateBackwardResponse> {

            var params = {};

            var result = await CCLLC.Common.LegacyWebApi.executeActionAsync("ccllc_transactions", transactionId, "ccllc_BTF_NavigateBackward", params) as IBTF_NavigateBackwardResponse
            return result;
        }
    }

}

