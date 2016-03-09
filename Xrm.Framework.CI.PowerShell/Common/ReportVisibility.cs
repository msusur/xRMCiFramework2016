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
    ///     Area in which to show a report. A report can be shown in multiple areas.
    /// </summary>
    [DataContract]
    [EntityLogicalName("reportvisibility")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ReportVisibility : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "reportvisibility";

        public const int EntityTypeCode = 9103;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ReportVisibility() :
            base(EntityLogicalName)
        {
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
        ///     Unique identifier of the user who created the report visibility record.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the report visibility record was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the reportvisibility.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
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
        /// </summary>
        [AttributeLogicalName("ismanaged")]
        public bool? IsManaged
        {
            get { return GetAttributeValue<bool?>("ismanaged"); }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the report visibility record.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the report visibility record was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the reportvisibility.
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
        ///     Unique identifier of the user or team who owns the report visibility.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId
        {
            get { return GetAttributeValue<EntityReference>("ownerid"); }
        }

        /// <summary>
        ///     Unique identifier of the business unit that owns the report visibility record.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public Guid? OwningBusinessUnit
        {
            get { return GetAttributeValue<Guid?>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the report visibility record.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public Guid? OwningUser
        {
            get { return GetAttributeValue<Guid?>("owninguser"); }
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
        ///     Unique identifier of the report visibility record.
        /// </summary>
        [AttributeLogicalName("reportvisibilityid")]
        public Guid? ReportVisibilityId
        {
            get { return GetAttributeValue<Guid?>("reportvisibilityid"); }
            set
            {
                OnPropertyChanging("ReportVisibilityId");
                SetAttributeValue("reportvisibilityid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ReportVisibilityId");
            }
        }

        [AttributeLogicalName("reportvisibilityid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ReportVisibilityId = value; }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("reportvisibilityidunique")]
        public Guid? ReportVisibilityIdUnique
        {
            get { return GetAttributeValue<Guid?>("reportvisibilityidunique"); }
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
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     Type of visibility of the report.
        /// </summary>
        [AttributeLogicalName("visibilitycode")]
        public OptionSetValue VisibilityCode
        {
            get { return GetAttributeValue<OptionSetValue>("visibilitycode"); }
            set
            {
                OnPropertyChanging("VisibilityCode");
                SetAttributeValue("visibilitycode", value);
                OnPropertyChanged("VisibilityCode");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_reportvisibility
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_reportvisibility")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_reportvisibility
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_reportvisibility", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_reportvisibility");
                SetRelatedEntities("userentityinstancedata_reportvisibility", null, value);
                OnPropertyChanged("userentityinstancedata_reportvisibility");
            }
        }

        /// <summary>
        ///     N:1 lk_reportvisibility_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_reportvisibility_createdonbehalfby")]
        public SystemUser lk_reportvisibility_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_reportvisibility_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_reportvisibility_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_reportvisibility_modifiedonbehalfby")]
        public SystemUser lk_reportvisibility_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_reportvisibility_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_reportvisibilitybase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_reportvisibilitybase_createdby")]
        public SystemUser lk_reportvisibilitybase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_reportvisibilitybase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_reportvisibilitybase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_reportvisibilitybase_modifiedby")]
        public SystemUser lk_reportvisibilitybase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_reportvisibilitybase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 report_reportvisibility
        /// </summary>
        [AttributeLogicalName("reportid")]
        [RelationshipSchemaName("report_reportvisibility")]
        public Report report_reportvisibility
        {
            get { return GetRelatedEntity<Report>("report_reportvisibility", null); }
            set
            {
                OnPropertyChanging("report_reportvisibility");
                SetRelatedEntity("report_reportvisibility", null, value);
                OnPropertyChanged("report_reportvisibility");
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