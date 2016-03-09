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
    ///     Activity that is delivered using email protocols.
    /// </summary>
    [DataContract]
    [EntityLogicalName("email")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Email : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "email";

        public const int EntityTypeCode = 4202;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Email() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the email activity.
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
        ///     Type the number of minutes spent creating and sending the email. The duration is used in reporting.
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
        ///     Enter the actual end date and time of the email. By default, it displays the date and time when the activity was
        ///     completed or canceled, but can be edited to capture the actual time to create and send the email.
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
        ///     Enter the actual start date and time for the email. By default, it displays the date and time when the activity was
        ///     created, but can be edited to capture the actual time to create and send the email.
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
        ///     Shows the umber of attachments of the email message.
        /// </summary>
        [AttributeLogicalName("attachmentcount")]
        public int? AttachmentCount
        {
            get { return GetAttributeValue<int?>("attachmentcount"); }
        }

        /// <summary>
        ///     Enter the recipients that are included on the email distribution, but are not displayed to other recipients.
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
        ///     Type a category to identify the email type, such as lead outreach, customer follow-up, or service alert, to tie the
        ///     email to a business group or function.
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
        ///     Enter the recipients that should be copied on the email.
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
        ///     Indicates if the body is compressed.
        /// </summary>
        [AttributeLogicalName("compressed")]
        public bool? Compressed
        {
            get { return GetAttributeValue<bool?>("compressed"); }
        }

        /// <summary>
        ///     Identifier for all the email responses for this conversation.
        /// </summary>
        [AttributeLogicalName("conversationindex")]
        public string ConversationIndex
        {
            get { return GetAttributeValue<string>("conversationindex"); }
        }

        /// <summary>
        ///     Shows how an email is matched to an existing email in Microsoft Dynamics CRM. For system use only.
        /// </summary>
        [AttributeLogicalName("correlationmethod")]
        public OptionSetValue CorrelationMethod
        {
            get { return GetAttributeValue<OptionSetValue>("correlationmethod"); }
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
        ///     Shows the count of the number of attempts made to send the email. The count is used as an indicator of email
        ///     routing issues.
        /// </summary>
        [AttributeLogicalName("deliveryattempts")]
        public int? DeliveryAttempts
        {
            get { return GetAttributeValue<int?>("deliveryattempts"); }
            set
            {
                OnPropertyChanging("DeliveryAttempts");
                SetAttributeValue("deliveryattempts", value);
                OnPropertyChanged("DeliveryAttempts");
            }
        }

        /// <summary>
        ///     Select the priority of delivery of the email to the email server.
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
        ///     Select whether the sender should receive confirmation that the email was delivered.
        /// </summary>
        [AttributeLogicalName("deliveryreceiptrequested")]
        public bool? DeliveryReceiptRequested
        {
            get { return GetAttributeValue<bool?>("deliveryreceiptrequested"); }
            set
            {
                OnPropertyChanging("DeliveryReceiptRequested");
                SetAttributeValue("deliveryreceiptrequested", value);
                OnPropertyChanged("DeliveryReceiptRequested");
            }
        }

        /// <summary>
        ///     Type the greeting and message text of the email.
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
        ///     Select the direction of the email as incoming or outbound.
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
        ///     Enter the sender of the email.
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
        ///     Type the ID of the email message that this email activity is a response to.
        /// </summary>
        [AttributeLogicalName("inreplyto")]
        public string InReplyTo
        {
            get { return GetAttributeValue<string>("inreplyto"); }
        }

        /// <summary>
        ///     Information regarding whether the email activity was billed as part of resolving a case.
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
        ///     Indication if the email was created by a workflow rule.
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
        ///     Unique identifier of the email message. Used only for email that is received.
        /// </summary>
        [AttributeLogicalName("messageid")]
        public string MessageId
        {
            get { return GetAttributeValue<string>("messageid"); }
            set
            {
                OnPropertyChanging("MessageId");
                SetAttributeValue("messageid", value);
                OnPropertyChanged("MessageId");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("messageiddupcheck")]
        [Obsolete]
        public Guid? MessageIdDupCheck
        {
            get { return GetAttributeValue<Guid?>("messageiddupcheck"); }
            set
            {
                OnPropertyChanging("MessageIdDupCheck");
                SetAttributeValue("messageiddupcheck", value);
                OnPropertyChanged("MessageIdDupCheck");
            }
        }

        /// <summary>
        ///     MIME type of the email message data.
        /// </summary>
        [AttributeLogicalName("mimetype")]
        public string MimeType
        {
            get { return GetAttributeValue<string>("mimetype"); }
            set
            {
                OnPropertyChanging("MimeType");
                SetAttributeValue("mimetype", value);
                OnPropertyChanged("MimeType");
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
        ///     Select the notification code to identify issues with the email recipients or attachments, such as blocked
        ///     attachments.
        /// </summary>
        [AttributeLogicalName("notifications")]
        public OptionSetValue Notifications
        {
            get { return GetAttributeValue<OptionSetValue>("notifications"); }
            set
            {
                OnPropertyChanging("Notifications");
                SetAttributeValue("notifications", value);
                OnPropertyChanged("Notifications");
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
        ///     Unique identifier of the business unit that owns the email activity.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the email activity.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the email activity.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Select the activity that the email is associated with.
        /// </summary>
        [AttributeLogicalName("parentactivityid")]
        public EntityReference ParentActivityId
        {
            get { return GetAttributeValue<EntityReference>("parentactivityid"); }
            set
            {
                OnPropertyChanging("ParentActivityId");
                SetAttributeValue("parentactivityid", value);
                OnPropertyChanged("ParentActivityId");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("postponeemailprocessinguntil")]
        public DateTime? PostponeEmailProcessingUntil
        {
            get { return GetAttributeValue<DateTime?>("postponeemailprocessinguntil"); }
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
        ///     Indicates that a read receipt is requested.
        /// </summary>
        [AttributeLogicalName("readreceiptrequested")]
        public bool? ReadReceiptRequested
        {
            get { return GetAttributeValue<bool?>("readreceiptrequested"); }
            set
            {
                OnPropertyChanging("ReadReceiptRequested");
                SetAttributeValue("readreceiptrequested", value);
                OnPropertyChanged("ReadReceiptRequested");
            }
        }

        /// <summary>
        ///     Unique identifier of the object with which the e-mail is associated.
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
        ///     Scheduled duration of the email activity, specified in minutes.
        /// </summary>
        [AttributeLogicalName("scheduleddurationminutes")]
        public int? ScheduledDurationMinutes
        {
            get { return GetAttributeValue<int?>("scheduleddurationminutes"); }
        }

        /// <summary>
        ///     Enter the expected due date and time for the activity to be completed to provide details about when the email will
        ///     be sent.
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
        ///     Enter the expected start date and time for the activity to provide details about the tentative time when the email
        ///     activity must be initiated.
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
        ///     Sender of the email.
        /// </summary>
        [AttributeLogicalName("sender")]
        public string Sender
        {
            get { return GetAttributeValue<string>("sender"); }
            set
            {
                OnPropertyChanging("Sender");
                SetAttributeValue("sender", value);
                OnPropertyChanged("Sender");
            }
        }

        /// <summary>
        ///     Select the mailbox associated with the sender of the email message.
        /// </summary>
        [AttributeLogicalName("sendermailboxid")]
        public EntityReference SenderMailboxId
        {
            get { return GetAttributeValue<EntityReference>("sendermailboxid"); }
        }

        /// <summary>
        ///     Shows the date and time that the email was sent.
        /// </summary>
        [AttributeLogicalName("senton")]
        public DateTime? SentOn
        {
            get { return GetAttributeValue<DateTime?>("senton"); }
        }

        /// <summary>
        ///     Unique identifier for the associated service.
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
        ///     Shows whether the email is open, completed, or canceled. Completed and canceled email is read-only and can't be
        ///     edited.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public EmailState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((EmailState) (Enum.ToObject(typeof (EmailState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Select the email's status.
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
        ///     Type a subcategory to identify the email type and relate the activity to a specific product, sales region, business
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
        ///     Type a short description about the objective or primary topic of the email.
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
        ///     Shows the Microsoft Office Outlook account for the user who submitted the email to Microsoft Dynamics CRM.
        /// </summary>
        [AttributeLogicalName("submittedby")]
        public string SubmittedBy
        {
            get { return GetAttributeValue<string>("submittedby"); }
            set
            {
                OnPropertyChanging("SubmittedBy");
                SetAttributeValue("submittedby", value);
                OnPropertyChanged("SubmittedBy");
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
        ///     Enter the account, contact, lead, queue, or user recipients for the email.
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
        ///     Shows the email addresses corresponding to the recipients.
        /// </summary>
        [AttributeLogicalName("torecipients")]
        public string ToRecipients
        {
            get { return GetAttributeValue<string>("torecipients"); }
            set
            {
                OnPropertyChanging("ToRecipients");
                SetAttributeValue("torecipients", value);
                OnPropertyChanged("ToRecipients");
            }
        }

        /// <summary>
        ///     Shows the tracking token assigned to the email to make sure responses are automatically tracked in Microsoft
        ///     Dynamics CRM.
        /// </summary>
        [AttributeLogicalName("trackingtoken")]
        public string TrackingToken
        {
            get { return GetAttributeValue<string>("trackingtoken"); }
            set
            {
                OnPropertyChanging("TrackingToken");
                SetAttributeValue("trackingtoken", value);
                OnPropertyChanged("TrackingToken");
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
        ///     Version number of the email message.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N email_activity_mime_attachment
        /// </summary>
        [RelationshipSchemaName("email_activity_mime_attachment")]
        public IEnumerable<ActivityMimeAttachment> email_activity_mime_attachment
        {
            get { return GetRelatedEntities<ActivityMimeAttachment>("email_activity_mime_attachment", null); }
            set
            {
                OnPropertyChanging("email_activity_mime_attachment");
                SetRelatedEntities("email_activity_mime_attachment", null, value);
                OnPropertyChanged("email_activity_mime_attachment");
            }
        }

        /// <summary>
        ///     1:N email_activity_parties
        /// </summary>
        [RelationshipSchemaName("email_activity_parties")]
        public IEnumerable<ActivityParty> email_activity_parties
        {
            get { return GetRelatedEntities<ActivityParty>("email_activity_parties", null); }
            set
            {
                OnPropertyChanging("email_activity_parties");
                SetRelatedEntities("email_activity_parties", null, value);
                OnPropertyChanged("email_activity_parties");
            }
        }

        /// <summary>
        ///     1:N Email_Annotation
        /// </summary>
        [RelationshipSchemaName("Email_Annotation")]
        public IEnumerable<Annotation> Email_Annotation
        {
            get { return GetRelatedEntities<Annotation>("Email_Annotation", null); }
            set
            {
                OnPropertyChanging("Email_Annotation");
                SetRelatedEntities("Email_Annotation", null, value);
                OnPropertyChanged("Email_Annotation");
            }
        }

        /// <summary>
        ///     1:N Email_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Email_AsyncOperations")]
        public IEnumerable<AsyncOperation> Email_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Email_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Email_AsyncOperations");
                SetRelatedEntities("Email_AsyncOperations", null, value);
                OnPropertyChanged("Email_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N Email_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("Email_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> Email_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("Email_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("Email_BulkDeleteFailures");
                SetRelatedEntities("Email_BulkDeleteFailures", null, value);
                OnPropertyChanged("Email_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N email_campaignresponse
        /// </summary>
        [RelationshipSchemaName("email_campaignresponse")]
        public IEnumerable<CampaignResponse> email_campaignresponse
        {
            get { return GetRelatedEntities<CampaignResponse>("email_campaignresponse", null); }
            set
            {
                OnPropertyChanging("email_campaignresponse");
                SetRelatedEntities("email_campaignresponse", null, value);
                OnPropertyChanged("email_campaignresponse");
            }
        }

        /// <summary>
        ///     1:N email_connections1
        /// </summary>
        [RelationshipSchemaName("email_connections1")]
        public IEnumerable<Connection> email_connections1
        {
            get { return GetRelatedEntities<Connection>("email_connections1", null); }
            set
            {
                OnPropertyChanging("email_connections1");
                SetRelatedEntities("email_connections1", null, value);
                OnPropertyChanged("email_connections1");
            }
        }

        /// <summary>
        ///     1:N email_connections2
        /// </summary>
        [RelationshipSchemaName("email_connections2")]
        public IEnumerable<Connection> email_connections2
        {
            get { return GetRelatedEntities<Connection>("email_connections2", null); }
            set
            {
                OnPropertyChanging("email_connections2");
                SetRelatedEntities("email_connections2", null, value);
                OnPropertyChanged("email_connections2");
            }
        }

        /// <summary>
        ///     1:N Email_DuplicateBaseRecord
        /// </summary>
        [RelationshipSchemaName("Email_DuplicateBaseRecord")]
        public IEnumerable<DuplicateRecord> Email_DuplicateBaseRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Email_DuplicateBaseRecord", null); }
            set
            {
                OnPropertyChanging("Email_DuplicateBaseRecord");
                SetRelatedEntities("Email_DuplicateBaseRecord", null, value);
                OnPropertyChanged("Email_DuplicateBaseRecord");
            }
        }

        /// <summary>
        ///     1:N Email_DuplicateMatchingRecord
        /// </summary>
        [RelationshipSchemaName("Email_DuplicateMatchingRecord")]
        public IEnumerable<DuplicateRecord> Email_DuplicateMatchingRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Email_DuplicateMatchingRecord", null); }
            set
            {
                OnPropertyChanging("Email_DuplicateMatchingRecord");
                SetRelatedEntities("Email_DuplicateMatchingRecord", null, value);
                OnPropertyChanged("Email_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        ///     1:N email_email_parentactivityid
        /// </summary>
        [RelationshipSchemaName("email_email_parentactivityid", EntityRole.Referenced)]
        public IEnumerable<Email> Referencedemail_email_parentactivityid
        {
            get { return GetRelatedEntities<Email>("email_email_parentactivityid", EntityRole.Referenced); }
            set
            {
                OnPropertyChanging("Referencedemail_email_parentactivityid");
                SetRelatedEntities("email_email_parentactivityid", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedemail_email_parentactivityid");
            }
        }

        /// <summary>
        ///     1:N email_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("email_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> email_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntities<PrincipalObjectAttributeAccess>("email_principalobjectattributeaccess", null);
            }
            set
            {
                OnPropertyChanging("email_principalobjectattributeaccess");
                SetRelatedEntities("email_principalobjectattributeaccess", null, value);
                OnPropertyChanged("email_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N Email_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("Email_ProcessSessions")]
        public IEnumerable<ProcessSession> Email_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("Email_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Email_ProcessSessions");
                SetRelatedEntities("Email_ProcessSessions", null, value);
                OnPropertyChanged("Email_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N Email_QueueItem
        /// </summary>
        [RelationshipSchemaName("Email_QueueItem")]
        public IEnumerable<QueueItem> Email_QueueItem
        {
            get { return GetRelatedEntities<QueueItem>("Email_QueueItem", null); }
            set
            {
                OnPropertyChanging("Email_QueueItem");
                SetRelatedEntities("Email_QueueItem", null, value);
                OnPropertyChanged("Email_QueueItem");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_email
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_email")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_email
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_email", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_email");
                SetRelatedEntities("userentityinstancedata_email", null, value);
                OnPropertyChanged("userentityinstancedata_email");
            }
        }

        /// <summary>
        ///     N:1 Account_Emails
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Account_Emails")]
        public Account Account_Emails
        {
            get { return GetRelatedEntity<Account>("Account_Emails", null); }
            set
            {
                OnPropertyChanging("Account_Emails");
                SetRelatedEntity("Account_Emails", null, value);
                OnPropertyChanged("Account_Emails");
            }
        }

        /// <summary>
        ///     N:1 activity_pointer_email
        /// </summary>
        [AttributeLogicalName("activityid")]
        [RelationshipSchemaName("activity_pointer_email")]
        public ActivityPointer activity_pointer_email
        {
            get { return GetRelatedEntity<ActivityPointer>("activity_pointer_email", null); }
            set
            {
                OnPropertyChanging("activity_pointer_email");
                SetRelatedEntity("activity_pointer_email", null, value);
                OnPropertyChanged("activity_pointer_email");
            }
        }

        /// <summary>
        ///     N:1 AsyncOperation_Emails
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("AsyncOperation_Emails")]
        public AsyncOperation AsyncOperation_Emails
        {
            get { return GetRelatedEntity<AsyncOperation>("AsyncOperation_Emails", null); }
            set
            {
                OnPropertyChanging("AsyncOperation_Emails");
                SetRelatedEntity("AsyncOperation_Emails", null, value);
                OnPropertyChanged("AsyncOperation_Emails");
            }
        }

        /// <summary>
        ///     N:1 BulkOperation_Email
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("BulkOperation_Email")]
        public BulkOperation BulkOperation_Email
        {
            get { return GetRelatedEntity<BulkOperation>("BulkOperation_Email", null); }
            set
            {
                OnPropertyChanging("BulkOperation_Email");
                SetRelatedEntity("BulkOperation_Email", null, value);
                OnPropertyChanged("BulkOperation_Email");
            }
        }

        /// <summary>
        ///     N:1 business_unit_email_activities
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_email_activities")]
        public BusinessUnit business_unit_email_activities
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_email_activities", null); }
        }

        /// <summary>
        ///     N:1 Campaign_Emails
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Campaign_Emails")]
        public Campaign Campaign_Emails
        {
            get { return GetRelatedEntity<Campaign>("Campaign_Emails", null); }
            set
            {
                OnPropertyChanging("Campaign_Emails");
                SetRelatedEntity("Campaign_Emails", null, value);
                OnPropertyChanged("Campaign_Emails");
            }
        }

        /// <summary>
        ///     N:1 CampaignActivity_Emails
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("CampaignActivity_Emails")]
        public CampaignActivity CampaignActivity_Emails
        {
            get { return GetRelatedEntity<CampaignActivity>("CampaignActivity_Emails", null); }
            set
            {
                OnPropertyChanging("CampaignActivity_Emails");
                SetRelatedEntity("CampaignActivity_Emails", null, value);
                OnPropertyChanged("CampaignActivity_Emails");
            }
        }

        /// <summary>
        ///     N:1 Contact_Emails
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Contact_Emails")]
        public Contact Contact_Emails
        {
            get { return GetRelatedEntity<Contact>("Contact_Emails", null); }
            set
            {
                OnPropertyChanging("Contact_Emails");
                SetRelatedEntity("Contact_Emails", null, value);
                OnPropertyChanged("Contact_Emails");
            }
        }

        /// <summary>
        ///     N:1 Contract_Emails
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Contract_Emails")]
        public Contract Contract_Emails
        {
            get { return GetRelatedEntity<Contract>("Contract_Emails", null); }
            set
            {
                OnPropertyChanging("Contract_Emails");
                SetRelatedEntity("Contract_Emails", null, value);
                OnPropertyChanged("Contract_Emails");
            }
        }

        /// <summary>
        ///     N:1 email_email_parentactivityid
        /// </summary>
        [AttributeLogicalName("parentactivityid")]
        [RelationshipSchemaName("email_email_parentactivityid", EntityRole.Referencing)]
        public Email Referencingemail_email_parentactivityid
        {
            get { return GetRelatedEntity<Email>("email_email_parentactivityid", EntityRole.Referencing); }
            set
            {
                OnPropertyChanging("Referencingemail_email_parentactivityid");
                SetRelatedEntity("email_email_parentactivityid", EntityRole.Referencing, value);
                OnPropertyChanged("Referencingemail_email_parentactivityid");
            }
        }

        /// <summary>
        ///     N:1 email_sendermailboxid_mailbox
        /// </summary>
        [AttributeLogicalName("sendermailboxid")]
        [RelationshipSchemaName("email_sendermailboxid_mailbox")]
        public Mailbox email_sendermailboxid_mailbox
        {
            get { return GetRelatedEntity<Mailbox>("email_sendermailboxid_mailbox", null); }
        }

        /// <summary>
        ///     N:1 Incident_Emails
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Incident_Emails")]
        public Incident Incident_Emails
        {
            get { return GetRelatedEntity<Incident>("Incident_Emails", null); }
            set
            {
                OnPropertyChanging("Incident_Emails");
                SetRelatedEntity("Incident_Emails", null, value);
                OnPropertyChanged("Incident_Emails");
            }
        }

        /// <summary>
        ///     N:1 Invoice_Emails
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Invoice_Emails")]
        public Invoice Invoice_Emails
        {
            get { return GetRelatedEntity<Invoice>("Invoice_Emails", null); }
            set
            {
                OnPropertyChanging("Invoice_Emails");
                SetRelatedEntity("Invoice_Emails", null, value);
                OnPropertyChanged("Invoice_Emails");
            }
        }

        /// <summary>
        ///     N:1 Lead_Emails
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Lead_Emails")]
        public Lead Lead_Emails
        {
            get { return GetRelatedEntity<Lead>("Lead_Emails", null); }
            set
            {
                OnPropertyChanging("Lead_Emails");
                SetRelatedEntity("Lead_Emails", null, value);
                OnPropertyChanged("Lead_Emails");
            }
        }

        /// <summary>
        ///     N:1 lk_email_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_email_createdby")]
        public SystemUser lk_email_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_email_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_email_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_email_createdonbehalfby")]
        public SystemUser lk_email_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_email_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_email_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_email_modifiedby")]
        public SystemUser lk_email_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_email_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_email_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_email_modifiedonbehalfby")]
        public SystemUser lk_email_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_email_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 msdyn_postalbum_Emails
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("msdyn_postalbum_Emails")]
        public msdyn_PostAlbum msdyn_postalbum_Emails
        {
            get { return GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_Emails", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_Emails");
                SetRelatedEntity("msdyn_postalbum_Emails", null, value);
                OnPropertyChanged("msdyn_postalbum_Emails");
            }
        }

        /// <summary>
        ///     N:1 Opportunity_Emails
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Opportunity_Emails")]
        public Opportunity Opportunity_Emails
        {
            get { return GetRelatedEntity<Opportunity>("Opportunity_Emails", null); }
            set
            {
                OnPropertyChanging("Opportunity_Emails");
                SetRelatedEntity("Opportunity_Emails", null, value);
                OnPropertyChanged("Opportunity_Emails");
            }
        }

        /// <summary>
        ///     N:1 processstage_emails
        /// </summary>
        [AttributeLogicalName("stageid")]
        [RelationshipSchemaName("processstage_emails")]
        public ProcessStage processstage_emails
        {
            get { return GetRelatedEntity<ProcessStage>("processstage_emails", null); }
            set
            {
                OnPropertyChanging("processstage_emails");
                SetRelatedEntity("processstage_emails", null, value);
                OnPropertyChanged("processstage_emails");
            }
        }

        /// <summary>
        ///     N:1 Quote_Emails
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Quote_Emails")]
        public Quote Quote_Emails
        {
            get { return GetRelatedEntity<Quote>("Quote_Emails", null); }
            set
            {
                OnPropertyChanging("Quote_Emails");
                SetRelatedEntity("Quote_Emails", null, value);
                OnPropertyChanged("Quote_Emails");
            }
        }

        /// <summary>
        ///     N:1 SalesOrder_Emails
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SalesOrder_Emails")]
        public SalesOrder SalesOrder_Emails
        {
            get { return GetRelatedEntity<SalesOrder>("SalesOrder_Emails", null); }
            set
            {
                OnPropertyChanging("SalesOrder_Emails");
                SetRelatedEntity("SalesOrder_Emails", null, value);
                OnPropertyChanged("SalesOrder_Emails");
            }
        }

        /// <summary>
        ///     N:1 service_emails
        /// </summary>
        [AttributeLogicalName("serviceid")]
        [RelationshipSchemaName("service_emails")]
        public Service service_emails
        {
            get { return GetRelatedEntity<Service>("service_emails", null); }
            set
            {
                OnPropertyChanging("service_emails");
                SetRelatedEntity("service_emails", null, value);
                OnPropertyChanged("service_emails");
            }
        }

        /// <summary>
        ///     N:1 team_email
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_email")]
        public Team team_email
        {
            get { return GetRelatedEntity<Team>("team_email", null); }
        }

        /// <summary>
        ///     N:1 TransactionCurrency_Email
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("TransactionCurrency_Email")]
        public TransactionCurrency TransactionCurrency_Email
        {
            get { return GetRelatedEntity<TransactionCurrency>("TransactionCurrency_Email", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_Email");
                SetRelatedEntity("TransactionCurrency_Email", null, value);
                OnPropertyChanged("TransactionCurrency_Email");
            }
        }

        /// <summary>
        ///     N:1 user_email
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_email")]
        public SystemUser user_email
        {
            get { return GetRelatedEntity<SystemUser>("user_email", null); }
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