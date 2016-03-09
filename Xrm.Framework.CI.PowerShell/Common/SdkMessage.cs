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
    ///     Message that is supported by the SDK.
    /// </summary>
    [DataContract]
    [EntityLogicalName("sdkmessage")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class SdkMessage : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "sdkmessage";

        public const int EntityTypeCode = 4606;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public SdkMessage() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Information about whether the SDK message is automatically transacted.
        /// </summary>
        [AttributeLogicalName("autotransact")]
        public bool? AutoTransact
        {
            get { return GetAttributeValue<bool?>("autotransact"); }
            set
            {
                OnPropertyChanging("AutoTransact");
                SetAttributeValue("autotransact", value);
                OnPropertyChanged("AutoTransact");
            }
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
        ///     If this is a categorized method, this is the name, otherwise None.
        /// </summary>
        [AttributeLogicalName("categoryname")]
        public string CategoryName
        {
            get { return GetAttributeValue<string>("categoryname"); }
            set
            {
                OnPropertyChanging("CategoryName");
                SetAttributeValue("categoryname", value);
                OnPropertyChanged("CategoryName");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the SDK message.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the SDK message was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the sdkmessage.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Customization level of the SDK message.
        /// </summary>
        [AttributeLogicalName("customizationlevel")]
        public int? CustomizationLevel
        {
            get { return GetAttributeValue<int?>("customizationlevel"); }
        }

        /// <summary>
        ///     Indicates whether the SDK message should have its requests expanded per primary entity defined in its filters.
        /// </summary>
        [AttributeLogicalName("expand")]
        public bool? Expand
        {
            get { return GetAttributeValue<bool?>("expand"); }
            set
            {
                OnPropertyChanging("Expand");
                SetAttributeValue("expand", value);
                OnPropertyChanged("Expand");
            }
        }

        /// <summary>
        ///     Information about whether the SDK message is active.
        /// </summary>
        [AttributeLogicalName("isactive")]
        public bool? IsActive
        {
            get { return GetAttributeValue<bool?>("isactive"); }
            set
            {
                OnPropertyChanging("IsActive");
                SetAttributeValue("isactive", value);
                OnPropertyChanged("IsActive");
            }
        }

        /// <summary>
        ///     Indicates whether the SDK message is private.
        /// </summary>
        [AttributeLogicalName("isprivate")]
        public bool? IsPrivate
        {
            get { return GetAttributeValue<bool?>("isprivate"); }
            set
            {
                OnPropertyChanging("IsPrivate");
                SetAttributeValue("isprivate", value);
                OnPropertyChanged("IsPrivate");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("isvalidforexecuteasync")]
        public bool? IsValidForExecuteAsync
        {
            get { return GetAttributeValue<bool?>("isvalidforexecuteasync"); }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the SDK message.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the SDK message was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the sdkmessage.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the SDK message.
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
        ///     Unique identifier of the organization with which the SDK message is associated.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     Unique identifier of the SDK message entity.
        /// </summary>
        [AttributeLogicalName("sdkmessageid")]
        public Guid? SdkMessageId
        {
            get { return GetAttributeValue<Guid?>("sdkmessageid"); }
            set
            {
                OnPropertyChanging("SdkMessageId");
                SetAttributeValue("sdkmessageid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("SdkMessageId");
            }
        }

        [AttributeLogicalName("sdkmessageid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { SdkMessageId = value; }
        }

        /// <summary>
        ///     Unique identifier of the SDK message.
        /// </summary>
        [AttributeLogicalName("sdkmessageidunique")]
        public Guid? SdkMessageIdUnique
        {
            get { return GetAttributeValue<Guid?>("sdkmessageidunique"); }
        }

        /// <summary>
        ///     Indicates whether the SDK message is a template.
        /// </summary>
        [AttributeLogicalName("template")]
        public bool? Template
        {
            get { return GetAttributeValue<bool?>("template"); }
            set
            {
                OnPropertyChanging("Template");
                SetAttributeValue("template", value);
                OnPropertyChanged("Template");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("throttlesettings")]
        public string ThrottleSettings
        {
            get { return GetAttributeValue<string>("throttlesettings"); }
        }

        /// <summary>
        ///     Number that identifies a specific revision of the SDK message.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N message_sdkmessagepair
        /// </summary>
        [RelationshipSchemaName("message_sdkmessagepair")]
        public IEnumerable<SdkMessagePair> message_sdkmessagepair
        {
            get { return GetRelatedEntities<SdkMessagePair>("message_sdkmessagepair", null); }
            set
            {
                OnPropertyChanging("message_sdkmessagepair");
                SetRelatedEntities("message_sdkmessagepair", null, value);
                OnPropertyChanged("message_sdkmessagepair");
            }
        }

        /// <summary>
        ///     1:N sdkmessageid_sdkmessagefilter
        /// </summary>
        [RelationshipSchemaName("sdkmessageid_sdkmessagefilter")]
        public IEnumerable<SdkMessageFilter> sdkmessageid_sdkmessagefilter
        {
            get { return GetRelatedEntities<SdkMessageFilter>("sdkmessageid_sdkmessagefilter", null); }
            set
            {
                OnPropertyChanging("sdkmessageid_sdkmessagefilter");
                SetRelatedEntities("sdkmessageid_sdkmessagefilter", null, value);
                OnPropertyChanged("sdkmessageid_sdkmessagefilter");
            }
        }

        /// <summary>
        ///     1:N sdkmessageid_sdkmessageprocessingstep
        /// </summary>
        [RelationshipSchemaName("sdkmessageid_sdkmessageprocessingstep")]
        public IEnumerable<SdkMessageProcessingStep> sdkmessageid_sdkmessageprocessingstep
        {
            get { return GetRelatedEntities<SdkMessageProcessingStep>("sdkmessageid_sdkmessageprocessingstep", null); }
            set
            {
                OnPropertyChanging("sdkmessageid_sdkmessageprocessingstep");
                SetRelatedEntities("sdkmessageid_sdkmessageprocessingstep", null, value);
                OnPropertyChanged("sdkmessageid_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        ///     1:N sdkmessageid_workflow_dependency
        /// </summary>
        [RelationshipSchemaName("sdkmessageid_workflow_dependency")]
        public IEnumerable<WorkflowDependency> sdkmessageid_workflow_dependency
        {
            get { return GetRelatedEntities<WorkflowDependency>("sdkmessageid_workflow_dependency", null); }
            set
            {
                OnPropertyChanging("sdkmessageid_workflow_dependency");
                SetRelatedEntities("sdkmessageid_workflow_dependency", null, value);
                OnPropertyChanged("sdkmessageid_workflow_dependency");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_sdkmessage
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_sdkmessage")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_sdkmessage
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_sdkmessage", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_sdkmessage");
                SetRelatedEntities("userentityinstancedata_sdkmessage", null, value);
                OnPropertyChanged("userentityinstancedata_sdkmessage");
            }
        }

        /// <summary>
        ///     N:1 createdby_sdkmessage
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("createdby_sdkmessage")]
        public SystemUser createdby_sdkmessage
        {
            get { return GetRelatedEntity<SystemUser>("createdby_sdkmessage", null); }
        }

        /// <summary>
        ///     N:1 lk_sdkmessage_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_sdkmessage_createdonbehalfby")]
        public SystemUser lk_sdkmessage_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_sdkmessage_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_sdkmessage_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_sdkmessage_modifiedonbehalfby")]
        public SystemUser lk_sdkmessage_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_sdkmessage_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 modifiedby_sdkmessage
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("modifiedby_sdkmessage")]
        public SystemUser modifiedby_sdkmessage
        {
            get { return GetRelatedEntity<SystemUser>("modifiedby_sdkmessage", null); }
        }

        /// <summary>
        ///     N:1 organization_sdkmessage
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_sdkmessage")]
        public Organization organization_sdkmessage
        {
            get { return GetRelatedEntity<Organization>("organization_sdkmessage", null); }
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