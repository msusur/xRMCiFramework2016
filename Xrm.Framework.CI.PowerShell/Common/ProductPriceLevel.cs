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
    ///     Information about how to price a product in the specified price level, including pricing method, rounding option,
    ///     and discount type based on a specified product unit.
    /// </summary>
    [DataContract]
    [EntityLogicalName("productpricelevel")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ProductPriceLevel : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "productpricelevel";

        public const int EntityTypeCode = 1026;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ProductPriceLevel() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Monetary amount for the price list.
        /// </summary>
        [AttributeLogicalName("amount")]
        public Money Amount
        {
            get { return GetAttributeValue<Money>("amount"); }
            set
            {
                OnPropertyChanging("Amount");
                SetAttributeValue("amount", value);
                OnPropertyChanged("Amount");
            }
        }

        /// <summary>
        ///     Shows the Amount field converted to the system's default base currency, if specified as a fixed amount. The
        ///     calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("amount_base")]
        public Money Amount_Base
        {
            get { return GetAttributeValue<Money>("amount_base"); }
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
        ///     Shows who created the record on behalf of another user.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the discount list associated with the price list.
        /// </summary>
        [AttributeLogicalName("discounttypeid")]
        public EntityReference DiscountTypeId
        {
            get { return GetAttributeValue<EntityReference>("discounttypeid"); }
            set
            {
                OnPropertyChanging("DiscountTypeId");
                SetAttributeValue("discounttypeid", value);
                OnPropertyChanged("DiscountTypeId");
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
        ///     Shows who last updated the record on behalf of another user.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the organization associated with the price list.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public Guid? OrganizationId
        {
            get { return GetAttributeValue<Guid?>("organizationid"); }
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
        ///     Percentage for the price list.
        /// </summary>
        [AttributeLogicalName("percentage")]
        public decimal? Percentage
        {
            get { return GetAttributeValue<decimal?>("percentage"); }
            set
            {
                OnPropertyChanging("Percentage");
                SetAttributeValue("percentage", value);
                OnPropertyChanged("Percentage");
            }
        }

        /// <summary>
        ///     Unique identifier of the price level associated with this price list.
        /// </summary>
        [AttributeLogicalName("pricelevelid")]
        public EntityReference PriceLevelId
        {
            get { return GetAttributeValue<EntityReference>("pricelevelid"); }
            set
            {
                OnPropertyChanging("PriceLevelId");
                SetAttributeValue("pricelevelid", value);
                OnPropertyChanged("PriceLevelId");
            }
        }

        /// <summary>
        ///     Pricing method applied to the price list.
        /// </summary>
        [AttributeLogicalName("pricingmethodcode")]
        public OptionSetValue PricingMethodCode
        {
            get { return GetAttributeValue<OptionSetValue>("pricingmethodcode"); }
            set
            {
                OnPropertyChanging("PricingMethodCode");
                SetAttributeValue("pricingmethodcode", value);
                OnPropertyChanged("PricingMethodCode");
            }
        }

        /// <summary>
        ///     Unique identifier of the Process.
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
        ///     Product associated with the price list.
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
        ///     Unique identifier of the price list.
        /// </summary>
        [AttributeLogicalName("productpricelevelid")]
        public Guid? ProductPriceLevelId
        {
            get { return GetAttributeValue<Guid?>("productpricelevelid"); }
            set
            {
                OnPropertyChanging("ProductPriceLevelId");
                SetAttributeValue("productpricelevelid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ProductPriceLevelId");
            }
        }

        [AttributeLogicalName("productpricelevelid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ProductPriceLevelId = value; }
        }

        /// <summary>
        ///     Quantity of the product that must be sold for a given price level.
        /// </summary>
        [AttributeLogicalName("quantitysellingcode")]
        public OptionSetValue QuantitySellingCode
        {
            get { return GetAttributeValue<OptionSetValue>("quantitysellingcode"); }
            set
            {
                OnPropertyChanging("QuantitySellingCode");
                SetAttributeValue("quantitysellingcode", value);
                OnPropertyChanged("QuantitySellingCode");
            }
        }

        /// <summary>
        ///     Rounding option amount for the price list.
        /// </summary>
        [AttributeLogicalName("roundingoptionamount")]
        public Money RoundingOptionAmount
        {
            get { return GetAttributeValue<Money>("roundingoptionamount"); }
            set
            {
                OnPropertyChanging("RoundingOptionAmount");
                SetAttributeValue("roundingoptionamount", value);
                OnPropertyChanged("RoundingOptionAmount");
            }
        }

        /// <summary>
        ///     Shows the Rounding Amount field converted to the system's default base currency for reporting purposes. The
        ///     calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("roundingoptionamount_base")]
        public Money RoundingOptionAmount_Base
        {
            get { return GetAttributeValue<Money>("roundingoptionamount_base"); }
        }

        /// <summary>
        ///     Option for rounding the price list.
        /// </summary>
        [AttributeLogicalName("roundingoptioncode")]
        public OptionSetValue RoundingOptionCode
        {
            get { return GetAttributeValue<OptionSetValue>("roundingoptioncode"); }
            set
            {
                OnPropertyChanging("RoundingOptionCode");
                SetAttributeValue("roundingoptioncode", value);
                OnPropertyChanged("RoundingOptionCode");
            }
        }

        /// <summary>
        ///     Policy for rounding the price list.
        /// </summary>
        [AttributeLogicalName("roundingpolicycode")]
        public OptionSetValue RoundingPolicyCode
        {
            get { return GetAttributeValue<OptionSetValue>("roundingpolicycode"); }
            set
            {
                OnPropertyChanging("RoundingPolicyCode");
                SetAttributeValue("roundingpolicycode", value);
                OnPropertyChanged("RoundingPolicyCode");
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
        ///     Unique identifier of the unit for the price list.
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
        ///     Unique identifier of the unit schedule for the price list.
        /// </summary>
        [AttributeLogicalName("uomscheduleid")]
        public EntityReference UoMScheduleId
        {
            get { return GetAttributeValue<EntityReference>("uomscheduleid"); }
            set
            {
                OnPropertyChanging("UoMScheduleId");
                SetAttributeValue("uomscheduleid", value);
                OnPropertyChanged("UoMScheduleId");
            }
        }

        /// <summary>
        ///     Version number of the price list.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N ProductPriceLevel_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("ProductPriceLevel_AsyncOperations")]
        public IEnumerable<AsyncOperation> ProductPriceLevel_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("ProductPriceLevel_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("ProductPriceLevel_AsyncOperations");
                SetRelatedEntities("ProductPriceLevel_AsyncOperations", null, value);
                OnPropertyChanged("ProductPriceLevel_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N ProductPriceLevel_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("ProductPriceLevel_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> ProductPriceLevel_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("ProductPriceLevel_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("ProductPriceLevel_BulkDeleteFailures");
                SetRelatedEntities("ProductPriceLevel_BulkDeleteFailures", null, value);
                OnPropertyChanged("ProductPriceLevel_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N ProductPriceLevel_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("ProductPriceLevel_ProcessSessions")]
        public IEnumerable<ProcessSession> ProductPriceLevel_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("ProductPriceLevel_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("ProductPriceLevel_ProcessSessions");
                SetRelatedEntities("ProductPriceLevel_ProcessSessions", null, value);
                OnPropertyChanged("ProductPriceLevel_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_productpricelevel
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_productpricelevel")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_productpricelevel
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_productpricelevel", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_productpricelevel");
                SetRelatedEntities("userentityinstancedata_productpricelevel", null, value);
                OnPropertyChanged("userentityinstancedata_productpricelevel");
            }
        }

        /// <summary>
        ///     N:1 discount_type_product_price_levels
        /// </summary>
        [AttributeLogicalName("discounttypeid")]
        [RelationshipSchemaName("discount_type_product_price_levels")]
        public DiscountType discount_type_product_price_levels
        {
            get { return GetRelatedEntity<DiscountType>("discount_type_product_price_levels", null); }
            set
            {
                OnPropertyChanging("discount_type_product_price_levels");
                SetRelatedEntity("discount_type_product_price_levels", null, value);
                OnPropertyChanged("discount_type_product_price_levels");
            }
        }

        /// <summary>
        ///     N:1 lk_productpricelevel_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_productpricelevel_createdonbehalfby")]
        public SystemUser lk_productpricelevel_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_productpricelevel_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_productpricelevel_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_productpricelevel_modifiedonbehalfby")]
        public SystemUser lk_productpricelevel_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_productpricelevel_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_productpricelevelbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_productpricelevelbase_createdby")]
        public SystemUser lk_productpricelevelbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_productpricelevelbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_productpricelevelbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_productpricelevelbase_modifiedby")]
        public SystemUser lk_productpricelevelbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_productpricelevelbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 price_level_product_price_levels
        /// </summary>
        [AttributeLogicalName("pricelevelid")]
        [RelationshipSchemaName("price_level_product_price_levels")]
        public PriceLevel price_level_product_price_levels
        {
            get { return GetRelatedEntity<PriceLevel>("price_level_product_price_levels", null); }
            set
            {
                OnPropertyChanging("price_level_product_price_levels");
                SetRelatedEntity("price_level_product_price_levels", null, value);
                OnPropertyChanged("price_level_product_price_levels");
            }
        }

        /// <summary>
        ///     N:1 processstage_productpricelevels
        /// </summary>
        [AttributeLogicalName("stageid")]
        [RelationshipSchemaName("processstage_productpricelevels")]
        public ProcessStage processstage_productpricelevels
        {
            get { return GetRelatedEntity<ProcessStage>("processstage_productpricelevels", null); }
            set
            {
                OnPropertyChanging("processstage_productpricelevels");
                SetRelatedEntity("processstage_productpricelevels", null, value);
                OnPropertyChanged("processstage_productpricelevels");
            }
        }

        /// <summary>
        ///     N:1 product_price_levels
        /// </summary>
        [AttributeLogicalName("productid")]
        [RelationshipSchemaName("product_price_levels")]
        public Product product_price_levels
        {
            get { return GetRelatedEntity<Product>("product_price_levels", null); }
            set
            {
                OnPropertyChanging("product_price_levels");
                SetRelatedEntity("product_price_levels", null, value);
                OnPropertyChanged("product_price_levels");
            }
        }

        /// <summary>
        ///     N:1 transactioncurrency_productpricelevel
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("transactioncurrency_productpricelevel")]
        public TransactionCurrency transactioncurrency_productpricelevel
        {
            get { return GetRelatedEntity<TransactionCurrency>("transactioncurrency_productpricelevel", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_productpricelevel");
                SetRelatedEntity("transactioncurrency_productpricelevel", null, value);
                OnPropertyChanged("transactioncurrency_productpricelevel");
            }
        }

        /// <summary>
        ///     N:1 unit_of_measure_schedule_product_price_level
        /// </summary>
        [AttributeLogicalName("uomscheduleid")]
        [RelationshipSchemaName("unit_of_measure_schedule_product_price_level")]
        public UoMSchedule unit_of_measure_schedule_product_price_level
        {
            get { return GetRelatedEntity<UoMSchedule>("unit_of_measure_schedule_product_price_level", null); }
            set
            {
                OnPropertyChanging("unit_of_measure_schedule_product_price_level");
                SetRelatedEntity("unit_of_measure_schedule_product_price_level", null, value);
                OnPropertyChanged("unit_of_measure_schedule_product_price_level");
            }
        }

        /// <summary>
        ///     N:1 unit_of_measurement_product_price_levels
        /// </summary>
        [AttributeLogicalName("uomid")]
        [RelationshipSchemaName("unit_of_measurement_product_price_levels")]
        public UoM unit_of_measurement_product_price_levels
        {
            get { return GetRelatedEntity<UoM>("unit_of_measurement_product_price_levels", null); }
            set
            {
                OnPropertyChanging("unit_of_measurement_product_price_levels");
                SetRelatedEntity("unit_of_measurement_product_price_levels", null, value);
                OnPropertyChanged("unit_of_measurement_product_price_levels");
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