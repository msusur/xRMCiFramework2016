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
    ///     Address information for a lead.
    /// </summary>
    [DataContract]
    [EntityLogicalName("leadaddress")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class LeadAddress : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "leadaddress";

        public const int EntityTypeCode = 1017;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public LeadAddress() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Information about the address for the lead.
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
        ///     Type of address for the lead address.
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
        ///     City name in the address for the lead.
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
        ///     Shows the complete address.
        /// </summary>
        [AttributeLogicalName("composite")]
        public string Composite
        {
            get { return GetAttributeValue<string>("composite"); }
        }

        /// <summary>
        ///     Country/region name in the address for the lead.
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
        ///     County name in the address for the lead.
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
        ///     Unique identifier of the user who created the lead address.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the lead address was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the leadaddress.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Exchange rate for the currency associated with the leadaddress with respect to the base currency.
        /// </summary>
        [AttributeLogicalName("exchangerate")]
        public decimal? ExchangeRate
        {
            get { return GetAttributeValue<decimal?>("exchangerate"); }
        }

        /// <summary>
        ///     Fax number for the address for the lead.
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
        ///     Latitude for the address for the lead.
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
        ///     Unique identifier of the lead address.
        /// </summary>
        [AttributeLogicalName("leadaddressid")]
        public Guid? LeadAddressId
        {
            get { return GetAttributeValue<Guid?>("leadaddressid"); }
            set
            {
                OnPropertyChanging("LeadAddressId");
                SetAttributeValue("leadaddressid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("LeadAddressId");
            }
        }

        [AttributeLogicalName("leadaddressid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { LeadAddressId = value; }
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
        ///     Longitude for the address for the lead.
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
        ///     Unique identifier of the user who last modified the lead address.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the lead address was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the leadaddress.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name used to identify the lead address.
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
        ///     Unique identifier of the parent object with which the lead address is associated.
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
        ///     ZIP Code or postal code in the address for the lead.
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
        ///     Post office box number in the address for the lead.
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
        ///     Method of shipment for the lead.
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
        ///     State or province in the address for the lead.
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
        ///     First telephone number for the lead address.
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
        ///     Second telephone number for the lead address.
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
        ///     Third telephone number for the lead address.
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
        ///     Unique identifier of the currency associated with the leadaddress.
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
        ///     United Parcel Service (UPS) zone for the address of the lead.
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
        ///     UTC offset for the lead address. This is the difference between local time and standard Coordinated Universal Time.
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
        ///     Version number of the lead address.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N userentityinstancedata_leadaddress
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_leadaddress")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_leadaddress
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_leadaddress", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_leadaddress");
                SetRelatedEntities("userentityinstancedata_leadaddress", null, value);
                OnPropertyChanged("userentityinstancedata_leadaddress");
            }
        }

        /// <summary>
        ///     N:1 lead_addresses
        /// </summary>
        [AttributeLogicalName("parentid")]
        [RelationshipSchemaName("lead_addresses")]
        public Lead lead_addresses
        {
            get { return GetRelatedEntity<Lead>("lead_addresses", null); }
            set
            {
                OnPropertyChanging("lead_addresses");
                SetRelatedEntity("lead_addresses", null, value);
                OnPropertyChanged("lead_addresses");
            }
        }

        /// <summary>
        ///     N:1 lk_leadaddress_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_leadaddress_createdonbehalfby")]
        public SystemUser lk_leadaddress_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_leadaddress_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_leadaddress_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_leadaddress_modifiedonbehalfby")]
        public SystemUser lk_leadaddress_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_leadaddress_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_leadaddressbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_leadaddressbase_createdby")]
        public SystemUser lk_leadaddressbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_leadaddressbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_leadaddressbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_leadaddressbase_modifiedby")]
        public SystemUser lk_leadaddressbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_leadaddressbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 TransactionCurrency_LeadAddress
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("TransactionCurrency_LeadAddress")]
        public TransactionCurrency TransactionCurrency_LeadAddress
        {
            get { return GetRelatedEntity<TransactionCurrency>("TransactionCurrency_LeadAddress", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_LeadAddress");
                SetRelatedEntity("TransactionCurrency_LeadAddress", null, value);
                OnPropertyChanged("TransactionCurrency_LeadAddress");
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