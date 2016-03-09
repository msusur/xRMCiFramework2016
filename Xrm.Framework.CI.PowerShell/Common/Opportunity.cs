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
    ///     Potential revenue-generating event, or sale to an account, which needs to be tracked through a sales process to
    ///     completion.
    /// </summary>
    [DataContract]
    [EntityLogicalName("opportunity")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Opportunity : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "opportunity";

        public const int EntityTypeCode = 3;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Opportunity() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the account with which the opportunity is associated.
        /// </summary>
        [AttributeLogicalName("accountid")]
        public EntityReference AccountId
        {
            get { return GetAttributeValue<EntityReference>("accountid"); }
        }

        /// <summary>
        ///     Shows the date and time when the opportunity was closed or canceled.
        /// </summary>
        [AttributeLogicalName("actualclosedate")]
        public DateTime? ActualCloseDate
        {
            get { return GetAttributeValue<DateTime?>("actualclosedate"); }
            set
            {
                OnPropertyChanging("ActualCloseDate");
                SetAttributeValue("actualclosedate", value);
                OnPropertyChanged("ActualCloseDate");
            }
        }

        /// <summary>
        ///     Type the actual revenue amount for the opportunity for reporting and analysis of estimated versus actual sales.
        ///     Field defaults to the Est. Revenue value when an opportunity is won.
        /// </summary>
        [AttributeLogicalName("actualvalue")]
        public Money ActualValue
        {
            get { return GetAttributeValue<Money>("actualvalue"); }
            set
            {
                OnPropertyChanging("ActualValue");
                SetAttributeValue("actualvalue", value);
                OnPropertyChanged("ActualValue");
            }
        }

        /// <summary>
        ///     Shows the Actual Revenue field converted to the system's default base currency for reporting purposes. The
        ///     calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("actualvalue_base")]
        public Money ActualValue_Base
        {
            get { return GetAttributeValue<Money>("actualvalue_base"); }
        }

        /// <summary>
        ///     Type a value between 0 and 1,000,000,000,000 to indicate the lead's potential available budget.
        /// </summary>
        [AttributeLogicalName("budgetamount")]
        public Money BudgetAmount
        {
            get { return GetAttributeValue<Money>("budgetamount"); }
            set
            {
                OnPropertyChanging("BudgetAmount");
                SetAttributeValue("budgetamount", value);
                OnPropertyChanged("BudgetAmount");
            }
        }

        /// <summary>
        ///     Shows the budget amount converted to the system's base currency.
        /// </summary>
        [AttributeLogicalName("budgetamount_base")]
        public Money BudgetAmount_Base
        {
            get { return GetAttributeValue<Money>("budgetamount_base"); }
        }

        /// <summary>
        ///     Select the likely budget status for the lead's company. This may help determine the lead rating or your sales
        ///     approach.
        /// </summary>
        [AttributeLogicalName("budgetstatus")]
        public OptionSetValue BudgetStatus
        {
            get { return GetAttributeValue<OptionSetValue>("budgetstatus"); }
            set
            {
                OnPropertyChanging("BudgetStatus");
                SetAttributeValue("budgetstatus", value);
                OnPropertyChanged("BudgetStatus");
            }
        }

        /// <summary>
        ///     Shows the campaign that the opportunity was created from. The ID is used for tracking the success of the campaign.
        /// </summary>
        [AttributeLogicalName("campaignid")]
        public EntityReference CampaignId
        {
            get { return GetAttributeValue<EntityReference>("campaignid"); }
            set
            {
                OnPropertyChanging("CampaignId");
                SetAttributeValue("campaignid", value);
                OnPropertyChanged("CampaignId");
            }
        }

        /// <summary>
        ///     Choose whether the proposal feedback has been captured for the opportunity.
        /// </summary>
        [AttributeLogicalName("captureproposalfeedback")]
        public bool? CaptureProposalFeedback
        {
            get { return GetAttributeValue<bool?>("captureproposalfeedback"); }
            set
            {
                OnPropertyChanging("CaptureProposalFeedback");
                SetAttributeValue("captureproposalfeedback", value);
                OnPropertyChanged("CaptureProposalFeedback");
            }
        }

        /// <summary>
        ///     Type a number from 0 to 100 that represents the likelihood of closing the opportunity. This can aid the sales team
        ///     in their efforts to convert the opportunity in a sale.
        /// </summary>
        [AttributeLogicalName("closeprobability")]
        public int? CloseProbability
        {
            get { return GetAttributeValue<int?>("closeprobability"); }
            set
            {
                OnPropertyChanging("CloseProbability");
                SetAttributeValue("closeprobability", value);
                OnPropertyChanged("CloseProbability");
            }
        }

        /// <summary>
        ///     Select whether a final proposal has been completed for the opportunity.
        /// </summary>
        [AttributeLogicalName("completefinalproposal")]
        public bool? CompleteFinalProposal
        {
            get { return GetAttributeValue<bool?>("completefinalproposal"); }
            set
            {
                OnPropertyChanging("CompleteFinalProposal");
                SetAttributeValue("completefinalproposal", value);
                OnPropertyChanged("CompleteFinalProposal");
            }
        }

        /// <summary>
        ///     Select whether an internal review has been completed for this opportunity.
        /// </summary>
        [AttributeLogicalName("completeinternalreview")]
        public bool? CompleteInternalReview
        {
            get { return GetAttributeValue<bool?>("completeinternalreview"); }
            set
            {
                OnPropertyChanging("CompleteInternalReview");
                SetAttributeValue("completeinternalreview", value);
                OnPropertyChanged("CompleteInternalReview");
            }
        }

        /// <summary>
        ///     Select whether the lead confirmed interest in your offerings. This helps in determining the lead quality and the
        ///     probability of it turning into an opportunity.
        /// </summary>
        [AttributeLogicalName("confirminterest")]
        public bool? ConfirmInterest
        {
            get { return GetAttributeValue<bool?>("confirminterest"); }
            set
            {
                OnPropertyChanging("ConfirmInterest");
                SetAttributeValue("confirminterest", value);
                OnPropertyChanged("ConfirmInterest");
            }
        }

        /// <summary>
        ///     Unique identifier of the contact associated with the opportunity.
        /// </summary>
        [AttributeLogicalName("contactid")]
        public EntityReference ContactId
        {
            get { return GetAttributeValue<EntityReference>("contactid"); }
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
        ///     Type notes about the company or organization associated with the opportunity.
        /// </summary>
        [AttributeLogicalName("currentsituation")]
        public string CurrentSituation
        {
            get { return GetAttributeValue<string>("currentsituation"); }
            set
            {
                OnPropertyChanging("CurrentSituation");
                SetAttributeValue("currentsituation", value);
                OnPropertyChanged("CurrentSituation");
            }
        }

        /// <summary>
        ///     Select the customer account or contact to provide a quick link to additional customer details, such as address,
        ///     phone number, activities, and orders.
        /// </summary>
        [AttributeLogicalName("customerid")]
        public EntityReference CustomerId
        {
            get { return GetAttributeValue<EntityReference>("customerid"); }
            set
            {
                OnPropertyChanging("CustomerId");
                SetAttributeValue("customerid", value);
                OnPropertyChanged("CustomerId");
            }
        }

        /// <summary>
        ///     Type some notes about the customer's requirements, to help the sales team identify products and services that could
        ///     meet their requirements.
        /// </summary>
        [AttributeLogicalName("customerneed")]
        public string CustomerNeed
        {
            get { return GetAttributeValue<string>("customerneed"); }
            set
            {
                OnPropertyChanging("CustomerNeed");
                SetAttributeValue("customerneed", value);
                OnPropertyChanged("CustomerNeed");
            }
        }

        /// <summary>
        ///     Type notes about the customer's pain points to help the sales team identify products and services that could
        ///     address these pain points.
        /// </summary>
        [AttributeLogicalName("customerpainpoints")]
        public string CustomerPainPoints
        {
            get { return GetAttributeValue<string>("customerpainpoints"); }
            set
            {
                OnPropertyChanging("CustomerPainPoints");
                SetAttributeValue("customerpainpoints", value);
                OnPropertyChanged("CustomerPainPoints");
            }
        }

        /// <summary>
        ///     Select whether your notes include information about who makes the purchase decisions at the lead's company.
        /// </summary>
        [AttributeLogicalName("decisionmaker")]
        public bool? DecisionMaker
        {
            get { return GetAttributeValue<bool?>("decisionmaker"); }
            set
            {
                OnPropertyChanging("DecisionMaker");
                SetAttributeValue("decisionmaker", value);
                OnPropertyChanged("DecisionMaker");
            }
        }

        /// <summary>
        ///     Type additional information to describe the opportunity, such as possible products to sell or past purchases from
        ///     the customer.
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
        ///     Select whether a proposal has been developed for the opportunity.
        /// </summary>
        [AttributeLogicalName("developproposal")]
        public bool? DevelopProposal
        {
            get { return GetAttributeValue<bool?>("developproposal"); }
            set
            {
                OnPropertyChanging("DevelopProposal");
                SetAttributeValue("developproposal", value);
                OnPropertyChanged("DevelopProposal");
            }
        }

        /// <summary>
        ///     Type the discount amount for the opportunity if the customer is eligible for special savings.
        /// </summary>
        [AttributeLogicalName("discountamount")]
        public Money DiscountAmount
        {
            get { return GetAttributeValue<Money>("discountamount"); }
            set
            {
                OnPropertyChanging("DiscountAmount");
                SetAttributeValue("discountamount", value);
                OnPropertyChanged("DiscountAmount");
            }
        }

        /// <summary>
        ///     Shows the Opportunity Discount Amount field converted to the system's default base currency for reporting purposes.
        ///     The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("discountamount_base")]
        public Money DiscountAmount_Base
        {
            get { return GetAttributeValue<Money>("discountamount_base"); }
        }

        /// <summary>
        ///     Type the discount rate that should be applied to the Product Totals field to include additional savings for the
        ///     customer in the opportunity.
        /// </summary>
        [AttributeLogicalName("discountpercentage")]
        public decimal? DiscountPercentage
        {
            get { return GetAttributeValue<decimal?>("discountpercentage"); }
            set
            {
                OnPropertyChanging("DiscountPercentage");
                SetAttributeValue("discountpercentage", value);
                OnPropertyChanged("DiscountPercentage");
            }
        }

        /// <summary>
        ///     Enter the expected closing date of the opportunity to help make accurate revenue forecasts.
        /// </summary>
        [AttributeLogicalName("estimatedclosedate")]
        public DateTime? EstimatedCloseDate
        {
            get { return GetAttributeValue<DateTime?>("estimatedclosedate"); }
            set
            {
                OnPropertyChanging("EstimatedCloseDate");
                SetAttributeValue("estimatedclosedate", value);
                OnPropertyChanged("EstimatedCloseDate");
            }
        }

        /// <summary>
        ///     Type the estimated revenue amount to indicate the potential sale or value of the opportunity for revenue
        ///     forecasting. This field can be either system-populated or editable based on the selection in the Revenue field.
        /// </summary>
        [AttributeLogicalName("estimatedvalue")]
        public Money EstimatedValue
        {
            get { return GetAttributeValue<Money>("estimatedvalue"); }
            set
            {
                OnPropertyChanging("EstimatedValue");
                SetAttributeValue("estimatedvalue", value);
                OnPropertyChanged("EstimatedValue");
            }
        }

        /// <summary>
        ///     Shows the Actual Revenue field converted to the system's default base currency for reporting purposes. The
        ///     calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("estimatedvalue_base")]
        public Money EstimatedValue_Base
        {
            get { return GetAttributeValue<Money>("estimatedvalue_base"); }
        }

        /// <summary>
        ///     Select whether the fit between the lead's requirements and your offerings was evaluated.
        /// </summary>
        [AttributeLogicalName("evaluatefit")]
        public bool? EvaluateFit
        {
            get { return GetAttributeValue<bool?>("evaluatefit"); }
            set
            {
                OnPropertyChanging("EvaluateFit");
                SetAttributeValue("evaluatefit", value);
                OnPropertyChanged("EvaluateFit");
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
        ///     Choose whether the sales team has recorded detailed notes on the proposals and the account's responses.
        /// </summary>
        [AttributeLogicalName("filedebrief")]
        public bool? FileDebrief
        {
            get { return GetAttributeValue<bool?>("filedebrief"); }
            set
            {
                OnPropertyChanging("FileDebrief");
                SetAttributeValue("filedebrief", value);
                OnPropertyChanged("FileDebrief");
            }
        }

        /// <summary>
        ///     Enter the date and time when the final decision of the opportunity was made.
        /// </summary>
        [AttributeLogicalName("finaldecisiondate")]
        public DateTime? FinalDecisionDate
        {
            get { return GetAttributeValue<DateTime?>("finaldecisiondate"); }
            set
            {
                OnPropertyChanging("FinalDecisionDate");
                SetAttributeValue("finaldecisiondate", value);
                OnPropertyChanged("FinalDecisionDate");
            }
        }

        /// <summary>
        ///     Type the cost of freight or shipping for the products included in the opportunity for use in calculating the Total
        ///     Amount field.
        /// </summary>
        [AttributeLogicalName("freightamount")]
        public Money FreightAmount
        {
            get { return GetAttributeValue<Money>("freightamount"); }
            set
            {
                OnPropertyChanging("FreightAmount");
                SetAttributeValue("freightamount", value);
                OnPropertyChanged("FreightAmount");
            }
        }

        /// <summary>
        ///     Shows the Freight Amount field converted to the system's default base currency for reporting purposes. The
        ///     calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("freightamount_base")]
        public Money FreightAmount_Base
        {
            get { return GetAttributeValue<Money>("freightamount_base"); }
        }

        /// <summary>
        ///     Select whether information about competitors is included.
        /// </summary>
        [AttributeLogicalName("identifycompetitors")]
        public bool? IdentifyCompetitors
        {
            get { return GetAttributeValue<bool?>("identifycompetitors"); }
            set
            {
                OnPropertyChanging("IdentifyCompetitors");
                SetAttributeValue("identifycompetitors", value);
                OnPropertyChanged("IdentifyCompetitors");
            }
        }

        /// <summary>
        ///     Select whether the customer contacts for this opportunity have been identified.
        /// </summary>
        [AttributeLogicalName("identifycustomercontacts")]
        public bool? IdentifyCustomerContacts
        {
            get { return GetAttributeValue<bool?>("identifycustomercontacts"); }
            set
            {
                OnPropertyChanging("IdentifyCustomerContacts");
                SetAttributeValue("identifycustomercontacts", value);
                OnPropertyChanged("IdentifyCustomerContacts");
            }
        }

        /// <summary>
        ///     Choose whether you have recorded who will pursue the opportunity.
        /// </summary>
        [AttributeLogicalName("identifypursuitteam")]
        public bool? IdentifyPursuitTeam
        {
            get { return GetAttributeValue<bool?>("identifypursuitteam"); }
            set
            {
                OnPropertyChanging("IdentifyPursuitTeam");
                SetAttributeValue("identifypursuitteam", value);
                OnPropertyChanged("IdentifyPursuitTeam");
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
        ///     Choose whether someone from the sales team contacted this lead earlier.
        /// </summary>
        [AttributeLogicalName("initialcommunication")]
        public OptionSetValue InitialCommunication
        {
            get { return GetAttributeValue<OptionSetValue>("initialcommunication"); }
            set
            {
                OnPropertyChanging("InitialCommunication");
                SetAttributeValue("initialcommunication", value);
                OnPropertyChanged("InitialCommunication");
            }
        }

        /// <summary>
        ///     Select whether the estimated revenue for the opportunity is calculated automatically based on the products entered
        ///     or entered manually by a user.
        /// </summary>
        [AttributeLogicalName("isrevenuesystemcalculated")]
        public bool? IsRevenueSystemCalculated
        {
            get { return GetAttributeValue<bool?>("isrevenuesystemcalculated"); }
            set
            {
                OnPropertyChanging("IsRevenueSystemCalculated");
                SetAttributeValue("isrevenuesystemcalculated", value);
                OnPropertyChanged("IsRevenueSystemCalculated");
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
        ///     Type a subject or descriptive name, such as the expected order or company name, for the opportunity.
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
        ///     Choose how high the level of need is for the lead's company.
        /// </summary>
        [AttributeLogicalName("need")]
        public OptionSetValue Need
        {
            get { return GetAttributeValue<OptionSetValue>("need"); }
            set
            {
                OnPropertyChanging("Need");
                SetAttributeValue("need", value);
                OnPropertyChanged("Need");
            }
        }

        /// <summary>
        ///     Unique identifier of the opportunity.
        /// </summary>
        [AttributeLogicalName("opportunityid")]
        public Guid? OpportunityId
        {
            get { return GetAttributeValue<Guid?>("opportunityid"); }
            set
            {
                OnPropertyChanging("OpportunityId");
                SetAttributeValue("opportunityid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("OpportunityId");
            }
        }

        [AttributeLogicalName("opportunityid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { OpportunityId = value; }
        }

        /// <summary>
        ///     Select the expected value or priority of the opportunity based on revenue, customer status, or closing probability.
        /// </summary>
        [AttributeLogicalName("opportunityratingcode")]
        public OptionSetValue OpportunityRatingCode
        {
            get { return GetAttributeValue<OptionSetValue>("opportunityratingcode"); }
            set
            {
                OnPropertyChanging("OpportunityRatingCode");
                SetAttributeValue("opportunityratingcode", value);
                OnPropertyChanged("OpportunityRatingCode");
            }
        }

        /// <summary>
        ///     Choose the lead that the opportunity was created from for reporting and analytics. The field is read-only after the
        ///     opportunity is created and defaults to the correct lead when an opportunity is created from a converted lead.
        /// </summary>
        [AttributeLogicalName("originatingleadid")]
        public EntityReference OriginatingLeadId
        {
            get { return GetAttributeValue<EntityReference>("originatingleadid"); }
            set
            {
                OnPropertyChanging("OriginatingLeadId");
                SetAttributeValue("originatingleadid", value);
                OnPropertyChanged("OriginatingLeadId");
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
        ///     Unique identifier of the business unit that owns the opportunity.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the opportunity.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the opportunity.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Choose an account to connect this opportunity to, so that the relationship is visible in reports and analytics, and
        ///     to provide a quick link to additional details, such as financial information and activities.
        /// </summary>
        [AttributeLogicalName("parentaccountid")]
        public EntityReference ParentAccountId
        {
            get { return GetAttributeValue<EntityReference>("parentaccountid"); }
            set
            {
                OnPropertyChanging("ParentAccountId");
                SetAttributeValue("parentaccountid", value);
                OnPropertyChanged("ParentAccountId");
            }
        }

        /// <summary>
        ///     Choose a contact to connect this opportunity to, so that the relationship is visible in reports and analytics.
        /// </summary>
        [AttributeLogicalName("parentcontactid")]
        public EntityReference ParentContactId
        {
            get { return GetAttributeValue<EntityReference>("parentcontactid"); }
            set
            {
                OnPropertyChanging("ParentContactId");
                SetAttributeValue("parentcontactid", value);
                OnPropertyChanged("ParentContactId");
            }
        }

        /// <summary>
        ///     Information about whether the opportunity participates in workflow rules.
        /// </summary>
        [AttributeLogicalName("participatesinworkflow")]
        public bool? ParticipatesInWorkflow
        {
            get { return GetAttributeValue<bool?>("participatesinworkflow"); }
            set
            {
                OnPropertyChanging("ParticipatesInWorkflow");
                SetAttributeValue("participatesinworkflow", value);
                OnPropertyChanged("ParticipatesInWorkflow");
            }
        }

        /// <summary>
        ///     Select whether the final proposal has been presented to the account.
        /// </summary>
        [AttributeLogicalName("presentfinalproposal")]
        public bool? PresentFinalProposal
        {
            get { return GetAttributeValue<bool?>("presentfinalproposal"); }
            set
            {
                OnPropertyChanging("PresentFinalProposal");
                SetAttributeValue("presentfinalproposal", value);
                OnPropertyChanged("PresentFinalProposal");
            }
        }

        /// <summary>
        ///     Select whether a proposal for the opportunity has been presented to the account.
        /// </summary>
        [AttributeLogicalName("presentproposal")]
        public bool? PresentProposal
        {
            get { return GetAttributeValue<bool?>("presentproposal"); }
            set
            {
                OnPropertyChanging("PresentProposal");
                SetAttributeValue("presentproposal", value);
                OnPropertyChanged("PresentProposal");
            }
        }

        /// <summary>
        ///     Choose the price list associated with this record to make sure the products associated with the campaign are
        ///     offered at the correct prices.
        /// </summary>
        [AttributeLogicalName("pricelevelid")]
        public EntityReference PriceLevelId
        {
            get { return GetAttributeValue<EntityReference>("pricelevelid"); }
            set
            {
                OnPropertyChanging("PriceLevelId");
                SetAttributeValue("pricelevelid", value);
                OnPropertyChanged("PriceLevelId");
            }
        }

        /// <summary>
        ///     Pricing error for the opportunity.
        /// </summary>
        [AttributeLogicalName("pricingerrorcode")]
        public OptionSetValue PricingErrorCode
        {
            get { return GetAttributeValue<OptionSetValue>("pricingerrorcode"); }
            set
            {
                OnPropertyChanging("PricingErrorCode");
                SetAttributeValue("pricingerrorcode", value);
                OnPropertyChanged("PricingErrorCode");
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
        ///     Type notes about the proposed solution for the opportunity.
        /// </summary>
        [AttributeLogicalName("proposedsolution")]
        public string ProposedSolution
        {
            get { return GetAttributeValue<string>("proposedsolution"); }
            set
            {
                OnPropertyChanging("ProposedSolution");
                SetAttributeValue("proposedsolution", value);
                OnPropertyChanged("ProposedSolution");
            }
        }

        /// <summary>
        ///     Choose whether an individual or a committee will be involved in the purchase process for the lead.
        /// </summary>
        [AttributeLogicalName("purchaseprocess")]
        public OptionSetValue PurchaseProcess
        {
            get { return GetAttributeValue<OptionSetValue>("purchaseprocess"); }
            set
            {
                OnPropertyChanging("PurchaseProcess");
                SetAttributeValue("purchaseprocess", value);
                OnPropertyChanged("PurchaseProcess");
            }
        }

        /// <summary>
        ///     Choose how long the lead will likely take to make the purchase.
        /// </summary>
        [AttributeLogicalName("purchasetimeframe")]
        public OptionSetValue PurchaseTimeframe
        {
            get { return GetAttributeValue<OptionSetValue>("purchasetimeframe"); }
            set
            {
                OnPropertyChanging("PurchaseTimeframe");
                SetAttributeValue("purchasetimeframe", value);
                OnPropertyChanged("PurchaseTimeframe");
            }
        }

        /// <summary>
        ///     Select whether the decision about pursuing the opportunity has been made.
        /// </summary>
        [AttributeLogicalName("pursuitdecision")]
        public bool? PursuitDecision
        {
            get { return GetAttributeValue<bool?>("pursuitdecision"); }
            set
            {
                OnPropertyChanging("PursuitDecision");
                SetAttributeValue("pursuitdecision", value);
                OnPropertyChanged("PursuitDecision");
            }
        }

        /// <summary>
        ///     Type comments about the qualification or scoring of the lead.
        /// </summary>
        [AttributeLogicalName("qualificationcomments")]
        public string QualificationComments
        {
            get { return GetAttributeValue<string>("qualificationcomments"); }
            set
            {
                OnPropertyChanging("QualificationComments");
                SetAttributeValue("qualificationcomments", value);
                OnPropertyChanged("QualificationComments");
            }
        }

        /// <summary>
        ///     Type comments about the quotes associated with the opportunity.
        /// </summary>
        [AttributeLogicalName("quotecomments")]
        public string QuoteComments
        {
            get { return GetAttributeValue<string>("quotecomments"); }
            set
            {
                OnPropertyChanging("QuoteComments");
                SetAttributeValue("quotecomments", value);
                OnPropertyChanged("QuoteComments");
            }
        }

        /// <summary>
        ///     Choose whether the proposal feedback has been captured and resolved for the opportunity.
        /// </summary>
        [AttributeLogicalName("resolvefeedback")]
        public bool? ResolveFeedback
        {
            get { return GetAttributeValue<bool?>("resolvefeedback"); }
            set
            {
                OnPropertyChanging("ResolveFeedback");
                SetAttributeValue("resolvefeedback", value);
                OnPropertyChanged("ResolveFeedback");
            }
        }

        /// <summary>
        ///     Select the sales stage of this opportunity to aid the sales team in their efforts to win this opportunity.
        /// </summary>
        [AttributeLogicalName("salesstage")]
        public OptionSetValue SalesStage
        {
            get { return GetAttributeValue<OptionSetValue>("salesstage"); }
            set
            {
                OnPropertyChanging("SalesStage");
                SetAttributeValue("salesstage", value);
                OnPropertyChanged("SalesStage");
            }
        }

        /// <summary>
        ///     Select the sales process stage for the opportunity to indicate the probability of closing the opportunity.
        /// </summary>
        [AttributeLogicalName("salesstagecode")]
        public OptionSetValue SalesStageCode
        {
            get { return GetAttributeValue<OptionSetValue>("salesstagecode"); }
            set
            {
                OnPropertyChanging("SalesStageCode");
                SetAttributeValue("salesstagecode", value);
                OnPropertyChanged("SalesStageCode");
            }
        }

        /// <summary>
        ///     Enter the date and time of the prospecting follow-up meeting with the lead.
        /// </summary>
        [AttributeLogicalName("schedulefollowup_prospect")]
        public DateTime? ScheduleFollowup_Prospect
        {
            get { return GetAttributeValue<DateTime?>("schedulefollowup_prospect"); }
            set
            {
                OnPropertyChanging("ScheduleFollowup_Prospect");
                SetAttributeValue("schedulefollowup_prospect", value);
                OnPropertyChanged("ScheduleFollowup_Prospect");
            }
        }

        /// <summary>
        ///     Enter the date and time of the qualifying follow-up meeting with the lead.
        /// </summary>
        [AttributeLogicalName("schedulefollowup_qualify")]
        public DateTime? ScheduleFollowup_Qualify
        {
            get { return GetAttributeValue<DateTime?>("schedulefollowup_qualify"); }
            set
            {
                OnPropertyChanging("ScheduleFollowup_Qualify");
                SetAttributeValue("schedulefollowup_qualify", value);
                OnPropertyChanged("ScheduleFollowup_Qualify");
            }
        }

        /// <summary>
        ///     Enter the date and time of the proposal meeting for the opportunity.
        /// </summary>
        [AttributeLogicalName("scheduleproposalmeeting")]
        public DateTime? ScheduleProposalMeeting
        {
            get { return GetAttributeValue<DateTime?>("scheduleproposalmeeting"); }
            set
            {
                OnPropertyChanging("ScheduleProposalMeeting");
                SetAttributeValue("scheduleproposalmeeting", value);
                OnPropertyChanged("ScheduleProposalMeeting");
            }
        }

        /// <summary>
        ///     Select whether a thank you note has been sent to the account for considering the proposal.
        /// </summary>
        [AttributeLogicalName("sendthankyounote")]
        public bool? SendThankYouNote
        {
            get { return GetAttributeValue<bool?>("sendthankyounote"); }
            set
            {
                OnPropertyChanging("SendThankYouNote");
                SetAttributeValue("sendthankyounote", value);
                OnPropertyChanged("SendThankYouNote");
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
        ///     Shows whether the opportunity is open, won, or lost. Won and lost opportunities are read-only and can't be edited
        ///     until they are reactivated.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public OpportunityState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((OpportunityState) (Enum.ToObject(typeof (OpportunityState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Select the opportunity's status.
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
        ///     Shows the ID of the workflow step.
        /// </summary>
        [AttributeLogicalName("stepid")]
        public Guid? StepId
        {
            get { return GetAttributeValue<Guid?>("stepid"); }
            set
            {
                OnPropertyChanging("StepId");
                SetAttributeValue("stepid", value);
                OnPropertyChanged("StepId");
            }
        }

        /// <summary>
        ///     Shows the current phase in the sales pipeline for the opportunity. This is updated by a workflow.
        /// </summary>
        [AttributeLogicalName("stepname")]
        public string StepName
        {
            get { return GetAttributeValue<string>("stepname"); }
            set
            {
                OnPropertyChanging("StepName");
                SetAttributeValue("stepname", value);
                OnPropertyChanged("StepName");
            }
        }

        /// <summary>
        ///     Select when the opportunity is likely to be closed.
        /// </summary>
        [AttributeLogicalName("timeline")]
        public OptionSetValue TimeLine
        {
            get { return GetAttributeValue<OptionSetValue>("timeline"); }
            set
            {
                OnPropertyChanging("TimeLine");
                SetAttributeValue("timeline", value);
                OnPropertyChanged("TimeLine");
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
        ///     Shows the total amount due, calculated as the sum of the products, discounts, freight, and taxes for the
        ///     opportunity.
        /// </summary>
        [AttributeLogicalName("totalamount")]
        public Money TotalAmount
        {
            get { return GetAttributeValue<Money>("totalamount"); }
        }

        /// <summary>
        ///     Shows the Total Amount field converted to the system's default base currency for reporting purposes. The
        ///     calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("totalamount_base")]
        public Money TotalAmount_Base
        {
            get { return GetAttributeValue<Money>("totalamount_base"); }
        }

        /// <summary>
        ///     Shows the total product amount for the opportunity, minus any discounts. This value is added to freight and tax
        ///     amounts in the calculation for the total amount of the opportunity.
        /// </summary>
        [AttributeLogicalName("totalamountlessfreight")]
        public Money TotalAmountLessFreight
        {
            get { return GetAttributeValue<Money>("totalamountlessfreight"); }
        }

        /// <summary>
        ///     Shows the Total Pre-Freight Amount field converted to the system's default base currency for reporting purposes.
        ///     The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("totalamountlessfreight_base")]
        public Money TotalAmountLessFreight_Base
        {
            get { return GetAttributeValue<Money>("totalamountlessfreight_base"); }
        }

        /// <summary>
        ///     Shows the total discount amount, based on the discount price and rate entered on the opportunity.
        /// </summary>
        [AttributeLogicalName("totaldiscountamount")]
        public Money TotalDiscountAmount
        {
            get { return GetAttributeValue<Money>("totaldiscountamount"); }
        }

        /// <summary>
        ///     Shows the Total Discount Amount field converted to the system's default base currency for reporting purposes. The
        ///     calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("totaldiscountamount_base")]
        public Money TotalDiscountAmount_Base
        {
            get { return GetAttributeValue<Money>("totaldiscountamount_base"); }
        }

        /// <summary>
        ///     Shows the sum of all existing and write-in products included on the opportunity, based on the specified price list
        ///     and quantities.
        /// </summary>
        [AttributeLogicalName("totallineitemamount")]
        public Money TotalLineItemAmount
        {
            get { return GetAttributeValue<Money>("totallineitemamount"); }
        }

        /// <summary>
        ///     Shows the Total Detail Amount field converted to the system's default base currency for reporting purposes. The
        ///     calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("totallineitemamount_base")]
        public Money TotalLineItemAmount_Base
        {
            get { return GetAttributeValue<Money>("totallineitemamount_base"); }
        }

        /// <summary>
        ///     Shows the total of the Manual Discount amounts specified on all products included in the opportunity. This value is
        ///     reflected in the Total Detail Amount field on the opportunity and is added to any discount amount or rate specified
        ///     on the opportunity.
        /// </summary>
        [AttributeLogicalName("totallineitemdiscountamount")]
        public Money TotalLineItemDiscountAmount
        {
            get { return GetAttributeValue<Money>("totallineitemdiscountamount"); }
        }

        /// <summary>
        ///     Shows the Total Line Item Discount Amount field to the system's default base currency for reporting purposes. The
        ///     calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("totallineitemdiscountamount_base")]
        public Money TotalLineItemDiscountAmount_Base
        {
            get { return GetAttributeValue<Money>("totallineitemdiscountamount_base"); }
        }

        /// <summary>
        ///     Shows the total of the Tax amounts specified on all products included in the opportunity, included in the Total
        ///     Amount field calculation for the opportunity.
        /// </summary>
        [AttributeLogicalName("totaltax")]
        public Money TotalTax
        {
            get { return GetAttributeValue<Money>("totaltax"); }
        }

        /// <summary>
        ///     Shows the Total Tax field converted to the system's default base currency for reporting purposes. The calculation
        ///     uses the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("totaltax_base")]
        public Money TotalTax_Base
        {
            get { return GetAttributeValue<Money>("totaltax_base"); }
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
        ///     Version number of the opportunity.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N CreatedOpportunity_BulkOperationLogs
        /// </summary>
        [RelationshipSchemaName("CreatedOpportunity_BulkOperationLogs")]
        public IEnumerable<BulkOperationLog> CreatedOpportunity_BulkOperationLogs
        {
            get { return GetRelatedEntities<BulkOperationLog>("CreatedOpportunity_BulkOperationLogs", null); }
            set
            {
                OnPropertyChanging("CreatedOpportunity_BulkOperationLogs");
                SetRelatedEntities("CreatedOpportunity_BulkOperationLogs", null, value);
                OnPropertyChanged("CreatedOpportunity_BulkOperationLogs");
            }
        }

        /// <summary>
        ///     1:N lead_qualifying_opportunity
        /// </summary>
        [RelationshipSchemaName("lead_qualifying_opportunity")]
        public IEnumerable<Lead> lead_qualifying_opportunity
        {
            get { return GetRelatedEntities<Lead>("lead_qualifying_opportunity", null); }
            set
            {
                OnPropertyChanging("lead_qualifying_opportunity");
                SetRelatedEntities("lead_qualifying_opportunity", null, value);
                OnPropertyChanged("lead_qualifying_opportunity");
            }
        }

        /// <summary>
        ///     1:N opportunity_activity_parties
        /// </summary>
        [RelationshipSchemaName("opportunity_activity_parties")]
        public IEnumerable<ActivityParty> opportunity_activity_parties
        {
            get { return GetRelatedEntities<ActivityParty>("opportunity_activity_parties", null); }
            set
            {
                OnPropertyChanging("opportunity_activity_parties");
                SetRelatedEntities("opportunity_activity_parties", null, value);
                OnPropertyChanged("opportunity_activity_parties");
            }
        }

        /// <summary>
        ///     1:N Opportunity_ActivityPointers
        /// </summary>
        [RelationshipSchemaName("Opportunity_ActivityPointers")]
        public IEnumerable<ActivityPointer> Opportunity_ActivityPointers
        {
            get { return GetRelatedEntities<ActivityPointer>("Opportunity_ActivityPointers", null); }
            set
            {
                OnPropertyChanging("Opportunity_ActivityPointers");
                SetRelatedEntities("Opportunity_ActivityPointers", null, value);
                OnPropertyChanged("Opportunity_ActivityPointers");
            }
        }

        /// <summary>
        ///     1:N Opportunity_Annotation
        /// </summary>
        [RelationshipSchemaName("Opportunity_Annotation")]
        public IEnumerable<Annotation> Opportunity_Annotation
        {
            get { return GetRelatedEntities<Annotation>("Opportunity_Annotation", null); }
            set
            {
                OnPropertyChanging("Opportunity_Annotation");
                SetRelatedEntities("Opportunity_Annotation", null, value);
                OnPropertyChanged("Opportunity_Annotation");
            }
        }

        /// <summary>
        ///     1:N Opportunity_Appointments
        /// </summary>
        [RelationshipSchemaName("Opportunity_Appointments")]
        public IEnumerable<Appointment> Opportunity_Appointments
        {
            get { return GetRelatedEntities<Appointment>("Opportunity_Appointments", null); }
            set
            {
                OnPropertyChanging("Opportunity_Appointments");
                SetRelatedEntities("Opportunity_Appointments", null, value);
                OnPropertyChanged("Opportunity_Appointments");
            }
        }

        /// <summary>
        ///     1:N Opportunity_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Opportunity_AsyncOperations")]
        public IEnumerable<AsyncOperation> Opportunity_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Opportunity_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Opportunity_AsyncOperations");
                SetRelatedEntities("Opportunity_AsyncOperations", null, value);
                OnPropertyChanged("Opportunity_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N Opportunity_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("Opportunity_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> Opportunity_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("Opportunity_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("Opportunity_BulkDeleteFailures");
                SetRelatedEntities("Opportunity_BulkDeleteFailures", null, value);
                OnPropertyChanged("Opportunity_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N opportunity_connections1
        /// </summary>
        [RelationshipSchemaName("opportunity_connections1")]
        public IEnumerable<Connection> opportunity_connections1
        {
            get { return GetRelatedEntities<Connection>("opportunity_connections1", null); }
            set
            {
                OnPropertyChanging("opportunity_connections1");
                SetRelatedEntities("opportunity_connections1", null, value);
                OnPropertyChanged("opportunity_connections1");
            }
        }

        /// <summary>
        ///     1:N opportunity_connections2
        /// </summary>
        [RelationshipSchemaName("opportunity_connections2")]
        public IEnumerable<Connection> opportunity_connections2
        {
            get { return GetRelatedEntities<Connection>("opportunity_connections2", null); }
            set
            {
                OnPropertyChanging("opportunity_connections2");
                SetRelatedEntities("opportunity_connections2", null, value);
                OnPropertyChanged("opportunity_connections2");
            }
        }

        /// <summary>
        ///     1:N opportunity_customer_opportunity_roles
        /// </summary>
        [RelationshipSchemaName("opportunity_customer_opportunity_roles")]
        public IEnumerable<CustomerOpportunityRole> opportunity_customer_opportunity_roles
        {
            get { return GetRelatedEntities<CustomerOpportunityRole>("opportunity_customer_opportunity_roles", null); }
            set
            {
                OnPropertyChanging("opportunity_customer_opportunity_roles");
                SetRelatedEntities("opportunity_customer_opportunity_roles", null, value);
                OnPropertyChanged("opportunity_customer_opportunity_roles");
            }
        }

        /// <summary>
        ///     1:N Opportunity_DuplicateBaseRecord
        /// </summary>
        [RelationshipSchemaName("Opportunity_DuplicateBaseRecord")]
        public IEnumerable<DuplicateRecord> Opportunity_DuplicateBaseRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Opportunity_DuplicateBaseRecord", null); }
            set
            {
                OnPropertyChanging("Opportunity_DuplicateBaseRecord");
                SetRelatedEntities("Opportunity_DuplicateBaseRecord", null, value);
                OnPropertyChanged("Opportunity_DuplicateBaseRecord");
            }
        }

        /// <summary>
        ///     1:N Opportunity_DuplicateMatchingRecord
        /// </summary>
        [RelationshipSchemaName("Opportunity_DuplicateMatchingRecord")]
        public IEnumerable<DuplicateRecord> Opportunity_DuplicateMatchingRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Opportunity_DuplicateMatchingRecord", null); }
            set
            {
                OnPropertyChanging("Opportunity_DuplicateMatchingRecord");
                SetRelatedEntities("Opportunity_DuplicateMatchingRecord", null, value);
                OnPropertyChanged("Opportunity_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        ///     1:N Opportunity_Emails
        /// </summary>
        [RelationshipSchemaName("Opportunity_Emails")]
        public IEnumerable<Email> Opportunity_Emails
        {
            get { return GetRelatedEntities<Email>("Opportunity_Emails", null); }
            set
            {
                OnPropertyChanging("Opportunity_Emails");
                SetRelatedEntities("Opportunity_Emails", null, value);
                OnPropertyChanged("Opportunity_Emails");
            }
        }

        /// <summary>
        ///     1:N Opportunity_Faxes
        /// </summary>
        [RelationshipSchemaName("Opportunity_Faxes")]
        public IEnumerable<Fax> Opportunity_Faxes
        {
            get { return GetRelatedEntities<Fax>("Opportunity_Faxes", null); }
            set
            {
                OnPropertyChanging("Opportunity_Faxes");
                SetRelatedEntities("Opportunity_Faxes", null, value);
                OnPropertyChanged("Opportunity_Faxes");
            }
        }

        /// <summary>
        ///     1:N opportunity_invoices
        /// </summary>
        [RelationshipSchemaName("opportunity_invoices")]
        public IEnumerable<Invoice> opportunity_invoices
        {
            get { return GetRelatedEntities<Invoice>("opportunity_invoices", null); }
            set
            {
                OnPropertyChanging("opportunity_invoices");
                SetRelatedEntities("opportunity_invoices", null, value);
                OnPropertyChanged("opportunity_invoices");
            }
        }

        /// <summary>
        ///     1:N Opportunity_Letters
        /// </summary>
        [RelationshipSchemaName("Opportunity_Letters")]
        public IEnumerable<Letter> Opportunity_Letters
        {
            get { return GetRelatedEntities<Letter>("Opportunity_Letters", null); }
            set
            {
                OnPropertyChanging("Opportunity_Letters");
                SetRelatedEntities("Opportunity_Letters", null, value);
                OnPropertyChanged("Opportunity_Letters");
            }
        }

        /// <summary>
        ///     1:N Opportunity_OpportunityClose
        /// </summary>
        [RelationshipSchemaName("Opportunity_OpportunityClose")]
        public IEnumerable<OpportunityClose> Opportunity_OpportunityClose
        {
            get { return GetRelatedEntities<OpportunityClose>("Opportunity_OpportunityClose", null); }
            set
            {
                OnPropertyChanging("Opportunity_OpportunityClose");
                SetRelatedEntities("Opportunity_OpportunityClose", null, value);
                OnPropertyChanged("Opportunity_OpportunityClose");
            }
        }

        /// <summary>
        ///     1:N Opportunity_Phonecalls
        /// </summary>
        [RelationshipSchemaName("Opportunity_Phonecalls")]
        public IEnumerable<PhoneCall> Opportunity_Phonecalls
        {
            get { return GetRelatedEntities<PhoneCall>("Opportunity_Phonecalls", null); }
            set
            {
                OnPropertyChanging("Opportunity_Phonecalls");
                SetRelatedEntities("Opportunity_Phonecalls", null, value);
                OnPropertyChanged("Opportunity_Phonecalls");
            }
        }

        /// <summary>
        ///     1:N opportunity_PostFollows
        /// </summary>
        [RelationshipSchemaName("opportunity_PostFollows")]
        public IEnumerable<PostFollow> opportunity_PostFollows
        {
            get { return GetRelatedEntities<PostFollow>("opportunity_PostFollows", null); }
            set
            {
                OnPropertyChanging("opportunity_PostFollows");
                SetRelatedEntities("opportunity_PostFollows", null, value);
                OnPropertyChanged("opportunity_PostFollows");
            }
        }

        /// <summary>
        ///     1:N opportunity_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("opportunity_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> opportunity_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntities<PrincipalObjectAttributeAccess>("opportunity_principalobjectattributeaccess",
                    null);
            }
            set
            {
                OnPropertyChanging("opportunity_principalobjectattributeaccess");
                SetRelatedEntities("opportunity_principalobjectattributeaccess", null, value);
                OnPropertyChanged("opportunity_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N Opportunity_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("Opportunity_ProcessSessions")]
        public IEnumerable<ProcessSession> Opportunity_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("Opportunity_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Opportunity_ProcessSessions");
                SetRelatedEntities("Opportunity_ProcessSessions", null, value);
                OnPropertyChanged("Opportunity_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N opportunity_quotes
        /// </summary>
        [RelationshipSchemaName("opportunity_quotes")]
        public IEnumerable<Quote> opportunity_quotes
        {
            get { return GetRelatedEntities<Quote>("opportunity_quotes", null); }
            set
            {
                OnPropertyChanging("opportunity_quotes");
                SetRelatedEntities("opportunity_quotes", null, value);
                OnPropertyChanged("opportunity_quotes");
            }
        }

        /// <summary>
        ///     1:N Opportunity_RecurringAppointmentMasters
        /// </summary>
        [RelationshipSchemaName("Opportunity_RecurringAppointmentMasters")]
        public IEnumerable<RecurringAppointmentMaster> Opportunity_RecurringAppointmentMasters
        {
            get
            {
                return GetRelatedEntities<RecurringAppointmentMaster>("Opportunity_RecurringAppointmentMasters", null);
            }
            set
            {
                OnPropertyChanging("Opportunity_RecurringAppointmentMasters");
                SetRelatedEntities("Opportunity_RecurringAppointmentMasters", null, value);
                OnPropertyChanged("Opportunity_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        ///     1:N opportunity_sales_orders
        /// </summary>
        [RelationshipSchemaName("opportunity_sales_orders")]
        public IEnumerable<SalesOrder> opportunity_sales_orders
        {
            get { return GetRelatedEntities<SalesOrder>("opportunity_sales_orders", null); }
            set
            {
                OnPropertyChanging("opportunity_sales_orders");
                SetRelatedEntities("opportunity_sales_orders", null, value);
                OnPropertyChanged("opportunity_sales_orders");
            }
        }

        /// <summary>
        ///     1:N Opportunity_ServiceAppointments
        /// </summary>
        [RelationshipSchemaName("Opportunity_ServiceAppointments")]
        public IEnumerable<ServiceAppointment> Opportunity_ServiceAppointments
        {
            get { return GetRelatedEntities<ServiceAppointment>("Opportunity_ServiceAppointments", null); }
            set
            {
                OnPropertyChanging("Opportunity_ServiceAppointments");
                SetRelatedEntities("Opportunity_ServiceAppointments", null, value);
                OnPropertyChanged("Opportunity_ServiceAppointments");
            }
        }

        /// <summary>
        ///     1:N Opportunity_SharepointDocumentLocation
        /// </summary>
        [RelationshipSchemaName("Opportunity_SharepointDocumentLocation")]
        public IEnumerable<SharePointDocumentLocation> Opportunity_SharepointDocumentLocation
        {
            get
            {
                return GetRelatedEntities<SharePointDocumentLocation>("Opportunity_SharepointDocumentLocation", null);
            }
            set
            {
                OnPropertyChanging("Opportunity_SharepointDocumentLocation");
                SetRelatedEntities("Opportunity_SharepointDocumentLocation", null, value);
                OnPropertyChanged("Opportunity_SharepointDocumentLocation");
            }
        }

        /// <summary>
        ///     1:N Opportunity_Tasks
        /// </summary>
        [RelationshipSchemaName("Opportunity_Tasks")]
        public IEnumerable<Task> Opportunity_Tasks
        {
            get { return GetRelatedEntities<Task>("Opportunity_Tasks", null); }
            set
            {
                OnPropertyChanging("Opportunity_Tasks");
                SetRelatedEntities("Opportunity_Tasks", null, value);
                OnPropertyChanged("Opportunity_Tasks");
            }
        }

        /// <summary>
        ///     1:N opportunity_Teams
        /// </summary>
        [RelationshipSchemaName("opportunity_Teams")]
        public IEnumerable<Team> opportunity_Teams
        {
            get { return GetRelatedEntities<Team>("opportunity_Teams", null); }
            set
            {
                OnPropertyChanging("opportunity_Teams");
                SetRelatedEntities("opportunity_Teams", null, value);
                OnPropertyChanged("opportunity_Teams");
            }
        }

        /// <summary>
        ///     1:N product_opportunities
        /// </summary>
        [RelationshipSchemaName("product_opportunities")]
        public IEnumerable<OpportunityProduct> product_opportunities
        {
            get { return GetRelatedEntities<OpportunityProduct>("product_opportunities", null); }
            set
            {
                OnPropertyChanging("product_opportunities");
                SetRelatedEntities("product_opportunities", null, value);
                OnPropertyChanged("product_opportunities");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_opportunity
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_opportunity")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_opportunity
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_opportunity", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_opportunity");
                SetRelatedEntities("userentityinstancedata_opportunity", null, value);
                OnPropertyChanged("userentityinstancedata_opportunity");
            }
        }

        /// <summary>
        ///     N:N opportunitycompetitors_association
        /// </summary>
        [RelationshipSchemaName("opportunitycompetitors_association")]
        public IEnumerable<Competitor> opportunitycompetitors_association
        {
            get { return GetRelatedEntities<Competitor>("opportunitycompetitors_association", null); }
            set
            {
                OnPropertyChanging("opportunitycompetitors_association");
                SetRelatedEntities("opportunitycompetitors_association", null, value);
                OnPropertyChanged("opportunitycompetitors_association");
            }
        }

        /// <summary>
        ///     N:1 business_unit_opportunities
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_opportunities")]
        public BusinessUnit business_unit_opportunities
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_opportunities", null); }
        }

        /// <summary>
        ///     N:1 campaign_opportunities
        /// </summary>
        [AttributeLogicalName("campaignid")]
        [RelationshipSchemaName("campaign_opportunities")]
        public Campaign campaign_opportunities
        {
            get { return GetRelatedEntity<Campaign>("campaign_opportunities", null); }
            set
            {
                OnPropertyChanging("campaign_opportunities");
                SetRelatedEntity("campaign_opportunities", null, value);
                OnPropertyChanged("campaign_opportunities");
            }
        }

        /// <summary>
        ///     N:1 lk_opportunity_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_opportunity_createdonbehalfby")]
        public SystemUser lk_opportunity_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_opportunity_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_opportunity_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_opportunity_modifiedonbehalfby")]
        public SystemUser lk_opportunity_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_opportunity_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_opportunitybase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_opportunitybase_createdby")]
        public SystemUser lk_opportunitybase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_opportunitybase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_opportunitybase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_opportunitybase_modifiedby")]
        public SystemUser lk_opportunitybase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_opportunitybase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 opportunity_customer_accounts
        /// </summary>
        [AttributeLogicalName("customerid")]
        [RelationshipSchemaName("opportunity_customer_accounts")]
        public Account opportunity_customer_accounts
        {
            get { return GetRelatedEntity<Account>("opportunity_customer_accounts", null); }
            set
            {
                OnPropertyChanging("opportunity_customer_accounts");
                SetRelatedEntity("opportunity_customer_accounts", null, value);
                OnPropertyChanged("opportunity_customer_accounts");
            }
        }

        /// <summary>
        ///     N:1 opportunity_customer_contacts
        /// </summary>
        [AttributeLogicalName("customerid")]
        [RelationshipSchemaName("opportunity_customer_contacts")]
        public Contact opportunity_customer_contacts
        {
            get { return GetRelatedEntity<Contact>("opportunity_customer_contacts", null); }
            set
            {
                OnPropertyChanging("opportunity_customer_contacts");
                SetRelatedEntity("opportunity_customer_contacts", null, value);
                OnPropertyChanged("opportunity_customer_contacts");
            }
        }

        /// <summary>
        ///     N:1 opportunity_originating_lead
        /// </summary>
        [AttributeLogicalName("originatingleadid")]
        [RelationshipSchemaName("opportunity_originating_lead")]
        public Lead opportunity_originating_lead
        {
            get { return GetRelatedEntity<Lead>("opportunity_originating_lead", null); }
            set
            {
                OnPropertyChanging("opportunity_originating_lead");
                SetRelatedEntity("opportunity_originating_lead", null, value);
                OnPropertyChanged("opportunity_originating_lead");
            }
        }

        /// <summary>
        ///     N:1 opportunity_owning_user
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("opportunity_owning_user")]
        public SystemUser opportunity_owning_user
        {
            get { return GetRelatedEntity<SystemUser>("opportunity_owning_user", null); }
        }

        /// <summary>
        ///     N:1 opportunity_parent_account
        /// </summary>
        [AttributeLogicalName("parentaccountid")]
        [RelationshipSchemaName("opportunity_parent_account")]
        public Account opportunity_parent_account
        {
            get { return GetRelatedEntity<Account>("opportunity_parent_account", null); }
            set
            {
                OnPropertyChanging("opportunity_parent_account");
                SetRelatedEntity("opportunity_parent_account", null, value);
                OnPropertyChanged("opportunity_parent_account");
            }
        }

        /// <summary>
        ///     N:1 opportunity_parent_contact
        /// </summary>
        [AttributeLogicalName("parentcontactid")]
        [RelationshipSchemaName("opportunity_parent_contact")]
        public Contact opportunity_parent_contact
        {
            get { return GetRelatedEntity<Contact>("opportunity_parent_contact", null); }
            set
            {
                OnPropertyChanging("opportunity_parent_contact");
                SetRelatedEntity("opportunity_parent_contact", null, value);
                OnPropertyChanged("opportunity_parent_contact");
            }
        }

        /// <summary>
        ///     N:1 price_level_opportunties
        /// </summary>
        [AttributeLogicalName("pricelevelid")]
        [RelationshipSchemaName("price_level_opportunties")]
        public PriceLevel price_level_opportunties
        {
            get { return GetRelatedEntity<PriceLevel>("price_level_opportunties", null); }
            set
            {
                OnPropertyChanging("price_level_opportunties");
                SetRelatedEntity("price_level_opportunties", null, value);
                OnPropertyChanged("price_level_opportunties");
            }
        }

        /// <summary>
        ///     N:1 processstage_opportunity
        /// </summary>
        [AttributeLogicalName("stageid")]
        [RelationshipSchemaName("processstage_opportunity")]
        public ProcessStage processstage_opportunity
        {
            get { return GetRelatedEntity<ProcessStage>("processstage_opportunity", null); }
            set
            {
                OnPropertyChanging("processstage_opportunity");
                SetRelatedEntity("processstage_opportunity", null, value);
                OnPropertyChanged("processstage_opportunity");
            }
        }

        /// <summary>
        ///     N:1 team_opportunities
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_opportunities")]
        public Team team_opportunities
        {
            get { return GetRelatedEntity<Team>("team_opportunities", null); }
        }

        /// <summary>
        ///     N:1 transactioncurrency_opportunity
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("transactioncurrency_opportunity")]
        public TransactionCurrency transactioncurrency_opportunity
        {
            get { return GetRelatedEntity<TransactionCurrency>("transactioncurrency_opportunity", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_opportunity");
                SetRelatedEntity("transactioncurrency_opportunity", null, value);
                OnPropertyChanged("transactioncurrency_opportunity");
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