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
    ///     Note that is attached to one or more objects, including other notes.
    /// </summary>
    [DataContract]
    [EntityLogicalName("annotation")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Annotation : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "annotation";

        public const int EntityTypeCode = 5;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Annotation() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the note.
        /// </summary>
        [AttributeLogicalName("annotationid")]
        public Guid? AnnotationId
        {
            get { return GetAttributeValue<Guid?>("annotationid"); }
            set
            {
                OnPropertyChanging("AnnotationId");
                SetAttributeValue("annotationid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("AnnotationId");
            }
        }

        [AttributeLogicalName("annotationid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { AnnotationId = value; }
        }

        /// <summary>
        ///     Unique identifier of the user who created the note.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the note was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the annotation.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Contents of the note's attachment.
        /// </summary>
        [AttributeLogicalName("documentbody")]
        public string DocumentBody
        {
            get { return GetAttributeValue<string>("documentbody"); }
            set
            {
                OnPropertyChanging("DocumentBody");
                SetAttributeValue("documentbody", value);
                OnPropertyChanged("DocumentBody");
            }
        }

        /// <summary>
        ///     File name of the note.
        /// </summary>
        [AttributeLogicalName("filename")]
        public string FileName
        {
            get { return GetAttributeValue<string>("filename"); }
            set
            {
                OnPropertyChanging("FileName");
                SetAttributeValue("filename", value);
                OnPropertyChanged("FileName");
            }
        }

        /// <summary>
        ///     File size of the note.
        /// </summary>
        [AttributeLogicalName("filesize")]
        public int? FileSize
        {
            get { return GetAttributeValue<int?>("filesize"); }
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
        ///     Specifies whether the note is an attachment.
        /// </summary>
        [AttributeLogicalName("isdocument")]
        public bool? IsDocument
        {
            get { return GetAttributeValue<bool?>("isdocument"); }
            set
            {
                OnPropertyChanging("IsDocument");
                SetAttributeValue("isdocument", value);
                OnPropertyChanged("IsDocument");
            }
        }

        /// <summary>
        ///     Language identifier for the note.
        /// </summary>
        [AttributeLogicalName("langid")]
        public string LangId
        {
            get { return GetAttributeValue<string>("langid"); }
            set
            {
                OnPropertyChanging("LangId");
                SetAttributeValue("langid", value);
                OnPropertyChanged("LangId");
            }
        }

        /// <summary>
        ///     MIME type of the note's attachment.
        /// </summary>
        [AttributeLogicalName("mimetype")]
        public string MimeType
        {
            get { return GetAttributeValue<string>("mimetype"); }
            set
            {
                OnPropertyChanging("MimeType");
                SetAttributeValue("mimetype", value);
                OnPropertyChanged("MimeType");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the note.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the note was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the annotation.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Text of the note.
        /// </summary>
        [AttributeLogicalName("notetext")]
        public string NoteText
        {
            get { return GetAttributeValue<string>("notetext"); }
            set
            {
                OnPropertyChanging("NoteText");
                SetAttributeValue("notetext", value);
                OnPropertyChanged("NoteText");
            }
        }

        /// <summary>
        ///     Unique identifier of the object with which the note is associated.
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
        ///     Type of entity with which the note is associated.
        /// </summary>
        [AttributeLogicalName("objecttypecode")]
        public string ObjectTypeCode
        {
            get { return GetAttributeValue<string>("objecttypecode"); }
            set
            {
                OnPropertyChanging("ObjectTypeCode");
                SetAttributeValue("objecttypecode", value);
                OnPropertyChanged("ObjectTypeCode");
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
        ///     Unique identifier of the user or team who owns the note.
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
        ///     Unique identifier of the business unit that owns the note.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the note.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the note.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     workflow step id associated with the note.
        /// </summary>
        [AttributeLogicalName("stepid")]
        public string StepId
        {
            get { return GetAttributeValue<string>("stepid"); }
            set
            {
                OnPropertyChanging("StepId");
                SetAttributeValue("stepid", value);
                OnPropertyChanged("StepId");
            }
        }

        /// <summary>
        ///     Subject associated with the note.
        /// </summary>
        [AttributeLogicalName("subject")]
        public string Subject
        {
            get { return GetAttributeValue<string>("subject"); }
            set
            {
                OnPropertyChanging("Subject");
                SetAttributeValue("subject", value);
                OnPropertyChanged("Subject");
            }
        }

        /// <summary>
        ///     Version number of the note.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N Annotation_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Annotation_AsyncOperations")]
        public IEnumerable<AsyncOperation> Annotation_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Annotation_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Annotation_AsyncOperations");
                SetRelatedEntities("Annotation_AsyncOperations", null, value);
                OnPropertyChanged("Annotation_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N Annotation_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("Annotation_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> Annotation_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("Annotation_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("Annotation_BulkDeleteFailures");
                SetRelatedEntities("Annotation_BulkDeleteFailures", null, value);
                OnPropertyChanged("Annotation_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N Annotation_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("Annotation_ProcessSessions")]
        public IEnumerable<ProcessSession> Annotation_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("Annotation_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Annotation_ProcessSessions");
                SetRelatedEntities("Annotation_ProcessSessions", null, value);
                OnPropertyChanged("Annotation_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_annotation
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_annotation")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_annotation
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_annotation", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_annotation");
                SetRelatedEntities("userentityinstancedata_annotation", null, value);
                OnPropertyChanged("userentityinstancedata_annotation");
            }
        }

        /// <summary>
        ///     N:1 Account_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("Account_Annotation")]
        public Account Account_Annotation
        {
            get { return GetRelatedEntity<Account>("Account_Annotation", null); }
            set
            {
                OnPropertyChanging("Account_Annotation");
                SetRelatedEntity("Account_Annotation", null, value);
                OnPropertyChanged("Account_Annotation");
            }
        }

        /// <summary>
        ///     N:1 annotation_owning_user
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("annotation_owning_user")]
        public SystemUser annotation_owning_user
        {
            get { return GetRelatedEntity<SystemUser>("annotation_owning_user", null); }
        }

        /// <summary>
        ///     N:1 Appointment_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("Appointment_Annotation")]
        public Appointment Appointment_Annotation
        {
            get { return GetRelatedEntity<Appointment>("Appointment_Annotation", null); }
            set
            {
                OnPropertyChanging("Appointment_Annotation");
                SetRelatedEntity("Appointment_Annotation", null, value);
                OnPropertyChanged("Appointment_Annotation");
            }
        }

        /// <summary>
        ///     N:1 business_unit_annotations
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_annotations")]
        public BusinessUnit business_unit_annotations
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_annotations", null); }
        }

        /// <summary>
        ///     N:1 Calendar_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("Calendar_Annotation")]
        public Calendar Calendar_Annotation
        {
            get { return GetRelatedEntity<Calendar>("Calendar_Annotation", null); }
            set
            {
                OnPropertyChanging("Calendar_Annotation");
                SetRelatedEntity("Calendar_Annotation", null, value);
                OnPropertyChanged("Calendar_Annotation");
            }
        }

        /// <summary>
        ///     N:1 Campaign_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("Campaign_Annotation")]
        public Campaign Campaign_Annotation
        {
            get { return GetRelatedEntity<Campaign>("Campaign_Annotation", null); }
            set
            {
                OnPropertyChanging("Campaign_Annotation");
                SetRelatedEntity("Campaign_Annotation", null, value);
                OnPropertyChanged("Campaign_Annotation");
            }
        }

        /// <summary>
        ///     N:1 CampaignActivity_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("CampaignActivity_Annotation")]
        public CampaignActivity CampaignActivity_Annotation
        {
            get { return GetRelatedEntity<CampaignActivity>("CampaignActivity_Annotation", null); }
            set
            {
                OnPropertyChanging("CampaignActivity_Annotation");
                SetRelatedEntity("CampaignActivity_Annotation", null, value);
                OnPropertyChanged("CampaignActivity_Annotation");
            }
        }

        /// <summary>
        ///     N:1 CampaignResponse_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("CampaignResponse_Annotation")]
        public CampaignResponse CampaignResponse_Annotation
        {
            get { return GetRelatedEntity<CampaignResponse>("CampaignResponse_Annotation", null); }
            set
            {
                OnPropertyChanging("CampaignResponse_Annotation");
                SetRelatedEntity("CampaignResponse_Annotation", null, value);
                OnPropertyChanged("CampaignResponse_Annotation");
            }
        }

        /// <summary>
        ///     N:1 Competitor_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("Competitor_Annotation")]
        public Competitor Competitor_Annotation
        {
            get { return GetRelatedEntity<Competitor>("Competitor_Annotation", null); }
            set
            {
                OnPropertyChanging("Competitor_Annotation");
                SetRelatedEntity("Competitor_Annotation", null, value);
                OnPropertyChanged("Competitor_Annotation");
            }
        }

        /// <summary>
        ///     N:1 Contact_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("Contact_Annotation")]
        public Contact Contact_Annotation
        {
            get { return GetRelatedEntity<Contact>("Contact_Annotation", null); }
            set
            {
                OnPropertyChanging("Contact_Annotation");
                SetRelatedEntity("Contact_Annotation", null, value);
                OnPropertyChanged("Contact_Annotation");
            }
        }

        /// <summary>
        ///     N:1 Contract_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("Contract_Annotation")]
        public Contract Contract_Annotation
        {
            get { return GetRelatedEntity<Contract>("Contract_Annotation", null); }
            set
            {
                OnPropertyChanging("Contract_Annotation");
                SetRelatedEntity("Contract_Annotation", null, value);
                OnPropertyChanged("Contract_Annotation");
            }
        }

        /// <summary>
        ///     N:1 ContractDetail_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("ContractDetail_Annotation")]
        public ContractDetail ContractDetail_Annotation
        {
            get { return GetRelatedEntity<ContractDetail>("ContractDetail_Annotation", null); }
            set
            {
                OnPropertyChanging("ContractDetail_Annotation");
                SetRelatedEntity("ContractDetail_Annotation", null, value);
                OnPropertyChanged("ContractDetail_Annotation");
            }
        }

        /// <summary>
        ///     N:1 DuplicateRule_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("DuplicateRule_Annotation")]
        public DuplicateRule DuplicateRule_Annotation
        {
            get { return GetRelatedEntity<DuplicateRule>("DuplicateRule_Annotation", null); }
            set
            {
                OnPropertyChanging("DuplicateRule_Annotation");
                SetRelatedEntity("DuplicateRule_Annotation", null, value);
                OnPropertyChanged("DuplicateRule_Annotation");
            }
        }

        /// <summary>
        ///     N:1 Email_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("Email_Annotation")]
        public Email Email_Annotation
        {
            get { return GetRelatedEntity<Email>("Email_Annotation", null); }
            set
            {
                OnPropertyChanging("Email_Annotation");
                SetRelatedEntity("Email_Annotation", null, value);
                OnPropertyChanged("Email_Annotation");
            }
        }

        /// <summary>
        ///     N:1 EmailServerProfile_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("EmailServerProfile_Annotation")]
        public EmailServerProfile EmailServerProfile_Annotation
        {
            get { return GetRelatedEntity<EmailServerProfile>("EmailServerProfile_Annotation", null); }
            set
            {
                OnPropertyChanging("EmailServerProfile_Annotation");
                SetRelatedEntity("EmailServerProfile_Annotation", null, value);
                OnPropertyChanged("EmailServerProfile_Annotation");
            }
        }

        /// <summary>
        ///     N:1 Equipment_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("Equipment_Annotation")]
        public Equipment Equipment_Annotation
        {
            get { return GetRelatedEntity<Equipment>("Equipment_Annotation", null); }
            set
            {
                OnPropertyChanging("Equipment_Annotation");
                SetRelatedEntity("Equipment_Annotation", null, value);
                OnPropertyChanged("Equipment_Annotation");
            }
        }

        /// <summary>
        ///     N:1 Fax_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("Fax_Annotation")]
        public Fax Fax_Annotation
        {
            get { return GetRelatedEntity<Fax>("Fax_Annotation", null); }
            set
            {
                OnPropertyChanging("Fax_Annotation");
                SetRelatedEntity("Fax_Annotation", null, value);
                OnPropertyChanged("Fax_Annotation");
            }
        }

        /// <summary>
        ///     N:1 Goal_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("Goal_Annotation")]
        public Goal Goal_Annotation
        {
            get { return GetRelatedEntity<Goal>("Goal_Annotation", null); }
            set
            {
                OnPropertyChanging("Goal_Annotation");
                SetRelatedEntity("Goal_Annotation", null, value);
                OnPropertyChanged("Goal_Annotation");
            }
        }

        /// <summary>
        ///     N:1 Incident_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("Incident_Annotation")]
        public Incident Incident_Annotation
        {
            get { return GetRelatedEntity<Incident>("Incident_Annotation", null); }
            set
            {
                OnPropertyChanging("Incident_Annotation");
                SetRelatedEntity("Incident_Annotation", null, value);
                OnPropertyChanged("Incident_Annotation");
            }
        }

        /// <summary>
        ///     N:1 IncidentResolution_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("IncidentResolution_Annotation")]
        public IncidentResolution IncidentResolution_Annotation
        {
            get { return GetRelatedEntity<IncidentResolution>("IncidentResolution_Annotation", null); }
            set
            {
                OnPropertyChanging("IncidentResolution_Annotation");
                SetRelatedEntity("IncidentResolution_Annotation", null, value);
                OnPropertyChanged("IncidentResolution_Annotation");
            }
        }

        /// <summary>
        ///     N:1 Invoice_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("Invoice_Annotation")]
        public Invoice Invoice_Annotation
        {
            get { return GetRelatedEntity<Invoice>("Invoice_Annotation", null); }
            set
            {
                OnPropertyChanging("Invoice_Annotation");
                SetRelatedEntity("Invoice_Annotation", null, value);
                OnPropertyChanged("Invoice_Annotation");
            }
        }

        /// <summary>
        ///     N:1 KbArticle_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("KbArticle_Annotation")]
        public KbArticle KbArticle_Annotation
        {
            get { return GetRelatedEntity<KbArticle>("KbArticle_Annotation", null); }
            set
            {
                OnPropertyChanging("KbArticle_Annotation");
                SetRelatedEntity("KbArticle_Annotation", null, value);
                OnPropertyChanged("KbArticle_Annotation");
            }
        }

        /// <summary>
        ///     N:1 Lead_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("Lead_Annotation")]
        public Lead Lead_Annotation
        {
            get { return GetRelatedEntity<Lead>("Lead_Annotation", null); }
            set
            {
                OnPropertyChanging("Lead_Annotation");
                SetRelatedEntity("Lead_Annotation", null, value);
                OnPropertyChanged("Lead_Annotation");
            }
        }

        /// <summary>
        ///     N:1 Letter_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("Letter_Annotation")]
        public Letter Letter_Annotation
        {
            get { return GetRelatedEntity<Letter>("Letter_Annotation", null); }
            set
            {
                OnPropertyChanging("Letter_Annotation");
                SetRelatedEntity("Letter_Annotation", null, value);
                OnPropertyChanged("Letter_Annotation");
            }
        }

        /// <summary>
        ///     N:1 List_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("List_Annotation")]
        public List List_Annotation
        {
            get { return GetRelatedEntity<List>("List_Annotation", null); }
            set
            {
                OnPropertyChanging("List_Annotation");
                SetRelatedEntity("List_Annotation", null, value);
                OnPropertyChanged("List_Annotation");
            }
        }

        /// <summary>
        ///     N:1 lk_annotationbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_annotationbase_createdby")]
        public SystemUser lk_annotationbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_annotationbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_annotationbase_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_annotationbase_createdonbehalfby")]
        public SystemUser lk_annotationbase_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_annotationbase_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_annotationbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_annotationbase_modifiedby")]
        public SystemUser lk_annotationbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_annotationbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_annotationbase_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_annotationbase_modifiedonbehalfby")]
        public SystemUser lk_annotationbase_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_annotationbase_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 Mailbox_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("Mailbox_Annotation")]
        public Mailbox Mailbox_Annotation
        {
            get { return GetRelatedEntity<Mailbox>("Mailbox_Annotation", null); }
            set
            {
                OnPropertyChanging("Mailbox_Annotation");
                SetRelatedEntity("Mailbox_Annotation", null, value);
                OnPropertyChanged("Mailbox_Annotation");
            }
        }

        /// <summary>
        ///     N:1 msdyn_postalbum_Annotations
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("msdyn_postalbum_Annotations")]
        public msdyn_PostAlbum msdyn_postalbum_Annotations
        {
            get { return GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_Annotations", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_Annotations");
                SetRelatedEntity("msdyn_postalbum_Annotations", null, value);
                OnPropertyChanged("msdyn_postalbum_Annotations");
            }
        }

        /// <summary>
        ///     N:1 Opportunity_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("Opportunity_Annotation")]
        public Opportunity Opportunity_Annotation
        {
            get { return GetRelatedEntity<Opportunity>("Opportunity_Annotation", null); }
            set
            {
                OnPropertyChanging("Opportunity_Annotation");
                SetRelatedEntity("Opportunity_Annotation", null, value);
                OnPropertyChanged("Opportunity_Annotation");
            }
        }

        /// <summary>
        ///     N:1 OpportunityClose_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("OpportunityClose_Annotation")]
        public OpportunityClose OpportunityClose_Annotation
        {
            get { return GetRelatedEntity<OpportunityClose>("OpportunityClose_Annotation", null); }
            set
            {
                OnPropertyChanging("OpportunityClose_Annotation");
                SetRelatedEntity("OpportunityClose_Annotation", null, value);
                OnPropertyChanged("OpportunityClose_Annotation");
            }
        }

        /// <summary>
        ///     N:1 OrderClose_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("OrderClose_Annotation")]
        public OrderClose OrderClose_Annotation
        {
            get { return GetRelatedEntity<OrderClose>("OrderClose_Annotation", null); }
            set
            {
                OnPropertyChanging("OrderClose_Annotation");
                SetRelatedEntity("OrderClose_Annotation", null, value);
                OnPropertyChanged("OrderClose_Annotation");
            }
        }

        /// <summary>
        ///     N:1 PhoneCall_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("PhoneCall_Annotation")]
        public PhoneCall PhoneCall_Annotation
        {
            get { return GetRelatedEntity<PhoneCall>("PhoneCall_Annotation", null); }
            set
            {
                OnPropertyChanging("PhoneCall_Annotation");
                SetRelatedEntity("PhoneCall_Annotation", null, value);
                OnPropertyChanged("PhoneCall_Annotation");
            }
        }

        /// <summary>
        ///     N:1 Product_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("Product_Annotation")]
        public Product Product_Annotation
        {
            get { return GetRelatedEntity<Product>("Product_Annotation", null); }
            set
            {
                OnPropertyChanging("Product_Annotation");
                SetRelatedEntity("Product_Annotation", null, value);
                OnPropertyChanged("Product_Annotation");
            }
        }

        /// <summary>
        ///     N:1 Quote_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("Quote_Annotation")]
        public Quote Quote_Annotation
        {
            get { return GetRelatedEntity<Quote>("Quote_Annotation", null); }
            set
            {
                OnPropertyChanging("Quote_Annotation");
                SetRelatedEntity("Quote_Annotation", null, value);
                OnPropertyChanged("Quote_Annotation");
            }
        }

        /// <summary>
        ///     N:1 QuoteClose_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("QuoteClose_Annotation")]
        public QuoteClose QuoteClose_Annotation
        {
            get { return GetRelatedEntity<QuoteClose>("QuoteClose_Annotation", null); }
            set
            {
                OnPropertyChanging("QuoteClose_Annotation");
                SetRelatedEntity("QuoteClose_Annotation", null, value);
                OnPropertyChanged("QuoteClose_Annotation");
            }
        }

        /// <summary>
        ///     N:1 RecurringAppointmentMaster_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("RecurringAppointmentMaster_Annotation")]
        public RecurringAppointmentMaster RecurringAppointmentMaster_Annotation
        {
            get { return GetRelatedEntity<RecurringAppointmentMaster>("RecurringAppointmentMaster_Annotation", null); }
            set
            {
                OnPropertyChanging("RecurringAppointmentMaster_Annotation");
                SetRelatedEntity("RecurringAppointmentMaster_Annotation", null, value);
                OnPropertyChanged("RecurringAppointmentMaster_Annotation");
            }
        }

        /// <summary>
        ///     N:1 ResourceSpec_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("ResourceSpec_Annotation")]
        public ResourceSpec ResourceSpec_Annotation
        {
            get { return GetRelatedEntity<ResourceSpec>("ResourceSpec_Annotation", null); }
            set
            {
                OnPropertyChanging("ResourceSpec_Annotation");
                SetRelatedEntity("ResourceSpec_Annotation", null, value);
                OnPropertyChanged("ResourceSpec_Annotation");
            }
        }

        /// <summary>
        ///     N:1 SalesOrder_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("SalesOrder_Annotation")]
        public SalesOrder SalesOrder_Annotation
        {
            get { return GetRelatedEntity<SalesOrder>("SalesOrder_Annotation", null); }
            set
            {
                OnPropertyChanging("SalesOrder_Annotation");
                SetRelatedEntity("SalesOrder_Annotation", null, value);
                OnPropertyChanged("SalesOrder_Annotation");
            }
        }

        /// <summary>
        ///     N:1 Service_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("Service_Annotation")]
        public Service Service_Annotation
        {
            get { return GetRelatedEntity<Service>("Service_Annotation", null); }
            set
            {
                OnPropertyChanging("Service_Annotation");
                SetRelatedEntity("Service_Annotation", null, value);
                OnPropertyChanged("Service_Annotation");
            }
        }

        /// <summary>
        ///     N:1 ServiceAppointment_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("ServiceAppointment_Annotation")]
        public ServiceAppointment ServiceAppointment_Annotation
        {
            get { return GetRelatedEntity<ServiceAppointment>("ServiceAppointment_Annotation", null); }
            set
            {
                OnPropertyChanging("ServiceAppointment_Annotation");
                SetRelatedEntity("ServiceAppointment_Annotation", null, value);
                OnPropertyChanged("ServiceAppointment_Annotation");
            }
        }

        /// <summary>
        ///     N:1 Task_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("Task_Annotation")]
        public Task Task_Annotation
        {
            get { return GetRelatedEntity<Task>("Task_Annotation", null); }
            set
            {
                OnPropertyChanging("Task_Annotation");
                SetRelatedEntity("Task_Annotation", null, value);
                OnPropertyChanged("Task_Annotation");
            }
        }

        /// <summary>
        ///     N:1 team_annotations
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_annotations")]
        public Team team_annotations
        {
            get { return GetRelatedEntity<Team>("team_annotations", null); }
        }

        /// <summary>
        ///     N:1 Workflow_Annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("Workflow_Annotation")]
        public Workflow Workflow_Annotation
        {
            get { return GetRelatedEntity<Workflow>("Workflow_Annotation", null); }
            set
            {
                OnPropertyChanging("Workflow_Annotation");
                SetRelatedEntity("Workflow_Annotation", null, value);
                OnPropertyChanged("Workflow_Annotation");
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