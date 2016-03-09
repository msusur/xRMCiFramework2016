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
    ///     An activity feed post.
    /// </summary>
    [DataContract]
    [EntityLogicalName("post")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Post : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "post";

        public const int EntityTypeCode = 8000;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Post() :
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
        ///     Unique identifier of the user who modified the record.
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
        ///     Unique identifier of the delegate user who modified the record.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the organization associated with the solution.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     Unique identifier for entity instances
        /// </summary>
        [AttributeLogicalName("postid")]
        public Guid? PostId
        {
            get { return GetAttributeValue<Guid?>("postid"); }
            set
            {
                OnPropertyChanging("PostId");
                SetAttributeValue("postid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("PostId");
            }
        }

        [AttributeLogicalName("postid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { PostId = value; }
        }

        /// <summary>
        ///     Choose the parent record for the post to identify the customer, opportunity, case, or other record that the post
        ///     most closely relates to.
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        public EntityReference RegardingObjectId
        {
            get { return GetAttributeValue<EntityReference>("regardingobjectid"); }
            set
            {
                OnPropertyChanging("RegardingObjectId");
                SetAttributeValue("regardingobjectid", value);
                OnPropertyChanged("RegardingObjectId");
            }
        }

        /// <summary>
        ///     Unique identifier of the user or team who owns the regarding object.
        /// </summary>
        [AttributeLogicalName("regardingobjectownerid")]
        public EntityReference RegardingObjectOwnerId
        {
            get { return GetAttributeValue<EntityReference>("regardingobjectownerid"); }
        }

        /// <summary>
        ///     Unique identifier of the business unit that owns the regarding object.
        /// </summary>
        [AttributeLogicalName("regardingobjectowningbusinessunit")]
        public EntityReference RegardingObjectOwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("regardingobjectowningbusinessunit"); }
        }

        /// <summary>
        ///     Select whether the post was created manually or automatically.
        /// </summary>
        [AttributeLogicalName("source")]
        public OptionSetValue Source
        {
            get { return GetAttributeValue<OptionSetValue>("source"); }
            set
            {
                OnPropertyChanging("Source");
                SetAttributeValue("source", value);
                OnPropertyChanged("Source");
            }
        }

        /// <summary>
        ///     Shows the text of a post. If this is a manual post, it appears in plain text. If this is an auto post, it appears
        ///     in XML.
        /// </summary>
        [AttributeLogicalName("text")]
        public string Text
        {
            get { return GetAttributeValue<string>("text"); }
            set
            {
                OnPropertyChanging("Text");
                SetAttributeValue("text", value);
                OnPropertyChanged("Text");
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
        ///     Select the post type.
        /// </summary>
        [AttributeLogicalName("type")]
        public OptionSetValue Type
        {
            get { return GetAttributeValue<OptionSetValue>("type"); }
            set
            {
                OnPropertyChanging("Type");
                SetAttributeValue("type", value);
                OnPropertyChanged("Type");
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
        ///     1:N post_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("post_AsyncOperations")]
        public IEnumerable<AsyncOperation> post_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("post_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("post_AsyncOperations");
                SetRelatedEntities("post_AsyncOperations", null, value);
                OnPropertyChanged("post_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N post_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("post_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> post_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("post_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("post_BulkDeleteFailures");
                SetRelatedEntities("post_BulkDeleteFailures", null, value);
                OnPropertyChanged("post_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N Post_Comments
        /// </summary>
        [RelationshipSchemaName("Post_Comments")]
        public IEnumerable<PostComment> Post_Comments
        {
            get { return GetRelatedEntities<PostComment>("Post_Comments", null); }
            set
            {
                OnPropertyChanging("Post_Comments");
                SetRelatedEntities("Post_Comments", null, value);
                OnPropertyChanged("Post_Comments");
            }
        }

        /// <summary>
        ///     1:N Post_Likes
        /// </summary>
        [RelationshipSchemaName("Post_Likes")]
        public IEnumerable<PostLike> Post_Likes
        {
            get { return GetRelatedEntities<PostLike>("Post_Likes", null); }
            set
            {
                OnPropertyChanging("Post_Likes");
                SetRelatedEntities("Post_Likes", null, value);
                OnPropertyChanged("Post_Likes");
            }
        }

        /// <summary>
        ///     N:1 lk_post_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_post_createdby")]
        public SystemUser lk_post_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_post_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_post_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_post_createdonbehalfby")]
        public SystemUser lk_post_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_post_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_post_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_post_modifiedby")]
        public SystemUser lk_post_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_post_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_post_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_post_modifiedonbehalfby")]
        public SystemUser lk_post_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_post_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 organization_post
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_post")]
        public Organization organization_post
        {
            get { return GetRelatedEntity<Organization>("organization_post", null); }
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