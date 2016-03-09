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
    [EntityLogicalName("systemuserprofiles")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class SystemUserProfiles : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "systemuserprofiles";

        public const int EntityTypeCode = 1202;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public SystemUserProfiles() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("fieldsecurityprofileid")]
        public Guid? FieldSecurityProfileId
        {
            get { return GetAttributeValue<Guid?>("fieldsecurityprofileid"); }
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
        [AttributeLogicalName("systemuserprofileid")]
        public Guid? SystemUserProfileId
        {
            get { return GetAttributeValue<Guid?>("systemuserprofileid"); }
            set
            {
                OnPropertyChanging("SystemUserProfileId");
                SetAttributeValue("systemuserprofileid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("SystemUserProfileId");
            }
        }

        [AttributeLogicalName("systemuserprofileid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { SystemUserProfileId = value; }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
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