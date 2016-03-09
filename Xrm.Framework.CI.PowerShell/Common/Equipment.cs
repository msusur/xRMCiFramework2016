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
    ///     Resource that can be scheduled.
    /// </summary>
    [DataContract]
    [EntityLogicalName("equipment")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Equipment : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "equipment";

        public const int EntityTypeCode = 4000;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Equipment() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the associated business unit.
        /// </summary>
        [AttributeLogicalName("businessunitid")]
        public EntityReference BusinessUnitId
        {
            get { return GetAttributeValue<EntityReference>("businessunitid"); }
            set
            {
                OnPropertyChanging("BusinessUnitId");
                SetAttributeValue("businessunitid", value);
                OnPropertyChanged("BusinessUnitId");
            }
        }

        /// <summary>
        ///     Fiscal calendar associated with the facility/equipment.
        /// </summary>
        [AttributeLogicalName("calendarid")]
        public EntityReference CalendarId
        {
            get { return GetAttributeValue<EntityReference>("calendarid"); }
            set
            {
                OnPropertyChanging("CalendarId");
                SetAttributeValue("calendarid", value);
                OnPropertyChanged("CalendarId");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the facility/equipment entry.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the facility/equipment entry was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the equipment.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Description of the facility/equipment.
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
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("displayinserviceviews")]
        public bool? DisplayInServiceViews
        {
            get { return GetAttributeValue<bool?>("displayinserviceviews"); }
            set
            {
                OnPropertyChanging("DisplayInServiceViews");
                SetAttributeValue("displayinserviceviews", value);
                OnPropertyChanged("DisplayInServiceViews");
            }
        }

        /// <summary>
        ///     Email address of person to contact about the use of the facility/equipment.
        /// </summary>
        [AttributeLogicalName("emailaddress")]
        public string EMailAddress
        {
            get { return GetAttributeValue<string>("emailaddress"); }
            set
            {
                OnPropertyChanging("EMailAddress");
                SetAttributeValue("emailaddress", value);
                OnPropertyChanged("EMailAddress");
            }
        }

        /// <summary>
        ///     Unique identifier of the facility/equipment.
        /// </summary>
        [AttributeLogicalName("equipmentid")]
        public Guid? EquipmentId
        {
            get { return GetAttributeValue<Guid?>("equipmentid"); }
            set
            {
                OnPropertyChanging("EquipmentId");
                SetAttributeValue("equipmentid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("EquipmentId");
            }
        }

        [AttributeLogicalName("equipmentid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { EquipmentId = value; }
        }

        /// <summary>
        ///     Exchange rate for the currency associated with the equipment with respect to the base currency.
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
        ///     Whether the facility/equipment is disabled or operational.
        /// </summary>
        [AttributeLogicalName("isdisabled")]
        public bool? IsDisabled
        {
            get { return GetAttributeValue<bool?>("isdisabled"); }
            set
            {
                OnPropertyChanging("IsDisabled");
                SetAttributeValue("isdisabled", value);
                OnPropertyChanged("IsDisabled");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the facility/equipment.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the facility/equipment entry was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the equipment.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the facility/equipment.
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
        ///     Unique identifier of the parent business unit.
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
        ///     Site where the facility/equipment is located.
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
        ///     Skills needed to operate the facility/equipment.
        /// </summary>
        [AttributeLogicalName("skills")]
        public string Skills
        {
            get { return GetAttributeValue<string>("skills"); }
            set
            {
                OnPropertyChanging("Skills");
                SetAttributeValue("skills", value);
                OnPropertyChanged("Skills");
            }
        }

        /// <summary>
        ///     Local time zone where the facility/equipment is located.
        /// </summary>
        [AttributeLogicalName("timezonecode")]
        public int? TimeZoneCode
        {
            get { return GetAttributeValue<int?>("timezonecode"); }
            set
            {
                OnPropertyChanging("TimeZoneCode");
                SetAttributeValue("timezonecode", value);
                OnPropertyChanged("TimeZoneCode");
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
        ///     Unique identifier of the currency associated with the equipment.
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
        ///     Version number of the equipment.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N equipment_accounts
        /// </summary>
        [RelationshipSchemaName("equipment_accounts")]
        public IEnumerable<Account> equipment_accounts
        {
            get { return GetRelatedEntities<Account>("equipment_accounts", null); }
            set
            {
                OnPropertyChanging("equipment_accounts");
                SetRelatedEntities("equipment_accounts", null, value);
                OnPropertyChanged("equipment_accounts");
            }
        }

        /// <summary>
        ///     1:N equipment_activity_parties
        /// </summary>
        [RelationshipSchemaName("equipment_activity_parties")]
        public IEnumerable<ActivityParty> equipment_activity_parties
        {
            get { return GetRelatedEntities<ActivityParty>("equipment_activity_parties", null); }
            set
            {
                OnPropertyChanging("equipment_activity_parties");
                SetRelatedEntities("equipment_activity_parties", null, value);
                OnPropertyChanged("equipment_activity_parties");
            }
        }

        /// <summary>
        ///     1:N Equipment_Annotation
        /// </summary>
        [RelationshipSchemaName("Equipment_Annotation")]
        public IEnumerable<Annotation> Equipment_Annotation
        {
            get { return GetRelatedEntities<Annotation>("Equipment_Annotation", null); }
            set
            {
                OnPropertyChanging("Equipment_Annotation");
                SetRelatedEntities("Equipment_Annotation", null, value);
                OnPropertyChanged("Equipment_Annotation");
            }
        }

        /// <summary>
        ///     1:N Equipment_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Equipment_AsyncOperations")]
        public IEnumerable<AsyncOperation> Equipment_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Equipment_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Equipment_AsyncOperations");
                SetRelatedEntities("Equipment_AsyncOperations", null, value);
                OnPropertyChanged("Equipment_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N Equipment_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("Equipment_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> Equipment_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("Equipment_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("Equipment_BulkDeleteFailures");
                SetRelatedEntities("Equipment_BulkDeleteFailures", null, value);
                OnPropertyChanged("Equipment_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N equipment_connections1
        /// </summary>
        [RelationshipSchemaName("equipment_connections1")]
        public IEnumerable<Connection> equipment_connections1
        {
            get { return GetRelatedEntities<Connection>("equipment_connections1", null); }
            set
            {
                OnPropertyChanging("equipment_connections1");
                SetRelatedEntities("equipment_connections1", null, value);
                OnPropertyChanged("equipment_connections1");
            }
        }

        /// <summary>
        ///     1:N equipment_connections2
        /// </summary>
        [RelationshipSchemaName("equipment_connections2")]
        public IEnumerable<Connection> equipment_connections2
        {
            get { return GetRelatedEntities<Connection>("equipment_connections2", null); }
            set
            {
                OnPropertyChanging("equipment_connections2");
                SetRelatedEntities("equipment_connections2", null, value);
                OnPropertyChanged("equipment_connections2");
            }
        }

        /// <summary>
        ///     1:N equipment_contacts
        /// </summary>
        [RelationshipSchemaName("equipment_contacts")]
        public IEnumerable<Contact> equipment_contacts
        {
            get { return GetRelatedEntities<Contact>("equipment_contacts", null); }
            set
            {
                OnPropertyChanging("equipment_contacts");
                SetRelatedEntities("equipment_contacts", null, value);
                OnPropertyChanged("equipment_contacts");
            }
        }

        /// <summary>
        ///     1:N Equipment_DuplicateBaseRecord
        /// </summary>
        [RelationshipSchemaName("Equipment_DuplicateBaseRecord")]
        public IEnumerable<DuplicateRecord> Equipment_DuplicateBaseRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Equipment_DuplicateBaseRecord", null); }
            set
            {
                OnPropertyChanging("Equipment_DuplicateBaseRecord");
                SetRelatedEntities("Equipment_DuplicateBaseRecord", null, value);
                OnPropertyChanged("Equipment_DuplicateBaseRecord");
            }
        }

        /// <summary>
        ///     1:N Equipment_DuplicateMatchingRecord
        /// </summary>
        [RelationshipSchemaName("Equipment_DuplicateMatchingRecord")]
        public IEnumerable<DuplicateRecord> Equipment_DuplicateMatchingRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Equipment_DuplicateMatchingRecord", null); }
            set
            {
                OnPropertyChanging("Equipment_DuplicateMatchingRecord");
                SetRelatedEntities("Equipment_DuplicateMatchingRecord", null, value);
                OnPropertyChanged("Equipment_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        ///     1:N equipment_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("equipment_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> equipment_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntities<PrincipalObjectAttributeAccess>("equipment_principalobjectattributeaccess",
                    null);
            }
            set
            {
                OnPropertyChanging("equipment_principalobjectattributeaccess");
                SetRelatedEntities("equipment_principalobjectattributeaccess", null, value);
                OnPropertyChanged("equipment_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N Equipment_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("Equipment_ProcessSessions")]
        public IEnumerable<ProcessSession> Equipment_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("Equipment_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Equipment_ProcessSessions");
                SetRelatedEntities("Equipment_ProcessSessions", null, value);
                OnPropertyChanged("Equipment_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N equipment_resources
        /// </summary>
        [RelationshipSchemaName("equipment_resources")]
        public IEnumerable<Resource> equipment_resources
        {
            get { return GetRelatedEntities<Resource>("equipment_resources", null); }
            set
            {
                OnPropertyChanging("equipment_resources");
                SetRelatedEntities("equipment_resources", null, value);
                OnPropertyChanged("equipment_resources");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_equipment
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_equipment")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_equipment
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_equipment", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_equipment");
                SetRelatedEntities("userentityinstancedata_equipment", null, value);
                OnPropertyChanged("userentityinstancedata_equipment");
            }
        }

        /// <summary>
        ///     N:1 business_unit_equipment
        /// </summary>
        [AttributeLogicalName("businessunitid")]
        [RelationshipSchemaName("business_unit_equipment")]
        public BusinessUnit business_unit_equipment
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_equipment", null); }
            set
            {
                OnPropertyChanging("business_unit_equipment");
                SetRelatedEntity("business_unit_equipment", null, value);
                OnPropertyChanged("business_unit_equipment");
            }
        }

        /// <summary>
        ///     N:1 calendar_equipment
        /// </summary>
        [AttributeLogicalName("calendarid")]
        [RelationshipSchemaName("calendar_equipment")]
        public Calendar calendar_equipment
        {
            get { return GetRelatedEntity<Calendar>("calendar_equipment", null); }
            set
            {
                OnPropertyChanging("calendar_equipment");
                SetRelatedEntity("calendar_equipment", null, value);
                OnPropertyChanged("calendar_equipment");
            }
        }

        /// <summary>
        ///     N:1 equipment_systemuser
        /// </summary>
        [AttributeLogicalName("businessunitid")]
        [RelationshipSchemaName("equipment_systemuser")]
        public SystemUser equipment_systemuser
        {
            get { return GetRelatedEntity<SystemUser>("equipment_systemuser", null); }
            set
            {
                OnPropertyChanging("equipment_systemuser");
                SetRelatedEntity("equipment_systemuser", null, value);
                OnPropertyChanged("equipment_systemuser");
            }
        }

        /// <summary>
        ///     N:1 lk_equipment_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_equipment_createdby")]
        public SystemUser lk_equipment_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_equipment_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_equipment_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_equipment_createdonbehalfby")]
        public SystemUser lk_equipment_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_equipment_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_equipment_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_equipment_modifiedby")]
        public SystemUser lk_equipment_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_equipment_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_equipment_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_equipment_modifiedonbehalfby")]
        public SystemUser lk_equipment_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_equipment_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 organization_equipment
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_equipment")]
        public Organization organization_equipment
        {
            get { return GetRelatedEntity<Organization>("organization_equipment", null); }
        }

        /// <summary>
        ///     N:1 site_equipment
        /// </summary>
        [AttributeLogicalName("siteid")]
        [RelationshipSchemaName("site_equipment")]
        public Site site_equipment
        {
            get { return GetRelatedEntity<Site>("site_equipment", null); }
            set
            {
                OnPropertyChanging("site_equipment");
                SetRelatedEntity("site_equipment", null, value);
                OnPropertyChanged("site_equipment");
            }
        }

        /// <summary>
        ///     N:1 TransactionCurrency_Equipment
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("TransactionCurrency_Equipment")]
        public TransactionCurrency TransactionCurrency_Equipment
        {
            get { return GetRelatedEntity<TransactionCurrency>("TransactionCurrency_Equipment", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_Equipment");
                SetRelatedEntity("TransactionCurrency_Equipment", null, value);
                OnPropertyChanged("TransactionCurrency_Equipment");
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