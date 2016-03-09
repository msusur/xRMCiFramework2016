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
    ///     An XML document used to configure client extension controls.
    /// </summary>
    [DataContract]
    [EntityLogicalName("isvconfig")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class IsvConfig : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "isvconfig";

        public const int EntityTypeCode = 4705;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public IsvConfig() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Structured XML data representing the customizations.
        /// </summary>
        [AttributeLogicalName("configxml")]
        public string ConfigXML
        {
            get { return GetAttributeValue<string>("configxml"); }
            set
            {
                OnPropertyChanging("ConfigXML");
                SetAttributeValue("configxml", value);
                OnPropertyChanged("ConfigXML");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the ISV configuration.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the ISV configuration was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the isvconfig.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the ISV configuration.
        /// </summary>
        [AttributeLogicalName("isvconfigid")]
        public Guid? IsvConfigId
        {
            get { return GetAttributeValue<Guid?>("isvconfigid"); }
            set
            {
                OnPropertyChanging("IsvConfigId");
                SetAttributeValue("isvconfigid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("IsvConfigId");
            }
        }

        [AttributeLogicalName("isvconfigid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { IsvConfigId = value; }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the ISV configuration.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the ISV configuration was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the isvconfig.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the organization associated with the ISV configuration XML.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public Guid? OrganizationId
        {
            get { return GetAttributeValue<Guid?>("organizationid"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N IsvConfig_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("IsvConfig_AsyncOperations")]
        public IEnumerable<AsyncOperation> IsvConfig_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("IsvConfig_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("IsvConfig_AsyncOperations");
                SetRelatedEntities("IsvConfig_AsyncOperations", null, value);
                OnPropertyChanged("IsvConfig_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N IsvConfig_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("IsvConfig_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> IsvConfig_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("IsvConfig_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("IsvConfig_BulkDeleteFailures");
                SetRelatedEntities("IsvConfig_BulkDeleteFailures", null, value);
                OnPropertyChanged("IsvConfig_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_isvconfig
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_isvconfig")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_isvconfig
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_isvconfig", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_isvconfig");
                SetRelatedEntities("userentityinstancedata_isvconfig", null, value);
                OnPropertyChanged("userentityinstancedata_isvconfig");
            }
        }

        /// <summary>
        ///     N:1 lk_isvconfig_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_isvconfig_createdonbehalfby")]
        public SystemUser lk_isvconfig_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_isvconfig_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_isvconfig_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_isvconfig_modifiedonbehalfby")]
        public SystemUser lk_isvconfig_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_isvconfig_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_isvconfigbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_isvconfigbase_createdby")]
        public SystemUser lk_isvconfigbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_isvconfigbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_isvconfigbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_isvconfigbase_modifiedby")]
        public SystemUser lk_isvconfigbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_isvconfigbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 organization_isvconfigs
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_isvconfigs")]
        public Organization organization_isvconfigs
        {
            get { return GetRelatedEntity<Organization>("organization_isvconfigs", null); }
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