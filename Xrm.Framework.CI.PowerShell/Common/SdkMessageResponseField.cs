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
    [EntityLogicalName("sdkmessageresponsefield")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class SdkMessageResponseField : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "sdkmessageresponsefield";

        public const int EntityTypeCode = 4611;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public SdkMessageResponseField() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Common language runtime (CLR)-based formatter of the SDK message response field.
        /// </summary>
        [AttributeLogicalName("clrformatter")]
        public string ClrFormatter
        {
            get { return GetAttributeValue<string>("clrformatter"); }
            set
            {
                OnPropertyChanging("ClrFormatter");
                SetAttributeValue("clrformatter", value);
                OnPropertyChanged("ClrFormatter");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the SDK message response field.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the SDK message response field was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the sdkmessageresponsefield.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Customization level of the SDK message response field.
        /// </summary>
        [AttributeLogicalName("customizationlevel")]
        public int? CustomizationLevel
        {
            get { return GetAttributeValue<int?>("customizationlevel"); }
        }

        /// <summary>
        ///     Formatter for the SDK message response field.
        /// </summary>
        [AttributeLogicalName("formatter")]
        public string Formatter
        {
            get { return GetAttributeValue<string>("formatter"); }
            set
            {
                OnPropertyChanging("Formatter");
                SetAttributeValue("formatter", value);
                OnPropertyChanged("Formatter");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the SDK message response field.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the SDK message response field was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the sdkmessageresponsefield.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the SDK message response field.
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
        ///     Unique identifier of the organization with which the SDK message response field is associated.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     Position of the Sdk message response field
        /// </summary>
        [AttributeLogicalName("position")]
        public int? Position
        {
            get { return GetAttributeValue<int?>("position"); }
        }

        /// <summary>
        ///     Public name of the SDK message response field.
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
        ///     Unique identifier of the SDK message response field entity.
        /// </summary>
        [AttributeLogicalName("sdkmessageresponsefieldid")]
        public Guid? SdkMessageResponseFieldId
        {
            get { return GetAttributeValue<Guid?>("sdkmessageresponsefieldid"); }
            set
            {
                OnPropertyChanging("SdkMessageResponseFieldId");
                SetAttributeValue("sdkmessageresponsefieldid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("SdkMessageResponseFieldId");
            }
        }

        [AttributeLogicalName("sdkmessageresponsefieldid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { SdkMessageResponseFieldId = value; }
        }

        /// <summary>
        ///     Unique identifier of the SDK message response field.
        /// </summary>
        [AttributeLogicalName("sdkmessageresponsefieldidunique")]
        public Guid? SdkMessageResponseFieldIdUnique
        {
            get { return GetAttributeValue<Guid?>("sdkmessageresponsefieldidunique"); }
        }

        /// <summary>
        ///     Unique identifier of the message response with which the SDK message response field is associated.
        /// </summary>
        [AttributeLogicalName("sdkmessageresponseid")]
        public EntityReference SdkMessageResponseId
        {
            get { return GetAttributeValue<EntityReference>("sdkmessageresponseid"); }
        }

        /// <summary>
        ///     Actual value of the SDK message response field.
        /// </summary>
        [AttributeLogicalName("value")]
        public string Value
        {
            get { return GetAttributeValue<string>("value"); }
            set
            {
                OnPropertyChanging("Value");
                SetAttributeValue("value", value);
                OnPropertyChanged("Value");
            }
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
        ///     1:N userentityinstancedata_sdkmessageresponsefield
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_sdkmessageresponsefield")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_sdkmessageresponsefield
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_sdkmessageresponsefield", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_sdkmessageresponsefield");
                SetRelatedEntities("userentityinstancedata_sdkmessageresponsefield", null, value);
                OnPropertyChanged("userentityinstancedata_sdkmessageresponsefield");
            }
        }

        /// <summary>
        ///     N:1 createdby_sdkmessageresponsefield
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("createdby_sdkmessageresponsefield")]
        public SystemUser createdby_sdkmessageresponsefield
        {
            get { return GetRelatedEntity<SystemUser>("createdby_sdkmessageresponsefield", null); }
        }

        /// <summary>
        ///     N:1 lk_sdkmessageresponsefield_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_sdkmessageresponsefield_createdonbehalfby")]
        public SystemUser lk_sdkmessageresponsefield_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_sdkmessageresponsefield_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_sdkmessageresponsefield_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_sdkmessageresponsefield_modifiedonbehalfby")]
        public SystemUser lk_sdkmessageresponsefield_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_sdkmessageresponsefield_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 messageresponse_sdkmessageresponsefield
        /// </summary>
        [AttributeLogicalName("sdkmessageresponseid")]
        [RelationshipSchemaName("messageresponse_sdkmessageresponsefield")]
        public SdkMessageResponse messageresponse_sdkmessageresponsefield
        {
            get { return GetRelatedEntity<SdkMessageResponse>("messageresponse_sdkmessageresponsefield", null); }
        }

        /// <summary>
        ///     N:1 modifiedby_sdkmessageresponsefield
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("modifiedby_sdkmessageresponsefield")]
        public SystemUser modifiedby_sdkmessageresponsefield
        {
            get { return GetRelatedEntity<SystemUser>("modifiedby_sdkmessageresponsefield", null); }
        }

        /// <summary>
        ///     N:1 organization_sdkmessageresponsefield
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_sdkmessageresponsefield")]
        public Organization organization_sdkmessageresponsefield
        {
            get { return GetRelatedEntity<Organization>("organization_sdkmessageresponsefield", null); }
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