namespace CCLLC.BTF.Platform.CDS
{

	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("contact")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class Contact : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public Contact() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "contact";
		
		public const int EntityTypeCode = 2;
		
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
		/// Unique identifier of the account with which the contact is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
		public Microsoft.Xrm.Sdk.EntityReference AccountId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("accountid");
			}
		}
		
		/// <summary>
		/// Select the contact's role within the company or sales process, such as decision maker, employee, or influencer.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountrolecode")]
		public System.Nullable<CCLLC.BTF.Platform.CDS.contact_accountrolecode> AccountRoleCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("accountrolecode");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Platform.CDS.contact_accountrolecode)(System.Enum.ToObject(typeof(CCLLC.BTF.Platform.CDS.contact_accountrolecode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("AccountRoleCode");
				if ((value == null))
				{
					this.SetAttributeValue("accountrolecode", null);
				}
				else
				{
					this.SetAttributeValue("accountrolecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("AccountRoleCode");
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
		/// Select the primary address type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addresstypecode")]
		public System.Nullable<CCLLC.BTF.Platform.CDS.contact_address1_addresstypecode> Address1_AddressTypeCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_addresstypecode");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Platform.CDS.contact_address1_addresstypecode)(System.Enum.ToObject(typeof(CCLLC.BTF.Platform.CDS.contact_address1_addresstypecode), optionSet.Value)));
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
		/// Type the city for the primary address.
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
		/// Type the country or region for the primary address.
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
		/// Type the county for the primary address.
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
		/// Type the fax number associated with the primary address.
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
		/// Select the freight terms for the primary address to make sure shipping orders are processed correctly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_freighttermscode")]
		public System.Nullable<CCLLC.BTF.Platform.CDS.contact_address1_freighttermscode> Address1_FreightTermsCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_freighttermscode");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Platform.CDS.contact_address1_freighttermscode)(System.Enum.ToObject(typeof(CCLLC.BTF.Platform.CDS.contact_address1_freighttermscode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("Address1_FreightTermsCode");
				if ((value == null))
				{
					this.SetAttributeValue("address1_freighttermscode", null);
				}
				else
				{
					this.SetAttributeValue("address1_freighttermscode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("Address1_FreightTermsCode");
			}
		}
		
		/// <summary>
		/// Type the latitude value for the primary address for use in mapping and other applications.
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
		/// Type the first line of the primary address.
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
		/// Type the second line of the primary address.
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
		/// Type the third line of the primary address.
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
		/// Type the longitude value for the primary address for use in mapping and other applications.
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
		/// Type a descriptive name for the primary address, such as Corporate Headquarters.
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
		/// Type the ZIP Code or postal code for the primary address.
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
		/// Type the post office box number of the primary address.
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
		/// Type the name of the main contact at the account's primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_primarycontactname")]
		public string Address1_PrimaryContactName
		{
			get
			{
				return this.GetAttributeValue<string>("address1_primarycontactname");
			}
			set
			{
				this.OnPropertyChanging("Address1_PrimaryContactName");
				this.SetAttributeValue("address1_primarycontactname", value);
				this.OnPropertyChanged("Address1_PrimaryContactName");
			}
		}
		
		/// <summary>
		/// Select a shipping method for deliveries sent to this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_shippingmethodcode")]
		public System.Nullable<CCLLC.BTF.Platform.CDS.contact_address1_shippingmethodcode> Address1_ShippingMethodCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_shippingmethodcode");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Platform.CDS.contact_address1_shippingmethodcode)(System.Enum.ToObject(typeof(CCLLC.BTF.Platform.CDS.contact_address1_shippingmethodcode), optionSet.Value)));
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
		/// Type the state or province of the primary address.
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
		/// Type the main phone number associated with the primary address.
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
		/// Type a second phone number associated with the primary address.
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
		/// Type a third phone number associated with the primary address.
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
		/// Type the UPS zone of the primary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.
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
		/// Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.
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
		/// Select the secondary address type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addresstypecode")]
		public System.Nullable<CCLLC.BTF.Platform.CDS.contact_address2_addresstypecode> Address2_AddressTypeCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_addresstypecode");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Platform.CDS.contact_address2_addresstypecode)(System.Enum.ToObject(typeof(CCLLC.BTF.Platform.CDS.contact_address2_addresstypecode), optionSet.Value)));
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
		/// Type the city for the secondary address.
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
		/// Type the country or region for the secondary address.
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
		/// Type the county for the secondary address.
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
		/// Type the fax number associated with the secondary address.
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
		/// Select the freight terms for the secondary address to make sure shipping orders are processed correctly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_freighttermscode")]
		public System.Nullable<CCLLC.BTF.Platform.CDS.contact_address2_freighttermscode> Address2_FreightTermsCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_freighttermscode");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Platform.CDS.contact_address2_freighttermscode)(System.Enum.ToObject(typeof(CCLLC.BTF.Platform.CDS.contact_address2_freighttermscode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("Address2_FreightTermsCode");
				if ((value == null))
				{
					this.SetAttributeValue("address2_freighttermscode", null);
				}
				else
				{
					this.SetAttributeValue("address2_freighttermscode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("Address2_FreightTermsCode");
			}
		}
		
		/// <summary>
		/// Type the latitude value for the secondary address for use in mapping and other applications.
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
		/// Type the first line of the secondary address.
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
		/// Type the second line of the secondary address.
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
		/// Type the third line of the secondary address.
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
		/// Type the longitude value for the secondary address for use in mapping and other applications.
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
		/// Type a descriptive name for the secondary address, such as Corporate Headquarters.
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
		/// Type the ZIP Code or postal code for the secondary address.
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
		/// Type the post office box number of the secondary address.
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
		/// Type the name of the main contact at the account's secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_primarycontactname")]
		public string Address2_PrimaryContactName
		{
			get
			{
				return this.GetAttributeValue<string>("address2_primarycontactname");
			}
			set
			{
				this.OnPropertyChanging("Address2_PrimaryContactName");
				this.SetAttributeValue("address2_primarycontactname", value);
				this.OnPropertyChanged("Address2_PrimaryContactName");
			}
		}
		
		/// <summary>
		/// Select a shipping method for deliveries sent to this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_shippingmethodcode")]
		public System.Nullable<CCLLC.BTF.Platform.CDS.contact_address2_shippingmethodcode> Address2_ShippingMethodCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_shippingmethodcode");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Platform.CDS.contact_address2_shippingmethodcode)(System.Enum.ToObject(typeof(CCLLC.BTF.Platform.CDS.contact_address2_shippingmethodcode), optionSet.Value)));
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
		/// Type the state or province of the secondary address.
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
		/// Type the main phone number associated with the secondary address.
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
		/// Type a second phone number associated with the secondary address.
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
		/// Type a third phone number associated with the secondary address.
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
		/// Type the UPS zone of the secondary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.
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
		/// Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.
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
		/// Unique identifier for address 3.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addresccllc_addressid")]
		public System.Nullable<System.Guid> Addresccllc_AddressId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("addresccllc_addressid");
			}
			set
			{
				this.OnPropertyChanging("Addresccllc_AddressId");
				this.SetAttributeValue("addresccllc_addressid", value);
				this.OnPropertyChanged("Addresccllc_AddressId");
			}
		}
		
		/// <summary>
		/// Select the third address type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addresccllc_addresstypecode")]
		public System.Nullable<CCLLC.BTF.Platform.CDS.contact_addresccllc_addresstypecode> Addresccllc_AddressTypeCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("addresccllc_addresstypecode");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Platform.CDS.contact_addresccllc_addresstypecode)(System.Enum.ToObject(typeof(CCLLC.BTF.Platform.CDS.contact_addresccllc_addresstypecode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("Addresccllc_AddressTypeCode");
				if ((value == null))
				{
					this.SetAttributeValue("addresccllc_addresstypecode", null);
				}
				else
				{
					this.SetAttributeValue("addresccllc_addresstypecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("Addresccllc_AddressTypeCode");
			}
		}
		
		/// <summary>
		/// Type the city for the 3rd address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addresccllc_city")]
		public string Addresccllc_City
		{
			get
			{
				return this.GetAttributeValue<string>("addresccllc_city");
			}
			set
			{
				this.OnPropertyChanging("Addresccllc_City");
				this.SetAttributeValue("addresccllc_city", value);
				this.OnPropertyChanged("Addresccllc_City");
			}
		}
		
		/// <summary>
		/// Shows the complete third address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addresccllc_composite")]
		public string Addresccllc_Composite
		{
			get
			{
				return this.GetAttributeValue<string>("addresccllc_composite");
			}
		}
		
		/// <summary>
		/// the country or region for the 3rd address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addresccllc_country")]
		public string Addresccllc_Country
		{
			get
			{
				return this.GetAttributeValue<string>("addresccllc_country");
			}
			set
			{
				this.OnPropertyChanging("Addresccllc_Country");
				this.SetAttributeValue("addresccllc_country", value);
				this.OnPropertyChanged("Addresccllc_Country");
			}
		}
		
		/// <summary>
		/// Type the county for the third address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addresccllc_county")]
		public string Addresccllc_County
		{
			get
			{
				return this.GetAttributeValue<string>("addresccllc_county");
			}
			set
			{
				this.OnPropertyChanging("Addresccllc_County");
				this.SetAttributeValue("addresccllc_county", value);
				this.OnPropertyChanged("Addresccllc_County");
			}
		}
		
		/// <summary>
		/// Type the fax number associated with the third address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addresccllc_fax")]
		public string Addresccllc_Fax
		{
			get
			{
				return this.GetAttributeValue<string>("addresccllc_fax");
			}
			set
			{
				this.OnPropertyChanging("Addresccllc_Fax");
				this.SetAttributeValue("addresccllc_fax", value);
				this.OnPropertyChanged("Addresccllc_Fax");
			}
		}
		
		/// <summary>
		/// Select the freight terms for the third address to make sure shipping orders are processed correctly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addresccllc_freighttermscode")]
		public System.Nullable<CCLLC.BTF.Platform.CDS.contact_addresccllc_freighttermscode> Addresccllc_FreightTermsCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("addresccllc_freighttermscode");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Platform.CDS.contact_addresccllc_freighttermscode)(System.Enum.ToObject(typeof(CCLLC.BTF.Platform.CDS.contact_addresccllc_freighttermscode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("Addresccllc_FreightTermsCode");
				if ((value == null))
				{
					this.SetAttributeValue("addresccllc_freighttermscode", null);
				}
				else
				{
					this.SetAttributeValue("addresccllc_freighttermscode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("Addresccllc_FreightTermsCode");
			}
		}
		
		/// <summary>
		/// Type the latitude value for the third address for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addresccllc_latitude")]
		public System.Nullable<double> Addresccllc_Latitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("addresccllc_latitude");
			}
			set
			{
				this.OnPropertyChanging("Addresccllc_Latitude");
				this.SetAttributeValue("addresccllc_latitude", value);
				this.OnPropertyChanged("Addresccllc_Latitude");
			}
		}
		
		/// <summary>
		/// the first line of the 3rd address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addresccllc_line1")]
		public string Addresccllc_Line1
		{
			get
			{
				return this.GetAttributeValue<string>("addresccllc_line1");
			}
			set
			{
				this.OnPropertyChanging("Addresccllc_Line1");
				this.SetAttributeValue("addresccllc_line1", value);
				this.OnPropertyChanged("Addresccllc_Line1");
			}
		}
		
		/// <summary>
		/// the second line of the 3rd address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addresccllc_line2")]
		public string Addresccllc_Line2
		{
			get
			{
				return this.GetAttributeValue<string>("addresccllc_line2");
			}
			set
			{
				this.OnPropertyChanging("Addresccllc_Line2");
				this.SetAttributeValue("addresccllc_line2", value);
				this.OnPropertyChanged("Addresccllc_Line2");
			}
		}
		
		/// <summary>
		/// the third line of the 3rd address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addresccllc_line3")]
		public string Addresccllc_Line3
		{
			get
			{
				return this.GetAttributeValue<string>("addresccllc_line3");
			}
			set
			{
				this.OnPropertyChanging("Addresccllc_Line3");
				this.SetAttributeValue("addresccllc_line3", value);
				this.OnPropertyChanged("Addresccllc_Line3");
			}
		}
		
		/// <summary>
		/// Type the longitude value for the third address for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addresccllc_longitude")]
		public System.Nullable<double> Addresccllc_Longitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("addresccllc_longitude");
			}
			set
			{
				this.OnPropertyChanging("Addresccllc_Longitude");
				this.SetAttributeValue("addresccllc_longitude", value);
				this.OnPropertyChanged("Addresccllc_Longitude");
			}
		}
		
		/// <summary>
		/// Type a descriptive name for the third address, such as Corporate Headquarters.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addresccllc_name")]
		public string Addresccllc_Name
		{
			get
			{
				return this.GetAttributeValue<string>("addresccllc_name");
			}
			set
			{
				this.OnPropertyChanging("Addresccllc_Name");
				this.SetAttributeValue("addresccllc_name", value);
				this.OnPropertyChanged("Addresccllc_Name");
			}
		}
		
		/// <summary>
		/// the ZIP Code or postal code for the 3rd address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addresccllc_postalcode")]
		public string Addresccllc_PostalCode
		{
			get
			{
				return this.GetAttributeValue<string>("addresccllc_postalcode");
			}
			set
			{
				this.OnPropertyChanging("Addresccllc_PostalCode");
				this.SetAttributeValue("addresccllc_postalcode", value);
				this.OnPropertyChanged("Addresccllc_PostalCode");
			}
		}
		
		/// <summary>
		/// the post office box number of the 3rd address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addresccllc_postofficebox")]
		public string Addresccllc_PostOfficeBox
		{
			get
			{
				return this.GetAttributeValue<string>("addresccllc_postofficebox");
			}
			set
			{
				this.OnPropertyChanging("Addresccllc_PostOfficeBox");
				this.SetAttributeValue("addresccllc_postofficebox", value);
				this.OnPropertyChanged("Addresccllc_PostOfficeBox");
			}
		}
		
		/// <summary>
		/// Type the name of the main contact at the account's third address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addresccllc_primarycontactname")]
		public string Addresccllc_PrimaryContactName
		{
			get
			{
				return this.GetAttributeValue<string>("addresccllc_primarycontactname");
			}
			set
			{
				this.OnPropertyChanging("Addresccllc_PrimaryContactName");
				this.SetAttributeValue("addresccllc_primarycontactname", value);
				this.OnPropertyChanged("Addresccllc_PrimaryContactName");
			}
		}
		
		/// <summary>
		/// Select a shipping method for deliveries sent to this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addresccllc_shippingmethodcode")]
		public System.Nullable<CCLLC.BTF.Platform.CDS.contact_addresccllc_shippingmethodcode> Addresccllc_ShippingMethodCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("addresccllc_shippingmethodcode");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Platform.CDS.contact_addresccllc_shippingmethodcode)(System.Enum.ToObject(typeof(CCLLC.BTF.Platform.CDS.contact_addresccllc_shippingmethodcode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("Addresccllc_ShippingMethodCode");
				if ((value == null))
				{
					this.SetAttributeValue("addresccllc_shippingmethodcode", null);
				}
				else
				{
					this.SetAttributeValue("addresccllc_shippingmethodcode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("Addresccllc_ShippingMethodCode");
			}
		}
		
		/// <summary>
		/// the state or province of the third address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addresccllc_stateorprovince")]
		public string Addresccllc_StateOrProvince
		{
			get
			{
				return this.GetAttributeValue<string>("addresccllc_stateorprovince");
			}
			set
			{
				this.OnPropertyChanging("Addresccllc_StateOrProvince");
				this.SetAttributeValue("addresccllc_stateorprovince", value);
				this.OnPropertyChanged("Addresccllc_StateOrProvince");
			}
		}
		
		/// <summary>
		/// Type the main phone number associated with the third address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addresccllc_telephone1")]
		public string Addresccllc_Telephone1
		{
			get
			{
				return this.GetAttributeValue<string>("addresccllc_telephone1");
			}
			set
			{
				this.OnPropertyChanging("Addresccllc_Telephone1");
				this.SetAttributeValue("addresccllc_telephone1", value);
				this.OnPropertyChanged("Addresccllc_Telephone1");
			}
		}
		
		/// <summary>
		/// Type a second phone number associated with the third address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addresccllc_telephone2")]
		public string Addresccllc_Telephone2
		{
			get
			{
				return this.GetAttributeValue<string>("addresccllc_telephone2");
			}
			set
			{
				this.OnPropertyChanging("Addresccllc_Telephone2");
				this.SetAttributeValue("addresccllc_telephone2", value);
				this.OnPropertyChanged("Addresccllc_Telephone2");
			}
		}
		
		/// <summary>
		/// Type a third phone number associated with the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addresccllc_telephone3")]
		public string Addresccllc_Telephone3
		{
			get
			{
				return this.GetAttributeValue<string>("addresccllc_telephone3");
			}
			set
			{
				this.OnPropertyChanging("Addresccllc_Telephone3");
				this.SetAttributeValue("addresccllc_telephone3", value);
				this.OnPropertyChanged("Addresccllc_Telephone3");
			}
		}
		
		/// <summary>
		/// Type the UPS zone of the third address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addresccllc_upszone")]
		public string Addresccllc_UPSZone
		{
			get
			{
				return this.GetAttributeValue<string>("addresccllc_upszone");
			}
			set
			{
				this.OnPropertyChanging("Addresccllc_UPSZone");
				this.SetAttributeValue("addresccllc_upszone", value);
				this.OnPropertyChanged("Addresccllc_UPSZone");
			}
		}
		
		/// <summary>
		/// Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addresccllc_utcoffset")]
		public System.Nullable<int> Addresccllc_UTCOffset
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("addresccllc_utcoffset");
			}
			set
			{
				this.OnPropertyChanging("Addresccllc_UTCOffset");
				this.SetAttributeValue("addresccllc_utcoffset", value);
				this.OnPropertyChanged("Addresccllc_UTCOffset");
			}
		}
		
		/// <summary>
		/// For system use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging30")]
		public Microsoft.Xrm.Sdk.Money Aging30
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging30");
			}
		}
		
		/// <summary>
		/// Shows the Aging 30 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging30_base")]
		public Microsoft.Xrm.Sdk.Money Aging30_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging30_base");
			}
		}
		
		/// <summary>
		/// For system use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging60")]
		public Microsoft.Xrm.Sdk.Money Aging60
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging60");
			}
		}
		
		/// <summary>
		/// Shows the Aging 60 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging60_base")]
		public Microsoft.Xrm.Sdk.Money Aging60_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging60_base");
			}
		}
		
		/// <summary>
		/// For system use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging90")]
		public Microsoft.Xrm.Sdk.Money Aging90
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging90");
			}
		}
		
		/// <summary>
		/// Shows the Aging 90 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging90_base")]
		public Microsoft.Xrm.Sdk.Money Aging90_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging90_base");
			}
		}
		
		/// <summary>
		/// Enter the date of the contact's wedding or service anniversary for use in customer gift programs or other communications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("anniversary")]
		public System.Nullable<System.DateTime> Anniversary
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("anniversary");
			}
			set
			{
				this.OnPropertyChanging("Anniversary");
				this.SetAttributeValue("anniversary", value);
				this.OnPropertyChanged("Anniversary");
			}
		}
		
		/// <summary>
		/// Type the contact's annual income for use in profiling and financial analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("annualincome")]
		public Microsoft.Xrm.Sdk.Money AnnualIncome
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("annualincome");
			}
			set
			{
				this.OnPropertyChanging("AnnualIncome");
				this.SetAttributeValue("annualincome", value);
				this.OnPropertyChanged("AnnualIncome");
			}
		}
		
		/// <summary>
		/// Shows the Annual Income field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("annualincome_base")]
		public Microsoft.Xrm.Sdk.Money AnnualIncome_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("annualincome_base");
			}
		}
		
		/// <summary>
		/// Type the name of the contact's assistant.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("assistantname")]
		public string AssistantName
		{
			get
			{
				return this.GetAttributeValue<string>("assistantname");
			}
			set
			{
				this.OnPropertyChanging("AssistantName");
				this.SetAttributeValue("assistantname", value);
				this.OnPropertyChanged("AssistantName");
			}
		}
		
		/// <summary>
		/// Type the phone number for the contact's assistant.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("assistantphone")]
		public string AssistantPhone
		{
			get
			{
				return this.GetAttributeValue<string>("assistantphone");
			}
			set
			{
				this.OnPropertyChanging("AssistantPhone");
				this.SetAttributeValue("assistantphone", value);
				this.OnPropertyChanged("AssistantPhone");
			}
		}
		
		/// <summary>
		/// Enter the contact's birthday for use in customer gift programs or other communications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("birthdate")]
		public System.Nullable<System.DateTime> BirthDate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("birthdate");
			}
			set
			{
				this.OnPropertyChanging("BirthDate");
				this.SetAttributeValue("birthdate", value);
				this.OnPropertyChanged("BirthDate");
			}
		}
		
		/// <summary>
		/// Type a second business phone number for this contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("business2")]
		public string Business2
		{
			get
			{
				return this.GetAttributeValue<string>("business2");
			}
			set
			{
				this.OnPropertyChanging("Business2");
				this.SetAttributeValue("business2", value);
				this.OnPropertyChanged("Business2");
			}
		}
		
		/// <summary>
		/// Type a callback phone number for this contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("callback")]
		public string Callback
		{
			get
			{
				return this.GetAttributeValue<string>("callback");
			}
			set
			{
				this.OnPropertyChanging("Callback");
				this.SetAttributeValue("callback", value);
				this.OnPropertyChanged("Callback");
			}
		}
		
		/// <summary>
		/// Type the names of the contact's children for reference in communications and client programs.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("childrensnames")]
		public string ChildrensNames
		{
			get
			{
				return this.GetAttributeValue<string>("childrensnames");
			}
			set
			{
				this.OnPropertyChanging("ChildrensNames");
				this.SetAttributeValue("childrensnames", value);
				this.OnPropertyChanged("ChildrensNames");
			}
		}
		
		/// <summary>
		/// Type the company phone of the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("company")]
		public string Company
		{
			get
			{
				return this.GetAttributeValue<string>("company");
			}
			set
			{
				this.OnPropertyChanging("Company");
				this.SetAttributeValue("company", value);
				this.OnPropertyChanged("Company");
			}
		}
		
		/// <summary>
		/// Unique identifier of the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactid")]
		public System.Nullable<System.Guid> ContactId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("contactid");
			}
			set
			{
				this.OnPropertyChanging("ContactId");
				this.SetAttributeValue("contactid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ContactId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.ContactId = value;
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
		/// Shows the external party who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdbyexternalparty")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedByExternalParty
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdbyexternalparty");
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
		/// Type the credit limit of the contact for reference when you address invoice and accounting issues with the customer.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditlimit")]
		public Microsoft.Xrm.Sdk.Money CreditLimit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("creditlimit");
			}
			set
			{
				this.OnPropertyChanging("CreditLimit");
				this.SetAttributeValue("creditlimit", value);
				this.OnPropertyChanged("CreditLimit");
			}
		}
		
		/// <summary>
		/// Shows the Credit Limit field converted to the system's default base currency for reporting purposes. The calculations use the exchange rate specified in the Currencies area.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditlimit_base")]
		public Microsoft.Xrm.Sdk.Money CreditLimit_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("creditlimit_base");
			}
		}
		
		/// <summary>
		/// Select whether the contact is on a credit hold, for reference when addressing invoice and accounting issues.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditonhold")]
		public System.Nullable<bool> CreditOnHold
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("creditonhold");
			}
			set
			{
				this.OnPropertyChanging("CreditOnHold");
				this.SetAttributeValue("creditonhold", value);
				this.OnPropertyChanged("CreditOnHold");
			}
		}
		
		/// <summary>
		/// Select the size of the contact's company for segmentation and reporting purposes.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customersizecode")]
		public System.Nullable<CCLLC.BTF.Platform.CDS.contact_customersizecode> CustomerSizeCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("customersizecode");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Platform.CDS.contact_customersizecode)(System.Enum.ToObject(typeof(CCLLC.BTF.Platform.CDS.contact_customersizecode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("CustomerSizeCode");
				if ((value == null))
				{
					this.SetAttributeValue("customersizecode", null);
				}
				else
				{
					this.SetAttributeValue("customersizecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("CustomerSizeCode");
			}
		}
		
		/// <summary>
		/// Select the category that best describes the relationship between the contact and your organization.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customertypecode")]
		public System.Nullable<CCLLC.BTF.Platform.CDS.contact_customertypecode> CustomerTypeCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("customertypecode");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Platform.CDS.contact_customertypecode)(System.Enum.ToObject(typeof(CCLLC.BTF.Platform.CDS.contact_customertypecode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("CustomerTypeCode");
				if ((value == null))
				{
					this.SetAttributeValue("customertypecode", null);
				}
				else
				{
					this.SetAttributeValue("customertypecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("CustomerTypeCode");
			}
		}
		
		/// <summary>
		/// Type the department or business unit where the contact works in the parent company or business.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("department")]
		public string Department
		{
			get
			{
				return this.GetAttributeValue<string>("department");
			}
			set
			{
				this.OnPropertyChanging("Department");
				this.SetAttributeValue("department", value);
				this.OnPropertyChanged("Department");
			}
		}
		
		/// <summary>
		/// Type additional information to describe the contact, such as an excerpt from the company's website.
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
		/// Select whether the contact accepts bulk email sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the contact can be added to marketing lists, but will be excluded from the email.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotbulkemail")]
		public System.Nullable<bool> DoNotBulkEMail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotbulkemail");
			}
			set
			{
				this.OnPropertyChanging("DoNotBulkEMail");
				this.SetAttributeValue("donotbulkemail", value);
				this.OnPropertyChanged("DoNotBulkEMail");
			}
		}
		
		/// <summary>
		/// Select whether the contact accepts bulk postal mail sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the contact can be added to marketing lists, but will be excluded from the letters.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotbulkpostalmail")]
		public System.Nullable<bool> DoNotBulkPostalMail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotbulkpostalmail");
			}
			set
			{
				this.OnPropertyChanging("DoNotBulkPostalMail");
				this.SetAttributeValue("donotbulkpostalmail", value);
				this.OnPropertyChanged("DoNotBulkPostalMail");
			}
		}
		
		/// <summary>
		/// Select whether the contact allows direct email sent from Microsoft Dynamics 365. If Do Not Allow is selected, Microsoft Dynamics 365 will not send the email.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotemail")]
		public System.Nullable<bool> DoNotEMail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotemail");
			}
			set
			{
				this.OnPropertyChanging("DoNotEMail");
				this.SetAttributeValue("donotemail", value);
				this.OnPropertyChanged("DoNotEMail");
			}
		}
		
		/// <summary>
		/// Select whether the contact allows faxes. If Do Not Allow is selected, the contact will be excluded from any fax activities distributed in marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotfax")]
		public System.Nullable<bool> DoNotFax
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotfax");
			}
			set
			{
				this.OnPropertyChanging("DoNotFax");
				this.SetAttributeValue("donotfax", value);
				this.OnPropertyChanged("DoNotFax");
			}
		}
		
		/// <summary>
		/// Select whether the contact accepts phone calls. If Do Not Allow is selected, the contact will be excluded from any phone call activities distributed in marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotphone")]
		public System.Nullable<bool> DoNotPhone
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotphone");
			}
			set
			{
				this.OnPropertyChanging("DoNotPhone");
				this.SetAttributeValue("donotphone", value);
				this.OnPropertyChanged("DoNotPhone");
			}
		}
		
		/// <summary>
		/// Select whether the contact allows direct mail. If Do Not Allow is selected, the contact will be excluded from letter activities distributed in marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotpostalmail")]
		public System.Nullable<bool> DoNotPostalMail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotpostalmail");
			}
			set
			{
				this.OnPropertyChanging("DoNotPostalMail");
				this.SetAttributeValue("donotpostalmail", value);
				this.OnPropertyChanged("DoNotPostalMail");
			}
		}
		
		/// <summary>
		/// Select whether the contact accepts marketing materials, such as brochures or catalogs. Contacts that opt out can be excluded from marketing initiatives.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotsendmm")]
		public System.Nullable<bool> DoNotSendMM
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotsendmm");
			}
			set
			{
				this.OnPropertyChanging("DoNotSendMM");
				this.SetAttributeValue("donotsendmm", value);
				this.OnPropertyChanged("DoNotSendMM");
			}
		}
		
		/// <summary>
		/// Select the contact's highest level of education for use in segmentation and analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("educationcode")]
		public System.Nullable<CCLLC.BTF.Platform.CDS.contact_educationcode> EducationCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("educationcode");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Platform.CDS.contact_educationcode)(System.Enum.ToObject(typeof(CCLLC.BTF.Platform.CDS.contact_educationcode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("EducationCode");
				if ((value == null))
				{
					this.SetAttributeValue("educationcode", null);
				}
				else
				{
					this.SetAttributeValue("educationcode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("EducationCode");
			}
		}
		
		/// <summary>
		/// Type the primary email address for the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress1")]
		public string EMailAddress1
		{
			get
			{
				return this.GetAttributeValue<string>("emailaddress1");
			}
			set
			{
				this.OnPropertyChanging("EMailAddress1");
				this.SetAttributeValue("emailaddress1", value);
				this.OnPropertyChanged("EMailAddress1");
			}
		}
		
		/// <summary>
		/// Type the secondary email address for the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress2")]
		public string EMailAddress2
		{
			get
			{
				return this.GetAttributeValue<string>("emailaddress2");
			}
			set
			{
				this.OnPropertyChanging("EMailAddress2");
				this.SetAttributeValue("emailaddress2", value);
				this.OnPropertyChanged("EMailAddress2");
			}
		}
		
		/// <summary>
		/// Type an alternate email address for the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress3")]
		public string EMailAddress3
		{
			get
			{
				return this.GetAttributeValue<string>("emailaddress3");
			}
			set
			{
				this.OnPropertyChanging("EMailAddress3");
				this.SetAttributeValue("emailaddress3", value);
				this.OnPropertyChanged("EMailAddress3");
			}
		}
		
		/// <summary>
		/// Type the employee ID or number for the contact for reference in orders, service cases, or other communications with the contact's organization.
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
		/// Identifier for an external user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("externaluseridentifier")]
		public string ExternalUserIdentifier
		{
			get
			{
				return this.GetAttributeValue<string>("externaluseridentifier");
			}
			set
			{
				this.OnPropertyChanging("ExternalUserIdentifier");
				this.SetAttributeValue("externaluseridentifier", value);
				this.OnPropertyChanged("ExternalUserIdentifier");
			}
		}
		
		/// <summary>
		/// Select the marital status of the contact for reference in follow-up phone calls and other communications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("familystatuscode")]
		public System.Nullable<CCLLC.BTF.Platform.CDS.contact_familystatuscode> FamilyStatusCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("familystatuscode");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Platform.CDS.contact_familystatuscode)(System.Enum.ToObject(typeof(CCLLC.BTF.Platform.CDS.contact_familystatuscode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("FamilyStatusCode");
				if ((value == null))
				{
					this.SetAttributeValue("familystatuscode", null);
				}
				else
				{
					this.SetAttributeValue("familystatuscode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("FamilyStatusCode");
			}
		}
		
		/// <summary>
		/// Type the fax number for the contact.
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
		/// Type the contact's first name to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.
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
		/// Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("followemail")]
		public System.Nullable<bool> FollowEmail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("followemail");
			}
			set
			{
				this.OnPropertyChanging("FollowEmail");
				this.SetAttributeValue("followemail", value);
				this.OnPropertyChanged("FollowEmail");
			}
		}
		
		/// <summary>
		/// Type the URL for the contact's FTP site to enable users to access data and share documents.
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
		/// Combines and shows the contact's first and last names so that the full name can be displayed in views and reports.
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
		/// Select the contact's gender to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("gendercode")]
		public System.Nullable<CCLLC.BTF.Platform.CDS.contact_gendercode> GenderCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("gendercode");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Platform.CDS.contact_gendercode)(System.Enum.ToObject(typeof(CCLLC.BTF.Platform.CDS.contact_gendercode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("GenderCode");
				if ((value == null))
				{
					this.SetAttributeValue("gendercode", null);
				}
				else
				{
					this.SetAttributeValue("gendercode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("GenderCode");
			}
		}
		
		/// <summary>
		/// Type the passport number or other government ID for the contact for use in documents or reports.
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
		/// Select whether the contact has any children for reference in follow-up phone calls and other communications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("haschildrencode")]
		public System.Nullable<CCLLC.BTF.Platform.CDS.contact_haschildrencode> HasChildrenCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("haschildrencode");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Platform.CDS.contact_haschildrencode)(System.Enum.ToObject(typeof(CCLLC.BTF.Platform.CDS.contact_haschildrencode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("HasChildrenCode");
				if ((value == null))
				{
					this.SetAttributeValue("haschildrencode", null);
				}
				else
				{
					this.SetAttributeValue("haschildrencode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("HasChildrenCode");
			}
		}
		
		/// <summary>
		/// Type a second home phone number for this contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("home2")]
		public string Home2
		{
			get
			{
				return this.GetAttributeValue<string>("home2");
			}
			set
			{
				this.OnPropertyChanging("Home2");
				this.SetAttributeValue("home2", value);
				this.OnPropertyChanged("Home2");
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
		/// Select whether the contact exists in a separate accounting or other system, such as Microsoft Dynamics GP or another ERP database, for use in integration processes.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isbackofficecustomer")]
		public System.Nullable<bool> IsBackofficeCustomer
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isbackofficecustomer");
			}
			set
			{
				this.OnPropertyChanging("IsBackofficeCustomer");
				this.SetAttributeValue("isbackofficecustomer", value);
				this.OnPropertyChanged("IsBackofficeCustomer");
			}
		}
		
		/// <summary>
		/// Type the job title of the contact to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.
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
		/// Type the contact's last name to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.
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
		/// Contains the date and time stamp of the last on hold time.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastonholdtime")]
		public System.Nullable<System.DateTime> LastOnHoldTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastonholdtime");
			}
			set
			{
				this.OnPropertyChanging("LastOnHoldTime");
				this.SetAttributeValue("lastonholdtime", value);
				this.OnPropertyChanged("LastOnHoldTime");
			}
		}
		
		/// <summary>
		/// Shows the date when the contact was last included in a marketing campaign or quick campaign.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastusedincampaign")]
		public System.Nullable<System.DateTime> LastUsedInCampaign
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastusedincampaign");
			}
			set
			{
				this.OnPropertyChanging("LastUsedInCampaign");
				this.SetAttributeValue("lastusedincampaign", value);
				this.OnPropertyChanged("LastUsedInCampaign");
			}
		}
		
		/// <summary>
		/// Select the primary marketing source that directed the contact to your organization.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("leadsourcecode")]
		public System.Nullable<CCLLC.BTF.Platform.CDS.contact_leadsourcecode> LeadSourceCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("leadsourcecode");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Platform.CDS.contact_leadsourcecode)(System.Enum.ToObject(typeof(CCLLC.BTF.Platform.CDS.contact_leadsourcecode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("LeadSourceCode");
				if ((value == null))
				{
					this.SetAttributeValue("leadsourcecode", null);
				}
				else
				{
					this.SetAttributeValue("leadsourcecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("LeadSourceCode");
			}
		}
		
		/// <summary>
		/// Type the name of the contact's manager for use in escalating issues or other follow-up communications with the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("managername")]
		public string ManagerName
		{
			get
			{
				return this.GetAttributeValue<string>("managername");
			}
			set
			{
				this.OnPropertyChanging("ManagerName");
				this.SetAttributeValue("managername", value);
				this.OnPropertyChanged("ManagerName");
			}
		}
		
		/// <summary>
		/// Type the phone number for the contact's manager.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("managerphone")]
		public string ManagerPhone
		{
			get
			{
				return this.GetAttributeValue<string>("managerphone");
			}
			set
			{
				this.OnPropertyChanging("ManagerPhone");
				this.SetAttributeValue("managerphone", value);
				this.OnPropertyChanged("ManagerPhone");
			}
		}
		
		/// <summary>
		/// Whether is only for marketing
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("marketingonly")]
		public System.Nullable<bool> MarketingOnly
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("marketingonly");
			}
			set
			{
				this.OnPropertyChanging("MarketingOnly");
				this.SetAttributeValue("marketingonly", value);
				this.OnPropertyChanged("MarketingOnly");
			}
		}
		
		/// <summary>
		/// Unique identifier of the master contact for merge.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("masterid")]
		public Microsoft.Xrm.Sdk.EntityReference MasterId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("masterid");
			}
		}
		
		/// <summary>
		/// Shows whether the account has been merged with a master contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("merged")]
		public System.Nullable<bool> Merged
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("merged");
			}
		}
		
		/// <summary>
		/// Type the contact's middle name or initial to make sure the contact is addressed correctly.
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
		/// Type the mobile phone number for the contact.
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
		/// Shows the external party who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedbyexternalparty")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedByExternalParty
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedbyexternalparty");
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
		/// Type the contact's nickname.
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
		/// Type the number of children the contact has for reference in follow-up phone calls and other communications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("numberofchildren")]
		public System.Nullable<int> NumberOfChildren
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("numberofchildren");
			}
			set
			{
				this.OnPropertyChanging("NumberOfChildren");
				this.SetAttributeValue("numberofchildren", value);
				this.OnPropertyChanged("NumberOfChildren");
			}
		}
		
		/// <summary>
		/// Shows how long, in minutes, that the record was on hold.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("onholdtime")]
		public System.Nullable<int> OnHoldTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("onholdtime");
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
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the business unit that owns the contact.
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
		/// Unique identifier of the team who owns the contact.
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
		/// Unique identifier of the user who owns the contact.
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
		/// Type the pager number for the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pager")]
		public string Pager
		{
			get
			{
				return this.GetAttributeValue<string>("pager");
			}
			set
			{
				this.OnPropertyChanging("Pager");
				this.SetAttributeValue("pager", value);
				this.OnPropertyChanged("Pager");
			}
		}
		
		/// <summary>
		/// Unique identifier of the parent contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcontactid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentContactId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentcontactid");
			}
		}
		
		/// <summary>
		/// Select the parent account or parent contact for the contact to provide a quick link to additional details, such as financial information, activities, and opportunities.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcustomerid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentCustomerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentcustomerid");
			}
			set
			{
				this.OnPropertyChanging("ParentCustomerId");
				this.SetAttributeValue("parentcustomerid", value);
				this.OnPropertyChanged("ParentCustomerId");
			}
		}
		
		/// <summary>
		/// Shows whether the contact participates in workflow rules.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("participatesinworkflow")]
		public System.Nullable<bool> ParticipatesInWorkflow
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("participatesinworkflow");
			}
			set
			{
				this.OnPropertyChanging("ParticipatesInWorkflow");
				this.SetAttributeValue("participatesinworkflow", value);
				this.OnPropertyChanged("ParticipatesInWorkflow");
			}
		}
		
		/// <summary>
		/// Select the payment terms to indicate when the customer needs to pay the total amount.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("paymenttermscode")]
		public System.Nullable<CCLLC.BTF.Platform.CDS.contact_paymenttermscode> PaymentTermsCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("paymenttermscode");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Platform.CDS.contact_paymenttermscode)(System.Enum.ToObject(typeof(CCLLC.BTF.Platform.CDS.contact_paymenttermscode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("PaymentTermsCode");
				if ((value == null))
				{
					this.SetAttributeValue("paymenttermscode", null);
				}
				else
				{
					this.SetAttributeValue("paymenttermscode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("PaymentTermsCode");
			}
		}
		
		/// <summary>
		/// Select the preferred day of the week for service appointments.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredappointmentdaycode")]
		public System.Nullable<CCLLC.BTF.Platform.CDS.contact_preferredappointmentdaycode> PreferredAppointmentDayCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredappointmentdaycode");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Platform.CDS.contact_preferredappointmentdaycode)(System.Enum.ToObject(typeof(CCLLC.BTF.Platform.CDS.contact_preferredappointmentdaycode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("PreferredAppointmentDayCode");
				if ((value == null))
				{
					this.SetAttributeValue("preferredappointmentdaycode", null);
				}
				else
				{
					this.SetAttributeValue("preferredappointmentdaycode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("PreferredAppointmentDayCode");
			}
		}
		
		/// <summary>
		/// Select the preferred time of day for service appointments.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredappointmenttimecode")]
		public System.Nullable<CCLLC.BTF.Platform.CDS.contact_preferredappointmenttimecode> PreferredAppointmentTimeCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredappointmenttimecode");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Platform.CDS.contact_preferredappointmenttimecode)(System.Enum.ToObject(typeof(CCLLC.BTF.Platform.CDS.contact_preferredappointmenttimecode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("PreferredAppointmentTimeCode");
				if ((value == null))
				{
					this.SetAttributeValue("preferredappointmenttimecode", null);
				}
				else
				{
					this.SetAttributeValue("preferredappointmenttimecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("PreferredAppointmentTimeCode");
			}
		}
		
		/// <summary>
		/// Select the preferred method of contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredcontactmethodcode")]
		public System.Nullable<CCLLC.BTF.Platform.CDS.contact_preferredcontactmethodcode> PreferredContactMethodCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredcontactmethodcode");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Platform.CDS.contact_preferredcontactmethodcode)(System.Enum.ToObject(typeof(CCLLC.BTF.Platform.CDS.contact_preferredcontactmethodcode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("PreferredContactMethodCode");
				if ((value == null))
				{
					this.SetAttributeValue("preferredcontactmethodcode", null);
				}
				else
				{
					this.SetAttributeValue("preferredcontactmethodcode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("PreferredContactMethodCode");
			}
		}
		
		/// <summary>
		/// Choose the regular or preferred customer service representative for reference when scheduling service activities for the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredsystemuserid")]
		public Microsoft.Xrm.Sdk.EntityReference PreferredSystemUserId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredsystemuserid");
			}
			set
			{
				this.OnPropertyChanging("PreferredSystemUserId");
				this.SetAttributeValue("preferredsystemuserid", value);
				this.OnPropertyChanged("PreferredSystemUserId");
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
		/// This field denotes the federally issues identification. This could be SSN in US or something else in a different country.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ccllc_federalid")]
		public string ccllc_FederalID
		{
			get
			{
				return this.GetAttributeValue<string>("ccllc_federalid");
			}
			set
			{
				this.OnPropertyChanging("ccllc_FederalID");
				this.SetAttributeValue("ccllc_federalid", value);
				this.OnPropertyChanged("ccllc_FederalID");
			}
		}
		
		/// <summary>
		/// Type the salutation of the contact to make sure the contact is addressed correctly in sales calls, email messages, and marketing campaigns.
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
		/// Select a shipping method for deliveries sent to this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shippingmethodcode")]
		public System.Nullable<CCLLC.BTF.Platform.CDS.contact_shippingmethodcode> ShippingMethodCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("shippingmethodcode");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Platform.CDS.contact_shippingmethodcode)(System.Enum.ToObject(typeof(CCLLC.BTF.Platform.CDS.contact_shippingmethodcode), optionSet.Value)));
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
		/// Choose the service level agreement (SLA) that you want to apply to the Contact record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slaid")]
		public Microsoft.Xrm.Sdk.EntityReference SLAId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slaid");
			}
			set
			{
				this.OnPropertyChanging("SLAId");
				this.SetAttributeValue("slaid", value);
				this.OnPropertyChanged("SLAId");
			}
		}
		
		/// <summary>
		/// Last SLA that was applied to this case. This field is for internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slainvokedid")]
		public Microsoft.Xrm.Sdk.EntityReference SLAInvokedId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slainvokedid");
			}
		}
		
		/// <summary>
		/// Type the name of the contact's spouse or partner for reference during calls, events, or other communications with the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("spousesname")]
		public string SpousesName
		{
			get
			{
				return this.GetAttributeValue<string>("spousesname");
			}
			set
			{
				this.OnPropertyChanging("SpousesName");
				this.SetAttributeValue("spousesname", value);
				this.OnPropertyChanged("SpousesName");
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
		/// Shows whether the contact is active or inactive. Inactive contacts are read-only and can't be edited unless they are reactivated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<CCLLC.BTF.Platform.CDS.ContactState> StateCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Platform.CDS.ContactState)(System.Enum.ToObject(typeof(CCLLC.BTF.Platform.CDS.ContactState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("StateCode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("StateCode");
			}
		}
		
		/// <summary>
		/// Select the contact's status.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public System.Nullable<CCLLC.BTF.Platform.CDS.contact_statuscode> StatusCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Platform.CDS.contact_statuscode)(System.Enum.ToObject(typeof(CCLLC.BTF.Platform.CDS.contact_statuscode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("StatusCode");
				if ((value == null))
				{
					this.SetAttributeValue("statuscode", null);
				}
				else
				{
					this.SetAttributeValue("statuscode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("StatusCode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subscriptionid")]
		public System.Nullable<System.Guid> SubscriptionId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("subscriptionid");
			}
			set
			{
				this.OnPropertyChanging("SubscriptionId");
				this.SetAttributeValue("subscriptionid", value);
				this.OnPropertyChanged("SubscriptionId");
			}
		}
		
		/// <summary>
		/// Type the suffix used in the contact's name, such as Jr. or Sr. to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("suffix")]
		public string Suffix
		{
			get
			{
				return this.GetAttributeValue<string>("suffix");
			}
			set
			{
				this.OnPropertyChanging("Suffix");
				this.SetAttributeValue("suffix", value);
				this.OnPropertyChanged("Suffix");
			}
		}
		
		/// <summary>
		/// Type the main phone number for this contact.
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
		/// Type a second phone number for this contact.
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
		/// Type a third phone number for this contact.
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
		/// Select a region or territory for the contact for use in segmentation and analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("territorycode")]
		public System.Nullable<CCLLC.BTF.Platform.CDS.contact_territorycode> TerritoryCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("territorycode");
				if ((optionSet != null))
				{
					return ((CCLLC.BTF.Platform.CDS.contact_territorycode)(System.Enum.ToObject(typeof(CCLLC.BTF.Platform.CDS.contact_territorycode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("TerritoryCode");
				if ((value == null))
				{
					this.SetAttributeValue("territorycode", null);
				}
				else
				{
					this.SetAttributeValue("territorycode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("TerritoryCode");
			}
		}
		
		/// <summary>
		/// Total time spent for emails (read and write) and meetings by me in relation to the contact record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timespentbymeonemailandmeetings")]
		public string TimeSpentByMeOnEmailAndMeetings
		{
			get
			{
				return this.GetAttributeValue<string>("timespentbymeonemailandmeetings");
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
		/// Version number of the contact.
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
		/// Type the contact's professional or personal website or blog URL.
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
		/// Type the phonetic spelling of the contact's first name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact.
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
		/// Shows the combined Yomi first and last names of the contact so that the full phonetic name can be displayed in views and reports.
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
		/// Type the phonetic spelling of the contact's last name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact.
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
		/// Type the phonetic spelling of the contact's middle name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact.
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
		/// 1:N account_primary_contact
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_primary_contact")]
		public System.Collections.Generic.IEnumerable<CCLLC.BTF.Platform.CDS.Account> account_primary_contact
		{
			get
			{
				return this.GetRelatedEntities<CCLLC.BTF.Platform.CDS.Account>("account_primary_contact", null);
			}
			set
			{
				this.OnPropertyChanging("account_primary_contact");
				this.SetRelatedEntities<CCLLC.BTF.Platform.CDS.Account>("account_primary_contact", null, value);
				this.OnPropertyChanged("account_primary_contact");
			}
		}
		
		/// <summary>
		/// 1:N contact_customer_contacts
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_customer_contacts", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<CCLLC.BTF.Platform.CDS.Contact> Referencedcontact_customer_contacts
		{
			get
			{
				return this.GetRelatedEntities<CCLLC.BTF.Platform.CDS.Contact>("contact_customer_contacts", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedcontact_customer_contacts");
				this.SetRelatedEntities<CCLLC.BTF.Platform.CDS.Contact>("contact_customer_contacts", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedcontact_customer_contacts");
			}
		}
		
		/// <summary>
		/// 1:N Contact_CustomerAddress
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_CustomerAddress")]
		public System.Collections.Generic.IEnumerable<CCLLC.BTF.Platform.CDS.CustomerAddress> Contact_CustomerAddress
		{
			get
			{
				return this.GetRelatedEntities<CCLLC.BTF.Platform.CDS.CustomerAddress>("Contact_CustomerAddress", null);
			}
			set
			{
				this.OnPropertyChanging("Contact_CustomerAddress");
				this.SetRelatedEntities<CCLLC.BTF.Platform.CDS.CustomerAddress>("Contact_CustomerAddress", null, value);
				this.OnPropertyChanged("Contact_CustomerAddress");
			}
		}
		
		/// <summary>
		/// 1:N contact_master_contact
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_master_contact", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<CCLLC.BTF.Platform.CDS.Contact> Referencedcontact_master_contact
		{
			get
			{
				return this.GetRelatedEntities<CCLLC.BTF.Platform.CDS.Contact>("contact_master_contact", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedcontact_master_contact");
				this.SetRelatedEntities<CCLLC.BTF.Platform.CDS.Contact>("contact_master_contact", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedcontact_master_contact");
			}
		}
		
		/// <summary>
		/// 1:N ccllc_contact_authorizedagent
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_contact_authorizedagent")]
		public System.Collections.Generic.IEnumerable<CCLLC.BTF.Platform.CDS.ccllc_agentauthorizedcustomer> ccllc_contact_authorizedagent
		{
			get
			{
				return this.GetRelatedEntities<CCLLC.BTF.Platform.CDS.ccllc_agentauthorizedcustomer>("ccllc_contact_authorizedagent", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_contact_authorizedagent");
				this.SetRelatedEntities<CCLLC.BTF.Platform.CDS.ccllc_agentauthorizedcustomer>("ccllc_contact_authorizedagent", null, value);
				this.OnPropertyChanged("ccllc_contact_authorizedagent");
			}
		}
		
		/// <summary>
		/// 1:N ccllc_contact_prohibitedagent
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ccllc_contact_prohibitedagent")]
		public System.Collections.Generic.IEnumerable<CCLLC.BTF.Platform.CDS.ccllc_agentprohibitedcustomer> ccllc_contact_prohibitedagent
		{
			get
			{
				return this.GetRelatedEntities<CCLLC.BTF.Platform.CDS.ccllc_agentprohibitedcustomer>("ccllc_contact_prohibitedagent", null);
			}
			set
			{
				this.OnPropertyChanging("ccllc_contact_prohibitedagent");
				this.SetRelatedEntities<CCLLC.BTF.Platform.CDS.ccllc_agentprohibitedcustomer>("ccllc_contact_prohibitedagent", null, value);
				this.OnPropertyChanged("ccllc_contact_prohibitedagent");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_contacts
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_contacts")]
		public CCLLC.BTF.Platform.CDS.BusinessUnit business_unit_contacts
		{
			get
			{
				return this.GetRelatedEntity<CCLLC.BTF.Platform.CDS.BusinessUnit>("business_unit_contacts", null);
			}
		}
		
		/// <summary>
		/// N:1 contact_customer_accounts
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcustomerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_customer_accounts")]
		public CCLLC.BTF.Platform.CDS.Account contact_customer_accounts
		{
			get
			{
				return this.GetRelatedEntity<CCLLC.BTF.Platform.CDS.Account>("contact_customer_accounts", null);
			}
			set
			{
				this.OnPropertyChanging("contact_customer_accounts");
				this.SetRelatedEntity<CCLLC.BTF.Platform.CDS.Account>("contact_customer_accounts", null, value);
				this.OnPropertyChanged("contact_customer_accounts");
			}
		}
		
		/// <summary>
		/// N:1 contact_customer_contacts
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcustomerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_customer_contacts", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public CCLLC.BTF.Platform.CDS.Contact Referencingcontact_customer_contacts
		{
			get
			{
				return this.GetRelatedEntity<CCLLC.BTF.Platform.CDS.Contact>("contact_customer_contacts", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			set
			{
				this.OnPropertyChanging("Referencingcontact_customer_contacts");
				this.SetRelatedEntity<CCLLC.BTF.Platform.CDS.Contact>("contact_customer_contacts", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
				this.OnPropertyChanged("Referencingcontact_customer_contacts");
			}
		}
		
		/// <summary>
		/// N:1 contact_master_contact
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("masterid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_master_contact", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public CCLLC.BTF.Platform.CDS.Contact Referencingcontact_master_contact
		{
			get
			{
				return this.GetRelatedEntity<CCLLC.BTF.Platform.CDS.Contact>("contact_master_contact", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
		}
		
		/// <summary>
		/// N:1 contact_owning_user
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_owning_user")]
		public CCLLC.BTF.Platform.CDS.SystemUser contact_owning_user
		{
			get
			{
				return this.GetRelatedEntity<CCLLC.BTF.Platform.CDS.SystemUser>("contact_owning_user", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_contact_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contact_createdonbehalfby")]
		public CCLLC.BTF.Platform.CDS.SystemUser lk_contact_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<CCLLC.BTF.Platform.CDS.SystemUser>("lk_contact_createdonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_contact_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contact_modifiedonbehalfby")]
		public CCLLC.BTF.Platform.CDS.SystemUser lk_contact_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<CCLLC.BTF.Platform.CDS.SystemUser>("lk_contact_modifiedonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_contactbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contactbase_createdby")]
		public CCLLC.BTF.Platform.CDS.SystemUser lk_contactbase_createdby
		{
			get
			{
				return this.GetRelatedEntity<CCLLC.BTF.Platform.CDS.SystemUser>("lk_contactbase_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_contactbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contactbase_modifiedby")]
		public CCLLC.BTF.Platform.CDS.SystemUser lk_contactbase_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<CCLLC.BTF.Platform.CDS.SystemUser>("lk_contactbase_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 system_user_contacts
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredsystemuserid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_contacts")]
		public CCLLC.BTF.Platform.CDS.SystemUser system_user_contacts
		{
			get
			{
				return this.GetRelatedEntity<CCLLC.BTF.Platform.CDS.SystemUser>("system_user_contacts", null);
			}
			set
			{
				this.OnPropertyChanging("system_user_contacts");
				this.SetRelatedEntity<CCLLC.BTF.Platform.CDS.SystemUser>("system_user_contacts", null, value);
				this.OnPropertyChanged("system_user_contacts");
			}
		}
	}
}
