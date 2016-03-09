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
    ///     Time zone definition, including name and time zone code.
    /// </summary>
    [DataContract]
    [EntityLogicalName("timezonedefinition")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class TimeZoneDefinition : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "timezonedefinition";

        public const int EntityTypeCode = 4810;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public TimeZoneDefinition() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Base time bias of the time zone.
        /// </summary>
        [AttributeLogicalName("bias")]
        public int? Bias
        {
            get { return GetAttributeValue<int?>("bias"); }
            set
            {
                OnPropertyChanging("Bias");
                SetAttributeValue("bias", value);
                OnPropertyChanged("Bias");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the time zone record.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the time zone record was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the timezonedefinition.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Time zone name for the daylight time.
        /// </summary>
        [AttributeLogicalName("daylightname")]
        public string DaylightName
        {
            get { return GetAttributeValue<string>("daylightname"); }
            set
            {
                OnPropertyChanging("DaylightName");
                SetAttributeValue("daylightname", value);
                OnPropertyChanged("DaylightName");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the time zone record.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the time zone record was modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the timezonedefinition.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the organization associated with the time zone definition.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     Order an entry for a time zone definition is retired. 0 for the latest entry.
        /// </summary>
        [AttributeLogicalName("retiredorder")]
        public int? RetiredOrder
        {
            get { return GetAttributeValue<int?>("retiredorder"); }
            set
            {
                OnPropertyChanging("RetiredOrder");
                SetAttributeValue("retiredorder", value);
                OnPropertyChanged("RetiredOrder");
            }
        }

        /// <summary>
        ///     Time zone name for the standard time.
        /// </summary>
        [AttributeLogicalName("standardname")]
        public string StandardName
        {
            get { return GetAttributeValue<string>("standardname"); }
            set
            {
                OnPropertyChanging("StandardName");
                SetAttributeValue("standardname", value);
                OnPropertyChanged("StandardName");
            }
        }

        /// <summary>
        ///     Time zone identification code.
        /// </summary>
        [AttributeLogicalName("timezonecode")]
        public int? TimeZoneCode
        {
            get { return GetAttributeValue<int?>("timezonecode"); }
            set
            {
                OnPropertyChanging("TimeZoneCode");
                SetAttributeValue("timezonecode", value);
                OnPropertyChanged("TimeZoneCode");
            }
        }

        /// <summary>
        ///     Unique identifier of the time zone record.
        /// </summary>
        [AttributeLogicalName("timezonedefinitionid")]
        public Guid? TimeZoneDefinitionId
        {
            get { return GetAttributeValue<Guid?>("timezonedefinitionid"); }
            set
            {
                OnPropertyChanging("TimeZoneDefinitionId");
                SetAttributeValue("timezonedefinitionid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("TimeZoneDefinitionId");
            }
        }

        [AttributeLogicalName("timezonedefinitionid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { TimeZoneDefinitionId = value; }
        }

        /// <summary>
        ///     Display name for the time zone in the Microsoft Windows registry.
        /// </summary>
        [AttributeLogicalName("userinterfacename")]
        public string UserInterfaceName
        {
            get { return GetAttributeValue<string>("userinterfacename"); }
            set
            {
                OnPropertyChanging("UserInterfaceName");
                SetAttributeValue("userinterfacename", value);
                OnPropertyChanged("UserInterfaceName");
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
        ///     1:N lk_timezonelocalizedname_timezonedefinitionid
        /// </summary>
        [RelationshipSchemaName("lk_timezonelocalizedname_timezonedefinitionid")]
        public IEnumerable<TimeZoneLocalizedName> lk_timezonelocalizedname_timezonedefinitionid
        {
            get
            {
                return GetRelatedEntities<TimeZoneLocalizedName>("lk_timezonelocalizedname_timezonedefinitionid", null);
            }
            set
            {
                OnPropertyChanging("lk_timezonelocalizedname_timezonedefinitionid");
                SetRelatedEntities("lk_timezonelocalizedname_timezonedefinitionid", null, value);
                OnPropertyChanged("lk_timezonelocalizedname_timezonedefinitionid");
            }
        }

        /// <summary>
        ///     1:N lk_timezonerule_timezonedefinitionid
        /// </summary>
        [RelationshipSchemaName("lk_timezonerule_timezonedefinitionid")]
        public IEnumerable<TimeZoneRule> lk_timezonerule_timezonedefinitionid
        {
            get { return GetRelatedEntities<TimeZoneRule>("lk_timezonerule_timezonedefinitionid", null); }
            set
            {
                OnPropertyChanging("lk_timezonerule_timezonedefinitionid");
                SetRelatedEntities("lk_timezonerule_timezonedefinitionid", null, value);
                OnPropertyChanged("lk_timezonerule_timezonedefinitionid");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_timezonedefinition
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_timezonedefinition")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_timezonedefinition
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_timezonedefinition", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_timezonedefinition");
                SetRelatedEntities("userentityinstancedata_timezonedefinition", null, value);
                OnPropertyChanged("userentityinstancedata_timezonedefinition");
            }
        }

        /// <summary>
        ///     N:1 lk_timezonedefinition_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_timezonedefinition_createdby")]
        public SystemUser lk_timezonedefinition_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_timezonedefinition_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_timezonedefinition_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_timezonedefinition_createdonbehalfby")]
        public SystemUser lk_timezonedefinition_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_timezonedefinition_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_timezonedefinition_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_timezonedefinition_modifiedby")]
        public SystemUser lk_timezonedefinition_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_timezonedefinition_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_timezonedefinition_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_timezonedefinition_modifiedonbehalfby")]
        public SystemUser lk_timezonedefinition_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_timezonedefinition_modifiedonbehalfby", null); }
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