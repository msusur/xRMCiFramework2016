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
    ///     Permission to perform an action in Microsoft CRM. The platform checks for the privilege and rejects the attempt if
    ///     the user does not hold the privilege.
    /// </summary>
    [DataContract]
    [EntityLogicalName("privilege")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Privilege : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "privilege";

        public const int EntityTypeCode = 1023;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Privilege() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Rights a user has to an instance of an entity.
        /// </summary>
        [AttributeLogicalName("accessright")]
        public int? AccessRight
        {
            get { return GetAttributeValue<int?>("accessright"); }
            set
            {
                OnPropertyChanging("AccessRight");
                SetAttributeValue("accessright", value);
                OnPropertyChanged("AccessRight");
            }
        }

        /// <summary>
        ///     Information that specifies whether the privilege applies to the user, the user's team, or objects shared by the
        ///     user.
        /// </summary>
        [AttributeLogicalName("canbebasic")]
        public bool? CanBeBasic
        {
            get { return GetAttributeValue<bool?>("canbebasic"); }
            set
            {
                OnPropertyChanging("CanBeBasic");
                SetAttributeValue("canbebasic", value);
                OnPropertyChanged("CanBeBasic");
            }
        }

        /// <summary>
        ///     Information that specifies whether the privilege applies to child business units of the business unit associated
        ///     with the user.
        /// </summary>
        [AttributeLogicalName("canbedeep")]
        public bool? CanBeDeep
        {
            get { return GetAttributeValue<bool?>("canbedeep"); }
            set
            {
                OnPropertyChanging("CanBeDeep");
                SetAttributeValue("canbedeep", value);
                OnPropertyChanged("CanBeDeep");
            }
        }

        /// <summary>
        ///     Information that specifies whether the privilege applies to the entire organization.
        /// </summary>
        [AttributeLogicalName("canbeglobal")]
        public bool? CanBeGlobal
        {
            get { return GetAttributeValue<bool?>("canbeglobal"); }
            set
            {
                OnPropertyChanging("CanBeGlobal");
                SetAttributeValue("canbeglobal", value);
                OnPropertyChanged("CanBeGlobal");
            }
        }

        /// <summary>
        ///     Information that specifies whether the privilege applies to the user's business unit.
        /// </summary>
        [AttributeLogicalName("canbelocal")]
        public bool? CanBeLocal
        {
            get { return GetAttributeValue<bool?>("canbelocal"); }
            set
            {
                OnPropertyChanging("CanBeLocal");
                SetAttributeValue("canbelocal", value);
                OnPropertyChanged("CanBeLocal");
            }
        }

        /// <summary>
        ///     Name of the privilege.
        /// </summary>
        [AttributeLogicalName("name")]
        public string Name
        {
            get { return GetAttributeValue<string>("name"); }
            set
            {
                OnPropertyChanging("Name");
                SetAttributeValue("name", value);
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        ///     Unique identifier of the privilege.
        /// </summary>
        [AttributeLogicalName("privilegeid")]
        public Guid? PrivilegeId
        {
            get { return GetAttributeValue<Guid?>("privilegeid"); }
            set
            {
                OnPropertyChanging("PrivilegeId");
                SetAttributeValue("privilegeid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("PrivilegeId");
            }
        }

        [AttributeLogicalName("privilegeid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { PrivilegeId = value; }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N Privilege_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Privilege_AsyncOperations")]
        public IEnumerable<AsyncOperation> Privilege_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Privilege_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Privilege_AsyncOperations");
                SetRelatedEntities("Privilege_AsyncOperations", null, value);
                OnPropertyChanged("Privilege_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N Privilege_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("Privilege_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> Privilege_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("Privilege_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("Privilege_BulkDeleteFailures");
                SetRelatedEntities("Privilege_BulkDeleteFailures", null, value);
                OnPropertyChanged("Privilege_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_privilege
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_privilege")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_privilege
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_privilege", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_privilege");
                SetRelatedEntities("userentityinstancedata_privilege", null, value);
                OnPropertyChanged("userentityinstancedata_privilege");
            }
        }

        /// <summary>
        ///     N:N roleprivileges_association
        /// </summary>
        [RelationshipSchemaName("roleprivileges_association")]
        public IEnumerable<Role> roleprivileges_association
        {
            get { return GetRelatedEntities<Role>("roleprivileges_association", null); }
            set
            {
                OnPropertyChanging("roleprivileges_association");
                SetRelatedEntities("roleprivileges_association", null, value);
                OnPropertyChanged("roleprivileges_association");
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