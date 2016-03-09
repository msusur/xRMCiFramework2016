using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Xrm.Framework.CI.Common.Entities
{
    /// <summary>
    /// </summary>
    [DataContract]
    [EntityLogicalName("roletemplateprivileges")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class RoleTemplatePrivileges : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "roletemplateprivileges";

        public const int EntityTypeCode = 28;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public RoleTemplatePrivileges() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Information about whether the role in the template applies to the user, the user's team, or objects shared by the
        ///     user.
        /// </summary>
        [AttributeLogicalName("isbasic")]
        public bool? IsBasic
        {
            get { return GetAttributeValue<bool?>("isbasic"); }
            set
            {
                OnPropertyChanging("IsBasic");
                SetAttributeValue("isbasic", value);
                OnPropertyChanged("IsBasic");
            }
        }

        /// <summary>
        ///     Information about whether the role in the template applies to child business units of the business unit associated
        ///     with the user.
        /// </summary>
        [AttributeLogicalName("isdeep")]
        public bool? IsDeep
        {
            get { return GetAttributeValue<bool?>("isdeep"); }
            set
            {
                OnPropertyChanging("IsDeep");
                SetAttributeValue("isdeep", value);
                OnPropertyChanged("IsDeep");
            }
        }

        /// <summary>
        ///     Information about whether the role in the template applies to the entire organization.
        /// </summary>
        [AttributeLogicalName("isglobal")]
        public bool? IsGlobal
        {
            get { return GetAttributeValue<bool?>("isglobal"); }
            set
            {
                OnPropertyChanging("IsGlobal");
                SetAttributeValue("isglobal", value);
                OnPropertyChanged("IsGlobal");
            }
        }

        /// <summary>
        ///     Information about whether the role in the template applies to the user's business unit.
        /// </summary>
        [AttributeLogicalName("islocal")]
        public bool? IsLocal
        {
            get { return GetAttributeValue<bool?>("islocal"); }
            set
            {
                OnPropertyChanging("IsLocal");
                SetAttributeValue("islocal", value);
                OnPropertyChanged("IsLocal");
            }
        }

        /// <summary>
        ///     Unique identifier of the privilege assigned to the role template.
        /// </summary>
        [AttributeLogicalName("privilegeid")]
        public Guid? PrivilegeId
        {
            get { return GetAttributeValue<Guid?>("privilegeid"); }
        }

        /// <summary>
        ///     Unique identifier of the role template that is associated with the role privilege.
        /// </summary>
        [AttributeLogicalName("roletemplateid")]
        public Guid? RoleTemplateId
        {
            get { return GetAttributeValue<Guid?>("roletemplateid"); }
        }

        /// <summary>
        ///     Unique identifier of the role template privileges.
        /// </summary>
        [AttributeLogicalName("roletemplateprivilegeid")]
        public Guid? RoleTemplatePrivilegeId
        {
            get { return GetAttributeValue<Guid?>("roletemplateprivilegeid"); }
            set
            {
                OnPropertyChanging("RoleTemplatePrivilegeId");
                SetAttributeValue("roletemplateprivilegeid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("RoleTemplatePrivilegeId");
            }
        }

        [AttributeLogicalName("roletemplateprivilegeid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { RoleTemplatePrivilegeId = value; }
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