namespace CCLLC.BTF.Process.CDS
{

	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("ccllc_transactionprocess")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class ccllc_transactionprocess : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public ccllc_transactionprocess() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "ccllc_transactionprocess";
		
		public const int EntityTypeCode = 10071;
		
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
		/// The Process Step that is executed at the beginning of the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_initialprocessstepid")]
		public Microsoft.Xrm.Sdk.EntityReference ccllc_InitialProcessStepId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ccllc_initialprocessstepid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_InitialProcessStepId");
				this.SetAttributeValue("ccllc_initialprocessstepid", value);
				this.OnPropertyChanged("ccllc_InitialProcessStepId");
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
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_transactionprocessid")]
		public System.Nullable<System.Guid> ccllc_transactionprocessId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("ccllc_transactionprocessid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_transactionprocessId");
				this.SetAttributeValue("ccllc_transactionprocessid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ccllc_transactionprocessId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_transactionprocessid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.ccllc_transactionprocessId = value;
			}
		}
		
		/// <summary>
		/// The Transaction Type the Transaction Process supports.
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
		/// Status of the Transaction Process
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<CCLLC.BTF.Process.CDS.ccllc_transactionprocessState> statecode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Process.CDS.ccllc_transactionprocessState)(System.Enum.ToObject(typeof(CCLLC.BTF.Process.CDS.ccllc_transactionprocessState), optionSet.Value)));
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
		/// Reason for the status of the Transaction Process
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public System.Nullable<CCLLC.BTF.Process.CDS.ccllc_transactionprocess_statuscode> statuscode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Process.CDS.ccllc_transactionprocess_statuscode)(System.Enum.ToObject(typeof(CCLLC.BTF.Process.CDS.ccllc_transactionprocess_statuscode), optionSet.Value)));
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
		/// 1:N ccllc_process_ccllc_processauthorizedchannel
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_process_ccllc_processauthorizedchannel")]
		public System.Collections.Generic.IEnumerable<CCLLC.BTF.Process.CDS.ccllc_processauthorizedchannel> ccllc_process_ccllc_processauthorizedchannel
		{
			get
			{
				return this.GetRelatedEntities<CCLLC.BTF.Process.CDS.ccllc_processauthorizedchannel>("ccllc_process_ccllc_processauthorizedchannel", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_process_ccllc_processauthorizedchannel");
				this.SetRelatedEntities<CCLLC.BTF.Process.CDS.ccllc_processauthorizedchannel>("ccllc_process_ccllc_processauthorizedchannel", null, value);
				this.OnPropertyChanged("ccllc_process_ccllc_processauthorizedchannel");
			}
		}
		
		/// <summary>
		/// 1:N ccllc_transaction_currentprocess
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transaction_currentprocess")]
		public System.Collections.Generic.IEnumerable<CCLLC.BTF.Process.CDS.ccllc_transaction> ccllc_transaction_currentprocess
		{
			get
			{
				return this.GetRelatedEntities<CCLLC.BTF.Process.CDS.ccllc_transaction>("ccllc_transaction_currentprocess", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transaction_currentprocess");
				this.SetRelatedEntities<CCLLC.BTF.Process.CDS.ccllc_transaction>("ccllc_transaction_currentprocess", null, value);
				this.OnPropertyChanged("ccllc_transaction_currentprocess");
			}
		}
		
		/// <summary>
		/// 1:N ccllc_transaction_initiatingprocess
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transaction_initiatingprocess")]
		public System.Collections.Generic.IEnumerable<CCLLC.BTF.Process.CDS.ccllc_transaction> ccllc_transaction_initiatingprocess
		{
			get
			{
				return this.GetRelatedEntities<CCLLC.BTF.Process.CDS.ccllc_transaction>("ccllc_transaction_initiatingprocess", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transaction_initiatingprocess");
				this.SetRelatedEntities<CCLLC.BTF.Process.CDS.ccllc_transaction>("ccllc_transaction_initiatingprocess", null, value);
				this.OnPropertyChanged("ccllc_transaction_initiatingprocess");
			}
		}
		
		/// <summary>
		/// 1:N ccllc_transactionprocess_assignedsteps
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transactionprocess_assignedsteps")]
		public System.Collections.Generic.IEnumerable<CCLLC.BTF.Process.CDS.ccllc_processstep> ccllc_transactionprocess_assignedsteps
		{
			get
			{
				return this.GetRelatedEntities<CCLLC.BTF.Process.CDS.ccllc_processstep>("ccllc_transactionprocess_assignedsteps", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transactionprocess_assignedsteps");
				this.SetRelatedEntities<CCLLC.BTF.Process.CDS.ccllc_processstep>("ccllc_transactionprocess_assignedsteps", null, value);
				this.OnPropertyChanged("ccllc_transactionprocess_assignedsteps");
			}
		}
		
		/// <summary>
		/// 1:N ccllc_transactiontype_startupprocess
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transactiontype_startupprocess")]
		public System.Collections.Generic.IEnumerable<CCLLC.BTF.Process.CDS.ccllc_transactiontype> ccllc_transactiontype_startupprocess
		{
			get
			{
				return this.GetRelatedEntities<CCLLC.BTF.Process.CDS.ccllc_transactiontype>("ccllc_transactiontype_startupprocess", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transactiontype_startupprocess");
				this.SetRelatedEntities<CCLLC.BTF.Process.CDS.ccllc_transactiontype>("ccllc_transactiontype_startupprocess", null, value);
				this.OnPropertyChanged("ccllc_transactiontype_startupprocess");
			}
		}
		
		/// <summary>
		/// N:1 ccllc_transactionprocess_initialstep
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_initialprocessstepid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transactionprocess_initialstep")]
		public CCLLC.BTF.Process.CDS.ccllc_processstep ccllc_transactionprocess_initialstep
		{
			get
			{
				return this.GetRelatedEntity<CCLLC.BTF.Process.CDS.ccllc_processstep>("ccllc_transactionprocess_initialstep", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transactionprocess_initialstep");
				this.SetRelatedEntity<CCLLC.BTF.Process.CDS.ccllc_processstep>("ccllc_transactionprocess_initialstep", null, value);
				this.OnPropertyChanged("ccllc_transactionprocess_initialstep");
			}
		}
		
		/// <summary>
		/// N:1 ccllc_transactiontype_availableprocesses
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_transactiontypeid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_transactiontype_availableprocesses")]
		public CCLLC.BTF.Process.CDS.ccllc_transactiontype ccllc_transactiontype_availableprocesses
		{
			get
			{
				return this.GetRelatedEntity<CCLLC.BTF.Process.CDS.ccllc_transactiontype>("ccllc_transactiontype_availableprocesses", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_transactiontype_availableprocesses");
				this.SetRelatedEntity<CCLLC.BTF.Process.CDS.ccllc_transactiontype>("ccllc_transactiontype_availableprocesses", null, value);
				this.OnPropertyChanged("ccllc_transactiontype_availableprocesses");
			}
		}
	}
}
