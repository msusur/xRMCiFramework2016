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
    ///     Team Profiles
    /// </summary>
    [DataContract]
    [EntityLogicalName("teamprofiles")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class TeamProfiles : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "teamprofiles";

        public const int EntityTypeCode = 1203;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public TeamProfiles() :
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
        [AttributeLogicalName("teamid")]
        public Guid? TeamId
        {
            get { return GetAttributeValue<Guid?>("teamid"); }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("teamprofileid")]
        public Guid? TeamProfileId
        {
            get { return GetAttributeValue<Guid?>("teamprofileid"); }
            set
            {
                OnPropertyChanging("TeamProfileId");
                SetAttributeValue("teamprofileid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("TeamProfileId");
            }
        }

        [AttributeLogicalName("teamprofileid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { TeamProfileId = value; }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
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