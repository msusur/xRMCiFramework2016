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
    ///     Storage of sales literature, which may contain one or more documents.
    /// </summary>
    [DataContract]
    [EntityLogicalName("salesliterature")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class SalesLiterature : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "salesliterature";

        public const int EntityTypeCode = 1038;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public SalesLiterature() :
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
        ///     Type additional information to describe the sales literature, such as the intended audience or primary messages.
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
        ///     Choose the user who is responsible for maintaining or updating the sales literature.
        /// </summary>
        [AttributeLogicalName("employeecontactid")]
        public EntityReference EmployeeContactId
        {
            get { return GetAttributeValue<EntityReference>("employeecontactid"); }
            set
            {
                OnPropertyChanging("EmployeeContactId");
                SetAttributeValue("employeecontactid", value);
                OnPropertyChanged("EmployeeContactId");
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
        ///     Enter the expiration date or last day the sales literature can be distributed.
        /// </summary>
        [AttributeLogicalName("expirationdate")]
        public DateTime? ExpirationDate
        {
            get { return GetAttributeValue<DateTime?>("expirationdate"); }
            set
            {
                OnPropertyChanging("ExpirationDate");
                SetAttributeValue("expirationdate", value);
                OnPropertyChanged("ExpirationDate");
            }
        }

        /// <summary>
        ///     Tells whether the sales literature has one or more attachments.
        /// </summary>
        [AttributeLogicalName("hasattachments")]
        public bool? HasAttachments
        {
            get { return GetAttributeValue<bool?>("hasattachments"); }
            set
            {
                OnPropertyChanging("HasAttachments");
                SetAttributeValue("hasattachments", value);
                OnPropertyChanged("HasAttachments");
            }
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
        ///     Select whether the sales literature can be distributed to prospects and customers or is for internal use only.
        /// </summary>
        [AttributeLogicalName("iscustomerviewable")]
        public bool? IsCustomerViewable
        {
            get { return GetAttributeValue<bool?>("iscustomerviewable"); }
            set
            {
                OnPropertyChanging("IsCustomerViewable");
                SetAttributeValue("iscustomerviewable", value);
                OnPropertyChanged("IsCustomerViewable");
            }
        }

        /// <summary>
        ///     Type one or more topics or keywords that can be used to search for the sales literature.
        /// </summary>
        [AttributeLogicalName("keywords")]
        public string KeyWords
        {
            get { return GetAttributeValue<string>("keywords"); }
            set
            {
                OnPropertyChanging("KeyWords");
                SetAttributeValue("keywords", value);
                OnPropertyChanged("KeyWords");
            }
        }

        /// <summary>
        ///     Select a category or type to help others identify the intended use of the sales literature.
        /// </summary>
        [AttributeLogicalName("literaturetypecode")]
        public OptionSetValue LiteratureTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("literaturetypecode"); }
            set
            {
                OnPropertyChanging("LiteratureTypeCode");
                SetAttributeValue("literaturetypecode", value);
                OnPropertyChanged("LiteratureTypeCode");
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
        ///     Type a descriptive title for the sales literature.
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
        ///     Choose the ID of the organization that the record is associated with.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
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
        ///     Unique identifier of the sales literature.
        /// </summary>
        [AttributeLogicalName("salesliteratureid")]
        public Guid? SalesLiteratureId
        {
            get { return GetAttributeValue<Guid?>("salesliteratureid"); }
            set
            {
                OnPropertyChanging("SalesLiteratureId");
                SetAttributeValue("salesliteratureid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("SalesLiteratureId");
            }
        }

        [AttributeLogicalName("salesliteratureid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { SalesLiteratureId = value; }
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
        ///     Choose the subject for the sales literature to relate the item to a product or business group. Administrators can
        ///     configure subjects under Business Management in the Settings area.
        /// </summary>
        [AttributeLogicalName("subjectid")]
        public EntityReference SubjectId
        {
            get { return GetAttributeValue<EntityReference>("subjectid"); }
            set
            {
                OnPropertyChanging("SubjectId");
                SetAttributeValue("subjectid", value);
                OnPropertyChanged("SubjectId");
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
        ///     Version number of the sales literature.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N sales_literature_items
        /// </summary>
        [RelationshipSchemaName("sales_literature_items")]
        public IEnumerable<SalesLiteratureItem> sales_literature_items
        {
            get { return GetRelatedEntities<SalesLiteratureItem>("sales_literature_items", null); }
            set
            {
                OnPropertyChanging("sales_literature_items");
                SetRelatedEntities("sales_literature_items", null, value);
                OnPropertyChanged("sales_literature_items");
            }
        }

        /// <summary>
        ///     1:N SalesLiterature_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("SalesLiterature_AsyncOperations")]
        public IEnumerable<AsyncOperation> SalesLiterature_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("SalesLiterature_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("SalesLiterature_AsyncOperations");
                SetRelatedEntities("SalesLiterature_AsyncOperations", null, value);
                OnPropertyChanged("SalesLiterature_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N SalesLiterature_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("SalesLiterature_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> SalesLiterature_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("SalesLiterature_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("SalesLiterature_BulkDeleteFailures");
                SetRelatedEntities("SalesLiterature_BulkDeleteFailures", null, value);
                OnPropertyChanged("SalesLiterature_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N salesliterature_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("salesliterature_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> salesliterature_principalobjectattributeaccess
        {
            get
            {
                return
                    GetRelatedEntities<PrincipalObjectAttributeAccess>(
                        "salesliterature_principalobjectattributeaccess", null);
            }
            set
            {
                OnPropertyChanging("salesliterature_principalobjectattributeaccess");
                SetRelatedEntities("salesliterature_principalobjectattributeaccess", null, value);
                OnPropertyChanged("salesliterature_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N SalesLiterature_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("SalesLiterature_ProcessSessions")]
        public IEnumerable<ProcessSession> SalesLiterature_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("SalesLiterature_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("SalesLiterature_ProcessSessions");
                SetRelatedEntities("SalesLiterature_ProcessSessions", null, value);
                OnPropertyChanged("SalesLiterature_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N SalesLiterature_SharepointDocumentLocation
        /// </summary>
        [RelationshipSchemaName("SalesLiterature_SharepointDocumentLocation")]
        public IEnumerable<SharePointDocumentLocation> SalesLiterature_SharepointDocumentLocation
        {
            get
            {
                return GetRelatedEntities<SharePointDocumentLocation>("SalesLiterature_SharepointDocumentLocation", null);
            }
            set
            {
                OnPropertyChanging("SalesLiterature_SharepointDocumentLocation");
                SetRelatedEntities("SalesLiterature_SharepointDocumentLocation", null, value);
                OnPropertyChanged("SalesLiterature_SharepointDocumentLocation");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_salesliterature
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_salesliterature")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_salesliterature
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_salesliterature", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_salesliterature");
                SetRelatedEntities("userentityinstancedata_salesliterature", null, value);
                OnPropertyChanged("userentityinstancedata_salesliterature");
            }
        }

        /// <summary>
        ///     N:N campaignactivitysalesliterature_association
        /// </summary>
        [RelationshipSchemaName("campaignactivitysalesliterature_association")]
        public IEnumerable<CampaignActivity> campaignactivitysalesliterature_association
        {
            get { return GetRelatedEntities<CampaignActivity>("campaignactivitysalesliterature_association", null); }
            set
            {
                OnPropertyChanging("campaignactivitysalesliterature_association");
                SetRelatedEntities("campaignactivitysalesliterature_association", null, value);
                OnPropertyChanged("campaignactivitysalesliterature_association");
            }
        }

        /// <summary>
        ///     N:N campaignsalesliterature_association
        /// </summary>
        [RelationshipSchemaName("campaignsalesliterature_association")]
        public IEnumerable<Campaign> campaignsalesliterature_association
        {
            get { return GetRelatedEntities<Campaign>("campaignsalesliterature_association", null); }
            set
            {
                OnPropertyChanging("campaignsalesliterature_association");
                SetRelatedEntities("campaignsalesliterature_association", null, value);
                OnPropertyChanged("campaignsalesliterature_association");
            }
        }

        /// <summary>
        ///     N:N competitorsalesliterature_association
        /// </summary>
        [RelationshipSchemaName("competitorsalesliterature_association")]
        public IEnumerable<Competitor> competitorsalesliterature_association
        {
            get { return GetRelatedEntities<Competitor>("competitorsalesliterature_association", null); }
            set
            {
                OnPropertyChanging("competitorsalesliterature_association");
                SetRelatedEntities("competitorsalesliterature_association", null, value);
                OnPropertyChanged("competitorsalesliterature_association");
            }
        }

        /// <summary>
        ///     N:N productsalesliterature_association
        /// </summary>
        [RelationshipSchemaName("productsalesliterature_association")]
        public IEnumerable<Product> productsalesliterature_association
        {
            get { return GetRelatedEntities<Product>("productsalesliterature_association", null); }
            set
            {
                OnPropertyChanging("productsalesliterature_association");
                SetRelatedEntities("productsalesliterature_association", null, value);
                OnPropertyChanged("productsalesliterature_association");
            }
        }

        /// <summary>
        ///     N:1 lk_salesliterature_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_salesliterature_createdonbehalfby")]
        public SystemUser lk_salesliterature_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_salesliterature_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_salesliterature_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_salesliterature_modifiedonbehalfby")]
        public SystemUser lk_salesliterature_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_salesliterature_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_salesliteraturebase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_salesliteraturebase_createdby")]
        public SystemUser lk_salesliteraturebase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_salesliteraturebase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_salesliteraturebase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_salesliteraturebase_modifiedby")]
        public SystemUser lk_salesliteraturebase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_salesliteraturebase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 organization_sales_literature
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_sales_literature")]
        public Organization organization_sales_literature
        {
            get { return GetRelatedEntity<Organization>("organization_sales_literature", null); }
        }

        /// <summary>
        ///     N:1 processstage_salesliteratures
        /// </summary>
        [AttributeLogicalName("stageid")]
        [RelationshipSchemaName("processstage_salesliteratures")]
        public ProcessStage processstage_salesliteratures
        {
            get { return GetRelatedEntity<ProcessStage>("processstage_salesliteratures", null); }
            set
            {
                OnPropertyChanging("processstage_salesliteratures");
                SetRelatedEntity("processstage_salesliteratures", null, value);
                OnPropertyChanged("processstage_salesliteratures");
            }
        }

        /// <summary>
        ///     N:1 subject_sales_literature
        /// </summary>
        [AttributeLogicalName("subjectid")]
        [RelationshipSchemaName("subject_sales_literature")]
        public Subject subject_sales_literature
        {
            get { return GetRelatedEntity<Subject>("subject_sales_literature", null); }
            set
            {
                OnPropertyChanging("subject_sales_literature");
                SetRelatedEntity("subject_sales_literature", null, value);
                OnPropertyChanged("subject_sales_literature");
            }
        }

        /// <summary>
        ///     N:1 system_user_sales_literature
        /// </summary>
        [AttributeLogicalName("employeecontactid")]
        [RelationshipSchemaName("system_user_sales_literature")]
        public SystemUser system_user_sales_literature
        {
            get { return GetRelatedEntity<SystemUser>("system_user_sales_literature", null); }
            set
            {
                OnPropertyChanging("system_user_sales_literature");
                SetRelatedEntity("system_user_sales_literature", null, value);
                OnPropertyChanged("system_user_sales_literature");
            }
        }

        /// <summary>
        ///     N:1 TransactionCurrency_SalesLiterature
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("TransactionCurrency_SalesLiterature")]
        public TransactionCurrency TransactionCurrency_SalesLiterature
        {
            get { return GetRelatedEntity<TransactionCurrency>("TransactionCurrency_SalesLiterature", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_SalesLiterature");
                SetRelatedEntity("TransactionCurrency_SalesLiterature", null, value);
                OnPropertyChanged("TransactionCurrency_SalesLiterature");
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