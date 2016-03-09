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
    ///     Copy of an entity's attributes before or after the core system operation.
    /// </summary>
    [DataContract]
    [EntityLogicalName("sdkmessageprocessingstepimage")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class SdkMessageProcessingStepImage : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "sdkmessageprocessingstepimage";

        public const int EntityTypeCode = 4615;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public SdkMessageProcessingStepImage() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Comma-separated list of attributes that are to be passed into the SDK message processing step image.
        /// </summary>
        [AttributeLogicalName("attributes")]
        public string Attributes1
        {
            get { return GetAttributeValue<string>("attributes"); }
            set
            {
                OnPropertyChanging("Attributes1");
                SetAttributeValue("attributes", value);
                OnPropertyChanged("Attributes1");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("componentstate")]
        public OptionSetValue ComponentState
        {
            get { return GetAttributeValue<OptionSetValue>("componentstate"); }
        }

        /// <summary>
        ///     Unique identifier of the user who created the SDK message processing step image.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the SDK message processing step image was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the sdkmessageprocessingstepimage.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Customization level of the SDK message processing step image.
        /// </summary>
        [AttributeLogicalName("customizationlevel")]
        public int? CustomizationLevel
        {
            get { return GetAttributeValue<int?>("customizationlevel"); }
        }

        /// <summary>
        ///     Description of the SDK message processing step image.
        /// </summary>
        [AttributeLogicalName("description")]
        public string Description
        {
            get { return GetAttributeValue<string>("description"); }
            set
            {
                OnPropertyChanging("Description");
                SetAttributeValue("description", value);
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        ///     Key name used to access the pre-image or post-image property bags in a step.
        /// </summary>
        [AttributeLogicalName("entityalias")]
        public string EntityAlias
        {
            get { return GetAttributeValue<string>("entityalias"); }
            set
            {
                OnPropertyChanging("EntityAlias");
                SetAttributeValue("entityalias", value);
                OnPropertyChanged("EntityAlias");
            }
        }

        /// <summary>
        ///     Type of image requested.
        /// </summary>
        [AttributeLogicalName("imagetype")]
        public OptionSetValue ImageType
        {
            get { return GetAttributeValue<OptionSetValue>("imagetype"); }
            set
            {
                OnPropertyChanging("ImageType");
                SetAttributeValue("imagetype", value);
                OnPropertyChanged("ImageType");
            }
        }

        /// <summary>
        ///     Version in which the form is introduced.
        /// </summary>
        [AttributeLogicalName("introducedversion")]
        public string IntroducedVersion
        {
            get { return GetAttributeValue<string>("introducedversion"); }
            set
            {
                OnPropertyChanging("IntroducedVersion");
                SetAttributeValue("introducedversion", value);
                OnPropertyChanged("IntroducedVersion");
            }
        }

        /// <summary>
        ///     Information that specifies whether this component can be customized.
        /// </summary>
        [AttributeLogicalName("iscustomizable")]
        public BooleanManagedProperty IsCustomizable
        {
            get { return GetAttributeValue<BooleanManagedProperty>("iscustomizable"); }
            set
            {
                OnPropertyChanging("IsCustomizable");
                SetAttributeValue("iscustomizable", value);
                OnPropertyChanged("IsCustomizable");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("ismanaged")]
        public bool? IsManaged
        {
            get { return GetAttributeValue<bool?>("ismanaged"); }
        }

        /// <summary>
        ///     Name of the property on the Request message.
        /// </summary>
        [AttributeLogicalName("messagepropertyname")]
        public string MessagePropertyName
        {
            get { return GetAttributeValue<string>("messagepropertyname"); }
            set
            {
                OnPropertyChanging("MessagePropertyName");
                SetAttributeValue("messagepropertyname", value);
                OnPropertyChanged("MessagePropertyName");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the SDK message processing step.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the SDK message processing step was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the sdkmessageprocessingstepimage.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of SdkMessage processing step image.
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
        ///     Unique identifier of the organization with which the SDK message processing step is associated.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("overwritetime")]
        public DateTime? OverwriteTime
        {
            get { return GetAttributeValue<DateTime?>("overwritetime"); }
        }

        /// <summary>
        ///     Name of the related entity.
        /// </summary>
        [AttributeLogicalName("relatedattributename")]
        public string RelatedAttributeName
        {
            get { return GetAttributeValue<string>("relatedattributename"); }
            set
            {
                OnPropertyChanging("RelatedAttributeName");
                SetAttributeValue("relatedattributename", value);
                OnPropertyChanged("RelatedAttributeName");
            }
        }

        /// <summary>
        ///     Unique identifier of the SDK message processing step.
        /// </summary>
        [AttributeLogicalName("sdkmessageprocessingstepid")]
        public EntityReference SdkMessageProcessingStepId
        {
            get { return GetAttributeValue<EntityReference>("sdkmessageprocessingstepid"); }
            set
            {
                OnPropertyChanging("SdkMessageProcessingStepId");
                SetAttributeValue("sdkmessageprocessingstepid", value);
                OnPropertyChanged("SdkMessageProcessingStepId");
            }
        }

        /// <summary>
        ///     Unique identifier of the SDK message processing step image entity.
        /// </summary>
        [AttributeLogicalName("sdkmessageprocessingstepimageid")]
        public Guid? SdkMessageProcessingStepImageId
        {
            get { return GetAttributeValue<Guid?>("sdkmessageprocessingstepimageid"); }
            set
            {
                OnPropertyChanging("SdkMessageProcessingStepImageId");
                SetAttributeValue("sdkmessageprocessingstepimageid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("SdkMessageProcessingStepImageId");
            }
        }

        [AttributeLogicalName("sdkmessageprocessingstepimageid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { SdkMessageProcessingStepImageId = value; }
        }

        /// <summary>
        ///     Unique identifier of the SDK message processing step image.
        /// </summary>
        [AttributeLogicalName("sdkmessageprocessingstepimageidunique")]
        public Guid? SdkMessageProcessingStepImageIdUnique
        {
            get { return GetAttributeValue<Guid?>("sdkmessageprocessingstepimageidunique"); }
        }

        /// <summary>
        ///     Unique identifier of the associated solution.
        /// </summary>
        [AttributeLogicalName("solutionid")]
        public Guid? SolutionId
        {
            get { return GetAttributeValue<Guid?>("solutionid"); }
        }

        /// <summary>
        ///     Number that identifies a specific revision of the step image.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N userentityinstancedata_sdkmessageprocessingstepimage
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_sdkmessageprocessingstepimage")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_sdkmessageprocessingstepimage
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>(
                    "userentityinstancedata_sdkmessageprocessingstepimage", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_sdkmessageprocessingstepimage");
                SetRelatedEntities("userentityinstancedata_sdkmessageprocessingstepimage", null, value);
                OnPropertyChanged("userentityinstancedata_sdkmessageprocessingstepimage");
            }
        }

        /// <summary>
        ///     N:1 createdby_sdkmessageprocessingstepimage
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("createdby_sdkmessageprocessingstepimage")]
        public SystemUser createdby_sdkmessageprocessingstepimage
        {
            get { return GetRelatedEntity<SystemUser>("createdby_sdkmessageprocessingstepimage", null); }
        }

        /// <summary>
        ///     N:1 lk_sdkmessageprocessingstepimage_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_sdkmessageprocessingstepimage_createdonbehalfby")]
        public SystemUser lk_sdkmessageprocessingstepimage_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_sdkmessageprocessingstepimage_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_sdkmessageprocessingstepimage_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_sdkmessageprocessingstepimage_modifiedonbehalfby")]
        public SystemUser lk_sdkmessageprocessingstepimage_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_sdkmessageprocessingstepimage_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 modifiedby_sdkmessageprocessingstepimage
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("modifiedby_sdkmessageprocessingstepimage")]
        public SystemUser modifiedby_sdkmessageprocessingstepimage
        {
            get { return GetRelatedEntity<SystemUser>("modifiedby_sdkmessageprocessingstepimage", null); }
        }

        /// <summary>
        ///     N:1 organization_sdkmessageprocessingstepimage
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_sdkmessageprocessingstepimage")]
        public Organization organization_sdkmessageprocessingstepimage
        {
            get { return GetRelatedEntity<Organization>("organization_sdkmessageprocessingstepimage", null); }
        }

        /// <summary>
        ///     N:1 sdkmessageprocessingstepid_sdkmessageprocessingstepimage
        /// </summary>
        [AttributeLogicalName("sdkmessageprocessingstepid")]
        [RelationshipSchemaName("sdkmessageprocessingstepid_sdkmessageprocessingstepimage")]
        public SdkMessageProcessingStep sdkmessageprocessingstepid_sdkmessageprocessingstepimage
        {
            get
            {
                return
                    GetRelatedEntity<SdkMessageProcessingStep>(
                        "sdkmessageprocessingstepid_sdkmessageprocessingstepimage", null);
            }
            set
            {
                OnPropertyChanging("sdkmessageprocessingstepid_sdkmessageprocessingstepimage");
                SetRelatedEntity("sdkmessageprocessingstepid_sdkmessageprocessingstepimage", null, value);
                OnPropertyChanged("sdkmessageprocessingstepid_sdkmessageprocessingstepimage");
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