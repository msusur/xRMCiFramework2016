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
    ///     Order that has been billed.
    /// </summary>
    [DataContract]
    [EntityLogicalName("invoice")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Invoice : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "invoice";

        public const int EntityTypeCode = 1090;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Invoice() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the account with which the invoice is associated.
        /// </summary>
        [AttributeLogicalName("accountid")]
        public EntityReference AccountId
        {
            get { return GetAttributeValue<EntityReference>("accountid"); }
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
        ///     Unique identifier of the contact associated with the invoice.
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
        ///     Enter the date when the products included in the invoice were delivered.
        /// </summary>
        [AttributeLogicalName("datedelivered")]
        public DateTime? DateDelivered
        {
            get { return GetAttributeValue<DateTime?>("datedelivered"); }
            set
            {
                OnPropertyChanging("DateDelivered");
                SetAttributeValue("datedelivered", value);
                OnPropertyChanged("DateDelivered");
            }
        }

        /// <summary>
        ///     Type additional information to describe the invoice, such as shipping details or product substitutions.
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
        ///     Type the discount amount for the invoice if the customer is eligible for special savings.
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
        ///     Shows the Invoice Discount field converted to the system's default base currency for reporting purposes. The
        ///     calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("discountamount_base")]
        public Money DiscountAmount_Base
        {
            get { return GetAttributeValue<Money>("discountamount_base"); }
        }

        /// <summary>
        ///     Type the discount rate that should be applied to the Detail Amount field, for use in calculating the Pre-Freight
        ///     Amount and Total Amount values for the invoice.
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
        ///     Enter the date by which the invoice should be paid by the customer.
        /// </summary>
        [AttributeLogicalName("duedate")]
        public DateTime? DueDate
        {
            get { return GetAttributeValue<DateTime?>("duedate"); }
            set
            {
                OnPropertyChanging("DueDate");
                SetAttributeValue("duedate", value);
                OnPropertyChanged("DueDate");
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
        ///     Type the cost of freight or shipping for the products included in the invoice for use in calculating the total
        ///     amount due.
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
        ///     Unique identifier of the invoice.
        /// </summary>
        [AttributeLogicalName("invoiceid")]
        public Guid? InvoiceId
        {
            get { return GetAttributeValue<Guid?>("invoiceid"); }
            set
            {
                OnPropertyChanging("InvoiceId");
                SetAttributeValue("invoiceid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("InvoiceId");
            }
        }

        [AttributeLogicalName("invoiceid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { InvoiceId = value; }
        }

        /// <summary>
        ///     Shows the identifying number or code of the invoice.
        /// </summary>
        [AttributeLogicalName("invoicenumber")]
        public string InvoiceNumber
        {
            get { return GetAttributeValue<string>("invoicenumber"); }
            set
            {
                OnPropertyChanging("InvoiceNumber");
                SetAttributeValue("invoicenumber", value);
                OnPropertyChanged("InvoiceNumber");
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
        ///     Enter the date and time when the invoice was last submitted to an accounting or ERP system for processing.
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
        ///     Type a descriptive name for the invoice.
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
        ///     Choose the opportunity that the invoice is related to for reporting and analytics.
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
        ///     Unique identifier of the business unit that owns the invoice.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the invoice.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the invoice.
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
        ///     Type of pricing error for the invoice.
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
        ///     Choose the order related to the invoice to make sure the order is fulfilled and invoiced correctly.
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
        ///     Shows whether the invoice is active, paid, or canceled. Paid and canceled invoices are read-only and can't be
        ///     edited unless they are reactivated.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public InvoiceState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((InvoiceState) (Enum.ToObject(typeof (InvoiceState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Select the invoice's status.
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
        ///     Shows the total amount due, calculated as the sum of the products, discount, freight, and taxes for the invoice.
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
        ///     Shows the total product amount due, minus any discounts. This value is added to freight and tax amounts in the
        ///     calculation for the total amount due for the invoice.
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
        ///     Shows the total discount amount, based on the discount price and rate entered on the invoice.
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
        ///     Shows the sum of all existing and write-in products included on the invoice, based on the specified price list and
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
        ///     Shows the Manual Discount amounts specified on all products included in the invoice. This value is reflected in the
        ///     Detail Amount field on the invoice and is added to any discount amount or rate specified on the invoice.
        /// </summary>
        [AttributeLogicalName("totallineitemdiscountamount")]
        public Money TotalLineItemDiscountAmount
        {
            get { return GetAttributeValue<Money>("totallineitemdiscountamount"); }
        }

        /// <summary>
        ///     Shows the total of the Manual Discount amounts specified on all products included in the invoice. This value is
        ///     reflected in the Detail Amount field on the invoice and is added to any discount amount or rate specified on the
        ///     invoice.
        /// </summary>
        [AttributeLogicalName("totallineitemdiscountamount_base")]
        public Money TotalLineItemDiscountAmount_Base
        {
            get { return GetAttributeValue<Money>("totallineitemdiscountamount_base"); }
        }

        /// <summary>
        ///     Shows the total of the Tax amounts specified on all products included in the invoice, included in the Total Amount
        ///     due calculation for the invoice.
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
        ///     Version number of the invoice.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     Select whether the products included in the invoice should be shipped to the specified address or held until the
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
        ///     1:N invoice_activity_parties
        /// </summary>
        [RelationshipSchemaName("invoice_activity_parties")]
        public IEnumerable<ActivityParty> invoice_activity_parties
        {
            get { return GetRelatedEntities<ActivityParty>("invoice_activity_parties", null); }
            set
            {
                OnPropertyChanging("invoice_activity_parties");
                SetRelatedEntities("invoice_activity_parties", null, value);
                OnPropertyChanged("invoice_activity_parties");
            }
        }

        /// <summary>
        ///     1:N Invoice_ActivityPointers
        /// </summary>
        [RelationshipSchemaName("Invoice_ActivityPointers")]
        public IEnumerable<ActivityPointer> Invoice_ActivityPointers
        {
            get { return GetRelatedEntities<ActivityPointer>("Invoice_ActivityPointers", null); }
            set
            {
                OnPropertyChanging("Invoice_ActivityPointers");
                SetRelatedEntities("Invoice_ActivityPointers", null, value);
                OnPropertyChanged("Invoice_ActivityPointers");
            }
        }

        /// <summary>
        ///     1:N Invoice_Annotation
        /// </summary>
        [RelationshipSchemaName("Invoice_Annotation")]
        public IEnumerable<Annotation> Invoice_Annotation
        {
            get { return GetRelatedEntities<Annotation>("Invoice_Annotation", null); }
            set
            {
                OnPropertyChanging("Invoice_Annotation");
                SetRelatedEntities("Invoice_Annotation", null, value);
                OnPropertyChanged("Invoice_Annotation");
            }
        }

        /// <summary>
        ///     1:N Invoice_Appointments
        /// </summary>
        [RelationshipSchemaName("Invoice_Appointments")]
        public IEnumerable<Appointment> Invoice_Appointments
        {
            get { return GetRelatedEntities<Appointment>("Invoice_Appointments", null); }
            set
            {
                OnPropertyChanging("Invoice_Appointments");
                SetRelatedEntities("Invoice_Appointments", null, value);
                OnPropertyChanged("Invoice_Appointments");
            }
        }

        /// <summary>
        ///     1:N Invoice_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Invoice_AsyncOperations")]
        public IEnumerable<AsyncOperation> Invoice_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Invoice_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Invoice_AsyncOperations");
                SetRelatedEntities("Invoice_AsyncOperations", null, value);
                OnPropertyChanged("Invoice_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N Invoice_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("Invoice_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> Invoice_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("Invoice_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("Invoice_BulkDeleteFailures");
                SetRelatedEntities("Invoice_BulkDeleteFailures", null, value);
                OnPropertyChanged("Invoice_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N invoice_connections1
        /// </summary>
        [RelationshipSchemaName("invoice_connections1")]
        public IEnumerable<Connection> invoice_connections1
        {
            get { return GetRelatedEntities<Connection>("invoice_connections1", null); }
            set
            {
                OnPropertyChanging("invoice_connections1");
                SetRelatedEntities("invoice_connections1", null, value);
                OnPropertyChanged("invoice_connections1");
            }
        }

        /// <summary>
        ///     1:N invoice_connections2
        /// </summary>
        [RelationshipSchemaName("invoice_connections2")]
        public IEnumerable<Connection> invoice_connections2
        {
            get { return GetRelatedEntities<Connection>("invoice_connections2", null); }
            set
            {
                OnPropertyChanging("invoice_connections2");
                SetRelatedEntities("invoice_connections2", null, value);
                OnPropertyChanged("invoice_connections2");
            }
        }

        /// <summary>
        ///     1:N invoice_details
        /// </summary>
        [RelationshipSchemaName("invoice_details")]
        public IEnumerable<InvoiceDetail> invoice_details
        {
            get { return GetRelatedEntities<InvoiceDetail>("invoice_details", null); }
            set
            {
                OnPropertyChanging("invoice_details");
                SetRelatedEntities("invoice_details", null, value);
                OnPropertyChanged("invoice_details");
            }
        }

        /// <summary>
        ///     1:N Invoice_Emails
        /// </summary>
        [RelationshipSchemaName("Invoice_Emails")]
        public IEnumerable<Email> Invoice_Emails
        {
            get { return GetRelatedEntities<Email>("Invoice_Emails", null); }
            set
            {
                OnPropertyChanging("Invoice_Emails");
                SetRelatedEntities("Invoice_Emails", null, value);
                OnPropertyChanged("Invoice_Emails");
            }
        }

        /// <summary>
        ///     1:N Invoice_Faxes
        /// </summary>
        [RelationshipSchemaName("Invoice_Faxes")]
        public IEnumerable<Fax> Invoice_Faxes
        {
            get { return GetRelatedEntities<Fax>("Invoice_Faxes", null); }
            set
            {
                OnPropertyChanging("Invoice_Faxes");
                SetRelatedEntities("Invoice_Faxes", null, value);
                OnPropertyChanged("Invoice_Faxes");
            }
        }

        /// <summary>
        ///     1:N Invoice_Letters
        /// </summary>
        [RelationshipSchemaName("Invoice_Letters")]
        public IEnumerable<Letter> Invoice_Letters
        {
            get { return GetRelatedEntities<Letter>("Invoice_Letters", null); }
            set
            {
                OnPropertyChanging("Invoice_Letters");
                SetRelatedEntities("Invoice_Letters", null, value);
                OnPropertyChanged("Invoice_Letters");
            }
        }

        /// <summary>
        ///     1:N Invoice_Phonecalls
        /// </summary>
        [RelationshipSchemaName("Invoice_Phonecalls")]
        public IEnumerable<PhoneCall> Invoice_Phonecalls
        {
            get { return GetRelatedEntities<PhoneCall>("Invoice_Phonecalls", null); }
            set
            {
                OnPropertyChanging("Invoice_Phonecalls");
                SetRelatedEntities("Invoice_Phonecalls", null, value);
                OnPropertyChanged("Invoice_Phonecalls");
            }
        }

        /// <summary>
        ///     1:N invoice_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("invoice_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> invoice_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntities<PrincipalObjectAttributeAccess>("invoice_principalobjectattributeaccess", null);
            }
            set
            {
                OnPropertyChanging("invoice_principalobjectattributeaccess");
                SetRelatedEntities("invoice_principalobjectattributeaccess", null, value);
                OnPropertyChanged("invoice_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N Invoice_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("Invoice_ProcessSessions")]
        public IEnumerable<ProcessSession> Invoice_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("Invoice_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Invoice_ProcessSessions");
                SetRelatedEntities("Invoice_ProcessSessions", null, value);
                OnPropertyChanged("Invoice_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N Invoice_RecurringAppointmentMasters
        /// </summary>
        [RelationshipSchemaName("Invoice_RecurringAppointmentMasters")]
        public IEnumerable<RecurringAppointmentMaster> Invoice_RecurringAppointmentMasters
        {
            get { return GetRelatedEntities<RecurringAppointmentMaster>("Invoice_RecurringAppointmentMasters", null); }
            set
            {
                OnPropertyChanging("Invoice_RecurringAppointmentMasters");
                SetRelatedEntities("Invoice_RecurringAppointmentMasters", null, value);
                OnPropertyChanged("Invoice_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        ///     1:N Invoice_ServiceAppointments
        /// </summary>
        [RelationshipSchemaName("Invoice_ServiceAppointments")]
        public IEnumerable<ServiceAppointment> Invoice_ServiceAppointments
        {
            get { return GetRelatedEntities<ServiceAppointment>("Invoice_ServiceAppointments", null); }
            set
            {
                OnPropertyChanging("Invoice_ServiceAppointments");
                SetRelatedEntities("Invoice_ServiceAppointments", null, value);
                OnPropertyChanged("Invoice_ServiceAppointments");
            }
        }

        /// <summary>
        ///     1:N Invoice_Tasks
        /// </summary>
        [RelationshipSchemaName("Invoice_Tasks")]
        public IEnumerable<Task> Invoice_Tasks
        {
            get { return GetRelatedEntities<Task>("Invoice_Tasks", null); }
            set
            {
                OnPropertyChanging("Invoice_Tasks");
                SetRelatedEntities("Invoice_Tasks", null, value);
                OnPropertyChanged("Invoice_Tasks");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_invoice
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_invoice")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_invoice
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_invoice", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_invoice");
                SetRelatedEntities("userentityinstancedata_invoice", null, value);
                OnPropertyChanged("userentityinstancedata_invoice");
            }
        }

        /// <summary>
        ///     N:N contactinvoices_association
        /// </summary>
        [RelationshipSchemaName("contactinvoices_association")]
        public IEnumerable<Contact> contactinvoices_association
        {
            get { return GetRelatedEntities<Contact>("contactinvoices_association", null); }
            set
            {
                OnPropertyChanging("contactinvoices_association");
                SetRelatedEntities("contactinvoices_association", null, value);
                OnPropertyChanged("contactinvoices_association");
            }
        }

        /// <summary>
        ///     N:1 business_unit_invoices
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_invoices")]
        public BusinessUnit business_unit_invoices
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_invoices", null); }
        }

        /// <summary>
        ///     N:1 invoice_customer_accounts
        /// </summary>
        [AttributeLogicalName("customerid")]
        [RelationshipSchemaName("invoice_customer_accounts")]
        public Account invoice_customer_accounts
        {
            get { return GetRelatedEntity<Account>("invoice_customer_accounts", null); }
            set
            {
                OnPropertyChanging("invoice_customer_accounts");
                SetRelatedEntity("invoice_customer_accounts", null, value);
                OnPropertyChanged("invoice_customer_accounts");
            }
        }

        /// <summary>
        ///     N:1 invoice_customer_contacts
        /// </summary>
        [AttributeLogicalName("customerid")]
        [RelationshipSchemaName("invoice_customer_contacts")]
        public Contact invoice_customer_contacts
        {
            get { return GetRelatedEntity<Contact>("invoice_customer_contacts", null); }
            set
            {
                OnPropertyChanging("invoice_customer_contacts");
                SetRelatedEntity("invoice_customer_contacts", null, value);
                OnPropertyChanged("invoice_customer_contacts");
            }
        }

        /// <summary>
        ///     N:1 lk_invoice_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_invoice_createdonbehalfby")]
        public SystemUser lk_invoice_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_invoice_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_invoice_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_invoice_modifiedonbehalfby")]
        public SystemUser lk_invoice_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_invoice_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_invoicebase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_invoicebase_createdby")]
        public SystemUser lk_invoicebase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_invoicebase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_invoicebase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_invoicebase_modifiedby")]
        public SystemUser lk_invoicebase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_invoicebase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 opportunity_invoices
        /// </summary>
        [AttributeLogicalName("opportunityid")]
        [RelationshipSchemaName("opportunity_invoices")]
        public Opportunity opportunity_invoices
        {
            get { return GetRelatedEntity<Opportunity>("opportunity_invoices", null); }
            set
            {
                OnPropertyChanging("opportunity_invoices");
                SetRelatedEntity("opportunity_invoices", null, value);
                OnPropertyChanged("opportunity_invoices");
            }
        }

        /// <summary>
        ///     N:1 order_invoices
        /// </summary>
        [AttributeLogicalName("salesorderid")]
        [RelationshipSchemaName("order_invoices")]
        public SalesOrder order_invoices
        {
            get { return GetRelatedEntity<SalesOrder>("order_invoices", null); }
            set
            {
                OnPropertyChanging("order_invoices");
                SetRelatedEntity("order_invoices", null, value);
                OnPropertyChanged("order_invoices");
            }
        }

        /// <summary>
        ///     N:1 price_level_invoices
        /// </summary>
        [AttributeLogicalName("pricelevelid")]
        [RelationshipSchemaName("price_level_invoices")]
        public PriceLevel price_level_invoices
        {
            get { return GetRelatedEntity<PriceLevel>("price_level_invoices", null); }
            set
            {
                OnPropertyChanging("price_level_invoices");
                SetRelatedEntity("price_level_invoices", null, value);
                OnPropertyChanged("price_level_invoices");
            }
        }

        /// <summary>
        ///     N:1 processstage_invoices
        /// </summary>
        [AttributeLogicalName("stageid")]
        [RelationshipSchemaName("processstage_invoices")]
        public ProcessStage processstage_invoices
        {
            get { return GetRelatedEntity<ProcessStage>("processstage_invoices", null); }
            set
            {
                OnPropertyChanging("processstage_invoices");
                SetRelatedEntity("processstage_invoices", null, value);
                OnPropertyChanged("processstage_invoices");
            }
        }

        /// <summary>
        ///     N:1 system_user_invoices
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("system_user_invoices")]
        public SystemUser system_user_invoices
        {
            get { return GetRelatedEntity<SystemUser>("system_user_invoices", null); }
        }

        /// <summary>
        ///     N:1 team_invoices
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_invoices")]
        public Team team_invoices
        {
            get { return GetRelatedEntity<Team>("team_invoices", null); }
        }

        /// <summary>
        ///     N:1 transactioncurrency_invoice
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("transactioncurrency_invoice")]
        public TransactionCurrency transactioncurrency_invoice
        {
            get { return GetRelatedEntity<TransactionCurrency>("transactioncurrency_invoice", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_invoice");
                SetRelatedEntity("transactioncurrency_invoice", null, value);
                OnPropertyChanged("transactioncurrency_invoice");
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