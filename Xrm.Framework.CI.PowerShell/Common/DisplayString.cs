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
    ///     Customized messages for an entity that has been renamed.
    /// </summary>
    [DataContract]
    [EntityLogicalName("displaystring")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class DisplayString : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "displaystring";

        public const int EntityTypeCode = 4102;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public DisplayString() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("componentstate")]
        public OptionSetValue ComponentState
        {
            get { return GetAttributeValue<OptionSetValue>("componentstate"); }
        }

        /// <summary>
        ///     Unique identifier of the user who created the display string.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the display string was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the displaystring.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Comment for a customized display string.
        /// </summary>
        [AttributeLogicalName("customcomment")]
        public string CustomComment
        {
            get { return GetAttributeValue<string>("customcomment"); }
            set
            {
                OnPropertyChanging("CustomComment");
                SetAttributeValue("customcomment", value);
                OnPropertyChanged("CustomComment");
            }
        }

        /// <summary>
        ///     Customized display string.
        /// </summary>
        [AttributeLogicalName("customdisplaystring")]
        public string CustomDisplayString
        {
            get { return GetAttributeValue<string>("customdisplaystring"); }
            set
            {
                OnPropertyChanging("CustomDisplayString");
                SetAttributeValue("customdisplaystring", value);
                OnPropertyChanged("CustomDisplayString");
            }
        }

        /// <summary>
        ///     Unique identifier of the display string.
        /// </summary>
        [AttributeLogicalName("displaystringid")]
        public Guid? DisplayStringId
        {
            get { return GetAttributeValue<Guid?>("displaystringid"); }
            set
            {
                OnPropertyChanging("DisplayStringId");
                SetAttributeValue("displaystringid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("DisplayStringId");
            }
        }

        [AttributeLogicalName("displaystringid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { DisplayStringId = value; }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("displaystringidunique")]
        public Guid? DisplayStringIdUnique
        {
            get { return GetAttributeValue<Guid?>("displaystringidunique"); }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("displaystringkey")]
        public string DisplayStringKey
        {
            get { return GetAttributeValue<string>("displaystringkey"); }
        }

        /// <summary>
        ///     Parameters used for formatting the display string.
        /// </summary>
        [AttributeLogicalName("formatparameters")]
        public int? FormatParameters
        {
            get { return GetAttributeValue<int?>("formatparameters"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("ismanaged")]
        public bool? IsManaged
        {
            get { return GetAttributeValue<bool?>("ismanaged"); }
        }

        /// <summary>
        ///     Language code of the display string.
        /// </summary>
        [AttributeLogicalName("languagecode")]
        public int? LanguageCode
        {
            get { return GetAttributeValue<int?>("languagecode"); }
            set
            {
                OnPropertyChanging("LanguageCode");
                SetAttributeValue("languagecode", value);
                OnPropertyChanged("LanguageCode");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the display string.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the display string was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the displaystring.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the organization associated with the display string.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("overwritetime")]
        public DateTime? OverwriteTime
        {
            get { return GetAttributeValue<DateTime?>("overwritetime"); }
        }

        /// <summary>
        ///     Published display string.
        /// </summary>
        [AttributeLogicalName("publisheddisplaystring")]
        public string PublishedDisplayString
        {
            get { return GetAttributeValue<string>("publisheddisplaystring"); }
        }

        /// <summary>
        ///     Unique identifier of the associated solution.
        /// </summary>
        [AttributeLogicalName("solutionid")]
        public Guid? SolutionId
        {
            get { return GetAttributeValue<Guid?>("solutionid"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N DisplayString_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("DisplayString_AsyncOperations")]
        public IEnumerable<AsyncOperation> DisplayString_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("DisplayString_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("DisplayString_AsyncOperations");
                SetRelatedEntities("DisplayString_AsyncOperations", null, value);
                OnPropertyChanged("DisplayString_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N DisplayString_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("DisplayString_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> DisplayString_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("DisplayString_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("DisplayString_BulkDeleteFailures");
                SetRelatedEntities("DisplayString_BulkDeleteFailures", null, value);
                OnPropertyChanged("DisplayString_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_displaystring
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_displaystring")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_displaystring
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_displaystring", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_displaystring");
                SetRelatedEntities("userentityinstancedata_displaystring", null, value);
                OnPropertyChanged("userentityinstancedata_displaystring");
            }
        }

        /// <summary>
        ///     N:1 lk_DisplayStringbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_DisplayStringbase_createdby")]
        public SystemUser lk_DisplayStringbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_DisplayStringbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_DisplayStringbase_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_DisplayStringbase_createdonbehalfby")]
        public SystemUser lk_DisplayStringbase_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_DisplayStringbase_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_DisplayStringbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_DisplayStringbase_modifiedby")]
        public SystemUser lk_DisplayStringbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_DisplayStringbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_DisplayStringbase_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_DisplayStringbase_modifiedonbehalfby")]
        public SystemUser lk_DisplayStringbase_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_DisplayStringbase_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 organization_custom_displaystrings
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_custom_displaystrings")]
        public Organization organization_custom_displaystrings
        {
            get { return GetRelatedEntity<Organization>("organization_custom_displaystrings", null); }
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