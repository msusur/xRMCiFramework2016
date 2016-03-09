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
    ///     Grouping of units.
    /// </summary>
    [DataContract]
    [EntityLogicalName("uomschedule")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class UoMSchedule : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "uomschedule";

        public const int EntityTypeCode = 1056;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public UoMSchedule() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Name of the base unit.
        /// </summary>
        [AttributeLogicalName("baseuomname")]
        public string BaseUoMName
        {
            get { return GetAttributeValue<string>("baseuomname"); }
            set
            {
                OnPropertyChanging("BaseUoMName");
                SetAttributeValue("baseuomname", value);
                OnPropertyChanged("BaseUoMName");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the unit group.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the unit group was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the uomschedule.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Description of the unit group.
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
        ///     Unique identifier of the user who last modified the unit group.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the unit group was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the uomschedule.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the unit group.
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
        ///     Unique identifier of the organization associated with the unit group.
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
        ///     Status of the Unit Group.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public UoMScheduleState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((UoMScheduleState) (Enum.ToObject(typeof (UoMScheduleState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the Unit Group.
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
        ///     Unique identifier for the unit group.
        /// </summary>
        [AttributeLogicalName("uomscheduleid")]
        public Guid? UoMScheduleId
        {
            get { return GetAttributeValue<Guid?>("uomscheduleid"); }
            set
            {
                OnPropertyChanging("UoMScheduleId");
                SetAttributeValue("uomscheduleid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("UoMScheduleId");
            }
        }

        [AttributeLogicalName("uomscheduleid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { UoMScheduleId = value; }
        }

        /// <summary>
        ///     Version number of the unit group.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N contract_detail_unit_of_measure_schedule
        /// </summary>
        [RelationshipSchemaName("contract_detail_unit_of_measure_schedule")]
        public IEnumerable<ContractDetail> contract_detail_unit_of_measure_schedule
        {
            get { return GetRelatedEntities<ContractDetail>("contract_detail_unit_of_measure_schedule", null); }
            set
            {
                OnPropertyChanging("contract_detail_unit_of_measure_schedule");
                SetRelatedEntities("contract_detail_unit_of_measure_schedule", null, value);
                OnPropertyChanged("contract_detail_unit_of_measure_schedule");
            }
        }

        /// <summary>
        ///     1:N unit_of_measure_schedule_conversions
        /// </summary>
        [RelationshipSchemaName("unit_of_measure_schedule_conversions")]
        public IEnumerable<UoM> unit_of_measure_schedule_conversions
        {
            get { return GetRelatedEntities<UoM>("unit_of_measure_schedule_conversions", null); }
            set
            {
                OnPropertyChanging("unit_of_measure_schedule_conversions");
                SetRelatedEntities("unit_of_measure_schedule_conversions", null, value);
                OnPropertyChanged("unit_of_measure_schedule_conversions");
            }
        }

        /// <summary>
        ///     1:N unit_of_measure_schedule_product_price_level
        /// </summary>
        [RelationshipSchemaName("unit_of_measure_schedule_product_price_level")]
        public IEnumerable<ProductPriceLevel> unit_of_measure_schedule_product_price_level
        {
            get { return GetRelatedEntities<ProductPriceLevel>("unit_of_measure_schedule_product_price_level", null); }
            set
            {
                OnPropertyChanging("unit_of_measure_schedule_product_price_level");
                SetRelatedEntities("unit_of_measure_schedule_product_price_level", null, value);
                OnPropertyChanged("unit_of_measure_schedule_product_price_level");
            }
        }

        /// <summary>
        ///     1:N unit_of_measurement_schedule_products
        /// </summary>
        [RelationshipSchemaName("unit_of_measurement_schedule_products")]
        public IEnumerable<Product> unit_of_measurement_schedule_products
        {
            get { return GetRelatedEntities<Product>("unit_of_measurement_schedule_products", null); }
            set
            {
                OnPropertyChanging("unit_of_measurement_schedule_products");
                SetRelatedEntities("unit_of_measurement_schedule_products", null, value);
                OnPropertyChanged("unit_of_measurement_schedule_products");
            }
        }

        /// <summary>
        ///     1:N UoMSchedule_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("UoMSchedule_AsyncOperations")]
        public IEnumerable<AsyncOperation> UoMSchedule_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("UoMSchedule_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("UoMSchedule_AsyncOperations");
                SetRelatedEntities("UoMSchedule_AsyncOperations", null, value);
                OnPropertyChanged("UoMSchedule_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N UoMSchedule_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("UoMSchedule_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> UoMSchedule_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("UoMSchedule_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("UoMSchedule_BulkDeleteFailures");
                SetRelatedEntities("UoMSchedule_BulkDeleteFailures", null, value);
                OnPropertyChanged("UoMSchedule_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_uomschedule
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_uomschedule")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_uomschedule
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_uomschedule", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_uomschedule");
                SetRelatedEntities("userentityinstancedata_uomschedule", null, value);
                OnPropertyChanged("userentityinstancedata_uomschedule");
            }
        }

        /// <summary>
        ///     N:1 lk_uomschedule_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_uomschedule_createdonbehalfby")]
        public SystemUser lk_uomschedule_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_uomschedule_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_uomschedule_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_uomschedule_modifiedonbehalfby")]
        public SystemUser lk_uomschedule_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_uomschedule_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_uomschedulebase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_uomschedulebase_createdby")]
        public SystemUser lk_uomschedulebase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_uomschedulebase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_uomschedulebase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_uomschedulebase_modifiedby")]
        public SystemUser lk_uomschedulebase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_uomschedulebase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 organization_uof_schedules
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_uof_schedules")]
        public Organization organization_uof_schedules
        {
            get { return GetRelatedEntity<Organization>("organization_uof_schedules", null); }
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