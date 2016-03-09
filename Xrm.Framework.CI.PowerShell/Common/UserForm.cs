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
    ///     User-owned dashboards.
    /// </summary>
    [DataContract]
    [EntityLogicalName("userform")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class UserForm : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "userform";

        public const int EntityTypeCode = 1031;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public UserForm() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Shows who created the record.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Shows the date and time when the record was created. The date and time are displayed in the time zone selected in
        ///     Microsoft Dynamics CRM options.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Shows who created the record on behalf of another user.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Type additional information to describe the form or dashboard, such as the filter criteria or intended audience.
        /// </summary>
        [AttributeLogicalName("description")]
        public string Description
        {
            get { return GetAttributeValue<string>("description"); }
            set
            {
                OnPropertyChanging("Description");
                SetAttributeValue("description", value);
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        ///     Shows the XML representation of the layout of the form or dashboard.
        /// </summary>
        [AttributeLogicalName("formxml")]
        public string FormXml
        {
            get { return GetAttributeValue<string>("formxml"); }
            set
            {
                OnPropertyChanging("FormXml");
                SetAttributeValue("formxml", value);
                OnPropertyChanged("FormXml");
            }
        }

        /// <summary>
        ///     Shows who last updated the record.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected
        ///     in Microsoft Dynamics CRM options.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Shows who created the record on behalf of another user.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Type a descriptive name for the form or dashboard.
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
        ///     Shows the record type (entity) code that the form applies to.
        /// </summary>
        [AttributeLogicalName("objecttypecode")]
        public string ObjectTypeCode
        {
            get { return GetAttributeValue<string>("objecttypecode"); }
            set
            {
                OnPropertyChanging("ObjectTypeCode");
                SetAttributeValue("objecttypecode", value);
                OnPropertyChanged("ObjectTypeCode");
            }
        }

        /// <summary>
        ///     Enter the user or team who is assigned to manage the record. This field is updated every time the record is
        ///     assigned to a different user.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId
        {
            get { return GetAttributeValue<EntityReference>("ownerid"); }
            set
            {
                OnPropertyChanging("OwnerId");
                SetAttributeValue("ownerid", value);
                OnPropertyChanged("OwnerId");
            }
        }

        /// <summary>
        ///     Shows the business unit that the record owner belongs to.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the dashboard.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the dashboard.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Select the form type.
        /// </summary>
        [AttributeLogicalName("type")]
        public OptionSetValue Type
        {
            get { return GetAttributeValue<OptionSetValue>("type"); }
            set
            {
                OnPropertyChanging("Type");
                SetAttributeValue("type", value);
                OnPropertyChanged("Type");
            }
        }

        /// <summary>
        ///     Unique identifier of the user dashboard.
        /// </summary>
        [AttributeLogicalName("userformid")]
        public Guid? UserFormId
        {
            get { return GetAttributeValue<Guid?>("userformid"); }
            set
            {
                OnPropertyChanging("UserFormId");
                SetAttributeValue("userformid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("UserFormId");
            }
        }

        [AttributeLogicalName("userformid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { UserFormId = value; }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N userentityinstancedata_userform
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_userform")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_userform
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_userform", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_userform");
                SetRelatedEntities("userentityinstancedata_userform", null, value);
                OnPropertyChanged("userentityinstancedata_userform");
            }
        }

        /// <summary>
        ///     1:N UserForm_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("UserForm_AsyncOperations")]
        public IEnumerable<AsyncOperation> UserForm_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("UserForm_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("UserForm_AsyncOperations");
                SetRelatedEntities("UserForm_AsyncOperations", null, value);
                OnPropertyChanged("UserForm_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N UserForm_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("UserForm_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> UserForm_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("UserForm_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("UserForm_BulkDeleteFailures");
                SetRelatedEntities("UserForm_BulkDeleteFailures", null, value);
                OnPropertyChanged("UserForm_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     N:1 business_unit_userform
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_userform")]
        public BusinessUnit business_unit_userform
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_userform", null); }
        }

        /// <summary>
        ///     N:1 lk_userform_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_userform_createdby")]
        public SystemUser lk_userform_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_userform_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_userform_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_userform_modifiedby")]
        public SystemUser lk_userform_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_userform_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_userformbase_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_userformbase_createdonbehalfby")]
        public SystemUser lk_userformbase_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_userformbase_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_userformbase_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_userformbase_modifiedonbehalfby")]
        public SystemUser lk_userformbase_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_userformbase_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 team_userform
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_userform")]
        public Team team_userform
        {
            get { return GetRelatedEntity<Team>("team_userform", null); }
        }

        /// <summary>
        ///     N:1 user_userform
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_userform")]
        public SystemUser user_userform
        {
            get { return GetRelatedEntity<SystemUser>("user_userform", null); }
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