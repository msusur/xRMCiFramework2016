using System.CodeDom.Compiler;
using System.Linq;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Xrm.Framework.CI.PowerShell.Common;

namespace Xrm.Framework.CI.Common.Entities
{
    /// <summary>
    ///     Represents a source of entities bound to a CRM service. It tracks and manages changes made to the retrieved
    ///     entities.
    /// </summary>
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class CIContext : OrganizationServiceContext
    {
        /// <summary>
        ///     Constructor.
        /// </summary>
        public CIContext(IOrganizationService service) :
            base(service)
        {
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Account" /> entities.
        /// </summary>
        public IQueryable<Account> AccountSet
        {
            get { return CreateQuery<Account>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.AccountLeads" /> entities.
        /// </summary>
        public IQueryable<AccountLeads> AccountLeadsSet
        {
            get { return CreateQuery<AccountLeads>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ActivityMimeAttachment" /> entities.
        /// </summary>
        public IQueryable<ActivityMimeAttachment> ActivityMimeAttachmentSet
        {
            get { return CreateQuery<ActivityMimeAttachment>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ActivityParty" /> entities.
        /// </summary>
        public IQueryable<ActivityParty> ActivityPartySet
        {
            get { return CreateQuery<ActivityParty>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ActivityPointer" /> entities.
        /// </summary>
        public IQueryable<ActivityPointer> ActivityPointerSet
        {
            get { return CreateQuery<ActivityPointer>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Annotation" /> entities.
        /// </summary>
        public IQueryable<Annotation> AnnotationSet
        {
            get { return CreateQuery<Annotation>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.AnnualFiscalCalendar" /> entities.
        /// </summary>
        public IQueryable<AnnualFiscalCalendar> AnnualFiscalCalendarSet
        {
            get { return CreateQuery<AnnualFiscalCalendar>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Appointment" /> entities.
        /// </summary>
        public IQueryable<Appointment> AppointmentSet
        {
            get { return CreateQuery<Appointment>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.AsyncOperation" /> entities.
        /// </summary>
        public IQueryable<AsyncOperation> AsyncOperationSet
        {
            get { return CreateQuery<AsyncOperation>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.AttributeMap" /> entities.
        /// </summary>
        public IQueryable<AttributeMap> AttributeMapSet
        {
            get { return CreateQuery<AttributeMap>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Audit" /> entities.
        /// </summary>
        public IQueryable<Audit> AuditSet
        {
            get { return CreateQuery<Audit>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.BulkDeleteFailure" /> entities.
        /// </summary>
        public IQueryable<BulkDeleteFailure> BulkDeleteFailureSet
        {
            get { return CreateQuery<BulkDeleteFailure>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.BulkDeleteOperation" /> entities.
        /// </summary>
        public IQueryable<BulkDeleteOperation> BulkDeleteOperationSet
        {
            get { return CreateQuery<BulkDeleteOperation>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.BulkOperation" /> entities.
        /// </summary>
        public IQueryable<BulkOperation> BulkOperationSet
        {
            get { return CreateQuery<BulkOperation>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.BulkOperationLog" /> entities.
        /// </summary>
        public IQueryable<BulkOperationLog> BulkOperationLogSet
        {
            get { return CreateQuery<BulkOperationLog>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.BusinessUnit" /> entities.
        /// </summary>
        public IQueryable<BusinessUnit> BusinessUnitSet
        {
            get { return CreateQuery<BusinessUnit>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.BusinessUnitNewsArticle" /> entities.
        /// </summary>
        public IQueryable<BusinessUnitNewsArticle> BusinessUnitNewsArticleSet
        {
            get { return CreateQuery<BusinessUnitNewsArticle>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Calendar" /> entities.
        /// </summary>
        public IQueryable<Calendar> CalendarSet
        {
            get { return CreateQuery<Calendar>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Campaign" /> entities.
        /// </summary>
        public IQueryable<Campaign> CampaignSet
        {
            get { return CreateQuery<Campaign>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.CampaignActivity" /> entities.
        /// </summary>
        public IQueryable<CampaignActivity> CampaignActivitySet
        {
            get { return CreateQuery<CampaignActivity>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.CampaignActivityItem" /> entities.
        /// </summary>
        public IQueryable<CampaignActivityItem> CampaignActivityItemSet
        {
            get { return CreateQuery<CampaignActivityItem>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.CampaignItem" /> entities.
        /// </summary>
        public IQueryable<CampaignItem> CampaignItemSet
        {
            get { return CreateQuery<CampaignItem>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.CampaignResponse" /> entities.
        /// </summary>
        public IQueryable<CampaignResponse> CampaignResponseSet
        {
            get { return CreateQuery<CampaignResponse>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ColumnMapping" /> entities.
        /// </summary>
        public IQueryable<ColumnMapping> ColumnMappingSet
        {
            get { return CreateQuery<ColumnMapping>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Competitor" /> entities.
        /// </summary>
        public IQueryable<Competitor> CompetitorSet
        {
            get { return CreateQuery<Competitor>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.CompetitorProduct" /> entities.
        /// </summary>
        public IQueryable<CompetitorProduct> CompetitorProductSet
        {
            get { return CreateQuery<CompetitorProduct>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.CompetitorSalesLiterature" />
        ///     entities.
        /// </summary>
        public IQueryable<CompetitorSalesLiterature> CompetitorSalesLiteratureSet
        {
            get { return CreateQuery<CompetitorSalesLiterature>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Connection" /> entities.
        /// </summary>
        public IQueryable<Connection> ConnectionSet
        {
            get { return CreateQuery<Connection>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ConnectionRole" /> entities.
        /// </summary>
        public IQueryable<ConnectionRole> ConnectionRoleSet
        {
            get { return CreateQuery<ConnectionRole>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ConnectionRoleAssociation" />
        ///     entities.
        /// </summary>
        public IQueryable<ConnectionRoleAssociation> ConnectionRoleAssociationSet
        {
            get { return CreateQuery<ConnectionRoleAssociation>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ConnectionRoleObjectTypeCode" />
        ///     entities.
        /// </summary>
        public IQueryable<ConnectionRoleObjectTypeCode> ConnectionRoleObjectTypeCodeSet
        {
            get { return CreateQuery<ConnectionRoleObjectTypeCode>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ConstraintBasedGroup" /> entities.
        /// </summary>
        public IQueryable<ConstraintBasedGroup> ConstraintBasedGroupSet
        {
            get { return CreateQuery<ConstraintBasedGroup>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Contact" /> entities.
        /// </summary>
        public IQueryable<Contact> ContactSet
        {
            get { return CreateQuery<Contact>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ContactInvoices" /> entities.
        /// </summary>
        public IQueryable<ContactInvoices> ContactInvoicesSet
        {
            get { return CreateQuery<ContactInvoices>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ContactLeads" /> entities.
        /// </summary>
        public IQueryable<ContactLeads> ContactLeadsSet
        {
            get { return CreateQuery<ContactLeads>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ContactOrders" /> entities.
        /// </summary>
        public IQueryable<ContactOrders> ContactOrdersSet
        {
            get { return CreateQuery<ContactOrders>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ContactQuotes" /> entities.
        /// </summary>
        public IQueryable<ContactQuotes> ContactQuotesSet
        {
            get { return CreateQuery<ContactQuotes>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Contract" /> entities.
        /// </summary>
        public IQueryable<Contract> ContractSet
        {
            get { return CreateQuery<Contract>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ContractDetail" /> entities.
        /// </summary>
        public IQueryable<ContractDetail> ContractDetailSet
        {
            get { return CreateQuery<ContractDetail>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ContractTemplate" /> entities.
        /// </summary>
        public IQueryable<ContractTemplate> ContractTemplateSet
        {
            get { return CreateQuery<ContractTemplate>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.CustomerAddress" /> entities.
        /// </summary>
        public IQueryable<CustomerAddress> CustomerAddressSet
        {
            get { return CreateQuery<CustomerAddress>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.CustomerOpportunityRole" /> entities.
        /// </summary>
        public IQueryable<CustomerOpportunityRole> CustomerOpportunityRoleSet
        {
            get { return CreateQuery<CustomerOpportunityRole>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.CustomerRelationship" /> entities.
        /// </summary>
        public IQueryable<CustomerRelationship> CustomerRelationshipSet
        {
            get { return CreateQuery<CustomerRelationship>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Dependency" /> entities.
        /// </summary>
        public IQueryable<Dependency> DependencySet
        {
            get { return CreateQuery<Dependency>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Discount" /> entities.
        /// </summary>
        public IQueryable<Discount> DiscountSet
        {
            get { return CreateQuery<Discount>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.DiscountType" /> entities.
        /// </summary>
        public IQueryable<DiscountType> DiscountTypeSet
        {
            get { return CreateQuery<DiscountType>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.DisplayString" /> entities.
        /// </summary>
        public IQueryable<DisplayString> DisplayStringSet
        {
            get { return CreateQuery<DisplayString>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.DuplicateRecord" /> entities.
        /// </summary>
        public IQueryable<DuplicateRecord> DuplicateRecordSet
        {
            get { return CreateQuery<DuplicateRecord>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.DuplicateRule" /> entities.
        /// </summary>
        public IQueryable<DuplicateRule> DuplicateRuleSet
        {
            get { return CreateQuery<DuplicateRule>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.DuplicateRuleCondition" /> entities.
        /// </summary>
        public IQueryable<DuplicateRuleCondition> DuplicateRuleConditionSet
        {
            get { return CreateQuery<DuplicateRuleCondition>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Email" /> entities.
        /// </summary>
        public IQueryable<Email> EmailSet
        {
            get { return CreateQuery<Email>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.EmailServerProfile" /> entities.
        /// </summary>
        public IQueryable<EmailServerProfile> EmailServerProfileSet
        {
            get { return CreateQuery<EmailServerProfile>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.EntityMap" /> entities.
        /// </summary>
        public IQueryable<EntityMap> EntityMapSet
        {
            get { return CreateQuery<EntityMap>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Equipment" /> entities.
        /// </summary>
        public IQueryable<Equipment> EquipmentSet
        {
            get { return CreateQuery<Equipment>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ExchangeSyncIdMapping" /> entities.
        /// </summary>
        public IQueryable<ExchangeSyncIdMapping> ExchangeSyncIdMappingSet
        {
            get { return CreateQuery<ExchangeSyncIdMapping>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Fax" /> entities.
        /// </summary>
        public IQueryable<Fax> FaxSet
        {
            get { return CreateQuery<Fax>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.FieldPermission" /> entities.
        /// </summary>
        public IQueryable<FieldPermission> FieldPermissionSet
        {
            get { return CreateQuery<FieldPermission>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.FieldSecurityProfile" /> entities.
        /// </summary>
        public IQueryable<FieldSecurityProfile> FieldSecurityProfileSet
        {
            get { return CreateQuery<FieldSecurityProfile>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.FixedMonthlyFiscalCalendar" />
        ///     entities.
        /// </summary>
        public IQueryable<FixedMonthlyFiscalCalendar> FixedMonthlyFiscalCalendarSet
        {
            get { return CreateQuery<FixedMonthlyFiscalCalendar>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Goal" /> entities.
        /// </summary>
        public IQueryable<Goal> GoalSet
        {
            get { return CreateQuery<Goal>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.GoalRollupQuery" /> entities.
        /// </summary>
        public IQueryable<GoalRollupQuery> GoalRollupQuerySet
        {
            get { return CreateQuery<GoalRollupQuery>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Import" /> entities.
        /// </summary>
        public IQueryable<Import> ImportSet
        {
            get { return CreateQuery<Import>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ImportEntityMapping" /> entities.
        /// </summary>
        public IQueryable<ImportEntityMapping> ImportEntityMappingSet
        {
            get { return CreateQuery<ImportEntityMapping>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ImportFile" /> entities.
        /// </summary>
        public IQueryable<ImportFile> ImportFileSet
        {
            get { return CreateQuery<ImportFile>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ImportJob" /> entities.
        /// </summary>
        public IQueryable<ImportJob> ImportJobSet
        {
            get { return CreateQuery<ImportJob>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ImportLog" /> entities.
        /// </summary>
        public IQueryable<ImportLog> ImportLogSet
        {
            get { return CreateQuery<ImportLog>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ImportMap" /> entities.
        /// </summary>
        public IQueryable<ImportMap> ImportMapSet
        {
            get { return CreateQuery<ImportMap>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Incident" /> entities.
        /// </summary>
        public IQueryable<Incident> IncidentSet
        {
            get { return CreateQuery<Incident>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.IncidentResolution" /> entities.
        /// </summary>
        public IQueryable<IncidentResolution> IncidentResolutionSet
        {
            get { return CreateQuery<IncidentResolution>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.InvalidDependency" /> entities.
        /// </summary>
        public IQueryable<InvalidDependency> InvalidDependencySet
        {
            get { return CreateQuery<InvalidDependency>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Invoice" /> entities.
        /// </summary>
        public IQueryable<Invoice> InvoiceSet
        {
            get { return CreateQuery<Invoice>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="InvoiceDetail" /> entities.
        /// </summary>
        public IQueryable<InvoiceDetail> InvoiceDetailSet
        {
            get { return CreateQuery<InvoiceDetail>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.IsvConfig" /> entities.
        /// </summary>
        public IQueryable<IsvConfig> IsvConfigSet
        {
            get { return CreateQuery<IsvConfig>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.KbArticle" /> entities.
        /// </summary>
        public IQueryable<KbArticle> KbArticleSet
        {
            get { return CreateQuery<KbArticle>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.KbArticleComment" /> entities.
        /// </summary>
        public IQueryable<KbArticleComment> KbArticleCommentSet
        {
            get { return CreateQuery<KbArticleComment>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.KbArticleTemplate" /> entities.
        /// </summary>
        public IQueryable<KbArticleTemplate> KbArticleTemplateSet
        {
            get { return CreateQuery<KbArticleTemplate>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Lead" /> entities.
        /// </summary>
        public IQueryable<Lead> LeadSet
        {
            get { return CreateQuery<Lead>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.LeadAddress" /> entities.
        /// </summary>
        public IQueryable<LeadAddress> LeadAddressSet
        {
            get { return CreateQuery<LeadAddress>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.LeadCompetitors" /> entities.
        /// </summary>
        public IQueryable<LeadCompetitors> LeadCompetitorsSet
        {
            get { return CreateQuery<LeadCompetitors>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.LeadProduct" /> entities.
        /// </summary>
        public IQueryable<LeadProduct> LeadProductSet
        {
            get { return CreateQuery<LeadProduct>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Letter" /> entities.
        /// </summary>
        public IQueryable<Letter> LetterSet
        {
            get { return CreateQuery<Letter>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.License" /> entities.
        /// </summary>
        public IQueryable<License> LicenseSet
        {
            get { return CreateQuery<License>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.List" /> entities.
        /// </summary>
        public IQueryable<List> ListSet
        {
            get { return CreateQuery<List>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ListMember" /> entities.
        /// </summary>
        public IQueryable<ListMember> ListMemberSet
        {
            get { return CreateQuery<ListMember>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.LookUpMapping" /> entities.
        /// </summary>
        public IQueryable<LookUpMapping> LookUpMappingSet
        {
            get { return CreateQuery<LookUpMapping>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Mailbox" /> entities.
        /// </summary>
        public IQueryable<Mailbox> MailboxSet
        {
            get { return CreateQuery<Mailbox>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.MailMergeTemplate" /> entities.
        /// </summary>
        public IQueryable<MailMergeTemplate> MailMergeTemplateSet
        {
            get { return CreateQuery<MailMergeTemplate>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Metric" /> entities.
        /// </summary>
        public IQueryable<Metric> MetricSet
        {
            get { return CreateQuery<Metric>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.MonthlyFiscalCalendar" /> entities.
        /// </summary>
        public IQueryable<MonthlyFiscalCalendar> MonthlyFiscalCalendarSet
        {
            get { return CreateQuery<MonthlyFiscalCalendar>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.msdyn_PostAlbum" /> entities.
        /// </summary>
        public IQueryable<msdyn_PostAlbum> msdyn_PostAlbumSet
        {
            get { return CreateQuery<msdyn_PostAlbum>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.msdyn_PostConfig" /> entities.
        /// </summary>
        public IQueryable<msdyn_PostConfig> msdyn_PostConfigSet
        {
            get { return CreateQuery<msdyn_PostConfig>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.msdyn_PostRuleConfig" /> entities.
        /// </summary>
        public IQueryable<msdyn_PostRuleConfig> msdyn_PostRuleConfigSet
        {
            get { return CreateQuery<msdyn_PostRuleConfig>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.msdyn_wallsavedquery" /> entities.
        /// </summary>
        public IQueryable<msdyn_wallsavedquery> msdyn_wallsavedquerySet
        {
            get { return CreateQuery<msdyn_wallsavedquery>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.msdyn_wallsavedqueryusersettings" />
        ///     entities.
        /// </summary>
        public IQueryable<msdyn_wallsavedqueryusersettings> msdyn_wallsavedqueryusersettingsSet
        {
            get { return CreateQuery<msdyn_wallsavedqueryusersettings>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Opportunity" /> entities.
        /// </summary>
        public IQueryable<Opportunity> OpportunitySet
        {
            get { return CreateQuery<Opportunity>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.OpportunityClose" /> entities.
        /// </summary>
        public IQueryable<OpportunityClose> OpportunityCloseSet
        {
            get { return CreateQuery<OpportunityClose>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.OpportunityCompetitors" /> entities.
        /// </summary>
        public IQueryable<OpportunityCompetitors> OpportunityCompetitorsSet
        {
            get { return CreateQuery<OpportunityCompetitors>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.OpportunityProduct" /> entities.
        /// </summary>
        public IQueryable<OpportunityProduct> OpportunityProductSet
        {
            get { return CreateQuery<OpportunityProduct>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.OrderClose" /> entities.
        /// </summary>
        public IQueryable<OrderClose> OrderCloseSet
        {
            get { return CreateQuery<OrderClose>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Organization" /> entities.
        /// </summary>
        public IQueryable<Organization> OrganizationSet
        {
            get { return CreateQuery<Organization>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.OrganizationUI" /> entities.
        /// </summary>
        public IQueryable<OrganizationUI> OrganizationUISet
        {
            get { return CreateQuery<OrganizationUI>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.OwnerMapping" /> entities.
        /// </summary>
        public IQueryable<OwnerMapping> OwnerMappingSet
        {
            get { return CreateQuery<OwnerMapping>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.PhoneCall" /> entities.
        /// </summary>
        public IQueryable<PhoneCall> PhoneCallSet
        {
            get { return CreateQuery<PhoneCall>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.PickListMapping" /> entities.
        /// </summary>
        public IQueryable<PickListMapping> PickListMappingSet
        {
            get { return CreateQuery<PickListMapping>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.PluginAssembly" /> entities.
        /// </summary>
        public IQueryable<PluginAssembly> PluginAssemblySet
        {
            get { return CreateQuery<PluginAssembly>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.PluginType" /> entities.
        /// </summary>
        public IQueryable<PluginType> PluginTypeSet
        {
            get { return CreateQuery<PluginType>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.PluginTypeStatistic" /> entities.
        /// </summary>
        public IQueryable<PluginTypeStatistic> PluginTypeStatisticSet
        {
            get { return CreateQuery<PluginTypeStatistic>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Post" /> entities.
        /// </summary>
        public IQueryable<Post> PostSet
        {
            get { return CreateQuery<Post>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.PostComment" /> entities.
        /// </summary>
        public IQueryable<PostComment> PostCommentSet
        {
            get { return CreateQuery<PostComment>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.PostFollow" /> entities.
        /// </summary>
        public IQueryable<PostFollow> PostFollowSet
        {
            get { return CreateQuery<PostFollow>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.PostLike" /> entities.
        /// </summary>
        public IQueryable<PostLike> PostLikeSet
        {
            get { return CreateQuery<PostLike>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.PriceLevel" /> entities.
        /// </summary>
        public IQueryable<PriceLevel> PriceLevelSet
        {
            get { return CreateQuery<PriceLevel>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.PrincipalEntityMap" /> entities.
        /// </summary>
        public IQueryable<PrincipalEntityMap> PrincipalEntityMapSet
        {
            get { return CreateQuery<PrincipalEntityMap>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.PrincipalObjectAttributeAccess" />
        ///     entities.
        /// </summary>
        public IQueryable<PrincipalObjectAttributeAccess> PrincipalObjectAttributeAccessSet
        {
            get { return CreateQuery<PrincipalObjectAttributeAccess>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Privilege" /> entities.
        /// </summary>
        public IQueryable<Privilege> PrivilegeSet
        {
            get { return CreateQuery<Privilege>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ProcessSession" /> entities.
        /// </summary>
        public IQueryable<ProcessSession> ProcessSessionSet
        {
            get { return CreateQuery<ProcessSession>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ProcessStage" /> entities.
        /// </summary>
        public IQueryable<ProcessStage> ProcessStageSet
        {
            get { return CreateQuery<ProcessStage>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ProcessTrigger" /> entities.
        /// </summary>
        public IQueryable<ProcessTrigger> ProcessTriggerSet
        {
            get { return CreateQuery<ProcessTrigger>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Product" /> entities.
        /// </summary>
        public IQueryable<Product> ProductSet
        {
            get { return CreateQuery<Product>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ProductAssociation" /> entities.
        /// </summary>
        public IQueryable<ProductAssociation> ProductAssociationSet
        {
            get { return CreateQuery<ProductAssociation>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ProductPriceLevel" /> entities.
        /// </summary>
        public IQueryable<ProductPriceLevel> ProductPriceLevelSet
        {
            get { return CreateQuery<ProductPriceLevel>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ProductSalesLiterature" /> entities.
        /// </summary>
        public IQueryable<ProductSalesLiterature> ProductSalesLiteratureSet
        {
            get { return CreateQuery<ProductSalesLiterature>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ProductSubstitute" /> entities.
        /// </summary>
        public IQueryable<ProductSubstitute> ProductSubstituteSet
        {
            get { return CreateQuery<ProductSubstitute>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Publisher" /> entities.
        /// </summary>
        public IQueryable<Publisher> PublisherSet
        {
            get { return CreateQuery<Publisher>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.PublisherAddress" /> entities.
        /// </summary>
        public IQueryable<PublisherAddress> PublisherAddressSet
        {
            get { return CreateQuery<PublisherAddress>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.QuarterlyFiscalCalendar" /> entities.
        /// </summary>
        public IQueryable<QuarterlyFiscalCalendar> QuarterlyFiscalCalendarSet
        {
            get { return CreateQuery<QuarterlyFiscalCalendar>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Queue" /> entities.
        /// </summary>
        public IQueryable<Queue> QueueSet
        {
            get { return CreateQuery<Queue>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.QueueItem" /> entities.
        /// </summary>
        public IQueryable<QueueItem> QueueItemSet
        {
            get { return CreateQuery<QueueItem>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Quote" /> entities.
        /// </summary>
        public IQueryable<Quote> QuoteSet
        {
            get { return CreateQuery<Quote>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.QuoteClose" /> entities.
        /// </summary>
        public IQueryable<QuoteClose> QuoteCloseSet
        {
            get { return CreateQuery<QuoteClose>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.QuoteDetail" /> entities.
        /// </summary>
        public IQueryable<QuoteDetail> QuoteDetailSet
        {
            get { return CreateQuery<QuoteDetail>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.RecurrenceRule" /> entities.
        /// </summary>
        public IQueryable<RecurrenceRule> RecurrenceRuleSet
        {
            get { return CreateQuery<RecurrenceRule>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.RecurringAppointmentMaster" />
        ///     entities.
        /// </summary>
        public IQueryable<RecurringAppointmentMaster> RecurringAppointmentMasterSet
        {
            get { return CreateQuery<RecurringAppointmentMaster>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.RelationshipRole" /> entities.
        /// </summary>
        public IQueryable<RelationshipRole> RelationshipRoleSet
        {
            get { return CreateQuery<RelationshipRole>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.RelationshipRoleMap" /> entities.
        /// </summary>
        public IQueryable<RelationshipRoleMap> RelationshipRoleMapSet
        {
            get { return CreateQuery<RelationshipRoleMap>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Report" /> entities.
        /// </summary>
        public IQueryable<Report> ReportSet
        {
            get { return CreateQuery<Report>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ReportCategory" /> entities.
        /// </summary>
        public IQueryable<ReportCategory> ReportCategorySet
        {
            get { return CreateQuery<ReportCategory>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ReportEntity" /> entities.
        /// </summary>
        public IQueryable<ReportEntity> ReportEntitySet
        {
            get { return CreateQuery<ReportEntity>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ReportLink" /> entities.
        /// </summary>
        public IQueryable<ReportLink> ReportLinkSet
        {
            get { return CreateQuery<ReportLink>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ReportVisibility" /> entities.
        /// </summary>
        public IQueryable<ReportVisibility> ReportVisibilitySet
        {
            get { return CreateQuery<ReportVisibility>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Resource" /> entities.
        /// </summary>
        public IQueryable<Resource> ResourceSet
        {
            get { return CreateQuery<Resource>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ResourceGroup" /> entities.
        /// </summary>
        public IQueryable<ResourceGroup> ResourceGroupSet
        {
            get { return CreateQuery<ResourceGroup>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ResourceSpec" /> entities.
        /// </summary>
        public IQueryable<ResourceSpec> ResourceSpecSet
        {
            get { return CreateQuery<ResourceSpec>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.RibbonCustomization" /> entities.
        /// </summary>
        public IQueryable<RibbonCustomization> RibbonCustomizationSet
        {
            get { return CreateQuery<RibbonCustomization>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Role" /> entities.
        /// </summary>
        public IQueryable<Role> RoleSet
        {
            get { return CreateQuery<Role>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.RolePrivileges" /> entities.
        /// </summary>
        public IQueryable<RolePrivileges> RolePrivilegesSet
        {
            get { return CreateQuery<RolePrivileges>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.RoleTemplatePrivileges" /> entities.
        /// </summary>
        public IQueryable<RoleTemplatePrivileges> RoleTemplatePrivilegesSet
        {
            get { return CreateQuery<RoleTemplatePrivileges>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.RollupField" /> entities.
        /// </summary>
        public IQueryable<RollupField> RollupFieldSet
        {
            get { return CreateQuery<RollupField>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.SalesLiterature" /> entities.
        /// </summary>
        public IQueryable<SalesLiterature> SalesLiteratureSet
        {
            get { return CreateQuery<SalesLiterature>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.SalesLiteratureItem" /> entities.
        /// </summary>
        public IQueryable<SalesLiteratureItem> SalesLiteratureItemSet
        {
            get { return CreateQuery<SalesLiteratureItem>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.SalesOrder" /> entities.
        /// </summary>
        public IQueryable<SalesOrder> SalesOrderSet
        {
            get { return CreateQuery<SalesOrder>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.SalesOrderDetail" /> entities.
        /// </summary>
        public IQueryable<SalesOrderDetail> SalesOrderDetailSet
        {
            get { return CreateQuery<SalesOrderDetail>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.SavedQuery" /> entities.
        /// </summary>
        public IQueryable<SavedQuery> SavedQuerySet
        {
            get { return CreateQuery<SavedQuery>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.SavedQueryVisualization" /> entities.
        /// </summary>
        public IQueryable<SavedQueryVisualization> SavedQueryVisualizationSet
        {
            get { return CreateQuery<SavedQueryVisualization>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.SdkMessage" /> entities.
        /// </summary>
        public IQueryable<SdkMessage> SdkMessageSet
        {
            get { return CreateQuery<SdkMessage>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.SdkMessageFilter" /> entities.
        /// </summary>
        public IQueryable<SdkMessageFilter> SdkMessageFilterSet
        {
            get { return CreateQuery<SdkMessageFilter>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.SdkMessagePair" /> entities.
        /// </summary>
        public IQueryable<SdkMessagePair> SdkMessagePairSet
        {
            get { return CreateQuery<SdkMessagePair>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.SdkMessageProcessingStep" /> entities.
        /// </summary>
        public IQueryable<SdkMessageProcessingStep> SdkMessageProcessingStepSet
        {
            get { return CreateQuery<SdkMessageProcessingStep>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.SdkMessageProcessingStepImage" />
        ///     entities.
        /// </summary>
        public IQueryable<SdkMessageProcessingStepImage> SdkMessageProcessingStepImageSet
        {
            get { return CreateQuery<SdkMessageProcessingStepImage>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all
        ///     <see cref="Xrm.Framework.CI.Common.Entities.SdkMessageProcessingStepSecureConfig" /> entities.
        /// </summary>
        public IQueryable<SdkMessageProcessingStepSecureConfig> SdkMessageProcessingStepSecureConfigSet
        {
            get { return CreateQuery<SdkMessageProcessingStepSecureConfig>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.SdkMessageRequest" /> entities.
        /// </summary>
        public IQueryable<SdkMessageRequest> SdkMessageRequestSet
        {
            get { return CreateQuery<SdkMessageRequest>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.SdkMessageRequestField" /> entities.
        /// </summary>
        public IQueryable<SdkMessageRequestField> SdkMessageRequestFieldSet
        {
            get { return CreateQuery<SdkMessageRequestField>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.SdkMessageResponse" /> entities.
        /// </summary>
        public IQueryable<SdkMessageResponse> SdkMessageResponseSet
        {
            get { return CreateQuery<SdkMessageResponse>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.SdkMessageResponseField" /> entities.
        /// </summary>
        public IQueryable<SdkMessageResponseField> SdkMessageResponseFieldSet
        {
            get { return CreateQuery<SdkMessageResponseField>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.SemiAnnualFiscalCalendar" /> entities.
        /// </summary>
        public IQueryable<SemiAnnualFiscalCalendar> SemiAnnualFiscalCalendarSet
        {
            get { return CreateQuery<SemiAnnualFiscalCalendar>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Service" /> entities.
        /// </summary>
        public IQueryable<Service> ServiceSet
        {
            get { return CreateQuery<Service>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ServiceAppointment" /> entities.
        /// </summary>
        public IQueryable<ServiceAppointment> ServiceAppointmentSet
        {
            get { return CreateQuery<ServiceAppointment>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ServiceContractContacts" /> entities.
        /// </summary>
        public IQueryable<ServiceContractContacts> ServiceContractContactsSet
        {
            get { return CreateQuery<ServiceContractContacts>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.ServiceEndpoint" /> entities.
        /// </summary>
        public IQueryable<ServiceEndpoint> ServiceEndpointSet
        {
            get { return CreateQuery<ServiceEndpoint>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.SharePointDocumentLocation" />
        ///     entities.
        /// </summary>
        public IQueryable<SharePointDocumentLocation> SharePointDocumentLocationSet
        {
            get { return CreateQuery<SharePointDocumentLocation>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.SharePointSite" /> entities.
        /// </summary>
        public IQueryable<SharePointSite> SharePointSiteSet
        {
            get { return CreateQuery<SharePointSite>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Site" /> entities.
        /// </summary>
        public IQueryable<Site> SiteSet
        {
            get { return CreateQuery<Site>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.SiteMap" /> entities.
        /// </summary>
        public IQueryable<SiteMap> SiteMapSet
        {
            get { return CreateQuery<SiteMap>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Solution" /> entities.
        /// </summary>
        public IQueryable<Solution> SolutionSet
        {
            get { return CreateQuery<Solution>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.SolutionComponent" /> entities.
        /// </summary>
        public IQueryable<SolutionComponent> SolutionComponentSet
        {
            get { return CreateQuery<SolutionComponent>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Subject" /> entities.
        /// </summary>
        public IQueryable<Subject> SubjectSet
        {
            get { return CreateQuery<Subject>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.SubscriptionManuallyTrackedObject" />
        ///     entities.
        /// </summary>
        public IQueryable<SubscriptionManuallyTrackedObject> SubscriptionManuallyTrackedObjectSet
        {
            get { return CreateQuery<SubscriptionManuallyTrackedObject>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.SystemForm" /> entities.
        /// </summary>
        public IQueryable<SystemForm> SystemFormSet
        {
            get { return CreateQuery<SystemForm>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.SystemUser" /> entities.
        /// </summary>
        public IQueryable<SystemUser> SystemUserSet
        {
            get { return CreateQuery<SystemUser>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.SystemUserLicenses" /> entities.
        /// </summary>
        public IQueryable<SystemUserLicenses> SystemUserLicensesSet
        {
            get { return CreateQuery<SystemUserLicenses>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.SystemUserProfiles" /> entities.
        /// </summary>
        public IQueryable<SystemUserProfiles> SystemUserProfilesSet
        {
            get { return CreateQuery<SystemUserProfiles>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.SystemUserRoles" /> entities.
        /// </summary>
        public IQueryable<SystemUserRoles> SystemUserRolesSet
        {
            get { return CreateQuery<SystemUserRoles>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Task" /> entities.
        /// </summary>
        public IQueryable<Task> TaskSet
        {
            get { return CreateQuery<Task>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Team" /> entities.
        /// </summary>
        public IQueryable<Team> TeamSet
        {
            get { return CreateQuery<Team>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.TeamMembership" /> entities.
        /// </summary>
        public IQueryable<TeamMembership> TeamMembershipSet
        {
            get { return CreateQuery<TeamMembership>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.TeamProfiles" /> entities.
        /// </summary>
        public IQueryable<TeamProfiles> TeamProfilesSet
        {
            get { return CreateQuery<TeamProfiles>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.TeamRoles" /> entities.
        /// </summary>
        public IQueryable<TeamRoles> TeamRolesSet
        {
            get { return CreateQuery<TeamRoles>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.TeamTemplate" /> entities.
        /// </summary>
        public IQueryable<TeamTemplate> TeamTemplateSet
        {
            get { return CreateQuery<TeamTemplate>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Template" /> entities.
        /// </summary>
        public IQueryable<Template> TemplateSet
        {
            get { return CreateQuery<Template>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Territory" /> entities.
        /// </summary>
        public IQueryable<Territory> TerritorySet
        {
            get { return CreateQuery<Territory>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.TimeZoneDefinition" /> entities.
        /// </summary>
        public IQueryable<TimeZoneDefinition> TimeZoneDefinitionSet
        {
            get { return CreateQuery<TimeZoneDefinition>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.TimeZoneLocalizedName" /> entities.
        /// </summary>
        public IQueryable<TimeZoneLocalizedName> TimeZoneLocalizedNameSet
        {
            get { return CreateQuery<TimeZoneLocalizedName>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.TimeZoneRule" /> entities.
        /// </summary>
        public IQueryable<TimeZoneRule> TimeZoneRuleSet
        {
            get { return CreateQuery<TimeZoneRule>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.TraceLog" /> entities.
        /// </summary>
        public IQueryable<TraceLog> TraceLogSet
        {
            get { return CreateQuery<TraceLog>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.TransactionCurrency" /> entities.
        /// </summary>
        public IQueryable<TransactionCurrency> TransactionCurrencySet
        {
            get { return CreateQuery<TransactionCurrency>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.TransformationMapping" /> entities.
        /// </summary>
        public IQueryable<TransformationMapping> TransformationMappingSet
        {
            get { return CreateQuery<TransformationMapping>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.TransformationParameterMapping" />
        ///     entities.
        /// </summary>
        public IQueryable<TransformationParameterMapping> TransformationParameterMappingSet
        {
            get { return CreateQuery<TransformationParameterMapping>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.UoM" /> entities.
        /// </summary>
        public IQueryable<UoM> UoMSet
        {
            get { return CreateQuery<UoM>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.UoMSchedule" /> entities.
        /// </summary>
        public IQueryable<UoMSchedule> UoMScheduleSet
        {
            get { return CreateQuery<UoMSchedule>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.UserEntityInstanceData" /> entities.
        /// </summary>
        public IQueryable<UserEntityInstanceData> UserEntityInstanceDataSet
        {
            get { return CreateQuery<UserEntityInstanceData>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.UserEntityUISettings" /> entities.
        /// </summary>
        public IQueryable<UserEntityUISettings> UserEntityUISettingsSet
        {
            get { return CreateQuery<UserEntityUISettings>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.UserForm" /> entities.
        /// </summary>
        public IQueryable<UserForm> UserFormSet
        {
            get { return CreateQuery<UserForm>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.UserQuery" /> entities.
        /// </summary>
        public IQueryable<UserQuery> UserQuerySet
        {
            get { return CreateQuery<UserQuery>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.UserQueryVisualization" /> entities.
        /// </summary>
        public IQueryable<UserQueryVisualization> UserQueryVisualizationSet
        {
            get { return CreateQuery<UserQueryVisualization>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.UserSettings" /> entities.
        /// </summary>
        public IQueryable<UserSettings> UserSettingsSet
        {
            get { return CreateQuery<UserSettings>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.WebResource" /> entities.
        /// </summary>
        public IQueryable<WebResource> WebResourceSet
        {
            get { return CreateQuery<WebResource>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.Workflow" /> entities.
        /// </summary>
        public IQueryable<Workflow> WorkflowSet
        {
            get { return CreateQuery<Workflow>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.WorkflowDependency" /> entities.
        /// </summary>
        public IQueryable<WorkflowDependency> WorkflowDependencySet
        {
            get { return CreateQuery<WorkflowDependency>(); }
        }

        /// <summary>
        ///     Gets a binding to the set of all <see cref="Xrm.Framework.CI.Common.Entities.WorkflowLog" /> entities.
        /// </summary>
        public IQueryable<WorkflowLog> WorkflowLogSet
        {
            get { return CreateQuery<WorkflowLog>(); }
        }
    }
}