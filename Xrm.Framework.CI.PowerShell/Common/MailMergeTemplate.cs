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
    ///     Template for a mail merge document that contains the standard attributes of that document.
    /// </summary>
    [DataContract]
    [EntityLogicalName("mailmergetemplate")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class MailMergeTemplate : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "mailmergetemplate";

        public const int EntityTypeCode = 9106;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public MailMergeTemplate() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Body text of the mail merge template.
        /// </summary>
        [AttributeLogicalName("body")]
        public string Body
        {
            get { return GetAttributeValue<string>("body"); }
            set
            {
                OnPropertyChanging("Body");
                SetAttributeValue("body", value);
                OnPropertyChanged("Body");
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
        ///     Unique identifier of the user who created the mail merge template.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the mail merge template was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the mailmergetemplate.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Default data fields associated with the mail merge template.
        /// </summary>
        [AttributeLogicalName("defaultfilter")]
        public string DefaultFilter
        {
            get { return GetAttributeValue<string>("defaultfilter"); }
            set
            {
                OnPropertyChanging("DefaultFilter");
                SetAttributeValue("defaultfilter", value);
                OnPropertyChanged("DefaultFilter");
            }
        }

        /// <summary>
        ///     Description of the mail merge template.
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
        ///     Version of the Microsoft Office Word XML format used by the template.
        /// </summary>
        [AttributeLogicalName("documentformat")]
        public OptionSetValue DocumentFormat
        {
            get { return GetAttributeValue<OptionSetValue>("documentformat"); }
            set
            {
                OnPropertyChanging("DocumentFormat");
                SetAttributeValue("documentformat", value);
                OnPropertyChanged("DocumentFormat");
            }
        }

        /// <summary>
        ///     Exchange rate for the currency associated with the mailmergetemplate with respect to the base currency.
        /// </summary>
        [AttributeLogicalName("exchangerate")]
        public decimal? ExchangeRate
        {
            get { return GetAttributeValue<decimal?>("exchangerate"); }
        }

        /// <summary>
        ///     File name of the mail merge template.
        /// </summary>
        [AttributeLogicalName("filename")]
        public string FileName
        {
            get { return GetAttributeValue<string>("filename"); }
            set
            {
                OnPropertyChanging("FileName");
                SetAttributeValue("filename", value);
                OnPropertyChanged("FileName");
            }
        }

        /// <summary>
        ///     File size of the mail merge template.
        /// </summary>
        [AttributeLogicalName("filesize")]
        public int? FileSize
        {
            get { return GetAttributeValue<int?>("filesize"); }
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
        ///     Information about whether the mail merge template is personal or is available to all users.
        /// </summary>
        [AttributeLogicalName("ispersonal")]
        public bool? IsPersonal
        {
            get { return GetAttributeValue<bool?>("ispersonal"); }
            set
            {
                OnPropertyChanging("IsPersonal");
                SetAttributeValue("ispersonal", value);
                OnPropertyChanged("IsPersonal");
            }
        }

        /// <summary>
        ///     Language of the mail merge template.
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
        ///     Unique identifier of the mail merge template.
        /// </summary>
        [AttributeLogicalName("mailmergetemplateid")]
        public Guid? MailMergeTemplateId
        {
            get { return GetAttributeValue<Guid?>("mailmergetemplateid"); }
            set
            {
                OnPropertyChanging("MailMergeTemplateId");
                SetAttributeValue("mailmergetemplateid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("MailMergeTemplateId");
            }
        }

        [AttributeLogicalName("mailmergetemplateid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { MailMergeTemplateId = value; }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("mailmergetemplateidunique")]
        public Guid? MailMergeTemplateIdUnique
        {
            get { return GetAttributeValue<Guid?>("mailmergetemplateidunique"); }
        }

        /// <summary>
        ///     Drop-down list for selecting the type of the mail merge.
        /// </summary>
        [AttributeLogicalName("mailmergetype")]
        public OptionSetValue MailMergeType
        {
            get { return GetAttributeValue<OptionSetValue>("mailmergetype"); }
            set
            {
                OnPropertyChanging("MailMergeType");
                SetAttributeValue("mailmergetype", value);
                OnPropertyChanged("MailMergeType");
            }
        }

        /// <summary>
        ///     MIME type of the mail merge template.
        /// </summary>
        [AttributeLogicalName("mimetype")]
        public string MimeType
        {
            get { return GetAttributeValue<string>("mimetype"); }
            set
            {
                OnPropertyChanging("MimeType");
                SetAttributeValue("mimetype", value);
                OnPropertyChanged("MimeType");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the mail merge template.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the mail merge template was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the mailmergetemplate.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the mail merge template.
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
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("overwritetime")]
        public DateTime? OverwriteTime
        {
            get { return GetAttributeValue<DateTime?>("overwritetime"); }
        }

        /// <summary>
        ///     Unique identifier of the user or team who owns the mail merge template.
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
        ///     Unique identifier of the business unit that owns the mail merge template.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the mail merge template.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the mail merge template.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Parameter Xml.
        /// </summary>
        [AttributeLogicalName("parameterxml")]
        public string ParameterXml
        {
            get { return GetAttributeValue<string>("parameterxml"); }
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
        ///     Status of the mail merge template.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public MailMergeTemplateState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((MailMergeTemplateState) (Enum.ToObject(typeof (MailMergeTemplateState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the mail merge template.
        /// </summary>
        [AttributeLogicalName("statuscode")]
        public OptionSetValue StatusCode
        {
            get { return GetAttributeValue<OptionSetValue>("statuscode"); }
            set
            {
                OnPropertyChanging("StatusCode");
                SetAttributeValue("statuscode", value);
                OnPropertyChanged("StatusCode");
            }
        }

        /// <summary>
        ///     Type of mail merge template.
        /// </summary>
        [AttributeLogicalName("templatetypecode")]
        public string TemplateTypeCode
        {
            get { return GetAttributeValue<string>("templatetypecode"); }
            set
            {
                OnPropertyChanging("TemplateTypeCode");
                SetAttributeValue("templatetypecode", value);
                OnPropertyChanged("TemplateTypeCode");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("timezoneruleversionnumber")]
        public int? TimeZoneRuleVersionNumber
        {
            get { return GetAttributeValue<int?>("timezoneruleversionnumber"); }
            set
            {
                OnPropertyChanging("TimeZoneRuleVersionNumber");
                SetAttributeValue("timezoneruleversionnumber", value);
                OnPropertyChanged("TimeZoneRuleVersionNumber");
            }
        }

        /// <summary>
        ///     Unique identifier of the currency associated with the mailmergetemplate.
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        public EntityReference TransactionCurrencyId
        {
            get { return GetAttributeValue<EntityReference>("transactioncurrencyid"); }
            set
            {
                OnPropertyChanging("TransactionCurrencyId");
                SetAttributeValue("transactioncurrencyid", value);
                OnPropertyChanged("TransactionCurrencyId");
            }
        }

        /// <summary>
        ///     Time zone code that was in use when the record was created.
        /// </summary>
        [AttributeLogicalName("utcconversiontimezonecode")]
        public int? UTCConversionTimeZoneCode
        {
            get { return GetAttributeValue<int?>("utcconversiontimezonecode"); }
            set
            {
                OnPropertyChanging("UTCConversionTimeZoneCode");
                SetAttributeValue("utcconversiontimezonecode", value);
                OnPropertyChanged("UTCConversionTimeZoneCode");
            }
        }

        /// <summary>
        ///     Version number of the mail merge template.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N MailMergeTemplate_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("MailMergeTemplate_AsyncOperations")]
        public IEnumerable<AsyncOperation> MailMergeTemplate_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("MailMergeTemplate_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("MailMergeTemplate_AsyncOperations");
                SetRelatedEntities("MailMergeTemplate_AsyncOperations", null, value);
                OnPropertyChanged("MailMergeTemplate_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N mailmergetemplate_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("mailmergetemplate_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> mailmergetemplate_principalobjectattributeaccess
        {
            get
            {
                return
                    GetRelatedEntities<PrincipalObjectAttributeAccess>(
                        "mailmergetemplate_principalobjectattributeaccess", null);
            }
            set
            {
                OnPropertyChanging("mailmergetemplate_principalobjectattributeaccess");
                SetRelatedEntities("mailmergetemplate_principalobjectattributeaccess", null, value);
                OnPropertyChanged("mailmergetemplate_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N MailMergeTemplate_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("MailMergeTemplate_ProcessSessions")]
        public IEnumerable<ProcessSession> MailMergeTemplate_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("MailMergeTemplate_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("MailMergeTemplate_ProcessSessions");
                SetRelatedEntities("MailMergeTemplate_ProcessSessions", null, value);
                OnPropertyChanged("MailMergeTemplate_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_mailmergetemplate
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_mailmergetemplate")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_mailmergetemplate
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_mailmergetemplate", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_mailmergetemplate");
                SetRelatedEntities("userentityinstancedata_mailmergetemplate", null, value);
                OnPropertyChanged("userentityinstancedata_mailmergetemplate");
            }
        }

        /// <summary>
        ///     N:1 business_unit_mailmergetemplates
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_mailmergetemplates")]
        public BusinessUnit business_unit_mailmergetemplates
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_mailmergetemplates", null); }
        }

        /// <summary>
        ///     N:1 lk_mailmergetemplate_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_mailmergetemplate_createdonbehalfby")]
        public SystemUser lk_mailmergetemplate_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_mailmergetemplate_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_mailmergetemplate_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_mailmergetemplate_modifiedonbehalfby")]
        public SystemUser lk_mailmergetemplate_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_mailmergetemplate_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_mailmergetemplatebase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_mailmergetemplatebase_createdby")]
        public SystemUser lk_mailmergetemplatebase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_mailmergetemplatebase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_mailmergetemplatebase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_mailmergetemplatebase_modifiedby")]
        public SystemUser lk_mailmergetemplatebase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_mailmergetemplatebase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 TransactionCurrency_MailMergeTemplate
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("TransactionCurrency_MailMergeTemplate")]
        public TransactionCurrency TransactionCurrency_MailMergeTemplate
        {
            get { return GetRelatedEntity<TransactionCurrency>("TransactionCurrency_MailMergeTemplate", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_MailMergeTemplate");
                SetRelatedEntity("TransactionCurrency_MailMergeTemplate", null, value);
                OnPropertyChanged("TransactionCurrency_MailMergeTemplate");
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