//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: Microsoft.Xrm.Sdk.Client.ProxyTypesAssemblyAttribute()]

namespace CCLLC.BTF.Process.CDS.Plugins
{
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/s3/")]
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("ccllc_BTF_CanNavigateForward")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class ccllc_BTF_CanNavigateForwardRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public Microsoft.Xrm.Sdk.EntityReference UserId
		{
			get
			{
				if (this.Parameters.Contains("UserId"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["UserId"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["UserId"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference Target
		{
			get
			{
				if (this.Parameters.Contains("Target"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["Target"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["Target"] = value;
			}
		}
		
		public ccllc_BTF_CanNavigateForwardRequest()
		{
			this.RequestName = "ccllc_BTF_CanNavigateForward";
			this.Target = default(Microsoft.Xrm.Sdk.EntityReference);
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/s3/")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("ccllc_BTF_CanNavigateForward")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class ccllc_BTF_CanNavigateForwardResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public ccllc_BTF_CanNavigateForwardResponse()
		{
		}
		
		public bool IsAllowed
		{
			get
			{
				if (this.Results.Contains("IsAllowed"))
				{
					return ((bool)(this.Results["IsAllowed"]));
				}
				else
				{
					return default(bool);
				}
			}
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/s3/")]
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("ccllc_BTF_NavigateForward")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class ccllc_BTF_NavigateForwardRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public Microsoft.Xrm.Sdk.EntityReference UserId
		{
			get
			{
				if (this.Parameters.Contains("UserId"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["UserId"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["UserId"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference Target
		{
			get
			{
				if (this.Parameters.Contains("Target"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["Target"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["Target"] = value;
			}
		}
		
		public ccllc_BTF_NavigateForwardRequest()
		{
			this.RequestName = "ccllc_BTF_NavigateForward";
			this.Target = default(Microsoft.Xrm.Sdk.EntityReference);
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/s3/")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("ccllc_BTF_NavigateForward")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class ccllc_BTF_NavigateForwardResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public ccllc_BTF_NavigateForwardResponse()
		{
		}
		
		public string UIPointer
		{
			get
			{
				if (this.Results.Contains("UIPointer"))
				{
					return ((string)(this.Results["UIPointer"]));
				}
				else
				{
					return default(string);
				}
			}
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/s3/")]
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("ccllc_BTF_CanNavigateBackward")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class ccllc_BTF_CanNavigateBackwardRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public Microsoft.Xrm.Sdk.EntityReference UserId
		{
			get
			{
				if (this.Parameters.Contains("UserId"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["UserId"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["UserId"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference Target
		{
			get
			{
				if (this.Parameters.Contains("Target"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["Target"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["Target"] = value;
			}
		}
		
		public ccllc_BTF_CanNavigateBackwardRequest()
		{
			this.RequestName = "ccllc_BTF_CanNavigateBackward";
			this.Target = default(Microsoft.Xrm.Sdk.EntityReference);
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/s3/")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("ccllc_BTF_CanNavigateBackward")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class ccllc_BTF_CanNavigateBackwardResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public ccllc_BTF_CanNavigateBackwardResponse()
		{
		}
		
		public bool IsAllowed
		{
			get
			{
				if (this.Results.Contains("IsAllowed"))
				{
					return ((bool)(this.Results["IsAllowed"]));
				}
				else
				{
					return default(bool);
				}
			}
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/s3/")]
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("ccllc_BTF_NavigateBackward")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class ccllc_BTF_NavigateBackwardRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public Microsoft.Xrm.Sdk.EntityReference UserId
		{
			get
			{
				if (this.Parameters.Contains("UserId"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["UserId"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["UserId"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference Target
		{
			get
			{
				if (this.Parameters.Contains("Target"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["Target"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["Target"] = value;
			}
		}
		
		public ccllc_BTF_NavigateBackwardRequest()
		{
			this.RequestName = "ccllc_BTF_NavigateBackward";
			this.Target = default(Microsoft.Xrm.Sdk.EntityReference);
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/s3/")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("ccllc_BTF_NavigateBackward")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class ccllc_BTF_NavigateBackwardResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public ccllc_BTF_NavigateBackwardResponse()
		{
		}
		
		public string UIPointer
		{
			get
			{
				if (this.Results.Contains("UIPointer"))
				{
					return ((string)(this.Results["UIPointer"]));
				}
				else
				{
					return default(string);
				}
			}
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/s3/")]
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("ccllc_BTF_InitiateTransaction")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class ccllc_BTF_InitiateTransactionRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
        public string ContextRecordType
        {
            get
            {
                if (this.Parameters.Contains("ContextRecordType"))
                {
                    return ((string)(this.Parameters["ContextRecordType"]));
                }
                else
                {
                    return default(string);
                }
            }
            set
            {
                this.Parameters["ContextRecordType"] = value;
            }
        }

        public string ContextRecordId
		{
			get
			{
				if (this.Parameters.Contains("ContextRecordId"))
				{
					return ((string)(this.Parameters["ContextRecordId"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["ContextRecordId"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference TransactionTypeId
		{
			get
			{
				if (this.Parameters.Contains("TransactionTypeId"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["TransactionTypeId"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["TransactionTypeId"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference UserId
		{
			get
			{
				if (this.Parameters.Contains("UserId"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["UserId"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["UserId"] = value;
			}
		}
		
		public ccllc_BTF_InitiateTransactionRequest()
		{
			this.RequestName = "ccllc_BTF_InitiateTransaction";
            this.ContextRecordType = default(string);
            this.ContextRecordId = default(string);
			this.TransactionTypeId = default(Microsoft.Xrm.Sdk.EntityReference);
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/s3/")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("ccllc_BTF_InitiateTransaction")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class ccllc_BTF_InitiateTransactionResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public ccllc_BTF_InitiateTransactionResponse()
		{
		}
		
		public string UIPointer
		{
			get
			{
				if (this.Results.Contains("UIPointer"))
				{
					return ((string)(this.Results["UIPointer"]));
				}
				else
				{
					return default(string);
				}
			}
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/s3/")]
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("ccllc_BTF_GetAvailableTransactionTypes")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class ccllc_BTF_GetAvailableTransactionTypesRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{

        public string ContextRecordType
        {
            get
            {
                if (this.Parameters.Contains("ContextRecordType"))
                {
                    return ((string)(this.Parameters["ContextRecordType"]));
                }
                else
                {
                    return default(string);
                }
            }
            set
            {
                this.Parameters["ContextRecordType"] = value;
            }
        }

        public string ContextRecordId
        {
            get
            {
                if (this.Parameters.Contains("ContextRecordId"))
                {
                    return ((string)(this.Parameters["ContextRecordId"]));
                }
                else
                {
                    return default(string);
                }
            }
            set
            {
                this.Parameters["ContextRecordId"] = value;
            }
        }

        public Microsoft.Xrm.Sdk.EntityReference UserId
		{
			get
			{
				if (this.Parameters.Contains("UserId"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["UserId"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["UserId"] = value;
			}
		}
		
		public ccllc_BTF_GetAvailableTransactionTypesRequest()
		{
			this.RequestName = "ccllc_BTF_GetAvailableTransactionTypes";
            this.ContextRecordType = default(string);
			this.ContextRecordId = default(string);
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/s3/")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("ccllc_BTF_GetAvailableTransactionTypes")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class ccllc_BTF_GetAvailableTransactionTypesResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public ccllc_BTF_GetAvailableTransactionTypesResponse()
		{
		}
		
		public string TransactionTypes
		{
			get
			{
				if (this.Results.Contains("TransactionTypes"))
				{
					return ((string)(this.Results["TransactionTypes"]));
				}
				else
				{
					return default(string);
				}
			}
		}
	}
}