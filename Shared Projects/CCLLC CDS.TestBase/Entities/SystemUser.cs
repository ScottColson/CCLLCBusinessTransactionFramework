namespace TestProxy
{

	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("systemuser")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class SystemUser : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public SystemUser() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "systemuser";
		
		public const int EntityTypeCode = 8;
		
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
		/// Type of user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accessmode")]
		public System.Nullable<TestProxy.systemuser_accessmode> AccessMode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("accessmode");
				if ((optionSet != null))
				{
					return ((TestProxy.systemuser_accessmode)(System.Enum.ToObject(typeof(TestProxy.systemuser_accessmode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("AccessMode");
				if ((value == null))
				{
					this.SetAttributeValue("accessmode", null);
				}
				else
				{
					this.SetAttributeValue("accessmode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("AccessMode");
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
		public System.Nullable<TestProxy.systemuser_address1_addresstypecode> Address1_AddressTypeCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_addresstypecode");
				if ((optionSet != null))
				{
					return ((TestProxy.systemuser_address1_addresstypecode)(System.Enum.ToObject(typeof(TestProxy.systemuser_address1_addresstypecode), optionSet.Value)));
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
		/// Shows the complete primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_composite")]
		public string Address1_Composite
		{
			get
			{
				return this.GetAttributeValue<string>("address1_composite");
			}
		}
		
		/// <summary>
		/// Country/region name in address 1.
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
		public System.Nullable<TestProxy.systemuser_address1_shippingmethodcode> Address1_ShippingMethodCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_shippingmethodcode");
				if ((optionSet != null))
				{
					return ((TestProxy.systemuser_address1_shippingmethodcode)(System.Enum.ToObject(typeof(TestProxy.systemuser_address1_shippingmethodcode), optionSet.Value)));
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
		public System.Nullable<TestProxy.systemuser_address2_addresstypecode> Address2_AddressTypeCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_addresstypecode");
				if ((optionSet != null))
				{
					return ((TestProxy.systemuser_address2_addresstypecode)(System.Enum.ToObject(typeof(TestProxy.systemuser_address2_addresstypecode), optionSet.Value)));
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
		/// Shows the complete secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_composite")]
		public string Address2_Composite
		{
			get
			{
				return this.GetAttributeValue<string>("address2_composite");
			}
		}
		
		/// <summary>
		/// Country/region name in address 2.
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
		public System.Nullable<TestProxy.systemuser_address2_shippingmethodcode> Address2_ShippingMethodCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_shippingmethodcode");
				if ((optionSet != null))
				{
					return ((TestProxy.systemuser_address2_shippingmethodcode)(System.Enum.ToObject(typeof(TestProxy.systemuser_address2_shippingmethodcode), optionSet.Value)));
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
		/// The identifier for the application. This is used to access data in another application.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("applicationid")]
		public System.Nullable<System.Guid> ApplicationId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("applicationid");
			}
			set
			{
				this.OnPropertyChanging("ApplicationId");
				this.SetAttributeValue("applicationid", value);
				this.OnPropertyChanged("ApplicationId");
			}
		}
		
		/// <summary>
		/// The URI used as a unique logical identifier for the external app. This can be used to validate the application.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("applicationiduri")]
		public string ApplicationIdUri
		{
			get
			{
				return this.GetAttributeValue<string>("applicationiduri");
			}
		}
		
		/// <summary>
		/// This is the application directory object Id.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("azureactivedirectoryobjectid")]
		public System.Nullable<System.Guid> AzureActiveDirectoryObjectId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("azureactivedirectoryobjectid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the business unit with which the user is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
		public Microsoft.Xrm.Sdk.EntityReference BusinessUnitId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("businessunitid");
			}
			set
			{
				this.OnPropertyChanging("BusinessUnitId");
				this.SetAttributeValue("businessunitid", value);
				this.OnPropertyChanged("BusinessUnitId");
			}
		}
		
		/// <summary>
		/// Fiscal calendar associated with the user.
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
		/// License type of user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("caltype")]
		public System.Nullable<TestProxy.systemuser_caltype> CALType
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("caltype");
				if ((optionSet != null))
				{
					return ((TestProxy.systemuser_caltype)(System.Enum.ToObject(typeof(TestProxy.systemuser_caltype), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("CALType");
				if ((value == null))
				{
					this.SetAttributeValue("caltype", null);
				}
				else
				{
					this.SetAttributeValue("caltype", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("CALType");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the user.
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
		/// Date and time when the user was created.
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
		/// Unique identifier of the delegate user who created the systemuser.
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
		/// Indicates if default outlook filters have been populated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultfilterspopulated")]
		public System.Nullable<bool> DefaultFiltersPopulated
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("defaultfilterspopulated");
			}
		}
		
		/// <summary>
		/// Select the mailbox associated with this user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultmailbox")]
		public Microsoft.Xrm.Sdk.EntityReference DefaultMailbox
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("defaultmailbox");
			}
		}
		
		/// <summary>
		/// Type a default folder name for the user's OneDrive For Business location.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultodbfoldername")]
		public string DefaultOdbFolderName
		{
			get
			{
				return this.GetAttributeValue<string>("defaultodbfoldername");
			}
		}
		
		/// <summary>
		/// Reason for disabling the user.
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
		/// Whether to display the user in service views.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("displayinserviceviews")]
		public System.Nullable<bool> DisplayInServiceViews
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("displayinserviceviews");
			}
			set
			{
				this.OnPropertyChanging("DisplayInServiceViews");
				this.SetAttributeValue("displayinserviceviews", value);
				this.OnPropertyChanged("DisplayInServiceViews");
			}
		}
		
		/// <summary>
		/// Active Directory domain of which the user is a member.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("domainname")]
		public string DomainName
		{
			get
			{
				return this.GetAttributeValue<string>("domainname");
			}
			set
			{
				this.OnPropertyChanging("DomainName");
				this.SetAttributeValue("domainname", value);
				this.OnPropertyChanged("DomainName");
			}
		}
		
		/// <summary>
		/// Shows the status of the primary email address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailrouteraccessapproval")]
		public System.Nullable<TestProxy.systemuser_emailrouteraccessapproval> EmailRouterAccessApproval
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("emailrouteraccessapproval");
				if ((optionSet != null))
				{
					return ((TestProxy.systemuser_emailrouteraccessapproval)(System.Enum.ToObject(typeof(TestProxy.systemuser_emailrouteraccessapproval), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("EmailRouterAccessApproval");
				if ((value == null))
				{
					this.SetAttributeValue("emailrouteraccessapproval", null);
				}
				else
				{
					this.SetAttributeValue("emailrouteraccessapproval", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("EmailRouterAccessApproval");
			}
		}
		
		/// <summary>
		/// Employee identifier for the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("employeeid")]
		public string EmployeeId
		{
			get
			{
				return this.GetAttributeValue<string>("employeeid");
			}
			set
			{
				this.OnPropertyChanging("EmployeeId");
				this.SetAttributeValue("employeeid", value);
				this.OnPropertyChanged("EmployeeId");
			}
		}
		
		/// <summary>
		/// Shows the default image for the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage")]
		public byte[] EntityImage
		{
			get
			{
				return this.GetAttributeValue<byte[]>("entityimage");
			}
			set
			{
				this.OnPropertyChanging("EntityImage");
				this.SetAttributeValue("entityimage", value);
				this.OnPropertyChanged("EntityImage");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_timestamp")]
		public System.Nullable<long> EntityImage_Timestamp
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("entityimage_timestamp");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_url")]
		public string EntityImage_URL
		{
			get
			{
				return this.GetAttributeValue<string>("entityimage_url");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimageid")]
		public System.Nullable<System.Guid> EntityImageId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("entityimageid");
			}
		}
		
		/// <summary>
		/// Exchange rate for the currency associated with the systemuser with respect to the base currency.
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
		/// First name of the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("firstname")]
		public string FirstName
		{
			get
			{
				return this.GetAttributeValue<string>("firstname");
			}
			set
			{
				this.OnPropertyChanging("FirstName");
				this.SetAttributeValue("firstname", value);
				this.OnPropertyChanged("FirstName");
			}
		}
		
		/// <summary>
		/// Full name of the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fullname")]
		public string FullName
		{
			get
			{
				return this.GetAttributeValue<string>("fullname");
			}
		}
		
		/// <summary>
		/// Government identifier for the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("governmentid")]
		public string GovernmentId
		{
			get
			{
				return this.GetAttributeValue<string>("governmentid");
			}
			set
			{
				this.OnPropertyChanging("GovernmentId");
				this.SetAttributeValue("governmentid", value);
				this.OnPropertyChanged("GovernmentId");
			}
		}
		
		/// <summary>
		/// Home phone number for the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("homephone")]
		public string HomePhone
		{
			get
			{
				return this.GetAttributeValue<string>("homephone");
			}
			set
			{
				this.OnPropertyChanging("HomePhone");
				this.SetAttributeValue("homephone", value);
				this.OnPropertyChanged("HomePhone");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("identityid")]
		public System.Nullable<int> IdentityId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("identityid");
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
		/// Incoming email delivery method for the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("incomingemaildeliverymethod")]
		public System.Nullable<TestProxy.systemuser_incomingemaildeliverymethod> IncomingEmailDeliveryMethod
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("incomingemaildeliverymethod");
				if ((optionSet != null))
				{
					return ((TestProxy.systemuser_incomingemaildeliverymethod)(System.Enum.ToObject(typeof(TestProxy.systemuser_incomingemaildeliverymethod), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("IncomingEmailDeliveryMethod");
				if ((value == null))
				{
					this.SetAttributeValue("incomingemaildeliverymethod", null);
				}
				else
				{
					this.SetAttributeValue("incomingemaildeliverymethod", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("IncomingEmailDeliveryMethod");
			}
		}
		
		/// <summary>
		/// Internal email address for the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("internalemailaddress")]
		public string InternalEMailAddress
		{
			get
			{
				return this.GetAttributeValue<string>("internalemailaddress");
			}
			set
			{
				this.OnPropertyChanging("InternalEMailAddress");
				this.SetAttributeValue("internalemailaddress", value);
				this.OnPropertyChanged("InternalEMailAddress");
			}
		}
		
		/// <summary>
		/// User invitation status.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("invitestatuscode")]
		public System.Nullable<TestProxy.systemuser_invitestatuscode> InviteStatusCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("invitestatuscode");
				if ((optionSet != null))
				{
					return ((TestProxy.systemuser_invitestatuscode)(System.Enum.ToObject(typeof(TestProxy.systemuser_invitestatuscode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("InviteStatusCode");
				if ((value == null))
				{
					this.SetAttributeValue("invitestatuscode", null);
				}
				else
				{
					this.SetAttributeValue("invitestatuscode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("InviteStatusCode");
			}
		}
		
		/// <summary>
		/// Information about whether the user is enabled.
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
		/// Shows the status of approval of the email address by O365 Admin.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isemailaddressapprovedbyo365admin")]
		public System.Nullable<bool> IsEmailAddressApprovedByO365Admin
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isemailaddressapprovedbyo365admin");
			}
		}
		
		/// <summary>
		/// Check if user is an integration user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isintegrationuser")]
		public System.Nullable<bool> IsIntegrationUser
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isintegrationuser");
			}
			set
			{
				this.OnPropertyChanging("IsIntegrationUser");
				this.SetAttributeValue("isintegrationuser", value);
				this.OnPropertyChanged("IsIntegrationUser");
			}
		}
		
		/// <summary>
		/// Information about whether the user is licensed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("islicensed")]
		public System.Nullable<bool> IsLicensed
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("islicensed");
			}
			set
			{
				this.OnPropertyChanging("IsLicensed");
				this.SetAttributeValue("islicensed", value);
				this.OnPropertyChanged("IsLicensed");
			}
		}
		
		/// <summary>
		/// Information about whether the user is synced with the directory.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("issyncwithdirectory")]
		public System.Nullable<bool> IsSyncWithDirectory
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("issyncwithdirectory");
			}
			set
			{
				this.OnPropertyChanging("IsSyncWithDirectory");
				this.SetAttributeValue("issyncwithdirectory", value);
				this.OnPropertyChanged("IsSyncWithDirectory");
			}
		}
		
		/// <summary>
		/// Job title of the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("jobtitle")]
		public string JobTitle
		{
			get
			{
				return this.GetAttributeValue<string>("jobtitle");
			}
			set
			{
				this.OnPropertyChanging("JobTitle");
				this.SetAttributeValue("jobtitle", value);
				this.OnPropertyChanged("JobTitle");
			}
		}
		
		/// <summary>
		/// Last name of the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastname")]
		public string LastName
		{
			get
			{
				return this.GetAttributeValue<string>("lastname");
			}
			set
			{
				this.OnPropertyChanging("LastName");
				this.SetAttributeValue("lastname", value);
				this.OnPropertyChanged("LastName");
			}
		}
		
		/// <summary>
		/// Middle name of the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("middlename")]
		public string MiddleName
		{
			get
			{
				return this.GetAttributeValue<string>("middlename");
			}
			set
			{
				this.OnPropertyChanging("MiddleName");
				this.SetAttributeValue("middlename", value);
				this.OnPropertyChanged("MiddleName");
			}
		}
		
		/// <summary>
		/// Mobile alert email address for the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobilealertemail")]
		public string MobileAlertEMail
		{
			get
			{
				return this.GetAttributeValue<string>("mobilealertemail");
			}
			set
			{
				this.OnPropertyChanging("MobileAlertEMail");
				this.SetAttributeValue("mobilealertemail", value);
				this.OnPropertyChanged("MobileAlertEMail");
			}
		}
		
		/// <summary>
		/// Items contained with a particular SystemUser.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobileofflineprofileid")]
		public Microsoft.Xrm.Sdk.EntityReference MobileOfflineProfileId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("mobileofflineprofileid");
			}
			set
			{
				this.OnPropertyChanging("MobileOfflineProfileId");
				this.SetAttributeValue("mobileofflineprofileid", value);
				this.OnPropertyChanged("MobileOfflineProfileId");
			}
		}
		
		/// <summary>
		/// Mobile phone number for the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobilephone")]
		public string MobilePhone
		{
			get
			{
				return this.GetAttributeValue<string>("mobilephone");
			}
			set
			{
				this.OnPropertyChanging("MobilePhone");
				this.SetAttributeValue("mobilephone", value);
				this.OnPropertyChanged("MobilePhone");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the user.
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
		/// Date and time when the user was last modified.
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
		/// Unique identifier of the delegate user who last modified the systemuser.
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
		/// Nickname of the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("nickname")]
		public string NickName
		{
			get
			{
				return this.GetAttributeValue<string>("nickname");
			}
			set
			{
				this.OnPropertyChanging("NickName");
				this.SetAttributeValue("nickname", value);
				this.OnPropertyChanged("NickName");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization associated with the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public System.Nullable<System.Guid> OrganizationId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("organizationid");
			}
		}
		
		/// <summary>
		/// Outgoing email delivery method for the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("outgoingemaildeliverymethod")]
		public System.Nullable<TestProxy.systemuser_outgoingemaildeliverymethod> OutgoingEmailDeliveryMethod
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("outgoingemaildeliverymethod");
				if ((optionSet != null))
				{
					return ((TestProxy.systemuser_outgoingemaildeliverymethod)(System.Enum.ToObject(typeof(TestProxy.systemuser_outgoingemaildeliverymethod), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("OutgoingEmailDeliveryMethod");
				if ((value == null))
				{
					this.SetAttributeValue("outgoingemaildeliverymethod", null);
				}
				else
				{
					this.SetAttributeValue("outgoingemaildeliverymethod", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("OutgoingEmailDeliveryMethod");
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
		/// Unique identifier of the manager of the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentsystemuserid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentSystemUserId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentsystemuserid");
			}
			set
			{
				this.OnPropertyChanging("ParentSystemUserId");
				this.SetAttributeValue("parentsystemuserid", value);
				this.OnPropertyChanged("ParentSystemUserId");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("passporthi")]
		public System.Nullable<int> PassportHi
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("passporthi");
			}
			set
			{
				this.OnPropertyChanging("PassportHi");
				this.SetAttributeValue("passporthi", value);
				this.OnPropertyChanged("PassportHi");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("passportlo")]
		public System.Nullable<int> PassportLo
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("passportlo");
			}
			set
			{
				this.OnPropertyChanging("PassportLo");
				this.SetAttributeValue("passportlo", value);
				this.OnPropertyChanged("PassportLo");
			}
		}
		
		/// <summary>
		/// Personal email address of the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("personalemailaddress")]
		public string PersonalEMailAddress
		{
			get
			{
				return this.GetAttributeValue<string>("personalemailaddress");
			}
			set
			{
				this.OnPropertyChanging("PersonalEMailAddress");
				this.SetAttributeValue("personalemailaddress", value);
				this.OnPropertyChanged("PersonalEMailAddress");
			}
		}
		
		/// <summary>
		/// URL for the Website on which a photo of the user is located.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("photourl")]
		public string PhotoUrl
		{
			get
			{
				return this.GetAttributeValue<string>("photourl");
			}
			set
			{
				this.OnPropertyChanging("PhotoUrl");
				this.SetAttributeValue("photourl", value);
				this.OnPropertyChanged("PhotoUrl");
			}
		}
		
		/// <summary>
		/// User's position in hierarchical security model.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("positionid")]
		public Microsoft.Xrm.Sdk.EntityReference PositionId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("positionid");
			}
			set
			{
				this.OnPropertyChanging("PositionId");
				this.SetAttributeValue("positionid", value);
				this.OnPropertyChanged("PositionId");
			}
		}
		
		/// <summary>
		/// Preferred address for the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredaddresscode")]
		public System.Nullable<TestProxy.systemuser_preferredaddresscode> PreferredAddressCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredaddresscode");
				if ((optionSet != null))
				{
					return ((TestProxy.systemuser_preferredaddresscode)(System.Enum.ToObject(typeof(TestProxy.systemuser_preferredaddresscode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("PreferredAddressCode");
				if ((value == null))
				{
					this.SetAttributeValue("preferredaddresscode", null);
				}
				else
				{
					this.SetAttributeValue("preferredaddresscode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("PreferredAddressCode");
			}
		}
		
		/// <summary>
		/// Preferred email address for the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredemailcode")]
		public System.Nullable<TestProxy.systemuser_preferredemailcode> PreferredEmailCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredemailcode");
				if ((optionSet != null))
				{
					return ((TestProxy.systemuser_preferredemailcode)(System.Enum.ToObject(typeof(TestProxy.systemuser_preferredemailcode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("PreferredEmailCode");
				if ((value == null))
				{
					this.SetAttributeValue("preferredemailcode", null);
				}
				else
				{
					this.SetAttributeValue("preferredemailcode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("PreferredEmailCode");
			}
		}
		
		/// <summary>
		/// Preferred phone number for the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredphonecode")]
		public System.Nullable<TestProxy.systemuser_preferredphonecode> PreferredPhoneCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredphonecode");
				if ((optionSet != null))
				{
					return ((TestProxy.systemuser_preferredphonecode)(System.Enum.ToObject(typeof(TestProxy.systemuser_preferredphonecode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("PreferredPhoneCode");
				if ((value == null))
				{
					this.SetAttributeValue("preferredphonecode", null);
				}
				else
				{
					this.SetAttributeValue("preferredphonecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("PreferredPhoneCode");
			}
		}
		
		/// <summary>
		/// Shows the ID of the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		public System.Nullable<System.Guid> ProcessId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("processid");
			}
			set
			{
				this.OnPropertyChanging("ProcessId");
				this.SetAttributeValue("processid", value);
				this.OnPropertyChanged("ProcessId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the default queue for the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queueid")]
		public Microsoft.Xrm.Sdk.EntityReference QueueId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("queueid");
			}
			set
			{
				this.OnPropertyChanging("QueueId");
				this.SetAttributeValue("queueid", value);
				this.OnPropertyChanged("QueueId");
			}
		}
		
		/// <summary>
		/// Salutation for correspondence with the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salutation")]
		public string Salutation
		{
			get
			{
				return this.GetAttributeValue<string>("salutation");
			}
			set
			{
				this.OnPropertyChanging("Salutation");
				this.SetAttributeValue("salutation", value);
				this.OnPropertyChanged("Salutation");
			}
		}
		
		/// <summary>
		/// Check if user is a setup user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("setupuser")]
		public System.Nullable<bool> SetupUser
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("setupuser");
			}
			set
			{
				this.OnPropertyChanging("SetupUser");
				this.SetAttributeValue("setupuser", value);
				this.OnPropertyChanged("SetupUser");
			}
		}
		
		/// <summary>
		/// SharePoint Work Email Address
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sharepointemailaddress")]
		public string SharePointEmailAddress
		{
			get
			{
				return this.GetAttributeValue<string>("sharepointemailaddress");
			}
			set
			{
				this.OnPropertyChanging("SharePointEmailAddress");
				this.SetAttributeValue("sharepointemailaddress", value);
				this.OnPropertyChanged("SharePointEmailAddress");
			}
		}
		
		/// <summary>
		/// Skill set of the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("skills")]
		public string Skills
		{
			get
			{
				return this.GetAttributeValue<string>("skills");
			}
			set
			{
				this.OnPropertyChanging("Skills");
				this.SetAttributeValue("skills", value);
				this.OnPropertyChanged("Skills");
			}
		}
		
		/// <summary>
		/// Shows the ID of the stage.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
		public System.Nullable<System.Guid> StageId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid");
			}
			set
			{
				this.OnPropertyChanging("StageId");
				this.SetAttributeValue("stageid", value);
				this.OnPropertyChanged("StageId");
			}
		}
		
		/// <summary>
		/// Unique identifier for the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
		public System.Nullable<System.Guid> SystemUserId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("systemuserid");
			}
			set
			{
				this.OnPropertyChanging("SystemUserId");
				this.SetAttributeValue("systemuserid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("SystemUserId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.SystemUserId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the territory to which the user is assigned.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("territoryid")]
		public Microsoft.Xrm.Sdk.EntityReference TerritoryId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("territoryid");
			}
			set
			{
				this.OnPropertyChanging("TerritoryId");
				this.SetAttributeValue("territoryid", value);
				this.OnPropertyChanged("TerritoryId");
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
		/// Title of the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("title")]
		public string Title
		{
			get
			{
				return this.GetAttributeValue<string>("title");
			}
			set
			{
				this.OnPropertyChanging("Title");
				this.SetAttributeValue("title", value);
				this.OnPropertyChanged("Title");
			}
		}
		
		/// <summary>
		/// Unique identifier of the currency associated with the systemuser.
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
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
		public string TraversedPath
		{
			get
			{
				return this.GetAttributeValue<string>("traversedpath");
			}
			set
			{
				this.OnPropertyChanging("TraversedPath");
				this.SetAttributeValue("traversedpath", value);
				this.OnPropertyChanged("TraversedPath");
			}
		}
		
		/// <summary>
		/// Shows the type of user license.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userlicensetype")]
		public System.Nullable<int> UserLicenseType
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("userlicensetype");
			}
			set
			{
				this.OnPropertyChanging("UserLicenseType");
				this.SetAttributeValue("userlicensetype", value);
				this.OnPropertyChanged("UserLicenseType");
			}
		}
		
		/// <summary>
		///  User PUID User Identifiable Information
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userpuid")]
		public string UserPuid
		{
			get
			{
				return this.GetAttributeValue<string>("userpuid");
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
		/// Version number of the user.
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
		/// Windows Live ID
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("windowsliveid")]
		public string WindowsLiveID
		{
			get
			{
				return this.GetAttributeValue<string>("windowsliveid");
			}
			set
			{
				this.OnPropertyChanging("WindowsLiveID");
				this.SetAttributeValue("windowsliveid", value);
				this.OnPropertyChanged("WindowsLiveID");
			}
		}
		
		/// <summary>
		/// User's Yammer login email address
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yammeremailaddress")]
		public string YammerEmailAddress
		{
			get
			{
				return this.GetAttributeValue<string>("yammeremailaddress");
			}
			set
			{
				this.OnPropertyChanging("YammerEmailAddress");
				this.SetAttributeValue("yammeremailaddress", value);
				this.OnPropertyChanged("YammerEmailAddress");
			}
		}
		
		/// <summary>
		/// User's Yammer ID
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yammeruserid")]
		public string YammerUserId
		{
			get
			{
				return this.GetAttributeValue<string>("yammeruserid");
			}
			set
			{
				this.OnPropertyChanging("YammerUserId");
				this.SetAttributeValue("yammeruserid", value);
				this.OnPropertyChanged("YammerUserId");
			}
		}
		
		/// <summary>
		/// Pronunciation of the first name of the user, written in phonetic hiragana or katakana characters.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomifirstname")]
		public string YomiFirstName
		{
			get
			{
				return this.GetAttributeValue<string>("yomifirstname");
			}
			set
			{
				this.OnPropertyChanging("YomiFirstName");
				this.SetAttributeValue("yomifirstname", value);
				this.OnPropertyChanged("YomiFirstName");
			}
		}
		
		/// <summary>
		/// Pronunciation of the full name of the user, written in phonetic hiragana or katakana characters.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomifullname")]
		public string YomiFullName
		{
			get
			{
				return this.GetAttributeValue<string>("yomifullname");
			}
		}
		
		/// <summary>
		/// Pronunciation of the last name of the user, written in phonetic hiragana or katakana characters.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomilastname")]
		public string YomiLastName
		{
			get
			{
				return this.GetAttributeValue<string>("yomilastname");
			}
			set
			{
				this.OnPropertyChanging("YomiLastName");
				this.SetAttributeValue("yomilastname", value);
				this.OnPropertyChanged("YomiLastName");
			}
		}
		
		/// <summary>
		/// Pronunciation of the middle name of the user, written in phonetic hiragana or katakana characters.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomimiddlename")]
		public string YomiMiddleName
		{
			get
			{
				return this.GetAttributeValue<string>("yomimiddlename");
			}
			set
			{
				this.OnPropertyChanging("YomiMiddleName");
				this.SetAttributeValue("yomimiddlename", value);
				this.OnPropertyChanged("YomiMiddleName");
			}
		}
		
		/// <summary>
		/// 1:N contact_owning_user
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_owning_user")]
		public System.Collections.Generic.IEnumerable<TestProxy.Contact> contact_owning_user
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.Contact>("contact_owning_user", null);
			}
			set
			{
				this.OnPropertyChanging("contact_owning_user");
				this.SetRelatedEntities<TestProxy.Contact>("contact_owning_user", null, value);
				this.OnPropertyChanged("contact_owning_user");
			}
		}
		
		/// <summary>
		/// 1:N lk_accountbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.Account> lk_accountbase_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.Account>("lk_accountbase_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_accountbase_createdby");
				this.SetRelatedEntities<TestProxy.Account>("lk_accountbase_createdby", null, value);
				this.OnPropertyChanged("lk_accountbase_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_accountbase_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.Account> lk_accountbase_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.Account>("lk_accountbase_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_accountbase_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.Account>("lk_accountbase_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_accountbase_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_accountbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.Account> lk_accountbase_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.Account>("lk_accountbase_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_accountbase_modifiedby");
				this.SetRelatedEntities<TestProxy.Account>("lk_accountbase_modifiedby", null, value);
				this.OnPropertyChanged("lk_accountbase_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_accountbase_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.Account> lk_accountbase_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.Account>("lk_accountbase_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_accountbase_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.Account>("lk_accountbase_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_accountbase_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_businessunit_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunit_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.BusinessUnit> lk_businessunit_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.BusinessUnit>("lk_businessunit_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_businessunit_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.BusinessUnit>("lk_businessunit_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_businessunit_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_businessunit_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunit_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.BusinessUnit> lk_businessunit_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.BusinessUnit>("lk_businessunit_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_businessunit_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.BusinessUnit>("lk_businessunit_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_businessunit_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_businessunitbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunitbase_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.BusinessUnit> lk_businessunitbase_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.BusinessUnit>("lk_businessunitbase_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_businessunitbase_createdby");
				this.SetRelatedEntities<TestProxy.BusinessUnit>("lk_businessunitbase_createdby", null, value);
				this.OnPropertyChanged("lk_businessunitbase_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_businessunitbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunitbase_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.BusinessUnit> lk_businessunitbase_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.BusinessUnit>("lk_businessunitbase_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_businessunitbase_modifiedby");
				this.SetRelatedEntities<TestProxy.BusinessUnit>("lk_businessunitbase_modifiedby", null, value);
				this.OnPropertyChanged("lk_businessunitbase_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_contact_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contact_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.Contact> lk_contact_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.Contact>("lk_contact_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_contact_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.Contact>("lk_contact_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_contact_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_contact_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contact_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.Contact> lk_contact_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.Contact>("lk_contact_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_contact_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.Contact>("lk_contact_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_contact_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_contactbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contactbase_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.Contact> lk_contactbase_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.Contact>("lk_contactbase_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_contactbase_createdby");
				this.SetRelatedEntities<TestProxy.Contact>("lk_contactbase_createdby", null, value);
				this.OnPropertyChanged("lk_contactbase_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_contactbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contactbase_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.Contact> lk_contactbase_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.Contact>("lk_contactbase_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_contactbase_modifiedby");
				this.SetRelatedEntities<TestProxy.Contact>("lk_contactbase_modifiedby", null, value);
				this.OnPropertyChanged("lk_contactbase_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_customeraddress_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeraddress_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.CustomerAddress> lk_customeraddress_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.CustomerAddress>("lk_customeraddress_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_customeraddress_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.CustomerAddress>("lk_customeraddress_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_customeraddress_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_customeraddress_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeraddress_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.CustomerAddress> lk_customeraddress_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.CustomerAddress>("lk_customeraddress_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_customeraddress_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.CustomerAddress>("lk_customeraddress_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_customeraddress_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_customeraddressbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeraddressbase_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.CustomerAddress> lk_customeraddressbase_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.CustomerAddress>("lk_customeraddressbase_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_customeraddressbase_createdby");
				this.SetRelatedEntities<TestProxy.CustomerAddress>("lk_customeraddressbase_createdby", null, value);
				this.OnPropertyChanged("lk_customeraddressbase_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_customeraddressbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeraddressbase_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.CustomerAddress> lk_customeraddressbase_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.CustomerAddress>("lk_customeraddressbase_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_customeraddressbase_modifiedby");
				this.SetRelatedEntities<TestProxy.CustomerAddress>("lk_customeraddressbase_modifiedby", null, value);
				this.OnPropertyChanged("lk_customeraddressbase_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_agent_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_agent_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_agent> lk_ccllc_agent_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_agent>("lk_ccllc_agent_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_agent_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_agent>("lk_ccllc_agent_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_agent_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_agent_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_agent_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_agent> lk_ccllc_agent_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_agent>("lk_ccllc_agent_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_agent_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_agent>("lk_ccllc_agent_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_agent_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_agent_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_agent_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_agent> lk_ccllc_agent_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_agent>("lk_ccllc_agent_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_agent_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_agent>("lk_ccllc_agent_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_agent_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_agent_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_agent_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_agent> lk_ccllc_agent_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_agent>("lk_ccllc_agent_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_agent_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_agent>("lk_ccllc_agent_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_agent_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_agentauthorizedcustomer_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_agentauthorizedcustomer_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_agentauthorizedcustomer> lk_ccllc_agentauthorizedcustomer_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_agentauthorizedcustomer>("lk_ccllc_agentauthorizedcustomer_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_agentauthorizedcustomer_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_agentauthorizedcustomer>("lk_ccllc_agentauthorizedcustomer_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_agentauthorizedcustomer_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_agentauthorizedcustomer_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_agentauthorizedcustomer_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_agentauthorizedcustomer> lk_ccllc_agentauthorizedcustomer_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_agentauthorizedcustomer>("lk_ccllc_agentauthorizedcustomer_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_agentauthorizedcustomer_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_agentauthorizedcustomer>("lk_ccllc_agentauthorizedcustomer_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_agentauthorizedcustomer_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_agentauthorizedcustomer_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_agentauthorizedcustomer_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_agentauthorizedcustomer> lk_ccllc_agentauthorizedcustomer_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_agentauthorizedcustomer>("lk_ccllc_agentauthorizedcustomer_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_agentauthorizedcustomer_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_agentauthorizedcustomer>("lk_ccllc_agentauthorizedcustomer_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_agentauthorizedcustomer_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_agentauthorizedcustomer_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_agentauthorizedcustomer_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_agentauthorizedcustomer> lk_ccllc_agentauthorizedcustomer_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_agentauthorizedcustomer>("lk_ccllc_agentauthorizedcustomer_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_agentauthorizedcustomer_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_agentauthorizedcustomer>("lk_ccllc_agentauthorizedcustomer_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_agentauthorizedcustomer_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_agentprohibitedcustomer_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_agentprohibitedcustomer_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_agentprohibitedcustomer> lk_ccllc_agentprohibitedcustomer_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_agentprohibitedcustomer>("lk_ccllc_agentprohibitedcustomer_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_agentprohibitedcustomer_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_agentprohibitedcustomer>("lk_ccllc_agentprohibitedcustomer_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_agentprohibitedcustomer_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_agentprohibitedcustomer_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_agentprohibitedcustomer_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_agentprohibitedcustomer> lk_ccllc_agentprohibitedcustomer_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_agentprohibitedcustomer>("lk_ccllc_agentprohibitedcustomer_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_agentprohibitedcustomer_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_agentprohibitedcustomer>("lk_ccllc_agentprohibitedcustomer_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_agentprohibitedcustomer_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_agentprohibitedcustomer_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_agentprohibitedcustomer_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_agentprohibitedcustomer> lk_ccllc_agentprohibitedcustomer_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_agentprohibitedcustomer>("lk_ccllc_agentprohibitedcustomer_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_agentprohibitedcustomer_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_agentprohibitedcustomer>("lk_ccllc_agentprohibitedcustomer_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_agentprohibitedcustomer_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_agentprohibitedcustomer_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_agentprohibitedcustomer_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_agentprohibitedcustomer> lk_ccllc_agentprohibitedcustomer_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_agentprohibitedcustomer>("lk_ccllc_agentprohibitedcustomer_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_agentprohibitedcustomer_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_agentprohibitedcustomer>("lk_ccllc_agentprohibitedcustomer_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_agentprohibitedcustomer_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_agentrole_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_agentrole_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_agentrole> lk_ccllc_agentrole_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_agentrole>("lk_ccllc_agentrole_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_agentrole_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_agentrole>("lk_ccllc_agentrole_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_agentrole_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_agentrole_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_agentrole_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_agentrole> lk_ccllc_agentrole_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_agentrole>("lk_ccllc_agentrole_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_agentrole_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_agentrole>("lk_ccllc_agentrole_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_agentrole_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_agentrole_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_agentrole_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_agentrole> lk_ccllc_agentrole_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_agentrole>("lk_ccllc_agentrole_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_agentrole_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_agentrole>("lk_ccllc_agentrole_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_agentrole_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_agentrole_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_agentrole_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_agentrole> lk_ccllc_agentrole_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_agentrole>("lk_ccllc_agentrole_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_agentrole_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_agentrole>("lk_ccllc_agentrole_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_agentrole_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_alternatebranch_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_alternatebranch_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_alternatebranch> lk_ccllc_alternatebranch_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_alternatebranch>("lk_ccllc_alternatebranch_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_alternatebranch_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_alternatebranch>("lk_ccllc_alternatebranch_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_alternatebranch_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_alternatebranch_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_alternatebranch_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_alternatebranch> lk_ccllc_alternatebranch_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_alternatebranch>("lk_ccllc_alternatebranch_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_alternatebranch_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_alternatebranch>("lk_ccllc_alternatebranch_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_alternatebranch_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_alternatebranch_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_alternatebranch_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_alternatebranch> lk_ccllc_alternatebranch_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_alternatebranch>("lk_ccllc_alternatebranch_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_alternatebranch_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_alternatebranch>("lk_ccllc_alternatebranch_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_alternatebranch_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_alternatebranch_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_alternatebranch_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_alternatebranch> lk_ccllc_alternatebranch_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_alternatebranch>("lk_ccllc_alternatebranch_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_alternatebranch_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_alternatebranch>("lk_ccllc_alternatebranch_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_alternatebranch_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_appliedfee_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_appliedfee_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_appliedfee> lk_ccllc_appliedfee_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_appliedfee>("lk_ccllc_appliedfee_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_appliedfee_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_appliedfee>("lk_ccllc_appliedfee_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_appliedfee_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_appliedfee_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_appliedfee_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_appliedfee> lk_ccllc_appliedfee_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_appliedfee>("lk_ccllc_appliedfee_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_appliedfee_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_appliedfee>("lk_ccllc_appliedfee_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_appliedfee_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_appliedfee_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_appliedfee_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_appliedfee> lk_ccllc_appliedfee_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_appliedfee>("lk_ccllc_appliedfee_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_appliedfee_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_appliedfee>("lk_ccllc_appliedfee_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_appliedfee_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_appliedfee_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_appliedfee_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_appliedfee> lk_ccllc_appliedfee_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_appliedfee>("lk_ccllc_appliedfee_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_appliedfee_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_appliedfee>("lk_ccllc_appliedfee_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_appliedfee_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_channel_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_channel_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_channel> lk_ccllc_channel_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_channel>("lk_ccllc_channel_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_channel_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_channel>("lk_ccllc_channel_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_channel_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_channel_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_channel_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_channel> lk_ccllc_channel_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_channel>("lk_ccllc_channel_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_channel_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_channel>("lk_ccllc_channel_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_channel_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_channel_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_channel_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_channel> lk_ccllc_channel_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_channel>("lk_ccllc_channel_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_channel_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_channel>("lk_ccllc_channel_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_channel_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_channel_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_channel_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_channel> lk_ccllc_channel_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_channel>("lk_ccllc_channel_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_channel_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_channel>("lk_ccllc_channel_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_channel_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_device_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_device_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_device> lk_ccllc_device_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_device>("lk_ccllc_device_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_device_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_device>("lk_ccllc_device_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_device_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_device_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_device_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_device> lk_ccllc_device_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_device>("lk_ccllc_device_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_device_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_device>("lk_ccllc_device_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_device_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_device_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_device_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_device> lk_ccllc_device_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_device>("lk_ccllc_device_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_device_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_device>("lk_ccllc_device_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_device_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_device_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_device_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_device> lk_ccllc_device_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_device>("lk_ccllc_device_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_device_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_device>("lk_ccllc_device_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_device_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_evaluatortype_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_evaluatortype_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_evaluatortype> lk_ccllc_evaluatortype_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_evaluatortype>("lk_ccllc_evaluatortype_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_evaluatortype_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_evaluatortype>("lk_ccllc_evaluatortype_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_evaluatortype_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_evaluatortype_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_evaluatortype_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_evaluatortype> lk_ccllc_evaluatortype_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_evaluatortype>("lk_ccllc_evaluatortype_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_evaluatortype_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_evaluatortype>("lk_ccllc_evaluatortype_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_evaluatortype_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_evaluatortype_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_evaluatortype_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_evaluatortype> lk_ccllc_evaluatortype_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_evaluatortype>("lk_ccllc_evaluatortype_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_evaluatortype_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_evaluatortype>("lk_ccllc_evaluatortype_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_evaluatortype_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_evaluatortype_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_evaluatortype_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_evaluatortype> lk_ccllc_evaluatortype_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_evaluatortype>("lk_ccllc_evaluatortype_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_evaluatortype_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_evaluatortype>("lk_ccllc_evaluatortype_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_evaluatortype_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_fee_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_fee_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_fee> lk_ccllc_fee_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_fee>("lk_ccllc_fee_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_fee_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_fee>("lk_ccllc_fee_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_fee_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_fee_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_fee_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_fee> lk_ccllc_fee_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_fee>("lk_ccllc_fee_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_fee_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_fee>("lk_ccllc_fee_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_fee_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_fee_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_fee_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_fee> lk_ccllc_fee_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_fee>("lk_ccllc_fee_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_fee_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_fee>("lk_ccllc_fee_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_fee_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_fee_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_fee_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_fee> lk_ccllc_fee_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_fee>("lk_ccllc_fee_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_fee_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_fee>("lk_ccllc_fee_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_fee_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_location_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_location_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_location> lk_ccllc_location_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_location>("lk_ccllc_location_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_location_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_location>("lk_ccllc_location_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_location_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_location_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_location_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_location> lk_ccllc_location_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_location>("lk_ccllc_location_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_location_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_location>("lk_ccllc_location_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_location_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_location_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_location_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_location> lk_ccllc_location_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_location>("lk_ccllc_location_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_location_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_location>("lk_ccllc_location_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_location_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_location_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_location_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_location> lk_ccllc_location_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_location>("lk_ccllc_location_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_location_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_location>("lk_ccllc_location_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_location_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_partner_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_partner_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_partner> lk_ccllc_partner_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_partner>("lk_ccllc_partner_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_partner_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_partner>("lk_ccllc_partner_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_partner_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_partner_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_partner_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_partner> lk_ccllc_partner_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_partner>("lk_ccllc_partner_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_partner_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_partner>("lk_ccllc_partner_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_partner_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_partner_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_partner_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_partner> lk_ccllc_partner_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_partner>("lk_ccllc_partner_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_partner_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_partner>("lk_ccllc_partner_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_partner_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_partner_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_partner_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_partner> lk_ccllc_partner_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_partner>("lk_ccllc_partner_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_partner_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_partner>("lk_ccllc_partner_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_partner_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_partnerworker_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_partnerworker_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_partnerworker> lk_ccllc_partnerworker_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_partnerworker>("lk_ccllc_partnerworker_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_partnerworker_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_partnerworker>("lk_ccllc_partnerworker_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_partnerworker_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_partnerworker_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_partnerworker_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_partnerworker> lk_ccllc_partnerworker_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_partnerworker>("lk_ccllc_partnerworker_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_partnerworker_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_partnerworker>("lk_ccllc_partnerworker_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_partnerworker_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_partnerworker_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_partnerworker_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_partnerworker> lk_ccllc_partnerworker_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_partnerworker>("lk_ccllc_partnerworker_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_partnerworker_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_partnerworker>("lk_ccllc_partnerworker_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_partnerworker_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_partnerworker_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_partnerworker_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_partnerworker> lk_ccllc_partnerworker_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_partnerworker>("lk_ccllc_partnerworker_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_partnerworker_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_partnerworker>("lk_ccllc_partnerworker_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_partnerworker_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_processauthorizedchannel_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_processauthorizedchannel_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processauthorizedchannel> lk_ccllc_processauthorizedchannel_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processauthorizedchannel>("lk_ccllc_processauthorizedchannel_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_processauthorizedchannel_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_processauthorizedchannel>("lk_ccllc_processauthorizedchannel_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_processauthorizedchannel_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_processauthorizedchannel_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_processauthorizedchannel_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processauthorizedchannel> lk_ccllc_processauthorizedchannel_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processauthorizedchannel>("lk_ccllc_processauthorizedchannel_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_processauthorizedchannel_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_processauthorizedchannel>("lk_ccllc_processauthorizedchannel_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_processauthorizedchannel_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_processauthorizedchannel_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_processauthorizedchannel_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processauthorizedchannel> lk_ccllc_processauthorizedchannel_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processauthorizedchannel>("lk_ccllc_processauthorizedchannel_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_processauthorizedchannel_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_processauthorizedchannel>("lk_ccllc_processauthorizedchannel_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_processauthorizedchannel_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_processauthorizedchannel_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_processauthorizedchannel_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processauthorizedchannel> lk_ccllc_processauthorizedchannel_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processauthorizedchannel>("lk_ccllc_processauthorizedchannel_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_processauthorizedchannel_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_processauthorizedchannel>("lk_ccllc_processauthorizedchannel_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_processauthorizedchannel_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_processstep_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_processstep_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processstep> lk_ccllc_processstep_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processstep>("lk_ccllc_processstep_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_processstep_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_processstep>("lk_ccllc_processstep_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_processstep_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_processstep_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_processstep_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processstep> lk_ccllc_processstep_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processstep>("lk_ccllc_processstep_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_processstep_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_processstep>("lk_ccllc_processstep_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_processstep_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_processstep_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_processstep_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processstep> lk_ccllc_processstep_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processstep>("lk_ccllc_processstep_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_processstep_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_processstep>("lk_ccllc_processstep_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_processstep_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_processstep_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_processstep_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processstep> lk_ccllc_processstep_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processstep>("lk_ccllc_processstep_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_processstep_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_processstep>("lk_ccllc_processstep_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_processstep_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_processstepauthorizedchannel_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_processstepauthorizedchannel_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processstepauthorizedchannel> lk_ccllc_processstepauthorizedchannel_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processstepauthorizedchannel>("lk_ccllc_processstepauthorizedchannel_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_processstepauthorizedchannel_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_processstepauthorizedchannel>("lk_ccllc_processstepauthorizedchannel_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_processstepauthorizedchannel_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_processstepauthorizedchannel_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_processstepauthorizedchannel_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processstepauthorizedchannel> lk_ccllc_processstepauthorizedchannel_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processstepauthorizedchannel>("lk_ccllc_processstepauthorizedchannel_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_processstepauthorizedchannel_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_processstepauthorizedchannel>("lk_ccllc_processstepauthorizedchannel_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_processstepauthorizedchannel_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_processstepauthorizedchannel_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_processstepauthorizedchannel_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processstepauthorizedchannel> lk_ccllc_processstepauthorizedchannel_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processstepauthorizedchannel>("lk_ccllc_processstepauthorizedchannel_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_processstepauthorizedchannel_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_processstepauthorizedchannel>("lk_ccllc_processstepauthorizedchannel_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_processstepauthorizedchannel_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_processstepauthorizedchannel_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_processstepauthorizedchannel_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processstepauthorizedchannel> lk_ccllc_processstepauthorizedchannel_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processstepauthorizedchannel>("lk_ccllc_processstepauthorizedchannel_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_processstepauthorizedchannel_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_processstepauthorizedchannel>("lk_ccllc_processstepauthorizedchannel_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_processstepauthorizedchannel_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_processsteprequirement_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_processsteprequirement_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processsteprequirement> lk_ccllc_processsteprequirement_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processsteprequirement>("lk_ccllc_processsteprequirement_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_processsteprequirement_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_processsteprequirement>("lk_ccllc_processsteprequirement_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_processsteprequirement_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_processsteprequirement_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_processsteprequirement_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processsteprequirement> lk_ccllc_processsteprequirement_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processsteprequirement>("lk_ccllc_processsteprequirement_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_processsteprequirement_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_processsteprequirement>("lk_ccllc_processsteprequirement_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_processsteprequirement_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_processsteprequirement_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_processsteprequirement_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processsteprequirement> lk_ccllc_processsteprequirement_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processsteprequirement>("lk_ccllc_processsteprequirement_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_processsteprequirement_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_processsteprequirement>("lk_ccllc_processsteprequirement_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_processsteprequirement_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_processsteprequirement_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_processsteprequirement_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processsteprequirement> lk_ccllc_processsteprequirement_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processsteprequirement>("lk_ccllc_processsteprequirement_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_processsteprequirement_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_processsteprequirement>("lk_ccllc_processsteprequirement_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_processsteprequirement_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_processsteptype_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_processsteptype_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processsteptype> lk_ccllc_processsteptype_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processsteptype>("lk_ccllc_processsteptype_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_processsteptype_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_processsteptype>("lk_ccllc_processsteptype_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_processsteptype_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_processsteptype_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_processsteptype_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processsteptype> lk_ccllc_processsteptype_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processsteptype>("lk_ccllc_processsteptype_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_processsteptype_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_processsteptype>("lk_ccllc_processsteptype_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_processsteptype_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_processsteptype_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_processsteptype_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processsteptype> lk_ccllc_processsteptype_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processsteptype>("lk_ccllc_processsteptype_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_processsteptype_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_processsteptype>("lk_ccllc_processsteptype_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_processsteptype_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_processsteptype_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_processsteptype_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processsteptype> lk_ccllc_processsteptype_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processsteptype>("lk_ccllc_processsteptype_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_processsteptype_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_processsteptype>("lk_ccllc_processsteptype_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_processsteptype_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_requirementwaiverrole_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_requirementwaiverrole_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_requirementwaiverrole> lk_ccllc_requirementwaiverrole_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_requirementwaiverrole>("lk_ccllc_requirementwaiverrole_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_requirementwaiverrole_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_requirementwaiverrole>("lk_ccllc_requirementwaiverrole_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_requirementwaiverrole_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_requirementwaiverrole_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_requirementwaiverrole_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_requirementwaiverrole> lk_ccllc_requirementwaiverrole_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_requirementwaiverrole>("lk_ccllc_requirementwaiverrole_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_requirementwaiverrole_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_requirementwaiverrole>("lk_ccllc_requirementwaiverrole_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_requirementwaiverrole_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_requirementwaiverrole_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_requirementwaiverrole_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_requirementwaiverrole> lk_ccllc_requirementwaiverrole_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_requirementwaiverrole>("lk_ccllc_requirementwaiverrole_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_requirementwaiverrole_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_requirementwaiverrole>("lk_ccllc_requirementwaiverrole_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_requirementwaiverrole_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_requirementwaiverrole_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_requirementwaiverrole_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_requirementwaiverrole> lk_ccllc_requirementwaiverrole_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_requirementwaiverrole>("lk_ccllc_requirementwaiverrole_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_requirementwaiverrole_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_requirementwaiverrole>("lk_ccllc_requirementwaiverrole_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_requirementwaiverrole_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_role_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_role_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_role> lk_ccllc_role_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_role>("lk_ccllc_role_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_role_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_role>("lk_ccllc_role_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_role_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_role_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_role_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_role> lk_ccllc_role_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_role>("lk_ccllc_role_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_role_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_role>("lk_ccllc_role_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_role_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_role_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_role_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_role> lk_ccllc_role_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_role>("lk_ccllc_role_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_role_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_role>("lk_ccllc_role_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_role_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_role_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_role_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_role> lk_ccllc_role_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_role>("lk_ccllc_role_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_role_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_role>("lk_ccllc_role_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_role_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_stephistory_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_stephistory_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_stephistory> lk_ccllc_stephistory_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_stephistory>("lk_ccllc_stephistory_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_stephistory_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_stephistory>("lk_ccllc_stephistory_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_stephistory_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_stephistory_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_stephistory_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_stephistory> lk_ccllc_stephistory_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_stephistory>("lk_ccllc_stephistory_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_stephistory_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_stephistory>("lk_ccllc_stephistory_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_stephistory_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_stephistory_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_stephistory_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_stephistory> lk_ccllc_stephistory_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_stephistory>("lk_ccllc_stephistory_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_stephistory_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_stephistory>("lk_ccllc_stephistory_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_stephistory_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_stephistory_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_stephistory_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_stephistory> lk_ccllc_stephistory_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_stephistory>("lk_ccllc_stephistory_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_stephistory_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_stephistory>("lk_ccllc_stephistory_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_stephistory_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transaction_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transaction_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transaction> lk_ccllc_transaction_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transaction>("lk_ccllc_transaction_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transaction_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_transaction>("lk_ccllc_transaction_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_transaction_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transaction_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transaction_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transaction> lk_ccllc_transaction_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transaction>("lk_ccllc_transaction_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transaction_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_transaction>("lk_ccllc_transaction_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_transaction_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transaction_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transaction_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transaction> lk_ccllc_transaction_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transaction>("lk_ccllc_transaction_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transaction_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_transaction>("lk_ccllc_transaction_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_transaction_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transaction_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transaction_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transaction> lk_ccllc_transaction_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transaction>("lk_ccllc_transaction_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transaction_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_transaction>("lk_ccllc_transaction_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_transaction_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactiongroup_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactiongroup_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiongroup> lk_ccllc_transactiongroup_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiongroup>("lk_ccllc_transactiongroup_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactiongroup_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_transactiongroup>("lk_ccllc_transactiongroup_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactiongroup_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactiongroup_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactiongroup_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiongroup> lk_ccllc_transactiongroup_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiongroup>("lk_ccllc_transactiongroup_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactiongroup_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_transactiongroup>("lk_ccllc_transactiongroup_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactiongroup_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactiongroup_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactiongroup_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiongroup> lk_ccllc_transactiongroup_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiongroup>("lk_ccllc_transactiongroup_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactiongroup_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_transactiongroup>("lk_ccllc_transactiongroup_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactiongroup_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactiongroup_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactiongroup_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiongroup> lk_ccllc_transactiongroup_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiongroup>("lk_ccllc_transactiongroup_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactiongroup_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_transactiongroup>("lk_ccllc_transactiongroup_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactiongroup_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactioninitialfee_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactioninitialfee_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactioninitialfee> lk_ccllc_transactioninitialfee_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactioninitialfee>("lk_ccllc_transactioninitialfee_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactioninitialfee_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_transactioninitialfee>("lk_ccllc_transactioninitialfee_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactioninitialfee_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactioninitialfee_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactioninitialfee_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactioninitialfee> lk_ccllc_transactioninitialfee_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactioninitialfee>("lk_ccllc_transactioninitialfee_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactioninitialfee_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_transactioninitialfee>("lk_ccllc_transactioninitialfee_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactioninitialfee_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactioninitialfee_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactioninitialfee_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactioninitialfee> lk_ccllc_transactioninitialfee_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactioninitialfee>("lk_ccllc_transactioninitialfee_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactioninitialfee_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_transactioninitialfee>("lk_ccllc_transactioninitialfee_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactioninitialfee_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactioninitialfee_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactioninitialfee_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactioninitialfee> lk_ccllc_transactioninitialfee_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactioninitialfee>("lk_ccllc_transactioninitialfee_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactioninitialfee_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_transactioninitialfee>("lk_ccllc_transactioninitialfee_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactioninitialfee_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactionprocess_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactionprocess_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactionprocess> lk_ccllc_transactionprocess_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactionprocess>("lk_ccllc_transactionprocess_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactionprocess_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_transactionprocess>("lk_ccllc_transactionprocess_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactionprocess_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactionprocess_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactionprocess_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactionprocess> lk_ccllc_transactionprocess_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactionprocess>("lk_ccllc_transactionprocess_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactionprocess_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_transactionprocess>("lk_ccllc_transactionprocess_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactionprocess_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactionprocess_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactionprocess_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactionprocess> lk_ccllc_transactionprocess_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactionprocess>("lk_ccllc_transactionprocess_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactionprocess_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_transactionprocess>("lk_ccllc_transactionprocess_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactionprocess_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactionprocess_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactionprocess_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactionprocess> lk_ccllc_transactionprocess_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactionprocess>("lk_ccllc_transactionprocess_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactionprocess_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_transactionprocess>("lk_ccllc_transactionprocess_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactionprocess_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactionrequirement_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactionrequirement_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactionrequirement> lk_ccllc_transactionrequirement_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactionrequirement>("lk_ccllc_transactionrequirement_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactionrequirement_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_transactionrequirement>("lk_ccllc_transactionrequirement_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactionrequirement_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactionrequirement_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactionrequirement_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactionrequirement> lk_ccllc_transactionrequirement_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactionrequirement>("lk_ccllc_transactionrequirement_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactionrequirement_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_transactionrequirement>("lk_ccllc_transactionrequirement_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactionrequirement_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactionrequirement_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactionrequirement_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactionrequirement> lk_ccllc_transactionrequirement_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactionrequirement>("lk_ccllc_transactionrequirement_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactionrequirement_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_transactionrequirement>("lk_ccllc_transactionrequirement_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactionrequirement_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactionrequirement_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactionrequirement_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactionrequirement> lk_ccllc_transactionrequirement_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactionrequirement>("lk_ccllc_transactionrequirement_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactionrequirement_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_transactionrequirement>("lk_ccllc_transactionrequirement_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactionrequirement_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactionrequirementwaiverrole_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactionrequirementwaiverrole_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactionrequirementwaiverrole> lk_ccllc_transactionrequirementwaiverrole_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactionrequirementwaiverrole>("lk_ccllc_transactionrequirementwaiverrole_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactionrequirementwaiverrole_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_transactionrequirementwaiverrole>("lk_ccllc_transactionrequirementwaiverrole_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactionrequirementwaiverrole_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactionrequirementwaiverrole_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactionrequirementwaiverrole_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactionrequirementwaiverrole> lk_ccllc_transactionrequirementwaiverrole_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactionrequirementwaiverrole>("lk_ccllc_transactionrequirementwaiverrole_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactionrequirementwaiverrole_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_transactionrequirementwaiverrole>("lk_ccllc_transactionrequirementwaiverrole_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactionrequirementwaiverrole_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactionrequirementwaiverrole_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactionrequirementwaiverrole_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactionrequirementwaiverrole> lk_ccllc_transactionrequirementwaiverrole_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactionrequirementwaiverrole>("lk_ccllc_transactionrequirementwaiverrole_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactionrequirementwaiverrole_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_transactionrequirementwaiverrole>("lk_ccllc_transactionrequirementwaiverrole_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactionrequirementwaiverrole_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactionrequirementwaiverrole_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactionrequirementwaiverrole_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactionrequirementwaiverrole> lk_ccllc_transactionrequirementwaiverrole_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactionrequirementwaiverrole>("lk_ccllc_transactionrequirementwaiverrole_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactionrequirementwaiverrole_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_transactionrequirementwaiverrole>("lk_ccllc_transactionrequirementwaiverrole_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactionrequirementwaiverrole_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactiontype_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactiontype_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiontype> lk_ccllc_transactiontype_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiontype>("lk_ccllc_transactiontype_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactiontype_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_transactiontype>("lk_ccllc_transactiontype_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactiontype_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactiontype_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactiontype_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiontype> lk_ccllc_transactiontype_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiontype>("lk_ccllc_transactiontype_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactiontype_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_transactiontype>("lk_ccllc_transactiontype_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactiontype_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactiontype_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactiontype_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiontype> lk_ccllc_transactiontype_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiontype>("lk_ccllc_transactiontype_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactiontype_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_transactiontype>("lk_ccllc_transactiontype_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactiontype_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactiontype_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactiontype_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiontype> lk_ccllc_transactiontype_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiontype>("lk_ccllc_transactiontype_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactiontype_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_transactiontype>("lk_ccllc_transactiontype_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactiontype_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactiontypeauthorizedchannel_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactiontypeauthorizedchannel_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiontypeauthorizedchannel> lk_ccllc_transactiontypeauthorizedchannel_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiontypeauthorizedchannel>("lk_ccllc_transactiontypeauthorizedchannel_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactiontypeauthorizedchannel_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_transactiontypeauthorizedchannel>("lk_ccllc_transactiontypeauthorizedchannel_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactiontypeauthorizedchannel_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactiontypeauthorizedchannel_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactiontypeauthorizedchannel_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiontypeauthorizedchannel> lk_ccllc_transactiontypeauthorizedchannel_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiontypeauthorizedchannel>("lk_ccllc_transactiontypeauthorizedchannel_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactiontypeauthorizedchannel_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_transactiontypeauthorizedchannel>("lk_ccllc_transactiontypeauthorizedchannel_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactiontypeauthorizedchannel_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactiontypeauthorizedchannel_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactiontypeauthorizedchannel_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiontypeauthorizedchannel> lk_ccllc_transactiontypeauthorizedchannel_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiontypeauthorizedchannel>("lk_ccllc_transactiontypeauthorizedchannel_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactiontypeauthorizedchannel_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_transactiontypeauthorizedchannel>("lk_ccllc_transactiontypeauthorizedchannel_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactiontypeauthorizedchannel_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactiontypeauthorizedchannel_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactiontypeauthorizedchannel_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiontypeauthorizedchannel> lk_ccllc_transactiontypeauthorizedchannel_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiontypeauthorizedchannel>("lk_ccllc_transactiontypeauthorizedchannel_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactiontypeauthorizedchannel_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_transactiontypeauthorizedchannel>("lk_ccllc_transactiontypeauthorizedchannel_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactiontypeauthorizedchannel_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactiontypeauthorizedrole_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactiontypeauthorizedrole_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiontypeauthorizedrole> lk_ccllc_transactiontypeauthorizedrole_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiontypeauthorizedrole>("lk_ccllc_transactiontypeauthorizedrole_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactiontypeauthorizedrole_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_transactiontypeauthorizedrole>("lk_ccllc_transactiontypeauthorizedrole_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactiontypeauthorizedrole_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactiontypeauthorizedrole_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactiontypeauthorizedrole_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiontypeauthorizedrole> lk_ccllc_transactiontypeauthorizedrole_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiontypeauthorizedrole>("lk_ccllc_transactiontypeauthorizedrole_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactiontypeauthorizedrole_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_transactiontypeauthorizedrole>("lk_ccllc_transactiontypeauthorizedrole_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactiontypeauthorizedrole_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactiontypeauthorizedrole_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactiontypeauthorizedrole_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiontypeauthorizedrole> lk_ccllc_transactiontypeauthorizedrole_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiontypeauthorizedrole>("lk_ccllc_transactiontypeauthorizedrole_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactiontypeauthorizedrole_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_transactiontypeauthorizedrole>("lk_ccllc_transactiontypeauthorizedrole_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactiontypeauthorizedrole_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactiontypeauthorizedrole_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactiontypeauthorizedrole_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiontypeauthorizedrole> lk_ccllc_transactiontypeauthorizedrole_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiontypeauthorizedrole>("lk_ccllc_transactiontypeauthorizedrole_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactiontypeauthorizedrole_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_transactiontypeauthorizedrole>("lk_ccllc_transactiontypeauthorizedrole_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactiontypeauthorizedrole_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactiontypecontext_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactiontypecontext_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiontypecontext> lk_ccllc_transactiontypecontext_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiontypecontext>("lk_ccllc_transactiontypecontext_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactiontypecontext_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_transactiontypecontext>("lk_ccllc_transactiontypecontext_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactiontypecontext_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactiontypecontext_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactiontypecontext_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiontypecontext> lk_ccllc_transactiontypecontext_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiontypecontext>("lk_ccllc_transactiontypecontext_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactiontypecontext_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_transactiontypecontext>("lk_ccllc_transactiontypecontext_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactiontypecontext_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactiontypecontext_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactiontypecontext_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiontypecontext> lk_ccllc_transactiontypecontext_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiontypecontext>("lk_ccllc_transactiontypecontext_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactiontypecontext_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_transactiontypecontext>("lk_ccllc_transactiontypecontext_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactiontypecontext_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_transactiontypecontext_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_transactiontypecontext_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiontypecontext> lk_ccllc_transactiontypecontext_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiontypecontext>("lk_ccllc_transactiontypecontext_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_transactiontypecontext_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_transactiontypecontext>("lk_ccllc_transactiontypecontext_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_transactiontypecontext_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_worksession_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_worksession_createdby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_worksession> lk_ccllc_worksession_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_worksession>("lk_ccllc_worksession_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_worksession_createdby");
				this.SetRelatedEntities<TestProxy.ccllc_worksession>("lk_ccllc_worksession_createdby", null, value);
				this.OnPropertyChanged("lk_ccllc_worksession_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_worksession_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_worksession_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_worksession> lk_ccllc_worksession_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_worksession>("lk_ccllc_worksession_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_worksession_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_worksession>("lk_ccllc_worksession_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_worksession_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_worksession_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_worksession_modifiedby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_worksession> lk_ccllc_worksession_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_worksession>("lk_ccllc_worksession_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_worksession_modifiedby");
				this.SetRelatedEntities<TestProxy.ccllc_worksession>("lk_ccllc_worksession_modifiedby", null, value);
				this.OnPropertyChanged("lk_ccllc_worksession_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N lk_ccllc_worksession_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ccllc_worksession_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_worksession> lk_ccllc_worksession_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_worksession>("lk_ccllc_worksession_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ccllc_worksession_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.ccllc_worksession>("lk_ccllc_worksession_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ccllc_worksession_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_systemuser_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<TestProxy.SystemUser> Referencedlk_systemuser_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.SystemUser>("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedlk_systemuser_createdonbehalfby");
				this.SetRelatedEntities<TestProxy.SystemUser>("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedlk_systemuser_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_systemuser_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<TestProxy.SystemUser> Referencedlk_systemuser_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.SystemUser>("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedlk_systemuser_modifiedonbehalfby");
				this.SetRelatedEntities<TestProxy.SystemUser>("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedlk_systemuser_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// 1:N lk_systemuserbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<TestProxy.SystemUser> Referencedlk_systemuserbase_createdby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.SystemUser>("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedlk_systemuserbase_createdby");
				this.SetRelatedEntities<TestProxy.SystemUser>("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedlk_systemuserbase_createdby");
			}
		}
		
		/// <summary>
		/// 1:N lk_systemuserbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<TestProxy.SystemUser> Referencedlk_systemuserbase_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.SystemUser>("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedlk_systemuserbase_modifiedby");
				this.SetRelatedEntities<TestProxy.SystemUser>("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedlk_systemuserbase_modifiedby");
			}
		}
		
		/// <summary>
		/// 1:N ccllc_systemuser_assignedagent
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_systemuser_assignedagent")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_agent> ccllc_systemuser_assignedagent
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_agent>("ccllc_systemuser_assignedagent", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_systemuser_assignedagent");
				this.SetRelatedEntities<TestProxy.ccllc_agent>("ccllc_systemuser_assignedagent", null, value);
				this.OnPropertyChanged("ccllc_systemuser_assignedagent");
			}
		}
		
		/// <summary>
		/// 1:N system_user_accounts
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_accounts")]
		public System.Collections.Generic.IEnumerable<TestProxy.Account> system_user_accounts
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.Account>("system_user_accounts", null);
			}
			set
			{
				this.OnPropertyChanging("system_user_accounts");
				this.SetRelatedEntities<TestProxy.Account>("system_user_accounts", null, value);
				this.OnPropertyChanged("system_user_accounts");
			}
		}
		
		/// <summary>
		/// 1:N system_user_contacts
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_contacts")]
		public System.Collections.Generic.IEnumerable<TestProxy.Contact> system_user_contacts
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.Contact>("system_user_contacts", null);
			}
			set
			{
				this.OnPropertyChanging("system_user_contacts");
				this.SetRelatedEntities<TestProxy.Contact>("system_user_contacts", null, value);
				this.OnPropertyChanged("system_user_contacts");
			}
		}
		
		/// <summary>
		/// 1:N user_accounts
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_accounts")]
		public System.Collections.Generic.IEnumerable<TestProxy.Account> user_accounts
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.Account>("user_accounts", null);
			}
			set
			{
				this.OnPropertyChanging("user_accounts");
				this.SetRelatedEntities<TestProxy.Account>("user_accounts", null, value);
				this.OnPropertyChanged("user_accounts");
			}
		}
		
		/// <summary>
		/// 1:N user_parent_user
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<TestProxy.SystemUser> Referenceduser_parent_user
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.SystemUser>("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referenceduser_parent_user");
				this.SetRelatedEntities<TestProxy.SystemUser>("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referenceduser_parent_user");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_agent
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_agent")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_agent> user_ccllc_agent
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_agent>("user_ccllc_agent", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_agent");
				this.SetRelatedEntities<TestProxy.ccllc_agent>("user_ccllc_agent", null, value);
				this.OnPropertyChanged("user_ccllc_agent");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_agentauthorizedcustomer
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_agentauthorizedcustomer")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_agentauthorizedcustomer> user_ccllc_agentauthorizedcustomer
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_agentauthorizedcustomer>("user_ccllc_agentauthorizedcustomer", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_agentauthorizedcustomer");
				this.SetRelatedEntities<TestProxy.ccllc_agentauthorizedcustomer>("user_ccllc_agentauthorizedcustomer", null, value);
				this.OnPropertyChanged("user_ccllc_agentauthorizedcustomer");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_agentprohibitedcustomer
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_agentprohibitedcustomer")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_agentprohibitedcustomer> user_ccllc_agentprohibitedcustomer
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_agentprohibitedcustomer>("user_ccllc_agentprohibitedcustomer", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_agentprohibitedcustomer");
				this.SetRelatedEntities<TestProxy.ccllc_agentprohibitedcustomer>("user_ccllc_agentprohibitedcustomer", null, value);
				this.OnPropertyChanged("user_ccllc_agentprohibitedcustomer");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_agentrole
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_agentrole")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_agentrole> user_ccllc_agentrole
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_agentrole>("user_ccllc_agentrole", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_agentrole");
				this.SetRelatedEntities<TestProxy.ccllc_agentrole>("user_ccllc_agentrole", null, value);
				this.OnPropertyChanged("user_ccllc_agentrole");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_alternatebranch
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_alternatebranch")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_alternatebranch> user_ccllc_alternatebranch
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_alternatebranch>("user_ccllc_alternatebranch", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_alternatebranch");
				this.SetRelatedEntities<TestProxy.ccllc_alternatebranch>("user_ccllc_alternatebranch", null, value);
				this.OnPropertyChanged("user_ccllc_alternatebranch");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_appliedfee
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_appliedfee")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_appliedfee> user_ccllc_appliedfee
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_appliedfee>("user_ccllc_appliedfee", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_appliedfee");
				this.SetRelatedEntities<TestProxy.ccllc_appliedfee>("user_ccllc_appliedfee", null, value);
				this.OnPropertyChanged("user_ccllc_appliedfee");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_channel
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_channel")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_channel> user_ccllc_channel
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_channel>("user_ccllc_channel", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_channel");
				this.SetRelatedEntities<TestProxy.ccllc_channel>("user_ccllc_channel", null, value);
				this.OnPropertyChanged("user_ccllc_channel");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_device
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_device")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_device> user_ccllc_device
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_device>("user_ccllc_device", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_device");
				this.SetRelatedEntities<TestProxy.ccllc_device>("user_ccllc_device", null, value);
				this.OnPropertyChanged("user_ccllc_device");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_evaluatortype
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_evaluatortype")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_evaluatortype> user_ccllc_evaluatortype
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_evaluatortype>("user_ccllc_evaluatortype", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_evaluatortype");
				this.SetRelatedEntities<TestProxy.ccllc_evaluatortype>("user_ccllc_evaluatortype", null, value);
				this.OnPropertyChanged("user_ccllc_evaluatortype");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_fee
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_fee")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_fee> user_ccllc_fee
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_fee>("user_ccllc_fee", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_fee");
				this.SetRelatedEntities<TestProxy.ccllc_fee>("user_ccllc_fee", null, value);
				this.OnPropertyChanged("user_ccllc_fee");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_location
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_location")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_location> user_ccllc_location
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_location>("user_ccllc_location", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_location");
				this.SetRelatedEntities<TestProxy.ccllc_location>("user_ccllc_location", null, value);
				this.OnPropertyChanged("user_ccllc_location");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_partner
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_partner")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_partner> user_ccllc_partner
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_partner>("user_ccllc_partner", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_partner");
				this.SetRelatedEntities<TestProxy.ccllc_partner>("user_ccllc_partner", null, value);
				this.OnPropertyChanged("user_ccllc_partner");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_partnerworker
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_partnerworker")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_partnerworker> user_ccllc_partnerworker
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_partnerworker>("user_ccllc_partnerworker", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_partnerworker");
				this.SetRelatedEntities<TestProxy.ccllc_partnerworker>("user_ccllc_partnerworker", null, value);
				this.OnPropertyChanged("user_ccllc_partnerworker");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_processauthorizedchannel
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_processauthorizedchannel")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processauthorizedchannel> user_ccllc_processauthorizedchannel
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processauthorizedchannel>("user_ccllc_processauthorizedchannel", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_processauthorizedchannel");
				this.SetRelatedEntities<TestProxy.ccllc_processauthorizedchannel>("user_ccllc_processauthorizedchannel", null, value);
				this.OnPropertyChanged("user_ccllc_processauthorizedchannel");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_processstep
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_processstep")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processstep> user_ccllc_processstep
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processstep>("user_ccllc_processstep", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_processstep");
				this.SetRelatedEntities<TestProxy.ccllc_processstep>("user_ccllc_processstep", null, value);
				this.OnPropertyChanged("user_ccllc_processstep");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_processstepauthorizedchannel
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_processstepauthorizedchannel")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processstepauthorizedchannel> user_ccllc_processstepauthorizedchannel
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processstepauthorizedchannel>("user_ccllc_processstepauthorizedchannel", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_processstepauthorizedchannel");
				this.SetRelatedEntities<TestProxy.ccllc_processstepauthorizedchannel>("user_ccllc_processstepauthorizedchannel", null, value);
				this.OnPropertyChanged("user_ccllc_processstepauthorizedchannel");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_processsteprequirement
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_processsteprequirement")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processsteprequirement> user_ccllc_processsteprequirement
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processsteprequirement>("user_ccllc_processsteprequirement", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_processsteprequirement");
				this.SetRelatedEntities<TestProxy.ccllc_processsteprequirement>("user_ccllc_processsteprequirement", null, value);
				this.OnPropertyChanged("user_ccllc_processsteprequirement");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_processsteptype
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_processsteptype")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_processsteptype> user_ccllc_processsteptype
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_processsteptype>("user_ccllc_processsteptype", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_processsteptype");
				this.SetRelatedEntities<TestProxy.ccllc_processsteptype>("user_ccllc_processsteptype", null, value);
				this.OnPropertyChanged("user_ccllc_processsteptype");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_requirementwaiverrole
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_requirementwaiverrole")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_requirementwaiverrole> user_ccllc_requirementwaiverrole
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_requirementwaiverrole>("user_ccllc_requirementwaiverrole", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_requirementwaiverrole");
				this.SetRelatedEntities<TestProxy.ccllc_requirementwaiverrole>("user_ccllc_requirementwaiverrole", null, value);
				this.OnPropertyChanged("user_ccllc_requirementwaiverrole");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_role
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_role")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_role> user_ccllc_role
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_role>("user_ccllc_role", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_role");
				this.SetRelatedEntities<TestProxy.ccllc_role>("user_ccllc_role", null, value);
				this.OnPropertyChanged("user_ccllc_role");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_stephistory
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_stephistory")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_stephistory> user_ccllc_stephistory
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_stephistory>("user_ccllc_stephistory", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_stephistory");
				this.SetRelatedEntities<TestProxy.ccllc_stephistory>("user_ccllc_stephistory", null, value);
				this.OnPropertyChanged("user_ccllc_stephistory");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_transaction
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_transaction")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transaction> user_ccllc_transaction
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transaction>("user_ccllc_transaction", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_transaction");
				this.SetRelatedEntities<TestProxy.ccllc_transaction>("user_ccllc_transaction", null, value);
				this.OnPropertyChanged("user_ccllc_transaction");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_transactiongroup
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_transactiongroup")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiongroup> user_ccllc_transactiongroup
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiongroup>("user_ccllc_transactiongroup", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_transactiongroup");
				this.SetRelatedEntities<TestProxy.ccllc_transactiongroup>("user_ccllc_transactiongroup", null, value);
				this.OnPropertyChanged("user_ccllc_transactiongroup");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_transactioninitialfee
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_transactioninitialfee")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactioninitialfee> user_ccllc_transactioninitialfee
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactioninitialfee>("user_ccllc_transactioninitialfee", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_transactioninitialfee");
				this.SetRelatedEntities<TestProxy.ccllc_transactioninitialfee>("user_ccllc_transactioninitialfee", null, value);
				this.OnPropertyChanged("user_ccllc_transactioninitialfee");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_transactionprocess
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_transactionprocess")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactionprocess> user_ccllc_transactionprocess
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactionprocess>("user_ccllc_transactionprocess", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_transactionprocess");
				this.SetRelatedEntities<TestProxy.ccllc_transactionprocess>("user_ccllc_transactionprocess", null, value);
				this.OnPropertyChanged("user_ccllc_transactionprocess");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_transactionrequirement
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_transactionrequirement")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactionrequirement> user_ccllc_transactionrequirement
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactionrequirement>("user_ccllc_transactionrequirement", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_transactionrequirement");
				this.SetRelatedEntities<TestProxy.ccllc_transactionrequirement>("user_ccllc_transactionrequirement", null, value);
				this.OnPropertyChanged("user_ccllc_transactionrequirement");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_transactionrequirementwaiverrole
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_transactionrequirementwaiverrole")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactionrequirementwaiverrole> user_ccllc_transactionrequirementwaiverrole
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactionrequirementwaiverrole>("user_ccllc_transactionrequirementwaiverrole", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_transactionrequirementwaiverrole");
				this.SetRelatedEntities<TestProxy.ccllc_transactionrequirementwaiverrole>("user_ccllc_transactionrequirementwaiverrole", null, value);
				this.OnPropertyChanged("user_ccllc_transactionrequirementwaiverrole");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_transactiontype
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_transactiontype")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiontype> user_ccllc_transactiontype
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiontype>("user_ccllc_transactiontype", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_transactiontype");
				this.SetRelatedEntities<TestProxy.ccllc_transactiontype>("user_ccllc_transactiontype", null, value);
				this.OnPropertyChanged("user_ccllc_transactiontype");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_transactiontypeauthorizedchannel
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_transactiontypeauthorizedchannel")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiontypeauthorizedchannel> user_ccllc_transactiontypeauthorizedchannel
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiontypeauthorizedchannel>("user_ccllc_transactiontypeauthorizedchannel", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_transactiontypeauthorizedchannel");
				this.SetRelatedEntities<TestProxy.ccllc_transactiontypeauthorizedchannel>("user_ccllc_transactiontypeauthorizedchannel", null, value);
				this.OnPropertyChanged("user_ccllc_transactiontypeauthorizedchannel");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_transactiontypeauthorizedrole
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_transactiontypeauthorizedrole")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiontypeauthorizedrole> user_ccllc_transactiontypeauthorizedrole
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiontypeauthorizedrole>("user_ccllc_transactiontypeauthorizedrole", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_transactiontypeauthorizedrole");
				this.SetRelatedEntities<TestProxy.ccllc_transactiontypeauthorizedrole>("user_ccllc_transactiontypeauthorizedrole", null, value);
				this.OnPropertyChanged("user_ccllc_transactiontypeauthorizedrole");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_transactiontypecontext
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_transactiontypecontext")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_transactiontypecontext> user_ccllc_transactiontypecontext
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_transactiontypecontext>("user_ccllc_transactiontypecontext", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_transactiontypecontext");
				this.SetRelatedEntities<TestProxy.ccllc_transactiontypecontext>("user_ccllc_transactiontypecontext", null, value);
				this.OnPropertyChanged("user_ccllc_transactiontypecontext");
			}
		}
		
		/// <summary>
		/// 1:N user_ccllc_worksession
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ccllc_worksession")]
		public System.Collections.Generic.IEnumerable<TestProxy.ccllc_worksession> user_ccllc_worksession
		{
			get
			{
				return this.GetRelatedEntities<TestProxy.ccllc_worksession>("user_ccllc_worksession", null);
			}
			set
			{
				this.OnPropertyChanging("user_ccllc_worksession");
				this.SetRelatedEntities<TestProxy.ccllc_worksession>("user_ccllc_worksession", null, value);
				this.OnPropertyChanged("user_ccllc_worksession");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_system_users
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_system_users")]
		public TestProxy.BusinessUnit business_unit_system_users
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.BusinessUnit>("business_unit_system_users", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_system_users");
				this.SetRelatedEntity<TestProxy.BusinessUnit>("business_unit_system_users", null, value);
				this.OnPropertyChanged("business_unit_system_users");
			}
		}
		
		/// <summary>
		/// N:1 lk_systemuser_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public TestProxy.SystemUser Referencinglk_systemuser_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
		}
		
		/// <summary>
		/// N:1 lk_systemuser_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public TestProxy.SystemUser Referencinglk_systemuser_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
		}
		
		/// <summary>
		/// N:1 lk_systemuserbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public TestProxy.SystemUser Referencinglk_systemuserbase_createdby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
		}
		
		/// <summary>
		/// N:1 lk_systemuserbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public TestProxy.SystemUser Referencinglk_systemuserbase_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
		}
		
		/// <summary>
		/// N:1 user_parent_user
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentsystemuserid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public TestProxy.SystemUser Referencinguser_parent_user
		{
			get
			{
				return this.GetRelatedEntity<TestProxy.SystemUser>("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			set
			{
				this.OnPropertyChanging("Referencinguser_parent_user");
				this.SetRelatedEntity<TestProxy.SystemUser>("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
				this.OnPropertyChanged("Referencinguser_parent_user");
			}
		}
	}
}
