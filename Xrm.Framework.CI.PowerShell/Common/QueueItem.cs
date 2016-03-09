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
    ///     A specific item in a queue, such as a case record or an activity record.
    /// </summary>
    [DataContract]
    [EntityLogicalName("queueitem")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class QueueItem : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "queueitem";

        public const int EntityTypeCode = 2029;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public QueueItem() :
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
        ///     Shows the date the record was assigned to the queue.
        /// </summary>
        [AttributeLogicalName("enteredon")]
        public DateTime? EnteredOn
        {
            get { return GetAttributeValue<DateTime?>("enteredon"); }
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
        ///     Unique identifier of the delegate user who last modified the queueitem.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Choose the activity, case, or article assigned to the queue.
        /// </summary>
        [AttributeLogicalName("objectid")]
        public EntityReference ObjectId
        {
            get { return GetAttributeValue<EntityReference>("objectid"); }
            set
            {
                OnPropertyChanging("ObjectId");
                SetAttributeValue("objectid", value);
                OnPropertyChanged("ObjectId");
            }
        }

        /// <summary>
        ///     Select the type of the queue item, such as activity, case, or appointment.
        /// </summary>
        [AttributeLogicalName("objecttypecode")]
        public OptionSetValue ObjectTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("objecttypecode"); }
        }

        /// <summary>
        ///     Unique identifier of the organization with which the queue item is associated.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
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
        ///     Unique identifier of the user or team who owns the queue item.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId
        {
            get { return GetAttributeValue<EntityReference>("ownerid"); }
        }

        /// <summary>
        ///     Unique identifier of the business unit that owns the queue item.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the queue item.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Priority of the queue item.
        /// </summary>
        [AttributeLogicalName("priority")]
        [Obsolete]
        public int? Priority
        {
            get { return GetAttributeValue<int?>("priority"); }
            set
            {
                OnPropertyChanging("Priority");
                SetAttributeValue("priority", value);
                OnPropertyChanged("Priority");
            }
        }

        /// <summary>
        ///     Choose the queue that the item is assigned to.
        /// </summary>
        [AttributeLogicalName("queueid")]
        public EntityReference QueueId
        {
            get { return GetAttributeValue<EntityReference>("queueid"); }
            set
            {
                OnPropertyChanging("QueueId");
                SetAttributeValue("queueid", value);
                OnPropertyChanged("QueueId");
            }
        }

        /// <summary>
        ///     Unique identifier of the queue item.
        /// </summary>
        [AttributeLogicalName("queueitemid")]
        public Guid? QueueItemId
        {
            get { return GetAttributeValue<Guid?>("queueitemid"); }
            set
            {
                OnPropertyChanging("QueueItemId");
                SetAttributeValue("queueitemid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("QueueItemId");
            }
        }

        [AttributeLogicalName("queueitemid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { QueueItemId = value; }
        }

        /// <summary>
        ///     Sender who created the queue item.
        /// </summary>
        [AttributeLogicalName("sender")]
        [Obsolete]
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
        ///     Status of the queue item.
        /// </summary>
        [AttributeLogicalName("state")]
        [Obsolete]
        public int? State
        {
            get { return GetAttributeValue<int?>("state"); }
            set
            {
                OnPropertyChanging("State");
                SetAttributeValue("state", value);
                OnPropertyChanged("State");
            }
        }

        /// <summary>
        ///     Shows whether the queue record is active or inactive. Inactive queue records are read-only and can't be edited
        ///     unless they are reactivated.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public QueueItemState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((QueueItemState) (Enum.ToObject(typeof (QueueItemState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the queue item.
        /// </summary>
        [AttributeLogicalName("status")]
        [Obsolete]
        public int? Status
        {
            get { return GetAttributeValue<int?>("status"); }
            set
            {
                OnPropertyChanging("Status");
                SetAttributeValue("status", value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        ///     Select the item's status.
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
        ///     Shows the title or name that describes the queue record. This value is copied from the record that was assigned to
        ///     the queue.
        /// </summary>
        [AttributeLogicalName("title")]
        public string Title
        {
            get { return GetAttributeValue<string>("title"); }
        }

        /// <summary>
        ///     Recipients listed on the To line of the message for email queue items.
        /// </summary>
        [AttributeLogicalName("torecipients")]
        [Obsolete]
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
        ///     Version number of the queue item.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     Shows who is working on the queue item.
        /// </summary>
        [AttributeLogicalName("workerid")]
        public EntityReference WorkerId
        {
            get { return GetAttributeValue<EntityReference>("workerid"); }
            set
            {
                OnPropertyChanging("WorkerId");
                SetAttributeValue("workerid", value);
                OnPropertyChanged("WorkerId");
            }
        }

        /// <summary>
        ///     Shows the date and time when the queue item was last assigned to a user.
        /// </summary>
        [AttributeLogicalName("workeridmodifiedon")]
        public DateTime? WorkerIdModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("workeridmodifiedon"); }
        }

        /// <summary>
        ///     1:N QueueItem_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("QueueItem_AsyncOperations")]
        public IEnumerable<AsyncOperation> QueueItem_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("QueueItem_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("QueueItem_AsyncOperations");
                SetRelatedEntities("QueueItem_AsyncOperations", null, value);
                OnPropertyChanged("QueueItem_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N QueueItem_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("QueueItem_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> QueueItem_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("QueueItem_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("QueueItem_BulkDeleteFailures");
                SetRelatedEntities("QueueItem_BulkDeleteFailures", null, value);
                OnPropertyChanged("QueueItem_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N queueitem_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("queueitem_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> queueitem_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntities<PrincipalObjectAttributeAccess>("queueitem_principalobjectattributeaccess",
                    null);
            }
            set
            {
                OnPropertyChanging("queueitem_principalobjectattributeaccess");
                SetRelatedEntities("queueitem_principalobjectattributeaccess", null, value);
                OnPropertyChanged("queueitem_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N QueueItem_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("QueueItem_ProcessSessions")]
        public IEnumerable<ProcessSession> QueueItem_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("QueueItem_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("QueueItem_ProcessSessions");
                SetRelatedEntities("QueueItem_ProcessSessions", null, value);
                OnPropertyChanged("QueueItem_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_queueitem
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_queueitem")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_queueitem
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_queueitem", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_queueitem");
                SetRelatedEntities("userentityinstancedata_queueitem", null, value);
                OnPropertyChanged("userentityinstancedata_queueitem");
            }
        }

        /// <summary>
        ///     N:1 ActivityPointer_QueueItem
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("ActivityPointer_QueueItem")]
        public ActivityPointer ActivityPointer_QueueItem
        {
            get { return GetRelatedEntity<ActivityPointer>("ActivityPointer_QueueItem", null); }
            set
            {
                OnPropertyChanging("ActivityPointer_QueueItem");
                SetRelatedEntity("ActivityPointer_QueueItem", null, value);
                OnPropertyChanged("ActivityPointer_QueueItem");
            }
        }

        /// <summary>
        ///     N:1 Appointment_QueueItem
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("Appointment_QueueItem")]
        public Appointment Appointment_QueueItem
        {
            get { return GetRelatedEntity<Appointment>("Appointment_QueueItem", null); }
            set
            {
                OnPropertyChanging("Appointment_QueueItem");
                SetRelatedEntity("Appointment_QueueItem", null, value);
                OnPropertyChanged("Appointment_QueueItem");
            }
        }

        /// <summary>
        ///     N:1 BulkOperation_QueueItem
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("BulkOperation_QueueItem")]
        public BulkOperation BulkOperation_QueueItem
        {
            get { return GetRelatedEntity<BulkOperation>("BulkOperation_QueueItem", null); }
            set
            {
                OnPropertyChanging("BulkOperation_QueueItem");
                SetRelatedEntity("BulkOperation_QueueItem", null, value);
                OnPropertyChanged("BulkOperation_QueueItem");
            }
        }

        /// <summary>
        ///     N:1 CampaignActivity_QueueItem
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("CampaignActivity_QueueItem")]
        public CampaignActivity CampaignActivity_QueueItem
        {
            get { return GetRelatedEntity<CampaignActivity>("CampaignActivity_QueueItem", null); }
            set
            {
                OnPropertyChanging("CampaignActivity_QueueItem");
                SetRelatedEntity("CampaignActivity_QueueItem", null, value);
                OnPropertyChanged("CampaignActivity_QueueItem");
            }
        }

        /// <summary>
        ///     N:1 CampaignResponse_QueueItem
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("CampaignResponse_QueueItem")]
        public CampaignResponse CampaignResponse_QueueItem
        {
            get { return GetRelatedEntity<CampaignResponse>("CampaignResponse_QueueItem", null); }
            set
            {
                OnPropertyChanging("CampaignResponse_QueueItem");
                SetRelatedEntity("CampaignResponse_QueueItem", null, value);
                OnPropertyChanged("CampaignResponse_QueueItem");
            }
        }

        /// <summary>
        ///     N:1 Email_QueueItem
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("Email_QueueItem")]
        public Email Email_QueueItem
        {
            get { return GetRelatedEntity<Email>("Email_QueueItem", null); }
            set
            {
                OnPropertyChanging("Email_QueueItem");
                SetRelatedEntity("Email_QueueItem", null, value);
                OnPropertyChanged("Email_QueueItem");
            }
        }

        /// <summary>
        ///     N:1 Fax_QueueItem
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("Fax_QueueItem")]
        public Fax Fax_QueueItem
        {
            get { return GetRelatedEntity<Fax>("Fax_QueueItem", null); }
            set
            {
                OnPropertyChanging("Fax_QueueItem");
                SetRelatedEntity("Fax_QueueItem", null, value);
                OnPropertyChanged("Fax_QueueItem");
            }
        }

        /// <summary>
        ///     N:1 Incident_QueueItem
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("Incident_QueueItem")]
        public Incident Incident_QueueItem
        {
            get { return GetRelatedEntity<Incident>("Incident_QueueItem", null); }
            set
            {
                OnPropertyChanging("Incident_QueueItem");
                SetRelatedEntity("Incident_QueueItem", null, value);
                OnPropertyChanged("Incident_QueueItem");
            }
        }

        /// <summary>
        ///     N:1 Letter_QueueItem
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("Letter_QueueItem")]
        public Letter Letter_QueueItem
        {
            get { return GetRelatedEntity<Letter>("Letter_QueueItem", null); }
            set
            {
                OnPropertyChanging("Letter_QueueItem");
                SetRelatedEntity("Letter_QueueItem", null, value);
                OnPropertyChanged("Letter_QueueItem");
            }
        }

        /// <summary>
        ///     N:1 lk_queueitem_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_queueitem_createdonbehalfby")]
        public SystemUser lk_queueitem_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_queueitem_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_queueitem_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_queueitem_modifiedonbehalfby")]
        public SystemUser lk_queueitem_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_queueitem_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_queueitembase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_queueitembase_createdby")]
        public SystemUser lk_queueitembase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_queueitembase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_queueitembase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_queueitembase_modifiedby")]
        public SystemUser lk_queueitembase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_queueitembase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_queueitembase_workerid
        /// </summary>
        [AttributeLogicalName("workerid")]
        [RelationshipSchemaName("lk_queueitembase_workerid")]
        public SystemUser lk_queueitembase_workerid
        {
            get { return GetRelatedEntity<SystemUser>("lk_queueitembase_workerid", null); }
            set
            {
                OnPropertyChanging("lk_queueitembase_workerid");
                SetRelatedEntity("lk_queueitembase_workerid", null, value);
                OnPropertyChanged("lk_queueitembase_workerid");
            }
        }

        /// <summary>
        ///     N:1 organization_queueitems
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_queueitems")]
        public Organization organization_queueitems
        {
            get { return GetRelatedEntity<Organization>("organization_queueitems", null); }
        }

        /// <summary>
        ///     N:1 PhoneCall_QueueItem
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("PhoneCall_QueueItem")]
        public PhoneCall PhoneCall_QueueItem
        {
            get { return GetRelatedEntity<PhoneCall>("PhoneCall_QueueItem", null); }
            set
            {
                OnPropertyChanging("PhoneCall_QueueItem");
                SetRelatedEntity("PhoneCall_QueueItem", null, value);
                OnPropertyChanged("PhoneCall_QueueItem");
            }
        }

        /// <summary>
        ///     N:1 queue_entries
        /// </summary>
        [AttributeLogicalName("queueid")]
        [RelationshipSchemaName("queue_entries")]
        public Queue queue_entries
        {
            get { return GetRelatedEntity<Queue>("queue_entries", null); }
            set
            {
                OnPropertyChanging("queue_entries");
                SetRelatedEntity("queue_entries", null, value);
                OnPropertyChanged("queue_entries");
            }
        }

        /// <summary>
        ///     N:1 RecurringAppointmentMaster_QueueItem
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("RecurringAppointmentMaster_QueueItem")]
        public RecurringAppointmentMaster RecurringAppointmentMaster_QueueItem
        {
            get { return GetRelatedEntity<RecurringAppointmentMaster>("RecurringAppointmentMaster_QueueItem", null); }
            set
            {
                OnPropertyChanging("RecurringAppointmentMaster_QueueItem");
                SetRelatedEntity("RecurringAppointmentMaster_QueueItem", null, value);
                OnPropertyChanged("RecurringAppointmentMaster_QueueItem");
            }
        }

        /// <summary>
        ///     N:1 ServiceAppointment_QueueItem
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("ServiceAppointment_QueueItem")]
        public ServiceAppointment ServiceAppointment_QueueItem
        {
            get { return GetRelatedEntity<ServiceAppointment>("ServiceAppointment_QueueItem", null); }
            set
            {
                OnPropertyChanging("ServiceAppointment_QueueItem");
                SetRelatedEntity("ServiceAppointment_QueueItem", null, value);
                OnPropertyChanged("ServiceAppointment_QueueItem");
            }
        }

        /// <summary>
        ///     N:1 Task_QueueItem
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("Task_QueueItem")]
        public Task Task_QueueItem
        {
            get { return GetRelatedEntity<Task>("Task_QueueItem", null); }
            set
            {
                OnPropertyChanging("Task_QueueItem");
                SetRelatedEntity("Task_QueueItem", null, value);
                OnPropertyChanged("Task_QueueItem");
            }
        }

        /// <summary>
        ///     N:1 team_queueitembase_workerid
        /// </summary>
        [AttributeLogicalName("workerid")]
        [RelationshipSchemaName("team_queueitembase_workerid")]
        public Team team_queueitembase_workerid
        {
            get { return GetRelatedEntity<Team>("team_queueitembase_workerid", null); }
            set
            {
                OnPropertyChanging("team_queueitembase_workerid");
                SetRelatedEntity("team_queueitembase_workerid", null, value);
                OnPropertyChanged("team_queueitembase_workerid");
            }
        }

        /// <summary>
        ///     N:1 TransactionCurrency_QueueItem
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("TransactionCurrency_QueueItem")]
        public TransactionCurrency TransactionCurrency_QueueItem
        {
            get { return GetRelatedEntity<TransactionCurrency>("TransactionCurrency_QueueItem", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_QueueItem");
                SetRelatedEntity("TransactionCurrency_QueueItem", null, value);
                OnPropertyChanged("TransactionCurrency_QueueItem");
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