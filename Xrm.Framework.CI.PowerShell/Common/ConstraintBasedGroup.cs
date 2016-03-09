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
    ///     Group or collection of people, equipment, and/or facilities that can be scheduled.
    /// </summary>
    [DataContract]
    [EntityLogicalName("constraintbasedgroup")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ConstraintBasedGroup : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "constraintbasedgroup";

        public const int EntityTypeCode = 4007;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ConstraintBasedGroup() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Shows the business unit that the record owner belongs to.
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
        ///     Unique identifier of the resource group.
        /// </summary>
        [AttributeLogicalName("constraintbasedgroupid")]
        public Guid? ConstraintBasedGroupId
        {
            get { return GetAttributeValue<Guid?>("constraintbasedgroupid"); }
            set
            {
                OnPropertyChanging("ConstraintBasedGroupId");
                SetAttributeValue("constraintbasedgroupid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ConstraintBasedGroupId");
            }
        }

        [AttributeLogicalName("constraintbasedgroupid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ConstraintBasedGroupId = value; }
        }

        /// <summary>
        ///     Shows the constraints defined for the users, equipment, teams, and other resource groups included as resources for
        ///     the group, stored in XML format.
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
        ///     Unique identifier of the user who created the resource group.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the resource group was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the constraintbasedgroup.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Type additional information to describe the resource group, such as the intended use or associated resource types.
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
        ///     Shows whether the resource group is static, dynamic or hidden. Hidden groups are for system use only and are not
        ///     viewable in Microsoft Dynamics CRM.
        /// </summary>
        [AttributeLogicalName("grouptypecode")]
        public OptionSetValue GroupTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("grouptypecode"); }
            set
            {
                OnPropertyChanging("GroupTypeCode");
                SetAttributeValue("grouptypecode", value);
                OnPropertyChanged("GroupTypeCode");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the resource group.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the resource group was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the constraintbasedgroup.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Type a title or name that describes the resource group.
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
        ///     Unique identifier of the organization associated with the resource group.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N constraint_based_group_resource_specs
        /// </summary>
        [RelationshipSchemaName("constraint_based_group_resource_specs")]
        public IEnumerable<ResourceSpec> constraint_based_group_resource_specs
        {
            get { return GetRelatedEntities<ResourceSpec>("constraint_based_group_resource_specs", null); }
            set
            {
                OnPropertyChanging("constraint_based_group_resource_specs");
                SetRelatedEntities("constraint_based_group_resource_specs", null, value);
                OnPropertyChanged("constraint_based_group_resource_specs");
            }
        }

        /// <summary>
        ///     1:N ConstraintBasedGroup_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("ConstraintBasedGroup_AsyncOperations")]
        public IEnumerable<AsyncOperation> ConstraintBasedGroup_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("ConstraintBasedGroup_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("ConstraintBasedGroup_AsyncOperations");
                SetRelatedEntities("ConstraintBasedGroup_AsyncOperations", null, value);
                OnPropertyChanged("ConstraintBasedGroup_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N ConstraintBasedGroup_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("ConstraintBasedGroup_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> ConstraintBasedGroup_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("ConstraintBasedGroup_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("ConstraintBasedGroup_BulkDeleteFailures");
                SetRelatedEntities("ConstraintBasedGroup_BulkDeleteFailures", null, value);
                OnPropertyChanged("ConstraintBasedGroup_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N constraintbasedgroup_connections1
        /// </summary>
        [RelationshipSchemaName("constraintbasedgroup_connections1")]
        public IEnumerable<Connection> constraintbasedgroup_connections1
        {
            get { return GetRelatedEntities<Connection>("constraintbasedgroup_connections1", null); }
            set
            {
                OnPropertyChanging("constraintbasedgroup_connections1");
                SetRelatedEntities("constraintbasedgroup_connections1", null, value);
                OnPropertyChanged("constraintbasedgroup_connections1");
            }
        }

        /// <summary>
        ///     1:N constraintbasedgroup_connections2
        /// </summary>
        [RelationshipSchemaName("constraintbasedgroup_connections2")]
        public IEnumerable<Connection> constraintbasedgroup_connections2
        {
            get { return GetRelatedEntities<Connection>("constraintbasedgroup_connections2", null); }
            set
            {
                OnPropertyChanging("constraintbasedgroup_connections2");
                SetRelatedEntities("constraintbasedgroup_connections2", null, value);
                OnPropertyChanged("constraintbasedgroup_connections2");
            }
        }

        /// <summary>
        ///     1:N ConstraintBasedGroup_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("ConstraintBasedGroup_ProcessSessions")]
        public IEnumerable<ProcessSession> ConstraintBasedGroup_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("ConstraintBasedGroup_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("ConstraintBasedGroup_ProcessSessions");
                SetRelatedEntities("ConstraintBasedGroup_ProcessSessions", null, value);
                OnPropertyChanged("ConstraintBasedGroup_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N constraintbasedgroup_resource_groups
        /// </summary>
        [RelationshipSchemaName("constraintbasedgroup_resource_groups")]
        public IEnumerable<ResourceGroup> constraintbasedgroup_resource_groups
        {
            get { return GetRelatedEntities<ResourceGroup>("constraintbasedgroup_resource_groups", null); }
            set
            {
                OnPropertyChanging("constraintbasedgroup_resource_groups");
                SetRelatedEntities("constraintbasedgroup_resource_groups", null, value);
                OnPropertyChanged("constraintbasedgroup_resource_groups");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_constraintbasedgroup
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_constraintbasedgroup")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_constraintbasedgroup
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_constraintbasedgroup", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_constraintbasedgroup");
                SetRelatedEntities("userentityinstancedata_constraintbasedgroup", null, value);
                OnPropertyChanged("userentityinstancedata_constraintbasedgroup");
            }
        }

        /// <summary>
        ///     N:1 business_unit_constraint_based_groups
        /// </summary>
        [AttributeLogicalName("businessunitid")]
        [RelationshipSchemaName("business_unit_constraint_based_groups")]
        public BusinessUnit business_unit_constraint_based_groups
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_constraint_based_groups", null); }
            set
            {
                OnPropertyChanging("business_unit_constraint_based_groups");
                SetRelatedEntity("business_unit_constraint_based_groups", null, value);
                OnPropertyChanged("business_unit_constraint_based_groups");
            }
        }

        /// <summary>
        ///     N:1 constraintbasedgroup_systemuser
        /// </summary>
        [AttributeLogicalName("businessunitid")]
        [RelationshipSchemaName("constraintbasedgroup_systemuser")]
        public SystemUser constraintbasedgroup_systemuser
        {
            get { return GetRelatedEntity<SystemUser>("constraintbasedgroup_systemuser", null); }
            set
            {
                OnPropertyChanging("constraintbasedgroup_systemuser");
                SetRelatedEntity("constraintbasedgroup_systemuser", null, value);
                OnPropertyChanged("constraintbasedgroup_systemuser");
            }
        }

        /// <summary>
        ///     N:1 lk_constraintbasedgroup_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_constraintbasedgroup_createdby")]
        public SystemUser lk_constraintbasedgroup_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_constraintbasedgroup_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_constraintbasedgroup_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_constraintbasedgroup_createdonbehalfby")]
        public SystemUser lk_constraintbasedgroup_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_constraintbasedgroup_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_constraintbasedgroup_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_constraintbasedgroup_modifiedby")]
        public SystemUser lk_constraintbasedgroup_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_constraintbasedgroup_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_constraintbasedgroup_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_constraintbasedgroup_modifiedonbehalfby")]
        public SystemUser lk_constraintbasedgroup_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_constraintbasedgroup_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 organization_constraint_based_groups
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_constraint_based_groups")]
        public Organization organization_constraint_based_groups
        {
            get { return GetRelatedEntity<Organization>("organization_constraint_based_groups", null); }
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