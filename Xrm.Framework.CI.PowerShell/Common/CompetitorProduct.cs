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
    ///     Association between a competitor and a product offered by the competitor.
    /// </summary>
    [DataContract]
    [EntityLogicalName("competitorproduct")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class CompetitorProduct : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "competitorproduct";

        public const int EntityTypeCode = 1006;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public CompetitorProduct() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("competitorid")]
        public Guid? CompetitorId
        {
            get { return GetAttributeValue<Guid?>("competitorid"); }
        }

        /// <summary>
        ///     Unique identifier of the competitor product.
        /// </summary>
        [AttributeLogicalName("competitorproductid")]
        public Guid? CompetitorProductId
        {
            get { return GetAttributeValue<Guid?>("competitorproductid"); }
            set
            {
                OnPropertyChanging("CompetitorProductId");
                SetAttributeValue("competitorproductid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("CompetitorProductId");
            }
        }

        [AttributeLogicalName("competitorproductid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { CompetitorProductId = value; }
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
        ///     1:N userentityinstancedata_competitorproduct
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_competitorproduct")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_competitorproduct
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_competitorproduct", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_competitorproduct");
                SetRelatedEntities("userentityinstancedata_competitorproduct", null, value);
                OnPropertyChanged("userentityinstancedata_competitorproduct");
            }
        }

        /// <summary>
        ///     N:N competitorproduct_association
        /// </summary>
        [RelationshipSchemaName("competitorproduct_association")]
        public IEnumerable<Competitor> competitorproduct_association
        {
            get { return GetRelatedEntities<Competitor>("competitorproduct_association", null); }
            set
            {
                OnPropertyChanging("competitorproduct_association");
                SetRelatedEntities("competitorproduct_association", null, value);
                OnPropertyChanged("competitorproduct_association");
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