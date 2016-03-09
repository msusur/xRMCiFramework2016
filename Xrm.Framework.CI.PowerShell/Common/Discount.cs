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
    ///     Price reduction made from the list price of a product or service based on the quantity purchased.
    /// </summary>
    [DataContract]
    [EntityLogicalName("discount")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Discount : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "discount";

        public const int EntityTypeCode = 1013;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Discount() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Amount of the discount, specified either as a percentage or as a monetary amount.
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
        ///     Unique identifier of the user who created the discount.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the discount was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the discount.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the discount.
        /// </summary>
        [AttributeLogicalName("discountid")]
        public Guid? DiscountId
        {
            get { return GetAttributeValue<Guid?>("discountid"); }
            set
            {
                OnPropertyChanging("DiscountId");
                SetAttributeValue("discountid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("DiscountId");
            }
        }

        [AttributeLogicalName("discountid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { DiscountId = value; }
        }

        /// <summary>
        ///     Unique identifier of the discount list associated with the discount.
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
        ///     Upper boundary for the quantity range to which a particular discount can be applied.
        /// </summary>
        [AttributeLogicalName("highquantity")]
        public decimal? HighQuantity
        {
            get { return GetAttributeValue<decimal?>("highquantity"); }
            set
            {
                OnPropertyChanging("HighQuantity");
                SetAttributeValue("highquantity", value);
                OnPropertyChanged("HighQuantity");
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
        ///     Specifies whether the discount is specified as a monetary amount or a percentage.
        /// </summary>
        [AttributeLogicalName("isamounttype")]
        public bool? IsAmountType
        {
            get { return GetAttributeValue<bool?>("isamounttype"); }
        }

        /// <summary>
        ///     Lower boundary for the quantity range to which a particular discount is applied.
        /// </summary>
        [AttributeLogicalName("lowquantity")]
        public decimal? LowQuantity
        {
            get { return GetAttributeValue<decimal?>("lowquantity"); }
            set
            {
                OnPropertyChanging("LowQuantity");
                SetAttributeValue("lowquantity", value);
                OnPropertyChanged("LowQuantity");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the discount.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the discount was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the discount.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the organization associated with the discount.
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
        ///     Percentage discount value.
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
        ///     Select the discount's status.
        /// </summary>
        [AttributeLogicalName("statuscode")]
        [Obsolete]
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
        ///     Choose the local currency for the record to make sure budgets are reported in the correct currency.
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        public EntityReference TransactionCurrencyId
        {
            get { return GetAttributeValue<EntityReference>("transactioncurrencyid"); }
        }

        /// <summary>
        ///     Version number of the discount.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N Discount_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Discount_AsyncOperations")]
        public IEnumerable<AsyncOperation> Discount_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Discount_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Discount_AsyncOperations");
                SetRelatedEntities("Discount_AsyncOperations", null, value);
                OnPropertyChanged("Discount_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N Discount_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("Discount_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> Discount_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("Discount_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("Discount_BulkDeleteFailures");
                SetRelatedEntities("Discount_BulkDeleteFailures", null, value);
                OnPropertyChanged("Discount_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N Discount_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("Discount_ProcessSessions")]
        public IEnumerable<ProcessSession> Discount_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("Discount_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Discount_ProcessSessions");
                SetRelatedEntities("Discount_ProcessSessions", null, value);
                OnPropertyChanged("Discount_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_discount
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_discount")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_discount
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_discount", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_discount");
                SetRelatedEntities("userentityinstancedata_discount", null, value);
                OnPropertyChanged("userentityinstancedata_discount");
            }
        }

        /// <summary>
        ///     N:1 discount_type_discounts
        /// </summary>
        [AttributeLogicalName("discounttypeid")]
        [RelationshipSchemaName("discount_type_discounts")]
        public DiscountType discount_type_discounts
        {
            get { return GetRelatedEntity<DiscountType>("discount_type_discounts", null); }
            set
            {
                OnPropertyChanging("discount_type_discounts");
                SetRelatedEntity("discount_type_discounts", null, value);
                OnPropertyChanged("discount_type_discounts");
            }
        }

        /// <summary>
        ///     N:1 lk_discount_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_discount_createdonbehalfby")]
        public SystemUser lk_discount_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_discount_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_discount_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_discount_modifiedonbehalfby")]
        public SystemUser lk_discount_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_discount_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_discountbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_discountbase_createdby")]
        public SystemUser lk_discountbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_discountbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_discountbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_discountbase_modifiedby")]
        public SystemUser lk_discountbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_discountbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 transactioncurrency_discount
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("transactioncurrency_discount")]
        public TransactionCurrency transactioncurrency_discount
        {
            get { return GetRelatedEntity<TransactionCurrency>("transactioncurrency_discount", null); }
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