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
    ///     Activity that is created automatically when an opportunity is closed, containing information such as the
    ///     description of the closing and actual revenue.
    /// </summary>
    [DataContract]
    [EntityLogicalName("opportunityclose")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class OpportunityClose : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "opportunityclose";

        public const int EntityTypeCode = 4208;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public OpportunityClose() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the opportunity close activity.
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
        ///     Actual duration of the opportunity close activity in minutes.
        /// </summary>
        [AttributeLogicalName("actualdurationminutes")]
        public int? ActualDurationMinutes
        {
            get { return GetAttributeValue<int?>("actualdurationminutes"); }
            set
            {
                OnPropertyChanging("ActualDurationMinutes");
                SetAttributeValue("actualdurationminutes", value);
                OnPropertyChanged("ActualDurationMinutes");
            }
        }

        /// <summary>
        ///     Actual end time of the opportunity close activity.
        /// </summary>
        [AttributeLogicalName("actualend")]
        public DateTime? ActualEnd
        {
            get { return GetAttributeValue<DateTime?>("actualend"); }
            set
            {
                OnPropertyChanging("ActualEnd");
                SetAttributeValue("actualend", value);
                OnPropertyChanged("ActualEnd");
            }
        }

        /// <summary>
        ///     Actual revenue generated for the opportunity.
        /// </summary>
        [AttributeLogicalName("actualrevenue")]
        public Money ActualRevenue
        {
            get { return GetAttributeValue<Money>("actualrevenue"); }
            set
            {
                OnPropertyChanging("ActualRevenue");
                SetAttributeValue("actualrevenue", value);
                OnPropertyChanged("ActualRevenue");
            }
        }

        /// <summary>
        ///     Shows the Actual Revenue field converted to the system's default base currency for reporting purposes. The
        ///     calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("actualrevenue_base")]
        public Money ActualRevenue_Base
        {
            get { return GetAttributeValue<Money>("actualrevenue_base"); }
        }

        /// <summary>
        ///     Actual start time of the opportunity close activity.
        /// </summary>
        [AttributeLogicalName("actualstart")]
        public DateTime? ActualStart
        {
            get { return GetAttributeValue<DateTime?>("actualstart"); }
            set
            {
                OnPropertyChanging("ActualStart");
                SetAttributeValue("actualstart", value);
                OnPropertyChanged("ActualStart");
            }
        }

        /// <summary>
        ///     Category of the opportunity close activity.
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
        ///     Unique identifier of the competitor with which the opportunity close activity is associated.
        /// </summary>
        [AttributeLogicalName("competitorid")]
        public EntityReference CompetitorId
        {
            get { return GetAttributeValue<EntityReference>("competitorid"); }
            set
            {
                OnPropertyChanging("CompetitorId");
                SetAttributeValue("competitorid", value);
                OnPropertyChanged("CompetitorId");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the opportunity close activity.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the opportunity close activity was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the opportunityclose.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Activity that is created automatically when an opportunity is closed, containing information such as the
        ///     description of the closing and actual revenue.
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
        ///     Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the
        ///     record from the local currency to the system's default currency.
        /// </summary>
        [AttributeLogicalName("exchangerate")]
        public decimal? ExchangeRate
        {
            get { return GetAttributeValue<decimal?>("exchangerate"); }
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
        ///     Information about whether the opportunity close activity was billed as part of resolving a case.
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
        ///     Information regarding whether the activity is a regular activity type or event type.
        /// </summary>
        [AttributeLogicalName("isregularactivity")]
        public bool? IsRegularActivity
        {
            get { return GetAttributeValue<bool?>("isregularactivity"); }
        }

        /// <summary>
        ///     Information that specifies if the opportunity close activity was created from a workflow rule.
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
        ///     Unique identifier of the user who last modified the opportunity close activity.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the opportunity close activity was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the opportunityclose.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the opportunity closed.
        /// </summary>
        [AttributeLogicalName("opportunityid")]
        public EntityReference OpportunityId
        {
            get { return GetAttributeValue<EntityReference>("opportunityid"); }
            set
            {
                OnPropertyChanging("OpportunityId");
                SetAttributeValue("opportunityid", value);
                OnPropertyChanged("OpportunityId");
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
        ///     Unique identifier of the user or team who owns the opportunity close activity.
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
        ///     Unique identifier of the business unit that owns the opportunity close activity.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the opportunity close activity.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the opportunity close activity.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Scheduled duration of the opportunity close activity, specified in minutes.
        /// </summary>
        [AttributeLogicalName("scheduleddurationminutes")]
        public int? ScheduledDurationMinutes
        {
            get { return GetAttributeValue<int?>("scheduleddurationminutes"); }
        }

        /// <summary>
        ///     Scheduled end time of the opportunity close activity.
        /// </summary>
        [AttributeLogicalName("scheduledend")]
        public DateTime? ScheduledEnd
        {
            get { return GetAttributeValue<DateTime?>("scheduledend"); }
            set
            {
                OnPropertyChanging("ScheduledEnd");
                SetAttributeValue("scheduledend", value);
                OnPropertyChanged("ScheduledEnd");
            }
        }

        /// <summary>
        ///     Scheduled start time of the opportunity close activity.
        /// </summary>
        [AttributeLogicalName("scheduledstart")]
        public DateTime? ScheduledStart
        {
            get { return GetAttributeValue<DateTime?>("scheduledstart"); }
            set
            {
                OnPropertyChanging("ScheduledStart");
                SetAttributeValue("scheduledstart", value);
                OnPropertyChanged("ScheduledStart");
            }
        }

        /// <summary>
        ///     Unique identifier of the service with which the opportunity close activity is associated.
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
        ///     Shows whether the opportunity close activity is open, completed, or canceled. By default, opportunity close
        ///     activities are completed unless the opportunity is reactivated, which updates them to canceled.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public OpportunityCloseState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((OpportunityCloseState) (Enum.ToObject(typeof (OpportunityCloseState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the opportunity close activity.
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
        ///     Subcategory of the opportunity close activity.
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
        ///     Subject associated with the opportunity close activity.
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
        ///     Version number of the opportunity close activity.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N opportunityclose_activity_parties
        /// </summary>
        [RelationshipSchemaName("opportunityclose_activity_parties")]
        public IEnumerable<ActivityParty> opportunityclose_activity_parties
        {
            get { return GetRelatedEntities<ActivityParty>("opportunityclose_activity_parties", null); }
            set
            {
                OnPropertyChanging("opportunityclose_activity_parties");
                SetRelatedEntities("opportunityclose_activity_parties", null, value);
                OnPropertyChanged("opportunityclose_activity_parties");
            }
        }

        /// <summary>
        ///     1:N OpportunityClose_Annotation
        /// </summary>
        [RelationshipSchemaName("OpportunityClose_Annotation")]
        public IEnumerable<Annotation> OpportunityClose_Annotation
        {
            get { return GetRelatedEntities<Annotation>("OpportunityClose_Annotation", null); }
            set
            {
                OnPropertyChanging("OpportunityClose_Annotation");
                SetRelatedEntities("OpportunityClose_Annotation", null, value);
                OnPropertyChanged("OpportunityClose_Annotation");
            }
        }

        /// <summary>
        ///     1:N OpportunityClose_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("OpportunityClose_AsyncOperations")]
        public IEnumerable<AsyncOperation> OpportunityClose_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("OpportunityClose_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("OpportunityClose_AsyncOperations");
                SetRelatedEntities("OpportunityClose_AsyncOperations", null, value);
                OnPropertyChanged("OpportunityClose_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N OpportunityClose_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("OpportunityClose_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> OpportunityClose_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("OpportunityClose_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("OpportunityClose_BulkDeleteFailures");
                SetRelatedEntities("OpportunityClose_BulkDeleteFailures", null, value);
                OnPropertyChanged("OpportunityClose_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_opportunityclose
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_opportunityclose")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_opportunityclose
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_opportunityclose", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_opportunityclose");
                SetRelatedEntities("userentityinstancedata_opportunityclose", null, value);
                OnPropertyChanged("userentityinstancedata_opportunityclose");
            }
        }

        /// <summary>
        ///     N:1 activity_pointer_opportunity_close
        /// </summary>
        [AttributeLogicalName("activityid")]
        [RelationshipSchemaName("activity_pointer_opportunity_close")]
        public ActivityPointer activity_pointer_opportunity_close
        {
            get { return GetRelatedEntity<ActivityPointer>("activity_pointer_opportunity_close", null); }
            set
            {
                OnPropertyChanging("activity_pointer_opportunity_close");
                SetRelatedEntity("activity_pointer_opportunity_close", null, value);
                OnPropertyChanged("activity_pointer_opportunity_close");
            }
        }

        /// <summary>
        ///     N:1 business_unit_opportunity_close_activities
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_opportunity_close_activities")]
        public BusinessUnit business_unit_opportunity_close_activities
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_opportunity_close_activities", null); }
        }

        /// <summary>
        ///     N:1 competitor_opportunity_activities
        /// </summary>
        [AttributeLogicalName("competitorid")]
        [RelationshipSchemaName("competitor_opportunity_activities")]
        public Competitor competitor_opportunity_activities
        {
            get { return GetRelatedEntity<Competitor>("competitor_opportunity_activities", null); }
            set
            {
                OnPropertyChanging("competitor_opportunity_activities");
                SetRelatedEntity("competitor_opportunity_activities", null, value);
                OnPropertyChanged("competitor_opportunity_activities");
            }
        }

        /// <summary>
        ///     N:1 lk_opportunityclose_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_opportunityclose_createdby")]
        public SystemUser lk_opportunityclose_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_opportunityclose_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_opportunityclose_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_opportunityclose_createdonbehalfby")]
        public SystemUser lk_opportunityclose_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_opportunityclose_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_opportunityclose_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_opportunityclose_modifiedby")]
        public SystemUser lk_opportunityclose_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_opportunityclose_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_opportunityclose_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_opportunityclose_modifiedonbehalfby")]
        public SystemUser lk_opportunityclose_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_opportunityclose_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 Opportunity_OpportunityClose
        /// </summary>
        [AttributeLogicalName("opportunityid")]
        [RelationshipSchemaName("Opportunity_OpportunityClose")]
        public Opportunity Opportunity_OpportunityClose
        {
            get { return GetRelatedEntity<Opportunity>("Opportunity_OpportunityClose", null); }
            set
            {
                OnPropertyChanging("Opportunity_OpportunityClose");
                SetRelatedEntity("Opportunity_OpportunityClose", null, value);
                OnPropertyChanged("Opportunity_OpportunityClose");
            }
        }

        /// <summary>
        ///     N:1 service_opportunityclose
        /// </summary>
        [AttributeLogicalName("serviceid")]
        [RelationshipSchemaName("service_opportunityclose")]
        public Service service_opportunityclose
        {
            get { return GetRelatedEntity<Service>("service_opportunityclose", null); }
            set
            {
                OnPropertyChanging("service_opportunityclose");
                SetRelatedEntity("service_opportunityclose", null, value);
                OnPropertyChanged("service_opportunityclose");
            }
        }

        /// <summary>
        ///     N:1 team_opportunityclose
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_opportunityclose")]
        public Team team_opportunityclose
        {
            get { return GetRelatedEntity<Team>("team_opportunityclose", null); }
        }

        /// <summary>
        ///     N:1 transactioncurrency_opportunityclose
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("transactioncurrency_opportunityclose")]
        public TransactionCurrency transactioncurrency_opportunityclose
        {
            get { return GetRelatedEntity<TransactionCurrency>("transactioncurrency_opportunityclose", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_opportunityclose");
                SetRelatedEntity("transactioncurrency_opportunityclose", null, value);
                OnPropertyChanged("transactioncurrency_opportunityclose");
            }
        }

        /// <summary>
        ///     N:1 user_opportunityclose
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_opportunityclose")]
        public SystemUser user_opportunityclose
        {
            get { return GetRelatedEntity<SystemUser>("user_opportunityclose", null); }
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