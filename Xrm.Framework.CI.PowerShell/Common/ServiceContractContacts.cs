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
    [EntityLogicalName("servicecontractcontacts")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ServiceContractContacts : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "servicecontractcontacts";

        public const int EntityTypeCode = 20;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ServiceContractContacts() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("contactid")]
        public Guid? ContactId
        {
            get { return GetAttributeValue<Guid?>("contactid"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("contractid")]
        public Guid? ContractId
        {
            get { return GetAttributeValue<Guid?>("contractid"); }
        }

        /// <summary>
        ///     Unique identifier of the contact of the service contract.
        /// </summary>
        [AttributeLogicalName("servicecontractcontactid")]
        public Guid? ServiceContractContactId
        {
            get { return GetAttributeValue<Guid?>("servicecontractcontactid"); }
            set
            {
                OnPropertyChanging("ServiceContractContactId");
                SetAttributeValue("servicecontractcontactid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ServiceContractContactId");
            }
        }

        [AttributeLogicalName("servicecontractcontactid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ServiceContractContactId = value; }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("servicelevel")]
        public int? ServiceLevel
        {
            get { return GetAttributeValue<int?>("servicelevel"); }
            set
            {
                OnPropertyChanging("ServiceLevel");
                SetAttributeValue("servicelevel", value);
                OnPropertyChanged("ServiceLevel");
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
        ///     N:N servicecontractcontacts_association
        /// </summary>
        [RelationshipSchemaName("servicecontractcontacts_association")]
        public IEnumerable<Contact> servicecontractcontacts_association
        {
            get { return GetRelatedEntities<Contact>("servicecontractcontacts_association", null); }
            set
            {
                OnPropertyChanging("servicecontractcontacts_association");
                SetRelatedEntities("servicecontractcontacts_association", null, value);
                OnPropertyChanged("servicecontractcontacts_association");
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