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
    ///     Profile which defines access level for secured attributes
    /// </summary>
    [DataContract]
    [EntityLogicalName("fieldsecurityprofile")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class FieldSecurityProfile : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "fieldsecurityprofile";

        public const int EntityTypeCode = 1200;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public FieldSecurityProfile() :
            base(EntityLogicalName)
        {
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
        ///     Unique identifier of the user who created the profile.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the profile was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the role.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Description of the Profile
        /// </summary>
        [AttributeLogicalName("description")]
        public string Description
        {
            get { return GetAttributeValue<string>("description"); }
            set
            {
                OnPropertyChanging("Description");
                SetAttributeValue("description", value);
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        ///     Unique identifier of the profile.
        /// </summary>
        [AttributeLogicalName("fieldsecurityprofileid")]
        public Guid? FieldSecurityProfileId
        {
            get { return GetAttributeValue<Guid?>("fieldsecurityprofileid"); }
            set
            {
                OnPropertyChanging("FieldSecurityProfileId");
                SetAttributeValue("fieldsecurityprofileid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("FieldSecurityProfileId");
            }
        }

        [AttributeLogicalName("fieldsecurityprofileid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { FieldSecurityProfileId = value; }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("fieldsecurityprofileidunique")]
        public Guid? FieldSecurityProfileIdUnique
        {
            get { return GetAttributeValue<Guid?>("fieldsecurityprofileidunique"); }
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
        ///     Unique identifier of the user who last modified the profile.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the profile was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the profile.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the profile.
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
        ///     Unique identifier of the associated organization.
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
        ///     1:N lk_fieldpermission_fieldsecurityprofileid
        /// </summary>
        [RelationshipSchemaName("lk_fieldpermission_fieldsecurityprofileid")]
        public IEnumerable<FieldPermission> lk_fieldpermission_fieldsecurityprofileid
        {
            get { return GetRelatedEntities<FieldPermission>("lk_fieldpermission_fieldsecurityprofileid", null); }
            set
            {
                OnPropertyChanging("lk_fieldpermission_fieldsecurityprofileid");
                SetRelatedEntities("lk_fieldpermission_fieldsecurityprofileid", null, value);
                OnPropertyChanged("lk_fieldpermission_fieldsecurityprofileid");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_fieldsecurityprofile
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_fieldsecurityprofile")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_fieldsecurityprofile
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_fieldsecurityprofile", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_fieldsecurityprofile");
                SetRelatedEntities("userentityinstancedata_fieldsecurityprofile", null, value);
                OnPropertyChanged("userentityinstancedata_fieldsecurityprofile");
            }
        }

        /// <summary>
        ///     N:N systemuserprofiles_association
        /// </summary>
        [RelationshipSchemaName("systemuserprofiles_association")]
        public IEnumerable<SystemUser> systemuserprofiles_association
        {
            get { return GetRelatedEntities<SystemUser>("systemuserprofiles_association", null); }
            set
            {
                OnPropertyChanging("systemuserprofiles_association");
                SetRelatedEntities("systemuserprofiles_association", null, value);
                OnPropertyChanged("systemuserprofiles_association");
            }
        }

        /// <summary>
        ///     N:N teamprofiles_association
        /// </summary>
        [RelationshipSchemaName("teamprofiles_association")]
        public IEnumerable<Team> teamprofiles_association
        {
            get { return GetRelatedEntities<Team>("teamprofiles_association", null); }
            set
            {
                OnPropertyChanging("teamprofiles_association");
                SetRelatedEntities("teamprofiles_association", null, value);
                OnPropertyChanged("teamprofiles_association");
            }
        }

        /// <summary>
        ///     N:1 lk_fieldsecurityprofile_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_fieldsecurityprofile_createdby")]
        public SystemUser lk_fieldsecurityprofile_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_fieldsecurityprofile_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_fieldsecurityprofile_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_fieldsecurityprofile_createdonbehalfby")]
        public SystemUser lk_fieldsecurityprofile_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_fieldsecurityprofile_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_fieldsecurityprofile_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_fieldsecurityprofile_modifiedby")]
        public SystemUser lk_fieldsecurityprofile_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_fieldsecurityprofile_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_fieldsecurityprofile_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_fieldsecurityprofile_modifiedonbehalfby")]
        public SystemUser lk_fieldsecurityprofile_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_fieldsecurityprofile_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_fieldsecurityprofile_organizationid
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("lk_fieldsecurityprofile_organizationid")]
        public Organization lk_fieldsecurityprofile_organizationid
        {
            get { return GetRelatedEntity<Organization>("lk_fieldsecurityprofile_organizationid", null); }
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