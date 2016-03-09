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
    ///     Data equivalent to files used in Web development. Web resources provide client-side components that are used to
    ///     provide custom user interface elements.
    /// </summary>
    [DataContract]
    [EntityLogicalName("webresource")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class WebResource : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "webresource";

        public const int EntityTypeCode = 9333;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public WebResource() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Information that specifies whether this component can be deleted.
        /// </summary>
        [AttributeLogicalName("canbedeleted")]
        public BooleanManagedProperty CanBeDeleted
        {
            get { return GetAttributeValue<BooleanManagedProperty>("canbedeleted"); }
            set
            {
                OnPropertyChanging("CanBeDeleted");
                SetAttributeValue("canbedeleted", value);
                OnPropertyChanged("CanBeDeleted");
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
        ///     Bytes of the web resource, in Base64 format.
        /// </summary>
        [AttributeLogicalName("content")]
        public string Content
        {
            get { return GetAttributeValue<string>("content"); }
            set
            {
                OnPropertyChanging("Content");
                SetAttributeValue("content", value);
                OnPropertyChanged("Content");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the web resource.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the web resource was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the web resource.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Description of the web resource.
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
        ///     Display name of the web resource.
        /// </summary>
        [AttributeLogicalName("displayname")]
        public string DisplayName
        {
            get { return GetAttributeValue<string>("displayname"); }
            set
            {
                OnPropertyChanging("DisplayName");
                SetAttributeValue("displayname", value);
                OnPropertyChanged("DisplayName");
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
        ///     Information that specifies whether this component should be hidden.
        /// </summary>
        [AttributeLogicalName("ishidden")]
        public BooleanManagedProperty IsHidden
        {
            get { return GetAttributeValue<BooleanManagedProperty>("ishidden"); }
            set
            {
                OnPropertyChanging("IsHidden");
                SetAttributeValue("ishidden", value);
                OnPropertyChanged("IsHidden");
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
        ///     Language of the web resource.
        /// </summary>
        [AttributeLogicalName("languagecode")]
        public int? LanguageCode
        {
            get { return GetAttributeValue<int?>("languagecode"); }
            set
            {
                OnPropertyChanging("LanguageCode");
                SetAttributeValue("languagecode", value);
                OnPropertyChanged("LanguageCode");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the web resource.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the web resource was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who modified the web resource.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the web resource.
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
        ///     Unique identifier of the organization associated with the web resource.
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
        ///     Silverlight runtime version number required by a silverlight web resource.
        /// </summary>
        [AttributeLogicalName("silverlightversion")]
        public string SilverlightVersion
        {
            get { return GetAttributeValue<string>("silverlightversion"); }
            set
            {
                OnPropertyChanging("SilverlightVersion");
                SetAttributeValue("silverlightversion", value);
                OnPropertyChanged("SilverlightVersion");
            }
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
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     Unique identifier of the web resource.
        /// </summary>
        [AttributeLogicalName("webresourceid")]
        public Guid? WebResourceId
        {
            get { return GetAttributeValue<Guid?>("webresourceid"); }
            set
            {
                OnPropertyChanging("WebResourceId");
                SetAttributeValue("webresourceid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("WebResourceId");
            }
        }

        [AttributeLogicalName("webresourceid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { WebResourceId = value; }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("webresourceidunique")]
        public Guid? WebResourceIdUnique
        {
            get { return GetAttributeValue<Guid?>("webresourceidunique"); }
        }

        /// <summary>
        ///     Drop-down list for selecting the type of the web resource.
        /// </summary>
        [AttributeLogicalName("webresourcetype")]
        public OptionSetValue WebResourceType
        {
            get { return GetAttributeValue<OptionSetValue>("webresourcetype"); }
            set
            {
                OnPropertyChanging("WebResourceType");
                SetAttributeValue("webresourcetype", value);
                OnPropertyChanged("WebResourceType");
            }
        }

        /// <summary>
        ///     1:N solution_configuration_webresource
        /// </summary>
        [RelationshipSchemaName("solution_configuration_webresource")]
        public IEnumerable<Solution> solution_configuration_webresource
        {
            get { return GetRelatedEntities<Solution>("solution_configuration_webresource", null); }
            set
            {
                OnPropertyChanging("solution_configuration_webresource");
                SetRelatedEntities("solution_configuration_webresource", null, value);
                OnPropertyChanged("solution_configuration_webresource");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_webresource
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_webresource")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_webresource
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_webresource", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_webresource");
                SetRelatedEntities("userentityinstancedata_webresource", null, value);
                OnPropertyChanged("userentityinstancedata_webresource");
            }
        }

        /// <summary>
        ///     1:N webresource_savedqueryvisualizations
        /// </summary>
        [RelationshipSchemaName("webresource_savedqueryvisualizations")]
        public IEnumerable<SavedQueryVisualization> webresource_savedqueryvisualizations
        {
            get { return GetRelatedEntities<SavedQueryVisualization>("webresource_savedqueryvisualizations", null); }
            set
            {
                OnPropertyChanging("webresource_savedqueryvisualizations");
                SetRelatedEntities("webresource_savedqueryvisualizations", null, value);
                OnPropertyChanged("webresource_savedqueryvisualizations");
            }
        }

        /// <summary>
        ///     1:N webresource_userqueryvisualizations
        /// </summary>
        [RelationshipSchemaName("webresource_userqueryvisualizations")]
        public IEnumerable<UserQueryVisualization> webresource_userqueryvisualizations
        {
            get { return GetRelatedEntities<UserQueryVisualization>("webresource_userqueryvisualizations", null); }
            set
            {
                OnPropertyChanging("webresource_userqueryvisualizations");
                SetRelatedEntities("webresource_userqueryvisualizations", null, value);
                OnPropertyChanged("webresource_userqueryvisualizations");
            }
        }

        /// <summary>
        ///     N:1 lk_webresourcebase_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_webresourcebase_createdonbehalfby")]
        public SystemUser lk_webresourcebase_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_webresourcebase_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_webresourcebase_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_webresourcebase_modifiedonbehalfby")]
        public SystemUser lk_webresourcebase_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_webresourcebase_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 webresource_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("webresource_createdby")]
        public SystemUser webresource_createdby
        {
            get { return GetRelatedEntity<SystemUser>("webresource_createdby", null); }
        }

        /// <summary>
        ///     N:1 webresource_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("webresource_modifiedby")]
        public SystemUser webresource_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("webresource_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 webresource_organization
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("webresource_organization")]
        public Organization webresource_organization
        {
            get { return GetRelatedEntity<Organization>("webresource_organization", null); }
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