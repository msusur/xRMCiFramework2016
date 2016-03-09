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
    ///     Defines free/busy times for a service and for resources or resource groups, such as working, non-working, vacation,
    ///     and blocked.
    /// </summary>
    [DataContract]
    [EntityLogicalName("calendarrule")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class CalendarRule : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "calendarrule";

        public const int EntityTypeCode = 4004;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public CalendarRule() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the business unit with which the calendar rule is associated.
        /// </summary>
        [AttributeLogicalName("businessunitid")]
        public Guid? BusinessUnitId
        {
            get { return GetAttributeValue<Guid?>("businessunitid"); }
        }

        /// <summary>
        ///     Unique identifier of the calendar with which the calendar rule is associated.
        /// </summary>
        [AttributeLogicalName("calendarid")]
        public EntityReference CalendarId
        {
            get { return GetAttributeValue<EntityReference>("calendarid"); }
            set
            {
                OnPropertyChanging("CalendarId");
                SetAttributeValue("calendarid", value);
                OnPropertyChanged("CalendarId");
            }
        }

        /// <summary>
        ///     Unique identifier of the calendar rule.
        /// </summary>
        [AttributeLogicalName("calendarruleid")]
        public Guid? CalendarRuleId
        {
            get { return GetAttributeValue<Guid?>("calendarruleid"); }
            set
            {
                OnPropertyChanging("CalendarRuleId");
                SetAttributeValue("calendarruleid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("CalendarRuleId");
            }
        }

        [AttributeLogicalName("calendarruleid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { CalendarRuleId = value; }
        }

        /// <summary>
        ///     Unique identifier of the user who created the calendar rule.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the calendar rule was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the calendarrule.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Defines free/busy times for a service and for resources or resource groups, such as working, non-working, vacation,
        ///     and blocked.
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
        ///     Duration of the calendar rule in minutes.
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
        ///     Effective interval end of the calendar rule.
        /// </summary>
        [AttributeLogicalName("effectiveintervalend")]
        public DateTime? EffectiveIntervalEnd
        {
            get { return GetAttributeValue<DateTime?>("effectiveintervalend"); }
            set
            {
                OnPropertyChanging("EffectiveIntervalEnd");
                SetAttributeValue("effectiveintervalend", value);
                OnPropertyChanged("EffectiveIntervalEnd");
            }
        }

        /// <summary>
        ///     Effective interval start of the calendar rule.
        /// </summary>
        [AttributeLogicalName("effectiveintervalstart")]
        public DateTime? EffectiveIntervalStart
        {
            get { return GetAttributeValue<DateTime?>("effectiveintervalstart"); }
            set
            {
                OnPropertyChanging("EffectiveIntervalStart");
                SetAttributeValue("effectiveintervalstart", value);
                OnPropertyChanged("EffectiveIntervalStart");
            }
        }

        /// <summary>
        ///     Effort available for a resource during the time described by the calendar rule.
        /// </summary>
        [AttributeLogicalName("effort")]
        public double? Effort
        {
            get { return GetAttributeValue<double?>("effort"); }
            set
            {
                OnPropertyChanging("Effort");
                SetAttributeValue("effort", value);
                OnPropertyChanged("Effort");
            }
        }

        /// <summary>
        ///     For internal use only.
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
        ///     Extent of the calendar rule.
        /// </summary>
        [AttributeLogicalName("extentcode")]
        public int? ExtentCode
        {
            get { return GetAttributeValue<int?>("extentcode"); }
            set
            {
                OnPropertyChanging("ExtentCode");
                SetAttributeValue("extentcode", value);
                OnPropertyChanged("ExtentCode");
            }
        }

        /// <summary>
        ///     Unique identifier of the group.
        /// </summary>
        [AttributeLogicalName("groupdesignator")]
        public string GroupDesignator
        {
            get { return GetAttributeValue<string>("groupdesignator"); }
            set
            {
                OnPropertyChanging("GroupDesignator");
                SetAttributeValue("groupdesignator", value);
                OnPropertyChanged("GroupDesignator");
            }
        }

        /// <summary>
        ///     Unique identifier of the inner calendar for non-leaf calendar rules.
        /// </summary>
        [AttributeLogicalName("innercalendarid")]
        public EntityReference InnerCalendarId
        {
            get { return GetAttributeValue<EntityReference>("innercalendarid"); }
            set
            {
                OnPropertyChanging("InnerCalendarId");
                SetAttributeValue("innercalendarid", value);
                OnPropertyChanged("InnerCalendarId");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("ismodified")]
        public bool? IsModified
        {
            get { return GetAttributeValue<bool?>("ismodified"); }
            set
            {
                OnPropertyChanging("IsModified");
                SetAttributeValue("ismodified", value);
                OnPropertyChanged("IsModified");
            }
        }

        /// <summary>
        ///     Flag used in vary-by-day calendar rules.
        /// </summary>
        [AttributeLogicalName("isselected")]
        public bool? IsSelected
        {
            get { return GetAttributeValue<bool?>("isselected"); }
            set
            {
                OnPropertyChanging("IsSelected");
                SetAttributeValue("isselected", value);
                OnPropertyChanged("IsSelected");
            }
        }

        /// <summary>
        ///     Flag used in vary-by-day calendar rules.
        /// </summary>
        [AttributeLogicalName("issimple")]
        public bool? IsSimple
        {
            get { return GetAttributeValue<bool?>("issimple"); }
            set
            {
                OnPropertyChanging("IsSimple");
                SetAttributeValue("issimple", value);
                OnPropertyChanged("IsSimple");
            }
        }

        /// <summary>
        ///     Flag used in leaf nonrecurring rules.
        /// </summary>
        [AttributeLogicalName("isvaried")]
        public bool? IsVaried
        {
            get { return GetAttributeValue<bool?>("isvaried"); }
            set
            {
                OnPropertyChanging("IsVaried");
                SetAttributeValue("isvaried", value);
                OnPropertyChanged("IsVaried");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the calendar rule.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the calendar rule was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the calendarrule.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the calendar rule.
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
        ///     Start offset for leaf nonrecurring rules.
        /// </summary>
        [AttributeLogicalName("offset")]
        public int? Offset
        {
            get { return GetAttributeValue<int?>("offset"); }
            set
            {
                OnPropertyChanging("Offset");
                SetAttributeValue("offset", value);
                OnPropertyChanged("Offset");
            }
        }

        /// <summary>
        ///     Unique identifier of the organization with which the calendar rule is associated.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public Guid? OrganizationId
        {
            get { return GetAttributeValue<Guid?>("organizationid"); }
        }

        /// <summary>
        ///     Pattern of the rule recurrence.
        /// </summary>
        [AttributeLogicalName("pattern")]
        public string Pattern
        {
            get { return GetAttributeValue<string>("pattern"); }
            set
            {
                OnPropertyChanging("Pattern");
                SetAttributeValue("pattern", value);
                OnPropertyChanged("Pattern");
            }
        }

        /// <summary>
        ///     Rank of the calendar rule.
        /// </summary>
        [AttributeLogicalName("rank")]
        public int? Rank
        {
            get { return GetAttributeValue<int?>("rank"); }
            set
            {
                OnPropertyChanging("Rank");
                SetAttributeValue("rank", value);
                OnPropertyChanged("Rank");
            }
        }

        /// <summary>
        ///     Unique identifier of the service with which the calendar rule is associated.
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
        ///     Start time for the rule.
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
        ///     Sub-type of calendar rule.
        /// </summary>
        [AttributeLogicalName("subcode")]
        public int? SubCode
        {
            get { return GetAttributeValue<int?>("subcode"); }
            set
            {
                OnPropertyChanging("SubCode");
                SetAttributeValue("subcode", value);
                OnPropertyChanged("SubCode");
            }
        }

        /// <summary>
        ///     Type of calendar rule such as working hours, break, holiday, or time off.
        /// </summary>
        [AttributeLogicalName("timecode")]
        public int? TimeCode
        {
            get { return GetAttributeValue<int?>("timecode"); }
            set
            {
                OnPropertyChanging("TimeCode");
                SetAttributeValue("timecode", value);
                OnPropertyChanged("TimeCode");
            }
        }

        /// <summary>
        ///     Local time zone for the calendar rule.
        /// </summary>
        [AttributeLogicalName("timezonecode")]
        public int? TimeZoneCode
        {
            get { return GetAttributeValue<int?>("timezonecode"); }
            set
            {
                OnPropertyChanging("TimeZoneCode");
                SetAttributeValue("timezonecode", value);
                OnPropertyChanged("TimeZoneCode");
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
        ///     1:N userentityinstancedata_calendarrule
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_calendarrule")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_calendarrule
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_calendarrule", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_calendarrule");
                SetRelatedEntities("userentityinstancedata_calendarrule", null, value);
                OnPropertyChanged("userentityinstancedata_calendarrule");
            }
        }

        /// <summary>
        ///     N:1 calendar_calendar_rules
        /// </summary>
        [AttributeLogicalName("calendarid")]
        [RelationshipSchemaName("calendar_calendar_rules")]
        public Calendar calendar_calendar_rules
        {
            get { return GetRelatedEntity<Calendar>("calendar_calendar_rules", null); }
            set
            {
                OnPropertyChanging("calendar_calendar_rules");
                SetRelatedEntity("calendar_calendar_rules", null, value);
                OnPropertyChanged("calendar_calendar_rules");
            }
        }

        /// <summary>
        ///     N:1 inner_calendar_calendar_rules
        /// </summary>
        [AttributeLogicalName("innercalendarid")]
        [RelationshipSchemaName("inner_calendar_calendar_rules")]
        public Calendar inner_calendar_calendar_rules
        {
            get { return GetRelatedEntity<Calendar>("inner_calendar_calendar_rules", null); }
            set
            {
                OnPropertyChanging("inner_calendar_calendar_rules");
                SetRelatedEntity("inner_calendar_calendar_rules", null, value);
                OnPropertyChanged("inner_calendar_calendar_rules");
            }
        }

        /// <summary>
        ///     N:1 lk_calendarrule_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_calendarrule_createdby")]
        public SystemUser lk_calendarrule_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_calendarrule_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_calendarrule_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_calendarrule_createdonbehalfby")]
        public SystemUser lk_calendarrule_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_calendarrule_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_calendarrule_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_calendarrule_modifiedby")]
        public SystemUser lk_calendarrule_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_calendarrule_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_calendarrule_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_calendarrule_modifiedonbehalfby")]
        public SystemUser lk_calendarrule_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_calendarrule_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 service_calendar_rules
        /// </summary>
        [AttributeLogicalName("serviceid")]
        [RelationshipSchemaName("service_calendar_rules")]
        public Service service_calendar_rules
        {
            get { return GetRelatedEntity<Service>("service_calendar_rules", null); }
            set
            {
                OnPropertyChanging("service_calendar_rules");
                SetRelatedEntity("service_calendar_rules", null, value);
                OnPropertyChanged("service_calendar_rules");
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