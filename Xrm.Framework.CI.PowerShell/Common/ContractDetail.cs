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
    ///     Line item in a contract that specifies the type of service a customer is entitled to.
    /// </summary>
    [DataContract]
    [EntityLogicalName("contractdetail")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ContractDetail : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "contractdetail";

        public const int EntityTypeCode = 1011;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ContractDetail() :
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
        ///     Enter the date when the contract line becomes active.
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
        ///     Shows the number of minutes over the Total Allotments field that have been spent on resolved cases related to the
        ///     contract line.
        /// </summary>
        [AttributeLogicalName("allotmentsoverage")]
        public int? AllotmentsOverage
        {
            get { return GetAttributeValue<int?>("allotmentsoverage"); }
        }

        /// <summary>
        ///     Shows the number of cases or minutes remaining, based on the resolved cases logged to the contract line.
        /// </summary>
        [AttributeLogicalName("allotmentsremaining")]
        public int? AllotmentsRemaining
        {
            get { return GetAttributeValue<int?>("allotmentsremaining"); }
        }

        /// <summary>
        ///     Shows the number of cases or minutes used in the resolved cases on the contract line.
        /// </summary>
        [AttributeLogicalName("allotmentsused")]
        public int? AllotmentsUsed
        {
            get { return GetAttributeValue<int?>("allotmentsused"); }
        }

        /// <summary>
        ///     Unique identifier for the contact associated with the contract line.
        /// </summary>
        [AttributeLogicalName("contactid")]
        public EntityReference ContactId
        {
            get { return GetAttributeValue<EntityReference>("contactid"); }
        }

        /// <summary>
        ///     Unique identifier of the contract line.
        /// </summary>
        [AttributeLogicalName("contractdetailid")]
        public Guid? ContractDetailId
        {
            get { return GetAttributeValue<Guid?>("contractdetailid"); }
            set
            {
                OnPropertyChanging("ContractDetailId");
                SetAttributeValue("contractdetailid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ContractDetailId");
            }
        }

        [AttributeLogicalName("contractdetailid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ContractDetailId = value; }
        }

        /// <summary>
        ///     Unique identifier of the contract associated with the contract line.
        /// </summary>
        [AttributeLogicalName("contractid")]
        public EntityReference ContractId
        {
            get { return GetAttributeValue<EntityReference>("contractid"); }
            set
            {
                OnPropertyChanging("ContractId");
                SetAttributeValue("contractid", value);
                OnPropertyChanged("ContractId");
            }
        }

        /// <summary>
        ///     Status of the contract.
        /// </summary>
        [AttributeLogicalName("contractstatecode")]
        public OptionSetValue ContractStateCode
        {
            get { return GetAttributeValue<OptionSetValue>("contractstatecode"); }
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
        ///     Type the discount amount for the contract line to deduct any negotiated or other savings from the net amount due.
        /// </summary>
        [AttributeLogicalName("discount")]
        public Money Discount
        {
            get { return GetAttributeValue<Money>("discount"); }
            set
            {
                OnPropertyChanging("Discount");
                SetAttributeValue("discount", value);
                OnPropertyChanged("Discount");
            }
        }

        /// <summary>
        ///     Shows the Discount field converted to the system's default base currency. The calculation uses the exchange rate
        ///     specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("discount_base")]
        public Money Discount_Base
        {
            get { return GetAttributeValue<Money>("discount_base"); }
        }

        /// <summary>
        ///     Type the discount rate that should be applied to the Total Price, for use in calculating the net amount due for the
        ///     contract line.
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
        ///     Days of the week and times for which the contract line item is effective.
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
        ///     Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the
        ///     record from the local currency to the system's default currency.
        /// </summary>
        [AttributeLogicalName("exchangerate")]
        public decimal? ExchangeRate
        {
            get { return GetAttributeValue<decimal?>("exchangerate"); }
        }

        /// <summary>
        ///     Enter the date when the contract line expires. The date is automatically filled with the contract date, but you can
        ///     change it if required.
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
        ///     Type the number of units of the specified product or service that are eligible for support on the contract line.
        /// </summary>
        [AttributeLogicalName("initialquantity")]
        public int? InitialQuantity
        {
            get { return GetAttributeValue<int?>("initialquantity"); }
            set
            {
                OnPropertyChanging("InitialQuantity");
                SetAttributeValue("initialquantity", value);
                OnPropertyChanged("InitialQuantity");
            }
        }

        /// <summary>
        ///     Type the line item number for the contract line to easily identify the contract line and make sure it's listed in
        ///     the correct order in the parent contract.
        /// </summary>
        [AttributeLogicalName("lineitemorder")]
        public int? LineItemOrder
        {
            get { return GetAttributeValue<int?>("lineitemorder"); }
            set
            {
                OnPropertyChanging("LineItemOrder");
                SetAttributeValue("lineitemorder", value);
                OnPropertyChanged("LineItemOrder");
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
        ///     Shows the total charge to the customer for the contract line, calculated as the Total Price minus any discounts.
        /// </summary>
        [AttributeLogicalName("net")]
        public Money Net
        {
            get { return GetAttributeValue<Money>("net"); }
        }

        /// <summary>
        ///     Shows the Net field converted to the system's default base currency for reporting purposes. The calculation uses
        ///     the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("net_base")]
        public Money Net_Base
        {
            get { return GetAttributeValue<Money>("net_base"); }
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
        ///     Unique identifier of the user or team who owns the contract detail.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId
        {
            get { return GetAttributeValue<EntityReference>("ownerid"); }
        }

        /// <summary>
        ///     Unique identifier of the business unit that owns the contract line.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public Guid? OwningBusinessUnit
        {
            get { return GetAttributeValue<Guid?>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the contract line.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public Guid? OwningUser
        {
            get { return GetAttributeValue<Guid?>("owninguser"); }
        }

        /// <summary>
        ///     Type the total service charge for the contract line before any discounts are credited.
        /// </summary>
        [AttributeLogicalName("price")]
        public Money Price
        {
            get { return GetAttributeValue<Money>("price"); }
            set
            {
                OnPropertyChanging("Price");
                SetAttributeValue("price", value);
                OnPropertyChanged("Price");
            }
        }

        /// <summary>
        ///     Shows the Total Price field converted to the system's default base currency for reporting purposes. The calculation
        ///     uses the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("price_base")]
        public Money Price_Base
        {
            get { return GetAttributeValue<Money>("price_base"); }
        }

        /// <summary>
        ///     Choose the product that is eligible for services on the contract line.
        /// </summary>
        [AttributeLogicalName("productid")]
        public EntityReference ProductId
        {
            get { return GetAttributeValue<EntityReference>("productid"); }
            set
            {
                OnPropertyChanging("ProductId");
                SetAttributeValue("productid", value);
                OnPropertyChanged("ProductId");
            }
        }

        /// <summary>
        ///     Type the serial number for the product that is eligible for services on the contract line.
        /// </summary>
        [AttributeLogicalName("productserialnumber")]
        public string ProductSerialNumber
        {
            get { return GetAttributeValue<string>("productserialnumber"); }
            set
            {
                OnPropertyChanging("ProductSerialNumber");
                SetAttributeValue("productserialnumber", value);
                OnPropertyChanged("ProductSerialNumber");
            }
        }

        /// <summary>
        ///     Shows the cost per case or minute, calculated by dividing the Total Price value by the total number of cases or
        ///     minutes allocated to the contract line.
        /// </summary>
        [AttributeLogicalName("rate")]
        public Money Rate
        {
            get { return GetAttributeValue<Money>("rate"); }
        }

        /// <summary>
        ///     Shows the Rate field converted to the system's default base currency for reporting purposes. The calculation uses
        ///     the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("rate_base")]
        public Money Rate_Base
        {
            get { return GetAttributeValue<Money>("rate_base"); }
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
        ///     Select the unit type allotted in the contract line, such as cases or minutes, to determine the level of support.
        /// </summary>
        [AttributeLogicalName("servicecontractunitscode")]
        public OptionSetValue ServiceContractUnitsCode
        {
            get { return GetAttributeValue<OptionSetValue>("servicecontractunitscode"); }
            set
            {
                OnPropertyChanging("ServiceContractUnitsCode");
                SetAttributeValue("servicecontractunitscode", value);
                OnPropertyChanged("ServiceContractUnitsCode");
            }
        }

        /// <summary>
        ///     Shows whether the contract line is existing, renewed, canceled, or expired. You can't edit a contract line after it
        ///     is saved, regardless of the status.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public ContractDetailState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ContractDetailState) (Enum.ToObject(typeof (ContractDetailState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Select the contract line's status.
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
        ///     Type a title or name that describes the contract line.
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
        ///     Type the total number of minutes or cases allowed for the contract line.
        /// </summary>
        [AttributeLogicalName("totalallotments")]
        public int? TotalAllotments
        {
            get { return GetAttributeValue<int?>("totalallotments"); }
            set
            {
                OnPropertyChanging("TotalAllotments");
                SetAttributeValue("totalallotments", value);
                OnPropertyChanged("TotalAllotments");
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
        ///     Choose the unit of measurement for the base unit quantity for this purchase, such as each or dozen.
        /// </summary>
        [AttributeLogicalName("uomid")]
        public EntityReference UoMId
        {
            get { return GetAttributeValue<EntityReference>("uomid"); }
            set
            {
                OnPropertyChanging("UoMId");
                SetAttributeValue("uomid", value);
                OnPropertyChanged("UoMId");
            }
        }

        /// <summary>
        ///     Unique identifier of the unit group associated with the contract line.
        /// </summary>
        [AttributeLogicalName("uomscheduleid")]
        public EntityReference UoMScheduleId
        {
            get { return GetAttributeValue<EntityReference>("uomscheduleid"); }
            set
            {
                OnPropertyChanging("UoMScheduleId");
                SetAttributeValue("uomscheduleid", value);
                OnPropertyChanged("UoMScheduleId");
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
        ///     Version number of the contract template.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N contract_detail_cases
        /// </summary>
        [RelationshipSchemaName("contract_detail_cases")]
        public IEnumerable<Incident> contract_detail_cases
        {
            get { return GetRelatedEntities<Incident>("contract_detail_cases", null); }
            set
            {
                OnPropertyChanging("contract_detail_cases");
                SetRelatedEntities("contract_detail_cases", null, value);
                OnPropertyChanged("contract_detail_cases");
            }
        }

        /// <summary>
        ///     1:N ContractDetail_Annotation
        /// </summary>
        [RelationshipSchemaName("ContractDetail_Annotation")]
        public IEnumerable<Annotation> ContractDetail_Annotation
        {
            get { return GetRelatedEntities<Annotation>("ContractDetail_Annotation", null); }
            set
            {
                OnPropertyChanging("ContractDetail_Annotation");
                SetRelatedEntities("ContractDetail_Annotation", null, value);
                OnPropertyChanged("ContractDetail_Annotation");
            }
        }

        /// <summary>
        ///     1:N ContractDetail_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("ContractDetail_AsyncOperations")]
        public IEnumerable<AsyncOperation> ContractDetail_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("ContractDetail_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("ContractDetail_AsyncOperations");
                SetRelatedEntities("ContractDetail_AsyncOperations", null, value);
                OnPropertyChanged("ContractDetail_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N ContractDetail_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("ContractDetail_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> ContractDetail_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("ContractDetail_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("ContractDetail_BulkDeleteFailures");
                SetRelatedEntities("ContractDetail_BulkDeleteFailures", null, value);
                OnPropertyChanged("ContractDetail_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N contractdetail_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("contractdetail_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> contractdetail_principalobjectattributeaccess
        {
            get
            {
                return
                    GetRelatedEntities<PrincipalObjectAttributeAccess>("contractdetail_principalobjectattributeaccess",
                        null);
            }
            set
            {
                OnPropertyChanging("contractdetail_principalobjectattributeaccess");
                SetRelatedEntities("contractdetail_principalobjectattributeaccess", null, value);
                OnPropertyChanged("contractdetail_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N ContractDetail_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("ContractDetail_ProcessSessions")]
        public IEnumerable<ProcessSession> ContractDetail_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("ContractDetail_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("ContractDetail_ProcessSessions");
                SetRelatedEntities("ContractDetail_ProcessSessions", null, value);
                OnPropertyChanged("ContractDetail_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_contractdetail
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_contractdetail")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_contractdetail
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_contractdetail", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_contractdetail");
                SetRelatedEntities("userentityinstancedata_contractdetail", null, value);
                OnPropertyChanged("userentityinstancedata_contractdetail");
            }
        }

        /// <summary>
        ///     N:1 contract_detail_unit_of_measure_schedule
        /// </summary>
        [AttributeLogicalName("uomscheduleid")]
        [RelationshipSchemaName("contract_detail_unit_of_measure_schedule")]
        public UoMSchedule contract_detail_unit_of_measure_schedule
        {
            get { return GetRelatedEntity<UoMSchedule>("contract_detail_unit_of_measure_schedule", null); }
            set
            {
                OnPropertyChanging("contract_detail_unit_of_measure_schedule");
                SetRelatedEntity("contract_detail_unit_of_measure_schedule", null, value);
                OnPropertyChanged("contract_detail_unit_of_measure_schedule");
            }
        }

        /// <summary>
        ///     N:1 contract_line_items
        /// </summary>
        [AttributeLogicalName("contractid")]
        [RelationshipSchemaName("contract_line_items")]
        public Contract contract_line_items
        {
            get { return GetRelatedEntity<Contract>("contract_line_items", null); }
            set
            {
                OnPropertyChanging("contract_line_items");
                SetRelatedEntity("contract_line_items", null, value);
                OnPropertyChanged("contract_line_items");
            }
        }

        /// <summary>
        ///     N:1 contractlineitem_customer_accounts
        /// </summary>
        [AttributeLogicalName("customerid")]
        [RelationshipSchemaName("contractlineitem_customer_accounts")]
        public Account contractlineitem_customer_accounts
        {
            get { return GetRelatedEntity<Account>("contractlineitem_customer_accounts", null); }
            set
            {
                OnPropertyChanging("contractlineitem_customer_accounts");
                SetRelatedEntity("contractlineitem_customer_accounts", null, value);
                OnPropertyChanged("contractlineitem_customer_accounts");
            }
        }

        /// <summary>
        ///     N:1 contractlineitem_customer_contacts
        /// </summary>
        [AttributeLogicalName("customerid")]
        [RelationshipSchemaName("contractlineitem_customer_contacts")]
        public Contact contractlineitem_customer_contacts
        {
            get { return GetRelatedEntity<Contact>("contractlineitem_customer_contacts", null); }
            set
            {
                OnPropertyChanging("contractlineitem_customer_contacts");
                SetRelatedEntity("contractlineitem_customer_contacts", null, value);
                OnPropertyChanged("contractlineitem_customer_contacts");
            }
        }

        /// <summary>
        ///     N:1 customer_address_contract_line_items
        /// </summary>
        [AttributeLogicalName("serviceaddress")]
        [RelationshipSchemaName("customer_address_contract_line_items")]
        public CustomerAddress customer_address_contract_line_items
        {
            get { return GetRelatedEntity<CustomerAddress>("customer_address_contract_line_items", null); }
            set
            {
                OnPropertyChanging("customer_address_contract_line_items");
                SetRelatedEntity("customer_address_contract_line_items", null, value);
                OnPropertyChanged("customer_address_contract_line_items");
            }
        }

        /// <summary>
        ///     N:1 lk_contractdetail_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_contractdetail_createdonbehalfby")]
        public SystemUser lk_contractdetail_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_contractdetail_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_contractdetail_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_contractdetail_modifiedonbehalfby")]
        public SystemUser lk_contractdetail_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_contractdetail_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_contractdetailbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_contractdetailbase_createdby")]
        public SystemUser lk_contractdetailbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_contractdetailbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_contractdetailbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_contractdetailbase_modifiedby")]
        public SystemUser lk_contractdetailbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_contractdetailbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 product_contract_line_items
        /// </summary>
        [AttributeLogicalName("productid")]
        [RelationshipSchemaName("product_contract_line_items")]
        public Product product_contract_line_items
        {
            get { return GetRelatedEntity<Product>("product_contract_line_items", null); }
            set
            {
                OnPropertyChanging("product_contract_line_items");
                SetRelatedEntity("product_contract_line_items", null, value);
                OnPropertyChanged("product_contract_line_items");
            }
        }

        /// <summary>
        ///     N:1 transactioncurrency_contractdetail
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("transactioncurrency_contractdetail")]
        public TransactionCurrency transactioncurrency_contractdetail
        {
            get { return GetRelatedEntity<TransactionCurrency>("transactioncurrency_contractdetail", null); }
        }

        /// <summary>
        ///     N:1 unit_of_measurement_contract_line_items
        /// </summary>
        [AttributeLogicalName("uomid")]
        [RelationshipSchemaName("unit_of_measurement_contract_line_items")]
        public UoM unit_of_measurement_contract_line_items
        {
            get { return GetRelatedEntity<UoM>("unit_of_measurement_contract_line_items", null); }
            set
            {
                OnPropertyChanging("unit_of_measurement_contract_line_items");
                SetRelatedEntity("unit_of_measurement_contract_line_items", null, value);
                OnPropertyChanged("unit_of_measurement_contract_line_items");
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