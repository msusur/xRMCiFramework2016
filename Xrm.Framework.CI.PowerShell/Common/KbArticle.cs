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
    ///     Structured content that is part of the knowledge base.
    /// </summary>
    [DataContract]
    [EntityLogicalName("kbarticle")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class KbArticle : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "kbarticle";

        public const int EntityTypeCode = 127;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public KbArticle() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Shows the article content and formatting, stored as XML.
        /// </summary>
        [AttributeLogicalName("articlexml")]
        public string ArticleXml
        {
            get { return GetAttributeValue<string>("articlexml"); }
            set
            {
                OnPropertyChanging("ArticleXml");
                SetAttributeValue("articlexml", value);
                OnPropertyChanged("ArticleXml");
            }
        }

        /// <summary>
        ///     Comments regarding the knowledge base article.
        /// </summary>
        [AttributeLogicalName("comments")]
        public string Comments
        {
            get { return GetAttributeValue<string>("comments"); }
            set
            {
                OnPropertyChanging("Comments");
                SetAttributeValue("comments", value);
                OnPropertyChanged("Comments");
            }
        }

        /// <summary>
        ///     Description of the content of the knowledge base article.
        /// </summary>
        [AttributeLogicalName("content")]
        public string Content
        {
            get { return GetAttributeValue<string>("content"); }
        }

        /// <summary>
        ///     Unique identifier of the user who created the knowledge base article.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the knowledge base article was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the article.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Type additional information that describes the knowledge base article.
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
        ///     Shows the ID of the article.
        /// </summary>
        [AttributeLogicalName("kbarticleid")]
        public Guid? KbArticleId
        {
            get { return GetAttributeValue<Guid?>("kbarticleid"); }
            set
            {
                OnPropertyChanging("KbArticleId");
                SetAttributeValue("kbarticleid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("KbArticleId");
            }
        }

        [AttributeLogicalName("kbarticleid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { KbArticleId = value; }
        }

        /// <summary>
        ///     Choose the template that you want to use as a base for creating the new article.
        /// </summary>
        [AttributeLogicalName("kbarticletemplateid")]
        public EntityReference KbArticleTemplateId
        {
            get { return GetAttributeValue<EntityReference>("kbarticletemplateid"); }
            set
            {
                OnPropertyChanging("KbArticleTemplateId");
                SetAttributeValue("kbarticletemplateid", value);
                OnPropertyChanged("KbArticleTemplateId");
            }
        }

        /// <summary>
        ///     Keywords to be used for searches in knowledge base articles.
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
        ///     Select which language the article must be available in. This list is based on the list of language packs that are
        ///     installed in your Microsoft Dynamics CRM environment.
        /// </summary>
        [AttributeLogicalName("languagecode")]
        public int? LanguageCode
        {
            get { return GetAttributeValue<int?>("languagecode"); }
            set
            {
                OnPropertyChanging("LanguageCode");
                SetAttributeValue("languagecode", value);
                OnPropertyChanged("LanguageCode");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the knowledge base article.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the knowledge base article was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the kbarticle.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Knowledge base article number.
        /// </summary>
        [AttributeLogicalName("number")]
        public string Number
        {
            get { return GetAttributeValue<string>("number"); }
        }

        /// <summary>
        ///     Unique identifier of the organization associated with the article.
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
        ///     Shows whether the knowledge base article is in draft, unapproved, or published status. Published articles are
        ///     read-only and can't be edited unless they are unpublished.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public KbArticleState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((KbArticleState) (Enum.ToObject(typeof (KbArticleState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Select the article's status.
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
        ///     Choose the subject of the article to assist with article searches. You can configure subjects under Business
        ///     Management in the Settings area.
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
        ///     Type a subject or descriptive name for the article to assist with article searches.
        /// </summary>
        [AttributeLogicalName("title")]
        public string Title
        {
            get { return GetAttributeValue<string>("title"); }
            set
            {
                OnPropertyChanging("Title");
                SetAttributeValue("title", value);
                OnPropertyChanged("Title");
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
        ///     Title of the knowledge base article.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N KbArticle_Annotation
        /// </summary>
        [RelationshipSchemaName("KbArticle_Annotation")]
        public IEnumerable<Annotation> KbArticle_Annotation
        {
            get { return GetRelatedEntities<Annotation>("KbArticle_Annotation", null); }
            set
            {
                OnPropertyChanging("KbArticle_Annotation");
                SetRelatedEntities("KbArticle_Annotation", null, value);
                OnPropertyChanged("KbArticle_Annotation");
            }
        }

        /// <summary>
        ///     1:N KbArticle_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("KbArticle_AsyncOperations")]
        public IEnumerable<AsyncOperation> KbArticle_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("KbArticle_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("KbArticle_AsyncOperations");
                SetRelatedEntities("KbArticle_AsyncOperations", null, value);
                OnPropertyChanged("KbArticle_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N KbArticle_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("KbArticle_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> KbArticle_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("KbArticle_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("KbArticle_BulkDeleteFailures");
                SetRelatedEntities("KbArticle_BulkDeleteFailures", null, value);
                OnPropertyChanged("KbArticle_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N kbarticle_comments
        /// </summary>
        [RelationshipSchemaName("kbarticle_comments")]
        public IEnumerable<KbArticleComment> kbarticle_comments
        {
            get { return GetRelatedEntities<KbArticleComment>("kbarticle_comments", null); }
            set
            {
                OnPropertyChanging("kbarticle_comments");
                SetRelatedEntities("kbarticle_comments", null, value);
                OnPropertyChanged("kbarticle_comments");
            }
        }

        /// <summary>
        ///     1:N KbArticle_DuplicateBaseRecord
        /// </summary>
        [RelationshipSchemaName("KbArticle_DuplicateBaseRecord")]
        public IEnumerable<DuplicateRecord> KbArticle_DuplicateBaseRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("KbArticle_DuplicateBaseRecord", null); }
            set
            {
                OnPropertyChanging("KbArticle_DuplicateBaseRecord");
                SetRelatedEntities("KbArticle_DuplicateBaseRecord", null, value);
                OnPropertyChanged("KbArticle_DuplicateBaseRecord");
            }
        }

        /// <summary>
        ///     1:N KbArticle_DuplicateMatchingRecord
        /// </summary>
        [RelationshipSchemaName("KbArticle_DuplicateMatchingRecord")]
        public IEnumerable<DuplicateRecord> KbArticle_DuplicateMatchingRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("KbArticle_DuplicateMatchingRecord", null); }
            set
            {
                OnPropertyChanging("KbArticle_DuplicateMatchingRecord");
                SetRelatedEntities("KbArticle_DuplicateMatchingRecord", null, value);
                OnPropertyChanged("KbArticle_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        ///     1:N kbarticle_incidents
        /// </summary>
        [RelationshipSchemaName("kbarticle_incidents")]
        public IEnumerable<Incident> kbarticle_incidents
        {
            get { return GetRelatedEntities<Incident>("kbarticle_incidents", null); }
            set
            {
                OnPropertyChanging("kbarticle_incidents");
                SetRelatedEntities("kbarticle_incidents", null, value);
                OnPropertyChanged("kbarticle_incidents");
            }
        }

        /// <summary>
        ///     1:N kbarticle_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("kbarticle_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> kbarticle_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntities<PrincipalObjectAttributeAccess>("kbarticle_principalobjectattributeaccess",
                    null);
            }
            set
            {
                OnPropertyChanging("kbarticle_principalobjectattributeaccess");
                SetRelatedEntities("kbarticle_principalobjectattributeaccess", null, value);
                OnPropertyChanged("kbarticle_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N KbArticle_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("KbArticle_ProcessSessions")]
        public IEnumerable<ProcessSession> KbArticle_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("KbArticle_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("KbArticle_ProcessSessions");
                SetRelatedEntities("KbArticle_ProcessSessions", null, value);
                OnPropertyChanged("KbArticle_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N KbArticle_SharepointDocumentLocation
        /// </summary>
        [RelationshipSchemaName("KbArticle_SharepointDocumentLocation")]
        public IEnumerable<SharePointDocumentLocation> KbArticle_SharepointDocumentLocation
        {
            get { return GetRelatedEntities<SharePointDocumentLocation>("KbArticle_SharepointDocumentLocation", null); }
            set
            {
                OnPropertyChanging("KbArticle_SharepointDocumentLocation");
                SetRelatedEntities("KbArticle_SharepointDocumentLocation", null, value);
                OnPropertyChanged("KbArticle_SharepointDocumentLocation");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_kbarticle
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_kbarticle")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_kbarticle
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_kbarticle", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_kbarticle");
                SetRelatedEntities("userentityinstancedata_kbarticle", null, value);
                OnPropertyChanged("userentityinstancedata_kbarticle");
            }
        }

        /// <summary>
        ///     N:1 kb_article_template_kb_articles
        /// </summary>
        [AttributeLogicalName("kbarticletemplateid")]
        [RelationshipSchemaName("kb_article_template_kb_articles")]
        public KbArticleTemplate kb_article_template_kb_articles
        {
            get { return GetRelatedEntity<KbArticleTemplate>("kb_article_template_kb_articles", null); }
            set
            {
                OnPropertyChanging("kb_article_template_kb_articles");
                SetRelatedEntity("kb_article_template_kb_articles", null, value);
                OnPropertyChanged("kb_article_template_kb_articles");
            }
        }

        /// <summary>
        ///     N:1 lk_kbarticle_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_kbarticle_createdonbehalfby")]
        public SystemUser lk_kbarticle_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_kbarticle_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_kbarticle_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_kbarticle_modifiedonbehalfby")]
        public SystemUser lk_kbarticle_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_kbarticle_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_kbarticlebase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_kbarticlebase_createdby")]
        public SystemUser lk_kbarticlebase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_kbarticlebase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_kbarticlebase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_kbarticlebase_modifiedby")]
        public SystemUser lk_kbarticlebase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_kbarticlebase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 organization_kb_articles
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_kb_articles")]
        public Organization organization_kb_articles
        {
            get { return GetRelatedEntity<Organization>("organization_kb_articles", null); }
        }

        /// <summary>
        ///     N:1 subject_kb_articles
        /// </summary>
        [AttributeLogicalName("subjectid")]
        [RelationshipSchemaName("subject_kb_articles")]
        public Subject subject_kb_articles
        {
            get { return GetRelatedEntity<Subject>("subject_kb_articles", null); }
            set
            {
                OnPropertyChanging("subject_kb_articles");
                SetRelatedEntity("subject_kb_articles", null, value);
                OnPropertyChanged("subject_kb_articles");
            }
        }

        /// <summary>
        ///     N:1 TransactionCurrency_KbArticle
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("TransactionCurrency_KbArticle")]
        public TransactionCurrency TransactionCurrency_KbArticle
        {
            get { return GetRelatedEntity<TransactionCurrency>("TransactionCurrency_KbArticle", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_KbArticle");
                SetRelatedEntity("TransactionCurrency_KbArticle", null, value);
                OnPropertyChanged("TransactionCurrency_KbArticle");
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