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
    ///     Group of privileges used to categorize users to provide appropriate access to entities.
    /// </summary>
    [DataContract]
    [EntityLogicalName("roleprivileges")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class RolePrivileges : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "roleprivileges";

        public const int EntityTypeCode = 12;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public RolePrivileges() :
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
        /// </summary>
        [AttributeLogicalName("ismanaged")]
        public bool? IsManaged
        {
            get { return GetAttributeValue<bool?>("ismanaged"); }
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
        ///     System-generated attribute that stores the privileges associated with the role.
        /// </summary>
        [AttributeLogicalName("privilegedepthmask")]
        public int? PrivilegeDepthMask
        {
            get { return GetAttributeValue<int?>("privilegedepthmask"); }
            set
            {
                OnPropertyChanging("PrivilegeDepthMask");
                SetAttributeValue("privilegedepthmask", value);
                OnPropertyChanged("PrivilegeDepthMask");
            }
        }

        /// <summary>
        ///     Unique identifier of the privilege associated with the role.
        /// </summary>
        [AttributeLogicalName("privilegeid")]
        public Guid? PrivilegeId
        {
            get { return GetAttributeValue<Guid?>("privilegeid"); }
        }

        /// <summary>
        ///     Unique identifier of the role that is associated with the role privilege.
        /// </summary>
        [AttributeLogicalName("roleid")]
        public Guid? RoleId
        {
            get { return GetAttributeValue<Guid?>("roleid"); }
        }

        /// <summary>
        ///     Unique identifier of the role privilege.
        /// </summary>
        [AttributeLogicalName("roleprivilegeid")]
        public Guid? RolePrivilegeId
        {
            get { return GetAttributeValue<Guid?>("roleprivilegeid"); }
            set
            {
                OnPropertyChanging("RolePrivilegeId");
                SetAttributeValue("roleprivilegeid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("RolePrivilegeId");
            }
        }

        [AttributeLogicalName("roleprivilegeid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { RolePrivilegeId = value; }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("roleprivilegeidunique")]
        public Guid? RolePrivilegeIdUnique
        {
            get { return GetAttributeValue<Guid?>("roleprivilegeidunique"); }
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
        ///     N:N roleprivileges_association
        /// </summary>
        [RelationshipSchemaName("roleprivileges_association")]
        public IEnumerable<Privilege> roleprivileges_association
        {
            get { return GetRelatedEntities<Privilege>("roleprivileges_association", null); }
            set
            {
                OnPropertyChanging("roleprivileges_association");
                SetRelatedEntities("roleprivileges_association", null, value);
                OnPropertyChanged("roleprivileges_association");
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