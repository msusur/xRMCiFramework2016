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
    ///     Type of measurement for a goal, such as money amount or count.
    /// </summary>
    [DataContract]
    [EntityLogicalName("metric")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Metric : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "metric";

        public const int EntityTypeCode = 9603;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Metric() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Data type of the amount.
        /// </summary>
        [AttributeLogicalName("amountdatatype")]
        public OptionSetValue AmountDataType
        {
            get { return GetAttributeValue<OptionSetValue>("amountdatatype"); }
            set
            {
                OnPropertyChanging("AmountDataType");
                SetAttributeValue("amountdatatype", value);
                OnPropertyChanged("AmountDataType");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the record.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the record was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the record.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Description of the goal metric.
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
        ///     Sequence number of the import that created this record.
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
        ///     Information that indicates whether the metric type is Count or Amount.
        /// </summary>
        [AttributeLogicalName("isamount")]
        public bool? IsAmount
        {
            get { return GetAttributeValue<bool?>("isamount"); }
            set
            {
                OnPropertyChanging("IsAmount");
                SetAttributeValue("isamount", value);
                OnPropertyChanged("IsAmount");
            }
        }

        /// <summary>
        ///     Indicates whether the goal metric tracks stretch targets.
        /// </summary>
        [AttributeLogicalName("isstretchtracked")]
        public bool? IsStretchTracked
        {
            get { return GetAttributeValue<bool?>("isstretchtracked"); }
            set
            {
                OnPropertyChanging("IsStretchTracked");
                SetAttributeValue("isstretchtracked", value);
                OnPropertyChanged("IsStretchTracked");
            }
        }

        /// <summary>
        ///     Unique identifier of the goal metric.
        /// </summary>
        [AttributeLogicalName("metricid")]
        public Guid? MetricId
        {
            get { return GetAttributeValue<Guid?>("metricid"); }
            set
            {
                OnPropertyChanging("MetricId");
                SetAttributeValue("metricid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("MetricId");
            }
        }

        [AttributeLogicalName("metricid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { MetricId = value; }
        }

        /// <summary>
        ///     Unique identifier of the user who modified the record.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the record was modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who modified the record.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the goal metric.
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
        ///     Unique identifier of the organization.
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
        ///     Status of the goal metric.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public MetricState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((MetricState) (Enum.ToObject(typeof (MetricState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the goal metric.
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
        ///     Version number of the goal metric.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N metric_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("metric_AsyncOperations")]
        public IEnumerable<AsyncOperation> metric_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("metric_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("metric_AsyncOperations");
                SetRelatedEntities("metric_AsyncOperations", null, value);
                OnPropertyChanged("metric_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N metric_goal
        /// </summary>
        [RelationshipSchemaName("metric_goal")]
        public IEnumerable<Goal> metric_goal
        {
            get { return GetRelatedEntities<Goal>("metric_goal", null); }
            set
            {
                OnPropertyChanging("metric_goal");
                SetRelatedEntities("metric_goal", null, value);
                OnPropertyChanged("metric_goal");
            }
        }

        /// <summary>
        ///     1:N metric_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("metric_ProcessSessions")]
        public IEnumerable<ProcessSession> metric_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("metric_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("metric_ProcessSessions");
                SetRelatedEntities("metric_ProcessSessions", null, value);
                OnPropertyChanged("metric_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N metric_rollupfield
        /// </summary>
        [RelationshipSchemaName("metric_rollupfield")]
        public IEnumerable<RollupField> metric_rollupfield
        {
            get { return GetRelatedEntities<RollupField>("metric_rollupfield", null); }
            set
            {
                OnPropertyChanging("metric_rollupfield");
                SetRelatedEntities("metric_rollupfield", null, value);
                OnPropertyChanged("metric_rollupfield");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_metric
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_metric")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_metric
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_metric", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_metric");
                SetRelatedEntities("userentityinstancedata_metric", null, value);
                OnPropertyChanged("userentityinstancedata_metric");
            }
        }

        /// <summary>
        ///     N:1 lk_metric_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_metric_createdby")]
        public SystemUser lk_metric_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_metric_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_metric_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_metric_createdonbehalfby")]
        public SystemUser lk_metric_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_metric_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_metric_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_metric_modifiedby")]
        public SystemUser lk_metric_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_metric_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_metric_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_metric_modifiedonbehalfby")]
        public SystemUser lk_metric_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_metric_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 organization_metric
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_metric")]
        public Organization organization_metric
        {
            get { return GetRelatedEntity<Organization>("organization_metric", null); }
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