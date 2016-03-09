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
    ///     Type of discount specified as either a percentage or an amount.
    /// </summary>
    [DataContract]
    [EntityLogicalName("discounttype")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class DiscountType : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "discounttype";

        public const int EntityTypeCode = 1080;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public DiscountType() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the user who created the discount list.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the discount list was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the discounttype.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Description of the discount list.
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
        ///     Unique identifier of the discount list.
        /// </summary>
        [AttributeLogicalName("discounttypeid")]
        public Guid? DiscountTypeId
        {
            get { return GetAttributeValue<Guid?>("discounttypeid"); }
            set
            {
                OnPropertyChanging("DiscountTypeId");
                SetAttributeValue("discounttypeid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("DiscountTypeId");
            }
        }

        [AttributeLogicalName("discounttypeid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { DiscountTypeId = value; }
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
        ///     Information about whether the discount list amounts are specified as monetary amounts or percentages.
        /// </summary>
        [AttributeLogicalName("isamounttype")]
        public bool? IsAmountType
        {
            get { return GetAttributeValue<bool?>("isamounttype"); }
            set
            {
                OnPropertyChanging("IsAmountType");
                SetAttributeValue("isamounttype", value);
                OnPropertyChanged("IsAmountType");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the discount list.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the discount list was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the discounttype.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the discount list.
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
        ///     Unique identifier of the organization associated with the discount list.
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
        ///     Status of the discount list.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public DiscountTypeState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((DiscountTypeState) (Enum.ToObject(typeof (DiscountTypeState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the discount list.
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
        ///     Unique identifier of the currency associated with the discount type.
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
        ///     Version number of the discount type.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N discount_type_discounts
        /// </summary>
        [RelationshipSchemaName("discount_type_discounts")]
        public IEnumerable<Discount> discount_type_discounts
        {
            get { return GetRelatedEntities<Discount>("discount_type_discounts", null); }
            set
            {
                OnPropertyChanging("discount_type_discounts");
                SetRelatedEntities("discount_type_discounts", null, value);
                OnPropertyChanged("discount_type_discounts");
            }
        }

        /// <summary>
        ///     1:N discount_type_product_price_levels
        /// </summary>
        [RelationshipSchemaName("discount_type_product_price_levels")]
        public IEnumerable<ProductPriceLevel> discount_type_product_price_levels
        {
            get { return GetRelatedEntities<ProductPriceLevel>("discount_type_product_price_levels", null); }
            set
            {
                OnPropertyChanging("discount_type_product_price_levels");
                SetRelatedEntities("discount_type_product_price_levels", null, value);
                OnPropertyChanged("discount_type_product_price_levels");
            }
        }

        /// <summary>
        ///     1:N DiscountType_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("DiscountType_AsyncOperations")]
        public IEnumerable<AsyncOperation> DiscountType_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("DiscountType_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("DiscountType_AsyncOperations");
                SetRelatedEntities("DiscountType_AsyncOperations", null, value);
                OnPropertyChanged("DiscountType_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N DiscountType_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("DiscountType_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> DiscountType_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("DiscountType_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("DiscountType_BulkDeleteFailures");
                SetRelatedEntities("DiscountType_BulkDeleteFailures", null, value);
                OnPropertyChanged("DiscountType_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N DiscountType_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("DiscountType_ProcessSessions")]
        public IEnumerable<ProcessSession> DiscountType_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("DiscountType_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("DiscountType_ProcessSessions");
                SetRelatedEntities("DiscountType_ProcessSessions", null, value);
                OnPropertyChanged("DiscountType_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_discounttype
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_discounttype")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_discounttype
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_discounttype", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_discounttype");
                SetRelatedEntities("userentityinstancedata_discounttype", null, value);
                OnPropertyChanged("userentityinstancedata_discounttype");
            }
        }

        /// <summary>
        ///     N:1 lk_discounttype_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_discounttype_createdonbehalfby")]
        public SystemUser lk_discounttype_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_discounttype_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_discounttype_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_discounttype_modifiedonbehalfby")]
        public SystemUser lk_discounttype_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_discounttype_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_discounttypebase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_discounttypebase_createdby")]
        public SystemUser lk_discounttypebase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_discounttypebase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_discounttypebase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_discounttypebase_modifiedby")]
        public SystemUser lk_discounttypebase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_discounttypebase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 organization_discount_types
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_discount_types")]
        public Organization organization_discount_types
        {
            get { return GetRelatedEntity<Organization>("organization_discount_types", null); }
        }

        /// <summary>
        ///     N:1 transactioncurrency_discounttype
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("transactioncurrency_discounttype")]
        public TransactionCurrency transactioncurrency_discounttype
        {
            get { return GetRelatedEntity<TransactionCurrency>("transactioncurrency_discounttype", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_discounttype");
                SetRelatedEntity("transactioncurrency_discounttype", null, value);
                OnPropertyChanged("transactioncurrency_discounttype");
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