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
    ///     Top level of the Microsoft Dynamics CRM business hierarchy. The organization can be a specific business, holding
    ///     company, or corporation.
    /// </summary>
    [DataContract]
    [EntityLogicalName("organization")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Organization : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "organization";

        public const int EntityTypeCode = 1019;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Organization() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the template to be used for acknowledgement when a user unsubscribes.
        /// </summary>
        [AttributeLogicalName("acknowledgementtemplateid")]
        public EntityReference AcknowledgementTemplateId
        {
            get { return GetAttributeValue<EntityReference>("acknowledgementtemplateid"); }
            set
            {
                OnPropertyChanging("AcknowledgementTemplateId");
                SetAttributeValue("acknowledgementtemplateid", value);
                OnPropertyChanged("AcknowledgementTemplateId");
            }
        }

        /// <summary>
        ///     Indicates whether background address book synchronization in Microsoft Office Outlook is allowed.
        /// </summary>
        [AttributeLogicalName("allowaddressbooksyncs")]
        public bool? AllowAddressBookSyncs
        {
            get { return GetAttributeValue<bool?>("allowaddressbooksyncs"); }
            set
            {
                OnPropertyChanging("AllowAddressBookSyncs");
                SetAttributeValue("allowaddressbooksyncs", value);
                OnPropertyChanged("AllowAddressBookSyncs");
            }
        }

        /// <summary>
        ///     Indicates whether automatic response creation is allowed.
        /// </summary>
        [AttributeLogicalName("allowautoresponsecreation")]
        public bool? AllowAutoResponseCreation
        {
            get { return GetAttributeValue<bool?>("allowautoresponsecreation"); }
            set
            {
                OnPropertyChanging("AllowAutoResponseCreation");
                SetAttributeValue("allowautoresponsecreation", value);
                OnPropertyChanged("AllowAutoResponseCreation");
            }
        }

        /// <summary>
        ///     Indicates whether automatic unsubscribe is allowed.
        /// </summary>
        [AttributeLogicalName("allowautounsubscribe")]
        public bool? AllowAutoUnsubscribe
        {
            get { return GetAttributeValue<bool?>("allowautounsubscribe"); }
            set
            {
                OnPropertyChanging("AllowAutoUnsubscribe");
                SetAttributeValue("allowautounsubscribe", value);
                OnPropertyChanged("AllowAutoUnsubscribe");
            }
        }

        /// <summary>
        ///     Indicates whether automatic unsubscribe acknowledgement email is allowed to send.
        /// </summary>
        [AttributeLogicalName("allowautounsubscribeacknowledgement")]
        public bool? AllowAutoUnsubscribeAcknowledgement
        {
            get { return GetAttributeValue<bool?>("allowautounsubscribeacknowledgement"); }
            set
            {
                OnPropertyChanging("AllowAutoUnsubscribeAcknowledgement");
                SetAttributeValue("allowautounsubscribeacknowledgement", value);
                OnPropertyChanged("AllowAutoUnsubscribeAcknowledgement");
            }
        }

        /// <summary>
        ///     Indicates whether Outlook Client message bar advertisement is allowed.
        /// </summary>
        [AttributeLogicalName("allowclientmessagebarad")]
        public bool? AllowClientMessageBarAd
        {
            get { return GetAttributeValue<bool?>("allowclientmessagebarad"); }
            set
            {
                OnPropertyChanging("AllowClientMessageBarAd");
                SetAttributeValue("allowclientmessagebarad", value);
                OnPropertyChanged("AllowClientMessageBarAd");
            }
        }

        /// <summary>
        ///     Indicates whether auditing of changes to entity is allowed when no attributes have changed.
        /// </summary>
        [AttributeLogicalName("allowentityonlyaudit")]
        public bool? AllowEntityOnlyAudit
        {
            get { return GetAttributeValue<bool?>("allowentityonlyaudit"); }
            set
            {
                OnPropertyChanging("AllowEntityOnlyAudit");
                SetAttributeValue("allowentityonlyaudit", value);
                OnPropertyChanged("AllowEntityOnlyAudit");
            }
        }

        /// <summary>
        ///     Indicates whether marketing emails execution is allowed.
        /// </summary>
        [AttributeLogicalName("allowmarketingemailexecution")]
        public bool? AllowMarketingEmailExecution
        {
            get { return GetAttributeValue<bool?>("allowmarketingemailexecution"); }
            set
            {
                OnPropertyChanging("AllowMarketingEmailExecution");
                SetAttributeValue("allowmarketingemailexecution", value);
                OnPropertyChanged("AllowMarketingEmailExecution");
            }
        }

        /// <summary>
        ///     Indicates whether background offline synchronization in Microsoft Office Outlook is allowed.
        /// </summary>
        [AttributeLogicalName("allowofflinescheduledsyncs")]
        public bool? AllowOfflineScheduledSyncs
        {
            get { return GetAttributeValue<bool?>("allowofflinescheduledsyncs"); }
            set
            {
                OnPropertyChanging("AllowOfflineScheduledSyncs");
                SetAttributeValue("allowofflinescheduledsyncs", value);
                OnPropertyChanged("AllowOfflineScheduledSyncs");
            }
        }

        /// <summary>
        ///     Indicates whether scheduled synchronizations to Outlook are allowed.
        /// </summary>
        [AttributeLogicalName("allowoutlookscheduledsyncs")]
        public bool? AllowOutlookScheduledSyncs
        {
            get { return GetAttributeValue<bool?>("allowoutlookscheduledsyncs"); }
            set
            {
                OnPropertyChanging("AllowOutlookScheduledSyncs");
                SetAttributeValue("allowoutlookscheduledsyncs", value);
                OnPropertyChanged("AllowOutlookScheduledSyncs");
            }
        }

        /// <summary>
        ///     Indicates whether users are allowed to send email to unresolved parties (parties must still have an email address).
        /// </summary>
        [AttributeLogicalName("allowunresolvedpartiesonemailsend")]
        public bool? AllowUnresolvedPartiesOnEmailSend
        {
            get { return GetAttributeValue<bool?>("allowunresolvedpartiesonemailsend"); }
            set
            {
                OnPropertyChanging("AllowUnresolvedPartiesOnEmailSend");
                SetAttributeValue("allowunresolvedpartiesonemailsend", value);
                OnPropertyChanged("AllowUnresolvedPartiesOnEmailSend");
            }
        }

        /// <summary>
        ///     Indicates whether individuals can select their form mode preference in their personal options.
        /// </summary>
        [AttributeLogicalName("allowuserformmodepreference")]
        public bool? AllowUserFormModePreference
        {
            get { return GetAttributeValue<bool?>("allowuserformmodepreference"); }
            set
            {
                OnPropertyChanging("AllowUserFormModePreference");
                SetAttributeValue("allowuserformmodepreference", value);
                OnPropertyChanged("AllowUserFormModePreference");
            }
        }

        /// <summary>
        ///     Indicates whether the showing tablet application notification bars in a browser is allowed.
        /// </summary>
        [AttributeLogicalName("allowusersseeappdownloadmessage")]
        public bool? AllowUsersSeeAppdownloadMessage
        {
            get { return GetAttributeValue<bool?>("allowusersseeappdownloadmessage"); }
            set
            {
                OnPropertyChanging("AllowUsersSeeAppdownloadMessage");
                SetAttributeValue("allowusersseeappdownloadmessage", value);
                OnPropertyChanged("AllowUsersSeeAppdownloadMessage");
            }
        }

        /// <summary>
        ///     Indicates whether Web-based export of grids to Microsoft Office Excel is allowed.
        /// </summary>
        [AttributeLogicalName("allowwebexcelexport")]
        public bool? AllowWebExcelExport
        {
            get { return GetAttributeValue<bool?>("allowwebexcelexport"); }
            set
            {
                OnPropertyChanging("AllowWebExcelExport");
                SetAttributeValue("allowwebexcelexport", value);
                OnPropertyChanged("AllowWebExcelExport");
            }
        }

        /// <summary>
        ///     AM designator to use throughout Microsoft Dynamics CRM.
        /// </summary>
        [AttributeLogicalName("amdesignator")]
        public string AMDesignator
        {
            get { return GetAttributeValue<string>("amdesignator"); }
            set
            {
                OnPropertyChanging("AMDesignator");
                SetAttributeValue("amdesignator", value);
                OnPropertyChanged("AMDesignator");
            }
        }

        /// <summary>
        ///     Unique identifier of the base currency of the organization.
        /// </summary>
        [AttributeLogicalName("basecurrencyid")]
        public EntityReference BaseCurrencyId
        {
            get { return GetAttributeValue<EntityReference>("basecurrencyid"); }
            set
            {
                OnPropertyChanging("BaseCurrencyId");
                SetAttributeValue("basecurrencyid", value);
                OnPropertyChanged("BaseCurrencyId");
            }
        }

        /// <summary>
        ///     Number of decimal places that can be used for the base currency.
        /// </summary>
        [AttributeLogicalName("basecurrencyprecision")]
        public int? BaseCurrencyPrecision
        {
            get { return GetAttributeValue<int?>("basecurrencyprecision"); }
        }

        /// <summary>
        ///     Symbol used for the base currency.
        /// </summary>
        [AttributeLogicalName("basecurrencysymbol")]
        public string BaseCurrencySymbol
        {
            get { return GetAttributeValue<string>("basecurrencysymbol"); }
        }

        /// <summary>
        ///     Api Key to be used in requests to Bing Maps services.
        /// </summary>
        [AttributeLogicalName("bingmapsapikey")]
        public string BingMapsApiKey
        {
            get { return GetAttributeValue<string>("bingmapsapikey"); }
            set
            {
                OnPropertyChanging("BingMapsApiKey");
                SetAttributeValue("bingmapsapikey", value);
                OnPropertyChanged("BingMapsApiKey");
            }
        }

        /// <summary>
        ///     Prevent upload or download of certain attachment types that are considered dangerous.
        /// </summary>
        [AttributeLogicalName("blockedattachments")]
        public string BlockedAttachments
        {
            get { return GetAttributeValue<string>("blockedattachments"); }
            set
            {
                OnPropertyChanging("BlockedAttachments");
                SetAttributeValue("blockedattachments", value);
                OnPropertyChanged("BlockedAttachments");
            }
        }

        /// <summary>
        ///     Prefix used for bulk operation numbering.
        /// </summary>
        [AttributeLogicalName("bulkoperationprefix")]
        public string BulkOperationPrefix
        {
            get { return GetAttributeValue<string>("bulkoperationprefix"); }
            set
            {
                OnPropertyChanging("BulkOperationPrefix");
                SetAttributeValue("bulkoperationprefix", value);
                OnPropertyChanged("BulkOperationPrefix");
            }
        }

        /// <summary>
        ///     Unique identifier of the business closure calendar of organization.
        /// </summary>
        [AttributeLogicalName("businessclosurecalendarid")]
        public Guid? BusinessClosureCalendarId
        {
            get { return GetAttributeValue<Guid?>("businessclosurecalendarid"); }
            set
            {
                OnPropertyChanging("BusinessClosureCalendarId");
                SetAttributeValue("businessclosurecalendarid", value);
                OnPropertyChanged("BusinessClosureCalendarId");
            }
        }

        /// <summary>
        ///     Calendar type for the system. Set to Gregorian US by default.
        /// </summary>
        [AttributeLogicalName("calendartype")]
        public int? CalendarType
        {
            get { return GetAttributeValue<int?>("calendartype"); }
            set
            {
                OnPropertyChanging("CalendarType");
                SetAttributeValue("calendartype", value);
                OnPropertyChanged("CalendarType");
            }
        }

        /// <summary>
        ///     Prefix used for campaign numbering.
        /// </summary>
        [AttributeLogicalName("campaignprefix")]
        public string CampaignPrefix
        {
            get { return GetAttributeValue<string>("campaignprefix"); }
            set
            {
                OnPropertyChanging("CampaignPrefix");
                SetAttributeValue("campaignprefix", value);
                OnPropertyChanged("CampaignPrefix");
            }
        }

        /// <summary>
        ///     Prefix to use for all cases throughout Microsoft Dynamics CRM.
        /// </summary>
        [AttributeLogicalName("caseprefix")]
        public string CasePrefix
        {
            get { return GetAttributeValue<string>("caseprefix"); }
            set
            {
                OnPropertyChanging("CasePrefix");
                SetAttributeValue("caseprefix", value);
                OnPropertyChanged("CasePrefix");
            }
        }

        /// <summary>
        ///     Prefix to use for all contracts throughout Microsoft Dynamics CRM.
        /// </summary>
        [AttributeLogicalName("contractprefix")]
        public string ContractPrefix
        {
            get { return GetAttributeValue<string>("contractprefix"); }
            set
            {
                OnPropertyChanging("ContractPrefix");
                SetAttributeValue("contractprefix", value);
                OnPropertyChanged("ContractPrefix");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the organization.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the organization was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the organization.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Number of decimal places that can be used for currency.
        /// </summary>
        [AttributeLogicalName("currencydecimalprecision")]
        public int? CurrencyDecimalPrecision
        {
            get { return GetAttributeValue<int?>("currencydecimalprecision"); }
            set
            {
                OnPropertyChanging("CurrencyDecimalPrecision");
                SetAttributeValue("currencydecimalprecision", value);
                OnPropertyChanged("CurrencyDecimalPrecision");
            }
        }

        /// <summary>
        ///     Indicates whether to display money fields with currency code or currency symbol.
        /// </summary>
        [AttributeLogicalName("currencydisplayoption")]
        public OptionSetValue CurrencyDisplayOption
        {
            get { return GetAttributeValue<OptionSetValue>("currencydisplayoption"); }
            set
            {
                OnPropertyChanging("CurrencyDisplayOption");
                SetAttributeValue("currencydisplayoption", value);
                OnPropertyChanged("CurrencyDisplayOption");
            }
        }

        /// <summary>
        ///     Information about how currency symbols are placed throughout Microsoft Dynamics CRM.
        /// </summary>
        [AttributeLogicalName("currencyformatcode")]
        public OptionSetValue CurrencyFormatCode
        {
            get { return GetAttributeValue<OptionSetValue>("currencyformatcode"); }
            set
            {
                OnPropertyChanging("CurrencyFormatCode");
                SetAttributeValue("currencyformatcode", value);
                OnPropertyChanged("CurrencyFormatCode");
            }
        }

        /// <summary>
        ///     Symbol used for currency throughout Microsoft Dynamics CRM.
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
        ///     Current bulk operation number.
        /// </summary>
        [AttributeLogicalName("currentbulkoperationnumber")]
        public int? CurrentBulkOperationNumber
        {
            get { return GetAttributeValue<int?>("currentbulkoperationnumber"); }
            set
            {
                OnPropertyChanging("CurrentBulkOperationNumber");
                SetAttributeValue("currentbulkoperationnumber", value);
                OnPropertyChanged("CurrentBulkOperationNumber");
            }
        }

        /// <summary>
        ///     Current campaign number.
        /// </summary>
        [AttributeLogicalName("currentcampaignnumber")]
        public int? CurrentCampaignNumber
        {
            get { return GetAttributeValue<int?>("currentcampaignnumber"); }
            set
            {
                OnPropertyChanging("CurrentCampaignNumber");
                SetAttributeValue("currentcampaignnumber", value);
                OnPropertyChanged("CurrentCampaignNumber");
            }
        }

        /// <summary>
        ///     First case number to use.
        /// </summary>
        [AttributeLogicalName("currentcasenumber")]
        public int? CurrentCaseNumber
        {
            get { return GetAttributeValue<int?>("currentcasenumber"); }
            set
            {
                OnPropertyChanging("CurrentCaseNumber");
                SetAttributeValue("currentcasenumber", value);
                OnPropertyChanged("CurrentCaseNumber");
            }
        }

        /// <summary>
        ///     First contract number to use.
        /// </summary>
        [AttributeLogicalName("currentcontractnumber")]
        public int? CurrentContractNumber
        {
            get { return GetAttributeValue<int?>("currentcontractnumber"); }
            set
            {
                OnPropertyChanging("CurrentContractNumber");
                SetAttributeValue("currentcontractnumber", value);
                OnPropertyChanged("CurrentContractNumber");
            }
        }

        /// <summary>
        ///     Import sequence to use.
        /// </summary>
        [AttributeLogicalName("currentimportsequencenumber")]
        public int? CurrentImportSequenceNumber
        {
            get { return GetAttributeValue<int?>("currentimportsequencenumber"); }
        }

        /// <summary>
        ///     First invoice number to use.
        /// </summary>
        [AttributeLogicalName("currentinvoicenumber")]
        public int? CurrentInvoiceNumber
        {
            get { return GetAttributeValue<int?>("currentinvoicenumber"); }
            set
            {
                OnPropertyChanging("CurrentInvoiceNumber");
                SetAttributeValue("currentinvoicenumber", value);
                OnPropertyChanged("CurrentInvoiceNumber");
            }
        }

        /// <summary>
        ///     First article number to use.
        /// </summary>
        [AttributeLogicalName("currentkbnumber")]
        public int? CurrentKbNumber
        {
            get { return GetAttributeValue<int?>("currentkbnumber"); }
            set
            {
                OnPropertyChanging("CurrentKbNumber");
                SetAttributeValue("currentkbnumber", value);
                OnPropertyChanged("CurrentKbNumber");
            }
        }

        /// <summary>
        ///     First order number to use.
        /// </summary>
        [AttributeLogicalName("currentordernumber")]
        public int? CurrentOrderNumber
        {
            get { return GetAttributeValue<int?>("currentordernumber"); }
            set
            {
                OnPropertyChanging("CurrentOrderNumber");
                SetAttributeValue("currentordernumber", value);
                OnPropertyChanged("CurrentOrderNumber");
            }
        }

        /// <summary>
        ///     First parsed table number to use.
        /// </summary>
        [AttributeLogicalName("currentparsedtablenumber")]
        public int? CurrentParsedTableNumber
        {
            get { return GetAttributeValue<int?>("currentparsedtablenumber"); }
        }

        /// <summary>
        ///     First quote number to use.
        /// </summary>
        [AttributeLogicalName("currentquotenumber")]
        public int? CurrentQuoteNumber
        {
            get { return GetAttributeValue<int?>("currentquotenumber"); }
            set
            {
                OnPropertyChanging("CurrentQuoteNumber");
                SetAttributeValue("currentquotenumber", value);
                OnPropertyChanged("CurrentQuoteNumber");
            }
        }

        /// <summary>
        ///     Information about how the date is displayed throughout Microsoft CRM.
        /// </summary>
        [AttributeLogicalName("dateformatcode")]
        public OptionSetValue DateFormatCode
        {
            get { return GetAttributeValue<OptionSetValue>("dateformatcode"); }
            set
            {
                OnPropertyChanging("DateFormatCode");
                SetAttributeValue("dateformatcode", value);
                OnPropertyChanged("DateFormatCode");
            }
        }

        /// <summary>
        ///     String showing how the date is displayed throughout Microsoft CRM.
        /// </summary>
        [AttributeLogicalName("dateformatstring")]
        public string DateFormatString
        {
            get { return GetAttributeValue<string>("dateformatstring"); }
            set
            {
                OnPropertyChanging("DateFormatString");
                SetAttributeValue("dateformatstring", value);
                OnPropertyChanged("DateFormatString");
            }
        }

        /// <summary>
        ///     Character used to separate the month, the day, and the year in dates throughout Microsoft Dynamics CRM.
        /// </summary>
        [AttributeLogicalName("dateseparator")]
        public string DateSeparator
        {
            get { return GetAttributeValue<string>("dateseparator"); }
            set
            {
                OnPropertyChanging("DateSeparator");
                SetAttributeValue("dateseparator", value);
                OnPropertyChanged("DateSeparator");
            }
        }

        /// <summary>
        ///     Symbol used for decimal in Microsoft Dynamics CRM.
        /// </summary>
        [AttributeLogicalName("decimalsymbol")]
        public string DecimalSymbol
        {
            get { return GetAttributeValue<string>("decimalsymbol"); }
            set
            {
                OnPropertyChanging("DecimalSymbol");
                SetAttributeValue("decimalsymbol", value);
                OnPropertyChanged("DecimalSymbol");
            }
        }

        /// <summary>
        ///     Text area to enter default country code.
        /// </summary>
        [AttributeLogicalName("defaultcountrycode")]
        public string DefaultCountryCode
        {
            get { return GetAttributeValue<string>("defaultcountrycode"); }
            set
            {
                OnPropertyChanging("DefaultCountryCode");
                SetAttributeValue("defaultcountrycode", value);
                OnPropertyChanged("DefaultCountryCode");
            }
        }

        /// <summary>
        ///     Unique identifier of the default email server profile.
        /// </summary>
        [AttributeLogicalName("defaultemailserverprofileid")]
        public EntityReference DefaultEmailServerProfileId
        {
            get { return GetAttributeValue<EntityReference>("defaultemailserverprofileid"); }
            set
            {
                OnPropertyChanging("DefaultEmailServerProfileId");
                SetAttributeValue("defaultemailserverprofileid", value);
                OnPropertyChanged("DefaultEmailServerProfileId");
            }
        }

        /// <summary>
        ///     XML string containing the default email settings that are applied when a user or queue is created.
        /// </summary>
        [AttributeLogicalName("defaultemailsettings")]
        public string DefaultEmailSettings
        {
            get { return GetAttributeValue<string>("defaultemailsettings"); }
            set
            {
                OnPropertyChanging("DefaultEmailSettings");
                SetAttributeValue("defaultemailsettings", value);
                OnPropertyChanged("DefaultEmailSettings");
            }
        }

        /// <summary>
        ///     Type of default recurrence end range date.
        /// </summary>
        [AttributeLogicalName("defaultrecurrenceendrangetype")]
        public OptionSetValue DefaultRecurrenceEndRangeType
        {
            get { return GetAttributeValue<OptionSetValue>("defaultrecurrenceendrangetype"); }
            set
            {
                OnPropertyChanging("DefaultRecurrenceEndRangeType");
                SetAttributeValue("defaultrecurrenceendrangetype", value);
                OnPropertyChanged("DefaultRecurrenceEndRangeType");
            }
        }

        /// <summary>
        ///     Reason for disabling the organization.
        /// </summary>
        [AttributeLogicalName("disabledreason")]
        public string DisabledReason
        {
            get { return GetAttributeValue<string>("disabledreason"); }
        }

        /// <summary>
        ///     Select if you want to use the Email Router or server-side synchronization for email processing.
        /// </summary>
        [AttributeLogicalName("emailconnectionchannel")]
        public OptionSetValue EmailConnectionChannel
        {
            get { return GetAttributeValue<OptionSetValue>("emailconnectionchannel"); }
            set
            {
                OnPropertyChanging("EmailConnectionChannel");
                SetAttributeValue("emailconnectionchannel", value);
                OnPropertyChanged("EmailConnectionChannel");
            }
        }

        /// <summary>
        ///     Flag to turn email correlation on or off.
        /// </summary>
        [AttributeLogicalName("emailcorrelationenabled")]
        public bool? EmailCorrelationEnabled
        {
            get { return GetAttributeValue<bool?>("emailcorrelationenabled"); }
            set
            {
                OnPropertyChanging("EmailCorrelationEnabled");
                SetAttributeValue("emailcorrelationenabled", value);
                OnPropertyChanged("EmailCorrelationEnabled");
            }
        }

        /// <summary>
        ///     Normal polling frequency used for sending email in Microsoft Office Outlook.
        /// </summary>
        [AttributeLogicalName("emailsendpollingperiod")]
        public int? EmailSendPollingPeriod
        {
            get { return GetAttributeValue<int?>("emailsendpollingperiod"); }
            set
            {
                OnPropertyChanging("EmailSendPollingPeriod");
                SetAttributeValue("emailsendpollingperiod", value);
                OnPropertyChanged("EmailSendPollingPeriod");
            }
        }

        /// <summary>
        ///     Enable Integration with Bing Maps
        /// </summary>
        [AttributeLogicalName("enablebingmapsintegration")]
        public bool? EnableBingMapsIntegration
        {
            get { return GetAttributeValue<bool?>("enablebingmapsintegration"); }
            set
            {
                OnPropertyChanging("EnableBingMapsIntegration");
                SetAttributeValue("enablebingmapsintegration", value);
                OnPropertyChanged("EnableBingMapsIntegration");
            }
        }

        /// <summary>
        ///     Enable pricing calculations on a Create call.
        /// </summary>
        [AttributeLogicalName("enablepricingoncreate")]
        public bool? EnablePricingOnCreate
        {
            get { return GetAttributeValue<bool?>("enablepricingoncreate"); }
            set
            {
                OnPropertyChanging("EnablePricingOnCreate");
                SetAttributeValue("enablepricingoncreate", value);
                OnPropertyChanged("EnablePricingOnCreate");
            }
        }

        /// <summary>
        ///     Use Smart Matching.
        /// </summary>
        [AttributeLogicalName("enablesmartmatching")]
        public bool? EnableSmartMatching
        {
            get { return GetAttributeValue<bool?>("enablesmartmatching"); }
            set
            {
                OnPropertyChanging("EnableSmartMatching");
                SetAttributeValue("enablesmartmatching", value);
                OnPropertyChanged("EnableSmartMatching");
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
        ///     Maximum number of days before deleting inactive subscriptions.
        /// </summary>
        [AttributeLogicalName("expiresubscriptionsindays")]
        public int? ExpireSubscriptionsInDays
        {
            get { return GetAttributeValue<int?>("expiresubscriptionsindays"); }
            set
            {
                OnPropertyChanging("ExpireSubscriptionsInDays");
                SetAttributeValue("expiresubscriptionsindays", value);
                OnPropertyChanged("ExpireSubscriptionsInDays");
            }
        }

        /// <summary>
        ///     Features to be enabled as an XML BLOB.
        /// </summary>
        [AttributeLogicalName("featureset")]
        public string FeatureSet
        {
            get { return GetAttributeValue<string>("featureset"); }
            set
            {
                OnPropertyChanging("FeatureSet");
                SetAttributeValue("featureset", value);
                OnPropertyChanged("FeatureSet");
            }
        }

        /// <summary>
        ///     Start date for the fiscal period that is to be used throughout Microsoft CRM.
        /// </summary>
        [AttributeLogicalName("fiscalcalendarstart")]
        public DateTime? FiscalCalendarStart
        {
            get { return GetAttributeValue<DateTime?>("fiscalcalendarstart"); }
            set
            {
                OnPropertyChanging("FiscalCalendarStart");
                SetAttributeValue("fiscalcalendarstart", value);
                OnPropertyChanged("FiscalCalendarStart");
            }
        }

        /// <summary>
        ///     Information that specifies how the name of the fiscal period is displayed throughout Microsoft CRM.
        /// </summary>
        [AttributeLogicalName("fiscalperiodformat")]
        public string FiscalPeriodFormat
        {
            get { return GetAttributeValue<string>("fiscalperiodformat"); }
            set
            {
                OnPropertyChanging("FiscalPeriodFormat");
                SetAttributeValue("fiscalperiodformat", value);
                OnPropertyChanged("FiscalPeriodFormat");
            }
        }

        /// <summary>
        ///     Format in which the fiscal period will be displayed.
        /// </summary>
        [AttributeLogicalName("fiscalperiodformatperiod")]
        public OptionSetValue FiscalPeriodFormatPeriod
        {
            get { return GetAttributeValue<OptionSetValue>("fiscalperiodformatperiod"); }
            set
            {
                OnPropertyChanging("FiscalPeriodFormatPeriod");
                SetAttributeValue("fiscalperiodformatperiod", value);
                OnPropertyChanged("FiscalPeriodFormatPeriod");
            }
        }

        /// <summary>
        ///     Type of fiscal period used throughout Microsoft CRM.
        /// </summary>
        [AttributeLogicalName("fiscalperiodtype")]
        public int? FiscalPeriodType
        {
            get { return GetAttributeValue<int?>("fiscalperiodtype"); }
            set
            {
                OnPropertyChanging("FiscalPeriodType");
                SetAttributeValue("fiscalperiodtype", value);
                OnPropertyChanged("FiscalPeriodType");
            }
        }

        /// <summary>
        ///     Information that specifies whether the fiscal settings have been updated.
        /// </summary>
        [AttributeLogicalName("fiscalsettingsupdated")]
        [Obsolete]
        public bool? FiscalSettingsUpdated
        {
            get { return GetAttributeValue<bool?>("fiscalsettingsupdated"); }
        }

        /// <summary>
        ///     Information that specifies whether the fiscal year should be displayed based on the start date or the end date of
        ///     the fiscal year.
        /// </summary>
        [AttributeLogicalName("fiscalyeardisplaycode")]
        public int? FiscalYearDisplayCode
        {
            get { return GetAttributeValue<int?>("fiscalyeardisplaycode"); }
            set
            {
                OnPropertyChanging("FiscalYearDisplayCode");
                SetAttributeValue("fiscalyeardisplaycode", value);
                OnPropertyChanged("FiscalYearDisplayCode");
            }
        }

        /// <summary>
        ///     Information that specifies how the name of the fiscal year is displayed throughout Microsoft CRM.
        /// </summary>
        [AttributeLogicalName("fiscalyearformat")]
        public string FiscalYearFormat
        {
            get { return GetAttributeValue<string>("fiscalyearformat"); }
            set
            {
                OnPropertyChanging("FiscalYearFormat");
                SetAttributeValue("fiscalyearformat", value);
                OnPropertyChanged("FiscalYearFormat");
            }
        }

        /// <summary>
        ///     Prefix for the display of the fiscal year.
        /// </summary>
        [AttributeLogicalName("fiscalyearformatprefix")]
        public OptionSetValue FiscalYearFormatPrefix
        {
            get { return GetAttributeValue<OptionSetValue>("fiscalyearformatprefix"); }
            set
            {
                OnPropertyChanging("FiscalYearFormatPrefix");
                SetAttributeValue("fiscalyearformatprefix", value);
                OnPropertyChanged("FiscalYearFormatPrefix");
            }
        }

        /// <summary>
        ///     Suffix for the display of the fiscal year.
        /// </summary>
        [AttributeLogicalName("fiscalyearformatsuffix")]
        public OptionSetValue FiscalYearFormatSuffix
        {
            get { return GetAttributeValue<OptionSetValue>("fiscalyearformatsuffix"); }
            set
            {
                OnPropertyChanging("FiscalYearFormatSuffix");
                SetAttributeValue("fiscalyearformatsuffix", value);
                OnPropertyChanged("FiscalYearFormatSuffix");
            }
        }

        /// <summary>
        ///     Format for the year.
        /// </summary>
        [AttributeLogicalName("fiscalyearformatyear")]
        public OptionSetValue FiscalYearFormatYear
        {
            get { return GetAttributeValue<OptionSetValue>("fiscalyearformatyear"); }
            set
            {
                OnPropertyChanging("FiscalYearFormatYear");
                SetAttributeValue("fiscalyearformatyear", value);
                OnPropertyChanged("FiscalYearFormatYear");
            }
        }

        /// <summary>
        ///     Information that specifies how the names of the fiscal year and the fiscal period should be connected when
        ///     displayed together.
        /// </summary>
        [AttributeLogicalName("fiscalyearperiodconnect")]
        public string FiscalYearPeriodConnect
        {
            get { return GetAttributeValue<string>("fiscalyearperiodconnect"); }
            set
            {
                OnPropertyChanging("FiscalYearPeriodConnect");
                SetAttributeValue("fiscalyearperiodconnect", value);
                OnPropertyChanged("FiscalYearPeriodConnect");
            }
        }

        /// <summary>
        ///     Order in which names are to be displayed throughout Microsoft CRM.
        /// </summary>
        [AttributeLogicalName("fullnameconventioncode")]
        public OptionSetValue FullNameConventionCode
        {
            get { return GetAttributeValue<OptionSetValue>("fullnameconventioncode"); }
            set
            {
                OnPropertyChanging("FullNameConventionCode");
                SetAttributeValue("fullnameconventioncode", value);
                OnPropertyChanged("FullNameConventionCode");
            }
        }

        /// <summary>
        ///     Specifies the maximum number of months in future for which the recurring activities can be created.
        /// </summary>
        [AttributeLogicalName("futureexpansionwindow")]
        public int? FutureExpansionWindow
        {
            get { return GetAttributeValue<int?>("futureexpansionwindow"); }
            set
            {
                OnPropertyChanging("FutureExpansionWindow");
                SetAttributeValue("futureexpansionwindow", value);
                OnPropertyChanged("FutureExpansionWindow");
            }
        }

        /// <summary>
        ///     Indicates whether alerts will be generated for errors.
        /// </summary>
        [AttributeLogicalName("generatealertsforerrors")]
        public bool? GenerateAlertsForErrors
        {
            get { return GetAttributeValue<bool?>("generatealertsforerrors"); }
            set
            {
                OnPropertyChanging("GenerateAlertsForErrors");
                SetAttributeValue("generatealertsforerrors", value);
                OnPropertyChanged("GenerateAlertsForErrors");
            }
        }

        /// <summary>
        ///     Indicates whether alerts will be generated for information.
        /// </summary>
        [AttributeLogicalName("generatealertsforinformation")]
        public bool? GenerateAlertsForInformation
        {
            get { return GetAttributeValue<bool?>("generatealertsforinformation"); }
            set
            {
                OnPropertyChanging("GenerateAlertsForInformation");
                SetAttributeValue("generatealertsforinformation", value);
                OnPropertyChanged("GenerateAlertsForInformation");
            }
        }

        /// <summary>
        ///     Indicates whether alerts will be generated for warnings.
        /// </summary>
        [AttributeLogicalName("generatealertsforwarnings")]
        public bool? GenerateAlertsForWarnings
        {
            get { return GetAttributeValue<bool?>("generatealertsforwarnings"); }
            set
            {
                OnPropertyChanging("GenerateAlertsForWarnings");
                SetAttributeValue("generatealertsforwarnings", value);
                OnPropertyChanged("GenerateAlertsForWarnings");
            }
        }

        /// <summary>
        ///     Indicates whether Get Started content is enabled for this organization.
        /// </summary>
        [AttributeLogicalName("getstartedpanecontentenabled")]
        public bool? GetStartedPaneContentEnabled
        {
            get { return GetAttributeValue<bool?>("getstartedpanecontentenabled"); }
            set
            {
                OnPropertyChanging("GetStartedPaneContentEnabled");
                SetAttributeValue("getstartedpanecontentenabled", value);
                OnPropertyChanged("GetStartedPaneContentEnabled");
            }
        }

        /// <summary>
        ///     Number of days after the goal's end date after which the rollup of the goal stops automatically.
        /// </summary>
        [AttributeLogicalName("goalrollupexpirytime")]
        public int? GoalRollupExpiryTime
        {
            get { return GetAttributeValue<int?>("goalrollupexpirytime"); }
            set
            {
                OnPropertyChanging("GoalRollupExpiryTime");
                SetAttributeValue("goalrollupexpirytime", value);
                OnPropertyChanged("GoalRollupExpiryTime");
            }
        }

        /// <summary>
        ///     Number of hours between automatic rollup jobs .
        /// </summary>
        [AttributeLogicalName("goalrollupfrequency")]
        public int? GoalRollupFrequency
        {
            get { return GetAttributeValue<int?>("goalrollupfrequency"); }
            set
            {
                OnPropertyChanging("GoalRollupFrequency");
                SetAttributeValue("goalrollupfrequency", value);
                OnPropertyChanged("GoalRollupFrequency");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("grantaccesstonetworkservice")]
        public bool? GrantAccessToNetworkService
        {
            get { return GetAttributeValue<bool?>("grantaccesstonetworkservice"); }
            set
            {
                OnPropertyChanging("GrantAccessToNetworkService");
                SetAttributeValue("grantaccesstonetworkservice", value);
                OnPropertyChanged("GrantAccessToNetworkService");
            }
        }

        /// <summary>
        ///     Maximum difference allowed between subject keywords count of the email messaged to be correlated
        /// </summary>
        [AttributeLogicalName("hashdeltasubjectcount")]
        public int? HashDeltaSubjectCount
        {
            get { return GetAttributeValue<int?>("hashdeltasubjectcount"); }
            set
            {
                OnPropertyChanging("HashDeltaSubjectCount");
                SetAttributeValue("hashdeltasubjectcount", value);
                OnPropertyChanged("HashDeltaSubjectCount");
            }
        }

        /// <summary>
        ///     Filter Subject Keywords
        /// </summary>
        [AttributeLogicalName("hashfilterkeywords")]
        public string HashFilterKeywords
        {
            get { return GetAttributeValue<string>("hashfilterkeywords"); }
            set
            {
                OnPropertyChanging("HashFilterKeywords");
                SetAttributeValue("hashfilterkeywords", value);
                OnPropertyChanged("HashFilterKeywords");
            }
        }

        /// <summary>
        ///     Maximum number of subject keywords or recipients used for correlation
        /// </summary>
        [AttributeLogicalName("hashmaxcount")]
        public int? HashMaxCount
        {
            get { return GetAttributeValue<int?>("hashmaxcount"); }
            set
            {
                OnPropertyChanging("HashMaxCount");
                SetAttributeValue("hashmaxcount", value);
                OnPropertyChanged("HashMaxCount");
            }
        }

        /// <summary>
        ///     Minimum number of recipients required to match for email messaged to be correlated
        /// </summary>
        [AttributeLogicalName("hashminaddresscount")]
        public int? HashMinAddressCount
        {
            get { return GetAttributeValue<int?>("hashminaddresscount"); }
            set
            {
                OnPropertyChanging("HashMinAddressCount");
                SetAttributeValue("hashminaddresscount", value);
                OnPropertyChanged("HashMinAddressCount");
            }
        }

        /// <summary>
        ///     Indicates whether incoming email sent by internal Microsoft Dynamics CRM users or queues should be tracked.
        /// </summary>
        [AttributeLogicalName("ignoreinternalemail")]
        public bool? IgnoreInternalEmail
        {
            get { return GetAttributeValue<bool?>("ignoreinternalemail"); }
            set
            {
                OnPropertyChanging("IgnoreInternalEmail");
                SetAttributeValue("ignoreinternalemail", value);
                OnPropertyChanged("IgnoreInternalEmail");
            }
        }

        /// <summary>
        ///     Setting for the Async Service Mailbox Queue. Defines the retrieval batch size of exchange server.
        /// </summary>
        [AttributeLogicalName("incomingemailexchangeemailretrievalbatchsize")]
        public int? IncomingEmailExchangeEmailRetrievalBatchSize
        {
            get { return GetAttributeValue<int?>("incomingemailexchangeemailretrievalbatchsize"); }
            set
            {
                OnPropertyChanging("IncomingEmailExchangeEmailRetrievalBatchSize");
                SetAttributeValue("incomingemailexchangeemailretrievalbatchsize", value);
                OnPropertyChanged("IncomingEmailExchangeEmailRetrievalBatchSize");
            }
        }

        /// <summary>
        ///     Initial version of the organization.
        /// </summary>
        [AttributeLogicalName("initialversion")]
        public string InitialVersion
        {
            get { return GetAttributeValue<string>("initialversion"); }
            set
            {
                OnPropertyChanging("InitialVersion");
                SetAttributeValue("initialversion", value);
                OnPropertyChanged("InitialVersion");
            }
        }

        /// <summary>
        ///     Unique identifier of the integration user for the organization.
        /// </summary>
        [AttributeLogicalName("integrationuserid")]
        public Guid? IntegrationUserId
        {
            get { return GetAttributeValue<Guid?>("integrationuserid"); }
            set
            {
                OnPropertyChanging("IntegrationUserId");
                SetAttributeValue("integrationuserid", value);
                OnPropertyChanged("IntegrationUserId");
            }
        }

        /// <summary>
        ///     Prefix to use for all invoice numbers throughout Microsoft Dynamics CRM.
        /// </summary>
        [AttributeLogicalName("invoiceprefix")]
        public string InvoicePrefix
        {
            get { return GetAttributeValue<string>("invoiceprefix"); }
            set
            {
                OnPropertyChanging("InvoicePrefix");
                SetAttributeValue("invoiceprefix", value);
                OnPropertyChanged("InvoicePrefix");
            }
        }

        /// <summary>
        ///     Indicates whether loading of Microsoft Dynamics CRM in a browser window that does not have address, tool, and menu
        ///     bars is enabled.
        /// </summary>
        [AttributeLogicalName("isappmode")]
        public bool? IsAppMode
        {
            get { return GetAttributeValue<bool?>("isappmode"); }
            set
            {
                OnPropertyChanging("IsAppMode");
                SetAttributeValue("isappmode", value);
                OnPropertyChanged("IsAppMode");
            }
        }

        /// <summary>
        ///     Enable or disable auditing of changes.
        /// </summary>
        [AttributeLogicalName("isauditenabled")]
        public bool? IsAuditEnabled
        {
            get { return GetAttributeValue<bool?>("isauditenabled"); }
            set
            {
                OnPropertyChanging("IsAuditEnabled");
                SetAttributeValue("isauditenabled", value);
                OnPropertyChanged("IsAuditEnabled");
            }
        }

        /// <summary>
        ///     Information on whether auto save is enabled.
        /// </summary>
        [AttributeLogicalName("isautosaveenabled")]
        public bool? IsAutoSaveEnabled
        {
            get { return GetAttributeValue<bool?>("isautosaveenabled"); }
            set
            {
                OnPropertyChanging("IsAutoSaveEnabled");
                SetAttributeValue("isautosaveenabled", value);
                OnPropertyChanged("IsAutoSaveEnabled");
            }
        }

        /// <summary>
        ///     Enable or disable country code selection.
        /// </summary>
        [AttributeLogicalName("isdefaultcountrycodecheckenabled")]
        public bool? IsDefaultCountryCodeCheckEnabled
        {
            get { return GetAttributeValue<bool?>("isdefaultcountrycodecheckenabled"); }
            set
            {
                OnPropertyChanging("IsDefaultCountryCodeCheckEnabled");
                SetAttributeValue("isdefaultcountrycodecheckenabled", value);
                OnPropertyChanged("IsDefaultCountryCodeCheckEnabled");
            }
        }

        /// <summary>
        ///     Information that specifies whether the organization is disabled.
        /// </summary>
        [AttributeLogicalName("isdisabled")]
        public bool? IsDisabled
        {
            get { return GetAttributeValue<bool?>("isdisabled"); }
        }

        /// <summary>
        ///     Indicates whether duplicate detection of records is enabled.
        /// </summary>
        [AttributeLogicalName("isduplicatedetectionenabled")]
        public bool? IsDuplicateDetectionEnabled
        {
            get { return GetAttributeValue<bool?>("isduplicatedetectionenabled"); }
            set
            {
                OnPropertyChanging("IsDuplicateDetectionEnabled");
                SetAttributeValue("isduplicatedetectionenabled", value);
                OnPropertyChanged("IsDuplicateDetectionEnabled");
            }
        }

        /// <summary>
        ///     Indicates whether duplicate detection of records during import is enabled.
        /// </summary>
        [AttributeLogicalName("isduplicatedetectionenabledforimport")]
        public bool? IsDuplicateDetectionEnabledForImport
        {
            get { return GetAttributeValue<bool?>("isduplicatedetectionenabledforimport"); }
            set
            {
                OnPropertyChanging("IsDuplicateDetectionEnabledForImport");
                SetAttributeValue("isduplicatedetectionenabledforimport", value);
                OnPropertyChanged("IsDuplicateDetectionEnabledForImport");
            }
        }

        /// <summary>
        ///     Indicates whether duplicate detection of records during offline synchronization is enabled.
        /// </summary>
        [AttributeLogicalName("isduplicatedetectionenabledforofflinesync")]
        public bool? IsDuplicateDetectionEnabledForOfflineSync
        {
            get { return GetAttributeValue<bool?>("isduplicatedetectionenabledforofflinesync"); }
            set
            {
                OnPropertyChanging("IsDuplicateDetectionEnabledForOfflineSync");
                SetAttributeValue("isduplicatedetectionenabledforofflinesync", value);
                OnPropertyChanged("IsDuplicateDetectionEnabledForOfflineSync");
            }
        }

        /// <summary>
        ///     Indicates whether duplicate detection during online create or update is enabled.
        /// </summary>
        [AttributeLogicalName("isduplicatedetectionenabledforonlinecreateupdate")]
        public bool? IsDuplicateDetectionEnabledForOnlineCreateUpdate
        {
            get { return GetAttributeValue<bool?>("isduplicatedetectionenabledforonlinecreateupdate"); }
            set
            {
                OnPropertyChanging("IsDuplicateDetectionEnabledForOnlineCreateUpdate");
                SetAttributeValue("isduplicatedetectionenabledforonlinecreateupdate", value);
                OnPropertyChanged("IsDuplicateDetectionEnabledForOnlineCreateUpdate");
            }
        }

        /// <summary>
        ///     Indicates whether the fiscal period is displayed as the month number.
        /// </summary>
        [AttributeLogicalName("isfiscalperiodmonthbased")]
        public bool? IsFiscalPeriodMonthBased
        {
            get { return GetAttributeValue<bool?>("isfiscalperiodmonthbased"); }
            set
            {
                OnPropertyChanging("IsFiscalPeriodMonthBased");
                SetAttributeValue("isfiscalperiodmonthbased", value);
                OnPropertyChanged("IsFiscalPeriodMonthBased");
            }
        }

        /// <summary>
        ///     Information on whether IM presence is enabled.
        /// </summary>
        [AttributeLogicalName("ispresenceenabled")]
        public bool? IsPresenceEnabled
        {
            get { return GetAttributeValue<bool?>("ispresenceenabled"); }
            set
            {
                OnPropertyChanging("IsPresenceEnabled");
                SetAttributeValue("ispresenceenabled", value);
                OnPropertyChanged("IsPresenceEnabled");
            }
        }

        /// <summary>
        ///     Enable sales order processing integration.
        /// </summary>
        [AttributeLogicalName("issopintegrationenabled")]
        public bool? IsSOPIntegrationEnabled
        {
            get { return GetAttributeValue<bool?>("issopintegrationenabled"); }
            set
            {
                OnPropertyChanging("IsSOPIntegrationEnabled");
                SetAttributeValue("issopintegrationenabled", value);
                OnPropertyChanged("IsSOPIntegrationEnabled");
            }
        }

        /// <summary>
        ///     Enable or disable auditing of user access.
        /// </summary>
        [AttributeLogicalName("isuseraccessauditenabled")]
        public bool? IsUserAccessAuditEnabled
        {
            get { return GetAttributeValue<bool?>("isuseraccessauditenabled"); }
            set
            {
                OnPropertyChanging("IsUserAccessAuditEnabled");
                SetAttributeValue("isuseraccessauditenabled", value);
                OnPropertyChanged("IsUserAccessAuditEnabled");
            }
        }

        /// <summary>
        ///     Indicates whether loading of Microsoft Dynamics CRM in a browser window that does not have address, tool, and menu
        ///     bars is enabled.
        /// </summary>
        [AttributeLogicalName("isvintegrationcode")]
        [Obsolete]
        public OptionSetValue ISVIntegrationCode
        {
            get { return GetAttributeValue<OptionSetValue>("isvintegrationcode"); }
            set
            {
                OnPropertyChanging("ISVIntegrationCode");
                SetAttributeValue("isvintegrationcode", value);
                OnPropertyChanged("ISVIntegrationCode");
            }
        }

        /// <summary>
        ///     Prefix to use for all articles in Microsoft Dynamics CRM.
        /// </summary>
        [AttributeLogicalName("kbprefix")]
        public string KbPrefix
        {
            get { return GetAttributeValue<string>("kbprefix"); }
            set
            {
                OnPropertyChanging("KbPrefix");
                SetAttributeValue("kbprefix", value);
                OnPropertyChanged("KbPrefix");
            }
        }

        /// <summary>
        ///     Preferred language for the organization.
        /// </summary>
        [AttributeLogicalName("languagecode")]
        public int? LanguageCode
        {
            get { return GetAttributeValue<int?>("languagecode"); }
            set
            {
                OnPropertyChanging("LanguageCode");
                SetAttributeValue("languagecode", value);
                OnPropertyChanged("LanguageCode");
            }
        }

        /// <summary>
        ///     Unique identifier of the locale of the organization.
        /// </summary>
        [AttributeLogicalName("localeid")]
        public int? LocaleId
        {
            get { return GetAttributeValue<int?>("localeid"); }
            set
            {
                OnPropertyChanging("LocaleId");
                SetAttributeValue("localeid", value);
                OnPropertyChanged("LocaleId");
            }
        }

        /// <summary>
        ///     Information that specifies how the Long Date format is displayed in Microsoft Dynamics CRM.
        /// </summary>
        [AttributeLogicalName("longdateformatcode")]
        public int? LongDateFormatCode
        {
            get { return GetAttributeValue<int?>("longdateformatcode"); }
            set
            {
                OnPropertyChanging("LongDateFormatCode");
                SetAttributeValue("longdateformatcode", value);
                OnPropertyChanged("LongDateFormatCode");
            }
        }

        /// <summary>
        ///     Maximum number of days an appointment can last.
        /// </summary>
        [AttributeLogicalName("maxappointmentdurationdays")]
        public int? MaxAppointmentDurationDays
        {
            get { return GetAttributeValue<int?>("maxappointmentdurationdays"); }
            set
            {
                OnPropertyChanging("MaxAppointmentDurationDays");
                SetAttributeValue("maxappointmentdurationdays", value);
                OnPropertyChanged("MaxAppointmentDurationDays");
            }
        }

        /// <summary>
        ///     Maximum number of active business process flows allowed per entity
        /// </summary>
        [AttributeLogicalName("maximumactivebusinessprocessflowsallowedperentity")]
        public int? MaximumActiveBusinessProcessFlowsAllowedPerEntity
        {
            get { return GetAttributeValue<int?>("maximumactivebusinessprocessflowsallowedperentity"); }
            set
            {
                OnPropertyChanging("MaximumActiveBusinessProcessFlowsAllowedPerEntity");
                SetAttributeValue("maximumactivebusinessprocessflowsallowedperentity", value);
                OnPropertyChanged("MaximumActiveBusinessProcessFlowsAllowedPerEntity");
            }
        }

        /// <summary>
        ///     Maximum tracking number before recycling takes place.
        /// </summary>
        [AttributeLogicalName("maximumtrackingnumber")]
        public int? MaximumTrackingNumber
        {
            get { return GetAttributeValue<int?>("maximumtrackingnumber"); }
            set
            {
                OnPropertyChanging("MaximumTrackingNumber");
                SetAttributeValue("maximumtrackingnumber", value);
                OnPropertyChanged("MaximumTrackingNumber");
            }
        }

        /// <summary>
        ///     Maximum number of records that will be exported to a static Microsoft Office Excel worksheet when exporting from
        ///     the grid.
        /// </summary>
        [AttributeLogicalName("maxrecordsforexporttoexcel")]
        public int? MaxRecordsForExportToExcel
        {
            get { return GetAttributeValue<int?>("maxrecordsforexporttoexcel"); }
            set
            {
                OnPropertyChanging("MaxRecordsForExportToExcel");
                SetAttributeValue("maxrecordsforexporttoexcel", value);
                OnPropertyChanged("MaxRecordsForExportToExcel");
            }
        }

        /// <summary>
        ///     Maximum number of lookup and picklist records that can be selected by user for filtering.
        /// </summary>
        [AttributeLogicalName("maxrecordsforlookupfilters")]
        public int? MaxRecordsForLookupFilters
        {
            get { return GetAttributeValue<int?>("maxrecordsforlookupfilters"); }
            set
            {
                OnPropertyChanging("MaxRecordsForLookupFilters");
                SetAttributeValue("maxrecordsforlookupfilters", value);
                OnPropertyChanged("MaxRecordsForLookupFilters");
            }
        }

        /// <summary>
        ///     Maximum allowed size of an attachment.
        /// </summary>
        [AttributeLogicalName("maxuploadfilesize")]
        public int? MaxUploadFileSize
        {
            get { return GetAttributeValue<int?>("maxuploadfilesize"); }
            set
            {
                OnPropertyChanging("MaxUploadFileSize");
                SetAttributeValue("maxuploadfilesize", value);
                OnPropertyChanged("MaxUploadFileSize");
            }
        }

        /// <summary>
        ///     Normal polling frequency used for address book synchronization in Microsoft Office Outlook.
        /// </summary>
        [AttributeLogicalName("minaddressbooksyncinterval")]
        public int? MinAddressBookSyncInterval
        {
            get { return GetAttributeValue<int?>("minaddressbooksyncinterval"); }
            set
            {
                OnPropertyChanging("MinAddressBookSyncInterval");
                SetAttributeValue("minaddressbooksyncinterval", value);
                OnPropertyChanged("MinAddressBookSyncInterval");
            }
        }

        /// <summary>
        ///     Normal polling frequency used for background offline synchronization in Microsoft Office Outlook.
        /// </summary>
        [AttributeLogicalName("minofflinesyncinterval")]
        public int? MinOfflineSyncInterval
        {
            get { return GetAttributeValue<int?>("minofflinesyncinterval"); }
            set
            {
                OnPropertyChanging("MinOfflineSyncInterval");
                SetAttributeValue("minofflinesyncinterval", value);
                OnPropertyChanged("MinOfflineSyncInterval");
            }
        }

        /// <summary>
        ///     Minimum allowed time between scheduled Outlook synchronizations.
        /// </summary>
        [AttributeLogicalName("minoutlooksyncinterval")]
        public int? MinOutlookSyncInterval
        {
            get { return GetAttributeValue<int?>("minoutlooksyncinterval"); }
            set
            {
                OnPropertyChanging("MinOutlookSyncInterval");
                SetAttributeValue("minoutlooksyncinterval", value);
                OnPropertyChanged("MinOutlookSyncInterval");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the organization.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the organization was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the organization.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the organization. The name is set when Microsoft CRM is installed and should not be changed.
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
        ///     Information that specifies how negative currency numbers are displayed throughout Microsoft Dynamics CRM.
        /// </summary>
        [AttributeLogicalName("negativecurrencyformatcode")]
        public int? NegativeCurrencyFormatCode
        {
            get { return GetAttributeValue<int?>("negativecurrencyformatcode"); }
            set
            {
                OnPropertyChanging("NegativeCurrencyFormatCode");
                SetAttributeValue("negativecurrencyformatcode", value);
                OnPropertyChanged("NegativeCurrencyFormatCode");
            }
        }

        /// <summary>
        ///     Information that specifies how negative numbers are displayed throughout Microsoft CRM.
        /// </summary>
        [AttributeLogicalName("negativeformatcode")]
        public OptionSetValue NegativeFormatCode
        {
            get { return GetAttributeValue<OptionSetValue>("negativeformatcode"); }
            set
            {
                OnPropertyChanging("NegativeFormatCode");
                SetAttributeValue("negativeformatcode", value);
                OnPropertyChanged("NegativeFormatCode");
            }
        }

        /// <summary>
        ///     Next token to be placed on the subject line of an email message.
        /// </summary>
        [AttributeLogicalName("nexttrackingnumber")]
        public int? NextTrackingNumber
        {
            get { return GetAttributeValue<int?>("nexttrackingnumber"); }
            set
            {
                OnPropertyChanging("NextTrackingNumber");
                SetAttributeValue("nexttrackingnumber", value);
                OnPropertyChanged("NextTrackingNumber");
            }
        }

        /// <summary>
        ///     Indicates whether mailbox owners will be notified of email server profile level alerts.
        /// </summary>
        [AttributeLogicalName("notifymailboxownerofemailserverlevelalerts")]
        public bool? NotifyMailboxOwnerOfEmailServerLevelAlerts
        {
            get { return GetAttributeValue<bool?>("notifymailboxownerofemailserverlevelalerts"); }
            set
            {
                OnPropertyChanging("NotifyMailboxOwnerOfEmailServerLevelAlerts");
                SetAttributeValue("notifymailboxownerofemailserverlevelalerts", value);
                OnPropertyChanged("NotifyMailboxOwnerOfEmailServerLevelAlerts");
            }
        }

        /// <summary>
        ///     Specification of how numbers are displayed throughout Microsoft CRM.
        /// </summary>
        [AttributeLogicalName("numberformat")]
        public string NumberFormat
        {
            get { return GetAttributeValue<string>("numberformat"); }
            set
            {
                OnPropertyChanging("NumberFormat");
                SetAttributeValue("numberformat", value);
                OnPropertyChanged("NumberFormat");
            }
        }

        /// <summary>
        ///     Specifies how numbers are grouped in Microsoft Dynamics CRM.
        /// </summary>
        [AttributeLogicalName("numbergroupformat")]
        public string NumberGroupFormat
        {
            get { return GetAttributeValue<string>("numbergroupformat"); }
            set
            {
                OnPropertyChanging("NumberGroupFormat");
                SetAttributeValue("numbergroupformat", value);
                OnPropertyChanged("NumberGroupFormat");
            }
        }

        /// <summary>
        ///     Symbol used for number separation in Microsoft Dynamics CRM.
        /// </summary>
        [AttributeLogicalName("numberseparator")]
        public string NumberSeparator
        {
            get { return GetAttributeValue<string>("numberseparator"); }
            set
            {
                OnPropertyChanging("NumberSeparator");
                SetAttributeValue("numberseparator", value);
                OnPropertyChanged("NumberSeparator");
            }
        }

        /// <summary>
        ///     Prefix to use for all orders throughout Microsoft Dynamics CRM.
        /// </summary>
        [AttributeLogicalName("orderprefix")]
        public string OrderPrefix
        {
            get { return GetAttributeValue<string>("orderprefix"); }
            set
            {
                OnPropertyChanging("OrderPrefix");
                SetAttributeValue("orderprefix", value);
                OnPropertyChanged("OrderPrefix");
            }
        }

        /// <summary>
        ///     Unique identifier of the organization.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public Guid? OrganizationId
        {
            get { return GetAttributeValue<Guid?>("organizationid"); }
        }

        [AttributeLogicalName("organizationid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { base.Id = value; }
        }

        /// <summary>
        ///     Organization settings stored in Organization Database.
        /// </summary>
        [AttributeLogicalName("orgdborgsettings")]
        public string OrgDbOrgSettings
        {
            get { return GetAttributeValue<string>("orgdborgsettings"); }
            set
            {
                OnPropertyChanging("OrgDbOrgSettings");
                SetAttributeValue("orgdborgsettings", value);
                OnPropertyChanged("OrgDbOrgSettings");
            }
        }

        /// <summary>
        ///     Prefix used for parsed table columns.
        /// </summary>
        [AttributeLogicalName("parsedtablecolumnprefix")]
        public string ParsedTableColumnPrefix
        {
            get { return GetAttributeValue<string>("parsedtablecolumnprefix"); }
        }

        /// <summary>
        ///     Prefix used for parsed tables.
        /// </summary>
        [AttributeLogicalName("parsedtableprefix")]
        public string ParsedTablePrefix
        {
            get { return GetAttributeValue<string>("parsedtableprefix"); }
        }

        /// <summary>
        ///     Specifies the maximum number of months in past for which the recurring activities can be created.
        /// </summary>
        [AttributeLogicalName("pastexpansionwindow")]
        public int? PastExpansionWindow
        {
            get { return GetAttributeValue<int?>("pastexpansionwindow"); }
            set
            {
                OnPropertyChanging("PastExpansionWindow");
                SetAttributeValue("pastexpansionwindow", value);
                OnPropertyChanged("PastExpansionWindow");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("picture")]
        public string Picture
        {
            get { return GetAttributeValue<string>("picture"); }
            set
            {
                OnPropertyChanging("Picture");
                SetAttributeValue("picture", value);
                OnPropertyChanged("Picture");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("pinpointlanguagecode")]
        public int? PinpointLanguageCode
        {
            get { return GetAttributeValue<int?>("pinpointlanguagecode"); }
            set
            {
                OnPropertyChanging("PinpointLanguageCode");
                SetAttributeValue("pinpointlanguagecode", value);
                OnPropertyChanged("PinpointLanguageCode");
            }
        }

        /// <summary>
        ///     PM designator to use throughout Microsoft Dynamics CRM.
        /// </summary>
        [AttributeLogicalName("pmdesignator")]
        public string PMDesignator
        {
            get { return GetAttributeValue<string>("pmdesignator"); }
            set
            {
                OnPropertyChanging("PMDesignator");
                SetAttributeValue("pmdesignator", value);
                OnPropertyChanged("PMDesignator");
            }
        }

        /// <summary>
        ///     Number of decimal places that can be used for prices.
        /// </summary>
        [AttributeLogicalName("pricingdecimalprecision")]
        public int? PricingDecimalPrecision
        {
            get { return GetAttributeValue<int?>("pricingdecimalprecision"); }
            set
            {
                OnPropertyChanging("PricingDecimalPrecision");
                SetAttributeValue("pricingdecimalprecision", value);
                OnPropertyChanged("PricingDecimalPrecision");
            }
        }

        /// <summary>
        ///     Unique identifier of the default privilege for users in the organization.
        /// </summary>
        [AttributeLogicalName("privilegeusergroupid")]
        public Guid? PrivilegeUserGroupId
        {
            get { return GetAttributeValue<Guid?>("privilegeusergroupid"); }
            set
            {
                OnPropertyChanging("PrivilegeUserGroupId");
                SetAttributeValue("privilegeusergroupid", value);
                OnPropertyChanged("PrivilegeUserGroupId");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("privreportinggroupid")]
        public Guid? PrivReportingGroupId
        {
            get { return GetAttributeValue<Guid?>("privreportinggroupid"); }
            set
            {
                OnPropertyChanging("PrivReportingGroupId");
                SetAttributeValue("privreportinggroupid", value);
                OnPropertyChanged("PrivReportingGroupId");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("privreportinggroupname")]
        public string PrivReportingGroupName
        {
            get { return GetAttributeValue<string>("privreportinggroupname"); }
            set
            {
                OnPropertyChanging("PrivReportingGroupName");
                SetAttributeValue("privreportinggroupname", value);
                OnPropertyChanged("PrivReportingGroupName");
            }
        }

        /// <summary>
        ///     Indicates whether a quick find record limit should be enabled for this organization (allows for faster Quick Find
        ///     queries but prevents overly broad searches).
        /// </summary>
        [AttributeLogicalName("quickfindrecordlimitenabled")]
        public bool? QuickFindRecordLimitEnabled
        {
            get { return GetAttributeValue<bool?>("quickfindrecordlimitenabled"); }
            set
            {
                OnPropertyChanging("QuickFindRecordLimitEnabled");
                SetAttributeValue("quickfindrecordlimitenabled", value);
                OnPropertyChanged("QuickFindRecordLimitEnabled");
            }
        }

        /// <summary>
        ///     Prefix to use for all quotes throughout Microsoft Dynamics CRM.
        /// </summary>
        [AttributeLogicalName("quoteprefix")]
        public string QuotePrefix
        {
            get { return GetAttributeValue<string>("quoteprefix"); }
            set
            {
                OnPropertyChanging("QuotePrefix");
                SetAttributeValue("quoteprefix", value);
                OnPropertyChanged("QuotePrefix");
            }
        }

        /// <summary>
        ///     Specifies the default value for number of occurrences field in the recurrence dialog.
        /// </summary>
        [AttributeLogicalName("recurrencedefaultnumberofoccurrences")]
        public int? RecurrenceDefaultNumberOfOccurrences
        {
            get { return GetAttributeValue<int?>("recurrencedefaultnumberofoccurrences"); }
            set
            {
                OnPropertyChanging("RecurrenceDefaultNumberOfOccurrences");
                SetAttributeValue("recurrencedefaultnumberofoccurrences", value);
                OnPropertyChanged("RecurrenceDefaultNumberOfOccurrences");
            }
        }

        /// <summary>
        ///     Specifies the interval (in seconds) for pausing expansion job.
        /// </summary>
        [AttributeLogicalName("recurrenceexpansionjobbatchinterval")]
        public int? RecurrenceExpansionJobBatchInterval
        {
            get { return GetAttributeValue<int?>("recurrenceexpansionjobbatchinterval"); }
            set
            {
                OnPropertyChanging("RecurrenceExpansionJobBatchInterval");
                SetAttributeValue("recurrenceexpansionjobbatchinterval", value);
                OnPropertyChanged("RecurrenceExpansionJobBatchInterval");
            }
        }

        /// <summary>
        ///     Specifies the value for number of instances created in on demand job in one shot.
        /// </summary>
        [AttributeLogicalName("recurrenceexpansionjobbatchsize")]
        public int? RecurrenceExpansionJobBatchSize
        {
            get { return GetAttributeValue<int?>("recurrenceexpansionjobbatchsize"); }
            set
            {
                OnPropertyChanging("RecurrenceExpansionJobBatchSize");
                SetAttributeValue("recurrenceexpansionjobbatchsize", value);
                OnPropertyChanged("RecurrenceExpansionJobBatchSize");
            }
        }

        /// <summary>
        ///     Specifies the maximum number of instances to be created synchronously after creating a recurring appointment.
        /// </summary>
        [AttributeLogicalName("recurrenceexpansionsynchcreatemax")]
        public int? RecurrenceExpansionSynchCreateMax
        {
            get { return GetAttributeValue<int?>("recurrenceexpansionsynchcreatemax"); }
            set
            {
                OnPropertyChanging("RecurrenceExpansionSynchCreateMax");
                SetAttributeValue("recurrenceexpansionsynchcreatemax", value);
                OnPropertyChanged("RecurrenceExpansionSynchCreateMax");
            }
        }

        /// <summary>
        ///     XML string that defines the navigation structure for the application. This is the site map from the previously
        ///     upgraded build and is used in a 3-way merge during upgrade.
        /// </summary>
        [AttributeLogicalName("referencesitemapxml")]
        [Obsolete]
        public string ReferenceSiteMapXml
        {
            get { return GetAttributeValue<string>("referencesitemapxml"); }
            set
            {
                OnPropertyChanging("ReferenceSiteMapXml");
                SetAttributeValue("referencesitemapxml", value);
                OnPropertyChanged("ReferenceSiteMapXml");
            }
        }

        /// <summary>
        ///     Flag to render the body of email in the Web form in an IFRAME with the security='restricted' attribute set. This is
        ///     additional security but can cause a credentials prompt.
        /// </summary>
        [AttributeLogicalName("rendersecureiframeforemail")]
        public bool? RenderSecureIFrameForEmail
        {
            get { return GetAttributeValue<bool?>("rendersecureiframeforemail"); }
            set
            {
                OnPropertyChanging("RenderSecureIFrameForEmail");
                SetAttributeValue("rendersecureiframeforemail", value);
                OnPropertyChanged("RenderSecureIFrameForEmail");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("reportinggroupid")]
        public Guid? ReportingGroupId
        {
            get { return GetAttributeValue<Guid?>("reportinggroupid"); }
            set
            {
                OnPropertyChanging("ReportingGroupId");
                SetAttributeValue("reportinggroupid", value);
                OnPropertyChanged("ReportingGroupId");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("reportinggroupname")]
        public string ReportingGroupName
        {
            get { return GetAttributeValue<string>("reportinggroupname"); }
            set
            {
                OnPropertyChanging("ReportingGroupName");
                SetAttributeValue("reportinggroupname", value);
                OnPropertyChanged("ReportingGroupName");
            }
        }

        /// <summary>
        ///     Picklist for selecting the organization preference for reporting scripting errors.
        /// </summary>
        [AttributeLogicalName("reportscripterrors")]
        public OptionSetValue ReportScriptErrors
        {
            get { return GetAttributeValue<OptionSetValue>("reportscripterrors"); }
            set
            {
                OnPropertyChanging("ReportScriptErrors");
                SetAttributeValue("reportscripterrors", value);
                OnPropertyChanged("ReportScriptErrors");
            }
        }

        /// <summary>
        ///     Indicates whether Send As Other User privilege is enabled.
        /// </summary>
        [AttributeLogicalName("requireapprovalforqueueemail")]
        public bool? RequireApprovalForQueueEmail
        {
            get { return GetAttributeValue<bool?>("requireapprovalforqueueemail"); }
            set
            {
                OnPropertyChanging("RequireApprovalForQueueEmail");
                SetAttributeValue("requireapprovalforqueueemail", value);
                OnPropertyChanged("RequireApprovalForQueueEmail");
            }
        }

        /// <summary>
        ///     Indicates whether Send As Other User privilege is enabled.
        /// </summary>
        [AttributeLogicalName("requireapprovalforuseremail")]
        public bool? RequireApprovalForUserEmail
        {
            get { return GetAttributeValue<bool?>("requireapprovalforuseremail"); }
            set
            {
                OnPropertyChanging("RequireApprovalForUserEmail");
                SetAttributeValue("requireapprovalforuseremail", value);
                OnPropertyChanged("RequireApprovalForUserEmail");
            }
        }

        /// <summary>
        ///     Unique identifier of the sample data import job.
        /// </summary>
        [AttributeLogicalName("sampledataimportid")]
        public Guid? SampleDataImportId
        {
            get { return GetAttributeValue<Guid?>("sampledataimportid"); }
            set
            {
                OnPropertyChanging("SampleDataImportId");
                SetAttributeValue("sampledataimportid", value);
                OnPropertyChanged("SampleDataImportId");
            }
        }

        /// <summary>
        ///     Prefix used for custom entities and attributes.
        /// </summary>
        [AttributeLogicalName("schemanameprefix")]
        public string SchemaNamePrefix
        {
            get { return GetAttributeValue<string>("schemanameprefix"); }
            set
            {
                OnPropertyChanging("SchemaNamePrefix");
                SetAttributeValue("schemanameprefix", value);
                OnPropertyChanged("SchemaNamePrefix");
            }
        }

        /// <summary>
        ///     Information that specifies whether to share to previous owner on assign.
        /// </summary>
        [AttributeLogicalName("sharetopreviousowneronassign")]
        public bool? ShareToPreviousOwnerOnAssign
        {
            get { return GetAttributeValue<bool?>("sharetopreviousowneronassign"); }
            set
            {
                OnPropertyChanging("ShareToPreviousOwnerOnAssign");
                SetAttributeValue("sharetopreviousowneronassign", value);
                OnPropertyChanged("ShareToPreviousOwnerOnAssign");
            }
        }

        /// <summary>
        ///     Information that specifies whether to display the week number in calendar displays throughout Microsoft CRM.
        /// </summary>
        [AttributeLogicalName("showweeknumber")]
        public bool? ShowWeekNumber
        {
            get { return GetAttributeValue<bool?>("showweeknumber"); }
            set
            {
                OnPropertyChanging("ShowWeekNumber");
                SetAttributeValue("showweeknumber", value);
                OnPropertyChanged("ShowWeekNumber");
            }
        }

        /// <summary>
        ///     CRM for Outlook Download URL
        /// </summary>
        [AttributeLogicalName("signupoutlookdownloadfwlink")]
        public string SignupOutlookDownloadFWLink
        {
            get { return GetAttributeValue<string>("signupoutlookdownloadfwlink"); }
            set
            {
                OnPropertyChanging("SignupOutlookDownloadFWLink");
                SetAttributeValue("signupoutlookdownloadfwlink", value);
                OnPropertyChanged("SignupOutlookDownloadFWLink");
            }
        }

        /// <summary>
        ///     XML string that defines the navigation structure for the application.
        /// </summary>
        [AttributeLogicalName("sitemapxml")]
        [Obsolete]
        public string SiteMapXml
        {
            get { return GetAttributeValue<string>("sitemapxml"); }
            set
            {
                OnPropertyChanging("SiteMapXml");
                SetAttributeValue("sitemapxml", value);
                OnPropertyChanged("SiteMapXml");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("sortid")]
        public int? SortId
        {
            get { return GetAttributeValue<int?>("sortid"); }
            set
            {
                OnPropertyChanging("SortId");
                SetAttributeValue("sortid", value);
                OnPropertyChanged("SortId");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("sqlaccessgroupid")]
        public Guid? SqlAccessGroupId
        {
            get { return GetAttributeValue<Guid?>("sqlaccessgroupid"); }
            set
            {
                OnPropertyChanging("SqlAccessGroupId");
                SetAttributeValue("sqlaccessgroupid", value);
                OnPropertyChanged("SqlAccessGroupId");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("sqlaccessgroupname")]
        public string SqlAccessGroupName
        {
            get { return GetAttributeValue<string>("sqlaccessgroupname"); }
            set
            {
                OnPropertyChanging("SqlAccessGroupName");
                SetAttributeValue("sqlaccessgroupname", value);
                OnPropertyChanged("SqlAccessGroupName");
            }
        }

        /// <summary>
        ///     Setting for SQM data collection, 0 no, 1 yes enabled
        /// </summary>
        [AttributeLogicalName("sqmenabled")]
        public bool? SQMEnabled
        {
            get { return GetAttributeValue<bool?>("sqmenabled"); }
            set
            {
                OnPropertyChanging("SQMEnabled");
                SetAttributeValue("sqmenabled", value);
                OnPropertyChanged("SQMEnabled");
            }
        }

        /// <summary>
        ///     Unique identifier of the support user for the organization.
        /// </summary>
        [AttributeLogicalName("supportuserid")]
        public Guid? SupportUserId
        {
            get { return GetAttributeValue<Guid?>("supportuserid"); }
            set
            {
                OnPropertyChanging("SupportUserId");
                SetAttributeValue("supportuserid", value);
                OnPropertyChanged("SupportUserId");
            }
        }

        /// <summary>
        ///     Unique identifier of the system user for the organization.
        /// </summary>
        [AttributeLogicalName("systemuserid")]
        public Guid? SystemUserId
        {
            get { return GetAttributeValue<Guid?>("systemuserid"); }
            set
            {
                OnPropertyChanging("SystemUserId");
                SetAttributeValue("systemuserid", value);
                OnPropertyChanged("SystemUserId");
            }
        }

        /// <summary>
        ///     Maximum number of aggressive polling cycles executed for email auto-tagging when a new email is received.
        /// </summary>
        [AttributeLogicalName("tagmaxaggressivecycles")]
        public int? TagMaxAggressiveCycles
        {
            get { return GetAttributeValue<int?>("tagmaxaggressivecycles"); }
            set
            {
                OnPropertyChanging("TagMaxAggressiveCycles");
                SetAttributeValue("tagmaxaggressivecycles", value);
                OnPropertyChanged("TagMaxAggressiveCycles");
            }
        }

        /// <summary>
        ///     Normal polling frequency used for email receive auto-tagging in outlook.
        /// </summary>
        [AttributeLogicalName("tagpollingperiod")]
        public int? TagPollingPeriod
        {
            get { return GetAttributeValue<int?>("tagpollingperiod"); }
            set
            {
                OnPropertyChanging("TagPollingPeriod");
                SetAttributeValue("tagpollingperiod", value);
                OnPropertyChanged("TagPollingPeriod");
            }
        }

        /// <summary>
        ///     Information that specifies how the time is displayed throughout Microsoft CRM.
        /// </summary>
        [AttributeLogicalName("timeformatcode")]
        public OptionSetValue TimeFormatCode
        {
            get { return GetAttributeValue<OptionSetValue>("timeformatcode"); }
            set
            {
                OnPropertyChanging("TimeFormatCode");
                SetAttributeValue("timeformatcode", value);
                OnPropertyChanged("TimeFormatCode");
            }
        }

        /// <summary>
        ///     Text for how time is displayed in Microsoft Dynamics CRM.
        /// </summary>
        [AttributeLogicalName("timeformatstring")]
        public string TimeFormatString
        {
            get { return GetAttributeValue<string>("timeformatstring"); }
            set
            {
                OnPropertyChanging("TimeFormatString");
                SetAttributeValue("timeformatstring", value);
                OnPropertyChanged("TimeFormatString");
            }
        }

        /// <summary>
        ///     Text for how the time separator is displayed throughout Microsoft Dynamics CRM.
        /// </summary>
        [AttributeLogicalName("timeseparator")]
        public string TimeSeparator
        {
            get { return GetAttributeValue<string>("timeseparator"); }
            set
            {
                OnPropertyChanging("TimeSeparator");
                SetAttributeValue("timeseparator", value);
                OnPropertyChanged("TimeSeparator");
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
        ///     Duration used for token expiration.
        /// </summary>
        [AttributeLogicalName("tokenexpiry")]
        public int? TokenExpiry
        {
            get { return GetAttributeValue<int?>("tokenexpiry"); }
            set
            {
                OnPropertyChanging("TokenExpiry");
                SetAttributeValue("tokenexpiry", value);
                OnPropertyChanged("TokenExpiry");
            }
        }

        /// <summary>
        ///     Token key.
        /// </summary>
        [AttributeLogicalName("tokenkey")]
        public string TokenKey
        {
            get { return GetAttributeValue<string>("tokenkey"); }
            set
            {
                OnPropertyChanging("TokenKey");
                SetAttributeValue("tokenkey", value);
                OnPropertyChanged("TokenKey");
            }
        }

        /// <summary>
        ///     History list of tracking token prefixes.
        /// </summary>
        [AttributeLogicalName("trackingprefix")]
        public string TrackingPrefix
        {
            get { return GetAttributeValue<string>("trackingprefix"); }
            set
            {
                OnPropertyChanging("TrackingPrefix");
                SetAttributeValue("trackingprefix", value);
                OnPropertyChanged("TrackingPrefix");
            }
        }

        /// <summary>
        ///     Base number used to provide separate tracking token identifiers to users belonging to different deployments.
        /// </summary>
        [AttributeLogicalName("trackingtokenidbase")]
        public int? TrackingTokenIdBase
        {
            get { return GetAttributeValue<int?>("trackingtokenidbase"); }
            set
            {
                OnPropertyChanging("TrackingTokenIdBase");
                SetAttributeValue("trackingtokenidbase", value);
                OnPropertyChanged("TrackingTokenIdBase");
            }
        }

        /// <summary>
        ///     Number of digits used to represent a tracking token identifier.
        /// </summary>
        [AttributeLogicalName("trackingtokeniddigits")]
        public int? TrackingTokenIdDigits
        {
            get { return GetAttributeValue<int?>("trackingtokeniddigits"); }
            set
            {
                OnPropertyChanging("TrackingTokenIdDigits");
                SetAttributeValue("trackingtokeniddigits", value);
                OnPropertyChanged("TrackingTokenIdDigits");
            }
        }

        /// <summary>
        ///     Number of characters appended to invoice, quote, and order numbers.
        /// </summary>
        [AttributeLogicalName("uniquespecifierlength")]
        public int? UniqueSpecifierLength
        {
            get { return GetAttributeValue<int?>("uniquespecifierlength"); }
            set
            {
                OnPropertyChanging("UniqueSpecifierLength");
                SetAttributeValue("uniquespecifierlength", value);
                OnPropertyChanged("UniqueSpecifierLength");
            }
        }

        /// <summary>
        ///     The interval at which user access is checked for auditing.
        /// </summary>
        [AttributeLogicalName("useraccessauditinginterval")]
        public int? UserAccessAuditingInterval
        {
            get { return GetAttributeValue<int?>("useraccessauditinginterval"); }
            set
            {
                OnPropertyChanging("UserAccessAuditingInterval");
                SetAttributeValue("useraccessauditinginterval", value);
                OnPropertyChanged("UserAccessAuditingInterval");
            }
        }

        /// <summary>
        ///     Indicates whether the read-optimized form should be enabled for this organization.
        /// </summary>
        [AttributeLogicalName("usereadform")]
        public bool? UseReadForm
        {
            get { return GetAttributeValue<bool?>("usereadform"); }
            set
            {
                OnPropertyChanging("UseReadForm");
                SetAttributeValue("usereadform", value);
                OnPropertyChanged("UseReadForm");
            }
        }

        /// <summary>
        ///     Unique identifier of the default group of users in the organization.
        /// </summary>
        [AttributeLogicalName("usergroupid")]
        public Guid? UserGroupId
        {
            get { return GetAttributeValue<Guid?>("usergroupid"); }
            set
            {
                OnPropertyChanging("UserGroupId");
                SetAttributeValue("usergroupid", value);
                OnPropertyChanged("UserGroupId");
            }
        }

        /// <summary>
        ///     Indicates default protocol selected for organization.
        /// </summary>
        [AttributeLogicalName("useskypeprotocol")]
        public bool? UseSkypeProtocol
        {
            get { return GetAttributeValue<bool?>("useskypeprotocol"); }
            set
            {
                OnPropertyChanging("UseSkypeProtocol");
                SetAttributeValue("useskypeprotocol", value);
                OnPropertyChanged("UseSkypeProtocol");
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
        ///     Hash of the V3 callout configuration file.
        /// </summary>
        [AttributeLogicalName("v3calloutconfighash")]
        public string V3CalloutConfigHash
        {
            get { return GetAttributeValue<string>("v3calloutconfighash"); }
        }

        /// <summary>
        ///     Version number of the organization.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     Designated first day of the week throughout Microsoft Dynamics CRM.
        /// </summary>
        [AttributeLogicalName("weekstartdaycode")]
        public OptionSetValue WeekStartDayCode
        {
            get { return GetAttributeValue<OptionSetValue>("weekstartdaycode"); }
            set
            {
                OnPropertyChanging("WeekStartDayCode");
                SetAttributeValue("weekstartdaycode", value);
                OnPropertyChanged("WeekStartDayCode");
            }
        }

        /// <summary>
        ///     Denotes the Yammer group ID
        /// </summary>
        [AttributeLogicalName("yammergroupid")]
        public int? YammerGroupId
        {
            get { return GetAttributeValue<int?>("yammergroupid"); }
            set
            {
                OnPropertyChanging("YammerGroupId");
                SetAttributeValue("yammergroupid", value);
                OnPropertyChanged("YammerGroupId");
            }
        }

        /// <summary>
        ///     Denotes the Yammer network permalink
        /// </summary>
        [AttributeLogicalName("yammernetworkpermalink")]
        public string YammerNetworkPermalink
        {
            get { return GetAttributeValue<string>("yammernetworkpermalink"); }
            set
            {
                OnPropertyChanging("YammerNetworkPermalink");
                SetAttributeValue("yammernetworkpermalink", value);
                OnPropertyChanged("YammerNetworkPermalink");
            }
        }

        /// <summary>
        ///     Denotes whether the OAuth access token for Yammer network has expired
        /// </summary>
        [AttributeLogicalName("yammeroauthaccesstokenexpired")]
        public bool? YammerOAuthAccessTokenExpired
        {
            get { return GetAttributeValue<bool?>("yammeroauthaccesstokenexpired"); }
            set
            {
                OnPropertyChanging("YammerOAuthAccessTokenExpired");
                SetAttributeValue("yammeroauthaccesstokenexpired", value);
                OnPropertyChanged("YammerOAuthAccessTokenExpired");
            }
        }

        /// <summary>
        ///     Internal Use Only
        /// </summary>
        [AttributeLogicalName("yammerpostmethod")]
        public OptionSetValue YammerPostMethod
        {
            get { return GetAttributeValue<OptionSetValue>("yammerpostmethod"); }
            set
            {
                OnPropertyChanging("YammerPostMethod");
                SetAttributeValue("yammerpostmethod", value);
                OnPropertyChanged("YammerPostMethod");
            }
        }

        /// <summary>
        ///     Information that specifies how the first week of the year is specified in Microsoft Dynamics CRM.
        /// </summary>
        [AttributeLogicalName("yearstartweekcode")]
        public int? YearStartWeekCode
        {
            get { return GetAttributeValue<int?>("yearstartweekcode"); }
            set
            {
                OnPropertyChanging("YearStartWeekCode");
                SetAttributeValue("yearstartweekcode", value);
                OnPropertyChanged("YearStartWeekCode");
            }
        }

        /// <summary>
        ///     1:N lk_fieldsecurityprofile_organizationid
        /// </summary>
        [RelationshipSchemaName("lk_fieldsecurityprofile_organizationid")]
        public IEnumerable<FieldSecurityProfile> lk_fieldsecurityprofile_organizationid
        {
            get { return GetRelatedEntities<FieldSecurityProfile>("lk_fieldsecurityprofile_organizationid", null); }
            set
            {
                OnPropertyChanging("lk_fieldsecurityprofile_organizationid");
                SetRelatedEntities("lk_fieldsecurityprofile_organizationid", null, value);
                OnPropertyChanged("lk_fieldsecurityprofile_organizationid");
            }
        }

        /// <summary>
        ///     1:N lk_organizationui_organizationid
        /// </summary>
        [RelationshipSchemaName("lk_organizationui_organizationid")]
        public IEnumerable<OrganizationUI> lk_organizationui_organizationid
        {
            get { return GetRelatedEntities<OrganizationUI>("lk_organizationui_organizationid", null); }
            set
            {
                OnPropertyChanging("lk_organizationui_organizationid");
                SetRelatedEntities("lk_organizationui_organizationid", null, value);
                OnPropertyChanged("lk_organizationui_organizationid");
            }
        }

        /// <summary>
        ///     1:N lk_principalobjectattributeaccess_organizationid
        /// </summary>
        [RelationshipSchemaName("lk_principalobjectattributeaccess_organizationid")]
        public IEnumerable<PrincipalObjectAttributeAccess> lk_principalobjectattributeaccess_organizationid
        {
            get
            {
                return
                    GetRelatedEntities<PrincipalObjectAttributeAccess>(
                        "lk_principalobjectattributeaccess_organizationid", null);
            }
            set
            {
                OnPropertyChanging("lk_principalobjectattributeaccess_organizationid");
                SetRelatedEntities("lk_principalobjectattributeaccess_organizationid", null, value);
                OnPropertyChanged("lk_principalobjectattributeaccess_organizationid");
            }
        }

        /// <summary>
        ///     1:N Organization_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Organization_AsyncOperations")]
        public IEnumerable<AsyncOperation> Organization_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Organization_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Organization_AsyncOperations");
                SetRelatedEntities("Organization_AsyncOperations", null, value);
                OnPropertyChanged("Organization_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N organization_attributemap
        /// </summary>
        [RelationshipSchemaName("organization_attributemap")]
        public IEnumerable<AttributeMap> organization_attributemap
        {
            get { return GetRelatedEntities<AttributeMap>("organization_attributemap", null); }
            set
            {
                OnPropertyChanging("organization_attributemap");
                SetRelatedEntities("organization_attributemap", null, value);
                OnPropertyChanged("organization_attributemap");
            }
        }

        /// <summary>
        ///     1:N Organization_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("Organization_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> Organization_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("Organization_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("Organization_BulkDeleteFailures");
                SetRelatedEntities("Organization_BulkDeleteFailures", null, value);
                OnPropertyChanged("Organization_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N organization_business_unit_news_articles
        /// </summary>
        [RelationshipSchemaName("organization_business_unit_news_articles")]
        public IEnumerable<BusinessUnitNewsArticle> organization_business_unit_news_articles
        {
            get
            {
                return GetRelatedEntities<BusinessUnitNewsArticle>("organization_business_unit_news_articles", null);
            }
            set
            {
                OnPropertyChanging("organization_business_unit_news_articles");
                SetRelatedEntities("organization_business_unit_news_articles", null, value);
                OnPropertyChanged("organization_business_unit_news_articles");
            }
        }

        /// <summary>
        ///     1:N organization_business_units
        /// </summary>
        [RelationshipSchemaName("organization_business_units")]
        public IEnumerable<BusinessUnit> organization_business_units
        {
            get { return GetRelatedEntities<BusinessUnit>("organization_business_units", null); }
            set
            {
                OnPropertyChanging("organization_business_units");
                SetRelatedEntities("organization_business_units", null, value);
                OnPropertyChanged("organization_business_units");
            }
        }

        /// <summary>
        ///     1:N organization_calendars
        /// </summary>
        [RelationshipSchemaName("organization_calendars")]
        public IEnumerable<Calendar> organization_calendars
        {
            get { return GetRelatedEntities<Calendar>("organization_calendars", null); }
            set
            {
                OnPropertyChanging("organization_calendars");
                SetRelatedEntities("organization_calendars", null, value);
                OnPropertyChanged("organization_calendars");
            }
        }

        /// <summary>
        ///     1:N organization_competitors
        /// </summary>
        [RelationshipSchemaName("organization_competitors")]
        public IEnumerable<Competitor> organization_competitors
        {
            get { return GetRelatedEntities<Competitor>("organization_competitors", null); }
            set
            {
                OnPropertyChanging("organization_competitors");
                SetRelatedEntities("organization_competitors", null, value);
                OnPropertyChanged("organization_competitors");
            }
        }

        /// <summary>
        ///     1:N organization_connection_roles
        /// </summary>
        [RelationshipSchemaName("organization_connection_roles")]
        public IEnumerable<ConnectionRole> organization_connection_roles
        {
            get { return GetRelatedEntities<ConnectionRole>("organization_connection_roles", null); }
            set
            {
                OnPropertyChanging("organization_connection_roles");
                SetRelatedEntities("organization_connection_roles", null, value);
                OnPropertyChanged("organization_connection_roles");
            }
        }

        /// <summary>
        ///     1:N organization_constraint_based_groups
        /// </summary>
        [RelationshipSchemaName("organization_constraint_based_groups")]
        public IEnumerable<ConstraintBasedGroup> organization_constraint_based_groups
        {
            get { return GetRelatedEntities<ConstraintBasedGroup>("organization_constraint_based_groups", null); }
            set
            {
                OnPropertyChanging("organization_constraint_based_groups");
                SetRelatedEntities("organization_constraint_based_groups", null, value);
                OnPropertyChanged("organization_constraint_based_groups");
            }
        }

        /// <summary>
        ///     1:N organization_contract_templates
        /// </summary>
        [RelationshipSchemaName("organization_contract_templates")]
        public IEnumerable<ContractTemplate> organization_contract_templates
        {
            get { return GetRelatedEntities<ContractTemplate>("organization_contract_templates", null); }
            set
            {
                OnPropertyChanging("organization_contract_templates");
                SetRelatedEntities("organization_contract_templates", null, value);
                OnPropertyChanged("organization_contract_templates");
            }
        }

        /// <summary>
        ///     1:N organization_custom_displaystrings
        /// </summary>
        [RelationshipSchemaName("organization_custom_displaystrings")]
        public IEnumerable<DisplayString> organization_custom_displaystrings
        {
            get { return GetRelatedEntities<DisplayString>("organization_custom_displaystrings", null); }
            set
            {
                OnPropertyChanging("organization_custom_displaystrings");
                SetRelatedEntities("organization_custom_displaystrings", null, value);
                OnPropertyChanged("organization_custom_displaystrings");
            }
        }

        /// <summary>
        ///     1:N organization_discount_types
        /// </summary>
        [RelationshipSchemaName("organization_discount_types")]
        public IEnumerable<DiscountType> organization_discount_types
        {
            get { return GetRelatedEntities<DiscountType>("organization_discount_types", null); }
            set
            {
                OnPropertyChanging("organization_discount_types");
                SetRelatedEntities("organization_discount_types", null, value);
                OnPropertyChanged("organization_discount_types");
            }
        }

        /// <summary>
        ///     1:N organization_emailserverprofile
        /// </summary>
        [RelationshipSchemaName("organization_emailserverprofile")]
        public IEnumerable<EmailServerProfile> organization_emailserverprofile
        {
            get { return GetRelatedEntities<EmailServerProfile>("organization_emailserverprofile", null); }
            set
            {
                OnPropertyChanging("organization_emailserverprofile");
                SetRelatedEntities("organization_emailserverprofile", null, value);
                OnPropertyChanged("organization_emailserverprofile");
            }
        }

        /// <summary>
        ///     1:N organization_entitymap
        /// </summary>
        [RelationshipSchemaName("organization_entitymap")]
        public IEnumerable<EntityMap> organization_entitymap
        {
            get { return GetRelatedEntities<EntityMap>("organization_entitymap", null); }
            set
            {
                OnPropertyChanging("organization_entitymap");
                SetRelatedEntities("organization_entitymap", null, value);
                OnPropertyChanged("organization_entitymap");
            }
        }

        /// <summary>
        ///     1:N organization_equipment
        /// </summary>
        [RelationshipSchemaName("organization_equipment")]
        public IEnumerable<Equipment> organization_equipment
        {
            get { return GetRelatedEntities<Equipment>("organization_equipment", null); }
            set
            {
                OnPropertyChanging("organization_equipment");
                SetRelatedEntities("organization_equipment", null, value);
                OnPropertyChanged("organization_equipment");
            }
        }

        /// <summary>
        ///     1:N organization_importjob
        /// </summary>
        [RelationshipSchemaName("organization_importjob")]
        public IEnumerable<ImportJob> organization_importjob
        {
            get { return GetRelatedEntities<ImportJob>("organization_importjob", null); }
            set
            {
                OnPropertyChanging("organization_importjob");
                SetRelatedEntities("organization_importjob", null, value);
                OnPropertyChanged("organization_importjob");
            }
        }

        /// <summary>
        ///     1:N organization_isvconfigs
        /// </summary>
        [RelationshipSchemaName("organization_isvconfigs")]
        public IEnumerable<IsvConfig> organization_isvconfigs
        {
            get { return GetRelatedEntities<IsvConfig>("organization_isvconfigs", null); }
            set
            {
                OnPropertyChanging("organization_isvconfigs");
                SetRelatedEntities("organization_isvconfigs", null, value);
                OnPropertyChanged("organization_isvconfigs");
            }
        }

        /// <summary>
        ///     1:N organization_kb_article_templates
        /// </summary>
        [RelationshipSchemaName("organization_kb_article_templates")]
        public IEnumerable<KbArticleTemplate> organization_kb_article_templates
        {
            get { return GetRelatedEntities<KbArticleTemplate>("organization_kb_article_templates", null); }
            set
            {
                OnPropertyChanging("organization_kb_article_templates");
                SetRelatedEntities("organization_kb_article_templates", null, value);
                OnPropertyChanged("organization_kb_article_templates");
            }
        }

        /// <summary>
        ///     1:N organization_kb_articles
        /// </summary>
        [RelationshipSchemaName("organization_kb_articles")]
        public IEnumerable<KbArticle> organization_kb_articles
        {
            get { return GetRelatedEntities<KbArticle>("organization_kb_articles", null); }
            set
            {
                OnPropertyChanging("organization_kb_articles");
                SetRelatedEntities("organization_kb_articles", null, value);
                OnPropertyChanged("organization_kb_articles");
            }
        }

        /// <summary>
        ///     1:N organization_licenses
        /// </summary>
        [RelationshipSchemaName("organization_licenses")]
        public IEnumerable<License> organization_licenses
        {
            get { return GetRelatedEntities<License>("organization_licenses", null); }
            set
            {
                OnPropertyChanging("organization_licenses");
                SetRelatedEntities("organization_licenses", null, value);
                OnPropertyChanged("organization_licenses");
            }
        }

        /// <summary>
        ///     1:N organization_mailbox
        /// </summary>
        [RelationshipSchemaName("organization_mailbox")]
        public IEnumerable<Mailbox> organization_mailbox
        {
            get { return GetRelatedEntities<Mailbox>("organization_mailbox", null); }
            set
            {
                OnPropertyChanging("organization_mailbox");
                SetRelatedEntities("organization_mailbox", null, value);
                OnPropertyChanged("organization_mailbox");
            }
        }

        /// <summary>
        ///     1:N organization_metric
        /// </summary>
        [RelationshipSchemaName("organization_metric")]
        public IEnumerable<Metric> organization_metric
        {
            get { return GetRelatedEntities<Metric>("organization_metric", null); }
            set
            {
                OnPropertyChanging("organization_metric");
                SetRelatedEntities("organization_metric", null, value);
                OnPropertyChanged("organization_metric");
            }
        }

        /// <summary>
        ///     1:N organization_msdyn_postconfig
        /// </summary>
        [RelationshipSchemaName("organization_msdyn_postconfig")]
        public IEnumerable<msdyn_PostConfig> organization_msdyn_postconfig
        {
            get { return GetRelatedEntities<msdyn_PostConfig>("organization_msdyn_postconfig", null); }
            set
            {
                OnPropertyChanging("organization_msdyn_postconfig");
                SetRelatedEntities("organization_msdyn_postconfig", null, value);
                OnPropertyChanged("organization_msdyn_postconfig");
            }
        }

        /// <summary>
        ///     1:N organization_msdyn_postruleconfig
        /// </summary>
        [RelationshipSchemaName("organization_msdyn_postruleconfig")]
        public IEnumerable<msdyn_PostRuleConfig> organization_msdyn_postruleconfig
        {
            get { return GetRelatedEntities<msdyn_PostRuleConfig>("organization_msdyn_postruleconfig", null); }
            set
            {
                OnPropertyChanging("organization_msdyn_postruleconfig");
                SetRelatedEntities("organization_msdyn_postruleconfig", null, value);
                OnPropertyChanged("organization_msdyn_postruleconfig");
            }
        }

        /// <summary>
        ///     1:N organization_msdyn_wallsavedquery
        /// </summary>
        [RelationshipSchemaName("organization_msdyn_wallsavedquery")]
        public IEnumerable<msdyn_wallsavedquery> organization_msdyn_wallsavedquery
        {
            get { return GetRelatedEntities<msdyn_wallsavedquery>("organization_msdyn_wallsavedquery", null); }
            set
            {
                OnPropertyChanging("organization_msdyn_wallsavedquery");
                SetRelatedEntities("organization_msdyn_wallsavedquery", null, value);
                OnPropertyChanged("organization_msdyn_wallsavedquery");
            }
        }

        /// <summary>
        ///     1:N organization_pluginassembly
        /// </summary>
        [RelationshipSchemaName("organization_pluginassembly")]
        public IEnumerable<PluginAssembly> organization_pluginassembly
        {
            get { return GetRelatedEntities<PluginAssembly>("organization_pluginassembly", null); }
            set
            {
                OnPropertyChanging("organization_pluginassembly");
                SetRelatedEntities("organization_pluginassembly", null, value);
                OnPropertyChanged("organization_pluginassembly");
            }
        }

        /// <summary>
        ///     1:N organization_plugintype
        /// </summary>
        [RelationshipSchemaName("organization_plugintype")]
        public IEnumerable<PluginType> organization_plugintype
        {
            get { return GetRelatedEntities<PluginType>("organization_plugintype", null); }
            set
            {
                OnPropertyChanging("organization_plugintype");
                SetRelatedEntities("organization_plugintype", null, value);
                OnPropertyChanged("organization_plugintype");
            }
        }

        /// <summary>
        ///     1:N organization_plugintypestatistic
        /// </summary>
        [RelationshipSchemaName("organization_plugintypestatistic")]
        public IEnumerable<PluginTypeStatistic> organization_plugintypestatistic
        {
            get { return GetRelatedEntities<PluginTypeStatistic>("organization_plugintypestatistic", null); }
            set
            {
                OnPropertyChanging("organization_plugintypestatistic");
                SetRelatedEntities("organization_plugintypestatistic", null, value);
                OnPropertyChanged("organization_plugintypestatistic");
            }
        }

        /// <summary>
        ///     1:N organization_post
        /// </summary>
        [RelationshipSchemaName("organization_post")]
        public IEnumerable<Post> organization_post
        {
            get { return GetRelatedEntities<Post>("organization_post", null); }
            set
            {
                OnPropertyChanging("organization_post");
                SetRelatedEntities("organization_post", null, value);
                OnPropertyChanged("organization_post");
            }
        }

        /// <summary>
        ///     1:N organization_PostComment
        /// </summary>
        [RelationshipSchemaName("organization_PostComment")]
        public IEnumerable<PostComment> organization_PostComment
        {
            get { return GetRelatedEntities<PostComment>("organization_PostComment", null); }
            set
            {
                OnPropertyChanging("organization_PostComment");
                SetRelatedEntities("organization_PostComment", null, value);
                OnPropertyChanged("organization_PostComment");
            }
        }

        /// <summary>
        ///     1:N organization_postlike
        /// </summary>
        [RelationshipSchemaName("organization_postlike")]
        public IEnumerable<PostLike> organization_postlike
        {
            get { return GetRelatedEntities<PostLike>("organization_postlike", null); }
            set
            {
                OnPropertyChanging("organization_postlike");
                SetRelatedEntities("organization_postlike", null, value);
                OnPropertyChanged("organization_postlike");
            }
        }

        /// <summary>
        ///     1:N organization_price_levels
        /// </summary>
        [RelationshipSchemaName("organization_price_levels")]
        public IEnumerable<PriceLevel> organization_price_levels
        {
            get { return GetRelatedEntities<PriceLevel>("organization_price_levels", null); }
            set
            {
                OnPropertyChanging("organization_price_levels");
                SetRelatedEntities("organization_price_levels", null, value);
                OnPropertyChanged("organization_price_levels");
            }
        }

        /// <summary>
        ///     1:N organization_products
        /// </summary>
        [RelationshipSchemaName("organization_products")]
        public IEnumerable<Product> organization_products
        {
            get { return GetRelatedEntities<Product>("organization_products", null); }
            set
            {
                OnPropertyChanging("organization_products");
                SetRelatedEntities("organization_products", null, value);
                OnPropertyChanged("organization_products");
            }
        }

        /// <summary>
        ///     1:N organization_publisher
        /// </summary>
        [RelationshipSchemaName("organization_publisher")]
        public IEnumerable<Publisher> organization_publisher
        {
            get { return GetRelatedEntities<Publisher>("organization_publisher", null); }
            set
            {
                OnPropertyChanging("organization_publisher");
                SetRelatedEntities("organization_publisher", null, value);
                OnPropertyChanged("organization_publisher");
            }
        }

        /// <summary>
        ///     1:N organization_queueitems
        /// </summary>
        [RelationshipSchemaName("organization_queueitems")]
        public IEnumerable<QueueItem> organization_queueitems
        {
            get { return GetRelatedEntities<QueueItem>("organization_queueitems", null); }
            set
            {
                OnPropertyChanging("organization_queueitems");
                SetRelatedEntities("organization_queueitems", null, value);
                OnPropertyChanged("organization_queueitems");
            }
        }

        /// <summary>
        ///     1:N organization_queues
        /// </summary>
        [RelationshipSchemaName("organization_queues")]
        public IEnumerable<Queue> organization_queues
        {
            get { return GetRelatedEntities<Queue>("organization_queues", null); }
            set
            {
                OnPropertyChanging("organization_queues");
                SetRelatedEntities("organization_queues", null, value);
                OnPropertyChanged("organization_queues");
            }
        }

        /// <summary>
        ///     1:N organization_relationship_roles
        /// </summary>
        [RelationshipSchemaName("organization_relationship_roles")]
        public IEnumerable<RelationshipRole> organization_relationship_roles
        {
            get { return GetRelatedEntities<RelationshipRole>("organization_relationship_roles", null); }
            set
            {
                OnPropertyChanging("organization_relationship_roles");
                SetRelatedEntities("organization_relationship_roles", null, value);
                OnPropertyChanged("organization_relationship_roles");
            }
        }

        /// <summary>
        ///     1:N organization_resource_groups
        /// </summary>
        [RelationshipSchemaName("organization_resource_groups")]
        public IEnumerable<ResourceGroup> organization_resource_groups
        {
            get { return GetRelatedEntities<ResourceGroup>("organization_resource_groups", null); }
            set
            {
                OnPropertyChanging("organization_resource_groups");
                SetRelatedEntities("organization_resource_groups", null, value);
                OnPropertyChanged("organization_resource_groups");
            }
        }

        /// <summary>
        ///     1:N organization_resource_specs
        /// </summary>
        [RelationshipSchemaName("organization_resource_specs")]
        public IEnumerable<ResourceSpec> organization_resource_specs
        {
            get { return GetRelatedEntities<ResourceSpec>("organization_resource_specs", null); }
            set
            {
                OnPropertyChanging("organization_resource_specs");
                SetRelatedEntities("organization_resource_specs", null, value);
                OnPropertyChanged("organization_resource_specs");
            }
        }

        /// <summary>
        ///     1:N organization_resources
        /// </summary>
        [RelationshipSchemaName("organization_resources")]
        public IEnumerable<Resource> organization_resources
        {
            get { return GetRelatedEntities<Resource>("organization_resources", null); }
            set
            {
                OnPropertyChanging("organization_resources");
                SetRelatedEntities("organization_resources", null, value);
                OnPropertyChanged("organization_resources");
            }
        }

        /// <summary>
        ///     1:N organization_ribbon_customization
        /// </summary>
        [RelationshipSchemaName("organization_ribbon_customization")]
        public IEnumerable<RibbonCustomization> organization_ribbon_customization
        {
            get { return GetRelatedEntities<RibbonCustomization>("organization_ribbon_customization", null); }
            set
            {
                OnPropertyChanging("organization_ribbon_customization");
                SetRelatedEntities("organization_ribbon_customization", null, value);
                OnPropertyChanged("organization_ribbon_customization");
            }
        }

        /// <summary>
        ///     1:N organization_roles
        /// </summary>
        [RelationshipSchemaName("organization_roles")]
        public IEnumerable<Role> organization_roles
        {
            get { return GetRelatedEntities<Role>("organization_roles", null); }
            set
            {
                OnPropertyChanging("organization_roles");
                SetRelatedEntities("organization_roles", null, value);
                OnPropertyChanged("organization_roles");
            }
        }

        /// <summary>
        ///     1:N organization_sales_literature
        /// </summary>
        [RelationshipSchemaName("organization_sales_literature")]
        public IEnumerable<SalesLiterature> organization_sales_literature
        {
            get { return GetRelatedEntities<SalesLiterature>("organization_sales_literature", null); }
            set
            {
                OnPropertyChanging("organization_sales_literature");
                SetRelatedEntities("organization_sales_literature", null, value);
                OnPropertyChanged("organization_sales_literature");
            }
        }

        /// <summary>
        ///     1:N organization_saved_queries
        /// </summary>
        [RelationshipSchemaName("organization_saved_queries")]
        public IEnumerable<SavedQuery> organization_saved_queries
        {
            get { return GetRelatedEntities<SavedQuery>("organization_saved_queries", null); }
            set
            {
                OnPropertyChanging("organization_saved_queries");
                SetRelatedEntities("organization_saved_queries", null, value);
                OnPropertyChanged("organization_saved_queries");
            }
        }

        /// <summary>
        ///     1:N organization_saved_query_visualizations
        /// </summary>
        [RelationshipSchemaName("organization_saved_query_visualizations")]
        public IEnumerable<SavedQueryVisualization> organization_saved_query_visualizations
        {
            get { return GetRelatedEntities<SavedQueryVisualization>("organization_saved_query_visualizations", null); }
            set
            {
                OnPropertyChanging("organization_saved_query_visualizations");
                SetRelatedEntities("organization_saved_query_visualizations", null, value);
                OnPropertyChanged("organization_saved_query_visualizations");
            }
        }

        /// <summary>
        ///     1:N organization_sdkmessage
        /// </summary>
        [RelationshipSchemaName("organization_sdkmessage")]
        public IEnumerable<SdkMessage> organization_sdkmessage
        {
            get { return GetRelatedEntities<SdkMessage>("organization_sdkmessage", null); }
            set
            {
                OnPropertyChanging("organization_sdkmessage");
                SetRelatedEntities("organization_sdkmessage", null, value);
                OnPropertyChanged("organization_sdkmessage");
            }
        }

        /// <summary>
        ///     1:N organization_sdkmessagefilter
        /// </summary>
        [RelationshipSchemaName("organization_sdkmessagefilter")]
        public IEnumerable<SdkMessageFilter> organization_sdkmessagefilter
        {
            get { return GetRelatedEntities<SdkMessageFilter>("organization_sdkmessagefilter", null); }
            set
            {
                OnPropertyChanging("organization_sdkmessagefilter");
                SetRelatedEntities("organization_sdkmessagefilter", null, value);
                OnPropertyChanged("organization_sdkmessagefilter");
            }
        }

        /// <summary>
        ///     1:N organization_sdkmessagepair
        /// </summary>
        [RelationshipSchemaName("organization_sdkmessagepair")]
        public IEnumerable<SdkMessagePair> organization_sdkmessagepair
        {
            get { return GetRelatedEntities<SdkMessagePair>("organization_sdkmessagepair", null); }
            set
            {
                OnPropertyChanging("organization_sdkmessagepair");
                SetRelatedEntities("organization_sdkmessagepair", null, value);
                OnPropertyChanged("organization_sdkmessagepair");
            }
        }

        /// <summary>
        ///     1:N organization_sdkmessageprocessingstep
        /// </summary>
        [RelationshipSchemaName("organization_sdkmessageprocessingstep")]
        public IEnumerable<SdkMessageProcessingStep> organization_sdkmessageprocessingstep
        {
            get { return GetRelatedEntities<SdkMessageProcessingStep>("organization_sdkmessageprocessingstep", null); }
            set
            {
                OnPropertyChanging("organization_sdkmessageprocessingstep");
                SetRelatedEntities("organization_sdkmessageprocessingstep", null, value);
                OnPropertyChanged("organization_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        ///     1:N organization_sdkmessageprocessingstepimage
        /// </summary>
        [RelationshipSchemaName("organization_sdkmessageprocessingstepimage")]
        public IEnumerable<SdkMessageProcessingStepImage> organization_sdkmessageprocessingstepimage
        {
            get
            {
                return GetRelatedEntities<SdkMessageProcessingStepImage>("organization_sdkmessageprocessingstepimage",
                    null);
            }
            set
            {
                OnPropertyChanging("organization_sdkmessageprocessingstepimage");
                SetRelatedEntities("organization_sdkmessageprocessingstepimage", null, value);
                OnPropertyChanged("organization_sdkmessageprocessingstepimage");
            }
        }

        /// <summary>
        ///     1:N organization_sdkmessageprocessingstepsecureconfig
        /// </summary>
        [RelationshipSchemaName("organization_sdkmessageprocessingstepsecureconfig")]
        public IEnumerable<SdkMessageProcessingStepSecureConfig> organization_sdkmessageprocessingstepsecureconfig
        {
            get
            {
                return
                    GetRelatedEntities<SdkMessageProcessingStepSecureConfig>(
                        "organization_sdkmessageprocessingstepsecureconfig", null);
            }
            set
            {
                OnPropertyChanging("organization_sdkmessageprocessingstepsecureconfig");
                SetRelatedEntities("organization_sdkmessageprocessingstepsecureconfig", null, value);
                OnPropertyChanged("organization_sdkmessageprocessingstepsecureconfig");
            }
        }

        /// <summary>
        ///     1:N organization_sdkmessagerequest
        /// </summary>
        [RelationshipSchemaName("organization_sdkmessagerequest")]
        public IEnumerable<SdkMessageRequest> organization_sdkmessagerequest
        {
            get { return GetRelatedEntities<SdkMessageRequest>("organization_sdkmessagerequest", null); }
            set
            {
                OnPropertyChanging("organization_sdkmessagerequest");
                SetRelatedEntities("organization_sdkmessagerequest", null, value);
                OnPropertyChanged("organization_sdkmessagerequest");
            }
        }

        /// <summary>
        ///     1:N organization_sdkmessagerequestfield
        /// </summary>
        [RelationshipSchemaName("organization_sdkmessagerequestfield")]
        public IEnumerable<SdkMessageRequestField> organization_sdkmessagerequestfield
        {
            get { return GetRelatedEntities<SdkMessageRequestField>("organization_sdkmessagerequestfield", null); }
            set
            {
                OnPropertyChanging("organization_sdkmessagerequestfield");
                SetRelatedEntities("organization_sdkmessagerequestfield", null, value);
                OnPropertyChanged("organization_sdkmessagerequestfield");
            }
        }

        /// <summary>
        ///     1:N organization_sdkmessageresponse
        /// </summary>
        [RelationshipSchemaName("organization_sdkmessageresponse")]
        public IEnumerable<SdkMessageResponse> organization_sdkmessageresponse
        {
            get { return GetRelatedEntities<SdkMessageResponse>("organization_sdkmessageresponse", null); }
            set
            {
                OnPropertyChanging("organization_sdkmessageresponse");
                SetRelatedEntities("organization_sdkmessageresponse", null, value);
                OnPropertyChanged("organization_sdkmessageresponse");
            }
        }

        /// <summary>
        ///     1:N organization_sdkmessageresponsefield
        /// </summary>
        [RelationshipSchemaName("organization_sdkmessageresponsefield")]
        public IEnumerable<SdkMessageResponseField> organization_sdkmessageresponsefield
        {
            get { return GetRelatedEntities<SdkMessageResponseField>("organization_sdkmessageresponsefield", null); }
            set
            {
                OnPropertyChanging("organization_sdkmessageresponsefield");
                SetRelatedEntities("organization_sdkmessageresponsefield", null, value);
                OnPropertyChanged("organization_sdkmessageresponsefield");
            }
        }

        /// <summary>
        ///     1:N organization_serviceendpoint
        /// </summary>
        [RelationshipSchemaName("organization_serviceendpoint")]
        public IEnumerable<ServiceEndpoint> organization_serviceendpoint
        {
            get { return GetRelatedEntities<ServiceEndpoint>("organization_serviceendpoint", null); }
            set
            {
                OnPropertyChanging("organization_serviceendpoint");
                SetRelatedEntities("organization_serviceendpoint", null, value);
                OnPropertyChanged("organization_serviceendpoint");
            }
        }

        /// <summary>
        ///     1:N organization_services
        /// </summary>
        [RelationshipSchemaName("organization_services")]
        public IEnumerable<Service> organization_services
        {
            get { return GetRelatedEntities<Service>("organization_services", null); }
            set
            {
                OnPropertyChanging("organization_services");
                SetRelatedEntities("organization_services", null, value);
                OnPropertyChanged("organization_services");
            }
        }

        /// <summary>
        ///     1:N organization_sitemap
        /// </summary>
        [RelationshipSchemaName("organization_sitemap")]
        public IEnumerable<SiteMap> organization_sitemap
        {
            get { return GetRelatedEntities<SiteMap>("organization_sitemap", null); }
            set
            {
                OnPropertyChanging("organization_sitemap");
                SetRelatedEntities("organization_sitemap", null, value);
                OnPropertyChanged("organization_sitemap");
            }
        }

        /// <summary>
        ///     1:N organization_sites
        /// </summary>
        [RelationshipSchemaName("organization_sites")]
        public IEnumerable<Site> organization_sites
        {
            get { return GetRelatedEntities<Site>("organization_sites", null); }
            set
            {
                OnPropertyChanging("organization_sites");
                SetRelatedEntities("organization_sites", null, value);
                OnPropertyChanged("organization_sites");
            }
        }

        /// <summary>
        ///     1:N organization_solution
        /// </summary>
        [RelationshipSchemaName("organization_solution")]
        public IEnumerable<Solution> organization_solution
        {
            get { return GetRelatedEntities<Solution>("organization_solution", null); }
            set
            {
                OnPropertyChanging("organization_solution");
                SetRelatedEntities("organization_solution", null, value);
                OnPropertyChanged("organization_solution");
            }
        }

        /// <summary>
        ///     1:N organization_subjects
        /// </summary>
        [RelationshipSchemaName("organization_subjects")]
        public IEnumerable<Subject> organization_subjects
        {
            get { return GetRelatedEntities<Subject>("organization_subjects", null); }
            set
            {
                OnPropertyChanging("organization_subjects");
                SetRelatedEntities("organization_subjects", null, value);
                OnPropertyChanged("organization_subjects");
            }
        }

        /// <summary>
        ///     1:N organization_system_users
        /// </summary>
        [RelationshipSchemaName("organization_system_users")]
        public IEnumerable<SystemUser> organization_system_users
        {
            get { return GetRelatedEntities<SystemUser>("organization_system_users", null); }
            set
            {
                OnPropertyChanging("organization_system_users");
                SetRelatedEntities("organization_system_users", null, value);
                OnPropertyChanged("organization_system_users");
            }
        }

        /// <summary>
        ///     1:N organization_systemforms
        /// </summary>
        [RelationshipSchemaName("organization_systemforms")]
        public IEnumerable<SystemForm> organization_systemforms
        {
            get { return GetRelatedEntities<SystemForm>("organization_systemforms", null); }
            set
            {
                OnPropertyChanging("organization_systemforms");
                SetRelatedEntities("organization_systemforms", null, value);
                OnPropertyChanged("organization_systemforms");
            }
        }

        /// <summary>
        ///     1:N organization_teams
        /// </summary>
        [RelationshipSchemaName("organization_teams")]
        public IEnumerable<Team> organization_teams
        {
            get { return GetRelatedEntities<Team>("organization_teams", null); }
            set
            {
                OnPropertyChanging("organization_teams");
                SetRelatedEntities("organization_teams", null, value);
                OnPropertyChanged("organization_teams");
            }
        }

        /// <summary>
        ///     1:N organization_territories
        /// </summary>
        [RelationshipSchemaName("organization_territories")]
        public IEnumerable<Territory> organization_territories
        {
            get { return GetRelatedEntities<Territory>("organization_territories", null); }
            set
            {
                OnPropertyChanging("organization_territories");
                SetRelatedEntities("organization_territories", null, value);
                OnPropertyChanged("organization_territories");
            }
        }

        /// <summary>
        ///     1:N organization_tracelog
        /// </summary>
        [RelationshipSchemaName("organization_tracelog")]
        public IEnumerable<TraceLog> organization_tracelog
        {
            get { return GetRelatedEntities<TraceLog>("organization_tracelog", null); }
            set
            {
                OnPropertyChanging("organization_tracelog");
                SetRelatedEntities("organization_tracelog", null, value);
                OnPropertyChanged("organization_tracelog");
            }
        }

        /// <summary>
        ///     1:N organization_transactioncurrencies
        /// </summary>
        [RelationshipSchemaName("organization_transactioncurrencies")]
        public IEnumerable<TransactionCurrency> organization_transactioncurrencies
        {
            get { return GetRelatedEntities<TransactionCurrency>("organization_transactioncurrencies", null); }
            set
            {
                OnPropertyChanging("organization_transactioncurrencies");
                SetRelatedEntities("organization_transactioncurrencies", null, value);
                OnPropertyChanged("organization_transactioncurrencies");
            }
        }

        /// <summary>
        ///     1:N organization_uof_schedules
        /// </summary>
        [RelationshipSchemaName("organization_uof_schedules")]
        public IEnumerable<UoMSchedule> organization_uof_schedules
        {
            get { return GetRelatedEntities<UoMSchedule>("organization_uof_schedules", null); }
            set
            {
                OnPropertyChanging("organization_uof_schedules");
                SetRelatedEntities("organization_uof_schedules", null, value);
                OnPropertyChanged("organization_uof_schedules");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_organization
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_organization")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_organization
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_organization", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_organization");
                SetRelatedEntities("userentityinstancedata_organization", null, value);
                OnPropertyChanged("userentityinstancedata_organization");
            }
        }

        /// <summary>
        ///     1:N webresource_organization
        /// </summary>
        [RelationshipSchemaName("webresource_organization")]
        public IEnumerable<WebResource> webresource_organization
        {
            get { return GetRelatedEntities<WebResource>("webresource_organization", null); }
            set
            {
                OnPropertyChanging("webresource_organization");
                SetRelatedEntities("webresource_organization", null, value);
                OnPropertyChanged("webresource_organization");
            }
        }

        /// <summary>
        ///     N:1 basecurrency_organization
        /// </summary>
        [AttributeLogicalName("basecurrencyid")]
        [RelationshipSchemaName("basecurrency_organization")]
        public TransactionCurrency basecurrency_organization
        {
            get { return GetRelatedEntity<TransactionCurrency>("basecurrency_organization", null); }
            set
            {
                OnPropertyChanging("basecurrency_organization");
                SetRelatedEntity("basecurrency_organization", null, value);
                OnPropertyChanged("basecurrency_organization");
            }
        }

        /// <summary>
        ///     N:1 calendar_organization
        /// </summary>
        [AttributeLogicalName("businessclosurecalendarid")]
        [RelationshipSchemaName("calendar_organization")]
        public Calendar calendar_organization
        {
            get { return GetRelatedEntity<Calendar>("calendar_organization", null); }
            set
            {
                OnPropertyChanging("calendar_organization");
                SetRelatedEntity("calendar_organization", null, value);
                OnPropertyChanged("calendar_organization");
            }
        }

        /// <summary>
        ///     N:1 EmailServerProfile_Organization
        /// </summary>
        [AttributeLogicalName("defaultemailserverprofileid")]
        [RelationshipSchemaName("EmailServerProfile_Organization")]
        public EmailServerProfile EmailServerProfile_Organization
        {
            get { return GetRelatedEntity<EmailServerProfile>("EmailServerProfile_Organization", null); }
            set
            {
                OnPropertyChanging("EmailServerProfile_Organization");
                SetRelatedEntity("EmailServerProfile_Organization", null, value);
                OnPropertyChanged("EmailServerProfile_Organization");
            }
        }

        /// <summary>
        ///     N:1 lk_organization_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_organization_createdonbehalfby")]
        public SystemUser lk_organization_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_organization_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_organization_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_organization_modifiedonbehalfby")]
        public SystemUser lk_organization_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_organization_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_organizationbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_organizationbase_createdby")]
        public SystemUser lk_organizationbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_organizationbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_organizationbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_organizationbase_modifiedby")]
        public SystemUser lk_organizationbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_organizationbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 Template_Organization
        /// </summary>
        [AttributeLogicalName("acknowledgementtemplateid")]
        [RelationshipSchemaName("Template_Organization")]
        public Template Template_Organization
        {
            get { return GetRelatedEntity<Template>("Template_Organization", null); }
            set
            {
                OnPropertyChanging("Template_Organization");
                SetRelatedEntity("Template_Organization", null, value);
                OnPropertyChanged("Template_Organization");
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