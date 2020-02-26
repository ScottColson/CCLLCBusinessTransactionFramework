namespace TestProxy
{

	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("ccllc_alternatebranch")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.28")]
	public partial class ccllc_alternatebranch : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public ccllc_alternatebranch() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "ccllc_alternatebranch";
		
		public const int EntityTypeCode = 10154;
		
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
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_alternatebranchid")]
		public System.Nullable<System.Guid> ccllc_alternatebranchId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("ccllc_alternatebranchid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_alternatebranchId");
				this.SetAttributeValue("ccllc_alternatebranchid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ccllc_alternatebranchId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_alternatebranchid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.ccllc_alternatebranchId = value;
			}
		}
		
		/// <summary>
		/// A relative ranking order to evaluate branch conditions. Branches are evaluated from lowest number to highest number.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_evaluationorder")]
		public System.Nullable<int> ccllc_EvaluationOrder
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("ccllc_evaluationorder");
			}
			set
			{
				this.OnPropertyChanging("ccllc_EvaluationOrder");
				this.SetAttributeValue("ccllc_evaluationorder", value);
				this.OnPropertyChanged("ccllc_EvaluationOrder");
			}
		}
		
		/// <summary>
		/// Parameter information used during evaluation of the branching logic.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_evaluationparameters")]
		public string ccllc_EvaluationParameters
		{
			get
			{
				return this.GetAttributeValue<string>("ccllc_evaluationparameters");
			}
			set
			{
				this.OnPropertyChanging("ccllc_EvaluationParameters");
				this.SetAttributeValue("ccllc_evaluationparameters", value);
				this.OnPropertyChanged("ccllc_EvaluationParameters");
			}
		}
		
		/// <summary>
		/// The type of evaluator the branch uses to determine if it should be taken.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_evaluatortypeid")]
		public Microsoft.Xrm.Sdk.EntityReference ccllc_EvaluatorTypeId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ccllc_evaluatortypeid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_EvaluatorTypeId");
				this.SetAttributeValue("ccllc_evaluatortypeid", value);
				this.OnPropertyChanged("ccllc_EvaluatorTypeId");
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
		/// The Process Step that parents the Alternate Branch.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_parentstepid")]
		public Microsoft.Xrm.Sdk.EntityReference ccllc_ParentStepId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ccllc_parentstepid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_ParentStepId");
				this.SetAttributeValue("ccllc_parentstepid", value);
				this.OnPropertyChanged("ccllc_ParentStepId");
			}
		}
		
		/// <summary>
		/// The first Process Step executed on this branch.
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
		/// Status of the Alternate Branch
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<TestProxy.ccllc_alternatebranchState> statecode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((TestProxy.ccllc_alternatebranchState)(System.Enum.ToObject(typeof(TestProxy.ccllc_alternatebranchState), optionSet.Value)));
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
		/// Reason for the status of the Alternate Branch
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public System.Nullable<TestProxy.ccllc_alternatebranch_statuscode> statuscode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
				if ((optionSet != null))
				{
					return ((TestProxy.ccllc_alternatebranch_statuscode)(System.Enum.ToObject(typeof(TestProxy.ccllc_alternatebranch_statuscode), optionSet.Value)));
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
		/// N:1 business_unit_ccllc_alternatebranch
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_alternatebranch")]
		public TestProxy.BusinessUnit business_unit_ccllc_alternatebranch
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.BusinessUnit>("business_unit_ccllc_alternatebranch", null);
			}
		}
		
		/// <summary>
		/// N:1 ccllc_evaluatortype_alternatebranch
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_evaluatortypeid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_evaluatortype_alternatebranch")]
		public TestProxy.ccllc_evaluatortype ccllc_evaluatortype_alternatebranch
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.ccllc_evaluatortype>("ccllc_evaluatortype_alternatebranch", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_evaluatortype_alternatebranch");
				this.SetRelatedEntity<TestProxy.ccllc_evaluatortype>("ccllc_evaluatortype_alternatebranch", null, value);
				this.OnPropertyChanged("ccllc_evaluatortype_alternatebranch");
			}
		}
		
		/// <summary>
		/// N:1 ccllc_parentprocessstep_alternatebranch
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_parentstepid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_parentprocessstep_alternatebranch")]
		public TestProxy.ccllc_processstep ccllc_parentprocessstep_alternatebranch
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.ccllc_processstep>("ccllc_parentprocessstep_alternatebranch", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_parentprocessstep_alternatebranch");
				this.SetRelatedEntity<TestProxy.ccllc_processstep>("ccllc_parentprocessstep_alternatebranch", null, value);
				this.OnPropertyChanged("ccllc_parentprocessstep_alternatebranch");
			}
		}
		
		/// <summary>
		/// N:1 ccllc_subsequentprocessstep_alternatebranch
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_subsequentstepid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_subsequentprocessstep_alternatebranch")]
		public TestProxy.ccllc_processstep ccllc_subsequentprocessstep_alternatebranch
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.ccllc_processstep>("ccllc_subsequentprocessstep_alternatebranch", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_subsequentprocessstep_alternatebranch");
				this.SetRelatedEntity<TestProxy.ccllc_processstep>("ccllc_subsequentprocessstep_alternatebranch", null, value);
				this.OnPropertyChanged("ccllc_subsequentprocessstep_alternatebranch");
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_alternatebranch_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_alternatebranch_createdby")]
		public TestProxy.SystemUser lk_ccllc_alternatebranch_createdby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_alternatebranch_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_alternatebranch_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_alternatebranch_createdonbehalfby")]
		public TestProxy.SystemUser lk_ccllc_alternatebranch_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_alternatebranch_createdonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_alternatebranch_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_alternatebranch_modifiedby")]
		public TestProxy.SystemUser lk_ccllc_alternatebranch_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_alternatebranch_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_alternatebranch_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_alternatebranch_modifiedonbehalfby")]
		public TestProxy.SystemUser lk_ccllc_alternatebranch_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_alternatebranch_modifiedonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 user_ccllc_alternatebranch
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_alternatebranch")]
		public TestProxy.SystemUser user_ccllc_alternatebranch
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("user_ccllc_alternatebranch", null);
			}
		}
	}
}
