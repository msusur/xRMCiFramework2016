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
    ///     Localized name of the time zone.
    /// </summary>
    [DataContract]
    [EntityLogicalName("timezonelocalizedname")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class TimeZoneLocalizedName : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "timezonelocalizedname";

        public const int EntityTypeCode = 4812;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public TimeZoneLocalizedName() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the user who created the record.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the record was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the timezonelocalizedname.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the culture that the UI names are encoded in.
        /// </summary>
        [AttributeLogicalName("cultureid")]
        public int? CultureId
        {
            get { return GetAttributeValue<int?>("cultureid"); }
            set
            {
                OnPropertyChanging("CultureId");
                SetAttributeValue("cultureid", value);
                OnPropertyChanged("CultureId");
            }
        }

        /// <summary>
        ///     Name of the time zone for the daylight time.
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
        ///     Unique identifier of the user who last modified the time zone localized name.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the record was modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the timezonelocalizedname.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the organization associated with the time zone localized name.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     Name of the time zone for the standard time.
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
        ///     Unique identifier of time zone definition entity instances.
        /// </summary>
        [AttributeLogicalName("timezonedefinitionid")]
        public EntityReference TimeZoneDefinitionId
        {
            get { return GetAttributeValue<EntityReference>("timezonedefinitionid"); }
            set
            {
                OnPropertyChanging("TimeZoneDefinitionId");
                SetAttributeValue("timezonedefinitionid", value);
                OnPropertyChanged("TimeZoneDefinitionId");
            }
        }

        /// <summary>
        ///     Unique identifier of entity instances.
        /// </summary>
        [AttributeLogicalName("timezonelocalizednameid")]
        public Guid? TimeZoneLocalizedNameId
        {
            get { return GetAttributeValue<Guid?>("timezonelocalizednameid"); }
            set
            {
                OnPropertyChanging("TimeZoneLocalizedNameId");
                SetAttributeValue("timezonelocalizednameid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("TimeZoneLocalizedNameId");
            }
        }

        [AttributeLogicalName("timezonelocalizednameid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { TimeZoneLocalizedNameId = value; }
        }

        /// <summary>
        ///     Unique display name for the time zone in the Microsoft Windows registry.
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
        ///     1:N userentityinstancedata_timezonelocalizedname
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_timezonelocalizedname")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_timezonelocalizedname
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_timezonelocalizedname", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_timezonelocalizedname");
                SetRelatedEntities("userentityinstancedata_timezonelocalizedname", null, value);
                OnPropertyChanged("userentityinstancedata_timezonelocalizedname");
            }
        }

        /// <summary>
        ///     N:1 lk_timezonelocalizedname_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_timezonelocalizedname_createdby")]
        public SystemUser lk_timezonelocalizedname_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_timezonelocalizedname_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_timezonelocalizedname_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_timezonelocalizedname_createdonbehalfby")]
        public SystemUser lk_timezonelocalizedname_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_timezonelocalizedname_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_timezonelocalizedname_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_timezonelocalizedname_modifiedby")]
        public SystemUser lk_timezonelocalizedname_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_timezonelocalizedname_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_timezonelocalizedname_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_timezonelocalizedname_modifiedonbehalfby")]
        public SystemUser lk_timezonelocalizedname_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_timezonelocalizedname_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_timezonelocalizedname_timezonedefinitionid
        /// </summary>
        [AttributeLogicalName("timezonedefinitionid")]
        [RelationshipSchemaName("lk_timezonelocalizedname_timezonedefinitionid")]
        public TimeZoneDefinition lk_timezonelocalizedname_timezonedefinitionid
        {
            get { return GetRelatedEntity<TimeZoneDefinition>("lk_timezonelocalizedname_timezonedefinitionid", null); }
            set
            {
                OnPropertyChanging("lk_timezonelocalizedname_timezonedefinitionid");
                SetRelatedEntity("lk_timezonelocalizedname_timezonedefinitionid", null, value);
                OnPropertyChanged("lk_timezonelocalizedname_timezonedefinitionid");
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