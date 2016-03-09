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
    ///     Specifies the entity type that can play specific role in a connection.
    /// </summary>
    [DataContract]
    [EntityLogicalName("connectionroleobjecttypecode")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ConnectionRoleObjectTypeCode : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "connectionroleobjecttypecode";

        public const int EntityTypeCode = 3233;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ConnectionRoleObjectTypeCode() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("associatedobjecttypecode")]
        public string AssociatedObjectTypeCode
        {
            get { return GetAttributeValue<string>("associatedobjecttypecode"); }
            set
            {
                OnPropertyChanging("AssociatedObjectTypeCode");
                SetAttributeValue("associatedobjecttypecode", value);
                OnPropertyChanged("AssociatedObjectTypeCode");
            }
        }

        /// <summary>
        ///     Unique identifier of the connection role associated with the Connection Role Object Type Code.
        /// </summary>
        [AttributeLogicalName("connectionroleid")]
        public EntityReference ConnectionRoleId
        {
            get { return GetAttributeValue<EntityReference>("connectionroleid"); }
            set
            {
                OnPropertyChanging("ConnectionRoleId");
                SetAttributeValue("connectionroleid", value);
                OnPropertyChanged("ConnectionRoleId");
            }
        }

        /// <summary>
        ///     Unique identifier of the connection role object type association.
        /// </summary>
        [AttributeLogicalName("connectionroleobjecttypecodeid")]
        public Guid? ConnectionRoleObjectTypeCodeId
        {
            get { return GetAttributeValue<Guid?>("connectionroleobjecttypecodeid"); }
            set
            {
                OnPropertyChanging("ConnectionRoleObjectTypeCodeId");
                SetAttributeValue("connectionroleobjecttypecodeid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ConnectionRoleObjectTypeCodeId");
            }
        }

        [AttributeLogicalName("connectionroleobjecttypecodeid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ConnectionRoleObjectTypeCodeId = value; }
        }

        /// <summary>
        ///     Unique identifier of the organization associated with the connectionroleobjecttypecode.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public Guid? OrganizationId
        {
            get { return GetAttributeValue<Guid?>("organizationid"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N userentityinstancedata_connectionroleobjecttypecode
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_connectionroleobjecttypecode")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_connectionroleobjecttypecode
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>(
                    "userentityinstancedata_connectionroleobjecttypecode", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_connectionroleobjecttypecode");
                SetRelatedEntities("userentityinstancedata_connectionroleobjecttypecode", null, value);
                OnPropertyChanged("userentityinstancedata_connectionroleobjecttypecode");
            }
        }

        /// <summary>
        ///     N:1 connection_role_connection_role_object_type_codes
        /// </summary>
        [AttributeLogicalName("connectionroleid")]
        [RelationshipSchemaName("connection_role_connection_role_object_type_codes")]
        public ConnectionRole connection_role_connection_role_object_type_codes
        {
            get { return GetRelatedEntity<ConnectionRole>("connection_role_connection_role_object_type_codes", null); }
            set
            {
                OnPropertyChanging("connection_role_connection_role_object_type_codes");
                SetRelatedEntity("connection_role_connection_role_object_type_codes", null, value);
                OnPropertyChanged("connection_role_connection_role_object_type_codes");
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