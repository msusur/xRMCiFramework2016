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
    ///     Quarterly fiscal calendar of an organization. A span of time during which the financial activities of an
    ///     organization are calculated.
    /// </summary>
    [DataContract]
    [EntityLogicalName("quarterlyfiscalcalendar")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class QuarterlyFiscalCalendar : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "quarterlyfiscalcalendar";

        public const int EntityTypeCode = 2002;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public QuarterlyFiscalCalendar() :
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
        ///     Unique identifier of the user who created the quarterly fiscal calendar.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the quota for the quarterly fiscal calendar was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the quarterlyfiscalcalendar.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Date and time when the quarterly fiscal calendar sales quota takes effect.
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
        ///     Exchange rate for the currency associated with the quarterly fiscal calendar with respect to the base currency.
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
        ///     Unique identifier of the user who last modified the quarterly fiscal calendar.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the quarterly fiscal calendar was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the quarterlyfiscalcalendar.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Sales quota for the first quarter in the fiscal year.
        /// </summary>
        [AttributeLogicalName("quarter1")]
        public Money Quarter1
        {
            get { return GetAttributeValue<Money>("quarter1"); }
            set
            {
                OnPropertyChanging("Quarter1");
                SetAttributeValue("quarter1", value);
                OnPropertyChanged("Quarter1");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the sales quota for the first quarter in the fiscal year.
        /// </summary>
        [AttributeLogicalName("quarter1_base")]
        public Money Quarter1_Base
        {
            get { return GetAttributeValue<Money>("quarter1_base"); }
        }

        /// <summary>
        ///     Sales quota for the second quarter in the fiscal year.
        /// </summary>
        [AttributeLogicalName("quarter2")]
        public Money Quarter2
        {
            get { return GetAttributeValue<Money>("quarter2"); }
            set
            {
                OnPropertyChanging("Quarter2");
                SetAttributeValue("quarter2", value);
                OnPropertyChanged("Quarter2");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the sales quota for the second quarter in the fiscal year
        /// </summary>
        [AttributeLogicalName("quarter2_base")]
        public Money Quarter2_Base
        {
            get { return GetAttributeValue<Money>("quarter2_base"); }
        }

        /// <summary>
        ///     Sales quota for the third quarter in the fiscal year.
        /// </summary>
        [AttributeLogicalName("quarter3")]
        public Money Quarter3
        {
            get { return GetAttributeValue<Money>("quarter3"); }
            set
            {
                OnPropertyChanging("Quarter3");
                SetAttributeValue("quarter3", value);
                OnPropertyChanged("Quarter3");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the sales quota for the third quarter in the fiscal year.
        /// </summary>
        [AttributeLogicalName("quarter3_base")]
        public Money Quarter3_Base
        {
            get { return GetAttributeValue<Money>("quarter3_base"); }
        }

        /// <summary>
        ///     Sales quota for the fourth quarter in the fiscal year.
        /// </summary>
        [AttributeLogicalName("quarter4")]
        public Money Quarter4
        {
            get { return GetAttributeValue<Money>("quarter4"); }
            set
            {
                OnPropertyChanging("Quarter4");
                SetAttributeValue("quarter4", value);
                OnPropertyChanged("Quarter4");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the sales quota for the fourth quarter in the fiscal year.
        /// </summary>
        [AttributeLogicalName("quarter4_base")]
        public Money Quarter4_Base
        {
            get { return GetAttributeValue<Money>("quarter4_base"); }
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
        ///     Unique identifier of the currency associated with the quarterly fiscal calendar.
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
        ///     Unique identifier of the quarterly fiscal calendar.
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
        ///     1:N QuarterlyFiscalCalendar_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("QuarterlyFiscalCalendar_AsyncOperations")]
        public IEnumerable<AsyncOperation> QuarterlyFiscalCalendar_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("QuarterlyFiscalCalendar_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("QuarterlyFiscalCalendar_AsyncOperations");
                SetRelatedEntities("QuarterlyFiscalCalendar_AsyncOperations", null, value);
                OnPropertyChanged("QuarterlyFiscalCalendar_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N QuarterlyFiscalCalendar_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("QuarterlyFiscalCalendar_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> QuarterlyFiscalCalendar_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("QuarterlyFiscalCalendar_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("QuarterlyFiscalCalendar_BulkDeleteFailures");
                SetRelatedEntities("QuarterlyFiscalCalendar_BulkDeleteFailures", null, value);
                OnPropertyChanged("QuarterlyFiscalCalendar_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     N:1 lk_quarterlyfiscalcalendar_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_quarterlyfiscalcalendar_createdby")]
        public SystemUser lk_quarterlyfiscalcalendar_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_quarterlyfiscalcalendar_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_quarterlyfiscalcalendar_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_quarterlyfiscalcalendar_createdonbehalfby")]
        public SystemUser lk_quarterlyfiscalcalendar_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_quarterlyfiscalcalendar_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_quarterlyfiscalcalendar_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_quarterlyfiscalcalendar_modifiedby")]
        public SystemUser lk_quarterlyfiscalcalendar_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_quarterlyfiscalcalendar_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_quarterlyfiscalcalendar_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_quarterlyfiscalcalendar_modifiedonbehalfby")]
        public SystemUser lk_quarterlyfiscalcalendar_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_quarterlyfiscalcalendar_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_quarterlyfiscalcalendar_salespersonid
        /// </summary>
        [AttributeLogicalName("salespersonid")]
        [RelationshipSchemaName("lk_quarterlyfiscalcalendar_salespersonid")]
        public SystemUser lk_quarterlyfiscalcalendar_salespersonid
        {
            get { return GetRelatedEntity<SystemUser>("lk_quarterlyfiscalcalendar_salespersonid", null); }
            set
            {
                OnPropertyChanging("lk_quarterlyfiscalcalendar_salespersonid");
                SetRelatedEntity("lk_quarterlyfiscalcalendar_salespersonid", null, value);
                OnPropertyChanged("lk_quarterlyfiscalcalendar_salespersonid");
            }
        }

        /// <summary>
        ///     N:1 transactioncurrency_quarterlyfiscalcalendar
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("transactioncurrency_quarterlyfiscalcalendar")]
        public TransactionCurrency transactioncurrency_quarterlyfiscalcalendar
        {
            get { return GetRelatedEntity<TransactionCurrency>("transactioncurrency_quarterlyfiscalcalendar", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_quarterlyfiscalcalendar");
                SetRelatedEntity("transactioncurrency_quarterlyfiscalcalendar", null, value);
                OnPropertyChanged("transactioncurrency_quarterlyfiscalcalendar");
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