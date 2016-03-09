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
    [EntityLogicalName("sdkmessagerequestfield")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class SdkMessageRequestField : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "sdkmessagerequestfield";

        public const int EntityTypeCode = 4614;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public SdkMessageRequestField() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Common language runtime (CLR)-based parser for the SDK message request field.
        /// </summary>
        [AttributeLogicalName("clrparser")]
        public string ClrParser
        {
            get { return GetAttributeValue<string>("clrparser"); }
            set
            {
                OnPropertyChanging("ClrParser");
                SetAttributeValue("clrparser", value);
                OnPropertyChanged("ClrParser");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the SDK message request field.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the SDK message request field was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the sdkmessagerequestfield.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Customization level of the SDK message request field.
        /// </summary>
        [AttributeLogicalName("customizationlevel")]
        public int? CustomizationLevel
        {
            get { return GetAttributeValue<int?>("customizationlevel"); }
        }

        /// <summary>
        ///     Indicates how field contents are used during message processing. 1 - Primary entity, 2- Secondary entity
        /// </summary>
        [AttributeLogicalName("fieldmask")]
        public int? FieldMask
        {
            get { return GetAttributeValue<int?>("fieldmask"); }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the SDK message request field.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the SDK message request field was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the sdkmessagerequestfield.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the SDK message request field.
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
        ///     Information about whether SDK message request field is optional.
        /// </summary>
        [AttributeLogicalName("optional")]
        public bool? Optional
        {
            get { return GetAttributeValue<bool?>("optional"); }
            set
            {
                OnPropertyChanging("Optional");
                SetAttributeValue("optional", value);
                OnPropertyChanged("Optional");
            }
        }

        /// <summary>
        ///     Unique identifier of the organization with which the SDK message request field is associated.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     Parser for the SDK message request field.
        /// </summary>
        [AttributeLogicalName("parser")]
        public string Parser
        {
            get { return GetAttributeValue<string>("parser"); }
            set
            {
                OnPropertyChanging("Parser");
                SetAttributeValue("parser", value);
                OnPropertyChanged("Parser");
            }
        }

        /// <summary>
        ///     Position of the Sdk message request field
        /// </summary>
        [AttributeLogicalName("position")]
        public int? Position
        {
            get { return GetAttributeValue<int?>("position"); }
        }

        /// <summary>
        ///     Public name of the SDK message request field.
        /// </summary>
        [AttributeLogicalName("publicname")]
        public string PublicName
        {
            get { return GetAttributeValue<string>("publicname"); }
            set
            {
                OnPropertyChanging("PublicName");
                SetAttributeValue("publicname", value);
                OnPropertyChanged("PublicName");
            }
        }

        /// <summary>
        ///     Unique identifier of the SDK message request field entity.
        /// </summary>
        [AttributeLogicalName("sdkmessagerequestfieldid")]
        public Guid? SdkMessageRequestFieldId
        {
            get { return GetAttributeValue<Guid?>("sdkmessagerequestfieldid"); }
            set
            {
                OnPropertyChanging("SdkMessageRequestFieldId");
                SetAttributeValue("sdkmessagerequestfieldid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("SdkMessageRequestFieldId");
            }
        }

        [AttributeLogicalName("sdkmessagerequestfieldid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { SdkMessageRequestFieldId = value; }
        }

        /// <summary>
        ///     Entity identifier of the SDK message request field.
        /// </summary>
        [AttributeLogicalName("sdkmessagerequestfieldidunique")]
        public Guid? SdkMessageRequestFieldIdUnique
        {
            get { return GetAttributeValue<Guid?>("sdkmessagerequestfieldidunique"); }
        }

        /// <summary>
        ///     Unique identifier of the message request with which the SDK message request field is associated.
        /// </summary>
        [AttributeLogicalName("sdkmessagerequestid")]
        public EntityReference SdkMessageRequestId
        {
            get { return GetAttributeValue<EntityReference>("sdkmessagerequestid"); }
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
        ///     1:N userentityinstancedata_sdkmessagerequestfield
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_sdkmessagerequestfield")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_sdkmessagerequestfield
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_sdkmessagerequestfield", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_sdkmessagerequestfield");
                SetRelatedEntities("userentityinstancedata_sdkmessagerequestfield", null, value);
                OnPropertyChanged("userentityinstancedata_sdkmessagerequestfield");
            }
        }

        /// <summary>
        ///     N:1 createdby_sdkmessagerequestfield
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("createdby_sdkmessagerequestfield")]
        public SystemUser createdby_sdkmessagerequestfield
        {
            get { return GetRelatedEntity<SystemUser>("createdby_sdkmessagerequestfield", null); }
        }

        /// <summary>
        ///     N:1 lk_sdkmessagerequestfield_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_sdkmessagerequestfield_createdonbehalfby")]
        public SystemUser lk_sdkmessagerequestfield_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_sdkmessagerequestfield_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_sdkmessagerequestfield_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_sdkmessagerequestfield_modifiedonbehalfby")]
        public SystemUser lk_sdkmessagerequestfield_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_sdkmessagerequestfield_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 messagerequest_sdkmessagerequestfield
        /// </summary>
        [AttributeLogicalName("sdkmessagerequestid")]
        [RelationshipSchemaName("messagerequest_sdkmessagerequestfield")]
        public SdkMessageRequest messagerequest_sdkmessagerequestfield
        {
            get { return GetRelatedEntity<SdkMessageRequest>("messagerequest_sdkmessagerequestfield", null); }
        }

        /// <summary>
        ///     N:1 modifiedby_sdkmessagerequestfield
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("modifiedby_sdkmessagerequestfield")]
        public SystemUser modifiedby_sdkmessagerequestfield
        {
            get { return GetRelatedEntity<SystemUser>("modifiedby_sdkmessagerequestfield", null); }
        }

        /// <summary>
        ///     N:1 organization_sdkmessagerequestfield
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_sdkmessagerequestfield")]
        public Organization organization_sdkmessagerequestfield
        {
            get { return GetRelatedEntity<Organization>("organization_sdkmessagerequestfield", null); }
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