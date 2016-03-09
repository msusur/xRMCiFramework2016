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
    [EntityLogicalName("systemuserroles")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class SystemUserRoles : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "systemuserroles";

        public const int EntityTypeCode = 15;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public SystemUserRoles() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("roleid")]
        public Guid? RoleId
        {
            get { return GetAttributeValue<Guid?>("roleid"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("systemuserid")]
        public Guid? SystemUserId
        {
            get { return GetAttributeValue<Guid?>("systemuserid"); }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("systemuserroleid")]
        public Guid? SystemUserRoleId
        {
            get { return GetAttributeValue<Guid?>("systemuserroleid"); }
            set
            {
                OnPropertyChanging("SystemUserRoleId");
                SetAttributeValue("systemuserroleid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("SystemUserRoleId");
            }
        }

        [AttributeLogicalName("systemuserroleid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { SystemUserRoleId = value; }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     N:N systemuserroles_association
        /// </summary>
        [RelationshipSchemaName("systemuserroles_association")]
        public IEnumerable<SystemUser> systemuserroles_association
        {
            get { return GetRelatedEntities<SystemUser>("systemuserroles_association", null); }
            set
            {
                OnPropertyChanging("systemuserroles_association");
                SetRelatedEntities("systemuserroles_association", null, value);
                OnPropertyChanged("systemuserroles_association");
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