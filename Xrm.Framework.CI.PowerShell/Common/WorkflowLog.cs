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
    ///     Log used to track process execution.
    /// </summary>
    [DataContract]
    [EntityLogicalName("workflowlog")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class WorkflowLog : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "workflowlog";

        public const int EntityTypeCode = 4706;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public WorkflowLog() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Name of the activity which the process step is currently processing.
        /// </summary>
        [AttributeLogicalName("activityname")]
        public string ActivityName
        {
            get { return GetAttributeValue<string>("activityname"); }
            set
            {
                OnPropertyChanging("ActivityName");
                SetAttributeValue("activityname", value);
                OnPropertyChanged("ActivityName");
            }
        }

        /// <summary>
        ///     Unique identifier of the parent record.
        /// </summary>
        [AttributeLogicalName("asyncoperationid")]
        public EntityReference AsyncOperationId
        {
            get { return GetAttributeValue<EntityReference>("asyncoperationid"); }
            set
            {
                OnPropertyChanging("AsyncOperationId");
                SetAttributeValue("asyncoperationid", value);
                OnPropertyChanged("AsyncOperationId");
            }
        }

        /// <summary>
        ///     Unique identifier of the system job.
        /// </summary>
        [AttributeLogicalName("childworkflowinstanceid")]
        public EntityReference ChildWorkflowInstanceId
        {
            get { return GetAttributeValue<EntityReference>("childworkflowinstanceid"); }
            set
            {
                OnPropertyChanging("ChildWorkflowInstanceId");
                SetAttributeValue("childworkflowinstanceid", value);
                OnPropertyChanged("ChildWorkflowInstanceId");
            }
        }

        /// <summary>
        ///     Date and time when the operation was completed.
        /// </summary>
        [AttributeLogicalName("completedon")]
        public DateTime? CompletedOn
        {
            get { return GetAttributeValue<DateTime?>("completedon"); }
            set
            {
                OnPropertyChanging("CompletedOn");
                SetAttributeValue("completedon", value);
                OnPropertyChanged("CompletedOn");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the process log entry.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the process log entry was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the process log.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Description of the process step.
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
        ///     Error code related to process.
        /// </summary>
        [AttributeLogicalName("errorcode")]
        public int? ErrorCode
        {
            get { return GetAttributeValue<int?>("errorcode"); }
            set
            {
                OnPropertyChanging("ErrorCode");
                SetAttributeValue("errorcode", value);
                OnPropertyChanged("ErrorCode");
            }
        }

        /// <summary>
        ///     String specifying the result of an interaction activity.
        /// </summary>
        [AttributeLogicalName("interactionactivityresult")]
        public string InteractionActivityResult
        {
            get { return GetAttributeValue<string>("interactionactivityresult"); }
            set
            {
                OnPropertyChanging("InteractionActivityResult");
                SetAttributeValue("interactionactivityresult", value);
                OnPropertyChanged("InteractionActivityResult");
            }
        }

        /// <summary>
        ///     Message related to process.
        /// </summary>
        [AttributeLogicalName("message")]
        public string Message
        {
            get { return GetAttributeValue<string>("message"); }
            set
            {
                OnPropertyChanging("Message");
                SetAttributeValue("message", value);
                OnPropertyChanged("Message");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the process log entry.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the process log entry was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the process log.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the user or team who owns the process log.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId
        {
            get { return GetAttributeValue<EntityReference>("ownerid"); }
        }

        /// <summary>
        ///     Unique identifier of the business unit that owns the process.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the process log.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the process.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Unique identifier of the associated record.
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
        ///     Name of the process stage.
        /// </summary>
        [AttributeLogicalName("stagename")]
        public string StageName
        {
            get { return GetAttributeValue<string>("stagename"); }
            set
            {
                OnPropertyChanging("StageName");
                SetAttributeValue("stagename", value);
                OnPropertyChanged("StageName");
            }
        }

        /// <summary>
        ///     Status of the process step for which process log record has been created: In Progress, Successfully Completed, or
        ///     Failed.
        /// </summary>
        [AttributeLogicalName("status")]
        public OptionSetValue Status
        {
            get { return GetAttributeValue<OptionSetValue>("status"); }
            set
            {
                OnPropertyChanging("Status");
                SetAttributeValue("status", value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        ///     Name of the process step.
        /// </summary>
        [AttributeLogicalName("stepname")]
        public string StepName
        {
            get { return GetAttributeValue<string>("stepname"); }
            set
            {
                OnPropertyChanging("StepName");
                SetAttributeValue("stepname", value);
                OnPropertyChanged("StepName");
            }
        }

        /// <summary>
        ///     Unique identifier of the process log entry.
        /// </summary>
        [AttributeLogicalName("workflowlogid")]
        public Guid? WorkflowLogId
        {
            get { return GetAttributeValue<Guid?>("workflowlogid"); }
            set
            {
                OnPropertyChanging("WorkflowLogId");
                SetAttributeValue("workflowlogid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("WorkflowLogId");
            }
        }

        [AttributeLogicalName("workflowlogid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { WorkflowLogId = value; }
        }

        /// <summary>
        ///     1:N userentityinstancedata_workflowlog
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_workflowlog")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_workflowlog
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_workflowlog", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_workflowlog");
                SetRelatedEntities("userentityinstancedata_workflowlog", null, value);
                OnPropertyChanged("userentityinstancedata_workflowlog");
            }
        }

        /// <summary>
        ///     N:1 business_unit_workflowlogs
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_workflowlogs")]
        public BusinessUnit business_unit_workflowlogs
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_workflowlogs", null); }
        }

        /// <summary>
        ///     N:1 lk_workflowlog_asyncoperation_childworkflow
        /// </summary>
        [AttributeLogicalName("childworkflowinstanceid")]
        [RelationshipSchemaName("lk_workflowlog_asyncoperation_childworkflow")]
        public AsyncOperation lk_workflowlog_asyncoperation_childworkflow
        {
            get { return GetRelatedEntity<AsyncOperation>("lk_workflowlog_asyncoperation_childworkflow", null); }
            set
            {
                OnPropertyChanging("lk_workflowlog_asyncoperation_childworkflow");
                SetRelatedEntity("lk_workflowlog_asyncoperation_childworkflow", null, value);
                OnPropertyChanged("lk_workflowlog_asyncoperation_childworkflow");
            }
        }

        /// <summary>
        ///     N:1 lk_workflowlog_asyncoperations
        /// </summary>
        [AttributeLogicalName("asyncoperationid")]
        [RelationshipSchemaName("lk_workflowlog_asyncoperations")]
        public AsyncOperation lk_workflowlog_asyncoperations
        {
            get { return GetRelatedEntity<AsyncOperation>("lk_workflowlog_asyncoperations", null); }
            set
            {
                OnPropertyChanging("lk_workflowlog_asyncoperations");
                SetRelatedEntity("lk_workflowlog_asyncoperations", null, value);
                OnPropertyChanged("lk_workflowlog_asyncoperations");
            }
        }

        /// <summary>
        ///     N:1 lk_workflowlog_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_workflowlog_createdby")]
        public SystemUser lk_workflowlog_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_workflowlog_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_workflowlog_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_workflowlog_createdonbehalfby")]
        public SystemUser lk_workflowlog_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_workflowlog_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_workflowlog_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_workflowlog_modifiedby")]
        public SystemUser lk_workflowlog_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_workflowlog_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_workflowlog_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_workflowlog_modifiedonbehalfby")]
        public SystemUser lk_workflowlog_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_workflowlog_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_workflowlog_processsession
        /// </summary>
        [AttributeLogicalName("asyncoperationid")]
        [RelationshipSchemaName("lk_workflowlog_processsession")]
        public ProcessSession lk_workflowlog_processsession
        {
            get { return GetRelatedEntity<ProcessSession>("lk_workflowlog_processsession", null); }
            set
            {
                OnPropertyChanging("lk_workflowlog_processsession");
                SetRelatedEntity("lk_workflowlog_processsession", null, value);
                OnPropertyChanged("lk_workflowlog_processsession");
            }
        }

        /// <summary>
        ///     N:1 lk_workflowlog_processsession_childworkflow
        /// </summary>
        [AttributeLogicalName("childworkflowinstanceid")]
        [RelationshipSchemaName("lk_workflowlog_processsession_childworkflow")]
        public ProcessSession lk_workflowlog_processsession_childworkflow
        {
            get { return GetRelatedEntity<ProcessSession>("lk_workflowlog_processsession_childworkflow", null); }
            set
            {
                OnPropertyChanging("lk_workflowlog_processsession_childworkflow");
                SetRelatedEntity("lk_workflowlog_processsession_childworkflow", null, value);
                OnPropertyChanged("lk_workflowlog_processsession_childworkflow");
            }
        }

        /// <summary>
        ///     N:1 team_workflowlog
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_workflowlog")]
        public Team team_workflowlog
        {
            get { return GetRelatedEntity<Team>("team_workflowlog", null); }
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