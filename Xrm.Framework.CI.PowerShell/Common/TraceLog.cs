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
    ///     A trace log.
    /// </summary>
    [DataContract]
    [EntityLogicalName("tracelog")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class TraceLog : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "tracelog";

        public const int EntityTypeCode = 8050;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public TraceLog() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Indicates if this trace log can be deleted.
        /// </summary>
        [AttributeLogicalName("canbedeleted")]
        public bool? CanBeDeleted
        {
            get { return GetAttributeValue<bool?>("canbedeleted"); }
            set
            {
                OnPropertyChanging("CanBeDeleted");
                SetAttributeValue("canbedeleted", value);
                OnPropertyChanged("CanBeDeleted");
            }
        }

        /// <summary>
        ///     Indicates the collation level
        /// </summary>
        [AttributeLogicalName("collationlevel")]
        public int? CollationLevel
        {
            get { return GetAttributeValue<int?>("collationlevel"); }
            set
            {
                OnPropertyChanging("CollationLevel");
                SetAttributeValue("collationlevel", value);
                OnPropertyChanged("CollationLevel");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the trace.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the trace was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the trace.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Tells if this traceLog is created uniquely(only one) for the associated entity.
        /// </summary>
        [AttributeLogicalName("isunique")]
        public bool? IsUnique
        {
            get { return GetAttributeValue<bool?>("isunique"); }
            set
            {
                OnPropertyChanging("IsUnique");
                SetAttributeValue("isunique", value);
                OnPropertyChanged("IsUnique");
            }
        }

        /// <summary>
        ///     Information about the trace level.
        /// </summary>
        [AttributeLogicalName("level")]
        public OptionSetValue Level
        {
            get { return GetAttributeValue<OptionSetValue>("level"); }
            set
            {
                OnPropertyChanging("Level");
                SetAttributeValue("level", value);
                OnPropertyChanged("Level");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who modified the trace.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the trace was modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who modified the trace.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the organization associated with the trace.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     Indicates the parent ID of the trace log.
        /// </summary>
        [AttributeLogicalName("parenttracelogid")]
        public EntityReference ParentTraceLogId
        {
            get { return GetAttributeValue<EntityReference>("parenttracelogid"); }
            set
            {
                OnPropertyChanging("ParentTraceLogId");
                SetAttributeValue("parenttracelogid", value);
                OnPropertyChanged("ParentTraceLogId");
            }
        }

        /// <summary>
        ///     Unique identifier of the object the trace is regarding.
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
        ///     Unique identifier of the user or team who owns the regarding object.
        /// </summary>
        [AttributeLogicalName("regardingobjectownerid")]
        public EntityReference RegardingObjectOwnerId
        {
            get { return GetAttributeValue<EntityReference>("regardingobjectownerid"); }
        }

        /// <summary>
        ///     Unique identifier of the business unit that owns the regarding object.
        /// </summary>
        [AttributeLogicalName("regardingobjectowningbusinessunit")]
        public EntityReference RegardingObjectOwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("regardingobjectowningbusinessunit"); }
        }

        /// <summary>
        ///     Text of the trace.
        /// </summary>
        [AttributeLogicalName("text")]
        public string Text
        {
            get { return GetAttributeValue<string>("text"); }
            set
            {
                OnPropertyChanging("Text");
                SetAttributeValue("text", value);
                OnPropertyChanged("Text");
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
        ///     XML representation of the trace actions.
        /// </summary>
        [AttributeLogicalName("traceactionxml")]
        public string TraceActionXml
        {
            get { return GetAttributeValue<string>("traceactionxml"); }
            set
            {
                OnPropertyChanging("TraceActionXml");
                SetAttributeValue("traceactionxml", value);
                OnPropertyChanged("TraceActionXml");
            }
        }

        /// <summary>
        ///     Trace code for the trace.
        /// </summary>
        [AttributeLogicalName("tracecode")]
        public int? TraceCode
        {
            get { return GetAttributeValue<int?>("tracecode"); }
            set
            {
                OnPropertyChanging("TraceCode");
                SetAttributeValue("tracecode", value);
                OnPropertyChanged("TraceCode");
            }
        }

        /// <summary>
        ///     XML representation of the trace details.
        /// </summary>
        [AttributeLogicalName("tracedetailxml")]
        public string TraceDetailXml
        {
            get { return GetAttributeValue<string>("tracedetailxml"); }
            set
            {
                OnPropertyChanging("TraceDetailXml");
                SetAttributeValue("tracedetailxml", value);
                OnPropertyChanged("TraceDetailXml");
            }
        }

        /// <summary>
        ///     Unique identifier of the trace.
        /// </summary>
        [AttributeLogicalName("tracelogid")]
        public Guid? TraceLogId
        {
            get { return GetAttributeValue<Guid?>("tracelogid"); }
            set
            {
                OnPropertyChanging("TraceLogId");
                SetAttributeValue("tracelogid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("TraceLogId");
            }
        }

        [AttributeLogicalName("tracelogid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { TraceLogId = value; }
        }

        /// <summary>
        ///     Stores the hash of the entity object associated with this tracelog. Hash is computed using the object type code and
        ///     its id.
        /// </summary>
        [AttributeLogicalName("traceparameterhash")]
        public int? TraceParameterHash
        {
            get { return GetAttributeValue<int?>("traceparameterhash"); }
        }

        /// <summary>
        ///     XML representation of the trace parameters.
        /// </summary>
        [AttributeLogicalName("traceparameterxml")]
        public string TraceParameterXml
        {
            get { return GetAttributeValue<string>("traceparameterxml"); }
            set
            {
                OnPropertyChanging("TraceParameterXml");
                SetAttributeValue("traceparameterxml", value);
                OnPropertyChanged("TraceParameterXml");
            }
        }

        /// <summary>
        ///     Time zone code that was in use when the trace was created.
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
        ///     1:N tracelog_parent_tracelog
        /// </summary>
        [RelationshipSchemaName("tracelog_parent_tracelog", EntityRole.Referenced)]
        public IEnumerable<TraceLog> Referencedtracelog_parent_tracelog
        {
            get { return GetRelatedEntities<TraceLog>("tracelog_parent_tracelog", EntityRole.Referenced); }
            set
            {
                OnPropertyChanging("Referencedtracelog_parent_tracelog");
                SetRelatedEntities("tracelog_parent_tracelog", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedtracelog_parent_tracelog");
            }
        }

        /// <summary>
        ///     N:1 lk_tracelog_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_tracelog_createdby")]
        public SystemUser lk_tracelog_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_tracelog_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_tracelog_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_tracelog_createdonbehalfby")]
        public SystemUser lk_tracelog_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_tracelog_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_tracelog_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_tracelog_modifiedby")]
        public SystemUser lk_tracelog_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_tracelog_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_tracelog_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_tracelog_modifiedonbehalfby")]
        public SystemUser lk_tracelog_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_tracelog_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 organization_tracelog
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_tracelog")]
        public Organization organization_tracelog
        {
            get { return GetRelatedEntity<Organization>("organization_tracelog", null); }
        }

        /// <summary>
        ///     N:1 tracelog_EmailServerProfile
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("tracelog_EmailServerProfile")]
        public EmailServerProfile tracelog_EmailServerProfile
        {
            get { return GetRelatedEntity<EmailServerProfile>("tracelog_EmailServerProfile", null); }
            set
            {
                OnPropertyChanging("tracelog_EmailServerProfile");
                SetRelatedEntity("tracelog_EmailServerProfile", null, value);
                OnPropertyChanged("tracelog_EmailServerProfile");
            }
        }

        /// <summary>
        ///     N:1 tracelog_Mailbox
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("tracelog_Mailbox")]
        public Mailbox tracelog_Mailbox
        {
            get { return GetRelatedEntity<Mailbox>("tracelog_Mailbox", null); }
            set
            {
                OnPropertyChanging("tracelog_Mailbox");
                SetRelatedEntity("tracelog_Mailbox", null, value);
                OnPropertyChanged("tracelog_Mailbox");
            }
        }

        /// <summary>
        ///     N:1 tracelog_parent_tracelog
        /// </summary>
        [AttributeLogicalName("parenttracelogid")]
        [RelationshipSchemaName("tracelog_parent_tracelog", EntityRole.Referencing)]
        public TraceLog Referencingtracelog_parent_tracelog
        {
            get { return GetRelatedEntity<TraceLog>("tracelog_parent_tracelog", EntityRole.Referencing); }
            set
            {
                OnPropertyChanging("Referencingtracelog_parent_tracelog");
                SetRelatedEntity("tracelog_parent_tracelog", EntityRole.Referencing, value);
                OnPropertyChanged("Referencingtracelog_parent_tracelog");
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