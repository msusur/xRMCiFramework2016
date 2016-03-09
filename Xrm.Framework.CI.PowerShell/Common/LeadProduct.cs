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
    [EntityLogicalName("leadproduct")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class LeadProduct : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "leadproduct";

        public const int EntityTypeCode = 27;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public LeadProduct() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("leadid")]
        public Guid? LeadId
        {
            get { return GetAttributeValue<Guid?>("leadid"); }
        }

        /// <summary>
        ///     Unique identifier of the lead product.
        /// </summary>
        [AttributeLogicalName("leadproductid")]
        public Guid? LeadProductId
        {
            get { return GetAttributeValue<Guid?>("leadproductid"); }
            set
            {
                OnPropertyChanging("LeadProductId");
                SetAttributeValue("leadproductid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("LeadProductId");
            }
        }

        [AttributeLogicalName("leadproductid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { LeadProductId = value; }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("productid")]
        public Guid? ProductId
        {
            get { return GetAttributeValue<Guid?>("productid"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N userentityinstancedata_leadproduct
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_leadproduct")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_leadproduct
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_leadproduct", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_leadproduct");
                SetRelatedEntities("userentityinstancedata_leadproduct", null, value);
                OnPropertyChanged("userentityinstancedata_leadproduct");
            }
        }

        /// <summary>
        ///     N:N leadproduct_association
        /// </summary>
        [RelationshipSchemaName("leadproduct_association")]
        public IEnumerable<Lead> leadproduct_association
        {
            get { return GetRelatedEntities<Lead>("leadproduct_association", null); }
            set
            {
                OnPropertyChanging("leadproduct_association");
                SetRelatedEntities("leadproduct_association", null, value);
                OnPropertyChanged("leadproduct_association");
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