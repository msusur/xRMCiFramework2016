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
    ///     Saved database query that is owned by a user.
    /// </summary>
    [DataContract]
    [EntityLogicalName("userquery")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class UserQuery : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "userquery";

        public const int EntityTypeCode = 4230;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public UserQuery() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Type the column name that will be used to group the results from the data collected across multiple records from a
        ///     user view.
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
        ///     Shows the columns and sorting criteria for the saved view, stored in XML format.
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
        ///     Type information about how the items in the user view are formatted.
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
        ///     Type additional information to describe the saved view, such as the filter criteria or intended results set.
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
        ///     Contains the Fetch XML query that defines the entities and attributes included in the saved view.
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
        ///     Type a descriptive name for the saved view.
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
        ///     Unique identifier of the team who owns this saved view.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns this saved view.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Choose the ID of the saved query that the record was created from.
        /// </summary>
        [AttributeLogicalName("parentqueryid")]
        public EntityReference ParentQueryId
        {
            get { return GetAttributeValue<EntityReference>("parentqueryid"); }
            set
            {
                OnPropertyChanging("ParentQueryId");
                SetAttributeValue("parentqueryid", value);
                OnPropertyChanged("ParentQueryId");
            }
        }

        /// <summary>
        ///     Shows the code for the query type to indicate whether the saved view is an address book filter, advanced search, or
        ///     other view.
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
        ///     Type of entity that the saved view displays.
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
        ///     Shows whether the saved view is active or inactive.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public UserQueryState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((UserQueryState) (Enum.ToObject(typeof (UserQueryState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Select the item's status.
        /// </summary>
        [AttributeLogicalName("statuscode")]
        public OptionSetValue StatusCode
        {
            get { return GetAttributeValue<OptionSetValue>("statuscode"); }
        }

        /// <summary>
        ///     Unique identifier of the saved view.
        /// </summary>
        [AttributeLogicalName("userqueryid")]
        public Guid? UserQueryId
        {
            get { return GetAttributeValue<Guid?>("userqueryid"); }
            set
            {
                OnPropertyChanging("UserQueryId");
                SetAttributeValue("userqueryid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("UserQueryId");
            }
        }

        [AttributeLogicalName("userqueryid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { UserQueryId = value; }
        }

        /// <summary>
        ///     Version number of the saved view.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N userentityinstancedata_userquery
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_userquery")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_userquery
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_userquery", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_userquery");
                SetRelatedEntities("userentityinstancedata_userquery", null, value);
                OnPropertyChanged("userentityinstancedata_userquery");
            }
        }

        /// <summary>
        ///     1:N UserQuery_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("UserQuery_AsyncOperations")]
        public IEnumerable<AsyncOperation> UserQuery_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("UserQuery_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("UserQuery_AsyncOperations");
                SetRelatedEntities("UserQuery_AsyncOperations", null, value);
                OnPropertyChanged("UserQuery_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N UserQuery_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("UserQuery_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> UserQuery_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("UserQuery_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("UserQuery_BulkDeleteFailures");
                SetRelatedEntities("UserQuery_BulkDeleteFailures", null, value);
                OnPropertyChanged("UserQuery_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     N:1 business_unit_userquery
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_userquery")]
        public BusinessUnit business_unit_userquery
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_userquery", null); }
        }

        /// <summary>
        ///     N:1 lk_userquery_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_userquery_createdby")]
        public SystemUser lk_userquery_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_userquery_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_userquery_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_userquery_createdonbehalfby")]
        public SystemUser lk_userquery_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_userquery_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_userquery_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_userquery_modifiedby")]
        public SystemUser lk_userquery_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_userquery_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_userquery_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_userquery_modifiedonbehalfby")]
        public SystemUser lk_userquery_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_userquery_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 team_userquery
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_userquery")]
        public Team team_userquery
        {
            get { return GetRelatedEntity<Team>("team_userquery", null); }
        }

        /// <summary>
        ///     N:1 user_userquery
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_userquery")]
        public SystemUser user_userquery
        {
            get { return GetRelatedEntity<SystemUser>("user_userquery", null); }
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