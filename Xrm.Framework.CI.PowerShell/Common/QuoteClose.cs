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
    ///     Activity generated when a quote is closed.
    /// </summary>
    [DataContract]
    [EntityLogicalName("quoteclose")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class QuoteClose : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "quoteclose";

        public const int EntityTypeCode = 4211;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public QuoteClose() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the quote close activity.
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
        ///     Actual duration of the quote close activity in minutes.
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
        ///     Actual end time of the quote close activity.
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
        ///     Actual start time of the quote close activity.
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
        ///     Category of the quote close activity.
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
        ///     Unique identifier of the user who created the quote close activity.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the quote close activity was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the quoteclose.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Activity generated when a quote is closed.
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
        ///     Information about whether the quote close activity was billed as part of resolving a case.
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
        ///     Information that specifies if the quote close activity was created from a workflow rule.
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
        ///     Unique identifier of the user who last modified the quote close activity.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the quote close activity was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the quoteclose.
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
        ///     Unique identifier of the user or team who owns the quote close activity.
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
        ///     Unique identifier of the business unit that owns the quote close activity.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the quote close activity.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the quote close activity.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Unique identifier of the quote with which the quote close activity is associated.
        /// </summary>
        [AttributeLogicalName("quoteid")]
        public EntityReference QuoteId
        {
            get { return GetAttributeValue<EntityReference>("quoteid"); }
            set
            {
                OnPropertyChanging("QuoteId");
                SetAttributeValue("quoteid", value);
                OnPropertyChanged("QuoteId");
            }
        }

        /// <summary>
        ///     Quote number.
        /// </summary>
        [AttributeLogicalName("quotenumber")]
        public string QuoteNumber
        {
            get { return GetAttributeValue<string>("quotenumber"); }
            set
            {
                OnPropertyChanging("QuoteNumber");
                SetAttributeValue("quotenumber", value);
                OnPropertyChanged("QuoteNumber");
            }
        }

        /// <summary>
        ///     Quote revision number.
        /// </summary>
        [AttributeLogicalName("revision")]
        public int? Revision
        {
            get { return GetAttributeValue<int?>("revision"); }
            set
            {
                OnPropertyChanging("Revision");
                SetAttributeValue("revision", value);
                OnPropertyChanged("Revision");
            }
        }

        /// <summary>
        ///     Scheduled duration of the quote close activity, specified in minutes.
        /// </summary>
        [AttributeLogicalName("scheduleddurationminutes")]
        public int? ScheduledDurationMinutes
        {
            get { return GetAttributeValue<int?>("scheduleddurationminutes"); }
        }

        /// <summary>
        ///     Scheduled end time of the quote close activity.
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
        ///     Scheduled start time of the quote close activity.
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
        ///     Unique identifier of the service with which the quote close activity is associated.
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
        ///     Shows whether the quote close activity is open, completed, or canceled. By default, quote close activities are
        ///     completed.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public QuoteCloseState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((QuoteCloseState) (Enum.ToObject(typeof (QuoteCloseState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the quote close activity.
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
        ///     Subcategory of the quote close activity.
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
        ///     Subject associated with the quote close activity.
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
        ///     Version number of the quote close activity.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N quoteclose_activity_parties
        /// </summary>
        [RelationshipSchemaName("quoteclose_activity_parties")]
        public IEnumerable<ActivityParty> quoteclose_activity_parties
        {
            get { return GetRelatedEntities<ActivityParty>("quoteclose_activity_parties", null); }
            set
            {
                OnPropertyChanging("quoteclose_activity_parties");
                SetRelatedEntities("quoteclose_activity_parties", null, value);
                OnPropertyChanged("quoteclose_activity_parties");
            }
        }

        /// <summary>
        ///     1:N QuoteClose_Annotation
        /// </summary>
        [RelationshipSchemaName("QuoteClose_Annotation")]
        public IEnumerable<Annotation> QuoteClose_Annotation
        {
            get { return GetRelatedEntities<Annotation>("QuoteClose_Annotation", null); }
            set
            {
                OnPropertyChanging("QuoteClose_Annotation");
                SetRelatedEntities("QuoteClose_Annotation", null, value);
                OnPropertyChanged("QuoteClose_Annotation");
            }
        }

        /// <summary>
        ///     1:N QuoteClose_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("QuoteClose_AsyncOperations")]
        public IEnumerable<AsyncOperation> QuoteClose_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("QuoteClose_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("QuoteClose_AsyncOperations");
                SetRelatedEntities("QuoteClose_AsyncOperations", null, value);
                OnPropertyChanged("QuoteClose_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N QuoteClose_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("QuoteClose_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> QuoteClose_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("QuoteClose_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("QuoteClose_BulkDeleteFailures");
                SetRelatedEntities("QuoteClose_BulkDeleteFailures", null, value);
                OnPropertyChanged("QuoteClose_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_quoteclose
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_quoteclose")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_quoteclose
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_quoteclose", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_quoteclose");
                SetRelatedEntities("userentityinstancedata_quoteclose", null, value);
                OnPropertyChanged("userentityinstancedata_quoteclose");
            }
        }

        /// <summary>
        ///     N:1 activity_pointer_quote_close
        /// </summary>
        [AttributeLogicalName("activityid")]
        [RelationshipSchemaName("activity_pointer_quote_close")]
        public ActivityPointer activity_pointer_quote_close
        {
            get { return GetRelatedEntity<ActivityPointer>("activity_pointer_quote_close", null); }
            set
            {
                OnPropertyChanging("activity_pointer_quote_close");
                SetRelatedEntity("activity_pointer_quote_close", null, value);
                OnPropertyChanged("activity_pointer_quote_close");
            }
        }

        /// <summary>
        ///     N:1 business_unit_quote_close_activities
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_quote_close_activities")]
        public BusinessUnit business_unit_quote_close_activities
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_quote_close_activities", null); }
        }

        /// <summary>
        ///     N:1 lk_quoteclose_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_quoteclose_createdby")]
        public SystemUser lk_quoteclose_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_quoteclose_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_quoteclose_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_quoteclose_createdonbehalfby")]
        public SystemUser lk_quoteclose_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_quoteclose_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_quoteclose_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_quoteclose_modifiedby")]
        public SystemUser lk_quoteclose_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_quoteclose_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_quoteclose_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_quoteclose_modifiedonbehalfby")]
        public SystemUser lk_quoteclose_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_quoteclose_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 Quote_QuoteClose
        /// </summary>
        [AttributeLogicalName("quoteid")]
        [RelationshipSchemaName("Quote_QuoteClose")]
        public Quote Quote_QuoteClose
        {
            get { return GetRelatedEntity<Quote>("Quote_QuoteClose", null); }
            set
            {
                OnPropertyChanging("Quote_QuoteClose");
                SetRelatedEntity("Quote_QuoteClose", null, value);
                OnPropertyChanged("Quote_QuoteClose");
            }
        }

        /// <summary>
        ///     N:1 service_quoteclose
        /// </summary>
        [AttributeLogicalName("serviceid")]
        [RelationshipSchemaName("service_quoteclose")]
        public Service service_quoteclose
        {
            get { return GetRelatedEntity<Service>("service_quoteclose", null); }
            set
            {
                OnPropertyChanging("service_quoteclose");
                SetRelatedEntity("service_quoteclose", null, value);
                OnPropertyChanged("service_quoteclose");
            }
        }

        /// <summary>
        ///     N:1 team_quoteclose
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_quoteclose")]
        public Team team_quoteclose
        {
            get { return GetRelatedEntity<Team>("team_quoteclose", null); }
        }

        /// <summary>
        ///     N:1 user_quoteclose
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_quoteclose")]
        public SystemUser user_quoteclose
        {
            get { return GetRelatedEntity<SystemUser>("user_quoteclose", null); }
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