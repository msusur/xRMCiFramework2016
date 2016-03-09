using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Xrm.Framework.CI.Common.Entities
{
    /// <summary>
    ///     User's preferred settings.
    /// </summary>
    [DataContract]
    [EntityLogicalName("usersettings")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class UserSettings : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "usersettings";

        public const int EntityTypeCode = 150;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public UserSettings() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Normal polling frequency used for address book synchronization in Microsoft Office Outlook.
        /// </summary>
        [AttributeLogicalName("addressbooksyncinterval")]
        public int? AddressBookSyncInterval
        {
            get { return GetAttributeValue<int?>("addressbooksyncinterval"); }
            set
            {
                OnPropertyChanging("AddressBookSyncInterval");
                SetAttributeValue("addressbooksyncinterval", value);
                OnPropertyChanged("AddressBookSyncInterval");
            }
        }

        /// <summary>
        ///     Default mode, such as simple or detailed, for advanced find.
        /// </summary>
        [AttributeLogicalName("advancedfindstartupmode")]
        public int? AdvancedFindStartupMode
        {
            get { return GetAttributeValue<int?>("advancedfindstartupmode"); }
            set
            {
                OnPropertyChanging("AdvancedFindStartupMode");
                SetAttributeValue("advancedfindstartupmode", value);
                OnPropertyChanged("AdvancedFindStartupMode");
            }
        }

        /// <summary>
        ///     Indicates whether a user wants to specify email credentials.
        /// </summary>
        [AttributeLogicalName("allowemailcredentials")]
        [Obsolete]
        public bool? AllowEmailCredentials
        {
            get { return GetAttributeValue<bool?>("allowemailcredentials"); }
        }

        /// <summary>
        ///     AM designator to use in Microsoft Dynamics CRM.
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
        ///     Auto-create contact on client promote
        /// </summary>
        [AttributeLogicalName("autocreatecontactonpromote")]
        public int? AutoCreateContactOnPromote
        {
            get { return GetAttributeValue<int?>("autocreatecontactonpromote"); }
            set
            {
                OnPropertyChanging("AutoCreateContactOnPromote");
                SetAttributeValue("autocreatecontactonpromote", value);
                OnPropertyChanged("AutoCreateContactOnPromote");
            }
        }

        /// <summary>
        ///     Unique identifier of the business unit with which the user is associated.
        /// </summary>
        [AttributeLogicalName("businessunitid")]
        public Guid? BusinessUnitId
        {
            get { return GetAttributeValue<Guid?>("businessunitid"); }
            set
            {
                OnPropertyChanging("BusinessUnitId");
                SetAttributeValue("businessunitid", value);
                OnPropertyChanged("BusinessUnitId");
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
        ///     Unique identifier of the user who created the user settings.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the user settings object was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the usersettings.
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
        [Obsolete]
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
        ///     Information about how currency symbols are placed in Microsoft Dynamics CRM.
        /// </summary>
        [AttributeLogicalName("currencyformatcode")]
        public int? CurrencyFormatCode
        {
            get { return GetAttributeValue<int?>("currencyformatcode"); }
            set
            {
                OnPropertyChanging("CurrencyFormatCode");
                SetAttributeValue("currencyformatcode", value);
                OnPropertyChanged("CurrencyFormatCode");
            }
        }

        /// <summary>
        ///     Symbol used for currency in Microsoft Dynamics CRM.
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
        ///     Information that specifies the level of data validation in excel worksheets exported in a format suitable for
        ///     import.
        /// </summary>
        [AttributeLogicalName("datavalidationmodeforexporttoexcel")]
        public OptionSetValue DataValidationModeForExportToExcel
        {
            get { return GetAttributeValue<OptionSetValue>("datavalidationmodeforexporttoexcel"); }
            set
            {
                OnPropertyChanging("DataValidationModeForExportToExcel");
                SetAttributeValue("datavalidationmodeforexporttoexcel", value);
                OnPropertyChanged("DataValidationModeForExportToExcel");
            }
        }

        /// <summary>
        ///     Information about how the date is displayed in Microsoft Dynamics CRM.
        /// </summary>
        [AttributeLogicalName("dateformatcode")]
        public int? DateFormatCode
        {
            get { return GetAttributeValue<int?>("dateformatcode"); }
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
        ///     Character used to separate the month, the day, and the year in dates in Microsoft Dynamics CRM.
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
        ///     Default calendar view for the user.
        /// </summary>
        [AttributeLogicalName("defaultcalendarview")]
        public int? DefaultCalendarView
        {
            get { return GetAttributeValue<int?>("defaultcalendarview"); }
            set
            {
                OnPropertyChanging("DefaultCalendarView");
                SetAttributeValue("defaultcalendarview", value);
                OnPropertyChanged("DefaultCalendarView");
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
        ///     Unique identifier of the default dashboard.
        /// </summary>
        [AttributeLogicalName("defaultdashboardid")]
        public Guid? DefaultDashboardId
        {
            get { return GetAttributeValue<Guid?>("defaultdashboardid"); }
            set
            {
                OnPropertyChanging("DefaultDashboardId");
                SetAttributeValue("defaultdashboardid", value);
                OnPropertyChanged("DefaultDashboardId");
            }
        }

        /// <summary>
        ///     Email password.
        /// </summary>
        [AttributeLogicalName("emailpassword")]
        [Obsolete]
        public string EmailPassword
        {
            get { return GetAttributeValue<string>("emailpassword"); }
        }

        /// <summary>
        ///     Email user name.
        /// </summary>
        [AttributeLogicalName("emailusername")]
        [Obsolete]
        public string EmailUsername
        {
            get { return GetAttributeValue<string>("emailusername"); }
        }

        /// <summary>
        ///     Indicates the form mode to be used.
        /// </summary>
        [AttributeLogicalName("entityformmode")]
        public OptionSetValue EntityFormMode
        {
            get { return GetAttributeValue<OptionSetValue>("entityformmode"); }
            set
            {
                OnPropertyChanging("EntityFormMode");
                SetAttributeValue("entityformmode", value);
                OnPropertyChanged("EntityFormMode");
            }
        }

        /// <summary>
        ///     Order in which names are to be displayed in Microsoft Dynamics CRM.
        /// </summary>
        [AttributeLogicalName("fullnameconventioncode")]
        public int? FullNameConventionCode
        {
            get { return GetAttributeValue<int?>("fullnameconventioncode"); }
            set
            {
                OnPropertyChanging("FullNameConventionCode");
                SetAttributeValue("fullnameconventioncode", value);
                OnPropertyChanged("FullNameConventionCode");
            }
        }

        /// <summary>
        ///     Information that specifies whether the Get Started pane in lists is enabled.
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
        ///     Unique identifier of the Help language.
        /// </summary>
        [AttributeLogicalName("helplanguageid")]
        public int? HelpLanguageId
        {
            get { return GetAttributeValue<int?>("helplanguageid"); }
            set
            {
                OnPropertyChanging("HelpLanguageId");
                SetAttributeValue("helplanguageid", value);
                OnPropertyChanged("HelpLanguageId");
            }
        }

        /// <summary>
        ///     Web site home page for the user.
        /// </summary>
        [AttributeLogicalName("homepagearea")]
        public string HomepageArea
        {
            get { return GetAttributeValue<string>("homepagearea"); }
            set
            {
                OnPropertyChanging("HomepageArea");
                SetAttributeValue("homepagearea", value);
                OnPropertyChanged("HomepageArea");
            }
        }

        /// <summary>
        ///     Configuration of the home page layout.
        /// </summary>
        [AttributeLogicalName("homepagelayout")]
        public string HomepageLayout
        {
            get { return GetAttributeValue<string>("homepagelayout"); }
            set
            {
                OnPropertyChanging("HomepageLayout");
                SetAttributeValue("homepagelayout", value);
                OnPropertyChanged("HomepageLayout");
            }
        }

        /// <summary>
        ///     Web site page for the user.
        /// </summary>
        [AttributeLogicalName("homepagesubarea")]
        public string HomepageSubarea
        {
            get { return GetAttributeValue<string>("homepagesubarea"); }
            set
            {
                OnPropertyChanging("HomepageSubarea");
                SetAttributeValue("homepagesubarea", value);
                OnPropertyChanged("HomepageSubarea");
            }
        }

        /// <summary>
        ///     Information that specifies whether a user account is to ignore unsolicited email (deprecated).
        /// </summary>
        [AttributeLogicalName("ignoreunsolicitedemail")]
        public bool? IgnoreUnsolicitedEmail
        {
            get { return GetAttributeValue<bool?>("ignoreunsolicitedemail"); }
            set
            {
                OnPropertyChanging("IgnoreUnsolicitedEmail");
                SetAttributeValue("ignoreunsolicitedemail", value);
                OnPropertyChanged("IgnoreUnsolicitedEmail");
            }
        }

        /// <summary>
        ///     Incoming email filtering method.
        /// </summary>
        [AttributeLogicalName("incomingemailfilteringmethod")]
        public OptionSetValue IncomingEmailFilteringMethod
        {
            get { return GetAttributeValue<OptionSetValue>("incomingemailfilteringmethod"); }
            set
            {
                OnPropertyChanging("IncomingEmailFilteringMethod");
                SetAttributeValue("incomingemailfilteringmethod", value);
                OnPropertyChanged("IncomingEmailFilteringMethod");
            }
        }

        /// <summary>
        ///     Enable or disable country code selection .
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
        ///     Indicates if duplicate detection is enabled when going online.
        /// </summary>
        [AttributeLogicalName("isduplicatedetectionenabledwhengoingonline")]
        public bool? IsDuplicateDetectionEnabledWhenGoingOnline
        {
            get { return GetAttributeValue<bool?>("isduplicatedetectionenabledwhengoingonline"); }
            set
            {
                OnPropertyChanging("IsDuplicateDetectionEnabledWhenGoingOnline");
                SetAttributeValue("isduplicatedetectionenabledwhengoingonline", value);
                OnPropertyChanged("IsDuplicateDetectionEnabledWhenGoingOnline");
            }
        }

        /// <summary>
        ///     Indicates if send as other user privilege is enabled or not.
        /// </summary>
        [AttributeLogicalName("issendasallowed")]
        public bool? IsSendAsAllowed
        {
            get { return GetAttributeValue<bool?>("issendasallowed"); }
            set
            {
                OnPropertyChanging("IsSendAsAllowed");
                SetAttributeValue("issendasallowed", value);
                OnPropertyChanged("IsSendAsAllowed");
            }
        }

        /// <summary>
        ///     Shows the last time when the traces were read from the database.
        /// </summary>
        [AttributeLogicalName("lastalertsviewedtime")]
        public DateTime? LastAlertsViewedTime
        {
            get { return GetAttributeValue<DateTime?>("lastalertsviewedtime"); }
            set
            {
                OnPropertyChanging("LastAlertsViewedTime");
                SetAttributeValue("lastalertsviewedtime", value);
                OnPropertyChanged("LastAlertsViewedTime");
            }
        }

        /// <summary>
        ///     Unique identifier of the user locale.
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
        ///     Information that specifies how Long Date is displayed throughout Microsoft CRM.
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
        ///     Unique identifier of the user who last modified the user settings.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the user settings object was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the usersettings.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Information that specifies how negative currency numbers are displayed in Microsoft Dynamics CRM.
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
        ///     Information that specifies how negative numbers are displayed in Microsoft Dynamics CRM.
        /// </summary>
        [AttributeLogicalName("negativeformatcode")]
        public int? NegativeFormatCode
        {
            get { return GetAttributeValue<int?>("negativeformatcode"); }
            set
            {
                OnPropertyChanging("NegativeFormatCode");
                SetAttributeValue("negativeformatcode", value);
                OnPropertyChanged("NegativeFormatCode");
            }
        }

        /// <summary>
        ///     Next tracking number.
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
        ///     Information that specifies how numbers are grouped in Microsoft Dynamics CRM.
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
        ///     Normal polling frequency used for background offline synchronization in Microsoft Office Outlook.
        /// </summary>
        [AttributeLogicalName("offlinesyncinterval")]
        public int? OfflineSyncInterval
        {
            get { return GetAttributeValue<int?>("offlinesyncinterval"); }
            set
            {
                OnPropertyChanging("OfflineSyncInterval");
                SetAttributeValue("offlinesyncinterval", value);
                OnPropertyChanged("OfflineSyncInterval");
            }
        }

        /// <summary>
        ///     Normal polling frequency used for record synchronization in Microsoft Office Outlook.
        /// </summary>
        [AttributeLogicalName("outlooksyncinterval")]
        public int? OutlookSyncInterval
        {
            get { return GetAttributeValue<int?>("outlooksyncinterval"); }
            set
            {
                OnPropertyChanging("OutlookSyncInterval");
                SetAttributeValue("outlooksyncinterval", value);
                OnPropertyChanged("OutlookSyncInterval");
            }
        }

        /// <summary>
        ///     Information that specifies how many items to list on a page in list views.
        /// </summary>
        [AttributeLogicalName("paginglimit")]
        public int? PagingLimit
        {
            get { return GetAttributeValue<int?>("paginglimit"); }
            set
            {
                OnPropertyChanging("PagingLimit");
                SetAttributeValue("paginglimit", value);
                OnPropertyChanged("PagingLimit");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("personalizationsettings")]
        public string PersonalizationSettings
        {
            get { return GetAttributeValue<string>("personalizationsettings"); }
            set
            {
                OnPropertyChanging("PersonalizationSettings");
                SetAttributeValue("personalizationsettings", value);
                OnPropertyChanged("PersonalizationSettings");
            }
        }

        /// <summary>
        ///     PM designator to use in Microsoft Dynamics CRM.
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
        [Obsolete]
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
        ///     Picklist for selecting the user preference for reporting scripting errors.
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
        ///     Information that specifies whether to display the week number in calendar displays in Microsoft Dynamics CRM.
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
        ///     Indicates if the company field in Microsoft Office Outlook items are set during Outlook synchronization.
        /// </summary>
        [AttributeLogicalName("synccontactcompany")]
        public bool? SyncContactCompany
        {
            get { return GetAttributeValue<bool?>("synccontactcompany"); }
            set
            {
                OnPropertyChanging("SyncContactCompany");
                SetAttributeValue("synccontactcompany", value);
                OnPropertyChanged("SyncContactCompany");
            }
        }

        /// <summary>
        ///     Unique identifier of the user.
        /// </summary>
        [AttributeLogicalName("systemuserid")]
        public Guid? SystemUserId
        {
            get { return GetAttributeValue<Guid?>("systemuserid"); }
            set
            {
                OnPropertyChanging("SystemUserId");
                SetAttributeValue("systemuserid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("SystemUserId");
            }
        }

        [AttributeLogicalName("systemuserid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { SystemUserId = value; }
        }

        /// <summary>
        ///     Information that specifies how the time is displayed in Microsoft Dynamics CRM.
        /// </summary>
        [AttributeLogicalName("timeformatcode")]
        public int? TimeFormatCode
        {
            get { return GetAttributeValue<int?>("timeformatcode"); }
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
        ///     Text for how time is displayed in Microsoft Dynamics CRM.
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
        ///     Local time zone adjustment for the user. System calculated based on the time zone selected.
        /// </summary>
        [AttributeLogicalName("timezonebias")]
        public int? TimeZoneBias
        {
            get { return GetAttributeValue<int?>("timezonebias"); }
            set
            {
                OnPropertyChanging("TimeZoneBias");
                SetAttributeValue("timezonebias", value);
                OnPropertyChanged("TimeZoneBias");
            }
        }

        /// <summary>
        ///     Local time zone for the user.
        /// </summary>
        [AttributeLogicalName("timezonecode")]
        public int? TimeZoneCode
        {
            get { return GetAttributeValue<int?>("timezonecode"); }
            set
            {
                OnPropertyChanging("TimeZoneCode");
                SetAttributeValue("timezonecode", value);
                OnPropertyChanged("TimeZoneCode");
            }
        }

        /// <summary>
        ///     Local time zone daylight adjustment for the user. System calculated based on the time zone selected.
        /// </summary>
        [AttributeLogicalName("timezonedaylightbias")]
        public int? TimeZoneDaylightBias
        {
            get { return GetAttributeValue<int?>("timezonedaylightbias"); }
            set
            {
                OnPropertyChanging("TimeZoneDaylightBias");
                SetAttributeValue("timezonedaylightbias", value);
                OnPropertyChanged("TimeZoneDaylightBias");
            }
        }

        /// <summary>
        ///     Local time zone daylight day for the user. System calculated based on the time zone selected.
        /// </summary>
        [AttributeLogicalName("timezonedaylightday")]
        public int? TimeZoneDaylightDay
        {
            get { return GetAttributeValue<int?>("timezonedaylightday"); }
            set
            {
                OnPropertyChanging("TimeZoneDaylightDay");
                SetAttributeValue("timezonedaylightday", value);
                OnPropertyChanged("TimeZoneDaylightDay");
            }
        }

        /// <summary>
        ///     Local time zone daylight day of week for the user. System calculated based on the time zone selected in Options.
        /// </summary>
        [AttributeLogicalName("timezonedaylightdayofweek")]
        public int? TimeZoneDaylightDayOfWeek
        {
            get { return GetAttributeValue<int?>("timezonedaylightdayofweek"); }
            set
            {
                OnPropertyChanging("TimeZoneDaylightDayOfWeek");
                SetAttributeValue("timezonedaylightdayofweek", value);
                OnPropertyChanged("TimeZoneDaylightDayOfWeek");
            }
        }

        /// <summary>
        ///     Local time zone daylight hour for the user. System calculated based on the time zone selected.
        /// </summary>
        [AttributeLogicalName("timezonedaylighthour")]
        public int? TimeZoneDaylightHour
        {
            get { return GetAttributeValue<int?>("timezonedaylighthour"); }
            set
            {
                OnPropertyChanging("TimeZoneDaylightHour");
                SetAttributeValue("timezonedaylighthour", value);
                OnPropertyChanged("TimeZoneDaylightHour");
            }
        }

        /// <summary>
        ///     Local time zone daylight minute for the user. System calculated based on the time zone selected.
        /// </summary>
        [AttributeLogicalName("timezonedaylightminute")]
        public int? TimeZoneDaylightMinute
        {
            get { return GetAttributeValue<int?>("timezonedaylightminute"); }
            set
            {
                OnPropertyChanging("TimeZoneDaylightMinute");
                SetAttributeValue("timezonedaylightminute", value);
                OnPropertyChanged("TimeZoneDaylightMinute");
            }
        }

        /// <summary>
        ///     Local time zone daylight month for the user. System calculated based on the time zone selected.
        /// </summary>
        [AttributeLogicalName("timezonedaylightmonth")]
        public int? TimeZoneDaylightMonth
        {
            get { return GetAttributeValue<int?>("timezonedaylightmonth"); }
            set
            {
                OnPropertyChanging("TimeZoneDaylightMonth");
                SetAttributeValue("timezonedaylightmonth", value);
                OnPropertyChanged("TimeZoneDaylightMonth");
            }
        }

        /// <summary>
        ///     Local time zone daylight second for the user. System calculated based on the time zone selected.
        /// </summary>
        [AttributeLogicalName("timezonedaylightsecond")]
        public int? TimeZoneDaylightSecond
        {
            get { return GetAttributeValue<int?>("timezonedaylightsecond"); }
            set
            {
                OnPropertyChanging("TimeZoneDaylightSecond");
                SetAttributeValue("timezonedaylightsecond", value);
                OnPropertyChanged("TimeZoneDaylightSecond");
            }
        }

        /// <summary>
        ///     Local time zone daylight year for the user. System calculated based on the time zone selected.
        /// </summary>
        [AttributeLogicalName("timezonedaylightyear")]
        public int? TimeZoneDaylightYear
        {
            get { return GetAttributeValue<int?>("timezonedaylightyear"); }
            set
            {
                OnPropertyChanging("TimeZoneDaylightYear");
                SetAttributeValue("timezonedaylightyear", value);
                OnPropertyChanged("TimeZoneDaylightYear");
            }
        }

        /// <summary>
        ///     Local time zone standard time bias for the user. System calculated based on the time zone selected.
        /// </summary>
        [AttributeLogicalName("timezonestandardbias")]
        public int? TimeZoneStandardBias
        {
            get { return GetAttributeValue<int?>("timezonestandardbias"); }
            set
            {
                OnPropertyChanging("TimeZoneStandardBias");
                SetAttributeValue("timezonestandardbias", value);
                OnPropertyChanged("TimeZoneStandardBias");
            }
        }

        /// <summary>
        ///     Local time zone standard day for the user. System calculated based on the time zone selected.
        /// </summary>
        [AttributeLogicalName("timezonestandardday")]
        public int? TimeZoneStandardDay
        {
            get { return GetAttributeValue<int?>("timezonestandardday"); }
            set
            {
                OnPropertyChanging("TimeZoneStandardDay");
                SetAttributeValue("timezonestandardday", value);
                OnPropertyChanged("TimeZoneStandardDay");
            }
        }

        /// <summary>
        ///     Local time zone standard day of week for the user. System calculated based on the time zone selected.
        /// </summary>
        [AttributeLogicalName("timezonestandarddayofweek")]
        public int? TimeZoneStandardDayOfWeek
        {
            get { return GetAttributeValue<int?>("timezonestandarddayofweek"); }
            set
            {
                OnPropertyChanging("TimeZoneStandardDayOfWeek");
                SetAttributeValue("timezonestandarddayofweek", value);
                OnPropertyChanged("TimeZoneStandardDayOfWeek");
            }
        }

        /// <summary>
        ///     Local time zone standard hour for the user. System calculated based on the time zone selected.
        /// </summary>
        [AttributeLogicalName("timezonestandardhour")]
        public int? TimeZoneStandardHour
        {
            get { return GetAttributeValue<int?>("timezonestandardhour"); }
            set
            {
                OnPropertyChanging("TimeZoneStandardHour");
                SetAttributeValue("timezonestandardhour", value);
                OnPropertyChanged("TimeZoneStandardHour");
            }
        }

        /// <summary>
        ///     Local time zone standard minute for the user. System calculated based on the time zone selected.
        /// </summary>
        [AttributeLogicalName("timezonestandardminute")]
        public int? TimeZoneStandardMinute
        {
            get { return GetAttributeValue<int?>("timezonestandardminute"); }
            set
            {
                OnPropertyChanging("TimeZoneStandardMinute");
                SetAttributeValue("timezonestandardminute", value);
                OnPropertyChanged("TimeZoneStandardMinute");
            }
        }

        /// <summary>
        ///     Local time zone standard month for the user. System calculated based on the time zone selected.
        /// </summary>
        [AttributeLogicalName("timezonestandardmonth")]
        public int? TimeZoneStandardMonth
        {
            get { return GetAttributeValue<int?>("timezonestandardmonth"); }
            set
            {
                OnPropertyChanging("TimeZoneStandardMonth");
                SetAttributeValue("timezonestandardmonth", value);
                OnPropertyChanged("TimeZoneStandardMonth");
            }
        }

        /// <summary>
        ///     Local time zone standard second for the user. System calculated based on the time zone selected.
        /// </summary>
        [AttributeLogicalName("timezonestandardsecond")]
        public int? TimeZoneStandardSecond
        {
            get { return GetAttributeValue<int?>("timezonestandardsecond"); }
            set
            {
                OnPropertyChanging("TimeZoneStandardSecond");
                SetAttributeValue("timezonestandardsecond", value);
                OnPropertyChanged("TimeZoneStandardSecond");
            }
        }

        /// <summary>
        ///     Local time zone standard year for the user. System calculated based on the time zone selected.
        /// </summary>
        [AttributeLogicalName("timezonestandardyear")]
        public int? TimeZoneStandardYear
        {
            get { return GetAttributeValue<int?>("timezonestandardyear"); }
            set
            {
                OnPropertyChanging("TimeZoneStandardYear");
                SetAttributeValue("timezonestandardyear", value);
                OnPropertyChanged("TimeZoneStandardYear");
            }
        }

        /// <summary>
        ///     Tracking token ID.
        /// </summary>
        [AttributeLogicalName("trackingtokenid")]
        public int? TrackingTokenId
        {
            get { return GetAttributeValue<int?>("trackingtokenid"); }
            set
            {
                OnPropertyChanging("TrackingTokenId");
                SetAttributeValue("trackingtokenid", value);
                OnPropertyChanged("TrackingTokenId");
            }
        }

        /// <summary>
        ///     Unique identifier of the default currency of the user.
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
        ///     Unique identifier of the language in which to view the user interface (UI).
        /// </summary>
        [AttributeLogicalName("uilanguageid")]
        public int? UILanguageId
        {
            get { return GetAttributeValue<int?>("uilanguageid"); }
            set
            {
                OnPropertyChanging("UILanguageId");
                SetAttributeValue("uilanguageid", value);
                OnPropertyChanged("UILanguageId");
            }
        }

        /// <summary>
        ///     Indicates whether to use the Microsoft Dynamics CRM appointment form within Microsoft Office Outlook for creating
        ///     new appointments.
        /// </summary>
        [AttributeLogicalName("usecrmformforappointment")]
        public bool? UseCrmFormForAppointment
        {
            get { return GetAttributeValue<bool?>("usecrmformforappointment"); }
            set
            {
                OnPropertyChanging("UseCrmFormForAppointment");
                SetAttributeValue("usecrmformforappointment", value);
                OnPropertyChanged("UseCrmFormForAppointment");
            }
        }

        /// <summary>
        ///     Indicates whether to use the Microsoft Dynamics CRM contact form within Microsoft Office Outlook for creating new
        ///     contacts.
        /// </summary>
        [AttributeLogicalName("usecrmformforcontact")]
        public bool? UseCrmFormForContact
        {
            get { return GetAttributeValue<bool?>("usecrmformforcontact"); }
            set
            {
                OnPropertyChanging("UseCrmFormForContact");
                SetAttributeValue("usecrmformforcontact", value);
                OnPropertyChanged("UseCrmFormForContact");
            }
        }

        /// <summary>
        ///     Indicates whether to use the Microsoft Dynamics CRM email form within Microsoft Office Outlook for creating new
        ///     emails.
        /// </summary>
        [AttributeLogicalName("usecrmformforemail")]
        public bool? UseCrmFormForEmail
        {
            get { return GetAttributeValue<bool?>("usecrmformforemail"); }
            set
            {
                OnPropertyChanging("UseCrmFormForEmail");
                SetAttributeValue("usecrmformforemail", value);
                OnPropertyChanged("UseCrmFormForEmail");
            }
        }

        /// <summary>
        ///     Indicates whether to use the Microsoft Dynamics CRM task form within Microsoft Office Outlook for creating new
        ///     tasks.
        /// </summary>
        [AttributeLogicalName("usecrmformfortask")]
        public bool? UseCrmFormForTask
        {
            get { return GetAttributeValue<bool?>("usecrmformfortask"); }
            set
            {
                OnPropertyChanging("UseCrmFormForTask");
                SetAttributeValue("usecrmformfortask", value);
                OnPropertyChanged("UseCrmFormForTask");
            }
        }

        /// <summary>
        ///     Indicates whether image strips are used to render images.
        /// </summary>
        [AttributeLogicalName("useimagestrips")]
        public bool? UseImageStrips
        {
            get { return GetAttributeValue<bool?>("useimagestrips"); }
            set
            {
                OnPropertyChanging("UseImageStrips");
                SetAttributeValue("useimagestrips", value);
                OnPropertyChanged("UseImageStrips");
            }
        }

        /// <summary>
        ///     Specifies user profile ids in comma separated list.
        /// </summary>
        [AttributeLogicalName("userprofile")]
        public string UserProfile
        {
            get { return GetAttributeValue<string>("userprofile"); }
            set
            {
                OnPropertyChanging("UserProfile");
                SetAttributeValue("userprofile", value);
                OnPropertyChanged("UserProfile");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     The layout of the visualization pane.
        /// </summary>
        [AttributeLogicalName("visualizationpanelayout")]
        public OptionSetValue VisualizationPaneLayout
        {
            get { return GetAttributeValue<OptionSetValue>("visualizationpanelayout"); }
            set
            {
                OnPropertyChanging("VisualizationPaneLayout");
                SetAttributeValue("visualizationpanelayout", value);
                OnPropertyChanged("VisualizationPaneLayout");
            }
        }

        /// <summary>
        ///     Workday start time for the user.
        /// </summary>
        [AttributeLogicalName("workdaystarttime")]
        public string WorkdayStartTime
        {
            get { return GetAttributeValue<string>("workdaystarttime"); }
            set
            {
                OnPropertyChanging("WorkdayStartTime");
                SetAttributeValue("workdaystarttime", value);
                OnPropertyChanged("WorkdayStartTime");
            }
        }

        /// <summary>
        ///     Workday stop time for the user.
        /// </summary>
        [AttributeLogicalName("workdaystoptime")]
        public string WorkdayStopTime
        {
            get { return GetAttributeValue<string>("workdaystoptime"); }
            set
            {
                OnPropertyChanging("WorkdayStopTime");
                SetAttributeValue("workdaystoptime", value);
                OnPropertyChanged("WorkdayStopTime");
            }
        }

        /// <summary>
        ///     N:1 business_unit_user_settings
        /// </summary>
        [AttributeLogicalName("businessunitid")]
        [RelationshipSchemaName("business_unit_user_settings")]
        public BusinessUnit business_unit_user_settings
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_user_settings", null); }
            set
            {
                OnPropertyChanging("business_unit_user_settings");
                SetRelatedEntity("business_unit_user_settings", null, value);
                OnPropertyChanged("business_unit_user_settings");
            }
        }

        /// <summary>
        ///     N:1 lk_usersettings_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_usersettings_createdonbehalfby")]
        public SystemUser lk_usersettings_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_usersettings_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_usersettings_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_usersettings_modifiedonbehalfby")]
        public SystemUser lk_usersettings_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_usersettings_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_usersettingsbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_usersettingsbase_createdby")]
        public SystemUser lk_usersettingsbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_usersettingsbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_usersettingsbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_usersettingsbase_modifiedby")]
        public SystemUser lk_usersettingsbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_usersettingsbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 transactioncurrency_usersettings
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("transactioncurrency_usersettings")]
        public TransactionCurrency transactioncurrency_usersettings
        {
            get { return GetRelatedEntity<TransactionCurrency>("transactioncurrency_usersettings", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_usersettings");
                SetRelatedEntity("transactioncurrency_usersettings", null, value);
                OnPropertyChanged("transactioncurrency_usersettings");
            }
        }

        /// <summary>
        ///     N:1 user_settings
        /// </summary>
        [AttributeLogicalName("systemuserid")]
        [RelationshipSchemaName("user_settings")]
        public SystemUser user_settings
        {
            get { return GetRelatedEntity<SystemUser>("user_settings", null); }
            set
            {
                OnPropertyChanging("user_settings");
                SetRelatedEntity("user_settings", null, value);
                OnPropertyChanged("user_settings");
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