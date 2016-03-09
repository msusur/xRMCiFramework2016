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
    [EntityLogicalName("teamroles")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class TeamRoles : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "teamroles";

        public const int EntityTypeCode = 40;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public TeamRoles() :
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
        [AttributeLogicalName("teamid")]
        public Guid? TeamId
        {
            get { return GetAttributeValue<Guid?>("teamid"); }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("teamroleid")]
        public Guid? TeamRoleId
        {
            get { return GetAttributeValue<Guid?>("teamroleid"); }
            set
            {
                OnPropertyChanging("TeamRoleId");
                SetAttributeValue("teamroleid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("TeamRoleId");
            }
        }

        [AttributeLogicalName("teamroleid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { TeamRoleId = value; }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     N:N teamroles_association
        /// </summary>
        [RelationshipSchemaName("teamroles_association")]
        public IEnumerable<Team> teamroles_association
        {
            get { return GetRelatedEntities<Team>("teamroles_association", null); }
            set
            {
                OnPropertyChanging("teamroles_association");
                SetRelatedEntities("teamroles_association", null, value);
                OnPropertyChanged("teamroles_association");
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