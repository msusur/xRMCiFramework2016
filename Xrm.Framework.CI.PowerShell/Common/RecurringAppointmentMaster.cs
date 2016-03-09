using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Xrm.Framework.CI.Common.Entities
{
    /// <summary>
    ///     The Master appointment of a recurring appointment series.
    /// </summary>
    [DataContract]
    [EntityLogicalName("recurringappointmentmaster")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class RecurringAppointmentMaster : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "recurringappointmentmaster";

        public const int EntityTypeCode = 4251;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public RecurringAppointmentMaster() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the recurring appointment series.
        /// </summary>
        [AttributeLogicalName("activityid")]
        public Guid? ActivityId
        {
            get { return GetAttributeValue<Guid?>("activityid"); }
            set
            {
                OnPropertyChanging("ActivityId");
                SetAttributeValue("activityid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ActivityId");
            }
        }

        [AttributeLogicalName("activityid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ActivityId = value; }
        }

        /// <summary>
        ///     Type of activity.
        /// </summary>
        [AttributeLogicalName("activitytypecode")]
        public string ActivityTypeCode
        {
            get { return GetAttributeValue<string>("activitytypecode"); }
        }

        /// <summary>
        ///     Type a category to identify the recurring appointment type, such as status meeting or service call, to tie the
        ///     appointment to a business group or function.
        /// </summary>
        [AttributeLogicalName("category")]
        public string Category
        {
            get { return GetAttributeValue<string>("category"); }
            set
            {
                OnPropertyChanging("Category");
                SetAttributeValue("category", value);
                OnPropertyChanged("Category");
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
        ///     The day of the month on which the recurring appointment occurs.
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
        ///     Bitmask that represents the days of the week on which the recurring appointment occurs.
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
        ///     List of deleted instances of the recurring appointment series.
        /// </summary>
        [AttributeLogicalName("deletedexceptionslist")]
        public string DeletedExceptionsList
        {
            get { return GetAttributeValue<string>("deletedexceptionslist"); }
        }

        /// <summary>
        ///     Type additional information to describe the recurring appointment, such as key talking points or objectives.
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
        ///     Duration of the recurring appointment series in minutes.
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
        ///     Actual end date of the recurring appointment series based on the specified end date and recurrence pattern.
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
        ///     Actual start date of the recurring appointment series based on the specified start date and recurrence pattern.
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
        ///     Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the
        ///     record from the local currency to the system's default currency.
        /// </summary>
        [AttributeLogicalName("exchangerate")]
        public decimal? ExchangeRate
        {
            get { return GetAttributeValue<decimal?>("exchangerate"); }
        }

        /// <summary>
        ///     State code to indicate whether the recurring appointment series is expanded fully or partially.
        /// </summary>
        [AttributeLogicalName("expansionstatecode")]
        public OptionSetValue ExpansionStateCode
        {
            get { return GetAttributeValue<OptionSetValue>("expansionstatecode"); }
        }

        /// <summary>
        ///     First day of week for the recurrence pattern.
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
        ///     Unique Outlook identifier to correlate recurring appointment series across Exchange mailboxes.
        /// </summary>
        [AttributeLogicalName("globalobjectid")]
        public string GlobalObjectId
        {
            get { return GetAttributeValue<string>("globalobjectid"); }
            set
            {
                OnPropertyChanging("GlobalObjectId");
                SetAttributeValue("globalobjectid", value);
                OnPropertyChanged("GlobalObjectId");
            }
        }

        /// <summary>
        ///     Unique identifier of the recurring appointment series for which the recurrence information was updated.
        /// </summary>
        [AttributeLogicalName("groupid")]
        public EntityReference GroupId
        {
            get { return GetAttributeValue<EntityReference>("groupid"); }
        }

        /// <summary>
        ///     Unique identifier of the data import or data migration that created this record.
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
        ///     Specifies the recurring appointment series to occur on every Nth day of a month. Valid for monthly and yearly
        ///     recurrence patterns only.
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
        ///     Type of instance of a recurring appointment series.
        /// </summary>
        [AttributeLogicalName("instancetypecode")]
        public OptionSetValue InstanceTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("instancetypecode"); }
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
        ///     Select whether the recurring appointment is an all-day event to make sure that the required resources are scheduled
        ///     for the full day.
        /// </summary>
        [AttributeLogicalName("isalldayevent")]
        public bool? IsAllDayEvent
        {
            get { return GetAttributeValue<bool?>("isalldayevent"); }
            set
            {
                OnPropertyChanging("IsAllDayEvent");
                SetAttributeValue("isalldayevent", value);
                OnPropertyChanged("IsAllDayEvent");
            }
        }

        /// <summary>
        ///     Indicates whether the recurring appointment series was billed as part of resolving a case.
        /// </summary>
        [AttributeLogicalName("isbilled")]
        public bool? IsBilled
        {
            get { return GetAttributeValue<bool?>("isbilled"); }
            set
            {
                OnPropertyChanging("IsBilled");
                SetAttributeValue("isbilled", value);
                OnPropertyChanged("IsBilled");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("ismapiprivate")]
        public bool? IsMapiPrivate
        {
            get { return GetAttributeValue<bool?>("ismapiprivate"); }
            set
            {
                OnPropertyChanging("IsMapiPrivate");
                SetAttributeValue("ismapiprivate", value);
                OnPropertyChanged("IsMapiPrivate");
            }
        }

        /// <summary>
        ///     Indicates whether the recurring appointment series should occur after every N months. Valid for monthly recurrence
        ///     pattern only.
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
        ///     Indicates whether the recurring appointment series should occur after every N years. Valid for yearly recurrence
        ///     pattern only.
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
        ///     For internal use only.
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
        ///     Indicates whether the activity is a regular activity type or event type.
        /// </summary>
        [AttributeLogicalName("isregularactivity")]
        public bool? IsRegularActivity
        {
            get { return GetAttributeValue<bool?>("isregularactivity"); }
        }

        /// <summary>
        ///     Indicates whether the weekly recurrence pattern is a daily weekday pattern. Valid for weekly recurrence pattern
        ///     only.
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
        ///     Indicates whether the recurring appointment series was created from a workflow rule.
        /// </summary>
        [AttributeLogicalName("isworkflowcreated")]
        public bool? IsWorkflowCreated
        {
            get { return GetAttributeValue<bool?>("isworkflowcreated"); }
            set
            {
                OnPropertyChanging("IsWorkflowCreated");
                SetAttributeValue("isworkflowcreated", value);
                OnPropertyChanged("IsWorkflowCreated");
            }
        }

        /// <summary>
        ///     Date of last expanded instance of a recurring appointment series.
        /// </summary>
        [AttributeLogicalName("lastexpandedinstancedate")]
        public DateTime? LastExpandedInstanceDate
        {
            get { return GetAttributeValue<DateTime?>("lastexpandedinstancedate"); }
        }

        /// <summary>
        ///     Type the location where the recurring appointment will take place, such as a conference room or customer office.
        /// </summary>
        [AttributeLogicalName("location")]
        public string Location
        {
            get { return GetAttributeValue<string>("location"); }
            set
            {
                OnPropertyChanging("Location");
                SetAttributeValue("location", value);
                OnPropertyChanged("Location");
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
        ///     Indicates the month of the year for the recurrence pattern.
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
        ///     Date of the next expanded instance of a recurring appointment series.
        /// </summary>
        [AttributeLogicalName("nextexpansioninstancedate")]
        public DateTime? NextExpansionInstanceDate
        {
            get { return GetAttributeValue<DateTime?>("nextexpansioninstancedate"); }
        }

        /// <summary>
        ///     Number of appointment occurrences in a recurring appointment series.
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
        ///     Enter the account, contact, lead, user, or other equipment resources that are not needed at the recurring
        ///     appointment, but can optionally attend.
        /// </summary>
        [AttributeLogicalName("optionalattendees")]
        public IEnumerable<ActivityParty> OptionalAttendees
        {
            get
            {
                var collection = GetAttributeValue<EntityCollection>("optionalattendees");
                if (((collection != null)
                     && (collection.Entities != null)))
                {
                    return Enumerable.Cast<ActivityParty>(collection.Entities);
                }
                return null;
            }
            set
            {
                OnPropertyChanging("OptionalAttendees");
                if ((value == null))
                {
                    SetAttributeValue("optionalattendees", value);
                }
                else
                {
                    SetAttributeValue("optionalattendees", new EntityCollection(new List<Entity>(value)));
                }
                OnPropertyChanged("OptionalAttendees");
            }
        }

        /// <summary>
        ///     Enter the user who is in charge of coordinating or leading the recurring appointment to make sure the appointment
        ///     is displayed in the user's My Activities view.
        /// </summary>
        [AttributeLogicalName("organizer")]
        public IEnumerable<ActivityParty> Organizer
        {
            get
            {
                var collection = GetAttributeValue<EntityCollection>("organizer");
                if (((collection != null)
                     && (collection.Entities != null)))
                {
                    return Enumerable.Cast<ActivityParty>(collection.Entities);
                }
                return null;
            }
            set
            {
                OnPropertyChanging("Organizer");
                if ((value == null))
                {
                    SetAttributeValue("organizer", value);
                }
                else
                {
                    SetAttributeValue("organizer", new EntityCollection(new List<Entity>(value)));
                }
                OnPropertyChanged("Organizer");
            }
        }

        /// <summary>
        ///     Unique identifier of the Microsoft Office Outlook recurring appointment series owner that correlates to the
        ///     PR_OWNER_APPT_ID MAPI property.
        /// </summary>
        [AttributeLogicalName("outlookownerapptid")]
        public int? OutlookOwnerApptId
        {
            get { return GetAttributeValue<int?>("outlookownerapptid"); }
            set
            {
                OnPropertyChanging("OutlookOwnerApptId");
                SetAttributeValue("outlookownerapptid", value);
                OnPropertyChanged("OutlookOwnerApptId");
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
        ///     Unique identifier of the business unit that owns the recurring appointment series.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the recurring appointment series.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the recurring appointment series.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     End date of the recurrence range.
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
        ///     Select the type of end date for the recurring appointment, such as no end date or the number of occurrences.
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
        ///     Start date of the recurrence range.
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
        ///     Select the priority so that preferred customers or critical issues are handled quickly.
        /// </summary>
        [AttributeLogicalName("prioritycode")]
        public OptionSetValue PriorityCode
        {
            get { return GetAttributeValue<OptionSetValue>("prioritycode"); }
            set
            {
                OnPropertyChanging("PriorityCode");
                SetAttributeValue("prioritycode", value);
                OnPropertyChanged("PriorityCode");
            }
        }

        /// <summary>
        ///     Shows the ID of the process.
        /// </summary>
        [AttributeLogicalName("processid")]
        public Guid? ProcessId
        {
            get { return GetAttributeValue<Guid?>("processid"); }
            set
            {
                OnPropertyChanging("ProcessId");
                SetAttributeValue("processid", value);
                OnPropertyChanged("ProcessId");
            }
        }

        /// <summary>
        ///     Select the pattern type for the recurring appointment to indicate whether the appointment occurs daily, weekly,
        ///     monthly, or yearly.
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
        ///     Unique identifier of the object with which the recurring appointment series is associated.
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        public EntityReference RegardingObjectId
        {
            get { return GetAttributeValue<EntityReference>("regardingobjectid"); }
            set
            {
                OnPropertyChanging("RegardingObjectId");
                SetAttributeValue("regardingobjectid", value);
                OnPropertyChanged("RegardingObjectId");
            }
        }

        /// <summary>
        ///     Enter the account, contact, lead, user, or other equipment resources that are required to attend the recurring
        ///     appointment.
        /// </summary>
        [AttributeLogicalName("requiredattendees")]
        public IEnumerable<ActivityParty> RequiredAttendees
        {
            get
            {
                var collection = GetAttributeValue<EntityCollection>("requiredattendees");
                if (((collection != null)
                     && (collection.Entities != null)))
                {
                    return Enumerable.Cast<ActivityParty>(collection.Entities);
                }
                return null;
            }
            set
            {
                OnPropertyChanging("RequiredAttendees");
                if ((value == null))
                {
                    SetAttributeValue("requiredattendees", value);
                }
                else
                {
                    SetAttributeValue("requiredattendees", new EntityCollection(new List<Entity>(value)));
                }
                OnPropertyChanged("RequiredAttendees");
            }
        }

        /// <summary>
        ///     Unique identifier of the recurrence rule that is associated with the recurring appointment series.
        /// </summary>
        [AttributeLogicalName("ruleid")]
        public EntityReference RuleId
        {
            get { return GetAttributeValue<EntityReference>("ruleid"); }
        }

        /// <summary>
        ///     Scheduled end time of the recurring appointment series.
        /// </summary>
        [AttributeLogicalName("scheduledend")]
        public DateTime? ScheduledEnd
        {
            get { return GetAttributeValue<DateTime?>("scheduledend"); }
        }

        /// <summary>
        ///     Scheduled start time of the recurring appointment series.
        /// </summary>
        [AttributeLogicalName("scheduledstart")]
        public DateTime? ScheduledStart
        {
            get { return GetAttributeValue<DateTime?>("scheduledstart"); }
        }

        /// <summary>
        ///     Indicates whether the recurring appointment series is active or inactive.
        /// </summary>
        [AttributeLogicalName("seriesstatus")]
        public bool? SeriesStatus
        {
            get { return GetAttributeValue<bool?>("seriesstatus"); }
            set
            {
                OnPropertyChanging("SeriesStatus");
                SetAttributeValue("seriesstatus", value);
                OnPropertyChanged("SeriesStatus");
            }
        }

        /// <summary>
        ///     Unique identifier for an associated service.
        /// </summary>
        [AttributeLogicalName("serviceid")]
        public EntityReference ServiceId
        {
            get { return GetAttributeValue<EntityReference>("serviceid"); }
            set
            {
                OnPropertyChanging("ServiceId");
                SetAttributeValue("serviceid", value);
                OnPropertyChanged("ServiceId");
            }
        }

        /// <summary>
        ///     Shows the ID of the stage.
        /// </summary>
        [AttributeLogicalName("stageid")]
        public Guid? StageId
        {
            get { return GetAttributeValue<Guid?>("stageid"); }
            set
            {
                OnPropertyChanging("StageId");
                SetAttributeValue("stageid", value);
                OnPropertyChanged("StageId");
            }
        }

        /// <summary>
        ///     Start time of the recurring appointment series.
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
        ///     Shows whether the recurring appointment is open, scheduled, completed, or canceled. Completed and canceled
        ///     appointments are read-only and can't be edited.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public RecurringAppointmentMasterState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return
                        ((RecurringAppointmentMasterState)
                            (Enum.ToObject(typeof (RecurringAppointmentMasterState), optionSet.Value)));
                }
                return null;
            }
            set
            {
                OnPropertyChanging("StateCode");
                if ((value == null))
                {
                    SetAttributeValue("statecode", null);
                }
                else
                {
                    SetAttributeValue("statecode", new OptionSetValue(((int) (value))));
                }
                OnPropertyChanged("StateCode");
            }
        }

        /// <summary>
        ///     Select the recurring appointment's status.
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
        ///     Type a subcategory to identify the recurring appointment type and relate the activity to a specific product, sales
        ///     region, business group, or other function.
        /// </summary>
        [AttributeLogicalName("subcategory")]
        public string Subcategory
        {
            get { return GetAttributeValue<string>("subcategory"); }
            set
            {
                OnPropertyChanging("Subcategory");
                SetAttributeValue("subcategory", value);
                OnPropertyChanged("Subcategory");
            }
        }

        /// <summary>
        ///     Type a short description about the objective or primary topic of the recurring appointment.
        /// </summary>
        [AttributeLogicalName("subject")]
        public string Subject
        {
            get { return GetAttributeValue<string>("subject"); }
            set
            {
                OnPropertyChanging("Subject");
                SetAttributeValue("subject", value);
                OnPropertyChanged("Subject");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("subscriptionid")]
        public Guid? SubscriptionId
        {
            get { return GetAttributeValue<Guid?>("subscriptionid"); }
            set
            {
                OnPropertyChanging("SubscriptionId");
                SetAttributeValue("subscriptionid", value);
                OnPropertyChanged("SubscriptionId");
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
        ///     Choose the local currency for the record to make sure budgets are reported in the correct currency.
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        public EntityReference TransactionCurrencyId
        {
            get { return GetAttributeValue<EntityReference>("transactioncurrencyid"); }
            set
            {
                OnPropertyChanging("TransactionCurrencyId");
                SetAttributeValue("transactioncurrencyid", value);
                OnPropertyChanged("TransactionCurrencyId");
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
        ///     1:N recurringappointmentmaster_activity_parties
        /// </summary>
        [RelationshipSchemaName("recurringappointmentmaster_activity_parties")]
        public IEnumerable<ActivityParty> recurringappointmentmaster_activity_parties
        {
            get { return GetRelatedEntities<ActivityParty>("recurringappointmentmaster_activity_parties", null); }
            set
            {
                OnPropertyChanging("recurringappointmentmaster_activity_parties");
                SetRelatedEntities("recurringappointmentmaster_activity_parties", null, value);
                OnPropertyChanged("recurringappointmentmaster_activity_parties");
            }
        }

        /// <summary>
        ///     1:N RecurringAppointmentMaster_Annotation
        /// </summary>
        [RelationshipSchemaName("RecurringAppointmentMaster_Annotation")]
        public IEnumerable<Annotation> RecurringAppointmentMaster_Annotation
        {
            get { return GetRelatedEntities<Annotation>("RecurringAppointmentMaster_Annotation", null); }
            set
            {
                OnPropertyChanging("RecurringAppointmentMaster_Annotation");
                SetRelatedEntities("RecurringAppointmentMaster_Annotation", null, value);
                OnPropertyChanged("RecurringAppointmentMaster_Annotation");
            }
        }

        /// <summary>
        ///     1:N recurringappointmentmaster_appointment
        /// </summary>
        [RelationshipSchemaName("recurringappointmentmaster_appointment")]
        public IEnumerable<Appointment> recurringappointmentmaster_appointment
        {
            get { return GetRelatedEntities<Appointment>("recurringappointmentmaster_appointment", null); }
            set
            {
                OnPropertyChanging("recurringappointmentmaster_appointment");
                SetRelatedEntities("recurringappointmentmaster_appointment", null, value);
                OnPropertyChanged("recurringappointmentmaster_appointment");
            }
        }

        /// <summary>
        ///     1:N RecurringAppointmentMaster_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("RecurringAppointmentMaster_AsyncOperations")]
        public IEnumerable<AsyncOperation> RecurringAppointmentMaster_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("RecurringAppointmentMaster_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("RecurringAppointmentMaster_AsyncOperations");
                SetRelatedEntities("RecurringAppointmentMaster_AsyncOperations", null, value);
                OnPropertyChanged("RecurringAppointmentMaster_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N RecurringAppointmentMaster_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("RecurringAppointmentMaster_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> RecurringAppointmentMaster_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("RecurringAppointmentMaster_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("RecurringAppointmentMaster_BulkDeleteFailures");
                SetRelatedEntities("RecurringAppointmentMaster_BulkDeleteFailures", null, value);
                OnPropertyChanged("RecurringAppointmentMaster_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N recurringappointmentmaster_campaignresponse
        /// </summary>
        [RelationshipSchemaName("recurringappointmentmaster_campaignresponse")]
        public IEnumerable<CampaignResponse> recurringappointmentmaster_campaignresponse
        {
            get { return GetRelatedEntities<CampaignResponse>("recurringappointmentmaster_campaignresponse", null); }
            set
            {
                OnPropertyChanging("recurringappointmentmaster_campaignresponse");
                SetRelatedEntities("recurringappointmentmaster_campaignresponse", null, value);
                OnPropertyChanged("recurringappointmentmaster_campaignresponse");
            }
        }

        /// <summary>
        ///     1:N recurringappointmentmaster_connections1
        /// </summary>
        [RelationshipSchemaName("recurringappointmentmaster_connections1")]
        public IEnumerable<Connection> recurringappointmentmaster_connections1
        {
            get { return GetRelatedEntities<Connection>("recurringappointmentmaster_connections1", null); }
            set
            {
                OnPropertyChanging("recurringappointmentmaster_connections1");
                SetRelatedEntities("recurringappointmentmaster_connections1", null, value);
                OnPropertyChanged("recurringappointmentmaster_connections1");
            }
        }

        /// <summary>
        ///     1:N recurringappointmentmaster_connections2
        /// </summary>
        [RelationshipSchemaName("recurringappointmentmaster_connections2")]
        public IEnumerable<Connection> recurringappointmentmaster_connections2
        {
            get { return GetRelatedEntities<Connection>("recurringappointmentmaster_connections2", null); }
            set
            {
                OnPropertyChanging("recurringappointmentmaster_connections2");
                SetRelatedEntities("recurringappointmentmaster_connections2", null, value);
                OnPropertyChanged("recurringappointmentmaster_connections2");
            }
        }

        /// <summary>
        ///     1:N RecurringAppointmentMaster_DuplicateBaseRecord
        /// </summary>
        [RelationshipSchemaName("RecurringAppointmentMaster_DuplicateBaseRecord")]
        public IEnumerable<DuplicateRecord> RecurringAppointmentMaster_DuplicateBaseRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("RecurringAppointmentMaster_DuplicateBaseRecord", null); }
            set
            {
                OnPropertyChanging("RecurringAppointmentMaster_DuplicateBaseRecord");
                SetRelatedEntities("RecurringAppointmentMaster_DuplicateBaseRecord", null, value);
                OnPropertyChanged("RecurringAppointmentMaster_DuplicateBaseRecord");
            }
        }

        /// <summary>
        ///     1:N RecurringAppointmentMaster_DuplicateMatchingRecord
        /// </summary>
        [RelationshipSchemaName("RecurringAppointmentMaster_DuplicateMatchingRecord")]
        public IEnumerable<DuplicateRecord> RecurringAppointmentMaster_DuplicateMatchingRecord
        {
            get
            {
                return GetRelatedEntities<DuplicateRecord>("RecurringAppointmentMaster_DuplicateMatchingRecord", null);
            }
            set
            {
                OnPropertyChanging("RecurringAppointmentMaster_DuplicateMatchingRecord");
                SetRelatedEntities("RecurringAppointmentMaster_DuplicateMatchingRecord", null, value);
                OnPropertyChanged("RecurringAppointmentMaster_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        ///     1:N recurringappointmentmaster_PostFollows
        /// </summary>
        [RelationshipSchemaName("recurringappointmentmaster_PostFollows")]
        public IEnumerable<PostFollow> recurringappointmentmaster_PostFollows
        {
            get { return GetRelatedEntities<PostFollow>("recurringappointmentmaster_PostFollows", null); }
            set
            {
                OnPropertyChanging("recurringappointmentmaster_PostFollows");
                SetRelatedEntities("recurringappointmentmaster_PostFollows", null, value);
                OnPropertyChanged("recurringappointmentmaster_PostFollows");
            }
        }

        /// <summary>
        ///     1:N recurringappointmentmaster_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("recurringappointmentmaster_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> recurringappointmentmaster_principalobjectattributeaccess
        {
            get
            {
                return
                    GetRelatedEntities<PrincipalObjectAttributeAccess>(
                        "recurringappointmentmaster_principalobjectattributeaccess", null);
            }
            set
            {
                OnPropertyChanging("recurringappointmentmaster_principalobjectattributeaccess");
                SetRelatedEntities("recurringappointmentmaster_principalobjectattributeaccess", null, value);
                OnPropertyChanged("recurringappointmentmaster_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N RecurringAppointmentMaster_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("RecurringAppointmentMaster_ProcessSessions")]
        public IEnumerable<ProcessSession> RecurringAppointmentMaster_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("RecurringAppointmentMaster_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("RecurringAppointmentMaster_ProcessSessions");
                SetRelatedEntities("RecurringAppointmentMaster_ProcessSessions", null, value);
                OnPropertyChanged("RecurringAppointmentMaster_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N RecurringAppointmentMaster_QueueItem
        /// </summary>
        [RelationshipSchemaName("RecurringAppointmentMaster_QueueItem")]
        public IEnumerable<QueueItem> RecurringAppointmentMaster_QueueItem
        {
            get { return GetRelatedEntities<QueueItem>("RecurringAppointmentMaster_QueueItem", null); }
            set
            {
                OnPropertyChanging("RecurringAppointmentMaster_QueueItem");
                SetRelatedEntities("RecurringAppointmentMaster_QueueItem", null, value);
                OnPropertyChanged("RecurringAppointmentMaster_QueueItem");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_recurringappointmentmaster
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_recurringappointmentmaster")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_recurringappointmentmaster
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_recurringappointmentmaster",
                    null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_recurringappointmentmaster");
                SetRelatedEntities("userentityinstancedata_recurringappointmentmaster", null, value);
                OnPropertyChanged("userentityinstancedata_recurringappointmentmaster");
            }
        }

        /// <summary>
        ///     N:1 Account_RecurringAppointmentMasters
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Account_RecurringAppointmentMasters")]
        public Account Account_RecurringAppointmentMasters
        {
            get { return GetRelatedEntity<Account>("Account_RecurringAppointmentMasters", null); }
            set
            {
                OnPropertyChanging("Account_RecurringAppointmentMasters");
                SetRelatedEntity("Account_RecurringAppointmentMasters", null, value);
                OnPropertyChanged("Account_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        ///     N:1 activity_pointer_recurringappointmentmaster
        /// </summary>
        [AttributeLogicalName("activityid")]
        [RelationshipSchemaName("activity_pointer_recurringappointmentmaster")]
        public ActivityPointer activity_pointer_recurringappointmentmaster
        {
            get { return GetRelatedEntity<ActivityPointer>("activity_pointer_recurringappointmentmaster", null); }
            set
            {
                OnPropertyChanging("activity_pointer_recurringappointmentmaster");
                SetRelatedEntity("activity_pointer_recurringappointmentmaster", null, value);
                OnPropertyChanged("activity_pointer_recurringappointmentmaster");
            }
        }

        /// <summary>
        ///     N:1 BulkOperation_RecurringAppointmentMaster
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("BulkOperation_RecurringAppointmentMaster")]
        public BulkOperation BulkOperation_RecurringAppointmentMaster
        {
            get { return GetRelatedEntity<BulkOperation>("BulkOperation_RecurringAppointmentMaster", null); }
            set
            {
                OnPropertyChanging("BulkOperation_RecurringAppointmentMaster");
                SetRelatedEntity("BulkOperation_RecurringAppointmentMaster", null, value);
                OnPropertyChanged("BulkOperation_RecurringAppointmentMaster");
            }
        }

        /// <summary>
        ///     N:1 business_unit_recurringappointmentmaster_activities
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_recurringappointmentmaster_activities")]
        public BusinessUnit business_unit_recurringappointmentmaster_activities
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_recurringappointmentmaster_activities", null); }
        }

        /// <summary>
        ///     N:1 Campaign_RecurringAppointmentMasters
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Campaign_RecurringAppointmentMasters")]
        public Campaign Campaign_RecurringAppointmentMasters
        {
            get { return GetRelatedEntity<Campaign>("Campaign_RecurringAppointmentMasters", null); }
            set
            {
                OnPropertyChanging("Campaign_RecurringAppointmentMasters");
                SetRelatedEntity("Campaign_RecurringAppointmentMasters", null, value);
                OnPropertyChanged("Campaign_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        ///     N:1 CampaignActivity_RecurringAppointmentMasters
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("CampaignActivity_RecurringAppointmentMasters")]
        public CampaignActivity CampaignActivity_RecurringAppointmentMasters
        {
            get { return GetRelatedEntity<CampaignActivity>("CampaignActivity_RecurringAppointmentMasters", null); }
            set
            {
                OnPropertyChanging("CampaignActivity_RecurringAppointmentMasters");
                SetRelatedEntity("CampaignActivity_RecurringAppointmentMasters", null, value);
                OnPropertyChanged("CampaignActivity_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        ///     N:1 Contact_RecurringAppointmentMasters
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Contact_RecurringAppointmentMasters")]
        public Contact Contact_RecurringAppointmentMasters
        {
            get { return GetRelatedEntity<Contact>("Contact_RecurringAppointmentMasters", null); }
            set
            {
                OnPropertyChanging("Contact_RecurringAppointmentMasters");
                SetRelatedEntity("Contact_RecurringAppointmentMasters", null, value);
                OnPropertyChanged("Contact_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        ///     N:1 Contract_RecurringAppointmentMasters
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Contract_RecurringAppointmentMasters")]
        public Contract Contract_RecurringAppointmentMasters
        {
            get { return GetRelatedEntity<Contract>("Contract_RecurringAppointmentMasters", null); }
            set
            {
                OnPropertyChanging("Contract_RecurringAppointmentMasters");
                SetRelatedEntity("Contract_RecurringAppointmentMasters", null, value);
                OnPropertyChanged("Contract_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        ///     N:1 Incident_RecurringAppointmentMasters
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Incident_RecurringAppointmentMasters")]
        public Incident Incident_RecurringAppointmentMasters
        {
            get { return GetRelatedEntity<Incident>("Incident_RecurringAppointmentMasters", null); }
            set
            {
                OnPropertyChanging("Incident_RecurringAppointmentMasters");
                SetRelatedEntity("Incident_RecurringAppointmentMasters", null, value);
                OnPropertyChanged("Incident_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        ///     N:1 Invoice_RecurringAppointmentMasters
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Invoice_RecurringAppointmentMasters")]
        public Invoice Invoice_RecurringAppointmentMasters
        {
            get { return GetRelatedEntity<Invoice>("Invoice_RecurringAppointmentMasters", null); }
            set
            {
                OnPropertyChanging("Invoice_RecurringAppointmentMasters");
                SetRelatedEntity("Invoice_RecurringAppointmentMasters", null, value);
                OnPropertyChanged("Invoice_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        ///     N:1 Lead_RecurringAppointmentMasters
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Lead_RecurringAppointmentMasters")]
        public Lead Lead_RecurringAppointmentMasters
        {
            get { return GetRelatedEntity<Lead>("Lead_RecurringAppointmentMasters", null); }
            set
            {
                OnPropertyChanging("Lead_RecurringAppointmentMasters");
                SetRelatedEntity("Lead_RecurringAppointmentMasters", null, value);
                OnPropertyChanged("Lead_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        ///     N:1 lk_recurringappointmentmaster_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_recurringappointmentmaster_createdby")]
        public SystemUser lk_recurringappointmentmaster_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_recurringappointmentmaster_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_recurringappointmentmaster_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_recurringappointmentmaster_createdonbehalfby")]
        public SystemUser lk_recurringappointmentmaster_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_recurringappointmentmaster_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_recurringappointmentmaster_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_recurringappointmentmaster_modifiedby")]
        public SystemUser lk_recurringappointmentmaster_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_recurringappointmentmaster_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_recurringappointmentmaster_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_recurringappointmentmaster_modifiedonbehalfby")]
        public SystemUser lk_recurringappointmentmaster_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_recurringappointmentmaster_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 msdyn_postalbum_RecurringAppointmentMasters
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("msdyn_postalbum_RecurringAppointmentMasters")]
        public msdyn_PostAlbum msdyn_postalbum_RecurringAppointmentMasters
        {
            get { return GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_RecurringAppointmentMasters", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_RecurringAppointmentMasters");
                SetRelatedEntity("msdyn_postalbum_RecurringAppointmentMasters", null, value);
                OnPropertyChanged("msdyn_postalbum_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        ///     N:1 Opportunity_RecurringAppointmentMasters
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Opportunity_RecurringAppointmentMasters")]
        public Opportunity Opportunity_RecurringAppointmentMasters
        {
            get { return GetRelatedEntity<Opportunity>("Opportunity_RecurringAppointmentMasters", null); }
            set
            {
                OnPropertyChanging("Opportunity_RecurringAppointmentMasters");
                SetRelatedEntity("Opportunity_RecurringAppointmentMasters", null, value);
                OnPropertyChanged("Opportunity_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        ///     N:1 processstage_recurringappointmentmasters
        /// </summary>
        [AttributeLogicalName("stageid")]
        [RelationshipSchemaName("processstage_recurringappointmentmasters")]
        public ProcessStage processstage_recurringappointmentmasters
        {
            get { return GetRelatedEntity<ProcessStage>("processstage_recurringappointmentmasters", null); }
            set
            {
                OnPropertyChanging("processstage_recurringappointmentmasters");
                SetRelatedEntity("processstage_recurringappointmentmasters", null, value);
                OnPropertyChanged("processstage_recurringappointmentmasters");
            }
        }

        /// <summary>
        ///     N:1 Quote_RecurringAppointmentMasters
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Quote_RecurringAppointmentMasters")]
        public Quote Quote_RecurringAppointmentMasters
        {
            get { return GetRelatedEntity<Quote>("Quote_RecurringAppointmentMasters", null); }
            set
            {
                OnPropertyChanging("Quote_RecurringAppointmentMasters");
                SetRelatedEntity("Quote_RecurringAppointmentMasters", null, value);
                OnPropertyChanged("Quote_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        ///     N:1 recurrencerule_recurringappointmentmaster
        /// </summary>
        [AttributeLogicalName("activityid")]
        [RelationshipSchemaName("recurrencerule_recurringappointmentmaster")]
        public RecurrenceRule recurrencerule_recurringappointmentmaster
        {
            get { return GetRelatedEntity<RecurrenceRule>("recurrencerule_recurringappointmentmaster", null); }
            set
            {
                OnPropertyChanging("recurrencerule_recurringappointmentmaster");
                SetRelatedEntity("recurrencerule_recurringappointmentmaster", null, value);
                OnPropertyChanged("recurrencerule_recurringappointmentmaster");
            }
        }

        /// <summary>
        ///     N:1 SalesOrder_RecurringAppointmentMasters
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SalesOrder_RecurringAppointmentMasters")]
        public SalesOrder SalesOrder_RecurringAppointmentMasters
        {
            get { return GetRelatedEntity<SalesOrder>("SalesOrder_RecurringAppointmentMasters", null); }
            set
            {
                OnPropertyChanging("SalesOrder_RecurringAppointmentMasters");
                SetRelatedEntity("SalesOrder_RecurringAppointmentMasters", null, value);
                OnPropertyChanged("SalesOrder_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        ///     N:1 service_recurringappointmentmasters
        /// </summary>
        [AttributeLogicalName("serviceid")]
        [RelationshipSchemaName("service_recurringappointmentmasters")]
        public Service service_recurringappointmentmasters
        {
            get { return GetRelatedEntity<Service>("service_recurringappointmentmasters", null); }
            set
            {
                OnPropertyChanging("service_recurringappointmentmasters");
                SetRelatedEntity("service_recurringappointmentmasters", null, value);
                OnPropertyChanged("service_recurringappointmentmasters");
            }
        }

        /// <summary>
        ///     N:1 team_recurringappointmentmaster
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_recurringappointmentmaster")]
        public Team team_recurringappointmentmaster
        {
            get { return GetRelatedEntity<Team>("team_recurringappointmentmaster", null); }
        }

        /// <summary>
        ///     N:1 TransactionCurrency_RecurringAppointmentMaster
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("TransactionCurrency_RecurringAppointmentMaster")]
        public TransactionCurrency TransactionCurrency_RecurringAppointmentMaster
        {
            get
            {
                return GetRelatedEntity<TransactionCurrency>("TransactionCurrency_RecurringAppointmentMaster", null);
            }
            set
            {
                OnPropertyChanging("TransactionCurrency_RecurringAppointmentMaster");
                SetRelatedEntity("TransactionCurrency_RecurringAppointmentMaster", null, value);
                OnPropertyChanged("TransactionCurrency_RecurringAppointmentMaster");
            }
        }

        /// <summary>
        ///     N:1 user_recurringappointmentmaster
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_recurringappointmentmaster")]
        public SystemUser user_recurringappointmentmaster
        {
            get { return GetRelatedEntity<SystemUser>("user_recurringappointmentmaster", null); }
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