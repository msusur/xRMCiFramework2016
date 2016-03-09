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
    ///     Product line item in a quote. The details include such information as product ID, description, quantity, and cost.
    /// </summary>
    [DataContract]
    [EntityLogicalName("quotedetail")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class QuoteDetail : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "quotedetail";

        public const int EntityTypeCode = 1085;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public QuoteDetail() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Shows the total price of the quote product, based on the price per unit, volume discount, and quantity.
        /// </summary>
        [AttributeLogicalName("baseamount")]
        public Money BaseAmount
        {
            get { return GetAttributeValue<Money>("baseamount"); }
        }

        /// <summary>
        ///     Shows the Amount field converted to the system's default base currency. The calculation uses the exchange rate
        ///     specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("baseamount_base")]
        public Money BaseAmount_Base
        {
            get { return GetAttributeValue<Money>("baseamount_base"); }
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
        ///     Type additional information to describe the quote product, such as manufacturing details or acceptable
        ///     substitutions.
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
        ///     Shows the total amount due for the quote product, based on the sum of the unit price, quantity, discounts ,and tax.
        /// </summary>
        [AttributeLogicalName("extendedamount")]
        public Money ExtendedAmount
        {
            get { return GetAttributeValue<Money>("extendedamount"); }
        }

        /// <summary>
        ///     Shows the Extended Amount field converted to the system's default base currency. The calculation uses the exchange
        ///     rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("extendedamount_base")]
        public Money ExtendedAmount_Base
        {
            get { return GetAttributeValue<Money>("extendedamount_base"); }
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
        ///     Select whether the price per unit is fixed at the value in the specified price list or can be overridden by users
        ///     who have edit rights to the quote product.
        /// </summary>
        [AttributeLogicalName("ispriceoverridden")]
        public bool? IsPriceOverridden
        {
            get { return GetAttributeValue<bool?>("ispriceoverridden"); }
            set
            {
                OnPropertyChanging("IsPriceOverridden");
                SetAttributeValue("ispriceoverridden", value);
                OnPropertyChanged("IsPriceOverridden");
            }
        }

        /// <summary>
        ///     Select whether the product exists in the Microsoft Dynamics CRM product catalog or is a write-in product specific
        ///     to the quote.
        /// </summary>
        [AttributeLogicalName("isproductoverridden")]
        public bool? IsProductOverridden
        {
            get { return GetAttributeValue<bool?>("isproductoverridden"); }
            set
            {
                OnPropertyChanging("IsProductOverridden");
                SetAttributeValue("isproductoverridden", value);
                OnPropertyChanged("IsProductOverridden");
            }
        }

        /// <summary>
        ///     Type the line item number for the quote product to easily identify the product in the quote and make sure it's
        ///     listed in the correct order.
        /// </summary>
        [AttributeLogicalName("lineitemnumber")]
        public int? LineItemNumber
        {
            get { return GetAttributeValue<int?>("lineitemnumber"); }
            set
            {
                OnPropertyChanging("LineItemNumber");
                SetAttributeValue("lineitemnumber", value);
                OnPropertyChanged("LineItemNumber");
            }
        }

        /// <summary>
        ///     Type the manual discount amount for the quote product to deduct any negotiated or other savings from the product
        ///     total on the quote.
        /// </summary>
        [AttributeLogicalName("manualdiscountamount")]
        public Money ManualDiscountAmount
        {
            get { return GetAttributeValue<Money>("manualdiscountamount"); }
            set
            {
                OnPropertyChanging("ManualDiscountAmount");
                SetAttributeValue("manualdiscountamount", value);
                OnPropertyChanged("ManualDiscountAmount");
            }
        }

        /// <summary>
        ///     Shows the Manual Discount field converted to the system's default base currency for reporting purposes. The
        ///     calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("manualdiscountamount_base")]
        public Money ManualDiscountAmount_Base
        {
            get { return GetAttributeValue<Money>("manualdiscountamount_base"); }
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
        ///     Unique identifier of the user or team who owns the quote detail.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId
        {
            get { return GetAttributeValue<EntityReference>("ownerid"); }
        }

        /// <summary>
        ///     Unique identifier of the business unit that owns the quote detail.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public Guid? OwningBusinessUnit
        {
            get { return GetAttributeValue<Guid?>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the quote detail.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public Guid? OwningUser
        {
            get { return GetAttributeValue<Guid?>("owninguser"); }
        }

        /// <summary>
        ///     Type the price per unit of the quote product. The default is to the value in the price list specified on the quote
        ///     for existing products.
        /// </summary>
        [AttributeLogicalName("priceperunit")]
        public Money PricePerUnit
        {
            get { return GetAttributeValue<Money>("priceperunit"); }
            set
            {
                OnPropertyChanging("PricePerUnit");
                SetAttributeValue("priceperunit", value);
                OnPropertyChanged("PricePerUnit");
            }
        }

        /// <summary>
        ///     Shows the Price Per Unit field converted to the system's default base currency for reporting purposes. The
        ///     calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("priceperunit_base")]
        public Money PricePerUnit_Base
        {
            get { return GetAttributeValue<Money>("priceperunit_base"); }
        }

        /// <summary>
        ///     Select the type of pricing error, such as a missing or invalid product, or missing quantity.
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
        ///     Type a name or description to identify the type of write-in product included in the quote.
        /// </summary>
        [AttributeLogicalName("productdescription")]
        public string ProductDescription
        {
            get { return GetAttributeValue<string>("productdescription"); }
            set
            {
                OnPropertyChanging("ProductDescription");
                SetAttributeValue("productdescription", value);
                OnPropertyChanged("ProductDescription");
            }
        }

        /// <summary>
        ///     Choose the product to include on the quote to link the product's pricing and other information to the quote.
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
        ///     Type the amount or quantity of the product requested by the customer.
        /// </summary>
        [AttributeLogicalName("quantity")]
        public decimal? Quantity
        {
            get { return GetAttributeValue<decimal?>("quantity"); }
            set
            {
                OnPropertyChanging("Quantity");
                SetAttributeValue("quantity", value);
                OnPropertyChanged("Quantity");
            }
        }

        /// <summary>
        ///     Unique identifier of the product line item in the quote.
        /// </summary>
        [AttributeLogicalName("quotedetailid")]
        public Guid? QuoteDetailId
        {
            get { return GetAttributeValue<Guid?>("quotedetailid"); }
            set
            {
                OnPropertyChanging("QuoteDetailId");
                SetAttributeValue("quotedetailid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("QuoteDetailId");
            }
        }

        [AttributeLogicalName("quotedetailid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { QuoteDetailId = value; }
        }

        /// <summary>
        ///     Unique identifier of the quote for the quote product.
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
        ///     Status of the quote product.
        /// </summary>
        [AttributeLogicalName("quotestatecode")]
        public OptionSetValue QuoteStateCode
        {
            get { return GetAttributeValue<OptionSetValue>("quotestatecode"); }
        }

        /// <summary>
        ///     Enter the delivery date requested by the customer for the quote product.
        /// </summary>
        [AttributeLogicalName("requestdeliveryby")]
        public DateTime? RequestDeliveryBy
        {
            get { return GetAttributeValue<DateTime?>("requestdeliveryby"); }
            set
            {
                OnPropertyChanging("RequestDeliveryBy");
                SetAttributeValue("requestdeliveryby", value);
                OnPropertyChanged("RequestDeliveryBy");
            }
        }

        /// <summary>
        ///     Choose the user responsible for the sale of the quote product.
        /// </summary>
        [AttributeLogicalName("salesrepid")]
        public EntityReference SalesRepId
        {
            get { return GetAttributeValue<EntityReference>("salesrepid"); }
            set
            {
                OnPropertyChanging("SalesRepId");
                SetAttributeValue("salesrepid", value);
                OnPropertyChanged("SalesRepId");
            }
        }

        /// <summary>
        ///     Unique identifier of the data that maintains the sequence.
        /// </summary>
        [AttributeLogicalName("sequencenumber")]
        public int? SequenceNumber
        {
            get { return GetAttributeValue<int?>("sequencenumber"); }
            set
            {
                OnPropertyChanging("SequenceNumber");
                SetAttributeValue("sequencenumber", value);
                OnPropertyChanged("SequenceNumber");
            }
        }

        /// <summary>
        ///     Unique identifier of the shipping address.
        /// </summary>
        [AttributeLogicalName("shipto_addressid")]
        public Guid? ShipTo_AddressId
        {
            get { return GetAttributeValue<Guid?>("shipto_addressid"); }
            set
            {
                OnPropertyChanging("ShipTo_AddressId");
                SetAttributeValue("shipto_addressid", value);
                OnPropertyChanged("ShipTo_AddressId");
            }
        }

        /// <summary>
        ///     Type the city for the customer's shipping address.
        /// </summary>
        [AttributeLogicalName("shipto_city")]
        public string ShipTo_City
        {
            get { return GetAttributeValue<string>("shipto_city"); }
            set
            {
                OnPropertyChanging("ShipTo_City");
                SetAttributeValue("shipto_city", value);
                OnPropertyChanged("ShipTo_City");
            }
        }

        /// <summary>
        ///     Type the primary contact name at the customer's shipping address.
        /// </summary>
        [AttributeLogicalName("shipto_contactname")]
        public string ShipTo_ContactName
        {
            get { return GetAttributeValue<string>("shipto_contactname"); }
            set
            {
                OnPropertyChanging("ShipTo_ContactName");
                SetAttributeValue("shipto_contactname", value);
                OnPropertyChanged("ShipTo_ContactName");
            }
        }

        /// <summary>
        ///     Type the country or region for the customer's shipping address.
        /// </summary>
        [AttributeLogicalName("shipto_country")]
        public string ShipTo_Country
        {
            get { return GetAttributeValue<string>("shipto_country"); }
            set
            {
                OnPropertyChanging("ShipTo_Country");
                SetAttributeValue("shipto_country", value);
                OnPropertyChanged("ShipTo_Country");
            }
        }

        /// <summary>
        ///     Type the fax number for the customer's shipping address.
        /// </summary>
        [AttributeLogicalName("shipto_fax")]
        public string ShipTo_Fax
        {
            get { return GetAttributeValue<string>("shipto_fax"); }
            set
            {
                OnPropertyChanging("ShipTo_Fax");
                SetAttributeValue("shipto_fax", value);
                OnPropertyChanged("ShipTo_Fax");
            }
        }

        /// <summary>
        ///     Select the freight terms to make sure shipping orders are processed correctly.
        /// </summary>
        [AttributeLogicalName("shipto_freighttermscode")]
        public OptionSetValue ShipTo_FreightTermsCode
        {
            get { return GetAttributeValue<OptionSetValue>("shipto_freighttermscode"); }
            set
            {
                OnPropertyChanging("ShipTo_FreightTermsCode");
                SetAttributeValue("shipto_freighttermscode", value);
                OnPropertyChanged("ShipTo_FreightTermsCode");
            }
        }

        /// <summary>
        ///     Type the first line of the customer's shipping address.
        /// </summary>
        [AttributeLogicalName("shipto_line1")]
        public string ShipTo_Line1
        {
            get { return GetAttributeValue<string>("shipto_line1"); }
            set
            {
                OnPropertyChanging("ShipTo_Line1");
                SetAttributeValue("shipto_line1", value);
                OnPropertyChanged("ShipTo_Line1");
            }
        }

        /// <summary>
        ///     Type the second line of the customer's shipping address.
        /// </summary>
        [AttributeLogicalName("shipto_line2")]
        public string ShipTo_Line2
        {
            get { return GetAttributeValue<string>("shipto_line2"); }
            set
            {
                OnPropertyChanging("ShipTo_Line2");
                SetAttributeValue("shipto_line2", value);
                OnPropertyChanged("ShipTo_Line2");
            }
        }

        /// <summary>
        ///     Type the third line of the shipping address.
        /// </summary>
        [AttributeLogicalName("shipto_line3")]
        public string ShipTo_Line3
        {
            get { return GetAttributeValue<string>("shipto_line3"); }
            set
            {
                OnPropertyChanging("ShipTo_Line3");
                SetAttributeValue("shipto_line3", value);
                OnPropertyChanged("ShipTo_Line3");
            }
        }

        /// <summary>
        ///     Type a name for the customer's shipping address, such as "Headquarters" or "Field office", to identify the address.
        /// </summary>
        [AttributeLogicalName("shipto_name")]
        public string ShipTo_Name
        {
            get { return GetAttributeValue<string>("shipto_name"); }
            set
            {
                OnPropertyChanging("ShipTo_Name");
                SetAttributeValue("shipto_name", value);
                OnPropertyChanged("ShipTo_Name");
            }
        }

        /// <summary>
        ///     Type the ZIP Code or postal code for the shipping address.
        /// </summary>
        [AttributeLogicalName("shipto_postalcode")]
        public string ShipTo_PostalCode
        {
            get { return GetAttributeValue<string>("shipto_postalcode"); }
            set
            {
                OnPropertyChanging("ShipTo_PostalCode");
                SetAttributeValue("shipto_postalcode", value);
                OnPropertyChanged("ShipTo_PostalCode");
            }
        }

        /// <summary>
        ///     Type the state or province for the shipping address.
        /// </summary>
        [AttributeLogicalName("shipto_stateorprovince")]
        public string ShipTo_StateOrProvince
        {
            get { return GetAttributeValue<string>("shipto_stateorprovince"); }
            set
            {
                OnPropertyChanging("ShipTo_StateOrProvince");
                SetAttributeValue("shipto_stateorprovince", value);
                OnPropertyChanged("ShipTo_StateOrProvince");
            }
        }

        /// <summary>
        ///     Type the phone number for the customer's shipping address.
        /// </summary>
        [AttributeLogicalName("shipto_telephone")]
        public string ShipTo_Telephone
        {
            get { return GetAttributeValue<string>("shipto_telephone"); }
            set
            {
                OnPropertyChanging("ShipTo_Telephone");
                SetAttributeValue("shipto_telephone", value);
                OnPropertyChanged("ShipTo_Telephone");
            }
        }

        /// <summary>
        ///     Type the tax amount for the quote product.
        /// </summary>
        [AttributeLogicalName("tax")]
        public Money Tax
        {
            get { return GetAttributeValue<Money>("tax"); }
            set
            {
                OnPropertyChanging("Tax");
                SetAttributeValue("tax", value);
                OnPropertyChanged("Tax");
            }
        }

        /// <summary>
        ///     Shows the Tax field converted to the system's default base currency for reporting purposes. The calculation uses
        ///     the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("tax_base")]
        public Money Tax_Base
        {
            get { return GetAttributeValue<Money>("tax_base"); }
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
        ///     Version number of the quote detail.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     Shows the discount amount per unit if a specified volume is purchased. Configure volume discounts in the Product
        ///     Catalog in the Settings area.
        /// </summary>
        [AttributeLogicalName("volumediscountamount")]
        public Money VolumeDiscountAmount
        {
            get { return GetAttributeValue<Money>("volumediscountamount"); }
        }

        /// <summary>
        ///     Shows the discount amount per unit if a specified volume is purchased. Configure volume discounts in the Product
        ///     Catalog in the Settings area.
        /// </summary>
        [AttributeLogicalName("volumediscountamount_base")]
        public Money VolumeDiscountAmount_Base
        {
            get { return GetAttributeValue<Money>("volumediscountamount_base"); }
        }

        /// <summary>
        ///     Select whether the quote product should be shipped to the specified address or held until the customer calls with
        ///     further pick up or delivery instructions.
        /// </summary>
        [AttributeLogicalName("willcall")]
        public bool? WillCall
        {
            get { return GetAttributeValue<bool?>("willcall"); }
            set
            {
                OnPropertyChanging("WillCall");
                SetAttributeValue("willcall", value);
                OnPropertyChanged("WillCall");
            }
        }

        /// <summary>
        ///     1:N QuoteDetail_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("QuoteDetail_AsyncOperations")]
        public IEnumerable<AsyncOperation> QuoteDetail_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("QuoteDetail_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("QuoteDetail_AsyncOperations");
                SetRelatedEntities("QuoteDetail_AsyncOperations", null, value);
                OnPropertyChanged("QuoteDetail_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N QuoteDetail_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("QuoteDetail_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> QuoteDetail_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("QuoteDetail_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("QuoteDetail_BulkDeleteFailures");
                SetRelatedEntities("QuoteDetail_BulkDeleteFailures", null, value);
                OnPropertyChanged("QuoteDetail_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N quotedetail_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("quotedetail_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> quotedetail_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntities<PrincipalObjectAttributeAccess>("quotedetail_principalobjectattributeaccess",
                    null);
            }
            set
            {
                OnPropertyChanging("quotedetail_principalobjectattributeaccess");
                SetRelatedEntities("quotedetail_principalobjectattributeaccess", null, value);
                OnPropertyChanged("quotedetail_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N QuoteDetail_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("QuoteDetail_ProcessSessions")]
        public IEnumerable<ProcessSession> QuoteDetail_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("QuoteDetail_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("QuoteDetail_ProcessSessions");
                SetRelatedEntities("QuoteDetail_ProcessSessions", null, value);
                OnPropertyChanged("QuoteDetail_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_quotedetail
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_quotedetail")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_quotedetail
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_quotedetail", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_quotedetail");
                SetRelatedEntities("userentityinstancedata_quotedetail", null, value);
                OnPropertyChanged("userentityinstancedata_quotedetail");
            }
        }

        /// <summary>
        ///     N:1 lk_quotedetail_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_quotedetail_createdonbehalfby")]
        public SystemUser lk_quotedetail_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_quotedetail_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_quotedetail_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_quotedetail_modifiedonbehalfby")]
        public SystemUser lk_quotedetail_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_quotedetail_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_quotedetailbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_quotedetailbase_createdby")]
        public SystemUser lk_quotedetailbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_quotedetailbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_quotedetailbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_quotedetailbase_modifiedby")]
        public SystemUser lk_quotedetailbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_quotedetailbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 product_quote_details
        /// </summary>
        [AttributeLogicalName("productid")]
        [RelationshipSchemaName("product_quote_details")]
        public Product product_quote_details
        {
            get { return GetRelatedEntity<Product>("product_quote_details", null); }
            set
            {
                OnPropertyChanging("product_quote_details");
                SetRelatedEntity("product_quote_details", null, value);
                OnPropertyChanged("product_quote_details");
            }
        }

        /// <summary>
        ///     N:1 quote_details
        /// </summary>
        [AttributeLogicalName("quoteid")]
        [RelationshipSchemaName("quote_details")]
        public Quote quote_details
        {
            get { return GetRelatedEntity<Quote>("quote_details", null); }
            set
            {
                OnPropertyChanging("quote_details");
                SetRelatedEntity("quote_details", null, value);
                OnPropertyChanged("quote_details");
            }
        }

        /// <summary>
        ///     N:1 system_user_quotedetail
        /// </summary>
        [AttributeLogicalName("salesrepid")]
        [RelationshipSchemaName("system_user_quotedetail")]
        public SystemUser system_user_quotedetail
        {
            get { return GetRelatedEntity<SystemUser>("system_user_quotedetail", null); }
            set
            {
                OnPropertyChanging("system_user_quotedetail");
                SetRelatedEntity("system_user_quotedetail", null, value);
                OnPropertyChanged("system_user_quotedetail");
            }
        }

        /// <summary>
        ///     N:1 transactioncurrency_quotedetail
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("transactioncurrency_quotedetail")]
        public TransactionCurrency transactioncurrency_quotedetail
        {
            get { return GetRelatedEntity<TransactionCurrency>("transactioncurrency_quotedetail", null); }
        }

        /// <summary>
        ///     N:1 unit_of_measurement_quote_details
        /// </summary>
        [AttributeLogicalName("uomid")]
        [RelationshipSchemaName("unit_of_measurement_quote_details")]
        public UoM unit_of_measurement_quote_details
        {
            get { return GetRelatedEntity<UoM>("unit_of_measurement_quote_details", null); }
            set
            {
                OnPropertyChanging("unit_of_measurement_quote_details");
                SetRelatedEntity("unit_of_measurement_quote_details", null, value);
                OnPropertyChanged("unit_of_measurement_quote_details");
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