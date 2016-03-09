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
    ///     Formal offer for products and/or services, proposed at specific prices and related payment terms, which is sent to
    ///     a prospective customer.
    /// </summary>
    [DataContract]
    [EntityLogicalName("quote")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Quote : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "quote";

        public const int EntityTypeCode = 1084;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Quote() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the account with which the quote is associated.
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
        ///     Enter the date when the quote was closed to indicate the expiration, revision, or cancellation date.
        /// </summary>
        [AttributeLogicalName("closedon")]
        public DateTime? ClosedOn
        {
            get { return GetAttributeValue<DateTime?>("closedon"); }
            set
            {
                OnPropertyChanging("ClosedOn");
                SetAttributeValue("closedon", value);
                OnPropertyChanged("ClosedOn");
            }
        }

        /// <summary>
        ///     Unique identifier of the contact associated with the quote.
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
        ///     Type additional information to describe the quote, such as the products or services offered or details about the
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
        ///     Type the discount amount for the quote if the customer is eligible for special savings.
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
        ///     Shows the Discount Amount field converted to the system's default base currency for reporting purposes. The
        ///     calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("discountamount_base")]
        public Money DiscountAmount_Base
        {
            get { return GetAttributeValue<Money>("discountamount_base"); }
        }

        /// <summary>
        ///     Type the discount rate that should be applied to the Detail Amount field to include additional savings for the
        ///     customer in the quote.
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
        ///     Enter the date when the quote pricing is effective or was first communicated to the customer.
        /// </summary>
        [AttributeLogicalName("effectivefrom")]
        public DateTime? EffectiveFrom
        {
            get { return GetAttributeValue<DateTime?>("effectivefrom"); }
            set
            {
                OnPropertyChanging("EffectiveFrom");
                SetAttributeValue("effectivefrom", value);
                OnPropertyChanged("EffectiveFrom");
            }
        }

        /// <summary>
        ///     Enter the expiration date or last day the quote pricing is effective for the customer.
        /// </summary>
        [AttributeLogicalName("effectiveto")]
        public DateTime? EffectiveTo
        {
            get { return GetAttributeValue<DateTime?>("effectiveto"); }
            set
            {
                OnPropertyChanging("EffectiveTo");
                SetAttributeValue("effectiveto", value);
                OnPropertyChanged("EffectiveTo");
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
        ///     Enter the date a decision or order is due from the customer to indicate the expiration date of the quote.
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
        ///     Type the cost of freight or shipping for the products included in the quote for use in calculating the Total Amount
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
        ///     Type a descriptive name for the quote.
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
        ///     Choose the opportunity that the quote is related to for reporting and analytics.
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
        ///     Unique identifier of the business unit that owns the quote.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the quote.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the quote.
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
        ///     Pricing error for the quote.
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
        ///     Unique identifier of the quote.
        /// </summary>
        [AttributeLogicalName("quoteid")]
        public Guid? QuoteId
        {
            get { return GetAttributeValue<Guid?>("quoteid"); }
            set
            {
                OnPropertyChanging("QuoteId");
                SetAttributeValue("quoteid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("QuoteId");
            }
        }

        [AttributeLogicalName("quoteid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { QuoteId = value; }
        }

        /// <summary>
        ///     Shows the quote number for customer reference and searching capabilities. The number cannot be modified.
        /// </summary>
        [AttributeLogicalName("quotenumber")]
        public string QuoteNumber
        {
            get { return GetAttributeValue<string>("quotenumber"); }
            set
            {
                OnPropertyChanging("QuoteNumber");
                SetAttributeValue("quotenumber", value);
                OnPropertyChanged("QuoteNumber");
            }
        }

        /// <summary>
        ///     Enter the delivery date requested by the customer for all products in the quote.
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
        ///     Shows the version number of the quote for revision history tracking.
        /// </summary>
        [AttributeLogicalName("revisionnumber")]
        public int? RevisionNumber
        {
            get { return GetAttributeValue<int?>("revisionnumber"); }
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
        ///     Shows whether the quote is draft, active, won, or closed. Only draft quotes can be edited.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public QuoteState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((QuoteState) (Enum.ToObject(typeof (QuoteState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Select the quote's status.
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
        ///     Shows the total amount due, calculated as the sum of the products, discounts, freight, and taxes for the quote.
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
        ///     Shows the total product amount for the quote, minus any discounts. This value is added to freight and tax amounts
        ///     in the calculation for the total amount due for the quote.
        /// </summary>
        [AttributeLogicalName("totalamountlessfreight")]
        public Money TotalAmountLessFreight
        {
            get { return GetAttributeValue<Money>("totalamountlessfreight"); }
        }

        /// <summary>
        ///     Shows the Pre-Freight Amount converted field to the system's default base currency for reporting purposes. The
        ///     calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("totalamountlessfreight_base")]
        public Money TotalAmountLessFreight_Base
        {
            get { return GetAttributeValue<Money>("totalamountlessfreight_base"); }
        }

        /// <summary>
        ///     Shows the total discount amount, based on the discount price and rate entered on the quote.
        /// </summary>
        [AttributeLogicalName("totaldiscountamount")]
        public Money TotalDiscountAmount
        {
            get { return GetAttributeValue<Money>("totaldiscountamount"); }
        }

        /// <summary>
        ///     Shows the Total Discount Amount converted field to the system's default base currency for reporting purposes. The
        ///     calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("totaldiscountamount_base")]
        public Money TotalDiscountAmount_Base
        {
            get { return GetAttributeValue<Money>("totaldiscountamount_base"); }
        }

        /// <summary>
        ///     Shows the sum of all existing and write-in products included on the quote, based on the specified price list and
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
        ///     Shows the total of the Manual Discount amounts specified on all products included in the quote. This value is
        ///     reflected in the Detail Amount field on the quote and is added to any discount amount or rate specified on the
        ///     quote
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
        ///     Shows the total of the Tax amounts specified on all products included in the quote, included in the Total Amount
        ///     due calculation for the quote.
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
        ///     Version number of the quote.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     Select whether the products included in the quote should be shipped to the specified address or held until the
        ///     customer calls with further pick up or delivery instructions.
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
        ///     1:N quote_activity_parties
        /// </summary>
        [RelationshipSchemaName("quote_activity_parties")]
        public IEnumerable<ActivityParty> quote_activity_parties
        {
            get { return GetRelatedEntities<ActivityParty>("quote_activity_parties", null); }
            set
            {
                OnPropertyChanging("quote_activity_parties");
                SetRelatedEntities("quote_activity_parties", null, value);
                OnPropertyChanged("quote_activity_parties");
            }
        }

        /// <summary>
        ///     1:N Quote_ActivityPointers
        /// </summary>
        [RelationshipSchemaName("Quote_ActivityPointers")]
        public IEnumerable<ActivityPointer> Quote_ActivityPointers
        {
            get { return GetRelatedEntities<ActivityPointer>("Quote_ActivityPointers", null); }
            set
            {
                OnPropertyChanging("Quote_ActivityPointers");
                SetRelatedEntities("Quote_ActivityPointers", null, value);
                OnPropertyChanged("Quote_ActivityPointers");
            }
        }

        /// <summary>
        ///     1:N Quote_Annotation
        /// </summary>
        [RelationshipSchemaName("Quote_Annotation")]
        public IEnumerable<Annotation> Quote_Annotation
        {
            get { return GetRelatedEntities<Annotation>("Quote_Annotation", null); }
            set
            {
                OnPropertyChanging("Quote_Annotation");
                SetRelatedEntities("Quote_Annotation", null, value);
                OnPropertyChanged("Quote_Annotation");
            }
        }

        /// <summary>
        ///     1:N Quote_Appointments
        /// </summary>
        [RelationshipSchemaName("Quote_Appointments")]
        public IEnumerable<Appointment> Quote_Appointments
        {
            get { return GetRelatedEntities<Appointment>("Quote_Appointments", null); }
            set
            {
                OnPropertyChanging("Quote_Appointments");
                SetRelatedEntities("Quote_Appointments", null, value);
                OnPropertyChanged("Quote_Appointments");
            }
        }

        /// <summary>
        ///     1:N Quote_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Quote_AsyncOperations")]
        public IEnumerable<AsyncOperation> Quote_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Quote_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Quote_AsyncOperations");
                SetRelatedEntities("Quote_AsyncOperations", null, value);
                OnPropertyChanged("Quote_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N Quote_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("Quote_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> Quote_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("Quote_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("Quote_BulkDeleteFailures");
                SetRelatedEntities("Quote_BulkDeleteFailures", null, value);
                OnPropertyChanged("Quote_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N quote_connections1
        /// </summary>
        [RelationshipSchemaName("quote_connections1")]
        public IEnumerable<Connection> quote_connections1
        {
            get { return GetRelatedEntities<Connection>("quote_connections1", null); }
            set
            {
                OnPropertyChanging("quote_connections1");
                SetRelatedEntities("quote_connections1", null, value);
                OnPropertyChanged("quote_connections1");
            }
        }

        /// <summary>
        ///     1:N quote_connections2
        /// </summary>
        [RelationshipSchemaName("quote_connections2")]
        public IEnumerable<Connection> quote_connections2
        {
            get { return GetRelatedEntities<Connection>("quote_connections2", null); }
            set
            {
                OnPropertyChanging("quote_connections2");
                SetRelatedEntities("quote_connections2", null, value);
                OnPropertyChanged("quote_connections2");
            }
        }

        /// <summary>
        ///     1:N quote_details
        /// </summary>
        [RelationshipSchemaName("quote_details")]
        public IEnumerable<QuoteDetail> quote_details
        {
            get { return GetRelatedEntities<QuoteDetail>("quote_details", null); }
            set
            {
                OnPropertyChanging("quote_details");
                SetRelatedEntities("quote_details", null, value);
                OnPropertyChanged("quote_details");
            }
        }

        /// <summary>
        ///     1:N Quote_DuplicateBaseRecord
        /// </summary>
        [RelationshipSchemaName("Quote_DuplicateBaseRecord")]
        public IEnumerable<DuplicateRecord> Quote_DuplicateBaseRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Quote_DuplicateBaseRecord", null); }
            set
            {
                OnPropertyChanging("Quote_DuplicateBaseRecord");
                SetRelatedEntities("Quote_DuplicateBaseRecord", null, value);
                OnPropertyChanged("Quote_DuplicateBaseRecord");
            }
        }

        /// <summary>
        ///     1:N Quote_DuplicateMatchingRecord
        /// </summary>
        [RelationshipSchemaName("Quote_DuplicateMatchingRecord")]
        public IEnumerable<DuplicateRecord> Quote_DuplicateMatchingRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Quote_DuplicateMatchingRecord", null); }
            set
            {
                OnPropertyChanging("Quote_DuplicateMatchingRecord");
                SetRelatedEntities("Quote_DuplicateMatchingRecord", null, value);
                OnPropertyChanged("Quote_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        ///     1:N Quote_Emails
        /// </summary>
        [RelationshipSchemaName("Quote_Emails")]
        public IEnumerable<Email> Quote_Emails
        {
            get { return GetRelatedEntities<Email>("Quote_Emails", null); }
            set
            {
                OnPropertyChanging("Quote_Emails");
                SetRelatedEntities("Quote_Emails", null, value);
                OnPropertyChanged("Quote_Emails");
            }
        }

        /// <summary>
        ///     1:N Quote_Faxes
        /// </summary>
        [RelationshipSchemaName("Quote_Faxes")]
        public IEnumerable<Fax> Quote_Faxes
        {
            get { return GetRelatedEntities<Fax>("Quote_Faxes", null); }
            set
            {
                OnPropertyChanging("Quote_Faxes");
                SetRelatedEntities("Quote_Faxes", null, value);
                OnPropertyChanged("Quote_Faxes");
            }
        }

        /// <summary>
        ///     1:N Quote_Letters
        /// </summary>
        [RelationshipSchemaName("Quote_Letters")]
        public IEnumerable<Letter> Quote_Letters
        {
            get { return GetRelatedEntities<Letter>("Quote_Letters", null); }
            set
            {
                OnPropertyChanging("Quote_Letters");
                SetRelatedEntities("Quote_Letters", null, value);
                OnPropertyChanged("Quote_Letters");
            }
        }

        /// <summary>
        ///     1:N quote_orders
        /// </summary>
        [RelationshipSchemaName("quote_orders")]
        public IEnumerable<SalesOrder> quote_orders
        {
            get { return GetRelatedEntities<SalesOrder>("quote_orders", null); }
            set
            {
                OnPropertyChanging("quote_orders");
                SetRelatedEntities("quote_orders", null, value);
                OnPropertyChanged("quote_orders");
            }
        }

        /// <summary>
        ///     1:N Quote_Phonecalls
        /// </summary>
        [RelationshipSchemaName("Quote_Phonecalls")]
        public IEnumerable<PhoneCall> Quote_Phonecalls
        {
            get { return GetRelatedEntities<PhoneCall>("Quote_Phonecalls", null); }
            set
            {
                OnPropertyChanging("Quote_Phonecalls");
                SetRelatedEntities("Quote_Phonecalls", null, value);
                OnPropertyChanged("Quote_Phonecalls");
            }
        }

        /// <summary>
        ///     1:N quote_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("quote_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> quote_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntities<PrincipalObjectAttributeAccess>("quote_principalobjectattributeaccess", null);
            }
            set
            {
                OnPropertyChanging("quote_principalobjectattributeaccess");
                SetRelatedEntities("quote_principalobjectattributeaccess", null, value);
                OnPropertyChanged("quote_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N Quote_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("Quote_ProcessSessions")]
        public IEnumerable<ProcessSession> Quote_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("Quote_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Quote_ProcessSessions");
                SetRelatedEntities("Quote_ProcessSessions", null, value);
                OnPropertyChanged("Quote_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N Quote_QuoteClose
        /// </summary>
        [RelationshipSchemaName("Quote_QuoteClose")]
        public IEnumerable<QuoteClose> Quote_QuoteClose
        {
            get { return GetRelatedEntities<QuoteClose>("Quote_QuoteClose", null); }
            set
            {
                OnPropertyChanging("Quote_QuoteClose");
                SetRelatedEntities("Quote_QuoteClose", null, value);
                OnPropertyChanged("Quote_QuoteClose");
            }
        }

        /// <summary>
        ///     1:N Quote_RecurringAppointmentMasters
        /// </summary>
        [RelationshipSchemaName("Quote_RecurringAppointmentMasters")]
        public IEnumerable<RecurringAppointmentMaster> Quote_RecurringAppointmentMasters
        {
            get { return GetRelatedEntities<RecurringAppointmentMaster>("Quote_RecurringAppointmentMasters", null); }
            set
            {
                OnPropertyChanging("Quote_RecurringAppointmentMasters");
                SetRelatedEntities("Quote_RecurringAppointmentMasters", null, value);
                OnPropertyChanged("Quote_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        ///     1:N Quote_ServiceAppointments
        /// </summary>
        [RelationshipSchemaName("Quote_ServiceAppointments")]
        public IEnumerable<ServiceAppointment> Quote_ServiceAppointments
        {
            get { return GetRelatedEntities<ServiceAppointment>("Quote_ServiceAppointments", null); }
            set
            {
                OnPropertyChanging("Quote_ServiceAppointments");
                SetRelatedEntities("Quote_ServiceAppointments", null, value);
                OnPropertyChanged("Quote_ServiceAppointments");
            }
        }

        /// <summary>
        ///     1:N Quote_SharepointDocumentLocation
        /// </summary>
        [RelationshipSchemaName("Quote_SharepointDocumentLocation")]
        public IEnumerable<SharePointDocumentLocation> Quote_SharepointDocumentLocation
        {
            get { return GetRelatedEntities<SharePointDocumentLocation>("Quote_SharepointDocumentLocation", null); }
            set
            {
                OnPropertyChanging("Quote_SharepointDocumentLocation");
                SetRelatedEntities("Quote_SharepointDocumentLocation", null, value);
                OnPropertyChanged("Quote_SharepointDocumentLocation");
            }
        }

        /// <summary>
        ///     1:N Quote_Tasks
        /// </summary>
        [RelationshipSchemaName("Quote_Tasks")]
        public IEnumerable<Task> Quote_Tasks
        {
            get { return GetRelatedEntities<Task>("Quote_Tasks", null); }
            set
            {
                OnPropertyChanging("Quote_Tasks");
                SetRelatedEntities("Quote_Tasks", null, value);
                OnPropertyChanged("Quote_Tasks");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_quote
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_quote")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_quote
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_quote", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_quote");
                SetRelatedEntities("userentityinstancedata_quote", null, value);
                OnPropertyChanged("userentityinstancedata_quote");
            }
        }

        /// <summary>
        ///     N:N contactquotes_association
        /// </summary>
        [RelationshipSchemaName("contactquotes_association")]
        public IEnumerable<Contact> contactquotes_association
        {
            get { return GetRelatedEntities<Contact>("contactquotes_association", null); }
            set
            {
                OnPropertyChanging("contactquotes_association");
                SetRelatedEntities("contactquotes_association", null, value);
                OnPropertyChanged("contactquotes_association");
            }
        }

        /// <summary>
        ///     N:1 business_unit_quotes
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_quotes")]
        public BusinessUnit business_unit_quotes
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_quotes", null); }
        }

        /// <summary>
        ///     N:1 campaign_quotes
        /// </summary>
        [AttributeLogicalName("campaignid")]
        [RelationshipSchemaName("campaign_quotes")]
        public Campaign campaign_quotes
        {
            get { return GetRelatedEntity<Campaign>("campaign_quotes", null); }
            set
            {
                OnPropertyChanging("campaign_quotes");
                SetRelatedEntity("campaign_quotes", null, value);
                OnPropertyChanged("campaign_quotes");
            }
        }

        /// <summary>
        ///     N:1 lk_quote_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_quote_createdonbehalfby")]
        public SystemUser lk_quote_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_quote_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_quote_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_quote_modifiedonbehalfby")]
        public SystemUser lk_quote_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_quote_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_quotebase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_quotebase_createdby")]
        public SystemUser lk_quotebase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_quotebase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_quotebase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_quotebase_modifiedby")]
        public SystemUser lk_quotebase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_quotebase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 opportunity_quotes
        /// </summary>
        [AttributeLogicalName("opportunityid")]
        [RelationshipSchemaName("opportunity_quotes")]
        public Opportunity opportunity_quotes
        {
            get { return GetRelatedEntity<Opportunity>("opportunity_quotes", null); }
            set
            {
                OnPropertyChanging("opportunity_quotes");
                SetRelatedEntity("opportunity_quotes", null, value);
                OnPropertyChanged("opportunity_quotes");
            }
        }

        /// <summary>
        ///     N:1 price_level_quotes
        /// </summary>
        [AttributeLogicalName("pricelevelid")]
        [RelationshipSchemaName("price_level_quotes")]
        public PriceLevel price_level_quotes
        {
            get { return GetRelatedEntity<PriceLevel>("price_level_quotes", null); }
            set
            {
                OnPropertyChanging("price_level_quotes");
                SetRelatedEntity("price_level_quotes", null, value);
                OnPropertyChanged("price_level_quotes");
            }
        }

        /// <summary>
        ///     N:1 processstage_quotes
        /// </summary>
        [AttributeLogicalName("stageid")]
        [RelationshipSchemaName("processstage_quotes")]
        public ProcessStage processstage_quotes
        {
            get { return GetRelatedEntity<ProcessStage>("processstage_quotes", null); }
            set
            {
                OnPropertyChanging("processstage_quotes");
                SetRelatedEntity("processstage_quotes", null, value);
                OnPropertyChanged("processstage_quotes");
            }
        }

        /// <summary>
        ///     N:1 quote_customer_accounts
        /// </summary>
        [AttributeLogicalName("customerid")]
        [RelationshipSchemaName("quote_customer_accounts")]
        public Account quote_customer_accounts
        {
            get { return GetRelatedEntity<Account>("quote_customer_accounts", null); }
            set
            {
                OnPropertyChanging("quote_customer_accounts");
                SetRelatedEntity("quote_customer_accounts", null, value);
                OnPropertyChanged("quote_customer_accounts");
            }
        }

        /// <summary>
        ///     N:1 quote_customer_contacts
        /// </summary>
        [AttributeLogicalName("customerid")]
        [RelationshipSchemaName("quote_customer_contacts")]
        public Contact quote_customer_contacts
        {
            get { return GetRelatedEntity<Contact>("quote_customer_contacts", null); }
            set
            {
                OnPropertyChanging("quote_customer_contacts");
                SetRelatedEntity("quote_customer_contacts", null, value);
                OnPropertyChanged("quote_customer_contacts");
            }
        }

        /// <summary>
        ///     N:1 system_user_quotes
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("system_user_quotes")]
        public SystemUser system_user_quotes
        {
            get { return GetRelatedEntity<SystemUser>("system_user_quotes", null); }
        }

        /// <summary>
        ///     N:1 team_quotes
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_quotes")]
        public Team team_quotes
        {
            get { return GetRelatedEntity<Team>("team_quotes", null); }
        }

        /// <summary>
        ///     N:1 transactioncurrency_quote
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("transactioncurrency_quote")]
        public TransactionCurrency transactioncurrency_quote
        {
            get { return GetRelatedEntity<TransactionCurrency>("transactioncurrency_quote", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_quote");
                SetRelatedEntity("transactioncurrency_quote", null, value);
                OnPropertyChanged("transactioncurrency_quote");
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