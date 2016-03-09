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
    ///     Data map used in import.
    /// </summary>
    [DataContract]
    [EntityLogicalName("importmap")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ImportMap : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "importmap";

        public const int EntityTypeCode = 4411;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ImportMap() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Shows who created the record.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Shows the date and time when the record was created. The date and time are displayed in the time zone selected in
        ///     Microsoft Dynamics CRM options.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Shows who created the record on behalf of another user.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Type additional information to describe the data map, such as the intended use or data source.
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
        ///     Choose whether a data file can contain data for one or more record types.
        /// </summary>
        [AttributeLogicalName("entitiesperfile")]
        public OptionSetValue EntitiesPerFile
        {
            get { return GetAttributeValue<OptionSetValue>("entitiesperfile"); }
            set
            {
                OnPropertyChanging("EntitiesPerFile");
                SetAttributeValue("entitiesperfile", value);
                OnPropertyChanged("EntitiesPerFile");
            }
        }

        /// <summary>
        ///     Unique identifier of the data map.
        /// </summary>
        [AttributeLogicalName("importmapid")]
        public Guid? ImportMapId
        {
            get { return GetAttributeValue<Guid?>("importmapid"); }
            set
            {
                OnPropertyChanging("ImportMapId");
                SetAttributeValue("importmapid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ImportMapId");
            }
        }

        [AttributeLogicalName("importmapid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ImportMapId = value; }
        }

        /// <summary>
        ///     Select the type of data map to distinguish out-of-the-box data maps from custom maps.
        /// </summary>
        [AttributeLogicalName("importmaptype")]
        public OptionSetValue ImportMapType
        {
            get { return GetAttributeValue<OptionSetValue>("importmaptype"); }
            set
            {
                OnPropertyChanging("ImportMapType");
                SetAttributeValue("importmaptype", value);
                OnPropertyChanged("ImportMapType");
            }
        }

        /// <summary>
        ///     Information about whether the data map is valid for use with data import.
        /// </summary>
        [AttributeLogicalName("isvalidforimport")]
        public bool? IsValidForImport
        {
            get { return GetAttributeValue<bool?>("isvalidforimport"); }
        }

        /// <summary>
        ///     Information about whether this data map was created by the Data Migration Manager.
        /// </summary>
        [AttributeLogicalName("iswizardcreated")]
        public bool? IsWizardCreated
        {
            get { return GetAttributeValue<bool?>("iswizardcreated"); }
            set
            {
                OnPropertyChanging("IsWizardCreated");
                SetAttributeValue("iswizardcreated", value);
                OnPropertyChanged("IsWizardCreated");
            }
        }

        /// <summary>
        ///     Customizations XML
        /// </summary>
        [AttributeLogicalName("mapcustomizations")]
        public string MapCustomizations
        {
            get { return GetAttributeValue<string>("mapcustomizations"); }
            set
            {
                OnPropertyChanging("MapCustomizations");
                SetAttributeValue("mapcustomizations", value);
                OnPropertyChanged("MapCustomizations");
            }
        }

        /// <summary>
        ///     Shows who last updated the record.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected
        ///     in Microsoft Dynamics CRM options.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Shows who last updated the record on behalf of another user.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Type a descriptive name for the data map.
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
        ///     Enter the user or team who is assigned to manage the record. This field is updated every time the record is
        ///     assigned to a different user.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId
        {
            get { return GetAttributeValue<EntityReference>("ownerid"); }
            set
            {
                OnPropertyChanging("OwnerId");
                SetAttributeValue("ownerid", value);
                OnPropertyChanged("OwnerId");
            }
        }

        /// <summary>
        ///     Business unit that owns the data map.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the data map.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the data map.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Type the name of the migration source that this data map is used for.
        /// </summary>
        [AttributeLogicalName("source")]
        public string Source
        {
            get { return GetAttributeValue<string>("source"); }
            set
            {
                OnPropertyChanging("Source");
                SetAttributeValue("source", value);
                OnPropertyChanged("Source");
            }
        }

        /// <summary>
        ///     Select the migration source type that this data map is used for.
        /// </summary>
        [AttributeLogicalName("sourcetype")]
        public OptionSetValue SourceType
        {
            get { return GetAttributeValue<OptionSetValue>("sourcetype"); }
            set
            {
                OnPropertyChanging("SourceType");
                SetAttributeValue("sourcetype", value);
                OnPropertyChanged("SourceType");
            }
        }

        /// <summary>
        ///     Source user value for source Microsoft Dynamics CRM user link.
        /// </summary>
        [AttributeLogicalName("sourceuseridentifierforsourcecrmuserlink")]
        public string SourceUserIdentifierForSourceCRMUserLink
        {
            get { return GetAttributeValue<string>("sourceuseridentifierforsourcecrmuserlink"); }
            set
            {
                OnPropertyChanging("SourceUserIdentifierForSourceCRMUserLink");
                SetAttributeValue("sourceuseridentifierforsourcecrmuserlink", value);
                OnPropertyChanged("SourceUserIdentifierForSourceCRMUserLink");
            }
        }

        /// <summary>
        ///     Column in the source file that uniquely identifies a user.
        /// </summary>
        [AttributeLogicalName("sourceuseridentifierforsourcedatasourceuserlink")]
        public string SourceUserIdentifierForSourceDataSourceUserLink
        {
            get { return GetAttributeValue<string>("sourceuseridentifierforsourcedatasourceuserlink"); }
            set
            {
                OnPropertyChanging("SourceUserIdentifierForSourceDataSourceUserLink");
                SetAttributeValue("sourceuseridentifierforsourcedatasourceuserlink", value);
                OnPropertyChanged("SourceUserIdentifierForSourceDataSourceUserLink");
            }
        }

        /// <summary>
        ///     Shows whether the data map is active or inactive. Inactive data maps are read-only and can't be edited.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public ImportMapState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ImportMapState) (Enum.ToObject(typeof (ImportMapState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Select the data map's status.
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
        ///     Select the name of the Microsoft Dynamics CRM record type that this data map is defined for.
        /// </summary>
        [AttributeLogicalName("targetentity")]
        public OptionSetValue TargetEntity
        {
            get { return GetAttributeValue<OptionSetValue>("targetentity"); }
        }

        /// <summary>
        ///     Microsoft Dynamics CRM user.
        /// </summary>
        [AttributeLogicalName("targetuseridentifierforsourcecrmuserlink")]
        public string TargetUserIdentifierForSourceCRMUserLink
        {
            get { return GetAttributeValue<string>("targetuseridentifierforsourcecrmuserlink"); }
            set
            {
                OnPropertyChanging("TargetUserIdentifierForSourceCRMUserLink");
                SetAttributeValue("targetuseridentifierforsourcecrmuserlink", value);
                OnPropertyChanged("TargetUserIdentifierForSourceCRMUserLink");
            }
        }

        /// <summary>
        ///     1:N ColumnMapping_ImportMap
        /// </summary>
        [RelationshipSchemaName("ColumnMapping_ImportMap")]
        public IEnumerable<ColumnMapping> ColumnMapping_ImportMap
        {
            get { return GetRelatedEntities<ColumnMapping>("ColumnMapping_ImportMap", null); }
            set
            {
                OnPropertyChanging("ColumnMapping_ImportMap");
                SetRelatedEntities("ColumnMapping_ImportMap", null, value);
                OnPropertyChanged("ColumnMapping_ImportMap");
            }
        }

        /// <summary>
        ///     1:N ImportEntityMapping_ImportMap
        /// </summary>
        [RelationshipSchemaName("ImportEntityMapping_ImportMap")]
        public IEnumerable<ImportEntityMapping> ImportEntityMapping_ImportMap
        {
            get { return GetRelatedEntities<ImportEntityMapping>("ImportEntityMapping_ImportMap", null); }
            set
            {
                OnPropertyChanging("ImportEntityMapping_ImportMap");
                SetRelatedEntities("ImportEntityMapping_ImportMap", null, value);
                OnPropertyChanged("ImportEntityMapping_ImportMap");
            }
        }

        /// <summary>
        ///     1:N ImportMap_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("ImportMap_AsyncOperations")]
        public IEnumerable<AsyncOperation> ImportMap_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("ImportMap_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("ImportMap_AsyncOperations");
                SetRelatedEntities("ImportMap_AsyncOperations", null, value);
                OnPropertyChanged("ImportMap_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N ImportMap_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("ImportMap_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> ImportMap_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("ImportMap_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("ImportMap_BulkDeleteFailures");
                SetRelatedEntities("ImportMap_BulkDeleteFailures", null, value);
                OnPropertyChanged("ImportMap_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N ImportMap_ImportFile
        /// </summary>
        [RelationshipSchemaName("ImportMap_ImportFile")]
        public IEnumerable<ImportFile> ImportMap_ImportFile
        {
            get { return GetRelatedEntities<ImportFile>("ImportMap_ImportFile", null); }
            set
            {
                OnPropertyChanging("ImportMap_ImportFile");
                SetRelatedEntities("ImportMap_ImportFile", null, value);
                OnPropertyChanged("ImportMap_ImportFile");
            }
        }

        /// <summary>
        ///     1:N OwnerMapping_ImportMap
        /// </summary>
        [RelationshipSchemaName("OwnerMapping_ImportMap")]
        public IEnumerable<OwnerMapping> OwnerMapping_ImportMap
        {
            get { return GetRelatedEntities<OwnerMapping>("OwnerMapping_ImportMap", null); }
            set
            {
                OnPropertyChanging("OwnerMapping_ImportMap");
                SetRelatedEntities("OwnerMapping_ImportMap", null, value);
                OnPropertyChanged("OwnerMapping_ImportMap");
            }
        }

        /// <summary>
        ///     1:N TransformationMapping_ImportMap
        /// </summary>
        [RelationshipSchemaName("TransformationMapping_ImportMap")]
        public IEnumerable<TransformationMapping> TransformationMapping_ImportMap
        {
            get { return GetRelatedEntities<TransformationMapping>("TransformationMapping_ImportMap", null); }
            set
            {
                OnPropertyChanging("TransformationMapping_ImportMap");
                SetRelatedEntities("TransformationMapping_ImportMap", null, value);
                OnPropertyChanged("TransformationMapping_ImportMap");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_importmap
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_importmap")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_importmap
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_importmap", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_importmap");
                SetRelatedEntities("userentityinstancedata_importmap", null, value);
                OnPropertyChanged("userentityinstancedata_importmap");
            }
        }

        /// <summary>
        ///     N:1 BusinessUnit_ImportMaps
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("BusinessUnit_ImportMaps")]
        public BusinessUnit BusinessUnit_ImportMaps
        {
            get { return GetRelatedEntity<BusinessUnit>("BusinessUnit_ImportMaps", null); }
        }

        /// <summary>
        ///     N:1 lk_importmap_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_importmap_createdonbehalfby")]
        public SystemUser lk_importmap_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_importmap_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_importmap_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_importmap_modifiedonbehalfby")]
        public SystemUser lk_importmap_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_importmap_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_importmapbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_importmapbase_createdby")]
        public SystemUser lk_importmapbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_importmapbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_importmapbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_importmapbase_modifiedby")]
        public SystemUser lk_importmapbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_importmapbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 SystemUser_ImportMaps
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("SystemUser_ImportMaps")]
        public SystemUser SystemUser_ImportMaps
        {
            get { return GetRelatedEntity<SystemUser>("SystemUser_ImportMaps", null); }
        }

        /// <summary>
        ///     N:1 team_ImportMaps
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_ImportMaps")]
        public Team team_ImportMaps
        {
            get { return GetRelatedEntity<Team>("team_ImportMaps", null); }
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