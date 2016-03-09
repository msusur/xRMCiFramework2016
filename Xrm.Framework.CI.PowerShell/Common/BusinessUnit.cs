using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Xrm.Framework.CI.Common.Entities
{
    /// <summary>
    ///     Business, division, or department in the Microsoft Dynamics CRM database.
    /// </summary>
    [DataContract]
    [EntityLogicalName("businessunit")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class BusinessUnit : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "businessunit";

        public const int EntityTypeCode = 10;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public BusinessUnit() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier for address 1.
        /// </summary>
        [AttributeLogicalName("address1_addressid")]
        public Guid? Address1_AddressId
        {
            get { return GetAttributeValue<Guid?>("address1_addressid"); }
            set
            {
                OnPropertyChanging("Address1_AddressId");
                SetAttributeValue("address1_addressid", value);
                OnPropertyChanged("Address1_AddressId");
            }
        }

        /// <summary>
        ///     Type of address for address 1, such as billing, shipping, or primary address.
        /// </summary>
        [AttributeLogicalName("address1_addresstypecode")]
        public OptionSetValue Address1_AddressTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("address1_addresstypecode"); }
            set
            {
                OnPropertyChanging("Address1_AddressTypeCode");
                SetAttributeValue("address1_addresstypecode", value);
                OnPropertyChanged("Address1_AddressTypeCode");
            }
        }

        /// <summary>
        ///     City name for address 1.
        /// </summary>
        [AttributeLogicalName("address1_city")]
        public string Address1_City
        {
            get { return GetAttributeValue<string>("address1_city"); }
            set
            {
                OnPropertyChanging("Address1_City");
                SetAttributeValue("address1_city", value);
                OnPropertyChanged("Address1_City");
            }
        }

        /// <summary>
        ///     Country/region name for address 1.
        /// </summary>
        [AttributeLogicalName("address1_country")]
        public string Address1_Country
        {
            get { return GetAttributeValue<string>("address1_country"); }
            set
            {
                OnPropertyChanging("Address1_Country");
                SetAttributeValue("address1_country", value);
                OnPropertyChanged("Address1_Country");
            }
        }

        /// <summary>
        ///     County name for address 1.
        /// </summary>
        [AttributeLogicalName("address1_county")]
        public string Address1_County
        {
            get { return GetAttributeValue<string>("address1_county"); }
            set
            {
                OnPropertyChanging("Address1_County");
                SetAttributeValue("address1_county", value);
                OnPropertyChanged("Address1_County");
            }
        }

        /// <summary>
        ///     Fax number for address 1.
        /// </summary>
        [AttributeLogicalName("address1_fax")]
        public string Address1_Fax
        {
            get { return GetAttributeValue<string>("address1_fax"); }
            set
            {
                OnPropertyChanging("Address1_Fax");
                SetAttributeValue("address1_fax", value);
                OnPropertyChanged("Address1_Fax");
            }
        }

        /// <summary>
        ///     Latitude for address 1.
        /// </summary>
        [AttributeLogicalName("address1_latitude")]
        public double? Address1_Latitude
        {
            get { return GetAttributeValue<double?>("address1_latitude"); }
            set
            {
                OnPropertyChanging("Address1_Latitude");
                SetAttributeValue("address1_latitude", value);
                OnPropertyChanged("Address1_Latitude");
            }
        }

        /// <summary>
        ///     First line for entering address 1 information.
        /// </summary>
        [AttributeLogicalName("address1_line1")]
        public string Address1_Line1
        {
            get { return GetAttributeValue<string>("address1_line1"); }
            set
            {
                OnPropertyChanging("Address1_Line1");
                SetAttributeValue("address1_line1", value);
                OnPropertyChanged("Address1_Line1");
            }
        }

        /// <summary>
        ///     Second line for entering address 1 information.
        /// </summary>
        [AttributeLogicalName("address1_line2")]
        public string Address1_Line2
        {
            get { return GetAttributeValue<string>("address1_line2"); }
            set
            {
                OnPropertyChanging("Address1_Line2");
                SetAttributeValue("address1_line2", value);
                OnPropertyChanged("Address1_Line2");
            }
        }

        /// <summary>
        ///     Third line for entering address 1 information.
        /// </summary>
        [AttributeLogicalName("address1_line3")]
        public string Address1_Line3
        {
            get { return GetAttributeValue<string>("address1_line3"); }
            set
            {
                OnPropertyChanging("Address1_Line3");
                SetAttributeValue("address1_line3", value);
                OnPropertyChanged("Address1_Line3");
            }
        }

        /// <summary>
        ///     Longitude for address 1.
        /// </summary>
        [AttributeLogicalName("address1_longitude")]
        public double? Address1_Longitude
        {
            get { return GetAttributeValue<double?>("address1_longitude"); }
            set
            {
                OnPropertyChanging("Address1_Longitude");
                SetAttributeValue("address1_longitude", value);
                OnPropertyChanged("Address1_Longitude");
            }
        }

        /// <summary>
        ///     Name to enter for address 1.
        /// </summary>
        [AttributeLogicalName("address1_name")]
        public string Address1_Name
        {
            get { return GetAttributeValue<string>("address1_name"); }
            set
            {
                OnPropertyChanging("Address1_Name");
                SetAttributeValue("address1_name", value);
                OnPropertyChanged("Address1_Name");
            }
        }

        /// <summary>
        ///     ZIP Code or postal code for address 1.
        /// </summary>
        [AttributeLogicalName("address1_postalcode")]
        public string Address1_PostalCode
        {
            get { return GetAttributeValue<string>("address1_postalcode"); }
            set
            {
                OnPropertyChanging("Address1_PostalCode");
                SetAttributeValue("address1_postalcode", value);
                OnPropertyChanged("Address1_PostalCode");
            }
        }

        /// <summary>
        ///     Post office box number for address 1.
        /// </summary>
        [AttributeLogicalName("address1_postofficebox")]
        public string Address1_PostOfficeBox
        {
            get { return GetAttributeValue<string>("address1_postofficebox"); }
            set
            {
                OnPropertyChanging("Address1_PostOfficeBox");
                SetAttributeValue("address1_postofficebox", value);
                OnPropertyChanged("Address1_PostOfficeBox");
            }
        }

        /// <summary>
        ///     Method of shipment for address 1.
        /// </summary>
        [AttributeLogicalName("address1_shippingmethodcode")]
        public OptionSetValue Address1_ShippingMethodCode
        {
            get { return GetAttributeValue<OptionSetValue>("address1_shippingmethodcode"); }
            set
            {
                OnPropertyChanging("Address1_ShippingMethodCode");
                SetAttributeValue("address1_shippingmethodcode", value);
                OnPropertyChanged("Address1_ShippingMethodCode");
            }
        }

        /// <summary>
        ///     State or province for address 1.
        /// </summary>
        [AttributeLogicalName("address1_stateorprovince")]
        public string Address1_StateOrProvince
        {
            get { return GetAttributeValue<string>("address1_stateorprovince"); }
            set
            {
                OnPropertyChanging("Address1_StateOrProvince");
                SetAttributeValue("address1_stateorprovince", value);
                OnPropertyChanged("Address1_StateOrProvince");
            }
        }

        /// <summary>
        ///     First telephone number associated with address 1.
        /// </summary>
        [AttributeLogicalName("address1_telephone1")]
        public string Address1_Telephone1
        {
            get { return GetAttributeValue<string>("address1_telephone1"); }
            set
            {
                OnPropertyChanging("Address1_Telephone1");
                SetAttributeValue("address1_telephone1", value);
                OnPropertyChanged("Address1_Telephone1");
            }
        }

        /// <summary>
        ///     Second telephone number associated with address 1.
        /// </summary>
        [AttributeLogicalName("address1_telephone2")]
        public string Address1_Telephone2
        {
            get { return GetAttributeValue<string>("address1_telephone2"); }
            set
            {
                OnPropertyChanging("Address1_Telephone2");
                SetAttributeValue("address1_telephone2", value);
                OnPropertyChanged("Address1_Telephone2");
            }
        }

        /// <summary>
        ///     Third telephone number associated with address 1.
        /// </summary>
        [AttributeLogicalName("address1_telephone3")]
        public string Address1_Telephone3
        {
            get { return GetAttributeValue<string>("address1_telephone3"); }
            set
            {
                OnPropertyChanging("Address1_Telephone3");
                SetAttributeValue("address1_telephone3", value);
                OnPropertyChanged("Address1_Telephone3");
            }
        }

        /// <summary>
        ///     United Parcel Service (UPS) zone for address 1.
        /// </summary>
        [AttributeLogicalName("address1_upszone")]
        public string Address1_UPSZone
        {
            get { return GetAttributeValue<string>("address1_upszone"); }
            set
            {
                OnPropertyChanging("Address1_UPSZone");
                SetAttributeValue("address1_upszone", value);
                OnPropertyChanged("Address1_UPSZone");
            }
        }

        /// <summary>
        ///     UTC offset for address 1. This is the difference between local time and standard Coordinated Universal Time.
        /// </summary>
        [AttributeLogicalName("address1_utcoffset")]
        public int? Address1_UTCOffset
        {
            get { return GetAttributeValue<int?>("address1_utcoffset"); }
            set
            {
                OnPropertyChanging("Address1_UTCOffset");
                SetAttributeValue("address1_utcoffset", value);
                OnPropertyChanged("Address1_UTCOffset");
            }
        }

        /// <summary>
        ///     Unique identifier for address 2.
        /// </summary>
        [AttributeLogicalName("address2_addressid")]
        public Guid? Address2_AddressId
        {
            get { return GetAttributeValue<Guid?>("address2_addressid"); }
            set
            {
                OnPropertyChanging("Address2_AddressId");
                SetAttributeValue("address2_addressid", value);
                OnPropertyChanged("Address2_AddressId");
            }
        }

        /// <summary>
        ///     Type of address for address 2, such as billing, shipping, or primary address.
        /// </summary>
        [AttributeLogicalName("address2_addresstypecode")]
        public OptionSetValue Address2_AddressTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("address2_addresstypecode"); }
            set
            {
                OnPropertyChanging("Address2_AddressTypeCode");
                SetAttributeValue("address2_addresstypecode", value);
                OnPropertyChanged("Address2_AddressTypeCode");
            }
        }

        /// <summary>
        ///     City name for address 2.
        /// </summary>
        [AttributeLogicalName("address2_city")]
        public string Address2_City
        {
            get { return GetAttributeValue<string>("address2_city"); }
            set
            {
                OnPropertyChanging("Address2_City");
                SetAttributeValue("address2_city", value);
                OnPropertyChanged("Address2_City");
            }
        }

        /// <summary>
        ///     Country/region name for address 2.
        /// </summary>
        [AttributeLogicalName("address2_country")]
        public string Address2_Country
        {
            get { return GetAttributeValue<string>("address2_country"); }
            set
            {
                OnPropertyChanging("Address2_Country");
                SetAttributeValue("address2_country", value);
                OnPropertyChanged("Address2_Country");
            }
        }

        /// <summary>
        ///     County name for address 2.
        /// </summary>
        [AttributeLogicalName("address2_county")]
        public string Address2_County
        {
            get { return GetAttributeValue<string>("address2_county"); }
            set
            {
                OnPropertyChanging("Address2_County");
                SetAttributeValue("address2_county", value);
                OnPropertyChanged("Address2_County");
            }
        }

        /// <summary>
        ///     Fax number for address 2.
        /// </summary>
        [AttributeLogicalName("address2_fax")]
        public string Address2_Fax
        {
            get { return GetAttributeValue<string>("address2_fax"); }
            set
            {
                OnPropertyChanging("Address2_Fax");
                SetAttributeValue("address2_fax", value);
                OnPropertyChanged("Address2_Fax");
            }
        }

        /// <summary>
        ///     Latitude for address 2.
        /// </summary>
        [AttributeLogicalName("address2_latitude")]
        public double? Address2_Latitude
        {
            get { return GetAttributeValue<double?>("address2_latitude"); }
            set
            {
                OnPropertyChanging("Address2_Latitude");
                SetAttributeValue("address2_latitude", value);
                OnPropertyChanged("Address2_Latitude");
            }
        }

        /// <summary>
        ///     First line for entering address 2 information.
        /// </summary>
        [AttributeLogicalName("address2_line1")]
        public string Address2_Line1
        {
            get { return GetAttributeValue<string>("address2_line1"); }
            set
            {
                OnPropertyChanging("Address2_Line1");
                SetAttributeValue("address2_line1", value);
                OnPropertyChanged("Address2_Line1");
            }
        }

        /// <summary>
        ///     Second line for entering address 2 information.
        /// </summary>
        [AttributeLogicalName("address2_line2")]
        public string Address2_Line2
        {
            get { return GetAttributeValue<string>("address2_line2"); }
            set
            {
                OnPropertyChanging("Address2_Line2");
                SetAttributeValue("address2_line2", value);
                OnPropertyChanged("Address2_Line2");
            }
        }

        /// <summary>
        ///     Third line for entering address 2 information.
        /// </summary>
        [AttributeLogicalName("address2_line3")]
        public string Address2_Line3
        {
            get { return GetAttributeValue<string>("address2_line3"); }
            set
            {
                OnPropertyChanging("Address2_Line3");
                SetAttributeValue("address2_line3", value);
                OnPropertyChanged("Address2_Line3");
            }
        }

        /// <summary>
        ///     Longitude for address 2.
        /// </summary>
        [AttributeLogicalName("address2_longitude")]
        public double? Address2_Longitude
        {
            get { return GetAttributeValue<double?>("address2_longitude"); }
            set
            {
                OnPropertyChanging("Address2_Longitude");
                SetAttributeValue("address2_longitude", value);
                OnPropertyChanged("Address2_Longitude");
            }
        }

        /// <summary>
        ///     Name to enter for address 2.
        /// </summary>
        [AttributeLogicalName("address2_name")]
        public string Address2_Name
        {
            get { return GetAttributeValue<string>("address2_name"); }
            set
            {
                OnPropertyChanging("Address2_Name");
                SetAttributeValue("address2_name", value);
                OnPropertyChanged("Address2_Name");
            }
        }

        /// <summary>
        ///     ZIP Code or postal code for address 2.
        /// </summary>
        [AttributeLogicalName("address2_postalcode")]
        public string Address2_PostalCode
        {
            get { return GetAttributeValue<string>("address2_postalcode"); }
            set
            {
                OnPropertyChanging("Address2_PostalCode");
                SetAttributeValue("address2_postalcode", value);
                OnPropertyChanged("Address2_PostalCode");
            }
        }

        /// <summary>
        ///     Post office box number for address 2.
        /// </summary>
        [AttributeLogicalName("address2_postofficebox")]
        public string Address2_PostOfficeBox
        {
            get { return GetAttributeValue<string>("address2_postofficebox"); }
            set
            {
                OnPropertyChanging("Address2_PostOfficeBox");
                SetAttributeValue("address2_postofficebox", value);
                OnPropertyChanged("Address2_PostOfficeBox");
            }
        }

        /// <summary>
        ///     Method of shipment for address 2.
        /// </summary>
        [AttributeLogicalName("address2_shippingmethodcode")]
        public OptionSetValue Address2_ShippingMethodCode
        {
            get { return GetAttributeValue<OptionSetValue>("address2_shippingmethodcode"); }
            set
            {
                OnPropertyChanging("Address2_ShippingMethodCode");
                SetAttributeValue("address2_shippingmethodcode", value);
                OnPropertyChanged("Address2_ShippingMethodCode");
            }
        }

        /// <summary>
        ///     State or province for address 2.
        /// </summary>
        [AttributeLogicalName("address2_stateorprovince")]
        public string Address2_StateOrProvince
        {
            get { return GetAttributeValue<string>("address2_stateorprovince"); }
            set
            {
                OnPropertyChanging("Address2_StateOrProvince");
                SetAttributeValue("address2_stateorprovince", value);
                OnPropertyChanged("Address2_StateOrProvince");
            }
        }

        /// <summary>
        ///     First telephone number associated with address 2.
        /// </summary>
        [AttributeLogicalName("address2_telephone1")]
        public string Address2_Telephone1
        {
            get { return GetAttributeValue<string>("address2_telephone1"); }
            set
            {
                OnPropertyChanging("Address2_Telephone1");
                SetAttributeValue("address2_telephone1", value);
                OnPropertyChanged("Address2_Telephone1");
            }
        }

        /// <summary>
        ///     Second telephone number associated with address 2.
        /// </summary>
        [AttributeLogicalName("address2_telephone2")]
        public string Address2_Telephone2
        {
            get { return GetAttributeValue<string>("address2_telephone2"); }
            set
            {
                OnPropertyChanging("Address2_Telephone2");
                SetAttributeValue("address2_telephone2", value);
                OnPropertyChanged("Address2_Telephone2");
            }
        }

        /// <summary>
        ///     Third telephone number associated with address 2.
        /// </summary>
        [AttributeLogicalName("address2_telephone3")]
        public string Address2_Telephone3
        {
            get { return GetAttributeValue<string>("address2_telephone3"); }
            set
            {
                OnPropertyChanging("Address2_Telephone3");
                SetAttributeValue("address2_telephone3", value);
                OnPropertyChanged("Address2_Telephone3");
            }
        }

        /// <summary>
        ///     United Parcel Service (UPS) zone for address 2.
        /// </summary>
        [AttributeLogicalName("address2_upszone")]
        public string Address2_UPSZone
        {
            get { return GetAttributeValue<string>("address2_upszone"); }
            set
            {
                OnPropertyChanging("Address2_UPSZone");
                SetAttributeValue("address2_upszone", value);
                OnPropertyChanged("Address2_UPSZone");
            }
        }

        /// <summary>
        ///     UTC offset for address 2. This is the difference between local time and standard Coordinated Universal Time.
        /// </summary>
        [AttributeLogicalName("address2_utcoffset")]
        public int? Address2_UTCOffset
        {
            get { return GetAttributeValue<int?>("address2_utcoffset"); }
            set
            {
                OnPropertyChanging("Address2_UTCOffset");
                SetAttributeValue("address2_utcoffset", value);
                OnPropertyChanged("Address2_UTCOffset");
            }
        }

        /// <summary>
        ///     Unique identifier of the business unit.
        /// </summary>
        [AttributeLogicalName("businessunitid")]
        public Guid? BusinessUnitId
        {
            get { return GetAttributeValue<Guid?>("businessunitid"); }
            set
            {
                OnPropertyChanging("BusinessUnitId");
                SetAttributeValue("businessunitid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("BusinessUnitId");
            }
        }

        [AttributeLogicalName("businessunitid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { BusinessUnitId = value; }
        }

        /// <summary>
        ///     Fiscal calendar associated with the business unit.
        /// </summary>
        [AttributeLogicalName("calendarid")]
        public EntityReference CalendarId
        {
            get { return GetAttributeValue<EntityReference>("calendarid"); }
            set
            {
                OnPropertyChanging("CalendarId");
                SetAttributeValue("calendarid", value);
                OnPropertyChanged("CalendarId");
            }
        }

        /// <summary>
        ///     Name of the business unit cost center.
        /// </summary>
        [AttributeLogicalName("costcenter")]
        public string CostCenter
        {
            get { return GetAttributeValue<string>("costcenter"); }
            set
            {
                OnPropertyChanging("CostCenter");
                SetAttributeValue("costcenter", value);
                OnPropertyChanged("CostCenter");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the business unit.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the business unit was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the businessunit.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Credit limit for the business unit.
        /// </summary>
        [AttributeLogicalName("creditlimit")]
        public double? CreditLimit
        {
            get { return GetAttributeValue<double?>("creditlimit"); }
            set
            {
                OnPropertyChanging("CreditLimit");
                SetAttributeValue("creditlimit", value);
                OnPropertyChanged("CreditLimit");
            }
        }

        /// <summary>
        ///     Description of the business unit.
        /// </summary>
        [AttributeLogicalName("description")]
        public string Description
        {
            get { return GetAttributeValue<string>("description"); }
            set
            {
                OnPropertyChanging("Description");
                SetAttributeValue("description", value);
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        ///     Reason for disabling the business unit.
        /// </summary>
        [AttributeLogicalName("disabledreason")]
        public string DisabledReason
        {
            get { return GetAttributeValue<string>("disabledreason"); }
        }

        /// <summary>
        ///     Name of the division to which the business unit belongs.
        /// </summary>
        [AttributeLogicalName("divisionname")]
        public string DivisionName
        {
            get { return GetAttributeValue<string>("divisionname"); }
            set
            {
                OnPropertyChanging("DivisionName");
                SetAttributeValue("divisionname", value);
                OnPropertyChanged("DivisionName");
            }
        }

        /// <summary>
        ///     Email address for the business unit.
        /// </summary>
        [AttributeLogicalName("emailaddress")]
        public string EMailAddress
        {
            get { return GetAttributeValue<string>("emailaddress"); }
            set
            {
                OnPropertyChanging("EMailAddress");
                SetAttributeValue("emailaddress", value);
                OnPropertyChanged("EMailAddress");
            }
        }

        /// <summary>
        ///     Exchange rate for the currency associated with the businessunit with respect to the base currency.
        /// </summary>
        [AttributeLogicalName("exchangerate")]
        public decimal? ExchangeRate
        {
            get { return GetAttributeValue<decimal?>("exchangerate"); }
        }

        /// <summary>
        ///     Alternative name under which the business unit can be filed.
        /// </summary>
        [AttributeLogicalName("fileasname")]
        public string FileAsName
        {
            get { return GetAttributeValue<string>("fileasname"); }
            set
            {
                OnPropertyChanging("FileAsName");
                SetAttributeValue("fileasname", value);
                OnPropertyChanged("FileAsName");
            }
        }

        /// <summary>
        ///     FTP site URL for the business unit.
        /// </summary>
        [AttributeLogicalName("ftpsiteurl")]
        public string FtpSiteUrl
        {
            get { return GetAttributeValue<string>("ftpsiteurl"); }
            set
            {
                OnPropertyChanging("FtpSiteUrl");
                SetAttributeValue("ftpsiteurl", value);
                OnPropertyChanged("FtpSiteUrl");
            }
        }

        /// <summary>
        ///     Unique identifier of the data import or data migration that created this record.
        /// </summary>
        [AttributeLogicalName("importsequencenumber")]
        public int? ImportSequenceNumber
        {
            get { return GetAttributeValue<int?>("importsequencenumber"); }
            set
            {
                OnPropertyChanging("ImportSequenceNumber");
                SetAttributeValue("importsequencenumber", value);
                OnPropertyChanged("ImportSequenceNumber");
            }
        }

        /// <summary>
        ///     Inheritance mask for the business unit.
        /// </summary>
        [AttributeLogicalName("inheritancemask")]
        public int? InheritanceMask
        {
            get { return GetAttributeValue<int?>("inheritancemask"); }
            set
            {
                OnPropertyChanging("InheritanceMask");
                SetAttributeValue("inheritancemask", value);
                OnPropertyChanged("InheritanceMask");
            }
        }

        /// <summary>
        ///     Information about whether the business unit is enabled or disabled.
        /// </summary>
        [AttributeLogicalName("isdisabled")]
        public bool? IsDisabled
        {
            get { return GetAttributeValue<bool?>("isdisabled"); }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the business unit.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the business unit was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the businessunit.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the business unit.
        /// </summary>
        [AttributeLogicalName("name")]
        public string Name
        {
            get { return GetAttributeValue<string>("name"); }
            set
            {
                OnPropertyChanging("Name");
                SetAttributeValue("name", value);
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        ///     Unique identifier of the organization associated with the business unit.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     Date and time that the record was migrated.
        /// </summary>
        [AttributeLogicalName("overriddencreatedon")]
        public DateTime? OverriddenCreatedOn
        {
            get { return GetAttributeValue<DateTime?>("overriddencreatedon"); }
            set
            {
                OnPropertyChanging("OverriddenCreatedOn");
                SetAttributeValue("overriddencreatedon", value);
                OnPropertyChanged("OverriddenCreatedOn");
            }
        }

        /// <summary>
        ///     Unique identifier for the parent business unit.
        /// </summary>
        [AttributeLogicalName("parentbusinessunitid")]
        public EntityReference ParentBusinessUnitId
        {
            get { return GetAttributeValue<EntityReference>("parentbusinessunitid"); }
            set
            {
                OnPropertyChanging("ParentBusinessUnitId");
                SetAttributeValue("parentbusinessunitid", value);
                OnPropertyChanged("ParentBusinessUnitId");
            }
        }

        /// <summary>
        ///     Picture or diagram of the business unit.
        /// </summary>
        [AttributeLogicalName("picture")]
        public string Picture
        {
            get { return GetAttributeValue<string>("picture"); }
            set
            {
                OnPropertyChanging("Picture");
                SetAttributeValue("picture", value);
                OnPropertyChanged("Picture");
            }
        }

        /// <summary>
        ///     Stock exchange on which the business is listed.
        /// </summary>
        [AttributeLogicalName("stockexchange")]
        public string StockExchange
        {
            get { return GetAttributeValue<string>("stockexchange"); }
            set
            {
                OnPropertyChanging("StockExchange");
                SetAttributeValue("stockexchange", value);
                OnPropertyChanged("StockExchange");
            }
        }

        /// <summary>
        ///     Stock exchange ticker symbol for the business unit.
        /// </summary>
        [AttributeLogicalName("tickersymbol")]
        public string TickerSymbol
        {
            get { return GetAttributeValue<string>("tickersymbol"); }
            set
            {
                OnPropertyChanging("TickerSymbol");
                SetAttributeValue("tickersymbol", value);
                OnPropertyChanged("TickerSymbol");
            }
        }

        /// <summary>
        ///     Unique identifier of the currency associated with the businessunit.
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        public EntityReference TransactionCurrencyId
        {
            get { return GetAttributeValue<EntityReference>("transactioncurrencyid"); }
            set
            {
                OnPropertyChanging("TransactionCurrencyId");
                SetAttributeValue("transactioncurrencyid", value);
                OnPropertyChanged("TransactionCurrencyId");
            }
        }

        /// <summary>
        ///     UTC offset for the business unit. This is the difference between local time and standard Coordinated Universal
        ///     Time.
        /// </summary>
        [AttributeLogicalName("utcoffset")]
        public int? UTCOffset
        {
            get { return GetAttributeValue<int?>("utcoffset"); }
            set
            {
                OnPropertyChanging("UTCOffset");
                SetAttributeValue("utcoffset", value);
                OnPropertyChanged("UTCOffset");
            }
        }

        /// <summary>
        ///     Version number of the business unit.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     Website URL for the business unit.
        /// </summary>
        [AttributeLogicalName("websiteurl")]
        public string WebSiteUrl
        {
            get { return GetAttributeValue<string>("websiteurl"); }
            set
            {
                OnPropertyChanging("WebSiteUrl");
                SetAttributeValue("websiteurl", value);
                OnPropertyChanged("WebSiteUrl");
            }
        }

        /// <summary>
        ///     Information about whether workflow or sales process rules have been suspended.
        /// </summary>
        [AttributeLogicalName("workflowsuspended")]
        public bool? WorkflowSuspended
        {
            get { return GetAttributeValue<bool?>("workflowsuspended"); }
            set
            {
                OnPropertyChanging("WorkflowSuspended");
                SetAttributeValue("workflowsuspended", value);
                OnPropertyChanged("WorkflowSuspended");
            }
        }

        /// <summary>
        ///     1:N business_customer_opportunity_roles
        /// </summary>
        [RelationshipSchemaName("business_customer_opportunity_roles")]
        public IEnumerable<CustomerOpportunityRole> business_customer_opportunity_roles
        {
            get { return GetRelatedEntities<CustomerOpportunityRole>("business_customer_opportunity_roles", null); }
            set
            {
                OnPropertyChanging("business_customer_opportunity_roles");
                SetRelatedEntities("business_customer_opportunity_roles", null, value);
                OnPropertyChanged("business_customer_opportunity_roles");
            }
        }

        /// <summary>
        ///     1:N business_unit_accounts
        /// </summary>
        [RelationshipSchemaName("business_unit_accounts")]
        public IEnumerable<Account> business_unit_accounts
        {
            get { return GetRelatedEntities<Account>("business_unit_accounts", null); }
            set
            {
                OnPropertyChanging("business_unit_accounts");
                SetRelatedEntities("business_unit_accounts", null, value);
                OnPropertyChanged("business_unit_accounts");
            }
        }

        /// <summary>
        ///     1:N business_unit_activitypointer
        /// </summary>
        [RelationshipSchemaName("business_unit_activitypointer")]
        public IEnumerable<ActivityPointer> business_unit_activitypointer
        {
            get { return GetRelatedEntities<ActivityPointer>("business_unit_activitypointer", null); }
            set
            {
                OnPropertyChanging("business_unit_activitypointer");
                SetRelatedEntities("business_unit_activitypointer", null, value);
                OnPropertyChanged("business_unit_activitypointer");
            }
        }

        /// <summary>
        ///     1:N business_unit_annotations
        /// </summary>
        [RelationshipSchemaName("business_unit_annotations")]
        public IEnumerable<Annotation> business_unit_annotations
        {
            get { return GetRelatedEntities<Annotation>("business_unit_annotations", null); }
            set
            {
                OnPropertyChanging("business_unit_annotations");
                SetRelatedEntities("business_unit_annotations", null, value);
                OnPropertyChanged("business_unit_annotations");
            }
        }

        /// <summary>
        ///     1:N business_unit_appointment_activities
        /// </summary>
        [RelationshipSchemaName("business_unit_appointment_activities")]
        public IEnumerable<Appointment> business_unit_appointment_activities
        {
            get { return GetRelatedEntities<Appointment>("business_unit_appointment_activities", null); }
            set
            {
                OnPropertyChanging("business_unit_appointment_activities");
                SetRelatedEntities("business_unit_appointment_activities", null, value);
                OnPropertyChanged("business_unit_appointment_activities");
            }
        }

        /// <summary>
        ///     1:N business_unit_asyncoperation
        /// </summary>
        [RelationshipSchemaName("business_unit_asyncoperation")]
        public IEnumerable<AsyncOperation> business_unit_asyncoperation
        {
            get { return GetRelatedEntities<AsyncOperation>("business_unit_asyncoperation", null); }
            set
            {
                OnPropertyChanging("business_unit_asyncoperation");
                SetRelatedEntities("business_unit_asyncoperation", null, value);
                OnPropertyChanged("business_unit_asyncoperation");
            }
        }

        /// <summary>
        ///     1:N business_unit_BulkOperation_activities
        /// </summary>
        [RelationshipSchemaName("business_unit_BulkOperation_activities")]
        public IEnumerable<BulkOperation> business_unit_BulkOperation_activities
        {
            get { return GetRelatedEntities<BulkOperation>("business_unit_BulkOperation_activities", null); }
            set
            {
                OnPropertyChanging("business_unit_BulkOperation_activities");
                SetRelatedEntities("business_unit_BulkOperation_activities", null, value);
                OnPropertyChanged("business_unit_BulkOperation_activities");
            }
        }

        /// <summary>
        ///     1:N business_unit_calendars
        /// </summary>
        [RelationshipSchemaName("business_unit_calendars")]
        public IEnumerable<Calendar> business_unit_calendars
        {
            get { return GetRelatedEntities<Calendar>("business_unit_calendars", null); }
            set
            {
                OnPropertyChanging("business_unit_calendars");
                SetRelatedEntities("business_unit_calendars", null, value);
                OnPropertyChanged("business_unit_calendars");
            }
        }

        /// <summary>
        ///     1:N business_unit_campaignactivity_activities
        /// </summary>
        [RelationshipSchemaName("business_unit_campaignactivity_activities")]
        public IEnumerable<CampaignActivity> business_unit_campaignactivity_activities
        {
            get { return GetRelatedEntities<CampaignActivity>("business_unit_campaignactivity_activities", null); }
            set
            {
                OnPropertyChanging("business_unit_campaignactivity_activities");
                SetRelatedEntities("business_unit_campaignactivity_activities", null, value);
                OnPropertyChanged("business_unit_campaignactivity_activities");
            }
        }

        /// <summary>
        ///     1:N business_unit_campaignresponse_activities
        /// </summary>
        [RelationshipSchemaName("business_unit_campaignresponse_activities")]
        public IEnumerable<CampaignResponse> business_unit_campaignresponse_activities
        {
            get { return GetRelatedEntities<CampaignResponse>("business_unit_campaignresponse_activities", null); }
            set
            {
                OnPropertyChanging("business_unit_campaignresponse_activities");
                SetRelatedEntities("business_unit_campaignresponse_activities", null, value);
                OnPropertyChanged("business_unit_campaignresponse_activities");
            }
        }

        /// <summary>
        ///     1:N business_unit_connections
        /// </summary>
        [RelationshipSchemaName("business_unit_connections")]
        public IEnumerable<Connection> business_unit_connections
        {
            get { return GetRelatedEntities<Connection>("business_unit_connections", null); }
            set
            {
                OnPropertyChanging("business_unit_connections");
                SetRelatedEntities("business_unit_connections", null, value);
                OnPropertyChanged("business_unit_connections");
            }
        }

        /// <summary>
        ///     1:N business_unit_constraint_based_groups
        /// </summary>
        [RelationshipSchemaName("business_unit_constraint_based_groups")]
        public IEnumerable<ConstraintBasedGroup> business_unit_constraint_based_groups
        {
            get { return GetRelatedEntities<ConstraintBasedGroup>("business_unit_constraint_based_groups", null); }
            set
            {
                OnPropertyChanging("business_unit_constraint_based_groups");
                SetRelatedEntities("business_unit_constraint_based_groups", null, value);
                OnPropertyChanged("business_unit_constraint_based_groups");
            }
        }

        /// <summary>
        ///     1:N business_unit_contacts
        /// </summary>
        [RelationshipSchemaName("business_unit_contacts")]
        public IEnumerable<Contact> business_unit_contacts
        {
            get { return GetRelatedEntities<Contact>("business_unit_contacts", null); }
            set
            {
                OnPropertyChanging("business_unit_contacts");
                SetRelatedEntities("business_unit_contacts", null, value);
                OnPropertyChanged("business_unit_contacts");
            }
        }

        /// <summary>
        ///     1:N business_unit_customer_relationship
        /// </summary>
        [RelationshipSchemaName("business_unit_customer_relationship")]
        public IEnumerable<CustomerRelationship> business_unit_customer_relationship
        {
            get { return GetRelatedEntities<CustomerRelationship>("business_unit_customer_relationship", null); }
            set
            {
                OnPropertyChanging("business_unit_customer_relationship");
                SetRelatedEntities("business_unit_customer_relationship", null, value);
                OnPropertyChanged("business_unit_customer_relationship");
            }
        }

        /// <summary>
        ///     1:N business_unit_email_activities
        /// </summary>
        [RelationshipSchemaName("business_unit_email_activities")]
        public IEnumerable<Email> business_unit_email_activities
        {
            get { return GetRelatedEntities<Email>("business_unit_email_activities", null); }
            set
            {
                OnPropertyChanging("business_unit_email_activities");
                SetRelatedEntities("business_unit_email_activities", null, value);
                OnPropertyChanged("business_unit_email_activities");
            }
        }

        /// <summary>
        ///     1:N business_unit_emailserverprofile
        /// </summary>
        [RelationshipSchemaName("business_unit_emailserverprofile")]
        public IEnumerable<EmailServerProfile> business_unit_emailserverprofile
        {
            get { return GetRelatedEntities<EmailServerProfile>("business_unit_emailserverprofile", null); }
            set
            {
                OnPropertyChanging("business_unit_emailserverprofile");
                SetRelatedEntities("business_unit_emailserverprofile", null, value);
                OnPropertyChanged("business_unit_emailserverprofile");
            }
        }

        /// <summary>
        ///     1:N business_unit_equipment
        /// </summary>
        [RelationshipSchemaName("business_unit_equipment")]
        public IEnumerable<Equipment> business_unit_equipment
        {
            get { return GetRelatedEntities<Equipment>("business_unit_equipment", null); }
            set
            {
                OnPropertyChanging("business_unit_equipment");
                SetRelatedEntities("business_unit_equipment", null, value);
                OnPropertyChanged("business_unit_equipment");
            }
        }

        /// <summary>
        ///     1:N business_unit_exchangesyncidmapping
        /// </summary>
        [RelationshipSchemaName("business_unit_exchangesyncidmapping")]
        public IEnumerable<ExchangeSyncIdMapping> business_unit_exchangesyncidmapping
        {
            get { return GetRelatedEntities<ExchangeSyncIdMapping>("business_unit_exchangesyncidmapping", null); }
            set
            {
                OnPropertyChanging("business_unit_exchangesyncidmapping");
                SetRelatedEntities("business_unit_exchangesyncidmapping", null, value);
                OnPropertyChanged("business_unit_exchangesyncidmapping");
            }
        }

        /// <summary>
        ///     1:N business_unit_fax_activities
        /// </summary>
        [RelationshipSchemaName("business_unit_fax_activities")]
        public IEnumerable<Fax> business_unit_fax_activities
        {
            get { return GetRelatedEntities<Fax>("business_unit_fax_activities", null); }
            set
            {
                OnPropertyChanging("business_unit_fax_activities");
                SetRelatedEntities("business_unit_fax_activities", null, value);
                OnPropertyChanged("business_unit_fax_activities");
            }
        }

        /// <summary>
        ///     1:N business_unit_goal
        /// </summary>
        [RelationshipSchemaName("business_unit_goal")]
        public IEnumerable<Goal> business_unit_goal
        {
            get { return GetRelatedEntities<Goal>("business_unit_goal", null); }
            set
            {
                OnPropertyChanging("business_unit_goal");
                SetRelatedEntities("business_unit_goal", null, value);
                OnPropertyChanged("business_unit_goal");
            }
        }

        /// <summary>
        ///     1:N business_unit_goalrollupquery
        /// </summary>
        [RelationshipSchemaName("business_unit_goalrollupquery")]
        public IEnumerable<GoalRollupQuery> business_unit_goalrollupquery
        {
            get { return GetRelatedEntities<GoalRollupQuery>("business_unit_goalrollupquery", null); }
            set
            {
                OnPropertyChanging("business_unit_goalrollupquery");
                SetRelatedEntities("business_unit_goalrollupquery", null, value);
                OnPropertyChanged("business_unit_goalrollupquery");
            }
        }

        /// <summary>
        ///     1:N business_unit_incident_resolution_activities
        /// </summary>
        [RelationshipSchemaName("business_unit_incident_resolution_activities")]
        public IEnumerable<IncidentResolution> business_unit_incident_resolution_activities
        {
            get { return GetRelatedEntities<IncidentResolution>("business_unit_incident_resolution_activities", null); }
            set
            {
                OnPropertyChanging("business_unit_incident_resolution_activities");
                SetRelatedEntities("business_unit_incident_resolution_activities", null, value);
                OnPropertyChanged("business_unit_incident_resolution_activities");
            }
        }

        /// <summary>
        ///     1:N business_unit_incidents
        /// </summary>
        [RelationshipSchemaName("business_unit_incidents")]
        public IEnumerable<Incident> business_unit_incidents
        {
            get { return GetRelatedEntities<Incident>("business_unit_incidents", null); }
            set
            {
                OnPropertyChanging("business_unit_incidents");
                SetRelatedEntities("business_unit_incidents", null, value);
                OnPropertyChanged("business_unit_incidents");
            }
        }

        /// <summary>
        ///     1:N business_unit_invoices
        /// </summary>
        [RelationshipSchemaName("business_unit_invoices")]
        public IEnumerable<Invoice> business_unit_invoices
        {
            get { return GetRelatedEntities<Invoice>("business_unit_invoices", null); }
            set
            {
                OnPropertyChanging("business_unit_invoices");
                SetRelatedEntities("business_unit_invoices", null, value);
                OnPropertyChanged("business_unit_invoices");
            }
        }

        /// <summary>
        ///     1:N business_unit_leads
        /// </summary>
        [RelationshipSchemaName("business_unit_leads")]
        public IEnumerable<Lead> business_unit_leads
        {
            get { return GetRelatedEntities<Lead>("business_unit_leads", null); }
            set
            {
                OnPropertyChanging("business_unit_leads");
                SetRelatedEntities("business_unit_leads", null, value);
                OnPropertyChanged("business_unit_leads");
            }
        }

        /// <summary>
        ///     1:N business_unit_letter_activities
        /// </summary>
        [RelationshipSchemaName("business_unit_letter_activities")]
        public IEnumerable<Letter> business_unit_letter_activities
        {
            get { return GetRelatedEntities<Letter>("business_unit_letter_activities", null); }
            set
            {
                OnPropertyChanging("business_unit_letter_activities");
                SetRelatedEntities("business_unit_letter_activities", null, value);
                OnPropertyChanged("business_unit_letter_activities");
            }
        }

        /// <summary>
        ///     1:N business_unit_list
        /// </summary>
        [RelationshipSchemaName("business_unit_list")]
        public IEnumerable<List> business_unit_list
        {
            get { return GetRelatedEntities<List>("business_unit_list", null); }
            set
            {
                OnPropertyChanging("business_unit_list");
                SetRelatedEntities("business_unit_list", null, value);
                OnPropertyChanged("business_unit_list");
            }
        }

        /// <summary>
        ///     1:N business_unit_mailbox
        /// </summary>
        [RelationshipSchemaName("business_unit_mailbox")]
        public IEnumerable<Mailbox> business_unit_mailbox
        {
            get { return GetRelatedEntities<Mailbox>("business_unit_mailbox", null); }
            set
            {
                OnPropertyChanging("business_unit_mailbox");
                SetRelatedEntities("business_unit_mailbox", null, value);
                OnPropertyChanged("business_unit_mailbox");
            }
        }

        /// <summary>
        ///     1:N business_unit_mailmergetemplates
        /// </summary>
        [RelationshipSchemaName("business_unit_mailmergetemplates")]
        public IEnumerable<MailMergeTemplate> business_unit_mailmergetemplates
        {
            get { return GetRelatedEntities<MailMergeTemplate>("business_unit_mailmergetemplates", null); }
            set
            {
                OnPropertyChanging("business_unit_mailmergetemplates");
                SetRelatedEntities("business_unit_mailmergetemplates", null, value);
                OnPropertyChanged("business_unit_mailmergetemplates");
            }
        }

        /// <summary>
        ///     1:N business_unit_msdyn_postalbum
        /// </summary>
        [RelationshipSchemaName("business_unit_msdyn_postalbum")]
        public IEnumerable<msdyn_PostAlbum> business_unit_msdyn_postalbum
        {
            get { return GetRelatedEntities<msdyn_PostAlbum>("business_unit_msdyn_postalbum", null); }
            set
            {
                OnPropertyChanging("business_unit_msdyn_postalbum");
                SetRelatedEntities("business_unit_msdyn_postalbum", null, value);
                OnPropertyChanged("business_unit_msdyn_postalbum");
            }
        }

        /// <summary>
        ///     1:N business_unit_msdyn_wallsavedqueryusersettings
        /// </summary>
        [RelationshipSchemaName("business_unit_msdyn_wallsavedqueryusersettings")]
        public IEnumerable<msdyn_wallsavedqueryusersettings> business_unit_msdyn_wallsavedqueryusersettings
        {
            get
            {
                return
                    GetRelatedEntities<msdyn_wallsavedqueryusersettings>(
                        "business_unit_msdyn_wallsavedqueryusersettings", null);
            }
            set
            {
                OnPropertyChanging("business_unit_msdyn_wallsavedqueryusersettings");
                SetRelatedEntities("business_unit_msdyn_wallsavedqueryusersettings", null, value);
                OnPropertyChanged("business_unit_msdyn_wallsavedqueryusersettings");
            }
        }

        /// <summary>
        ///     1:N business_unit_opportunities
        /// </summary>
        [RelationshipSchemaName("business_unit_opportunities")]
        public IEnumerable<Opportunity> business_unit_opportunities
        {
            get { return GetRelatedEntities<Opportunity>("business_unit_opportunities", null); }
            set
            {
                OnPropertyChanging("business_unit_opportunities");
                SetRelatedEntities("business_unit_opportunities", null, value);
                OnPropertyChanged("business_unit_opportunities");
            }
        }

        /// <summary>
        ///     1:N business_unit_opportunity_close_activities
        /// </summary>
        [RelationshipSchemaName("business_unit_opportunity_close_activities")]
        public IEnumerable<OpportunityClose> business_unit_opportunity_close_activities
        {
            get { return GetRelatedEntities<OpportunityClose>("business_unit_opportunity_close_activities", null); }
            set
            {
                OnPropertyChanging("business_unit_opportunity_close_activities");
                SetRelatedEntities("business_unit_opportunity_close_activities", null, value);
                OnPropertyChanged("business_unit_opportunity_close_activities");
            }
        }

        /// <summary>
        ///     1:N business_unit_order_close_activities
        /// </summary>
        [RelationshipSchemaName("business_unit_order_close_activities")]
        public IEnumerable<OrderClose> business_unit_order_close_activities
        {
            get { return GetRelatedEntities<OrderClose>("business_unit_order_close_activities", null); }
            set
            {
                OnPropertyChanging("business_unit_order_close_activities");
                SetRelatedEntities("business_unit_order_close_activities", null, value);
                OnPropertyChanged("business_unit_order_close_activities");
            }
        }

        /// <summary>
        ///     1:N business_unit_orders
        /// </summary>
        [RelationshipSchemaName("business_unit_orders")]
        public IEnumerable<SalesOrder> business_unit_orders
        {
            get { return GetRelatedEntities<SalesOrder>("business_unit_orders", null); }
            set
            {
                OnPropertyChanging("business_unit_orders");
                SetRelatedEntities("business_unit_orders", null, value);
                OnPropertyChanged("business_unit_orders");
            }
        }

        /// <summary>
        ///     1:N business_unit_parent_business_unit
        /// </summary>
        [RelationshipSchemaName("business_unit_parent_business_unit", EntityRole.Referenced)]
        public IEnumerable<BusinessUnit> Referencedbusiness_unit_parent_business_unit
        {
            get
            {
                return GetRelatedEntities<BusinessUnit>("business_unit_parent_business_unit", EntityRole.Referenced);
            }
            set
            {
                OnPropertyChanging("Referencedbusiness_unit_parent_business_unit");
                SetRelatedEntities("business_unit_parent_business_unit", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedbusiness_unit_parent_business_unit");
            }
        }

        /// <summary>
        ///     1:N business_unit_phone_call_activities
        /// </summary>
        [RelationshipSchemaName("business_unit_phone_call_activities")]
        public IEnumerable<PhoneCall> business_unit_phone_call_activities
        {
            get { return GetRelatedEntities<PhoneCall>("business_unit_phone_call_activities", null); }
            set
            {
                OnPropertyChanging("business_unit_phone_call_activities");
                SetRelatedEntities("business_unit_phone_call_activities", null, value);
                OnPropertyChanged("business_unit_phone_call_activities");
            }
        }

        /// <summary>
        ///     1:N business_unit_postfollows
        /// </summary>
        [RelationshipSchemaName("business_unit_postfollows")]
        public IEnumerable<PostFollow> business_unit_postfollows
        {
            get { return GetRelatedEntities<PostFollow>("business_unit_postfollows", null); }
            set
            {
                OnPropertyChanging("business_unit_postfollows");
                SetRelatedEntities("business_unit_postfollows", null, value);
                OnPropertyChanged("business_unit_postfollows");
            }
        }

        /// <summary>
        ///     1:N business_unit_queues
        /// </summary>
        [RelationshipSchemaName("business_unit_queues")]
        public IEnumerable<Queue> business_unit_queues
        {
            get { return GetRelatedEntities<Queue>("business_unit_queues", null); }
            set
            {
                OnPropertyChanging("business_unit_queues");
                SetRelatedEntities("business_unit_queues", null, value);
                OnPropertyChanged("business_unit_queues");
            }
        }

        /// <summary>
        ///     1:N business_unit_queues2
        /// </summary>
        [RelationshipSchemaName("business_unit_queues2")]
        public IEnumerable<Queue> business_unit_queues2
        {
            get { return GetRelatedEntities<Queue>("business_unit_queues2", null); }
            set
            {
                OnPropertyChanging("business_unit_queues2");
                SetRelatedEntities("business_unit_queues2", null, value);
                OnPropertyChanged("business_unit_queues2");
            }
        }

        /// <summary>
        ///     1:N business_unit_quote_close_activities
        /// </summary>
        [RelationshipSchemaName("business_unit_quote_close_activities")]
        public IEnumerable<QuoteClose> business_unit_quote_close_activities
        {
            get { return GetRelatedEntities<QuoteClose>("business_unit_quote_close_activities", null); }
            set
            {
                OnPropertyChanging("business_unit_quote_close_activities");
                SetRelatedEntities("business_unit_quote_close_activities", null, value);
                OnPropertyChanged("business_unit_quote_close_activities");
            }
        }

        /// <summary>
        ///     1:N business_unit_quotes
        /// </summary>
        [RelationshipSchemaName("business_unit_quotes")]
        public IEnumerable<Quote> business_unit_quotes
        {
            get { return GetRelatedEntities<Quote>("business_unit_quotes", null); }
            set
            {
                OnPropertyChanging("business_unit_quotes");
                SetRelatedEntities("business_unit_quotes", null, value);
                OnPropertyChanged("business_unit_quotes");
            }
        }

        /// <summary>
        ///     1:N business_unit_recurrencerule
        /// </summary>
        [RelationshipSchemaName("business_unit_recurrencerule")]
        public IEnumerable<RecurrenceRule> business_unit_recurrencerule
        {
            get { return GetRelatedEntities<RecurrenceRule>("business_unit_recurrencerule", null); }
            set
            {
                OnPropertyChanging("business_unit_recurrencerule");
                SetRelatedEntities("business_unit_recurrencerule", null, value);
                OnPropertyChanged("business_unit_recurrencerule");
            }
        }

        /// <summary>
        ///     1:N business_unit_recurringappointmentmaster_activities
        /// </summary>
        [RelationshipSchemaName("business_unit_recurringappointmentmaster_activities")]
        public IEnumerable<RecurringAppointmentMaster> business_unit_recurringappointmentmaster_activities
        {
            get
            {
                return
                    GetRelatedEntities<RecurringAppointmentMaster>(
                        "business_unit_recurringappointmentmaster_activities", null);
            }
            set
            {
                OnPropertyChanging("business_unit_recurringappointmentmaster_activities");
                SetRelatedEntities("business_unit_recurringappointmentmaster_activities", null, value);
                OnPropertyChanged("business_unit_recurringappointmentmaster_activities");
            }
        }

        /// <summary>
        ///     1:N business_unit_reports
        /// </summary>
        [RelationshipSchemaName("business_unit_reports")]
        public IEnumerable<Report> business_unit_reports
        {
            get { return GetRelatedEntities<Report>("business_unit_reports", null); }
            set
            {
                OnPropertyChanging("business_unit_reports");
                SetRelatedEntities("business_unit_reports", null, value);
                OnPropertyChanged("business_unit_reports");
            }
        }

        /// <summary>
        ///     1:N business_unit_resource_groups
        /// </summary>
        [RelationshipSchemaName("business_unit_resource_groups")]
        public IEnumerable<ResourceGroup> business_unit_resource_groups
        {
            get { return GetRelatedEntities<ResourceGroup>("business_unit_resource_groups", null); }
            set
            {
                OnPropertyChanging("business_unit_resource_groups");
                SetRelatedEntities("business_unit_resource_groups", null, value);
                OnPropertyChanged("business_unit_resource_groups");
            }
        }

        /// <summary>
        ///     1:N business_unit_resource_specs
        /// </summary>
        [RelationshipSchemaName("business_unit_resource_specs")]
        public IEnumerable<ResourceSpec> business_unit_resource_specs
        {
            get { return GetRelatedEntities<ResourceSpec>("business_unit_resource_specs", null); }
            set
            {
                OnPropertyChanging("business_unit_resource_specs");
                SetRelatedEntities("business_unit_resource_specs", null, value);
                OnPropertyChanged("business_unit_resource_specs");
            }
        }

        /// <summary>
        ///     1:N business_unit_resources
        /// </summary>
        [RelationshipSchemaName("business_unit_resources")]
        public IEnumerable<Resource> business_unit_resources
        {
            get { return GetRelatedEntities<Resource>("business_unit_resources", null); }
            set
            {
                OnPropertyChanging("business_unit_resources");
                SetRelatedEntities("business_unit_resources", null, value);
                OnPropertyChanged("business_unit_resources");
            }
        }

        /// <summary>
        ///     1:N business_unit_roles
        /// </summary>
        [RelationshipSchemaName("business_unit_roles")]
        public IEnumerable<Role> business_unit_roles
        {
            get { return GetRelatedEntities<Role>("business_unit_roles", null); }
            set
            {
                OnPropertyChanging("business_unit_roles");
                SetRelatedEntities("business_unit_roles", null, value);
                OnPropertyChanged("business_unit_roles");
            }
        }

        /// <summary>
        ///     1:N business_unit_service_appointments
        /// </summary>
        [RelationshipSchemaName("business_unit_service_appointments")]
        public IEnumerable<ServiceAppointment> business_unit_service_appointments
        {
            get { return GetRelatedEntities<ServiceAppointment>("business_unit_service_appointments", null); }
            set
            {
                OnPropertyChanging("business_unit_service_appointments");
                SetRelatedEntities("business_unit_service_appointments", null, value);
                OnPropertyChanged("business_unit_service_appointments");
            }
        }

        /// <summary>
        ///     1:N business_unit_service_contracts
        /// </summary>
        [RelationshipSchemaName("business_unit_service_contracts")]
        public IEnumerable<Contract> business_unit_service_contracts
        {
            get { return GetRelatedEntities<Contract>("business_unit_service_contracts", null); }
            set
            {
                OnPropertyChanging("business_unit_service_contracts");
                SetRelatedEntities("business_unit_service_contracts", null, value);
                OnPropertyChanged("business_unit_service_contracts");
            }
        }

        /// <summary>
        ///     1:N business_unit_sharepointdocumentlocation
        /// </summary>
        [RelationshipSchemaName("business_unit_sharepointdocumentlocation")]
        public IEnumerable<SharePointDocumentLocation> business_unit_sharepointdocumentlocation
        {
            get
            {
                return GetRelatedEntities<SharePointDocumentLocation>("business_unit_sharepointdocumentlocation", null);
            }
            set
            {
                OnPropertyChanging("business_unit_sharepointdocumentlocation");
                SetRelatedEntities("business_unit_sharepointdocumentlocation", null, value);
                OnPropertyChanged("business_unit_sharepointdocumentlocation");
            }
        }

        /// <summary>
        ///     1:N business_unit_sharepointsites
        /// </summary>
        [RelationshipSchemaName("business_unit_sharepointsites")]
        public IEnumerable<SharePointSite> business_unit_sharepointsites
        {
            get { return GetRelatedEntities<SharePointSite>("business_unit_sharepointsites", null); }
            set
            {
                OnPropertyChanging("business_unit_sharepointsites");
                SetRelatedEntities("business_unit_sharepointsites", null, value);
                OnPropertyChanged("business_unit_sharepointsites");
            }
        }

        /// <summary>
        ///     1:N business_unit_system_users
        /// </summary>
        [RelationshipSchemaName("business_unit_system_users")]
        public IEnumerable<SystemUser> business_unit_system_users
        {
            get { return GetRelatedEntities<SystemUser>("business_unit_system_users", null); }
            set
            {
                OnPropertyChanging("business_unit_system_users");
                SetRelatedEntities("business_unit_system_users", null, value);
                OnPropertyChanged("business_unit_system_users");
            }
        }

        /// <summary>
        ///     1:N business_unit_task_activities
        /// </summary>
        [RelationshipSchemaName("business_unit_task_activities")]
        public IEnumerable<Task> business_unit_task_activities
        {
            get { return GetRelatedEntities<Task>("business_unit_task_activities", null); }
            set
            {
                OnPropertyChanging("business_unit_task_activities");
                SetRelatedEntities("business_unit_task_activities", null, value);
                OnPropertyChanged("business_unit_task_activities");
            }
        }

        /// <summary>
        ///     1:N business_unit_teams
        /// </summary>
        [RelationshipSchemaName("business_unit_teams")]
        public IEnumerable<Team> business_unit_teams
        {
            get { return GetRelatedEntities<Team>("business_unit_teams", null); }
            set
            {
                OnPropertyChanging("business_unit_teams");
                SetRelatedEntities("business_unit_teams", null, value);
                OnPropertyChanged("business_unit_teams");
            }
        }

        /// <summary>
        ///     1:N business_unit_templates
        /// </summary>
        [RelationshipSchemaName("business_unit_templates")]
        public IEnumerable<Template> business_unit_templates
        {
            get { return GetRelatedEntities<Template>("business_unit_templates", null); }
            set
            {
                OnPropertyChanging("business_unit_templates");
                SetRelatedEntities("business_unit_templates", null, value);
                OnPropertyChanged("business_unit_templates");
            }
        }

        /// <summary>
        ///     1:N business_unit_user_settings
        /// </summary>
        [RelationshipSchemaName("business_unit_user_settings")]
        public IEnumerable<UserSettings> business_unit_user_settings
        {
            get { return GetRelatedEntities<UserSettings>("business_unit_user_settings", null); }
            set
            {
                OnPropertyChanging("business_unit_user_settings");
                SetRelatedEntities("business_unit_user_settings", null, value);
                OnPropertyChanged("business_unit_user_settings");
            }
        }

        /// <summary>
        ///     1:N business_unit_userform
        /// </summary>
        [RelationshipSchemaName("business_unit_userform")]
        public IEnumerable<UserForm> business_unit_userform
        {
            get { return GetRelatedEntities<UserForm>("business_unit_userform", null); }
            set
            {
                OnPropertyChanging("business_unit_userform");
                SetRelatedEntities("business_unit_userform", null, value);
                OnPropertyChanged("business_unit_userform");
            }
        }

        /// <summary>
        ///     1:N business_unit_userquery
        /// </summary>
        [RelationshipSchemaName("business_unit_userquery")]
        public IEnumerable<UserQuery> business_unit_userquery
        {
            get { return GetRelatedEntities<UserQuery>("business_unit_userquery", null); }
            set
            {
                OnPropertyChanging("business_unit_userquery");
                SetRelatedEntities("business_unit_userquery", null, value);
                OnPropertyChanged("business_unit_userquery");
            }
        }

        /// <summary>
        ///     1:N business_unit_userqueryvisualizations
        /// </summary>
        [RelationshipSchemaName("business_unit_userqueryvisualizations")]
        public IEnumerable<UserQueryVisualization> business_unit_userqueryvisualizations
        {
            get { return GetRelatedEntities<UserQueryVisualization>("business_unit_userqueryvisualizations", null); }
            set
            {
                OnPropertyChanging("business_unit_userqueryvisualizations");
                SetRelatedEntities("business_unit_userqueryvisualizations", null, value);
                OnPropertyChanged("business_unit_userqueryvisualizations");
            }
        }

        /// <summary>
        ///     1:N business_unit_workflow
        /// </summary>
        [RelationshipSchemaName("business_unit_workflow")]
        public IEnumerable<Workflow> business_unit_workflow
        {
            get { return GetRelatedEntities<Workflow>("business_unit_workflow", null); }
            set
            {
                OnPropertyChanging("business_unit_workflow");
                SetRelatedEntities("business_unit_workflow", null, value);
                OnPropertyChanged("business_unit_workflow");
            }
        }

        /// <summary>
        ///     1:N business_unit_workflowlogs
        /// </summary>
        [RelationshipSchemaName("business_unit_workflowlogs")]
        public IEnumerable<WorkflowLog> business_unit_workflowlogs
        {
            get { return GetRelatedEntities<WorkflowLog>("business_unit_workflowlogs", null); }
            set
            {
                OnPropertyChanging("business_unit_workflowlogs");
                SetRelatedEntities("business_unit_workflowlogs", null, value);
                OnPropertyChanged("business_unit_workflowlogs");
            }
        }

        /// <summary>
        ///     1:N BusinessUnit_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("BusinessUnit_AsyncOperations")]
        public IEnumerable<AsyncOperation> BusinessUnit_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("BusinessUnit_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("BusinessUnit_AsyncOperations");
                SetRelatedEntities("BusinessUnit_AsyncOperations", null, value);
                OnPropertyChanged("BusinessUnit_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N BusinessUnit_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("BusinessUnit_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> BusinessUnit_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("BusinessUnit_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("BusinessUnit_BulkDeleteFailures");
                SetRelatedEntities("BusinessUnit_BulkDeleteFailures", null, value);
                OnPropertyChanged("BusinessUnit_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N BusinessUnit_Campaigns
        /// </summary>
        [RelationshipSchemaName("BusinessUnit_Campaigns")]
        public IEnumerable<Campaign> BusinessUnit_Campaigns
        {
            get { return GetRelatedEntities<Campaign>("BusinessUnit_Campaigns", null); }
            set
            {
                OnPropertyChanging("BusinessUnit_Campaigns");
                SetRelatedEntities("BusinessUnit_Campaigns", null, value);
                OnPropertyChanged("BusinessUnit_Campaigns");
            }
        }

        /// <summary>
        ///     1:N BusinessUnit_DuplicateRules
        /// </summary>
        [RelationshipSchemaName("BusinessUnit_DuplicateRules")]
        public IEnumerable<DuplicateRule> BusinessUnit_DuplicateRules
        {
            get { return GetRelatedEntities<DuplicateRule>("BusinessUnit_DuplicateRules", null); }
            set
            {
                OnPropertyChanging("BusinessUnit_DuplicateRules");
                SetRelatedEntities("BusinessUnit_DuplicateRules", null, value);
                OnPropertyChanged("BusinessUnit_DuplicateRules");
            }
        }

        /// <summary>
        ///     1:N BusinessUnit_ImportFiles
        /// </summary>
        [RelationshipSchemaName("BusinessUnit_ImportFiles")]
        public IEnumerable<ImportFile> BusinessUnit_ImportFiles
        {
            get { return GetRelatedEntities<ImportFile>("BusinessUnit_ImportFiles", null); }
            set
            {
                OnPropertyChanging("BusinessUnit_ImportFiles");
                SetRelatedEntities("BusinessUnit_ImportFiles", null, value);
                OnPropertyChanged("BusinessUnit_ImportFiles");
            }
        }

        /// <summary>
        ///     1:N BusinessUnit_ImportLogs
        /// </summary>
        [RelationshipSchemaName("BusinessUnit_ImportLogs")]
        public IEnumerable<ImportLog> BusinessUnit_ImportLogs
        {
            get { return GetRelatedEntities<ImportLog>("BusinessUnit_ImportLogs", null); }
            set
            {
                OnPropertyChanging("BusinessUnit_ImportLogs");
                SetRelatedEntities("BusinessUnit_ImportLogs", null, value);
                OnPropertyChanged("BusinessUnit_ImportLogs");
            }
        }

        /// <summary>
        ///     1:N BusinessUnit_ImportMaps
        /// </summary>
        [RelationshipSchemaName("BusinessUnit_ImportMaps")]
        public IEnumerable<ImportMap> BusinessUnit_ImportMaps
        {
            get { return GetRelatedEntities<ImportMap>("BusinessUnit_ImportMaps", null); }
            set
            {
                OnPropertyChanging("BusinessUnit_ImportMaps");
                SetRelatedEntities("BusinessUnit_ImportMaps", null, value);
                OnPropertyChanged("BusinessUnit_ImportMaps");
            }
        }

        /// <summary>
        ///     1:N BusinessUnit_Imports
        /// </summary>
        [RelationshipSchemaName("BusinessUnit_Imports")]
        public IEnumerable<Import> BusinessUnit_Imports
        {
            get { return GetRelatedEntities<Import>("BusinessUnit_Imports", null); }
            set
            {
                OnPropertyChanging("BusinessUnit_Imports");
                SetRelatedEntities("BusinessUnit_Imports", null, value);
                OnPropertyChanged("BusinessUnit_Imports");
            }
        }

        /// <summary>
        ///     1:N businessunit_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("businessunit_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> businessunit_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntities<PrincipalObjectAttributeAccess>(
                    "businessunit_principalobjectattributeaccess", null);
            }
            set
            {
                OnPropertyChanging("businessunit_principalobjectattributeaccess");
                SetRelatedEntities("businessunit_principalobjectattributeaccess", null, value);
                OnPropertyChanged("businessunit_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N BusinessUnit_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("BusinessUnit_ProcessSessions")]
        public IEnumerable<ProcessSession> BusinessUnit_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("BusinessUnit_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("BusinessUnit_ProcessSessions");
                SetRelatedEntities("BusinessUnit_ProcessSessions", null, value);
                OnPropertyChanged("BusinessUnit_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N Owning_businessunit_processsessions
        /// </summary>
        [RelationshipSchemaName("Owning_businessunit_processsessions")]
        public IEnumerable<ProcessSession> Owning_businessunit_processsessions
        {
            get { return GetRelatedEntities<ProcessSession>("Owning_businessunit_processsessions", null); }
            set
            {
                OnPropertyChanging("Owning_businessunit_processsessions");
                SetRelatedEntities("Owning_businessunit_processsessions", null, value);
                OnPropertyChanged("Owning_businessunit_processsessions");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_businessunit
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_businessunit")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_businessunit
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_businessunit", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_businessunit");
                SetRelatedEntities("userentityinstancedata_businessunit", null, value);
                OnPropertyChanged("userentityinstancedata_businessunit");
            }
        }

        /// <summary>
        ///     1:N userentityuisettings_businessunit
        /// </summary>
        [RelationshipSchemaName("userentityuisettings_businessunit")]
        public IEnumerable<UserEntityUISettings> userentityuisettings_businessunit
        {
            get { return GetRelatedEntities<UserEntityUISettings>("userentityuisettings_businessunit", null); }
            set
            {
                OnPropertyChanging("userentityuisettings_businessunit");
                SetRelatedEntities("userentityuisettings_businessunit", null, value);
                OnPropertyChanged("userentityuisettings_businessunit");
            }
        }

        /// <summary>
        ///     N:1 business_unit_parent_business_unit
        /// </summary>
        [AttributeLogicalName("parentbusinessunitid")]
        [RelationshipSchemaName("business_unit_parent_business_unit", EntityRole.Referencing)]
        public BusinessUnit Referencingbusiness_unit_parent_business_unit
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_parent_business_unit", EntityRole.Referencing); }
            set
            {
                OnPropertyChanging("Referencingbusiness_unit_parent_business_unit");
                SetRelatedEntity("business_unit_parent_business_unit", EntityRole.Referencing, value);
                OnPropertyChanged("Referencingbusiness_unit_parent_business_unit");
            }
        }

        /// <summary>
        ///     N:1 BusinessUnit_Calendar
        /// </summary>
        [AttributeLogicalName("calendarid")]
        [RelationshipSchemaName("BusinessUnit_Calendar")]
        public Calendar BusinessUnit_Calendar
        {
            get { return GetRelatedEntity<Calendar>("BusinessUnit_Calendar", null); }
            set
            {
                OnPropertyChanging("BusinessUnit_Calendar");
                SetRelatedEntity("BusinessUnit_Calendar", null, value);
                OnPropertyChanged("BusinessUnit_Calendar");
            }
        }

        /// <summary>
        ///     N:1 lk_businessunit_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_businessunit_createdonbehalfby")]
        public SystemUser lk_businessunit_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_businessunit_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_businessunit_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_businessunit_modifiedonbehalfby")]
        public SystemUser lk_businessunit_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_businessunit_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_businessunitbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_businessunitbase_createdby")]
        public SystemUser lk_businessunitbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_businessunitbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_businessunitbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_businessunitbase_modifiedby")]
        public SystemUser lk_businessunitbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_businessunitbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 organization_business_units
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_business_units")]
        public Organization organization_business_units
        {
            get { return GetRelatedEntity<Organization>("organization_business_units", null); }
        }

        /// <summary>
        ///     N:1 TransactionCurrency_BusinessUnit
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("TransactionCurrency_BusinessUnit")]
        public TransactionCurrency TransactionCurrency_BusinessUnit
        {
            get { return GetRelatedEntity<TransactionCurrency>("TransactionCurrency_BusinessUnit", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_BusinessUnit");
                SetRelatedEntity("TransactionCurrency_BusinessUnit", null, value);
                OnPropertyChanged("TransactionCurrency_BusinessUnit");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public event PropertyChangingEventHandler PropertyChanging;

        private void OnPropertyChanged(string propertyName)
        {
            if ((PropertyChanged != null))
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void OnPropertyChanging(string propertyName)
        {
            if ((PropertyChanging != null))
            {
                PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
            }
        }
    }
}