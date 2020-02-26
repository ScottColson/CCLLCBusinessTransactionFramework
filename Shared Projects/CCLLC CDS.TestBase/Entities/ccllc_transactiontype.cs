namespace TestProxy
{

	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("ccllc_transactiontype")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.28")]
	public partial class ccllc_transactiontype : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public ccllc_transactiontype() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "ccllc_transactiontype";
		
		public const int EntityTypeCode = 10166;
		
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
		/// Identifies the entity type of the data record that is used to collect input data for this transaction.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_datarecordconfiguration")]
		public string ccllc_DataRecordConfiguration
		{
			get
			{
				return this.GetAttributeValue<string>("ccllc_datarecordconfiguration");
			}
			set
			{
				this.OnPropertyChanging("ccllc_DataRecordConfiguration");
				this.SetAttributeValue("ccllc_datarecordconfiguration", value);
				this.OnPropertyChanged("ccllc_DataRecordConfiguration");
			}
		}
		
		/// <summary>
		/// Sort order for displaying the Transaction Type in a list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_displayrank")]
		public System.Nullable<int> ccllc_DisplayRank
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("ccllc_displayrank");
			}
			set
			{
				this.OnPropertyChanging("ccllc_DisplayRank");
				this.SetAttributeValue("ccllc_displayrank", value);
				this.OnPropertyChanged("ccllc_DisplayRank");
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
		/// The Transaction process that is started when a new Transaction is created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_startupprocessid")]
		public Microsoft.Xrm.Sdk.EntityReference ccllc_StartupProcessId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ccllc_startupprocessid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_StartupProcessId");
				this.SetAttributeValue("ccllc_startupprocessid", value);
				this.OnPropertyChanged("ccllc_StartupProcessId");
			}
		}
		
		/// <summary>
		/// Unique identifier for Transaction Group associated with Transaction Type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_transactiongroupid")]
		public Microsoft.Xrm.Sdk.EntityReference ccllc_TransactionGroupId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ccllc_transactiongroupid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_TransactionGroupId");
				this.SetAttributeValue("ccllc_transactiongroupid", value);
				this.OnPropertyChanged("ccllc_TransactionGroupId");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_transactiontypeid")]
		public System.Nullable<System.Guid> ccllc_transactiontypeId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("ccllc_transactiontypeid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_transactiontypeId");
				this.SetAttributeValue("ccllc_transactiontypeid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ccllc_transactiontypeId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_transactiontypeid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.ccllc_transactiontypeId = value;
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
		/// Status of the Transaction Type
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<TestProxy.ccllc_transactiontypeState> statecode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((TestProxy.ccllc_transactiontypeState)(System.Enum.ToObject(typeof(TestProxy.ccllc_transactiontypeState), optionSet.Value)));
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
		/// Reason for the status of the Transaction Type
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public System.Nullable<TestProxy.ccllc_transactiontype_statuscode> statuscode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
				if ((optionSet != null))
				{
					return ((TestProxy.ccllc_transactiontype_statuscode)(System.Enum.ToObject(typeof(TestProxy.ccllc_transactiontype_statuscode), optionSet.Value)));
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
		/// 1:N ccllc_transactiontype_authorizedchannel
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transactiontype_authorizedchannel")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiontypeauthorizedchannel> ccllc_transactiontype_authorizedchannel
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiontypeauthorizedchannel>("ccllc_transactiontype_authorizedchannel", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transactiontype_authorizedchannel");
				this.SetRelatedEntities<TestProxy.ccllc_transactiontypeauthorizedchannel>("ccllc_transactiontype_authorizedchannel", null, value);
				this.OnPropertyChanged("ccllc_transactiontype_authorizedchannel");
			}
		}
		
		/// <summary>
		/// 1:N ccllc_transactiontype_authorizedroles
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transactiontype_authorizedroles")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiontypeauthorizedrole> ccllc_transactiontype_authorizedroles
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiontypeauthorizedrole>("ccllc_transactiontype_authorizedroles", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transactiontype_authorizedroles");
				this.SetRelatedEntities<TestProxy.ccllc_transactiontypeauthorizedrole>("ccllc_transactiontype_authorizedroles", null, value);
				this.OnPropertyChanged("ccllc_transactiontype_authorizedroles");
			}
		}
		
		/// <summary>
		/// 1:N ccllc_transactiontype_availableprocesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transactiontype_availableprocesses")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactionprocess> ccllc_transactiontype_availableprocesses
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactionprocess>("ccllc_transactiontype_availableprocesses", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transactiontype_availableprocesses");
				this.SetRelatedEntities<TestProxy.ccllc_transactionprocess>("ccllc_transactiontype_availableprocesses", null, value);
				this.OnPropertyChanged("ccllc_transactiontype_availableprocesses");
			}
		}
		
		/// <summary>
		/// 1:N ccllc_transactiontype_context
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transactiontype_context")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiontypecontext> ccllc_transactiontype_context
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiontypecontext>("ccllc_transactiontype_context", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transactiontype_context");
				this.SetRelatedEntities<TestProxy.ccllc_transactiontypecontext>("ccllc_transactiontype_context", null, value);
				this.OnPropertyChanged("ccllc_transactiontype_context");
			}
		}
		
		/// <summary>
		/// 1:N ccllc_transactiontype_initialfee
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transactiontype_initialfee")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactioninitialfee> ccllc_transactiontype_initialfee
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactioninitialfee>("ccllc_transactiontype_initialfee", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transactiontype_initialfee");
				this.SetRelatedEntities<TestProxy.ccllc_transactioninitialfee>("ccllc_transactiontype_initialfee", null, value);
				this.OnPropertyChanged("ccllc_transactiontype_initialfee");
			}
		}
		
		/// <summary>
		/// 1:N ccllc_transactiontype_relatedtransaction
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transactiontype_relatedtransaction")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transaction> ccllc_transactiontype_relatedtransaction
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transaction>("ccllc_transactiontype_relatedtransaction", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transactiontype_relatedtransaction");
				this.SetRelatedEntities<TestProxy.ccllc_transaction>("ccllc_transactiontype_relatedtransaction", null, value);
				this.OnPropertyChanged("ccllc_transactiontype_relatedtransaction");
			}
		}
		
		/// <summary>
		/// 1:N ccllc_transactiontype_requirements
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transactiontype_requirements")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactionrequirement> ccllc_transactiontype_requirements
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactionrequirement>("ccllc_transactiontype_requirements", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transactiontype_requirements");
				this.SetRelatedEntities<TestProxy.ccllc_transactionrequirement>("ccllc_transactiontype_requirements", null, value);
				this.OnPropertyChanged("ccllc_transactiontype_requirements");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_ccllc_transactiontype
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_transactiontype")]
		public TestProxy.BusinessUnit business_unit_ccllc_transactiontype
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.BusinessUnit>("business_unit_ccllc_transactiontype", null);
			}
		}
		
		/// <summary>
		/// N:1 ccllc_transactiontype_parentgroup
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_transactiongroupid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transactiontype_parentgroup")]
		public TestProxy.ccllc_transactiongroup ccllc_transactiontype_parentgroup
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.ccllc_transactiongroup>("ccllc_transactiontype_parentgroup", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transactiontype_parentgroup");
				this.SetRelatedEntity<TestProxy.ccllc_transactiongroup>("ccllc_transactiontype_parentgroup", null, value);
				this.OnPropertyChanged("ccllc_transactiontype_parentgroup");
			}
		}
		
		/// <summary>
		/// N:1 ccllc_transactiontype_startupprocess
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_startupprocessid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transactiontype_startupprocess")]
		public TestProxy.ccllc_transactionprocess ccllc_transactiontype_startupprocess
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.ccllc_transactionprocess>("ccllc_transactiontype_startupprocess", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transactiontype_startupprocess");
				this.SetRelatedEntity<TestProxy.ccllc_transactionprocess>("ccllc_transactiontype_startupprocess", null, value);
				this.OnPropertyChanged("ccllc_transactiontype_startupprocess");
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_transactiontype_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactiontype_createdby")]
		public TestProxy.SystemUser lk_ccllc_transactiontype_createdby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_transactiontype_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_transactiontype_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactiontype_createdonbehalfby")]
		public TestProxy.SystemUser lk_ccllc_transactiontype_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_transactiontype_createdonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_transactiontype_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactiontype_modifiedby")]
		public TestProxy.SystemUser lk_ccllc_transactiontype_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_transactiontype_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_transactiontype_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactiontype_modifiedonbehalfby")]
		public TestProxy.SystemUser lk_ccllc_transactiontype_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_transactiontype_modifiedonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 user_ccllc_transactiontype
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_transactiontype")]
		public TestProxy.SystemUser user_ccllc_transactiontype
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("user_ccllc_transactiontype", null);
			}
		}
	}
}
