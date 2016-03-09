using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Xrm.Framework.CI.Common.Entities;
using AsyncOperation = Xrm.Framework.CI.Common.Entities.AsyncOperation;

namespace Xrm.Framework.CI.PowerShell.Common
{
    /// <summary>
    ///     Line item in an invoice containing detailed billing information for a product.
    /// </summary>
    [DataContract]
    [EntityLogicalName("invoicedetail")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class InvoiceDetail : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "invoicedetail";

        public const int EntityTypeCode = 1091;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public InvoiceDetail() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Enter the date when the invoiced product was delivered to the customer.
        /// </summary>
        [AttributeLogicalName("actualdeliveryon")]
        public DateTime? ActualDeliveryOn
        {
            get { return GetAttributeValue<DateTime?>("actualdeliveryon"); }
            set
            {
                OnPropertyChanging("ActualDeliveryOn");
                SetAttributeValue("actualdeliveryon", value);
                OnPropertyChanged("ActualDeliveryOn");
            }
        }

        /// <summary>
        ///     Shows the total price of the invoice product, based on the price per unit, volume discount, and quantity.
        /// </summary>
        [AttributeLogicalName("baseamount")]
        public Money BaseAmount => GetAttributeValue<Money>("baseamount");

        /// <summary>
        ///     Shows the Amount field converted to the system's default base currency. The calculation uses the exchange rate
        ///     specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("baseamount_base")]
        public Money BaseAmountBase => GetAttributeValue<Money>("baseamount_base");

        /// <summary>
        ///     Shows who created the record.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy => GetAttributeValue<EntityReference>("createdby");

        /// <summary>
        ///     Shows the date and time when the record was created. The date and time are displayed in the time zone selected in
        ///     Microsoft Dynamics CRM options.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn => GetAttributeValue<DateTime?>("createdon");

        /// <summary>
        ///     Shows who created the record on behalf of another user.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy => GetAttributeValue<EntityReference>("createdonbehalfby");

        /// <summary>
        ///     Type additional information to describe the product line item of the invoice.
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
        public decimal? ExchangeRate => GetAttributeValue<decimal?>("exchangerate");

        /// <summary>
        ///     Shows the total amount due for the invoice product, based on the sum of the unit price, quantity, discounts, and
        ///     tax.
        /// </summary>
        [AttributeLogicalName("extendedamount")]
        public Money ExtendedAmount => GetAttributeValue<Money>("extendedamount");

        /// <summary>
        ///     Shows the Extended Amount field converted to the system's default base currency. The calculation uses the exchange
        ///     rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("extendedamount_base")]
        public Money ExtendedAmountBase => GetAttributeValue<Money>("extendedamount_base");

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
        ///     Unique identifier of the invoice product line item.
        /// </summary>
        [AttributeLogicalName("invoicedetailid")]
        public Guid? InvoiceDetailId
        {
            get { return GetAttributeValue<Guid?>("invoicedetailid"); }
            set
            {
                OnPropertyChanging("InvoiceDetailId");
                SetAttributeValue("invoicedetailid", value);
                base.Id = value ?? Guid.Empty;
                OnPropertyChanged("InvoiceDetailId");
            }
        }

        [AttributeLogicalName("invoicedetailid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { InvoiceDetailId = value; }
        }

        /// <summary>
        ///     Unique identifier of the invoice associated with the invoice product line item.
        /// </summary>
        [AttributeLogicalName("invoiceid")]
        public EntityReference InvoiceId
        {
            get { return GetAttributeValue<EntityReference>("invoiceid"); }
            set
            {
                OnPropertyChanging("InvoiceId");
                SetAttributeValue("invoiceid", value);
                OnPropertyChanged("InvoiceId");
            }
        }

        /// <summary>
        ///     Information about whether invoice product pricing is locked.
        /// </summary>
        [AttributeLogicalName("invoiceispricelocked")]
        public bool? InvoiceIsPriceLocked => GetAttributeValue<bool?>("invoiceispricelocked");

        /// <summary>
        ///     Status of the invoice product.
        /// </summary>
        [AttributeLogicalName("invoicestatecode")]
        public OptionSetValue InvoiceStateCode => GetAttributeValue<OptionSetValue>("invoicestatecode");

        /// <summary>
        ///     Select whether the invoice product is copied from another item or data source.
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
        ///     who have edit rights to the invoice product.
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
        ///     to the parent invoice.
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
        ///     Type the line item number for the invoice product to easily identify the product in the invoice and make sure it's
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
        ///     Type the manual discount amount for the invoice product to deduct any negotiated or other savings from the product
        ///     total.
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
        public Money ManualDiscountAmountBase
        {
            get { return GetAttributeValue<Money>("manualdiscountamount_base"); }
        }

        /// <summary>
        ///     Shows who last updated the record.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy => GetAttributeValue<EntityReference>("modifiedby");

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
        ///     Unique identifier of the user or team who owns the invoice detail.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId
        {
            get { return GetAttributeValue<EntityReference>("ownerid"); }
        }

        /// <summary>
        ///     Unique identifier of the business unit that owns the invoice product line item.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public Guid? OwningBusinessUnit
        {
            get { return GetAttributeValue<Guid?>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the invoice product line item.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public Guid? OwningUser
        {
            get { return GetAttributeValue<Guid?>("owninguser"); }
        }

        /// <summary>
        ///     Type the price per unit of the invoice product. The default is the value in the price list specified on the parent
        ///     invoice for existing products.
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
        ///     Pricing error for the invoice product line item.
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
        ///     Type a name or description to identify the type of write-in product included in the invoice.
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
        ///     Choose the product to include on the invoice.
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
        ///     Type the amount or quantity of the product included in the invoice's total amount due.
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
        ///     Type the amount or quantity of the product that is back ordered for the invoice.
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
        ///     Type the amount or quantity of the product that was canceled for the invoice line item.
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
        ///     Type the amount or quantity of the product that was shipped.
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
        ///     Choose the user responsible for the sale of the invoice product.
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
        ///     Type a tracking number for shipment of the invoiced product.
        /// </summary>
        [AttributeLogicalName("shippingtrackingnumber")]
        public string ShippingTrackingNumber
        {
            get { return GetAttributeValue<string>("shippingtrackingnumber"); }
            set
            {
                OnPropertyChanging("ShippingTrackingNumber");
                SetAttributeValue("shippingtrackingnumber", value);
                OnPropertyChanged("ShippingTrackingNumber");
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
        ///     Type the tax amount for the invoice product.
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
        ///     Version number of the invoice product line item.
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
        ///     Select whether the invoice product should be shipped to the specified address or held until the customer calls with
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
        ///     1:N InvoiceDetail_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("InvoiceDetail_AsyncOperations")]
        public IEnumerable<AsyncOperation> InvoiceDetail_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("InvoiceDetail_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("InvoiceDetail_AsyncOperations");
                SetRelatedEntities("InvoiceDetail_AsyncOperations", null, value);
                OnPropertyChanged("InvoiceDetail_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N InvoiceDetail_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("InvoiceDetail_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> InvoiceDetail_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("InvoiceDetail_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("InvoiceDetail_BulkDeleteFailures");
                SetRelatedEntities("InvoiceDetail_BulkDeleteFailures", null, value);
                OnPropertyChanged("InvoiceDetail_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N invoicedetail_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("invoicedetail_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> invoicedetail_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntities<PrincipalObjectAttributeAccess>(
                    "invoicedetail_principalobjectattributeaccess", null);
            }
            set
            {
                OnPropertyChanging("invoicedetail_principalobjectattributeaccess");
                SetRelatedEntities("invoicedetail_principalobjectattributeaccess", null, value);
                OnPropertyChanged("invoicedetail_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N InvoiceDetail_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("InvoiceDetail_ProcessSessions")]
        public IEnumerable<ProcessSession> InvoiceDetail_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("InvoiceDetail_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("InvoiceDetail_ProcessSessions");
                SetRelatedEntities("InvoiceDetail_ProcessSessions", null, value);
                OnPropertyChanged("InvoiceDetail_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_invoicedetail
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_invoicedetail")]
        public IEnumerable<UserEntityInstanceData> UserentityinstancedataInvoicedetail
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_invoicedetail", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_invoicedetail");
                SetRelatedEntities("userentityinstancedata_invoicedetail", null, value);
                OnPropertyChanged("userentityinstancedata_invoicedetail");
            }
        }

        /// <summary>
        ///     N:1 invoice_details
        /// </summary>
        [AttributeLogicalName("invoiceid")]
        [RelationshipSchemaName("invoice_details")]
        public Invoice InvoiceDetails
        {
            get { return GetRelatedEntity<Invoice>("invoice_details", null); }
            set
            {
                OnPropertyChanging("invoice_details");
                SetRelatedEntity("invoice_details", null, value);
                OnPropertyChanged("invoice_details");
            }
        }

        /// <summary>
        ///     N:1 lk_invoicedetail_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_invoicedetail_createdonbehalfby")]
        public SystemUser lk_invoicedetail_createdonbehalfby
            => GetRelatedEntity<SystemUser>("lk_invoicedetail_createdonbehalfby", null);

        /// <summary>
        ///     N:1 lk_invoicedetail_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_invoicedetail_modifiedonbehalfby")]
        public SystemUser lk_invoicedetail_modifiedonbehalfby
            => GetRelatedEntity<SystemUser>("lk_invoicedetail_modifiedonbehalfby", null);

        /// <summary>
        ///     N:1 lk_invoicedetailbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_invoicedetailbase_createdby")]
        public SystemUser lk_invoicedetailbase_createdby
            => GetRelatedEntity<SystemUser>("lk_invoicedetailbase_createdby", null);

        /// <summary>
        ///     N:1 lk_invoicedetailbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_invoicedetailbase_modifiedby")]
        public SystemUser lk_invoicedetailbase_modifiedby
            => GetRelatedEntity<SystemUser>("lk_invoicedetailbase_modifiedby", null);

        /// <summary>
        ///     N:1 product_invoice_details
        /// </summary>
        [AttributeLogicalName("productid")]
        [RelationshipSchemaName("product_invoice_details")]
        public Product ProductInvoiceDetails
        {
            get { return GetRelatedEntity<Product>("product_invoice_details", null); }
            set
            {
                OnPropertyChanging("product_invoice_details");
                SetRelatedEntity("product_invoice_details", null, value);
                OnPropertyChanged("product_invoice_details");
            }
        }

        /// <summary>
        ///     N:1 system_user_invoicedetail
        /// </summary>
        [AttributeLogicalName("salesrepid")]
        [RelationshipSchemaName("system_user_invoicedetail")]
        public SystemUser SystemUserInvoicedetail
        {
            get { return GetRelatedEntity<SystemUser>("system_user_invoicedetail", null); }
            set
            {
                OnPropertyChanging("system_user_invoicedetail");
                SetRelatedEntity("system_user_invoicedetail", null, value);
                OnPropertyChanged("system_user_invoicedetail");
            }
        }

        /// <summary>
        ///     N:1 transactioncurrency_invoicedetail
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("transactioncurrency_invoicedetail")]
        public TransactionCurrency transactioncurrency_invoicedetail
            => GetRelatedEntity<TransactionCurrency>("transactioncurrency_invoicedetail", null);

        /// <summary>
        ///     N:1 unit_of_measurement_invoice_details
        /// </summary>
        [AttributeLogicalName("uomid")]
        [RelationshipSchemaName("unit_of_measurement_invoice_details")]
        public UoM UnitOfMeasurementInvoiceDetails
        {
            get { return GetRelatedEntity<UoM>("unit_of_measurement_invoice_details", null); }
            set
            {
                OnPropertyChanging("unit_of_measurement_invoice_details");
                SetRelatedEntity("unit_of_measurement_invoice_details", null, value);
                OnPropertyChanged("unit_of_measurement_invoice_details");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public event PropertyChangingEventHandler PropertyChanging;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void OnPropertyChanging(string propertyName)
        {
            PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));
        }
    }
}