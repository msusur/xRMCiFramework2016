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
    ///     Condition of a duplicate detection rule.
    /// </summary>
    [DataContract]
    [EntityLogicalName("duplicaterulecondition")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class DuplicateRuleCondition : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "duplicaterulecondition";

        public const int EntityTypeCode = 4416;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public DuplicateRuleCondition() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Field that is being compared.
        /// </summary>
        [AttributeLogicalName("baseattributename")]
        public string BaseAttributeName
        {
            get { return GetAttributeValue<string>("baseattributename"); }
            set
            {
                OnPropertyChanging("BaseAttributeName");
                SetAttributeValue("baseattributename", value);
                OnPropertyChanged("BaseAttributeName");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the condition.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the condition was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the duplicate rule condition.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the condition.
        /// </summary>
        [AttributeLogicalName("duplicateruleconditionid")]
        public Guid? DuplicateRuleConditionId
        {
            get { return GetAttributeValue<Guid?>("duplicateruleconditionid"); }
            set
            {
                OnPropertyChanging("DuplicateRuleConditionId");
                SetAttributeValue("duplicateruleconditionid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("DuplicateRuleConditionId");
            }
        }

        [AttributeLogicalName("duplicateruleconditionid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { DuplicateRuleConditionId = value; }
        }

        /// <summary>
        ///     Determines whether to consider blank values as non-duplicate values
        /// </summary>
        [AttributeLogicalName("ignoreblankvalues")]
        public bool? IgnoreBlankValues
        {
            get { return GetAttributeValue<bool?>("ignoreblankvalues"); }
            set
            {
                OnPropertyChanging("IgnoreBlankValues");
                SetAttributeValue("ignoreblankvalues", value);
                OnPropertyChanged("IgnoreBlankValues");
            }
        }

        /// <summary>
        ///     Field that is being compared with the base field.
        /// </summary>
        [AttributeLogicalName("matchingattributename")]
        public string MatchingAttributeName
        {
            get { return GetAttributeValue<string>("matchingattributename"); }
            set
            {
                OnPropertyChanging("MatchingAttributeName");
                SetAttributeValue("matchingattributename", value);
                OnPropertyChanged("MatchingAttributeName");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the condition.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the condition was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the duplicate rule condition.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Operator for this rule condition.
        /// </summary>
        [AttributeLogicalName("operatorcode")]
        public OptionSetValue OperatorCode
        {
            get { return GetAttributeValue<OptionSetValue>("operatorcode"); }
            set
            {
                OnPropertyChanging("OperatorCode");
                SetAttributeValue("operatorcode", value);
                OnPropertyChanged("OperatorCode");
            }
        }

        /// <summary>
        ///     Parameter value of N if the operator is Same First Characters or Same Last Characters.
        /// </summary>
        [AttributeLogicalName("operatorparam")]
        public int? OperatorParam
        {
            get { return GetAttributeValue<int?>("operatorparam"); }
            set
            {
                OnPropertyChanging("OperatorParam");
                SetAttributeValue("operatorparam", value);
                OnPropertyChanged("OperatorParam");
            }
        }

        /// <summary>
        ///     Unique identifier of the user or team who owns the duplicate rule condition.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId
        {
            get { return GetAttributeValue<EntityReference>("ownerid"); }
        }

        /// <summary>
        ///     Unique identifier of the business unit that owns the condition.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public Guid? OwningBusinessUnit
        {
            get { return GetAttributeValue<Guid?>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the condition.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public Guid? OwningUser
        {
            get { return GetAttributeValue<Guid?>("owninguser"); }
        }

        /// <summary>
        ///     Unique identifier of the object with which the condition is associated.
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        public EntityReference RegardingObjectId
        {
            get { return GetAttributeValue<EntityReference>("regardingobjectid"); }
            set
            {
                OnPropertyChanging("RegardingObjectId");
                SetAttributeValue("regardingobjectid", value);
                OnPropertyChanged("RegardingObjectId");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_duplicaterulecondition
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_duplicaterulecondition")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_duplicaterulecondition
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_duplicaterulecondition", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_duplicaterulecondition");
                SetRelatedEntities("userentityinstancedata_duplicaterulecondition", null, value);
                OnPropertyChanged("userentityinstancedata_duplicaterulecondition");
            }
        }

        /// <summary>
        ///     N:1 DuplicateRule_DuplicateRuleConditions
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("DuplicateRule_DuplicateRuleConditions")]
        public DuplicateRule DuplicateRule_DuplicateRuleConditions
        {
            get { return GetRelatedEntity<DuplicateRule>("DuplicateRule_DuplicateRuleConditions", null); }
            set
            {
                OnPropertyChanging("DuplicateRule_DuplicateRuleConditions");
                SetRelatedEntity("DuplicateRule_DuplicateRuleConditions", null, value);
                OnPropertyChanged("DuplicateRule_DuplicateRuleConditions");
            }
        }

        /// <summary>
        ///     N:1 lk_duplicaterulecondition_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_duplicaterulecondition_createdonbehalfby")]
        public SystemUser lk_duplicaterulecondition_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_duplicaterulecondition_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_duplicaterulecondition_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_duplicaterulecondition_modifiedonbehalfby")]
        public SystemUser lk_duplicaterulecondition_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_duplicaterulecondition_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_duplicateruleconditionbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_duplicateruleconditionbase_createdby")]
        public SystemUser lk_duplicateruleconditionbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_duplicateruleconditionbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_duplicateruleconditionbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_duplicateruleconditionbase_modifiedby")]
        public SystemUser lk_duplicateruleconditionbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_duplicateruleconditionbase_modifiedby", null); }
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