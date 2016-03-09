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
    ///     Role describing a relationship between a two records.
    /// </summary>
    [DataContract]
    [EntityLogicalName("connectionrole")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ConnectionRole : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "connectionrole";

        public const int EntityTypeCode = 3231;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ConnectionRole() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Categories for connection roles.
        /// </summary>
        [AttributeLogicalName("category")]
        public OptionSetValue Category
        {
            get { return GetAttributeValue<OptionSetValue>("category"); }
            set
            {
                OnPropertyChanging("Category");
                SetAttributeValue("category", value);
                OnPropertyChanged("Category");
            }
        }

        /// <summary>
        ///     State of the component.
        /// </summary>
        [AttributeLogicalName("componentstate")]
        public OptionSetValue ComponentState
        {
            get { return GetAttributeValue<OptionSetValue>("componentstate"); }
        }

        /// <summary>
        ///     Unique identifier of the connection role.
        /// </summary>
        [AttributeLogicalName("connectionroleid")]
        public Guid? ConnectionRoleId
        {
            get { return GetAttributeValue<Guid?>("connectionroleid"); }
            set
            {
                OnPropertyChanging("ConnectionRoleId");
                SetAttributeValue("connectionroleid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ConnectionRoleId");
            }
        }

        [AttributeLogicalName("connectionroleid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ConnectionRoleId = value; }
        }

        /// <summary>
        ///     Unique identifier of the published or unpublished connection role record.
        /// </summary>
        [AttributeLogicalName("connectionroleidunique")]
        public Guid? ConnectionRoleIdUnique
        {
            get { return GetAttributeValue<Guid?>("connectionroleidunique"); }
        }

        /// <summary>
        ///     Unique identifier of the user who created the relationship role.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the connection role was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the relationship role.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Description of the connection role.
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
        ///     Indicates whether the solution component is part of a managed solution.
        /// </summary>
        [AttributeLogicalName("ismanaged")]
        public bool? IsManaged
        {
            get { return GetAttributeValue<bool?>("ismanaged"); }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the connection role.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the connection role was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who modified the relationship role.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the connection role.
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
        ///     Unique identifier of the organization that this connection role belongs to.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     Date and time when the record was last overwritten.
        /// </summary>
        [AttributeLogicalName("overwritetime")]
        public DateTime? OverwriteTime
        {
            get { return GetAttributeValue<DateTime?>("overwritetime"); }
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
        ///     Status of the connection role.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public ConnectionRoleState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ConnectionRoleState) (Enum.ToObject(typeof (ConnectionRoleState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the connection role.
        /// </summary>
        [AttributeLogicalName("statuscode")]
        public OptionSetValue StatusCode
        {
            get { return GetAttributeValue<OptionSetValue>("statuscode"); }
            set
            {
                OnPropertyChanging("StatusCode");
                SetAttributeValue("statuscode", value);
                OnPropertyChanged("StatusCode");
            }
        }

        /// <summary>
        ///     Version number of the connection role.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N Connection_Role_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Connection_Role_AsyncOperations")]
        public IEnumerable<AsyncOperation> Connection_Role_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Connection_Role_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Connection_Role_AsyncOperations");
                SetRelatedEntities("Connection_Role_AsyncOperations", null, value);
                OnPropertyChanged("Connection_Role_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N connection_role_connection_role_object_type_codes
        /// </summary>
        [RelationshipSchemaName("connection_role_connection_role_object_type_codes")]
        public IEnumerable<ConnectionRoleObjectTypeCode> connection_role_connection_role_object_type_codes
        {
            get
            {
                return
                    GetRelatedEntities<ConnectionRoleObjectTypeCode>(
                        "connection_role_connection_role_object_type_codes", null);
            }
            set
            {
                OnPropertyChanging("connection_role_connection_role_object_type_codes");
                SetRelatedEntities("connection_role_connection_role_object_type_codes", null, value);
                OnPropertyChanged("connection_role_connection_role_object_type_codes");
            }
        }

        /// <summary>
        ///     1:N connection_role_connections1
        /// </summary>
        [RelationshipSchemaName("connection_role_connections1")]
        public IEnumerable<Connection> connection_role_connections1
        {
            get { return GetRelatedEntities<Connection>("connection_role_connections1", null); }
            set
            {
                OnPropertyChanging("connection_role_connections1");
                SetRelatedEntities("connection_role_connections1", null, value);
                OnPropertyChanged("connection_role_connections1");
            }
        }

        /// <summary>
        ///     1:N connection_role_connections2
        /// </summary>
        [RelationshipSchemaName("connection_role_connections2")]
        public IEnumerable<Connection> connection_role_connections2
        {
            get { return GetRelatedEntities<Connection>("connection_role_connections2", null); }
            set
            {
                OnPropertyChanging("connection_role_connections2");
                SetRelatedEntities("connection_role_connections2", null, value);
                OnPropertyChanged("connection_role_connections2");
            }
        }

        /// <summary>
        ///     1:N ConnectionRole_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("ConnectionRole_ProcessSessions")]
        public IEnumerable<ProcessSession> ConnectionRole_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("ConnectionRole_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("ConnectionRole_ProcessSessions");
                SetRelatedEntities("ConnectionRole_ProcessSessions", null, value);
                OnPropertyChanged("ConnectionRole_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_connectionrole
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_connectionrole")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_connectionrole
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_connectionrole", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_connectionrole");
                SetRelatedEntities("userentityinstancedata_connectionrole", null, value);
                OnPropertyChanged("userentityinstancedata_connectionrole");
            }
        }

        /// <summary>
        ///     N:N connectionroleassociation_association
        /// </summary>
        [RelationshipSchemaName("connectionroleassociation_association", EntityRole.Referencing)]
        public IEnumerable<ConnectionRole> Referencingconnectionroleassociation_association
        {
            get
            {
                return GetRelatedEntities<ConnectionRole>("connectionroleassociation_association",
                    EntityRole.Referencing);
            }
            set
            {
                OnPropertyChanging("Referencingconnectionroleassociation_association");
                SetRelatedEntities("connectionroleassociation_association", EntityRole.Referencing, value);
                OnPropertyChanged("Referencingconnectionroleassociation_association");
            }
        }

        /// <summary>
        ///     N:N connectionroleassociation_association
        /// </summary>
        [RelationshipSchemaName("connectionroleassociation_association", EntityRole.Referenced)]
        public IEnumerable<ConnectionRole> Referencedconnectionroleassociation_association
        {
            get
            {
                return GetRelatedEntities<ConnectionRole>("connectionroleassociation_association", EntityRole.Referenced);
            }
            set
            {
                OnPropertyChanging("Referencedconnectionroleassociation_association");
                SetRelatedEntities("connectionroleassociation_association", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedconnectionroleassociation_association");
            }
        }

        /// <summary>
        ///     N:1 createdby_connection_role
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("createdby_connection_role")]
        public SystemUser createdby_connection_role
        {
            get { return GetRelatedEntity<SystemUser>("createdby_connection_role", null); }
        }

        /// <summary>
        ///     N:1 lk_connectionrolebase_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_connectionrolebase_createdonbehalfby")]
        public SystemUser lk_connectionrolebase_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_connectionrolebase_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_connectionrolebase_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_connectionrolebase_modifiedonbehalfby")]
        public SystemUser lk_connectionrolebase_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_connectionrolebase_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 modifiedby_connection_role
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("modifiedby_connection_role")]
        public SystemUser modifiedby_connection_role
        {
            get { return GetRelatedEntity<SystemUser>("modifiedby_connection_role", null); }
        }

        /// <summary>
        ///     N:1 organization_connection_roles
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_connection_roles")]
        public Organization organization_connection_roles
        {
            get { return GetRelatedEntity<Organization>("organization_connection_roles", null); }
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