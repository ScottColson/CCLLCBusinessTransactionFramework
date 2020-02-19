namespace TestProxy
{

	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("customeraddress")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class CustomerAddress : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public CustomerAddress() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "customeraddress";
		
		public const int EntityTypeCode = 1071;
		
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
		/// Shows the number of the address, to indicate whether the address is the primary, secondary, or other address for the customer.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addressnumber")]
		public System.Nullable<int> AddressNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("addressnumber");
			}
			set
			{
				this.OnPropertyChanging("AddressNumber");
				this.SetAttributeValue("addressnumber", value);
				this.OnPropertyChanged("AddressNumber");
			}
		}
		
		/// <summary>
		/// Select the address type, such as primary or billing.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addresstypecode")]
		public System.Nullable<TestProxy.customeraddress_addresstypecode> AddressTypeCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("addresstypecode");
				if ((optionSet != null))
				{
					return ((TestProxy.customeraddress_addresstypecode)(System.Enum.ToObject(typeof(TestProxy.customeraddress_addresstypecode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("AddressTypeCode");
				if ((value == null))
				{
					this.SetAttributeValue("addresstypecode", null);
				}
				else
				{
					this.SetAttributeValue("addresstypecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("AddressTypeCode");
			}
		}
		
		/// <summary>
		/// Type the city for the customer's address to help identify the location.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("city")]
		public string City
		{
			get
			{
				return this.GetAttributeValue<string>("city");
			}
			set
			{
				this.OnPropertyChanging("City");
				this.SetAttributeValue("city", value);
				this.OnPropertyChanged("City");
			}
		}
		
		/// <summary>
		/// Shows the complete address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("composite")]
		public string Composite
		{
			get
			{
				return this.GetAttributeValue<string>("composite");
			}
		}
		
		/// <summary>
		/// Type the country or region for the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("country")]
		public string Country
		{
			get
			{
				return this.GetAttributeValue<string>("country");
			}
			set
			{
				this.OnPropertyChanging("Country");
				this.SetAttributeValue("country", value);
				this.OnPropertyChanged("Country");
			}
		}
		
		/// <summary>
		/// Type the county for the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("county")]
		public string County
		{
			get
			{
				return this.GetAttributeValue<string>("county");
			}
			set
			{
				this.OnPropertyChanging("County");
				this.SetAttributeValue("county", value);
				this.OnPropertyChanged("County");
			}
		}
		
		/// <summary>
		/// Shows who created the record.
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
		/// Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
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
		/// Shows who created the record on behalf of another user.
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
		/// Unique identifier of the customer address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customeraddressid")]
		public System.Nullable<System.Guid> CustomerAddressId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("customeraddressid");
			}
			set
			{
				this.OnPropertyChanging("CustomerAddressId");
				this.SetAttributeValue("customeraddressid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("CustomerAddressId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customeraddressid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.CustomerAddressId = value;
			}
		}
		
		/// <summary>
		/// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
		
		/// <summary>
		/// Type the fax number associated with the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fax")]
		public string Fax
		{
			get
			{
				return this.GetAttributeValue<string>("fax");
			}
			set
			{
				this.OnPropertyChanging("Fax");
				this.SetAttributeValue("fax", value);
				this.OnPropertyChanged("Fax");
			}
		}
		
		/// <summary>
		/// Select the freight terms to make sure shipping charges are processed correctly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("freighttermscode")]
		public System.Nullable<TestProxy.customeraddress_freighttermscode> FreightTermsCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("freighttermscode");
				if ((optionSet != null))
				{
					return ((TestProxy.customeraddress_freighttermscode)(System.Enum.ToObject(typeof(TestProxy.customeraddress_freighttermscode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("FreightTermsCode");
				if ((value == null))
				{
					this.SetAttributeValue("freighttermscode", null);
				}
				else
				{
					this.SetAttributeValue("freighttermscode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("FreightTermsCode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the data import or data migration that created this record.
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
		/// Type the latitude value for the customer's address, for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("latitude")]
		public System.Nullable<double> Latitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("latitude");
			}
			set
			{
				this.OnPropertyChanging("Latitude");
				this.SetAttributeValue("latitude", value);
				this.OnPropertyChanged("Latitude");
			}
		}
		
		/// <summary>
		/// Type the first line of the customer's address to help identify the location.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("line1")]
		public string Line1
		{
			get
			{
				return this.GetAttributeValue<string>("line1");
			}
			set
			{
				this.OnPropertyChanging("Line1");
				this.SetAttributeValue("line1", value);
				this.OnPropertyChanged("Line1");
			}
		}
		
		/// <summary>
		/// Type the second line of the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("line2")]
		public string Line2
		{
			get
			{
				return this.GetAttributeValue<string>("line2");
			}
			set
			{
				this.OnPropertyChanging("Line2");
				this.SetAttributeValue("line2", value);
				this.OnPropertyChanged("Line2");
			}
		}
		
		/// <summary>
		/// Type the third line of the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("line3")]
		public string Line3
		{
			get
			{
				return this.GetAttributeValue<string>("line3");
			}
			set
			{
				this.OnPropertyChanging("Line3");
				this.SetAttributeValue("line3", value);
				this.OnPropertyChanged("Line3");
			}
		}
		
		/// <summary>
		/// Type the longitude value for the customer's address, for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("longitude")]
		public System.Nullable<double> Longitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("longitude");
			}
			set
			{
				this.OnPropertyChanging("Longitude");
				this.SetAttributeValue("longitude", value);
				this.OnPropertyChanged("Longitude");
			}
		}
		
		/// <summary>
		/// Shows who last updated the record.
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
		/// Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
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
		/// Shows who last updated the record on behalf of another user.
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
		/// Type a descriptive name for the customer's address, such as Corporate Headquarters.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Shows the type code of the customer record to indicate whether the address belongs to a customer account or contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objecttypecode")]
		public string ObjectTypeCode
		{
			get
			{
				return this.GetAttributeValue<string>("objecttypecode");
			}
			set
			{
				this.OnPropertyChanging("ObjectTypeCode");
				this.SetAttributeValue("objecttypecode", value);
				this.OnPropertyChanged("ObjectTypeCode");
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
		/// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
		}
		
		/// <summary>
		/// Shows the business unit that the record owner belongs to.
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
		/// Unique identifier of the user who owns the customer address.
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
		/// Choose the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentid");
			}
			set
			{
				this.OnPropertyChanging("ParentId");
				this.SetAttributeValue("parentid", value);
				this.OnPropertyChanged("ParentId");
			}
		}
		
		/// <summary>
		/// Type the ZIP Code or postal code for the address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postalcode")]
		public string PostalCode
		{
			get
			{
				return this.GetAttributeValue<string>("postalcode");
			}
			set
			{
				this.OnPropertyChanging("PostalCode");
				this.SetAttributeValue("postalcode", value);
				this.OnPropertyChanged("PostalCode");
			}
		}
		
		/// <summary>
		/// Type the post office box number of the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postofficebox")]
		public string PostOfficeBox
		{
			get
			{
				return this.GetAttributeValue<string>("postofficebox");
			}
			set
			{
				this.OnPropertyChanging("PostOfficeBox");
				this.SetAttributeValue("postofficebox", value);
				this.OnPropertyChanged("PostOfficeBox");
			}
		}
		
		/// <summary>
		/// Type the name of the primary contact person for the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primarycontactname")]
		public string PrimaryContactName
		{
			get
			{
				return this.GetAttributeValue<string>("primarycontactname");
			}
			set
			{
				this.OnPropertyChanging("PrimaryContactName");
				this.SetAttributeValue("primarycontactname", value);
				this.OnPropertyChanged("PrimaryContactName");
			}
		}
		
		/// <summary>
		/// Select a shipping method for deliveries sent to this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shippingmethodcode")]
		public System.Nullable<TestProxy.customeraddress_shippingmethodcode> ShippingMethodCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("shippingmethodcode");
				if ((optionSet != null))
				{
					return ((TestProxy.customeraddress_shippingmethodcode)(System.Enum.ToObject(typeof(TestProxy.customeraddress_shippingmethodcode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("ShippingMethodCode");
				if ((value == null))
				{
					this.SetAttributeValue("shippingmethodcode", null);
				}
				else
				{
					this.SetAttributeValue("shippingmethodcode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("ShippingMethodCode");
			}
		}
		
		/// <summary>
		/// Type the state or province of the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stateorprovince")]
		public string StateOrProvince
		{
			get
			{
				return this.GetAttributeValue<string>("stateorprovince");
			}
			set
			{
				this.OnPropertyChanging("StateOrProvince");
				this.SetAttributeValue("stateorprovince", value);
				this.OnPropertyChanged("StateOrProvince");
			}
		}
		
		/// <summary>
		/// Type the primary phone number for the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone1")]
		public string Telephone1
		{
			get
			{
				return this.GetAttributeValue<string>("telephone1");
			}
			set
			{
				this.OnPropertyChanging("Telephone1");
				this.SetAttributeValue("telephone1", value);
				this.OnPropertyChanged("Telephone1");
			}
		}
		
		/// <summary>
		/// Type a second phone number for the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone2")]
		public string Telephone2
		{
			get
			{
				return this.GetAttributeValue<string>("telephone2");
			}
			set
			{
				this.OnPropertyChanging("Telephone2");
				this.SetAttributeValue("telephone2", value);
				this.OnPropertyChanged("Telephone2");
			}
		}
		
		/// <summary>
		/// Type a third phone number for the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone3")]
		public string Telephone3
		{
			get
			{
				return this.GetAttributeValue<string>("telephone3");
			}
			set
			{
				this.OnPropertyChanging("Telephone3");
				this.SetAttributeValue("telephone3", value);
				this.OnPropertyChanged("Telephone3");
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
		/// Choose the local currency for the record to make sure budgets are reported in the correct currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			set
			{
				this.OnPropertyChanging("TransactionCurrencyId");
				this.SetAttributeValue("transactioncurrencyid", value);
				this.OnPropertyChanged("TransactionCurrencyId");
			}
		}
		
		/// <summary>
		/// Type the UPS zone of the customer's address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("upszone")]
		public string UPSZone
		{
			get
			{
				return this.GetAttributeValue<string>("upszone");
			}
			set
			{
				this.OnPropertyChanging("UPSZone");
				this.SetAttributeValue("upszone", value);
				this.OnPropertyChanged("UPSZone");
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
		/// Select the time zone for the address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcoffset")]
		public System.Nullable<int> UTCOffset
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcoffset");
			}
			set
			{
				this.OnPropertyChanging("UTCOffset");
				this.SetAttributeValue("utcoffset", value);
				this.OnPropertyChanged("UTCOffset");
			}
		}
		
		/// <summary>
		/// Version number of the customer address.
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
		/// N:1 Account_CustomerAddress
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_CustomerAddress")]
		public TestProxy.Account Account_CustomerAddress
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.Account>("Account_CustomerAddress", null);
			}
			set
			{
				this.OnPropertyChanging("Account_CustomerAddress");
				this.SetRelatedEntity<TestProxy.Account>("Account_CustomerAddress", null, value);
				this.OnPropertyChanged("Account_CustomerAddress");
			}
		}
		
		/// <summary>
		/// N:1 Contact_CustomerAddress
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_CustomerAddress")]
		public TestProxy.Contact Contact_CustomerAddress
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.Contact>("Contact_CustomerAddress", null);
			}
			set
			{
				this.OnPropertyChanging("Contact_CustomerAddress");
				this.SetRelatedEntity<TestProxy.Contact>("Contact_CustomerAddress", null, value);
				this.OnPropertyChanged("Contact_CustomerAddress");
			}
		}
		
		/// <summary>
		/// N:1 lk_customeraddress_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeraddress_createdonbehalfby")]
		public TestProxy.SystemUser lk_customeraddress_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_customeraddress_createdonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_customeraddress_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeraddress_modifiedonbehalfby")]
		public TestProxy.SystemUser lk_customeraddress_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_customeraddress_modifiedonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_customeraddressbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeraddressbase_createdby")]
		public TestProxy.SystemUser lk_customeraddressbase_createdby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_customeraddressbase_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_customeraddressbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeraddressbase_modifiedby")]
		public TestProxy.SystemUser lk_customeraddressbase_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_customeraddressbase_modifiedby", null);
			}
		}
	}
}
