using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Xrm.Framework.CI.Common.Entities
{
    /// <summary>
    ///     Trigger that invoke a rule.
    /// </summary>
    [DataContract]
    [EntityLogicalName("processtrigger")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ProcessTrigger : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "processtrigger";

        public const int EntityTypeCode = 4712;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ProcessTrigger() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("componentstate")]
        public OptionSetValue ComponentState
        {
            get { return GetAttributeValue<OptionSetValue>("componentstate"); }
        }

        /// <summary>
        ///     Name of the control.
        /// </summary>
        [AttributeLogicalName("controlname")]
        public string ControlName
        {
            get { return GetAttributeValue<string>("controlname"); }
            set
            {
                OnPropertyChanging("ControlName");
                SetAttributeValue("controlname", value);
                OnPropertyChanged("ControlName");
            }
        }

        /// <summary>
        ///     Type of the control to which this trigger is bound
        /// </summary>
        [AttributeLogicalName("controltype")]
        public OptionSetValue ControlType
        {
            get { return GetAttributeValue<OptionSetValue>("controltype"); }
            set
            {
                OnPropertyChanging("ControlType");
                SetAttributeValue("controltype", value);
                OnPropertyChanged("ControlType");
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
        ///     Indicates the event.
        /// </summary>
        [AttributeLogicalName("event")]
        public string Event
        {
            get { return GetAttributeValue<string>("event"); }
            set
            {
                OnPropertyChanging("Event");
                SetAttributeValue("event", value);
                OnPropertyChanged("Event");
            }
        }

        /// <summary>
        ///     Unique identifier of the form associated with the trigger.
        /// </summary>
        [AttributeLogicalName("formid")]
        public EntityReference FormId
        {
            get { return GetAttributeValue<EntityReference>("formid"); }
            set
            {
                OnPropertyChanging("FormId");
                SetAttributeValue("formid", value);
                OnPropertyChanged("FormId");
            }
        }

        /// <summary>
        ///     Indicates whether this component can be customized.
        /// </summary>
        [AttributeLogicalName("iscustomizable")]
        public BooleanManagedProperty IsCustomizable
        {
            get { return GetAttributeValue<BooleanManagedProperty>("iscustomizable"); }
            set
            {
                OnPropertyChanging("IsCustomizable");
                SetAttributeValue("iscustomizable", value);
                OnPropertyChanged("IsCustomizable");
            }
        }

        /// <summary>
        ///     Indicates whether the solution component is part of a managed solution.
        /// </summary>
        [AttributeLogicalName("ismanaged")]
        public bool? IsManaged
        {
            get { return GetAttributeValue<bool?>("ismanaged"); }
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
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("overwritetime")]
        public DateTime? OverwriteTime
        {
            get { return GetAttributeValue<DateTime?>("overwritetime"); }
        }

        /// <summary>
        ///     Enter the user or team who is assigned to manage the record. This field is updated every time the record is
        ///     assigned to a different user.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId
        {
            get { return GetAttributeValue<EntityReference>("ownerid"); }
        }

        /// <summary>
        ///     Select the business unit that owns the record.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public Guid? OwningBusinessUnit
        {
            get { return GetAttributeValue<Guid?>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier for the user that owns the record.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public Guid? OwningUser
        {
            get { return GetAttributeValue<Guid?>("owninguser"); }
        }

        /// <summary>
        ///     Primary entity for the process which is invoked by the event.
        /// </summary>
        [AttributeLogicalName("primaryentitytypecode")]
        public string PrimaryEntityTypeCode
        {
            get { return GetAttributeValue<string>("primaryentitytypecode"); }
            set
            {
                OnPropertyChanging("PrimaryEntityTypeCode");
                SetAttributeValue("primaryentitytypecode", value);
                OnPropertyChanged("PrimaryEntityTypeCode");
            }
        }

        /// <summary>
        ///     Shows the ID of the process.
        /// </summary>
        [AttributeLogicalName("processid")]
        public EntityReference ProcessId
        {
            get { return GetAttributeValue<EntityReference>("processid"); }
            set
            {
                OnPropertyChanging("ProcessId");
                SetAttributeValue("processid", value);
                OnPropertyChanged("ProcessId");
            }
        }

        /// <summary>
        ///     Unique identifier of the process trigger record.
        /// </summary>
        [AttributeLogicalName("processtriggerid")]
        public Guid? ProcessTriggerId
        {
            get { return GetAttributeValue<Guid?>("processtriggerid"); }
            set
            {
                OnPropertyChanging("ProcessTriggerId");
                SetAttributeValue("processtriggerid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ProcessTriggerId");
            }
        }

        [AttributeLogicalName("processtriggerid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ProcessTriggerId = value; }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("processtriggeridunique")]
        public Guid? ProcessTriggerIdUnique
        {
            get { return GetAttributeValue<Guid?>("processtriggeridunique"); }
        }

        /// <summary>
        ///     Unique identifier of the associated solution.
        /// </summary>
        [AttributeLogicalName("solutionid")]
        public Guid? SolutionId
        {
            get { return GetAttributeValue<Guid?>("solutionid"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     N:1 lk_processtriggerbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_processtriggerbase_createdby")]
        public SystemUser lk_processtriggerbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_processtriggerbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_processtriggerbase_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_processtriggerbase_createdonbehalfby")]
        public SystemUser lk_processtriggerbase_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_processtriggerbase_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_processtriggerbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_processtriggerbase_modifiedby")]
        public SystemUser lk_processtriggerbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_processtriggerbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_processtriggerbase_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_processtriggerbase_modifiedonbehalfby")]
        public SystemUser lk_processtriggerbase_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_processtriggerbase_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 process_processtrigger
        /// </summary>
        [AttributeLogicalName("processid")]
        [RelationshipSchemaName("process_processtrigger")]
        public Workflow process_processtrigger
        {
            get { return GetRelatedEntity<Workflow>("process_processtrigger", null); }
            set
            {
                OnPropertyChanging("process_processtrigger");
                SetRelatedEntity("process_processtrigger", null, value);
                OnPropertyChanged("process_processtrigger");
            }
        }

        /// <summary>
        ///     N:1 processtrigger_systemform
        /// </summary>
        [AttributeLogicalName("formid")]
        [RelationshipSchemaName("processtrigger_systemform")]
        public SystemForm processtrigger_systemform
        {
            get { return GetRelatedEntity<SystemForm>("processtrigger_systemform", null); }
            set
            {
                OnPropertyChanging("processtrigger_systemform");
                SetRelatedEntity("processtrigger_systemform", null, value);
                OnPropertyChanged("processtrigger_systemform");
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