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
    ///     Failure reason and other detailed information for a record that failed to import.
    /// </summary>
    [DataContract]
    [EntityLogicalName("importlog")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ImportLog : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "importlog";

        public const int EntityTypeCode = 4423;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ImportLog() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Additional information related to the error.
        /// </summary>
        [AttributeLogicalName("additionalinfo")]
        public string AdditionalInfo
        {
            get { return GetAttributeValue<string>("additionalinfo"); }
            set
            {
                OnPropertyChanging("AdditionalInfo");
                SetAttributeValue("additionalinfo", value);
                OnPropertyChanged("AdditionalInfo");
            }
        }

        /// <summary>
        ///     Value in the column.
        /// </summary>
        [AttributeLogicalName("columnvalue")]
        public string ColumnValue
        {
            get { return GetAttributeValue<string>("columnvalue"); }
            set
            {
                OnPropertyChanging("ColumnValue");
                SetAttributeValue("columnvalue", value);
                OnPropertyChanged("ColumnValue");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the import log.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the import log was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the importlog.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Description of an error.
        /// </summary>
        [AttributeLogicalName("errordescription")]
        public string ErrorDescription
        {
            get { return GetAttributeValue<string>("errordescription"); }
            set
            {
                OnPropertyChanging("ErrorDescription");
                SetAttributeValue("errordescription", value);
                OnPropertyChanged("ErrorDescription");
            }
        }

        /// <summary>
        ///     Error code of an error.
        /// </summary>
        [AttributeLogicalName("errornumber")]
        public int? ErrorNumber
        {
            get { return GetAttributeValue<int?>("errornumber"); }
            set
            {
                OnPropertyChanging("ErrorNumber");
                SetAttributeValue("errornumber", value);
                OnPropertyChanged("ErrorNumber");
            }
        }

        /// <summary>
        ///     Name of the column heading.
        /// </summary>
        [AttributeLogicalName("headercolumn")]
        public string HeaderColumn
        {
            get { return GetAttributeValue<string>("headercolumn"); }
            set
            {
                OnPropertyChanging("HeaderColumn");
                SetAttributeValue("headercolumn", value);
                OnPropertyChanged("HeaderColumn");
            }
        }

        /// <summary>
        ///     Unique identifier of the import data for this import log.
        /// </summary>
        [AttributeLogicalName("importdataid")]
        public EntityReference ImportDataId
        {
            get { return GetAttributeValue<EntityReference>("importdataid"); }
            set
            {
                OnPropertyChanging("ImportDataId");
                SetAttributeValue("importdataid", value);
                OnPropertyChanged("ImportDataId");
            }
        }

        /// <summary>
        ///     Unique identifier of the import file for this import log.
        /// </summary>
        [AttributeLogicalName("importfileid")]
        public EntityReference ImportFileId
        {
            get { return GetAttributeValue<EntityReference>("importfileid"); }
            set
            {
                OnPropertyChanging("ImportFileId");
                SetAttributeValue("importfileid", value);
                OnPropertyChanged("ImportFileId");
            }
        }

        /// <summary>
        ///     Unique identifier of the import log.
        /// </summary>
        [AttributeLogicalName("importlogid")]
        public Guid? ImportLogId
        {
            get { return GetAttributeValue<Guid?>("importlogid"); }
            set
            {
                OnPropertyChanging("ImportLogId");
                SetAttributeValue("importlogid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ImportLogId");
            }
        }

        [AttributeLogicalName("importlogid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ImportLogId = value; }
        }

        /// <summary>
        ///     Original line number of the data used in this log.
        /// </summary>
        [AttributeLogicalName("linenumber")]
        public int? LineNumber
        {
            get { return GetAttributeValue<int?>("linenumber"); }
            set
            {
                OnPropertyChanging("LineNumber");
                SetAttributeValue("linenumber", value);
                OnPropertyChanged("LineNumber");
            }
        }

        /// <summary>
        ///     Phase for which the log is recorded.
        /// </summary>
        [AttributeLogicalName("logphasecode")]
        public OptionSetValue LogPhaseCode
        {
            get { return GetAttributeValue<OptionSetValue>("logphasecode"); }
            set
            {
                OnPropertyChanging("LogPhaseCode");
                SetAttributeValue("logphasecode", value);
                OnPropertyChanged("LogPhaseCode");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the import log.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the import log was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the importlog.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the user or team who owns the import log.
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
        ///     Business unit that owns the import log.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the import log.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the import log.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Sequence number of the error in this log.
        /// </summary>
        [AttributeLogicalName("sequencenumber")]
        public int? SequenceNumber
        {
            get { return GetAttributeValue<int?>("sequencenumber"); }
        }

        /// <summary>
        ///     Status of the import log.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public ImportLogState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ImportLogState) (Enum.ToObject(typeof (ImportLogState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the import log.
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
        ///     1:N ImportLog_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("ImportLog_AsyncOperations")]
        public IEnumerable<AsyncOperation> ImportLog_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("ImportLog_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("ImportLog_AsyncOperations");
                SetRelatedEntities("ImportLog_AsyncOperations", null, value);
                OnPropertyChanged("ImportLog_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N ImportLog_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("ImportLog_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> ImportLog_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("ImportLog_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("ImportLog_BulkDeleteFailures");
                SetRelatedEntities("ImportLog_BulkDeleteFailures", null, value);
                OnPropertyChanged("ImportLog_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_importlog
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_importlog")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_importlog
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_importlog", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_importlog");
                SetRelatedEntities("userentityinstancedata_importlog", null, value);
                OnPropertyChanged("userentityinstancedata_importlog");
            }
        }

        /// <summary>
        ///     N:1 BusinessUnit_ImportLogs
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("BusinessUnit_ImportLogs")]
        public BusinessUnit BusinessUnit_ImportLogs
        {
            get { return GetRelatedEntity<BusinessUnit>("BusinessUnit_ImportLogs", null); }
        }

        /// <summary>
        ///     N:1 ImportLog_ImportFile
        /// </summary>
        [AttributeLogicalName("importfileid")]
        [RelationshipSchemaName("ImportLog_ImportFile")]
        public ImportFile ImportLog_ImportFile
        {
            get { return GetRelatedEntity<ImportFile>("ImportLog_ImportFile", null); }
            set
            {
                OnPropertyChanging("ImportLog_ImportFile");
                SetRelatedEntity("ImportLog_ImportFile", null, value);
                OnPropertyChanged("ImportLog_ImportFile");
            }
        }

        /// <summary>
        ///     N:1 lk_importlog_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_importlog_createdonbehalfby")]
        public SystemUser lk_importlog_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_importlog_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_importlog_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_importlog_modifiedonbehalfby")]
        public SystemUser lk_importlog_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_importlog_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_importlogbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_importlogbase_createdby")]
        public SystemUser lk_importlogbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_importlogbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_importlogbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_importlogbase_modifiedby")]
        public SystemUser lk_importlogbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_importlogbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 SystemUser_ImportLogs
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("SystemUser_ImportLogs")]
        public SystemUser SystemUser_ImportLogs
        {
            get { return GetRelatedEntity<SystemUser>("SystemUser_ImportLogs", null); }
        }

        /// <summary>
        ///     N:1 team_ImportLogs
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_ImportLogs")]
        public Team team_ImportLogs
        {
            get { return GetRelatedEntity<Team>("team_ImportLogs", null); }
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