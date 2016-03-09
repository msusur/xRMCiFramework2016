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
    /// </summary>
    [DataContract]
    [EntityLogicalName("accountleads")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class AccountLeads : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "accountleads";

        public const int EntityTypeCode = 16;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public AccountLeads() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("accountid")]
        public Guid? AccountId
        {
            get { return GetAttributeValue<Guid?>("accountid"); }
        }

        /// <summary>
        ///     Unique identifier of the lead for the account.
        /// </summary>
        [AttributeLogicalName("accountleadid")]
        public Guid? AccountLeadId
        {
            get { return GetAttributeValue<Guid?>("accountleadid"); }
            set
            {
                OnPropertyChanging("AccountLeadId");
                SetAttributeValue("accountleadid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("AccountLeadId");
            }
        }

        [AttributeLogicalName("accountleadid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { AccountLeadId = value; }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("leadid")]
        public Guid? LeadId
        {
            get { return GetAttributeValue<Guid?>("leadid"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     N:N accountleads_association
        /// </summary>
        [RelationshipSchemaName("accountleads_association")]
        public IEnumerable<Account> accountleads_association
        {
            get { return GetRelatedEntities<Account>("accountleads_association", null); }
            set
            {
                OnPropertyChanging("accountleads_association");
                SetRelatedEntities("accountleads_association", null, value);
                OnPropertyChanged("accountleads_association");
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