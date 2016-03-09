using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Xrm.Framework.CI.PowerShell.Common;

namespace Xrm.Framework.CI.Common.Entities
{
    /// <summary>
    ///     Person with access to the Microsoft CRM system and who owns objects in the Microsoft CRM database.
    /// </summary>
    [DataContract]
    [EntityLogicalName("systemuser")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class SystemUser : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "systemuser";

        public const int EntityTypeCode = 8;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public SystemUser() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Type of user.
        /// </summary>
        [AttributeLogicalName("accessmode")]
        public OptionSetValue AccessMode
        {
            get { return GetAttributeValue<OptionSetValue>("accessmode"); }
            set
            {
                OnPropertyChanging("AccessMode");
                SetAttributeValue("accessmode", value);
                OnPropertyChanged("AccessMode");
            }
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
        ///     Shows the complete primary address.
        /// </summary>
        [AttributeLogicalName("address1_composite")]
        public string Address1_Composite
        {
            get { return GetAttributeValue<string>("address1_composite"); }
        }

        /// <summary>
        ///     Country/region name in address 1.
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
        ///     Shows the complete secondary address.
        /// </summary>
        [AttributeLogicalName("address2_composite")]
        public string Address2_Composite
        {
            get { return GetAttributeValue<string>("address2_composite"); }
        }

        /// <summary>
        ///     Country/region name in address 2.
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
        ///     Unique identifier of the business unit with which the user is associated.
        /// </summary>
        [AttributeLogicalName("businessunitid")]
        public EntityReference BusinessUnitId
        {
            get { return GetAttributeValue<EntityReference>("businessunitid"); }
            set
            {
                OnPropertyChanging("BusinessUnitId");
                SetAttributeValue("businessunitid", value);
                OnPropertyChanged("BusinessUnitId");
            }
        }

        /// <summary>
        ///     Fiscal calendar associated with the user.
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
        ///     License type of user.
        /// </summary>
        [AttributeLogicalName("caltype")]
        public OptionSetValue CALType
        {
            get { return GetAttributeValue<OptionSetValue>("caltype"); }
            set
            {
                OnPropertyChanging("CALType");
                SetAttributeValue("caltype", value);
                OnPropertyChanged("CALType");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the user.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the user was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the systemuser.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Indicates if default outlook filters have been populated.
        /// </summary>
        [AttributeLogicalName("defaultfilterspopulated")]
        public bool? DefaultFiltersPopulated
        {
            get { return GetAttributeValue<bool?>("defaultfilterspopulated"); }
        }

        /// <summary>
        ///     Select the mailbox associated with this user.
        /// </summary>
        [AttributeLogicalName("defaultmailbox")]
        public EntityReference DefaultMailbox
        {
            get { return GetAttributeValue<EntityReference>("defaultmailbox"); }
        }

        /// <summary>
        ///     Reason for disabling the user.
        /// </summary>
        [AttributeLogicalName("disabledreason")]
        public string DisabledReason
        {
            get { return GetAttributeValue<string>("disabledreason"); }
        }

        /// <summary>
        ///     Whether to display the user in service views.
        /// </summary>
        [AttributeLogicalName("displayinserviceviews")]
        public bool? DisplayInServiceViews
        {
            get { return GetAttributeValue<bool?>("displayinserviceviews"); }
            set
            {
                OnPropertyChanging("DisplayInServiceViews");
                SetAttributeValue("displayinserviceviews", value);
                OnPropertyChanged("DisplayInServiceViews");
            }
        }

        /// <summary>
        ///     Active Directory domain of which the user is a member.
        /// </summary>
        [AttributeLogicalName("domainname")]
        public string DomainName
        {
            get { return GetAttributeValue<string>("domainname"); }
            set
            {
                OnPropertyChanging("DomainName");
                SetAttributeValue("domainname", value);
                OnPropertyChanged("DomainName");
            }
        }

        /// <summary>
        ///     Shows the status of the primary email address.
        /// </summary>
        [AttributeLogicalName("emailrouteraccessapproval")]
        public OptionSetValue EmailRouterAccessApproval
        {
            get { return GetAttributeValue<OptionSetValue>("emailrouteraccessapproval"); }
            set
            {
                OnPropertyChanging("EmailRouterAccessApproval");
                SetAttributeValue("emailrouteraccessapproval", value);
                OnPropertyChanged("EmailRouterAccessApproval");
            }
        }

        /// <summary>
        ///     Employee identifier for the user.
        /// </summary>
        [AttributeLogicalName("employeeid")]
        public string EmployeeId
        {
            get { return GetAttributeValue<string>("employeeid"); }
            set
            {
                OnPropertyChanging("EmployeeId");
                SetAttributeValue("employeeid", value);
                OnPropertyChanged("EmployeeId");
            }
        }

        /// <summary>
        ///     Shows the default image for the record.
        /// </summary>
        [AttributeLogicalName("entityimage")]
        public byte[] EntityImage
        {
            get { return GetAttributeValue<byte[]>("entityimage"); }
            set
            {
                OnPropertyChanging("EntityImage");
                SetAttributeValue("entityimage", value);
                OnPropertyChanged("EntityImage");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("entityimage_timestamp")]
        public long? EntityImage_Timestamp
        {
            get { return GetAttributeValue<long?>("entityimage_timestamp"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("entityimage_url")]
        public string EntityImage_URL
        {
            get { return GetAttributeValue<string>("entityimage_url"); }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("entityimageid")]
        public Guid? EntityImageId
        {
            get { return GetAttributeValue<Guid?>("entityimageid"); }
        }

        /// <summary>
        ///     Exchange rate for the currency associated with the systemuser with respect to the base currency.
        /// </summary>
        [AttributeLogicalName("exchangerate")]
        public decimal? ExchangeRate
        {
            get { return GetAttributeValue<decimal?>("exchangerate"); }
        }

        /// <summary>
        ///     First name of the user.
        /// </summary>
        [AttributeLogicalName("firstname")]
        public string FirstName
        {
            get { return GetAttributeValue<string>("firstname"); }
            set
            {
                OnPropertyChanging("FirstName");
                SetAttributeValue("firstname", value);
                OnPropertyChanged("FirstName");
            }
        }

        /// <summary>
        ///     Full name of the user.
        /// </summary>
        [AttributeLogicalName("fullname")]
        public string FullName
        {
            get { return GetAttributeValue<string>("fullname"); }
        }

        /// <summary>
        ///     Government identifier for the user.
        /// </summary>
        [AttributeLogicalName("governmentid")]
        public string GovernmentId
        {
            get { return GetAttributeValue<string>("governmentid"); }
            set
            {
                OnPropertyChanging("GovernmentId");
                SetAttributeValue("governmentid", value);
                OnPropertyChanged("GovernmentId");
            }
        }

        /// <summary>
        ///     Home phone number for the user.
        /// </summary>
        [AttributeLogicalName("homephone")]
        public string HomePhone
        {
            get { return GetAttributeValue<string>("homephone"); }
            set
            {
                OnPropertyChanging("HomePhone");
                SetAttributeValue("homephone", value);
                OnPropertyChanged("HomePhone");
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
        ///     Incoming email delivery method for the user.
        /// </summary>
        [AttributeLogicalName("incomingemaildeliverymethod")]
        public OptionSetValue IncomingEmailDeliveryMethod
        {
            get { return GetAttributeValue<OptionSetValue>("incomingemaildeliverymethod"); }
            set
            {
                OnPropertyChanging("IncomingEmailDeliveryMethod");
                SetAttributeValue("incomingemaildeliverymethod", value);
                OnPropertyChanged("IncomingEmailDeliveryMethod");
            }
        }

        /// <summary>
        ///     Internal email address for the user.
        /// </summary>
        [AttributeLogicalName("internalemailaddress")]
        public string InternalEMailAddress
        {
            get { return GetAttributeValue<string>("internalemailaddress"); }
            set
            {
                OnPropertyChanging("InternalEMailAddress");
                SetAttributeValue("internalemailaddress", value);
                OnPropertyChanged("InternalEMailAddress");
            }
        }

        /// <summary>
        ///     User invitation status.
        /// </summary>
        [AttributeLogicalName("invitestatuscode")]
        public OptionSetValue InviteStatusCode
        {
            get { return GetAttributeValue<OptionSetValue>("invitestatuscode"); }
            set
            {
                OnPropertyChanging("InviteStatusCode");
                SetAttributeValue("invitestatuscode", value);
                OnPropertyChanged("InviteStatusCode");
            }
        }

        /// <summary>
        ///     Information about whether the user is enabled.
        /// </summary>
        [AttributeLogicalName("isdisabled")]
        public bool? IsDisabled
        {
            get { return GetAttributeValue<bool?>("isdisabled"); }
        }

        /// <summary>
        ///     Shows the status of approval of the email address by O365 Admin.
        /// </summary>
        [AttributeLogicalName("isemailaddressapprovedbyo365admin")]
        public bool? IsEmailAddressApprovedByO365Admin
        {
            get { return GetAttributeValue<bool?>("isemailaddressapprovedbyo365admin"); }
        }

        /// <summary>
        ///     Check if user is an integration user.
        /// </summary>
        [AttributeLogicalName("isintegrationuser")]
        public bool? IsIntegrationUser
        {
            get { return GetAttributeValue<bool?>("isintegrationuser"); }
            set
            {
                OnPropertyChanging("IsIntegrationUser");
                SetAttributeValue("isintegrationuser", value);
                OnPropertyChanged("IsIntegrationUser");
            }
        }

        /// <summary>
        ///     Information about whether the user is licensed.
        /// </summary>
        [AttributeLogicalName("islicensed")]
        public bool? IsLicensed
        {
            get { return GetAttributeValue<bool?>("islicensed"); }
            set
            {
                OnPropertyChanging("IsLicensed");
                SetAttributeValue("islicensed", value);
                OnPropertyChanged("IsLicensed");
            }
        }

        /// <summary>
        ///     Information about whether the user is synced with the directory.
        /// </summary>
        [AttributeLogicalName("issyncwithdirectory")]
        public bool? IsSyncWithDirectory
        {
            get { return GetAttributeValue<bool?>("issyncwithdirectory"); }
            set
            {
                OnPropertyChanging("IsSyncWithDirectory");
                SetAttributeValue("issyncwithdirectory", value);
                OnPropertyChanged("IsSyncWithDirectory");
            }
        }

        /// <summary>
        ///     Job title of the user.
        /// </summary>
        [AttributeLogicalName("jobtitle")]
        public string JobTitle
        {
            get { return GetAttributeValue<string>("jobtitle"); }
            set
            {
                OnPropertyChanging("JobTitle");
                SetAttributeValue("jobtitle", value);
                OnPropertyChanged("JobTitle");
            }
        }

        /// <summary>
        ///     Last name of the user.
        /// </summary>
        [AttributeLogicalName("lastname")]
        public string LastName
        {
            get { return GetAttributeValue<string>("lastname"); }
            set
            {
                OnPropertyChanging("LastName");
                SetAttributeValue("lastname", value);
                OnPropertyChanged("LastName");
            }
        }

        /// <summary>
        ///     Middle name of the user.
        /// </summary>
        [AttributeLogicalName("middlename")]
        public string MiddleName
        {
            get { return GetAttributeValue<string>("middlename"); }
            set
            {
                OnPropertyChanging("MiddleName");
                SetAttributeValue("middlename", value);
                OnPropertyChanged("MiddleName");
            }
        }

        /// <summary>
        ///     Mobile alert email address for the user.
        /// </summary>
        [AttributeLogicalName("mobilealertemail")]
        public string MobileAlertEMail
        {
            get { return GetAttributeValue<string>("mobilealertemail"); }
            set
            {
                OnPropertyChanging("MobileAlertEMail");
                SetAttributeValue("mobilealertemail", value);
                OnPropertyChanged("MobileAlertEMail");
            }
        }

        /// <summary>
        ///     Mobile phone number for the user.
        /// </summary>
        [AttributeLogicalName("mobilephone")]
        public string MobilePhone
        {
            get { return GetAttributeValue<string>("mobilephone"); }
            set
            {
                OnPropertyChanging("MobilePhone");
                SetAttributeValue("mobilephone", value);
                OnPropertyChanged("MobilePhone");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the user.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the user was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the systemuser.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Nickname of the user.
        /// </summary>
        [AttributeLogicalName("nickname")]
        public string NickName
        {
            get { return GetAttributeValue<string>("nickname"); }
            set
            {
                OnPropertyChanging("NickName");
                SetAttributeValue("nickname", value);
                OnPropertyChanged("NickName");
            }
        }

        /// <summary>
        ///     Unique identifier of the organization associated with the user.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public Guid? OrganizationId
        {
            get { return GetAttributeValue<Guid?>("organizationid"); }
        }

        /// <summary>
        ///     Outgoing email delivery method for the user.
        /// </summary>
        [AttributeLogicalName("outgoingemaildeliverymethod")]
        public OptionSetValue OutgoingEmailDeliveryMethod
        {
            get { return GetAttributeValue<OptionSetValue>("outgoingemaildeliverymethod"); }
            set
            {
                OnPropertyChanging("OutgoingEmailDeliveryMethod");
                SetAttributeValue("outgoingemaildeliverymethod", value);
                OnPropertyChanged("OutgoingEmailDeliveryMethod");
            }
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
        ///     Unique identifier of the manager of the user.
        /// </summary>
        [AttributeLogicalName("parentsystemuserid")]
        public EntityReference ParentSystemUserId
        {
            get { return GetAttributeValue<EntityReference>("parentsystemuserid"); }
            set
            {
                OnPropertyChanging("ParentSystemUserId");
                SetAttributeValue("parentsystemuserid", value);
                OnPropertyChanged("ParentSystemUserId");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("passporthi")]
        public int? PassportHi
        {
            get { return GetAttributeValue<int?>("passporthi"); }
            set
            {
                OnPropertyChanging("PassportHi");
                SetAttributeValue("passporthi", value);
                OnPropertyChanged("PassportHi");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("passportlo")]
        public int? PassportLo
        {
            get { return GetAttributeValue<int?>("passportlo"); }
            set
            {
                OnPropertyChanging("PassportLo");
                SetAttributeValue("passportlo", value);
                OnPropertyChanged("PassportLo");
            }
        }

        /// <summary>
        ///     Personal email address of the user.
        /// </summary>
        [AttributeLogicalName("personalemailaddress")]
        public string PersonalEMailAddress
        {
            get { return GetAttributeValue<string>("personalemailaddress"); }
            set
            {
                OnPropertyChanging("PersonalEMailAddress");
                SetAttributeValue("personalemailaddress", value);
                OnPropertyChanged("PersonalEMailAddress");
            }
        }

        /// <summary>
        ///     URL for the Website on which a photo of the user is located.
        /// </summary>
        [AttributeLogicalName("photourl")]
        public string PhotoUrl
        {
            get { return GetAttributeValue<string>("photourl"); }
            set
            {
                OnPropertyChanging("PhotoUrl");
                SetAttributeValue("photourl", value);
                OnPropertyChanged("PhotoUrl");
            }
        }

        /// <summary>
        ///     Preferred address for the user.
        /// </summary>
        [AttributeLogicalName("preferredaddresscode")]
        public OptionSetValue PreferredAddressCode
        {
            get { return GetAttributeValue<OptionSetValue>("preferredaddresscode"); }
            set
            {
                OnPropertyChanging("PreferredAddressCode");
                SetAttributeValue("preferredaddresscode", value);
                OnPropertyChanged("PreferredAddressCode");
            }
        }

        /// <summary>
        ///     Preferred email address for the user.
        /// </summary>
        [AttributeLogicalName("preferredemailcode")]
        public OptionSetValue PreferredEmailCode
        {
            get { return GetAttributeValue<OptionSetValue>("preferredemailcode"); }
            set
            {
                OnPropertyChanging("PreferredEmailCode");
                SetAttributeValue("preferredemailcode", value);
                OnPropertyChanged("PreferredEmailCode");
            }
        }

        /// <summary>
        ///     Preferred phone number for the user.
        /// </summary>
        [AttributeLogicalName("preferredphonecode")]
        public OptionSetValue PreferredPhoneCode
        {
            get { return GetAttributeValue<OptionSetValue>("preferredphonecode"); }
            set
            {
                OnPropertyChanging("PreferredPhoneCode");
                SetAttributeValue("preferredphonecode", value);
                OnPropertyChanged("PreferredPhoneCode");
            }
        }

        /// <summary>
        ///     Shows the ID of the process.
        /// </summary>
        [AttributeLogicalName("processid")]
        public Guid? ProcessId
        {
            get { return GetAttributeValue<Guid?>("processid"); }
            set
            {
                OnPropertyChanging("ProcessId");
                SetAttributeValue("processid", value);
                OnPropertyChanged("ProcessId");
            }
        }

        /// <summary>
        ///     Unique identifier of the default queue for the user.
        /// </summary>
        [AttributeLogicalName("queueid")]
        public EntityReference QueueId
        {
            get { return GetAttributeValue<EntityReference>("queueid"); }
            set
            {
                OnPropertyChanging("QueueId");
                SetAttributeValue("queueid", value);
                OnPropertyChanged("QueueId");
            }
        }

        /// <summary>
        ///     Salutation for correspondence with the user.
        /// </summary>
        [AttributeLogicalName("salutation")]
        public string Salutation
        {
            get { return GetAttributeValue<string>("salutation"); }
            set
            {
                OnPropertyChanging("Salutation");
                SetAttributeValue("salutation", value);
                OnPropertyChanged("Salutation");
            }
        }

        /// <summary>
        ///     Check if user is a setup user.
        /// </summary>
        [AttributeLogicalName("setupuser")]
        public bool? SetupUser
        {
            get { return GetAttributeValue<bool?>("setupuser"); }
            set
            {
                OnPropertyChanging("SetupUser");
                SetAttributeValue("setupuser", value);
                OnPropertyChanged("SetupUser");
            }
        }

        /// <summary>
        ///     Site at which the user is located.
        /// </summary>
        [AttributeLogicalName("siteid")]
        public EntityReference SiteId
        {
            get { return GetAttributeValue<EntityReference>("siteid"); }
            set
            {
                OnPropertyChanging("SiteId");
                SetAttributeValue("siteid", value);
                OnPropertyChanged("SiteId");
            }
        }

        /// <summary>
        ///     Skill set of the user.
        /// </summary>
        [AttributeLogicalName("skills")]
        public string Skills
        {
            get { return GetAttributeValue<string>("skills"); }
            set
            {
                OnPropertyChanging("Skills");
                SetAttributeValue("skills", value);
                OnPropertyChanged("Skills");
            }
        }

        /// <summary>
        ///     Shows the ID of the stage.
        /// </summary>
        [AttributeLogicalName("stageid")]
        public Guid? StageId
        {
            get { return GetAttributeValue<Guid?>("stageid"); }
            set
            {
                OnPropertyChanging("StageId");
                SetAttributeValue("stageid", value);
                OnPropertyChanged("StageId");
            }
        }

        /// <summary>
        ///     Unique identifier for the user.
        /// </summary>
        [AttributeLogicalName("systemuserid")]
        public Guid? SystemUserId
        {
            get { return GetAttributeValue<Guid?>("systemuserid"); }
            set
            {
                OnPropertyChanging("SystemUserId");
                SetAttributeValue("systemuserid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("SystemUserId");
            }
        }

        [AttributeLogicalName("systemuserid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { SystemUserId = value; }
        }

        /// <summary>
        ///     Unique identifier of the territory to which the user is assigned.
        /// </summary>
        [AttributeLogicalName("territoryid")]
        public EntityReference TerritoryId
        {
            get { return GetAttributeValue<EntityReference>("territoryid"); }
            set
            {
                OnPropertyChanging("TerritoryId");
                SetAttributeValue("territoryid", value);
                OnPropertyChanged("TerritoryId");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("timezoneruleversionnumber")]
        public int? TimeZoneRuleVersionNumber
        {
            get { return GetAttributeValue<int?>("timezoneruleversionnumber"); }
            set
            {
                OnPropertyChanging("TimeZoneRuleVersionNumber");
                SetAttributeValue("timezoneruleversionnumber", value);
                OnPropertyChanged("TimeZoneRuleVersionNumber");
            }
        }

        /// <summary>
        ///     Title of the user.
        /// </summary>
        [AttributeLogicalName("title")]
        public string Title
        {
            get { return GetAttributeValue<string>("title"); }
            set
            {
                OnPropertyChanging("Title");
                SetAttributeValue("title", value);
                OnPropertyChanged("Title");
            }
        }

        /// <summary>
        ///     Unique identifier of the currency associated with the systemuser.
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
        ///     Shows the type of user license.
        /// </summary>
        [AttributeLogicalName("userlicensetype")]
        public int? UserLicenseType
        {
            get { return GetAttributeValue<int?>("userlicensetype"); }
        }

        /// <summary>
        ///     Time zone code that was in use when the record was created.
        /// </summary>
        [AttributeLogicalName("utcconversiontimezonecode")]
        public int? UTCConversionTimeZoneCode
        {
            get { return GetAttributeValue<int?>("utcconversiontimezonecode"); }
            set
            {
                OnPropertyChanging("UTCConversionTimeZoneCode");
                SetAttributeValue("utcconversiontimezonecode", value);
                OnPropertyChanged("UTCConversionTimeZoneCode");
            }
        }

        /// <summary>
        ///     Version number of the user.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     Windows Live ID
        /// </summary>
        [AttributeLogicalName("windowsliveid")]
        public string WindowsLiveID
        {
            get { return GetAttributeValue<string>("windowsliveid"); }
            set
            {
                OnPropertyChanging("WindowsLiveID");
                SetAttributeValue("windowsliveid", value);
                OnPropertyChanged("WindowsLiveID");
            }
        }

        /// <summary>
        ///     User's Yammer login email address
        /// </summary>
        [AttributeLogicalName("yammeremailaddress")]
        public string YammerEmailAddress
        {
            get { return GetAttributeValue<string>("yammeremailaddress"); }
            set
            {
                OnPropertyChanging("YammerEmailAddress");
                SetAttributeValue("yammeremailaddress", value);
                OnPropertyChanged("YammerEmailAddress");
            }
        }

        /// <summary>
        ///     User's Yammer ID
        /// </summary>
        [AttributeLogicalName("yammeruserid")]
        public string YammerUserId
        {
            get { return GetAttributeValue<string>("yammeruserid"); }
            set
            {
                OnPropertyChanging("YammerUserId");
                SetAttributeValue("yammeruserid", value);
                OnPropertyChanged("YammerUserId");
            }
        }

        /// <summary>
        ///     Pronunciation of the first name of the user, written in phonetic hiragana or katakana characters.
        /// </summary>
        [AttributeLogicalName("yomifirstname")]
        public string YomiFirstName
        {
            get { return GetAttributeValue<string>("yomifirstname"); }
            set
            {
                OnPropertyChanging("YomiFirstName");
                SetAttributeValue("yomifirstname", value);
                OnPropertyChanged("YomiFirstName");
            }
        }

        /// <summary>
        ///     Pronunciation of the full name of the user, written in phonetic hiragana or katakana characters.
        /// </summary>
        [AttributeLogicalName("yomifullname")]
        public string YomiFullName
        {
            get { return GetAttributeValue<string>("yomifullname"); }
        }

        /// <summary>
        ///     Pronunciation of the last name of the user, written in phonetic hiragana or katakana characters.
        /// </summary>
        [AttributeLogicalName("yomilastname")]
        public string YomiLastName
        {
            get { return GetAttributeValue<string>("yomilastname"); }
            set
            {
                OnPropertyChanging("YomiLastName");
                SetAttributeValue("yomilastname", value);
                OnPropertyChanged("YomiLastName");
            }
        }

        /// <summary>
        ///     Pronunciation of the middle name of the user, written in phonetic hiragana or katakana characters.
        /// </summary>
        [AttributeLogicalName("yomimiddlename")]
        public string YomiMiddleName
        {
            get { return GetAttributeValue<string>("yomimiddlename"); }
            set
            {
                OnPropertyChanging("YomiMiddleName");
                SetAttributeValue("yomimiddlename", value);
                OnPropertyChanged("YomiMiddleName");
            }
        }

        /// <summary>
        ///     1:N annotation_owning_user
        /// </summary>
        [RelationshipSchemaName("annotation_owning_user")]
        public IEnumerable<Annotation> annotation_owning_user
        {
            get { return GetRelatedEntities<Annotation>("annotation_owning_user", null); }
            set
            {
                OnPropertyChanging("annotation_owning_user");
                SetRelatedEntities("annotation_owning_user", null, value);
                OnPropertyChanged("annotation_owning_user");
            }
        }

        /// <summary>
        ///     1:N constraintbasedgroup_systemuser
        /// </summary>
        [RelationshipSchemaName("constraintbasedgroup_systemuser")]
        public IEnumerable<ConstraintBasedGroup> constraintbasedgroup_systemuser
        {
            get { return GetRelatedEntities<ConstraintBasedGroup>("constraintbasedgroup_systemuser", null); }
            set
            {
                OnPropertyChanging("constraintbasedgroup_systemuser");
                SetRelatedEntities("constraintbasedgroup_systemuser", null, value);
                OnPropertyChanged("constraintbasedgroup_systemuser");
            }
        }

        /// <summary>
        ///     1:N contact_owning_user
        /// </summary>
        [RelationshipSchemaName("contact_owning_user")]
        public IEnumerable<Contact> contact_owning_user
        {
            get { return GetRelatedEntities<Contact>("contact_owning_user", null); }
            set
            {
                OnPropertyChanging("contact_owning_user");
                SetRelatedEntities("contact_owning_user", null, value);
                OnPropertyChanged("contact_owning_user");
            }
        }

        /// <summary>
        ///     1:N createdby_attributemap
        /// </summary>
        [RelationshipSchemaName("createdby_attributemap")]
        public IEnumerable<AttributeMap> createdby_attributemap
        {
            get { return GetRelatedEntities<AttributeMap>("createdby_attributemap", null); }
            set
            {
                OnPropertyChanging("createdby_attributemap");
                SetRelatedEntities("createdby_attributemap", null, value);
                OnPropertyChanged("createdby_attributemap");
            }
        }

        /// <summary>
        ///     1:N createdby_connection
        /// </summary>
        [RelationshipSchemaName("createdby_connection")]
        public IEnumerable<Connection> createdby_connection
        {
            get { return GetRelatedEntities<Connection>("createdby_connection", null); }
            set
            {
                OnPropertyChanging("createdby_connection");
                SetRelatedEntities("createdby_connection", null, value);
                OnPropertyChanged("createdby_connection");
            }
        }

        /// <summary>
        ///     1:N createdby_connection_role
        /// </summary>
        [RelationshipSchemaName("createdby_connection_role")]
        public IEnumerable<ConnectionRole> createdby_connection_role
        {
            get { return GetRelatedEntities<ConnectionRole>("createdby_connection_role", null); }
            set
            {
                OnPropertyChanging("createdby_connection_role");
                SetRelatedEntities("createdby_connection_role", null, value);
                OnPropertyChanged("createdby_connection_role");
            }
        }

        /// <summary>
        ///     1:N createdby_customer_relationship
        /// </summary>
        [RelationshipSchemaName("createdby_customer_relationship")]
        public IEnumerable<CustomerRelationship> createdby_customer_relationship
        {
            get { return GetRelatedEntities<CustomerRelationship>("createdby_customer_relationship", null); }
            set
            {
                OnPropertyChanging("createdby_customer_relationship");
                SetRelatedEntities("createdby_customer_relationship", null, value);
                OnPropertyChanged("createdby_customer_relationship");
            }
        }

        /// <summary>
        ///     1:N createdby_entitymap
        /// </summary>
        [RelationshipSchemaName("createdby_entitymap")]
        public IEnumerable<EntityMap> createdby_entitymap
        {
            get { return GetRelatedEntities<EntityMap>("createdby_entitymap", null); }
            set
            {
                OnPropertyChanging("createdby_entitymap");
                SetRelatedEntities("createdby_entitymap", null, value);
                OnPropertyChanged("createdby_entitymap");
            }
        }

        /// <summary>
        ///     1:N createdby_pluginassembly
        /// </summary>
        [RelationshipSchemaName("createdby_pluginassembly")]
        public IEnumerable<PluginAssembly> createdby_pluginassembly
        {
            get { return GetRelatedEntities<PluginAssembly>("createdby_pluginassembly", null); }
            set
            {
                OnPropertyChanging("createdby_pluginassembly");
                SetRelatedEntities("createdby_pluginassembly", null, value);
                OnPropertyChanged("createdby_pluginassembly");
            }
        }

        /// <summary>
        ///     1:N createdby_plugintype
        /// </summary>
        [RelationshipSchemaName("createdby_plugintype")]
        public IEnumerable<PluginType> createdby_plugintype
        {
            get { return GetRelatedEntities<PluginType>("createdby_plugintype", null); }
            set
            {
                OnPropertyChanging("createdby_plugintype");
                SetRelatedEntities("createdby_plugintype", null, value);
                OnPropertyChanged("createdby_plugintype");
            }
        }

        /// <summary>
        ///     1:N createdby_plugintypestatistic
        /// </summary>
        [RelationshipSchemaName("createdby_plugintypestatistic")]
        public IEnumerable<PluginTypeStatistic> createdby_plugintypestatistic
        {
            get { return GetRelatedEntities<PluginTypeStatistic>("createdby_plugintypestatistic", null); }
            set
            {
                OnPropertyChanging("createdby_plugintypestatistic");
                SetRelatedEntities("createdby_plugintypestatistic", null, value);
                OnPropertyChanged("createdby_plugintypestatistic");
            }
        }

        /// <summary>
        ///     1:N createdby_relationship_role
        /// </summary>
        [RelationshipSchemaName("createdby_relationship_role")]
        public IEnumerable<RelationshipRole> createdby_relationship_role
        {
            get { return GetRelatedEntities<RelationshipRole>("createdby_relationship_role", null); }
            set
            {
                OnPropertyChanging("createdby_relationship_role");
                SetRelatedEntities("createdby_relationship_role", null, value);
                OnPropertyChanged("createdby_relationship_role");
            }
        }

        /// <summary>
        ///     1:N createdby_relationship_role_map
        /// </summary>
        [RelationshipSchemaName("createdby_relationship_role_map")]
        public IEnumerable<RelationshipRoleMap> createdby_relationship_role_map
        {
            get { return GetRelatedEntities<RelationshipRoleMap>("createdby_relationship_role_map", null); }
            set
            {
                OnPropertyChanging("createdby_relationship_role_map");
                SetRelatedEntities("createdby_relationship_role_map", null, value);
                OnPropertyChanged("createdby_relationship_role_map");
            }
        }

        /// <summary>
        ///     1:N createdby_sdkmessage
        /// </summary>
        [RelationshipSchemaName("createdby_sdkmessage")]
        public IEnumerable<SdkMessage> createdby_sdkmessage
        {
            get { return GetRelatedEntities<SdkMessage>("createdby_sdkmessage", null); }
            set
            {
                OnPropertyChanging("createdby_sdkmessage");
                SetRelatedEntities("createdby_sdkmessage", null, value);
                OnPropertyChanged("createdby_sdkmessage");
            }
        }

        /// <summary>
        ///     1:N createdby_sdkmessagefilter
        /// </summary>
        [RelationshipSchemaName("createdby_sdkmessagefilter")]
        public IEnumerable<SdkMessageFilter> createdby_sdkmessagefilter
        {
            get { return GetRelatedEntities<SdkMessageFilter>("createdby_sdkmessagefilter", null); }
            set
            {
                OnPropertyChanging("createdby_sdkmessagefilter");
                SetRelatedEntities("createdby_sdkmessagefilter", null, value);
                OnPropertyChanged("createdby_sdkmessagefilter");
            }
        }

        /// <summary>
        ///     1:N createdby_sdkmessagepair
        /// </summary>
        [RelationshipSchemaName("createdby_sdkmessagepair")]
        public IEnumerable<SdkMessagePair> createdby_sdkmessagepair
        {
            get { return GetRelatedEntities<SdkMessagePair>("createdby_sdkmessagepair", null); }
            set
            {
                OnPropertyChanging("createdby_sdkmessagepair");
                SetRelatedEntities("createdby_sdkmessagepair", null, value);
                OnPropertyChanged("createdby_sdkmessagepair");
            }
        }

        /// <summary>
        ///     1:N createdby_sdkmessageprocessingstep
        /// </summary>
        [RelationshipSchemaName("createdby_sdkmessageprocessingstep")]
        public IEnumerable<SdkMessageProcessingStep> createdby_sdkmessageprocessingstep
        {
            get { return GetRelatedEntities<SdkMessageProcessingStep>("createdby_sdkmessageprocessingstep", null); }
            set
            {
                OnPropertyChanging("createdby_sdkmessageprocessingstep");
                SetRelatedEntities("createdby_sdkmessageprocessingstep", null, value);
                OnPropertyChanged("createdby_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        ///     1:N createdby_sdkmessageprocessingstepimage
        /// </summary>
        [RelationshipSchemaName("createdby_sdkmessageprocessingstepimage")]
        public IEnumerable<SdkMessageProcessingStepImage> createdby_sdkmessageprocessingstepimage
        {
            get
            {
                return GetRelatedEntities<SdkMessageProcessingStepImage>("createdby_sdkmessageprocessingstepimage", null);
            }
            set
            {
                OnPropertyChanging("createdby_sdkmessageprocessingstepimage");
                SetRelatedEntities("createdby_sdkmessageprocessingstepimage", null, value);
                OnPropertyChanged("createdby_sdkmessageprocessingstepimage");
            }
        }

        /// <summary>
        ///     1:N createdby_sdkmessageprocessingstepsecureconfig
        /// </summary>
        [RelationshipSchemaName("createdby_sdkmessageprocessingstepsecureconfig")]
        public IEnumerable<SdkMessageProcessingStepSecureConfig> createdby_sdkmessageprocessingstepsecureconfig
        {
            get
            {
                return
                    GetRelatedEntities<SdkMessageProcessingStepSecureConfig>(
                        "createdby_sdkmessageprocessingstepsecureconfig", null);
            }
            set
            {
                OnPropertyChanging("createdby_sdkmessageprocessingstepsecureconfig");
                SetRelatedEntities("createdby_sdkmessageprocessingstepsecureconfig", null, value);
                OnPropertyChanged("createdby_sdkmessageprocessingstepsecureconfig");
            }
        }

        /// <summary>
        ///     1:N createdby_sdkmessagerequest
        /// </summary>
        [RelationshipSchemaName("createdby_sdkmessagerequest")]
        public IEnumerable<SdkMessageRequest> createdby_sdkmessagerequest
        {
            get { return GetRelatedEntities<SdkMessageRequest>("createdby_sdkmessagerequest", null); }
            set
            {
                OnPropertyChanging("createdby_sdkmessagerequest");
                SetRelatedEntities("createdby_sdkmessagerequest", null, value);
                OnPropertyChanged("createdby_sdkmessagerequest");
            }
        }

        /// <summary>
        ///     1:N createdby_sdkmessagerequestfield
        /// </summary>
        [RelationshipSchemaName("createdby_sdkmessagerequestfield")]
        public IEnumerable<SdkMessageRequestField> createdby_sdkmessagerequestfield
        {
            get { return GetRelatedEntities<SdkMessageRequestField>("createdby_sdkmessagerequestfield", null); }
            set
            {
                OnPropertyChanging("createdby_sdkmessagerequestfield");
                SetRelatedEntities("createdby_sdkmessagerequestfield", null, value);
                OnPropertyChanged("createdby_sdkmessagerequestfield");
            }
        }

        /// <summary>
        ///     1:N createdby_sdkmessageresponse
        /// </summary>
        [RelationshipSchemaName("createdby_sdkmessageresponse")]
        public IEnumerable<SdkMessageResponse> createdby_sdkmessageresponse
        {
            get { return GetRelatedEntities<SdkMessageResponse>("createdby_sdkmessageresponse", null); }
            set
            {
                OnPropertyChanging("createdby_sdkmessageresponse");
                SetRelatedEntities("createdby_sdkmessageresponse", null, value);
                OnPropertyChanged("createdby_sdkmessageresponse");
            }
        }

        /// <summary>
        ///     1:N createdby_sdkmessageresponsefield
        /// </summary>
        [RelationshipSchemaName("createdby_sdkmessageresponsefield")]
        public IEnumerable<SdkMessageResponseField> createdby_sdkmessageresponsefield
        {
            get { return GetRelatedEntities<SdkMessageResponseField>("createdby_sdkmessageresponsefield", null); }
            set
            {
                OnPropertyChanging("createdby_sdkmessageresponsefield");
                SetRelatedEntities("createdby_sdkmessageresponsefield", null, value);
                OnPropertyChanged("createdby_sdkmessageresponsefield");
            }
        }

        /// <summary>
        ///     1:N createdby_serviceendpoint
        /// </summary>
        [RelationshipSchemaName("createdby_serviceendpoint")]
        public IEnumerable<ServiceEndpoint> createdby_serviceendpoint
        {
            get { return GetRelatedEntities<ServiceEndpoint>("createdby_serviceendpoint", null); }
            set
            {
                OnPropertyChanging("createdby_serviceendpoint");
                SetRelatedEntities("createdby_serviceendpoint", null, value);
                OnPropertyChanged("createdby_serviceendpoint");
            }
        }

        /// <summary>
        ///     1:N createdonbehalfby_attributemap
        /// </summary>
        [RelationshipSchemaName("createdonbehalfby_attributemap")]
        public IEnumerable<AttributeMap> createdonbehalfby_attributemap
        {
            get { return GetRelatedEntities<AttributeMap>("createdonbehalfby_attributemap", null); }
            set
            {
                OnPropertyChanging("createdonbehalfby_attributemap");
                SetRelatedEntities("createdonbehalfby_attributemap", null, value);
                OnPropertyChanged("createdonbehalfby_attributemap");
            }
        }

        /// <summary>
        ///     1:N createdonbehalfby_customer_relationship
        /// </summary>
        [RelationshipSchemaName("createdonbehalfby_customer_relationship")]
        public IEnumerable<CustomerRelationship> createdonbehalfby_customer_relationship
        {
            get { return GetRelatedEntities<CustomerRelationship>("createdonbehalfby_customer_relationship", null); }
            set
            {
                OnPropertyChanging("createdonbehalfby_customer_relationship");
                SetRelatedEntities("createdonbehalfby_customer_relationship", null, value);
                OnPropertyChanged("createdonbehalfby_customer_relationship");
            }
        }

        /// <summary>
        ///     1:N equipment_systemuser
        /// </summary>
        [RelationshipSchemaName("equipment_systemuser")]
        public IEnumerable<Equipment> equipment_systemuser
        {
            get { return GetRelatedEntities<Equipment>("equipment_systemuser", null); }
            set
            {
                OnPropertyChanging("equipment_systemuser");
                SetRelatedEntities("equipment_systemuser", null, value);
                OnPropertyChanged("equipment_systemuser");
            }
        }

        /// <summary>
        ///     1:N impersonatinguserid_sdkmessageprocessingstep
        /// </summary>
        [RelationshipSchemaName("impersonatinguserid_sdkmessageprocessingstep")]
        public IEnumerable<SdkMessageProcessingStep> impersonatinguserid_sdkmessageprocessingstep
        {
            get
            {
                return GetRelatedEntities<SdkMessageProcessingStep>("impersonatinguserid_sdkmessageprocessingstep", null);
            }
            set
            {
                OnPropertyChanging("impersonatinguserid_sdkmessageprocessingstep");
                SetRelatedEntities("impersonatinguserid_sdkmessageprocessingstep", null, value);
                OnPropertyChanged("impersonatinguserid_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        ///     1:N ImportFile_SystemUser
        /// </summary>
        [RelationshipSchemaName("ImportFile_SystemUser")]
        public IEnumerable<ImportFile> ImportFile_SystemUser
        {
            get { return GetRelatedEntities<ImportFile>("ImportFile_SystemUser", null); }
            set
            {
                OnPropertyChanging("ImportFile_SystemUser");
                SetRelatedEntities("ImportFile_SystemUser", null, value);
                OnPropertyChanged("ImportFile_SystemUser");
            }
        }

        /// <summary>
        ///     1:N lead_owning_user
        /// </summary>
        [RelationshipSchemaName("lead_owning_user")]
        public IEnumerable<Lead> lead_owning_user
        {
            get { return GetRelatedEntities<Lead>("lead_owning_user", null); }
            set
            {
                OnPropertyChanging("lead_owning_user");
                SetRelatedEntities("lead_owning_user", null, value);
                OnPropertyChanged("lead_owning_user");
            }
        }

        /// <summary>
        ///     1:N lk_accountbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_accountbase_createdby")]
        public IEnumerable<Account> lk_accountbase_createdby
        {
            get { return GetRelatedEntities<Account>("lk_accountbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_accountbase_createdby");
                SetRelatedEntities("lk_accountbase_createdby", null, value);
                OnPropertyChanged("lk_accountbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_accountbase_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_accountbase_createdonbehalfby")]
        public IEnumerable<Account> lk_accountbase_createdonbehalfby
        {
            get { return GetRelatedEntities<Account>("lk_accountbase_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_accountbase_createdonbehalfby");
                SetRelatedEntities("lk_accountbase_createdonbehalfby", null, value);
                OnPropertyChanged("lk_accountbase_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_accountbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_accountbase_modifiedby")]
        public IEnumerable<Account> lk_accountbase_modifiedby
        {
            get { return GetRelatedEntities<Account>("lk_accountbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_accountbase_modifiedby");
                SetRelatedEntities("lk_accountbase_modifiedby", null, value);
                OnPropertyChanged("lk_accountbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_accountbase_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_accountbase_modifiedonbehalfby")]
        public IEnumerable<Account> lk_accountbase_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Account>("lk_accountbase_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_accountbase_modifiedonbehalfby");
                SetRelatedEntities("lk_accountbase_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_accountbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_activitypointer_createdby
        /// </summary>
        [RelationshipSchemaName("lk_activitypointer_createdby")]
        public IEnumerable<ActivityPointer> lk_activitypointer_createdby
        {
            get { return GetRelatedEntities<ActivityPointer>("lk_activitypointer_createdby", null); }
            set
            {
                OnPropertyChanging("lk_activitypointer_createdby");
                SetRelatedEntities("lk_activitypointer_createdby", null, value);
                OnPropertyChanged("lk_activitypointer_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_activitypointer_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_activitypointer_createdonbehalfby")]
        public IEnumerable<ActivityPointer> lk_activitypointer_createdonbehalfby
        {
            get { return GetRelatedEntities<ActivityPointer>("lk_activitypointer_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_activitypointer_createdonbehalfby");
                SetRelatedEntities("lk_activitypointer_createdonbehalfby", null, value);
                OnPropertyChanged("lk_activitypointer_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_activitypointer_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_activitypointer_modifiedby")]
        public IEnumerable<ActivityPointer> lk_activitypointer_modifiedby
        {
            get { return GetRelatedEntities<ActivityPointer>("lk_activitypointer_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_activitypointer_modifiedby");
                SetRelatedEntities("lk_activitypointer_modifiedby", null, value);
                OnPropertyChanged("lk_activitypointer_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_activitypointer_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_activitypointer_modifiedonbehalfby")]
        public IEnumerable<ActivityPointer> lk_activitypointer_modifiedonbehalfby
        {
            get { return GetRelatedEntities<ActivityPointer>("lk_activitypointer_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_activitypointer_modifiedonbehalfby");
                SetRelatedEntities("lk_activitypointer_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_activitypointer_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_annotationbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_annotationbase_createdby")]
        public IEnumerable<Annotation> lk_annotationbase_createdby
        {
            get { return GetRelatedEntities<Annotation>("lk_annotationbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_annotationbase_createdby");
                SetRelatedEntities("lk_annotationbase_createdby", null, value);
                OnPropertyChanged("lk_annotationbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_annotationbase_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_annotationbase_createdonbehalfby")]
        public IEnumerable<Annotation> lk_annotationbase_createdonbehalfby
        {
            get { return GetRelatedEntities<Annotation>("lk_annotationbase_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_annotationbase_createdonbehalfby");
                SetRelatedEntities("lk_annotationbase_createdonbehalfby", null, value);
                OnPropertyChanged("lk_annotationbase_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_annotationbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_annotationbase_modifiedby")]
        public IEnumerable<Annotation> lk_annotationbase_modifiedby
        {
            get { return GetRelatedEntities<Annotation>("lk_annotationbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_annotationbase_modifiedby");
                SetRelatedEntities("lk_annotationbase_modifiedby", null, value);
                OnPropertyChanged("lk_annotationbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_annotationbase_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_annotationbase_modifiedonbehalfby")]
        public IEnumerable<Annotation> lk_annotationbase_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Annotation>("lk_annotationbase_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_annotationbase_modifiedonbehalfby");
                SetRelatedEntities("lk_annotationbase_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_annotationbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_annualfiscalcalendar_createdby
        /// </summary>
        [RelationshipSchemaName("lk_annualfiscalcalendar_createdby")]
        public IEnumerable<AnnualFiscalCalendar> lk_annualfiscalcalendar_createdby
        {
            get { return GetRelatedEntities<AnnualFiscalCalendar>("lk_annualfiscalcalendar_createdby", null); }
            set
            {
                OnPropertyChanging("lk_annualfiscalcalendar_createdby");
                SetRelatedEntities("lk_annualfiscalcalendar_createdby", null, value);
                OnPropertyChanged("lk_annualfiscalcalendar_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_annualfiscalcalendar_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_annualfiscalcalendar_createdonbehalfby")]
        public IEnumerable<AnnualFiscalCalendar> lk_annualfiscalcalendar_createdonbehalfby
        {
            get { return GetRelatedEntities<AnnualFiscalCalendar>("lk_annualfiscalcalendar_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_annualfiscalcalendar_createdonbehalfby");
                SetRelatedEntities("lk_annualfiscalcalendar_createdonbehalfby", null, value);
                OnPropertyChanged("lk_annualfiscalcalendar_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_annualfiscalcalendar_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_annualfiscalcalendar_modifiedby")]
        public IEnumerable<AnnualFiscalCalendar> lk_annualfiscalcalendar_modifiedby
        {
            get { return GetRelatedEntities<AnnualFiscalCalendar>("lk_annualfiscalcalendar_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_annualfiscalcalendar_modifiedby");
                SetRelatedEntities("lk_annualfiscalcalendar_modifiedby", null, value);
                OnPropertyChanged("lk_annualfiscalcalendar_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_annualfiscalcalendar_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_annualfiscalcalendar_modifiedonbehalfby")]
        public IEnumerable<AnnualFiscalCalendar> lk_annualfiscalcalendar_modifiedonbehalfby
        {
            get { return GetRelatedEntities<AnnualFiscalCalendar>("lk_annualfiscalcalendar_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_annualfiscalcalendar_modifiedonbehalfby");
                SetRelatedEntities("lk_annualfiscalcalendar_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_annualfiscalcalendar_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_annualfiscalcalendar_salespersonid
        /// </summary>
        [RelationshipSchemaName("lk_annualfiscalcalendar_salespersonid")]
        public IEnumerable<AnnualFiscalCalendar> lk_annualfiscalcalendar_salespersonid
        {
            get { return GetRelatedEntities<AnnualFiscalCalendar>("lk_annualfiscalcalendar_salespersonid", null); }
            set
            {
                OnPropertyChanging("lk_annualfiscalcalendar_salespersonid");
                SetRelatedEntities("lk_annualfiscalcalendar_salespersonid", null, value);
                OnPropertyChanged("lk_annualfiscalcalendar_salespersonid");
            }
        }

        /// <summary>
        ///     1:N lk_appointment_createdby
        /// </summary>
        [RelationshipSchemaName("lk_appointment_createdby")]
        public IEnumerable<Appointment> lk_appointment_createdby
        {
            get { return GetRelatedEntities<Appointment>("lk_appointment_createdby", null); }
            set
            {
                OnPropertyChanging("lk_appointment_createdby");
                SetRelatedEntities("lk_appointment_createdby", null, value);
                OnPropertyChanged("lk_appointment_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_appointment_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_appointment_createdonbehalfby")]
        public IEnumerable<Appointment> lk_appointment_createdonbehalfby
        {
            get { return GetRelatedEntities<Appointment>("lk_appointment_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_appointment_createdonbehalfby");
                SetRelatedEntities("lk_appointment_createdonbehalfby", null, value);
                OnPropertyChanged("lk_appointment_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_appointment_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_appointment_modifiedby")]
        public IEnumerable<Appointment> lk_appointment_modifiedby
        {
            get { return GetRelatedEntities<Appointment>("lk_appointment_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_appointment_modifiedby");
                SetRelatedEntities("lk_appointment_modifiedby", null, value);
                OnPropertyChanged("lk_appointment_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_appointment_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_appointment_modifiedonbehalfby")]
        public IEnumerable<Appointment> lk_appointment_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Appointment>("lk_appointment_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_appointment_modifiedonbehalfby");
                SetRelatedEntities("lk_appointment_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_appointment_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_asyncoperation_createdby
        /// </summary>
        [RelationshipSchemaName("lk_asyncoperation_createdby")]
        public IEnumerable<AsyncOperation> lk_asyncoperation_createdby
        {
            get { return GetRelatedEntities<AsyncOperation>("lk_asyncoperation_createdby", null); }
            set
            {
                OnPropertyChanging("lk_asyncoperation_createdby");
                SetRelatedEntities("lk_asyncoperation_createdby", null, value);
                OnPropertyChanged("lk_asyncoperation_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_asyncoperation_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_asyncoperation_createdonbehalfby")]
        public IEnumerable<AsyncOperation> lk_asyncoperation_createdonbehalfby
        {
            get { return GetRelatedEntities<AsyncOperation>("lk_asyncoperation_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_asyncoperation_createdonbehalfby");
                SetRelatedEntities("lk_asyncoperation_createdonbehalfby", null, value);
                OnPropertyChanged("lk_asyncoperation_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_asyncoperation_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_asyncoperation_modifiedby")]
        public IEnumerable<AsyncOperation> lk_asyncoperation_modifiedby
        {
            get { return GetRelatedEntities<AsyncOperation>("lk_asyncoperation_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_asyncoperation_modifiedby");
                SetRelatedEntities("lk_asyncoperation_modifiedby", null, value);
                OnPropertyChanged("lk_asyncoperation_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_asyncoperation_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_asyncoperation_modifiedonbehalfby")]
        public IEnumerable<AsyncOperation> lk_asyncoperation_modifiedonbehalfby
        {
            get { return GetRelatedEntities<AsyncOperation>("lk_asyncoperation_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_asyncoperation_modifiedonbehalfby");
                SetRelatedEntities("lk_asyncoperation_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_asyncoperation_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_audit_callinguserid
        /// </summary>
        [RelationshipSchemaName("lk_audit_callinguserid")]
        public IEnumerable<Audit> lk_audit_callinguserid
        {
            get { return GetRelatedEntities<Audit>("lk_audit_callinguserid", null); }
            set
            {
                OnPropertyChanging("lk_audit_callinguserid");
                SetRelatedEntities("lk_audit_callinguserid", null, value);
                OnPropertyChanged("lk_audit_callinguserid");
            }
        }

        /// <summary>
        ///     1:N lk_audit_userid
        /// </summary>
        [RelationshipSchemaName("lk_audit_userid")]
        public IEnumerable<Audit> lk_audit_userid
        {
            get { return GetRelatedEntities<Audit>("lk_audit_userid", null); }
            set
            {
                OnPropertyChanging("lk_audit_userid");
                SetRelatedEntities("lk_audit_userid", null, value);
                OnPropertyChanged("lk_audit_userid");
            }
        }

        /// <summary>
        ///     1:N lk_bulkdeleteoperation_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_bulkdeleteoperation_createdonbehalfby")]
        public IEnumerable<BulkDeleteOperation> lk_bulkdeleteoperation_createdonbehalfby
        {
            get { return GetRelatedEntities<BulkDeleteOperation>("lk_bulkdeleteoperation_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_bulkdeleteoperation_createdonbehalfby");
                SetRelatedEntities("lk_bulkdeleteoperation_createdonbehalfby", null, value);
                OnPropertyChanged("lk_bulkdeleteoperation_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_bulkdeleteoperation_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_bulkdeleteoperation_modifiedonbehalfby")]
        public IEnumerable<BulkDeleteOperation> lk_bulkdeleteoperation_modifiedonbehalfby
        {
            get { return GetRelatedEntities<BulkDeleteOperation>("lk_bulkdeleteoperation_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_bulkdeleteoperation_modifiedonbehalfby");
                SetRelatedEntities("lk_bulkdeleteoperation_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_bulkdeleteoperation_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_bulkdeleteoperationbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_bulkdeleteoperationbase_createdby")]
        public IEnumerable<BulkDeleteOperation> lk_bulkdeleteoperationbase_createdby
        {
            get { return GetRelatedEntities<BulkDeleteOperation>("lk_bulkdeleteoperationbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_bulkdeleteoperationbase_createdby");
                SetRelatedEntities("lk_bulkdeleteoperationbase_createdby", null, value);
                OnPropertyChanged("lk_bulkdeleteoperationbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_bulkdeleteoperationbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_bulkdeleteoperationbase_modifiedby")]
        public IEnumerable<BulkDeleteOperation> lk_bulkdeleteoperationbase_modifiedby
        {
            get { return GetRelatedEntities<BulkDeleteOperation>("lk_bulkdeleteoperationbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_bulkdeleteoperationbase_modifiedby");
                SetRelatedEntities("lk_bulkdeleteoperationbase_modifiedby", null, value);
                OnPropertyChanged("lk_bulkdeleteoperationbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_BulkOperation_createdby
        /// </summary>
        [RelationshipSchemaName("lk_BulkOperation_createdby")]
        public IEnumerable<BulkOperation> lk_BulkOperation_createdby
        {
            get { return GetRelatedEntities<BulkOperation>("lk_BulkOperation_createdby", null); }
            set
            {
                OnPropertyChanging("lk_BulkOperation_createdby");
                SetRelatedEntities("lk_BulkOperation_createdby", null, value);
                OnPropertyChanged("lk_BulkOperation_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_BulkOperation_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_BulkOperation_createdonbehalfby")]
        public IEnumerable<BulkOperation> lk_BulkOperation_createdonbehalfby
        {
            get { return GetRelatedEntities<BulkOperation>("lk_BulkOperation_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_BulkOperation_createdonbehalfby");
                SetRelatedEntities("lk_BulkOperation_createdonbehalfby", null, value);
                OnPropertyChanged("lk_BulkOperation_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_BulkOperation_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_BulkOperation_modifiedby")]
        public IEnumerable<BulkOperation> lk_BulkOperation_modifiedby
        {
            get { return GetRelatedEntities<BulkOperation>("lk_BulkOperation_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_BulkOperation_modifiedby");
                SetRelatedEntities("lk_BulkOperation_modifiedby", null, value);
                OnPropertyChanged("lk_BulkOperation_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_BulkOperation_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_BulkOperation_modifiedonbehalfby")]
        public IEnumerable<BulkOperation> lk_BulkOperation_modifiedonbehalfby
        {
            get { return GetRelatedEntities<BulkOperation>("lk_BulkOperation_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_BulkOperation_modifiedonbehalfby");
                SetRelatedEntities("lk_BulkOperation_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_BulkOperation_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_businessunit_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_businessunit_createdonbehalfby")]
        public IEnumerable<BusinessUnit> lk_businessunit_createdonbehalfby
        {
            get { return GetRelatedEntities<BusinessUnit>("lk_businessunit_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_businessunit_createdonbehalfby");
                SetRelatedEntities("lk_businessunit_createdonbehalfby", null, value);
                OnPropertyChanged("lk_businessunit_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_businessunit_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_businessunit_modifiedonbehalfby")]
        public IEnumerable<BusinessUnit> lk_businessunit_modifiedonbehalfby
        {
            get { return GetRelatedEntities<BusinessUnit>("lk_businessunit_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_businessunit_modifiedonbehalfby");
                SetRelatedEntities("lk_businessunit_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_businessunit_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_businessunitbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_businessunitbase_createdby")]
        public IEnumerable<BusinessUnit> lk_businessunitbase_createdby
        {
            get { return GetRelatedEntities<BusinessUnit>("lk_businessunitbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_businessunitbase_createdby");
                SetRelatedEntities("lk_businessunitbase_createdby", null, value);
                OnPropertyChanged("lk_businessunitbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_businessunitbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_businessunitbase_modifiedby")]
        public IEnumerable<BusinessUnit> lk_businessunitbase_modifiedby
        {
            get { return GetRelatedEntities<BusinessUnit>("lk_businessunitbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_businessunitbase_modifiedby");
                SetRelatedEntities("lk_businessunitbase_modifiedby", null, value);
                OnPropertyChanged("lk_businessunitbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_businessunitnewsarticle_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_businessunitnewsarticle_createdonbehalfby")]
        public IEnumerable<BusinessUnitNewsArticle> lk_businessunitnewsarticle_createdonbehalfby
        {
            get
            {
                return GetRelatedEntities<BusinessUnitNewsArticle>("lk_businessunitnewsarticle_createdonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_businessunitnewsarticle_createdonbehalfby");
                SetRelatedEntities("lk_businessunitnewsarticle_createdonbehalfby", null, value);
                OnPropertyChanged("lk_businessunitnewsarticle_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_businessunitnewsarticle_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_businessunitnewsarticle_modifiedonbehalfby")]
        public IEnumerable<BusinessUnitNewsArticle> lk_businessunitnewsarticle_modifiedonbehalfby
        {
            get
            {
                return GetRelatedEntities<BusinessUnitNewsArticle>("lk_businessunitnewsarticle_modifiedonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_businessunitnewsarticle_modifiedonbehalfby");
                SetRelatedEntities("lk_businessunitnewsarticle_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_businessunitnewsarticle_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_businessunitnewsarticlebase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_businessunitnewsarticlebase_createdby")]
        public IEnumerable<BusinessUnitNewsArticle> lk_businessunitnewsarticlebase_createdby
        {
            get
            {
                return GetRelatedEntities<BusinessUnitNewsArticle>("lk_businessunitnewsarticlebase_createdby", null);
            }
            set
            {
                OnPropertyChanging("lk_businessunitnewsarticlebase_createdby");
                SetRelatedEntities("lk_businessunitnewsarticlebase_createdby", null, value);
                OnPropertyChanged("lk_businessunitnewsarticlebase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_businessunitnewsarticlebase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_businessunitnewsarticlebase_modifiedby")]
        public IEnumerable<BusinessUnitNewsArticle> lk_businessunitnewsarticlebase_modifiedby
        {
            get
            {
                return GetRelatedEntities<BusinessUnitNewsArticle>("lk_businessunitnewsarticlebase_modifiedby", null);
            }
            set
            {
                OnPropertyChanging("lk_businessunitnewsarticlebase_modifiedby");
                SetRelatedEntities("lk_businessunitnewsarticlebase_modifiedby", null, value);
                OnPropertyChanged("lk_businessunitnewsarticlebase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_calendar_createdby
        /// </summary>
        [RelationshipSchemaName("lk_calendar_createdby")]
        public IEnumerable<Calendar> lk_calendar_createdby
        {
            get { return GetRelatedEntities<Calendar>("lk_calendar_createdby", null); }
            set
            {
                OnPropertyChanging("lk_calendar_createdby");
                SetRelatedEntities("lk_calendar_createdby", null, value);
                OnPropertyChanged("lk_calendar_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_calendar_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_calendar_createdonbehalfby")]
        public IEnumerable<Calendar> lk_calendar_createdonbehalfby
        {
            get { return GetRelatedEntities<Calendar>("lk_calendar_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_calendar_createdonbehalfby");
                SetRelatedEntities("lk_calendar_createdonbehalfby", null, value);
                OnPropertyChanged("lk_calendar_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_calendar_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_calendar_modifiedby")]
        public IEnumerable<Calendar> lk_calendar_modifiedby
        {
            get { return GetRelatedEntities<Calendar>("lk_calendar_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_calendar_modifiedby");
                SetRelatedEntities("lk_calendar_modifiedby", null, value);
                OnPropertyChanged("lk_calendar_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_calendar_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_calendar_modifiedonbehalfby")]
        public IEnumerable<Calendar> lk_calendar_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Calendar>("lk_calendar_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_calendar_modifiedonbehalfby");
                SetRelatedEntities("lk_calendar_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_calendar_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_campaign_createdby
        /// </summary>
        [RelationshipSchemaName("lk_campaign_createdby")]
        public IEnumerable<Campaign> lk_campaign_createdby
        {
            get { return GetRelatedEntities<Campaign>("lk_campaign_createdby", null); }
            set
            {
                OnPropertyChanging("lk_campaign_createdby");
                SetRelatedEntities("lk_campaign_createdby", null, value);
                OnPropertyChanged("lk_campaign_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_campaign_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_campaign_createdonbehalfby")]
        public IEnumerable<Campaign> lk_campaign_createdonbehalfby
        {
            get { return GetRelatedEntities<Campaign>("lk_campaign_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_campaign_createdonbehalfby");
                SetRelatedEntities("lk_campaign_createdonbehalfby", null, value);
                OnPropertyChanged("lk_campaign_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_campaign_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_campaign_modifiedby")]
        public IEnumerable<Campaign> lk_campaign_modifiedby
        {
            get { return GetRelatedEntities<Campaign>("lk_campaign_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_campaign_modifiedby");
                SetRelatedEntities("lk_campaign_modifiedby", null, value);
                OnPropertyChanged("lk_campaign_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_campaign_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_campaign_modifiedonbehalfby")]
        public IEnumerable<Campaign> lk_campaign_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Campaign>("lk_campaign_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_campaign_modifiedonbehalfby");
                SetRelatedEntities("lk_campaign_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_campaign_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_campaignactivity_createdby
        /// </summary>
        [RelationshipSchemaName("lk_campaignactivity_createdby")]
        public IEnumerable<CampaignActivity> lk_campaignactivity_createdby
        {
            get { return GetRelatedEntities<CampaignActivity>("lk_campaignactivity_createdby", null); }
            set
            {
                OnPropertyChanging("lk_campaignactivity_createdby");
                SetRelatedEntities("lk_campaignactivity_createdby", null, value);
                OnPropertyChanged("lk_campaignactivity_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_campaignactivity_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_campaignactivity_createdonbehalfby")]
        public IEnumerable<CampaignActivity> lk_campaignactivity_createdonbehalfby
        {
            get { return GetRelatedEntities<CampaignActivity>("lk_campaignactivity_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_campaignactivity_createdonbehalfby");
                SetRelatedEntities("lk_campaignactivity_createdonbehalfby", null, value);
                OnPropertyChanged("lk_campaignactivity_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_campaignactivity_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_campaignactivity_modifiedby")]
        public IEnumerable<CampaignActivity> lk_campaignactivity_modifiedby
        {
            get { return GetRelatedEntities<CampaignActivity>("lk_campaignactivity_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_campaignactivity_modifiedby");
                SetRelatedEntities("lk_campaignactivity_modifiedby", null, value);
                OnPropertyChanged("lk_campaignactivity_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_campaignactivity_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_campaignactivity_modifiedonbehalfby")]
        public IEnumerable<CampaignActivity> lk_campaignactivity_modifiedonbehalfby
        {
            get { return GetRelatedEntities<CampaignActivity>("lk_campaignactivity_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_campaignactivity_modifiedonbehalfby");
                SetRelatedEntities("lk_campaignactivity_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_campaignactivity_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_campaignresponse_createdby
        /// </summary>
        [RelationshipSchemaName("lk_campaignresponse_createdby")]
        public IEnumerable<CampaignResponse> lk_campaignresponse_createdby
        {
            get { return GetRelatedEntities<CampaignResponse>("lk_campaignresponse_createdby", null); }
            set
            {
                OnPropertyChanging("lk_campaignresponse_createdby");
                SetRelatedEntities("lk_campaignresponse_createdby", null, value);
                OnPropertyChanged("lk_campaignresponse_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_campaignresponse_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_campaignresponse_createdonbehalfby")]
        public IEnumerable<CampaignResponse> lk_campaignresponse_createdonbehalfby
        {
            get { return GetRelatedEntities<CampaignResponse>("lk_campaignresponse_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_campaignresponse_createdonbehalfby");
                SetRelatedEntities("lk_campaignresponse_createdonbehalfby", null, value);
                OnPropertyChanged("lk_campaignresponse_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_campaignresponse_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_campaignresponse_modifiedby")]
        public IEnumerable<CampaignResponse> lk_campaignresponse_modifiedby
        {
            get { return GetRelatedEntities<CampaignResponse>("lk_campaignresponse_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_campaignresponse_modifiedby");
                SetRelatedEntities("lk_campaignresponse_modifiedby", null, value);
                OnPropertyChanged("lk_campaignresponse_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_campaignresponse_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_campaignresponse_modifiedonbehalfby")]
        public IEnumerable<CampaignResponse> lk_campaignresponse_modifiedonbehalfby
        {
            get { return GetRelatedEntities<CampaignResponse>("lk_campaignresponse_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_campaignresponse_modifiedonbehalfby");
                SetRelatedEntities("lk_campaignresponse_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_campaignresponse_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_columnmapping_createdby
        /// </summary>
        [RelationshipSchemaName("lk_columnmapping_createdby")]
        public IEnumerable<ColumnMapping> lk_columnmapping_createdby
        {
            get { return GetRelatedEntities<ColumnMapping>("lk_columnmapping_createdby", null); }
            set
            {
                OnPropertyChanging("lk_columnmapping_createdby");
                SetRelatedEntities("lk_columnmapping_createdby", null, value);
                OnPropertyChanged("lk_columnmapping_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_columnmapping_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_columnmapping_createdonbehalfby")]
        public IEnumerable<ColumnMapping> lk_columnmapping_createdonbehalfby
        {
            get { return GetRelatedEntities<ColumnMapping>("lk_columnmapping_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_columnmapping_createdonbehalfby");
                SetRelatedEntities("lk_columnmapping_createdonbehalfby", null, value);
                OnPropertyChanged("lk_columnmapping_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_columnmapping_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_columnmapping_modifiedby")]
        public IEnumerable<ColumnMapping> lk_columnmapping_modifiedby
        {
            get { return GetRelatedEntities<ColumnMapping>("lk_columnmapping_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_columnmapping_modifiedby");
                SetRelatedEntities("lk_columnmapping_modifiedby", null, value);
                OnPropertyChanged("lk_columnmapping_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_columnmapping_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_columnmapping_modifiedonbehalfby")]
        public IEnumerable<ColumnMapping> lk_columnmapping_modifiedonbehalfby
        {
            get { return GetRelatedEntities<ColumnMapping>("lk_columnmapping_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_columnmapping_modifiedonbehalfby");
                SetRelatedEntities("lk_columnmapping_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_columnmapping_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_competitor_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_competitor_createdonbehalfby")]
        public IEnumerable<Competitor> lk_competitor_createdonbehalfby
        {
            get { return GetRelatedEntities<Competitor>("lk_competitor_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_competitor_createdonbehalfby");
                SetRelatedEntities("lk_competitor_createdonbehalfby", null, value);
                OnPropertyChanged("lk_competitor_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_competitor_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_competitor_modifiedonbehalfby")]
        public IEnumerable<Competitor> lk_competitor_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Competitor>("lk_competitor_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_competitor_modifiedonbehalfby");
                SetRelatedEntities("lk_competitor_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_competitor_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_competitorbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_competitorbase_createdby")]
        public IEnumerable<Competitor> lk_competitorbase_createdby
        {
            get { return GetRelatedEntities<Competitor>("lk_competitorbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_competitorbase_createdby");
                SetRelatedEntities("lk_competitorbase_createdby", null, value);
                OnPropertyChanged("lk_competitorbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_competitorbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_competitorbase_modifiedby")]
        public IEnumerable<Competitor> lk_competitorbase_modifiedby
        {
            get { return GetRelatedEntities<Competitor>("lk_competitorbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_competitorbase_modifiedby");
                SetRelatedEntities("lk_competitorbase_modifiedby", null, value);
                OnPropertyChanged("lk_competitorbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_connectionbase_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_connectionbase_createdonbehalfby")]
        public IEnumerable<Connection> lk_connectionbase_createdonbehalfby
        {
            get { return GetRelatedEntities<Connection>("lk_connectionbase_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_connectionbase_createdonbehalfby");
                SetRelatedEntities("lk_connectionbase_createdonbehalfby", null, value);
                OnPropertyChanged("lk_connectionbase_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_connectionbase_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_connectionbase_modifiedonbehalfby")]
        public IEnumerable<Connection> lk_connectionbase_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Connection>("lk_connectionbase_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_connectionbase_modifiedonbehalfby");
                SetRelatedEntities("lk_connectionbase_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_connectionbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_connectionrolebase_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_connectionrolebase_createdonbehalfby")]
        public IEnumerable<ConnectionRole> lk_connectionrolebase_createdonbehalfby
        {
            get { return GetRelatedEntities<ConnectionRole>("lk_connectionrolebase_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_connectionrolebase_createdonbehalfby");
                SetRelatedEntities("lk_connectionrolebase_createdonbehalfby", null, value);
                OnPropertyChanged("lk_connectionrolebase_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_connectionrolebase_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_connectionrolebase_modifiedonbehalfby")]
        public IEnumerable<ConnectionRole> lk_connectionrolebase_modifiedonbehalfby
        {
            get { return GetRelatedEntities<ConnectionRole>("lk_connectionrolebase_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_connectionrolebase_modifiedonbehalfby");
                SetRelatedEntities("lk_connectionrolebase_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_connectionrolebase_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_constraintbasedgroup_createdby
        /// </summary>
        [RelationshipSchemaName("lk_constraintbasedgroup_createdby")]
        public IEnumerable<ConstraintBasedGroup> lk_constraintbasedgroup_createdby
        {
            get { return GetRelatedEntities<ConstraintBasedGroup>("lk_constraintbasedgroup_createdby", null); }
            set
            {
                OnPropertyChanging("lk_constraintbasedgroup_createdby");
                SetRelatedEntities("lk_constraintbasedgroup_createdby", null, value);
                OnPropertyChanged("lk_constraintbasedgroup_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_constraintbasedgroup_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_constraintbasedgroup_createdonbehalfby")]
        public IEnumerable<ConstraintBasedGroup> lk_constraintbasedgroup_createdonbehalfby
        {
            get { return GetRelatedEntities<ConstraintBasedGroup>("lk_constraintbasedgroup_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_constraintbasedgroup_createdonbehalfby");
                SetRelatedEntities("lk_constraintbasedgroup_createdonbehalfby", null, value);
                OnPropertyChanged("lk_constraintbasedgroup_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_constraintbasedgroup_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_constraintbasedgroup_modifiedby")]
        public IEnumerable<ConstraintBasedGroup> lk_constraintbasedgroup_modifiedby
        {
            get { return GetRelatedEntities<ConstraintBasedGroup>("lk_constraintbasedgroup_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_constraintbasedgroup_modifiedby");
                SetRelatedEntities("lk_constraintbasedgroup_modifiedby", null, value);
                OnPropertyChanged("lk_constraintbasedgroup_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_constraintbasedgroup_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_constraintbasedgroup_modifiedonbehalfby")]
        public IEnumerable<ConstraintBasedGroup> lk_constraintbasedgroup_modifiedonbehalfby
        {
            get { return GetRelatedEntities<ConstraintBasedGroup>("lk_constraintbasedgroup_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_constraintbasedgroup_modifiedonbehalfby");
                SetRelatedEntities("lk_constraintbasedgroup_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_constraintbasedgroup_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_contact_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_contact_createdonbehalfby")]
        public IEnumerable<Contact> lk_contact_createdonbehalfby
        {
            get { return GetRelatedEntities<Contact>("lk_contact_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_contact_createdonbehalfby");
                SetRelatedEntities("lk_contact_createdonbehalfby", null, value);
                OnPropertyChanged("lk_contact_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_contact_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_contact_modifiedonbehalfby")]
        public IEnumerable<Contact> lk_contact_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Contact>("lk_contact_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_contact_modifiedonbehalfby");
                SetRelatedEntities("lk_contact_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_contact_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_contactbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_contactbase_createdby")]
        public IEnumerable<Contact> lk_contactbase_createdby
        {
            get { return GetRelatedEntities<Contact>("lk_contactbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_contactbase_createdby");
                SetRelatedEntities("lk_contactbase_createdby", null, value);
                OnPropertyChanged("lk_contactbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_contactbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_contactbase_modifiedby")]
        public IEnumerable<Contact> lk_contactbase_modifiedby
        {
            get { return GetRelatedEntities<Contact>("lk_contactbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_contactbase_modifiedby");
                SetRelatedEntities("lk_contactbase_modifiedby", null, value);
                OnPropertyChanged("lk_contactbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_contract_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_contract_createdonbehalfby")]
        public IEnumerable<Contract> lk_contract_createdonbehalfby
        {
            get { return GetRelatedEntities<Contract>("lk_contract_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_contract_createdonbehalfby");
                SetRelatedEntities("lk_contract_createdonbehalfby", null, value);
                OnPropertyChanged("lk_contract_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_contract_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_contract_modifiedonbehalfby")]
        public IEnumerable<Contract> lk_contract_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Contract>("lk_contract_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_contract_modifiedonbehalfby");
                SetRelatedEntities("lk_contract_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_contract_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_contractbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_contractbase_createdby")]
        public IEnumerable<Contract> lk_contractbase_createdby
        {
            get { return GetRelatedEntities<Contract>("lk_contractbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_contractbase_createdby");
                SetRelatedEntities("lk_contractbase_createdby", null, value);
                OnPropertyChanged("lk_contractbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_contractbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_contractbase_modifiedby")]
        public IEnumerable<Contract> lk_contractbase_modifiedby
        {
            get { return GetRelatedEntities<Contract>("lk_contractbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_contractbase_modifiedby");
                SetRelatedEntities("lk_contractbase_modifiedby", null, value);
                OnPropertyChanged("lk_contractbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_contractdetail_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_contractdetail_createdonbehalfby")]
        public IEnumerable<ContractDetail> lk_contractdetail_createdonbehalfby
        {
            get { return GetRelatedEntities<ContractDetail>("lk_contractdetail_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_contractdetail_createdonbehalfby");
                SetRelatedEntities("lk_contractdetail_createdonbehalfby", null, value);
                OnPropertyChanged("lk_contractdetail_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_contractdetail_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_contractdetail_modifiedonbehalfby")]
        public IEnumerable<ContractDetail> lk_contractdetail_modifiedonbehalfby
        {
            get { return GetRelatedEntities<ContractDetail>("lk_contractdetail_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_contractdetail_modifiedonbehalfby");
                SetRelatedEntities("lk_contractdetail_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_contractdetail_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_contractdetailbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_contractdetailbase_createdby")]
        public IEnumerable<ContractDetail> lk_contractdetailbase_createdby
        {
            get { return GetRelatedEntities<ContractDetail>("lk_contractdetailbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_contractdetailbase_createdby");
                SetRelatedEntities("lk_contractdetailbase_createdby", null, value);
                OnPropertyChanged("lk_contractdetailbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_contractdetailbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_contractdetailbase_modifiedby")]
        public IEnumerable<ContractDetail> lk_contractdetailbase_modifiedby
        {
            get { return GetRelatedEntities<ContractDetail>("lk_contractdetailbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_contractdetailbase_modifiedby");
                SetRelatedEntities("lk_contractdetailbase_modifiedby", null, value);
                OnPropertyChanged("lk_contractdetailbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_contracttemplate_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_contracttemplate_createdonbehalfby")]
        public IEnumerable<ContractTemplate> lk_contracttemplate_createdonbehalfby
        {
            get { return GetRelatedEntities<ContractTemplate>("lk_contracttemplate_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_contracttemplate_createdonbehalfby");
                SetRelatedEntities("lk_contracttemplate_createdonbehalfby", null, value);
                OnPropertyChanged("lk_contracttemplate_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_contracttemplate_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_contracttemplate_modifiedonbehalfby")]
        public IEnumerable<ContractTemplate> lk_contracttemplate_modifiedonbehalfby
        {
            get { return GetRelatedEntities<ContractTemplate>("lk_contracttemplate_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_contracttemplate_modifiedonbehalfby");
                SetRelatedEntities("lk_contracttemplate_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_contracttemplate_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_contracttemplatebase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_contracttemplatebase_createdby")]
        public IEnumerable<ContractTemplate> lk_contracttemplatebase_createdby
        {
            get { return GetRelatedEntities<ContractTemplate>("lk_contracttemplatebase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_contracttemplatebase_createdby");
                SetRelatedEntities("lk_contracttemplatebase_createdby", null, value);
                OnPropertyChanged("lk_contracttemplatebase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_contracttemplatebase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_contracttemplatebase_modifiedby")]
        public IEnumerable<ContractTemplate> lk_contracttemplatebase_modifiedby
        {
            get { return GetRelatedEntities<ContractTemplate>("lk_contracttemplatebase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_contracttemplatebase_modifiedby");
                SetRelatedEntities("lk_contracttemplatebase_modifiedby", null, value);
                OnPropertyChanged("lk_contracttemplatebase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_customeraddress_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_customeraddress_createdonbehalfby")]
        public IEnumerable<CustomerAddress> lk_customeraddress_createdonbehalfby
        {
            get { return GetRelatedEntities<CustomerAddress>("lk_customeraddress_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_customeraddress_createdonbehalfby");
                SetRelatedEntities("lk_customeraddress_createdonbehalfby", null, value);
                OnPropertyChanged("lk_customeraddress_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_customeraddress_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_customeraddress_modifiedonbehalfby")]
        public IEnumerable<CustomerAddress> lk_customeraddress_modifiedonbehalfby
        {
            get { return GetRelatedEntities<CustomerAddress>("lk_customeraddress_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_customeraddress_modifiedonbehalfby");
                SetRelatedEntities("lk_customeraddress_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_customeraddress_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_customeraddressbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_customeraddressbase_createdby")]
        public IEnumerable<CustomerAddress> lk_customeraddressbase_createdby
        {
            get { return GetRelatedEntities<CustomerAddress>("lk_customeraddressbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_customeraddressbase_createdby");
                SetRelatedEntities("lk_customeraddressbase_createdby", null, value);
                OnPropertyChanged("lk_customeraddressbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_customeraddressbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_customeraddressbase_modifiedby")]
        public IEnumerable<CustomerAddress> lk_customeraddressbase_modifiedby
        {
            get { return GetRelatedEntities<CustomerAddress>("lk_customeraddressbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_customeraddressbase_modifiedby");
                SetRelatedEntities("lk_customeraddressbase_modifiedby", null, value);
                OnPropertyChanged("lk_customeraddressbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_customeropportunityrole_createdby
        /// </summary>
        [RelationshipSchemaName("lk_customeropportunityrole_createdby")]
        public IEnumerable<CustomerOpportunityRole> lk_customeropportunityrole_createdby
        {
            get { return GetRelatedEntities<CustomerOpportunityRole>("lk_customeropportunityrole_createdby", null); }
            set
            {
                OnPropertyChanging("lk_customeropportunityrole_createdby");
                SetRelatedEntities("lk_customeropportunityrole_createdby", null, value);
                OnPropertyChanged("lk_customeropportunityrole_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_customeropportunityrole_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_customeropportunityrole_createdonbehalfby")]
        public IEnumerable<CustomerOpportunityRole> lk_customeropportunityrole_createdonbehalfby
        {
            get
            {
                return GetRelatedEntities<CustomerOpportunityRole>("lk_customeropportunityrole_createdonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_customeropportunityrole_createdonbehalfby");
                SetRelatedEntities("lk_customeropportunityrole_createdonbehalfby", null, value);
                OnPropertyChanged("lk_customeropportunityrole_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_customeropportunityrole_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_customeropportunityrole_modifiedby")]
        public IEnumerable<CustomerOpportunityRole> lk_customeropportunityrole_modifiedby
        {
            get { return GetRelatedEntities<CustomerOpportunityRole>("lk_customeropportunityrole_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_customeropportunityrole_modifiedby");
                SetRelatedEntities("lk_customeropportunityrole_modifiedby", null, value);
                OnPropertyChanged("lk_customeropportunityrole_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_customeropportunityrole_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_customeropportunityrole_modifiedonbehalfby")]
        public IEnumerable<CustomerOpportunityRole> lk_customeropportunityrole_modifiedonbehalfby
        {
            get
            {
                return GetRelatedEntities<CustomerOpportunityRole>("lk_customeropportunityrole_modifiedonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_customeropportunityrole_modifiedonbehalfby");
                SetRelatedEntities("lk_customeropportunityrole_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_customeropportunityrole_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_discount_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_discount_createdonbehalfby")]
        public IEnumerable<Discount> lk_discount_createdonbehalfby
        {
            get { return GetRelatedEntities<Discount>("lk_discount_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_discount_createdonbehalfby");
                SetRelatedEntities("lk_discount_createdonbehalfby", null, value);
                OnPropertyChanged("lk_discount_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_discount_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_discount_modifiedonbehalfby")]
        public IEnumerable<Discount> lk_discount_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Discount>("lk_discount_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_discount_modifiedonbehalfby");
                SetRelatedEntities("lk_discount_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_discount_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_discountbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_discountbase_createdby")]
        public IEnumerable<Discount> lk_discountbase_createdby
        {
            get { return GetRelatedEntities<Discount>("lk_discountbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_discountbase_createdby");
                SetRelatedEntities("lk_discountbase_createdby", null, value);
                OnPropertyChanged("lk_discountbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_discountbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_discountbase_modifiedby")]
        public IEnumerable<Discount> lk_discountbase_modifiedby
        {
            get { return GetRelatedEntities<Discount>("lk_discountbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_discountbase_modifiedby");
                SetRelatedEntities("lk_discountbase_modifiedby", null, value);
                OnPropertyChanged("lk_discountbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_discounttype_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_discounttype_createdonbehalfby")]
        public IEnumerable<DiscountType> lk_discounttype_createdonbehalfby
        {
            get { return GetRelatedEntities<DiscountType>("lk_discounttype_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_discounttype_createdonbehalfby");
                SetRelatedEntities("lk_discounttype_createdonbehalfby", null, value);
                OnPropertyChanged("lk_discounttype_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_discounttype_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_discounttype_modifiedonbehalfby")]
        public IEnumerable<DiscountType> lk_discounttype_modifiedonbehalfby
        {
            get { return GetRelatedEntities<DiscountType>("lk_discounttype_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_discounttype_modifiedonbehalfby");
                SetRelatedEntities("lk_discounttype_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_discounttype_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_discounttypebase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_discounttypebase_createdby")]
        public IEnumerable<DiscountType> lk_discounttypebase_createdby
        {
            get { return GetRelatedEntities<DiscountType>("lk_discounttypebase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_discounttypebase_createdby");
                SetRelatedEntities("lk_discounttypebase_createdby", null, value);
                OnPropertyChanged("lk_discounttypebase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_discounttypebase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_discounttypebase_modifiedby")]
        public IEnumerable<DiscountType> lk_discounttypebase_modifiedby
        {
            get { return GetRelatedEntities<DiscountType>("lk_discounttypebase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_discounttypebase_modifiedby");
                SetRelatedEntities("lk_discounttypebase_modifiedby", null, value);
                OnPropertyChanged("lk_discounttypebase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_DisplayStringbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_DisplayStringbase_createdby")]
        public IEnumerable<DisplayString> lk_DisplayStringbase_createdby
        {
            get { return GetRelatedEntities<DisplayString>("lk_DisplayStringbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_DisplayStringbase_createdby");
                SetRelatedEntities("lk_DisplayStringbase_createdby", null, value);
                OnPropertyChanged("lk_DisplayStringbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_DisplayStringbase_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_DisplayStringbase_createdonbehalfby")]
        public IEnumerable<DisplayString> lk_DisplayStringbase_createdonbehalfby
        {
            get { return GetRelatedEntities<DisplayString>("lk_DisplayStringbase_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_DisplayStringbase_createdonbehalfby");
                SetRelatedEntities("lk_DisplayStringbase_createdonbehalfby", null, value);
                OnPropertyChanged("lk_DisplayStringbase_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_DisplayStringbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_DisplayStringbase_modifiedby")]
        public IEnumerable<DisplayString> lk_DisplayStringbase_modifiedby
        {
            get { return GetRelatedEntities<DisplayString>("lk_DisplayStringbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_DisplayStringbase_modifiedby");
                SetRelatedEntities("lk_DisplayStringbase_modifiedby", null, value);
                OnPropertyChanged("lk_DisplayStringbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_DisplayStringbase_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_DisplayStringbase_modifiedonbehalfby")]
        public IEnumerable<DisplayString> lk_DisplayStringbase_modifiedonbehalfby
        {
            get { return GetRelatedEntities<DisplayString>("lk_DisplayStringbase_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_DisplayStringbase_modifiedonbehalfby");
                SetRelatedEntities("lk_DisplayStringbase_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_DisplayStringbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_duplicaterule_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_duplicaterule_createdonbehalfby")]
        public IEnumerable<DuplicateRule> lk_duplicaterule_createdonbehalfby
        {
            get { return GetRelatedEntities<DuplicateRule>("lk_duplicaterule_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_duplicaterule_createdonbehalfby");
                SetRelatedEntities("lk_duplicaterule_createdonbehalfby", null, value);
                OnPropertyChanged("lk_duplicaterule_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_duplicaterule_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_duplicaterule_modifiedonbehalfby")]
        public IEnumerable<DuplicateRule> lk_duplicaterule_modifiedonbehalfby
        {
            get { return GetRelatedEntities<DuplicateRule>("lk_duplicaterule_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_duplicaterule_modifiedonbehalfby");
                SetRelatedEntities("lk_duplicaterule_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_duplicaterule_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_duplicaterulebase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_duplicaterulebase_createdby")]
        public IEnumerable<DuplicateRule> lk_duplicaterulebase_createdby
        {
            get { return GetRelatedEntities<DuplicateRule>("lk_duplicaterulebase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_duplicaterulebase_createdby");
                SetRelatedEntities("lk_duplicaterulebase_createdby", null, value);
                OnPropertyChanged("lk_duplicaterulebase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_duplicaterulebase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_duplicaterulebase_modifiedby")]
        public IEnumerable<DuplicateRule> lk_duplicaterulebase_modifiedby
        {
            get { return GetRelatedEntities<DuplicateRule>("lk_duplicaterulebase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_duplicaterulebase_modifiedby");
                SetRelatedEntities("lk_duplicaterulebase_modifiedby", null, value);
                OnPropertyChanged("lk_duplicaterulebase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_duplicaterulecondition_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_duplicaterulecondition_createdonbehalfby")]
        public IEnumerable<DuplicateRuleCondition> lk_duplicaterulecondition_createdonbehalfby
        {
            get
            {
                return GetRelatedEntities<DuplicateRuleCondition>("lk_duplicaterulecondition_createdonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_duplicaterulecondition_createdonbehalfby");
                SetRelatedEntities("lk_duplicaterulecondition_createdonbehalfby", null, value);
                OnPropertyChanged("lk_duplicaterulecondition_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_duplicaterulecondition_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_duplicaterulecondition_modifiedonbehalfby")]
        public IEnumerable<DuplicateRuleCondition> lk_duplicaterulecondition_modifiedonbehalfby
        {
            get
            {
                return GetRelatedEntities<DuplicateRuleCondition>("lk_duplicaterulecondition_modifiedonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_duplicaterulecondition_modifiedonbehalfby");
                SetRelatedEntities("lk_duplicaterulecondition_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_duplicaterulecondition_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_duplicateruleconditionbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_duplicateruleconditionbase_createdby")]
        public IEnumerable<DuplicateRuleCondition> lk_duplicateruleconditionbase_createdby
        {
            get { return GetRelatedEntities<DuplicateRuleCondition>("lk_duplicateruleconditionbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_duplicateruleconditionbase_createdby");
                SetRelatedEntities("lk_duplicateruleconditionbase_createdby", null, value);
                OnPropertyChanged("lk_duplicateruleconditionbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_duplicateruleconditionbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_duplicateruleconditionbase_modifiedby")]
        public IEnumerable<DuplicateRuleCondition> lk_duplicateruleconditionbase_modifiedby
        {
            get { return GetRelatedEntities<DuplicateRuleCondition>("lk_duplicateruleconditionbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_duplicateruleconditionbase_modifiedby");
                SetRelatedEntities("lk_duplicateruleconditionbase_modifiedby", null, value);
                OnPropertyChanged("lk_duplicateruleconditionbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_email_createdby
        /// </summary>
        [RelationshipSchemaName("lk_email_createdby")]
        public IEnumerable<Email> lk_email_createdby
        {
            get { return GetRelatedEntities<Email>("lk_email_createdby", null); }
            set
            {
                OnPropertyChanging("lk_email_createdby");
                SetRelatedEntities("lk_email_createdby", null, value);
                OnPropertyChanged("lk_email_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_email_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_email_createdonbehalfby")]
        public IEnumerable<Email> lk_email_createdonbehalfby
        {
            get { return GetRelatedEntities<Email>("lk_email_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_email_createdonbehalfby");
                SetRelatedEntities("lk_email_createdonbehalfby", null, value);
                OnPropertyChanged("lk_email_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_email_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_email_modifiedby")]
        public IEnumerable<Email> lk_email_modifiedby
        {
            get { return GetRelatedEntities<Email>("lk_email_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_email_modifiedby");
                SetRelatedEntities("lk_email_modifiedby", null, value);
                OnPropertyChanged("lk_email_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_email_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_email_modifiedonbehalfby")]
        public IEnumerable<Email> lk_email_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Email>("lk_email_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_email_modifiedonbehalfby");
                SetRelatedEntities("lk_email_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_email_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_emailserverprofile_createdby
        /// </summary>
        [RelationshipSchemaName("lk_emailserverprofile_createdby")]
        public IEnumerable<EmailServerProfile> lk_emailserverprofile_createdby
        {
            get { return GetRelatedEntities<EmailServerProfile>("lk_emailserverprofile_createdby", null); }
            set
            {
                OnPropertyChanging("lk_emailserverprofile_createdby");
                SetRelatedEntities("lk_emailserverprofile_createdby", null, value);
                OnPropertyChanged("lk_emailserverprofile_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_emailserverprofile_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_emailserverprofile_createdonbehalfby")]
        public IEnumerable<EmailServerProfile> lk_emailserverprofile_createdonbehalfby
        {
            get { return GetRelatedEntities<EmailServerProfile>("lk_emailserverprofile_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_emailserverprofile_createdonbehalfby");
                SetRelatedEntities("lk_emailserverprofile_createdonbehalfby", null, value);
                OnPropertyChanged("lk_emailserverprofile_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_emailserverprofile_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_emailserverprofile_modifiedby")]
        public IEnumerable<EmailServerProfile> lk_emailserverprofile_modifiedby
        {
            get { return GetRelatedEntities<EmailServerProfile>("lk_emailserverprofile_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_emailserverprofile_modifiedby");
                SetRelatedEntities("lk_emailserverprofile_modifiedby", null, value);
                OnPropertyChanged("lk_emailserverprofile_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_emailserverprofile_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_emailserverprofile_modifiedonbehalfby")]
        public IEnumerable<EmailServerProfile> lk_emailserverprofile_modifiedonbehalfby
        {
            get { return GetRelatedEntities<EmailServerProfile>("lk_emailserverprofile_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_emailserverprofile_modifiedonbehalfby");
                SetRelatedEntities("lk_emailserverprofile_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_emailserverprofile_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_entitymap_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_entitymap_createdonbehalfby")]
        public IEnumerable<EntityMap> lk_entitymap_createdonbehalfby
        {
            get { return GetRelatedEntities<EntityMap>("lk_entitymap_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_entitymap_createdonbehalfby");
                SetRelatedEntities("lk_entitymap_createdonbehalfby", null, value);
                OnPropertyChanged("lk_entitymap_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_entitymap_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_entitymap_modifiedonbehalfby")]
        public IEnumerable<EntityMap> lk_entitymap_modifiedonbehalfby
        {
            get { return GetRelatedEntities<EntityMap>("lk_entitymap_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_entitymap_modifiedonbehalfby");
                SetRelatedEntities("lk_entitymap_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_entitymap_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_equipment_createdby
        /// </summary>
        [RelationshipSchemaName("lk_equipment_createdby")]
        public IEnumerable<Equipment> lk_equipment_createdby
        {
            get { return GetRelatedEntities<Equipment>("lk_equipment_createdby", null); }
            set
            {
                OnPropertyChanging("lk_equipment_createdby");
                SetRelatedEntities("lk_equipment_createdby", null, value);
                OnPropertyChanged("lk_equipment_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_equipment_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_equipment_createdonbehalfby")]
        public IEnumerable<Equipment> lk_equipment_createdonbehalfby
        {
            get { return GetRelatedEntities<Equipment>("lk_equipment_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_equipment_createdonbehalfby");
                SetRelatedEntities("lk_equipment_createdonbehalfby", null, value);
                OnPropertyChanged("lk_equipment_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_equipment_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_equipment_modifiedby")]
        public IEnumerable<Equipment> lk_equipment_modifiedby
        {
            get { return GetRelatedEntities<Equipment>("lk_equipment_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_equipment_modifiedby");
                SetRelatedEntities("lk_equipment_modifiedby", null, value);
                OnPropertyChanged("lk_equipment_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_equipment_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_equipment_modifiedonbehalfby")]
        public IEnumerable<Equipment> lk_equipment_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Equipment>("lk_equipment_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_equipment_modifiedonbehalfby");
                SetRelatedEntities("lk_equipment_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_equipment_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_fax_createdby
        /// </summary>
        [RelationshipSchemaName("lk_fax_createdby")]
        public IEnumerable<Fax> lk_fax_createdby
        {
            get { return GetRelatedEntities<Fax>("lk_fax_createdby", null); }
            set
            {
                OnPropertyChanging("lk_fax_createdby");
                SetRelatedEntities("lk_fax_createdby", null, value);
                OnPropertyChanged("lk_fax_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_fax_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_fax_createdonbehalfby")]
        public IEnumerable<Fax> lk_fax_createdonbehalfby
        {
            get { return GetRelatedEntities<Fax>("lk_fax_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_fax_createdonbehalfby");
                SetRelatedEntities("lk_fax_createdonbehalfby", null, value);
                OnPropertyChanged("lk_fax_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_fax_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_fax_modifiedby")]
        public IEnumerable<Fax> lk_fax_modifiedby
        {
            get { return GetRelatedEntities<Fax>("lk_fax_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_fax_modifiedby");
                SetRelatedEntities("lk_fax_modifiedby", null, value);
                OnPropertyChanged("lk_fax_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_fax_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_fax_modifiedonbehalfby")]
        public IEnumerable<Fax> lk_fax_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Fax>("lk_fax_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_fax_modifiedonbehalfby");
                SetRelatedEntities("lk_fax_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_fax_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_fieldsecurityprofile_createdby
        /// </summary>
        [RelationshipSchemaName("lk_fieldsecurityprofile_createdby")]
        public IEnumerable<FieldSecurityProfile> lk_fieldsecurityprofile_createdby
        {
            get { return GetRelatedEntities<FieldSecurityProfile>("lk_fieldsecurityprofile_createdby", null); }
            set
            {
                OnPropertyChanging("lk_fieldsecurityprofile_createdby");
                SetRelatedEntities("lk_fieldsecurityprofile_createdby", null, value);
                OnPropertyChanged("lk_fieldsecurityprofile_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_fieldsecurityprofile_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_fieldsecurityprofile_createdonbehalfby")]
        public IEnumerable<FieldSecurityProfile> lk_fieldsecurityprofile_createdonbehalfby
        {
            get { return GetRelatedEntities<FieldSecurityProfile>("lk_fieldsecurityprofile_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_fieldsecurityprofile_createdonbehalfby");
                SetRelatedEntities("lk_fieldsecurityprofile_createdonbehalfby", null, value);
                OnPropertyChanged("lk_fieldsecurityprofile_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_fieldsecurityprofile_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_fieldsecurityprofile_modifiedby")]
        public IEnumerable<FieldSecurityProfile> lk_fieldsecurityprofile_modifiedby
        {
            get { return GetRelatedEntities<FieldSecurityProfile>("lk_fieldsecurityprofile_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_fieldsecurityprofile_modifiedby");
                SetRelatedEntities("lk_fieldsecurityprofile_modifiedby", null, value);
                OnPropertyChanged("lk_fieldsecurityprofile_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_fieldsecurityprofile_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_fieldsecurityprofile_modifiedonbehalfby")]
        public IEnumerable<FieldSecurityProfile> lk_fieldsecurityprofile_modifiedonbehalfby
        {
            get { return GetRelatedEntities<FieldSecurityProfile>("lk_fieldsecurityprofile_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_fieldsecurityprofile_modifiedonbehalfby");
                SetRelatedEntities("lk_fieldsecurityprofile_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_fieldsecurityprofile_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_fixedmonthlyfiscalcalendar_createdby
        /// </summary>
        [RelationshipSchemaName("lk_fixedmonthlyfiscalcalendar_createdby")]
        public IEnumerable<FixedMonthlyFiscalCalendar> lk_fixedmonthlyfiscalcalendar_createdby
        {
            get
            {
                return GetRelatedEntities<FixedMonthlyFiscalCalendar>("lk_fixedmonthlyfiscalcalendar_createdby", null);
            }
            set
            {
                OnPropertyChanging("lk_fixedmonthlyfiscalcalendar_createdby");
                SetRelatedEntities("lk_fixedmonthlyfiscalcalendar_createdby", null, value);
                OnPropertyChanged("lk_fixedmonthlyfiscalcalendar_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_fixedmonthlyfiscalcalendar_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_fixedmonthlyfiscalcalendar_createdonbehalfby")]
        public IEnumerable<FixedMonthlyFiscalCalendar> lk_fixedmonthlyfiscalcalendar_createdonbehalfby
        {
            get
            {
                return GetRelatedEntities<FixedMonthlyFiscalCalendar>(
                    "lk_fixedmonthlyfiscalcalendar_createdonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_fixedmonthlyfiscalcalendar_createdonbehalfby");
                SetRelatedEntities("lk_fixedmonthlyfiscalcalendar_createdonbehalfby", null, value);
                OnPropertyChanged("lk_fixedmonthlyfiscalcalendar_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_fixedmonthlyfiscalcalendar_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_fixedmonthlyfiscalcalendar_modifiedby")]
        public IEnumerable<FixedMonthlyFiscalCalendar> lk_fixedmonthlyfiscalcalendar_modifiedby
        {
            get
            {
                return GetRelatedEntities<FixedMonthlyFiscalCalendar>("lk_fixedmonthlyfiscalcalendar_modifiedby", null);
            }
            set
            {
                OnPropertyChanging("lk_fixedmonthlyfiscalcalendar_modifiedby");
                SetRelatedEntities("lk_fixedmonthlyfiscalcalendar_modifiedby", null, value);
                OnPropertyChanged("lk_fixedmonthlyfiscalcalendar_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby")]
        public IEnumerable<FixedMonthlyFiscalCalendar> lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby
        {
            get
            {
                return GetRelatedEntities<FixedMonthlyFiscalCalendar>(
                    "lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby");
                SetRelatedEntities("lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_fixedmonthlyfiscalcalendar_salespersonid
        /// </summary>
        [RelationshipSchemaName("lk_fixedmonthlyfiscalcalendar_salespersonid")]
        public IEnumerable<FixedMonthlyFiscalCalendar> lk_fixedmonthlyfiscalcalendar_salespersonid
        {
            get
            {
                return GetRelatedEntities<FixedMonthlyFiscalCalendar>("lk_fixedmonthlyfiscalcalendar_salespersonid",
                    null);
            }
            set
            {
                OnPropertyChanging("lk_fixedmonthlyfiscalcalendar_salespersonid");
                SetRelatedEntities("lk_fixedmonthlyfiscalcalendar_salespersonid", null, value);
                OnPropertyChanged("lk_fixedmonthlyfiscalcalendar_salespersonid");
            }
        }

        /// <summary>
        ///     1:N lk_goal_createdby
        /// </summary>
        [RelationshipSchemaName("lk_goal_createdby")]
        public IEnumerable<Goal> lk_goal_createdby
        {
            get { return GetRelatedEntities<Goal>("lk_goal_createdby", null); }
            set
            {
                OnPropertyChanging("lk_goal_createdby");
                SetRelatedEntities("lk_goal_createdby", null, value);
                OnPropertyChanged("lk_goal_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_goal_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_goal_createdonbehalfby")]
        public IEnumerable<Goal> lk_goal_createdonbehalfby
        {
            get { return GetRelatedEntities<Goal>("lk_goal_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_goal_createdonbehalfby");
                SetRelatedEntities("lk_goal_createdonbehalfby", null, value);
                OnPropertyChanged("lk_goal_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_goal_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_goal_modifiedby")]
        public IEnumerable<Goal> lk_goal_modifiedby
        {
            get { return GetRelatedEntities<Goal>("lk_goal_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_goal_modifiedby");
                SetRelatedEntities("lk_goal_modifiedby", null, value);
                OnPropertyChanged("lk_goal_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_goal_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_goal_modifiedonbehalfby")]
        public IEnumerable<Goal> lk_goal_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Goal>("lk_goal_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_goal_modifiedonbehalfby");
                SetRelatedEntities("lk_goal_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_goal_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_goalrollupquery_createdby
        /// </summary>
        [RelationshipSchemaName("lk_goalrollupquery_createdby")]
        public IEnumerable<GoalRollupQuery> lk_goalrollupquery_createdby
        {
            get { return GetRelatedEntities<GoalRollupQuery>("lk_goalrollupquery_createdby", null); }
            set
            {
                OnPropertyChanging("lk_goalrollupquery_createdby");
                SetRelatedEntities("lk_goalrollupquery_createdby", null, value);
                OnPropertyChanged("lk_goalrollupquery_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_goalrollupquery_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_goalrollupquery_createdonbehalfby")]
        public IEnumerable<GoalRollupQuery> lk_goalrollupquery_createdonbehalfby
        {
            get { return GetRelatedEntities<GoalRollupQuery>("lk_goalrollupquery_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_goalrollupquery_createdonbehalfby");
                SetRelatedEntities("lk_goalrollupquery_createdonbehalfby", null, value);
                OnPropertyChanged("lk_goalrollupquery_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_goalrollupquery_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_goalrollupquery_modifiedby")]
        public IEnumerable<GoalRollupQuery> lk_goalrollupquery_modifiedby
        {
            get { return GetRelatedEntities<GoalRollupQuery>("lk_goalrollupquery_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_goalrollupquery_modifiedby");
                SetRelatedEntities("lk_goalrollupquery_modifiedby", null, value);
                OnPropertyChanged("lk_goalrollupquery_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_goalrollupquery_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_goalrollupquery_modifiedonbehalfby")]
        public IEnumerable<GoalRollupQuery> lk_goalrollupquery_modifiedonbehalfby
        {
            get { return GetRelatedEntities<GoalRollupQuery>("lk_goalrollupquery_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_goalrollupquery_modifiedonbehalfby");
                SetRelatedEntities("lk_goalrollupquery_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_goalrollupquery_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_import_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_import_createdonbehalfby")]
        public IEnumerable<Import> lk_import_createdonbehalfby
        {
            get { return GetRelatedEntities<Import>("lk_import_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_import_createdonbehalfby");
                SetRelatedEntities("lk_import_createdonbehalfby", null, value);
                OnPropertyChanged("lk_import_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_import_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_import_modifiedonbehalfby")]
        public IEnumerable<Import> lk_import_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Import>("lk_import_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_import_modifiedonbehalfby");
                SetRelatedEntities("lk_import_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_import_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_importbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_importbase_createdby")]
        public IEnumerable<Import> lk_importbase_createdby
        {
            get { return GetRelatedEntities<Import>("lk_importbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_importbase_createdby");
                SetRelatedEntities("lk_importbase_createdby", null, value);
                OnPropertyChanged("lk_importbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_importbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_importbase_modifiedby")]
        public IEnumerable<Import> lk_importbase_modifiedby
        {
            get { return GetRelatedEntities<Import>("lk_importbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_importbase_modifiedby");
                SetRelatedEntities("lk_importbase_modifiedby", null, value);
                OnPropertyChanged("lk_importbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_importentitymapping_createdby
        /// </summary>
        [RelationshipSchemaName("lk_importentitymapping_createdby")]
        public IEnumerable<ImportEntityMapping> lk_importentitymapping_createdby
        {
            get { return GetRelatedEntities<ImportEntityMapping>("lk_importentitymapping_createdby", null); }
            set
            {
                OnPropertyChanging("lk_importentitymapping_createdby");
                SetRelatedEntities("lk_importentitymapping_createdby", null, value);
                OnPropertyChanged("lk_importentitymapping_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_importentitymapping_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_importentitymapping_createdonbehalfby")]
        public IEnumerable<ImportEntityMapping> lk_importentitymapping_createdonbehalfby
        {
            get { return GetRelatedEntities<ImportEntityMapping>("lk_importentitymapping_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_importentitymapping_createdonbehalfby");
                SetRelatedEntities("lk_importentitymapping_createdonbehalfby", null, value);
                OnPropertyChanged("lk_importentitymapping_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_importentitymapping_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_importentitymapping_modifiedby")]
        public IEnumerable<ImportEntityMapping> lk_importentitymapping_modifiedby
        {
            get { return GetRelatedEntities<ImportEntityMapping>("lk_importentitymapping_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_importentitymapping_modifiedby");
                SetRelatedEntities("lk_importentitymapping_modifiedby", null, value);
                OnPropertyChanged("lk_importentitymapping_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_importentitymapping_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_importentitymapping_modifiedonbehalfby")]
        public IEnumerable<ImportEntityMapping> lk_importentitymapping_modifiedonbehalfby
        {
            get { return GetRelatedEntities<ImportEntityMapping>("lk_importentitymapping_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_importentitymapping_modifiedonbehalfby");
                SetRelatedEntities("lk_importentitymapping_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_importentitymapping_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_importfilebase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_importfilebase_createdby")]
        public IEnumerable<ImportFile> lk_importfilebase_createdby
        {
            get { return GetRelatedEntities<ImportFile>("lk_importfilebase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_importfilebase_createdby");
                SetRelatedEntities("lk_importfilebase_createdby", null, value);
                OnPropertyChanged("lk_importfilebase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_importfilebase_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_importfilebase_createdonbehalfby")]
        public IEnumerable<ImportFile> lk_importfilebase_createdonbehalfby
        {
            get { return GetRelatedEntities<ImportFile>("lk_importfilebase_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_importfilebase_createdonbehalfby");
                SetRelatedEntities("lk_importfilebase_createdonbehalfby", null, value);
                OnPropertyChanged("lk_importfilebase_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_importfilebase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_importfilebase_modifiedby")]
        public IEnumerable<ImportFile> lk_importfilebase_modifiedby
        {
            get { return GetRelatedEntities<ImportFile>("lk_importfilebase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_importfilebase_modifiedby");
                SetRelatedEntities("lk_importfilebase_modifiedby", null, value);
                OnPropertyChanged("lk_importfilebase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_importfilebase_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_importfilebase_modifiedonbehalfby")]
        public IEnumerable<ImportFile> lk_importfilebase_modifiedonbehalfby
        {
            get { return GetRelatedEntities<ImportFile>("lk_importfilebase_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_importfilebase_modifiedonbehalfby");
                SetRelatedEntities("lk_importfilebase_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_importfilebase_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_importjobbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_importjobbase_createdby")]
        public IEnumerable<ImportJob> lk_importjobbase_createdby
        {
            get { return GetRelatedEntities<ImportJob>("lk_importjobbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_importjobbase_createdby");
                SetRelatedEntities("lk_importjobbase_createdby", null, value);
                OnPropertyChanged("lk_importjobbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_importjobbase_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_importjobbase_createdonbehalfby")]
        public IEnumerable<ImportJob> lk_importjobbase_createdonbehalfby
        {
            get { return GetRelatedEntities<ImportJob>("lk_importjobbase_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_importjobbase_createdonbehalfby");
                SetRelatedEntities("lk_importjobbase_createdonbehalfby", null, value);
                OnPropertyChanged("lk_importjobbase_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_importjobbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_importjobbase_modifiedby")]
        public IEnumerable<ImportJob> lk_importjobbase_modifiedby
        {
            get { return GetRelatedEntities<ImportJob>("lk_importjobbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_importjobbase_modifiedby");
                SetRelatedEntities("lk_importjobbase_modifiedby", null, value);
                OnPropertyChanged("lk_importjobbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_importjobbase_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_importjobbase_modifiedonbehalfby")]
        public IEnumerable<ImportJob> lk_importjobbase_modifiedonbehalfby
        {
            get { return GetRelatedEntities<ImportJob>("lk_importjobbase_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_importjobbase_modifiedonbehalfby");
                SetRelatedEntities("lk_importjobbase_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_importjobbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_importlog_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_importlog_createdonbehalfby")]
        public IEnumerable<ImportLog> lk_importlog_createdonbehalfby
        {
            get { return GetRelatedEntities<ImportLog>("lk_importlog_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_importlog_createdonbehalfby");
                SetRelatedEntities("lk_importlog_createdonbehalfby", null, value);
                OnPropertyChanged("lk_importlog_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_importlog_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_importlog_modifiedonbehalfby")]
        public IEnumerable<ImportLog> lk_importlog_modifiedonbehalfby
        {
            get { return GetRelatedEntities<ImportLog>("lk_importlog_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_importlog_modifiedonbehalfby");
                SetRelatedEntities("lk_importlog_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_importlog_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_importlogbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_importlogbase_createdby")]
        public IEnumerable<ImportLog> lk_importlogbase_createdby
        {
            get { return GetRelatedEntities<ImportLog>("lk_importlogbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_importlogbase_createdby");
                SetRelatedEntities("lk_importlogbase_createdby", null, value);
                OnPropertyChanged("lk_importlogbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_importlogbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_importlogbase_modifiedby")]
        public IEnumerable<ImportLog> lk_importlogbase_modifiedby
        {
            get { return GetRelatedEntities<ImportLog>("lk_importlogbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_importlogbase_modifiedby");
                SetRelatedEntities("lk_importlogbase_modifiedby", null, value);
                OnPropertyChanged("lk_importlogbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_importmap_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_importmap_createdonbehalfby")]
        public IEnumerable<ImportMap> lk_importmap_createdonbehalfby
        {
            get { return GetRelatedEntities<ImportMap>("lk_importmap_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_importmap_createdonbehalfby");
                SetRelatedEntities("lk_importmap_createdonbehalfby", null, value);
                OnPropertyChanged("lk_importmap_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_importmap_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_importmap_modifiedonbehalfby")]
        public IEnumerable<ImportMap> lk_importmap_modifiedonbehalfby
        {
            get { return GetRelatedEntities<ImportMap>("lk_importmap_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_importmap_modifiedonbehalfby");
                SetRelatedEntities("lk_importmap_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_importmap_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_importmapbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_importmapbase_createdby")]
        public IEnumerable<ImportMap> lk_importmapbase_createdby
        {
            get { return GetRelatedEntities<ImportMap>("lk_importmapbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_importmapbase_createdby");
                SetRelatedEntities("lk_importmapbase_createdby", null, value);
                OnPropertyChanged("lk_importmapbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_importmapbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_importmapbase_modifiedby")]
        public IEnumerable<ImportMap> lk_importmapbase_modifiedby
        {
            get { return GetRelatedEntities<ImportMap>("lk_importmapbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_importmapbase_modifiedby");
                SetRelatedEntities("lk_importmapbase_modifiedby", null, value);
                OnPropertyChanged("lk_importmapbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_incidentbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_incidentbase_createdby")]
        public IEnumerable<Incident> lk_incidentbase_createdby
        {
            get { return GetRelatedEntities<Incident>("lk_incidentbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_incidentbase_createdby");
                SetRelatedEntities("lk_incidentbase_createdby", null, value);
                OnPropertyChanged("lk_incidentbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_incidentbase_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_incidentbase_createdonbehalfby")]
        public IEnumerable<Incident> lk_incidentbase_createdonbehalfby
        {
            get { return GetRelatedEntities<Incident>("lk_incidentbase_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_incidentbase_createdonbehalfby");
                SetRelatedEntities("lk_incidentbase_createdonbehalfby", null, value);
                OnPropertyChanged("lk_incidentbase_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_incidentbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_incidentbase_modifiedby")]
        public IEnumerable<Incident> lk_incidentbase_modifiedby
        {
            get { return GetRelatedEntities<Incident>("lk_incidentbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_incidentbase_modifiedby");
                SetRelatedEntities("lk_incidentbase_modifiedby", null, value);
                OnPropertyChanged("lk_incidentbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_incidentbase_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_incidentbase_modifiedonbehalfby")]
        public IEnumerable<Incident> lk_incidentbase_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Incident>("lk_incidentbase_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_incidentbase_modifiedonbehalfby");
                SetRelatedEntities("lk_incidentbase_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_incidentbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_incidentresolution_createdby
        /// </summary>
        [RelationshipSchemaName("lk_incidentresolution_createdby")]
        public IEnumerable<IncidentResolution> lk_incidentresolution_createdby
        {
            get { return GetRelatedEntities<IncidentResolution>("lk_incidentresolution_createdby", null); }
            set
            {
                OnPropertyChanging("lk_incidentresolution_createdby");
                SetRelatedEntities("lk_incidentresolution_createdby", null, value);
                OnPropertyChanged("lk_incidentresolution_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_incidentresolution_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_incidentresolution_createdonbehalfby")]
        public IEnumerable<IncidentResolution> lk_incidentresolution_createdonbehalfby
        {
            get { return GetRelatedEntities<IncidentResolution>("lk_incidentresolution_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_incidentresolution_createdonbehalfby");
                SetRelatedEntities("lk_incidentresolution_createdonbehalfby", null, value);
                OnPropertyChanged("lk_incidentresolution_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_incidentresolution_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_incidentresolution_modifiedby")]
        public IEnumerable<IncidentResolution> lk_incidentresolution_modifiedby
        {
            get { return GetRelatedEntities<IncidentResolution>("lk_incidentresolution_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_incidentresolution_modifiedby");
                SetRelatedEntities("lk_incidentresolution_modifiedby", null, value);
                OnPropertyChanged("lk_incidentresolution_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_incidentresolution_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_incidentresolution_modifiedonbehalfby")]
        public IEnumerable<IncidentResolution> lk_incidentresolution_modifiedonbehalfby
        {
            get { return GetRelatedEntities<IncidentResolution>("lk_incidentresolution_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_incidentresolution_modifiedonbehalfby");
                SetRelatedEntities("lk_incidentresolution_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_incidentresolution_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_invoice_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_invoice_createdonbehalfby")]
        public IEnumerable<Invoice> lk_invoice_createdonbehalfby
        {
            get { return GetRelatedEntities<Invoice>("lk_invoice_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_invoice_createdonbehalfby");
                SetRelatedEntities("lk_invoice_createdonbehalfby", null, value);
                OnPropertyChanged("lk_invoice_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_invoice_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_invoice_modifiedonbehalfby")]
        public IEnumerable<Invoice> lk_invoice_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Invoice>("lk_invoice_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_invoice_modifiedonbehalfby");
                SetRelatedEntities("lk_invoice_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_invoice_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_invoicebase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_invoicebase_createdby")]
        public IEnumerable<Invoice> lk_invoicebase_createdby
        {
            get { return GetRelatedEntities<Invoice>("lk_invoicebase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_invoicebase_createdby");
                SetRelatedEntities("lk_invoicebase_createdby", null, value);
                OnPropertyChanged("lk_invoicebase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_invoicebase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_invoicebase_modifiedby")]
        public IEnumerable<Invoice> lk_invoicebase_modifiedby
        {
            get { return GetRelatedEntities<Invoice>("lk_invoicebase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_invoicebase_modifiedby");
                SetRelatedEntities("lk_invoicebase_modifiedby", null, value);
                OnPropertyChanged("lk_invoicebase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_invoicedetail_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_invoicedetail_createdonbehalfby")]
        public IEnumerable<InvoiceDetail> lk_invoicedetail_createdonbehalfby
        {
            get { return GetRelatedEntities<InvoiceDetail>("lk_invoicedetail_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_invoicedetail_createdonbehalfby");
                SetRelatedEntities("lk_invoicedetail_createdonbehalfby", null, value);
                OnPropertyChanged("lk_invoicedetail_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_invoicedetail_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_invoicedetail_modifiedonbehalfby")]
        public IEnumerable<InvoiceDetail> lk_invoicedetail_modifiedonbehalfby
        {
            get { return GetRelatedEntities<InvoiceDetail>("lk_invoicedetail_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_invoicedetail_modifiedonbehalfby");
                SetRelatedEntities("lk_invoicedetail_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_invoicedetail_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_invoicedetailbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_invoicedetailbase_createdby")]
        public IEnumerable<InvoiceDetail> lk_invoicedetailbase_createdby
        {
            get { return GetRelatedEntities<InvoiceDetail>("lk_invoicedetailbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_invoicedetailbase_createdby");
                SetRelatedEntities("lk_invoicedetailbase_createdby", null, value);
                OnPropertyChanged("lk_invoicedetailbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_invoicedetailbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_invoicedetailbase_modifiedby")]
        public IEnumerable<InvoiceDetail> lk_invoicedetailbase_modifiedby
        {
            get { return GetRelatedEntities<InvoiceDetail>("lk_invoicedetailbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_invoicedetailbase_modifiedby");
                SetRelatedEntities("lk_invoicedetailbase_modifiedby", null, value);
                OnPropertyChanged("lk_invoicedetailbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_isvconfig_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_isvconfig_createdonbehalfby")]
        public IEnumerable<IsvConfig> lk_isvconfig_createdonbehalfby
        {
            get { return GetRelatedEntities<IsvConfig>("lk_isvconfig_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_isvconfig_createdonbehalfby");
                SetRelatedEntities("lk_isvconfig_createdonbehalfby", null, value);
                OnPropertyChanged("lk_isvconfig_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_isvconfig_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_isvconfig_modifiedonbehalfby")]
        public IEnumerable<IsvConfig> lk_isvconfig_modifiedonbehalfby
        {
            get { return GetRelatedEntities<IsvConfig>("lk_isvconfig_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_isvconfig_modifiedonbehalfby");
                SetRelatedEntities("lk_isvconfig_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_isvconfig_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_isvconfigbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_isvconfigbase_createdby")]
        public IEnumerable<IsvConfig> lk_isvconfigbase_createdby
        {
            get { return GetRelatedEntities<IsvConfig>("lk_isvconfigbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_isvconfigbase_createdby");
                SetRelatedEntities("lk_isvconfigbase_createdby", null, value);
                OnPropertyChanged("lk_isvconfigbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_isvconfigbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_isvconfigbase_modifiedby")]
        public IEnumerable<IsvConfig> lk_isvconfigbase_modifiedby
        {
            get { return GetRelatedEntities<IsvConfig>("lk_isvconfigbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_isvconfigbase_modifiedby");
                SetRelatedEntities("lk_isvconfigbase_modifiedby", null, value);
                OnPropertyChanged("lk_isvconfigbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_kbarticle_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_kbarticle_createdonbehalfby")]
        public IEnumerable<KbArticle> lk_kbarticle_createdonbehalfby
        {
            get { return GetRelatedEntities<KbArticle>("lk_kbarticle_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_kbarticle_createdonbehalfby");
                SetRelatedEntities("lk_kbarticle_createdonbehalfby", null, value);
                OnPropertyChanged("lk_kbarticle_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_kbarticle_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_kbarticle_modifiedonbehalfby")]
        public IEnumerable<KbArticle> lk_kbarticle_modifiedonbehalfby
        {
            get { return GetRelatedEntities<KbArticle>("lk_kbarticle_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_kbarticle_modifiedonbehalfby");
                SetRelatedEntities("lk_kbarticle_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_kbarticle_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_kbarticlebase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_kbarticlebase_createdby")]
        public IEnumerable<KbArticle> lk_kbarticlebase_createdby
        {
            get { return GetRelatedEntities<KbArticle>("lk_kbarticlebase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_kbarticlebase_createdby");
                SetRelatedEntities("lk_kbarticlebase_createdby", null, value);
                OnPropertyChanged("lk_kbarticlebase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_kbarticlebase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_kbarticlebase_modifiedby")]
        public IEnumerable<KbArticle> lk_kbarticlebase_modifiedby
        {
            get { return GetRelatedEntities<KbArticle>("lk_kbarticlebase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_kbarticlebase_modifiedby");
                SetRelatedEntities("lk_kbarticlebase_modifiedby", null, value);
                OnPropertyChanged("lk_kbarticlebase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_kbarticlecomment_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_kbarticlecomment_createdonbehalfby")]
        public IEnumerable<KbArticleComment> lk_kbarticlecomment_createdonbehalfby
        {
            get { return GetRelatedEntities<KbArticleComment>("lk_kbarticlecomment_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_kbarticlecomment_createdonbehalfby");
                SetRelatedEntities("lk_kbarticlecomment_createdonbehalfby", null, value);
                OnPropertyChanged("lk_kbarticlecomment_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_kbarticlecomment_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_kbarticlecomment_modifiedonbehalfby")]
        public IEnumerable<KbArticleComment> lk_kbarticlecomment_modifiedonbehalfby
        {
            get { return GetRelatedEntities<KbArticleComment>("lk_kbarticlecomment_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_kbarticlecomment_modifiedonbehalfby");
                SetRelatedEntities("lk_kbarticlecomment_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_kbarticlecomment_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_kbarticlecommentbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_kbarticlecommentbase_createdby")]
        public IEnumerable<KbArticleComment> lk_kbarticlecommentbase_createdby
        {
            get { return GetRelatedEntities<KbArticleComment>("lk_kbarticlecommentbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_kbarticlecommentbase_createdby");
                SetRelatedEntities("lk_kbarticlecommentbase_createdby", null, value);
                OnPropertyChanged("lk_kbarticlecommentbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_kbarticlecommentbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_kbarticlecommentbase_modifiedby")]
        public IEnumerable<KbArticleComment> lk_kbarticlecommentbase_modifiedby
        {
            get { return GetRelatedEntities<KbArticleComment>("lk_kbarticlecommentbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_kbarticlecommentbase_modifiedby");
                SetRelatedEntities("lk_kbarticlecommentbase_modifiedby", null, value);
                OnPropertyChanged("lk_kbarticlecommentbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_kbarticletemplate_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_kbarticletemplate_createdonbehalfby")]
        public IEnumerable<KbArticleTemplate> lk_kbarticletemplate_createdonbehalfby
        {
            get { return GetRelatedEntities<KbArticleTemplate>("lk_kbarticletemplate_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_kbarticletemplate_createdonbehalfby");
                SetRelatedEntities("lk_kbarticletemplate_createdonbehalfby", null, value);
                OnPropertyChanged("lk_kbarticletemplate_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_kbarticletemplate_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_kbarticletemplate_modifiedonbehalfby")]
        public IEnumerable<KbArticleTemplate> lk_kbarticletemplate_modifiedonbehalfby
        {
            get { return GetRelatedEntities<KbArticleTemplate>("lk_kbarticletemplate_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_kbarticletemplate_modifiedonbehalfby");
                SetRelatedEntities("lk_kbarticletemplate_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_kbarticletemplate_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_kbarticletemplatebase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_kbarticletemplatebase_createdby")]
        public IEnumerable<KbArticleTemplate> lk_kbarticletemplatebase_createdby
        {
            get { return GetRelatedEntities<KbArticleTemplate>("lk_kbarticletemplatebase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_kbarticletemplatebase_createdby");
                SetRelatedEntities("lk_kbarticletemplatebase_createdby", null, value);
                OnPropertyChanged("lk_kbarticletemplatebase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_kbarticletemplatebase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_kbarticletemplatebase_modifiedby")]
        public IEnumerable<KbArticleTemplate> lk_kbarticletemplatebase_modifiedby
        {
            get { return GetRelatedEntities<KbArticleTemplate>("lk_kbarticletemplatebase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_kbarticletemplatebase_modifiedby");
                SetRelatedEntities("lk_kbarticletemplatebase_modifiedby", null, value);
                OnPropertyChanged("lk_kbarticletemplatebase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_lead_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_lead_createdonbehalfby")]
        public IEnumerable<Lead> lk_lead_createdonbehalfby
        {
            get { return GetRelatedEntities<Lead>("lk_lead_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_lead_createdonbehalfby");
                SetRelatedEntities("lk_lead_createdonbehalfby", null, value);
                OnPropertyChanged("lk_lead_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_lead_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_lead_modifiedonbehalfby")]
        public IEnumerable<Lead> lk_lead_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Lead>("lk_lead_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_lead_modifiedonbehalfby");
                SetRelatedEntities("lk_lead_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_lead_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_leadaddress_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_leadaddress_createdonbehalfby")]
        public IEnumerable<LeadAddress> lk_leadaddress_createdonbehalfby
        {
            get { return GetRelatedEntities<LeadAddress>("lk_leadaddress_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_leadaddress_createdonbehalfby");
                SetRelatedEntities("lk_leadaddress_createdonbehalfby", null, value);
                OnPropertyChanged("lk_leadaddress_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_leadaddress_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_leadaddress_modifiedonbehalfby")]
        public IEnumerable<LeadAddress> lk_leadaddress_modifiedonbehalfby
        {
            get { return GetRelatedEntities<LeadAddress>("lk_leadaddress_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_leadaddress_modifiedonbehalfby");
                SetRelatedEntities("lk_leadaddress_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_leadaddress_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_leadaddressbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_leadaddressbase_createdby")]
        public IEnumerable<LeadAddress> lk_leadaddressbase_createdby
        {
            get { return GetRelatedEntities<LeadAddress>("lk_leadaddressbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_leadaddressbase_createdby");
                SetRelatedEntities("lk_leadaddressbase_createdby", null, value);
                OnPropertyChanged("lk_leadaddressbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_leadaddressbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_leadaddressbase_modifiedby")]
        public IEnumerable<LeadAddress> lk_leadaddressbase_modifiedby
        {
            get { return GetRelatedEntities<LeadAddress>("lk_leadaddressbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_leadaddressbase_modifiedby");
                SetRelatedEntities("lk_leadaddressbase_modifiedby", null, value);
                OnPropertyChanged("lk_leadaddressbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_leadbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_leadbase_createdby")]
        public IEnumerable<Lead> lk_leadbase_createdby
        {
            get { return GetRelatedEntities<Lead>("lk_leadbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_leadbase_createdby");
                SetRelatedEntities("lk_leadbase_createdby", null, value);
                OnPropertyChanged("lk_leadbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_leadbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_leadbase_modifiedby")]
        public IEnumerable<Lead> lk_leadbase_modifiedby
        {
            get { return GetRelatedEntities<Lead>("lk_leadbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_leadbase_modifiedby");
                SetRelatedEntities("lk_leadbase_modifiedby", null, value);
                OnPropertyChanged("lk_leadbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_letter_createdby
        /// </summary>
        [RelationshipSchemaName("lk_letter_createdby")]
        public IEnumerable<Letter> lk_letter_createdby
        {
            get { return GetRelatedEntities<Letter>("lk_letter_createdby", null); }
            set
            {
                OnPropertyChanging("lk_letter_createdby");
                SetRelatedEntities("lk_letter_createdby", null, value);
                OnPropertyChanged("lk_letter_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_letter_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_letter_createdonbehalfby")]
        public IEnumerable<Letter> lk_letter_createdonbehalfby
        {
            get { return GetRelatedEntities<Letter>("lk_letter_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_letter_createdonbehalfby");
                SetRelatedEntities("lk_letter_createdonbehalfby", null, value);
                OnPropertyChanged("lk_letter_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_letter_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_letter_modifiedby")]
        public IEnumerable<Letter> lk_letter_modifiedby
        {
            get { return GetRelatedEntities<Letter>("lk_letter_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_letter_modifiedby");
                SetRelatedEntities("lk_letter_modifiedby", null, value);
                OnPropertyChanged("lk_letter_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_letter_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_letter_modifiedonbehalfby")]
        public IEnumerable<Letter> lk_letter_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Letter>("lk_letter_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_letter_modifiedonbehalfby");
                SetRelatedEntities("lk_letter_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_letter_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_list_createdby
        /// </summary>
        [RelationshipSchemaName("lk_list_createdby")]
        public IEnumerable<List> lk_list_createdby
        {
            get { return GetRelatedEntities<List>("lk_list_createdby", null); }
            set
            {
                OnPropertyChanging("lk_list_createdby");
                SetRelatedEntities("lk_list_createdby", null, value);
                OnPropertyChanged("lk_list_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_list_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_list_createdonbehalfby")]
        public IEnumerable<List> lk_list_createdonbehalfby
        {
            get { return GetRelatedEntities<List>("lk_list_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_list_createdonbehalfby");
                SetRelatedEntities("lk_list_createdonbehalfby", null, value);
                OnPropertyChanged("lk_list_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_list_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_list_modifiedby")]
        public IEnumerable<List> lk_list_modifiedby
        {
            get { return GetRelatedEntities<List>("lk_list_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_list_modifiedby");
                SetRelatedEntities("lk_list_modifiedby", null, value);
                OnPropertyChanged("lk_list_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_list_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_list_modifiedonbehalfby")]
        public IEnumerable<List> lk_list_modifiedonbehalfby
        {
            get { return GetRelatedEntities<List>("lk_list_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_list_modifiedonbehalfby");
                SetRelatedEntities("lk_list_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_list_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_listmember_createdby
        /// </summary>
        [RelationshipSchemaName("lk_listmember_createdby")]
        public IEnumerable<ListMember> lk_listmember_createdby
        {
            get { return GetRelatedEntities<ListMember>("lk_listmember_createdby", null); }
            set
            {
                OnPropertyChanging("lk_listmember_createdby");
                SetRelatedEntities("lk_listmember_createdby", null, value);
                OnPropertyChanged("lk_listmember_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_listmember_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_listmember_createdonbehalfby")]
        public IEnumerable<ListMember> lk_listmember_createdonbehalfby
        {
            get { return GetRelatedEntities<ListMember>("lk_listmember_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_listmember_createdonbehalfby");
                SetRelatedEntities("lk_listmember_createdonbehalfby", null, value);
                OnPropertyChanged("lk_listmember_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_listmember_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_listmember_modifiedby")]
        public IEnumerable<ListMember> lk_listmember_modifiedby
        {
            get { return GetRelatedEntities<ListMember>("lk_listmember_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_listmember_modifiedby");
                SetRelatedEntities("lk_listmember_modifiedby", null, value);
                OnPropertyChanged("lk_listmember_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_listmember_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_listmember_modifiedonbehalfby")]
        public IEnumerable<ListMember> lk_listmember_modifiedonbehalfby
        {
            get { return GetRelatedEntities<ListMember>("lk_listmember_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_listmember_modifiedonbehalfby");
                SetRelatedEntities("lk_listmember_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_listmember_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_lookupmapping_createdby
        /// </summary>
        [RelationshipSchemaName("lk_lookupmapping_createdby")]
        public IEnumerable<LookUpMapping> lk_lookupmapping_createdby
        {
            get { return GetRelatedEntities<LookUpMapping>("lk_lookupmapping_createdby", null); }
            set
            {
                OnPropertyChanging("lk_lookupmapping_createdby");
                SetRelatedEntities("lk_lookupmapping_createdby", null, value);
                OnPropertyChanged("lk_lookupmapping_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_lookupmapping_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_lookupmapping_createdonbehalfby")]
        public IEnumerable<LookUpMapping> lk_lookupmapping_createdonbehalfby
        {
            get { return GetRelatedEntities<LookUpMapping>("lk_lookupmapping_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_lookupmapping_createdonbehalfby");
                SetRelatedEntities("lk_lookupmapping_createdonbehalfby", null, value);
                OnPropertyChanged("lk_lookupmapping_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_lookupmapping_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_lookupmapping_modifiedby")]
        public IEnumerable<LookUpMapping> lk_lookupmapping_modifiedby
        {
            get { return GetRelatedEntities<LookUpMapping>("lk_lookupmapping_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_lookupmapping_modifiedby");
                SetRelatedEntities("lk_lookupmapping_modifiedby", null, value);
                OnPropertyChanged("lk_lookupmapping_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_lookupmapping_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_lookupmapping_modifiedonbehalfby")]
        public IEnumerable<LookUpMapping> lk_lookupmapping_modifiedonbehalfby
        {
            get { return GetRelatedEntities<LookUpMapping>("lk_lookupmapping_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_lookupmapping_modifiedonbehalfby");
                SetRelatedEntities("lk_lookupmapping_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_lookupmapping_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_mailbox_createdby
        /// </summary>
        [RelationshipSchemaName("lk_mailbox_createdby")]
        public IEnumerable<Mailbox> lk_mailbox_createdby
        {
            get { return GetRelatedEntities<Mailbox>("lk_mailbox_createdby", null); }
            set
            {
                OnPropertyChanging("lk_mailbox_createdby");
                SetRelatedEntities("lk_mailbox_createdby", null, value);
                OnPropertyChanged("lk_mailbox_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_mailbox_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_mailbox_createdonbehalfby")]
        public IEnumerable<Mailbox> lk_mailbox_createdonbehalfby
        {
            get { return GetRelatedEntities<Mailbox>("lk_mailbox_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_mailbox_createdonbehalfby");
                SetRelatedEntities("lk_mailbox_createdonbehalfby", null, value);
                OnPropertyChanged("lk_mailbox_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_mailbox_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_mailbox_modifiedby")]
        public IEnumerable<Mailbox> lk_mailbox_modifiedby
        {
            get { return GetRelatedEntities<Mailbox>("lk_mailbox_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_mailbox_modifiedby");
                SetRelatedEntities("lk_mailbox_modifiedby", null, value);
                OnPropertyChanged("lk_mailbox_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_mailbox_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_mailbox_modifiedonbehalfby")]
        public IEnumerable<Mailbox> lk_mailbox_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Mailbox>("lk_mailbox_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_mailbox_modifiedonbehalfby");
                SetRelatedEntities("lk_mailbox_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_mailbox_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_mailmergetemplate_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_mailmergetemplate_createdonbehalfby")]
        public IEnumerable<MailMergeTemplate> lk_mailmergetemplate_createdonbehalfby
        {
            get { return GetRelatedEntities<MailMergeTemplate>("lk_mailmergetemplate_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_mailmergetemplate_createdonbehalfby");
                SetRelatedEntities("lk_mailmergetemplate_createdonbehalfby", null, value);
                OnPropertyChanged("lk_mailmergetemplate_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_mailmergetemplate_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_mailmergetemplate_modifiedonbehalfby")]
        public IEnumerable<MailMergeTemplate> lk_mailmergetemplate_modifiedonbehalfby
        {
            get { return GetRelatedEntities<MailMergeTemplate>("lk_mailmergetemplate_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_mailmergetemplate_modifiedonbehalfby");
                SetRelatedEntities("lk_mailmergetemplate_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_mailmergetemplate_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_mailmergetemplatebase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_mailmergetemplatebase_createdby")]
        public IEnumerable<MailMergeTemplate> lk_mailmergetemplatebase_createdby
        {
            get { return GetRelatedEntities<MailMergeTemplate>("lk_mailmergetemplatebase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_mailmergetemplatebase_createdby");
                SetRelatedEntities("lk_mailmergetemplatebase_createdby", null, value);
                OnPropertyChanged("lk_mailmergetemplatebase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_mailmergetemplatebase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_mailmergetemplatebase_modifiedby")]
        public IEnumerable<MailMergeTemplate> lk_mailmergetemplatebase_modifiedby
        {
            get { return GetRelatedEntities<MailMergeTemplate>("lk_mailmergetemplatebase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_mailmergetemplatebase_modifiedby");
                SetRelatedEntities("lk_mailmergetemplatebase_modifiedby", null, value);
                OnPropertyChanged("lk_mailmergetemplatebase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_metric_createdby
        /// </summary>
        [RelationshipSchemaName("lk_metric_createdby")]
        public IEnumerable<Metric> lk_metric_createdby
        {
            get { return GetRelatedEntities<Metric>("lk_metric_createdby", null); }
            set
            {
                OnPropertyChanging("lk_metric_createdby");
                SetRelatedEntities("lk_metric_createdby", null, value);
                OnPropertyChanged("lk_metric_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_metric_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_metric_createdonbehalfby")]
        public IEnumerable<Metric> lk_metric_createdonbehalfby
        {
            get { return GetRelatedEntities<Metric>("lk_metric_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_metric_createdonbehalfby");
                SetRelatedEntities("lk_metric_createdonbehalfby", null, value);
                OnPropertyChanged("lk_metric_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_metric_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_metric_modifiedby")]
        public IEnumerable<Metric> lk_metric_modifiedby
        {
            get { return GetRelatedEntities<Metric>("lk_metric_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_metric_modifiedby");
                SetRelatedEntities("lk_metric_modifiedby", null, value);
                OnPropertyChanged("lk_metric_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_metric_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_metric_modifiedonbehalfby")]
        public IEnumerable<Metric> lk_metric_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Metric>("lk_metric_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_metric_modifiedonbehalfby");
                SetRelatedEntities("lk_metric_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_metric_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_monthlyfiscalcalendar_createdby
        /// </summary>
        [RelationshipSchemaName("lk_monthlyfiscalcalendar_createdby")]
        public IEnumerable<MonthlyFiscalCalendar> lk_monthlyfiscalcalendar_createdby
        {
            get { return GetRelatedEntities<MonthlyFiscalCalendar>("lk_monthlyfiscalcalendar_createdby", null); }
            set
            {
                OnPropertyChanging("lk_monthlyfiscalcalendar_createdby");
                SetRelatedEntities("lk_monthlyfiscalcalendar_createdby", null, value);
                OnPropertyChanged("lk_monthlyfiscalcalendar_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_monthlyfiscalcalendar_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_monthlyfiscalcalendar_createdonbehalfby")]
        public IEnumerable<MonthlyFiscalCalendar> lk_monthlyfiscalcalendar_createdonbehalfby
        {
            get
            {
                return GetRelatedEntities<MonthlyFiscalCalendar>("lk_monthlyfiscalcalendar_createdonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_monthlyfiscalcalendar_createdonbehalfby");
                SetRelatedEntities("lk_monthlyfiscalcalendar_createdonbehalfby", null, value);
                OnPropertyChanged("lk_monthlyfiscalcalendar_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_monthlyfiscalcalendar_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_monthlyfiscalcalendar_modifiedby")]
        public IEnumerable<MonthlyFiscalCalendar> lk_monthlyfiscalcalendar_modifiedby
        {
            get { return GetRelatedEntities<MonthlyFiscalCalendar>("lk_monthlyfiscalcalendar_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_monthlyfiscalcalendar_modifiedby");
                SetRelatedEntities("lk_monthlyfiscalcalendar_modifiedby", null, value);
                OnPropertyChanged("lk_monthlyfiscalcalendar_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_monthlyfiscalcalendar_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_monthlyfiscalcalendar_modifiedonbehalfby")]
        public IEnumerable<MonthlyFiscalCalendar> lk_monthlyfiscalcalendar_modifiedonbehalfby
        {
            get
            {
                return GetRelatedEntities<MonthlyFiscalCalendar>("lk_monthlyfiscalcalendar_modifiedonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_monthlyfiscalcalendar_modifiedonbehalfby");
                SetRelatedEntities("lk_monthlyfiscalcalendar_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_monthlyfiscalcalendar_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_monthlyfiscalcalendar_salespersonid
        /// </summary>
        [RelationshipSchemaName("lk_monthlyfiscalcalendar_salespersonid")]
        public IEnumerable<MonthlyFiscalCalendar> lk_monthlyfiscalcalendar_salespersonid
        {
            get { return GetRelatedEntities<MonthlyFiscalCalendar>("lk_monthlyfiscalcalendar_salespersonid", null); }
            set
            {
                OnPropertyChanging("lk_monthlyfiscalcalendar_salespersonid");
                SetRelatedEntities("lk_monthlyfiscalcalendar_salespersonid", null, value);
                OnPropertyChanged("lk_monthlyfiscalcalendar_salespersonid");
            }
        }

        /// <summary>
        ///     1:N lk_msdyn_postalbum_createdby
        /// </summary>
        [RelationshipSchemaName("lk_msdyn_postalbum_createdby")]
        public IEnumerable<msdyn_PostAlbum> lk_msdyn_postalbum_createdby
        {
            get { return GetRelatedEntities<msdyn_PostAlbum>("lk_msdyn_postalbum_createdby", null); }
            set
            {
                OnPropertyChanging("lk_msdyn_postalbum_createdby");
                SetRelatedEntities("lk_msdyn_postalbum_createdby", null, value);
                OnPropertyChanged("lk_msdyn_postalbum_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_msdyn_postalbum_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_msdyn_postalbum_createdonbehalfby")]
        public IEnumerable<msdyn_PostAlbum> lk_msdyn_postalbum_createdonbehalfby
        {
            get { return GetRelatedEntities<msdyn_PostAlbum>("lk_msdyn_postalbum_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_msdyn_postalbum_createdonbehalfby");
                SetRelatedEntities("lk_msdyn_postalbum_createdonbehalfby", null, value);
                OnPropertyChanged("lk_msdyn_postalbum_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_msdyn_postalbum_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_msdyn_postalbum_modifiedby")]
        public IEnumerable<msdyn_PostAlbum> lk_msdyn_postalbum_modifiedby
        {
            get { return GetRelatedEntities<msdyn_PostAlbum>("lk_msdyn_postalbum_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_msdyn_postalbum_modifiedby");
                SetRelatedEntities("lk_msdyn_postalbum_modifiedby", null, value);
                OnPropertyChanged("lk_msdyn_postalbum_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_msdyn_postalbum_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_msdyn_postalbum_modifiedonbehalfby")]
        public IEnumerable<msdyn_PostAlbum> lk_msdyn_postalbum_modifiedonbehalfby
        {
            get { return GetRelatedEntities<msdyn_PostAlbum>("lk_msdyn_postalbum_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_msdyn_postalbum_modifiedonbehalfby");
                SetRelatedEntities("lk_msdyn_postalbum_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_msdyn_postalbum_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_msdyn_postconfig_createdby
        /// </summary>
        [RelationshipSchemaName("lk_msdyn_postconfig_createdby")]
        public IEnumerable<msdyn_PostConfig> lk_msdyn_postconfig_createdby
        {
            get { return GetRelatedEntities<msdyn_PostConfig>("lk_msdyn_postconfig_createdby", null); }
            set
            {
                OnPropertyChanging("lk_msdyn_postconfig_createdby");
                SetRelatedEntities("lk_msdyn_postconfig_createdby", null, value);
                OnPropertyChanged("lk_msdyn_postconfig_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_msdyn_postconfig_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_msdyn_postconfig_createdonbehalfby")]
        public IEnumerable<msdyn_PostConfig> lk_msdyn_postconfig_createdonbehalfby
        {
            get { return GetRelatedEntities<msdyn_PostConfig>("lk_msdyn_postconfig_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_msdyn_postconfig_createdonbehalfby");
                SetRelatedEntities("lk_msdyn_postconfig_createdonbehalfby", null, value);
                OnPropertyChanged("lk_msdyn_postconfig_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_msdyn_postconfig_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_msdyn_postconfig_modifiedby")]
        public IEnumerable<msdyn_PostConfig> lk_msdyn_postconfig_modifiedby
        {
            get { return GetRelatedEntities<msdyn_PostConfig>("lk_msdyn_postconfig_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_msdyn_postconfig_modifiedby");
                SetRelatedEntities("lk_msdyn_postconfig_modifiedby", null, value);
                OnPropertyChanged("lk_msdyn_postconfig_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_msdyn_postconfig_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_msdyn_postconfig_modifiedonbehalfby")]
        public IEnumerable<msdyn_PostConfig> lk_msdyn_postconfig_modifiedonbehalfby
        {
            get { return GetRelatedEntities<msdyn_PostConfig>("lk_msdyn_postconfig_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_msdyn_postconfig_modifiedonbehalfby");
                SetRelatedEntities("lk_msdyn_postconfig_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_msdyn_postconfig_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_msdyn_postruleconfig_createdby
        /// </summary>
        [RelationshipSchemaName("lk_msdyn_postruleconfig_createdby")]
        public IEnumerable<msdyn_PostRuleConfig> lk_msdyn_postruleconfig_createdby
        {
            get { return GetRelatedEntities<msdyn_PostRuleConfig>("lk_msdyn_postruleconfig_createdby", null); }
            set
            {
                OnPropertyChanging("lk_msdyn_postruleconfig_createdby");
                SetRelatedEntities("lk_msdyn_postruleconfig_createdby", null, value);
                OnPropertyChanged("lk_msdyn_postruleconfig_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_msdyn_postruleconfig_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_msdyn_postruleconfig_createdonbehalfby")]
        public IEnumerable<msdyn_PostRuleConfig> lk_msdyn_postruleconfig_createdonbehalfby
        {
            get { return GetRelatedEntities<msdyn_PostRuleConfig>("lk_msdyn_postruleconfig_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_msdyn_postruleconfig_createdonbehalfby");
                SetRelatedEntities("lk_msdyn_postruleconfig_createdonbehalfby", null, value);
                OnPropertyChanged("lk_msdyn_postruleconfig_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_msdyn_postruleconfig_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_msdyn_postruleconfig_modifiedby")]
        public IEnumerable<msdyn_PostRuleConfig> lk_msdyn_postruleconfig_modifiedby
        {
            get { return GetRelatedEntities<msdyn_PostRuleConfig>("lk_msdyn_postruleconfig_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_msdyn_postruleconfig_modifiedby");
                SetRelatedEntities("lk_msdyn_postruleconfig_modifiedby", null, value);
                OnPropertyChanged("lk_msdyn_postruleconfig_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_msdyn_postruleconfig_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_msdyn_postruleconfig_modifiedonbehalfby")]
        public IEnumerable<msdyn_PostRuleConfig> lk_msdyn_postruleconfig_modifiedonbehalfby
        {
            get { return GetRelatedEntities<msdyn_PostRuleConfig>("lk_msdyn_postruleconfig_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_msdyn_postruleconfig_modifiedonbehalfby");
                SetRelatedEntities("lk_msdyn_postruleconfig_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_msdyn_postruleconfig_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_msdyn_wallsavedquery_createdby
        /// </summary>
        [RelationshipSchemaName("lk_msdyn_wallsavedquery_createdby")]
        public IEnumerable<msdyn_wallsavedquery> lk_msdyn_wallsavedquery_createdby
        {
            get { return GetRelatedEntities<msdyn_wallsavedquery>("lk_msdyn_wallsavedquery_createdby", null); }
            set
            {
                OnPropertyChanging("lk_msdyn_wallsavedquery_createdby");
                SetRelatedEntities("lk_msdyn_wallsavedquery_createdby", null, value);
                OnPropertyChanged("lk_msdyn_wallsavedquery_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_msdyn_wallsavedquery_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_msdyn_wallsavedquery_createdonbehalfby")]
        public IEnumerable<msdyn_wallsavedquery> lk_msdyn_wallsavedquery_createdonbehalfby
        {
            get { return GetRelatedEntities<msdyn_wallsavedquery>("lk_msdyn_wallsavedquery_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_msdyn_wallsavedquery_createdonbehalfby");
                SetRelatedEntities("lk_msdyn_wallsavedquery_createdonbehalfby", null, value);
                OnPropertyChanged("lk_msdyn_wallsavedquery_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_msdyn_wallsavedquery_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_msdyn_wallsavedquery_modifiedby")]
        public IEnumerable<msdyn_wallsavedquery> lk_msdyn_wallsavedquery_modifiedby
        {
            get { return GetRelatedEntities<msdyn_wallsavedquery>("lk_msdyn_wallsavedquery_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_msdyn_wallsavedquery_modifiedby");
                SetRelatedEntities("lk_msdyn_wallsavedquery_modifiedby", null, value);
                OnPropertyChanged("lk_msdyn_wallsavedquery_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_msdyn_wallsavedquery_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_msdyn_wallsavedquery_modifiedonbehalfby")]
        public IEnumerable<msdyn_wallsavedquery> lk_msdyn_wallsavedquery_modifiedonbehalfby
        {
            get { return GetRelatedEntities<msdyn_wallsavedquery>("lk_msdyn_wallsavedquery_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_msdyn_wallsavedquery_modifiedonbehalfby");
                SetRelatedEntities("lk_msdyn_wallsavedquery_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_msdyn_wallsavedquery_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_msdyn_wallsavedqueryusersettings_createdby
        /// </summary>
        [RelationshipSchemaName("lk_msdyn_wallsavedqueryusersettings_createdby")]
        public IEnumerable<msdyn_wallsavedqueryusersettings> lk_msdyn_wallsavedqueryusersettings_createdby
        {
            get
            {
                return
                    GetRelatedEntities<msdyn_wallsavedqueryusersettings>(
                        "lk_msdyn_wallsavedqueryusersettings_createdby", null);
            }
            set
            {
                OnPropertyChanging("lk_msdyn_wallsavedqueryusersettings_createdby");
                SetRelatedEntities("lk_msdyn_wallsavedqueryusersettings_createdby", null, value);
                OnPropertyChanged("lk_msdyn_wallsavedqueryusersettings_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_msdyn_wallsavedqueryusersettings_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_msdyn_wallsavedqueryusersettings_createdonbehalfby")]
        public IEnumerable<msdyn_wallsavedqueryusersettings> lk_msdyn_wallsavedqueryusersettings_createdonbehalfby
        {
            get
            {
                return
                    GetRelatedEntities<msdyn_wallsavedqueryusersettings>(
                        "lk_msdyn_wallsavedqueryusersettings_createdonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_msdyn_wallsavedqueryusersettings_createdonbehalfby");
                SetRelatedEntities("lk_msdyn_wallsavedqueryusersettings_createdonbehalfby", null, value);
                OnPropertyChanged("lk_msdyn_wallsavedqueryusersettings_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_msdyn_wallsavedqueryusersettings_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_msdyn_wallsavedqueryusersettings_modifiedby")]
        public IEnumerable<msdyn_wallsavedqueryusersettings> lk_msdyn_wallsavedqueryusersettings_modifiedby
        {
            get
            {
                return
                    GetRelatedEntities<msdyn_wallsavedqueryusersettings>(
                        "lk_msdyn_wallsavedqueryusersettings_modifiedby", null);
            }
            set
            {
                OnPropertyChanging("lk_msdyn_wallsavedqueryusersettings_modifiedby");
                SetRelatedEntities("lk_msdyn_wallsavedqueryusersettings_modifiedby", null, value);
                OnPropertyChanged("lk_msdyn_wallsavedqueryusersettings_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby")]
        public IEnumerable<msdyn_wallsavedqueryusersettings> lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby
        {
            get
            {
                return
                    GetRelatedEntities<msdyn_wallsavedqueryusersettings>(
                        "lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby");
                SetRelatedEntities("lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_opportunity_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_opportunity_createdonbehalfby")]
        public IEnumerable<Opportunity> lk_opportunity_createdonbehalfby
        {
            get { return GetRelatedEntities<Opportunity>("lk_opportunity_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_opportunity_createdonbehalfby");
                SetRelatedEntities("lk_opportunity_createdonbehalfby", null, value);
                OnPropertyChanged("lk_opportunity_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_opportunity_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_opportunity_modifiedonbehalfby")]
        public IEnumerable<Opportunity> lk_opportunity_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Opportunity>("lk_opportunity_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_opportunity_modifiedonbehalfby");
                SetRelatedEntities("lk_opportunity_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_opportunity_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_opportunitybase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_opportunitybase_createdby")]
        public IEnumerable<Opportunity> lk_opportunitybase_createdby
        {
            get { return GetRelatedEntities<Opportunity>("lk_opportunitybase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_opportunitybase_createdby");
                SetRelatedEntities("lk_opportunitybase_createdby", null, value);
                OnPropertyChanged("lk_opportunitybase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_opportunitybase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_opportunitybase_modifiedby")]
        public IEnumerable<Opportunity> lk_opportunitybase_modifiedby
        {
            get { return GetRelatedEntities<Opportunity>("lk_opportunitybase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_opportunitybase_modifiedby");
                SetRelatedEntities("lk_opportunitybase_modifiedby", null, value);
                OnPropertyChanged("lk_opportunitybase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_opportunityclose_createdby
        /// </summary>
        [RelationshipSchemaName("lk_opportunityclose_createdby")]
        public IEnumerable<OpportunityClose> lk_opportunityclose_createdby
        {
            get { return GetRelatedEntities<OpportunityClose>("lk_opportunityclose_createdby", null); }
            set
            {
                OnPropertyChanging("lk_opportunityclose_createdby");
                SetRelatedEntities("lk_opportunityclose_createdby", null, value);
                OnPropertyChanged("lk_opportunityclose_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_opportunityclose_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_opportunityclose_createdonbehalfby")]
        public IEnumerable<OpportunityClose> lk_opportunityclose_createdonbehalfby
        {
            get { return GetRelatedEntities<OpportunityClose>("lk_opportunityclose_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_opportunityclose_createdonbehalfby");
                SetRelatedEntities("lk_opportunityclose_createdonbehalfby", null, value);
                OnPropertyChanged("lk_opportunityclose_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_opportunityclose_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_opportunityclose_modifiedby")]
        public IEnumerable<OpportunityClose> lk_opportunityclose_modifiedby
        {
            get { return GetRelatedEntities<OpportunityClose>("lk_opportunityclose_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_opportunityclose_modifiedby");
                SetRelatedEntities("lk_opportunityclose_modifiedby", null, value);
                OnPropertyChanged("lk_opportunityclose_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_opportunityclose_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_opportunityclose_modifiedonbehalfby")]
        public IEnumerable<OpportunityClose> lk_opportunityclose_modifiedonbehalfby
        {
            get { return GetRelatedEntities<OpportunityClose>("lk_opportunityclose_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_opportunityclose_modifiedonbehalfby");
                SetRelatedEntities("lk_opportunityclose_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_opportunityclose_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_opportunityproduct_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_opportunityproduct_createdonbehalfby")]
        public IEnumerable<OpportunityProduct> lk_opportunityproduct_createdonbehalfby
        {
            get { return GetRelatedEntities<OpportunityProduct>("lk_opportunityproduct_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_opportunityproduct_createdonbehalfby");
                SetRelatedEntities("lk_opportunityproduct_createdonbehalfby", null, value);
                OnPropertyChanged("lk_opportunityproduct_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_opportunityproduct_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_opportunityproduct_modifiedonbehalfby")]
        public IEnumerable<OpportunityProduct> lk_opportunityproduct_modifiedonbehalfby
        {
            get { return GetRelatedEntities<OpportunityProduct>("lk_opportunityproduct_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_opportunityproduct_modifiedonbehalfby");
                SetRelatedEntities("lk_opportunityproduct_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_opportunityproduct_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_opportunityproductbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_opportunityproductbase_createdby")]
        public IEnumerable<OpportunityProduct> lk_opportunityproductbase_createdby
        {
            get { return GetRelatedEntities<OpportunityProduct>("lk_opportunityproductbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_opportunityproductbase_createdby");
                SetRelatedEntities("lk_opportunityproductbase_createdby", null, value);
                OnPropertyChanged("lk_opportunityproductbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_opportunityproductbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_opportunityproductbase_modifiedby")]
        public IEnumerable<OpportunityProduct> lk_opportunityproductbase_modifiedby
        {
            get { return GetRelatedEntities<OpportunityProduct>("lk_opportunityproductbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_opportunityproductbase_modifiedby");
                SetRelatedEntities("lk_opportunityproductbase_modifiedby", null, value);
                OnPropertyChanged("lk_opportunityproductbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_orderclose_createdby
        /// </summary>
        [RelationshipSchemaName("lk_orderclose_createdby")]
        public IEnumerable<OrderClose> lk_orderclose_createdby
        {
            get { return GetRelatedEntities<OrderClose>("lk_orderclose_createdby", null); }
            set
            {
                OnPropertyChanging("lk_orderclose_createdby");
                SetRelatedEntities("lk_orderclose_createdby", null, value);
                OnPropertyChanged("lk_orderclose_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_orderclose_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_orderclose_createdonbehalfby")]
        public IEnumerable<OrderClose> lk_orderclose_createdonbehalfby
        {
            get { return GetRelatedEntities<OrderClose>("lk_orderclose_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_orderclose_createdonbehalfby");
                SetRelatedEntities("lk_orderclose_createdonbehalfby", null, value);
                OnPropertyChanged("lk_orderclose_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_orderclose_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_orderclose_modifiedby")]
        public IEnumerable<OrderClose> lk_orderclose_modifiedby
        {
            get { return GetRelatedEntities<OrderClose>("lk_orderclose_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_orderclose_modifiedby");
                SetRelatedEntities("lk_orderclose_modifiedby", null, value);
                OnPropertyChanged("lk_orderclose_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_orderclose_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_orderclose_modifiedonbehalfby")]
        public IEnumerable<OrderClose> lk_orderclose_modifiedonbehalfby
        {
            get { return GetRelatedEntities<OrderClose>("lk_orderclose_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_orderclose_modifiedonbehalfby");
                SetRelatedEntities("lk_orderclose_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_orderclose_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_organization_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_organization_createdonbehalfby")]
        public IEnumerable<Organization> lk_organization_createdonbehalfby
        {
            get { return GetRelatedEntities<Organization>("lk_organization_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_organization_createdonbehalfby");
                SetRelatedEntities("lk_organization_createdonbehalfby", null, value);
                OnPropertyChanged("lk_organization_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_organization_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_organization_modifiedonbehalfby")]
        public IEnumerable<Organization> lk_organization_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Organization>("lk_organization_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_organization_modifiedonbehalfby");
                SetRelatedEntities("lk_organization_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_organization_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_organizationbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_organizationbase_createdby")]
        public IEnumerable<Organization> lk_organizationbase_createdby
        {
            get { return GetRelatedEntities<Organization>("lk_organizationbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_organizationbase_createdby");
                SetRelatedEntities("lk_organizationbase_createdby", null, value);
                OnPropertyChanged("lk_organizationbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_organizationbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_organizationbase_modifiedby")]
        public IEnumerable<Organization> lk_organizationbase_modifiedby
        {
            get { return GetRelatedEntities<Organization>("lk_organizationbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_organizationbase_modifiedby");
                SetRelatedEntities("lk_organizationbase_modifiedby", null, value);
                OnPropertyChanged("lk_organizationbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_ownermapping_createdby
        /// </summary>
        [RelationshipSchemaName("lk_ownermapping_createdby")]
        public IEnumerable<OwnerMapping> lk_ownermapping_createdby
        {
            get { return GetRelatedEntities<OwnerMapping>("lk_ownermapping_createdby", null); }
            set
            {
                OnPropertyChanging("lk_ownermapping_createdby");
                SetRelatedEntities("lk_ownermapping_createdby", null, value);
                OnPropertyChanged("lk_ownermapping_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_ownermapping_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_ownermapping_createdonbehalfby")]
        public IEnumerable<OwnerMapping> lk_ownermapping_createdonbehalfby
        {
            get { return GetRelatedEntities<OwnerMapping>("lk_ownermapping_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_ownermapping_createdonbehalfby");
                SetRelatedEntities("lk_ownermapping_createdonbehalfby", null, value);
                OnPropertyChanged("lk_ownermapping_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_ownermapping_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_ownermapping_modifiedby")]
        public IEnumerable<OwnerMapping> lk_ownermapping_modifiedby
        {
            get { return GetRelatedEntities<OwnerMapping>("lk_ownermapping_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_ownermapping_modifiedby");
                SetRelatedEntities("lk_ownermapping_modifiedby", null, value);
                OnPropertyChanged("lk_ownermapping_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_ownermapping_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_ownermapping_modifiedonbehalfby")]
        public IEnumerable<OwnerMapping> lk_ownermapping_modifiedonbehalfby
        {
            get { return GetRelatedEntities<OwnerMapping>("lk_ownermapping_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_ownermapping_modifiedonbehalfby");
                SetRelatedEntities("lk_ownermapping_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_ownermapping_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_phonecall_createdby
        /// </summary>
        [RelationshipSchemaName("lk_phonecall_createdby")]
        public IEnumerable<PhoneCall> lk_phonecall_createdby
        {
            get { return GetRelatedEntities<PhoneCall>("lk_phonecall_createdby", null); }
            set
            {
                OnPropertyChanging("lk_phonecall_createdby");
                SetRelatedEntities("lk_phonecall_createdby", null, value);
                OnPropertyChanged("lk_phonecall_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_phonecall_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_phonecall_createdonbehalfby")]
        public IEnumerable<PhoneCall> lk_phonecall_createdonbehalfby
        {
            get { return GetRelatedEntities<PhoneCall>("lk_phonecall_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_phonecall_createdonbehalfby");
                SetRelatedEntities("lk_phonecall_createdonbehalfby", null, value);
                OnPropertyChanged("lk_phonecall_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_phonecall_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_phonecall_modifiedby")]
        public IEnumerable<PhoneCall> lk_phonecall_modifiedby
        {
            get { return GetRelatedEntities<PhoneCall>("lk_phonecall_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_phonecall_modifiedby");
                SetRelatedEntities("lk_phonecall_modifiedby", null, value);
                OnPropertyChanged("lk_phonecall_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_phonecall_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_phonecall_modifiedonbehalfby")]
        public IEnumerable<PhoneCall> lk_phonecall_modifiedonbehalfby
        {
            get { return GetRelatedEntities<PhoneCall>("lk_phonecall_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_phonecall_modifiedonbehalfby");
                SetRelatedEntities("lk_phonecall_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_phonecall_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_picklistmapping_createdby
        /// </summary>
        [RelationshipSchemaName("lk_picklistmapping_createdby")]
        public IEnumerable<PickListMapping> lk_picklistmapping_createdby
        {
            get { return GetRelatedEntities<PickListMapping>("lk_picklistmapping_createdby", null); }
            set
            {
                OnPropertyChanging("lk_picklistmapping_createdby");
                SetRelatedEntities("lk_picklistmapping_createdby", null, value);
                OnPropertyChanged("lk_picklistmapping_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_picklistmapping_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_picklistmapping_createdonbehalfby")]
        public IEnumerable<PickListMapping> lk_picklistmapping_createdonbehalfby
        {
            get { return GetRelatedEntities<PickListMapping>("lk_picklistmapping_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_picklistmapping_createdonbehalfby");
                SetRelatedEntities("lk_picklistmapping_createdonbehalfby", null, value);
                OnPropertyChanged("lk_picklistmapping_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_picklistmapping_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_picklistmapping_modifiedby")]
        public IEnumerable<PickListMapping> lk_picklistmapping_modifiedby
        {
            get { return GetRelatedEntities<PickListMapping>("lk_picklistmapping_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_picklistmapping_modifiedby");
                SetRelatedEntities("lk_picklistmapping_modifiedby", null, value);
                OnPropertyChanged("lk_picklistmapping_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_picklistmapping_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_picklistmapping_modifiedonbehalfby")]
        public IEnumerable<PickListMapping> lk_picklistmapping_modifiedonbehalfby
        {
            get { return GetRelatedEntities<PickListMapping>("lk_picklistmapping_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_picklistmapping_modifiedonbehalfby");
                SetRelatedEntities("lk_picklistmapping_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_picklistmapping_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_pluginassembly_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_pluginassembly_createdonbehalfby")]
        public IEnumerable<PluginAssembly> lk_pluginassembly_createdonbehalfby
        {
            get { return GetRelatedEntities<PluginAssembly>("lk_pluginassembly_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_pluginassembly_createdonbehalfby");
                SetRelatedEntities("lk_pluginassembly_createdonbehalfby", null, value);
                OnPropertyChanged("lk_pluginassembly_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_pluginassembly_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_pluginassembly_modifiedonbehalfby")]
        public IEnumerable<PluginAssembly> lk_pluginassembly_modifiedonbehalfby
        {
            get { return GetRelatedEntities<PluginAssembly>("lk_pluginassembly_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_pluginassembly_modifiedonbehalfby");
                SetRelatedEntities("lk_pluginassembly_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_pluginassembly_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_plugintype_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_plugintype_createdonbehalfby")]
        public IEnumerable<PluginType> lk_plugintype_createdonbehalfby
        {
            get { return GetRelatedEntities<PluginType>("lk_plugintype_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_plugintype_createdonbehalfby");
                SetRelatedEntities("lk_plugintype_createdonbehalfby", null, value);
                OnPropertyChanged("lk_plugintype_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_plugintype_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_plugintype_modifiedonbehalfby")]
        public IEnumerable<PluginType> lk_plugintype_modifiedonbehalfby
        {
            get { return GetRelatedEntities<PluginType>("lk_plugintype_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_plugintype_modifiedonbehalfby");
                SetRelatedEntities("lk_plugintype_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_plugintype_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_plugintypestatisticbase_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_plugintypestatisticbase_createdonbehalfby")]
        public IEnumerable<PluginTypeStatistic> lk_plugintypestatisticbase_createdonbehalfby
        {
            get
            {
                return GetRelatedEntities<PluginTypeStatistic>("lk_plugintypestatisticbase_createdonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_plugintypestatisticbase_createdonbehalfby");
                SetRelatedEntities("lk_plugintypestatisticbase_createdonbehalfby", null, value);
                OnPropertyChanged("lk_plugintypestatisticbase_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_plugintypestatisticbase_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_plugintypestatisticbase_modifiedonbehalfby")]
        public IEnumerable<PluginTypeStatistic> lk_plugintypestatisticbase_modifiedonbehalfby
        {
            get
            {
                return GetRelatedEntities<PluginTypeStatistic>("lk_plugintypestatisticbase_modifiedonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_plugintypestatisticbase_modifiedonbehalfby");
                SetRelatedEntities("lk_plugintypestatisticbase_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_plugintypestatisticbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_post_createdby
        /// </summary>
        [RelationshipSchemaName("lk_post_createdby")]
        public IEnumerable<Post> lk_post_createdby
        {
            get { return GetRelatedEntities<Post>("lk_post_createdby", null); }
            set
            {
                OnPropertyChanging("lk_post_createdby");
                SetRelatedEntities("lk_post_createdby", null, value);
                OnPropertyChanged("lk_post_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_post_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_post_createdonbehalfby")]
        public IEnumerable<Post> lk_post_createdonbehalfby
        {
            get { return GetRelatedEntities<Post>("lk_post_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_post_createdonbehalfby");
                SetRelatedEntities("lk_post_createdonbehalfby", null, value);
                OnPropertyChanged("lk_post_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_post_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_post_modifiedby")]
        public IEnumerable<Post> lk_post_modifiedby
        {
            get { return GetRelatedEntities<Post>("lk_post_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_post_modifiedby");
                SetRelatedEntities("lk_post_modifiedby", null, value);
                OnPropertyChanged("lk_post_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_post_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_post_modifiedonbehalfby")]
        public IEnumerable<Post> lk_post_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Post>("lk_post_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_post_modifiedonbehalfby");
                SetRelatedEntities("lk_post_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_post_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_postcomment_createdby
        /// </summary>
        [RelationshipSchemaName("lk_postcomment_createdby")]
        public IEnumerable<PostComment> lk_postcomment_createdby
        {
            get { return GetRelatedEntities<PostComment>("lk_postcomment_createdby", null); }
            set
            {
                OnPropertyChanging("lk_postcomment_createdby");
                SetRelatedEntities("lk_postcomment_createdby", null, value);
                OnPropertyChanged("lk_postcomment_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_postcomment_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_postcomment_createdonbehalfby")]
        public IEnumerable<PostComment> lk_postcomment_createdonbehalfby
        {
            get { return GetRelatedEntities<PostComment>("lk_postcomment_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_postcomment_createdonbehalfby");
                SetRelatedEntities("lk_postcomment_createdonbehalfby", null, value);
                OnPropertyChanged("lk_postcomment_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_PostFollow_createdby
        /// </summary>
        [RelationshipSchemaName("lk_PostFollow_createdby")]
        public IEnumerable<PostFollow> lk_PostFollow_createdby
        {
            get { return GetRelatedEntities<PostFollow>("lk_PostFollow_createdby", null); }
            set
            {
                OnPropertyChanging("lk_PostFollow_createdby");
                SetRelatedEntities("lk_PostFollow_createdby", null, value);
                OnPropertyChanged("lk_PostFollow_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_postfollow_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_postfollow_createdonbehalfby")]
        public IEnumerable<PostFollow> lk_postfollow_createdonbehalfby
        {
            get { return GetRelatedEntities<PostFollow>("lk_postfollow_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_postfollow_createdonbehalfby");
                SetRelatedEntities("lk_postfollow_createdonbehalfby", null, value);
                OnPropertyChanged("lk_postfollow_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_postlike_createdby
        /// </summary>
        [RelationshipSchemaName("lk_postlike_createdby")]
        public IEnumerable<PostLike> lk_postlike_createdby
        {
            get { return GetRelatedEntities<PostLike>("lk_postlike_createdby", null); }
            set
            {
                OnPropertyChanging("lk_postlike_createdby");
                SetRelatedEntities("lk_postlike_createdby", null, value);
                OnPropertyChanged("lk_postlike_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_postlike_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_postlike_createdonbehalfby")]
        public IEnumerable<PostLike> lk_postlike_createdonbehalfby
        {
            get { return GetRelatedEntities<PostLike>("lk_postlike_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_postlike_createdonbehalfby");
                SetRelatedEntities("lk_postlike_createdonbehalfby", null, value);
                OnPropertyChanged("lk_postlike_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_pricelevel_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_pricelevel_createdonbehalfby")]
        public IEnumerable<PriceLevel> lk_pricelevel_createdonbehalfby
        {
            get { return GetRelatedEntities<PriceLevel>("lk_pricelevel_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_pricelevel_createdonbehalfby");
                SetRelatedEntities("lk_pricelevel_createdonbehalfby", null, value);
                OnPropertyChanged("lk_pricelevel_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_pricelevel_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_pricelevel_modifiedonbehalfby")]
        public IEnumerable<PriceLevel> lk_pricelevel_modifiedonbehalfby
        {
            get { return GetRelatedEntities<PriceLevel>("lk_pricelevel_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_pricelevel_modifiedonbehalfby");
                SetRelatedEntities("lk_pricelevel_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_pricelevel_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_pricelevelbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_pricelevelbase_createdby")]
        public IEnumerable<PriceLevel> lk_pricelevelbase_createdby
        {
            get { return GetRelatedEntities<PriceLevel>("lk_pricelevelbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_pricelevelbase_createdby");
                SetRelatedEntities("lk_pricelevelbase_createdby", null, value);
                OnPropertyChanged("lk_pricelevelbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_pricelevelbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_pricelevelbase_modifiedby")]
        public IEnumerable<PriceLevel> lk_pricelevelbase_modifiedby
        {
            get { return GetRelatedEntities<PriceLevel>("lk_pricelevelbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_pricelevelbase_modifiedby");
                SetRelatedEntities("lk_pricelevelbase_modifiedby", null, value);
                OnPropertyChanged("lk_pricelevelbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_processsession_canceledby
        /// </summary>
        [RelationshipSchemaName("lk_processsession_canceledby")]
        public IEnumerable<ProcessSession> lk_processsession_canceledby
        {
            get { return GetRelatedEntities<ProcessSession>("lk_processsession_canceledby", null); }
            set
            {
                OnPropertyChanging("lk_processsession_canceledby");
                SetRelatedEntities("lk_processsession_canceledby", null, value);
                OnPropertyChanged("lk_processsession_canceledby");
            }
        }

        /// <summary>
        ///     1:N lk_processsession_completedby
        /// </summary>
        [RelationshipSchemaName("lk_processsession_completedby")]
        public IEnumerable<ProcessSession> lk_processsession_completedby
        {
            get { return GetRelatedEntities<ProcessSession>("lk_processsession_completedby", null); }
            set
            {
                OnPropertyChanging("lk_processsession_completedby");
                SetRelatedEntities("lk_processsession_completedby", null, value);
                OnPropertyChanged("lk_processsession_completedby");
            }
        }

        /// <summary>
        ///     1:N lk_processsession_createdby
        /// </summary>
        [RelationshipSchemaName("lk_processsession_createdby")]
        public IEnumerable<ProcessSession> lk_processsession_createdby
        {
            get { return GetRelatedEntities<ProcessSession>("lk_processsession_createdby", null); }
            set
            {
                OnPropertyChanging("lk_processsession_createdby");
                SetRelatedEntities("lk_processsession_createdby", null, value);
                OnPropertyChanged("lk_processsession_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_processsession_executedby
        /// </summary>
        [RelationshipSchemaName("lk_processsession_executedby")]
        public IEnumerable<ProcessSession> lk_processsession_executedby
        {
            get { return GetRelatedEntities<ProcessSession>("lk_processsession_executedby", null); }
            set
            {
                OnPropertyChanging("lk_processsession_executedby");
                SetRelatedEntities("lk_processsession_executedby", null, value);
                OnPropertyChanged("lk_processsession_executedby");
            }
        }

        /// <summary>
        ///     1:N lk_processsession_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_processsession_modifiedby")]
        public IEnumerable<ProcessSession> lk_processsession_modifiedby
        {
            get { return GetRelatedEntities<ProcessSession>("lk_processsession_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_processsession_modifiedby");
                SetRelatedEntities("lk_processsession_modifiedby", null, value);
                OnPropertyChanged("lk_processsession_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_processsession_startedby
        /// </summary>
        [RelationshipSchemaName("lk_processsession_startedby")]
        public IEnumerable<ProcessSession> lk_processsession_startedby
        {
            get { return GetRelatedEntities<ProcessSession>("lk_processsession_startedby", null); }
            set
            {
                OnPropertyChanging("lk_processsession_startedby");
                SetRelatedEntities("lk_processsession_startedby", null, value);
                OnPropertyChanged("lk_processsession_startedby");
            }
        }

        /// <summary>
        ///     1:N lk_processsessionbase_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_processsessionbase_createdonbehalfby")]
        public IEnumerable<ProcessSession> lk_processsessionbase_createdonbehalfby
        {
            get { return GetRelatedEntities<ProcessSession>("lk_processsessionbase_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_processsessionbase_createdonbehalfby");
                SetRelatedEntities("lk_processsessionbase_createdonbehalfby", null, value);
                OnPropertyChanged("lk_processsessionbase_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_processsessionbase_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_processsessionbase_modifiedonbehalfby")]
        public IEnumerable<ProcessSession> lk_processsessionbase_modifiedonbehalfby
        {
            get { return GetRelatedEntities<ProcessSession>("lk_processsessionbase_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_processsessionbase_modifiedonbehalfby");
                SetRelatedEntities("lk_processsessionbase_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_processsessionbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_processtriggerbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_processtriggerbase_createdby")]
        public IEnumerable<ProcessTrigger> lk_processtriggerbase_createdby
        {
            get { return GetRelatedEntities<ProcessTrigger>("lk_processtriggerbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_processtriggerbase_createdby");
                SetRelatedEntities("lk_processtriggerbase_createdby", null, value);
                OnPropertyChanged("lk_processtriggerbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_processtriggerbase_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_processtriggerbase_createdonbehalfby")]
        public IEnumerable<ProcessTrigger> lk_processtriggerbase_createdonbehalfby
        {
            get { return GetRelatedEntities<ProcessTrigger>("lk_processtriggerbase_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_processtriggerbase_createdonbehalfby");
                SetRelatedEntities("lk_processtriggerbase_createdonbehalfby", null, value);
                OnPropertyChanged("lk_processtriggerbase_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_processtriggerbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_processtriggerbase_modifiedby")]
        public IEnumerable<ProcessTrigger> lk_processtriggerbase_modifiedby
        {
            get { return GetRelatedEntities<ProcessTrigger>("lk_processtriggerbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_processtriggerbase_modifiedby");
                SetRelatedEntities("lk_processtriggerbase_modifiedby", null, value);
                OnPropertyChanged("lk_processtriggerbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_processtriggerbase_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_processtriggerbase_modifiedonbehalfby")]
        public IEnumerable<ProcessTrigger> lk_processtriggerbase_modifiedonbehalfby
        {
            get { return GetRelatedEntities<ProcessTrigger>("lk_processtriggerbase_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_processtriggerbase_modifiedonbehalfby");
                SetRelatedEntities("lk_processtriggerbase_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_processtriggerbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_product_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_product_createdonbehalfby")]
        public IEnumerable<Product> lk_product_createdonbehalfby
        {
            get { return GetRelatedEntities<Product>("lk_product_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_product_createdonbehalfby");
                SetRelatedEntities("lk_product_createdonbehalfby", null, value);
                OnPropertyChanged("lk_product_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_product_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_product_modifiedonbehalfby")]
        public IEnumerable<Product> lk_product_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Product>("lk_product_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_product_modifiedonbehalfby");
                SetRelatedEntities("lk_product_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_product_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_productbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_productbase_createdby")]
        public IEnumerable<Product> lk_productbase_createdby
        {
            get { return GetRelatedEntities<Product>("lk_productbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_productbase_createdby");
                SetRelatedEntities("lk_productbase_createdby", null, value);
                OnPropertyChanged("lk_productbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_productbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_productbase_modifiedby")]
        public IEnumerable<Product> lk_productbase_modifiedby
        {
            get { return GetRelatedEntities<Product>("lk_productbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_productbase_modifiedby");
                SetRelatedEntities("lk_productbase_modifiedby", null, value);
                OnPropertyChanged("lk_productbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_productpricelevel_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_productpricelevel_createdonbehalfby")]
        public IEnumerable<ProductPriceLevel> lk_productpricelevel_createdonbehalfby
        {
            get { return GetRelatedEntities<ProductPriceLevel>("lk_productpricelevel_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_productpricelevel_createdonbehalfby");
                SetRelatedEntities("lk_productpricelevel_createdonbehalfby", null, value);
                OnPropertyChanged("lk_productpricelevel_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_productpricelevel_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_productpricelevel_modifiedonbehalfby")]
        public IEnumerable<ProductPriceLevel> lk_productpricelevel_modifiedonbehalfby
        {
            get { return GetRelatedEntities<ProductPriceLevel>("lk_productpricelevel_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_productpricelevel_modifiedonbehalfby");
                SetRelatedEntities("lk_productpricelevel_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_productpricelevel_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_productpricelevelbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_productpricelevelbase_createdby")]
        public IEnumerable<ProductPriceLevel> lk_productpricelevelbase_createdby
        {
            get { return GetRelatedEntities<ProductPriceLevel>("lk_productpricelevelbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_productpricelevelbase_createdby");
                SetRelatedEntities("lk_productpricelevelbase_createdby", null, value);
                OnPropertyChanged("lk_productpricelevelbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_productpricelevelbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_productpricelevelbase_modifiedby")]
        public IEnumerable<ProductPriceLevel> lk_productpricelevelbase_modifiedby
        {
            get { return GetRelatedEntities<ProductPriceLevel>("lk_productpricelevelbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_productpricelevelbase_modifiedby");
                SetRelatedEntities("lk_productpricelevelbase_modifiedby", null, value);
                OnPropertyChanged("lk_productpricelevelbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_publisher_createdby
        /// </summary>
        [RelationshipSchemaName("lk_publisher_createdby")]
        public IEnumerable<Publisher> lk_publisher_createdby
        {
            get { return GetRelatedEntities<Publisher>("lk_publisher_createdby", null); }
            set
            {
                OnPropertyChanging("lk_publisher_createdby");
                SetRelatedEntities("lk_publisher_createdby", null, value);
                OnPropertyChanged("lk_publisher_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_publisher_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_publisher_modifiedby")]
        public IEnumerable<Publisher> lk_publisher_modifiedby
        {
            get { return GetRelatedEntities<Publisher>("lk_publisher_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_publisher_modifiedby");
                SetRelatedEntities("lk_publisher_modifiedby", null, value);
                OnPropertyChanged("lk_publisher_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_publisheraddressbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_publisheraddressbase_createdby")]
        public IEnumerable<PublisherAddress> lk_publisheraddressbase_createdby
        {
            get { return GetRelatedEntities<PublisherAddress>("lk_publisheraddressbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_publisheraddressbase_createdby");
                SetRelatedEntities("lk_publisheraddressbase_createdby", null, value);
                OnPropertyChanged("lk_publisheraddressbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_publisheraddressbase_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_publisheraddressbase_createdonbehalfby")]
        public IEnumerable<PublisherAddress> lk_publisheraddressbase_createdonbehalfby
        {
            get { return GetRelatedEntities<PublisherAddress>("lk_publisheraddressbase_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_publisheraddressbase_createdonbehalfby");
                SetRelatedEntities("lk_publisheraddressbase_createdonbehalfby", null, value);
                OnPropertyChanged("lk_publisheraddressbase_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_publisheraddressbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_publisheraddressbase_modifiedby")]
        public IEnumerable<PublisherAddress> lk_publisheraddressbase_modifiedby
        {
            get { return GetRelatedEntities<PublisherAddress>("lk_publisheraddressbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_publisheraddressbase_modifiedby");
                SetRelatedEntities("lk_publisheraddressbase_modifiedby", null, value);
                OnPropertyChanged("lk_publisheraddressbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_publisheraddressbase_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_publisheraddressbase_modifiedonbehalfby")]
        public IEnumerable<PublisherAddress> lk_publisheraddressbase_modifiedonbehalfby
        {
            get { return GetRelatedEntities<PublisherAddress>("lk_publisheraddressbase_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_publisheraddressbase_modifiedonbehalfby");
                SetRelatedEntities("lk_publisheraddressbase_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_publisheraddressbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_publisherbase_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_publisherbase_createdonbehalfby")]
        public IEnumerable<Publisher> lk_publisherbase_createdonbehalfby
        {
            get { return GetRelatedEntities<Publisher>("lk_publisherbase_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_publisherbase_createdonbehalfby");
                SetRelatedEntities("lk_publisherbase_createdonbehalfby", null, value);
                OnPropertyChanged("lk_publisherbase_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_publisherbase_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_publisherbase_modifiedonbehalfby")]
        public IEnumerable<Publisher> lk_publisherbase_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Publisher>("lk_publisherbase_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_publisherbase_modifiedonbehalfby");
                SetRelatedEntities("lk_publisherbase_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_publisherbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_quarterlyfiscalcalendar_createdby
        /// </summary>
        [RelationshipSchemaName("lk_quarterlyfiscalcalendar_createdby")]
        public IEnumerable<QuarterlyFiscalCalendar> lk_quarterlyfiscalcalendar_createdby
        {
            get { return GetRelatedEntities<QuarterlyFiscalCalendar>("lk_quarterlyfiscalcalendar_createdby", null); }
            set
            {
                OnPropertyChanging("lk_quarterlyfiscalcalendar_createdby");
                SetRelatedEntities("lk_quarterlyfiscalcalendar_createdby", null, value);
                OnPropertyChanged("lk_quarterlyfiscalcalendar_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_quarterlyfiscalcalendar_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_quarterlyfiscalcalendar_createdonbehalfby")]
        public IEnumerable<QuarterlyFiscalCalendar> lk_quarterlyfiscalcalendar_createdonbehalfby
        {
            get
            {
                return GetRelatedEntities<QuarterlyFiscalCalendar>("lk_quarterlyfiscalcalendar_createdonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_quarterlyfiscalcalendar_createdonbehalfby");
                SetRelatedEntities("lk_quarterlyfiscalcalendar_createdonbehalfby", null, value);
                OnPropertyChanged("lk_quarterlyfiscalcalendar_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_quarterlyfiscalcalendar_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_quarterlyfiscalcalendar_modifiedby")]
        public IEnumerable<QuarterlyFiscalCalendar> lk_quarterlyfiscalcalendar_modifiedby
        {
            get { return GetRelatedEntities<QuarterlyFiscalCalendar>("lk_quarterlyfiscalcalendar_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_quarterlyfiscalcalendar_modifiedby");
                SetRelatedEntities("lk_quarterlyfiscalcalendar_modifiedby", null, value);
                OnPropertyChanged("lk_quarterlyfiscalcalendar_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_quarterlyfiscalcalendar_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_quarterlyfiscalcalendar_modifiedonbehalfby")]
        public IEnumerable<QuarterlyFiscalCalendar> lk_quarterlyfiscalcalendar_modifiedonbehalfby
        {
            get
            {
                return GetRelatedEntities<QuarterlyFiscalCalendar>("lk_quarterlyfiscalcalendar_modifiedonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_quarterlyfiscalcalendar_modifiedonbehalfby");
                SetRelatedEntities("lk_quarterlyfiscalcalendar_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_quarterlyfiscalcalendar_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_quarterlyfiscalcalendar_salespersonid
        /// </summary>
        [RelationshipSchemaName("lk_quarterlyfiscalcalendar_salespersonid")]
        public IEnumerable<QuarterlyFiscalCalendar> lk_quarterlyfiscalcalendar_salespersonid
        {
            get
            {
                return GetRelatedEntities<QuarterlyFiscalCalendar>("lk_quarterlyfiscalcalendar_salespersonid", null);
            }
            set
            {
                OnPropertyChanging("lk_quarterlyfiscalcalendar_salespersonid");
                SetRelatedEntities("lk_quarterlyfiscalcalendar_salespersonid", null, value);
                OnPropertyChanged("lk_quarterlyfiscalcalendar_salespersonid");
            }
        }

        /// <summary>
        ///     1:N lk_queue_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_queue_createdonbehalfby")]
        public IEnumerable<Queue> lk_queue_createdonbehalfby
        {
            get { return GetRelatedEntities<Queue>("lk_queue_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_queue_createdonbehalfby");
                SetRelatedEntities("lk_queue_createdonbehalfby", null, value);
                OnPropertyChanged("lk_queue_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_queue_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_queue_modifiedonbehalfby")]
        public IEnumerable<Queue> lk_queue_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Queue>("lk_queue_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_queue_modifiedonbehalfby");
                SetRelatedEntities("lk_queue_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_queue_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_queuebase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_queuebase_createdby")]
        public IEnumerable<Queue> lk_queuebase_createdby
        {
            get { return GetRelatedEntities<Queue>("lk_queuebase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_queuebase_createdby");
                SetRelatedEntities("lk_queuebase_createdby", null, value);
                OnPropertyChanged("lk_queuebase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_queuebase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_queuebase_modifiedby")]
        public IEnumerable<Queue> lk_queuebase_modifiedby
        {
            get { return GetRelatedEntities<Queue>("lk_queuebase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_queuebase_modifiedby");
                SetRelatedEntities("lk_queuebase_modifiedby", null, value);
                OnPropertyChanged("lk_queuebase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_queueitem_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_queueitem_createdonbehalfby")]
        public IEnumerable<QueueItem> lk_queueitem_createdonbehalfby
        {
            get { return GetRelatedEntities<QueueItem>("lk_queueitem_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_queueitem_createdonbehalfby");
                SetRelatedEntities("lk_queueitem_createdonbehalfby", null, value);
                OnPropertyChanged("lk_queueitem_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_queueitem_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_queueitem_modifiedonbehalfby")]
        public IEnumerable<QueueItem> lk_queueitem_modifiedonbehalfby
        {
            get { return GetRelatedEntities<QueueItem>("lk_queueitem_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_queueitem_modifiedonbehalfby");
                SetRelatedEntities("lk_queueitem_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_queueitem_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_queueitembase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_queueitembase_createdby")]
        public IEnumerable<QueueItem> lk_queueitembase_createdby
        {
            get { return GetRelatedEntities<QueueItem>("lk_queueitembase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_queueitembase_createdby");
                SetRelatedEntities("lk_queueitembase_createdby", null, value);
                OnPropertyChanged("lk_queueitembase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_queueitembase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_queueitembase_modifiedby")]
        public IEnumerable<QueueItem> lk_queueitembase_modifiedby
        {
            get { return GetRelatedEntities<QueueItem>("lk_queueitembase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_queueitembase_modifiedby");
                SetRelatedEntities("lk_queueitembase_modifiedby", null, value);
                OnPropertyChanged("lk_queueitembase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_queueitembase_workerid
        /// </summary>
        [RelationshipSchemaName("lk_queueitembase_workerid")]
        public IEnumerable<QueueItem> lk_queueitembase_workerid
        {
            get { return GetRelatedEntities<QueueItem>("lk_queueitembase_workerid", null); }
            set
            {
                OnPropertyChanging("lk_queueitembase_workerid");
                SetRelatedEntities("lk_queueitembase_workerid", null, value);
                OnPropertyChanged("lk_queueitembase_workerid");
            }
        }

        /// <summary>
        ///     1:N lk_quote_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_quote_createdonbehalfby")]
        public IEnumerable<Quote> lk_quote_createdonbehalfby
        {
            get { return GetRelatedEntities<Quote>("lk_quote_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_quote_createdonbehalfby");
                SetRelatedEntities("lk_quote_createdonbehalfby", null, value);
                OnPropertyChanged("lk_quote_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_quote_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_quote_modifiedonbehalfby")]
        public IEnumerable<Quote> lk_quote_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Quote>("lk_quote_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_quote_modifiedonbehalfby");
                SetRelatedEntities("lk_quote_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_quote_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_quotebase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_quotebase_createdby")]
        public IEnumerable<Quote> lk_quotebase_createdby
        {
            get { return GetRelatedEntities<Quote>("lk_quotebase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_quotebase_createdby");
                SetRelatedEntities("lk_quotebase_createdby", null, value);
                OnPropertyChanged("lk_quotebase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_quotebase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_quotebase_modifiedby")]
        public IEnumerable<Quote> lk_quotebase_modifiedby
        {
            get { return GetRelatedEntities<Quote>("lk_quotebase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_quotebase_modifiedby");
                SetRelatedEntities("lk_quotebase_modifiedby", null, value);
                OnPropertyChanged("lk_quotebase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_quoteclose_createdby
        /// </summary>
        [RelationshipSchemaName("lk_quoteclose_createdby")]
        public IEnumerable<QuoteClose> lk_quoteclose_createdby
        {
            get { return GetRelatedEntities<QuoteClose>("lk_quoteclose_createdby", null); }
            set
            {
                OnPropertyChanging("lk_quoteclose_createdby");
                SetRelatedEntities("lk_quoteclose_createdby", null, value);
                OnPropertyChanged("lk_quoteclose_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_quoteclose_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_quoteclose_createdonbehalfby")]
        public IEnumerable<QuoteClose> lk_quoteclose_createdonbehalfby
        {
            get { return GetRelatedEntities<QuoteClose>("lk_quoteclose_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_quoteclose_createdonbehalfby");
                SetRelatedEntities("lk_quoteclose_createdonbehalfby", null, value);
                OnPropertyChanged("lk_quoteclose_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_quoteclose_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_quoteclose_modifiedby")]
        public IEnumerable<QuoteClose> lk_quoteclose_modifiedby
        {
            get { return GetRelatedEntities<QuoteClose>("lk_quoteclose_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_quoteclose_modifiedby");
                SetRelatedEntities("lk_quoteclose_modifiedby", null, value);
                OnPropertyChanged("lk_quoteclose_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_quoteclose_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_quoteclose_modifiedonbehalfby")]
        public IEnumerable<QuoteClose> lk_quoteclose_modifiedonbehalfby
        {
            get { return GetRelatedEntities<QuoteClose>("lk_quoteclose_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_quoteclose_modifiedonbehalfby");
                SetRelatedEntities("lk_quoteclose_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_quoteclose_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_quotedetail_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_quotedetail_createdonbehalfby")]
        public IEnumerable<QuoteDetail> lk_quotedetail_createdonbehalfby
        {
            get { return GetRelatedEntities<QuoteDetail>("lk_quotedetail_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_quotedetail_createdonbehalfby");
                SetRelatedEntities("lk_quotedetail_createdonbehalfby", null, value);
                OnPropertyChanged("lk_quotedetail_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_quotedetail_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_quotedetail_modifiedonbehalfby")]
        public IEnumerable<QuoteDetail> lk_quotedetail_modifiedonbehalfby
        {
            get { return GetRelatedEntities<QuoteDetail>("lk_quotedetail_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_quotedetail_modifiedonbehalfby");
                SetRelatedEntities("lk_quotedetail_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_quotedetail_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_quotedetailbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_quotedetailbase_createdby")]
        public IEnumerable<QuoteDetail> lk_quotedetailbase_createdby
        {
            get { return GetRelatedEntities<QuoteDetail>("lk_quotedetailbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_quotedetailbase_createdby");
                SetRelatedEntities("lk_quotedetailbase_createdby", null, value);
                OnPropertyChanged("lk_quotedetailbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_quotedetailbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_quotedetailbase_modifiedby")]
        public IEnumerable<QuoteDetail> lk_quotedetailbase_modifiedby
        {
            get { return GetRelatedEntities<QuoteDetail>("lk_quotedetailbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_quotedetailbase_modifiedby");
                SetRelatedEntities("lk_quotedetailbase_modifiedby", null, value);
                OnPropertyChanged("lk_quotedetailbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_recurrencerule_createdby
        /// </summary>
        [RelationshipSchemaName("lk_recurrencerule_createdby")]
        public IEnumerable<RecurrenceRule> lk_recurrencerule_createdby
        {
            get { return GetRelatedEntities<RecurrenceRule>("lk_recurrencerule_createdby", null); }
            set
            {
                OnPropertyChanging("lk_recurrencerule_createdby");
                SetRelatedEntities("lk_recurrencerule_createdby", null, value);
                OnPropertyChanged("lk_recurrencerule_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_recurrencerule_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_recurrencerule_modifiedby")]
        public IEnumerable<RecurrenceRule> lk_recurrencerule_modifiedby
        {
            get { return GetRelatedEntities<RecurrenceRule>("lk_recurrencerule_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_recurrencerule_modifiedby");
                SetRelatedEntities("lk_recurrencerule_modifiedby", null, value);
                OnPropertyChanged("lk_recurrencerule_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_recurrencerulebase_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_recurrencerulebase_createdonbehalfby")]
        public IEnumerable<RecurrenceRule> lk_recurrencerulebase_createdonbehalfby
        {
            get { return GetRelatedEntities<RecurrenceRule>("lk_recurrencerulebase_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_recurrencerulebase_createdonbehalfby");
                SetRelatedEntities("lk_recurrencerulebase_createdonbehalfby", null, value);
                OnPropertyChanged("lk_recurrencerulebase_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_recurrencerulebase_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_recurrencerulebase_modifiedonbehalfby")]
        public IEnumerable<RecurrenceRule> lk_recurrencerulebase_modifiedonbehalfby
        {
            get { return GetRelatedEntities<RecurrenceRule>("lk_recurrencerulebase_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_recurrencerulebase_modifiedonbehalfby");
                SetRelatedEntities("lk_recurrencerulebase_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_recurrencerulebase_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_recurringappointmentmaster_createdby
        /// </summary>
        [RelationshipSchemaName("lk_recurringappointmentmaster_createdby")]
        public IEnumerable<RecurringAppointmentMaster> lk_recurringappointmentmaster_createdby
        {
            get
            {
                return GetRelatedEntities<RecurringAppointmentMaster>("lk_recurringappointmentmaster_createdby", null);
            }
            set
            {
                OnPropertyChanging("lk_recurringappointmentmaster_createdby");
                SetRelatedEntities("lk_recurringappointmentmaster_createdby", null, value);
                OnPropertyChanged("lk_recurringappointmentmaster_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_recurringappointmentmaster_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_recurringappointmentmaster_createdonbehalfby")]
        public IEnumerable<RecurringAppointmentMaster> lk_recurringappointmentmaster_createdonbehalfby
        {
            get
            {
                return GetRelatedEntities<RecurringAppointmentMaster>(
                    "lk_recurringappointmentmaster_createdonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_recurringappointmentmaster_createdonbehalfby");
                SetRelatedEntities("lk_recurringappointmentmaster_createdonbehalfby", null, value);
                OnPropertyChanged("lk_recurringappointmentmaster_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_recurringappointmentmaster_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_recurringappointmentmaster_modifiedby")]
        public IEnumerable<RecurringAppointmentMaster> lk_recurringappointmentmaster_modifiedby
        {
            get
            {
                return GetRelatedEntities<RecurringAppointmentMaster>("lk_recurringappointmentmaster_modifiedby", null);
            }
            set
            {
                OnPropertyChanging("lk_recurringappointmentmaster_modifiedby");
                SetRelatedEntities("lk_recurringappointmentmaster_modifiedby", null, value);
                OnPropertyChanged("lk_recurringappointmentmaster_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_recurringappointmentmaster_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_recurringappointmentmaster_modifiedonbehalfby")]
        public IEnumerable<RecurringAppointmentMaster> lk_recurringappointmentmaster_modifiedonbehalfby
        {
            get
            {
                return GetRelatedEntities<RecurringAppointmentMaster>(
                    "lk_recurringappointmentmaster_modifiedonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_recurringappointmentmaster_modifiedonbehalfby");
                SetRelatedEntities("lk_recurringappointmentmaster_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_recurringappointmentmaster_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_relationshiprole_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_relationshiprole_createdonbehalfby")]
        public IEnumerable<RelationshipRole> lk_relationshiprole_createdonbehalfby
        {
            get { return GetRelatedEntities<RelationshipRole>("lk_relationshiprole_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_relationshiprole_createdonbehalfby");
                SetRelatedEntities("lk_relationshiprole_createdonbehalfby", null, value);
                OnPropertyChanged("lk_relationshiprole_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_relationshiprole_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_relationshiprole_modifiedonbehalfby")]
        public IEnumerable<RelationshipRole> lk_relationshiprole_modifiedonbehalfby
        {
            get { return GetRelatedEntities<RelationshipRole>("lk_relationshiprole_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_relationshiprole_modifiedonbehalfby");
                SetRelatedEntities("lk_relationshiprole_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_relationshiprole_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_relationshiprolemap_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_relationshiprolemap_createdonbehalfby")]
        public IEnumerable<RelationshipRoleMap> lk_relationshiprolemap_createdonbehalfby
        {
            get { return GetRelatedEntities<RelationshipRoleMap>("lk_relationshiprolemap_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_relationshiprolemap_createdonbehalfby");
                SetRelatedEntities("lk_relationshiprolemap_createdonbehalfby", null, value);
                OnPropertyChanged("lk_relationshiprolemap_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_relationshiprolemap_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_relationshiprolemap_modifiedonbehalfby")]
        public IEnumerable<RelationshipRoleMap> lk_relationshiprolemap_modifiedonbehalfby
        {
            get { return GetRelatedEntities<RelationshipRoleMap>("lk_relationshiprolemap_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_relationshiprolemap_modifiedonbehalfby");
                SetRelatedEntities("lk_relationshiprolemap_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_relationshiprolemap_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_report_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_report_createdonbehalfby")]
        public IEnumerable<Report> lk_report_createdonbehalfby
        {
            get { return GetRelatedEntities<Report>("lk_report_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_report_createdonbehalfby");
                SetRelatedEntities("lk_report_createdonbehalfby", null, value);
                OnPropertyChanged("lk_report_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_report_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_report_modifiedonbehalfby")]
        public IEnumerable<Report> lk_report_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Report>("lk_report_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_report_modifiedonbehalfby");
                SetRelatedEntities("lk_report_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_report_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_reportbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_reportbase_createdby")]
        public IEnumerable<Report> lk_reportbase_createdby
        {
            get { return GetRelatedEntities<Report>("lk_reportbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_reportbase_createdby");
                SetRelatedEntities("lk_reportbase_createdby", null, value);
                OnPropertyChanged("lk_reportbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_reportbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_reportbase_modifiedby")]
        public IEnumerable<Report> lk_reportbase_modifiedby
        {
            get { return GetRelatedEntities<Report>("lk_reportbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_reportbase_modifiedby");
                SetRelatedEntities("lk_reportbase_modifiedby", null, value);
                OnPropertyChanged("lk_reportbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_reportcategory_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_reportcategory_createdonbehalfby")]
        public IEnumerable<ReportCategory> lk_reportcategory_createdonbehalfby
        {
            get { return GetRelatedEntities<ReportCategory>("lk_reportcategory_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_reportcategory_createdonbehalfby");
                SetRelatedEntities("lk_reportcategory_createdonbehalfby", null, value);
                OnPropertyChanged("lk_reportcategory_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_reportcategory_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_reportcategory_modifiedonbehalfby")]
        public IEnumerable<ReportCategory> lk_reportcategory_modifiedonbehalfby
        {
            get { return GetRelatedEntities<ReportCategory>("lk_reportcategory_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_reportcategory_modifiedonbehalfby");
                SetRelatedEntities("lk_reportcategory_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_reportcategory_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_reportcategorybase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_reportcategorybase_createdby")]
        public IEnumerable<ReportCategory> lk_reportcategorybase_createdby
        {
            get { return GetRelatedEntities<ReportCategory>("lk_reportcategorybase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_reportcategorybase_createdby");
                SetRelatedEntities("lk_reportcategorybase_createdby", null, value);
                OnPropertyChanged("lk_reportcategorybase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_reportcategorybase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_reportcategorybase_modifiedby")]
        public IEnumerable<ReportCategory> lk_reportcategorybase_modifiedby
        {
            get { return GetRelatedEntities<ReportCategory>("lk_reportcategorybase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_reportcategorybase_modifiedby");
                SetRelatedEntities("lk_reportcategorybase_modifiedby", null, value);
                OnPropertyChanged("lk_reportcategorybase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_reportentity_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_reportentity_createdonbehalfby")]
        public IEnumerable<ReportEntity> lk_reportentity_createdonbehalfby
        {
            get { return GetRelatedEntities<ReportEntity>("lk_reportentity_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_reportentity_createdonbehalfby");
                SetRelatedEntities("lk_reportentity_createdonbehalfby", null, value);
                OnPropertyChanged("lk_reportentity_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_reportentity_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_reportentity_modifiedonbehalfby")]
        public IEnumerable<ReportEntity> lk_reportentity_modifiedonbehalfby
        {
            get { return GetRelatedEntities<ReportEntity>("lk_reportentity_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_reportentity_modifiedonbehalfby");
                SetRelatedEntities("lk_reportentity_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_reportentity_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_reportentitybase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_reportentitybase_createdby")]
        public IEnumerable<ReportEntity> lk_reportentitybase_createdby
        {
            get { return GetRelatedEntities<ReportEntity>("lk_reportentitybase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_reportentitybase_createdby");
                SetRelatedEntities("lk_reportentitybase_createdby", null, value);
                OnPropertyChanged("lk_reportentitybase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_reportentitybase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_reportentitybase_modifiedby")]
        public IEnumerable<ReportEntity> lk_reportentitybase_modifiedby
        {
            get { return GetRelatedEntities<ReportEntity>("lk_reportentitybase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_reportentitybase_modifiedby");
                SetRelatedEntities("lk_reportentitybase_modifiedby", null, value);
                OnPropertyChanged("lk_reportentitybase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_reportlink_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_reportlink_createdonbehalfby")]
        public IEnumerable<ReportLink> lk_reportlink_createdonbehalfby
        {
            get { return GetRelatedEntities<ReportLink>("lk_reportlink_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_reportlink_createdonbehalfby");
                SetRelatedEntities("lk_reportlink_createdonbehalfby", null, value);
                OnPropertyChanged("lk_reportlink_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_reportlink_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_reportlink_modifiedonbehalfby")]
        public IEnumerable<ReportLink> lk_reportlink_modifiedonbehalfby
        {
            get { return GetRelatedEntities<ReportLink>("lk_reportlink_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_reportlink_modifiedonbehalfby");
                SetRelatedEntities("lk_reportlink_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_reportlink_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_reportlinkbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_reportlinkbase_createdby")]
        public IEnumerable<ReportLink> lk_reportlinkbase_createdby
        {
            get { return GetRelatedEntities<ReportLink>("lk_reportlinkbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_reportlinkbase_createdby");
                SetRelatedEntities("lk_reportlinkbase_createdby", null, value);
                OnPropertyChanged("lk_reportlinkbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_reportlinkbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_reportlinkbase_modifiedby")]
        public IEnumerable<ReportLink> lk_reportlinkbase_modifiedby
        {
            get { return GetRelatedEntities<ReportLink>("lk_reportlinkbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_reportlinkbase_modifiedby");
                SetRelatedEntities("lk_reportlinkbase_modifiedby", null, value);
                OnPropertyChanged("lk_reportlinkbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_reportvisibility_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_reportvisibility_createdonbehalfby")]
        public IEnumerable<ReportVisibility> lk_reportvisibility_createdonbehalfby
        {
            get { return GetRelatedEntities<ReportVisibility>("lk_reportvisibility_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_reportvisibility_createdonbehalfby");
                SetRelatedEntities("lk_reportvisibility_createdonbehalfby", null, value);
                OnPropertyChanged("lk_reportvisibility_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_reportvisibility_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_reportvisibility_modifiedonbehalfby")]
        public IEnumerable<ReportVisibility> lk_reportvisibility_modifiedonbehalfby
        {
            get { return GetRelatedEntities<ReportVisibility>("lk_reportvisibility_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_reportvisibility_modifiedonbehalfby");
                SetRelatedEntities("lk_reportvisibility_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_reportvisibility_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_reportvisibilitybase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_reportvisibilitybase_createdby")]
        public IEnumerable<ReportVisibility> lk_reportvisibilitybase_createdby
        {
            get { return GetRelatedEntities<ReportVisibility>("lk_reportvisibilitybase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_reportvisibilitybase_createdby");
                SetRelatedEntities("lk_reportvisibilitybase_createdby", null, value);
                OnPropertyChanged("lk_reportvisibilitybase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_reportvisibilitybase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_reportvisibilitybase_modifiedby")]
        public IEnumerable<ReportVisibility> lk_reportvisibilitybase_modifiedby
        {
            get { return GetRelatedEntities<ReportVisibility>("lk_reportvisibilitybase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_reportvisibilitybase_modifiedby");
                SetRelatedEntities("lk_reportvisibilitybase_modifiedby", null, value);
                OnPropertyChanged("lk_reportvisibilitybase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_resourcespec_createdby
        /// </summary>
        [RelationshipSchemaName("lk_resourcespec_createdby")]
        public IEnumerable<ResourceSpec> lk_resourcespec_createdby
        {
            get { return GetRelatedEntities<ResourceSpec>("lk_resourcespec_createdby", null); }
            set
            {
                OnPropertyChanging("lk_resourcespec_createdby");
                SetRelatedEntities("lk_resourcespec_createdby", null, value);
                OnPropertyChanged("lk_resourcespec_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_resourcespec_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_resourcespec_createdonbehalfby")]
        public IEnumerable<ResourceSpec> lk_resourcespec_createdonbehalfby
        {
            get { return GetRelatedEntities<ResourceSpec>("lk_resourcespec_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_resourcespec_createdonbehalfby");
                SetRelatedEntities("lk_resourcespec_createdonbehalfby", null, value);
                OnPropertyChanged("lk_resourcespec_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_resourcespec_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_resourcespec_modifiedby")]
        public IEnumerable<ResourceSpec> lk_resourcespec_modifiedby
        {
            get { return GetRelatedEntities<ResourceSpec>("lk_resourcespec_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_resourcespec_modifiedby");
                SetRelatedEntities("lk_resourcespec_modifiedby", null, value);
                OnPropertyChanged("lk_resourcespec_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_resourcespec_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_resourcespec_modifiedonbehalfby")]
        public IEnumerable<ResourceSpec> lk_resourcespec_modifiedonbehalfby
        {
            get { return GetRelatedEntities<ResourceSpec>("lk_resourcespec_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_resourcespec_modifiedonbehalfby");
                SetRelatedEntities("lk_resourcespec_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_resourcespec_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_role_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_role_createdonbehalfby")]
        public IEnumerable<Role> lk_role_createdonbehalfby
        {
            get { return GetRelatedEntities<Role>("lk_role_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_role_createdonbehalfby");
                SetRelatedEntities("lk_role_createdonbehalfby", null, value);
                OnPropertyChanged("lk_role_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_role_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_role_modifiedonbehalfby")]
        public IEnumerable<Role> lk_role_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Role>("lk_role_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_role_modifiedonbehalfby");
                SetRelatedEntities("lk_role_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_role_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_rolebase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_rolebase_createdby")]
        public IEnumerable<Role> lk_rolebase_createdby
        {
            get { return GetRelatedEntities<Role>("lk_rolebase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_rolebase_createdby");
                SetRelatedEntities("lk_rolebase_createdby", null, value);
                OnPropertyChanged("lk_rolebase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_rolebase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_rolebase_modifiedby")]
        public IEnumerable<Role> lk_rolebase_modifiedby
        {
            get { return GetRelatedEntities<Role>("lk_rolebase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_rolebase_modifiedby");
                SetRelatedEntities("lk_rolebase_modifiedby", null, value);
                OnPropertyChanged("lk_rolebase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_rollupfield_createdby
        /// </summary>
        [RelationshipSchemaName("lk_rollupfield_createdby")]
        public IEnumerable<RollupField> lk_rollupfield_createdby
        {
            get { return GetRelatedEntities<RollupField>("lk_rollupfield_createdby", null); }
            set
            {
                OnPropertyChanging("lk_rollupfield_createdby");
                SetRelatedEntities("lk_rollupfield_createdby", null, value);
                OnPropertyChanged("lk_rollupfield_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_rollupfield_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_rollupfield_createdonbehalfby")]
        public IEnumerable<RollupField> lk_rollupfield_createdonbehalfby
        {
            get { return GetRelatedEntities<RollupField>("lk_rollupfield_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_rollupfield_createdonbehalfby");
                SetRelatedEntities("lk_rollupfield_createdonbehalfby", null, value);
                OnPropertyChanged("lk_rollupfield_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_rollupfield_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_rollupfield_modifiedby")]
        public IEnumerable<RollupField> lk_rollupfield_modifiedby
        {
            get { return GetRelatedEntities<RollupField>("lk_rollupfield_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_rollupfield_modifiedby");
                SetRelatedEntities("lk_rollupfield_modifiedby", null, value);
                OnPropertyChanged("lk_rollupfield_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_rollupfield_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_rollupfield_modifiedonbehalfby")]
        public IEnumerable<RollupField> lk_rollupfield_modifiedonbehalfby
        {
            get { return GetRelatedEntities<RollupField>("lk_rollupfield_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_rollupfield_modifiedonbehalfby");
                SetRelatedEntities("lk_rollupfield_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_rollupfield_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_salesliterature_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_salesliterature_createdonbehalfby")]
        public IEnumerable<SalesLiterature> lk_salesliterature_createdonbehalfby
        {
            get { return GetRelatedEntities<SalesLiterature>("lk_salesliterature_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_salesliterature_createdonbehalfby");
                SetRelatedEntities("lk_salesliterature_createdonbehalfby", null, value);
                OnPropertyChanged("lk_salesliterature_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_salesliterature_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_salesliterature_modifiedonbehalfby")]
        public IEnumerable<SalesLiterature> lk_salesliterature_modifiedonbehalfby
        {
            get { return GetRelatedEntities<SalesLiterature>("lk_salesliterature_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_salesliterature_modifiedonbehalfby");
                SetRelatedEntities("lk_salesliterature_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_salesliterature_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_salesliteraturebase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_salesliteraturebase_createdby")]
        public IEnumerable<SalesLiterature> lk_salesliteraturebase_createdby
        {
            get { return GetRelatedEntities<SalesLiterature>("lk_salesliteraturebase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_salesliteraturebase_createdby");
                SetRelatedEntities("lk_salesliteraturebase_createdby", null, value);
                OnPropertyChanged("lk_salesliteraturebase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_salesliteraturebase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_salesliteraturebase_modifiedby")]
        public IEnumerable<SalesLiterature> lk_salesliteraturebase_modifiedby
        {
            get { return GetRelatedEntities<SalesLiterature>("lk_salesliteraturebase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_salesliteraturebase_modifiedby");
                SetRelatedEntities("lk_salesliteraturebase_modifiedby", null, value);
                OnPropertyChanged("lk_salesliteraturebase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_salesliteratureitem_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_salesliteratureitem_createdonbehalfby")]
        public IEnumerable<SalesLiteratureItem> lk_salesliteratureitem_createdonbehalfby
        {
            get { return GetRelatedEntities<SalesLiteratureItem>("lk_salesliteratureitem_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_salesliteratureitem_createdonbehalfby");
                SetRelatedEntities("lk_salesliteratureitem_createdonbehalfby", null, value);
                OnPropertyChanged("lk_salesliteratureitem_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_salesliteratureitem_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_salesliteratureitem_modifiedonbehalfby")]
        public IEnumerable<SalesLiteratureItem> lk_salesliteratureitem_modifiedonbehalfby
        {
            get { return GetRelatedEntities<SalesLiteratureItem>("lk_salesliteratureitem_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_salesliteratureitem_modifiedonbehalfby");
                SetRelatedEntities("lk_salesliteratureitem_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_salesliteratureitem_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_salesliteratureitembase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_salesliteratureitembase_createdby")]
        public IEnumerable<SalesLiteratureItem> lk_salesliteratureitembase_createdby
        {
            get { return GetRelatedEntities<SalesLiteratureItem>("lk_salesliteratureitembase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_salesliteratureitembase_createdby");
                SetRelatedEntities("lk_salesliteratureitembase_createdby", null, value);
                OnPropertyChanged("lk_salesliteratureitembase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_salesliteratureitembase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_salesliteratureitembase_modifiedby")]
        public IEnumerable<SalesLiteratureItem> lk_salesliteratureitembase_modifiedby
        {
            get { return GetRelatedEntities<SalesLiteratureItem>("lk_salesliteratureitembase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_salesliteratureitembase_modifiedby");
                SetRelatedEntities("lk_salesliteratureitembase_modifiedby", null, value);
                OnPropertyChanged("lk_salesliteratureitembase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_salesorder_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_salesorder_createdonbehalfby")]
        public IEnumerable<SalesOrder> lk_salesorder_createdonbehalfby
        {
            get { return GetRelatedEntities<SalesOrder>("lk_salesorder_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_salesorder_createdonbehalfby");
                SetRelatedEntities("lk_salesorder_createdonbehalfby", null, value);
                OnPropertyChanged("lk_salesorder_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_salesorder_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_salesorder_modifiedonbehalfby")]
        public IEnumerable<SalesOrder> lk_salesorder_modifiedonbehalfby
        {
            get { return GetRelatedEntities<SalesOrder>("lk_salesorder_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_salesorder_modifiedonbehalfby");
                SetRelatedEntities("lk_salesorder_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_salesorder_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_salesorderbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_salesorderbase_createdby")]
        public IEnumerable<SalesOrder> lk_salesorderbase_createdby
        {
            get { return GetRelatedEntities<SalesOrder>("lk_salesorderbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_salesorderbase_createdby");
                SetRelatedEntities("lk_salesorderbase_createdby", null, value);
                OnPropertyChanged("lk_salesorderbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_salesorderbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_salesorderbase_modifiedby")]
        public IEnumerable<SalesOrder> lk_salesorderbase_modifiedby
        {
            get { return GetRelatedEntities<SalesOrder>("lk_salesorderbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_salesorderbase_modifiedby");
                SetRelatedEntities("lk_salesorderbase_modifiedby", null, value);
                OnPropertyChanged("lk_salesorderbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_salesorderdetail_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_salesorderdetail_createdonbehalfby")]
        public IEnumerable<SalesOrderDetail> lk_salesorderdetail_createdonbehalfby
        {
            get { return GetRelatedEntities<SalesOrderDetail>("lk_salesorderdetail_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_salesorderdetail_createdonbehalfby");
                SetRelatedEntities("lk_salesorderdetail_createdonbehalfby", null, value);
                OnPropertyChanged("lk_salesorderdetail_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_salesorderdetail_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_salesorderdetail_modifiedonbehalfby")]
        public IEnumerable<SalesOrderDetail> lk_salesorderdetail_modifiedonbehalfby
        {
            get { return GetRelatedEntities<SalesOrderDetail>("lk_salesorderdetail_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_salesorderdetail_modifiedonbehalfby");
                SetRelatedEntities("lk_salesorderdetail_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_salesorderdetail_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_salesorderdetailbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_salesorderdetailbase_createdby")]
        public IEnumerable<SalesOrderDetail> lk_salesorderdetailbase_createdby
        {
            get { return GetRelatedEntities<SalesOrderDetail>("lk_salesorderdetailbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_salesorderdetailbase_createdby");
                SetRelatedEntities("lk_salesorderdetailbase_createdby", null, value);
                OnPropertyChanged("lk_salesorderdetailbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_salesorderdetailbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_salesorderdetailbase_modifiedby")]
        public IEnumerable<SalesOrderDetail> lk_salesorderdetailbase_modifiedby
        {
            get { return GetRelatedEntities<SalesOrderDetail>("lk_salesorderdetailbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_salesorderdetailbase_modifiedby");
                SetRelatedEntities("lk_salesorderdetailbase_modifiedby", null, value);
                OnPropertyChanged("lk_salesorderdetailbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_savedquery_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_savedquery_createdonbehalfby")]
        public IEnumerable<SavedQuery> lk_savedquery_createdonbehalfby
        {
            get { return GetRelatedEntities<SavedQuery>("lk_savedquery_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_savedquery_createdonbehalfby");
                SetRelatedEntities("lk_savedquery_createdonbehalfby", null, value);
                OnPropertyChanged("lk_savedquery_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_savedquery_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_savedquery_modifiedonbehalfby")]
        public IEnumerable<SavedQuery> lk_savedquery_modifiedonbehalfby
        {
            get { return GetRelatedEntities<SavedQuery>("lk_savedquery_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_savedquery_modifiedonbehalfby");
                SetRelatedEntities("lk_savedquery_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_savedquery_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_savedquerybase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_savedquerybase_createdby")]
        public IEnumerable<SavedQuery> lk_savedquerybase_createdby
        {
            get { return GetRelatedEntities<SavedQuery>("lk_savedquerybase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_savedquerybase_createdby");
                SetRelatedEntities("lk_savedquerybase_createdby", null, value);
                OnPropertyChanged("lk_savedquerybase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_savedquerybase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_savedquerybase_modifiedby")]
        public IEnumerable<SavedQuery> lk_savedquerybase_modifiedby
        {
            get { return GetRelatedEntities<SavedQuery>("lk_savedquerybase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_savedquerybase_modifiedby");
                SetRelatedEntities("lk_savedquerybase_modifiedby", null, value);
                OnPropertyChanged("lk_savedquerybase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_savedqueryvisualizationbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_savedqueryvisualizationbase_createdby")]
        public IEnumerable<SavedQueryVisualization> lk_savedqueryvisualizationbase_createdby
        {
            get
            {
                return GetRelatedEntities<SavedQueryVisualization>("lk_savedqueryvisualizationbase_createdby", null);
            }
            set
            {
                OnPropertyChanging("lk_savedqueryvisualizationbase_createdby");
                SetRelatedEntities("lk_savedqueryvisualizationbase_createdby", null, value);
                OnPropertyChanged("lk_savedqueryvisualizationbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_savedqueryvisualizationbase_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_savedqueryvisualizationbase_createdonbehalfby")]
        public IEnumerable<SavedQueryVisualization> lk_savedqueryvisualizationbase_createdonbehalfby
        {
            get
            {
                return GetRelatedEntities<SavedQueryVisualization>("lk_savedqueryvisualizationbase_createdonbehalfby",
                    null);
            }
            set
            {
                OnPropertyChanging("lk_savedqueryvisualizationbase_createdonbehalfby");
                SetRelatedEntities("lk_savedqueryvisualizationbase_createdonbehalfby", null, value);
                OnPropertyChanged("lk_savedqueryvisualizationbase_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_savedqueryvisualizationbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_savedqueryvisualizationbase_modifiedby")]
        public IEnumerable<SavedQueryVisualization> lk_savedqueryvisualizationbase_modifiedby
        {
            get
            {
                return GetRelatedEntities<SavedQueryVisualization>("lk_savedqueryvisualizationbase_modifiedby", null);
            }
            set
            {
                OnPropertyChanging("lk_savedqueryvisualizationbase_modifiedby");
                SetRelatedEntities("lk_savedqueryvisualizationbase_modifiedby", null, value);
                OnPropertyChanged("lk_savedqueryvisualizationbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_savedqueryvisualizationbase_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_savedqueryvisualizationbase_modifiedonbehalfby")]
        public IEnumerable<SavedQueryVisualization> lk_savedqueryvisualizationbase_modifiedonbehalfby
        {
            get
            {
                return GetRelatedEntities<SavedQueryVisualization>("lk_savedqueryvisualizationbase_modifiedonbehalfby",
                    null);
            }
            set
            {
                OnPropertyChanging("lk_savedqueryvisualizationbase_modifiedonbehalfby");
                SetRelatedEntities("lk_savedqueryvisualizationbase_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_savedqueryvisualizationbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_sdkmessage_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_sdkmessage_createdonbehalfby")]
        public IEnumerable<SdkMessage> lk_sdkmessage_createdonbehalfby
        {
            get { return GetRelatedEntities<SdkMessage>("lk_sdkmessage_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_sdkmessage_createdonbehalfby");
                SetRelatedEntities("lk_sdkmessage_createdonbehalfby", null, value);
                OnPropertyChanged("lk_sdkmessage_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_sdkmessage_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_sdkmessage_modifiedonbehalfby")]
        public IEnumerable<SdkMessage> lk_sdkmessage_modifiedonbehalfby
        {
            get { return GetRelatedEntities<SdkMessage>("lk_sdkmessage_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_sdkmessage_modifiedonbehalfby");
                SetRelatedEntities("lk_sdkmessage_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_sdkmessage_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_sdkmessagefilter_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_sdkmessagefilter_createdonbehalfby")]
        public IEnumerable<SdkMessageFilter> lk_sdkmessagefilter_createdonbehalfby
        {
            get { return GetRelatedEntities<SdkMessageFilter>("lk_sdkmessagefilter_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_sdkmessagefilter_createdonbehalfby");
                SetRelatedEntities("lk_sdkmessagefilter_createdonbehalfby", null, value);
                OnPropertyChanged("lk_sdkmessagefilter_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_sdkmessagefilter_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_sdkmessagefilter_modifiedonbehalfby")]
        public IEnumerable<SdkMessageFilter> lk_sdkmessagefilter_modifiedonbehalfby
        {
            get { return GetRelatedEntities<SdkMessageFilter>("lk_sdkmessagefilter_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_sdkmessagefilter_modifiedonbehalfby");
                SetRelatedEntities("lk_sdkmessagefilter_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_sdkmessagefilter_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_sdkmessagepair_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_sdkmessagepair_createdonbehalfby")]
        public IEnumerable<SdkMessagePair> lk_sdkmessagepair_createdonbehalfby
        {
            get { return GetRelatedEntities<SdkMessagePair>("lk_sdkmessagepair_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_sdkmessagepair_createdonbehalfby");
                SetRelatedEntities("lk_sdkmessagepair_createdonbehalfby", null, value);
                OnPropertyChanged("lk_sdkmessagepair_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_sdkmessagepair_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_sdkmessagepair_modifiedonbehalfby")]
        public IEnumerable<SdkMessagePair> lk_sdkmessagepair_modifiedonbehalfby
        {
            get { return GetRelatedEntities<SdkMessagePair>("lk_sdkmessagepair_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_sdkmessagepair_modifiedonbehalfby");
                SetRelatedEntities("lk_sdkmessagepair_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_sdkmessagepair_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_sdkmessageprocessingstep_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_sdkmessageprocessingstep_createdonbehalfby")]
        public IEnumerable<SdkMessageProcessingStep> lk_sdkmessageprocessingstep_createdonbehalfby
        {
            get
            {
                return GetRelatedEntities<SdkMessageProcessingStep>("lk_sdkmessageprocessingstep_createdonbehalfby",
                    null);
            }
            set
            {
                OnPropertyChanging("lk_sdkmessageprocessingstep_createdonbehalfby");
                SetRelatedEntities("lk_sdkmessageprocessingstep_createdonbehalfby", null, value);
                OnPropertyChanged("lk_sdkmessageprocessingstep_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_sdkmessageprocessingstep_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_sdkmessageprocessingstep_modifiedonbehalfby")]
        public IEnumerable<SdkMessageProcessingStep> lk_sdkmessageprocessingstep_modifiedonbehalfby
        {
            get
            {
                return GetRelatedEntities<SdkMessageProcessingStep>("lk_sdkmessageprocessingstep_modifiedonbehalfby",
                    null);
            }
            set
            {
                OnPropertyChanging("lk_sdkmessageprocessingstep_modifiedonbehalfby");
                SetRelatedEntities("lk_sdkmessageprocessingstep_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_sdkmessageprocessingstep_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_sdkmessageprocessingstepimage_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_sdkmessageprocessingstepimage_createdonbehalfby")]
        public IEnumerable<SdkMessageProcessingStepImage> lk_sdkmessageprocessingstepimage_createdonbehalfby
        {
            get
            {
                return
                    GetRelatedEntities<SdkMessageProcessingStepImage>(
                        "lk_sdkmessageprocessingstepimage_createdonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_sdkmessageprocessingstepimage_createdonbehalfby");
                SetRelatedEntities("lk_sdkmessageprocessingstepimage_createdonbehalfby", null, value);
                OnPropertyChanged("lk_sdkmessageprocessingstepimage_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_sdkmessageprocessingstepimage_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_sdkmessageprocessingstepimage_modifiedonbehalfby")]
        public IEnumerable<SdkMessageProcessingStepImage> lk_sdkmessageprocessingstepimage_modifiedonbehalfby
        {
            get
            {
                return
                    GetRelatedEntities<SdkMessageProcessingStepImage>(
                        "lk_sdkmessageprocessingstepimage_modifiedonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_sdkmessageprocessingstepimage_modifiedonbehalfby");
                SetRelatedEntities("lk_sdkmessageprocessingstepimage_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_sdkmessageprocessingstepimage_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby")]
        public IEnumerable<SdkMessageProcessingStepSecureConfig>
            lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby
        {
            get
            {
                return
                    GetRelatedEntities<SdkMessageProcessingStepSecureConfig>(
                        "lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby");
                SetRelatedEntities("lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby", null, value);
                OnPropertyChanged("lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby")]
        public IEnumerable<SdkMessageProcessingStepSecureConfig>
            lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby
        {
            get
            {
                return
                    GetRelatedEntities<SdkMessageProcessingStepSecureConfig>(
                        "lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby");
                SetRelatedEntities("lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_sdkmessagerequest_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_sdkmessagerequest_createdonbehalfby")]
        public IEnumerable<SdkMessageRequest> lk_sdkmessagerequest_createdonbehalfby
        {
            get { return GetRelatedEntities<SdkMessageRequest>("lk_sdkmessagerequest_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_sdkmessagerequest_createdonbehalfby");
                SetRelatedEntities("lk_sdkmessagerequest_createdonbehalfby", null, value);
                OnPropertyChanged("lk_sdkmessagerequest_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_sdkmessagerequest_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_sdkmessagerequest_modifiedonbehalfby")]
        public IEnumerable<SdkMessageRequest> lk_sdkmessagerequest_modifiedonbehalfby
        {
            get { return GetRelatedEntities<SdkMessageRequest>("lk_sdkmessagerequest_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_sdkmessagerequest_modifiedonbehalfby");
                SetRelatedEntities("lk_sdkmessagerequest_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_sdkmessagerequest_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_sdkmessagerequestfield_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_sdkmessagerequestfield_createdonbehalfby")]
        public IEnumerable<SdkMessageRequestField> lk_sdkmessagerequestfield_createdonbehalfby
        {
            get
            {
                return GetRelatedEntities<SdkMessageRequestField>("lk_sdkmessagerequestfield_createdonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_sdkmessagerequestfield_createdonbehalfby");
                SetRelatedEntities("lk_sdkmessagerequestfield_createdonbehalfby", null, value);
                OnPropertyChanged("lk_sdkmessagerequestfield_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_sdkmessagerequestfield_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_sdkmessagerequestfield_modifiedonbehalfby")]
        public IEnumerable<SdkMessageRequestField> lk_sdkmessagerequestfield_modifiedonbehalfby
        {
            get
            {
                return GetRelatedEntities<SdkMessageRequestField>("lk_sdkmessagerequestfield_modifiedonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_sdkmessagerequestfield_modifiedonbehalfby");
                SetRelatedEntities("lk_sdkmessagerequestfield_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_sdkmessagerequestfield_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_sdkmessageresponse_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_sdkmessageresponse_createdonbehalfby")]
        public IEnumerable<SdkMessageResponse> lk_sdkmessageresponse_createdonbehalfby
        {
            get { return GetRelatedEntities<SdkMessageResponse>("lk_sdkmessageresponse_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_sdkmessageresponse_createdonbehalfby");
                SetRelatedEntities("lk_sdkmessageresponse_createdonbehalfby", null, value);
                OnPropertyChanged("lk_sdkmessageresponse_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_sdkmessageresponse_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_sdkmessageresponse_modifiedonbehalfby")]
        public IEnumerable<SdkMessageResponse> lk_sdkmessageresponse_modifiedonbehalfby
        {
            get { return GetRelatedEntities<SdkMessageResponse>("lk_sdkmessageresponse_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_sdkmessageresponse_modifiedonbehalfby");
                SetRelatedEntities("lk_sdkmessageresponse_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_sdkmessageresponse_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_sdkmessageresponsefield_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_sdkmessageresponsefield_createdonbehalfby")]
        public IEnumerable<SdkMessageResponseField> lk_sdkmessageresponsefield_createdonbehalfby
        {
            get
            {
                return GetRelatedEntities<SdkMessageResponseField>("lk_sdkmessageresponsefield_createdonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_sdkmessageresponsefield_createdonbehalfby");
                SetRelatedEntities("lk_sdkmessageresponsefield_createdonbehalfby", null, value);
                OnPropertyChanged("lk_sdkmessageresponsefield_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_sdkmessageresponsefield_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_sdkmessageresponsefield_modifiedonbehalfby")]
        public IEnumerable<SdkMessageResponseField> lk_sdkmessageresponsefield_modifiedonbehalfby
        {
            get
            {
                return GetRelatedEntities<SdkMessageResponseField>("lk_sdkmessageresponsefield_modifiedonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_sdkmessageresponsefield_modifiedonbehalfby");
                SetRelatedEntities("lk_sdkmessageresponsefield_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_sdkmessageresponsefield_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_semiannualfiscalcalendar_createdby
        /// </summary>
        [RelationshipSchemaName("lk_semiannualfiscalcalendar_createdby")]
        public IEnumerable<SemiAnnualFiscalCalendar> lk_semiannualfiscalcalendar_createdby
        {
            get { return GetRelatedEntities<SemiAnnualFiscalCalendar>("lk_semiannualfiscalcalendar_createdby", null); }
            set
            {
                OnPropertyChanging("lk_semiannualfiscalcalendar_createdby");
                SetRelatedEntities("lk_semiannualfiscalcalendar_createdby", null, value);
                OnPropertyChanged("lk_semiannualfiscalcalendar_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_semiannualfiscalcalendar_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_semiannualfiscalcalendar_createdonbehalfby")]
        public IEnumerable<SemiAnnualFiscalCalendar> lk_semiannualfiscalcalendar_createdonbehalfby
        {
            get
            {
                return GetRelatedEntities<SemiAnnualFiscalCalendar>("lk_semiannualfiscalcalendar_createdonbehalfby",
                    null);
            }
            set
            {
                OnPropertyChanging("lk_semiannualfiscalcalendar_createdonbehalfby");
                SetRelatedEntities("lk_semiannualfiscalcalendar_createdonbehalfby", null, value);
                OnPropertyChanged("lk_semiannualfiscalcalendar_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_semiannualfiscalcalendar_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_semiannualfiscalcalendar_modifiedby")]
        public IEnumerable<SemiAnnualFiscalCalendar> lk_semiannualfiscalcalendar_modifiedby
        {
            get { return GetRelatedEntities<SemiAnnualFiscalCalendar>("lk_semiannualfiscalcalendar_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_semiannualfiscalcalendar_modifiedby");
                SetRelatedEntities("lk_semiannualfiscalcalendar_modifiedby", null, value);
                OnPropertyChanged("lk_semiannualfiscalcalendar_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_semiannualfiscalcalendar_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_semiannualfiscalcalendar_modifiedonbehalfby")]
        public IEnumerable<SemiAnnualFiscalCalendar> lk_semiannualfiscalcalendar_modifiedonbehalfby
        {
            get
            {
                return GetRelatedEntities<SemiAnnualFiscalCalendar>("lk_semiannualfiscalcalendar_modifiedonbehalfby",
                    null);
            }
            set
            {
                OnPropertyChanging("lk_semiannualfiscalcalendar_modifiedonbehalfby");
                SetRelatedEntities("lk_semiannualfiscalcalendar_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_semiannualfiscalcalendar_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_semiannualfiscalcalendar_salespersonid
        /// </summary>
        [RelationshipSchemaName("lk_semiannualfiscalcalendar_salespersonid")]
        public IEnumerable<SemiAnnualFiscalCalendar> lk_semiannualfiscalcalendar_salespersonid
        {
            get
            {
                return GetRelatedEntities<SemiAnnualFiscalCalendar>("lk_semiannualfiscalcalendar_salespersonid", null);
            }
            set
            {
                OnPropertyChanging("lk_semiannualfiscalcalendar_salespersonid");
                SetRelatedEntities("lk_semiannualfiscalcalendar_salespersonid", null, value);
                OnPropertyChanged("lk_semiannualfiscalcalendar_salespersonid");
            }
        }

        /// <summary>
        ///     1:N lk_service_createdby
        /// </summary>
        [RelationshipSchemaName("lk_service_createdby")]
        public IEnumerable<Service> lk_service_createdby
        {
            get { return GetRelatedEntities<Service>("lk_service_createdby", null); }
            set
            {
                OnPropertyChanging("lk_service_createdby");
                SetRelatedEntities("lk_service_createdby", null, value);
                OnPropertyChanged("lk_service_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_service_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_service_createdonbehalfby")]
        public IEnumerable<Service> lk_service_createdonbehalfby
        {
            get { return GetRelatedEntities<Service>("lk_service_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_service_createdonbehalfby");
                SetRelatedEntities("lk_service_createdonbehalfby", null, value);
                OnPropertyChanged("lk_service_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_service_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_service_modifiedby")]
        public IEnumerable<Service> lk_service_modifiedby
        {
            get { return GetRelatedEntities<Service>("lk_service_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_service_modifiedby");
                SetRelatedEntities("lk_service_modifiedby", null, value);
                OnPropertyChanged("lk_service_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_service_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_service_modifiedonbehalfby")]
        public IEnumerable<Service> lk_service_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Service>("lk_service_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_service_modifiedonbehalfby");
                SetRelatedEntities("lk_service_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_service_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_serviceappointment_createdby
        /// </summary>
        [RelationshipSchemaName("lk_serviceappointment_createdby")]
        public IEnumerable<ServiceAppointment> lk_serviceappointment_createdby
        {
            get { return GetRelatedEntities<ServiceAppointment>("lk_serviceappointment_createdby", null); }
            set
            {
                OnPropertyChanging("lk_serviceappointment_createdby");
                SetRelatedEntities("lk_serviceappointment_createdby", null, value);
                OnPropertyChanged("lk_serviceappointment_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_serviceappointment_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_serviceappointment_createdonbehalfby")]
        public IEnumerable<ServiceAppointment> lk_serviceappointment_createdonbehalfby
        {
            get { return GetRelatedEntities<ServiceAppointment>("lk_serviceappointment_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_serviceappointment_createdonbehalfby");
                SetRelatedEntities("lk_serviceappointment_createdonbehalfby", null, value);
                OnPropertyChanged("lk_serviceappointment_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_serviceappointment_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_serviceappointment_modifiedby")]
        public IEnumerable<ServiceAppointment> lk_serviceappointment_modifiedby
        {
            get { return GetRelatedEntities<ServiceAppointment>("lk_serviceappointment_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_serviceappointment_modifiedby");
                SetRelatedEntities("lk_serviceappointment_modifiedby", null, value);
                OnPropertyChanged("lk_serviceappointment_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_serviceappointment_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_serviceappointment_modifiedonbehalfby")]
        public IEnumerable<ServiceAppointment> lk_serviceappointment_modifiedonbehalfby
        {
            get { return GetRelatedEntities<ServiceAppointment>("lk_serviceappointment_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_serviceappointment_modifiedonbehalfby");
                SetRelatedEntities("lk_serviceappointment_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_serviceappointment_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_serviceendpointbase_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_serviceendpointbase_createdonbehalfby")]
        public IEnumerable<ServiceEndpoint> lk_serviceendpointbase_createdonbehalfby
        {
            get { return GetRelatedEntities<ServiceEndpoint>("lk_serviceendpointbase_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_serviceendpointbase_createdonbehalfby");
                SetRelatedEntities("lk_serviceendpointbase_createdonbehalfby", null, value);
                OnPropertyChanged("lk_serviceendpointbase_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_serviceendpointbase_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_serviceendpointbase_modifiedonbehalfby")]
        public IEnumerable<ServiceEndpoint> lk_serviceendpointbase_modifiedonbehalfby
        {
            get { return GetRelatedEntities<ServiceEndpoint>("lk_serviceendpointbase_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_serviceendpointbase_modifiedonbehalfby");
                SetRelatedEntities("lk_serviceendpointbase_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_serviceendpointbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_sharepointdocumentlocationbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_sharepointdocumentlocationbase_createdby")]
        public IEnumerable<SharePointDocumentLocation> lk_sharepointdocumentlocationbase_createdby
        {
            get
            {
                return GetRelatedEntities<SharePointDocumentLocation>("lk_sharepointdocumentlocationbase_createdby",
                    null);
            }
            set
            {
                OnPropertyChanging("lk_sharepointdocumentlocationbase_createdby");
                SetRelatedEntities("lk_sharepointdocumentlocationbase_createdby", null, value);
                OnPropertyChanged("lk_sharepointdocumentlocationbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_sharepointdocumentlocationbase_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_sharepointdocumentlocationbase_createdonbehalfby")]
        public IEnumerable<SharePointDocumentLocation> lk_sharepointdocumentlocationbase_createdonbehalfby
        {
            get
            {
                return
                    GetRelatedEntities<SharePointDocumentLocation>(
                        "lk_sharepointdocumentlocationbase_createdonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_sharepointdocumentlocationbase_createdonbehalfby");
                SetRelatedEntities("lk_sharepointdocumentlocationbase_createdonbehalfby", null, value);
                OnPropertyChanged("lk_sharepointdocumentlocationbase_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_sharepointdocumentlocationbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_sharepointdocumentlocationbase_modifiedby")]
        public IEnumerable<SharePointDocumentLocation> lk_sharepointdocumentlocationbase_modifiedby
        {
            get
            {
                return GetRelatedEntities<SharePointDocumentLocation>("lk_sharepointdocumentlocationbase_modifiedby",
                    null);
            }
            set
            {
                OnPropertyChanging("lk_sharepointdocumentlocationbase_modifiedby");
                SetRelatedEntities("lk_sharepointdocumentlocationbase_modifiedby", null, value);
                OnPropertyChanged("lk_sharepointdocumentlocationbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_sharepointdocumentlocationbase_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_sharepointdocumentlocationbase_modifiedonbehalfby")]
        public IEnumerable<SharePointDocumentLocation> lk_sharepointdocumentlocationbase_modifiedonbehalfby
        {
            get
            {
                return
                    GetRelatedEntities<SharePointDocumentLocation>(
                        "lk_sharepointdocumentlocationbase_modifiedonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_sharepointdocumentlocationbase_modifiedonbehalfby");
                SetRelatedEntities("lk_sharepointdocumentlocationbase_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_sharepointdocumentlocationbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_sharepointsitebase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_sharepointsitebase_createdby")]
        public IEnumerable<SharePointSite> lk_sharepointsitebase_createdby
        {
            get { return GetRelatedEntities<SharePointSite>("lk_sharepointsitebase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_sharepointsitebase_createdby");
                SetRelatedEntities("lk_sharepointsitebase_createdby", null, value);
                OnPropertyChanged("lk_sharepointsitebase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_sharepointsitebase_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_sharepointsitebase_createdonbehalfby")]
        public IEnumerable<SharePointSite> lk_sharepointsitebase_createdonbehalfby
        {
            get { return GetRelatedEntities<SharePointSite>("lk_sharepointsitebase_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_sharepointsitebase_createdonbehalfby");
                SetRelatedEntities("lk_sharepointsitebase_createdonbehalfby", null, value);
                OnPropertyChanged("lk_sharepointsitebase_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_sharepointsitebase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_sharepointsitebase_modifiedby")]
        public IEnumerable<SharePointSite> lk_sharepointsitebase_modifiedby
        {
            get { return GetRelatedEntities<SharePointSite>("lk_sharepointsitebase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_sharepointsitebase_modifiedby");
                SetRelatedEntities("lk_sharepointsitebase_modifiedby", null, value);
                OnPropertyChanged("lk_sharepointsitebase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_sharepointsitebase_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_sharepointsitebase_modifiedonbehalfby")]
        public IEnumerable<SharePointSite> lk_sharepointsitebase_modifiedonbehalfby
        {
            get { return GetRelatedEntities<SharePointSite>("lk_sharepointsitebase_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_sharepointsitebase_modifiedonbehalfby");
                SetRelatedEntities("lk_sharepointsitebase_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_sharepointsitebase_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_site_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_site_createdonbehalfby")]
        public IEnumerable<Site> lk_site_createdonbehalfby
        {
            get { return GetRelatedEntities<Site>("lk_site_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_site_createdonbehalfby");
                SetRelatedEntities("lk_site_createdonbehalfby", null, value);
                OnPropertyChanged("lk_site_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_site_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_site_modifiedonbehalfby")]
        public IEnumerable<Site> lk_site_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Site>("lk_site_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_site_modifiedonbehalfby");
                SetRelatedEntities("lk_site_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_site_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_sitebase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_sitebase_createdby")]
        public IEnumerable<Site> lk_sitebase_createdby
        {
            get { return GetRelatedEntities<Site>("lk_sitebase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_sitebase_createdby");
                SetRelatedEntities("lk_sitebase_createdby", null, value);
                OnPropertyChanged("lk_sitebase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_sitebase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_sitebase_modifiedby")]
        public IEnumerable<Site> lk_sitebase_modifiedby
        {
            get { return GetRelatedEntities<Site>("lk_sitebase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_sitebase_modifiedby");
                SetRelatedEntities("lk_sitebase_modifiedby", null, value);
                OnPropertyChanged("lk_sitebase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_solution_createdby
        /// </summary>
        [RelationshipSchemaName("lk_solution_createdby")]
        public IEnumerable<Solution> lk_solution_createdby
        {
            get { return GetRelatedEntities<Solution>("lk_solution_createdby", null); }
            set
            {
                OnPropertyChanging("lk_solution_createdby");
                SetRelatedEntities("lk_solution_createdby", null, value);
                OnPropertyChanged("lk_solution_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_solution_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_solution_modifiedby")]
        public IEnumerable<Solution> lk_solution_modifiedby
        {
            get { return GetRelatedEntities<Solution>("lk_solution_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_solution_modifiedby");
                SetRelatedEntities("lk_solution_modifiedby", null, value);
                OnPropertyChanged("lk_solution_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_solutionbase_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_solutionbase_createdonbehalfby")]
        public IEnumerable<Solution> lk_solutionbase_createdonbehalfby
        {
            get { return GetRelatedEntities<Solution>("lk_solutionbase_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_solutionbase_createdonbehalfby");
                SetRelatedEntities("lk_solutionbase_createdonbehalfby", null, value);
                OnPropertyChanged("lk_solutionbase_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_solutionbase_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_solutionbase_modifiedonbehalfby")]
        public IEnumerable<Solution> lk_solutionbase_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Solution>("lk_solutionbase_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_solutionbase_modifiedonbehalfby");
                SetRelatedEntities("lk_solutionbase_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_solutionbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_solutioncomponentbase_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_solutioncomponentbase_createdonbehalfby")]
        public IEnumerable<SolutionComponent> lk_solutioncomponentbase_createdonbehalfby
        {
            get { return GetRelatedEntities<SolutionComponent>("lk_solutioncomponentbase_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_solutioncomponentbase_createdonbehalfby");
                SetRelatedEntities("lk_solutioncomponentbase_createdonbehalfby", null, value);
                OnPropertyChanged("lk_solutioncomponentbase_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_solutioncomponentbase_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_solutioncomponentbase_modifiedonbehalfby")]
        public IEnumerable<SolutionComponent> lk_solutioncomponentbase_modifiedonbehalfby
        {
            get { return GetRelatedEntities<SolutionComponent>("lk_solutioncomponentbase_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_solutioncomponentbase_modifiedonbehalfby");
                SetRelatedEntities("lk_solutioncomponentbase_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_solutioncomponentbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_subject_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_subject_createdonbehalfby")]
        public IEnumerable<Subject> lk_subject_createdonbehalfby
        {
            get { return GetRelatedEntities<Subject>("lk_subject_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_subject_createdonbehalfby");
                SetRelatedEntities("lk_subject_createdonbehalfby", null, value);
                OnPropertyChanged("lk_subject_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_subject_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_subject_modifiedonbehalfby")]
        public IEnumerable<Subject> lk_subject_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Subject>("lk_subject_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_subject_modifiedonbehalfby");
                SetRelatedEntities("lk_subject_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_subject_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_subjectbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_subjectbase_createdby")]
        public IEnumerable<Subject> lk_subjectbase_createdby
        {
            get { return GetRelatedEntities<Subject>("lk_subjectbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_subjectbase_createdby");
                SetRelatedEntities("lk_subjectbase_createdby", null, value);
                OnPropertyChanged("lk_subjectbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_subjectbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_subjectbase_modifiedby")]
        public IEnumerable<Subject> lk_subjectbase_modifiedby
        {
            get { return GetRelatedEntities<Subject>("lk_subjectbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_subjectbase_modifiedby");
                SetRelatedEntities("lk_subjectbase_modifiedby", null, value);
                OnPropertyChanged("lk_subjectbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_systemuser_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_systemuser_createdonbehalfby", EntityRole.Referenced)]
        public IEnumerable<SystemUser> Referencedlk_systemuser_createdonbehalfby
        {
            get { return GetRelatedEntities<SystemUser>("lk_systemuser_createdonbehalfby", EntityRole.Referenced); }
            set
            {
                OnPropertyChanging("Referencedlk_systemuser_createdonbehalfby");
                SetRelatedEntities("lk_systemuser_createdonbehalfby", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedlk_systemuser_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_systemuser_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_systemuser_modifiedonbehalfby", EntityRole.Referenced)]
        public IEnumerable<SystemUser> Referencedlk_systemuser_modifiedonbehalfby
        {
            get { return GetRelatedEntities<SystemUser>("lk_systemuser_modifiedonbehalfby", EntityRole.Referenced); }
            set
            {
                OnPropertyChanging("Referencedlk_systemuser_modifiedonbehalfby");
                SetRelatedEntities("lk_systemuser_modifiedonbehalfby", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedlk_systemuser_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_systemuserbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_systemuserbase_createdby", EntityRole.Referenced)]
        public IEnumerable<SystemUser> Referencedlk_systemuserbase_createdby
        {
            get { return GetRelatedEntities<SystemUser>("lk_systemuserbase_createdby", EntityRole.Referenced); }
            set
            {
                OnPropertyChanging("Referencedlk_systemuserbase_createdby");
                SetRelatedEntities("lk_systemuserbase_createdby", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedlk_systemuserbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_systemuserbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_systemuserbase_modifiedby", EntityRole.Referenced)]
        public IEnumerable<SystemUser> Referencedlk_systemuserbase_modifiedby
        {
            get { return GetRelatedEntities<SystemUser>("lk_systemuserbase_modifiedby", EntityRole.Referenced); }
            set
            {
                OnPropertyChanging("Referencedlk_systemuserbase_modifiedby");
                SetRelatedEntities("lk_systemuserbase_modifiedby", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedlk_systemuserbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_task_createdby
        /// </summary>
        [RelationshipSchemaName("lk_task_createdby")]
        public IEnumerable<Task> lk_task_createdby
        {
            get { return GetRelatedEntities<Task>("lk_task_createdby", null); }
            set
            {
                OnPropertyChanging("lk_task_createdby");
                SetRelatedEntities("lk_task_createdby", null, value);
                OnPropertyChanged("lk_task_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_task_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_task_createdonbehalfby")]
        public IEnumerable<Task> lk_task_createdonbehalfby
        {
            get { return GetRelatedEntities<Task>("lk_task_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_task_createdonbehalfby");
                SetRelatedEntities("lk_task_createdonbehalfby", null, value);
                OnPropertyChanged("lk_task_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_task_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_task_modifiedby")]
        public IEnumerable<Task> lk_task_modifiedby
        {
            get { return GetRelatedEntities<Task>("lk_task_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_task_modifiedby");
                SetRelatedEntities("lk_task_modifiedby", null, value);
                OnPropertyChanged("lk_task_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_task_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_task_modifiedonbehalfby")]
        public IEnumerable<Task> lk_task_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Task>("lk_task_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_task_modifiedonbehalfby");
                SetRelatedEntities("lk_task_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_task_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_team_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_team_createdonbehalfby")]
        public IEnumerable<Team> lk_team_createdonbehalfby
        {
            get { return GetRelatedEntities<Team>("lk_team_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_team_createdonbehalfby");
                SetRelatedEntities("lk_team_createdonbehalfby", null, value);
                OnPropertyChanged("lk_team_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_team_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_team_modifiedonbehalfby")]
        public IEnumerable<Team> lk_team_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Team>("lk_team_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_team_modifiedonbehalfby");
                SetRelatedEntities("lk_team_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_team_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_teambase_administratorid
        /// </summary>
        [RelationshipSchemaName("lk_teambase_administratorid")]
        public IEnumerable<Team> lk_teambase_administratorid
        {
            get { return GetRelatedEntities<Team>("lk_teambase_administratorid", null); }
            set
            {
                OnPropertyChanging("lk_teambase_administratorid");
                SetRelatedEntities("lk_teambase_administratorid", null, value);
                OnPropertyChanged("lk_teambase_administratorid");
            }
        }

        /// <summary>
        ///     1:N lk_teambase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_teambase_createdby")]
        public IEnumerable<Team> lk_teambase_createdby
        {
            get { return GetRelatedEntities<Team>("lk_teambase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_teambase_createdby");
                SetRelatedEntities("lk_teambase_createdby", null, value);
                OnPropertyChanged("lk_teambase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_teambase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_teambase_modifiedby")]
        public IEnumerable<Team> lk_teambase_modifiedby
        {
            get { return GetRelatedEntities<Team>("lk_teambase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_teambase_modifiedby");
                SetRelatedEntities("lk_teambase_modifiedby", null, value);
                OnPropertyChanged("lk_teambase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_teamtemplate_createdby
        /// </summary>
        [RelationshipSchemaName("lk_teamtemplate_createdby")]
        public IEnumerable<TeamTemplate> lk_teamtemplate_createdby
        {
            get { return GetRelatedEntities<TeamTemplate>("lk_teamtemplate_createdby", null); }
            set
            {
                OnPropertyChanging("lk_teamtemplate_createdby");
                SetRelatedEntities("lk_teamtemplate_createdby", null, value);
                OnPropertyChanged("lk_teamtemplate_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_teamtemplate_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_teamtemplate_createdonbehalfby")]
        public IEnumerable<TeamTemplate> lk_teamtemplate_createdonbehalfby
        {
            get { return GetRelatedEntities<TeamTemplate>("lk_teamtemplate_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_teamtemplate_createdonbehalfby");
                SetRelatedEntities("lk_teamtemplate_createdonbehalfby", null, value);
                OnPropertyChanged("lk_teamtemplate_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_teamtemplate_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_teamtemplate_modifiedby")]
        public IEnumerable<TeamTemplate> lk_teamtemplate_modifiedby
        {
            get { return GetRelatedEntities<TeamTemplate>("lk_teamtemplate_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_teamtemplate_modifiedby");
                SetRelatedEntities("lk_teamtemplate_modifiedby", null, value);
                OnPropertyChanged("lk_teamtemplate_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_teamtemplate_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_teamtemplate_modifiedonbehalfby")]
        public IEnumerable<TeamTemplate> lk_teamtemplate_modifiedonbehalfby
        {
            get { return GetRelatedEntities<TeamTemplate>("lk_teamtemplate_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_teamtemplate_modifiedonbehalfby");
                SetRelatedEntities("lk_teamtemplate_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_teamtemplate_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_templatebase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_templatebase_createdby")]
        public IEnumerable<Template> lk_templatebase_createdby
        {
            get { return GetRelatedEntities<Template>("lk_templatebase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_templatebase_createdby");
                SetRelatedEntities("lk_templatebase_createdby", null, value);
                OnPropertyChanged("lk_templatebase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_templatebase_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_templatebase_createdonbehalfby")]
        public IEnumerable<Template> lk_templatebase_createdonbehalfby
        {
            get { return GetRelatedEntities<Template>("lk_templatebase_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_templatebase_createdonbehalfby");
                SetRelatedEntities("lk_templatebase_createdonbehalfby", null, value);
                OnPropertyChanged("lk_templatebase_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_templatebase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_templatebase_modifiedby")]
        public IEnumerable<Template> lk_templatebase_modifiedby
        {
            get { return GetRelatedEntities<Template>("lk_templatebase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_templatebase_modifiedby");
                SetRelatedEntities("lk_templatebase_modifiedby", null, value);
                OnPropertyChanged("lk_templatebase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_templatebase_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_templatebase_modifiedonbehalfby")]
        public IEnumerable<Template> lk_templatebase_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Template>("lk_templatebase_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_templatebase_modifiedonbehalfby");
                SetRelatedEntities("lk_templatebase_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_templatebase_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_territory_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_territory_createdonbehalfby")]
        public IEnumerable<Territory> lk_territory_createdonbehalfby
        {
            get { return GetRelatedEntities<Territory>("lk_territory_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_territory_createdonbehalfby");
                SetRelatedEntities("lk_territory_createdonbehalfby", null, value);
                OnPropertyChanged("lk_territory_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_territory_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_territory_modifiedonbehalfby")]
        public IEnumerable<Territory> lk_territory_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Territory>("lk_territory_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_territory_modifiedonbehalfby");
                SetRelatedEntities("lk_territory_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_territory_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_territorybase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_territorybase_createdby")]
        public IEnumerable<Territory> lk_territorybase_createdby
        {
            get { return GetRelatedEntities<Territory>("lk_territorybase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_territorybase_createdby");
                SetRelatedEntities("lk_territorybase_createdby", null, value);
                OnPropertyChanged("lk_territorybase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_territorybase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_territorybase_modifiedby")]
        public IEnumerable<Territory> lk_territorybase_modifiedby
        {
            get { return GetRelatedEntities<Territory>("lk_territorybase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_territorybase_modifiedby");
                SetRelatedEntities("lk_territorybase_modifiedby", null, value);
                OnPropertyChanged("lk_territorybase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_timezonedefinition_createdby
        /// </summary>
        [RelationshipSchemaName("lk_timezonedefinition_createdby")]
        public IEnumerable<TimeZoneDefinition> lk_timezonedefinition_createdby
        {
            get { return GetRelatedEntities<TimeZoneDefinition>("lk_timezonedefinition_createdby", null); }
            set
            {
                OnPropertyChanging("lk_timezonedefinition_createdby");
                SetRelatedEntities("lk_timezonedefinition_createdby", null, value);
                OnPropertyChanged("lk_timezonedefinition_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_timezonedefinition_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_timezonedefinition_createdonbehalfby")]
        public IEnumerable<TimeZoneDefinition> lk_timezonedefinition_createdonbehalfby
        {
            get { return GetRelatedEntities<TimeZoneDefinition>("lk_timezonedefinition_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_timezonedefinition_createdonbehalfby");
                SetRelatedEntities("lk_timezonedefinition_createdonbehalfby", null, value);
                OnPropertyChanged("lk_timezonedefinition_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_timezonedefinition_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_timezonedefinition_modifiedby")]
        public IEnumerable<TimeZoneDefinition> lk_timezonedefinition_modifiedby
        {
            get { return GetRelatedEntities<TimeZoneDefinition>("lk_timezonedefinition_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_timezonedefinition_modifiedby");
                SetRelatedEntities("lk_timezonedefinition_modifiedby", null, value);
                OnPropertyChanged("lk_timezonedefinition_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_timezonedefinition_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_timezonedefinition_modifiedonbehalfby")]
        public IEnumerable<TimeZoneDefinition> lk_timezonedefinition_modifiedonbehalfby
        {
            get { return GetRelatedEntities<TimeZoneDefinition>("lk_timezonedefinition_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_timezonedefinition_modifiedonbehalfby");
                SetRelatedEntities("lk_timezonedefinition_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_timezonedefinition_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_timezonelocalizedname_createdby
        /// </summary>
        [RelationshipSchemaName("lk_timezonelocalizedname_createdby")]
        public IEnumerable<TimeZoneLocalizedName> lk_timezonelocalizedname_createdby
        {
            get { return GetRelatedEntities<TimeZoneLocalizedName>("lk_timezonelocalizedname_createdby", null); }
            set
            {
                OnPropertyChanging("lk_timezonelocalizedname_createdby");
                SetRelatedEntities("lk_timezonelocalizedname_createdby", null, value);
                OnPropertyChanged("lk_timezonelocalizedname_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_timezonelocalizedname_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_timezonelocalizedname_createdonbehalfby")]
        public IEnumerable<TimeZoneLocalizedName> lk_timezonelocalizedname_createdonbehalfby
        {
            get
            {
                return GetRelatedEntities<TimeZoneLocalizedName>("lk_timezonelocalizedname_createdonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_timezonelocalizedname_createdonbehalfby");
                SetRelatedEntities("lk_timezonelocalizedname_createdonbehalfby", null, value);
                OnPropertyChanged("lk_timezonelocalizedname_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_timezonelocalizedname_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_timezonelocalizedname_modifiedby")]
        public IEnumerable<TimeZoneLocalizedName> lk_timezonelocalizedname_modifiedby
        {
            get { return GetRelatedEntities<TimeZoneLocalizedName>("lk_timezonelocalizedname_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_timezonelocalizedname_modifiedby");
                SetRelatedEntities("lk_timezonelocalizedname_modifiedby", null, value);
                OnPropertyChanged("lk_timezonelocalizedname_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_timezonelocalizedname_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_timezonelocalizedname_modifiedonbehalfby")]
        public IEnumerable<TimeZoneLocalizedName> lk_timezonelocalizedname_modifiedonbehalfby
        {
            get
            {
                return GetRelatedEntities<TimeZoneLocalizedName>("lk_timezonelocalizedname_modifiedonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_timezonelocalizedname_modifiedonbehalfby");
                SetRelatedEntities("lk_timezonelocalizedname_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_timezonelocalizedname_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_timezonerule_createdby
        /// </summary>
        [RelationshipSchemaName("lk_timezonerule_createdby")]
        public IEnumerable<TimeZoneRule> lk_timezonerule_createdby
        {
            get { return GetRelatedEntities<TimeZoneRule>("lk_timezonerule_createdby", null); }
            set
            {
                OnPropertyChanging("lk_timezonerule_createdby");
                SetRelatedEntities("lk_timezonerule_createdby", null, value);
                OnPropertyChanged("lk_timezonerule_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_timezonerule_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_timezonerule_createdonbehalfby")]
        public IEnumerable<TimeZoneRule> lk_timezonerule_createdonbehalfby
        {
            get { return GetRelatedEntities<TimeZoneRule>("lk_timezonerule_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_timezonerule_createdonbehalfby");
                SetRelatedEntities("lk_timezonerule_createdonbehalfby", null, value);
                OnPropertyChanged("lk_timezonerule_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_timezonerule_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_timezonerule_modifiedby")]
        public IEnumerable<TimeZoneRule> lk_timezonerule_modifiedby
        {
            get { return GetRelatedEntities<TimeZoneRule>("lk_timezonerule_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_timezonerule_modifiedby");
                SetRelatedEntities("lk_timezonerule_modifiedby", null, value);
                OnPropertyChanged("lk_timezonerule_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_timezonerule_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_timezonerule_modifiedonbehalfby")]
        public IEnumerable<TimeZoneRule> lk_timezonerule_modifiedonbehalfby
        {
            get { return GetRelatedEntities<TimeZoneRule>("lk_timezonerule_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_timezonerule_modifiedonbehalfby");
                SetRelatedEntities("lk_timezonerule_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_timezonerule_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_tracelog_createdby
        /// </summary>
        [RelationshipSchemaName("lk_tracelog_createdby")]
        public IEnumerable<TraceLog> lk_tracelog_createdby
        {
            get { return GetRelatedEntities<TraceLog>("lk_tracelog_createdby", null); }
            set
            {
                OnPropertyChanging("lk_tracelog_createdby");
                SetRelatedEntities("lk_tracelog_createdby", null, value);
                OnPropertyChanged("lk_tracelog_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_tracelog_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_tracelog_createdonbehalfby")]
        public IEnumerable<TraceLog> lk_tracelog_createdonbehalfby
        {
            get { return GetRelatedEntities<TraceLog>("lk_tracelog_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_tracelog_createdonbehalfby");
                SetRelatedEntities("lk_tracelog_createdonbehalfby", null, value);
                OnPropertyChanged("lk_tracelog_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_tracelog_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_tracelog_modifiedby")]
        public IEnumerable<TraceLog> lk_tracelog_modifiedby
        {
            get { return GetRelatedEntities<TraceLog>("lk_tracelog_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_tracelog_modifiedby");
                SetRelatedEntities("lk_tracelog_modifiedby", null, value);
                OnPropertyChanged("lk_tracelog_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_tracelog_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_tracelog_modifiedonbehalfby")]
        public IEnumerable<TraceLog> lk_tracelog_modifiedonbehalfby
        {
            get { return GetRelatedEntities<TraceLog>("lk_tracelog_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_tracelog_modifiedonbehalfby");
                SetRelatedEntities("lk_tracelog_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_tracelog_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_transactioncurrency_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_transactioncurrency_createdonbehalfby")]
        public IEnumerable<TransactionCurrency> lk_transactioncurrency_createdonbehalfby
        {
            get { return GetRelatedEntities<TransactionCurrency>("lk_transactioncurrency_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_transactioncurrency_createdonbehalfby");
                SetRelatedEntities("lk_transactioncurrency_createdonbehalfby", null, value);
                OnPropertyChanged("lk_transactioncurrency_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_transactioncurrency_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_transactioncurrency_modifiedonbehalfby")]
        public IEnumerable<TransactionCurrency> lk_transactioncurrency_modifiedonbehalfby
        {
            get { return GetRelatedEntities<TransactionCurrency>("lk_transactioncurrency_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_transactioncurrency_modifiedonbehalfby");
                SetRelatedEntities("lk_transactioncurrency_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_transactioncurrency_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_transactioncurrencybase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_transactioncurrencybase_createdby")]
        public IEnumerable<TransactionCurrency> lk_transactioncurrencybase_createdby
        {
            get { return GetRelatedEntities<TransactionCurrency>("lk_transactioncurrencybase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_transactioncurrencybase_createdby");
                SetRelatedEntities("lk_transactioncurrencybase_createdby", null, value);
                OnPropertyChanged("lk_transactioncurrencybase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_transactioncurrencybase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_transactioncurrencybase_modifiedby")]
        public IEnumerable<TransactionCurrency> lk_transactioncurrencybase_modifiedby
        {
            get { return GetRelatedEntities<TransactionCurrency>("lk_transactioncurrencybase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_transactioncurrencybase_modifiedby");
                SetRelatedEntities("lk_transactioncurrencybase_modifiedby", null, value);
                OnPropertyChanged("lk_transactioncurrencybase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_transformationmapping_createdby
        /// </summary>
        [RelationshipSchemaName("lk_transformationmapping_createdby")]
        public IEnumerable<TransformationMapping> lk_transformationmapping_createdby
        {
            get { return GetRelatedEntities<TransformationMapping>("lk_transformationmapping_createdby", null); }
            set
            {
                OnPropertyChanging("lk_transformationmapping_createdby");
                SetRelatedEntities("lk_transformationmapping_createdby", null, value);
                OnPropertyChanged("lk_transformationmapping_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_transformationmapping_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_transformationmapping_createdonbehalfby")]
        public IEnumerable<TransformationMapping> lk_transformationmapping_createdonbehalfby
        {
            get
            {
                return GetRelatedEntities<TransformationMapping>("lk_transformationmapping_createdonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_transformationmapping_createdonbehalfby");
                SetRelatedEntities("lk_transformationmapping_createdonbehalfby", null, value);
                OnPropertyChanged("lk_transformationmapping_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_transformationmapping_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_transformationmapping_modifiedby")]
        public IEnumerable<TransformationMapping> lk_transformationmapping_modifiedby
        {
            get { return GetRelatedEntities<TransformationMapping>("lk_transformationmapping_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_transformationmapping_modifiedby");
                SetRelatedEntities("lk_transformationmapping_modifiedby", null, value);
                OnPropertyChanged("lk_transformationmapping_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_transformationmapping_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_transformationmapping_modifiedonbehalfby")]
        public IEnumerable<TransformationMapping> lk_transformationmapping_modifiedonbehalfby
        {
            get
            {
                return GetRelatedEntities<TransformationMapping>("lk_transformationmapping_modifiedonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_transformationmapping_modifiedonbehalfby");
                SetRelatedEntities("lk_transformationmapping_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_transformationmapping_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_transformationparametermapping_createdby
        /// </summary>
        [RelationshipSchemaName("lk_transformationparametermapping_createdby")]
        public IEnumerable<TransformationParameterMapping> lk_transformationparametermapping_createdby
        {
            get
            {
                return GetRelatedEntities<TransformationParameterMapping>(
                    "lk_transformationparametermapping_createdby", null);
            }
            set
            {
                OnPropertyChanging("lk_transformationparametermapping_createdby");
                SetRelatedEntities("lk_transformationparametermapping_createdby", null, value);
                OnPropertyChanged("lk_transformationparametermapping_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_transformationparametermapping_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_transformationparametermapping_createdonbehalfby")]
        public IEnumerable<TransformationParameterMapping> lk_transformationparametermapping_createdonbehalfby
        {
            get
            {
                return
                    GetRelatedEntities<TransformationParameterMapping>(
                        "lk_transformationparametermapping_createdonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_transformationparametermapping_createdonbehalfby");
                SetRelatedEntities("lk_transformationparametermapping_createdonbehalfby", null, value);
                OnPropertyChanged("lk_transformationparametermapping_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_transformationparametermapping_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_transformationparametermapping_modifiedby")]
        public IEnumerable<TransformationParameterMapping> lk_transformationparametermapping_modifiedby
        {
            get
            {
                return GetRelatedEntities<TransformationParameterMapping>(
                    "lk_transformationparametermapping_modifiedby", null);
            }
            set
            {
                OnPropertyChanging("lk_transformationparametermapping_modifiedby");
                SetRelatedEntities("lk_transformationparametermapping_modifiedby", null, value);
                OnPropertyChanged("lk_transformationparametermapping_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_transformationparametermapping_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_transformationparametermapping_modifiedonbehalfby")]
        public IEnumerable<TransformationParameterMapping> lk_transformationparametermapping_modifiedonbehalfby
        {
            get
            {
                return
                    GetRelatedEntities<TransformationParameterMapping>(
                        "lk_transformationparametermapping_modifiedonbehalfby", null);
            }
            set
            {
                OnPropertyChanging("lk_transformationparametermapping_modifiedonbehalfby");
                SetRelatedEntities("lk_transformationparametermapping_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_transformationparametermapping_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_uom_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_uom_createdonbehalfby")]
        public IEnumerable<UoM> lk_uom_createdonbehalfby
        {
            get { return GetRelatedEntities<UoM>("lk_uom_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_uom_createdonbehalfby");
                SetRelatedEntities("lk_uom_createdonbehalfby", null, value);
                OnPropertyChanged("lk_uom_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_uom_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_uom_modifiedonbehalfby")]
        public IEnumerable<UoM> lk_uom_modifiedonbehalfby
        {
            get { return GetRelatedEntities<UoM>("lk_uom_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_uom_modifiedonbehalfby");
                SetRelatedEntities("lk_uom_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_uom_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_uombase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_uombase_createdby")]
        public IEnumerable<UoM> lk_uombase_createdby
        {
            get { return GetRelatedEntities<UoM>("lk_uombase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_uombase_createdby");
                SetRelatedEntities("lk_uombase_createdby", null, value);
                OnPropertyChanged("lk_uombase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_uombase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_uombase_modifiedby")]
        public IEnumerable<UoM> lk_uombase_modifiedby
        {
            get { return GetRelatedEntities<UoM>("lk_uombase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_uombase_modifiedby");
                SetRelatedEntities("lk_uombase_modifiedby", null, value);
                OnPropertyChanged("lk_uombase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_uomschedule_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_uomschedule_createdonbehalfby")]
        public IEnumerable<UoMSchedule> lk_uomschedule_createdonbehalfby
        {
            get { return GetRelatedEntities<UoMSchedule>("lk_uomschedule_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_uomschedule_createdonbehalfby");
                SetRelatedEntities("lk_uomschedule_createdonbehalfby", null, value);
                OnPropertyChanged("lk_uomschedule_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_uomschedule_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_uomschedule_modifiedonbehalfby")]
        public IEnumerable<UoMSchedule> lk_uomschedule_modifiedonbehalfby
        {
            get { return GetRelatedEntities<UoMSchedule>("lk_uomschedule_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_uomschedule_modifiedonbehalfby");
                SetRelatedEntities("lk_uomschedule_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_uomschedule_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_uomschedulebase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_uomschedulebase_createdby")]
        public IEnumerable<UoMSchedule> lk_uomschedulebase_createdby
        {
            get { return GetRelatedEntities<UoMSchedule>("lk_uomschedulebase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_uomschedulebase_createdby");
                SetRelatedEntities("lk_uomschedulebase_createdby", null, value);
                OnPropertyChanged("lk_uomschedulebase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_uomschedulebase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_uomschedulebase_modifiedby")]
        public IEnumerable<UoMSchedule> lk_uomschedulebase_modifiedby
        {
            get { return GetRelatedEntities<UoMSchedule>("lk_uomschedulebase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_uomschedulebase_modifiedby");
                SetRelatedEntities("lk_uomschedulebase_modifiedby", null, value);
                OnPropertyChanged("lk_uomschedulebase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_userform_createdby
        /// </summary>
        [RelationshipSchemaName("lk_userform_createdby")]
        public IEnumerable<UserForm> lk_userform_createdby
        {
            get { return GetRelatedEntities<UserForm>("lk_userform_createdby", null); }
            set
            {
                OnPropertyChanging("lk_userform_createdby");
                SetRelatedEntities("lk_userform_createdby", null, value);
                OnPropertyChanged("lk_userform_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_userform_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_userform_modifiedby")]
        public IEnumerable<UserForm> lk_userform_modifiedby
        {
            get { return GetRelatedEntities<UserForm>("lk_userform_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_userform_modifiedby");
                SetRelatedEntities("lk_userform_modifiedby", null, value);
                OnPropertyChanged("lk_userform_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_userformbase_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_userformbase_createdonbehalfby")]
        public IEnumerable<UserForm> lk_userformbase_createdonbehalfby
        {
            get { return GetRelatedEntities<UserForm>("lk_userformbase_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_userformbase_createdonbehalfby");
                SetRelatedEntities("lk_userformbase_createdonbehalfby", null, value);
                OnPropertyChanged("lk_userformbase_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_userformbase_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_userformbase_modifiedonbehalfby")]
        public IEnumerable<UserForm> lk_userformbase_modifiedonbehalfby
        {
            get { return GetRelatedEntities<UserForm>("lk_userformbase_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_userformbase_modifiedonbehalfby");
                SetRelatedEntities("lk_userformbase_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_userformbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_userquery_createdby
        /// </summary>
        [RelationshipSchemaName("lk_userquery_createdby")]
        public IEnumerable<UserQuery> lk_userquery_createdby
        {
            get { return GetRelatedEntities<UserQuery>("lk_userquery_createdby", null); }
            set
            {
                OnPropertyChanging("lk_userquery_createdby");
                SetRelatedEntities("lk_userquery_createdby", null, value);
                OnPropertyChanged("lk_userquery_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_userquery_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_userquery_createdonbehalfby")]
        public IEnumerable<UserQuery> lk_userquery_createdonbehalfby
        {
            get { return GetRelatedEntities<UserQuery>("lk_userquery_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_userquery_createdonbehalfby");
                SetRelatedEntities("lk_userquery_createdonbehalfby", null, value);
                OnPropertyChanged("lk_userquery_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_userquery_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_userquery_modifiedby")]
        public IEnumerable<UserQuery> lk_userquery_modifiedby
        {
            get { return GetRelatedEntities<UserQuery>("lk_userquery_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_userquery_modifiedby");
                SetRelatedEntities("lk_userquery_modifiedby", null, value);
                OnPropertyChanged("lk_userquery_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_userquery_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_userquery_modifiedonbehalfby")]
        public IEnumerable<UserQuery> lk_userquery_modifiedonbehalfby
        {
            get { return GetRelatedEntities<UserQuery>("lk_userquery_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_userquery_modifiedonbehalfby");
                SetRelatedEntities("lk_userquery_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_userquery_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_userqueryvisualization_createdby
        /// </summary>
        [RelationshipSchemaName("lk_userqueryvisualization_createdby")]
        public IEnumerable<UserQueryVisualization> lk_userqueryvisualization_createdby
        {
            get { return GetRelatedEntities<UserQueryVisualization>("lk_userqueryvisualization_createdby", null); }
            set
            {
                OnPropertyChanging("lk_userqueryvisualization_createdby");
                SetRelatedEntities("lk_userqueryvisualization_createdby", null, value);
                OnPropertyChanged("lk_userqueryvisualization_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_userqueryvisualization_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_userqueryvisualization_modifiedby")]
        public IEnumerable<UserQueryVisualization> lk_userqueryvisualization_modifiedby
        {
            get { return GetRelatedEntities<UserQueryVisualization>("lk_userqueryvisualization_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_userqueryvisualization_modifiedby");
                SetRelatedEntities("lk_userqueryvisualization_modifiedby", null, value);
                OnPropertyChanged("lk_userqueryvisualization_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_userqueryvisualizationbase_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_userqueryvisualizationbase_createdonbehalfby")]
        public IEnumerable<UserQueryVisualization> lk_userqueryvisualizationbase_createdonbehalfby
        {
            get
            {
                return GetRelatedEntities<UserQueryVisualization>("lk_userqueryvisualizationbase_createdonbehalfby",
                    null);
            }
            set
            {
                OnPropertyChanging("lk_userqueryvisualizationbase_createdonbehalfby");
                SetRelatedEntities("lk_userqueryvisualizationbase_createdonbehalfby", null, value);
                OnPropertyChanged("lk_userqueryvisualizationbase_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_userqueryvisualizationbase_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_userqueryvisualizationbase_modifiedonbehalfby")]
        public IEnumerable<UserQueryVisualization> lk_userqueryvisualizationbase_modifiedonbehalfby
        {
            get
            {
                return GetRelatedEntities<UserQueryVisualization>("lk_userqueryvisualizationbase_modifiedonbehalfby",
                    null);
            }
            set
            {
                OnPropertyChanging("lk_userqueryvisualizationbase_modifiedonbehalfby");
                SetRelatedEntities("lk_userqueryvisualizationbase_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_userqueryvisualizationbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_usersettings_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_usersettings_createdonbehalfby")]
        public IEnumerable<UserSettings> lk_usersettings_createdonbehalfby
        {
            get { return GetRelatedEntities<UserSettings>("lk_usersettings_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_usersettings_createdonbehalfby");
                SetRelatedEntities("lk_usersettings_createdonbehalfby", null, value);
                OnPropertyChanged("lk_usersettings_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_usersettings_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_usersettings_modifiedonbehalfby")]
        public IEnumerable<UserSettings> lk_usersettings_modifiedonbehalfby
        {
            get { return GetRelatedEntities<UserSettings>("lk_usersettings_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_usersettings_modifiedonbehalfby");
                SetRelatedEntities("lk_usersettings_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_usersettings_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_usersettingsbase_createdby
        /// </summary>
        [RelationshipSchemaName("lk_usersettingsbase_createdby")]
        public IEnumerable<UserSettings> lk_usersettingsbase_createdby
        {
            get { return GetRelatedEntities<UserSettings>("lk_usersettingsbase_createdby", null); }
            set
            {
                OnPropertyChanging("lk_usersettingsbase_createdby");
                SetRelatedEntities("lk_usersettingsbase_createdby", null, value);
                OnPropertyChanged("lk_usersettingsbase_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_usersettingsbase_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_usersettingsbase_modifiedby")]
        public IEnumerable<UserSettings> lk_usersettingsbase_modifiedby
        {
            get { return GetRelatedEntities<UserSettings>("lk_usersettingsbase_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_usersettingsbase_modifiedby");
                SetRelatedEntities("lk_usersettingsbase_modifiedby", null, value);
                OnPropertyChanged("lk_usersettingsbase_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_webresourcebase_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_webresourcebase_createdonbehalfby")]
        public IEnumerable<WebResource> lk_webresourcebase_createdonbehalfby
        {
            get { return GetRelatedEntities<WebResource>("lk_webresourcebase_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_webresourcebase_createdonbehalfby");
                SetRelatedEntities("lk_webresourcebase_createdonbehalfby", null, value);
                OnPropertyChanged("lk_webresourcebase_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_webresourcebase_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_webresourcebase_modifiedonbehalfby")]
        public IEnumerable<WebResource> lk_webresourcebase_modifiedonbehalfby
        {
            get { return GetRelatedEntities<WebResource>("lk_webresourcebase_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_webresourcebase_modifiedonbehalfby");
                SetRelatedEntities("lk_webresourcebase_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_webresourcebase_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_workflowlog_createdby
        /// </summary>
        [RelationshipSchemaName("lk_workflowlog_createdby")]
        public IEnumerable<WorkflowLog> lk_workflowlog_createdby
        {
            get { return GetRelatedEntities<WorkflowLog>("lk_workflowlog_createdby", null); }
            set
            {
                OnPropertyChanging("lk_workflowlog_createdby");
                SetRelatedEntities("lk_workflowlog_createdby", null, value);
                OnPropertyChanged("lk_workflowlog_createdby");
            }
        }

        /// <summary>
        ///     1:N lk_workflowlog_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_workflowlog_createdonbehalfby")]
        public IEnumerable<WorkflowLog> lk_workflowlog_createdonbehalfby
        {
            get { return GetRelatedEntities<WorkflowLog>("lk_workflowlog_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_workflowlog_createdonbehalfby");
                SetRelatedEntities("lk_workflowlog_createdonbehalfby", null, value);
                OnPropertyChanged("lk_workflowlog_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N lk_workflowlog_modifiedby
        /// </summary>
        [RelationshipSchemaName("lk_workflowlog_modifiedby")]
        public IEnumerable<WorkflowLog> lk_workflowlog_modifiedby
        {
            get { return GetRelatedEntities<WorkflowLog>("lk_workflowlog_modifiedby", null); }
            set
            {
                OnPropertyChanging("lk_workflowlog_modifiedby");
                SetRelatedEntities("lk_workflowlog_modifiedby", null, value);
                OnPropertyChanged("lk_workflowlog_modifiedby");
            }
        }

        /// <summary>
        ///     1:N lk_workflowlog_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("lk_workflowlog_modifiedonbehalfby")]
        public IEnumerable<WorkflowLog> lk_workflowlog_modifiedonbehalfby
        {
            get { return GetRelatedEntities<WorkflowLog>("lk_workflowlog_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("lk_workflowlog_modifiedonbehalfby");
                SetRelatedEntities("lk_workflowlog_modifiedonbehalfby", null, value);
                OnPropertyChanged("lk_workflowlog_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N mailbox_regarding_systemuser
        /// </summary>
        [RelationshipSchemaName("mailbox_regarding_systemuser")]
        public IEnumerable<Mailbox> mailbox_regarding_systemuser
        {
            get { return GetRelatedEntities<Mailbox>("mailbox_regarding_systemuser", null); }
            set
            {
                OnPropertyChanging("mailbox_regarding_systemuser");
                SetRelatedEntities("mailbox_regarding_systemuser", null, value);
                OnPropertyChanged("mailbox_regarding_systemuser");
            }
        }

        /// <summary>
        ///     1:N modifiedby_attributemap
        /// </summary>
        [RelationshipSchemaName("modifiedby_attributemap")]
        public IEnumerable<AttributeMap> modifiedby_attributemap
        {
            get { return GetRelatedEntities<AttributeMap>("modifiedby_attributemap", null); }
            set
            {
                OnPropertyChanging("modifiedby_attributemap");
                SetRelatedEntities("modifiedby_attributemap", null, value);
                OnPropertyChanged("modifiedby_attributemap");
            }
        }

        /// <summary>
        ///     1:N modifiedby_connection
        /// </summary>
        [RelationshipSchemaName("modifiedby_connection")]
        public IEnumerable<Connection> modifiedby_connection
        {
            get { return GetRelatedEntities<Connection>("modifiedby_connection", null); }
            set
            {
                OnPropertyChanging("modifiedby_connection");
                SetRelatedEntities("modifiedby_connection", null, value);
                OnPropertyChanged("modifiedby_connection");
            }
        }

        /// <summary>
        ///     1:N modifiedby_connection_role
        /// </summary>
        [RelationshipSchemaName("modifiedby_connection_role")]
        public IEnumerable<ConnectionRole> modifiedby_connection_role
        {
            get { return GetRelatedEntities<ConnectionRole>("modifiedby_connection_role", null); }
            set
            {
                OnPropertyChanging("modifiedby_connection_role");
                SetRelatedEntities("modifiedby_connection_role", null, value);
                OnPropertyChanged("modifiedby_connection_role");
            }
        }

        /// <summary>
        ///     1:N modifiedby_customer_relationship
        /// </summary>
        [RelationshipSchemaName("modifiedby_customer_relationship")]
        public IEnumerable<CustomerRelationship> modifiedby_customer_relationship
        {
            get { return GetRelatedEntities<CustomerRelationship>("modifiedby_customer_relationship", null); }
            set
            {
                OnPropertyChanging("modifiedby_customer_relationship");
                SetRelatedEntities("modifiedby_customer_relationship", null, value);
                OnPropertyChanged("modifiedby_customer_relationship");
            }
        }

        /// <summary>
        ///     1:N modifiedby_entitymap
        /// </summary>
        [RelationshipSchemaName("modifiedby_entitymap")]
        public IEnumerable<EntityMap> modifiedby_entitymap
        {
            get { return GetRelatedEntities<EntityMap>("modifiedby_entitymap", null); }
            set
            {
                OnPropertyChanging("modifiedby_entitymap");
                SetRelatedEntities("modifiedby_entitymap", null, value);
                OnPropertyChanged("modifiedby_entitymap");
            }
        }

        /// <summary>
        ///     1:N modifiedby_pluginassembly
        /// </summary>
        [RelationshipSchemaName("modifiedby_pluginassembly")]
        public IEnumerable<PluginAssembly> modifiedby_pluginassembly
        {
            get { return GetRelatedEntities<PluginAssembly>("modifiedby_pluginassembly", null); }
            set
            {
                OnPropertyChanging("modifiedby_pluginassembly");
                SetRelatedEntities("modifiedby_pluginassembly", null, value);
                OnPropertyChanged("modifiedby_pluginassembly");
            }
        }

        /// <summary>
        ///     1:N modifiedby_plugintype
        /// </summary>
        [RelationshipSchemaName("modifiedby_plugintype")]
        public IEnumerable<PluginType> modifiedby_plugintype
        {
            get { return GetRelatedEntities<PluginType>("modifiedby_plugintype", null); }
            set
            {
                OnPropertyChanging("modifiedby_plugintype");
                SetRelatedEntities("modifiedby_plugintype", null, value);
                OnPropertyChanged("modifiedby_plugintype");
            }
        }

        /// <summary>
        ///     1:N modifiedby_plugintypestatistic
        /// </summary>
        [RelationshipSchemaName("modifiedby_plugintypestatistic")]
        public IEnumerable<PluginTypeStatistic> modifiedby_plugintypestatistic
        {
            get { return GetRelatedEntities<PluginTypeStatistic>("modifiedby_plugintypestatistic", null); }
            set
            {
                OnPropertyChanging("modifiedby_plugintypestatistic");
                SetRelatedEntities("modifiedby_plugintypestatistic", null, value);
                OnPropertyChanged("modifiedby_plugintypestatistic");
            }
        }

        /// <summary>
        ///     1:N modifiedby_relationship_role
        /// </summary>
        [RelationshipSchemaName("modifiedby_relationship_role")]
        public IEnumerable<RelationshipRole> modifiedby_relationship_role
        {
            get { return GetRelatedEntities<RelationshipRole>("modifiedby_relationship_role", null); }
            set
            {
                OnPropertyChanging("modifiedby_relationship_role");
                SetRelatedEntities("modifiedby_relationship_role", null, value);
                OnPropertyChanged("modifiedby_relationship_role");
            }
        }

        /// <summary>
        ///     1:N modifiedby_relationship_role_map
        /// </summary>
        [RelationshipSchemaName("modifiedby_relationship_role_map")]
        public IEnumerable<RelationshipRoleMap> modifiedby_relationship_role_map
        {
            get { return GetRelatedEntities<RelationshipRoleMap>("modifiedby_relationship_role_map", null); }
            set
            {
                OnPropertyChanging("modifiedby_relationship_role_map");
                SetRelatedEntities("modifiedby_relationship_role_map", null, value);
                OnPropertyChanged("modifiedby_relationship_role_map");
            }
        }

        /// <summary>
        ///     1:N modifiedby_sdkmessage
        /// </summary>
        [RelationshipSchemaName("modifiedby_sdkmessage")]
        public IEnumerable<SdkMessage> modifiedby_sdkmessage
        {
            get { return GetRelatedEntities<SdkMessage>("modifiedby_sdkmessage", null); }
            set
            {
                OnPropertyChanging("modifiedby_sdkmessage");
                SetRelatedEntities("modifiedby_sdkmessage", null, value);
                OnPropertyChanged("modifiedby_sdkmessage");
            }
        }

        /// <summary>
        ///     1:N modifiedby_sdkmessagefilter
        /// </summary>
        [RelationshipSchemaName("modifiedby_sdkmessagefilter")]
        public IEnumerable<SdkMessageFilter> modifiedby_sdkmessagefilter
        {
            get { return GetRelatedEntities<SdkMessageFilter>("modifiedby_sdkmessagefilter", null); }
            set
            {
                OnPropertyChanging("modifiedby_sdkmessagefilter");
                SetRelatedEntities("modifiedby_sdkmessagefilter", null, value);
                OnPropertyChanged("modifiedby_sdkmessagefilter");
            }
        }

        /// <summary>
        ///     1:N modifiedby_sdkmessagepair
        /// </summary>
        [RelationshipSchemaName("modifiedby_sdkmessagepair")]
        public IEnumerable<SdkMessagePair> modifiedby_sdkmessagepair
        {
            get { return GetRelatedEntities<SdkMessagePair>("modifiedby_sdkmessagepair", null); }
            set
            {
                OnPropertyChanging("modifiedby_sdkmessagepair");
                SetRelatedEntities("modifiedby_sdkmessagepair", null, value);
                OnPropertyChanged("modifiedby_sdkmessagepair");
            }
        }

        /// <summary>
        ///     1:N modifiedby_sdkmessageprocessingstep
        /// </summary>
        [RelationshipSchemaName("modifiedby_sdkmessageprocessingstep")]
        public IEnumerable<SdkMessageProcessingStep> modifiedby_sdkmessageprocessingstep
        {
            get { return GetRelatedEntities<SdkMessageProcessingStep>("modifiedby_sdkmessageprocessingstep", null); }
            set
            {
                OnPropertyChanging("modifiedby_sdkmessageprocessingstep");
                SetRelatedEntities("modifiedby_sdkmessageprocessingstep", null, value);
                OnPropertyChanged("modifiedby_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        ///     1:N modifiedby_sdkmessageprocessingstepimage
        /// </summary>
        [RelationshipSchemaName("modifiedby_sdkmessageprocessingstepimage")]
        public IEnumerable<SdkMessageProcessingStepImage> modifiedby_sdkmessageprocessingstepimage
        {
            get
            {
                return GetRelatedEntities<SdkMessageProcessingStepImage>("modifiedby_sdkmessageprocessingstepimage",
                    null);
            }
            set
            {
                OnPropertyChanging("modifiedby_sdkmessageprocessingstepimage");
                SetRelatedEntities("modifiedby_sdkmessageprocessingstepimage", null, value);
                OnPropertyChanged("modifiedby_sdkmessageprocessingstepimage");
            }
        }

        /// <summary>
        ///     1:N modifiedby_sdkmessageprocessingstepsecureconfig
        /// </summary>
        [RelationshipSchemaName("modifiedby_sdkmessageprocessingstepsecureconfig")]
        public IEnumerable<SdkMessageProcessingStepSecureConfig> modifiedby_sdkmessageprocessingstepsecureconfig
        {
            get
            {
                return
                    GetRelatedEntities<SdkMessageProcessingStepSecureConfig>(
                        "modifiedby_sdkmessageprocessingstepsecureconfig", null);
            }
            set
            {
                OnPropertyChanging("modifiedby_sdkmessageprocessingstepsecureconfig");
                SetRelatedEntities("modifiedby_sdkmessageprocessingstepsecureconfig", null, value);
                OnPropertyChanged("modifiedby_sdkmessageprocessingstepsecureconfig");
            }
        }

        /// <summary>
        ///     1:N modifiedby_sdkmessagerequest
        /// </summary>
        [RelationshipSchemaName("modifiedby_sdkmessagerequest")]
        public IEnumerable<SdkMessageRequest> modifiedby_sdkmessagerequest
        {
            get { return GetRelatedEntities<SdkMessageRequest>("modifiedby_sdkmessagerequest", null); }
            set
            {
                OnPropertyChanging("modifiedby_sdkmessagerequest");
                SetRelatedEntities("modifiedby_sdkmessagerequest", null, value);
                OnPropertyChanged("modifiedby_sdkmessagerequest");
            }
        }

        /// <summary>
        ///     1:N modifiedby_sdkmessagerequestfield
        /// </summary>
        [RelationshipSchemaName("modifiedby_sdkmessagerequestfield")]
        public IEnumerable<SdkMessageRequestField> modifiedby_sdkmessagerequestfield
        {
            get { return GetRelatedEntities<SdkMessageRequestField>("modifiedby_sdkmessagerequestfield", null); }
            set
            {
                OnPropertyChanging("modifiedby_sdkmessagerequestfield");
                SetRelatedEntities("modifiedby_sdkmessagerequestfield", null, value);
                OnPropertyChanged("modifiedby_sdkmessagerequestfield");
            }
        }

        /// <summary>
        ///     1:N modifiedby_sdkmessageresponse
        /// </summary>
        [RelationshipSchemaName("modifiedby_sdkmessageresponse")]
        public IEnumerable<SdkMessageResponse> modifiedby_sdkmessageresponse
        {
            get { return GetRelatedEntities<SdkMessageResponse>("modifiedby_sdkmessageresponse", null); }
            set
            {
                OnPropertyChanging("modifiedby_sdkmessageresponse");
                SetRelatedEntities("modifiedby_sdkmessageresponse", null, value);
                OnPropertyChanged("modifiedby_sdkmessageresponse");
            }
        }

        /// <summary>
        ///     1:N modifiedby_sdkmessageresponsefield
        /// </summary>
        [RelationshipSchemaName("modifiedby_sdkmessageresponsefield")]
        public IEnumerable<SdkMessageResponseField> modifiedby_sdkmessageresponsefield
        {
            get { return GetRelatedEntities<SdkMessageResponseField>("modifiedby_sdkmessageresponsefield", null); }
            set
            {
                OnPropertyChanging("modifiedby_sdkmessageresponsefield");
                SetRelatedEntities("modifiedby_sdkmessageresponsefield", null, value);
                OnPropertyChanged("modifiedby_sdkmessageresponsefield");
            }
        }

        /// <summary>
        ///     1:N modifiedby_serviceendpoint
        /// </summary>
        [RelationshipSchemaName("modifiedby_serviceendpoint")]
        public IEnumerable<ServiceEndpoint> modifiedby_serviceendpoint
        {
            get { return GetRelatedEntities<ServiceEndpoint>("modifiedby_serviceendpoint", null); }
            set
            {
                OnPropertyChanging("modifiedby_serviceendpoint");
                SetRelatedEntities("modifiedby_serviceendpoint", null, value);
                OnPropertyChanged("modifiedby_serviceendpoint");
            }
        }

        /// <summary>
        ///     1:N modifiedonbehalfby_attributemap
        /// </summary>
        [RelationshipSchemaName("modifiedonbehalfby_attributemap")]
        public IEnumerable<AttributeMap> modifiedonbehalfby_attributemap
        {
            get { return GetRelatedEntities<AttributeMap>("modifiedonbehalfby_attributemap", null); }
            set
            {
                OnPropertyChanging("modifiedonbehalfby_attributemap");
                SetRelatedEntities("modifiedonbehalfby_attributemap", null, value);
                OnPropertyChanged("modifiedonbehalfby_attributemap");
            }
        }

        /// <summary>
        ///     1:N modifiedonbehalfby_customer_relationship
        /// </summary>
        [RelationshipSchemaName("modifiedonbehalfby_customer_relationship")]
        public IEnumerable<CustomerRelationship> modifiedonbehalfby_customer_relationship
        {
            get { return GetRelatedEntities<CustomerRelationship>("modifiedonbehalfby_customer_relationship", null); }
            set
            {
                OnPropertyChanging("modifiedonbehalfby_customer_relationship");
                SetRelatedEntities("modifiedonbehalfby_customer_relationship", null, value);
                OnPropertyChanged("modifiedonbehalfby_customer_relationship");
            }
        }

        /// <summary>
        ///     1:N msdyn_systemuser_wallsavedqueryusersettings_userid
        /// </summary>
        [RelationshipSchemaName("msdyn_systemuser_wallsavedqueryusersettings_userid")]
        public IEnumerable<msdyn_wallsavedqueryusersettings> msdyn_systemuser_wallsavedqueryusersettings_userid
        {
            get
            {
                return
                    GetRelatedEntities<msdyn_wallsavedqueryusersettings>(
                        "msdyn_systemuser_wallsavedqueryusersettings_userid", null);
            }
            set
            {
                OnPropertyChanging("msdyn_systemuser_wallsavedqueryusersettings_userid");
                SetRelatedEntities("msdyn_systemuser_wallsavedqueryusersettings_userid", null, value);
                OnPropertyChanged("msdyn_systemuser_wallsavedqueryusersettings_userid");
            }
        }

        /// <summary>
        ///     1:N opportunity_owning_user
        /// </summary>
        [RelationshipSchemaName("opportunity_owning_user")]
        public IEnumerable<Opportunity> opportunity_owning_user
        {
            get { return GetRelatedEntities<Opportunity>("opportunity_owning_user", null); }
            set
            {
                OnPropertyChanging("opportunity_owning_user");
                SetRelatedEntities("opportunity_owning_user", null, value);
                OnPropertyChanged("opportunity_owning_user");
            }
        }

        /// <summary>
        ///     1:N OwnerMapping_SystemUser
        /// </summary>
        [RelationshipSchemaName("OwnerMapping_SystemUser")]
        public IEnumerable<OwnerMapping> OwnerMapping_SystemUser
        {
            get { return GetRelatedEntities<OwnerMapping>("OwnerMapping_SystemUser", null); }
            set
            {
                OnPropertyChanging("OwnerMapping_SystemUser");
                SetRelatedEntities("OwnerMapping_SystemUser", null, value);
                OnPropertyChanged("OwnerMapping_SystemUser");
            }
        }

        /// <summary>
        ///     1:N queue_primary_user
        /// </summary>
        [RelationshipSchemaName("queue_primary_user")]
        public IEnumerable<Queue> queue_primary_user
        {
            get { return GetRelatedEntities<Queue>("queue_primary_user", null); }
            set
            {
                OnPropertyChanging("queue_primary_user");
                SetRelatedEntities("queue_primary_user", null, value);
                OnPropertyChanged("queue_primary_user");
            }
        }

        /// <summary>
        ///     1:N system_user_accounts
        /// </summary>
        [RelationshipSchemaName("system_user_accounts")]
        public IEnumerable<Account> system_user_accounts
        {
            get { return GetRelatedEntities<Account>("system_user_accounts", null); }
            set
            {
                OnPropertyChanging("system_user_accounts");
                SetRelatedEntities("system_user_accounts", null, value);
                OnPropertyChanged("system_user_accounts");
            }
        }

        /// <summary>
        ///     1:N system_user_activity_parties
        /// </summary>
        [RelationshipSchemaName("system_user_activity_parties")]
        public IEnumerable<ActivityParty> system_user_activity_parties
        {
            get { return GetRelatedEntities<ActivityParty>("system_user_activity_parties", null); }
            set
            {
                OnPropertyChanging("system_user_activity_parties");
                SetRelatedEntities("system_user_activity_parties", null, value);
                OnPropertyChanged("system_user_activity_parties");
            }
        }

        /// <summary>
        ///     1:N system_user_asyncoperation
        /// </summary>
        [RelationshipSchemaName("system_user_asyncoperation")]
        public IEnumerable<AsyncOperation> system_user_asyncoperation
        {
            get { return GetRelatedEntities<AsyncOperation>("system_user_asyncoperation", null); }
            set
            {
                OnPropertyChanging("system_user_asyncoperation");
                SetRelatedEntities("system_user_asyncoperation", null, value);
                OnPropertyChanged("system_user_asyncoperation");
            }
        }

        /// <summary>
        ///     1:N system_user_contacts
        /// </summary>
        [RelationshipSchemaName("system_user_contacts")]
        public IEnumerable<Contact> system_user_contacts
        {
            get { return GetRelatedEntities<Contact>("system_user_contacts", null); }
            set
            {
                OnPropertyChanging("system_user_contacts");
                SetRelatedEntities("system_user_contacts", null, value);
                OnPropertyChanged("system_user_contacts");
            }
        }

        /// <summary>
        ///     1:N system_user_email_templates
        /// </summary>
        [RelationshipSchemaName("system_user_email_templates")]
        public IEnumerable<Template> system_user_email_templates
        {
            get { return GetRelatedEntities<Template>("system_user_email_templates", null); }
            set
            {
                OnPropertyChanging("system_user_email_templates");
                SetRelatedEntities("system_user_email_templates", null, value);
                OnPropertyChanged("system_user_email_templates");
            }
        }

        /// <summary>
        ///     1:N system_user_incidents
        /// </summary>
        [RelationshipSchemaName("system_user_incidents")]
        public IEnumerable<Incident> system_user_incidents
        {
            get { return GetRelatedEntities<Incident>("system_user_incidents", null); }
            set
            {
                OnPropertyChanging("system_user_incidents");
                SetRelatedEntities("system_user_incidents", null, value);
                OnPropertyChanged("system_user_incidents");
            }
        }

        /// <summary>
        ///     1:N system_user_invoicedetail
        /// </summary>
        [RelationshipSchemaName("system_user_invoicedetail")]
        public IEnumerable<InvoiceDetail> system_user_invoicedetail
        {
            get { return GetRelatedEntities<InvoiceDetail>("system_user_invoicedetail", null); }
            set
            {
                OnPropertyChanging("system_user_invoicedetail");
                SetRelatedEntities("system_user_invoicedetail", null, value);
                OnPropertyChanged("system_user_invoicedetail");
            }
        }

        /// <summary>
        ///     1:N system_user_invoices
        /// </summary>
        [RelationshipSchemaName("system_user_invoices")]
        public IEnumerable<Invoice> system_user_invoices
        {
            get { return GetRelatedEntities<Invoice>("system_user_invoices", null); }
            set
            {
                OnPropertyChanging("system_user_invoices");
                SetRelatedEntities("system_user_invoices", null, value);
                OnPropertyChanged("system_user_invoices");
            }
        }

        /// <summary>
        ///     1:N system_user_orders
        /// </summary>
        [RelationshipSchemaName("system_user_orders")]
        public IEnumerable<SalesOrder> system_user_orders
        {
            get { return GetRelatedEntities<SalesOrder>("system_user_orders", null); }
            set
            {
                OnPropertyChanging("system_user_orders");
                SetRelatedEntities("system_user_orders", null, value);
                OnPropertyChanged("system_user_orders");
            }
        }

        /// <summary>
        ///     1:N system_user_quotedetail
        /// </summary>
        [RelationshipSchemaName("system_user_quotedetail")]
        public IEnumerable<QuoteDetail> system_user_quotedetail
        {
            get { return GetRelatedEntities<QuoteDetail>("system_user_quotedetail", null); }
            set
            {
                OnPropertyChanging("system_user_quotedetail");
                SetRelatedEntities("system_user_quotedetail", null, value);
                OnPropertyChanged("system_user_quotedetail");
            }
        }

        /// <summary>
        ///     1:N system_user_quotes
        /// </summary>
        [RelationshipSchemaName("system_user_quotes")]
        public IEnumerable<Quote> system_user_quotes
        {
            get { return GetRelatedEntities<Quote>("system_user_quotes", null); }
            set
            {
                OnPropertyChanging("system_user_quotes");
                SetRelatedEntities("system_user_quotes", null, value);
                OnPropertyChanged("system_user_quotes");
            }
        }

        /// <summary>
        ///     1:N system_user_sales_literature
        /// </summary>
        [RelationshipSchemaName("system_user_sales_literature")]
        public IEnumerable<SalesLiterature> system_user_sales_literature
        {
            get { return GetRelatedEntities<SalesLiterature>("system_user_sales_literature", null); }
            set
            {
                OnPropertyChanging("system_user_sales_literature");
                SetRelatedEntities("system_user_sales_literature", null, value);
                OnPropertyChanged("system_user_sales_literature");
            }
        }

        /// <summary>
        ///     1:N system_user_salesorderdetail
        /// </summary>
        [RelationshipSchemaName("system_user_salesorderdetail")]
        public IEnumerable<SalesOrderDetail> system_user_salesorderdetail
        {
            get { return GetRelatedEntities<SalesOrderDetail>("system_user_salesorderdetail", null); }
            set
            {
                OnPropertyChanging("system_user_salesorderdetail");
                SetRelatedEntities("system_user_salesorderdetail", null, value);
                OnPropertyChanged("system_user_salesorderdetail");
            }
        }

        /// <summary>
        ///     1:N system_user_service_appointments
        /// </summary>
        [RelationshipSchemaName("system_user_service_appointments")]
        public IEnumerable<ServiceAppointment> system_user_service_appointments
        {
            get { return GetRelatedEntities<ServiceAppointment>("system_user_service_appointments", null); }
            set
            {
                OnPropertyChanging("system_user_service_appointments");
                SetRelatedEntities("system_user_service_appointments", null, value);
                OnPropertyChanged("system_user_service_appointments");
            }
        }

        /// <summary>
        ///     1:N system_user_service_contracts
        /// </summary>
        [RelationshipSchemaName("system_user_service_contracts")]
        public IEnumerable<Contract> system_user_service_contracts
        {
            get { return GetRelatedEntities<Contract>("system_user_service_contracts", null); }
            set
            {
                OnPropertyChanging("system_user_service_contracts");
                SetRelatedEntities("system_user_service_contracts", null, value);
                OnPropertyChanged("system_user_service_contracts");
            }
        }

        /// <summary>
        ///     1:N system_user_territories
        /// </summary>
        [RelationshipSchemaName("system_user_territories")]
        public IEnumerable<Territory> system_user_territories
        {
            get { return GetRelatedEntities<Territory>("system_user_territories", null); }
            set
            {
                OnPropertyChanging("system_user_territories");
                SetRelatedEntities("system_user_territories", null, value);
                OnPropertyChanged("system_user_territories");
            }
        }

        /// <summary>
        ///     1:N system_user_workflow
        /// </summary>
        [RelationshipSchemaName("system_user_workflow")]
        public IEnumerable<Workflow> system_user_workflow
        {
            get { return GetRelatedEntities<Workflow>("system_user_workflow", null); }
            set
            {
                OnPropertyChanging("system_user_workflow");
                SetRelatedEntities("system_user_workflow", null, value);
                OnPropertyChanged("system_user_workflow");
            }
        }

        /// <summary>
        ///     1:N SystemUser_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("SystemUser_AsyncOperations")]
        public IEnumerable<AsyncOperation> SystemUser_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("SystemUser_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("SystemUser_AsyncOperations");
                SetRelatedEntities("SystemUser_AsyncOperations", null, value);
                OnPropertyChanged("SystemUser_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N SystemUser_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("SystemUser_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> SystemUser_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("SystemUser_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("SystemUser_BulkDeleteFailures");
                SetRelatedEntities("SystemUser_BulkDeleteFailures", null, value);
                OnPropertyChanged("SystemUser_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N SystemUser_Campaigns
        /// </summary>
        [RelationshipSchemaName("SystemUser_Campaigns")]
        public IEnumerable<Campaign> SystemUser_Campaigns
        {
            get { return GetRelatedEntities<Campaign>("SystemUser_Campaigns", null); }
            set
            {
                OnPropertyChanging("SystemUser_Campaigns");
                SetRelatedEntities("SystemUser_Campaigns", null, value);
                OnPropertyChanged("SystemUser_Campaigns");
            }
        }

        /// <summary>
        ///     1:N systemuser_connections1
        /// </summary>
        [RelationshipSchemaName("systemuser_connections1")]
        public IEnumerable<Connection> systemuser_connections1
        {
            get { return GetRelatedEntities<Connection>("systemuser_connections1", null); }
            set
            {
                OnPropertyChanging("systemuser_connections1");
                SetRelatedEntities("systemuser_connections1", null, value);
                OnPropertyChanged("systemuser_connections1");
            }
        }

        /// <summary>
        ///     1:N systemuser_connections2
        /// </summary>
        [RelationshipSchemaName("systemuser_connections2")]
        public IEnumerable<Connection> systemuser_connections2
        {
            get { return GetRelatedEntities<Connection>("systemuser_connections2", null); }
            set
            {
                OnPropertyChanging("systemuser_connections2");
                SetRelatedEntities("systemuser_connections2", null, value);
                OnPropertyChanged("systemuser_connections2");
            }
        }

        /// <summary>
        ///     1:N SystemUser_DuplicateBaseRecord
        /// </summary>
        [RelationshipSchemaName("SystemUser_DuplicateBaseRecord")]
        public IEnumerable<DuplicateRecord> SystemUser_DuplicateBaseRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("SystemUser_DuplicateBaseRecord", null); }
            set
            {
                OnPropertyChanging("SystemUser_DuplicateBaseRecord");
                SetRelatedEntities("SystemUser_DuplicateBaseRecord", null, value);
                OnPropertyChanged("SystemUser_DuplicateBaseRecord");
            }
        }

        /// <summary>
        ///     1:N SystemUser_DuplicateMatchingRecord
        /// </summary>
        [RelationshipSchemaName("SystemUser_DuplicateMatchingRecord")]
        public IEnumerable<DuplicateRecord> SystemUser_DuplicateMatchingRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("SystemUser_DuplicateMatchingRecord", null); }
            set
            {
                OnPropertyChanging("SystemUser_DuplicateMatchingRecord");
                SetRelatedEntities("SystemUser_DuplicateMatchingRecord", null, value);
                OnPropertyChanged("SystemUser_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        ///     1:N SystemUser_DuplicateRules
        /// </summary>
        [RelationshipSchemaName("SystemUser_DuplicateRules")]
        public IEnumerable<DuplicateRule> SystemUser_DuplicateRules
        {
            get { return GetRelatedEntities<DuplicateRule>("SystemUser_DuplicateRules", null); }
            set
            {
                OnPropertyChanging("SystemUser_DuplicateRules");
                SetRelatedEntities("SystemUser_DuplicateRules", null, value);
                OnPropertyChanged("SystemUser_DuplicateRules");
            }
        }

        /// <summary>
        ///     1:N SystemUser_ImportFiles
        /// </summary>
        [RelationshipSchemaName("SystemUser_ImportFiles")]
        public IEnumerable<ImportFile> SystemUser_ImportFiles
        {
            get { return GetRelatedEntities<ImportFile>("SystemUser_ImportFiles", null); }
            set
            {
                OnPropertyChanging("SystemUser_ImportFiles");
                SetRelatedEntities("SystemUser_ImportFiles", null, value);
                OnPropertyChanged("SystemUser_ImportFiles");
            }
        }

        /// <summary>
        ///     1:N SystemUser_ImportLogs
        /// </summary>
        [RelationshipSchemaName("SystemUser_ImportLogs")]
        public IEnumerable<ImportLog> SystemUser_ImportLogs
        {
            get { return GetRelatedEntities<ImportLog>("SystemUser_ImportLogs", null); }
            set
            {
                OnPropertyChanging("SystemUser_ImportLogs");
                SetRelatedEntities("SystemUser_ImportLogs", null, value);
                OnPropertyChanged("SystemUser_ImportLogs");
            }
        }

        /// <summary>
        ///     1:N SystemUser_ImportMaps
        /// </summary>
        [RelationshipSchemaName("SystemUser_ImportMaps")]
        public IEnumerable<ImportMap> SystemUser_ImportMaps
        {
            get { return GetRelatedEntities<ImportMap>("SystemUser_ImportMaps", null); }
            set
            {
                OnPropertyChanging("SystemUser_ImportMaps");
                SetRelatedEntities("SystemUser_ImportMaps", null, value);
                OnPropertyChanged("SystemUser_ImportMaps");
            }
        }

        /// <summary>
        ///     1:N SystemUser_Imports
        /// </summary>
        [RelationshipSchemaName("SystemUser_Imports")]
        public IEnumerable<Import> SystemUser_Imports
        {
            get { return GetRelatedEntities<Import>("SystemUser_Imports", null); }
            set
            {
                OnPropertyChanging("SystemUser_Imports");
                SetRelatedEntities("SystemUser_Imports", null, value);
                OnPropertyChanged("SystemUser_Imports");
            }
        }

        /// <summary>
        ///     1:N systemuser_PostFollows
        /// </summary>
        [RelationshipSchemaName("systemuser_PostFollows")]
        public IEnumerable<PostFollow> systemuser_PostFollows
        {
            get { return GetRelatedEntities<PostFollow>("systemuser_PostFollows", null); }
            set
            {
                OnPropertyChanging("systemuser_PostFollows");
                SetRelatedEntities("systemuser_PostFollows", null, value);
                OnPropertyChanged("systemuser_PostFollows");
            }
        }

        /// <summary>
        ///     1:N systemuser_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("systemuser_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> systemuser_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntities<PrincipalObjectAttributeAccess>("systemuser_principalobjectattributeaccess",
                    null);
            }
            set
            {
                OnPropertyChanging("systemuser_principalobjectattributeaccess");
                SetRelatedEntities("systemuser_principalobjectattributeaccess", null, value);
                OnPropertyChanged("systemuser_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N systemuser_principalobjectattributeaccess_principalid
        /// </summary>
        [RelationshipSchemaName("systemuser_principalobjectattributeaccess_principalid")]
        public IEnumerable<PrincipalObjectAttributeAccess> systemuser_principalobjectattributeaccess_principalid
        {
            get
            {
                return
                    GetRelatedEntities<PrincipalObjectAttributeAccess>(
                        "systemuser_principalobjectattributeaccess_principalid", null);
            }
            set
            {
                OnPropertyChanging("systemuser_principalobjectattributeaccess_principalid");
                SetRelatedEntities("systemuser_principalobjectattributeaccess_principalid", null, value);
                OnPropertyChanged("systemuser_principalobjectattributeaccess_principalid");
            }
        }

        /// <summary>
        ///     1:N SystemUser_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("SystemUser_ProcessSessions")]
        public IEnumerable<ProcessSession> SystemUser_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("SystemUser_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("SystemUser_ProcessSessions");
                SetRelatedEntities("SystemUser_ProcessSessions", null, value);
                OnPropertyChanged("SystemUser_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N systemuser_resources
        /// </summary>
        [RelationshipSchemaName("systemuser_resources")]
        public IEnumerable<Resource> systemuser_resources
        {
            get { return GetRelatedEntities<Resource>("systemuser_resources", null); }
            set
            {
                OnPropertyChanging("systemuser_resources");
                SetRelatedEntities("systemuser_resources", null, value);
                OnPropertyChanged("systemuser_resources");
            }
        }

        /// <summary>
        ///     1:N user_accounts
        /// </summary>
        [RelationshipSchemaName("user_accounts")]
        public IEnumerable<Account> user_accounts
        {
            get { return GetRelatedEntities<Account>("user_accounts", null); }
            set
            {
                OnPropertyChanging("user_accounts");
                SetRelatedEntities("user_accounts", null, value);
                OnPropertyChanged("user_accounts");
            }
        }

        /// <summary>
        ///     1:N user_activity
        /// </summary>
        [RelationshipSchemaName("user_activity")]
        public IEnumerable<ActivityPointer> user_activity
        {
            get { return GetRelatedEntities<ActivityPointer>("user_activity", null); }
            set
            {
                OnPropertyChanging("user_activity");
                SetRelatedEntities("user_activity", null, value);
                OnPropertyChanged("user_activity");
            }
        }

        /// <summary>
        ///     1:N user_appointment
        /// </summary>
        [RelationshipSchemaName("user_appointment")]
        public IEnumerable<Appointment> user_appointment
        {
            get { return GetRelatedEntities<Appointment>("user_appointment", null); }
            set
            {
                OnPropertyChanging("user_appointment");
                SetRelatedEntities("user_appointment", null, value);
                OnPropertyChanged("user_appointment");
            }
        }

        /// <summary>
        ///     1:N user_BulkOperation
        /// </summary>
        [RelationshipSchemaName("user_BulkOperation")]
        public IEnumerable<BulkOperation> user_BulkOperation
        {
            get { return GetRelatedEntities<BulkOperation>("user_BulkOperation", null); }
            set
            {
                OnPropertyChanging("user_BulkOperation");
                SetRelatedEntities("user_BulkOperation", null, value);
                OnPropertyChanged("user_BulkOperation");
            }
        }

        /// <summary>
        ///     1:N user_campaignactivity
        /// </summary>
        [RelationshipSchemaName("user_campaignactivity")]
        public IEnumerable<CampaignActivity> user_campaignactivity
        {
            get { return GetRelatedEntities<CampaignActivity>("user_campaignactivity", null); }
            set
            {
                OnPropertyChanging("user_campaignactivity");
                SetRelatedEntities("user_campaignactivity", null, value);
                OnPropertyChanged("user_campaignactivity");
            }
        }

        /// <summary>
        ///     1:N user_campaignresponse
        /// </summary>
        [RelationshipSchemaName("user_campaignresponse")]
        public IEnumerable<CampaignResponse> user_campaignresponse
        {
            get { return GetRelatedEntities<CampaignResponse>("user_campaignresponse", null); }
            set
            {
                OnPropertyChanging("user_campaignresponse");
                SetRelatedEntities("user_campaignresponse", null, value);
                OnPropertyChanged("user_campaignresponse");
            }
        }

        /// <summary>
        ///     1:N user_customer_opportunity_roles
        /// </summary>
        [RelationshipSchemaName("user_customer_opportunity_roles")]
        public IEnumerable<CustomerOpportunityRole> user_customer_opportunity_roles
        {
            get { return GetRelatedEntities<CustomerOpportunityRole>("user_customer_opportunity_roles", null); }
            set
            {
                OnPropertyChanging("user_customer_opportunity_roles");
                SetRelatedEntities("user_customer_opportunity_roles", null, value);
                OnPropertyChanged("user_customer_opportunity_roles");
            }
        }

        /// <summary>
        ///     1:N user_customer_relationship
        /// </summary>
        [RelationshipSchemaName("user_customer_relationship")]
        public IEnumerable<CustomerRelationship> user_customer_relationship
        {
            get { return GetRelatedEntities<CustomerRelationship>("user_customer_relationship", null); }
            set
            {
                OnPropertyChanging("user_customer_relationship");
                SetRelatedEntities("user_customer_relationship", null, value);
                OnPropertyChanged("user_customer_relationship");
            }
        }

        /// <summary>
        ///     1:N user_email
        /// </summary>
        [RelationshipSchemaName("user_email")]
        public IEnumerable<Email> user_email
        {
            get { return GetRelatedEntities<Email>("user_email", null); }
            set
            {
                OnPropertyChanging("user_email");
                SetRelatedEntities("user_email", null, value);
                OnPropertyChanged("user_email");
            }
        }

        /// <summary>
        ///     1:N user_exchangesyncidmapping
        /// </summary>
        [RelationshipSchemaName("user_exchangesyncidmapping")]
        public IEnumerable<ExchangeSyncIdMapping> user_exchangesyncidmapping
        {
            get { return GetRelatedEntities<ExchangeSyncIdMapping>("user_exchangesyncidmapping", null); }
            set
            {
                OnPropertyChanging("user_exchangesyncidmapping");
                SetRelatedEntities("user_exchangesyncidmapping", null, value);
                OnPropertyChanged("user_exchangesyncidmapping");
            }
        }

        /// <summary>
        ///     1:N user_fax
        /// </summary>
        [RelationshipSchemaName("user_fax")]
        public IEnumerable<Fax> user_fax
        {
            get { return GetRelatedEntities<Fax>("user_fax", null); }
            set
            {
                OnPropertyChanging("user_fax");
                SetRelatedEntities("user_fax", null, value);
                OnPropertyChanged("user_fax");
            }
        }

        /// <summary>
        ///     1:N user_goal
        /// </summary>
        [RelationshipSchemaName("user_goal")]
        public IEnumerable<Goal> user_goal
        {
            get { return GetRelatedEntities<Goal>("user_goal", null); }
            set
            {
                OnPropertyChanging("user_goal");
                SetRelatedEntities("user_goal", null, value);
                OnPropertyChanged("user_goal");
            }
        }

        /// <summary>
        ///     1:N user_goal_goalowner
        /// </summary>
        [RelationshipSchemaName("user_goal_goalowner")]
        public IEnumerable<Goal> user_goal_goalowner
        {
            get { return GetRelatedEntities<Goal>("user_goal_goalowner", null); }
            set
            {
                OnPropertyChanging("user_goal_goalowner");
                SetRelatedEntities("user_goal_goalowner", null, value);
                OnPropertyChanged("user_goal_goalowner");
            }
        }

        /// <summary>
        ///     1:N user_incidentresolution
        /// </summary>
        [RelationshipSchemaName("user_incidentresolution")]
        public IEnumerable<IncidentResolution> user_incidentresolution
        {
            get { return GetRelatedEntities<IncidentResolution>("user_incidentresolution", null); }
            set
            {
                OnPropertyChanging("user_incidentresolution");
                SetRelatedEntities("user_incidentresolution", null, value);
                OnPropertyChanged("user_incidentresolution");
            }
        }

        /// <summary>
        ///     1:N user_letter
        /// </summary>
        [RelationshipSchemaName("user_letter")]
        public IEnumerable<Letter> user_letter
        {
            get { return GetRelatedEntities<Letter>("user_letter", null); }
            set
            {
                OnPropertyChanging("user_letter");
                SetRelatedEntities("user_letter", null, value);
                OnPropertyChanged("user_letter");
            }
        }

        /// <summary>
        ///     1:N user_list
        /// </summary>
        [RelationshipSchemaName("user_list")]
        public IEnumerable<List> user_list
        {
            get { return GetRelatedEntities<List>("user_list", null); }
            set
            {
                OnPropertyChanging("user_list");
                SetRelatedEntities("user_list", null, value);
                OnPropertyChanged("user_list");
            }
        }

        /// <summary>
        ///     1:N user_mailbox
        /// </summary>
        [RelationshipSchemaName("user_mailbox")]
        public IEnumerable<Mailbox> user_mailbox
        {
            get { return GetRelatedEntities<Mailbox>("user_mailbox", null); }
            set
            {
                OnPropertyChanging("user_mailbox");
                SetRelatedEntities("user_mailbox", null, value);
                OnPropertyChanged("user_mailbox");
            }
        }

        /// <summary>
        ///     1:N user_msdyn_postalbum
        /// </summary>
        [RelationshipSchemaName("user_msdyn_postalbum")]
        public IEnumerable<msdyn_PostAlbum> user_msdyn_postalbum
        {
            get { return GetRelatedEntities<msdyn_PostAlbum>("user_msdyn_postalbum", null); }
            set
            {
                OnPropertyChanging("user_msdyn_postalbum");
                SetRelatedEntities("user_msdyn_postalbum", null, value);
                OnPropertyChanged("user_msdyn_postalbum");
            }
        }

        /// <summary>
        ///     1:N user_msdyn_wallsavedqueryusersettings
        /// </summary>
        [RelationshipSchemaName("user_msdyn_wallsavedqueryusersettings")]
        public IEnumerable<msdyn_wallsavedqueryusersettings> user_msdyn_wallsavedqueryusersettings
        {
            get
            {
                return GetRelatedEntities<msdyn_wallsavedqueryusersettings>("user_msdyn_wallsavedqueryusersettings",
                    null);
            }
            set
            {
                OnPropertyChanging("user_msdyn_wallsavedqueryusersettings");
                SetRelatedEntities("user_msdyn_wallsavedqueryusersettings", null, value);
                OnPropertyChanged("user_msdyn_wallsavedqueryusersettings");
            }
        }

        /// <summary>
        ///     1:N user_opportunityclose
        /// </summary>
        [RelationshipSchemaName("user_opportunityclose")]
        public IEnumerable<OpportunityClose> user_opportunityclose
        {
            get { return GetRelatedEntities<OpportunityClose>("user_opportunityclose", null); }
            set
            {
                OnPropertyChanging("user_opportunityclose");
                SetRelatedEntities("user_opportunityclose", null, value);
                OnPropertyChanged("user_opportunityclose");
            }
        }

        /// <summary>
        ///     1:N user_orderclose
        /// </summary>
        [RelationshipSchemaName("user_orderclose")]
        public IEnumerable<OrderClose> user_orderclose
        {
            get { return GetRelatedEntities<OrderClose>("user_orderclose", null); }
            set
            {
                OnPropertyChanging("user_orderclose");
                SetRelatedEntities("user_orderclose", null, value);
                OnPropertyChanged("user_orderclose");
            }
        }

        /// <summary>
        ///     1:N user_owner_postfollows
        /// </summary>
        [RelationshipSchemaName("user_owner_postfollows")]
        public IEnumerable<PostFollow> user_owner_postfollows
        {
            get { return GetRelatedEntities<PostFollow>("user_owner_postfollows", null); }
            set
            {
                OnPropertyChanging("user_owner_postfollows");
                SetRelatedEntities("user_owner_postfollows", null, value);
                OnPropertyChanged("user_owner_postfollows");
            }
        }

        /// <summary>
        ///     1:N user_parent_user
        /// </summary>
        [RelationshipSchemaName("user_parent_user", EntityRole.Referenced)]
        public IEnumerable<SystemUser> Referenceduser_parent_user
        {
            get { return GetRelatedEntities<SystemUser>("user_parent_user", EntityRole.Referenced); }
            set
            {
                OnPropertyChanging("Referenceduser_parent_user");
                SetRelatedEntities("user_parent_user", EntityRole.Referenced, value);
                OnPropertyChanged("Referenceduser_parent_user");
            }
        }

        /// <summary>
        ///     1:N user_phonecall
        /// </summary>
        [RelationshipSchemaName("user_phonecall")]
        public IEnumerable<PhoneCall> user_phonecall
        {
            get { return GetRelatedEntities<PhoneCall>("user_phonecall", null); }
            set
            {
                OnPropertyChanging("user_phonecall");
                SetRelatedEntities("user_phonecall", null, value);
                OnPropertyChanged("user_phonecall");
            }
        }

        /// <summary>
        ///     1:N user_quoteclose
        /// </summary>
        [RelationshipSchemaName("user_quoteclose")]
        public IEnumerable<QuoteClose> user_quoteclose
        {
            get { return GetRelatedEntities<QuoteClose>("user_quoteclose", null); }
            set
            {
                OnPropertyChanging("user_quoteclose");
                SetRelatedEntities("user_quoteclose", null, value);
                OnPropertyChanged("user_quoteclose");
            }
        }

        /// <summary>
        ///     1:N user_recurringappointmentmaster
        /// </summary>
        [RelationshipSchemaName("user_recurringappointmentmaster")]
        public IEnumerable<RecurringAppointmentMaster> user_recurringappointmentmaster
        {
            get { return GetRelatedEntities<RecurringAppointmentMaster>("user_recurringappointmentmaster", null); }
            set
            {
                OnPropertyChanging("user_recurringappointmentmaster");
                SetRelatedEntities("user_recurringappointmentmaster", null, value);
                OnPropertyChanged("user_recurringappointmentmaster");
            }
        }

        /// <summary>
        ///     1:N user_settings
        /// </summary>
        [RelationshipSchemaName("user_settings")]
        public IEnumerable<UserSettings> user_settings
        {
            get { return GetRelatedEntities<UserSettings>("user_settings", null); }
            set
            {
                OnPropertyChanging("user_settings");
                SetRelatedEntities("user_settings", null, value);
                OnPropertyChanged("user_settings");
            }
        }

        /// <summary>
        ///     1:N user_sharepointdocumentlocation
        /// </summary>
        [RelationshipSchemaName("user_sharepointdocumentlocation")]
        public IEnumerable<SharePointDocumentLocation> user_sharepointdocumentlocation
        {
            get { return GetRelatedEntities<SharePointDocumentLocation>("user_sharepointdocumentlocation", null); }
            set
            {
                OnPropertyChanging("user_sharepointdocumentlocation");
                SetRelatedEntities("user_sharepointdocumentlocation", null, value);
                OnPropertyChanged("user_sharepointdocumentlocation");
            }
        }

        /// <summary>
        ///     1:N user_sharepointsite
        /// </summary>
        [RelationshipSchemaName("user_sharepointsite")]
        public IEnumerable<SharePointSite> user_sharepointsite
        {
            get { return GetRelatedEntities<SharePointSite>("user_sharepointsite", null); }
            set
            {
                OnPropertyChanging("user_sharepointsite");
                SetRelatedEntities("user_sharepointsite", null, value);
                OnPropertyChanged("user_sharepointsite");
            }
        }

        /// <summary>
        ///     1:N user_task
        /// </summary>
        [RelationshipSchemaName("user_task")]
        public IEnumerable<Task> user_task
        {
            get { return GetRelatedEntities<Task>("user_task", null); }
            set
            {
                OnPropertyChanging("user_task");
                SetRelatedEntities("user_task", null, value);
                OnPropertyChanged("user_task");
            }
        }

        /// <summary>
        ///     1:N user_userform
        /// </summary>
        [RelationshipSchemaName("user_userform")]
        public IEnumerable<UserForm> user_userform
        {
            get { return GetRelatedEntities<UserForm>("user_userform", null); }
            set
            {
                OnPropertyChanging("user_userform");
                SetRelatedEntities("user_userform", null, value);
                OnPropertyChanged("user_userform");
            }
        }

        /// <summary>
        ///     1:N user_userquery
        /// </summary>
        [RelationshipSchemaName("user_userquery")]
        public IEnumerable<UserQuery> user_userquery
        {
            get { return GetRelatedEntities<UserQuery>("user_userquery", null); }
            set
            {
                OnPropertyChanging("user_userquery");
                SetRelatedEntities("user_userquery", null, value);
                OnPropertyChanged("user_userquery");
            }
        }

        /// <summary>
        ///     1:N user_userqueryvisualizations
        /// </summary>
        [RelationshipSchemaName("user_userqueryvisualizations")]
        public IEnumerable<UserQueryVisualization> user_userqueryvisualizations
        {
            get { return GetRelatedEntities<UserQueryVisualization>("user_userqueryvisualizations", null); }
            set
            {
                OnPropertyChanging("user_userqueryvisualizations");
                SetRelatedEntities("user_userqueryvisualizations", null, value);
                OnPropertyChanged("user_userqueryvisualizations");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_owning_user
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_owning_user")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_owning_user
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_owning_user", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_owning_user");
                SetRelatedEntities("userentityinstancedata_owning_user", null, value);
                OnPropertyChanged("userentityinstancedata_owning_user");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_systemuser
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_systemuser")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_systemuser
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_systemuser", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_systemuser");
                SetRelatedEntities("userentityinstancedata_systemuser", null, value);
                OnPropertyChanged("userentityinstancedata_systemuser");
            }
        }

        /// <summary>
        ///     1:N userentityuisettings_owning_user
        /// </summary>
        [RelationshipSchemaName("userentityuisettings_owning_user")]
        public IEnumerable<UserEntityUISettings> userentityuisettings_owning_user
        {
            get { return GetRelatedEntities<UserEntityUISettings>("userentityuisettings_owning_user", null); }
            set
            {
                OnPropertyChanging("userentityuisettings_owning_user");
                SetRelatedEntities("userentityuisettings_owning_user", null, value);
                OnPropertyChanged("userentityuisettings_owning_user");
            }
        }

        /// <summary>
        ///     1:N webresource_createdby
        /// </summary>
        [RelationshipSchemaName("webresource_createdby")]
        public IEnumerable<WebResource> webresource_createdby
        {
            get { return GetRelatedEntities<WebResource>("webresource_createdby", null); }
            set
            {
                OnPropertyChanging("webresource_createdby");
                SetRelatedEntities("webresource_createdby", null, value);
                OnPropertyChanged("webresource_createdby");
            }
        }

        /// <summary>
        ///     1:N webresource_modifiedby
        /// </summary>
        [RelationshipSchemaName("webresource_modifiedby")]
        public IEnumerable<WebResource> webresource_modifiedby
        {
            get { return GetRelatedEntities<WebResource>("webresource_modifiedby", null); }
            set
            {
                OnPropertyChanging("webresource_modifiedby");
                SetRelatedEntities("webresource_modifiedby", null, value);
                OnPropertyChanged("webresource_modifiedby");
            }
        }

        /// <summary>
        ///     1:N workflow_createdby
        /// </summary>
        [RelationshipSchemaName("workflow_createdby")]
        public IEnumerable<Workflow> workflow_createdby
        {
            get { return GetRelatedEntities<Workflow>("workflow_createdby", null); }
            set
            {
                OnPropertyChanging("workflow_createdby");
                SetRelatedEntities("workflow_createdby", null, value);
                OnPropertyChanged("workflow_createdby");
            }
        }

        /// <summary>
        ///     1:N workflow_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("workflow_createdonbehalfby")]
        public IEnumerable<Workflow> workflow_createdonbehalfby
        {
            get { return GetRelatedEntities<Workflow>("workflow_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("workflow_createdonbehalfby");
                SetRelatedEntities("workflow_createdonbehalfby", null, value);
                OnPropertyChanged("workflow_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N workflow_dependency_createdby
        /// </summary>
        [RelationshipSchemaName("workflow_dependency_createdby")]
        public IEnumerable<WorkflowDependency> workflow_dependency_createdby
        {
            get { return GetRelatedEntities<WorkflowDependency>("workflow_dependency_createdby", null); }
            set
            {
                OnPropertyChanging("workflow_dependency_createdby");
                SetRelatedEntities("workflow_dependency_createdby", null, value);
                OnPropertyChanged("workflow_dependency_createdby");
            }
        }

        /// <summary>
        ///     1:N workflow_dependency_createdonbehalfby
        /// </summary>
        [RelationshipSchemaName("workflow_dependency_createdonbehalfby")]
        public IEnumerable<WorkflowDependency> workflow_dependency_createdonbehalfby
        {
            get { return GetRelatedEntities<WorkflowDependency>("workflow_dependency_createdonbehalfby", null); }
            set
            {
                OnPropertyChanging("workflow_dependency_createdonbehalfby");
                SetRelatedEntities("workflow_dependency_createdonbehalfby", null, value);
                OnPropertyChanged("workflow_dependency_createdonbehalfby");
            }
        }

        /// <summary>
        ///     1:N workflow_dependency_modifiedby
        /// </summary>
        [RelationshipSchemaName("workflow_dependency_modifiedby")]
        public IEnumerable<WorkflowDependency> workflow_dependency_modifiedby
        {
            get { return GetRelatedEntities<WorkflowDependency>("workflow_dependency_modifiedby", null); }
            set
            {
                OnPropertyChanging("workflow_dependency_modifiedby");
                SetRelatedEntities("workflow_dependency_modifiedby", null, value);
                OnPropertyChanged("workflow_dependency_modifiedby");
            }
        }

        /// <summary>
        ///     1:N workflow_dependency_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("workflow_dependency_modifiedonbehalfby")]
        public IEnumerable<WorkflowDependency> workflow_dependency_modifiedonbehalfby
        {
            get { return GetRelatedEntities<WorkflowDependency>("workflow_dependency_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("workflow_dependency_modifiedonbehalfby");
                SetRelatedEntities("workflow_dependency_modifiedonbehalfby", null, value);
                OnPropertyChanged("workflow_dependency_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     1:N workflow_modifiedby
        /// </summary>
        [RelationshipSchemaName("workflow_modifiedby")]
        public IEnumerable<Workflow> workflow_modifiedby
        {
            get { return GetRelatedEntities<Workflow>("workflow_modifiedby", null); }
            set
            {
                OnPropertyChanging("workflow_modifiedby");
                SetRelatedEntities("workflow_modifiedby", null, value);
                OnPropertyChanged("workflow_modifiedby");
            }
        }

        /// <summary>
        ///     1:N workflow_modifiedonbehalfby
        /// </summary>
        [RelationshipSchemaName("workflow_modifiedonbehalfby")]
        public IEnumerable<Workflow> workflow_modifiedonbehalfby
        {
            get { return GetRelatedEntities<Workflow>("workflow_modifiedonbehalfby", null); }
            set
            {
                OnPropertyChanging("workflow_modifiedonbehalfby");
                SetRelatedEntities("workflow_modifiedonbehalfby", null, value);
                OnPropertyChanged("workflow_modifiedonbehalfby");
            }
        }

        /// <summary>
        ///     N:N systemuserprofiles_association
        /// </summary>
        [RelationshipSchemaName("systemuserprofiles_association")]
        public IEnumerable<FieldSecurityProfile> systemuserprofiles_association
        {
            get { return GetRelatedEntities<FieldSecurityProfile>("systemuserprofiles_association", null); }
            set
            {
                OnPropertyChanging("systemuserprofiles_association");
                SetRelatedEntities("systemuserprofiles_association", null, value);
                OnPropertyChanged("systemuserprofiles_association");
            }
        }

        /// <summary>
        ///     N:N systemuserroles_association
        /// </summary>
        [RelationshipSchemaName("systemuserroles_association")]
        public IEnumerable<Role> systemuserroles_association
        {
            get { return GetRelatedEntities<Role>("systemuserroles_association", null); }
            set
            {
                OnPropertyChanging("systemuserroles_association");
                SetRelatedEntities("systemuserroles_association", null, value);
                OnPropertyChanged("systemuserroles_association");
            }
        }

        /// <summary>
        ///     N:N teammembership_association
        /// </summary>
        [RelationshipSchemaName("teammembership_association")]
        public IEnumerable<Team> teammembership_association
        {
            get { return GetRelatedEntities<Team>("teammembership_association", null); }
            set
            {
                OnPropertyChanging("teammembership_association");
                SetRelatedEntities("teammembership_association", null, value);
                OnPropertyChanged("teammembership_association");
            }
        }

        /// <summary>
        ///     N:1 business_unit_system_users
        /// </summary>
        [AttributeLogicalName("businessunitid")]
        [RelationshipSchemaName("business_unit_system_users")]
        public BusinessUnit business_unit_system_users
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_system_users", null); }
            set
            {
                OnPropertyChanging("business_unit_system_users");
                SetRelatedEntity("business_unit_system_users", null, value);
                OnPropertyChanged("business_unit_system_users");
            }
        }

        /// <summary>
        ///     N:1 calendar_system_users
        /// </summary>
        [AttributeLogicalName("calendarid")]
        [RelationshipSchemaName("calendar_system_users")]
        public Calendar calendar_system_users
        {
            get { return GetRelatedEntity<Calendar>("calendar_system_users", null); }
            set
            {
                OnPropertyChanging("calendar_system_users");
                SetRelatedEntity("calendar_system_users", null, value);
                OnPropertyChanged("calendar_system_users");
            }
        }

        /// <summary>
        ///     N:1 lk_systemuser_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_systemuser_createdonbehalfby", EntityRole.Referencing)]
        public SystemUser Referencinglk_systemuser_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_systemuser_createdonbehalfby", EntityRole.Referencing); }
        }

        /// <summary>
        ///     N:1 lk_systemuser_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_systemuser_modifiedonbehalfby", EntityRole.Referencing)]
        public SystemUser Referencinglk_systemuser_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_systemuser_modifiedonbehalfby", EntityRole.Referencing); }
        }

        /// <summary>
        ///     N:1 lk_systemuserbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_systemuserbase_createdby", EntityRole.Referencing)]
        public SystemUser Referencinglk_systemuserbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_systemuserbase_createdby", EntityRole.Referencing); }
        }

        /// <summary>
        ///     N:1 lk_systemuserbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_systemuserbase_modifiedby", EntityRole.Referencing)]
        public SystemUser Referencinglk_systemuserbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_systemuserbase_modifiedby", EntityRole.Referencing); }
        }

        /// <summary>
        ///     N:1 organization_system_users
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_system_users")]
        public Organization organization_system_users
        {
            get { return GetRelatedEntity<Organization>("organization_system_users", null); }
        }

        /// <summary>
        ///     N:1 processstage_systemusers
        /// </summary>
        [AttributeLogicalName("stageid")]
        [RelationshipSchemaName("processstage_systemusers")]
        public ProcessStage processstage_systemusers
        {
            get { return GetRelatedEntity<ProcessStage>("processstage_systemusers", null); }
            set
            {
                OnPropertyChanging("processstage_systemusers");
                SetRelatedEntity("processstage_systemusers", null, value);
                OnPropertyChanged("processstage_systemusers");
            }
        }

        /// <summary>
        ///     N:1 queue_system_user
        /// </summary>
        [AttributeLogicalName("queueid")]
        [RelationshipSchemaName("queue_system_user")]
        public Queue queue_system_user
        {
            get { return GetRelatedEntity<Queue>("queue_system_user", null); }
            set
            {
                OnPropertyChanging("queue_system_user");
                SetRelatedEntity("queue_system_user", null, value);
                OnPropertyChanged("queue_system_user");
            }
        }

        /// <summary>
        ///     N:1 site_system_users
        /// </summary>
        [AttributeLogicalName("siteid")]
        [RelationshipSchemaName("site_system_users")]
        public Site site_system_users
        {
            get { return GetRelatedEntity<Site>("site_system_users", null); }
            set
            {
                OnPropertyChanging("site_system_users");
                SetRelatedEntity("site_system_users", null, value);
                OnPropertyChanged("site_system_users");
            }
        }

        /// <summary>
        ///     N:1 systemuser_defaultmailbox_mailbox
        /// </summary>
        [AttributeLogicalName("defaultmailbox")]
        [RelationshipSchemaName("systemuser_defaultmailbox_mailbox")]
        public Mailbox systemuser_defaultmailbox_mailbox
        {
            get { return GetRelatedEntity<Mailbox>("systemuser_defaultmailbox_mailbox", null); }
        }

        /// <summary>
        ///     N:1 territory_system_users
        /// </summary>
        [AttributeLogicalName("territoryid")]
        [RelationshipSchemaName("territory_system_users")]
        public Territory territory_system_users
        {
            get { return GetRelatedEntity<Territory>("territory_system_users", null); }
            set
            {
                OnPropertyChanging("territory_system_users");
                SetRelatedEntity("territory_system_users", null, value);
                OnPropertyChanged("territory_system_users");
            }
        }

        /// <summary>
        ///     N:1 TransactionCurrency_SystemUser
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("TransactionCurrency_SystemUser")]
        public TransactionCurrency TransactionCurrency_SystemUser
        {
            get { return GetRelatedEntity<TransactionCurrency>("TransactionCurrency_SystemUser", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_SystemUser");
                SetRelatedEntity("TransactionCurrency_SystemUser", null, value);
                OnPropertyChanged("TransactionCurrency_SystemUser");
            }
        }

        /// <summary>
        ///     N:1 user_parent_user
        /// </summary>
        [AttributeLogicalName("parentsystemuserid")]
        [RelationshipSchemaName("user_parent_user", EntityRole.Referencing)]
        public SystemUser Referencinguser_parent_user
        {
            get { return GetRelatedEntity<SystemUser>("user_parent_user", EntityRole.Referencing); }
            set
            {
                OnPropertyChanging("Referencinguser_parent_user");
                SetRelatedEntity("user_parent_user", EntityRole.Referencing, value);
                OnPropertyChanged("Referencinguser_parent_user");
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