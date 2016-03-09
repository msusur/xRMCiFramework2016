using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Xrm.Framework.CI.PowerShell.Common;

namespace Xrm.Framework.CI.Common.Entities
{
    /// <summary>
    ///     Process whose execution can proceed independently or in the background.
    /// </summary>
    [DataContract]
    [EntityLogicalName("asyncoperation")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class AsyncOperation : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "asyncoperation";

        public const int EntityTypeCode = 4700;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public AsyncOperation() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the system job.
        /// </summary>
        [AttributeLogicalName("asyncoperationid")]
        public Guid? AsyncOperationId
        {
            get { return GetAttributeValue<Guid?>("asyncoperationid"); }
            set
            {
                OnPropertyChanging("AsyncOperationId");
                SetAttributeValue("asyncoperationid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("AsyncOperationId");
            }
        }

        [AttributeLogicalName("asyncoperationid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { AsyncOperationId = value; }
        }

        /// <summary>
        ///     Date and time when the system job was completed.
        /// </summary>
        [AttributeLogicalName("completedon")]
        public DateTime? CompletedOn
        {
            get { return GetAttributeValue<DateTime?>("completedon"); }
        }

        /// <summary>
        ///     Unique identifier used to correlate between multiple SDK requests and system jobs.
        /// </summary>
        [AttributeLogicalName("correlationid")]
        public Guid? CorrelationId
        {
            get { return GetAttributeValue<Guid?>("correlationid"); }
            set
            {
                OnPropertyChanging("CorrelationId");
                SetAttributeValue("correlationid", value);
                OnPropertyChanged("CorrelationId");
            }
        }

        /// <summary>
        ///     Last time the correlation depth was updated.
        /// </summary>
        [AttributeLogicalName("correlationupdatedtime")]
        public DateTime? CorrelationUpdatedTime
        {
            get { return GetAttributeValue<DateTime?>("correlationupdatedtime"); }
            set
            {
                OnPropertyChanging("CorrelationUpdatedTime");
                SetAttributeValue("correlationupdatedtime", value);
                OnPropertyChanged("CorrelationUpdatedTime");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the system job.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the system job was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the asyncoperation.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Unstructured data associated with the system job.
        /// </summary>
        [AttributeLogicalName("data")]
        public string Data
        {
            get { return GetAttributeValue<string>("data"); }
            set
            {
                OnPropertyChanging("Data");
                SetAttributeValue("data", value);
                OnPropertyChanged("Data");
            }
        }

        /// <summary>
        ///     Execution of all operations with the same dependency token is serialized.
        /// </summary>
        [AttributeLogicalName("dependencytoken")]
        public string DependencyToken
        {
            get { return GetAttributeValue<string>("dependencytoken"); }
            set
            {
                OnPropertyChanging("DependencyToken");
                SetAttributeValue("dependencytoken", value);
                OnPropertyChanged("DependencyToken");
            }
        }

        /// <summary>
        ///     Number of SDK calls made since the first call.
        /// </summary>
        [AttributeLogicalName("depth")]
        public int? Depth
        {
            get { return GetAttributeValue<int?>("depth"); }
            set
            {
                OnPropertyChanging("Depth");
                SetAttributeValue("depth", value);
                OnPropertyChanged("Depth");
            }
        }

        /// <summary>
        ///     Error code returned from a canceled system job.
        /// </summary>
        [AttributeLogicalName("errorcode")]
        public int? ErrorCode
        {
            get { return GetAttributeValue<int?>("errorcode"); }
        }

        /// <summary>
        ///     Time that the system job has taken to execute.
        /// </summary>
        [AttributeLogicalName("executiontimespan")]
        public double? ExecutionTimeSpan
        {
            get { return GetAttributeValue<double?>("executiontimespan"); }
        }

        /// <summary>
        ///     Message provided by the system job.
        /// </summary>
        [AttributeLogicalName("friendlymessage")]
        public string FriendlyMessage
        {
            get { return GetAttributeValue<string>("friendlymessage"); }
            set
            {
                OnPropertyChanging("FriendlyMessage");
                SetAttributeValue("friendlymessage", value);
                OnPropertyChanged("FriendlyMessage");
            }
        }

        /// <summary>
        ///     Unique identifier of the host that owns this system job.
        /// </summary>
        [AttributeLogicalName("hostid")]
        public string HostId
        {
            get { return GetAttributeValue<string>("hostid"); }
            set
            {
                OnPropertyChanging("HostId");
                SetAttributeValue("hostid", value);
                OnPropertyChanged("HostId");
            }
        }

        /// <summary>
        ///     Indicates that the system job is waiting for an event.
        /// </summary>
        [AttributeLogicalName("iswaitingforevent")]
        public bool? IsWaitingForEvent
        {
            get { return GetAttributeValue<bool?>("iswaitingforevent"); }
        }

        /// <summary>
        ///     Message related to the system job.
        /// </summary>
        [AttributeLogicalName("message")]
        public string Message
        {
            get { return GetAttributeValue<string>("message"); }
        }

        /// <summary>
        ///     Name of the message that started this system job.
        /// </summary>
        [AttributeLogicalName("messagename")]
        public string MessageName
        {
            get { return GetAttributeValue<string>("messagename"); }
            set
            {
                OnPropertyChanging("MessageName");
                SetAttributeValue("messagename", value);
                OnPropertyChanged("MessageName");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the system job.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the system job was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the asyncoperation.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the system job.
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
        ///     Type of the system job.
        /// </summary>
        [AttributeLogicalName("operationtype")]
        public OptionSetValue OperationType
        {
            get { return GetAttributeValue<OptionSetValue>("operationtype"); }
            set
            {
                OnPropertyChanging("OperationType");
                SetAttributeValue("operationtype", value);
                OnPropertyChanged("OperationType");
            }
        }

        /// <summary>
        ///     Unique identifier of the user or team who owns the system job.
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
        ///     Unique identifier of the business unit that owns the system job.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the owning extension with which the system job is associated.
        /// </summary>
        [AttributeLogicalName("owningextensionid")]
        public EntityReference OwningExtensionId
        {
            get { return GetAttributeValue<EntityReference>("owningextensionid"); }
            set
            {
                OnPropertyChanging("OwningExtensionId");
                SetAttributeValue("owningextensionid", value);
                OnPropertyChanged("OwningExtensionId");
            }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the record.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the record.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Indicates whether the system job should run only after the specified date and time.
        /// </summary>
        [AttributeLogicalName("postponeuntil")]
        public DateTime? PostponeUntil
        {
            get { return GetAttributeValue<DateTime?>("postponeuntil"); }
            set
            {
                OnPropertyChanging("PostponeUntil");
                SetAttributeValue("postponeuntil", value);
                OnPropertyChanged("PostponeUntil");
            }
        }

        /// <summary>
        ///     Type of entity with which the system job is primarily associated.
        /// </summary>
        [AttributeLogicalName("primaryentitytype")]
        public string PrimaryEntityType
        {
            get { return GetAttributeValue<string>("primaryentitytype"); }
            set
            {
                OnPropertyChanging("PrimaryEntityType");
                SetAttributeValue("primaryentitytype", value);
                OnPropertyChanged("PrimaryEntityType");
            }
        }

        /// <summary>
        ///     Pattern of the system job's recurrence.
        /// </summary>
        [AttributeLogicalName("recurrencepattern")]
        public string RecurrencePattern
        {
            get { return GetAttributeValue<string>("recurrencepattern"); }
            set
            {
                OnPropertyChanging("RecurrencePattern");
                SetAttributeValue("recurrencepattern", value);
                OnPropertyChanged("RecurrencePattern");
            }
        }

        /// <summary>
        ///     Starting time in UTC for the recurrence pattern.
        /// </summary>
        [AttributeLogicalName("recurrencestarttime")]
        public DateTime? RecurrenceStartTime
        {
            get { return GetAttributeValue<DateTime?>("recurrencestarttime"); }
            set
            {
                OnPropertyChanging("RecurrenceStartTime");
                SetAttributeValue("recurrencestarttime", value);
                OnPropertyChanged("RecurrenceStartTime");
            }
        }

        /// <summary>
        ///     Unique identifier of the object with which the system job is associated.
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        public EntityReference RegardingObjectId
        {
            get { return GetAttributeValue<EntityReference>("regardingobjectid"); }
            set
            {
                OnPropertyChanging("RegardingObjectId");
                SetAttributeValue("regardingobjectid", value);
                OnPropertyChanged("RegardingObjectId");
            }
        }

        /// <summary>
        ///     Unique identifier of the request that generated the system job.
        /// </summary>
        [AttributeLogicalName("requestid")]
        public Guid? RequestId
        {
            get { return GetAttributeValue<Guid?>("requestid"); }
            set
            {
                OnPropertyChanging("RequestId");
                SetAttributeValue("requestid", value);
                OnPropertyChanged("RequestId");
            }
        }

        /// <summary>
        ///     Number of times to retry the system job.
        /// </summary>
        [AttributeLogicalName("retrycount")]
        public int? RetryCount
        {
            get { return GetAttributeValue<int?>("retrycount"); }
        }

        /// <summary>
        ///     Order in which operations were submitted.
        /// </summary>
        [AttributeLogicalName("sequence")]
        public long? Sequence
        {
            get { return GetAttributeValue<long?>("sequence"); }
        }

        /// <summary>
        ///     Date and time when the system job was started.
        /// </summary>
        [AttributeLogicalName("startedon")]
        public DateTime? StartedOn
        {
            get { return GetAttributeValue<DateTime?>("startedon"); }
        }

        /// <summary>
        ///     Status of the system job.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public AsyncOperationState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((AsyncOperationState) (Enum.ToObject(typeof (AsyncOperationState), optionSet.Value)));
                }
                return null;
            }
            set
            {
                OnPropertyChanging("StateCode");
                if ((value == null))
                {
                    SetAttributeValue("statecode", null);
                }
                else
                {
                    SetAttributeValue("statecode", new OptionSetValue(((int) (value))));
                }
                OnPropertyChanged("StateCode");
            }
        }

        /// <summary>
        ///     Reason for the status of the system job.
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
        ///     Unique identifier of the workflow activation related to the system job.
        /// </summary>
        [AttributeLogicalName("workflowactivationid")]
        public EntityReference WorkflowActivationId
        {
            get { return GetAttributeValue<EntityReference>("workflowactivationid"); }
            set
            {
                OnPropertyChanging("WorkflowActivationId");
                SetAttributeValue("workflowactivationid", value);
                OnPropertyChanged("WorkflowActivationId");
            }
        }

        /// <summary>
        ///     Name of a workflow stage.
        /// </summary>
        [AttributeLogicalName("workflowstagename")]
        public string WorkflowStageName
        {
            get { return GetAttributeValue<string>("workflowstagename"); }
        }

        /// <summary>
        ///     1:N AsyncOperation_BulkDeleteOperation
        /// </summary>
        [RelationshipSchemaName("AsyncOperation_BulkDeleteOperation")]
        public IEnumerable<BulkDeleteOperation> AsyncOperation_BulkDeleteOperation
        {
            get { return GetRelatedEntities<BulkDeleteOperation>("AsyncOperation_BulkDeleteOperation", null); }
            set
            {
                OnPropertyChanging("AsyncOperation_BulkDeleteOperation");
                SetRelatedEntities("AsyncOperation_BulkDeleteOperation", null, value);
                OnPropertyChanged("AsyncOperation_BulkDeleteOperation");
            }
        }

        /// <summary>
        ///     1:N AsyncOperation_DuplicateBaseRecord
        /// </summary>
        [RelationshipSchemaName("AsyncOperation_DuplicateBaseRecord")]
        public IEnumerable<DuplicateRecord> AsyncOperation_DuplicateBaseRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("AsyncOperation_DuplicateBaseRecord", null); }
            set
            {
                OnPropertyChanging("AsyncOperation_DuplicateBaseRecord");
                SetRelatedEntities("AsyncOperation_DuplicateBaseRecord", null, value);
                OnPropertyChanged("AsyncOperation_DuplicateBaseRecord");
            }
        }

        /// <summary>
        ///     1:N AsyncOperation_Emails
        /// </summary>
        [RelationshipSchemaName("AsyncOperation_Emails")]
        public IEnumerable<Email> AsyncOperation_Emails
        {
            get { return GetRelatedEntities<Email>("AsyncOperation_Emails", null); }
            set
            {
                OnPropertyChanging("AsyncOperation_Emails");
                SetRelatedEntities("AsyncOperation_Emails", null, value);
                OnPropertyChanged("AsyncOperation_Emails");
            }
        }

        /// <summary>
        ///     1:N lk_workflowlog_asyncoperation_childworkflow
        /// </summary>
        [RelationshipSchemaName("lk_workflowlog_asyncoperation_childworkflow")]
        public IEnumerable<WorkflowLog> lk_workflowlog_asyncoperation_childworkflow
        {
            get { return GetRelatedEntities<WorkflowLog>("lk_workflowlog_asyncoperation_childworkflow", null); }
            set
            {
                OnPropertyChanging("lk_workflowlog_asyncoperation_childworkflow");
                SetRelatedEntities("lk_workflowlog_asyncoperation_childworkflow", null, value);
                OnPropertyChanged("lk_workflowlog_asyncoperation_childworkflow");
            }
        }

        /// <summary>
        ///     1:N lk_workflowlog_asyncoperations
        /// </summary>
        [RelationshipSchemaName("lk_workflowlog_asyncoperations")]
        public IEnumerable<WorkflowLog> lk_workflowlog_asyncoperations
        {
            get { return GetRelatedEntities<WorkflowLog>("lk_workflowlog_asyncoperations", null); }
            set
            {
                OnPropertyChanging("lk_workflowlog_asyncoperations");
                SetRelatedEntities("lk_workflowlog_asyncoperations", null, value);
                OnPropertyChanged("lk_workflowlog_asyncoperations");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_asyncoperation
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_asyncoperation")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_asyncoperation
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_asyncoperation", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_asyncoperation");
                SetRelatedEntities("userentityinstancedata_asyncoperation", null, value);
                OnPropertyChanged("userentityinstancedata_asyncoperation");
            }
        }

        /// <summary>
        ///     N:1 Account_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Account_AsyncOperations")]
        public Account Account_AsyncOperations
        {
            get { return GetRelatedEntity<Account>("Account_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Account_AsyncOperations");
                SetRelatedEntity("Account_AsyncOperations", null, value);
                OnPropertyChanged("Account_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 ActivityMimeAttachment_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("ActivityMimeAttachment_AsyncOperations")]
        public ActivityMimeAttachment ActivityMimeAttachment_AsyncOperations
        {
            get { return GetRelatedEntity<ActivityMimeAttachment>("ActivityMimeAttachment_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("ActivityMimeAttachment_AsyncOperations");
                SetRelatedEntity("ActivityMimeAttachment_AsyncOperations", null, value);
                OnPropertyChanged("ActivityMimeAttachment_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 ActivityPointer_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("ActivityPointer_AsyncOperations")]
        public ActivityPointer ActivityPointer_AsyncOperations
        {
            get { return GetRelatedEntity<ActivityPointer>("ActivityPointer_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("ActivityPointer_AsyncOperations");
                SetRelatedEntity("ActivityPointer_AsyncOperations", null, value);
                OnPropertyChanged("ActivityPointer_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Annotation_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Annotation_AsyncOperations")]
        public Annotation Annotation_AsyncOperations
        {
            get { return GetRelatedEntity<Annotation>("Annotation_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Annotation_AsyncOperations");
                SetRelatedEntity("Annotation_AsyncOperations", null, value);
                OnPropertyChanged("Annotation_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 AnnualFiscalCalendar_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("AnnualFiscalCalendar_AsyncOperations")]
        public AnnualFiscalCalendar AnnualFiscalCalendar_AsyncOperations
        {
            get { return GetRelatedEntity<AnnualFiscalCalendar>("AnnualFiscalCalendar_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("AnnualFiscalCalendar_AsyncOperations");
                SetRelatedEntity("AnnualFiscalCalendar_AsyncOperations", null, value);
                OnPropertyChanged("AnnualFiscalCalendar_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Appointment_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Appointment_AsyncOperations")]
        public Appointment Appointment_AsyncOperations
        {
            get { return GetRelatedEntity<Appointment>("Appointment_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Appointment_AsyncOperations");
                SetRelatedEntity("Appointment_AsyncOperations", null, value);
                OnPropertyChanged("Appointment_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 AttributeMap_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("AttributeMap_AsyncOperations")]
        public AttributeMap AttributeMap_AsyncOperations
        {
            get { return GetRelatedEntity<AttributeMap>("AttributeMap_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("AttributeMap_AsyncOperations");
                SetRelatedEntity("AttributeMap_AsyncOperations", null, value);
                OnPropertyChanged("AttributeMap_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 BulkOperation_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("BulkOperation_AsyncOperations")]
        public BulkOperation BulkOperation_AsyncOperations
        {
            get { return GetRelatedEntity<BulkOperation>("BulkOperation_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("BulkOperation_AsyncOperations");
                SetRelatedEntity("BulkOperation_AsyncOperations", null, value);
                OnPropertyChanged("BulkOperation_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 BulkOperationLog_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("BulkOperationLog_AsyncOperations")]
        public BulkOperationLog BulkOperationLog_AsyncOperations
        {
            get { return GetRelatedEntity<BulkOperationLog>("BulkOperationLog_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("BulkOperationLog_AsyncOperations");
                SetRelatedEntity("BulkOperationLog_AsyncOperations", null, value);
                OnPropertyChanged("BulkOperationLog_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 business_unit_asyncoperation
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_asyncoperation")]
        public BusinessUnit business_unit_asyncoperation
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_asyncoperation", null); }
        }

        /// <summary>
        ///     N:1 BusinessUnit_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("BusinessUnit_AsyncOperations")]
        public BusinessUnit BusinessUnit_AsyncOperations
        {
            get { return GetRelatedEntity<BusinessUnit>("BusinessUnit_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("BusinessUnit_AsyncOperations");
                SetRelatedEntity("BusinessUnit_AsyncOperations", null, value);
                OnPropertyChanged("BusinessUnit_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 BusinessUnitNewsArticle_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("BusinessUnitNewsArticle_AsyncOperations")]
        public BusinessUnitNewsArticle BusinessUnitNewsArticle_AsyncOperations
        {
            get { return GetRelatedEntity<BusinessUnitNewsArticle>("BusinessUnitNewsArticle_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("BusinessUnitNewsArticle_AsyncOperations");
                SetRelatedEntity("BusinessUnitNewsArticle_AsyncOperations", null, value);
                OnPropertyChanged("BusinessUnitNewsArticle_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Calendar_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Calendar_AsyncOperations")]
        public Calendar Calendar_AsyncOperations
        {
            get { return GetRelatedEntity<Calendar>("Calendar_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Calendar_AsyncOperations");
                SetRelatedEntity("Calendar_AsyncOperations", null, value);
                OnPropertyChanged("Calendar_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Campaign_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Campaign_AsyncOperations")]
        public Campaign Campaign_AsyncOperations
        {
            get { return GetRelatedEntity<Campaign>("Campaign_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Campaign_AsyncOperations");
                SetRelatedEntity("Campaign_AsyncOperations", null, value);
                OnPropertyChanged("Campaign_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 CampaignActivity_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("CampaignActivity_AsyncOperations")]
        public CampaignActivity CampaignActivity_AsyncOperations
        {
            get { return GetRelatedEntity<CampaignActivity>("CampaignActivity_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("CampaignActivity_AsyncOperations");
                SetRelatedEntity("CampaignActivity_AsyncOperations", null, value);
                OnPropertyChanged("CampaignActivity_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 CampaignResponse_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("CampaignResponse_AsyncOperations")]
        public CampaignResponse CampaignResponse_AsyncOperations
        {
            get { return GetRelatedEntity<CampaignResponse>("CampaignResponse_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("CampaignResponse_AsyncOperations");
                SetRelatedEntity("CampaignResponse_AsyncOperations", null, value);
                OnPropertyChanged("CampaignResponse_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Competitor_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Competitor_AsyncOperations")]
        public Competitor Competitor_AsyncOperations
        {
            get { return GetRelatedEntity<Competitor>("Competitor_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Competitor_AsyncOperations");
                SetRelatedEntity("Competitor_AsyncOperations", null, value);
                OnPropertyChanged("Competitor_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Connection_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Connection_AsyncOperations")]
        public Connection Connection_AsyncOperations
        {
            get { return GetRelatedEntity<Connection>("Connection_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Connection_AsyncOperations");
                SetRelatedEntity("Connection_AsyncOperations", null, value);
                OnPropertyChanged("Connection_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Connection_Role_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Connection_Role_AsyncOperations")]
        public ConnectionRole Connection_Role_AsyncOperations
        {
            get { return GetRelatedEntity<ConnectionRole>("Connection_Role_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Connection_Role_AsyncOperations");
                SetRelatedEntity("Connection_Role_AsyncOperations", null, value);
                OnPropertyChanged("Connection_Role_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 ConstraintBasedGroup_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("ConstraintBasedGroup_AsyncOperations")]
        public ConstraintBasedGroup ConstraintBasedGroup_AsyncOperations
        {
            get { return GetRelatedEntity<ConstraintBasedGroup>("ConstraintBasedGroup_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("ConstraintBasedGroup_AsyncOperations");
                SetRelatedEntity("ConstraintBasedGroup_AsyncOperations", null, value);
                OnPropertyChanged("ConstraintBasedGroup_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Contact_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Contact_AsyncOperations")]
        public Contact Contact_AsyncOperations
        {
            get { return GetRelatedEntity<Contact>("Contact_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Contact_AsyncOperations");
                SetRelatedEntity("Contact_AsyncOperations", null, value);
                OnPropertyChanged("Contact_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Contract_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Contract_AsyncOperations")]
        public Contract Contract_AsyncOperations
        {
            get { return GetRelatedEntity<Contract>("Contract_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Contract_AsyncOperations");
                SetRelatedEntity("Contract_AsyncOperations", null, value);
                OnPropertyChanged("Contract_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 ContractDetail_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("ContractDetail_AsyncOperations")]
        public ContractDetail ContractDetail_AsyncOperations
        {
            get { return GetRelatedEntity<ContractDetail>("ContractDetail_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("ContractDetail_AsyncOperations");
                SetRelatedEntity("ContractDetail_AsyncOperations", null, value);
                OnPropertyChanged("ContractDetail_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 ContractTemplate_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("ContractTemplate_AsyncOperations")]
        public ContractTemplate ContractTemplate_AsyncOperations
        {
            get { return GetRelatedEntity<ContractTemplate>("ContractTemplate_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("ContractTemplate_AsyncOperations");
                SetRelatedEntity("ContractTemplate_AsyncOperations", null, value);
                OnPropertyChanged("ContractTemplate_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 CustomerAddress_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("CustomerAddress_AsyncOperations")]
        public CustomerAddress CustomerAddress_AsyncOperations
        {
            get { return GetRelatedEntity<CustomerAddress>("CustomerAddress_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("CustomerAddress_AsyncOperations");
                SetRelatedEntity("CustomerAddress_AsyncOperations", null, value);
                OnPropertyChanged("CustomerAddress_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 CustomerOpportunityRole_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("CustomerOpportunityRole_AsyncOperations")]
        public CustomerOpportunityRole CustomerOpportunityRole_AsyncOperations
        {
            get { return GetRelatedEntity<CustomerOpportunityRole>("CustomerOpportunityRole_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("CustomerOpportunityRole_AsyncOperations");
                SetRelatedEntity("CustomerOpportunityRole_AsyncOperations", null, value);
                OnPropertyChanged("CustomerOpportunityRole_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 CustomerRelationship_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("CustomerRelationship_AsyncOperations")]
        public CustomerRelationship CustomerRelationship_AsyncOperations
        {
            get { return GetRelatedEntity<CustomerRelationship>("CustomerRelationship_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("CustomerRelationship_AsyncOperations");
                SetRelatedEntity("CustomerRelationship_AsyncOperations", null, value);
                OnPropertyChanged("CustomerRelationship_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Discount_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Discount_AsyncOperations")]
        public Discount Discount_AsyncOperations
        {
            get { return GetRelatedEntity<Discount>("Discount_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Discount_AsyncOperations");
                SetRelatedEntity("Discount_AsyncOperations", null, value);
                OnPropertyChanged("Discount_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 DiscountType_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("DiscountType_AsyncOperations")]
        public DiscountType DiscountType_AsyncOperations
        {
            get { return GetRelatedEntity<DiscountType>("DiscountType_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("DiscountType_AsyncOperations");
                SetRelatedEntity("DiscountType_AsyncOperations", null, value);
                OnPropertyChanged("DiscountType_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 DisplayString_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("DisplayString_AsyncOperations")]
        public DisplayString DisplayString_AsyncOperations
        {
            get { return GetRelatedEntity<DisplayString>("DisplayString_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("DisplayString_AsyncOperations");
                SetRelatedEntity("DisplayString_AsyncOperations", null, value);
                OnPropertyChanged("DisplayString_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Email_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Email_AsyncOperations")]
        public Email Email_AsyncOperations
        {
            get { return GetRelatedEntity<Email>("Email_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Email_AsyncOperations");
                SetRelatedEntity("Email_AsyncOperations", null, value);
                OnPropertyChanged("Email_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 emailserverprofile_asyncoperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("emailserverprofile_asyncoperations")]
        public EmailServerProfile emailserverprofile_asyncoperations
        {
            get { return GetRelatedEntity<EmailServerProfile>("emailserverprofile_asyncoperations", null); }
            set
            {
                OnPropertyChanging("emailserverprofile_asyncoperations");
                SetRelatedEntity("emailserverprofile_asyncoperations", null, value);
                OnPropertyChanged("emailserverprofile_asyncoperations");
            }
        }

        /// <summary>
        ///     N:1 EntityMap_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("EntityMap_AsyncOperations")]
        public EntityMap EntityMap_AsyncOperations
        {
            get { return GetRelatedEntity<EntityMap>("EntityMap_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("EntityMap_AsyncOperations");
                SetRelatedEntity("EntityMap_AsyncOperations", null, value);
                OnPropertyChanged("EntityMap_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Equipment_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Equipment_AsyncOperations")]
        public Equipment Equipment_AsyncOperations
        {
            get { return GetRelatedEntity<Equipment>("Equipment_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Equipment_AsyncOperations");
                SetRelatedEntity("Equipment_AsyncOperations", null, value);
                OnPropertyChanged("Equipment_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Fax_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Fax_AsyncOperations")]
        public Fax Fax_AsyncOperations
        {
            get { return GetRelatedEntity<Fax>("Fax_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Fax_AsyncOperations");
                SetRelatedEntity("Fax_AsyncOperations", null, value);
                OnPropertyChanged("Fax_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 FixedMonthlyFiscalCalendar_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("FixedMonthlyFiscalCalendar_AsyncOperations")]
        public FixedMonthlyFiscalCalendar FixedMonthlyFiscalCalendar_AsyncOperations
        {
            get
            {
                return GetRelatedEntity<FixedMonthlyFiscalCalendar>("FixedMonthlyFiscalCalendar_AsyncOperations", null);
            }
            set
            {
                OnPropertyChanging("FixedMonthlyFiscalCalendar_AsyncOperations");
                SetRelatedEntity("FixedMonthlyFiscalCalendar_AsyncOperations", null, value);
                OnPropertyChanged("FixedMonthlyFiscalCalendar_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Goal_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Goal_AsyncOperations")]
        public Goal Goal_AsyncOperations
        {
            get { return GetRelatedEntity<Goal>("Goal_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Goal_AsyncOperations");
                SetRelatedEntity("Goal_AsyncOperations", null, value);
                OnPropertyChanged("Goal_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 goalrollupquery_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("goalrollupquery_AsyncOperations")]
        public GoalRollupQuery goalrollupquery_AsyncOperations
        {
            get { return GetRelatedEntity<GoalRollupQuery>("goalrollupquery_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("goalrollupquery_AsyncOperations");
                SetRelatedEntity("goalrollupquery_AsyncOperations", null, value);
                OnPropertyChanged("goalrollupquery_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Import_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Import_AsyncOperations")]
        public Import Import_AsyncOperations
        {
            get { return GetRelatedEntity<Import>("Import_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Import_AsyncOperations");
                SetRelatedEntity("Import_AsyncOperations", null, value);
                OnPropertyChanged("Import_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 ImportFile_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("ImportFile_AsyncOperations")]
        public ImportFile ImportFile_AsyncOperations
        {
            get { return GetRelatedEntity<ImportFile>("ImportFile_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("ImportFile_AsyncOperations");
                SetRelatedEntity("ImportFile_AsyncOperations", null, value);
                OnPropertyChanged("ImportFile_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 ImportLog_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("ImportLog_AsyncOperations")]
        public ImportLog ImportLog_AsyncOperations
        {
            get { return GetRelatedEntity<ImportLog>("ImportLog_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("ImportLog_AsyncOperations");
                SetRelatedEntity("ImportLog_AsyncOperations", null, value);
                OnPropertyChanged("ImportLog_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 ImportMap_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("ImportMap_AsyncOperations")]
        public ImportMap ImportMap_AsyncOperations
        {
            get { return GetRelatedEntity<ImportMap>("ImportMap_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("ImportMap_AsyncOperations");
                SetRelatedEntity("ImportMap_AsyncOperations", null, value);
                OnPropertyChanged("ImportMap_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Incident_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Incident_AsyncOperations")]
        public Incident Incident_AsyncOperations
        {
            get { return GetRelatedEntity<Incident>("Incident_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Incident_AsyncOperations");
                SetRelatedEntity("Incident_AsyncOperations", null, value);
                OnPropertyChanged("Incident_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 IncidentResolution_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("IncidentResolution_AsyncOperations")]
        public IncidentResolution IncidentResolution_AsyncOperations
        {
            get { return GetRelatedEntity<IncidentResolution>("IncidentResolution_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("IncidentResolution_AsyncOperations");
                SetRelatedEntity("IncidentResolution_AsyncOperations", null, value);
                OnPropertyChanged("IncidentResolution_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Invoice_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Invoice_AsyncOperations")]
        public Invoice Invoice_AsyncOperations
        {
            get { return GetRelatedEntity<Invoice>("Invoice_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Invoice_AsyncOperations");
                SetRelatedEntity("Invoice_AsyncOperations", null, value);
                OnPropertyChanged("Invoice_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 InvoiceDetail_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("InvoiceDetail_AsyncOperations")]
        public InvoiceDetail InvoiceDetail_AsyncOperations
        {
            get { return GetRelatedEntity<InvoiceDetail>("InvoiceDetail_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("InvoiceDetail_AsyncOperations");
                SetRelatedEntity("InvoiceDetail_AsyncOperations", null, value);
                OnPropertyChanged("InvoiceDetail_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 IsvConfig_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("IsvConfig_AsyncOperations")]
        public IsvConfig IsvConfig_AsyncOperations
        {
            get { return GetRelatedEntity<IsvConfig>("IsvConfig_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("IsvConfig_AsyncOperations");
                SetRelatedEntity("IsvConfig_AsyncOperations", null, value);
                OnPropertyChanged("IsvConfig_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 KbArticle_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("KbArticle_AsyncOperations")]
        public KbArticle KbArticle_AsyncOperations
        {
            get { return GetRelatedEntity<KbArticle>("KbArticle_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("KbArticle_AsyncOperations");
                SetRelatedEntity("KbArticle_AsyncOperations", null, value);
                OnPropertyChanged("KbArticle_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 KbArticleComment_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("KbArticleComment_AsyncOperations")]
        public KbArticleComment KbArticleComment_AsyncOperations
        {
            get { return GetRelatedEntity<KbArticleComment>("KbArticleComment_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("KbArticleComment_AsyncOperations");
                SetRelatedEntity("KbArticleComment_AsyncOperations", null, value);
                OnPropertyChanged("KbArticleComment_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 KbArticleTemplate_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("KbArticleTemplate_AsyncOperations")]
        public KbArticleTemplate KbArticleTemplate_AsyncOperations
        {
            get { return GetRelatedEntity<KbArticleTemplate>("KbArticleTemplate_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("KbArticleTemplate_AsyncOperations");
                SetRelatedEntity("KbArticleTemplate_AsyncOperations", null, value);
                OnPropertyChanged("KbArticleTemplate_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Lead_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Lead_AsyncOperations")]
        public Lead Lead_AsyncOperations
        {
            get { return GetRelatedEntity<Lead>("Lead_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Lead_AsyncOperations");
                SetRelatedEntity("Lead_AsyncOperations", null, value);
                OnPropertyChanged("Lead_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Letter_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Letter_AsyncOperations")]
        public Letter Letter_AsyncOperations
        {
            get { return GetRelatedEntity<Letter>("Letter_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Letter_AsyncOperations");
                SetRelatedEntity("Letter_AsyncOperations", null, value);
                OnPropertyChanged("Letter_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 List_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("List_AsyncOperations")]
        public List List_AsyncOperations
        {
            get { return GetRelatedEntity<List>("List_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("List_AsyncOperations");
                SetRelatedEntity("List_AsyncOperations", null, value);
                OnPropertyChanged("List_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 lk_asyncoperation_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_asyncoperation_createdby")]
        public SystemUser lk_asyncoperation_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_asyncoperation_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_asyncoperation_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_asyncoperation_createdonbehalfby")]
        public SystemUser lk_asyncoperation_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_asyncoperation_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_asyncoperation_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_asyncoperation_modifiedby")]
        public SystemUser lk_asyncoperation_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_asyncoperation_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_asyncoperation_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_asyncoperation_modifiedonbehalfby")]
        public SystemUser lk_asyncoperation_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_asyncoperation_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_asyncoperation_workflowactivationid
        /// </summary>
        [AttributeLogicalName("workflowactivationid")]
        [RelationshipSchemaName("lk_asyncoperation_workflowactivationid")]
        public Workflow lk_asyncoperation_workflowactivationid
        {
            get { return GetRelatedEntity<Workflow>("lk_asyncoperation_workflowactivationid", null); }
            set
            {
                OnPropertyChanging("lk_asyncoperation_workflowactivationid");
                SetRelatedEntity("lk_asyncoperation_workflowactivationid", null, value);
                OnPropertyChanged("lk_asyncoperation_workflowactivationid");
            }
        }

        /// <summary>
        ///     N:1 mailbox_asyncoperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("mailbox_asyncoperations")]
        public Mailbox mailbox_asyncoperations
        {
            get { return GetRelatedEntity<Mailbox>("mailbox_asyncoperations", null); }
            set
            {
                OnPropertyChanging("mailbox_asyncoperations");
                SetRelatedEntity("mailbox_asyncoperations", null, value);
                OnPropertyChanged("mailbox_asyncoperations");
            }
        }

        /// <summary>
        ///     N:1 MailMergeTemplate_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("MailMergeTemplate_AsyncOperations")]
        public MailMergeTemplate MailMergeTemplate_AsyncOperations
        {
            get { return GetRelatedEntity<MailMergeTemplate>("MailMergeTemplate_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("MailMergeTemplate_AsyncOperations");
                SetRelatedEntity("MailMergeTemplate_AsyncOperations", null, value);
                OnPropertyChanged("MailMergeTemplate_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 metric_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("metric_AsyncOperations")]
        public Metric metric_AsyncOperations
        {
            get { return GetRelatedEntity<Metric>("metric_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("metric_AsyncOperations");
                SetRelatedEntity("metric_AsyncOperations", null, value);
                OnPropertyChanged("metric_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 MonthlyFiscalCalendar_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("MonthlyFiscalCalendar_AsyncOperations")]
        public MonthlyFiscalCalendar MonthlyFiscalCalendar_AsyncOperations
        {
            get { return GetRelatedEntity<MonthlyFiscalCalendar>("MonthlyFiscalCalendar_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("MonthlyFiscalCalendar_AsyncOperations");
                SetRelatedEntity("MonthlyFiscalCalendar_AsyncOperations", null, value);
                OnPropertyChanged("MonthlyFiscalCalendar_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 msdyn_postalbum_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("msdyn_postalbum_AsyncOperations")]
        public msdyn_PostAlbum msdyn_postalbum_AsyncOperations
        {
            get { return GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_AsyncOperations");
                SetRelatedEntity("msdyn_postalbum_AsyncOperations", null, value);
                OnPropertyChanged("msdyn_postalbum_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 msdyn_postconfig_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("msdyn_postconfig_AsyncOperations")]
        public msdyn_PostConfig msdyn_postconfig_AsyncOperations
        {
            get { return GetRelatedEntity<msdyn_PostConfig>("msdyn_postconfig_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("msdyn_postconfig_AsyncOperations");
                SetRelatedEntity("msdyn_postconfig_AsyncOperations", null, value);
                OnPropertyChanged("msdyn_postconfig_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 msdyn_postruleconfig_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("msdyn_postruleconfig_AsyncOperations")]
        public msdyn_PostRuleConfig msdyn_postruleconfig_AsyncOperations
        {
            get { return GetRelatedEntity<msdyn_PostRuleConfig>("msdyn_postruleconfig_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("msdyn_postruleconfig_AsyncOperations");
                SetRelatedEntity("msdyn_postruleconfig_AsyncOperations", null, value);
                OnPropertyChanged("msdyn_postruleconfig_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 msdyn_wallsavedquery_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("msdyn_wallsavedquery_AsyncOperations")]
        public msdyn_wallsavedquery msdyn_wallsavedquery_AsyncOperations
        {
            get { return GetRelatedEntity<msdyn_wallsavedquery>("msdyn_wallsavedquery_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("msdyn_wallsavedquery_AsyncOperations");
                SetRelatedEntity("msdyn_wallsavedquery_AsyncOperations", null, value);
                OnPropertyChanged("msdyn_wallsavedquery_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 msdyn_wallsavedqueryusersettings_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("msdyn_wallsavedqueryusersettings_AsyncOperations")]
        public msdyn_wallsavedqueryusersettings msdyn_wallsavedqueryusersettings_AsyncOperations
        {
            get
            {
                return
                    GetRelatedEntity<msdyn_wallsavedqueryusersettings>(
                        "msdyn_wallsavedqueryusersettings_AsyncOperations", null);
            }
            set
            {
                OnPropertyChanging("msdyn_wallsavedqueryusersettings_AsyncOperations");
                SetRelatedEntity("msdyn_wallsavedqueryusersettings_AsyncOperations", null, value);
                OnPropertyChanged("msdyn_wallsavedqueryusersettings_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Opportunity_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Opportunity_AsyncOperations")]
        public Opportunity Opportunity_AsyncOperations
        {
            get { return GetRelatedEntity<Opportunity>("Opportunity_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Opportunity_AsyncOperations");
                SetRelatedEntity("Opportunity_AsyncOperations", null, value);
                OnPropertyChanged("Opportunity_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 OpportunityClose_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("OpportunityClose_AsyncOperations")]
        public OpportunityClose OpportunityClose_AsyncOperations
        {
            get { return GetRelatedEntity<OpportunityClose>("OpportunityClose_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("OpportunityClose_AsyncOperations");
                SetRelatedEntity("OpportunityClose_AsyncOperations", null, value);
                OnPropertyChanged("OpportunityClose_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 OpportunityProduct_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("OpportunityProduct_AsyncOperations")]
        public OpportunityProduct OpportunityProduct_AsyncOperations
        {
            get { return GetRelatedEntity<OpportunityProduct>("OpportunityProduct_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("OpportunityProduct_AsyncOperations");
                SetRelatedEntity("OpportunityProduct_AsyncOperations", null, value);
                OnPropertyChanged("OpportunityProduct_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 OrderClose_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("OrderClose_AsyncOperations")]
        public OrderClose OrderClose_AsyncOperations
        {
            get { return GetRelatedEntity<OrderClose>("OrderClose_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("OrderClose_AsyncOperations");
                SetRelatedEntity("OrderClose_AsyncOperations", null, value);
                OnPropertyChanged("OrderClose_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Organization_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Organization_AsyncOperations")]
        public Organization Organization_AsyncOperations
        {
            get { return GetRelatedEntity<Organization>("Organization_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Organization_AsyncOperations");
                SetRelatedEntity("Organization_AsyncOperations", null, value);
                OnPropertyChanged("Organization_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 PhoneCall_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("PhoneCall_AsyncOperations")]
        public PhoneCall PhoneCall_AsyncOperations
        {
            get { return GetRelatedEntity<PhoneCall>("PhoneCall_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("PhoneCall_AsyncOperations");
                SetRelatedEntity("PhoneCall_AsyncOperations", null, value);
                OnPropertyChanged("PhoneCall_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 post_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("post_AsyncOperations")]
        public Post post_AsyncOperations
        {
            get { return GetRelatedEntity<Post>("post_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("post_AsyncOperations");
                SetRelatedEntity("post_AsyncOperations", null, value);
                OnPropertyChanged("post_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 PostFollow_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("PostFollow_AsyncOperations")]
        public PostFollow PostFollow_AsyncOperations
        {
            get { return GetRelatedEntity<PostFollow>("PostFollow_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("PostFollow_AsyncOperations");
                SetRelatedEntity("PostFollow_AsyncOperations", null, value);
                OnPropertyChanged("PostFollow_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 PriceLevel_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("PriceLevel_AsyncOperations")]
        public PriceLevel PriceLevel_AsyncOperations
        {
            get { return GetRelatedEntity<PriceLevel>("PriceLevel_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("PriceLevel_AsyncOperations");
                SetRelatedEntity("PriceLevel_AsyncOperations", null, value);
                OnPropertyChanged("PriceLevel_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Privilege_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Privilege_AsyncOperations")]
        public Privilege Privilege_AsyncOperations
        {
            get { return GetRelatedEntity<Privilege>("Privilege_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Privilege_AsyncOperations");
                SetRelatedEntity("Privilege_AsyncOperations", null, value);
                OnPropertyChanged("Privilege_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Product_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Product_AsyncOperations")]
        public Product Product_AsyncOperations
        {
            get { return GetRelatedEntity<Product>("Product_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Product_AsyncOperations");
                SetRelatedEntity("Product_AsyncOperations", null, value);
                OnPropertyChanged("Product_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 ProductPriceLevel_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("ProductPriceLevel_AsyncOperations")]
        public ProductPriceLevel ProductPriceLevel_AsyncOperations
        {
            get { return GetRelatedEntity<ProductPriceLevel>("ProductPriceLevel_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("ProductPriceLevel_AsyncOperations");
                SetRelatedEntity("ProductPriceLevel_AsyncOperations", null, value);
                OnPropertyChanged("ProductPriceLevel_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 QuarterlyFiscalCalendar_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("QuarterlyFiscalCalendar_AsyncOperations")]
        public QuarterlyFiscalCalendar QuarterlyFiscalCalendar_AsyncOperations
        {
            get { return GetRelatedEntity<QuarterlyFiscalCalendar>("QuarterlyFiscalCalendar_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("QuarterlyFiscalCalendar_AsyncOperations");
                SetRelatedEntity("QuarterlyFiscalCalendar_AsyncOperations", null, value);
                OnPropertyChanged("QuarterlyFiscalCalendar_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Queue_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Queue_AsyncOperations")]
        public Queue Queue_AsyncOperations
        {
            get { return GetRelatedEntity<Queue>("Queue_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Queue_AsyncOperations");
                SetRelatedEntity("Queue_AsyncOperations", null, value);
                OnPropertyChanged("Queue_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 QueueItem_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("QueueItem_AsyncOperations")]
        public QueueItem QueueItem_AsyncOperations
        {
            get { return GetRelatedEntity<QueueItem>("QueueItem_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("QueueItem_AsyncOperations");
                SetRelatedEntity("QueueItem_AsyncOperations", null, value);
                OnPropertyChanged("QueueItem_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Quote_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Quote_AsyncOperations")]
        public Quote Quote_AsyncOperations
        {
            get { return GetRelatedEntity<Quote>("Quote_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Quote_AsyncOperations");
                SetRelatedEntity("Quote_AsyncOperations", null, value);
                OnPropertyChanged("Quote_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 QuoteClose_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("QuoteClose_AsyncOperations")]
        public QuoteClose QuoteClose_AsyncOperations
        {
            get { return GetRelatedEntity<QuoteClose>("QuoteClose_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("QuoteClose_AsyncOperations");
                SetRelatedEntity("QuoteClose_AsyncOperations", null, value);
                OnPropertyChanged("QuoteClose_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 QuoteDetail_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("QuoteDetail_AsyncOperations")]
        public QuoteDetail QuoteDetail_AsyncOperations
        {
            get { return GetRelatedEntity<QuoteDetail>("QuoteDetail_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("QuoteDetail_AsyncOperations");
                SetRelatedEntity("QuoteDetail_AsyncOperations", null, value);
                OnPropertyChanged("QuoteDetail_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 RecurringAppointmentMaster_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("RecurringAppointmentMaster_AsyncOperations")]
        public RecurringAppointmentMaster RecurringAppointmentMaster_AsyncOperations
        {
            get
            {
                return GetRelatedEntity<RecurringAppointmentMaster>("RecurringAppointmentMaster_AsyncOperations", null);
            }
            set
            {
                OnPropertyChanging("RecurringAppointmentMaster_AsyncOperations");
                SetRelatedEntity("RecurringAppointmentMaster_AsyncOperations", null, value);
                OnPropertyChanged("RecurringAppointmentMaster_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 RelationshipRole_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("RelationshipRole_AsyncOperations")]
        public RelationshipRole RelationshipRole_AsyncOperations
        {
            get { return GetRelatedEntity<RelationshipRole>("RelationshipRole_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("RelationshipRole_AsyncOperations");
                SetRelatedEntity("RelationshipRole_AsyncOperations", null, value);
                OnPropertyChanged("RelationshipRole_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 RelationshipRoleMap_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("RelationshipRoleMap_AsyncOperations")]
        public RelationshipRoleMap RelationshipRoleMap_AsyncOperations
        {
            get { return GetRelatedEntity<RelationshipRoleMap>("RelationshipRoleMap_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("RelationshipRoleMap_AsyncOperations");
                SetRelatedEntity("RelationshipRoleMap_AsyncOperations", null, value);
                OnPropertyChanged("RelationshipRoleMap_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Report_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Report_AsyncOperations")]
        public Report Report_AsyncOperations
        {
            get { return GetRelatedEntity<Report>("Report_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Report_AsyncOperations");
                SetRelatedEntity("Report_AsyncOperations", null, value);
                OnPropertyChanged("Report_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Resource_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Resource_AsyncOperations")]
        public Resource Resource_AsyncOperations
        {
            get { return GetRelatedEntity<Resource>("Resource_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Resource_AsyncOperations");
                SetRelatedEntity("Resource_AsyncOperations", null, value);
                OnPropertyChanged("Resource_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 ResourceGroup_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("ResourceGroup_AsyncOperations")]
        public ResourceGroup ResourceGroup_AsyncOperations
        {
            get { return GetRelatedEntity<ResourceGroup>("ResourceGroup_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("ResourceGroup_AsyncOperations");
                SetRelatedEntity("ResourceGroup_AsyncOperations", null, value);
                OnPropertyChanged("ResourceGroup_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 ResourceSpec_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("ResourceSpec_AsyncOperations")]
        public ResourceSpec ResourceSpec_AsyncOperations
        {
            get { return GetRelatedEntity<ResourceSpec>("ResourceSpec_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("ResourceSpec_AsyncOperations");
                SetRelatedEntity("ResourceSpec_AsyncOperations", null, value);
                OnPropertyChanged("ResourceSpec_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Role_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Role_AsyncOperations")]
        public Role Role_AsyncOperations
        {
            get { return GetRelatedEntity<Role>("Role_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Role_AsyncOperations");
                SetRelatedEntity("Role_AsyncOperations", null, value);
                OnPropertyChanged("Role_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 rollupfield_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("rollupfield_AsyncOperations")]
        public RollupField rollupfield_AsyncOperations
        {
            get { return GetRelatedEntity<RollupField>("rollupfield_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("rollupfield_AsyncOperations");
                SetRelatedEntity("rollupfield_AsyncOperations", null, value);
                OnPropertyChanged("rollupfield_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 SalesLiterature_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SalesLiterature_AsyncOperations")]
        public SalesLiterature SalesLiterature_AsyncOperations
        {
            get { return GetRelatedEntity<SalesLiterature>("SalesLiterature_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("SalesLiterature_AsyncOperations");
                SetRelatedEntity("SalesLiterature_AsyncOperations", null, value);
                OnPropertyChanged("SalesLiterature_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 SalesLiteratureItem_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SalesLiteratureItem_AsyncOperations")]
        public SalesLiteratureItem SalesLiteratureItem_AsyncOperations
        {
            get { return GetRelatedEntity<SalesLiteratureItem>("SalesLiteratureItem_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("SalesLiteratureItem_AsyncOperations");
                SetRelatedEntity("SalesLiteratureItem_AsyncOperations", null, value);
                OnPropertyChanged("SalesLiteratureItem_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 SalesOrder_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SalesOrder_AsyncOperations")]
        public SalesOrder SalesOrder_AsyncOperations
        {
            get { return GetRelatedEntity<SalesOrder>("SalesOrder_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("SalesOrder_AsyncOperations");
                SetRelatedEntity("SalesOrder_AsyncOperations", null, value);
                OnPropertyChanged("SalesOrder_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 SalesOrderDetail_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SalesOrderDetail_AsyncOperations")]
        public SalesOrderDetail SalesOrderDetail_AsyncOperations
        {
            get { return GetRelatedEntity<SalesOrderDetail>("SalesOrderDetail_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("SalesOrderDetail_AsyncOperations");
                SetRelatedEntity("SalesOrderDetail_AsyncOperations", null, value);
                OnPropertyChanged("SalesOrderDetail_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 SavedQuery_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SavedQuery_AsyncOperations")]
        public SavedQuery SavedQuery_AsyncOperations
        {
            get { return GetRelatedEntity<SavedQuery>("SavedQuery_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("SavedQuery_AsyncOperations");
                SetRelatedEntity("SavedQuery_AsyncOperations", null, value);
                OnPropertyChanged("SavedQuery_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 SdkMessageProcessingStep_AsyncOperations
        /// </summary>
        [AttributeLogicalName("owningextensionid")]
        [RelationshipSchemaName("SdkMessageProcessingStep_AsyncOperations")]
        public SdkMessageProcessingStep SdkMessageProcessingStep_AsyncOperations
        {
            get { return GetRelatedEntity<SdkMessageProcessingStep>("SdkMessageProcessingStep_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("SdkMessageProcessingStep_AsyncOperations");
                SetRelatedEntity("SdkMessageProcessingStep_AsyncOperations", null, value);
                OnPropertyChanged("SdkMessageProcessingStep_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 SemiAnnualFiscalCalendar_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SemiAnnualFiscalCalendar_AsyncOperations")]
        public SemiAnnualFiscalCalendar SemiAnnualFiscalCalendar_AsyncOperations
        {
            get { return GetRelatedEntity<SemiAnnualFiscalCalendar>("SemiAnnualFiscalCalendar_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("SemiAnnualFiscalCalendar_AsyncOperations");
                SetRelatedEntity("SemiAnnualFiscalCalendar_AsyncOperations", null, value);
                OnPropertyChanged("SemiAnnualFiscalCalendar_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Service_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Service_AsyncOperations")]
        public Service Service_AsyncOperations
        {
            get { return GetRelatedEntity<Service>("Service_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Service_AsyncOperations");
                SetRelatedEntity("Service_AsyncOperations", null, value);
                OnPropertyChanged("Service_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 ServiceAppointment_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("ServiceAppointment_AsyncOperations")]
        public ServiceAppointment ServiceAppointment_AsyncOperations
        {
            get { return GetRelatedEntity<ServiceAppointment>("ServiceAppointment_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("ServiceAppointment_AsyncOperations");
                SetRelatedEntity("ServiceAppointment_AsyncOperations", null, value);
                OnPropertyChanged("ServiceAppointment_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 SharePointDocumentLocation_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SharePointDocumentLocation_AsyncOperations")]
        public SharePointDocumentLocation SharePointDocumentLocation_AsyncOperations
        {
            get
            {
                return GetRelatedEntity<SharePointDocumentLocation>("SharePointDocumentLocation_AsyncOperations", null);
            }
            set
            {
                OnPropertyChanging("SharePointDocumentLocation_AsyncOperations");
                SetRelatedEntity("SharePointDocumentLocation_AsyncOperations", null, value);
                OnPropertyChanged("SharePointDocumentLocation_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 SharePointSite_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SharePointSite_AsyncOperations")]
        public SharePointSite SharePointSite_AsyncOperations
        {
            get { return GetRelatedEntity<SharePointSite>("SharePointSite_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("SharePointSite_AsyncOperations");
                SetRelatedEntity("SharePointSite_AsyncOperations", null, value);
                OnPropertyChanged("SharePointSite_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Site_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Site_AsyncOperations")]
        public Site Site_AsyncOperations
        {
            get { return GetRelatedEntity<Site>("Site_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Site_AsyncOperations");
                SetRelatedEntity("Site_AsyncOperations", null, value);
                OnPropertyChanged("Site_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Subject_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Subject_AsyncOperations")]
        public Subject Subject_AsyncOperations
        {
            get { return GetRelatedEntity<Subject>("Subject_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Subject_AsyncOperations");
                SetRelatedEntity("Subject_AsyncOperations", null, value);
                OnPropertyChanged("Subject_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 system_user_asyncoperation
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("system_user_asyncoperation")]
        public SystemUser system_user_asyncoperation
        {
            get { return GetRelatedEntity<SystemUser>("system_user_asyncoperation", null); }
        }

        /// <summary>
        ///     N:1 SystemForm_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SystemForm_AsyncOperations")]
        public SystemForm SystemForm_AsyncOperations
        {
            get { return GetRelatedEntity<SystemForm>("SystemForm_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("SystemForm_AsyncOperations");
                SetRelatedEntity("SystemForm_AsyncOperations", null, value);
                OnPropertyChanged("SystemForm_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 SystemUser_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SystemUser_AsyncOperations")]
        public SystemUser SystemUser_AsyncOperations
        {
            get { return GetRelatedEntity<SystemUser>("SystemUser_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("SystemUser_AsyncOperations");
                SetRelatedEntity("SystemUser_AsyncOperations", null, value);
                OnPropertyChanged("SystemUser_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Task_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Task_AsyncOperations")]
        public Task Task_AsyncOperations
        {
            get { return GetRelatedEntity<Task>("Task_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Task_AsyncOperations");
                SetRelatedEntity("Task_AsyncOperations", null, value);
                OnPropertyChanged("Task_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 team_asyncoperation
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_asyncoperation")]
        public Team team_asyncoperation
        {
            get { return GetRelatedEntity<Team>("team_asyncoperation", null); }
        }

        /// <summary>
        ///     N:1 Team_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Team_AsyncOperations")]
        public Team Team_AsyncOperations
        {
            get { return GetRelatedEntity<Team>("Team_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Team_AsyncOperations");
                SetRelatedEntity("Team_AsyncOperations", null, value);
                OnPropertyChanged("Team_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Template_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Template_AsyncOperations")]
        public Template Template_AsyncOperations
        {
            get { return GetRelatedEntity<Template>("Template_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Template_AsyncOperations");
                SetRelatedEntity("Template_AsyncOperations", null, value);
                OnPropertyChanged("Template_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 Territory_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Territory_AsyncOperations")]
        public Territory Territory_AsyncOperations
        {
            get { return GetRelatedEntity<Territory>("Territory_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Territory_AsyncOperations");
                SetRelatedEntity("Territory_AsyncOperations", null, value);
                OnPropertyChanged("Territory_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 TransactionCurrency_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("TransactionCurrency_AsyncOperations")]
        public TransactionCurrency TransactionCurrency_AsyncOperations
        {
            get { return GetRelatedEntity<TransactionCurrency>("TransactionCurrency_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_AsyncOperations");
                SetRelatedEntity("TransactionCurrency_AsyncOperations", null, value);
                OnPropertyChanged("TransactionCurrency_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 UoM_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("UoM_AsyncOperations")]
        public UoM UoM_AsyncOperations
        {
            get { return GetRelatedEntity<UoM>("UoM_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("UoM_AsyncOperations");
                SetRelatedEntity("UoM_AsyncOperations", null, value);
                OnPropertyChanged("UoM_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 UoMSchedule_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("UoMSchedule_AsyncOperations")]
        public UoMSchedule UoMSchedule_AsyncOperations
        {
            get { return GetRelatedEntity<UoMSchedule>("UoMSchedule_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("UoMSchedule_AsyncOperations");
                SetRelatedEntity("UoMSchedule_AsyncOperations", null, value);
                OnPropertyChanged("UoMSchedule_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 UserForm_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("UserForm_AsyncOperations")]
        public UserForm UserForm_AsyncOperations
        {
            get { return GetRelatedEntity<UserForm>("UserForm_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("UserForm_AsyncOperations");
                SetRelatedEntity("UserForm_AsyncOperations", null, value);
                OnPropertyChanged("UserForm_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 UserQuery_AsyncOperations
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("UserQuery_AsyncOperations")]
        public UserQuery UserQuery_AsyncOperations
        {
            get { return GetRelatedEntity<UserQuery>("UserQuery_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("UserQuery_AsyncOperations");
                SetRelatedEntity("UserQuery_AsyncOperations", null, value);
                OnPropertyChanged("UserQuery_AsyncOperations");
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