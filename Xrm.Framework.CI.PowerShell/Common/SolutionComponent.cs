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
    ///     A component of a CRM solution.
    /// </summary>
    [DataContract]
    [EntityLogicalName("solutioncomponent")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class SolutionComponent : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "solutioncomponent";

        public const int EntityTypeCode = 7103;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public SolutionComponent() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     The object type code of the component.
        /// </summary>
        [AttributeLogicalName("componenttype")]
        public OptionSetValue ComponentType
        {
            get { return GetAttributeValue<OptionSetValue>("componenttype"); }
        }

        /// <summary>
        ///     Unique identifier of the user who created the solution
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the solution was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the solution.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Indicates whether this component is metadata or data.
        /// </summary>
        [AttributeLogicalName("ismetadata")]
        public bool? IsMetadata
        {
            get { return GetAttributeValue<bool?>("ismetadata"); }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the solution.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the solution was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who modified the solution.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the object with which the component is associated.
        /// </summary>
        [AttributeLogicalName("objectid")]
        public Guid? ObjectId
        {
            get { return GetAttributeValue<Guid?>("objectid"); }
        }

        /// <summary>
        ///     Unique identifier of the solution component.
        /// </summary>
        [AttributeLogicalName("solutioncomponentid")]
        public Guid? SolutionComponentId
        {
            get { return GetAttributeValue<Guid?>("solutioncomponentid"); }
        }

        [AttributeLogicalName("solutioncomponentid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { base.Id = value; }
        }

        /// <summary>
        ///     Unique identifier of the solution.
        /// </summary>
        [AttributeLogicalName("solutionid")]
        public EntityReference SolutionId
        {
            get { return GetAttributeValue<EntityReference>("solutionid"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N userentityinstancedata_solutioncomponent
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_solutioncomponent")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_solutioncomponent
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_solutioncomponent", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_solutioncomponent");
                SetRelatedEntities("userentityinstancedata_solutioncomponent", null, value);
                OnPropertyChanged("userentityinstancedata_solutioncomponent");
            }
        }

        /// <summary>
        ///     N:1 lk_solutioncomponentbase_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_solutioncomponentbase_createdonbehalfby")]
        public SystemUser lk_solutioncomponentbase_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_solutioncomponentbase_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_solutioncomponentbase_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_solutioncomponentbase_modifiedonbehalfby")]
        public SystemUser lk_solutioncomponentbase_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_solutioncomponentbase_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 solution_solutioncomponent
        /// </summary>
        [AttributeLogicalName("solutionid")]
        [RelationshipSchemaName("solution_solutioncomponent")]
        public Solution solution_solutioncomponent
        {
            get { return GetRelatedEntity<Solution>("solution_solutioncomponent", null); }
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