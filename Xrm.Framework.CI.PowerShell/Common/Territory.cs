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
    ///     Territory represents sales regions.
    /// </summary>
    [DataContract]
    [EntityLogicalName("territory")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Territory : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "territory";

        public const int EntityTypeCode = 2013;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Territory() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the user who created the territory.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the territory was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the territory.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Description of the territory.
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
        ///     The default image for the entity.
        /// </summary>
        [AttributeLogicalName("entityimage")]
        public byte[] EntityImage
        {
            get { return GetAttributeValue<byte[]>("entityimage"); }
            set
            {
                OnPropertyChanging("EntityImage");
                SetAttributeValue("entityimage", value);
                OnPropertyChanged("EntityImage");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("entityimage_timestamp")]
        public long? EntityImage_Timestamp
        {
            get { return GetAttributeValue<long?>("entityimage_timestamp"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("entityimage_url")]
        public string EntityImage_URL
        {
            get { return GetAttributeValue<string>("entityimage_url"); }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("entityimageid")]
        public Guid? EntityImageId
        {
            get { return GetAttributeValue<Guid?>("entityimageid"); }
        }

        /// <summary>
        ///     Exchange rate for the currency associated with the territory with respect to the base currency.
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
        ///     Unique identifier of the manager of the territory.
        /// </summary>
        [AttributeLogicalName("managerid")]
        public EntityReference ManagerId
        {
            get { return GetAttributeValue<EntityReference>("managerid"); }
            set
            {
                OnPropertyChanging("ManagerId");
                SetAttributeValue("managerid", value);
                OnPropertyChanged("ManagerId");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the territory.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the territory was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the territory.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the territory.
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
        ///     Unique identifier of the organization associated with the territory.
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
        ///     Unique identifier of the territory.
        /// </summary>
        [AttributeLogicalName("territoryid")]
        public Guid? TerritoryId
        {
            get { return GetAttributeValue<Guid?>("territoryid"); }
            set
            {
                OnPropertyChanging("TerritoryId");
                SetAttributeValue("territoryid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("TerritoryId");
            }
        }

        [AttributeLogicalName("territoryid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { TerritoryId = value; }
        }

        /// <summary>
        ///     Unique identifier of the currency associated with the territory.
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
        ///     Version number of the territory.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N territory_accounts
        /// </summary>
        [RelationshipSchemaName("territory_accounts")]
        public IEnumerable<Account> territory_accounts
        {
            get { return GetRelatedEntities<Account>("territory_accounts", null); }
            set
            {
                OnPropertyChanging("territory_accounts");
                SetRelatedEntities("territory_accounts", null, value);
                OnPropertyChanged("territory_accounts");
            }
        }

        /// <summary>
        ///     1:N Territory_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Territory_AsyncOperations")]
        public IEnumerable<AsyncOperation> Territory_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Territory_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Territory_AsyncOperations");
                SetRelatedEntities("Territory_AsyncOperations", null, value);
                OnPropertyChanged("Territory_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N Territory_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("Territory_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> Territory_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("Territory_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("Territory_BulkDeleteFailures");
                SetRelatedEntities("Territory_BulkDeleteFailures", null, value);
                OnPropertyChanged("Territory_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N Territory_DuplicateBaseRecord
        /// </summary>
        [RelationshipSchemaName("Territory_DuplicateBaseRecord")]
        public IEnumerable<DuplicateRecord> Territory_DuplicateBaseRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Territory_DuplicateBaseRecord", null); }
            set
            {
                OnPropertyChanging("Territory_DuplicateBaseRecord");
                SetRelatedEntities("Territory_DuplicateBaseRecord", null, value);
                OnPropertyChanged("Territory_DuplicateBaseRecord");
            }
        }

        /// <summary>
        ///     1:N Territory_DuplicateMatchingRecord
        /// </summary>
        [RelationshipSchemaName("Territory_DuplicateMatchingRecord")]
        public IEnumerable<DuplicateRecord> Territory_DuplicateMatchingRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Territory_DuplicateMatchingRecord", null); }
            set
            {
                OnPropertyChanging("Territory_DuplicateMatchingRecord");
                SetRelatedEntities("Territory_DuplicateMatchingRecord", null, value);
                OnPropertyChanged("Territory_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        ///     1:N territory_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("territory_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> territory_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntities<PrincipalObjectAttributeAccess>("territory_principalobjectattributeaccess",
                    null);
            }
            set
            {
                OnPropertyChanging("territory_principalobjectattributeaccess");
                SetRelatedEntities("territory_principalobjectattributeaccess", null, value);
                OnPropertyChanged("territory_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N Territory_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("Territory_ProcessSessions")]
        public IEnumerable<ProcessSession> Territory_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("Territory_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Territory_ProcessSessions");
                SetRelatedEntities("Territory_ProcessSessions", null, value);
                OnPropertyChanged("Territory_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N territory_system_users
        /// </summary>
        [RelationshipSchemaName("territory_system_users")]
        public IEnumerable<SystemUser> territory_system_users
        {
            get { return GetRelatedEntities<SystemUser>("territory_system_users", null); }
            set
            {
                OnPropertyChanging("territory_system_users");
                SetRelatedEntities("territory_system_users", null, value);
                OnPropertyChanged("territory_system_users");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_territory
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_territory")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_territory
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_territory", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_territory");
                SetRelatedEntities("userentityinstancedata_territory", null, value);
                OnPropertyChanged("userentityinstancedata_territory");
            }
        }

        /// <summary>
        ///     N:1 lk_territory_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_territory_createdonbehalfby")]
        public SystemUser lk_territory_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_territory_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_territory_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_territory_modifiedonbehalfby")]
        public SystemUser lk_territory_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_territory_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_territorybase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_territorybase_createdby")]
        public SystemUser lk_territorybase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_territorybase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_territorybase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_territorybase_modifiedby")]
        public SystemUser lk_territorybase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_territorybase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 organization_territories
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_territories")]
        public Organization organization_territories
        {
            get { return GetRelatedEntity<Organization>("organization_territories", null); }
        }

        /// <summary>
        ///     N:1 system_user_territories
        /// </summary>
        [AttributeLogicalName("managerid")]
        [RelationshipSchemaName("system_user_territories")]
        public SystemUser system_user_territories
        {
            get { return GetRelatedEntity<SystemUser>("system_user_territories", null); }
            set
            {
                OnPropertyChanging("system_user_territories");
                SetRelatedEntity("system_user_territories", null, value);
                OnPropertyChanged("system_user_territories");
            }
        }

        /// <summary>
        ///     N:1 TransactionCurrency_Territory
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("TransactionCurrency_Territory")]
        public TransactionCurrency TransactionCurrency_Territory
        {
            get { return GetRelatedEntity<TransactionCurrency>("TransactionCurrency_Territory", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_Territory");
                SetRelatedEntity("TransactionCurrency_Territory", null, value);
                OnPropertyChanged("TransactionCurrency_Territory");
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