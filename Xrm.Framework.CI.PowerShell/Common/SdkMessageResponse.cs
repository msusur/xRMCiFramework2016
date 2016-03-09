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
    [EntityLogicalName("sdkmessageresponse")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class SdkMessageResponse : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "sdkmessageresponse";

        public const int EntityTypeCode = 4610;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public SdkMessageResponse() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the user who created the SDK message response.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the SDK message response was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the sdkmessageresponse.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Customization level of the SDK message response.
        /// </summary>
        [AttributeLogicalName("customizationlevel")]
        public int? CustomizationLevel
        {
            get { return GetAttributeValue<int?>("customizationlevel"); }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the SDK message response.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the SDK message response was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the sdkmessageresponse.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the organization with which the SDK message response is associated.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     Unique identifier of the message request with which the SDK message response is associated.
        /// </summary>
        [AttributeLogicalName("sdkmessagerequestid")]
        public EntityReference SdkMessageRequestId
        {
            get { return GetAttributeValue<EntityReference>("sdkmessagerequestid"); }
        }

        /// <summary>
        ///     Unique identifier of the SDK message response entity.
        /// </summary>
        [AttributeLogicalName("sdkmessageresponseid")]
        public Guid? SdkMessageResponseId
        {
            get { return GetAttributeValue<Guid?>("sdkmessageresponseid"); }
            set
            {
                OnPropertyChanging("SdkMessageResponseId");
                SetAttributeValue("sdkmessageresponseid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("SdkMessageResponseId");
            }
        }

        [AttributeLogicalName("sdkmessageresponseid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { SdkMessageResponseId = value; }
        }

        /// <summary>
        ///     Unique identifier of the SDK message response.
        /// </summary>
        [AttributeLogicalName("sdkmessageresponseidunique")]
        public Guid? SdkMessageResponseIdUnique
        {
            get { return GetAttributeValue<Guid?>("sdkmessageresponseidunique"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N messageresponse_sdkmessageresponsefield
        /// </summary>
        [RelationshipSchemaName("messageresponse_sdkmessageresponsefield")]
        public IEnumerable<SdkMessageResponseField> messageresponse_sdkmessageresponsefield
        {
            get { return GetRelatedEntities<SdkMessageResponseField>("messageresponse_sdkmessageresponsefield", null); }
            set
            {
                OnPropertyChanging("messageresponse_sdkmessageresponsefield");
                SetRelatedEntities("messageresponse_sdkmessageresponsefield", null, value);
                OnPropertyChanged("messageresponse_sdkmessageresponsefield");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_sdkmessageresponse
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_sdkmessageresponse")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_sdkmessageresponse
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_sdkmessageresponse", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_sdkmessageresponse");
                SetRelatedEntities("userentityinstancedata_sdkmessageresponse", null, value);
                OnPropertyChanged("userentityinstancedata_sdkmessageresponse");
            }
        }

        /// <summary>
        ///     N:1 createdby_sdkmessageresponse
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("createdby_sdkmessageresponse")]
        public SystemUser createdby_sdkmessageresponse
        {
            get { return GetRelatedEntity<SystemUser>("createdby_sdkmessageresponse", null); }
        }

        /// <summary>
        ///     N:1 lk_sdkmessageresponse_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_sdkmessageresponse_createdonbehalfby")]
        public SystemUser lk_sdkmessageresponse_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_sdkmessageresponse_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_sdkmessageresponse_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_sdkmessageresponse_modifiedonbehalfby")]
        public SystemUser lk_sdkmessageresponse_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_sdkmessageresponse_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 messagerequest_sdkmessageresponse
        /// </summary>
        [AttributeLogicalName("sdkmessagerequestid")]
        [RelationshipSchemaName("messagerequest_sdkmessageresponse")]
        public SdkMessageRequest messagerequest_sdkmessageresponse
        {
            get { return GetRelatedEntity<SdkMessageRequest>("messagerequest_sdkmessageresponse", null); }
        }

        /// <summary>
        ///     N:1 modifiedby_sdkmessageresponse
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("modifiedby_sdkmessageresponse")]
        public SystemUser modifiedby_sdkmessageresponse
        {
            get { return GetRelatedEntity<SystemUser>("modifiedby_sdkmessageresponse", null); }
        }

        /// <summary>
        ///     N:1 organization_sdkmessageresponse
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_sdkmessageresponse")]
        public Organization organization_sdkmessageresponse
        {
            get { return GetRelatedEntity<Organization>("organization_sdkmessageresponse", null); }
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