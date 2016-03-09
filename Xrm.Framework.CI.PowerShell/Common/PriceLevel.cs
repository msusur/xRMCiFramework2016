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
    ///     Entity that defines pricing levels.
    /// </summary>
    [DataContract]
    [EntityLogicalName("pricelevel")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class PriceLevel : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "pricelevel";

        public const int EntityTypeCode = 1022;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public PriceLevel() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Date on which the price list becomes effective.
        /// </summary>
        [AttributeLogicalName("begindate")]
        public DateTime? BeginDate
        {
            get { return GetAttributeValue<DateTime?>("begindate"); }
            set
            {
                OnPropertyChanging("BeginDate");
                SetAttributeValue("begindate", value);
                OnPropertyChanged("BeginDate");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the price list.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the price list was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the pricelevel.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Description of the price list.
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
        ///     Date that is the last day the price list is valid.
        /// </summary>
        [AttributeLogicalName("enddate")]
        public DateTime? EndDate
        {
            get { return GetAttributeValue<DateTime?>("enddate"); }
            set
            {
                OnPropertyChanging("EndDate");
                SetAttributeValue("enddate", value);
                OnPropertyChanged("EndDate");
            }
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
        ///     Freight terms for the price list.
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
        ///     Unique identifier of the user who last modified the price list.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the price list was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the pricelevel.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the price list.
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
        ///     Unique identifier of the organization associated with the price list.
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
        ///     Payment terms to use with the price list.
        /// </summary>
        [AttributeLogicalName("paymentmethodcode")]
        public OptionSetValue PaymentMethodCode
        {
            get { return GetAttributeValue<OptionSetValue>("paymentmethodcode"); }
            set
            {
                OnPropertyChanging("PaymentMethodCode");
                SetAttributeValue("paymentmethodcode", value);
                OnPropertyChanged("PaymentMethodCode");
            }
        }

        /// <summary>
        ///     Unique identifier of the price list.
        /// </summary>
        [AttributeLogicalName("pricelevelid")]
        public Guid? PriceLevelId
        {
            get { return GetAttributeValue<Guid?>("pricelevelid"); }
            set
            {
                OnPropertyChanging("PriceLevelId");
                SetAttributeValue("pricelevelid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("PriceLevelId");
            }
        }

        [AttributeLogicalName("pricelevelid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { PriceLevelId = value; }
        }

        /// <summary>
        ///     Method of shipment for products in the price list.
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
        ///     Status of the price list.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public PriceLevelState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((PriceLevelState) (Enum.ToObject(typeof (PriceLevelState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the price list.
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
        ///     Unique identifier of the currency associated with the price level.
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
        ///     Version number of the price level.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N price_level_accounts
        /// </summary>
        [RelationshipSchemaName("price_level_accounts")]
        public IEnumerable<Account> price_level_accounts
        {
            get { return GetRelatedEntities<Account>("price_level_accounts", null); }
            set
            {
                OnPropertyChanging("price_level_accounts");
                SetRelatedEntities("price_level_accounts", null, value);
                OnPropertyChanged("price_level_accounts");
            }
        }

        /// <summary>
        ///     1:N price_level_contacts
        /// </summary>
        [RelationshipSchemaName("price_level_contacts")]
        public IEnumerable<Contact> price_level_contacts
        {
            get { return GetRelatedEntities<Contact>("price_level_contacts", null); }
            set
            {
                OnPropertyChanging("price_level_contacts");
                SetRelatedEntities("price_level_contacts", null, value);
                OnPropertyChanged("price_level_contacts");
            }
        }

        /// <summary>
        ///     1:N price_level_invoices
        /// </summary>
        [RelationshipSchemaName("price_level_invoices")]
        public IEnumerable<Invoice> price_level_invoices
        {
            get { return GetRelatedEntities<Invoice>("price_level_invoices", null); }
            set
            {
                OnPropertyChanging("price_level_invoices");
                SetRelatedEntities("price_level_invoices", null, value);
                OnPropertyChanged("price_level_invoices");
            }
        }

        /// <summary>
        ///     1:N price_level_opportunties
        /// </summary>
        [RelationshipSchemaName("price_level_opportunties")]
        public IEnumerable<Opportunity> price_level_opportunties
        {
            get { return GetRelatedEntities<Opportunity>("price_level_opportunties", null); }
            set
            {
                OnPropertyChanging("price_level_opportunties");
                SetRelatedEntities("price_level_opportunties", null, value);
                OnPropertyChanged("price_level_opportunties");
            }
        }

        /// <summary>
        ///     1:N price_level_orders
        /// </summary>
        [RelationshipSchemaName("price_level_orders")]
        public IEnumerable<SalesOrder> price_level_orders
        {
            get { return GetRelatedEntities<SalesOrder>("price_level_orders", null); }
            set
            {
                OnPropertyChanging("price_level_orders");
                SetRelatedEntities("price_level_orders", null, value);
                OnPropertyChanged("price_level_orders");
            }
        }

        /// <summary>
        ///     1:N price_level_product_price_levels
        /// </summary>
        [RelationshipSchemaName("price_level_product_price_levels")]
        public IEnumerable<ProductPriceLevel> price_level_product_price_levels
        {
            get { return GetRelatedEntities<ProductPriceLevel>("price_level_product_price_levels", null); }
            set
            {
                OnPropertyChanging("price_level_product_price_levels");
                SetRelatedEntities("price_level_product_price_levels", null, value);
                OnPropertyChanged("price_level_product_price_levels");
            }
        }

        /// <summary>
        ///     1:N price_level_products
        /// </summary>
        [RelationshipSchemaName("price_level_products")]
        public IEnumerable<Product> price_level_products
        {
            get { return GetRelatedEntities<Product>("price_level_products", null); }
            set
            {
                OnPropertyChanging("price_level_products");
                SetRelatedEntities("price_level_products", null, value);
                OnPropertyChanged("price_level_products");
            }
        }

        /// <summary>
        ///     1:N price_level_quotes
        /// </summary>
        [RelationshipSchemaName("price_level_quotes")]
        public IEnumerable<Quote> price_level_quotes
        {
            get { return GetRelatedEntities<Quote>("price_level_quotes", null); }
            set
            {
                OnPropertyChanging("price_level_quotes");
                SetRelatedEntities("price_level_quotes", null, value);
                OnPropertyChanged("price_level_quotes");
            }
        }

        /// <summary>
        ///     1:N PriceLevel_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("PriceLevel_AsyncOperations")]
        public IEnumerable<AsyncOperation> PriceLevel_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("PriceLevel_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("PriceLevel_AsyncOperations");
                SetRelatedEntities("PriceLevel_AsyncOperations", null, value);
                OnPropertyChanged("PriceLevel_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N PriceLevel_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("PriceLevel_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> PriceLevel_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("PriceLevel_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("PriceLevel_BulkDeleteFailures");
                SetRelatedEntities("PriceLevel_BulkDeleteFailures", null, value);
                OnPropertyChanged("PriceLevel_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N pricelevel_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("pricelevel_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> pricelevel_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntities<PrincipalObjectAttributeAccess>("pricelevel_principalobjectattributeaccess",
                    null);
            }
            set
            {
                OnPropertyChanging("pricelevel_principalobjectattributeaccess");
                SetRelatedEntities("pricelevel_principalobjectattributeaccess", null, value);
                OnPropertyChanged("pricelevel_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N PriceLevel_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("PriceLevel_ProcessSessions")]
        public IEnumerable<ProcessSession> PriceLevel_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("PriceLevel_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("PriceLevel_ProcessSessions");
                SetRelatedEntities("PriceLevel_ProcessSessions", null, value);
                OnPropertyChanged("PriceLevel_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N PriceList_Campaigns
        /// </summary>
        [RelationshipSchemaName("PriceList_Campaigns")]
        public IEnumerable<Campaign> PriceList_Campaigns
        {
            get { return GetRelatedEntities<Campaign>("PriceList_Campaigns", null); }
            set
            {
                OnPropertyChanging("PriceList_Campaigns");
                SetRelatedEntities("PriceList_Campaigns", null, value);
                OnPropertyChanged("PriceList_Campaigns");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_pricelevel
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_pricelevel")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_pricelevel
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_pricelevel", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_pricelevel");
                SetRelatedEntities("userentityinstancedata_pricelevel", null, value);
                OnPropertyChanged("userentityinstancedata_pricelevel");
            }
        }

        /// <summary>
        ///     N:1 lk_pricelevel_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_pricelevel_createdonbehalfby")]
        public SystemUser lk_pricelevel_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_pricelevel_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_pricelevel_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_pricelevel_modifiedonbehalfby")]
        public SystemUser lk_pricelevel_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_pricelevel_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_pricelevelbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_pricelevelbase_createdby")]
        public SystemUser lk_pricelevelbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_pricelevelbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_pricelevelbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_pricelevelbase_modifiedby")]
        public SystemUser lk_pricelevelbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_pricelevelbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 organization_price_levels
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_price_levels")]
        public Organization organization_price_levels
        {
            get { return GetRelatedEntity<Organization>("organization_price_levels", null); }
        }

        /// <summary>
        ///     N:1 transactioncurrency_pricelevel
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("transactioncurrency_pricelevel")]
        public TransactionCurrency transactioncurrency_pricelevel
        {
            get { return GetRelatedEntity<TransactionCurrency>("transactioncurrency_pricelevel", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_pricelevel");
                SetRelatedEntity("transactioncurrency_pricelevel", null, value);
                OnPropertyChanged("transactioncurrency_pricelevel");
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