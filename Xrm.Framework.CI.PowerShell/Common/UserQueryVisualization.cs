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
    ///     Chart attached to an entity.
    /// </summary>
    [DataContract]
    [EntityLogicalName("userqueryvisualization")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class UserQueryVisualization : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "userqueryvisualization";

        public const int EntityTypeCode = 1112;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public UserQueryVisualization() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Shows who created the record.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Shows the date and time when the record was created. The date and time are displayed in the time zone selected in
        ///     Microsoft Dynamics CRM options.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Shows who created the record on behalf of another user.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Shows the fields that are used to display data in a chart, stored in XML format.
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
        ///     Type additional information to describe the chart, such as the filter criteria or intended audience.
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
        ///     Select whether the chart is the default chart for the view that it is associated with.
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
        ///     Shows who last updated the record.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected
        ///     in Microsoft Dynamics CRM options.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Shows who created the record on behalf of another user.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Type a descriptive name for the chart.
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
        ///     Enter the user or team who is assigned to manage the record. This field is updated every time the record is
        ///     assigned to a different user.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId
        {
            get { return GetAttributeValue<EntityReference>("ownerid"); }
            set
            {
                OnPropertyChanging("OwnerId");
                SetAttributeValue("ownerid", value);
                OnPropertyChanged("OwnerId");
            }
        }

        /// <summary>
        ///     Shows the business unit that the record owner belongs to.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the user chart.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the user chart.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Contains the chart's formatting details and presentation properties, stored in XML format.
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
        ///     Type of entity which the user chart is attached.
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
        ///     Unique identifier of the user chart.
        /// </summary>
        [AttributeLogicalName("userqueryvisualizationid")]
        public Guid? UserQueryVisualizationId
        {
            get { return GetAttributeValue<Guid?>("userqueryvisualizationid"); }
            set
            {
                OnPropertyChanging("UserQueryVisualizationId");
                SetAttributeValue("userqueryvisualizationid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("UserQueryVisualizationId");
            }
        }

        [AttributeLogicalName("userqueryvisualizationid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { UserQueryVisualizationId = value; }
        }

        /// <summary>
        ///     Version number of the user chart.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     Shows the web resource that will be displayed in the chart to the user.
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
        ///     1:N userentityinstancedata_userqueryvisualization
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_userqueryvisualization")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_userqueryvisualization
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_userqueryvisualization", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_userqueryvisualization");
                SetRelatedEntities("userentityinstancedata_userqueryvisualization", null, value);
                OnPropertyChanged("userentityinstancedata_userqueryvisualization");
            }
        }

        /// <summary>
        ///     N:1 business_unit_userqueryvisualizations
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_userqueryvisualizations")]
        public BusinessUnit business_unit_userqueryvisualizations
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_userqueryvisualizations", null); }
        }

        /// <summary>
        ///     N:1 lk_userqueryvisualization_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_userqueryvisualization_createdby")]
        public SystemUser lk_userqueryvisualization_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_userqueryvisualization_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_userqueryvisualization_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_userqueryvisualization_modifiedby")]
        public SystemUser lk_userqueryvisualization_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_userqueryvisualization_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_userqueryvisualizationbase_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_userqueryvisualizationbase_createdonbehalfby")]
        public SystemUser lk_userqueryvisualizationbase_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_userqueryvisualizationbase_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_userqueryvisualizationbase_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_userqueryvisualizationbase_modifiedonbehalfby")]
        public SystemUser lk_userqueryvisualizationbase_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_userqueryvisualizationbase_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 team_userqueryvisualizations
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_userqueryvisualizations")]
        public Team team_userqueryvisualizations
        {
            get { return GetRelatedEntity<Team>("team_userqueryvisualizations", null); }
        }

        /// <summary>
        ///     N:1 user_userqueryvisualizations
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_userqueryvisualizations")]
        public SystemUser user_userqueryvisualizations
        {
            get { return GetRelatedEntity<SystemUser>("user_userqueryvisualizations", null); }
        }

        /// <summary>
        ///     N:1 webresource_userqueryvisualizations
        /// </summary>
        [AttributeLogicalName("webresourceid")]
        [RelationshipSchemaName("webresource_userqueryvisualizations")]
        public WebResource webresource_userqueryvisualizations
        {
            get { return GetRelatedEntity<WebResource>("webresource_userqueryvisualizations", null); }
            set
            {
                OnPropertyChanging("webresource_userqueryvisualizations");
                SetRelatedEntity("webresource_userqueryvisualizations", null, value);
                OnPropertyChanged("webresource_userqueryvisualizations");
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