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
    ///     Mapping for columns in a data map.
    /// </summary>
    [DataContract]
    [EntityLogicalName("columnmapping")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ColumnMapping : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "columnmapping";

        public const int EntityTypeCode = 4417;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ColumnMapping() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the column mapping.
        /// </summary>
        [AttributeLogicalName("columnmappingid")]
        public Guid? ColumnMappingId
        {
            get { return GetAttributeValue<Guid?>("columnmappingid"); }
            set
            {
                OnPropertyChanging("ColumnMappingId");
                SetAttributeValue("columnmappingid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ColumnMappingId");
            }
        }

        [AttributeLogicalName("columnmappingid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ColumnMappingId = value; }
        }

        /// <summary>
        ///     Unique identifier of the user who created the column mapping.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the column mapping was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the columnmapping.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
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
        ///     Unique identifier of the user who last modified the column mapping.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the column mapping was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the columnmapping.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Information about whether the column mapping needs to be processed.
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
        ///     Name of the source attribute.
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
        ///     Status of the column mapping.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public ColumnMappingState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ColumnMappingState) (Enum.ToObject(typeof (ColumnMappingState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the column mapping.
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
        ///     Name of the Microsoft Dynamics CRM attribute.
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
        ///     1:N LookUpMapping_ColumnMapping
        /// </summary>
        [RelationshipSchemaName("LookUpMapping_ColumnMapping")]
        public IEnumerable<LookUpMapping> LookUpMapping_ColumnMapping
        {
            get { return GetRelatedEntities<LookUpMapping>("LookUpMapping_ColumnMapping", null); }
            set
            {
                OnPropertyChanging("LookUpMapping_ColumnMapping");
                SetRelatedEntities("LookUpMapping_ColumnMapping", null, value);
                OnPropertyChanged("LookUpMapping_ColumnMapping");
            }
        }

        /// <summary>
        ///     1:N PickListMapping_ColumnMapping
        /// </summary>
        [RelationshipSchemaName("PickListMapping_ColumnMapping")]
        public IEnumerable<PickListMapping> PickListMapping_ColumnMapping
        {
            get { return GetRelatedEntities<PickListMapping>("PickListMapping_ColumnMapping", null); }
            set
            {
                OnPropertyChanging("PickListMapping_ColumnMapping");
                SetRelatedEntities("PickListMapping_ColumnMapping", null, value);
                OnPropertyChanged("PickListMapping_ColumnMapping");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_columnmapping
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_columnmapping")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_columnmapping
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_columnmapping", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_columnmapping");
                SetRelatedEntities("userentityinstancedata_columnmapping", null, value);
                OnPropertyChanged("userentityinstancedata_columnmapping");
            }
        }

        /// <summary>
        ///     N:1 ColumnMapping_ImportMap
        /// </summary>
        [AttributeLogicalName("importmapid")]
        [RelationshipSchemaName("ColumnMapping_ImportMap")]
        public ImportMap ColumnMapping_ImportMap
        {
            get { return GetRelatedEntity<ImportMap>("ColumnMapping_ImportMap", null); }
            set
            {
                OnPropertyChanging("ColumnMapping_ImportMap");
                SetRelatedEntity("ColumnMapping_ImportMap", null, value);
                OnPropertyChanged("ColumnMapping_ImportMap");
            }
        }

        /// <summary>
        ///     N:1 lk_columnmapping_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_columnmapping_createdby")]
        public SystemUser lk_columnmapping_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_columnmapping_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_columnmapping_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_columnmapping_createdonbehalfby")]
        public SystemUser lk_columnmapping_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_columnmapping_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_columnmapping_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_columnmapping_modifiedby")]
        public SystemUser lk_columnmapping_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_columnmapping_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_columnmapping_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_columnmapping_modifiedonbehalfby")]
        public SystemUser lk_columnmapping_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_columnmapping_modifiedonbehalfby", null); }
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