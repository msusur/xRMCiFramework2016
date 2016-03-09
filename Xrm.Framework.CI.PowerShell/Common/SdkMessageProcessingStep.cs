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
    ///     Stage in the execution pipeline that a plug-in is to execute.
    /// </summary>
    [DataContract]
    [EntityLogicalName("sdkmessageprocessingstep")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class SdkMessageProcessingStep : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "sdkmessageprocessingstep";

        public const int EntityTypeCode = 4608;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public SdkMessageProcessingStep() :
            base(EntityLogicalName)
        {
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
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("componentstate")]
        public OptionSetValue ComponentState
        {
            get { return GetAttributeValue<OptionSetValue>("componentstate"); }
        }

        /// <summary>
        ///     Step-specific configuration for the plug-in type. Passed to the plug-in constructor at run time.
        /// </summary>
        [AttributeLogicalName("configuration")]
        public string Configuration
        {
            get { return GetAttributeValue<string>("configuration"); }
            set
            {
                OnPropertyChanging("Configuration");
                SetAttributeValue("configuration", value);
                OnPropertyChanged("Configuration");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the SDK message processing step.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the SDK message processing step was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the sdkmessageprocessingstep.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Customization level of the SDK message processing step.
        /// </summary>
        [AttributeLogicalName("customizationlevel")]
        public int? CustomizationLevel
        {
            get { return GetAttributeValue<int?>("customizationlevel"); }
        }

        /// <summary>
        ///     Description of the SDK message processing step.
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
        ///     Unique identifier of the associated event handler.
        /// </summary>
        [AttributeLogicalName("eventhandler")]
        public EntityReference EventHandler
        {
            get { return GetAttributeValue<EntityReference>("eventhandler"); }
            set
            {
                OnPropertyChanging("EventHandler");
                SetAttributeValue("eventhandler", value);
                OnPropertyChanged("EventHandler");
            }
        }

        /// <summary>
        ///     Comma-separated list of attributes. If at least one of these attributes is modified, the plug-in should execute.
        /// </summary>
        [AttributeLogicalName("filteringattributes")]
        public string FilteringAttributes
        {
            get { return GetAttributeValue<string>("filteringattributes"); }
            set
            {
                OnPropertyChanging("FilteringAttributes");
                SetAttributeValue("filteringattributes", value);
                OnPropertyChanged("FilteringAttributes");
            }
        }

        /// <summary>
        ///     Unique identifier of the user to impersonate context when step is executed.
        /// </summary>
        [AttributeLogicalName("impersonatinguserid")]
        public EntityReference ImpersonatingUserId
        {
            get { return GetAttributeValue<EntityReference>("impersonatinguserid"); }
            set
            {
                OnPropertyChanging("ImpersonatingUserId");
                SetAttributeValue("impersonatinguserid", value);
                OnPropertyChanged("ImpersonatingUserId");
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
        ///     Identifies if a plug-in should be executed from a parent pipeline, a child pipeline, or both.
        /// </summary>
        [AttributeLogicalName("invocationsource")]
        [Obsolete]
        public OptionSetValue InvocationSource
        {
            get { return GetAttributeValue<OptionSetValue>("invocationsource"); }
            set
            {
                OnPropertyChanging("InvocationSource");
                SetAttributeValue("invocationsource", value);
                OnPropertyChanged("InvocationSource");
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
        ///     Information that specifies whether this component should be hidden.
        /// </summary>
        [AttributeLogicalName("ishidden")]
        public BooleanManagedProperty IsHidden
        {
            get { return GetAttributeValue<BooleanManagedProperty>("ishidden"); }
            set
            {
                OnPropertyChanging("IsHidden");
                SetAttributeValue("ishidden", value);
                OnPropertyChanged("IsHidden");
            }
        }

        /// <summary>
        ///     Information that specifies whether this component is managed.
        /// </summary>
        [AttributeLogicalName("ismanaged")]
        public bool? IsManaged
        {
            get { return GetAttributeValue<bool?>("ismanaged"); }
        }

        /// <summary>
        ///     Run-time mode of execution, for example, synchronous or asynchronous.
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
        ///     Unique identifier of the user who last modified the SDK message processing step.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the SDK message processing step was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the sdkmessageprocessingstep.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of SdkMessage processing step.
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
        ///     Unique identifier of the organization with which the SDK message processing step is associated.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
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
        ///     Unique identifier of the plug-in type associated with the step.
        /// </summary>
        [AttributeLogicalName("plugintypeid")]
        [Obsolete]
        public EntityReference PluginTypeId
        {
            get { return GetAttributeValue<EntityReference>("plugintypeid"); }
            set
            {
                OnPropertyChanging("PluginTypeId");
                SetAttributeValue("plugintypeid", value);
                OnPropertyChanged("PluginTypeId");
            }
        }

        /// <summary>
        ///     Processing order within the stage.
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
        ///     Unique identifier of the SDK message filter.
        /// </summary>
        [AttributeLogicalName("sdkmessagefilterid")]
        public EntityReference SdkMessageFilterId
        {
            get { return GetAttributeValue<EntityReference>("sdkmessagefilterid"); }
            set
            {
                OnPropertyChanging("SdkMessageFilterId");
                SetAttributeValue("sdkmessagefilterid", value);
                OnPropertyChanged("SdkMessageFilterId");
            }
        }

        /// <summary>
        ///     Unique identifier of the SDK message.
        /// </summary>
        [AttributeLogicalName("sdkmessageid")]
        public EntityReference SdkMessageId
        {
            get { return GetAttributeValue<EntityReference>("sdkmessageid"); }
            set
            {
                OnPropertyChanging("SdkMessageId");
                SetAttributeValue("sdkmessageid", value);
                OnPropertyChanged("SdkMessageId");
            }
        }

        /// <summary>
        ///     Unique identifier of the SDK message processing step entity.
        /// </summary>
        [AttributeLogicalName("sdkmessageprocessingstepid")]
        public Guid? SdkMessageProcessingStepId
        {
            get { return GetAttributeValue<Guid?>("sdkmessageprocessingstepid"); }
            set
            {
                OnPropertyChanging("SdkMessageProcessingStepId");
                SetAttributeValue("sdkmessageprocessingstepid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("SdkMessageProcessingStepId");
            }
        }

        [AttributeLogicalName("sdkmessageprocessingstepid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { SdkMessageProcessingStepId = value; }
        }

        /// <summary>
        ///     Unique identifier of the SDK message processing step.
        /// </summary>
        [AttributeLogicalName("sdkmessageprocessingstepidunique")]
        public Guid? SdkMessageProcessingStepIdUnique
        {
            get { return GetAttributeValue<Guid?>("sdkmessageprocessingstepidunique"); }
        }

        /// <summary>
        ///     Unique identifier of the Sdk message processing step secure configuration.
        /// </summary>
        [AttributeLogicalName("sdkmessageprocessingstepsecureconfigid")]
        public EntityReference SdkMessageProcessingStepSecureConfigId
        {
            get { return GetAttributeValue<EntityReference>("sdkmessageprocessingstepsecureconfigid"); }
            set
            {
                OnPropertyChanging("SdkMessageProcessingStepSecureConfigId");
                SetAttributeValue("sdkmessageprocessingstepsecureconfigid", value);
                OnPropertyChanged("SdkMessageProcessingStepSecureConfigId");
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
        ///     Stage in the execution pipeline that the SDK message processing step is in.
        /// </summary>
        [AttributeLogicalName("stage")]
        public OptionSetValue Stage
        {
            get { return GetAttributeValue<OptionSetValue>("stage"); }
            set
            {
                OnPropertyChanging("Stage");
                SetAttributeValue("stage", value);
                OnPropertyChanged("Stage");
            }
        }

        /// <summary>
        ///     Status of the SDK message processing step.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public SdkMessageProcessingStepState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return
                        ((SdkMessageProcessingStepState)
                            (Enum.ToObject(typeof (SdkMessageProcessingStepState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the SDK message processing step.
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
        ///     Deployment that the SDK message processing step should be executed on; server, client, or both.
        /// </summary>
        [AttributeLogicalName("supporteddeployment")]
        public OptionSetValue SupportedDeployment
        {
            get { return GetAttributeValue<OptionSetValue>("supporteddeployment"); }
            set
            {
                OnPropertyChanging("SupportedDeployment");
                SetAttributeValue("supporteddeployment", value);
                OnPropertyChanged("SupportedDeployment");
            }
        }

        /// <summary>
        ///     Number that identifies a specific revision of the SDK message processing step.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N SdkMessageProcessingStep_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("SdkMessageProcessingStep_AsyncOperations")]
        public IEnumerable<AsyncOperation> SdkMessageProcessingStep_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("SdkMessageProcessingStep_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("SdkMessageProcessingStep_AsyncOperations");
                SetRelatedEntities("SdkMessageProcessingStep_AsyncOperations", null, value);
                OnPropertyChanged("SdkMessageProcessingStep_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N sdkmessageprocessingstepid_sdkmessageprocessingstepimage
        /// </summary>
        [RelationshipSchemaName("sdkmessageprocessingstepid_sdkmessageprocessingstepimage")]
        public IEnumerable<SdkMessageProcessingStepImage> sdkmessageprocessingstepid_sdkmessageprocessingstepimage
        {
            get
            {
                return
                    GetRelatedEntities<SdkMessageProcessingStepImage>(
                        "sdkmessageprocessingstepid_sdkmessageprocessingstepimage", null);
            }
            set
            {
                OnPropertyChanging("sdkmessageprocessingstepid_sdkmessageprocessingstepimage");
                SetRelatedEntities("sdkmessageprocessingstepid_sdkmessageprocessingstepimage", null, value);
                OnPropertyChanged("sdkmessageprocessingstepid_sdkmessageprocessingstepimage");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_sdkmessageprocessingstep
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_sdkmessageprocessingstep")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_sdkmessageprocessingstep
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_sdkmessageprocessingstep",
                    null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_sdkmessageprocessingstep");
                SetRelatedEntities("userentityinstancedata_sdkmessageprocessingstep", null, value);
                OnPropertyChanged("userentityinstancedata_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        ///     N:1 createdby_sdkmessageprocessingstep
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("createdby_sdkmessageprocessingstep")]
        public SystemUser createdby_sdkmessageprocessingstep
        {
            get { return GetRelatedEntity<SystemUser>("createdby_sdkmessageprocessingstep", null); }
        }

        /// <summary>
        ///     N:1 impersonatinguserid_sdkmessageprocessingstep
        /// </summary>
        [AttributeLogicalName("impersonatinguserid")]
        [RelationshipSchemaName("impersonatinguserid_sdkmessageprocessingstep")]
        public SystemUser impersonatinguserid_sdkmessageprocessingstep
        {
            get { return GetRelatedEntity<SystemUser>("impersonatinguserid_sdkmessageprocessingstep", null); }
            set
            {
                OnPropertyChanging("impersonatinguserid_sdkmessageprocessingstep");
                SetRelatedEntity("impersonatinguserid_sdkmessageprocessingstep", null, value);
                OnPropertyChanged("impersonatinguserid_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        ///     N:1 lk_sdkmessageprocessingstep_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_sdkmessageprocessingstep_createdonbehalfby")]
        public SystemUser lk_sdkmessageprocessingstep_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_sdkmessageprocessingstep_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_sdkmessageprocessingstep_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_sdkmessageprocessingstep_modifiedonbehalfby")]
        public SystemUser lk_sdkmessageprocessingstep_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_sdkmessageprocessingstep_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 modifiedby_sdkmessageprocessingstep
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("modifiedby_sdkmessageprocessingstep")]
        public SystemUser modifiedby_sdkmessageprocessingstep
        {
            get { return GetRelatedEntity<SystemUser>("modifiedby_sdkmessageprocessingstep", null); }
        }

        /// <summary>
        ///     N:1 organization_sdkmessageprocessingstep
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_sdkmessageprocessingstep")]
        public Organization organization_sdkmessageprocessingstep
        {
            get { return GetRelatedEntity<Organization>("organization_sdkmessageprocessingstep", null); }
        }

        /// <summary>
        ///     N:1 plugintype_sdkmessageprocessingstep
        /// </summary>
        [AttributeLogicalName("eventhandler")]
        [RelationshipSchemaName("plugintype_sdkmessageprocessingstep")]
        public PluginType plugintype_sdkmessageprocessingstep
        {
            get { return GetRelatedEntity<PluginType>("plugintype_sdkmessageprocessingstep", null); }
            set
            {
                OnPropertyChanging("plugintype_sdkmessageprocessingstep");
                SetRelatedEntity("plugintype_sdkmessageprocessingstep", null, value);
                OnPropertyChanged("plugintype_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        ///     N:1 plugintypeid_sdkmessageprocessingstep
        /// </summary>
        [AttributeLogicalName("plugintypeid")]
        [RelationshipSchemaName("plugintypeid_sdkmessageprocessingstep")]
        public PluginType plugintypeid_sdkmessageprocessingstep
        {
            get { return GetRelatedEntity<PluginType>("plugintypeid_sdkmessageprocessingstep", null); }
            set
            {
                OnPropertyChanging("plugintypeid_sdkmessageprocessingstep");
                SetRelatedEntity("plugintypeid_sdkmessageprocessingstep", null, value);
                OnPropertyChanged("plugintypeid_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        ///     N:1 sdkmessagefilterid_sdkmessageprocessingstep
        /// </summary>
        [AttributeLogicalName("sdkmessagefilterid")]
        [RelationshipSchemaName("sdkmessagefilterid_sdkmessageprocessingstep")]
        public SdkMessageFilter sdkmessagefilterid_sdkmessageprocessingstep
        {
            get { return GetRelatedEntity<SdkMessageFilter>("sdkmessagefilterid_sdkmessageprocessingstep", null); }
            set
            {
                OnPropertyChanging("sdkmessagefilterid_sdkmessageprocessingstep");
                SetRelatedEntity("sdkmessagefilterid_sdkmessageprocessingstep", null, value);
                OnPropertyChanged("sdkmessagefilterid_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        ///     N:1 sdkmessageid_sdkmessageprocessingstep
        /// </summary>
        [AttributeLogicalName("sdkmessageid")]
        [RelationshipSchemaName("sdkmessageid_sdkmessageprocessingstep")]
        public SdkMessage sdkmessageid_sdkmessageprocessingstep
        {
            get { return GetRelatedEntity<SdkMessage>("sdkmessageid_sdkmessageprocessingstep", null); }
            set
            {
                OnPropertyChanging("sdkmessageid_sdkmessageprocessingstep");
                SetRelatedEntity("sdkmessageid_sdkmessageprocessingstep", null, value);
                OnPropertyChanged("sdkmessageid_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        ///     N:1 sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep
        /// </summary>
        [AttributeLogicalName("sdkmessageprocessingstepsecureconfigid")]
        [RelationshipSchemaName("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep")]
        public SdkMessageProcessingStepSecureConfig sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep
        {
            get
            {
                return
                    GetRelatedEntity<SdkMessageProcessingStepSecureConfig>(
                        "sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep", null);
            }
            set
            {
                OnPropertyChanging("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep");
                SetRelatedEntity("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep", null, value);
                OnPropertyChanged("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        ///     N:1 serviceendpoint_sdkmessageprocessingstep
        /// </summary>
        [AttributeLogicalName("eventhandler")]
        [RelationshipSchemaName("serviceendpoint_sdkmessageprocessingstep")]
        public ServiceEndpoint serviceendpoint_sdkmessageprocessingstep
        {
            get { return GetRelatedEntity<ServiceEndpoint>("serviceendpoint_sdkmessageprocessingstep", null); }
            set
            {
                OnPropertyChanging("serviceendpoint_sdkmessageprocessingstep");
                SetRelatedEntity("serviceendpoint_sdkmessageprocessingstep", null, value);
                OnPropertyChanged("serviceendpoint_sdkmessageprocessingstep");
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