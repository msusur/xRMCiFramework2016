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
    ///     Document libraries or folders on a SharePoint server from where documents can be managed in Microsoft Dynamics CRM.
    /// </summary>
    [DataContract]
    [EntityLogicalName("sharepointdocumentlocation")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class SharePointDocumentLocation : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "sharepointdocumentlocation";

        public const int EntityTypeCode = 9508;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public SharePointDocumentLocation() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Absolute URL of the SharePoint document location.
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
        ///     Unique identifier of the user who created the SharePoint document location record.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the SharePoint document location record was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the SharePoint document location record.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Description of the SharePoint document location record.
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
        ///     Exchange rate between the currency associated with the SharePoint document location record and the base currency.
        /// </summary>
        [AttributeLogicalName("exchangerate")]
        public decimal? ExchangeRate
        {
            get { return GetAttributeValue<decimal?>("exchangerate"); }
        }

        /// <summary>
        ///     Sequence number of the import that created the SharePoint document location record.
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
        ///     Unique identifier of the user who last modified the SharePoint document location record.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the SharePoint document location record was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who modified the SharePoint document location record.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the SharePoint document location record.
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
        ///     Unique identifier of the user or team who owns the SharePoint document location record.
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
        ///     Unique identifier of the business unit that owns the SharePoint document location record.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the SharePoint document location record.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the SharePoint document location record.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Unique identifier of the parent site or location.
        /// </summary>
        [AttributeLogicalName("parentsiteorlocation")]
        public EntityReference ParentSiteOrLocation
        {
            get { return GetAttributeValue<EntityReference>("parentsiteorlocation"); }
            set
            {
                OnPropertyChanging("ParentSiteOrLocation");
                SetAttributeValue("parentsiteorlocation", value);
                OnPropertyChanged("ParentSiteOrLocation");
            }
        }

        /// <summary>
        ///     Unique identifier of the object with which the SharePoint document location record is associated.
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
        ///     Relative URL of the SharePoint document location.
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
        ///     Unique identifier of the SharePoint document location record.
        /// </summary>
        [AttributeLogicalName("sharepointdocumentlocationid")]
        public Guid? SharePointDocumentLocationId
        {
            get { return GetAttributeValue<Guid?>("sharepointdocumentlocationid"); }
            set
            {
                OnPropertyChanging("SharePointDocumentLocationId");
                SetAttributeValue("sharepointdocumentlocationid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("SharePointDocumentLocationId");
            }
        }

        [AttributeLogicalName("sharepointdocumentlocationid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { SharePointDocumentLocationId = value; }
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
        ///     Status of the SharePoint document location record.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public SharePointDocumentLocationState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return
                        ((SharePointDocumentLocationState)
                            (Enum.ToObject(typeof (SharePointDocumentLocationState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the SharePoint document location record.
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
        ///     Unique identifier of the currency associated with the SharePoint document location record.
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
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N SharePointDocumentLocation_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("SharePointDocumentLocation_AsyncOperations")]
        public IEnumerable<AsyncOperation> SharePointDocumentLocation_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("SharePointDocumentLocation_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("SharePointDocumentLocation_AsyncOperations");
                SetRelatedEntities("SharePointDocumentLocation_AsyncOperations", null, value);
                OnPropertyChanged("SharePointDocumentLocation_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N SharePointDocumentLocation_DuplicateBaseRecord
        /// </summary>
        [RelationshipSchemaName("SharePointDocumentLocation_DuplicateBaseRecord")]
        public IEnumerable<DuplicateRecord> SharePointDocumentLocation_DuplicateBaseRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("SharePointDocumentLocation_DuplicateBaseRecord", null); }
            set
            {
                OnPropertyChanging("SharePointDocumentLocation_DuplicateBaseRecord");
                SetRelatedEntities("SharePointDocumentLocation_DuplicateBaseRecord", null, value);
                OnPropertyChanged("SharePointDocumentLocation_DuplicateBaseRecord");
            }
        }

        /// <summary>
        ///     1:N SharePointDocumentLocation_DuplicateMatchingRecord
        /// </summary>
        [RelationshipSchemaName("SharePointDocumentLocation_DuplicateMatchingRecord")]
        public IEnumerable<DuplicateRecord> SharePointDocumentLocation_DuplicateMatchingRecord
        {
            get
            {
                return GetRelatedEntities<DuplicateRecord>("SharePointDocumentLocation_DuplicateMatchingRecord", null);
            }
            set
            {
                OnPropertyChanging("SharePointDocumentLocation_DuplicateMatchingRecord");
                SetRelatedEntities("SharePointDocumentLocation_DuplicateMatchingRecord", null, value);
                OnPropertyChanged("SharePointDocumentLocation_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        ///     1:N sharepointdocumentlocation_parent_sharepointdocumentlocation
        /// </summary>
        [RelationshipSchemaName("sharepointdocumentlocation_parent_sharepointdocumentlocation", EntityRole.Referenced)]
        public IEnumerable<SharePointDocumentLocation>
            Referencedsharepointdocumentlocation_parent_sharepointdocumentlocation
        {
            get
            {
                return
                    GetRelatedEntities<SharePointDocumentLocation>(
                        "sharepointdocumentlocation_parent_sharepointdocumentlocation", EntityRole.Referenced);
            }
            set
            {
                OnPropertyChanging("Referencedsharepointdocumentlocation_parent_sharepointdocumentlocation");
                SetRelatedEntities("sharepointdocumentlocation_parent_sharepointdocumentlocation", EntityRole.Referenced,
                    value);
                OnPropertyChanged("Referencedsharepointdocumentlocation_parent_sharepointdocumentlocation");
            }
        }

        /// <summary>
        ///     1:N sharepointdocumentlocation_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("sharepointdocumentlocation_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> sharepointdocumentlocation_principalobjectattributeaccess
        {
            get
            {
                return
                    GetRelatedEntities<PrincipalObjectAttributeAccess>(
                        "sharepointdocumentlocation_principalobjectattributeaccess", null);
            }
            set
            {
                OnPropertyChanging("sharepointdocumentlocation_principalobjectattributeaccess");
                SetRelatedEntities("sharepointdocumentlocation_principalobjectattributeaccess", null, value);
                OnPropertyChanged("sharepointdocumentlocation_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N SharePointDocumentLocation_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("SharePointDocumentLocation_ProcessSessions")]
        public IEnumerable<ProcessSession> SharePointDocumentLocation_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("SharePointDocumentLocation_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("SharePointDocumentLocation_ProcessSessions");
                SetRelatedEntities("SharePointDocumentLocation_ProcessSessions", null, value);
                OnPropertyChanged("SharePointDocumentLocation_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_sharepointdocumentlocation
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_sharepointdocumentlocation")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_sharepointdocumentlocation
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_sharepointdocumentlocation",
                    null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_sharepointdocumentlocation");
                SetRelatedEntities("userentityinstancedata_sharepointdocumentlocation", null, value);
                OnPropertyChanged("userentityinstancedata_sharepointdocumentlocation");
            }
        }

        /// <summary>
        ///     N:1 Account_SharepointDocumentLocation
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Account_SharepointDocumentLocation")]
        public Account Account_SharepointDocumentLocation
        {
            get { return GetRelatedEntity<Account>("Account_SharepointDocumentLocation", null); }
            set
            {
                OnPropertyChanging("Account_SharepointDocumentLocation");
                SetRelatedEntity("Account_SharepointDocumentLocation", null, value);
                OnPropertyChanged("Account_SharepointDocumentLocation");
            }
        }

        /// <summary>
        ///     N:1 business_unit_sharepointdocumentlocation
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_sharepointdocumentlocation")]
        public BusinessUnit business_unit_sharepointdocumentlocation
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_sharepointdocumentlocation", null); }
        }

        /// <summary>
        ///     N:1 KbArticle_SharepointDocumentLocation
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("KbArticle_SharepointDocumentLocation")]
        public KbArticle KbArticle_SharepointDocumentLocation
        {
            get { return GetRelatedEntity<KbArticle>("KbArticle_SharepointDocumentLocation", null); }
            set
            {
                OnPropertyChanging("KbArticle_SharepointDocumentLocation");
                SetRelatedEntity("KbArticle_SharepointDocumentLocation", null, value);
                OnPropertyChanged("KbArticle_SharepointDocumentLocation");
            }
        }

        /// <summary>
        ///     N:1 Lead_SharepointDocumentLocation
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Lead_SharepointDocumentLocation")]
        public Lead Lead_SharepointDocumentLocation
        {
            get { return GetRelatedEntity<Lead>("Lead_SharepointDocumentLocation", null); }
            set
            {
                OnPropertyChanging("Lead_SharepointDocumentLocation");
                SetRelatedEntity("Lead_SharepointDocumentLocation", null, value);
                OnPropertyChanged("Lead_SharepointDocumentLocation");
            }
        }

        /// <summary>
        ///     N:1 lk_sharepointdocumentlocationbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_sharepointdocumentlocationbase_createdby")]
        public SystemUser lk_sharepointdocumentlocationbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_sharepointdocumentlocationbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_sharepointdocumentlocationbase_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_sharepointdocumentlocationbase_createdonbehalfby")]
        public SystemUser lk_sharepointdocumentlocationbase_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_sharepointdocumentlocationbase_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_sharepointdocumentlocationbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_sharepointdocumentlocationbase_modifiedby")]
        public SystemUser lk_sharepointdocumentlocationbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_sharepointdocumentlocationbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_sharepointdocumentlocationbase_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_sharepointdocumentlocationbase_modifiedonbehalfby")]
        public SystemUser lk_sharepointdocumentlocationbase_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_sharepointdocumentlocationbase_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 Opportunity_SharepointDocumentLocation
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Opportunity_SharepointDocumentLocation")]
        public Opportunity Opportunity_SharepointDocumentLocation
        {
            get { return GetRelatedEntity<Opportunity>("Opportunity_SharepointDocumentLocation", null); }
            set
            {
                OnPropertyChanging("Opportunity_SharepointDocumentLocation");
                SetRelatedEntity("Opportunity_SharepointDocumentLocation", null, value);
                OnPropertyChanged("Opportunity_SharepointDocumentLocation");
            }
        }

        /// <summary>
        ///     N:1 Product_SharepointDocumentLocation
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Product_SharepointDocumentLocation")]
        public Product Product_SharepointDocumentLocation
        {
            get { return GetRelatedEntity<Product>("Product_SharepointDocumentLocation", null); }
            set
            {
                OnPropertyChanging("Product_SharepointDocumentLocation");
                SetRelatedEntity("Product_SharepointDocumentLocation", null, value);
                OnPropertyChanged("Product_SharepointDocumentLocation");
            }
        }

        /// <summary>
        ///     N:1 Quote_SharepointDocumentLocation
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Quote_SharepointDocumentLocation")]
        public Quote Quote_SharepointDocumentLocation
        {
            get { return GetRelatedEntity<Quote>("Quote_SharepointDocumentLocation", null); }
            set
            {
                OnPropertyChanging("Quote_SharepointDocumentLocation");
                SetRelatedEntity("Quote_SharepointDocumentLocation", null, value);
                OnPropertyChanged("Quote_SharepointDocumentLocation");
            }
        }

        /// <summary>
        ///     N:1 SalesLiterature_SharepointDocumentLocation
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SalesLiterature_SharepointDocumentLocation")]
        public SalesLiterature SalesLiterature_SharepointDocumentLocation
        {
            get { return GetRelatedEntity<SalesLiterature>("SalesLiterature_SharepointDocumentLocation", null); }
            set
            {
                OnPropertyChanging("SalesLiterature_SharepointDocumentLocation");
                SetRelatedEntity("SalesLiterature_SharepointDocumentLocation", null, value);
                OnPropertyChanged("SalesLiterature_SharepointDocumentLocation");
            }
        }

        /// <summary>
        ///     N:1 sharepointdocumentlocation_parent_sharepointdocumentlocation
        /// </summary>
        [AttributeLogicalName("parentsiteorlocation")]
        [RelationshipSchemaName("sharepointdocumentlocation_parent_sharepointdocumentlocation", EntityRole.Referencing)]
        public SharePointDocumentLocation Referencingsharepointdocumentlocation_parent_sharepointdocumentlocation
        {
            get
            {
                return
                    GetRelatedEntity<SharePointDocumentLocation>(
                        "sharepointdocumentlocation_parent_sharepointdocumentlocation", EntityRole.Referencing);
            }
            set
            {
                OnPropertyChanging("Referencingsharepointdocumentlocation_parent_sharepointdocumentlocation");
                SetRelatedEntity("sharepointdocumentlocation_parent_sharepointdocumentlocation", EntityRole.Referencing,
                    value);
                OnPropertyChanged("Referencingsharepointdocumentlocation_parent_sharepointdocumentlocation");
            }
        }

        /// <summary>
        ///     N:1 sharepointdocumentlocation_parent_sharepointsite
        /// </summary>
        [AttributeLogicalName("parentsiteorlocation")]
        [RelationshipSchemaName("sharepointdocumentlocation_parent_sharepointsite")]
        public SharePointSite sharepointdocumentlocation_parent_sharepointsite
        {
            get { return GetRelatedEntity<SharePointSite>("sharepointdocumentlocation_parent_sharepointsite", null); }
            set
            {
                OnPropertyChanging("sharepointdocumentlocation_parent_sharepointsite");
                SetRelatedEntity("sharepointdocumentlocation_parent_sharepointsite", null, value);
                OnPropertyChanged("sharepointdocumentlocation_parent_sharepointsite");
            }
        }

        /// <summary>
        ///     N:1 team_sharepointdocumentlocation
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_sharepointdocumentlocation")]
        public Team team_sharepointdocumentlocation
        {
            get { return GetRelatedEntity<Team>("team_sharepointdocumentlocation", null); }
        }

        /// <summary>
        ///     N:1 TransactionCurrency_SharePointDocumentLocation
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("TransactionCurrency_SharePointDocumentLocation")]
        public TransactionCurrency TransactionCurrency_SharePointDocumentLocation
        {
            get
            {
                return GetRelatedEntity<TransactionCurrency>("TransactionCurrency_SharePointDocumentLocation", null);
            }
        }

        /// <summary>
        ///     N:1 user_sharepointdocumentlocation
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_sharepointdocumentlocation")]
        public SystemUser user_sharepointdocumentlocation
        {
            get { return GetRelatedEntity<SystemUser>("user_sharepointdocumentlocation", null); }
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