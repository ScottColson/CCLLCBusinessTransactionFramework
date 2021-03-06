namespace TestProxy
{

	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("ccllc_device")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.28")]
	public partial class ccllc_device : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public ccllc_device() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "ccllc_device";
		
		public const int EntityTypeCode = 10140;
		
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
		/// Defines the capability of the device. A given device can have multiple capabilities.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_devicecapability")]
		public object ccllc_DeviceCapability
		{
			get
			{
				return this.GetAttributeValue<object>("ccllc_devicecapability");
			}
			set
			{
				this.OnPropertyChanging("ccllc_DeviceCapability");
				this.SetAttributeValue("ccllc_devicecapability", value);
				this.OnPropertyChanged("ccllc_DeviceCapability");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_deviceid")]
		public System.Nullable<System.Guid> ccllc_deviceId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("ccllc_deviceid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_deviceId");
				this.SetAttributeValue("ccllc_deviceid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ccllc_deviceId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_deviceid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.ccllc_deviceId = value;
			}
		}
		
		/// <summary>
		/// The location where a device exists.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_locationid")]
		public Microsoft.Xrm.Sdk.EntityReference ccllc_LocationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ccllc_locationid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_LocationId");
				this.SetAttributeValue("ccllc_locationid", value);
				this.OnPropertyChanged("ccllc_LocationId");
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
		/// Status of the Device
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<TestProxy.ccllc_deviceState> statecode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((TestProxy.ccllc_deviceState)(System.Enum.ToObject(typeof(TestProxy.ccllc_deviceState), optionSet.Value)));
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
		/// Reason for the status of the Device
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public System.Nullable<TestProxy.ccllc_device_statuscode> statuscode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
				if ((optionSet != null))
				{
					return ((TestProxy.ccllc_device_statuscode)(System.Enum.ToObject(typeof(TestProxy.ccllc_device_statuscode), optionSet.Value)));
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
		/// N:1 business_unit_ccllc_device
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_device")]
		public TestProxy.BusinessUnit business_unit_ccllc_device
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.BusinessUnit>("business_unit_ccllc_device", null);
			}
		}
		
		/// <summary>
		/// N:1 ccllc_location_device
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_locationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_location_device")]
		public TestProxy.ccllc_location ccllc_location_device
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.ccllc_location>("ccllc_location_device", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_location_device");
				this.SetRelatedEntity<TestProxy.ccllc_location>("ccllc_location_device", null, value);
				this.OnPropertyChanged("ccllc_location_device");
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_device_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_device_createdby")]
		public TestProxy.SystemUser lk_ccllc_device_createdby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_device_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_device_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_device_createdonbehalfby")]
		public TestProxy.SystemUser lk_ccllc_device_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_device_createdonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_device_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_device_modifiedby")]
		public TestProxy.SystemUser lk_ccllc_device_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_device_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ccllc_device_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_device_modifiedonbehalfby")]
		public TestProxy.SystemUser lk_ccllc_device_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_ccllc_device_modifiedonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 user_ccllc_device
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_device")]
		public TestProxy.SystemUser user_ccllc_device
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("user_ccllc_device", null);
			}
		}
	}
}
