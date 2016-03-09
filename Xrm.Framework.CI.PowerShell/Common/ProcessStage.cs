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
    ///     Stage associated with a process.
    /// </summary>
    [DataContract]
    [EntityLogicalName("processstage")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ProcessStage : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "processstage";

        public const int EntityTypeCode = 4724;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ProcessStage() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Enter the user or team who is assigned to manage the record. This field is updated every time the record is
        ///     assigned to a different user.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId
        {
            get { return GetAttributeValue<EntityReference>("ownerid"); }
        }

        /// <summary>
        ///     Select the business unit that owns the record.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public Guid? OwningBusinessUnit
        {
            get { return GetAttributeValue<Guid?>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Primary entity associated with the stage.
        /// </summary>
        [AttributeLogicalName("primaryentitytypecode")]
        public string PrimaryEntityTypeCode
        {
            get { return GetAttributeValue<string>("primaryentitytypecode"); }
            set
            {
                OnPropertyChanging("PrimaryEntityTypeCode");
                SetAttributeValue("primaryentitytypecode", value);
                OnPropertyChanged("PrimaryEntityTypeCode");
            }
        }

        /// <summary>
        ///     Shows the ID of the process.
        /// </summary>
        [AttributeLogicalName("processid")]
        public EntityReference ProcessId
        {
            get { return GetAttributeValue<EntityReference>("processid"); }
            set
            {
                OnPropertyChanging("ProcessId");
                SetAttributeValue("processid", value);
                OnPropertyChanged("ProcessId");
            }
        }

        /// <summary>
        ///     Shows the ID of the process stage record.
        /// </summary>
        [AttributeLogicalName("processstageid")]
        public Guid? ProcessStageId
        {
            get { return GetAttributeValue<Guid?>("processstageid"); }
            set
            {
                OnPropertyChanging("ProcessStageId");
                SetAttributeValue("processstageid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ProcessStageId");
            }
        }

        [AttributeLogicalName("processstageid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ProcessStageId = value; }
        }

        /// <summary>
        ///     Select the category of the sales process.
        /// </summary>
        [AttributeLogicalName("stagecategory")]
        public OptionSetValue StageCategory
        {
            get { return GetAttributeValue<OptionSetValue>("stagecategory"); }
            set
            {
                OnPropertyChanging("StageCategory");
                SetAttributeValue("stagecategory", value);
                OnPropertyChanged("StageCategory");
            }
        }

        /// <summary>
        ///     Type a name for the process stage.
        /// </summary>
        [AttributeLogicalName("stagename")]
        public string StageName
        {
            get { return GetAttributeValue<string>("stagename"); }
            set
            {
                OnPropertyChanging("StageName");
                SetAttributeValue("stagename", value);
                OnPropertyChanged("StageName");
            }
        }

        /// <summary>
        ///     Version number of the process stage.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N processstage_account
        /// </summary>
        [RelationshipSchemaName("processstage_account")]
        public IEnumerable<Account> processstage_account
        {
            get { return GetRelatedEntities<Account>("processstage_account", null); }
            set
            {
                OnPropertyChanging("processstage_account");
                SetRelatedEntities("processstage_account", null, value);
                OnPropertyChanged("processstage_account");
            }
        }

        /// <summary>
        ///     1:N processstage_appointments
        /// </summary>
        [RelationshipSchemaName("processstage_appointments")]
        public IEnumerable<Appointment> processstage_appointments
        {
            get { return GetRelatedEntities<Appointment>("processstage_appointments", null); }
            set
            {
                OnPropertyChanging("processstage_appointments");
                SetRelatedEntities("processstage_appointments", null, value);
                OnPropertyChanged("processstage_appointments");
            }
        }

        /// <summary>
        ///     1:N processstage_campaignactivities
        /// </summary>
        [RelationshipSchemaName("processstage_campaignactivities")]
        public IEnumerable<CampaignActivity> processstage_campaignactivities
        {
            get { return GetRelatedEntities<CampaignActivity>("processstage_campaignactivities", null); }
            set
            {
                OnPropertyChanging("processstage_campaignactivities");
                SetRelatedEntities("processstage_campaignactivities", null, value);
                OnPropertyChanged("processstage_campaignactivities");
            }
        }

        /// <summary>
        ///     1:N processstage_campaignresponses
        /// </summary>
        [RelationshipSchemaName("processstage_campaignresponses")]
        public IEnumerable<CampaignResponse> processstage_campaignresponses
        {
            get { return GetRelatedEntities<CampaignResponse>("processstage_campaignresponses", null); }
            set
            {
                OnPropertyChanging("processstage_campaignresponses");
                SetRelatedEntities("processstage_campaignresponses", null, value);
                OnPropertyChanged("processstage_campaignresponses");
            }
        }

        /// <summary>
        ///     1:N processstage_campaigns
        /// </summary>
        [RelationshipSchemaName("processstage_campaigns")]
        public IEnumerable<Campaign> processstage_campaigns
        {
            get { return GetRelatedEntities<Campaign>("processstage_campaigns", null); }
            set
            {
                OnPropertyChanging("processstage_campaigns");
                SetRelatedEntities("processstage_campaigns", null, value);
                OnPropertyChanged("processstage_campaigns");
            }
        }

        /// <summary>
        ///     1:N processstage_competitors
        /// </summary>
        [RelationshipSchemaName("processstage_competitors")]
        public IEnumerable<Competitor> processstage_competitors
        {
            get { return GetRelatedEntities<Competitor>("processstage_competitors", null); }
            set
            {
                OnPropertyChanging("processstage_competitors");
                SetRelatedEntities("processstage_competitors", null, value);
                OnPropertyChanged("processstage_competitors");
            }
        }

        /// <summary>
        ///     1:N processstage_contact
        /// </summary>
        [RelationshipSchemaName("processstage_contact")]
        public IEnumerable<Contact> processstage_contact
        {
            get { return GetRelatedEntities<Contact>("processstage_contact", null); }
            set
            {
                OnPropertyChanging("processstage_contact");
                SetRelatedEntities("processstage_contact", null, value);
                OnPropertyChanged("processstage_contact");
            }
        }

        /// <summary>
        ///     1:N processstage_emails
        /// </summary>
        [RelationshipSchemaName("processstage_emails")]
        public IEnumerable<Email> processstage_emails
        {
            get { return GetRelatedEntities<Email>("processstage_emails", null); }
            set
            {
                OnPropertyChanging("processstage_emails");
                SetRelatedEntities("processstage_emails", null, value);
                OnPropertyChanged("processstage_emails");
            }
        }

        /// <summary>
        ///     1:N processstage_faxes
        /// </summary>
        [RelationshipSchemaName("processstage_faxes")]
        public IEnumerable<Fax> processstage_faxes
        {
            get { return GetRelatedEntities<Fax>("processstage_faxes", null); }
            set
            {
                OnPropertyChanging("processstage_faxes");
                SetRelatedEntities("processstage_faxes", null, value);
                OnPropertyChanged("processstage_faxes");
            }
        }

        /// <summary>
        ///     1:N processstage_incident
        /// </summary>
        [RelationshipSchemaName("processstage_incident")]
        public IEnumerable<Incident> processstage_incident
        {
            get { return GetRelatedEntities<Incident>("processstage_incident", null); }
            set
            {
                OnPropertyChanging("processstage_incident");
                SetRelatedEntities("processstage_incident", null, value);
                OnPropertyChanged("processstage_incident");
            }
        }

        /// <summary>
        ///     1:N processstage_invoices
        /// </summary>
        [RelationshipSchemaName("processstage_invoices")]
        public IEnumerable<Invoice> processstage_invoices
        {
            get { return GetRelatedEntities<Invoice>("processstage_invoices", null); }
            set
            {
                OnPropertyChanging("processstage_invoices");
                SetRelatedEntities("processstage_invoices", null, value);
                OnPropertyChanged("processstage_invoices");
            }
        }

        /// <summary>
        ///     1:N processstage_lead
        /// </summary>
        [RelationshipSchemaName("processstage_lead")]
        public IEnumerable<Lead> processstage_lead
        {
            get { return GetRelatedEntities<Lead>("processstage_lead", null); }
            set
            {
                OnPropertyChanging("processstage_lead");
                SetRelatedEntities("processstage_lead", null, value);
                OnPropertyChanged("processstage_lead");
            }
        }

        /// <summary>
        ///     1:N processstage_letters
        /// </summary>
        [RelationshipSchemaName("processstage_letters")]
        public IEnumerable<Letter> processstage_letters
        {
            get { return GetRelatedEntities<Letter>("processstage_letters", null); }
            set
            {
                OnPropertyChanging("processstage_letters");
                SetRelatedEntities("processstage_letters", null, value);
                OnPropertyChanged("processstage_letters");
            }
        }

        /// <summary>
        ///     1:N processstage_lists
        /// </summary>
        [RelationshipSchemaName("processstage_lists")]
        public IEnumerable<List> processstage_lists
        {
            get { return GetRelatedEntities<List>("processstage_lists", null); }
            set
            {
                OnPropertyChanging("processstage_lists");
                SetRelatedEntities("processstage_lists", null, value);
                OnPropertyChanged("processstage_lists");
            }
        }

        /// <summary>
        ///     1:N processstage_opportunity
        /// </summary>
        [RelationshipSchemaName("processstage_opportunity")]
        public IEnumerable<Opportunity> processstage_opportunity
        {
            get { return GetRelatedEntities<Opportunity>("processstage_opportunity", null); }
            set
            {
                OnPropertyChanging("processstage_opportunity");
                SetRelatedEntities("processstage_opportunity", null, value);
                OnPropertyChanged("processstage_opportunity");
            }
        }

        /// <summary>
        ///     1:N processstage_phonecalls
        /// </summary>
        [RelationshipSchemaName("processstage_phonecalls")]
        public IEnumerable<PhoneCall> processstage_phonecalls
        {
            get { return GetRelatedEntities<PhoneCall>("processstage_phonecalls", null); }
            set
            {
                OnPropertyChanging("processstage_phonecalls");
                SetRelatedEntities("processstage_phonecalls", null, value);
                OnPropertyChanged("processstage_phonecalls");
            }
        }

        /// <summary>
        ///     1:N processstage_productpricelevels
        /// </summary>
        [RelationshipSchemaName("processstage_productpricelevels")]
        public IEnumerable<ProductPriceLevel> processstage_productpricelevels
        {
            get { return GetRelatedEntities<ProductPriceLevel>("processstage_productpricelevels", null); }
            set
            {
                OnPropertyChanging("processstage_productpricelevels");
                SetRelatedEntities("processstage_productpricelevels", null, value);
                OnPropertyChanged("processstage_productpricelevels");
            }
        }

        /// <summary>
        ///     1:N processstage_products
        /// </summary>
        [RelationshipSchemaName("processstage_products")]
        public IEnumerable<Product> processstage_products
        {
            get { return GetRelatedEntities<Product>("processstage_products", null); }
            set
            {
                OnPropertyChanging("processstage_products");
                SetRelatedEntities("processstage_products", null, value);
                OnPropertyChanged("processstage_products");
            }
        }

        /// <summary>
        ///     1:N processstage_quotes
        /// </summary>
        [RelationshipSchemaName("processstage_quotes")]
        public IEnumerable<Quote> processstage_quotes
        {
            get { return GetRelatedEntities<Quote>("processstage_quotes", null); }
            set
            {
                OnPropertyChanging("processstage_quotes");
                SetRelatedEntities("processstage_quotes", null, value);
                OnPropertyChanged("processstage_quotes");
            }
        }

        /// <summary>
        ///     1:N processstage_recurringappointmentmasters
        /// </summary>
        [RelationshipSchemaName("processstage_recurringappointmentmasters")]
        public IEnumerable<RecurringAppointmentMaster> processstage_recurringappointmentmasters
        {
            get
            {
                return GetRelatedEntities<RecurringAppointmentMaster>("processstage_recurringappointmentmasters", null);
            }
            set
            {
                OnPropertyChanging("processstage_recurringappointmentmasters");
                SetRelatedEntities("processstage_recurringappointmentmasters", null, value);
                OnPropertyChanged("processstage_recurringappointmentmasters");
            }
        }

        /// <summary>
        ///     1:N processstage_salesliteratures
        /// </summary>
        [RelationshipSchemaName("processstage_salesliteratures")]
        public IEnumerable<SalesLiterature> processstage_salesliteratures
        {
            get { return GetRelatedEntities<SalesLiterature>("processstage_salesliteratures", null); }
            set
            {
                OnPropertyChanging("processstage_salesliteratures");
                SetRelatedEntities("processstage_salesliteratures", null, value);
                OnPropertyChanged("processstage_salesliteratures");
            }
        }

        /// <summary>
        ///     1:N processstage_salesorders
        /// </summary>
        [RelationshipSchemaName("processstage_salesorders")]
        public IEnumerable<SalesOrder> processstage_salesorders
        {
            get { return GetRelatedEntities<SalesOrder>("processstage_salesorders", null); }
            set
            {
                OnPropertyChanging("processstage_salesorders");
                SetRelatedEntities("processstage_salesorders", null, value);
                OnPropertyChanged("processstage_salesorders");
            }
        }

        /// <summary>
        ///     1:N processstage_systemusers
        /// </summary>
        [RelationshipSchemaName("processstage_systemusers")]
        public IEnumerable<SystemUser> processstage_systemusers
        {
            get { return GetRelatedEntities<SystemUser>("processstage_systemusers", null); }
            set
            {
                OnPropertyChanging("processstage_systemusers");
                SetRelatedEntities("processstage_systemusers", null, value);
                OnPropertyChanged("processstage_systemusers");
            }
        }

        /// <summary>
        ///     1:N processstage_tasks
        /// </summary>
        [RelationshipSchemaName("processstage_tasks")]
        public IEnumerable<Task> processstage_tasks
        {
            get { return GetRelatedEntities<Task>("processstage_tasks", null); }
            set
            {
                OnPropertyChanging("processstage_tasks");
                SetRelatedEntities("processstage_tasks", null, value);
                OnPropertyChanged("processstage_tasks");
            }
        }

        /// <summary>
        ///     1:N processstage_teams
        /// </summary>
        [RelationshipSchemaName("processstage_teams")]
        public IEnumerable<Team> processstage_teams
        {
            get { return GetRelatedEntities<Team>("processstage_teams", null); }
            set
            {
                OnPropertyChanging("processstage_teams");
                SetRelatedEntities("processstage_teams", null, value);
                OnPropertyChanged("processstage_teams");
            }
        }

        /// <summary>
        ///     N:1 process_processstage
        /// </summary>
        [AttributeLogicalName("processid")]
        [RelationshipSchemaName("process_processstage")]
        public Workflow process_processstage
        {
            get { return GetRelatedEntity<Workflow>("process_processstage", null); }
            set
            {
                OnPropertyChanging("process_processstage");
                SetRelatedEntity("process_processstage", null, value);
                OnPropertyChanged("process_processstage");
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