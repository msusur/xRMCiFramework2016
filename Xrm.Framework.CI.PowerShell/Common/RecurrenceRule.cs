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
    ///     Recurrence Rule represents the pattern of incidence of recurring entities.
    /// </summary>
    [DataContract]
    [EntityLogicalName("recurrencerule")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class RecurrenceRule : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "recurrencerule";

        public const int EntityTypeCode = 4250;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public RecurrenceRule() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the user who created the recurrence rule.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the recurrence rule was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the recurrence rule.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     The day of the month on which the recurring appointment or task occurs.
        /// </summary>
        [AttributeLogicalName("dayofmonth")]
        public int? DayOfMonth
        {
            get { return GetAttributeValue<int?>("dayofmonth"); }
            set
            {
                OnPropertyChanging("DayOfMonth");
                SetAttributeValue("dayofmonth", value);
                OnPropertyChanged("DayOfMonth");
            }
        }

        /// <summary>
        ///     Bitmask representing the days of the week on which the recurring appointment or task occurs.
        /// </summary>
        [AttributeLogicalName("daysofweekmask")]
        public int? DaysOfWeekMask
        {
            get { return GetAttributeValue<int?>("daysofweekmask"); }
            set
            {
                OnPropertyChanging("DaysOfWeekMask");
                SetAttributeValue("daysofweekmask", value);
                OnPropertyChanged("DaysOfWeekMask");
            }
        }

        /// <summary>
        ///     Duration of the recurrence pattern in minutes.
        /// </summary>
        [AttributeLogicalName("duration")]
        public int? Duration
        {
            get { return GetAttributeValue<int?>("duration"); }
            set
            {
                OnPropertyChanging("Duration");
                SetAttributeValue("duration", value);
                OnPropertyChanged("Duration");
            }
        }

        /// <summary>
        ///     The actual end date for expansion of the recurrence pattern.
        /// </summary>
        [AttributeLogicalName("effectiveenddate")]
        public DateTime? EffectiveEndDate
        {
            get { return GetAttributeValue<DateTime?>("effectiveenddate"); }
            set
            {
                OnPropertyChanging("EffectiveEndDate");
                SetAttributeValue("effectiveenddate", value);
                OnPropertyChanged("EffectiveEndDate");
            }
        }

        /// <summary>
        ///     The actual start date for expansion of the recurrence pattern.
        /// </summary>
        [AttributeLogicalName("effectivestartdate")]
        public DateTime? EffectiveStartDate
        {
            get { return GetAttributeValue<DateTime?>("effectivestartdate"); }
            set
            {
                OnPropertyChanging("EffectiveStartDate");
                SetAttributeValue("effectivestartdate", value);
                OnPropertyChanged("EffectiveStartDate");
            }
        }

        /// <summary>
        ///     End time of the associated activity.
        /// </summary>
        [AttributeLogicalName("endtime")]
        public DateTime? EndTime
        {
            get { return GetAttributeValue<DateTime?>("endtime"); }
            set
            {
                OnPropertyChanging("EndTime");
                SetAttributeValue("endtime", value);
                OnPropertyChanged("EndTime");
            }
        }

        /// <summary>
        ///     First day Of week for the recurrence pattern.
        /// </summary>
        [AttributeLogicalName("firstdayofweek")]
        public int? FirstDayOfWeek
        {
            get { return GetAttributeValue<int?>("firstdayofweek"); }
            set
            {
                OnPropertyChanging("FirstDayOfWeek");
                SetAttributeValue("firstdayofweek", value);
                OnPropertyChanged("FirstDayOfWeek");
            }
        }

        /// <summary>
        ///     Specifies the count for which the recurrence pattern is valid for a given interval.
        /// </summary>
        [AttributeLogicalName("instance")]
        public OptionSetValue Instance
        {
            get { return GetAttributeValue<OptionSetValue>("instance"); }
            set
            {
                OnPropertyChanging("Instance");
                SetAttributeValue("instance", value);
                OnPropertyChanged("Instance");
            }
        }

        /// <summary>
        ///     Number of units of a given recurrence type between occurrences.
        /// </summary>
        [AttributeLogicalName("interval")]
        public int? Interval
        {
            get { return GetAttributeValue<int?>("interval"); }
            set
            {
                OnPropertyChanging("Interval");
                SetAttributeValue("interval", value);
                OnPropertyChanged("Interval");
            }
        }

        /// <summary>
        ///     Specifies whether the monthly recurrence pattern is Nth monthly, valid only for monthly recurrence.
        /// </summary>
        [AttributeLogicalName("isnthmonthly")]
        public bool? IsNthMonthly
        {
            get { return GetAttributeValue<bool?>("isnthmonthly"); }
            set
            {
                OnPropertyChanging("IsNthMonthly");
                SetAttributeValue("isnthmonthly", value);
                OnPropertyChanged("IsNthMonthly");
            }
        }

        /// <summary>
        ///     Specifies whether the yearly recurrence pattern is Nth yearly, valid only for yearly recurrence.
        /// </summary>
        [AttributeLogicalName("isnthyearly")]
        public bool? IsNthYearly
        {
            get { return GetAttributeValue<bool?>("isnthyearly"); }
            set
            {
                OnPropertyChanging("IsNthYearly");
                SetAttributeValue("isnthyearly", value);
                OnPropertyChanged("IsNthYearly");
            }
        }

        /// <summary>
        ///     Valid only for task type recurrence,indicates whether task should be regenerated.
        /// </summary>
        [AttributeLogicalName("isregenerate")]
        public bool? IsRegenerate
        {
            get { return GetAttributeValue<bool?>("isregenerate"); }
            set
            {
                OnPropertyChanging("IsRegenerate");
                SetAttributeValue("isregenerate", value);
                OnPropertyChanged("IsRegenerate");
            }
        }

        /// <summary>
        ///     Specifies whether the weekly recurrence pattern is actually a daily every weekday pattern, valid only for weekly
        ///     recurrence.
        /// </summary>
        [AttributeLogicalName("isweekdaypattern")]
        public bool? IsWeekDayPattern
        {
            get { return GetAttributeValue<bool?>("isweekdaypattern"); }
            set
            {
                OnPropertyChanging("IsWeekDayPattern");
                SetAttributeValue("isweekdaypattern", value);
                OnPropertyChanged("IsWeekDayPattern");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the recurrence rule.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the recurrence rule was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who modified the recurrence rule.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Specifies the month of the year valid for the recurrence pattern.
        /// </summary>
        [AttributeLogicalName("monthofyear")]
        public OptionSetValue MonthOfYear
        {
            get { return GetAttributeValue<OptionSetValue>("monthofyear"); }
            set
            {
                OnPropertyChanging("MonthOfYear");
                SetAttributeValue("monthofyear", value);
                OnPropertyChanged("MonthOfYear");
            }
        }

        /// <summary>
        ///     Unique identifier of the object with which the recurrence rule is associated.
        /// </summary>
        [AttributeLogicalName("objectid")]
        public EntityReference ObjectId
        {
            get { return GetAttributeValue<EntityReference>("objectid"); }
            set
            {
                OnPropertyChanging("ObjectId");
                SetAttributeValue("objectid", value);
                OnPropertyChanged("ObjectId");
            }
        }

        /// <summary>
        ///     Number of occurrences of the recurrence pattern.
        /// </summary>
        [AttributeLogicalName("occurrences")]
        public int? Occurrences
        {
            get { return GetAttributeValue<int?>("occurrences"); }
            set
            {
                OnPropertyChanging("Occurrences");
                SetAttributeValue("occurrences", value);
                OnPropertyChanged("Occurrences");
            }
        }

        /// <summary>
        ///     Unique identifier of the user or team who owns the recurrence rule.
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
        ///     Unique identifier of the business unit that owns the recurrence rule.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     End date of the Recurrence Range.
        /// </summary>
        [AttributeLogicalName("patternenddate")]
        public DateTime? PatternEndDate
        {
            get { return GetAttributeValue<DateTime?>("patternenddate"); }
            set
            {
                OnPropertyChanging("PatternEndDate");
                SetAttributeValue("patternenddate", value);
                OnPropertyChanged("PatternEndDate");
            }
        }

        /// <summary>
        ///     Pattern End Type of a recurring series.
        /// </summary>
        [AttributeLogicalName("patternendtype")]
        public OptionSetValue PatternEndType
        {
            get { return GetAttributeValue<OptionSetValue>("patternendtype"); }
            set
            {
                OnPropertyChanging("PatternEndType");
                SetAttributeValue("patternendtype", value);
                OnPropertyChanged("PatternEndType");
            }
        }

        /// <summary>
        ///     Start date of the Recurrence Range.
        /// </summary>
        [AttributeLogicalName("patternstartdate")]
        public DateTime? PatternStartDate
        {
            get { return GetAttributeValue<DateTime?>("patternstartdate"); }
            set
            {
                OnPropertyChanging("PatternStartDate");
                SetAttributeValue("patternstartdate", value);
                OnPropertyChanged("PatternStartDate");
            }
        }

        /// <summary>
        ///     Type of Recurrence.
        /// </summary>
        [AttributeLogicalName("recurrencepatterntype")]
        public OptionSetValue RecurrencePatternType
        {
            get { return GetAttributeValue<OptionSetValue>("recurrencepatterntype"); }
            set
            {
                OnPropertyChanging("RecurrencePatternType");
                SetAttributeValue("recurrencepatterntype", value);
                OnPropertyChanged("RecurrencePatternType");
            }
        }

        /// <summary>
        ///     Unique identifier of the entity associated with recurrence rule.
        /// </summary>
        [AttributeLogicalName("ruleid")]
        public Guid? RuleId
        {
            get { return GetAttributeValue<Guid?>("ruleid"); }
            set
            {
                OnPropertyChanging("RuleId");
                SetAttributeValue("ruleid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("RuleId");
            }
        }

        [AttributeLogicalName("ruleid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { RuleId = value; }
        }

        /// <summary>
        ///     Start time of the recurring activity.
        /// </summary>
        [AttributeLogicalName("starttime")]
        public DateTime? StartTime
        {
            get { return GetAttributeValue<DateTime?>("starttime"); }
            set
            {
                OnPropertyChanging("StartTime");
                SetAttributeValue("starttime", value);
                OnPropertyChanged("StartTime");
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
        ///     1:N recurrencerule_recurringappointmentmaster
        /// </summary>
        [RelationshipSchemaName("recurrencerule_recurringappointmentmaster")]
        public IEnumerable<RecurringAppointmentMaster> recurrencerule_recurringappointmentmaster
        {
            get
            {
                return GetRelatedEntities<RecurringAppointmentMaster>("recurrencerule_recurringappointmentmaster", null);
            }
            set
            {
                OnPropertyChanging("recurrencerule_recurringappointmentmaster");
                SetRelatedEntities("recurrencerule_recurringappointmentmaster", null, value);
                OnPropertyChanged("recurrencerule_recurringappointmentmaster");
            }
        }

        /// <summary>
        ///     N:1 activity_pointer_recurrencerule
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("activity_pointer_recurrencerule")]
        public ActivityPointer activity_pointer_recurrencerule
        {
            get { return GetRelatedEntity<ActivityPointer>("activity_pointer_recurrencerule", null); }
            set
            {
                OnPropertyChanging("activity_pointer_recurrencerule");
                SetRelatedEntity("activity_pointer_recurrencerule", null, value);
                OnPropertyChanged("activity_pointer_recurrencerule");
            }
        }

        /// <summary>
        ///     N:1 business_unit_recurrencerule
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_recurrencerule")]
        public BusinessUnit business_unit_recurrencerule
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_recurrencerule", null); }
        }

        /// <summary>
        ///     N:1 lk_recurrencerule_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_recurrencerule_createdby")]
        public SystemUser lk_recurrencerule_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_recurrencerule_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_recurrencerule_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_recurrencerule_modifiedby")]
        public SystemUser lk_recurrencerule_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_recurrencerule_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_recurrencerulebase_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_recurrencerulebase_createdonbehalfby")]
        public SystemUser lk_recurrencerulebase_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_recurrencerulebase_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_recurrencerulebase_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_recurrencerulebase_modifiedonbehalfby")]
        public SystemUser lk_recurrencerulebase_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_recurrencerulebase_modifiedonbehalfby", null); }
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