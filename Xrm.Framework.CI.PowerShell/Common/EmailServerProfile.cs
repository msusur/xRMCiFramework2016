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
    ///     Holds the Email Server Profiles of an organization
    /// </summary>
    [DataContract]
    [EntityLogicalName("emailserverprofile")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class EmailServerProfile : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "emailserverprofile";

        public const int EntityTypeCode = 9605;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public EmailServerProfile() :
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
        ///     Type additional information that describes the email server profile.
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
        ///     Unique identifier of the email server profile.
        /// </summary>
        [AttributeLogicalName("emailserverprofileid")]
        public Guid? EmailServerProfileId
        {
            get { return GetAttributeValue<Guid?>("emailserverprofileid"); }
            set
            {
                OnPropertyChanging("EmailServerProfileId");
                SetAttributeValue("emailserverprofileid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("EmailServerProfileId");
            }
        }

        [AttributeLogicalName("emailserverprofileid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { EmailServerProfileId = value; }
        }

        /// <summary>
        ///     Indicates the code page to use when encoding email content.
        /// </summary>
        [AttributeLogicalName("encodingcodepage")]
        public string EncodingCodePage
        {
            get { return GetAttributeValue<string>("encodingcodepage"); }
            set
            {
                OnPropertyChanging("EncodingCodePage");
                SetAttributeValue("encodingcodepage", value);
                OnPropertyChanged("EncodingCodePage");
            }
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
        ///     Select the version of Exchange that is on the email server.
        /// </summary>
        [AttributeLogicalName("exchangeversion")]
        public OptionSetValue ExchangeVersion
        {
            get { return GetAttributeValue<OptionSetValue>("exchangeversion"); }
            set
            {
                OnPropertyChanging("ExchangeVersion");
                SetAttributeValue("exchangeversion", value);
                OnPropertyChanged("ExchangeVersion");
            }
        }

        /// <summary>
        ///     Select the incoming email authentication protocol that is used for connecting to the email server.
        /// </summary>
        [AttributeLogicalName("incomingauthenticationprotocol")]
        public OptionSetValue IncomingAuthenticationProtocol
        {
            get { return GetAttributeValue<OptionSetValue>("incomingauthenticationprotocol"); }
            set
            {
                OnPropertyChanging("IncomingAuthenticationProtocol");
                SetAttributeValue("incomingauthenticationprotocol", value);
                OnPropertyChanged("IncomingAuthenticationProtocol");
            }
        }

        /// <summary>
        ///     Select how credentials will be retrieved for incoming email.
        /// </summary>
        [AttributeLogicalName("incomingcredentialretrieval")]
        public OptionSetValue IncomingCredentialRetrieval
        {
            get { return GetAttributeValue<OptionSetValue>("incomingcredentialretrieval"); }
            set
            {
                OnPropertyChanging("IncomingCredentialRetrieval");
                SetAttributeValue("incomingcredentialretrieval", value);
                OnPropertyChanged("IncomingCredentialRetrieval");
            }
        }

        /// <summary>
        ///     Indicates the incoming partner application.
        /// </summary>
        [AttributeLogicalName("incomingpartnerapplication")]
        public EntityReference IncomingPartnerApplication
        {
            get { return GetAttributeValue<EntityReference>("incomingpartnerapplication"); }
        }

        /// <summary>
        ///     Type the password for incoming email.
        /// </summary>
        [AttributeLogicalName("incomingpassword")]
        public string IncomingPassword
        {
            get { return GetAttributeValue<string>("incomingpassword"); }
            set
            {
                OnPropertyChanging("IncomingPassword");
                SetAttributeValue("incomingpassword", value);
                OnPropertyChanged("IncomingPassword");
            }
        }

        /// <summary>
        ///     Type the port number for incoming email.
        /// </summary>
        [AttributeLogicalName("incomingportnumber")]
        public int? IncomingPortNumber
        {
            get { return GetAttributeValue<int?>("incomingportnumber"); }
            set
            {
                OnPropertyChanging("IncomingPortNumber");
                SetAttributeValue("incomingportnumber", value);
                OnPropertyChanged("IncomingPortNumber");
            }
        }

        /// <summary>
        ///     Type the location of the server for incoming email.
        /// </summary>
        [AttributeLogicalName("incomingserverlocation")]
        public string IncomingServerLocation
        {
            get { return GetAttributeValue<string>("incomingserverlocation"); }
            set
            {
                OnPropertyChanging("IncomingServerLocation");
                SetAttributeValue("incomingserverlocation", value);
                OnPropertyChanged("IncomingServerLocation");
            }
        }

        /// <summary>
        ///     Select whether to use impersonation to access the mailbox to process incoming emails.
        /// </summary>
        [AttributeLogicalName("incominguseimpersonation")]
        public bool? IncomingUseImpersonation
        {
            get { return GetAttributeValue<bool?>("incominguseimpersonation"); }
            set
            {
                OnPropertyChanging("IncomingUseImpersonation");
                SetAttributeValue("incominguseimpersonation", value);
                OnPropertyChanged("IncomingUseImpersonation");
            }
        }

        /// <summary>
        ///     Type the user name for incoming email.
        /// </summary>
        [AttributeLogicalName("incomingusername")]
        public string IncomingUserName
        {
            get { return GetAttributeValue<string>("incomingusername"); }
            set
            {
                OnPropertyChanging("IncomingUserName");
                SetAttributeValue("incomingusername", value);
                OnPropertyChanged("IncomingUserName");
            }
        }

        /// <summary>
        ///     Select whether to use the Secure Sockets Layer (SSL) protocol for incoming email.
        /// </summary>
        [AttributeLogicalName("incomingusessl")]
        public bool? IncomingUseSSL
        {
            get { return GetAttributeValue<bool?>("incomingusessl"); }
            set
            {
                OnPropertyChanging("IncomingUseSSL");
                SetAttributeValue("incomingusessl", value);
                OnPropertyChanged("IncomingUseSSL");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("isincomingpasswordset")]
        public bool? IsIncomingPasswordSet
        {
            get { return GetAttributeValue<bool?>("isincomingpasswordset"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("isoutgoingpasswordset")]
        public bool? IsOutgoingPasswordSet
        {
            get { return GetAttributeValue<bool?>("isoutgoingpasswordset"); }
        }

        /// <summary>
        ///     Maximum number of concurrent connections allowed to the email server per authenticated user.
        /// </summary>
        [AttributeLogicalName("maxconcurrentconnections")]
        public int? MaxConcurrentConnections
        {
            get { return GetAttributeValue<int?>("maxconcurrentconnections"); }
            set
            {
                OnPropertyChanging("MaxConcurrentConnections");
                SetAttributeValue("maxconcurrentconnections", value);
                OnPropertyChanged("MaxConcurrentConnections");
            }
        }

        /// <summary>
        ///     Minimum polling interval, in minutes, for mailboxes that are associated with this email server profile.
        /// </summary>
        [AttributeLogicalName("minpollingintervalinminutes")]
        public int? MinPollingIntervalInMinutes
        {
            get { return GetAttributeValue<int?>("minpollingintervalinminutes"); }
            set
            {
                OnPropertyChanging("MinPollingIntervalInMinutes");
                SetAttributeValue("minpollingintervalinminutes", value);
                OnPropertyChanged("MinPollingIntervalInMinutes");
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
        ///     Indicates whether to move undelivered incoming emails to the Undeliverable folder in Microsoft Exchange.
        /// </summary>
        [AttributeLogicalName("moveundeliveredemails")]
        public bool? MoveUndeliveredEmails
        {
            get { return GetAttributeValue<bool?>("moveundeliveredemails"); }
            set
            {
                OnPropertyChanging("MoveUndeliveredEmails");
                SetAttributeValue("moveundeliveredemails", value);
                OnPropertyChanged("MoveUndeliveredEmails");
            }
        }

        /// <summary>
        ///     Type the name of the email server profile record.
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
        ///     Unique identifier of the organization associated with the record.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     Select the outgoing email authentication protocol that is used for connecting to the email server.
        /// </summary>
        [AttributeLogicalName("outgoingauthenticationprotocol")]
        public OptionSetValue OutgoingAuthenticationProtocol
        {
            get { return GetAttributeValue<OptionSetValue>("outgoingauthenticationprotocol"); }
            set
            {
                OnPropertyChanging("OutgoingAuthenticationProtocol");
                SetAttributeValue("outgoingauthenticationprotocol", value);
                OnPropertyChanged("OutgoingAuthenticationProtocol");
            }
        }

        /// <summary>
        ///     Indicates whether the email connector will grant delegate access permissions to the accessing user when required
        ///     while processing outgoing emails.
        /// </summary>
        [AttributeLogicalName("outgoingautograntdelegateaccess")]
        public bool? OutgoingAutoGrantDelegateAccess
        {
            get { return GetAttributeValue<bool?>("outgoingautograntdelegateaccess"); }
            set
            {
                OnPropertyChanging("OutgoingAutoGrantDelegateAccess");
                SetAttributeValue("outgoingautograntdelegateaccess", value);
                OnPropertyChanged("OutgoingAutoGrantDelegateAccess");
            }
        }

        /// <summary>
        ///     Select how credentials will be retrieved for outgoing email.
        /// </summary>
        [AttributeLogicalName("outgoingcredentialretrieval")]
        public OptionSetValue OutgoingCredentialRetrieval
        {
            get { return GetAttributeValue<OptionSetValue>("outgoingcredentialretrieval"); }
            set
            {
                OnPropertyChanging("OutgoingCredentialRetrieval");
                SetAttributeValue("outgoingcredentialretrieval", value);
                OnPropertyChanged("OutgoingCredentialRetrieval");
            }
        }

        /// <summary>
        ///     Indicates the outgoing partner application.
        /// </summary>
        [AttributeLogicalName("outgoingpartnerapplication")]
        public EntityReference OutgoingPartnerApplication
        {
            get { return GetAttributeValue<EntityReference>("outgoingpartnerapplication"); }
        }

        /// <summary>
        ///     Type the password for outgoing email.
        /// </summary>
        [AttributeLogicalName("outgoingpassword")]
        public string OutgoingPassword
        {
            get { return GetAttributeValue<string>("outgoingpassword"); }
            set
            {
                OnPropertyChanging("OutgoingPassword");
                SetAttributeValue("outgoingpassword", value);
                OnPropertyChanged("OutgoingPassword");
            }
        }

        /// <summary>
        ///     Type the port number for outgoing email.
        /// </summary>
        [AttributeLogicalName("outgoingportnumber")]
        public int? OutgoingPortNumber
        {
            get { return GetAttributeValue<int?>("outgoingportnumber"); }
            set
            {
                OnPropertyChanging("OutgoingPortNumber");
                SetAttributeValue("outgoingportnumber", value);
                OnPropertyChanged("OutgoingPortNumber");
            }
        }

        /// <summary>
        ///     Type the location of the server for outgoing email.
        /// </summary>
        [AttributeLogicalName("outgoingserverlocation")]
        public string OutgoingServerLocation
        {
            get { return GetAttributeValue<string>("outgoingserverlocation"); }
            set
            {
                OnPropertyChanging("OutgoingServerLocation");
                SetAttributeValue("outgoingserverlocation", value);
                OnPropertyChanged("OutgoingServerLocation");
            }
        }

        /// <summary>
        ///     Select whether to use impersonation for accessing the mailbox to process outgoing emails.
        /// </summary>
        [AttributeLogicalName("outgoinguseimpersonation")]
        public bool? OutgoingUseImpersonation
        {
            get { return GetAttributeValue<bool?>("outgoinguseimpersonation"); }
            set
            {
                OnPropertyChanging("OutgoingUseImpersonation");
                SetAttributeValue("outgoinguseimpersonation", value);
                OnPropertyChanged("OutgoingUseImpersonation");
            }
        }

        /// <summary>
        ///     Type the user name for outgoing email.
        /// </summary>
        [AttributeLogicalName("outgoingusername")]
        public string OutgoingUsername
        {
            get { return GetAttributeValue<string>("outgoingusername"); }
            set
            {
                OnPropertyChanging("OutgoingUsername");
                SetAttributeValue("outgoingusername", value);
                OnPropertyChanged("OutgoingUsername");
            }
        }

        /// <summary>
        ///     Select whether to use the Secure Sockets Layer (SSL) protocol for outgoing email.
        /// </summary>
        [AttributeLogicalName("outgoingusessl")]
        public bool? OutgoingUseSSL
        {
            get { return GetAttributeValue<bool?>("outgoingusessl"); }
            set
            {
                OnPropertyChanging("OutgoingUseSSL");
                SetAttributeValue("outgoingusessl", value);
                OnPropertyChanged("OutgoingUseSSL");
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
        ///     Shows the date and time after which email messages that are received will be processed for mailboxes associated
        ///     with the email server profile.
        /// </summary>
        [AttributeLogicalName("processemailsreceivedafter")]
        public DateTime? ProcessEmailsReceivedAfter
        {
            get { return GetAttributeValue<DateTime?>("processemailsreceivedafter"); }
            set
            {
                OnPropertyChanging("ProcessEmailsReceivedAfter");
                SetAttributeValue("processemailsreceivedafter", value);
                OnPropertyChanged("ProcessEmailsReceivedAfter");
            }
        }

        /// <summary>
        ///     Select the profile's email server type.
        /// </summary>
        [AttributeLogicalName("servertype")]
        public OptionSetValue ServerType
        {
            get { return GetAttributeValue<OptionSetValue>("servertype"); }
            set
            {
                OnPropertyChanging("ServerType");
                SetAttributeValue("servertype", value);
                OnPropertyChanged("ServerType");
            }
        }

        /// <summary>
        ///     Shows whether the email server profile is active or inactive.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public EmailServerProfileState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return
                        ((EmailServerProfileState) (Enum.ToObject(typeof (EmailServerProfileState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Select the email server profile's status.
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
        ///     Select whether to automatically discover the server location.
        /// </summary>
        [AttributeLogicalName("useautodiscover")]
        public bool? UseAutoDiscover
        {
            get { return GetAttributeValue<bool?>("useautodiscover"); }
            set
            {
                OnPropertyChanging("UseAutoDiscover");
                SetAttributeValue("useautodiscover", value);
                OnPropertyChanged("UseAutoDiscover");
            }
        }

        /// <summary>
        ///     Select whether to use the same settings for incoming and outgoing connections.
        /// </summary>
        [AttributeLogicalName("usesamesettingsforoutgoingconnections")]
        public bool? UseSameSettingsForOutgoingConnections
        {
            get { return GetAttributeValue<bool?>("usesamesettingsforoutgoingconnections"); }
            set
            {
                OnPropertyChanging("UseSameSettingsForOutgoingConnections");
                SetAttributeValue("usesamesettingsforoutgoingconnections", value);
                OnPropertyChanged("UseSameSettingsForOutgoingConnections");
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
        ///     1:N EmailServerProfile_Annotation
        /// </summary>
        [RelationshipSchemaName("EmailServerProfile_Annotation")]
        public IEnumerable<Annotation> EmailServerProfile_Annotation
        {
            get { return GetRelatedEntities<Annotation>("EmailServerProfile_Annotation", null); }
            set
            {
                OnPropertyChanging("EmailServerProfile_Annotation");
                SetRelatedEntities("EmailServerProfile_Annotation", null, value);
                OnPropertyChanged("EmailServerProfile_Annotation");
            }
        }

        /// <summary>
        ///     1:N emailserverprofile_asyncoperations
        /// </summary>
        [RelationshipSchemaName("emailserverprofile_asyncoperations")]
        public IEnumerable<AsyncOperation> emailserverprofile_asyncoperations
        {
            get { return GetRelatedEntities<AsyncOperation>("emailserverprofile_asyncoperations", null); }
            set
            {
                OnPropertyChanging("emailserverprofile_asyncoperations");
                SetRelatedEntities("emailserverprofile_asyncoperations", null, value);
                OnPropertyChanged("emailserverprofile_asyncoperations");
            }
        }

        /// <summary>
        ///     1:N emailserverprofile_bulkdeletefailures
        /// </summary>
        [RelationshipSchemaName("emailserverprofile_bulkdeletefailures")]
        public IEnumerable<BulkDeleteFailure> emailserverprofile_bulkdeletefailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("emailserverprofile_bulkdeletefailures", null); }
            set
            {
                OnPropertyChanging("emailserverprofile_bulkdeletefailures");
                SetRelatedEntities("emailserverprofile_bulkdeletefailures", null, value);
                OnPropertyChanged("emailserverprofile_bulkdeletefailures");
            }
        }

        /// <summary>
        ///     1:N emailserverprofile_duplicatebaserecord
        /// </summary>
        [RelationshipSchemaName("emailserverprofile_duplicatebaserecord")]
        public IEnumerable<DuplicateRecord> emailserverprofile_duplicatebaserecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("emailserverprofile_duplicatebaserecord", null); }
            set
            {
                OnPropertyChanging("emailserverprofile_duplicatebaserecord");
                SetRelatedEntities("emailserverprofile_duplicatebaserecord", null, value);
                OnPropertyChanged("emailserverprofile_duplicatebaserecord");
            }
        }

        /// <summary>
        ///     1:N emailserverprofile_duplicatematchingrecord
        /// </summary>
        [RelationshipSchemaName("emailserverprofile_duplicatematchingrecord")]
        public IEnumerable<DuplicateRecord> emailserverprofile_duplicatematchingrecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("emailserverprofile_duplicatematchingrecord", null); }
            set
            {
                OnPropertyChanging("emailserverprofile_duplicatematchingrecord");
                SetRelatedEntities("emailserverprofile_duplicatematchingrecord", null, value);
                OnPropertyChanged("emailserverprofile_duplicatematchingrecord");
            }
        }

        /// <summary>
        ///     1:N emailserverprofile_mailbox
        /// </summary>
        [RelationshipSchemaName("emailserverprofile_mailbox")]
        public IEnumerable<Mailbox> emailserverprofile_mailbox
        {
            get { return GetRelatedEntities<Mailbox>("emailserverprofile_mailbox", null); }
            set
            {
                OnPropertyChanging("emailserverprofile_mailbox");
                SetRelatedEntities("emailserverprofile_mailbox", null, value);
                OnPropertyChanged("emailserverprofile_mailbox");
            }
        }

        /// <summary>
        ///     1:N EmailServerProfile_Organization
        /// </summary>
        [RelationshipSchemaName("EmailServerProfile_Organization")]
        public IEnumerable<Organization> EmailServerProfile_Organization
        {
            get { return GetRelatedEntities<Organization>("EmailServerProfile_Organization", null); }
            set
            {
                OnPropertyChanging("EmailServerProfile_Organization");
                SetRelatedEntities("EmailServerProfile_Organization", null, value);
                OnPropertyChanged("EmailServerProfile_Organization");
            }
        }

        /// <summary>
        ///     1:N tracelog_EmailServerProfile
        /// </summary>
        [RelationshipSchemaName("tracelog_EmailServerProfile")]
        public IEnumerable<TraceLog> tracelog_EmailServerProfile
        {
            get { return GetRelatedEntities<TraceLog>("tracelog_EmailServerProfile", null); }
            set
            {
                OnPropertyChanging("tracelog_EmailServerProfile");
                SetRelatedEntities("tracelog_EmailServerProfile", null, value);
                OnPropertyChanged("tracelog_EmailServerProfile");
            }
        }

        /// <summary>
        ///     N:1 business_unit_emailserverprofile
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_emailserverprofile")]
        public BusinessUnit business_unit_emailserverprofile
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_emailserverprofile", null); }
        }

        /// <summary>
        ///     N:1 lk_emailserverprofile_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_emailserverprofile_createdby")]
        public SystemUser lk_emailserverprofile_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_emailserverprofile_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_emailserverprofile_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_emailserverprofile_createdonbehalfby")]
        public SystemUser lk_emailserverprofile_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_emailserverprofile_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_emailserverprofile_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_emailserverprofile_modifiedby")]
        public SystemUser lk_emailserverprofile_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_emailserverprofile_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_emailserverprofile_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_emailserverprofile_modifiedonbehalfby")]
        public SystemUser lk_emailserverprofile_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_emailserverprofile_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 organization_emailserverprofile
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_emailserverprofile")]
        public Organization organization_emailserverprofile
        {
            get { return GetRelatedEntity<Organization>("organization_emailserverprofile", null); }
        }

        /// <summary>
        ///     N:1 team_emailserverprofile
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_emailserverprofile")]
        public Team team_emailserverprofile
        {
            get { return GetRelatedEntity<Team>("team_emailserverprofile", null); }
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