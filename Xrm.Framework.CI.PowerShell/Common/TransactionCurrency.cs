using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Xrm.Framework.CI.PowerShell.Common;

namespace Xrm.Framework.CI.Common.Entities
{
    /// <summary>
    ///     Currency in which a financial transaction is carried out.
    /// </summary>
    [DataContract]
    [EntityLogicalName("transactioncurrency")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class TransactionCurrency : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "transactioncurrency";

        public const int EntityTypeCode = 9105;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public TransactionCurrency() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the user who created the transaction currency.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the transaction currency was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the transactioncurrency.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Name of the transaction currency.
        /// </summary>
        [AttributeLogicalName("currencyname")]
        public string CurrencyName
        {
            get { return GetAttributeValue<string>("currencyname"); }
            set
            {
                OnPropertyChanging("CurrencyName");
                SetAttributeValue("currencyname", value);
                OnPropertyChanged("CurrencyName");
            }
        }

        /// <summary>
        ///     Number of decimal places that can be used for currency.
        /// </summary>
        [AttributeLogicalName("currencyprecision")]
        public int? CurrencyPrecision
        {
            get { return GetAttributeValue<int?>("currencyprecision"); }
            set
            {
                OnPropertyChanging("CurrencyPrecision");
                SetAttributeValue("currencyprecision", value);
                OnPropertyChanged("CurrencyPrecision");
            }
        }

        /// <summary>
        ///     Symbol for the transaction currency.
        /// </summary>
        [AttributeLogicalName("currencysymbol")]
        public string CurrencySymbol
        {
            get { return GetAttributeValue<string>("currencysymbol"); }
            set
            {
                OnPropertyChanging("CurrencySymbol");
                SetAttributeValue("currencysymbol", value);
                OnPropertyChanged("CurrencySymbol");
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
        ///     Exchange rate between the transaction currency and the base currency.
        /// </summary>
        [AttributeLogicalName("exchangerate")]
        public decimal? ExchangeRate
        {
            get { return GetAttributeValue<decimal?>("exchangerate"); }
            set
            {
                OnPropertyChanging("ExchangeRate");
                SetAttributeValue("exchangerate", value);
                OnPropertyChanged("ExchangeRate");
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
        ///     ISO currency code for the transaction currency.
        /// </summary>
        [AttributeLogicalName("isocurrencycode")]
        public string ISOCurrencyCode
        {
            get { return GetAttributeValue<string>("isocurrencycode"); }
            set
            {
                OnPropertyChanging("ISOCurrencyCode");
                SetAttributeValue("isocurrencycode", value);
                OnPropertyChanged("ISOCurrencyCode");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the transaction currency.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the transaction currency was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the transactioncurrency.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the organization associated with the transaction currency.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
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
        ///     Status of the transaction currency.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public TransactionCurrencyState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return
                        ((TransactionCurrencyState) (Enum.ToObject(typeof (TransactionCurrencyState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the transaction currency.
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
        ///     Unique identifier of the transaction currency.
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        public Guid? TransactionCurrencyId
        {
            get { return GetAttributeValue<Guid?>("transactioncurrencyid"); }
            set
            {
                OnPropertyChanging("TransactionCurrencyId");
                SetAttributeValue("transactioncurrencyid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("TransactionCurrencyId");
            }
        }

        [AttributeLogicalName("transactioncurrencyid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { TransactionCurrencyId = value; }
        }

        /// <summary>
        ///     Version number of the transaction currency.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N basecurrency_organization
        /// </summary>
        [RelationshipSchemaName("basecurrency_organization")]
        public IEnumerable<Organization> basecurrency_organization
        {
            get { return GetRelatedEntities<Organization>("basecurrency_organization", null); }
            set
            {
                OnPropertyChanging("basecurrency_organization");
                SetRelatedEntities("basecurrency_organization", null, value);
                OnPropertyChanged("basecurrency_organization");
            }
        }

        /// <summary>
        ///     1:N transactioncurrency_account
        /// </summary>
        [RelationshipSchemaName("transactioncurrency_account")]
        public IEnumerable<Account> transactioncurrency_account
        {
            get { return GetRelatedEntities<Account>("transactioncurrency_account", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_account");
                SetRelatedEntities("transactioncurrency_account", null, value);
                OnPropertyChanged("transactioncurrency_account");
            }
        }

        /// <summary>
        ///     1:N TransactionCurrency_ActivityPointer
        /// </summary>
        [RelationshipSchemaName("TransactionCurrency_ActivityPointer")]
        public IEnumerable<ActivityPointer> TransactionCurrency_ActivityPointer
        {
            get { return GetRelatedEntities<ActivityPointer>("TransactionCurrency_ActivityPointer", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_ActivityPointer");
                SetRelatedEntities("TransactionCurrency_ActivityPointer", null, value);
                OnPropertyChanged("TransactionCurrency_ActivityPointer");
            }
        }

        /// <summary>
        ///     1:N transactioncurrency_annualfiscalcalendar
        /// </summary>
        [RelationshipSchemaName("transactioncurrency_annualfiscalcalendar")]
        public IEnumerable<AnnualFiscalCalendar> transactioncurrency_annualfiscalcalendar
        {
            get { return GetRelatedEntities<AnnualFiscalCalendar>("transactioncurrency_annualfiscalcalendar", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_annualfiscalcalendar");
                SetRelatedEntities("transactioncurrency_annualfiscalcalendar", null, value);
                OnPropertyChanged("transactioncurrency_annualfiscalcalendar");
            }
        }

        /// <summary>
        ///     1:N TransactionCurrency_Appointment
        /// </summary>
        [RelationshipSchemaName("TransactionCurrency_Appointment")]
        public IEnumerable<Appointment> TransactionCurrency_Appointment
        {
            get { return GetRelatedEntities<Appointment>("TransactionCurrency_Appointment", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_Appointment");
                SetRelatedEntities("TransactionCurrency_Appointment", null, value);
                OnPropertyChanged("TransactionCurrency_Appointment");
            }
        }

        /// <summary>
        ///     1:N TransactionCurrency_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("TransactionCurrency_AsyncOperations")]
        public IEnumerable<AsyncOperation> TransactionCurrency_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("TransactionCurrency_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_AsyncOperations");
                SetRelatedEntities("TransactionCurrency_AsyncOperations", null, value);
                OnPropertyChanged("TransactionCurrency_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N TransactionCurrency_BusinessUnit
        /// </summary>
        [RelationshipSchemaName("TransactionCurrency_BusinessUnit")]
        public IEnumerable<BusinessUnit> TransactionCurrency_BusinessUnit
        {
            get { return GetRelatedEntities<BusinessUnit>("TransactionCurrency_BusinessUnit", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_BusinessUnit");
                SetRelatedEntities("TransactionCurrency_BusinessUnit", null, value);
                OnPropertyChanged("TransactionCurrency_BusinessUnit");
            }
        }

        /// <summary>
        ///     1:N transactioncurrency_campaign
        /// </summary>
        [RelationshipSchemaName("transactioncurrency_campaign")]
        public IEnumerable<Campaign> transactioncurrency_campaign
        {
            get { return GetRelatedEntities<Campaign>("transactioncurrency_campaign", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_campaign");
                SetRelatedEntities("transactioncurrency_campaign", null, value);
                OnPropertyChanged("transactioncurrency_campaign");
            }
        }

        /// <summary>
        ///     1:N transactioncurrency_campaignactivity
        /// </summary>
        [RelationshipSchemaName("transactioncurrency_campaignactivity")]
        public IEnumerable<CampaignActivity> transactioncurrency_campaignactivity
        {
            get { return GetRelatedEntities<CampaignActivity>("transactioncurrency_campaignactivity", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_campaignactivity");
                SetRelatedEntities("transactioncurrency_campaignactivity", null, value);
                OnPropertyChanged("transactioncurrency_campaignactivity");
            }
        }

        /// <summary>
        ///     1:N TransactionCurrency_CampaignResponse
        /// </summary>
        [RelationshipSchemaName("TransactionCurrency_CampaignResponse")]
        public IEnumerable<CampaignResponse> TransactionCurrency_CampaignResponse
        {
            get { return GetRelatedEntities<CampaignResponse>("TransactionCurrency_CampaignResponse", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_CampaignResponse");
                SetRelatedEntities("TransactionCurrency_CampaignResponse", null, value);
                OnPropertyChanged("TransactionCurrency_CampaignResponse");
            }
        }

        /// <summary>
        ///     1:N transactioncurrency_competitor
        /// </summary>
        [RelationshipSchemaName("transactioncurrency_competitor")]
        public IEnumerable<Competitor> transactioncurrency_competitor
        {
            get { return GetRelatedEntities<Competitor>("transactioncurrency_competitor", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_competitor");
                SetRelatedEntities("transactioncurrency_competitor", null, value);
                OnPropertyChanged("transactioncurrency_competitor");
            }
        }

        /// <summary>
        ///     1:N TransactionCurrency_Connection
        /// </summary>
        [RelationshipSchemaName("TransactionCurrency_Connection")]
        public IEnumerable<Connection> TransactionCurrency_Connection
        {
            get { return GetRelatedEntities<Connection>("TransactionCurrency_Connection", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_Connection");
                SetRelatedEntities("TransactionCurrency_Connection", null, value);
                OnPropertyChanged("TransactionCurrency_Connection");
            }
        }

        /// <summary>
        ///     1:N transactioncurrency_contact
        /// </summary>
        [RelationshipSchemaName("transactioncurrency_contact")]
        public IEnumerable<Contact> transactioncurrency_contact
        {
            get { return GetRelatedEntities<Contact>("transactioncurrency_contact", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_contact");
                SetRelatedEntities("transactioncurrency_contact", null, value);
                OnPropertyChanged("transactioncurrency_contact");
            }
        }

        /// <summary>
        ///     1:N transactioncurrency_contract
        /// </summary>
        [RelationshipSchemaName("transactioncurrency_contract")]
        public IEnumerable<Contract> transactioncurrency_contract
        {
            get { return GetRelatedEntities<Contract>("transactioncurrency_contract", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_contract");
                SetRelatedEntities("transactioncurrency_contract", null, value);
                OnPropertyChanged("transactioncurrency_contract");
            }
        }

        /// <summary>
        ///     1:N transactioncurrency_contractdetail
        /// </summary>
        [RelationshipSchemaName("transactioncurrency_contractdetail")]
        public IEnumerable<ContractDetail> transactioncurrency_contractdetail
        {
            get { return GetRelatedEntities<ContractDetail>("transactioncurrency_contractdetail", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_contractdetail");
                SetRelatedEntities("transactioncurrency_contractdetail", null, value);
                OnPropertyChanged("transactioncurrency_contractdetail");
            }
        }

        /// <summary>
        ///     1:N TransactionCurrency_CustomerAddress
        /// </summary>
        [RelationshipSchemaName("TransactionCurrency_CustomerAddress")]
        public IEnumerable<CustomerAddress> TransactionCurrency_CustomerAddress
        {
            get { return GetRelatedEntities<CustomerAddress>("TransactionCurrency_CustomerAddress", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_CustomerAddress");
                SetRelatedEntities("TransactionCurrency_CustomerAddress", null, value);
                OnPropertyChanged("TransactionCurrency_CustomerAddress");
            }
        }

        /// <summary>
        ///     1:N transactioncurrency_discount
        /// </summary>
        [RelationshipSchemaName("transactioncurrency_discount")]
        public IEnumerable<Discount> transactioncurrency_discount
        {
            get { return GetRelatedEntities<Discount>("transactioncurrency_discount", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_discount");
                SetRelatedEntities("transactioncurrency_discount", null, value);
                OnPropertyChanged("transactioncurrency_discount");
            }
        }

        /// <summary>
        ///     1:N transactioncurrency_discounttype
        /// </summary>
        [RelationshipSchemaName("transactioncurrency_discounttype")]
        public IEnumerable<DiscountType> transactioncurrency_discounttype
        {
            get { return GetRelatedEntities<DiscountType>("transactioncurrency_discounttype", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_discounttype");
                SetRelatedEntities("transactioncurrency_discounttype", null, value);
                OnPropertyChanged("transactioncurrency_discounttype");
            }
        }

        /// <summary>
        ///     1:N TransactionCurrency_Email
        /// </summary>
        [RelationshipSchemaName("TransactionCurrency_Email")]
        public IEnumerable<Email> TransactionCurrency_Email
        {
            get { return GetRelatedEntities<Email>("TransactionCurrency_Email", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_Email");
                SetRelatedEntities("TransactionCurrency_Email", null, value);
                OnPropertyChanged("TransactionCurrency_Email");
            }
        }

        /// <summary>
        ///     1:N TransactionCurrency_Equipment
        /// </summary>
        [RelationshipSchemaName("TransactionCurrency_Equipment")]
        public IEnumerable<Equipment> TransactionCurrency_Equipment
        {
            get { return GetRelatedEntities<Equipment>("TransactionCurrency_Equipment", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_Equipment");
                SetRelatedEntities("TransactionCurrency_Equipment", null, value);
                OnPropertyChanged("TransactionCurrency_Equipment");
            }
        }

        /// <summary>
        ///     1:N TransactionCurrency_Fax
        /// </summary>
        [RelationshipSchemaName("TransactionCurrency_Fax")]
        public IEnumerable<Fax> TransactionCurrency_Fax
        {
            get { return GetRelatedEntities<Fax>("TransactionCurrency_Fax", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_Fax");
                SetRelatedEntities("TransactionCurrency_Fax", null, value);
                OnPropertyChanged("TransactionCurrency_Fax");
            }
        }

        /// <summary>
        ///     1:N transactioncurrency_fixedmonthlyfiscalcalendar
        /// </summary>
        [RelationshipSchemaName("transactioncurrency_fixedmonthlyfiscalcalendar")]
        public IEnumerable<FixedMonthlyFiscalCalendar> transactioncurrency_fixedmonthlyfiscalcalendar
        {
            get
            {
                return GetRelatedEntities<FixedMonthlyFiscalCalendar>("transactioncurrency_fixedmonthlyfiscalcalendar",
                    null);
            }
            set
            {
                OnPropertyChanging("transactioncurrency_fixedmonthlyfiscalcalendar");
                SetRelatedEntities("transactioncurrency_fixedmonthlyfiscalcalendar", null, value);
                OnPropertyChanged("transactioncurrency_fixedmonthlyfiscalcalendar");
            }
        }

        /// <summary>
        ///     1:N TransactionCurrency_Goal
        /// </summary>
        [RelationshipSchemaName("TransactionCurrency_Goal")]
        public IEnumerable<Goal> TransactionCurrency_Goal
        {
            get { return GetRelatedEntities<Goal>("TransactionCurrency_Goal", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_Goal");
                SetRelatedEntities("TransactionCurrency_Goal", null, value);
                OnPropertyChanged("TransactionCurrency_Goal");
            }
        }

        /// <summary>
        ///     1:N TransactionCurrency_Incident
        /// </summary>
        [RelationshipSchemaName("TransactionCurrency_Incident")]
        public IEnumerable<Incident> TransactionCurrency_Incident
        {
            get { return GetRelatedEntities<Incident>("TransactionCurrency_Incident", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_Incident");
                SetRelatedEntities("TransactionCurrency_Incident", null, value);
                OnPropertyChanged("TransactionCurrency_Incident");
            }
        }

        /// <summary>
        ///     1:N transactioncurrency_invoice
        /// </summary>
        [RelationshipSchemaName("transactioncurrency_invoice")]
        public IEnumerable<Invoice> transactioncurrency_invoice
        {
            get { return GetRelatedEntities<Invoice>("transactioncurrency_invoice", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_invoice");
                SetRelatedEntities("transactioncurrency_invoice", null, value);
                OnPropertyChanged("transactioncurrency_invoice");
            }
        }

        /// <summary>
        ///     1:N transactioncurrency_invoicedetail
        /// </summary>
        [RelationshipSchemaName("transactioncurrency_invoicedetail")]
        public IEnumerable<InvoiceDetail> transactioncurrency_invoicedetail
        {
            get { return GetRelatedEntities<InvoiceDetail>("transactioncurrency_invoicedetail", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_invoicedetail");
                SetRelatedEntities("transactioncurrency_invoicedetail", null, value);
                OnPropertyChanged("transactioncurrency_invoicedetail");
            }
        }

        /// <summary>
        ///     1:N TransactionCurrency_KbArticle
        /// </summary>
        [RelationshipSchemaName("TransactionCurrency_KbArticle")]
        public IEnumerable<KbArticle> TransactionCurrency_KbArticle
        {
            get { return GetRelatedEntities<KbArticle>("TransactionCurrency_KbArticle", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_KbArticle");
                SetRelatedEntities("TransactionCurrency_KbArticle", null, value);
                OnPropertyChanged("TransactionCurrency_KbArticle");
            }
        }

        /// <summary>
        ///     1:N transactioncurrency_lead
        /// </summary>
        [RelationshipSchemaName("transactioncurrency_lead")]
        public IEnumerable<Lead> transactioncurrency_lead
        {
            get { return GetRelatedEntities<Lead>("transactioncurrency_lead", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_lead");
                SetRelatedEntities("transactioncurrency_lead", null, value);
                OnPropertyChanged("transactioncurrency_lead");
            }
        }

        /// <summary>
        ///     1:N TransactionCurrency_LeadAddress
        /// </summary>
        [RelationshipSchemaName("TransactionCurrency_LeadAddress")]
        public IEnumerable<LeadAddress> TransactionCurrency_LeadAddress
        {
            get { return GetRelatedEntities<LeadAddress>("TransactionCurrency_LeadAddress", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_LeadAddress");
                SetRelatedEntities("TransactionCurrency_LeadAddress", null, value);
                OnPropertyChanged("TransactionCurrency_LeadAddress");
            }
        }

        /// <summary>
        ///     1:N TransactionCurrency_Letter
        /// </summary>
        [RelationshipSchemaName("TransactionCurrency_Letter")]
        public IEnumerable<Letter> TransactionCurrency_Letter
        {
            get { return GetRelatedEntities<Letter>("TransactionCurrency_Letter", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_Letter");
                SetRelatedEntities("TransactionCurrency_Letter", null, value);
                OnPropertyChanged("TransactionCurrency_Letter");
            }
        }

        /// <summary>
        ///     1:N transactioncurrency_list
        /// </summary>
        [RelationshipSchemaName("transactioncurrency_list")]
        public IEnumerable<List> transactioncurrency_list
        {
            get { return GetRelatedEntities<List>("transactioncurrency_list", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_list");
                SetRelatedEntities("transactioncurrency_list", null, value);
                OnPropertyChanged("transactioncurrency_list");
            }
        }

        /// <summary>
        ///     1:N TransactionCurrency_MailMergeTemplate
        /// </summary>
        [RelationshipSchemaName("TransactionCurrency_MailMergeTemplate")]
        public IEnumerable<MailMergeTemplate> TransactionCurrency_MailMergeTemplate
        {
            get { return GetRelatedEntities<MailMergeTemplate>("TransactionCurrency_MailMergeTemplate", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_MailMergeTemplate");
                SetRelatedEntities("TransactionCurrency_MailMergeTemplate", null, value);
                OnPropertyChanged("TransactionCurrency_MailMergeTemplate");
            }
        }

        /// <summary>
        ///     1:N transactioncurrency_monthlyfiscalcalendar
        /// </summary>
        [RelationshipSchemaName("transactioncurrency_monthlyfiscalcalendar")]
        public IEnumerable<MonthlyFiscalCalendar> transactioncurrency_monthlyfiscalcalendar
        {
            get { return GetRelatedEntities<MonthlyFiscalCalendar>("transactioncurrency_monthlyfiscalcalendar", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_monthlyfiscalcalendar");
                SetRelatedEntities("transactioncurrency_monthlyfiscalcalendar", null, value);
                OnPropertyChanged("transactioncurrency_monthlyfiscalcalendar");
            }
        }

        /// <summary>
        ///     1:N transactioncurrency_opportunity
        /// </summary>
        [RelationshipSchemaName("transactioncurrency_opportunity")]
        public IEnumerable<Opportunity> transactioncurrency_opportunity
        {
            get { return GetRelatedEntities<Opportunity>("transactioncurrency_opportunity", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_opportunity");
                SetRelatedEntities("transactioncurrency_opportunity", null, value);
                OnPropertyChanged("transactioncurrency_opportunity");
            }
        }

        /// <summary>
        ///     1:N transactioncurrency_opportunityclose
        /// </summary>
        [RelationshipSchemaName("transactioncurrency_opportunityclose")]
        public IEnumerable<OpportunityClose> transactioncurrency_opportunityclose
        {
            get { return GetRelatedEntities<OpportunityClose>("transactioncurrency_opportunityclose", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_opportunityclose");
                SetRelatedEntities("transactioncurrency_opportunityclose", null, value);
                OnPropertyChanged("transactioncurrency_opportunityclose");
            }
        }

        /// <summary>
        ///     1:N transactioncurrency_opportunityproduct
        /// </summary>
        [RelationshipSchemaName("transactioncurrency_opportunityproduct")]
        public IEnumerable<OpportunityProduct> transactioncurrency_opportunityproduct
        {
            get { return GetRelatedEntities<OpportunityProduct>("transactioncurrency_opportunityproduct", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_opportunityproduct");
                SetRelatedEntities("transactioncurrency_opportunityproduct", null, value);
                OnPropertyChanged("transactioncurrency_opportunityproduct");
            }
        }

        /// <summary>
        ///     1:N TransactionCurrency_PhoneCall
        /// </summary>
        [RelationshipSchemaName("TransactionCurrency_PhoneCall")]
        public IEnumerable<PhoneCall> TransactionCurrency_PhoneCall
        {
            get { return GetRelatedEntities<PhoneCall>("TransactionCurrency_PhoneCall", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_PhoneCall");
                SetRelatedEntities("TransactionCurrency_PhoneCall", null, value);
                OnPropertyChanged("TransactionCurrency_PhoneCall");
            }
        }

        /// <summary>
        ///     1:N transactioncurrency_pricelevel
        /// </summary>
        [RelationshipSchemaName("transactioncurrency_pricelevel")]
        public IEnumerable<PriceLevel> transactioncurrency_pricelevel
        {
            get { return GetRelatedEntities<PriceLevel>("transactioncurrency_pricelevel", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_pricelevel");
                SetRelatedEntities("transactioncurrency_pricelevel", null, value);
                OnPropertyChanged("transactioncurrency_pricelevel");
            }
        }

        /// <summary>
        ///     1:N TransactionCurrency_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("TransactionCurrency_ProcessSessions")]
        public IEnumerable<ProcessSession> TransactionCurrency_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("TransactionCurrency_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_ProcessSessions");
                SetRelatedEntities("TransactionCurrency_ProcessSessions", null, value);
                OnPropertyChanged("TransactionCurrency_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N transactioncurrency_product
        /// </summary>
        [RelationshipSchemaName("transactioncurrency_product")]
        public IEnumerable<Product> transactioncurrency_product
        {
            get { return GetRelatedEntities<Product>("transactioncurrency_product", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_product");
                SetRelatedEntities("transactioncurrency_product", null, value);
                OnPropertyChanged("transactioncurrency_product");
            }
        }

        /// <summary>
        ///     1:N transactioncurrency_productpricelevel
        /// </summary>
        [RelationshipSchemaName("transactioncurrency_productpricelevel")]
        public IEnumerable<ProductPriceLevel> transactioncurrency_productpricelevel
        {
            get { return GetRelatedEntities<ProductPriceLevel>("transactioncurrency_productpricelevel", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_productpricelevel");
                SetRelatedEntities("transactioncurrency_productpricelevel", null, value);
                OnPropertyChanged("transactioncurrency_productpricelevel");
            }
        }

        /// <summary>
        ///     1:N transactioncurrency_quarterlyfiscalcalendar
        /// </summary>
        [RelationshipSchemaName("transactioncurrency_quarterlyfiscalcalendar")]
        public IEnumerable<QuarterlyFiscalCalendar> transactioncurrency_quarterlyfiscalcalendar
        {
            get
            {
                return GetRelatedEntities<QuarterlyFiscalCalendar>("transactioncurrency_quarterlyfiscalcalendar", null);
            }
            set
            {
                OnPropertyChanging("transactioncurrency_quarterlyfiscalcalendar");
                SetRelatedEntities("transactioncurrency_quarterlyfiscalcalendar", null, value);
                OnPropertyChanged("transactioncurrency_quarterlyfiscalcalendar");
            }
        }

        /// <summary>
        ///     1:N TransactionCurrency_Queue
        /// </summary>
        [RelationshipSchemaName("TransactionCurrency_Queue")]
        public IEnumerable<Queue> TransactionCurrency_Queue
        {
            get { return GetRelatedEntities<Queue>("TransactionCurrency_Queue", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_Queue");
                SetRelatedEntities("TransactionCurrency_Queue", null, value);
                OnPropertyChanged("TransactionCurrency_Queue");
            }
        }

        /// <summary>
        ///     1:N TransactionCurrency_QueueItem
        /// </summary>
        [RelationshipSchemaName("TransactionCurrency_QueueItem")]
        public IEnumerable<QueueItem> TransactionCurrency_QueueItem
        {
            get { return GetRelatedEntities<QueueItem>("TransactionCurrency_QueueItem", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_QueueItem");
                SetRelatedEntities("TransactionCurrency_QueueItem", null, value);
                OnPropertyChanged("TransactionCurrency_QueueItem");
            }
        }

        /// <summary>
        ///     1:N transactioncurrency_quote
        /// </summary>
        [RelationshipSchemaName("transactioncurrency_quote")]
        public IEnumerable<Quote> transactioncurrency_quote
        {
            get { return GetRelatedEntities<Quote>("transactioncurrency_quote", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_quote");
                SetRelatedEntities("transactioncurrency_quote", null, value);
                OnPropertyChanged("transactioncurrency_quote");
            }
        }

        /// <summary>
        ///     1:N transactioncurrency_quotedetail
        /// </summary>
        [RelationshipSchemaName("transactioncurrency_quotedetail")]
        public IEnumerable<QuoteDetail> transactioncurrency_quotedetail
        {
            get { return GetRelatedEntities<QuoteDetail>("transactioncurrency_quotedetail", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_quotedetail");
                SetRelatedEntities("transactioncurrency_quotedetail", null, value);
                OnPropertyChanged("transactioncurrency_quotedetail");
            }
        }

        /// <summary>
        ///     1:N TransactionCurrency_RecurringAppointmentMaster
        /// </summary>
        [RelationshipSchemaName("TransactionCurrency_RecurringAppointmentMaster")]
        public IEnumerable<RecurringAppointmentMaster> TransactionCurrency_RecurringAppointmentMaster
        {
            get
            {
                return GetRelatedEntities<RecurringAppointmentMaster>("TransactionCurrency_RecurringAppointmentMaster",
                    null);
            }
            set
            {
                OnPropertyChanging("TransactionCurrency_RecurringAppointmentMaster");
                SetRelatedEntities("TransactionCurrency_RecurringAppointmentMaster", null, value);
                OnPropertyChanged("TransactionCurrency_RecurringAppointmentMaster");
            }
        }

        /// <summary>
        ///     1:N TransactionCurrency_ReportCategory
        /// </summary>
        [RelationshipSchemaName("TransactionCurrency_ReportCategory")]
        public IEnumerable<ReportCategory> TransactionCurrency_ReportCategory
        {
            get { return GetRelatedEntities<ReportCategory>("TransactionCurrency_ReportCategory", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_ReportCategory");
                SetRelatedEntities("TransactionCurrency_ReportCategory", null, value);
                OnPropertyChanged("TransactionCurrency_ReportCategory");
            }
        }

        /// <summary>
        ///     1:N TransactionCurrency_SalesLiterature
        /// </summary>
        [RelationshipSchemaName("TransactionCurrency_SalesLiterature")]
        public IEnumerable<SalesLiterature> TransactionCurrency_SalesLiterature
        {
            get { return GetRelatedEntities<SalesLiterature>("TransactionCurrency_SalesLiterature", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_SalesLiterature");
                SetRelatedEntities("TransactionCurrency_SalesLiterature", null, value);
                OnPropertyChanged("TransactionCurrency_SalesLiterature");
            }
        }

        /// <summary>
        ///     1:N transactioncurrency_salesorder
        /// </summary>
        [RelationshipSchemaName("transactioncurrency_salesorder")]
        public IEnumerable<SalesOrder> transactioncurrency_salesorder
        {
            get { return GetRelatedEntities<SalesOrder>("transactioncurrency_salesorder", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_salesorder");
                SetRelatedEntities("transactioncurrency_salesorder", null, value);
                OnPropertyChanged("transactioncurrency_salesorder");
            }
        }

        /// <summary>
        ///     1:N transactioncurrency_salesorderdetail
        /// </summary>
        [RelationshipSchemaName("transactioncurrency_salesorderdetail")]
        public IEnumerable<SalesOrderDetail> transactioncurrency_salesorderdetail
        {
            get { return GetRelatedEntities<SalesOrderDetail>("transactioncurrency_salesorderdetail", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_salesorderdetail");
                SetRelatedEntities("transactioncurrency_salesorderdetail", null, value);
                OnPropertyChanged("transactioncurrency_salesorderdetail");
            }
        }

        /// <summary>
        ///     1:N transactioncurrency_semiannualfiscalcalendar
        /// </summary>
        [RelationshipSchemaName("transactioncurrency_semiannualfiscalcalendar")]
        public IEnumerable<SemiAnnualFiscalCalendar> transactioncurrency_semiannualfiscalcalendar
        {
            get
            {
                return GetRelatedEntities<SemiAnnualFiscalCalendar>("transactioncurrency_semiannualfiscalcalendar", null);
            }
            set
            {
                OnPropertyChanging("transactioncurrency_semiannualfiscalcalendar");
                SetRelatedEntities("transactioncurrency_semiannualfiscalcalendar", null, value);
                OnPropertyChanged("transactioncurrency_semiannualfiscalcalendar");
            }
        }

        /// <summary>
        ///     1:N TransactionCurrency_ServiceAppointment
        /// </summary>
        [RelationshipSchemaName("TransactionCurrency_ServiceAppointment")]
        public IEnumerable<ServiceAppointment> TransactionCurrency_ServiceAppointment
        {
            get { return GetRelatedEntities<ServiceAppointment>("TransactionCurrency_ServiceAppointment", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_ServiceAppointment");
                SetRelatedEntities("TransactionCurrency_ServiceAppointment", null, value);
                OnPropertyChanged("TransactionCurrency_ServiceAppointment");
            }
        }

        /// <summary>
        ///     1:N TransactionCurrency_SharePointDocumentLocation
        /// </summary>
        [RelationshipSchemaName("TransactionCurrency_SharePointDocumentLocation")]
        public IEnumerable<SharePointDocumentLocation> TransactionCurrency_SharePointDocumentLocation
        {
            get
            {
                return GetRelatedEntities<SharePointDocumentLocation>("TransactionCurrency_SharePointDocumentLocation",
                    null);
            }
            set
            {
                OnPropertyChanging("TransactionCurrency_SharePointDocumentLocation");
                SetRelatedEntities("TransactionCurrency_SharePointDocumentLocation", null, value);
                OnPropertyChanged("TransactionCurrency_SharePointDocumentLocation");
            }
        }

        /// <summary>
        ///     1:N TransactionCurrency_SharePointSite
        /// </summary>
        [RelationshipSchemaName("TransactionCurrency_SharePointSite")]
        public IEnumerable<SharePointSite> TransactionCurrency_SharePointSite
        {
            get { return GetRelatedEntities<SharePointSite>("TransactionCurrency_SharePointSite", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_SharePointSite");
                SetRelatedEntities("TransactionCurrency_SharePointSite", null, value);
                OnPropertyChanged("TransactionCurrency_SharePointSite");
            }
        }

        /// <summary>
        ///     1:N TransactionCurrency_SystemUser
        /// </summary>
        [RelationshipSchemaName("TransactionCurrency_SystemUser")]
        public IEnumerable<SystemUser> TransactionCurrency_SystemUser
        {
            get { return GetRelatedEntities<SystemUser>("TransactionCurrency_SystemUser", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_SystemUser");
                SetRelatedEntities("TransactionCurrency_SystemUser", null, value);
                OnPropertyChanged("TransactionCurrency_SystemUser");
            }
        }

        /// <summary>
        ///     1:N TransactionCurrency_Task
        /// </summary>
        [RelationshipSchemaName("TransactionCurrency_Task")]
        public IEnumerable<Task> TransactionCurrency_Task
        {
            get { return GetRelatedEntities<Task>("TransactionCurrency_Task", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_Task");
                SetRelatedEntities("TransactionCurrency_Task", null, value);
                OnPropertyChanged("TransactionCurrency_Task");
            }
        }

        /// <summary>
        ///     1:N TransactionCurrency_Team
        /// </summary>
        [RelationshipSchemaName("TransactionCurrency_Team")]
        public IEnumerable<Team> TransactionCurrency_Team
        {
            get { return GetRelatedEntities<Team>("TransactionCurrency_Team", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_Team");
                SetRelatedEntities("TransactionCurrency_Team", null, value);
                OnPropertyChanged("TransactionCurrency_Team");
            }
        }

        /// <summary>
        ///     1:N TransactionCurrency_Territory
        /// </summary>
        [RelationshipSchemaName("TransactionCurrency_Territory")]
        public IEnumerable<Territory> TransactionCurrency_Territory
        {
            get { return GetRelatedEntities<Territory>("TransactionCurrency_Territory", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_Territory");
                SetRelatedEntities("TransactionCurrency_Territory", null, value);
                OnPropertyChanged("TransactionCurrency_Territory");
            }
        }

        /// <summary>
        ///     1:N transactioncurrency_usersettings
        /// </summary>
        [RelationshipSchemaName("transactioncurrency_usersettings")]
        public IEnumerable<UserSettings> transactioncurrency_usersettings
        {
            get { return GetRelatedEntities<UserSettings>("transactioncurrency_usersettings", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_usersettings");
                SetRelatedEntities("transactioncurrency_usersettings", null, value);
                OnPropertyChanged("transactioncurrency_usersettings");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_transactioncurrency
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_transactioncurrency")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_transactioncurrency
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_transactioncurrency", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_transactioncurrency");
                SetRelatedEntities("userentityinstancedata_transactioncurrency", null, value);
                OnPropertyChanged("userentityinstancedata_transactioncurrency");
            }
        }

        /// <summary>
        ///     N:1 lk_transactioncurrency_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_transactioncurrency_createdonbehalfby")]
        public SystemUser lk_transactioncurrency_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_transactioncurrency_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_transactioncurrency_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_transactioncurrency_modifiedonbehalfby")]
        public SystemUser lk_transactioncurrency_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_transactioncurrency_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_transactioncurrencybase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_transactioncurrencybase_createdby")]
        public SystemUser lk_transactioncurrencybase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_transactioncurrencybase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_transactioncurrencybase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_transactioncurrencybase_modifiedby")]
        public SystemUser lk_transactioncurrencybase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_transactioncurrencybase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 organization_transactioncurrencies
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_transactioncurrencies")]
        public Organization organization_transactioncurrencies
        {
            get { return GetRelatedEntity<Organization>("organization_transactioncurrencies", null); }
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