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
    ///     Group of privileges used to categorize users to provide appropriate access to secured columns.
    /// </summary>
    [DataContract]
    [EntityLogicalName("fieldpermission")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class FieldPermission : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "fieldpermission";

        public const int EntityTypeCode = 1201;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public FieldPermission() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Attribute Name.
        /// </summary>
        [AttributeLogicalName("attributelogicalname")]
        public string AttributeLogicalName
        {
            get { return GetAttributeValue<string>("attributelogicalname"); }
            set
            {
                OnPropertyChanging("AttributeLogicalName");
                SetAttributeValue("attributelogicalname", value);
                OnPropertyChanged("AttributeLogicalName");
            }
        }

        /// <summary>
        ///     Can this Profile create the attribute
        /// </summary>
        [AttributeLogicalName("cancreate")]
        public OptionSetValue CanCreate
        {
            get { return GetAttributeValue<OptionSetValue>("cancreate"); }
            set
            {
                OnPropertyChanging("CanCreate");
                SetAttributeValue("cancreate", value);
                OnPropertyChanged("CanCreate");
            }
        }

        /// <summary>
        ///     Can this Profile read the attribute
        /// </summary>
        [AttributeLogicalName("canread")]
        public OptionSetValue CanRead
        {
            get { return GetAttributeValue<OptionSetValue>("canread"); }
            set
            {
                OnPropertyChanging("CanRead");
                SetAttributeValue("canread", value);
                OnPropertyChanged("CanRead");
            }
        }

        /// <summary>
        ///     Can this Profile update the attribute
        /// </summary>
        [AttributeLogicalName("canupdate")]
        public OptionSetValue CanUpdate
        {
            get { return GetAttributeValue<OptionSetValue>("canupdate"); }
            set
            {
                OnPropertyChanging("CanUpdate");
                SetAttributeValue("canupdate", value);
                OnPropertyChanged("CanUpdate");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("componentstate")]
        public OptionSetValue ComponentState
        {
            get { return GetAttributeValue<OptionSetValue>("componentstate"); }
        }

        /// <summary>
        ///     Entity name.
        /// </summary>
        [AttributeLogicalName("entityname")]
        public string EntityName
        {
            get { return GetAttributeValue<string>("entityname"); }
            set
            {
                OnPropertyChanging("EntityName");
                SetAttributeValue("entityname", value);
                OnPropertyChanged("EntityName");
            }
        }

        /// <summary>
        ///     Unique identifier of the Field Permission.
        /// </summary>
        [AttributeLogicalName("fieldpermissionid")]
        public Guid? FieldPermissionId
        {
            get { return GetAttributeValue<Guid?>("fieldpermissionid"); }
            set
            {
                OnPropertyChanging("FieldPermissionId");
                SetAttributeValue("fieldpermissionid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("FieldPermissionId");
            }
        }

        [AttributeLogicalName("fieldpermissionid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { FieldPermissionId = value; }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("fieldpermissionidunique")]
        public Guid? FieldPermissionIdUnique
        {
            get { return GetAttributeValue<Guid?>("fieldpermissionidunique"); }
        }

        /// <summary>
        ///     Unique identifier of profile to which this privilege belongs.
        /// </summary>
        [AttributeLogicalName("fieldsecurityprofileid")]
        public EntityReference FieldSecurityProfileId
        {
            get { return GetAttributeValue<EntityReference>("fieldsecurityprofileid"); }
            set
            {
                OnPropertyChanging("FieldSecurityProfileId");
                SetAttributeValue("fieldsecurityprofileid", value);
                OnPropertyChanged("FieldSecurityProfileId");
            }
        }

        /// <summary>
        ///     Indicates whether the solution component is part of a managed solution.
        /// </summary>
        [AttributeLogicalName("ismanaged")]
        public bool? IsManaged
        {
            get { return GetAttributeValue<bool?>("ismanaged"); }
        }

        /// <summary>
        ///     Unique identifier for the organization
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("overwritetime")]
        public DateTime? OverwriteTime
        {
            get { return GetAttributeValue<DateTime?>("overwritetime"); }
        }

        /// <summary>
        ///     Unique identifier of the associated solution.
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
        ///     1:N userentityinstancedata_fieldpermission
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_fieldpermission")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_fieldpermission
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_fieldpermission", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_fieldpermission");
                SetRelatedEntities("userentityinstancedata_fieldpermission", null, value);
                OnPropertyChanged("userentityinstancedata_fieldpermission");
            }
        }

        /// <summary>
        ///     N:1 lk_fieldpermission_fieldsecurityprofileid
        /// </summary>
        [AttributeLogicalName("fieldsecurityprofileid")]
        [RelationshipSchemaName("lk_fieldpermission_fieldsecurityprofileid")]
        public FieldSecurityProfile lk_fieldpermission_fieldsecurityprofileid
        {
            get { return GetRelatedEntity<FieldSecurityProfile>("lk_fieldpermission_fieldsecurityprofileid", null); }
            set
            {
                OnPropertyChanging("lk_fieldpermission_fieldsecurityprofileid");
                SetRelatedEntity("lk_fieldpermission_fieldsecurityprofileid", null, value);
                OnPropertyChanged("lk_fieldpermission_fieldsecurityprofileid");
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