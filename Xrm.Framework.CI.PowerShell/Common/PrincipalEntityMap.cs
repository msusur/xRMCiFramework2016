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
    ///     Map CRM security principals (users and teams) to user/team owned entities with basic read privilege.
    /// </summary>
    [DataContract]
    [EntityLogicalName("principalentitymap")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class PrincipalEntityMap : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "principalentitymap";

        public const int EntityTypeCode = 41;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public PrincipalEntityMap() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("objecttypecode")]
        public string ObjectTypeCode
        {
            get { return GetAttributeValue<string>("objecttypecode"); }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("principalentitymapid")]
        public Guid? PrincipalEntityMapId
        {
            get { return GetAttributeValue<Guid?>("principalentitymapid"); }
            set
            {
                OnPropertyChanging("PrincipalEntityMapId");
                SetAttributeValue("principalentitymapid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("PrincipalEntityMapId");
            }
        }

        [AttributeLogicalName("principalentitymapid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { PrincipalEntityMapId = value; }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("principalid")]
        public Guid? PrincipalId
        {
            get { return GetAttributeValue<Guid?>("principalid"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N userentityinstancedata_principalentitymap
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_principalentitymap")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_principalentitymap
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_principalentitymap", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_principalentitymap");
                SetRelatedEntities("userentityinstancedata_principalentitymap", null, value);
                OnPropertyChanged("userentityinstancedata_principalentitymap");
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