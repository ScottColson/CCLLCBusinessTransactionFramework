namespace TestProxy
{

	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("ccllc_stephistory")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class ccllc_stephistory : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public ccllc_stephistory() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "ccllc_stephistory";
		
		public const int EntityTypeCode = 10102;
		
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
		/// The Location where the associated Process Step was completed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_completedatlocationid")]
		public Microsoft.Xrm.Sdk.EntityReference ccllc_CompletedAtLocationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ccllc_completedatlocationid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_CompletedAtLocationId");
				this.SetAttributeValue("ccllc_completedatlocationid", value);
				this.OnPropertyChanged("ccllc_CompletedAtLocationId");
			}
		}
		
		/// <summary>
		/// The Agent the completed the associated Process Step.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_completedbyagentid")]
		public Microsoft.Xrm.Sdk.EntityReference ccllc_CompletedByAgentId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ccllc_completedbyagentid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_CompletedByAgentId");
				this.SetAttributeValue("ccllc_completedbyagentid", value);
				this.OnPropertyChanged("ccllc_CompletedByAgentId");
			}
		}
		
		/// <summary>
		/// Tracks the date and time a step was completed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_completedon")]
		public System.Nullable<System.DateTime> ccllc_CompletedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("ccllc_completedon");
			}
			set
			{
				this.OnPropertyChanging("ccllc_CompletedOn");
				this.SetAttributeValue("ccllc_completedon", value);
				this.OnPropertyChanged("ccllc_CompletedOn");
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
		/// Pointer to the next record in the list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_nextrecordid")]
		public Microsoft.Xrm.Sdk.EntityReference ccllc_NextRecordId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ccllc_nextrecordid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_NextRecordId");
				this.SetAttributeValue("ccllc_nextrecordid", value);
				this.OnPropertyChanged("ccllc_NextRecordId");
			}
		}
		
		/// <summary>
		/// Pointer to the record prior to this record in the list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_previousrecordid")]
		public Microsoft.Xrm.Sdk.EntityReference ccllc_PreviousRecordId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ccllc_previousrecordid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_PreviousRecordId");
				this.SetAttributeValue("ccllc_previousrecordid", value);
				this.OnPropertyChanged("ccllc_PreviousRecordId");
			}
		}
		
		/// <summary>
		/// The Process Step that the history relates to.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_processstepid")]
		public Microsoft.Xrm.Sdk.EntityReference ccllc_ProcessStepId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ccllc_processstepid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_ProcessStepId");
				this.SetAttributeValue("ccllc_processstepid", value);
				this.OnPropertyChanged("ccllc_ProcessStepId");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_stephistoryid")]
		public System.Nullable<System.Guid> ccllc_stephistoryId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("ccllc_stephistoryid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_stephistoryId");
				this.SetAttributeValue("ccllc_stephistoryid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ccllc_stephistoryId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_stephistoryid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.ccllc_stephistoryId = value;
			}
		}
		
		/// <summary>
		/// The Transaction the history is related to.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_transactionid")]
		public Microsoft.Xrm.Sdk.EntityReference ccllc_TransactionId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ccllc_transactionid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_TransactionId");
				this.SetAttributeValue("ccllc_transactionid", value);
				this.OnPropertyChanged("ccllc_TransactionId");
			}
		}
		
		/// <summary>
		/// Status of the Step History
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<TestProxy.ccllc_stephistoryState> statecode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((TestProxy.ccllc_stephistoryState)(System.Enum.ToObject(typeof(TestProxy.ccllc_stephistoryState), optionSet.Value)));
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
		/// Reason for the status of the Step History
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public System.Nullable<TestProxy.ccllc_stephistory_statuscode> statuscode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
				if ((optionSet != null))
				{
					return ((TestProxy.ccllc_stephistory_statuscode)(System.Enum.ToObject(typeof(TestProxy.ccllc_stephistory_statuscode), optionSet.Value)));
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
		/// 1:N ccllc_stephistory_nextrecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_stephistory_nextrecord", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_stephistory> Referencedccllc_stephistory_nextrecord
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_stephistory>("ccllc_stephistory_nextrecord", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedccllc_stephistory_nextrecord");
				this.SetRelatedEntities<TestProxy.ccllc_stephistory>("ccllc_stephistory_nextrecord", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedccllc_stephistory_nextrecord");
			}
		}
		
		/// <summary>
		/// 1:N ccllc_stephistory_previousrecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_stephistory_previousrecord", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_stephistory> Referencedccllc_stephistory_previousrecord
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_stephistory>("ccllc_stephistory_previousrecord", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedccllc_stephistory_previousrecord");
				this.SetRelatedEntities<TestProxy.ccllc_stephistory>("ccllc_stephistory_previousrecord", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedccllc_stephistory_previousrecord");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_ccllc_stephistory
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_stephistory")]
		public TestProxy.BusinessUnit business_unit_ccllc_stephistory
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.BusinessUnit>("business_unit_ccllc_stephistory", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_stephistory_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_stephistory_createdby")]
		public TestProxy.SystemUser lk_ccllc_stephistory_createdby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_stephistory_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_stephistory_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_stephistory_createdonbehalfby")]
		public TestProxy.SystemUser lk_ccllc_stephistory_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_stephistory_createdonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_stephistory_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_stephistory_modifiedby")]
		public TestProxy.SystemUser lk_ccllc_stephistory_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_stephistory_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_stephistory_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_stephistory_modifiedonbehalfby")]
		public TestProxy.SystemUser lk_ccllc_stephistory_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_stephistory_modifiedonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 ccllc_agent_stephistorycompletedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_completedbyagentid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_agent_stephistorycompletedby")]
		public TestProxy.ccllc_agent ccllc_agent_stephistorycompletedby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.ccllc_agent>("ccllc_agent_stephistorycompletedby", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_agent_stephistorycompletedby");
				this.SetRelatedEntity<TestProxy.ccllc_agent>("ccllc_agent_stephistorycompletedby", null, value);
				this.OnPropertyChanged("ccllc_agent_stephistorycompletedby");
			}
		}
		
		/// <summary>
		/// N:1 ccllc_location_stepcompletedlocation
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_completedatlocationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_location_stepcompletedlocation")]
		public TestProxy.ccllc_location ccllc_location_stepcompletedlocation
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.ccllc_location>("ccllc_location_stepcompletedlocation", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_location_stepcompletedlocation");
				this.SetRelatedEntity<TestProxy.ccllc_location>("ccllc_location_stepcompletedlocation", null, value);
				this.OnPropertyChanged("ccllc_location_stepcompletedlocation");
			}
		}
		
		/// <summary>
		/// N:1 ccllc_processstep_stephistory
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_processstepid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_processstep_stephistory")]
		public TestProxy.ccllc_processstep ccllc_processstep_stephistory
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.ccllc_processstep>("ccllc_processstep_stephistory", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_processstep_stephistory");
				this.SetRelatedEntity<TestProxy.ccllc_processstep>("ccllc_processstep_stephistory", null, value);
				this.OnPropertyChanged("ccllc_processstep_stephistory");
			}
		}
		
		/// <summary>
		/// N:1 ccllc_stephistory_nextrecord
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_nextrecordid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_stephistory_nextrecord", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public TestProxy.ccllc_stephistory Referencingccllc_stephistory_nextrecord
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.ccllc_stephistory>("ccllc_stephistory_nextrecord", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			set
			{
				this.OnPropertyChanging("Referencingccllc_stephistory_nextrecord");
				this.SetRelatedEntity<TestProxy.ccllc_stephistory>("ccllc_stephistory_nextrecord", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
				this.OnPropertyChanged("Referencingccllc_stephistory_nextrecord");
			}
		}
		
		/// <summary>
		/// N:1 ccllc_stephistory_previousrecord
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_previousrecordid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_stephistory_previousrecord", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public TestProxy.ccllc_stephistory Referencingccllc_stephistory_previousrecord
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.ccllc_stephistory>("ccllc_stephistory_previousrecord", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			set
			{
				this.OnPropertyChanging("Referencingccllc_stephistory_previousrecord");
				this.SetRelatedEntity<TestProxy.ccllc_stephistory>("ccllc_stephistory_previousrecord", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
				this.OnPropertyChanged("Referencingccllc_stephistory_previousrecord");
			}
		}
		
		/// <summary>
		/// N:1 ccllc_transaction_stephistory
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_transactionid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transaction_stephistory")]
		public TestProxy.ccllc_transaction ccllc_transaction_stephistory
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.ccllc_transaction>("ccllc_transaction_stephistory", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transaction_stephistory");
				this.SetRelatedEntity<TestProxy.ccllc_transaction>("ccllc_transaction_stephistory", null, value);
				this.OnPropertyChanged("ccllc_transaction_stephistory");
			}
		}
		
		/// <summary>
		/// N:1 user_ccllc_stephistory
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_stephistory")]
		public TestProxy.SystemUser user_ccllc_stephistory
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("user_ccllc_stephistory", null);
			}
		}
	}
}
