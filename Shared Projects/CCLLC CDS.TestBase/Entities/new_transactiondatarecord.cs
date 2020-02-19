namespace TestProxy
{

	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("new_transactiondatarecord")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class new_transactiondatarecord : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public new_transactiondatarecord() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "new_transactiondatarecord";
		
		public const int EntityTypeCode = 10111;
		
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
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_customerid")]
		public Microsoft.Xrm.Sdk.EntityReference new_CustomerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_customerid");
			}
			set
			{
				this.OnPropertyChanging("new_CustomerId");
				this.SetAttributeValue("new_customerid", value);
				this.OnPropertyChanged("new_CustomerId");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_datafield1")]
		public string new_DataField1
		{
			get
			{
				return this.GetAttributeValue<string>("new_datafield1");
			}
			set
			{
				this.OnPropertyChanging("new_DataField1");
				this.SetAttributeValue("new_datafield1", value);
				this.OnPropertyChanged("new_DataField1");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_datafield2")]
		public string new_DataField2
		{
			get
			{
				return this.GetAttributeValue<string>("new_datafield2");
			}
			set
			{
				this.OnPropertyChanging("new_DataField2");
				this.SetAttributeValue("new_datafield2", value);
				this.OnPropertyChanged("new_DataField2");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_datafield3")]
		public string new_DataField3
		{
			get
			{
				return this.GetAttributeValue<string>("new_datafield3");
			}
			set
			{
				this.OnPropertyChanging("new_DataField3");
				this.SetAttributeValue("new_datafield3", value);
				this.OnPropertyChanged("new_DataField3");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_datafield4")]
		public string new_DataField4
		{
			get
			{
				return this.GetAttributeValue<string>("new_datafield4");
			}
			set
			{
				this.OnPropertyChanging("new_DataField4");
				this.SetAttributeValue("new_datafield4", value);
				this.OnPropertyChanged("new_DataField4");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_datafield5")]
		public string new_DataField5
		{
			get
			{
				return this.GetAttributeValue<string>("new_datafield5");
			}
			set
			{
				this.OnPropertyChanging("new_DataField5");
				this.SetAttributeValue("new_datafield5", value);
				this.OnPropertyChanged("new_DataField5");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_datafield6")]
		public string new_DataField6
		{
			get
			{
				return this.GetAttributeValue<string>("new_datafield6");
			}
			set
			{
				this.OnPropertyChanging("new_DataField6");
				this.SetAttributeValue("new_datafield6", value);
				this.OnPropertyChanged("new_DataField6");
			}
		}
		
		/// <summary>
		/// The name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_name")]
		public string new_name
		{
			get
			{
				return this.GetAttributeValue<string>("new_name");
			}
			set
			{
				this.OnPropertyChanging("new_name");
				this.SetAttributeValue("new_name", value);
				this.OnPropertyChanged("new_name");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_transactiondatarecordid")]
		public System.Nullable<System.Guid> new_transactiondatarecordId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("new_transactiondatarecordid");
			}
			set
			{
				this.OnPropertyChanging("new_transactiondatarecordId");
				this.SetAttributeValue("new_transactiondatarecordid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("new_transactiondatarecordId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_transactiondatarecordid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.new_transactiondatarecordId = value;
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_transactionid")]
		public Microsoft.Xrm.Sdk.EntityReference new_TransactionId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("new_transactionid");
			}
			set
			{
				this.OnPropertyChanging("new_TransactionId");
				this.SetAttributeValue("new_transactionid", value);
				this.OnPropertyChanged("new_TransactionId");
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
		/// Status of the Transaction Data Record
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<TestProxy.new_transactiondatarecordState> statecode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((TestProxy.new_transactiondatarecordState)(System.Enum.ToObject(typeof(TestProxy.new_transactiondatarecordState), optionSet.Value)));
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
		/// Reason for the status of the Transaction Data Record
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public System.Nullable<TestProxy.new_transactiondatarecord_statuscode> statuscode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
				if ((optionSet != null))
				{
					return ((TestProxy.new_transactiondatarecord_statuscode)(System.Enum.ToObject(typeof(TestProxy.new_transactiondatarecord_statuscode), optionSet.Value)));
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
		/// N:1 business_unit_new_transactiondatarecord
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_new_transactiondatarecord")]
		public TestProxy.BusinessUnit business_unit_new_transactiondatarecord
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.BusinessUnit>("business_unit_new_transactiondatarecord", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_new_transactiondatarecord_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_new_transactiondatarecord_createdby")]
		public TestProxy.SystemUser lk_new_transactiondatarecord_createdby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_new_transactiondatarecord_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_new_transactiondatarecord_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_new_transactiondatarecord_createdonbehalfby")]
		public TestProxy.SystemUser lk_new_transactiondatarecord_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_new_transactiondatarecord_createdonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_new_transactiondatarecord_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_new_transactiondatarecord_modifiedby")]
		public TestProxy.SystemUser lk_new_transactiondatarecord_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_new_transactiondatarecord_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_new_transactiondatarecord_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_new_transactiondatarecord_modifiedonbehalfby")]
		public TestProxy.SystemUser lk_new_transactiondatarecord_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_new_transactiondatarecord_modifiedonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 new_account_new_transactiondatarecord_Customer
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_customerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_account_new_transactiondatarecord_Customer")]
		public TestProxy.Account new_account_new_transactiondatarecord_Customer
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.Account>("new_account_new_transactiondatarecord_Customer", null);
			}
			set
			{
				this.OnPropertyChanging("new_account_new_transactiondatarecord_Customer");
				this.SetRelatedEntity<TestProxy.Account>("new_account_new_transactiondatarecord_Customer", null, value);
				this.OnPropertyChanged("new_account_new_transactiondatarecord_Customer");
			}
		}
		
		/// <summary>
		/// N:1 new_contact_new_transactiondatarecord_Customer
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_customerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_contact_new_transactiondatarecord_Customer")]
		public TestProxy.Contact new_contact_new_transactiondatarecord_Customer
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.Contact>("new_contact_new_transactiondatarecord_Customer", null);
			}
			set
			{
				this.OnPropertyChanging("new_contact_new_transactiondatarecord_Customer");
				this.SetRelatedEntity<TestProxy.Contact>("new_contact_new_transactiondatarecord_Customer", null, value);
				this.OnPropertyChanged("new_contact_new_transactiondatarecord_Customer");
			}
		}
		
		/// <summary>
		/// N:1 new_ccllc_transaction_new_transactiondatarecord_Transaction
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_transactionid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_ccllc_transaction_new_transactiondatarecord_Transaction")]
		public TestProxy.ccllc_transaction new_ccllc_transaction_new_transactiondatarecord_Transaction
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.ccllc_transaction>("new_ccllc_transaction_new_transactiondatarecord_Transaction", null);
			}
			set
			{
				this.OnPropertyChanging("new_ccllc_transaction_new_transactiondatarecord_Transaction");
				this.SetRelatedEntity<TestProxy.ccllc_transaction>("new_ccllc_transaction_new_transactiondatarecord_Transaction", null, value);
				this.OnPropertyChanged("new_ccllc_transaction_new_transactiondatarecord_Transaction");
			}
		}
		
		/// <summary>
		/// N:1 user_new_transactiondatarecord
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_new_transactiondatarecord")]
		public TestProxy.SystemUser user_new_transactiondatarecord
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("user_new_transactiondatarecord", null);
			}
		}
	}
}
