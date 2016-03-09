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
    ///     Address and shipping information. Used to store additional addresses for a publisher.
    /// </summary>
    [DataContract]
    [EntityLogicalName("publisheraddress")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class PublisherAddress : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "publisheraddress";

        public const int EntityTypeCode = 7102;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public PublisherAddress() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Specifies which publisher address is applicable.
        /// </summary>
        [AttributeLogicalName("addressnumber")]
        public int? AddressNumber
        {
            get { return GetAttributeValue<int?>("addressnumber"); }
            set
            {
                OnPropertyChanging("AddressNumber");
                SetAttributeValue("addressnumber", value);
                OnPropertyChanged("AddressNumber");
            }
        }

        /// <summary>
        ///     Type of address for the publisher, such as billing, shipping, or primary address.
        /// </summary>
        [AttributeLogicalName("addresstypecode")]
        public OptionSetValue AddressTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("addresstypecode"); }
            set
            {
                OnPropertyChanging("AddressTypeCode");
                SetAttributeValue("addresstypecode", value);
                OnPropertyChanged("AddressTypeCode");
            }
        }

        /// <summary>
        ///     City name in the publisher address.
        /// </summary>
        [AttributeLogicalName("city")]
        public string City
        {
            get { return GetAttributeValue<string>("city"); }
            set
            {
                OnPropertyChanging("City");
                SetAttributeValue("city", value);
                OnPropertyChanged("City");
            }
        }

        /// <summary>
        ///     Country/region name in the publisher address.
        /// </summary>
        [AttributeLogicalName("country")]
        public string Country
        {
            get { return GetAttributeValue<string>("country"); }
            set
            {
                OnPropertyChanging("Country");
                SetAttributeValue("country", value);
                OnPropertyChanged("Country");
            }
        }

        /// <summary>
        ///     County name in the publisher address.
        /// </summary>
        [AttributeLogicalName("county")]
        public string County
        {
            get { return GetAttributeValue<string>("county"); }
            set
            {
                OnPropertyChanging("County");
                SetAttributeValue("county", value);
                OnPropertyChanged("County");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the publisher address.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the publisher address was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the publisher address.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Fax number for the publisher address.
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
        ///     Freight terms for the publisher address.
        /// </summary>
        [AttributeLogicalName("freighttermscode")]
        public OptionSetValue FreightTermsCode
        {
            get { return GetAttributeValue<OptionSetValue>("freighttermscode"); }
            set
            {
                OnPropertyChanging("FreightTermsCode");
                SetAttributeValue("freighttermscode", value);
                OnPropertyChanged("FreightTermsCode");
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
        ///     Latitude for the publisher address.
        /// </summary>
        [AttributeLogicalName("latitude")]
        public double? Latitude
        {
            get { return GetAttributeValue<double?>("latitude"); }
            set
            {
                OnPropertyChanging("Latitude");
                SetAttributeValue("latitude", value);
                OnPropertyChanged("Latitude");
            }
        }

        /// <summary>
        ///     First line for entering address information.
        /// </summary>
        [AttributeLogicalName("line1")]
        public string Line1
        {
            get { return GetAttributeValue<string>("line1"); }
            set
            {
                OnPropertyChanging("Line1");
                SetAttributeValue("line1", value);
                OnPropertyChanged("Line1");
            }
        }

        /// <summary>
        ///     Second line for entering address information.
        /// </summary>
        [AttributeLogicalName("line2")]
        public string Line2
        {
            get { return GetAttributeValue<string>("line2"); }
            set
            {
                OnPropertyChanging("Line2");
                SetAttributeValue("line2", value);
                OnPropertyChanged("Line2");
            }
        }

        /// <summary>
        ///     Third line for entering address information.
        /// </summary>
        [AttributeLogicalName("line3")]
        public string Line3
        {
            get { return GetAttributeValue<string>("line3"); }
            set
            {
                OnPropertyChanging("Line3");
                SetAttributeValue("line3", value);
                OnPropertyChanged("Line3");
            }
        }

        /// <summary>
        ///     Longitude for the publisher address.
        /// </summary>
        [AttributeLogicalName("longitude")]
        public double? Longitude
        {
            get { return GetAttributeValue<double?>("longitude"); }
            set
            {
                OnPropertyChanging("Longitude");
                SetAttributeValue("longitude", value);
                OnPropertyChanged("Longitude");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the publisher address.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the publisher address was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who modified the publisher address.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name used to identify the publisher address.
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
        ///     Unique identifier of the parent object with which the publisher address is associated.
        /// </summary>
        [AttributeLogicalName("parentid")]
        public EntityReference ParentId
        {
            get { return GetAttributeValue<EntityReference>("parentid"); }
            set
            {
                OnPropertyChanging("ParentId");
                SetAttributeValue("parentid", value);
                OnPropertyChanged("ParentId");
            }
        }

        /// <summary>
        ///     ZIP Code or postal code in the publisher address.
        /// </summary>
        [AttributeLogicalName("postalcode")]
        public string PostalCode
        {
            get { return GetAttributeValue<string>("postalcode"); }
            set
            {
                OnPropertyChanging("PostalCode");
                SetAttributeValue("postalcode", value);
                OnPropertyChanged("PostalCode");
            }
        }

        /// <summary>
        ///     Post office box number in the publisher address.
        /// </summary>
        [AttributeLogicalName("postofficebox")]
        public string PostOfficeBox
        {
            get { return GetAttributeValue<string>("postofficebox"); }
            set
            {
                OnPropertyChanging("PostOfficeBox");
                SetAttributeValue("postofficebox", value);
                OnPropertyChanged("PostOfficeBox");
            }
        }

        /// <summary>
        ///     Name of the primary contact at the publisher address.
        /// </summary>
        [AttributeLogicalName("primarycontactname")]
        public string PrimaryContactName
        {
            get { return GetAttributeValue<string>("primarycontactname"); }
            set
            {
                OnPropertyChanging("PrimaryContactName");
                SetAttributeValue("primarycontactname", value);
                OnPropertyChanged("PrimaryContactName");
            }
        }

        /// <summary>
        ///     Unique identifier of the publisher address.
        /// </summary>
        [AttributeLogicalName("publisheraddressid")]
        public Guid? PublisherAddressId
        {
            get { return GetAttributeValue<Guid?>("publisheraddressid"); }
            set
            {
                OnPropertyChanging("PublisherAddressId");
                SetAttributeValue("publisheraddressid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("PublisherAddressId");
            }
        }

        [AttributeLogicalName("publisheraddressid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { PublisherAddressId = value; }
        }

        /// <summary>
        ///     Method of shipment for the publisher address.
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
        ///     State or province in the publisher address.
        /// </summary>
        [AttributeLogicalName("stateorprovince")]
        public string StateOrProvince
        {
            get { return GetAttributeValue<string>("stateorprovince"); }
            set
            {
                OnPropertyChanging("StateOrProvince");
                SetAttributeValue("stateorprovince", value);
                OnPropertyChanged("StateOrProvince");
            }
        }

        /// <summary>
        ///     First telephone number for the publisher address.
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
        ///     Second telephone number for the publisher address.
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
        ///     Third telephone number for the publisher address.
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
        ///     United Parcel Service (UPS) zone for the address of the publisher.
        /// </summary>
        [AttributeLogicalName("upszone")]
        public string UPSZone
        {
            get { return GetAttributeValue<string>("upszone"); }
            set
            {
                OnPropertyChanging("UPSZone");
                SetAttributeValue("upszone", value);
                OnPropertyChanged("UPSZone");
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
        ///     UTC offset for the address. This is the difference between local time and standard Coordinated Universal Time.
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
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N userentityinstancedata_publisheraddress
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_publisheraddress")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_publisheraddress
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_publisheraddress", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_publisheraddress");
                SetRelatedEntities("userentityinstancedata_publisheraddress", null, value);
                OnPropertyChanged("userentityinstancedata_publisheraddress");
            }
        }

        /// <summary>
        ///     N:1 lk_publisheraddressbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_publisheraddressbase_createdby")]
        public SystemUser lk_publisheraddressbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_publisheraddressbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_publisheraddressbase_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_publisheraddressbase_createdonbehalfby")]
        public SystemUser lk_publisheraddressbase_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_publisheraddressbase_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_publisheraddressbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_publisheraddressbase_modifiedby")]
        public SystemUser lk_publisheraddressbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_publisheraddressbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_publisheraddressbase_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_publisheraddressbase_modifiedonbehalfby")]
        public SystemUser lk_publisheraddressbase_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_publisheraddressbase_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 Publisher_PublisherAddress
        /// </summary>
        [AttributeLogicalName("parentid")]
        [RelationshipSchemaName("Publisher_PublisherAddress")]
        public Publisher Publisher_PublisherAddress
        {
            get { return GetRelatedEntity<Publisher>("Publisher_PublisherAddress", null); }
            set
            {
                OnPropertyChanging("Publisher_PublisherAddress");
                SetRelatedEntity("Publisher_PublisherAddress", null, value);
                OnPropertyChanged("Publisher_PublisherAddress");
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