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
    ///     Service endpoint that can be contacted.
    /// </summary>
    [DataContract]
    [EntityLogicalName("serviceendpoint")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ServiceEndpoint : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "serviceendpoint";

        public const int EntityTypeCode = 4618;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ServiceEndpoint() :
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
        ///     Connection mode to contact the service endpoint.
        /// </summary>
        [AttributeLogicalName("connectionmode")]
        public OptionSetValue ConnectionMode
        {
            get { return GetAttributeValue<OptionSetValue>("connectionmode"); }
            set
            {
                OnPropertyChanging("ConnectionMode");
                SetAttributeValue("connectionmode", value);
                OnPropertyChanged("ConnectionMode");
            }
        }

        /// <summary>
        ///     Type of the endpoint contract.
        /// </summary>
        [AttributeLogicalName("contract")]
        public OptionSetValue Contract
        {
            get { return GetAttributeValue<OptionSetValue>("contract"); }
            set
            {
                OnPropertyChanging("Contract");
                SetAttributeValue("contract", value);
                OnPropertyChanged("Contract");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the service endpoint.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the service endpoint was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the service endpoint.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Description of the service endpoint.
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
        ///     Information that specifies whether this component is managed.
        /// </summary>
        [AttributeLogicalName("ismanaged")]
        public bool? IsManaged
        {
            get { return GetAttributeValue<bool?>("ismanaged"); }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the service endpoint.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the service endpoint was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who modified the service endpoint.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of Service end point.
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
        ///     Unique identifier of the organization with which the service endpoint is associated.
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
        ///     Path to the service endpoint.
        /// </summary>
        [AttributeLogicalName("path")]
        public string Path
        {
            get { return GetAttributeValue<string>("path"); }
            set
            {
                OnPropertyChanging("Path");
                SetAttributeValue("path", value);
                OnPropertyChanged("Path");
            }
        }

        /// <summary>
        ///     Unique identifier of the service endpoint.
        /// </summary>
        [AttributeLogicalName("serviceendpointid")]
        public Guid? ServiceEndpointId
        {
            get { return GetAttributeValue<Guid?>("serviceendpointid"); }
            set
            {
                OnPropertyChanging("ServiceEndpointId");
                SetAttributeValue("serviceendpointid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ServiceEndpointId");
            }
        }

        [AttributeLogicalName("serviceendpointid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ServiceEndpointId = value; }
        }

        /// <summary>
        ///     Unique identifier of the service endpoint.
        /// </summary>
        [AttributeLogicalName("serviceendpointidunique")]
        public Guid? ServiceEndpointIdUnique
        {
            get { return GetAttributeValue<Guid?>("serviceendpointidunique"); }
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
        ///     Namespace of the App Fabric solution.
        /// </summary>
        [AttributeLogicalName("solutionnamespace")]
        public string SolutionNamespace
        {
            get { return GetAttributeValue<string>("solutionnamespace"); }
            set
            {
                OnPropertyChanging("SolutionNamespace");
                SetAttributeValue("solutionnamespace", value);
                OnPropertyChanged("SolutionNamespace");
            }
        }

        /// <summary>
        ///     Additional user claim value type.
        /// </summary>
        [AttributeLogicalName("userclaim")]
        public OptionSetValue UserClaim
        {
            get { return GetAttributeValue<OptionSetValue>("userclaim"); }
            set
            {
                OnPropertyChanging("UserClaim");
                SetAttributeValue("userclaim", value);
                OnPropertyChanged("UserClaim");
            }
        }

        /// <summary>
        ///     1:N serviceendpoint_sdkmessageprocessingstep
        /// </summary>
        [RelationshipSchemaName("serviceendpoint_sdkmessageprocessingstep")]
        public IEnumerable<SdkMessageProcessingStep> serviceendpoint_sdkmessageprocessingstep
        {
            get
            {
                return GetRelatedEntities<SdkMessageProcessingStep>("serviceendpoint_sdkmessageprocessingstep", null);
            }
            set
            {
                OnPropertyChanging("serviceendpoint_sdkmessageprocessingstep");
                SetRelatedEntities("serviceendpoint_sdkmessageprocessingstep", null, value);
                OnPropertyChanged("serviceendpoint_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_serviceendpoint
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_serviceendpoint")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_serviceendpoint
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_serviceendpoint", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_serviceendpoint");
                SetRelatedEntities("userentityinstancedata_serviceendpoint", null, value);
                OnPropertyChanged("userentityinstancedata_serviceendpoint");
            }
        }

        /// <summary>
        ///     N:1 createdby_serviceendpoint
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("createdby_serviceendpoint")]
        public SystemUser createdby_serviceendpoint
        {
            get { return GetRelatedEntity<SystemUser>("createdby_serviceendpoint", null); }
        }

        /// <summary>
        ///     N:1 lk_serviceendpointbase_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_serviceendpointbase_createdonbehalfby")]
        public SystemUser lk_serviceendpointbase_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_serviceendpointbase_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_serviceendpointbase_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_serviceendpointbase_modifiedonbehalfby")]
        public SystemUser lk_serviceendpointbase_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_serviceendpointbase_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 modifiedby_serviceendpoint
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("modifiedby_serviceendpoint")]
        public SystemUser modifiedby_serviceendpoint
        {
            get { return GetRelatedEntity<SystemUser>("modifiedby_serviceendpoint", null); }
        }

        /// <summary>
        ///     N:1 organization_serviceendpoint
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_serviceendpoint")]
        public Organization organization_serviceendpoint
        {
            get { return GetRelatedEntity<Organization>("organization_serviceendpoint", null); }
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