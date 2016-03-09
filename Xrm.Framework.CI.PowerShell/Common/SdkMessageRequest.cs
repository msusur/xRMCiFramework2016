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
    [EntityLogicalName("sdkmessagerequest")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class SdkMessageRequest : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "sdkmessagerequest";

        public const int EntityTypeCode = 4609;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public SdkMessageRequest() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the user who created the SDK message request.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the SDK message request was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the sdkmessagerequest.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Customization level of the SDK message request.
        /// </summary>
        [AttributeLogicalName("customizationlevel")]
        public int? CustomizationLevel
        {
            get { return GetAttributeValue<int?>("customizationlevel"); }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the SDK message request.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the SDK message request was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the sdkmessagerequest.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the SDK message request.
        /// </summary>
        [AttributeLogicalName("name")]
        public string Name
        {
            get { return GetAttributeValue<string>("name"); }
            set
            {
                OnPropertyChanging("Name");
                SetAttributeValue("name", value);
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        ///     Unique identifier of the organization with which the SDK message request is associated.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     Type of entity with which the SDK request is associated.
        /// </summary>
        [AttributeLogicalName("primaryobjecttypecode")]
        public string PrimaryObjectTypeCode
        {
            get { return GetAttributeValue<string>("primaryobjecttypecode"); }
        }

        /// <summary>
        ///     Unique identifier of the message pair with which the SDK message request is associated.
        /// </summary>
        [AttributeLogicalName("sdkmessagepairid")]
        public EntityReference SdkMessagePairId
        {
            get { return GetAttributeValue<EntityReference>("sdkmessagepairid"); }
        }

        /// <summary>
        ///     Unique identifier of the SDK message request entity.
        /// </summary>
        [AttributeLogicalName("sdkmessagerequestid")]
        public Guid? SdkMessageRequestId
        {
            get { return GetAttributeValue<Guid?>("sdkmessagerequestid"); }
            set
            {
                OnPropertyChanging("SdkMessageRequestId");
                SetAttributeValue("sdkmessagerequestid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("SdkMessageRequestId");
            }
        }

        [AttributeLogicalName("sdkmessagerequestid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { SdkMessageRequestId = value; }
        }

        /// <summary>
        ///     Unique identifier of the SDK message request.
        /// </summary>
        [AttributeLogicalName("sdkmessagerequestidunique")]
        public Guid? SdkMessageRequestIdUnique
        {
            get { return GetAttributeValue<Guid?>("sdkmessagerequestidunique"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N messagerequest_sdkmessagerequestfield
        /// </summary>
        [RelationshipSchemaName("messagerequest_sdkmessagerequestfield")]
        public IEnumerable<SdkMessageRequestField> messagerequest_sdkmessagerequestfield
        {
            get { return GetRelatedEntities<SdkMessageRequestField>("messagerequest_sdkmessagerequestfield", null); }
            set
            {
                OnPropertyChanging("messagerequest_sdkmessagerequestfield");
                SetRelatedEntities("messagerequest_sdkmessagerequestfield", null, value);
                OnPropertyChanged("messagerequest_sdkmessagerequestfield");
            }
        }

        /// <summary>
        ///     1:N messagerequest_sdkmessageresponse
        /// </summary>
        [RelationshipSchemaName("messagerequest_sdkmessageresponse")]
        public IEnumerable<SdkMessageResponse> messagerequest_sdkmessageresponse
        {
            get { return GetRelatedEntities<SdkMessageResponse>("messagerequest_sdkmessageresponse", null); }
            set
            {
                OnPropertyChanging("messagerequest_sdkmessageresponse");
                SetRelatedEntities("messagerequest_sdkmessageresponse", null, value);
                OnPropertyChanged("messagerequest_sdkmessageresponse");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_sdkmessagerequest
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_sdkmessagerequest")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_sdkmessagerequest
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_sdkmessagerequest", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_sdkmessagerequest");
                SetRelatedEntities("userentityinstancedata_sdkmessagerequest", null, value);
                OnPropertyChanged("userentityinstancedata_sdkmessagerequest");
            }
        }

        /// <summary>
        ///     N:1 createdby_sdkmessagerequest
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("createdby_sdkmessagerequest")]
        public SystemUser createdby_sdkmessagerequest
        {
            get { return GetRelatedEntity<SystemUser>("createdby_sdkmessagerequest", null); }
        }

        /// <summary>
        ///     N:1 lk_sdkmessagerequest_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_sdkmessagerequest_createdonbehalfby")]
        public SystemUser lk_sdkmessagerequest_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_sdkmessagerequest_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_sdkmessagerequest_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_sdkmessagerequest_modifiedonbehalfby")]
        public SystemUser lk_sdkmessagerequest_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_sdkmessagerequest_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 messagepair_sdkmessagerequest
        /// </summary>
        [AttributeLogicalName("sdkmessagepairid")]
        [RelationshipSchemaName("messagepair_sdkmessagerequest")]
        public SdkMessagePair messagepair_sdkmessagerequest
        {
            get { return GetRelatedEntity<SdkMessagePair>("messagepair_sdkmessagerequest", null); }
        }

        /// <summary>
        ///     N:1 modifiedby_sdkmessagerequest
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("modifiedby_sdkmessagerequest")]
        public SystemUser modifiedby_sdkmessagerequest
        {
            get { return GetRelatedEntity<SystemUser>("modifiedby_sdkmessagerequest", null); }
        }

        /// <summary>
        ///     N:1 organization_sdkmessagerequest
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_sdkmessagerequest")]
        public Organization organization_sdkmessagerequest
        {
            get { return GetRelatedEntity<Organization>("organization_sdkmessagerequest", null); }
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