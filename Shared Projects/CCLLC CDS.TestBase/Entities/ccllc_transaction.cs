namespace TestProxy
{

	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("ccllc_transaction")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.28")]
	public partial class ccllc_transaction : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public ccllc_transaction() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "ccllc_transaction";
		
		public const int EntityTypeCode = 10145;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// The GUID of the context record used to initiate the transaction.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_contextrecordguid")]
		public string ccllc_ContextRecordGUID
		{
			get
			{
				return this.GetAttributeValue<string>("ccllc_contextrecordguid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_ContextRecordGUID");
				this.SetAttributeValue("ccllc_contextrecordguid", value);
				this.OnPropertyChanged("ccllc_ContextRecordGUID");
			}
		}
		
		/// <summary>
		/// The logical name of the context record used to initiate the transaction.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_contextrecordtype")]
		public string ccllc_ContextRecordType
		{
			get
			{
				return this.GetAttributeValue<string>("ccllc_contextrecordtype");
			}
			set
			{
				this.OnPropertyChanging("ccllc_ContextRecordType");
				this.SetAttributeValue("ccllc_contextrecordtype", value);
				this.OnPropertyChanged("ccllc_ContextRecordType");
			}
		}
		
		/// <summary>
		/// The current process being used to complete the transaction.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_currentprocessid")]
		public Microsoft.Xrm.Sdk.EntityReference ccllc_CurrentProcessId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ccllc_currentprocessid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_CurrentProcessId");
				this.SetAttributeValue("ccllc_currentprocessid", value);
				this.OnPropertyChanged("ccllc_CurrentProcessId");
			}
		}
		
		/// <summary>
		/// The current process step for the transaction
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_currentstepid")]
		public Microsoft.Xrm.Sdk.EntityReference ccllc_CurrentStepId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ccllc_currentstepid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_CurrentStepId");
				this.SetAttributeValue("ccllc_currentstepid", value);
				this.OnPropertyChanged("ccllc_CurrentStepId");
			}
		}
		
		/// <summary>
		/// The customer associated with the transaction.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_customerid")]
		public Microsoft.Xrm.Sdk.EntityReference ccllc_CustomerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ccllc_customerid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_CustomerId");
				this.SetAttributeValue("ccllc_customerid", value);
				this.OnPropertyChanged("ccllc_CustomerId");
			}
		}
		
		/// <summary>
		/// The agent that initiated the transaction.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_initiatingagentdd")]
		public Microsoft.Xrm.Sdk.EntityReference ccllc_initiatingagentdd
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ccllc_initiatingagentdd");
			}
			set
			{
				this.OnPropertyChanging("ccllc_initiatingagentdd");
				this.SetAttributeValue("ccllc_initiatingagentdd", value);
				this.OnPropertyChanged("ccllc_initiatingagentdd");
			}
		}
		
		/// <summary>
		/// Unique identifier for Location associated with Transaction.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_initiatinglocationd")]
		public Microsoft.Xrm.Sdk.EntityReference ccllc_initiatinglocationd
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ccllc_initiatinglocationd");
			}
			set
			{
				this.OnPropertyChanging("ccllc_initiatinglocationd");
				this.SetAttributeValue("ccllc_initiatinglocationd", value);
				this.OnPropertyChanged("ccllc_initiatinglocationd");
			}
		}
		
		/// <summary>
		/// The transaction process that started the transaction.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_initiatingprocessid")]
		public Microsoft.Xrm.Sdk.EntityReference ccllc_InitiatingProcessId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ccllc_initiatingprocessid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_InitiatingProcessId");
				this.SetAttributeValue("ccllc_initiatingprocessid", value);
				this.OnPropertyChanged("ccllc_InitiatingProcessId");
			}
		}
		
		/// <summary>
		/// The name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_name")]
		public string ccllc_name
		{
			get
			{
				return this.GetAttributeValue<string>("ccllc_name");
			}
			set
			{
				this.OnPropertyChanging("ccllc_name");
				this.SetAttributeValue("ccllc_name", value);
				this.OnPropertyChanged("ccllc_name");
			}
		}
		
		/// <summary>
		/// A unique reference number assigned to the transaction.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_referencenumber")]
		public string ccllc_ReferenceNumber
		{
			get
			{
				return this.GetAttributeValue<string>("ccllc_referencenumber");
			}
			set
			{
				this.OnPropertyChanging("ccllc_ReferenceNumber");
				this.SetAttributeValue("ccllc_referencenumber", value);
				this.OnPropertyChanged("ccllc_ReferenceNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_transactionid")]
		public System.Nullable<System.Guid> ccllc_transactionId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("ccllc_transactionid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_transactionId");
				this.SetAttributeValue("ccllc_transactionid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ccllc_transactionId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_transactionid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.ccllc_transactionId = value;
			}
		}
		
		/// <summary>
		/// The type of the Transaction.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_transactiontypeid")]
		public Microsoft.Xrm.Sdk.EntityReference ccllc_TransactionTypeId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ccllc_transactiontypeid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_TransactionTypeId");
				this.SetAttributeValue("ccllc_transactiontypeid", value);
				this.OnPropertyChanged("ccllc_TransactionTypeId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Owner Id
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Unique identifier for the business unit that owns the record
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier for the team that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
		
		/// <summary>
		/// Unique identifier for the user that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Status of the Transaction
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<TestProxy.ccllc_transactionState> statecode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((TestProxy.ccllc_transactionState)(System.Enum.ToObject(typeof(TestProxy.ccllc_transactionState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("statecode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("statecode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the Transaction
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public System.Nullable<TestProxy.ccllc_transaction_statuscode> statuscode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
				if ((optionSet != null))
				{
					return ((TestProxy.ccllc_transaction_statuscode)(System.Enum.ToObject(typeof(TestProxy.ccllc_transaction_statuscode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("statuscode");
				if ((value == null))
				{
					this.SetAttributeValue("statuscode", null);
				}
				else
				{
					this.SetAttributeValue("statuscode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("statuscode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Version Number
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N ccllc_transaction_stephistory
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transaction_stephistory")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_stephistory> ccllc_transaction_stephistory
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_stephistory>("ccllc_transaction_stephistory", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transaction_stephistory");
				this.SetRelatedEntities<TestProxy.ccllc_stephistory>("ccllc_transaction_stephistory", null, value);
				this.OnPropertyChanged("ccllc_transaction_stephistory");
			}
		}
		
		/// <summary>
		/// 1:N ccllc_transaction_transactionfee
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transaction_transactionfee")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactionfee> ccllc_transaction_transactionfee
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactionfee>("ccllc_transaction_transactionfee", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transaction_transactionfee");
				this.SetRelatedEntities<TestProxy.ccllc_transactionfee>("ccllc_transaction_transactionfee", null, value);
				this.OnPropertyChanged("ccllc_transaction_transactionfee");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_ccllc_transaction
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_transaction")]
		public TestProxy.BusinessUnit business_unit_ccllc_transaction
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.BusinessUnit>("business_unit_ccllc_transaction", null);
			}
		}
		
		/// <summary>
		/// N:1 ccllc_account_transaction_customer
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_customerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_account_transaction_customer")]
		public TestProxy.Account ccllc_account_transaction_customer
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.Account>("ccllc_account_transaction_customer", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_account_transaction_customer");
				this.SetRelatedEntity<TestProxy.Account>("ccllc_account_transaction_customer", null, value);
				this.OnPropertyChanged("ccllc_account_transaction_customer");
			}
		}
		
		/// <summary>
		/// N:1 ccllc_contact_transaction_customer
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_customerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_contact_transaction_customer")]
		public TestProxy.Contact ccllc_contact_transaction_customer
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.Contact>("ccllc_contact_transaction_customer", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_contact_transaction_customer");
				this.SetRelatedEntity<TestProxy.Contact>("ccllc_contact_transaction_customer", null, value);
				this.OnPropertyChanged("ccllc_contact_transaction_customer");
			}
		}
		
		/// <summary>
		/// N:1 ccllc_transaction_currentprocess
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_currentprocessid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transaction_currentprocess")]
		public TestProxy.ccllc_transactionprocess ccllc_transaction_currentprocess
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.ccllc_transactionprocess>("ccllc_transaction_currentprocess", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transaction_currentprocess");
				this.SetRelatedEntity<TestProxy.ccllc_transactionprocess>("ccllc_transaction_currentprocess", null, value);
				this.OnPropertyChanged("ccllc_transaction_currentprocess");
			}
		}
		
		/// <summary>
		/// N:1 ccllc_transaction_currentprocessstep
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_currentstepid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transaction_currentprocessstep")]
		public TestProxy.ccllc_processstep ccllc_transaction_currentprocessstep
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.ccllc_processstep>("ccllc_transaction_currentprocessstep", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transaction_currentprocessstep");
				this.SetRelatedEntity<TestProxy.ccllc_processstep>("ccllc_transaction_currentprocessstep", null, value);
				this.OnPropertyChanged("ccllc_transaction_currentprocessstep");
			}
		}
		
		/// <summary>
		/// N:1 ccllc_transaction_initiatingagent
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_initiatingagentdd")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transaction_initiatingagent")]
		public TestProxy.ccllc_agent ccllc_transaction_initiatingagent
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.ccllc_agent>("ccllc_transaction_initiatingagent", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transaction_initiatingagent");
				this.SetRelatedEntity<TestProxy.ccllc_agent>("ccllc_transaction_initiatingagent", null, value);
				this.OnPropertyChanged("ccllc_transaction_initiatingagent");
			}
		}
		
		/// <summary>
		/// N:1 ccllc_transaction_initiatinglocation
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_initiatinglocationd")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transaction_initiatinglocation")]
		public TestProxy.ccllc_location ccllc_transaction_initiatinglocation
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.ccllc_location>("ccllc_transaction_initiatinglocation", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transaction_initiatinglocation");
				this.SetRelatedEntity<TestProxy.ccllc_location>("ccllc_transaction_initiatinglocation", null, value);
				this.OnPropertyChanged("ccllc_transaction_initiatinglocation");
			}
		}
		
		/// <summary>
		/// N:1 ccllc_transaction_initiatingprocess
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_initiatingprocessid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transaction_initiatingprocess")]
		public TestProxy.ccllc_transactionprocess ccllc_transaction_initiatingprocess
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.ccllc_transactionprocess>("ccllc_transaction_initiatingprocess", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transaction_initiatingprocess");
				this.SetRelatedEntity<TestProxy.ccllc_transactionprocess>("ccllc_transaction_initiatingprocess", null, value);
				this.OnPropertyChanged("ccllc_transaction_initiatingprocess");
			}
		}
		
		/// <summary>
		/// N:1 ccllc_transactiontype_relatedtransaction
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_transactiontypeid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transactiontype_relatedtransaction")]
		public TestProxy.ccllc_transactiontype ccllc_transactiontype_relatedtransaction
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.ccllc_transactiontype>("ccllc_transactiontype_relatedtransaction", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transactiontype_relatedtransaction");
				this.SetRelatedEntity<TestProxy.ccllc_transactiontype>("ccllc_transactiontype_relatedtransaction", null, value);
				this.OnPropertyChanged("ccllc_transactiontype_relatedtransaction");
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_transaction_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transaction_createdby")]
		public TestProxy.SystemUser lk_ccllc_transaction_createdby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_transaction_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_transaction_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transaction_createdonbehalfby")]
		public TestProxy.SystemUser lk_ccllc_transaction_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_transaction_createdonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_transaction_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transaction_modifiedby")]
		public TestProxy.SystemUser lk_ccllc_transaction_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_transaction_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_transaction_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transaction_modifiedonbehalfby")]
		public TestProxy.SystemUser lk_ccllc_transaction_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_transaction_modifiedonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 user_ccllc_transaction
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_transaction")]
		public TestProxy.SystemUser user_ccllc_transaction
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("user_ccllc_transaction", null);
			}
		}
	}
}
