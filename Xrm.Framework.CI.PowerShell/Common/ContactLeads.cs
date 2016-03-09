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
    [EntityLogicalName("contactleads")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ContactLeads : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "contactleads";

        public const int EntityTypeCode = 22;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ContactLeads() :
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
        ///     Unique identifier of the leads for the contact.
        /// </summary>
        [AttributeLogicalName("contactleadid")]
        public Guid? ContactLeadId
        {
            get { return GetAttributeValue<Guid?>("contactleadid"); }
            set
            {
                OnPropertyChanging("ContactLeadId");
                SetAttributeValue("contactleadid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ContactLeadId");
            }
        }

        [AttributeLogicalName("contactleadid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ContactLeadId = value; }
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
        ///     N:N contactleads_association
        /// </summary>
        [RelationshipSchemaName("contactleads_association")]
        public IEnumerable<Contact> contactleads_association
        {
            get { return GetRelatedEntities<Contact>("contactleads_association", null); }
            set
            {
                OnPropertyChanging("contactleads_association");
                SetRelatedEntities("contactleads_association", null, value);
                OnPropertyChanged("contactleads_association");
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