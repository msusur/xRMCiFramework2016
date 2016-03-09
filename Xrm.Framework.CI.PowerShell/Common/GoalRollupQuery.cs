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
    ///     Query that is used to filter the results of the goal rollup.
    /// </summary>
    [DataContract]
    [EntityLogicalName("goalrollupquery")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class GoalRollupQuery : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "goalrollupquery";

        public const int EntityTypeCode = 9602;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public GoalRollupQuery() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Shows who created the record.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Shows the date and time when the record was created. The date and time are displayed in the time zone selected in
        ///     Microsoft Dynamics CRM options.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Shows who created the record on behalf of another user.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     String that specifies the condition criteria in FetchXML.
        /// </summary>
        [AttributeLogicalName("fetchxml")]
        public string FetchXml
        {
            get { return GetAttributeValue<string>("fetchxml"); }
            set
            {
                OnPropertyChanging("FetchXml");
                SetAttributeValue("fetchxml", value);
                OnPropertyChanged("FetchXml");
            }
        }

        /// <summary>
        ///     Unique identifier of the rollup query.
        /// </summary>
        [AttributeLogicalName("goalrollupqueryid")]
        public Guid? GoalRollupQueryId
        {
            get { return GetAttributeValue<Guid?>("goalrollupqueryid"); }
            set
            {
                OnPropertyChanging("GoalRollupQueryId");
                SetAttributeValue("goalrollupqueryid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("GoalRollupQueryId");
            }
        }

        [AttributeLogicalName("goalrollupqueryid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { GoalRollupQueryId = value; }
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
        ///     Shows who last updated the record.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected
        ///     in Microsoft Dynamics CRM options.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Shows who last updated the record on behalf of another user.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Type a descriptive name for the goal rollup query.
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
        ///     Enter the user or team who is assigned to manage the record. This field is updated every time the record is
        ///     assigned to a different user.
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
        ///     Unique identifier of the business unit that owns the record.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the record.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the record.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Enter the record type of the rollup query.
        /// </summary>
        [AttributeLogicalName("queryentitytype")]
        public string QueryEntityType
        {
            get { return GetAttributeValue<string>("queryentitytype"); }
            set
            {
                OnPropertyChanging("QueryEntityType");
                SetAttributeValue("queryentitytype", value);
                OnPropertyChanged("QueryEntityType");
            }
        }

        /// <summary>
        ///     Shows whether the goal rollup query is active or inactive.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public GoalRollupQueryState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((GoalRollupQueryState) (Enum.ToObject(typeof (GoalRollupQueryState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Select the goal rollup query's status.
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
        ///     Version number of the goal rollup query.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N goal_rollupquery_actualdecimal
        /// </summary>
        [RelationshipSchemaName("goal_rollupquery_actualdecimal")]
        public IEnumerable<Goal> goal_rollupquery_actualdecimal
        {
            get { return GetRelatedEntities<Goal>("goal_rollupquery_actualdecimal", null); }
            set
            {
                OnPropertyChanging("goal_rollupquery_actualdecimal");
                SetRelatedEntities("goal_rollupquery_actualdecimal", null, value);
                OnPropertyChanged("goal_rollupquery_actualdecimal");
            }
        }

        /// <summary>
        ///     1:N goal_rollupquery_actualmoney
        /// </summary>
        [RelationshipSchemaName("goal_rollupquery_actualmoney")]
        public IEnumerable<Goal> goal_rollupquery_actualmoney
        {
            get { return GetRelatedEntities<Goal>("goal_rollupquery_actualmoney", null); }
            set
            {
                OnPropertyChanging("goal_rollupquery_actualmoney");
                SetRelatedEntities("goal_rollupquery_actualmoney", null, value);
                OnPropertyChanged("goal_rollupquery_actualmoney");
            }
        }

        /// <summary>
        ///     1:N goal_rollupquery_customdecimal
        /// </summary>
        [RelationshipSchemaName("goal_rollupquery_customdecimal")]
        public IEnumerable<Goal> goal_rollupquery_customdecimal
        {
            get { return GetRelatedEntities<Goal>("goal_rollupquery_customdecimal", null); }
            set
            {
                OnPropertyChanging("goal_rollupquery_customdecimal");
                SetRelatedEntities("goal_rollupquery_customdecimal", null, value);
                OnPropertyChanged("goal_rollupquery_customdecimal");
            }
        }

        /// <summary>
        ///     1:N goal_rollupquery_customint
        /// </summary>
        [RelationshipSchemaName("goal_rollupquery_customint")]
        public IEnumerable<Goal> goal_rollupquery_customint
        {
            get { return GetRelatedEntities<Goal>("goal_rollupquery_customint", null); }
            set
            {
                OnPropertyChanging("goal_rollupquery_customint");
                SetRelatedEntities("goal_rollupquery_customint", null, value);
                OnPropertyChanged("goal_rollupquery_customint");
            }
        }

        /// <summary>
        ///     1:N goal_rollupquery_custommoney
        /// </summary>
        [RelationshipSchemaName("goal_rollupquery_custommoney")]
        public IEnumerable<Goal> goal_rollupquery_custommoney
        {
            get { return GetRelatedEntities<Goal>("goal_rollupquery_custommoney", null); }
            set
            {
                OnPropertyChanging("goal_rollupquery_custommoney");
                SetRelatedEntities("goal_rollupquery_custommoney", null, value);
                OnPropertyChanged("goal_rollupquery_custommoney");
            }
        }

        /// <summary>
        ///     1:N goal_rollupquery_inprogressdecimal
        /// </summary>
        [RelationshipSchemaName("goal_rollupquery_inprogressdecimal")]
        public IEnumerable<Goal> goal_rollupquery_inprogressdecimal
        {
            get { return GetRelatedEntities<Goal>("goal_rollupquery_inprogressdecimal", null); }
            set
            {
                OnPropertyChanging("goal_rollupquery_inprogressdecimal");
                SetRelatedEntities("goal_rollupquery_inprogressdecimal", null, value);
                OnPropertyChanged("goal_rollupquery_inprogressdecimal");
            }
        }

        /// <summary>
        ///     1:N goal_rollupquery_inprogressint
        /// </summary>
        [RelationshipSchemaName("goal_rollupquery_inprogressint")]
        public IEnumerable<Goal> goal_rollupquery_inprogressint
        {
            get { return GetRelatedEntities<Goal>("goal_rollupquery_inprogressint", null); }
            set
            {
                OnPropertyChanging("goal_rollupquery_inprogressint");
                SetRelatedEntities("goal_rollupquery_inprogressint", null, value);
                OnPropertyChanged("goal_rollupquery_inprogressint");
            }
        }

        /// <summary>
        ///     1:N goal_rollupquery_inprogressmoney
        /// </summary>
        [RelationshipSchemaName("goal_rollupquery_inprogressmoney")]
        public IEnumerable<Goal> goal_rollupquery_inprogressmoney
        {
            get { return GetRelatedEntities<Goal>("goal_rollupquery_inprogressmoney", null); }
            set
            {
                OnPropertyChanging("goal_rollupquery_inprogressmoney");
                SetRelatedEntities("goal_rollupquery_inprogressmoney", null, value);
                OnPropertyChanged("goal_rollupquery_inprogressmoney");
            }
        }

        /// <summary>
        ///     1:N goalrollupquery_actualint
        /// </summary>
        [RelationshipSchemaName("goalrollupquery_actualint")]
        public IEnumerable<Goal> goalrollupquery_actualint
        {
            get { return GetRelatedEntities<Goal>("goalrollupquery_actualint", null); }
            set
            {
                OnPropertyChanging("goalrollupquery_actualint");
                SetRelatedEntities("goalrollupquery_actualint", null, value);
                OnPropertyChanged("goalrollupquery_actualint");
            }
        }

        /// <summary>
        ///     1:N goalrollupquery_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("goalrollupquery_AsyncOperations")]
        public IEnumerable<AsyncOperation> goalrollupquery_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("goalrollupquery_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("goalrollupquery_AsyncOperations");
                SetRelatedEntities("goalrollupquery_AsyncOperations", null, value);
                OnPropertyChanged("goalrollupquery_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N goalrollupquery_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("goalrollupquery_ProcessSessions")]
        public IEnumerable<ProcessSession> goalrollupquery_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("goalrollupquery_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("goalrollupquery_ProcessSessions");
                SetRelatedEntities("goalrollupquery_ProcessSessions", null, value);
                OnPropertyChanged("goalrollupquery_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_goalrollupquery
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_goalrollupquery")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_goalrollupquery
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_goalrollupquery", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_goalrollupquery");
                SetRelatedEntities("userentityinstancedata_goalrollupquery", null, value);
                OnPropertyChanged("userentityinstancedata_goalrollupquery");
            }
        }

        /// <summary>
        ///     N:1 business_unit_goalrollupquery
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_goalrollupquery")]
        public BusinessUnit business_unit_goalrollupquery
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_goalrollupquery", null); }
        }

        /// <summary>
        ///     N:1 lk_goalrollupquery_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_goalrollupquery_createdby")]
        public SystemUser lk_goalrollupquery_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_goalrollupquery_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_goalrollupquery_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_goalrollupquery_createdonbehalfby")]
        public SystemUser lk_goalrollupquery_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_goalrollupquery_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_goalrollupquery_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_goalrollupquery_modifiedby")]
        public SystemUser lk_goalrollupquery_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_goalrollupquery_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_goalrollupquery_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_goalrollupquery_modifiedonbehalfby")]
        public SystemUser lk_goalrollupquery_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_goalrollupquery_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 team_goalrollupquery
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_goalrollupquery")]
        public Team team_goalrollupquery
        {
            get { return GetRelatedEntity<Team>("team_goalrollupquery", null); }
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