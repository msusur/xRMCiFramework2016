using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Xrm.Framework.CI.Common.Entities
{
    /// <summary>
    ///     Calendar used by the scheduling system to define when an appointment or activity is to occur.
    /// </summary>
    [DataContract]
    [EntityLogicalName("calendar")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Calendar : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "calendar";

        public const int EntityTypeCode = 4003;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Calendar() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the business unit with which the calendar is associated.
        /// </summary>
        [AttributeLogicalName("businessunitid")]
        public EntityReference BusinessUnitId
        {
            get { return GetAttributeValue<EntityReference>("businessunitid"); }
            set
            {
                OnPropertyChanging("BusinessUnitId");
                SetAttributeValue("businessunitid", value);
                OnPropertyChanged("BusinessUnitId");
            }
        }

        /// <summary>
        ///     Unique identifier of the calendar.
        /// </summary>
        [AttributeLogicalName("calendarid")]
        public Guid? CalendarId
        {
            get { return GetAttributeValue<Guid?>("calendarid"); }
            set
            {
                OnPropertyChanging("CalendarId");
                SetAttributeValue("calendarid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("CalendarId");
            }
        }

        [AttributeLogicalName("calendarid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { CalendarId = value; }
        }

        /// <summary>
        ///     Unique identifier of the user who created the calendar.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the calendar was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the calendar.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Calendar used by the scheduling system to define when an appointment or activity is to occur.
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
        ///     Calendar is shared by other calendars, such as the organization calendar.
        /// </summary>
        [AttributeLogicalName("isshared")]
        public bool? IsShared
        {
            get { return GetAttributeValue<bool?>("isshared"); }
            set
            {
                OnPropertyChanging("IsShared");
                SetAttributeValue("isshared", value);
                OnPropertyChanged("IsShared");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the calendar.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the calendar was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the calendar.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the calendar.
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
        ///     Unique identifier of the organization with which the calendar is associated.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     Unique identifier of the primary user of this calendar.
        /// </summary>
        [AttributeLogicalName("primaryuserid")]
        public Guid? PrimaryUserId
        {
            get { return GetAttributeValue<Guid?>("primaryuserid"); }
            set
            {
                OnPropertyChanging("PrimaryUserId");
                SetAttributeValue("primaryuserid", value);
                OnPropertyChanged("PrimaryUserId");
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
        ///     1:N BusinessUnit_Calendar
        /// </summary>
        [RelationshipSchemaName("BusinessUnit_Calendar")]
        public IEnumerable<BusinessUnit> BusinessUnit_Calendar
        {
            get { return GetRelatedEntities<BusinessUnit>("BusinessUnit_Calendar", null); }
            set
            {
                OnPropertyChanging("BusinessUnit_Calendar");
                SetRelatedEntities("BusinessUnit_Calendar", null, value);
                OnPropertyChanged("BusinessUnit_Calendar");
            }
        }

        /// <summary>
        ///     1:N Calendar_Annotation
        /// </summary>
        [RelationshipSchemaName("Calendar_Annotation")]
        public IEnumerable<Annotation> Calendar_Annotation
        {
            get { return GetRelatedEntities<Annotation>("Calendar_Annotation", null); }
            set
            {
                OnPropertyChanging("Calendar_Annotation");
                SetRelatedEntities("Calendar_Annotation", null, value);
                OnPropertyChanged("Calendar_Annotation");
            }
        }

        /// <summary>
        ///     1:N Calendar_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Calendar_AsyncOperations")]
        public IEnumerable<AsyncOperation> Calendar_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Calendar_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Calendar_AsyncOperations");
                SetRelatedEntities("Calendar_AsyncOperations", null, value);
                OnPropertyChanged("Calendar_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N Calendar_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("Calendar_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> Calendar_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("Calendar_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("Calendar_BulkDeleteFailures");
                SetRelatedEntities("Calendar_BulkDeleteFailures", null, value);
                OnPropertyChanged("Calendar_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N calendar_calendar_rules
        /// </summary>
        [AttributeLogicalName("calendarrules")]
        public IEnumerable<CalendarRule> CalendarRules
        {
            get
            {
                var collection = GetAttributeValue<EntityCollection>("calendarrules");
                if (((collection != null)
                     && (collection.Entities != null)))
                {
                    return Enumerable.Cast<CalendarRule>(collection.Entities);
                }
                return null;
            }
            set
            {
                OnPropertyChanging("CalendarRules");
                if ((value == null))
                {
                    SetAttributeValue("calendarrules", value);
                }
                else
                {
                    SetAttributeValue("calendarrules", new EntityCollection(new List<Entity>(value)));
                }
                OnPropertyChanged("CalendarRules");
            }
        }

        /// <summary>
        ///     1:N calendar_equipment
        /// </summary>
        [RelationshipSchemaName("calendar_equipment")]
        public IEnumerable<Equipment> calendar_equipment
        {
            get { return GetRelatedEntities<Equipment>("calendar_equipment", null); }
            set
            {
                OnPropertyChanging("calendar_equipment");
                SetRelatedEntities("calendar_equipment", null, value);
                OnPropertyChanged("calendar_equipment");
            }
        }

        /// <summary>
        ///     1:N calendar_organization
        /// </summary>
        [RelationshipSchemaName("calendar_organization")]
        public IEnumerable<Organization> calendar_organization
        {
            get { return GetRelatedEntities<Organization>("calendar_organization", null); }
            set
            {
                OnPropertyChanging("calendar_organization");
                SetRelatedEntities("calendar_organization", null, value);
                OnPropertyChanged("calendar_organization");
            }
        }

        /// <summary>
        ///     1:N calendar_services
        /// </summary>
        [RelationshipSchemaName("calendar_services")]
        public IEnumerable<Service> calendar_services
        {
            get { return GetRelatedEntities<Service>("calendar_services", null); }
            set
            {
                OnPropertyChanging("calendar_services");
                SetRelatedEntities("calendar_services", null, value);
                OnPropertyChanged("calendar_services");
            }
        }

        /// <summary>
        ///     1:N calendar_system_users
        /// </summary>
        [RelationshipSchemaName("calendar_system_users")]
        public IEnumerable<SystemUser> calendar_system_users
        {
            get { return GetRelatedEntities<SystemUser>("calendar_system_users", null); }
            set
            {
                OnPropertyChanging("calendar_system_users");
                SetRelatedEntities("calendar_system_users", null, value);
                OnPropertyChanged("calendar_system_users");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_calendar
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_calendar")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_calendar
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_calendar", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_calendar");
                SetRelatedEntities("userentityinstancedata_calendar", null, value);
                OnPropertyChanged("userentityinstancedata_calendar");
            }
        }

        /// <summary>
        ///     N:1 business_unit_calendars
        /// </summary>
        [AttributeLogicalName("businessunitid")]
        [RelationshipSchemaName("business_unit_calendars")]
        public BusinessUnit business_unit_calendars
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_calendars", null); }
            set
            {
                OnPropertyChanging("business_unit_calendars");
                SetRelatedEntity("business_unit_calendars", null, value);
                OnPropertyChanged("business_unit_calendars");
            }
        }

        /// <summary>
        ///     N:1 lk_calendar_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_calendar_createdby")]
        public SystemUser lk_calendar_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_calendar_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_calendar_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_calendar_createdonbehalfby")]
        public SystemUser lk_calendar_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_calendar_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_calendar_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_calendar_modifiedby")]
        public SystemUser lk_calendar_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_calendar_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_calendar_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_calendar_modifiedonbehalfby")]
        public SystemUser lk_calendar_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_calendar_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 organization_calendars
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_calendars")]
        public Organization organization_calendars
        {
            get { return GetRelatedEntity<Organization>("organization_calendars", null); }
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