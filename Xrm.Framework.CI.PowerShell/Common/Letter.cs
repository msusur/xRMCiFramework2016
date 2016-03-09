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
    ///     Activity that tracks the delivery of a letter. The activity can contain the electronic copy of the letter.
    /// </summary>
    [DataContract]
    [EntityLogicalName("letter")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Letter : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "letter";

        public const int EntityTypeCode = 4207;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Letter() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the letter activity.
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
        ///     Type the number of minutes spent creating and sending the letter. The duration is used in reporting.
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
        ///     Enter the actual end date and time of the letter. By default, it displays the date and time when the activity was
        ///     completed or canceled, but can be edited to capture the actual time to create and send the letter.
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
        ///     Enter the actual start date and time for the letter. By default, it displays the date and time when the activity
        ///     was created, but can be edited to capture the actual time to create and send the letter.
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
        ///     Type the complete recipient address for the letter to ensure timely delivery.
        /// </summary>
        [AttributeLogicalName("address")]
        public string Address
        {
            get { return GetAttributeValue<string>("address"); }
            set
            {
                OnPropertyChanging("Address");
                SetAttributeValue("address", value);
                OnPropertyChanged("Address");
            }
        }

        /// <summary>
        ///     Enter the recipients that are included in the letter distribution, but are not displayed to other recipients.
        /// </summary>
        [AttributeLogicalName("bcc")]
        public IEnumerable<ActivityParty> Bcc
        {
            get
            {
                var collection = GetAttributeValue<EntityCollection>("bcc");
                if (((collection != null)
                     && (collection.Entities != null)))
                {
                    return Enumerable.Cast<ActivityParty>(collection.Entities);
                }
                return null;
            }
            set
            {
                OnPropertyChanging("Bcc");
                if ((value == null))
                {
                    SetAttributeValue("bcc", value);
                }
                else
                {
                    SetAttributeValue("bcc", new EntityCollection(new List<Entity>(value)));
                }
                OnPropertyChanged("Bcc");
            }
        }

        /// <summary>
        ///     Type a category to identify the letter type, such as sales offer or past due notice, to tie the letter to a
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
        ///     Enter the recipients that should be copied on the letter.
        /// </summary>
        [AttributeLogicalName("cc")]
        public IEnumerable<ActivityParty> Cc
        {
            get
            {
                var collection = GetAttributeValue<EntityCollection>("cc");
                if (((collection != null)
                     && (collection.Entities != null)))
                {
                    return Enumerable.Cast<ActivityParty>(collection.Entities);
                }
                return null;
            }
            set
            {
                OnPropertyChanging("Cc");
                if ((value == null))
                {
                    SetAttributeValue("cc", value);
                }
                else
                {
                    SetAttributeValue("cc", new EntityCollection(new List<Entity>(value)));
                }
                OnPropertyChanged("Cc");
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
        ///     Type the letter body or additional information to describe the letter, such as the primary message or the products
        ///     and services described.
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
        ///     Select the direction of the letter as incoming or outbound.
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
        ///     Enter the account, contact, lead, or user who sent the letter.
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
        ///     Shows whether the letter activity was billed as part of resolving a case.
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
        ///     Shows whether the activity is a regular activity type or event type.
        /// </summary>
        [AttributeLogicalName("isregularactivity")]
        public bool? IsRegularActivity
        {
            get { return GetAttributeValue<bool?>("isregularactivity"); }
        }

        /// <summary>
        ///     Shows whether the letter activity was created by a workflow rule.
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
        ///     Unique identifier of the business unit that owns the letter activity.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team that owns the letter activity.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user that owns the letter activity.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
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
        ///     Unique identifier of the object with which the letter activity is associated.
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
        ///     Scheduled duration of the letter activity, specified in minutes.
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
        ///     Shows whether the letter is open, completed, or canceled. Completed and canceled letters are read-only and can't be
        ///     edited.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public LetterState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((LetterState) (Enum.ToObject(typeof (LetterState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Select the letter's status.
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
        ///     Type a subcategory to identify the letter type and relate the activity to a specific product, sales region,
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
        ///     Type a short description about the objective or primary topic of the letter.
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
        ///     Enter the account, contact, lead, or user recipients for the letter.
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
        ///     Version number of the letter.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N letter_activity_parties
        /// </summary>
        [RelationshipSchemaName("letter_activity_parties")]
        public IEnumerable<ActivityParty> letter_activity_parties
        {
            get { return GetRelatedEntities<ActivityParty>("letter_activity_parties", null); }
            set
            {
                OnPropertyChanging("letter_activity_parties");
                SetRelatedEntities("letter_activity_parties", null, value);
                OnPropertyChanged("letter_activity_parties");
            }
        }

        /// <summary>
        ///     1:N Letter_Annotation
        /// </summary>
        [RelationshipSchemaName("Letter_Annotation")]
        public IEnumerable<Annotation> Letter_Annotation
        {
            get { return GetRelatedEntities<Annotation>("Letter_Annotation", null); }
            set
            {
                OnPropertyChanging("Letter_Annotation");
                SetRelatedEntities("Letter_Annotation", null, value);
                OnPropertyChanged("Letter_Annotation");
            }
        }

        /// <summary>
        ///     1:N Letter_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Letter_AsyncOperations")]
        public IEnumerable<AsyncOperation> Letter_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Letter_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Letter_AsyncOperations");
                SetRelatedEntities("Letter_AsyncOperations", null, value);
                OnPropertyChanged("Letter_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N Letter_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("Letter_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> Letter_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("Letter_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("Letter_BulkDeleteFailures");
                SetRelatedEntities("Letter_BulkDeleteFailures", null, value);
                OnPropertyChanged("Letter_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N letter_campaignresponse
        /// </summary>
        [RelationshipSchemaName("letter_campaignresponse")]
        public IEnumerable<CampaignResponse> letter_campaignresponse
        {
            get { return GetRelatedEntities<CampaignResponse>("letter_campaignresponse", null); }
            set
            {
                OnPropertyChanging("letter_campaignresponse");
                SetRelatedEntities("letter_campaignresponse", null, value);
                OnPropertyChanged("letter_campaignresponse");
            }
        }

        /// <summary>
        ///     1:N letter_connections1
        /// </summary>
        [RelationshipSchemaName("letter_connections1")]
        public IEnumerable<Connection> letter_connections1
        {
            get { return GetRelatedEntities<Connection>("letter_connections1", null); }
            set
            {
                OnPropertyChanging("letter_connections1");
                SetRelatedEntities("letter_connections1", null, value);
                OnPropertyChanged("letter_connections1");
            }
        }

        /// <summary>
        ///     1:N letter_connections2
        /// </summary>
        [RelationshipSchemaName("letter_connections2")]
        public IEnumerable<Connection> letter_connections2
        {
            get { return GetRelatedEntities<Connection>("letter_connections2", null); }
            set
            {
                OnPropertyChanging("letter_connections2");
                SetRelatedEntities("letter_connections2", null, value);
                OnPropertyChanged("letter_connections2");
            }
        }

        /// <summary>
        ///     1:N Letter_DuplicateBaseRecord
        /// </summary>
        [RelationshipSchemaName("Letter_DuplicateBaseRecord")]
        public IEnumerable<DuplicateRecord> Letter_DuplicateBaseRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Letter_DuplicateBaseRecord", null); }
            set
            {
                OnPropertyChanging("Letter_DuplicateBaseRecord");
                SetRelatedEntities("Letter_DuplicateBaseRecord", null, value);
                OnPropertyChanged("Letter_DuplicateBaseRecord");
            }
        }

        /// <summary>
        ///     1:N Letter_DuplicateMatchingRecord
        /// </summary>
        [RelationshipSchemaName("Letter_DuplicateMatchingRecord")]
        public IEnumerable<DuplicateRecord> Letter_DuplicateMatchingRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Letter_DuplicateMatchingRecord", null); }
            set
            {
                OnPropertyChanging("Letter_DuplicateMatchingRecord");
                SetRelatedEntities("Letter_DuplicateMatchingRecord", null, value);
                OnPropertyChanged("Letter_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        ///     1:N letter_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("letter_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> letter_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntities<PrincipalObjectAttributeAccess>("letter_principalobjectattributeaccess", null);
            }
            set
            {
                OnPropertyChanging("letter_principalobjectattributeaccess");
                SetRelatedEntities("letter_principalobjectattributeaccess", null, value);
                OnPropertyChanged("letter_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N Letter_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("Letter_ProcessSessions")]
        public IEnumerable<ProcessSession> Letter_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("Letter_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Letter_ProcessSessions");
                SetRelatedEntities("Letter_ProcessSessions", null, value);
                OnPropertyChanged("Letter_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N Letter_QueueItem
        /// </summary>
        [RelationshipSchemaName("Letter_QueueItem")]
        public IEnumerable<QueueItem> Letter_QueueItem
        {
            get { return GetRelatedEntities<QueueItem>("Letter_QueueItem", null); }
            set
            {
                OnPropertyChanging("Letter_QueueItem");
                SetRelatedEntities("Letter_QueueItem", null, value);
                OnPropertyChanged("Letter_QueueItem");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_letter
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_letter")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_letter
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_letter", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_letter");
                SetRelatedEntities("userentityinstancedata_letter", null, value);
                OnPropertyChanged("userentityinstancedata_letter");
            }
        }

        /// <summary>
        ///     N:1 Account_Letters
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Account_Letters")]
        public Account Account_Letters
        {
            get { return GetRelatedEntity<Account>("Account_Letters", null); }
            set
            {
                OnPropertyChanging("Account_Letters");
                SetRelatedEntity("Account_Letters", null, value);
                OnPropertyChanged("Account_Letters");
            }
        }

        /// <summary>
        ///     N:1 activity_pointer_letter
        /// </summary>
        [AttributeLogicalName("activityid")]
        [RelationshipSchemaName("activity_pointer_letter")]
        public ActivityPointer activity_pointer_letter
        {
            get { return GetRelatedEntity<ActivityPointer>("activity_pointer_letter", null); }
            set
            {
                OnPropertyChanging("activity_pointer_letter");
                SetRelatedEntity("activity_pointer_letter", null, value);
                OnPropertyChanged("activity_pointer_letter");
            }
        }

        /// <summary>
        ///     N:1 BulkOperation_Letter
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("BulkOperation_Letter")]
        public BulkOperation BulkOperation_Letter
        {
            get { return GetRelatedEntity<BulkOperation>("BulkOperation_Letter", null); }
            set
            {
                OnPropertyChanging("BulkOperation_Letter");
                SetRelatedEntity("BulkOperation_Letter", null, value);
                OnPropertyChanged("BulkOperation_Letter");
            }
        }

        /// <summary>
        ///     N:1 business_unit_letter_activities
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_letter_activities")]
        public BusinessUnit business_unit_letter_activities
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_letter_activities", null); }
        }

        /// <summary>
        ///     N:1 Campaign_Letters
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Campaign_Letters")]
        public Campaign Campaign_Letters
        {
            get { return GetRelatedEntity<Campaign>("Campaign_Letters", null); }
            set
            {
                OnPropertyChanging("Campaign_Letters");
                SetRelatedEntity("Campaign_Letters", null, value);
                OnPropertyChanged("Campaign_Letters");
            }
        }

        /// <summary>
        ///     N:1 CampaignActivity_Letters
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("CampaignActivity_Letters")]
        public CampaignActivity CampaignActivity_Letters
        {
            get { return GetRelatedEntity<CampaignActivity>("CampaignActivity_Letters", null); }
            set
            {
                OnPropertyChanging("CampaignActivity_Letters");
                SetRelatedEntity("CampaignActivity_Letters", null, value);
                OnPropertyChanged("CampaignActivity_Letters");
            }
        }

        /// <summary>
        ///     N:1 Contact_Letters
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Contact_Letters")]
        public Contact Contact_Letters
        {
            get { return GetRelatedEntity<Contact>("Contact_Letters", null); }
            set
            {
                OnPropertyChanging("Contact_Letters");
                SetRelatedEntity("Contact_Letters", null, value);
                OnPropertyChanged("Contact_Letters");
            }
        }

        /// <summary>
        ///     N:1 Contract_Letters
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Contract_Letters")]
        public Contract Contract_Letters
        {
            get { return GetRelatedEntity<Contract>("Contract_Letters", null); }
            set
            {
                OnPropertyChanging("Contract_Letters");
                SetRelatedEntity("Contract_Letters", null, value);
                OnPropertyChanged("Contract_Letters");
            }
        }

        /// <summary>
        ///     N:1 Incident_Letters
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Incident_Letters")]
        public Incident Incident_Letters
        {
            get { return GetRelatedEntity<Incident>("Incident_Letters", null); }
            set
            {
                OnPropertyChanging("Incident_Letters");
                SetRelatedEntity("Incident_Letters", null, value);
                OnPropertyChanged("Incident_Letters");
            }
        }

        /// <summary>
        ///     N:1 Invoice_Letters
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Invoice_Letters")]
        public Invoice Invoice_Letters
        {
            get { return GetRelatedEntity<Invoice>("Invoice_Letters", null); }
            set
            {
                OnPropertyChanging("Invoice_Letters");
                SetRelatedEntity("Invoice_Letters", null, value);
                OnPropertyChanged("Invoice_Letters");
            }
        }

        /// <summary>
        ///     N:1 Lead_Letters
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Lead_Letters")]
        public Lead Lead_Letters
        {
            get { return GetRelatedEntity<Lead>("Lead_Letters", null); }
            set
            {
                OnPropertyChanging("Lead_Letters");
                SetRelatedEntity("Lead_Letters", null, value);
                OnPropertyChanged("Lead_Letters");
            }
        }

        /// <summary>
        ///     N:1 lk_letter_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_letter_createdby")]
        public SystemUser lk_letter_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_letter_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_letter_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_letter_createdonbehalfby")]
        public SystemUser lk_letter_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_letter_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_letter_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_letter_modifiedby")]
        public SystemUser lk_letter_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_letter_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_letter_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_letter_modifiedonbehalfby")]
        public SystemUser lk_letter_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_letter_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 msdyn_postalbum_Letters
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("msdyn_postalbum_Letters")]
        public msdyn_PostAlbum msdyn_postalbum_Letters
        {
            get { return GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_Letters", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_Letters");
                SetRelatedEntity("msdyn_postalbum_Letters", null, value);
                OnPropertyChanged("msdyn_postalbum_Letters");
            }
        }

        /// <summary>
        ///     N:1 Opportunity_Letters
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Opportunity_Letters")]
        public Opportunity Opportunity_Letters
        {
            get { return GetRelatedEntity<Opportunity>("Opportunity_Letters", null); }
            set
            {
                OnPropertyChanging("Opportunity_Letters");
                SetRelatedEntity("Opportunity_Letters", null, value);
                OnPropertyChanged("Opportunity_Letters");
            }
        }

        /// <summary>
        ///     N:1 processstage_letters
        /// </summary>
        [AttributeLogicalName("stageid")]
        [RelationshipSchemaName("processstage_letters")]
        public ProcessStage processstage_letters
        {
            get { return GetRelatedEntity<ProcessStage>("processstage_letters", null); }
            set
            {
                OnPropertyChanging("processstage_letters");
                SetRelatedEntity("processstage_letters", null, value);
                OnPropertyChanged("processstage_letters");
            }
        }

        /// <summary>
        ///     N:1 Quote_Letters
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Quote_Letters")]
        public Quote Quote_Letters
        {
            get { return GetRelatedEntity<Quote>("Quote_Letters", null); }
            set
            {
                OnPropertyChanging("Quote_Letters");
                SetRelatedEntity("Quote_Letters", null, value);
                OnPropertyChanged("Quote_Letters");
            }
        }

        /// <summary>
        ///     N:1 SalesOrder_Letters
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SalesOrder_Letters")]
        public SalesOrder SalesOrder_Letters
        {
            get { return GetRelatedEntity<SalesOrder>("SalesOrder_Letters", null); }
            set
            {
                OnPropertyChanging("SalesOrder_Letters");
                SetRelatedEntity("SalesOrder_Letters", null, value);
                OnPropertyChanged("SalesOrder_Letters");
            }
        }

        /// <summary>
        ///     N:1 service_letters
        /// </summary>
        [AttributeLogicalName("serviceid")]
        [RelationshipSchemaName("service_letters")]
        public Service service_letters
        {
            get { return GetRelatedEntity<Service>("service_letters", null); }
            set
            {
                OnPropertyChanging("service_letters");
                SetRelatedEntity("service_letters", null, value);
                OnPropertyChanged("service_letters");
            }
        }

        /// <summary>
        ///     N:1 team_letter
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_letter")]
        public Team team_letter
        {
            get { return GetRelatedEntity<Team>("team_letter", null); }
        }

        /// <summary>
        ///     N:1 TransactionCurrency_Letter
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("TransactionCurrency_Letter")]
        public TransactionCurrency TransactionCurrency_Letter
        {
            get { return GetRelatedEntity<TransactionCurrency>("TransactionCurrency_Letter", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_Letter");
                SetRelatedEntity("TransactionCurrency_Letter", null, value);
                OnPropertyChanged("TransactionCurrency_Letter");
            }
        }

        /// <summary>
        ///     N:1 user_letter
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_letter")]
        public SystemUser user_letter
        {
            get { return GetRelatedEntity<SystemUser>("user_letter", null); }
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