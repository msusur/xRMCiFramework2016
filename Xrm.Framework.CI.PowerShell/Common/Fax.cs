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
    ///     Activity that tracks call outcome and number of pages for a fax and optionally stores an electronic copy of the
    ///     document.
    /// </summary>
    [DataContract]
    [EntityLogicalName("fax")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Fax : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "fax";

        public const int EntityTypeCode = 4204;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Fax() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the fax activity.
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
        ///     Type the number of minutes spent creating and sending the fax. The duration is used in reporting.
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
        ///     Enter the actual end date and time of the fax. By default, it displays the date and time when the activity was
        ///     completed or canceled, but can be edited to capture the actual time to create and send the fax.
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
        ///     Enter the actual start date and time for the fax. By default, it displays the date and time when the activity was
        ///     created, but can be edited to capture the actual time to create and send the fax.
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
        ///     Type the billing code for the fax to make sure the fax is charged to the correct sender or customer account.
        /// </summary>
        [AttributeLogicalName("billingcode")]
        public string BillingCode
        {
            get { return GetAttributeValue<string>("billingcode"); }
            set
            {
                OnPropertyChanging("BillingCode");
                SetAttributeValue("billingcode", value);
                OnPropertyChanged("BillingCode");
            }
        }

        /// <summary>
        ///     Type a category to identify the fax type, such as sales offer or press release, to tie the fax to a business group
        ///     or function.
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
        ///     Type the name of the cover page to use when sending the fax.
        /// </summary>
        [AttributeLogicalName("coverpagename")]
        public string CoverPageName
        {
            get { return GetAttributeValue<string>("coverpagename"); }
            set
            {
                OnPropertyChanging("CoverPageName");
                SetAttributeValue("coverpagename", value);
                OnPropertyChanged("CoverPageName");
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
        ///     Type additional information to describe the fax, such as the primary message or the products and services featured.
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
        ///     Select the direction of the fax as incoming or outbound.
        /// </summary>
        [AttributeLogicalName("directioncode")]
        public bool? DirectionCode
        {
            get { return GetAttributeValue<bool?>("directioncode"); }
            set
            {
                OnPropertyChanging("DirectionCode");
                SetAttributeValue("directioncode", value);
                OnPropertyChanged("DirectionCode");
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
        ///     Type the recipient's fax number.
        /// </summary>
        [AttributeLogicalName("faxnumber")]
        public string FaxNumber
        {
            get { return GetAttributeValue<string>("faxnumber"); }
            set
            {
                OnPropertyChanging("FaxNumber");
                SetAttributeValue("faxnumber", value);
                OnPropertyChanged("FaxNumber");
            }
        }

        /// <summary>
        ///     Enter the account, contact, lead, queue, or user who sent the fax.
        /// </summary>
        [AttributeLogicalName("from")]
        public IEnumerable<ActivityParty> From
        {
            get
            {
                var collection = GetAttributeValue<EntityCollection>("from");
                if (((collection != null)
                     && (collection.Entities != null)))
                {
                    return Enumerable.Cast<ActivityParty>(collection.Entities);
                }
                return null;
            }
            set
            {
                OnPropertyChanging("From");
                if ((value == null))
                {
                    SetAttributeValue("from", value);
                }
                else
                {
                    SetAttributeValue("from", new EntityCollection(new List<Entity>(value)));
                }
                OnPropertyChanged("From");
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
        ///     Information regarding whether the fax activity was billed as part of resolving a case.
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
        ///     Indication of whether the fax activity was created by a workflow rule.
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
        ///     Type the number of pages included in the fax.
        /// </summary>
        [AttributeLogicalName("numberofpages")]
        public int? NumberOfPages
        {
            get { return GetAttributeValue<int?>("numberofpages"); }
            set
            {
                OnPropertyChanging("NumberOfPages");
                SetAttributeValue("numberofpages", value);
                OnPropertyChanged("NumberOfPages");
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
        ///     Unique identifier of the business unit that owns the fax activity.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team that owns the fax activity.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user that owns the fax activity.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
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
        ///     Unique identifier of the object with which the fax activity is associated.
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
        ///     Shows the expected duration of the fax activity, in minutes.
        /// </summary>
        [AttributeLogicalName("scheduleddurationminutes")]
        public int? ScheduledDurationMinutes
        {
            get { return GetAttributeValue<int?>("scheduleddurationminutes"); }
        }

        /// <summary>
        ///     Enter the expected due date and time.
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
        ///     Enter the expected due date and time.
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
        ///     Shows whether the fax activity is open, completed, or canceled. Completed and canceled fax activities are read-only
        ///     and can't be edited.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public FaxState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((FaxState) (Enum.ToObject(typeof (FaxState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Select the fax's status.
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
        ///     Type a subcategory to identify the fax type to relate the activity to a specific product, sales region, business
        ///     group, or other function.
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
        ///     Type a short description about the objective or primary topic of the fax.
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
        ///     Enter the account, contact, lead, queue, or user recipients for the fax.
        /// </summary>
        [AttributeLogicalName("to")]
        public IEnumerable<ActivityParty> To
        {
            get
            {
                var collection = GetAttributeValue<EntityCollection>("to");
                if (((collection != null)
                     && (collection.Entities != null)))
                {
                    return Enumerable.Cast<ActivityParty>(collection.Entities);
                }
                return null;
            }
            set
            {
                OnPropertyChanging("To");
                if ((value == null))
                {
                    SetAttributeValue("to", value);
                }
                else
                {
                    SetAttributeValue("to", new EntityCollection(new List<Entity>(value)));
                }
                OnPropertyChanged("To");
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
        ///     Type the Transmitting Subscriber ID (TSID) associated with a send action. This is typically a combination of the
        ///     recipient's fax or phone number and company name.
        /// </summary>
        [AttributeLogicalName("tsid")]
        public string Tsid
        {
            get { return GetAttributeValue<string>("tsid"); }
            set
            {
                OnPropertyChanging("Tsid");
                SetAttributeValue("tsid", value);
                OnPropertyChanged("Tsid");
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
        ///     Version number of the fax.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N fax_activity_parties
        /// </summary>
        [RelationshipSchemaName("fax_activity_parties")]
        public IEnumerable<ActivityParty> fax_activity_parties
        {
            get { return GetRelatedEntities<ActivityParty>("fax_activity_parties", null); }
            set
            {
                OnPropertyChanging("fax_activity_parties");
                SetRelatedEntities("fax_activity_parties", null, value);
                OnPropertyChanged("fax_activity_parties");
            }
        }

        /// <summary>
        ///     1:N Fax_Annotation
        /// </summary>
        [RelationshipSchemaName("Fax_Annotation")]
        public IEnumerable<Annotation> Fax_Annotation
        {
            get { return GetRelatedEntities<Annotation>("Fax_Annotation", null); }
            set
            {
                OnPropertyChanging("Fax_Annotation");
                SetRelatedEntities("Fax_Annotation", null, value);
                OnPropertyChanged("Fax_Annotation");
            }
        }

        /// <summary>
        ///     1:N Fax_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Fax_AsyncOperations")]
        public IEnumerable<AsyncOperation> Fax_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Fax_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Fax_AsyncOperations");
                SetRelatedEntities("Fax_AsyncOperations", null, value);
                OnPropertyChanged("Fax_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N Fax_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("Fax_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> Fax_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("Fax_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("Fax_BulkDeleteFailures");
                SetRelatedEntities("Fax_BulkDeleteFailures", null, value);
                OnPropertyChanged("Fax_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N fax_campaignresponse
        /// </summary>
        [RelationshipSchemaName("fax_campaignresponse")]
        public IEnumerable<CampaignResponse> fax_campaignresponse
        {
            get { return GetRelatedEntities<CampaignResponse>("fax_campaignresponse", null); }
            set
            {
                OnPropertyChanging("fax_campaignresponse");
                SetRelatedEntities("fax_campaignresponse", null, value);
                OnPropertyChanged("fax_campaignresponse");
            }
        }

        /// <summary>
        ///     1:N fax_connections1
        /// </summary>
        [RelationshipSchemaName("fax_connections1")]
        public IEnumerable<Connection> fax_connections1
        {
            get { return GetRelatedEntities<Connection>("fax_connections1", null); }
            set
            {
                OnPropertyChanging("fax_connections1");
                SetRelatedEntities("fax_connections1", null, value);
                OnPropertyChanged("fax_connections1");
            }
        }

        /// <summary>
        ///     1:N fax_connections2
        /// </summary>
        [RelationshipSchemaName("fax_connections2")]
        public IEnumerable<Connection> fax_connections2
        {
            get { return GetRelatedEntities<Connection>("fax_connections2", null); }
            set
            {
                OnPropertyChanging("fax_connections2");
                SetRelatedEntities("fax_connections2", null, value);
                OnPropertyChanged("fax_connections2");
            }
        }

        /// <summary>
        ///     1:N Fax_DuplicateBaseRecord
        /// </summary>
        [RelationshipSchemaName("Fax_DuplicateBaseRecord")]
        public IEnumerable<DuplicateRecord> Fax_DuplicateBaseRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Fax_DuplicateBaseRecord", null); }
            set
            {
                OnPropertyChanging("Fax_DuplicateBaseRecord");
                SetRelatedEntities("Fax_DuplicateBaseRecord", null, value);
                OnPropertyChanged("Fax_DuplicateBaseRecord");
            }
        }

        /// <summary>
        ///     1:N Fax_DuplicateMatchingRecord
        /// </summary>
        [RelationshipSchemaName("Fax_DuplicateMatchingRecord")]
        public IEnumerable<DuplicateRecord> Fax_DuplicateMatchingRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Fax_DuplicateMatchingRecord", null); }
            set
            {
                OnPropertyChanging("Fax_DuplicateMatchingRecord");
                SetRelatedEntities("Fax_DuplicateMatchingRecord", null, value);
                OnPropertyChanged("Fax_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        ///     1:N fax_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("fax_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> fax_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntities<PrincipalObjectAttributeAccess>("fax_principalobjectattributeaccess", null);
            }
            set
            {
                OnPropertyChanging("fax_principalobjectattributeaccess");
                SetRelatedEntities("fax_principalobjectattributeaccess", null, value);
                OnPropertyChanged("fax_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N Fax_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("Fax_ProcessSessions")]
        public IEnumerable<ProcessSession> Fax_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("Fax_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Fax_ProcessSessions");
                SetRelatedEntities("Fax_ProcessSessions", null, value);
                OnPropertyChanged("Fax_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N Fax_QueueItem
        /// </summary>
        [RelationshipSchemaName("Fax_QueueItem")]
        public IEnumerable<QueueItem> Fax_QueueItem
        {
            get { return GetRelatedEntities<QueueItem>("Fax_QueueItem", null); }
            set
            {
                OnPropertyChanging("Fax_QueueItem");
                SetRelatedEntities("Fax_QueueItem", null, value);
                OnPropertyChanged("Fax_QueueItem");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_fax
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_fax")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_fax
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_fax", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_fax");
                SetRelatedEntities("userentityinstancedata_fax", null, value);
                OnPropertyChanged("userentityinstancedata_fax");
            }
        }

        /// <summary>
        ///     N:1 Account_Faxes
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Account_Faxes")]
        public Account Account_Faxes
        {
            get { return GetRelatedEntity<Account>("Account_Faxes", null); }
            set
            {
                OnPropertyChanging("Account_Faxes");
                SetRelatedEntity("Account_Faxes", null, value);
                OnPropertyChanged("Account_Faxes");
            }
        }

        /// <summary>
        ///     N:1 activity_pointer_fax
        /// </summary>
        [AttributeLogicalName("activityid")]
        [RelationshipSchemaName("activity_pointer_fax")]
        public ActivityPointer activity_pointer_fax
        {
            get { return GetRelatedEntity<ActivityPointer>("activity_pointer_fax", null); }
            set
            {
                OnPropertyChanging("activity_pointer_fax");
                SetRelatedEntity("activity_pointer_fax", null, value);
                OnPropertyChanged("activity_pointer_fax");
            }
        }

        /// <summary>
        ///     N:1 BulkOperation_Faxes
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("BulkOperation_Faxes")]
        public BulkOperation BulkOperation_Faxes
        {
            get { return GetRelatedEntity<BulkOperation>("BulkOperation_Faxes", null); }
            set
            {
                OnPropertyChanging("BulkOperation_Faxes");
                SetRelatedEntity("BulkOperation_Faxes", null, value);
                OnPropertyChanged("BulkOperation_Faxes");
            }
        }

        /// <summary>
        ///     N:1 business_unit_fax_activities
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_fax_activities")]
        public BusinessUnit business_unit_fax_activities
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_fax_activities", null); }
        }

        /// <summary>
        ///     N:1 Campaign_Faxes
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Campaign_Faxes")]
        public Campaign Campaign_Faxes
        {
            get { return GetRelatedEntity<Campaign>("Campaign_Faxes", null); }
            set
            {
                OnPropertyChanging("Campaign_Faxes");
                SetRelatedEntity("Campaign_Faxes", null, value);
                OnPropertyChanged("Campaign_Faxes");
            }
        }

        /// <summary>
        ///     N:1 CampaignActivity_Faxes
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("CampaignActivity_Faxes")]
        public CampaignActivity CampaignActivity_Faxes
        {
            get { return GetRelatedEntity<CampaignActivity>("CampaignActivity_Faxes", null); }
            set
            {
                OnPropertyChanging("CampaignActivity_Faxes");
                SetRelatedEntity("CampaignActivity_Faxes", null, value);
                OnPropertyChanged("CampaignActivity_Faxes");
            }
        }

        /// <summary>
        ///     N:1 Contact_Faxes
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Contact_Faxes")]
        public Contact Contact_Faxes
        {
            get { return GetRelatedEntity<Contact>("Contact_Faxes", null); }
            set
            {
                OnPropertyChanging("Contact_Faxes");
                SetRelatedEntity("Contact_Faxes", null, value);
                OnPropertyChanged("Contact_Faxes");
            }
        }

        /// <summary>
        ///     N:1 Contract_Faxes
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Contract_Faxes")]
        public Contract Contract_Faxes
        {
            get { return GetRelatedEntity<Contract>("Contract_Faxes", null); }
            set
            {
                OnPropertyChanging("Contract_Faxes");
                SetRelatedEntity("Contract_Faxes", null, value);
                OnPropertyChanged("Contract_Faxes");
            }
        }

        /// <summary>
        ///     N:1 Incident_Faxes
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Incident_Faxes")]
        public Incident Incident_Faxes
        {
            get { return GetRelatedEntity<Incident>("Incident_Faxes", null); }
            set
            {
                OnPropertyChanging("Incident_Faxes");
                SetRelatedEntity("Incident_Faxes", null, value);
                OnPropertyChanged("Incident_Faxes");
            }
        }

        /// <summary>
        ///     N:1 Invoice_Faxes
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Invoice_Faxes")]
        public Invoice Invoice_Faxes
        {
            get { return GetRelatedEntity<Invoice>("Invoice_Faxes", null); }
            set
            {
                OnPropertyChanging("Invoice_Faxes");
                SetRelatedEntity("Invoice_Faxes", null, value);
                OnPropertyChanged("Invoice_Faxes");
            }
        }

        /// <summary>
        ///     N:1 Lead_Faxes
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Lead_Faxes")]
        public Lead Lead_Faxes
        {
            get { return GetRelatedEntity<Lead>("Lead_Faxes", null); }
            set
            {
                OnPropertyChanging("Lead_Faxes");
                SetRelatedEntity("Lead_Faxes", null, value);
                OnPropertyChanged("Lead_Faxes");
            }
        }

        /// <summary>
        ///     N:1 lk_fax_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_fax_createdby")]
        public SystemUser lk_fax_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_fax_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_fax_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_fax_createdonbehalfby")]
        public SystemUser lk_fax_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_fax_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_fax_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_fax_modifiedby")]
        public SystemUser lk_fax_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_fax_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_fax_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_fax_modifiedonbehalfby")]
        public SystemUser lk_fax_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_fax_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 msdyn_postalbum_Faxes
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("msdyn_postalbum_Faxes")]
        public msdyn_PostAlbum msdyn_postalbum_Faxes
        {
            get { return GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_Faxes", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_Faxes");
                SetRelatedEntity("msdyn_postalbum_Faxes", null, value);
                OnPropertyChanged("msdyn_postalbum_Faxes");
            }
        }

        /// <summary>
        ///     N:1 Opportunity_Faxes
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Opportunity_Faxes")]
        public Opportunity Opportunity_Faxes
        {
            get { return GetRelatedEntity<Opportunity>("Opportunity_Faxes", null); }
            set
            {
                OnPropertyChanging("Opportunity_Faxes");
                SetRelatedEntity("Opportunity_Faxes", null, value);
                OnPropertyChanged("Opportunity_Faxes");
            }
        }

        /// <summary>
        ///     N:1 processstage_faxes
        /// </summary>
        [AttributeLogicalName("stageid")]
        [RelationshipSchemaName("processstage_faxes")]
        public ProcessStage processstage_faxes
        {
            get { return GetRelatedEntity<ProcessStage>("processstage_faxes", null); }
            set
            {
                OnPropertyChanging("processstage_faxes");
                SetRelatedEntity("processstage_faxes", null, value);
                OnPropertyChanged("processstage_faxes");
            }
        }

        /// <summary>
        ///     N:1 Quote_Faxes
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Quote_Faxes")]
        public Quote Quote_Faxes
        {
            get { return GetRelatedEntity<Quote>("Quote_Faxes", null); }
            set
            {
                OnPropertyChanging("Quote_Faxes");
                SetRelatedEntity("Quote_Faxes", null, value);
                OnPropertyChanged("Quote_Faxes");
            }
        }

        /// <summary>
        ///     N:1 SalesOrder_Faxes
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SalesOrder_Faxes")]
        public SalesOrder SalesOrder_Faxes
        {
            get { return GetRelatedEntity<SalesOrder>("SalesOrder_Faxes", null); }
            set
            {
                OnPropertyChanging("SalesOrder_Faxes");
                SetRelatedEntity("SalesOrder_Faxes", null, value);
                OnPropertyChanged("SalesOrder_Faxes");
            }
        }

        /// <summary>
        ///     N:1 service_faxes
        /// </summary>
        [AttributeLogicalName("serviceid")]
        [RelationshipSchemaName("service_faxes")]
        public Service service_faxes
        {
            get { return GetRelatedEntity<Service>("service_faxes", null); }
            set
            {
                OnPropertyChanging("service_faxes");
                SetRelatedEntity("service_faxes", null, value);
                OnPropertyChanged("service_faxes");
            }
        }

        /// <summary>
        ///     N:1 team_fax
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_fax")]
        public Team team_fax
        {
            get { return GetRelatedEntity<Team>("team_fax", null); }
        }

        /// <summary>
        ///     N:1 TransactionCurrency_Fax
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("TransactionCurrency_Fax")]
        public TransactionCurrency TransactionCurrency_Fax
        {
            get { return GetRelatedEntity<TransactionCurrency>("TransactionCurrency_Fax", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_Fax");
                SetRelatedEntity("TransactionCurrency_Fax", null, value);
                OnPropertyChanged("TransactionCurrency_Fax");
            }
        }

        /// <summary>
        ///     N:1 user_fax
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_fax")]
        public SystemUser user_fax
        {
            get { return GetRelatedEntity<SystemUser>("user_fax", null); }
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