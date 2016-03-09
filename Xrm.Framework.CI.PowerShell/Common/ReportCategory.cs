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
    ///     Categories related to a report. A report can be related to multiple categories.
    /// </summary>
    [DataContract]
    [EntityLogicalName("reportcategory")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ReportCategory : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "reportcategory";

        public const int EntityTypeCode = 9102;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ReportCategory() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Category of the report.
        /// </summary>
        [AttributeLogicalName("categorycode")]
        public OptionSetValue CategoryCode
        {
            get { return GetAttributeValue<OptionSetValue>("categorycode"); }
            set
            {
                OnPropertyChanging("CategoryCode");
                SetAttributeValue("categorycode", value);
                OnPropertyChanged("CategoryCode");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("componentstate")]
        public OptionSetValue ComponentState
        {
            get { return GetAttributeValue<OptionSetValue>("componentstate"); }
        }

        /// <summary>
        ///     Unique identifier of the user who created the report category.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the report category record was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the report category.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Exchange rate for the currency associated with the report category with respect to the base currency.
        /// </summary>
        [AttributeLogicalName("exchangerate")]
        public decimal? ExchangeRate
        {
            get { return GetAttributeValue<decimal?>("exchangerate"); }
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
        ///     Information that specifies whether this component can be customized.
        /// </summary>
        [AttributeLogicalName("iscustomizable")]
        public BooleanManagedProperty IsCustomizable
        {
            get { return GetAttributeValue<BooleanManagedProperty>("iscustomizable"); }
            set
            {
                OnPropertyChanging("IsCustomizable");
                SetAttributeValue("iscustomizable", value);
                OnPropertyChanged("IsCustomizable");
            }
        }

        /// <summary>
        ///     Indicates whether the solution component is part of a managed solution.
        /// </summary>
        [AttributeLogicalName("ismanaged")]
        public bool? IsManaged
        {
            get { return GetAttributeValue<bool?>("ismanaged"); }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the report category.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the report category was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the report category.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("overwritetime")]
        public DateTime? OverwriteTime
        {
            get { return GetAttributeValue<DateTime?>("overwritetime"); }
        }

        /// <summary>
        ///     Unique identifier of the user or team who owns the report category.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId
        {
            get { return GetAttributeValue<EntityReference>("ownerid"); }
        }

        /// <summary>
        ///     Unique identifier of the business unit that owns the report category.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public Guid? OwningBusinessUnit
        {
            get { return GetAttributeValue<Guid?>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the report category.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public Guid? OwningUser
        {
            get { return GetAttributeValue<Guid?>("owninguser"); }
        }

        /// <summary>
        ///     Unique identifier of the report category.
        /// </summary>
        [AttributeLogicalName("reportcategoryid")]
        public Guid? ReportCategoryId
        {
            get { return GetAttributeValue<Guid?>("reportcategoryid"); }
            set
            {
                OnPropertyChanging("ReportCategoryId");
                SetAttributeValue("reportcategoryid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ReportCategoryId");
            }
        }

        [AttributeLogicalName("reportcategoryid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ReportCategoryId = value; }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("reportcategoryidunique")]
        public Guid? ReportCategoryIdUnique
        {
            get { return GetAttributeValue<Guid?>("reportcategoryidunique"); }
        }

        /// <summary>
        ///     Unique identifier of the report.
        /// </summary>
        [AttributeLogicalName("reportid")]
        public EntityReference ReportId
        {
            get { return GetAttributeValue<EntityReference>("reportid"); }
            set
            {
                OnPropertyChanging("ReportId");
                SetAttributeValue("reportid", value);
                OnPropertyChanged("ReportId");
            }
        }

        /// <summary>
        ///     Unique identifier of the associated solution.
        /// </summary>
        [AttributeLogicalName("solutionid")]
        public Guid? SolutionId
        {
            get { return GetAttributeValue<Guid?>("solutionid"); }
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
        ///     Unique identifier of the currency associated with the Report category.
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
        ///     Version number of the report category.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N reportcategory_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("reportcategory_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> reportcategory_principalobjectattributeaccess
        {
            get
            {
                return
                    GetRelatedEntities<PrincipalObjectAttributeAccess>("reportcategory_principalobjectattributeaccess",
                        null);
            }
            set
            {
                OnPropertyChanging("reportcategory_principalobjectattributeaccess");
                SetRelatedEntities("reportcategory_principalobjectattributeaccess", null, value);
                OnPropertyChanged("reportcategory_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_reportcategory
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_reportcategory")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_reportcategory
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_reportcategory", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_reportcategory");
                SetRelatedEntities("userentityinstancedata_reportcategory", null, value);
                OnPropertyChanged("userentityinstancedata_reportcategory");
            }
        }

        /// <summary>
        ///     N:1 lk_reportcategory_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_reportcategory_createdonbehalfby")]
        public SystemUser lk_reportcategory_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_reportcategory_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_reportcategory_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_reportcategory_modifiedonbehalfby")]
        public SystemUser lk_reportcategory_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_reportcategory_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_reportcategorybase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_reportcategorybase_createdby")]
        public SystemUser lk_reportcategorybase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_reportcategorybase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_reportcategorybase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_reportcategorybase_modifiedby")]
        public SystemUser lk_reportcategorybase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_reportcategorybase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 report_reportcategories
        /// </summary>
        [AttributeLogicalName("reportid")]
        [RelationshipSchemaName("report_reportcategories")]
        public Report report_reportcategories
        {
            get { return GetRelatedEntity<Report>("report_reportcategories", null); }
            set
            {
                OnPropertyChanging("report_reportcategories");
                SetRelatedEntity("report_reportcategories", null, value);
                OnPropertyChanged("report_reportcategories");
            }
        }

        /// <summary>
        ///     N:1 TransactionCurrency_ReportCategory
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("TransactionCurrency_ReportCategory")]
        public TransactionCurrency TransactionCurrency_ReportCategory
        {
            get { return GetRelatedEntity<TransactionCurrency>("TransactionCurrency_ReportCategory", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_ReportCategory");
                SetRelatedEntity("TransactionCurrency_ReportCategory", null, value);
                OnPropertyChanged("TransactionCurrency_ReportCategory");
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