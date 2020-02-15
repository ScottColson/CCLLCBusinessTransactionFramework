namespace CCLLC.BTF.Platform.CDS
{

	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("ccllc_agent")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class ccllc_agent : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public ccllc_agent() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "ccllc_agent";
		
		public const int EntityTypeCode = 10017;
		
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
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_agentid")]
		public System.Nullable<System.Guid> ccllc_agentId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("ccllc_agentid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_agentId");
				this.SetAttributeValue("ccllc_agentid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ccllc_agentId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_agentid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.ccllc_agentId = value;
			}
		}
		
		/// <summary>
		/// Defines the Type of Agent.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_agenttype")]
		public System.Nullable<CCLLC.BTF.Platform.CDS.ccllc_agent_ccllc_agenttype> ccllc_AgentType
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("ccllc_agenttype");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Platform.CDS.ccllc_agent_ccllc_agenttype)(System.Enum.ToObject(typeof(CCLLC.BTF.Platform.CDS.ccllc_agent_ccllc_agenttype), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("ccllc_AgentType");
				if ((value == null))
				{
					this.SetAttributeValue("ccllc_agenttype", null);
				}
				else
				{
					this.SetAttributeValue("ccllc_agenttype", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("ccllc_AgentType");
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
		/// Link back to user that the agent record represents.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_userid")]
		public Microsoft.Xrm.Sdk.EntityReference ccllc_UserId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ccllc_userid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_UserId");
				this.SetAttributeValue("ccllc_userid", value);
				this.OnPropertyChanged("ccllc_UserId");
			}
		}
		
		/// <summary>
		/// Status of the Agent
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<CCLLC.BTF.Platform.CDS.ccllc_agentState> statecode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Platform.CDS.ccllc_agentState)(System.Enum.ToObject(typeof(CCLLC.BTF.Platform.CDS.ccllc_agentState), optionSet.Value)));
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
		/// Reason for the status of the Agent
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public System.Nullable<CCLLC.BTF.Platform.CDS.ccllc_agent_statuscode> statuscode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Platform.CDS.ccllc_agent_statuscode)(System.Enum.ToObject(typeof(CCLLC.BTF.Platform.CDS.ccllc_agent_statuscode), optionSet.Value)));
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
		/// 1:N ccllc_agent_agentrole
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_agent_agentrole")]
		public System.Collections.Generic.IEnumerable<CCLLC.BTF.Platform.CDS.ccllc_agentrole> ccllc_agent_agentrole
		{
			get
			{
				return this.GetRelatedEntities<CCLLC.BTF.Platform.CDS.ccllc_agentrole>("ccllc_agent_agentrole", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_agent_agentrole");
				this.SetRelatedEntities<CCLLC.BTF.Platform.CDS.ccllc_agentrole>("ccllc_agent_agentrole", null, value);
				this.OnPropertyChanged("ccllc_agent_agentrole");
			}
		}
		
		/// <summary>
		/// 1:N ccllc_agent_authorizedcustomer
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_agent_authorizedcustomer")]
		public System.Collections.Generic.IEnumerable<CCLLC.BTF.Platform.CDS.ccllc_agentauthorizedcustomer> ccllc_agent_authorizedcustomer
		{
			get
			{
				return this.GetRelatedEntities<CCLLC.BTF.Platform.CDS.ccllc_agentauthorizedcustomer>("ccllc_agent_authorizedcustomer", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_agent_authorizedcustomer");
				this.SetRelatedEntities<CCLLC.BTF.Platform.CDS.ccllc_agentauthorizedcustomer>("ccllc_agent_authorizedcustomer", null, value);
				this.OnPropertyChanged("ccllc_agent_authorizedcustomer");
			}
		}
		
		/// <summary>
		/// 1:N ccllc_agent_prohibitedcustomer
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_agent_prohibitedcustomer")]
		public System.Collections.Generic.IEnumerable<CCLLC.BTF.Platform.CDS.ccllc_agentprohibitedcustomer> ccllc_agent_prohibitedcustomer
		{
			get
			{
				return this.GetRelatedEntities<CCLLC.BTF.Platform.CDS.ccllc_agentprohibitedcustomer>("ccllc_agent_prohibitedcustomer", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_agent_prohibitedcustomer");
				this.SetRelatedEntities<CCLLC.BTF.Platform.CDS.ccllc_agentprohibitedcustomer>("ccllc_agent_prohibitedcustomer", null, value);
				this.OnPropertyChanged("ccllc_agent_prohibitedcustomer");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_ccllc_agent
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_agent")]
		public CCLLC.BTF.Platform.CDS.BusinessUnit business_unit_ccllc_agent
		{
			get
			{
				return this.GetRelatedEntity<CCLLC.BTF.Platform.CDS.BusinessUnit>("business_unit_ccllc_agent", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_agent_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_agent_createdby")]
		public CCLLC.BTF.Platform.CDS.SystemUser lk_ccllc_agent_createdby
		{
			get
			{
				return this.GetRelatedEntity<CCLLC.BTF.Platform.CDS.SystemUser>("lk_ccllc_agent_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_agent_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_agent_createdonbehalfby")]
		public CCLLC.BTF.Platform.CDS.SystemUser lk_ccllc_agent_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<CCLLC.BTF.Platform.CDS.SystemUser>("lk_ccllc_agent_createdonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_agent_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_agent_modifiedby")]
		public CCLLC.BTF.Platform.CDS.SystemUser lk_ccllc_agent_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<CCLLC.BTF.Platform.CDS.SystemUser>("lk_ccllc_agent_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_agent_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_agent_modifiedonbehalfby")]
		public CCLLC.BTF.Platform.CDS.SystemUser lk_ccllc_agent_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<CCLLC.BTF.Platform.CDS.SystemUser>("lk_ccllc_agent_modifiedonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 ccllc_systemuser_assignedagent
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_userid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_systemuser_assignedagent")]
		public CCLLC.BTF.Platform.CDS.SystemUser ccllc_systemuser_assignedagent
		{
			get
			{
				return this.GetRelatedEntity<CCLLC.BTF.Platform.CDS.SystemUser>("ccllc_systemuser_assignedagent", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_systemuser_assignedagent");
				this.SetRelatedEntity<CCLLC.BTF.Platform.CDS.SystemUser>("ccllc_systemuser_assignedagent", null, value);
				this.OnPropertyChanged("ccllc_systemuser_assignedagent");
			}
		}
		
		/// <summary>
		/// N:1 user_ccllc_agent
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_agent")]
		public CCLLC.BTF.Platform.CDS.SystemUser user_ccllc_agent
		{
			get
			{
				return this.GetRelatedEntity<CCLLC.BTF.Platform.CDS.SystemUser>("user_ccllc_agent", null);
			}
		}
	}
}
