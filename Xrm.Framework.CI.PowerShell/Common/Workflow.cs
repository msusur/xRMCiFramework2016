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
    ///     Set of logical rules that define the steps necessary to automate a specific business process, task, or set of
    ///     actions to be performed.
    /// </summary>
    [DataContract]
    [EntityLogicalName("workflow")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Workflow : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "workflow";

        public const int EntityTypeCode = 4703;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Workflow() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the latest activation record for the process.
        /// </summary>
        [AttributeLogicalName("activeworkflowid")]
        public EntityReference ActiveWorkflowId
        {
            get { return GetAttributeValue<EntityReference>("activeworkflowid"); }
        }

        /// <summary>
        ///     Indicates whether the asynchronous system job is automatically deleted on completion.
        /// </summary>
        [AttributeLogicalName("asyncautodelete")]
        public bool? AsyncAutoDelete
        {
            get { return GetAttributeValue<bool?>("asyncautodelete"); }
            set
            {
                OnPropertyChanging("AsyncAutoDelete");
                SetAttributeValue("asyncautodelete", value);
                OnPropertyChanged("AsyncAutoDelete");
            }
        }

        /// <summary>
        ///     Category of the process.
        /// </summary>
        [AttributeLogicalName("category")]
        public OptionSetValue Category
        {
            get { return GetAttributeValue<OptionSetValue>("category"); }
            set
            {
                OnPropertyChanging("Category");
                SetAttributeValue("category", value);
                OnPropertyChanged("Category");
            }
        }

        /// <summary>
        ///     Business logic converted into client data
        /// </summary>
        [AttributeLogicalName("clientdata")]
        public string ClientData
        {
            get { return GetAttributeValue<string>("clientdata"); }
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
        ///     Unique identifier of the user who created the process.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the process was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the process.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Stage of the process when triggered on Create.
        /// </summary>
        [AttributeLogicalName("createstage")]
        public OptionSetValue CreateStage
        {
            get { return GetAttributeValue<OptionSetValue>("createstage"); }
            set
            {
                OnPropertyChanging("CreateStage");
                SetAttributeValue("createstage", value);
                OnPropertyChanged("CreateStage");
            }
        }

        /// <summary>
        ///     Stage of the process when triggered on Delete.
        /// </summary>
        [AttributeLogicalName("deletestage")]
        public OptionSetValue DeleteStage
        {
            get { return GetAttributeValue<OptionSetValue>("deletestage"); }
            set
            {
                OnPropertyChanging("DeleteStage");
                SetAttributeValue("deletestage", value);
                OnPropertyChanged("DeleteStage");
            }
        }

        /// <summary>
        ///     Description of the process.
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
        ///     Input parameters to the process.
        /// </summary>
        [AttributeLogicalName("inputparameters")]
        public string InputParameters
        {
            get { return GetAttributeValue<string>("inputparameters"); }
            set
            {
                OnPropertyChanging("InputParameters");
                SetAttributeValue("inputparameters", value);
                OnPropertyChanged("InputParameters");
            }
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
        ///     Indicates whether the process was created using the Microsoft Dynamics CRM Web application.
        /// </summary>
        [AttributeLogicalName("iscrmuiworkflow")]
        public bool? IsCrmUIWorkflow
        {
            get { return GetAttributeValue<bool?>("iscrmuiworkflow"); }
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
        ///     Indicates whether the solution component is part of a managed solution.
        /// </summary>
        [AttributeLogicalName("ismanaged")]
        public bool? IsManaged
        {
            get { return GetAttributeValue<bool?>("ismanaged"); }
        }

        /// <summary>
        ///     Indicates whether the custom operation is automatically transacted.
        /// </summary>
        [AttributeLogicalName("istransacted")]
        public bool? IsTransacted
        {
            get { return GetAttributeValue<bool?>("istransacted"); }
            set
            {
                OnPropertyChanging("IsTransacted");
                SetAttributeValue("istransacted", value);
                OnPropertyChanged("IsTransacted");
            }
        }

        /// <summary>
        ///     Language of the process.
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
        ///     Shows the mode of the process.
        /// </summary>
        [AttributeLogicalName("mode")]
        public OptionSetValue Mode
        {
            get { return GetAttributeValue<OptionSetValue>("mode"); }
            set
            {
                OnPropertyChanging("Mode");
                SetAttributeValue("mode", value);
                OnPropertyChanged("Mode");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the process.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the process was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the process.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the process.
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
        ///     Indicates whether the process is able to run as an on-demand process.
        /// </summary>
        [AttributeLogicalName("ondemand")]
        public bool? OnDemand
        {
            get { return GetAttributeValue<bool?>("ondemand"); }
            set
            {
                OnPropertyChanging("OnDemand");
                SetAttributeValue("ondemand", value);
                OnPropertyChanged("OnDemand");
            }
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
        ///     Unique identifier of the user or team who owns the process.
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
        ///     Unique identifier of the business unit that owns the process.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the process.
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
        ///     Unique identifier of the definition for process activation.
        /// </summary>
        [AttributeLogicalName("parentworkflowid")]
        public EntityReference ParentWorkflowId
        {
            get { return GetAttributeValue<EntityReference>("parentworkflowid"); }
        }

        /// <summary>
        ///     Unique identifier of the plug-in type.
        /// </summary>
        [AttributeLogicalName("plugintypeid")]
        public EntityReference PluginTypeId
        {
            get { return GetAttributeValue<EntityReference>("plugintypeid"); }
        }

        /// <summary>
        ///     Primary entity for the process. The process can be associated for one or more SDK operations defined on the primary
        ///     entity.
        /// </summary>
        [AttributeLogicalName("primaryentity")]
        public string PrimaryEntity
        {
            get { return GetAttributeValue<string>("primaryentity"); }
            set
            {
                OnPropertyChanging("PrimaryEntity");
                SetAttributeValue("primaryentity", value);
                OnPropertyChanged("PrimaryEntity");
            }
        }

        /// <summary>
        ///     Type the business process flow order.
        /// </summary>
        [AttributeLogicalName("processorder")]
        public int? ProcessOrder
        {
            get { return GetAttributeValue<int?>("processorder"); }
            set
            {
                OnPropertyChanging("ProcessOrder");
                SetAttributeValue("processorder", value);
                OnPropertyChanged("ProcessOrder");
            }
        }

        /// <summary>
        ///     Contains the role assignment for the process.
        /// </summary>
        [AttributeLogicalName("processroleassignment")]
        public string ProcessRoleAssignment
        {
            get { return GetAttributeValue<string>("processroleassignment"); }
            set
            {
                OnPropertyChanging("ProcessRoleAssignment");
                SetAttributeValue("processroleassignment", value);
                OnPropertyChanged("ProcessRoleAssignment");
            }
        }

        /// <summary>
        ///     Indicates the rank for order of execution for the synchronous workflow.
        /// </summary>
        [AttributeLogicalName("rank")]
        public int? Rank
        {
            get { return GetAttributeValue<int?>("rank"); }
            set
            {
                OnPropertyChanging("Rank");
                SetAttributeValue("rank", value);
                OnPropertyChanged("Rank");
            }
        }

        /// <summary>
        ///     Specifies the system user account under which a workflow executes.
        /// </summary>
        [AttributeLogicalName("runas")]
        public OptionSetValue RunAs
        {
            get { return GetAttributeValue<OptionSetValue>("runas"); }
            set
            {
                OnPropertyChanging("RunAs");
                SetAttributeValue("runas", value);
                OnPropertyChanged("RunAs");
            }
        }

        /// <summary>
        ///     Scope of the process.
        /// </summary>
        [AttributeLogicalName("scope")]
        public OptionSetValue Scope
        {
            get { return GetAttributeValue<OptionSetValue>("scope"); }
            set
            {
                OnPropertyChanging("Scope");
                SetAttributeValue("scope", value);
                OnPropertyChanged("Scope");
            }
        }

        /// <summary>
        ///     Unique identifier of the SDK Message associated with this workflow.
        /// </summary>
        [AttributeLogicalName("sdkmessageid")]
        public EntityReference SdkMessageId
        {
            get { return GetAttributeValue<EntityReference>("sdkmessageid"); }
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
        ///     Status of the process.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public WorkflowState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((WorkflowState) (Enum.ToObject(typeof (WorkflowState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Additional information about status of the process.
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
        ///     Indicates whether the process can be included in other processes as a child process.
        /// </summary>
        [AttributeLogicalName("subprocess")]
        public bool? Subprocess
        {
            get { return GetAttributeValue<bool?>("subprocess"); }
            set
            {
                OnPropertyChanging("Subprocess");
                SetAttributeValue("subprocess", value);
                OnPropertyChanged("Subprocess");
            }
        }

        /// <summary>
        ///     Select whether synchronous workflow failures will be saved to log files.
        /// </summary>
        [AttributeLogicalName("syncworkflowlogonfailure")]
        public bool? SyncWorkflowLogOnFailure
        {
            get { return GetAttributeValue<bool?>("syncworkflowlogonfailure"); }
            set
            {
                OnPropertyChanging("SyncWorkflowLogOnFailure");
                SetAttributeValue("syncworkflowlogonfailure", value);
                OnPropertyChanged("SyncWorkflowLogOnFailure");
            }
        }

        /// <summary>
        ///     Indicates whether the process will be triggered when the primary entity is created.
        /// </summary>
        [AttributeLogicalName("triggeroncreate")]
        public bool? TriggerOnCreate
        {
            get { return GetAttributeValue<bool?>("triggeroncreate"); }
            set
            {
                OnPropertyChanging("TriggerOnCreate");
                SetAttributeValue("triggeroncreate", value);
                OnPropertyChanged("TriggerOnCreate");
            }
        }

        /// <summary>
        ///     Indicates whether the process will be triggered on deletion of the primary entity.
        /// </summary>
        [AttributeLogicalName("triggerondelete")]
        public bool? TriggerOnDelete
        {
            get { return GetAttributeValue<bool?>("triggerondelete"); }
            set
            {
                OnPropertyChanging("TriggerOnDelete");
                SetAttributeValue("triggerondelete", value);
                OnPropertyChanged("TriggerOnDelete");
            }
        }

        /// <summary>
        ///     Attributes that trigger the process when updated.
        /// </summary>
        [AttributeLogicalName("triggeronupdateattributelist")]
        public string TriggerOnUpdateAttributeList
        {
            get { return GetAttributeValue<string>("triggeronupdateattributelist"); }
            set
            {
                OnPropertyChanging("TriggerOnUpdateAttributeList");
                SetAttributeValue("triggeronupdateattributelist", value);
                OnPropertyChanged("TriggerOnUpdateAttributeList");
            }
        }

        /// <summary>
        ///     Type of the process.
        /// </summary>
        [AttributeLogicalName("type")]
        public OptionSetValue Type
        {
            get { return GetAttributeValue<OptionSetValue>("type"); }
            set
            {
                OnPropertyChanging("Type");
                SetAttributeValue("type", value);
                OnPropertyChanged("Type");
            }
        }

        /// <summary>
        ///     Type a name for the custom operation.
        /// </summary>
        [AttributeLogicalName("uniquename")]
        public string UniqueName
        {
            get { return GetAttributeValue<string>("uniquename"); }
            set
            {
                OnPropertyChanging("UniqueName");
                SetAttributeValue("uniquename", value);
                OnPropertyChanged("UniqueName");
            }
        }

        /// <summary>
        ///     Select the stage a process will be triggered on update.
        /// </summary>
        [AttributeLogicalName("updatestage")]
        public OptionSetValue UpdateStage
        {
            get { return GetAttributeValue<OptionSetValue>("updatestage"); }
            set
            {
                OnPropertyChanging("UpdateStage");
                SetAttributeValue("updatestage", value);
                OnPropertyChanged("UpdateStage");
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
        ///     Unique identifier of the process.
        /// </summary>
        [AttributeLogicalName("workflowid")]
        public Guid? WorkflowId
        {
            get { return GetAttributeValue<Guid?>("workflowid"); }
            set
            {
                OnPropertyChanging("WorkflowId");
                SetAttributeValue("workflowid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("WorkflowId");
            }
        }

        [AttributeLogicalName("workflowid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { WorkflowId = value; }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("workflowidunique")]
        public Guid? WorkflowIdUnique
        {
            get { return GetAttributeValue<Guid?>("workflowidunique"); }
        }

        /// <summary>
        ///     XAML that defines the process.
        /// </summary>
        [AttributeLogicalName("xaml")]
        public string Xaml
        {
            get { return GetAttributeValue<string>("xaml"); }
            set
            {
                OnPropertyChanging("Xaml");
                SetAttributeValue("xaml", value);
                OnPropertyChanged("Xaml");
            }
        }

        /// <summary>
        ///     1:N lk_asyncoperation_workflowactivationid
        /// </summary>
        [RelationshipSchemaName("lk_asyncoperation_workflowactivationid")]
        public IEnumerable<AsyncOperation> lk_asyncoperation_workflowactivationid
        {
            get { return GetRelatedEntities<AsyncOperation>("lk_asyncoperation_workflowactivationid", null); }
            set
            {
                OnPropertyChanging("lk_asyncoperation_workflowactivationid");
                SetRelatedEntities("lk_asyncoperation_workflowactivationid", null, value);
                OnPropertyChanged("lk_asyncoperation_workflowactivationid");
            }
        }

        /// <summary>
        ///     1:N lk_processsession_processid
        /// </summary>
        [RelationshipSchemaName("lk_processsession_processid")]
        public IEnumerable<ProcessSession> lk_processsession_processid
        {
            get { return GetRelatedEntities<ProcessSession>("lk_processsession_processid", null); }
            set
            {
                OnPropertyChanging("lk_processsession_processid");
                SetRelatedEntities("lk_processsession_processid", null, value);
                OnPropertyChanged("lk_processsession_processid");
            }
        }

        /// <summary>
        ///     1:N process_processstage
        /// </summary>
        [RelationshipSchemaName("process_processstage")]
        public IEnumerable<ProcessStage> process_processstage
        {
            get { return GetRelatedEntities<ProcessStage>("process_processstage", null); }
            set
            {
                OnPropertyChanging("process_processstage");
                SetRelatedEntities("process_processstage", null, value);
                OnPropertyChanged("process_processstage");
            }
        }

        /// <summary>
        ///     1:N process_processtrigger
        /// </summary>
        [RelationshipSchemaName("process_processtrigger")]
        public IEnumerable<ProcessTrigger> process_processtrigger
        {
            get { return GetRelatedEntities<ProcessTrigger>("process_processtrigger", null); }
            set
            {
                OnPropertyChanging("process_processtrigger");
                SetRelatedEntities("process_processtrigger", null, value);
                OnPropertyChanged("process_processtrigger");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_workflow
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_workflow")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_workflow
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_workflow", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_workflow");
                SetRelatedEntities("userentityinstancedata_workflow", null, value);
                OnPropertyChanged("userentityinstancedata_workflow");
            }
        }

        /// <summary>
        ///     1:N workflow_active_workflow
        /// </summary>
        [RelationshipSchemaName("workflow_active_workflow", EntityRole.Referenced)]
        public IEnumerable<Workflow> Referencedworkflow_active_workflow
        {
            get { return GetRelatedEntities<Workflow>("workflow_active_workflow", EntityRole.Referenced); }
            set
            {
                OnPropertyChanging("Referencedworkflow_active_workflow");
                SetRelatedEntities("workflow_active_workflow", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedworkflow_active_workflow");
            }
        }

        /// <summary>
        ///     1:N Workflow_Annotation
        /// </summary>
        [RelationshipSchemaName("Workflow_Annotation")]
        public IEnumerable<Annotation> Workflow_Annotation
        {
            get { return GetRelatedEntities<Annotation>("Workflow_Annotation", null); }
            set
            {
                OnPropertyChanging("Workflow_Annotation");
                SetRelatedEntities("Workflow_Annotation", null, value);
                OnPropertyChanged("Workflow_Annotation");
            }
        }

        /// <summary>
        ///     1:N workflow_dependencies
        /// </summary>
        [RelationshipSchemaName("workflow_dependencies")]
        public IEnumerable<WorkflowDependency> workflow_dependencies
        {
            get { return GetRelatedEntities<WorkflowDependency>("workflow_dependencies", null); }
            set
            {
                OnPropertyChanging("workflow_dependencies");
                SetRelatedEntities("workflow_dependencies", null, value);
                OnPropertyChanged("workflow_dependencies");
            }
        }

        /// <summary>
        ///     1:N workflow_parent_workflow
        /// </summary>
        [RelationshipSchemaName("workflow_parent_workflow", EntityRole.Referenced)]
        public IEnumerable<Workflow> Referencedworkflow_parent_workflow
        {
            get { return GetRelatedEntities<Workflow>("workflow_parent_workflow", EntityRole.Referenced); }
            set
            {
                OnPropertyChanging("Referencedworkflow_parent_workflow");
                SetRelatedEntities("workflow_parent_workflow", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedworkflow_parent_workflow");
            }
        }

        /// <summary>
        ///     N:1 business_unit_workflow
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_workflow")]
        public BusinessUnit business_unit_workflow
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_workflow", null); }
        }

        /// <summary>
        ///     N:1 system_user_workflow
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("system_user_workflow")]
        public SystemUser system_user_workflow
        {
            get { return GetRelatedEntity<SystemUser>("system_user_workflow", null); }
        }

        /// <summary>
        ///     N:1 team_workflow
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_workflow")]
        public Team team_workflow
        {
            get { return GetRelatedEntity<Team>("team_workflow", null); }
        }

        /// <summary>
        ///     N:1 workflow_active_workflow
        /// </summary>
        [AttributeLogicalName("activeworkflowid")]
        [RelationshipSchemaName("workflow_active_workflow", EntityRole.Referencing)]
        public Workflow Referencingworkflow_active_workflow
        {
            get { return GetRelatedEntity<Workflow>("workflow_active_workflow", EntityRole.Referencing); }
        }

        /// <summary>
        ///     N:1 workflow_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("workflow_createdby")]
        public SystemUser workflow_createdby
        {
            get { return GetRelatedEntity<SystemUser>("workflow_createdby", null); }
        }

        /// <summary>
        ///     N:1 workflow_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("workflow_createdonbehalfby")]
        public SystemUser workflow_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("workflow_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 workflow_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("workflow_modifiedby")]
        public SystemUser workflow_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("workflow_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 workflow_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("workflow_modifiedonbehalfby")]
        public SystemUser workflow_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("workflow_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 workflow_parent_workflow
        /// </summary>
        [AttributeLogicalName("parentworkflowid")]
        [RelationshipSchemaName("workflow_parent_workflow", EntityRole.Referencing)]
        public Workflow Referencingworkflow_parent_workflow
        {
            get { return GetRelatedEntity<Workflow>("workflow_parent_workflow", EntityRole.Referencing); }
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