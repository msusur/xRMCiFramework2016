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
    ///     Person with whom a business unit has a relationship, such as customer, supplier, and colleague.
    /// </summary>
    [DataContract]
    [EntityLogicalName("contact")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Contact : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "contact";

        public const int EntityTypeCode = 2;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Contact() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the account with which the contact is associated.
        /// </summary>
        [AttributeLogicalName("accountid")]
        public EntityReference AccountId
        {
            get { return GetAttributeValue<EntityReference>("accountid"); }
        }

        /// <summary>
        ///     Select the contact's role within the company or sales process, such as decision maker, employee, or influencer.
        /// </summary>
        [AttributeLogicalName("accountrolecode")]
        public OptionSetValue AccountRoleCode
        {
            get { return GetAttributeValue<OptionSetValue>("accountrolecode"); }
            set
            {
                OnPropertyChanging("AccountRoleCode");
                SetAttributeValue("accountrolecode", value);
                OnPropertyChanged("AccountRoleCode");
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
        ///     Select the primary address type.
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
        ///     Type the city for the primary address.
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
        ///     Type the country or region for the primary address.
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
        ///     Type the county for the primary address.
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
        ///     Type the fax number associated with the primary address.
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
        ///     Select the freight terms for the primary address to make sure shipping orders are processed correctly.
        /// </summary>
        [AttributeLogicalName("address1_freighttermscode")]
        public OptionSetValue Address1_FreightTermsCode
        {
            get { return GetAttributeValue<OptionSetValue>("address1_freighttermscode"); }
            set
            {
                OnPropertyChanging("Address1_FreightTermsCode");
                SetAttributeValue("address1_freighttermscode", value);
                OnPropertyChanged("Address1_FreightTermsCode");
            }
        }

        /// <summary>
        ///     Type the latitude value for the primary address for use in mapping and other applications.
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
        ///     Type the first line of the primary address.
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
        ///     Type the second line of the primary address.
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
        ///     Type the third line of the primary address.
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
        ///     Type the longitude value for the primary address for use in mapping and other applications.
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
        ///     Type a descriptive name for the primary address, such as Corporate Headquarters.
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
        ///     Type the ZIP Code or postal code for the primary address.
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
        ///     Type the post office box number of the primary address.
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
        ///     Type the name of the main contact at the account's primary address.
        /// </summary>
        [AttributeLogicalName("address1_primarycontactname")]
        public string Address1_PrimaryContactName
        {
            get { return GetAttributeValue<string>("address1_primarycontactname"); }
            set
            {
                OnPropertyChanging("Address1_PrimaryContactName");
                SetAttributeValue("address1_primarycontactname", value);
                OnPropertyChanged("Address1_PrimaryContactName");
            }
        }

        /// <summary>
        ///     Select a shipping method for deliveries sent to this address.
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
        ///     Type the state or province of the primary address.
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
        ///     Type the main phone number associated with the primary address.
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
        ///     Type a second phone number associated with the primary address.
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
        ///     Type a third phone number associated with the primary address.
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
        ///     Type the UPS zone of the primary address to make sure shipping charges are calculated correctly and deliveries are
        ///     made promptly, if shipped by UPS.
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
        ///     Select the time zone, or UTC offset, for this address so that other people can reference it when they contact
        ///     someone at this address.
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
        ///     Select the secondary address type.
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
        ///     Type the city for the secondary address.
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
        ///     Type the country or region for the secondary address.
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
        ///     Type the county for the secondary address.
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
        ///     Type the fax number associated with the secondary address.
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
        ///     Select the freight terms for the secondary address to make sure shipping orders are processed correctly.
        /// </summary>
        [AttributeLogicalName("address2_freighttermscode")]
        public OptionSetValue Address2_FreightTermsCode
        {
            get { return GetAttributeValue<OptionSetValue>("address2_freighttermscode"); }
            set
            {
                OnPropertyChanging("Address2_FreightTermsCode");
                SetAttributeValue("address2_freighttermscode", value);
                OnPropertyChanged("Address2_FreightTermsCode");
            }
        }

        /// <summary>
        ///     Type the latitude value for the secondary address for use in mapping and other applications.
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
        ///     Type the first line of the secondary address.
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
        ///     Type the second line of the secondary address.
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
        ///     Type the third line of the secondary address.
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
        ///     Type the longitude value for the secondary address for use in mapping and other applications.
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
        ///     Type a descriptive name for the secondary address, such as Corporate Headquarters.
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
        ///     Type the ZIP Code or postal code for the secondary address.
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
        ///     Type the post office box number of the secondary address.
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
        ///     Type the name of the main contact at the account's secondary address.
        /// </summary>
        [AttributeLogicalName("address2_primarycontactname")]
        public string Address2_PrimaryContactName
        {
            get { return GetAttributeValue<string>("address2_primarycontactname"); }
            set
            {
                OnPropertyChanging("Address2_PrimaryContactName");
                SetAttributeValue("address2_primarycontactname", value);
                OnPropertyChanged("Address2_PrimaryContactName");
            }
        }

        /// <summary>
        ///     Select a shipping method for deliveries sent to this address.
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
        ///     Type the state or province of the secondary address.
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
        ///     Type the main phone number associated with the secondary address.
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
        ///     Type a second phone number associated with the secondary address.
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
        ///     Type a third phone number associated with the secondary address.
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
        ///     Type the UPS zone of the secondary address to make sure shipping charges are calculated correctly and deliveries
        ///     are made promptly, if shipped by UPS.
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
        ///     Select the time zone, or UTC offset, for this address so that other people can reference it when they contact
        ///     someone at this address.
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
        ///     For system use only.
        /// </summary>
        [AttributeLogicalName("aging30")]
        public Money Aging30
        {
            get { return GetAttributeValue<Money>("aging30"); }
        }

        /// <summary>
        ///     Shows the Aging 30 field converted to the system's default base currency. The calculations use the exchange rate
        ///     specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("aging30_base")]
        public Money Aging30_Base
        {
            get { return GetAttributeValue<Money>("aging30_base"); }
        }

        /// <summary>
        ///     For system use only.
        /// </summary>
        [AttributeLogicalName("aging60")]
        public Money Aging60
        {
            get { return GetAttributeValue<Money>("aging60"); }
        }

        /// <summary>
        ///     Shows the Aging 60 field converted to the system's default base currency. The calculations use the exchange rate
        ///     specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("aging60_base")]
        public Money Aging60_Base
        {
            get { return GetAttributeValue<Money>("aging60_base"); }
        }

        /// <summary>
        ///     For system use only.
        /// </summary>
        [AttributeLogicalName("aging90")]
        public Money Aging90
        {
            get { return GetAttributeValue<Money>("aging90"); }
        }

        /// <summary>
        ///     Shows the Aging 90 field converted to the system's default base currency. The calculations use the exchange rate
        ///     specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("aging90_base")]
        public Money Aging90_Base
        {
            get { return GetAttributeValue<Money>("aging90_base"); }
        }

        /// <summary>
        ///     Enter the date of the contact's wedding or service anniversary for use in customer gift programs or other
        ///     communications.
        /// </summary>
        [AttributeLogicalName("anniversary")]
        public DateTime? Anniversary
        {
            get { return GetAttributeValue<DateTime?>("anniversary"); }
            set
            {
                OnPropertyChanging("Anniversary");
                SetAttributeValue("anniversary", value);
                OnPropertyChanged("Anniversary");
            }
        }

        /// <summary>
        ///     Type the contact's annual income for use in profiling and financial analysis.
        /// </summary>
        [AttributeLogicalName("annualincome")]
        public Money AnnualIncome
        {
            get { return GetAttributeValue<Money>("annualincome"); }
            set
            {
                OnPropertyChanging("AnnualIncome");
                SetAttributeValue("annualincome", value);
                OnPropertyChanged("AnnualIncome");
            }
        }

        /// <summary>
        ///     Shows the Annual Income field converted to the system's default base currency. The calculations use the exchange
        ///     rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("annualincome_base")]
        public Money AnnualIncome_Base
        {
            get { return GetAttributeValue<Money>("annualincome_base"); }
        }

        /// <summary>
        ///     Type the name of the contact's assistant.
        /// </summary>
        [AttributeLogicalName("assistantname")]
        public string AssistantName
        {
            get { return GetAttributeValue<string>("assistantname"); }
            set
            {
                OnPropertyChanging("AssistantName");
                SetAttributeValue("assistantname", value);
                OnPropertyChanged("AssistantName");
            }
        }

        /// <summary>
        ///     Type the phone number for the contact's assistant.
        /// </summary>
        [AttributeLogicalName("assistantphone")]
        public string AssistantPhone
        {
            get { return GetAttributeValue<string>("assistantphone"); }
            set
            {
                OnPropertyChanging("AssistantPhone");
                SetAttributeValue("assistantphone", value);
                OnPropertyChanged("AssistantPhone");
            }
        }

        /// <summary>
        ///     Enter the contact's birthday for use in customer gift programs or other communications.
        /// </summary>
        [AttributeLogicalName("birthdate")]
        public DateTime? BirthDate
        {
            get { return GetAttributeValue<DateTime?>("birthdate"); }
            set
            {
                OnPropertyChanging("BirthDate");
                SetAttributeValue("birthdate", value);
                OnPropertyChanged("BirthDate");
            }
        }

        /// <summary>
        ///     Type the names of the contact's children for reference in communications and client programs.
        /// </summary>
        [AttributeLogicalName("childrensnames")]
        public string ChildrensNames
        {
            get { return GetAttributeValue<string>("childrensnames"); }
            set
            {
                OnPropertyChanging("ChildrensNames");
                SetAttributeValue("childrensnames", value);
                OnPropertyChanged("ChildrensNames");
            }
        }

        /// <summary>
        ///     Unique identifier of the contact.
        /// </summary>
        [AttributeLogicalName("contactid")]
        public Guid? ContactId
        {
            get { return GetAttributeValue<Guid?>("contactid"); }
            set
            {
                OnPropertyChanging("ContactId");
                SetAttributeValue("contactid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ContactId");
            }
        }

        [AttributeLogicalName("contactid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ContactId = value; }
        }

        /// <summary>
        ///     Shows who created the record.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Shows the date and time when the record was created. The date and time are displayed in the time zone selected in
        ///     Microsoft Dynamics CRM options.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Shows who created the record on behalf of another user.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Type the credit limit of the contact for reference when you address invoice and accounting issues with the
        ///     customer.
        /// </summary>
        [AttributeLogicalName("creditlimit")]
        public Money CreditLimit
        {
            get { return GetAttributeValue<Money>("creditlimit"); }
            set
            {
                OnPropertyChanging("CreditLimit");
                SetAttributeValue("creditlimit", value);
                OnPropertyChanged("CreditLimit");
            }
        }

        /// <summary>
        ///     Shows the Credit Limit field converted to the system's default base currency for reporting purposes. The
        ///     calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("creditlimit_base")]
        public Money CreditLimit_Base
        {
            get { return GetAttributeValue<Money>("creditlimit_base"); }
        }

        /// <summary>
        ///     Select whether the contact is on a credit hold, for reference when addressing invoice and accounting issues.
        /// </summary>
        [AttributeLogicalName("creditonhold")]
        public bool? CreditOnHold
        {
            get { return GetAttributeValue<bool?>("creditonhold"); }
            set
            {
                OnPropertyChanging("CreditOnHold");
                SetAttributeValue("creditonhold", value);
                OnPropertyChanged("CreditOnHold");
            }
        }

        /// <summary>
        ///     Select the size of the contact's company for segmentation and reporting purposes.
        /// </summary>
        [AttributeLogicalName("customersizecode")]
        public OptionSetValue CustomerSizeCode
        {
            get { return GetAttributeValue<OptionSetValue>("customersizecode"); }
            set
            {
                OnPropertyChanging("CustomerSizeCode");
                SetAttributeValue("customersizecode", value);
                OnPropertyChanged("CustomerSizeCode");
            }
        }

        /// <summary>
        ///     Select the category that best describes the relationship between the contact and your organization.
        /// </summary>
        [AttributeLogicalName("customertypecode")]
        public OptionSetValue CustomerTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("customertypecode"); }
            set
            {
                OnPropertyChanging("CustomerTypeCode");
                SetAttributeValue("customertypecode", value);
                OnPropertyChanged("CustomerTypeCode");
            }
        }

        /// <summary>
        ///     Choose the default price list associated with the contact to make sure the correct product prices for this customer
        ///     are applied in sales opportunities, quotes, and orders.
        /// </summary>
        [AttributeLogicalName("defaultpricelevelid")]
        public EntityReference DefaultPriceLevelId
        {
            get { return GetAttributeValue<EntityReference>("defaultpricelevelid"); }
            set
            {
                OnPropertyChanging("DefaultPriceLevelId");
                SetAttributeValue("defaultpricelevelid", value);
                OnPropertyChanged("DefaultPriceLevelId");
            }
        }

        /// <summary>
        ///     Type the department or business unit where the contact works in the parent company or business.
        /// </summary>
        [AttributeLogicalName("department")]
        public string Department
        {
            get { return GetAttributeValue<string>("department"); }
            set
            {
                OnPropertyChanging("Department");
                SetAttributeValue("department", value);
                OnPropertyChanged("Department");
            }
        }

        /// <summary>
        ///     Type additional information to describe the contact, such as an excerpt from the company's website.
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
        ///     Select whether the contact accepts bulk email sent through marketing campaigns or quick campaigns. If Do Not Allow
        ///     is selected, the contact can be added to marketing lists, but will be excluded from the email.
        /// </summary>
        [AttributeLogicalName("donotbulkemail")]
        public bool? DoNotBulkEMail
        {
            get { return GetAttributeValue<bool?>("donotbulkemail"); }
            set
            {
                OnPropertyChanging("DoNotBulkEMail");
                SetAttributeValue("donotbulkemail", value);
                OnPropertyChanged("DoNotBulkEMail");
            }
        }

        /// <summary>
        ///     Select whether the contact accepts bulk postal mail sent through marketing campaigns or quick campaigns. If Do Not
        ///     Allow is selected, the contact can be added to marketing lists, but will be excluded from the letters.
        /// </summary>
        [AttributeLogicalName("donotbulkpostalmail")]
        public bool? DoNotBulkPostalMail
        {
            get { return GetAttributeValue<bool?>("donotbulkpostalmail"); }
            set
            {
                OnPropertyChanging("DoNotBulkPostalMail");
                SetAttributeValue("donotbulkpostalmail", value);
                OnPropertyChanged("DoNotBulkPostalMail");
            }
        }

        /// <summary>
        ///     Select whether the contact allows direct email sent from Microsoft Dynamics CRM. If Do Not Allow is selected,
        ///     Microsoft Dynamics CRM will not send the email.
        /// </summary>
        [AttributeLogicalName("donotemail")]
        public bool? DoNotEMail
        {
            get { return GetAttributeValue<bool?>("donotemail"); }
            set
            {
                OnPropertyChanging("DoNotEMail");
                SetAttributeValue("donotemail", value);
                OnPropertyChanged("DoNotEMail");
            }
        }

        /// <summary>
        ///     Select whether the contact allows faxes. If Do Not Allow is selected, the contact will be excluded from any fax
        ///     activities distributed in marketing campaigns.
        /// </summary>
        [AttributeLogicalName("donotfax")]
        public bool? DoNotFax
        {
            get { return GetAttributeValue<bool?>("donotfax"); }
            set
            {
                OnPropertyChanging("DoNotFax");
                SetAttributeValue("donotfax", value);
                OnPropertyChanged("DoNotFax");
            }
        }

        /// <summary>
        ///     Select whether the contact accepts phone calls. If Do Not Allow is selected, the contact will be excluded from any
        ///     phone call activities distributed in marketing campaigns.
        /// </summary>
        [AttributeLogicalName("donotphone")]
        public bool? DoNotPhone
        {
            get { return GetAttributeValue<bool?>("donotphone"); }
            set
            {
                OnPropertyChanging("DoNotPhone");
                SetAttributeValue("donotphone", value);
                OnPropertyChanged("DoNotPhone");
            }
        }

        /// <summary>
        ///     Select whether the contact allows direct mail. If Do Not Allow is selected, the contact will be excluded from
        ///     letter activities distributed in marketing campaigns.
        /// </summary>
        [AttributeLogicalName("donotpostalmail")]
        public bool? DoNotPostalMail
        {
            get { return GetAttributeValue<bool?>("donotpostalmail"); }
            set
            {
                OnPropertyChanging("DoNotPostalMail");
                SetAttributeValue("donotpostalmail", value);
                OnPropertyChanged("DoNotPostalMail");
            }
        }

        /// <summary>
        ///     Select whether the contact accepts marketing materials, such as brochures or catalogs. Contacts that opt out can be
        ///     excluded from marketing initiatives.
        /// </summary>
        [AttributeLogicalName("donotsendmm")]
        public bool? DoNotSendMM
        {
            get { return GetAttributeValue<bool?>("donotsendmm"); }
            set
            {
                OnPropertyChanging("DoNotSendMM");
                SetAttributeValue("donotsendmm", value);
                OnPropertyChanged("DoNotSendMM");
            }
        }

        /// <summary>
        ///     Select the contact's highest level of education for use in segmentation and analysis.
        /// </summary>
        [AttributeLogicalName("educationcode")]
        public OptionSetValue EducationCode
        {
            get { return GetAttributeValue<OptionSetValue>("educationcode"); }
            set
            {
                OnPropertyChanging("EducationCode");
                SetAttributeValue("educationcode", value);
                OnPropertyChanged("EducationCode");
            }
        }

        /// <summary>
        ///     Type the primary email address for the contact.
        /// </summary>
        [AttributeLogicalName("emailaddress1")]
        public string EMailAddress1
        {
            get { return GetAttributeValue<string>("emailaddress1"); }
            set
            {
                OnPropertyChanging("EMailAddress1");
                SetAttributeValue("emailaddress1", value);
                OnPropertyChanged("EMailAddress1");
            }
        }

        /// <summary>
        ///     Type the secondary email address for the contact.
        /// </summary>
        [AttributeLogicalName("emailaddress2")]
        public string EMailAddress2
        {
            get { return GetAttributeValue<string>("emailaddress2"); }
            set
            {
                OnPropertyChanging("EMailAddress2");
                SetAttributeValue("emailaddress2", value);
                OnPropertyChanged("EMailAddress2");
            }
        }

        /// <summary>
        ///     Type an alternate email address for the contact.
        /// </summary>
        [AttributeLogicalName("emailaddress3")]
        public string EMailAddress3
        {
            get { return GetAttributeValue<string>("emailaddress3"); }
            set
            {
                OnPropertyChanging("EMailAddress3");
                SetAttributeValue("emailaddress3", value);
                OnPropertyChanged("EMailAddress3");
            }
        }

        /// <summary>
        ///     Type the employee ID or number for the contact for reference in orders, service cases, or other communications with
        ///     the contact's organization.
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
        ///     Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the
        ///     record from the local currency to the system's default currency.
        /// </summary>
        [AttributeLogicalName("exchangerate")]
        public decimal? ExchangeRate
        {
            get { return GetAttributeValue<decimal?>("exchangerate"); }
        }

        /// <summary>
        ///     Identifier for an external user.
        /// </summary>
        [AttributeLogicalName("externaluseridentifier")]
        public string ExternalUserIdentifier
        {
            get { return GetAttributeValue<string>("externaluseridentifier"); }
            set
            {
                OnPropertyChanging("ExternalUserIdentifier");
                SetAttributeValue("externaluseridentifier", value);
                OnPropertyChanged("ExternalUserIdentifier");
            }
        }

        /// <summary>
        ///     Select the marital status of the contact for reference in follow-up phone calls and other communications.
        /// </summary>
        [AttributeLogicalName("familystatuscode")]
        public OptionSetValue FamilyStatusCode
        {
            get { return GetAttributeValue<OptionSetValue>("familystatuscode"); }
            set
            {
                OnPropertyChanging("FamilyStatusCode");
                SetAttributeValue("familystatuscode", value);
                OnPropertyChanged("FamilyStatusCode");
            }
        }

        /// <summary>
        ///     Type the fax number for the contact.
        /// </summary>
        [AttributeLogicalName("fax")]
        public string Fax
        {
            get { return GetAttributeValue<string>("fax"); }
            set
            {
                OnPropertyChanging("Fax");
                SetAttributeValue("fax", value);
                OnPropertyChanged("Fax");
            }
        }

        /// <summary>
        ///     Type the contact's first name to make sure the contact is addressed correctly in sales calls, email, and marketing
        ///     campaigns.
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
        ///     Type the URL for the contact's FTP site to enable users to access data and share documents.
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
        ///     Combines and shows the contact's first and last names so that the full name can be displayed in views and reports.
        /// </summary>
        [AttributeLogicalName("fullname")]
        public string FullName
        {
            get { return GetAttributeValue<string>("fullname"); }
        }

        /// <summary>
        ///     Select the contact's gender to make sure the contact is addressed correctly in sales calls, email, and marketing
        ///     campaigns.
        /// </summary>
        [AttributeLogicalName("gendercode")]
        public OptionSetValue GenderCode
        {
            get { return GetAttributeValue<OptionSetValue>("gendercode"); }
            set
            {
                OnPropertyChanging("GenderCode");
                SetAttributeValue("gendercode", value);
                OnPropertyChanged("GenderCode");
            }
        }

        /// <summary>
        ///     Type the passport number or other government ID for the contact for use in documents or reports.
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
        ///     Select whether the contact has any children for reference in follow-up phone calls and other communications.
        /// </summary>
        [AttributeLogicalName("haschildrencode")]
        public OptionSetValue HasChildrenCode
        {
            get { return GetAttributeValue<OptionSetValue>("haschildrencode"); }
            set
            {
                OnPropertyChanging("HasChildrenCode");
                SetAttributeValue("haschildrencode", value);
                OnPropertyChanged("HasChildrenCode");
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
        ///     Select whether the contact exists in a separate accounting or other system, such as Microsoft Dynamics GP or
        ///     another ERP database, for use in integration processes.
        /// </summary>
        [AttributeLogicalName("isbackofficecustomer")]
        public bool? IsBackofficeCustomer
        {
            get { return GetAttributeValue<bool?>("isbackofficecustomer"); }
            set
            {
                OnPropertyChanging("IsBackofficeCustomer");
                SetAttributeValue("isbackofficecustomer", value);
                OnPropertyChanged("IsBackofficeCustomer");
            }
        }

        /// <summary>
        ///     Type the job title of the contact to make sure the contact is addressed correctly in sales calls, email, and
        ///     marketing campaigns.
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
        ///     Type the contact's last name to make sure the contact is addressed correctly in sales calls, email, and marketing
        ///     campaigns.
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
        ///     Shows the date when the contact was last included in a marketing campaign or quick campaign.
        /// </summary>
        [AttributeLogicalName("lastusedincampaign")]
        public DateTime? LastUsedInCampaign
        {
            get { return GetAttributeValue<DateTime?>("lastusedincampaign"); }
            set
            {
                OnPropertyChanging("LastUsedInCampaign");
                SetAttributeValue("lastusedincampaign", value);
                OnPropertyChanged("LastUsedInCampaign");
            }
        }

        /// <summary>
        ///     Select the primary marketing source that directed the contact to your organization.
        /// </summary>
        [AttributeLogicalName("leadsourcecode")]
        public OptionSetValue LeadSourceCode
        {
            get { return GetAttributeValue<OptionSetValue>("leadsourcecode"); }
            set
            {
                OnPropertyChanging("LeadSourceCode");
                SetAttributeValue("leadsourcecode", value);
                OnPropertyChanged("LeadSourceCode");
            }
        }

        /// <summary>
        ///     Type the name of the contact's manager for use in escalating issues or other follow-up communications with the
        ///     contact.
        /// </summary>
        [AttributeLogicalName("managername")]
        public string ManagerName
        {
            get { return GetAttributeValue<string>("managername"); }
            set
            {
                OnPropertyChanging("ManagerName");
                SetAttributeValue("managername", value);
                OnPropertyChanged("ManagerName");
            }
        }

        /// <summary>
        ///     Type the phone number for the contact's manager.
        /// </summary>
        [AttributeLogicalName("managerphone")]
        public string ManagerPhone
        {
            get { return GetAttributeValue<string>("managerphone"); }
            set
            {
                OnPropertyChanging("ManagerPhone");
                SetAttributeValue("managerphone", value);
                OnPropertyChanged("ManagerPhone");
            }
        }

        /// <summary>
        ///     Unique identifier of the master contact for merge.
        /// </summary>
        [AttributeLogicalName("masterid")]
        public EntityReference MasterId
        {
            get { return GetAttributeValue<EntityReference>("masterid"); }
        }

        /// <summary>
        ///     Shows whether the account has been merged with a master contact.
        /// </summary>
        [AttributeLogicalName("merged")]
        public bool? Merged
        {
            get { return GetAttributeValue<bool?>("merged"); }
        }

        /// <summary>
        ///     Type the contact's middle name or initial to make sure the contact is addressed correctly.
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
        ///     Type the mobile phone number for the contact.
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
        ///     Shows who last updated the record.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected
        ///     in Microsoft Dynamics CRM options.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Shows who last updated the record on behalf of another user.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Type the contact's nickname.
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
        ///     Type the number of children the contact has for reference in follow-up phone calls and other communications.
        /// </summary>
        [AttributeLogicalName("numberofchildren")]
        public int? NumberOfChildren
        {
            get { return GetAttributeValue<int?>("numberofchildren"); }
            set
            {
                OnPropertyChanging("NumberOfChildren");
                SetAttributeValue("numberofchildren", value);
                OnPropertyChanged("NumberOfChildren");
            }
        }

        /// <summary>
        ///     Shows the lead that the contact was created if the contact was created by converting a lead in Microsoft Dynamics
        ///     CRM. This is used to relate the contact to the data on the originating lead for use in reporting and analytics.
        /// </summary>
        [AttributeLogicalName("originatingleadid")]
        public EntityReference OriginatingLeadId
        {
            get { return GetAttributeValue<EntityReference>("originatingleadid"); }
            set
            {
                OnPropertyChanging("OriginatingLeadId");
                SetAttributeValue("originatingleadid", value);
                OnPropertyChanged("OriginatingLeadId");
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
        ///     Enter the user or team who is assigned to manage the record. This field is updated every time the record is
        ///     assigned to a different user.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId
        {
            get { return GetAttributeValue<EntityReference>("ownerid"); }
            set
            {
                OnPropertyChanging("OwnerId");
                SetAttributeValue("ownerid", value);
                OnPropertyChanged("OwnerId");
            }
        }

        /// <summary>
        ///     Unique identifier of the business unit that owns the contact.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the contact.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the contact.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Type the pager number for the contact.
        /// </summary>
        [AttributeLogicalName("pager")]
        public string Pager
        {
            get { return GetAttributeValue<string>("pager"); }
            set
            {
                OnPropertyChanging("Pager");
                SetAttributeValue("pager", value);
                OnPropertyChanged("Pager");
            }
        }

        /// <summary>
        ///     Unique identifier of the parent contact.
        /// </summary>
        [AttributeLogicalName("parentcontactid")]
        public EntityReference ParentContactId
        {
            get { return GetAttributeValue<EntityReference>("parentcontactid"); }
        }

        /// <summary>
        ///     Select the parent account or parent contact for the contact to provide a quick link to additional details, such as
        ///     financial information, activities, and opportunities.
        /// </summary>
        [AttributeLogicalName("parentcustomerid")]
        public EntityReference ParentCustomerId
        {
            get { return GetAttributeValue<EntityReference>("parentcustomerid"); }
            set
            {
                OnPropertyChanging("ParentCustomerId");
                SetAttributeValue("parentcustomerid", value);
                OnPropertyChanged("ParentCustomerId");
            }
        }

        /// <summary>
        ///     Shows whether the contact participates in workflow rules.
        /// </summary>
        [AttributeLogicalName("participatesinworkflow")]
        public bool? ParticipatesInWorkflow
        {
            get { return GetAttributeValue<bool?>("participatesinworkflow"); }
            set
            {
                OnPropertyChanging("ParticipatesInWorkflow");
                SetAttributeValue("participatesinworkflow", value);
                OnPropertyChanged("ParticipatesInWorkflow");
            }
        }

        /// <summary>
        ///     Select the payment terms to indicate when the customer needs to pay the total amount.
        /// </summary>
        [AttributeLogicalName("paymenttermscode")]
        public OptionSetValue PaymentTermsCode
        {
            get { return GetAttributeValue<OptionSetValue>("paymenttermscode"); }
            set
            {
                OnPropertyChanging("PaymentTermsCode");
                SetAttributeValue("paymenttermscode", value);
                OnPropertyChanged("PaymentTermsCode");
            }
        }

        /// <summary>
        ///     Select the preferred day of the week for service appointments.
        /// </summary>
        [AttributeLogicalName("preferredappointmentdaycode")]
        public OptionSetValue PreferredAppointmentDayCode
        {
            get { return GetAttributeValue<OptionSetValue>("preferredappointmentdaycode"); }
            set
            {
                OnPropertyChanging("PreferredAppointmentDayCode");
                SetAttributeValue("preferredappointmentdaycode", value);
                OnPropertyChanged("PreferredAppointmentDayCode");
            }
        }

        /// <summary>
        ///     Select the preferred time of day for service appointments.
        /// </summary>
        [AttributeLogicalName("preferredappointmenttimecode")]
        public OptionSetValue PreferredAppointmentTimeCode
        {
            get { return GetAttributeValue<OptionSetValue>("preferredappointmenttimecode"); }
            set
            {
                OnPropertyChanging("PreferredAppointmentTimeCode");
                SetAttributeValue("preferredappointmenttimecode", value);
                OnPropertyChanged("PreferredAppointmentTimeCode");
            }
        }

        /// <summary>
        ///     Select the preferred method of contact.
        /// </summary>
        [AttributeLogicalName("preferredcontactmethodcode")]
        public OptionSetValue PreferredContactMethodCode
        {
            get { return GetAttributeValue<OptionSetValue>("preferredcontactmethodcode"); }
            set
            {
                OnPropertyChanging("PreferredContactMethodCode");
                SetAttributeValue("preferredcontactmethodcode", value);
                OnPropertyChanged("PreferredContactMethodCode");
            }
        }

        /// <summary>
        ///     Choose the contact's preferred service facility or equipment to make sure services are scheduled correctly for the
        ///     customer.
        /// </summary>
        [AttributeLogicalName("preferredequipmentid")]
        public EntityReference PreferredEquipmentId
        {
            get { return GetAttributeValue<EntityReference>("preferredequipmentid"); }
            set
            {
                OnPropertyChanging("PreferredEquipmentId");
                SetAttributeValue("preferredequipmentid", value);
                OnPropertyChanged("PreferredEquipmentId");
            }
        }

        /// <summary>
        ///     Choose the contact's preferred service to make sure services are scheduled correctly for the customer.
        /// </summary>
        [AttributeLogicalName("preferredserviceid")]
        public EntityReference PreferredServiceId
        {
            get { return GetAttributeValue<EntityReference>("preferredserviceid"); }
            set
            {
                OnPropertyChanging("PreferredServiceId");
                SetAttributeValue("preferredserviceid", value);
                OnPropertyChanged("PreferredServiceId");
            }
        }

        /// <summary>
        ///     Choose the regular or preferred customer service representative for reference when scheduling service activities
        ///     for the contact.
        /// </summary>
        [AttributeLogicalName("preferredsystemuserid")]
        public EntityReference PreferredSystemUserId
        {
            get { return GetAttributeValue<EntityReference>("preferredsystemuserid"); }
            set
            {
                OnPropertyChanging("PreferredSystemUserId");
                SetAttributeValue("preferredsystemuserid", value);
                OnPropertyChanged("PreferredSystemUserId");
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
        ///     Type the salutation of the contact to make sure the contact is addressed correctly in sales calls, email messages,
        ///     and marketing campaigns.
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
        ///     Select a shipping method for deliveries sent to this address.
        /// </summary>
        [AttributeLogicalName("shippingmethodcode")]
        public OptionSetValue ShippingMethodCode
        {
            get { return GetAttributeValue<OptionSetValue>("shippingmethodcode"); }
            set
            {
                OnPropertyChanging("ShippingMethodCode");
                SetAttributeValue("shippingmethodcode", value);
                OnPropertyChanged("ShippingMethodCode");
            }
        }

        /// <summary>
        ///     Type the name of the contact's spouse or partner for reference during calls, events, or other communications with
        ///     the contact.
        /// </summary>
        [AttributeLogicalName("spousesname")]
        public string SpousesName
        {
            get { return GetAttributeValue<string>("spousesname"); }
            set
            {
                OnPropertyChanging("SpousesName");
                SetAttributeValue("spousesname", value);
                OnPropertyChanged("SpousesName");
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
        ///     Shows whether the contact is active or inactive. Inactive contacts are read-only and can't be edited unless they
        ///     are reactivated.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public ContactState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ContactState) (Enum.ToObject(typeof (ContactState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Select the contact's status.
        /// </summary>
        [AttributeLogicalName("statuscode")]
        public OptionSetValue StatusCode
        {
            get { return GetAttributeValue<OptionSetValue>("statuscode"); }
            set
            {
                OnPropertyChanging("StatusCode");
                SetAttributeValue("statuscode", value);
                OnPropertyChanged("StatusCode");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("subscriptionid")]
        public Guid? SubscriptionId
        {
            get { return GetAttributeValue<Guid?>("subscriptionid"); }
            set
            {
                OnPropertyChanging("SubscriptionId");
                SetAttributeValue("subscriptionid", value);
                OnPropertyChanged("SubscriptionId");
            }
        }

        /// <summary>
        ///     Type the suffix used in the contact's name, such as Jr. or Sr. to make sure the contact is addressed correctly in
        ///     sales calls, email, and marketing campaigns.
        /// </summary>
        [AttributeLogicalName("suffix")]
        public string Suffix
        {
            get { return GetAttributeValue<string>("suffix"); }
            set
            {
                OnPropertyChanging("Suffix");
                SetAttributeValue("suffix", value);
                OnPropertyChanged("Suffix");
            }
        }

        /// <summary>
        ///     Type the main phone number for this contact.
        /// </summary>
        [AttributeLogicalName("telephone1")]
        public string Telephone1
        {
            get { return GetAttributeValue<string>("telephone1"); }
            set
            {
                OnPropertyChanging("Telephone1");
                SetAttributeValue("telephone1", value);
                OnPropertyChanged("Telephone1");
            }
        }

        /// <summary>
        ///     Type a second phone number for this contact.
        /// </summary>
        [AttributeLogicalName("telephone2")]
        public string Telephone2
        {
            get { return GetAttributeValue<string>("telephone2"); }
            set
            {
                OnPropertyChanging("Telephone2");
                SetAttributeValue("telephone2", value);
                OnPropertyChanged("Telephone2");
            }
        }

        /// <summary>
        ///     Type a third phone number for this contact.
        /// </summary>
        [AttributeLogicalName("telephone3")]
        public string Telephone3
        {
            get { return GetAttributeValue<string>("telephone3"); }
            set
            {
                OnPropertyChanging("Telephone3");
                SetAttributeValue("telephone3", value);
                OnPropertyChanged("Telephone3");
            }
        }

        /// <summary>
        ///     Select a region or territory for the contact for use in segmentation and analysis.
        /// </summary>
        [AttributeLogicalName("territorycode")]
        public OptionSetValue TerritoryCode
        {
            get { return GetAttributeValue<OptionSetValue>("territorycode"); }
            set
            {
                OnPropertyChanging("TerritoryCode");
                SetAttributeValue("territorycode", value);
                OnPropertyChanged("TerritoryCode");
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
        ///     Choose the local currency for the record to make sure budgets are reported in the correct currency.
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
        ///     Version number of the contact.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     Type the contact's professional or personal website or blog URL.
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
        ///     Type the phonetic spelling of the contact's first name, if the name is specified in Japanese, to make sure the name
        ///     is pronounced correctly in phone calls with the contact.
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
        ///     Shows the combined Yomi first and last names of the contact so that the full phonetic name can be displayed in
        ///     views and reports.
        /// </summary>
        [AttributeLogicalName("yomifullname")]
        public string YomiFullName
        {
            get { return GetAttributeValue<string>("yomifullname"); }
        }

        /// <summary>
        ///     Type the phonetic spelling of the contact's last name, if the name is specified in Japanese, to make sure the name
        ///     is pronounced correctly in phone calls with the contact.
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
        ///     Type the phonetic spelling of the contact's middle name, if the name is specified in Japanese, to make sure the
        ///     name is pronounced correctly in phone calls with the contact.
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
        ///     1:N account_primary_contact
        /// </summary>
        [RelationshipSchemaName("account_primary_contact")]
        public IEnumerable<Account> account_primary_contact
        {
            get { return GetRelatedEntities<Account>("account_primary_contact", null); }
            set
            {
                OnPropertyChanging("account_primary_contact");
                SetRelatedEntities("account_primary_contact", null, value);
                OnPropertyChanged("account_primary_contact");
            }
        }

        /// <summary>
        ///     1:N contact_activity_parties
        /// </summary>
        [RelationshipSchemaName("contact_activity_parties")]
        public IEnumerable<ActivityParty> contact_activity_parties
        {
            get { return GetRelatedEntities<ActivityParty>("contact_activity_parties", null); }
            set
            {
                OnPropertyChanging("contact_activity_parties");
                SetRelatedEntities("contact_activity_parties", null, value);
                OnPropertyChanged("contact_activity_parties");
            }
        }

        /// <summary>
        ///     1:N Contact_ActivityPointers
        /// </summary>
        [RelationshipSchemaName("Contact_ActivityPointers")]
        public IEnumerable<ActivityPointer> Contact_ActivityPointers
        {
            get { return GetRelatedEntities<ActivityPointer>("Contact_ActivityPointers", null); }
            set
            {
                OnPropertyChanging("Contact_ActivityPointers");
                SetRelatedEntities("Contact_ActivityPointers", null, value);
                OnPropertyChanged("Contact_ActivityPointers");
            }
        }

        /// <summary>
        ///     1:N Contact_Annotation
        /// </summary>
        [RelationshipSchemaName("Contact_Annotation")]
        public IEnumerable<Annotation> Contact_Annotation
        {
            get { return GetRelatedEntities<Annotation>("Contact_Annotation", null); }
            set
            {
                OnPropertyChanging("Contact_Annotation");
                SetRelatedEntities("Contact_Annotation", null, value);
                OnPropertyChanged("Contact_Annotation");
            }
        }

        /// <summary>
        ///     1:N Contact_Appointments
        /// </summary>
        [RelationshipSchemaName("Contact_Appointments")]
        public IEnumerable<Appointment> Contact_Appointments
        {
            get { return GetRelatedEntities<Appointment>("Contact_Appointments", null); }
            set
            {
                OnPropertyChanging("Contact_Appointments");
                SetRelatedEntities("Contact_Appointments", null, value);
                OnPropertyChanged("Contact_Appointments");
            }
        }

        /// <summary>
        ///     1:N contact_as_responsible_contact
        /// </summary>
        [RelationshipSchemaName("contact_as_responsible_contact")]
        public IEnumerable<Incident> contact_as_responsible_contact
        {
            get { return GetRelatedEntities<Incident>("contact_as_responsible_contact", null); }
            set
            {
                OnPropertyChanging("contact_as_responsible_contact");
                SetRelatedEntities("contact_as_responsible_contact", null, value);
                OnPropertyChanged("contact_as_responsible_contact");
            }
        }

        /// <summary>
        ///     1:N Contact_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Contact_AsyncOperations")]
        public IEnumerable<AsyncOperation> Contact_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Contact_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Contact_AsyncOperations");
                SetRelatedEntities("Contact_AsyncOperations", null, value);
                OnPropertyChanged("Contact_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N Contact_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("Contact_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> Contact_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("Contact_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("Contact_BulkDeleteFailures");
                SetRelatedEntities("Contact_BulkDeleteFailures", null, value);
                OnPropertyChanged("Contact_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N contact_connections1
        /// </summary>
        [RelationshipSchemaName("contact_connections1")]
        public IEnumerable<Connection> contact_connections1
        {
            get { return GetRelatedEntities<Connection>("contact_connections1", null); }
            set
            {
                OnPropertyChanging("contact_connections1");
                SetRelatedEntities("contact_connections1", null, value);
                OnPropertyChanged("contact_connections1");
            }
        }

        /// <summary>
        ///     1:N contact_connections2
        /// </summary>
        [RelationshipSchemaName("contact_connections2")]
        public IEnumerable<Connection> contact_connections2
        {
            get { return GetRelatedEntities<Connection>("contact_connections2", null); }
            set
            {
                OnPropertyChanging("contact_connections2");
                SetRelatedEntities("contact_connections2", null, value);
                OnPropertyChanged("contact_connections2");
            }
        }

        /// <summary>
        ///     1:N contact_customer_contacts
        /// </summary>
        [RelationshipSchemaName("contact_customer_contacts", EntityRole.Referenced)]
        public IEnumerable<Contact> Referencedcontact_customer_contacts
        {
            get { return GetRelatedEntities<Contact>("contact_customer_contacts", EntityRole.Referenced); }
            set
            {
                OnPropertyChanging("Referencedcontact_customer_contacts");
                SetRelatedEntities("contact_customer_contacts", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedcontact_customer_contacts");
            }
        }

        /// <summary>
        ///     1:N contact_customer_opportunity_roles
        /// </summary>
        [RelationshipSchemaName("contact_customer_opportunity_roles")]
        public IEnumerable<CustomerOpportunityRole> contact_customer_opportunity_roles
        {
            get { return GetRelatedEntities<CustomerOpportunityRole>("contact_customer_opportunity_roles", null); }
            set
            {
                OnPropertyChanging("contact_customer_opportunity_roles");
                SetRelatedEntities("contact_customer_opportunity_roles", null, value);
                OnPropertyChanged("contact_customer_opportunity_roles");
            }
        }

        /// <summary>
        ///     1:N contact_customer_relationship_customer
        /// </summary>
        [RelationshipSchemaName("contact_customer_relationship_customer")]
        public IEnumerable<CustomerRelationship> contact_customer_relationship_customer
        {
            get { return GetRelatedEntities<CustomerRelationship>("contact_customer_relationship_customer", null); }
            set
            {
                OnPropertyChanging("contact_customer_relationship_customer");
                SetRelatedEntities("contact_customer_relationship_customer", null, value);
                OnPropertyChanged("contact_customer_relationship_customer");
            }
        }

        /// <summary>
        ///     1:N contact_customer_relationship_partner
        /// </summary>
        [RelationshipSchemaName("contact_customer_relationship_partner")]
        public IEnumerable<CustomerRelationship> contact_customer_relationship_partner
        {
            get { return GetRelatedEntities<CustomerRelationship>("contact_customer_relationship_partner", null); }
            set
            {
                OnPropertyChanging("contact_customer_relationship_partner");
                SetRelatedEntities("contact_customer_relationship_partner", null, value);
                OnPropertyChanged("contact_customer_relationship_partner");
            }
        }

        /// <summary>
        ///     1:N Contact_CustomerAddress
        /// </summary>
        [RelationshipSchemaName("Contact_CustomerAddress")]
        public IEnumerable<CustomerAddress> Contact_CustomerAddress
        {
            get { return GetRelatedEntities<CustomerAddress>("Contact_CustomerAddress", null); }
            set
            {
                OnPropertyChanging("Contact_CustomerAddress");
                SetRelatedEntities("Contact_CustomerAddress", null, value);
                OnPropertyChanged("Contact_CustomerAddress");
            }
        }

        /// <summary>
        ///     1:N Contact_DuplicateBaseRecord
        /// </summary>
        [RelationshipSchemaName("Contact_DuplicateBaseRecord")]
        public IEnumerable<DuplicateRecord> Contact_DuplicateBaseRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Contact_DuplicateBaseRecord", null); }
            set
            {
                OnPropertyChanging("Contact_DuplicateBaseRecord");
                SetRelatedEntities("Contact_DuplicateBaseRecord", null, value);
                OnPropertyChanged("Contact_DuplicateBaseRecord");
            }
        }

        /// <summary>
        ///     1:N Contact_DuplicateMatchingRecord
        /// </summary>
        [RelationshipSchemaName("Contact_DuplicateMatchingRecord")]
        public IEnumerable<DuplicateRecord> Contact_DuplicateMatchingRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Contact_DuplicateMatchingRecord", null); }
            set
            {
                OnPropertyChanging("Contact_DuplicateMatchingRecord");
                SetRelatedEntities("Contact_DuplicateMatchingRecord", null, value);
                OnPropertyChanged("Contact_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        ///     1:N Contact_Emails
        /// </summary>
        [RelationshipSchemaName("Contact_Emails")]
        public IEnumerable<Email> Contact_Emails
        {
            get { return GetRelatedEntities<Email>("Contact_Emails", null); }
            set
            {
                OnPropertyChanging("Contact_Emails");
                SetRelatedEntities("Contact_Emails", null, value);
                OnPropertyChanged("Contact_Emails");
            }
        }

        /// <summary>
        ///     1:N Contact_Faxes
        /// </summary>
        [RelationshipSchemaName("Contact_Faxes")]
        public IEnumerable<Fax> Contact_Faxes
        {
            get { return GetRelatedEntities<Fax>("Contact_Faxes", null); }
            set
            {
                OnPropertyChanging("Contact_Faxes");
                SetRelatedEntities("Contact_Faxes", null, value);
                OnPropertyChanged("Contact_Faxes");
            }
        }

        /// <summary>
        ///     1:N Contact_Letters
        /// </summary>
        [RelationshipSchemaName("Contact_Letters")]
        public IEnumerable<Letter> Contact_Letters
        {
            get { return GetRelatedEntities<Letter>("Contact_Letters", null); }
            set
            {
                OnPropertyChanging("Contact_Letters");
                SetRelatedEntities("Contact_Letters", null, value);
                OnPropertyChanged("Contact_Letters");
            }
        }

        /// <summary>
        ///     1:N contact_master_contact
        /// </summary>
        [RelationshipSchemaName("contact_master_contact", EntityRole.Referenced)]
        public IEnumerable<Contact> Referencedcontact_master_contact
        {
            get { return GetRelatedEntities<Contact>("contact_master_contact", EntityRole.Referenced); }
            set
            {
                OnPropertyChanging("Referencedcontact_master_contact");
                SetRelatedEntities("contact_master_contact", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedcontact_master_contact");
            }
        }

        /// <summary>
        ///     1:N Contact_Phonecalls
        /// </summary>
        [RelationshipSchemaName("Contact_Phonecalls")]
        public IEnumerable<PhoneCall> Contact_Phonecalls
        {
            get { return GetRelatedEntities<PhoneCall>("Contact_Phonecalls", null); }
            set
            {
                OnPropertyChanging("Contact_Phonecalls");
                SetRelatedEntities("Contact_Phonecalls", null, value);
                OnPropertyChanged("Contact_Phonecalls");
            }
        }

        /// <summary>
        ///     1:N contact_PostFollows
        /// </summary>
        [RelationshipSchemaName("contact_PostFollows")]
        public IEnumerable<PostFollow> contact_PostFollows
        {
            get { return GetRelatedEntities<PostFollow>("contact_PostFollows", null); }
            set
            {
                OnPropertyChanging("contact_PostFollows");
                SetRelatedEntities("contact_PostFollows", null, value);
                OnPropertyChanged("contact_PostFollows");
            }
        }

        /// <summary>
        ///     1:N contact_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("contact_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> contact_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntities<PrincipalObjectAttributeAccess>("contact_principalobjectattributeaccess", null);
            }
            set
            {
                OnPropertyChanging("contact_principalobjectattributeaccess");
                SetRelatedEntities("contact_principalobjectattributeaccess", null, value);
                OnPropertyChanged("contact_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N Contact_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("Contact_ProcessSessions")]
        public IEnumerable<ProcessSession> Contact_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("Contact_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Contact_ProcessSessions");
                SetRelatedEntities("Contact_ProcessSessions", null, value);
                OnPropertyChanged("Contact_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N Contact_RecurringAppointmentMasters
        /// </summary>
        [RelationshipSchemaName("Contact_RecurringAppointmentMasters")]
        public IEnumerable<RecurringAppointmentMaster> Contact_RecurringAppointmentMasters
        {
            get { return GetRelatedEntities<RecurringAppointmentMaster>("Contact_RecurringAppointmentMasters", null); }
            set
            {
                OnPropertyChanging("Contact_RecurringAppointmentMasters");
                SetRelatedEntities("Contact_RecurringAppointmentMasters", null, value);
                OnPropertyChanged("Contact_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        ///     1:N Contact_ServiceAppointments
        /// </summary>
        [RelationshipSchemaName("Contact_ServiceAppointments")]
        public IEnumerable<ServiceAppointment> Contact_ServiceAppointments
        {
            get { return GetRelatedEntities<ServiceAppointment>("Contact_ServiceAppointments", null); }
            set
            {
                OnPropertyChanging("Contact_ServiceAppointments");
                SetRelatedEntities("Contact_ServiceAppointments", null, value);
                OnPropertyChanged("Contact_ServiceAppointments");
            }
        }

        /// <summary>
        ///     1:N Contact_Tasks
        /// </summary>
        [RelationshipSchemaName("Contact_Tasks")]
        public IEnumerable<Task> Contact_Tasks
        {
            get { return GetRelatedEntities<Task>("Contact_Tasks", null); }
            set
            {
                OnPropertyChanging("Contact_Tasks");
                SetRelatedEntities("Contact_Tasks", null, value);
                OnPropertyChanged("Contact_Tasks");
            }
        }

        /// <summary>
        ///     1:N contract_billingcustomer_contacts
        /// </summary>
        [RelationshipSchemaName("contract_billingcustomer_contacts")]
        public IEnumerable<Contract> contract_billingcustomer_contacts
        {
            get { return GetRelatedEntities<Contract>("contract_billingcustomer_contacts", null); }
            set
            {
                OnPropertyChanging("contract_billingcustomer_contacts");
                SetRelatedEntities("contract_billingcustomer_contacts", null, value);
                OnPropertyChanged("contract_billingcustomer_contacts");
            }
        }

        /// <summary>
        ///     1:N contract_customer_contacts
        /// </summary>
        [RelationshipSchemaName("contract_customer_contacts")]
        public IEnumerable<Contract> contract_customer_contacts
        {
            get { return GetRelatedEntities<Contract>("contract_customer_contacts", null); }
            set
            {
                OnPropertyChanging("contract_customer_contacts");
                SetRelatedEntities("contract_customer_contacts", null, value);
                OnPropertyChanged("contract_customer_contacts");
            }
        }

        /// <summary>
        ///     1:N contractlineitem_customer_contacts
        /// </summary>
        [RelationshipSchemaName("contractlineitem_customer_contacts")]
        public IEnumerable<ContractDetail> contractlineitem_customer_contacts
        {
            get { return GetRelatedEntities<ContractDetail>("contractlineitem_customer_contacts", null); }
            set
            {
                OnPropertyChanging("contractlineitem_customer_contacts");
                SetRelatedEntities("contractlineitem_customer_contacts", null, value);
                OnPropertyChanged("contractlineitem_customer_contacts");
            }
        }

        /// <summary>
        ///     1:N CreatedContact_BulkOperationLogs
        /// </summary>
        [RelationshipSchemaName("CreatedContact_BulkOperationLogs")]
        public IEnumerable<BulkOperationLog> CreatedContact_BulkOperationLogs
        {
            get { return GetRelatedEntities<BulkOperationLog>("CreatedContact_BulkOperationLogs", null); }
            set
            {
                OnPropertyChanging("CreatedContact_BulkOperationLogs");
                SetRelatedEntities("CreatedContact_BulkOperationLogs", null, value);
                OnPropertyChanged("CreatedContact_BulkOperationLogs");
            }
        }

        /// <summary>
        ///     1:N incident_customer_contacts
        /// </summary>
        [RelationshipSchemaName("incident_customer_contacts")]
        public IEnumerable<Incident> incident_customer_contacts
        {
            get { return GetRelatedEntities<Incident>("incident_customer_contacts", null); }
            set
            {
                OnPropertyChanging("incident_customer_contacts");
                SetRelatedEntities("incident_customer_contacts", null, value);
                OnPropertyChanged("incident_customer_contacts");
            }
        }

        /// <summary>
        ///     1:N invoice_customer_contacts
        /// </summary>
        [RelationshipSchemaName("invoice_customer_contacts")]
        public IEnumerable<Invoice> invoice_customer_contacts
        {
            get { return GetRelatedEntities<Invoice>("invoice_customer_contacts", null); }
            set
            {
                OnPropertyChanging("invoice_customer_contacts");
                SetRelatedEntities("invoice_customer_contacts", null, value);
                OnPropertyChanged("invoice_customer_contacts");
            }
        }

        /// <summary>
        ///     1:N lead_customer_contacts
        /// </summary>
        [RelationshipSchemaName("lead_customer_contacts")]
        public IEnumerable<Lead> lead_customer_contacts
        {
            get { return GetRelatedEntities<Lead>("lead_customer_contacts", null); }
            set
            {
                OnPropertyChanging("lead_customer_contacts");
                SetRelatedEntities("lead_customer_contacts", null, value);
                OnPropertyChanged("lead_customer_contacts");
            }
        }

        /// <summary>
        ///     1:N lead_parent_contact
        /// </summary>
        [RelationshipSchemaName("lead_parent_contact")]
        public IEnumerable<Lead> lead_parent_contact
        {
            get { return GetRelatedEntities<Lead>("lead_parent_contact", null); }
            set
            {
                OnPropertyChanging("lead_parent_contact");
                SetRelatedEntities("lead_parent_contact", null, value);
                OnPropertyChanged("lead_parent_contact");
            }
        }

        /// <summary>
        ///     1:N opportunity_customer_contacts
        /// </summary>
        [RelationshipSchemaName("opportunity_customer_contacts")]
        public IEnumerable<Opportunity> opportunity_customer_contacts
        {
            get { return GetRelatedEntities<Opportunity>("opportunity_customer_contacts", null); }
            set
            {
                OnPropertyChanging("opportunity_customer_contacts");
                SetRelatedEntities("opportunity_customer_contacts", null, value);
                OnPropertyChanged("opportunity_customer_contacts");
            }
        }

        /// <summary>
        ///     1:N opportunity_parent_contact
        /// </summary>
        [RelationshipSchemaName("opportunity_parent_contact")]
        public IEnumerable<Opportunity> opportunity_parent_contact
        {
            get { return GetRelatedEntities<Opportunity>("opportunity_parent_contact", null); }
            set
            {
                OnPropertyChanging("opportunity_parent_contact");
                SetRelatedEntities("opportunity_parent_contact", null, value);
                OnPropertyChanged("opportunity_parent_contact");
            }
        }

        /// <summary>
        ///     1:N order_customer_contacts
        /// </summary>
        [RelationshipSchemaName("order_customer_contacts")]
        public IEnumerable<SalesOrder> order_customer_contacts
        {
            get { return GetRelatedEntities<SalesOrder>("order_customer_contacts", null); }
            set
            {
                OnPropertyChanging("order_customer_contacts");
                SetRelatedEntities("order_customer_contacts", null, value);
                OnPropertyChanged("order_customer_contacts");
            }
        }

        /// <summary>
        ///     1:N quote_customer_contacts
        /// </summary>
        [RelationshipSchemaName("quote_customer_contacts")]
        public IEnumerable<Quote> quote_customer_contacts
        {
            get { return GetRelatedEntities<Quote>("quote_customer_contacts", null); }
            set
            {
                OnPropertyChanging("quote_customer_contacts");
                SetRelatedEntities("quote_customer_contacts", null, value);
                OnPropertyChanged("quote_customer_contacts");
            }
        }

        /// <summary>
        ///     1:N SourceContact_BulkOperationLogs
        /// </summary>
        [RelationshipSchemaName("SourceContact_BulkOperationLogs")]
        public IEnumerable<BulkOperationLog> SourceContact_BulkOperationLogs
        {
            get { return GetRelatedEntities<BulkOperationLog>("SourceContact_BulkOperationLogs", null); }
            set
            {
                OnPropertyChanging("SourceContact_BulkOperationLogs");
                SetRelatedEntities("SourceContact_BulkOperationLogs", null, value);
                OnPropertyChanged("SourceContact_BulkOperationLogs");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_contact
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_contact")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_contact
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_contact", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_contact");
                SetRelatedEntities("userentityinstancedata_contact", null, value);
                OnPropertyChanged("userentityinstancedata_contact");
            }
        }

        /// <summary>
        ///     N:N contactinvoices_association
        /// </summary>
        [RelationshipSchemaName("contactinvoices_association")]
        public IEnumerable<Invoice> contactinvoices_association
        {
            get { return GetRelatedEntities<Invoice>("contactinvoices_association", null); }
            set
            {
                OnPropertyChanging("contactinvoices_association");
                SetRelatedEntities("contactinvoices_association", null, value);
                OnPropertyChanged("contactinvoices_association");
            }
        }

        /// <summary>
        ///     N:N contactleads_association
        /// </summary>
        [RelationshipSchemaName("contactleads_association")]
        public IEnumerable<Lead> contactleads_association
        {
            get { return GetRelatedEntities<Lead>("contactleads_association", null); }
            set
            {
                OnPropertyChanging("contactleads_association");
                SetRelatedEntities("contactleads_association", null, value);
                OnPropertyChanged("contactleads_association");
            }
        }

        /// <summary>
        ///     N:N contactorders_association
        /// </summary>
        [RelationshipSchemaName("contactorders_association")]
        public IEnumerable<SalesOrder> contactorders_association
        {
            get { return GetRelatedEntities<SalesOrder>("contactorders_association", null); }
            set
            {
                OnPropertyChanging("contactorders_association");
                SetRelatedEntities("contactorders_association", null, value);
                OnPropertyChanged("contactorders_association");
            }
        }

        /// <summary>
        ///     N:N contactquotes_association
        /// </summary>
        [RelationshipSchemaName("contactquotes_association")]
        public IEnumerable<Quote> contactquotes_association
        {
            get { return GetRelatedEntities<Quote>("contactquotes_association", null); }
            set
            {
                OnPropertyChanging("contactquotes_association");
                SetRelatedEntities("contactquotes_association", null, value);
                OnPropertyChanged("contactquotes_association");
            }
        }

        /// <summary>
        ///     N:N listcontact_association
        /// </summary>
        [RelationshipSchemaName("listcontact_association")]
        public IEnumerable<List> listcontact_association
        {
            get { return GetRelatedEntities<List>("listcontact_association", null); }
            set
            {
                OnPropertyChanging("listcontact_association");
                SetRelatedEntities("listcontact_association", null, value);
                OnPropertyChanged("listcontact_association");
            }
        }

        /// <summary>
        ///     N:N servicecontractcontacts_association
        /// </summary>
        [RelationshipSchemaName("servicecontractcontacts_association")]
        public IEnumerable<Contract> servicecontractcontacts_association
        {
            get { return GetRelatedEntities<Contract>("servicecontractcontacts_association", null); }
            set
            {
                OnPropertyChanging("servicecontractcontacts_association");
                SetRelatedEntities("servicecontractcontacts_association", null, value);
                OnPropertyChanged("servicecontractcontacts_association");
            }
        }

        /// <summary>
        ///     N:1 business_unit_contacts
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_contacts")]
        public BusinessUnit business_unit_contacts
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_contacts", null); }
        }

        /// <summary>
        ///     N:1 contact_customer_accounts
        /// </summary>
        [AttributeLogicalName("parentcustomerid")]
        [RelationshipSchemaName("contact_customer_accounts")]
        public Account contact_customer_accounts
        {
            get { return GetRelatedEntity<Account>("contact_customer_accounts", null); }
            set
            {
                OnPropertyChanging("contact_customer_accounts");
                SetRelatedEntity("contact_customer_accounts", null, value);
                OnPropertyChanged("contact_customer_accounts");
            }
        }

        /// <summary>
        ///     N:1 contact_customer_contacts
        /// </summary>
        [AttributeLogicalName("parentcustomerid")]
        [RelationshipSchemaName("contact_customer_contacts", EntityRole.Referencing)]
        public Contact Referencingcontact_customer_contacts
        {
            get { return GetRelatedEntity<Contact>("contact_customer_contacts", EntityRole.Referencing); }
            set
            {
                OnPropertyChanging("Referencingcontact_customer_contacts");
                SetRelatedEntity("contact_customer_contacts", EntityRole.Referencing, value);
                OnPropertyChanged("Referencingcontact_customer_contacts");
            }
        }

        /// <summary>
        ///     N:1 contact_master_contact
        /// </summary>
        [AttributeLogicalName("masterid")]
        [RelationshipSchemaName("contact_master_contact", EntityRole.Referencing)]
        public Contact Referencingcontact_master_contact
        {
            get { return GetRelatedEntity<Contact>("contact_master_contact", EntityRole.Referencing); }
        }

        /// <summary>
        ///     N:1 contact_originating_lead
        /// </summary>
        [AttributeLogicalName("originatingleadid")]
        [RelationshipSchemaName("contact_originating_lead")]
        public Lead contact_originating_lead
        {
            get { return GetRelatedEntity<Lead>("contact_originating_lead", null); }
            set
            {
                OnPropertyChanging("contact_originating_lead");
                SetRelatedEntity("contact_originating_lead", null, value);
                OnPropertyChanged("contact_originating_lead");
            }
        }

        /// <summary>
        ///     N:1 contact_owning_user
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("contact_owning_user")]
        public SystemUser contact_owning_user
        {
            get { return GetRelatedEntity<SystemUser>("contact_owning_user", null); }
        }

        /// <summary>
        ///     N:1 equipment_contacts
        /// </summary>
        [AttributeLogicalName("preferredequipmentid")]
        [RelationshipSchemaName("equipment_contacts")]
        public Equipment equipment_contacts
        {
            get { return GetRelatedEntity<Equipment>("equipment_contacts", null); }
            set
            {
                OnPropertyChanging("equipment_contacts");
                SetRelatedEntity("equipment_contacts", null, value);
                OnPropertyChanged("equipment_contacts");
            }
        }

        /// <summary>
        ///     N:1 lk_contact_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_contact_createdonbehalfby")]
        public SystemUser lk_contact_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_contact_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_contact_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_contact_modifiedonbehalfby")]
        public SystemUser lk_contact_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_contact_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_contactbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_contactbase_createdby")]
        public SystemUser lk_contactbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_contactbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_contactbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_contactbase_modifiedby")]
        public SystemUser lk_contactbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_contactbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 price_level_contacts
        /// </summary>
        [AttributeLogicalName("defaultpricelevelid")]
        [RelationshipSchemaName("price_level_contacts")]
        public PriceLevel price_level_contacts
        {
            get { return GetRelatedEntity<PriceLevel>("price_level_contacts", null); }
            set
            {
                OnPropertyChanging("price_level_contacts");
                SetRelatedEntity("price_level_contacts", null, value);
                OnPropertyChanged("price_level_contacts");
            }
        }

        /// <summary>
        ///     N:1 processstage_contact
        /// </summary>
        [AttributeLogicalName("stageid")]
        [RelationshipSchemaName("processstage_contact")]
        public ProcessStage processstage_contact
        {
            get { return GetRelatedEntity<ProcessStage>("processstage_contact", null); }
            set
            {
                OnPropertyChanging("processstage_contact");
                SetRelatedEntity("processstage_contact", null, value);
                OnPropertyChanged("processstage_contact");
            }
        }

        /// <summary>
        ///     N:1 service_contacts
        /// </summary>
        [AttributeLogicalName("preferredserviceid")]
        [RelationshipSchemaName("service_contacts")]
        public Service service_contacts
        {
            get { return GetRelatedEntity<Service>("service_contacts", null); }
            set
            {
                OnPropertyChanging("service_contacts");
                SetRelatedEntity("service_contacts", null, value);
                OnPropertyChanged("service_contacts");
            }
        }

        /// <summary>
        ///     N:1 system_user_contacts
        /// </summary>
        [AttributeLogicalName("preferredsystemuserid")]
        [RelationshipSchemaName("system_user_contacts")]
        public SystemUser system_user_contacts
        {
            get { return GetRelatedEntity<SystemUser>("system_user_contacts", null); }
            set
            {
                OnPropertyChanging("system_user_contacts");
                SetRelatedEntity("system_user_contacts", null, value);
                OnPropertyChanged("system_user_contacts");
            }
        }

        /// <summary>
        ///     N:1 team_contacts
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_contacts")]
        public Team team_contacts
        {
            get { return GetRelatedEntity<Team>("team_contacts", null); }
        }

        /// <summary>
        ///     N:1 transactioncurrency_contact
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("transactioncurrency_contact")]
        public TransactionCurrency transactioncurrency_contact
        {
            get { return GetRelatedEntity<TransactionCurrency>("transactioncurrency_contact", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_contact");
                SetRelatedEntity("transactioncurrency_contact", null, value);
                OnPropertyChanged("transactioncurrency_contact");
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