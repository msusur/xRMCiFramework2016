using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Xrm.Framework.CI.Common.Entities
{
    /// <summary>
    ///     A comment on an activity feed post.
    /// </summary>
    [DataContract]
    [EntityLogicalName("postcomment")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class PostComment : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "postcomment";

        public const int EntityTypeCode = 8005;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public PostComment() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the user who created the record.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the record was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the record.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
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
        ///     Shows the ID of the post comment.
        /// </summary>
        [AttributeLogicalName("postcommentid")]
        public Guid? PostCommentId
        {
            get { return GetAttributeValue<Guid?>("postcommentid"); }
            set
            {
                OnPropertyChanging("PostCommentId");
                SetAttributeValue("postcommentid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("PostCommentId");
            }
        }

        [AttributeLogicalName("postcommentid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { PostCommentId = value; }
        }

        /// <summary>
        ///     Unique identifier of the post with which the comment is associated.
        /// </summary>
        [AttributeLogicalName("postid")]
        public EntityReference PostId
        {
            get { return GetAttributeValue<EntityReference>("postid"); }
            set
            {
                OnPropertyChanging("PostId");
                SetAttributeValue("postid", value);
                OnPropertyChanged("PostId");
            }
        }

        /// <summary>
        ///     Text of the comment.
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
        ///     N:1 lk_postcomment_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_postcomment_createdby")]
        public SystemUser lk_postcomment_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_postcomment_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_postcomment_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_postcomment_createdonbehalfby")]
        public SystemUser lk_postcomment_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_postcomment_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 organization_PostComment
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_PostComment")]
        public Organization organization_PostComment
        {
            get { return GetRelatedEntity<Organization>("organization_PostComment", null); }
        }

        /// <summary>
        ///     N:1 Post_Comments
        /// </summary>
        [AttributeLogicalName("postid")]
        [RelationshipSchemaName("Post_Comments")]
        public Post Post_Comments
        {
            get { return GetRelatedEntity<Post>("Post_Comments", null); }
            set
            {
                OnPropertyChanging("Post_Comments");
                SetRelatedEntity("Post_Comments", null, value);
                OnPropertyChanged("Post_Comments");
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