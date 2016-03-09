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
    ///     Announcement associated with an organization.
    /// </summary>
    [DataContract]
    [EntityLogicalName("businessunitnewsarticle")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class BusinessUnitNewsArticle : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "businessunitnewsarticle";

        public const int EntityTypeCode = 132;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public BusinessUnitNewsArticle() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Date and time for the announcement to become active.
        /// </summary>
        [AttributeLogicalName("activeon")]
        public DateTime? ActiveOn
        {
            get { return GetAttributeValue<DateTime?>("activeon"); }
            set
            {
                OnPropertyChanging("ActiveOn");
                SetAttributeValue("activeon", value);
                OnPropertyChanged("ActiveOn");
            }
        }

        /// <summary>
        ///     Date and time of the last day the announcement is active.
        /// </summary>
        [AttributeLogicalName("activeuntil")]
        public DateTime? ActiveUntil
        {
            get { return GetAttributeValue<DateTime?>("activeuntil"); }
            set
            {
                OnPropertyChanging("ActiveUntil");
                SetAttributeValue("activeuntil", value);
                OnPropertyChanged("ActiveUntil");
            }
        }

        /// <summary>
        ///     Title of the announcement.
        /// </summary>
        [AttributeLogicalName("articletitle")]
        public string ArticleTitle
        {
            get { return GetAttributeValue<string>("articletitle"); }
            set
            {
                OnPropertyChanging("ArticleTitle");
                SetAttributeValue("articletitle", value);
                OnPropertyChanged("ArticleTitle");
            }
        }

        /// <summary>
        ///     Type of announcement.
        /// </summary>
        [AttributeLogicalName("articletypecode")]
        public OptionSetValue ArticleTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("articletypecode"); }
            set
            {
                OnPropertyChanging("ArticleTypeCode");
                SetAttributeValue("articletypecode", value);
                OnPropertyChanged("ArticleTypeCode");
            }
        }

        /// <summary>
        ///     URL for the Website on which the announcement is located.
        /// </summary>
        [AttributeLogicalName("articleurl")]
        public string ArticleUrl
        {
            get { return GetAttributeValue<string>("articleurl"); }
            set
            {
                OnPropertyChanging("ArticleUrl");
                SetAttributeValue("articleurl", value);
                OnPropertyChanged("ArticleUrl");
            }
        }

        /// <summary>
        ///     Unique identifier of the announcement.
        /// </summary>
        [AttributeLogicalName("businessunitnewsarticleid")]
        public Guid? BusinessUnitNewsArticleId
        {
            get { return GetAttributeValue<Guid?>("businessunitnewsarticleid"); }
            set
            {
                OnPropertyChanging("BusinessUnitNewsArticleId");
                SetAttributeValue("businessunitnewsarticleid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("BusinessUnitNewsArticleId");
            }
        }

        [AttributeLogicalName("businessunitnewsarticleid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { BusinessUnitNewsArticleId = value; }
        }

        /// <summary>
        ///     Unique identifier of the user who created the announcement.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the announcement was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the businessunitnewsarticle.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
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
        ///     Unique identifier of the user who last modified the announcement.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the announcement was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the businessunitnewsarticle.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Text for the announcement.
        /// </summary>
        [AttributeLogicalName("newsarticle")]
        public string NewsArticle
        {
            get { return GetAttributeValue<string>("newsarticle"); }
            set
            {
                OnPropertyChanging("NewsArticle");
                SetAttributeValue("newsarticle", value);
                OnPropertyChanged("NewsArticle");
            }
        }

        /// <summary>
        ///     Unique identifier of the organization associated with the announcement.
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
        ///     Information about whether to show the announcement on the Website home page.
        /// </summary>
        [AttributeLogicalName("showonhomepage")]
        public bool? ShowOnHomepage
        {
            get { return GetAttributeValue<bool?>("showonhomepage"); }
            set
            {
                OnPropertyChanging("ShowOnHomepage");
                SetAttributeValue("showonhomepage", value);
                OnPropertyChanged("ShowOnHomepage");
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
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N BusinessUnitNewsArticle_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("BusinessUnitNewsArticle_AsyncOperations")]
        public IEnumerable<AsyncOperation> BusinessUnitNewsArticle_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("BusinessUnitNewsArticle_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("BusinessUnitNewsArticle_AsyncOperations");
                SetRelatedEntities("BusinessUnitNewsArticle_AsyncOperations", null, value);
                OnPropertyChanged("BusinessUnitNewsArticle_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N BusinessUnitNewsArticle_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("BusinessUnitNewsArticle_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> BusinessUnitNewsArticle_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("BusinessUnitNewsArticle_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("BusinessUnitNewsArticle_BulkDeleteFailures");
                SetRelatedEntities("BusinessUnitNewsArticle_BulkDeleteFailures", null, value);
                OnPropertyChanged("BusinessUnitNewsArticle_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N BusinessUnitNewsArticle_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("BusinessUnitNewsArticle_ProcessSessions")]
        public IEnumerable<ProcessSession> BusinessUnitNewsArticle_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("BusinessUnitNewsArticle_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("BusinessUnitNewsArticle_ProcessSessions");
                SetRelatedEntities("BusinessUnitNewsArticle_ProcessSessions", null, value);
                OnPropertyChanged("BusinessUnitNewsArticle_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_businessunitnewsarticle
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_businessunitnewsarticle")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_businessunitnewsarticle
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_businessunitnewsarticle", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_businessunitnewsarticle");
                SetRelatedEntities("userentityinstancedata_businessunitnewsarticle", null, value);
                OnPropertyChanged("userentityinstancedata_businessunitnewsarticle");
            }
        }

        /// <summary>
        ///     N:1 lk_businessunitnewsarticle_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_businessunitnewsarticle_createdonbehalfby")]
        public SystemUser lk_businessunitnewsarticle_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_businessunitnewsarticle_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_businessunitnewsarticle_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_businessunitnewsarticle_modifiedonbehalfby")]
        public SystemUser lk_businessunitnewsarticle_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_businessunitnewsarticle_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_businessunitnewsarticlebase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_businessunitnewsarticlebase_createdby")]
        public SystemUser lk_businessunitnewsarticlebase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_businessunitnewsarticlebase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_businessunitnewsarticlebase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_businessunitnewsarticlebase_modifiedby")]
        public SystemUser lk_businessunitnewsarticlebase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_businessunitnewsarticlebase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 organization_business_unit_news_articles
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_business_unit_news_articles")]
        public Organization organization_business_unit_news_articles
        {
            get { return GetRelatedEntity<Organization>("organization_business_unit_news_articles", null); }
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