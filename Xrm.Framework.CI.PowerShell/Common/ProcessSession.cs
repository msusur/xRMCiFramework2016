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
    ///     Information that is generated when a dialog is run. Every time that you run a dialog, a dialog session is created.
    /// </summary>
    [DataContract]
    [EntityLogicalName("processsession")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ProcessSession : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "processsession";

        public const int EntityTypeCode = 4710;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ProcessSession() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Name of the activity that is being executed.
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
        ///     Unique identifier of the user who canceled the dialog session.
        /// </summary>
        [AttributeLogicalName("canceledby")]
        public EntityReference CanceledBy
        {
            get { return GetAttributeValue<EntityReference>("canceledby"); }
        }

        /// <summary>
        ///     Date and time when the dialog session was canceled.
        /// </summary>
        [AttributeLogicalName("canceledon")]
        public DateTime? CanceledOn
        {
            get { return GetAttributeValue<DateTime?>("canceledon"); }
            set
            {
                OnPropertyChanging("CanceledOn");
                SetAttributeValue("canceledon", value);
                OnPropertyChanged("CanceledOn");
            }
        }

        /// <summary>
        ///     User comments.
        /// </summary>
        [AttributeLogicalName("comments")]
        public string Comments
        {
            get { return GetAttributeValue<string>("comments"); }
            set
            {
                OnPropertyChanging("Comments");
                SetAttributeValue("comments", value);
                OnPropertyChanged("Comments");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who completed the dialog session.
        /// </summary>
        [AttributeLogicalName("completedby")]
        public EntityReference CompletedBy
        {
            get { return GetAttributeValue<EntityReference>("completedby"); }
        }

        /// <summary>
        ///     Date and time when the dialog session was completed.
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
        ///     Unique identifier of the user who started the dialog session.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the dialog session was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the dialog session.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Error code related to the dialog session.
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
        ///     Unique identifier of the user who ran the dialog process.
        /// </summary>
        [AttributeLogicalName("executedby")]
        public EntityReference ExecutedBy
        {
            get { return GetAttributeValue<EntityReference>("executedby"); }
            set
            {
                OnPropertyChanging("ExecutedBy");
                SetAttributeValue("executedby", value);
                OnPropertyChanged("ExecutedBy");
            }
        }

        /// <summary>
        ///     Date and time when the dialog process was run.
        /// </summary>
        [AttributeLogicalName("executedon")]
        public DateTime? ExecutedOn
        {
            get { return GetAttributeValue<DateTime?>("executedon"); }
        }

        /// <summary>
        ///     Input arguments for the child dialog process.
        /// </summary>
        [AttributeLogicalName("inputarguments")]
        public string InputArguments
        {
            get { return GetAttributeValue<string>("inputarguments"); }
            set
            {
                OnPropertyChanging("InputArguments");
                SetAttributeValue("inputarguments", value);
                OnPropertyChanged("InputArguments");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the dialog session.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the dialog session was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who modified the dialog session.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the dialog session.
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
        ///     Unique identifier of the succeeding linked dialog session.
        /// </summary>
        [AttributeLogicalName("nextlinkedsessionid")]
        public EntityReference NextLinkedSessionId
        {
            get { return GetAttributeValue<EntityReference>("nextlinkedsessionid"); }
            set
            {
                OnPropertyChanging("NextLinkedSessionId");
                SetAttributeValue("nextlinkedsessionid", value);
                OnPropertyChanged("NextLinkedSessionId");
            }
        }

        /// <summary>
        ///     Unique identifier of the originating dialog session.
        /// </summary>
        [AttributeLogicalName("originatingsessionid")]
        public EntityReference OriginatingSessionId
        {
            get { return GetAttributeValue<EntityReference>("originatingsessionid"); }
            set
            {
                OnPropertyChanging("OriginatingSessionId");
                SetAttributeValue("originatingsessionid", value);
                OnPropertyChanged("OriginatingSessionId");
            }
        }

        /// <summary>
        ///     Unique identifier of the user or team who owns the dialog session.
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
        ///     Unique identifier of the business unit that owns the dialog session.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the dialog session.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the dialog session.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Unique identifier of the preceding linked dialog session.
        /// </summary>
        [AttributeLogicalName("previouslinkedsessionid")]
        public EntityReference PreviousLinkedSessionId
        {
            get { return GetAttributeValue<EntityReference>("previouslinkedsessionid"); }
            set
            {
                OnPropertyChanging("PreviousLinkedSessionId");
                SetAttributeValue("previouslinkedsessionid", value);
                OnPropertyChanged("PreviousLinkedSessionId");
            }
        }

        /// <summary>
        ///     Select the process activation record that is related to the dialog session.
        /// </summary>
        [AttributeLogicalName("processid")]
        public EntityReference ProcessId
        {
            get { return GetAttributeValue<EntityReference>("processid"); }
            set
            {
                OnPropertyChanging("ProcessId");
                SetAttributeValue("processid", value);
                OnPropertyChanged("ProcessId");
            }
        }

        /// <summary>
        ///     Unique identifier of the dialog session.
        /// </summary>
        [AttributeLogicalName("processsessionid")]
        public Guid? ProcessSessionId
        {
            get { return GetAttributeValue<Guid?>("processsessionid"); }
            set
            {
                OnPropertyChanging("ProcessSessionId");
                SetAttributeValue("processsessionid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ProcessSessionId");
            }
        }

        [AttributeLogicalName("processsessionid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ProcessSessionId = value; }
        }

        /// <summary>
        ///     Name of the dialog stage.
        /// </summary>
        [AttributeLogicalName("processstagename")]
        public string ProcessStageName
        {
            get { return GetAttributeValue<string>("processstagename"); }
            set
            {
                OnPropertyChanging("ProcessStageName");
                SetAttributeValue("processstagename", value);
                OnPropertyChanged("ProcessStageName");
            }
        }

        /// <summary>
        ///     State of the dialog process.
        /// </summary>
        [AttributeLogicalName("processstate")]
        public string ProcessState
        {
            get { return GetAttributeValue<string>("processstate"); }
            set
            {
                OnPropertyChanging("ProcessState");
                SetAttributeValue("processstate", value);
                OnPropertyChanged("ProcessState");
            }
        }

        /// <summary>
        ///     Unique identifier of the object with which the dialog session is associated.
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
        ///     Unique identifier of the user who started the dialog session.
        /// </summary>
        [AttributeLogicalName("startedby")]
        public EntityReference StartedBy
        {
            get { return GetAttributeValue<EntityReference>("startedby"); }
        }

        /// <summary>
        ///     Date and time when the dialog session was started.
        /// </summary>
        [AttributeLogicalName("startedon")]
        public DateTime? StartedOn
        {
            get { return GetAttributeValue<DateTime?>("startedon"); }
            set
            {
                OnPropertyChanging("StartedOn");
                SetAttributeValue("startedon", value);
                OnPropertyChanged("StartedOn");
            }
        }

        /// <summary>
        ///     Status of the dialog session.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public ProcessSessionState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ProcessSessionState) (Enum.ToObject(typeof (ProcessSessionState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the dialog session.
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
        ///     Name of the dialog step.
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
        ///     1:N lk_processsession_nextlinkedsessionid
        /// </summary>
        [RelationshipSchemaName("lk_processsession_nextlinkedsessionid", EntityRole.Referenced)]
        public IEnumerable<ProcessSession> Referencedlk_processsession_nextlinkedsessionid
        {
            get
            {
                return GetRelatedEntities<ProcessSession>("lk_processsession_nextlinkedsessionid", EntityRole.Referenced);
            }
            set
            {
                OnPropertyChanging("Referencedlk_processsession_nextlinkedsessionid");
                SetRelatedEntities("lk_processsession_nextlinkedsessionid", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedlk_processsession_nextlinkedsessionid");
            }
        }

        /// <summary>
        ///     1:N lk_processsession_originatingsessionid
        /// </summary>
        [RelationshipSchemaName("lk_processsession_originatingsessionid", EntityRole.Referenced)]
        public IEnumerable<ProcessSession> Referencedlk_processsession_originatingsessionid
        {
            get
            {
                return GetRelatedEntities<ProcessSession>("lk_processsession_originatingsessionid",
                    EntityRole.Referenced);
            }
            set
            {
                OnPropertyChanging("Referencedlk_processsession_originatingsessionid");
                SetRelatedEntities("lk_processsession_originatingsessionid", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedlk_processsession_originatingsessionid");
            }
        }

        /// <summary>
        ///     1:N lk_processsession_previouslinkedsessionid
        /// </summary>
        [RelationshipSchemaName("lk_processsession_previouslinkedsessionid", EntityRole.Referenced)]
        public IEnumerable<ProcessSession> Referencedlk_processsession_previouslinkedsessionid
        {
            get
            {
                return GetRelatedEntities<ProcessSession>("lk_processsession_previouslinkedsessionid",
                    EntityRole.Referenced);
            }
            set
            {
                OnPropertyChanging("Referencedlk_processsession_previouslinkedsessionid");
                SetRelatedEntities("lk_processsession_previouslinkedsessionid", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedlk_processsession_previouslinkedsessionid");
            }
        }

        /// <summary>
        ///     1:N lk_workflowlog_processsession
        /// </summary>
        [RelationshipSchemaName("lk_workflowlog_processsession")]
        public IEnumerable<WorkflowLog> lk_workflowlog_processsession
        {
            get { return GetRelatedEntities<WorkflowLog>("lk_workflowlog_processsession", null); }
            set
            {
                OnPropertyChanging("lk_workflowlog_processsession");
                SetRelatedEntities("lk_workflowlog_processsession", null, value);
                OnPropertyChanged("lk_workflowlog_processsession");
            }
        }

        /// <summary>
        ///     1:N lk_workflowlog_processsession_childworkflow
        /// </summary>
        [RelationshipSchemaName("lk_workflowlog_processsession_childworkflow")]
        public IEnumerable<WorkflowLog> lk_workflowlog_processsession_childworkflow
        {
            get { return GetRelatedEntities<WorkflowLog>("lk_workflowlog_processsession_childworkflow", null); }
            set
            {
                OnPropertyChanging("lk_workflowlog_processsession_childworkflow");
                SetRelatedEntities("lk_workflowlog_processsession_childworkflow", null, value);
                OnPropertyChanged("lk_workflowlog_processsession_childworkflow");
            }
        }

        /// <summary>
        ///     1:N processsession_connections1
        /// </summary>
        [RelationshipSchemaName("processsession_connections1")]
        public IEnumerable<Connection> processsession_connections1
        {
            get { return GetRelatedEntities<Connection>("processsession_connections1", null); }
            set
            {
                OnPropertyChanging("processsession_connections1");
                SetRelatedEntities("processsession_connections1", null, value);
                OnPropertyChanged("processsession_connections1");
            }
        }

        /// <summary>
        ///     1:N processsession_connections2
        /// </summary>
        [RelationshipSchemaName("processsession_connections2")]
        public IEnumerable<Connection> processsession_connections2
        {
            get { return GetRelatedEntities<Connection>("processsession_connections2", null); }
            set
            {
                OnPropertyChanging("processsession_connections2");
                SetRelatedEntities("processsession_connections2", null, value);
                OnPropertyChanged("processsession_connections2");
            }
        }

        /// <summary>
        ///     1:N processsession_PostFollows
        /// </summary>
        [RelationshipSchemaName("processsession_PostFollows")]
        public IEnumerable<PostFollow> processsession_PostFollows
        {
            get { return GetRelatedEntities<PostFollow>("processsession_PostFollows", null); }
            set
            {
                OnPropertyChanging("processsession_PostFollows");
                SetRelatedEntities("processsession_PostFollows", null, value);
                OnPropertyChanged("processsession_PostFollows");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_processsession
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_processsession")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_processsession
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_processsession", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_processsession");
                SetRelatedEntities("userentityinstancedata_processsession", null, value);
                OnPropertyChanged("userentityinstancedata_processsession");
            }
        }

        /// <summary>
        ///     N:1 Account_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Account_ProcessSessions")]
        public Account Account_ProcessSessions
        {
            get { return GetRelatedEntity<Account>("Account_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Account_ProcessSessions");
                SetRelatedEntity("Account_ProcessSessions", null, value);
                OnPropertyChanged("Account_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 Annotation_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Annotation_ProcessSessions")]
        public Annotation Annotation_ProcessSessions
        {
            get { return GetRelatedEntity<Annotation>("Annotation_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Annotation_ProcessSessions");
                SetRelatedEntity("Annotation_ProcessSessions", null, value);
                OnPropertyChanged("Annotation_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 Appointment_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Appointment_ProcessSessions")]
        public Appointment Appointment_ProcessSessions
        {
            get { return GetRelatedEntity<Appointment>("Appointment_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Appointment_ProcessSessions");
                SetRelatedEntity("Appointment_ProcessSessions", null, value);
                OnPropertyChanged("Appointment_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 BusinessUnit_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("BusinessUnit_ProcessSessions")]
        public BusinessUnit BusinessUnit_ProcessSessions
        {
            get { return GetRelatedEntity<BusinessUnit>("BusinessUnit_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("BusinessUnit_ProcessSessions");
                SetRelatedEntity("BusinessUnit_ProcessSessions", null, value);
                OnPropertyChanged("BusinessUnit_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 BusinessUnitNewsArticle_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("BusinessUnitNewsArticle_ProcessSessions")]
        public BusinessUnitNewsArticle BusinessUnitNewsArticle_ProcessSessions
        {
            get { return GetRelatedEntity<BusinessUnitNewsArticle>("BusinessUnitNewsArticle_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("BusinessUnitNewsArticle_ProcessSessions");
                SetRelatedEntity("BusinessUnitNewsArticle_ProcessSessions", null, value);
                OnPropertyChanged("BusinessUnitNewsArticle_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 Campaign_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Campaign_ProcessSessions")]
        public Campaign Campaign_ProcessSessions
        {
            get { return GetRelatedEntity<Campaign>("Campaign_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Campaign_ProcessSessions");
                SetRelatedEntity("Campaign_ProcessSessions", null, value);
                OnPropertyChanged("Campaign_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 CampaignActivity_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("CampaignActivity_ProcessSessions")]
        public CampaignActivity CampaignActivity_ProcessSessions
        {
            get { return GetRelatedEntity<CampaignActivity>("CampaignActivity_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("CampaignActivity_ProcessSessions");
                SetRelatedEntity("CampaignActivity_ProcessSessions", null, value);
                OnPropertyChanged("CampaignActivity_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 CampaignResponse_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("CampaignResponse_ProcessSessions")]
        public CampaignResponse CampaignResponse_ProcessSessions
        {
            get { return GetRelatedEntity<CampaignResponse>("CampaignResponse_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("CampaignResponse_ProcessSessions");
                SetRelatedEntity("CampaignResponse_ProcessSessions", null, value);
                OnPropertyChanged("CampaignResponse_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 Competitor_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Competitor_ProcessSessions")]
        public Competitor Competitor_ProcessSessions
        {
            get { return GetRelatedEntity<Competitor>("Competitor_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Competitor_ProcessSessions");
                SetRelatedEntity("Competitor_ProcessSessions", null, value);
                OnPropertyChanged("Competitor_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 Connection_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Connection_ProcessSessions")]
        public Connection Connection_ProcessSessions
        {
            get { return GetRelatedEntity<Connection>("Connection_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Connection_ProcessSessions");
                SetRelatedEntity("Connection_ProcessSessions", null, value);
                OnPropertyChanged("Connection_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 ConnectionRole_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("ConnectionRole_ProcessSessions")]
        public ConnectionRole ConnectionRole_ProcessSessions
        {
            get { return GetRelatedEntity<ConnectionRole>("ConnectionRole_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("ConnectionRole_ProcessSessions");
                SetRelatedEntity("ConnectionRole_ProcessSessions", null, value);
                OnPropertyChanged("ConnectionRole_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 ConstraintBasedGroup_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("ConstraintBasedGroup_ProcessSessions")]
        public ConstraintBasedGroup ConstraintBasedGroup_ProcessSessions
        {
            get { return GetRelatedEntity<ConstraintBasedGroup>("ConstraintBasedGroup_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("ConstraintBasedGroup_ProcessSessions");
                SetRelatedEntity("ConstraintBasedGroup_ProcessSessions", null, value);
                OnPropertyChanged("ConstraintBasedGroup_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 Contact_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Contact_ProcessSessions")]
        public Contact Contact_ProcessSessions
        {
            get { return GetRelatedEntity<Contact>("Contact_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Contact_ProcessSessions");
                SetRelatedEntity("Contact_ProcessSessions", null, value);
                OnPropertyChanged("Contact_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 Contract_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Contract_ProcessSessions")]
        public Contract Contract_ProcessSessions
        {
            get { return GetRelatedEntity<Contract>("Contract_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Contract_ProcessSessions");
                SetRelatedEntity("Contract_ProcessSessions", null, value);
                OnPropertyChanged("Contract_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 ContractDetail_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("ContractDetail_ProcessSessions")]
        public ContractDetail ContractDetail_ProcessSessions
        {
            get { return GetRelatedEntity<ContractDetail>("ContractDetail_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("ContractDetail_ProcessSessions");
                SetRelatedEntity("ContractDetail_ProcessSessions", null, value);
                OnPropertyChanged("ContractDetail_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 ContractTemplate_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("ContractTemplate_ProcessSessions")]
        public ContractTemplate ContractTemplate_ProcessSessions
        {
            get { return GetRelatedEntity<ContractTemplate>("ContractTemplate_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("ContractTemplate_ProcessSessions");
                SetRelatedEntity("ContractTemplate_ProcessSessions", null, value);
                OnPropertyChanged("ContractTemplate_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 CustomerAddress_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("CustomerAddress_ProcessSessions")]
        public CustomerAddress CustomerAddress_ProcessSessions
        {
            get { return GetRelatedEntity<CustomerAddress>("CustomerAddress_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("CustomerAddress_ProcessSessions");
                SetRelatedEntity("CustomerAddress_ProcessSessions", null, value);
                OnPropertyChanged("CustomerAddress_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 CustomerOpportunityRole_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("CustomerOpportunityRole_ProcessSessions")]
        public CustomerOpportunityRole CustomerOpportunityRole_ProcessSessions
        {
            get { return GetRelatedEntity<CustomerOpportunityRole>("CustomerOpportunityRole_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("CustomerOpportunityRole_ProcessSessions");
                SetRelatedEntity("CustomerOpportunityRole_ProcessSessions", null, value);
                OnPropertyChanged("CustomerOpportunityRole_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 CustomerRelationship_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("CustomerRelationship_ProcessSessions")]
        public CustomerRelationship CustomerRelationship_ProcessSessions
        {
            get { return GetRelatedEntity<CustomerRelationship>("CustomerRelationship_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("CustomerRelationship_ProcessSessions");
                SetRelatedEntity("CustomerRelationship_ProcessSessions", null, value);
                OnPropertyChanged("CustomerRelationship_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 Discount_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Discount_ProcessSessions")]
        public Discount Discount_ProcessSessions
        {
            get { return GetRelatedEntity<Discount>("Discount_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Discount_ProcessSessions");
                SetRelatedEntity("Discount_ProcessSessions", null, value);
                OnPropertyChanged("Discount_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 DiscountType_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("DiscountType_ProcessSessions")]
        public DiscountType DiscountType_ProcessSessions
        {
            get { return GetRelatedEntity<DiscountType>("DiscountType_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("DiscountType_ProcessSessions");
                SetRelatedEntity("DiscountType_ProcessSessions", null, value);
                OnPropertyChanged("DiscountType_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 Email_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Email_ProcessSessions")]
        public Email Email_ProcessSessions
        {
            get { return GetRelatedEntity<Email>("Email_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Email_ProcessSessions");
                SetRelatedEntity("Email_ProcessSessions", null, value);
                OnPropertyChanged("Email_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 Equipment_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Equipment_ProcessSessions")]
        public Equipment Equipment_ProcessSessions
        {
            get { return GetRelatedEntity<Equipment>("Equipment_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Equipment_ProcessSessions");
                SetRelatedEntity("Equipment_ProcessSessions", null, value);
                OnPropertyChanged("Equipment_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 Fax_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Fax_ProcessSessions")]
        public Fax Fax_ProcessSessions
        {
            get { return GetRelatedEntity<Fax>("Fax_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Fax_ProcessSessions");
                SetRelatedEntity("Fax_ProcessSessions", null, value);
                OnPropertyChanged("Fax_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 Goal_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Goal_ProcessSessions")]
        public Goal Goal_ProcessSessions
        {
            get { return GetRelatedEntity<Goal>("Goal_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Goal_ProcessSessions");
                SetRelatedEntity("Goal_ProcessSessions", null, value);
                OnPropertyChanged("Goal_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 goalrollupquery_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("goalrollupquery_ProcessSessions")]
        public GoalRollupQuery goalrollupquery_ProcessSessions
        {
            get { return GetRelatedEntity<GoalRollupQuery>("goalrollupquery_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("goalrollupquery_ProcessSessions");
                SetRelatedEntity("goalrollupquery_ProcessSessions", null, value);
                OnPropertyChanged("goalrollupquery_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 Incident_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Incident_ProcessSessions")]
        public Incident Incident_ProcessSessions
        {
            get { return GetRelatedEntity<Incident>("Incident_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Incident_ProcessSessions");
                SetRelatedEntity("Incident_ProcessSessions", null, value);
                OnPropertyChanged("Incident_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 Invoice_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Invoice_ProcessSessions")]
        public Invoice Invoice_ProcessSessions
        {
            get { return GetRelatedEntity<Invoice>("Invoice_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Invoice_ProcessSessions");
                SetRelatedEntity("Invoice_ProcessSessions", null, value);
                OnPropertyChanged("Invoice_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 InvoiceDetail_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("InvoiceDetail_ProcessSessions")]
        public InvoiceDetail InvoiceDetail_ProcessSessions
        {
            get { return GetRelatedEntity<InvoiceDetail>("InvoiceDetail_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("InvoiceDetail_ProcessSessions");
                SetRelatedEntity("InvoiceDetail_ProcessSessions", null, value);
                OnPropertyChanged("InvoiceDetail_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 KbArticle_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("KbArticle_ProcessSessions")]
        public KbArticle KbArticle_ProcessSessions
        {
            get { return GetRelatedEntity<KbArticle>("KbArticle_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("KbArticle_ProcessSessions");
                SetRelatedEntity("KbArticle_ProcessSessions", null, value);
                OnPropertyChanged("KbArticle_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 KbArticleComment_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("KbArticleComment_ProcessSessions")]
        public KbArticleComment KbArticleComment_ProcessSessions
        {
            get { return GetRelatedEntity<KbArticleComment>("KbArticleComment_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("KbArticleComment_ProcessSessions");
                SetRelatedEntity("KbArticleComment_ProcessSessions", null, value);
                OnPropertyChanged("KbArticleComment_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 KbArticleTemplate_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("KbArticleTemplate_ProcessSessions")]
        public KbArticleTemplate KbArticleTemplate_ProcessSessions
        {
            get { return GetRelatedEntity<KbArticleTemplate>("KbArticleTemplate_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("KbArticleTemplate_ProcessSessions");
                SetRelatedEntity("KbArticleTemplate_ProcessSessions", null, value);
                OnPropertyChanged("KbArticleTemplate_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 Lead_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Lead_ProcessSessions")]
        public Lead Lead_ProcessSessions
        {
            get { return GetRelatedEntity<Lead>("Lead_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Lead_ProcessSessions");
                SetRelatedEntity("Lead_ProcessSessions", null, value);
                OnPropertyChanged("Lead_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 Letter_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Letter_ProcessSessions")]
        public Letter Letter_ProcessSessions
        {
            get { return GetRelatedEntity<Letter>("Letter_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Letter_ProcessSessions");
                SetRelatedEntity("Letter_ProcessSessions", null, value);
                OnPropertyChanged("Letter_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 List_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("List_ProcessSessions")]
        public List List_ProcessSessions
        {
            get { return GetRelatedEntity<List>("List_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("List_ProcessSessions");
                SetRelatedEntity("List_ProcessSessions", null, value);
                OnPropertyChanged("List_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 lk_processsession_canceledby
        /// </summary>
        [AttributeLogicalName("canceledby")]
        [RelationshipSchemaName("lk_processsession_canceledby")]
        public SystemUser lk_processsession_canceledby
        {
            get { return GetRelatedEntity<SystemUser>("lk_processsession_canceledby", null); }
        }

        /// <summary>
        ///     N:1 lk_processsession_completedby
        /// </summary>
        [AttributeLogicalName("completedby")]
        [RelationshipSchemaName("lk_processsession_completedby")]
        public SystemUser lk_processsession_completedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_processsession_completedby", null); }
        }

        /// <summary>
        ///     N:1 lk_processsession_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_processsession_createdby")]
        public SystemUser lk_processsession_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_processsession_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_processsession_executedby
        /// </summary>
        [AttributeLogicalName("executedby")]
        [RelationshipSchemaName("lk_processsession_executedby")]
        public SystemUser lk_processsession_executedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_processsession_executedby", null); }
            set
            {
                OnPropertyChanging("lk_processsession_executedby");
                SetRelatedEntity("lk_processsession_executedby", null, value);
                OnPropertyChanged("lk_processsession_executedby");
            }
        }

        /// <summary>
        ///     N:1 lk_processsession_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_processsession_modifiedby")]
        public SystemUser lk_processsession_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_processsession_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_processsession_nextlinkedsessionid
        /// </summary>
        [AttributeLogicalName("nextlinkedsessionid")]
        [RelationshipSchemaName("lk_processsession_nextlinkedsessionid", EntityRole.Referencing)]
        public ProcessSession Referencinglk_processsession_nextlinkedsessionid
        {
            get
            {
                return GetRelatedEntity<ProcessSession>("lk_processsession_nextlinkedsessionid", EntityRole.Referencing);
            }
            set
            {
                OnPropertyChanging("Referencinglk_processsession_nextlinkedsessionid");
                SetRelatedEntity("lk_processsession_nextlinkedsessionid", EntityRole.Referencing, value);
                OnPropertyChanged("Referencinglk_processsession_nextlinkedsessionid");
            }
        }

        /// <summary>
        ///     N:1 lk_processsession_originatingsessionid
        /// </summary>
        [AttributeLogicalName("originatingsessionid")]
        [RelationshipSchemaName("lk_processsession_originatingsessionid", EntityRole.Referencing)]
        public ProcessSession Referencinglk_processsession_originatingsessionid
        {
            get
            {
                return GetRelatedEntity<ProcessSession>("lk_processsession_originatingsessionid", EntityRole.Referencing);
            }
            set
            {
                OnPropertyChanging("Referencinglk_processsession_originatingsessionid");
                SetRelatedEntity("lk_processsession_originatingsessionid", EntityRole.Referencing, value);
                OnPropertyChanged("Referencinglk_processsession_originatingsessionid");
            }
        }

        /// <summary>
        ///     N:1 lk_processsession_previouslinkedsessionid
        /// </summary>
        [AttributeLogicalName("previouslinkedsessionid")]
        [RelationshipSchemaName("lk_processsession_previouslinkedsessionid", EntityRole.Referencing)]
        public ProcessSession Referencinglk_processsession_previouslinkedsessionid
        {
            get
            {
                return GetRelatedEntity<ProcessSession>("lk_processsession_previouslinkedsessionid",
                    EntityRole.Referencing);
            }
            set
            {
                OnPropertyChanging("Referencinglk_processsession_previouslinkedsessionid");
                SetRelatedEntity("lk_processsession_previouslinkedsessionid", EntityRole.Referencing, value);
                OnPropertyChanged("Referencinglk_processsession_previouslinkedsessionid");
            }
        }

        /// <summary>
        ///     N:1 lk_processsession_processid
        /// </summary>
        [AttributeLogicalName("processid")]
        [RelationshipSchemaName("lk_processsession_processid")]
        public Workflow lk_processsession_processid
        {
            get { return GetRelatedEntity<Workflow>("lk_processsession_processid", null); }
            set
            {
                OnPropertyChanging("lk_processsession_processid");
                SetRelatedEntity("lk_processsession_processid", null, value);
                OnPropertyChanged("lk_processsession_processid");
            }
        }

        /// <summary>
        ///     N:1 lk_processsession_startedby
        /// </summary>
        [AttributeLogicalName("startedby")]
        [RelationshipSchemaName("lk_processsession_startedby")]
        public SystemUser lk_processsession_startedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_processsession_startedby", null); }
        }

        /// <summary>
        ///     N:1 lk_processsessionbase_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_processsessionbase_createdonbehalfby")]
        public SystemUser lk_processsessionbase_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_processsessionbase_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_processsessionbase_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_processsessionbase_modifiedonbehalfby")]
        public SystemUser lk_processsessionbase_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_processsessionbase_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 mailbox_processsessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("mailbox_processsessions")]
        public Mailbox mailbox_processsessions
        {
            get { return GetRelatedEntity<Mailbox>("mailbox_processsessions", null); }
            set
            {
                OnPropertyChanging("mailbox_processsessions");
                SetRelatedEntity("mailbox_processsessions", null, value);
                OnPropertyChanged("mailbox_processsessions");
            }
        }

        /// <summary>
        ///     N:1 MailMergeTemplate_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("MailMergeTemplate_ProcessSessions")]
        public MailMergeTemplate MailMergeTemplate_ProcessSessions
        {
            get { return GetRelatedEntity<MailMergeTemplate>("MailMergeTemplate_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("MailMergeTemplate_ProcessSessions");
                SetRelatedEntity("MailMergeTemplate_ProcessSessions", null, value);
                OnPropertyChanged("MailMergeTemplate_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 metric_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("metric_ProcessSessions")]
        public Metric metric_ProcessSessions
        {
            get { return GetRelatedEntity<Metric>("metric_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("metric_ProcessSessions");
                SetRelatedEntity("metric_ProcessSessions", null, value);
                OnPropertyChanged("metric_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 msdyn_postalbum_ProcessSession
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("msdyn_postalbum_ProcessSession")]
        public msdyn_PostAlbum msdyn_postalbum_ProcessSession
        {
            get { return GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_ProcessSession", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_ProcessSession");
                SetRelatedEntity("msdyn_postalbum_ProcessSession", null, value);
                OnPropertyChanged("msdyn_postalbum_ProcessSession");
            }
        }

        /// <summary>
        ///     N:1 msdyn_postconfig_ProcessSession
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("msdyn_postconfig_ProcessSession")]
        public msdyn_PostConfig msdyn_postconfig_ProcessSession
        {
            get { return GetRelatedEntity<msdyn_PostConfig>("msdyn_postconfig_ProcessSession", null); }
            set
            {
                OnPropertyChanging("msdyn_postconfig_ProcessSession");
                SetRelatedEntity("msdyn_postconfig_ProcessSession", null, value);
                OnPropertyChanged("msdyn_postconfig_ProcessSession");
            }
        }

        /// <summary>
        ///     N:1 msdyn_postruleconfig_ProcessSession
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("msdyn_postruleconfig_ProcessSession")]
        public msdyn_PostRuleConfig msdyn_postruleconfig_ProcessSession
        {
            get { return GetRelatedEntity<msdyn_PostRuleConfig>("msdyn_postruleconfig_ProcessSession", null); }
            set
            {
                OnPropertyChanging("msdyn_postruleconfig_ProcessSession");
                SetRelatedEntity("msdyn_postruleconfig_ProcessSession", null, value);
                OnPropertyChanged("msdyn_postruleconfig_ProcessSession");
            }
        }

        /// <summary>
        ///     N:1 msdyn_wallsavedquery_ProcessSession
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("msdyn_wallsavedquery_ProcessSession")]
        public msdyn_wallsavedquery msdyn_wallsavedquery_ProcessSession
        {
            get { return GetRelatedEntity<msdyn_wallsavedquery>("msdyn_wallsavedquery_ProcessSession", null); }
            set
            {
                OnPropertyChanging("msdyn_wallsavedquery_ProcessSession");
                SetRelatedEntity("msdyn_wallsavedquery_ProcessSession", null, value);
                OnPropertyChanged("msdyn_wallsavedquery_ProcessSession");
            }
        }

        /// <summary>
        ///     N:1 msdyn_wallsavedqueryusersettings_ProcessSession
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("msdyn_wallsavedqueryusersettings_ProcessSession")]
        public msdyn_wallsavedqueryusersettings msdyn_wallsavedqueryusersettings_ProcessSession
        {
            get
            {
                return
                    GetRelatedEntity<msdyn_wallsavedqueryusersettings>(
                        "msdyn_wallsavedqueryusersettings_ProcessSession", null);
            }
            set
            {
                OnPropertyChanging("msdyn_wallsavedqueryusersettings_ProcessSession");
                SetRelatedEntity("msdyn_wallsavedqueryusersettings_ProcessSession", null, value);
                OnPropertyChanged("msdyn_wallsavedqueryusersettings_ProcessSession");
            }
        }

        /// <summary>
        ///     N:1 Opportunity_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Opportunity_ProcessSessions")]
        public Opportunity Opportunity_ProcessSessions
        {
            get { return GetRelatedEntity<Opportunity>("Opportunity_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Opportunity_ProcessSessions");
                SetRelatedEntity("Opportunity_ProcessSessions", null, value);
                OnPropertyChanged("Opportunity_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 OpportunityProduct_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("OpportunityProduct_ProcessSessions")]
        public OpportunityProduct OpportunityProduct_ProcessSessions
        {
            get { return GetRelatedEntity<OpportunityProduct>("OpportunityProduct_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("OpportunityProduct_ProcessSessions");
                SetRelatedEntity("OpportunityProduct_ProcessSessions", null, value);
                OnPropertyChanged("OpportunityProduct_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 Owning_businessunit_processsessions
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("Owning_businessunit_processsessions")]
        public BusinessUnit Owning_businessunit_processsessions
        {
            get { return GetRelatedEntity<BusinessUnit>("Owning_businessunit_processsessions", null); }
        }

        /// <summary>
        ///     N:1 PhoneCall_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("PhoneCall_ProcessSessions")]
        public PhoneCall PhoneCall_ProcessSessions
        {
            get { return GetRelatedEntity<PhoneCall>("PhoneCall_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("PhoneCall_ProcessSessions");
                SetRelatedEntity("PhoneCall_ProcessSessions", null, value);
                OnPropertyChanged("PhoneCall_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 PriceLevel_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("PriceLevel_ProcessSessions")]
        public PriceLevel PriceLevel_ProcessSessions
        {
            get { return GetRelatedEntity<PriceLevel>("PriceLevel_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("PriceLevel_ProcessSessions");
                SetRelatedEntity("PriceLevel_ProcessSessions", null, value);
                OnPropertyChanged("PriceLevel_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 Product_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Product_ProcessSessions")]
        public Product Product_ProcessSessions
        {
            get { return GetRelatedEntity<Product>("Product_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Product_ProcessSessions");
                SetRelatedEntity("Product_ProcessSessions", null, value);
                OnPropertyChanged("Product_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 ProductPriceLevel_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("ProductPriceLevel_ProcessSessions")]
        public ProductPriceLevel ProductPriceLevel_ProcessSessions
        {
            get { return GetRelatedEntity<ProductPriceLevel>("ProductPriceLevel_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("ProductPriceLevel_ProcessSessions");
                SetRelatedEntity("ProductPriceLevel_ProcessSessions", null, value);
                OnPropertyChanged("ProductPriceLevel_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 Queue_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Queue_ProcessSessions")]
        public Queue Queue_ProcessSessions
        {
            get { return GetRelatedEntity<Queue>("Queue_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Queue_ProcessSessions");
                SetRelatedEntity("Queue_ProcessSessions", null, value);
                OnPropertyChanged("Queue_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 QueueItem_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("QueueItem_ProcessSessions")]
        public QueueItem QueueItem_ProcessSessions
        {
            get { return GetRelatedEntity<QueueItem>("QueueItem_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("QueueItem_ProcessSessions");
                SetRelatedEntity("QueueItem_ProcessSessions", null, value);
                OnPropertyChanged("QueueItem_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 Quote_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Quote_ProcessSessions")]
        public Quote Quote_ProcessSessions
        {
            get { return GetRelatedEntity<Quote>("Quote_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Quote_ProcessSessions");
                SetRelatedEntity("Quote_ProcessSessions", null, value);
                OnPropertyChanged("Quote_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 QuoteDetail_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("QuoteDetail_ProcessSessions")]
        public QuoteDetail QuoteDetail_ProcessSessions
        {
            get { return GetRelatedEntity<QuoteDetail>("QuoteDetail_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("QuoteDetail_ProcessSessions");
                SetRelatedEntity("QuoteDetail_ProcessSessions", null, value);
                OnPropertyChanged("QuoteDetail_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 RecurringAppointmentMaster_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("RecurringAppointmentMaster_ProcessSessions")]
        public RecurringAppointmentMaster RecurringAppointmentMaster_ProcessSessions
        {
            get
            {
                return GetRelatedEntity<RecurringAppointmentMaster>("RecurringAppointmentMaster_ProcessSessions", null);
            }
            set
            {
                OnPropertyChanging("RecurringAppointmentMaster_ProcessSessions");
                SetRelatedEntity("RecurringAppointmentMaster_ProcessSessions", null, value);
                OnPropertyChanged("RecurringAppointmentMaster_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 RelationshipRole_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("RelationshipRole_ProcessSessions")]
        public RelationshipRole RelationshipRole_ProcessSessions
        {
            get { return GetRelatedEntity<RelationshipRole>("RelationshipRole_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("RelationshipRole_ProcessSessions");
                SetRelatedEntity("RelationshipRole_ProcessSessions", null, value);
                OnPropertyChanged("RelationshipRole_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 Report_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Report_ProcessSessions")]
        public Report Report_ProcessSessions
        {
            get { return GetRelatedEntity<Report>("Report_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Report_ProcessSessions");
                SetRelatedEntity("Report_ProcessSessions", null, value);
                OnPropertyChanged("Report_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 rollupfield_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("rollupfield_ProcessSessions")]
        public RollupField rollupfield_ProcessSessions
        {
            get { return GetRelatedEntity<RollupField>("rollupfield_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("rollupfield_ProcessSessions");
                SetRelatedEntity("rollupfield_ProcessSessions", null, value);
                OnPropertyChanged("rollupfield_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 SalesLiterature_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SalesLiterature_ProcessSessions")]
        public SalesLiterature SalesLiterature_ProcessSessions
        {
            get { return GetRelatedEntity<SalesLiterature>("SalesLiterature_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("SalesLiterature_ProcessSessions");
                SetRelatedEntity("SalesLiterature_ProcessSessions", null, value);
                OnPropertyChanged("SalesLiterature_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 SalesLiteratureItem_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SalesLiteratureItem_ProcessSessions")]
        public SalesLiteratureItem SalesLiteratureItem_ProcessSessions
        {
            get { return GetRelatedEntity<SalesLiteratureItem>("SalesLiteratureItem_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("SalesLiteratureItem_ProcessSessions");
                SetRelatedEntity("SalesLiteratureItem_ProcessSessions", null, value);
                OnPropertyChanged("SalesLiteratureItem_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 SalesOrder_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SalesOrder_ProcessSessions")]
        public SalesOrder SalesOrder_ProcessSessions
        {
            get { return GetRelatedEntity<SalesOrder>("SalesOrder_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("SalesOrder_ProcessSessions");
                SetRelatedEntity("SalesOrder_ProcessSessions", null, value);
                OnPropertyChanged("SalesOrder_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 SalesOrderDetail_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SalesOrderDetail_ProcessSessions")]
        public SalesOrderDetail SalesOrderDetail_ProcessSessions
        {
            get { return GetRelatedEntity<SalesOrderDetail>("SalesOrderDetail_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("SalesOrderDetail_ProcessSessions");
                SetRelatedEntity("SalesOrderDetail_ProcessSessions", null, value);
                OnPropertyChanged("SalesOrderDetail_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 Service_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Service_ProcessSessions")]
        public Service Service_ProcessSessions
        {
            get { return GetRelatedEntity<Service>("Service_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Service_ProcessSessions");
                SetRelatedEntity("Service_ProcessSessions", null, value);
                OnPropertyChanged("Service_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 ServiceAppointment_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("ServiceAppointment_ProcessSessions")]
        public ServiceAppointment ServiceAppointment_ProcessSessions
        {
            get { return GetRelatedEntity<ServiceAppointment>("ServiceAppointment_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("ServiceAppointment_ProcessSessions");
                SetRelatedEntity("ServiceAppointment_ProcessSessions", null, value);
                OnPropertyChanged("ServiceAppointment_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 SharePointDocumentLocation_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SharePointDocumentLocation_ProcessSessions")]
        public SharePointDocumentLocation SharePointDocumentLocation_ProcessSessions
        {
            get
            {
                return GetRelatedEntity<SharePointDocumentLocation>("SharePointDocumentLocation_ProcessSessions", null);
            }
            set
            {
                OnPropertyChanging("SharePointDocumentLocation_ProcessSessions");
                SetRelatedEntity("SharePointDocumentLocation_ProcessSessions", null, value);
                OnPropertyChanged("SharePointDocumentLocation_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 SharePointSite_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SharePointSite_ProcessSessions")]
        public SharePointSite SharePointSite_ProcessSessions
        {
            get { return GetRelatedEntity<SharePointSite>("SharePointSite_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("SharePointSite_ProcessSessions");
                SetRelatedEntity("SharePointSite_ProcessSessions", null, value);
                OnPropertyChanged("SharePointSite_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 Site_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Site_ProcessSessions")]
        public Site Site_ProcessSessions
        {
            get { return GetRelatedEntity<Site>("Site_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Site_ProcessSessions");
                SetRelatedEntity("Site_ProcessSessions", null, value);
                OnPropertyChanged("Site_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 Subject_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Subject_ProcessSessions")]
        public Subject Subject_ProcessSessions
        {
            get { return GetRelatedEntity<Subject>("Subject_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Subject_ProcessSessions");
                SetRelatedEntity("Subject_ProcessSessions", null, value);
                OnPropertyChanged("Subject_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 SystemUser_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SystemUser_ProcessSessions")]
        public SystemUser SystemUser_ProcessSessions
        {
            get { return GetRelatedEntity<SystemUser>("SystemUser_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("SystemUser_ProcessSessions");
                SetRelatedEntity("SystemUser_ProcessSessions", null, value);
                OnPropertyChanged("SystemUser_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 Task_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Task_ProcessSessions")]
        public Task Task_ProcessSessions
        {
            get { return GetRelatedEntity<Task>("Task_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Task_ProcessSessions");
                SetRelatedEntity("Task_ProcessSessions", null, value);
                OnPropertyChanged("Task_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 team_processsession
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_processsession")]
        public Team team_processsession
        {
            get { return GetRelatedEntity<Team>("team_processsession", null); }
        }

        /// <summary>
        ///     N:1 Team_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Team_ProcessSessions")]
        public Team Team_ProcessSessions
        {
            get { return GetRelatedEntity<Team>("Team_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Team_ProcessSessions");
                SetRelatedEntity("Team_ProcessSessions", null, value);
                OnPropertyChanged("Team_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 Template_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Template_ProcessSessions")]
        public Template Template_ProcessSessions
        {
            get { return GetRelatedEntity<Template>("Template_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Template_ProcessSessions");
                SetRelatedEntity("Template_ProcessSessions", null, value);
                OnPropertyChanged("Template_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 Territory_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Territory_ProcessSessions")]
        public Territory Territory_ProcessSessions
        {
            get { return GetRelatedEntity<Territory>("Territory_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Territory_ProcessSessions");
                SetRelatedEntity("Territory_ProcessSessions", null, value);
                OnPropertyChanged("Territory_ProcessSessions");
            }
        }

        /// <summary>
        ///     N:1 TransactionCurrency_ProcessSessions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("TransactionCurrency_ProcessSessions")]
        public TransactionCurrency TransactionCurrency_ProcessSessions
        {
            get { return GetRelatedEntity<TransactionCurrency>("TransactionCurrency_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_ProcessSessions");
                SetRelatedEntity("TransactionCurrency_ProcessSessions", null, value);
                OnPropertyChanged("TransactionCurrency_ProcessSessions");
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