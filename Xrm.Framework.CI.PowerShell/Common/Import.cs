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
    ///     Status and ownership information for an import job.
    /// </summary>
    [DataContract]
    [EntityLogicalName("import")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Import : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "import";

        public const int EntityTypeCode = 4410;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Import() :
            base(EntityLogicalName)
        {
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
        ///     Shows the date and time when the import was initiated.
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
        ///     Type the email address that the import completion notification must be sent to.
        /// </summary>
        [AttributeLogicalName("emailaddress")]
        public string EMailAddress
        {
            get { return GetAttributeValue<string>("emailaddress"); }
            set
            {
                OnPropertyChanging("EMailAddress");
                SetAttributeValue("emailaddress", value);
                OnPropertyChanged("EMailAddress");
            }
        }

        /// <summary>
        ///     Unique identifier of the import job.
        /// </summary>
        [AttributeLogicalName("importid")]
        public Guid? ImportId
        {
            get { return GetAttributeValue<Guid?>("importid"); }
            set
            {
                OnPropertyChanging("ImportId");
                SetAttributeValue("importid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ImportId");
            }
        }

        [AttributeLogicalName("importid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ImportId = value; }
        }

        /// <summary>
        ///     Information about whether the source of this import job is data import or data migration.
        /// </summary>
        [AttributeLogicalName("isimport")]
        [Obsolete]
        public bool? IsImport
        {
            get { return GetAttributeValue<bool?>("isimport"); }
            set
            {
                OnPropertyChanging("IsImport");
                SetAttributeValue("isimport", value);
                OnPropertyChanged("IsImport");
            }
        }

        /// <summary>
        ///     Select whether to create or update records in Microsoft Dynamics CRM during the import job.
        /// </summary>
        [AttributeLogicalName("modecode")]
        public OptionSetValue ModeCode
        {
            get { return GetAttributeValue<OptionSetValue>("modecode"); }
            set
            {
                OnPropertyChanging("ModeCode");
                SetAttributeValue("modecode", value);
                OnPropertyChanged("ModeCode");
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
        ///     Shows the name of the import job, based on the import file and the entity being imported.
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
        ///     Enter the user or team who is assigned to manage the record. This field is updated every time the record is
        ///     assigned to a different user.
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
        ///     Business unit that owns the import job.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the import.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the import.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Select whether to send a notification email message to a selected user after the import is completed.
        /// </summary>
        [AttributeLogicalName("sendnotification")]
        public bool? SendNotification
        {
            get { return GetAttributeValue<bool?>("sendnotification"); }
            set
            {
                OnPropertyChanging("SendNotification");
                SetAttributeValue("sendnotification", value);
                OnPropertyChanged("SendNotification");
            }
        }

        /// <summary>
        ///     Order in which the import was created.
        /// </summary>
        [AttributeLogicalName("sequence")]
        public int? Sequence
        {
            get { return GetAttributeValue<int?>("sequence"); }
        }

        /// <summary>
        ///     Shows the status of the import job. By default, import jobs are active and can't be deactivated.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public ImportState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ImportState) (Enum.ToObject(typeof (ImportState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Shows the reason code that explains the import job's status to identify the job's stage of the import processes,
        ///     from transforming the data to completed.
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
        ///     1:N Import_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Import_AsyncOperations")]
        public IEnumerable<AsyncOperation> Import_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Import_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Import_AsyncOperations");
                SetRelatedEntities("Import_AsyncOperations", null, value);
                OnPropertyChanged("Import_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N Import_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("Import_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> Import_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("Import_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("Import_BulkDeleteFailures");
                SetRelatedEntities("Import_BulkDeleteFailures", null, value);
                OnPropertyChanged("Import_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N Import_ImportFile
        /// </summary>
        [RelationshipSchemaName("Import_ImportFile")]
        public IEnumerable<ImportFile> Import_ImportFile
        {
            get { return GetRelatedEntities<ImportFile>("Import_ImportFile", null); }
            set
            {
                OnPropertyChanging("Import_ImportFile");
                SetRelatedEntities("Import_ImportFile", null, value);
                OnPropertyChanged("Import_ImportFile");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_import
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_import")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_import
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_import", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_import");
                SetRelatedEntities("userentityinstancedata_import", null, value);
                OnPropertyChanged("userentityinstancedata_import");
            }
        }

        /// <summary>
        ///     N:1 BusinessUnit_Imports
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("BusinessUnit_Imports")]
        public BusinessUnit BusinessUnit_Imports
        {
            get { return GetRelatedEntity<BusinessUnit>("BusinessUnit_Imports", null); }
        }

        /// <summary>
        ///     N:1 lk_import_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_import_createdonbehalfby")]
        public SystemUser lk_import_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_import_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_import_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_import_modifiedonbehalfby")]
        public SystemUser lk_import_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_import_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_importbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_importbase_createdby")]
        public SystemUser lk_importbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_importbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_importbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_importbase_modifiedby")]
        public SystemUser lk_importbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_importbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 SystemUser_Imports
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("SystemUser_Imports")]
        public SystemUser SystemUser_Imports
        {
            get { return GetRelatedEntity<SystemUser>("SystemUser_Imports", null); }
        }

        /// <summary>
        ///     N:1 team_Imports
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_Imports")]
        public Team team_Imports
        {
            get { return GetRelatedEntity<Team>("team_Imports", null); }
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