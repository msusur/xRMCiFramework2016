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
    ///     Work item in a campaign, a list or sales literature.
    /// </summary>
    [DataContract]
    [EntityLogicalName("campaignitem")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class CampaignItem : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "campaignitem";

        public const int EntityTypeCode = 4403;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public CampaignItem() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the campaign that is associated with the individual item.
        /// </summary>
        [AttributeLogicalName("campaignid")]
        public EntityReference CampaignId
        {
            get { return GetAttributeValue<EntityReference>("campaignid"); }
            set
            {
                OnPropertyChanging("CampaignId");
                SetAttributeValue("campaignid", value);
                OnPropertyChanged("CampaignId");
            }
        }

        /// <summary>
        ///     Unique identifier of the campaign item.
        /// </summary>
        [AttributeLogicalName("campaignitemid")]
        public Guid? CampaignItemId
        {
            get { return GetAttributeValue<Guid?>("campaignitemid"); }
            set
            {
                OnPropertyChanging("CampaignItemId");
                SetAttributeValue("campaignitemid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("CampaignItemId");
            }
        }

        [AttributeLogicalName("campaignitemid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { CampaignItemId = value; }
        }

        /// <summary>
        ///     Unique identifier of the entity for the campaign item.
        /// </summary>
        [AttributeLogicalName("entityid")]
        public Guid? EntityId
        {
            get { return GetAttributeValue<Guid?>("entityid"); }
            set
            {
                OnPropertyChanging("EntityId");
                SetAttributeValue("entityid", value);
                OnPropertyChanged("EntityId");
            }
        }

        /// <summary>
        ///     Object type of entity for the campaign item.
        /// </summary>
        [AttributeLogicalName("entitytype")]
        public string EntityType
        {
            get { return GetAttributeValue<string>("entitytype"); }
            set
            {
                OnPropertyChanging("EntityType");
                SetAttributeValue("entitytype", value);
                OnPropertyChanged("EntityType");
            }
        }

        /// <summary>
        ///     Unique identifier of the user or team who owns the campaign item.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId
        {
            get { return GetAttributeValue<EntityReference>("ownerid"); }
        }

        /// <summary>
        ///     Unique identifier of the business unit that owns the campaign item.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public Guid? OwningBusinessUnit
        {
            get { return GetAttributeValue<Guid?>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the user that owns the campaign item.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public Guid? OwningUser
        {
            get { return GetAttributeValue<Guid?>("owninguser"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N userentityinstancedata_campaignitem
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_campaignitem")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_campaignitem
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_campaignitem", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_campaignitem");
                SetRelatedEntities("userentityinstancedata_campaignitem", null, value);
                OnPropertyChanged("userentityinstancedata_campaignitem");
            }
        }

        /// <summary>
        ///     N:N campaigncampaign_association
        /// </summary>
        [RelationshipSchemaName("campaigncampaign_association")]
        public IEnumerable<Campaign> campaigncampaign_association
        {
            get { return GetRelatedEntities<Campaign>("campaigncampaign_association", null); }
            set
            {
                OnPropertyChanging("campaigncampaign_association");
                SetRelatedEntities("campaigncampaign_association", null, value);
                OnPropertyChanged("campaigncampaign_association");
            }
        }

        /// <summary>
        ///     N:N campaignlist_association
        /// </summary>
        [RelationshipSchemaName("campaignlist_association")]
        public IEnumerable<Campaign> campaignlist_association
        {
            get { return GetRelatedEntities<Campaign>("campaignlist_association", null); }
            set
            {
                OnPropertyChanging("campaignlist_association");
                SetRelatedEntities("campaignlist_association", null, value);
                OnPropertyChanged("campaignlist_association");
            }
        }

        /// <summary>
        ///     N:N campaignproduct_association
        /// </summary>
        [RelationshipSchemaName("campaignproduct_association")]
        public IEnumerable<Campaign> campaignproduct_association
        {
            get { return GetRelatedEntities<Campaign>("campaignproduct_association", null); }
            set
            {
                OnPropertyChanging("campaignproduct_association");
                SetRelatedEntities("campaignproduct_association", null, value);
                OnPropertyChanged("campaignproduct_association");
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