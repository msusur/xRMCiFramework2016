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
    ///     Line item in a sales order.
    /// </summary>
    [DataContract]
    [EntityLogicalName("salesorderdetail")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class SalesOrderDetail : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "salesorderdetail";

        public const int EntityTypeCode = 1089;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public SalesOrderDetail() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Shows the total price of the order product, based on the price per unit, volume discount, and quantity.
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
        ///     Type additional information to describe the order product, such as manufacturing details or acceptable
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
        ///     Shows the total amount due for the order product, based on the sum of the unit price, quantity, discounts, and tax.
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
        ///     Select whether the invoice line item is copied from another item or data source.
        /// </summary>
        [AttributeLogicalName("iscopied")]
        public bool? IsCopied
        {
            get { return GetAttributeValue<bool?>("iscopied"); }
            set
            {
                OnPropertyChanging("IsCopied");
                SetAttributeValue("iscopied", value);
                OnPropertyChanged("IsCopied");
            }
        }

        /// <summary>
        ///     Select whether the price per unit is fixed at the value in the specified price list or can be overridden by users
        ///     who have edit rights to the order product.
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
        ///     to the order.
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
        ///     Type the line item number for the order product to easily identify the product in the order and make sure it's
        ///     listed in the correct sequence.
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
        ///     Type the manual discount amount for the order product to deduct any negotiated or other savings from the product
        ///     total on the order.
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
        ///     Enter the user or team who is assigned to manage the record. This field is updated every time the record is
        ///     assigned to a different user.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId
        {
            get { return GetAttributeValue<EntityReference>("ownerid"); }
        }

        /// <summary>
        ///     Unique identifier of the business unit that owns the order product.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public Guid? OwningBusinessUnit
        {
            get { return GetAttributeValue<Guid?>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the order product.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public Guid? OwningUser
        {
            get { return GetAttributeValue<Guid?>("owninguser"); }
        }

        /// <summary>
        ///     Type the price per unit of the order product. The default is the value in the price list specified on the order for
        ///     existing products.
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
        ///     Type a name or description to identify the type of write-in product included in the order.
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
        ///     Choose the product to include on the order to link the product's pricing and other information to the parent order.
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
        ///     Type the amount or quantity of the product ordered by the customer.
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
        ///     Type the amount or quantity of the product that is back ordered for the order.
        /// </summary>
        [AttributeLogicalName("quantitybackordered")]
        public decimal? QuantityBackordered
        {
            get { return GetAttributeValue<decimal?>("quantitybackordered"); }
            set
            {
                OnPropertyChanging("QuantityBackordered");
                SetAttributeValue("quantitybackordered", value);
                OnPropertyChanged("QuantityBackordered");
            }
        }

        /// <summary>
        ///     Type the amount or quantity of the product that was canceled.
        /// </summary>
        [AttributeLogicalName("quantitycancelled")]
        public decimal? QuantityCancelled
        {
            get { return GetAttributeValue<decimal?>("quantitycancelled"); }
            set
            {
                OnPropertyChanging("QuantityCancelled");
                SetAttributeValue("quantitycancelled", value);
                OnPropertyChanged("QuantityCancelled");
            }
        }

        /// <summary>
        ///     Type the amount or quantity of the product that was shipped for the order.
        /// </summary>
        [AttributeLogicalName("quantityshipped")]
        public decimal? QuantityShipped
        {
            get { return GetAttributeValue<decimal?>("quantityshipped"); }
            set
            {
                OnPropertyChanging("QuantityShipped");
                SetAttributeValue("quantityshipped", value);
                OnPropertyChanged("QuantityShipped");
            }
        }

        /// <summary>
        ///     Enter the delivery date requested by the customer for the order product.
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
        ///     Unique identifier of the product specified in the order.
        /// </summary>
        [AttributeLogicalName("salesorderdetailid")]
        public Guid? SalesOrderDetailId
        {
            get { return GetAttributeValue<Guid?>("salesorderdetailid"); }
            set
            {
                OnPropertyChanging("SalesOrderDetailId");
                SetAttributeValue("salesorderdetailid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("SalesOrderDetailId");
            }
        }

        [AttributeLogicalName("salesorderdetailid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { SalesOrderDetailId = value; }
        }

        /// <summary>
        ///     Shows the order for the product. The ID is used to link product pricing and other details to the total amounts and
        ///     other information on the order.
        /// </summary>
        [AttributeLogicalName("salesorderid")]
        public EntityReference SalesOrderId
        {
            get { return GetAttributeValue<EntityReference>("salesorderid"); }
            set
            {
                OnPropertyChanging("SalesOrderId");
                SetAttributeValue("salesorderid", value);
                OnPropertyChanged("SalesOrderId");
            }
        }

        /// <summary>
        ///     Tells whether product pricing is locked for the order.
        /// </summary>
        [AttributeLogicalName("salesorderispricelocked")]
        public bool? SalesOrderIsPriceLocked
        {
            get { return GetAttributeValue<bool?>("salesorderispricelocked"); }
        }

        /// <summary>
        ///     Shows the status of the order that the order detail is associated with.
        /// </summary>
        [AttributeLogicalName("salesorderstatecode")]
        public OptionSetValue SalesOrderStateCode
        {
            get { return GetAttributeValue<OptionSetValue>("salesorderstatecode"); }
        }

        /// <summary>
        ///     Choose the user responsible for the sale of the order product.
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
        ///     Shows the ID of the data that maintains the sequence.
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
        ///     Type the tax amount for the order product.
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
        ///     Version number of the sales order detail.
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
        ///     Shows the Volume Discount field converted to the system's default base currency for reporting purposes. The
        ///     calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("volumediscountamount_base")]
        public Money VolumeDiscountAmount_Base
        {
            get { return GetAttributeValue<Money>("volumediscountamount_base"); }
        }

        /// <summary>
        ///     Select whether the order product should be shipped to the specified address or held until the customer calls with
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
        ///     1:N SalesOrderDetail_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("SalesOrderDetail_AsyncOperations")]
        public IEnumerable<AsyncOperation> SalesOrderDetail_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("SalesOrderDetail_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("SalesOrderDetail_AsyncOperations");
                SetRelatedEntities("SalesOrderDetail_AsyncOperations", null, value);
                OnPropertyChanged("SalesOrderDetail_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N SalesOrderDetail_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("SalesOrderDetail_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> SalesOrderDetail_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("SalesOrderDetail_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("SalesOrderDetail_BulkDeleteFailures");
                SetRelatedEntities("SalesOrderDetail_BulkDeleteFailures", null, value);
                OnPropertyChanged("SalesOrderDetail_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N salesorderdetail_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("salesorderdetail_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> salesorderdetail_principalobjectattributeaccess
        {
            get
            {
                return
                    GetRelatedEntities<PrincipalObjectAttributeAccess>(
                        "salesorderdetail_principalobjectattributeaccess", null);
            }
            set
            {
                OnPropertyChanging("salesorderdetail_principalobjectattributeaccess");
                SetRelatedEntities("salesorderdetail_principalobjectattributeaccess", null, value);
                OnPropertyChanged("salesorderdetail_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N SalesOrderDetail_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("SalesOrderDetail_ProcessSessions")]
        public IEnumerable<ProcessSession> SalesOrderDetail_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("SalesOrderDetail_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("SalesOrderDetail_ProcessSessions");
                SetRelatedEntities("SalesOrderDetail_ProcessSessions", null, value);
                OnPropertyChanged("SalesOrderDetail_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_salesorderdetail
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_salesorderdetail")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_salesorderdetail
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_salesorderdetail", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_salesorderdetail");
                SetRelatedEntities("userentityinstancedata_salesorderdetail", null, value);
                OnPropertyChanged("userentityinstancedata_salesorderdetail");
            }
        }

        /// <summary>
        ///     N:1 lk_salesorderdetail_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_salesorderdetail_createdonbehalfby")]
        public SystemUser lk_salesorderdetail_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_salesorderdetail_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_salesorderdetail_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_salesorderdetail_modifiedonbehalfby")]
        public SystemUser lk_salesorderdetail_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_salesorderdetail_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_salesorderdetailbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_salesorderdetailbase_createdby")]
        public SystemUser lk_salesorderdetailbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_salesorderdetailbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_salesorderdetailbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_salesorderdetailbase_modifiedby")]
        public SystemUser lk_salesorderdetailbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_salesorderdetailbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 order_details
        /// </summary>
        [AttributeLogicalName("salesorderid")]
        [RelationshipSchemaName("order_details")]
        public SalesOrder order_details
        {
            get { return GetRelatedEntity<SalesOrder>("order_details", null); }
            set
            {
                OnPropertyChanging("order_details");
                SetRelatedEntity("order_details", null, value);
                OnPropertyChanged("order_details");
            }
        }

        /// <summary>
        ///     N:1 product_order_details
        /// </summary>
        [AttributeLogicalName("productid")]
        [RelationshipSchemaName("product_order_details")]
        public Product product_order_details
        {
            get { return GetRelatedEntity<Product>("product_order_details", null); }
            set
            {
                OnPropertyChanging("product_order_details");
                SetRelatedEntity("product_order_details", null, value);
                OnPropertyChanged("product_order_details");
            }
        }

        /// <summary>
        ///     N:1 system_user_salesorderdetail
        /// </summary>
        [AttributeLogicalName("salesrepid")]
        [RelationshipSchemaName("system_user_salesorderdetail")]
        public SystemUser system_user_salesorderdetail
        {
            get { return GetRelatedEntity<SystemUser>("system_user_salesorderdetail", null); }
            set
            {
                OnPropertyChanging("system_user_salesorderdetail");
                SetRelatedEntity("system_user_salesorderdetail", null, value);
                OnPropertyChanged("system_user_salesorderdetail");
            }
        }

        /// <summary>
        ///     N:1 transactioncurrency_salesorderdetail
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("transactioncurrency_salesorderdetail")]
        public TransactionCurrency transactioncurrency_salesorderdetail
        {
            get { return GetRelatedEntity<TransactionCurrency>("transactioncurrency_salesorderdetail", null); }
        }

        /// <summary>
        ///     N:1 unit_of_measurement_order_details
        /// </summary>
        [AttributeLogicalName("uomid")]
        [RelationshipSchemaName("unit_of_measurement_order_details")]
        public UoM unit_of_measurement_order_details
        {
            get { return GetRelatedEntity<UoM>("unit_of_measurement_order_details", null); }
            set
            {
                OnPropertyChanging("unit_of_measurement_order_details");
                SetRelatedEntity("unit_of_measurement_order_details", null, value);
                OnPropertyChanged("unit_of_measurement_order_details");
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