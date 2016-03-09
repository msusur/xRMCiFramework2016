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
    ///     In a data map, maps the transformation of source attributes to Microsoft Dynamics CRM attributes.
    /// </summary>
    [DataContract]
    [EntityLogicalName("transformationmapping")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class TransformationMapping : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "transformationmapping";

        public const int EntityTypeCode = 4426;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public TransformationMapping() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the user who created the transformation mapping.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the transformation mapping was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the transformationmapping.
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
        ///     Unique identifier of the user who last modified the mapping.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the transformation mapping was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the transformationmapping.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Information about whether the transformation mapping needs to be processed.
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
        ///     Status of the transformation mapping.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public TransformationMappingState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return
                        ((TransformationMappingState)
                            (Enum.ToObject(typeof (TransformationMappingState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the transformation mapping.
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
        ///     Unique identifier of the transformation mapping.
        /// </summary>
        [AttributeLogicalName("transformationmappingid")]
        public Guid? TransformationMappingId
        {
            get { return GetAttributeValue<Guid?>("transformationmappingid"); }
            set
            {
                OnPropertyChanging("TransformationMappingId");
                SetAttributeValue("transformationmappingid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("TransformationMappingId");
            }
        }

        [AttributeLogicalName("transformationmappingid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { TransformationMappingId = value; }
        }

        /// <summary>
        ///     Type of transformation.
        /// </summary>
        [AttributeLogicalName("transformationtypename")]
        public string TransformationTypeName
        {
            get { return GetAttributeValue<string>("transformationtypename"); }
            set
            {
                OnPropertyChanging("TransformationTypeName");
                SetAttributeValue("transformationtypename", value);
                OnPropertyChanged("TransformationTypeName");
            }
        }

        /// <summary>
        ///     1:N TransformationParameterMapping_TransformationMapping
        /// </summary>
        [RelationshipSchemaName("TransformationParameterMapping_TransformationMapping")]
        public IEnumerable<TransformationParameterMapping> TransformationParameterMapping_TransformationMapping
        {
            get
            {
                return
                    GetRelatedEntities<TransformationParameterMapping>(
                        "TransformationParameterMapping_TransformationMapping", null);
            }
            set
            {
                OnPropertyChanging("TransformationParameterMapping_TransformationMapping");
                SetRelatedEntities("TransformationParameterMapping_TransformationMapping", null, value);
                OnPropertyChanged("TransformationParameterMapping_TransformationMapping");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_transformationmapping
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_transformationmapping")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_transformationmapping
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_transformationmapping", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_transformationmapping");
                SetRelatedEntities("userentityinstancedata_transformationmapping", null, value);
                OnPropertyChanged("userentityinstancedata_transformationmapping");
            }
        }

        /// <summary>
        ///     N:1 lk_transformationmapping_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_transformationmapping_createdby")]
        public SystemUser lk_transformationmapping_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_transformationmapping_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_transformationmapping_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_transformationmapping_createdonbehalfby")]
        public SystemUser lk_transformationmapping_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_transformationmapping_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_transformationmapping_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_transformationmapping_modifiedby")]
        public SystemUser lk_transformationmapping_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_transformationmapping_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_transformationmapping_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_transformationmapping_modifiedonbehalfby")]
        public SystemUser lk_transformationmapping_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_transformationmapping_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 TransformationMapping_ImportMap
        /// </summary>
        [AttributeLogicalName("importmapid")]
        [RelationshipSchemaName("TransformationMapping_ImportMap")]
        public ImportMap TransformationMapping_ImportMap
        {
            get { return GetRelatedEntity<ImportMap>("TransformationMapping_ImportMap", null); }
            set
            {
                OnPropertyChanging("TransformationMapping_ImportMap");
                SetRelatedEntity("TransformationMapping_ImportMap", null, value);
                OnPropertyChanged("TransformationMapping_ImportMap");
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