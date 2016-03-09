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
    ///     Template for a knowledge base article that contains the standard attributes of an article.
    /// </summary>
    [DataContract]
    [EntityLogicalName("kbarticletemplate")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class KbArticleTemplate : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "kbarticletemplate";

        public const int EntityTypeCode = 1016;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public KbArticleTemplate() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("componentstate")]
        public OptionSetValue ComponentState
        {
            get { return GetAttributeValue<OptionSetValue>("componentstate"); }
        }

        /// <summary>
        ///     Unique identifier of the user who created the knowledge base article template.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the knowledge base article template was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the kbarticletemplate.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Description of the knowledge base article template.
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
        ///     XML format of the knowledge base article template.
        /// </summary>
        [AttributeLogicalName("formatxml")]
        public string FormatXml
        {
            get { return GetAttributeValue<string>("formatxml"); }
            set
            {
                OnPropertyChanging("FormatXml");
                SetAttributeValue("formatxml", value);
                OnPropertyChanged("FormatXml");
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
        ///     Version in which the form is introduced.
        /// </summary>
        [AttributeLogicalName("introducedversion")]
        public string IntroducedVersion
        {
            get { return GetAttributeValue<string>("introducedversion"); }
            set
            {
                OnPropertyChanging("IntroducedVersion");
                SetAttributeValue("introducedversion", value);
                OnPropertyChanged("IntroducedVersion");
            }
        }

        /// <summary>
        ///     Information about whether the knowledge base article is active.
        /// </summary>
        [AttributeLogicalName("isactive")]
        public bool? IsActive
        {
            get { return GetAttributeValue<bool?>("isactive"); }
            set
            {
                OnPropertyChanging("IsActive");
                SetAttributeValue("isactive", value);
                OnPropertyChanged("IsActive");
            }
        }

        /// <summary>
        ///     Information that specifies whether this component can be customized.
        /// </summary>
        [AttributeLogicalName("iscustomizable")]
        public BooleanManagedProperty IsCustomizable
        {
            get { return GetAttributeValue<BooleanManagedProperty>("iscustomizable"); }
            set
            {
                OnPropertyChanging("IsCustomizable");
                SetAttributeValue("iscustomizable", value);
                OnPropertyChanged("IsCustomizable");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("ismanaged")]
        public bool? IsManaged
        {
            get { return GetAttributeValue<bool?>("ismanaged"); }
        }

        /// <summary>
        ///     Unique identifier of the knowledge base article template.
        /// </summary>
        [AttributeLogicalName("kbarticletemplateid")]
        public Guid? KbArticleTemplateId
        {
            get { return GetAttributeValue<Guid?>("kbarticletemplateid"); }
            set
            {
                OnPropertyChanging("KbArticleTemplateId");
                SetAttributeValue("kbarticletemplateid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("KbArticleTemplateId");
            }
        }

        [AttributeLogicalName("kbarticletemplateid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { KbArticleTemplateId = value; }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("kbarticletemplateidunique")]
        public Guid? KbArticleTemplateIdUnique
        {
            get { return GetAttributeValue<Guid?>("kbarticletemplateidunique"); }
        }

        /// <summary>
        ///     Language of the Article Template
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
        ///     Unique identifier of the user who last modified the knowledge base article template.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the knowledge base article template was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the kbarticletemplate.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the organization associated with the template.
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
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("overwritetime")]
        public DateTime? OverwriteTime
        {
            get { return GetAttributeValue<DateTime?>("overwritetime"); }
        }

        /// <summary>
        ///     Unique identifier of the associated solution.
        /// </summary>
        [AttributeLogicalName("solutionid")]
        public Guid? SolutionId
        {
            get { return GetAttributeValue<Guid?>("solutionid"); }
        }

        /// <summary>
        ///     XML structure of the knowledge base article.
        /// </summary>
        [AttributeLogicalName("structurexml")]
        public string StructureXml
        {
            get { return GetAttributeValue<string>("structurexml"); }
            set
            {
                OnPropertyChanging("StructureXml");
                SetAttributeValue("structurexml", value);
                OnPropertyChanged("StructureXml");
            }
        }

        /// <summary>
        ///     Title of the knowledge base article template.
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
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N kb_article_template_kb_articles
        /// </summary>
        [RelationshipSchemaName("kb_article_template_kb_articles")]
        public IEnumerable<KbArticle> kb_article_template_kb_articles
        {
            get { return GetRelatedEntities<KbArticle>("kb_article_template_kb_articles", null); }
            set
            {
                OnPropertyChanging("kb_article_template_kb_articles");
                SetRelatedEntities("kb_article_template_kb_articles", null, value);
                OnPropertyChanged("kb_article_template_kb_articles");
            }
        }

        /// <summary>
        ///     1:N KbArticleTemplate_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("KbArticleTemplate_AsyncOperations")]
        public IEnumerable<AsyncOperation> KbArticleTemplate_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("KbArticleTemplate_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("KbArticleTemplate_AsyncOperations");
                SetRelatedEntities("KbArticleTemplate_AsyncOperations", null, value);
                OnPropertyChanged("KbArticleTemplate_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N KbArticleTemplate_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("KbArticleTemplate_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> KbArticleTemplate_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("KbArticleTemplate_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("KbArticleTemplate_BulkDeleteFailures");
                SetRelatedEntities("KbArticleTemplate_BulkDeleteFailures", null, value);
                OnPropertyChanged("KbArticleTemplate_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N KbArticleTemplate_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("KbArticleTemplate_ProcessSessions")]
        public IEnumerable<ProcessSession> KbArticleTemplate_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("KbArticleTemplate_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("KbArticleTemplate_ProcessSessions");
                SetRelatedEntities("KbArticleTemplate_ProcessSessions", null, value);
                OnPropertyChanged("KbArticleTemplate_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_kbarticletemplate
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_kbarticletemplate")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_kbarticletemplate
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_kbarticletemplate", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_kbarticletemplate");
                SetRelatedEntities("userentityinstancedata_kbarticletemplate", null, value);
                OnPropertyChanged("userentityinstancedata_kbarticletemplate");
            }
        }

        /// <summary>
        ///     N:1 lk_kbarticletemplate_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_kbarticletemplate_createdonbehalfby")]
        public SystemUser lk_kbarticletemplate_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_kbarticletemplate_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_kbarticletemplate_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_kbarticletemplate_modifiedonbehalfby")]
        public SystemUser lk_kbarticletemplate_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_kbarticletemplate_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_kbarticletemplatebase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_kbarticletemplatebase_createdby")]
        public SystemUser lk_kbarticletemplatebase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_kbarticletemplatebase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_kbarticletemplatebase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_kbarticletemplatebase_modifiedby")]
        public SystemUser lk_kbarticletemplatebase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_kbarticletemplatebase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 organization_kb_article_templates
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_kb_article_templates")]
        public Organization organization_kb_article_templates
        {
            get { return GetRelatedEntity<Organization>("organization_kb_article_templates", null); }
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