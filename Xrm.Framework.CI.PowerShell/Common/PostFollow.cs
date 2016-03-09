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
    ///     Represents a user following the activity feed of an object.
    /// </summary>
    [DataContract]
    [EntityLogicalName("postfollow")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class PostFollow : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "postfollow";

        public const int EntityTypeCode = 8003;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public PostFollow() :
            base(EntityLogicalName)
        {
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
        ///     Unique identifier for the business unit that owns the record.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the follow.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier for the user who owns the record.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Shows the ID of the post follow.
        /// </summary>
        [AttributeLogicalName("postfollowid")]
        public Guid? PostFollowId
        {
            get { return GetAttributeValue<Guid?>("postfollowid"); }
            set
            {
                OnPropertyChanging("PostFollowId");
                SetAttributeValue("postfollowid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("PostFollowId");
            }
        }

        [AttributeLogicalName("postfollowid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { PostFollowId = value; }
        }

        /// <summary>
        ///     Choose the parent record for the followed post to identify the customer, opportunity, case, or other record type
        ///     that the post most closely relates to.
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
        ///     Internal Use Only
        /// </summary>
        [AttributeLogicalName("yammerpoststate")]
        public int? YammerPostState
        {
            get { return GetAttributeValue<int?>("yammerpoststate"); }
        }

        /// <summary>
        ///     1:N PostFollow_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("PostFollow_AsyncOperations")]
        public IEnumerable<AsyncOperation> PostFollow_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("PostFollow_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("PostFollow_AsyncOperations");
                SetRelatedEntities("PostFollow_AsyncOperations", null, value);
                OnPropertyChanged("PostFollow_AsyncOperations");
            }
        }

        /// <summary>
        ///     N:1 account_PostFollows
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("account_PostFollows")]
        public Account account_PostFollows
        {
            get { return GetRelatedEntity<Account>("account_PostFollows", null); }
            set
            {
                OnPropertyChanging("account_PostFollows");
                SetRelatedEntity("account_PostFollows", null, value);
                OnPropertyChanged("account_PostFollows");
            }
        }

        /// <summary>
        ///     N:1 appointment_PostFollows
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("appointment_PostFollows")]
        public Appointment appointment_PostFollows
        {
            get { return GetRelatedEntity<Appointment>("appointment_PostFollows", null); }
            set
            {
                OnPropertyChanging("appointment_PostFollows");
                SetRelatedEntity("appointment_PostFollows", null, value);
                OnPropertyChanged("appointment_PostFollows");
            }
        }

        /// <summary>
        ///     N:1 business_unit_postfollows
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_postfollows")]
        public BusinessUnit business_unit_postfollows
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_postfollows", null); }
        }

        /// <summary>
        ///     N:1 competitor_PostFollows
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("competitor_PostFollows")]
        public Competitor competitor_PostFollows
        {
            get { return GetRelatedEntity<Competitor>("competitor_PostFollows", null); }
            set
            {
                OnPropertyChanging("competitor_PostFollows");
                SetRelatedEntity("competitor_PostFollows", null, value);
                OnPropertyChanged("competitor_PostFollows");
            }
        }

        /// <summary>
        ///     N:1 contact_PostFollows
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("contact_PostFollows")]
        public Contact contact_PostFollows
        {
            get { return GetRelatedEntity<Contact>("contact_PostFollows", null); }
            set
            {
                OnPropertyChanging("contact_PostFollows");
                SetRelatedEntity("contact_PostFollows", null, value);
                OnPropertyChanged("contact_PostFollows");
            }
        }

        /// <summary>
        ///     N:1 incident_PostFollows
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("incident_PostFollows")]
        public Incident incident_PostFollows
        {
            get { return GetRelatedEntity<Incident>("incident_PostFollows", null); }
            set
            {
                OnPropertyChanging("incident_PostFollows");
                SetRelatedEntity("incident_PostFollows", null, value);
                OnPropertyChanged("incident_PostFollows");
            }
        }

        /// <summary>
        ///     N:1 lead_PostFollows
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("lead_PostFollows")]
        public Lead lead_PostFollows
        {
            get { return GetRelatedEntity<Lead>("lead_PostFollows", null); }
            set
            {
                OnPropertyChanging("lead_PostFollows");
                SetRelatedEntity("lead_PostFollows", null, value);
                OnPropertyChanged("lead_PostFollows");
            }
        }

        /// <summary>
        ///     N:1 lk_PostFollow_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_PostFollow_createdby")]
        public SystemUser lk_PostFollow_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_PostFollow_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_postfollow_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_postfollow_createdonbehalfby")]
        public SystemUser lk_postfollow_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_postfollow_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 opportunity_PostFollows
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("opportunity_PostFollows")]
        public Opportunity opportunity_PostFollows
        {
            get { return GetRelatedEntity<Opportunity>("opportunity_PostFollows", null); }
            set
            {
                OnPropertyChanging("opportunity_PostFollows");
                SetRelatedEntity("opportunity_PostFollows", null, value);
                OnPropertyChanged("opportunity_PostFollows");
            }
        }

        /// <summary>
        ///     N:1 OwningTeam_postfollows
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("OwningTeam_postfollows")]
        public Team OwningTeam_postfollows
        {
            get { return GetRelatedEntity<Team>("OwningTeam_postfollows", null); }
        }

        /// <summary>
        ///     N:1 phonecall_PostFollows
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("phonecall_PostFollows")]
        public PhoneCall phonecall_PostFollows
        {
            get { return GetRelatedEntity<PhoneCall>("phonecall_PostFollows", null); }
            set
            {
                OnPropertyChanging("phonecall_PostFollows");
                SetRelatedEntity("phonecall_PostFollows", null, value);
                OnPropertyChanged("phonecall_PostFollows");
            }
        }

        /// <summary>
        ///     N:1 processsession_PostFollows
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("processsession_PostFollows")]
        public ProcessSession processsession_PostFollows
        {
            get { return GetRelatedEntity<ProcessSession>("processsession_PostFollows", null); }
            set
            {
                OnPropertyChanging("processsession_PostFollows");
                SetRelatedEntity("processsession_PostFollows", null, value);
                OnPropertyChanged("processsession_PostFollows");
            }
        }

        /// <summary>
        ///     N:1 queue_PostFollows
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("queue_PostFollows")]
        public Queue queue_PostFollows
        {
            get { return GetRelatedEntity<Queue>("queue_PostFollows", null); }
            set
            {
                OnPropertyChanging("queue_PostFollows");
                SetRelatedEntity("queue_PostFollows", null, value);
                OnPropertyChanged("queue_PostFollows");
            }
        }

        /// <summary>
        ///     N:1 recurringappointmentmaster_PostFollows
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("recurringappointmentmaster_PostFollows")]
        public RecurringAppointmentMaster recurringappointmentmaster_PostFollows
        {
            get { return GetRelatedEntity<RecurringAppointmentMaster>("recurringappointmentmaster_PostFollows", null); }
            set
            {
                OnPropertyChanging("recurringappointmentmaster_PostFollows");
                SetRelatedEntity("recurringappointmentmaster_PostFollows", null, value);
                OnPropertyChanged("recurringappointmentmaster_PostFollows");
            }
        }

        /// <summary>
        ///     N:1 systemuser_PostFollows
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("systemuser_PostFollows")]
        public SystemUser systemuser_PostFollows
        {
            get { return GetRelatedEntity<SystemUser>("systemuser_PostFollows", null); }
            set
            {
                OnPropertyChanging("systemuser_PostFollows");
                SetRelatedEntity("systemuser_PostFollows", null, value);
                OnPropertyChanged("systemuser_PostFollows");
            }
        }

        /// <summary>
        ///     N:1 task_PostFollows
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("task_PostFollows")]
        public Task task_PostFollows
        {
            get { return GetRelatedEntity<Task>("task_PostFollows", null); }
            set
            {
                OnPropertyChanging("task_PostFollows");
                SetRelatedEntity("task_PostFollows", null, value);
                OnPropertyChanged("task_PostFollows");
            }
        }

        /// <summary>
        ///     N:1 user_owner_postfollows
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_owner_postfollows")]
        public SystemUser user_owner_postfollows
        {
            get { return GetRelatedEntity<SystemUser>("user_owner_postfollows", null); }
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