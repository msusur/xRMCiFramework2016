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
    ///     Prospect or potential sales opportunity. Leads are converted into accounts, contacts, or opportunities when they
    ///     are qualified. Otherwise, they are deleted or archived.
    /// </summary>
    [DataContract]
    [EntityLogicalName("lead")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Lead : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "lead";

        public const int EntityTypeCode = 4;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Lead() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the account with which the lead is associated.
        /// </summary>
        [AttributeLogicalName("accountid")]
        public EntityReference AccountId
        {
            get { return GetAttributeValue<EntityReference>("accountid"); }
        }

        /// <summary>
        ///     Unique identifier for address 1.
        /// </summary>
        [AttributeLogicalName("address1_addressid")]
        public Guid? Address1_AddressId
        {
            get { return GetAttributeValue<Guid?>("address1_addressid"); }
            set
            {
                OnPropertyChanging("Address1_AddressId");
                SetAttributeValue("address1_addressid", value);
                OnPropertyChanged("Address1_AddressId");
            }
        }

        /// <summary>
        ///     Select the primary address type.
        /// </summary>
        [AttributeLogicalName("address1_addresstypecode")]
        public OptionSetValue Address1_AddressTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("address1_addresstypecode"); }
            set
            {
                OnPropertyChanging("Address1_AddressTypeCode");
                SetAttributeValue("address1_addresstypecode", value);
                OnPropertyChanged("Address1_AddressTypeCode");
            }
        }

        /// <summary>
        ///     Type the city for the primary address.
        /// </summary>
        [AttributeLogicalName("address1_city")]
        public string Address1_City
        {
            get { return GetAttributeValue<string>("address1_city"); }
            set
            {
                OnPropertyChanging("Address1_City");
                SetAttributeValue("address1_city", value);
                OnPropertyChanged("Address1_City");
            }
        }

        /// <summary>
        ///     Shows the complete primary address.
        /// </summary>
        [AttributeLogicalName("address1_composite")]
        public string Address1_Composite
        {
            get { return GetAttributeValue<string>("address1_composite"); }
        }

        /// <summary>
        ///     Type the country or region for the primary address.
        /// </summary>
        [AttributeLogicalName("address1_country")]
        public string Address1_Country
        {
            get { return GetAttributeValue<string>("address1_country"); }
            set
            {
                OnPropertyChanging("Address1_Country");
                SetAttributeValue("address1_country", value);
                OnPropertyChanged("Address1_Country");
            }
        }

        /// <summary>
        ///     Type the county for the primary address.
        /// </summary>
        [AttributeLogicalName("address1_county")]
        public string Address1_County
        {
            get { return GetAttributeValue<string>("address1_county"); }
            set
            {
                OnPropertyChanging("Address1_County");
                SetAttributeValue("address1_county", value);
                OnPropertyChanged("Address1_County");
            }
        }

        /// <summary>
        ///     Type the fax number associated with the primary address.
        /// </summary>
        [AttributeLogicalName("address1_fax")]
        public string Address1_Fax
        {
            get { return GetAttributeValue<string>("address1_fax"); }
            set
            {
                OnPropertyChanging("Address1_Fax");
                SetAttributeValue("address1_fax", value);
                OnPropertyChanged("Address1_Fax");
            }
        }

        /// <summary>
        ///     Type the latitude value for the primary address for use in mapping and other applications.
        /// </summary>
        [AttributeLogicalName("address1_latitude")]
        public double? Address1_Latitude
        {
            get { return GetAttributeValue<double?>("address1_latitude"); }
            set
            {
                OnPropertyChanging("Address1_Latitude");
                SetAttributeValue("address1_latitude", value);
                OnPropertyChanged("Address1_Latitude");
            }
        }

        /// <summary>
        ///     Type the first line of the primary address.
        /// </summary>
        [AttributeLogicalName("address1_line1")]
        public string Address1_Line1
        {
            get { return GetAttributeValue<string>("address1_line1"); }
            set
            {
                OnPropertyChanging("Address1_Line1");
                SetAttributeValue("address1_line1", value);
                OnPropertyChanged("Address1_Line1");
            }
        }

        /// <summary>
        ///     Type the second line of the primary address.
        /// </summary>
        [AttributeLogicalName("address1_line2")]
        public string Address1_Line2
        {
            get { return GetAttributeValue<string>("address1_line2"); }
            set
            {
                OnPropertyChanging("Address1_Line2");
                SetAttributeValue("address1_line2", value);
                OnPropertyChanged("Address1_Line2");
            }
        }

        /// <summary>
        ///     Type the third line of the primary address.
        /// </summary>
        [AttributeLogicalName("address1_line3")]
        public string Address1_Line3
        {
            get { return GetAttributeValue<string>("address1_line3"); }
            set
            {
                OnPropertyChanging("Address1_Line3");
                SetAttributeValue("address1_line3", value);
                OnPropertyChanged("Address1_Line3");
            }
        }

        /// <summary>
        ///     Type the longitude value for the primary address for use in mapping and other applications.
        /// </summary>
        [AttributeLogicalName("address1_longitude")]
        public double? Address1_Longitude
        {
            get { return GetAttributeValue<double?>("address1_longitude"); }
            set
            {
                OnPropertyChanging("Address1_Longitude");
                SetAttributeValue("address1_longitude", value);
                OnPropertyChanged("Address1_Longitude");
            }
        }

        /// <summary>
        ///     Type a descriptive name for the primary address, such as Corporate Headquarters.
        /// </summary>
        [AttributeLogicalName("address1_name")]
        public string Address1_Name
        {
            get { return GetAttributeValue<string>("address1_name"); }
            set
            {
                OnPropertyChanging("Address1_Name");
                SetAttributeValue("address1_name", value);
                OnPropertyChanged("Address1_Name");
            }
        }

        /// <summary>
        ///     Type the ZIP Code or postal code for the primary address.
        /// </summary>
        [AttributeLogicalName("address1_postalcode")]
        public string Address1_PostalCode
        {
            get { return GetAttributeValue<string>("address1_postalcode"); }
            set
            {
                OnPropertyChanging("Address1_PostalCode");
                SetAttributeValue("address1_postalcode", value);
                OnPropertyChanged("Address1_PostalCode");
            }
        }

        /// <summary>
        ///     Type the post office box number of the primary address.
        /// </summary>
        [AttributeLogicalName("address1_postofficebox")]
        public string Address1_PostOfficeBox
        {
            get { return GetAttributeValue<string>("address1_postofficebox"); }
            set
            {
                OnPropertyChanging("Address1_PostOfficeBox");
                SetAttributeValue("address1_postofficebox", value);
                OnPropertyChanged("Address1_PostOfficeBox");
            }
        }

        /// <summary>
        ///     Select a shipping method for deliveries sent to this address.
        /// </summary>
        [AttributeLogicalName("address1_shippingmethodcode")]
        public OptionSetValue Address1_ShippingMethodCode
        {
            get { return GetAttributeValue<OptionSetValue>("address1_shippingmethodcode"); }
            set
            {
                OnPropertyChanging("Address1_ShippingMethodCode");
                SetAttributeValue("address1_shippingmethodcode", value);
                OnPropertyChanged("Address1_ShippingMethodCode");
            }
        }

        /// <summary>
        ///     Type the state or province of the primary address.
        /// </summary>
        [AttributeLogicalName("address1_stateorprovince")]
        public string Address1_StateOrProvince
        {
            get { return GetAttributeValue<string>("address1_stateorprovince"); }
            set
            {
                OnPropertyChanging("Address1_StateOrProvince");
                SetAttributeValue("address1_stateorprovince", value);
                OnPropertyChanged("Address1_StateOrProvince");
            }
        }

        /// <summary>
        ///     Type the main phone number associated with the primary address.
        /// </summary>
        [AttributeLogicalName("address1_telephone1")]
        public string Address1_Telephone1
        {
            get { return GetAttributeValue<string>("address1_telephone1"); }
            set
            {
                OnPropertyChanging("Address1_Telephone1");
                SetAttributeValue("address1_telephone1", value);
                OnPropertyChanged("Address1_Telephone1");
            }
        }

        /// <summary>
        ///     Type a second phone number associated with the primary address.
        /// </summary>
        [AttributeLogicalName("address1_telephone2")]
        public string Address1_Telephone2
        {
            get { return GetAttributeValue<string>("address1_telephone2"); }
            set
            {
                OnPropertyChanging("Address1_Telephone2");
                SetAttributeValue("address1_telephone2", value);
                OnPropertyChanged("Address1_Telephone2");
            }
        }

        /// <summary>
        ///     Type a third phone number associated with the primary address.
        /// </summary>
        [AttributeLogicalName("address1_telephone3")]
        public string Address1_Telephone3
        {
            get { return GetAttributeValue<string>("address1_telephone3"); }
            set
            {
                OnPropertyChanging("Address1_Telephone3");
                SetAttributeValue("address1_telephone3", value);
                OnPropertyChanged("Address1_Telephone3");
            }
        }

        /// <summary>
        ///     Type the UPS zone of the primary address to make sure shipping charges are calculated correctly and deliveries are
        ///     made promptly, if shipped by UPS.
        /// </summary>
        [AttributeLogicalName("address1_upszone")]
        public string Address1_UPSZone
        {
            get { return GetAttributeValue<string>("address1_upszone"); }
            set
            {
                OnPropertyChanging("Address1_UPSZone");
                SetAttributeValue("address1_upszone", value);
                OnPropertyChanged("Address1_UPSZone");
            }
        }

        /// <summary>
        ///     Select the time zone, or UTC offset, for this address so that other people can reference it when they contact
        ///     someone at this address.
        /// </summary>
        [AttributeLogicalName("address1_utcoffset")]
        public int? Address1_UTCOffset
        {
            get { return GetAttributeValue<int?>("address1_utcoffset"); }
            set
            {
                OnPropertyChanging("Address1_UTCOffset");
                SetAttributeValue("address1_utcoffset", value);
                OnPropertyChanged("Address1_UTCOffset");
            }
        }

        /// <summary>
        ///     Unique identifier for address 2.
        /// </summary>
        [AttributeLogicalName("address2_addressid")]
        public Guid? Address2_AddressId
        {
            get { return GetAttributeValue<Guid?>("address2_addressid"); }
            set
            {
                OnPropertyChanging("Address2_AddressId");
                SetAttributeValue("address2_addressid", value);
                OnPropertyChanged("Address2_AddressId");
            }
        }

        /// <summary>
        ///     Select the secondary address type.
        /// </summary>
        [AttributeLogicalName("address2_addresstypecode")]
        public OptionSetValue Address2_AddressTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("address2_addresstypecode"); }
            set
            {
                OnPropertyChanging("Address2_AddressTypeCode");
                SetAttributeValue("address2_addresstypecode", value);
                OnPropertyChanged("Address2_AddressTypeCode");
            }
        }

        /// <summary>
        ///     Type the city for the secondary address.
        /// </summary>
        [AttributeLogicalName("address2_city")]
        public string Address2_City
        {
            get { return GetAttributeValue<string>("address2_city"); }
            set
            {
                OnPropertyChanging("Address2_City");
                SetAttributeValue("address2_city", value);
                OnPropertyChanged("Address2_City");
            }
        }

        /// <summary>
        ///     Shows the complete secondary address.
        /// </summary>
        [AttributeLogicalName("address2_composite")]
        public string Address2_Composite
        {
            get { return GetAttributeValue<string>("address2_composite"); }
        }

        /// <summary>
        ///     Type the country or region for the secondary address.
        /// </summary>
        [AttributeLogicalName("address2_country")]
        public string Address2_Country
        {
            get { return GetAttributeValue<string>("address2_country"); }
            set
            {
                OnPropertyChanging("Address2_Country");
                SetAttributeValue("address2_country", value);
                OnPropertyChanged("Address2_Country");
            }
        }

        /// <summary>
        ///     Type the county for the secondary address.
        /// </summary>
        [AttributeLogicalName("address2_county")]
        public string Address2_County
        {
            get { return GetAttributeValue<string>("address2_county"); }
            set
            {
                OnPropertyChanging("Address2_County");
                SetAttributeValue("address2_county", value);
                OnPropertyChanged("Address2_County");
            }
        }

        /// <summary>
        ///     Type the fax number associated with the secondary address.
        /// </summary>
        [AttributeLogicalName("address2_fax")]
        public string Address2_Fax
        {
            get { return GetAttributeValue<string>("address2_fax"); }
            set
            {
                OnPropertyChanging("Address2_Fax");
                SetAttributeValue("address2_fax", value);
                OnPropertyChanged("Address2_Fax");
            }
        }

        /// <summary>
        ///     Type the latitude value for the secondary address for use in mapping and other applications.
        /// </summary>
        [AttributeLogicalName("address2_latitude")]
        public double? Address2_Latitude
        {
            get { return GetAttributeValue<double?>("address2_latitude"); }
            set
            {
                OnPropertyChanging("Address2_Latitude");
                SetAttributeValue("address2_latitude", value);
                OnPropertyChanged("Address2_Latitude");
            }
        }

        /// <summary>
        ///     Type the first line of the secondary address.
        /// </summary>
        [AttributeLogicalName("address2_line1")]
        public string Address2_Line1
        {
            get { return GetAttributeValue<string>("address2_line1"); }
            set
            {
                OnPropertyChanging("Address2_Line1");
                SetAttributeValue("address2_line1", value);
                OnPropertyChanged("Address2_Line1");
            }
        }

        /// <summary>
        ///     Type the second line of the secondary address.
        /// </summary>
        [AttributeLogicalName("address2_line2")]
        public string Address2_Line2
        {
            get { return GetAttributeValue<string>("address2_line2"); }
            set
            {
                OnPropertyChanging("Address2_Line2");
                SetAttributeValue("address2_line2", value);
                OnPropertyChanged("Address2_Line2");
            }
        }

        /// <summary>
        ///     Type the third line of the secondary address.
        /// </summary>
        [AttributeLogicalName("address2_line3")]
        public string Address2_Line3
        {
            get { return GetAttributeValue<string>("address2_line3"); }
            set
            {
                OnPropertyChanging("Address2_Line3");
                SetAttributeValue("address2_line3", value);
                OnPropertyChanged("Address2_Line3");
            }
        }

        /// <summary>
        ///     Type the longitude value for the secondary address for use in mapping and other applications.
        /// </summary>
        [AttributeLogicalName("address2_longitude")]
        public double? Address2_Longitude
        {
            get { return GetAttributeValue<double?>("address2_longitude"); }
            set
            {
                OnPropertyChanging("Address2_Longitude");
                SetAttributeValue("address2_longitude", value);
                OnPropertyChanged("Address2_Longitude");
            }
        }

        /// <summary>
        ///     Type a descriptive name for the secondary address, such as Corporate Headquarters.
        /// </summary>
        [AttributeLogicalName("address2_name")]
        public string Address2_Name
        {
            get { return GetAttributeValue<string>("address2_name"); }
            set
            {
                OnPropertyChanging("Address2_Name");
                SetAttributeValue("address2_name", value);
                OnPropertyChanged("Address2_Name");
            }
        }

        /// <summary>
        ///     Type the ZIP Code or postal code for the secondary address.
        /// </summary>
        [AttributeLogicalName("address2_postalcode")]
        public string Address2_PostalCode
        {
            get { return GetAttributeValue<string>("address2_postalcode"); }
            set
            {
                OnPropertyChanging("Address2_PostalCode");
                SetAttributeValue("address2_postalcode", value);
                OnPropertyChanged("Address2_PostalCode");
            }
        }

        /// <summary>
        ///     Type the post office box number of the secondary address.
        /// </summary>
        [AttributeLogicalName("address2_postofficebox")]
        public string Address2_PostOfficeBox
        {
            get { return GetAttributeValue<string>("address2_postofficebox"); }
            set
            {
                OnPropertyChanging("Address2_PostOfficeBox");
                SetAttributeValue("address2_postofficebox", value);
                OnPropertyChanged("Address2_PostOfficeBox");
            }
        }

        /// <summary>
        ///     Select a shipping method for deliveries sent to this address.
        /// </summary>
        [AttributeLogicalName("address2_shippingmethodcode")]
        public OptionSetValue Address2_ShippingMethodCode
        {
            get { return GetAttributeValue<OptionSetValue>("address2_shippingmethodcode"); }
            set
            {
                OnPropertyChanging("Address2_ShippingMethodCode");
                SetAttributeValue("address2_shippingmethodcode", value);
                OnPropertyChanged("Address2_ShippingMethodCode");
            }
        }

        /// <summary>
        ///     Type the state or province of the secondary address.
        /// </summary>
        [AttributeLogicalName("address2_stateorprovince")]
        public string Address2_StateOrProvince
        {
            get { return GetAttributeValue<string>("address2_stateorprovince"); }
            set
            {
                OnPropertyChanging("Address2_StateOrProvince");
                SetAttributeValue("address2_stateorprovince", value);
                OnPropertyChanged("Address2_StateOrProvince");
            }
        }

        /// <summary>
        ///     Type the main phone number associated with the secondary address.
        /// </summary>
        [AttributeLogicalName("address2_telephone1")]
        public string Address2_Telephone1
        {
            get { return GetAttributeValue<string>("address2_telephone1"); }
            set
            {
                OnPropertyChanging("Address2_Telephone1");
                SetAttributeValue("address2_telephone1", value);
                OnPropertyChanged("Address2_Telephone1");
            }
        }

        /// <summary>
        ///     Type a second phone number associated with the secondary address.
        /// </summary>
        [AttributeLogicalName("address2_telephone2")]
        public string Address2_Telephone2
        {
            get { return GetAttributeValue<string>("address2_telephone2"); }
            set
            {
                OnPropertyChanging("Address2_Telephone2");
                SetAttributeValue("address2_telephone2", value);
                OnPropertyChanged("Address2_Telephone2");
            }
        }

        /// <summary>
        ///     Type a third phone number associated with the secondary address.
        /// </summary>
        [AttributeLogicalName("address2_telephone3")]
        public string Address2_Telephone3
        {
            get { return GetAttributeValue<string>("address2_telephone3"); }
            set
            {
                OnPropertyChanging("Address2_Telephone3");
                SetAttributeValue("address2_telephone3", value);
                OnPropertyChanged("Address2_Telephone3");
            }
        }

        /// <summary>
        ///     Type the UPS zone of the secondary address to make sure shipping charges are calculated correctly and deliveries
        ///     are made promptly, if shipped by UPS.
        /// </summary>
        [AttributeLogicalName("address2_upszone")]
        public string Address2_UPSZone
        {
            get { return GetAttributeValue<string>("address2_upszone"); }
            set
            {
                OnPropertyChanging("Address2_UPSZone");
                SetAttributeValue("address2_upszone", value);
                OnPropertyChanged("Address2_UPSZone");
            }
        }

        /// <summary>
        ///     Select the time zone, or UTC offset, for this address so that other people can reference it when they contact
        ///     someone at this address.
        /// </summary>
        [AttributeLogicalName("address2_utcoffset")]
        public int? Address2_UTCOffset
        {
            get { return GetAttributeValue<int?>("address2_utcoffset"); }
            set
            {
                OnPropertyChanging("Address2_UTCOffset");
                SetAttributeValue("address2_utcoffset", value);
                OnPropertyChanged("Address2_UTCOffset");
            }
        }

        /// <summary>
        ///     Information about the budget amount of the lead's company or organization.
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
        ///     Base currency equivalent of the estimated budget of the lead.
        /// </summary>
        [AttributeLogicalName("budgetamount_base")]
        public Money BudgetAmount_Base
        {
            get { return GetAttributeValue<Money>("budgetamount_base"); }
        }

        /// <summary>
        ///     Information about the budget status of the lead's company or organization.
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
        ///     Choose the campaign that the lead was generated from to track the effectiveness of marketing campaigns and identify
        ///     communications received by the lead.
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
        ///     Type the name of the company associated with the lead. This becomes the account name when the lead is qualified and
        ///     converted to a customer account.
        /// </summary>
        [AttributeLogicalName("companyname")]
        public string CompanyName
        {
            get { return GetAttributeValue<string>("companyname"); }
            set
            {
                OnPropertyChanging("CompanyName");
                SetAttributeValue("companyname", value);
                OnPropertyChanged("CompanyName");
            }
        }

        /// <summary>
        ///     Select whether the lead confirmed interest in your offerings. This helps in determining the lead quality.
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
        ///     Unique identifier of the contact with which the lead is associated.
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
        ///     Type additional information to describe the lead, such as an excerpt from the company's website.
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
        ///     Select whether the lead accepts bulk email sent through marketing campaigns or quick campaigns. If Do Not Allow is
        ///     selected, the lead can be added to marketing lists, but will be excluded from the email.
        /// </summary>
        [AttributeLogicalName("donotbulkemail")]
        public bool? DoNotBulkEMail
        {
            get { return GetAttributeValue<bool?>("donotbulkemail"); }
            set
            {
                OnPropertyChanging("DoNotBulkEMail");
                SetAttributeValue("donotbulkemail", value);
                OnPropertyChanged("DoNotBulkEMail");
            }
        }

        /// <summary>
        ///     Select whether the lead allows direct email sent from Microsoft Dynamics CRM.
        /// </summary>
        [AttributeLogicalName("donotemail")]
        public bool? DoNotEMail
        {
            get { return GetAttributeValue<bool?>("donotemail"); }
            set
            {
                OnPropertyChanging("DoNotEMail");
                SetAttributeValue("donotemail", value);
                OnPropertyChanged("DoNotEMail");
            }
        }

        /// <summary>
        ///     Select whether the lead allows faxes.
        /// </summary>
        [AttributeLogicalName("donotfax")]
        public bool? DoNotFax
        {
            get { return GetAttributeValue<bool?>("donotfax"); }
            set
            {
                OnPropertyChanging("DoNotFax");
                SetAttributeValue("donotfax", value);
                OnPropertyChanged("DoNotFax");
            }
        }

        /// <summary>
        ///     Select whether the lead allows phone calls.
        /// </summary>
        [AttributeLogicalName("donotphone")]
        public bool? DoNotPhone
        {
            get { return GetAttributeValue<bool?>("donotphone"); }
            set
            {
                OnPropertyChanging("DoNotPhone");
                SetAttributeValue("donotphone", value);
                OnPropertyChanged("DoNotPhone");
            }
        }

        /// <summary>
        ///     Select whether the lead allows direct mail.
        /// </summary>
        [AttributeLogicalName("donotpostalmail")]
        public bool? DoNotPostalMail
        {
            get { return GetAttributeValue<bool?>("donotpostalmail"); }
            set
            {
                OnPropertyChanging("DoNotPostalMail");
                SetAttributeValue("donotpostalmail", value);
                OnPropertyChanged("DoNotPostalMail");
            }
        }

        /// <summary>
        ///     Select whether the lead accepts marketing materials, such as brochures or catalogs. Leads that opt out can be
        ///     excluded from marketing initiatives.
        /// </summary>
        [AttributeLogicalName("donotsendmm")]
        public bool? DoNotSendMM
        {
            get { return GetAttributeValue<bool?>("donotsendmm"); }
            set
            {
                OnPropertyChanging("DoNotSendMM");
                SetAttributeValue("donotsendmm", value);
                OnPropertyChanged("DoNotSendMM");
            }
        }

        /// <summary>
        ///     Type the primary email address for the lead.
        /// </summary>
        [AttributeLogicalName("emailaddress1")]
        public string EMailAddress1
        {
            get { return GetAttributeValue<string>("emailaddress1"); }
            set
            {
                OnPropertyChanging("EMailAddress1");
                SetAttributeValue("emailaddress1", value);
                OnPropertyChanged("EMailAddress1");
            }
        }

        /// <summary>
        ///     Type the secondary email address for the lead.
        /// </summary>
        [AttributeLogicalName("emailaddress2")]
        public string EMailAddress2
        {
            get { return GetAttributeValue<string>("emailaddress2"); }
            set
            {
                OnPropertyChanging("EMailAddress2");
                SetAttributeValue("emailaddress2", value);
                OnPropertyChanged("EMailAddress2");
            }
        }

        /// <summary>
        ///     Type a third email address for the lead.
        /// </summary>
        [AttributeLogicalName("emailaddress3")]
        public string EMailAddress3
        {
            get { return GetAttributeValue<string>("emailaddress3"); }
            set
            {
                OnPropertyChanging("EMailAddress3");
                SetAttributeValue("emailaddress3", value);
                OnPropertyChanged("EMailAddress3");
            }
        }

        /// <summary>
        ///     Shows the default image for the record.
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
        ///     Type the estimated revenue value that this lead will generate to assist in sales forecasting and planning.
        /// </summary>
        [AttributeLogicalName("estimatedamount")]
        public Money EstimatedAmount
        {
            get { return GetAttributeValue<Money>("estimatedamount"); }
            set
            {
                OnPropertyChanging("EstimatedAmount");
                SetAttributeValue("estimatedamount", value);
                OnPropertyChanged("EstimatedAmount");
            }
        }

        /// <summary>
        ///     Shows the Est. Value field converted to the system's default base currency. The calculation uses the exchange rate
        ///     specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("estimatedamount_base")]
        public Money EstimatedAmount_Base
        {
            get { return GetAttributeValue<Money>("estimatedamount_base"); }
        }

        /// <summary>
        ///     Enter the expected close date for the lead, so that the sales team can schedule timely follow-up meetings to move
        ///     the prospect to the next sales stage.
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
        ///     Type a numeric value of the lead's estimated value, such as a product quantity, if no revenue amount can be
        ///     specified in the Est. Value field. This can be used for sales forecasting and planning.
        /// </summary>
        [AttributeLogicalName("estimatedvalue")]
        public double? EstimatedValue
        {
            get { return GetAttributeValue<double?>("estimatedvalue"); }
            set
            {
                OnPropertyChanging("EstimatedValue");
                SetAttributeValue("estimatedvalue", value);
                OnPropertyChanged("EstimatedValue");
            }
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
        ///     Type the fax number for the primary contact for the lead.
        /// </summary>
        [AttributeLogicalName("fax")]
        public string Fax
        {
            get { return GetAttributeValue<string>("fax"); }
            set
            {
                OnPropertyChanging("Fax");
                SetAttributeValue("fax", value);
                OnPropertyChanged("Fax");
            }
        }

        /// <summary>
        ///     Type the first name of the primary contact for the lead to make sure the prospect is addressed correctly in sales
        ///     calls, email, and marketing campaigns.
        /// </summary>
        [AttributeLogicalName("firstname")]
        public string FirstName
        {
            get { return GetAttributeValue<string>("firstname"); }
            set
            {
                OnPropertyChanging("FirstName");
                SetAttributeValue("firstname", value);
                OnPropertyChanged("FirstName");
            }
        }

        /// <summary>
        ///     Combines and shows the lead's first and last names so the full name can be displayed in views and reports.
        /// </summary>
        [AttributeLogicalName("fullname")]
        public string FullName
        {
            get { return GetAttributeValue<string>("fullname"); }
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
        ///     Select the primary industry in which the lead's business is focused, for use in marketing segmentation and
        ///     demographic analysis.
        /// </summary>
        [AttributeLogicalName("industrycode")]
        public OptionSetValue IndustryCode
        {
            get { return GetAttributeValue<OptionSetValue>("industrycode"); }
            set
            {
                OnPropertyChanging("IndustryCode");
                SetAttributeValue("industrycode", value);
                OnPropertyChanged("IndustryCode");
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
        ///     Type the job title of the primary contact for this lead to make sure the prospect is addressed correctly in sales
        ///     calls, email, and marketing campaigns.
        /// </summary>
        [AttributeLogicalName("jobtitle")]
        public string JobTitle
        {
            get { return GetAttributeValue<string>("jobtitle"); }
            set
            {
                OnPropertyChanging("JobTitle");
                SetAttributeValue("jobtitle", value);
                OnPropertyChanged("JobTitle");
            }
        }

        /// <summary>
        ///     Type the last name of the primary contact for the lead to make sure the prospect is addressed correctly in sales
        ///     calls, email, and marketing campaigns.
        /// </summary>
        [AttributeLogicalName("lastname")]
        public string LastName
        {
            get { return GetAttributeValue<string>("lastname"); }
            set
            {
                OnPropertyChanging("LastName");
                SetAttributeValue("lastname", value);
                OnPropertyChanged("LastName");
            }
        }

        /// <summary>
        ///     Shows the date when the lead was last included in a marketing campaign or quick campaign.
        /// </summary>
        [AttributeLogicalName("lastusedincampaign")]
        public DateTime? LastUsedInCampaign
        {
            get { return GetAttributeValue<DateTime?>("lastusedincampaign"); }
            set
            {
                OnPropertyChanging("LastUsedInCampaign");
                SetAttributeValue("lastusedincampaign", value);
                OnPropertyChanged("LastUsedInCampaign");
            }
        }

        /// <summary>
        ///     Unique identifier of the lead.
        /// </summary>
        [AttributeLogicalName("leadid")]
        public Guid? LeadId
        {
            get { return GetAttributeValue<Guid?>("leadid"); }
            set
            {
                OnPropertyChanging("LeadId");
                SetAttributeValue("leadid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("LeadId");
            }
        }

        [AttributeLogicalName("leadid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { LeadId = value; }
        }

        /// <summary>
        ///     Select a rating value to indicate the lead's potential to become a customer.
        /// </summary>
        [AttributeLogicalName("leadqualitycode")]
        public OptionSetValue LeadQualityCode
        {
            get { return GetAttributeValue<OptionSetValue>("leadqualitycode"); }
            set
            {
                OnPropertyChanging("LeadQualityCode");
                SetAttributeValue("leadqualitycode", value);
                OnPropertyChanged("LeadQualityCode");
            }
        }

        /// <summary>
        ///     Select the primary marketing source that prompted the lead to contact you.
        /// </summary>
        [AttributeLogicalName("leadsourcecode")]
        public OptionSetValue LeadSourceCode
        {
            get { return GetAttributeValue<OptionSetValue>("leadsourcecode"); }
            set
            {
                OnPropertyChanging("LeadSourceCode");
                SetAttributeValue("leadsourcecode", value);
                OnPropertyChanged("LeadSourceCode");
            }
        }

        /// <summary>
        ///     Unique identifier of the master lead for merge.
        /// </summary>
        [AttributeLogicalName("masterid")]
        public EntityReference MasterId
        {
            get { return GetAttributeValue<EntityReference>("masterid"); }
        }

        /// <summary>
        ///     Tells whether the lead has been merged with another lead.
        /// </summary>
        [AttributeLogicalName("merged")]
        public bool? Merged
        {
            get { return GetAttributeValue<bool?>("merged"); }
        }

        /// <summary>
        ///     Type the middle name or initial of the primary contact for the lead to make sure the prospect is addressed
        ///     correctly.
        /// </summary>
        [AttributeLogicalName("middlename")]
        public string MiddleName
        {
            get { return GetAttributeValue<string>("middlename"); }
            set
            {
                OnPropertyChanging("MiddleName");
                SetAttributeValue("middlename", value);
                OnPropertyChanged("MiddleName");
            }
        }

        /// <summary>
        ///     Type the mobile phone number for the primary contact for the lead.
        /// </summary>
        [AttributeLogicalName("mobilephone")]
        public string MobilePhone
        {
            get { return GetAttributeValue<string>("mobilephone"); }
            set
            {
                OnPropertyChanging("MobilePhone");
                SetAttributeValue("mobilephone", value);
                OnPropertyChanged("MobilePhone");
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
        ///     Type the number of employees that work at the company associated with the lead, for use in marketing segmentation
        ///     and demographic analysis.
        /// </summary>
        [AttributeLogicalName("numberofemployees")]
        public int? NumberOfEmployees
        {
            get { return GetAttributeValue<int?>("numberofemployees"); }
            set
            {
                OnPropertyChanging("NumberOfEmployees");
                SetAttributeValue("numberofemployees", value);
                OnPropertyChanged("NumberOfEmployees");
            }
        }

        /// <summary>
        ///     This attribute is used for Sample Service Business Processes.
        /// </summary>
        [AttributeLogicalName("originatingcaseid")]
        public EntityReference OriginatingCaseId
        {
            get { return GetAttributeValue<EntityReference>("originatingcaseid"); }
            set
            {
                OnPropertyChanging("OriginatingCaseId");
                SetAttributeValue("originatingcaseid", value);
                OnPropertyChanged("OriginatingCaseId");
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
        ///     Unique identifier of the business unit that owns the lead.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the lead.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the lead.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Type the pager number for the primary contact for the lead.
        /// </summary>
        [AttributeLogicalName("pager")]
        public string Pager
        {
            get { return GetAttributeValue<string>("pager"); }
            set
            {
                OnPropertyChanging("Pager");
                SetAttributeValue("pager", value);
                OnPropertyChanged("Pager");
            }
        }

        /// <summary>
        ///     Choose an account to connect this lead to, so that the relationship is visible in reports and analytics.
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
        ///     Choose a contact to connect this lead to, so that the relationship is visible in reports and analytics.
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
        ///     Shows whether the lead participates in workflow rules.
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
        ///     Select the preferred method of contact.
        /// </summary>
        [AttributeLogicalName("preferredcontactmethodcode")]
        public OptionSetValue PreferredContactMethodCode
        {
            get { return GetAttributeValue<OptionSetValue>("preferredcontactmethodcode"); }
            set
            {
                OnPropertyChanging("PreferredContactMethodCode");
                SetAttributeValue("preferredcontactmethodcode", value);
                OnPropertyChanged("PreferredContactMethodCode");
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
        ///     Choose how long the lead will likely take to make the purchase, so the sales team will be aware.
        /// </summary>
        [AttributeLogicalName("purchasetimeframe")]
        public OptionSetValue PurchaseTimeFrame
        {
            get { return GetAttributeValue<OptionSetValue>("purchasetimeframe"); }
            set
            {
                OnPropertyChanging("PurchaseTimeFrame");
                SetAttributeValue("purchasetimeframe", value);
                OnPropertyChanged("PurchaseTimeFrame");
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
        ///     Choose the opportunity that the lead was qualified on and then converted to.
        /// </summary>
        [AttributeLogicalName("qualifyingopportunityid")]
        public EntityReference QualifyingOpportunityId
        {
            get { return GetAttributeValue<EntityReference>("qualifyingopportunityid"); }
            set
            {
                OnPropertyChanging("QualifyingOpportunityId");
                SetAttributeValue("qualifyingopportunityid", value);
                OnPropertyChanged("QualifyingOpportunityId");
            }
        }

        /// <summary>
        ///     Related Campaign Response.
        /// </summary>
        [AttributeLogicalName("relatedobjectid")]
        public EntityReference RelatedObjectId
        {
            get { return GetAttributeValue<EntityReference>("relatedobjectid"); }
            set
            {
                OnPropertyChanging("RelatedObjectId");
                SetAttributeValue("relatedobjectid", value);
                OnPropertyChanged("RelatedObjectId");
            }
        }

        /// <summary>
        ///     Type the annual revenue of the company associated with the lead to provide an understanding of the prospect's
        ///     business.
        /// </summary>
        [AttributeLogicalName("revenue")]
        public Money Revenue
        {
            get { return GetAttributeValue<Money>("revenue"); }
            set
            {
                OnPropertyChanging("Revenue");
                SetAttributeValue("revenue", value);
                OnPropertyChanged("Revenue");
            }
        }

        /// <summary>
        ///     Shows the Annual Revenue field converted to the system's default base currency. The calculation uses the exchange
        ///     rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("revenue_base")]
        public Money Revenue_Base
        {
            get { return GetAttributeValue<Money>("revenue_base"); }
        }

        /// <summary>
        ///     Select the sales stage of this lead to aid the sales team in their efforts to convert this lead to an opportunity.
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
        ///     Select the sales process stage for the lead to help determine the probability of the lead converting to an
        ///     opportunity.
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
        ///     Type the salutation of the primary contact for this lead to make sure the prospect is addressed correctly in sales
        ///     calls, email messages, and marketing campaigns.
        /// </summary>
        [AttributeLogicalName("salutation")]
        public string Salutation
        {
            get { return GetAttributeValue<string>("salutation"); }
            set
            {
                OnPropertyChanging("Salutation");
                SetAttributeValue("salutation", value);
                OnPropertyChanged("Salutation");
            }
        }

        /// <summary>
        ///     Enter the date and time of the prospecting follow-up meeting with the lead.
        /// </summary>
        [AttributeLogicalName("schedulefollowup_prospect")]
        public DateTime? ScheduleFollowUp_Prospect
        {
            get { return GetAttributeValue<DateTime?>("schedulefollowup_prospect"); }
            set
            {
                OnPropertyChanging("ScheduleFollowUp_Prospect");
                SetAttributeValue("schedulefollowup_prospect", value);
                OnPropertyChanged("ScheduleFollowUp_Prospect");
            }
        }

        /// <summary>
        ///     Enter the date and time of the qualifying follow-up meeting with the lead.
        /// </summary>
        [AttributeLogicalName("schedulefollowup_qualify")]
        public DateTime? ScheduleFollowUp_Qualify
        {
            get { return GetAttributeValue<DateTime?>("schedulefollowup_qualify"); }
            set
            {
                OnPropertyChanging("ScheduleFollowUp_Qualify");
                SetAttributeValue("schedulefollowup_qualify", value);
                OnPropertyChanged("ScheduleFollowUp_Qualify");
            }
        }

        /// <summary>
        ///     Type the Standard Industrial Classification (SIC) code that indicates the lead's primary industry of business for
        ///     use in marketing segmentation and demographic analysis.
        /// </summary>
        [AttributeLogicalName("sic")]
        public string SIC
        {
            get { return GetAttributeValue<string>("sic"); }
            set
            {
                OnPropertyChanging("SIC");
                SetAttributeValue("sic", value);
                OnPropertyChanged("SIC");
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
        ///     Shows whether the lead is open, qualified, or disqualified. Qualified and disqualified leads are read-only and
        ///     can't be edited unless they are reactivated.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public LeadState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((LeadState) (Enum.ToObject(typeof (LeadState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Select the lead's status.
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
        ///     Type a subject or descriptive name, such as the expected order, company name, or marketing source list, to identify
        ///     the lead.
        /// </summary>
        [AttributeLogicalName("subject")]
        public string Subject
        {
            get { return GetAttributeValue<string>("subject"); }
            set
            {
                OnPropertyChanging("Subject");
                SetAttributeValue("subject", value);
                OnPropertyChanged("Subject");
            }
        }

        /// <summary>
        ///     Type the work phone number for the primary contact for the lead.
        /// </summary>
        [AttributeLogicalName("telephone1")]
        public string Telephone1
        {
            get { return GetAttributeValue<string>("telephone1"); }
            set
            {
                OnPropertyChanging("Telephone1");
                SetAttributeValue("telephone1", value);
                OnPropertyChanged("Telephone1");
            }
        }

        /// <summary>
        ///     Type the home phone number for the primary contact for the lead.
        /// </summary>
        [AttributeLogicalName("telephone2")]
        public string Telephone2
        {
            get { return GetAttributeValue<string>("telephone2"); }
            set
            {
                OnPropertyChanging("Telephone2");
                SetAttributeValue("telephone2", value);
                OnPropertyChanged("Telephone2");
            }
        }

        /// <summary>
        ///     Type an alternate phone number for the primary contact for the lead.
        /// </summary>
        [AttributeLogicalName("telephone3")]
        public string Telephone3
        {
            get { return GetAttributeValue<string>("telephone3"); }
            set
            {
                OnPropertyChanging("Telephone3");
                SetAttributeValue("telephone3", value);
                OnPropertyChanged("Telephone3");
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
        ///     Version number of the lead.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     Type the website URL for the company associated with this lead.
        /// </summary>
        [AttributeLogicalName("websiteurl")]
        public string WebSiteUrl
        {
            get { return GetAttributeValue<string>("websiteurl"); }
            set
            {
                OnPropertyChanging("WebSiteUrl");
                SetAttributeValue("websiteurl", value);
                OnPropertyChanged("WebSiteUrl");
            }
        }

        /// <summary>
        ///     Type the phonetic spelling of the lead's company name, if the name is specified in Japanese, to make sure the name
        ///     is pronounced correctly in phone calls with the prospect.
        /// </summary>
        [AttributeLogicalName("yomicompanyname")]
        public string YomiCompanyName
        {
            get { return GetAttributeValue<string>("yomicompanyname"); }
            set
            {
                OnPropertyChanging("YomiCompanyName");
                SetAttributeValue("yomicompanyname", value);
                OnPropertyChanged("YomiCompanyName");
            }
        }

        /// <summary>
        ///     Type the phonetic spelling of the lead's first name, if the name is specified in Japanese, to make sure the name is
        ///     pronounced correctly in phone calls with the prospect.
        /// </summary>
        [AttributeLogicalName("yomifirstname")]
        public string YomiFirstName
        {
            get { return GetAttributeValue<string>("yomifirstname"); }
            set
            {
                OnPropertyChanging("YomiFirstName");
                SetAttributeValue("yomifirstname", value);
                OnPropertyChanged("YomiFirstName");
            }
        }

        /// <summary>
        ///     Combines and shows the lead's Yomi first and last names so the full phonetic name can be displayed in views and
        ///     reports.
        /// </summary>
        [AttributeLogicalName("yomifullname")]
        public string YomiFullName
        {
            get { return GetAttributeValue<string>("yomifullname"); }
        }

        /// <summary>
        ///     Type the phonetic spelling of the lead's last name, if the name is specified in Japanese, to make sure the name is
        ///     pronounced correctly in phone calls with the prospect.
        /// </summary>
        [AttributeLogicalName("yomilastname")]
        public string YomiLastName
        {
            get { return GetAttributeValue<string>("yomilastname"); }
            set
            {
                OnPropertyChanging("YomiLastName");
                SetAttributeValue("yomilastname", value);
                OnPropertyChanged("YomiLastName");
            }
        }

        /// <summary>
        ///     Type the phonetic spelling of the lead's middle name, if the name is specified in Japanese, to make sure the name
        ///     is pronounced correctly in phone calls with the prospect.
        /// </summary>
        [AttributeLogicalName("yomimiddlename")]
        public string YomiMiddleName
        {
            get { return GetAttributeValue<string>("yomimiddlename"); }
            set
            {
                OnPropertyChanging("YomiMiddleName");
                SetAttributeValue("yomimiddlename", value);
                OnPropertyChanged("YomiMiddleName");
            }
        }

        /// <summary>
        ///     1:N account_originating_lead
        /// </summary>
        [RelationshipSchemaName("account_originating_lead")]
        public IEnumerable<Account> account_originating_lead
        {
            get { return GetRelatedEntities<Account>("account_originating_lead", null); }
            set
            {
                OnPropertyChanging("account_originating_lead");
                SetRelatedEntities("account_originating_lead", null, value);
                OnPropertyChanged("account_originating_lead");
            }
        }

        /// <summary>
        ///     1:N contact_originating_lead
        /// </summary>
        [RelationshipSchemaName("contact_originating_lead")]
        public IEnumerable<Contact> contact_originating_lead
        {
            get { return GetRelatedEntities<Contact>("contact_originating_lead", null); }
            set
            {
                OnPropertyChanging("contact_originating_lead");
                SetRelatedEntities("contact_originating_lead", null, value);
                OnPropertyChanged("contact_originating_lead");
            }
        }

        /// <summary>
        ///     1:N CreatedLead_BulkOperationLogs
        /// </summary>
        [RelationshipSchemaName("CreatedLead_BulkOperationLogs")]
        public IEnumerable<BulkOperationLog> CreatedLead_BulkOperationLogs
        {
            get { return GetRelatedEntities<BulkOperationLog>("CreatedLead_BulkOperationLogs", null); }
            set
            {
                OnPropertyChanging("CreatedLead_BulkOperationLogs");
                SetRelatedEntities("CreatedLead_BulkOperationLogs", null, value);
                OnPropertyChanged("CreatedLead_BulkOperationLogs");
            }
        }

        /// <summary>
        ///     1:N lead_activity_parties
        /// </summary>
        [RelationshipSchemaName("lead_activity_parties")]
        public IEnumerable<ActivityParty> lead_activity_parties
        {
            get { return GetRelatedEntities<ActivityParty>("lead_activity_parties", null); }
            set
            {
                OnPropertyChanging("lead_activity_parties");
                SetRelatedEntities("lead_activity_parties", null, value);
                OnPropertyChanged("lead_activity_parties");
            }
        }

        /// <summary>
        ///     1:N Lead_ActivityPointers
        /// </summary>
        [RelationshipSchemaName("Lead_ActivityPointers")]
        public IEnumerable<ActivityPointer> Lead_ActivityPointers
        {
            get { return GetRelatedEntities<ActivityPointer>("Lead_ActivityPointers", null); }
            set
            {
                OnPropertyChanging("Lead_ActivityPointers");
                SetRelatedEntities("Lead_ActivityPointers", null, value);
                OnPropertyChanged("Lead_ActivityPointers");
            }
        }

        /// <summary>
        ///     1:N lead_addresses
        /// </summary>
        [RelationshipSchemaName("lead_addresses")]
        public IEnumerable<LeadAddress> lead_addresses
        {
            get { return GetRelatedEntities<LeadAddress>("lead_addresses", null); }
            set
            {
                OnPropertyChanging("lead_addresses");
                SetRelatedEntities("lead_addresses", null, value);
                OnPropertyChanged("lead_addresses");
            }
        }

        /// <summary>
        ///     1:N Lead_Annotation
        /// </summary>
        [RelationshipSchemaName("Lead_Annotation")]
        public IEnumerable<Annotation> Lead_Annotation
        {
            get { return GetRelatedEntities<Annotation>("Lead_Annotation", null); }
            set
            {
                OnPropertyChanging("Lead_Annotation");
                SetRelatedEntities("Lead_Annotation", null, value);
                OnPropertyChanged("Lead_Annotation");
            }
        }

        /// <summary>
        ///     1:N Lead_Appointments
        /// </summary>
        [RelationshipSchemaName("Lead_Appointments")]
        public IEnumerable<Appointment> Lead_Appointments
        {
            get { return GetRelatedEntities<Appointment>("Lead_Appointments", null); }
            set
            {
                OnPropertyChanging("Lead_Appointments");
                SetRelatedEntities("Lead_Appointments", null, value);
                OnPropertyChanged("Lead_Appointments");
            }
        }

        /// <summary>
        ///     1:N Lead_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Lead_AsyncOperations")]
        public IEnumerable<AsyncOperation> Lead_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Lead_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Lead_AsyncOperations");
                SetRelatedEntities("Lead_AsyncOperations", null, value);
                OnPropertyChanged("Lead_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N Lead_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("Lead_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> Lead_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("Lead_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("Lead_BulkDeleteFailures");
                SetRelatedEntities("Lead_BulkDeleteFailures", null, value);
                OnPropertyChanged("Lead_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N lead_connections1
        /// </summary>
        [RelationshipSchemaName("lead_connections1")]
        public IEnumerable<Connection> lead_connections1
        {
            get { return GetRelatedEntities<Connection>("lead_connections1", null); }
            set
            {
                OnPropertyChanging("lead_connections1");
                SetRelatedEntities("lead_connections1", null, value);
                OnPropertyChanged("lead_connections1");
            }
        }

        /// <summary>
        ///     1:N lead_connections2
        /// </summary>
        [RelationshipSchemaName("lead_connections2")]
        public IEnumerable<Connection> lead_connections2
        {
            get { return GetRelatedEntities<Connection>("lead_connections2", null); }
            set
            {
                OnPropertyChanging("lead_connections2");
                SetRelatedEntities("lead_connections2", null, value);
                OnPropertyChanged("lead_connections2");
            }
        }

        /// <summary>
        ///     1:N Lead_DuplicateBaseRecord
        /// </summary>
        [RelationshipSchemaName("Lead_DuplicateBaseRecord")]
        public IEnumerable<DuplicateRecord> Lead_DuplicateBaseRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Lead_DuplicateBaseRecord", null); }
            set
            {
                OnPropertyChanging("Lead_DuplicateBaseRecord");
                SetRelatedEntities("Lead_DuplicateBaseRecord", null, value);
                OnPropertyChanged("Lead_DuplicateBaseRecord");
            }
        }

        /// <summary>
        ///     1:N Lead_DuplicateMatchingRecord
        /// </summary>
        [RelationshipSchemaName("Lead_DuplicateMatchingRecord")]
        public IEnumerable<DuplicateRecord> Lead_DuplicateMatchingRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Lead_DuplicateMatchingRecord", null); }
            set
            {
                OnPropertyChanging("Lead_DuplicateMatchingRecord");
                SetRelatedEntities("Lead_DuplicateMatchingRecord", null, value);
                OnPropertyChanged("Lead_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        ///     1:N Lead_Emails
        /// </summary>
        [RelationshipSchemaName("Lead_Emails")]
        public IEnumerable<Email> Lead_Emails
        {
            get { return GetRelatedEntities<Email>("Lead_Emails", null); }
            set
            {
                OnPropertyChanging("Lead_Emails");
                SetRelatedEntities("Lead_Emails", null, value);
                OnPropertyChanged("Lead_Emails");
            }
        }

        /// <summary>
        ///     1:N Lead_Faxes
        /// </summary>
        [RelationshipSchemaName("Lead_Faxes")]
        public IEnumerable<Fax> Lead_Faxes
        {
            get { return GetRelatedEntities<Fax>("Lead_Faxes", null); }
            set
            {
                OnPropertyChanging("Lead_Faxes");
                SetRelatedEntities("Lead_Faxes", null, value);
                OnPropertyChanged("Lead_Faxes");
            }
        }

        /// <summary>
        ///     1:N Lead_Letters
        /// </summary>
        [RelationshipSchemaName("Lead_Letters")]
        public IEnumerable<Letter> Lead_Letters
        {
            get { return GetRelatedEntities<Letter>("Lead_Letters", null); }
            set
            {
                OnPropertyChanging("Lead_Letters");
                SetRelatedEntities("Lead_Letters", null, value);
                OnPropertyChanged("Lead_Letters");
            }
        }

        /// <summary>
        ///     1:N lead_master_lead
        /// </summary>
        [RelationshipSchemaName("lead_master_lead", EntityRole.Referenced)]
        public IEnumerable<Lead> Referencedlead_master_lead
        {
            get { return GetRelatedEntities<Lead>("lead_master_lead", EntityRole.Referenced); }
            set
            {
                OnPropertyChanging("Referencedlead_master_lead");
                SetRelatedEntities("lead_master_lead", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedlead_master_lead");
            }
        }

        /// <summary>
        ///     1:N Lead_Phonecalls
        /// </summary>
        [RelationshipSchemaName("Lead_Phonecalls")]
        public IEnumerable<PhoneCall> Lead_Phonecalls
        {
            get { return GetRelatedEntities<PhoneCall>("Lead_Phonecalls", null); }
            set
            {
                OnPropertyChanging("Lead_Phonecalls");
                SetRelatedEntities("Lead_Phonecalls", null, value);
                OnPropertyChanged("Lead_Phonecalls");
            }
        }

        /// <summary>
        ///     1:N lead_PostFollows
        /// </summary>
        [RelationshipSchemaName("lead_PostFollows")]
        public IEnumerable<PostFollow> lead_PostFollows
        {
            get { return GetRelatedEntities<PostFollow>("lead_PostFollows", null); }
            set
            {
                OnPropertyChanging("lead_PostFollows");
                SetRelatedEntities("lead_PostFollows", null, value);
                OnPropertyChanged("lead_PostFollows");
            }
        }

        /// <summary>
        ///     1:N lead_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("lead_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> lead_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntities<PrincipalObjectAttributeAccess>("lead_principalobjectattributeaccess", null);
            }
            set
            {
                OnPropertyChanging("lead_principalobjectattributeaccess");
                SetRelatedEntities("lead_principalobjectattributeaccess", null, value);
                OnPropertyChanged("lead_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N Lead_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("Lead_ProcessSessions")]
        public IEnumerable<ProcessSession> Lead_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("Lead_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Lead_ProcessSessions");
                SetRelatedEntities("Lead_ProcessSessions", null, value);
                OnPropertyChanged("Lead_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N Lead_RecurringAppointmentMasters
        /// </summary>
        [RelationshipSchemaName("Lead_RecurringAppointmentMasters")]
        public IEnumerable<RecurringAppointmentMaster> Lead_RecurringAppointmentMasters
        {
            get { return GetRelatedEntities<RecurringAppointmentMaster>("Lead_RecurringAppointmentMasters", null); }
            set
            {
                OnPropertyChanging("Lead_RecurringAppointmentMasters");
                SetRelatedEntities("Lead_RecurringAppointmentMasters", null, value);
                OnPropertyChanged("Lead_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        ///     1:N Lead_ServiceAppointments
        /// </summary>
        [RelationshipSchemaName("Lead_ServiceAppointments")]
        public IEnumerable<ServiceAppointment> Lead_ServiceAppointments
        {
            get { return GetRelatedEntities<ServiceAppointment>("Lead_ServiceAppointments", null); }
            set
            {
                OnPropertyChanging("Lead_ServiceAppointments");
                SetRelatedEntities("Lead_ServiceAppointments", null, value);
                OnPropertyChanged("Lead_ServiceAppointments");
            }
        }

        /// <summary>
        ///     1:N Lead_SharepointDocumentLocation
        /// </summary>
        [RelationshipSchemaName("Lead_SharepointDocumentLocation")]
        public IEnumerable<SharePointDocumentLocation> Lead_SharepointDocumentLocation
        {
            get { return GetRelatedEntities<SharePointDocumentLocation>("Lead_SharepointDocumentLocation", null); }
            set
            {
                OnPropertyChanging("Lead_SharepointDocumentLocation");
                SetRelatedEntities("Lead_SharepointDocumentLocation", null, value);
                OnPropertyChanged("Lead_SharepointDocumentLocation");
            }
        }

        /// <summary>
        ///     1:N Lead_Tasks
        /// </summary>
        [RelationshipSchemaName("Lead_Tasks")]
        public IEnumerable<Task> Lead_Tasks
        {
            get { return GetRelatedEntities<Task>("Lead_Tasks", null); }
            set
            {
                OnPropertyChanging("Lead_Tasks");
                SetRelatedEntities("Lead_Tasks", null, value);
                OnPropertyChanged("Lead_Tasks");
            }
        }

        /// <summary>
        ///     1:N opportunity_originating_lead
        /// </summary>
        [RelationshipSchemaName("opportunity_originating_lead")]
        public IEnumerable<Opportunity> opportunity_originating_lead
        {
            get { return GetRelatedEntities<Opportunity>("opportunity_originating_lead", null); }
            set
            {
                OnPropertyChanging("opportunity_originating_lead");
                SetRelatedEntities("opportunity_originating_lead", null, value);
                OnPropertyChanged("opportunity_originating_lead");
            }
        }

        /// <summary>
        ///     1:N SourceLead_BulkOperationLogs
        /// </summary>
        [RelationshipSchemaName("SourceLead_BulkOperationLogs")]
        public IEnumerable<BulkOperationLog> SourceLead_BulkOperationLogs
        {
            get { return GetRelatedEntities<BulkOperationLog>("SourceLead_BulkOperationLogs", null); }
            set
            {
                OnPropertyChanging("SourceLead_BulkOperationLogs");
                SetRelatedEntities("SourceLead_BulkOperationLogs", null, value);
                OnPropertyChanged("SourceLead_BulkOperationLogs");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_lead
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_lead")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_lead
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_lead", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_lead");
                SetRelatedEntities("userentityinstancedata_lead", null, value);
                OnPropertyChanged("userentityinstancedata_lead");
            }
        }

        /// <summary>
        ///     N:N accountleads_association
        /// </summary>
        [RelationshipSchemaName("accountleads_association")]
        public IEnumerable<Account> accountleads_association
        {
            get { return GetRelatedEntities<Account>("accountleads_association", null); }
            set
            {
                OnPropertyChanging("accountleads_association");
                SetRelatedEntities("accountleads_association", null, value);
                OnPropertyChanged("accountleads_association");
            }
        }

        /// <summary>
        ///     N:N contactleads_association
        /// </summary>
        [RelationshipSchemaName("contactleads_association")]
        public IEnumerable<Contact> contactleads_association
        {
            get { return GetRelatedEntities<Contact>("contactleads_association", null); }
            set
            {
                OnPropertyChanging("contactleads_association");
                SetRelatedEntities("contactleads_association", null, value);
                OnPropertyChanged("contactleads_association");
            }
        }

        /// <summary>
        ///     N:N leadcompetitors_association
        /// </summary>
        [RelationshipSchemaName("leadcompetitors_association")]
        public IEnumerable<Competitor> leadcompetitors_association
        {
            get { return GetRelatedEntities<Competitor>("leadcompetitors_association", null); }
            set
            {
                OnPropertyChanging("leadcompetitors_association");
                SetRelatedEntities("leadcompetitors_association", null, value);
                OnPropertyChanged("leadcompetitors_association");
            }
        }

        /// <summary>
        ///     N:N leadproduct_association
        /// </summary>
        [RelationshipSchemaName("leadproduct_association")]
        public IEnumerable<Product> leadproduct_association
        {
            get { return GetRelatedEntities<Product>("leadproduct_association", null); }
            set
            {
                OnPropertyChanging("leadproduct_association");
                SetRelatedEntities("leadproduct_association", null, value);
                OnPropertyChanged("leadproduct_association");
            }
        }

        /// <summary>
        ///     N:N listlead_association
        /// </summary>
        [RelationshipSchemaName("listlead_association")]
        public IEnumerable<List> listlead_association
        {
            get { return GetRelatedEntities<List>("listlead_association", null); }
            set
            {
                OnPropertyChanging("listlead_association");
                SetRelatedEntities("listlead_association", null, value);
                OnPropertyChanged("listlead_association");
            }
        }

        /// <summary>
        ///     N:1 business_unit_leads
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_leads")]
        public BusinessUnit business_unit_leads
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_leads", null); }
        }

        /// <summary>
        ///     N:1 campaign_leads
        /// </summary>
        [AttributeLogicalName("campaignid")]
        [RelationshipSchemaName("campaign_leads")]
        public Campaign campaign_leads
        {
            get { return GetRelatedEntity<Campaign>("campaign_leads", null); }
            set
            {
                OnPropertyChanging("campaign_leads");
                SetRelatedEntity("campaign_leads", null, value);
                OnPropertyChanged("campaign_leads");
            }
        }

        /// <summary>
        ///     N:1 CampaignResponse_Lead
        /// </summary>
        [AttributeLogicalName("relatedobjectid")]
        [RelationshipSchemaName("CampaignResponse_Lead")]
        public CampaignResponse CampaignResponse_Lead
        {
            get { return GetRelatedEntity<CampaignResponse>("CampaignResponse_Lead", null); }
            set
            {
                OnPropertyChanging("CampaignResponse_Lead");
                SetRelatedEntity("CampaignResponse_Lead", null, value);
                OnPropertyChanged("CampaignResponse_Lead");
            }
        }

        /// <summary>
        ///     N:1 lead_customer_accounts
        /// </summary>
        [AttributeLogicalName("customerid")]
        [RelationshipSchemaName("lead_customer_accounts")]
        public Account lead_customer_accounts
        {
            get { return GetRelatedEntity<Account>("lead_customer_accounts", null); }
            set
            {
                OnPropertyChanging("lead_customer_accounts");
                SetRelatedEntity("lead_customer_accounts", null, value);
                OnPropertyChanged("lead_customer_accounts");
            }
        }

        /// <summary>
        ///     N:1 lead_customer_contacts
        /// </summary>
        [AttributeLogicalName("customerid")]
        [RelationshipSchemaName("lead_customer_contacts")]
        public Contact lead_customer_contacts
        {
            get { return GetRelatedEntity<Contact>("lead_customer_contacts", null); }
            set
            {
                OnPropertyChanging("lead_customer_contacts");
                SetRelatedEntity("lead_customer_contacts", null, value);
                OnPropertyChanged("lead_customer_contacts");
            }
        }

        /// <summary>
        ///     N:1 lead_master_lead
        /// </summary>
        [AttributeLogicalName("masterid")]
        [RelationshipSchemaName("lead_master_lead", EntityRole.Referencing)]
        public Lead Referencinglead_master_lead
        {
            get { return GetRelatedEntity<Lead>("lead_master_lead", EntityRole.Referencing); }
        }

        /// <summary>
        ///     N:1 lead_owning_team
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("lead_owning_team")]
        public Team lead_owning_team
        {
            get { return GetRelatedEntity<Team>("lead_owning_team", null); }
        }

        /// <summary>
        ///     N:1 lead_owning_user
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("lead_owning_user")]
        public SystemUser lead_owning_user
        {
            get { return GetRelatedEntity<SystemUser>("lead_owning_user", null); }
        }

        /// <summary>
        ///     N:1 lead_parent_account
        /// </summary>
        [AttributeLogicalName("parentaccountid")]
        [RelationshipSchemaName("lead_parent_account")]
        public Account lead_parent_account
        {
            get { return GetRelatedEntity<Account>("lead_parent_account", null); }
            set
            {
                OnPropertyChanging("lead_parent_account");
                SetRelatedEntity("lead_parent_account", null, value);
                OnPropertyChanged("lead_parent_account");
            }
        }

        /// <summary>
        ///     N:1 lead_parent_contact
        /// </summary>
        [AttributeLogicalName("parentcontactid")]
        [RelationshipSchemaName("lead_parent_contact")]
        public Contact lead_parent_contact
        {
            get { return GetRelatedEntity<Contact>("lead_parent_contact", null); }
            set
            {
                OnPropertyChanging("lead_parent_contact");
                SetRelatedEntity("lead_parent_contact", null, value);
                OnPropertyChanged("lead_parent_contact");
            }
        }

        /// <summary>
        ///     N:1 lead_qualifying_opportunity
        /// </summary>
        [AttributeLogicalName("qualifyingopportunityid")]
        [RelationshipSchemaName("lead_qualifying_opportunity")]
        public Opportunity lead_qualifying_opportunity
        {
            get { return GetRelatedEntity<Opportunity>("lead_qualifying_opportunity", null); }
            set
            {
                OnPropertyChanging("lead_qualifying_opportunity");
                SetRelatedEntity("lead_qualifying_opportunity", null, value);
                OnPropertyChanged("lead_qualifying_opportunity");
            }
        }

        /// <summary>
        ///     N:1 lk_lead_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_lead_createdonbehalfby")]
        public SystemUser lk_lead_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_lead_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_lead_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_lead_modifiedonbehalfby")]
        public SystemUser lk_lead_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_lead_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_leadbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_leadbase_createdby")]
        public SystemUser lk_leadbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_leadbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_leadbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_leadbase_modifiedby")]
        public SystemUser lk_leadbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_leadbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 OriginatingCase_Lead
        /// </summary>
        [AttributeLogicalName("originatingcaseid")]
        [RelationshipSchemaName("OriginatingCase_Lead")]
        public Incident OriginatingCase_Lead
        {
            get { return GetRelatedEntity<Incident>("OriginatingCase_Lead", null); }
            set
            {
                OnPropertyChanging("OriginatingCase_Lead");
                SetRelatedEntity("OriginatingCase_Lead", null, value);
                OnPropertyChanged("OriginatingCase_Lead");
            }
        }

        /// <summary>
        ///     N:1 processstage_lead
        /// </summary>
        [AttributeLogicalName("stageid")]
        [RelationshipSchemaName("processstage_lead")]
        public ProcessStage processstage_lead
        {
            get { return GetRelatedEntity<ProcessStage>("processstage_lead", null); }
            set
            {
                OnPropertyChanging("processstage_lead");
                SetRelatedEntity("processstage_lead", null, value);
                OnPropertyChanged("processstage_lead");
            }
        }

        /// <summary>
        ///     N:1 transactioncurrency_lead
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("transactioncurrency_lead")]
        public TransactionCurrency transactioncurrency_lead
        {
            get { return GetRelatedEntity<TransactionCurrency>("transactioncurrency_lead", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_lead");
                SetRelatedEntity("transactioncurrency_lead", null, value);
                OnPropertyChanged("transactioncurrency_lead");
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