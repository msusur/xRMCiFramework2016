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
    ///     Association between an opportunity and a product.
    /// </summary>
    [DataContract]
    [EntityLogicalName("opportunityproduct")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class OpportunityProduct : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "opportunityproduct";

        public const int EntityTypeCode = 1083;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public OpportunityProduct() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Shows the total price of the opportunity product, based on the price per unit, volume discount, and quantity.
        /// </summary>
        [AttributeLogicalName("baseamount")]
        public Money BaseAmount
        {
            get { return GetAttributeValue<Money>("baseamount"); }
        }

        /// <summary>
        ///     Shows the Amount field converted to the system's default base currency. The calculation uses the exchange rate
        ///     specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("baseamount_base")]
        public Money BaseAmount_Base
        {
            get { return GetAttributeValue<Money>("baseamount_base"); }
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
        ///     Type additional information to describe the opportunity product, such as manufacturing details.
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
        ///     The default image for the entity.
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
        ///     Shows the total amount due for the opportunity product, calculated on the Amount value minus the Manual Discount
        ///     amount.
        /// </summary>
        [AttributeLogicalName("extendedamount")]
        public Money ExtendedAmount
        {
            get { return GetAttributeValue<Money>("extendedamount"); }
        }

        /// <summary>
        ///     Shows the Extended Amount field converted to the system's default base currency. The calculation uses the exchange
        ///     rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("extendedamount_base")]
        public Money ExtendedAmount_Base
        {
            get { return GetAttributeValue<Money>("extendedamount_base"); }
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
        ///     Select whether the pricing on the opportunity product reflects an override of the product catalog pricing.
        /// </summary>
        [AttributeLogicalName("ispriceoverridden")]
        public bool? IsPriceOverridden
        {
            get { return GetAttributeValue<bool?>("ispriceoverridden"); }
            set
            {
                OnPropertyChanging("IsPriceOverridden");
                SetAttributeValue("ispriceoverridden", value);
                OnPropertyChanged("IsPriceOverridden");
            }
        }

        /// <summary>
        ///     For system use only.
        /// </summary>
        [AttributeLogicalName("isproductoverridden")]
        public bool? IsProductOverridden
        {
            get { return GetAttributeValue<bool?>("isproductoverridden"); }
            set
            {
                OnPropertyChanging("IsProductOverridden");
                SetAttributeValue("isproductoverridden", value);
                OnPropertyChanged("IsProductOverridden");
            }
        }

        /// <summary>
        ///     Type the line item number for the opportunity product to easily identify the product in the opportunity documents
        ///     and make sure it's listed in the correct order.
        /// </summary>
        [AttributeLogicalName("lineitemnumber")]
        public int? LineItemNumber
        {
            get { return GetAttributeValue<int?>("lineitemnumber"); }
            set
            {
                OnPropertyChanging("LineItemNumber");
                SetAttributeValue("lineitemnumber", value);
                OnPropertyChanged("LineItemNumber");
            }
        }

        /// <summary>
        ///     Type the manual discount amount for the opportunity product to deduct any negotiated or other savings from the
        ///     product total.
        /// </summary>
        [AttributeLogicalName("manualdiscountamount")]
        public Money ManualDiscountAmount
        {
            get { return GetAttributeValue<Money>("manualdiscountamount"); }
            set
            {
                OnPropertyChanging("ManualDiscountAmount");
                SetAttributeValue("manualdiscountamount", value);
                OnPropertyChanged("ManualDiscountAmount");
            }
        }

        /// <summary>
        ///     Shows the Manual Discount field converted to the system's default base currency for reporting purposes. The
        ///     calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("manualdiscountamount_base")]
        public Money ManualDiscountAmount_Base
        {
            get { return GetAttributeValue<Money>("manualdiscountamount_base"); }
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
        ///     Unique identifier of the delegate user who last modified the opportunityproduct.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the opportunity with which the opportunity product is associated.
        /// </summary>
        [AttributeLogicalName("opportunityid")]
        public EntityReference OpportunityId
        {
            get { return GetAttributeValue<EntityReference>("opportunityid"); }
            set
            {
                OnPropertyChanging("OpportunityId");
                SetAttributeValue("opportunityid", value);
                OnPropertyChanged("OpportunityId");
            }
        }

        /// <summary>
        ///     Unique identifier of the opportunity product.
        /// </summary>
        [AttributeLogicalName("opportunityproductid")]
        public Guid? OpportunityProductId
        {
            get { return GetAttributeValue<Guid?>("opportunityproductid"); }
            set
            {
                OnPropertyChanging("OpportunityProductId");
                SetAttributeValue("opportunityproductid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("OpportunityProductId");
            }
        }

        [AttributeLogicalName("opportunityproductid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { OpportunityProductId = value; }
        }

        /// <summary>
        ///     Select the status of the opportunity product.
        /// </summary>
        [AttributeLogicalName("opportunitystatecode")]
        public OptionSetValue OpportunityStateCode
        {
            get { return GetAttributeValue<OptionSetValue>("opportunitystatecode"); }
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
        ///     Unique identifier of the user or team who owns the opportunity product.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId
        {
            get { return GetAttributeValue<EntityReference>("ownerid"); }
        }

        /// <summary>
        ///     Unique identifier of the business unit that owns the opportunity product.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public Guid? OwningBusinessUnit
        {
            get { return GetAttributeValue<Guid?>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the opportunity product.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public Guid? OwningUser
        {
            get { return GetAttributeValue<Guid?>("owninguser"); }
        }

        /// <summary>
        ///     Shows the price per unit of the opportunity product, based on the price list specified on the parent opportunity.
        /// </summary>
        [AttributeLogicalName("priceperunit")]
        public Money PricePerUnit
        {
            get { return GetAttributeValue<Money>("priceperunit"); }
            set
            {
                OnPropertyChanging("PricePerUnit");
                SetAttributeValue("priceperunit", value);
                OnPropertyChanged("PricePerUnit");
            }
        }

        /// <summary>
        ///     Shows the Price Per Unit field converted to the system's default base currency for reporting purposes. The
        ///     calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("priceperunit_base")]
        public Money PricePerUnit_Base
        {
            get { return GetAttributeValue<Money>("priceperunit_base"); }
        }

        /// <summary>
        ///     Select the pricing error for the opportunity product.
        /// </summary>
        [AttributeLogicalName("pricingerrorcode")]
        public OptionSetValue PricingErrorCode
        {
            get { return GetAttributeValue<OptionSetValue>("pricingerrorcode"); }
            set
            {
                OnPropertyChanging("PricingErrorCode");
                SetAttributeValue("pricingerrorcode", value);
                OnPropertyChanged("PricingErrorCode");
            }
        }

        /// <summary>
        ///     Type a detailed product description or additional notes about the opportunity product, such as talking points or
        ///     product updates, that will assist the sales team when they discuss the product with the customer.
        /// </summary>
        [AttributeLogicalName("productdescription")]
        public string ProductDescription
        {
            get { return GetAttributeValue<string>("productdescription"); }
            set
            {
                OnPropertyChanging("ProductDescription");
                SetAttributeValue("productdescription", value);
                OnPropertyChanged("ProductDescription");
            }
        }

        /// <summary>
        ///     Choose the product to include on the opportunity to link the product's pricing and other information to the
        ///     opportunity.
        /// </summary>
        [AttributeLogicalName("productid")]
        public EntityReference ProductId
        {
            get { return GetAttributeValue<EntityReference>("productid"); }
            set
            {
                OnPropertyChanging("ProductId");
                SetAttributeValue("productid", value);
                OnPropertyChanged("ProductId");
            }
        }

        /// <summary>
        ///     Type the amount or quantity of the product the customer would like to purchase.
        /// </summary>
        [AttributeLogicalName("quantity")]
        public decimal? Quantity
        {
            get { return GetAttributeValue<decimal?>("quantity"); }
            set
            {
                OnPropertyChanging("Quantity");
                SetAttributeValue("quantity", value);
                OnPropertyChanged("Quantity");
            }
        }

        /// <summary>
        ///     Shows the ID of the data that maintains the sequence.
        /// </summary>
        [AttributeLogicalName("sequencenumber")]
        public int? SequenceNumber
        {
            get { return GetAttributeValue<int?>("sequencenumber"); }
            set
            {
                OnPropertyChanging("SequenceNumber");
                SetAttributeValue("sequencenumber", value);
                OnPropertyChanged("SequenceNumber");
            }
        }

        /// <summary>
        ///     Type the tax amount to be applied on the opportunity product.
        /// </summary>
        [AttributeLogicalName("tax")]
        public Money Tax
        {
            get { return GetAttributeValue<Money>("tax"); }
            set
            {
                OnPropertyChanging("Tax");
                SetAttributeValue("tax", value);
                OnPropertyChanged("Tax");
            }
        }

        /// <summary>
        ///     Shows the Tax field converted to the system's default base currency for reporting purposes. The calculation uses
        ///     the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("tax_base")]
        public Money Tax_Base
        {
            get { return GetAttributeValue<Money>("tax_base"); }
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
        }

        /// <summary>
        ///     Choose the unit of measurement for the base unit quantity for this purchase, such as each or dozen.
        /// </summary>
        [AttributeLogicalName("uomid")]
        public EntityReference UoMId
        {
            get { return GetAttributeValue<EntityReference>("uomid"); }
            set
            {
                OnPropertyChanging("UoMId");
                SetAttributeValue("uomid", value);
                OnPropertyChanged("UoMId");
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
        ///     Version number of the opportunity product.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     Shows the discount amount per unit if a specified volume is purchased. Configure volume discounts in the Product
        ///     Catalog in the Settings area.
        /// </summary>
        [AttributeLogicalName("volumediscountamount")]
        public Money VolumeDiscountAmount
        {
            get { return GetAttributeValue<Money>("volumediscountamount"); }
        }

        /// <summary>
        ///     Shows the Volume Discount field converted to the system's default base currency for reporting purposes. The
        ///     calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("volumediscountamount_base")]
        public Money VolumeDiscountAmount_Base
        {
            get { return GetAttributeValue<Money>("volumediscountamount_base"); }
        }

        /// <summary>
        ///     1:N OpportunityProduct_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("OpportunityProduct_AsyncOperations")]
        public IEnumerable<AsyncOperation> OpportunityProduct_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("OpportunityProduct_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("OpportunityProduct_AsyncOperations");
                SetRelatedEntities("OpportunityProduct_AsyncOperations", null, value);
                OnPropertyChanged("OpportunityProduct_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N OpportunityProduct_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("OpportunityProduct_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> OpportunityProduct_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("OpportunityProduct_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("OpportunityProduct_BulkDeleteFailures");
                SetRelatedEntities("OpportunityProduct_BulkDeleteFailures", null, value);
                OnPropertyChanged("OpportunityProduct_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N opportunityproduct_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("opportunityproduct_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> opportunityproduct_principalobjectattributeaccess
        {
            get
            {
                return
                    GetRelatedEntities<PrincipalObjectAttributeAccess>(
                        "opportunityproduct_principalobjectattributeaccess", null);
            }
            set
            {
                OnPropertyChanging("opportunityproduct_principalobjectattributeaccess");
                SetRelatedEntities("opportunityproduct_principalobjectattributeaccess", null, value);
                OnPropertyChanged("opportunityproduct_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N OpportunityProduct_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("OpportunityProduct_ProcessSessions")]
        public IEnumerable<ProcessSession> OpportunityProduct_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("OpportunityProduct_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("OpportunityProduct_ProcessSessions");
                SetRelatedEntities("OpportunityProduct_ProcessSessions", null, value);
                OnPropertyChanged("OpportunityProduct_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_opportunityproduct
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_opportunityproduct")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_opportunityproduct
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_opportunityproduct", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_opportunityproduct");
                SetRelatedEntities("userentityinstancedata_opportunityproduct", null, value);
                OnPropertyChanged("userentityinstancedata_opportunityproduct");
            }
        }

        /// <summary>
        ///     N:1 lk_opportunityproduct_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_opportunityproduct_createdonbehalfby")]
        public SystemUser lk_opportunityproduct_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_opportunityproduct_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_opportunityproduct_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_opportunityproduct_modifiedonbehalfby")]
        public SystemUser lk_opportunityproduct_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_opportunityproduct_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_opportunityproductbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_opportunityproductbase_createdby")]
        public SystemUser lk_opportunityproductbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_opportunityproductbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_opportunityproductbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_opportunityproductbase_modifiedby")]
        public SystemUser lk_opportunityproductbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_opportunityproductbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 opportunity_products
        /// </summary>
        [AttributeLogicalName("productid")]
        [RelationshipSchemaName("opportunity_products")]
        public Product opportunity_products
        {
            get { return GetRelatedEntity<Product>("opportunity_products", null); }
            set
            {
                OnPropertyChanging("opportunity_products");
                SetRelatedEntity("opportunity_products", null, value);
                OnPropertyChanged("opportunity_products");
            }
        }

        /// <summary>
        ///     N:1 product_opportunities
        /// </summary>
        [AttributeLogicalName("opportunityid")]
        [RelationshipSchemaName("product_opportunities")]
        public Opportunity product_opportunities
        {
            get { return GetRelatedEntity<Opportunity>("product_opportunities", null); }
            set
            {
                OnPropertyChanging("product_opportunities");
                SetRelatedEntity("product_opportunities", null, value);
                OnPropertyChanged("product_opportunities");
            }
        }

        /// <summary>
        ///     N:1 transactioncurrency_opportunityproduct
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("transactioncurrency_opportunityproduct")]
        public TransactionCurrency transactioncurrency_opportunityproduct
        {
            get { return GetRelatedEntity<TransactionCurrency>("transactioncurrency_opportunityproduct", null); }
        }

        /// <summary>
        ///     N:1 unit_of_measurement_opportunity_products
        /// </summary>
        [AttributeLogicalName("uomid")]
        [RelationshipSchemaName("unit_of_measurement_opportunity_products")]
        public UoM unit_of_measurement_opportunity_products
        {
            get { return GetRelatedEntity<UoM>("unit_of_measurement_opportunity_products", null); }
            set
            {
                OnPropertyChanging("unit_of_measurement_opportunity_products");
                SetRelatedEntity("unit_of_measurement_opportunity_products", null, value);
                OnPropertyChanged("unit_of_measurement_opportunity_products");
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