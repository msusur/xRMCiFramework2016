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
    [EntityLogicalName("competitorsalesliterature")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class CompetitorSalesLiterature : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "competitorsalesliterature";

        public const int EntityTypeCode = 26;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public CompetitorSalesLiterature() :
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
        ///     Unique identifier of the sales literature for the competitor product.
        /// </summary>
        [AttributeLogicalName("competitorsalesliteratureid")]
        public Guid? CompetitorSalesLiteratureId
        {
            get { return GetAttributeValue<Guid?>("competitorsalesliteratureid"); }
            set
            {
                OnPropertyChanging("CompetitorSalesLiteratureId");
                SetAttributeValue("competitorsalesliteratureid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("CompetitorSalesLiteratureId");
            }
        }

        [AttributeLogicalName("competitorsalesliteratureid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { CompetitorSalesLiteratureId = value; }
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
        ///     1:N userentityinstancedata_competitorsalesliterature
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_competitorsalesliterature")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_competitorsalesliterature
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_competitorsalesliterature",
                    null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_competitorsalesliterature");
                SetRelatedEntities("userentityinstancedata_competitorsalesliterature", null, value);
                OnPropertyChanged("userentityinstancedata_competitorsalesliterature");
            }
        }

        /// <summary>
        ///     N:N competitorsalesliterature_association
        /// </summary>
        [RelationshipSchemaName("competitorsalesliterature_association")]
        public IEnumerable<SalesLiterature> competitorsalesliterature_association
        {
            get { return GetRelatedEntities<SalesLiterature>("competitorsalesliterature_association", null); }
            set
            {
                OnPropertyChanging("competitorsalesliterature_association");
                SetRelatedEntities("competitorsalesliterature_association", null, value);
                OnPropertyChanged("competitorsalesliterature_association");
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