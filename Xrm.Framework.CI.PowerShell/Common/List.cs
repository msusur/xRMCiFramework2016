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
    ///     Group of existing or potential customers created for a marketing campaign or other sales purposes.
    /// </summary>
    [DataContract]
    [EntityLogicalName("list")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class List : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "list";

        public const int EntityTypeCode = 4300;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public List() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Type the cost of obtaining the marketing list.
        /// </summary>
        [AttributeLogicalName("cost")]
        public Money Cost
        {
            get { return GetAttributeValue<Money>("cost"); }
            set
            {
                OnPropertyChanging("Cost");
                SetAttributeValue("cost", value);
                OnPropertyChanged("Cost");
            }
        }

        /// <summary>
        ///     Shows the Cost field converted to the system's default base currency for reporting purposes. The calculation uses
        ///     the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("cost_base")]
        public Money Cost_Base
        {
            get { return GetAttributeValue<Money>("cost_base"); }
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
        ///     Select the type of members that this marketing list will contain: accounts, contacts, or leads. Each list can have
        ///     only one member type and this value can't be changed after the marketing list is created.
        /// </summary>
        [AttributeLogicalName("createdfromcode")]
        public OptionSetValue CreatedFromCode
        {
            get { return GetAttributeValue<OptionSetValue>("createdfromcode"); }
            set
            {
                OnPropertyChanging("CreatedFromCode");
                SetAttributeValue("createdfromcode", value);
                OnPropertyChanged("CreatedFromCode");
            }
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
        ///     Type additional information to describe the marketing list, such as the intended use or date of the last update.
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
        ///     Select whether to override the opt-out settings on leads, contacts, and accounts for the members of the target
        ///     marketing lists of the campaign activity. If No is selected, those who have chosen to opt out won't be excluded
        ///     from the list. This means they will receive marketing materials.
        /// </summary>
        [AttributeLogicalName("donotsendonoptout")]
        public bool? DoNotSendOnOptOut
        {
            get { return GetAttributeValue<bool?>("donotsendonoptout"); }
            set
            {
                OnPropertyChanging("DoNotSendOnOptOut");
                SetAttributeValue("donotsendonoptout", value);
                OnPropertyChanged("DoNotSendOnOptOut");
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
        ///     Select whether inactive accounts, contacts, or leads should be excluded from the campaign activity distribution
        ///     when the marketing list is included in a campaign.
        /// </summary>
        [AttributeLogicalName("ignoreinactivelistmembers")]
        public bool? IgnoreInactiveListMembers
        {
            get { return GetAttributeValue<bool?>("ignoreinactivelistmembers"); }
            set
            {
                OnPropertyChanging("IgnoreInactiveListMembers");
                SetAttributeValue("ignoreinactivelistmembers", value);
                OnPropertyChanged("IgnoreInactiveListMembers");
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
        ///     Shows the date and time when the marketing list was last used in a campaign or in the creation of activities or
        ///     opportunities.
        /// </summary>
        [AttributeLogicalName("lastusedon")]
        public DateTime? LastUsedOn
        {
            get { return GetAttributeValue<DateTime?>("lastusedon"); }
        }

        /// <summary>
        ///     Unique identifier of the marketing list.
        /// </summary>
        [AttributeLogicalName("listid")]
        public Guid? ListId
        {
            get { return GetAttributeValue<Guid?>("listid"); }
            set
            {
                OnPropertyChanging("ListId");
                SetAttributeValue("listid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ListId");
            }
        }

        [AttributeLogicalName("listid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ListId = value; }
        }

        /// <summary>
        ///     Type a name for the marketing list so that it is identified correctly in lists.
        /// </summary>
        [AttributeLogicalName("listname")]
        public string ListName
        {
            get { return GetAttributeValue<string>("listname"); }
            set
            {
                OnPropertyChanging("ListName");
                SetAttributeValue("listname", value);
                OnPropertyChanged("ListName");
            }
        }

        /// <summary>
        ///     Select whether the marketing list is locked. If Yes is selected, no additional members can be added to the
        ///     marketing list.
        /// </summary>
        [AttributeLogicalName("lockstatus")]
        public bool? LockStatus
        {
            get { return GetAttributeValue<bool?>("lockstatus"); }
            set
            {
                OnPropertyChanging("LockStatus");
                SetAttributeValue("lockstatus", value);
                OnPropertyChanged("LockStatus");
            }
        }

        /// <summary>
        ///     Shows the sum of all members in the marketing list.
        /// </summary>
        [AttributeLogicalName("membercount")]
        public int? MemberCount
        {
            get { return GetAttributeValue<int?>("membercount"); }
        }

        /// <summary>
        ///     Type of the members that can be stored in the marketing list.
        /// </summary>
        [AttributeLogicalName("membertype")]
        public int? MemberType
        {
            get { return GetAttributeValue<int?>("membertype"); }
            set
            {
                OnPropertyChanging("MemberType");
                SetAttributeValue("membertype", value);
                OnPropertyChanged("MemberType");
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
        ///     Unique identifier of the business unit that owns the marketing list.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the marketing list.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the marketing list.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Shows the ID of the process.
        /// </summary>
        [AttributeLogicalName("processid")]
        public Guid? ProcessId
        {
            get { return GetAttributeValue<Guid?>("processid"); }
            set
            {
                OnPropertyChanging("ProcessId");
                SetAttributeValue("processid", value);
                OnPropertyChanged("ProcessId");
            }
        }

        /// <summary>
        ///     Type the intended use of the marketing list to identify its key segments, target offers, or business group.
        /// </summary>
        [AttributeLogicalName("purpose")]
        public string Purpose
        {
            get { return GetAttributeValue<string>("purpose"); }
            set
            {
                OnPropertyChanging("Purpose");
                SetAttributeValue("purpose", value);
                OnPropertyChanged("Purpose");
            }
        }

        /// <summary>
        ///     Query used for retrieving members of marketing list.
        /// </summary>
        [AttributeLogicalName("query")]
        public string Query
        {
            get { return GetAttributeValue<string>("query"); }
            set
            {
                OnPropertyChanging("Query");
                SetAttributeValue("query", value);
                OnPropertyChanged("Query");
            }
        }

        /// <summary>
        ///     Type the source of the marketing list, such as a third-party supplier or internal database.
        /// </summary>
        [AttributeLogicalName("source")]
        public string Source
        {
            get { return GetAttributeValue<string>("source"); }
            set
            {
                OnPropertyChanging("Source");
                SetAttributeValue("source", value);
                OnPropertyChanged("Source");
            }
        }

        /// <summary>
        ///     Shows the ID of the stage.
        /// </summary>
        [AttributeLogicalName("stageid")]
        public Guid? StageId
        {
            get { return GetAttributeValue<Guid?>("stageid"); }
            set
            {
                OnPropertyChanging("StageId");
                SetAttributeValue("stageid", value);
                OnPropertyChanged("StageId");
            }
        }

        /// <summary>
        ///     Shows whether the marketing list is active or inactive. Inactive marketing lists are read-only and can't be edited
        ///     unless they are reactivated.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public ListState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ListState) (Enum.ToObject(typeof (ListState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Select the marketing list's status.
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
        ///     Select whether you want the marketing list to be static or dynamic. The members in a static marketing list are
        ///     unchanging. A dynamic marketing list is based on a dynamic query that retrieves the updated list of members
        /// </summary>
        [AttributeLogicalName("type")]
        public bool? Type
        {
            get { return GetAttributeValue<bool?>("type"); }
            set
            {
                OnPropertyChanging("Type");
                SetAttributeValue("type", value);
                OnPropertyChanged("Type");
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
        ///     Version number of the marketing list.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N List_Annotation
        /// </summary>
        [RelationshipSchemaName("List_Annotation")]
        public IEnumerable<Annotation> List_Annotation
        {
            get { return GetRelatedEntities<Annotation>("List_Annotation", null); }
            set
            {
                OnPropertyChanging("List_Annotation");
                SetRelatedEntities("List_Annotation", null, value);
                OnPropertyChanged("List_Annotation");
            }
        }

        /// <summary>
        ///     1:N List_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("List_AsyncOperations")]
        public IEnumerable<AsyncOperation> List_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("List_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("List_AsyncOperations");
                SetRelatedEntities("List_AsyncOperations", null, value);
                OnPropertyChanged("List_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N List_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("List_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> List_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("List_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("List_BulkDeleteFailures");
                SetRelatedEntities("List_BulkDeleteFailures", null, value);
                OnPropertyChanged("List_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N List_BulkOperations
        /// </summary>
        [RelationshipSchemaName("List_BulkOperations")]
        public IEnumerable<BulkOperation> List_BulkOperations
        {
            get { return GetRelatedEntities<BulkOperation>("List_BulkOperations", null); }
            set
            {
                OnPropertyChanging("List_BulkOperations");
                SetRelatedEntities("List_BulkOperations", null, value);
                OnPropertyChanged("List_BulkOperations");
            }
        }

        /// <summary>
        ///     1:N list_connections1
        /// </summary>
        [RelationshipSchemaName("list_connections1")]
        public IEnumerable<Connection> list_connections1
        {
            get { return GetRelatedEntities<Connection>("list_connections1", null); }
            set
            {
                OnPropertyChanging("list_connections1");
                SetRelatedEntities("list_connections1", null, value);
                OnPropertyChanged("list_connections1");
            }
        }

        /// <summary>
        ///     1:N list_connections2
        /// </summary>
        [RelationshipSchemaName("list_connections2")]
        public IEnumerable<Connection> list_connections2
        {
            get { return GetRelatedEntities<Connection>("list_connections2", null); }
            set
            {
                OnPropertyChanging("list_connections2");
                SetRelatedEntities("list_connections2", null, value);
                OnPropertyChanged("list_connections2");
            }
        }

        /// <summary>
        ///     1:N List_DuplicateBaseRecord
        /// </summary>
        [RelationshipSchemaName("List_DuplicateBaseRecord")]
        public IEnumerable<DuplicateRecord> List_DuplicateBaseRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("List_DuplicateBaseRecord", null); }
            set
            {
                OnPropertyChanging("List_DuplicateBaseRecord");
                SetRelatedEntities("List_DuplicateBaseRecord", null, value);
                OnPropertyChanged("List_DuplicateBaseRecord");
            }
        }

        /// <summary>
        ///     1:N List_DuplicateMatchingRecord
        /// </summary>
        [RelationshipSchemaName("List_DuplicateMatchingRecord")]
        public IEnumerable<DuplicateRecord> List_DuplicateMatchingRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("List_DuplicateMatchingRecord", null); }
            set
            {
                OnPropertyChanging("List_DuplicateMatchingRecord");
                SetRelatedEntities("List_DuplicateMatchingRecord", null, value);
                OnPropertyChanged("List_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        ///     1:N list_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("list_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> list_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntities<PrincipalObjectAttributeAccess>("list_principalobjectattributeaccess", null);
            }
            set
            {
                OnPropertyChanging("list_principalobjectattributeaccess");
                SetRelatedEntities("list_principalobjectattributeaccess", null, value);
                OnPropertyChanged("list_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N List_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("List_ProcessSessions")]
        public IEnumerable<ProcessSession> List_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("List_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("List_ProcessSessions");
                SetRelatedEntities("List_ProcessSessions", null, value);
                OnPropertyChanged("List_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_list
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_list")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_list
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_list", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_list");
                SetRelatedEntities("userentityinstancedata_list", null, value);
                OnPropertyChanged("userentityinstancedata_list");
            }
        }

        /// <summary>
        ///     N:N campaignactivitylist_association
        /// </summary>
        [RelationshipSchemaName("campaignactivitylist_association")]
        public IEnumerable<CampaignActivity> campaignactivitylist_association
        {
            get { return GetRelatedEntities<CampaignActivity>("campaignactivitylist_association", null); }
            set
            {
                OnPropertyChanging("campaignactivitylist_association");
                SetRelatedEntities("campaignactivitylist_association", null, value);
                OnPropertyChanged("campaignactivitylist_association");
            }
        }

        /// <summary>
        ///     N:N campaignlist_association
        /// </summary>
        [RelationshipSchemaName("campaignlist_association")]
        public IEnumerable<Campaign> campaignlist_association
        {
            get { return GetRelatedEntities<Campaign>("campaignlist_association", null); }
            set
            {
                OnPropertyChanging("campaignlist_association");
                SetRelatedEntities("campaignlist_association", null, value);
                OnPropertyChanged("campaignlist_association");
            }
        }

        /// <summary>
        ///     N:N listaccount_association
        /// </summary>
        [RelationshipSchemaName("listaccount_association")]
        public IEnumerable<Account> listaccount_association
        {
            get { return GetRelatedEntities<Account>("listaccount_association", null); }
            set
            {
                OnPropertyChanging("listaccount_association");
                SetRelatedEntities("listaccount_association", null, value);
                OnPropertyChanged("listaccount_association");
            }
        }

        /// <summary>
        ///     N:N listcontact_association
        /// </summary>
        [RelationshipSchemaName("listcontact_association")]
        public IEnumerable<Contact> listcontact_association
        {
            get { return GetRelatedEntities<Contact>("listcontact_association", null); }
            set
            {
                OnPropertyChanging("listcontact_association");
                SetRelatedEntities("listcontact_association", null, value);
                OnPropertyChanged("listcontact_association");
            }
        }

        /// <summary>
        ///     N:N listlead_association
        /// </summary>
        [RelationshipSchemaName("listlead_association")]
        public IEnumerable<Lead> listlead_association
        {
            get { return GetRelatedEntities<Lead>("listlead_association", null); }
            set
            {
                OnPropertyChanging("listlead_association");
                SetRelatedEntities("listlead_association", null, value);
                OnPropertyChanged("listlead_association");
            }
        }

        /// <summary>
        ///     N:1 business_unit_list
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_list")]
        public BusinessUnit business_unit_list
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_list", null); }
        }

        /// <summary>
        ///     N:1 lk_list_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_list_createdby")]
        public SystemUser lk_list_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_list_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_list_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_list_createdonbehalfby")]
        public SystemUser lk_list_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_list_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_list_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_list_modifiedby")]
        public SystemUser lk_list_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_list_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_list_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_list_modifiedonbehalfby")]
        public SystemUser lk_list_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_list_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 processstage_lists
        /// </summary>
        [AttributeLogicalName("stageid")]
        [RelationshipSchemaName("processstage_lists")]
        public ProcessStage processstage_lists
        {
            get { return GetRelatedEntity<ProcessStage>("processstage_lists", null); }
            set
            {
                OnPropertyChanging("processstage_lists");
                SetRelatedEntity("processstage_lists", null, value);
                OnPropertyChanged("processstage_lists");
            }
        }

        /// <summary>
        ///     N:1 team_list
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_list")]
        public Team team_list
        {
            get { return GetRelatedEntity<Team>("team_list", null); }
        }

        /// <summary>
        ///     N:1 transactioncurrency_list
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("transactioncurrency_list")]
        public TransactionCurrency transactioncurrency_list
        {
            get { return GetRelatedEntity<TransactionCurrency>("transactioncurrency_list", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_list");
                SetRelatedEntity("transactioncurrency_list", null, value);
                OnPropertyChanged("transactioncurrency_list");
            }
        }

        /// <summary>
        ///     N:1 user_list
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_list")]
        public SystemUser user_list
        {
            get { return GetRelatedEntity<SystemUser>("user_list", null); }
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