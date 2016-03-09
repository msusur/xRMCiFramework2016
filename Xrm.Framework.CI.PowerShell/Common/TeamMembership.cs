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
    [EntityLogicalName("teammembership")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class TeamMembership : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "teammembership";

        public const int EntityTypeCode = 23;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public TeamMembership() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("systemuserid")]
        public Guid? SystemUserId
        {
            get { return GetAttributeValue<Guid?>("systemuserid"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("teamid")]
        public Guid? TeamId
        {
            get { return GetAttributeValue<Guid?>("teamid"); }
        }

        /// <summary>
        ///     Unique identifier of the team membership.
        /// </summary>
        [AttributeLogicalName("teammembershipid")]
        public Guid? TeamMembershipId
        {
            get { return GetAttributeValue<Guid?>("teammembershipid"); }
            set
            {
                OnPropertyChanging("TeamMembershipId");
                SetAttributeValue("teammembershipid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("TeamMembershipId");
            }
        }

        [AttributeLogicalName("teammembershipid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { TeamMembershipId = value; }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N userentityinstancedata_teammembership
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_teammembership")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_teammembership
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_teammembership", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_teammembership");
                SetRelatedEntities("userentityinstancedata_teammembership", null, value);
                OnPropertyChanged("userentityinstancedata_teammembership");
            }
        }

        /// <summary>
        ///     N:N teammembership_association
        /// </summary>
        [RelationshipSchemaName("teammembership_association")]
        public IEnumerable<Team> teammembership_association
        {
            get { return GetRelatedEntities<Team>("teammembership_association", null); }
            set
            {
                OnPropertyChanging("teammembership_association");
                SetRelatedEntities("teammembership_association", null, value);
                OnPropertyChanged("teammembership_association");
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