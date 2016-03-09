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
    ///     Generic activity representing work needed to be done.
    /// </summary>
    [DataContract]
    [EntityLogicalName("task")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Task : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "task";

        public const int EntityTypeCode = 4212;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Task() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the task.
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
        ///     Type the number of minutes spent on the task. The duration is used in reporting.
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
        ///     Enter the actual end date and time of the task. By default, it displays when the activity was completed or
        ///     canceled.
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
        ///     Enter the actual start date and time for the task. By default, it displays when the task was created.
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
        ///     Type a category to identify the task type, such as lead gathering or customer follow up, to tie the task to a
        ///     business group or function.
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
        ///     Type additional information to describe the task.
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
        ///     Information which specifies whether the task was billed as part of resolving a case.
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
        ///     Information which specifies if the task was created from a workflow rule.
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
        ///     Shows the record owner's business unit.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team that owns the task.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user that owns the task.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Type the percentage complete value for the task to track tasks to completion.
        /// </summary>
        [AttributeLogicalName("percentcomplete")]
        public int? PercentComplete
        {
            get { return GetAttributeValue<int?>("percentcomplete"); }
            set
            {
                OnPropertyChanging("PercentComplete");
                SetAttributeValue("percentcomplete", value);
                OnPropertyChanged("PercentComplete");
            }
        }

        /// <summary>
        ///     Select the priority so that preferred customers or critical issues are handled quickly.
        /// </summary>
        [AttributeLogicalName("prioritycode")]
        public OptionSetValue PriorityCode
        {
            get { return GetAttributeValue<OptionSetValue>("prioritycode"); }
            set
            {
                OnPropertyChanging("PriorityCode");
                SetAttributeValue("prioritycode", value);
                OnPropertyChanged("PriorityCode");
            }
        }

        /// <summary>
        ///     Shows the ID of the process.
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
        ///     Unique identifier of the object with which the task is associated.
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
        ///     Scheduled duration of the task, specified in minutes.
        /// </summary>
        [AttributeLogicalName("scheduleddurationminutes")]
        public int? ScheduledDurationMinutes
        {
            get { return GetAttributeValue<int?>("scheduleddurationminutes"); }
        }

        /// <summary>
        ///     Enter the expected due date and time.
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
        ///     Enter the expected due date and time.
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
        ///     Choose the service that is associated with this activity.
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
        ///     Shows whether the task is open, completed, or canceled. Completed and canceled tasks are read-only and can't be
        ///     edited.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public TaskState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((TaskState) (Enum.ToObject(typeof (TaskState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Select the task's status.
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
        ///     Type a subcategory to identify the task type and relate the activity to a specific product, sales region, business
        ///     group, or other function.
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
        ///     Type a short description about the objective or primary topic of the task.
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
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("subscriptionid")]
        public Guid? SubscriptionId
        {
            get { return GetAttributeValue<Guid?>("subscriptionid"); }
            set
            {
                OnPropertyChanging("SubscriptionId");
                SetAttributeValue("subscriptionid", value);
                OnPropertyChanged("SubscriptionId");
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
        ///     Version number of the task.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N task_activity_parties
        /// </summary>
        [RelationshipSchemaName("task_activity_parties")]
        public IEnumerable<ActivityParty> task_activity_parties
        {
            get { return GetRelatedEntities<ActivityParty>("task_activity_parties", null); }
            set
            {
                OnPropertyChanging("task_activity_parties");
                SetRelatedEntities("task_activity_parties", null, value);
                OnPropertyChanged("task_activity_parties");
            }
        }

        /// <summary>
        ///     1:N Task_Annotation
        /// </summary>
        [RelationshipSchemaName("Task_Annotation")]
        public IEnumerable<Annotation> Task_Annotation
        {
            get { return GetRelatedEntities<Annotation>("Task_Annotation", null); }
            set
            {
                OnPropertyChanging("Task_Annotation");
                SetRelatedEntities("Task_Annotation", null, value);
                OnPropertyChanged("Task_Annotation");
            }
        }

        /// <summary>
        ///     1:N Task_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Task_AsyncOperations")]
        public IEnumerable<AsyncOperation> Task_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Task_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Task_AsyncOperations");
                SetRelatedEntities("Task_AsyncOperations", null, value);
                OnPropertyChanged("Task_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N Task_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("Task_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> Task_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("Task_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("Task_BulkDeleteFailures");
                SetRelatedEntities("Task_BulkDeleteFailures", null, value);
                OnPropertyChanged("Task_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N task_connections1
        /// </summary>
        [RelationshipSchemaName("task_connections1")]
        public IEnumerable<Connection> task_connections1
        {
            get { return GetRelatedEntities<Connection>("task_connections1", null); }
            set
            {
                OnPropertyChanging("task_connections1");
                SetRelatedEntities("task_connections1", null, value);
                OnPropertyChanged("task_connections1");
            }
        }

        /// <summary>
        ///     1:N task_connections2
        /// </summary>
        [RelationshipSchemaName("task_connections2")]
        public IEnumerable<Connection> task_connections2
        {
            get { return GetRelatedEntities<Connection>("task_connections2", null); }
            set
            {
                OnPropertyChanging("task_connections2");
                SetRelatedEntities("task_connections2", null, value);
                OnPropertyChanged("task_connections2");
            }
        }

        /// <summary>
        ///     1:N Task_DuplicateBaseRecord
        /// </summary>
        [RelationshipSchemaName("Task_DuplicateBaseRecord")]
        public IEnumerable<DuplicateRecord> Task_DuplicateBaseRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Task_DuplicateBaseRecord", null); }
            set
            {
                OnPropertyChanging("Task_DuplicateBaseRecord");
                SetRelatedEntities("Task_DuplicateBaseRecord", null, value);
                OnPropertyChanged("Task_DuplicateBaseRecord");
            }
        }

        /// <summary>
        ///     1:N Task_DuplicateMatchingRecord
        /// </summary>
        [RelationshipSchemaName("Task_DuplicateMatchingRecord")]
        public IEnumerable<DuplicateRecord> Task_DuplicateMatchingRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Task_DuplicateMatchingRecord", null); }
            set
            {
                OnPropertyChanging("Task_DuplicateMatchingRecord");
                SetRelatedEntities("Task_DuplicateMatchingRecord", null, value);
                OnPropertyChanged("Task_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        ///     1:N task_PostFollows
        /// </summary>
        [RelationshipSchemaName("task_PostFollows")]
        public IEnumerable<PostFollow> task_PostFollows
        {
            get { return GetRelatedEntities<PostFollow>("task_PostFollows", null); }
            set
            {
                OnPropertyChanging("task_PostFollows");
                SetRelatedEntities("task_PostFollows", null, value);
                OnPropertyChanged("task_PostFollows");
            }
        }

        /// <summary>
        ///     1:N task_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("task_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> task_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntities<PrincipalObjectAttributeAccess>("task_principalobjectattributeaccess", null);
            }
            set
            {
                OnPropertyChanging("task_principalobjectattributeaccess");
                SetRelatedEntities("task_principalobjectattributeaccess", null, value);
                OnPropertyChanged("task_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N Task_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("Task_ProcessSessions")]
        public IEnumerable<ProcessSession> Task_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("Task_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Task_ProcessSessions");
                SetRelatedEntities("Task_ProcessSessions", null, value);
                OnPropertyChanged("Task_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N Task_QueueItem
        /// </summary>
        [RelationshipSchemaName("Task_QueueItem")]
        public IEnumerable<QueueItem> Task_QueueItem
        {
            get { return GetRelatedEntities<QueueItem>("Task_QueueItem", null); }
            set
            {
                OnPropertyChanging("Task_QueueItem");
                SetRelatedEntities("Task_QueueItem", null, value);
                OnPropertyChanged("Task_QueueItem");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_task
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_task")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_task
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_task", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_task");
                SetRelatedEntities("userentityinstancedata_task", null, value);
                OnPropertyChanged("userentityinstancedata_task");
            }
        }

        /// <summary>
        ///     N:1 Account_Tasks
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Account_Tasks")]
        public Account Account_Tasks
        {
            get { return GetRelatedEntity<Account>("Account_Tasks", null); }
            set
            {
                OnPropertyChanging("Account_Tasks");
                SetRelatedEntity("Account_Tasks", null, value);
                OnPropertyChanged("Account_Tasks");
            }
        }

        /// <summary>
        ///     N:1 activity_pointer_task
        /// </summary>
        [AttributeLogicalName("activityid")]
        [RelationshipSchemaName("activity_pointer_task")]
        public ActivityPointer activity_pointer_task
        {
            get { return GetRelatedEntity<ActivityPointer>("activity_pointer_task", null); }
            set
            {
                OnPropertyChanging("activity_pointer_task");
                SetRelatedEntity("activity_pointer_task", null, value);
                OnPropertyChanged("activity_pointer_task");
            }
        }

        /// <summary>
        ///     N:1 business_unit_task_activities
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_task_activities")]
        public BusinessUnit business_unit_task_activities
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_task_activities", null); }
        }

        /// <summary>
        ///     N:1 Campaign_Tasks
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Campaign_Tasks")]
        public Campaign Campaign_Tasks
        {
            get { return GetRelatedEntity<Campaign>("Campaign_Tasks", null); }
            set
            {
                OnPropertyChanging("Campaign_Tasks");
                SetRelatedEntity("Campaign_Tasks", null, value);
                OnPropertyChanged("Campaign_Tasks");
            }
        }

        /// <summary>
        ///     N:1 CampaignActivity_Tasks
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("CampaignActivity_Tasks")]
        public CampaignActivity CampaignActivity_Tasks
        {
            get { return GetRelatedEntity<CampaignActivity>("CampaignActivity_Tasks", null); }
            set
            {
                OnPropertyChanging("CampaignActivity_Tasks");
                SetRelatedEntity("CampaignActivity_Tasks", null, value);
                OnPropertyChanged("CampaignActivity_Tasks");
            }
        }

        /// <summary>
        ///     N:1 Contact_Tasks
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Contact_Tasks")]
        public Contact Contact_Tasks
        {
            get { return GetRelatedEntity<Contact>("Contact_Tasks", null); }
            set
            {
                OnPropertyChanging("Contact_Tasks");
                SetRelatedEntity("Contact_Tasks", null, value);
                OnPropertyChanged("Contact_Tasks");
            }
        }

        /// <summary>
        ///     N:1 Contract_Tasks
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Contract_Tasks")]
        public Contract Contract_Tasks
        {
            get { return GetRelatedEntity<Contract>("Contract_Tasks", null); }
            set
            {
                OnPropertyChanging("Contract_Tasks");
                SetRelatedEntity("Contract_Tasks", null, value);
                OnPropertyChanged("Contract_Tasks");
            }
        }

        /// <summary>
        ///     N:1 Incident_Tasks
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Incident_Tasks")]
        public Incident Incident_Tasks
        {
            get { return GetRelatedEntity<Incident>("Incident_Tasks", null); }
            set
            {
                OnPropertyChanging("Incident_Tasks");
                SetRelatedEntity("Incident_Tasks", null, value);
                OnPropertyChanged("Incident_Tasks");
            }
        }

        /// <summary>
        ///     N:1 Invoice_Tasks
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Invoice_Tasks")]
        public Invoice Invoice_Tasks
        {
            get { return GetRelatedEntity<Invoice>("Invoice_Tasks", null); }
            set
            {
                OnPropertyChanging("Invoice_Tasks");
                SetRelatedEntity("Invoice_Tasks", null, value);
                OnPropertyChanged("Invoice_Tasks");
            }
        }

        /// <summary>
        ///     N:1 Lead_Tasks
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Lead_Tasks")]
        public Lead Lead_Tasks
        {
            get { return GetRelatedEntity<Lead>("Lead_Tasks", null); }
            set
            {
                OnPropertyChanging("Lead_Tasks");
                SetRelatedEntity("Lead_Tasks", null, value);
                OnPropertyChanged("Lead_Tasks");
            }
        }

        /// <summary>
        ///     N:1 lk_task_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_task_createdby")]
        public SystemUser lk_task_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_task_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_task_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_task_createdonbehalfby")]
        public SystemUser lk_task_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_task_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_task_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_task_modifiedby")]
        public SystemUser lk_task_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_task_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_task_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_task_modifiedonbehalfby")]
        public SystemUser lk_task_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_task_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 msdyn_postalbum_Tasks
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("msdyn_postalbum_Tasks")]
        public msdyn_PostAlbum msdyn_postalbum_Tasks
        {
            get { return GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_Tasks", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_Tasks");
                SetRelatedEntity("msdyn_postalbum_Tasks", null, value);
                OnPropertyChanged("msdyn_postalbum_Tasks");
            }
        }

        /// <summary>
        ///     N:1 Opportunity_Tasks
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Opportunity_Tasks")]
        public Opportunity Opportunity_Tasks
        {
            get { return GetRelatedEntity<Opportunity>("Opportunity_Tasks", null); }
            set
            {
                OnPropertyChanging("Opportunity_Tasks");
                SetRelatedEntity("Opportunity_Tasks", null, value);
                OnPropertyChanged("Opportunity_Tasks");
            }
        }

        /// <summary>
        ///     N:1 processstage_tasks
        /// </summary>
        [AttributeLogicalName("stageid")]
        [RelationshipSchemaName("processstage_tasks")]
        public ProcessStage processstage_tasks
        {
            get { return GetRelatedEntity<ProcessStage>("processstage_tasks", null); }
            set
            {
                OnPropertyChanging("processstage_tasks");
                SetRelatedEntity("processstage_tasks", null, value);
                OnPropertyChanged("processstage_tasks");
            }
        }

        /// <summary>
        ///     N:1 Quote_Tasks
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Quote_Tasks")]
        public Quote Quote_Tasks
        {
            get { return GetRelatedEntity<Quote>("Quote_Tasks", null); }
            set
            {
                OnPropertyChanging("Quote_Tasks");
                SetRelatedEntity("Quote_Tasks", null, value);
                OnPropertyChanged("Quote_Tasks");
            }
        }

        /// <summary>
        ///     N:1 SalesOrder_Tasks
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SalesOrder_Tasks")]
        public SalesOrder SalesOrder_Tasks
        {
            get { return GetRelatedEntity<SalesOrder>("SalesOrder_Tasks", null); }
            set
            {
                OnPropertyChanging("SalesOrder_Tasks");
                SetRelatedEntity("SalesOrder_Tasks", null, value);
                OnPropertyChanged("SalesOrder_Tasks");
            }
        }

        /// <summary>
        ///     N:1 service_tasks
        /// </summary>
        [AttributeLogicalName("serviceid")]
        [RelationshipSchemaName("service_tasks")]
        public Service service_tasks
        {
            get { return GetRelatedEntity<Service>("service_tasks", null); }
            set
            {
                OnPropertyChanging("service_tasks");
                SetRelatedEntity("service_tasks", null, value);
                OnPropertyChanged("service_tasks");
            }
        }

        /// <summary>
        ///     N:1 team_task
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_task")]
        public Team team_task
        {
            get { return GetRelatedEntity<Team>("team_task", null); }
        }

        /// <summary>
        ///     N:1 TransactionCurrency_Task
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("TransactionCurrency_Task")]
        public TransactionCurrency TransactionCurrency_Task
        {
            get { return GetRelatedEntity<TransactionCurrency>("TransactionCurrency_Task", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_Task");
                SetRelatedEntity("TransactionCurrency_Task", null, value);
                OnPropertyChanged("TransactionCurrency_Task");
            }
        }

        /// <summary>
        ///     N:1 user_task
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_task")]
        public SystemUser user_task
        {
            get { return GetRelatedEntity<SystemUser>("user_task", null); }
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