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
    ///     An invalid dependency in the CRM system.
    /// </summary>
    [DataContract]
    [EntityLogicalName("invaliddependency")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class InvalidDependency : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "invaliddependency";

        public const int EntityTypeCode = 7107;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public InvalidDependency() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the object that has an invalid dependency
        /// </summary>
        [AttributeLogicalName("existingcomponentid")]
        public Guid? ExistingComponentId
        {
            get { return GetAttributeValue<Guid?>("existingcomponentid"); }
        }

        /// <summary>
        ///     Component type of the object that has an invalid dependency
        /// </summary>
        [AttributeLogicalName("existingcomponenttype")]
        public OptionSetValue ExistingComponentType
        {
            get { return GetAttributeValue<OptionSetValue>("existingcomponenttype"); }
        }

        /// <summary>
        ///     The dependency type of the invalid dependency.
        /// </summary>
        [AttributeLogicalName("existingdependencytype")]
        public OptionSetValue ExistingDependencyType
        {
            get { return GetAttributeValue<OptionSetValue>("existingdependencytype"); }
        }

        /// <summary>
        ///     Unique identifier of the invalid dependency.
        /// </summary>
        [AttributeLogicalName("invaliddependencyid")]
        public Guid? InvalidDependencyId
        {
            get { return GetAttributeValue<Guid?>("invaliddependencyid"); }
        }

        [AttributeLogicalName("invaliddependencyid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { base.Id = value; }
        }

        /// <summary>
        ///     Indicates whether the existing node is the required component in the dependency
        /// </summary>
        [AttributeLogicalName("isexistingnoderequiredcomponent")]
        public bool? IsExistingNodeRequiredComponent
        {
            get { return GetAttributeValue<bool?>("isexistingnoderequiredcomponent"); }
        }

        /// <summary>
        ///     Unique identifier of the missing component.
        /// </summary>
        [AttributeLogicalName("missingcomponentid")]
        public Guid? MissingComponentId
        {
            get { return GetAttributeValue<Guid?>("missingcomponentid"); }
            set
            {
                OnPropertyChanging("MissingComponentId");
                SetAttributeValue("missingcomponentid", value);
                OnPropertyChanged("MissingComponentId");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("missingcomponentinfo")]
        public string MissingComponentInfo
        {
            get { return GetAttributeValue<string>("missingcomponentinfo"); }
        }

        /// <summary>
        ///     The lookup type of the missing component.
        /// </summary>
        [AttributeLogicalName("missingcomponentlookuptype")]
        public int? MissingComponentLookupType
        {
            get { return GetAttributeValue<int?>("missingcomponentlookuptype"); }
        }

        /// <summary>
        ///     The object type code of the missing component.
        /// </summary>
        [AttributeLogicalName("missingcomponenttype")]
        public OptionSetValue MissingComponentType
        {
            get { return GetAttributeValue<OptionSetValue>("missingcomponenttype"); }
        }

        /// <summary>
        ///     1:N userentityinstancedata_invaliddependency
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_invaliddependency")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_invaliddependency
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_invaliddependency", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_invaliddependency");
                SetRelatedEntities("userentityinstancedata_invaliddependency", null, value);
                OnPropertyChanged("userentityinstancedata_invaliddependency");
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