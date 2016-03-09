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
    [EntityLogicalName("contactquotes")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ContactQuotes : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "contactquotes";

        public const int EntityTypeCode = 18;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ContactQuotes() :
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
        ///     Unique identifier of the quotes for the contact.
        /// </summary>
        [AttributeLogicalName("contactquoteid")]
        public Guid? ContactQuoteId
        {
            get { return GetAttributeValue<Guid?>("contactquoteid"); }
            set
            {
                OnPropertyChanging("ContactQuoteId");
                SetAttributeValue("contactquoteid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ContactQuoteId");
            }
        }

        [AttributeLogicalName("contactquoteid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ContactQuoteId = value; }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("quoteid")]
        public Guid? QuoteId
        {
            get { return GetAttributeValue<Guid?>("quoteid"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     N:N contactquotes_association
        /// </summary>
        [RelationshipSchemaName("contactquotes_association")]
        public IEnumerable<Quote> contactquotes_association
        {
            get { return GetRelatedEntities<Quote>("contactquotes_association", null); }
            set
            {
                OnPropertyChanging("contactquotes_association");
                SetRelatedEntities("contactquotes_association", null, value);
                OnPropertyChanged("contactquotes_association");
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