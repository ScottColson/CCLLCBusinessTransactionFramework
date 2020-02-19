namespace TestProxy
{

	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("ccllc_transactiontypeauthorizedrole")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class ccllc_transactiontypeauthorizedrole : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public ccllc_transactiontypeauthorizedrole() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "ccllc_transactiontypeauthorizedrole";
		
		public const int EntityTypeCode = 10095;
		
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
		/// The Role assigned to the Transaction Type
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_roleid")]
		public Microsoft.Xrm.Sdk.EntityReference ccllc_RoleId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ccllc_roleid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_RoleId");
				this.SetAttributeValue("ccllc_roleid", value);
				this.OnPropertyChanged("ccllc_RoleId");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_transactiontypeauthorizedroleid")]
		public System.Nullable<System.Guid> ccllc_transactiontypeauthorizedroleId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("ccllc_transactiontypeauthorizedroleid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_transactiontypeauthorizedroleId");
				this.SetAttributeValue("ccllc_transactiontypeauthorizedroleid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ccllc_transactiontypeauthorizedroleId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_transactiontypeauthorizedroleid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.ccllc_transactiontypeauthorizedroleId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier for Transaction Type associated with Transaction Type Authorized Role.
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
		/// Status of the Transaction Type Authorized Role
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<TestProxy.ccllc_transactiontypeauthorizedroleState> statecode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((TestProxy.ccllc_transactiontypeauthorizedroleState)(System.Enum.ToObject(typeof(TestProxy.ccllc_transactiontypeauthorizedroleState), optionSet.Value)));
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
		/// Reason for the status of the Transaction Type Authorized Role
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public System.Nullable<TestProxy.ccllc_transactiontypeauthorizedrole_statuscode> statuscode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
				if ((optionSet != null))
				{
					return ((TestProxy.ccllc_transactiontypeauthorizedrole_statuscode)(System.Enum.ToObject(typeof(TestProxy.ccllc_transactiontypeauthorizedrole_statuscode), optionSet.Value)));
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
		/// N:1 business_unit_ccllc_transactiontypeauthorizedrole
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_transactiontypeauthorizedrole")]
		public TestProxy.BusinessUnit business_unit_ccllc_transactiontypeauthorizedrole
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.BusinessUnit>("business_unit_ccllc_transactiontypeauthorizedrole", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_transactiontypeauthorizedrole_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactiontypeauthorizedrole_createdby")]
		public TestProxy.SystemUser lk_ccllc_transactiontypeauthorizedrole_createdby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_transactiontypeauthorizedrole_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_transactiontypeauthorizedrole_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactiontypeauthorizedrole_createdonbehalfby")]
		public TestProxy.SystemUser lk_ccllc_transactiontypeauthorizedrole_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_transactiontypeauthorizedrole_createdonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_transactiontypeauthorizedrole_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactiontypeauthorizedrole_modifiedby")]
		public TestProxy.SystemUser lk_ccllc_transactiontypeauthorizedrole_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_transactiontypeauthorizedrole_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_transactiontypeauthorizedrole_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactiontypeauthorizedrole_modifiedonbehalfby")]
		public TestProxy.SystemUser lk_ccllc_transactiontypeauthorizedrole_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_transactiontypeauthorizedrole_modifiedonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 ccllc_transactiontype_authorizedrole
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_roleid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transactiontype_authorizedrole")]
		public TestProxy.ccllc_role ccllc_transactiontype_authorizedrole
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.ccllc_role>("ccllc_transactiontype_authorizedrole", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transactiontype_authorizedrole");
				this.SetRelatedEntity<TestProxy.ccllc_role>("ccllc_transactiontype_authorizedrole", null, value);
				this.OnPropertyChanged("ccllc_transactiontype_authorizedrole");
			}
		}
		
		/// <summary>
		/// N:1 ccllc_transactiontype_authorizedroles
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_transactiontypeid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transactiontype_authorizedroles")]
		public TestProxy.ccllc_transactiontype ccllc_transactiontype_authorizedroles
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.ccllc_transactiontype>("ccllc_transactiontype_authorizedroles", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transactiontype_authorizedroles");
				this.SetRelatedEntity<TestProxy.ccllc_transactiontype>("ccllc_transactiontype_authorizedroles", null, value);
				this.OnPropertyChanged("ccllc_transactiontype_authorizedroles");
			}
		}
		
		/// <summary>
		/// N:1 user_ccllc_transactiontypeauthorizedrole
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_transactiontypeauthorizedrole")]
		public TestProxy.SystemUser user_ccllc_transactiontypeauthorizedrole
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("user_ccllc_transactiontypeauthorizedrole", null);
			}
		}
	}
}
