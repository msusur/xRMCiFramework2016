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
    ///     Mapping of the primary associated objects between which the relationship role is valid.
    /// </summary>
    [DataContract]
    [EntityLogicalName("relationshiprolemap")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class RelationshipRoleMap : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "relationshiprolemap";

        public const int EntityTypeCode = 4501;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public RelationshipRoleMap() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Type of the associated entity in the relationship role mapping.
        /// </summary>
        [AttributeLogicalName("associateobjecttypecode")]
        public string AssociateObjectTypeCode
        {
            get { return GetAttributeValue<string>("associateobjecttypecode"); }
            set
            {
                OnPropertyChanging("AssociateObjectTypeCode");
                SetAttributeValue("associateobjecttypecode", value);
                OnPropertyChanged("AssociateObjectTypeCode");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the relationship role map.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the relationship role map was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the relationshiprolemap.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the relationship role map.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the relationship role map record was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the relationshiprolemap.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the organization with which the relationship role map is associated.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public Guid? OrganizationId
        {
            get { return GetAttributeValue<Guid?>("organizationid"); }
        }

        /// <summary>
        ///     Type of the primary entity in the relationship role mapping.
        /// </summary>
        [AttributeLogicalName("primaryobjecttypecode")]
        public string PrimaryObjectTypeCode
        {
            get { return GetAttributeValue<string>("primaryobjecttypecode"); }
            set
            {
                OnPropertyChanging("PrimaryObjectTypeCode");
                SetAttributeValue("primaryobjecttypecode", value);
                OnPropertyChanged("PrimaryObjectTypeCode");
            }
        }

        /// <summary>
        ///     Unique identifier of the relationship role. This relationship role is only valid in a relationship between an
        ///     entity of type specified in the primaryobjecttypecode property and an entity of type specified in the
        ///     associateobjecttypecode property.
        /// </summary>
        [AttributeLogicalName("relationshiproleid")]
        public EntityReference RelationshipRoleId
        {
            get { return GetAttributeValue<EntityReference>("relationshiproleid"); }
            set
            {
                OnPropertyChanging("RelationshipRoleId");
                SetAttributeValue("relationshiproleid", value);
                OnPropertyChanged("RelationshipRoleId");
            }
        }

        /// <summary>
        ///     Unique identifier of the relationship role map.
        /// </summary>
        [AttributeLogicalName("relationshiprolemapid")]
        public Guid? RelationshipRoleMapId
        {
            get { return GetAttributeValue<Guid?>("relationshiprolemapid"); }
            set
            {
                OnPropertyChanging("RelationshipRoleMapId");
                SetAttributeValue("relationshiprolemapid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("RelationshipRoleMapId");
            }
        }

        [AttributeLogicalName("relationshiprolemapid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { RelationshipRoleMapId = value; }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N RelationshipRoleMap_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("RelationshipRoleMap_AsyncOperations")]
        public IEnumerable<AsyncOperation> RelationshipRoleMap_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("RelationshipRoleMap_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("RelationshipRoleMap_AsyncOperations");
                SetRelatedEntities("RelationshipRoleMap_AsyncOperations", null, value);
                OnPropertyChanged("RelationshipRoleMap_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N RelationshipRoleMap_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("RelationshipRoleMap_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> RelationshipRoleMap_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("RelationshipRoleMap_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("RelationshipRoleMap_BulkDeleteFailures");
                SetRelatedEntities("RelationshipRoleMap_BulkDeleteFailures", null, value);
                OnPropertyChanged("RelationshipRoleMap_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_relationshiprolemap
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_relationshiprolemap")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_relationshiprolemap
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_relationshiprolemap", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_relationshiprolemap");
                SetRelatedEntities("userentityinstancedata_relationshiprolemap", null, value);
                OnPropertyChanged("userentityinstancedata_relationshiprolemap");
            }
        }

        /// <summary>
        ///     N:1 createdby_relationship_role_map
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("createdby_relationship_role_map")]
        public SystemUser createdby_relationship_role_map
        {
            get { return GetRelatedEntity<SystemUser>("createdby_relationship_role_map", null); }
        }

        /// <summary>
        ///     N:1 lk_relationshiprolemap_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_relationshiprolemap_createdonbehalfby")]
        public SystemUser lk_relationshiprolemap_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_relationshiprolemap_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_relationshiprolemap_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_relationshiprolemap_modifiedonbehalfby")]
        public SystemUser lk_relationshiprolemap_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_relationshiprolemap_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 modifiedby_relationship_role_map
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("modifiedby_relationship_role_map")]
        public SystemUser modifiedby_relationship_role_map
        {
            get { return GetRelatedEntity<SystemUser>("modifiedby_relationship_role_map", null); }
        }

        /// <summary>
        ///     N:1 relationship_role_relationship_role_map
        /// </summary>
        [AttributeLogicalName("relationshiproleid")]
        [RelationshipSchemaName("relationship_role_relationship_role_map")]
        public RelationshipRole relationship_role_relationship_role_map
        {
            get { return GetRelatedEntity<RelationshipRole>("relationship_role_relationship_role_map", null); }
            set
            {
                OnPropertyChanging("relationship_role_relationship_role_map");
                SetRelatedEntity("relationship_role_relationship_role_map", null, value);
                OnPropertyChanged("relationship_role_relationship_role_map");
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