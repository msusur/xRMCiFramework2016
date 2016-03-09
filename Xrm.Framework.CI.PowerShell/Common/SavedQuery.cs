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
    ///     Saved query against the database.
    /// </summary>
    [DataContract]
    [EntityLogicalName("savedquery")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class SavedQuery : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "savedquery";

        public const int EntityTypeCode = 1039;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public SavedQuery() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Type the column name that will be used to group the results from the data collected across multiple records from a
        ///     system view.
        /// </summary>
        [AttributeLogicalName("advancedgroupby")]
        public string AdvancedGroupBy
        {
            get { return GetAttributeValue<string>("advancedgroupby"); }
            set
            {
                OnPropertyChanging("AdvancedGroupBy");
                SetAttributeValue("advancedgroupby", value);
                OnPropertyChanged("AdvancedGroupBy");
            }
        }

        /// <summary>
        ///     Tells whether the view can be deleted.
        /// </summary>
        [AttributeLogicalName("canbedeleted")]
        public BooleanManagedProperty CanBeDeleted
        {
            get { return GetAttributeValue<BooleanManagedProperty>("canbedeleted"); }
            set
            {
                OnPropertyChanging("CanBeDeleted");
                SetAttributeValue("canbedeleted", value);
                OnPropertyChanged("CanBeDeleted");
            }
        }

        /// <summary>
        ///     Contains the columns and sorting criteria for the view, stored in XML format.
        /// </summary>
        [AttributeLogicalName("columnsetxml")]
        public string ColumnSetXml
        {
            get { return GetAttributeValue<string>("columnsetxml"); }
            set
            {
                OnPropertyChanging("ColumnSetXml");
                SetAttributeValue("columnsetxml", value);
                OnPropertyChanged("ColumnSetXml");
            }
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
        ///     Type information about how the items in the system view are formatted.
        /// </summary>
        [AttributeLogicalName("conditionalformatting")]
        public string ConditionalFormatting
        {
            get { return GetAttributeValue<string>("conditionalformatting"); }
            set
            {
                OnPropertyChanging("ConditionalFormatting");
                SetAttributeValue("conditionalformatting", value);
                OnPropertyChanged("ConditionalFormatting");
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
        ///     Type additional information to describe the view, such as the filter criteria or intended results set.
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
        ///     String specifying the query in Fetch XML language.
        /// </summary>
        [AttributeLogicalName("fetchxml")]
        public string FetchXml
        {
            get { return GetAttributeValue<string>("fetchxml"); }
            set
            {
                OnPropertyChanging("FetchXml");
                SetAttributeValue("fetchxml", value);
                OnPropertyChanged("FetchXml");
            }
        }

        /// <summary>
        ///     Version in which the form is introduced.
        /// </summary>
        [AttributeLogicalName("introducedversion")]
        public string IntroducedVersion
        {
            get { return GetAttributeValue<string>("introducedversion"); }
            set
            {
                OnPropertyChanging("IntroducedVersion");
                SetAttributeValue("introducedversion", value);
                OnPropertyChanged("IntroducedVersion");
            }
        }

        /// <summary>
        ///     Tells whether the component can be customized.
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
        ///     Tells whether the view is the default view for the specified record type (entity).
        /// </summary>
        [AttributeLogicalName("isdefault")]
        public bool? IsDefault
        {
            get { return GetAttributeValue<bool?>("isdefault"); }
            set
            {
                OnPropertyChanging("IsDefault");
                SetAttributeValue("isdefault", value);
                OnPropertyChanged("IsDefault");
            }
        }

        /// <summary>
        ///     Tells whether the record is part of a managed solution.
        /// </summary>
        [AttributeLogicalName("ismanaged")]
        public bool? IsManaged
        {
            get { return GetAttributeValue<bool?>("ismanaged"); }
        }

        /// <summary>
        ///     Indicates whether or not this is viewable by the entire organization.
        /// </summary>
        [AttributeLogicalName("isprivate")]
        [Obsolete]
        public bool? IsPrivate
        {
            get { return GetAttributeValue<bool?>("isprivate"); }
        }

        /// <summary>
        ///     Choose whether the view is compatible with Quick Find. When users search for specific items, you define the fields
        ///     that are searched in.
        /// </summary>
        [AttributeLogicalName("isquickfindquery")]
        public bool? IsQuickFindQuery
        {
            get { return GetAttributeValue<bool?>("isquickfindquery"); }
            set
            {
                OnPropertyChanging("IsQuickFindQuery");
                SetAttributeValue("isquickfindquery", value);
                OnPropertyChanged("IsQuickFindQuery");
            }
        }

        /// <summary>
        ///     Tells whether the view was created by a user.
        /// </summary>
        [AttributeLogicalName("isuserdefined")]
        public bool? IsUserDefined
        {
            get { return GetAttributeValue<bool?>("isuserdefined"); }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("layoutxml")]
        public string LayoutXml
        {
            get { return GetAttributeValue<string>("layoutxml"); }
            set
            {
                OnPropertyChanging("LayoutXml");
                SetAttributeValue("layoutxml", value);
                OnPropertyChanged("LayoutXml");
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
        ///     Type a name for the view to describe what results the view will contain. This name is visible to users in the View
        ///     list.
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
        ///     Choose the ID of the organization that the record is associated with.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     For the organization, type the tab order to determine how users navigate through the screen using only the Tab key.
        /// </summary>
        [AttributeLogicalName("organizationtaborder")]
        public int? OrganizationTabOrder
        {
            get { return GetAttributeValue<int?>("organizationtaborder"); }
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
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("queryapi")]
        public string QueryAPI
        {
            get { return GetAttributeValue<string>("queryapi"); }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("queryappusage")]
        public int? QueryAppUsage
        {
            get { return GetAttributeValue<int?>("queryappusage"); }
            set
            {
                OnPropertyChanging("QueryAppUsage");
                SetAttributeValue("queryappusage", value);
                OnPropertyChanged("QueryAppUsage");
            }
        }

        /// <summary>
        ///     Shows the type of the query.
        /// </summary>
        [AttributeLogicalName("querytype")]
        public int? QueryType
        {
            get { return GetAttributeValue<int?>("querytype"); }
            set
            {
                OnPropertyChanging("QueryType");
                SetAttributeValue("querytype", value);
                OnPropertyChanged("QueryType");
            }
        }

        /// <summary>
        ///     Type of entity displayed in the view.
        /// </summary>
        [AttributeLogicalName("returnedtypecode")]
        public string ReturnedTypeCode
        {
            get { return GetAttributeValue<string>("returnedtypecode"); }
            set
            {
                OnPropertyChanging("ReturnedTypeCode");
                SetAttributeValue("returnedtypecode", value);
                OnPropertyChanged("ReturnedTypeCode");
            }
        }

        /// <summary>
        ///     Unique identifier of the view.
        /// </summary>
        [AttributeLogicalName("savedqueryid")]
        public Guid? SavedQueryId
        {
            get { return GetAttributeValue<Guid?>("savedqueryid"); }
            set
            {
                OnPropertyChanging("SavedQueryId");
                SetAttributeValue("savedqueryid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("SavedQueryId");
            }
        }

        [AttributeLogicalName("savedqueryid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { SavedQueryId = value; }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("savedqueryidunique")]
        public Guid? SavedQueryIdUnique
        {
            get { return GetAttributeValue<Guid?>("savedqueryidunique"); }
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
        ///     Shows the status of the view.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public SavedQueryState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((SavedQueryState) (Enum.ToObject(typeof (SavedQueryState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Shows the reason code that explains the status of the record.
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
        ///     Version number of the view.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N SavedQuery_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("SavedQuery_AsyncOperations")]
        public IEnumerable<AsyncOperation> SavedQuery_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("SavedQuery_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("SavedQuery_AsyncOperations");
                SetRelatedEntities("SavedQuery_AsyncOperations", null, value);
                OnPropertyChanged("SavedQuery_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N SavedQuery_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("SavedQuery_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> SavedQuery_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("SavedQuery_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("SavedQuery_BulkDeleteFailures");
                SetRelatedEntities("SavedQuery_BulkDeleteFailures", null, value);
                OnPropertyChanged("SavedQuery_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_savedquery
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_savedquery")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_savedquery
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_savedquery", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_savedquery");
                SetRelatedEntities("userentityinstancedata_savedquery", null, value);
                OnPropertyChanged("userentityinstancedata_savedquery");
            }
        }

        /// <summary>
        ///     N:1 lk_savedquery_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_savedquery_createdonbehalfby")]
        public SystemUser lk_savedquery_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_savedquery_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_savedquery_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_savedquery_modifiedonbehalfby")]
        public SystemUser lk_savedquery_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_savedquery_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_savedquerybase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_savedquerybase_createdby")]
        public SystemUser lk_savedquerybase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_savedquerybase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_savedquerybase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_savedquerybase_modifiedby")]
        public SystemUser lk_savedquerybase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_savedquerybase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 organization_saved_queries
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_saved_queries")]
        public Organization organization_saved_queries
        {
            get { return GetRelatedEntity<Organization>("organization_saved_queries", null); }
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