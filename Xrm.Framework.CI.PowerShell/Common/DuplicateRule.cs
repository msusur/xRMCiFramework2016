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
    ///     Rule used to identify potential duplicates.
    /// </summary>
    [DataContract]
    [EntityLogicalName("duplicaterule")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class DuplicateRule : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "duplicaterule";

        public const int EntityTypeCode = 4414;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public DuplicateRule() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Database table that stores match codes for the record type being evaluated for potential duplicates.
        /// </summary>
        [AttributeLogicalName("baseentitymatchcodetable")]
        public string BaseEntityMatchCodeTable
        {
            get { return GetAttributeValue<string>("baseentitymatchcodetable"); }
        }

        /// <summary>
        ///     Record type of the record being evaluated for potential duplicates.
        /// </summary>
        [AttributeLogicalName("baseentityname")]
        public string BaseEntityName
        {
            get { return GetAttributeValue<string>("baseentityname"); }
            set
            {
                OnPropertyChanging("BaseEntityName");
                SetAttributeValue("baseentityname", value);
                OnPropertyChanged("BaseEntityName");
            }
        }

        /// <summary>
        ///     Record type of the record being evaluated for potential duplicates.
        /// </summary>
        [AttributeLogicalName("baseentitytypecode")]
        public OptionSetValue BaseEntityTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("baseentitytypecode"); }
        }

        /// <summary>
        ///     Unique identifier of the user who created the duplicate detection rule.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the duplicate detection rule was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the duplicaterule.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Description of the duplicate detection rule.
        /// </summary>
        [AttributeLogicalName("description")]
        public string Description
        {
            get { return GetAttributeValue<string>("description"); }
            set
            {
                OnPropertyChanging("Description");
                SetAttributeValue("description", value);
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        ///     Unique identifier of the duplicate detection rule.
        /// </summary>
        [AttributeLogicalName("duplicateruleid")]
        public Guid? DuplicateRuleId
        {
            get { return GetAttributeValue<Guid?>("duplicateruleid"); }
            set
            {
                OnPropertyChanging("DuplicateRuleId");
                SetAttributeValue("duplicateruleid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("DuplicateRuleId");
            }
        }

        [AttributeLogicalName("duplicateruleid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { DuplicateRuleId = value; }
        }

        /// <summary>
        ///     Determines whether to flag inactive records as duplicates
        /// </summary>
        [AttributeLogicalName("excludeinactiverecords")]
        public bool? ExcludeInactiveRecords
        {
            get { return GetAttributeValue<bool?>("excludeinactiverecords"); }
            set
            {
                OnPropertyChanging("ExcludeInactiveRecords");
                SetAttributeValue("excludeinactiverecords", value);
                OnPropertyChanged("ExcludeInactiveRecords");
            }
        }

        /// <summary>
        ///     Indicates if the operator is case-sensitive.
        /// </summary>
        [AttributeLogicalName("iscasesensitive")]
        public bool? IsCaseSensitive
        {
            get { return GetAttributeValue<bool?>("iscasesensitive"); }
            set
            {
                OnPropertyChanging("IsCaseSensitive");
                SetAttributeValue("iscasesensitive", value);
                OnPropertyChanged("IsCaseSensitive");
            }
        }

        /// <summary>
        ///     Database table that stores match codes for potential duplicate records.
        /// </summary>
        [AttributeLogicalName("matchingentitymatchcodetable")]
        public string MatchingEntityMatchCodeTable
        {
            get { return GetAttributeValue<string>("matchingentitymatchcodetable"); }
        }

        /// <summary>
        ///     Record type of the records being evaluated as potential duplicates.
        /// </summary>
        [AttributeLogicalName("matchingentityname")]
        public string MatchingEntityName
        {
            get { return GetAttributeValue<string>("matchingentityname"); }
            set
            {
                OnPropertyChanging("MatchingEntityName");
                SetAttributeValue("matchingentityname", value);
                OnPropertyChanged("MatchingEntityName");
            }
        }

        /// <summary>
        ///     Record type of the records being evaluated as potential duplicates.
        /// </summary>
        [AttributeLogicalName("matchingentitytypecode")]
        public OptionSetValue MatchingEntityTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("matchingentitytypecode"); }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the duplicate detection rule.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the duplicate detection rule was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the duplicaterule.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the duplicate detection rule.
        /// </summary>
        [AttributeLogicalName("name")]
        public string Name
        {
            get { return GetAttributeValue<string>("name"); }
            set
            {
                OnPropertyChanging("Name");
                SetAttributeValue("name", value);
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        ///     Unique identifier of the user or team who owns the duplicate detection rule.
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
        ///     Unique identifier of the business unit that owns duplicate detection rule.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the duplicate detection rule.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the duplicate detection rule.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Status of the duplicate detection rule.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public DuplicateRuleState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((DuplicateRuleState) (Enum.ToObject(typeof (DuplicateRuleState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the duplicate detection rule.
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
        ///     1:N DuplicateRule_Annotation
        /// </summary>
        [RelationshipSchemaName("DuplicateRule_Annotation")]
        public IEnumerable<Annotation> DuplicateRule_Annotation
        {
            get { return GetRelatedEntities<Annotation>("DuplicateRule_Annotation", null); }
            set
            {
                OnPropertyChanging("DuplicateRule_Annotation");
                SetRelatedEntities("DuplicateRule_Annotation", null, value);
                OnPropertyChanged("DuplicateRule_Annotation");
            }
        }

        /// <summary>
        ///     1:N DuplicateRule_DuplicateBaseRecord
        /// </summary>
        [RelationshipSchemaName("DuplicateRule_DuplicateBaseRecord")]
        public IEnumerable<DuplicateRecord> DuplicateRule_DuplicateBaseRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("DuplicateRule_DuplicateBaseRecord", null); }
            set
            {
                OnPropertyChanging("DuplicateRule_DuplicateBaseRecord");
                SetRelatedEntities("DuplicateRule_DuplicateBaseRecord", null, value);
                OnPropertyChanged("DuplicateRule_DuplicateBaseRecord");
            }
        }

        /// <summary>
        ///     1:N DuplicateRule_DuplicateRuleConditions
        /// </summary>
        [RelationshipSchemaName("DuplicateRule_DuplicateRuleConditions")]
        public IEnumerable<DuplicateRuleCondition> DuplicateRule_DuplicateRuleConditions
        {
            get { return GetRelatedEntities<DuplicateRuleCondition>("DuplicateRule_DuplicateRuleConditions", null); }
            set
            {
                OnPropertyChanging("DuplicateRule_DuplicateRuleConditions");
                SetRelatedEntities("DuplicateRule_DuplicateRuleConditions", null, value);
                OnPropertyChanged("DuplicateRule_DuplicateRuleConditions");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_duplicaterule
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_duplicaterule")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_duplicaterule
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_duplicaterule", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_duplicaterule");
                SetRelatedEntities("userentityinstancedata_duplicaterule", null, value);
                OnPropertyChanged("userentityinstancedata_duplicaterule");
            }
        }

        /// <summary>
        ///     N:1 BusinessUnit_DuplicateRules
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("BusinessUnit_DuplicateRules")]
        public BusinessUnit BusinessUnit_DuplicateRules
        {
            get { return GetRelatedEntity<BusinessUnit>("BusinessUnit_DuplicateRules", null); }
        }

        /// <summary>
        ///     N:1 lk_duplicaterule_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_duplicaterule_createdonbehalfby")]
        public SystemUser lk_duplicaterule_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_duplicaterule_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_duplicaterule_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_duplicaterule_modifiedonbehalfby")]
        public SystemUser lk_duplicaterule_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_duplicaterule_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_duplicaterulebase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_duplicaterulebase_createdby")]
        public SystemUser lk_duplicaterulebase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_duplicaterulebase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_duplicaterulebase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_duplicaterulebase_modifiedby")]
        public SystemUser lk_duplicaterulebase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_duplicaterulebase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 SystemUser_DuplicateRules
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("SystemUser_DuplicateRules")]
        public SystemUser SystemUser_DuplicateRules
        {
            get { return GetRelatedEntity<SystemUser>("SystemUser_DuplicateRules", null); }
        }

        /// <summary>
        ///     N:1 team_DuplicateRules
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_DuplicateRules")]
        public Team team_DuplicateRules
        {
            get { return GetRelatedEntity<Team>("team_DuplicateRules", null); }
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