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
    ///     Represents a mapping between two related entities so that data from one record can be copied into the form of a new
    ///     related record.
    /// </summary>
    [DataContract]
    [EntityLogicalName("entitymap")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class EntityMap : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "entitymap";

        public const int EntityTypeCode = 4600;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public EntityMap() :
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
        ///     Unique identifier of the user who created the entity map.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the entity map was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the entitymap.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the entity map.
        /// </summary>
        [AttributeLogicalName("entitymapid")]
        public Guid? EntityMapId
        {
            get { return GetAttributeValue<Guid?>("entitymapid"); }
            set
            {
                OnPropertyChanging("EntityMapId");
                SetAttributeValue("entitymapid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("EntityMapId");
            }
        }

        [AttributeLogicalName("entitymapid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { EntityMapId = value; }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("entitymapidunique")]
        public Guid? EntityMapIdUnique
        {
            get { return GetAttributeValue<Guid?>("entitymapidunique"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("ismanaged")]
        public bool? IsManaged
        {
            get { return GetAttributeValue<bool?>("ismanaged"); }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the entity map.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the entity map was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the entitymap.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the organization with which the entity map is associated.
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
        ///     Unique identifier of the associated solution.
        /// </summary>
        [AttributeLogicalName("solutionid")]
        public Guid? SolutionId
        {
            get { return GetAttributeValue<Guid?>("solutionid"); }
        }

        /// <summary>
        ///     Name of the source entity for the entity mapping.
        /// </summary>
        [AttributeLogicalName("sourceentityname")]
        public string SourceEntityName
        {
            get { return GetAttributeValue<string>("sourceentityname"); }
            set
            {
                OnPropertyChanging("SourceEntityName");
                SetAttributeValue("sourceentityname", value);
                OnPropertyChanged("SourceEntityName");
            }
        }

        /// <summary>
        ///     Name of the Microsoft Dynamics CRM entity.
        /// </summary>
        [AttributeLogicalName("targetentityname")]
        public string TargetEntityName
        {
            get { return GetAttributeValue<string>("targetentityname"); }
            set
            {
                OnPropertyChanging("TargetEntityName");
                SetAttributeValue("targetentityname", value);
                OnPropertyChanged("TargetEntityName");
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
        ///     1:N entity_map_attribute_maps
        /// </summary>
        [RelationshipSchemaName("entity_map_attribute_maps")]
        public IEnumerable<AttributeMap> entity_map_attribute_maps
        {
            get { return GetRelatedEntities<AttributeMap>("entity_map_attribute_maps", null); }
            set
            {
                OnPropertyChanging("entity_map_attribute_maps");
                SetRelatedEntities("entity_map_attribute_maps", null, value);
                OnPropertyChanged("entity_map_attribute_maps");
            }
        }

        /// <summary>
        ///     1:N EntityMap_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("EntityMap_AsyncOperations")]
        public IEnumerable<AsyncOperation> EntityMap_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("EntityMap_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("EntityMap_AsyncOperations");
                SetRelatedEntities("EntityMap_AsyncOperations", null, value);
                OnPropertyChanged("EntityMap_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N EntityMap_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("EntityMap_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> EntityMap_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("EntityMap_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("EntityMap_BulkDeleteFailures");
                SetRelatedEntities("EntityMap_BulkDeleteFailures", null, value);
                OnPropertyChanged("EntityMap_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_entitymap
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_entitymap")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_entitymap
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_entitymap", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_entitymap");
                SetRelatedEntities("userentityinstancedata_entitymap", null, value);
                OnPropertyChanged("userentityinstancedata_entitymap");
            }
        }

        /// <summary>
        ///     N:1 createdby_entitymap
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("createdby_entitymap")]
        public SystemUser createdby_entitymap
        {
            get { return GetRelatedEntity<SystemUser>("createdby_entitymap", null); }
        }

        /// <summary>
        ///     N:1 lk_entitymap_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_entitymap_createdonbehalfby")]
        public SystemUser lk_entitymap_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_entitymap_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_entitymap_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_entitymap_modifiedonbehalfby")]
        public SystemUser lk_entitymap_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_entitymap_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 modifiedby_entitymap
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("modifiedby_entitymap")]
        public SystemUser modifiedby_entitymap
        {
            get { return GetRelatedEntity<SystemUser>("modifiedby_entitymap", null); }
        }

        /// <summary>
        ///     N:1 organization_entitymap
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_entitymap")]
        public Organization organization_entitymap
        {
            get { return GetRelatedEntity<Organization>("organization_entitymap", null); }
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