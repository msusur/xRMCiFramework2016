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
    ///     Calendar representing the semi-annual span of time during which the financial activities of an organization are
    ///     calculated.
    /// </summary>
    [DataContract]
    [EntityLogicalName("semiannualfiscalcalendar")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class SemiAnnualFiscalCalendar : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "semiannualfiscalcalendar";

        public const int EntityTypeCode = 2001;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public SemiAnnualFiscalCalendar() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the business unit with which the calendar is associated.
        /// </summary>
        [AttributeLogicalName("businessunitid")]
        public EntityReference BusinessUnitId
        {
            get { return GetAttributeValue<EntityReference>("businessunitid"); }
        }

        /// <summary>
        ///     Unique identifier of the user who created the semiannual fiscal calendar.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the quota for the semiannual fiscal calendar was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the semiannualfiscalcalendar.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Date and time when the semiannual fiscal calendar sales quota takes effect.
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
        ///     Exchange rate for the currency associated with the semiannual fiscal calendar with respect to the base currency.
        /// </summary>
        [AttributeLogicalName("exchangerate")]
        public decimal? ExchangeRate
        {
            get { return GetAttributeValue<decimal?>("exchangerate"); }
        }

        /// <summary>
        ///     Sales quota for the first half of the fiscal year.
        /// </summary>
        [AttributeLogicalName("firsthalf")]
        public Money FirstHalf
        {
            get { return GetAttributeValue<Money>("firsthalf"); }
            set
            {
                OnPropertyChanging("FirstHalf");
                SetAttributeValue("firsthalf", value);
                OnPropertyChanged("FirstHalf");
            }
        }

        /// <summary>
        ///     Base currency equivalent for the sales quota for the first half of the fiscal year.
        /// </summary>
        [AttributeLogicalName("firsthalf_base")]
        public Money FirstHalf_Base
        {
            get { return GetAttributeValue<Money>("firsthalf_base"); }
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
        ///     Unique identifier of the user who last modified the semiannual fiscal calendar.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the semiannual fiscal calendar was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the semiannualfiscalcalendar.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
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
        ///     Sales quota for the second half of the fiscal year.
        /// </summary>
        [AttributeLogicalName("secondhalf")]
        public Money SecondHalf
        {
            get { return GetAttributeValue<Money>("secondhalf"); }
            set
            {
                OnPropertyChanging("SecondHalf");
                SetAttributeValue("secondhalf", value);
                OnPropertyChanged("SecondHalf");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the sales quota for the second half of the fiscal year.
        /// </summary>
        [AttributeLogicalName("secondhalf_base")]
        public Money SecondHalf_Base
        {
            get { return GetAttributeValue<Money>("secondhalf_base"); }
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
        ///     Unique identifier of the currency associated with the semiannual fiscal calendar.
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
        ///     Unique identifier for the user who created the semiannual fiscal calendar.
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
        ///     1:N SemiAnnualFiscalCalendar_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("SemiAnnualFiscalCalendar_AsyncOperations")]
        public IEnumerable<AsyncOperation> SemiAnnualFiscalCalendar_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("SemiAnnualFiscalCalendar_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("SemiAnnualFiscalCalendar_AsyncOperations");
                SetRelatedEntities("SemiAnnualFiscalCalendar_AsyncOperations", null, value);
                OnPropertyChanged("SemiAnnualFiscalCalendar_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N SemiAnnualFiscalCalendar_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("SemiAnnualFiscalCalendar_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> SemiAnnualFiscalCalendar_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("SemiAnnualFiscalCalendar_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("SemiAnnualFiscalCalendar_BulkDeleteFailures");
                SetRelatedEntities("SemiAnnualFiscalCalendar_BulkDeleteFailures", null, value);
                OnPropertyChanged("SemiAnnualFiscalCalendar_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     N:1 lk_semiannualfiscalcalendar_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_semiannualfiscalcalendar_createdby")]
        public SystemUser lk_semiannualfiscalcalendar_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_semiannualfiscalcalendar_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_semiannualfiscalcalendar_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_semiannualfiscalcalendar_createdonbehalfby")]
        public SystemUser lk_semiannualfiscalcalendar_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_semiannualfiscalcalendar_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_semiannualfiscalcalendar_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_semiannualfiscalcalendar_modifiedby")]
        public SystemUser lk_semiannualfiscalcalendar_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_semiannualfiscalcalendar_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_semiannualfiscalcalendar_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_semiannualfiscalcalendar_modifiedonbehalfby")]
        public SystemUser lk_semiannualfiscalcalendar_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_semiannualfiscalcalendar_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_semiannualfiscalcalendar_salespersonid
        /// </summary>
        [AttributeLogicalName("salespersonid")]
        [RelationshipSchemaName("lk_semiannualfiscalcalendar_salespersonid")]
        public SystemUser lk_semiannualfiscalcalendar_salespersonid
        {
            get { return GetRelatedEntity<SystemUser>("lk_semiannualfiscalcalendar_salespersonid", null); }
            set
            {
                OnPropertyChanging("lk_semiannualfiscalcalendar_salespersonid");
                SetRelatedEntity("lk_semiannualfiscalcalendar_salespersonid", null, value);
                OnPropertyChanged("lk_semiannualfiscalcalendar_salespersonid");
            }
        }

        /// <summary>
        ///     N:1 transactioncurrency_semiannualfiscalcalendar
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("transactioncurrency_semiannualfiscalcalendar")]
        public TransactionCurrency transactioncurrency_semiannualfiscalcalendar
        {
            get { return GetRelatedEntity<TransactionCurrency>("transactioncurrency_semiannualfiscalcalendar", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_semiannualfiscalcalendar");
                SetRelatedEntity("transactioncurrency_semiannualfiscalcalendar", null, value);
                OnPropertyChanged("transactioncurrency_semiannualfiscalcalendar");
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