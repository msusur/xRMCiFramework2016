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
    ///     Grouping of security privileges. Users are assigned roles that authorize their access to the Microsoft CRM system.
    /// </summary>
    [DataContract]
    [EntityLogicalName("role")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Role : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "role";

        public const int EntityTypeCode = 1036;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Role() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the business unit with which the role is associated.
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
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("componentstate")]
        public OptionSetValue ComponentState
        {
            get { return GetAttributeValue<OptionSetValue>("componentstate"); }
        }

        /// <summary>
        ///     Unique identifier of the user who created the role.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the role was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the role.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the data import or data migration that created this record.
        /// </summary>
        [AttributeLogicalName("importsequencenumber")]
        public int? ImportSequenceNumber
        {
            get { return GetAttributeValue<int?>("importsequencenumber"); }
            set
            {
                OnPropertyChanging("ImportSequenceNumber");
                SetAttributeValue("importsequencenumber", value);
                OnPropertyChanged("ImportSequenceNumber");
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
        ///     Indicates whether the solution component is part of a managed solution.
        /// </summary>
        [AttributeLogicalName("ismanaged")]
        public bool? IsManaged
        {
            get { return GetAttributeValue<bool?>("ismanaged"); }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the role.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the role was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the role.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the role.
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
        ///     Unique identifier of the organization associated with the role.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public Guid? OrganizationId
        {
            get { return GetAttributeValue<Guid?>("organizationid"); }
        }

        /// <summary>
        ///     Date and time that the record was migrated.
        /// </summary>
        [AttributeLogicalName("overriddencreatedon")]
        public DateTime? OverriddenCreatedOn
        {
            get { return GetAttributeValue<DateTime?>("overriddencreatedon"); }
            set
            {
                OnPropertyChanging("OverriddenCreatedOn");
                SetAttributeValue("overriddencreatedon", value);
                OnPropertyChanged("OverriddenCreatedOn");
            }
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
        ///     Unique identifier of the parent role.
        /// </summary>
        [AttributeLogicalName("parentroleid")]
        public EntityReference ParentRoleId
        {
            get { return GetAttributeValue<EntityReference>("parentroleid"); }
        }

        /// <summary>
        ///     Unique identifier of the parent root role.
        /// </summary>
        [AttributeLogicalName("parentrootroleid")]
        public EntityReference ParentRootRoleId
        {
            get { return GetAttributeValue<EntityReference>("parentrootroleid"); }
        }

        /// <summary>
        ///     Unique identifier of the role.
        /// </summary>
        [AttributeLogicalName("roleid")]
        public Guid? RoleId
        {
            get { return GetAttributeValue<Guid?>("roleid"); }
            set
            {
                OnPropertyChanging("RoleId");
                SetAttributeValue("roleid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("RoleId");
            }
        }

        [AttributeLogicalName("roleid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { RoleId = value; }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("roleidunique")]
        public Guid? RoleIdUnique
        {
            get { return GetAttributeValue<Guid?>("roleidunique"); }
        }

        /// <summary>
        ///     Unique identifier of the role template that is associated with the role.
        /// </summary>
        [AttributeLogicalName("roletemplateid")]
        public EntityReference RoleTemplateId
        {
            get { return GetAttributeValue<EntityReference>("roletemplateid"); }
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
        ///     Version number of the role.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N Role_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Role_AsyncOperations")]
        public IEnumerable<AsyncOperation> Role_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Role_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Role_AsyncOperations");
                SetRelatedEntities("Role_AsyncOperations", null, value);
                OnPropertyChanged("Role_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N Role_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("Role_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> Role_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("Role_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("Role_BulkDeleteFailures");
                SetRelatedEntities("Role_BulkDeleteFailures", null, value);
                OnPropertyChanged("Role_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N role_parent_role
        /// </summary>
        [RelationshipSchemaName("role_parent_role", EntityRole.Referenced)]
        public IEnumerable<Role> Referencedrole_parent_role
        {
            get { return GetRelatedEntities<Role>("role_parent_role", EntityRole.Referenced); }
            set
            {
                OnPropertyChanging("Referencedrole_parent_role");
                SetRelatedEntities("role_parent_role", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedrole_parent_role");
            }
        }

        /// <summary>
        ///     1:N role_parent_root_role
        /// </summary>
        [RelationshipSchemaName("role_parent_root_role", EntityRole.Referenced)]
        public IEnumerable<Role> Referencedrole_parent_root_role
        {
            get { return GetRelatedEntities<Role>("role_parent_root_role", EntityRole.Referenced); }
            set
            {
                OnPropertyChanging("Referencedrole_parent_root_role");
                SetRelatedEntities("role_parent_root_role", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedrole_parent_root_role");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_role
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_role")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_role
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_role", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_role");
                SetRelatedEntities("userentityinstancedata_role", null, value);
                OnPropertyChanged("userentityinstancedata_role");
            }
        }

        /// <summary>
        ///     N:N roleprivileges_association
        /// </summary>
        [RelationshipSchemaName("roleprivileges_association")]
        public IEnumerable<Privilege> roleprivileges_association
        {
            get { return GetRelatedEntities<Privilege>("roleprivileges_association", null); }
            set
            {
                OnPropertyChanging("roleprivileges_association");
                SetRelatedEntities("roleprivileges_association", null, value);
                OnPropertyChanged("roleprivileges_association");
            }
        }

        /// <summary>
        ///     N:N systemuserroles_association
        /// </summary>
        [RelationshipSchemaName("systemuserroles_association")]
        public IEnumerable<SystemUser> systemuserroles_association
        {
            get { return GetRelatedEntities<SystemUser>("systemuserroles_association", null); }
            set
            {
                OnPropertyChanging("systemuserroles_association");
                SetRelatedEntities("systemuserroles_association", null, value);
                OnPropertyChanged("systemuserroles_association");
            }
        }

        /// <summary>
        ///     N:N teamroles_association
        /// </summary>
        [RelationshipSchemaName("teamroles_association")]
        public IEnumerable<Team> teamroles_association
        {
            get { return GetRelatedEntities<Team>("teamroles_association", null); }
            set
            {
                OnPropertyChanging("teamroles_association");
                SetRelatedEntities("teamroles_association", null, value);
                OnPropertyChanged("teamroles_association");
            }
        }

        /// <summary>
        ///     N:1 business_unit_roles
        /// </summary>
        [AttributeLogicalName("businessunitid")]
        [RelationshipSchemaName("business_unit_roles")]
        public BusinessUnit business_unit_roles
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_roles", null); }
            set
            {
                OnPropertyChanging("business_unit_roles");
                SetRelatedEntity("business_unit_roles", null, value);
                OnPropertyChanged("business_unit_roles");
            }
        }

        /// <summary>
        ///     N:1 lk_role_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_role_createdonbehalfby")]
        public SystemUser lk_role_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_role_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_role_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_role_modifiedonbehalfby")]
        public SystemUser lk_role_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_role_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_rolebase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_rolebase_createdby")]
        public SystemUser lk_rolebase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_rolebase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_rolebase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_rolebase_modifiedby")]
        public SystemUser lk_rolebase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_rolebase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 organization_roles
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_roles")]
        public Organization organization_roles
        {
            get { return GetRelatedEntity<Organization>("organization_roles", null); }
        }

        /// <summary>
        ///     N:1 role_parent_role
        /// </summary>
        [AttributeLogicalName("parentroleid")]
        [RelationshipSchemaName("role_parent_role", EntityRole.Referencing)]
        public Role Referencingrole_parent_role
        {
            get { return GetRelatedEntity<Role>("role_parent_role", EntityRole.Referencing); }
        }

        /// <summary>
        ///     N:1 role_parent_root_role
        /// </summary>
        [AttributeLogicalName("parentrootroleid")]
        [RelationshipSchemaName("role_parent_root_role", EntityRole.Referencing)]
        public Role Referencingrole_parent_root_role
        {
            get { return GetRelatedEntity<Role>("role_parent_root_role", EntityRole.Referencing); }
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