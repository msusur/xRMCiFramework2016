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
    ///     For internal use only.
    /// </summary>
    [DataContract]
    [EntityLogicalName("subscriptionmanuallytrackedobject")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class SubscriptionManuallyTrackedObject : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "subscriptionmanuallytrackedobject";

        public const int EntityTypeCode = 37;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public SubscriptionManuallyTrackedObject() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the object with which the subscription is associated.
        /// </summary>
        [AttributeLogicalName("objectid")]
        public Guid? ObjectId
        {
            get { return GetAttributeValue<Guid?>("objectid"); }
            set
            {
                OnPropertyChanging("ObjectId");
                SetAttributeValue("objectid", value);
                OnPropertyChanged("ObjectId");
            }
        }

        /// <summary>
        ///     Type code of the object with which the subscription is associated.
        /// </summary>
        [AttributeLogicalName("objecttypecode")]
        public string ObjectTypeCode
        {
            get { return GetAttributeValue<string>("objecttypecode"); }
            set
            {
                OnPropertyChanging("ObjectTypeCode");
                SetAttributeValue("objecttypecode", value);
                OnPropertyChanged("ObjectTypeCode");
            }
        }

        /// <summary>
        ///     Unique identifier of the subscription.
        /// </summary>
        [AttributeLogicalName("subscriptionid")]
        public Guid? SubscriptionId
        {
            get { return GetAttributeValue<Guid?>("subscriptionid"); }
            set
            {
                OnPropertyChanging("SubscriptionId");
                SetAttributeValue("subscriptionid", value);
                OnPropertyChanged("SubscriptionId");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("subscriptionmanuallytrackedobjectid")]
        public Guid? SubscriptionManuallyTrackedObjectId
        {
            get { return GetAttributeValue<Guid?>("subscriptionmanuallytrackedobjectid"); }
            set
            {
                OnPropertyChanging("SubscriptionManuallyTrackedObjectId");
                SetAttributeValue("subscriptionmanuallytrackedobjectid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("SubscriptionManuallyTrackedObjectId");
            }
        }

        [AttributeLogicalName("subscriptionmanuallytrackedobjectid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { SubscriptionManuallyTrackedObjectId = value; }
        }

        /// <summary>
        ///     Information that specifies if the object is tracked.
        /// </summary>
        [AttributeLogicalName("track")]
        public bool? Track
        {
            get { return GetAttributeValue<bool?>("track"); }
            set
            {
                OnPropertyChanging("Track");
                SetAttributeValue("track", value);
                OnPropertyChanged("Track");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_subscriptionmanuallytrackedobject
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_subscriptionmanuallytrackedobject")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_subscriptionmanuallytrackedobject
        {
            get
            {
                return
                    GetRelatedEntities<UserEntityInstanceData>(
                        "userentityinstancedata_subscriptionmanuallytrackedobject", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_subscriptionmanuallytrackedobject");
                SetRelatedEntities("userentityinstancedata_subscriptionmanuallytrackedobject", null, value);
                OnPropertyChanged("userentityinstancedata_subscriptionmanuallytrackedobject");
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