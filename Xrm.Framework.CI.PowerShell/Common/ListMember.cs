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
    ///     Item in a marketing list.
    /// </summary>
    [DataContract]
    [EntityLogicalName("listmember")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ListMember : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "listmember";

        public const int EntityTypeCode = 4301;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ListMember() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("entityid")]
        public EntityReference EntityId
        {
            get { return GetAttributeValue<EntityReference>("entityid"); }
            set
            {
                OnPropertyChanging("EntityId");
                SetAttributeValue("entityid", value);
                OnPropertyChanged("EntityId");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("entitytype")]
        public string EntityType
        {
            get { return GetAttributeValue<string>("entitytype"); }
            set
            {
                OnPropertyChanging("EntityType");
                SetAttributeValue("entitytype", value);
                OnPropertyChanged("EntityType");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("listid")]
        public EntityReference ListId
        {
            get { return GetAttributeValue<EntityReference>("listid"); }
            set
            {
                OnPropertyChanging("ListId");
                SetAttributeValue("listid", value);
                OnPropertyChanged("ListId");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("listmemberid")]
        public Guid? ListMemberId
        {
            get { return GetAttributeValue<Guid?>("listmemberid"); }
            set
            {
                OnPropertyChanging("ListMemberId");
                SetAttributeValue("listmemberid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ListMemberId");
            }
        }

        [AttributeLogicalName("listmemberid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ListMemberId = value; }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the list member.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the list member was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the listmember.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the user or team who owns the list member.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId
        {
            get { return GetAttributeValue<EntityReference>("ownerid"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public Guid? OwningBusinessUnit
        {
            get { return GetAttributeValue<Guid?>("owningbusinessunit"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public Guid? OwningUser
        {
            get { return GetAttributeValue<Guid?>("owninguser"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N userentityinstancedata_listmember
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_listmember")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_listmember
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_listmember", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_listmember");
                SetRelatedEntities("userentityinstancedata_listmember", null, value);
                OnPropertyChanged("userentityinstancedata_listmember");
            }
        }

        /// <summary>
        ///     N:N listaccount_association
        /// </summary>
        [RelationshipSchemaName("listaccount_association")]
        public IEnumerable<List> listaccount_association
        {
            get { return GetRelatedEntities<List>("listaccount_association", null); }
            set
            {
                OnPropertyChanging("listaccount_association");
                SetRelatedEntities("listaccount_association", null, value);
                OnPropertyChanged("listaccount_association");
            }
        }

        /// <summary>
        ///     N:N listcontact_association
        /// </summary>
        [RelationshipSchemaName("listcontact_association")]
        public IEnumerable<List> listcontact_association
        {
            get { return GetRelatedEntities<List>("listcontact_association", null); }
            set
            {
                OnPropertyChanging("listcontact_association");
                SetRelatedEntities("listcontact_association", null, value);
                OnPropertyChanged("listcontact_association");
            }
        }

        /// <summary>
        ///     N:N listlead_association
        /// </summary>
        [RelationshipSchemaName("listlead_association")]
        public IEnumerable<List> listlead_association
        {
            get { return GetRelatedEntities<List>("listlead_association", null); }
            set
            {
                OnPropertyChanging("listlead_association");
                SetRelatedEntities("listlead_association", null, value);
                OnPropertyChanged("listlead_association");
            }
        }

        /// <summary>
        ///     N:1 lk_listmember_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_listmember_createdby")]
        public SystemUser lk_listmember_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_listmember_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_listmember_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_listmember_createdonbehalfby")]
        public SystemUser lk_listmember_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_listmember_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_listmember_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_listmember_modifiedby")]
        public SystemUser lk_listmember_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_listmember_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_listmember_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_listmember_modifiedonbehalfby")]
        public SystemUser lk_listmember_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_listmember_modifiedonbehalfby", null); }
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