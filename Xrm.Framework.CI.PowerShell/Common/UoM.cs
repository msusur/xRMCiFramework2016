using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Xrm.Framework.CI.PowerShell.Common;

namespace Xrm.Framework.CI.Common.Entities
{
    /// <summary>
    ///     Unit of measure.
    /// </summary>
    [DataContract]
    [EntityLogicalName("uom")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class UoM : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "uom";

        public const int EntityTypeCode = 1055;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public UoM() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Choose the base or primary unit on which the unit is based.
        /// </summary>
        [AttributeLogicalName("baseuom")]
        public EntityReference BaseUoM
        {
            get { return GetAttributeValue<EntityReference>("baseuom"); }
            set
            {
                OnPropertyChanging("BaseUoM");
                SetAttributeValue("baseuom", value);
                OnPropertyChanged("BaseUoM");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the unit.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the unit was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the uom.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
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
        ///     Tells whether the unit is the base unit for the associated unit group.
        /// </summary>
        [AttributeLogicalName("isschedulebaseuom")]
        public bool? IsScheduleBaseUoM
        {
            get { return GetAttributeValue<bool?>("isschedulebaseuom"); }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the unit.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the unit was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the uom.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Type a descriptive title or name for the unit of measure.
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
        ///     Unique identifier of the organization associated with the unit of measure.
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
        ///     Unit quantity for the product.
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
        ///     Unique identifier of the unit.
        /// </summary>
        [AttributeLogicalName("uomid")]
        public Guid? UoMId
        {
            get { return GetAttributeValue<Guid?>("uomid"); }
            set
            {
                OnPropertyChanging("UoMId");
                SetAttributeValue("uomid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("UoMId");
            }
        }

        [AttributeLogicalName("uomid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { UoMId = value; }
        }

        /// <summary>
        ///     Choose the ID of the unit group that the unit is associated with.
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
        ///     Version number of the unit.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N unit_of_measurement_base_unit
        /// </summary>
        [RelationshipSchemaName("unit_of_measurement_base_unit", EntityRole.Referenced)]
        public IEnumerable<UoM> Referencedunit_of_measurement_base_unit
        {
            get { return GetRelatedEntities<UoM>("unit_of_measurement_base_unit", EntityRole.Referenced); }
            set
            {
                OnPropertyChanging("Referencedunit_of_measurement_base_unit");
                SetRelatedEntities("unit_of_measurement_base_unit", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedunit_of_measurement_base_unit");
            }
        }

        /// <summary>
        ///     1:N unit_of_measurement_contract_line_items
        /// </summary>
        [RelationshipSchemaName("unit_of_measurement_contract_line_items")]
        public IEnumerable<ContractDetail> unit_of_measurement_contract_line_items
        {
            get { return GetRelatedEntities<ContractDetail>("unit_of_measurement_contract_line_items", null); }
            set
            {
                OnPropertyChanging("unit_of_measurement_contract_line_items");
                SetRelatedEntities("unit_of_measurement_contract_line_items", null, value);
                OnPropertyChanged("unit_of_measurement_contract_line_items");
            }
        }

        /// <summary>
        ///     1:N unit_of_measurement_invoice_details
        /// </summary>
        [RelationshipSchemaName("unit_of_measurement_invoice_details")]
        public IEnumerable<InvoiceDetail> unit_of_measurement_invoice_details
        {
            get { return GetRelatedEntities<InvoiceDetail>("unit_of_measurement_invoice_details", null); }
            set
            {
                OnPropertyChanging("unit_of_measurement_invoice_details");
                SetRelatedEntities("unit_of_measurement_invoice_details", null, value);
                OnPropertyChanged("unit_of_measurement_invoice_details");
            }
        }

        /// <summary>
        ///     1:N unit_of_measurement_opportunity_products
        /// </summary>
        [RelationshipSchemaName("unit_of_measurement_opportunity_products")]
        public IEnumerable<OpportunityProduct> unit_of_measurement_opportunity_products
        {
            get { return GetRelatedEntities<OpportunityProduct>("unit_of_measurement_opportunity_products", null); }
            set
            {
                OnPropertyChanging("unit_of_measurement_opportunity_products");
                SetRelatedEntities("unit_of_measurement_opportunity_products", null, value);
                OnPropertyChanged("unit_of_measurement_opportunity_products");
            }
        }

        /// <summary>
        ///     1:N unit_of_measurement_order_details
        /// </summary>
        [RelationshipSchemaName("unit_of_measurement_order_details")]
        public IEnumerable<SalesOrderDetail> unit_of_measurement_order_details
        {
            get { return GetRelatedEntities<SalesOrderDetail>("unit_of_measurement_order_details", null); }
            set
            {
                OnPropertyChanging("unit_of_measurement_order_details");
                SetRelatedEntities("unit_of_measurement_order_details", null, value);
                OnPropertyChanged("unit_of_measurement_order_details");
            }
        }

        /// <summary>
        ///     1:N unit_of_measurement_product_price_levels
        /// </summary>
        [RelationshipSchemaName("unit_of_measurement_product_price_levels")]
        public IEnumerable<ProductPriceLevel> unit_of_measurement_product_price_levels
        {
            get { return GetRelatedEntities<ProductPriceLevel>("unit_of_measurement_product_price_levels", null); }
            set
            {
                OnPropertyChanging("unit_of_measurement_product_price_levels");
                SetRelatedEntities("unit_of_measurement_product_price_levels", null, value);
                OnPropertyChanged("unit_of_measurement_product_price_levels");
            }
        }

        /// <summary>
        ///     1:N unit_of_measurement_products
        /// </summary>
        [RelationshipSchemaName("unit_of_measurement_products")]
        public IEnumerable<Product> unit_of_measurement_products
        {
            get { return GetRelatedEntities<Product>("unit_of_measurement_products", null); }
            set
            {
                OnPropertyChanging("unit_of_measurement_products");
                SetRelatedEntities("unit_of_measurement_products", null, value);
                OnPropertyChanged("unit_of_measurement_products");
            }
        }

        /// <summary>
        ///     1:N unit_of_measurement_quote_details
        /// </summary>
        [RelationshipSchemaName("unit_of_measurement_quote_details")]
        public IEnumerable<QuoteDetail> unit_of_measurement_quote_details
        {
            get { return GetRelatedEntities<QuoteDetail>("unit_of_measurement_quote_details", null); }
            set
            {
                OnPropertyChanging("unit_of_measurement_quote_details");
                SetRelatedEntities("unit_of_measurement_quote_details", null, value);
                OnPropertyChanged("unit_of_measurement_quote_details");
            }
        }

        /// <summary>
        ///     1:N UoM_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("UoM_AsyncOperations")]
        public IEnumerable<AsyncOperation> UoM_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("UoM_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("UoM_AsyncOperations");
                SetRelatedEntities("UoM_AsyncOperations", null, value);
                OnPropertyChanged("UoM_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N UoM_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("UoM_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> UoM_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("UoM_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("UoM_BulkDeleteFailures");
                SetRelatedEntities("UoM_BulkDeleteFailures", null, value);
                OnPropertyChanged("UoM_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_uom
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_uom")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_uom
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_uom", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_uom");
                SetRelatedEntities("userentityinstancedata_uom", null, value);
                OnPropertyChanged("userentityinstancedata_uom");
            }
        }

        /// <summary>
        ///     N:1 lk_uom_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_uom_createdonbehalfby")]
        public SystemUser lk_uom_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_uom_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_uom_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_uom_modifiedonbehalfby")]
        public SystemUser lk_uom_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_uom_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_uombase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_uombase_createdby")]
        public SystemUser lk_uombase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_uombase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_uombase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_uombase_modifiedby")]
        public SystemUser lk_uombase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_uombase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 unit_of_measure_schedule_conversions
        /// </summary>
        [AttributeLogicalName("uomscheduleid")]
        [RelationshipSchemaName("unit_of_measure_schedule_conversions")]
        public UoMSchedule unit_of_measure_schedule_conversions
        {
            get { return GetRelatedEntity<UoMSchedule>("unit_of_measure_schedule_conversions", null); }
            set
            {
                OnPropertyChanging("unit_of_measure_schedule_conversions");
                SetRelatedEntity("unit_of_measure_schedule_conversions", null, value);
                OnPropertyChanged("unit_of_measure_schedule_conversions");
            }
        }

        /// <summary>
        ///     N:1 unit_of_measurement_base_unit
        /// </summary>
        [AttributeLogicalName("baseuom")]
        [RelationshipSchemaName("unit_of_measurement_base_unit", EntityRole.Referencing)]
        public UoM Referencingunit_of_measurement_base_unit
        {
            get { return GetRelatedEntity<UoM>("unit_of_measurement_base_unit", EntityRole.Referencing); }
            set
            {
                OnPropertyChanging("Referencingunit_of_measurement_base_unit");
                SetRelatedEntity("unit_of_measurement_base_unit", EntityRole.Referencing, value);
                OnPropertyChanged("Referencingunit_of_measurement_base_unit");
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