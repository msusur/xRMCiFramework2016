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
    ///     System operation used to perform lengthy and asynchronous operations on large data sets, such as distributing a
    ///     campaign activity or quick campaign.
    /// </summary>
    [DataContract]
    [EntityLogicalName("bulkoperation")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class BulkOperation : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "bulkoperation";

        public const int EntityTypeCode = 4406;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public BulkOperation() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the bulk operation.
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
        ///     Actual duration of the bulk operation in minutes.
        /// </summary>
        [AttributeLogicalName("actualdurationminutes")]
        public int? ActualDurationMinutes
        {
            get { return GetAttributeValue<int?>("actualdurationminutes"); }
        }

        /// <summary>
        ///     Shows the date and time when the quick campaign was completed or canceled.
        /// </summary>
        [AttributeLogicalName("actualend")]
        public DateTime? ActualEnd
        {
            get { return GetAttributeValue<DateTime?>("actualend"); }
        }

        /// <summary>
        ///     Shows the date and time when the activity was started or created.
        /// </summary>
        [AttributeLogicalName("actualstart")]
        public DateTime? ActualStart
        {
            get { return GetAttributeValue<DateTime?>("actualstart"); }
        }

        /// <summary>
        ///     Shows the number for the quick campaign record, used to identify the quick campaign.
        /// </summary>
        [AttributeLogicalName("bulkoperationnumber")]
        public string BulkOperationNumber
        {
            get { return GetAttributeValue<string>("bulkoperationnumber"); }
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
        ///     Unique identifier of the delegate user who created the bulk operation.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Choose the activity to create that determines how target prospects or customers in this quick campaign are
        ///     contacted.
        /// </summary>
        [AttributeLogicalName("createdrecordtypecode")]
        public OptionSetValue CreatedRecordTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("createdrecordtypecode"); }
        }

        /// <summary>
        ///     Type additional information to describe the quick campaign, such as the products or services offered.
        /// </summary>
        [AttributeLogicalName("description")]
        public string Description
        {
            get { return GetAttributeValue<string>("description"); }
        }

        /// <summary>
        ///     Shows the error code that is used to troubleshoot issues in the quick campaign.
        /// </summary>
        [AttributeLogicalName("errornumber")]
        public int? ErrorNumber
        {
            get { return GetAttributeValue<int?>("errornumber"); }
        }

        /// <summary>
        ///     Number of records which failed in the bulk operation.
        /// </summary>
        [AttributeLogicalName("failurecount")]
        public int? FailureCount
        {
            get { return GetAttributeValue<int?>("failurecount"); }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("isbilled")]
        public bool? IsBilled
        {
            get { return GetAttributeValue<bool?>("isbilled"); }
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
        ///     Specifies if the bulk operation was created from a workflow rule.
        /// </summary>
        [AttributeLogicalName("isworkflowcreated")]
        public bool? IsWorkflowCreated
        {
            get { return GetAttributeValue<bool?>("isworkflowcreated"); }
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
        ///     Date and time when the bulk operation was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the bulk operation.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Select the type of bulk operation process, such as quick campaign or campaign activity distribution.
        /// </summary>
        [AttributeLogicalName("operationtypecode")]
        public OptionSetValue OperationTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("operationtypecode"); }
        }

        /// <summary>
        ///     Enter the user or team who is assigned to manage the record. This field is updated every time the record is
        ///     assigned to a different user.
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
        ///     Unique identifier of the business unit that owns the bulk operation.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the bulk operation.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the bulk operation.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     XML string that contains the parameters to the bulk operation.
        /// </summary>
        [AttributeLogicalName("parameters")]
        public string Parameters
        {
            get { return GetAttributeValue<string>("parameters"); }
        }

        /// <summary>
        ///     Choose the campaign from which the campaign activities were bulk-distributed.
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        public EntityReference RegardingObjectId
        {
            get { return GetAttributeValue<EntityReference>("regardingobjectid"); }
            set
            {
                OnPropertyChanging("RegardingObjectId");
                SetAttributeValue("regardingobjectid", value);
                OnPropertyChanged("RegardingObjectId");
            }
        }

        /// <summary>
        ///     Scheduled duration of the bulk operation, specified in minutes.
        /// </summary>
        [AttributeLogicalName("scheduleddurationminutes")]
        public int? ScheduledDurationMinutes
        {
            get { return GetAttributeValue<int?>("scheduleddurationminutes"); }
        }

        /// <summary>
        ///     Scheduled end date and time of the bulk operation.
        /// </summary>
        [AttributeLogicalName("scheduledend")]
        public DateTime? ScheduledEnd
        {
            get { return GetAttributeValue<DateTime?>("scheduledend"); }
        }

        /// <summary>
        ///     Scheduled start date and time of the bulk operation.
        /// </summary>
        [AttributeLogicalName("scheduledstart")]
        public DateTime? ScheduledStart
        {
            get { return GetAttributeValue<DateTime?>("scheduledstart"); }
        }

        /// <summary>
        ///     Unique identifier for an associated service.
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
        ///     Shows whether the quick campaign is open, closed, or canceled. Closed or canceled quick campaigns are read-only and
        ///     can't be edited.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public BulkOperationState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((BulkOperationState) (Enum.ToObject(typeof (BulkOperationState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Select the quick campaign's status.
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
        ///     Type a short description about the objective or primary topic of the quick campaign.
        /// </summary>
        [AttributeLogicalName("subject")]
        public string Subject
        {
            get { return GetAttributeValue<string>("subject"); }
        }

        /// <summary>
        ///     Number of records which succeeded in the bulk operation.
        /// </summary>
        [AttributeLogicalName("successcount")]
        public int? SuccessCount
        {
            get { return GetAttributeValue<int?>("successcount"); }
        }

        /// <summary>
        ///     Select the type of records targeted in the quick campaign to identify the target audience.
        /// </summary>
        [AttributeLogicalName("targetedrecordtypecode")]
        public OptionSetValue TargetedRecordTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("targetedrecordtypecode"); }
        }

        /// <summary>
        ///     Number of members to target.
        /// </summary>
        [AttributeLogicalName("targetmemberscount")]
        public int? TargetMembersCount
        {
            get { return GetAttributeValue<int?>("targetmemberscount"); }
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
        ///     Version number of the bulk operation.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N bulkoperation_activity_parties
        /// </summary>
        [RelationshipSchemaName("bulkoperation_activity_parties")]
        public IEnumerable<ActivityParty> bulkoperation_activity_parties
        {
            get { return GetRelatedEntities<ActivityParty>("bulkoperation_activity_parties", null); }
            set
            {
                OnPropertyChanging("bulkoperation_activity_parties");
                SetRelatedEntities("bulkoperation_activity_parties", null, value);
                OnPropertyChanged("bulkoperation_activity_parties");
            }
        }

        /// <summary>
        ///     1:N BulkOperation_ActivityPointers
        /// </summary>
        [RelationshipSchemaName("BulkOperation_ActivityPointers")]
        public IEnumerable<ActivityPointer> BulkOperation_ActivityPointers
        {
            get { return GetRelatedEntities<ActivityPointer>("BulkOperation_ActivityPointers", null); }
            set
            {
                OnPropertyChanging("BulkOperation_ActivityPointers");
                SetRelatedEntities("BulkOperation_ActivityPointers", null, value);
                OnPropertyChanged("BulkOperation_ActivityPointers");
            }
        }

        /// <summary>
        ///     1:N BulkOperation_Appointment
        /// </summary>
        [RelationshipSchemaName("BulkOperation_Appointment")]
        public IEnumerable<Appointment> BulkOperation_Appointment
        {
            get { return GetRelatedEntities<Appointment>("BulkOperation_Appointment", null); }
            set
            {
                OnPropertyChanging("BulkOperation_Appointment");
                SetRelatedEntities("BulkOperation_Appointment", null, value);
                OnPropertyChanged("BulkOperation_Appointment");
            }
        }

        /// <summary>
        ///     1:N BulkOperation_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("BulkOperation_AsyncOperations")]
        public IEnumerable<AsyncOperation> BulkOperation_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("BulkOperation_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("BulkOperation_AsyncOperations");
                SetRelatedEntities("BulkOperation_AsyncOperations", null, value);
                OnPropertyChanged("BulkOperation_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N BulkOperation_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("BulkOperation_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> BulkOperation_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("BulkOperation_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("BulkOperation_BulkDeleteFailures");
                SetRelatedEntities("BulkOperation_BulkDeleteFailures", null, value);
                OnPropertyChanged("BulkOperation_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N BulkOperation_CampaignResponse
        /// </summary>
        [RelationshipSchemaName("BulkOperation_CampaignResponse")]
        public IEnumerable<CampaignResponse> BulkOperation_CampaignResponse
        {
            get { return GetRelatedEntities<CampaignResponse>("BulkOperation_CampaignResponse", null); }
            set
            {
                OnPropertyChanging("BulkOperation_CampaignResponse");
                SetRelatedEntities("BulkOperation_CampaignResponse", null, value);
                OnPropertyChanged("BulkOperation_CampaignResponse");
            }
        }

        /// <summary>
        ///     1:N BulkOperation_Email
        /// </summary>
        [RelationshipSchemaName("BulkOperation_Email")]
        public IEnumerable<Email> BulkOperation_Email
        {
            get { return GetRelatedEntities<Email>("BulkOperation_Email", null); }
            set
            {
                OnPropertyChanging("BulkOperation_Email");
                SetRelatedEntities("BulkOperation_Email", null, value);
                OnPropertyChanged("BulkOperation_Email");
            }
        }

        /// <summary>
        ///     1:N BulkOperation_Faxes
        /// </summary>
        [RelationshipSchemaName("BulkOperation_Faxes")]
        public IEnumerable<Fax> BulkOperation_Faxes
        {
            get { return GetRelatedEntities<Fax>("BulkOperation_Faxes", null); }
            set
            {
                OnPropertyChanging("BulkOperation_Faxes");
                SetRelatedEntities("BulkOperation_Faxes", null, value);
                OnPropertyChanged("BulkOperation_Faxes");
            }
        }

        /// <summary>
        ///     1:N BulkOperation_Letter
        /// </summary>
        [RelationshipSchemaName("BulkOperation_Letter")]
        public IEnumerable<Letter> BulkOperation_Letter
        {
            get { return GetRelatedEntities<Letter>("BulkOperation_Letter", null); }
            set
            {
                OnPropertyChanging("BulkOperation_Letter");
                SetRelatedEntities("BulkOperation_Letter", null, value);
                OnPropertyChanged("BulkOperation_Letter");
            }
        }

        /// <summary>
        ///     1:N BulkOperation_logs
        /// </summary>
        [RelationshipSchemaName("BulkOperation_logs")]
        public IEnumerable<BulkOperationLog> BulkOperation_logs
        {
            get { return GetRelatedEntities<BulkOperationLog>("BulkOperation_logs", null); }
            set
            {
                OnPropertyChanging("BulkOperation_logs");
                SetRelatedEntities("BulkOperation_logs", null, value);
                OnPropertyChanged("BulkOperation_logs");
            }
        }

        /// <summary>
        ///     1:N BulkOperation_Phonecall
        /// </summary>
        [RelationshipSchemaName("BulkOperation_Phonecall")]
        public IEnumerable<PhoneCall> BulkOperation_Phonecall
        {
            get { return GetRelatedEntities<PhoneCall>("BulkOperation_Phonecall", null); }
            set
            {
                OnPropertyChanging("BulkOperation_Phonecall");
                SetRelatedEntities("BulkOperation_Phonecall", null, value);
                OnPropertyChanged("BulkOperation_Phonecall");
            }
        }

        /// <summary>
        ///     1:N BulkOperation_QueueItem
        /// </summary>
        [RelationshipSchemaName("BulkOperation_QueueItem")]
        public IEnumerable<QueueItem> BulkOperation_QueueItem
        {
            get { return GetRelatedEntities<QueueItem>("BulkOperation_QueueItem", null); }
            set
            {
                OnPropertyChanging("BulkOperation_QueueItem");
                SetRelatedEntities("BulkOperation_QueueItem", null, value);
                OnPropertyChanged("BulkOperation_QueueItem");
            }
        }

        /// <summary>
        ///     1:N BulkOperation_RecurringAppointmentMaster
        /// </summary>
        [RelationshipSchemaName("BulkOperation_RecurringAppointmentMaster")]
        public IEnumerable<RecurringAppointmentMaster> BulkOperation_RecurringAppointmentMaster
        {
            get
            {
                return GetRelatedEntities<RecurringAppointmentMaster>("BulkOperation_RecurringAppointmentMaster", null);
            }
            set
            {
                OnPropertyChanging("BulkOperation_RecurringAppointmentMaster");
                SetRelatedEntities("BulkOperation_RecurringAppointmentMaster", null, value);
                OnPropertyChanged("BulkOperation_RecurringAppointmentMaster");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_bulkoperation
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_bulkoperation")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_bulkoperation
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_bulkoperation", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_bulkoperation");
                SetRelatedEntities("userentityinstancedata_bulkoperation", null, value);
                OnPropertyChanged("userentityinstancedata_bulkoperation");
            }
        }

        /// <summary>
        ///     N:1 activity_pointer_BulkOperation
        /// </summary>
        [AttributeLogicalName("activityid")]
        [RelationshipSchemaName("activity_pointer_BulkOperation")]
        public ActivityPointer activity_pointer_BulkOperation
        {
            get { return GetRelatedEntity<ActivityPointer>("activity_pointer_BulkOperation", null); }
            set
            {
                OnPropertyChanging("activity_pointer_BulkOperation");
                SetRelatedEntity("activity_pointer_BulkOperation", null, value);
                OnPropertyChanged("activity_pointer_BulkOperation");
            }
        }

        /// <summary>
        ///     N:1 business_unit_BulkOperation_activities
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_BulkOperation_activities")]
        public BusinessUnit business_unit_BulkOperation_activities
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_BulkOperation_activities", null); }
        }

        /// <summary>
        ///     N:1 CampaignActivity_BulkOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("CampaignActivity_BulkOperations")]
        public CampaignActivity CampaignActivity_BulkOperations
        {
            get { return GetRelatedEntity<CampaignActivity>("CampaignActivity_BulkOperations", null); }
            set
            {
                OnPropertyChanging("CampaignActivity_BulkOperations");
                SetRelatedEntity("CampaignActivity_BulkOperations", null, value);
                OnPropertyChanged("CampaignActivity_BulkOperations");
            }
        }

        /// <summary>
        ///     N:1 List_BulkOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("List_BulkOperations")]
        public List List_BulkOperations
        {
            get { return GetRelatedEntity<List>("List_BulkOperations", null); }
            set
            {
                OnPropertyChanging("List_BulkOperations");
                SetRelatedEntity("List_BulkOperations", null, value);
                OnPropertyChanged("List_BulkOperations");
            }
        }

        /// <summary>
        ///     N:1 lk_BulkOperation_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_BulkOperation_createdby")]
        public SystemUser lk_BulkOperation_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_BulkOperation_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_BulkOperation_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_BulkOperation_createdonbehalfby")]
        public SystemUser lk_BulkOperation_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_BulkOperation_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_BulkOperation_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_BulkOperation_modifiedby")]
        public SystemUser lk_BulkOperation_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_BulkOperation_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_BulkOperation_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_BulkOperation_modifiedonbehalfby")]
        public SystemUser lk_BulkOperation_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_BulkOperation_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 team_BulkOperation
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_BulkOperation")]
        public Team team_BulkOperation
        {
            get { return GetRelatedEntity<Team>("team_BulkOperation", null); }
        }

        /// <summary>
        ///     N:1 user_BulkOperation
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_BulkOperation")]
        public SystemUser user_BulkOperation
        {
            get { return GetRelatedEntity<SystemUser>("user_BulkOperation", null); }
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