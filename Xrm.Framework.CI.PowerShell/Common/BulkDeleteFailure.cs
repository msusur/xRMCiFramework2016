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
    ///     Record that was not deleted during a bulk deletion job.
    /// </summary>
    [DataContract]
    [EntityLogicalName("bulkdeletefailure")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class BulkDeleteFailure : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "bulkdeletefailure";

        public const int EntityTypeCode = 4425;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public BulkDeleteFailure() :
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
        ///     Unique identifier of the bulk deletion failure record.
        /// </summary>
        [AttributeLogicalName("bulkdeletefailureid")]
        public Guid? BulkDeleteFailureId
        {
            get { return GetAttributeValue<Guid?>("bulkdeletefailureid"); }
        }

        [AttributeLogicalName("bulkdeletefailureid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { base.Id = value; }
        }

        /// <summary>
        ///     Unique identifier of the bulk operation job which created this record
        /// </summary>
        [AttributeLogicalName("bulkdeleteoperationid")]
        public EntityReference BulkDeleteOperationId
        {
            get { return GetAttributeValue<EntityReference>("bulkdeleteoperationid"); }
        }

        /// <summary>
        ///     Description of the error.
        /// </summary>
        [AttributeLogicalName("errordescription")]
        public string ErrorDescription
        {
            get { return GetAttributeValue<string>("errordescription"); }
        }

        /// <summary>
        ///     Error code for the failed bulk deletion.
        /// </summary>
        [AttributeLogicalName("errornumber")]
        public int? ErrorNumber
        {
            get { return GetAttributeValue<int?>("errornumber"); }
        }

        /// <summary>
        ///     Index of the ordered query expression that retrieved this record.
        /// </summary>
        [AttributeLogicalName("orderedqueryindex")]
        public int? OrderedQueryIndex
        {
            get { return GetAttributeValue<int?>("orderedqueryindex"); }
        }

        /// <summary>
        ///     Unique identifier of the user or team who owns the bulk operation log.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId
        {
            get { return GetAttributeValue<EntityReference>("ownerid"); }
        }

        /// <summary>
        ///     Unique identifier of the business unit that owns the bulk deletion failure.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public Guid? OwningBusinessUnit
        {
            get { return GetAttributeValue<Guid?>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the bulk deletion failure record.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public Guid? OwningUser
        {
            get { return GetAttributeValue<Guid?>("owninguser"); }
        }

        /// <summary>
        ///     Unique identifier of the record that can not be deleted.
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        public EntityReference RegardingObjectId
        {
            get { return GetAttributeValue<EntityReference>("regardingobjectid"); }
        }

        /// <summary>
        ///     1:N userentityinstancedata_bulkdeletefailure
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_bulkdeletefailure")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_bulkdeletefailure
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_bulkdeletefailure", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_bulkdeletefailure");
                SetRelatedEntities("userentityinstancedata_bulkdeletefailure", null, value);
                OnPropertyChanged("userentityinstancedata_bulkdeletefailure");
            }
        }

        /// <summary>
        ///     N:1 Account_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Account_BulkDeleteFailures")]
        public Account Account_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Account>("Account_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 ActivityMimeAttachment_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("ActivityMimeAttachment_BulkDeleteFailures")]
        public ActivityMimeAttachment ActivityMimeAttachment_BulkDeleteFailures
        {
            get { return GetRelatedEntity<ActivityMimeAttachment>("ActivityMimeAttachment_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 ActivityPointer_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("ActivityPointer_BulkDeleteFailures")]
        public ActivityPointer ActivityPointer_BulkDeleteFailures
        {
            get { return GetRelatedEntity<ActivityPointer>("ActivityPointer_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 Annotation_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Annotation_BulkDeleteFailures")]
        public Annotation Annotation_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Annotation>("Annotation_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 AnnualFiscalCalendar_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("AnnualFiscalCalendar_BulkDeleteFailures")]
        public AnnualFiscalCalendar AnnualFiscalCalendar_BulkDeleteFailures
        {
            get { return GetRelatedEntity<AnnualFiscalCalendar>("AnnualFiscalCalendar_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 Appointment_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Appointment_BulkDeleteFailures")]
        public Appointment Appointment_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Appointment>("Appointment_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 AttributeMap_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("AttributeMap_BulkDeleteFailures")]
        public AttributeMap AttributeMap_BulkDeleteFailures
        {
            get { return GetRelatedEntity<AttributeMap>("AttributeMap_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 BulkDeleteOperation_BulkDeleteFailure
        /// </summary>
        [AttributeLogicalName("bulkdeleteoperationid")]
        [RelationshipSchemaName("BulkDeleteOperation_BulkDeleteFailure")]
        public BulkDeleteOperation BulkDeleteOperation_BulkDeleteFailure
        {
            get { return GetRelatedEntity<BulkDeleteOperation>("BulkDeleteOperation_BulkDeleteFailure", null); }
        }

        /// <summary>
        ///     N:1 BulkOperation_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("BulkOperation_BulkDeleteFailures")]
        public BulkOperation BulkOperation_BulkDeleteFailures
        {
            get { return GetRelatedEntity<BulkOperation>("BulkOperation_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 BulkOperationLog_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("BulkOperationLog_BulkDeleteFailures")]
        public BulkOperationLog BulkOperationLog_BulkDeleteFailures
        {
            get { return GetRelatedEntity<BulkOperationLog>("BulkOperationLog_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 BusinessUnit_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("BusinessUnit_BulkDeleteFailures")]
        public BusinessUnit BusinessUnit_BulkDeleteFailures
        {
            get { return GetRelatedEntity<BusinessUnit>("BusinessUnit_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 BusinessUnitNewsArticle_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("BusinessUnitNewsArticle_BulkDeleteFailures")]
        public BusinessUnitNewsArticle BusinessUnitNewsArticle_BulkDeleteFailures
        {
            get
            {
                return GetRelatedEntity<BusinessUnitNewsArticle>("BusinessUnitNewsArticle_BulkDeleteFailures", null);
            }
        }

        /// <summary>
        ///     N:1 Calendar_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Calendar_BulkDeleteFailures")]
        public Calendar Calendar_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Calendar>("Calendar_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 Campaign_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Campaign_BulkDeleteFailures")]
        public Campaign Campaign_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Campaign>("Campaign_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 CampaignActivity_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("CampaignActivity_BulkDeleteFailures")]
        public CampaignActivity CampaignActivity_BulkDeleteFailures
        {
            get { return GetRelatedEntity<CampaignActivity>("CampaignActivity_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 CampaignResponse_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("CampaignResponse_BulkDeleteFailures")]
        public CampaignResponse CampaignResponse_BulkDeleteFailures
        {
            get { return GetRelatedEntity<CampaignResponse>("CampaignResponse_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 Competitor_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Competitor_BulkDeleteFailures")]
        public Competitor Competitor_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Competitor>("Competitor_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 ConstraintBasedGroup_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("ConstraintBasedGroup_BulkDeleteFailures")]
        public ConstraintBasedGroup ConstraintBasedGroup_BulkDeleteFailures
        {
            get { return GetRelatedEntity<ConstraintBasedGroup>("ConstraintBasedGroup_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 Contact_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Contact_BulkDeleteFailures")]
        public Contact Contact_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Contact>("Contact_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 Contract_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Contract_BulkDeleteFailures")]
        public Contract Contract_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Contract>("Contract_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 ContractDetail_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("ContractDetail_BulkDeleteFailures")]
        public ContractDetail ContractDetail_BulkDeleteFailures
        {
            get { return GetRelatedEntity<ContractDetail>("ContractDetail_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 ContractTemplate_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("ContractTemplate_BulkDeleteFailures")]
        public ContractTemplate ContractTemplate_BulkDeleteFailures
        {
            get { return GetRelatedEntity<ContractTemplate>("ContractTemplate_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 CustomerAddress_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("CustomerAddress_BulkDeleteFailures")]
        public CustomerAddress CustomerAddress_BulkDeleteFailures
        {
            get { return GetRelatedEntity<CustomerAddress>("CustomerAddress_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 CustomerOpportunityRole_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("CustomerOpportunityRole_BulkDeleteFailures")]
        public CustomerOpportunityRole CustomerOpportunityRole_BulkDeleteFailures
        {
            get
            {
                return GetRelatedEntity<CustomerOpportunityRole>("CustomerOpportunityRole_BulkDeleteFailures", null);
            }
        }

        /// <summary>
        ///     N:1 CustomerRelationship_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("CustomerRelationship_BulkDeleteFailures")]
        public CustomerRelationship CustomerRelationship_BulkDeleteFailures
        {
            get { return GetRelatedEntity<CustomerRelationship>("CustomerRelationship_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 Discount_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Discount_BulkDeleteFailures")]
        public Discount Discount_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Discount>("Discount_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 DiscountType_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("DiscountType_BulkDeleteFailures")]
        public DiscountType DiscountType_BulkDeleteFailures
        {
            get { return GetRelatedEntity<DiscountType>("DiscountType_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 DisplayString_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("DisplayString_BulkDeleteFailures")]
        public DisplayString DisplayString_BulkDeleteFailures
        {
            get { return GetRelatedEntity<DisplayString>("DisplayString_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 Email_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Email_BulkDeleteFailures")]
        public Email Email_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Email>("Email_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 emailserverprofile_bulkdeletefailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("emailserverprofile_bulkdeletefailures")]
        public EmailServerProfile emailserverprofile_bulkdeletefailures
        {
            get { return GetRelatedEntity<EmailServerProfile>("emailserverprofile_bulkdeletefailures", null); }
        }

        /// <summary>
        ///     N:1 EntityMap_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("EntityMap_BulkDeleteFailures")]
        public EntityMap EntityMap_BulkDeleteFailures
        {
            get { return GetRelatedEntity<EntityMap>("EntityMap_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 Equipment_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Equipment_BulkDeleteFailures")]
        public Equipment Equipment_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Equipment>("Equipment_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 Fax_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Fax_BulkDeleteFailures")]
        public Fax Fax_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Fax>("Fax_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 FixedMonthlyFiscalCalendar_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("FixedMonthlyFiscalCalendar_BulkDeleteFailures")]
        public FixedMonthlyFiscalCalendar FixedMonthlyFiscalCalendar_BulkDeleteFailures
        {
            get
            {
                return GetRelatedEntity<FixedMonthlyFiscalCalendar>("FixedMonthlyFiscalCalendar_BulkDeleteFailures",
                    null);
            }
        }

        /// <summary>
        ///     N:1 Import_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Import_BulkDeleteFailures")]
        public Import Import_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Import>("Import_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 ImportFile_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("ImportFile_BulkDeleteFailures")]
        public ImportFile ImportFile_BulkDeleteFailures
        {
            get { return GetRelatedEntity<ImportFile>("ImportFile_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 ImportLog_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("ImportLog_BulkDeleteFailures")]
        public ImportLog ImportLog_BulkDeleteFailures
        {
            get { return GetRelatedEntity<ImportLog>("ImportLog_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 ImportMap_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("ImportMap_BulkDeleteFailures")]
        public ImportMap ImportMap_BulkDeleteFailures
        {
            get { return GetRelatedEntity<ImportMap>("ImportMap_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 Incident_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Incident_BulkDeleteFailures")]
        public Incident Incident_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Incident>("Incident_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 IncidentResolution_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("IncidentResolution_BulkDeleteFailures")]
        public IncidentResolution IncidentResolution_BulkDeleteFailures
        {
            get { return GetRelatedEntity<IncidentResolution>("IncidentResolution_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 Invoice_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Invoice_BulkDeleteFailures")]
        public Invoice Invoice_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Invoice>("Invoice_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 InvoiceDetail_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("InvoiceDetail_BulkDeleteFailures")]
        public InvoiceDetail InvoiceDetail_BulkDeleteFailures
        {
            get { return GetRelatedEntity<InvoiceDetail>("InvoiceDetail_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 IsvConfig_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("IsvConfig_BulkDeleteFailures")]
        public IsvConfig IsvConfig_BulkDeleteFailures
        {
            get { return GetRelatedEntity<IsvConfig>("IsvConfig_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 KbArticle_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("KbArticle_BulkDeleteFailures")]
        public KbArticle KbArticle_BulkDeleteFailures
        {
            get { return GetRelatedEntity<KbArticle>("KbArticle_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 KbArticleComment_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("KbArticleComment_BulkDeleteFailures")]
        public KbArticleComment KbArticleComment_BulkDeleteFailures
        {
            get { return GetRelatedEntity<KbArticleComment>("KbArticleComment_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 KbArticleTemplate_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("KbArticleTemplate_BulkDeleteFailures")]
        public KbArticleTemplate KbArticleTemplate_BulkDeleteFailures
        {
            get { return GetRelatedEntity<KbArticleTemplate>("KbArticleTemplate_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 Lead_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Lead_BulkDeleteFailures")]
        public Lead Lead_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Lead>("Lead_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 Letter_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Letter_BulkDeleteFailures")]
        public Letter Letter_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Letter>("Letter_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 List_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("List_BulkDeleteFailures")]
        public List List_BulkDeleteFailures
        {
            get { return GetRelatedEntity<List>("List_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 MonthlyFiscalCalendar_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("MonthlyFiscalCalendar_BulkDeleteFailures")]
        public MonthlyFiscalCalendar MonthlyFiscalCalendar_BulkDeleteFailures
        {
            get { return GetRelatedEntity<MonthlyFiscalCalendar>("MonthlyFiscalCalendar_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 msdyn_postalbum_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("msdyn_postalbum_BulkDeleteFailures")]
        public msdyn_PostAlbum msdyn_postalbum_BulkDeleteFailures
        {
            get { return GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 msdyn_postconfig_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("msdyn_postconfig_BulkDeleteFailures")]
        public msdyn_PostConfig msdyn_postconfig_BulkDeleteFailures
        {
            get { return GetRelatedEntity<msdyn_PostConfig>("msdyn_postconfig_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 msdyn_postruleconfig_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("msdyn_postruleconfig_BulkDeleteFailures")]
        public msdyn_PostRuleConfig msdyn_postruleconfig_BulkDeleteFailures
        {
            get { return GetRelatedEntity<msdyn_PostRuleConfig>("msdyn_postruleconfig_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 msdyn_wallsavedquery_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("msdyn_wallsavedquery_BulkDeleteFailures")]
        public msdyn_wallsavedquery msdyn_wallsavedquery_BulkDeleteFailures
        {
            get { return GetRelatedEntity<msdyn_wallsavedquery>("msdyn_wallsavedquery_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 msdyn_wallsavedqueryusersettings_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("msdyn_wallsavedqueryusersettings_BulkDeleteFailures")]
        public msdyn_wallsavedqueryusersettings msdyn_wallsavedqueryusersettings_BulkDeleteFailures
        {
            get
            {
                return
                    GetRelatedEntity<msdyn_wallsavedqueryusersettings>(
                        "msdyn_wallsavedqueryusersettings_BulkDeleteFailures", null);
            }
        }

        /// <summary>
        ///     N:1 Opportunity_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Opportunity_BulkDeleteFailures")]
        public Opportunity Opportunity_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Opportunity>("Opportunity_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 OpportunityClose_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("OpportunityClose_BulkDeleteFailures")]
        public OpportunityClose OpportunityClose_BulkDeleteFailures
        {
            get { return GetRelatedEntity<OpportunityClose>("OpportunityClose_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 OpportunityProduct_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("OpportunityProduct_BulkDeleteFailures")]
        public OpportunityProduct OpportunityProduct_BulkDeleteFailures
        {
            get { return GetRelatedEntity<OpportunityProduct>("OpportunityProduct_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 OrderClose_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("OrderClose_BulkDeleteFailures")]
        public OrderClose OrderClose_BulkDeleteFailures
        {
            get { return GetRelatedEntity<OrderClose>("OrderClose_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 Organization_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Organization_BulkDeleteFailures")]
        public Organization Organization_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Organization>("Organization_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 PhoneCall_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("PhoneCall_BulkDeleteFailures")]
        public PhoneCall PhoneCall_BulkDeleteFailures
        {
            get { return GetRelatedEntity<PhoneCall>("PhoneCall_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 post_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("post_BulkDeleteFailures")]
        public Post post_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Post>("post_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 PriceLevel_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("PriceLevel_BulkDeleteFailures")]
        public PriceLevel PriceLevel_BulkDeleteFailures
        {
            get { return GetRelatedEntity<PriceLevel>("PriceLevel_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 Privilege_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Privilege_BulkDeleteFailures")]
        public Privilege Privilege_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Privilege>("Privilege_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 Product_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Product_BulkDeleteFailures")]
        public Product Product_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Product>("Product_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 ProductPriceLevel_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("ProductPriceLevel_BulkDeleteFailures")]
        public ProductPriceLevel ProductPriceLevel_BulkDeleteFailures
        {
            get { return GetRelatedEntity<ProductPriceLevel>("ProductPriceLevel_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 QuarterlyFiscalCalendar_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("QuarterlyFiscalCalendar_BulkDeleteFailures")]
        public QuarterlyFiscalCalendar QuarterlyFiscalCalendar_BulkDeleteFailures
        {
            get
            {
                return GetRelatedEntity<QuarterlyFiscalCalendar>("QuarterlyFiscalCalendar_BulkDeleteFailures", null);
            }
        }

        /// <summary>
        ///     N:1 Queue_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Queue_BulkDeleteFailures")]
        public Queue Queue_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Queue>("Queue_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 QueueItem_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("QueueItem_BulkDeleteFailures")]
        public QueueItem QueueItem_BulkDeleteFailures
        {
            get { return GetRelatedEntity<QueueItem>("QueueItem_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 Quote_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Quote_BulkDeleteFailures")]
        public Quote Quote_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Quote>("Quote_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 QuoteClose_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("QuoteClose_BulkDeleteFailures")]
        public QuoteClose QuoteClose_BulkDeleteFailures
        {
            get { return GetRelatedEntity<QuoteClose>("QuoteClose_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 QuoteDetail_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("QuoteDetail_BulkDeleteFailures")]
        public QuoteDetail QuoteDetail_BulkDeleteFailures
        {
            get { return GetRelatedEntity<QuoteDetail>("QuoteDetail_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 RecurringAppointmentMaster_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("RecurringAppointmentMaster_BulkDeleteFailures")]
        public RecurringAppointmentMaster RecurringAppointmentMaster_BulkDeleteFailures
        {
            get
            {
                return GetRelatedEntity<RecurringAppointmentMaster>("RecurringAppointmentMaster_BulkDeleteFailures",
                    null);
            }
        }

        /// <summary>
        ///     N:1 RelationshipRole_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("RelationshipRole_BulkDeleteFailures")]
        public RelationshipRole RelationshipRole_BulkDeleteFailures
        {
            get { return GetRelatedEntity<RelationshipRole>("RelationshipRole_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 RelationshipRoleMap_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("RelationshipRoleMap_BulkDeleteFailures")]
        public RelationshipRoleMap RelationshipRoleMap_BulkDeleteFailures
        {
            get { return GetRelatedEntity<RelationshipRoleMap>("RelationshipRoleMap_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 Resource_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Resource_BulkDeleteFailures")]
        public Resource Resource_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Resource>("Resource_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 ResourceGroup_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("ResourceGroup_BulkDeleteFailures")]
        public ResourceGroup ResourceGroup_BulkDeleteFailures
        {
            get { return GetRelatedEntity<ResourceGroup>("ResourceGroup_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 ResourceSpec_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("ResourceSpec_BulkDeleteFailures")]
        public ResourceSpec ResourceSpec_BulkDeleteFailures
        {
            get { return GetRelatedEntity<ResourceSpec>("ResourceSpec_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 Role_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Role_BulkDeleteFailures")]
        public Role Role_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Role>("Role_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 SalesLiterature_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SalesLiterature_BulkDeleteFailures")]
        public SalesLiterature SalesLiterature_BulkDeleteFailures
        {
            get { return GetRelatedEntity<SalesLiterature>("SalesLiterature_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 SalesLiteratureItem_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SalesLiteratureItem_BulkDeleteFailures")]
        public SalesLiteratureItem SalesLiteratureItem_BulkDeleteFailures
        {
            get { return GetRelatedEntity<SalesLiteratureItem>("SalesLiteratureItem_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 SalesOrder_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SalesOrder_BulkDeleteFailures")]
        public SalesOrder SalesOrder_BulkDeleteFailures
        {
            get { return GetRelatedEntity<SalesOrder>("SalesOrder_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 SalesOrderDetail_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SalesOrderDetail_BulkDeleteFailures")]
        public SalesOrderDetail SalesOrderDetail_BulkDeleteFailures
        {
            get { return GetRelatedEntity<SalesOrderDetail>("SalesOrderDetail_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 SavedQuery_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SavedQuery_BulkDeleteFailures")]
        public SavedQuery SavedQuery_BulkDeleteFailures
        {
            get { return GetRelatedEntity<SavedQuery>("SavedQuery_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 SemiAnnualFiscalCalendar_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SemiAnnualFiscalCalendar_BulkDeleteFailures")]
        public SemiAnnualFiscalCalendar SemiAnnualFiscalCalendar_BulkDeleteFailures
        {
            get
            {
                return GetRelatedEntity<SemiAnnualFiscalCalendar>("SemiAnnualFiscalCalendar_BulkDeleteFailures", null);
            }
        }

        /// <summary>
        ///     N:1 Service_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Service_BulkDeleteFailures")]
        public Service Service_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Service>("Service_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 ServiceAppointment_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("ServiceAppointment_BulkDeleteFailures")]
        public ServiceAppointment ServiceAppointment_BulkDeleteFailures
        {
            get { return GetRelatedEntity<ServiceAppointment>("ServiceAppointment_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 Site_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Site_BulkDeleteFailures")]
        public Site Site_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Site>("Site_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 Subject_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Subject_BulkDeleteFailures")]
        public Subject Subject_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Subject>("Subject_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 SystemForm_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SystemForm_BulkDeleteFailures")]
        public SystemForm SystemForm_BulkDeleteFailures
        {
            get { return GetRelatedEntity<SystemForm>("SystemForm_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 SystemUser_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SystemUser_BulkDeleteFailures")]
        public SystemUser SystemUser_BulkDeleteFailures
        {
            get { return GetRelatedEntity<SystemUser>("SystemUser_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 Task_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Task_BulkDeleteFailures")]
        public Task Task_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Task>("Task_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 Team_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Team_BulkDeleteFailures")]
        public Team Team_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Team>("Team_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 Template_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Template_BulkDeleteFailures")]
        public Template Template_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Template>("Template_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 Territory_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Territory_BulkDeleteFailures")]
        public Territory Territory_BulkDeleteFailures
        {
            get { return GetRelatedEntity<Territory>("Territory_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 UoM_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("UoM_BulkDeleteFailures")]
        public UoM UoM_BulkDeleteFailures
        {
            get { return GetRelatedEntity<UoM>("UoM_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 UoMSchedule_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("UoMSchedule_BulkDeleteFailures")]
        public UoMSchedule UoMSchedule_BulkDeleteFailures
        {
            get { return GetRelatedEntity<UoMSchedule>("UoMSchedule_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 UserForm_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("UserForm_BulkDeleteFailures")]
        public UserForm UserForm_BulkDeleteFailures
        {
            get { return GetRelatedEntity<UserForm>("UserForm_BulkDeleteFailures", null); }
        }

        /// <summary>
        ///     N:1 UserQuery_BulkDeleteFailures
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("UserQuery_BulkDeleteFailures")]
        public UserQuery UserQuery_BulkDeleteFailures
        {
            get { return GetRelatedEntity<UserQuery>("UserQuery_BulkDeleteFailures", null); }
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