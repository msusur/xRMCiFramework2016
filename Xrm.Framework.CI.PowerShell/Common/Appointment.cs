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
    ///     Commitment representing a time interval with start/end times and duration.
    /// </summary>
    [DataContract]
    [EntityLogicalName("appointment")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Appointment : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "appointment";

        public const int EntityTypeCode = 4201;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Appointment() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the appointment.
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
        ///     Shows the value selected in the Duration field on the appointment at the time that the appointment is closed as
        ///     completed. The duration is used to report the time spent on the activity.
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
        ///     Enter the actual end date and time of the appointment. By default, it displays the date and time when the activity
        ///     was completed or canceled, but can be edited to capture the actual duration of the appointment.
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
        ///     Enter the actual start date and time for the appointment. By default, it displays the date and time when the
        ///     activity was created, but can be edited to capture the actual duration of the appointment.
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
        ///     Type a category to identify the appointment type, such as sales demo, prospect call, or service call, to tie the
        ///     appointment to a business group or function.
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
        ///     Type additional information to describe the purpose of the appointment.
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
        ///     Shows the ID of the appointment in Microsoft Office Outlook. The ID is used to synchronize the appointment between
        ///     Microsoft Dynamics CRM and the correct Exchange account.
        /// </summary>
        [AttributeLogicalName("globalobjectid")]
        public string GlobalObjectId
        {
            get { return GetAttributeValue<string>("globalobjectid"); }
            set
            {
                OnPropertyChanging("GlobalObjectId");
                SetAttributeValue("globalobjectid", value);
                OnPropertyChanged("GlobalObjectId");
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
        ///     Type of instance of a recurring series.
        /// </summary>
        [AttributeLogicalName("instancetypecode")]
        public OptionSetValue InstanceTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("instancetypecode"); }
        }

        /// <summary>
        ///     Select whether the appointment is an all-day event to make sure that the required resources are scheduled for the
        ///     full day.
        /// </summary>
        [AttributeLogicalName("isalldayevent")]
        public bool? IsAllDayEvent
        {
            get { return GetAttributeValue<bool?>("isalldayevent"); }
            set
            {
                OnPropertyChanging("IsAllDayEvent");
                SetAttributeValue("isalldayevent", value);
                OnPropertyChanged("IsAllDayEvent");
            }
        }

        /// <summary>
        ///     Information regarding whether the appointment was billed as part of resolving a case.
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
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("ismapiprivate")]
        public bool? IsMapiPrivate
        {
            get { return GetAttributeValue<bool?>("ismapiprivate"); }
            set
            {
                OnPropertyChanging("IsMapiPrivate");
                SetAttributeValue("ismapiprivate", value);
                OnPropertyChanged("IsMapiPrivate");
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
        ///     Information regarding whether the appointment was created from a workflow rule.
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
        ///     Type the location where the appointment will take place, such as a conference room or customer office.
        /// </summary>
        [AttributeLogicalName("location")]
        public string Location
        {
            get { return GetAttributeValue<string>("location"); }
            set
            {
                OnPropertyChanging("Location");
                SetAttributeValue("location", value);
                OnPropertyChanged("Location");
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
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("modifiedfieldsmask")]
        public string ModifiedFieldsMask
        {
            get { return GetAttributeValue<string>("modifiedfieldsmask"); }
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
        ///     Shows who created the record on behalf of another user.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Enter the account, contact, lead, user, or other equipment resources that are not needed at the appointment, but
        ///     can optionally attend.
        /// </summary>
        [AttributeLogicalName("optionalattendees")]
        public IEnumerable<ActivityParty> OptionalAttendees
        {
            get
            {
                var collection = GetAttributeValue<EntityCollection>("optionalattendees");
                if (((collection != null)
                     && (collection.Entities != null)))
                {
                    return Enumerable.Cast<ActivityParty>(collection.Entities);
                }
                return null;
            }
            set
            {
                OnPropertyChanging("OptionalAttendees");
                if ((value == null))
                {
                    SetAttributeValue("optionalattendees", value);
                }
                else
                {
                    SetAttributeValue("optionalattendees", new EntityCollection(new List<Entity>(value)));
                }
                OnPropertyChanged("OptionalAttendees");
            }
        }

        /// <summary>
        ///     Enter the user who is in charge of coordinating or leading the appointment to make sure the appointment is
        ///     displayed in the user's My Activities view.
        /// </summary>
        [AttributeLogicalName("organizer")]
        public IEnumerable<ActivityParty> Organizer
        {
            get
            {
                var collection = GetAttributeValue<EntityCollection>("organizer");
                if (((collection != null)
                     && (collection.Entities != null)))
                {
                    return Enumerable.Cast<ActivityParty>(collection.Entities);
                }
                return null;
            }
            set
            {
                OnPropertyChanging("Organizer");
                if ((value == null))
                {
                    SetAttributeValue("organizer", value);
                }
                else
                {
                    SetAttributeValue("organizer", new EntityCollection(new List<Entity>(value)));
                }
                OnPropertyChanged("Organizer");
            }
        }

        /// <summary>
        ///     The original start date of the appointment.
        /// </summary>
        [AttributeLogicalName("originalstartdate")]
        public DateTime? OriginalStartDate
        {
            get { return GetAttributeValue<DateTime?>("originalstartdate"); }
        }

        /// <summary>
        ///     Unique identifier of the Microsoft Office Outlook appointment owner that correlates to the PR_OWNER_APPT_ID MAPI
        ///     property.
        /// </summary>
        [AttributeLogicalName("outlookownerapptid")]
        public int? OutlookOwnerApptId
        {
            get { return GetAttributeValue<int?>("outlookownerapptid"); }
            set
            {
                OnPropertyChanging("OutlookOwnerApptId");
                SetAttributeValue("outlookownerapptid", value);
                OnPropertyChanged("OutlookOwnerApptId");
            }
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
        ///     Shows the business unit that the record owner belongs to.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team that owns the appointment.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user that owns the appointment.
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
        ///     Unique identifier of the object with which the appointment is associated.
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
        ///     Enter the account, contact, lead, user, or other equipment resources that are required to attend the appointment.
        /// </summary>
        [AttributeLogicalName("requiredattendees")]
        public IEnumerable<ActivityParty> RequiredAttendees
        {
            get
            {
                var collection = GetAttributeValue<EntityCollection>("requiredattendees");
                if (((collection != null)
                     && (collection.Entities != null)))
                {
                    return Enumerable.Cast<ActivityParty>(collection.Entities);
                }
                return null;
            }
            set
            {
                OnPropertyChanging("RequiredAttendees");
                if ((value == null))
                {
                    SetAttributeValue("requiredattendees", value);
                }
                else
                {
                    SetAttributeValue("requiredattendees", new EntityCollection(new List<Entity>(value)));
                }
                OnPropertyChanged("RequiredAttendees");
            }
        }

        /// <summary>
        ///     Shows the expected duration of the appointment, in minutes.
        /// </summary>
        [AttributeLogicalName("scheduleddurationminutes")]
        public int? ScheduledDurationMinutes
        {
            get { return GetAttributeValue<int?>("scheduleddurationminutes"); }
            set
            {
                OnPropertyChanging("ScheduledDurationMinutes");
                SetAttributeValue("scheduleddurationminutes", value);
                OnPropertyChanged("ScheduledDurationMinutes");
            }
        }

        /// <summary>
        ///     Enter the expected due date and time for the activity to be completed to provide details about the timing of the
        ///     appointment.
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
        ///     Enter the expected start date and time for the activity to provide details about the timing of the appointment.
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
        ///     Shows the ID of the recurring series of an instance.
        /// </summary>
        [AttributeLogicalName("seriesid")]
        public Guid? SeriesId
        {
            get { return GetAttributeValue<Guid?>("seriesid"); }
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
        ///     Shows whether the appointment is open, completed, or canceled. Completed and canceled appointments are read-only
        ///     and can't be edited.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public AppointmentState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((AppointmentState) (Enum.ToObject(typeof (AppointmentState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Select the appointment's status.
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
        ///     Type a subcategory to identify the appointment type and relate the activity to a specific product, sales region,
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
        ///     Type a short description about the objective or primary topic of the appointment.
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
        ///     Version number of the appointment.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N appointment_activity_parties
        /// </summary>
        [RelationshipSchemaName("appointment_activity_parties")]
        public IEnumerable<ActivityParty> appointment_activity_parties
        {
            get { return GetRelatedEntities<ActivityParty>("appointment_activity_parties", null); }
            set
            {
                OnPropertyChanging("appointment_activity_parties");
                SetRelatedEntities("appointment_activity_parties", null, value);
                OnPropertyChanged("appointment_activity_parties");
            }
        }

        /// <summary>
        ///     1:N Appointment_Annotation
        /// </summary>
        [RelationshipSchemaName("Appointment_Annotation")]
        public IEnumerable<Annotation> Appointment_Annotation
        {
            get { return GetRelatedEntities<Annotation>("Appointment_Annotation", null); }
            set
            {
                OnPropertyChanging("Appointment_Annotation");
                SetRelatedEntities("Appointment_Annotation", null, value);
                OnPropertyChanged("Appointment_Annotation");
            }
        }

        /// <summary>
        ///     1:N Appointment_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Appointment_AsyncOperations")]
        public IEnumerable<AsyncOperation> Appointment_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Appointment_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Appointment_AsyncOperations");
                SetRelatedEntities("Appointment_AsyncOperations", null, value);
                OnPropertyChanged("Appointment_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N Appointment_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("Appointment_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> Appointment_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("Appointment_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("Appointment_BulkDeleteFailures");
                SetRelatedEntities("Appointment_BulkDeleteFailures", null, value);
                OnPropertyChanged("Appointment_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N appointment_campaignresponse
        /// </summary>
        [RelationshipSchemaName("appointment_campaignresponse")]
        public IEnumerable<CampaignResponse> appointment_campaignresponse
        {
            get { return GetRelatedEntities<CampaignResponse>("appointment_campaignresponse", null); }
            set
            {
                OnPropertyChanging("appointment_campaignresponse");
                SetRelatedEntities("appointment_campaignresponse", null, value);
                OnPropertyChanged("appointment_campaignresponse");
            }
        }

        /// <summary>
        ///     1:N appointment_connections1
        /// </summary>
        [RelationshipSchemaName("appointment_connections1")]
        public IEnumerable<Connection> appointment_connections1
        {
            get { return GetRelatedEntities<Connection>("appointment_connections1", null); }
            set
            {
                OnPropertyChanging("appointment_connections1");
                SetRelatedEntities("appointment_connections1", null, value);
                OnPropertyChanged("appointment_connections1");
            }
        }

        /// <summary>
        ///     1:N appointment_connections2
        /// </summary>
        [RelationshipSchemaName("appointment_connections2")]
        public IEnumerable<Connection> appointment_connections2
        {
            get { return GetRelatedEntities<Connection>("appointment_connections2", null); }
            set
            {
                OnPropertyChanging("appointment_connections2");
                SetRelatedEntities("appointment_connections2", null, value);
                OnPropertyChanged("appointment_connections2");
            }
        }

        /// <summary>
        ///     1:N Appointment_DuplicateBaseRecord
        /// </summary>
        [RelationshipSchemaName("Appointment_DuplicateBaseRecord")]
        public IEnumerable<DuplicateRecord> Appointment_DuplicateBaseRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Appointment_DuplicateBaseRecord", null); }
            set
            {
                OnPropertyChanging("Appointment_DuplicateBaseRecord");
                SetRelatedEntities("Appointment_DuplicateBaseRecord", null, value);
                OnPropertyChanged("Appointment_DuplicateBaseRecord");
            }
        }

        /// <summary>
        ///     1:N Appointment_DuplicateMatchingRecord
        /// </summary>
        [RelationshipSchemaName("Appointment_DuplicateMatchingRecord")]
        public IEnumerable<DuplicateRecord> Appointment_DuplicateMatchingRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Appointment_DuplicateMatchingRecord", null); }
            set
            {
                OnPropertyChanging("Appointment_DuplicateMatchingRecord");
                SetRelatedEntities("Appointment_DuplicateMatchingRecord", null, value);
                OnPropertyChanged("Appointment_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        ///     1:N appointment_PostFollows
        /// </summary>
        [RelationshipSchemaName("appointment_PostFollows")]
        public IEnumerable<PostFollow> appointment_PostFollows
        {
            get { return GetRelatedEntities<PostFollow>("appointment_PostFollows", null); }
            set
            {
                OnPropertyChanging("appointment_PostFollows");
                SetRelatedEntities("appointment_PostFollows", null, value);
                OnPropertyChanged("appointment_PostFollows");
            }
        }

        /// <summary>
        ///     1:N appointment_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("appointment_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> appointment_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntities<PrincipalObjectAttributeAccess>("appointment_principalobjectattributeaccess",
                    null);
            }
            set
            {
                OnPropertyChanging("appointment_principalobjectattributeaccess");
                SetRelatedEntities("appointment_principalobjectattributeaccess", null, value);
                OnPropertyChanged("appointment_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N Appointment_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("Appointment_ProcessSessions")]
        public IEnumerable<ProcessSession> Appointment_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("Appointment_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Appointment_ProcessSessions");
                SetRelatedEntities("Appointment_ProcessSessions", null, value);
                OnPropertyChanged("Appointment_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N Appointment_QueueItem
        /// </summary>
        [RelationshipSchemaName("Appointment_QueueItem")]
        public IEnumerable<QueueItem> Appointment_QueueItem
        {
            get { return GetRelatedEntities<QueueItem>("Appointment_QueueItem", null); }
            set
            {
                OnPropertyChanging("Appointment_QueueItem");
                SetRelatedEntities("Appointment_QueueItem", null, value);
                OnPropertyChanged("Appointment_QueueItem");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_appointment
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_appointment")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_appointment
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_appointment", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_appointment");
                SetRelatedEntities("userentityinstancedata_appointment", null, value);
                OnPropertyChanged("userentityinstancedata_appointment");
            }
        }

        /// <summary>
        ///     N:1 Account_Appointments
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Account_Appointments")]
        public Account Account_Appointments
        {
            get { return GetRelatedEntity<Account>("Account_Appointments", null); }
            set
            {
                OnPropertyChanging("Account_Appointments");
                SetRelatedEntity("Account_Appointments", null, value);
                OnPropertyChanged("Account_Appointments");
            }
        }

        /// <summary>
        ///     N:1 activity_pointer_appointment
        /// </summary>
        [AttributeLogicalName("activityid")]
        [RelationshipSchemaName("activity_pointer_appointment")]
        public ActivityPointer activity_pointer_appointment
        {
            get { return GetRelatedEntity<ActivityPointer>("activity_pointer_appointment", null); }
            set
            {
                OnPropertyChanging("activity_pointer_appointment");
                SetRelatedEntity("activity_pointer_appointment", null, value);
                OnPropertyChanged("activity_pointer_appointment");
            }
        }

        /// <summary>
        ///     N:1 BulkOperation_Appointment
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("BulkOperation_Appointment")]
        public BulkOperation BulkOperation_Appointment
        {
            get { return GetRelatedEntity<BulkOperation>("BulkOperation_Appointment", null); }
            set
            {
                OnPropertyChanging("BulkOperation_Appointment");
                SetRelatedEntity("BulkOperation_Appointment", null, value);
                OnPropertyChanged("BulkOperation_Appointment");
            }
        }

        /// <summary>
        ///     N:1 business_unit_appointment_activities
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_appointment_activities")]
        public BusinessUnit business_unit_appointment_activities
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_appointment_activities", null); }
        }

        /// <summary>
        ///     N:1 Campaign_Appointments
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Campaign_Appointments")]
        public Campaign Campaign_Appointments
        {
            get { return GetRelatedEntity<Campaign>("Campaign_Appointments", null); }
            set
            {
                OnPropertyChanging("Campaign_Appointments");
                SetRelatedEntity("Campaign_Appointments", null, value);
                OnPropertyChanged("Campaign_Appointments");
            }
        }

        /// <summary>
        ///     N:1 CampaignActivity_Appointments
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("CampaignActivity_Appointments")]
        public CampaignActivity CampaignActivity_Appointments
        {
            get { return GetRelatedEntity<CampaignActivity>("CampaignActivity_Appointments", null); }
            set
            {
                OnPropertyChanging("CampaignActivity_Appointments");
                SetRelatedEntity("CampaignActivity_Appointments", null, value);
                OnPropertyChanged("CampaignActivity_Appointments");
            }
        }

        /// <summary>
        ///     N:1 Contact_Appointments
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Contact_Appointments")]
        public Contact Contact_Appointments
        {
            get { return GetRelatedEntity<Contact>("Contact_Appointments", null); }
            set
            {
                OnPropertyChanging("Contact_Appointments");
                SetRelatedEntity("Contact_Appointments", null, value);
                OnPropertyChanged("Contact_Appointments");
            }
        }

        /// <summary>
        ///     N:1 Contract_Appointments
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Contract_Appointments")]
        public Contract Contract_Appointments
        {
            get { return GetRelatedEntity<Contract>("Contract_Appointments", null); }
            set
            {
                OnPropertyChanging("Contract_Appointments");
                SetRelatedEntity("Contract_Appointments", null, value);
                OnPropertyChanged("Contract_Appointments");
            }
        }

        /// <summary>
        ///     N:1 Incident_Appointments
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Incident_Appointments")]
        public Incident Incident_Appointments
        {
            get { return GetRelatedEntity<Incident>("Incident_Appointments", null); }
            set
            {
                OnPropertyChanging("Incident_Appointments");
                SetRelatedEntity("Incident_Appointments", null, value);
                OnPropertyChanged("Incident_Appointments");
            }
        }

        /// <summary>
        ///     N:1 Invoice_Appointments
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Invoice_Appointments")]
        public Invoice Invoice_Appointments
        {
            get { return GetRelatedEntity<Invoice>("Invoice_Appointments", null); }
            set
            {
                OnPropertyChanging("Invoice_Appointments");
                SetRelatedEntity("Invoice_Appointments", null, value);
                OnPropertyChanged("Invoice_Appointments");
            }
        }

        /// <summary>
        ///     N:1 Lead_Appointments
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Lead_Appointments")]
        public Lead Lead_Appointments
        {
            get { return GetRelatedEntity<Lead>("Lead_Appointments", null); }
            set
            {
                OnPropertyChanging("Lead_Appointments");
                SetRelatedEntity("Lead_Appointments", null, value);
                OnPropertyChanged("Lead_Appointments");
            }
        }

        /// <summary>
        ///     N:1 lk_appointment_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_appointment_createdby")]
        public SystemUser lk_appointment_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_appointment_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_appointment_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_appointment_createdonbehalfby")]
        public SystemUser lk_appointment_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_appointment_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_appointment_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_appointment_modifiedby")]
        public SystemUser lk_appointment_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_appointment_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_appointment_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_appointment_modifiedonbehalfby")]
        public SystemUser lk_appointment_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_appointment_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 msdyn_postalbum_Appointments
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("msdyn_postalbum_Appointments")]
        public msdyn_PostAlbum msdyn_postalbum_Appointments
        {
            get { return GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_Appointments", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_Appointments");
                SetRelatedEntity("msdyn_postalbum_Appointments", null, value);
                OnPropertyChanged("msdyn_postalbum_Appointments");
            }
        }

        /// <summary>
        ///     N:1 Opportunity_Appointments
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Opportunity_Appointments")]
        public Opportunity Opportunity_Appointments
        {
            get { return GetRelatedEntity<Opportunity>("Opportunity_Appointments", null); }
            set
            {
                OnPropertyChanging("Opportunity_Appointments");
                SetRelatedEntity("Opportunity_Appointments", null, value);
                OnPropertyChanged("Opportunity_Appointments");
            }
        }

        /// <summary>
        ///     N:1 processstage_appointments
        /// </summary>
        [AttributeLogicalName("stageid")]
        [RelationshipSchemaName("processstage_appointments")]
        public ProcessStage processstage_appointments
        {
            get { return GetRelatedEntity<ProcessStage>("processstage_appointments", null); }
            set
            {
                OnPropertyChanging("processstage_appointments");
                SetRelatedEntity("processstage_appointments", null, value);
                OnPropertyChanged("processstage_appointments");
            }
        }

        /// <summary>
        ///     N:1 Quote_Appointments
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Quote_Appointments")]
        public Quote Quote_Appointments
        {
            get { return GetRelatedEntity<Quote>("Quote_Appointments", null); }
            set
            {
                OnPropertyChanging("Quote_Appointments");
                SetRelatedEntity("Quote_Appointments", null, value);
                OnPropertyChanged("Quote_Appointments");
            }
        }

        /// <summary>
        ///     N:1 recurringappointmentmaster_appointment
        /// </summary>
        [AttributeLogicalName("seriesid")]
        [RelationshipSchemaName("recurringappointmentmaster_appointment")]
        public RecurringAppointmentMaster recurringappointmentmaster_appointment
        {
            get { return GetRelatedEntity<RecurringAppointmentMaster>("recurringappointmentmaster_appointment", null); }
        }

        /// <summary>
        ///     N:1 SalesOrder_Appointments
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SalesOrder_Appointments")]
        public SalesOrder SalesOrder_Appointments
        {
            get { return GetRelatedEntity<SalesOrder>("SalesOrder_Appointments", null); }
            set
            {
                OnPropertyChanging("SalesOrder_Appointments");
                SetRelatedEntity("SalesOrder_Appointments", null, value);
                OnPropertyChanged("SalesOrder_Appointments");
            }
        }

        /// <summary>
        ///     N:1 service_appointments
        /// </summary>
        [AttributeLogicalName("serviceid")]
        [RelationshipSchemaName("service_appointments")]
        public Service service_appointments
        {
            get { return GetRelatedEntity<Service>("service_appointments", null); }
            set
            {
                OnPropertyChanging("service_appointments");
                SetRelatedEntity("service_appointments", null, value);
                OnPropertyChanged("service_appointments");
            }
        }

        /// <summary>
        ///     N:1 team_appointment
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_appointment")]
        public Team team_appointment
        {
            get { return GetRelatedEntity<Team>("team_appointment", null); }
        }

        /// <summary>
        ///     N:1 TransactionCurrency_Appointment
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("TransactionCurrency_Appointment")]
        public TransactionCurrency TransactionCurrency_Appointment
        {
            get { return GetRelatedEntity<TransactionCurrency>("TransactionCurrency_Appointment", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_Appointment");
                SetRelatedEntity("TransactionCurrency_Appointment", null, value);
                OnPropertyChanged("TransactionCurrency_Appointment");
            }
        }

        /// <summary>
        ///     N:1 user_appointment
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_appointment")]
        public SystemUser user_appointment
        {
            get { return GetRelatedEntity<SystemUser>("user_appointment", null); }
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