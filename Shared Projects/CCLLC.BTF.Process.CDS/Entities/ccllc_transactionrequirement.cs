namespace CCLLC.BTF.Process.CDS
{

	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("ccllc_transactionrequirement")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.28")]
	public partial class ccllc_transactionrequirement : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public ccllc_transactionrequirement() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "ccllc_transactionrequirement";
		
		public const int EntityTypeCode = 10164;
		
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
		/// Defines the type of evaluator used to verify the requirement.
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
		/// Serialized parameters used by the evaluator to verify the requirement.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_requirementparameters")]
		public string ccllc_RequirementParameters
		{
			get
			{
				return this.GetAttributeValue<string>("ccllc_requirementparameters");
			}
			set
			{
				this.OnPropertyChanging("ccllc_RequirementParameters");
				this.SetAttributeValue("ccllc_requirementparameters", value);
				this.OnPropertyChanged("ccllc_RequirementParameters");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_transactionrequirementid")]
		public System.Nullable<System.Guid> ccllc_transactionrequirementId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("ccllc_transactionrequirementid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_transactionrequirementId");
				this.SetAttributeValue("ccllc_transactionrequirementid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ccllc_transactionrequirementId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_transactionrequirementid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.ccllc_transactionrequirementId = value;
			}
		}
		
		/// <summary>
		/// Defines the type of requirement
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_transactionrequirementtypecode")]
		public object ccllc_TransactionRequirementTypeCode
		{
			get
			{
				return this.GetAttributeValue<object>("ccllc_transactionrequirementtypecode");
			}
			set
			{
				this.OnPropertyChanging("ccllc_TransactionRequirementTypeCode");
				this.SetAttributeValue("ccllc_transactionrequirementtypecode", value);
				this.OnPropertyChanged("ccllc_TransactionRequirementTypeCode");
			}
		}
		
		/// <summary>
		/// The Transaction Type the Transaction Requirement applies to.
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
		/// Status of the Transaction Requirement
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<CCLLC.BTF.Process.CDS.ccllc_transactionrequirementState> statecode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Process.CDS.ccllc_transactionrequirementState)(System.Enum.ToObject(typeof(CCLLC.BTF.Process.CDS.ccllc_transactionrequirementState), optionSet.Value)));
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
		/// Reason for the status of the Transaction Requirement
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public System.Nullable<CCLLC.BTF.Process.CDS.ccllc_transactionrequirement_statuscode> statuscode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Process.CDS.ccllc_transactionrequirement_statuscode)(System.Enum.ToObject(typeof(CCLLC.BTF.Process.CDS.ccllc_transactionrequirement_statuscode), optionSet.Value)));
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
		/// 1:N ccllc_requirement_requirementwaiverrole
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_requirement_requirementwaiverrole")]
		public System.Collections.Generic.IEnumerable<CCLLC.BTF.Process.CDS.ccllc_requirementwaiverrole> ccllc_requirement_requirementwaiverrole
		{
			get
			{
				return this.GetRelatedEntities<CCLLC.BTF.Process.CDS.ccllc_requirementwaiverrole>("ccllc_requirement_requirementwaiverrole", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_requirement_requirementwaiverrole");
				this.SetRelatedEntities<CCLLC.BTF.Process.CDS.ccllc_requirementwaiverrole>("ccllc_requirement_requirementwaiverrole", null, value);
				this.OnPropertyChanged("ccllc_requirement_requirementwaiverrole");
			}
		}
		
		/// <summary>
		/// 1:N ccllc_transactiondeficiency_requirement
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transactiondeficiency_requirement")]
		public System.Collections.Generic.IEnumerable<CCLLC.BTF.Process.CDS.ccllc_transactiondeficiency> ccllc_transactiondeficiency_requirement
		{
			get
			{
				return this.GetRelatedEntities<CCLLC.BTF.Process.CDS.ccllc_transactiondeficiency>("ccllc_transactiondeficiency_requirement", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transactiondeficiency_requirement");
				this.SetRelatedEntities<CCLLC.BTF.Process.CDS.ccllc_transactiondeficiency>("ccllc_transactiondeficiency_requirement", null, value);
				this.OnPropertyChanged("ccllc_transactiondeficiency_requirement");
			}
		}
		
		/// <summary>
		/// 1:N ccllc_transactionrequirement__processstep
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transactionrequirement__processstep")]
		public System.Collections.Generic.IEnumerable<CCLLC.BTF.Process.CDS.ccllc_processsteprequirement> ccllc_transactionrequirement__processstep
		{
			get
			{
				return this.GetRelatedEntities<CCLLC.BTF.Process.CDS.ccllc_processsteprequirement>("ccllc_transactionrequirement__processstep", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transactionrequirement__processstep");
				this.SetRelatedEntities<CCLLC.BTF.Process.CDS.ccllc_processsteprequirement>("ccllc_transactionrequirement__processstep", null, value);
				this.OnPropertyChanged("ccllc_transactionrequirement__processstep");
			}
		}
		
		/// <summary>
		/// 1:N ccllc_transactionrequirement_waiverrole
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transactionrequirement_waiverrole")]
		public System.Collections.Generic.IEnumerable<CCLLC.BTF.Process.CDS.ccllc_transactionrequirementwaiverrole> ccllc_transactionrequirement_waiverrole
		{
			get
			{
				return this.GetRelatedEntities<CCLLC.BTF.Process.CDS.ccllc_transactionrequirementwaiverrole>("ccllc_transactionrequirement_waiverrole", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transactionrequirement_waiverrole");
				this.SetRelatedEntities<CCLLC.BTF.Process.CDS.ccllc_transactionrequirementwaiverrole>("ccllc_transactionrequirement_waiverrole", null, value);
				this.OnPropertyChanged("ccllc_transactionrequirement_waiverrole");
			}
		}
		
		/// <summary>
		/// N:1 ccllc_transactiontype_requirements
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_transactiontypeid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transactiontype_requirements")]
		public CCLLC.BTF.Process.CDS.ccllc_transactiontype ccllc_transactiontype_requirements
		{
			get
			{
				return this.GetRelatedEntity<CCLLC.BTF.Process.CDS.ccllc_transactiontype>("ccllc_transactiontype_requirements", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transactiontype_requirements");
				this.SetRelatedEntity<CCLLC.BTF.Process.CDS.ccllc_transactiontype>("ccllc_transactiontype_requirements", null, value);
				this.OnPropertyChanged("ccllc_transactiontype_requirements");
			}
		}
	}
}
