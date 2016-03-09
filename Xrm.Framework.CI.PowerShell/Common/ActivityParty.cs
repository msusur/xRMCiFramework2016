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
    ///     Person or group associated with an activity. An activity can have multiple activity parties.
    /// </summary>
    [DataContract]
    [EntityLogicalName("activityparty")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ActivityParty : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "activityparty";

        public const int EntityTypeCode = 135;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ActivityParty() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the activity associated with the activity party. (A "party" is any person who is associated
        ///     with an activity.)
        /// </summary>
        [AttributeLogicalName("activityid")]
        public EntityReference ActivityId
        {
            get { return GetAttributeValue<EntityReference>("activityid"); }
            set
            {
                OnPropertyChanging("ActivityId");
                SetAttributeValue("activityid", value);
                OnPropertyChanged("ActivityId");
            }
        }

        /// <summary>
        ///     Unique identifier of the activity party.
        /// </summary>
        [AttributeLogicalName("activitypartyid")]
        public Guid? ActivityPartyId
        {
            get { return GetAttributeValue<Guid?>("activitypartyid"); }
            set
            {
                OnPropertyChanging("ActivityPartyId");
                SetAttributeValue("activitypartyid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ActivityPartyId");
            }
        }

        [AttributeLogicalName("activitypartyid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ActivityPartyId = value; }
        }

        /// <summary>
        ///     Email address to which an email is delivered, and which is associated with the target entity.
        /// </summary>
        [AttributeLogicalName("addressused")]
        public string AddressUsed
        {
            get { return GetAttributeValue<string>("addressused"); }
            set
            {
                OnPropertyChanging("AddressUsed");
                SetAttributeValue("addressused", value);
                OnPropertyChanged("AddressUsed");
            }
        }

        /// <summary>
        ///     Information about whether to allow sending email to the activity party.
        /// </summary>
        [AttributeLogicalName("donotemail")]
        public bool? DoNotEmail
        {
            get { return GetAttributeValue<bool?>("donotemail"); }
        }

        /// <summary>
        ///     Information about whether to allow sending faxes to the activity party.
        /// </summary>
        [AttributeLogicalName("donotfax")]
        public bool? DoNotFax
        {
            get { return GetAttributeValue<bool?>("donotfax"); }
        }

        /// <summary>
        ///     Information about whether to allow phone calls to the lead.
        /// </summary>
        [AttributeLogicalName("donotphone")]
        public bool? DoNotPhone
        {
            get { return GetAttributeValue<bool?>("donotphone"); }
        }

        /// <summary>
        ///     Information about whether to allow sending postal mail to the lead.
        /// </summary>
        [AttributeLogicalName("donotpostalmail")]
        public bool? DoNotPostalMail
        {
            get { return GetAttributeValue<bool?>("donotpostalmail"); }
        }

        /// <summary>
        ///     Amount of effort used by the resource in a service appointment activity.
        /// </summary>
        [AttributeLogicalName("effort")]
        public double? Effort
        {
            get { return GetAttributeValue<double?>("effort"); }
            set
            {
                OnPropertyChanging("Effort");
                SetAttributeValue("effort", value);
                OnPropertyChanged("Effort");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("exchangeentryid")]
        public string ExchangeEntryId
        {
            get { return GetAttributeValue<string>("exchangeentryid"); }
            set
            {
                OnPropertyChanging("ExchangeEntryId");
                SetAttributeValue("exchangeentryid", value);
                OnPropertyChanged("ExchangeEntryId");
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
        ///     Information about whether the underlying entity record is deleted.
        /// </summary>
        [AttributeLogicalName("ispartydeleted")]
        public bool? IsPartyDeleted
        {
            get { return GetAttributeValue<bool?>("ispartydeleted"); }
        }

        /// <summary>
        ///     Unique identifier of the user or team who owns the activity_party.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId
        {
            get { return GetAttributeValue<EntityReference>("ownerid"); }
        }

        /// <summary>
        ///     Role of the person in the activity, such as sender, to, cc, bcc, required, optional, organizer, regarding, or
        ///     owner.
        /// </summary>
        [AttributeLogicalName("participationtypemask")]
        public OptionSetValue ParticipationTypeMask
        {
            get { return GetAttributeValue<OptionSetValue>("participationtypemask"); }
            set
            {
                OnPropertyChanging("ParticipationTypeMask");
                SetAttributeValue("participationtypemask", value);
                OnPropertyChanged("ParticipationTypeMask");
            }
        }

        /// <summary>
        ///     Unique identifier of the party associated with the activity.
        /// </summary>
        [AttributeLogicalName("partyid")]
        public EntityReference PartyId
        {
            get { return GetAttributeValue<EntityReference>("partyid"); }
            set
            {
                OnPropertyChanging("PartyId");
                SetAttributeValue("partyid", value);
                OnPropertyChanged("PartyId");
            }
        }

        /// <summary>
        ///     Unique identifier of the resource specification for the activity party.
        /// </summary>
        [AttributeLogicalName("resourcespecid")]
        public EntityReference ResourceSpecId
        {
            get { return GetAttributeValue<EntityReference>("resourcespecid"); }
            set
            {
                OnPropertyChanging("ResourceSpecId");
                SetAttributeValue("resourcespecid", value);
                OnPropertyChanged("ResourceSpecId");
            }
        }

        /// <summary>
        ///     Scheduled end time of the activity.
        /// </summary>
        [AttributeLogicalName("scheduledend")]
        public DateTime? ScheduledEnd
        {
            get { return GetAttributeValue<DateTime?>("scheduledend"); }
        }

        /// <summary>
        ///     Scheduled start time of the activity.
        /// </summary>
        [AttributeLogicalName("scheduledstart")]
        public DateTime? ScheduledStart
        {
            get { return GetAttributeValue<DateTime?>("scheduledstart"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N userentityinstancedata_activityparty
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_activityparty")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_activityparty
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_activityparty", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_activityparty");
                SetRelatedEntities("userentityinstancedata_activityparty", null, value);
                OnPropertyChanged("userentityinstancedata_activityparty");
            }
        }

        /// <summary>
        ///     N:1 account_activity_parties
        /// </summary>
        [AttributeLogicalName("partyid")]
        [RelationshipSchemaName("account_activity_parties")]
        public Account account_activity_parties
        {
            get { return GetRelatedEntity<Account>("account_activity_parties", null); }
            set
            {
                OnPropertyChanging("account_activity_parties");
                SetRelatedEntity("account_activity_parties", null, value);
                OnPropertyChanged("account_activity_parties");
            }
        }

        /// <summary>
        ///     N:1 ActivityPartyResourceSpec
        /// </summary>
        [AttributeLogicalName("resourcespecid")]
        [RelationshipSchemaName("ActivityPartyResourceSpec")]
        public ResourceSpec ActivityPartyResourceSpec
        {
            get { return GetRelatedEntity<ResourceSpec>("ActivityPartyResourceSpec", null); }
            set
            {
                OnPropertyChanging("ActivityPartyResourceSpec");
                SetRelatedEntity("ActivityPartyResourceSpec", null, value);
                OnPropertyChanged("ActivityPartyResourceSpec");
            }
        }

        /// <summary>
        ///     N:1 activitypointer_activity_parties
        /// </summary>
        [AttributeLogicalName("activityid")]
        [RelationshipSchemaName("activitypointer_activity_parties")]
        public ActivityPointer activitypointer_activity_parties
        {
            get { return GetRelatedEntity<ActivityPointer>("activitypointer_activity_parties", null); }
            set
            {
                OnPropertyChanging("activitypointer_activity_parties");
                SetRelatedEntity("activitypointer_activity_parties", null, value);
                OnPropertyChanged("activitypointer_activity_parties");
            }
        }

        /// <summary>
        ///     N:1 appointment_activity_parties
        /// </summary>
        [AttributeLogicalName("activityid")]
        [RelationshipSchemaName("appointment_activity_parties")]
        public Appointment appointment_activity_parties
        {
            get { return GetRelatedEntity<Appointment>("appointment_activity_parties", null); }
            set
            {
                OnPropertyChanging("appointment_activity_parties");
                SetRelatedEntity("appointment_activity_parties", null, value);
                OnPropertyChanged("appointment_activity_parties");
            }
        }

        /// <summary>
        ///     N:1 bulkoperation_activity_parties
        /// </summary>
        [AttributeLogicalName("partyid")]
        [RelationshipSchemaName("bulkoperation_activity_parties")]
        public BulkOperation bulkoperation_activity_parties
        {
            get { return GetRelatedEntity<BulkOperation>("bulkoperation_activity_parties", null); }
            set
            {
                OnPropertyChanging("bulkoperation_activity_parties");
                SetRelatedEntity("bulkoperation_activity_parties", null, value);
                OnPropertyChanged("bulkoperation_activity_parties");
            }
        }

        /// <summary>
        ///     N:1 campaign_activity_parties
        /// </summary>
        [AttributeLogicalName("partyid")]
        [RelationshipSchemaName("campaign_activity_parties")]
        public Campaign campaign_activity_parties
        {
            get { return GetRelatedEntity<Campaign>("campaign_activity_parties", null); }
            set
            {
                OnPropertyChanging("campaign_activity_parties");
                SetRelatedEntity("campaign_activity_parties", null, value);
                OnPropertyChanged("campaign_activity_parties");
            }
        }

        /// <summary>
        ///     N:1 campaignactivity_activity_parties
        /// </summary>
        [AttributeLogicalName("activityid")]
        [RelationshipSchemaName("campaignactivity_activity_parties")]
        public CampaignActivity campaignactivity_activity_parties
        {
            get { return GetRelatedEntity<CampaignActivity>("campaignactivity_activity_parties", null); }
            set
            {
                OnPropertyChanging("campaignactivity_activity_parties");
                SetRelatedEntity("campaignactivity_activity_parties", null, value);
                OnPropertyChanged("campaignactivity_activity_parties");
            }
        }

        /// <summary>
        ///     N:1 campaignactivity_activityparties
        /// </summary>
        [AttributeLogicalName("partyid")]
        [RelationshipSchemaName("campaignactivity_activityparties")]
        public CampaignActivity campaignactivity_activityparties
        {
            get { return GetRelatedEntity<CampaignActivity>("campaignactivity_activityparties", null); }
            set
            {
                OnPropertyChanging("campaignactivity_activityparties");
                SetRelatedEntity("campaignactivity_activityparties", null, value);
                OnPropertyChanged("campaignactivity_activityparties");
            }
        }

        /// <summary>
        ///     N:1 campaignresponse_activity_parties
        /// </summary>
        [AttributeLogicalName("activityid")]
        [RelationshipSchemaName("campaignresponse_activity_parties")]
        public CampaignResponse campaignresponse_activity_parties
        {
            get { return GetRelatedEntity<CampaignResponse>("campaignresponse_activity_parties", null); }
            set
            {
                OnPropertyChanging("campaignresponse_activity_parties");
                SetRelatedEntity("campaignresponse_activity_parties", null, value);
                OnPropertyChanged("campaignresponse_activity_parties");
            }
        }

        /// <summary>
        ///     N:1 contact_activity_parties
        /// </summary>
        [AttributeLogicalName("partyid")]
        [RelationshipSchemaName("contact_activity_parties")]
        public Contact contact_activity_parties
        {
            get { return GetRelatedEntity<Contact>("contact_activity_parties", null); }
            set
            {
                OnPropertyChanging("contact_activity_parties");
                SetRelatedEntity("contact_activity_parties", null, value);
                OnPropertyChanged("contact_activity_parties");
            }
        }

        /// <summary>
        ///     N:1 contract_activity_parties
        /// </summary>
        [AttributeLogicalName("partyid")]
        [RelationshipSchemaName("contract_activity_parties")]
        public Contract contract_activity_parties
        {
            get { return GetRelatedEntity<Contract>("contract_activity_parties", null); }
            set
            {
                OnPropertyChanging("contract_activity_parties");
                SetRelatedEntity("contract_activity_parties", null, value);
                OnPropertyChanged("contract_activity_parties");
            }
        }

        /// <summary>
        ///     N:1 email_activity_parties
        /// </summary>
        [AttributeLogicalName("activityid")]
        [RelationshipSchemaName("email_activity_parties")]
        public Email email_activity_parties
        {
            get { return GetRelatedEntity<Email>("email_activity_parties", null); }
            set
            {
                OnPropertyChanging("email_activity_parties");
                SetRelatedEntity("email_activity_parties", null, value);
                OnPropertyChanged("email_activity_parties");
            }
        }

        /// <summary>
        ///     N:1 equipment_activity_parties
        /// </summary>
        [AttributeLogicalName("partyid")]
        [RelationshipSchemaName("equipment_activity_parties")]
        public Equipment equipment_activity_parties
        {
            get { return GetRelatedEntity<Equipment>("equipment_activity_parties", null); }
            set
            {
                OnPropertyChanging("equipment_activity_parties");
                SetRelatedEntity("equipment_activity_parties", null, value);
                OnPropertyChanged("equipment_activity_parties");
            }
        }

        /// <summary>
        ///     N:1 fax_activity_parties
        /// </summary>
        [AttributeLogicalName("activityid")]
        [RelationshipSchemaName("fax_activity_parties")]
        public Fax fax_activity_parties
        {
            get { return GetRelatedEntity<Fax>("fax_activity_parties", null); }
            set
            {
                OnPropertyChanging("fax_activity_parties");
                SetRelatedEntity("fax_activity_parties", null, value);
                OnPropertyChanged("fax_activity_parties");
            }
        }

        /// <summary>
        ///     N:1 incident_activity_parties
        /// </summary>
        [AttributeLogicalName("partyid")]
        [RelationshipSchemaName("incident_activity_parties")]
        public Incident incident_activity_parties
        {
            get { return GetRelatedEntity<Incident>("incident_activity_parties", null); }
            set
            {
                OnPropertyChanging("incident_activity_parties");
                SetRelatedEntity("incident_activity_parties", null, value);
                OnPropertyChanged("incident_activity_parties");
            }
        }

        /// <summary>
        ///     N:1 incidentresolution_activity_parties
        /// </summary>
        [AttributeLogicalName("activityid")]
        [RelationshipSchemaName("incidentresolution_activity_parties")]
        public IncidentResolution incidentresolution_activity_parties
        {
            get { return GetRelatedEntity<IncidentResolution>("incidentresolution_activity_parties", null); }
            set
            {
                OnPropertyChanging("incidentresolution_activity_parties");
                SetRelatedEntity("incidentresolution_activity_parties", null, value);
                OnPropertyChanged("incidentresolution_activity_parties");
            }
        }

        /// <summary>
        ///     N:1 invoice_activity_parties
        /// </summary>
        [AttributeLogicalName("partyid")]
        [RelationshipSchemaName("invoice_activity_parties")]
        public Invoice invoice_activity_parties
        {
            get { return GetRelatedEntity<Invoice>("invoice_activity_parties", null); }
            set
            {
                OnPropertyChanging("invoice_activity_parties");
                SetRelatedEntity("invoice_activity_parties", null, value);
                OnPropertyChanged("invoice_activity_parties");
            }
        }

        /// <summary>
        ///     N:1 lead_activity_parties
        /// </summary>
        [AttributeLogicalName("partyid")]
        [RelationshipSchemaName("lead_activity_parties")]
        public Lead lead_activity_parties
        {
            get { return GetRelatedEntity<Lead>("lead_activity_parties", null); }
            set
            {
                OnPropertyChanging("lead_activity_parties");
                SetRelatedEntity("lead_activity_parties", null, value);
                OnPropertyChanged("lead_activity_parties");
            }
        }

        /// <summary>
        ///     N:1 letter_activity_parties
        /// </summary>
        [AttributeLogicalName("activityid")]
        [RelationshipSchemaName("letter_activity_parties")]
        public Letter letter_activity_parties
        {
            get { return GetRelatedEntity<Letter>("letter_activity_parties", null); }
            set
            {
                OnPropertyChanging("letter_activity_parties");
                SetRelatedEntity("letter_activity_parties", null, value);
                OnPropertyChanged("letter_activity_parties");
            }
        }

        /// <summary>
        ///     N:1 opportunity_activity_parties
        /// </summary>
        [AttributeLogicalName("partyid")]
        [RelationshipSchemaName("opportunity_activity_parties")]
        public Opportunity opportunity_activity_parties
        {
            get { return GetRelatedEntity<Opportunity>("opportunity_activity_parties", null); }
            set
            {
                OnPropertyChanging("opportunity_activity_parties");
                SetRelatedEntity("opportunity_activity_parties", null, value);
                OnPropertyChanged("opportunity_activity_parties");
            }
        }

        /// <summary>
        ///     N:1 opportunityclose_activity_parties
        /// </summary>
        [AttributeLogicalName("activityid")]
        [RelationshipSchemaName("opportunityclose_activity_parties")]
        public OpportunityClose opportunityclose_activity_parties
        {
            get { return GetRelatedEntity<OpportunityClose>("opportunityclose_activity_parties", null); }
            set
            {
                OnPropertyChanging("opportunityclose_activity_parties");
                SetRelatedEntity("opportunityclose_activity_parties", null, value);
                OnPropertyChanged("opportunityclose_activity_parties");
            }
        }

        /// <summary>
        ///     N:1 orderclose_activity_parties
        /// </summary>
        [AttributeLogicalName("activityid")]
        [RelationshipSchemaName("orderclose_activity_parties")]
        public OrderClose orderclose_activity_parties
        {
            get { return GetRelatedEntity<OrderClose>("orderclose_activity_parties", null); }
            set
            {
                OnPropertyChanging("orderclose_activity_parties");
                SetRelatedEntity("orderclose_activity_parties", null, value);
                OnPropertyChanged("orderclose_activity_parties");
            }
        }

        /// <summary>
        ///     N:1 phonecall_activity_parties
        /// </summary>
        [AttributeLogicalName("activityid")]
        [RelationshipSchemaName("phonecall_activity_parties")]
        public PhoneCall phonecall_activity_parties
        {
            get { return GetRelatedEntity<PhoneCall>("phonecall_activity_parties", null); }
            set
            {
                OnPropertyChanging("phonecall_activity_parties");
                SetRelatedEntity("phonecall_activity_parties", null, value);
                OnPropertyChanged("phonecall_activity_parties");
            }
        }

        /// <summary>
        ///     N:1 queue_activity_parties
        /// </summary>
        [AttributeLogicalName("partyid")]
        [RelationshipSchemaName("queue_activity_parties")]
        public Queue queue_activity_parties
        {
            get { return GetRelatedEntity<Queue>("queue_activity_parties", null); }
            set
            {
                OnPropertyChanging("queue_activity_parties");
                SetRelatedEntity("queue_activity_parties", null, value);
                OnPropertyChanged("queue_activity_parties");
            }
        }

        /// <summary>
        ///     N:1 quote_activity_parties
        /// </summary>
        [AttributeLogicalName("partyid")]
        [RelationshipSchemaName("quote_activity_parties")]
        public Quote quote_activity_parties
        {
            get { return GetRelatedEntity<Quote>("quote_activity_parties", null); }
            set
            {
                OnPropertyChanging("quote_activity_parties");
                SetRelatedEntity("quote_activity_parties", null, value);
                OnPropertyChanged("quote_activity_parties");
            }
        }

        /// <summary>
        ///     N:1 quoteclose_activity_parties
        /// </summary>
        [AttributeLogicalName("activityid")]
        [RelationshipSchemaName("quoteclose_activity_parties")]
        public QuoteClose quoteclose_activity_parties
        {
            get { return GetRelatedEntity<QuoteClose>("quoteclose_activity_parties", null); }
            set
            {
                OnPropertyChanging("quoteclose_activity_parties");
                SetRelatedEntity("quoteclose_activity_parties", null, value);
                OnPropertyChanged("quoteclose_activity_parties");
            }
        }

        /// <summary>
        ///     N:1 recurringappointmentmaster_activity_parties
        /// </summary>
        [AttributeLogicalName("activityid")]
        [RelationshipSchemaName("recurringappointmentmaster_activity_parties")]
        public RecurringAppointmentMaster recurringappointmentmaster_activity_parties
        {
            get
            {
                return GetRelatedEntity<RecurringAppointmentMaster>("recurringappointmentmaster_activity_parties", null);
            }
            set
            {
                OnPropertyChanging("recurringappointmentmaster_activity_parties");
                SetRelatedEntity("recurringappointmentmaster_activity_parties", null, value);
                OnPropertyChanged("recurringappointmentmaster_activity_parties");
            }
        }

        /// <summary>
        ///     N:1 salesorder_activity_parties
        /// </summary>
        [AttributeLogicalName("partyid")]
        [RelationshipSchemaName("salesorder_activity_parties")]
        public SalesOrder salesorder_activity_parties
        {
            get { return GetRelatedEntity<SalesOrder>("salesorder_activity_parties", null); }
            set
            {
                OnPropertyChanging("salesorder_activity_parties");
                SetRelatedEntity("salesorder_activity_parties", null, value);
                OnPropertyChanged("salesorder_activity_parties");
            }
        }

        /// <summary>
        ///     N:1 serviceappointment_activity_parties
        /// </summary>
        [AttributeLogicalName("activityid")]
        [RelationshipSchemaName("serviceappointment_activity_parties")]
        public ServiceAppointment serviceappointment_activity_parties
        {
            get { return GetRelatedEntity<ServiceAppointment>("serviceappointment_activity_parties", null); }
            set
            {
                OnPropertyChanging("serviceappointment_activity_parties");
                SetRelatedEntity("serviceappointment_activity_parties", null, value);
                OnPropertyChanged("serviceappointment_activity_parties");
            }
        }

        /// <summary>
        ///     N:1 system_user_activity_parties
        /// </summary>
        [AttributeLogicalName("partyid")]
        [RelationshipSchemaName("system_user_activity_parties")]
        public SystemUser system_user_activity_parties
        {
            get { return GetRelatedEntity<SystemUser>("system_user_activity_parties", null); }
            set
            {
                OnPropertyChanging("system_user_activity_parties");
                SetRelatedEntity("system_user_activity_parties", null, value);
                OnPropertyChanged("system_user_activity_parties");
            }
        }

        /// <summary>
        ///     N:1 task_activity_parties
        /// </summary>
        [AttributeLogicalName("activityid")]
        [RelationshipSchemaName("task_activity_parties")]
        public Task task_activity_parties
        {
            get { return GetRelatedEntity<Task>("task_activity_parties", null); }
            set
            {
                OnPropertyChanging("task_activity_parties");
                SetRelatedEntity("task_activity_parties", null, value);
                OnPropertyChanged("task_activity_parties");
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