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
    ///     Activity generated automatically when an order is closed.
    /// </summary>
    [DataContract]
    [EntityLogicalName("orderclose")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class OrderClose : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "orderclose";

        public const int EntityTypeCode = 4209;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public OrderClose() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the order close activity.
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
        ///     Type of activity.
        /// </summary>
        [AttributeLogicalName("activitytypecode")]
        public string ActivityTypeCode
        {
            get { return GetAttributeValue<string>("activitytypecode"); }
        }

        /// <summary>
        ///     Actual duration of the order close activity in minutes.
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
        ///     Actual end time of the order close activity.
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
        ///     Actual start time of the order close activity.
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
        ///     Category of the order close activity.
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
        ///     Unique identifier of the user who created the order close activity.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the order close activity was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the orderclose.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Activity generated automatically when an order is closed.
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
        ///     Information about whether the order close activity was billed as part of resolving a case.
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
        ///     Information regarding whether the activity is a regular activity type or event type.
        /// </summary>
        [AttributeLogicalName("isregularactivity")]
        public bool? IsRegularActivity
        {
            get { return GetAttributeValue<bool?>("isregularactivity"); }
        }

        /// <summary>
        ///     Information that specifies if the order close activity was created from a workflow rule.
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
        ///     Unique identifier of the user who last modified the order close activity.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the order close activity was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the orderclose.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Order number.
        /// </summary>
        [AttributeLogicalName("ordernumber")]
        public string OrderNumber
        {
            get { return GetAttributeValue<string>("ordernumber"); }
            set
            {
                OnPropertyChanging("OrderNumber");
                SetAttributeValue("ordernumber", value);
                OnPropertyChanged("OrderNumber");
            }
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
        ///     Unique identifier of the user or team who owns the order close activity.
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
        ///     Unique identifier of the business unit that owns the order close activity.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the order close activity.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the order close activity.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Order revision number.
        /// </summary>
        [AttributeLogicalName("revision")]
        public int? Revision
        {
            get { return GetAttributeValue<int?>("revision"); }
            set
            {
                OnPropertyChanging("Revision");
                SetAttributeValue("revision", value);
                OnPropertyChanged("Revision");
            }
        }

        /// <summary>
        ///     Unique identifier of the order with which the order close activity is associated.
        /// </summary>
        [AttributeLogicalName("salesorderid")]
        public EntityReference SalesOrderId
        {
            get { return GetAttributeValue<EntityReference>("salesorderid"); }
            set
            {
                OnPropertyChanging("SalesOrderId");
                SetAttributeValue("salesorderid", value);
                OnPropertyChanged("SalesOrderId");
            }
        }

        /// <summary>
        ///     Scheduled duration of the order close activity, specified in minutes.
        /// </summary>
        [AttributeLogicalName("scheduleddurationminutes")]
        public int? ScheduledDurationMinutes
        {
            get { return GetAttributeValue<int?>("scheduleddurationminutes"); }
        }

        /// <summary>
        ///     Scheduled end time of the order close activity.
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
        ///     Scheduled start time of the order close activity.
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
        ///     Unique identifier of the service with which the order close activity is associated.
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
        ///     Shows whether the order close activity is open, completed, or canceled. By default, order close activities are
        ///     completed.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public OrderCloseState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((OrderCloseState) (Enum.ToObject(typeof (OrderCloseState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the order close activity.
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
        ///     Subcategory of the order close activity.
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
        ///     Subject associated with the order close activity.
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
        ///     Version number of the order close activity.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N orderclose_activity_parties
        /// </summary>
        [RelationshipSchemaName("orderclose_activity_parties")]
        public IEnumerable<ActivityParty> orderclose_activity_parties
        {
            get { return GetRelatedEntities<ActivityParty>("orderclose_activity_parties", null); }
            set
            {
                OnPropertyChanging("orderclose_activity_parties");
                SetRelatedEntities("orderclose_activity_parties", null, value);
                OnPropertyChanged("orderclose_activity_parties");
            }
        }

        /// <summary>
        ///     1:N OrderClose_Annotation
        /// </summary>
        [RelationshipSchemaName("OrderClose_Annotation")]
        public IEnumerable<Annotation> OrderClose_Annotation
        {
            get { return GetRelatedEntities<Annotation>("OrderClose_Annotation", null); }
            set
            {
                OnPropertyChanging("OrderClose_Annotation");
                SetRelatedEntities("OrderClose_Annotation", null, value);
                OnPropertyChanged("OrderClose_Annotation");
            }
        }

        /// <summary>
        ///     1:N OrderClose_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("OrderClose_AsyncOperations")]
        public IEnumerable<AsyncOperation> OrderClose_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("OrderClose_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("OrderClose_AsyncOperations");
                SetRelatedEntities("OrderClose_AsyncOperations", null, value);
                OnPropertyChanged("OrderClose_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N OrderClose_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("OrderClose_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> OrderClose_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("OrderClose_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("OrderClose_BulkDeleteFailures");
                SetRelatedEntities("OrderClose_BulkDeleteFailures", null, value);
                OnPropertyChanged("OrderClose_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_orderclose
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_orderclose")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_orderclose
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_orderclose", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_orderclose");
                SetRelatedEntities("userentityinstancedata_orderclose", null, value);
                OnPropertyChanged("userentityinstancedata_orderclose");
            }
        }

        /// <summary>
        ///     N:1 activity_pointer_order_close
        /// </summary>
        [AttributeLogicalName("activityid")]
        [RelationshipSchemaName("activity_pointer_order_close")]
        public ActivityPointer activity_pointer_order_close
        {
            get { return GetRelatedEntity<ActivityPointer>("activity_pointer_order_close", null); }
            set
            {
                OnPropertyChanging("activity_pointer_order_close");
                SetRelatedEntity("activity_pointer_order_close", null, value);
                OnPropertyChanged("activity_pointer_order_close");
            }
        }

        /// <summary>
        ///     N:1 business_unit_order_close_activities
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_order_close_activities")]
        public BusinessUnit business_unit_order_close_activities
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_order_close_activities", null); }
        }

        /// <summary>
        ///     N:1 lk_orderclose_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_orderclose_createdby")]
        public SystemUser lk_orderclose_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_orderclose_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_orderclose_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_orderclose_createdonbehalfby")]
        public SystemUser lk_orderclose_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_orderclose_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_orderclose_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_orderclose_modifiedby")]
        public SystemUser lk_orderclose_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_orderclose_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_orderclose_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_orderclose_modifiedonbehalfby")]
        public SystemUser lk_orderclose_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_orderclose_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 SalesOrder_OrderClose
        /// </summary>
        [AttributeLogicalName("salesorderid")]
        [RelationshipSchemaName("SalesOrder_OrderClose")]
        public SalesOrder SalesOrder_OrderClose
        {
            get { return GetRelatedEntity<SalesOrder>("SalesOrder_OrderClose", null); }
            set
            {
                OnPropertyChanging("SalesOrder_OrderClose");
                SetRelatedEntity("SalesOrder_OrderClose", null, value);
                OnPropertyChanged("SalesOrder_OrderClose");
            }
        }

        /// <summary>
        ///     N:1 service_orderclose
        /// </summary>
        [AttributeLogicalName("serviceid")]
        [RelationshipSchemaName("service_orderclose")]
        public Service service_orderclose
        {
            get { return GetRelatedEntity<Service>("service_orderclose", null); }
            set
            {
                OnPropertyChanging("service_orderclose");
                SetRelatedEntity("service_orderclose", null, value);
                OnPropertyChanged("service_orderclose");
            }
        }

        /// <summary>
        ///     N:1 team_orderclose
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_orderclose")]
        public Team team_orderclose
        {
            get { return GetRelatedEntity<Team>("team_orderclose", null); }
        }

        /// <summary>
        ///     N:1 user_orderclose
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_orderclose")]
        public SystemUser user_orderclose
        {
            get { return GetRelatedEntity<SystemUser>("user_orderclose", null); }
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