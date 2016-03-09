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
    [EntityLogicalName("sdkmessagepair")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class SdkMessagePair : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "sdkmessagepair";

        public const int EntityTypeCode = 4613;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public SdkMessagePair() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the user who created the SDK message pair.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the SDK message pair was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the sdkmessagepair.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Customization level of the SDK message filter.
        /// </summary>
        [AttributeLogicalName("customizationlevel")]
        public int? CustomizationLevel
        {
            get { return GetAttributeValue<int?>("customizationlevel"); }
        }

        /// <summary>
        ///     Endpoint that the message pair is associated with.
        /// </summary>
        [AttributeLogicalName("endpoint")]
        public string Endpoint
        {
            get { return GetAttributeValue<string>("endpoint"); }
            set
            {
                OnPropertyChanging("Endpoint");
                SetAttributeValue("endpoint", value);
                OnPropertyChanged("Endpoint");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the SDK message pair.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the SDK message pair was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the sdkmessagepair.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Namespace that the message pair is associated with.
        /// </summary>
        [AttributeLogicalName("namespace")]
        public string Namespace
        {
            get { return GetAttributeValue<string>("namespace"); }
            set
            {
                OnPropertyChanging("Namespace");
                SetAttributeValue("namespace", value);
                OnPropertyChanged("Namespace");
            }
        }

        /// <summary>
        ///     Unique identifier of the organization with which the SDK message pair is associated.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     Unique identifier of the message with which the SDK message pair is associated.
        /// </summary>
        [AttributeLogicalName("sdkmessageid")]
        public EntityReference SdkMessageId
        {
            get { return GetAttributeValue<EntityReference>("sdkmessageid"); }
        }

        /// <summary>
        ///     Unique identifier of the SDK message pair entity.
        /// </summary>
        [AttributeLogicalName("sdkmessagepairid")]
        public Guid? SdkMessagePairId
        {
            get { return GetAttributeValue<Guid?>("sdkmessagepairid"); }
            set
            {
                OnPropertyChanging("SdkMessagePairId");
                SetAttributeValue("sdkmessagepairid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("SdkMessagePairId");
            }
        }

        [AttributeLogicalName("sdkmessagepairid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { SdkMessagePairId = value; }
        }

        /// <summary>
        ///     Unique identifier of the SDK message pair.
        /// </summary>
        [AttributeLogicalName("sdkmessagepairidunique")]
        public Guid? SdkMessagePairIdUnique
        {
            get { return GetAttributeValue<Guid?>("sdkmessagepairidunique"); }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N messagepair_sdkmessagerequest
        /// </summary>
        [RelationshipSchemaName("messagepair_sdkmessagerequest")]
        public IEnumerable<SdkMessageRequest> messagepair_sdkmessagerequest
        {
            get { return GetRelatedEntities<SdkMessageRequest>("messagepair_sdkmessagerequest", null); }
            set
            {
                OnPropertyChanging("messagepair_sdkmessagerequest");
                SetRelatedEntities("messagepair_sdkmessagerequest", null, value);
                OnPropertyChanged("messagepair_sdkmessagerequest");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_sdkmessagepair
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_sdkmessagepair")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_sdkmessagepair
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_sdkmessagepair", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_sdkmessagepair");
                SetRelatedEntities("userentityinstancedata_sdkmessagepair", null, value);
                OnPropertyChanged("userentityinstancedata_sdkmessagepair");
            }
        }

        /// <summary>
        ///     N:1 createdby_sdkmessagepair
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("createdby_sdkmessagepair")]
        public SystemUser createdby_sdkmessagepair
        {
            get { return GetRelatedEntity<SystemUser>("createdby_sdkmessagepair", null); }
        }

        /// <summary>
        ///     N:1 lk_sdkmessagepair_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_sdkmessagepair_createdonbehalfby")]
        public SystemUser lk_sdkmessagepair_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_sdkmessagepair_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_sdkmessagepair_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_sdkmessagepair_modifiedonbehalfby")]
        public SystemUser lk_sdkmessagepair_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_sdkmessagepair_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 message_sdkmessagepair
        /// </summary>
        [AttributeLogicalName("sdkmessageid")]
        [RelationshipSchemaName("message_sdkmessagepair")]
        public SdkMessage message_sdkmessagepair
        {
            get { return GetRelatedEntity<SdkMessage>("message_sdkmessagepair", null); }
        }

        /// <summary>
        ///     N:1 modifiedby_sdkmessagepair
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("modifiedby_sdkmessagepair")]
        public SystemUser modifiedby_sdkmessagepair
        {
            get { return GetRelatedEntity<SystemUser>("modifiedby_sdkmessagepair", null); }
        }

        /// <summary>
        ///     N:1 organization_sdkmessagepair
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_sdkmessagepair")]
        public Organization organization_sdkmessagepair
        {
            get { return GetRelatedEntity<Organization>("organization_sdkmessagepair", null); }
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