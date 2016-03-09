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
    ///     Track changes to records for analysis, record keeping, and compliance.
    /// </summary>
    [DataContract]
    [EntityLogicalName("audit")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Audit : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "audit";

        public const int EntityTypeCode = 4567;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Audit() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Actions the user can perform that cause a change
        /// </summary>
        [AttributeLogicalName("action")]
        public OptionSetValue Action
        {
            get { return GetAttributeValue<OptionSetValue>("action"); }
        }

        /// <summary>
        ///     Contains a CSV of the ColumnNumber metadata property of attributes
        /// </summary>
        [AttributeLogicalName("attributemask")]
        public string AttributeMask
        {
            get { return GetAttributeValue<string>("attributemask"); }
        }

        /// <summary>
        ///     Unique identifier of the auditing instance
        /// </summary>
        [AttributeLogicalName("auditid")]
        public Guid? AuditId
        {
            get { return GetAttributeValue<Guid?>("auditid"); }
        }

        [AttributeLogicalName("auditid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { base.Id = value; }
        }

        /// <summary>
        ///     Unique identifier of the calling user in case of an impersonated call
        /// </summary>
        [AttributeLogicalName("callinguserid")]
        public EntityReference CallingUserId
        {
            get { return GetAttributeValue<EntityReference>("callinguserid"); }
        }

        /// <summary>
        ///     Date and time when the audit record was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the record that is being audited
        /// </summary>
        [AttributeLogicalName("objectid")]
        public EntityReference ObjectId
        {
            get { return GetAttributeValue<EntityReference>("objectid"); }
        }

        /// <summary>
        ///     The action that causes the audit--it will be create, delete, or update
        /// </summary>
        [AttributeLogicalName("operation")]
        public OptionSetValue Operation
        {
            get { return GetAttributeValue<OptionSetValue>("operation"); }
        }

        /// <summary>
        ///     Unique identifier for multiple changes that are part of a single operation; this field contains the same GUID for
        ///     all the audit rows generated in a single transaction
        /// </summary>
        [AttributeLogicalName("transactionid")]
        public Guid? TransactionId
        {
            get { return GetAttributeValue<Guid?>("transactionid"); }
        }

        /// <summary>
        ///     Unique identifier of the user who caused a change
        /// </summary>
        [AttributeLogicalName("userid")]
        public EntityReference UserId
        {
            get { return GetAttributeValue<EntityReference>("userid"); }
        }

        /// <summary>
        ///     1:N userentityinstancedata_audit
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_audit")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_audit
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_audit", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_audit");
                SetRelatedEntities("userentityinstancedata_audit", null, value);
                OnPropertyChanged("userentityinstancedata_audit");
            }
        }

        /// <summary>
        ///     N:1 lk_audit_callinguserid
        /// </summary>
        [AttributeLogicalName("callinguserid")]
        [RelationshipSchemaName("lk_audit_callinguserid")]
        public SystemUser lk_audit_callinguserid
        {
            get { return GetRelatedEntity<SystemUser>("lk_audit_callinguserid", null); }
        }

        /// <summary>
        ///     N:1 lk_audit_userid
        /// </summary>
        [AttributeLogicalName("userid")]
        [RelationshipSchemaName("lk_audit_userid")]
        public SystemUser lk_audit_userid
        {
            get { return GetRelatedEntity<SystemUser>("lk_audit_userid", null); }
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