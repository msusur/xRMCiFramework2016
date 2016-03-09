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
    ///     Monthly fiscal calendar of an organization. A span of time during which the financial activities of an organization
    ///     are calculated.
    /// </summary>
    [DataContract]
    [EntityLogicalName("monthlyfiscalcalendar")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class MonthlyFiscalCalendar : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "monthlyfiscalcalendar";

        public const int EntityTypeCode = 2003;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public MonthlyFiscalCalendar() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("businessunitid")]
        public EntityReference BusinessUnitId
        {
            get { return GetAttributeValue<EntityReference>("businessunitid"); }
        }

        /// <summary>
        ///     Unique identifier of the user who created the fiscal calendar.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the quota for the monthly fiscal calendar was modified.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the monthlyfiscalcalendar.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Date and time when the monthly fiscal calendar sales quota takes effect.
        /// </summary>
        [AttributeLogicalName("effectiveon")]
        public DateTime? EffectiveOn
        {
            get { return GetAttributeValue<DateTime?>("effectiveon"); }
            set
            {
                OnPropertyChanging("EffectiveOn");
                SetAttributeValue("effectiveon", value);
                OnPropertyChanged("EffectiveOn");
            }
        }

        /// <summary>
        ///     Exchange rate for the currency associated with the monthly fiscal calendar with respect to the base currency.
        /// </summary>
        [AttributeLogicalName("exchangerate")]
        public decimal? ExchangeRate
        {
            get { return GetAttributeValue<decimal?>("exchangerate"); }
        }

        /// <summary>
        ///     Type of fiscal period used in the sales quota.
        /// </summary>
        [AttributeLogicalName("fiscalperiodtype")]
        public int? FiscalPeriodType
        {
            get { return GetAttributeValue<int?>("fiscalperiodtype"); }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the quota for the monthly fiscal calendar.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the quota for the monthly fiscal calendar was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the monthlyfiscalcalendar.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Sales quota for the first month in the fiscal year.
        /// </summary>
        [AttributeLogicalName("month1")]
        public Money Month1
        {
            get { return GetAttributeValue<Money>("month1"); }
            set
            {
                OnPropertyChanging("Month1");
                SetAttributeValue("month1", value);
                OnPropertyChanged("Month1");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the sales quota for the first month in the fiscal year.
        /// </summary>
        [AttributeLogicalName("month1_base")]
        public Money Month1_Base
        {
            get { return GetAttributeValue<Money>("month1_base"); }
        }

        /// <summary>
        ///     Sales quota for the tenth month in the fiscal year.
        /// </summary>
        [AttributeLogicalName("month10")]
        public Money Month10
        {
            get { return GetAttributeValue<Money>("month10"); }
            set
            {
                OnPropertyChanging("Month10");
                SetAttributeValue("month10", value);
                OnPropertyChanged("Month10");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the sales quota for the tenth month in the fiscal year.
        /// </summary>
        [AttributeLogicalName("month10_base")]
        public Money Month10_Base
        {
            get { return GetAttributeValue<Money>("month10_base"); }
        }

        /// <summary>
        ///     Sales quota for the eleventh month in the fiscal year.
        /// </summary>
        [AttributeLogicalName("month11")]
        public Money Month11
        {
            get { return GetAttributeValue<Money>("month11"); }
            set
            {
                OnPropertyChanging("Month11");
                SetAttributeValue("month11", value);
                OnPropertyChanged("Month11");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the sales quota for the eleventh month in the fiscal year.
        /// </summary>
        [AttributeLogicalName("month11_base")]
        public Money Month11_Base
        {
            get { return GetAttributeValue<Money>("month11_base"); }
        }

        /// <summary>
        ///     Sales quota for the twelfth month in the fiscal year.
        /// </summary>
        [AttributeLogicalName("month12")]
        public Money Month12
        {
            get { return GetAttributeValue<Money>("month12"); }
            set
            {
                OnPropertyChanging("Month12");
                SetAttributeValue("month12", value);
                OnPropertyChanged("Month12");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the sales quota for the twelfth month in the fiscal year.
        /// </summary>
        [AttributeLogicalName("month12_base")]
        public Money Month12_Base
        {
            get { return GetAttributeValue<Money>("month12_base"); }
        }

        /// <summary>
        ///     Sales quota for the second month in the fiscal year.
        /// </summary>
        [AttributeLogicalName("month2")]
        public Money Month2
        {
            get { return GetAttributeValue<Money>("month2"); }
            set
            {
                OnPropertyChanging("Month2");
                SetAttributeValue("month2", value);
                OnPropertyChanged("Month2");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the sales quota for the second month in the fiscal year.
        /// </summary>
        [AttributeLogicalName("month2_base")]
        public Money Month2_Base
        {
            get { return GetAttributeValue<Money>("month2_base"); }
        }

        /// <summary>
        ///     Sales quota for the third month in the fiscal year.
        /// </summary>
        [AttributeLogicalName("month3")]
        public Money Month3
        {
            get { return GetAttributeValue<Money>("month3"); }
            set
            {
                OnPropertyChanging("Month3");
                SetAttributeValue("month3", value);
                OnPropertyChanged("Month3");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the sales quota for the third month in the fiscal year.
        /// </summary>
        [AttributeLogicalName("month3_base")]
        public Money Month3_Base
        {
            get { return GetAttributeValue<Money>("month3_base"); }
        }

        /// <summary>
        ///     Sales quota for the fourth month in the fiscal year.
        /// </summary>
        [AttributeLogicalName("month4")]
        public Money Month4
        {
            get { return GetAttributeValue<Money>("month4"); }
            set
            {
                OnPropertyChanging("Month4");
                SetAttributeValue("month4", value);
                OnPropertyChanged("Month4");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the sales quota for the fourth month in the fiscal year.
        /// </summary>
        [AttributeLogicalName("month4_base")]
        public Money Month4_Base
        {
            get { return GetAttributeValue<Money>("month4_base"); }
        }

        /// <summary>
        ///     Sales quota for the fifth month in the fiscal year.
        /// </summary>
        [AttributeLogicalName("month5")]
        public Money Month5
        {
            get { return GetAttributeValue<Money>("month5"); }
            set
            {
                OnPropertyChanging("Month5");
                SetAttributeValue("month5", value);
                OnPropertyChanged("Month5");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the sales quota for the fifth month in the fiscal year.
        /// </summary>
        [AttributeLogicalName("month5_base")]
        public Money Month5_Base
        {
            get { return GetAttributeValue<Money>("month5_base"); }
        }

        /// <summary>
        ///     Sales quota for the sixth month in the fiscal year.
        /// </summary>
        [AttributeLogicalName("month6")]
        public Money Month6
        {
            get { return GetAttributeValue<Money>("month6"); }
            set
            {
                OnPropertyChanging("Month6");
                SetAttributeValue("month6", value);
                OnPropertyChanged("Month6");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the sales quota for the sixth month in the fiscal year.
        /// </summary>
        [AttributeLogicalName("month6_base")]
        public Money Month6_Base
        {
            get { return GetAttributeValue<Money>("month6_base"); }
        }

        /// <summary>
        ///     Sales quota for the seventh month in the fiscal year.
        /// </summary>
        [AttributeLogicalName("month7")]
        public Money Month7
        {
            get { return GetAttributeValue<Money>("month7"); }
            set
            {
                OnPropertyChanging("Month7");
                SetAttributeValue("month7", value);
                OnPropertyChanged("Month7");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the sales quota for the seventh month in the fiscal year.
        /// </summary>
        [AttributeLogicalName("month7_base")]
        public Money Month7_Base
        {
            get { return GetAttributeValue<Money>("month7_base"); }
        }

        /// <summary>
        ///     Sales quota for the eighth month in the fiscal year.
        /// </summary>
        [AttributeLogicalName("month8")]
        public Money Month8
        {
            get { return GetAttributeValue<Money>("month8"); }
            set
            {
                OnPropertyChanging("Month8");
                SetAttributeValue("month8", value);
                OnPropertyChanged("Month8");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the sales quota for the eighth month in the fiscal year.
        /// </summary>
        [AttributeLogicalName("month8_base")]
        public Money Month8_Base
        {
            get { return GetAttributeValue<Money>("month8_base"); }
        }

        /// <summary>
        ///     Sales quota for the ninth month in the fiscal year.
        /// </summary>
        [AttributeLogicalName("month9")]
        public Money Month9
        {
            get { return GetAttributeValue<Money>("month9"); }
            set
            {
                OnPropertyChanging("Month9");
                SetAttributeValue("month9", value);
                OnPropertyChanged("Month9");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the sales quota for the ninth month in the fiscal year.
        /// </summary>
        [AttributeLogicalName("month9_base")]
        public Money Month9_Base
        {
            get { return GetAttributeValue<Money>("month9_base"); }
        }

        /// <summary>
        ///     Unique identifier of the associated salesperson.
        /// </summary>
        [AttributeLogicalName("salespersonid")]
        public EntityReference SalesPersonId
        {
            get { return GetAttributeValue<EntityReference>("salespersonid"); }
            set
            {
                OnPropertyChanging("SalesPersonId");
                SetAttributeValue("salespersonid", value);
                OnPropertyChanged("SalesPersonId");
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
        ///     Unique identifier of the currency associated with the monthly fiscal calendar.
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
        ///     Unique identifier of the monthly fiscal calendar.
        /// </summary>
        [AttributeLogicalName("userfiscalcalendarid")]
        public Guid? UserFiscalCalendarId
        {
            get { return GetAttributeValue<Guid?>("userfiscalcalendarid"); }
            set
            {
                OnPropertyChanging("UserFiscalCalendarId");
                SetAttributeValue("userfiscalcalendarid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("UserFiscalCalendarId");
            }
        }

        [AttributeLogicalName("userfiscalcalendarid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { UserFiscalCalendarId = value; }
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
        ///     1:N MonthlyFiscalCalendar_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("MonthlyFiscalCalendar_AsyncOperations")]
        public IEnumerable<AsyncOperation> MonthlyFiscalCalendar_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("MonthlyFiscalCalendar_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("MonthlyFiscalCalendar_AsyncOperations");
                SetRelatedEntities("MonthlyFiscalCalendar_AsyncOperations", null, value);
                OnPropertyChanged("MonthlyFiscalCalendar_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N MonthlyFiscalCalendar_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("MonthlyFiscalCalendar_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> MonthlyFiscalCalendar_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("MonthlyFiscalCalendar_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("MonthlyFiscalCalendar_BulkDeleteFailures");
                SetRelatedEntities("MonthlyFiscalCalendar_BulkDeleteFailures", null, value);
                OnPropertyChanged("MonthlyFiscalCalendar_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     N:1 lk_monthlyfiscalcalendar_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_monthlyfiscalcalendar_createdby")]
        public SystemUser lk_monthlyfiscalcalendar_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_monthlyfiscalcalendar_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_monthlyfiscalcalendar_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_monthlyfiscalcalendar_createdonbehalfby")]
        public SystemUser lk_monthlyfiscalcalendar_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_monthlyfiscalcalendar_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_monthlyfiscalcalendar_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_monthlyfiscalcalendar_modifiedby")]
        public SystemUser lk_monthlyfiscalcalendar_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_monthlyfiscalcalendar_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_monthlyfiscalcalendar_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_monthlyfiscalcalendar_modifiedonbehalfby")]
        public SystemUser lk_monthlyfiscalcalendar_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_monthlyfiscalcalendar_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_monthlyfiscalcalendar_salespersonid
        /// </summary>
        [AttributeLogicalName("salespersonid")]
        [RelationshipSchemaName("lk_monthlyfiscalcalendar_salespersonid")]
        public SystemUser lk_monthlyfiscalcalendar_salespersonid
        {
            get { return GetRelatedEntity<SystemUser>("lk_monthlyfiscalcalendar_salespersonid", null); }
            set
            {
                OnPropertyChanging("lk_monthlyfiscalcalendar_salespersonid");
                SetRelatedEntity("lk_monthlyfiscalcalendar_salespersonid", null, value);
                OnPropertyChanged("lk_monthlyfiscalcalendar_salespersonid");
            }
        }

        /// <summary>
        ///     N:1 transactioncurrency_monthlyfiscalcalendar
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("transactioncurrency_monthlyfiscalcalendar")]
        public TransactionCurrency transactioncurrency_monthlyfiscalcalendar
        {
            get { return GetRelatedEntity<TransactionCurrency>("transactioncurrency_monthlyfiscalcalendar", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_monthlyfiscalcalendar");
                SetRelatedEntity("transactioncurrency_monthlyfiscalcalendar", null, value);
                OnPropertyChanged("transactioncurrency_monthlyfiscalcalendar");
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