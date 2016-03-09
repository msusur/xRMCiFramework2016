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
    ///     A component dependency in CRM.
    /// </summary>
    [DataContract]
    [EntityLogicalName("dependency")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Dependency : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "dependency";

        public const int EntityTypeCode = 7105;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Dependency() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of a dependency.
        /// </summary>
        [AttributeLogicalName("dependencyid")]
        public Guid? DependencyId
        {
            get { return GetAttributeValue<Guid?>("dependencyid"); }
        }

        [AttributeLogicalName("dependencyid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { base.Id = value; }
        }

        /// <summary>
        ///     The dependency type of the dependency.
        /// </summary>
        [AttributeLogicalName("dependencytype")]
        public OptionSetValue DependencyType
        {
            get { return GetAttributeValue<OptionSetValue>("dependencytype"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("dependentcomponentbasesolutionid")]
        public Guid? DependentComponentBaseSolutionId
        {
            get { return GetAttributeValue<Guid?>("dependentcomponentbasesolutionid"); }
        }

        /// <summary>
        ///     Unique identifier of the dependent component's node.
        /// </summary>
        [AttributeLogicalName("dependentcomponentnodeid")]
        public EntityReference DependentComponentNodeId
        {
            get { return GetAttributeValue<EntityReference>("dependentcomponentnodeid"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("dependentcomponentobjectid")]
        public Guid? DependentComponentObjectId
        {
            get { return GetAttributeValue<Guid?>("dependentcomponentobjectid"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("dependentcomponentparentid")]
        public Guid? DependentComponentParentId
        {
            get { return GetAttributeValue<Guid?>("dependentcomponentparentid"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("dependentcomponenttype")]
        public OptionSetValue DependentComponentType
        {
            get { return GetAttributeValue<OptionSetValue>("dependentcomponenttype"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("requiredcomponentbasesolutionid")]
        public Guid? RequiredComponentBaseSolutionId
        {
            get { return GetAttributeValue<Guid?>("requiredcomponentbasesolutionid"); }
        }

        /// <summary>
        ///     Unique identifier of the required component's node
        /// </summary>
        [AttributeLogicalName("requiredcomponentnodeid")]
        public EntityReference RequiredComponentNodeId
        {
            get { return GetAttributeValue<EntityReference>("requiredcomponentnodeid"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("requiredcomponentobjectid")]
        public Guid? RequiredComponentObjectId
        {
            get { return GetAttributeValue<Guid?>("requiredcomponentobjectid"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("requiredcomponentparentid")]
        public Guid? RequiredComponentParentId
        {
            get { return GetAttributeValue<Guid?>("requiredcomponentparentid"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("requiredcomponenttype")]
        public OptionSetValue RequiredComponentType
        {
            get { return GetAttributeValue<OptionSetValue>("requiredcomponenttype"); }
        }

        /// <summary>
        ///     1:N userentityinstancedata_dependency
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_dependency")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_dependency
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_dependency", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_dependency");
                SetRelatedEntities("userentityinstancedata_dependency", null, value);
                OnPropertyChanged("userentityinstancedata_dependency");
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