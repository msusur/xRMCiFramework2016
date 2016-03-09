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
    ///     Fixed monthly fiscal calendar of an organization. A span of time during which the financial activities of an
    ///     organization are calculated.
    /// </summary>
    [DataContract]
    [EntityLogicalName("fixedmonthlyfiscalcalendar")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class FixedMonthlyFiscalCalendar : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "fixedmonthlyfiscalcalendar";

        public const int EntityTypeCode = 2004;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public FixedMonthlyFiscalCalendar() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Business unit responsible for the quota associated with this calendar.
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
        ///     Date and time when the quota for the fixed monthly fiscal calendar was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the fixedmonthlyfiscalcalendar.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Date and time when the fixed monthly fiscal calendar sales quota takes effect.
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
        ///     Exchange rate for the currency associated with the fixed monthly fiscal calendar with respect to the base currency.
        /// </summary>
        [AttributeLogicalName("exchangerate")]
        public decimal? ExchangeRate
        {
            get { return GetAttributeValue<decimal?>("exchangerate"); }
        }

        /// <summary>
        ///     Type of fiscal period used in the fixed monthly fiscal calendar sales quota.
        /// </summary>
        [AttributeLogicalName("fiscalperiodtype")]
        public int? FiscalPeriodType
        {
            get { return GetAttributeValue<int?>("fiscalperiodtype"); }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the fixed monthly fiscal calendar.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the fixed monthly fiscal calendar was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the fixedmonthlyfiscalcalendar.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Sales quota for the first period in the fiscal year.
        /// </summary>
        [AttributeLogicalName("period1")]
        public Money Period1
        {
            get { return GetAttributeValue<Money>("period1"); }
            set
            {
                OnPropertyChanging("Period1");
                SetAttributeValue("period1", value);
                OnPropertyChanged("Period1");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the sales quota for the first period in the fiscal year.
        /// </summary>
        [AttributeLogicalName("period1_base")]
        public Money Period1_Base
        {
            get { return GetAttributeValue<Money>("period1_base"); }
        }

        /// <summary>
        ///     Sales quota for the tenth period in the fiscal year.
        /// </summary>
        [AttributeLogicalName("period10")]
        public Money Period10
        {
            get { return GetAttributeValue<Money>("period10"); }
            set
            {
                OnPropertyChanging("Period10");
                SetAttributeValue("period10", value);
                OnPropertyChanged("Period10");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the sales quota for the tenth period in the fiscal year.
        /// </summary>
        [AttributeLogicalName("period10_base")]
        public Money Period10_Base
        {
            get { return GetAttributeValue<Money>("period10_base"); }
        }

        /// <summary>
        ///     Sales quota for the eleventh period in the fiscal year.
        /// </summary>
        [AttributeLogicalName("period11")]
        public Money Period11
        {
            get { return GetAttributeValue<Money>("period11"); }
            set
            {
                OnPropertyChanging("Period11");
                SetAttributeValue("period11", value);
                OnPropertyChanged("Period11");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the sales quota for the eleventh period in the fiscal year.
        /// </summary>
        [AttributeLogicalName("period11_base")]
        public Money Period11_Base
        {
            get { return GetAttributeValue<Money>("period11_base"); }
        }

        /// <summary>
        ///     Sales quota for the twelfth period in the fiscal year.
        /// </summary>
        [AttributeLogicalName("period12")]
        public Money Period12
        {
            get { return GetAttributeValue<Money>("period12"); }
            set
            {
                OnPropertyChanging("Period12");
                SetAttributeValue("period12", value);
                OnPropertyChanged("Period12");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the sales quota for the twelfth period in the fiscal year.
        /// </summary>
        [AttributeLogicalName("period12_base")]
        public Money Period12_Base
        {
            get { return GetAttributeValue<Money>("period12_base"); }
        }

        /// <summary>
        ///     Sales quota for the thirteenth period in the fiscal year.
        /// </summary>
        [AttributeLogicalName("period13")]
        public Money Period13
        {
            get { return GetAttributeValue<Money>("period13"); }
            set
            {
                OnPropertyChanging("Period13");
                SetAttributeValue("period13", value);
                OnPropertyChanged("Period13");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the sales quota for the thirteenth period in the fiscal year.
        /// </summary>
        [AttributeLogicalName("period13_base")]
        public Money Period13_Base
        {
            get { return GetAttributeValue<Money>("period13_base"); }
        }

        /// <summary>
        ///     Sales quota for the second period in the fiscal year.
        /// </summary>
        [AttributeLogicalName("period2")]
        public Money Period2
        {
            get { return GetAttributeValue<Money>("period2"); }
            set
            {
                OnPropertyChanging("Period2");
                SetAttributeValue("period2", value);
                OnPropertyChanged("Period2");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the sales quota for the second period in the fiscal year.
        /// </summary>
        [AttributeLogicalName("period2_base")]
        public Money Period2_Base
        {
            get { return GetAttributeValue<Money>("period2_base"); }
        }

        /// <summary>
        ///     Sales quota for the third period in the fiscal year.
        /// </summary>
        [AttributeLogicalName("period3")]
        public Money Period3
        {
            get { return GetAttributeValue<Money>("period3"); }
            set
            {
                OnPropertyChanging("Period3");
                SetAttributeValue("period3", value);
                OnPropertyChanged("Period3");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the sales quota for the third period in the fiscal year.
        /// </summary>
        [AttributeLogicalName("period3_base")]
        public Money Period3_Base
        {
            get { return GetAttributeValue<Money>("period3_base"); }
        }

        /// <summary>
        ///     Sales quota for the fourth period in the fiscal year.
        /// </summary>
        [AttributeLogicalName("period4")]
        public Money Period4
        {
            get { return GetAttributeValue<Money>("period4"); }
            set
            {
                OnPropertyChanging("Period4");
                SetAttributeValue("period4", value);
                OnPropertyChanged("Period4");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the sales quota for the fourth period in the fiscal year.
        /// </summary>
        [AttributeLogicalName("period4_base")]
        public Money Period4_Base
        {
            get { return GetAttributeValue<Money>("period4_base"); }
        }

        /// <summary>
        ///     Sales quota for the fifth period in the fiscal year.
        /// </summary>
        [AttributeLogicalName("period5")]
        public Money Period5
        {
            get { return GetAttributeValue<Money>("period5"); }
            set
            {
                OnPropertyChanging("Period5");
                SetAttributeValue("period5", value);
                OnPropertyChanged("Period5");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the sales quota for the fifth period in the fiscal year.
        /// </summary>
        [AttributeLogicalName("period5_base")]
        public Money Period5_Base
        {
            get { return GetAttributeValue<Money>("period5_base"); }
        }

        /// <summary>
        ///     Sales quota for the sixth period in the fiscal year.
        /// </summary>
        [AttributeLogicalName("period6")]
        public Money Period6
        {
            get { return GetAttributeValue<Money>("period6"); }
            set
            {
                OnPropertyChanging("Period6");
                SetAttributeValue("period6", value);
                OnPropertyChanged("Period6");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the sales quota for the sixth period in the fiscal year.
        /// </summary>
        [AttributeLogicalName("period6_base")]
        public Money Period6_Base
        {
            get { return GetAttributeValue<Money>("period6_base"); }
        }

        /// <summary>
        ///     Sales quota for the seventh period in the fiscal year.
        /// </summary>
        [AttributeLogicalName("period7")]
        public Money Period7
        {
            get { return GetAttributeValue<Money>("period7"); }
            set
            {
                OnPropertyChanging("Period7");
                SetAttributeValue("period7", value);
                OnPropertyChanged("Period7");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the sales quota for the seventh period in the fiscal year.
        /// </summary>
        [AttributeLogicalName("period7_base")]
        public Money Period7_Base
        {
            get { return GetAttributeValue<Money>("period7_base"); }
        }

        /// <summary>
        ///     Sales quota for the eighth period in the fiscal year.
        /// </summary>
        [AttributeLogicalName("period8")]
        public Money Period8
        {
            get { return GetAttributeValue<Money>("period8"); }
            set
            {
                OnPropertyChanging("Period8");
                SetAttributeValue("period8", value);
                OnPropertyChanged("Period8");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the sales quota for the eighth period in the fiscal year.
        /// </summary>
        [AttributeLogicalName("period8_base")]
        public Money Period8_Base
        {
            get { return GetAttributeValue<Money>("period8_base"); }
        }

        /// <summary>
        ///     Sales quota for the ninth period in the fiscal year.
        /// </summary>
        [AttributeLogicalName("period9")]
        public Money Period9
        {
            get { return GetAttributeValue<Money>("period9"); }
            set
            {
                OnPropertyChanging("Period9");
                SetAttributeValue("period9", value);
                OnPropertyChanged("Period9");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the sales quota for the ninth period in the fiscal year.
        /// </summary>
        [AttributeLogicalName("period9_base")]
        public Money Period9_Base
        {
            get { return GetAttributeValue<Money>("period9_base"); }
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
        ///     Unique identifier of the currency associated with the fixed monthly fiscal calendar.
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
        ///     Unique identifier of the user of the fiscal calendar.
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
        ///     1:N FixedMonthlyFiscalCalendar_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("FixedMonthlyFiscalCalendar_AsyncOperations")]
        public IEnumerable<AsyncOperation> FixedMonthlyFiscalCalendar_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("FixedMonthlyFiscalCalendar_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("FixedMonthlyFiscalCalendar_AsyncOperations");
                SetRelatedEntities("FixedMonthlyFiscalCalendar_AsyncOperations", null, value);
                OnPropertyChanged("FixedMonthlyFiscalCalendar_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N FixedMonthlyFiscalCalendar_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("FixedMonthlyFiscalCalendar_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> FixedMonthlyFiscalCalendar_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("FixedMonthlyFiscalCalendar_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("FixedMonthlyFiscalCalendar_BulkDeleteFailures");
                SetRelatedEntities("FixedMonthlyFiscalCalendar_BulkDeleteFailures", null, value);
                OnPropertyChanged("FixedMonthlyFiscalCalendar_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     N:1 lk_fixedmonthlyfiscalcalendar_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_fixedmonthlyfiscalcalendar_createdby")]
        public SystemUser lk_fixedmonthlyfiscalcalendar_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_fixedmonthlyfiscalcalendar_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_fixedmonthlyfiscalcalendar_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_fixedmonthlyfiscalcalendar_createdonbehalfby")]
        public SystemUser lk_fixedmonthlyfiscalcalendar_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_fixedmonthlyfiscalcalendar_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_fixedmonthlyfiscalcalendar_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_fixedmonthlyfiscalcalendar_modifiedby")]
        public SystemUser lk_fixedmonthlyfiscalcalendar_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_fixedmonthlyfiscalcalendar_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby")]
        public SystemUser lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_fixedmonthlyfiscalcalendar_salespersonid
        /// </summary>
        [AttributeLogicalName("salespersonid")]
        [RelationshipSchemaName("lk_fixedmonthlyfiscalcalendar_salespersonid")]
        public SystemUser lk_fixedmonthlyfiscalcalendar_salespersonid
        {
            get { return GetRelatedEntity<SystemUser>("lk_fixedmonthlyfiscalcalendar_salespersonid", null); }
            set
            {
                OnPropertyChanging("lk_fixedmonthlyfiscalcalendar_salespersonid");
                SetRelatedEntity("lk_fixedmonthlyfiscalcalendar_salespersonid", null, value);
                OnPropertyChanged("lk_fixedmonthlyfiscalcalendar_salespersonid");
            }
        }

        /// <summary>
        ///     N:1 transactioncurrency_fixedmonthlyfiscalcalendar
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("transactioncurrency_fixedmonthlyfiscalcalendar")]
        public TransactionCurrency transactioncurrency_fixedmonthlyfiscalcalendar
        {
            get
            {
                return GetRelatedEntity<TransactionCurrency>("transactioncurrency_fixedmonthlyfiscalcalendar", null);
            }
            set
            {
                OnPropertyChanging("transactioncurrency_fixedmonthlyfiscalcalendar");
                SetRelatedEntity("transactioncurrency_fixedmonthlyfiscalcalendar", null, value);
                OnPropertyChanged("transactioncurrency_fixedmonthlyfiscalcalendar");
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