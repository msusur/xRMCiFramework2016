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
    [EntityLogicalName("opportunitycompetitors")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class OpportunityCompetitors : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "opportunitycompetitors";

        public const int EntityTypeCode = 25;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public OpportunityCompetitors() :
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
        ///     Unique identifier of the opportunity competitor.
        /// </summary>
        [AttributeLogicalName("opportunitycompetitorid")]
        public Guid? OpportunityCompetitorId
        {
            get { return GetAttributeValue<Guid?>("opportunitycompetitorid"); }
            set
            {
                OnPropertyChanging("OpportunityCompetitorId");
                SetAttributeValue("opportunitycompetitorid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("OpportunityCompetitorId");
            }
        }

        [AttributeLogicalName("opportunitycompetitorid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { OpportunityCompetitorId = value; }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("opportunityid")]
        public Guid? OpportunityId
        {
            get { return GetAttributeValue<Guid?>("opportunityid"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     N:N opportunitycompetitors_association
        /// </summary>
        [RelationshipSchemaName("opportunitycompetitors_association")]
        public IEnumerable<Opportunity> opportunitycompetitors_association
        {
            get { return GetRelatedEntities<Opportunity>("opportunitycompetitors_association", null); }
            set
            {
                OnPropertyChanging("opportunitycompetitors_association");
                SetRelatedEntities("opportunitycompetitors_association", null, value);
                OnPropertyChanged("opportunitycompetitors_association");
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