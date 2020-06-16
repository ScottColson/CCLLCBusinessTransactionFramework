/// <reference path="../../node_modules/@types/xrm/index.d.ts" />
namespace CCLLC.Common {

    /* LegacyWebApi
     * 
     * Implements executeAction and executeGlobal action using the direct XMLHttpRequests. This
     * class is required because the Xrm.WebApi.online.execute method current does not work with 
     * the Unified Client interface when working with actions that return output parameters.
     */
    export class LegacyWebApi {

        private static getClientUrl(): string {           
            var context = Xrm.Utility.getGlobalContext();
            return context.getClientUrl();
        }

        private static getWebAPIPath(): string {
            return this.getClientUrl() + "/api/data/v9.0";
        }

        private static errorHandler(req: XMLHttpRequest): Error {

            //Error descriptions come from http://support.microsoft.com/kb/193625
            if (req.status == 12029) {
                return new Error("The attempt to connect to the server failed.");
            }
            if (req.status == 12007) {
                return new Error("The server name could not be resolved.");
            }
            if (req.status == 500) {
                errorText = JSON.parse(req.responseText).error.message;
                return new Error(errorText);
            }
            var errorText;
            try {
                errorText = JSON.parse(req.responseText).error.message.value;
            }
            catch (e) {
                errorText = req.responseText
            }

            return new Error("Error : " + req.status + ": " + req.statusText + ": " + errorText);
        }

        private static dateReviver(key: string, value: any): any {

            var a;
            if (typeof value === 'string') {
                a = /^(\d{4})-(\d{2})-(\d{2})T(\d{2}):(\d{2}):(\d{2}(?:\.\d*)?)Z$/.exec(value);
                if (a) {
                    return new Date(Date.UTC(+a[1], +a[2] - 1, +a[3], +a[4], +a[5], +a[6]));
                }
            }
            return value;
        }

        /*
         * Execute an unbound action asynchronously.
         */
        static executeGlobalActionAsync(actionName: string, params: object): Promise<object> {

            return new Promise<object>((resolve, reject) => {

                var uri = encodeURI(this.getWebAPIPath()) + "/" + actionName;
                var req = new XMLHttpRequest();
                req.open("POST", uri, true);
                req.setRequestHeader("Accept", "application/json");
                req.setRequestHeader("Content-Type", "application/json; charset=utf-8");
                req.setRequestHeader("OData-MaxVersion", "4.0");
                req.setRequestHeader("OData-Version", "4.0");

                req.onload = () => {
                    if (req.status >= 200 && req.status <= 400) {
                        const data = JSON.parse(req.response);
                        resolve(data);
                    }
                    else {
                        debugger;
                        reject(this.errorHandler(req));
                    }
                };

                req.onerror = (err) => {
                    debugger;
                    reject(new Error("onerror"));
                };

                if (params == null) {
                    req.send(null);
                }
                else {
                    req.send(JSON.stringify(params));
                }
            });

        }

        static executeActionAsync(recordType: string, recordId: string, actionName: string, params: object): Promise<object> {

            return new Promise<object>((resolve, reject) => {

                if (recordType.slice(-1) != "s") {
                    recordType = recordType + "s";
                }
             
                if (recordId.length == 38) {
                    recordId = recordId.substring(1, 37);
                }

                var req = new XMLHttpRequest();
                var uri = encodeURI(this.getWebAPIPath() + "/" + recordType + "(" + recordId + ")/Microsoft.Dynamics.CRM." + actionName);              
                req.open("POST", uri, true);
                req.setRequestHeader("Accept", "application/json");
                req.setRequestHeader("Content-Type", "application/json; charset=utf-8");
                req.setRequestHeader("OData-MaxVersion", "4.0");
                req.setRequestHeader("OData-Version", "4.0");

                req.onload = () => {
                    if (req.status >= 200 && req.status <= 400) {
                        const data = JSON.parse(req.response);
                        resolve(data);
                    }
                    else {
                        debugger;
                        reject(this.errorHandler(req));
                    }
                };

                if (params != null) {
                    req.send(JSON.stringify(params));
                }
                else {
                    req.send(null);
                }
            });
        }

    }
   
}