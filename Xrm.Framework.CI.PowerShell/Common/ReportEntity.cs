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
    ///     Entities related to a report. A report can be related to multiple entities.
    /// </summary>
    [DataContract]
    [EntityLogicalName("reportentity")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ReportEntity : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "reportentity";

        public const int EntityTypeCode = 9101;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ReportEntity() :
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
        ///     Unique identifier of the user who created the report record.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the report record was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the reportentity.
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
        ///     Information about whether the report is filterable.
        /// </summary>
        [AttributeLogicalName("isfilterable")]
        public bool? IsFilterable
        {
            get { return GetAttributeValue<bool?>("isfilterable"); }
            set
            {
                OnPropertyChanging("IsFilterable");
                SetAttributeValue("isfilterable", value);
                OnPropertyChanged("IsFilterable");
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
        ///     Unique identifier of the user who last modified the report record.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the report record was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the reportentity.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Type of record with which the report is associated.
        /// </summary>
        [AttributeLogicalName("objecttypecode")]
        public string ObjectTypeCode
        {
            get { return GetAttributeValue<string>("objecttypecode"); }
            set
            {
                OnPropertyChanging("ObjectTypeCode");
                SetAttributeValue("objecttypecode", value);
                OnPropertyChanged("ObjectTypeCode");
            }
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
        ///     Unique identifier of the user or team who owns the report entity.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId
        {
            get { return GetAttributeValue<EntityReference>("ownerid"); }
        }

        /// <summary>
        ///     Unique identifier of the business unit that owns the report record.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public Guid? OwningBusinessUnit
        {
            get { return GetAttributeValue<Guid?>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the report record.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public Guid? OwningUser
        {
            get { return GetAttributeValue<Guid?>("owninguser"); }
        }

        /// <summary>
        ///     Unique identifier of the report record.
        /// </summary>
        [AttributeLogicalName("reportentityid")]
        public Guid? ReportEntityId
        {
            get { return GetAttributeValue<Guid?>("reportentityid"); }
            set
            {
                OnPropertyChanging("ReportEntityId");
                SetAttributeValue("reportentityid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ReportEntityId");
            }
        }

        [AttributeLogicalName("reportentityid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ReportEntityId = value; }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("reportentityidunique")]
        public Guid? ReportEntityIdUnique
        {
            get { return GetAttributeValue<Guid?>("reportentityidunique"); }
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
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N userentityinstancedata_reportentity
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_reportentity")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_reportentity
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_reportentity", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_reportentity");
                SetRelatedEntities("userentityinstancedata_reportentity", null, value);
                OnPropertyChanged("userentityinstancedata_reportentity");
            }
        }

        /// <summary>
        ///     N:1 lk_reportentity_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_reportentity_createdonbehalfby")]
        public SystemUser lk_reportentity_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_reportentity_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_reportentity_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_reportentity_modifiedonbehalfby")]
        public SystemUser lk_reportentity_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_reportentity_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_reportentitybase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_reportentitybase_createdby")]
        public SystemUser lk_reportentitybase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_reportentitybase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_reportentitybase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_reportentitybase_modifiedby")]
        public SystemUser lk_reportentitybase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_reportentitybase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 report_reportentities
        /// </summary>
        [AttributeLogicalName("reportid")]
        [RelationshipSchemaName("report_reportentities")]
        public Report report_reportentities
        {
            get { return GetRelatedEntity<Report>("report_reportentities", null); }
            set
            {
                OnPropertyChanging("report_reportentities");
                SetRelatedEntity("report_reportentities", null, value);
                OnPropertyChanged("report_reportentities");
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