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
    ///     Relationship that stores information about products that belong to a kit.
    /// </summary>
    [DataContract]
    [EntityLogicalName("productassociation")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ProductAssociation : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "productassociation";

        public const int EntityTypeCode = 1025;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ProductAssociation() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("associatedproduct")]
        public Guid? AssociatedProduct
        {
            get { return GetAttributeValue<Guid?>("associatedproduct"); }
            set
            {
                OnPropertyChanging("AssociatedProduct");
                SetAttributeValue("associatedproduct", value);
                OnPropertyChanged("AssociatedProduct");
            }
        }

        /// <summary>
        ///     Unique identifier of the product association.
        /// </summary>
        [AttributeLogicalName("productassociationid")]
        public Guid? ProductAssociationId
        {
            get { return GetAttributeValue<Guid?>("productassociationid"); }
            set
            {
                OnPropertyChanging("ProductAssociationId");
                SetAttributeValue("productassociationid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ProductAssociationId");
            }
        }

        [AttributeLogicalName("productassociationid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ProductAssociationId = value; }
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
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N userentityinstancedata_productassociation
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_productassociation")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_productassociation
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_productassociation", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_productassociation");
                SetRelatedEntities("userentityinstancedata_productassociation", null, value);
                OnPropertyChanged("userentityinstancedata_productassociation");
            }
        }

        /// <summary>
        ///     N:N productassociation_association
        /// </summary>
        [RelationshipSchemaName("productassociation_association")]
        public IEnumerable<Product> productassociation_association
        {
            get { return GetRelatedEntities<Product>("productassociation_association", null); }
            set
            {
                OnPropertyChanging("productassociation_association");
                SetRelatedEntities("productassociation_association", null, value);
                OnPropertyChanged("productassociation_association");
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