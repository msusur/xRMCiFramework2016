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
    ///     Business competing for the sale represented by a lead or opportunity.
    /// </summary>
    [DataContract]
    [EntityLogicalName("competitor")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Competitor : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "competitor";

        public const int EntityTypeCode = 123;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Competitor() :
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
        ///     are made promptly , if shipped by UPS.
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
        ///     Unique identifier of the competitor.
        /// </summary>
        [AttributeLogicalName("competitorid")]
        public Guid? CompetitorId
        {
            get { return GetAttributeValue<Guid?>("competitorid"); }
            set
            {
                OnPropertyChanging("CompetitorId");
                SetAttributeValue("competitorid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("CompetitorId");
            }
        }

        [AttributeLogicalName("competitorid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { CompetitorId = value; }
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
        ///     Type the competitor's primary product, service, or specialty.
        /// </summary>
        [AttributeLogicalName("keyproduct")]
        public string KeyProduct
        {
            get { return GetAttributeValue<string>("keyproduct"); }
            set
            {
                OnPropertyChanging("KeyProduct");
                SetAttributeValue("keyproduct", value);
                OnPropertyChanged("KeyProduct");
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
        ///     Type the company or business name used to identify the competitor in data views and related records.
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
        ///     Type notes or other information about the competitive opportunities or selling points you can make.
        /// </summary>
        [AttributeLogicalName("opportunities")]
        public string Opportunities
        {
            get { return GetAttributeValue<string>("opportunities"); }
            set
            {
                OnPropertyChanging("Opportunities");
                SetAttributeValue("opportunities", value);
                OnPropertyChanged("Opportunities");
            }
        }

        /// <summary>
        ///     Unique identifier of the associated organization.
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
        ///     Type notes or other information about the competitor's business, such as location, revenue, or distribution
        ///     channel.
        /// </summary>
        [AttributeLogicalName("overview")]
        public string Overview
        {
            get { return GetAttributeValue<string>("overview"); }
            set
            {
                OnPropertyChanging("Overview");
                SetAttributeValue("overview", value);
                OnPropertyChanged("Overview");
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
        ///     Type the URL for the website used to obtain reference information about the competitor.
        /// </summary>
        [AttributeLogicalName("referenceinfourl")]
        public string ReferenceInfoUrl
        {
            get { return GetAttributeValue<string>("referenceinfourl"); }
            set
            {
                OnPropertyChanging("ReferenceInfoUrl");
                SetAttributeValue("referenceinfourl", value);
                OnPropertyChanged("ReferenceInfoUrl");
            }
        }

        /// <summary>
        ///     Type the amount of revenue reported in the competitor's annual report or other source.
        /// </summary>
        [AttributeLogicalName("reportedrevenue")]
        public Money ReportedRevenue
        {
            get { return GetAttributeValue<Money>("reportedrevenue"); }
            set
            {
                OnPropertyChanging("ReportedRevenue");
                SetAttributeValue("reportedrevenue", value);
                OnPropertyChanged("ReportedRevenue");
            }
        }

        /// <summary>
        ///     Shows the Reported Revenue field converted to the system's default base currency for reporting purposes. The
        ///     calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("reportedrevenue_base")]
        public Money ReportedRevenue_Base
        {
            get { return GetAttributeValue<Money>("reportedrevenue_base"); }
        }

        /// <summary>
        ///     Type the quarter number during which the competitor's reported revenue was recorded or announced for use in
        ///     reporting and analysis.
        /// </summary>
        [AttributeLogicalName("reportingquarter")]
        public int? ReportingQuarter
        {
            get { return GetAttributeValue<int?>("reportingquarter"); }
            set
            {
                OnPropertyChanging("ReportingQuarter");
                SetAttributeValue("reportingquarter", value);
                OnPropertyChanged("ReportingQuarter");
            }
        }

        /// <summary>
        ///     Type the fiscal year during which the competitor's reported revenue was announced for use in reporting and
        ///     analysis.
        /// </summary>
        [AttributeLogicalName("reportingyear")]
        public int? ReportingYear
        {
            get { return GetAttributeValue<int?>("reportingyear"); }
            set
            {
                OnPropertyChanging("ReportingYear");
                SetAttributeValue("reportingyear", value);
                OnPropertyChanged("ReportingYear");
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
        ///     Type the stock exchange at which the competitor is listed to track their stock and financial performance of the
        ///     company.
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
        ///     Type notes or other information about the competitor's strengths, such as top-selling products and targeted
        ///     industries or markets.
        /// </summary>
        [AttributeLogicalName("strengths")]
        public string Strengths
        {
            get { return GetAttributeValue<string>("strengths"); }
            set
            {
                OnPropertyChanging("Strengths");
                SetAttributeValue("strengths", value);
                OnPropertyChanged("Strengths");
            }
        }

        /// <summary>
        ///     Type notes or other information about the competitor's threats to your organization when you sell to the same
        ///     prospect or customer.
        /// </summary>
        [AttributeLogicalName("threats")]
        public string Threats
        {
            get { return GetAttributeValue<string>("threats"); }
            set
            {
                OnPropertyChanging("Threats");
                SetAttributeValue("threats", value);
                OnPropertyChanged("Threats");
            }
        }

        /// <summary>
        ///     Type the stock exchange symbol for the competitor to track financial performance of the company. You can click the
        ///     code entered in this field to access the latest trading information from MSN Money.
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
        ///     Version number of the competitor.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     Type notes or other information about the competitor's weaknesses or areas in which your organization outperforms
        ///     the competitor.
        /// </summary>
        [AttributeLogicalName("weaknesses")]
        public string Weaknesses
        {
            get { return GetAttributeValue<string>("weaknesses"); }
            set
            {
                OnPropertyChanging("Weaknesses");
                SetAttributeValue("weaknesses", value);
                OnPropertyChanged("Weaknesses");
            }
        }

        /// <summary>
        ///     Type the website URL for the competitor.
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
        ///     Type the percentage of your organization's lost opportunities that are won by the competitor to identify your
        ///     strongest competitors.
        /// </summary>
        [AttributeLogicalName("winpercentage")]
        public double? WinPercentage
        {
            get { return GetAttributeValue<double?>("winpercentage"); }
            set
            {
                OnPropertyChanging("WinPercentage");
                SetAttributeValue("winpercentage", value);
                OnPropertyChanged("WinPercentage");
            }
        }

        /// <summary>
        ///     Type the phonetic spelling of the competitor's name, if specified in Japanese, to make sure the name is pronounced
        ///     correctly in phone calls and other communications.
        /// </summary>
        [AttributeLogicalName("yominame")]
        public string YomiName
        {
            get { return GetAttributeValue<string>("yominame"); }
            set
            {
                OnPropertyChanging("YomiName");
                SetAttributeValue("yominame", value);
                OnPropertyChanged("YomiName");
            }
        }

        /// <summary>
        ///     1:N Competitor_Annotation
        /// </summary>
        [RelationshipSchemaName("Competitor_Annotation")]
        public IEnumerable<Annotation> Competitor_Annotation
        {
            get { return GetRelatedEntities<Annotation>("Competitor_Annotation", null); }
            set
            {
                OnPropertyChanging("Competitor_Annotation");
                SetRelatedEntities("Competitor_Annotation", null, value);
                OnPropertyChanged("Competitor_Annotation");
            }
        }

        /// <summary>
        ///     1:N Competitor_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Competitor_AsyncOperations")]
        public IEnumerable<AsyncOperation> Competitor_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Competitor_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Competitor_AsyncOperations");
                SetRelatedEntities("Competitor_AsyncOperations", null, value);
                OnPropertyChanged("Competitor_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N Competitor_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("Competitor_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> Competitor_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("Competitor_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("Competitor_BulkDeleteFailures");
                SetRelatedEntities("Competitor_BulkDeleteFailures", null, value);
                OnPropertyChanged("Competitor_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N competitor_connections1
        /// </summary>
        [RelationshipSchemaName("competitor_connections1")]
        public IEnumerable<Connection> competitor_connections1
        {
            get { return GetRelatedEntities<Connection>("competitor_connections1", null); }
            set
            {
                OnPropertyChanging("competitor_connections1");
                SetRelatedEntities("competitor_connections1", null, value);
                OnPropertyChanged("competitor_connections1");
            }
        }

        /// <summary>
        ///     1:N competitor_connections2
        /// </summary>
        [RelationshipSchemaName("competitor_connections2")]
        public IEnumerable<Connection> competitor_connections2
        {
            get { return GetRelatedEntities<Connection>("competitor_connections2", null); }
            set
            {
                OnPropertyChanging("competitor_connections2");
                SetRelatedEntities("competitor_connections2", null, value);
                OnPropertyChanged("competitor_connections2");
            }
        }

        /// <summary>
        ///     1:N Competitor_DuplicateBaseRecord
        /// </summary>
        [RelationshipSchemaName("Competitor_DuplicateBaseRecord")]
        public IEnumerable<DuplicateRecord> Competitor_DuplicateBaseRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Competitor_DuplicateBaseRecord", null); }
            set
            {
                OnPropertyChanging("Competitor_DuplicateBaseRecord");
                SetRelatedEntities("Competitor_DuplicateBaseRecord", null, value);
                OnPropertyChanged("Competitor_DuplicateBaseRecord");
            }
        }

        /// <summary>
        ///     1:N Competitor_DuplicateMatchingRecord
        /// </summary>
        [RelationshipSchemaName("Competitor_DuplicateMatchingRecord")]
        public IEnumerable<DuplicateRecord> Competitor_DuplicateMatchingRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Competitor_DuplicateMatchingRecord", null); }
            set
            {
                OnPropertyChanging("Competitor_DuplicateMatchingRecord");
                SetRelatedEntities("Competitor_DuplicateMatchingRecord", null, value);
                OnPropertyChanged("Competitor_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        ///     1:N competitor_opportunity_activities
        /// </summary>
        [RelationshipSchemaName("competitor_opportunity_activities")]
        public IEnumerable<OpportunityClose> competitor_opportunity_activities
        {
            get { return GetRelatedEntities<OpportunityClose>("competitor_opportunity_activities", null); }
            set
            {
                OnPropertyChanging("competitor_opportunity_activities");
                SetRelatedEntities("competitor_opportunity_activities", null, value);
                OnPropertyChanged("competitor_opportunity_activities");
            }
        }

        /// <summary>
        ///     1:N competitor_PostFollows
        /// </summary>
        [RelationshipSchemaName("competitor_PostFollows")]
        public IEnumerable<PostFollow> competitor_PostFollows
        {
            get { return GetRelatedEntities<PostFollow>("competitor_PostFollows", null); }
            set
            {
                OnPropertyChanging("competitor_PostFollows");
                SetRelatedEntities("competitor_PostFollows", null, value);
                OnPropertyChanged("competitor_PostFollows");
            }
        }

        /// <summary>
        ///     1:N competitor_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("competitor_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> competitor_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntities<PrincipalObjectAttributeAccess>("competitor_principalobjectattributeaccess",
                    null);
            }
            set
            {
                OnPropertyChanging("competitor_principalobjectattributeaccess");
                SetRelatedEntities("competitor_principalobjectattributeaccess", null, value);
                OnPropertyChanged("competitor_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N Competitor_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("Competitor_ProcessSessions")]
        public IEnumerable<ProcessSession> Competitor_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("Competitor_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Competitor_ProcessSessions");
                SetRelatedEntities("Competitor_ProcessSessions", null, value);
                OnPropertyChanged("Competitor_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_competitor
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_competitor")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_competitor
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_competitor", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_competitor");
                SetRelatedEntities("userentityinstancedata_competitor", null, value);
                OnPropertyChanged("userentityinstancedata_competitor");
            }
        }

        /// <summary>
        ///     N:N competitorproduct_association
        /// </summary>
        [RelationshipSchemaName("competitorproduct_association")]
        public IEnumerable<Product> competitorproduct_association
        {
            get { return GetRelatedEntities<Product>("competitorproduct_association", null); }
            set
            {
                OnPropertyChanging("competitorproduct_association");
                SetRelatedEntities("competitorproduct_association", null, value);
                OnPropertyChanged("competitorproduct_association");
            }
        }

        /// <summary>
        ///     N:N competitorsalesliterature_association
        /// </summary>
        [RelationshipSchemaName("competitorsalesliterature_association")]
        public IEnumerable<SalesLiterature> competitorsalesliterature_association
        {
            get { return GetRelatedEntities<SalesLiterature>("competitorsalesliterature_association", null); }
            set
            {
                OnPropertyChanging("competitorsalesliterature_association");
                SetRelatedEntities("competitorsalesliterature_association", null, value);
                OnPropertyChanged("competitorsalesliterature_association");
            }
        }

        /// <summary>
        ///     N:N leadcompetitors_association
        /// </summary>
        [RelationshipSchemaName("leadcompetitors_association")]
        public IEnumerable<Lead> leadcompetitors_association
        {
            get { return GetRelatedEntities<Lead>("leadcompetitors_association", null); }
            set
            {
                OnPropertyChanging("leadcompetitors_association");
                SetRelatedEntities("leadcompetitors_association", null, value);
                OnPropertyChanged("leadcompetitors_association");
            }
        }

        /// <summary>
        ///     N:N opportunitycompetitors_association
        /// </summary>
        [RelationshipSchemaName("opportunitycompetitors_association")]
        public IEnumerable<Opportunity> opportunitycompetitors_association
        {
            get { return GetRelatedEntities<Opportunity>("opportunitycompetitors_association", null); }
            set
            {
                OnPropertyChanging("opportunitycompetitors_association");
                SetRelatedEntities("opportunitycompetitors_association", null, value);
                OnPropertyChanged("opportunitycompetitors_association");
            }
        }

        /// <summary>
        ///     N:1 lk_competitor_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_competitor_createdonbehalfby")]
        public SystemUser lk_competitor_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_competitor_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_competitor_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_competitor_modifiedonbehalfby")]
        public SystemUser lk_competitor_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_competitor_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_competitorbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_competitorbase_createdby")]
        public SystemUser lk_competitorbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_competitorbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_competitorbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_competitorbase_modifiedby")]
        public SystemUser lk_competitorbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_competitorbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 organization_competitors
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_competitors")]
        public Organization organization_competitors
        {
            get { return GetRelatedEntity<Organization>("organization_competitors", null); }
        }

        /// <summary>
        ///     N:1 processstage_competitors
        /// </summary>
        [AttributeLogicalName("stageid")]
        [RelationshipSchemaName("processstage_competitors")]
        public ProcessStage processstage_competitors
        {
            get { return GetRelatedEntity<ProcessStage>("processstage_competitors", null); }
            set
            {
                OnPropertyChanging("processstage_competitors");
                SetRelatedEntity("processstage_competitors", null, value);
                OnPropertyChanged("processstage_competitors");
            }
        }

        /// <summary>
        ///     N:1 transactioncurrency_competitor
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("transactioncurrency_competitor")]
        public TransactionCurrency transactioncurrency_competitor
        {
            get { return GetRelatedEntity<TransactionCurrency>("transactioncurrency_competitor", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_competitor");
                SetRelatedEntity("transactioncurrency_competitor", null, value);
                OnPropertyChanged("transactioncurrency_competitor");
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