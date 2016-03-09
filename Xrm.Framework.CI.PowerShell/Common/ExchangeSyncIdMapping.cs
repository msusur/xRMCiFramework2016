using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Xrm.Framework.CI.Common.Entities
{
    /// <summary>
    ///     The mapping used to keep track of the IDs for items synced between CRM and Exchange.
    /// </summary>
    [DataContract]
    [EntityLogicalName("exchangesyncidmapping")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ExchangeSyncIdMapping : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "exchangesyncidmapping";

        public const int EntityTypeCode = 4120;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ExchangeSyncIdMapping() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("exchangeentryid")]
        public string ExchangeEntryId
        {
            get { return GetAttributeValue<string>("exchangeentryid"); }
            set
            {
                OnPropertyChanging("ExchangeEntryId");
                SetAttributeValue("exchangeentryid", value);
                OnPropertyChanged("ExchangeEntryId");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("exchangesyncidmappingid")]
        public Guid? ExchangeSyncIdmappingId
        {
            get { return GetAttributeValue<Guid?>("exchangesyncidmappingid"); }
            set
            {
                OnPropertyChanging("ExchangeSyncIdmappingId");
                SetAttributeValue("exchangesyncidmappingid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ExchangeSyncIdmappingId");
            }
        }

        [AttributeLogicalName("exchangesyncidmappingid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ExchangeSyncIdmappingId = value; }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("fromcrmchangetype")]
        public int? FromCrmChangeType
        {
            get { return GetAttributeValue<int?>("fromcrmchangetype"); }
            set
            {
                OnPropertyChanging("FromCrmChangeType");
                SetAttributeValue("fromcrmchangetype", value);
                OnPropertyChanged("FromCrmChangeType");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("isdeletedinexchange")]
        public bool? IsDeletedInExchange
        {
            get { return GetAttributeValue<bool?>("isdeletedinexchange"); }
            set
            {
                OnPropertyChanging("IsDeletedInExchange");
                SetAttributeValue("isdeletedinexchange", value);
                OnPropertyChanged("IsDeletedInExchange");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("isunlinkedincrm")]
        public bool? IsUnlinkedInCRM
        {
            get { return GetAttributeValue<bool?>("isunlinkedincrm"); }
            set
            {
                OnPropertyChanging("IsUnlinkedInCRM");
                SetAttributeValue("isunlinkedincrm", value);
                OnPropertyChanged("IsUnlinkedInCRM");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("lastsyncerror")]
        public string LastSyncError
        {
            get { return GetAttributeValue<string>("lastsyncerror"); }
            set
            {
                OnPropertyChanging("LastSyncError");
                SetAttributeValue("lastsyncerror", value);
                OnPropertyChanged("LastSyncError");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("lastsyncerrorcode")]
        public int? LastSyncErrorCode
        {
            get { return GetAttributeValue<int?>("lastsyncerrorcode"); }
            set
            {
                OnPropertyChanging("LastSyncErrorCode");
                SetAttributeValue("lastsyncerrorcode", value);
                OnPropertyChanged("LastSyncErrorCode");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("objectid")]
        public Guid? ObjectId
        {
            get { return GetAttributeValue<Guid?>("objectid"); }
            set
            {
                OnPropertyChanging("ObjectId");
                SetAttributeValue("objectid", value);
                OnPropertyChanged("ObjectId");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("objecttypecode")]
        public int? ObjectTypeCode
        {
            get { return GetAttributeValue<int?>("objecttypecode"); }
            set
            {
                OnPropertyChanging("ObjectTypeCode");
                SetAttributeValue("objecttypecode", value);
                OnPropertyChanged("ObjectTypeCode");
            }
        }

        /// <summary>
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
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("retries")]
        public int? Retries
        {
            get { return GetAttributeValue<int?>("retries"); }
            set
            {
                OnPropertyChanging("Retries");
                SetAttributeValue("retries", value);
                OnPropertyChanged("Retries");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("tocrmchangetype")]
        public int? ToCrmChangeType
        {
            get { return GetAttributeValue<int?>("tocrmchangetype"); }
            set
            {
                OnPropertyChanging("ToCrmChangeType");
                SetAttributeValue("tocrmchangetype", value);
                OnPropertyChanged("ToCrmChangeType");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("userdecision")]
        public int? UserDecision
        {
            get { return GetAttributeValue<int?>("userdecision"); }
            set
            {
                OnPropertyChanging("UserDecision");
                SetAttributeValue("userdecision", value);
                OnPropertyChanged("UserDecision");
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
        ///     N:1 business_unit_exchangesyncidmapping
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_exchangesyncidmapping")]
        public BusinessUnit business_unit_exchangesyncidmapping
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_exchangesyncidmapping", null); }
        }

        /// <summary>
        ///     N:1 team_exchangesyncidmapping
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_exchangesyncidmapping")]
        public Team team_exchangesyncidmapping
        {
            get { return GetRelatedEntity<Team>("team_exchangesyncidmapping", null); }
        }

        /// <summary>
        ///     N:1 user_exchangesyncidmapping
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_exchangesyncidmapping")]
        public SystemUser user_exchangesyncidmapping
        {
            get { return GetRelatedEntity<SystemUser>("user_exchangesyncidmapping", null); }
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