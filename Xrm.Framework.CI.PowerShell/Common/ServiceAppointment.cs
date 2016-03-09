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
    ///     Activity offered by the organization to satisfy its customer's needs. Each service activity includes date, time,
    ///     duration, and required resources.
    /// </summary>
    [DataContract]
    [EntityLogicalName("serviceappointment")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ServiceAppointment : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "serviceappointment";

        public const int EntityTypeCode = 4214;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ServiceAppointment() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the service activity.
        /// </summary>
        [AttributeLogicalName("activityid")]
        public Guid? ActivityId
        {
            get { return GetAttributeValue<Guid?>("activityid"); }
            set
            {
                OnPropertyChanging("ActivityId");
                SetAttributeValue("activityid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ActivityId");
            }
        }

        [AttributeLogicalName("activityid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ActivityId = value; }
        }

        /// <summary>
        ///     Shows the type of activity.
        /// </summary>
        [AttributeLogicalName("activitytypecode")]
        public string ActivityTypeCode
        {
            get { return GetAttributeValue<string>("activitytypecode"); }
        }

        /// <summary>
        ///     Shows the value selected in the Duration field on the service activity at the time the service activity is closed
        ///     as completed. The duration is used to report the time spent on the activity.
        /// </summary>
        [AttributeLogicalName("actualdurationminutes")]
        public int? ActualDurationMinutes
        {
            get { return GetAttributeValue<int?>("actualdurationminutes"); }
            set
            {
                OnPropertyChanging("ActualDurationMinutes");
                SetAttributeValue("actualdurationminutes", value);
                OnPropertyChanged("ActualDurationMinutes");
            }
        }

        /// <summary>
        ///     Enter the actual end date and time of the service activity. By default, it displays when the activity was closed or
        ///     canceled.
        /// </summary>
        [AttributeLogicalName("actualend")]
        public DateTime? ActualEnd
        {
            get { return GetAttributeValue<DateTime?>("actualend"); }
            set
            {
                OnPropertyChanging("ActualEnd");
                SetAttributeValue("actualend", value);
                OnPropertyChanged("ActualEnd");
            }
        }

        /// <summary>
        ///     Enter the actual start date and time for the service activity. By default, it displays when the activity was
        ///     created.
        /// </summary>
        [AttributeLogicalName("actualstart")]
        public DateTime? ActualStart
        {
            get { return GetAttributeValue<DateTime?>("actualstart"); }
            set
            {
                OnPropertyChanging("ActualStart");
                SetAttributeValue("actualstart", value);
                OnPropertyChanged("ActualStart");
            }
        }

        /// <summary>
        ///     Type a category to identify the service activity type, such as routine maintenance or service call, to tie the
        ///     service activity to a business group or function.
        /// </summary>
        [AttributeLogicalName("category")]
        public string Category
        {
            get { return GetAttributeValue<string>("category"); }
            set
            {
                OnPropertyChanging("Category");
                SetAttributeValue("category", value);
                OnPropertyChanged("Category");
            }
        }

        /// <summary>
        ///     Shows who created the record.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Shows the date and time when the record was created. The date and time are displayed in the time zone selected in
        ///     Microsoft Dynamics CRM options.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Shows who created the record on behalf of another user.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Enter the accounts and contacts for whom the service activity is being performed.
        /// </summary>
        [AttributeLogicalName("customers")]
        public IEnumerable<ActivityParty> Customers
        {
            get
            {
                var collection = GetAttributeValue<EntityCollection>("customers");
                if (((collection != null)
                     && (collection.Entities != null)))
                {
                    return Enumerable.Cast<ActivityParty>(collection.Entities);
                }
                return null;
            }
            set
            {
                OnPropertyChanging("Customers");
                if ((value == null))
                {
                    SetAttributeValue("customers", value);
                }
                else
                {
                    SetAttributeValue("customers", new EntityCollection(new List<Entity>(value)));
                }
                OnPropertyChanged("Customers");
            }
        }

        /// <summary>
        ///     Type additional information to describe the service activity, such as key talking points or objectives.
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
        ///     Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the
        ///     record from the local currency to the system's default currency.
        /// </summary>
        [AttributeLogicalName("exchangerate")]
        public decimal? ExchangeRate
        {
            get { return GetAttributeValue<decimal?>("exchangerate"); }
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
        ///     Select whether the service activity is an all-day event to make sure the required resources are scheduled for the
        ///     full day.
        /// </summary>
        [AttributeLogicalName("isalldayevent")]
        public bool? IsAllDayEvent
        {
            get { return GetAttributeValue<bool?>("isalldayevent"); }
            set
            {
                OnPropertyChanging("IsAllDayEvent");
                SetAttributeValue("isalldayevent", value);
                OnPropertyChanged("IsAllDayEvent");
            }
        }

        /// <summary>
        ///     Information which specifies whether the service activity was billed as part of resolving a case.
        /// </summary>
        [AttributeLogicalName("isbilled")]
        public bool? IsBilled
        {
            get { return GetAttributeValue<bool?>("isbilled"); }
            set
            {
                OnPropertyChanging("IsBilled");
                SetAttributeValue("isbilled", value);
                OnPropertyChanged("IsBilled");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("ismapiprivate")]
        public bool? IsMapiPrivate
        {
            get { return GetAttributeValue<bool?>("ismapiprivate"); }
            set
            {
                OnPropertyChanging("IsMapiPrivate");
                SetAttributeValue("ismapiprivate", value);
                OnPropertyChanged("IsMapiPrivate");
            }
        }

        /// <summary>
        ///     Information regarding whether the activity is a regular activity type or event type.
        /// </summary>
        [AttributeLogicalName("isregularactivity")]
        public bool? IsRegularActivity
        {
            get { return GetAttributeValue<bool?>("isregularactivity"); }
        }

        /// <summary>
        ///     Information which specifies if the service activity was created from a workflow rule.
        /// </summary>
        [AttributeLogicalName("isworkflowcreated")]
        public bool? IsWorkflowCreated
        {
            get { return GetAttributeValue<bool?>("isworkflowcreated"); }
            set
            {
                OnPropertyChanging("IsWorkflowCreated");
                SetAttributeValue("isworkflowcreated", value);
                OnPropertyChanged("IsWorkflowCreated");
            }
        }

        /// <summary>
        ///     Type the location where the service activity will take place, such as a conference room, customer office, or other
        ///     venue.
        /// </summary>
        [AttributeLogicalName("location")]
        public string Location
        {
            get { return GetAttributeValue<string>("location"); }
            set
            {
                OnPropertyChanging("Location");
                SetAttributeValue("location", value);
                OnPropertyChanged("Location");
            }
        }

        /// <summary>
        ///     Shows who last updated the record.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected
        ///     in Microsoft Dynamics CRM options.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Shows who last updated the record on behalf of another user.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
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
        ///     Enter the user or team who is assigned to manage the record. This field is updated every time the record is
        ///     assigned to a different user.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId
        {
            get { return GetAttributeValue<EntityReference>("ownerid"); }
            set
            {
                OnPropertyChanging("OwnerId");
                SetAttributeValue("ownerid", value);
                OnPropertyChanged("OwnerId");
            }
        }

        /// <summary>
        ///     Shows the business unit that the record owner belongs to.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team that owns the service activity.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user that owns the service activity.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Select the priority so that preferred customers or critical issues are handled quickly.
        /// </summary>
        [AttributeLogicalName("prioritycode")]
        public OptionSetValue PriorityCode
        {
            get { return GetAttributeValue<OptionSetValue>("prioritycode"); }
            set
            {
                OnPropertyChanging("PriorityCode");
                SetAttributeValue("prioritycode", value);
                OnPropertyChanged("PriorityCode");
            }
        }

        /// <summary>
        ///     Unique identifier of the object with which the service activity is associated.
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        public EntityReference RegardingObjectId
        {
            get { return GetAttributeValue<EntityReference>("regardingobjectid"); }
            set
            {
                OnPropertyChanging("RegardingObjectId");
                SetAttributeValue("regardingobjectid", value);
                OnPropertyChanged("RegardingObjectId");
            }
        }

        /// <summary>
        ///     Enter the user, facility, or equipment required to complete the service activity.
        /// </summary>
        [AttributeLogicalName("resources")]
        public IEnumerable<ActivityParty> Resources
        {
            get
            {
                var collection = GetAttributeValue<EntityCollection>("resources");
                if (((collection != null)
                     && (collection.Entities != null)))
                {
                    return Enumerable.Cast<ActivityParty>(collection.Entities);
                }
                return null;
            }
            set
            {
                OnPropertyChanging("Resources");
                if ((value == null))
                {
                    SetAttributeValue("resources", value);
                }
                else
                {
                    SetAttributeValue("resources", new EntityCollection(new List<Entity>(value)));
                }
                OnPropertyChanged("Resources");
            }
        }

        /// <summary>
        ///     Shows the expected duration of the service activity, in minutes.
        /// </summary>
        [AttributeLogicalName("scheduleddurationminutes")]
        public int? ScheduledDurationMinutes
        {
            get { return GetAttributeValue<int?>("scheduleddurationminutes"); }
            set
            {
                OnPropertyChanging("ScheduledDurationMinutes");
                SetAttributeValue("scheduleddurationminutes", value);
                OnPropertyChanged("ScheduledDurationMinutes");
            }
        }

        /// <summary>
        ///     Enter the expected due date and time.
        /// </summary>
        [AttributeLogicalName("scheduledend")]
        public DateTime? ScheduledEnd
        {
            get { return GetAttributeValue<DateTime?>("scheduledend"); }
            set
            {
                OnPropertyChanging("ScheduledEnd");
                SetAttributeValue("scheduledend", value);
                OnPropertyChanged("ScheduledEnd");
            }
        }

        /// <summary>
        ///     Enter the expected due date and time.
        /// </summary>
        [AttributeLogicalName("scheduledstart")]
        public DateTime? ScheduledStart
        {
            get { return GetAttributeValue<DateTime?>("scheduledstart"); }
            set
            {
                OnPropertyChanging("ScheduledStart");
                SetAttributeValue("scheduledstart", value);
                OnPropertyChanged("ScheduledStart");
            }
        }

        /// <summary>
        ///     Choose the service scheduled to be performed during the service activity.
        /// </summary>
        [AttributeLogicalName("serviceid")]
        public EntityReference ServiceId
        {
            get { return GetAttributeValue<EntityReference>("serviceid"); }
            set
            {
                OnPropertyChanging("ServiceId");
                SetAttributeValue("serviceid", value);
                OnPropertyChanged("ServiceId");
            }
        }

        /// <summary>
        ///     Choose the site or location where the service activity will be performed.
        /// </summary>
        [AttributeLogicalName("siteid")]
        public EntityReference SiteId
        {
            get { return GetAttributeValue<EntityReference>("siteid"); }
            set
            {
                OnPropertyChanging("SiteId");
                SetAttributeValue("siteid", value);
                OnPropertyChanged("SiteId");
            }
        }

        /// <summary>
        ///     Shows whether the service activity is open, completed, or canceled. Completed and canceled service activities are
        ///     read-only and can't be edited.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public ServiceAppointmentState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return
                        ((ServiceAppointmentState) (Enum.ToObject(typeof (ServiceAppointmentState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Select the service activity's status.
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
        ///     Type a subcategory to identify the service activity type and relate the activity to a specific product, service
        ///     region, business group, or other function.
        /// </summary>
        [AttributeLogicalName("subcategory")]
        public string Subcategory
        {
            get { return GetAttributeValue<string>("subcategory"); }
            set
            {
                OnPropertyChanging("Subcategory");
                SetAttributeValue("subcategory", value);
                OnPropertyChanged("Subcategory");
            }
        }

        /// <summary>
        ///     Type a short description about the objective or primary topic of the service activity.
        /// </summary>
        [AttributeLogicalName("subject")]
        public string Subject
        {
            get { return GetAttributeValue<string>("subject"); }
            set
            {
                OnPropertyChanging("Subject");
                SetAttributeValue("subject", value);
                OnPropertyChanged("Subject");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("subscriptionid")]
        public Guid? SubscriptionId
        {
            get { return GetAttributeValue<Guid?>("subscriptionid"); }
            set
            {
                OnPropertyChanging("SubscriptionId");
                SetAttributeValue("subscriptionid", value);
                OnPropertyChanged("SubscriptionId");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("timezoneruleversionnumber")]
        public int? TimeZoneRuleVersionNumber
        {
            get { return GetAttributeValue<int?>("timezoneruleversionnumber"); }
            set
            {
                OnPropertyChanging("TimeZoneRuleVersionNumber");
                SetAttributeValue("timezoneruleversionnumber", value);
                OnPropertyChanged("TimeZoneRuleVersionNumber");
            }
        }

        /// <summary>
        ///     Choose the local currency for the record to make sure budgets are reported in the correct currency.
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        public EntityReference TransactionCurrencyId
        {
            get { return GetAttributeValue<EntityReference>("transactioncurrencyid"); }
            set
            {
                OnPropertyChanging("TransactionCurrencyId");
                SetAttributeValue("transactioncurrencyid", value);
                OnPropertyChanged("TransactionCurrencyId");
            }
        }

        /// <summary>
        ///     Time zone code that was in use when the record was created.
        /// </summary>
        [AttributeLogicalName("utcconversiontimezonecode")]
        public int? UTCConversionTimeZoneCode
        {
            get { return GetAttributeValue<int?>("utcconversiontimezonecode"); }
            set
            {
                OnPropertyChanging("UTCConversionTimeZoneCode");
                SetAttributeValue("utcconversiontimezonecode", value);
                OnPropertyChanged("UTCConversionTimeZoneCode");
            }
        }

        /// <summary>
        ///     Version number of the service activity.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N serviceappointment_activity_parties
        /// </summary>
        [RelationshipSchemaName("serviceappointment_activity_parties")]
        public IEnumerable<ActivityParty> serviceappointment_activity_parties
        {
            get { return GetRelatedEntities<ActivityParty>("serviceappointment_activity_parties", null); }
            set
            {
                OnPropertyChanging("serviceappointment_activity_parties");
                SetRelatedEntities("serviceappointment_activity_parties", null, value);
                OnPropertyChanged("serviceappointment_activity_parties");
            }
        }

        /// <summary>
        ///     1:N ServiceAppointment_Annotation
        /// </summary>
        [RelationshipSchemaName("ServiceAppointment_Annotation")]
        public IEnumerable<Annotation> ServiceAppointment_Annotation
        {
            get { return GetRelatedEntities<Annotation>("ServiceAppointment_Annotation", null); }
            set
            {
                OnPropertyChanging("ServiceAppointment_Annotation");
                SetRelatedEntities("ServiceAppointment_Annotation", null, value);
                OnPropertyChanged("ServiceAppointment_Annotation");
            }
        }

        /// <summary>
        ///     1:N ServiceAppointment_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("ServiceAppointment_AsyncOperations")]
        public IEnumerable<AsyncOperation> ServiceAppointment_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("ServiceAppointment_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("ServiceAppointment_AsyncOperations");
                SetRelatedEntities("ServiceAppointment_AsyncOperations", null, value);
                OnPropertyChanged("ServiceAppointment_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N ServiceAppointment_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("ServiceAppointment_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> ServiceAppointment_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("ServiceAppointment_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("ServiceAppointment_BulkDeleteFailures");
                SetRelatedEntities("ServiceAppointment_BulkDeleteFailures", null, value);
                OnPropertyChanged("ServiceAppointment_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N serviceappointment_connections1
        /// </summary>
        [RelationshipSchemaName("serviceappointment_connections1")]
        public IEnumerable<Connection> serviceappointment_connections1
        {
            get { return GetRelatedEntities<Connection>("serviceappointment_connections1", null); }
            set
            {
                OnPropertyChanging("serviceappointment_connections1");
                SetRelatedEntities("serviceappointment_connections1", null, value);
                OnPropertyChanged("serviceappointment_connections1");
            }
        }

        /// <summary>
        ///     1:N serviceappointment_connections2
        /// </summary>
        [RelationshipSchemaName("serviceappointment_connections2")]
        public IEnumerable<Connection> serviceappointment_connections2
        {
            get { return GetRelatedEntities<Connection>("serviceappointment_connections2", null); }
            set
            {
                OnPropertyChanging("serviceappointment_connections2");
                SetRelatedEntities("serviceappointment_connections2", null, value);
                OnPropertyChanged("serviceappointment_connections2");
            }
        }

        /// <summary>
        ///     1:N serviceappointment_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("serviceappointment_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> serviceappointment_principalobjectattributeaccess
        {
            get
            {
                return
                    GetRelatedEntities<PrincipalObjectAttributeAccess>(
                        "serviceappointment_principalobjectattributeaccess", null);
            }
            set
            {
                OnPropertyChanging("serviceappointment_principalobjectattributeaccess");
                SetRelatedEntities("serviceappointment_principalobjectattributeaccess", null, value);
                OnPropertyChanged("serviceappointment_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N ServiceAppointment_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("ServiceAppointment_ProcessSessions")]
        public IEnumerable<ProcessSession> ServiceAppointment_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("ServiceAppointment_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("ServiceAppointment_ProcessSessions");
                SetRelatedEntities("ServiceAppointment_ProcessSessions", null, value);
                OnPropertyChanged("ServiceAppointment_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N ServiceAppointment_QueueItem
        /// </summary>
        [RelationshipSchemaName("ServiceAppointment_QueueItem")]
        public IEnumerable<QueueItem> ServiceAppointment_QueueItem
        {
            get { return GetRelatedEntities<QueueItem>("ServiceAppointment_QueueItem", null); }
            set
            {
                OnPropertyChanging("ServiceAppointment_QueueItem");
                SetRelatedEntities("ServiceAppointment_QueueItem", null, value);
                OnPropertyChanged("ServiceAppointment_QueueItem");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_serviceappointment
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_serviceappointment")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_serviceappointment
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_serviceappointment", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_serviceappointment");
                SetRelatedEntities("userentityinstancedata_serviceappointment", null, value);
                OnPropertyChanged("userentityinstancedata_serviceappointment");
            }
        }

        /// <summary>
        ///     N:1 Account_ServiceAppointments
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Account_ServiceAppointments")]
        public Account Account_ServiceAppointments
        {
            get { return GetRelatedEntity<Account>("Account_ServiceAppointments", null); }
            set
            {
                OnPropertyChanging("Account_ServiceAppointments");
                SetRelatedEntity("Account_ServiceAppointments", null, value);
                OnPropertyChanged("Account_ServiceAppointments");
            }
        }

        /// <summary>
        ///     N:1 activity_pointer_service_appointment
        /// </summary>
        [AttributeLogicalName("activityid")]
        [RelationshipSchemaName("activity_pointer_service_appointment")]
        public ActivityPointer activity_pointer_service_appointment
        {
            get { return GetRelatedEntity<ActivityPointer>("activity_pointer_service_appointment", null); }
            set
            {
                OnPropertyChanging("activity_pointer_service_appointment");
                SetRelatedEntity("activity_pointer_service_appointment", null, value);
                OnPropertyChanged("activity_pointer_service_appointment");
            }
        }

        /// <summary>
        ///     N:1 business_unit_service_appointments
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_service_appointments")]
        public BusinessUnit business_unit_service_appointments
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_service_appointments", null); }
        }

        /// <summary>
        ///     N:1 Campaign_ServiceAppointments
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Campaign_ServiceAppointments")]
        public Campaign Campaign_ServiceAppointments
        {
            get { return GetRelatedEntity<Campaign>("Campaign_ServiceAppointments", null); }
            set
            {
                OnPropertyChanging("Campaign_ServiceAppointments");
                SetRelatedEntity("Campaign_ServiceAppointments", null, value);
                OnPropertyChanged("Campaign_ServiceAppointments");
            }
        }

        /// <summary>
        ///     N:1 Contact_ServiceAppointments
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Contact_ServiceAppointments")]
        public Contact Contact_ServiceAppointments
        {
            get { return GetRelatedEntity<Contact>("Contact_ServiceAppointments", null); }
            set
            {
                OnPropertyChanging("Contact_ServiceAppointments");
                SetRelatedEntity("Contact_ServiceAppointments", null, value);
                OnPropertyChanged("Contact_ServiceAppointments");
            }
        }

        /// <summary>
        ///     N:1 Contract_ServiceAppointments
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Contract_ServiceAppointments")]
        public Contract Contract_ServiceAppointments
        {
            get { return GetRelatedEntity<Contract>("Contract_ServiceAppointments", null); }
            set
            {
                OnPropertyChanging("Contract_ServiceAppointments");
                SetRelatedEntity("Contract_ServiceAppointments", null, value);
                OnPropertyChanged("Contract_ServiceAppointments");
            }
        }

        /// <summary>
        ///     N:1 Incident_ServiceAppointments
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Incident_ServiceAppointments")]
        public Incident Incident_ServiceAppointments
        {
            get { return GetRelatedEntity<Incident>("Incident_ServiceAppointments", null); }
            set
            {
                OnPropertyChanging("Incident_ServiceAppointments");
                SetRelatedEntity("Incident_ServiceAppointments", null, value);
                OnPropertyChanged("Incident_ServiceAppointments");
            }
        }

        /// <summary>
        ///     N:1 Invoice_ServiceAppointments
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Invoice_ServiceAppointments")]
        public Invoice Invoice_ServiceAppointments
        {
            get { return GetRelatedEntity<Invoice>("Invoice_ServiceAppointments", null); }
            set
            {
                OnPropertyChanging("Invoice_ServiceAppointments");
                SetRelatedEntity("Invoice_ServiceAppointments", null, value);
                OnPropertyChanged("Invoice_ServiceAppointments");
            }
        }

        /// <summary>
        ///     N:1 Lead_ServiceAppointments
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Lead_ServiceAppointments")]
        public Lead Lead_ServiceAppointments
        {
            get { return GetRelatedEntity<Lead>("Lead_ServiceAppointments", null); }
            set
            {
                OnPropertyChanging("Lead_ServiceAppointments");
                SetRelatedEntity("Lead_ServiceAppointments", null, value);
                OnPropertyChanged("Lead_ServiceAppointments");
            }
        }

        /// <summary>
        ///     N:1 lk_serviceappointment_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_serviceappointment_createdby")]
        public SystemUser lk_serviceappointment_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_serviceappointment_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_serviceappointment_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_serviceappointment_createdonbehalfby")]
        public SystemUser lk_serviceappointment_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_serviceappointment_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_serviceappointment_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_serviceappointment_modifiedby")]
        public SystemUser lk_serviceappointment_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_serviceappointment_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_serviceappointment_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_serviceappointment_modifiedonbehalfby")]
        public SystemUser lk_serviceappointment_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_serviceappointment_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 msdyn_postalbum_ServiceAppointments
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("msdyn_postalbum_ServiceAppointments")]
        public msdyn_PostAlbum msdyn_postalbum_ServiceAppointments
        {
            get { return GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_ServiceAppointments", null); }
            set
            {
                OnPropertyChanging("msdyn_postalbum_ServiceAppointments");
                SetRelatedEntity("msdyn_postalbum_ServiceAppointments", null, value);
                OnPropertyChanged("msdyn_postalbum_ServiceAppointments");
            }
        }

        /// <summary>
        ///     N:1 Opportunity_ServiceAppointments
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Opportunity_ServiceAppointments")]
        public Opportunity Opportunity_ServiceAppointments
        {
            get { return GetRelatedEntity<Opportunity>("Opportunity_ServiceAppointments", null); }
            set
            {
                OnPropertyChanging("Opportunity_ServiceAppointments");
                SetRelatedEntity("Opportunity_ServiceAppointments", null, value);
                OnPropertyChanged("Opportunity_ServiceAppointments");
            }
        }

        /// <summary>
        ///     N:1 Quote_ServiceAppointments
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Quote_ServiceAppointments")]
        public Quote Quote_ServiceAppointments
        {
            get { return GetRelatedEntity<Quote>("Quote_ServiceAppointments", null); }
            set
            {
                OnPropertyChanging("Quote_ServiceAppointments");
                SetRelatedEntity("Quote_ServiceAppointments", null, value);
                OnPropertyChanged("Quote_ServiceAppointments");
            }
        }

        /// <summary>
        ///     N:1 SalesOrder_ServiceAppointments
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SalesOrder_ServiceAppointments")]
        public SalesOrder SalesOrder_ServiceAppointments
        {
            get { return GetRelatedEntity<SalesOrder>("SalesOrder_ServiceAppointments", null); }
            set
            {
                OnPropertyChanging("SalesOrder_ServiceAppointments");
                SetRelatedEntity("SalesOrder_ServiceAppointments", null, value);
                OnPropertyChanged("SalesOrder_ServiceAppointments");
            }
        }

        /// <summary>
        ///     N:1 service_service_appointments
        /// </summary>
        [AttributeLogicalName("serviceid")]
        [RelationshipSchemaName("service_service_appointments")]
        public Service service_service_appointments
        {
            get { return GetRelatedEntity<Service>("service_service_appointments", null); }
            set
            {
                OnPropertyChanging("service_service_appointments");
                SetRelatedEntity("service_service_appointments", null, value);
                OnPropertyChanged("service_service_appointments");
            }
        }

        /// <summary>
        ///     N:1 site_service_appointments
        /// </summary>
        [AttributeLogicalName("siteid")]
        [RelationshipSchemaName("site_service_appointments")]
        public Site site_service_appointments
        {
            get { return GetRelatedEntity<Site>("site_service_appointments", null); }
            set
            {
                OnPropertyChanging("site_service_appointments");
                SetRelatedEntity("site_service_appointments", null, value);
                OnPropertyChanged("site_service_appointments");
            }
        }

        /// <summary>
        ///     N:1 system_user_service_appointments
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("system_user_service_appointments")]
        public SystemUser system_user_service_appointments
        {
            get { return GetRelatedEntity<SystemUser>("system_user_service_appointments", null); }
        }

        /// <summary>
        ///     N:1 team_service_appointments
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_service_appointments")]
        public Team team_service_appointments
        {
            get { return GetRelatedEntity<Team>("team_service_appointments", null); }
        }

        /// <summary>
        ///     N:1 TransactionCurrency_ServiceAppointment
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("TransactionCurrency_ServiceAppointment")]
        public TransactionCurrency TransactionCurrency_ServiceAppointment
        {
            get { return GetRelatedEntity<TransactionCurrency>("TransactionCurrency_ServiceAppointment", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_ServiceAppointment");
                SetRelatedEntity("TransactionCurrency_ServiceAppointment", null, value);
                OnPropertyChanged("TransactionCurrency_ServiceAppointment");
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