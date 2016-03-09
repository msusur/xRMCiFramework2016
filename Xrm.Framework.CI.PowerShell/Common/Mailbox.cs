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
    /// </summary>
    [DataContract]
    [EntityLogicalName("mailbox")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Mailbox : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "mailbox";

        public const int EntityTypeCode = 9606;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Mailbox() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Choose the delivery method for the mailbox for appointments, contacts, and tasks.
        /// </summary>
        [AttributeLogicalName("actdeliverymethod")]
        public OptionSetValue ACTDeliveryMethod
        {
            get { return GetAttributeValue<OptionSetValue>("actdeliverymethod"); }
            set
            {
                OnPropertyChanging("ACTDeliveryMethod");
                SetAttributeValue("actdeliverymethod", value);
                OnPropertyChanged("ACTDeliveryMethod");
            }
        }

        /// <summary>
        ///     Status of the Appointments, Contacts, and Tasks.
        /// </summary>
        [AttributeLogicalName("actstatus")]
        public OptionSetValue ACTStatus
        {
            get { return GetAttributeValue<OptionSetValue>("actstatus"); }
        }

        /// <summary>
        ///     Choose whether to allow the email connector to use credentials.
        /// </summary>
        [AttributeLogicalName("allowemailconnectortousecredentials")]
        public bool? AllowEmailConnectorToUseCredentials
        {
            get { return GetAttributeValue<bool?>("allowemailconnectortousecredentials"); }
            set
            {
                OnPropertyChanging("AllowEmailConnectorToUseCredentials");
                SetAttributeValue("allowemailconnectortousecredentials", value);
                OnPropertyChanged("AllowEmailConnectorToUseCredentials");
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
        ///     Type the email address of the mailbox.
        /// </summary>
        [AttributeLogicalName("emailaddress")]
        public string EmailAddress
        {
            get { return GetAttributeValue<string>("emailaddress"); }
            set
            {
                OnPropertyChanging("EmailAddress");
                SetAttributeValue("emailaddress", value);
                OnPropertyChanged("EmailAddress");
            }
        }

        /// <summary>
        ///     Shows the status of the email address.
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
        ///     Select the email server profile of the mailbox.
        /// </summary>
        [AttributeLogicalName("emailserverprofile")]
        public EntityReference EmailServerProfile
        {
            get { return GetAttributeValue<EntityReference>("emailserverprofile"); }
            set
            {
                OnPropertyChanging("EmailServerProfile");
                SetAttributeValue("emailserverprofile", value);
                OnPropertyChanged("EmailServerProfile");
            }
        }

        /// <summary>
        ///     Indicates whether the mailbox is enabled for Appointments, Contacts, and Tasks.
        /// </summary>
        [AttributeLogicalName("enabledforact")]
        public bool? EnabledForACT
        {
            get { return GetAttributeValue<bool?>("enabledforact"); }
        }

        /// <summary>
        ///     Choose whether the mailbox is enabled for receiving email.
        /// </summary>
        [AttributeLogicalName("enabledforincomingemail")]
        public bool? EnabledForIncomingEmail
        {
            get { return GetAttributeValue<bool?>("enabledforincomingemail"); }
        }

        /// <summary>
        ///     Choose whether the mailbox is enabled for sending email.
        /// </summary>
        [AttributeLogicalName("enabledforoutgoingemail")]
        public bool? EnabledForOutgoingEmail
        {
            get { return GetAttributeValue<bool?>("enabledforoutgoingemail"); }
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
        ///     Exchange web services endpoint URL for the mailbox.
        /// </summary>
        [AttributeLogicalName("ewsurl")]
        public string EWSURL
        {
            get { return GetAttributeValue<string>("ewsurl"); }
            set
            {
                OnPropertyChanging("EWSURL");
                SetAttributeValue("ewsurl", value);
                OnPropertyChanged("EWSURL");
            }
        }

        /// <summary>
        ///     Contains the exchange synchronization state in XML format.
        /// </summary>
        [AttributeLogicalName("exchangesyncstatexml")]
        public string ExchangeSyncStateXml
        {
            get { return GetAttributeValue<string>("exchangesyncstatexml"); }
            set
            {
                OnPropertyChanging("ExchangeSyncStateXml");
                SetAttributeValue("exchangesyncstatexml", value);
                OnPropertyChanged("ExchangeSyncStateXml");
            }
        }

        /// <summary>
        ///     Unique identifier of the async host that is processing this mailbox.
        /// </summary>
        [AttributeLogicalName("hostid")]
        public string HostId
        {
            get { return GetAttributeValue<string>("hostid"); }
        }

        /// <summary>
        ///     Select how incoming email will be delivered to the mailbox.
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
        ///     Select the status that will be assigned to incoming email messages.
        /// </summary>
        [AttributeLogicalName("incomingemailstatus")]
        public OptionSetValue IncomingEmailStatus
        {
            get { return GetAttributeValue<OptionSetValue>("incomingemailstatus"); }
        }

        /// <summary>
        ///     Set the current organization as the synchronization organization.
        /// </summary>
        [AttributeLogicalName("isactsyncorgflagset")]
        public bool? IsACTSyncOrgFlagSet
        {
            get { return GetAttributeValue<bool?>("isactsyncorgflagset"); }
            set
            {
                OnPropertyChanging("IsACTSyncOrgFlagSet");
                SetAttributeValue("isactsyncorgflagset", value);
                OnPropertyChanged("IsACTSyncOrgFlagSet");
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
        ///     Select whether the mailbox is a forward mailbox.
        /// </summary>
        [AttributeLogicalName("isforwardmailbox")]
        public bool? IsForwardMailbox
        {
            get { return GetAttributeValue<bool?>("isforwardmailbox"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("ispasswordset")]
        public bool? IsPasswordSet
        {
            get { return GetAttributeValue<bool?>("ispasswordset"); }
        }

        /// <summary>
        ///     Shows the date and time when the Exchange web services URL was last discovered using the AutoDiscover service.
        /// </summary>
        [AttributeLogicalName("lastautodiscoveredon")]
        public DateTime? LastAutoDiscoveredOn
        {
            get { return GetAttributeValue<DateTime?>("lastautodiscoveredon"); }
            set
            {
                OnPropertyChanging("LastAutoDiscoveredOn");
                SetAttributeValue("lastautodiscoveredon", value);
                OnPropertyChanged("LastAutoDiscoveredOn");
            }
        }

        /// <summary>
        ///     Unique identifier of the mailbox.
        /// </summary>
        [AttributeLogicalName("mailboxid")]
        public Guid? MailboxId
        {
            get { return GetAttributeValue<Guid?>("mailboxid"); }
            set
            {
                OnPropertyChanging("MailboxId");
                SetAttributeValue("mailboxid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("MailboxId");
            }
        }

        [AttributeLogicalName("mailboxid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { MailboxId = value; }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("mailboxprocessingcontext")]
        public int? MailboxProcessingContext
        {
            get { return GetAttributeValue<int?>("mailboxprocessingcontext"); }
            set
            {
                OnPropertyChanging("MailboxProcessingContext");
                SetAttributeValue("mailboxprocessingcontext", value);
                OnPropertyChanged("MailboxProcessingContext");
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
        ///     Type the name of the mailbox.
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
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("noactcount")]
        public int? NoACTCount
        {
            get { return GetAttributeValue<int?>("noactcount"); }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("noemailcount")]
        public int? NoEmailCount
        {
            get { return GetAttributeValue<int?>("noemailcount"); }
        }

        /// <summary>
        ///     Unique identifier of the organization associated with the record.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     Select how outgoing email will be sent from the mailbox.
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
        ///     Select the status of outgoing email messages.
        /// </summary>
        [AttributeLogicalName("outgoingemailstatus")]
        public OptionSetValue OutgoingEmailStatus
        {
            get { return GetAttributeValue<OptionSetValue>("outgoingemailstatus"); }
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
        ///     Select the business unit that owns the record.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier for the team that owns the record.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier for the user that owns the record.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Type the password for the mailbox.
        /// </summary>
        [AttributeLogicalName("password")]
        public string Password
        {
            get { return GetAttributeValue<string>("password"); }
            set
            {
                OnPropertyChanging("Password");
                SetAttributeValue("password", value);
                OnPropertyChanged("Password");
            }
        }

        /// <summary>
        ///     Shows the date and time when processing will begin on this mailbox.
        /// </summary>
        [AttributeLogicalName("postponemailboxprocessinguntil")]
        public DateTime? PostponeMailboxProcessingUntil
        {
            get { return GetAttributeValue<DateTime?>("postponemailboxprocessinguntil"); }
        }

        /// <summary>
        ///     Shows the date and time when the mailbox can start sending emails.
        /// </summary>
        [AttributeLogicalName("postponesendinguntil")]
        public DateTime? PostponeSendingUntil
        {
            get { return GetAttributeValue<DateTime?>("postponesendinguntil"); }
            set
            {
                OnPropertyChanging("PostponeSendingUntil");
                SetAttributeValue("postponesendinguntil", value);
                OnPropertyChanged("PostponeSendingUntil");
            }
        }

        /// <summary>
        ///     Shows the date and time when the next email configuration test will be run for a mailbox record.
        /// </summary>
        [AttributeLogicalName("postponetestemailconfigurationuntil")]
        public DateTime? PostponeTestEmailConfigurationUntil
        {
            get { return GetAttributeValue<DateTime?>("postponetestemailconfigurationuntil"); }
            set
            {
                OnPropertyChanging("PostponeTestEmailConfigurationUntil");
                SetAttributeValue("postponetestemailconfigurationuntil", value);
                OnPropertyChanged("PostponeTestEmailConfigurationUntil");
            }
        }

        /// <summary>
        ///     Select whether to delete emails from the mailbox after processing.
        /// </summary>
        [AttributeLogicalName("processanddeleteemails")]
        public bool? ProcessAndDeleteEmails
        {
            get { return GetAttributeValue<bool?>("processanddeleteemails"); }
            set
            {
                OnPropertyChanging("ProcessAndDeleteEmails");
                SetAttributeValue("processanddeleteemails", value);
                OnPropertyChanged("ProcessAndDeleteEmails");
            }
        }

        /// <summary>
        ///     Shows the date and time to start processing email received by the mailbox.
        /// </summary>
        [AttributeLogicalName("processemailreceivedafter")]
        public DateTime? ProcessEmailReceivedAfter
        {
            get { return GetAttributeValue<DateTime?>("processemailreceivedafter"); }
            set
            {
                OnPropertyChanging("ProcessEmailReceivedAfter");
                SetAttributeValue("processemailreceivedafter", value);
                OnPropertyChanged("ProcessEmailReceivedAfter");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("receivingpostponeduntil")]
        public DateTime? ReceivingPostponedUntil
        {
            get { return GetAttributeValue<DateTime?>("receivingpostponeduntil"); }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("receivingpostponeduntilforact")]
        public DateTime? ReceivingPostponedUntilForACT
        {
            get { return GetAttributeValue<DateTime?>("receivingpostponeduntilforact"); }
        }

        /// <summary>
        ///     Choose the user associated to the mailbox.
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        public EntityReference RegardingObjectId
        {
            get { return GetAttributeValue<EntityReference>("regardingobjectid"); }
        }

        /// <summary>
        ///     Shows whether the mailbox is active or inactive.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public MailboxState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((MailboxState) (Enum.ToObject(typeof (MailboxState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Select the mailbox's status.
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
        ///     Shows the number of times an email configuration test has been performed.
        /// </summary>
        [AttributeLogicalName("testemailconfigurationretrycount")]
        public int? TestEmailConfigurationRetryCount
        {
            get { return GetAttributeValue<int?>("testemailconfigurationretrycount"); }
            set
            {
                OnPropertyChanging("TestEmailConfigurationRetryCount");
                SetAttributeValue("testemailconfigurationretrycount", value);
                OnPropertyChanged("TestEmailConfigurationRetryCount");
            }
        }

        /// <summary>
        ///     Indicates if the email configuration test has been scheduled for a mailbox record.
        /// </summary>
        [AttributeLogicalName("testemailconfigurationscheduled")]
        public bool? TestEmailConfigurationScheduled
        {
            get { return GetAttributeValue<bool?>("testemailconfigurationscheduled"); }
            set
            {
                OnPropertyChanging("TestEmailConfigurationScheduled");
                SetAttributeValue("testemailconfigurationscheduled", value);
                OnPropertyChanged("TestEmailConfigurationScheduled");
            }
        }

        /// <summary>
        ///     Date and time when the last email configuration test was completed for a mailbox record.
        /// </summary>
        [AttributeLogicalName("testmailboxaccesscompletedon")]
        public DateTime? TestMailboxAccessCompletedOn
        {
            get { return GetAttributeValue<DateTime?>("testmailboxaccesscompletedon"); }
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
        ///     Concatenation of transient failure counts of all mailbox operations.
        /// </summary>
        [AttributeLogicalName("transientfailurecount")]
        public int? TransientFailureCount
        {
            get { return GetAttributeValue<int?>("transientfailurecount"); }
        }

        /// <summary>
        ///     Shows the ID of the Undeliverable folder in the mailbox managed by Microsoft Exchange.
        /// </summary>
        [AttributeLogicalName("undeliverablefolder")]
        public string UndeliverableFolder
        {
            get { return GetAttributeValue<string>("undeliverablefolder"); }
            set
            {
                OnPropertyChanging("UndeliverableFolder");
                SetAttributeValue("undeliverablefolder", value);
                OnPropertyChanged("UndeliverableFolder");
            }
        }

        /// <summary>
        ///     Type a user name used for mailbox authentication.
        /// </summary>
        [AttributeLogicalName("username")]
        public string Username
        {
            get { return GetAttributeValue<string>("username"); }
            set
            {
                OnPropertyChanging("Username");
                SetAttributeValue("username", value);
                OnPropertyChanged("Username");
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
        ///     Version number of the mailbox.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N activitypointer_sendermailboxid_mailbox
        /// </summary>
        [RelationshipSchemaName("activitypointer_sendermailboxid_mailbox")]
        public IEnumerable<ActivityPointer> activitypointer_sendermailboxid_mailbox
        {
            get { return GetRelatedEntities<ActivityPointer>("activitypointer_sendermailboxid_mailbox", null); }
            set
            {
                OnPropertyChanging("activitypointer_sendermailboxid_mailbox");
                SetRelatedEntities("activitypointer_sendermailboxid_mailbox", null, value);
                OnPropertyChanged("activitypointer_sendermailboxid_mailbox");
            }
        }

        /// <summary>
        ///     1:N email_sendermailboxid_mailbox
        /// </summary>
        [RelationshipSchemaName("email_sendermailboxid_mailbox")]
        public IEnumerable<Email> email_sendermailboxid_mailbox
        {
            get { return GetRelatedEntities<Email>("email_sendermailboxid_mailbox", null); }
            set
            {
                OnPropertyChanging("email_sendermailboxid_mailbox");
                SetRelatedEntities("email_sendermailboxid_mailbox", null, value);
                OnPropertyChanged("email_sendermailboxid_mailbox");
            }
        }

        /// <summary>
        ///     1:N Mailbox_Annotation
        /// </summary>
        [RelationshipSchemaName("Mailbox_Annotation")]
        public IEnumerable<Annotation> Mailbox_Annotation
        {
            get { return GetRelatedEntities<Annotation>("Mailbox_Annotation", null); }
            set
            {
                OnPropertyChanging("Mailbox_Annotation");
                SetRelatedEntities("Mailbox_Annotation", null, value);
                OnPropertyChanged("Mailbox_Annotation");
            }
        }

        /// <summary>
        ///     1:N mailbox_asyncoperations
        /// </summary>
        [RelationshipSchemaName("mailbox_asyncoperations")]
        public IEnumerable<AsyncOperation> mailbox_asyncoperations
        {
            get { return GetRelatedEntities<AsyncOperation>("mailbox_asyncoperations", null); }
            set
            {
                OnPropertyChanging("mailbox_asyncoperations");
                SetRelatedEntities("mailbox_asyncoperations", null, value);
                OnPropertyChanged("mailbox_asyncoperations");
            }
        }

        /// <summary>
        ///     1:N mailbox_processsessions
        /// </summary>
        [RelationshipSchemaName("mailbox_processsessions")]
        public IEnumerable<ProcessSession> mailbox_processsessions
        {
            get { return GetRelatedEntities<ProcessSession>("mailbox_processsessions", null); }
            set
            {
                OnPropertyChanging("mailbox_processsessions");
                SetRelatedEntities("mailbox_processsessions", null, value);
                OnPropertyChanged("mailbox_processsessions");
            }
        }

        /// <summary>
        ///     1:N mailbox_userentityinstancedatas
        /// </summary>
        [RelationshipSchemaName("mailbox_userentityinstancedatas")]
        public IEnumerable<UserEntityInstanceData> mailbox_userentityinstancedatas
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("mailbox_userentityinstancedatas", null); }
            set
            {
                OnPropertyChanging("mailbox_userentityinstancedatas");
                SetRelatedEntities("mailbox_userentityinstancedatas", null, value);
                OnPropertyChanged("mailbox_userentityinstancedatas");
            }
        }

        /// <summary>
        ///     1:N queue_defaultmailbox_mailbox
        /// </summary>
        [RelationshipSchemaName("queue_defaultmailbox_mailbox")]
        public IEnumerable<Queue> queue_defaultmailbox_mailbox
        {
            get { return GetRelatedEntities<Queue>("queue_defaultmailbox_mailbox", null); }
            set
            {
                OnPropertyChanging("queue_defaultmailbox_mailbox");
                SetRelatedEntities("queue_defaultmailbox_mailbox", null, value);
                OnPropertyChanged("queue_defaultmailbox_mailbox");
            }
        }

        /// <summary>
        ///     1:N systemuser_defaultmailbox_mailbox
        /// </summary>
        [RelationshipSchemaName("systemuser_defaultmailbox_mailbox")]
        public IEnumerable<SystemUser> systemuser_defaultmailbox_mailbox
        {
            get { return GetRelatedEntities<SystemUser>("systemuser_defaultmailbox_mailbox", null); }
            set
            {
                OnPropertyChanging("systemuser_defaultmailbox_mailbox");
                SetRelatedEntities("systemuser_defaultmailbox_mailbox", null, value);
                OnPropertyChanged("systemuser_defaultmailbox_mailbox");
            }
        }

        /// <summary>
        ///     1:N tracelog_Mailbox
        /// </summary>
        [RelationshipSchemaName("tracelog_Mailbox")]
        public IEnumerable<TraceLog> tracelog_Mailbox
        {
            get { return GetRelatedEntities<TraceLog>("tracelog_Mailbox", null); }
            set
            {
                OnPropertyChanging("tracelog_Mailbox");
                SetRelatedEntities("tracelog_Mailbox", null, value);
                OnPropertyChanged("tracelog_Mailbox");
            }
        }

        /// <summary>
        ///     N:1 business_unit_mailbox
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_mailbox")]
        public BusinessUnit business_unit_mailbox
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_mailbox", null); }
        }

        /// <summary>
        ///     N:1 emailserverprofile_mailbox
        /// </summary>
        [AttributeLogicalName("emailserverprofile")]
        [RelationshipSchemaName("emailserverprofile_mailbox")]
        public EmailServerProfile emailserverprofile_mailbox
        {
            get { return GetRelatedEntity<EmailServerProfile>("emailserverprofile_mailbox", null); }
            set
            {
                OnPropertyChanging("emailserverprofile_mailbox");
                SetRelatedEntity("emailserverprofile_mailbox", null, value);
                OnPropertyChanged("emailserverprofile_mailbox");
            }
        }

        /// <summary>
        ///     N:1 lk_mailbox_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_mailbox_createdby")]
        public SystemUser lk_mailbox_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_mailbox_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_mailbox_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_mailbox_createdonbehalfby")]
        public SystemUser lk_mailbox_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_mailbox_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_mailbox_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_mailbox_modifiedby")]
        public SystemUser lk_mailbox_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_mailbox_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_mailbox_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_mailbox_modifiedonbehalfby")]
        public SystemUser lk_mailbox_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_mailbox_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 mailbox_regarding_queue
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("mailbox_regarding_queue")]
        public Queue mailbox_regarding_queue
        {
            get { return GetRelatedEntity<Queue>("mailbox_regarding_queue", null); }
        }

        /// <summary>
        ///     N:1 mailbox_regarding_systemuser
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("mailbox_regarding_systemuser")]
        public SystemUser mailbox_regarding_systemuser
        {
            get { return GetRelatedEntity<SystemUser>("mailbox_regarding_systemuser", null); }
        }

        /// <summary>
        ///     N:1 organization_mailbox
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_mailbox")]
        public Organization organization_mailbox
        {
            get { return GetRelatedEntity<Organization>("organization_mailbox", null); }
        }

        /// <summary>
        ///     N:1 team_mailbox
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_mailbox")]
        public Team team_mailbox
        {
            get { return GetRelatedEntity<Team>("team_mailbox", null); }
        }

        /// <summary>
        ///     N:1 user_mailbox
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_mailbox")]
        public SystemUser user_mailbox
        {
            get { return GetRelatedEntity<SystemUser>("user_mailbox", null); }
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