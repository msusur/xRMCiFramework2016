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
    ///     Links and dependencies between reports. A report may drill through to another report, or it may have another report
    ///     as a sub-report.
    /// </summary>
    [DataContract]
    [EntityLogicalName("reportlink")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ReportLink : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "reportlink";

        public const int EntityTypeCode = 9104;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ReportLink() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the user who created the report link.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the report link record was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the reportlink.
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
        ///     Unique identifier of the linked report.
        /// </summary>
        [AttributeLogicalName("linkedreportid")]
        public EntityReference LinkedReportId
        {
            get { return GetAttributeValue<EntityReference>("linkedreportid"); }
            set
            {
                OnPropertyChanging("LinkedReportId");
                SetAttributeValue("linkedreportid", value);
                OnPropertyChanged("LinkedReportId");
            }
        }

        /// <summary>
        ///     Name of the linked report.
        /// </summary>
        [AttributeLogicalName("linkedreportname")]
        public string LinkedReportName
        {
            get { return GetAttributeValue<string>("linkedreportname"); }
            set
            {
                OnPropertyChanging("LinkedReportName");
                SetAttributeValue("linkedreportname", value);
                OnPropertyChanged("LinkedReportName");
            }
        }

        /// <summary>
        ///     Link type of the report.
        /// </summary>
        [AttributeLogicalName("linktypecode")]
        public OptionSetValue LinkTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("linktypecode"); }
            set
            {
                OnPropertyChanging("LinkTypeCode");
                SetAttributeValue("linktypecode", value);
                OnPropertyChanged("LinkTypeCode");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the report link.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the report link was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the reportlink.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the user or team who owns the report link.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId
        {
            get { return GetAttributeValue<EntityReference>("ownerid"); }
        }

        /// <summary>
        ///     Unique identifier of the business unit that owns the report link.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public Guid? OwningBusinessUnit
        {
            get { return GetAttributeValue<Guid?>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the report link.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public Guid? OwningUser
        {
            get { return GetAttributeValue<Guid?>("owninguser"); }
        }

        /// <summary>
        ///     Unique identifier of the main report.
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
        ///     Unique identifier of the report link.
        /// </summary>
        [AttributeLogicalName("reportlinkid")]
        public Guid? ReportLinkId
        {
            get { return GetAttributeValue<Guid?>("reportlinkid"); }
            set
            {
                OnPropertyChanging("ReportLinkId");
                SetAttributeValue("reportlinkid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ReportLinkId");
            }
        }

        [AttributeLogicalName("reportlinkid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ReportLinkId = value; }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("reportlinkidunique")]
        public Guid? ReportLinkIdUnique
        {
            get { return GetAttributeValue<Guid?>("reportlinkidunique"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N userentityinstancedata_reportlink
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_reportlink")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_reportlink
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_reportlink", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_reportlink");
                SetRelatedEntities("userentityinstancedata_reportlink", null, value);
                OnPropertyChanged("userentityinstancedata_reportlink");
            }
        }

        /// <summary>
        ///     N:1 lk_reportlink_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_reportlink_createdonbehalfby")]
        public SystemUser lk_reportlink_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_reportlink_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_reportlink_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_reportlink_modifiedonbehalfby")]
        public SystemUser lk_reportlink_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_reportlink_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_reportlinkbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_reportlinkbase_createdby")]
        public SystemUser lk_reportlinkbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_reportlinkbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_reportlinkbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_reportlinkbase_modifiedby")]
        public SystemUser lk_reportlinkbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_reportlinkbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 report_reportlink
        /// </summary>
        [AttributeLogicalName("reportid")]
        [RelationshipSchemaName("report_reportlink")]
        public Report report_reportlink
        {
            get { return GetRelatedEntity<Report>("report_reportlink", null); }
            set
            {
                OnPropertyChanging("report_reportlink");
                SetRelatedEntity("report_reportlink", null, value);
                OnPropertyChanged("report_reportlink");
            }
        }

        /// <summary>
        ///     N:1 report_reportlink_sub
        /// </summary>
        [AttributeLogicalName("linkedreportid")]
        [RelationshipSchemaName("report_reportlink_sub")]
        public Report report_reportlink_sub
        {
            get { return GetRelatedEntity<Report>("report_reportlink_sub", null); }
            set
            {
                OnPropertyChanging("report_reportlink_sub");
                SetRelatedEntity("report_reportlink_sub", null, value);
                OnPropertyChanged("report_reportlink_sub");
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