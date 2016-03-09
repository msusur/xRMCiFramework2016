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
    ///     Represents a mapping between attributes where the attribute values should be copied from a record into the form of
    ///     a new related record.
    /// </summary>
    [DataContract]
    [EntityLogicalName("attributemap")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class AttributeMap : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "attributemap";

        public const int EntityTypeCode = 4601;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public AttributeMap() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the attribute map.
        /// </summary>
        [AttributeLogicalName("attributemapid")]
        public Guid? AttributeMapId
        {
            get { return GetAttributeValue<Guid?>("attributemapid"); }
            set
            {
                OnPropertyChanging("AttributeMapId");
                SetAttributeValue("attributemapid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("AttributeMapId");
            }
        }

        [AttributeLogicalName("attributemapid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { AttributeMapId = value; }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("attributemapidunique")]
        public Guid? AttributeMapIdUnique
        {
            get { return GetAttributeValue<Guid?>("attributemapidunique"); }
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
        ///     Unique identifier of the user who created the attribute map.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the attribute map was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the attributemap.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the entity map with which the attribute map is associated.
        /// </summary>
        [AttributeLogicalName("entitymapid")]
        public EntityReference EntityMapId
        {
            get { return GetAttributeValue<EntityReference>("entitymapid"); }
            set
            {
                OnPropertyChanging("EntityMapId");
                SetAttributeValue("entitymapid", value);
                OnPropertyChanged("EntityMapId");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("ismanaged")]
        public bool? IsManaged
        {
            get { return GetAttributeValue<bool?>("ismanaged"); }
        }

        /// <summary>
        ///     Information about whether this attribute map is user-defined or system-defined.
        /// </summary>
        [AttributeLogicalName("issystem")]
        public bool? IsSystem
        {
            get { return GetAttributeValue<bool?>("issystem"); }
            set
            {
                OnPropertyChanging("IsSystem");
                SetAttributeValue("issystem", value);
                OnPropertyChanged("IsSystem");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the attribute map.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the attribute map was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the attributemap.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the organization with which the attribute map is associated.
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
        ///     Unique identifier of the parent attribute map.
        /// </summary>
        [AttributeLogicalName("parentattributemapid")]
        public EntityReference ParentAttributeMapId
        {
            get { return GetAttributeValue<EntityReference>("parentattributemapid"); }
            set
            {
                OnPropertyChanging("ParentAttributeMapId");
                SetAttributeValue("parentattributemapid", value);
                OnPropertyChanged("ParentAttributeMapId");
            }
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
        ///     Name of the source attribute for the mapping.
        /// </summary>
        [AttributeLogicalName("sourceattributename")]
        public string SourceAttributeName
        {
            get { return GetAttributeValue<string>("sourceattributename"); }
            set
            {
                OnPropertyChanging("SourceAttributeName");
                SetAttributeValue("sourceattributename", value);
                OnPropertyChanged("SourceAttributeName");
            }
        }

        /// <summary>
        ///     Name of the target attribute for the mapping.
        /// </summary>
        [AttributeLogicalName("targetattributename")]
        public string TargetAttributeName
        {
            get { return GetAttributeValue<string>("targetattributename"); }
            set
            {
                OnPropertyChanging("TargetAttributeName");
                SetAttributeValue("targetattributename", value);
                OnPropertyChanged("TargetAttributeName");
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
        ///     1:N attribute_map_attribute_maps
        /// </summary>
        [RelationshipSchemaName("attribute_map_attribute_maps", EntityRole.Referenced)]
        public IEnumerable<AttributeMap> Referencedattribute_map_attribute_maps
        {
            get { return GetRelatedEntities<AttributeMap>("attribute_map_attribute_maps", EntityRole.Referenced); }
            set
            {
                OnPropertyChanging("Referencedattribute_map_attribute_maps");
                SetRelatedEntities("attribute_map_attribute_maps", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedattribute_map_attribute_maps");
            }
        }

        /// <summary>
        ///     1:N AttributeMap_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("AttributeMap_AsyncOperations")]
        public IEnumerable<AsyncOperation> AttributeMap_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("AttributeMap_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("AttributeMap_AsyncOperations");
                SetRelatedEntities("AttributeMap_AsyncOperations", null, value);
                OnPropertyChanged("AttributeMap_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N AttributeMap_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("AttributeMap_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> AttributeMap_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("AttributeMap_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("AttributeMap_BulkDeleteFailures");
                SetRelatedEntities("AttributeMap_BulkDeleteFailures", null, value);
                OnPropertyChanged("AttributeMap_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_attributemap
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_attributemap")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_attributemap
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_attributemap", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_attributemap");
                SetRelatedEntities("userentityinstancedata_attributemap", null, value);
                OnPropertyChanged("userentityinstancedata_attributemap");
            }
        }

        /// <summary>
        ///     N:1 attribute_map_attribute_maps
        /// </summary>
        [AttributeLogicalName("parentattributemapid")]
        [RelationshipSchemaName("attribute_map_attribute_maps", EntityRole.Referencing)]
        public AttributeMap Referencingattribute_map_attribute_maps
        {
            get { return GetRelatedEntity<AttributeMap>("attribute_map_attribute_maps", EntityRole.Referencing); }
            set
            {
                OnPropertyChanging("Referencingattribute_map_attribute_maps");
                SetRelatedEntity("attribute_map_attribute_maps", EntityRole.Referencing, value);
                OnPropertyChanged("Referencingattribute_map_attribute_maps");
            }
        }

        /// <summary>
        ///     N:1 createdby_attributemap
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("createdby_attributemap")]
        public SystemUser createdby_attributemap
        {
            get { return GetRelatedEntity<SystemUser>("createdby_attributemap", null); }
        }

        /// <summary>
        ///     N:1 createdonbehalfby_attributemap
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("createdonbehalfby_attributemap")]
        public SystemUser createdonbehalfby_attributemap
        {
            get { return GetRelatedEntity<SystemUser>("createdonbehalfby_attributemap", null); }
        }

        /// <summary>
        ///     N:1 entity_map_attribute_maps
        /// </summary>
        [AttributeLogicalName("entitymapid")]
        [RelationshipSchemaName("entity_map_attribute_maps")]
        public EntityMap entity_map_attribute_maps
        {
            get { return GetRelatedEntity<EntityMap>("entity_map_attribute_maps", null); }
            set
            {
                OnPropertyChanging("entity_map_attribute_maps");
                SetRelatedEntity("entity_map_attribute_maps", null, value);
                OnPropertyChanged("entity_map_attribute_maps");
            }
        }

        /// <summary>
        ///     N:1 modifiedby_attributemap
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("modifiedby_attributemap")]
        public SystemUser modifiedby_attributemap
        {
            get { return GetRelatedEntity<SystemUser>("modifiedby_attributemap", null); }
        }

        /// <summary>
        ///     N:1 modifiedonbehalfby_attributemap
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("modifiedonbehalfby_attributemap")]
        public SystemUser modifiedonbehalfby_attributemap
        {
            get { return GetRelatedEntity<SystemUser>("modifiedonbehalfby_attributemap", null); }
        }

        /// <summary>
        ///     N:1 organization_attributemap
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_attributemap")]
        public Organization organization_attributemap
        {
            get { return GetRelatedEntity<Organization>("organization_attributemap", null); }
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