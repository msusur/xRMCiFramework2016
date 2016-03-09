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
    ///     Data summary in an easy-to-read layout.
    /// </summary>
    [DataContract]
    [EntityLogicalName("report")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Report : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "report";

        public const int EntityTypeCode = 9100;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Report() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Binary report contents (base-64 encoded).
        /// </summary>
        [AttributeLogicalName("bodybinary")]
        public string BodyBinary
        {
            get { return GetAttributeValue<string>("bodybinary"); }
            set
            {
                OnPropertyChanging("BodyBinary");
                SetAttributeValue("bodybinary", value);
                OnPropertyChanged("BodyBinary");
            }
        }

        /// <summary>
        ///     Text contents of the RDL file for a Reporting Services report.
        /// </summary>
        [AttributeLogicalName("bodytext")]
        public string BodyText
        {
            get { return GetAttributeValue<string>("bodytext"); }
            set
            {
                OnPropertyChanging("BodyText");
                SetAttributeValue("bodytext", value);
                OnPropertyChanged("BodyText");
            }
        }

        /// <summary>
        ///     URL for a linked report.
        /// </summary>
        [AttributeLogicalName("bodyurl")]
        public string BodyUrl
        {
            get { return GetAttributeValue<string>("bodyurl"); }
            set
            {
                OnPropertyChanging("BodyUrl");
                SetAttributeValue("bodyurl", value);
                OnPropertyChanged("BodyUrl");
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
        ///     Unique identifier of the user who created the report.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the report was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the report.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     XML used to define a custom report.
        /// </summary>
        [AttributeLogicalName("customreportxml")]
        public string CustomReportXml
        {
            get { return GetAttributeValue<string>("customreportxml"); }
        }

        /// <summary>
        ///     Default filter for the report.
        /// </summary>
        [AttributeLogicalName("defaultfilter")]
        public string DefaultFilter
        {
            get { return GetAttributeValue<string>("defaultfilter"); }
            set
            {
                OnPropertyChanging("DefaultFilter");
                SetAttributeValue("defaultfilter", value);
                OnPropertyChanged("DefaultFilter");
            }
        }

        /// <summary>
        ///     Description of the report.
        /// </summary>
        [AttributeLogicalName("description")]
        public string Description
        {
            get { return GetAttributeValue<string>("description"); }
            set
            {
                OnPropertyChanging("Description");
                SetAttributeValue("description", value);
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        ///     File name of the report.
        /// </summary>
        [AttributeLogicalName("filename")]
        public string FileName
        {
            get { return GetAttributeValue<string>("filename"); }
            set
            {
                OnPropertyChanging("FileName");
                SetAttributeValue("filename", value);
                OnPropertyChanged("FileName");
            }
        }

        /// <summary>
        ///     File size of the report.
        /// </summary>
        [AttributeLogicalName("filesize")]
        public int? FileSize
        {
            get { return GetAttributeValue<int?>("filesize"); }
        }

        /// <summary>
        ///     Version in which the form is introduced.
        /// </summary>
        [AttributeLogicalName("introducedversion")]
        public string IntroducedVersion
        {
            get { return GetAttributeValue<string>("introducedversion"); }
            set
            {
                OnPropertyChanging("IntroducedVersion");
                SetAttributeValue("introducedversion", value);
                OnPropertyChanged("IntroducedVersion");
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
        ///     Information about whether the report is a custom report.
        /// </summary>
        [AttributeLogicalName("iscustomreport")]
        public bool? IsCustomReport
        {
            get { return GetAttributeValue<bool?>("iscustomreport"); }
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
        ///     Information about whether the report is personal or is available to all users.
        /// </summary>
        [AttributeLogicalName("ispersonal")]
        public bool? IsPersonal
        {
            get { return GetAttributeValue<bool?>("ispersonal"); }
            set
            {
                OnPropertyChanging("IsPersonal");
                SetAttributeValue("ispersonal", value);
                OnPropertyChanged("IsPersonal");
            }
        }

        /// <summary>
        ///     Information about whether the report is a scheduled report.
        /// </summary>
        [AttributeLogicalName("isscheduledreport")]
        public bool? IsScheduledReport
        {
            get { return GetAttributeValue<bool?>("isscheduledreport"); }
        }

        /// <summary>
        ///     Language in which the report will be displayed.
        /// </summary>
        [AttributeLogicalName("languagecode")]
        public int? LanguageCode
        {
            get { return GetAttributeValue<int?>("languagecode"); }
            set
            {
                OnPropertyChanging("LanguageCode");
                SetAttributeValue("languagecode", value);
                OnPropertyChanged("LanguageCode");
            }
        }

        /// <summary>
        ///     MIME type of the report.
        /// </summary>
        [AttributeLogicalName("mimetype")]
        public string MimeType
        {
            get { return GetAttributeValue<string>("mimetype"); }
            set
            {
                OnPropertyChanging("MimeType");
                SetAttributeValue("mimetype", value);
                OnPropertyChanged("MimeType");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the report.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the report was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the report.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the report.
        /// </summary>
        [AttributeLogicalName("name")]
        public string Name
        {
            get { return GetAttributeValue<string>("name"); }
            set
            {
                OnPropertyChanging("Name");
                SetAttributeValue("name", value);
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        ///     Original Text contents of the RDL file for a Reporting Services report.
        /// </summary>
        [AttributeLogicalName("originalbodytext")]
        public string OriginalBodyText
        {
            get { return GetAttributeValue<string>("originalbodytext"); }
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
        ///     Unique identifier of the user or team who owns the report.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId
        {
            get { return GetAttributeValue<EntityReference>("ownerid"); }
            set
            {
                OnPropertyChanging("OwnerId");
                SetAttributeValue("ownerid", value);
                OnPropertyChanged("OwnerId");
            }
        }

        /// <summary>
        ///     Unique identifier of the business unit that owns the report.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the report.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the report.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Unique identifier of the parent report.
        /// </summary>
        [AttributeLogicalName("parentreportid")]
        public EntityReference ParentReportId
        {
            get { return GetAttributeValue<EntityReference>("parentreportid"); }
            set
            {
                OnPropertyChanging("ParentReportId");
                SetAttributeValue("parentreportid", value);
                OnPropertyChanged("ParentReportId");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("queryinfo")]
        public string QueryInfo
        {
            get { return GetAttributeValue<string>("queryinfo"); }
        }

        /// <summary>
        ///     Unique identifier of the report.
        /// </summary>
        [AttributeLogicalName("reportid")]
        public Guid? ReportId
        {
            get { return GetAttributeValue<Guid?>("reportid"); }
            set
            {
                OnPropertyChanging("ReportId");
                SetAttributeValue("reportid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ReportId");
            }
        }

        [AttributeLogicalName("reportid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ReportId = value; }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("reportidunique")]
        public Guid? ReportIdUnique
        {
            get { return GetAttributeValue<Guid?>("reportidunique"); }
        }

        /// <summary>
        ///     Name of the report on SRS.
        /// </summary>
        [AttributeLogicalName("reportnameonsrs")]
        public string ReportNameOnSRS
        {
            get { return GetAttributeValue<string>("reportnameonsrs"); }
        }

        /// <summary>
        ///     Type of the report.
        /// </summary>
        [AttributeLogicalName("reporttypecode")]
        public OptionSetValue ReportTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("reporttypecode"); }
            set
            {
                OnPropertyChanging("ReportTypeCode");
                SetAttributeValue("reporttypecode", value);
                OnPropertyChanged("ReportTypeCode");
            }
        }

        /// <summary>
        ///     XML used for defining the report schedule.
        /// </summary>
        [AttributeLogicalName("schedulexml")]
        public string ScheduleXml
        {
            get { return GetAttributeValue<string>("schedulexml"); }
        }

        /// <summary>
        ///     Report signature date, used to identify a report for upgrades and hotfixes.
        /// </summary>
        [AttributeLogicalName("signaturedate")]
        public DateTime? SignatureDate
        {
            get { return GetAttributeValue<DateTime?>("signaturedate"); }
            set
            {
                OnPropertyChanging("SignatureDate");
                SetAttributeValue("signaturedate", value);
                OnPropertyChanged("SignatureDate");
            }
        }

        /// <summary>
        ///     Unique identifier of the report signature used to identify a report for upgrades and hotfixes.
        /// </summary>
        [AttributeLogicalName("signatureid")]
        public Guid? SignatureId
        {
            get { return GetAttributeValue<Guid?>("signatureid"); }
            set
            {
                OnPropertyChanging("SignatureId");
                SetAttributeValue("signatureid", value);
                OnPropertyChanged("SignatureId");
            }
        }

        /// <summary>
        ///     Report signature language code used to identify a report for upgrades and hotfixes.
        /// </summary>
        [AttributeLogicalName("signaturelcid")]
        public int? SignatureLcid
        {
            get { return GetAttributeValue<int?>("signaturelcid"); }
            set
            {
                OnPropertyChanging("SignatureLcid");
                SetAttributeValue("signaturelcid", value);
                OnPropertyChanged("SignatureLcid");
            }
        }

        /// <summary>
        ///     Report signature major version, used to identify a report for upgrades and hotfixes.
        /// </summary>
        [AttributeLogicalName("signaturemajorversion")]
        public int? SignatureMajorVersion
        {
            get { return GetAttributeValue<int?>("signaturemajorversion"); }
            set
            {
                OnPropertyChanging("SignatureMajorVersion");
                SetAttributeValue("signaturemajorversion", value);
                OnPropertyChanged("SignatureMajorVersion");
            }
        }

        /// <summary>
        ///     Report signature minor version, used to identify a report for upgrades and hotfixes.
        /// </summary>
        [AttributeLogicalName("signatureminorversion")]
        public int? SignatureMinorVersion
        {
            get { return GetAttributeValue<int?>("signatureminorversion"); }
            set
            {
                OnPropertyChanging("SignatureMinorVersion");
                SetAttributeValue("signatureminorversion", value);
                OnPropertyChanged("SignatureMinorVersion");
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
        ///     Version number of the report.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N Report_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Report_AsyncOperations")]
        public IEnumerable<AsyncOperation> Report_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Report_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Report_AsyncOperations");
                SetRelatedEntities("Report_AsyncOperations", null, value);
                OnPropertyChanged("Report_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N report_parent_report
        /// </summary>
        [RelationshipSchemaName("report_parent_report", EntityRole.Referenced)]
        public IEnumerable<Report> Referencedreport_parent_report
        {
            get { return GetRelatedEntities<Report>("report_parent_report", EntityRole.Referenced); }
            set
            {
                OnPropertyChanging("Referencedreport_parent_report");
                SetRelatedEntities("report_parent_report", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedreport_parent_report");
            }
        }

        /// <summary>
        ///     1:N Report_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("Report_ProcessSessions")]
        public IEnumerable<ProcessSession> Report_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("Report_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Report_ProcessSessions");
                SetRelatedEntities("Report_ProcessSessions", null, value);
                OnPropertyChanged("Report_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N report_reportcategories
        /// </summary>
        [RelationshipSchemaName("report_reportcategories")]
        public IEnumerable<ReportCategory> report_reportcategories
        {
            get { return GetRelatedEntities<ReportCategory>("report_reportcategories", null); }
            set
            {
                OnPropertyChanging("report_reportcategories");
                SetRelatedEntities("report_reportcategories", null, value);
                OnPropertyChanged("report_reportcategories");
            }
        }

        /// <summary>
        ///     1:N report_reportentities
        /// </summary>
        [RelationshipSchemaName("report_reportentities")]
        public IEnumerable<ReportEntity> report_reportentities
        {
            get { return GetRelatedEntities<ReportEntity>("report_reportentities", null); }
            set
            {
                OnPropertyChanging("report_reportentities");
                SetRelatedEntities("report_reportentities", null, value);
                OnPropertyChanged("report_reportentities");
            }
        }

        /// <summary>
        ///     1:N report_reportlink
        /// </summary>
        [RelationshipSchemaName("report_reportlink")]
        public IEnumerable<ReportLink> report_reportlink
        {
            get { return GetRelatedEntities<ReportLink>("report_reportlink", null); }
            set
            {
                OnPropertyChanging("report_reportlink");
                SetRelatedEntities("report_reportlink", null, value);
                OnPropertyChanged("report_reportlink");
            }
        }

        /// <summary>
        ///     1:N report_reportlink_sub
        /// </summary>
        [RelationshipSchemaName("report_reportlink_sub")]
        public IEnumerable<ReportLink> report_reportlink_sub
        {
            get { return GetRelatedEntities<ReportLink>("report_reportlink_sub", null); }
            set
            {
                OnPropertyChanging("report_reportlink_sub");
                SetRelatedEntities("report_reportlink_sub", null, value);
                OnPropertyChanged("report_reportlink_sub");
            }
        }

        /// <summary>
        ///     1:N report_reportvisibility
        /// </summary>
        [RelationshipSchemaName("report_reportvisibility")]
        public IEnumerable<ReportVisibility> report_reportvisibility
        {
            get { return GetRelatedEntities<ReportVisibility>("report_reportvisibility", null); }
            set
            {
                OnPropertyChanging("report_reportvisibility");
                SetRelatedEntities("report_reportvisibility", null, value);
                OnPropertyChanged("report_reportvisibility");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_report
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_report")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_report
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_report", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_report");
                SetRelatedEntities("userentityinstancedata_report", null, value);
                OnPropertyChanged("userentityinstancedata_report");
            }
        }

        /// <summary>
        ///     N:1 business_unit_reports
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_reports")]
        public BusinessUnit business_unit_reports
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_reports", null); }
        }

        /// <summary>
        ///     N:1 lk_report_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_report_createdonbehalfby")]
        public SystemUser lk_report_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_report_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_report_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_report_modifiedonbehalfby")]
        public SystemUser lk_report_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_report_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_reportbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_reportbase_createdby")]
        public SystemUser lk_reportbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_reportbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_reportbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_reportbase_modifiedby")]
        public SystemUser lk_reportbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_reportbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 report_parent_report
        /// </summary>
        [AttributeLogicalName("parentreportid")]
        [RelationshipSchemaName("report_parent_report", EntityRole.Referencing)]
        public Report Referencingreport_parent_report
        {
            get { return GetRelatedEntity<Report>("report_parent_report", EntityRole.Referencing); }
            set
            {
                OnPropertyChanging("Referencingreport_parent_report");
                SetRelatedEntity("report_parent_report", EntityRole.Referencing, value);
                OnPropertyChanged("Referencingreport_parent_report");
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