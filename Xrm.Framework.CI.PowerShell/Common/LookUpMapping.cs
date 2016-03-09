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
    ///     In a data map, maps a lookup attribute in a source file to Microsoft Dynamics CRM.
    /// </summary>
    [DataContract]
    [EntityLogicalName("lookupmapping")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class LookUpMapping : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "lookupmapping";

        public const int EntityTypeCode = 4419;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public LookUpMapping() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the column mapping with which this lookup mapping is associated.
        /// </summary>
        [AttributeLogicalName("columnmappingid")]
        public EntityReference ColumnMappingId
        {
            get { return GetAttributeValue<EntityReference>("columnmappingid"); }
            set
            {
                OnPropertyChanging("ColumnMappingId");
                SetAttributeValue("columnmappingid", value);
                OnPropertyChanged("ColumnMappingId");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the lookup mapping.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the lookup mapping was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the lookupmapping.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Name of the field with which the lookup is associated.
        /// </summary>
        [AttributeLogicalName("lookupattributename")]
        public string LookUpAttributeName
        {
            get { return GetAttributeValue<string>("lookupattributename"); }
            set
            {
                OnPropertyChanging("LookUpAttributeName");
                SetAttributeValue("lookupattributename", value);
                OnPropertyChanged("LookUpAttributeName");
            }
        }

        /// <summary>
        ///     Name of the entity with which the lookup is associated.
        /// </summary>
        [AttributeLogicalName("lookupentityname")]
        public string LookUpEntityName
        {
            get { return GetAttributeValue<string>("lookupentityname"); }
            set
            {
                OnPropertyChanging("LookUpEntityName");
                SetAttributeValue("lookupentityname", value);
                OnPropertyChanged("LookUpEntityName");
            }
        }

        /// <summary>
        ///     Unique identifier of the lookup mapping.
        /// </summary>
        [AttributeLogicalName("lookupmappingid")]
        public Guid? LookUpMappingId
        {
            get { return GetAttributeValue<Guid?>("lookupmappingid"); }
            set
            {
                OnPropertyChanging("LookUpMappingId");
                SetAttributeValue("lookupmappingid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("LookUpMappingId");
            }
        }

        [AttributeLogicalName("lookupmappingid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { LookUpMappingId = value; }
        }

        /// <summary>
        ///     Lookup source code for lookup mapping.
        /// </summary>
        [AttributeLogicalName("lookupsourcecode")]
        public OptionSetValue LookUpSourceCode
        {
            get { return GetAttributeValue<OptionSetValue>("lookupsourcecode"); }
            set
            {
                OnPropertyChanging("LookUpSourceCode");
                SetAttributeValue("lookupsourcecode", value);
                OnPropertyChanged("LookUpSourceCode");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the lookup mapping.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the lookup mapping was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the lookupmapping.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Information about whether the lookup mapping has to be processed.
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
        ///     Status of the lookup mapping.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public LookUpMappingState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((LookUpMappingState) (Enum.ToObject(typeof (LookUpMappingState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the lookup mapping.
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
        ///     Unique identifier of the transformation parameter mapping with which this lookup mapping is associated.
        /// </summary>
        [AttributeLogicalName("transformationparametermappingid")]
        public EntityReference TransformationParameterMappingId
        {
            get { return GetAttributeValue<EntityReference>("transformationparametermappingid"); }
            set
            {
                OnPropertyChanging("TransformationParameterMappingId");
                SetAttributeValue("transformationparametermappingid", value);
                OnPropertyChanged("TransformationParameterMappingId");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_lookupmapping
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_lookupmapping")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_lookupmapping
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_lookupmapping", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_lookupmapping");
                SetRelatedEntities("userentityinstancedata_lookupmapping", null, value);
                OnPropertyChanged("userentityinstancedata_lookupmapping");
            }
        }

        /// <summary>
        ///     N:1 lk_lookupmapping_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_lookupmapping_createdby")]
        public SystemUser lk_lookupmapping_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_lookupmapping_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_lookupmapping_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_lookupmapping_createdonbehalfby")]
        public SystemUser lk_lookupmapping_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_lookupmapping_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_lookupmapping_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_lookupmapping_modifiedby")]
        public SystemUser lk_lookupmapping_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_lookupmapping_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_lookupmapping_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_lookupmapping_modifiedonbehalfby")]
        public SystemUser lk_lookupmapping_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_lookupmapping_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 LookUpMapping_ColumnMapping
        /// </summary>
        [AttributeLogicalName("columnmappingid")]
        [RelationshipSchemaName("LookUpMapping_ColumnMapping")]
        public ColumnMapping LookUpMapping_ColumnMapping
        {
            get { return GetRelatedEntity<ColumnMapping>("LookUpMapping_ColumnMapping", null); }
            set
            {
                OnPropertyChanging("LookUpMapping_ColumnMapping");
                SetRelatedEntity("LookUpMapping_ColumnMapping", null, value);
                OnPropertyChanged("LookUpMapping_ColumnMapping");
            }
        }

        /// <summary>
        ///     N:1 LookUpMapping_TransformationParameterMapping
        /// </summary>
        [AttributeLogicalName("transformationparametermappingid")]
        [RelationshipSchemaName("LookUpMapping_TransformationParameterMapping")]
        public TransformationParameterMapping LookUpMapping_TransformationParameterMapping
        {
            get
            {
                return GetRelatedEntity<TransformationParameterMapping>("LookUpMapping_TransformationParameterMapping",
                    null);
            }
            set
            {
                OnPropertyChanging("LookUpMapping_TransformationParameterMapping");
                SetRelatedEntity("LookUpMapping_TransformationParameterMapping", null, value);
                OnPropertyChanged("LookUpMapping_TransformationParameterMapping");
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