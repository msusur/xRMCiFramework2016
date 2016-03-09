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
    ///     Template for an email message that contains the standard attributes of an email message.
    /// </summary>
    [DataContract]
    [EntityLogicalName("template")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Template : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "template";

        public const int EntityTypeCode = 2010;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Template() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Body text of the email template.
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
        ///     Unique identifier of the user who created the email template.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the email template was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the template.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Description of the email template.
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
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("generationtypecode")]
        public int? GenerationTypeCode
        {
            get { return GetAttributeValue<int?>("generationtypecode"); }
            set
            {
                OnPropertyChanging("GenerationTypeCode");
                SetAttributeValue("generationtypecode", value);
                OnPropertyChanged("GenerationTypeCode");
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
        ///     Information about whether the template is personal or is available to all users.
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
        ///     Language of the email template.
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
        ///     MIME type of the email template.
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
        ///     Unique identifier of the user who last modified the template.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the email template was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the template.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
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
        ///     Unique identifier of the user or team who owns the template for the email activity.
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
        ///     Unique identifier of the business unit that owns the template.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the template.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the template.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     XML data for the body of the email template.
        /// </summary>
        [AttributeLogicalName("presentationxml")]
        public string PresentationXml
        {
            get { return GetAttributeValue<string>("presentationxml"); }
            set
            {
                OnPropertyChanging("PresentationXml");
                SetAttributeValue("presentationxml", value);
                OnPropertyChanged("PresentationXml");
            }
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
        ///     Subject associated with the email template.
        /// </summary>
        [AttributeLogicalName("subject")]
        public string Subject
        {
            get { return GetAttributeValue<string>("subject"); }
            set
            {
                OnPropertyChanging("Subject");
                SetAttributeValue("subject", value);
                OnPropertyChanged("Subject");
            }
        }

        /// <summary>
        ///     XML data for the subject of the email template.
        /// </summary>
        [AttributeLogicalName("subjectpresentationxml")]
        public string SubjectPresentationXml
        {
            get { return GetAttributeValue<string>("subjectpresentationxml"); }
            set
            {
                OnPropertyChanging("SubjectPresentationXml");
                SetAttributeValue("subjectpresentationxml", value);
                OnPropertyChanged("SubjectPresentationXml");
            }
        }

        /// <summary>
        ///     Unique identifier of the template.
        /// </summary>
        [AttributeLogicalName("templateid")]
        public Guid? TemplateId
        {
            get { return GetAttributeValue<Guid?>("templateid"); }
            set
            {
                OnPropertyChanging("TemplateId");
                SetAttributeValue("templateid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("TemplateId");
            }
        }

        [AttributeLogicalName("templateid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { TemplateId = value; }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("templateidunique")]
        public Guid? TemplateIdUnique
        {
            get { return GetAttributeValue<Guid?>("templateidunique"); }
        }

        /// <summary>
        ///     Type of email template.
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
        ///     Title of the template.
        /// </summary>
        [AttributeLogicalName("title")]
        public string Title
        {
            get { return GetAttributeValue<string>("title"); }
            set
            {
                OnPropertyChanging("Title");
                SetAttributeValue("title", value);
                OnPropertyChanged("Title");
            }
        }

        /// <summary>
        ///     Version number of the template.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N template_activity_mime_attachments
        /// </summary>
        [RelationshipSchemaName("template_activity_mime_attachments")]
        public IEnumerable<ActivityMimeAttachment> template_activity_mime_attachments
        {
            get { return GetRelatedEntities<ActivityMimeAttachment>("template_activity_mime_attachments", null); }
            set
            {
                OnPropertyChanging("template_activity_mime_attachments");
                SetRelatedEntities("template_activity_mime_attachments", null, value);
                OnPropertyChanged("template_activity_mime_attachments");
            }
        }

        /// <summary>
        ///     1:N Template_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Template_AsyncOperations")]
        public IEnumerable<AsyncOperation> Template_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Template_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Template_AsyncOperations");
                SetRelatedEntities("Template_AsyncOperations", null, value);
                OnPropertyChanged("Template_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N Template_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("Template_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> Template_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("Template_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("Template_BulkDeleteFailures");
                SetRelatedEntities("Template_BulkDeleteFailures", null, value);
                OnPropertyChanged("Template_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N Template_Organization
        /// </summary>
        [RelationshipSchemaName("Template_Organization")]
        public IEnumerable<Organization> Template_Organization
        {
            get { return GetRelatedEntities<Organization>("Template_Organization", null); }
            set
            {
                OnPropertyChanging("Template_Organization");
                SetRelatedEntities("Template_Organization", null, value);
                OnPropertyChanged("Template_Organization");
            }
        }

        /// <summary>
        ///     1:N Template_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("Template_ProcessSessions")]
        public IEnumerable<ProcessSession> Template_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("Template_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Template_ProcessSessions");
                SetRelatedEntities("Template_ProcessSessions", null, value);
                OnPropertyChanged("Template_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_template
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_template")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_template
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_template", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_template");
                SetRelatedEntities("userentityinstancedata_template", null, value);
                OnPropertyChanged("userentityinstancedata_template");
            }
        }

        /// <summary>
        ///     N:1 business_unit_templates
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_templates")]
        public BusinessUnit business_unit_templates
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_templates", null); }
        }

        /// <summary>
        ///     N:1 lk_templatebase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_templatebase_createdby")]
        public SystemUser lk_templatebase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_templatebase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_templatebase_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_templatebase_createdonbehalfby")]
        public SystemUser lk_templatebase_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_templatebase_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_templatebase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_templatebase_modifiedby")]
        public SystemUser lk_templatebase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_templatebase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_templatebase_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_templatebase_modifiedonbehalfby")]
        public SystemUser lk_templatebase_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_templatebase_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 system_user_email_templates
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("system_user_email_templates")]
        public SystemUser system_user_email_templates
        {
            get { return GetRelatedEntity<SystemUser>("system_user_email_templates", null); }
        }

        /// <summary>
        ///     N:1 team_email_templates
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_email_templates")]
        public Team team_email_templates
        {
            get { return GetRelatedEntity<Team>("team_email_templates", null); }
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