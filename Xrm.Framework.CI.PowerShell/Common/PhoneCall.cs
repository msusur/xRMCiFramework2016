using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Xrm.Framework.CI.Common.Entities
{
    /// <summary>
    ///     Activity to track a telephone call.
    /// </summary>
    [DataContract]
    [EntityLogicalName("phonecall")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class PhoneCall : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "phonecall";

        public const int EntityTypeCode = 4210;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public PhoneCall() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the phone call activity.
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
        ///     Shows the type of activity.
        /// </summary>
        [AttributeLogicalName("activitytypecode")]
        public string ActivityTypeCode
        {
            get { return GetAttributeValue<string>("activitytypecode"); }
        }

        /// <summary>
        ///     Type the number of minutes spent on the phone call. The duration is used in reporting.
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
        ///     Enter the actual end date and time of the phone call. By default, it displays the date and time when the activity
        ///     was completed or canceled, but can be edited to capture the actual duration of the phone call.
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
        ///     Enter the actual start date and time for the phone call. By default, it displays the date and time when the
        ///     activity was created, but can be edited to capture the actual duration of the phone call.
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
        ///     Type a category to identify the phone call type, such as lead gathering or customer follow-up, to tie the phone
        ///     call to a business group or function.
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
        ///     Type additional information to describe the phone call, such as the primary message or the products and services
        ///     discussed.
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
        ///     Select the direction of the phone call as incoming or outbound.
        /// </summary>
        [AttributeLogicalName("directioncode")]
        public bool? DirectionCode
        {
            get { return GetAttributeValue<bool?>("directioncode"); }
            set
            {
                OnPropertyChanging("DirectionCode");
                SetAttributeValue("directioncode", value);
                OnPropertyChanged("DirectionCode");
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
        ///     Enter the account, contact, lead, or user who made the phone call.
        /// </summary>
        [AttributeLogicalName("from")]
        public IEnumerable<ActivityParty> From
        {
            get
            {
                var collection = GetAttributeValue<EntityCollection>("from");
                if (((collection != null)
                     && (collection.Entities != null)))
                {
                    return Enumerable.Cast<ActivityParty>(collection.Entities);
                }
                return null;
            }
            set
            {
                OnPropertyChanging("From");
                if ((value == null))
                {
                    SetAttributeValue("from", value);
                }
                else
                {
                    SetAttributeValue("from", new EntityCollection(new List<Entity>(value)));
                }
                OnPropertyChanged("From");
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
        ///     Information which specifies whether the phone call activity was billed as part of resolving a case.
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
        ///     Indication which specifies if the phone call activity was created by a workflow rule.
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
        ///     Select whether a voice mail was left for the person.
        /// </summary>
        [AttributeLogicalName("leftvoicemail")]
        public bool? LeftVoiceMail
        {
            get { return GetAttributeValue<bool?>("leftvoicemail"); }
            set
            {
                OnPropertyChanging("LeftVoiceMail");
                SetAttributeValue("leftvoicemail", value);
                OnPropertyChanged("LeftVoiceMail");
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
        ///     Unique identifier of the business unit that owns the phone call activity.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team that owns the phone call activity.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user that owns the phone call activity.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Type the phone number.
        /// </summary>
        [AttributeLogicalName("phonenumber")]
        public string PhoneNumber
        {
            get { return GetAttributeValue<string>("phonenumber"); }
            set
            {
                OnPropertyChanging("PhoneNumber");
                SetAttributeValue("phonenumber", value);
                OnPropertyChanged("PhoneNumber");
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
        ///     Unique identifier of the object with which the phone call activity is associated.
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
        ///     Scheduled duration of the phone call activity, specified in minutes.
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
        ///     Shows whether the phone call is open, completed, or canceled. Completed and canceled phone calls are read-only and
        ///     can't be edited.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public PhoneCallState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((PhoneCallState) (Enum.ToObject(typeof (PhoneCallState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Select the phone call's status.
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
        ///     Type a subcategory to identify the phone call type and relate the activity to a specific product, sales region,
        ///     business group, or other function.
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
        ///     Type a short description about the objective or primary topic of the phone call.
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
        ///     Enter the account, contact, lead, or user recipients of the phone call.
        /// </summary>
        [AttributeLogicalName("to")]
        public IEnumerable<ActivityParty> To
        {
            get
            {
                var collection = GetAttributeValue<EntityCollection>("to");
                if (((collection != null)
                     && (collection.Entities != null)))
                {
                    return Enumerable.Cast<ActivityParty>(collection.Entities);
                }
                return null;
            }
            set
            {
                OnPropertyChanging("To");
                if ((value == null))
                {
                    SetAttributeValue("to", value);
                }
                else
                {
                    SetAttributeValue("to", new EntityCollection(new List<Entity>(value)));
                }
                OnPropertyChanged("To");
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
        ///     Version number of the phone call activity.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N phonecall_activity_parties
        /// </summary>
        [RelationshipSchemaName("phonecall_activity_parties")]
        public IEnumerable<ActivityParty> phonecall_activity_parties
        {
            get { return GetRelatedEntities<ActivityParty>("phonecall_activity_parties", null); }
            set
            {
                OnPropertyChanging("phonecall_activity_parties");
                SetRelatedEntities("phonecall_activity_parties", null, value);
                OnPropertyChanged("phonecall_activity_parties");
            }
        }

        /// <summary>
        ///     1:N PhoneCall_Annotation
        /// </summary>
        [RelationshipSchemaName("PhoneCall_Annotation")]
        public IEnumerable<Annotation> PhoneCall_Annotation
        {
            get { return GetRelatedEntities<Annotation>("PhoneCall_Annotation", null); }
            set
            {
                OnPropertyChanging("PhoneCall_Annotation");
                SetRelatedEntities("PhoneCall_Annotation", null, value);
                OnPropertyChanged("PhoneCall_Annotation");
            }
        }

        /// <summary>
        ///     1:N PhoneCall_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("PhoneCall_AsyncOperations")]
        public IEnumerable<AsyncOperation> PhoneCall_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("PhoneCall_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("PhoneCall_AsyncOperations");
                SetRelatedEntities("PhoneCall_AsyncOperations", null, value);
                OnPropertyChanged("PhoneCall_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N PhoneCall_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("PhoneCall_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> PhoneCall_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("PhoneCall_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("PhoneCall_BulkDeleteFailures");
                SetRelatedEntities("PhoneCall_BulkDeleteFailures", null, value);
                OnPropertyChanged("PhoneCall_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N phonecall_campaignresponse
        /// </summary>
        [RelationshipSchemaName("phonecall_campaignresponse")]
        public IEnumerable<CampaignResponse> phonecall_campaignresponse
        {
            get { return GetRelatedEntities<CampaignResponse>("phonecall_campaignresponse", null); }
            set
            {
                OnPropertyChanging("phonecall_campaignresponse");
                SetRelatedEntities("phonecall_campaignresponse", null, value);
                OnPropertyChanged("phonecall_campaignresponse");
            }
        }

        /// <summary>
        ///     1:N phonecall_connections1
        /// </summary>
        [RelationshipSchemaName("phonecall_connections1")]
        public IEnumerable<Connection> phonecall_connections1
        {
            get { return GetRelatedEntities<Connection>("phonecall_connections1", null); }
            set
            {
                OnPropertyChanging("phonecall_connections1");
                SetRelatedEntities("phonecall_connections1", null, value);
                OnPropertyChanged("phonecall_connections1");
            }
        }

        /// <summary>
        ///     1:N phonecall_connections2
        /// </summary>
        [RelationshipSchemaName("phonecall_connections2")]
        public IEnumerable<Connection> phonecall_connections2
        {
            get { return GetRelatedEntities<Connection>("phonecall_connections2", null); }
            set
            {
                OnPropertyChanging("phonecall_connections2");
                SetRelatedEntities("phonecall_connections2", null, value);
                OnPropertyChanged("phonecall_connections2");
            }
        }

        /// <summary>
        ///     1:N PhoneCall_DuplicateBaseRecord
        /// </summary>
        [RelationshipSchemaName("PhoneCall_DuplicateBaseRecord")]
        public IEnumerable<DuplicateRecord> PhoneCall_DuplicateBaseRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("PhoneCall_DuplicateBaseRecord", null); }
            set
            {
                OnPropertyChanging("PhoneCall_DuplicateBaseRecord");
                SetRelatedEntities("PhoneCall_DuplicateBaseRecord", null, value);
                OnPropertyChanged("PhoneCall_DuplicateBaseRecord");
            }
        }

        /// <summary>
        ///     1:N PhoneCall_DuplicateMatchingRecord
        /// </summary>
        [RelationshipSchemaName("PhoneCall_DuplicateMatchingRecord")]
        public IEnumerable<DuplicateRecord> PhoneCall_DuplicateMatchingRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("PhoneCall_DuplicateMatchingRecord", null); }
            set
            {
                OnPropertyChanging("PhoneCall_DuplicateMatchingRecord");
                SetRelatedEntities("PhoneCall_DuplicateMatchingRecord", null, value);
                OnPropertyChanged("PhoneCall_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        ///     1:N phonecall_PostFollows
        /// </summary>
        [RelationshipSchemaName("phonecall_PostFollows")]
        public IEnumerable<PostFollow> phonecall_PostFollows
        {
            get { return GetRelatedEntities<PostFollow>("phonecall_PostFollows", null); }
            set
            {
                OnPropertyChanging("phonecall_PostFollows");
                SetRelatedEntities("phonecall_PostFollows", null, value);
                OnPropertyChanged("phonecall_PostFollows");
            }
        }

        /// <summary>
        ///     1:N phonecall_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("phonecall_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> phonecall_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntities<PrincipalObjectAttributeAccess>("phonecall_principalobjectattributeaccess",
                    null);
            }
            set
            {
                OnPropertyChanging("phonecall_principalobjectattributeaccess");
                SetRelatedEntities("phonecall_principalobjectattributeaccess", null, value);
                OnPropertyChanged("phonecall_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N PhoneCall_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("PhoneCall_ProcessSessions")]
        public IEnumerable<ProcessSession> PhoneCall_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("PhoneCall_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("PhoneCall_ProcessSessions");
                SetRelatedEntities("PhoneCall_ProcessSessions", null, value);
                OnPropertyChanged("PhoneCall_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N PhoneCall_QueueItem
        /// </summary>
        [RelationshipSchemaName("PhoneCall_QueueItem")]
        public IEnumerable<QueueItem> PhoneCall_QueueItem
        {
            get { return GetRelatedEntities<QueueItem>("PhoneCall_QueueItem", null); }
            set
            {
                OnPropertyChanging("PhoneCall_QueueItem");
                SetRelatedEntities("PhoneCall_QueueItem", null, value);
                OnPropertyChanged("PhoneCall_QueueItem");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_phonecall
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_phonecall")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_phonecall
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_phonecall", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_phonecall");
                SetRelatedEntities("userentityinstancedata_phonecall", null, value);
                OnPropertyChanged("userentityinstancedata_phonecall");
            }
        }

        /// <summary>
        ///     N:1 Account_Phonecalls
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Account_Phonecalls")]
        public Account Account_Phonecalls
        {
            get { return GetRelatedEntity<Account>("Account_Phonecalls", null); }
            set
            {
                OnPropertyChanging("Account_Phonecalls");
                SetRelatedEntity("Account_Phonecalls", null, value);
                OnPropertyChanged("Account_Phonecalls");
            }
        }

        /// <summary>
        ///     N:1 activity_pointer_phonecall
        /// </summary>
        [AttributeLogicalName("activityid")]
        [RelationshipSchemaName("activity_pointer_phonecall")]
        public ActivityPointer activity_pointer_phonecall
        {
            get { return GetRelatedEntity<ActivityPointer>("activity_pointer_phonecall", null); }
            set
            {
                OnPropertyChanging("activity_pointer_phonecall");
                SetRelatedEntity("activity_pointer_phonecall", null, value);
                OnPropertyChanged("activity_pointer_phonecall");
            }
        }

        /// <summary>
        ///     N:1 BulkOperation_Phonecall
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("BulkOperation_Phonecall")]
        public BulkOperation BulkOperation_Phonecall
        {
            get { return GetRelatedEntity<BulkOperation>("BulkOperation_Phonecall", null); }
            set
            {
                OnPropertyChanging("BulkOperation_Phonecall");
                SetRelatedEntity("BulkOperation_Phonecall", null, value);
                OnPropertyChanged("BulkOperation_Phonecall");
            }
        }

        /// <summary>
        ///     N:1 business_unit_phone_call_activities
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_phone_call_activities")]
        public BusinessUnit business_unit_phone_call_activities
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_phone_call_activities", null); }
        }

        /// <summary>
        ///     N:1 Campaign_Phonecalls
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Campaign_Phonecalls")]
        public Campaign Campaign_Phonecalls
        {
            get { return GetRelatedEntity<Campaign>("Campaign_Phonecalls", null); }
            set
            {
                OnPropertyChanging("Campaign_Phonecalls");
                SetRelatedEntity("Campaign_Phonecalls", null, value);
                OnPropertyChanged("Campaign_Phonecalls");
            }
        }

        /// <summary>
        ///     N:1 CampaignActivity_Phonecalls
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("CampaignActivity_Phonecalls")]
        public CampaignActivity CampaignActivity_Phonecalls
        {
            get { return GetRelatedEntity<CampaignActivity>("CampaignActivity_Phonecalls", null); }
            set
            {
                OnPropertyChanging("CampaignActivity_Phonecalls");
                SetRelatedEntity("CampaignActivity_Phonecalls", null, value);
                OnPropertyChanged("CampaignActivity_Phonecalls");
            }
        }

        /// <summary>
        ///     N:1 Contact_Phonecalls
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Contact_Phonecalls")]
        public Contact Contact_Phonecalls
        {
            get { return GetRelatedEntity<Contact>("Contact_Phonecalls", null); }
            set
            {
                OnPropertyChanging("Contact_Phonecalls");
                SetRelatedEntity("Contact_Phonecalls", null, value);
                OnPropertyChanged("Contact_Phonecalls");
            }
        }

        /// <summary>
        ///     N:1 Contract_Phonecalls
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Contract_Phonecalls")]
        public Contract Contract_Phonecalls
        {
            get { return GetRelatedEntity<Contract>("Contract_Phonecalls", null); }
            set
            {
                OnPropertyChanging("Contract_Phonecalls");
                SetRelatedEntity("Contract_Phonecalls", null, value);
                OnPropertyChanged("Contract_Phonecalls");
            }
        }

        /// <summary>
        ///     N:1 Incident_Phonecalls
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Incident_Phonecalls")]
        public Incident Incident_Phonecalls
        {
            get { return GetRelatedEntity<Incident>("Incident_Phonecalls", null); }
            set
            {
                OnPropertyChanging("Incident_Phonecalls");
                SetRelatedEntity("Incident_Phonecalls", null, value);
                OnPropertyChanged("Incident_Phonecalls");
            }
        }

        /// <summary>
        ///     N:1 Invoice_Phonecalls
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Invoice_Phonecalls")]
        public Invoice Invoice_Phonecalls
        {
            get { return GetRelatedEntity<Invoice>("Invoice_Phonecalls", null); }
            set
            {
                OnPropertyChanging("Invoice_Phonecalls");
                SetRelatedEntity("Invoice_Phonecalls", null, value);
                OnPropertyChanged("Invoice_Phonecalls");
            }
        }

        /// <summary>
        ///     N:1 Lead_Phonecalls
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Lead_Phonecalls")]
        public Lead Lead_Phonecalls
        {
            get { return GetRelatedEntity<Lead>("Lead_Phonecalls", null); }
            set
            {
                OnPropertyChanging("Lead_Phonecalls");
                SetRelatedEntity("Lead_Phonecalls", null, value);
                OnPropertyChanged("Lead_Phonecalls");
            }
        }

        /// <summary>
        ///     N:1 lk_phonecall_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_phonecall_createdby")]
        public SystemUser lk_phonecall_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_phonecall_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_phonecall_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_phonecall_createdonbehalfby")]
        public SystemUser lk_phonecall_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_phonecall_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_phonecall_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_phonecall_modifiedby")]
        public SystemUser lk_phonecall_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_phonecall_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_phonecall_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_phonecall_modifiedonbehalfby")]
        public SystemUser lk_phonecall_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_phonecall_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 msdyn_postalbum_PhoneCalls
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("msdyn_postalbum_PhoneCalls")]
        public msdyn_PostAlbum msdyn_postalbum_PhoneCalls
        {
            get { return GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_PhoneCalls", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_PhoneCalls");
                SetRelatedEntity("msdyn_postalbum_PhoneCalls", null, value);
                OnPropertyChanged("msdyn_postalbum_PhoneCalls");
            }
        }

        /// <summary>
        ///     N:1 Opportunity_Phonecalls
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Opportunity_Phonecalls")]
        public Opportunity Opportunity_Phonecalls
        {
            get { return GetRelatedEntity<Opportunity>("Opportunity_Phonecalls", null); }
            set
            {
                OnPropertyChanging("Opportunity_Phonecalls");
                SetRelatedEntity("Opportunity_Phonecalls", null, value);
                OnPropertyChanged("Opportunity_Phonecalls");
            }
        }

        /// <summary>
        ///     N:1 processstage_phonecalls
        /// </summary>
        [AttributeLogicalName("stageid")]
        [RelationshipSchemaName("processstage_phonecalls")]
        public ProcessStage processstage_phonecalls
        {
            get { return GetRelatedEntity<ProcessStage>("processstage_phonecalls", null); }
            set
            {
                OnPropertyChanging("processstage_phonecalls");
                SetRelatedEntity("processstage_phonecalls", null, value);
                OnPropertyChanged("processstage_phonecalls");
            }
        }

        /// <summary>
        ///     N:1 Quote_Phonecalls
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Quote_Phonecalls")]
        public Quote Quote_Phonecalls
        {
            get { return GetRelatedEntity<Quote>("Quote_Phonecalls", null); }
            set
            {
                OnPropertyChanging("Quote_Phonecalls");
                SetRelatedEntity("Quote_Phonecalls", null, value);
                OnPropertyChanged("Quote_Phonecalls");
            }
        }

        /// <summary>
        ///     N:1 SalesOrder_Phonecalls
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SalesOrder_Phonecalls")]
        public SalesOrder SalesOrder_Phonecalls
        {
            get { return GetRelatedEntity<SalesOrder>("SalesOrder_Phonecalls", null); }
            set
            {
                OnPropertyChanging("SalesOrder_Phonecalls");
                SetRelatedEntity("SalesOrder_Phonecalls", null, value);
                OnPropertyChanged("SalesOrder_Phonecalls");
            }
        }

        /// <summary>
        ///     N:1 service_phonecalls
        /// </summary>
        [AttributeLogicalName("serviceid")]
        [RelationshipSchemaName("service_phonecalls")]
        public Service service_phonecalls
        {
            get { return GetRelatedEntity<Service>("service_phonecalls", null); }
            set
            {
                OnPropertyChanging("service_phonecalls");
                SetRelatedEntity("service_phonecalls", null, value);
                OnPropertyChanged("service_phonecalls");
            }
        }

        /// <summary>
        ///     N:1 team_phonecall
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_phonecall")]
        public Team team_phonecall
        {
            get { return GetRelatedEntity<Team>("team_phonecall", null); }
        }

        /// <summary>
        ///     N:1 TransactionCurrency_PhoneCall
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("TransactionCurrency_PhoneCall")]
        public TransactionCurrency TransactionCurrency_PhoneCall
        {
            get { return GetRelatedEntity<TransactionCurrency>("TransactionCurrency_PhoneCall", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_PhoneCall");
                SetRelatedEntity("TransactionCurrency_PhoneCall", null, value);
                OnPropertyChanged("TransactionCurrency_PhoneCall");
            }
        }

        /// <summary>
        ///     N:1 user_phonecall
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_phonecall")]
        public SystemUser user_phonecall
        {
            get { return GetRelatedEntity<SystemUser>("user_phonecall", null); }
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