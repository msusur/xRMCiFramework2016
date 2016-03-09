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
    ///     Activity that represents work done to satisfy a customer's need.
    /// </summary>
    [DataContract]
    [EntityLogicalName("service")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Service : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "service";

        public const int EntityTypeCode = 4001;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Service() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Used in conjunction with granularity to describes when services can be performed in relation to midnight on a given
        ///     day.
        /// </summary>
        [AttributeLogicalName("anchoroffset")]
        public int? AnchorOffset
        {
            get { return GetAttributeValue<int?>("anchoroffset"); }
            set
            {
                OnPropertyChanging("AnchorOffset");
                SetAttributeValue("anchoroffset", value);
                OnPropertyChanged("AnchorOffset");
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
                OnPropertyChanged("CalendarId");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the service.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the service was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the service.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Description of activity that represents work done to satisfy a customer's need.
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
        ///     Duration of the service.
        /// </summary>
        [AttributeLogicalName("duration")]
        public int? Duration
        {
            get { return GetAttributeValue<int?>("duration"); }
            set
            {
                OnPropertyChanging("Duration");
                SetAttributeValue("duration", value);
                OnPropertyChanged("Duration");
            }
        }

        /// <summary>
        ///     Describes how often the service is performed.
        /// </summary>
        [AttributeLogicalName("granularity")]
        public string Granularity
        {
            get { return GetAttributeValue<string>("granularity"); }
            set
            {
                OnPropertyChanging("Granularity");
                SetAttributeValue("granularity", value);
                OnPropertyChanged("Granularity");
            }
        }

        /// <summary>
        ///     Unique identifier of the data import or data migration that created this record.
        /// </summary>
        [AttributeLogicalName("importsequencenumber")]
        public int? ImportSequenceNumber
        {
            get { return GetAttributeValue<int?>("importsequencenumber"); }
            set
            {
                OnPropertyChanging("ImportSequenceNumber");
                SetAttributeValue("importsequencenumber", value);
                OnPropertyChanged("ImportSequenceNumber");
            }
        }

        /// <summary>
        ///     Initial status reason for the service activity.
        /// </summary>
        [AttributeLogicalName("initialstatuscode")]
        public OptionSetValue InitialStatusCode
        {
            get { return GetAttributeValue<OptionSetValue>("initialstatuscode"); }
            set
            {
                OnPropertyChanging("InitialStatusCode");
                SetAttributeValue("initialstatuscode", value);
                OnPropertyChanged("InitialStatusCode");
            }
        }

        /// <summary>
        ///     Information about whether the service can be scheduled.
        /// </summary>
        [AttributeLogicalName("isschedulable")]
        public bool? IsSchedulable
        {
            get { return GetAttributeValue<bool?>("isschedulable"); }
            set
            {
                OnPropertyChanging("IsSchedulable");
                SetAttributeValue("isschedulable", value);
                OnPropertyChanged("IsSchedulable");
            }
        }

        /// <summary>
        ///     Information about whether the service is visible to users.
        /// </summary>
        [AttributeLogicalName("isvisible")]
        public bool? IsVisible
        {
            get { return GetAttributeValue<bool?>("isvisible"); }
            set
            {
                OnPropertyChanging("IsVisible");
                SetAttributeValue("isvisible", value);
                OnPropertyChanged("IsVisible");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the service.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the service was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the service.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the service.
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
        ///     Unique identifier of the organization with which the service is associated.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     Date and time that the record was migrated.
        /// </summary>
        [AttributeLogicalName("overriddencreatedon")]
        public DateTime? OverriddenCreatedOn
        {
            get { return GetAttributeValue<DateTime?>("overriddencreatedon"); }
            set
            {
                OnPropertyChanging("OverriddenCreatedOn");
                SetAttributeValue("overriddencreatedon", value);
                OnPropertyChanged("OverriddenCreatedOn");
            }
        }

        /// <summary>
        ///     Unique identifier of the resource specification with which the service is associated.
        /// </summary>
        [AttributeLogicalName("resourcespecid")]
        public EntityReference ResourceSpecId
        {
            get { return GetAttributeValue<EntityReference>("resourcespecid"); }
            set
            {
                OnPropertyChanging("ResourceSpecId");
                SetAttributeValue("resourcespecid", value);
                OnPropertyChanged("ResourceSpecId");
            }
        }

        /// <summary>
        ///     Unique identifier of the associated service.
        /// </summary>
        [AttributeLogicalName("serviceid")]
        public Guid? ServiceId
        {
            get { return GetAttributeValue<Guid?>("serviceid"); }
            set
            {
                OnPropertyChanging("ServiceId");
                SetAttributeValue("serviceid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ServiceId");
            }
        }

        [AttributeLogicalName("serviceid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ServiceId = value; }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("showresources")]
        public bool? ShowResources
        {
            get { return GetAttributeValue<bool?>("showresources"); }
            set
            {
                OnPropertyChanging("ShowResources");
                SetAttributeValue("showresources", value);
                OnPropertyChanged("ShowResources");
            }
        }

        /// <summary>
        ///     Value that is taken from PluginTypeId in the Plugin Type record for the scheduling strategy. This is the ID of the
        ///     scheduling strategy plug-in associated with the service.
        /// </summary>
        [AttributeLogicalName("strategyid")]
        public EntityReference StrategyId
        {
            get { return GetAttributeValue<EntityReference>("strategyid"); }
            set
            {
                OnPropertyChanging("StrategyId");
                SetAttributeValue("strategyid", value);
                OnPropertyChanged("StrategyId");
            }
        }

        /// <summary>
        ///     Version number of the service.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N service_accounts
        /// </summary>
        [RelationshipSchemaName("service_accounts")]
        public IEnumerable<Account> service_accounts
        {
            get { return GetRelatedEntities<Account>("service_accounts", null); }
            set
            {
                OnPropertyChanging("service_accounts");
                SetRelatedEntities("service_accounts", null, value);
                OnPropertyChanged("service_accounts");
            }
        }

        /// <summary>
        ///     1:N service_activity_pointers
        /// </summary>
        [RelationshipSchemaName("service_activity_pointers")]
        public IEnumerable<ActivityPointer> service_activity_pointers
        {
            get { return GetRelatedEntities<ActivityPointer>("service_activity_pointers", null); }
            set
            {
                OnPropertyChanging("service_activity_pointers");
                SetRelatedEntities("service_activity_pointers", null, value);
                OnPropertyChanged("service_activity_pointers");
            }
        }

        /// <summary>
        ///     1:N Service_Annotation
        /// </summary>
        [RelationshipSchemaName("Service_Annotation")]
        public IEnumerable<Annotation> Service_Annotation
        {
            get { return GetRelatedEntities<Annotation>("Service_Annotation", null); }
            set
            {
                OnPropertyChanging("Service_Annotation");
                SetRelatedEntities("Service_Annotation", null, value);
                OnPropertyChanged("Service_Annotation");
            }
        }

        /// <summary>
        ///     1:N service_appointments
        /// </summary>
        [RelationshipSchemaName("service_appointments")]
        public IEnumerable<Appointment> service_appointments
        {
            get { return GetRelatedEntities<Appointment>("service_appointments", null); }
            set
            {
                OnPropertyChanging("service_appointments");
                SetRelatedEntities("service_appointments", null, value);
                OnPropertyChanged("service_appointments");
            }
        }

        /// <summary>
        ///     1:N Service_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Service_AsyncOperations")]
        public IEnumerable<AsyncOperation> Service_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Service_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Service_AsyncOperations");
                SetRelatedEntities("Service_AsyncOperations", null, value);
                OnPropertyChanged("Service_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N Service_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("Service_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> Service_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("Service_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("Service_BulkDeleteFailures");
                SetRelatedEntities("Service_BulkDeleteFailures", null, value);
                OnPropertyChanged("Service_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N service_calendar_rules
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
        ///     1:N service_contacts
        /// </summary>
        [RelationshipSchemaName("service_contacts")]
        public IEnumerable<Contact> service_contacts
        {
            get { return GetRelatedEntities<Contact>("service_contacts", null); }
            set
            {
                OnPropertyChanging("service_contacts");
                SetRelatedEntities("service_contacts", null, value);
                OnPropertyChanged("service_contacts");
            }
        }

        /// <summary>
        ///     1:N Service_DuplicateBaseRecord
        /// </summary>
        [RelationshipSchemaName("Service_DuplicateBaseRecord")]
        public IEnumerable<DuplicateRecord> Service_DuplicateBaseRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Service_DuplicateBaseRecord", null); }
            set
            {
                OnPropertyChanging("Service_DuplicateBaseRecord");
                SetRelatedEntities("Service_DuplicateBaseRecord", null, value);
                OnPropertyChanged("Service_DuplicateBaseRecord");
            }
        }

        /// <summary>
        ///     1:N Service_DuplicateMatchingRecord
        /// </summary>
        [RelationshipSchemaName("Service_DuplicateMatchingRecord")]
        public IEnumerable<DuplicateRecord> Service_DuplicateMatchingRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Service_DuplicateMatchingRecord", null); }
            set
            {
                OnPropertyChanging("Service_DuplicateMatchingRecord");
                SetRelatedEntities("Service_DuplicateMatchingRecord", null, value);
                OnPropertyChanged("Service_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        ///     1:N service_emails
        /// </summary>
        [RelationshipSchemaName("service_emails")]
        public IEnumerable<Email> service_emails
        {
            get { return GetRelatedEntities<Email>("service_emails", null); }
            set
            {
                OnPropertyChanging("service_emails");
                SetRelatedEntities("service_emails", null, value);
                OnPropertyChanged("service_emails");
            }
        }

        /// <summary>
        ///     1:N service_faxes
        /// </summary>
        [RelationshipSchemaName("service_faxes")]
        public IEnumerable<Fax> service_faxes
        {
            get { return GetRelatedEntities<Fax>("service_faxes", null); }
            set
            {
                OnPropertyChanging("service_faxes");
                SetRelatedEntities("service_faxes", null, value);
                OnPropertyChanged("service_faxes");
            }
        }

        /// <summary>
        ///     1:N service_incidentresolutions
        /// </summary>
        [RelationshipSchemaName("service_incidentresolutions")]
        public IEnumerable<IncidentResolution> service_incidentresolutions
        {
            get { return GetRelatedEntities<IncidentResolution>("service_incidentresolutions", null); }
            set
            {
                OnPropertyChanging("service_incidentresolutions");
                SetRelatedEntities("service_incidentresolutions", null, value);
                OnPropertyChanged("service_incidentresolutions");
            }
        }

        /// <summary>
        ///     1:N service_letters
        /// </summary>
        [RelationshipSchemaName("service_letters")]
        public IEnumerable<Letter> service_letters
        {
            get { return GetRelatedEntities<Letter>("service_letters", null); }
            set
            {
                OnPropertyChanging("service_letters");
                SetRelatedEntities("service_letters", null, value);
                OnPropertyChanged("service_letters");
            }
        }

        /// <summary>
        ///     1:N service_opportunityclose
        /// </summary>
        [RelationshipSchemaName("service_opportunityclose")]
        public IEnumerable<OpportunityClose> service_opportunityclose
        {
            get { return GetRelatedEntities<OpportunityClose>("service_opportunityclose", null); }
            set
            {
                OnPropertyChanging("service_opportunityclose");
                SetRelatedEntities("service_opportunityclose", null, value);
                OnPropertyChanged("service_opportunityclose");
            }
        }

        /// <summary>
        ///     1:N service_orderclose
        /// </summary>
        [RelationshipSchemaName("service_orderclose")]
        public IEnumerable<OrderClose> service_orderclose
        {
            get { return GetRelatedEntities<OrderClose>("service_orderclose", null); }
            set
            {
                OnPropertyChanging("service_orderclose");
                SetRelatedEntities("service_orderclose", null, value);
                OnPropertyChanged("service_orderclose");
            }
        }

        /// <summary>
        ///     1:N service_phonecalls
        /// </summary>
        [RelationshipSchemaName("service_phonecalls")]
        public IEnumerable<PhoneCall> service_phonecalls
        {
            get { return GetRelatedEntities<PhoneCall>("service_phonecalls", null); }
            set
            {
                OnPropertyChanging("service_phonecalls");
                SetRelatedEntities("service_phonecalls", null, value);
                OnPropertyChanged("service_phonecalls");
            }
        }

        /// <summary>
        ///     1:N Service_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("Service_ProcessSessions")]
        public IEnumerable<ProcessSession> Service_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("Service_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Service_ProcessSessions");
                SetRelatedEntities("Service_ProcessSessions", null, value);
                OnPropertyChanged("Service_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N service_quoteclose
        /// </summary>
        [RelationshipSchemaName("service_quoteclose")]
        public IEnumerable<QuoteClose> service_quoteclose
        {
            get { return GetRelatedEntities<QuoteClose>("service_quoteclose", null); }
            set
            {
                OnPropertyChanging("service_quoteclose");
                SetRelatedEntities("service_quoteclose", null, value);
                OnPropertyChanged("service_quoteclose");
            }
        }

        /// <summary>
        ///     1:N service_recurringappointmentmasters
        /// </summary>
        [RelationshipSchemaName("service_recurringappointmentmasters")]
        public IEnumerable<RecurringAppointmentMaster> service_recurringappointmentmasters
        {
            get { return GetRelatedEntities<RecurringAppointmentMaster>("service_recurringappointmentmasters", null); }
            set
            {
                OnPropertyChanging("service_recurringappointmentmasters");
                SetRelatedEntities("service_recurringappointmentmasters", null, value);
                OnPropertyChanged("service_recurringappointmentmasters");
            }
        }

        /// <summary>
        ///     1:N service_service_appointments
        /// </summary>
        [RelationshipSchemaName("service_service_appointments")]
        public IEnumerable<ServiceAppointment> service_service_appointments
        {
            get { return GetRelatedEntities<ServiceAppointment>("service_service_appointments", null); }
            set
            {
                OnPropertyChanging("service_service_appointments");
                SetRelatedEntities("service_service_appointments", null, value);
                OnPropertyChanged("service_service_appointments");
            }
        }

        /// <summary>
        ///     1:N service_tasks
        /// </summary>
        [RelationshipSchemaName("service_tasks")]
        public IEnumerable<Task> service_tasks
        {
            get { return GetRelatedEntities<Task>("service_tasks", null); }
            set
            {
                OnPropertyChanging("service_tasks");
                SetRelatedEntities("service_tasks", null, value);
                OnPropertyChanged("service_tasks");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_service
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_service")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_service
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_service", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_service");
                SetRelatedEntities("userentityinstancedata_service", null, value);
                OnPropertyChanged("userentityinstancedata_service");
            }
        }

        /// <summary>
        ///     N:1 calendar_services
        /// </summary>
        [AttributeLogicalName("calendarid")]
        [RelationshipSchemaName("calendar_services")]
        public Calendar calendar_services
        {
            get { return GetRelatedEntity<Calendar>("calendar_services", null); }
            set
            {
                OnPropertyChanging("calendar_services");
                SetRelatedEntity("calendar_services", null, value);
                OnPropertyChanged("calendar_services");
            }
        }

        /// <summary>
        ///     N:1 lk_service_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_service_createdby")]
        public SystemUser lk_service_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_service_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_service_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_service_createdonbehalfby")]
        public SystemUser lk_service_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_service_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_service_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_service_modifiedby")]
        public SystemUser lk_service_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_service_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_service_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_service_modifiedonbehalfby")]
        public SystemUser lk_service_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_service_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 organization_services
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_services")]
        public Organization organization_services
        {
            get { return GetRelatedEntity<Organization>("organization_services", null); }
        }

        /// <summary>
        ///     N:1 plugin_type_service
        /// </summary>
        [AttributeLogicalName("strategyid")]
        [RelationshipSchemaName("plugin_type_service")]
        public PluginType plugin_type_service
        {
            get { return GetRelatedEntity<PluginType>("plugin_type_service", null); }
            set
            {
                OnPropertyChanging("plugin_type_service");
                SetRelatedEntity("plugin_type_service", null, value);
                OnPropertyChanged("plugin_type_service");
            }
        }

        /// <summary>
        ///     N:1 resource_spec_services
        /// </summary>
        [AttributeLogicalName("resourcespecid")]
        [RelationshipSchemaName("resource_spec_services")]
        public ResourceSpec resource_spec_services
        {
            get { return GetRelatedEntity<ResourceSpec>("resource_spec_services", null); }
            set
            {
                OnPropertyChanging("resource_spec_services");
                SetRelatedEntity("resource_spec_services", null, value);
                OnPropertyChanged("resource_spec_services");
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