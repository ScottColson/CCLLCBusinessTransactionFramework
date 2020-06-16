var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    }
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : new P(function (resolve) { resolve(result.value); }).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
var __generator = (this && this.__generator) || function (thisArg, body) {
    var _ = { label: 0, sent: function() { if (t[0] & 1) throw t[1]; return t[1]; }, trys: [], ops: [] }, f, y, t, g;
    return g = { next: verb(0), "throw": verb(1), "return": verb(2) }, typeof Symbol === "function" && (g[Symbol.iterator] = function() { return this; }), g;
    function verb(n) { return function (v) { return step([n, v]); }; }
    function step(op) {
        if (f) throw new TypeError("Generator is already executing.");
        while (_) try {
            if (f = 1, y && (t = op[0] & 2 ? y["return"] : op[0] ? y["throw"] || ((t = y["return"]) && t.call(y), 0) : y.next) && !(t = t.call(y, op[1])).done) return t;
            if (y = 0, t) op = [op[0] & 2, t.value];
            switch (op[0]) {
                case 0: case 1: t = op; break;
                case 4: _.label++; return { value: op[1], done: false };
                case 5: _.label++; y = op[1]; op = [0]; continue;
                case 7: op = _.ops.pop(); _.trys.pop(); continue;
                default:
                    if (!(t = _.trys, t = t.length > 0 && t[t.length - 1]) && (op[0] === 6 || op[0] === 2)) { _ = 0; continue; }
                    if (op[0] === 3 && (!t || (op[1] > t[0] && op[1] < t[3]))) { _.label = op[1]; break; }
                    if (op[0] === 6 && _.label < t[1]) { _.label = t[1]; t = op; break; }
                    if (t && _.label < t[2]) { _.label = t[2]; _.ops.push(op); break; }
                    if (t[2]) _.ops.pop();
                    _.trys.pop(); continue;
            }
            op = body.call(thisArg, _);
        } catch (e) { op = [6, e]; y = 0; } finally { f = t = 0; }
        if (op[0] & 5) throw op[1]; return { value: op[0] ? op[1] : void 0, done: true };
    }
};
/// <reference path="../../node_modules/@types/xrm/index.d.ts" />
var CCLLC;
(function (CCLLC) {
    var Common;
    (function (Common) {
        /* LegacyWebApi
         *
         * Implements executeAction and executeGlobal action using the direct XMLHttpRequests. This
         * class is required because the Xrm.WebApi.online.execute method current does not work with
         * the Unified Client interface when working with actions that return output parameters.
         */
        var LegacyWebApi = /** @class */ (function () {
            function LegacyWebApi() {
            }
            LegacyWebApi.getClientUrl = function () {
                var context = Xrm.Utility.getGlobalContext();
                return context.getClientUrl();
            };
            LegacyWebApi.getWebAPIPath = function () {
                return this.getClientUrl() + "/api/data/v9.0";
            };
            LegacyWebApi.errorHandler = function (req) {
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
                    errorText = req.responseText;
                }
                return new Error("Error : " + req.status + ": " + req.statusText + ": " + errorText);
            };
            LegacyWebApi.dateReviver = function (key, value) {
                var a;
                if (typeof value === 'string') {
                    a = /^(\d{4})-(\d{2})-(\d{2})T(\d{2}):(\d{2}):(\d{2}(?:\.\d*)?)Z$/.exec(value);
                    if (a) {
                        return new Date(Date.UTC(+a[1], +a[2] - 1, +a[3], +a[4], +a[5], +a[6]));
                    }
                }
                return value;
            };
            /*
             * Execute an unbound action asynchronously.
             */
            LegacyWebApi.executeGlobalActionAsync = function (actionName, params) {
                var _this = this;
                return new Promise(function (resolve, reject) {
                    var uri = encodeURI(_this.getWebAPIPath()) + "/" + actionName;
                    var req = new XMLHttpRequest();
                    req.open("POST", uri, true);
                    req.setRequestHeader("Accept", "application/json");
                    req.setRequestHeader("Content-Type", "application/json; charset=utf-8");
                    req.setRequestHeader("OData-MaxVersion", "4.0");
                    req.setRequestHeader("OData-Version", "4.0");
                    req.onload = function () {
                        if (req.status >= 200 && req.status <= 400) {
                            var data = JSON.parse(req.response);
                            resolve(data);
                        }
                        else {
                            debugger;
                            reject(_this.errorHandler(req));
                        }
                    };
                    req.onerror = function (err) {
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
            };
            LegacyWebApi.executeActionAsync = function (recordType, recordId, actionName, params) {
                var _this = this;
                return new Promise(function (resolve, reject) {
                    if (recordType.slice(-1) != "s") {
                        recordType = recordType + "s";
                    }
                    if (recordId.length == 38) {
                        recordId = recordId.substring(1, 37);
                    }
                    var req = new XMLHttpRequest();
                    var uri = encodeURI(_this.getWebAPIPath() + "/" + recordType + "(" + recordId + ")/Microsoft.Dynamics.CRM." + actionName);
                    req.open("POST", uri, true);
                    req.setRequestHeader("Accept", "application/json");
                    req.setRequestHeader("Content-Type", "application/json; charset=utf-8");
                    req.setRequestHeader("OData-MaxVersion", "4.0");
                    req.setRequestHeader("OData-Version", "4.0");
                    req.onload = function () {
                        if (req.status >= 200 && req.status <= 400) {
                            var data = JSON.parse(req.response);
                            resolve(data);
                        }
                        else {
                            debugger;
                            reject(_this.errorHandler(req));
                        }
                    };
                    if (params != null) {
                        req.send(JSON.stringify(params));
                    }
                    else {
                        req.send(null);
                    }
                });
            };
            return LegacyWebApi;
        }());
        Common.LegacyWebApi = LegacyWebApi;
    })(Common = CCLLC.Common || (CCLLC.Common = {}));
})(CCLLC || (CCLLC = {}));
var CCLLC;
(function (CCLLC) {
    var Transactions;
    (function (Transactions) {
        var CommandBar;
        (function (CommandBar) {
            var Encoding = /** @class */ (function () {
                function Encoding() {
                }
                Encoding.xmlEncode = function (text) {
                    if (text == null || text === "") {
                        return text;
                    }
                    return Xrm.Encoding.xmlEncode(text);
                };
                return Encoding;
            }());
            CommandBar.Encoding = Encoding;
            var RibbonControl = /** @class */ (function () {
                function RibbonControl(id, sequence, labelText, command, image16, image32) {
                    this.id = id;
                    this.sequence = sequence;
                    this.labelText = labelText;
                    this.command = command;
                    this.image16By16 = image16;
                    this.image32By32 = image32;
                }
                RibbonControl.prototype.serialiseToRibbonXml = function (sb) {
                };
                return RibbonControl;
            }());
            CommandBar.RibbonControl = RibbonControl;
            var RibbonFlyoutAnchor = /** @class */ (function (_super) {
                __extends(RibbonFlyoutAnchor, _super);
                function RibbonFlyoutAnchor() {
                    return _super !== null && _super.apply(this, arguments) || this;
                }
                RibbonFlyoutAnchor.prototype.serialiseToRibbonXml = function (sb) {
                    sb.push("<FlyoutAnchor Id=\"" + Encoding.xmlEncode(this.id) + "\" LabelText=\"" + Encoding.xmlEncode(this.labelText) + "\" Sequence=\"" + this.sequence.toString() + "\" Command=\"" + Encoding.xmlEncode(this.command) + "\"" + ((this.image32By32 != null) ? (" Image32by32=\"" + Encoding.xmlEncode(this.image32By32) + "\"") : "") + ((this.image16By16 != null) ? (" Image16by16=\"" + Encoding.xmlEncode(this.image16By16) + "\"") : "") + " PopulateDynamically=\"false\">");
                    sb.push(this.menu.serialiseToRibbonXml());
                    sb.push("</FlyoutAnchor>");
                };
                return RibbonFlyoutAnchor;
            }(RibbonControl));
            CommandBar.RibbonFlyoutAnchor = RibbonFlyoutAnchor;
            var RibbonButton = /** @class */ (function (_super) {
                __extends(RibbonButton, _super);
                function RibbonButton() {
                    return _super !== null && _super.apply(this, arguments) || this;
                }
                RibbonButton.prototype.serialiseToRibbonXml = function (sb) {
                    sb.push("<Button Id=\"" + Encoding.xmlEncode(this.id) + "\" LabelText=\"" + Encoding.xmlEncode(this.labelText) + "\" Sequence=\"" + this.sequence.toString() + "\" Command=\"" + Encoding.xmlEncode(this.command) + "\"" + ((this.image32By32 != null) ? (" Image32by32=\"" + Encoding.xmlEncode(this.image32By32) + "\"") : "") + ((this.image16By16 != null) ? (" Image16by16 =\"" + Encoding.xmlEncode(this.image16By16) + "\"") : "") + " />");
                };
                return RibbonButton;
            }(RibbonControl));
            CommandBar.RibbonButton = RibbonButton;
            var RibbonMenu = /** @class */ (function () {
                function RibbonMenu(id) {
                    this.sections = new Array();
                    this.id = id;
                }
                RibbonMenu.prototype.serialiseToRibbonXml = function () {
                    var sb = new Array();
                    sb.push("<Menu Id=\"" + this.id + "\">");
                    this.sections.forEach(function (section) {
                        section.serialiseToRibbonXml(sb);
                    });
                    sb.push("</Menu>");
                    return sb.join("");
                };
                RibbonMenu.prototype.addSection = function (section) {
                    this.sections.push(section);
                    return this;
                };
                return RibbonMenu;
            }());
            CommandBar.RibbonMenu = RibbonMenu;
            var RibbonMenuSection = /** @class */ (function () {
                function RibbonMenuSection(id, labelText, sequence, displayMode) {
                    this.buttons = new Array();
                    this.id = id;
                    this.title = labelText;
                    this.sequence = sequence;
                    this.displayMode = displayMode;
                }
                RibbonMenuSection.prototype.serialiseToRibbonXml = function (sb) {
                    sb.push("<MenuSection Id=\"" + Encoding.xmlEncode(this.id) + (this.title != null ? "\" Title=\"" + Encoding.xmlEncode(this.title) : "") + "\" Sequence=\"" + this.sequence.toString() + "\" DisplayMode=\"" + this.displayMode + "\">");
                    sb.push("<Controls Id=\"" + Encoding.xmlEncode(this.id + ".Controls") + "\">");
                    this.buttons.forEach(function (button) {
                        button.serialiseToRibbonXml(sb);
                    });
                    sb.push("</Controls>");
                    sb.push("</MenuSection>");
                };
                RibbonMenuSection.prototype.addButton = function (button) {
                    this.buttons.push(button);
                    return this;
                };
                return RibbonMenuSection;
            }());
            CommandBar.RibbonMenuSection = RibbonMenuSection;
            var CommandProperties = /** @class */ (function () {
                function CommandProperties() {
                }
                return CommandProperties;
            }());
            CommandBar.CommandProperties = CommandProperties;
        })(CommandBar = Transactions.CommandBar || (Transactions.CommandBar = {}));
    })(Transactions = CCLLC.Transactions || (CCLLC.Transactions = {}));
})(CCLLC || (CCLLC = {}));
/// <reference path="ribbon-lib.ts" />
/// <reference path="../legacywebapi.ts" />
/// <reference path="../../../node_modules/@types/xrm/index.d.ts" />
var CCLLC;
(function (CCLLC) {
    var Transactions;
    (function (Transactions) {
        var CommandBar;
        (function (CommandBar) {
            var BTF_GetAvailableTransactionTypesRequest = /** @class */ (function () {
                function BTF_GetAvailableTransactionTypesRequest(ContextRecordType, ContextRecordId) {
                    this.ContextRecordType = ContextRecordType;
                    this.ContextRecordId = ContextRecordId;
                    this.getMetadata = function () {
                        var metadata = {
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
                        };
                        return metadata;
                    };
                }
                return BTF_GetAvailableTransactionTypesRequest;
            }());
            var TMF_InitiateTransactionRequest = /** @class */ (function () {
                function TMF_InitiateTransactionRequest(contextRecordType, contextRecordId, transactionTypeId, string, userId) {
                    this.contextRecordType = contextRecordType;
                    this.contextRecordId = contextRecordId;
                    this.transactionTypeId = transactionTypeId;
                    this.userId = userId;
                    this.getMetadata = function () {
                        var metadata = {
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
                        };
                        return metadata;
                    };
                    this.ContextRecordType = contextRecordType;
                    this.ContextRecordId = contextRecordId;
                    this.transactionTypeId = transactionTypeId;
                    this.UserId = userId;
                }
                return TMF_InitiateTransactionRequest;
            }());
            var Actions = /** @class */ (function () {
                function Actions() {
                }
                /*
                 * Call the unbound ccllc_BTF_GetAvailableTransactionTypes action to get a list of registered transaction types that
                 * are authorized for the current Agent (user) and the current record.
                */
                Actions.GetTransactionTypesAsync = function (contextRecordType, contextRecordId) {
                    return __awaiter(this, void 0, void 0, function () {
                        var params, result;
                        return __generator(this, function (_a) {
                            switch (_a.label) {
                                case 0:
                                    params = {
                                        "ContextRecordType": contextRecordType,
                                        "ContextRecordId": contextRecordId
                                    };
                                    return [4 /*yield*/, CCLLC.Common.LegacyWebApi.executeGlobalActionAsync("ccllc_BTF_GetAvailableTransactionTypes", params)];
                                case 1:
                                    result = _a.sent();
                                    return [2 /*return*/, result];
                            }
                        });
                    });
                };
                /*
                 * Call the unbound ccllc_BTF_InitiateTransactionAction to create a new Transaction and initiate the transaction process
                 * for that Transaction. Return the UI Pointer required to update the user screens.
                 */
                Actions.InitiateTransactionAsync = function (contextRecordType, contextRecordId, transactionTypeId) {
                    return __awaiter(this, void 0, void 0, function () {
                        var transactionType, params, result;
                        return __generator(this, function (_a) {
                            switch (_a.label) {
                                case 0:
                                    transactionType = {
                                        "ccllc_transactiontypeid": transactionTypeId
                                    };
                                    transactionType["@odata.type"] = "Microsoft.Dynamics.CRM.ccllc_transactiontype";
                                    params = {
                                        "ContextRecordType": contextRecordType,
                                        "ContextRecordId": contextRecordId,
                                        "TransactionTypeId": transactionType
                                    };
                                    return [4 /*yield*/, CCLLC.Common.LegacyWebApi.executeGlobalActionAsync("ccllc_BTF_InitiateTransaction", params)];
                                case 1:
                                    result = _a.sent();
                                    return [2 /*return*/, result];
                            }
                        });
                    });
                };
                Actions.CanNavigateForwardAsync = function (transactionId) {
                    return __awaiter(this, void 0, void 0, function () {
                        var params, result;
                        return __generator(this, function (_a) {
                            switch (_a.label) {
                                case 0:
                                    params = {};
                                    return [4 /*yield*/, CCLLC.Common.LegacyWebApi.executeActionAsync("ccllc_transactions", transactionId, "ccllc_BTF_CanNavigateForward", params)];
                                case 1:
                                    result = _a.sent();
                                    return [2 /*return*/, result];
                            }
                        });
                    });
                };
                Actions.CanNavigateBackwardAsync = function (transactionId) {
                    return __awaiter(this, void 0, void 0, function () {
                        var params, result;
                        return __generator(this, function (_a) {
                            switch (_a.label) {
                                case 0:
                                    params = {};
                                    return [4 /*yield*/, CCLLC.Common.LegacyWebApi.executeActionAsync("ccllc_transactions", transactionId, "ccllc_BTF_CanNavigateBackward", params)];
                                case 1:
                                    result = _a.sent();
                                    return [2 /*return*/, result];
                            }
                        });
                    });
                };
                Actions.NavigateForwardAsync = function (transactionId) {
                    return __awaiter(this, void 0, void 0, function () {
                        var params, result;
                        return __generator(this, function (_a) {
                            switch (_a.label) {
                                case 0:
                                    params = {};
                                    return [4 /*yield*/, CCLLC.Common.LegacyWebApi.executeActionAsync("ccllc_transactions", transactionId, "ccllc_BTF_NavigateForward", params)];
                                case 1:
                                    result = _a.sent();
                                    return [2 /*return*/, result];
                            }
                        });
                    });
                };
                Actions.NavigateBackwardAsync = function (transactionId) {
                    return __awaiter(this, void 0, void 0, function () {
                        var params, result;
                        return __generator(this, function (_a) {
                            switch (_a.label) {
                                case 0:
                                    params = {};
                                    return [4 /*yield*/, CCLLC.Common.LegacyWebApi.executeActionAsync("ccllc_transactions", transactionId, "ccllc_BTF_NavigateBackward", params)];
                                case 1:
                                    result = _a.sent();
                                    return [2 /*return*/, result];
                            }
                        });
                    });
                };
                return Actions;
            }());
            CommandBar.Actions = Actions;
        })(CommandBar = Transactions.CommandBar || (Transactions.CommandBar = {}));
    })(Transactions = CCLLC.Transactions || (CCLLC.Transactions = {}));
})(CCLLC || (CCLLC = {}));
/// <reference path="../../../node_modules/@types/xrm/index.d.ts" />
/// <reference path="transaction-actions.ts" />
var CCLLC;
(function (CCLLC) {
    var Transactions;
    (function (Transactions) {
        var CommandBar;
        (function (CommandBar) {
            ;
            var Commands = /** @class */ (function () {
                function Commands() {
                }
                Commands.populateTransactionFlyout = function (commandProperties, formContext, ribbonCommand) {
                    var recordType = formContext.data.entity.getEntityName();
                    var recordId = formContext.data.entity.getId();
                    commandProperties.PopulationXML = Commands.getTransactionOptionsXml(recordType, recordId, ribbonCommand);
                };
                Commands.initiateTransaction = function (commandProperties, formContext) {
                    var _this = this;
                    var recordType = formContext.data.entity.getEntityName();
                    var recordId = formContext.data.entity.getId();
                    var transactionTypeId = commandProperties.SourceControlId;
                    Xrm.Page.data.refresh(true)
                        .then(function () {
                        CCLLC.Transactions.CommandBar.Actions.InitiateTransactionAsync(recordType, recordId, transactionTypeId)
                            .then(function (result) {
                            var uiPointer = JSON.parse(result.UIPointer);
                            _this.processUIPointer(uiPointer)
                                .catch(function (error) {
                                _this.errorHandler(error);
                            });
                        })
                            .catch(function (error) {
                            _this.errorHandler(error);
                        });
                    })
                        .catch(function (reason) {
                        _this.errorHandler(new Error(reason.message));
                    });
                };
                Commands.canNavigateForward = function (commandProperties, formContext, transactionFieldName) {
                    return __awaiter(this, void 0, void 0, function () {
                        var transactionId, result, error_1;
                        return __generator(this, function (_a) {
                            switch (_a.label) {
                                case 0:
                                    _a.trys.push([0, 2, , 3]);
                                    transactionId = formContext.data.entity.attributes
                                        .get(transactionFieldName)
                                        .getValue()[0].id;
                                    return [4 /*yield*/, CCLLC.Transactions.CommandBar.Actions.CanNavigateForwardAsync(transactionId)];
                                case 1:
                                    result = _a.sent();
                                    return [2 /*return*/, result.IsAllowed];
                                case 2:
                                    error_1 = _a.sent();
                                    this.errorHandler(error_1);
                                    return [3 /*break*/, 3];
                                case 3: return [2 /*return*/];
                            }
                        });
                    });
                };
                Commands.canNavigateBackward = function (commandProperties, formContext, transactionFieldName) {
                    return __awaiter(this, void 0, void 0, function () {
                        var transactionId, result, error_2;
                        return __generator(this, function (_a) {
                            switch (_a.label) {
                                case 0:
                                    _a.trys.push([0, 2, , 3]);
                                    transactionId = formContext.data.entity.attributes
                                        .get(transactionFieldName)
                                        .getValue()[0].id;
                                    return [4 /*yield*/, CCLLC.Transactions.CommandBar.Actions.CanNavigateBackwardAsync(transactionId)];
                                case 1:
                                    result = _a.sent();
                                    return [2 /*return*/, result.IsAllowed];
                                case 2:
                                    error_2 = _a.sent();
                                    this.errorHandler(error_2);
                                    return [3 /*break*/, 3];
                                case 3: return [2 /*return*/];
                            }
                        });
                    });
                };
                Commands.navigateForward = function (commandProperties, formContext, transactionFieldName) {
                    var _this = this;
                    var transactionId = formContext.data.entity.attributes
                        .get(transactionFieldName)
                        .getValue()[0].id;
                    Xrm.Page.data.refresh(true)
                        .then(function () {
                        CCLLC.Transactions.CommandBar.Actions.NavigateForwardAsync(transactionId)
                            .then(function (result) {
                            var uiPointer = JSON.parse(result.UIPointer);
                            _this.processUIPointer(uiPointer)
                                .catch(function (error) {
                                _this.errorHandler(error);
                            });
                        })
                            .catch(function (error) {
                            _this.errorHandler(error);
                        });
                    })
                        .catch(function (reason) {
                        _this.errorHandler(new Error(reason.message));
                    });
                };
                Commands.navigateBackward = function (commandProperties, formContext, transactionFieldName) {
                    var _this = this;
                    var transactionId = formContext.data.entity.attributes
                        .get(transactionFieldName)
                        .getValue()[0].id;
                    Xrm.Page.data.refresh(true)
                        .then(function () {
                        CCLLC.Transactions.CommandBar.Actions.NavigateBackwardAsync(transactionId)
                            .then(function (result) {
                            var uiPointer = JSON.parse(result.UIPointer);
                            _this.processUIPointer(uiPointer)
                                .catch(function (error) {
                                _this.errorHandler(error);
                            });
                        })
                            .catch(function (error) {
                            _this.errorHandler(error);
                        });
                    })
                        .catch(function (reason) {
                        _this.errorHandler(new Error(reason.message));
                    });
                };
                /*
                 * Builds the required XML for the dynamically generated command bar buttons for transactions.
                 *   recordType: The entity logical name of the record where the button menu is being populated.
                 *   recordId: The id of the record where the menu is being populated
                 *   ribbonCommand: The ribbon command that will be attached to each dynamically created button.
                 */
                Commands.getTransactionOptionsXml = function (recordType, recordId, ribbonCommand) {
                    return __awaiter(this, void 0, void 0, function () {
                        var result, items, ribbonMenuSection, actionSection, sectionName, sectionCount, buttonCount, xml;
                        return __generator(this, function (_a) {
                            switch (_a.label) {
                                case 0: return [4 /*yield*/, CCLLC.Transactions.CommandBar.Actions.GetTransactionTypesAsync(recordType, recordId)];
                                case 1:
                                    result = _a.sent();
                                    items = JSON.parse(result.TransactionTypes);
                                    ribbonMenuSection = new CommandBar.RibbonMenu("ccllc.common.TransactionTypes.Button.Menu");
                                    actionSection = null;
                                    sectionName = null;
                                    sectionCount = 0;
                                    buttonCount = 0;
                                    items.forEach(function (item) {
                                        if (sectionName == null || sectionName != item.GroupName) {
                                            if (actionSection != null) {
                                                ribbonMenuSection.addSection(actionSection);
                                            }
                                            sectionName = item.GroupName;
                                            sectionCount++;
                                            actionSection = new CommandBar.RibbonMenuSection("Section" + sectionCount, sectionName, sectionCount, "Menu16");
                                        }
                                        buttonCount++;
                                        // add button setting the id of the button to the GUID of the 
                                        // corresponding Transaction Type. This GUID will get passed in 
                                        // when the button is clicked.
                                        actionSection.addButton(new CommandBar.RibbonButton(item.TypeId, buttonCount, item.TypeName, ribbonCommand, null, null));
                                    });
                                    if (actionSection != null) {
                                        ribbonMenuSection.addSection(actionSection);
                                    }
                                    xml = ribbonMenuSection.serialiseToRibbonXml();
                                    return [2 /*return*/, xml];
                            }
                        });
                    });
                };
                /*
                 * Process navigation or display instructions encoded in a UI pointer object.
                 */
                Commands.processUIPointer = function (uiPointer) {
                    return __awaiter(this, void 0, void 0, function () {
                        var formOptions, formOptions, error_3;
                        return __generator(this, function (_a) {
                            switch (_a.label) {
                                case 0:
                                    _a.trys.push([0, 7, , 8]);
                                    if (!(uiPointer.UIType == "DataForm")) return [3 /*break*/, 5];
                                    if (!(uiPointer.Definition.toLowerCase() == "default")) return [3 /*break*/, 2];
                                    formOptions = {
                                        entityName: uiPointer.RecordType,
                                        entityId: uiPointer.RecordId
                                    };
                                    return [4 /*yield*/, Xrm.Navigation.openForm(formOptions).catch(function (error) { throw error; })];
                                case 1:
                                    _a.sent();
                                    return [3 /*break*/, 4];
                                case 2:
                                    formOptions = {
                                        entityName: uiPointer.RecordType,
                                        entityId: uiPointer.RecordId,
                                        formId: uiPointer.Definition
                                    };
                                    return [4 /*yield*/, Xrm.Navigation.openForm(formOptions).catch(function (error) { throw error; })];
                                case 3:
                                    _a.sent();
                                    _a.label = 4;
                                case 4: return [3 /*break*/, 6];
                                case 5: throw new Error(uiPointer.UIType + " is not a supported UI type.");
                                case 6: return [3 /*break*/, 8];
                                case 7:
                                    error_3 = _a.sent();
                                    throw error_3;
                                case 8: return [2 /*return*/];
                            }
                        });
                    });
                };
                /*
                 * Standard error handler for script related errors.
                 */
                Commands.errorHandler = function (error) {
                    Xrm.Utility.alertDialog(error.message, function () { });
                };
                return Commands;
            }());
            CommandBar.Commands = Commands;
        })(CommandBar = Transactions.CommandBar || (Transactions.CommandBar = {}));
    })(Transactions = CCLLC.Transactions || (CCLLC.Transactions = {}));
})(CCLLC || (CCLLC = {}));
//# sourceMappingURL=common.js.map
