namespace TestProxy
{

	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("ccllc_processstep")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.28")]
	public partial class ccllc_processstep : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public ccllc_processstep() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "ccllc_processstep";
		
		public const int EntityTypeCode = 10170;
		
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
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_processstepid")]
		public System.Nullable<System.Guid> ccllc_processstepId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("ccllc_processstepid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_processstepId");
				this.SetAttributeValue("ccllc_processstepid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ccllc_processstepId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_processstepid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.ccllc_processstepId = value;
			}
		}
		
		/// <summary>
		/// The type of the Process Step
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_processsteptypeid")]
		public Microsoft.Xrm.Sdk.EntityReference ccllc_ProcessStepTypeId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ccllc_processsteptypeid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_ProcessStepTypeId");
				this.SetAttributeValue("ccllc_processsteptypeid", value);
				this.OnPropertyChanged("ccllc_ProcessStepTypeId");
			}
		}
		
		/// <summary>
		/// Contains parameter information used during the execution of the process step.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_stepparameters")]
		public string ccllc_StepParameters
		{
			get
			{
				return this.GetAttributeValue<string>("ccllc_stepparameters");
			}
			set
			{
				this.OnPropertyChanging("ccllc_StepParameters");
				this.SetAttributeValue("ccllc_stepparameters", value);
				this.OnPropertyChanged("ccllc_StepParameters");
			}
		}
		
		/// <summary>
		/// The next step completed after this step if no other conditional branching occurs.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_subsequentstepid")]
		public Microsoft.Xrm.Sdk.EntityReference ccllc_SubsequentStepId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ccllc_subsequentstepid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_SubsequentStepId");
				this.SetAttributeValue("ccllc_subsequentstepid", value);
				this.OnPropertyChanged("ccllc_SubsequentStepId");
			}
		}
		
		/// <summary>
		/// Unique identifier for Transaction Process associated with Process Step.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_transactionprocessid")]
		public Microsoft.Xrm.Sdk.EntityReference ccllc_TransactionProcessId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ccllc_transactionprocessid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_TransactionProcessId");
				this.SetAttributeValue("ccllc_transactionprocessid", value);
				this.OnPropertyChanged("ccllc_TransactionProcessId");
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
		/// Status of the Process Step
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<TestProxy.ccllc_processstepState> statecode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((TestProxy.ccllc_processstepState)(System.Enum.ToObject(typeof(TestProxy.ccllc_processstepState), optionSet.Value)));
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
		/// Reason for the status of the Process Step
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public System.Nullable<TestProxy.ccllc_processstep_statuscode> statuscode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
				if ((optionSet != null))
				{
					return ((TestProxy.ccllc_processstep_statuscode)(System.Enum.ToObject(typeof(TestProxy.ccllc_processstep_statuscode), optionSet.Value)));
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
		/// 1:N ccllc_parentprocessstep_alternatebranch
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_parentprocessstep_alternatebranch")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_alternatebranch> ccllc_parentprocessstep_alternatebranch
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_alternatebranch>("ccllc_parentprocessstep_alternatebranch", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_parentprocessstep_alternatebranch");
				this.SetRelatedEntities<TestProxy.ccllc_alternatebranch>("ccllc_parentprocessstep_alternatebranch", null, value);
				this.OnPropertyChanged("ccllc_parentprocessstep_alternatebranch");
			}
		}
		
		/// <summary>
		/// 1:N ccllc_processstep_stephistory
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_processstep_stephistory")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_stephistory> ccllc_processstep_stephistory
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_stephistory>("ccllc_processstep_stephistory", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_processstep_stephistory");
				this.SetRelatedEntities<TestProxy.ccllc_stephistory>("ccllc_processstep_stephistory", null, value);
				this.OnPropertyChanged("ccllc_processstep_stephistory");
			}
		}
		
		/// <summary>
		/// 1:N ccllc_processstep_steprequirement
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_processstep_steprequirement")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processsteprequirement> ccllc_processstep_steprequirement
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processsteprequirement>("ccllc_processstep_steprequirement", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_processstep_steprequirement");
				this.SetRelatedEntities<TestProxy.ccllc_processsteprequirement>("ccllc_processstep_steprequirement", null, value);
				this.OnPropertyChanged("ccllc_processstep_steprequirement");
			}
		}
		
		/// <summary>
		/// 1:N ccllc_processstep_subsequentstep
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_processstep_subsequentstep", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processstep> Referencedccllc_processstep_subsequentstep
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processstep>("ccllc_processstep_subsequentstep", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedccllc_processstep_subsequentstep");
				this.SetRelatedEntities<TestProxy.ccllc_processstep>("ccllc_processstep_subsequentstep", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedccllc_processstep_subsequentstep");
			}
		}
		
		/// <summary>
		/// 1:N ccllc_step_ccllc_stepauthorizedchannel
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_step_ccllc_stepauthorizedchannel")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processstepauthorizedchannel> ccllc_step_ccllc_stepauthorizedchannel
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processstepauthorizedchannel>("ccllc_step_ccllc_stepauthorizedchannel", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_step_ccllc_stepauthorizedchannel");
				this.SetRelatedEntities<TestProxy.ccllc_processstepauthorizedchannel>("ccllc_step_ccllc_stepauthorizedchannel", null, value);
				this.OnPropertyChanged("ccllc_step_ccllc_stepauthorizedchannel");
			}
		}
		
		/// <summary>
		/// 1:N ccllc_subsequentprocessstep_alternatebranch
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_subsequentprocessstep_alternatebranch")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_alternatebranch> ccllc_subsequentprocessstep_alternatebranch
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_alternatebranch>("ccllc_subsequentprocessstep_alternatebranch", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_subsequentprocessstep_alternatebranch");
				this.SetRelatedEntities<TestProxy.ccllc_alternatebranch>("ccllc_subsequentprocessstep_alternatebranch", null, value);
				this.OnPropertyChanged("ccllc_subsequentprocessstep_alternatebranch");
			}
		}
		
		/// <summary>
		/// 1:N ccllc_transaction_currentprocessstep
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transaction_currentprocessstep")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transaction> ccllc_transaction_currentprocessstep
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transaction>("ccllc_transaction_currentprocessstep", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transaction_currentprocessstep");
				this.SetRelatedEntities<TestProxy.ccllc_transaction>("ccllc_transaction_currentprocessstep", null, value);
				this.OnPropertyChanged("ccllc_transaction_currentprocessstep");
			}
		}
		
		/// <summary>
		/// 1:N ccllc_transactionprocess_initialstep
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transactionprocess_initialstep")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactionprocess> ccllc_transactionprocess_initialstep
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactionprocess>("ccllc_transactionprocess_initialstep", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transactionprocess_initialstep");
				this.SetRelatedEntities<TestProxy.ccllc_transactionprocess>("ccllc_transactionprocess_initialstep", null, value);
				this.OnPropertyChanged("ccllc_transactionprocess_initialstep");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_ccllc_processstep
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_processstep")]
		public TestProxy.BusinessUnit business_unit_ccllc_processstep
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.BusinessUnit>("business_unit_ccllc_processstep", null);
			}
		}
		
		/// <summary>
		/// N:1 ccllc_processstep_steptype
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_processsteptypeid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_processstep_steptype")]
		public TestProxy.ccllc_processsteptype ccllc_processstep_steptype
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.ccllc_processsteptype>("ccllc_processstep_steptype", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_processstep_steptype");
				this.SetRelatedEntity<TestProxy.ccllc_processsteptype>("ccllc_processstep_steptype", null, value);
				this.OnPropertyChanged("ccllc_processstep_steptype");
			}
		}
		
		/// <summary>
		/// N:1 ccllc_processstep_subsequentstep
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_subsequentstepid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_processstep_subsequentstep", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public TestProxy.ccllc_processstep Referencingccllc_processstep_subsequentstep
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.ccllc_processstep>("ccllc_processstep_subsequentstep", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			set
			{
				this.OnPropertyChanging("Referencingccllc_processstep_subsequentstep");
				this.SetRelatedEntity<TestProxy.ccllc_processstep>("ccllc_processstep_subsequentstep", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
				this.OnPropertyChanged("Referencingccllc_processstep_subsequentstep");
			}
		}
		
		/// <summary>
		/// N:1 ccllc_transactionprocess_assignedsteps
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_transactionprocessid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transactionprocess_assignedsteps")]
		public TestProxy.ccllc_transactionprocess ccllc_transactionprocess_assignedsteps
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.ccllc_transactionprocess>("ccllc_transactionprocess_assignedsteps", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transactionprocess_assignedsteps");
				this.SetRelatedEntity<TestProxy.ccllc_transactionprocess>("ccllc_transactionprocess_assignedsteps", null, value);
				this.OnPropertyChanged("ccllc_transactionprocess_assignedsteps");
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_processstep_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_processstep_createdby")]
		public TestProxy.SystemUser lk_ccllc_processstep_createdby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_processstep_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_processstep_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_processstep_createdonbehalfby")]
		public TestProxy.SystemUser lk_ccllc_processstep_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_processstep_createdonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_processstep_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_processstep_modifiedby")]
		public TestProxy.SystemUser lk_ccllc_processstep_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_processstep_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_processstep_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_processstep_modifiedonbehalfby")]
		public TestProxy.SystemUser lk_ccllc_processstep_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_processstep_modifiedonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 user_ccllc_processstep
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_processstep")]
		public TestProxy.SystemUser user_ccllc_processstep
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("user_ccllc_processstep", null);
			}
		}
	}
}
