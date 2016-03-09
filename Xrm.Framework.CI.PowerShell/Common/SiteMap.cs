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
    ///     XML data used to control the application navigation pane.
    /// </summary>
    [DataContract]
    [EntityLogicalName("sitemap")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class SiteMap : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "sitemap";

        public const int EntityTypeCode = 4709;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public SiteMap() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("componentstate")]
        public OptionSetValue ComponentState
        {
            get { return GetAttributeValue<OptionSetValue>("componentstate"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("ismanaged")]
        public bool? IsManaged
        {
            get { return GetAttributeValue<bool?>("ismanaged"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("overwritetime")]
        public DateTime? OverwriteTime
        {
            get { return GetAttributeValue<DateTime?>("overwritetime"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("sitemapid")]
        public Guid? SiteMapId
        {
            get { return GetAttributeValue<Guid?>("sitemapid"); }
        }

        [AttributeLogicalName("sitemapid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { base.Id = value; }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("sitemapidunique")]
        public Guid? SiteMapIdUnique
        {
            get { return GetAttributeValue<Guid?>("sitemapidunique"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("sitemapxml")]
        public string SiteMapXml
        {
            get { return GetAttributeValue<string>("sitemapxml"); }
            set
            {
                OnPropertyChanging("SiteMapXml");
                SetAttributeValue("sitemapxml", value);
                OnPropertyChanged("SiteMapXml");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("solutionid")]
        public Guid? SolutionId
        {
            get { return GetAttributeValue<Guid?>("solutionid"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N userentityinstancedata_sitemap
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_sitemap")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_sitemap
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_sitemap", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_sitemap");
                SetRelatedEntities("userentityinstancedata_sitemap", null, value);
                OnPropertyChanged("userentityinstancedata_sitemap");
            }
        }

        /// <summary>
        ///     N:1 organization_sitemap
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_sitemap")]
        public Organization organization_sitemap
        {
            get { return GetRelatedEntity<Organization>("organization_sitemap", null); }
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