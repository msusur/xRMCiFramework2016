using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Xrm.Framework.CI.PowerShell.Common;

namespace Xrm.Framework.CI.Common.Entities
{
    /// <summary>
    ///     Per User item instance data
    /// </summary>
    [DataContract]
    [EntityLogicalName("userentityinstancedata")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class UserEntityInstanceData : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "userentityinstancedata";

        public const int EntityTypeCode = 2501;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public UserEntityInstanceData() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Common end date
        /// </summary>
        [AttributeLogicalName("commonend")]
        public DateTime? CommonEnd
        {
            get { return GetAttributeValue<DateTime?>("commonend"); }
            set
            {
                OnPropertyChanging("CommonEnd");
                SetAttributeValue("commonend", value);
                OnPropertyChanged("CommonEnd");
            }
        }

        /// <summary>
        ///     Common start date
        /// </summary>
        [AttributeLogicalName("commonstart")]
        public DateTime? CommonStart
        {
            get { return GetAttributeValue<DateTime?>("commonstart"); }
            set
            {
                OnPropertyChanging("CommonStart");
                SetAttributeValue("commonstart", value);
                OnPropertyChanged("CommonStart");
            }
        }

        /// <summary>
        ///     Due Date
        /// </summary>
        [AttributeLogicalName("duedate")]
        public DateTime? DueDate
        {
            get { return GetAttributeValue<DateTime?>("duedate"); }
            set
            {
                OnPropertyChanging("DueDate");
                SetAttributeValue("duedate", value);
                OnPropertyChanged("DueDate");
            }
        }

        /// <summary>
        ///     Flag due by
        /// </summary>
        [AttributeLogicalName("flagdueby")]
        public DateTime? FlagDueBy
        {
            get { return GetAttributeValue<DateTime?>("flagdueby"); }
            set
            {
                OnPropertyChanging("FlagDueBy");
                SetAttributeValue("flagdueby", value);
                OnPropertyChanged("FlagDueBy");
            }
        }

        /// <summary>
        ///     Flag request
        /// </summary>
        [AttributeLogicalName("flagrequest")]
        public string FlagRequest
        {
            get { return GetAttributeValue<string>("flagrequest"); }
            set
            {
                OnPropertyChanging("FlagRequest");
                SetAttributeValue("flagrequest", value);
                OnPropertyChanged("FlagRequest");
            }
        }

        /// <summary>
        ///     Flag status.
        /// </summary>
        [AttributeLogicalName("flagstatus")]
        public int? FlagStatus
        {
            get { return GetAttributeValue<int?>("flagstatus"); }
            set
            {
                OnPropertyChanging("FlagStatus");
                SetAttributeValue("flagstatus", value);
                OnPropertyChanged("FlagStatus");
            }
        }

        /// <summary>
        ///     Unique identifier of the source record.
        /// </summary>
        [AttributeLogicalName("objectid")]
        public EntityReference ObjectId
        {
            get { return GetAttributeValue<EntityReference>("objectid"); }
            set
            {
                OnPropertyChanging("ObjectId");
                SetAttributeValue("objectid", value);
                OnPropertyChanged("ObjectId");
            }
        }

        /// <summary>
        ///     Object Type Code
        /// </summary>
        [AttributeLogicalName("objecttypecode")]
        public int? ObjectTypeCode
        {
            get { return GetAttributeValue<int?>("objecttypecode"); }
            set
            {
                OnPropertyChanging("ObjectTypeCode");
                SetAttributeValue("objecttypecode", value);
                OnPropertyChanged("ObjectTypeCode");
            }
        }

        /// <summary>
        ///     Unique identifier of the user or team who owns the user entity instance data.
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
        ///     Unique identifier of the business unit that owns this.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns this object.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns this object.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Personal categories
        /// </summary>
        [AttributeLogicalName("personalcategories")]
        public string PersonalCategories
        {
            get { return GetAttributeValue<string>("personalcategories"); }
            set
            {
                OnPropertyChanging("PersonalCategories");
                SetAttributeValue("personalcategories", value);
                OnPropertyChanged("PersonalCategories");
            }
        }

        /// <summary>
        ///     Indicates whether a reminder is set on this object.
        /// </summary>
        [AttributeLogicalName("reminderset")]
        public bool? ReminderSet
        {
            get { return GetAttributeValue<bool?>("reminderset"); }
            set
            {
                OnPropertyChanging("ReminderSet");
                SetAttributeValue("reminderset", value);
                OnPropertyChanged("ReminderSet");
            }
        }

        /// <summary>
        ///     Reminder time
        /// </summary>
        [AttributeLogicalName("remindertime")]
        public DateTime? ReminderTime
        {
            get { return GetAttributeValue<DateTime?>("remindertime"); }
            set
            {
                OnPropertyChanging("ReminderTime");
                SetAttributeValue("remindertime", value);
                OnPropertyChanged("ReminderTime");
            }
        }

        /// <summary>
        ///     Start Time
        /// </summary>
        [AttributeLogicalName("starttime")]
        public DateTime? StartTime
        {
            get { return GetAttributeValue<DateTime?>("starttime"); }
            set
            {
                OnPropertyChanging("StartTime");
                SetAttributeValue("starttime", value);
                OnPropertyChanged("StartTime");
            }
        }

        /// <summary>
        ///     To Do item flags.
        /// </summary>
        [AttributeLogicalName("todoitemflags")]
        public int? ToDoItemFlags
        {
            get { return GetAttributeValue<int?>("todoitemflags"); }
            set
            {
                OnPropertyChanging("ToDoItemFlags");
                SetAttributeValue("todoitemflags", value);
                OnPropertyChanged("ToDoItemFlags");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("todoordinaldate")]
        public DateTime? ToDoOrdinalDate
        {
            get { return GetAttributeValue<DateTime?>("todoordinaldate"); }
            set
            {
                OnPropertyChanging("ToDoOrdinalDate");
                SetAttributeValue("todoordinaldate", value);
                OnPropertyChanged("ToDoOrdinalDate");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("todosubordinal")]
        public string ToDoSubOrdinal
        {
            get { return GetAttributeValue<string>("todosubordinal"); }
            set
            {
                OnPropertyChanging("ToDoSubOrdinal");
                SetAttributeValue("todosubordinal", value);
                OnPropertyChanged("ToDoSubOrdinal");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("todotitle")]
        public string ToDoTitle
        {
            get { return GetAttributeValue<string>("todotitle"); }
            set
            {
                OnPropertyChanging("ToDoTitle");
                SetAttributeValue("todotitle", value);
                OnPropertyChanged("ToDoTitle");
            }
        }

        /// <summary>
        ///     Unique identifier user entity
        /// </summary>
        [AttributeLogicalName("userentityinstancedataid")]
        public Guid? UserEntityInstanceDataId
        {
            get { return GetAttributeValue<Guid?>("userentityinstancedataid"); }
            set
            {
                OnPropertyChanging("UserEntityInstanceDataId");
                SetAttributeValue("userentityinstancedataid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("UserEntityInstanceDataId");
            }
        }

        [AttributeLogicalName("userentityinstancedataid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { UserEntityInstanceDataId = value; }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     N:1 mailbox_userentityinstancedatas
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("mailbox_userentityinstancedatas")]
        public Mailbox mailbox_userentityinstancedatas
        {
            get { return GetRelatedEntity<Mailbox>("mailbox_userentityinstancedatas", null); }
            set
            {
                OnPropertyChanging("mailbox_userentityinstancedatas");
                SetRelatedEntity("mailbox_userentityinstancedatas", null, value);
                OnPropertyChanged("mailbox_userentityinstancedatas");
            }
        }

        /// <summary>
        ///     N:1 msdyn_postalbum_UserEntityInstanceDatas
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("msdyn_postalbum_UserEntityInstanceDatas")]
        public msdyn_PostAlbum msdyn_postalbum_UserEntityInstanceDatas
        {
            get { return GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_UserEntityInstanceDatas", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_UserEntityInstanceDatas");
                SetRelatedEntity("msdyn_postalbum_UserEntityInstanceDatas", null, value);
                OnPropertyChanged("msdyn_postalbum_UserEntityInstanceDatas");
            }
        }

        /// <summary>
        ///     N:1 msdyn_postconfig_UserEntityInstanceDatas
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("msdyn_postconfig_UserEntityInstanceDatas")]
        public msdyn_PostConfig msdyn_postconfig_UserEntityInstanceDatas
        {
            get { return GetRelatedEntity<msdyn_PostConfig>("msdyn_postconfig_UserEntityInstanceDatas", null); }
            set
            {
                OnPropertyChanging("msdyn_postconfig_UserEntityInstanceDatas");
                SetRelatedEntity("msdyn_postconfig_UserEntityInstanceDatas", null, value);
                OnPropertyChanged("msdyn_postconfig_UserEntityInstanceDatas");
            }
        }

        /// <summary>
        ///     N:1 msdyn_postruleconfig_UserEntityInstanceDatas
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("msdyn_postruleconfig_UserEntityInstanceDatas")]
        public msdyn_PostRuleConfig msdyn_postruleconfig_UserEntityInstanceDatas
        {
            get { return GetRelatedEntity<msdyn_PostRuleConfig>("msdyn_postruleconfig_UserEntityInstanceDatas", null); }
            set
            {
                OnPropertyChanging("msdyn_postruleconfig_UserEntityInstanceDatas");
                SetRelatedEntity("msdyn_postruleconfig_UserEntityInstanceDatas", null, value);
                OnPropertyChanged("msdyn_postruleconfig_UserEntityInstanceDatas");
            }
        }

        /// <summary>
        ///     N:1 msdyn_wallsavedquery_UserEntityInstanceDatas
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("msdyn_wallsavedquery_UserEntityInstanceDatas")]
        public msdyn_wallsavedquery msdyn_wallsavedquery_UserEntityInstanceDatas
        {
            get { return GetRelatedEntity<msdyn_wallsavedquery>("msdyn_wallsavedquery_UserEntityInstanceDatas", null); }
            set
            {
                OnPropertyChanging("msdyn_wallsavedquery_UserEntityInstanceDatas");
                SetRelatedEntity("msdyn_wallsavedquery_UserEntityInstanceDatas", null, value);
                OnPropertyChanged("msdyn_wallsavedquery_UserEntityInstanceDatas");
            }
        }

        /// <summary>
        ///     N:1 msdyn_wallsavedqueryusersettings_UserEntityInstanceDatas
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("msdyn_wallsavedqueryusersettings_UserEntityInstanceDatas")]
        public msdyn_wallsavedqueryusersettings msdyn_wallsavedqueryusersettings_UserEntityInstanceDatas
        {
            get
            {
                return
                    GetRelatedEntity<msdyn_wallsavedqueryusersettings>(
                        "msdyn_wallsavedqueryusersettings_UserEntityInstanceDatas", null);
            }
            set
            {
                OnPropertyChanging("msdyn_wallsavedqueryusersettings_UserEntityInstanceDatas");
                SetRelatedEntity("msdyn_wallsavedqueryusersettings_UserEntityInstanceDatas", null, value);
                OnPropertyChanged("msdyn_wallsavedqueryusersettings_UserEntityInstanceDatas");
            }
        }

