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
    ///     In a data map, maps list values from the source file to Microsoft Dynamics CRM.
    /// </summary>
    [DataContract]
    [EntityLogicalName("picklistmapping")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class PickListMapping : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "picklistmapping";

        public const int EntityTypeCode = 4418;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public PickListMapping() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the column mapping with which this list value mapping is associated.
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
        ///     Unique identifier of the user who created the list value mapping.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the list value mapping was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the picklistmapping.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the list value mapping.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the list value mapping was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the picklistmapping.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the picklist mapping.
        /// </summary>
        [AttributeLogicalName("picklistmappingid")]
        public Guid? PickListMappingId
        {
            get { return GetAttributeValue<Guid?>("picklistmappingid"); }
            set
            {
                OnPropertyChanging("PickListMappingId");
                SetAttributeValue("picklistmappingid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("PickListMappingId");
            }
        }

        [AttributeLogicalName("picklistmappingid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { PickListMappingId = value; }
        }

        /// <summary>
        ///     Information about whether the list value mapping needs to be processed.
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
        ///     Source value to be replaced.
        /// </summary>
        [AttributeLogicalName("sourcevalue")]
        public string SourceValue
        {
            get { return GetAttributeValue<string>("sourcevalue"); }
            set
            {
                OnPropertyChanging("SourceValue");
                SetAttributeValue("sourcevalue", value);
                OnPropertyChanged("SourceValue");
            }
        }

        /// <summary>
        ///     Status of the picklist mapping.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public PickListMappingState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((PickListMappingState) (Enum.ToObject(typeof (PickListMappingState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the picklist mapping.
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
        ///     Microsoft Dynamics CRM list value with which to replace the source value.
        /// </summary>
        [AttributeLogicalName("targetvalue")]
        public int? TargetValue
        {
            get { return GetAttributeValue<int?>("targetvalue"); }
            set
            {
                OnPropertyChanging("TargetValue");
                SetAttributeValue("targetvalue", value);
                OnPropertyChanged("TargetValue");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_picklistmapping
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_picklistmapping")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_picklistmapping
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_picklistmapping", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_picklistmapping");
                SetRelatedEntities("userentityinstancedata_picklistmapping", null, value);
                OnPropertyChanged("userentityinstancedata_picklistmapping");
            }
        }

        /// <summary>
        ///     N:1 lk_picklistmapping_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_picklistmapping_createdby")]
        public SystemUser lk_picklistmapping_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_picklistmapping_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_picklistmapping_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_picklistmapping_createdonbehalfby")]
        public SystemUser lk_picklistmapping_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_picklistmapping_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_picklistmapping_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_picklistmapping_modifiedby")]
        public SystemUser lk_picklistmapping_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_picklistmapping_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_picklistmapping_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_picklistmapping_modifiedonbehalfby")]
        public SystemUser lk_picklistmapping_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_picklistmapping_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 PickListMapping_ColumnMapping
        /// </summary>
        [AttributeLogicalName("columnmappingid")]
        [RelationshipSchemaName("PickListMapping_ColumnMapping")]
        public ColumnMapping PickListMapping_ColumnMapping
        {
            get { return GetRelatedEntity<ColumnMapping>("PickListMapping_ColumnMapping", null); }
            set
            {
                OnPropertyChanging("PickListMapping_ColumnMapping");
                SetRelatedEntity("PickListMapping_ColumnMapping", null, value);
                OnPropertyChanged("PickListMapping_ColumnMapping");
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