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
    ///     Storage of an association between a product and a substitute product.
    /// </summary>
    [DataContract]
    [EntityLogicalName("productsubstitute")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ProductSubstitute : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "productsubstitute";

        public const int EntityTypeCode = 1028;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ProductSubstitute() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("productid")]
        public Guid? ProductId
        {
            get { return GetAttributeValue<Guid?>("productid"); }
            set
            {
                OnPropertyChanging("ProductId");
                SetAttributeValue("productid", value);
                OnPropertyChanged("ProductId");
            }
        }

        /// <summary>
        ///     Unique identifier of the product substitute.
        /// </summary>
        [AttributeLogicalName("productsubstituteid")]
        public Guid? ProductSubstituteId
        {
            get { return GetAttributeValue<Guid?>("productsubstituteid"); }
            set
            {
                OnPropertyChanging("ProductSubstituteId");
                SetAttributeValue("productsubstituteid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ProductSubstituteId");
            }
        }

        [AttributeLogicalName("productsubstituteid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ProductSubstituteId = value; }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("substitutedproductid")]
        public Guid? SubstitutedProductId
        {
            get { return GetAttributeValue<Guid?>("substitutedproductid"); }
            set
            {
                OnPropertyChanging("SubstitutedProductId");
                SetAttributeValue("substitutedproductid", value);
                OnPropertyChanged("SubstitutedProductId");
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
        ///     1:N userentityinstancedata_productsubstitute
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_productsubstitute")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_productsubstitute
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_productsubstitute", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_productsubstitute");
                SetRelatedEntities("userentityinstancedata_productsubstitute", null, value);
                OnPropertyChanged("userentityinstancedata_productsubstitute");
            }
        }

        /// <summary>
        ///     N:N productsubstitute_association
        /// </summary>
        [RelationshipSchemaName("productsubstitute_association")]
        public IEnumerable<Product> productsubstitute_association
        {
            get { return GetRelatedEntities<Product>("productsubstitute_association", null); }
            set
            {
                OnPropertyChanging("productsubstitute_association");
                SetRelatedEntities("productsubstitute_association", null, value);
                OnPropertyChanged("productsubstitute_association");
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