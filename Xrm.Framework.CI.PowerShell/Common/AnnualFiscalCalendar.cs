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
    ///     Year long fiscal calendar of an organization. A span of time during which the financial activities of an
    ///     organization are calculated.
    /// </summary>
    [DataContract]
    [EntityLogicalName("annualfiscalcalendar")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class AnnualFiscalCalendar : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "annualfiscalcalendar";

        public const int EntityTypeCode = 2000;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public AnnualFiscalCalendar() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Sales quota for the first period in the fiscal year.
        /// </summary>
        [AttributeLogicalName("annual")]
        public Money Annual
        {
            get { return GetAttributeValue<Money>("annual"); }
            set
            {
                OnPropertyChanging("Annual");
                SetAttributeValue("annual", value);
                OnPropertyChanged("Annual");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the sales quota for the first period in the fiscal year.
        /// </summary>
        [AttributeLogicalName("annual_base")]
        public Money Annual_Base
        {
            get { return GetAttributeValue<Money>("annual_base"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("businessunitid")]
        public EntityReference BusinessUnitId
        {
            get { return GetAttributeValue<EntityReference>("businessunitid"); }
        }

        /// <summary>
        ///     Unique identifier of the user who created the quota for the annual fiscal calendar.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the quota for the annual fiscal calendar was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the annualfiscalcalendar.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Date and time when the fiscal calendar sales quota takes effect.
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
        ///     Exchange rate for the currency associated with the annual fiscal calendar with respect to the base currency.
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
        ///     Unique identifier of the user who last modified the quota for the annual fiscal calendar.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the annual fiscal calendar was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the annualfiscalcalendar.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the sales person associated with the sales quota.
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
        ///     Unique identifier of the currency associated with the annual fiscal calendar.
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
        ///     Unique identifier of the user associated with the annual fiscal calendar.
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
        ///     1:N AnnualFiscalCalendar_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("AnnualFiscalCalendar_AsyncOperations")]
        public IEnumerable<AsyncOperation> AnnualFiscalCalendar_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("AnnualFiscalCalendar_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("AnnualFiscalCalendar_AsyncOperations");
                SetRelatedEntities("AnnualFiscalCalendar_AsyncOperations", null, value);
                OnPropertyChanged("AnnualFiscalCalendar_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N AnnualFiscalCalendar_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("AnnualFiscalCalendar_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> AnnualFiscalCalendar_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("AnnualFiscalCalendar_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("AnnualFiscalCalendar_BulkDeleteFailures");
                SetRelatedEntities("AnnualFiscalCalendar_BulkDeleteFailures", null, value);
                OnPropertyChanged("AnnualFiscalCalendar_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     N:1 lk_annualfiscalcalendar_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_annualfiscalcalendar_createdby")]
        public SystemUser lk_annualfiscalcalendar_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_annualfiscalcalendar_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_annualfiscalcalendar_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_annualfiscalcalendar_createdonbehalfby")]
        public SystemUser lk_annualfiscalcalendar_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_annualfiscalcalendar_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_annualfiscalcalendar_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_annualfiscalcalendar_modifiedby")]
        public SystemUser lk_annualfiscalcalendar_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_annualfiscalcalendar_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_annualfiscalcalendar_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_annualfiscalcalendar_modifiedonbehalfby")]
        public SystemUser lk_annualfiscalcalendar_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_annualfiscalcalendar_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_annualfiscalcalendar_salespersonid
        /// </summary>
        [AttributeLogicalName("salespersonid")]
        [RelationshipSchemaName("lk_annualfiscalcalendar_salespersonid")]
        public SystemUser lk_annualfiscalcalendar_salespersonid
        {
            get { return GetRelatedEntity<SystemUser>("lk_annualfiscalcalendar_salespersonid", null); }
            set
            {
                OnPropertyChanging("lk_annualfiscalcalendar_salespersonid");
                SetRelatedEntity("lk_annualfiscalcalendar_salespersonid", null, value);
                OnPropertyChanged("lk_annualfiscalcalendar_salespersonid");
            }
        }

        /// <summary>
        ///     N:1 transactioncurrency_annualfiscalcalendar
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("transactioncurrency_annualfiscalcalendar")]
        public TransactionCurrency transactioncurrency_annualfiscalcalendar
        {
            get { return GetRelatedEntity<TransactionCurrency>("transactioncurrency_annualfiscalcalendar", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_annualfiscalcalendar");
                SetRelatedEntity("transactioncurrency_annualfiscalcalendar", null, value);
                OnPropertyChanged("transactioncurrency_annualfiscalcalendar");
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