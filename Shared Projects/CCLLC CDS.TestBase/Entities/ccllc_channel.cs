namespace TestProxy
{

	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("ccllc_channel")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class ccllc_channel : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public ccllc_channel() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "ccllc_channel";
		
		public const int EntityTypeCode = 10077;
		
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
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_channelid")]
		public System.Nullable<System.Guid> ccllc_channelId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("ccllc_channelid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_channelId");
				this.SetAttributeValue("ccllc_channelid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ccllc_channelId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_channelid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.ccllc_channelId = value;
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_channeltypecode")]
		public System.Nullable<TestProxy.ccllc_channeltypeoptions> ccllc_ChannelTypeCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("ccllc_channeltypecode");
				if ((optionSet != null))
				{
					return ((TestProxy.ccllc_channeltypeoptions)(System.Enum.ToObject(typeof(TestProxy.ccllc_channeltypeoptions), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("ccllc_ChannelTypeCode");
				if ((value == null))
				{
					this.SetAttributeValue("ccllc_channeltypecode", null);
				}
				else
				{
					this.SetAttributeValue("ccllc_channeltypecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("ccllc_ChannelTypeCode");
			}
		}
		
		/// <summary>
		/// Defines the scope of customer interaction this channel supports.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_customerinteractionscopecode")]
		public System.Nullable<TestProxy.ccllc_customerinteractionscopeoptions> ccllc_CustomerInteractionScopeCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("ccllc_customerinteractionscopecode");
				if ((optionSet != null))
				{
					return ((TestProxy.ccllc_customerinteractionscopeoptions)(System.Enum.ToObject(typeof(TestProxy.ccllc_customerinteractionscopeoptions), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("ccllc_CustomerInteractionScopeCode");
				if ((value == null))
				{
					this.SetAttributeValue("ccllc_customerinteractionscopecode", null);
				}
				else
				{
					this.SetAttributeValue("ccllc_customerinteractionscopecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("ccllc_CustomerInteractionScopeCode");
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
		/// Defines the partner that the channel supports.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_partnerid")]
		public Microsoft.Xrm.Sdk.EntityReference ccllc_PartnerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ccllc_partnerid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_PartnerId");
				this.SetAttributeValue("ccllc_partnerid", value);
				this.OnPropertyChanged("ccllc_PartnerId");
			}
		}
		
		/// <summary>
		/// Status of the Channel
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<TestProxy.ccllc_channelState> statecode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((TestProxy.ccllc_channelState)(System.Enum.ToObject(typeof(TestProxy.ccllc_channelState), optionSet.Value)));
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
		/// Reason for the status of the Channel
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public System.Nullable<TestProxy.ccllc_channel_statuscode> statuscode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
				if ((optionSet != null))
				{
					return ((TestProxy.ccllc_channel_statuscode)(System.Enum.ToObject(typeof(TestProxy.ccllc_channel_statuscode), optionSet.Value)));
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
		/// 1:N ccllc_channel_authorizedtransactiontype
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_channel_authorizedtransactiontype")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiontypeauthorizedchannel> ccllc_channel_authorizedtransactiontype
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiontypeauthorizedchannel>("ccllc_channel_authorizedtransactiontype", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_channel_authorizedtransactiontype");
				this.SetRelatedEntities<TestProxy.ccllc_transactiontypeauthorizedchannel>("ccllc_channel_authorizedtransactiontype", null, value);
				this.OnPropertyChanged("ccllc_channel_authorizedtransactiontype");
			}
		}
		
		/// <summary>
		/// 1:N ccllc_channel_processauthorizedchannel
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_channel_processauthorizedchannel")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processauthorizedchannel> ccllc_channel_processauthorizedchannel
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processauthorizedchannel>("ccllc_channel_processauthorizedchannel", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_channel_processauthorizedchannel");
				this.SetRelatedEntities<TestProxy.ccllc_processauthorizedchannel>("ccllc_channel_processauthorizedchannel", null, value);
				this.OnPropertyChanged("ccllc_channel_processauthorizedchannel");
			}
		}
		
		/// <summary>
		/// 1:N ccllc_channel_stepauthorizedchannel
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_channel_stepauthorizedchannel")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processstepauthorizedchannel> ccllc_channel_stepauthorizedchannel
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processstepauthorizedchannel>("ccllc_channel_stepauthorizedchannel", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_channel_stepauthorizedchannel");
				this.SetRelatedEntities<TestProxy.ccllc_processstepauthorizedchannel>("ccllc_channel_stepauthorizedchannel", null, value);
				this.OnPropertyChanged("ccllc_channel_stepauthorizedchannel");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_ccllc_channel
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_channel")]
		public TestProxy.BusinessUnit business_unit_ccllc_channel
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.BusinessUnit>("business_unit_ccllc_channel", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_channel_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_channel_createdby")]
		public TestProxy.SystemUser lk_ccllc_channel_createdby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_channel_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_channel_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_channel_createdonbehalfby")]
		public TestProxy.SystemUser lk_ccllc_channel_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_channel_createdonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_channel_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_channel_modifiedby")]
		public TestProxy.SystemUser lk_ccllc_channel_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_channel_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_channel_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_channel_modifiedonbehalfby")]
		public TestProxy.SystemUser lk_ccllc_channel_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_channel_modifiedonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 ccllc_partner_channel
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_partnerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_partner_channel")]
		public TestProxy.ccllc_partner ccllc_partner_channel
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.ccllc_partner>("ccllc_partner_channel", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_partner_channel");
				this.SetRelatedEntity<TestProxy.ccllc_partner>("ccllc_partner_channel", null, value);
				this.OnPropertyChanged("ccllc_partner_channel");
			}
		}
		
		/// <summary>
		/// N:1 user_ccllc_channel
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_channel")]
		public TestProxy.SystemUser user_ccllc_channel
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("user_ccllc_channel", null);
			}
		}
	}
}
