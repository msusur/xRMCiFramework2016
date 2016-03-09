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
    ///     Agreement to provide customer service during a specified amount of time or number of cases.
    /// </summary>
    [DataContract]
    [EntityLogicalName("contract")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Contract : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "contract";

        public const int EntityTypeCode = 1010;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Contract() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the account with which the contract is associated.
        /// </summary>
        [AttributeLogicalName("accountid")]
        public EntityReference AccountId
        {
            get { return GetAttributeValue<EntityReference>("accountid"); }
        }

        /// <summary>
        ///     Enter the date when the contract becomes active.
        /// </summary>
        [AttributeLogicalName("activeon")]
        public DateTime? ActiveOn
        {
            get { return GetAttributeValue<DateTime?>("activeon"); }
            set
            {
                OnPropertyChanging("ActiveOn");
                SetAttributeValue("activeon", value);
                OnPropertyChanged("ActiveOn");
            }
        }

        /// <summary>
        ///     Type of allotment that the contract supports.
        /// </summary>
        [AttributeLogicalName("allotmenttypecode")]
        public OptionSetValue AllotmentTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("allotmenttypecode"); }
            set
            {
                OnPropertyChanging("AllotmentTypeCode");
                SetAttributeValue("allotmenttypecode", value);
                OnPropertyChanged("AllotmentTypeCode");
            }
        }

        /// <summary>
        ///     Unique identifier of the account to which the contract is to be billed.
        /// </summary>
        [AttributeLogicalName("billingaccountid")]
        public EntityReference BillingAccountId
        {
            get { return GetAttributeValue<EntityReference>("billingaccountid"); }
        }

        /// <summary>
        ///     Unique identifier of the contact to whom the contract is to be billed.
        /// </summary>
        [AttributeLogicalName("billingcontactid")]
        public EntityReference BillingContactId
        {
            get { return GetAttributeValue<EntityReference>("billingcontactid"); }
        }

        /// <summary>
        ///     Select the customer account or contact to which the contract should be billed to provide a quick link to address
        ///     and other customer details.
        /// </summary>
        [AttributeLogicalName("billingcustomerid")]
        public EntityReference BillingCustomerId
        {
            get { return GetAttributeValue<EntityReference>("billingcustomerid"); }
            set
            {
                OnPropertyChanging("BillingCustomerId");
                SetAttributeValue("billingcustomerid", value);
                OnPropertyChanged("BillingCustomerId");
            }
        }

        /// <summary>
        ///     Enter the end date for the contract's billing period to indicate the period for which the customer must pay for a
        ///     service.
        /// </summary>
        [AttributeLogicalName("billingendon")]
        public DateTime? BillingEndOn
        {
            get { return GetAttributeValue<DateTime?>("billingendon"); }
            set
            {
                OnPropertyChanging("BillingEndOn");
                SetAttributeValue("billingendon", value);
                OnPropertyChanged("BillingEndOn");
            }
        }

        /// <summary>
        ///     Select the billing schedule of the contract to indicate how often the customer should be invoiced.
        /// </summary>
        [AttributeLogicalName("billingfrequencycode")]
        public OptionSetValue BillingFrequencyCode
        {
            get { return GetAttributeValue<OptionSetValue>("billingfrequencycode"); }
            set
            {
                OnPropertyChanging("BillingFrequencyCode");
                SetAttributeValue("billingfrequencycode", value);
                OnPropertyChanged("BillingFrequencyCode");
            }
        }

        /// <summary>
        ///     Enter the start date for the contract's billing period to indicate the period for which the customer must pay for a
        ///     service. This defaults to the same date that is selected in the Contract Start Date field.
        /// </summary>
        [AttributeLogicalName("billingstarton")]
        public DateTime? BillingStartOn
        {
            get { return GetAttributeValue<DateTime?>("billingstarton"); }
            set
            {
                OnPropertyChanging("BillingStartOn");
                SetAttributeValue("billingstarton", value);
                OnPropertyChanged("BillingStartOn");
            }
        }

        /// <summary>
        ///     Choose which address to send the invoice to.
        /// </summary>
        [AttributeLogicalName("billtoaddress")]
        public EntityReference BillToAddress
        {
            get { return GetAttributeValue<EntityReference>("billtoaddress"); }
            set
            {
                OnPropertyChanging("BillToAddress");
                SetAttributeValue("billtoaddress", value);
                OnPropertyChanged("BillToAddress");
            }
        }

        /// <summary>
        ///     Shows the date and time when the contract was canceled.
        /// </summary>
        [AttributeLogicalName("cancelon")]
        public DateTime? CancelOn
        {
            get { return GetAttributeValue<DateTime?>("cancelon"); }
        }

        /// <summary>
        ///     Unique identifier of the contact specified for the contract.
        /// </summary>
        [AttributeLogicalName("contactid")]
        public EntityReference ContactId
        {
            get { return GetAttributeValue<EntityReference>("contactid"); }
        }

        /// <summary>
        ///     Unique identifier of the contract.
        /// </summary>
        [AttributeLogicalName("contractid")]
        public Guid? ContractId
        {
            get { return GetAttributeValue<Guid?>("contractid"); }
            set
            {
                OnPropertyChanging("ContractId");
                SetAttributeValue("contractid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ContractId");
            }
        }

        [AttributeLogicalName("contractid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ContractId = value; }
        }

        /// <summary>
        ///     Type additional information about the contract, such as the products or services provided to the customer.
        /// </summary>
        [AttributeLogicalName("contractlanguage")]
        public string ContractLanguage
        {
            get { return GetAttributeValue<string>("contractlanguage"); }
            set
            {
                OnPropertyChanging("ContractLanguage");
                SetAttributeValue("contractlanguage", value);
                OnPropertyChanged("ContractLanguage");
            }
        }

        /// <summary>
        ///     Shows the number for the contract for customer reference and searching capabilities. You cannot modify this number.
        /// </summary>
        [AttributeLogicalName("contractnumber")]
        public string ContractNumber
        {
            get { return GetAttributeValue<string>("contractnumber"); }
            set
            {
                OnPropertyChanging("ContractNumber");
                SetAttributeValue("contractnumber", value);
                OnPropertyChanged("ContractNumber");
            }
        }

        /// <summary>
        ///     Select the level of service that should be provided for the contract based on your company's definition of bronze,
        ///     silver, or gold.
        /// </summary>
        [AttributeLogicalName("contractservicelevelcode")]
        public OptionSetValue ContractServiceLevelCode
        {
            get { return GetAttributeValue<OptionSetValue>("contractservicelevelcode"); }
            set
            {
                OnPropertyChanging("ContractServiceLevelCode");
                SetAttributeValue("contractservicelevelcode", value);
                OnPropertyChanged("ContractServiceLevelCode");
            }
        }

        /// <summary>
        ///     Shows the abbreviation of the contract template selected when the contract is created.
        /// </summary>
        [AttributeLogicalName("contracttemplateabbreviation")]
        public string ContractTemplateAbbreviation
        {
            get { return GetAttributeValue<string>("contracttemplateabbreviation"); }
        }

        /// <summary>
        ///     Choose the contract template that should be used to determine the terms of the contract, such as allotment type,
        ///     available hours, and billing frequency.
        /// </summary>
        [AttributeLogicalName("contracttemplateid")]
        public EntityReference ContractTemplateId
        {
            get { return GetAttributeValue<EntityReference>("contracttemplateid"); }
            set
            {
                OnPropertyChanging("ContractTemplateId");
                SetAttributeValue("contracttemplateid", value);
                OnPropertyChanged("ContractTemplateId");
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
        ///     Shows for the duration of the contract, in days, based on the contract start and end dates.
        /// </summary>
        [AttributeLogicalName("duration")]
        public int? Duration
        {
            get { return GetAttributeValue<int?>("duration"); }
        }

        /// <summary>
        ///     Days of the week and times during which customer service support is available for the duration of the contract.
        /// </summary>
        [AttributeLogicalName("effectivitycalendar")]
        public string EffectivityCalendar
        {
            get { return GetAttributeValue<string>("effectivitycalendar"); }
            set
            {
                OnPropertyChanging("EffectivityCalendar");
                SetAttributeValue("effectivitycalendar", value);
                OnPropertyChanged("EffectivityCalendar");
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
        ///     Enter the date when the contract expires.
        /// </summary>
        [AttributeLogicalName("expireson")]
        public DateTime? ExpiresOn
        {
            get { return GetAttributeValue<DateTime?>("expireson"); }
            set
            {
                OnPropertyChanging("ExpiresOn");
                SetAttributeValue("expireson", value);
                OnPropertyChanged("ExpiresOn");
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
        ///     Shows the total charge to the customer for the service contract, calculated as the sum of values in the Net field
        ///     for each existing contract line related to the contract.
        /// </summary>
        [AttributeLogicalName("netprice")]
        public Money NetPrice
        {
            get { return GetAttributeValue<Money>("netprice"); }
        }

        /// <summary>
        ///     Shows the Net Price field converted to the system's default base currency for reporting purposes. The calculations
        ///     use the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("netprice_base")]
        public Money NetPrice_Base
        {
            get { return GetAttributeValue<Money>("netprice_base"); }
        }

        /// <summary>
        ///     Choose the original contract that this contract was created from. This information is used to track renewal
        ///     history.
        /// </summary>
        [AttributeLogicalName("originatingcontract")]
        public EntityReference OriginatingContract
        {
            get { return GetAttributeValue<EntityReference>("originatingcontract"); }
            set
            {
                OnPropertyChanging("OriginatingContract");
                SetAttributeValue("originatingcontract", value);
                OnPropertyChanged("OriginatingContract");
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
        ///     Unique identifier of the business unit that owns the contract.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the contract.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the contract.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Choose the address for the customer account or contact where the services are provided.
        /// </summary>
        [AttributeLogicalName("serviceaddress")]
        public EntityReference ServiceAddress
        {
            get { return GetAttributeValue<EntityReference>("serviceaddress"); }
            set
            {
                OnPropertyChanging("ServiceAddress");
                SetAttributeValue("serviceaddress", value);
                OnPropertyChanged("ServiceAddress");
            }
        }

        /// <summary>
        ///     Shows whether the contract is in draft, invoiced, active, on hold, canceled, or expired. You can edit only the
        ///     contracts that are in draft status.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public ContractState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ContractState) (Enum.ToObject(typeof (ContractState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Select the contract's status.
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
        ///     Type a title or name for the contract that indicates the purpose of the contract.
        /// </summary>
        [AttributeLogicalName("title")]
        public string Title
        {
            get { return GetAttributeValue<string>("title"); }
            set
            {
                OnPropertyChanging("Title");
                SetAttributeValue("title", value);
                OnPropertyChanged("Title");
            }
        }

        /// <summary>
        ///     Shows the total discount applied to the contract's service charges, calculated as the sum of values in the Discount
        ///     fields for each existing contract line related to the contract.
        /// </summary>
        [AttributeLogicalName("totaldiscount")]
        public Money TotalDiscount
        {
            get { return GetAttributeValue<Money>("totaldiscount"); }
        }

        /// <summary>
        ///     Shows the Total Discount field converted to the system's default base currency for reporting purposes. The
        ///     calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("totaldiscount_base")]
        public Money TotalDiscount_Base
        {
            get { return GetAttributeValue<Money>("totaldiscount_base"); }
        }

        /// <summary>
        ///     Shows the total service charge for the contract, before any discounts are credited. This is calculated as the sum
        ///     of values in the Total Price field for each existing contract line related to the contract.
        /// </summary>
        [AttributeLogicalName("totalprice")]
        public Money TotalPrice
        {
            get { return GetAttributeValue<Money>("totalprice"); }
        }

        /// <summary>
        ///     Shows the Total Price field converted to the system's default base currency for reporting purposes. The
        ///     calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("totalprice_base")]
        public Money TotalPrice_Base
        {
            get { return GetAttributeValue<Money>("totalprice_base"); }
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
        ///     Select whether the discounts entered on contract lines for this contract should be entered as a percentage or a
        ///     fixed dollar value.
        /// </summary>
        [AttributeLogicalName("usediscountaspercentage")]
        public bool? UseDiscountAsPercentage
        {
            get { return GetAttributeValue<bool?>("usediscountaspercentage"); }
            set
            {
                OnPropertyChanging("UseDiscountAsPercentage");
                SetAttributeValue("usediscountaspercentage", value);
                OnPropertyChanged("UseDiscountAsPercentage");
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
        ///     Version number of the contract.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N contract_activity_parties
        /// </summary>
        [RelationshipSchemaName("contract_activity_parties")]
        public IEnumerable<ActivityParty> contract_activity_parties
        {
            get { return GetRelatedEntities<ActivityParty>("contract_activity_parties", null); }
            set
            {
                OnPropertyChanging("contract_activity_parties");
                SetRelatedEntities("contract_activity_parties", null, value);
                OnPropertyChanged("contract_activity_parties");
            }
        }

        /// <summary>
        ///     1:N Contract_ActivityPointers
        /// </summary>
        [RelationshipSchemaName("Contract_ActivityPointers")]
        public IEnumerable<ActivityPointer> Contract_ActivityPointers
        {
            get { return GetRelatedEntities<ActivityPointer>("Contract_ActivityPointers", null); }
            set
            {
                OnPropertyChanging("Contract_ActivityPointers");
                SetRelatedEntities("Contract_ActivityPointers", null, value);
                OnPropertyChanged("Contract_ActivityPointers");
            }
        }

        /// <summary>
        ///     1:N Contract_Annotation
        /// </summary>
        [RelationshipSchemaName("Contract_Annotation")]
        public IEnumerable<Annotation> Contract_Annotation
        {
            get { return GetRelatedEntities<Annotation>("Contract_Annotation", null); }
            set
            {
                OnPropertyChanging("Contract_Annotation");
                SetRelatedEntities("Contract_Annotation", null, value);
                OnPropertyChanged("Contract_Annotation");
            }
        }

        /// <summary>
        ///     1:N Contract_Appointments
        /// </summary>
        [RelationshipSchemaName("Contract_Appointments")]
        public IEnumerable<Appointment> Contract_Appointments
        {
            get { return GetRelatedEntities<Appointment>("Contract_Appointments", null); }
            set
            {
                OnPropertyChanging("Contract_Appointments");
                SetRelatedEntities("Contract_Appointments", null, value);
                OnPropertyChanged("Contract_Appointments");
            }
        }

        /// <summary>
        ///     1:N Contract_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Contract_AsyncOperations")]
        public IEnumerable<AsyncOperation> Contract_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Contract_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Contract_AsyncOperations");
                SetRelatedEntities("Contract_AsyncOperations", null, value);
                OnPropertyChanged("Contract_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N Contract_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("Contract_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> Contract_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("Contract_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("Contract_BulkDeleteFailures");
                SetRelatedEntities("Contract_BulkDeleteFailures", null, value);
                OnPropertyChanged("Contract_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N contract_cases
        /// </summary>
        [RelationshipSchemaName("contract_cases")]
        public IEnumerable<Incident> contract_cases
        {
            get { return GetRelatedEntities<Incident>("contract_cases", null); }
            set
            {
                OnPropertyChanging("contract_cases");
                SetRelatedEntities("contract_cases", null, value);
                OnPropertyChanged("contract_cases");
            }
        }

        /// <summary>
        ///     1:N contract_connections1
        /// </summary>
        [RelationshipSchemaName("contract_connections1")]
        public IEnumerable<Connection> contract_connections1
        {
            get { return GetRelatedEntities<Connection>("contract_connections1", null); }
            set
            {
                OnPropertyChanging("contract_connections1");
                SetRelatedEntities("contract_connections1", null, value);
                OnPropertyChanged("contract_connections1");
            }
        }

        /// <summary>
        ///     1:N contract_connections2
        /// </summary>
        [RelationshipSchemaName("contract_connections2")]
        public IEnumerable<Connection> contract_connections2
        {
            get { return GetRelatedEntities<Connection>("contract_connections2", null); }
            set
            {
                OnPropertyChanging("contract_connections2");
                SetRelatedEntities("contract_connections2", null, value);
                OnPropertyChanged("contract_connections2");
            }
        }

        /// <summary>
        ///     1:N Contract_DuplicateBaseRecord
        /// </summary>
        [RelationshipSchemaName("Contract_DuplicateBaseRecord")]
        public IEnumerable<DuplicateRecord> Contract_DuplicateBaseRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Contract_DuplicateBaseRecord", null); }
            set
            {
                OnPropertyChanging("Contract_DuplicateBaseRecord");
                SetRelatedEntities("Contract_DuplicateBaseRecord", null, value);
                OnPropertyChanged("Contract_DuplicateBaseRecord");
            }
        }

        /// <summary>
        ///     1:N Contract_DuplicateMatchingRecord
        /// </summary>
        [RelationshipSchemaName("Contract_DuplicateMatchingRecord")]
        public IEnumerable<DuplicateRecord> Contract_DuplicateMatchingRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Contract_DuplicateMatchingRecord", null); }
            set
            {
                OnPropertyChanging("Contract_DuplicateMatchingRecord");
                SetRelatedEntities("Contract_DuplicateMatchingRecord", null, value);
                OnPropertyChanged("Contract_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        ///     1:N Contract_Emails
        /// </summary>
        [RelationshipSchemaName("Contract_Emails")]
        public IEnumerable<Email> Contract_Emails
        {
            get { return GetRelatedEntities<Email>("Contract_Emails", null); }
            set
            {
                OnPropertyChanging("Contract_Emails");
                SetRelatedEntities("Contract_Emails", null, value);
                OnPropertyChanged("Contract_Emails");
            }
        }

        /// <summary>
        ///     1:N Contract_Faxes
        /// </summary>
        [RelationshipSchemaName("Contract_Faxes")]
        public IEnumerable<Fax> Contract_Faxes
        {
            get { return GetRelatedEntities<Fax>("Contract_Faxes", null); }
            set
            {
                OnPropertyChanging("Contract_Faxes");
                SetRelatedEntities("Contract_Faxes", null, value);
                OnPropertyChanged("Contract_Faxes");
            }
        }

        /// <summary>
        ///     1:N Contract_Letters
        /// </summary>
        [RelationshipSchemaName("Contract_Letters")]
        public IEnumerable<Letter> Contract_Letters
        {
            get { return GetRelatedEntities<Letter>("Contract_Letters", null); }
            set
            {
                OnPropertyChanging("Contract_Letters");
                SetRelatedEntities("Contract_Letters", null, value);
                OnPropertyChanged("Contract_Letters");
            }
        }

        /// <summary>
        ///     1:N contract_line_items
        /// </summary>
        [RelationshipSchemaName("contract_line_items")]
        public IEnumerable<ContractDetail> contract_line_items
        {
            get { return GetRelatedEntities<ContractDetail>("contract_line_items", null); }
            set
            {
                OnPropertyChanging("contract_line_items");
                SetRelatedEntities("contract_line_items", null, value);
                OnPropertyChanged("contract_line_items");
            }
        }

        /// <summary>
        ///     1:N contract_originating_contract
        /// </summary>
        [RelationshipSchemaName("contract_originating_contract", EntityRole.Referenced)]
        public IEnumerable<Contract> Referencedcontract_originating_contract
        {
            get { return GetRelatedEntities<Contract>("contract_originating_contract", EntityRole.Referenced); }
            set
            {
                OnPropertyChanging("Referencedcontract_originating_contract");
                SetRelatedEntities("contract_originating_contract", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedcontract_originating_contract");
            }
        }

        /// <summary>
        ///     1:N Contract_Phonecalls
        /// </summary>
        [RelationshipSchemaName("Contract_Phonecalls")]
        public IEnumerable<PhoneCall> Contract_Phonecalls
        {
            get { return GetRelatedEntities<PhoneCall>("Contract_Phonecalls", null); }
            set
            {
                OnPropertyChanging("Contract_Phonecalls");
                SetRelatedEntities("Contract_Phonecalls", null, value);
                OnPropertyChanged("Contract_Phonecalls");
            }
        }

        /// <summary>
        ///     1:N contract_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("contract_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> contract_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntities<PrincipalObjectAttributeAccess>("contract_principalobjectattributeaccess",
                    null);
            }
            set
            {
                OnPropertyChanging("contract_principalobjectattributeaccess");
                SetRelatedEntities("contract_principalobjectattributeaccess", null, value);
                OnPropertyChanged("contract_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N Contract_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("Contract_ProcessSessions")]
        public IEnumerable<ProcessSession> Contract_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("Contract_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Contract_ProcessSessions");
                SetRelatedEntities("Contract_ProcessSessions", null, value);
                OnPropertyChanged("Contract_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N Contract_RecurringAppointmentMasters
        /// </summary>
        [RelationshipSchemaName("Contract_RecurringAppointmentMasters")]
        public IEnumerable<RecurringAppointmentMaster> Contract_RecurringAppointmentMasters
        {
            get { return GetRelatedEntities<RecurringAppointmentMaster>("Contract_RecurringAppointmentMasters", null); }
            set
            {
                OnPropertyChanging("Contract_RecurringAppointmentMasters");
                SetRelatedEntities("Contract_RecurringAppointmentMasters", null, value);
                OnPropertyChanged("Contract_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        ///     1:N Contract_ServiceAppointments
        /// </summary>
        [RelationshipSchemaName("Contract_ServiceAppointments")]
        public IEnumerable<ServiceAppointment> Contract_ServiceAppointments
        {
            get { return GetRelatedEntities<ServiceAppointment>("Contract_ServiceAppointments", null); }
            set
            {
                OnPropertyChanging("Contract_ServiceAppointments");
                SetRelatedEntities("Contract_ServiceAppointments", null, value);
                OnPropertyChanged("Contract_ServiceAppointments");
            }
        }

        /// <summary>
        ///     1:N Contract_Tasks
        /// </summary>
        [RelationshipSchemaName("Contract_Tasks")]
        public IEnumerable<Task> Contract_Tasks
        {
            get { return GetRelatedEntities<Task>("Contract_Tasks", null); }
            set
            {
                OnPropertyChanging("Contract_Tasks");
                SetRelatedEntities("Contract_Tasks", null, value);
                OnPropertyChanged("Contract_Tasks");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_contract
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_contract")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_contract
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_contract", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_contract");
                SetRelatedEntities("userentityinstancedata_contract", null, value);
                OnPropertyChanged("userentityinstancedata_contract");
            }
        }

        /// <summary>
        ///     N:N servicecontractcontacts_association
        /// </summary>
        [RelationshipSchemaName("servicecontractcontacts_association")]
        public IEnumerable<Contact> servicecontractcontacts_association
        {
            get { return GetRelatedEntities<Contact>("servicecontractcontacts_association", null); }
            set
            {
                OnPropertyChanging("servicecontractcontacts_association");
                SetRelatedEntities("servicecontractcontacts_association", null, value);
                OnPropertyChanged("servicecontractcontacts_association");
            }
        }

        /// <summary>
        ///     N:1 business_unit_service_contracts
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_service_contracts")]
        public BusinessUnit business_unit_service_contracts
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_service_contracts", null); }
        }

        /// <summary>
        ///     N:1 contract_billingcustomer_accounts
        /// </summary>
        [AttributeLogicalName("billingcustomerid")]
        [RelationshipSchemaName("contract_billingcustomer_accounts")]
        public Account contract_billingcustomer_accounts
        {
            get { return GetRelatedEntity<Account>("contract_billingcustomer_accounts", null); }
            set
            {
                OnPropertyChanging("contract_billingcustomer_accounts");
                SetRelatedEntity("contract_billingcustomer_accounts", null, value);
                OnPropertyChanged("contract_billingcustomer_accounts");
            }
        }

        /// <summary>
        ///     N:1 contract_billingcustomer_contacts
        /// </summary>
        [AttributeLogicalName("billingcustomerid")]
        [RelationshipSchemaName("contract_billingcustomer_contacts")]
        public Contact contract_billingcustomer_contacts
        {
            get { return GetRelatedEntity<Contact>("contract_billingcustomer_contacts", null); }
            set
            {
                OnPropertyChanging("contract_billingcustomer_contacts");
                SetRelatedEntity("contract_billingcustomer_contacts", null, value);
                OnPropertyChanged("contract_billingcustomer_contacts");
            }
        }

        /// <summary>
        ///     N:1 contract_customer_accounts
        /// </summary>
        [AttributeLogicalName("customerid")]
        [RelationshipSchemaName("contract_customer_accounts")]
        public Account contract_customer_accounts
        {
            get { return GetRelatedEntity<Account>("contract_customer_accounts", null); }
            set
            {
                OnPropertyChanging("contract_customer_accounts");
                SetRelatedEntity("contract_customer_accounts", null, value);
                OnPropertyChanged("contract_customer_accounts");
            }
        }

        /// <summary>
        ///     N:1 contract_customer_contacts
        /// </summary>
        [AttributeLogicalName("customerid")]
        [RelationshipSchemaName("contract_customer_contacts")]
        public Contact contract_customer_contacts
        {
            get { return GetRelatedEntity<Contact>("contract_customer_contacts", null); }
            set
            {
                OnPropertyChanging("contract_customer_contacts");
                SetRelatedEntity("contract_customer_contacts", null, value);
                OnPropertyChanged("contract_customer_contacts");
            }
        }

        /// <summary>
        ///     N:1 contract_originating_contract
        /// </summary>
        [AttributeLogicalName("originatingcontract")]
        [RelationshipSchemaName("contract_originating_contract", EntityRole.Referencing)]
        public Contract Referencingcontract_originating_contract
        {
            get { return GetRelatedEntity<Contract>("contract_originating_contract", EntityRole.Referencing); }
            set
            {
                OnPropertyChanging("Referencingcontract_originating_contract");
                SetRelatedEntity("contract_originating_contract", EntityRole.Referencing, value);
                OnPropertyChanged("Referencingcontract_originating_contract");
            }
        }

        /// <summary>
        ///     N:1 contract_template_contracts
        /// </summary>
        [AttributeLogicalName("contracttemplateid")]
        [RelationshipSchemaName("contract_template_contracts")]
        public ContractTemplate contract_template_contracts
        {
            get { return GetRelatedEntity<ContractTemplate>("contract_template_contracts", null); }
            set
            {
                OnPropertyChanging("contract_template_contracts");
                SetRelatedEntity("contract_template_contracts", null, value);
                OnPropertyChanged("contract_template_contracts");
            }
        }

        /// <summary>
        ///     N:1 customer_address_contracts_as_billing_address
        /// </summary>
        [AttributeLogicalName("billtoaddress")]
        [RelationshipSchemaName("customer_address_contracts_as_billing_address")]
        public CustomerAddress customer_address_contracts_as_billing_address
        {
            get { return GetRelatedEntity<CustomerAddress>("customer_address_contracts_as_billing_address", null); }
            set
            {
                OnPropertyChanging("customer_address_contracts_as_billing_address");
                SetRelatedEntity("customer_address_contracts_as_billing_address", null, value);
                OnPropertyChanged("customer_address_contracts_as_billing_address");
            }
        }

        /// <summary>
        ///     N:1 customer_address_contracts_as_service_address
        /// </summary>
        [AttributeLogicalName("serviceaddress")]
        [RelationshipSchemaName("customer_address_contracts_as_service_address")]
        public CustomerAddress customer_address_contracts_as_service_address
        {
            get { return GetRelatedEntity<CustomerAddress>("customer_address_contracts_as_service_address", null); }
            set
            {
                OnPropertyChanging("customer_address_contracts_as_service_address");
                SetRelatedEntity("customer_address_contracts_as_service_address", null, value);
                OnPropertyChanged("customer_address_contracts_as_service_address");
            }
        }

        /// <summary>
        ///     N:1 lk_contract_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_contract_createdonbehalfby")]
        public SystemUser lk_contract_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_contract_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_contract_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_contract_modifiedonbehalfby")]
        public SystemUser lk_contract_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_contract_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_contractbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_contractbase_createdby")]
        public SystemUser lk_contractbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_contractbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_contractbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_contractbase_modifiedby")]
        public SystemUser lk_contractbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_contractbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 system_user_service_contracts
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("system_user_service_contracts")]
        public SystemUser system_user_service_contracts
        {
            get { return GetRelatedEntity<SystemUser>("system_user_service_contracts", null); }
        }

        /// <summary>
        ///     N:1 team_service_contracts
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_service_contracts")]
        public Team team_service_contracts
        {
            get { return GetRelatedEntity<Team>("team_service_contracts", null); }
        }

        /// <summary>
        ///     N:1 transactioncurrency_contract
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("transactioncurrency_contract")]
        public TransactionCurrency transactioncurrency_contract
        {
            get { return GetRelatedEntity<TransactionCurrency>("transactioncurrency_contract", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_contract");
                SetRelatedEntity("transactioncurrency_contract", null, value);
                OnPropertyChanged("transactioncurrency_contract");
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