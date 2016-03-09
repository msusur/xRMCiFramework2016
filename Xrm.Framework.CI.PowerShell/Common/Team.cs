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
    ///     Collection of system users that routinely collaborate. Teams can be used to simplify record sharing and provide
    ///     team members with common access to organization data when team members belong to different Business Units.
    /// </summary>
    [DataContract]
    [EntityLogicalName("team")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Team : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "team";

        public const int EntityTypeCode = 9;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Team() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the user primary responsible for the team.
        /// </summary>
        [AttributeLogicalName("administratorid")]
        public EntityReference AdministratorId
        {
            get { return GetAttributeValue<EntityReference>("administratorid"); }
            set
            {
                OnPropertyChanging("AdministratorId");
                SetAttributeValue("administratorid", value);
                OnPropertyChanged("AdministratorId");
            }
        }

        /// <summary>
        ///     Unique identifier of the business unit with which the team is associated.
        /// </summary>
        [AttributeLogicalName("businessunitid")]
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
        ///     Unique identifier of the user who created the team.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the team was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the team.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Description of the team.
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
        ///     Email address for the team.
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
        ///     Exchange rate for the currency associated with the team with respect to the base currency.
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
        ///     Information about whether the team is a default business unit team.
        /// </summary>
        [AttributeLogicalName("isdefault")]
        public bool? IsDefault
        {
            get { return GetAttributeValue<bool?>("isdefault"); }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the team.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the team was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the team.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the team.
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
        ///     Unique identifier of the organization associated with the team.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public Guid? OrganizationId
        {
            get { return GetAttributeValue<Guid?>("organizationid"); }
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
        ///     Unique identifier of the default queue for the team.
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
        ///     Choose the record that the team relates to.
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
        ///     Select whether the team will be managed by the system.
        /// </summary>
        [AttributeLogicalName("systemmanaged")]
        public bool? SystemManaged
        {
            get { return GetAttributeValue<bool?>("systemmanaged"); }
        }

        /// <summary>
        ///     Unique identifier for the team.
        /// </summary>
        [AttributeLogicalName("teamid")]
        public Guid? TeamId
        {
            get { return GetAttributeValue<Guid?>("teamid"); }
            set
            {
                OnPropertyChanging("TeamId");
                SetAttributeValue("teamid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("TeamId");
            }
        }

        [AttributeLogicalName("teamid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { TeamId = value; }
        }

        /// <summary>
        ///     Shows the team template that is associated with the team.
        /// </summary>
        [AttributeLogicalName("teamtemplateid")]
        public EntityReference TeamTemplateId
        {
            get { return GetAttributeValue<EntityReference>("teamtemplateid"); }
            set
            {
                OnPropertyChanging("TeamTemplateId");
                SetAttributeValue("teamtemplateid", value);
                OnPropertyChanged("TeamTemplateId");
            }
        }

        /// <summary>
        ///     Select the team type.
        /// </summary>
        [AttributeLogicalName("teamtype")]
        public OptionSetValue TeamType
        {
            get { return GetAttributeValue<OptionSetValue>("teamtype"); }
            set
            {
                OnPropertyChanging("TeamType");
                SetAttributeValue("teamtype", value);
                OnPropertyChanged("TeamType");
            }
        }

        /// <summary>
        ///     Unique identifier of the currency associated with the team.
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
        ///     Version number of the team.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     Pronunciation of the full name of the team, written in phonetic hiragana or katakana characters.
        /// </summary>
        [AttributeLogicalName("yominame")]
        public string YomiName
        {
            get { return GetAttributeValue<string>("yominame"); }
            set
            {
                OnPropertyChanging("YomiName");
                SetAttributeValue("yominame", value);
                OnPropertyChanged("YomiName");
            }
        }

        /// <summary>
        ///     1:N ImportFile_Team
        /// </summary>
        [RelationshipSchemaName("ImportFile_Team")]
        public IEnumerable<ImportFile> ImportFile_Team
        {
            get { return GetRelatedEntities<ImportFile>("ImportFile_Team", null); }
            set
            {
                OnPropertyChanging("ImportFile_Team");
                SetRelatedEntities("ImportFile_Team", null, value);
                OnPropertyChanged("ImportFile_Team");
            }
        }

        /// <summary>
        ///     1:N lead_owning_team
        /// </summary>
        [RelationshipSchemaName("lead_owning_team")]
        public IEnumerable<Lead> lead_owning_team
        {
            get { return GetRelatedEntities<Lead>("lead_owning_team", null); }
            set
            {
                OnPropertyChanging("lead_owning_team");
                SetRelatedEntities("lead_owning_team", null, value);
                OnPropertyChanged("lead_owning_team");
            }
        }

        /// <summary>
        ///     1:N OwningTeam_postfollows
        /// </summary>
        [RelationshipSchemaName("OwningTeam_postfollows")]
        public IEnumerable<PostFollow> OwningTeam_postfollows
        {
            get { return GetRelatedEntities<PostFollow>("OwningTeam_postfollows", null); }
            set
            {
                OnPropertyChanging("OwningTeam_postfollows");
                SetRelatedEntities("OwningTeam_postfollows", null, value);
                OnPropertyChanged("OwningTeam_postfollows");
            }
        }

        /// <summary>
        ///     1:N team_accounts
        /// </summary>
        [RelationshipSchemaName("team_accounts")]
        public IEnumerable<Account> team_accounts
        {
            get { return GetRelatedEntities<Account>("team_accounts", null); }
            set
            {
                OnPropertyChanging("team_accounts");
                SetRelatedEntities("team_accounts", null, value);
                OnPropertyChanged("team_accounts");
            }
        }

        /// <summary>
        ///     1:N team_activity
        /// </summary>
        [RelationshipSchemaName("team_activity")]
        public IEnumerable<ActivityPointer> team_activity
        {
            get { return GetRelatedEntities<ActivityPointer>("team_activity", null); }
            set
            {
                OnPropertyChanging("team_activity");
                SetRelatedEntities("team_activity", null, value);
                OnPropertyChanged("team_activity");
            }
        }

        /// <summary>
        ///     1:N team_annotations
        /// </summary>
        [RelationshipSchemaName("team_annotations")]
        public IEnumerable<Annotation> team_annotations
        {
            get { return GetRelatedEntities<Annotation>("team_annotations", null); }
            set
            {
                OnPropertyChanging("team_annotations");
                SetRelatedEntities("team_annotations", null, value);
                OnPropertyChanged("team_annotations");
            }
        }

        /// <summary>
        ///     1:N team_appointment
        /// </summary>
        [RelationshipSchemaName("team_appointment")]
        public IEnumerable<Appointment> team_appointment
        {
            get { return GetRelatedEntities<Appointment>("team_appointment", null); }
            set
            {
                OnPropertyChanging("team_appointment");
                SetRelatedEntities("team_appointment", null, value);
                OnPropertyChanged("team_appointment");
            }
        }

        /// <summary>
        ///     1:N team_asyncoperation
        /// </summary>
        [RelationshipSchemaName("team_asyncoperation")]
        public IEnumerable<AsyncOperation> team_asyncoperation
        {
            get { return GetRelatedEntities<AsyncOperation>("team_asyncoperation", null); }
            set
            {
                OnPropertyChanging("team_asyncoperation");
                SetRelatedEntities("team_asyncoperation", null, value);
                OnPropertyChanged("team_asyncoperation");
            }
        }

        /// <summary>
        ///     1:N Team_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Team_AsyncOperations")]
        public IEnumerable<AsyncOperation> Team_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Team_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Team_AsyncOperations");
                SetRelatedEntities("Team_AsyncOperations", null, value);
                OnPropertyChanged("Team_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N Team_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("Team_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> Team_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("Team_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("Team_BulkDeleteFailures");
                SetRelatedEntities("Team_BulkDeleteFailures", null, value);
                OnPropertyChanged("Team_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N team_BulkOperation
        /// </summary>
        [RelationshipSchemaName("team_BulkOperation")]
        public IEnumerable<BulkOperation> team_BulkOperation
        {
            get { return GetRelatedEntities<BulkOperation>("team_BulkOperation", null); }
            set
            {
                OnPropertyChanging("team_BulkOperation");
                SetRelatedEntities("team_BulkOperation", null, value);
                OnPropertyChanged("team_BulkOperation");
            }
        }

        /// <summary>
        ///     1:N team_campaignactivity
        /// </summary>
        [RelationshipSchemaName("team_campaignactivity")]
        public IEnumerable<CampaignActivity> team_campaignactivity
        {
            get { return GetRelatedEntities<CampaignActivity>("team_campaignactivity", null); }
            set
            {
                OnPropertyChanging("team_campaignactivity");
                SetRelatedEntities("team_campaignactivity", null, value);
                OnPropertyChanged("team_campaignactivity");
            }
        }

        /// <summary>
        ///     1:N team_campaignresponse
        /// </summary>
        [RelationshipSchemaName("team_campaignresponse")]
        public IEnumerable<CampaignResponse> team_campaignresponse
        {
            get { return GetRelatedEntities<CampaignResponse>("team_campaignresponse", null); }
            set
            {
                OnPropertyChanging("team_campaignresponse");
                SetRelatedEntities("team_campaignresponse", null, value);
                OnPropertyChanged("team_campaignresponse");
            }
        }

        /// <summary>
        ///     1:N team_Campaigns
        /// </summary>
        [RelationshipSchemaName("team_Campaigns")]
        public IEnumerable<Campaign> team_Campaigns
        {
            get { return GetRelatedEntities<Campaign>("team_Campaigns", null); }
            set
            {
                OnPropertyChanging("team_Campaigns");
                SetRelatedEntities("team_Campaigns", null, value);
                OnPropertyChanged("team_Campaigns");
            }
        }

        /// <summary>
        ///     1:N team_connections1
        /// </summary>
        [RelationshipSchemaName("team_connections1")]
        public IEnumerable<Connection> team_connections1
        {
            get { return GetRelatedEntities<Connection>("team_connections1", null); }
            set
            {
                OnPropertyChanging("team_connections1");
                SetRelatedEntities("team_connections1", null, value);
                OnPropertyChanged("team_connections1");
            }
        }

        /// <summary>
        ///     1:N team_connections2
        /// </summary>
        [RelationshipSchemaName("team_connections2")]
        public IEnumerable<Connection> team_connections2
        {
            get { return GetRelatedEntities<Connection>("team_connections2", null); }
            set
            {
                OnPropertyChanging("team_connections2");
                SetRelatedEntities("team_connections2", null, value);
                OnPropertyChanged("team_connections2");
            }
        }

        /// <summary>
        ///     1:N team_contacts
        /// </summary>
        [RelationshipSchemaName("team_contacts")]
        public IEnumerable<Contact> team_contacts
        {
            get { return GetRelatedEntities<Contact>("team_contacts", null); }
            set
            {
                OnPropertyChanging("team_contacts");
                SetRelatedEntities("team_contacts", null, value);
                OnPropertyChanged("team_contacts");
            }
        }

        /// <summary>
        ///     1:N team_customer_opportunity_roles
        /// </summary>
        [RelationshipSchemaName("team_customer_opportunity_roles")]
        public IEnumerable<CustomerOpportunityRole> team_customer_opportunity_roles
        {
            get { return GetRelatedEntities<CustomerOpportunityRole>("team_customer_opportunity_roles", null); }
            set
            {
                OnPropertyChanging("team_customer_opportunity_roles");
                SetRelatedEntities("team_customer_opportunity_roles", null, value);
                OnPropertyChanged("team_customer_opportunity_roles");
            }
        }

        /// <summary>
        ///     1:N team_customer_relationship
        /// </summary>
        [RelationshipSchemaName("team_customer_relationship")]
        public IEnumerable<CustomerRelationship> team_customer_relationship
        {
            get { return GetRelatedEntities<CustomerRelationship>("team_customer_relationship", null); }
            set
            {
                OnPropertyChanging("team_customer_relationship");
                SetRelatedEntities("team_customer_relationship", null, value);
                OnPropertyChanged("team_customer_relationship");
            }
        }

        /// <summary>
        ///     1:N Team_DuplicateBaseRecord
        /// </summary>
        [RelationshipSchemaName("Team_DuplicateBaseRecord")]
        public IEnumerable<DuplicateRecord> Team_DuplicateBaseRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Team_DuplicateBaseRecord", null); }
            set
            {
                OnPropertyChanging("Team_DuplicateBaseRecord");
                SetRelatedEntities("Team_DuplicateBaseRecord", null, value);
                OnPropertyChanged("Team_DuplicateBaseRecord");
            }
        }

        /// <summary>
        ///     1:N Team_DuplicateMatchingRecord
        /// </summary>
        [RelationshipSchemaName("Team_DuplicateMatchingRecord")]
        public IEnumerable<DuplicateRecord> Team_DuplicateMatchingRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Team_DuplicateMatchingRecord", null); }
            set
            {
                OnPropertyChanging("Team_DuplicateMatchingRecord");
                SetRelatedEntities("Team_DuplicateMatchingRecord", null, value);
                OnPropertyChanged("Team_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        ///     1:N team_DuplicateRules
        /// </summary>
        [RelationshipSchemaName("team_DuplicateRules")]
        public IEnumerable<DuplicateRule> team_DuplicateRules
        {
            get { return GetRelatedEntities<DuplicateRule>("team_DuplicateRules", null); }
            set
            {
                OnPropertyChanging("team_DuplicateRules");
                SetRelatedEntities("team_DuplicateRules", null, value);
                OnPropertyChanged("team_DuplicateRules");
            }
        }

        /// <summary>
        ///     1:N team_email
        /// </summary>
        [RelationshipSchemaName("team_email")]
        public IEnumerable<Email> team_email
        {
            get { return GetRelatedEntities<Email>("team_email", null); }
            set
            {
                OnPropertyChanging("team_email");
                SetRelatedEntities("team_email", null, value);
                OnPropertyChanged("team_email");
            }
        }

        /// <summary>
        ///     1:N team_email_templates
        /// </summary>
        [RelationshipSchemaName("team_email_templates")]
        public IEnumerable<Template> team_email_templates
        {
            get { return GetRelatedEntities<Template>("team_email_templates", null); }
            set
            {
                OnPropertyChanging("team_email_templates");
                SetRelatedEntities("team_email_templates", null, value);
                OnPropertyChanged("team_email_templates");
            }
        }

        /// <summary>
        ///     1:N team_emailserverprofile
        /// </summary>
        [RelationshipSchemaName("team_emailserverprofile")]
        public IEnumerable<EmailServerProfile> team_emailserverprofile
        {
            get { return GetRelatedEntities<EmailServerProfile>("team_emailserverprofile", null); }
            set
            {
                OnPropertyChanging("team_emailserverprofile");
                SetRelatedEntities("team_emailserverprofile", null, value);
                OnPropertyChanged("team_emailserverprofile");
            }
        }

        /// <summary>
        ///     1:N team_exchangesyncidmapping
        /// </summary>
        [RelationshipSchemaName("team_exchangesyncidmapping")]
        public IEnumerable<ExchangeSyncIdMapping> team_exchangesyncidmapping
        {
            get { return GetRelatedEntities<ExchangeSyncIdMapping>("team_exchangesyncidmapping", null); }
            set
            {
                OnPropertyChanging("team_exchangesyncidmapping");
                SetRelatedEntities("team_exchangesyncidmapping", null, value);
                OnPropertyChanged("team_exchangesyncidmapping");
            }
        }

        /// <summary>
        ///     1:N team_fax
        /// </summary>
        [RelationshipSchemaName("team_fax")]
        public IEnumerable<Fax> team_fax
        {
            get { return GetRelatedEntities<Fax>("team_fax", null); }
            set
            {
                OnPropertyChanging("team_fax");
                SetRelatedEntities("team_fax", null, value);
                OnPropertyChanged("team_fax");
            }
        }

        /// <summary>
        ///     1:N team_goal
        /// </summary>
        [RelationshipSchemaName("team_goal")]
        public IEnumerable<Goal> team_goal
        {
            get { return GetRelatedEntities<Goal>("team_goal", null); }
            set
            {
                OnPropertyChanging("team_goal");
                SetRelatedEntities("team_goal", null, value);
                OnPropertyChanged("team_goal");
            }
        }

        /// <summary>
        ///     1:N team_goal_goalowner
        /// </summary>
        [RelationshipSchemaName("team_goal_goalowner")]
        public IEnumerable<Goal> team_goal_goalowner
        {
            get { return GetRelatedEntities<Goal>("team_goal_goalowner", null); }
            set
            {
                OnPropertyChanging("team_goal_goalowner");
                SetRelatedEntities("team_goal_goalowner", null, value);
                OnPropertyChanged("team_goal_goalowner");
            }
        }

        /// <summary>
        ///     1:N team_goalrollupquery
        /// </summary>
        [RelationshipSchemaName("team_goalrollupquery")]
        public IEnumerable<GoalRollupQuery> team_goalrollupquery
        {
            get { return GetRelatedEntities<GoalRollupQuery>("team_goalrollupquery", null); }
            set
            {
                OnPropertyChanging("team_goalrollupquery");
                SetRelatedEntities("team_goalrollupquery", null, value);
                OnPropertyChanged("team_goalrollupquery");
            }
        }

        /// <summary>
        ///     1:N team_ImportFiles
        /// </summary>
        [RelationshipSchemaName("team_ImportFiles")]
        public IEnumerable<ImportFile> team_ImportFiles
        {
            get { return GetRelatedEntities<ImportFile>("team_ImportFiles", null); }
            set
            {
                OnPropertyChanging("team_ImportFiles");
                SetRelatedEntities("team_ImportFiles", null, value);
                OnPropertyChanged("team_ImportFiles");
            }
        }

        /// <summary>
        ///     1:N team_ImportLogs
        /// </summary>
        [RelationshipSchemaName("team_ImportLogs")]
        public IEnumerable<ImportLog> team_ImportLogs
        {
            get { return GetRelatedEntities<ImportLog>("team_ImportLogs", null); }
            set
            {
                OnPropertyChanging("team_ImportLogs");
                SetRelatedEntities("team_ImportLogs", null, value);
                OnPropertyChanged("team_ImportLogs");
            }
        }

        /// <summary>
        ///     1:N team_ImportMaps
        /// </summary>
        [RelationshipSchemaName("team_ImportMaps")]
        public IEnumerable<ImportMap> team_ImportMaps
        {
            get { return GetRelatedEntities<ImportMap>("team_ImportMaps", null); }
            set
            {
                OnPropertyChanging("team_ImportMaps");
                SetRelatedEntities("team_ImportMaps", null, value);
                OnPropertyChanged("team_ImportMaps");
            }
        }

        /// <summary>
        ///     1:N team_Imports
        /// </summary>
        [RelationshipSchemaName("team_Imports")]
        public IEnumerable<Import> team_Imports
        {
            get { return GetRelatedEntities<Import>("team_Imports", null); }
            set
            {
                OnPropertyChanging("team_Imports");
                SetRelatedEntities("team_Imports", null, value);
                OnPropertyChanged("team_Imports");
            }
        }

        /// <summary>
        ///     1:N team_incidentresolution
        /// </summary>
        [RelationshipSchemaName("team_incidentresolution")]
        public IEnumerable<IncidentResolution> team_incidentresolution
        {
            get { return GetRelatedEntities<IncidentResolution>("team_incidentresolution", null); }
            set
            {
                OnPropertyChanging("team_incidentresolution");
                SetRelatedEntities("team_incidentresolution", null, value);
                OnPropertyChanged("team_incidentresolution");
            }
        }

        /// <summary>
        ///     1:N team_incidents
        /// </summary>
        [RelationshipSchemaName("team_incidents")]
        public IEnumerable<Incident> team_incidents
        {
            get { return GetRelatedEntities<Incident>("team_incidents", null); }
            set
            {
                OnPropertyChanging("team_incidents");
                SetRelatedEntities("team_incidents", null, value);
                OnPropertyChanged("team_incidents");
            }
        }

        /// <summary>
        ///     1:N team_invoices
        /// </summary>
        [RelationshipSchemaName("team_invoices")]
        public IEnumerable<Invoice> team_invoices
        {
            get { return GetRelatedEntities<Invoice>("team_invoices", null); }
            set
            {
                OnPropertyChanging("team_invoices");
                SetRelatedEntities("team_invoices", null, value);
                OnPropertyChanged("team_invoices");
            }
        }

        /// <summary>
        ///     1:N team_letter
        /// </summary>
        [RelationshipSchemaName("team_letter")]
        public IEnumerable<Letter> team_letter
        {
            get { return GetRelatedEntities<Letter>("team_letter", null); }
            set
            {
                OnPropertyChanging("team_letter");
                SetRelatedEntities("team_letter", null, value);
                OnPropertyChanged("team_letter");
            }
        }

        /// <summary>
        ///     1:N team_list
        /// </summary>
        [RelationshipSchemaName("team_list")]
        public IEnumerable<List> team_list
        {
            get { return GetRelatedEntities<List>("team_list", null); }
            set
            {
                OnPropertyChanging("team_list");
                SetRelatedEntities("team_list", null, value);
                OnPropertyChanged("team_list");
            }
        }

        /// <summary>
        ///     1:N team_mailbox
        /// </summary>
        [RelationshipSchemaName("team_mailbox")]
        public IEnumerable<Mailbox> team_mailbox
        {
            get { return GetRelatedEntities<Mailbox>("team_mailbox", null); }
            set
            {
                OnPropertyChanging("team_mailbox");
                SetRelatedEntities("team_mailbox", null, value);
                OnPropertyChanged("team_mailbox");
            }
        }

        /// <summary>
        ///     1:N team_msdyn_postalbum
        /// </summary>
        [RelationshipSchemaName("team_msdyn_postalbum")]
        public IEnumerable<msdyn_PostAlbum> team_msdyn_postalbum
        {
            get { return GetRelatedEntities<msdyn_PostAlbum>("team_msdyn_postalbum", null); }
            set
            {
                OnPropertyChanging("team_msdyn_postalbum");
                SetRelatedEntities("team_msdyn_postalbum", null, value);
                OnPropertyChanged("team_msdyn_postalbum");
            }
        }

        /// <summary>
        ///     1:N team_msdyn_wallsavedqueryusersettings
        /// </summary>
        [RelationshipSchemaName("team_msdyn_wallsavedqueryusersettings")]
        public IEnumerable<msdyn_wallsavedqueryusersettings> team_msdyn_wallsavedqueryusersettings
        {
            get
            {
                return GetRelatedEntities<msdyn_wallsavedqueryusersettings>("team_msdyn_wallsavedqueryusersettings",
                    null);
            }
            set
            {
                OnPropertyChanging("team_msdyn_wallsavedqueryusersettings");
                SetRelatedEntities("team_msdyn_wallsavedqueryusersettings", null, value);
                OnPropertyChanged("team_msdyn_wallsavedqueryusersettings");
            }
        }

        /// <summary>
        ///     1:N team_opportunities
        /// </summary>
        [RelationshipSchemaName("team_opportunities")]
        public IEnumerable<Opportunity> team_opportunities
        {
            get { return GetRelatedEntities<Opportunity>("team_opportunities", null); }
            set
            {
                OnPropertyChanging("team_opportunities");
                SetRelatedEntities("team_opportunities", null, value);
                OnPropertyChanged("team_opportunities");
            }
        }

        /// <summary>
        ///     1:N team_opportunityclose
        /// </summary>
        [RelationshipSchemaName("team_opportunityclose")]
        public IEnumerable<OpportunityClose> team_opportunityclose
        {
            get { return GetRelatedEntities<OpportunityClose>("team_opportunityclose", null); }
            set
            {
                OnPropertyChanging("team_opportunityclose");
                SetRelatedEntities("team_opportunityclose", null, value);
                OnPropertyChanged("team_opportunityclose");
            }
        }

        /// <summary>
        ///     1:N team_orderclose
        /// </summary>
        [RelationshipSchemaName("team_orderclose")]
        public IEnumerable<OrderClose> team_orderclose
        {
            get { return GetRelatedEntities<OrderClose>("team_orderclose", null); }
            set
            {
                OnPropertyChanging("team_orderclose");
                SetRelatedEntities("team_orderclose", null, value);
                OnPropertyChanged("team_orderclose");
            }
        }

        /// <summary>
        ///     1:N team_orders
        /// </summary>
        [RelationshipSchemaName("team_orders")]
        public IEnumerable<SalesOrder> team_orders
        {
            get { return GetRelatedEntities<SalesOrder>("team_orders", null); }
            set
            {
                OnPropertyChanging("team_orders");
                SetRelatedEntities("team_orders", null, value);
                OnPropertyChanged("team_orders");
            }
        }

        /// <summary>
        ///     1:N team_phonecall
        /// </summary>
        [RelationshipSchemaName("team_phonecall")]
        public IEnumerable<PhoneCall> team_phonecall
        {
            get { return GetRelatedEntities<PhoneCall>("team_phonecall", null); }
            set
            {
                OnPropertyChanging("team_phonecall");
                SetRelatedEntities("team_phonecall", null, value);
                OnPropertyChanged("team_phonecall");
            }
        }

        /// <summary>
        ///     1:N team_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("team_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> team_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntities<PrincipalObjectAttributeAccess>("team_principalobjectattributeaccess", null);
            }
            set
            {
                OnPropertyChanging("team_principalobjectattributeaccess");
                SetRelatedEntities("team_principalobjectattributeaccess", null, value);
                OnPropertyChanged("team_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N team_principalobjectattributeaccess_principalid
        /// </summary>
        [RelationshipSchemaName("team_principalobjectattributeaccess_principalid")]
        public IEnumerable<PrincipalObjectAttributeAccess> team_principalobjectattributeaccess_principalid
        {
            get
            {
                return
                    GetRelatedEntities<PrincipalObjectAttributeAccess>(
                        "team_principalobjectattributeaccess_principalid", null);
            }
            set
            {
                OnPropertyChanging("team_principalobjectattributeaccess_principalid");
                SetRelatedEntities("team_principalobjectattributeaccess_principalid", null, value);
                OnPropertyChanged("team_principalobjectattributeaccess_principalid");
            }
        }

        /// <summary>
        ///     1:N team_processsession
        /// </summary>
        [RelationshipSchemaName("team_processsession")]
        public IEnumerable<ProcessSession> team_processsession
        {
            get { return GetRelatedEntities<ProcessSession>("team_processsession", null); }
            set
            {
                OnPropertyChanging("team_processsession");
                SetRelatedEntities("team_processsession", null, value);
                OnPropertyChanged("team_processsession");
            }
        }

        /// <summary>
        ///     1:N Team_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("Team_ProcessSessions")]
        public IEnumerable<ProcessSession> Team_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("Team_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Team_ProcessSessions");
                SetRelatedEntities("Team_ProcessSessions", null, value);
                OnPropertyChanged("Team_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N team_queueitembase_workerid
        /// </summary>
        [RelationshipSchemaName("team_queueitembase_workerid")]
        public IEnumerable<QueueItem> team_queueitembase_workerid
        {
            get { return GetRelatedEntities<QueueItem>("team_queueitembase_workerid", null); }
            set
            {
                OnPropertyChanging("team_queueitembase_workerid");
                SetRelatedEntities("team_queueitembase_workerid", null, value);
                OnPropertyChanged("team_queueitembase_workerid");
            }
        }

        /// <summary>
        ///     1:N team_quoteclose
        /// </summary>
        [RelationshipSchemaName("team_quoteclose")]
        public IEnumerable<QuoteClose> team_quoteclose
        {
            get { return GetRelatedEntities<QuoteClose>("team_quoteclose", null); }
            set
            {
                OnPropertyChanging("team_quoteclose");
                SetRelatedEntities("team_quoteclose", null, value);
                OnPropertyChanged("team_quoteclose");
            }
        }

        /// <summary>
        ///     1:N team_quotes
        /// </summary>
        [RelationshipSchemaName("team_quotes")]
        public IEnumerable<Quote> team_quotes
        {
            get { return GetRelatedEntities<Quote>("team_quotes", null); }
            set
            {
                OnPropertyChanging("team_quotes");
                SetRelatedEntities("team_quotes", null, value);
                OnPropertyChanged("team_quotes");
            }
        }

        /// <summary>
        ///     1:N team_recurringappointmentmaster
        /// </summary>
        [RelationshipSchemaName("team_recurringappointmentmaster")]
        public IEnumerable<RecurringAppointmentMaster> team_recurringappointmentmaster
        {
            get { return GetRelatedEntities<RecurringAppointmentMaster>("team_recurringappointmentmaster", null); }
            set
            {
                OnPropertyChanging("team_recurringappointmentmaster");
                SetRelatedEntities("team_recurringappointmentmaster", null, value);
                OnPropertyChanged("team_recurringappointmentmaster");
            }
        }

        /// <summary>
        ///     1:N team_resource_groups
        /// </summary>
        [RelationshipSchemaName("team_resource_groups")]
        public IEnumerable<ResourceGroup> team_resource_groups
        {
            get { return GetRelatedEntities<ResourceGroup>("team_resource_groups", null); }
            set
            {
                OnPropertyChanging("team_resource_groups");
                SetRelatedEntities("team_resource_groups", null, value);
                OnPropertyChanged("team_resource_groups");
            }
        }

        /// <summary>
        ///     1:N team_resource_specs
        /// </summary>
        [RelationshipSchemaName("team_resource_specs")]
        public IEnumerable<ResourceSpec> team_resource_specs
        {
            get { return GetRelatedEntities<ResourceSpec>("team_resource_specs", null); }
            set
            {
                OnPropertyChanging("team_resource_specs");
                SetRelatedEntities("team_resource_specs", null, value);
                OnPropertyChanged("team_resource_specs");
            }
        }

        /// <summary>
        ///     1:N team_service_appointments
        /// </summary>
        [RelationshipSchemaName("team_service_appointments")]
        public IEnumerable<ServiceAppointment> team_service_appointments
        {
            get { return GetRelatedEntities<ServiceAppointment>("team_service_appointments", null); }
            set
            {
                OnPropertyChanging("team_service_appointments");
                SetRelatedEntities("team_service_appointments", null, value);
                OnPropertyChanged("team_service_appointments");
            }
        }

        /// <summary>
        ///     1:N team_service_contracts
        /// </summary>
        [RelationshipSchemaName("team_service_contracts")]
        public IEnumerable<Contract> team_service_contracts
        {
            get { return GetRelatedEntities<Contract>("team_service_contracts", null); }
            set
            {
                OnPropertyChanging("team_service_contracts");
                SetRelatedEntities("team_service_contracts", null, value);
                OnPropertyChanged("team_service_contracts");
            }
        }

        /// <summary>
        ///     1:N team_sharepointdocumentlocation
        /// </summary>
        [RelationshipSchemaName("team_sharepointdocumentlocation")]
        public IEnumerable<SharePointDocumentLocation> team_sharepointdocumentlocation
        {
            get { return GetRelatedEntities<SharePointDocumentLocation>("team_sharepointdocumentlocation", null); }
            set
            {
                OnPropertyChanging("team_sharepointdocumentlocation");
                SetRelatedEntities("team_sharepointdocumentlocation", null, value);
                OnPropertyChanged("team_sharepointdocumentlocation");
            }
        }

        /// <summary>
        ///     1:N team_sharepointsite
        /// </summary>
        [RelationshipSchemaName("team_sharepointsite")]
        public IEnumerable<SharePointSite> team_sharepointsite
        {
            get { return GetRelatedEntities<SharePointSite>("team_sharepointsite", null); }
            set
            {
                OnPropertyChanging("team_sharepointsite");
                SetRelatedEntities("team_sharepointsite", null, value);
                OnPropertyChanged("team_sharepointsite");
            }
        }

        /// <summary>
        ///     1:N team_task
        /// </summary>
        [RelationshipSchemaName("team_task")]
        public IEnumerable<Task> team_task
        {
            get { return GetRelatedEntities<Task>("team_task", null); }
            set
            {
                OnPropertyChanging("team_task");
                SetRelatedEntities("team_task", null, value);
                OnPropertyChanged("team_task");
            }
        }

        /// <summary>
        ///     1:N team_userentityinstancedata
        /// </summary>
        [RelationshipSchemaName("team_userentityinstancedata")]
        public IEnumerable<UserEntityInstanceData> team_userentityinstancedata
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("team_userentityinstancedata", null); }
            set
            {
                OnPropertyChanging("team_userentityinstancedata");
                SetRelatedEntities("team_userentityinstancedata", null, value);
                OnPropertyChanged("team_userentityinstancedata");
            }
        }

        /// <summary>
        ///     1:N team_userentityuisettings
        /// </summary>
        [RelationshipSchemaName("team_userentityuisettings")]
        public IEnumerable<UserEntityUISettings> team_userentityuisettings
        {
            get { return GetRelatedEntities<UserEntityUISettings>("team_userentityuisettings", null); }
            set
            {
                OnPropertyChanging("team_userentityuisettings");
                SetRelatedEntities("team_userentityuisettings", null, value);
                OnPropertyChanged("team_userentityuisettings");
            }
        }

        /// <summary>
        ///     1:N team_userform
        /// </summary>
        [RelationshipSchemaName("team_userform")]
        public IEnumerable<UserForm> team_userform
        {
            get { return GetRelatedEntities<UserForm>("team_userform", null); }
            set
            {
                OnPropertyChanging("team_userform");
                SetRelatedEntities("team_userform", null, value);
                OnPropertyChanged("team_userform");
            }
        }

        /// <summary>
        ///     1:N team_userquery
        /// </summary>
        [RelationshipSchemaName("team_userquery")]
        public IEnumerable<UserQuery> team_userquery
        {
            get { return GetRelatedEntities<UserQuery>("team_userquery", null); }
            set
            {
                OnPropertyChanging("team_userquery");
                SetRelatedEntities("team_userquery", null, value);
                OnPropertyChanged("team_userquery");
            }
        }

        /// <summary>
        ///     1:N team_userqueryvisualizations
        /// </summary>
        [RelationshipSchemaName("team_userqueryvisualizations")]
        public IEnumerable<UserQueryVisualization> team_userqueryvisualizations
        {
            get { return GetRelatedEntities<UserQueryVisualization>("team_userqueryvisualizations", null); }
            set
            {
                OnPropertyChanging("team_userqueryvisualizations");
                SetRelatedEntities("team_userqueryvisualizations", null, value);
                OnPropertyChanged("team_userqueryvisualizations");
            }
        }

        /// <summary>
        ///     1:N team_workflow
        /// </summary>
        [RelationshipSchemaName("team_workflow")]
        public IEnumerable<Workflow> team_workflow
        {
            get { return GetRelatedEntities<Workflow>("team_workflow", null); }
            set
            {
                OnPropertyChanging("team_workflow");
                SetRelatedEntities("team_workflow", null, value);
                OnPropertyChanged("team_workflow");
            }
        }

        /// <summary>
        ///     1:N team_workflowlog
        /// </summary>
        [RelationshipSchemaName("team_workflowlog")]
        public IEnumerable<WorkflowLog> team_workflowlog
        {
            get { return GetRelatedEntities<WorkflowLog>("team_workflowlog", null); }
            set
            {
                OnPropertyChanging("team_workflowlog");
                SetRelatedEntities("team_workflowlog", null, value);
                OnPropertyChanged("team_workflowlog");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_team
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_team")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_team
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_team", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_team");
                SetRelatedEntities("userentityinstancedata_team", null, value);
                OnPropertyChanged("userentityinstancedata_team");
            }
        }

        /// <summary>
        ///     N:N teammembership_association
        /// </summary>
        [RelationshipSchemaName("teammembership_association")]
        public IEnumerable<SystemUser> teammembership_association
        {
            get { return GetRelatedEntities<SystemUser>("teammembership_association", null); }
            set
            {
                OnPropertyChanging("teammembership_association");
                SetRelatedEntities("teammembership_association", null, value);
                OnPropertyChanged("teammembership_association");
            }
        }

        /// <summary>
        ///     N:N teamprofiles_association
        /// </summary>
        [RelationshipSchemaName("teamprofiles_association")]
        public IEnumerable<FieldSecurityProfile> teamprofiles_association
        {
            get { return GetRelatedEntities<FieldSecurityProfile>("teamprofiles_association", null); }
            set
            {
                OnPropertyChanging("teamprofiles_association");
                SetRelatedEntities("teamprofiles_association", null, value);
                OnPropertyChanged("teamprofiles_association");
            }
        }

        /// <summary>
        ///     N:N teamroles_association
        /// </summary>
        [RelationshipSchemaName("teamroles_association")]
        public IEnumerable<Role> teamroles_association
        {
            get { return GetRelatedEntities<Role>("teamroles_association", null); }
            set
            {
                OnPropertyChanging("teamroles_association");
                SetRelatedEntities("teamroles_association", null, value);
                OnPropertyChanged("teamroles_association");
            }
        }

        /// <summary>
        ///     N:1 business_unit_teams
        /// </summary>
        [AttributeLogicalName("businessunitid")]
        [RelationshipSchemaName("business_unit_teams")]
        public BusinessUnit business_unit_teams
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_teams", null); }
            set
            {
                OnPropertyChanging("business_unit_teams");
                SetRelatedEntity("business_unit_teams", null, value);
                OnPropertyChanged("business_unit_teams");
            }
        }

        /// <summary>
        ///     N:1 lk_team_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_team_createdonbehalfby")]
        public SystemUser lk_team_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_team_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_team_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_team_modifiedonbehalfby")]
        public SystemUser lk_team_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_team_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_teambase_administratorid
        /// </summary>
        [AttributeLogicalName("administratorid")]
        [RelationshipSchemaName("lk_teambase_administratorid")]
        public SystemUser lk_teambase_administratorid
        {
            get { return GetRelatedEntity<SystemUser>("lk_teambase_administratorid", null); }
            set
            {
                OnPropertyChanging("lk_teambase_administratorid");
                SetRelatedEntity("lk_teambase_administratorid", null, value);
                OnPropertyChanged("lk_teambase_administratorid");
            }
        }

        /// <summary>
        ///     N:1 lk_teambase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_teambase_createdby")]
        public SystemUser lk_teambase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_teambase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_teambase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_teambase_modifiedby")]
        public SystemUser lk_teambase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_teambase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 opportunity_Teams
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("opportunity_Teams")]
        public Opportunity opportunity_Teams
        {
            get { return GetRelatedEntity<Opportunity>("opportunity_Teams", null); }
            set
            {
                OnPropertyChanging("opportunity_Teams");
                SetRelatedEntity("opportunity_Teams", null, value);
                OnPropertyChanged("opportunity_Teams");
            }
        }

        /// <summary>
        ///     N:1 organization_teams
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_teams")]
        public Organization organization_teams
        {
            get { return GetRelatedEntity<Organization>("organization_teams", null); }
        }

        /// <summary>
        ///     N:1 processstage_teams
        /// </summary>
        [AttributeLogicalName("stageid")]
        [RelationshipSchemaName("processstage_teams")]
        public ProcessStage processstage_teams
        {
            get { return GetRelatedEntity<ProcessStage>("processstage_teams", null); }
            set
            {
                OnPropertyChanging("processstage_teams");
                SetRelatedEntity("processstage_teams", null, value);
                OnPropertyChanged("processstage_teams");
            }
        }

        /// <summary>
        ///     N:1 queue_team
        /// </summary>
        [AttributeLogicalName("queueid")]
        [RelationshipSchemaName("queue_team")]
        public Queue queue_team
        {
            get { return GetRelatedEntity<Queue>("queue_team", null); }
            set
            {
                OnPropertyChanging("queue_team");
                SetRelatedEntity("queue_team", null, value);
                OnPropertyChanged("queue_team");
            }
        }

        /// <summary>
        ///     N:1 teamtemplate_Teams
        /// </summary>
        [AttributeLogicalName("teamtemplateid")]
        [RelationshipSchemaName("teamtemplate_Teams")]
        public TeamTemplate teamtemplate_Teams
        {
            get { return GetRelatedEntity<TeamTemplate>("teamtemplate_Teams", null); }
            set
            {
                OnPropertyChanging("teamtemplate_Teams");
                SetRelatedEntity("teamtemplate_Teams", null, value);
                OnPropertyChanged("teamtemplate_Teams");
            }
        }

        /// <summary>
        ///     N:1 TransactionCurrency_Team
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("TransactionCurrency_Team")]
        public TransactionCurrency TransactionCurrency_Team
        {
            get { return GetRelatedEntity<TransactionCurrency>("TransactionCurrency_Team", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_Team");
                SetRelatedEntity("TransactionCurrency_Team", null, value);
                OnPropertyChanged("TransactionCurrency_Team");
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