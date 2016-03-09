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
    ///     Contains user personalization information regarding which of the administrator’s selected views to display on a
    ///     user’s personal wall.
    /// </summary>
    [DataContract]
    [EntityLogicalName("msdyn_wallsavedqueryusersettings")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class msdyn_wallsavedqueryusersettings : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "msdyn_wallsavedqueryusersettings";

        public const int EntityTypeCode = 10004;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public msdyn_wallsavedqueryusersettings() :
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
        ///     XML blob that stores personalization data for the user.
        /// </summary>
        [AttributeLogicalName("msdyn_data")]
        public string msdyn_data
        {
            get { return GetAttributeValue<string>("msdyn_data"); }
            set
            {
                OnPropertyChanging("msdyn_data");
                SetAttributeValue("msdyn_data", value);
                OnPropertyChanged("msdyn_data");
            }
        }

        /// <summary>
        ///     Indicates that view is selected by default if value is greater than 0. Also contains information which specific
        ///     filter is applied.
        /// </summary>
        [AttributeLogicalName("msdyn_default")]
        public int? msdyn_default
        {
            get { return GetAttributeValue<int?>("msdyn_default"); }
            set
            {
                OnPropertyChanging("msdyn_default");
                SetAttributeValue("msdyn_default", value);
                OnPropertyChanged("msdyn_default");
            }
        }

        /// <summary>
        ///     Display name of the entity to which the corresponding views belong.
        /// </summary>
        [AttributeLogicalName("msdyn_entitydisplayname")]
        public string msdyn_entitydisplayname
        {
            get { return GetAttributeValue<string>("msdyn_entitydisplayname"); }
            set
            {
                OnPropertyChanging("msdyn_entitydisplayname");
                SetAttributeValue("msdyn_entitydisplayname", value);
                OnPropertyChanged("msdyn_entitydisplayname");
            }
        }

        /// <summary>
        ///     Name of the entity to which the corresponding views belong.
        /// </summary>
        [AttributeLogicalName("msdyn_entityname")]
        public string msdyn_entityname
        {
            get { return GetAttributeValue<string>("msdyn_entityname"); }
            set
            {
                OnPropertyChanging("msdyn_entityname");
                SetAttributeValue("msdyn_entityname", value);
                OnPropertyChanged("msdyn_entityname");
            }
        }

        /// <summary>
        ///     Indicates that wall should be included in response to avoid roundtrips to server
        /// </summary>
        [AttributeLogicalName("msdyn_includewallinresponse")]
        public bool? msdyn_includewallinresponse
        {
            get { return GetAttributeValue<bool?>("msdyn_includewallinresponse"); }
            set
            {
                OnPropertyChanging("msdyn_includewallinresponse");
                SetAttributeValue("msdyn_includewallinresponse", value);
                OnPropertyChanged("msdyn_includewallinresponse");
            }
        }

        /// <summary>
        ///     Indicates that corresponding view is following view
        /// </summary>
        [AttributeLogicalName("msdyn_isfollowing")]
        public bool? msdyn_isfollowing
        {
            get { return GetAttributeValue<bool?>("msdyn_isfollowing"); }
            set
            {
                OnPropertyChanging("msdyn_isfollowing");
                SetAttributeValue("msdyn_isfollowing", value);
                OnPropertyChanged("msdyn_isfollowing");
            }
        }

        /// <summary>
        ///     Indicates that the record is virtual
        /// </summary>
        [AttributeLogicalName("msdyn_isvirtual")]
        public bool? msdyn_IsVirtual
        {
            get { return GetAttributeValue<bool?>("msdyn_isvirtual"); }
            set
            {
                OnPropertyChanging("msdyn_IsVirtual");
                SetAttributeValue("msdyn_isvirtual", value);
                OnPropertyChanged("msdyn_IsVirtual");
            }
        }

        /// <summary>
        ///     Information that indicates whether the corresponding view should be displayed on the personal wall for this user.
        /// </summary>
        [AttributeLogicalName("msdyn_isvisible")]
        public bool? msdyn_isvisible
        {
            get { return GetAttributeValue<bool?>("msdyn_isvisible"); }
            set
            {
                OnPropertyChanging("msdyn_isvisible");
                SetAttributeValue("msdyn_isvisible", value);
                OnPropertyChanged("msdyn_isvisible");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("msdyn_isvisiblebit")]
        public int? msdyn_isvisiblebit
        {
            get { return GetAttributeValue<int?>("msdyn_isvisiblebit"); }
            set
            {
                OnPropertyChanging("msdyn_isvisiblebit");
                SetAttributeValue("msdyn_isvisiblebit", value);
                OnPropertyChanged("msdyn_isvisiblebit");
            }
        }

        /// <summary>
        ///     Virtual column which contains entity type code for the entities returned by corresponding savedquery
        /// </summary>
        [AttributeLogicalName("msdyn_otc")]
        public int? msdyn_otc
        {
            get { return GetAttributeValue<int?>("msdyn_otc"); }
            set
            {
                OnPropertyChanging("msdyn_otc");
                SetAttributeValue("msdyn_otc", value);
                OnPropertyChanged("msdyn_otc");
            }
        }

        /// <summary>
        ///     Name of the corresponding view.
        /// </summary>
        [AttributeLogicalName("msdyn_savedqueryname")]
        public string msdyn_savedqueryname
        {
            get { return GetAttributeValue<string>("msdyn_savedqueryname"); }
            set
            {
                OnPropertyChanging("msdyn_savedqueryname");
                SetAttributeValue("msdyn_savedqueryname", value);
                OnPropertyChanged("msdyn_savedqueryname");
            }
        }

        /// <summary>
        ///     Sort order to be used when displaying the filter on the user’s personal wall.
        /// </summary>
        [AttributeLogicalName("msdyn_sortorder")]
        public int? msdyn_sortorder
        {
            get { return GetAttributeValue<int?>("msdyn_sortorder"); }
            set
            {
                OnPropertyChanging("msdyn_sortorder");
                SetAttributeValue("msdyn_sortorder", value);
                OnPropertyChanged("msdyn_sortorder");
            }
        }

        /// <summary>
        ///     Reserved to support different view types. Currently not used.
        /// </summary>
        [AttributeLogicalName("msdyn_type")]
        public int? msdyn_type
        {
            get { return GetAttributeValue<int?>("msdyn_type"); }
            set
            {
                OnPropertyChanging("msdyn_type");
                SetAttributeValue("msdyn_type", value);
                OnPropertyChanged("msdyn_type");
            }
        }

        /// <summary>
        ///     Unique identifier for User associated with Wall View User Setting.
        /// </summary>
        [AttributeLogicalName("msdyn_userid")]
        public EntityReference msdyn_userid
        {
            get { return GetAttributeValue<EntityReference>("msdyn_userid"); }
            set
            {
                OnPropertyChanging("msdyn_userid");
                SetAttributeValue("msdyn_userid", value);
                OnPropertyChanged("msdyn_userid");
            }
        }

        /// <summary>
        ///     Unique identifier for Wall View associated with Wall View User Setting.
        /// </summary>
        [AttributeLogicalName("msdyn_wallsavedqueryid")]
        public EntityReference msdyn_wallsavedqueryid
        {
            get { return GetAttributeValue<EntityReference>("msdyn_wallsavedqueryid"); }
            set
            {
                OnPropertyChanging("msdyn_wallsavedqueryid");
                SetAttributeValue("msdyn_wallsavedqueryid", value);
                OnPropertyChanged("msdyn_wallsavedqueryid");
            }
        }

        /// <summary>
        ///     Unique identifier for entity instances
        /// </summary>
        [AttributeLogicalName("msdyn_wallsavedqueryusersettingsid")]
        public Guid? msdyn_wallsavedqueryusersettingsId
        {
            get { return GetAttributeValue<Guid?>("msdyn_wallsavedqueryusersettingsid"); }
            set
            {
                OnPropertyChanging("msdyn_wallsavedqueryusersettingsId");
                SetAttributeValue("msdyn_wallsavedqueryusersettingsid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("msdyn_wallsavedqueryusersettingsId");
            }
        }

        [AttributeLogicalName("msdyn_wallsavedqueryusersettingsid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { msdyn_wallsavedqueryusersettingsId = value; }
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
        ///     Owner Id
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
        ///     Unique identifier for the business unit that owns the record
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier for the team that owns the record.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier for the user that owns the record.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Status of the Wall View User Setting
        /// </summary>
        [AttributeLogicalName("statecode")]
        public msdyn_wallsavedqueryusersettingsState? statecode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return
                        ((msdyn_wallsavedqueryusersettingsState)
                            (Enum.ToObject(typeof (msdyn_wallsavedqueryusersettingsState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the Wall View User Setting
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
        ///     1:N msdyn_wallsavedqueryusersettings_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("msdyn_wallsavedqueryusersettings_AsyncOperations")]
        public IEnumerable<AsyncOperation> msdyn_wallsavedqueryusersettings_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("msdyn_wallsavedqueryusersettings_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("msdyn_wallsavedqueryusersettings_AsyncOperations");
                SetRelatedEntities("msdyn_wallsavedqueryusersettings_AsyncOperations", null, value);
                OnPropertyChanged("msdyn_wallsavedqueryusersettings_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N msdyn_wallsavedqueryusersettings_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("msdyn_wallsavedqueryusersettings_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> msdyn_wallsavedqueryusersettings_BulkDeleteFailures
        {
            get
            {
                return GetRelatedEntities<BulkDeleteFailure>("msdyn_wallsavedqueryusersettings_BulkDeleteFailures", null);
            }
            set
            {
                OnPropertyChanging("msdyn_wallsavedqueryusersettings_BulkDeleteFailures");
                SetRelatedEntities("msdyn_wallsavedqueryusersettings_BulkDeleteFailures", null, value);
                OnPropertyChanged("msdyn_wallsavedqueryusersettings_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses
        /// </summary>
        [RelationshipSchemaName("msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses")]
        public IEnumerable<PrincipalObjectAttributeAccess>
            msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses
        {
            get
            {
                return
                    GetRelatedEntities<PrincipalObjectAttributeAccess>(
                        "msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses", null);
            }
            set
            {
                OnPropertyChanging("msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses");
                SetRelatedEntities("msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses", null, value);
                OnPropertyChanged("msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses");
            }
        }

        /// <summary>
        ///     1:N msdyn_wallsavedqueryusersettings_ProcessSession
        /// </summary>
        [RelationshipSchemaName("msdyn_wallsavedqueryusersettings_ProcessSession")]
        public IEnumerable<ProcessSession> msdyn_wallsavedqueryusersettings_ProcessSession
        {
            get { return GetRelatedEntities<ProcessSession>("msdyn_wallsavedqueryusersettings_ProcessSession", null); }
            set
            {
                OnPropertyChanging("msdyn_wallsavedqueryusersettings_ProcessSession");
                SetRelatedEntities("msdyn_wallsavedqueryusersettings_ProcessSession", null, value);
                OnPropertyChanged("msdyn_wallsavedqueryusersettings_ProcessSession");
            }
        }

        /// <summary>
        ///     1:N msdyn_wallsavedqueryusersettings_UserEntityInstanceDatas
        /// </summary>
        [RelationshipSchemaName("msdyn_wallsavedqueryusersettings_UserEntityInstanceDatas")]
        public IEnumerable<UserEntityInstanceData> msdyn_wallsavedqueryusersettings_UserEntityInstanceDatas
        {
            get
            {
                return
                    GetRelatedEntities<UserEntityInstanceData>(
                        "msdyn_wallsavedqueryusersettings_UserEntityInstanceDatas", null);
            }
            set
            {
                OnPropertyChanging("msdyn_wallsavedqueryusersettings_UserEntityInstanceDatas");
                SetRelatedEntities("msdyn_wallsavedqueryusersettings_UserEntityInstanceDatas", null, value);
                OnPropertyChanged("msdyn_wallsavedqueryusersettings_UserEntityInstanceDatas");
            }
        }

        /// <summary>
        ///     N:1 business_unit_msdyn_wallsavedqueryusersettings
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_msdyn_wallsavedqueryusersettings")]
        public BusinessUnit business_unit_msdyn_wallsavedqueryusersettings
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_msdyn_wallsavedqueryusersettings", null); }
        }

        /// <summary>
        ///     N:1 lk_msdyn_wallsavedqueryusersettings_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_msdyn_wallsavedqueryusersettings_createdby")]
        public SystemUser lk_msdyn_wallsavedqueryusersettings_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_msdyn_wallsavedqueryusersettings_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_msdyn_wallsavedqueryusersettings_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_msdyn_wallsavedqueryusersettings_createdonbehalfby")]
        public SystemUser lk_msdyn_wallsavedqueryusersettings_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_msdyn_wallsavedqueryusersettings_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_msdyn_wallsavedqueryusersettings_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_msdyn_wallsavedqueryusersettings_modifiedby")]
        public SystemUser lk_msdyn_wallsavedqueryusersettings_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_msdyn_wallsavedqueryusersettings_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby")]
        public SystemUser lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 msdyn_systemuser_wallsavedqueryusersettings_userid
        /// </summary>
        [AttributeLogicalName("msdyn_userid")]
        [RelationshipSchemaName("msdyn_systemuser_wallsavedqueryusersettings_userid")]
        public SystemUser msdyn_systemuser_wallsavedqueryusersettings_userid
        {
            get { return GetRelatedEntity<SystemUser>("msdyn_systemuser_wallsavedqueryusersettings_userid", null); }
            set
            {
                OnPropertyChanging("msdyn_systemuser_wallsavedqueryusersettings_userid");
                SetRelatedEntity("msdyn_systemuser_wallsavedqueryusersettings_userid", null, value);
                OnPropertyChanged("msdyn_systemuser_wallsavedqueryusersettings_userid");
            }
        }

        /// <summary>
        ///     N:1 msdyn_wallsavedquery_wallsavedqueryusersettings
        /// </summary>
        [AttributeLogicalName("msdyn_wallsavedqueryid")]
        [RelationshipSchemaName("msdyn_wallsavedquery_wallsavedqueryusersettings")]
        public msdyn_wallsavedquery msdyn_wallsavedquery_wallsavedqueryusersettings
        {
            get
            {
                return GetRelatedEntity<msdyn_wallsavedquery>("msdyn_wallsavedquery_wallsavedqueryusersettings", null);
            }
            set
            {
                OnPropertyChanging("msdyn_wallsavedquery_wallsavedqueryusersettings");
                SetRelatedEntity("msdyn_wallsavedquery_wallsavedqueryusersettings", null, value);
                OnPropertyChanged("msdyn_wallsavedquery_wallsavedqueryusersettings");
            }
        }

        /// <summary>
        ///     N:1 team_msdyn_wallsavedqueryusersettings
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_msdyn_wallsavedqueryusersettings")]
        public Team team_msdyn_wallsavedqueryusersettings
        {
            get { return GetRelatedEntity<Team>("team_msdyn_wallsavedqueryusersettings", null); }
        }

        /// <summary>
        ///     N:1 user_msdyn_wallsavedqueryusersettings
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_msdyn_wallsavedqueryusersettings")]
        public SystemUser user_msdyn_wallsavedqueryusersettings
        {
            get { return GetRelatedEntity<SystemUser>("user_msdyn_wallsavedqueryusersettings", null); }
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