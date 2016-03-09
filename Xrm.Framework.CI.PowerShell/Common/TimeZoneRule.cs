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
    ///     Definition for time conversion between local time and Coordinated Universal Time (UTC) for a particular time zone
    ///     at a particular time period.
    /// </summary>
    [DataContract]
    [EntityLogicalName("timezonerule")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class TimeZoneRule : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "timezonerule";

        public const int EntityTypeCode = 4811;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public TimeZoneRule() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Base time bias of the time zone rule.
        /// </summary>
        [AttributeLogicalName("bias")]
        public int? Bias
        {
            get { return GetAttributeValue<int?>("bias"); }
            set
            {
                OnPropertyChanging("Bias");
                SetAttributeValue("bias", value);
                OnPropertyChanged("Bias");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the time zone rule.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the time zone rule was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the timezonerule.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Time bias in addition to the base bias for daylight savings time.
        /// </summary>
        [AttributeLogicalName("daylightbias")]
        public int? DaylightBias
        {
            get { return GetAttributeValue<int?>("daylightbias"); }
            set
            {
                OnPropertyChanging("DaylightBias");
                SetAttributeValue("daylightbias", value);
                OnPropertyChanged("DaylightBias");
            }
        }

        /// <summary>
        ///     Day of the month when daylight savings time starts.
        /// </summary>
        [AttributeLogicalName("daylightday")]
        public int? DaylightDay
        {
            get { return GetAttributeValue<int?>("daylightday"); }
            set
            {
                OnPropertyChanging("DaylightDay");
                SetAttributeValue("daylightday", value);
                OnPropertyChanged("DaylightDay");
            }
        }

        /// <summary>
        ///     Day of the week when daylight savings time starts.
        /// </summary>
        [AttributeLogicalName("daylightdayofweek")]
        public int? DaylightDayOfWeek
        {
            get { return GetAttributeValue<int?>("daylightdayofweek"); }
            set
            {
                OnPropertyChanging("DaylightDayOfWeek");
                SetAttributeValue("daylightdayofweek", value);
                OnPropertyChanged("DaylightDayOfWeek");
            }
        }

        /// <summary>
        ///     Hour of the day when daylight savings time starts
        /// </summary>
        [AttributeLogicalName("daylighthour")]
        public int? DaylightHour
        {
            get { return GetAttributeValue<int?>("daylighthour"); }
            set
            {
                OnPropertyChanging("DaylightHour");
                SetAttributeValue("daylighthour", value);
                OnPropertyChanged("DaylightHour");
            }
        }

        /// <summary>
        ///     Minute of the hour when daylight savings time starts.
        /// </summary>
        [AttributeLogicalName("daylightminute")]
        public int? DaylightMinute
        {
            get { return GetAttributeValue<int?>("daylightminute"); }
            set
            {
                OnPropertyChanging("DaylightMinute");
                SetAttributeValue("daylightminute", value);
                OnPropertyChanged("DaylightMinute");
            }
        }

        /// <summary>
        ///     Month when daylight savings time starts.
        /// </summary>
        [AttributeLogicalName("daylightmonth")]
        public int? DaylightMonth
        {
            get { return GetAttributeValue<int?>("daylightmonth"); }
            set
            {
                OnPropertyChanging("DaylightMonth");
                SetAttributeValue("daylightmonth", value);
                OnPropertyChanged("DaylightMonth");
            }
        }

        /// <summary>
        ///     Second of the minute when daylight savings time starts
        /// </summary>
        [AttributeLogicalName("daylightsecond")]
        public int? DaylightSecond
        {
            get { return GetAttributeValue<int?>("daylightsecond"); }
            set
            {
                OnPropertyChanging("DaylightSecond");
                SetAttributeValue("daylightsecond", value);
                OnPropertyChanged("DaylightSecond");
            }
        }

        /// <summary>
        ///     Year when daylight savings times starts.
        /// </summary>
        [AttributeLogicalName("daylightyear")]
        public int? DaylightYear
        {
            get { return GetAttributeValue<int?>("daylightyear"); }
            set
            {
                OnPropertyChanging("DaylightYear");
                SetAttributeValue("daylightyear", value);
                OnPropertyChanged("DaylightYear");
            }
        }

        /// <summary>
        ///     Time that this rule takes effect, in local time.
        /// </summary>
        [AttributeLogicalName("effectivedatetime")]
        public DateTime? EffectiveDateTime
        {
            get { return GetAttributeValue<DateTime?>("effectivedatetime"); }
            set
            {
                OnPropertyChanging("EffectiveDateTime");
                SetAttributeValue("effectivedatetime", value);
                OnPropertyChanged("EffectiveDateTime");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the time zone rule.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the time zone rule was modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the timezonerule.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the organization associated with the time zone rule.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     Time bias in addition to the base bias for standard time.
        /// </summary>
        [AttributeLogicalName("standardbias")]
        public int? StandardBias
        {
            get { return GetAttributeValue<int?>("standardbias"); }
            set
            {
                OnPropertyChanging("StandardBias");
                SetAttributeValue("standardbias", value);
                OnPropertyChanged("StandardBias");
            }
        }

        /// <summary>
        ///     Day of the month when standard time starts.
        /// </summary>
        [AttributeLogicalName("standardday")]
        public int? StandardDay
        {
            get { return GetAttributeValue<int?>("standardday"); }
            set
            {
                OnPropertyChanging("StandardDay");
                SetAttributeValue("standardday", value);
                OnPropertyChanged("StandardDay");
            }
        }

        /// <summary>
        ///     Day of the week when standard time starts.
        /// </summary>
        [AttributeLogicalName("standarddayofweek")]
        public int? StandardDayOfWeek
        {
            get { return GetAttributeValue<int?>("standarddayofweek"); }
            set
            {
                OnPropertyChanging("StandardDayOfWeek");
                SetAttributeValue("standarddayofweek", value);
                OnPropertyChanged("StandardDayOfWeek");
            }
        }

        /// <summary>
        ///     Hour of the day when standard time starts.
        /// </summary>
        [AttributeLogicalName("standardhour")]
        public int? StandardHour
        {
            get { return GetAttributeValue<int?>("standardhour"); }
            set
            {
                OnPropertyChanging("StandardHour");
                SetAttributeValue("standardhour", value);
                OnPropertyChanged("StandardHour");
            }
        }

        /// <summary>
        ///     Minute of the hour when standard time starts.
        /// </summary>
        [AttributeLogicalName("standardminute")]
        public int? StandardMinute
        {
            get { return GetAttributeValue<int?>("standardminute"); }
            set
            {
                OnPropertyChanging("StandardMinute");
                SetAttributeValue("standardminute", value);
                OnPropertyChanged("StandardMinute");
            }
        }

        /// <summary>
        ///     Month when standard time starts.
        /// </summary>
        [AttributeLogicalName("standardmonth")]
        public int? StandardMonth
        {
            get { return GetAttributeValue<int?>("standardmonth"); }
            set
            {
                OnPropertyChanging("StandardMonth");
                SetAttributeValue("standardmonth", value);
                OnPropertyChanged("StandardMonth");
            }
        }

        /// <summary>
        ///     Second of the Minute when standard time starts.
        /// </summary>
        [AttributeLogicalName("standardsecond")]
        public int? StandardSecond
        {
            get { return GetAttributeValue<int?>("standardsecond"); }
            set
            {
                OnPropertyChanging("StandardSecond");
                SetAttributeValue("standardsecond", value);
                OnPropertyChanged("StandardSecond");
            }
        }

        /// <summary>
        ///     Year when standard time starts.
        /// </summary>
        [AttributeLogicalName("standardyear")]
        public int? StandardYear
        {
            get { return GetAttributeValue<int?>("standardyear"); }
            set
            {
                OnPropertyChanging("StandardYear");
                SetAttributeValue("standardyear", value);
                OnPropertyChanged("StandardYear");
            }
        }

        /// <summary>
        ///     Unique identifier of the time zone definition.
        /// </summary>
        [AttributeLogicalName("timezonedefinitionid")]
        public EntityReference TimeZoneDefinitionId
        {
            get { return GetAttributeValue<EntityReference>("timezonedefinitionid"); }
            set
            {
                OnPropertyChanging("TimeZoneDefinitionId");
                SetAttributeValue("timezonedefinitionid", value);
                OnPropertyChanged("TimeZoneDefinitionId");
            }
        }

        /// <summary>
        ///     Unique identifier of the time zone rule.
        /// </summary>
        [AttributeLogicalName("timezoneruleid")]
        public Guid? TimeZoneRuleId
        {
            get { return GetAttributeValue<Guid?>("timezoneruleid"); }
            set
            {
                OnPropertyChanging("TimeZoneRuleId");
                SetAttributeValue("timezoneruleid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("TimeZoneRuleId");
            }
        }

        [AttributeLogicalName("timezoneruleid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { TimeZoneRuleId = value; }
        }

        /// <summary>
        ///     For internal use only
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
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N userentityinstancedata_timezonerule
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_timezonerule")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_timezonerule
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_timezonerule", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_timezonerule");
                SetRelatedEntities("userentityinstancedata_timezonerule", null, value);
                OnPropertyChanged("userentityinstancedata_timezonerule");
            }
        }

        /// <summary>
        ///     N:1 lk_timezonerule_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_timezonerule_createdby")]
        public SystemUser lk_timezonerule_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_timezonerule_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_timezonerule_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_timezonerule_createdonbehalfby")]
        public SystemUser lk_timezonerule_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_timezonerule_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_timezonerule_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_timezonerule_modifiedby")]
        public SystemUser lk_timezonerule_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_timezonerule_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_timezonerule_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_timezonerule_modifiedonbehalfby")]
        public SystemUser lk_timezonerule_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_timezonerule_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_timezonerule_timezonedefinitionid
        /// </summary>
        [AttributeLogicalName("timezonedefinitionid")]
        [RelationshipSchemaName("lk_timezonerule_timezonedefinitionid")]
        public TimeZoneDefinition lk_timezonerule_timezonedefinitionid
        {
            get { return GetRelatedEntity<TimeZoneDefinition>("lk_timezonerule_timezonedefinitionid", null); }
            set
            {
                OnPropertyChanging("lk_timezonerule_timezonedefinitionid");
                SetRelatedEntity("lk_timezonerule_timezonedefinitionid", null, value);
                OnPropertyChanged("lk_timezonerule_timezonedefinitionid");
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