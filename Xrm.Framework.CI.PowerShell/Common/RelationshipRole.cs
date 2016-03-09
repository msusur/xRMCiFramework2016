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
    ///     Relationship between an account or contact and an opportunity.
    /// </summary>
    [DataContract]
    [EntityLogicalName("relationshiprole")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class RelationshipRole : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "relationshiprole";

        public const int EntityTypeCode = 4500;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public RelationshipRole() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique Identifier of the user who created the relationship role.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the relationship role was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the relationshiprole.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Description of the relationship role.
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
        ///     Unique identifier of the user who last modified the relationship role.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the relationship role was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the relationshiprole.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the relationship role.
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
        ///     Unique Identifier of the organization that this relationship role belongs to.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     Unique identifier of the relationship role.
        /// </summary>
        [AttributeLogicalName("relationshiproleid")]
        public Guid? RelationshipRoleId
        {
            get { return GetAttributeValue<Guid?>("relationshiproleid"); }
            set
            {
                OnPropertyChanging("RelationshipRoleId");
                SetAttributeValue("relationshiproleid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("RelationshipRoleId");
            }
        }

        [AttributeLogicalName("relationshiproleid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { RelationshipRoleId = value; }
        }

        /// <summary>
        ///     Status of the relationship role.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public RelationshipRoleState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((RelationshipRoleState) (Enum.ToObject(typeof (RelationshipRoleState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the relationship role.
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
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N relationship_role_customer_opportunity_roles
        /// </summary>
        [RelationshipSchemaName("relationship_role_customer_opportunity_roles")]
        public IEnumerable<CustomerOpportunityRole> relationship_role_customer_opportunity_roles
        {
            get
            {
                return GetRelatedEntities<CustomerOpportunityRole>("relationship_role_customer_opportunity_roles", null);
            }
            set
            {
                OnPropertyChanging("relationship_role_customer_opportunity_roles");
                SetRelatedEntities("relationship_role_customer_opportunity_roles", null, value);
                OnPropertyChanged("relationship_role_customer_opportunity_roles");
            }
        }

        /// <summary>
        ///     1:N relationship_role_customer_role
        /// </summary>
        [RelationshipSchemaName("relationship_role_customer_role")]
        public IEnumerable<CustomerRelationship> relationship_role_customer_role
        {
            get { return GetRelatedEntities<CustomerRelationship>("relationship_role_customer_role", null); }
            set
            {
                OnPropertyChanging("relationship_role_customer_role");
                SetRelatedEntities("relationship_role_customer_role", null, value);
                OnPropertyChanged("relationship_role_customer_role");
            }
        }

        /// <summary>
        ///     1:N relationship_role_partner_role
        /// </summary>
        [RelationshipSchemaName("relationship_role_partner_role")]
        public IEnumerable<CustomerRelationship> relationship_role_partner_role
        {
            get { return GetRelatedEntities<CustomerRelationship>("relationship_role_partner_role", null); }
            set
            {
                OnPropertyChanging("relationship_role_partner_role");
                SetRelatedEntities("relationship_role_partner_role", null, value);
                OnPropertyChanged("relationship_role_partner_role");
            }
        }

        /// <summary>
        ///     1:N relationship_role_relationship_role_map
        /// </summary>
        [RelationshipSchemaName("relationship_role_relationship_role_map")]
        public IEnumerable<RelationshipRoleMap> relationship_role_relationship_role_map
        {
            get { return GetRelatedEntities<RelationshipRoleMap>("relationship_role_relationship_role_map", null); }
            set
            {
                OnPropertyChanging("relationship_role_relationship_role_map");
                SetRelatedEntities("relationship_role_relationship_role_map", null, value);
                OnPropertyChanged("relationship_role_relationship_role_map");
            }
        }

        /// <summary>
        ///     1:N RelationshipRole_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("RelationshipRole_AsyncOperations")]
        public IEnumerable<AsyncOperation> RelationshipRole_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("RelationshipRole_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("RelationshipRole_AsyncOperations");
                SetRelatedEntities("RelationshipRole_AsyncOperations", null, value);
                OnPropertyChanged("RelationshipRole_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N RelationshipRole_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("RelationshipRole_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> RelationshipRole_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("RelationshipRole_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("RelationshipRole_BulkDeleteFailures");
                SetRelatedEntities("RelationshipRole_BulkDeleteFailures", null, value);
                OnPropertyChanged("RelationshipRole_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N RelationshipRole_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("RelationshipRole_ProcessSessions")]
        public IEnumerable<ProcessSession> RelationshipRole_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("RelationshipRole_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("RelationshipRole_ProcessSessions");
                SetRelatedEntities("RelationshipRole_ProcessSessions", null, value);
                OnPropertyChanged("RelationshipRole_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_relationshiprole
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_relationshiprole")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_relationshiprole
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_relationshiprole", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_relationshiprole");
                SetRelatedEntities("userentityinstancedata_relationshiprole", null, value);
                OnPropertyChanged("userentityinstancedata_relationshiprole");
            }
        }

        /// <summary>
        ///     N:1 createdby_relationship_role
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("createdby_relationship_role")]
        public SystemUser createdby_relationship_role
        {
            get { return GetRelatedEntity<SystemUser>("createdby_relationship_role", null); }
        }

        /// <summary>
        ///     N:1 lk_relationshiprole_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_relationshiprole_createdonbehalfby")]
        public SystemUser lk_relationshiprole_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_relationshiprole_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_relationshiprole_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_relationshiprole_modifiedonbehalfby")]
        public SystemUser lk_relationshiprole_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_relationshiprole_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 modifiedby_relationship_role
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("modifiedby_relationship_role")]
        public SystemUser modifiedby_relationship_role
        {
            get { return GetRelatedEntity<SystemUser>("modifiedby_relationship_role", null); }
        }

        /// <summary>
        ///     N:1 organization_relationship_roles
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_relationship_roles")]
        public Organization organization_relationship_roles
        {
            get { return GetRelatedEntity<Organization>("organization_relationship_roles", null); }
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