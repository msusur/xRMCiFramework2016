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
    ///     User or facility/equipment that can be scheduled for a service.
    /// </summary>
    [DataContract]
    [EntityLogicalName("resource")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Resource : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "resource";

        public const int EntityTypeCode = 4002;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Resource() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the business unit with which the resource is associated.
        /// </summary>
        [AttributeLogicalName("businessunitid")]
        public EntityReference BusinessUnitId
        {
            get { return GetAttributeValue<EntityReference>("businessunitid"); }
            set
            {
                OnPropertyChanging("BusinessUnitId");
                SetAttributeValue("businessunitid", value);
                OnPropertyChanged("BusinessUnitId");
            }
        }

        /// <summary>
        ///     Unique identifier of the calendar for the resource.
        /// </summary>
        [AttributeLogicalName("calendarid")]
        public Guid? CalendarId
        {
            get { return GetAttributeValue<Guid?>("calendarid"); }
            set
            {
                OnPropertyChanging("CalendarId");
                SetAttributeValue("calendarid", value);
                OnPropertyChanged("CalendarId");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("displayinserviceviews")]
        public bool? DisplayInServiceViews
        {
            get { return GetAttributeValue<bool?>("displayinserviceviews"); }
            set
            {
                OnPropertyChanging("DisplayInServiceViews");
                SetAttributeValue("displayinserviceviews", value);
                OnPropertyChanged("DisplayInServiceViews");
            }
        }

        /// <summary>
        ///     Shows the default image for the record.
        /// </summary>
        [AttributeLogicalName("entityimage")]
        public byte[] EntityImage
        {
            get { return GetAttributeValue<byte[]>("entityimage"); }
            set
            {
                OnPropertyChanging("EntityImage");
                SetAttributeValue("entityimage", value);
                OnPropertyChanged("EntityImage");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("entityimage_timestamp")]
        public long? EntityImage_Timestamp
        {
            get { return GetAttributeValue<long?>("entityimage_timestamp"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("entityimage_url")]
        public string EntityImage_URL
        {
            get { return GetAttributeValue<string>("entityimage_url"); }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("entityimageid")]
        public Guid? EntityImageId
        {
            get { return GetAttributeValue<Guid?>("entityimageid"); }
        }

        /// <summary>
        ///     Information about whether the resource is enabled.
        /// </summary>
        [AttributeLogicalName("isdisabled")]
        public bool? IsDisabled
        {
            get { return GetAttributeValue<bool?>("isdisabled"); }
            set
            {
                OnPropertyChanging("IsDisabled");
                SetAttributeValue("isdisabled", value);
                OnPropertyChanged("IsDisabled");
            }
        }

        /// <summary>
        ///     Name of the resource.
        /// </summary>
        [AttributeLogicalName("name")]
        public string Name
        {
            get { return GetAttributeValue<string>("name"); }
            set
            {
                OnPropertyChanging("Name");
                SetAttributeValue("name", value);
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        ///     Type of entity with which the resource is associated.
        /// </summary>
        [AttributeLogicalName("objecttypecode")]
        public string ObjectTypeCode
        {
            get { return GetAttributeValue<string>("objecttypecode"); }
            set
            {
                OnPropertyChanging("ObjectTypeCode");
                SetAttributeValue("objecttypecode", value);
                OnPropertyChanged("ObjectTypeCode");
            }
        }

        /// <summary>
        ///     Unique identifier of the organization with which the resource is associated.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     Unique identifier of the resource.
        /// </summary>
        [AttributeLogicalName("resourceid")]
        public Guid? ResourceId
        {
            get { return GetAttributeValue<Guid?>("resourceid"); }
            set
            {
                OnPropertyChanging("ResourceId");
                SetAttributeValue("resourceid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ResourceId");
            }
        }

        [AttributeLogicalName("resourceid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ResourceId = value; }
        }

        /// <summary>
        ///     Unique identifier of the site at which the resource is located.
        /// </summary>
        [AttributeLogicalName("siteid")]
        public EntityReference SiteId
        {
            get { return GetAttributeValue<EntityReference>("siteid"); }
            set
            {
                OnPropertyChanging("SiteId");
                SetAttributeValue("siteid", value);
                OnPropertyChanged("SiteId");
            }
        }

        /// <summary>
        ///     Version number of the resource.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N Resource_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Resource_AsyncOperations")]
        public IEnumerable<AsyncOperation> Resource_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Resource_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Resource_AsyncOperations");
                SetRelatedEntities("Resource_AsyncOperations", null, value);
                OnPropertyChanged("Resource_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N Resource_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("Resource_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> Resource_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("Resource_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("Resource_BulkDeleteFailures");
                SetRelatedEntities("Resource_BulkDeleteFailures", null, value);
                OnPropertyChanged("Resource_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_resource
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_resource")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_resource
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_resource", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_resource");
                SetRelatedEntities("userentityinstancedata_resource", null, value);
                OnPropertyChanged("userentityinstancedata_resource");
            }
        }

        /// <summary>
        ///     N:1 business_unit_resources
        /// </summary>
        [AttributeLogicalName("businessunitid")]
        [RelationshipSchemaName("business_unit_resources")]
        public BusinessUnit business_unit_resources
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_resources", null); }
            set
            {
                OnPropertyChanging("business_unit_resources");
                SetRelatedEntity("business_unit_resources", null, value);
                OnPropertyChanged("business_unit_resources");
            }
        }

        /// <summary>
        ///     N:1 equipment_resources
        /// </summary>
        [AttributeLogicalName("resourceid")]
        [RelationshipSchemaName("equipment_resources")]
        public Equipment equipment_resources
        {
            get { return GetRelatedEntity<Equipment>("equipment_resources", null); }
            set
            {
                OnPropertyChanging("equipment_resources");
                SetRelatedEntity("equipment_resources", null, value);
                OnPropertyChanged("equipment_resources");
            }
        }

        /// <summary>
        ///     N:1 organization_resources
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_resources")]
        public Organization organization_resources
        {
            get { return GetRelatedEntity<Organization>("organization_resources", null); }
        }

        /// <summary>
        ///     N:1 resourcespec_resources
        /// </summary>
        [AttributeLogicalName("resourceid")]
        [RelationshipSchemaName("resourcespec_resources")]
        public ResourceSpec resourcespec_resources
        {
            get { return GetRelatedEntity<ResourceSpec>("resourcespec_resources", null); }
            set
            {
                OnPropertyChanging("resourcespec_resources");
                SetRelatedEntity("resourcespec_resources", null, value);
                OnPropertyChanged("resourcespec_resources");
            }
        }

        /// <summary>
        ///     N:1 site_resources
        /// </summary>
        [AttributeLogicalName("siteid")]
        [RelationshipSchemaName("site_resources")]
        public Site site_resources
        {
            get { return GetRelatedEntity<Site>("site_resources", null); }
            set
            {
                OnPropertyChanging("site_resources");
                SetRelatedEntity("site_resources", null, value);
                OnPropertyChanged("site_resources");
            }
        }

        /// <summary>
        ///     N:1 systemuser_resources
        /// </summary>
        [AttributeLogicalName("resourceid")]
        [RelationshipSchemaName("systemuser_resources")]
        public SystemUser systemuser_resources
        {
            get { return GetRelatedEntity<SystemUser>("systemuser_resources", null); }
            set
            {
                OnPropertyChanging("systemuser_resources");
                SetRelatedEntity("systemuser_resources", null, value);
                OnPropertyChanged("systemuser_resources");
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