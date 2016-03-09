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
    ///     Plug-in type statistic.
    /// </summary>
    [DataContract]
    [EntityLogicalName("plugintypestatistic")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class PluginTypeStatistic : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "plugintypestatistic";

        public const int EntityTypeCode = 4603;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public PluginTypeStatistic() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     The average execution time (in milliseconds) for the plug-in type.
        /// </summary>
        [AttributeLogicalName("averageexecutetimeinmilliseconds")]
        public int? AverageExecuteTimeInMilliseconds
        {
            get { return GetAttributeValue<int?>("averageexecutetimeinmilliseconds"); }
        }

        /// <summary>
        ///     The plug-in type percentage contribution to crashes.
        /// </summary>
        [AttributeLogicalName("crashcontributionpercent")]
        public int? CrashContributionPercent
        {
            get { return GetAttributeValue<int?>("crashcontributionpercent"); }
        }

        /// <summary>
        ///     Number of times the plug-in type has crashed.
        /// </summary>
        [AttributeLogicalName("crashcount")]
        public int? CrashCount
        {
            get { return GetAttributeValue<int?>("crashcount"); }
        }

        /// <summary>
        ///     Percentage of crashes for the plug-in type.
        /// </summary>
        [AttributeLogicalName("crashpercent")]
        public int? CrashPercent
        {
            get { return GetAttributeValue<int?>("crashpercent"); }
        }

        /// <summary>
        ///     Unique identifier of the user who created the plug-in type statistic.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the plug-in type statistic was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the plug-in type statistic.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Number of times the plug-in type has been executed.
        /// </summary>
        [AttributeLogicalName("executecount")]
        public int? ExecuteCount
        {
            get { return GetAttributeValue<int?>("executecount"); }
        }

        /// <summary>
        ///     Number of times the plug-in type has failed.
        /// </summary>
        [AttributeLogicalName("failurecount")]
        public int? FailureCount
        {
            get { return GetAttributeValue<int?>("failurecount"); }
        }

        /// <summary>
        ///     Percentage of failures for the plug-in type.
        /// </summary>
        [AttributeLogicalName("failurepercent")]
        public int? FailurePercent
        {
            get { return GetAttributeValue<int?>("failurepercent"); }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the plug-in type statistic.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the plug-in type statistic was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who modified the plug-in type statistic.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the organization with which the plug-in type statistic is associated.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     Unique identifier of the plug-in type associated with this plug-in type statistic.
        /// </summary>
        [AttributeLogicalName("plugintypeid")]
        public EntityReference PluginTypeId
        {
            get { return GetAttributeValue<EntityReference>("plugintypeid"); }
        }

        /// <summary>
        ///     Unique identifier of the plug-in type statistic.
        /// </summary>
        [AttributeLogicalName("plugintypestatisticid")]
        public Guid? PluginTypeStatisticId
        {
            get { return GetAttributeValue<Guid?>("plugintypestatisticid"); }
        }

        [AttributeLogicalName("plugintypestatisticid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { base.Id = value; }
        }

        /// <summary>
        ///     The plug-in type percentage contribution to Worker process termination due to excessive CPU usage.
        /// </summary>
        [AttributeLogicalName("terminatecpucontributionpercent")]
        public int? TerminateCpuContributionPercent
        {
            get { return GetAttributeValue<int?>("terminatecpucontributionpercent"); }
        }

        /// <summary>
        ///     The plug-in type percentage contribution to Worker process termination due to excessive handle usage.
        /// </summary>
        [AttributeLogicalName("terminatehandlescontributionpercent")]
        public int? TerminateHandlesContributionPercent
        {
            get { return GetAttributeValue<int?>("terminatehandlescontributionpercent"); }
        }

        /// <summary>
        ///     The plug-in type percentage contribution to Worker process termination due to excessive memory usage.
        /// </summary>
        [AttributeLogicalName("terminatememorycontributionpercent")]
        public int? TerminateMemoryContributionPercent
        {
            get { return GetAttributeValue<int?>("terminatememorycontributionpercent"); }
        }

        /// <summary>
        ///     The plug-in type percentage contribution to Worker process termination due to unknown reasons.
        /// </summary>
        [AttributeLogicalName("terminateothercontributionpercent")]
        public int? TerminateOtherContributionPercent
        {
            get { return GetAttributeValue<int?>("terminateothercontributionpercent"); }
        }

        /// <summary>
        ///     1:N userentityinstancedata_plugintypestatistic
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_plugintypestatistic")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_plugintypestatistic
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_plugintypestatistic", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_plugintypestatistic");
                SetRelatedEntities("userentityinstancedata_plugintypestatistic", null, value);
                OnPropertyChanged("userentityinstancedata_plugintypestatistic");
            }
        }

        /// <summary>
        ///     N:1 createdby_plugintypestatistic
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("createdby_plugintypestatistic")]
        public SystemUser createdby_plugintypestatistic
        {
            get { return GetRelatedEntity<SystemUser>("createdby_plugintypestatistic", null); }
        }

        /// <summary>
        ///     N:1 lk_plugintypestatisticbase_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_plugintypestatisticbase_createdonbehalfby")]
        public SystemUser lk_plugintypestatisticbase_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_plugintypestatisticbase_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_plugintypestatisticbase_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_plugintypestatisticbase_modifiedonbehalfby")]
        public SystemUser lk_plugintypestatisticbase_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_plugintypestatisticbase_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 modifiedby_plugintypestatistic
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("modifiedby_plugintypestatistic")]
        public SystemUser modifiedby_plugintypestatistic
        {
            get { return GetRelatedEntity<SystemUser>("modifiedby_plugintypestatistic", null); }
        }

        /// <summary>
        ///     N:1 organization_plugintypestatistic
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_plugintypestatistic")]
        public Organization organization_plugintypestatistic
        {
            get { return GetRelatedEntity<Organization>("organization_plugintypestatistic", null); }
        }

        /// <summary>
        ///     N:1 plugintype_plugintypestatistic
        /// </summary>
        [AttributeLogicalName("plugintypeid")]
        [RelationshipSchemaName("plugintype_plugintypestatistic")]
        public PluginType plugintype_plugintypestatistic
        {
            get { return GetRelatedEntity<PluginType>("plugintype_plugintypestatistic", null); }
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