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
    ///     Enable or disable system post rules for an entity for Activity Feeds and Yammer.
    /// </summary>
    [DataContract]
    [EntityLogicalName("msdyn_postruleconfig")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class msdyn_PostRuleConfig : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "msdyn_postruleconfig";

        public const int EntityTypeCode = 10002;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public msdyn_PostRuleConfig() :
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
        ///     Internal Use Only.
        /// </summary>
        [AttributeLogicalName("msdyn_formatid")]
        public string msdyn_FormatId
        {
            get { return GetAttributeValue<string>("msdyn_formatid"); }
            set
            {
                OnPropertyChanging("msdyn_FormatId");
                SetAttributeValue("msdyn_formatid", value);
                OnPropertyChanged("msdyn_FormatId");
            }
        }

        /// <summary>
        ///     Name of the rule.
        /// </summary>
        [AttributeLogicalName("msdyn_name")]
        public string msdyn_name
        {
            get { return GetAttributeValue<string>("msdyn_name"); }
            set
            {
                OnPropertyChanging("msdyn_name");
                SetAttributeValue("msdyn_name", value);
                OnPropertyChanged("msdyn_name");
            }
        }

        /// <summary>
        ///     Entity that is enabled for Activity feeds.
        /// </summary>
        [AttributeLogicalName("msdyn_postconfigid")]
        public EntityReference msdyn_PostConfigId
        {
            get { return GetAttributeValue<EntityReference>("msdyn_postconfigid"); }
            set
            {
                OnPropertyChanging("msdyn_PostConfigId");
                SetAttributeValue("msdyn_postconfigid", value);
                OnPropertyChanged("msdyn_PostConfigId");
            }
        }

        /// <summary>
        ///     Unique identifier of the post rule configuration.
        /// </summary>
        [AttributeLogicalName("msdyn_postruleconfigid")]
        public Guid? msdyn_PostRuleConfigId
        {
            get { return GetAttributeValue<Guid?>("msdyn_postruleconfigid"); }
            set
            {
                OnPropertyChanging("msdyn_PostRuleConfigId");
                SetAttributeValue("msdyn_postruleconfigid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("msdyn_PostRuleConfigId");
            }
        }

        [AttributeLogicalName("msdyn_postruleconfigid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { msdyn_PostRuleConfigId = value; }
        }

        /// <summary>
        ///     Determine whether to post this message to the Yammer Activity Stream. Please do not check this box if this message
        ///     contains sensitive information requiring Microsoft Dynamics CRM access.
        /// </summary>
        [AttributeLogicalName("msdyn_posttoyammer")]
        public bool? msdyn_PostToYammer
        {
            get { return GetAttributeValue<bool?>("msdyn_posttoyammer"); }
            set
            {
                OnPropertyChanging("msdyn_PostToYammer");
                SetAttributeValue("msdyn_posttoyammer", value);
                OnPropertyChanged("msdyn_PostToYammer");
            }
        }

        /// <summary>
        ///     Identifier in the format WebResourceName:SchemaName of the definition for this rule.
        /// </summary>
        [AttributeLogicalName("msdyn_ruleid")]
        public string msdyn_RuleId
        {
            get { return GetAttributeValue<string>("msdyn_ruleid"); }
            set
            {
                OnPropertyChanging("msdyn_RuleId");
                SetAttributeValue("msdyn_ruleid", value);
                OnPropertyChanged("msdyn_RuleId");
            }
        }

        /// <summary>
        ///     Internal Use Only.
        /// </summary>
        [AttributeLogicalName("msdyn_rulesource")]
        public string msdyn_RuleSource
        {
            get { return GetAttributeValue<string>("msdyn_rulesource"); }
            set
            {
                OnPropertyChanging("msdyn_RuleSource");
                SetAttributeValue("msdyn_rulesource", value);
                OnPropertyChanged("msdyn_RuleSource");
            }
        }

        /// <summary>
        ///     Unique identifier of the SDK message processing step for this rule.
        /// </summary>
        [AttributeLogicalName("msdyn_stepid")]
        public string msdyn_StepId
        {
            get { return GetAttributeValue<string>("msdyn_stepid"); }
            set
            {
                OnPropertyChanging("msdyn_StepId");
                SetAttributeValue("msdyn_stepid", value);
                OnPropertyChanged("msdyn_StepId");
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
        ///     Status of the Post Rule Configuration
        /// </summary>
        [AttributeLogicalName("statecode")]
        public msdyn_PostRuleConfigState? statecode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return
                        ((msdyn_PostRuleConfigState)
                            (Enum.ToObject(typeof (msdyn_PostRuleConfigState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the Post Rule Configuration
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
        ///     1:N msdyn_postruleconfig_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("msdyn_postruleconfig_AsyncOperations")]
        public IEnumerable<AsyncOperation> msdyn_postruleconfig_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("msdyn_postruleconfig_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("msdyn_postruleconfig_AsyncOperations");
                SetRelatedEntities("msdyn_postruleconfig_AsyncOperations", null, value);
                OnPropertyChanged("msdyn_postruleconfig_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N msdyn_postruleconfig_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("msdyn_postruleconfig_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> msdyn_postruleconfig_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_postruleconfig_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("msdyn_postruleconfig_BulkDeleteFailures");
                SetRelatedEntities("msdyn_postruleconfig_BulkDeleteFailures", null, value);
                OnPropertyChanged("msdyn_postruleconfig_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N msdyn_postruleconfig_PrincipalObjectAttributeAccesses
        /// </summary>
        [RelationshipSchemaName("msdyn_postruleconfig_PrincipalObjectAttributeAccesses")]
        public IEnumerable<PrincipalObjectAttributeAccess> msdyn_postruleconfig_PrincipalObjectAttributeAccesses
        {
            get
            {
                return
                    GetRelatedEntities<PrincipalObjectAttributeAccess>(
                        "msdyn_postruleconfig_PrincipalObjectAttributeAccesses", null);
            }
            set
            {
                OnPropertyChanging("msdyn_postruleconfig_PrincipalObjectAttributeAccesses");
                SetRelatedEntities("msdyn_postruleconfig_PrincipalObjectAttributeAccesses", null, value);
                OnPropertyChanged("msdyn_postruleconfig_PrincipalObjectAttributeAccesses");
            }
        }

        /// <summary>
        ///     1:N msdyn_postruleconfig_ProcessSession
        /// </summary>
        [RelationshipSchemaName("msdyn_postruleconfig_ProcessSession")]
        public IEnumerable<ProcessSession> msdyn_postruleconfig_ProcessSession
        {
            get { return GetRelatedEntities<ProcessSession>("msdyn_postruleconfig_ProcessSession", null); }
            set
            {
                OnPropertyChanging("msdyn_postruleconfig_ProcessSession");
                SetRelatedEntities("msdyn_postruleconfig_ProcessSession", null, value);
                OnPropertyChanged("msdyn_postruleconfig_ProcessSession");
            }
        }

        /// <summary>
        ///     1:N msdyn_postruleconfig_UserEntityInstanceDatas
        /// </summary>
        [RelationshipSchemaName("msdyn_postruleconfig_UserEntityInstanceDatas")]
        public IEnumerable<UserEntityInstanceData> msdyn_postruleconfig_UserEntityInstanceDatas
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("msdyn_postruleconfig_UserEntityInstanceDatas", null);
            }
            set
            {
                OnPropertyChanging("msdyn_postruleconfig_UserEntityInstanceDatas");
                SetRelatedEntities("msdyn_postruleconfig_UserEntityInstanceDatas", null, value);
                OnPropertyChanged("msdyn_postruleconfig_UserEntityInstanceDatas");
            }
        }

        /// <summary>
        ///     N:1 lk_msdyn_postruleconfig_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_msdyn_postruleconfig_createdby")]
        public SystemUser lk_msdyn_postruleconfig_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_msdyn_postruleconfig_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_msdyn_postruleconfig_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_msdyn_postruleconfig_createdonbehalfby")]
        public SystemUser lk_msdyn_postruleconfig_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_msdyn_postruleconfig_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_msdyn_postruleconfig_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_msdyn_postruleconfig_modifiedby")]
        public SystemUser lk_msdyn_postruleconfig_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_msdyn_postruleconfig_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_msdyn_postruleconfig_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_msdyn_postruleconfig_modifiedonbehalfby")]
        public SystemUser lk_msdyn_postruleconfig_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_msdyn_postruleconfig_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 msdyn_postconfig_msdyn_postruleconfig
        /// </summary>
        [AttributeLogicalName("msdyn_postconfigid")]
        [RelationshipSchemaName("msdyn_postconfig_msdyn_postruleconfig")]
        public msdyn_PostConfig msdyn_postconfig_msdyn_postruleconfig
        {
            get { return GetRelatedEntity<msdyn_PostConfig>("msdyn_postconfig_msdyn_postruleconfig", null); }
            set
            {
                OnPropertyChanging("msdyn_postconfig_msdyn_postruleconfig");
                SetRelatedEntity("msdyn_postconfig_msdyn_postruleconfig", null, value);
                OnPropertyChanged("msdyn_postconfig_msdyn_postruleconfig");
            }
        }

        /// <summary>
        ///     N:1 organization_msdyn_postruleconfig
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_msdyn_postruleconfig")]
        public Organization organization_msdyn_postruleconfig
        {
            get { return GetRelatedEntity<Organization>("organization_msdyn_postruleconfig", null); }
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