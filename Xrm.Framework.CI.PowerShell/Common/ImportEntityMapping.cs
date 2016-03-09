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
    ///     Mapping for entities in a data map.
    /// </summary>
    [DataContract]
    [EntityLogicalName("importentitymapping")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ImportEntityMapping : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "importentitymapping";

        public const int EntityTypeCode = 4428;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ImportEntityMapping() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the user who created the import entity mapping.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the import entity mapping was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the importentitymapping.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Information about whether the entity needs to be processed to find and delete duplicate records.
        /// </summary>
        [AttributeLogicalName("dedupe")]
        public OptionSetValue DeDupe
        {
            get { return GetAttributeValue<OptionSetValue>("dedupe"); }
            set
            {
                OnPropertyChanging("DeDupe");
                SetAttributeValue("dedupe", value);
                OnPropertyChanged("DeDupe");
            }
        }

        /// <summary>
        ///     Unique identifier of the import entity mapping.
        /// </summary>
        [AttributeLogicalName("importentitymappingid")]
        public Guid? ImportEntityMappingId
        {
            get { return GetAttributeValue<Guid?>("importentitymappingid"); }
            set
            {
                OnPropertyChanging("ImportEntityMappingId");
                SetAttributeValue("importentitymappingid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ImportEntityMappingId");
            }
        }

        [AttributeLogicalName("importentitymappingid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ImportEntityMappingId = value; }
        }

        /// <summary>
        ///     Unique identifier of the associated data map.
        /// </summary>
        [AttributeLogicalName("importmapid")]
        public EntityReference ImportMapId
        {
            get { return GetAttributeValue<EntityReference>("importmapid"); }
            set
            {
                OnPropertyChanging("ImportMapId");
                SetAttributeValue("importmapid", value);
                OnPropertyChanged("ImportMapId");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the import entity mapping.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the import entity mapping was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the importentitymapping.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Information about whether the import entity mapping needs to be processed.
        /// </summary>
        [AttributeLogicalName("processcode")]
        public OptionSetValue ProcessCode
        {
            get { return GetAttributeValue<OptionSetValue>("processcode"); }
            set
            {
                OnPropertyChanging("ProcessCode");
                SetAttributeValue("processcode", value);
                OnPropertyChanged("ProcessCode");
            }
        }

        /// <summary>
        ///     Name of the source entity.
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
        ///     Status of the import entity mapping.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public ImportEntityMappingState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return
                        ((ImportEntityMappingState) (Enum.ToObject(typeof (ImportEntityMappingState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the import entity mapping.
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
        ///     1:N userentityinstancedata_importentitymapping
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_importentitymapping")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_importentitymapping
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_importentitymapping", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_importentitymapping");
                SetRelatedEntities("userentityinstancedata_importentitymapping", null, value);
                OnPropertyChanged("userentityinstancedata_importentitymapping");
            }
        }

        /// <summary>
        ///     N:1 ImportEntityMapping_ImportMap
        /// </summary>
        [AttributeLogicalName("importmapid")]
        [RelationshipSchemaName("ImportEntityMapping_ImportMap")]
        public ImportMap ImportEntityMapping_ImportMap
        {
            get { return GetRelatedEntity<ImportMap>("ImportEntityMapping_ImportMap", null); }
            set
            {
                OnPropertyChanging("ImportEntityMapping_ImportMap");
                SetRelatedEntity("ImportEntityMapping_ImportMap", null, value);
                OnPropertyChanged("ImportEntityMapping_ImportMap");
            }
        }

        /// <summary>
        ///     N:1 lk_importentitymapping_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_importentitymapping_createdby")]
        public SystemUser lk_importentitymapping_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_importentitymapping_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_importentitymapping_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_importentitymapping_createdonbehalfby")]
        public SystemUser lk_importentitymapping_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_importentitymapping_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_importentitymapping_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_importentitymapping_modifiedby")]
        public SystemUser lk_importentitymapping_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_importentitymapping_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_importentitymapping_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_importentitymapping_modifiedonbehalfby")]
        public SystemUser lk_importentitymapping_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_importentitymapping_modifiedonbehalfby", null); }
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