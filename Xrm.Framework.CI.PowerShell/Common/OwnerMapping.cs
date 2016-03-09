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
    ///     In a data map, maps ownership data from the source file to Microsoft Dynamics CRM.
    /// </summary>
    [DataContract]
    [EntityLogicalName("ownermapping")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class OwnerMapping : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "ownermapping";

        public const int EntityTypeCode = 4420;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public OwnerMapping() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the user who created the owner mapping.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the owner mapping was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the ownermapping.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the data map with which the owner mapping is associated.
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
        ///     Unique identifier of the user who last modified the lookup mapping.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the owner mapping was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the ownermapping.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the owner mapping.
        /// </summary>
        [AttributeLogicalName("ownermappingid")]
        public Guid? OwnerMappingId
        {
            get { return GetAttributeValue<Guid?>("ownermappingid"); }
            set
            {
                OnPropertyChanging("OwnerMappingId");
                SetAttributeValue("ownermappingid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("OwnerMappingId");
            }
        }

        [AttributeLogicalName("ownermappingid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { OwnerMappingId = value; }
        }

        /// <summary>
        ///     Code that indicates whether the owner mapping has to be processed
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
        ///     Source user name that has to be replaced
        /// </summary>
        [AttributeLogicalName("sourcesystemusername")]
        public string SourceSystemUserName
        {
            get { return GetAttributeValue<string>("sourcesystemusername"); }
            set
            {
                OnPropertyChanging("SourceSystemUserName");
                SetAttributeValue("sourcesystemusername", value);
                OnPropertyChanged("SourceSystemUserName");
            }
        }

        /// <summary>
        ///     Source user value for source Microsoft Dynamics CRM user link.
        /// </summary>
        [AttributeLogicalName("sourceuservalueforsourcecrmuserlink")]
        public string SourceUserValueForSourceCRMUserLink
        {
            get { return GetAttributeValue<string>("sourceuservalueforsourcecrmuserlink"); }
            set
            {
                OnPropertyChanging("SourceUserValueForSourceCRMUserLink");
                SetAttributeValue("sourceuservalueforsourcecrmuserlink", value);
                OnPropertyChanged("SourceUserValueForSourceCRMUserLink");
            }
        }

        /// <summary>
        ///     Status of the owner mapping.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public OwnerMappingState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((OwnerMappingState) (Enum.ToObject(typeof (OwnerMappingState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the owner mapping.
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
        ///     Microsoft Dynamics CRM logon name with which the source user name should be replaced.
        /// </summary>
        [AttributeLogicalName("targetsystemuserdomainname")]
        public string TargetSystemUserDomainName
        {
            get { return GetAttributeValue<string>("targetsystemuserdomainname"); }
            set
            {
                OnPropertyChanging("TargetSystemUserDomainName");
                SetAttributeValue("targetsystemuserdomainname", value);
                OnPropertyChanged("TargetSystemUserDomainName");
            }
        }

        /// <summary>
        ///     Unique identifier of the Microsoft Dynamics CRM user.
        /// </summary>
        [AttributeLogicalName("targetsystemuserid")]
        public EntityReference TargetSystemUserId
        {
            get { return GetAttributeValue<EntityReference>("targetsystemuserid"); }
            set
            {
                OnPropertyChanging("TargetSystemUserId");
                SetAttributeValue("targetsystemuserid", value);
                OnPropertyChanged("TargetSystemUserId");
            }
        }

        /// <summary>
        ///     Microsoft Dynamics CRM user.
        /// </summary>
        [AttributeLogicalName("targetuservalueforsourcecrmuserlink")]
        public string TargetUserValueForSourceCRMUserLink
        {
            get { return GetAttributeValue<string>("targetuservalueforsourcecrmuserlink"); }
            set
            {
                OnPropertyChanging("TargetUserValueForSourceCRMUserLink");
                SetAttributeValue("targetuservalueforsourcecrmuserlink", value);
                OnPropertyChanged("TargetUserValueForSourceCRMUserLink");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_ownermapping
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_ownermapping")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_ownermapping
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_ownermapping", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_ownermapping");
                SetRelatedEntities("userentityinstancedata_ownermapping", null, value);
                OnPropertyChanged("userentityinstancedata_ownermapping");
            }
        }

        /// <summary>
        ///     N:1 lk_ownermapping_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_ownermapping_createdby")]
        public SystemUser lk_ownermapping_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_ownermapping_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_ownermapping_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_ownermapping_createdonbehalfby")]
        public SystemUser lk_ownermapping_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_ownermapping_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_ownermapping_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_ownermapping_modifiedby")]
        public SystemUser lk_ownermapping_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_ownermapping_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_ownermapping_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_ownermapping_modifiedonbehalfby")]
        public SystemUser lk_ownermapping_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_ownermapping_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 OwnerMapping_ImportMap
        /// </summary>
        [AttributeLogicalName("importmapid")]
        [RelationshipSchemaName("OwnerMapping_ImportMap")]
        public ImportMap OwnerMapping_ImportMap
        {
            get { return GetRelatedEntity<ImportMap>("OwnerMapping_ImportMap", null); }
            set
            {
                OnPropertyChanging("OwnerMapping_ImportMap");
                SetRelatedEntity("OwnerMapping_ImportMap", null, value);
                OnPropertyChanged("OwnerMapping_ImportMap");
            }
        }

        /// <summary>
        ///     N:1 OwnerMapping_SystemUser
        /// </summary>
        [AttributeLogicalName("targetsystemuserid")]
        [RelationshipSchemaName("OwnerMapping_SystemUser")]
        public SystemUser OwnerMapping_SystemUser
        {
            get { return GetRelatedEntity<SystemUser>("OwnerMapping_SystemUser", null); }
            set
            {
                OnPropertyChanging("OwnerMapping_SystemUser");
                SetRelatedEntity("OwnerMapping_SystemUser", null, value);
                OnPropertyChanged("OwnerMapping_SystemUser");
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