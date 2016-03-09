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
    [EntityLogicalName("systemuserlicenses")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class SystemUserLicenses : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "systemuserlicenses";

        public const int EntityTypeCode = 13;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public SystemUserLicenses() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("licenseid")]
        public Guid? LicenseId
        {
            get { return GetAttributeValue<Guid?>("licenseid"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("systemuserid")]
        public Guid? SystemUserId
        {
            get { return GetAttributeValue<Guid?>("systemuserid"); }
        }

        /// <summary>
        ///     Unique identifier of the user licenses.
        /// </summary>
        [AttributeLogicalName("systemuserlicenseid")]
        public Guid? SystemUserLicenseId
        {
            get { return GetAttributeValue<Guid?>("systemuserlicenseid"); }
            set
            {
                OnPropertyChanging("SystemUserLicenseId");
                SetAttributeValue("systemuserlicenseid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("SystemUserLicenseId");
            }
        }

        [AttributeLogicalName("systemuserlicenseid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { SystemUserLicenseId = value; }
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