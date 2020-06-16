/// <reference path="../../../node_modules/@types/xrm/index.d.ts" />
/// <reference path="transaction-actions.ts" />

namespace CCLLC.Transactions.CommandBar {

    interface IAvailableTransactionType {
        GroupName: string,
        TypeName: string,
        TypeId: string,
        Icon: string
    };

    interface IUIPointer {
        UIType: string,
        RecordType: string,
        RecordId: string,
        Definition: string
    }

    export class Commands {

        static populateTransactionFlyout(commandProperties: CommandProperties, formContext: Xrm.FormContext, ribbonCommand: string) {
            
            var recordType = formContext.data.entity.getEntityName();
            var recordId = formContext.data.entity.getId();

            commandProperties.PopulationXML = Commands.getTransactionOptionsXml(recordType, recordId, ribbonCommand);
        }


        static initiateTransaction(commandProperties: CommandProperties, formContext: Xrm.FormContext) {

            var recordType = formContext.data.entity.getEntityName();
            var recordId = formContext.data.entity.getId();
            var transactionTypeId = commandProperties.SourceControlId;

            Xrm.Page.data.refresh(true)
                .then(() => {
                    CCLLC.Transactions.CommandBar.Actions.InitiateTransactionAsync(recordType, recordId, transactionTypeId)
                        .then((result) => {

                            var uiPointer: IUIPointer = JSON.parse(result.UIPointer);
                            this.processUIPointer(uiPointer)
                                .catch((error: Error) => {
                                    this.errorHandler(error);
                                });
                        })
                        .catch((error: Error) => {
                            this.errorHandler(error);
                        });

                })
                .catch((reason: Xrm.ErrorResponse) => {
                    this.errorHandler(new Error(reason.message));
                });
                
        }


        static async canNavigateForward(commandProperties: CommandProperties, formContext: Xrm.FormContext, transactionFieldName: string) {

            try {              
                var transactionId = formContext.data.entity.attributes
                    .get<Xrm.Page.LookupAttribute>(transactionFieldName)
                    .getValue()[0].id;

                var result = await CCLLC.Transactions.CommandBar.Actions.CanNavigateForwardAsync(transactionId);

                return result.IsAllowed;
            }
            catch (error) {
                this.errorHandler(error);
            }
        }

        static async canNavigateBackward(commandProperties: CommandProperties, formContext: Xrm.FormContext, transactionFieldName: string) {

            try {
                var transactionId = formContext.data.entity.attributes
                    .get<Xrm.Page.LookupAttribute>(transactionFieldName)
                    .getValue()[0].id;

                var result = await CCLLC.Transactions.CommandBar.Actions.CanNavigateBackwardAsync(transactionId);

                return result.IsAllowed;
            }
            catch (error) {
                this.errorHandler(error);
            }
        }

        static navigateForward(commandProperties: CommandProperties, formContext: Xrm.FormContext, transactionFieldName: string) {

            var transactionId = formContext.data.entity.attributes
                .get<Xrm.Page.LookupAttribute>(transactionFieldName)
                .getValue()[0].id;

            Xrm.Page.data.refresh(true)
                .then(() => {
                    CCLLC.Transactions.CommandBar.Actions.NavigateForwardAsync(transactionId)
                        .then((result) => {
                            var uiPointer: IUIPointer = JSON.parse(result.UIPointer);
                            this.processUIPointer(uiPointer)
                                .catch((error: Error) => {
                                    this.errorHandler(error);
                                });
                        })
                        .catch((error: Error) => {
                            this.errorHandler(error);
                        });
                })
                .catch((reason: Xrm.ErrorResponse) => {
                    this.errorHandler(new Error(reason.message));
                });
        }

        static navigateBackward(commandProperties: CommandProperties, formContext: Xrm.FormContext, transactionFieldName: string) {

            var transactionId = formContext.data.entity.attributes
                .get<Xrm.Page.LookupAttribute>(transactionFieldName)
                .getValue()[0].id;

            Xrm.Page.data.refresh(true)
                .then(() => {
                    CCLLC.Transactions.CommandBar.Actions.NavigateBackwardAsync(transactionId)
                        .then((result) => {
                            var uiPointer: IUIPointer = JSON.parse(result.UIPointer);
                            this.processUIPointer(uiPointer)
                                .catch((error: Error) => {
                                    this.errorHandler(error);
                                });
                        })
                        .catch((error: Error) => {
                            this.errorHandler(error);
                        });
                })
                .catch((reason: Xrm.ErrorResponse) => {
                    this.errorHandler(new Error(reason.message));
                });
        }


        /* 
         * Builds the required XML for the dynamically generated command bar buttons for transactions.
         *   recordType: The entity logical name of the record where the button menu is being populated.
         *   recordId: The id of the record where the menu is being populated
         *   ribbonCommand: The ribbon command that will be attached to each dynamically created button.
         */
        private static async getTransactionOptionsXml(recordType: string, recordId: string, ribbonCommand: string) {

            var result = await CCLLC.Transactions.CommandBar.Actions.GetTransactionTypesAsync(recordType, recordId);
                  
            var items: Array<IAvailableTransactionType> = JSON.parse(result.TransactionTypes);
          
            const ribbonMenuSection = new RibbonMenu("ccllc.common.TransactionTypes.Button.Menu");
            var actionSection: RibbonMenuSection = null;
           
            var sectionName: string = null;
            var sectionCount = 0;
            var buttonCount = 0;

            items.forEach((item) => {
                if (sectionName == null || sectionName != item.GroupName) {
                    if (actionSection != null) {
                        ribbonMenuSection.addSection(actionSection);
                    }
                    sectionName = item.GroupName;
                    sectionCount++;
                    actionSection = new RibbonMenuSection("Section"+sectionCount, sectionName, sectionCount, "Menu16");
                }

                buttonCount++;

                // add button setting the id of the button to the GUID of the 
                // corresponding Transaction Type. This GUID will get passed in 
                // when the button is clicked.
                actionSection.addButton(new RibbonButton(
                    item.TypeId,
                    buttonCount,
                    item.TypeName,
                    ribbonCommand,                    
                    null,
                    null));
            });

            if (actionSection != null) {
                ribbonMenuSection.addSection(actionSection);
            }

            var xml = ribbonMenuSection.serialiseToRibbonXml();  
            return xml;
        }

        /*
         * Process navigation or display instructions encoded in a UI pointer object.
         */
        private static async processUIPointer(uiPointer: IUIPointer) {

            try {
                if (uiPointer.UIType == "DataForm") {                   
                    if (uiPointer.Definition.toLowerCase() == "default") {

                        // Navigate to the last form used. 
                        var formOptions: Xrm.Navigation.EntityFormOptions = {
                            entityName: uiPointer.RecordType,
                            entityId: uiPointer.RecordId
                        };

                        await Xrm.Navigation.openForm(formOptions).catch((error) => { throw error });
                    }
                    else {                        
                        // Navigate to the specified form id
                        var formOptions: Xrm.Navigation.EntityFormOptions = {
                            entityName: uiPointer.RecordType,
                            entityId: uiPointer.RecordId,
                            formId: uiPointer.Definition
                        };

                        await Xrm.Navigation.openForm(formOptions).catch((error) => { throw error });

                    }
                }
                else {
                    throw new Error(uiPointer.UIType + " is not a supported UI type.");
                }
            }
            catch(error){
                throw error;
            }
            

        }

        /*
         * Standard error handler for script related errors.
         */
        private static errorHandler(error: Error) {
            Xrm.Utility.alertDialog(error.message, () => { });
        }
    }
}
       
