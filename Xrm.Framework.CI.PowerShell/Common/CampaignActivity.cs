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
    ///     Task performed, or to be performed, by a user for planning or running a campaign.
    /// </summary>
    [DataContract]
    [EntityLogicalName("campaignactivity")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class CampaignActivity : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "campaignactivity";

        public const int EntityTypeCode = 4402;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public CampaignActivity() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the campaign activity.
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
        ///     Type the actual cost of the campaign activity. The value entered is rolled up to the related campaign in the total
        ///     cost calculations.
        /// </summary>
        [AttributeLogicalName("actualcost")]
        public Money ActualCost
        {
            get { return GetAttributeValue<Money>("actualcost"); }
            set
            {
                OnPropertyChanging("ActualCost");
                SetAttributeValue("actualcost", value);
                OnPropertyChanged("ActualCost");
            }
        }

        /// <summary>
        ///     Shows the Actual Cost field converted to the system's default base currency for reporting purposes. The
        ///     calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("actualcost_base")]
        public Money ActualCost_Base
        {
            get { return GetAttributeValue<Money>("actualcost_base"); }
        }

        /// <summary>
        ///     Shows the value selected in the Duration field on the campaign activity. The duration is used to report the time
        ///     spent on the activity.
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
        ///     Enter the date when the campaign activity was actually completed.
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
        ///     Enter the actual start date and time for the campaign activity to determine if the campaign activity started on the
        ///     scheduled time.
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
        ///     Type the allocated budget of the campaign activity for estimated versus actual cost reporting.
        /// </summary>
        [AttributeLogicalName("budgetedcost")]
        public Money BudgetedCost
        {
            get { return GetAttributeValue<Money>("budgetedcost"); }
            set
            {
                OnPropertyChanging("BudgetedCost");
                SetAttributeValue("budgetedcost", value);
                OnPropertyChanged("BudgetedCost");
            }
        }

        /// <summary>
        ///     Shows the Budget Allocated field converted to the system's default base currency. The calculations use the exchange
        ///     rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("budgetedcost_base")]
        public Money BudgetedCost_Base
        {
            get { return GetAttributeValue<Money>("budgetedcost_base"); }
        }

        /// <summary>
        ///     Type a category to identify the campaign activity type, such as new business development or customer retention, to
        ///     tie the campaign activity to a business group or function.
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
        ///     Select how communications for this activity will be sent, such as phone, letter, fax, or email.
        /// </summary>
        [AttributeLogicalName("channeltypecode")]
        public OptionSetValue ChannelTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("channeltypecode"); }
            set
            {
                OnPropertyChanging("ChannelTypeCode");
                SetAttributeValue("channeltypecode", value);
                OnPropertyChanged("ChannelTypeCode");
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
        ///     Type additional information to describe the campaign activity, such as key talking points, objectives, or details
        ///     about the target audience.
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
        ///     Select whether to override the opt-out settings on leads, contacts, and accounts for the members of the target
        ///     marketing lists of the campaign activity. If No is selected, marketing materials will be sent to members who have
        ///     opted out.
        /// </summary>
        [AttributeLogicalName("donotsendonoptout")]
        public bool? DoNotSendOnOptOut
        {
            get { return GetAttributeValue<bool?>("donotsendonoptout"); }
            set
            {
                OnPropertyChanging("DoNotSendOnOptOut");
                SetAttributeValue("donotsendonoptout", value);
                OnPropertyChanged("DoNotSendOnOptOut");
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
        ///     Type the minimum number of days that must be passed before a marketing list member can be contacted in a campaign
        ///     again. The campaign activity will not be applied to members contacted within the specified time period.
        /// </summary>
        [AttributeLogicalName("excludeifcontactedinxdays")]
        public int? ExcludeIfContactedInXDays
        {
            get { return GetAttributeValue<int?>("excludeifcontactedinxdays"); }
            set
            {
                OnPropertyChanging("ExcludeIfContactedInXDays");
                SetAttributeValue("excludeifcontactedinxdays", value);
                OnPropertyChanged("ExcludeIfContactedInXDays");
            }
        }

        /// <summary>
        ///     For system use only.
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
        ///     Select whether inactive marketing list members will be excluded from the campaign activity distribution.
        /// </summary>
        [AttributeLogicalName("ignoreinactivelistmembers")]
        public bool? IgnoreInactiveListMembers
        {
            get { return GetAttributeValue<bool?>("ignoreinactivelistmembers"); }
            set
            {
                OnPropertyChanging("IgnoreInactiveListMembers");
                SetAttributeValue("ignoreinactivelistmembers", value);
                OnPropertyChanged("IgnoreInactiveListMembers");
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
        ///     Information regarding whether the campaign activity was billed as part of resolving a case.
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
        ///     Information about whether the campaign activity is created by a workflow rule.
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
        ///     Shows who created the record on behalf of another user.
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
        ///     Unique identifier of the business unit that owns the campaign activity.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the campaign activity.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the campaign activity.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Enter the vendor accounts or contacts to capture any third-party suppliers used for the campaign activity.
        /// </summary>
        [AttributeLogicalName("partners")]
        public IEnumerable<ActivityParty> Partners
        {
            get
            {
                var collection = GetAttributeValue<EntityCollection>("partners");
                if (((collection != null)
                     && (collection.Entities != null)))
                {
                    return Enumerable.Cast<ActivityParty>(collection.Entities);
                }
                return null;
            }
            set
            {
                OnPropertyChanging("Partners");
                if ((value == null))
                {
                    SetAttributeValue("partners", value);
                }
                else
                {
                    SetAttributeValue("partners", new EntityCollection(new List<Entity>(value)));
                }
                OnPropertyChanged("Partners");
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
        ///     Choose the parent campaign so that the campaign activity costs reflect in the correct campaign for reporting.
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
        ///     Scheduled duration, specified in minutes, of the campaign activity.
        /// </summary>
        [AttributeLogicalName("scheduleddurationminutes")]
        public int? ScheduledDurationMinutes
        {
            get { return GetAttributeValue<int?>("scheduleddurationminutes"); }
        }

        /// <summary>
        ///     Enter the expected due date and time for the activity to be completed to provide details about the timing of the
        ///     campaign activity.
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
        ///     Enter the expected start date and time for the activity to provide details about timing of the campaign activity.
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
        ///     Unique identifier of the associated service.
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
        ///     Shows whether the campaign activity is open, completed, or canceled. Completed and canceled campaign activities are
        ///     read-only and can't be edited.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public CampaignActivityState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((CampaignActivityState) (Enum.ToObject(typeof (CampaignActivityState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Select the campaign activity's status.
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
        ///     Type a subcategory to identify the campaign activity type and relate the activity to a specific product, sales
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
        ///     Type a short description about the objective or primary topic of the campaign activity.
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
        }

        /// <summary>
        ///     Select the type of campaign activity to indicate the purpose of the activity.
        /// </summary>
        [AttributeLogicalName("typecode")]
        public OptionSetValue TypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("typecode"); }
            set
            {
                OnPropertyChanging("TypeCode");
                SetAttributeValue("typecode", value);
                OnPropertyChanged("TypeCode");
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
        ///     Version number of the campaign activity.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N campaignactivity_activity_parties
        /// </summary>
        [RelationshipSchemaName("campaignactivity_activity_parties")]
        public IEnumerable<ActivityParty> campaignactivity_activity_parties
        {
            get { return GetRelatedEntities<ActivityParty>("campaignactivity_activity_parties", null); }
            set
            {
                OnPropertyChanging("campaignactivity_activity_parties");
                SetRelatedEntities("campaignactivity_activity_parties", null, value);
                OnPropertyChanged("campaignactivity_activity_parties");
            }
        }

        /// <summary>
        ///     1:N campaignactivity_activityparties
        /// </summary>
        [RelationshipSchemaName("campaignactivity_activityparties")]
        public IEnumerable<ActivityParty> campaignactivity_activityparties
        {
            get { return GetRelatedEntities<ActivityParty>("campaignactivity_activityparties", null); }
            set
            {
                OnPropertyChanging("campaignactivity_activityparties");
                SetRelatedEntities("campaignactivity_activityparties", null, value);
                OnPropertyChanged("campaignactivity_activityparties");
            }
        }

        /// <summary>
        ///     1:N CampaignActivity_ActivityPointers
        /// </summary>
        [RelationshipSchemaName("CampaignActivity_ActivityPointers")]
        public IEnumerable<ActivityPointer> CampaignActivity_ActivityPointers
        {
            get { return GetRelatedEntities<ActivityPointer>("CampaignActivity_ActivityPointers", null); }
            set
            {
                OnPropertyChanging("CampaignActivity_ActivityPointers");
                SetRelatedEntities("CampaignActivity_ActivityPointers", null, value);
                OnPropertyChanged("CampaignActivity_ActivityPointers");
            }
        }

        /// <summary>
        ///     1:N CampaignActivity_Annotation
        /// </summary>
        [RelationshipSchemaName("CampaignActivity_Annotation")]
        public IEnumerable<Annotation> CampaignActivity_Annotation
        {
            get { return GetRelatedEntities<Annotation>("CampaignActivity_Annotation", null); }
            set
            {
                OnPropertyChanging("CampaignActivity_Annotation");
                SetRelatedEntities("CampaignActivity_Annotation", null, value);
                OnPropertyChanged("CampaignActivity_Annotation");
            }
        }

        /// <summary>
        ///     1:N CampaignActivity_Appointments
        /// </summary>
        [RelationshipSchemaName("CampaignActivity_Appointments")]
        public IEnumerable<Appointment> CampaignActivity_Appointments
        {
            get { return GetRelatedEntities<Appointment>("CampaignActivity_Appointments", null); }
            set
            {
                OnPropertyChanging("CampaignActivity_Appointments");
                SetRelatedEntities("CampaignActivity_Appointments", null, value);
                OnPropertyChanged("CampaignActivity_Appointments");
            }
        }

        /// <summary>
        ///     1:N CampaignActivity_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("CampaignActivity_AsyncOperations")]
        public IEnumerable<AsyncOperation> CampaignActivity_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("CampaignActivity_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("CampaignActivity_AsyncOperations");
                SetRelatedEntities("CampaignActivity_AsyncOperations", null, value);
                OnPropertyChanged("CampaignActivity_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N CampaignActivity_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("CampaignActivity_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> CampaignActivity_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("CampaignActivity_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("CampaignActivity_BulkDeleteFailures");
                SetRelatedEntities("CampaignActivity_BulkDeleteFailures", null, value);
                OnPropertyChanged("CampaignActivity_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N CampaignActivity_BulkOperations
        /// </summary>
        [RelationshipSchemaName("CampaignActivity_BulkOperations")]
        public IEnumerable<BulkOperation> CampaignActivity_BulkOperations
        {
            get { return GetRelatedEntities<BulkOperation>("CampaignActivity_BulkOperations", null); }
            set
            {
                OnPropertyChanging("CampaignActivity_BulkOperations");
                SetRelatedEntities("CampaignActivity_BulkOperations", null, value);
                OnPropertyChanged("CampaignActivity_BulkOperations");
            }
        }

        /// <summary>
        ///     1:N campaignactivity_connections1
        /// </summary>
        [RelationshipSchemaName("campaignactivity_connections1")]
        public IEnumerable<Connection> campaignactivity_connections1
        {
            get { return GetRelatedEntities<Connection>("campaignactivity_connections1", null); }
            set
            {
                OnPropertyChanging("campaignactivity_connections1");
                SetRelatedEntities("campaignactivity_connections1", null, value);
                OnPropertyChanged("campaignactivity_connections1");
            }
        }

        /// <summary>
        ///     1:N campaignactivity_connections2
        /// </summary>
        [RelationshipSchemaName("campaignactivity_connections2")]
        public IEnumerable<Connection> campaignactivity_connections2
        {
            get { return GetRelatedEntities<Connection>("campaignactivity_connections2", null); }
            set
            {
                OnPropertyChanging("campaignactivity_connections2");
                SetRelatedEntities("campaignactivity_connections2", null, value);
                OnPropertyChanged("campaignactivity_connections2");
            }
        }

        /// <summary>
        ///     1:N CampaignActivity_Emails
        /// </summary>
        [RelationshipSchemaName("CampaignActivity_Emails")]
        public IEnumerable<Email> CampaignActivity_Emails
        {
            get { return GetRelatedEntities<Email>("CampaignActivity_Emails", null); }
            set
            {
                OnPropertyChanging("CampaignActivity_Emails");
                SetRelatedEntities("CampaignActivity_Emails", null, value);
                OnPropertyChanged("CampaignActivity_Emails");
            }
        }

        /// <summary>
        ///     1:N CampaignActivity_Faxes
        /// </summary>
        [RelationshipSchemaName("CampaignActivity_Faxes")]
        public IEnumerable<Fax> CampaignActivity_Faxes
        {
            get { return GetRelatedEntities<Fax>("CampaignActivity_Faxes", null); }
            set
            {
                OnPropertyChanging("CampaignActivity_Faxes");
                SetRelatedEntities("CampaignActivity_Faxes", null, value);
                OnPropertyChanged("CampaignActivity_Faxes");
            }
        }

        /// <summary>
        ///     1:N CampaignActivity_Letters
        /// </summary>
        [RelationshipSchemaName("CampaignActivity_Letters")]
        public IEnumerable<Letter> CampaignActivity_Letters
        {
            get { return GetRelatedEntities<Letter>("CampaignActivity_Letters", null); }
            set
            {
                OnPropertyChanging("CampaignActivity_Letters");
                SetRelatedEntities("CampaignActivity_Letters", null, value);
                OnPropertyChanged("CampaignActivity_Letters");
            }
        }

        /// <summary>
        ///     1:N CampaignActivity_Phonecalls
        /// </summary>
        [RelationshipSchemaName("CampaignActivity_Phonecalls")]
        public IEnumerable<PhoneCall> CampaignActivity_Phonecalls
        {
            get { return GetRelatedEntities<PhoneCall>("CampaignActivity_Phonecalls", null); }
            set
            {
                OnPropertyChanging("CampaignActivity_Phonecalls");
                SetRelatedEntities("CampaignActivity_Phonecalls", null, value);
                OnPropertyChanged("CampaignActivity_Phonecalls");
            }
        }

        /// <summary>
        ///     1:N campaignactivity_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("campaignactivity_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> campaignactivity_principalobjectattributeaccess
        {
            get
            {
                return
                    GetRelatedEntities<PrincipalObjectAttributeAccess>(
                        "campaignactivity_principalobjectattributeaccess", null);
            }
            set
            {
                OnPropertyChanging("campaignactivity_principalobjectattributeaccess");
                SetRelatedEntities("campaignactivity_principalobjectattributeaccess", null, value);
                OnPropertyChanged("campaignactivity_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N CampaignActivity_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("CampaignActivity_ProcessSessions")]
        public IEnumerable<ProcessSession> CampaignActivity_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("CampaignActivity_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("CampaignActivity_ProcessSessions");
                SetRelatedEntities("CampaignActivity_ProcessSessions", null, value);
                OnPropertyChanged("CampaignActivity_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N CampaignActivity_QueueItem
        /// </summary>
        [RelationshipSchemaName("CampaignActivity_QueueItem")]
        public IEnumerable<QueueItem> CampaignActivity_QueueItem
        {
            get { return GetRelatedEntities<QueueItem>("CampaignActivity_QueueItem", null); }
            set
            {
                OnPropertyChanging("CampaignActivity_QueueItem");
                SetRelatedEntities("CampaignActivity_QueueItem", null, value);
                OnPropertyChanged("CampaignActivity_QueueItem");
            }
        }

        /// <summary>
        ///     1:N CampaignActivity_RecurringAppointmentMasters
        /// </summary>
        [RelationshipSchemaName("CampaignActivity_RecurringAppointmentMasters")]
        public IEnumerable<RecurringAppointmentMaster> CampaignActivity_RecurringAppointmentMasters
        {
            get
            {
                return GetRelatedEntities<RecurringAppointmentMaster>("CampaignActivity_RecurringAppointmentMasters",
                    null);
            }
            set
            {
                OnPropertyChanging("CampaignActivity_RecurringAppointmentMasters");
                SetRelatedEntities("CampaignActivity_RecurringAppointmentMasters", null, value);
                OnPropertyChanged("CampaignActivity_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        ///     1:N CampaignActivity_Tasks
        /// </summary>
        [RelationshipSchemaName("CampaignActivity_Tasks")]
        public IEnumerable<Task> CampaignActivity_Tasks
        {
            get { return GetRelatedEntities<Task>("CampaignActivity_Tasks", null); }
            set
            {
                OnPropertyChanging("CampaignActivity_Tasks");
                SetRelatedEntities("CampaignActivity_Tasks", null, value);
                OnPropertyChanged("CampaignActivity_Tasks");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_campaignactivity
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_campaignactivity")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_campaignactivity
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_campaignactivity", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_campaignactivity");
                SetRelatedEntities("userentityinstancedata_campaignactivity", null, value);
                OnPropertyChanged("userentityinstancedata_campaignactivity");
            }
        }

        /// <summary>
        ///     N:N campaignactivitylist_association
        /// </summary>
        [RelationshipSchemaName("campaignactivitylist_association")]
        public IEnumerable<List> campaignactivitylist_association
        {
            get { return GetRelatedEntities<List>("campaignactivitylist_association", null); }
            set
            {
                OnPropertyChanging("campaignactivitylist_association");
                SetRelatedEntities("campaignactivitylist_association", null, value);
                OnPropertyChanged("campaignactivitylist_association");
            }
        }

        /// <summary>
        ///     N:N campaignactivitysalesliterature_association
        /// </summary>
        [RelationshipSchemaName("campaignactivitysalesliterature_association")]
        public IEnumerable<SalesLiterature> campaignactivitysalesliterature_association
        {
            get { return GetRelatedEntities<SalesLiterature>("campaignactivitysalesliterature_association", null); }
            set
            {
                OnPropertyChanging("campaignactivitysalesliterature_association");
                SetRelatedEntities("campaignactivitysalesliterature_association", null, value);
                OnPropertyChanged("campaignactivitysalesliterature_association");
            }
        }

        /// <summary>
        ///     N:1 activity_pointer_campaignactivity
        /// </summary>
        [AttributeLogicalName("activityid")]
        [RelationshipSchemaName("activity_pointer_campaignactivity")]
        public ActivityPointer activity_pointer_campaignactivity
        {
            get { return GetRelatedEntity<ActivityPointer>("activity_pointer_campaignactivity", null); }
            set
            {
                OnPropertyChanging("activity_pointer_campaignactivity");
                SetRelatedEntity("activity_pointer_campaignactivity", null, value);
                OnPropertyChanged("activity_pointer_campaignactivity");
            }
        }

        /// <summary>
        ///     N:1 business_unit_campaignactivity_activities
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_campaignactivity_activities")]
        public BusinessUnit business_unit_campaignactivity_activities
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_campaignactivity_activities", null); }
        }

        /// <summary>
        ///     N:1 Campaign_CampaignActivities
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Campaign_CampaignActivities")]
        public Campaign Campaign_CampaignActivities
        {
            get { return GetRelatedEntity<Campaign>("Campaign_CampaignActivities", null); }
            set
            {
                OnPropertyChanging("Campaign_CampaignActivities");
                SetRelatedEntity("Campaign_CampaignActivities", null, value);
                OnPropertyChanged("Campaign_CampaignActivities");
            }
        }

        /// <summary>
        ///     N:1 lk_campaignactivity_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_campaignactivity_createdby")]
        public SystemUser lk_campaignactivity_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_campaignactivity_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_campaignactivity_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_campaignactivity_createdonbehalfby")]
        public SystemUser lk_campaignactivity_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_campaignactivity_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_campaignactivity_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_campaignactivity_modifiedby")]
        public SystemUser lk_campaignactivity_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_campaignactivity_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_campaignactivity_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_campaignactivity_modifiedonbehalfby")]
        public SystemUser lk_campaignactivity_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_campaignactivity_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 processstage_campaignactivities
        /// </summary>
        [AttributeLogicalName("stageid")]
        [RelationshipSchemaName("processstage_campaignactivities")]
        public ProcessStage processstage_campaignactivities
        {
            get { return GetRelatedEntity<ProcessStage>("processstage_campaignactivities", null); }
            set
            {
                OnPropertyChanging("processstage_campaignactivities");
                SetRelatedEntity("processstage_campaignactivities", null, value);
                OnPropertyChanged("processstage_campaignactivities");
            }
        }

        /// <summary>
        ///     N:1 team_campaignactivity
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_campaignactivity")]
        public Team team_campaignactivity
        {
            get { return GetRelatedEntity<Team>("team_campaignactivity", null); }
        }

        /// <summary>
        ///     N:1 transactioncurrency_campaignactivity
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("transactioncurrency_campaignactivity")]
        public TransactionCurrency transactioncurrency_campaignactivity
        {
            get { return GetRelatedEntity<TransactionCurrency>("transactioncurrency_campaignactivity", null); }
        }

        /// <summary>
        ///     N:1 user_campaignactivity
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_campaignactivity")]
        public SystemUser user_campaignactivity
        {
            get { return GetRelatedEntity<SystemUser>("user_campaignactivity", null); }
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