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
    ///     Target objective for a user or a team for a specified time period.
    /// </summary>
    [DataContract]
    [EntityLogicalName("goal")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Goal : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "goal";

        public const int EntityTypeCode = 9600;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Goal() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Shows the actual value (Decimal type) achieved towards the target as of the last rolled-up date. This field appears
        ///     when the metric type of the goal is Amount and the amount data type is Decimal.
        /// </summary>
        [AttributeLogicalName("actualdecimal")]
        public decimal? ActualDecimal
        {
            get { return GetAttributeValue<decimal?>("actualdecimal"); }
            set
            {
                OnPropertyChanging("ActualDecimal");
                SetAttributeValue("actualdecimal", value);
                OnPropertyChanged("ActualDecimal");
            }
        }

        /// <summary>
        ///     Shows the actual value (integer) achieved towards the target as of the last rolled-up date. This field appears when
        ///     the metric type of the goal is Amount or Count and the amount data type is Integer.
        /// </summary>
        [AttributeLogicalName("actualinteger")]
        public int? ActualInteger
        {
            get { return GetAttributeValue<int?>("actualinteger"); }
            set
            {
                OnPropertyChanging("ActualInteger");
                SetAttributeValue("actualinteger", value);
                OnPropertyChanged("ActualInteger");
            }
        }

        /// <summary>
        ///     Shows the actual value (Money type) achieved towards the target as of the last rolled-up date. This field appears
        ///     when the metric type of the goal is Amount and the amount data type is Money.
        /// </summary>
        [AttributeLogicalName("actualmoney")]
        public Money ActualMoney
        {
            get { return GetAttributeValue<Money>("actualmoney"); }
            set
            {
                OnPropertyChanging("ActualMoney");
                SetAttributeValue("actualmoney", value);
                OnPropertyChanged("ActualMoney");
            }
        }

        /// <summary>
        ///     Shows the actual value (money type) in base currency to track goal results against the target.
        /// </summary>
        [AttributeLogicalName("actualmoney_base")]
        public Money ActualMoney_Base
        {
            get { return GetAttributeValue<Money>("actualmoney_base"); }
        }

        /// <summary>
        ///     Actual Value of the goal.
        /// </summary>
        [AttributeLogicalName("actualstring")]
        public string ActualString
        {
            get { return GetAttributeValue<string>("actualstring"); }
        }

        /// <summary>
        ///     Data type of the amount.
        /// </summary>
        [AttributeLogicalName("amountdatatype")]
        public OptionSetValue AmountDataType
        {
            get { return GetAttributeValue<OptionSetValue>("amountdatatype"); }
            set
            {
                OnPropertyChanging("AmountDataType");
                SetAttributeValue("amountdatatype", value);
                OnPropertyChanged("AmountDataType");
            }
        }

        /// <summary>
        ///     Shows the expected amount for actual value (decimal type) against the target goal.
        /// </summary>
        [AttributeLogicalName("computedtargetasoftodaydecimal")]
        public decimal? ComputedTargetAsOfTodayDecimal
        {
            get { return GetAttributeValue<decimal?>("computedtargetasoftodaydecimal"); }
        }

        /// <summary>
        ///     Shows the expected amount for actual value (integer type) against the target goal as of the current date.
        /// </summary>
        [AttributeLogicalName("computedtargetasoftodayinteger")]
        public int? ComputedTargetAsOfTodayInteger
        {
            get { return GetAttributeValue<int?>("computedtargetasoftodayinteger"); }
        }

        /// <summary>
        ///     Shows the expected amount for actual value (money type) against the target goal as of the current date.
        /// </summary>
        [AttributeLogicalName("computedtargetasoftodaymoney")]
        public Money ComputedTargetAsOfTodayMoney
        {
            get { return GetAttributeValue<Money>("computedtargetasoftodaymoney"); }
        }

        /// <summary>
        ///     Shows the expected amount in base currency for actual value (money type) against the target goal as of the current
        ///     date.
        /// </summary>
        [AttributeLogicalName("computedtargetasoftodaymoney_base")]
        public Money ComputedTargetAsOfTodayMoney_Base
        {
            get { return GetAttributeValue<Money>("computedtargetasoftodaymoney_base"); }
        }

        /// <summary>
        ///     Shows the expected value for percentage achieved against the target goal as of the current date.
        /// </summary>
        [AttributeLogicalName("computedtargetasoftodaypercentageachieved")]
        public decimal? ComputedTargetAsOfTodayPercentageAchieved
        {
            get { return GetAttributeValue<decimal?>("computedtargetasoftodaypercentageachieved"); }
        }

        /// <summary>
        ///     Select whether only the goal owner's records, or all records, should be rolled up for goal results.
        /// </summary>
        [AttributeLogicalName("consideronlygoalownersrecords")]
        public bool? ConsiderOnlyGoalOwnersRecords
        {
            get { return GetAttributeValue<bool?>("consideronlygoalownersrecords"); }
            set
            {
                OnPropertyChanging("ConsiderOnlyGoalOwnersRecords");
                SetAttributeValue("consideronlygoalownersrecords", value);
                OnPropertyChanged("ConsiderOnlyGoalOwnersRecords");
            }
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
        ///     Indicates a placeholder rollup field for a decimal value to track a third category of results other than actuals
        ///     and in-progress results.
        /// </summary>
        [AttributeLogicalName("customrollupfielddecimal")]
        public decimal? CustomRollupFieldDecimal
        {
            get { return GetAttributeValue<decimal?>("customrollupfielddecimal"); }
            set
            {
                OnPropertyChanging("CustomRollupFieldDecimal");
                SetAttributeValue("customrollupfielddecimal", value);
                OnPropertyChanged("CustomRollupFieldDecimal");
            }
        }

        /// <summary>
        ///     Indicates a placeholder rollup field for an integer value to track a third category of results other than actuals
        ///     and in-progress results.
        /// </summary>
        [AttributeLogicalName("customrollupfieldinteger")]
        public int? CustomRollupFieldInteger
        {
            get { return GetAttributeValue<int?>("customrollupfieldinteger"); }
            set
            {
                OnPropertyChanging("CustomRollupFieldInteger");
                SetAttributeValue("customrollupfieldinteger", value);
                OnPropertyChanged("CustomRollupFieldInteger");
            }
        }

        /// <summary>
        ///     Indicates a placeholder rollup field for a money value to track a third category of results other than actuals and
        ///     in-progress results.
        /// </summary>
        [AttributeLogicalName("customrollupfieldmoney")]
        public Money CustomRollupFieldMoney
        {
            get { return GetAttributeValue<Money>("customrollupfieldmoney"); }
            set
            {
                OnPropertyChanging("CustomRollupFieldMoney");
                SetAttributeValue("customrollupfieldmoney", value);
                OnPropertyChanged("CustomRollupFieldMoney");
            }
        }

        /// <summary>
        ///     Indicates a placeholder rollup field for a money value in base currency to track a third category of results other
        ///     than actuals and in-progress results.
        /// </summary>
        [AttributeLogicalName("customrollupfieldmoney_base")]
        public Money CustomRollupFieldMoney_Base
        {
            get { return GetAttributeValue<Money>("customrollupfieldmoney_base"); }
        }

        /// <summary>
        ///     Placeholder rollup field for the goal.
        /// </summary>
        [AttributeLogicalName("customrollupfieldstring")]
        public string CustomRollupFieldString
        {
            get { return GetAttributeValue<string>("customrollupfieldstring"); }
        }

        /// <summary>
        ///     Depth of the goal in the tree.
        /// </summary>
        [AttributeLogicalName("depth")]
        public int? Depth
        {
            get { return GetAttributeValue<int?>("depth"); }
        }

        /// <summary>
        ///     The default image for the entity.
        /// </summary>
        [AttributeLogicalName("entityimage")]
        public byte[] EntityImage
        {
            get { return GetAttributeValue<byte[]>("entityimage"); }
            set
            {
                OnPropertyChanging("EntityImage");
                SetAttributeValue("entityimage", value);
                OnPropertyChanged("EntityImage");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("entityimage_timestamp")]
        public long? EntityImage_Timestamp
        {
            get { return GetAttributeValue<long?>("entityimage_timestamp"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("entityimage_url")]
        public string EntityImage_URL
        {
            get { return GetAttributeValue<string>("entityimage_url"); }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("entityimageid")]
        public Guid? EntityImageId
        {
            get { return GetAttributeValue<Guid?>("entityimageid"); }
        }

        /// <summary>
        ///     Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the
        ///     record from the local currency to the system's default currency.
        /// </summary>
        [AttributeLogicalName("exchangerate")]
        public decimal? ExchangeRate
        {
            get { return GetAttributeValue<decimal?>("exchangerate"); }
        }

        /// <summary>
        ///     Select the fiscal period for the goal.
        /// </summary>
        [AttributeLogicalName("fiscalperiod")]
        public OptionSetValue FiscalPeriod
        {
            get { return GetAttributeValue<OptionSetValue>("fiscalperiod"); }
            set
            {
                OnPropertyChanging("FiscalPeriod");
                SetAttributeValue("fiscalperiod", value);
                OnPropertyChanged("FiscalPeriod");
            }
        }

        /// <summary>
        ///     Select the fiscal year for the goal that's being tracked.
        /// </summary>
        [AttributeLogicalName("fiscalyear")]
        public OptionSetValue FiscalYear
        {
            get { return GetAttributeValue<OptionSetValue>("fiscalyear"); }
            set
            {
                OnPropertyChanging("FiscalYear");
                SetAttributeValue("fiscalyear", value);
                OnPropertyChanged("FiscalYear");
            }
        }

        /// <summary>
        ///     Enter the date when the goal ends.
        /// </summary>
        [AttributeLogicalName("goalenddate")]
        public DateTime? GoalEndDate
        {
            get { return GetAttributeValue<DateTime?>("goalenddate"); }
            set
            {
                OnPropertyChanging("GoalEndDate");
                SetAttributeValue("goalenddate", value);
                OnPropertyChanged("GoalEndDate");
            }
        }

        /// <summary>
        ///     Unique identifier of the goal.
        /// </summary>
        [AttributeLogicalName("goalid")]
        public Guid? GoalId
        {
            get { return GetAttributeValue<Guid?>("goalid"); }
            set
            {
                OnPropertyChanging("GoalId");
                SetAttributeValue("goalid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("GoalId");
            }
        }

        [AttributeLogicalName("goalid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { GoalId = value; }
        }

        /// <summary>
        ///     Choose the user or team responsible for meeting the goal.
        /// </summary>
        [AttributeLogicalName("goalownerid")]
        public EntityReference GoalOwnerId
        {
            get { return GetAttributeValue<EntityReference>("goalownerid"); }
            set
            {
                OnPropertyChanging("GoalOwnerId");
                SetAttributeValue("goalownerid", value);
                OnPropertyChanged("GoalOwnerId");
            }
        }

        /// <summary>
        ///     Enter the date and time when the period for tracking the goal begins.
        /// </summary>
        [AttributeLogicalName("goalstartdate")]
        public DateTime? GoalStartDate
        {
            get { return GetAttributeValue<DateTime?>("goalstartdate"); }
            set
            {
                OnPropertyChanging("GoalStartDate");
                SetAttributeValue("goalstartdate", value);
                OnPropertyChanged("GoalStartDate");
            }
        }

        /// <summary>
        ///     Unique identifier of the goal that caused an error in the rollup of the goal hierarchy.
        /// </summary>
        [AttributeLogicalName("goalwitherrorid")]
        public EntityReference GoalWithErrorId
        {
            get { return GetAttributeValue<EntityReference>("goalwitherrorid"); }
            set
            {
                OnPropertyChanging("GoalWithErrorId");
                SetAttributeValue("goalwitherrorid", value);
                OnPropertyChanged("GoalWithErrorId");
            }
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
        ///     Shows the in-progress value (decimal) against the target. This value could contribute to a goal, but is not counted
        ///     yet as actual.
        /// </summary>
        [AttributeLogicalName("inprogressdecimal")]
        public decimal? InProgressDecimal
        {
            get { return GetAttributeValue<decimal?>("inprogressdecimal"); }
            set
            {
                OnPropertyChanging("InProgressDecimal");
                SetAttributeValue("inprogressdecimal", value);
                OnPropertyChanged("InProgressDecimal");
            }
        }

        /// <summary>
        ///     Shows the in-progress value (integer) against the target. This value could contribute to a goal, but is not counted
        ///     yet as actual.
        /// </summary>
        [AttributeLogicalName("inprogressinteger")]
        public int? InProgressInteger
        {
            get { return GetAttributeValue<int?>("inprogressinteger"); }
            set
            {
                OnPropertyChanging("InProgressInteger");
                SetAttributeValue("inprogressinteger", value);
                OnPropertyChanged("InProgressInteger");
            }
        }

        /// <summary>
        ///     Shows the in-progress value (money) against the target. This value could contribute to a goal, but is not counted
        ///     yet as actual.
        /// </summary>
        [AttributeLogicalName("inprogressmoney")]
        public Money InProgressMoney
        {
            get { return GetAttributeValue<Money>("inprogressmoney"); }
            set
            {
                OnPropertyChanging("InProgressMoney");
                SetAttributeValue("inprogressmoney", value);
                OnPropertyChanged("InProgressMoney");
            }
        }

        /// <summary>
        ///     Shows the in-progress value (money) in base currency to track goal results against the target.
        /// </summary>
        [AttributeLogicalName("inprogressmoney_base")]
        public Money InProgressMoney_Base
        {
            get { return GetAttributeValue<Money>("inprogressmoney_base"); }
        }

        /// <summary>
        ///     In-progress value of the goal.
        /// </summary>
        [AttributeLogicalName("inprogressstring")]
        public string InProgressString
        {
            get { return GetAttributeValue<string>("inprogressstring"); }
        }

        /// <summary>
        ///     Indicates whether the metric type is Count or Amount.
        /// </summary>
        [AttributeLogicalName("isamount")]
        public bool? IsAmount
        {
            get { return GetAttributeValue<bool?>("isamount"); }
            set
            {
                OnPropertyChanging("IsAmount");
                SetAttributeValue("isamount", value);
                OnPropertyChanged("IsAmount");
            }
        }

        /// <summary>
        ///     Select whether the goal period is a fiscal period or custom period.
        /// </summary>
        [AttributeLogicalName("isfiscalperiodgoal")]
        public bool? IsFiscalPeriodGoal
        {
            get { return GetAttributeValue<bool?>("isfiscalperiodgoal"); }
            set
            {
                OnPropertyChanging("IsFiscalPeriodGoal");
                SetAttributeValue("isfiscalperiodgoal", value);
                OnPropertyChanged("IsFiscalPeriodGoal");
            }
        }

        /// <summary>
        ///     Select whether the system rollup fields are updated. If set to Yes, the next system rollup will not update the
        ///     values of the rollup fields with the system calculated values.
        /// </summary>
        [AttributeLogicalName("isoverridden")]
        public bool? IsOverridden
        {
            get { return GetAttributeValue<bool?>("isoverridden"); }
            set
            {
                OnPropertyChanging("IsOverridden");
                SetAttributeValue("isoverridden", value);
                OnPropertyChanged("IsOverridden");
            }
        }

        /// <summary>
        ///     Indicates whether the values of system rollup fields can be updated.
        /// </summary>
        [AttributeLogicalName("isoverride")]
        public bool? IsOverride
        {
            get { return GetAttributeValue<bool?>("isoverride"); }
            set
            {
                OnPropertyChanging("IsOverride");
                SetAttributeValue("isoverride", value);
                OnPropertyChanged("IsOverride");
            }
        }

        /// <summary>
        ///     Shows the date and time when the goal was last rolled up. The date and time are displayed in the time zone selected
        ///     in Microsoft Dynamics CRM options.
        /// </summary>
        [AttributeLogicalName("lastrolledupdate")]
        public DateTime? LastRolledupDate
        {
            get { return GetAttributeValue<DateTime?>("lastrolledupdate"); }
            set
            {
                OnPropertyChanging("LastRolledupDate");
                SetAttributeValue("lastrolledupdate", value);
                OnPropertyChanged("LastRolledupDate");
            }
        }

        /// <summary>
        ///     Choose the metric for the goal. This metric determines how the goal is tracked.
        /// </summary>
        [AttributeLogicalName("metricid")]
        public EntityReference MetricId
        {
            get { return GetAttributeValue<EntityReference>("metricid"); }
            set
            {
                OnPropertyChanging("MetricId");
                SetAttributeValue("metricid", value);
                OnPropertyChanged("MetricId");
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
        ///     Unique identifier for the business unit that owns the record.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the goal.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier for the user who owns the record.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Choose a parent goal if the current goal is a child goal. This sets up a parent-child relationship for reporting
        ///     and analytics.
        /// </summary>
        [AttributeLogicalName("parentgoalid")]
        public EntityReference ParentGoalId
        {
            get { return GetAttributeValue<EntityReference>("parentgoalid"); }
            set
            {
                OnPropertyChanging("ParentGoalId");
                SetAttributeValue("parentgoalid", value);
                OnPropertyChanged("ParentGoalId");
            }
        }

        /// <summary>
        ///     Shows the percentage achieved against the target goal.
        /// </summary>
        [AttributeLogicalName("percentage")]
        public decimal? Percentage
        {
            get { return GetAttributeValue<decimal?>("percentage"); }
            set
            {
                OnPropertyChanging("Percentage");
                SetAttributeValue("percentage", value);
                OnPropertyChanged("Percentage");
            }
        }

        /// <summary>
        ///     Error code associated with rollup.
        /// </summary>
        [AttributeLogicalName("rolluperrorcode")]
        public int? RollupErrorCode
        {
            get { return GetAttributeValue<int?>("rolluperrorcode"); }
            set
            {
                OnPropertyChanging("RollupErrorCode");
                SetAttributeValue("rolluperrorcode", value);
                OnPropertyChanged("RollupErrorCode");
            }
        }

        /// <summary>
        ///     Select whether the data should be rolled up only from the child goals.
        /// </summary>
        [AttributeLogicalName("rolluponlyfromchildgoals")]
        public bool? RollupOnlyFromChildGoals
        {
            get { return GetAttributeValue<bool?>("rolluponlyfromchildgoals"); }
            set
            {
                OnPropertyChanging("RollupOnlyFromChildGoals");
                SetAttributeValue("rolluponlyfromchildgoals", value);
                OnPropertyChanged("RollupOnlyFromChildGoals");
            }
        }

        /// <summary>
        ///     Choose the query that will be used to calculate the actual data for the goal (decimal).
        /// </summary>
        [AttributeLogicalName("rollupqueryactualdecimalid")]
        public EntityReference RollUpQueryActualDecimalId
        {
            get { return GetAttributeValue<EntityReference>("rollupqueryactualdecimalid"); }
            set
            {
                OnPropertyChanging("RollUpQueryActualDecimalId");
                SetAttributeValue("rollupqueryactualdecimalid", value);
                OnPropertyChanged("RollUpQueryActualDecimalId");
            }
        }

        /// <summary>
        ///     Choose the query that will be used to calculate the actual data for the goal (integer).
        /// </summary>
        [AttributeLogicalName("rollupqueryactualintegerid")]
        public EntityReference RollupQueryActualIntegerId
        {
            get { return GetAttributeValue<EntityReference>("rollupqueryactualintegerid"); }
            set
            {
                OnPropertyChanging("RollupQueryActualIntegerId");
                SetAttributeValue("rollupqueryactualintegerid", value);
                OnPropertyChanged("RollupQueryActualIntegerId");
            }
        }

        /// <summary>
        ///     Choose the query that will be used to calculate the actual data for the goal (money).
        /// </summary>
        [AttributeLogicalName("rollupqueryactualmoneyid")]
        public EntityReference RollUpQueryActualMoneyId
        {
            get { return GetAttributeValue<EntityReference>("rollupqueryactualmoneyid"); }
            set
            {
                OnPropertyChanging("RollUpQueryActualMoneyId");
                SetAttributeValue("rollupqueryactualmoneyid", value);
                OnPropertyChanged("RollUpQueryActualMoneyId");
            }
        }

        /// <summary>
        ///     Choose the query that will be used to calculate data for the custom rollup field (decimal).
        /// </summary>
        [AttributeLogicalName("rollupquerycustomdecimalid")]
        public EntityReference RollUpQueryCustomDecimalId
        {
            get { return GetAttributeValue<EntityReference>("rollupquerycustomdecimalid"); }
            set
            {
                OnPropertyChanging("RollUpQueryCustomDecimalId");
                SetAttributeValue("rollupquerycustomdecimalid", value);
                OnPropertyChanged("RollUpQueryCustomDecimalId");
            }
        }

        /// <summary>
        ///     Choose the query that will be used to calculate data for the custom rollup field (integer).
        /// </summary>
        [AttributeLogicalName("rollupquerycustomintegerid")]
        public EntityReference RollUpQueryCustomIntegerId
        {
            get { return GetAttributeValue<EntityReference>("rollupquerycustomintegerid"); }
            set
            {
                OnPropertyChanging("RollUpQueryCustomIntegerId");
                SetAttributeValue("rollupquerycustomintegerid", value);
                OnPropertyChanged("RollUpQueryCustomIntegerId");
            }
        }

        /// <summary>
        ///     Choose the query that will be used to calculate data for the custom rollup field (money).
        /// </summary>
        [AttributeLogicalName("rollupquerycustommoneyid")]
        public EntityReference RollUpQueryCustomMoneyId
        {
            get { return GetAttributeValue<EntityReference>("rollupquerycustommoneyid"); }
            set
            {
                OnPropertyChanging("RollUpQueryCustomMoneyId");
                SetAttributeValue("rollupquerycustommoneyid", value);
                OnPropertyChanged("RollUpQueryCustomMoneyId");
            }
        }

        /// <summary>
        ///     Choose the query that will be used to calculate data for the in-progress rollup field (decimal).
        /// </summary>
        [AttributeLogicalName("rollupqueryinprogressdecimalid")]
        public EntityReference RollUpQueryInprogressDecimalId
        {
            get { return GetAttributeValue<EntityReference>("rollupqueryinprogressdecimalid"); }
            set
            {
                OnPropertyChanging("RollUpQueryInprogressDecimalId");
                SetAttributeValue("rollupqueryinprogressdecimalid", value);
                OnPropertyChanged("RollUpQueryInprogressDecimalId");
            }
        }

        /// <summary>
        ///     Choose the query that will be used to calculate data for the in-progress rollup field (integer).
        /// </summary>
        [AttributeLogicalName("rollupqueryinprogressintegerid")]
        public EntityReference RollUpQueryInprogressIntegerId
        {
            get { return GetAttributeValue<EntityReference>("rollupqueryinprogressintegerid"); }
            set
            {
                OnPropertyChanging("RollUpQueryInprogressIntegerId");
                SetAttributeValue("rollupqueryinprogressintegerid", value);
                OnPropertyChanged("RollUpQueryInprogressIntegerId");
            }
        }

        /// <summary>
        ///     Choose the query that will be used to calculate data for the in-progress rollup field (money).
        /// </summary>
        [AttributeLogicalName("rollupqueryinprogressmoneyid")]
        public EntityReference RollUpQueryInprogressMoneyId
        {
            get { return GetAttributeValue<EntityReference>("rollupqueryinprogressmoneyid"); }
            set
            {
                OnPropertyChanging("RollUpQueryInprogressMoneyId");
                SetAttributeValue("rollupqueryinprogressmoneyid", value);
                OnPropertyChanged("RollUpQueryInprogressMoneyId");
            }
        }

        /// <summary>
        ///     Shows whether the goal is open, completed, or canceled. Completed and canceled goals are read-only and can't be
        ///     edited.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public GoalState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((GoalState) (Enum.ToObject(typeof (GoalState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Select the goal's status.
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
        ///     Select a stretch target (decimal) of the goal to define a higher or difficult level of goal than the usual ones.
        /// </summary>
        [AttributeLogicalName("stretchtargetdecimal")]
        public decimal? StretchTargetDecimal
        {
            get { return GetAttributeValue<decimal?>("stretchtargetdecimal"); }
            set
            {
                OnPropertyChanging("StretchTargetDecimal");
                SetAttributeValue("stretchtargetdecimal", value);
                OnPropertyChanged("StretchTargetDecimal");
            }
        }

        /// <summary>
        ///     Select the stretch target (integer) of the goal to define a higher or difficult level of goal than the usual ones.
        /// </summary>
        [AttributeLogicalName("stretchtargetinteger")]
        public int? StretchTargetInteger
        {
            get { return GetAttributeValue<int?>("stretchtargetinteger"); }
            set
            {
                OnPropertyChanging("StretchTargetInteger");
                SetAttributeValue("stretchtargetinteger", value);
                OnPropertyChanged("StretchTargetInteger");
            }
        }

        /// <summary>
        ///     Select stretch target (money) of the goal to define a higher or difficult level of goal than the usual ones.
        /// </summary>
        [AttributeLogicalName("stretchtargetmoney")]
        public Money StretchTargetMoney
        {
            get { return GetAttributeValue<Money>("stretchtargetmoney"); }
            set
            {
                OnPropertyChanging("StretchTargetMoney");
                SetAttributeValue("stretchtargetmoney", value);
                OnPropertyChanged("StretchTargetMoney");
            }
        }

        /// <summary>
        ///     Shows the stretch target (money) in base currency to indicate a higher or difficult level of goal than the usual
        ///     ones.
        /// </summary>
        [AttributeLogicalName("stretchtargetmoney_base")]
        public Money StretchTargetMoney_Base
        {
            get { return GetAttributeValue<Money>("stretchtargetmoney_base"); }
        }

        /// <summary>
        ///     Stretch target value for all data types.
        /// </summary>
        [AttributeLogicalName("stretchtargetstring")]
        public string StretchTargetString
        {
            get { return GetAttributeValue<string>("stretchtargetstring"); }
        }

        /// <summary>
        ///     Select a goal target of the decimal type to use for tracking data that include partial numbers, such as pounds sold
        ///     of a product sold by weight.
        /// </summary>
        [AttributeLogicalName("targetdecimal")]
        public decimal? TargetDecimal
        {
            get { return GetAttributeValue<decimal?>("targetdecimal"); }
            set
            {
                OnPropertyChanging("TargetDecimal");
                SetAttributeValue("targetdecimal", value);
                OnPropertyChanged("TargetDecimal");
            }
        }

        /// <summary>
        ///     Select a goal target of the integer type to use for tracking anything countable in whole numbers, such as units
        ///     sold.
        /// </summary>
        [AttributeLogicalName("targetinteger")]
        public int? TargetInteger
        {
            get { return GetAttributeValue<int?>("targetinteger"); }
            set
            {
                OnPropertyChanging("TargetInteger");
                SetAttributeValue("targetinteger", value);
                OnPropertyChanged("TargetInteger");
            }
        }

        /// <summary>
        ///     Select a goal target (money) to track a monetary amount such as revenue from a product.
        /// </summary>
        [AttributeLogicalName("targetmoney")]
        public Money TargetMoney
        {
            get { return GetAttributeValue<Money>("targetmoney"); }
            set
            {
                OnPropertyChanging("TargetMoney");
                SetAttributeValue("targetmoney", value);
                OnPropertyChanged("TargetMoney");
            }
        }

        /// <summary>
        ///     Shows the goal target of the money type in base currency.
        /// </summary>
        [AttributeLogicalName("targetmoney_base")]
        public Money TargetMoney_Base
        {
            get { return GetAttributeValue<Money>("targetmoney_base"); }
        }

        /// <summary>
        ///     Target value of the goal.
        /// </summary>
        [AttributeLogicalName("targetstring")]
        public string TargetString
        {
            get { return GetAttributeValue<string>("targetstring"); }
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
        ///     Type a title or name that describes the goal.
        /// </summary>
        [AttributeLogicalName("title")]
        public string Title
        {
            get { return GetAttributeValue<string>("title"); }
            set
            {
                OnPropertyChanging("Title");
                SetAttributeValue("title", value);
                OnPropertyChanged("Title");
            }
        }

        /// <summary>
        ///     Choose the local currency for the record to make sure budgets are reported in the correct currency.
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        public EntityReference TransactionCurrencyId
        {
            get { return GetAttributeValue<EntityReference>("transactioncurrencyid"); }
        }

        /// <summary>
        ///     Unique identifier of the goal tree.
        /// </summary>
        [AttributeLogicalName("treeid")]
        public Guid? TreeId
        {
            get { return GetAttributeValue<Guid?>("treeid"); }
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
        ///     Version number of the goal.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N Goal_Annotation
        /// </summary>
        [RelationshipSchemaName("Goal_Annotation")]
        public IEnumerable<Annotation> Goal_Annotation
        {
            get { return GetRelatedEntities<Annotation>("Goal_Annotation", null); }
            set
            {
                OnPropertyChanging("Goal_Annotation");
                SetRelatedEntities("Goal_Annotation", null, value);
                OnPropertyChanged("Goal_Annotation");
            }
        }

        /// <summary>
        ///     1:N Goal_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Goal_AsyncOperations")]
        public IEnumerable<AsyncOperation> Goal_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Goal_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Goal_AsyncOperations");
                SetRelatedEntities("Goal_AsyncOperations", null, value);
                OnPropertyChanged("Goal_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N goal_connections1
        /// </summary>
        [RelationshipSchemaName("goal_connections1")]
        public IEnumerable<Connection> goal_connections1
        {
            get { return GetRelatedEntities<Connection>("goal_connections1", null); }
            set
            {
                OnPropertyChanging("goal_connections1");
                SetRelatedEntities("goal_connections1", null, value);
                OnPropertyChanged("goal_connections1");
            }
        }

        /// <summary>
        ///     1:N goal_connections2
        /// </summary>
        [RelationshipSchemaName("goal_connections2")]
        public IEnumerable<Connection> goal_connections2
        {
            get { return GetRelatedEntities<Connection>("goal_connections2", null); }
            set
            {
                OnPropertyChanging("goal_connections2");
                SetRelatedEntities("goal_connections2", null, value);
                OnPropertyChanged("goal_connections2");
            }
        }

        /// <summary>
        ///     1:N goal_parent_goal
        /// </summary>
        [RelationshipSchemaName("goal_parent_goal", EntityRole.Referenced)]
        public IEnumerable<Goal> Referencedgoal_parent_goal
        {
            get { return GetRelatedEntities<Goal>("goal_parent_goal", EntityRole.Referenced); }
            set
            {
                OnPropertyChanging("Referencedgoal_parent_goal");
                SetRelatedEntities("goal_parent_goal", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedgoal_parent_goal");
            }
        }

        /// <summary>
        ///     1:N goal_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("goal_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> goal_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntities<PrincipalObjectAttributeAccess>("goal_principalobjectattributeaccess", null);
            }
            set
            {
                OnPropertyChanging("goal_principalobjectattributeaccess");
                SetRelatedEntities("goal_principalobjectattributeaccess", null, value);
                OnPropertyChanged("goal_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N Goal_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("Goal_ProcessSessions")]
        public IEnumerable<ProcessSession> Goal_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("Goal_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Goal_ProcessSessions");
                SetRelatedEntities("Goal_ProcessSessions", null, value);
                OnPropertyChanged("Goal_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N Goal_RollupError_Goal
        /// </summary>
        [RelationshipSchemaName("Goal_RollupError_Goal", EntityRole.Referenced)]
        public IEnumerable<Goal> ReferencedGoal_RollupError_Goal
        {
            get { return GetRelatedEntities<Goal>("Goal_RollupError_Goal", EntityRole.Referenced); }
            set
            {
                OnPropertyChanging("ReferencedGoal_RollupError_Goal");
                SetRelatedEntities("Goal_RollupError_Goal", EntityRole.Referenced, value);
                OnPropertyChanged("ReferencedGoal_RollupError_Goal");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_goal
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_goal")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_goal
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_goal", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_goal");
                SetRelatedEntities("userentityinstancedata_goal", null, value);
                OnPropertyChanged("userentityinstancedata_goal");
            }
        }

        /// <summary>
        ///     N:1 business_unit_goal
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_goal")]
        public BusinessUnit business_unit_goal
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_goal", null); }
        }

        /// <summary>
        ///     N:1 goal_parent_goal
        /// </summary>
        [AttributeLogicalName("parentgoalid")]
        [RelationshipSchemaName("goal_parent_goal", EntityRole.Referencing)]
        public Goal Referencinggoal_parent_goal
        {
            get { return GetRelatedEntity<Goal>("goal_parent_goal", EntityRole.Referencing); }
            set
            {
                OnPropertyChanging("Referencinggoal_parent_goal");
                SetRelatedEntity("goal_parent_goal", EntityRole.Referencing, value);
                OnPropertyChanged("Referencinggoal_parent_goal");
            }
        }

        /// <summary>
        ///     N:1 Goal_RollupError_Goal
        /// </summary>
        [AttributeLogicalName("goalwitherrorid")]
        [RelationshipSchemaName("Goal_RollupError_Goal", EntityRole.Referencing)]
        public Goal ReferencingGoal_RollupError_Goal
        {
            get { return GetRelatedEntity<Goal>("Goal_RollupError_Goal", EntityRole.Referencing); }
            set
            {
                OnPropertyChanging("ReferencingGoal_RollupError_Goal");
                SetRelatedEntity("Goal_RollupError_Goal", EntityRole.Referencing, value);
                OnPropertyChanged("ReferencingGoal_RollupError_Goal");
            }
        }

        /// <summary>
        ///     N:1 goal_rollupquery_actualdecimal
        /// </summary>
        [AttributeLogicalName("rollupqueryactualdecimalid")]
        [RelationshipSchemaName("goal_rollupquery_actualdecimal")]
        public GoalRollupQuery goal_rollupquery_actualdecimal
        {
            get { return GetRelatedEntity<GoalRollupQuery>("goal_rollupquery_actualdecimal", null); }
            set
            {
                OnPropertyChanging("goal_rollupquery_actualdecimal");
                SetRelatedEntity("goal_rollupquery_actualdecimal", null, value);
                OnPropertyChanged("goal_rollupquery_actualdecimal");
            }
        }

        /// <summary>
        ///     N:1 goal_rollupquery_actualmoney
        /// </summary>
        [AttributeLogicalName("rollupqueryactualmoneyid")]
        [RelationshipSchemaName("goal_rollupquery_actualmoney")]
        public GoalRollupQuery goal_rollupquery_actualmoney
        {
            get { return GetRelatedEntity<GoalRollupQuery>("goal_rollupquery_actualmoney", null); }
            set
            {
                OnPropertyChanging("goal_rollupquery_actualmoney");
                SetRelatedEntity("goal_rollupquery_actualmoney", null, value);
                OnPropertyChanged("goal_rollupquery_actualmoney");
            }
        }

        /// <summary>
        ///     N:1 goal_rollupquery_customdecimal
        /// </summary>
        [AttributeLogicalName("rollupquerycustomdecimalid")]
        [RelationshipSchemaName("goal_rollupquery_customdecimal")]
        public GoalRollupQuery goal_rollupquery_customdecimal
        {
            get { return GetRelatedEntity<GoalRollupQuery>("goal_rollupquery_customdecimal", null); }
            set
            {
                OnPropertyChanging("goal_rollupquery_customdecimal");
                SetRelatedEntity("goal_rollupquery_customdecimal", null, value);
                OnPropertyChanged("goal_rollupquery_customdecimal");
            }
        }

        /// <summary>
        ///     N:1 goal_rollupquery_customint
        /// </summary>
        [AttributeLogicalName("rollupquerycustomintegerid")]
        [RelationshipSchemaName("goal_rollupquery_customint")]
        public GoalRollupQuery goal_rollupquery_customint
        {
            get { return GetRelatedEntity<GoalRollupQuery>("goal_rollupquery_customint", null); }
            set
            {
                OnPropertyChanging("goal_rollupquery_customint");
                SetRelatedEntity("goal_rollupquery_customint", null, value);
                OnPropertyChanged("goal_rollupquery_customint");
            }
        }

        /// <summary>
        ///     N:1 goal_rollupquery_custommoney
        /// </summary>
        [AttributeLogicalName("rollupquerycustommoneyid")]
        [RelationshipSchemaName("goal_rollupquery_custommoney")]
        public GoalRollupQuery goal_rollupquery_custommoney
        {
            get { return GetRelatedEntity<GoalRollupQuery>("goal_rollupquery_custommoney", null); }
            set
            {
                OnPropertyChanging("goal_rollupquery_custommoney");
                SetRelatedEntity("goal_rollupquery_custommoney", null, value);
                OnPropertyChanged("goal_rollupquery_custommoney");
            }
        }

        /// <summary>
        ///     N:1 goal_rollupquery_inprogressdecimal
        /// </summary>
        [AttributeLogicalName("rollupqueryinprogressdecimalid")]
        [RelationshipSchemaName("goal_rollupquery_inprogressdecimal")]
        public GoalRollupQuery goal_rollupquery_inprogressdecimal
        {
            get { return GetRelatedEntity<GoalRollupQuery>("goal_rollupquery_inprogressdecimal", null); }
            set
            {
                OnPropertyChanging("goal_rollupquery_inprogressdecimal");
                SetRelatedEntity("goal_rollupquery_inprogressdecimal", null, value);
                OnPropertyChanged("goal_rollupquery_inprogressdecimal");
            }
        }

        /// <summary>
        ///     N:1 goal_rollupquery_inprogressint
        /// </summary>
        [AttributeLogicalName("rollupqueryinprogressintegerid")]
        [RelationshipSchemaName("goal_rollupquery_inprogressint")]
        public GoalRollupQuery goal_rollupquery_inprogressint
        {
            get { return GetRelatedEntity<GoalRollupQuery>("goal_rollupquery_inprogressint", null); }
            set
            {
                OnPropertyChanging("goal_rollupquery_inprogressint");
                SetRelatedEntity("goal_rollupquery_inprogressint", null, value);
                OnPropertyChanged("goal_rollupquery_inprogressint");
            }
        }

        /// <summary>
        ///     N:1 goal_rollupquery_inprogressmoney
        /// </summary>
        [AttributeLogicalName("rollupqueryinprogressmoneyid")]
        [RelationshipSchemaName("goal_rollupquery_inprogressmoney")]
        public GoalRollupQuery goal_rollupquery_inprogressmoney
        {
            get { return GetRelatedEntity<GoalRollupQuery>("goal_rollupquery_inprogressmoney", null); }
            set
            {
                OnPropertyChanging("goal_rollupquery_inprogressmoney");
                SetRelatedEntity("goal_rollupquery_inprogressmoney", null, value);
                OnPropertyChanged("goal_rollupquery_inprogressmoney");
            }
        }

        /// <summary>
        ///     N:1 goalrollupquery_actualint
        /// </summary>
        [AttributeLogicalName("rollupqueryactualintegerid")]
        [RelationshipSchemaName("goalrollupquery_actualint")]
        public GoalRollupQuery goalrollupquery_actualint
        {
            get { return GetRelatedEntity<GoalRollupQuery>("goalrollupquery_actualint", null); }
            set
            {
                OnPropertyChanging("goalrollupquery_actualint");
                SetRelatedEntity("goalrollupquery_actualint", null, value);
                OnPropertyChanged("goalrollupquery_actualint");
            }
        }

        /// <summary>
        ///     N:1 lk_goal_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_goal_createdby")]
        public SystemUser lk_goal_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_goal_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_goal_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_goal_createdonbehalfby")]
        public SystemUser lk_goal_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_goal_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_goal_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_goal_modifiedby")]
        public SystemUser lk_goal_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_goal_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_goal_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_goal_modifiedonbehalfby")]
        public SystemUser lk_goal_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_goal_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 metric_goal
        /// </summary>
        [AttributeLogicalName("metricid")]
        [RelationshipSchemaName("metric_goal")]
        public Metric metric_goal
        {
            get { return GetRelatedEntity<Metric>("metric_goal", null); }
            set
            {
                OnPropertyChanging("metric_goal");
                SetRelatedEntity("metric_goal", null, value);
                OnPropertyChanged("metric_goal");
            }
        }

        /// <summary>
        ///     N:1 team_goal
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_goal")]
        public Team team_goal
        {
            get { return GetRelatedEntity<Team>("team_goal", null); }
        }

        /// <summary>
        ///     N:1 team_goal_goalowner
        /// </summary>
        [AttributeLogicalName("goalownerid")]
        [RelationshipSchemaName("team_goal_goalowner")]
        public Team team_goal_goalowner
        {
            get { return GetRelatedEntity<Team>("team_goal_goalowner", null); }
            set
            {
                OnPropertyChanging("team_goal_goalowner");
                SetRelatedEntity("team_goal_goalowner", null, value);
                OnPropertyChanged("team_goal_goalowner");
            }
        }

        /// <summary>
        ///     N:1 TransactionCurrency_Goal
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("TransactionCurrency_Goal")]
        public TransactionCurrency TransactionCurrency_Goal
        {
            get { return GetRelatedEntity<TransactionCurrency>("TransactionCurrency_Goal", null); }
        }

        /// <summary>
        ///     N:1 user_goal
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_goal")]
        public SystemUser user_goal
        {
            get { return GetRelatedEntity<SystemUser>("user_goal", null); }
        }

        /// <summary>
        ///     N:1 user_goal_goalowner
        /// </summary>
        [AttributeLogicalName("goalownerid")]
        [RelationshipSchemaName("user_goal_goalowner")]
        public SystemUser user_goal_goalowner
        {
            get { return GetRelatedEntity<SystemUser>("user_goal_goalowner", null); }
            set
            {
                OnPropertyChanging("user_goal_goalowner");
                SetRelatedEntity("user_goal_goalowner", null, value);
                OnPropertyChanged("user_goal_goalowner");
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