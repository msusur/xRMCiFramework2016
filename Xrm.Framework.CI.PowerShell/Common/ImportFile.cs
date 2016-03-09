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
    ///     File name of file used for import.
    /// </summary>
    [DataContract]
    [EntityLogicalName("importfile")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ImportFile : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "importfile";

        public const int EntityTypeCode = 4412;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ImportFile() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Shows the secondary column headers. The additional headers are used during the process of transforming the import
        ///     file into import data records.
        /// </summary>
        [AttributeLogicalName("additionalheaderrow")]
        public string AdditionalHeaderRow
        {
            get { return GetAttributeValue<string>("additionalheaderrow"); }
        }

        /// <summary>
        ///     Shows the date and time when the import associated with the import file was completed.
        /// </summary>
        [AttributeLogicalName("completedon")]
        public DateTime? CompletedOn
        {
            get { return GetAttributeValue<DateTime?>("completedon"); }
        }

        /// <summary>
        ///     Stores the content of the import file, stored as comma-separated values.
        /// </summary>
        [AttributeLogicalName("content")]
        public string Content
        {
            get { return GetAttributeValue<string>("content"); }
            set
            {
                OnPropertyChanging("Content");
                SetAttributeValue("content", value);
                OnPropertyChanged("Content");
            }
        }

        /// <summary>
        ///     Shows who created the record.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Shows the date and time when the record was created. The date and time are displayed in the time zone selected in
        ///     Microsoft Dynamics CRM options.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Shows who created the record on behalf of another user.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Select the single-character data delimiter used in the import file. This is typically a single or double quotation
        ///     mark.
        /// </summary>
        [AttributeLogicalName("datadelimitercode")]
        public OptionSetValue DataDelimiterCode
        {
            get { return GetAttributeValue<OptionSetValue>("datadelimitercode"); }
            set
            {
                OnPropertyChanging("DataDelimiterCode");
                SetAttributeValue("datadelimitercode", value);
                OnPropertyChanged("DataDelimiterCode");
            }
        }

        /// <summary>
        ///     Select whether duplicate-detection rules should be run against the import job.
        /// </summary>
        [AttributeLogicalName("enableduplicatedetection")]
        public bool? EnableDuplicateDetection
        {
            get { return GetAttributeValue<bool?>("enableduplicatedetection"); }
            set
            {
                OnPropertyChanging("EnableDuplicateDetection");
                SetAttributeValue("enableduplicatedetection", value);
                OnPropertyChanged("EnableDuplicateDetection");
            }
        }

        /// <summary>
        ///     Shows the number of records in the import file that cannot be imported.
        /// </summary>
        [AttributeLogicalName("failurecount")]
        public int? FailureCount
        {
            get { return GetAttributeValue<int?>("failurecount"); }
        }

        /// <summary>
        ///     Select the character that is used to separate each field in the import file. Typically, it is a comma.
        /// </summary>
        [AttributeLogicalName("fielddelimitercode")]
        public OptionSetValue FieldDelimiterCode
        {
            get { return GetAttributeValue<OptionSetValue>("fielddelimitercode"); }
            set
            {
                OnPropertyChanging("FieldDelimiterCode");
                SetAttributeValue("fielddelimitercode", value);
                OnPropertyChanged("FieldDelimiterCode");
            }
        }

        /// <summary>
        ///     Shows the type of source file that is uploaded for import.
        /// </summary>
        [AttributeLogicalName("filetypecode")]
        public OptionSetValue FileTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("filetypecode"); }
            set
            {
                OnPropertyChanging("FileTypeCode");
                SetAttributeValue("filetypecode", value);
                OnPropertyChanged("FileTypeCode");
            }
        }

        /// <summary>
        ///     Shows a list of each column header in the import file separated by a comma. The header is used for parsing the file
        ///     during the import job.
        /// </summary>
        [AttributeLogicalName("headerrow")]
        public string HeaderRow
        {
            get { return GetAttributeValue<string>("headerrow"); }
        }

        /// <summary>
        ///     Unique identifier of the import file.
        /// </summary>
        [AttributeLogicalName("importfileid")]
        public Guid? ImportFileId
        {
            get { return GetAttributeValue<Guid?>("importfileid"); }
            set
            {
                OnPropertyChanging("ImportFileId");
                SetAttributeValue("importfileid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ImportFileId");
            }
        }

        [AttributeLogicalName("importfileid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ImportFileId = value; }
        }

        /// <summary>
        ///     Choose the import job that the file was uploaded for.
        /// </summary>
        [AttributeLogicalName("importid")]
        public EntityReference ImportId
        {
            get { return GetAttributeValue<EntityReference>("importid"); }
            set
            {
                OnPropertyChanging("ImportId");
                SetAttributeValue("importid", value);
                OnPropertyChanged("ImportId");
            }
        }

        /// <summary>
        ///     Choose a data map to match the import file and its column headers with the record types and fields in Microsoft
        ///     Dynamics CRM. If the column headers in the file match the display names of the target fields in Microsoft Dynamics
        ///     CRM, we import the data automatically. If not, you can manually define matches during import.
        /// </summary>
        [AttributeLogicalName("importmapid")]
        public EntityReference ImportMapId
        {
            get { return GetAttributeValue<EntityReference>("importmapid"); }
            set
            {
                OnPropertyChanging("ImportMapId");
                SetAttributeValue("importmapid", value);
                OnPropertyChanged("ImportMapId");
            }
        }

        /// <summary>
        ///     Select whether the first row of the import file contains column headings, which are used for data mapping during
        ///     the import job.
        /// </summary>
        [AttributeLogicalName("isfirstrowheader")]
        public bool? IsFirstRowHeader
        {
            get { return GetAttributeValue<bool?>("isfirstrowheader"); }
            set
            {
                OnPropertyChanging("IsFirstRowHeader");
                SetAttributeValue("isfirstrowheader", value);
                OnPropertyChanged("IsFirstRowHeader");
            }
        }

        /// <summary>
        ///     Shows who last updated the record.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected
        ///     in Microsoft Dynamics CRM options.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Shows who created the record on behalf of another user.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Shows the name of the import file. This name is based on the name of the uploaded file.
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
        ///     Enter the user who is assigned to follow up with or manage the import file. This field is updated every time the
        ///     import file is assigned to a different user.
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
        ///     Shows the business unit that the record owner belongs to.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the import file.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the import file.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Shows the prefix applied to each column after the import file is parsed.
        /// </summary>
        [AttributeLogicalName("parsedtablecolumnprefix")]
        public string ParsedTableColumnPrefix
        {
            get { return GetAttributeValue<string>("parsedtablecolumnprefix"); }
        }

        /// <summary>
        ///     Shows the number of columns included in the parsed import file.
        /// </summary>
        [AttributeLogicalName("parsedtablecolumnsnumber")]
        public int? ParsedTableColumnsNumber
        {
            get { return GetAttributeValue<int?>("parsedtablecolumnsnumber"); }
        }

        /// <summary>
        ///     Shows the name of the table that contains the parsed data from the import file.
        /// </summary>
        [AttributeLogicalName("parsedtablename")]
        public string ParsedTableName
        {
            get { return GetAttributeValue<string>("parsedtablename"); }
        }

        /// <summary>
        ///     Shows the number of records in this file that had failures during the import.
        /// </summary>
        [AttributeLogicalName("partialfailurecount")]
        public int? PartialFailureCount
        {
            get { return GetAttributeValue<int?>("partialfailurecount"); }
        }

        /// <summary>
        ///     Tells whether the import file should be ignored or processed during the import.
        /// </summary>
        [AttributeLogicalName("processcode")]
        public OptionSetValue ProcessCode
        {
            get { return GetAttributeValue<OptionSetValue>("processcode"); }
            set
            {
                OnPropertyChanging("ProcessCode");
                SetAttributeValue("processcode", value);
                OnPropertyChanged("ProcessCode");
            }
        }

        /// <summary>
        ///     Shows the import file's processing status code. This indicates whether the data in the import file has been parsed,
        ///     transformed, or imported.
        /// </summary>
        [AttributeLogicalName("processingstatus")]
        public OptionSetValue ProcessingStatus
        {
            get { return GetAttributeValue<OptionSetValue>("processingstatus"); }
        }

        /// <summary>
        ///     Shows the progress code for the processing of the import file. This field is used when a paused import job is
        ///     resumed.
        /// </summary>
        [AttributeLogicalName("progresscounter")]
        public int? ProgressCounter
        {
            get { return GetAttributeValue<int?>("progresscounter"); }
        }

        /// <summary>
        ///     Choose the user that the records created during the import job should be assigned to.
        /// </summary>
        [AttributeLogicalName("recordsownerid")]
        public EntityReference RecordsOwnerId
        {
            get { return GetAttributeValue<EntityReference>("recordsownerid"); }
            set
            {
                OnPropertyChanging("RecordsOwnerId");
                SetAttributeValue("recordsownerid", value);
                OnPropertyChanged("RecordsOwnerId");
            }
        }

        /// <summary>
        ///     Shows the columns that are mapped to a related record type (entity) of the primary record type (entity) included in
        ///     the import file.
        /// </summary>
        [AttributeLogicalName("relatedentitycolumns")]
        public string RelatedEntityColumns
        {
            get { return GetAttributeValue<string>("relatedentitycolumns"); }
            set
            {
                OnPropertyChanging("RelatedEntityColumns");
                SetAttributeValue("relatedentitycolumns", value);
                OnPropertyChanged("RelatedEntityColumns");
            }
        }

        /// <summary>
        ///     Shows the size of the import file, in kilobytes.
        /// </summary>
        [AttributeLogicalName("size")]
        public string Size
        {
            get { return GetAttributeValue<string>("size"); }
            set
            {
                OnPropertyChanging("Size");
                SetAttributeValue("size", value);
                OnPropertyChanged("Size");
            }
        }

        /// <summary>
        ///     Shows the name of the data source file uploaded in the import job.
        /// </summary>
        [AttributeLogicalName("source")]
        public string Source
        {
            get { return GetAttributeValue<string>("source"); }
            set
            {
                OnPropertyChanging("Source");
                SetAttributeValue("source", value);
                OnPropertyChanged("Source");
            }
        }

        /// <summary>
        ///     Shows the record type (entity) of the source data.
        /// </summary>
        [AttributeLogicalName("sourceentityname")]
        public string SourceEntityName
        {
            get { return GetAttributeValue<string>("sourceentityname"); }
            set
            {
                OnPropertyChanging("SourceEntityName");
                SetAttributeValue("sourceentityname", value);
                OnPropertyChanged("SourceEntityName");
            }
        }

        /// <summary>
        ///     Shows the status of the import file record. By default, all records are active and can't be deactivated.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public ImportFileState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ImportFileState) (Enum.ToObject(typeof (ImportFileState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Shows the reason code that explains the import file's status to identify the stage of the import process, from
        ///     parsing the data to completed.
        /// </summary>
        [AttributeLogicalName("statuscode")]
        public OptionSetValue StatusCode
        {
            get { return GetAttributeValue<OptionSetValue>("statuscode"); }
            set
            {
                OnPropertyChanging("StatusCode");
                SetAttributeValue("statuscode", value);
                OnPropertyChanged("StatusCode");
            }
        }

        /// <summary>
        ///     Shows the number of records in the import file that are imported successfully.
        /// </summary>
        [AttributeLogicalName("successcount")]
        public int? SuccessCount
        {
            get { return GetAttributeValue<int?>("successcount"); }
        }

        /// <summary>
        ///     Select the target record type (entity) for the records that will be created during the import job.
        /// </summary>
        [AttributeLogicalName("targetentityname")]
        public string TargetEntityName
        {
            get { return GetAttributeValue<string>("targetentityname"); }
            set
            {
                OnPropertyChanging("TargetEntityName");
                SetAttributeValue("targetentityname", value);
                OnPropertyChanged("TargetEntityName");
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
        ///     Shows the total number of records in the import file.
        /// </summary>
        [AttributeLogicalName("totalcount")]
        public int? TotalCount
        {
            get { return GetAttributeValue<int?>("totalcount"); }
        }

        /// <summary>
        ///     Tells whether an automatic system map was applied to the import file, which automatically maps the import data to
        ///     the target entity in Microsoft Dynamics CRM.
        /// </summary>
        [AttributeLogicalName("usesystemmap")]
        public bool? UseSystemMap
        {
            get { return GetAttributeValue<bool?>("usesystemmap"); }
            set
            {
                OnPropertyChanging("UseSystemMap");
                SetAttributeValue("usesystemmap", value);
                OnPropertyChanged("UseSystemMap");
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
        ///     1:N ImportFile_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("ImportFile_AsyncOperations")]
        public IEnumerable<AsyncOperation> ImportFile_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("ImportFile_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("ImportFile_AsyncOperations");
                SetRelatedEntities("ImportFile_AsyncOperations", null, value);
                OnPropertyChanged("ImportFile_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N ImportFile_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("ImportFile_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> ImportFile_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("ImportFile_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("ImportFile_BulkDeleteFailures");
                SetRelatedEntities("ImportFile_BulkDeleteFailures", null, value);
                OnPropertyChanged("ImportFile_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N ImportLog_ImportFile
        /// </summary>
        [RelationshipSchemaName("ImportLog_ImportFile")]
        public IEnumerable<ImportLog> ImportLog_ImportFile
        {
            get { return GetRelatedEntities<ImportLog>("ImportLog_ImportFile", null); }
            set
            {
                OnPropertyChanging("ImportLog_ImportFile");
                SetRelatedEntities("ImportLog_ImportFile", null, value);
                OnPropertyChanged("ImportLog_ImportFile");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_importfile
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_importfile")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_importfile
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_importfile", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_importfile");
                SetRelatedEntities("userentityinstancedata_importfile", null, value);
                OnPropertyChanged("userentityinstancedata_importfile");
            }
        }

        /// <summary>
        ///     N:1 BusinessUnit_ImportFiles
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("BusinessUnit_ImportFiles")]
        public BusinessUnit BusinessUnit_ImportFiles
        {
            get { return GetRelatedEntity<BusinessUnit>("BusinessUnit_ImportFiles", null); }
        }

        /// <summary>
        ///     N:1 Import_ImportFile
        /// </summary>
        [AttributeLogicalName("importid")]
        [RelationshipSchemaName("Import_ImportFile")]
        public Import Import_ImportFile
        {
            get { return GetRelatedEntity<Import>("Import_ImportFile", null); }
            set
            {
                OnPropertyChanging("Import_ImportFile");
                SetRelatedEntity("Import_ImportFile", null, value);
                OnPropertyChanged("Import_ImportFile");
            }
        }

        /// <summary>
        ///     N:1 ImportFile_SystemUser
        /// </summary>
        [AttributeLogicalName("recordsownerid")]
        [RelationshipSchemaName("ImportFile_SystemUser")]
        public SystemUser ImportFile_SystemUser
        {
            get { return GetRelatedEntity<SystemUser>("ImportFile_SystemUser", null); }
            set
            {
                OnPropertyChanging("ImportFile_SystemUser");
                SetRelatedEntity("ImportFile_SystemUser", null, value);
                OnPropertyChanged("ImportFile_SystemUser");
            }
        }

        /// <summary>
        ///     N:1 ImportFile_Team
        /// </summary>
        [AttributeLogicalName("recordsownerid")]
        [RelationshipSchemaName("ImportFile_Team")]
        public Team ImportFile_Team
        {
            get { return GetRelatedEntity<Team>("ImportFile_Team", null); }
            set
            {
                OnPropertyChanging("ImportFile_Team");
                SetRelatedEntity("ImportFile_Team", null, value);
                OnPropertyChanged("ImportFile_Team");
            }
        }

        /// <summary>
        ///     N:1 ImportMap_ImportFile
        /// </summary>
        [AttributeLogicalName("importmapid")]
        [RelationshipSchemaName("ImportMap_ImportFile")]
        public ImportMap ImportMap_ImportFile
        {
            get { return GetRelatedEntity<ImportMap>("ImportMap_ImportFile", null); }
            set
            {
                OnPropertyChanging("ImportMap_ImportFile");
                SetRelatedEntity("ImportMap_ImportFile", null, value);
                OnPropertyChanged("ImportMap_ImportFile");
            }
        }

        /// <summary>
        ///     N:1 lk_importfilebase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_importfilebase_createdby")]
        public SystemUser lk_importfilebase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_importfilebase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_importfilebase_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_importfilebase_createdonbehalfby")]
        public SystemUser lk_importfilebase_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_importfilebase_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_importfilebase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_importfilebase_modifiedby")]
        public SystemUser lk_importfilebase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_importfilebase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_importfilebase_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_importfilebase_modifiedonbehalfby")]
        public SystemUser lk_importfilebase_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_importfilebase_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 SystemUser_ImportFiles
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("SystemUser_ImportFiles")]
        public SystemUser SystemUser_ImportFiles
        {
            get { return GetRelatedEntity<SystemUser>("SystemUser_ImportFiles", null); }
        }

        /// <summary>
        ///     N:1 team_ImportFiles
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_ImportFiles")]
        public Team team_ImportFiles
        {
            get { return GetRelatedEntity<Team>("team_ImportFiles", null); }
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