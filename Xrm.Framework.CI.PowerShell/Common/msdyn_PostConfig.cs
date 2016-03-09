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
    ///     Enable or disable entities for Activity Feeds and Yammer collaboration.
    /// </summary>
    [DataContract]
    [EntityLogicalName("msdyn_postconfig")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class msdyn_PostConfig : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "msdyn_postconfig";

        public const int EntityTypeCode = 10001;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public msdyn_PostConfig() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the user who created the record.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the record was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the record.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Sequence number of the import that created this record.
        /// </summary>
        [AttributeLogicalName("importsequencenumber")]
        public int? ImportSequenceNumber
        {
            get { return GetAttributeValue<int?>("importsequencenumber"); }
            set
            {
                OnPropertyChanging("ImportSequenceNumber");
                SetAttributeValue("importsequencenumber", value);
                OnPropertyChanged("ImportSequenceNumber");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who modified the record.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the record was modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who modified the record.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Enables or disables the wall on the entity form.
        /// </summary>
        [AttributeLogicalName("msdyn_configurewall")]
        public bool? msdyn_ConfigureWall
        {
            get { return GetAttributeValue<bool?>("msdyn_configurewall"); }
            set
            {
                OnPropertyChanging("msdyn_ConfigureWall");
                SetAttributeValue("msdyn_configurewall", value);
                OnPropertyChanged("msdyn_ConfigureWall");
            }
        }

        /// <summary>
        ///     Display name of the entity configured by this object.
        /// </summary>
        [AttributeLogicalName("msdyn_entitydisplayname")]
        public string msdyn_EntityDisplayName
        {
            get { return GetAttributeValue<string>("msdyn_entitydisplayname"); }
            set
            {
                OnPropertyChanging("msdyn_EntityDisplayName");
                SetAttributeValue("msdyn_entitydisplayname", value);
                OnPropertyChanged("msdyn_EntityDisplayName");
            }
        }

        /// <summary>
        ///     Logical name of the entity configured by this object.
        /// </summary>
        [AttributeLogicalName("msdyn_entityname")]
        public string msdyn_EntityName
        {
            get { return GetAttributeValue<string>("msdyn_entityname"); }
            set
            {
                OnPropertyChanging("msdyn_EntityName");
                SetAttributeValue("msdyn_entityname", value);
                OnPropertyChanged("msdyn_EntityName");
            }
        }

        /// <summary>
        ///     Identifier for the view of records that a user follows.
        /// </summary>
        [AttributeLogicalName("msdyn_followingviewid")]
        public string msdyn_FollowingViewId
        {
            get { return GetAttributeValue<string>("msdyn_followingviewid"); }
            set
            {
                OnPropertyChanging("msdyn_FollowingViewId");
                SetAttributeValue("msdyn_followingviewid", value);
                OnPropertyChanged("msdyn_FollowingViewId");
            }
        }

        /// <summary>
        ///     Identifier for the view of records that a user follows.
        /// </summary>
        [AttributeLogicalName("msdyn_followingviewid2")]
        public string msdyn_FollowingViewId2
        {
            get { return GetAttributeValue<string>("msdyn_followingviewid2"); }
            set
            {
                OnPropertyChanging("msdyn_FollowingViewId2");
                SetAttributeValue("msdyn_followingviewid2", value);
                OnPropertyChanged("msdyn_FollowingViewId2");
            }
        }

        /// <summary>
        ///     Object Type Code of the entity
        /// </summary>
        [AttributeLogicalName("msdyn_otc")]
        public int? msdyn_Otc
        {
            get { return GetAttributeValue<int?>("msdyn_otc"); }
            set
            {
                OnPropertyChanging("msdyn_Otc");
                SetAttributeValue("msdyn_otc", value);
                OnPropertyChanged("msdyn_Otc");
            }
        }

        /// <summary>
        ///     Unique identifier of the post configuration for this rule.
        /// </summary>
        [AttributeLogicalName("msdyn_postconfigid")]
        public Guid? msdyn_PostConfigId
        {
            get { return GetAttributeValue<Guid?>("msdyn_postconfigid"); }
            set
            {
                OnPropertyChanging("msdyn_PostConfigId");
                SetAttributeValue("msdyn_postconfigid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("msdyn_PostConfigId");
            }
        }

        [AttributeLogicalName("msdyn_postconfigid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { msdyn_PostConfigId = value; }
        }

        /// <summary>
        ///     Information about the success or failure of the configuration.
        /// </summary>
        [AttributeLogicalName("msdyn_status")]
        public string msdyn_Status
        {
            get { return GetAttributeValue<string>("msdyn_status"); }
            set
            {
                OnPropertyChanging("msdyn_Status");
                SetAttributeValue("msdyn_status", value);
                OnPropertyChanged("msdyn_Status");
            }
        }

        /// <summary>
        ///     Unique identifier for the organization
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     Date and time that the record was migrated.
        /// </summary>
        [AttributeLogicalName("overriddencreatedon")]
        public DateTime? OverriddenCreatedOn
        {
            get { return GetAttributeValue<DateTime?>("overriddencreatedon"); }
            set
            {
                OnPropertyChanging("OverriddenCreatedOn");
                SetAttributeValue("overriddencreatedon", value);
                OnPropertyChanged("OverriddenCreatedOn");
            }
        }

        /// <summary>
        ///     Status of the Post Configuration
        /// </summary>
        [AttributeLogicalName("statecode")]
        public msdyn_PostConfigState? statecode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((msdyn_PostConfigState) (Enum.ToObject(typeof (msdyn_PostConfigState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the Post Configuration
        /// </summary>
        [AttributeLogicalName("statuscode")]
        public OptionSetValue statuscode
        {
            get { return GetAttributeValue<OptionSetValue>("statuscode"); }
            set
            {
                OnPropertyChanging("statuscode");
                SetAttributeValue("statuscode", value);
                OnPropertyChanged("statuscode");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("timezoneruleversionnumber")]
        public int? TimeZoneRuleVersionNumber
        {
            get { return GetAttributeValue<int?>("timezoneruleversionnumber"); }
            set
            {
                OnPropertyChanging("TimeZoneRuleVersionNumber");
                SetAttributeValue("timezoneruleversionnumber", value);
                OnPropertyChanged("TimeZoneRuleVersionNumber");
            }
        }

        /// <summary>
        ///     Time zone code that was in use when the record was created.
        /// </summary>
        [AttributeLogicalName("utcconversiontimezonecode")]
        public int? UTCConversionTimeZoneCode
        {
            get { return GetAttributeValue<int?>("utcconversiontimezonecode"); }
            set
            {
                OnPropertyChanging("UTCConversionTimeZoneCode");
                SetAttributeValue("utcconversiontimezonecode", value);
                OnPropertyChanged("UTCConversionTimeZoneCode");
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
        ///     1:N msdyn_postconfig_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("msdyn_postconfig_AsyncOperations")]
        public IEnumerable<AsyncOperation> msdyn_postconfig_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("msdyn_postconfig_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("msdyn_postconfig_AsyncOperations");
                SetRelatedEntities("msdyn_postconfig_AsyncOperations", null, value);
                OnPropertyChanged("msdyn_postconfig_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N msdyn_postconfig_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("msdyn_postconfig_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> msdyn_postconfig_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_postconfig_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("msdyn_postconfig_BulkDeleteFailures");
                SetRelatedEntities("msdyn_postconfig_BulkDeleteFailures", null, value);
                OnPropertyChanged("msdyn_postconfig_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N msdyn_postconfig_msdyn_postruleconfig
        /// </summary>
        [RelationshipSchemaName("msdyn_postconfig_msdyn_postruleconfig")]
        public IEnumerable<msdyn_PostRuleConfig> msdyn_postconfig_msdyn_postruleconfig
        {
            get { return GetRelatedEntities<msdyn_PostRuleConfig>("msdyn_postconfig_msdyn_postruleconfig", null); }
            set
            {
                OnPropertyChanging("msdyn_postconfig_msdyn_postruleconfig");
                SetRelatedEntities("msdyn_postconfig_msdyn_postruleconfig", null, value);
                OnPropertyChanged("msdyn_postconfig_msdyn_postruleconfig");
            }
        }

        /// <summary>
        ///     1:N msdyn_postconfig_PrincipalObjectAttributeAccesses
        /// </summary>
        [RelationshipSchemaName("msdyn_postconfig_PrincipalObjectAttributeAccesses")]
        public IEnumerable<PrincipalObjectAttributeAccess> msdyn_postconfig_PrincipalObjectAttributeAccesses
        {
            get
            {
                return
                    GetRelatedEntities<PrincipalObjectAttributeAccess>(
                        "msdyn_postconfig_PrincipalObjectAttributeAccesses", null);
            }
            set
            {
                OnPropertyChanging("msdyn_postconfig_PrincipalObjectAttributeAccesses");
                SetRelatedEntities("msdyn_postconfig_PrincipalObjectAttributeAccesses", null, value);
                OnPropertyChanged("msdyn_postconfig_PrincipalObjectAttributeAccesses");
            }
        }

        /// <summary>
        ///     1:N msdyn_postconfig_ProcessSession
        /// </summary>
        [RelationshipSchemaName("msdyn_postconfig_ProcessSession")]
        public IEnumerable<ProcessSession> msdyn_postconfig_ProcessSession
        {
            get { return GetRelatedEntities<ProcessSession>("msdyn_postconfig_ProcessSession", null); }
            set
            {
                OnPropertyChanging("msdyn_postconfig_ProcessSession");
                SetRelatedEntities("msdyn_postconfig_ProcessSession", null, value);
                OnPropertyChanged("msdyn_postconfig_ProcessSession");
            }
        }

        /// <summary>
        ///     1:N msdyn_postconfig_UserEntityInstanceDatas
        /// </summary>
        [RelationshipSchemaName("msdyn_postconfig_UserEntityInstanceDatas")]
        public IEnumerable<UserEntityInstanceData> msdyn_postconfig_UserEntityInstanceDatas
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("msdyn_postconfig_UserEntityInstanceDatas", null); }
            set
            {
                OnPropertyChanging("msdyn_postconfig_UserEntityInstanceDatas");
                SetRelatedEntities("msdyn_postconfig_UserEntityInstanceDatas", null, value);
                OnPropertyChanged("msdyn_postconfig_UserEntityInstanceDatas");
            }
        }

        /// <summary>
        ///     1:N msdyn_postconfig_wallsavedquery
        /// </summary>
        [RelationshipSchemaName("msdyn_postconfig_wallsavedquery")]
        public IEnumerable<msdyn_wallsavedquery> msdyn_postconfig_wallsavedquery
        {
            get { return GetRelatedEntities<msdyn_wallsavedquery>("msdyn_postconfig_wallsavedquery", null); }
            set
            {
                OnPropertyChanging("msdyn_postconfig_wallsavedquery");
                SetRelatedEntities("msdyn_postconfig_wallsavedquery", null, value);
                OnPropertyChanged("msdyn_postconfig_wallsavedquery");
            }
        }

        /// <summary>
        ///     N:1 lk_msdyn_postconfig_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_msdyn_postconfig_createdby")]
        public SystemUser lk_msdyn_postconfig_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_msdyn_postconfig_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_msdyn_postconfig_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_msdyn_postconfig_createdonbehalfby")]
        public SystemUser lk_msdyn_postconfig_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_msdyn_postconfig_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_msdyn_postconfig_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_msdyn_postconfig_modifiedby")]
        public SystemUser lk_msdyn_postconfig_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_msdyn_postconfig_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_msdyn_postconfig_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_msdyn_postconfig_modifiedonbehalfby")]
        public SystemUser lk_msdyn_postconfig_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_msdyn_postconfig_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 organization_msdyn_postconfig
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_msdyn_postconfig")]
        public Organization organization_msdyn_postconfig
        {
            get { return GetRelatedEntity<Organization>("organization_msdyn_postconfig", null); }
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