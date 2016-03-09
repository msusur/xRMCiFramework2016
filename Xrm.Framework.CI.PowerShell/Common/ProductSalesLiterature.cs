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
    [EntityLogicalName("productsalesliterature")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ProductSalesLiterature : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "productsalesliterature";

        public const int EntityTypeCode = 21;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ProductSalesLiterature() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("productid")]
        public Guid? ProductId
        {
            get { return GetAttributeValue<Guid?>("productid"); }
        }

        /// <summary>
        ///     Unique identifier of the product sales literature associated with this price list.
        /// </summary>
        [AttributeLogicalName("productsalesliteratureid")]
        public Guid? ProductSalesLiteratureId
        {
            get { return GetAttributeValue<Guid?>("productsalesliteratureid"); }
            set
            {
                OnPropertyChanging("ProductSalesLiteratureId");
                SetAttributeValue("productsalesliteratureid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ProductSalesLiteratureId");
            }
        }

        [AttributeLogicalName("productsalesliteratureid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ProductSalesLiteratureId = value; }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("salesliteratureid")]
        public Guid? SalesLiteratureId
        {
            get { return GetAttributeValue<Guid?>("salesliteratureid"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N userentityinstancedata_productsalesliterature
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_productsalesliterature")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_productsalesliterature
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_productsalesliterature", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_productsalesliterature");
                SetRelatedEntities("userentityinstancedata_productsalesliterature", null, value);
                OnPropertyChanged("userentityinstancedata_productsalesliterature");
            }
        }

        /// <summary>
        ///     N:N productsalesliterature_association
        /// </summary>
        [RelationshipSchemaName("productsalesliterature_association")]
        public IEnumerable<Product> productsalesliterature_association
        {
            get { return GetRelatedEntities<Product>("productsalesliterature_association", null); }
            set
            {
                OnPropertyChanging("productsalesliterature_association");
                SetRelatedEntities("productsalesliterature_association", null, value);
                OnPropertyChanged("productsalesliterature_association");
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