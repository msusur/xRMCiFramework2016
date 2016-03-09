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
    ///     Special type of activity that includes description of the resolution, billing status, and the duration of the case.
    /// </summary>
    [DataContract]
    [EntityLogicalName("incidentresolution")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class IncidentResolution : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "incidentresolution";

        public const int EntityTypeCode = 4206;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public IncidentResolution() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the case resolution activity.
        /// </summary>
        [AttributeLogicalName("activityid")]
        public Guid? ActivityId
        {
            get { return GetAttributeValue<Guid?>("activityid"); }
            set
            {
                OnPropertyChanging("ActivityId");
                SetAttributeValue("activityid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ActivityId");
            }
        }

        [AttributeLogicalName("activityid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ActivityId = value; }
        }

        /// <summary>
        ///     Type of activity.
        /// </summary>
        [AttributeLogicalName("activitytypecode")]
        public string ActivityTypeCode
        {
            get { return GetAttributeValue<string>("activitytypecode"); }
        }

        /// <summary>
        ///     Actual duration of the case resolution activity in minutes.
        /// </summary>
        [AttributeLogicalName("actualdurationminutes")]
        public int? ActualDurationMinutes
        {
            get { return GetAttributeValue<int?>("actualdurationminutes"); }
            set
            {
                OnPropertyChanging("ActualDurationMinutes");
                SetAttributeValue("actualdurationminutes", value);
                OnPropertyChanged("ActualDurationMinutes");
            }
        }

        /// <summary>
        ///     Actual end time of the case resolution activity.
        /// </summary>
        [AttributeLogicalName("actualend")]
        public DateTime? ActualEnd
        {
            get { return GetAttributeValue<DateTime?>("actualend"); }
            set
            {
                OnPropertyChanging("ActualEnd");
                SetAttributeValue("actualend", value);
                OnPropertyChanged("ActualEnd");
            }
        }

        /// <summary>
        ///     Actual start time of the case resolution activity.
        /// </summary>
        [AttributeLogicalName("actualstart")]
        public DateTime? ActualStart
        {
            get { return GetAttributeValue<DateTime?>("actualstart"); }
            set
            {
                OnPropertyChanging("ActualStart");
                SetAttributeValue("actualstart", value);
                OnPropertyChanged("ActualStart");
            }
        }

        /// <summary>
        ///     Category for the case resolution activity.
        /// </summary>
        [AttributeLogicalName("category")]
        public string Category
        {
            get { return GetAttributeValue<string>("category"); }
            set
            {
                OnPropertyChanging("Category");
                SetAttributeValue("category", value);
                OnPropertyChanged("Category");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the case resolution activity.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the case resolution activity was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the incidentresolution.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Type additional information that describes the case resolution.
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
        ///     Unique identifier of the case.
        /// </summary>
        [AttributeLogicalName("incidentid")]
        public EntityReference IncidentId
        {
            get { return GetAttributeValue<EntityReference>("incidentid"); }
            set
            {
                OnPropertyChanging("IncidentId");
                SetAttributeValue("incidentid", value);
                OnPropertyChanged("IncidentId");
            }
        }

        /// <summary>
        ///     Information about whether the case resolution activity was billed as part of resolving a case.
        /// </summary>
        [AttributeLogicalName("isbilled")]
        public bool? IsBilled
        {
            get { return GetAttributeValue<bool?>("isbilled"); }
            set
            {
                OnPropertyChanging("IsBilled");
                SetAttributeValue("isbilled", value);
                OnPropertyChanged("IsBilled");
            }
        }

        /// <summary>
        ///     Information regarding whether the activity is a regular activity type or event type.
        /// </summary>
        [AttributeLogicalName("isregularactivity")]
        public bool? IsRegularActivity
        {
            get { return GetAttributeValue<bool?>("isregularactivity"); }
        }

        /// <summary>
        ///     Information that specifies if the case resolution activity was created from a workflow rule.
        /// </summary>
        [AttributeLogicalName("isworkflowcreated")]
        public bool? IsWorkflowCreated
        {
            get { return GetAttributeValue<bool?>("isworkflowcreated"); }
            set
            {
                OnPropertyChanging("IsWorkflowCreated");
                SetAttributeValue("isworkflowcreated", value);
                OnPropertyChanged("IsWorkflowCreated");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the case resolution activity.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the case resolution activity was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the incidentresolution.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
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
        ///     Unique identifier of the user or team who owns the case resolution activity.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId
        {
            get { return GetAttributeValue<EntityReference>("ownerid"); }
            set
            {
                OnPropertyChanging("OwnerId");
                SetAttributeValue("ownerid", value);
                OnPropertyChanged("OwnerId");
            }
        }

        /// <summary>
        ///     Unique identifier of the business unit that owns the case resolution activity.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the case resolution.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the case resolution.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Scheduled duration of the case resolution activity, specified in minutes.
        /// </summary>
        [AttributeLogicalName("scheduleddurationminutes")]
        public int? ScheduledDurationMinutes
        {
            get { return GetAttributeValue<int?>("scheduleddurationminutes"); }
        }

        /// <summary>
        ///     Scheduled end time of the case resolution activity.
        /// </summary>
        [AttributeLogicalName("scheduledend")]
        public DateTime? ScheduledEnd
        {
            get { return GetAttributeValue<DateTime?>("scheduledend"); }
            set
            {
                OnPropertyChanging("ScheduledEnd");
                SetAttributeValue("scheduledend", value);
                OnPropertyChanged("ScheduledEnd");
            }
        }

        /// <summary>
        ///     Scheduled start time of the case resolution activity.
        /// </summary>
        [AttributeLogicalName("scheduledstart")]
        public DateTime? ScheduledStart
        {
            get { return GetAttributeValue<DateTime?>("scheduledstart"); }
            set
            {
                OnPropertyChanging("ScheduledStart");
                SetAttributeValue("scheduledstart", value);
                OnPropertyChanged("ScheduledStart");
            }
        }

        /// <summary>
        ///     Unique identifier of the service with which the case resolution activity is associated.
        /// </summary>
        [AttributeLogicalName("serviceid")]
        public EntityReference ServiceId
        {
            get { return GetAttributeValue<EntityReference>("serviceid"); }
            set
            {
                OnPropertyChanging("ServiceId");
                SetAttributeValue("serviceid", value);
                OnPropertyChanged("ServiceId");
            }
        }

        /// <summary>
        ///     Shows whether the case resolution is open, completed, or canceled. By default, all case resolutions are completed
        ///     and the status value can't be changed.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public IncidentResolutionState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return
                        ((IncidentResolutionState) (Enum.ToObject(typeof (IncidentResolutionState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the case resolution activity.
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
        ///     Subcategory of the case resolution activity.
        /// </summary>
        [AttributeLogicalName("subcategory")]
        public string Subcategory
        {
            get { return GetAttributeValue<string>("subcategory"); }
            set
            {
                OnPropertyChanging("Subcategory");
                SetAttributeValue("subcategory", value);
                OnPropertyChanged("Subcategory");
            }
        }

        /// <summary>
        ///     Subject associated with the case resolution activity.
        /// </summary>
        [AttributeLogicalName("subject")]
        public string Subject
        {
            get { return GetAttributeValue<string>("subject"); }
            set
            {
                OnPropertyChanging("Subject");
                SetAttributeValue("subject", value);
                OnPropertyChanged("Subject");
            }
        }

        /// <summary>
        ///     Time spent on the case resolution activity.
        /// </summary>
        [AttributeLogicalName("timespent")]
        public int? TimeSpent
        {
            get { return GetAttributeValue<int?>("timespent"); }
            set
            {
                OnPropertyChanging("TimeSpent");
                SetAttributeValue("timespent", value);
                OnPropertyChanged("TimeSpent");
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
        ///     Version number of the case.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N incidentresolution_activity_parties
        /// </summary>
        [RelationshipSchemaName("incidentresolution_activity_parties")]
        public IEnumerable<ActivityParty> incidentresolution_activity_parties
        {
            get { return GetRelatedEntities<ActivityParty>("incidentresolution_activity_parties", null); }
            set
            {
                OnPropertyChanging("incidentresolution_activity_parties");
                SetRelatedEntities("incidentresolution_activity_parties", null, value);
                OnPropertyChanged("incidentresolution_activity_parties");
            }
        }

        /// <summary>
        ///     1:N IncidentResolution_Annotation
        /// </summary>
        [RelationshipSchemaName("IncidentResolution_Annotation")]
        public IEnumerable<Annotation> IncidentResolution_Annotation
        {
            get { return GetRelatedEntities<Annotation>("IncidentResolution_Annotation", null); }
            set
            {
                OnPropertyChanging("IncidentResolution_Annotation");
                SetRelatedEntities("IncidentResolution_Annotation", null, value);
                OnPropertyChanged("IncidentResolution_Annotation");
            }
        }

        /// <summary>
        ///     1:N IncidentResolution_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("IncidentResolution_AsyncOperations")]
        public IEnumerable<AsyncOperation> IncidentResolution_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("IncidentResolution_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("IncidentResolution_AsyncOperations");
                SetRelatedEntities("IncidentResolution_AsyncOperations", null, value);
                OnPropertyChanged("IncidentResolution_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N IncidentResolution_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("IncidentResolution_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> IncidentResolution_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("IncidentResolution_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("IncidentResolution_BulkDeleteFailures");
                SetRelatedEntities("IncidentResolution_BulkDeleteFailures", null, value);
                OnPropertyChanged("IncidentResolution_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_incidentresolution
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_incidentresolution")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_incidentresolution
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_incidentresolution", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_incidentresolution");
                SetRelatedEntities("userentityinstancedata_incidentresolution", null, value);
                OnPropertyChanged("userentityinstancedata_incidentresolution");
            }
        }

        /// <summary>
        ///     N:1 activity_pointer_incident_resolution
        /// </summary>
        [AttributeLogicalName("activityid")]
        [RelationshipSchemaName("activity_pointer_incident_resolution")]
        public ActivityPointer activity_pointer_incident_resolution
        {
            get { return GetRelatedEntity<ActivityPointer>("activity_pointer_incident_resolution", null); }
            set
            {
                OnPropertyChanging("activity_pointer_incident_resolution");
                SetRelatedEntity("activity_pointer_incident_resolution", null, value);
                OnPropertyChanged("activity_pointer_incident_resolution");
            }
        }

        /// <summary>
        ///     N:1 business_unit_incident_resolution_activities
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_incident_resolution_activities")]
        public BusinessUnit business_unit_incident_resolution_activities
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_incident_resolution_activities", null); }
        }

        /// <summary>
        ///     N:1 Incident_IncidentResolutions
        /// </summary>
        [AttributeLogicalName("incidentid")]
        [RelationshipSchemaName("Incident_IncidentResolutions")]
        public Incident Incident_IncidentResolutions
        {
            get { return GetRelatedEntity<Incident>("Incident_IncidentResolutions", null); }
            set
            {
                OnPropertyChanging("Incident_IncidentResolutions");
                SetRelatedEntity("Incident_IncidentResolutions", null, value);
                OnPropertyChanged("Incident_IncidentResolutions");
            }
        }

        /// <summary>
        ///     N:1 lk_incidentresolution_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_incidentresolution_createdby")]
        public SystemUser lk_incidentresolution_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_incidentresolution_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_incidentresolution_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_incidentresolution_createdonbehalfby")]
        public SystemUser lk_incidentresolution_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_incidentresolution_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_incidentresolution_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_incidentresolution_modifiedby")]
        public SystemUser lk_incidentresolution_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_incidentresolution_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_incidentresolution_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_incidentresolution_modifiedonbehalfby")]
        public SystemUser lk_incidentresolution_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_incidentresolution_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 service_incidentresolutions
        /// </summary>
        [AttributeLogicalName("serviceid")]
        [RelationshipSchemaName("service_incidentresolutions")]
        public Service service_incidentresolutions
        {
            get { return GetRelatedEntity<Service>("service_incidentresolutions", null); }
            set
            {
                OnPropertyChanging("service_incidentresolutions");
                SetRelatedEntity("service_incidentresolutions", null, value);
                OnPropertyChanged("service_incidentresolutions");
            }
        }

        /// <summary>
        ///     N:1 team_incidentresolution
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_incidentresolution")]
        public Team team_incidentresolution
        {
            get { return GetRelatedEntity<Team>("team_incidentresolution", null); }
        }

        /// <summary>
        ///     N:1 user_incidentresolution
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_incidentresolution")]
        public SystemUser user_incidentresolution
        {
            get { return GetRelatedEntity<SystemUser>("user_incidentresolution", null); }
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