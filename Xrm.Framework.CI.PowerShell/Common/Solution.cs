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
    ///     A solution which contains CRM customizations.
    /// </summary>
    [DataContract]
    [EntityLogicalName("solution")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Solution : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "solution";

        public const int EntityTypeCode = 7100;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Solution() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     A link to an optional configuration page for this solution.
        /// </summary>
        [AttributeLogicalName("configurationpageid")]
        public EntityReference ConfigurationPageId
        {
            get { return GetAttributeValue<EntityReference>("configurationpageid"); }
            set
            {
                OnPropertyChanging("ConfigurationPageId");
                SetAttributeValue("configurationpageid", value);
                OnPropertyChanged("ConfigurationPageId");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the solution.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the solution was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the solution.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Description of the solution.
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
        ///     User display name for the solution.
        /// </summary>
        [AttributeLogicalName("friendlyname")]
        public string FriendlyName
        {
            get { return GetAttributeValue<string>("friendlyname"); }
            set
            {
                OnPropertyChanging("FriendlyName");
                SetAttributeValue("friendlyname", value);
                OnPropertyChanged("FriendlyName");
            }
        }

        /// <summary>
        ///     Date and time when the solution was installed/upgraded.
        /// </summary>
        [AttributeLogicalName("installedon")]
        public DateTime? InstalledOn
        {
            get { return GetAttributeValue<DateTime?>("installedon"); }
        }

        /// <summary>
        ///     Indicates whether the solution is managed or unmanaged.
        /// </summary>
        [AttributeLogicalName("ismanaged")]
        public bool? IsManaged
        {
            get { return GetAttributeValue<bool?>("ismanaged"); }
        }

        /// <summary>
        ///     Indicates whether the solution is visible outside of the platform.
        /// </summary>
        [AttributeLogicalName("isvisible")]
        public bool? IsVisible
        {
            get { return GetAttributeValue<bool?>("isvisible"); }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the solution.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the solution was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who modified the solution.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the organization associated with the solution.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("pinpointassetid")]
        public string PinpointAssetId
        {
            get { return GetAttributeValue<string>("pinpointassetid"); }
        }

        /// <summary>
        ///     Identifier of the publisher of this solution in Microsoft Pinpoint.
        /// </summary>
        [AttributeLogicalName("pinpointpublisherid")]
        public long? PinpointPublisherId
        {
            get { return GetAttributeValue<long?>("pinpointpublisherid"); }
        }

        /// <summary>
        ///     Default locale of the solution in Microsoft Pinpoint.
        /// </summary>
        [AttributeLogicalName("pinpointsolutiondefaultlocale")]
        public string PinpointSolutionDefaultLocale
        {
            get { return GetAttributeValue<string>("pinpointsolutiondefaultlocale"); }
        }

        /// <summary>
        ///     Identifier of the solution in Microsoft Pinpoint.
        /// </summary>
        [AttributeLogicalName("pinpointsolutionid")]
        public long? PinpointSolutionId
        {
            get { return GetAttributeValue<long?>("pinpointsolutionid"); }
        }

        /// <summary>
        ///     Unique identifier of the publisher.
        /// </summary>
        [AttributeLogicalName("publisherid")]
        public EntityReference PublisherId
        {
            get { return GetAttributeValue<EntityReference>("publisherid"); }
            set
            {
                OnPropertyChanging("PublisherId");
                SetAttributeValue("publisherid", value);
                OnPropertyChanged("PublisherId");
            }
        }

        /// <summary>
        ///     Unique identifier of the solution.
        /// </summary>
        [AttributeLogicalName("solutionid")]
        public Guid? SolutionId
        {
            get { return GetAttributeValue<Guid?>("solutionid"); }
            set
            {
                OnPropertyChanging("SolutionId");
                SetAttributeValue("solutionid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("SolutionId");
            }
        }

        [AttributeLogicalName("solutionid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { SolutionId = value; }
        }

        /// <summary>
        ///     The unique name of this solution
        /// </summary>
        [AttributeLogicalName("uniquename")]
        public string UniqueName
        {
            get { return GetAttributeValue<string>("uniquename"); }
            set
            {
                OnPropertyChanging("UniqueName");
                SetAttributeValue("uniquename", value);
                OnPropertyChanged("UniqueName");
            }
        }

        /// <summary>
        ///     Solution version, used to identify a solution for upgrades and hotfixes.
        /// </summary>
        [AttributeLogicalName("version")]
        public string Version
        {
            get { return GetAttributeValue<string>("version"); }
            set
            {
                OnPropertyChanging("Version");
                SetAttributeValue("version", value);
                OnPropertyChanged("Version");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N solution_solutioncomponent
        /// </summary>
        [RelationshipSchemaName("solution_solutioncomponent")]
        public IEnumerable<SolutionComponent> solution_solutioncomponent
        {
            get { return GetRelatedEntities<SolutionComponent>("solution_solutioncomponent", null); }
            set
            {
                OnPropertyChanging("solution_solutioncomponent");
                SetRelatedEntities("solution_solutioncomponent", null, value);
                OnPropertyChanged("solution_solutioncomponent");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_solution
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_solution")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_solution
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_solution", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_solution");
                SetRelatedEntities("userentityinstancedata_solution", null, value);
                OnPropertyChanged("userentityinstancedata_solution");
            }
        }

        /// <summary>
        ///     N:1 lk_solution_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_solution_createdby")]
        public SystemUser lk_solution_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_solution_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_solution_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_solution_modifiedby")]
        public SystemUser lk_solution_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_solution_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_solutionbase_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_solutionbase_createdonbehalfby")]
        public SystemUser lk_solutionbase_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_solutionbase_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_solutionbase_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_solutionbase_modifiedonbehalfby")]
        public SystemUser lk_solutionbase_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_solutionbase_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 organization_solution
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_solution")]
        public Organization organization_solution
        {
            get { return GetRelatedEntity<Organization>("organization_solution", null); }
        }

        /// <summary>
        ///     N:1 publisher_solution
        /// </summary>
        [AttributeLogicalName("publisherid")]
        [RelationshipSchemaName("publisher_solution")]
        public Publisher publisher_solution
        {
            get { return GetRelatedEntity<Publisher>("publisher_solution", null); }
            set
            {
                OnPropertyChanging("publisher_solution");
                SetRelatedEntity("publisher_solution", null, value);
                OnPropertyChanged("publisher_solution");
            }
        }

        /// <summary>
        ///     N:1 solution_configuration_webresource
        /// </summary>
        [AttributeLogicalName("configurationpageid")]
        [RelationshipSchemaName("solution_configuration_webresource")]
        public WebResource solution_configuration_webresource
        {
            get { return GetRelatedEntity<WebResource>("solution_configuration_webresource", null); }
            set
            {
                OnPropertyChanging("solution_configuration_webresource");
                SetRelatedEntity("solution_configuration_webresource", null, value);
                OnPropertyChanged("solution_configuration_webresource");
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