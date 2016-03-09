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
    ///     System chart attached to an entity.
    /// </summary>
    [DataContract]
    [EntityLogicalName("savedqueryvisualization")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class SavedQueryVisualization : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "savedqueryvisualization";

        public const int EntityTypeCode = 1111;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public SavedQueryVisualization() :
            base(EntityLogicalName)
        {
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
        ///     Unique identifier of the user who created the system chart.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the system chart was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the system chart.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     XML string used to define the underlying data for the system chart.
        /// </summary>
        [AttributeLogicalName("datadescription")]
        public string DataDescription
        {
            get { return GetAttributeValue<string>("datadescription"); }
            set
            {
                OnPropertyChanging("DataDescription");
                SetAttributeValue("datadescription", value);
                OnPropertyChanged("DataDescription");
            }
        }

        /// <summary>
        ///     Description of the system chart.
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
        ///     Indicates whether the system chart is the default chart for the entity.
        /// </summary>
        [AttributeLogicalName("isdefault")]
        public bool? IsDefault
        {
            get { return GetAttributeValue<bool?>("isdefault"); }
            set
            {
                OnPropertyChanging("IsDefault");
                SetAttributeValue("isdefault", value);
                OnPropertyChanged("IsDefault");
            }
        }

        /// <summary>
        ///     Indicates whether the solution component is part of a managed solution.
        /// </summary>
        [AttributeLogicalName("ismanaged")]
        public bool? IsManaged
        {
            get { return GetAttributeValue<bool?>("ismanaged"); }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the system chart.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the system chart was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the system chart.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the system chart.
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
        ///     Unique identifier of the organization associated with the system chart.
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
        ///     XML string used to define the presentation properties of the system chart.
        /// </summary>
        [AttributeLogicalName("presentationdescription")]
        public string PresentationDescription
        {
            get { return GetAttributeValue<string>("presentationdescription"); }
            set
            {
                OnPropertyChanging("PresentationDescription");
                SetAttributeValue("presentationdescription", value);
                OnPropertyChanged("PresentationDescription");
            }
        }

        /// <summary>
        ///     Type of entity with which the system chart is attached.
        /// </summary>
        [AttributeLogicalName("primaryentitytypecode")]
        public string PrimaryEntityTypeCode
        {
            get { return GetAttributeValue<string>("primaryentitytypecode"); }
            set
            {
                OnPropertyChanging("PrimaryEntityTypeCode");
                SetAttributeValue("primaryentitytypecode", value);
                OnPropertyChanged("PrimaryEntityTypeCode");
            }
        }

        /// <summary>
        ///     Unique identifier of the system chart.
        /// </summary>
        [AttributeLogicalName("savedqueryvisualizationid")]
        public Guid? SavedQueryVisualizationId
        {
            get { return GetAttributeValue<Guid?>("savedqueryvisualizationid"); }
            set
            {
                OnPropertyChanging("SavedQueryVisualizationId");
                SetAttributeValue("savedqueryvisualizationid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("SavedQueryVisualizationId");
            }
        }

        [AttributeLogicalName("savedqueryvisualizationid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { SavedQueryVisualizationId = value; }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("savedqueryvisualizationidunique")]
        public Guid? SavedQueryVisualizationIdUnique
        {
            get { return GetAttributeValue<Guid?>("savedqueryvisualizationidunique"); }
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
        ///     Version number of the system chart.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     Unique identifier of the Web resource that will be displayed in the system chart.
        /// </summary>
        [AttributeLogicalName("webresourceid")]
        public EntityReference WebResourceId
        {
            get { return GetAttributeValue<EntityReference>("webresourceid"); }
            set
            {
                OnPropertyChanging("WebResourceId");
                SetAttributeValue("webresourceid", value);
                OnPropertyChanged("WebResourceId");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_savedqueryvisualization
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_savedqueryvisualization")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_savedqueryvisualization
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_savedqueryvisualization", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_savedqueryvisualization");
                SetRelatedEntities("userentityinstancedata_savedqueryvisualization", null, value);
                OnPropertyChanged("userentityinstancedata_savedqueryvisualization");
            }
        }

        /// <summary>
        ///     N:1 lk_savedqueryvisualizationbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_savedqueryvisualizationbase_createdby")]
        public SystemUser lk_savedqueryvisualizationbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_savedqueryvisualizationbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_savedqueryvisualizationbase_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_savedqueryvisualizationbase_createdonbehalfby")]
        public SystemUser lk_savedqueryvisualizationbase_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_savedqueryvisualizationbase_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_savedqueryvisualizationbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_savedqueryvisualizationbase_modifiedby")]
        public SystemUser lk_savedqueryvisualizationbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_savedqueryvisualizationbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_savedqueryvisualizationbase_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_savedqueryvisualizationbase_modifiedonbehalfby")]
        public SystemUser lk_savedqueryvisualizationbase_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_savedqueryvisualizationbase_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 organization_saved_query_visualizations
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_saved_query_visualizations")]
        public Organization organization_saved_query_visualizations
        {
            get { return GetRelatedEntity<Organization>("organization_saved_query_visualizations", null); }
        }

        /// <summary>
        ///     N:1 webresource_savedqueryvisualizations
        /// </summary>
        [AttributeLogicalName("webresourceid")]
        [RelationshipSchemaName("webresource_savedqueryvisualizations")]
        public WebResource webresource_savedqueryvisualizations
        {
            get { return GetRelatedEntity<WebResource>("webresource_savedqueryvisualizations", null); }
            set
            {
                OnPropertyChanging("webresource_savedqueryvisualizations");
                SetRelatedEntity("webresource_savedqueryvisualizations", null, value);
                OnPropertyChanged("webresource_savedqueryvisualizations");
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