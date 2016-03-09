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
    [EntityLogicalName("contactorders")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ContactOrders : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "contactorders";

        public const int EntityTypeCode = 19;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ContactOrders() :
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
        ///     Unique identifier of the orders for the contact.
        /// </summary>
        [AttributeLogicalName("contactorderid")]
        public Guid? ContactOrderId
        {
            get { return GetAttributeValue<Guid?>("contactorderid"); }
            set
            {
                OnPropertyChanging("ContactOrderId");
                SetAttributeValue("contactorderid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ContactOrderId");
            }
        }

        [AttributeLogicalName("contactorderid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ContactOrderId = value; }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("salesorderid")]
        public Guid? SalesOrderId
        {
            get { return GetAttributeValue<Guid?>("salesorderid"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     N:N contactorders_association
        /// </summary>
        [RelationshipSchemaName("contactorders_association")]
        public IEnumerable<SalesOrder> contactorders_association
        {
            get { return GetRelatedEntities<SalesOrder>("contactorders_association", null); }
            set
            {
                OnPropertyChanging("contactorders_association");
                SetRelatedEntities("contactorders_association", null, value);
                OnPropertyChanged("contactorders_association");
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