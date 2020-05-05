namespace TestProxy
{

	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("businessunit")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.28")]
	public partial class BusinessUnit : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public BusinessUnit() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "businessunit";
		
		public const int EntityTypeCode = 10;
		
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
		/// Unique identifier for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addressid")]
		public System.Nullable<System.Guid> Address1_AddressId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("address1_addressid");
			}
			set
			{
				this.OnPropertyChanging("Address1_AddressId");
				this.SetAttributeValue("address1_addressid", value);
				this.OnPropertyChanged("Address1_AddressId");
			}
		}
		
		/// <summary>
		/// Type of address for address 1, such as billing, shipping, or primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addresstypecode")]
		public System.Nullable<TestProxy.businessunit_address1_addresstypecode> Address1_AddressTypeCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_addresstypecode");
				if ((optionSet != null))
				{
					return ((TestProxy.businessunit_address1_addresstypecode)(System.Enum.ToObject(typeof(TestProxy.businessunit_address1_addresstypecode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("Address1_AddressTypeCode");
				if ((value == null))
				{
					this.SetAttributeValue("address1_addresstypecode", null);
				}
				else
				{
					this.SetAttributeValue("address1_addresstypecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("Address1_AddressTypeCode");
			}
		}
		
		/// <summary>
		/// City name for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_city")]
		public string Address1_City
		{
			get
			{
				return this.GetAttributeValue<string>("address1_city");
			}
			set
			{
				this.OnPropertyChanging("Address1_City");
				this.SetAttributeValue("address1_city", value);
				this.OnPropertyChanged("Address1_City");
			}
		}
		
		/// <summary>
		/// Country/region name for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_country")]
		public string Address1_Country
		{
			get
			{
				return this.GetAttributeValue<string>("address1_country");
			}
			set
			{
				this.OnPropertyChanging("Address1_Country");
				this.SetAttributeValue("address1_country", value);
				this.OnPropertyChanged("Address1_Country");
			}
		}
		
		/// <summary>
		/// County name for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_county")]
		public string Address1_County
		{
			get
			{
				return this.GetAttributeValue<string>("address1_county");
			}
			set
			{
				this.OnPropertyChanging("Address1_County");
				this.SetAttributeValue("address1_county", value);
				this.OnPropertyChanged("Address1_County");
			}
		}
		
		/// <summary>
		/// Fax number for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_fax")]
		public string Address1_Fax
		{
			get
			{
				return this.GetAttributeValue<string>("address1_fax");
			}
			set
			{
				this.OnPropertyChanging("Address1_Fax");
				this.SetAttributeValue("address1_fax", value);
				this.OnPropertyChanged("Address1_Fax");
			}
		}
		
		/// <summary>
		/// Latitude for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_latitude")]
		public System.Nullable<double> Address1_Latitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address1_latitude");
			}
			set
			{
				this.OnPropertyChanging("Address1_Latitude");
				this.SetAttributeValue("address1_latitude", value);
				this.OnPropertyChanged("Address1_Latitude");
			}
		}
		
		/// <summary>
		/// First line for entering address 1 information.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line1")]
		public string Address1_Line1
		{
			get
			{
				return this.GetAttributeValue<string>("address1_line1");
			}
			set
			{
				this.OnPropertyChanging("Address1_Line1");
				this.SetAttributeValue("address1_line1", value);
				this.OnPropertyChanged("Address1_Line1");
			}
		}
		
		/// <summary>
		/// Second line for entering address 1 information.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line2")]
		public string Address1_Line2
		{
			get
			{
				return this.GetAttributeValue<string>("address1_line2");
			}
			set
			{
				this.OnPropertyChanging("Address1_Line2");
				this.SetAttributeValue("address1_line2", value);
				this.OnPropertyChanged("Address1_Line2");
			}
		}
		
		/// <summary>
		/// Third line for entering address 1 information.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line3")]
		public string Address1_Line3
		{
			get
			{
				return this.GetAttributeValue<string>("address1_line3");
			}
			set
			{
				this.OnPropertyChanging("Address1_Line3");
				this.SetAttributeValue("address1_line3", value);
				this.OnPropertyChanged("Address1_Line3");
			}
		}
		
		/// <summary>
		/// Longitude for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_longitude")]
		public System.Nullable<double> Address1_Longitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address1_longitude");
			}
			set
			{
				this.OnPropertyChanging("Address1_Longitude");
				this.SetAttributeValue("address1_longitude", value);
				this.OnPropertyChanged("Address1_Longitude");
			}
		}
		
		/// <summary>
		/// Name to enter for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_name")]
		public string Address1_Name
		{
			get
			{
				return this.GetAttributeValue<string>("address1_name");
			}
			set
			{
				this.OnPropertyChanging("Address1_Name");
				this.SetAttributeValue("address1_name", value);
				this.OnPropertyChanged("Address1_Name");
			}
		}
		
		/// <summary>
		/// ZIP Code or postal code for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postalcode")]
		public string Address1_PostalCode
		{
			get
			{
				return this.GetAttributeValue<string>("address1_postalcode");
			}
			set
			{
				this.OnPropertyChanging("Address1_PostalCode");
				this.SetAttributeValue("address1_postalcode", value);
				this.OnPropertyChanged("Address1_PostalCode");
			}
		}
		
		/// <summary>
		/// Post office box number for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postofficebox")]
		public string Address1_PostOfficeBox
		{
			get
			{
				return this.GetAttributeValue<string>("address1_postofficebox");
			}
			set
			{
				this.OnPropertyChanging("Address1_PostOfficeBox");
				this.SetAttributeValue("address1_postofficebox", value);
				this.OnPropertyChanged("Address1_PostOfficeBox");
			}
		}
		
		/// <summary>
		/// Method of shipment for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_shippingmethodcode")]
		public System.Nullable<TestProxy.businessunit_address1_shippingmethodcode> Address1_ShippingMethodCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_shippingmethodcode");
				if ((optionSet != null))
				{
					return ((TestProxy.businessunit_address1_shippingmethodcode)(System.Enum.ToObject(typeof(TestProxy.businessunit_address1_shippingmethodcode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("Address1_ShippingMethodCode");
				if ((value == null))
				{
					this.SetAttributeValue("address1_shippingmethodcode", null);
				}
				else
				{
					this.SetAttributeValue("address1_shippingmethodcode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("Address1_ShippingMethodCode");
			}
		}
		
		/// <summary>
		/// State or province for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_stateorprovince")]
		public string Address1_StateOrProvince
		{
			get
			{
				return this.GetAttributeValue<string>("address1_stateorprovince");
			}
			set
			{
				this.OnPropertyChanging("Address1_StateOrProvince");
				this.SetAttributeValue("address1_stateorprovince", value);
				this.OnPropertyChanged("Address1_StateOrProvince");
			}
		}
		
		/// <summary>
		/// First telephone number associated with address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone1")]
		public string Address1_Telephone1
		{
			get
			{
				return this.GetAttributeValue<string>("address1_telephone1");
			}
			set
			{
				this.OnPropertyChanging("Address1_Telephone1");
				this.SetAttributeValue("address1_telephone1", value);
				this.OnPropertyChanged("Address1_Telephone1");
			}
		}
		
		/// <summary>
		/// Second telephone number associated with address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone2")]
		public string Address1_Telephone2
		{
			get
			{
				return this.GetAttributeValue<string>("address1_telephone2");
			}
			set
			{
				this.OnPropertyChanging("Address1_Telephone2");
				this.SetAttributeValue("address1_telephone2", value);
				this.OnPropertyChanged("Address1_Telephone2");
			}
		}
		
		/// <summary>
		/// Third telephone number associated with address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone3")]
		public string Address1_Telephone3
		{
			get
			{
				return this.GetAttributeValue<string>("address1_telephone3");
			}
			set
			{
				this.OnPropertyChanging("Address1_Telephone3");
				this.SetAttributeValue("address1_telephone3", value);
				this.OnPropertyChanged("Address1_Telephone3");
			}
		}
		
		/// <summary>
		/// United Parcel Service (UPS) zone for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_upszone")]
		public string Address1_UPSZone
		{
			get
			{
				return this.GetAttributeValue<string>("address1_upszone");
			}
			set
			{
				this.OnPropertyChanging("Address1_UPSZone");
				this.SetAttributeValue("address1_upszone", value);
				this.OnPropertyChanged("Address1_UPSZone");
			}
		}
		
		/// <summary>
		/// UTC offset for address 1. This is the difference between local time and standard Coordinated Universal Time.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_utcoffset")]
		public System.Nullable<int> Address1_UTCOffset
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("address1_utcoffset");
			}
			set
			{
				this.OnPropertyChanging("Address1_UTCOffset");
				this.SetAttributeValue("address1_utcoffset", value);
				this.OnPropertyChanged("Address1_UTCOffset");
			}
		}
		
		/// <summary>
		/// Unique identifier for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addressid")]
		public System.Nullable<System.Guid> Address2_AddressId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("address2_addressid");
			}
			set
			{
				this.OnPropertyChanging("Address2_AddressId");
				this.SetAttributeValue("address2_addressid", value);
				this.OnPropertyChanged("Address2_AddressId");
			}
		}
		
		/// <summary>
		/// Type of address for address 2, such as billing, shipping, or primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addresstypecode")]
		public System.Nullable<TestProxy.businessunit_address2_addresstypecode> Address2_AddressTypeCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_addresstypecode");
				if ((optionSet != null))
				{
					return ((TestProxy.businessunit_address2_addresstypecode)(System.Enum.ToObject(typeof(TestProxy.businessunit_address2_addresstypecode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("Address2_AddressTypeCode");
				if ((value == null))
				{
					this.SetAttributeValue("address2_addresstypecode", null);
				}
				else
				{
					this.SetAttributeValue("address2_addresstypecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("Address2_AddressTypeCode");
			}
		}
		
		/// <summary>
		/// City name for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_city")]
		public string Address2_City
		{
			get
			{
				return this.GetAttributeValue<string>("address2_city");
			}
			set
			{
				this.OnPropertyChanging("Address2_City");
				this.SetAttributeValue("address2_city", value);
				this.OnPropertyChanged("Address2_City");
			}
		}
		
		/// <summary>
		/// Country/region name for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_country")]
		public string Address2_Country
		{
			get
			{
				return this.GetAttributeValue<string>("address2_country");
			}
			set
			{
				this.OnPropertyChanging("Address2_Country");
				this.SetAttributeValue("address2_country", value);
				this.OnPropertyChanged("Address2_Country");
			}
		}
		
		/// <summary>
		/// County name for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_county")]
		public string Address2_County
		{
			get
			{
				return this.GetAttributeValue<string>("address2_county");
			}
			set
			{
				this.OnPropertyChanging("Address2_County");
				this.SetAttributeValue("address2_county", value);
				this.OnPropertyChanged("Address2_County");
			}
		}
		
		/// <summary>
		/// Fax number for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_fax")]
		public string Address2_Fax
		{
			get
			{
				return this.GetAttributeValue<string>("address2_fax");
			}
			set
			{
				this.OnPropertyChanging("Address2_Fax");
				this.SetAttributeValue("address2_fax", value);
				this.OnPropertyChanged("Address2_Fax");
			}
		}
		
		/// <summary>
		/// Latitude for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_latitude")]
		public System.Nullable<double> Address2_Latitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address2_latitude");
			}
			set
			{
				this.OnPropertyChanging("Address2_Latitude");
				this.SetAttributeValue("address2_latitude", value);
				this.OnPropertyChanged("Address2_Latitude");
			}
		}
		
		/// <summary>
		/// First line for entering address 2 information.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line1")]
		public string Address2_Line1
		{
			get
			{
				return this.GetAttributeValue<string>("address2_line1");
			}
			set
			{
				this.OnPropertyChanging("Address2_Line1");
				this.SetAttributeValue("address2_line1", value);
				this.OnPropertyChanged("Address2_Line1");
			}
		}
		
		/// <summary>
		/// Second line for entering address 2 information.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line2")]
		public string Address2_Line2
		{
			get
			{
				return this.GetAttributeValue<string>("address2_line2");
			}
			set
			{
				this.OnPropertyChanging("Address2_Line2");
				this.SetAttributeValue("address2_line2", value);
				this.OnPropertyChanged("Address2_Line2");
			}
		}
		
		/// <summary>
		/// Third line for entering address 2 information.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line3")]
		public string Address2_Line3
		{
			get
			{
				return this.GetAttributeValue<string>("address2_line3");
			}
			set
			{
				this.OnPropertyChanging("Address2_Line3");
				this.SetAttributeValue("address2_line3", value);
				this.OnPropertyChanged("Address2_Line3");
			}
		}
		
		/// <summary>
		/// Longitude for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_longitude")]
		public System.Nullable<double> Address2_Longitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address2_longitude");
			}
			set
			{
				this.OnPropertyChanging("Address2_Longitude");
				this.SetAttributeValue("address2_longitude", value);
				this.OnPropertyChanged("Address2_Longitude");
			}
		}
		
		/// <summary>
		/// Name to enter for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_name")]
		public string Address2_Name
		{
			get
			{
				return this.GetAttributeValue<string>("address2_name");
			}
			set
			{
				this.OnPropertyChanging("Address2_Name");
				this.SetAttributeValue("address2_name", value);
				this.OnPropertyChanged("Address2_Name");
			}
		}
		
		/// <summary>
		/// ZIP Code or postal code for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postalcode")]
		public string Address2_PostalCode
		{
			get
			{
				return this.GetAttributeValue<string>("address2_postalcode");
			}
			set
			{
				this.OnPropertyChanging("Address2_PostalCode");
				this.SetAttributeValue("address2_postalcode", value);
				this.OnPropertyChanged("Address2_PostalCode");
			}
		}
		
		/// <summary>
		/// Post office box number for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postofficebox")]
		public string Address2_PostOfficeBox
		{
			get
			{
				return this.GetAttributeValue<string>("address2_postofficebox");
			}
			set
			{
				this.OnPropertyChanging("Address2_PostOfficeBox");
				this.SetAttributeValue("address2_postofficebox", value);
				this.OnPropertyChanged("Address2_PostOfficeBox");
			}
		}
		
		/// <summary>
		/// Method of shipment for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_shippingmethodcode")]
		public System.Nullable<TestProxy.businessunit_address2_shippingmethodcode> Address2_ShippingMethodCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_shippingmethodcode");
				if ((optionSet != null))
				{
					return ((TestProxy.businessunit_address2_shippingmethodcode)(System.Enum.ToObject(typeof(TestProxy.businessunit_address2_shippingmethodcode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("Address2_ShippingMethodCode");
				if ((value == null))
				{
					this.SetAttributeValue("address2_shippingmethodcode", null);
				}
				else
				{
					this.SetAttributeValue("address2_shippingmethodcode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("Address2_ShippingMethodCode");
			}
		}
		
		/// <summary>
		/// State or province for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_stateorprovince")]
		public string Address2_StateOrProvince
		{
			get
			{
				return this.GetAttributeValue<string>("address2_stateorprovince");
			}
			set
			{
				this.OnPropertyChanging("Address2_StateOrProvince");
				this.SetAttributeValue("address2_stateorprovince", value);
				this.OnPropertyChanged("Address2_StateOrProvince");
			}
		}
		
		/// <summary>
		/// First telephone number associated with address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone1")]
		public string Address2_Telephone1
		{
			get
			{
				return this.GetAttributeValue<string>("address2_telephone1");
			}
			set
			{
				this.OnPropertyChanging("Address2_Telephone1");
				this.SetAttributeValue("address2_telephone1", value);
				this.OnPropertyChanged("Address2_Telephone1");
			}
		}
		
		/// <summary>
		/// Second telephone number associated with address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone2")]
		public string Address2_Telephone2
		{
			get
			{
				return this.GetAttributeValue<string>("address2_telephone2");
			}
			set
			{
				this.OnPropertyChanging("Address2_Telephone2");
				this.SetAttributeValue("address2_telephone2", value);
				this.OnPropertyChanged("Address2_Telephone2");
			}
		}
		
		/// <summary>
		/// Third telephone number associated with address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone3")]
		public string Address2_Telephone3
		{
			get
			{
				return this.GetAttributeValue<string>("address2_telephone3");
			}
			set
			{
				this.OnPropertyChanging("Address2_Telephone3");
				this.SetAttributeValue("address2_telephone3", value);
				this.OnPropertyChanged("Address2_Telephone3");
			}
		}
		
		/// <summary>
		/// United Parcel Service (UPS) zone for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_upszone")]
		public string Address2_UPSZone
		{
			get
			{
				return this.GetAttributeValue<string>("address2_upszone");
			}
			set
			{
				this.OnPropertyChanging("Address2_UPSZone");
				this.SetAttributeValue("address2_upszone", value);
				this.OnPropertyChanged("Address2_UPSZone");
			}
		}
		
		/// <summary>
		/// UTC offset for address 2. This is the difference between local time and standard Coordinated Universal Time.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_utcoffset")]
		public System.Nullable<int> Address2_UTCOffset
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("address2_utcoffset");
			}
			set
			{
				this.OnPropertyChanging("Address2_UTCOffset");
				this.SetAttributeValue("address2_utcoffset", value);
				this.OnPropertyChanged("Address2_UTCOffset");
			}
		}
		
		/// <summary>
		/// Unique identifier of the business unit.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
		public System.Nullable<System.Guid> BusinessUnitId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("businessunitid");
			}
			set
			{
				this.OnPropertyChanging("BusinessUnitId");
				this.SetAttributeValue("businessunitid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("BusinessUnitId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.BusinessUnitId = value;
			}
		}
		
		/// <summary>
		/// Fiscal calendar associated with the business unit.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("calendarid")]
		public Microsoft.Xrm.Sdk.EntityReference CalendarId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("calendarid");
			}
			set
			{
				this.OnPropertyChanging("CalendarId");
				this.SetAttributeValue("calendarid", value);
				this.OnPropertyChanged("CalendarId");
			}
		}
		
		/// <summary>
		/// Name of the business unit cost center.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("costcenter")]
		public string CostCenter
		{
			get
			{
				return this.GetAttributeValue<string>("costcenter");
			}
			set
			{
				this.OnPropertyChanging("CostCenter");
				this.SetAttributeValue("costcenter", value);
				this.OnPropertyChanged("CostCenter");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the business unit.
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
		/// Date and time when the business unit was created.
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
		/// Unique identifier of the delegate user who created the businessunit.
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
		/// Credit limit for the business unit.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditlimit")]
		public System.Nullable<double> CreditLimit
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("creditlimit");
			}
			set
			{
				this.OnPropertyChanging("CreditLimit");
				this.SetAttributeValue("creditlimit", value);
				this.OnPropertyChanged("CreditLimit");
			}
		}
		
		/// <summary>
		/// Description of the business unit.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// Reason for disabling the business unit.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("disabledreason")]
		public string DisabledReason
		{
			get
			{
				return this.GetAttributeValue<string>("disabledreason");
			}
		}
		
		/// <summary>
		/// Name of the division to which the business unit belongs.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("divisionname")]
		public string DivisionName
		{
			get
			{
				return this.GetAttributeValue<string>("divisionname");
			}
			set
			{
				this.OnPropertyChanging("DivisionName");
				this.SetAttributeValue("divisionname", value);
				this.OnPropertyChanged("DivisionName");
			}
		}
		
		/// <summary>
		/// Email address for the business unit.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress")]
		public string EMailAddress
		{
			get
			{
				return this.GetAttributeValue<string>("emailaddress");
			}
			set
			{
				this.OnPropertyChanging("EMailAddress");
				this.SetAttributeValue("emailaddress", value);
				this.OnPropertyChanged("EMailAddress");
			}
		}
		
		/// <summary>
		/// Exchange rate for the currency associated with the businessunit with respect to the base currency.
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
		/// Alternative name under which the business unit can be filed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fileasname")]
		public string FileAsName
		{
			get
			{
				return this.GetAttributeValue<string>("fileasname");
			}
			set
			{
				this.OnPropertyChanging("FileAsName");
				this.SetAttributeValue("fileasname", value);
				this.OnPropertyChanged("FileAsName");
			}
		}
		
		/// <summary>
		/// FTP site URL for the business unit.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ftpsiteurl")]
		public string FtpSiteUrl
		{
			get
			{
				return this.GetAttributeValue<string>("ftpsiteurl");
			}
			set
			{
				this.OnPropertyChanging("FtpSiteUrl");
				this.SetAttributeValue("ftpsiteurl", value);
				this.OnPropertyChanged("FtpSiteUrl");
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
		/// Inheritance mask for the business unit.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("inheritancemask")]
		public System.Nullable<int> InheritanceMask
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("inheritancemask");
			}
			set
			{
				this.OnPropertyChanging("InheritanceMask");
				this.SetAttributeValue("inheritancemask", value);
				this.OnPropertyChanged("InheritanceMask");
			}
		}
		
		/// <summary>
		/// Information about whether the business unit is enabled or disabled.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdisabled")]
		public System.Nullable<bool> IsDisabled
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isdisabled");
			}
			set
			{
				this.OnPropertyChanging("IsDisabled");
				this.SetAttributeValue("isdisabled", value);
				this.OnPropertyChanged("IsDisabled");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the business unit.
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
		/// Date and time when the business unit was last modified.
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
		/// Unique identifier of the delegate user who last modified the businessunit.
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
		/// Name of the business unit.
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
		/// Unique identifier of the organization associated with the business unit.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
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
		/// Unique identifier for the parent business unit.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentbusinessunitid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentBusinessUnitId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentbusinessunitid");
			}
			set
			{
				this.OnPropertyChanging("ParentBusinessUnitId");
				this.SetAttributeValue("parentbusinessunitid", value);
				this.OnPropertyChanged("ParentBusinessUnitId");
			}
		}
		
		/// <summary>
		/// Picture or diagram of the business unit.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("picture")]
		public string Picture
		{
			get
			{
				return this.GetAttributeValue<string>("picture");
			}
			set
			{
				this.OnPropertyChanging("Picture");
				this.SetAttributeValue("picture", value);
				this.OnPropertyChanged("Picture");
			}
		}
		
		/// <summary>
		/// Stock exchange on which the business is listed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stockexchange")]
		public string StockExchange
		{
			get
			{
				return this.GetAttributeValue<string>("stockexchange");
			}
			set
			{
				this.OnPropertyChanging("StockExchange");
				this.SetAttributeValue("stockexchange", value);
				this.OnPropertyChanged("StockExchange");
			}
		}
		
		/// <summary>
		/// Stock exchange ticker symbol for the business unit.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("tickersymbol")]
		public string TickerSymbol
		{
			get
			{
				return this.GetAttributeValue<string>("tickersymbol");
			}
			set
			{
				this.OnPropertyChanging("TickerSymbol");
				this.SetAttributeValue("tickersymbol", value);
				this.OnPropertyChanged("TickerSymbol");
			}
		}
		
		/// <summary>
		/// Unique identifier of the currency associated with the businessunit.
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
		/// UTC offset for the business unit. This is the difference between local time and standard Coordinated Universal Time.
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
		/// Version number of the business unit.
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
		/// Website URL for the business unit.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("websiteurl")]
		public string WebSiteUrl
		{
			get
			{
				return this.GetAttributeValue<string>("websiteurl");
			}
			set
			{
				this.OnPropertyChanging("WebSiteUrl");
				this.SetAttributeValue("websiteurl", value);
				this.OnPropertyChanged("WebSiteUrl");
			}
		}
		
		/// <summary>
		/// Information about whether workflow or sales process rules have been suspended.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowsuspended")]
		public System.Nullable<bool> WorkflowSuspended
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("workflowsuspended");
			}
			set
			{
				this.OnPropertyChanging("WorkflowSuspended");
				this.SetAttributeValue("workflowsuspended", value);
				this.OnPropertyChanged("WorkflowSuspended");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_accounts
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_accounts")]
		public System.Collections.Generic.IEnumerable<TestProxy.Account> business_unit_accounts
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.Account>("business_unit_accounts", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_accounts");
				this.SetRelatedEntities<TestProxy.Account>("business_unit_accounts", null, value);
				this.OnPropertyChanged("business_unit_accounts");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_ccllc_agent
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_agent")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_agent> business_unit_ccllc_agent
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_agent>("business_unit_ccllc_agent", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_ccllc_agent");
				this.SetRelatedEntities<TestProxy.ccllc_agent>("business_unit_ccllc_agent", null, value);
				this.OnPropertyChanged("business_unit_ccllc_agent");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_ccllc_agentauthorizedcustomer
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_agentauthorizedcustomer")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_agentauthorizedcustomer> business_unit_ccllc_agentauthorizedcustomer
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_agentauthorizedcustomer>("business_unit_ccllc_agentauthorizedcustomer", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_ccllc_agentauthorizedcustomer");
				this.SetRelatedEntities<TestProxy.ccllc_agentauthorizedcustomer>("business_unit_ccllc_agentauthorizedcustomer", null, value);
				this.OnPropertyChanged("business_unit_ccllc_agentauthorizedcustomer");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_ccllc_agentprohibitedcustomer
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_agentprohibitedcustomer")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_agentprohibitedcustomer> business_unit_ccllc_agentprohibitedcustomer
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_agentprohibitedcustomer>("business_unit_ccllc_agentprohibitedcustomer", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_ccllc_agentprohibitedcustomer");
				this.SetRelatedEntities<TestProxy.ccllc_agentprohibitedcustomer>("business_unit_ccllc_agentprohibitedcustomer", null, value);
				this.OnPropertyChanged("business_unit_ccllc_agentprohibitedcustomer");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_ccllc_agentrole
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_agentrole")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_agentrole> business_unit_ccllc_agentrole
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_agentrole>("business_unit_ccllc_agentrole", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_ccllc_agentrole");
				this.SetRelatedEntities<TestProxy.ccllc_agentrole>("business_unit_ccllc_agentrole", null, value);
				this.OnPropertyChanged("business_unit_ccllc_agentrole");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_ccllc_alternatebranch
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_alternatebranch")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_alternatebranch> business_unit_ccllc_alternatebranch
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_alternatebranch>("business_unit_ccllc_alternatebranch", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_ccllc_alternatebranch");
				this.SetRelatedEntities<TestProxy.ccllc_alternatebranch>("business_unit_ccllc_alternatebranch", null, value);
				this.OnPropertyChanged("business_unit_ccllc_alternatebranch");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_ccllc_channel
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_channel")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_channel> business_unit_ccllc_channel
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_channel>("business_unit_ccllc_channel", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_ccllc_channel");
				this.SetRelatedEntities<TestProxy.ccllc_channel>("business_unit_ccllc_channel", null, value);
				this.OnPropertyChanged("business_unit_ccllc_channel");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_ccllc_device
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_device")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_device> business_unit_ccllc_device
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_device>("business_unit_ccllc_device", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_ccllc_device");
				this.SetRelatedEntities<TestProxy.ccllc_device>("business_unit_ccllc_device", null, value);
				this.OnPropertyChanged("business_unit_ccllc_device");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_ccllc_evaluatortype
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_evaluatortype")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_evaluatortype> business_unit_ccllc_evaluatortype
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_evaluatortype>("business_unit_ccllc_evaluatortype", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_ccllc_evaluatortype");
				this.SetRelatedEntities<TestProxy.ccllc_evaluatortype>("business_unit_ccllc_evaluatortype", null, value);
				this.OnPropertyChanged("business_unit_ccllc_evaluatortype");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_ccllc_fee
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_fee")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_fee> business_unit_ccllc_fee
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_fee>("business_unit_ccllc_fee", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_ccllc_fee");
				this.SetRelatedEntities<TestProxy.ccllc_fee>("business_unit_ccllc_fee", null, value);
				this.OnPropertyChanged("business_unit_ccllc_fee");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_ccllc_location
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_location")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_location> business_unit_ccllc_location
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_location>("business_unit_ccllc_location", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_ccllc_location");
				this.SetRelatedEntities<TestProxy.ccllc_location>("business_unit_ccllc_location", null, value);
				this.OnPropertyChanged("business_unit_ccllc_location");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_ccllc_partner
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_partner")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_partner> business_unit_ccllc_partner
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_partner>("business_unit_ccllc_partner", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_ccllc_partner");
				this.SetRelatedEntities<TestProxy.ccllc_partner>("business_unit_ccllc_partner", null, value);
				this.OnPropertyChanged("business_unit_ccllc_partner");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_ccllc_partnerworker
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_partnerworker")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_partnerworker> business_unit_ccllc_partnerworker
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_partnerworker>("business_unit_ccllc_partnerworker", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_ccllc_partnerworker");
				this.SetRelatedEntities<TestProxy.ccllc_partnerworker>("business_unit_ccllc_partnerworker", null, value);
				this.OnPropertyChanged("business_unit_ccllc_partnerworker");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_ccllc_processauthorizedchannel
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_processauthorizedchannel")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processauthorizedchannel> business_unit_ccllc_processauthorizedchannel
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processauthorizedchannel>("business_unit_ccllc_processauthorizedchannel", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_ccllc_processauthorizedchannel");
				this.SetRelatedEntities<TestProxy.ccllc_processauthorizedchannel>("business_unit_ccllc_processauthorizedchannel", null, value);
				this.OnPropertyChanged("business_unit_ccllc_processauthorizedchannel");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_ccllc_processstep
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_processstep")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processstep> business_unit_ccllc_processstep
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processstep>("business_unit_ccllc_processstep", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_ccllc_processstep");
				this.SetRelatedEntities<TestProxy.ccllc_processstep>("business_unit_ccllc_processstep", null, value);
				this.OnPropertyChanged("business_unit_ccllc_processstep");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_ccllc_processstepauthorizedchannel
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_processstepauthorizedchannel")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processstepauthorizedchannel> business_unit_ccllc_processstepauthorizedchannel
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processstepauthorizedchannel>("business_unit_ccllc_processstepauthorizedchannel", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_ccllc_processstepauthorizedchannel");
				this.SetRelatedEntities<TestProxy.ccllc_processstepauthorizedchannel>("business_unit_ccllc_processstepauthorizedchannel", null, value);
				this.OnPropertyChanged("business_unit_ccllc_processstepauthorizedchannel");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_ccllc_processsteprequirement
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_processsteprequirement")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processsteprequirement> business_unit_ccllc_processsteprequirement
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processsteprequirement>("business_unit_ccllc_processsteprequirement", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_ccllc_processsteprequirement");
				this.SetRelatedEntities<TestProxy.ccllc_processsteprequirement>("business_unit_ccllc_processsteprequirement", null, value);
				this.OnPropertyChanged("business_unit_ccllc_processsteprequirement");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_ccllc_processsteptype
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_processsteptype")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processsteptype> business_unit_ccllc_processsteptype
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processsteptype>("business_unit_ccllc_processsteptype", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_ccllc_processsteptype");
				this.SetRelatedEntities<TestProxy.ccllc_processsteptype>("business_unit_ccllc_processsteptype", null, value);
				this.OnPropertyChanged("business_unit_ccllc_processsteptype");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_ccllc_requirement
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_requirement")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_Requirement> business_unit_ccllc_requirement
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_Requirement>("business_unit_ccllc_requirement", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_ccllc_requirement");
				this.SetRelatedEntities<TestProxy.ccllc_Requirement>("business_unit_ccllc_requirement", null, value);
				this.OnPropertyChanged("business_unit_ccllc_requirement");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_ccllc_requirementwaiverrole
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_requirementwaiverrole")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_RequirementWaiverRole> business_unit_ccllc_requirementwaiverrole
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_RequirementWaiverRole>("business_unit_ccllc_requirementwaiverrole", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_ccllc_requirementwaiverrole");
				this.SetRelatedEntities<TestProxy.ccllc_RequirementWaiverRole>("business_unit_ccllc_requirementwaiverrole", null, value);
				this.OnPropertyChanged("business_unit_ccllc_requirementwaiverrole");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_ccllc_role
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_role")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_role> business_unit_ccllc_role
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_role>("business_unit_ccllc_role", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_ccllc_role");
				this.SetRelatedEntities<TestProxy.ccllc_role>("business_unit_ccllc_role", null, value);
				this.OnPropertyChanged("business_unit_ccllc_role");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_ccllc_stephistory
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_stephistory")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_stephistory> business_unit_ccllc_stephistory
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_stephistory>("business_unit_ccllc_stephistory", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_ccllc_stephistory");
				this.SetRelatedEntities<TestProxy.ccllc_stephistory>("business_unit_ccllc_stephistory", null, value);
				this.OnPropertyChanged("business_unit_ccllc_stephistory");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_ccllc_transaction
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_transaction")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transaction> business_unit_ccllc_transaction
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transaction>("business_unit_ccllc_transaction", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_ccllc_transaction");
				this.SetRelatedEntities<TestProxy.ccllc_transaction>("business_unit_ccllc_transaction", null, value);
				this.OnPropertyChanged("business_unit_ccllc_transaction");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_ccllc_transactionfee
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_transactionfee")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactionfee> business_unit_ccllc_transactionfee
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactionfee>("business_unit_ccllc_transactionfee", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_ccllc_transactionfee");
				this.SetRelatedEntities<TestProxy.ccllc_transactionfee>("business_unit_ccllc_transactionfee", null, value);
				this.OnPropertyChanged("business_unit_ccllc_transactionfee");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_ccllc_transactiongroup
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_transactiongroup")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiongroup> business_unit_ccllc_transactiongroup
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiongroup>("business_unit_ccllc_transactiongroup", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_ccllc_transactiongroup");
				this.SetRelatedEntities<TestProxy.ccllc_transactiongroup>("business_unit_ccllc_transactiongroup", null, value);
				this.OnPropertyChanged("business_unit_ccllc_transactiongroup");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_ccllc_transactioninitialfee
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_transactioninitialfee")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactioninitialfee> business_unit_ccllc_transactioninitialfee
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactioninitialfee>("business_unit_ccllc_transactioninitialfee", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_ccllc_transactioninitialfee");
				this.SetRelatedEntities<TestProxy.ccllc_transactioninitialfee>("business_unit_ccllc_transactioninitialfee", null, value);
				this.OnPropertyChanged("business_unit_ccllc_transactioninitialfee");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_ccllc_transactionprocess
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_transactionprocess")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactionprocess> business_unit_ccllc_transactionprocess
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactionprocess>("business_unit_ccllc_transactionprocess", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_ccllc_transactionprocess");
				this.SetRelatedEntities<TestProxy.ccllc_transactionprocess>("business_unit_ccllc_transactionprocess", null, value);
				this.OnPropertyChanged("business_unit_ccllc_transactionprocess");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_ccllc_transactiontype
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_transactiontype")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiontype> business_unit_ccllc_transactiontype
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiontype>("business_unit_ccllc_transactiontype", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_ccllc_transactiontype");
				this.SetRelatedEntities<TestProxy.ccllc_transactiontype>("business_unit_ccllc_transactiontype", null, value);
				this.OnPropertyChanged("business_unit_ccllc_transactiontype");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_ccllc_transactiontypeauthorizedchannel
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_transactiontypeauthorizedchannel")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiontypeauthorizedchannel> business_unit_ccllc_transactiontypeauthorizedchannel
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiontypeauthorizedchannel>("business_unit_ccllc_transactiontypeauthorizedchannel", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_ccllc_transactiontypeauthorizedchannel");
				this.SetRelatedEntities<TestProxy.ccllc_transactiontypeauthorizedchannel>("business_unit_ccllc_transactiontypeauthorizedchannel", null, value);
				this.OnPropertyChanged("business_unit_ccllc_transactiontypeauthorizedchannel");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_ccllc_transactiontypeauthorizedrole
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_transactiontypeauthorizedrole")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiontypeauthorizedrole> business_unit_ccllc_transactiontypeauthorizedrole
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiontypeauthorizedrole>("business_unit_ccllc_transactiontypeauthorizedrole", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_ccllc_transactiontypeauthorizedrole");
				this.SetRelatedEntities<TestProxy.ccllc_transactiontypeauthorizedrole>("business_unit_ccllc_transactiontypeauthorizedrole", null, value);
				this.OnPropertyChanged("business_unit_ccllc_transactiontypeauthorizedrole");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_ccllc_transactiontypecontext
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_transactiontypecontext")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiontypecontext> business_unit_ccllc_transactiontypecontext
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiontypecontext>("business_unit_ccllc_transactiontypecontext", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_ccllc_transactiontypecontext");
				this.SetRelatedEntities<TestProxy.ccllc_transactiontypecontext>("business_unit_ccllc_transactiontypecontext", null, value);
				this.OnPropertyChanged("business_unit_ccllc_transactiontypecontext");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_ccllc_worksession
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ccllc_worksession")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_worksession> business_unit_ccllc_worksession
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_worksession>("business_unit_ccllc_worksession", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_ccllc_worksession");
				this.SetRelatedEntities<TestProxy.ccllc_worksession>("business_unit_ccllc_worksession", null, value);
				this.OnPropertyChanged("business_unit_ccllc_worksession");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_contacts
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_contacts")]
		public System.Collections.Generic.IEnumerable<TestProxy.Contact> business_unit_contacts
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.Contact>("business_unit_contacts", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_contacts");
				this.SetRelatedEntities<TestProxy.Contact>("business_unit_contacts", null, value);
				this.OnPropertyChanged("business_unit_contacts");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_parent_business_unit
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_parent_business_unit", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<TestProxy.BusinessUnit> Referencedbusiness_unit_parent_business_unit
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.BusinessUnit>("business_unit_parent_business_unit", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedbusiness_unit_parent_business_unit");
				this.SetRelatedEntities<TestProxy.BusinessUnit>("business_unit_parent_business_unit", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedbusiness_unit_parent_business_unit");
			}
		}
		
		/// <summary>
		/// 1:N business_unit_system_users
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_system_users")]
		public System.Collections.Generic.IEnumerable<TestProxy.SystemUser> business_unit_system_users
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.SystemUser>("business_unit_system_users", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_system_users");
				this.SetRelatedEntities<TestProxy.SystemUser>("business_unit_system_users", null, value);
				this.OnPropertyChanged("business_unit_system_users");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_parent_business_unit
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentbusinessunitid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_parent_business_unit", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public TestProxy.BusinessUnit Referencingbusiness_unit_parent_business_unit
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.BusinessUnit>("business_unit_parent_business_unit", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			set
			{
				this.OnPropertyChanging("Referencingbusiness_unit_parent_business_unit");
				this.SetRelatedEntity<TestProxy.BusinessUnit>("business_unit_parent_business_unit", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
				this.OnPropertyChanged("Referencingbusiness_unit_parent_business_unit");
			}
		}
		
		/// <summary>
		/// N:1 lk_businessunit_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunit_createdonbehalfby")]
		public TestProxy.SystemUser lk_businessunit_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_businessunit_createdonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_businessunit_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunit_modifiedonbehalfby")]
		public TestProxy.SystemUser lk_businessunit_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_businessunit_modifiedonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_businessunitbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunitbase_createdby")]
		public TestProxy.SystemUser lk_businessunitbase_createdby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_businessunitbase_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_businessunitbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunitbase_modifiedby")]
		public TestProxy.SystemUser lk_businessunitbase_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_businessunitbase_modifiedby", null);
			}
		}
	}
}
