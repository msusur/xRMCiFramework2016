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
    [EntityLogicalName("contactinvoices")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ContactInvoices : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "contactinvoices";

        public const int EntityTypeCode = 17;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ContactInvoices() :
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
        ///     Unique identifier of the invoices for the contact.
        /// </summary>
        [AttributeLogicalName("contactinvoiceid")]
        public Guid? ContactInvoiceId
        {
            get { return GetAttributeValue<Guid?>("contactinvoiceid"); }
            set
            {
                OnPropertyChanging("ContactInvoiceId");
                SetAttributeValue("contactinvoiceid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ContactInvoiceId");
            }
        }

        [AttributeLogicalName("contactinvoiceid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ContactInvoiceId = value; }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("invoiceid")]
        public Guid? InvoiceId
        {
            get { return GetAttributeValue<Guid?>("invoiceid"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     N:N contactinvoices_association
        /// </summary>
        [RelationshipSchemaName("contactinvoices_association")]
        public IEnumerable<Invoice> contactinvoices_association
        {
            get { return GetRelatedEntities<Invoice>("contactinvoices_association", null); }
            set
            {
                OnPropertyChanging("contactinvoices_association");
                SetRelatedEntities("contactinvoices_association", null, value);
                OnPropertyChanged("contactinvoices_association");
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