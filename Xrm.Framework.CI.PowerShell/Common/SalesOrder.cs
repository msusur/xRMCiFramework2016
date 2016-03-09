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
    ///     Quote that has been accepted.
    /// </summary>
    [DataContract]
    [EntityLogicalName("salesorder")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class SalesOrder : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "salesorder";

        public const int EntityTypeCode = 1088;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public SalesOrder() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Shows the parent account related to the record. This information is used to link the sales order to the account
        ///     selected in the Customer field for reporting and analytics.
        /// </summary>
        [AttributeLogicalName("accountid")]
        public EntityReference AccountId
        {
            get { return GetAttributeValue<EntityReference>("accountid"); }
        }

        /// <summary>
        ///     Unique identifier of the billing address.
        /// </summary>
        [AttributeLogicalName("billto_addressid")]
        public Guid? BillTo_AddressId
        {
            get { return GetAttributeValue<Guid?>("billto_addressid"); }
            set
            {
                OnPropertyChanging("BillTo_AddressId");
                SetAttributeValue("billto_addressid", value);
                OnPropertyChanged("BillTo_AddressId");
            }
        }

        /// <summary>
        ///     Type the city for the customer's billing address.
        /// </summary>
        [AttributeLogicalName("billto_city")]
        public string BillTo_City
        {
            get { return GetAttributeValue<string>("billto_city"); }
            set
            {
                OnPropertyChanging("BillTo_City");
                SetAttributeValue("billto_city", value);
                OnPropertyChanged("BillTo_City");
            }
        }

        /// <summary>
        ///     Shows the complete Bill To address.
        /// </summary>
        [AttributeLogicalName("billto_composite")]
        public string BillTo_Composite
        {
            get { return GetAttributeValue<string>("billto_composite"); }
        }

        /// <summary>
        ///     Type the primary contact name at the customer's billing address.
        /// </summary>
        [AttributeLogicalName("billto_contactname")]
        public string BillTo_ContactName
        {
            get { return GetAttributeValue<string>("billto_contactname"); }
            set
            {
                OnPropertyChanging("BillTo_ContactName");
                SetAttributeValue("billto_contactname", value);
                OnPropertyChanged("BillTo_ContactName");
            }
        }

        /// <summary>
        ///     Type the country or region for the customer's billing address.
        /// </summary>
        [AttributeLogicalName("billto_country")]
        public string BillTo_Country
        {
            get { return GetAttributeValue<string>("billto_country"); }
            set
            {
                OnPropertyChanging("BillTo_Country");
                SetAttributeValue("billto_country", value);
                OnPropertyChanged("BillTo_Country");
            }
        }

        /// <summary>
        ///     Type the fax number for the customer's billing address.
        /// </summary>
        [AttributeLogicalName("billto_fax")]
        public string BillTo_Fax
        {
            get { return GetAttributeValue<string>("billto_fax"); }
            set
            {
                OnPropertyChanging("BillTo_Fax");
                SetAttributeValue("billto_fax", value);
                OnPropertyChanged("BillTo_Fax");
            }
        }

        /// <summary>
        ///     Type the first line of the customer's billing address.
        /// </summary>
        [AttributeLogicalName("billto_line1")]
        public string BillTo_Line1
        {
            get { return GetAttributeValue<string>("billto_line1"); }
            set
            {
                OnPropertyChanging("BillTo_Line1");
                SetAttributeValue("billto_line1", value);
                OnPropertyChanged("BillTo_Line1");
            }
        }

        /// <summary>
        ///     Type the second line of the customer's billing address.
        /// </summary>
        [AttributeLogicalName("billto_line2")]
        public string BillTo_Line2
        {
            get { return GetAttributeValue<string>("billto_line2"); }
            set
            {
                OnPropertyChanging("BillTo_Line2");
                SetAttributeValue("billto_line2", value);
                OnPropertyChanged("BillTo_Line2");
            }
        }

        /// <summary>
        ///     Type the third line of the billing address.
        /// </summary>
        [AttributeLogicalName("billto_line3")]
        public string BillTo_Line3
        {
            get { return GetAttributeValue<string>("billto_line3"); }
            set
            {
                OnPropertyChanging("BillTo_Line3");
                SetAttributeValue("billto_line3", value);
                OnPropertyChanged("BillTo_Line3");
            }
        }

        /// <summary>
        ///     Type a name for the customer's billing address, such as "Headquarters" or "Field office", to identify the address.
        /// </summary>
        [AttributeLogicalName("billto_name")]
        public string BillTo_Name
        {
            get { return GetAttributeValue<string>("billto_name"); }
            set
            {
                OnPropertyChanging("BillTo_Name");
                SetAttributeValue("billto_name", value);
                OnPropertyChanged("BillTo_Name");
            }
        }

        /// <summary>
        ///     Type the ZIP Code or postal code for the billing address.
        /// </summary>
        [AttributeLogicalName("billto_postalcode")]
        public string BillTo_PostalCode
        {
            get { return GetAttributeValue<string>("billto_postalcode"); }
            set
            {
                OnPropertyChanging("BillTo_PostalCode");
                SetAttributeValue("billto_postalcode", value);
                OnPropertyChanged("BillTo_PostalCode");
            }
        }

        /// <summary>
        ///     Type the state or province for the billing address.
        /// </summary>
        [AttributeLogicalName("billto_stateorprovince")]
        public string BillTo_StateOrProvince
        {
            get { return GetAttributeValue<string>("billto_stateorprovince"); }
            set
            {
                OnPropertyChanging("BillTo_StateOrProvince");
                SetAttributeValue("billto_stateorprovince", value);
                OnPropertyChanged("BillTo_StateOrProvince");
            }
        }

        /// <summary>
        ///     Type the phone number for the customer's billing address.
        /// </summary>
        [AttributeLogicalName("billto_telephone")]
        public string BillTo_Telephone
        {
            get { return GetAttributeValue<string>("billto_telephone"); }
            set
            {
                OnPropertyChanging("BillTo_Telephone");
                SetAttributeValue("billto_telephone", value);
                OnPropertyChanged("BillTo_Telephone");
            }
        }

        /// <summary>
        ///     Shows the campaign that the order was created from.
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
        ///     Shows the parent contact related to the record. This information is used to link the contract to the contact
        ///     selected in the Customer field for reporting and analytics.
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
        ///     Select the customer account or contact to provide a quick link to additional customer details, such as account
        ///     information, activities, and opportunities.
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
        ///     Enter the date that all or part of the order was shipped to the customer.
        /// </summary>
        [AttributeLogicalName("datefulfilled")]
        public DateTime? DateFulfilled
        {
            get { return GetAttributeValue<DateTime?>("datefulfilled"); }
            set
            {
                OnPropertyChanging("DateFulfilled");
                SetAttributeValue("datefulfilled", value);
                OnPropertyChanged("DateFulfilled");
            }
        }

        /// <summary>
        ///     Type additional information to describe the order, such as the products or services offered or details about the
        ///     customer's product preferences.
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
        ///     Type the discount amount for the order if the customer is eligible for special savings.
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
        ///     Shows the Order Discount field converted to the system's default base currency for reporting purposes. The
        ///     calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("discountamount_base")]
        public Money DiscountAmount_Base
        {
            get { return GetAttributeValue<Money>("discountamount_base"); }
        }

        /// <summary>
        ///     Type the discount rate that should be applied to the Detail Amount field to include additional savings for the
        ///     customer in the order.
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
        ///     Type the cost of freight or shipping for the products included in the order for use in calculating the Total Amount
        ///     field.
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
        ///     Select the freight terms to make sure shipping charges are processed correctly.
        /// </summary>
        [AttributeLogicalName("freighttermscode")]
        public OptionSetValue FreightTermsCode
        {
            get { return GetAttributeValue<OptionSetValue>("freighttermscode"); }
            set
            {
                OnPropertyChanging("FreightTermsCode");
                SetAttributeValue("freighttermscode", value);
                OnPropertyChanged("FreightTermsCode");
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
        ///     Select whether prices specified on the invoice are locked from any further updates.
        /// </summary>
        [AttributeLogicalName("ispricelocked")]
        public bool? IsPriceLocked
        {
            get { return GetAttributeValue<bool?>("ispricelocked"); }
        }

        /// <summary>
        ///     Enter the date and time when the order was last submitted to an accounting or ERP system for processing.
        /// </summary>
        [AttributeLogicalName("lastbackofficesubmit")]
        public DateTime? LastBackofficeSubmit
        {
            get { return GetAttributeValue<DateTime?>("lastbackofficesubmit"); }
            set
            {
                OnPropertyChanging("LastBackofficeSubmit");
                SetAttributeValue("lastbackofficesubmit", value);
                OnPropertyChanged("LastBackofficeSubmit");
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
        ///     Type a descriptive name for the order.
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
        ///     Choose the related opportunity so that the data for the order and opportunity are linked for reporting and
        ///     analytics.
        /// </summary>
        [AttributeLogicalName("opportunityid")]
        public EntityReference OpportunityId
        {
            get { return GetAttributeValue<EntityReference>("opportunityid"); }
            set
            {
                OnPropertyChanging("OpportunityId");
                SetAttributeValue("opportunityid", value);
                OnPropertyChanged("OpportunityId");
            }
        }

        /// <summary>
        ///     Shows the order number for customer reference and to use in search. The number cannot be modified.
        /// </summary>
        [AttributeLogicalName("ordernumber")]
        public string OrderNumber
        {
            get { return GetAttributeValue<string>("ordernumber"); }
            set
            {
                OnPropertyChanging("OrderNumber");
                SetAttributeValue("ordernumber", value);
                OnPropertyChanged("OrderNumber");
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
        ///     Shows the business unit that the record owner belongs to.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the order.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the order.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Select the payment terms to indicate when the customer needs to pay the total amount.
        /// </summary>
        [AttributeLogicalName("paymenttermscode")]
        public OptionSetValue PaymentTermsCode
        {
            get { return GetAttributeValue<OptionSetValue>("paymenttermscode"); }
            set
            {
                OnPropertyChanging("PaymentTermsCode");
                SetAttributeValue("paymenttermscode", value);
                OnPropertyChanged("PaymentTermsCode");
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
        ///     Choose the related quote so that order data and quote data are linked for reporting and analytics.
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
        ///     Enter the delivery date requested by the customer for all products in the order.
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
        ///     Unique identifier of the order.
        /// </summary>
        [AttributeLogicalName("salesorderid")]
        public Guid? SalesOrderId
        {
            get { return GetAttributeValue<Guid?>("salesorderid"); }
            set
            {
                OnPropertyChanging("SalesOrderId");
                SetAttributeValue("salesorderid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("SalesOrderId");
            }
        }

        [AttributeLogicalName("salesorderid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { SalesOrderId = value; }
        }

        /// <summary>
        ///     Select a shipping method for deliveries sent to this address.
        /// </summary>
        [AttributeLogicalName("shippingmethodcode")]
        public OptionSetValue ShippingMethodCode
        {
            get { return GetAttributeValue<OptionSetValue>("shippingmethodcode"); }
            set
            {
                OnPropertyChanging("ShippingMethodCode");
                SetAttributeValue("shippingmethodcode", value);
                OnPropertyChanged("ShippingMethodCode");
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
        ///     Shows the complete Ship To address.
        /// </summary>
        [AttributeLogicalName("shipto_composite")]
        public string ShipTo_Composite
        {
            get { return GetAttributeValue<string>("shipto_composite"); }
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
        ///     Shows whether the order is active, submitted, fulfilled, canceled, or invoiced. Only active orders can be edited.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public SalesOrderState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((SalesOrderState) (Enum.ToObject(typeof (SalesOrderState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Select the order's status.
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
        ///     Enter the date when the order was submitted to the fulfillment or shipping center.
        /// </summary>
        [AttributeLogicalName("submitdate")]
        public DateTime? SubmitDate
        {
            get { return GetAttributeValue<DateTime?>("submitdate"); }
            set
            {
                OnPropertyChanging("SubmitDate");
                SetAttributeValue("submitdate", value);
                OnPropertyChanged("SubmitDate");
            }
        }

        /// <summary>
        ///     Type the code for the submitted status in the fulfillment or shipping center system.
        /// </summary>
        [AttributeLogicalName("submitstatus")]
        public int? SubmitStatus
        {
            get { return GetAttributeValue<int?>("submitstatus"); }
            set
            {
                OnPropertyChanging("SubmitStatus");
                SetAttributeValue("submitstatus", value);
                OnPropertyChanged("SubmitStatus");
            }
        }

        /// <summary>
        ///     Type additional details or notes about the order for the fulfillment or shipping center.
        /// </summary>
        [AttributeLogicalName("submitstatusdescription")]
        public string SubmitStatusDescription
        {
            get { return GetAttributeValue<string>("submitstatusdescription"); }
            set
            {
                OnPropertyChanging("SubmitStatusDescription");
                SetAttributeValue("submitstatusdescription", value);
                OnPropertyChanged("SubmitStatusDescription");
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
        ///     Shows the total amount due, calculated as the sum of the products, discounts, freight, and taxes for the order.
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
        ///     Shows the total product amount for the order, minus any discounts. This value is added to freight and tax amounts
        ///     in the calculation for the total amount due for the order.
        /// </summary>
        [AttributeLogicalName("totalamountlessfreight")]
        public Money TotalAmountLessFreight
        {
            get { return GetAttributeValue<Money>("totalamountlessfreight"); }
        }

        /// <summary>
        ///     Shows the Pre-Freight Amount field converted to the system's default base currency for reporting purposes. The
        ///     calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("totalamountlessfreight_base")]
        public Money TotalAmountLessFreight_Base
        {
            get { return GetAttributeValue<Money>("totalamountlessfreight_base"); }
        }

        /// <summary>
        ///     Shows the total discount amount, based on the discount price and rate entered on the order.
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
        ///     Shows the sum of all existing and write-in products included on the order, based on the specified price list and
        ///     quantities.
        /// </summary>
        [AttributeLogicalName("totallineitemamount")]
        public Money TotalLineItemAmount
        {
            get { return GetAttributeValue<Money>("totallineitemamount"); }
        }

        /// <summary>
        ///     Shows the Detail Amount field converted to the system's default base currency. The calculation uses the exchange
        ///     rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("totallineitemamount_base")]
        public Money TotalLineItemAmount_Base
        {
            get { return GetAttributeValue<Money>("totallineitemamount_base"); }
        }

        /// <summary>
        ///     Shows the total of the Manual Discount amounts specified on all products included in the order. This value is
        ///     reflected in the Detail Amount field on the order and is added to any discount amount or rate specified on the
        ///     order.
        /// </summary>
        [AttributeLogicalName("totallineitemdiscountamount")]
        public Money TotalLineItemDiscountAmount
        {
            get { return GetAttributeValue<Money>("totallineitemdiscountamount"); }
        }

        /// <summary>
        ///     Shows the Total Line Item Discount Amount field converted to the system's default base currency for reporting
        ///     purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("totallineitemdiscountamount_base")]
        public Money TotalLineItemDiscountAmount_Base
        {
            get { return GetAttributeValue<Money>("totallineitemdiscountamount_base"); }
        }

        /// <summary>
        ///     Shows the Tax amounts specified on all products included in the order, included in the Total Amount due calculation
        ///     for the order.
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
        ///     Version number of the order.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     Select whether the products included in the order should be shipped to the specified address or held until the
        ///     customer calls with further pick-up or delivery instructions.
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
        ///     1:N order_details
        /// </summary>
        [RelationshipSchemaName("order_details")]
        public IEnumerable<SalesOrderDetail> order_details
        {
            get { return GetRelatedEntities<SalesOrderDetail>("order_details", null); }
            set
            {
                OnPropertyChanging("order_details");
                SetRelatedEntities("order_details", null, value);
                OnPropertyChanged("order_details");
            }
        }

        /// <summary>
        ///     1:N order_invoices
        /// </summary>
        [RelationshipSchemaName("order_invoices")]
        public IEnumerable<Invoice> order_invoices
        {
            get { return GetRelatedEntities<Invoice>("order_invoices", null); }
            set
            {
                OnPropertyChanging("order_invoices");
                SetRelatedEntities("order_invoices", null, value);
                OnPropertyChanged("order_invoices");
            }
        }

        /// <summary>
        ///     1:N salesorder_activity_parties
        /// </summary>
        [RelationshipSchemaName("salesorder_activity_parties")]
        public IEnumerable<ActivityParty> salesorder_activity_parties
        {
            get { return GetRelatedEntities<ActivityParty>("salesorder_activity_parties", null); }
            set
            {
                OnPropertyChanging("salesorder_activity_parties");
                SetRelatedEntities("salesorder_activity_parties", null, value);
                OnPropertyChanged("salesorder_activity_parties");
            }
        }

        /// <summary>
        ///     1:N SalesOrder_ActivityPointers
        /// </summary>
        [RelationshipSchemaName("SalesOrder_ActivityPointers")]
        public IEnumerable<ActivityPointer> SalesOrder_ActivityPointers
        {
            get { return GetRelatedEntities<ActivityPointer>("SalesOrder_ActivityPointers", null); }
            set
            {
                OnPropertyChanging("SalesOrder_ActivityPointers");
                SetRelatedEntities("SalesOrder_ActivityPointers", null, value);
                OnPropertyChanged("SalesOrder_ActivityPointers");
            }
        }

        /// <summary>
        ///     1:N SalesOrder_Annotation
        /// </summary>
        [RelationshipSchemaName("SalesOrder_Annotation")]
        public IEnumerable<Annotation> SalesOrder_Annotation
        {
            get { return GetRelatedEntities<Annotation>("SalesOrder_Annotation", null); }
            set
            {
                OnPropertyChanging("SalesOrder_Annotation");
                SetRelatedEntities("SalesOrder_Annotation", null, value);
                OnPropertyChanged("SalesOrder_Annotation");
            }
        }

        /// <summary>
        ///     1:N SalesOrder_Appointments
        /// </summary>
        [RelationshipSchemaName("SalesOrder_Appointments")]
        public IEnumerable<Appointment> SalesOrder_Appointments
        {
            get { return GetRelatedEntities<Appointment>("SalesOrder_Appointments", null); }
            set
            {
                OnPropertyChanging("SalesOrder_Appointments");
                SetRelatedEntities("SalesOrder_Appointments", null, value);
                OnPropertyChanged("SalesOrder_Appointments");
            }
        }

        /// <summary>
        ///     1:N SalesOrder_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("SalesOrder_AsyncOperations")]
        public IEnumerable<AsyncOperation> SalesOrder_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("SalesOrder_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("SalesOrder_AsyncOperations");
                SetRelatedEntities("SalesOrder_AsyncOperations", null, value);
                OnPropertyChanged("SalesOrder_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N SalesOrder_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("SalesOrder_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> SalesOrder_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("SalesOrder_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("SalesOrder_BulkDeleteFailures");
                SetRelatedEntities("SalesOrder_BulkDeleteFailures", null, value);
                OnPropertyChanged("SalesOrder_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N salesorder_connections1
        /// </summary>
        [RelationshipSchemaName("salesorder_connections1")]
        public IEnumerable<Connection> salesorder_connections1
        {
            get { return GetRelatedEntities<Connection>("salesorder_connections1", null); }
            set
            {
                OnPropertyChanging("salesorder_connections1");
                SetRelatedEntities("salesorder_connections1", null, value);
                OnPropertyChanged("salesorder_connections1");
            }
        }

        /// <summary>
        ///     1:N salesorder_connections2
        /// </summary>
        [RelationshipSchemaName("salesorder_connections2")]
        public IEnumerable<Connection> salesorder_connections2
        {
            get { return GetRelatedEntities<Connection>("salesorder_connections2", null); }
            set
            {
                OnPropertyChanging("salesorder_connections2");
                SetRelatedEntities("salesorder_connections2", null, value);
                OnPropertyChanged("salesorder_connections2");
            }
        }

        /// <summary>
        ///     1:N SalesOrder_Emails
        /// </summary>
        [RelationshipSchemaName("SalesOrder_Emails")]
        public IEnumerable<Email> SalesOrder_Emails
        {
            get { return GetRelatedEntities<Email>("SalesOrder_Emails", null); }
            set
            {
                OnPropertyChanging("SalesOrder_Emails");
                SetRelatedEntities("SalesOrder_Emails", null, value);
                OnPropertyChanged("SalesOrder_Emails");
            }
        }

        /// <summary>
        ///     1:N SalesOrder_Faxes
        /// </summary>
        [RelationshipSchemaName("SalesOrder_Faxes")]
        public IEnumerable<Fax> SalesOrder_Faxes
        {
            get { return GetRelatedEntities<Fax>("SalesOrder_Faxes", null); }
            set
            {
                OnPropertyChanging("SalesOrder_Faxes");
                SetRelatedEntities("SalesOrder_Faxes", null, value);
                OnPropertyChanged("SalesOrder_Faxes");
            }
        }

        /// <summary>
        ///     1:N SalesOrder_Letters
        /// </summary>
        [RelationshipSchemaName("SalesOrder_Letters")]
        public IEnumerable<Letter> SalesOrder_Letters
        {
            get { return GetRelatedEntities<Letter>("SalesOrder_Letters", null); }
            set
            {
                OnPropertyChanging("SalesOrder_Letters");
                SetRelatedEntities("SalesOrder_Letters", null, value);
                OnPropertyChanged("SalesOrder_Letters");
            }
        }

        /// <summary>
        ///     1:N SalesOrder_OrderClose
        /// </summary>
        [RelationshipSchemaName("SalesOrder_OrderClose")]
        public IEnumerable<OrderClose> SalesOrder_OrderClose
        {
            get { return GetRelatedEntities<OrderClose>("SalesOrder_OrderClose", null); }
            set
            {
                OnPropertyChanging("SalesOrder_OrderClose");
                SetRelatedEntities("SalesOrder_OrderClose", null, value);
                OnPropertyChanged("SalesOrder_OrderClose");
            }
        }

        /// <summary>
        ///     1:N SalesOrder_Phonecalls
        /// </summary>
        [RelationshipSchemaName("SalesOrder_Phonecalls")]
        public IEnumerable<PhoneCall> SalesOrder_Phonecalls
        {
            get { return GetRelatedEntities<PhoneCall>("SalesOrder_Phonecalls", null); }
            set
            {
                OnPropertyChanging("SalesOrder_Phonecalls");
                SetRelatedEntities("SalesOrder_Phonecalls", null, value);
                OnPropertyChanged("SalesOrder_Phonecalls");
            }
        }

        /// <summary>
        ///     1:N salesorder_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("salesorder_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> salesorder_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntities<PrincipalObjectAttributeAccess>("salesorder_principalobjectattributeaccess",
                    null);
            }
            set
            {
                OnPropertyChanging("salesorder_principalobjectattributeaccess");
                SetRelatedEntities("salesorder_principalobjectattributeaccess", null, value);
                OnPropertyChanged("salesorder_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N SalesOrder_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("SalesOrder_ProcessSessions")]
        public IEnumerable<ProcessSession> SalesOrder_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("SalesOrder_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("SalesOrder_ProcessSessions");
                SetRelatedEntities("SalesOrder_ProcessSessions", null, value);
                OnPropertyChanged("SalesOrder_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N SalesOrder_RecurringAppointmentMasters
        /// </summary>
        [RelationshipSchemaName("SalesOrder_RecurringAppointmentMasters")]
        public IEnumerable<RecurringAppointmentMaster> SalesOrder_RecurringAppointmentMasters
        {
            get
            {
                return GetRelatedEntities<RecurringAppointmentMaster>("SalesOrder_RecurringAppointmentMasters", null);
            }
            set
            {
                OnPropertyChanging("SalesOrder_RecurringAppointmentMasters");
                SetRelatedEntities("SalesOrder_RecurringAppointmentMasters", null, value);
                OnPropertyChanged("SalesOrder_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        ///     1:N SalesOrder_ServiceAppointments
        /// </summary>
        [RelationshipSchemaName("SalesOrder_ServiceAppointments")]
        public IEnumerable<ServiceAppointment> SalesOrder_ServiceAppointments
        {
            get { return GetRelatedEntities<ServiceAppointment>("SalesOrder_ServiceAppointments", null); }
            set
            {
                OnPropertyChanging("SalesOrder_ServiceAppointments");
                SetRelatedEntities("SalesOrder_ServiceAppointments", null, value);
                OnPropertyChanged("SalesOrder_ServiceAppointments");
            }
        }

        /// <summary>
        ///     1:N SalesOrder_Tasks
        /// </summary>
        [RelationshipSchemaName("SalesOrder_Tasks")]
        public IEnumerable<Task> SalesOrder_Tasks
        {
            get { return GetRelatedEntities<Task>("SalesOrder_Tasks", null); }
            set
            {
                OnPropertyChanging("SalesOrder_Tasks");
                SetRelatedEntities("SalesOrder_Tasks", null, value);
                OnPropertyChanged("SalesOrder_Tasks");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_salesorder
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_salesorder")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_salesorder
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_salesorder", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_salesorder");
                SetRelatedEntities("userentityinstancedata_salesorder", null, value);
                OnPropertyChanged("userentityinstancedata_salesorder");
            }
        }

        /// <summary>
        ///     N:N contactorders_association
        /// </summary>
        [RelationshipSchemaName("contactorders_association")]
        public IEnumerable<Contact> contactorders_association
        {
            get { return GetRelatedEntities<Contact>("contactorders_association", null); }
            set
            {
                OnPropertyChanging("contactorders_association");
                SetRelatedEntities("contactorders_association", null, value);
                OnPropertyChanged("contactorders_association");
            }
        }

        /// <summary>
        ///     N:1 business_unit_orders
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_orders")]
        public BusinessUnit business_unit_orders
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_orders", null); }
        }

        /// <summary>
        ///     N:1 campaign_orders
        /// </summary>
        [AttributeLogicalName("campaignid")]
        [RelationshipSchemaName("campaign_orders")]
        public Campaign campaign_orders
        {
            get { return GetRelatedEntity<Campaign>("campaign_orders", null); }
            set
            {
                OnPropertyChanging("campaign_orders");
                SetRelatedEntity("campaign_orders", null, value);
                OnPropertyChanged("campaign_orders");
            }
        }

        /// <summary>
        ///     N:1 lk_salesorder_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_salesorder_createdonbehalfby")]
        public SystemUser lk_salesorder_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_salesorder_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_salesorder_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_salesorder_modifiedonbehalfby")]
        public SystemUser lk_salesorder_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_salesorder_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_salesorderbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_salesorderbase_createdby")]
        public SystemUser lk_salesorderbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_salesorderbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_salesorderbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_salesorderbase_modifiedby")]
        public SystemUser lk_salesorderbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_salesorderbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 opportunity_sales_orders
        /// </summary>
        [AttributeLogicalName("opportunityid")]
        [RelationshipSchemaName("opportunity_sales_orders")]
        public Opportunity opportunity_sales_orders
        {
            get { return GetRelatedEntity<Opportunity>("opportunity_sales_orders", null); }
            set
            {
                OnPropertyChanging("opportunity_sales_orders");
                SetRelatedEntity("opportunity_sales_orders", null, value);
                OnPropertyChanged("opportunity_sales_orders");
            }
        }

        /// <summary>
        ///     N:1 order_customer_accounts
        /// </summary>
        [AttributeLogicalName("customerid")]
        [RelationshipSchemaName("order_customer_accounts")]
        public Account order_customer_accounts
        {
            get { return GetRelatedEntity<Account>("order_customer_accounts", null); }
            set
            {
                OnPropertyChanging("order_customer_accounts");
                SetRelatedEntity("order_customer_accounts", null, value);
                OnPropertyChanged("order_customer_accounts");
            }
        }

        /// <summary>
        ///     N:1 order_customer_contacts
        /// </summary>
        [AttributeLogicalName("customerid")]
        [RelationshipSchemaName("order_customer_contacts")]
        public Contact order_customer_contacts
        {
            get { return GetRelatedEntity<Contact>("order_customer_contacts", null); }
            set
            {
                OnPropertyChanging("order_customer_contacts");
                SetRelatedEntity("order_customer_contacts", null, value);
                OnPropertyChanged("order_customer_contacts");
            }
        }

        /// <summary>
        ///     N:1 price_level_orders
        /// </summary>
        [AttributeLogicalName("pricelevelid")]
        [RelationshipSchemaName("price_level_orders")]
        public PriceLevel price_level_orders
        {
            get { return GetRelatedEntity<PriceLevel>("price_level_orders", null); }
            set
            {
                OnPropertyChanging("price_level_orders");
                SetRelatedEntity("price_level_orders", null, value);
                OnPropertyChanged("price_level_orders");
            }
        }

        /// <summary>
        ///     N:1 processstage_salesorders
        /// </summary>
        [AttributeLogicalName("stageid")]
        [RelationshipSchemaName("processstage_salesorders")]
        public ProcessStage processstage_salesorders
        {
            get { return GetRelatedEntity<ProcessStage>("processstage_salesorders", null); }
            set
            {
                OnPropertyChanging("processstage_salesorders");
                SetRelatedEntity("processstage_salesorders", null, value);
                OnPropertyChanged("processstage_salesorders");
            }
        }

        /// <summary>
        ///     N:1 quote_orders
        /// </summary>
        [AttributeLogicalName("quoteid")]
        [RelationshipSchemaName("quote_orders")]
        public Quote quote_orders
        {
            get { return GetRelatedEntity<Quote>("quote_orders", null); }
            set
            {
                OnPropertyChanging("quote_orders");
                SetRelatedEntity("quote_orders", null, value);
                OnPropertyChanged("quote_orders");
            }
        }

        /// <summary>
        ///     N:1 system_user_orders
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("system_user_orders")]
        public SystemUser system_user_orders
        {
            get { return GetRelatedEntity<SystemUser>("system_user_orders", null); }
        }

        /// <summary>
        ///     N:1 team_orders
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_orders")]
        public Team team_orders
        {
            get { return GetRelatedEntity<Team>("team_orders", null); }
        }

        /// <summary>
        ///     N:1 transactioncurrency_salesorder
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("transactioncurrency_salesorder")]
        public TransactionCurrency transactioncurrency_salesorder
        {
            get { return GetRelatedEntity<TransactionCurrency>("transactioncurrency_salesorder", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_salesorder");
                SetRelatedEntity("transactioncurrency_salesorder", null, value);
                OnPropertyChanged("transactioncurrency_salesorder");
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