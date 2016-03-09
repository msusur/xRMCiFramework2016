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
    ///     Task performed, or to be performed, by a user. An activity is any action for which an entry can be made on a
    ///     calendar.
    /// </summary>
    [DataContract]
    [EntityLogicalName("activitypointer")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ActivityPointer : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "activitypointer";

        public const int EntityTypeCode = 4200;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ActivityPointer() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the activity.
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
        ///     Actual duration of the activity in minutes.
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
        ///     Actual end time of the activity.
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
        ///     Actual start time of the activity.
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
        ///     All activity parties associated with this activity.
        /// </summary>
        [AttributeLogicalName("allparties")]
        public IEnumerable<ActivityParty> allparties
        {
            get
            {
                var collection = GetAttributeValue<EntityCollection>("allparties");
                if (((collection != null)
                     && (collection.Entities != null)))
                {
                    return Enumerable.Cast<ActivityParty>(collection.Entities);
                }
                return null;
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the activity.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the activity was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the activitypointer.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Date and time when the delivery of the activity was last attempted.
        /// </summary>
        [AttributeLogicalName("deliverylastattemptedon")]
        public DateTime? DeliveryLastAttemptedOn
        {
            get { return GetAttributeValue<DateTime?>("deliverylastattemptedon"); }
        }

        /// <summary>
        ///     Priority of delivery of the activity to the email server.
        /// </summary>
        [AttributeLogicalName("deliveryprioritycode")]
        public OptionSetValue DeliveryPriorityCode
        {
            get { return GetAttributeValue<OptionSetValue>("deliveryprioritycode"); }
            set
            {
                OnPropertyChanging("DeliveryPriorityCode");
                SetAttributeValue("deliveryprioritycode", value);
                OnPropertyChanged("DeliveryPriorityCode");
            }
        }

        /// <summary>
        ///     Description of the activity.
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
        ///     Exchange rate for the currency associated with the activitypointer with respect to the base currency.
        /// </summary>
        [AttributeLogicalName("exchangerate")]
        public decimal? ExchangeRate
        {
            get { return GetAttributeValue<decimal?>("exchangerate"); }
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
        ///     Information regarding whether the activity was billed as part of resolving a case.
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
        ///     Information regarding whether the activity was created from a workflow rule.
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
        ///     Left the voice mail
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
        ///     Unique identifier of user who last modified the activity.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when activity was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the activitypointer.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the user or team who owns the activity.
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
        ///     Unique identifier of the business unit that owns the activity.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team that owns the activity.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user that owns the activity.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("postponeactivityprocessinguntil")]
        public DateTime? PostponeActivityProcessingUntil
        {
            get { return GetAttributeValue<DateTime?>("postponeactivityprocessinguntil"); }
        }

        /// <summary>
        ///     Priority of the activity.
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
        ///     Unique identifier of the Process.
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
        ///     Unique identifier of the object with which the activity is associated.
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
        ///     Scheduled duration of the activity, specified in minutes.
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
        ///     Scheduled end time of the activity.
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
        ///     Scheduled start time of the activity.
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
        ///     Unique identifier of the mailbox associated with the sender of the email message.
        /// </summary>
        [AttributeLogicalName("sendermailboxid")]
        public EntityReference SenderMailboxId
        {
            get { return GetAttributeValue<EntityReference>("sendermailboxid"); }
        }

        /// <summary>
        ///     Date and time when the activity was sent.
        /// </summary>
        [AttributeLogicalName("senton")]
        public DateTime? SentOn
        {
            get { return GetAttributeValue<DateTime?>("senton"); }
        }

        /// <summary>
        ///     Uniqueidentifier specifying the id of recurring series of an instance.
        /// </summary>
        [AttributeLogicalName("seriesid")]
        public Guid? SeriesId
        {
            get { return GetAttributeValue<Guid?>("seriesid"); }
        }

        /// <summary>
        ///     Unique identifier of an associated service.
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
        ///     Unique identifier of the Stage.
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
        ///     Status of the activity.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public ActivityPointerState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ActivityPointerState) (Enum.ToObject(typeof (ActivityPointerState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the activity.
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
        ///     Subject associated with the activity.
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
        ///     Unique identifier of the currency associated with the activitypointer.
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
        ///     Version number of the activity.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N activity_campaignresponse
        /// </summary>
        [RelationshipSchemaName("activity_campaignresponse")]
        public IEnumerable<CampaignResponse> activity_campaignresponse
        {
            get { return GetRelatedEntities<CampaignResponse>("activity_campaignresponse", null); }
            set
            {
                OnPropertyChanging("activity_campaignresponse");
                SetRelatedEntities("activity_campaignresponse", null, value);
                OnPropertyChanged("activity_campaignresponse");
            }
        }

        /// <summary>
        ///     1:N activity_pointer_activity_mime_attachment
        /// </summary>
        [RelationshipSchemaName("activity_pointer_activity_mime_attachment")]
        public IEnumerable<ActivityMimeAttachment> activity_pointer_activity_mime_attachment
        {
            get
            {
                return GetRelatedEntities<ActivityMimeAttachment>("activity_pointer_activity_mime_attachment", null);
            }
            set
            {
                OnPropertyChanging("activity_pointer_activity_mime_attachment");
                SetRelatedEntities("activity_pointer_activity_mime_attachment", null, value);
                OnPropertyChanged("activity_pointer_activity_mime_attachment");
            }
        }

        /// <summary>
        ///     1:N activity_pointer_appointment
        /// </summary>
        [RelationshipSchemaName("activity_pointer_appointment")]
        public IEnumerable<Appointment> activity_pointer_appointment
        {
            get { return GetRelatedEntities<Appointment>("activity_pointer_appointment", null); }
            set
            {
                OnPropertyChanging("activity_pointer_appointment");
                SetRelatedEntities("activity_pointer_appointment", null, value);
                OnPropertyChanged("activity_pointer_appointment");
            }
        }

        /// <summary>
        ///     1:N activity_pointer_BulkOperation
        /// </summary>
        [RelationshipSchemaName("activity_pointer_BulkOperation")]
        public IEnumerable<BulkOperation> activity_pointer_BulkOperation
        {
            get { return GetRelatedEntities<BulkOperation>("activity_pointer_BulkOperation", null); }
            set
            {
                OnPropertyChanging("activity_pointer_BulkOperation");
                SetRelatedEntities("activity_pointer_BulkOperation", null, value);
                OnPropertyChanged("activity_pointer_BulkOperation");
            }
        }

        /// <summary>
        ///     1:N activity_pointer_BulkOperation_logs
        /// </summary>
        [RelationshipSchemaName("activity_pointer_BulkOperation_logs")]
        public IEnumerable<BulkOperationLog> activity_pointer_BulkOperation_logs
        {
            get { return GetRelatedEntities<BulkOperationLog>("activity_pointer_BulkOperation_logs", null); }
            set
            {
                OnPropertyChanging("activity_pointer_BulkOperation_logs");
                SetRelatedEntities("activity_pointer_BulkOperation_logs", null, value);
                OnPropertyChanged("activity_pointer_BulkOperation_logs");
            }
        }

        /// <summary>
        ///     1:N activity_pointer_campaignactivity
        /// </summary>
        [RelationshipSchemaName("activity_pointer_campaignactivity")]
        public IEnumerable<CampaignActivity> activity_pointer_campaignactivity
        {
            get { return GetRelatedEntities<CampaignActivity>("activity_pointer_campaignactivity", null); }
            set
            {
                OnPropertyChanging("activity_pointer_campaignactivity");
                SetRelatedEntities("activity_pointer_campaignactivity", null, value);
                OnPropertyChanged("activity_pointer_campaignactivity");
            }
        }

        /// <summary>
        ///     1:N activity_pointer_campaignresponse
        /// </summary>
        [RelationshipSchemaName("activity_pointer_campaignresponse")]
        public IEnumerable<CampaignResponse> activity_pointer_campaignresponse
        {
            get { return GetRelatedEntities<CampaignResponse>("activity_pointer_campaignresponse", null); }
            set
            {
                OnPropertyChanging("activity_pointer_campaignresponse");
                SetRelatedEntities("activity_pointer_campaignresponse", null, value);
                OnPropertyChanged("activity_pointer_campaignresponse");
            }
        }

        /// <summary>
        ///     1:N activity_pointer_email
        /// </summary>
        [RelationshipSchemaName("activity_pointer_email")]
        public IEnumerable<Email> activity_pointer_email
        {
            get { return GetRelatedEntities<Email>("activity_pointer_email", null); }
            set
            {
                OnPropertyChanging("activity_pointer_email");
                SetRelatedEntities("activity_pointer_email", null, value);
                OnPropertyChanged("activity_pointer_email");
            }
        }

        /// <summary>
        ///     1:N activity_pointer_fax
        /// </summary>
        [RelationshipSchemaName("activity_pointer_fax")]
        public IEnumerable<Fax> activity_pointer_fax
        {
            get { return GetRelatedEntities<Fax>("activity_pointer_fax", null); }
            set
            {
                OnPropertyChanging("activity_pointer_fax");
                SetRelatedEntities("activity_pointer_fax", null, value);
                OnPropertyChanged("activity_pointer_fax");
            }
        }

        /// <summary>
        ///     1:N activity_pointer_incident_resolution
        /// </summary>
        [RelationshipSchemaName("activity_pointer_incident_resolution")]
        public IEnumerable<IncidentResolution> activity_pointer_incident_resolution
        {
            get { return GetRelatedEntities<IncidentResolution>("activity_pointer_incident_resolution", null); }
            set
            {
                OnPropertyChanging("activity_pointer_incident_resolution");
                SetRelatedEntities("activity_pointer_incident_resolution", null, value);
                OnPropertyChanged("activity_pointer_incident_resolution");
            }
        }

        /// <summary>
        ///     1:N activity_pointer_letter
        /// </summary>
        [RelationshipSchemaName("activity_pointer_letter")]
        public IEnumerable<Letter> activity_pointer_letter
        {
            get { return GetRelatedEntities<Letter>("activity_pointer_letter", null); }
            set
            {
                OnPropertyChanging("activity_pointer_letter");
                SetRelatedEntities("activity_pointer_letter", null, value);
                OnPropertyChanged("activity_pointer_letter");
            }
        }

        /// <summary>
        ///     1:N activity_pointer_opportunity_close
        /// </summary>
        [RelationshipSchemaName("activity_pointer_opportunity_close")]
        public IEnumerable<OpportunityClose> activity_pointer_opportunity_close
        {
            get { return GetRelatedEntities<OpportunityClose>("activity_pointer_opportunity_close", null); }
            set
            {
                OnPropertyChanging("activity_pointer_opportunity_close");
                SetRelatedEntities("activity_pointer_opportunity_close", null, value);
                OnPropertyChanged("activity_pointer_opportunity_close");
            }
        }

        /// <summary>
        ///     1:N activity_pointer_order_close
        /// </summary>
        [RelationshipSchemaName("activity_pointer_order_close")]
        public IEnumerable<OrderClose> activity_pointer_order_close
        {
            get { return GetRelatedEntities<OrderClose>("activity_pointer_order_close", null); }
            set
            {
                OnPropertyChanging("activity_pointer_order_close");
                SetRelatedEntities("activity_pointer_order_close", null, value);
                OnPropertyChanged("activity_pointer_order_close");
            }
        }

        /// <summary>
        ///     1:N activity_pointer_phonecall
        /// </summary>
        [RelationshipSchemaName("activity_pointer_phonecall")]
        public IEnumerable<PhoneCall> activity_pointer_phonecall
        {
            get { return GetRelatedEntities<PhoneCall>("activity_pointer_phonecall", null); }
            set
            {
                OnPropertyChanging("activity_pointer_phonecall");
                SetRelatedEntities("activity_pointer_phonecall", null, value);
                OnPropertyChanged("activity_pointer_phonecall");
            }
        }

        /// <summary>
        ///     1:N activity_pointer_quote_close
        /// </summary>
        [RelationshipSchemaName("activity_pointer_quote_close")]
        public IEnumerable<QuoteClose> activity_pointer_quote_close
        {
            get { return GetRelatedEntities<QuoteClose>("activity_pointer_quote_close", null); }
            set
            {
                OnPropertyChanging("activity_pointer_quote_close");
                SetRelatedEntities("activity_pointer_quote_close", null, value);
                OnPropertyChanged("activity_pointer_quote_close");
            }
        }

        /// <summary>
        ///     1:N activity_pointer_recurrencerule
        /// </summary>
        [RelationshipSchemaName("activity_pointer_recurrencerule")]
        public IEnumerable<RecurrenceRule> activity_pointer_recurrencerule
        {
            get { return GetRelatedEntities<RecurrenceRule>("activity_pointer_recurrencerule", null); }
            set
            {
                OnPropertyChanging("activity_pointer_recurrencerule");
                SetRelatedEntities("activity_pointer_recurrencerule", null, value);
                OnPropertyChanged("activity_pointer_recurrencerule");
            }
        }

        /// <summary>
        ///     1:N activity_pointer_recurringappointmentmaster
        /// </summary>
        [RelationshipSchemaName("activity_pointer_recurringappointmentmaster")]
        public IEnumerable<RecurringAppointmentMaster> activity_pointer_recurringappointmentmaster
        {
            get
            {
                return GetRelatedEntities<RecurringAppointmentMaster>("activity_pointer_recurringappointmentmaster",
                    null);
            }
            set
            {
                OnPropertyChanging("activity_pointer_recurringappointmentmaster");
                SetRelatedEntities("activity_pointer_recurringappointmentmaster", null, value);
                OnPropertyChanged("activity_pointer_recurringappointmentmaster");
            }
        }

        /// <summary>
        ///     1:N activity_pointer_service_appointment
        /// </summary>
        [RelationshipSchemaName("activity_pointer_service_appointment")]
        public IEnumerable<ServiceAppointment> activity_pointer_service_appointment
        {
            get { return GetRelatedEntities<ServiceAppointment>("activity_pointer_service_appointment", null); }
            set
            {
                OnPropertyChanging("activity_pointer_service_appointment");
                SetRelatedEntities("activity_pointer_service_appointment", null, value);
                OnPropertyChanged("activity_pointer_service_appointment");
            }
        }

        /// <summary>
        ///     1:N activity_pointer_task
        /// </summary>
        [RelationshipSchemaName("activity_pointer_task")]
        public IEnumerable<Task> activity_pointer_task
        {
            get { return GetRelatedEntities<Task>("activity_pointer_task", null); }
            set
            {
                OnPropertyChanging("activity_pointer_task");
                SetRelatedEntities("activity_pointer_task", null, value);
                OnPropertyChanged("activity_pointer_task");
            }
        }

        /// <summary>
        ///     1:N activitypointer_activity_parties
        /// </summary>
        [RelationshipSchemaName("activitypointer_activity_parties")]
        public IEnumerable<ActivityParty> activitypointer_activity_parties
        {
            get { return GetRelatedEntities<ActivityParty>("activitypointer_activity_parties", null); }
            set
            {
                OnPropertyChanging("activitypointer_activity_parties");
                SetRelatedEntities("activitypointer_activity_parties", null, value);
                OnPropertyChanged("activitypointer_activity_parties");
            }
        }

        /// <summary>
        ///     1:N ActivityPointer_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("ActivityPointer_AsyncOperations")]
        public IEnumerable<AsyncOperation> ActivityPointer_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("ActivityPointer_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("ActivityPointer_AsyncOperations");
                SetRelatedEntities("ActivityPointer_AsyncOperations", null, value);
                OnPropertyChanged("ActivityPointer_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N ActivityPointer_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("ActivityPointer_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> ActivityPointer_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("ActivityPointer_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("ActivityPointer_BulkDeleteFailures");
                SetRelatedEntities("ActivityPointer_BulkDeleteFailures", null, value);
                OnPropertyChanged("ActivityPointer_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N ActivityPointer_CampaignActivityItems
        /// </summary>
        [RelationshipSchemaName("ActivityPointer_CampaignActivityItems")]
        public IEnumerable<CampaignActivityItem> ActivityPointer_CampaignActivityItems
        {
            get { return GetRelatedEntities<CampaignActivityItem>("ActivityPointer_CampaignActivityItems", null); }
            set
            {
                OnPropertyChanging("ActivityPointer_CampaignActivityItems");
                SetRelatedEntities("ActivityPointer_CampaignActivityItems", null, value);
                OnPropertyChanged("ActivityPointer_CampaignActivityItems");
            }
        }

        /// <summary>
        ///     1:N activitypointer_connections1
        /// </summary>
        [RelationshipSchemaName("activitypointer_connections1")]
        public IEnumerable<Connection> activitypointer_connections1
        {
            get { return GetRelatedEntities<Connection>("activitypointer_connections1", null); }
            set
            {
                OnPropertyChanging("activitypointer_connections1");
                SetRelatedEntities("activitypointer_connections1", null, value);
                OnPropertyChanged("activitypointer_connections1");
            }
        }

        /// <summary>
        ///     1:N activitypointer_connections2
        /// </summary>
        [RelationshipSchemaName("activitypointer_connections2")]
        public IEnumerable<Connection> activitypointer_connections2
        {
            get { return GetRelatedEntities<Connection>("activitypointer_connections2", null); }
            set
            {
                OnPropertyChanging("activitypointer_connections2");
                SetRelatedEntities("activitypointer_connections2", null, value);
                OnPropertyChanged("activitypointer_connections2");
            }
        }

        /// <summary>
        ///     1:N ActivityPointer_QueueItem
        /// </summary>
        [RelationshipSchemaName("ActivityPointer_QueueItem")]
        public IEnumerable<QueueItem> ActivityPointer_QueueItem
        {
            get { return GetRelatedEntities<QueueItem>("ActivityPointer_QueueItem", null); }
            set
            {
                OnPropertyChanging("ActivityPointer_QueueItem");
                SetRelatedEntities("ActivityPointer_QueueItem", null, value);
                OnPropertyChanged("ActivityPointer_QueueItem");
            }
        }

        /// <summary>
        ///     1:N CreatedActivity_BulkOperationLogs
        /// </summary>
        [RelationshipSchemaName("CreatedActivity_BulkOperationLogs")]
        public IEnumerable<BulkOperationLog> CreatedActivity_BulkOperationLogs
        {
            get { return GetRelatedEntities<BulkOperationLog>("CreatedActivity_BulkOperationLogs", null); }
            set
            {
                OnPropertyChanging("CreatedActivity_BulkOperationLogs");
                SetRelatedEntities("CreatedActivity_BulkOperationLogs", null, value);
                OnPropertyChanged("CreatedActivity_BulkOperationLogs");
            }
        }

        /// <summary>
        ///     N:1 Account_ActivityPointers
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Account_ActivityPointers")]
        public Account Account_ActivityPointers
        {
            get { return GetRelatedEntity<Account>("Account_ActivityPointers", null); }
            set
            {
                OnPropertyChanging("Account_ActivityPointers");
                SetRelatedEntity("Account_ActivityPointers", null, value);
                OnPropertyChanged("Account_ActivityPointers");
            }
        }

        /// <summary>
        ///     N:1 activitypointer_sendermailboxid_mailbox
        /// </summary>
        [AttributeLogicalName("sendermailboxid")]
        [RelationshipSchemaName("activitypointer_sendermailboxid_mailbox")]
        public Mailbox activitypointer_sendermailboxid_mailbox
        {
            get { return GetRelatedEntity<Mailbox>("activitypointer_sendermailboxid_mailbox", null); }
        }

        /// <summary>
        ///     N:1 BulkOperation_ActivityPointers
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("BulkOperation_ActivityPointers")]
        public BulkOperation BulkOperation_ActivityPointers
        {
            get { return GetRelatedEntity<BulkOperation>("BulkOperation_ActivityPointers", null); }
            set
            {
                OnPropertyChanging("BulkOperation_ActivityPointers");
                SetRelatedEntity("BulkOperation_ActivityPointers", null, value);
                OnPropertyChanged("BulkOperation_ActivityPointers");
            }
        }

        /// <summary>
        ///     N:1 business_unit_activitypointer
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_activitypointer")]
        public BusinessUnit business_unit_activitypointer
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_activitypointer", null); }
        }

        /// <summary>
        ///     N:1 Campaign_ActivityPointers
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Campaign_ActivityPointers")]
        public Campaign Campaign_ActivityPointers
        {
            get { return GetRelatedEntity<Campaign>("Campaign_ActivityPointers", null); }
            set
            {
                OnPropertyChanging("Campaign_ActivityPointers");
                SetRelatedEntity("Campaign_ActivityPointers", null, value);
                OnPropertyChanged("Campaign_ActivityPointers");
            }
        }

        /// <summary>
        ///     N:1 CampaignActivity_ActivityPointers
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("CampaignActivity_ActivityPointers")]
        public CampaignActivity CampaignActivity_ActivityPointers
        {
            get { return GetRelatedEntity<CampaignActivity>("CampaignActivity_ActivityPointers", null); }
            set
            {
                OnPropertyChanging("CampaignActivity_ActivityPointers");
                SetRelatedEntity("CampaignActivity_ActivityPointers", null, value);
                OnPropertyChanged("CampaignActivity_ActivityPointers");
            }
        }

        /// <summary>
        ///     N:1 Contact_ActivityPointers
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Contact_ActivityPointers")]
        public Contact Contact_ActivityPointers
        {
            get { return GetRelatedEntity<Contact>("Contact_ActivityPointers", null); }
            set
            {
                OnPropertyChanging("Contact_ActivityPointers");
                SetRelatedEntity("Contact_ActivityPointers", null, value);
                OnPropertyChanged("Contact_ActivityPointers");
            }
        }

        /// <summary>
        ///     N:1 Contract_ActivityPointers
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Contract_ActivityPointers")]
        public Contract Contract_ActivityPointers
        {
            get { return GetRelatedEntity<Contract>("Contract_ActivityPointers", null); }
            set
            {
                OnPropertyChanging("Contract_ActivityPointers");
                SetRelatedEntity("Contract_ActivityPointers", null, value);
                OnPropertyChanged("Contract_ActivityPointers");
            }
        }

        /// <summary>
        ///     N:1 Incident_ActivityPointers
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Incident_ActivityPointers")]
        public Incident Incident_ActivityPointers
        {
            get { return GetRelatedEntity<Incident>("Incident_ActivityPointers", null); }
            set
            {
                OnPropertyChanging("Incident_ActivityPointers");
                SetRelatedEntity("Incident_ActivityPointers", null, value);
                OnPropertyChanged("Incident_ActivityPointers");
            }
        }

        /// <summary>
        ///     N:1 Invoice_ActivityPointers
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Invoice_ActivityPointers")]
        public Invoice Invoice_ActivityPointers
        {
            get { return GetRelatedEntity<Invoice>("Invoice_ActivityPointers", null); }
            set
            {
                OnPropertyChanging("Invoice_ActivityPointers");
                SetRelatedEntity("Invoice_ActivityPointers", null, value);
                OnPropertyChanged("Invoice_ActivityPointers");
            }
        }

        /// <summary>
        ///     N:1 Lead_ActivityPointers
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Lead_ActivityPointers")]
        public Lead Lead_ActivityPointers
        {
            get { return GetRelatedEntity<Lead>("Lead_ActivityPointers", null); }
            set
            {
                OnPropertyChanging("Lead_ActivityPointers");
                SetRelatedEntity("Lead_ActivityPointers", null, value);
                OnPropertyChanged("Lead_ActivityPointers");
            }
        }

        /// <summary>
        ///     N:1 lk_activitypointer_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_activitypointer_createdby")]
        public SystemUser lk_activitypointer_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_activitypointer_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_activitypointer_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_activitypointer_createdonbehalfby")]
        public SystemUser lk_activitypointer_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_activitypointer_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_activitypointer_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_activitypointer_modifiedby")]
        public SystemUser lk_activitypointer_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_activitypointer_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_activitypointer_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_activitypointer_modifiedonbehalfby")]
        public SystemUser lk_activitypointer_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_activitypointer_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 msdyn_postalbum_ActivityPointers
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("msdyn_postalbum_ActivityPointers")]
        public msdyn_PostAlbum msdyn_postalbum_ActivityPointers
        {
            get { return GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_ActivityPointers", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_ActivityPointers");
                SetRelatedEntity("msdyn_postalbum_ActivityPointers", null, value);
                OnPropertyChanged("msdyn_postalbum_ActivityPointers");
            }
        }

        /// <summary>
        ///     N:1 Opportunity_ActivityPointers
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Opportunity_ActivityPointers")]
        public Opportunity Opportunity_ActivityPointers
        {
            get { return GetRelatedEntity<Opportunity>("Opportunity_ActivityPointers", null); }
            set
            {
                OnPropertyChanging("Opportunity_ActivityPointers");
                SetRelatedEntity("Opportunity_ActivityPointers", null, value);
                OnPropertyChanged("Opportunity_ActivityPointers");
            }
        }

        /// <summary>
        ///     N:1 Quote_ActivityPointers
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Quote_ActivityPointers")]
        public Quote Quote_ActivityPointers
        {
            get { return GetRelatedEntity<Quote>("Quote_ActivityPointers", null); }
            set
            {
                OnPropertyChanging("Quote_ActivityPointers");
                SetRelatedEntity("Quote_ActivityPointers", null, value);
                OnPropertyChanged("Quote_ActivityPointers");
            }
        }

        /// <summary>
        ///     N:1 SalesOrder_ActivityPointers
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SalesOrder_ActivityPointers")]
        public SalesOrder SalesOrder_ActivityPointers
        {
            get { return GetRelatedEntity<SalesOrder>("SalesOrder_ActivityPointers", null); }
            set
            {
                OnPropertyChanging("SalesOrder_ActivityPointers");
                SetRelatedEntity("SalesOrder_ActivityPointers", null, value);
                OnPropertyChanged("SalesOrder_ActivityPointers");
            }
        }

        /// <summary>
        ///     N:1 service_activity_pointers
        /// </summary>
        [AttributeLogicalName("serviceid")]
        [RelationshipSchemaName("service_activity_pointers")]
        public Service service_activity_pointers
        {
            get { return GetRelatedEntity<Service>("service_activity_pointers", null); }
            set
            {
                OnPropertyChanging("service_activity_pointers");
                SetRelatedEntity("service_activity_pointers", null, value);
                OnPropertyChanged("service_activity_pointers");
            }
        }

        /// <summary>
        ///     N:1 team_activity
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_activity")]
        public Team team_activity
        {
            get { return GetRelatedEntity<Team>("team_activity", null); }
        }

        /// <summary>
        ///     N:1 TransactionCurrency_ActivityPointer
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("TransactionCurrency_ActivityPointer")]
        public TransactionCurrency TransactionCurrency_ActivityPointer
        {
            get { return GetRelatedEntity<TransactionCurrency>("TransactionCurrency_ActivityPointer", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_ActivityPointer");
                SetRelatedEntity("TransactionCurrency_ActivityPointer", null, value);
                OnPropertyChanged("TransactionCurrency_ActivityPointer");
            }
        }

        /// <summary>
        ///     N:1 user_activity
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_activity")]
        public SystemUser user_activity
        {
            get { return GetRelatedEntity<SystemUser>("user_activity", null); }
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