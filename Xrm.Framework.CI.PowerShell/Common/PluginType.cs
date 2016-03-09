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
    ///     Type that inherits from the IPlugin interface and is contained within a plug-in assembly.
    /// </summary>
    [DataContract]
    [EntityLogicalName("plugintype")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class PluginType : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "plugintype";

        public const int EntityTypeCode = 4602;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public PluginType() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Full path name of the plug-in assembly.
        /// </summary>
        [AttributeLogicalName("assemblyname")]
        public string AssemblyName
        {
            get { return GetAttributeValue<string>("assemblyname"); }
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
        ///     Unique identifier of the user who created the plug-in type.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the plug-in type was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the plugintype.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Culture code for the plug-in assembly.
        /// </summary>
        [AttributeLogicalName("culture")]
        public string Culture
        {
            get { return GetAttributeValue<string>("culture"); }
        }

        /// <summary>
        ///     Customization level of the plug-in type.
        /// </summary>
        [AttributeLogicalName("customizationlevel")]
        public int? CustomizationLevel
        {
            get { return GetAttributeValue<int?>("customizationlevel"); }
        }

        /// <summary>
        ///     Serialized Custom Activity Type information, including required arguments. For more information, see
        ///     SandboxCustomActivityInfo.
        /// </summary>
        [AttributeLogicalName("customworkflowactivityinfo")]
        public string CustomWorkflowActivityInfo
        {
            get { return GetAttributeValue<string>("customworkflowactivityinfo"); }
        }

        /// <summary>
        ///     Description of the plug-in type.
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
        ///     User friendly name for the plug-in.
        /// </summary>
        [AttributeLogicalName("friendlyname")]
        public string FriendlyName
        {
            get { return GetAttributeValue<string>("friendlyname"); }
            set
            {
                OnPropertyChanging("FriendlyName");
                SetAttributeValue("friendlyname", value);
                OnPropertyChanged("FriendlyName");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("ismanaged")]
        public bool? IsManaged
        {
            get { return GetAttributeValue<bool?>("ismanaged"); }
        }

        /// <summary>
        ///     Indicates if the plug-in is a custom activity for workflows.
        /// </summary>
        [AttributeLogicalName("isworkflowactivity")]
        public bool? IsWorkflowActivity
        {
            get { return GetAttributeValue<bool?>("isworkflowactivity"); }
        }

        /// <summary>
        ///     Major of the version number of the assembly for the plug-in type.
        /// </summary>
        [AttributeLogicalName("major")]
        public int? Major
        {
            get { return GetAttributeValue<int?>("major"); }
        }

        /// <summary>
        ///     Minor of the version number of the assembly for the plug-in type.
        /// </summary>
        [AttributeLogicalName("minor")]
        public int? Minor
        {
            get { return GetAttributeValue<int?>("minor"); }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the plug-in type.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the plug-in type was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the plugintype.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the plug-in type.
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
        ///     Unique identifier of the organization with which the plug-in type is associated.
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
        ///     Unique identifier of the plug-in assembly that contains this plug-in type.
        /// </summary>
        [AttributeLogicalName("pluginassemblyid")]
        public EntityReference PluginAssemblyId
        {
            get { return GetAttributeValue<EntityReference>("pluginassemblyid"); }
            set
            {
                OnPropertyChanging("PluginAssemblyId");
                SetAttributeValue("pluginassemblyid", value);
                OnPropertyChanged("PluginAssemblyId");
            }
        }

        /// <summary>
        ///     Unique identifier of the plug-in type.
        /// </summary>
        [AttributeLogicalName("plugintypeid")]
        public Guid? PluginTypeId
        {
            get { return GetAttributeValue<Guid?>("plugintypeid"); }
            set
            {
                OnPropertyChanging("PluginTypeId");
                SetAttributeValue("plugintypeid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("PluginTypeId");
            }
        }

        [AttributeLogicalName("plugintypeid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { PluginTypeId = value; }
        }

        /// <summary>
        ///     Unique identifier of the plug-in type.
        /// </summary>
        [AttributeLogicalName("plugintypeidunique")]
        public Guid? PluginTypeIdUnique
        {
            get { return GetAttributeValue<Guid?>("plugintypeidunique"); }
        }

        /// <summary>
        ///     Public key token of the assembly for the plug-in type.
        /// </summary>
        [AttributeLogicalName("publickeytoken")]
        public string PublicKeyToken
        {
            get { return GetAttributeValue<string>("publickeytoken"); }
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
        ///     Fully qualified type name of the plug-in type.
        /// </summary>
        [AttributeLogicalName("typename")]
        public string TypeName
        {
            get { return GetAttributeValue<string>("typename"); }
            set
            {
                OnPropertyChanging("TypeName");
                SetAttributeValue("typename", value);
                OnPropertyChanged("TypeName");
            }
        }

        /// <summary>
        ///     Version number of the assembly for the plug-in type.
        /// </summary>
        [AttributeLogicalName("version")]
        public string Version
        {
            get { return GetAttributeValue<string>("version"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     Group name of workflow custom activity.
        /// </summary>
        [AttributeLogicalName("workflowactivitygroupname")]
        public string WorkflowActivityGroupName
        {
            get { return GetAttributeValue<string>("workflowactivitygroupname"); }
            set
            {
                OnPropertyChanging("WorkflowActivityGroupName");
                SetAttributeValue("workflowactivitygroupname", value);
                OnPropertyChanged("WorkflowActivityGroupName");
            }
        }

        /// <summary>
        ///     1:N plugin_type_service
        /// </summary>
        [RelationshipSchemaName("plugin_type_service")]
        public IEnumerable<Service> plugin_type_service
        {
            get { return GetRelatedEntities<Service>("plugin_type_service", null); }
            set
            {
                OnPropertyChanging("plugin_type_service");
                SetRelatedEntities("plugin_type_service", null, value);
                OnPropertyChanged("plugin_type_service");
            }
        }

        /// <summary>
        ///     1:N plugintype_plugintypestatistic
        /// </summary>
        [RelationshipSchemaName("plugintype_plugintypestatistic")]
        public IEnumerable<PluginTypeStatistic> plugintype_plugintypestatistic
        {
            get { return GetRelatedEntities<PluginTypeStatistic>("plugintype_plugintypestatistic", null); }
            set
            {
                OnPropertyChanging("plugintype_plugintypestatistic");
                SetRelatedEntities("plugintype_plugintypestatistic", null, value);
                OnPropertyChanged("plugintype_plugintypestatistic");
            }
        }

        /// <summary>
        ///     1:N plugintype_sdkmessageprocessingstep
        /// </summary>
        [RelationshipSchemaName("plugintype_sdkmessageprocessingstep")]
        public IEnumerable<SdkMessageProcessingStep> plugintype_sdkmessageprocessingstep
        {
            get { return GetRelatedEntities<SdkMessageProcessingStep>("plugintype_sdkmessageprocessingstep", null); }
            set
            {
                OnPropertyChanging("plugintype_sdkmessageprocessingstep");
                SetRelatedEntities("plugintype_sdkmessageprocessingstep", null, value);
                OnPropertyChanged("plugintype_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        ///     1:N plugintypeid_sdkmessageprocessingstep
        /// </summary>
        [RelationshipSchemaName("plugintypeid_sdkmessageprocessingstep")]
        public IEnumerable<SdkMessageProcessingStep> plugintypeid_sdkmessageprocessingstep
        {
            get { return GetRelatedEntities<SdkMessageProcessingStep>("plugintypeid_sdkmessageprocessingstep", null); }
            set
            {
                OnPropertyChanging("plugintypeid_sdkmessageprocessingstep");
                SetRelatedEntities("plugintypeid_sdkmessageprocessingstep", null, value);
                OnPropertyChanged("plugintypeid_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_plugintype
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_plugintype")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_plugintype
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_plugintype", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_plugintype");
                SetRelatedEntities("userentityinstancedata_plugintype", null, value);
                OnPropertyChanged("userentityinstancedata_plugintype");
            }
        }

        /// <summary>
        ///     N:1 createdby_plugintype
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("createdby_plugintype")]
        public SystemUser createdby_plugintype
        {
            get { return GetRelatedEntity<SystemUser>("createdby_plugintype", null); }
        }

        /// <summary>
        ///     N:1 lk_plugintype_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_plugintype_createdonbehalfby")]
        public SystemUser lk_plugintype_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_plugintype_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_plugintype_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_plugintype_modifiedonbehalfby")]
        public SystemUser lk_plugintype_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_plugintype_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 modifiedby_plugintype
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("modifiedby_plugintype")]
        public SystemUser modifiedby_plugintype
        {
            get { return GetRelatedEntity<SystemUser>("modifiedby_plugintype", null); }
        }

        /// <summary>
        ///     N:1 organization_plugintype
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_plugintype")]
        public Organization organization_plugintype
        {
            get { return GetRelatedEntity<Organization>("organization_plugintype", null); }
        }

        /// <summary>
        ///     N:1 pluginassembly_plugintype
        /// </summary>
        [AttributeLogicalName("pluginassemblyid")]
        [RelationshipSchemaName("pluginassembly_plugintype")]
        public PluginAssembly pluginassembly_plugintype
        {
            get { return GetRelatedEntity<PluginAssembly>("pluginassembly_plugintype", null); }
            set
            {
                OnPropertyChanging("pluginassembly_plugintype");
                SetRelatedEntity("pluginassembly_plugintype", null, value);
                OnPropertyChanged("pluginassembly_plugintype");
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