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
    ///     Dependencies for a process.
    /// </summary>
    [DataContract]
    [EntityLogicalName("workflowdependency")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class WorkflowDependency : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "workflowdependency";

        public const int EntityTypeCode = 4704;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public WorkflowDependency() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the user who created the process dependency.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the process dependency was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the process dependency.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Name of the entity used in the process.
        /// </summary>
        [AttributeLogicalName("customentityname")]
        public string CustomEntityName
        {
            get { return GetAttributeValue<string>("customentityname"); }
            set
            {
                OnPropertyChanging("CustomEntityName");
                SetAttributeValue("customentityname", value);
                OnPropertyChanged("CustomEntityName");
            }
        }

        /// <summary>
        ///     Name of the attribute used in the process.
        /// </summary>
        [AttributeLogicalName("dependentattributename")]
        public string DependentAttributeName
        {
            get { return GetAttributeValue<string>("dependentattributename"); }
            set
            {
                OnPropertyChanging("DependentAttributeName");
                SetAttributeValue("dependentattributename", value);
                OnPropertyChanged("DependentAttributeName");
            }
        }

        /// <summary>
        ///     Name of the entity used in the process.
        /// </summary>
        [AttributeLogicalName("dependententityname")]
        public string DependentEntityName
        {
            get { return GetAttributeValue<string>("dependententityname"); }
            set
            {
                OnPropertyChanging("DependentEntityName");
                SetAttributeValue("dependententityname", value);
                OnPropertyChanged("DependentEntityName");
            }
        }

        /// <summary>
        ///     Comma-separated list of attributes that will be passed to process instance.
        /// </summary>
        [AttributeLogicalName("entityattributes")]
        public string EntityAttributes
        {
            get { return GetAttributeValue<string>("entityattributes"); }
            set
            {
                OnPropertyChanging("EntityAttributes");
                SetAttributeValue("entityattributes", value);
                OnPropertyChanged("EntityAttributes");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the process dependency.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the process dependency was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the process dependency.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the user or team who owns the parent workflow instance.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId
        {
            get { return GetAttributeValue<EntityReference>("ownerid"); }
        }

        /// <summary>
        ///     Unique identifier of the business unit that owns the process dependency.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public Guid? OwningBusinessUnit
        {
            get { return GetAttributeValue<Guid?>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the process dependency.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public Guid? OwningUser
        {
            get { return GetAttributeValue<Guid?>("owninguser"); }
        }

        /// <summary>
        ///     Name of the process parameter.
        /// </summary>
        [AttributeLogicalName("parametername")]
        public string ParameterName
        {
            get { return GetAttributeValue<string>("parametername"); }
            set
            {
                OnPropertyChanging("ParameterName");
                SetAttributeValue("parametername", value);
                OnPropertyChanged("ParameterName");
            }
        }

        /// <summary>
        ///     Fully qualified name of the CLR type of the local parameter.
        /// </summary>
        [AttributeLogicalName("parametertype")]
        public string ParameterType
        {
            get { return GetAttributeValue<string>("parametertype"); }
            set
            {
                OnPropertyChanging("ParameterType");
                SetAttributeValue("parametertype", value);
                OnPropertyChanged("ParameterType");
            }
        }

        /// <summary>
        ///     Attribute of the primary entity that specifies related entity.
        /// </summary>
        [AttributeLogicalName("relatedattributename")]
        public string RelatedAttributeName
        {
            get { return GetAttributeValue<string>("relatedattributename"); }
            set
            {
                OnPropertyChanging("RelatedAttributeName");
                SetAttributeValue("relatedattributename", value);
                OnPropertyChanged("RelatedAttributeName");
            }
        }

        /// <summary>
        ///     Name of the related entity.
        /// </summary>
        [AttributeLogicalName("relatedentityname")]
        public string RelatedEntityName
        {
            get { return GetAttributeValue<string>("relatedentityname"); }
            set
            {
                OnPropertyChanging("RelatedEntityName");
                SetAttributeValue("relatedentityname", value);
                OnPropertyChanged("RelatedEntityName");
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
        ///     Type of the process dependency.
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
        ///     Unique identifier of the process dependency.
        /// </summary>
        [AttributeLogicalName("workflowdependencyid")]
        public Guid? WorkflowDependencyId
        {
            get { return GetAttributeValue<Guid?>("workflowdependencyid"); }
            set
            {
                OnPropertyChanging("WorkflowDependencyId");
                SetAttributeValue("workflowdependencyid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("WorkflowDependencyId");
            }
        }

        [AttributeLogicalName("workflowdependencyid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { WorkflowDependencyId = value; }
        }

        /// <summary>
        ///     Unique identifier of the process with which the dependency is associated.
        /// </summary>
        [AttributeLogicalName("workflowid")]
        public EntityReference WorkflowId
        {
            get { return GetAttributeValue<EntityReference>("workflowid"); }
            set
            {
                OnPropertyChanging("WorkflowId");
                SetAttributeValue("workflowid", value);
                OnPropertyChanged("WorkflowId");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_workflowdependency
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_workflowdependency")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_workflowdependency
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_workflowdependency", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_workflowdependency");
                SetRelatedEntities("userentityinstancedata_workflowdependency", null, value);
                OnPropertyChanged("userentityinstancedata_workflowdependency");
            }
        }

        /// <summary>
        ///     N:1 sdkmessageid_workflow_dependency
        /// </summary>
        [AttributeLogicalName("sdkmessageid")]
        [RelationshipSchemaName("sdkmessageid_workflow_dependency")]
        public SdkMessage sdkmessageid_workflow_dependency
        {
            get { return GetRelatedEntity<SdkMessage>("sdkmessageid_workflow_dependency", null); }
            set
            {
                OnPropertyChanging("sdkmessageid_workflow_dependency");
                SetRelatedEntity("sdkmessageid_workflow_dependency", null, value);
                OnPropertyChanged("sdkmessageid_workflow_dependency");
            }
        }

        /// <summary>
        ///     N:1 workflow_dependencies
        /// </summary>
        [AttributeLogicalName("workflowid")]
        [RelationshipSchemaName("workflow_dependencies")]
        public Workflow workflow_dependencies
        {
            get { return GetRelatedEntity<Workflow>("workflow_dependencies", null); }
            set
            {
                OnPropertyChanging("workflow_dependencies");
                SetRelatedEntity("workflow_dependencies", null, value);
                OnPropertyChanged("workflow_dependencies");
            }
        }

        /// <summary>
        ///     N:1 workflow_dependency_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("workflow_dependency_createdby")]
        public SystemUser workflow_dependency_createdby
        {
            get { return GetRelatedEntity<SystemUser>("workflow_dependency_createdby", null); }
        }

        /// <summary>
        ///     N:1 workflow_dependency_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("workflow_dependency_createdonbehalfby")]
        public SystemUser workflow_dependency_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("workflow_dependency_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 workflow_dependency_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("workflow_dependency_modifiedby")]
        public SystemUser workflow_dependency_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("workflow_dependency_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 workflow_dependency_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("workflow_dependency_modifiedonbehalfby")]
        public SystemUser workflow_dependency_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("workflow_dependency_modifiedonbehalfby", null); }
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