using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Xrm.Framework.CI.Common.Entities
{
    /// <summary>
    ///     A like on an activity feed post.
    /// </summary>
    [DataContract]
    [EntityLogicalName("postlike")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class PostLike : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "postlike";

        public const int EntityTypeCode = 8006;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public PostLike() :
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
        ///     Unique identifier of the post with which the like is associated.
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
        ///     Shows the ID of the post like.
        /// </summary>
        [AttributeLogicalName("postlikeid")]
        public Guid? PostLikeId
        {
            get { return GetAttributeValue<Guid?>("postlikeid"); }
            set
            {
                OnPropertyChanging("PostLikeId");
                SetAttributeValue("postlikeid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("PostLikeId");
            }
        }

        [AttributeLogicalName("postlikeid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { PostLikeId = value; }
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
        ///     N:1 lk_postlike_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_postlike_createdby")]
        public SystemUser lk_postlike_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_postlike_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_postlike_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_postlike_createdonbehalfby")]
        public SystemUser lk_postlike_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_postlike_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 organization_postlike
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_postlike")]
        public Organization organization_postlike
        {
            get { return GetRelatedEntity<Organization>("organization_postlike", null); }
        }

        /// <summary>
        ///     N:1 Post_Likes
        /// </summary>
        [AttributeLogicalName("postid")]
        [RelationshipSchemaName("Post_Likes")]
        public Post Post_Likes
        {
            get { return GetRelatedEntity<Post>("Post_Likes", null); }
            set
            {
                OnPropertyChanging("Post_Likes");
                SetRelatedEntity("Post_Likes", null, value);
                OnPropertyChanged("Post_Likes");
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