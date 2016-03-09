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
    ///     Selection rule that allows the scheduling engine to select a number of resources from a pool of resources. The
    ///     rules can be associated with a service.
    /// </summary>
    [DataContract]
    [EntityLogicalName("resourcespec")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ResourceSpec : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "resourcespec";

        public const int EntityTypeCode = 4006;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ResourceSpec() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the business unit with which the resource specification is associated.
        /// </summary>
        [AttributeLogicalName("businessunitid")]
        public EntityReference BusinessUnitId
        {
            get { return GetAttributeValue<EntityReference>("businessunitid"); }
            set
            {
                OnPropertyChanging("BusinessUnitId");
                SetAttributeValue("businessunitid", value);
                OnPropertyChanged("BusinessUnitId");
            }
        }

        /// <summary>
        ///     Additional constraints, specified as expressions, which are used to filter a set of valid resources.
        /// </summary>
        [AttributeLogicalName("constraints")]
        public string Constraints
        {
            get { return GetAttributeValue<string>("constraints"); }
            set
            {
                OnPropertyChanging("Constraints");
                SetAttributeValue("constraints", value);
                OnPropertyChanged("Constraints");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the resource specification.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the resource specification was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the resourcespec.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Selection rule that allows the scheduling engine to select a number of resources from a pool of resources. The
        ///     rules can be associated with a service.
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
        ///     Number that specifies the minimal effort required from resources.
        /// </summary>
        [AttributeLogicalName("effortrequired")]
        public double? EffortRequired
        {
            get { return GetAttributeValue<double?>("effortrequired"); }
            set
            {
                OnPropertyChanging("EffortRequired");
                SetAttributeValue("effortrequired", value);
                OnPropertyChanged("EffortRequired");
            }
        }

        /// <summary>
        ///     Unique identifier of the scheduling group with which the resource specification is associated.
        /// </summary>
        [AttributeLogicalName("groupobjectid")]
        public Guid? GroupObjectId
        {
            get { return GetAttributeValue<Guid?>("groupobjectid"); }
            set
            {
                OnPropertyChanging("GroupObjectId");
                SetAttributeValue("groupobjectid", value);
                OnPropertyChanged("GroupObjectId");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the resource specification.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the resource specification was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the resourcespec.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the resource specification.
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
        ///     Search strategy to use for the resource specification.
        /// </summary>
        [AttributeLogicalName("objectiveexpression")]
        public string ObjectiveExpression
        {
            get { return GetAttributeValue<string>("objectiveexpression"); }
            set
            {
                OnPropertyChanging("ObjectiveExpression");
                SetAttributeValue("objectiveexpression", value);
                OnPropertyChanged("ObjectiveExpression");
            }
        }

        /// <summary>
        ///     Type of entity with which the resource specification is associated.
        /// </summary>
        [AttributeLogicalName("objecttypecode")]
        public string ObjectTypeCode
        {
            get { return GetAttributeValue<string>("objecttypecode"); }
            set
            {
                OnPropertyChanging("ObjectTypeCode");
                SetAttributeValue("objecttypecode", value);
                OnPropertyChanged("ObjectTypeCode");
            }
        }

        /// <summary>
        ///     Unique identifier of the organization with which the resource specification is associated.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     Required number of resources that must be available. Use -1 to indicate all resources.
        /// </summary>
        [AttributeLogicalName("requiredcount")]
        public int? RequiredCount
        {
            get { return GetAttributeValue<int?>("requiredcount"); }
            set
            {
                OnPropertyChanging("RequiredCount");
                SetAttributeValue("requiredcount", value);
                OnPropertyChanged("RequiredCount");
            }
        }

        /// <summary>
        ///     Unique identifier of the resource specification.
        /// </summary>
        [AttributeLogicalName("resourcespecid")]
        public Guid? ResourceSpecId
        {
            get { return GetAttributeValue<Guid?>("resourcespecid"); }
            set
            {
                OnPropertyChanging("ResourceSpecId");
                SetAttributeValue("resourcespecid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ResourceSpecId");
            }
        }

        [AttributeLogicalName("resourcespecid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ResourceSpecId = value; }
        }

        /// <summary>
        ///     Value that specifies that all valid and available resources must be in the same site.
        /// </summary>
        [AttributeLogicalName("samesite")]
        public bool? SameSite
        {
            get { return GetAttributeValue<bool?>("samesite"); }
            set
            {
                OnPropertyChanging("SameSite");
                SetAttributeValue("samesite", value);
                OnPropertyChanged("SameSite");
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
        ///     1:N ActivityPartyResourceSpec
        /// </summary>
        [RelationshipSchemaName("ActivityPartyResourceSpec")]
        public IEnumerable<ActivityParty> ActivityPartyResourceSpec
        {
            get { return GetRelatedEntities<ActivityParty>("ActivityPartyResourceSpec", null); }
            set
            {
                OnPropertyChanging("ActivityPartyResourceSpec");
                SetRelatedEntities("ActivityPartyResourceSpec", null, value);
                OnPropertyChanged("ActivityPartyResourceSpec");
            }
        }

        /// <summary>
        ///     1:N resource_spec_services
        /// </summary>
        [RelationshipSchemaName("resource_spec_services")]
        public IEnumerable<Service> resource_spec_services
        {
            get { return GetRelatedEntities<Service>("resource_spec_services", null); }
            set
            {
                OnPropertyChanging("resource_spec_services");
                SetRelatedEntities("resource_spec_services", null, value);
                OnPropertyChanged("resource_spec_services");
            }
        }

        /// <summary>
        ///     1:N ResourceSpec_Annotation
        /// </summary>
        [RelationshipSchemaName("ResourceSpec_Annotation")]
        public IEnumerable<Annotation> ResourceSpec_Annotation
        {
            get { return GetRelatedEntities<Annotation>("ResourceSpec_Annotation", null); }
            set
            {
                OnPropertyChanging("ResourceSpec_Annotation");
                SetRelatedEntities("ResourceSpec_Annotation", null, value);
                OnPropertyChanged("ResourceSpec_Annotation");
            }
        }

        /// <summary>
        ///     1:N ResourceSpec_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("ResourceSpec_AsyncOperations")]
        public IEnumerable<AsyncOperation> ResourceSpec_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("ResourceSpec_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("ResourceSpec_AsyncOperations");
                SetRelatedEntities("ResourceSpec_AsyncOperations", null, value);
                OnPropertyChanged("ResourceSpec_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N ResourceSpec_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("ResourceSpec_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> ResourceSpec_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("ResourceSpec_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("ResourceSpec_BulkDeleteFailures");
                SetRelatedEntities("ResourceSpec_BulkDeleteFailures", null, value);
                OnPropertyChanged("ResourceSpec_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N resourcespec_resources
        /// </summary>
        [RelationshipSchemaName("resourcespec_resources")]
        public IEnumerable<Resource> resourcespec_resources
        {
            get { return GetRelatedEntities<Resource>("resourcespec_resources", null); }
            set
            {
                OnPropertyChanging("resourcespec_resources");
                SetRelatedEntities("resourcespec_resources", null, value);
                OnPropertyChanged("resourcespec_resources");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_resourcespec
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_resourcespec")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_resourcespec
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_resourcespec", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_resourcespec");
                SetRelatedEntities("userentityinstancedata_resourcespec", null, value);
                OnPropertyChanged("userentityinstancedata_resourcespec");
            }
        }

        /// <summary>
        ///     N:1 business_unit_resource_specs
        /// </summary>
        [AttributeLogicalName("businessunitid")]
        [RelationshipSchemaName("business_unit_resource_specs")]
        public BusinessUnit business_unit_resource_specs
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_resource_specs", null); }
            set
            {
                OnPropertyChanging("business_unit_resource_specs");
                SetRelatedEntity("business_unit_resource_specs", null, value);
                OnPropertyChanged("business_unit_resource_specs");
            }
        }

        /// <summary>
        ///     N:1 constraint_based_group_resource_specs
        /// </summary>
        [AttributeLogicalName("groupobjectid")]
        [RelationshipSchemaName("constraint_based_group_resource_specs")]
        public ConstraintBasedGroup constraint_based_group_resource_specs
        {
            get { return GetRelatedEntity<ConstraintBasedGroup>("constraint_based_group_resource_specs", null); }
            set
            {
                OnPropertyChanging("constraint_based_group_resource_specs");
                SetRelatedEntity("constraint_based_group_resource_specs", null, value);
                OnPropertyChanged("constraint_based_group_resource_specs");
            }
        }

        /// <summary>
        ///     N:1 lk_resourcespec_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_resourcespec_createdby")]
        public SystemUser lk_resourcespec_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_resourcespec_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_resourcespec_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_resourcespec_createdonbehalfby")]
        public SystemUser lk_resourcespec_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_resourcespec_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_resourcespec_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_resourcespec_modifiedby")]
        public SystemUser lk_resourcespec_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_resourcespec_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_resourcespec_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_resourcespec_modifiedonbehalfby")]
        public SystemUser lk_resourcespec_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_resourcespec_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 organization_resource_specs
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_resource_specs")]
        public Organization organization_resource_specs
        {
            get { return GetRelatedEntity<Organization>("organization_resource_specs", null); }
        }

        /// <summary>
        ///     N:1 team_resource_specs
        /// </summary>
        [AttributeLogicalName("groupobjectid")]
        [RelationshipSchemaName("team_resource_specs")]
        public Team team_resource_specs
        {
            get { return GetRelatedEntity<Team>("team_resource_specs", null); }
            set
            {
                OnPropertyChanging("team_resource_specs");
                SetRelatedEntity("team_resource_specs", null, value);
                OnPropertyChanged("team_resource_specs");
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