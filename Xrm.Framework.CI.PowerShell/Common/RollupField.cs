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
    ///     Field to be rolled up to calculate the actual and in-progress values against the goal.
    /// </summary>
    [DataContract]
    [EntityLogicalName("rollupfield")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class RollupField : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "rollupfield";

        public const int EntityTypeCode = 9604;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public RollupField() :
            base(EntityLogicalName)
        {
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
        ///     Select a date field for the selected record type, such as Actual Closed Date for the Opportunity record type. A
        ///     record participates in the goal rollup, if the selected date falls between the start date and the end date for the
        ///     goal.
        /// </summary>
        [AttributeLogicalName("dateattribute")]
        public string DateAttribute
        {
            get { return GetAttributeValue<string>("dateattribute"); }
            set
            {
                OnPropertyChanging("DateAttribute");
                SetAttributeValue("dateattribute", value);
                OnPropertyChanged("DateAttribute");
            }
        }

        /// <summary>
        ///     Select the record type that contains the date field that will be considered while rolling up data to the goal.
        /// </summary>
        [AttributeLogicalName("entityfordateattribute")]
        public string EntityForDateAttribute
        {
            get { return GetAttributeValue<string>("entityfordateattribute"); }
            set
            {
                OnPropertyChanging("EntityForDateAttribute");
                SetAttributeValue("entityfordateattribute", value);
                OnPropertyChanged("EntityForDateAttribute");
            }
        }

        /// <summary>
        ///     Select a rollup field where the metric rollup data will be displayed in the goal. The options are an integer or
        ///     money, depending on the Metric Type you chose for the goal metric.
        /// </summary>
        [AttributeLogicalName("goalattribute")]
        public string GoalAttribute
        {
            get { return GetAttributeValue<string>("goalattribute"); }
            set
            {
                OnPropertyChanging("GoalAttribute");
                SetAttributeValue("goalattribute", value);
                OnPropertyChanged("GoalAttribute");
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
        ///     Tells whether the state or status belongs to the parent entity.
        /// </summary>
        [AttributeLogicalName("isstateparententityattribute")]
        public bool? IsStateParentEntityAttribute
        {
            get { return GetAttributeValue<bool?>("isstateparententityattribute"); }
            set
            {
                OnPropertyChanging("IsStateParentEntityAttribute");
                SetAttributeValue("isstateparententityattribute", value);
                OnPropertyChanged("IsStateParentEntityAttribute");
            }
        }

        /// <summary>
        ///     Unique identifier of the goal metric associated with the rollup field.
        /// </summary>
        [AttributeLogicalName("metricid")]
        public EntityReference MetricId
        {
            get { return GetAttributeValue<EntityReference>("metricid"); }
            set
            {
                OnPropertyChanging("MetricId");
                SetAttributeValue("metricid", value);
                OnPropertyChanged("MetricId");
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
        ///     Choose the ID of the organization that the record is associated with.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     Unique identifier of the rollup field.
        /// </summary>
        [AttributeLogicalName("rollupfieldid")]
        public Guid? RollupFieldId
        {
            get { return GetAttributeValue<Guid?>("rollupfieldid"); }
            set
            {
                OnPropertyChanging("RollupFieldId");
                SetAttributeValue("rollupfieldid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("RollupFieldId");
            }
        }

        [AttributeLogicalName("rollupfieldid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { RollupFieldId = value; }
        }

        /// <summary>
        ///     Type the name of the field that the data for the goal rolls up from.
        /// </summary>
        [AttributeLogicalName("sourceattribute")]
        public string SourceAttribute
        {
            get { return GetAttributeValue<string>("sourceattribute"); }
            set
            {
                OnPropertyChanging("SourceAttribute");
                SetAttributeValue("sourceattribute", value);
                OnPropertyChanged("SourceAttribute");
            }
        }

        /// <summary>
        ///     Type the name of the record type (entity) that the data for the goal must roll up from.
        /// </summary>
        [AttributeLogicalName("sourceentity")]
        public string SourceEntity
        {
            get { return GetAttributeValue<string>("sourceentity"); }
            set
            {
                OnPropertyChanging("SourceEntity");
                SetAttributeValue("sourceentity", value);
                OnPropertyChanged("SourceEntity");
            }
        }

        /// <summary>
        ///     Select the state of the records you want to use as the source of the rollup data for the metric.
        /// </summary>
        [AttributeLogicalName("sourcestate")]
        public int? SourceState
        {
            get { return GetAttributeValue<int?>("sourcestate"); }
            set
            {
                OnPropertyChanging("SourceState");
                SetAttributeValue("sourcestate", value);
                OnPropertyChanged("SourceState");
            }
        }

        /// <summary>
        ///     Select the status of the records you want to use as the source of the rollup data for the metric.
        /// </summary>
        [AttributeLogicalName("sourcestatus")]
        public int? SourceStatus
        {
            get { return GetAttributeValue<int?>("sourcestatus"); }
            set
            {
                OnPropertyChanging("SourceStatus");
                SetAttributeValue("sourcestatus", value);
                OnPropertyChanged("SourceStatus");
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
        ///     Version number of the rollup field.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N rollupfield_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("rollupfield_AsyncOperations")]
        public IEnumerable<AsyncOperation> rollupfield_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("rollupfield_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("rollupfield_AsyncOperations");
                SetRelatedEntities("rollupfield_AsyncOperations", null, value);
                OnPropertyChanged("rollupfield_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N rollupfield_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("rollupfield_ProcessSessions")]
        public IEnumerable<ProcessSession> rollupfield_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("rollupfield_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("rollupfield_ProcessSessions");
                SetRelatedEntities("rollupfield_ProcessSessions", null, value);
                OnPropertyChanged("rollupfield_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_rollupfield
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_rollupfield")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_rollupfield
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_rollupfield", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_rollupfield");
                SetRelatedEntities("userentityinstancedata_rollupfield", null, value);
                OnPropertyChanged("userentityinstancedata_rollupfield");
            }
        }

        /// <summary>
        ///     N:1 lk_rollupfield_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_rollupfield_createdby")]
        public SystemUser lk_rollupfield_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_rollupfield_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_rollupfield_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_rollupfield_createdonbehalfby")]
        public SystemUser lk_rollupfield_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_rollupfield_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_rollupfield_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_rollupfield_modifiedby")]
        public SystemUser lk_rollupfield_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_rollupfield_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_rollupfield_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_rollupfield_modifiedonbehalfby")]
        public SystemUser lk_rollupfield_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_rollupfield_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 metric_rollupfield
        /// </summary>
        [AttributeLogicalName("metricid")]
        [RelationshipSchemaName("metric_rollupfield")]
        public Metric metric_rollupfield
        {
            get { return GetRelatedEntity<Metric>("metric_rollupfield", null); }
            set
            {
                OnPropertyChanging("metric_rollupfield");
                SetRelatedEntity("metric_rollupfield", null, value);
                OnPropertyChanged("metric_rollupfield");
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