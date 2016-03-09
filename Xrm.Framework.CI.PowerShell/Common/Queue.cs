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
    ///     A list of records requiring action, such as accounts, cases, and activities.
    /// </summary>
    [DataContract]
    [EntityLogicalName("queue")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Queue : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "queue";

        public const int EntityTypeCode = 2020;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Queue() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Choose whether to allow server-side synchronization or the Email Router to use credentials for email processing.
        /// </summary>
        [AttributeLogicalName("allowemailcredentials")]
        [Obsolete]
        public bool? AllowEmailCredentials
        {
            get { return GetAttributeValue<bool?>("allowemailcredentials"); }
        }

        /// <summary>
        ///     Unique identifier of the business unit with which the queue is associated.
        /// </summary>
        [AttributeLogicalName("businessunitid")]
        [Obsolete]
        public EntityReference BusinessUnitId
        {
            get { return GetAttributeValue<EntityReference>("businessunitid"); }
            set
            {
                OnPropertyChanging("BusinessUnitId");
                SetAttributeValue("businessunitid", value);
                OnPropertyChanged("BusinessUnitId");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the queue record.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the queue was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the queue.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Select the mailbox associated with this queue.
        /// </summary>
        [AttributeLogicalName("defaultmailbox")]
        public EntityReference DefaultMailbox
        {
            get { return GetAttributeValue<EntityReference>("defaultmailbox"); }
        }

        /// <summary>
        ///     Description of the queue.
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
        ///     Email address that is associated with the queue.
        /// </summary>
        [AttributeLogicalName("emailaddress")]
        public string EMailAddress
        {
            get { return GetAttributeValue<string>("emailaddress"); }
            set
            {
                OnPropertyChanging("EMailAddress");
                SetAttributeValue("emailaddress", value);
                OnPropertyChanged("EMailAddress");
            }
        }

        /// <summary>
        ///     Password for email.
        /// </summary>
        [AttributeLogicalName("emailpassword")]
        [Obsolete]
        public string EmailPassword
        {
            get { return GetAttributeValue<string>("emailpassword"); }
        }

        /// <summary>
        ///     Shows the status of the primary email address.
        /// </summary>
        [AttributeLogicalName("emailrouteraccessapproval")]
        public OptionSetValue EmailRouterAccessApproval
        {
            get { return GetAttributeValue<OptionSetValue>("emailrouteraccessapproval"); }
            set
            {
                OnPropertyChanging("EmailRouterAccessApproval");
                SetAttributeValue("emailrouteraccessapproval", value);
                OnPropertyChanged("EmailRouterAccessApproval");
            }
        }

        /// <summary>
        ///     User name for email.
        /// </summary>
        [AttributeLogicalName("emailusername")]
        [Obsolete]
        public string EmailUsername
        {
            get { return GetAttributeValue<string>("emailusername"); }
        }

        /// <summary>
        ///     The default image for the entity.
        /// </summary>
        [AttributeLogicalName("entityimage")]
        public byte[] EntityImage
        {
            get { return GetAttributeValue<byte[]>("entityimage"); }
            set
            {
                OnPropertyChanging("EntityImage");
                SetAttributeValue("entityimage", value);
                OnPropertyChanged("EntityImage");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("entityimage_timestamp")]
        public long? EntityImage_Timestamp
        {
            get { return GetAttributeValue<long?>("entityimage_timestamp"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("entityimage_url")]
        public string EntityImage_URL
        {
            get { return GetAttributeValue<string>("entityimage_url"); }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("entityimageid")]
        public Guid? EntityImageId
        {
            get { return GetAttributeValue<Guid?>("entityimageid"); }
        }

        /// <summary>
        ///     Exchange rate for the currency associated with the queue with respect to the base currency.
        /// </summary>
        [AttributeLogicalName("exchangerate")]
        public decimal? ExchangeRate
        {
            get { return GetAttributeValue<decimal?>("exchangerate"); }
        }

        /// <summary>
        ///     Information that specifies whether a queue is to ignore unsolicited email (deprecated).
        /// </summary>
        [AttributeLogicalName("ignoreunsolicitedemail")]
        public bool? IgnoreUnsolicitedEmail
        {
            get { return GetAttributeValue<bool?>("ignoreunsolicitedemail"); }
            set
            {
                OnPropertyChanging("IgnoreUnsolicitedEmail");
                SetAttributeValue("ignoreunsolicitedemail", value);
                OnPropertyChanged("IgnoreUnsolicitedEmail");
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
        ///     Incoming email delivery method for the queue.
        /// </summary>
        [AttributeLogicalName("incomingemaildeliverymethod")]
        public OptionSetValue IncomingEmailDeliveryMethod
        {
            get { return GetAttributeValue<OptionSetValue>("incomingemaildeliverymethod"); }
            set
            {
                OnPropertyChanging("IncomingEmailDeliveryMethod");
                SetAttributeValue("incomingemaildeliverymethod", value);
                OnPropertyChanged("IncomingEmailDeliveryMethod");
            }
        }

        /// <summary>
        ///     Incoming email filtering method.
        /// </summary>
        [AttributeLogicalName("incomingemailfilteringmethod")]
        public OptionSetValue IncomingEmailFilteringMethod
        {
            get { return GetAttributeValue<OptionSetValue>("incomingemailfilteringmethod"); }
            set
            {
                OnPropertyChanging("IncomingEmailFilteringMethod");
                SetAttributeValue("incomingemailfilteringmethod", value);
                OnPropertyChanged("IncomingEmailFilteringMethod");
            }
        }

        /// <summary>
        ///     Shows the status of approval of the email address by O365 Admin.
        /// </summary>
        [AttributeLogicalName("isemailaddressapprovedbyo365admin")]
        public bool? IsEmailAddressApprovedByO365Admin
        {
            get { return GetAttributeValue<bool?>("isemailaddressapprovedbyo365admin"); }
        }

        /// <summary>
        ///     Indication of whether a queue is the fax delivery queue.
        /// </summary>
        [AttributeLogicalName("isfaxqueue")]
        [Obsolete]
        public bool? IsFaxQueue
        {
            get { return GetAttributeValue<bool?>("isfaxqueue"); }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the queue.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the queue was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the queue.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the queue.
        /// </summary>
        [AttributeLogicalName("name")]
        public string Name
        {
            get { return GetAttributeValue<string>("name"); }
            set
            {
                OnPropertyChanging("Name");
                SetAttributeValue("name", value);
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        ///     Unique identifier of the organization associated with the queue.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     Outgoing email delivery method for the queue.
        /// </summary>
        [AttributeLogicalName("outgoingemaildeliverymethod")]
        public OptionSetValue OutgoingEmailDeliveryMethod
        {
            get { return GetAttributeValue<OptionSetValue>("outgoingemaildeliverymethod"); }
            set
            {
                OnPropertyChanging("OutgoingEmailDeliveryMethod");
                SetAttributeValue("outgoingemaildeliverymethod", value);
                OnPropertyChanged("OutgoingEmailDeliveryMethod");
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
        ///     Unique identifier of the user or team who owns the queue.
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
        ///     Unique identifier of the business unit that owns the queue.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the queue.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the queue.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Unique identifier of the owner of the queue.
        /// </summary>
        [AttributeLogicalName("primaryuserid")]
        [Obsolete]
        public EntityReference PrimaryUserId
        {
            get { return GetAttributeValue<EntityReference>("primaryuserid"); }
            set
            {
                OnPropertyChanging("PrimaryUserId");
                SetAttributeValue("primaryuserid", value);
                OnPropertyChanged("PrimaryUserId");
            }
        }

        /// <summary>
        ///     Unique identifier of the queue.
        /// </summary>
        [AttributeLogicalName("queueid")]
        public Guid? QueueId
        {
            get { return GetAttributeValue<Guid?>("queueid"); }
            set
            {
                OnPropertyChanging("QueueId");
                SetAttributeValue("queueid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("QueueId");
            }
        }

        [AttributeLogicalName("queueid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { QueueId = value; }
        }

        /// <summary>
        ///     Type of queue that is automatically assigned when a user or queue is created. The type can be public, private, or
        ///     work in process.
        /// </summary>
        [AttributeLogicalName("queuetypecode")]
        public OptionSetValue QueueTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("queuetypecode"); }
        }

        /// <summary>
        ///     Status of the queue.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public QueueState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((QueueState) (Enum.ToObject(typeof (QueueState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the queue.
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
        ///     Unique identifier of the currency associated with the queue.
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
        ///     Version number of the queue.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N mailbox_regarding_queue
        /// </summary>
        [RelationshipSchemaName("mailbox_regarding_queue")]
        public IEnumerable<Mailbox> mailbox_regarding_queue
        {
            get { return GetRelatedEntities<Mailbox>("mailbox_regarding_queue", null); }
            set
            {
                OnPropertyChanging("mailbox_regarding_queue");
                SetRelatedEntities("mailbox_regarding_queue", null, value);
                OnPropertyChanged("mailbox_regarding_queue");
            }
        }

        /// <summary>
        ///     1:N queue_activity_parties
        /// </summary>
        [RelationshipSchemaName("queue_activity_parties")]
        public IEnumerable<ActivityParty> queue_activity_parties
        {
            get { return GetRelatedEntities<ActivityParty>("queue_activity_parties", null); }
            set
            {
                OnPropertyChanging("queue_activity_parties");
                SetRelatedEntities("queue_activity_parties", null, value);
                OnPropertyChanged("queue_activity_parties");
            }
        }

        /// <summary>
        ///     1:N Queue_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Queue_AsyncOperations")]
        public IEnumerable<AsyncOperation> Queue_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Queue_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Queue_AsyncOperations");
                SetRelatedEntities("Queue_AsyncOperations", null, value);
                OnPropertyChanged("Queue_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N Queue_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("Queue_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> Queue_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("Queue_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("Queue_BulkDeleteFailures");
                SetRelatedEntities("Queue_BulkDeleteFailures", null, value);
                OnPropertyChanged("Queue_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N Queue_DuplicateBaseRecord
        /// </summary>
        [RelationshipSchemaName("Queue_DuplicateBaseRecord")]
        public IEnumerable<DuplicateRecord> Queue_DuplicateBaseRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Queue_DuplicateBaseRecord", null); }
            set
            {
                OnPropertyChanging("Queue_DuplicateBaseRecord");
                SetRelatedEntities("Queue_DuplicateBaseRecord", null, value);
                OnPropertyChanged("Queue_DuplicateBaseRecord");
            }
        }

        /// <summary>
        ///     1:N Queue_DuplicateMatchingRecord
        /// </summary>
        [RelationshipSchemaName("Queue_DuplicateMatchingRecord")]
        public IEnumerable<DuplicateRecord> Queue_DuplicateMatchingRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Queue_DuplicateMatchingRecord", null); }
            set
            {
                OnPropertyChanging("Queue_DuplicateMatchingRecord");
                SetRelatedEntities("Queue_DuplicateMatchingRecord", null, value);
                OnPropertyChanged("Queue_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        ///     1:N queue_entries
        /// </summary>
        [RelationshipSchemaName("queue_entries")]
        public IEnumerable<QueueItem> queue_entries
        {
            get { return GetRelatedEntities<QueueItem>("queue_entries", null); }
            set
            {
                OnPropertyChanging("queue_entries");
                SetRelatedEntities("queue_entries", null, value);
                OnPropertyChanged("queue_entries");
            }
        }

        /// <summary>
        ///     1:N queue_PostFollows
        /// </summary>
        [RelationshipSchemaName("queue_PostFollows")]
        public IEnumerable<PostFollow> queue_PostFollows
        {
            get { return GetRelatedEntities<PostFollow>("queue_PostFollows", null); }
            set
            {
                OnPropertyChanging("queue_PostFollows");
                SetRelatedEntities("queue_PostFollows", null, value);
                OnPropertyChanged("queue_PostFollows");
            }
        }

        /// <summary>
        ///     1:N queue_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("queue_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> queue_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntities<PrincipalObjectAttributeAccess>("queue_principalobjectattributeaccess", null);
            }
            set
            {
                OnPropertyChanging("queue_principalobjectattributeaccess");
                SetRelatedEntities("queue_principalobjectattributeaccess", null, value);
                OnPropertyChanged("queue_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N Queue_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("Queue_ProcessSessions")]
        public IEnumerable<ProcessSession> Queue_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("Queue_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Queue_ProcessSessions");
                SetRelatedEntities("Queue_ProcessSessions", null, value);
                OnPropertyChanged("Queue_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N queue_system_user
        /// </summary>
        [RelationshipSchemaName("queue_system_user")]
        public IEnumerable<SystemUser> queue_system_user
        {
            get { return GetRelatedEntities<SystemUser>("queue_system_user", null); }
            set
            {
                OnPropertyChanging("queue_system_user");
                SetRelatedEntities("queue_system_user", null, value);
                OnPropertyChanged("queue_system_user");
            }
        }

        /// <summary>
        ///     1:N queue_team
        /// </summary>
        [RelationshipSchemaName("queue_team")]
        public IEnumerable<Team> queue_team
        {
            get { return GetRelatedEntities<Team>("queue_team", null); }
            set
            {
                OnPropertyChanging("queue_team");
                SetRelatedEntities("queue_team", null, value);
                OnPropertyChanged("queue_team");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_queue
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_queue")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_queue
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_queue", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_queue");
                SetRelatedEntities("userentityinstancedata_queue", null, value);
                OnPropertyChanged("userentityinstancedata_queue");
            }
        }

        /// <summary>
        ///     N:1 business_unit_queues
        /// </summary>
        [AttributeLogicalName("businessunitid")]
        [RelationshipSchemaName("business_unit_queues")]
        public BusinessUnit business_unit_queues
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_queues", null); }
            set
            {
                OnPropertyChanging("business_unit_queues");
                SetRelatedEntity("business_unit_queues", null, value);
                OnPropertyChanged("business_unit_queues");
            }
        }

        /// <summary>
        ///     N:1 business_unit_queues2
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_queues2")]
        public BusinessUnit business_unit_queues2
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_queues2", null); }
        }

        /// <summary>
        ///     N:1 lk_queue_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_queue_createdonbehalfby")]
        public SystemUser lk_queue_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_queue_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_queue_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_queue_modifiedonbehalfby")]
        public SystemUser lk_queue_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_queue_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_queuebase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_queuebase_createdby")]
        public SystemUser lk_queuebase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_queuebase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_queuebase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_queuebase_modifiedby")]
        public SystemUser lk_queuebase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_queuebase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 organization_queues
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_queues")]
        public Organization organization_queues
        {
            get { return GetRelatedEntity<Organization>("organization_queues", null); }
        }

        /// <summary>
        ///     N:1 queue_defaultmailbox_mailbox
        /// </summary>
        [AttributeLogicalName("defaultmailbox")]
        [RelationshipSchemaName("queue_defaultmailbox_mailbox")]
        public Mailbox queue_defaultmailbox_mailbox
        {
            get { return GetRelatedEntity<Mailbox>("queue_defaultmailbox_mailbox", null); }
        }

        /// <summary>
        ///     N:1 queue_primary_user
        /// </summary>
        [AttributeLogicalName("primaryuserid")]
        [RelationshipSchemaName("queue_primary_user")]
        public SystemUser queue_primary_user
        {
            get { return GetRelatedEntity<SystemUser>("queue_primary_user", null); }
            set
            {
                OnPropertyChanging("queue_primary_user");
                SetRelatedEntity("queue_primary_user", null, value);
                OnPropertyChanged("queue_primary_user");
            }
        }

        /// <summary>
        ///     N:1 TransactionCurrency_Queue
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("TransactionCurrency_Queue")]
        public TransactionCurrency TransactionCurrency_Queue
        {
            get { return GetRelatedEntity<TransactionCurrency>("TransactionCurrency_Queue", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_Queue");
                SetRelatedEntity("TransactionCurrency_Queue", null, value);
                OnPropertyChanged("TransactionCurrency_Queue");
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