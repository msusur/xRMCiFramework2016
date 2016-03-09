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
    ///     Filter that defines which SDK messages are valid for each type of entity.
    /// </summary>
    [DataContract]
    [EntityLogicalName("sdkmessagefilter")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class SdkMessageFilter : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "sdkmessagefilter";

        public const int EntityTypeCode = 4607;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public SdkMessageFilter() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Identifies where a method will be exposed. 0 - Server, 1 - Client, 2 - both.
        /// </summary>
        [AttributeLogicalName("availability")]
        public int? Availability
        {
            get { return GetAttributeValue<int?>("availability"); }
            set
            {
                OnPropertyChanging("Availability");
                SetAttributeValue("availability", value);
                OnPropertyChanged("Availability");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the SDK message filter.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the SDK message filter was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the sdkmessagefilter.
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
        ///     Indicates whether a custom SDK message processing step is allowed.
        /// </summary>
        [AttributeLogicalName("iscustomprocessingstepallowed")]
        public bool? IsCustomProcessingStepAllowed
        {
            get { return GetAttributeValue<bool?>("iscustomprocessingstepallowed"); }
            set
            {
                OnPropertyChanging("IsCustomProcessingStepAllowed");
                SetAttributeValue("iscustomprocessingstepallowed", value);
                OnPropertyChanged("IsCustomProcessingStepAllowed");
            }
        }

        /// <summary>
        ///     Indicates whether the filter should be visible.
        /// </summary>
        [AttributeLogicalName("isvisible")]
        public bool? IsVisible
        {
            get { return GetAttributeValue<bool?>("isvisible"); }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the SDK message filter.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the SDK message filter was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the sdkmessagefilter.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the organization with which the SDK message filter is associated.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     Type of entity with which the SDK message filter is primarily associated.
        /// </summary>
        [AttributeLogicalName("primaryobjecttypecode")]
        public string PrimaryObjectTypeCode
        {
            get { return GetAttributeValue<string>("primaryobjecttypecode"); }
        }

        /// <summary>
        ///     Unique identifier of the SDK message filter entity.
        /// </summary>
        [AttributeLogicalName("sdkmessagefilterid")]
        public Guid? SdkMessageFilterId
        {
            get { return GetAttributeValue<Guid?>("sdkmessagefilterid"); }
            set
            {
                OnPropertyChanging("SdkMessageFilterId");
                SetAttributeValue("sdkmessagefilterid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("SdkMessageFilterId");
            }
        }

        [AttributeLogicalName("sdkmessagefilterid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { SdkMessageFilterId = value; }
        }

        /// <summary>
        ///     Unique identifier of the SDK message filter.
        /// </summary>
        [AttributeLogicalName("sdkmessagefilteridunique")]
        public Guid? SdkMessageFilterIdUnique
        {
            get { return GetAttributeValue<Guid?>("sdkmessagefilteridunique"); }
        }

        /// <summary>
        ///     Unique identifier of the related SDK message.
        /// </summary>
        [AttributeLogicalName("sdkmessageid")]
        public EntityReference SdkMessageId
        {
            get { return GetAttributeValue<EntityReference>("sdkmessageid"); }
            set
            {
                OnPropertyChanging("SdkMessageId");
                SetAttributeValue("sdkmessageid", value);
                OnPropertyChanged("SdkMessageId");
            }
        }

        /// <summary>
        ///     Type of entity with which the SDK message filter is secondarily associated.
        /// </summary>
        [AttributeLogicalName("secondaryobjecttypecode")]
        public string SecondaryObjectTypeCode
        {
            get { return GetAttributeValue<string>("secondaryobjecttypecode"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N sdkmessagefilterid_sdkmessageprocessingstep
        /// </summary>
        [RelationshipSchemaName("sdkmessagefilterid_sdkmessageprocessingstep")]
        public IEnumerable<SdkMessageProcessingStep> sdkmessagefilterid_sdkmessageprocessingstep
        {
            get
            {
                return GetRelatedEntities<SdkMessageProcessingStep>("sdkmessagefilterid_sdkmessageprocessingstep", null);
            }
            set
            {
                OnPropertyChanging("sdkmessagefilterid_sdkmessageprocessingstep");
                SetRelatedEntities("sdkmessagefilterid_sdkmessageprocessingstep", null, value);
                OnPropertyChanged("sdkmessagefilterid_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_sdkmessagefilter
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_sdkmessagefilter")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_sdkmessagefilter
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_sdkmessagefilter", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_sdkmessagefilter");
                SetRelatedEntities("userentityinstancedata_sdkmessagefilter", null, value);
                OnPropertyChanged("userentityinstancedata_sdkmessagefilter");
            }
        }

        /// <summary>
        ///     N:1 createdby_sdkmessagefilter
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("createdby_sdkmessagefilter")]
        public SystemUser createdby_sdkmessagefilter
        {
            get { return GetRelatedEntity<SystemUser>("createdby_sdkmessagefilter", null); }
        }

        /// <summary>
        ///     N:1 lk_sdkmessagefilter_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_sdkmessagefilter_createdonbehalfby")]
        public SystemUser lk_sdkmessagefilter_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_sdkmessagefilter_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_sdkmessagefilter_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_sdkmessagefilter_modifiedonbehalfby")]
        public SystemUser lk_sdkmessagefilter_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_sdkmessagefilter_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 modifiedby_sdkmessagefilter
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("modifiedby_sdkmessagefilter")]
        public SystemUser modifiedby_sdkmessagefilter
        {
            get { return GetRelatedEntity<SystemUser>("modifiedby_sdkmessagefilter", null); }
        }

        /// <summary>
        ///     N:1 organization_sdkmessagefilter
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_sdkmessagefilter")]
        public Organization organization_sdkmessagefilter
        {
            get { return GetRelatedEntity<Organization>("organization_sdkmessagefilter", null); }
        }

        /// <summary>
        ///     N:1 sdkmessageid_sdkmessagefilter
        /// </summary>
        [AttributeLogicalName("sdkmessageid")]
        [RelationshipSchemaName("sdkmessageid_sdkmessagefilter")]
        public SdkMessage sdkmessageid_sdkmessagefilter
        {
            get { return GetRelatedEntity<SdkMessage>("sdkmessageid_sdkmessagefilter", null); }
            set
            {
                OnPropertyChanging("sdkmessageid_sdkmessagefilter");
                SetRelatedEntity("sdkmessageid_sdkmessagefilter", null, value);
                OnPropertyChanged("sdkmessageid_sdkmessagefilter");
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