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
    ///     Template for a contract containing the standard attributes of a contract.
    /// </summary>
    [DataContract]
    [EntityLogicalName("contracttemplate")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ContractTemplate : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "contracttemplate";

        public const int EntityTypeCode = 2011;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ContractTemplate() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Abbreviation of the contract template name.
        /// </summary>
        [AttributeLogicalName("abbreviation")]
        public string Abbreviation
        {
            get { return GetAttributeValue<string>("abbreviation"); }
            set
            {
                OnPropertyChanging("Abbreviation");
                SetAttributeValue("abbreviation", value);
                OnPropertyChanged("Abbreviation");
            }
        }

        /// <summary>
        ///     Criteria for the contracts based on the template, such as number of cases, time, or coverage dates.
        /// </summary>
        [AttributeLogicalName("allotmenttypecode")]
        public OptionSetValue AllotmentTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("allotmenttypecode"); }
            set
            {
                OnPropertyChanging("AllotmentTypeCode");
                SetAttributeValue("allotmenttypecode", value);
                OnPropertyChanged("AllotmentTypeCode");
            }
        }

        /// <summary>
        ///     How often the customer or account is to be billed in contracts that are based on the template.
        /// </summary>
        [AttributeLogicalName("billingfrequencycode")]
        public OptionSetValue BillingFrequencyCode
        {
            get { return GetAttributeValue<OptionSetValue>("billingfrequencycode"); }
            set
            {
                OnPropertyChanging("BillingFrequencyCode");
                SetAttributeValue("billingfrequencycode", value);
                OnPropertyChanged("BillingFrequencyCode");
            }
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
        ///     Unique identifier of the level of service specified in contracts that are based on the template.
        /// </summary>
        [AttributeLogicalName("contractservicelevelcode")]
        public OptionSetValue ContractServiceLevelCode
        {
            get { return GetAttributeValue<OptionSetValue>("contractservicelevelcode"); }
            set
            {
                OnPropertyChanging("ContractServiceLevelCode");
                SetAttributeValue("contractservicelevelcode", value);
                OnPropertyChanged("ContractServiceLevelCode");
            }
        }

        /// <summary>
        ///     Unique identifier of the contract template.
        /// </summary>
        [AttributeLogicalName("contracttemplateid")]
        public Guid? ContractTemplateId
        {
            get { return GetAttributeValue<Guid?>("contracttemplateid"); }
            set
            {
                OnPropertyChanging("ContractTemplateId");
                SetAttributeValue("contracttemplateid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ContractTemplateId");
            }
        }

        [AttributeLogicalName("contracttemplateid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ContractTemplateId = value; }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("contracttemplateidunique")]
        public Guid? ContractTemplateIdUnique
        {
            get { return GetAttributeValue<Guid?>("contracttemplateidunique"); }
        }

        /// <summary>
        ///     Unique identifier of the user who created the contract template.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the contract template was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the contracttemplate.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Description of the contract template.
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
        ///     Days of the week and times for which contracts based on the template are effective.
        /// </summary>
        [AttributeLogicalName("effectivitycalendar")]
        public string EffectivityCalendar
        {
            get { return GetAttributeValue<string>("effectivitycalendar"); }
            set
            {
                OnPropertyChanging("EffectivityCalendar");
                SetAttributeValue("effectivitycalendar", value);
                OnPropertyChanged("EffectivityCalendar");
            }
        }

        /// <summary>
        ///     Unique identifier of the data import or data migration that created this record.
        /// </summary>
        [AttributeLogicalName("importsequencenumber")]
        public int? ImportSequenceNumber
        {
            get { return GetAttributeValue<int?>("importsequencenumber"); }
            set
            {
                OnPropertyChanging("ImportSequenceNumber");
                SetAttributeValue("importsequencenumber", value);
                OnPropertyChanged("ImportSequenceNumber");
            }
        }

        /// <summary>
        ///     Version in which the form is introduced.
        /// </summary>
        [AttributeLogicalName("introducedversion")]
        public string IntroducedVersion
        {
            get { return GetAttributeValue<string>("introducedversion"); }
            set
            {
                OnPropertyChanging("IntroducedVersion");
                SetAttributeValue("introducedversion", value);
                OnPropertyChanged("IntroducedVersion");
            }
        }

        /// <summary>
        ///     Information that specifies whether this component can be customized.
        /// </summary>
        [AttributeLogicalName("iscustomizable")]
        public BooleanManagedProperty IsCustomizable
        {
            get { return GetAttributeValue<BooleanManagedProperty>("iscustomizable"); }
            set
            {
                OnPropertyChanging("IsCustomizable");
                SetAttributeValue("iscustomizable", value);
                OnPropertyChanged("IsCustomizable");
            }
        }

        /// <summary>
        ///     Indicates whether the solution component is part of a managed solution.
        /// </summary>
        [AttributeLogicalName("ismanaged")]
        public bool? IsManaged
        {
            get { return GetAttributeValue<bool?>("ismanaged"); }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the contract template.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the contract template was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the contracttemplate.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the contract template.
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
        ///     Unique identifier of the organization associated with the contract template.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     Date and time that the record was migrated.
        /// </summary>
        [AttributeLogicalName("overriddencreatedon")]
        public DateTime? OverriddenCreatedOn
        {
            get { return GetAttributeValue<DateTime?>("overriddencreatedon"); }
            set
            {
                OnPropertyChanging("OverriddenCreatedOn");
                SetAttributeValue("overriddencreatedon", value);
                OnPropertyChanged("OverriddenCreatedOn");
            }
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
        ///     Unique identifier of the associated solution.
        /// </summary>
        [AttributeLogicalName("solutionid")]
        public Guid? SolutionId
        {
            get { return GetAttributeValue<Guid?>("solutionid"); }
        }

        /// <summary>
        ///     Specifies whether the discount is a percentage or a monetary amount in contracts based on the template.
        /// </summary>
        [AttributeLogicalName("usediscountaspercentage")]
        public bool? UseDiscountAsPercentage
        {
            get { return GetAttributeValue<bool?>("usediscountaspercentage"); }
            set
            {
                OnPropertyChanging("UseDiscountAsPercentage");
                SetAttributeValue("usediscountaspercentage", value);
                OnPropertyChanged("UseDiscountAsPercentage");
            }
        }

        /// <summary>
        ///     Version number of the contract template.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N contract_template_contracts
        /// </summary>
        [RelationshipSchemaName("contract_template_contracts")]
        public IEnumerable<Contract> contract_template_contracts
        {
            get { return GetRelatedEntities<Contract>("contract_template_contracts", null); }
            set
            {
                OnPropertyChanging("contract_template_contracts");
                SetRelatedEntities("contract_template_contracts", null, value);
                OnPropertyChanged("contract_template_contracts");
            }
        }

        /// <summary>
        ///     1:N ContractTemplate_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("ContractTemplate_AsyncOperations")]
        public IEnumerable<AsyncOperation> ContractTemplate_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("ContractTemplate_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("ContractTemplate_AsyncOperations");
                SetRelatedEntities("ContractTemplate_AsyncOperations", null, value);
                OnPropertyChanged("ContractTemplate_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N ContractTemplate_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("ContractTemplate_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> ContractTemplate_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("ContractTemplate_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("ContractTemplate_BulkDeleteFailures");
                SetRelatedEntities("ContractTemplate_BulkDeleteFailures", null, value);
                OnPropertyChanged("ContractTemplate_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N ContractTemplate_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("ContractTemplate_ProcessSessions")]
        public IEnumerable<ProcessSession> ContractTemplate_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("ContractTemplate_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("ContractTemplate_ProcessSessions");
                SetRelatedEntities("ContractTemplate_ProcessSessions", null, value);
                OnPropertyChanged("ContractTemplate_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_contracttemplate
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_contracttemplate")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_contracttemplate
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_contracttemplate", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_contracttemplate");
                SetRelatedEntities("userentityinstancedata_contracttemplate", null, value);
                OnPropertyChanged("userentityinstancedata_contracttemplate");
            }
        }

        /// <summary>
        ///     N:1 lk_contracttemplate_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_contracttemplate_createdonbehalfby")]
        public SystemUser lk_contracttemplate_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_contracttemplate_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_contracttemplate_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_contracttemplate_modifiedonbehalfby")]
        public SystemUser lk_contracttemplate_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_contracttemplate_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_contracttemplatebase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_contracttemplatebase_createdby")]
        public SystemUser lk_contracttemplatebase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_contracttemplatebase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_contracttemplatebase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_contracttemplatebase_modifiedby")]
        public SystemUser lk_contracttemplatebase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_contracttemplatebase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 organization_contract_templates
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_contract_templates")]
        public Organization organization_contract_templates
        {
            get { return GetRelatedEntity<Organization>("organization_contract_templates", null); }
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