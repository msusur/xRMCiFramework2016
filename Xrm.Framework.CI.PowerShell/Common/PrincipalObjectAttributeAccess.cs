using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Xrm.Framework.CI.PowerShell.Common;

namespace Xrm.Framework.CI.Common.Entities
{
    /// <summary>
    ///     Defines CRM security principals (users and teams) access rights to secured field for an entity instance.
    /// </summary>
    [DataContract]
    [EntityLogicalName("principalobjectattributeaccess")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class PrincipalObjectAttributeAccess : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "principalobjectattributeaccess";

        public const int EntityTypeCode = 44;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public PrincipalObjectAttributeAccess() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the shared secured field
        /// </summary>
        [AttributeLogicalName("attributeid")]
        public Guid? AttributeId
        {
            get { return GetAttributeValue<Guid?>("attributeid"); }
            set
            {
                OnPropertyChanging("AttributeId");
                SetAttributeValue("attributeid", value);
                OnPropertyChanged("AttributeId");
            }
        }

        /// <summary>
        ///     Unique identifier of the entity instance with shared secured field
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
        ///     Unique identifier of the associated organization.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     Unique identifier of the principal to which secured field is shared
        /// </summary>
        [AttributeLogicalName("principalid")]
        public EntityReference PrincipalId
        {
            get { return GetAttributeValue<EntityReference>("principalid"); }
            set
            {
                OnPropertyChanging("PrincipalId");
                SetAttributeValue("principalid", value);
                OnPropertyChanged("PrincipalId");
            }
        }

        /// <summary>
        ///     Unique identifier of the shared secured field instance
        /// </summary>
        [AttributeLogicalName("principalobjectattributeaccessid")]
        public Guid? PrincipalObjectAttributeAccessId
        {
            get { return GetAttributeValue<Guid?>("principalobjectattributeaccessid"); }
            set
            {
                OnPropertyChanging("PrincipalObjectAttributeAccessId");
                SetAttributeValue("principalobjectattributeaccessid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("PrincipalObjectAttributeAccessId");
            }
        }

        [AttributeLogicalName("principalobjectattributeaccessid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { PrincipalObjectAttributeAccessId = value; }
        }

        /// <summary>
        ///     Read permission for secured field instance
        /// </summary>
        [AttributeLogicalName("readaccess")]
        public bool? ReadAccess
        {
            get { return GetAttributeValue<bool?>("readaccess"); }
            set
            {
                OnPropertyChanging("ReadAccess");
                SetAttributeValue("readaccess", value);
                OnPropertyChanged("ReadAccess");
            }
        }

        /// <summary>
        ///     Update permission for secured field instance
        /// </summary>
        [AttributeLogicalName("updateaccess")]
        public bool? UpdateAccess
        {
            get { return GetAttributeValue<bool?>("updateaccess"); }
            set
            {
                OnPropertyChanging("UpdateAccess");
                SetAttributeValue("updateaccess", value);
                OnPropertyChanged("UpdateAccess");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N userentityinstancedata_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_principalobjectattributeaccess")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_principalobjectattributeaccess
        {
            get
            {
                return
                    GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_principalobjectattributeaccess",
                        null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_principalobjectattributeaccess");
                SetRelatedEntities("userentityinstancedata_principalobjectattributeaccess", null, value);
                OnPropertyChanged("userentityinstancedata_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 account_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("account_principalobjectattributeaccess")]
        public Account account_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<Account>("account_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("account_principalobjectattributeaccess");
                SetRelatedEntity("account_principalobjectattributeaccess", null, value);
                OnPropertyChanged("account_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 appointment_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("appointment_principalobjectattributeaccess")]
        public Appointment appointment_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<Appointment>("appointment_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("appointment_principalobjectattributeaccess");
                SetRelatedEntity("appointment_principalobjectattributeaccess", null, value);
                OnPropertyChanged("appointment_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 businessunit_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("businessunit_principalobjectattributeaccess")]
        public BusinessUnit businessunit_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<BusinessUnit>("businessunit_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("businessunit_principalobjectattributeaccess");
                SetRelatedEntity("businessunit_principalobjectattributeaccess", null, value);
                OnPropertyChanged("businessunit_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 campaign_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("campaign_principalobjectattributeaccess")]
        public Campaign campaign_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<Campaign>("campaign_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("campaign_principalobjectattributeaccess");
                SetRelatedEntity("campaign_principalobjectattributeaccess", null, value);
                OnPropertyChanged("campaign_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 campaignactivity_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("campaignactivity_principalobjectattributeaccess")]
        public CampaignActivity campaignactivity_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<CampaignActivity>("campaignactivity_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("campaignactivity_principalobjectattributeaccess");
                SetRelatedEntity("campaignactivity_principalobjectattributeaccess", null, value);
                OnPropertyChanged("campaignactivity_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 campaignresponse_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("campaignresponse_principalobjectattributeaccess")]
        public CampaignResponse campaignresponse_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<CampaignResponse>("campaignresponse_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("campaignresponse_principalobjectattributeaccess");
                SetRelatedEntity("campaignresponse_principalobjectattributeaccess", null, value);
                OnPropertyChanged("campaignresponse_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 competitor_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("competitor_principalobjectattributeaccess")]
        public Competitor competitor_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<Competitor>("competitor_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("competitor_principalobjectattributeaccess");
                SetRelatedEntity("competitor_principalobjectattributeaccess", null, value);
                OnPropertyChanged("competitor_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 connection_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("connection_principalobjectattributeaccess")]
        public Connection connection_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<Connection>("connection_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("connection_principalobjectattributeaccess");
                SetRelatedEntity("connection_principalobjectattributeaccess", null, value);
                OnPropertyChanged("connection_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 contact_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("contact_principalobjectattributeaccess")]
        public Contact contact_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<Contact>("contact_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("contact_principalobjectattributeaccess");
                SetRelatedEntity("contact_principalobjectattributeaccess", null, value);
                OnPropertyChanged("contact_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 contract_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("contract_principalobjectattributeaccess")]
        public Contract contract_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<Contract>("contract_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("contract_principalobjectattributeaccess");
                SetRelatedEntity("contract_principalobjectattributeaccess", null, value);
                OnPropertyChanged("contract_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 contractdetail_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("contractdetail_principalobjectattributeaccess")]
        public ContractDetail contractdetail_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<ContractDetail>("contractdetail_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("contractdetail_principalobjectattributeaccess");
                SetRelatedEntity("contractdetail_principalobjectattributeaccess", null, value);
                OnPropertyChanged("contractdetail_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 customeraddress_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("customeraddress_principalobjectattributeaccess")]
        public CustomerAddress customeraddress_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<CustomerAddress>("customeraddress_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("customeraddress_principalobjectattributeaccess");
                SetRelatedEntity("customeraddress_principalobjectattributeaccess", null, value);
                OnPropertyChanged("customeraddress_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 email_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("email_principalobjectattributeaccess")]
        public Email email_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<Email>("email_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("email_principalobjectattributeaccess");
                SetRelatedEntity("email_principalobjectattributeaccess", null, value);
                OnPropertyChanged("email_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 equipment_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("equipment_principalobjectattributeaccess")]
        public Equipment equipment_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<Equipment>("equipment_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("equipment_principalobjectattributeaccess");
                SetRelatedEntity("equipment_principalobjectattributeaccess", null, value);
                OnPropertyChanged("equipment_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 fax_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("fax_principalobjectattributeaccess")]
        public Fax fax_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<Fax>("fax_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("fax_principalobjectattributeaccess");
                SetRelatedEntity("fax_principalobjectattributeaccess", null, value);
                OnPropertyChanged("fax_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 goal_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("goal_principalobjectattributeaccess")]
        public Goal goal_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<Goal>("goal_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("goal_principalobjectattributeaccess");
                SetRelatedEntity("goal_principalobjectattributeaccess", null, value);
                OnPropertyChanged("goal_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 incident_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("incident_principalobjectattributeaccess")]
        public Incident incident_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<Incident>("incident_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("incident_principalobjectattributeaccess");
                SetRelatedEntity("incident_principalobjectattributeaccess", null, value);
                OnPropertyChanged("incident_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 invoice_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("invoice_principalobjectattributeaccess")]
        public Invoice invoice_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<Invoice>("invoice_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("invoice_principalobjectattributeaccess");
                SetRelatedEntity("invoice_principalobjectattributeaccess", null, value);
                OnPropertyChanged("invoice_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 invoicedetail_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("invoicedetail_principalobjectattributeaccess")]
        public InvoiceDetail invoicedetail_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<InvoiceDetail>("invoicedetail_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("invoicedetail_principalobjectattributeaccess");
                SetRelatedEntity("invoicedetail_principalobjectattributeaccess", null, value);
                OnPropertyChanged("invoicedetail_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 kbarticle_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("kbarticle_principalobjectattributeaccess")]
        public KbArticle kbarticle_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<KbArticle>("kbarticle_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("kbarticle_principalobjectattributeaccess");
                SetRelatedEntity("kbarticle_principalobjectattributeaccess", null, value);
                OnPropertyChanged("kbarticle_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 lead_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("lead_principalobjectattributeaccess")]
        public Lead lead_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<Lead>("lead_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("lead_principalobjectattributeaccess");
                SetRelatedEntity("lead_principalobjectattributeaccess", null, value);
                OnPropertyChanged("lead_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 letter_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("letter_principalobjectattributeaccess")]
        public Letter letter_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<Letter>("letter_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("letter_principalobjectattributeaccess");
                SetRelatedEntity("letter_principalobjectattributeaccess", null, value);
                OnPropertyChanged("letter_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 list_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("list_principalobjectattributeaccess")]
        public List list_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<List>("list_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("list_principalobjectattributeaccess");
                SetRelatedEntity("list_principalobjectattributeaccess", null, value);
                OnPropertyChanged("list_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 lk_principalobjectattributeaccess_organizationid
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("lk_principalobjectattributeaccess_organizationid")]
        public Organization lk_principalobjectattributeaccess_organizationid
        {
            get { return GetRelatedEntity<Organization>("lk_principalobjectattributeaccess_organizationid", null); }
        }

        /// <summary>
        ///     N:1 mailmergetemplate_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("mailmergetemplate_principalobjectattributeaccess")]
        public MailMergeTemplate mailmergetemplate_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntity<MailMergeTemplate>("mailmergetemplate_principalobjectattributeaccess", null);
            }
            set
            {
                OnPropertyChanging("mailmergetemplate_principalobjectattributeaccess");
                SetRelatedEntity("mailmergetemplate_principalobjectattributeaccess", null, value);
                OnPropertyChanged("mailmergetemplate_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 msdyn_postalbum_PrincipalObjectAttributeAccesses
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("msdyn_postalbum_PrincipalObjectAttributeAccesses")]
        public msdyn_PostAlbum msdyn_postalbum_PrincipalObjectAttributeAccesses
        {
            get { return GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_PrincipalObjectAttributeAccesses", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_PrincipalObjectAttributeAccesses");
                SetRelatedEntity("msdyn_postalbum_PrincipalObjectAttributeAccesses", null, value);
                OnPropertyChanged("msdyn_postalbum_PrincipalObjectAttributeAccesses");
            }
        }

        /// <summary>
        ///     N:1 msdyn_postconfig_PrincipalObjectAttributeAccesses
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("msdyn_postconfig_PrincipalObjectAttributeAccesses")]
        public msdyn_PostConfig msdyn_postconfig_PrincipalObjectAttributeAccesses
        {
            get
            {
                return GetRelatedEntity<msdyn_PostConfig>("msdyn_postconfig_PrincipalObjectAttributeAccesses", null);
            }
            set
            {
                OnPropertyChanging("msdyn_postconfig_PrincipalObjectAttributeAccesses");
                SetRelatedEntity("msdyn_postconfig_PrincipalObjectAttributeAccesses", null, value);
                OnPropertyChanged("msdyn_postconfig_PrincipalObjectAttributeAccesses");
            }
        }

        /// <summary>
        ///     N:1 msdyn_postruleconfig_PrincipalObjectAttributeAccesses
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("msdyn_postruleconfig_PrincipalObjectAttributeAccesses")]
        public msdyn_PostRuleConfig msdyn_postruleconfig_PrincipalObjectAttributeAccesses
        {
            get
            {
                return GetRelatedEntity<msdyn_PostRuleConfig>("msdyn_postruleconfig_PrincipalObjectAttributeAccesses",
                    null);
            }
            set
            {
                OnPropertyChanging("msdyn_postruleconfig_PrincipalObjectAttributeAccesses");
                SetRelatedEntity("msdyn_postruleconfig_PrincipalObjectAttributeAccesses", null, value);
                OnPropertyChanged("msdyn_postruleconfig_PrincipalObjectAttributeAccesses");
            }
        }

        /// <summary>
        ///     N:1 msdyn_wallsavedquery_PrincipalObjectAttributeAccesses
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("msdyn_wallsavedquery_PrincipalObjectAttributeAccesses")]
        public msdyn_wallsavedquery msdyn_wallsavedquery_PrincipalObjectAttributeAccesses
        {
            get
            {
                return GetRelatedEntity<msdyn_wallsavedquery>("msdyn_wallsavedquery_PrincipalObjectAttributeAccesses",
                    null);
            }
            set
            {
                OnPropertyChanging("msdyn_wallsavedquery_PrincipalObjectAttributeAccesses");
                SetRelatedEntity("msdyn_wallsavedquery_PrincipalObjectAttributeAccesses", null, value);
                OnPropertyChanged("msdyn_wallsavedquery_PrincipalObjectAttributeAccesses");
            }
        }

        /// <summary>
        ///     N:1 msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses")]
        public msdyn_wallsavedqueryusersettings msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses
        {
            get
            {
                return
                    GetRelatedEntity<msdyn_wallsavedqueryusersettings>(
                        "msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses", null);
            }
            set
            {
                OnPropertyChanging("msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses");
                SetRelatedEntity("msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses", null, value);
                OnPropertyChanged("msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses");
            }
        }

        /// <summary>
        ///     N:1 opportunity_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("opportunity_principalobjectattributeaccess")]
        public Opportunity opportunity_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<Opportunity>("opportunity_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("opportunity_principalobjectattributeaccess");
                SetRelatedEntity("opportunity_principalobjectattributeaccess", null, value);
                OnPropertyChanged("opportunity_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 opportunityproduct_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("opportunityproduct_principalobjectattributeaccess")]
        public OpportunityProduct opportunityproduct_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntity<OpportunityProduct>("opportunityproduct_principalobjectattributeaccess", null);
            }
            set
            {
                OnPropertyChanging("opportunityproduct_principalobjectattributeaccess");
                SetRelatedEntity("opportunityproduct_principalobjectattributeaccess", null, value);
                OnPropertyChanged("opportunityproduct_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 phonecall_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("phonecall_principalobjectattributeaccess")]
        public PhoneCall phonecall_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<PhoneCall>("phonecall_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("phonecall_principalobjectattributeaccess");
                SetRelatedEntity("phonecall_principalobjectattributeaccess", null, value);
                OnPropertyChanged("phonecall_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 pricelevel_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("pricelevel_principalobjectattributeaccess")]
        public PriceLevel pricelevel_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<PriceLevel>("pricelevel_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("pricelevel_principalobjectattributeaccess");
                SetRelatedEntity("pricelevel_principalobjectattributeaccess", null, value);
                OnPropertyChanged("pricelevel_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 product_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("product_principalobjectattributeaccess")]
        public Product product_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<Product>("product_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("product_principalobjectattributeaccess");
                SetRelatedEntity("product_principalobjectattributeaccess", null, value);
                OnPropertyChanged("product_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 queue_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("queue_principalobjectattributeaccess")]
        public Queue queue_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<Queue>("queue_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("queue_principalobjectattributeaccess");
                SetRelatedEntity("queue_principalobjectattributeaccess", null, value);
                OnPropertyChanged("queue_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 queueitem_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("queueitem_principalobjectattributeaccess")]
        public QueueItem queueitem_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<QueueItem>("queueitem_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("queueitem_principalobjectattributeaccess");
                SetRelatedEntity("queueitem_principalobjectattributeaccess", null, value);
                OnPropertyChanged("queueitem_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 quote_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("quote_principalobjectattributeaccess")]
        public Quote quote_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<Quote>("quote_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("quote_principalobjectattributeaccess");
                SetRelatedEntity("quote_principalobjectattributeaccess", null, value);
                OnPropertyChanged("quote_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 quotedetail_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("quotedetail_principalobjectattributeaccess")]
        public QuoteDetail quotedetail_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<QuoteDetail>("quotedetail_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("quotedetail_principalobjectattributeaccess");
                SetRelatedEntity("quotedetail_principalobjectattributeaccess", null, value);
                OnPropertyChanged("quotedetail_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 recurringappointmentmaster_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("recurringappointmentmaster_principalobjectattributeaccess")]
        public RecurringAppointmentMaster recurringappointmentmaster_principalobjectattributeaccess
        {
            get
            {
                return
                    GetRelatedEntity<RecurringAppointmentMaster>(
                        "recurringappointmentmaster_principalobjectattributeaccess", null);
            }
            set
            {
                OnPropertyChanging("recurringappointmentmaster_principalobjectattributeaccess");
                SetRelatedEntity("recurringappointmentmaster_principalobjectattributeaccess", null, value);
                OnPropertyChanged("recurringappointmentmaster_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 reportcategory_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("reportcategory_principalobjectattributeaccess")]
        public ReportCategory reportcategory_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<ReportCategory>("reportcategory_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("reportcategory_principalobjectattributeaccess");
                SetRelatedEntity("reportcategory_principalobjectattributeaccess", null, value);
                OnPropertyChanged("reportcategory_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 salesliterature_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("salesliterature_principalobjectattributeaccess")]
        public SalesLiterature salesliterature_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<SalesLiterature>("salesliterature_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("salesliterature_principalobjectattributeaccess");
                SetRelatedEntity("salesliterature_principalobjectattributeaccess", null, value);
                OnPropertyChanged("salesliterature_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 salesorder_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("salesorder_principalobjectattributeaccess")]
        public SalesOrder salesorder_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<SalesOrder>("salesorder_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("salesorder_principalobjectattributeaccess");
                SetRelatedEntity("salesorder_principalobjectattributeaccess", null, value);
                OnPropertyChanged("salesorder_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 salesorderdetail_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("salesorderdetail_principalobjectattributeaccess")]
        public SalesOrderDetail salesorderdetail_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<SalesOrderDetail>("salesorderdetail_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("salesorderdetail_principalobjectattributeaccess");
                SetRelatedEntity("salesorderdetail_principalobjectattributeaccess", null, value);
                OnPropertyChanged("salesorderdetail_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 serviceappointment_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("serviceappointment_principalobjectattributeaccess")]
        public ServiceAppointment serviceappointment_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntity<ServiceAppointment>("serviceappointment_principalobjectattributeaccess", null);
            }
            set
            {
                OnPropertyChanging("serviceappointment_principalobjectattributeaccess");
                SetRelatedEntity("serviceappointment_principalobjectattributeaccess", null, value);
                OnPropertyChanged("serviceappointment_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 sharepointdocumentlocation_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("sharepointdocumentlocation_principalobjectattributeaccess")]
        public SharePointDocumentLocation sharepointdocumentlocation_principalobjectattributeaccess
        {
            get
            {
                return
                    GetRelatedEntity<SharePointDocumentLocation>(
                        "sharepointdocumentlocation_principalobjectattributeaccess", null);
            }
            set
            {
                OnPropertyChanging("sharepointdocumentlocation_principalobjectattributeaccess");
                SetRelatedEntity("sharepointdocumentlocation_principalobjectattributeaccess", null, value);
                OnPropertyChanged("sharepointdocumentlocation_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 sharepointsite_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("sharepointsite_principalobjectattributeaccess")]
        public SharePointSite sharepointsite_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<SharePointSite>("sharepointsite_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("sharepointsite_principalobjectattributeaccess");
                SetRelatedEntity("sharepointsite_principalobjectattributeaccess", null, value);
                OnPropertyChanged("sharepointsite_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 systemuser_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("systemuser_principalobjectattributeaccess")]
        public SystemUser systemuser_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<SystemUser>("systemuser_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("systemuser_principalobjectattributeaccess");
                SetRelatedEntity("systemuser_principalobjectattributeaccess", null, value);
                OnPropertyChanged("systemuser_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 systemuser_principalobjectattributeaccess_principalid
        /// </summary>
        [AttributeLogicalName("principalid")]
        [RelationshipSchemaName("systemuser_principalobjectattributeaccess_principalid")]
        public SystemUser systemuser_principalobjectattributeaccess_principalid
        {
            get { return GetRelatedEntity<SystemUser>("systemuser_principalobjectattributeaccess_principalid", null); }
            set
            {
                OnPropertyChanging("systemuser_principalobjectattributeaccess_principalid");
                SetRelatedEntity("systemuser_principalobjectattributeaccess_principalid", null, value);
                OnPropertyChanged("systemuser_principalobjectattributeaccess_principalid");
            }
        }

        /// <summary>
        ///     N:1 task_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("task_principalobjectattributeaccess")]
        public Task task_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<Task>("task_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("task_principalobjectattributeaccess");
                SetRelatedEntity("task_principalobjectattributeaccess", null, value);
                OnPropertyChanged("task_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 team_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("team_principalobjectattributeaccess")]
        public Team team_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<Team>("team_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("team_principalobjectattributeaccess");
                SetRelatedEntity("team_principalobjectattributeaccess", null, value);
                OnPropertyChanged("team_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 team_principalobjectattributeaccess_principalid
        /// </summary>
        [AttributeLogicalName("principalid")]
        [RelationshipSchemaName("team_principalobjectattributeaccess_principalid")]
        public Team team_principalobjectattributeaccess_principalid
        {
            get { return GetRelatedEntity<Team>("team_principalobjectattributeaccess_principalid", null); }
            set
            {
                OnPropertyChanging("team_principalobjectattributeaccess_principalid");
                SetRelatedEntity("team_principalobjectattributeaccess_principalid", null, value);
                OnPropertyChanged("team_principalobjectattributeaccess_principalid");
            }
        }

        /// <summary>
        ///     N:1 territory_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("territory_principalobjectattributeaccess")]
        public Territory territory_principalobjectattributeaccess
        {
            get { return GetRelatedEntity<Territory>("territory_principalobjectattributeaccess", null); }
            set
            {
                OnPropertyChanging("territory_principalobjectattributeaccess");
                SetRelatedEntity("territory_principalobjectattributeaccess", null, value);
                OnPropertyChanged("territory_principalobjectattributeaccess");
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