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
    ///     SharePoint site from where documents can be managed in Microsoft Dynamics CRM.
    /// </summary>
    [DataContract]
    [EntityLogicalName("sharepointsite")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class SharePointSite : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "sharepointsite";

        public const int EntityTypeCode = 9502;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public SharePointSite() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Absolute URL of the SharePoint site.
        /// </summary>
        [AttributeLogicalName("absoluteurl")]
        public string AbsoluteURL
        {
            get { return GetAttributeValue<string>("absoluteurl"); }
            set
            {
                OnPropertyChanging("AbsoluteURL");
                SetAttributeValue("absoluteurl", value);
                OnPropertyChanged("AbsoluteURL");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the SharePoint site record.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the SharePoint site record was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the SharePoint site record.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Description of the SharePoint site record.
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
        ///     Exchange rate between the currency associated with the SharePoint site record and the base currency.
        /// </summary>
        [AttributeLogicalName("exchangerate")]
        public decimal? ExchangeRate
        {
            get { return GetAttributeValue<decimal?>("exchangerate"); }
        }

        /// <summary>
        ///     Entity on which the folder structure for Microsoft Dynamics CRM records will be created in SharePoint.
        /// </summary>
        [AttributeLogicalName("folderstructureentity")]
        public string FolderStructureEntity
        {
            get { return GetAttributeValue<string>("folderstructureentity"); }
            set
            {
                OnPropertyChanging("FolderStructureEntity");
                SetAttributeValue("folderstructureentity", value);
                OnPropertyChanged("FolderStructureEntity");
            }
        }

        /// <summary>
        ///     Sequence number of the import that created this record.
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
        ///     Indicates whether the SharePoint site is the default site or not.
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
        ///     Indicates if SharePoint Grid is present or not.
        /// </summary>
        [AttributeLogicalName("isgridpresent")]
        public bool? IsGridPresent
        {
            get { return GetAttributeValue<bool?>("isgridpresent"); }
            set
            {
                OnPropertyChanging("IsGridPresent");
                SetAttributeValue("isgridpresent", value);
                OnPropertyChanged("IsGridPresent");
            }
        }

        /// <summary>
        ///     Date and time when the SharePoint site URL was last validated.
        /// </summary>
        [AttributeLogicalName("lastvalidated")]
        public DateTime? LastValidated
        {
            get { return GetAttributeValue<DateTime?>("lastvalidated"); }
            set
            {
                OnPropertyChanging("LastValidated");
                SetAttributeValue("lastvalidated", value);
                OnPropertyChanged("LastValidated");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the SharePoint site record.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the SharePoint site record was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who modified the SharePoint site record.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the SharePoint site record.
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
        ///     Unique identifier of the user or team who owns the SharePoint site.
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
        ///     Unique identifier for the business unit that owns the document location record.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team that owns the SharePoint site record.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the SharePoint site record.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Unique identifier of the parent SharePoint site.
        /// </summary>
        [AttributeLogicalName("parentsite")]
        public EntityReference ParentSite
        {
            get { return GetAttributeValue<EntityReference>("parentsite"); }
            set
            {
                OnPropertyChanging("ParentSite");
                SetAttributeValue("parentsite", value);
                OnPropertyChanged("ParentSite");
            }
        }

        /// <summary>
        ///     Relative URL of the SharePoint site.
        /// </summary>
        [AttributeLogicalName("relativeurl")]
        public string RelativeUrl
        {
            get { return GetAttributeValue<string>("relativeurl"); }
            set
            {
                OnPropertyChanging("RelativeUrl");
                SetAttributeValue("relativeurl", value);
                OnPropertyChanged("RelativeUrl");
            }
        }

        /// <summary>
        ///     Unique identifier of the SharePoint site in CRM
        /// </summary>
        [AttributeLogicalName("sharepointsiteid")]
        public Guid? SharePointSiteId
        {
            get { return GetAttributeValue<Guid?>("sharepointsiteid"); }
            set
            {
                OnPropertyChanging("SharePointSiteId");
                SetAttributeValue("sharepointsiteid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("SharePointSiteId");
            }
        }

        [AttributeLogicalName("sharepointsiteid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { SharePointSiteId = value; }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("sitecollectionid")]
        public Guid? SiteCollectionId
        {
            get { return GetAttributeValue<Guid?>("sitecollectionid"); }
        }

        /// <summary>
        ///     Status of the SharePoint site record.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public SharePointSiteState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((SharePointSiteState) (Enum.ToObject(typeof (SharePointSiteState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the SharePoint site record.
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
        ///     Unique identifier of the currency associated with the SharePoint site record.
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        public EntityReference TransactionCurrencyId
        {
            get { return GetAttributeValue<EntityReference>("transactioncurrencyid"); }
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
        ///     Validation status of the SharePoint site URL.
        /// </summary>
        [AttributeLogicalName("validationstatus")]
        public OptionSetValue ValidationStatus
        {
            get { return GetAttributeValue<OptionSetValue>("validationstatus"); }
            set
            {
                OnPropertyChanging("ValidationStatus");
                SetAttributeValue("validationstatus", value);
                OnPropertyChanged("ValidationStatus");
            }
        }

        /// <summary>
        ///     Reason for validation status of the URL
        /// </summary>
        [AttributeLogicalName("validationstatuserrorcode")]
        public OptionSetValue ValidationStatusErrorCode
        {
            get { return GetAttributeValue<OptionSetValue>("validationstatuserrorcode"); }
            set
            {
                OnPropertyChanging("ValidationStatusErrorCode");
                SetAttributeValue("validationstatuserrorcode", value);
                OnPropertyChanged("ValidationStatusErrorCode");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N sharepointdocumentlocation_parent_sharepointsite
        /// </summary>
        [RelationshipSchemaName("sharepointdocumentlocation_parent_sharepointsite")]
        public IEnumerable<SharePointDocumentLocation> sharepointdocumentlocation_parent_sharepointsite
        {
            get
            {
                return GetRelatedEntities<SharePointDocumentLocation>(
                    "sharepointdocumentlocation_parent_sharepointsite", null);
            }
            set
            {
                OnPropertyChanging("sharepointdocumentlocation_parent_sharepointsite");
                SetRelatedEntities("sharepointdocumentlocation_parent_sharepointsite", null, value);
                OnPropertyChanged("sharepointdocumentlocation_parent_sharepointsite");
            }
        }

        /// <summary>
        ///     1:N SharePointSite_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("SharePointSite_AsyncOperations")]
        public IEnumerable<AsyncOperation> SharePointSite_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("SharePointSite_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("SharePointSite_AsyncOperations");
                SetRelatedEntities("SharePointSite_AsyncOperations", null, value);
                OnPropertyChanged("SharePointSite_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N SharePointSite_DuplicateBaseRecord
        /// </summary>
        [RelationshipSchemaName("SharePointSite_DuplicateBaseRecord")]
        public IEnumerable<DuplicateRecord> SharePointSite_DuplicateBaseRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("SharePointSite_DuplicateBaseRecord", null); }
            set
            {
                OnPropertyChanging("SharePointSite_DuplicateBaseRecord");
                SetRelatedEntities("SharePointSite_DuplicateBaseRecord", null, value);
                OnPropertyChanged("SharePointSite_DuplicateBaseRecord");
            }
        }

        /// <summary>
        ///     1:N SharePointSite_DuplicateMatchingRecord
        /// </summary>
        [RelationshipSchemaName("SharePointSite_DuplicateMatchingRecord")]
        public IEnumerable<DuplicateRecord> SharePointSite_DuplicateMatchingRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("SharePointSite_DuplicateMatchingRecord", null); }
            set
            {
                OnPropertyChanging("SharePointSite_DuplicateMatchingRecord");
                SetRelatedEntities("SharePointSite_DuplicateMatchingRecord", null, value);
                OnPropertyChanged("SharePointSite_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        ///     1:N sharepointsite_parentsite_sharepointsite
        /// </summary>
        [RelationshipSchemaName("sharepointsite_parentsite_sharepointsite", EntityRole.Referenced)]
        public IEnumerable<SharePointSite> Referencedsharepointsite_parentsite_sharepointsite
        {
            get
            {
                return GetRelatedEntities<SharePointSite>("sharepointsite_parentsite_sharepointsite",
                    EntityRole.Referenced);
            }
            set
            {
                OnPropertyChanging("Referencedsharepointsite_parentsite_sharepointsite");
                SetRelatedEntities("sharepointsite_parentsite_sharepointsite", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedsharepointsite_parentsite_sharepointsite");
            }
        }

        /// <summary>
        ///     1:N sharepointsite_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("sharepointsite_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> sharepointsite_principalobjectattributeaccess
        {
            get
            {
                return
                    GetRelatedEntities<PrincipalObjectAttributeAccess>("sharepointsite_principalobjectattributeaccess",
                        null);
            }
            set
            {
                OnPropertyChanging("sharepointsite_principalobjectattributeaccess");
                SetRelatedEntities("sharepointsite_principalobjectattributeaccess", null, value);
                OnPropertyChanged("sharepointsite_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N SharePointSite_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("SharePointSite_ProcessSessions")]
        public IEnumerable<ProcessSession> SharePointSite_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("SharePointSite_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("SharePointSite_ProcessSessions");
                SetRelatedEntities("SharePointSite_ProcessSessions", null, value);
                OnPropertyChanged("SharePointSite_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_sharepointsite
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_sharepointsite")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_sharepointsite
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_sharepointsite", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_sharepointsite");
                SetRelatedEntities("userentityinstancedata_sharepointsite", null, value);
                OnPropertyChanged("userentityinstancedata_sharepointsite");
            }
        }

        /// <summary>
        ///     N:1 business_unit_sharepointsites
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_sharepointsites")]
        public BusinessUnit business_unit_sharepointsites
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_sharepointsites", null); }
        }

        /// <summary>
        ///     N:1 lk_sharepointsitebase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_sharepointsitebase_createdby")]
        public SystemUser lk_sharepointsitebase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_sharepointsitebase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_sharepointsitebase_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_sharepointsitebase_createdonbehalfby")]
        public SystemUser lk_sharepointsitebase_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_sharepointsitebase_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_sharepointsitebase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_sharepointsitebase_modifiedby")]
        public SystemUser lk_sharepointsitebase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_sharepointsitebase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_sharepointsitebase_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_sharepointsitebase_modifiedonbehalfby")]
        public SystemUser lk_sharepointsitebase_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_sharepointsitebase_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 sharepointsite_parentsite_sharepointsite
        /// </summary>
        [AttributeLogicalName("parentsite")]
        [RelationshipSchemaName("sharepointsite_parentsite_sharepointsite", EntityRole.Referencing)]
        public SharePointSite Referencingsharepointsite_parentsite_sharepointsite
        {
            get
            {
                return GetRelatedEntity<SharePointSite>("sharepointsite_parentsite_sharepointsite",
                    EntityRole.Referencing);
            }
            set
            {
                OnPropertyChanging("Referencingsharepointsite_parentsite_sharepointsite");
                SetRelatedEntity("sharepointsite_parentsite_sharepointsite", EntityRole.Referencing, value);
                OnPropertyChanged("Referencingsharepointsite_parentsite_sharepointsite");
            }
        }

        /// <summary>
        ///     N:1 team_sharepointsite
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_sharepointsite")]
        public Team team_sharepointsite
        {
            get { return GetRelatedEntity<Team>("team_sharepointsite", null); }
        }

        /// <summary>
        ///     N:1 TransactionCurrency_SharePointSite
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("TransactionCurrency_SharePointSite")]
        public TransactionCurrency TransactionCurrency_SharePointSite
        {
            get { return GetRelatedEntity<TransactionCurrency>("TransactionCurrency_SharePointSite", null); }
        }

        /// <summary>
        ///     N:1 user_sharepointsite
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_sharepointsite")]
        public SystemUser user_sharepointsite
        {
            get { return GetRelatedEntity<SystemUser>("user_sharepointsite", null); }
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