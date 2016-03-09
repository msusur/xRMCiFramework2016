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
    ///     Comment on a knowledge base article.
    /// </summary>
    [DataContract]
    [EntityLogicalName("kbarticlecomment")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class KbArticleComment : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "kbarticlecomment";

        public const int EntityTypeCode = 1082;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public KbArticleComment() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Comment text for the knowledge base article.
        /// </summary>
        [AttributeLogicalName("commenttext")]
        public string CommentText
        {
            get { return GetAttributeValue<string>("commenttext"); }
            set
            {
                OnPropertyChanging("CommentText");
                SetAttributeValue("commenttext", value);
                OnPropertyChanged("CommentText");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the knowledge base article comment.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the knowledge base article comment was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the kbarticlecomment.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the knowledge base article comment.
        /// </summary>
        [AttributeLogicalName("kbarticlecommentid")]
        public Guid? KbArticleCommentId
        {
            get { return GetAttributeValue<Guid?>("kbarticlecommentid"); }
            set
            {
                OnPropertyChanging("KbArticleCommentId");
                SetAttributeValue("kbarticlecommentid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("KbArticleCommentId");
            }
        }

        [AttributeLogicalName("kbarticlecommentid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { KbArticleCommentId = value; }
        }

        /// <summary>
        ///     Unique identifier of the knowledge base article to which the comment applies.
        /// </summary>
        [AttributeLogicalName("kbarticleid")]
        public EntityReference KbArticleId
        {
            get { return GetAttributeValue<EntityReference>("kbarticleid"); }
            set
            {
                OnPropertyChanging("KbArticleId");
                SetAttributeValue("kbarticleid", value);
                OnPropertyChanged("KbArticleId");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the knowledge base article comment.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the knowledge base article comment was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the kbarticlecomment.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the organization with which the article comment is associated.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public Guid? OrganizationId
        {
            get { return GetAttributeValue<Guid?>("organizationid"); }
        }

        /// <summary>
        ///     Title of the knowledge base article comment.
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
        ///     1:N KbArticleComment_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("KbArticleComment_AsyncOperations")]
        public IEnumerable<AsyncOperation> KbArticleComment_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("KbArticleComment_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("KbArticleComment_AsyncOperations");
                SetRelatedEntities("KbArticleComment_AsyncOperations", null, value);
                OnPropertyChanged("KbArticleComment_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N KbArticleComment_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("KbArticleComment_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> KbArticleComment_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("KbArticleComment_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("KbArticleComment_BulkDeleteFailures");
                SetRelatedEntities("KbArticleComment_BulkDeleteFailures", null, value);
                OnPropertyChanged("KbArticleComment_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N KbArticleComment_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("KbArticleComment_ProcessSessions")]
        public IEnumerable<ProcessSession> KbArticleComment_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("KbArticleComment_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("KbArticleComment_ProcessSessions");
                SetRelatedEntities("KbArticleComment_ProcessSessions", null, value);
                OnPropertyChanged("KbArticleComment_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_kbarticlecomment
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_kbarticlecomment")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_kbarticlecomment
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_kbarticlecomment", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_kbarticlecomment");
                SetRelatedEntities("userentityinstancedata_kbarticlecomment", null, value);
                OnPropertyChanged("userentityinstancedata_kbarticlecomment");
            }
        }

        /// <summary>
        ///     N:1 kbarticle_comments
        /// </summary>
        [AttributeLogicalName("kbarticleid")]
        [RelationshipSchemaName("kbarticle_comments")]
        public KbArticle kbarticle_comments
        {
            get { return GetRelatedEntity<KbArticle>("kbarticle_comments", null); }
            set
            {
                OnPropertyChanging("kbarticle_comments");
                SetRelatedEntity("kbarticle_comments", null, value);
                OnPropertyChanged("kbarticle_comments");
            }
        }

        /// <summary>
        ///     N:1 lk_kbarticlecomment_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_kbarticlecomment_createdonbehalfby")]
        public SystemUser lk_kbarticlecomment_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_kbarticlecomment_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_kbarticlecomment_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_kbarticlecomment_modifiedonbehalfby")]
        public SystemUser lk_kbarticlecomment_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_kbarticlecomment_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_kbarticlecommentbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_kbarticlecommentbase_createdby")]
        public SystemUser lk_kbarticlecommentbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_kbarticlecommentbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_kbarticlecommentbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_kbarticlecommentbase_modifiedby")]
        public SystemUser lk_kbarticlecommentbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_kbarticlecommentbase_modifiedby", null); }
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