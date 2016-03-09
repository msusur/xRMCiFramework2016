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
    ///     Address and shipping information. Used to store additional addresses for an account or contact.
    /// </summary>
    [DataContract]
    [EntityLogicalName("customeraddress")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class CustomerAddress : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "customeraddress";

        public const int EntityTypeCode = 1071;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public CustomerAddress() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Shows the number of the address, to indicate whether the address is the primary, secondary, or other address for
        ///     the customer.
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
        ///     Select the address type, such as primary or billing.
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
        ///     Type the city for the customer's address to help identify the location.
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
        ///     Type the country or region for the customer's address.
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
        ///     Type the county for the customer's address.
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
        ///     Unique identifier of the customer address.
        /// </summary>
        [AttributeLogicalName("customeraddressid")]
        public Guid? CustomerAddressId
        {
            get { return GetAttributeValue<Guid?>("customeraddressid"); }
            set
            {
                OnPropertyChanging("CustomerAddressId");
                SetAttributeValue("customeraddressid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("CustomerAddressId");
            }
        }

        [AttributeLogicalName("customeraddressid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { CustomerAddressId = value; }
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
        ///     Type the fax number associated with the customer's address.
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
        ///     Select the freight terms to make sure shipping charges are processed correctly.
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
        ///     Type the latitude value for the customer's address, for use in mapping and other applications.
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
        ///     Type the first line of the customer's address to help identify the location.
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
        ///     Type the second line of the customer's address.
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
        ///     Type the third line of the customer's address.
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
        ///     Type the longitude value for the customer's address, for use in mapping and other applications.
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
        ///     Type a descriptive name for the customer's address, such as Corporate Headquarters.
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
        ///     Shows the type code of the customer record to indicate whether the address belongs to a customer account or
        ///     contact.
        /// </summary>
        [AttributeLogicalName("objecttypecode")]
        public string ObjectTypeCode
        {
            get { return GetAttributeValue<string>("objecttypecode"); }
            set
            {
                OnPropertyChanging("ObjectTypeCode");
                SetAttributeValue("objecttypecode", value);
                OnPropertyChanged("ObjectTypeCode");
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
        }

        /// <summary>
        ///     Shows the business unit that the record owner belongs to.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the customer address.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Choose the customer's address.
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
        ///     Type the ZIP Code or postal code for the address.
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
        ///     Type the post office box number of the customer's address.
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
        ///     Type the name of the primary contact person for the customer's address.
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
        ///     Type the state or province of the customer's address.
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
        ///     Type the primary phone number for the customer's address.
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
        ///     Type a second phone number for the customer's address.
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
        ///     Type a third phone number for the customer's address.
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
        ///     Type the UPS zone of the customer's address to make sure shipping charges are calculated correctly and deliveries
        ///     are made promptly, if shipped by UPS.
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
        ///     Select the time zone for the address.
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
        ///     Version number of the customer address.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N customer_address_contract_line_items
        /// </summary>
        [RelationshipSchemaName("customer_address_contract_line_items")]
        public IEnumerable<ContractDetail> customer_address_contract_line_items
        {
            get { return GetRelatedEntities<ContractDetail>("customer_address_contract_line_items", null); }
            set
            {
                OnPropertyChanging("customer_address_contract_line_items");
                SetRelatedEntities("customer_address_contract_line_items", null, value);
                OnPropertyChanged("customer_address_contract_line_items");
            }
        }

        /// <summary>
        ///     1:N customer_address_contracts_as_billing_address
        /// </summary>
        [RelationshipSchemaName("customer_address_contracts_as_billing_address")]
        public IEnumerable<Contract> customer_address_contracts_as_billing_address
        {
            get { return GetRelatedEntities<Contract>("customer_address_contracts_as_billing_address", null); }
            set
            {
                OnPropertyChanging("customer_address_contracts_as_billing_address");
                SetRelatedEntities("customer_address_contracts_as_billing_address", null, value);
                OnPropertyChanged("customer_address_contracts_as_billing_address");
            }
        }

        /// <summary>
        ///     1:N customer_address_contracts_as_service_address
        /// </summary>
        [RelationshipSchemaName("customer_address_contracts_as_service_address")]
        public IEnumerable<Contract> customer_address_contracts_as_service_address
        {
            get { return GetRelatedEntities<Contract>("customer_address_contracts_as_service_address", null); }
            set
            {
                OnPropertyChanging("customer_address_contracts_as_service_address");
                SetRelatedEntities("customer_address_contracts_as_service_address", null, value);
                OnPropertyChanged("customer_address_contracts_as_service_address");
            }
        }

        /// <summary>
        ///     1:N CustomerAddress_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("CustomerAddress_AsyncOperations")]
        public IEnumerable<AsyncOperation> CustomerAddress_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("CustomerAddress_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("CustomerAddress_AsyncOperations");
                SetRelatedEntities("CustomerAddress_AsyncOperations", null, value);
                OnPropertyChanged("CustomerAddress_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N CustomerAddress_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("CustomerAddress_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> CustomerAddress_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("CustomerAddress_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("CustomerAddress_BulkDeleteFailures");
                SetRelatedEntities("CustomerAddress_BulkDeleteFailures", null, value);
                OnPropertyChanged("CustomerAddress_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N customeraddress_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("customeraddress_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> customeraddress_principalobjectattributeaccess
        {
            get
            {
                return
                    GetRelatedEntities<PrincipalObjectAttributeAccess>(
                        "customeraddress_principalobjectattributeaccess", null);
            }
            set
            {
                OnPropertyChanging("customeraddress_principalobjectattributeaccess");
                SetRelatedEntities("customeraddress_principalobjectattributeaccess", null, value);
                OnPropertyChanged("customeraddress_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N CustomerAddress_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("CustomerAddress_ProcessSessions")]
        public IEnumerable<ProcessSession> CustomerAddress_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("CustomerAddress_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("CustomerAddress_ProcessSessions");
                SetRelatedEntities("CustomerAddress_ProcessSessions", null, value);
                OnPropertyChanged("CustomerAddress_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_customeraddress
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_customeraddress")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_customeraddress
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_customeraddress", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_customeraddress");
                SetRelatedEntities("userentityinstancedata_customeraddress", null, value);
                OnPropertyChanged("userentityinstancedata_customeraddress");
            }
        }

        /// <summary>
        ///     N:1 Account_CustomerAddress
        /// </summary>
        [AttributeLogicalName("parentid")]
        [RelationshipSchemaName("Account_CustomerAddress")]
        public Account Account_CustomerAddress
        {
            get { return GetRelatedEntity<Account>("Account_CustomerAddress", null); }
            set
            {
                OnPropertyChanging("Account_CustomerAddress");
                SetRelatedEntity("Account_CustomerAddress", null, value);
                OnPropertyChanged("Account_CustomerAddress");
            }
        }

        /// <summary>
        ///     N:1 Contact_CustomerAddress
        /// </summary>
        [AttributeLogicalName("parentid")]
        [RelationshipSchemaName("Contact_CustomerAddress")]
        public Contact Contact_CustomerAddress
        {
            get { return GetRelatedEntity<Contact>("Contact_CustomerAddress", null); }
            set
            {
                OnPropertyChanging("Contact_CustomerAddress");
                SetRelatedEntity("Contact_CustomerAddress", null, value);
                OnPropertyChanged("Contact_CustomerAddress");
            }
        }

        /// <summary>
        ///     N:1 lk_customeraddress_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_customeraddress_createdonbehalfby")]
        public SystemUser lk_customeraddress_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_customeraddress_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_customeraddress_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_customeraddress_modifiedonbehalfby")]
        public SystemUser lk_customeraddress_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_customeraddress_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_customeraddressbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_customeraddressbase_createdby")]
        public SystemUser lk_customeraddressbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_customeraddressbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_customeraddressbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_customeraddressbase_modifiedby")]
        public SystemUser lk_customeraddressbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_customeraddressbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 TransactionCurrency_CustomerAddress
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("TransactionCurrency_CustomerAddress")]
        public TransactionCurrency TransactionCurrency_CustomerAddress
        {
            get { return GetRelatedEntity<TransactionCurrency>("TransactionCurrency_CustomerAddress", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_CustomerAddress");
                SetRelatedEntity("TransactionCurrency_CustomerAddress", null, value);
                OnPropertyChanged("TransactionCurrency_CustomerAddress");
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