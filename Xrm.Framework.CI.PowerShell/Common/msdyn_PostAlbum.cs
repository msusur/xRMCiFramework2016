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
    ///     Contains user profile images that are stored as attachments and displayed in posts.
    /// </summary>
    [DataContract]
    [EntityLogicalName("msdyn_postalbum")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class msdyn_PostAlbum : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "msdyn_postalbum";

        public const int EntityTypeCode = 10000;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public msdyn_PostAlbum() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the user who created the record.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the record was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the record.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Sequence number of the import that created this record.
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
        ///     Unique identifier of the user who modified the record.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the record was modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who modified the record.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     The name of the custom entity.
        /// </summary>
        [AttributeLogicalName("msdyn_name")]
        public string msdyn_name
        {
            get { return GetAttributeValue<string>("msdyn_name"); }
            set
            {
                OnPropertyChanging("msdyn_name");
                SetAttributeValue("msdyn_name", value);
                OnPropertyChanged("msdyn_name");
            }
        }

        /// <summary>
        ///     Unique identifier for entity instances
        /// </summary>
        [AttributeLogicalName("msdyn_postalbumid")]
        public Guid? msdyn_PostAlbumId
        {
            get { return GetAttributeValue<Guid?>("msdyn_postalbumid"); }
            set
            {
                OnPropertyChanging("msdyn_PostAlbumId");
                SetAttributeValue("msdyn_postalbumid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("msdyn_PostAlbumId");
            }
        }

        [AttributeLogicalName("msdyn_postalbumid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { msdyn_PostAlbumId = value; }
        }

        /// <summary>
        ///     Date and time that the record was migrated.
        /// </summary>
        [AttributeLogicalName("overriddencreatedon")]
        public DateTime? OverriddenCreatedOn
        {
            get { return GetAttributeValue<DateTime?>("overriddencreatedon"); }
            set
            {
                OnPropertyChanging("OverriddenCreatedOn");
                SetAttributeValue("overriddencreatedon", value);
                OnPropertyChanged("OverriddenCreatedOn");
            }
        }

        /// <summary>
        ///     Owner Id
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
        ///     Unique identifier for the business unit that owns the record
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier for the team that owns the record.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier for the user that owns the record.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Status of the Profile Album
        /// </summary>
        [AttributeLogicalName("statecode")]
        public msdyn_PostAlbumState? statecode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((msdyn_PostAlbumState) (Enum.ToObject(typeof (msdyn_PostAlbumState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the Profile Album
        /// </summary>
        [AttributeLogicalName("statuscode")]
        public OptionSetValue statuscode
        {
            get { return GetAttributeValue<OptionSetValue>("statuscode"); }
            set
            {
                OnPropertyChanging("statuscode");
                SetAttributeValue("statuscode", value);
                OnPropertyChanged("statuscode");
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
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N msdyn_postalbum_ActivityPointers
        /// </summary>
        [RelationshipSchemaName("msdyn_postalbum_ActivityPointers")]
        public IEnumerable<ActivityPointer> msdyn_postalbum_ActivityPointers
        {
            get { return GetRelatedEntities<ActivityPointer>("msdyn_postalbum_ActivityPointers", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_ActivityPointers");
                SetRelatedEntities("msdyn_postalbum_ActivityPointers", null, value);
                OnPropertyChanged("msdyn_postalbum_ActivityPointers");
            }
        }

        /// <summary>
        ///     1:N msdyn_postalbum_Annotations
        /// </summary>
        [RelationshipSchemaName("msdyn_postalbum_Annotations")]
        public IEnumerable<Annotation> msdyn_postalbum_Annotations
        {
            get { return GetRelatedEntities<Annotation>("msdyn_postalbum_Annotations", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_Annotations");
                SetRelatedEntities("msdyn_postalbum_Annotations", null, value);
                OnPropertyChanged("msdyn_postalbum_Annotations");
            }
        }

        /// <summary>
        ///     1:N msdyn_postalbum_Appointments
        /// </summary>
        [RelationshipSchemaName("msdyn_postalbum_Appointments")]
        public IEnumerable<Appointment> msdyn_postalbum_Appointments
        {
            get { return GetRelatedEntities<Appointment>("msdyn_postalbum_Appointments", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_Appointments");
                SetRelatedEntities("msdyn_postalbum_Appointments", null, value);
                OnPropertyChanged("msdyn_postalbum_Appointments");
            }
        }

        /// <summary>
        ///     1:N msdyn_postalbum_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("msdyn_postalbum_AsyncOperations")]
        public IEnumerable<AsyncOperation> msdyn_postalbum_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("msdyn_postalbum_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_AsyncOperations");
                SetRelatedEntities("msdyn_postalbum_AsyncOperations", null, value);
                OnPropertyChanged("msdyn_postalbum_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N msdyn_postalbum_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("msdyn_postalbum_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> msdyn_postalbum_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_postalbum_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_BulkDeleteFailures");
                SetRelatedEntities("msdyn_postalbum_BulkDeleteFailures", null, value);
                OnPropertyChanged("msdyn_postalbum_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N msdyn_postalbum_connections1
        /// </summary>
        [RelationshipSchemaName("msdyn_postalbum_connections1")]
        public IEnumerable<Connection> msdyn_postalbum_connections1
        {
            get { return GetRelatedEntities<Connection>("msdyn_postalbum_connections1", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_connections1");
                SetRelatedEntities("msdyn_postalbum_connections1", null, value);
                OnPropertyChanged("msdyn_postalbum_connections1");
            }
        }

        /// <summary>
        ///     1:N msdyn_postalbum_connections2
        /// </summary>
        [RelationshipSchemaName("msdyn_postalbum_connections2")]
        public IEnumerable<Connection> msdyn_postalbum_connections2
        {
            get { return GetRelatedEntities<Connection>("msdyn_postalbum_connections2", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_connections2");
                SetRelatedEntities("msdyn_postalbum_connections2", null, value);
                OnPropertyChanged("msdyn_postalbum_connections2");
            }
        }

        /// <summary>
        ///     1:N msdyn_postalbum_DuplicateBaseRecord
        /// </summary>
        [RelationshipSchemaName("msdyn_postalbum_DuplicateBaseRecord")]
        public IEnumerable<DuplicateRecord> msdyn_postalbum_DuplicateBaseRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("msdyn_postalbum_DuplicateBaseRecord", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_DuplicateBaseRecord");
                SetRelatedEntities("msdyn_postalbum_DuplicateBaseRecord", null, value);
                OnPropertyChanged("msdyn_postalbum_DuplicateBaseRecord");
            }
        }

        /// <summary>
        ///     1:N msdyn_postalbum_DuplicateMatchingRecord
        /// </summary>
        [RelationshipSchemaName("msdyn_postalbum_DuplicateMatchingRecord")]
        public IEnumerable<DuplicateRecord> msdyn_postalbum_DuplicateMatchingRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("msdyn_postalbum_DuplicateMatchingRecord", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_DuplicateMatchingRecord");
                SetRelatedEntities("msdyn_postalbum_DuplicateMatchingRecord", null, value);
                OnPropertyChanged("msdyn_postalbum_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        ///     1:N msdyn_postalbum_Emails
        /// </summary>
        [RelationshipSchemaName("msdyn_postalbum_Emails")]
        public IEnumerable<Email> msdyn_postalbum_Emails
        {
            get { return GetRelatedEntities<Email>("msdyn_postalbum_Emails", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_Emails");
                SetRelatedEntities("msdyn_postalbum_Emails", null, value);
                OnPropertyChanged("msdyn_postalbum_Emails");
            }
        }

        /// <summary>
        ///     1:N msdyn_postalbum_Faxes
        /// </summary>
        [RelationshipSchemaName("msdyn_postalbum_Faxes")]
        public IEnumerable<Fax> msdyn_postalbum_Faxes
        {
            get { return GetRelatedEntities<Fax>("msdyn_postalbum_Faxes", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_Faxes");
                SetRelatedEntities("msdyn_postalbum_Faxes", null, value);
                OnPropertyChanged("msdyn_postalbum_Faxes");
            }
        }

        /// <summary>
        ///     1:N msdyn_postalbum_Letters
        /// </summary>
        [RelationshipSchemaName("msdyn_postalbum_Letters")]
        public IEnumerable<Letter> msdyn_postalbum_Letters
        {
            get { return GetRelatedEntities<Letter>("msdyn_postalbum_Letters", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_Letters");
                SetRelatedEntities("msdyn_postalbum_Letters", null, value);
                OnPropertyChanged("msdyn_postalbum_Letters");
            }
        }

        /// <summary>
        ///     1:N msdyn_postalbum_PhoneCalls
        /// </summary>
        [RelationshipSchemaName("msdyn_postalbum_PhoneCalls")]
        public IEnumerable<PhoneCall> msdyn_postalbum_PhoneCalls
        {
            get { return GetRelatedEntities<PhoneCall>("msdyn_postalbum_PhoneCalls", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_PhoneCalls");
                SetRelatedEntities("msdyn_postalbum_PhoneCalls", null, value);
                OnPropertyChanged("msdyn_postalbum_PhoneCalls");
            }
        }

        /// <summary>
        ///     1:N msdyn_postalbum_PrincipalObjectAttributeAccesses
        /// </summary>
        [RelationshipSchemaName("msdyn_postalbum_PrincipalObjectAttributeAccesses")]
        public IEnumerable<PrincipalObjectAttributeAccess> msdyn_postalbum_PrincipalObjectAttributeAccesses
        {
            get
            {
                return
                    GetRelatedEntities<PrincipalObjectAttributeAccess>(
                        "msdyn_postalbum_PrincipalObjectAttributeAccesses", null);
            }
            set
            {
                OnPropertyChanging("msdyn_postalbum_PrincipalObjectAttributeAccesses");
                SetRelatedEntities("msdyn_postalbum_PrincipalObjectAttributeAccesses", null, value);
                OnPropertyChanged("msdyn_postalbum_PrincipalObjectAttributeAccesses");
            }
        }

        /// <summary>
        ///     1:N msdyn_postalbum_ProcessSession
        /// </summary>
        [RelationshipSchemaName("msdyn_postalbum_ProcessSession")]
        public IEnumerable<ProcessSession> msdyn_postalbum_ProcessSession
        {
            get { return GetRelatedEntities<ProcessSession>("msdyn_postalbum_ProcessSession", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_ProcessSession");
                SetRelatedEntities("msdyn_postalbum_ProcessSession", null, value);
                OnPropertyChanged("msdyn_postalbum_ProcessSession");
            }
        }

        /// <summary>
        ///     1:N msdyn_postalbum_RecurringAppointmentMasters
        /// </summary>
        [RelationshipSchemaName("msdyn_postalbum_RecurringAppointmentMasters")]
        public IEnumerable<RecurringAppointmentMaster> msdyn_postalbum_RecurringAppointmentMasters
        {
            get
            {
                return GetRelatedEntities<RecurringAppointmentMaster>("msdyn_postalbum_RecurringAppointmentMasters",
                    null);
            }
            set
            {
                OnPropertyChanging("msdyn_postalbum_RecurringAppointmentMasters");
                SetRelatedEntities("msdyn_postalbum_RecurringAppointmentMasters", null, value);
                OnPropertyChanged("msdyn_postalbum_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        ///     1:N msdyn_postalbum_ServiceAppointments
        /// </summary>
        [RelationshipSchemaName("msdyn_postalbum_ServiceAppointments")]
        public IEnumerable<ServiceAppointment> msdyn_postalbum_ServiceAppointments
        {
            get { return GetRelatedEntities<ServiceAppointment>("msdyn_postalbum_ServiceAppointments", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_ServiceAppointments");
                SetRelatedEntities("msdyn_postalbum_ServiceAppointments", null, value);
                OnPropertyChanged("msdyn_postalbum_ServiceAppointments");
            }
        }

        /// <summary>
        ///     1:N msdyn_postalbum_Tasks
        /// </summary>
        [RelationshipSchemaName("msdyn_postalbum_Tasks")]
        public IEnumerable<Task> msdyn_postalbum_Tasks
        {
            get { return GetRelatedEntities<Task>("msdyn_postalbum_Tasks", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_Tasks");
                SetRelatedEntities("msdyn_postalbum_Tasks", null, value);
                OnPropertyChanged("msdyn_postalbum_Tasks");
            }
        }

        /// <summary>
        ///     1:N msdyn_postalbum_UserEntityInstanceDatas
        /// </summary>
        [RelationshipSchemaName("msdyn_postalbum_UserEntityInstanceDatas")]
        public IEnumerable<UserEntityInstanceData> msdyn_postalbum_UserEntityInstanceDatas
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("msdyn_postalbum_UserEntityInstanceDatas", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_UserEntityInstanceDatas");
                SetRelatedEntities("msdyn_postalbum_UserEntityInstanceDatas", null, value);
                OnPropertyChanged("msdyn_postalbum_UserEntityInstanceDatas");
            }
        }

        /// <summary>
        ///     N:1 business_unit_msdyn_postalbum
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_msdyn_postalbum")]
        public BusinessUnit business_unit_msdyn_postalbum
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_msdyn_postalbum", null); }
        }

        /// <summary>
        ///     N:1 lk_msdyn_postalbum_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_msdyn_postalbum_createdby")]
        public SystemUser lk_msdyn_postalbum_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_msdyn_postalbum_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_msdyn_postalbum_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_msdyn_postalbum_createdonbehalfby")]
        public SystemUser lk_msdyn_postalbum_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_msdyn_postalbum_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_msdyn_postalbum_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_msdyn_postalbum_modifiedby")]
        public SystemUser lk_msdyn_postalbum_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_msdyn_postalbum_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_msdyn_postalbum_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_msdyn_postalbum_modifiedonbehalfby")]
        public SystemUser lk_msdyn_postalbum_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_msdyn_postalbum_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 team_msdyn_postalbum
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_msdyn_postalbum")]
        public Team team_msdyn_postalbum
        {
            get { return GetRelatedEntity<Team>("team_msdyn_postalbum", null); }
        }

        /// <summary>
        ///     N:1 user_msdyn_postalbum
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_msdyn_postalbum")]
        public SystemUser user_msdyn_postalbum
        {
            get { return GetRelatedEntity<SystemUser>("user_msdyn_postalbum", null); }
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