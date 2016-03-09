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
    ///     Relationship between two entities.
    /// </summary>
    [DataContract]
    [EntityLogicalName("connection")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Connection : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "connection";

        public const int EntityTypeCode = 3234;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Connection() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the connection.
        /// </summary>
        [AttributeLogicalName("connectionid")]
        public Guid? ConnectionId
        {
            get { return GetAttributeValue<Guid?>("connectionid"); }
            set
            {
                OnPropertyChanging("ConnectionId");
                SetAttributeValue("connectionid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ConnectionId");
            }
        }

        [AttributeLogicalName("connectionid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ConnectionId = value; }
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
        ///     Type additional information to describe the connection, such as the length or quality of the relationship.
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
        ///     Enter the end date of the connection.
        /// </summary>
        [AttributeLogicalName("effectiveend")]
        public DateTime? EffectiveEnd
        {
            get { return GetAttributeValue<DateTime?>("effectiveend"); }
            set
            {
                OnPropertyChanging("EffectiveEnd");
                SetAttributeValue("effectiveend", value);
                OnPropertyChanged("EffectiveEnd");
            }
        }

        /// <summary>
        ///     Enter the start date of the connection.
        /// </summary>
        [AttributeLogicalName("effectivestart")]
        public DateTime? EffectiveStart
        {
            get { return GetAttributeValue<DateTime?>("effectivestart"); }
            set
            {
                OnPropertyChanging("EffectiveStart");
                SetAttributeValue("effectivestart", value);
                OnPropertyChanged("EffectiveStart");
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
        ///     Indicates that this is the master record.
        /// </summary>
        [AttributeLogicalName("ismaster")]
        public bool? IsMaster
        {
            get { return GetAttributeValue<bool?>("ismaster"); }
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
        ///     Name of the connection.
        /// </summary>
        [AttributeLogicalName("name")]
        public string Name
        {
            get { return GetAttributeValue<string>("name"); }
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
        ///     Unique identifier of the team who owns the connection.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the connection.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Unique identifier of the source record.
        /// </summary>
        [AttributeLogicalName("record1id")]
        public EntityReference Record1Id
        {
            get { return GetAttributeValue<EntityReference>("record1id"); }
            set
            {
                OnPropertyChanging("Record1Id");
                SetAttributeValue("record1id", value);
                OnPropertyChanged("Record1Id");
            }
        }

        /// <summary>
        ///     Shows the record type of the source record.
        /// </summary>
        [AttributeLogicalName("record1objecttypecode")]
        public OptionSetValue Record1ObjectTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("record1objecttypecode"); }
        }

        /// <summary>
        ///     Choose the primary party's role or relationship with the second party.
        /// </summary>
        [AttributeLogicalName("record1roleid")]
        public EntityReference Record1RoleId
        {
            get { return GetAttributeValue<EntityReference>("record1roleid"); }
            set
            {
                OnPropertyChanging("Record1RoleId");
                SetAttributeValue("record1roleid", value);
                OnPropertyChanged("Record1RoleId");
            }
        }

        /// <summary>
        ///     Unique identifier of the target record.
        /// </summary>
        [AttributeLogicalName("record2id")]
        public EntityReference Record2Id
        {
            get { return GetAttributeValue<EntityReference>("record2id"); }
            set
            {
                OnPropertyChanging("Record2Id");
                SetAttributeValue("record2id", value);
                OnPropertyChanged("Record2Id");
            }
        }

        /// <summary>
        ///     Shows the record type of the target record.
        /// </summary>
        [AttributeLogicalName("record2objecttypecode")]
        public OptionSetValue Record2ObjectTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("record2objecttypecode"); }
        }

        /// <summary>
        ///     Choose the secondary party's role or relationship with the primary party.
        /// </summary>
        [AttributeLogicalName("record2roleid")]
        public EntityReference Record2RoleId
        {
            get { return GetAttributeValue<EntityReference>("record2roleid"); }
            set
            {
                OnPropertyChanging("Record2RoleId");
                SetAttributeValue("record2roleid", value);
                OnPropertyChanged("Record2RoleId");
            }
        }

        /// <summary>
        ///     Unique identifier for the reciprocal connection record.
        /// </summary>
        [AttributeLogicalName("relatedconnectionid")]
        public EntityReference RelatedConnectionId
        {
            get { return GetAttributeValue<EntityReference>("relatedconnectionid"); }
        }

        /// <summary>
        ///     Shows whether the connection is active or inactive. Inactive connections are read-only and can't be edited unless
        ///     they are reactivated.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public ConnectionState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ConnectionState) (Enum.ToObject(typeof (ConnectionState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the connection.
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
        ///     Version number of the connection.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N Connection_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Connection_AsyncOperations")]
        public IEnumerable<AsyncOperation> Connection_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Connection_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Connection_AsyncOperations");
                SetRelatedEntities("Connection_AsyncOperations", null, value);
                OnPropertyChanged("Connection_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N connection_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("connection_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> connection_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntities<PrincipalObjectAttributeAccess>("connection_principalobjectattributeaccess",
                    null);
            }
            set
            {
                OnPropertyChanging("connection_principalobjectattributeaccess");
                SetRelatedEntities("connection_principalobjectattributeaccess", null, value);
                OnPropertyChanged("connection_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N Connection_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("Connection_ProcessSessions")]
        public IEnumerable<ProcessSession> Connection_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("Connection_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Connection_ProcessSessions");
                SetRelatedEntities("Connection_ProcessSessions", null, value);
                OnPropertyChanged("Connection_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N connection_related_connection
        /// </summary>
        [RelationshipSchemaName("connection_related_connection", EntityRole.Referenced)]
        public IEnumerable<Connection> Referencedconnection_related_connection
        {
            get { return GetRelatedEntities<Connection>("connection_related_connection", EntityRole.Referenced); }
            set
            {
                OnPropertyChanging("Referencedconnection_related_connection");
                SetRelatedEntities("connection_related_connection", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedconnection_related_connection");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_connection
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_connection")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_connection
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_connection", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_connection");
                SetRelatedEntities("userentityinstancedata_connection", null, value);
                OnPropertyChanged("userentityinstancedata_connection");
            }
        }

        /// <summary>
        ///     N:1 account_connections1
        /// </summary>
        [AttributeLogicalName("record1id")]
        [RelationshipSchemaName("account_connections1")]
        public Account account_connections1
        {
            get { return GetRelatedEntity<Account>("account_connections1", null); }
            set
            {
                OnPropertyChanging("account_connections1");
                SetRelatedEntity("account_connections1", null, value);
                OnPropertyChanged("account_connections1");
            }
        }

        /// <summary>
        ///     N:1 account_connections2
        /// </summary>
        [AttributeLogicalName("record2id")]
        [RelationshipSchemaName("account_connections2")]
        public Account account_connections2
        {
            get { return GetRelatedEntity<Account>("account_connections2", null); }
            set
            {
                OnPropertyChanging("account_connections2");
                SetRelatedEntity("account_connections2", null, value);
                OnPropertyChanged("account_connections2");
            }
        }

        /// <summary>
        ///     N:1 activitypointer_connections1
        /// </summary>
        [AttributeLogicalName("record1id")]
        [RelationshipSchemaName("activitypointer_connections1")]
        public ActivityPointer activitypointer_connections1
        {
            get { return GetRelatedEntity<ActivityPointer>("activitypointer_connections1", null); }
            set
            {
                OnPropertyChanging("activitypointer_connections1");
                SetRelatedEntity("activitypointer_connections1", null, value);
                OnPropertyChanged("activitypointer_connections1");
            }
        }

        /// <summary>
        ///     N:1 activitypointer_connections2
        /// </summary>
        [AttributeLogicalName("record2id")]
        [RelationshipSchemaName("activitypointer_connections2")]
        public ActivityPointer activitypointer_connections2
        {
            get { return GetRelatedEntity<ActivityPointer>("activitypointer_connections2", null); }
            set
            {
                OnPropertyChanging("activitypointer_connections2");
                SetRelatedEntity("activitypointer_connections2", null, value);
                OnPropertyChanged("activitypointer_connections2");
            }
        }

        /// <summary>
        ///     N:1 appointment_connections1
        /// </summary>
        [AttributeLogicalName("record1id")]
        [RelationshipSchemaName("appointment_connections1")]
        public Appointment appointment_connections1
        {
            get { return GetRelatedEntity<Appointment>("appointment_connections1", null); }
            set
            {
                OnPropertyChanging("appointment_connections1");
                SetRelatedEntity("appointment_connections1", null, value);
                OnPropertyChanged("appointment_connections1");
            }
        }

        /// <summary>
        ///     N:1 appointment_connections2
        /// </summary>
        [AttributeLogicalName("record2id")]
        [RelationshipSchemaName("appointment_connections2")]
        public Appointment appointment_connections2
        {
            get { return GetRelatedEntity<Appointment>("appointment_connections2", null); }
            set
            {
                OnPropertyChanging("appointment_connections2");
                SetRelatedEntity("appointment_connections2", null, value);
                OnPropertyChanged("appointment_connections2");
            }
        }

        /// <summary>
        ///     N:1 business_unit_connections
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_connections")]
        public BusinessUnit business_unit_connections
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_connections", null); }
        }

        /// <summary>
        ///     N:1 campaign_connections1
        /// </summary>
        [AttributeLogicalName("record1id")]
        [RelationshipSchemaName("campaign_connections1")]
        public Campaign campaign_connections1
        {
            get { return GetRelatedEntity<Campaign>("campaign_connections1", null); }
            set
            {
                OnPropertyChanging("campaign_connections1");
                SetRelatedEntity("campaign_connections1", null, value);
                OnPropertyChanged("campaign_connections1");
            }
        }

        /// <summary>
        ///     N:1 campaign_connections2
        /// </summary>
        [AttributeLogicalName("record2id")]
        [RelationshipSchemaName("campaign_connections2")]
        public Campaign campaign_connections2
        {
            get { return GetRelatedEntity<Campaign>("campaign_connections2", null); }
            set
            {
                OnPropertyChanging("campaign_connections2");
                SetRelatedEntity("campaign_connections2", null, value);
                OnPropertyChanged("campaign_connections2");
            }
        }

        /// <summary>
        ///     N:1 campaignactivity_connections1
        /// </summary>
        [AttributeLogicalName("record1id")]
        [RelationshipSchemaName("campaignactivity_connections1")]
        public CampaignActivity campaignactivity_connections1
        {
            get { return GetRelatedEntity<CampaignActivity>("campaignactivity_connections1", null); }
            set
            {
                OnPropertyChanging("campaignactivity_connections1");
                SetRelatedEntity("campaignactivity_connections1", null, value);
                OnPropertyChanged("campaignactivity_connections1");
            }
        }

        /// <summary>
        ///     N:1 campaignactivity_connections2
        /// </summary>
        [AttributeLogicalName("record2id")]
        [RelationshipSchemaName("campaignactivity_connections2")]
        public CampaignActivity campaignactivity_connections2
        {
            get { return GetRelatedEntity<CampaignActivity>("campaignactivity_connections2", null); }
            set
            {
                OnPropertyChanging("campaignactivity_connections2");
                SetRelatedEntity("campaignactivity_connections2", null, value);
                OnPropertyChanged("campaignactivity_connections2");
            }
        }

        /// <summary>
        ///     N:1 competitor_connections1
        /// </summary>
        [AttributeLogicalName("record1id")]
        [RelationshipSchemaName("competitor_connections1")]
        public Competitor competitor_connections1
        {
            get { return GetRelatedEntity<Competitor>("competitor_connections1", null); }
            set
            {
                OnPropertyChanging("competitor_connections1");
                SetRelatedEntity("competitor_connections1", null, value);
                OnPropertyChanged("competitor_connections1");
            }
        }

        /// <summary>
        ///     N:1 competitor_connections2
        /// </summary>
        [AttributeLogicalName("record2id")]
        [RelationshipSchemaName("competitor_connections2")]
        public Competitor competitor_connections2
        {
            get { return GetRelatedEntity<Competitor>("competitor_connections2", null); }
            set
            {
                OnPropertyChanging("competitor_connections2");
                SetRelatedEntity("competitor_connections2", null, value);
                OnPropertyChanged("competitor_connections2");
            }
        }

        /// <summary>
        ///     N:1 connection_related_connection
        /// </summary>
        [AttributeLogicalName("relatedconnectionid")]
        [RelationshipSchemaName("connection_related_connection", EntityRole.Referencing)]
        public Connection Referencingconnection_related_connection
        {
            get { return GetRelatedEntity<Connection>("connection_related_connection", EntityRole.Referencing); }
        }

        /// <summary>
        ///     N:1 connection_role_connections1
        /// </summary>
        [AttributeLogicalName("record1roleid")]
        [RelationshipSchemaName("connection_role_connections1")]
        public ConnectionRole connection_role_connections1
        {
            get { return GetRelatedEntity<ConnectionRole>("connection_role_connections1", null); }
            set
            {
                OnPropertyChanging("connection_role_connections1");
                SetRelatedEntity("connection_role_connections1", null, value);
                OnPropertyChanged("connection_role_connections1");
            }
        }

        /// <summary>
        ///     N:1 connection_role_connections2
        /// </summary>
        [AttributeLogicalName("record2roleid")]
        [RelationshipSchemaName("connection_role_connections2")]
        public ConnectionRole connection_role_connections2
        {
            get { return GetRelatedEntity<ConnectionRole>("connection_role_connections2", null); }
            set
            {
                OnPropertyChanging("connection_role_connections2");
                SetRelatedEntity("connection_role_connections2", null, value);
                OnPropertyChanged("connection_role_connections2");
            }
        }

        /// <summary>
        ///     N:1 constraintbasedgroup_connections1
        /// </summary>
        [AttributeLogicalName("record1id")]
        [RelationshipSchemaName("constraintbasedgroup_connections1")]
        public ConstraintBasedGroup constraintbasedgroup_connections1
        {
            get { return GetRelatedEntity<ConstraintBasedGroup>("constraintbasedgroup_connections1", null); }
            set
            {
                OnPropertyChanging("constraintbasedgroup_connections1");
                SetRelatedEntity("constraintbasedgroup_connections1", null, value);
                OnPropertyChanged("constraintbasedgroup_connections1");
            }
        }

        /// <summary>
        ///     N:1 constraintbasedgroup_connections2
        /// </summary>
        [AttributeLogicalName("record2id")]
        [RelationshipSchemaName("constraintbasedgroup_connections2")]
        public ConstraintBasedGroup constraintbasedgroup_connections2
        {
            get { return GetRelatedEntity<ConstraintBasedGroup>("constraintbasedgroup_connections2", null); }
            set
            {
                OnPropertyChanging("constraintbasedgroup_connections2");
                SetRelatedEntity("constraintbasedgroup_connections2", null, value);
                OnPropertyChanged("constraintbasedgroup_connections2");
            }
        }

        /// <summary>
        ///     N:1 contact_connections1
        /// </summary>
        [AttributeLogicalName("record1id")]
        [RelationshipSchemaName("contact_connections1")]
        public Contact contact_connections1
        {
            get { return GetRelatedEntity<Contact>("contact_connections1", null); }
            set
            {
                OnPropertyChanging("contact_connections1");
                SetRelatedEntity("contact_connections1", null, value);
                OnPropertyChanged("contact_connections1");
            }
        }

        /// <summary>
        ///     N:1 contact_connections2
        /// </summary>
        [AttributeLogicalName("record2id")]
        [RelationshipSchemaName("contact_connections2")]
        public Contact contact_connections2
        {
            get { return GetRelatedEntity<Contact>("contact_connections2", null); }
            set
            {
                OnPropertyChanging("contact_connections2");
                SetRelatedEntity("contact_connections2", null, value);
                OnPropertyChanged("contact_connections2");
            }
        }

        /// <summary>
        ///     N:1 contract_connections1
        /// </summary>
        [AttributeLogicalName("record1id")]
        [RelationshipSchemaName("contract_connections1")]
        public Contract contract_connections1
        {
            get { return GetRelatedEntity<Contract>("contract_connections1", null); }
            set
            {
                OnPropertyChanging("contract_connections1");
                SetRelatedEntity("contract_connections1", null, value);
                OnPropertyChanged("contract_connections1");
            }
        }

        /// <summary>
        ///     N:1 contract_connections2
        /// </summary>
        [AttributeLogicalName("record2id")]
        [RelationshipSchemaName("contract_connections2")]
        public Contract contract_connections2
        {
            get { return GetRelatedEntity<Contract>("contract_connections2", null); }
            set
            {
                OnPropertyChanging("contract_connections2");
                SetRelatedEntity("contract_connections2", null, value);
                OnPropertyChanged("contract_connections2");
            }
        }

        /// <summary>
        ///     N:1 createdby_connection
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("createdby_connection")]
        public SystemUser createdby_connection
        {
            get { return GetRelatedEntity<SystemUser>("createdby_connection", null); }
        }

        /// <summary>
        ///     N:1 email_connections1
        /// </summary>
        [AttributeLogicalName("record1id")]
        [RelationshipSchemaName("email_connections1")]
        public Email email_connections1
        {
            get { return GetRelatedEntity<Email>("email_connections1", null); }
            set
            {
                OnPropertyChanging("email_connections1");
                SetRelatedEntity("email_connections1", null, value);
                OnPropertyChanged("email_connections1");
            }
        }

        /// <summary>
        ///     N:1 email_connections2
        /// </summary>
        [AttributeLogicalName("record2id")]
        [RelationshipSchemaName("email_connections2")]
        public Email email_connections2
        {
            get { return GetRelatedEntity<Email>("email_connections2", null); }
            set
            {
                OnPropertyChanging("email_connections2");
                SetRelatedEntity("email_connections2", null, value);
                OnPropertyChanged("email_connections2");
            }
        }

        /// <summary>
        ///     N:1 equipment_connections1
        /// </summary>
        [AttributeLogicalName("record1id")]
        [RelationshipSchemaName("equipment_connections1")]
        public Equipment equipment_connections1
        {
            get { return GetRelatedEntity<Equipment>("equipment_connections1", null); }
            set
            {
                OnPropertyChanging("equipment_connections1");
                SetRelatedEntity("equipment_connections1", null, value);
                OnPropertyChanged("equipment_connections1");
            }
        }

        /// <summary>
        ///     N:1 equipment_connections2
        /// </summary>
        [AttributeLogicalName("record2id")]
        [RelationshipSchemaName("equipment_connections2")]
        public Equipment equipment_connections2
        {
            get { return GetRelatedEntity<Equipment>("equipment_connections2", null); }
            set
            {
                OnPropertyChanging("equipment_connections2");
                SetRelatedEntity("equipment_connections2", null, value);
                OnPropertyChanged("equipment_connections2");
            }
        }

        /// <summary>
        ///     N:1 fax_connections1
        /// </summary>
        [AttributeLogicalName("record1id")]
        [RelationshipSchemaName("fax_connections1")]
        public Fax fax_connections1
        {
            get { return GetRelatedEntity<Fax>("fax_connections1", null); }
            set
            {
                OnPropertyChanging("fax_connections1");
                SetRelatedEntity("fax_connections1", null, value);
                OnPropertyChanged("fax_connections1");
            }
        }

        /// <summary>
        ///     N:1 fax_connections2
        /// </summary>
        [AttributeLogicalName("record2id")]
        [RelationshipSchemaName("fax_connections2")]
        public Fax fax_connections2
        {
            get { return GetRelatedEntity<Fax>("fax_connections2", null); }
            set
            {
                OnPropertyChanging("fax_connections2");
                SetRelatedEntity("fax_connections2", null, value);
                OnPropertyChanged("fax_connections2");
            }
        }

        /// <summary>
        ///     N:1 goal_connections1
        /// </summary>
        [AttributeLogicalName("record1id")]
        [RelationshipSchemaName("goal_connections1")]
        public Goal goal_connections1
        {
            get { return GetRelatedEntity<Goal>("goal_connections1", null); }
            set
            {
                OnPropertyChanging("goal_connections1");
                SetRelatedEntity("goal_connections1", null, value);
                OnPropertyChanged("goal_connections1");
            }
        }

        /// <summary>
        ///     N:1 goal_connections2
        /// </summary>
        [AttributeLogicalName("record2id")]
        [RelationshipSchemaName("goal_connections2")]
        public Goal goal_connections2
        {
            get { return GetRelatedEntity<Goal>("goal_connections2", null); }
            set
            {
                OnPropertyChanging("goal_connections2");
                SetRelatedEntity("goal_connections2", null, value);
                OnPropertyChanged("goal_connections2");
            }
        }

        /// <summary>
        ///     N:1 incident_connections1
        /// </summary>
        [AttributeLogicalName("record1id")]
        [RelationshipSchemaName("incident_connections1")]
        public Incident incident_connections1
        {
            get { return GetRelatedEntity<Incident>("incident_connections1", null); }
            set
            {
                OnPropertyChanging("incident_connections1");
                SetRelatedEntity("incident_connections1", null, value);
                OnPropertyChanged("incident_connections1");
            }
        }

        /// <summary>
        ///     N:1 incident_connections2
        /// </summary>
        [AttributeLogicalName("record2id")]
        [RelationshipSchemaName("incident_connections2")]
        public Incident incident_connections2
        {
            get { return GetRelatedEntity<Incident>("incident_connections2", null); }
            set
            {
                OnPropertyChanging("incident_connections2");
                SetRelatedEntity("incident_connections2", null, value);
                OnPropertyChanged("incident_connections2");
            }
        }

        /// <summary>
        ///     N:1 invoice_connections1
        /// </summary>
        [AttributeLogicalName("record1id")]
        [RelationshipSchemaName("invoice_connections1")]
        public Invoice invoice_connections1
        {
            get { return GetRelatedEntity<Invoice>("invoice_connections1", null); }
            set
            {
                OnPropertyChanging("invoice_connections1");
                SetRelatedEntity("invoice_connections1", null, value);
                OnPropertyChanged("invoice_connections1");
            }
        }

        /// <summary>
        ///     N:1 invoice_connections2
        /// </summary>
        [AttributeLogicalName("record2id")]
        [RelationshipSchemaName("invoice_connections2")]
        public Invoice invoice_connections2
        {
            get { return GetRelatedEntity<Invoice>("invoice_connections2", null); }
            set
            {
                OnPropertyChanging("invoice_connections2");
                SetRelatedEntity("invoice_connections2", null, value);
                OnPropertyChanged("invoice_connections2");
            }
        }

        /// <summary>
        ///     N:1 lead_connections1
        /// </summary>
        [AttributeLogicalName("record1id")]
        [RelationshipSchemaName("lead_connections1")]
        public Lead lead_connections1
        {
            get { return GetRelatedEntity<Lead>("lead_connections1", null); }
            set
            {
                OnPropertyChanging("lead_connections1");
                SetRelatedEntity("lead_connections1", null, value);
                OnPropertyChanged("lead_connections1");
            }
        }

        /// <summary>
        ///     N:1 lead_connections2
        /// </summary>
        [AttributeLogicalName("record2id")]
        [RelationshipSchemaName("lead_connections2")]
        public Lead lead_connections2
        {
            get { return GetRelatedEntity<Lead>("lead_connections2", null); }
            set
            {
                OnPropertyChanging("lead_connections2");
                SetRelatedEntity("lead_connections2", null, value);
                OnPropertyChanged("lead_connections2");
            }
        }

        /// <summary>
        ///     N:1 letter_connections1
        /// </summary>
        [AttributeLogicalName("record1id")]
        [RelationshipSchemaName("letter_connections1")]
        public Letter letter_connections1
        {
            get { return GetRelatedEntity<Letter>("letter_connections1", null); }
            set
            {
                OnPropertyChanging("letter_connections1");
                SetRelatedEntity("letter_connections1", null, value);
                OnPropertyChanged("letter_connections1");
            }
        }

        /// <summary>
        ///     N:1 letter_connections2
        /// </summary>
        [AttributeLogicalName("record2id")]
        [RelationshipSchemaName("letter_connections2")]
        public Letter letter_connections2
        {
            get { return GetRelatedEntity<Letter>("letter_connections2", null); }
            set
            {
                OnPropertyChanging("letter_connections2");
                SetRelatedEntity("letter_connections2", null, value);
                OnPropertyChanged("letter_connections2");
            }
        }

        /// <summary>
        ///     N:1 list_connections1
        /// </summary>
        [AttributeLogicalName("record1id")]
        [RelationshipSchemaName("list_connections1")]
        public List list_connections1
        {
            get { return GetRelatedEntity<List>("list_connections1", null); }
            set
            {
                OnPropertyChanging("list_connections1");
                SetRelatedEntity("list_connections1", null, value);
                OnPropertyChanged("list_connections1");
            }
        }

        /// <summary>
        ///     N:1 list_connections2
        /// </summary>
        [AttributeLogicalName("record2id")]
        [RelationshipSchemaName("list_connections2")]
        public List list_connections2
        {
            get { return GetRelatedEntity<List>("list_connections2", null); }
            set
            {
                OnPropertyChanging("list_connections2");
                SetRelatedEntity("list_connections2", null, value);
                OnPropertyChanged("list_connections2");
            }
        }

        /// <summary>
        ///     N:1 lk_connectionbase_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_connectionbase_createdonbehalfby")]
        public SystemUser lk_connectionbase_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_connectionbase_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_connectionbase_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_connectionbase_modifiedonbehalfby")]
        public SystemUser lk_connectionbase_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_connectionbase_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 modifiedby_connection
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("modifiedby_connection")]
        public SystemUser modifiedby_connection
        {
            get { return GetRelatedEntity<SystemUser>("modifiedby_connection", null); }
        }

        /// <summary>
        ///     N:1 msdyn_postalbum_connections1
        /// </summary>
        [AttributeLogicalName("record1id")]
        [RelationshipSchemaName("msdyn_postalbum_connections1")]
        public msdyn_PostAlbum msdyn_postalbum_connections1
        {
            get { return GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_connections1", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_connections1");
                SetRelatedEntity("msdyn_postalbum_connections1", null, value);
                OnPropertyChanged("msdyn_postalbum_connections1");
            }
        }

        /// <summary>
        ///     N:1 msdyn_postalbum_connections2
        /// </summary>
        [AttributeLogicalName("record2id")]
        [RelationshipSchemaName("msdyn_postalbum_connections2")]
        public msdyn_PostAlbum msdyn_postalbum_connections2
        {
            get { return GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_connections2", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_connections2");
                SetRelatedEntity("msdyn_postalbum_connections2", null, value);
                OnPropertyChanged("msdyn_postalbum_connections2");
            }
        }

        /// <summary>
        ///     N:1 opportunity_connections1
        /// </summary>
        [AttributeLogicalName("record1id")]
        [RelationshipSchemaName("opportunity_connections1")]
        public Opportunity opportunity_connections1
        {
            get { return GetRelatedEntity<Opportunity>("opportunity_connections1", null); }
            set
            {
                OnPropertyChanging("opportunity_connections1");
                SetRelatedEntity("opportunity_connections1", null, value);
                OnPropertyChanged("opportunity_connections1");
            }
        }

        /// <summary>
        ///     N:1 opportunity_connections2
        /// </summary>
        [AttributeLogicalName("record2id")]
        [RelationshipSchemaName("opportunity_connections2")]
        public Opportunity opportunity_connections2
        {
            get { return GetRelatedEntity<Opportunity>("opportunity_connections2", null); }
            set
            {
                OnPropertyChanging("opportunity_connections2");
                SetRelatedEntity("opportunity_connections2", null, value);
                OnPropertyChanged("opportunity_connections2");
            }
        }

        /// <summary>
        ///     N:1 phonecall_connections1
        /// </summary>
        [AttributeLogicalName("record1id")]
        [RelationshipSchemaName("phonecall_connections1")]
        public PhoneCall phonecall_connections1
        {
            get { return GetRelatedEntity<PhoneCall>("phonecall_connections1", null); }
            set
            {
                OnPropertyChanging("phonecall_connections1");
                SetRelatedEntity("phonecall_connections1", null, value);
                OnPropertyChanged("phonecall_connections1");
            }
        }

        /// <summary>
        ///     N:1 phonecall_connections2
        /// </summary>
        [AttributeLogicalName("record2id")]
        [RelationshipSchemaName("phonecall_connections2")]
        public PhoneCall phonecall_connections2
        {
            get { return GetRelatedEntity<PhoneCall>("phonecall_connections2", null); }
            set
            {
                OnPropertyChanging("phonecall_connections2");
                SetRelatedEntity("phonecall_connections2", null, value);
                OnPropertyChanged("phonecall_connections2");
            }
        }

        /// <summary>
        ///     N:1 processsession_connections1
        /// </summary>
        [AttributeLogicalName("record1id")]
        [RelationshipSchemaName("processsession_connections1")]
        public ProcessSession processsession_connections1
        {
            get { return GetRelatedEntity<ProcessSession>("processsession_connections1", null); }
            set
            {
                OnPropertyChanging("processsession_connections1");
                SetRelatedEntity("processsession_connections1", null, value);
                OnPropertyChanged("processsession_connections1");
            }
        }

        /// <summary>
        ///     N:1 processsession_connections2
        /// </summary>
        [AttributeLogicalName("record2id")]
        [RelationshipSchemaName("processsession_connections2")]
        public ProcessSession processsession_connections2
        {
            get { return GetRelatedEntity<ProcessSession>("processsession_connections2", null); }
            set
            {
                OnPropertyChanging("processsession_connections2");
                SetRelatedEntity("processsession_connections2", null, value);
                OnPropertyChanged("processsession_connections2");
            }
        }

        /// <summary>
        ///     N:1 quote_connections1
        /// </summary>
        [AttributeLogicalName("record1id")]
        [RelationshipSchemaName("quote_connections1")]
        public Quote quote_connections1
        {
            get { return GetRelatedEntity<Quote>("quote_connections1", null); }
            set
            {
                OnPropertyChanging("quote_connections1");
                SetRelatedEntity("quote_connections1", null, value);
                OnPropertyChanged("quote_connections1");
            }
        }

        /// <summary>
        ///     N:1 quote_connections2
        /// </summary>
        [AttributeLogicalName("record2id")]
        [RelationshipSchemaName("quote_connections2")]
        public Quote quote_connections2
        {
            get { return GetRelatedEntity<Quote>("quote_connections2", null); }
            set
            {
                OnPropertyChanging("quote_connections2");
                SetRelatedEntity("quote_connections2", null, value);
                OnPropertyChanged("quote_connections2");
            }
        }

        /// <summary>
        ///     N:1 recurringappointmentmaster_connections1
        /// </summary>
        [AttributeLogicalName("record1id")]
        [RelationshipSchemaName("recurringappointmentmaster_connections1")]
        public RecurringAppointmentMaster recurringappointmentmaster_connections1
        {
            get
            {
                return GetRelatedEntity<RecurringAppointmentMaster>("recurringappointmentmaster_connections1", null);
            }
            set
            {
                OnPropertyChanging("recurringappointmentmaster_connections1");
                SetRelatedEntity("recurringappointmentmaster_connections1", null, value);
                OnPropertyChanged("recurringappointmentmaster_connections1");
            }
        }

        /// <summary>
        ///     N:1 recurringappointmentmaster_connections2
        /// </summary>
        [AttributeLogicalName("record2id")]
        [RelationshipSchemaName("recurringappointmentmaster_connections2")]
        public RecurringAppointmentMaster recurringappointmentmaster_connections2
        {
            get
            {
                return GetRelatedEntity<RecurringAppointmentMaster>("recurringappointmentmaster_connections2", null);
            }
            set
            {
                OnPropertyChanging("recurringappointmentmaster_connections2");
                SetRelatedEntity("recurringappointmentmaster_connections2", null, value);
                OnPropertyChanged("recurringappointmentmaster_connections2");
            }
        }

        /// <summary>
        ///     N:1 resourcegroup_connections1
        /// </summary>
        [AttributeLogicalName("record1id")]
        [RelationshipSchemaName("resourcegroup_connections1")]
        public ResourceGroup resourcegroup_connections1
        {
            get { return GetRelatedEntity<ResourceGroup>("resourcegroup_connections1", null); }
            set
            {
                OnPropertyChanging("resourcegroup_connections1");
                SetRelatedEntity("resourcegroup_connections1", null, value);
                OnPropertyChanged("resourcegroup_connections1");
            }
        }

        /// <summary>
        ///     N:1 resourcegroup_connections2
        /// </summary>
        [AttributeLogicalName("record2id")]
        [RelationshipSchemaName("resourcegroup_connections2")]
        public ResourceGroup resourcegroup_connections2
        {
            get { return GetRelatedEntity<ResourceGroup>("resourcegroup_connections2", null); }
            set
            {
                OnPropertyChanging("resourcegroup_connections2");
                SetRelatedEntity("resourcegroup_connections2", null, value);
                OnPropertyChanged("resourcegroup_connections2");
            }
        }

        /// <summary>
        ///     N:1 salesorder_connections1
        /// </summary>
        [AttributeLogicalName("record1id")]
        [RelationshipSchemaName("salesorder_connections1")]
        public SalesOrder salesorder_connections1
        {
            get { return GetRelatedEntity<SalesOrder>("salesorder_connections1", null); }
            set
            {
                OnPropertyChanging("salesorder_connections1");
                SetRelatedEntity("salesorder_connections1", null, value);
                OnPropertyChanged("salesorder_connections1");
            }
        }

        /// <summary>
        ///     N:1 salesorder_connections2
        /// </summary>
        [AttributeLogicalName("record2id")]
        [RelationshipSchemaName("salesorder_connections2")]
        public SalesOrder salesorder_connections2
        {
            get { return GetRelatedEntity<SalesOrder>("salesorder_connections2", null); }
            set
            {
                OnPropertyChanging("salesorder_connections2");
                SetRelatedEntity("salesorder_connections2", null, value);
                OnPropertyChanged("salesorder_connections2");
            }
        }

        /// <summary>
        ///     N:1 serviceappointment_connections1
        /// </summary>
        [AttributeLogicalName("record1id")]
        [RelationshipSchemaName("serviceappointment_connections1")]
        public ServiceAppointment serviceappointment_connections1
        {
            get { return GetRelatedEntity<ServiceAppointment>("serviceappointment_connections1", null); }
            set
            {
                OnPropertyChanging("serviceappointment_connections1");
                SetRelatedEntity("serviceappointment_connections1", null, value);
                OnPropertyChanged("serviceappointment_connections1");
            }
        }

        /// <summary>
        ///     N:1 serviceappointment_connections2
        /// </summary>
        [AttributeLogicalName("record2id")]
        [RelationshipSchemaName("serviceappointment_connections2")]
        public ServiceAppointment serviceappointment_connections2
        {
            get { return GetRelatedEntity<ServiceAppointment>("serviceappointment_connections2", null); }
            set
            {
                OnPropertyChanging("serviceappointment_connections2");
                SetRelatedEntity("serviceappointment_connections2", null, value);
                OnPropertyChanged("serviceappointment_connections2");
            }
        }

        /// <summary>
        ///     N:1 systemuser_connections1
        /// </summary>
        [AttributeLogicalName("record1id")]
        [RelationshipSchemaName("systemuser_connections1")]
        public SystemUser systemuser_connections1
        {
            get { return GetRelatedEntity<SystemUser>("systemuser_connections1", null); }
            set
            {
                OnPropertyChanging("systemuser_connections1");
                SetRelatedEntity("systemuser_connections1", null, value);
                OnPropertyChanged("systemuser_connections1");
            }
        }

        /// <summary>
        ///     N:1 systemuser_connections2
        /// </summary>
        [AttributeLogicalName("record2id")]
        [RelationshipSchemaName("systemuser_connections2")]
        public SystemUser systemuser_connections2
        {
            get { return GetRelatedEntity<SystemUser>("systemuser_connections2", null); }
            set
            {
                OnPropertyChanging("systemuser_connections2");
                SetRelatedEntity("systemuser_connections2", null, value);
                OnPropertyChanged("systemuser_connections2");
            }
        }

        /// <summary>
        ///     N:1 task_connections1
        /// </summary>
        [AttributeLogicalName("record1id")]
        [RelationshipSchemaName("task_connections1")]
        public Task task_connections1
        {
            get { return GetRelatedEntity<Task>("task_connections1", null); }
            set
            {
                OnPropertyChanging("task_connections1");
                SetRelatedEntity("task_connections1", null, value);
                OnPropertyChanged("task_connections1");
            }
        }

        /// <summary>
        ///     N:1 task_connections2
        /// </summary>
        [AttributeLogicalName("record2id")]
        [RelationshipSchemaName("task_connections2")]
        public Task task_connections2
        {
            get { return GetRelatedEntity<Task>("task_connections2", null); }
            set
            {
                OnPropertyChanging("task_connections2");
                SetRelatedEntity("task_connections2", null, value);
                OnPropertyChanged("task_connections2");
            }
        }

        /// <summary>
        ///     N:1 team_connections1
        /// </summary>
        [AttributeLogicalName("record1id")]
        [RelationshipSchemaName("team_connections1")]
        public Team team_connections1
        {
            get { return GetRelatedEntity<Team>("team_connections1", null); }
            set
            {
                OnPropertyChanging("team_connections1");
                SetRelatedEntity("team_connections1", null, value);
                OnPropertyChanged("team_connections1");
            }
        }

        /// <summary>
        ///     N:1 team_connections2
        /// </summary>
        [AttributeLogicalName("record2id")]
        [RelationshipSchemaName("team_connections2")]
        public Team team_connections2
        {
            get { return GetRelatedEntity<Team>("team_connections2", null); }
            set
            {
                OnPropertyChanging("team_connections2");
                SetRelatedEntity("team_connections2", null, value);
                OnPropertyChanged("team_connections2");
            }
        }

        /// <summary>
        ///     N:1 TransactionCurrency_Connection
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("TransactionCurrency_Connection")]
        public TransactionCurrency TransactionCurrency_Connection
        {
            get { return GetRelatedEntity<TransactionCurrency>("TransactionCurrency_Connection", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_Connection");
                SetRelatedEntity("TransactionCurrency_Connection", null, value);
                OnPropertyChanged("TransactionCurrency_Connection");
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