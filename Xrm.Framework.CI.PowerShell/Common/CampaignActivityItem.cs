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
    ///     Work item of a campaign activity, such as a list or sales literature.
    /// </summary>
    [DataContract]
    [EntityLogicalName("campaignactivityitem")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class CampaignActivityItem : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "campaignactivityitem";

        public const int EntityTypeCode = 4404;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public CampaignActivityItem() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the campaign activity for the item.
        /// </summary>
        [AttributeLogicalName("campaignactivityid")]
        public EntityReference CampaignActivityId
        {
            get { return GetAttributeValue<EntityReference>("campaignactivityid"); }
            set
            {
                OnPropertyChanging("CampaignActivityId");
                SetAttributeValue("campaignactivityid", value);
                OnPropertyChanged("CampaignActivityId");
            }
        }

        /// <summary>
        ///     Unique identifier of the campaign activity item.
        /// </summary>
        [AttributeLogicalName("campaignactivityitemid")]
        public Guid? CampaignActivityItemId
        {
            get { return GetAttributeValue<Guid?>("campaignactivityitemid"); }
            set
            {
                OnPropertyChanging("CampaignActivityItemId");
                SetAttributeValue("campaignactivityitemid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("CampaignActivityItemId");
            }
        }

        [AttributeLogicalName("campaignactivityitemid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { CampaignActivityItemId = value; }
        }

        /// <summary>
        ///     Unique identifier of the item.
        /// </summary>
        [AttributeLogicalName("itemid")]
        public Guid? ItemId
        {
            get { return GetAttributeValue<Guid?>("itemid"); }
            set
            {
                OnPropertyChanging("ItemId");
                SetAttributeValue("itemid", value);
                OnPropertyChanged("ItemId");
            }
        }

        /// <summary>
        ///     Identification of the type of the campaign activity item.
        /// </summary>
        [AttributeLogicalName("itemobjecttypecode")]
        public string ItemObjectTypeCode
        {
            get { return GetAttributeValue<string>("itemobjecttypecode"); }
            set
            {
                OnPropertyChanging("ItemObjectTypeCode");
                SetAttributeValue("itemobjecttypecode", value);
                OnPropertyChanged("ItemObjectTypeCode");
            }
        }

        /// <summary>
        ///     Unique identifier of the user or team who owns the campaign activity item.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId
        {
            get { return GetAttributeValue<EntityReference>("ownerid"); }
        }

        /// <summary>
        ///     Unique identifier of the business unit that owns the campaign activity item.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public Guid? OwningBusinessUnit
        {
            get { return GetAttributeValue<Guid?>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the user that owns the campaign activity item.
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
        ///     1:N userentityinstancedata_campaignactivityitem
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_campaignactivityitem")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_campaignactivityitem
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_campaignactivityitem", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_campaignactivityitem");
                SetRelatedEntities("userentityinstancedata_campaignactivityitem", null, value);
                OnPropertyChanged("userentityinstancedata_campaignactivityitem");
            }
        }

        /// <summary>
        ///     N:N campaignactivitylist_association
        /// </summary>
        [RelationshipSchemaName("campaignactivitylist_association")]
        public IEnumerable<CampaignActivity> campaignactivitylist_association
        {
            get { return GetRelatedEntities<CampaignActivity>("campaignactivitylist_association", null); }
            set
            {
                OnPropertyChanging("campaignactivitylist_association");
                SetRelatedEntities("campaignactivitylist_association", null, value);
                OnPropertyChanged("campaignactivitylist_association");
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
        ///     N:1 ActivityPointer_CampaignActivityItems
        /// </summary>
        [AttributeLogicalName("campaignactivityid")]
        [RelationshipSchemaName("ActivityPointer_CampaignActivityItems")]
        public ActivityPointer ActivityPointer_CampaignActivityItems
        {
            get { return GetRelatedEntity<ActivityPointer>("ActivityPointer_CampaignActivityItems", null); }
            set
            {
                OnPropertyChanging("ActivityPointer_CampaignActivityItems");
                SetRelatedEntity("ActivityPointer_CampaignActivityItems", null, value);
                OnPropertyChanged("ActivityPointer_CampaignActivityItems");
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