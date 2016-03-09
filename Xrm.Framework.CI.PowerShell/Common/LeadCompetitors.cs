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
    [EntityLogicalName("leadcompetitors")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class LeadCompetitors : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "leadcompetitors";

        public const int EntityTypeCode = 24;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public LeadCompetitors() :
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
        ///     Unique identifier of the lead competitor.
        /// </summary>
        [AttributeLogicalName("leadcompetitorid")]
        public Guid? LeadCompetitorId
        {
            get { return GetAttributeValue<Guid?>("leadcompetitorid"); }
            set
            {
                OnPropertyChanging("LeadCompetitorId");
                SetAttributeValue("leadcompetitorid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("LeadCompetitorId");
            }
        }

        [AttributeLogicalName("leadcompetitorid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { LeadCompetitorId = value; }
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
        ///     N:N leadcompetitors_association
        /// </summary>
        [RelationshipSchemaName("leadcompetitors_association")]
        public IEnumerable<Lead> leadcompetitors_association
        {
            get { return GetRelatedEntities<Lead>("leadcompetitors_association", null); }
            set
            {
                OnPropertyChanging("leadcompetitors_association");
                SetRelatedEntities("leadcompetitors_association", null, value);
                OnPropertyChanged("leadcompetitors_association");
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