        /// <summary>
        ///     N:1 team_userentityinstancedata
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_userentityinstancedata")]
        public Team team_userentityinstancedata
        {
            get { return GetRelatedEntity<Team>("team_userentityinstancedata", null); }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_account
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_account")]
        public Account userentityinstancedata_account
        {
            get { return GetRelatedEntity<Account>("userentityinstancedata_account", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_account");
                SetRelatedEntity("userentityinstancedata_account", null, value);
                OnPropertyChanged("userentityinstancedata_account");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_activitymimeattachment
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_activitymimeattachment")]
        public ActivityMimeAttachment userentityinstancedata_activitymimeattachment
        {
            get
            {
                return GetRelatedEntity<ActivityMimeAttachment>("userentityinstancedata_activitymimeattachment", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_activitymimeattachment");
                SetRelatedEntity("userentityinstancedata_activitymimeattachment", null, value);
                OnPropertyChanged("userentityinstancedata_activitymimeattachment");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_activityparty
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_activityparty")]
        public ActivityParty userentityinstancedata_activityparty
        {
            get { return GetRelatedEntity<ActivityParty>("userentityinstancedata_activityparty", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_activityparty");
                SetRelatedEntity("userentityinstancedata_activityparty", null, value);
                OnPropertyChanged("userentityinstancedata_activityparty");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_annotation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_annotation")]
        public Annotation userentityinstancedata_annotation
        {
            get { return GetRelatedEntity<Annotation>("userentityinstancedata_annotation", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_annotation");
                SetRelatedEntity("userentityinstancedata_annotation", null, value);
                OnPropertyChanged("userentityinstancedata_annotation");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_appointment
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_appointment")]
        public Appointment userentityinstancedata_appointment
        {
            get { return GetRelatedEntity<Appointment>("userentityinstancedata_appointment", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_appointment");
                SetRelatedEntity("userentityinstancedata_appointment", null, value);
                OnPropertyChanged("userentityinstancedata_appointment");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_asyncoperation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_asyncoperation")]
        public AsyncOperation userentityinstancedata_asyncoperation
        {
            get { return GetRelatedEntity<AsyncOperation>("userentityinstancedata_asyncoperation", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_asyncoperation");
                SetRelatedEntity("userentityinstancedata_asyncoperation", null, value);
                OnPropertyChanged("userentityinstancedata_asyncoperation");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_attributemap
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_attributemap")]
        public AttributeMap userentityinstancedata_attributemap
        {
            get { return GetRelatedEntity<AttributeMap>("userentityinstancedata_attributemap", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_attributemap");
                SetRelatedEntity("userentityinstancedata_attributemap", null, value);
                OnPropertyChanged("userentityinstancedata_attributemap");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_audit
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_audit")]
        public Audit userentityinstancedata_audit
        {
            get { return GetRelatedEntity<Audit>("userentityinstancedata_audit", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_audit");
                SetRelatedEntity("userentityinstancedata_audit", null, value);
                OnPropertyChanged("userentityinstancedata_audit");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_bulkdeletefailure
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_bulkdeletefailure")]
        public BulkDeleteFailure userentityinstancedata_bulkdeletefailure
        {
            get { return GetRelatedEntity<BulkDeleteFailure>("userentityinstancedata_bulkdeletefailure", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_bulkdeletefailure");
                SetRelatedEntity("userentityinstancedata_bulkdeletefailure", null, value);
                OnPropertyChanged("userentityinstancedata_bulkdeletefailure");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_bulkdeleteoperation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_bulkdeleteoperation")]
        public BulkDeleteOperation userentityinstancedata_bulkdeleteoperation
        {
            get { return GetRelatedEntity<BulkDeleteOperation>("userentityinstancedata_bulkdeleteoperation", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_bulkdeleteoperation");
                SetRelatedEntity("userentityinstancedata_bulkdeleteoperation", null, value);
                OnPropertyChanged("userentityinstancedata_bulkdeleteoperation");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_bulkoperation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_bulkoperation")]
        public BulkOperation userentityinstancedata_bulkoperation
        {
            get { return GetRelatedEntity<BulkOperation>("userentityinstancedata_bulkoperation", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_bulkoperation");
                SetRelatedEntity("userentityinstancedata_bulkoperation", null, value);
                OnPropertyChanged("userentityinstancedata_bulkoperation");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_bulkoperationlog
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_bulkoperationlog")]
        public BulkOperationLog userentityinstancedata_bulkoperationlog
        {
            get { return GetRelatedEntity<BulkOperationLog>("userentityinstancedata_bulkoperationlog", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_bulkoperationlog");
                SetRelatedEntity("userentityinstancedata_bulkoperationlog", null, value);
                OnPropertyChanged("userentityinstancedata_bulkoperationlog");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_businessunit
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("userentityinstancedata_businessunit")]
        public BusinessUnit userentityinstancedata_businessunit
        {
            get { return GetRelatedEntity<BusinessUnit>("userentityinstancedata_businessunit", null); }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_businessunitnewsarticle
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_businessunitnewsarticle")]
        public BusinessUnitNewsArticle userentityinstancedata_businessunitnewsarticle
        {
            get
            {
                return GetRelatedEntity<BusinessUnitNewsArticle>("userentityinstancedata_businessunitnewsarticle", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_businessunitnewsarticle");
                SetRelatedEntity("userentityinstancedata_businessunitnewsarticle", null, value);
                OnPropertyChanged("userentityinstancedata_businessunitnewsarticle");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_calendar
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_calendar")]
        public Calendar userentityinstancedata_calendar
        {
            get { return GetRelatedEntity<Calendar>("userentityinstancedata_calendar", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_calendar");
                SetRelatedEntity("userentityinstancedata_calendar", null, value);
                OnPropertyChanged("userentityinstancedata_calendar");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_campaign
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_campaign")]
        public Campaign userentityinstancedata_campaign
        {
            get { return GetRelatedEntity<Campaign>("userentityinstancedata_campaign", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_campaign");
                SetRelatedEntity("userentityinstancedata_campaign", null, value);
                OnPropertyChanged("userentityinstancedata_campaign");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_campaignactivity
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_campaignactivity")]
        public CampaignActivity userentityinstancedata_campaignactivity
        {
            get { return GetRelatedEntity<CampaignActivity>("userentityinstancedata_campaignactivity", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_campaignactivity");
                SetRelatedEntity("userentityinstancedata_campaignactivity", null, value);
                OnPropertyChanged("userentityinstancedata_campaignactivity");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_campaignactivityitem
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_campaignactivityitem")]
        public CampaignActivityItem userentityinstancedata_campaignactivityitem
        {
            get { return GetRelatedEntity<CampaignActivityItem>("userentityinstancedata_campaignactivityitem", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_campaignactivityitem");
                SetRelatedEntity("userentityinstancedata_campaignactivityitem", null, value);
                OnPropertyChanged("userentityinstancedata_campaignactivityitem");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_campaignitem
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_campaignitem")]
        public CampaignItem userentityinstancedata_campaignitem
        {
            get { return GetRelatedEntity<CampaignItem>("userentityinstancedata_campaignitem", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_campaignitem");
                SetRelatedEntity("userentityinstancedata_campaignitem", null, value);
                OnPropertyChanged("userentityinstancedata_campaignitem");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_campaignresponse
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_campaignresponse")]
        public CampaignResponse userentityinstancedata_campaignresponse
        {
            get { return GetRelatedEntity<CampaignResponse>("userentityinstancedata_campaignresponse", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_campaignresponse");
                SetRelatedEntity("userentityinstancedata_campaignresponse", null, value);
                OnPropertyChanged("userentityinstancedata_campaignresponse");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_columnmapping
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_columnmapping")]
        public ColumnMapping userentityinstancedata_columnmapping
        {
            get { return GetRelatedEntity<ColumnMapping>("userentityinstancedata_columnmapping", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_columnmapping");
                SetRelatedEntity("userentityinstancedata_columnmapping", null, value);
                OnPropertyChanged("userentityinstancedata_columnmapping");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_competitor
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_competitor")]
        public Competitor userentityinstancedata_competitor
        {
            get { return GetRelatedEntity<Competitor>("userentityinstancedata_competitor", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_competitor");
                SetRelatedEntity("userentityinstancedata_competitor", null, value);
                OnPropertyChanged("userentityinstancedata_competitor");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_competitorproduct
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_competitorproduct")]
        public CompetitorProduct userentityinstancedata_competitorproduct
        {
            get { return GetRelatedEntity<CompetitorProduct>("userentityinstancedata_competitorproduct", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_competitorproduct");
                SetRelatedEntity("userentityinstancedata_competitorproduct", null, value);
                OnPropertyChanged("userentityinstancedata_competitorproduct");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_competitorsalesliterature
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_competitorsalesliterature")]
        public CompetitorSalesLiterature userentityinstancedata_competitorsalesliterature
        {
            get
            {
                return GetRelatedEntity<CompetitorSalesLiterature>("userentityinstancedata_competitorsalesliterature",
                    null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_competitorsalesliterature");
                SetRelatedEntity("userentityinstancedata_competitorsalesliterature", null, value);
                OnPropertyChanged("userentityinstancedata_competitorsalesliterature");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_connection
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_connection")]
        public Connection userentityinstancedata_connection
        {
            get { return GetRelatedEntity<Connection>("userentityinstancedata_connection", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_connection");
                SetRelatedEntity("userentityinstancedata_connection", null, value);
                OnPropertyChanged("userentityinstancedata_connection");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_connectionrole
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_connectionrole")]
        public ConnectionRole userentityinstancedata_connectionrole
        {
            get { return GetRelatedEntity<ConnectionRole>("userentityinstancedata_connectionrole", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_connectionrole");
                SetRelatedEntity("userentityinstancedata_connectionrole", null, value);
                OnPropertyChanged("userentityinstancedata_connectionrole");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_connectionroleassociation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_connectionroleassociation")]
        public ConnectionRoleAssociation userentityinstancedata_connectionroleassociation
        {
            get
            {
                return GetRelatedEntity<ConnectionRoleAssociation>("userentityinstancedata_connectionroleassociation",
                    null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_connectionroleassociation");
                SetRelatedEntity("userentityinstancedata_connectionroleassociation", null, value);
                OnPropertyChanged("userentityinstancedata_connectionroleassociation");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_connectionroleobjecttypecode
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_connectionroleobjecttypecode")]
        public ConnectionRoleObjectTypeCode userentityinstancedata_connectionroleobjecttypecode
        {
            get
            {
                return
                    GetRelatedEntity<ConnectionRoleObjectTypeCode>(
                        "userentityinstancedata_connectionroleobjecttypecode", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_connectionroleobjecttypecode");
                SetRelatedEntity("userentityinstancedata_connectionroleobjecttypecode", null, value);
                OnPropertyChanged("userentityinstancedata_connectionroleobjecttypecode");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_constraintbasedgroup
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_constraintbasedgroup")]
        public ConstraintBasedGroup userentityinstancedata_constraintbasedgroup
        {
            get { return GetRelatedEntity<ConstraintBasedGroup>("userentityinstancedata_constraintbasedgroup", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_constraintbasedgroup");
                SetRelatedEntity("userentityinstancedata_constraintbasedgroup", null, value);
                OnPropertyChanged("userentityinstancedata_constraintbasedgroup");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_contact
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_contact")]
        public Contact userentityinstancedata_contact
        {
            get { return GetRelatedEntity<Contact>("userentityinstancedata_contact", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_contact");
                SetRelatedEntity("userentityinstancedata_contact", null, value);
                OnPropertyChanged("userentityinstancedata_contact");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_contract
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_contract")]
        public Contract userentityinstancedata_contract
        {
            get { return GetRelatedEntity<Contract>("userentityinstancedata_contract", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_contract");
                SetRelatedEntity("userentityinstancedata_contract", null, value);
                OnPropertyChanged("userentityinstancedata_contract");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_contractdetail
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_contractdetail")]
        public ContractDetail userentityinstancedata_contractdetail
        {
            get { return GetRelatedEntity<ContractDetail>("userentityinstancedata_contractdetail", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_contractdetail");
                SetRelatedEntity("userentityinstancedata_contractdetail", null, value);
                OnPropertyChanged("userentityinstancedata_contractdetail");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_contracttemplate
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_contracttemplate")]
        public ContractTemplate userentityinstancedata_contracttemplate
        {
            get { return GetRelatedEntity<ContractTemplate>("userentityinstancedata_contracttemplate", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_contracttemplate");
                SetRelatedEntity("userentityinstancedata_contracttemplate", null, value);
                OnPropertyChanged("userentityinstancedata_contracttemplate");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_customeraddress
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_customeraddress")]
        public CustomerAddress userentityinstancedata_customeraddress
        {
            get { return GetRelatedEntity<CustomerAddress>("userentityinstancedata_customeraddress", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_customeraddress");
                SetRelatedEntity("userentityinstancedata_customeraddress", null, value);
                OnPropertyChanged("userentityinstancedata_customeraddress");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_customeropportunityrole
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_customeropportunityrole")]
        public CustomerOpportunityRole userentityinstancedata_customeropportunityrole
        {
            get
            {
                return GetRelatedEntity<CustomerOpportunityRole>("userentityinstancedata_customeropportunityrole", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_customeropportunityrole");
                SetRelatedEntity("userentityinstancedata_customeropportunityrole", null, value);
                OnPropertyChanged("userentityinstancedata_customeropportunityrole");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_customerrelationship
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_customerrelationship")]
        public CustomerRelationship userentityinstancedata_customerrelationship
        {
            get { return GetRelatedEntity<CustomerRelationship>("userentityinstancedata_customerrelationship", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_customerrelationship");
                SetRelatedEntity("userentityinstancedata_customerrelationship", null, value);
                OnPropertyChanged("userentityinstancedata_customerrelationship");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_dependency
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_dependency")]
        public Dependency userentityinstancedata_dependency
        {
            get { return GetRelatedEntity<Dependency>("userentityinstancedata_dependency", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_dependency");
                SetRelatedEntity("userentityinstancedata_dependency", null, value);
                OnPropertyChanged("userentityinstancedata_dependency");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_discount
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_discount")]
        public Discount userentityinstancedata_discount
        {
            get { return GetRelatedEntity<Discount>("userentityinstancedata_discount", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_discount");
                SetRelatedEntity("userentityinstancedata_discount", null, value);
                OnPropertyChanged("userentityinstancedata_discount");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_discounttype
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_discounttype")]
        public DiscountType userentityinstancedata_discounttype
        {
            get { return GetRelatedEntity<DiscountType>("userentityinstancedata_discounttype", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_discounttype");
                SetRelatedEntity("userentityinstancedata_discounttype", null, value);
                OnPropertyChanged("userentityinstancedata_discounttype");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_displaystring
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_displaystring")]
        public DisplayString userentityinstancedata_displaystring
        {
            get { return GetRelatedEntity<DisplayString>("userentityinstancedata_displaystring", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_displaystring");
                SetRelatedEntity("userentityinstancedata_displaystring", null, value);
                OnPropertyChanged("userentityinstancedata_displaystring");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_duplicaterecord
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_duplicaterecord")]
        public DuplicateRecord userentityinstancedata_duplicaterecord
        {
            get { return GetRelatedEntity<DuplicateRecord>("userentityinstancedata_duplicaterecord", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_duplicaterecord");
                SetRelatedEntity("userentityinstancedata_duplicaterecord", null, value);
                OnPropertyChanged("userentityinstancedata_duplicaterecord");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_duplicaterule
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_duplicaterule")]
        public DuplicateRule userentityinstancedata_duplicaterule
        {
            get { return GetRelatedEntity<DuplicateRule>("userentityinstancedata_duplicaterule", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_duplicaterule");
                SetRelatedEntity("userentityinstancedata_duplicaterule", null, value);
                OnPropertyChanged("userentityinstancedata_duplicaterule");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_duplicaterulecondition
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_duplicaterulecondition")]
        public DuplicateRuleCondition userentityinstancedata_duplicaterulecondition
        {
            get
            {
                return GetRelatedEntity<DuplicateRuleCondition>("userentityinstancedata_duplicaterulecondition", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_duplicaterulecondition");
                SetRelatedEntity("userentityinstancedata_duplicaterulecondition", null, value);
                OnPropertyChanged("userentityinstancedata_duplicaterulecondition");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_email
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_email")]
        public Email userentityinstancedata_email
        {
            get { return GetRelatedEntity<Email>("userentityinstancedata_email", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_email");
                SetRelatedEntity("userentityinstancedata_email", null, value);
                OnPropertyChanged("userentityinstancedata_email");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_entitymap
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_entitymap")]
        public EntityMap userentityinstancedata_entitymap
        {
            get { return GetRelatedEntity<EntityMap>("userentityinstancedata_entitymap", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_entitymap");
                SetRelatedEntity("userentityinstancedata_entitymap", null, value);
                OnPropertyChanged("userentityinstancedata_entitymap");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_equipment
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_equipment")]
        public Equipment userentityinstancedata_equipment
        {
            get { return GetRelatedEntity<Equipment>("userentityinstancedata_equipment", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_equipment");
                SetRelatedEntity("userentityinstancedata_equipment", null, value);
                OnPropertyChanged("userentityinstancedata_equipment");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_fax
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_fax")]
        public Fax userentityinstancedata_fax
        {
            get { return GetRelatedEntity<Fax>("userentityinstancedata_fax", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_fax");
                SetRelatedEntity("userentityinstancedata_fax", null, value);
                OnPropertyChanged("userentityinstancedata_fax");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_fieldpermission
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_fieldpermission")]
        public FieldPermission userentityinstancedata_fieldpermission
        {
            get { return GetRelatedEntity<FieldPermission>("userentityinstancedata_fieldpermission", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_fieldpermission");
                SetRelatedEntity("userentityinstancedata_fieldpermission", null, value);
                OnPropertyChanged("userentityinstancedata_fieldpermission");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_fieldsecurityprofile
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_fieldsecurityprofile")]
        public FieldSecurityProfile userentityinstancedata_fieldsecurityprofile
        {
            get { return GetRelatedEntity<FieldSecurityProfile>("userentityinstancedata_fieldsecurityprofile", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_fieldsecurityprofile");
                SetRelatedEntity("userentityinstancedata_fieldsecurityprofile", null, value);
                OnPropertyChanged("userentityinstancedata_fieldsecurityprofile");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_goal
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_goal")]
        public Goal userentityinstancedata_goal
        {
            get { return GetRelatedEntity<Goal>("userentityinstancedata_goal", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_goal");
                SetRelatedEntity("userentityinstancedata_goal", null, value);
                OnPropertyChanged("userentityinstancedata_goal");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_goalrollupquery
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_goalrollupquery")]
        public GoalRollupQuery userentityinstancedata_goalrollupquery
        {
            get { return GetRelatedEntity<GoalRollupQuery>("userentityinstancedata_goalrollupquery", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_goalrollupquery");
                SetRelatedEntity("userentityinstancedata_goalrollupquery", null, value);
                OnPropertyChanged("userentityinstancedata_goalrollupquery");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_import
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_import")]
        public Import userentityinstancedata_import
        {
            get { return GetRelatedEntity<Import>("userentityinstancedata_import", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_import");
                SetRelatedEntity("userentityinstancedata_import", null, value);
                OnPropertyChanged("userentityinstancedata_import");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_importentitymapping
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_importentitymapping")]
        public ImportEntityMapping userentityinstancedata_importentitymapping
        {
            get { return GetRelatedEntity<ImportEntityMapping>("userentityinstancedata_importentitymapping", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_importentitymapping");
                SetRelatedEntity("userentityinstancedata_importentitymapping", null, value);
                OnPropertyChanged("userentityinstancedata_importentitymapping");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_importfile
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_importfile")]
        public ImportFile userentityinstancedata_importfile
        {
            get { return GetRelatedEntity<ImportFile>("userentityinstancedata_importfile", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_importfile");
                SetRelatedEntity("userentityinstancedata_importfile", null, value);
                OnPropertyChanged("userentityinstancedata_importfile");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_importjob
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_importjob")]
        public ImportJob userentityinstancedata_importjob
        {
            get { return GetRelatedEntity<ImportJob>("userentityinstancedata_importjob", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_importjob");
                SetRelatedEntity("userentityinstancedata_importjob", null, value);
                OnPropertyChanged("userentityinstancedata_importjob");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_importlog
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_importlog")]
        public ImportLog userentityinstancedata_importlog
        {
            get { return GetRelatedEntity<ImportLog>("userentityinstancedata_importlog", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_importlog");
                SetRelatedEntity("userentityinstancedata_importlog", null, value);
                OnPropertyChanged("userentityinstancedata_importlog");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_importmap
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_importmap")]
        public ImportMap userentityinstancedata_importmap
        {
            get { return GetRelatedEntity<ImportMap>("userentityinstancedata_importmap", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_importmap");
                SetRelatedEntity("userentityinstancedata_importmap", null, value);
                OnPropertyChanged("userentityinstancedata_importmap");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_incident
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_incident")]
        public Incident userentityinstancedata_incident
        {
            get { return GetRelatedEntity<Incident>("userentityinstancedata_incident", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_incident");
                SetRelatedEntity("userentityinstancedata_incident", null, value);
                OnPropertyChanged("userentityinstancedata_incident");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_incidentresolution
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_incidentresolution")]
        public IncidentResolution userentityinstancedata_incidentresolution
        {
            get { return GetRelatedEntity<IncidentResolution>("userentityinstancedata_incidentresolution", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_incidentresolution");
                SetRelatedEntity("userentityinstancedata_incidentresolution", null, value);
                OnPropertyChanged("userentityinstancedata_incidentresolution");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_invaliddependency
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_invaliddependency")]
        public InvalidDependency userentityinstancedata_invaliddependency
        {
            get { return GetRelatedEntity<InvalidDependency>("userentityinstancedata_invaliddependency", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_invaliddependency");
                SetRelatedEntity("userentityinstancedata_invaliddependency", null, value);
                OnPropertyChanged("userentityinstancedata_invaliddependency");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_invoice
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_invoice")]
        public Invoice userentityinstancedata_invoice
        {
            get { return GetRelatedEntity<Invoice>("userentityinstancedata_invoice", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_invoice");
                SetRelatedEntity("userentityinstancedata_invoice", null, value);
                OnPropertyChanged("userentityinstancedata_invoice");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_invoicedetail
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_invoicedetail")]
        public InvoiceDetail userentityinstancedata_invoicedetail
        {
            get { return GetRelatedEntity<InvoiceDetail>("userentityinstancedata_invoicedetail", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_invoicedetail");
                SetRelatedEntity("userentityinstancedata_invoicedetail", null, value);
                OnPropertyChanged("userentityinstancedata_invoicedetail");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_isvconfig
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_isvconfig")]
        public IsvConfig userentityinstancedata_isvconfig
        {
            get { return GetRelatedEntity<IsvConfig>("userentityinstancedata_isvconfig", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_isvconfig");
                SetRelatedEntity("userentityinstancedata_isvconfig", null, value);
                OnPropertyChanged("userentityinstancedata_isvconfig");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_kbarticle
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_kbarticle")]
        public KbArticle userentityinstancedata_kbarticle
        {
            get { return GetRelatedEntity<KbArticle>("userentityinstancedata_kbarticle", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_kbarticle");
                SetRelatedEntity("userentityinstancedata_kbarticle", null, value);
                OnPropertyChanged("userentityinstancedata_kbarticle");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_kbarticlecomment
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_kbarticlecomment")]
        public KbArticleComment userentityinstancedata_kbarticlecomment
        {
            get { return GetRelatedEntity<KbArticleComment>("userentityinstancedata_kbarticlecomment", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_kbarticlecomment");
                SetRelatedEntity("userentityinstancedata_kbarticlecomment", null, value);
                OnPropertyChanged("userentityinstancedata_kbarticlecomment");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_kbarticletemplate
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_kbarticletemplate")]
        public KbArticleTemplate userentityinstancedata_kbarticletemplate
        {
            get { return GetRelatedEntity<KbArticleTemplate>("userentityinstancedata_kbarticletemplate", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_kbarticletemplate");
                SetRelatedEntity("userentityinstancedata_kbarticletemplate", null, value);
                OnPropertyChanged("userentityinstancedata_kbarticletemplate");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_lead
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_lead")]
        public Lead userentityinstancedata_lead
        {
            get { return GetRelatedEntity<Lead>("userentityinstancedata_lead", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_lead");
                SetRelatedEntity("userentityinstancedata_lead", null, value);
                OnPropertyChanged("userentityinstancedata_lead");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_leadaddress
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_leadaddress")]
        public LeadAddress userentityinstancedata_leadaddress
        {
            get { return GetRelatedEntity<LeadAddress>("userentityinstancedata_leadaddress", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_leadaddress");
                SetRelatedEntity("userentityinstancedata_leadaddress", null, value);
                OnPropertyChanged("userentityinstancedata_leadaddress");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_leadproduct
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_leadproduct")]
        public LeadProduct userentityinstancedata_leadproduct
        {
            get { return GetRelatedEntity<LeadProduct>("userentityinstancedata_leadproduct", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_leadproduct");
                SetRelatedEntity("userentityinstancedata_leadproduct", null, value);
                OnPropertyChanged("userentityinstancedata_leadproduct");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_letter
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_letter")]
        public Letter userentityinstancedata_letter
        {
            get { return GetRelatedEntity<Letter>("userentityinstancedata_letter", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_letter");
                SetRelatedEntity("userentityinstancedata_letter", null, value);
                OnPropertyChanged("userentityinstancedata_letter");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_license
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_license")]
        public License userentityinstancedata_license
        {
            get { return GetRelatedEntity<License>("userentityinstancedata_license", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_license");
                SetRelatedEntity("userentityinstancedata_license", null, value);
                OnPropertyChanged("userentityinstancedata_license");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_list
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_list")]
        public List userentityinstancedata_list
        {
            get { return GetRelatedEntity<List>("userentityinstancedata_list", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_list");
                SetRelatedEntity("userentityinstancedata_list", null, value);
                OnPropertyChanged("userentityinstancedata_list");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_listmember
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_listmember")]
        public ListMember userentityinstancedata_listmember
        {
            get { return GetRelatedEntity<ListMember>("userentityinstancedata_listmember", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_listmember");
                SetRelatedEntity("userentityinstancedata_listmember", null, value);
                OnPropertyChanged("userentityinstancedata_listmember");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_lookupmapping
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_lookupmapping")]
        public LookUpMapping userentityinstancedata_lookupmapping
        {
            get { return GetRelatedEntity<LookUpMapping>("userentityinstancedata_lookupmapping", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_lookupmapping");
                SetRelatedEntity("userentityinstancedata_lookupmapping", null, value);
                OnPropertyChanged("userentityinstancedata_lookupmapping");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_mailmergetemplate
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_mailmergetemplate")]
        public MailMergeTemplate userentityinstancedata_mailmergetemplate
        {
            get { return GetRelatedEntity<MailMergeTemplate>("userentityinstancedata_mailmergetemplate", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_mailmergetemplate");
                SetRelatedEntity("userentityinstancedata_mailmergetemplate", null, value);
                OnPropertyChanged("userentityinstancedata_mailmergetemplate");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_metric
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_metric")]
        public Metric userentityinstancedata_metric
        {
            get { return GetRelatedEntity<Metric>("userentityinstancedata_metric", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_metric");
                SetRelatedEntity("userentityinstancedata_metric", null, value);
                OnPropertyChanged("userentityinstancedata_metric");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_opportunity
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_opportunity")]
        public Opportunity userentityinstancedata_opportunity
        {
            get { return GetRelatedEntity<Opportunity>("userentityinstancedata_opportunity", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_opportunity");
                SetRelatedEntity("userentityinstancedata_opportunity", null, value);
                OnPropertyChanged("userentityinstancedata_opportunity");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_opportunityclose
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_opportunityclose")]
        public OpportunityClose userentityinstancedata_opportunityclose
        {
            get { return GetRelatedEntity<OpportunityClose>("userentityinstancedata_opportunityclose", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_opportunityclose");
                SetRelatedEntity("userentityinstancedata_opportunityclose", null, value);
                OnPropertyChanged("userentityinstancedata_opportunityclose");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_opportunityproduct
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_opportunityproduct")]
        public OpportunityProduct userentityinstancedata_opportunityproduct
        {
            get { return GetRelatedEntity<OpportunityProduct>("userentityinstancedata_opportunityproduct", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_opportunityproduct");
                SetRelatedEntity("userentityinstancedata_opportunityproduct", null, value);
                OnPropertyChanged("userentityinstancedata_opportunityproduct");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_orderclose
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_orderclose")]
        public OrderClose userentityinstancedata_orderclose
        {
            get { return GetRelatedEntity<OrderClose>("userentityinstancedata_orderclose", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_orderclose");
                SetRelatedEntity("userentityinstancedata_orderclose", null, value);
                OnPropertyChanged("userentityinstancedata_orderclose");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_organization
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_organization")]
        public Organization userentityinstancedata_organization
        {
            get { return GetRelatedEntity<Organization>("userentityinstancedata_organization", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_organization");
                SetRelatedEntity("userentityinstancedata_organization", null, value);
                OnPropertyChanged("userentityinstancedata_organization");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_ownermapping
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_ownermapping")]
        public OwnerMapping userentityinstancedata_ownermapping
        {
            get { return GetRelatedEntity<OwnerMapping>("userentityinstancedata_ownermapping", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_ownermapping");
                SetRelatedEntity("userentityinstancedata_ownermapping", null, value);
                OnPropertyChanged("userentityinstancedata_ownermapping");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_owning_user
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("userentityinstancedata_owning_user")]
        public SystemUser userentityinstancedata_owning_user
        {
            get { return GetRelatedEntity<SystemUser>("userentityinstancedata_owning_user", null); }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_phonecall
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_phonecall")]
        public PhoneCall userentityinstancedata_phonecall
        {
            get { return GetRelatedEntity<PhoneCall>("userentityinstancedata_phonecall", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_phonecall");
                SetRelatedEntity("userentityinstancedata_phonecall", null, value);
                OnPropertyChanged("userentityinstancedata_phonecall");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_picklistmapping
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_picklistmapping")]
        public PickListMapping userentityinstancedata_picklistmapping
        {
            get { return GetRelatedEntity<PickListMapping>("userentityinstancedata_picklistmapping", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_picklistmapping");
                SetRelatedEntity("userentityinstancedata_picklistmapping", null, value);
                OnPropertyChanged("userentityinstancedata_picklistmapping");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_pluginassembly
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_pluginassembly")]
        public PluginAssembly userentityinstancedata_pluginassembly
        {
            get { return GetRelatedEntity<PluginAssembly>("userentityinstancedata_pluginassembly", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_pluginassembly");
                SetRelatedEntity("userentityinstancedata_pluginassembly", null, value);
                OnPropertyChanged("userentityinstancedata_pluginassembly");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_plugintype
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_plugintype")]
        public PluginType userentityinstancedata_plugintype
        {
            get { return GetRelatedEntity<PluginType>("userentityinstancedata_plugintype", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_plugintype");
                SetRelatedEntity("userentityinstancedata_plugintype", null, value);
                OnPropertyChanged("userentityinstancedata_plugintype");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_plugintypestatistic
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_plugintypestatistic")]
        public PluginTypeStatistic userentityinstancedata_plugintypestatistic
        {
            get { return GetRelatedEntity<PluginTypeStatistic>("userentityinstancedata_plugintypestatistic", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_plugintypestatistic");
                SetRelatedEntity("userentityinstancedata_plugintypestatistic", null, value);
                OnPropertyChanged("userentityinstancedata_plugintypestatistic");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_pricelevel
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_pricelevel")]
        public PriceLevel userentityinstancedata_pricelevel
        {
            get { return GetRelatedEntity<PriceLevel>("userentityinstancedata_pricelevel", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_pricelevel");
                SetRelatedEntity("userentityinstancedata_pricelevel", null, value);
                OnPropertyChanged("userentityinstancedata_pricelevel");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_principalentitymap
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_principalentitymap")]
        public PrincipalEntityMap userentityinstancedata_principalentitymap
        {
            get { return GetRelatedEntity<PrincipalEntityMap>("userentityinstancedata_principalentitymap", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_principalentitymap");
                SetRelatedEntity("userentityinstancedata_principalentitymap", null, value);
                OnPropertyChanged("userentityinstancedata_principalentitymap");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_principalobjectattributeaccess
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_principalobjectattributeaccess")]
        public PrincipalObjectAttributeAccess userentityinstancedata_principalobjectattributeaccess
        {
            get
            {
                return
                    GetRelatedEntity<PrincipalObjectAttributeAccess>(
                        "userentityinstancedata_principalobjectattributeaccess", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_principalobjectattributeaccess");
                SetRelatedEntity("userentityinstancedata_principalobjectattributeaccess", null, value);
                OnPropertyChanged("userentityinstancedata_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_privilege
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_privilege")]
        public Privilege userentityinstancedata_privilege
        {
            get { return GetRelatedEntity<Privilege>("userentityinstancedata_privilege", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_privilege");
                SetRelatedEntity("userentityinstancedata_privilege", null, value);
                OnPropertyChanged("userentityinstancedata_privilege");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_processsession
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_processsession")]
        public ProcessSession userentityinstancedata_processsession
        {
            get { return GetRelatedEntity<ProcessSession>("userentityinstancedata_processsession", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_processsession");
                SetRelatedEntity("userentityinstancedata_processsession", null, value);
                OnPropertyChanged("userentityinstancedata_processsession");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_product
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_product")]
        public Product userentityinstancedata_product
        {
            get { return GetRelatedEntity<Product>("userentityinstancedata_product", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_product");
                SetRelatedEntity("userentityinstancedata_product", null, value);
                OnPropertyChanged("userentityinstancedata_product");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_productassociation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_productassociation")]
        public ProductAssociation userentityinstancedata_productassociation
        {
            get { return GetRelatedEntity<ProductAssociation>("userentityinstancedata_productassociation", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_productassociation");
                SetRelatedEntity("userentityinstancedata_productassociation", null, value);
                OnPropertyChanged("userentityinstancedata_productassociation");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_productpricelevel
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_productpricelevel")]
        public ProductPriceLevel userentityinstancedata_productpricelevel
        {
            get { return GetRelatedEntity<ProductPriceLevel>("userentityinstancedata_productpricelevel", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_productpricelevel");
                SetRelatedEntity("userentityinstancedata_productpricelevel", null, value);
                OnPropertyChanged("userentityinstancedata_productpricelevel");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_productsalesliterature
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_productsalesliterature")]
        public ProductSalesLiterature userentityinstancedata_productsalesliterature
        {
            get
            {
                return GetRelatedEntity<ProductSalesLiterature>("userentityinstancedata_productsalesliterature", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_productsalesliterature");
                SetRelatedEntity("userentityinstancedata_productsalesliterature", null, value);
                OnPropertyChanged("userentityinstancedata_productsalesliterature");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_productsubstitute
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_productsubstitute")]
        public ProductSubstitute userentityinstancedata_productsubstitute
        {
            get { return GetRelatedEntity<ProductSubstitute>("userentityinstancedata_productsubstitute", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_productsubstitute");
                SetRelatedEntity("userentityinstancedata_productsubstitute", null, value);
                OnPropertyChanged("userentityinstancedata_productsubstitute");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_publisher
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_publisher")]
        public Publisher userentityinstancedata_publisher
        {
            get { return GetRelatedEntity<Publisher>("userentityinstancedata_publisher", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_publisher");
                SetRelatedEntity("userentityinstancedata_publisher", null, value);
                OnPropertyChanged("userentityinstancedata_publisher");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_publisheraddress
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_publisheraddress")]
        public PublisherAddress userentityinstancedata_publisheraddress
        {
            get { return GetRelatedEntity<PublisherAddress>("userentityinstancedata_publisheraddress", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_publisheraddress");
                SetRelatedEntity("userentityinstancedata_publisheraddress", null, value);
                OnPropertyChanged("userentityinstancedata_publisheraddress");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_queue
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_queue")]
        public Queue userentityinstancedata_queue
        {
            get { return GetRelatedEntity<Queue>("userentityinstancedata_queue", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_queue");
                SetRelatedEntity("userentityinstancedata_queue", null, value);
                OnPropertyChanged("userentityinstancedata_queue");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_queueitem
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_queueitem")]
        public QueueItem userentityinstancedata_queueitem
        {
            get { return GetRelatedEntity<QueueItem>("userentityinstancedata_queueitem", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_queueitem");
                SetRelatedEntity("userentityinstancedata_queueitem", null, value);
                OnPropertyChanged("userentityinstancedata_queueitem");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_quote
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_quote")]
        public Quote userentityinstancedata_quote
        {
            get { return GetRelatedEntity<Quote>("userentityinstancedata_quote", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_quote");
                SetRelatedEntity("userentityinstancedata_quote", null, value);
                OnPropertyChanged("userentityinstancedata_quote");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_quoteclose
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_quoteclose")]
        public QuoteClose userentityinstancedata_quoteclose
        {
            get { return GetRelatedEntity<QuoteClose>("userentityinstancedata_quoteclose", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_quoteclose");
                SetRelatedEntity("userentityinstancedata_quoteclose", null, value);
                OnPropertyChanged("userentityinstancedata_quoteclose");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_quotedetail
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_quotedetail")]
        public QuoteDetail userentityinstancedata_quotedetail
        {
            get { return GetRelatedEntity<QuoteDetail>("userentityinstancedata_quotedetail", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_quotedetail");
                SetRelatedEntity("userentityinstancedata_quotedetail", null, value);
                OnPropertyChanged("userentityinstancedata_quotedetail");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_recurringappointmentmaster
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_recurringappointmentmaster")]
        public RecurringAppointmentMaster userentityinstancedata_recurringappointmentmaster
        {
            get
            {
                return GetRelatedEntity<RecurringAppointmentMaster>(
                    "userentityinstancedata_recurringappointmentmaster", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_recurringappointmentmaster");
                SetRelatedEntity("userentityinstancedata_recurringappointmentmaster", null, value);
                OnPropertyChanged("userentityinstancedata_recurringappointmentmaster");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_relationshiprole
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_relationshiprole")]
        public RelationshipRole userentityinstancedata_relationshiprole
        {
            get { return GetRelatedEntity<RelationshipRole>("userentityinstancedata_relationshiprole", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_relationshiprole");
                SetRelatedEntity("userentityinstancedata_relationshiprole", null, value);
                OnPropertyChanged("userentityinstancedata_relationshiprole");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_relationshiprolemap
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_relationshiprolemap")]
        public RelationshipRoleMap userentityinstancedata_relationshiprolemap
        {
            get { return GetRelatedEntity<RelationshipRoleMap>("userentityinstancedata_relationshiprolemap", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_relationshiprolemap");
                SetRelatedEntity("userentityinstancedata_relationshiprolemap", null, value);
                OnPropertyChanged("userentityinstancedata_relationshiprolemap");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_report
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_report")]
        public Report userentityinstancedata_report
        {
            get { return GetRelatedEntity<Report>("userentityinstancedata_report", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_report");
                SetRelatedEntity("userentityinstancedata_report", null, value);
                OnPropertyChanged("userentityinstancedata_report");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_reportcategory
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_reportcategory")]
        public ReportCategory userentityinstancedata_reportcategory
        {
            get { return GetRelatedEntity<ReportCategory>("userentityinstancedata_reportcategory", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_reportcategory");
                SetRelatedEntity("userentityinstancedata_reportcategory", null, value);
                OnPropertyChanged("userentityinstancedata_reportcategory");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_reportentity
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_reportentity")]
        public ReportEntity userentityinstancedata_reportentity
        {
            get { return GetRelatedEntity<ReportEntity>("userentityinstancedata_reportentity", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_reportentity");
                SetRelatedEntity("userentityinstancedata_reportentity", null, value);
                OnPropertyChanged("userentityinstancedata_reportentity");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_reportlink
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_reportlink")]
        public ReportLink userentityinstancedata_reportlink
        {
            get { return GetRelatedEntity<ReportLink>("userentityinstancedata_reportlink", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_reportlink");
                SetRelatedEntity("userentityinstancedata_reportlink", null, value);
                OnPropertyChanged("userentityinstancedata_reportlink");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_reportvisibility
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_reportvisibility")]
        public ReportVisibility userentityinstancedata_reportvisibility
        {
            get { return GetRelatedEntity<ReportVisibility>("userentityinstancedata_reportvisibility", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_reportvisibility");
                SetRelatedEntity("userentityinstancedata_reportvisibility", null, value);
                OnPropertyChanged("userentityinstancedata_reportvisibility");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_resource
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_resource")]
        public Resource userentityinstancedata_resource
        {
            get { return GetRelatedEntity<Resource>("userentityinstancedata_resource", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_resource");
                SetRelatedEntity("userentityinstancedata_resource", null, value);
                OnPropertyChanged("userentityinstancedata_resource");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_resourcegroup
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_resourcegroup")]
        public ResourceGroup userentityinstancedata_resourcegroup
        {
            get { return GetRelatedEntity<ResourceGroup>("userentityinstancedata_resourcegroup", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_resourcegroup");
                SetRelatedEntity("userentityinstancedata_resourcegroup", null, value);
                OnPropertyChanged("userentityinstancedata_resourcegroup");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_resourcespec
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_resourcespec")]
        public ResourceSpec userentityinstancedata_resourcespec
        {
            get { return GetRelatedEntity<ResourceSpec>("userentityinstancedata_resourcespec", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_resourcespec");
                SetRelatedEntity("userentityinstancedata_resourcespec", null, value);
                OnPropertyChanged("userentityinstancedata_resourcespec");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_ribboncustomization
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_ribboncustomization")]
        public RibbonCustomization userentityinstancedata_ribboncustomization
        {
            get { return GetRelatedEntity<RibbonCustomization>("userentityinstancedata_ribboncustomization", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_ribboncustomization");
                SetRelatedEntity("userentityinstancedata_ribboncustomization", null, value);
                OnPropertyChanged("userentityinstancedata_ribboncustomization");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_role
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_role")]
        public Role userentityinstancedata_role
        {
            get { return GetRelatedEntity<Role>("userentityinstancedata_role", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_role");
                SetRelatedEntity("userentityinstancedata_role", null, value);
                OnPropertyChanged("userentityinstancedata_role");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_rollupfield
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_rollupfield")]
        public RollupField userentityinstancedata_rollupfield
        {
            get { return GetRelatedEntity<RollupField>("userentityinstancedata_rollupfield", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_rollupfield");
                SetRelatedEntity("userentityinstancedata_rollupfield", null, value);
                OnPropertyChanged("userentityinstancedata_rollupfield");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_salesliterature
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_salesliterature")]
        public SalesLiterature userentityinstancedata_salesliterature
        {
            get { return GetRelatedEntity<SalesLiterature>("userentityinstancedata_salesliterature", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_salesliterature");
                SetRelatedEntity("userentityinstancedata_salesliterature", null, value);
                OnPropertyChanged("userentityinstancedata_salesliterature");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_salesliteratureitem
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_salesliteratureitem")]
        public SalesLiteratureItem userentityinstancedata_salesliteratureitem
        {
            get { return GetRelatedEntity<SalesLiteratureItem>("userentityinstancedata_salesliteratureitem", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_salesliteratureitem");
                SetRelatedEntity("userentityinstancedata_salesliteratureitem", null, value);
                OnPropertyChanged("userentityinstancedata_salesliteratureitem");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_salesorder
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_salesorder")]
        public SalesOrder userentityinstancedata_salesorder
        {
            get { return GetRelatedEntity<SalesOrder>("userentityinstancedata_salesorder", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_salesorder");
                SetRelatedEntity("userentityinstancedata_salesorder", null, value);
                OnPropertyChanged("userentityinstancedata_salesorder");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_salesorderdetail
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_salesorderdetail")]
        public SalesOrderDetail userentityinstancedata_salesorderdetail
        {
            get { return GetRelatedEntity<SalesOrderDetail>("userentityinstancedata_salesorderdetail", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_salesorderdetail");
                SetRelatedEntity("userentityinstancedata_salesorderdetail", null, value);
                OnPropertyChanged("userentityinstancedata_salesorderdetail");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_savedquery
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_savedquery")]
        public SavedQuery userentityinstancedata_savedquery
        {
            get { return GetRelatedEntity<SavedQuery>("userentityinstancedata_savedquery", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_savedquery");
                SetRelatedEntity("userentityinstancedata_savedquery", null, value);
                OnPropertyChanged("userentityinstancedata_savedquery");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_savedqueryvisualization
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_savedqueryvisualization")]
        public SavedQueryVisualization userentityinstancedata_savedqueryvisualization
        {
            get
            {
                return GetRelatedEntity<SavedQueryVisualization>("userentityinstancedata_savedqueryvisualization", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_savedqueryvisualization");
                SetRelatedEntity("userentityinstancedata_savedqueryvisualization", null, value);
                OnPropertyChanged("userentityinstancedata_savedqueryvisualization");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_sdkmessage
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_sdkmessage")]
        public SdkMessage userentityinstancedata_sdkmessage
        {
            get { return GetRelatedEntity<SdkMessage>("userentityinstancedata_sdkmessage", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_sdkmessage");
                SetRelatedEntity("userentityinstancedata_sdkmessage", null, value);
                OnPropertyChanged("userentityinstancedata_sdkmessage");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_sdkmessagefilter
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_sdkmessagefilter")]
        public SdkMessageFilter userentityinstancedata_sdkmessagefilter
        {
            get { return GetRelatedEntity<SdkMessageFilter>("userentityinstancedata_sdkmessagefilter", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_sdkmessagefilter");
                SetRelatedEntity("userentityinstancedata_sdkmessagefilter", null, value);
                OnPropertyChanged("userentityinstancedata_sdkmessagefilter");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_sdkmessagepair
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_sdkmessagepair")]
        public SdkMessagePair userentityinstancedata_sdkmessagepair
        {
            get { return GetRelatedEntity<SdkMessagePair>("userentityinstancedata_sdkmessagepair", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_sdkmessagepair");
                SetRelatedEntity("userentityinstancedata_sdkmessagepair", null, value);
                OnPropertyChanged("userentityinstancedata_sdkmessagepair");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_sdkmessageprocessingstep
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_sdkmessageprocessingstep")]
        public SdkMessageProcessingStep userentityinstancedata_sdkmessageprocessingstep
        {
            get
            {
                return GetRelatedEntity<SdkMessageProcessingStep>("userentityinstancedata_sdkmessageprocessingstep",
                    null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_sdkmessageprocessingstep");
                SetRelatedEntity("userentityinstancedata_sdkmessageprocessingstep", null, value);
                OnPropertyChanged("userentityinstancedata_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_sdkmessageprocessingstepimage
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_sdkmessageprocessingstepimage")]
        public SdkMessageProcessingStepImage userentityinstancedata_sdkmessageprocessingstepimage
        {
            get
            {
                return
                    GetRelatedEntity<SdkMessageProcessingStepImage>(
                        "userentityinstancedata_sdkmessageprocessingstepimage", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_sdkmessageprocessingstepimage");
                SetRelatedEntity("userentityinstancedata_sdkmessageprocessingstepimage", null, value);
                OnPropertyChanged("userentityinstancedata_sdkmessageprocessingstepimage");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_sdkmessageprocessingstepsecureconfig
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_sdkmessageprocessingstepsecureconfig")]
        public SdkMessageProcessingStepSecureConfig userentityinstancedata_sdkmessageprocessingstepsecureconfig
        {
            get
            {
                return
                    GetRelatedEntity<SdkMessageProcessingStepSecureConfig>(
                        "userentityinstancedata_sdkmessageprocessingstepsecureconfig", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_sdkmessageprocessingstepsecureconfig");
                SetRelatedEntity("userentityinstancedata_sdkmessageprocessingstepsecureconfig", null, value);
                OnPropertyChanged("userentityinstancedata_sdkmessageprocessingstepsecureconfig");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_sdkmessagerequest
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_sdkmessagerequest")]
        public SdkMessageRequest userentityinstancedata_sdkmessagerequest
        {
            get { return GetRelatedEntity<SdkMessageRequest>("userentityinstancedata_sdkmessagerequest", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_sdkmessagerequest");
                SetRelatedEntity("userentityinstancedata_sdkmessagerequest", null, value);
                OnPropertyChanged("userentityinstancedata_sdkmessagerequest");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_sdkmessagerequestfield
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_sdkmessagerequestfield")]
        public SdkMessageRequestField userentityinstancedata_sdkmessagerequestfield
        {
            get
            {
                return GetRelatedEntity<SdkMessageRequestField>("userentityinstancedata_sdkmessagerequestfield", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_sdkmessagerequestfield");
                SetRelatedEntity("userentityinstancedata_sdkmessagerequestfield", null, value);
                OnPropertyChanged("userentityinstancedata_sdkmessagerequestfield");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_sdkmessageresponse
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_sdkmessageresponse")]
        public SdkMessageResponse userentityinstancedata_sdkmessageresponse
        {
            get { return GetRelatedEntity<SdkMessageResponse>("userentityinstancedata_sdkmessageresponse", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_sdkmessageresponse");
                SetRelatedEntity("userentityinstancedata_sdkmessageresponse", null, value);
                OnPropertyChanged("userentityinstancedata_sdkmessageresponse");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_sdkmessageresponsefield
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_sdkmessageresponsefield")]
        public SdkMessageResponseField userentityinstancedata_sdkmessageresponsefield
        {
            get
            {
                return GetRelatedEntity<SdkMessageResponseField>("userentityinstancedata_sdkmessageresponsefield", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_sdkmessageresponsefield");
                SetRelatedEntity("userentityinstancedata_sdkmessageresponsefield", null, value);
                OnPropertyChanged("userentityinstancedata_sdkmessageresponsefield");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_service
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_service")]
        public Service userentityinstancedata_service
        {
            get { return GetRelatedEntity<Service>("userentityinstancedata_service", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_service");
                SetRelatedEntity("userentityinstancedata_service", null, value);
                OnPropertyChanged("userentityinstancedata_service");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_serviceappointment
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_serviceappointment")]
        public ServiceAppointment userentityinstancedata_serviceappointment
        {
            get { return GetRelatedEntity<ServiceAppointment>("userentityinstancedata_serviceappointment", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_serviceappointment");
                SetRelatedEntity("userentityinstancedata_serviceappointment", null, value);
                OnPropertyChanged("userentityinstancedata_serviceappointment");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_serviceendpoint
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_serviceendpoint")]
        public ServiceEndpoint userentityinstancedata_serviceendpoint
        {
            get { return GetRelatedEntity<ServiceEndpoint>("userentityinstancedata_serviceendpoint", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_serviceendpoint");
                SetRelatedEntity("userentityinstancedata_serviceendpoint", null, value);
                OnPropertyChanged("userentityinstancedata_serviceendpoint");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_sharepointdocumentlocation
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_sharepointdocumentlocation")]
        public SharePointDocumentLocation userentityinstancedata_sharepointdocumentlocation
        {
            get
            {
                return GetRelatedEntity<SharePointDocumentLocation>(
                    "userentityinstancedata_sharepointdocumentlocation", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_sharepointdocumentlocation");
                SetRelatedEntity("userentityinstancedata_sharepointdocumentlocation", null, value);
                OnPropertyChanged("userentityinstancedata_sharepointdocumentlocation");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_sharepointsite
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_sharepointsite")]
        public SharePointSite userentityinstancedata_sharepointsite
        {
            get { return GetRelatedEntity<SharePointSite>("userentityinstancedata_sharepointsite", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_sharepointsite");
                SetRelatedEntity("userentityinstancedata_sharepointsite", null, value);
                OnPropertyChanged("userentityinstancedata_sharepointsite");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_site
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_site")]
        public Site userentityinstancedata_site
        {
            get { return GetRelatedEntity<Site>("userentityinstancedata_site", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_site");
                SetRelatedEntity("userentityinstancedata_site", null, value);
                OnPropertyChanged("userentityinstancedata_site");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_sitemap
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_sitemap")]
        public SiteMap userentityinstancedata_sitemap
        {
            get { return GetRelatedEntity<SiteMap>("userentityinstancedata_sitemap", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_sitemap");
                SetRelatedEntity("userentityinstancedata_sitemap", null, value);
                OnPropertyChanged("userentityinstancedata_sitemap");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_solution
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_solution")]
        public Solution userentityinstancedata_solution
        {
            get { return GetRelatedEntity<Solution>("userentityinstancedata_solution", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_solution");
                SetRelatedEntity("userentityinstancedata_solution", null, value);
                OnPropertyChanged("userentityinstancedata_solution");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_solutioncomponent
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_solutioncomponent")]
        public SolutionComponent userentityinstancedata_solutioncomponent
        {
            get { return GetRelatedEntity<SolutionComponent>("userentityinstancedata_solutioncomponent", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_solutioncomponent");
                SetRelatedEntity("userentityinstancedata_solutioncomponent", null, value);
                OnPropertyChanged("userentityinstancedata_solutioncomponent");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_subject
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_subject")]
        public Subject userentityinstancedata_subject
        {
            get { return GetRelatedEntity<Subject>("userentityinstancedata_subject", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_subject");
                SetRelatedEntity("userentityinstancedata_subject", null, value);
                OnPropertyChanged("userentityinstancedata_subject");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_subscriptionmanuallytrackedobject
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_subscriptionmanuallytrackedobject")]
        public SubscriptionManuallyTrackedObject userentityinstancedata_subscriptionmanuallytrackedobject
        {
            get
            {
                return
                    GetRelatedEntity<SubscriptionManuallyTrackedObject>(
                        "userentityinstancedata_subscriptionmanuallytrackedobject", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_subscriptionmanuallytrackedobject");
                SetRelatedEntity("userentityinstancedata_subscriptionmanuallytrackedobject", null, value);
                OnPropertyChanged("userentityinstancedata_subscriptionmanuallytrackedobject");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_systemuser
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_systemuser")]
        public SystemUser userentityinstancedata_systemuser
        {
            get { return GetRelatedEntity<SystemUser>("userentityinstancedata_systemuser", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_systemuser");
                SetRelatedEntity("userentityinstancedata_systemuser", null, value);
                OnPropertyChanged("userentityinstancedata_systemuser");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_task
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_task")]
        public Task userentityinstancedata_task
        {
            get { return GetRelatedEntity<Task>("userentityinstancedata_task", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_task");
                SetRelatedEntity("userentityinstancedata_task", null, value);
                OnPropertyChanged("userentityinstancedata_task");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_team
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_team")]
        public Team userentityinstancedata_team
        {
            get { return GetRelatedEntity<Team>("userentityinstancedata_team", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_team");
                SetRelatedEntity("userentityinstancedata_team", null, value);
                OnPropertyChanged("userentityinstancedata_team");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_teammembership
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_teammembership")]
        public TeamMembership userentityinstancedata_teammembership
        {
            get { return GetRelatedEntity<TeamMembership>("userentityinstancedata_teammembership", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_teammembership");
                SetRelatedEntity("userentityinstancedata_teammembership", null, value);
                OnPropertyChanged("userentityinstancedata_teammembership");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_template
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_template")]
        public Template userentityinstancedata_template
        {
            get { return GetRelatedEntity<Template>("userentityinstancedata_template", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_template");
                SetRelatedEntity("userentityinstancedata_template", null, value);
                OnPropertyChanged("userentityinstancedata_template");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_territory
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_territory")]
        public Territory userentityinstancedata_territory
        {
            get { return GetRelatedEntity<Territory>("userentityinstancedata_territory", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_territory");
                SetRelatedEntity("userentityinstancedata_territory", null, value);
                OnPropertyChanged("userentityinstancedata_territory");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_timezonedefinition
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_timezonedefinition")]
        public TimeZoneDefinition userentityinstancedata_timezonedefinition
        {
            get { return GetRelatedEntity<TimeZoneDefinition>("userentityinstancedata_timezonedefinition", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_timezonedefinition");
                SetRelatedEntity("userentityinstancedata_timezonedefinition", null, value);
                OnPropertyChanged("userentityinstancedata_timezonedefinition");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_timezonelocalizedname
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_timezonelocalizedname")]
        public TimeZoneLocalizedName userentityinstancedata_timezonelocalizedname
        {
            get
            {
                return GetRelatedEntity<TimeZoneLocalizedName>("userentityinstancedata_timezonelocalizedname", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_timezonelocalizedname");
                SetRelatedEntity("userentityinstancedata_timezonelocalizedname", null, value);
                OnPropertyChanged("userentityinstancedata_timezonelocalizedname");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_timezonerule
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_timezonerule")]
        public TimeZoneRule userentityinstancedata_timezonerule
        {
            get { return GetRelatedEntity<TimeZoneRule>("userentityinstancedata_timezonerule", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_timezonerule");
                SetRelatedEntity("userentityinstancedata_timezonerule", null, value);
                OnPropertyChanged("userentityinstancedata_timezonerule");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_transactioncurrency
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_transactioncurrency")]
        public TransactionCurrency userentityinstancedata_transactioncurrency
        {
            get { return GetRelatedEntity<TransactionCurrency>("userentityinstancedata_transactioncurrency", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_transactioncurrency");
                SetRelatedEntity("userentityinstancedata_transactioncurrency", null, value);
                OnPropertyChanged("userentityinstancedata_transactioncurrency");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_transformationmapping
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_transformationmapping")]
        public TransformationMapping userentityinstancedata_transformationmapping
        {
            get
            {
                return GetRelatedEntity<TransformationMapping>("userentityinstancedata_transformationmapping", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_transformationmapping");
                SetRelatedEntity("userentityinstancedata_transformationmapping", null, value);
                OnPropertyChanged("userentityinstancedata_transformationmapping");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_transformationparametermapping
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_transformationparametermapping")]
        public TransformationParameterMapping userentityinstancedata_transformationparametermapping
        {
            get
            {
                return
                    GetRelatedEntity<TransformationParameterMapping>(
                        "userentityinstancedata_transformationparametermapping", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_transformationparametermapping");
                SetRelatedEntity("userentityinstancedata_transformationparametermapping", null, value);
                OnPropertyChanged("userentityinstancedata_transformationparametermapping");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_uom
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_uom")]
        public UoM userentityinstancedata_uom
        {
            get { return GetRelatedEntity<UoM>("userentityinstancedata_uom", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_uom");
                SetRelatedEntity("userentityinstancedata_uom", null, value);
                OnPropertyChanged("userentityinstancedata_uom");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_uomschedule
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_uomschedule")]
        public UoMSchedule userentityinstancedata_uomschedule
        {
            get { return GetRelatedEntity<UoMSchedule>("userentityinstancedata_uomschedule", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_uomschedule");
                SetRelatedEntity("userentityinstancedata_uomschedule", null, value);
                OnPropertyChanged("userentityinstancedata_uomschedule");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_userentityuisettings
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_userentityuisettings")]
        public UserEntityUISettings userentityinstancedata_userentityuisettings
        {
            get { return GetRelatedEntity<UserEntityUISettings>("userentityinstancedata_userentityuisettings", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_userentityuisettings");
                SetRelatedEntity("userentityinstancedata_userentityuisettings", null, value);
                OnPropertyChanged("userentityinstancedata_userentityuisettings");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_userform
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_userform")]
        public UserForm userentityinstancedata_userform
        {
            get { return GetRelatedEntity<UserForm>("userentityinstancedata_userform", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_userform");
                SetRelatedEntity("userentityinstancedata_userform", null, value);
                OnPropertyChanged("userentityinstancedata_userform");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_userquery
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_userquery")]
        public UserQuery userentityinstancedata_userquery
        {
            get { return GetRelatedEntity<UserQuery>("userentityinstancedata_userquery", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_userquery");
                SetRelatedEntity("userentityinstancedata_userquery", null, value);
                OnPropertyChanged("userentityinstancedata_userquery");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_userqueryvisualization
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_userqueryvisualization")]
        public UserQueryVisualization userentityinstancedata_userqueryvisualization
        {
            get
            {
                return GetRelatedEntity<UserQueryVisualization>("userentityinstancedata_userqueryvisualization", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_userqueryvisualization");
                SetRelatedEntity("userentityinstancedata_userqueryvisualization", null, value);
                OnPropertyChanged("userentityinstancedata_userqueryvisualization");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_webresource
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_webresource")]
        public WebResource userentityinstancedata_webresource
        {
            get { return GetRelatedEntity<WebResource>("userentityinstancedata_webresource", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_webresource");
                SetRelatedEntity("userentityinstancedata_webresource", null, value);
                OnPropertyChanged("userentityinstancedata_webresource");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_workflow
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_workflow")]
        public Workflow userentityinstancedata_workflow
        {
            get { return GetRelatedEntity<Workflow>("userentityinstancedata_workflow", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_workflow");
                SetRelatedEntity("userentityinstancedata_workflow", null, value);
                OnPropertyChanged("userentityinstancedata_workflow");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_workflowdependency
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_workflowdependency")]
        public WorkflowDependency userentityinstancedata_workflowdependency
        {
            get { return GetRelatedEntity<WorkflowDependency>("userentityinstancedata_workflowdependency", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_workflowdependency");
                SetRelatedEntity("userentityinstancedata_workflowdependency", null, value);
                OnPropertyChanged("userentityinstancedata_workflowdependency");
            }
        }

        /// <summary>
        ///     N:1 userentityinstancedata_workflowlog
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("userentityinstancedata_workflowlog")]
        public WorkflowLog userentityinstancedata_workflowlog
        {
            get { return GetRelatedEntity<WorkflowLog>("userentityinstancedata_workflowlog", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_workflowlog");
                SetRelatedEntity("userentityinstancedata_workflowlog", null, value);
                OnPropertyChanged("userentityinstancedata_workflowlog");
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