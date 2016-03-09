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
    ///     Stores information about a Microsoft CRM license.
    /// </summary>
    [DataContract]
    [EntityLogicalName("license")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class License : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "license";

        public const int EntityTypeCode = 2027;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public License() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Date and time when the license was installed.
        /// </summary>
        [AttributeLogicalName("installedon")]
        public DateTime? InstalledOn
        {
            get { return GetAttributeValue<DateTime?>("installedon"); }
            set
            {
                OnPropertyChanging("InstalledOn");
                SetAttributeValue("installedon", value);
                OnPropertyChanged("InstalledOn");
            }
        }

        /// <summary>
        ///     Unique identifier of the license.
        /// </summary>
        [AttributeLogicalName("licenseid")]
        public Guid? LicenseId
        {
            get { return GetAttributeValue<Guid?>("licenseid"); }
            set
            {
                OnPropertyChanging("LicenseId");
                SetAttributeValue("licenseid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("LicenseId");
            }
        }

        [AttributeLogicalName("licenseid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { LicenseId = value; }
        }

        /// <summary>
        ///     Key for the license.
        /// </summary>
        [AttributeLogicalName("licensekey")]
        public string LicenseKey
        {
            get { return GetAttributeValue<string>("licensekey"); }
            set
            {
                OnPropertyChanging("LicenseKey");
                SetAttributeValue("licensekey", value);
                OnPropertyChanged("LicenseKey");
            }
        }

        /// <summary>
        ///     Type of license, such as Professional, Standard, or Suite.
        /// </summary>
        [AttributeLogicalName("licensetype")]
        public Guid? LicenseType
        {
            get { return GetAttributeValue<Guid?>("licensetype"); }
            set
            {
                OnPropertyChanging("LicenseType");
                SetAttributeValue("licensetype", value);
                OnPropertyChanged("LicenseType");
            }
        }

        /// <summary>
        ///     Unique identifier of the organization associated with the license.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("timezoneruleversionnumber")]
        public int? TimeZoneRuleVersionNumber
        {
            get { return GetAttributeValue<int?>("timezoneruleversionnumber"); }
            set
            {
                OnPropertyChanging("TimeZoneRuleVersionNumber");
                SetAttributeValue("timezoneruleversionnumber", value);
                OnPropertyChanged("TimeZoneRuleVersionNumber");
            }
        }

        /// <summary>
        ///     Time zone code that was in use when the record was created.
        /// </summary>
        [AttributeLogicalName("utcconversiontimezonecode")]
        public int? UTCConversionTimeZoneCode
        {
            get { return GetAttributeValue<int?>("utcconversiontimezonecode"); }
            set
            {
                OnPropertyChanging("UTCConversionTimeZoneCode");
                SetAttributeValue("utcconversiontimezonecode", value);
                OnPropertyChanged("UTCConversionTimeZoneCode");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_license
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_license")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_license
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_license", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_license");
                SetRelatedEntities("userentityinstancedata_license", null, value);
                OnPropertyChanged("userentityinstancedata_license");
            }
        }

        /// <summary>
        ///     N:1 organization_licenses
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_licenses")]
        public Organization organization_licenses
        {
            get { return GetRelatedEntity<Organization>("organization_licenses", null); }
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