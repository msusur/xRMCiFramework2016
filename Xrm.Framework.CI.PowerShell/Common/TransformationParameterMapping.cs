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
    ///     In a data map, defines parameters for a transformation.
    /// </summary>
    [DataContract]
    [EntityLogicalName("transformationparametermapping")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class TransformationParameterMapping : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "transformationparametermapping";

        public const int EntityTypeCode = 4427;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public TransformationParameterMapping() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the user who created the parameter mapping.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the transformation parameter mapping was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the transformationparametermapping.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Transformation data for transformation parameter
        /// </summary>
        [AttributeLogicalName("data")]
        public string Data
        {
            get { return GetAttributeValue<string>("data"); }
            set
            {
                OnPropertyChanging("Data");
                SetAttributeValue("data", value);
                OnPropertyChanged("Data");
            }
        }

        /// <summary>
        ///     Data type of the transformation parameter.
        /// </summary>
        [AttributeLogicalName("datatypecode")]
        public OptionSetValue DataTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("datatypecode"); }
            set
            {
                OnPropertyChanging("DataTypeCode");
                SetAttributeValue("datatypecode", value);
                OnPropertyChanged("DataTypeCode");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the transformation parameter mapping.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the transformation parameter mapping was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the transformationparametermapping.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Index of the array if the input parameter is an array.
        /// </summary>
        [AttributeLogicalName("parameterarrayindex")]
        public int? ParameterArrayIndex
        {
            get { return GetAttributeValue<int?>("parameterarrayindex"); }
            set
            {
                OnPropertyChanging("ParameterArrayIndex");
                SetAttributeValue("parameterarrayindex", value);
                OnPropertyChanged("ParameterArrayIndex");
            }
        }

        /// <summary>
        ///     Parameter sequence number.
        /// </summary>
        [AttributeLogicalName("parametersequence")]
        public int? ParameterSequence
        {
            get { return GetAttributeValue<int?>("parametersequence"); }
            set
            {
                OnPropertyChanging("ParameterSequence");
                SetAttributeValue("parametersequence", value);
                OnPropertyChanged("ParameterSequence");
            }
        }

        /// <summary>
        ///     Type of transformation parameter.
        /// </summary>
        [AttributeLogicalName("parametertypecode")]
        public OptionSetValue ParameterTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("parametertypecode"); }
            set
            {
                OnPropertyChanging("ParameterTypeCode");
                SetAttributeValue("parametertypecode", value);
                OnPropertyChanged("ParameterTypeCode");
            }
        }

        /// <summary>
        ///     Unique identifier of the transformation with which the parameter is associated.
        /// </summary>
        [AttributeLogicalName("transformationmappingid")]
        public EntityReference TransformationMappingId
        {
            get { return GetAttributeValue<EntityReference>("transformationmappingid"); }
            set
            {
                OnPropertyChanging("TransformationMappingId");
                SetAttributeValue("transformationmappingid", value);
                OnPropertyChanged("TransformationMappingId");
            }
        }

        /// <summary>
        ///     Unique identifier of the transformation parameter mapping.
        /// </summary>
        [AttributeLogicalName("transformationparametermappingid")]
        public Guid? TransformationParameterMappingId
        {
            get { return GetAttributeValue<Guid?>("transformationparametermappingid"); }
            set
            {
                OnPropertyChanging("TransformationParameterMappingId");
                SetAttributeValue("transformationparametermappingid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("TransformationParameterMappingId");
            }
        }

        [AttributeLogicalName("transformationparametermappingid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { TransformationParameterMappingId = value; }
        }

        /// <summary>
        ///     1:N LookUpMapping_TransformationParameterMapping
        /// </summary>
        [RelationshipSchemaName("LookUpMapping_TransformationParameterMapping")]
        public IEnumerable<LookUpMapping> LookUpMapping_TransformationParameterMapping
        {
            get { return GetRelatedEntities<LookUpMapping>("LookUpMapping_TransformationParameterMapping", null); }
            set
            {
                OnPropertyChanging("LookUpMapping_TransformationParameterMapping");
                SetRelatedEntities("LookUpMapping_TransformationParameterMapping", null, value);
                OnPropertyChanged("LookUpMapping_TransformationParameterMapping");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_transformationparametermapping
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_transformationparametermapping")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_transformationparametermapping
        {
            get
            {
                return
                    GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_transformationparametermapping",
                        null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_transformationparametermapping");
                SetRelatedEntities("userentityinstancedata_transformationparametermapping", null, value);
                OnPropertyChanged("userentityinstancedata_transformationparametermapping");
            }
        }

        /// <summary>
        ///     N:1 lk_transformationparametermapping_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_transformationparametermapping_createdby")]
        public SystemUser lk_transformationparametermapping_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_transformationparametermapping_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_transformationparametermapping_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_transformationparametermapping_createdonbehalfby")]
        public SystemUser lk_transformationparametermapping_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_transformationparametermapping_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_transformationparametermapping_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_transformationparametermapping_modifiedby")]
        public SystemUser lk_transformationparametermapping_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_transformationparametermapping_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_transformationparametermapping_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_transformationparametermapping_modifiedonbehalfby")]
        public SystemUser lk_transformationparametermapping_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_transformationparametermapping_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 TransformationParameterMapping_TransformationMapping
        /// </summary>
        [AttributeLogicalName("transformationmappingid")]
        [RelationshipSchemaName("TransformationParameterMapping_TransformationMapping")]
        public TransformationMapping TransformationParameterMapping_TransformationMapping
        {
            get
            {
                return GetRelatedEntity<TransformationMapping>("TransformationParameterMapping_TransformationMapping",
                    null);
            }
            set
            {
                OnPropertyChanging("TransformationParameterMapping_TransformationMapping");
                SetRelatedEntity("TransformationParameterMapping_TransformationMapping", null, value);
                OnPropertyChanged("TransformationParameterMapping_TransformationMapping");
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