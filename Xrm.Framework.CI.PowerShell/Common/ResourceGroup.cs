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
    ///     Resource group or team whose members can be scheduled for a service.
    /// </summary>
    [DataContract]
    [EntityLogicalName("resourcegroup")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ResourceGroup : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "resourcegroup";

        public const int EntityTypeCode = 4005;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ResourceGroup() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the business unit with which the scheduling group is associated.
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
        ///     Scheduling group type code.
        /// </summary>
        [AttributeLogicalName("grouptypecode")]
        public OptionSetValue GroupTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("grouptypecode"); }
        }

        /// <summary>
        ///     Name of the scheduling group.
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
        ///     Type of entity with which the scheduling group is associated.
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
        ///     Unique identifier of the organization associated with the scheduling group.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     Unique identifier of the scheduling group.
        /// </summary>
        [AttributeLogicalName("resourcegroupid")]
        public Guid? ResourceGroupId
        {
            get { return GetAttributeValue<Guid?>("resourcegroupid"); }
            set
            {
                OnPropertyChanging("ResourceGroupId");
                SetAttributeValue("resourcegroupid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ResourceGroupId");
            }
        }

        [AttributeLogicalName("resourcegroupid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ResourceGroupId = value; }
        }

        /// <summary>
        ///     Version number of the scheduling group.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N ResourceGroup_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("ResourceGroup_AsyncOperations")]
        public IEnumerable<AsyncOperation> ResourceGroup_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("ResourceGroup_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("ResourceGroup_AsyncOperations");
                SetRelatedEntities("ResourceGroup_AsyncOperations", null, value);
                OnPropertyChanged("ResourceGroup_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N ResourceGroup_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("ResourceGroup_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> ResourceGroup_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("ResourceGroup_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("ResourceGroup_BulkDeleteFailures");
                SetRelatedEntities("ResourceGroup_BulkDeleteFailures", null, value);
                OnPropertyChanged("ResourceGroup_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N resourcegroup_connections1
        /// </summary>
        [RelationshipSchemaName("resourcegroup_connections1")]
        public IEnumerable<Connection> resourcegroup_connections1
        {
            get { return GetRelatedEntities<Connection>("resourcegroup_connections1", null); }
            set
            {
                OnPropertyChanging("resourcegroup_connections1");
                SetRelatedEntities("resourcegroup_connections1", null, value);
                OnPropertyChanged("resourcegroup_connections1");
            }
        }

        /// <summary>
        ///     1:N resourcegroup_connections2
        /// </summary>
        [RelationshipSchemaName("resourcegroup_connections2")]
        public IEnumerable<Connection> resourcegroup_connections2
        {
            get { return GetRelatedEntities<Connection>("resourcegroup_connections2", null); }
            set
            {
                OnPropertyChanging("resourcegroup_connections2");
                SetRelatedEntities("resourcegroup_connections2", null, value);
                OnPropertyChanged("resourcegroup_connections2");
            }
        }

        /// <summary>
        ///     1:N ResourceGroup_DuplicateBaseRecord
        /// </summary>
        [RelationshipSchemaName("ResourceGroup_DuplicateBaseRecord")]
        public IEnumerable<DuplicateRecord> ResourceGroup_DuplicateBaseRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("ResourceGroup_DuplicateBaseRecord", null); }
            set
            {
                OnPropertyChanging("ResourceGroup_DuplicateBaseRecord");
                SetRelatedEntities("ResourceGroup_DuplicateBaseRecord", null, value);
                OnPropertyChanged("ResourceGroup_DuplicateBaseRecord");
            }
        }

        /// <summary>
        ///     1:N ResourceGroup_DuplicateMatchingRecord
        /// </summary>
        [RelationshipSchemaName("ResourceGroup_DuplicateMatchingRecord")]
        public IEnumerable<DuplicateRecord> ResourceGroup_DuplicateMatchingRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("ResourceGroup_DuplicateMatchingRecord", null); }
            set
            {
                OnPropertyChanging("ResourceGroup_DuplicateMatchingRecord");
                SetRelatedEntities("ResourceGroup_DuplicateMatchingRecord", null, value);
                OnPropertyChanged("ResourceGroup_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_resourcegroup
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_resourcegroup")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_resourcegroup
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_resourcegroup", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_resourcegroup");
                SetRelatedEntities("userentityinstancedata_resourcegroup", null, value);
                OnPropertyChanged("userentityinstancedata_resourcegroup");
            }
        }

        /// <summary>
        ///     N:1 business_unit_resource_groups
        /// </summary>
        [AttributeLogicalName("businessunitid")]
        [RelationshipSchemaName("business_unit_resource_groups")]
        public BusinessUnit business_unit_resource_groups
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_resource_groups", null); }
            set
            {
                OnPropertyChanging("business_unit_resource_groups");
                SetRelatedEntity("business_unit_resource_groups", null, value);
                OnPropertyChanged("business_unit_resource_groups");
            }
        }

        /// <summary>
        ///     N:1 constraintbasedgroup_resource_groups
        /// </summary>
        [AttributeLogicalName("resourcegroupid")]
        [RelationshipSchemaName("constraintbasedgroup_resource_groups")]
        public ConstraintBasedGroup constraintbasedgroup_resource_groups
        {
            get { return GetRelatedEntity<ConstraintBasedGroup>("constraintbasedgroup_resource_groups", null); }
            set
            {
                OnPropertyChanging("constraintbasedgroup_resource_groups");
                SetRelatedEntity("constraintbasedgroup_resource_groups", null, value);
                OnPropertyChanged("constraintbasedgroup_resource_groups");
            }
        }

        /// <summary>
        ///     N:1 organization_resource_groups
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_resource_groups")]
        public Organization organization_resource_groups
        {
            get { return GetRelatedEntity<Organization>("organization_resource_groups", null); }
        }

        /// <summary>
        ///     N:1 team_resource_groups
        /// </summary>
        [AttributeLogicalName("resourcegroupid")]
        [RelationshipSchemaName("team_resource_groups")]
        public Team team_resource_groups
        {
            get { return GetRelatedEntity<Team>("team_resource_groups", null); }
            set
            {
                OnPropertyChanging("team_resource_groups");
                SetRelatedEntity("team_resource_groups", null, value);
                OnPropertyChanged("team_resource_groups");
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