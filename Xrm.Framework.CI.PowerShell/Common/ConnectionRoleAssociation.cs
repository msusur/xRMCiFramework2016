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
    [EntityLogicalName("connectionroleassociation")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ConnectionRoleAssociation : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "connectionroleassociation";

        public const int EntityTypeCode = 3232;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ConnectionRoleAssociation() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("associatedconnectionroleid")]
        public Guid? AssociatedConnectionRoleId
        {
            get { return GetAttributeValue<Guid?>("associatedconnectionroleid"); }
            set
            {
                OnPropertyChanging("AssociatedConnectionRoleId");
                SetAttributeValue("associatedconnectionroleid", value);
                OnPropertyChanged("AssociatedConnectionRoleId");
            }
        }

        /// <summary>
        ///     Unique identifier of the connection role association.
        /// </summary>
        [AttributeLogicalName("connectionroleassociationid")]
        public Guid? ConnectionRoleAssociationId
        {
            get { return GetAttributeValue<Guid?>("connectionroleassociationid"); }
            set
            {
                OnPropertyChanging("ConnectionRoleAssociationId");
                SetAttributeValue("connectionroleassociationid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ConnectionRoleAssociationId");
            }
        }

        [AttributeLogicalName("connectionroleassociationid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ConnectionRoleAssociationId = value; }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("connectionroleid")]
        public Guid? ConnectionRoleId
        {
            get { return GetAttributeValue<Guid?>("connectionroleid"); }
            set
            {
                OnPropertyChanging("ConnectionRoleId");
                SetAttributeValue("connectionroleid", value);
                OnPropertyChanged("ConnectionRoleId");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N userentityinstancedata_connectionroleassociation
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_connectionroleassociation")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_connectionroleassociation
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_connectionroleassociation",
                    null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_connectionroleassociation");
                SetRelatedEntities("userentityinstancedata_connectionroleassociation", null, value);
                OnPropertyChanged("userentityinstancedata_connectionroleassociation");
            }
        }

        /// <summary>
        ///     N:N connectionroleassociation_association
        /// </summary>
        [RelationshipSchemaName("connectionroleassociation_association")]
        public IEnumerable<ConnectionRole> connectionroleassociation_association
        {
            get { return GetRelatedEntities<ConnectionRole>("connectionroleassociation_association", null); }
            set
            {
                OnPropertyChanging("connectionroleassociation_association");
                SetRelatedEntities("connectionroleassociation_association", null, value);
                OnPropertyChanged("connectionroleassociation_association");
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