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
    ///     Container for campaign activities and responses, sales literature, products, and lists to create, plan, execute,
    ///     and track the results of a specific marketing campaign through its life.
    /// </summary>
    [DataContract]
    [EntityLogicalName("campaign")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Campaign : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "campaign";

        public const int EntityTypeCode = 4400;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Campaign() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Enter the date when the campaign was closed or completed.
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
        ///     Enter the actual start date and time for the campaign.
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
        ///     Type the amount budgeted for the campaign to define a limit for how much you can spend.
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
        ///     Unique identifier of the campaign.
        /// </summary>
        [AttributeLogicalName("campaignid")]
        public Guid? CampaignId
        {
            get { return GetAttributeValue<Guid?>("campaignid"); }
            set
            {
                OnPropertyChanging("CampaignId");
                SetAttributeValue("campaignid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("CampaignId");
            }
        }

        [AttributeLogicalName("campaignid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { CampaignId = value; }
        }

        /// <summary>
        ///     Type a number or other tracking code to identify the campaign. If no value is entered, a code will be generated
        ///     automatically.
        /// </summary>
        [AttributeLogicalName("codename")]
        public string CodeName
        {
            get { return GetAttributeValue<string>("codename"); }
            set
            {
                OnPropertyChanging("CodeName");
                SetAttributeValue("codename", value);
                OnPropertyChanged("CodeName");
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
        ///     Type additional information to describe the campaign, such as the products or services offered or the targeted
        ///     audience.
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
        ///     Type the expected response rate for the campaign as a full number between 0 and 100.
        /// </summary>
        [AttributeLogicalName("expectedresponse")]
        public int? ExpectedResponse
        {
            get { return GetAttributeValue<int?>("expectedresponse"); }
            set
            {
                OnPropertyChanging("ExpectedResponse");
                SetAttributeValue("expectedresponse", value);
                OnPropertyChanged("ExpectedResponse");
            }
        }

        /// <summary>
        ///     Type the expected revenue for the campaign for return on investment projections and post-campaign reporting.
        /// </summary>
        [AttributeLogicalName("expectedrevenue")]
        public Money ExpectedRevenue
        {
            get { return GetAttributeValue<Money>("expectedrevenue"); }
            set
            {
                OnPropertyChanging("ExpectedRevenue");
                SetAttributeValue("expectedrevenue", value);
                OnPropertyChanged("ExpectedRevenue");
            }
        }

        /// <summary>
        ///     Shows the estimated revenue converted to the system's default base currency. The calculations use the exchange rate
        ///     specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("expectedrevenue_base")]
        public Money ExpectedRevenue_Base
        {
            get { return GetAttributeValue<Money>("expectedrevenue_base"); }
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
        ///     Select whether the campaign is a template that can be copied when you create future campaigns.
        /// </summary>
        [AttributeLogicalName("istemplate")]
        public bool? IsTemplate
        {
            get { return GetAttributeValue<bool?>("istemplate"); }
            set
            {
                OnPropertyChanging("IsTemplate");
                SetAttributeValue("istemplate", value);
                OnPropertyChanged("IsTemplate");
            }
        }

        /// <summary>
        ///     Type the promotional message or marketing copy for the campaign.
        /// </summary>
        [AttributeLogicalName("message")]
        public string Message
        {
            get { return GetAttributeValue<string>("message"); }
            set
            {
                OnPropertyChanging("Message");
                SetAttributeValue("message", value);
                OnPropertyChanged("Message");
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
        ///     Type a name for the campaign so that it is identified correctly in lists.
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
        ///     Type the objective of the campaign, including products, services, discounts, and pricing.
        /// </summary>
        [AttributeLogicalName("objective")]
        public string Objective
        {
            get { return GetAttributeValue<string>("objective"); }
            set
            {
                OnPropertyChanging("Objective");
                SetAttributeValue("objective", value);
                OnPropertyChanged("Objective");
            }
        }

        /// <summary>
        ///     Type the sum of any miscellaneous campaign costs not included in the campaign activities to make sure the actual
        ///     cost of the campaign is calculated correctly.
        /// </summary>
        [AttributeLogicalName("othercost")]
        public Money OtherCost
        {
            get { return GetAttributeValue<Money>("othercost"); }
            set
            {
                OnPropertyChanging("OtherCost");
                SetAttributeValue("othercost", value);
                OnPropertyChanged("OtherCost");
            }
        }

        /// <summary>
        ///     Shows the Miscellaneous Costs field converted to the system's default base currency for reporting purposes. The
        ///     calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("othercost_base")]
        public Money OtherCost_Base
        {
            get { return GetAttributeValue<Money>("othercost_base"); }
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
        ///     Shows the business unit that the record owner belongs to.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the campaign.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the campaign.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Choose the price list associated with this item to make sure the products associated with the campaign are offered
        ///     at the correct prices.
        /// </summary>
        [AttributeLogicalName("pricelistid")]
        public EntityReference PriceListId
        {
            get { return GetAttributeValue<EntityReference>("pricelistid"); }
            set
            {
                OnPropertyChanging("PriceListId");
                SetAttributeValue("pricelistid", value);
                OnPropertyChanged("PriceListId");
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
        ///     Type a promotional code to track sales related to the campaign or allow customers to redeem a discount offer.
        /// </summary>
        [AttributeLogicalName("promotioncodename")]
        public string PromotionCodeName
        {
            get { return GetAttributeValue<string>("promotioncodename"); }
            set
            {
                OnPropertyChanging("PromotionCodeName");
                SetAttributeValue("promotioncodename", value);
                OnPropertyChanged("PromotionCodeName");
            }
        }

        /// <summary>
        ///     Enter the date when the campaign is scheduled to end.
        /// </summary>
        [AttributeLogicalName("proposedend")]
        public DateTime? ProposedEnd
        {
            get { return GetAttributeValue<DateTime?>("proposedend"); }
            set
            {
                OnPropertyChanging("ProposedEnd");
                SetAttributeValue("proposedend", value);
                OnPropertyChanged("ProposedEnd");
            }
        }

        /// <summary>
        ///     Enter the date when the campaign is scheduled to start.
        /// </summary>
        [AttributeLogicalName("proposedstart")]
        public DateTime? ProposedStart
        {
            get { return GetAttributeValue<DateTime?>("proposedstart"); }
            set
            {
                OnPropertyChanging("ProposedStart");
                SetAttributeValue("proposedstart", value);
                OnPropertyChanged("ProposedStart");
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
        ///     Shows the status of the campaign. By default, campaigns are active and can't be deactivated.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public CampaignState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((CampaignState) (Enum.ToObject(typeof (CampaignState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Select the campaign's status.
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
        ///     Shows the sum of the amounts entered in the Total Cost of Campaign Activities and Miscellaneous Costs fields.
        /// </summary>
        [AttributeLogicalName("totalactualcost")]
        public Money TotalActualCost
        {
            get { return GetAttributeValue<Money>("totalactualcost"); }
        }

        /// <summary>
        ///     Shows the Total Cost of Campaign field converted to the system's default base currency for reporting purposes. The
        ///     calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("totalactualcost_base")]
        public Money TotalActualCost_Base
        {
            get { return GetAttributeValue<Money>("totalactualcost_base"); }
        }

        /// <summary>
        ///     Shows the sum of the values entered in the Actual Cost field on all campaign activities related to the campaign.
        /// </summary>
        [AttributeLogicalName("totalcampaignactivityactualcost")]
        public Money TotalCampaignActivityActualCost
        {
            get { return GetAttributeValue<Money>("totalcampaignactivityactualcost"); }
        }

        /// <summary>
        ///     Shows the Total Cost of Campaign Activities field converted to the system's default base currency. The calculations
        ///     use the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("totalcampaignactivityactualcost_base")]
        public Money TotalCampaignActivityActualCost_Base
        {
            get { return GetAttributeValue<Money>("totalcampaignactivityactualcost_base"); }
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
        ///     Select the type of the campaign.
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
        ///     Version number of the campaign.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N campaign_activity_parties
        /// </summary>
        [RelationshipSchemaName("campaign_activity_parties")]
        public IEnumerable<ActivityParty> campaign_activity_parties
        {
            get { return GetRelatedEntities<ActivityParty>("campaign_activity_parties", null); }
            set
            {
                OnPropertyChanging("campaign_activity_parties");
                SetRelatedEntities("campaign_activity_parties", null, value);
                OnPropertyChanged("campaign_activity_parties");
            }
        }

        /// <summary>
        ///     1:N Campaign_ActivityPointers
        /// </summary>
        [RelationshipSchemaName("Campaign_ActivityPointers")]
        public IEnumerable<ActivityPointer> Campaign_ActivityPointers
        {
            get { return GetRelatedEntities<ActivityPointer>("Campaign_ActivityPointers", null); }
            set
            {
                OnPropertyChanging("Campaign_ActivityPointers");
                SetRelatedEntities("Campaign_ActivityPointers", null, value);
                OnPropertyChanged("Campaign_ActivityPointers");
            }
        }

        /// <summary>
        ///     1:N Campaign_Annotation
        /// </summary>
        [RelationshipSchemaName("Campaign_Annotation")]
        public IEnumerable<Annotation> Campaign_Annotation
        {
            get { return GetRelatedEntities<Annotation>("Campaign_Annotation", null); }
            set
            {
                OnPropertyChanging("Campaign_Annotation");
                SetRelatedEntities("Campaign_Annotation", null, value);
                OnPropertyChanged("Campaign_Annotation");
            }
        }

        /// <summary>
        ///     1:N Campaign_Appointments
        /// </summary>
        [RelationshipSchemaName("Campaign_Appointments")]
        public IEnumerable<Appointment> Campaign_Appointments
        {
            get { return GetRelatedEntities<Appointment>("Campaign_Appointments", null); }
            set
            {
                OnPropertyChanging("Campaign_Appointments");
                SetRelatedEntities("Campaign_Appointments", null, value);
                OnPropertyChanged("Campaign_Appointments");
            }
        }

        /// <summary>
        ///     1:N Campaign_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Campaign_AsyncOperations")]
        public IEnumerable<AsyncOperation> Campaign_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Campaign_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Campaign_AsyncOperations");
                SetRelatedEntities("Campaign_AsyncOperations", null, value);
                OnPropertyChanged("Campaign_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N Campaign_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("Campaign_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> Campaign_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("Campaign_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("Campaign_BulkDeleteFailures");
                SetRelatedEntities("Campaign_BulkDeleteFailures", null, value);
                OnPropertyChanged("Campaign_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N Campaign_CampaignActivities
        /// </summary>
        [RelationshipSchemaName("Campaign_CampaignActivities")]
        public IEnumerable<CampaignActivity> Campaign_CampaignActivities
        {
            get { return GetRelatedEntities<CampaignActivity>("Campaign_CampaignActivities", null); }
            set
            {
                OnPropertyChanging("Campaign_CampaignActivities");
                SetRelatedEntities("Campaign_CampaignActivities", null, value);
                OnPropertyChanged("Campaign_CampaignActivities");
            }
        }

        /// <summary>
        ///     1:N Campaign_CampaignResponses
        /// </summary>
        [RelationshipSchemaName("Campaign_CampaignResponses")]
        public IEnumerable<CampaignResponse> Campaign_CampaignResponses
        {
            get { return GetRelatedEntities<CampaignResponse>("Campaign_CampaignResponses", null); }
            set
            {
                OnPropertyChanging("Campaign_CampaignResponses");
                SetRelatedEntities("Campaign_CampaignResponses", null, value);
                OnPropertyChanged("Campaign_CampaignResponses");
            }
        }

        /// <summary>
        ///     1:N campaign_connections1
        /// </summary>
        [RelationshipSchemaName("campaign_connections1")]
        public IEnumerable<Connection> campaign_connections1
        {
            get { return GetRelatedEntities<Connection>("campaign_connections1", null); }
            set
            {
                OnPropertyChanging("campaign_connections1");
                SetRelatedEntities("campaign_connections1", null, value);
                OnPropertyChanged("campaign_connections1");
            }
        }

        /// <summary>
        ///     1:N campaign_connections2
        /// </summary>
        [RelationshipSchemaName("campaign_connections2")]
        public IEnumerable<Connection> campaign_connections2
        {
            get { return GetRelatedEntities<Connection>("campaign_connections2", null); }
            set
            {
                OnPropertyChanging("campaign_connections2");
                SetRelatedEntities("campaign_connections2", null, value);
                OnPropertyChanged("campaign_connections2");
            }
        }

        /// <summary>
        ///     1:N Campaign_DuplicateBaseRecord
        /// </summary>
        [RelationshipSchemaName("Campaign_DuplicateBaseRecord")]
        public IEnumerable<DuplicateRecord> Campaign_DuplicateBaseRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Campaign_DuplicateBaseRecord", null); }
            set
            {
                OnPropertyChanging("Campaign_DuplicateBaseRecord");
                SetRelatedEntities("Campaign_DuplicateBaseRecord", null, value);
                OnPropertyChanged("Campaign_DuplicateBaseRecord");
            }
        }

        /// <summary>
        ///     1:N Campaign_DuplicateMatchingRecord
        /// </summary>
        [RelationshipSchemaName("Campaign_DuplicateMatchingRecord")]
        public IEnumerable<DuplicateRecord> Campaign_DuplicateMatchingRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Campaign_DuplicateMatchingRecord", null); }
            set
            {
                OnPropertyChanging("Campaign_DuplicateMatchingRecord");
                SetRelatedEntities("Campaign_DuplicateMatchingRecord", null, value);
                OnPropertyChanged("Campaign_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        ///     1:N Campaign_Emails
        /// </summary>
        [RelationshipSchemaName("Campaign_Emails")]
        public IEnumerable<Email> Campaign_Emails
        {
            get { return GetRelatedEntities<Email>("Campaign_Emails", null); }
            set
            {
                OnPropertyChanging("Campaign_Emails");
                SetRelatedEntities("Campaign_Emails", null, value);
                OnPropertyChanged("Campaign_Emails");
            }
        }

        /// <summary>
        ///     1:N Campaign_Faxes
        /// </summary>
        [RelationshipSchemaName("Campaign_Faxes")]
        public IEnumerable<Fax> Campaign_Faxes
        {
            get { return GetRelatedEntities<Fax>("Campaign_Faxes", null); }
            set
            {
                OnPropertyChanging("Campaign_Faxes");
                SetRelatedEntities("Campaign_Faxes", null, value);
                OnPropertyChanged("Campaign_Faxes");
            }
        }

        /// <summary>
        ///     1:N campaign_leads
        /// </summary>
        [RelationshipSchemaName("campaign_leads")]
        public IEnumerable<Lead> campaign_leads
        {
            get { return GetRelatedEntities<Lead>("campaign_leads", null); }
            set
            {
                OnPropertyChanging("campaign_leads");
                SetRelatedEntities("campaign_leads", null, value);
                OnPropertyChanged("campaign_leads");
            }
        }

        /// <summary>
        ///     1:N Campaign_Letters
        /// </summary>
        [RelationshipSchemaName("Campaign_Letters")]
        public IEnumerable<Letter> Campaign_Letters
        {
            get { return GetRelatedEntities<Letter>("Campaign_Letters", null); }
            set
            {
                OnPropertyChanging("Campaign_Letters");
                SetRelatedEntities("Campaign_Letters", null, value);
                OnPropertyChanged("Campaign_Letters");
            }
        }

        /// <summary>
        ///     1:N campaign_opportunities
        /// </summary>
        [RelationshipSchemaName("campaign_opportunities")]
        public IEnumerable<Opportunity> campaign_opportunities
        {
            get { return GetRelatedEntities<Opportunity>("campaign_opportunities", null); }
            set
            {
                OnPropertyChanging("campaign_opportunities");
                SetRelatedEntities("campaign_opportunities", null, value);
                OnPropertyChanged("campaign_opportunities");
            }
        }

        /// <summary>
        ///     1:N campaign_orders
        /// </summary>
        [RelationshipSchemaName("campaign_orders")]
        public IEnumerable<SalesOrder> campaign_orders
        {
            get { return GetRelatedEntities<SalesOrder>("campaign_orders", null); }
            set
            {
                OnPropertyChanging("campaign_orders");
                SetRelatedEntities("campaign_orders", null, value);
                OnPropertyChanged("campaign_orders");
            }
        }

        /// <summary>
        ///     1:N Campaign_Phonecalls
        /// </summary>
        [RelationshipSchemaName("Campaign_Phonecalls")]
        public IEnumerable<PhoneCall> Campaign_Phonecalls
        {
            get { return GetRelatedEntities<PhoneCall>("Campaign_Phonecalls", null); }
            set
            {
                OnPropertyChanging("Campaign_Phonecalls");
                SetRelatedEntities("Campaign_Phonecalls", null, value);
                OnPropertyChanged("Campaign_Phonecalls");
            }
        }

        /// <summary>
        ///     1:N campaign_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("campaign_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> campaign_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntities<PrincipalObjectAttributeAccess>("campaign_principalobjectattributeaccess",
                    null);
            }
            set
            {
                OnPropertyChanging("campaign_principalobjectattributeaccess");
                SetRelatedEntities("campaign_principalobjectattributeaccess", null, value);
                OnPropertyChanged("campaign_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N Campaign_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("Campaign_ProcessSessions")]
        public IEnumerable<ProcessSession> Campaign_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("Campaign_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Campaign_ProcessSessions");
                SetRelatedEntities("Campaign_ProcessSessions", null, value);
                OnPropertyChanged("Campaign_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N campaign_quotes
        /// </summary>
        [RelationshipSchemaName("campaign_quotes")]
        public IEnumerable<Quote> campaign_quotes
        {
            get { return GetRelatedEntities<Quote>("campaign_quotes", null); }
            set
            {
                OnPropertyChanging("campaign_quotes");
                SetRelatedEntities("campaign_quotes", null, value);
                OnPropertyChanged("campaign_quotes");
            }
        }

        /// <summary>
        ///     1:N Campaign_RecurringAppointmentMasters
        /// </summary>
        [RelationshipSchemaName("Campaign_RecurringAppointmentMasters")]
        public IEnumerable<RecurringAppointmentMaster> Campaign_RecurringAppointmentMasters
        {
            get { return GetRelatedEntities<RecurringAppointmentMaster>("Campaign_RecurringAppointmentMasters", null); }
            set
            {
                OnPropertyChanging("Campaign_RecurringAppointmentMasters");
                SetRelatedEntities("Campaign_RecurringAppointmentMasters", null, value);
                OnPropertyChanged("Campaign_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        ///     1:N Campaign_ServiceAppointments
        /// </summary>
        [RelationshipSchemaName("Campaign_ServiceAppointments")]
        public IEnumerable<ServiceAppointment> Campaign_ServiceAppointments
        {
            get { return GetRelatedEntities<ServiceAppointment>("Campaign_ServiceAppointments", null); }
            set
            {
                OnPropertyChanging("Campaign_ServiceAppointments");
                SetRelatedEntities("Campaign_ServiceAppointments", null, value);
                OnPropertyChanged("Campaign_ServiceAppointments");
            }
        }

        /// <summary>
        ///     1:N Campaign_Tasks
        /// </summary>
        [RelationshipSchemaName("Campaign_Tasks")]
        public IEnumerable<Task> Campaign_Tasks
        {
            get { return GetRelatedEntities<Task>("Campaign_Tasks", null); }
            set
            {
                OnPropertyChanging("Campaign_Tasks");
                SetRelatedEntities("Campaign_Tasks", null, value);
                OnPropertyChanged("Campaign_Tasks");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_campaign
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_campaign")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_campaign
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_campaign", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_campaign");
                SetRelatedEntities("userentityinstancedata_campaign", null, value);
                OnPropertyChanged("userentityinstancedata_campaign");
            }
        }

        /// <summary>
        ///     N:N campaigncampaign_association
        /// </summary>
        [RelationshipSchemaName("campaigncampaign_association", EntityRole.Referencing)]
        public IEnumerable<Campaign> Referencingcampaigncampaign_association
        {
            get { return GetRelatedEntities<Campaign>("campaigncampaign_association", EntityRole.Referencing); }
            set
            {
                OnPropertyChanging("Referencingcampaigncampaign_association");
                SetRelatedEntities("campaigncampaign_association", EntityRole.Referencing, value);
                OnPropertyChanged("Referencingcampaigncampaign_association");
            }
        }

        /// <summary>
        ///     N:N campaigncampaign_association
        /// </summary>
        [RelationshipSchemaName("campaigncampaign_association", EntityRole.Referenced)]
        public IEnumerable<Campaign> Referencedcampaigncampaign_association
        {
            get { return GetRelatedEntities<Campaign>("campaigncampaign_association", EntityRole.Referenced); }
            set
            {
                OnPropertyChanging("Referencedcampaigncampaign_association");
                SetRelatedEntities("campaigncampaign_association", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedcampaigncampaign_association");
            }
        }

        /// <summary>
        ///     N:N campaignlist_association
        /// </summary>
        [RelationshipSchemaName("campaignlist_association")]
        public IEnumerable<List> campaignlist_association
        {
            get { return GetRelatedEntities<List>("campaignlist_association", null); }
            set
            {
                OnPropertyChanging("campaignlist_association");
                SetRelatedEntities("campaignlist_association", null, value);
                OnPropertyChanged("campaignlist_association");
            }
        }

        /// <summary>
        ///     N:N campaignproduct_association
        /// </summary>
        [RelationshipSchemaName("campaignproduct_association")]
        public IEnumerable<Product> campaignproduct_association
        {
            get { return GetRelatedEntities<Product>("campaignproduct_association", null); }
            set
            {
                OnPropertyChanging("campaignproduct_association");
                SetRelatedEntities("campaignproduct_association", null, value);
                OnPropertyChanged("campaignproduct_association");
            }
        }

        /// <summary>
        ///     N:N campaignsalesliterature_association
        /// </summary>
        [RelationshipSchemaName("campaignsalesliterature_association")]
        public IEnumerable<SalesLiterature> campaignsalesliterature_association
        {
            get { return GetRelatedEntities<SalesLiterature>("campaignsalesliterature_association", null); }
            set
            {
                OnPropertyChanging("campaignsalesliterature_association");
                SetRelatedEntities("campaignsalesliterature_association", null, value);
                OnPropertyChanged("campaignsalesliterature_association");
            }
        }

        /// <summary>
        ///     N:1 BusinessUnit_Campaigns
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("BusinessUnit_Campaigns")]
        public BusinessUnit BusinessUnit_Campaigns
        {
            get { return GetRelatedEntity<BusinessUnit>("BusinessUnit_Campaigns", null); }
        }

        /// <summary>
        ///     N:1 lk_campaign_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_campaign_createdby")]
        public SystemUser lk_campaign_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_campaign_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_campaign_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_campaign_createdonbehalfby")]
        public SystemUser lk_campaign_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_campaign_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_campaign_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_campaign_modifiedby")]
        public SystemUser lk_campaign_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_campaign_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_campaign_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_campaign_modifiedonbehalfby")]
        public SystemUser lk_campaign_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_campaign_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 PriceList_Campaigns
        /// </summary>
        [AttributeLogicalName("pricelistid")]
        [RelationshipSchemaName("PriceList_Campaigns")]
        public PriceLevel PriceList_Campaigns
        {
            get { return GetRelatedEntity<PriceLevel>("PriceList_Campaigns", null); }
            set
            {
                OnPropertyChanging("PriceList_Campaigns");
                SetRelatedEntity("PriceList_Campaigns", null, value);
                OnPropertyChanged("PriceList_Campaigns");
            }
        }

        /// <summary>
        ///     N:1 processstage_campaigns
        /// </summary>
        [AttributeLogicalName("stageid")]
        [RelationshipSchemaName("processstage_campaigns")]
        public ProcessStage processstage_campaigns
        {
            get { return GetRelatedEntity<ProcessStage>("processstage_campaigns", null); }
            set
            {
                OnPropertyChanging("processstage_campaigns");
                SetRelatedEntity("processstage_campaigns", null, value);
                OnPropertyChanged("processstage_campaigns");
            }
        }

        /// <summary>
        ///     N:1 SystemUser_Campaigns
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("SystemUser_Campaigns")]
        public SystemUser SystemUser_Campaigns
        {
            get { return GetRelatedEntity<SystemUser>("SystemUser_Campaigns", null); }
        }

        /// <summary>
        ///     N:1 team_Campaigns
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_Campaigns")]
        public Team team_Campaigns
        {
            get { return GetRelatedEntity<Team>("team_Campaigns", null); }
        }

        /// <summary>
        ///     N:1 transactioncurrency_campaign
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("transactioncurrency_campaign")]
        public TransactionCurrency transactioncurrency_campaign
        {
            get { return GetRelatedEntity<TransactionCurrency>("transactioncurrency_campaign", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_campaign");
                SetRelatedEntity("transactioncurrency_campaign", null, value);
                OnPropertyChanged("transactioncurrency_campaign");
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