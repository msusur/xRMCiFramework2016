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
    ///     Potential duplicate record.
    /// </summary>
    [DataContract]
    [EntityLogicalName("duplicaterecord")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class DuplicateRecord : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "duplicaterecord";

        public const int EntityTypeCode = 4415;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public DuplicateRecord() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the system job that created this record.
        /// </summary>
        [AttributeLogicalName("asyncoperationid")]
        public EntityReference AsyncOperationId
        {
            get { return GetAttributeValue<EntityReference>("asyncoperationid"); }
        }

        /// <summary>
        ///     Unique identifier of the base record.
        /// </summary>
        [AttributeLogicalName("baserecordid")]
        public EntityReference BaseRecordId
        {
            get { return GetAttributeValue<EntityReference>("baserecordid"); }
        }

        /// <summary>
        ///     Date and time when the duplicate record was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the duplicate record.
        /// </summary>
        [AttributeLogicalName("duplicateid")]
        public Guid? DuplicateId
        {
            get { return GetAttributeValue<Guid?>("duplicateid"); }
            set
            {
                OnPropertyChanging("DuplicateId");
                SetAttributeValue("duplicateid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("DuplicateId");
            }
        }

        [AttributeLogicalName("duplicateid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { DuplicateId = value; }
        }

        /// <summary>
        ///     Unique identifier of the potential duplicate record.
        /// </summary>
        [AttributeLogicalName("duplicaterecordid")]
        public EntityReference DuplicateRecordId
        {
            get { return GetAttributeValue<EntityReference>("duplicaterecordid"); }
        }

        /// <summary>
        ///     Unique identifier of the duplicate rule against which this duplicate was found.
        /// </summary>
        [AttributeLogicalName("duplicateruleid")]
        public EntityReference DuplicateRuleId
        {
            get { return GetAttributeValue<EntityReference>("duplicateruleid"); }
        }

        /// <summary>
        ///     Unique identifier of the user or team who owns the duplicate record.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId
        {
            get { return GetAttributeValue<EntityReference>("ownerid"); }
        }

        /// <summary>
        ///     Unique identifier of the business unit that owns the duplicate record.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public Guid? OwningBusinessUnit
        {
            get { return GetAttributeValue<Guid?>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the duplicate record.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public Guid? OwningUser
        {
            get { return GetAttributeValue<Guid?>("owninguser"); }
        }

        /// <summary>
        ///     1:N userentityinstancedata_duplicaterecord
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_duplicaterecord")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_duplicaterecord
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_duplicaterecord", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_duplicaterecord");
                SetRelatedEntities("userentityinstancedata_duplicaterecord", null, value);
                OnPropertyChanged("userentityinstancedata_duplicaterecord");
            }
        }

        /// <summary>
        ///     N:1 Account_DuplicateBaseRecord
        /// </summary>
        [AttributeLogicalName("baserecordid")]
        [RelationshipSchemaName("Account_DuplicateBaseRecord")]
        public Account Account_DuplicateBaseRecord
        {
            get { return GetRelatedEntity<Account>("Account_DuplicateBaseRecord", null); }
        }

        /// <summary>
        ///     N:1 Account_DuplicateMatchingRecord
        /// </summary>
        [AttributeLogicalName("duplicaterecordid")]
        [RelationshipSchemaName("Account_DuplicateMatchingRecord")]
        public Account Account_DuplicateMatchingRecord
        {
            get { return GetRelatedEntity<Account>("Account_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        ///     N:1 Appointment_DuplicateBaseRecord
        /// </summary>
        [AttributeLogicalName("baserecordid")]
        [RelationshipSchemaName("Appointment_DuplicateBaseRecord")]
        public Appointment Appointment_DuplicateBaseRecord
        {
            get { return GetRelatedEntity<Appointment>("Appointment_DuplicateBaseRecord", null); }
        }

        /// <summary>
        ///     N:1 Appointment_DuplicateMatchingRecord
        /// </summary>
        [AttributeLogicalName("duplicaterecordid")]
        [RelationshipSchemaName("Appointment_DuplicateMatchingRecord")]
        public Appointment Appointment_DuplicateMatchingRecord
        {
            get { return GetRelatedEntity<Appointment>("Appointment_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        ///     N:1 AsyncOperation_DuplicateBaseRecord
        /// </summary>
        [AttributeLogicalName("asyncoperationid")]
        [RelationshipSchemaName("AsyncOperation_DuplicateBaseRecord")]
        public AsyncOperation AsyncOperation_DuplicateBaseRecord
        {
            get { return GetRelatedEntity<AsyncOperation>("AsyncOperation_DuplicateBaseRecord", null); }
        }

        /// <summary>
        ///     N:1 Campaign_DuplicateBaseRecord
        /// </summary>
        [AttributeLogicalName("baserecordid")]
        [RelationshipSchemaName("Campaign_DuplicateBaseRecord")]
        public Campaign Campaign_DuplicateBaseRecord
        {
            get { return GetRelatedEntity<Campaign>("Campaign_DuplicateBaseRecord", null); }
        }

        /// <summary>
        ///     N:1 Campaign_DuplicateMatchingRecord
        /// </summary>
        [AttributeLogicalName("duplicaterecordid")]
        [RelationshipSchemaName("Campaign_DuplicateMatchingRecord")]
        public Campaign Campaign_DuplicateMatchingRecord
        {
            get { return GetRelatedEntity<Campaign>("Campaign_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        ///     N:1 CampaignResponse_DuplicateBaseRecord
        /// </summary>
        [AttributeLogicalName("baserecordid")]
        [RelationshipSchemaName("CampaignResponse_DuplicateBaseRecord")]
        public CampaignResponse CampaignResponse_DuplicateBaseRecord
        {
            get { return GetRelatedEntity<CampaignResponse>("CampaignResponse_DuplicateBaseRecord", null); }
        }

        /// <summary>
        ///     N:1 CampaignResponse_DuplicateMatchingRecord
        /// </summary>
        [AttributeLogicalName("duplicaterecordid")]
        [RelationshipSchemaName("CampaignResponse_DuplicateMatchingRecord")]
        public CampaignResponse CampaignResponse_DuplicateMatchingRecord
        {
            get { return GetRelatedEntity<CampaignResponse>("CampaignResponse_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        ///     N:1 Competitor_DuplicateBaseRecord
        /// </summary>
        [AttributeLogicalName("baserecordid")]
        [RelationshipSchemaName("Competitor_DuplicateBaseRecord")]
        public Competitor Competitor_DuplicateBaseRecord
        {
            get { return GetRelatedEntity<Competitor>("Competitor_DuplicateBaseRecord", null); }
        }

        /// <summary>
        ///     N:1 Competitor_DuplicateMatchingRecord
        /// </summary>
        [AttributeLogicalName("duplicaterecordid")]
        [RelationshipSchemaName("Competitor_DuplicateMatchingRecord")]
        public Competitor Competitor_DuplicateMatchingRecord
        {
            get { return GetRelatedEntity<Competitor>("Competitor_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        ///     N:1 Contact_DuplicateBaseRecord
        /// </summary>
        [AttributeLogicalName("baserecordid")]
        [RelationshipSchemaName("Contact_DuplicateBaseRecord")]
        public Contact Contact_DuplicateBaseRecord
        {
            get { return GetRelatedEntity<Contact>("Contact_DuplicateBaseRecord", null); }
        }

        /// <summary>
        ///     N:1 Contact_DuplicateMatchingRecord
        /// </summary>
        [AttributeLogicalName("duplicaterecordid")]
        [RelationshipSchemaName("Contact_DuplicateMatchingRecord")]
        public Contact Contact_DuplicateMatchingRecord
        {
            get { return GetRelatedEntity<Contact>("Contact_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        ///     N:1 Contract_DuplicateBaseRecord
        /// </summary>
        [AttributeLogicalName("baserecordid")]
        [RelationshipSchemaName("Contract_DuplicateBaseRecord")]
        public Contract Contract_DuplicateBaseRecord
        {
            get { return GetRelatedEntity<Contract>("Contract_DuplicateBaseRecord", null); }
        }

        /// <summary>
        ///     N:1 Contract_DuplicateMatchingRecord
        /// </summary>
        [AttributeLogicalName("duplicaterecordid")]
        [RelationshipSchemaName("Contract_DuplicateMatchingRecord")]
        public Contract Contract_DuplicateMatchingRecord
        {
            get { return GetRelatedEntity<Contract>("Contract_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        ///     N:1 DuplicateRule_DuplicateBaseRecord
        /// </summary>
        [AttributeLogicalName("duplicateruleid")]
        [RelationshipSchemaName("DuplicateRule_DuplicateBaseRecord")]
        public DuplicateRule DuplicateRule_DuplicateBaseRecord
        {
            get { return GetRelatedEntity<DuplicateRule>("DuplicateRule_DuplicateBaseRecord", null); }
        }

        /// <summary>
        ///     N:1 Email_DuplicateBaseRecord
        /// </summary>
        [AttributeLogicalName("baserecordid")]
        [RelationshipSchemaName("Email_DuplicateBaseRecord")]
        public Email Email_DuplicateBaseRecord
        {
            get { return GetRelatedEntity<Email>("Email_DuplicateBaseRecord", null); }
        }

        /// <summary>
        ///     N:1 Email_DuplicateMatchingRecord
        /// </summary>
        [AttributeLogicalName("duplicaterecordid")]
        [RelationshipSchemaName("Email_DuplicateMatchingRecord")]
        public Email Email_DuplicateMatchingRecord
        {
            get { return GetRelatedEntity<Email>("Email_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        ///     N:1 emailserverprofile_duplicatebaserecord
        /// </summary>
        [AttributeLogicalName("baserecordid")]
        [RelationshipSchemaName("emailserverprofile_duplicatebaserecord")]
        public EmailServerProfile emailserverprofile_duplicatebaserecord
        {
            get { return GetRelatedEntity<EmailServerProfile>("emailserverprofile_duplicatebaserecord", null); }
        }

        /// <summary>
        ///     N:1 emailserverprofile_duplicatematchingrecord
        /// </summary>
        [AttributeLogicalName("duplicaterecordid")]
        [RelationshipSchemaName("emailserverprofile_duplicatematchingrecord")]
        public EmailServerProfile emailserverprofile_duplicatematchingrecord
        {
            get { return GetRelatedEntity<EmailServerProfile>("emailserverprofile_duplicatematchingrecord", null); }
        }

        /// <summary>
        ///     N:1 Equipment_DuplicateBaseRecord
        /// </summary>
        [AttributeLogicalName("baserecordid")]
        [RelationshipSchemaName("Equipment_DuplicateBaseRecord")]
        public Equipment Equipment_DuplicateBaseRecord
        {
            get { return GetRelatedEntity<Equipment>("Equipment_DuplicateBaseRecord", null); }
        }

        /// <summary>
        ///     N:1 Equipment_DuplicateMatchingRecord
        /// </summary>
        [AttributeLogicalName("duplicaterecordid")]
        [RelationshipSchemaName("Equipment_DuplicateMatchingRecord")]
        public Equipment Equipment_DuplicateMatchingRecord
        {
            get { return GetRelatedEntity<Equipment>("Equipment_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        ///     N:1 Fax_DuplicateBaseRecord
        /// </summary>
        [AttributeLogicalName("baserecordid")]
        [RelationshipSchemaName("Fax_DuplicateBaseRecord")]
        public Fax Fax_DuplicateBaseRecord
        {
            get { return GetRelatedEntity<Fax>("Fax_DuplicateBaseRecord", null); }
        }

        /// <summary>
        ///     N:1 Fax_DuplicateMatchingRecord
        /// </summary>
        [AttributeLogicalName("duplicaterecordid")]
        [RelationshipSchemaName("Fax_DuplicateMatchingRecord")]
        public Fax Fax_DuplicateMatchingRecord
        {
            get { return GetRelatedEntity<Fax>("Fax_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        ///     N:1 Incident_DuplicateBaseRecord
        /// </summary>
        [AttributeLogicalName("baserecordid")]
        [RelationshipSchemaName("Incident_DuplicateBaseRecord")]
        public Incident Incident_DuplicateBaseRecord
        {
            get { return GetRelatedEntity<Incident>("Incident_DuplicateBaseRecord", null); }
        }

        /// <summary>
        ///     N:1 Incident_DuplicateMatchingRecord
        /// </summary>
        [AttributeLogicalName("duplicaterecordid")]
        [RelationshipSchemaName("Incident_DuplicateMatchingRecord")]
        public Incident Incident_DuplicateMatchingRecord
        {
            get { return GetRelatedEntity<Incident>("Incident_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        ///     N:1 KbArticle_DuplicateBaseRecord
        /// </summary>
        [AttributeLogicalName("baserecordid")]
        [RelationshipSchemaName("KbArticle_DuplicateBaseRecord")]
        public KbArticle KbArticle_DuplicateBaseRecord
        {
            get { return GetRelatedEntity<KbArticle>("KbArticle_DuplicateBaseRecord", null); }
        }

        /// <summary>
        ///     N:1 KbArticle_DuplicateMatchingRecord
        /// </summary>
        [AttributeLogicalName("duplicaterecordid")]
        [RelationshipSchemaName("KbArticle_DuplicateMatchingRecord")]
        public KbArticle KbArticle_DuplicateMatchingRecord
        {
            get { return GetRelatedEntity<KbArticle>("KbArticle_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        ///     N:1 Lead_DuplicateBaseRecord
        /// </summary>
        [AttributeLogicalName("baserecordid")]
        [RelationshipSchemaName("Lead_DuplicateBaseRecord")]
        public Lead Lead_DuplicateBaseRecord
        {
            get { return GetRelatedEntity<Lead>("Lead_DuplicateBaseRecord", null); }
        }

        /// <summary>
        ///     N:1 Lead_DuplicateMatchingRecord
        /// </summary>
        [AttributeLogicalName("duplicaterecordid")]
        [RelationshipSchemaName("Lead_DuplicateMatchingRecord")]
        public Lead Lead_DuplicateMatchingRecord
        {
            get { return GetRelatedEntity<Lead>("Lead_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        ///     N:1 Letter_DuplicateBaseRecord
        /// </summary>
        [AttributeLogicalName("baserecordid")]
        [RelationshipSchemaName("Letter_DuplicateBaseRecord")]
        public Letter Letter_DuplicateBaseRecord
        {
            get { return GetRelatedEntity<Letter>("Letter_DuplicateBaseRecord", null); }
        }

        /// <summary>
        ///     N:1 Letter_DuplicateMatchingRecord
        /// </summary>
        [AttributeLogicalName("duplicaterecordid")]
        [RelationshipSchemaName("Letter_DuplicateMatchingRecord")]
        public Letter Letter_DuplicateMatchingRecord
        {
            get { return GetRelatedEntity<Letter>("Letter_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        ///     N:1 List_DuplicateBaseRecord
        /// </summary>
        [AttributeLogicalName("baserecordid")]
        [RelationshipSchemaName("List_DuplicateBaseRecord")]
        public List List_DuplicateBaseRecord
        {
            get { return GetRelatedEntity<List>("List_DuplicateBaseRecord", null); }
        }

        /// <summary>
        ///     N:1 List_DuplicateMatchingRecord
        /// </summary>
        [AttributeLogicalName("duplicaterecordid")]
        [RelationshipSchemaName("List_DuplicateMatchingRecord")]
        public List List_DuplicateMatchingRecord
        {
            get { return GetRelatedEntity<List>("List_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        ///     N:1 msdyn_postalbum_DuplicateBaseRecord
        /// </summary>
        [AttributeLogicalName("baserecordid")]
        [RelationshipSchemaName("msdyn_postalbum_DuplicateBaseRecord")]
        public msdyn_PostAlbum msdyn_postalbum_DuplicateBaseRecord
        {
            get { return GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_DuplicateBaseRecord", null); }
        }

        /// <summary>
        ///     N:1 msdyn_postalbum_DuplicateMatchingRecord
        /// </summary>
        [AttributeLogicalName("duplicaterecordid")]
        [RelationshipSchemaName("msdyn_postalbum_DuplicateMatchingRecord")]
        public msdyn_PostAlbum msdyn_postalbum_DuplicateMatchingRecord
        {
            get { return GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        ///     N:1 Opportunity_DuplicateBaseRecord
        /// </summary>
        [AttributeLogicalName("baserecordid")]
        [RelationshipSchemaName("Opportunity_DuplicateBaseRecord")]
        public Opportunity Opportunity_DuplicateBaseRecord
        {
            get { return GetRelatedEntity<Opportunity>("Opportunity_DuplicateBaseRecord", null); }
        }

        /// <summary>
        ///     N:1 Opportunity_DuplicateMatchingRecord
        /// </summary>
        [AttributeLogicalName("duplicaterecordid")]
        [RelationshipSchemaName("Opportunity_DuplicateMatchingRecord")]
        public Opportunity Opportunity_DuplicateMatchingRecord
        {
            get { return GetRelatedEntity<Opportunity>("Opportunity_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        ///     N:1 PhoneCall_DuplicateBaseRecord
        /// </summary>
        [AttributeLogicalName("baserecordid")]
        [RelationshipSchemaName("PhoneCall_DuplicateBaseRecord")]
        public PhoneCall PhoneCall_DuplicateBaseRecord
        {
            get { return GetRelatedEntity<PhoneCall>("PhoneCall_DuplicateBaseRecord", null); }
        }

        /// <summary>
        ///     N:1 PhoneCall_DuplicateMatchingRecord
        /// </summary>
        [AttributeLogicalName("duplicaterecordid")]
        [RelationshipSchemaName("PhoneCall_DuplicateMatchingRecord")]
        public PhoneCall PhoneCall_DuplicateMatchingRecord
        {
            get { return GetRelatedEntity<PhoneCall>("PhoneCall_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        ///     N:1 Queue_DuplicateBaseRecord
        /// </summary>
        [AttributeLogicalName("baserecordid")]
        [RelationshipSchemaName("Queue_DuplicateBaseRecord")]
        public Queue Queue_DuplicateBaseRecord
        {
            get { return GetRelatedEntity<Queue>("Queue_DuplicateBaseRecord", null); }
        }

        /// <summary>
        ///     N:1 Queue_DuplicateMatchingRecord
        /// </summary>
        [AttributeLogicalName("duplicaterecordid")]
        [RelationshipSchemaName("Queue_DuplicateMatchingRecord")]
        public Queue Queue_DuplicateMatchingRecord
        {
            get { return GetRelatedEntity<Queue>("Queue_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        ///     N:1 Quote_DuplicateBaseRecord
        /// </summary>
        [AttributeLogicalName("baserecordid")]
        [RelationshipSchemaName("Quote_DuplicateBaseRecord")]
        public Quote Quote_DuplicateBaseRecord
        {
            get { return GetRelatedEntity<Quote>("Quote_DuplicateBaseRecord", null); }
        }

        /// <summary>
        ///     N:1 Quote_DuplicateMatchingRecord
        /// </summary>
        [AttributeLogicalName("duplicaterecordid")]
        [RelationshipSchemaName("Quote_DuplicateMatchingRecord")]
        public Quote Quote_DuplicateMatchingRecord
        {
            get { return GetRelatedEntity<Quote>("Quote_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        ///     N:1 RecurringAppointmentMaster_DuplicateBaseRecord
        /// </summary>
        [AttributeLogicalName("baserecordid")]
        [RelationshipSchemaName("RecurringAppointmentMaster_DuplicateBaseRecord")]
        public RecurringAppointmentMaster RecurringAppointmentMaster_DuplicateBaseRecord
        {
            get
            {
                return GetRelatedEntity<RecurringAppointmentMaster>("RecurringAppointmentMaster_DuplicateBaseRecord",
                    null);
            }
        }

        /// <summary>
        ///     N:1 RecurringAppointmentMaster_DuplicateMatchingRecord
        /// </summary>
        [AttributeLogicalName("duplicaterecordid")]
        [RelationshipSchemaName("RecurringAppointmentMaster_DuplicateMatchingRecord")]
        public RecurringAppointmentMaster RecurringAppointmentMaster_DuplicateMatchingRecord
        {
            get
            {
                return GetRelatedEntity<RecurringAppointmentMaster>(
                    "RecurringAppointmentMaster_DuplicateMatchingRecord", null);
            }
        }

        /// <summary>
        ///     N:1 ResourceGroup_DuplicateBaseRecord
        /// </summary>
        [AttributeLogicalName("baserecordid")]
        [RelationshipSchemaName("ResourceGroup_DuplicateBaseRecord")]
        public ResourceGroup ResourceGroup_DuplicateBaseRecord
        {
            get { return GetRelatedEntity<ResourceGroup>("ResourceGroup_DuplicateBaseRecord", null); }
        }

        /// <summary>
        ///     N:1 ResourceGroup_DuplicateMatchingRecord
        /// </summary>
        [AttributeLogicalName("duplicaterecordid")]
        [RelationshipSchemaName("ResourceGroup_DuplicateMatchingRecord")]
        public ResourceGroup ResourceGroup_DuplicateMatchingRecord
        {
            get { return GetRelatedEntity<ResourceGroup>("ResourceGroup_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        ///     N:1 Service_DuplicateBaseRecord
        /// </summary>
        [AttributeLogicalName("baserecordid")]
        [RelationshipSchemaName("Service_DuplicateBaseRecord")]
        public Service Service_DuplicateBaseRecord
        {
            get { return GetRelatedEntity<Service>("Service_DuplicateBaseRecord", null); }
        }

        /// <summary>
        ///     N:1 Service_DuplicateMatchingRecord
        /// </summary>
        [AttributeLogicalName("duplicaterecordid")]
        [RelationshipSchemaName("Service_DuplicateMatchingRecord")]
        public Service Service_DuplicateMatchingRecord
        {
            get { return GetRelatedEntity<Service>("Service_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        ///     N:1 SharePointDocumentLocation_DuplicateBaseRecord
        /// </summary>
        [AttributeLogicalName("baserecordid")]
        [RelationshipSchemaName("SharePointDocumentLocation_DuplicateBaseRecord")]
        public SharePointDocumentLocation SharePointDocumentLocation_DuplicateBaseRecord
        {
            get
            {
                return GetRelatedEntity<SharePointDocumentLocation>("SharePointDocumentLocation_DuplicateBaseRecord",
                    null);
            }
        }

        /// <summary>
        ///     N:1 SharePointDocumentLocation_DuplicateMatchingRecord
        /// </summary>
        [AttributeLogicalName("duplicaterecordid")]
        [RelationshipSchemaName("SharePointDocumentLocation_DuplicateMatchingRecord")]
        public SharePointDocumentLocation SharePointDocumentLocation_DuplicateMatchingRecord
        {
            get
            {
                return GetRelatedEntity<SharePointDocumentLocation>(
                    "SharePointDocumentLocation_DuplicateMatchingRecord", null);
            }
        }

        /// <summary>
        ///     N:1 SharePointSite_DuplicateBaseRecord
        /// </summary>
        [AttributeLogicalName("baserecordid")]
        [RelationshipSchemaName("SharePointSite_DuplicateBaseRecord")]
        public SharePointSite SharePointSite_DuplicateBaseRecord
        {
            get { return GetRelatedEntity<SharePointSite>("SharePointSite_DuplicateBaseRecord", null); }
        }

        /// <summary>
        ///     N:1 SharePointSite_DuplicateMatchingRecord
        /// </summary>
        [AttributeLogicalName("duplicaterecordid")]
        [RelationshipSchemaName("SharePointSite_DuplicateMatchingRecord")]
        public SharePointSite SharePointSite_DuplicateMatchingRecord
        {
            get { return GetRelatedEntity<SharePointSite>("SharePointSite_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        ///     N:1 SystemUser_DuplicateBaseRecord
        /// </summary>
        [AttributeLogicalName("baserecordid")]
        [RelationshipSchemaName("SystemUser_DuplicateBaseRecord")]
        public SystemUser SystemUser_DuplicateBaseRecord
        {
            get { return GetRelatedEntity<SystemUser>("SystemUser_DuplicateBaseRecord", null); }
        }

        /// <summary>
        ///     N:1 SystemUser_DuplicateMatchingRecord
        /// </summary>
        [AttributeLogicalName("duplicaterecordid")]
        [RelationshipSchemaName("SystemUser_DuplicateMatchingRecord")]
        public SystemUser SystemUser_DuplicateMatchingRecord
        {
            get { return GetRelatedEntity<SystemUser>("SystemUser_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        ///     N:1 Task_DuplicateBaseRecord
        /// </summary>
        [AttributeLogicalName("baserecordid")]
        [RelationshipSchemaName("Task_DuplicateBaseRecord")]
        public Task Task_DuplicateBaseRecord
        {
            get { return GetRelatedEntity<Task>("Task_DuplicateBaseRecord", null); }
        }

        /// <summary>
        ///     N:1 Task_DuplicateMatchingRecord
        /// </summary>
        [AttributeLogicalName("duplicaterecordid")]
        [RelationshipSchemaName("Task_DuplicateMatchingRecord")]
        public Task Task_DuplicateMatchingRecord
        {
            get { return GetRelatedEntity<Task>("Task_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        ///     N:1 Team_DuplicateBaseRecord
        /// </summary>
        [AttributeLogicalName("baserecordid")]
        [RelationshipSchemaName("Team_DuplicateBaseRecord")]
        public Team Team_DuplicateBaseRecord
        {
            get { return GetRelatedEntity<Team>("Team_DuplicateBaseRecord", null); }
        }

        /// <summary>
        ///     N:1 Team_DuplicateMatchingRecord
        /// </summary>
        [AttributeLogicalName("duplicaterecordid")]
        [RelationshipSchemaName("Team_DuplicateMatchingRecord")]
        public Team Team_DuplicateMatchingRecord
        {
            get { return GetRelatedEntity<Team>("Team_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        ///     N:1 Territory_DuplicateBaseRecord
        /// </summary>
        [AttributeLogicalName("baserecordid")]
        [RelationshipSchemaName("Territory_DuplicateBaseRecord")]
        public Territory Territory_DuplicateBaseRecord
        {
            get { return GetRelatedEntity<Territory>("Territory_DuplicateBaseRecord", null); }
        }

        /// <summary>
        ///     N:1 Territory_DuplicateMatchingRecord
        /// </summary>
        [AttributeLogicalName("duplicaterecordid")]
        [RelationshipSchemaName("Territory_DuplicateMatchingRecord")]
        public Territory Territory_DuplicateMatchingRecord
        {
            get { return GetRelatedEntity<Territory>("Territory_DuplicateMatchingRecord", null); }
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