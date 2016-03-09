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
    ///     Information regarding subjects available in the system.
    /// </summary>
    [DataContract]
    [EntityLogicalName("subject")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Subject : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "subject";

        public const int EntityTypeCode = 129;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Subject() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the user who created the subject.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the subject was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the subject.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Description of the subject.
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
        ///     Information that specifies when the subject will be displayed in lists of subjects.
        /// </summary>
        [AttributeLogicalName("featuremask")]
        public int? FeatureMask
        {
            get { return GetAttributeValue<int?>("featuremask"); }
            set
            {
                OnPropertyChanging("FeatureMask");
                SetAttributeValue("featuremask", value);
                OnPropertyChanged("FeatureMask");
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
        ///     Unique identifier of the user who last modified the subject.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the subject was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the subject.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier for the organization associated with the subject.
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
        ///     Unique identifier of the parent subject.
        /// </summary>
        [AttributeLogicalName("parentsubject")]
        public EntityReference ParentSubject
        {
            get { return GetAttributeValue<EntityReference>("parentsubject"); }
            set
            {
                OnPropertyChanging("ParentSubject");
                SetAttributeValue("parentsubject", value);
                OnPropertyChanged("ParentSubject");
            }
        }

        /// <summary>
        ///     Unique identifier of the subject.
        /// </summary>
        [AttributeLogicalName("subjectid")]
        public Guid? SubjectId
        {
            get { return GetAttributeValue<Guid?>("subjectid"); }
            set
            {
                OnPropertyChanging("SubjectId");
                SetAttributeValue("subjectid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("SubjectId");
            }
        }

        [AttributeLogicalName("subjectid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { SubjectId = value; }
        }

        /// <summary>
        ///     Title of the subject.
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
        ///     Version number of the subject.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N Subject_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Subject_AsyncOperations")]
        public IEnumerable<AsyncOperation> Subject_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Subject_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Subject_AsyncOperations");
                SetRelatedEntities("Subject_AsyncOperations", null, value);
                OnPropertyChanged("Subject_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N Subject_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("Subject_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> Subject_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("Subject_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("Subject_BulkDeleteFailures");
                SetRelatedEntities("Subject_BulkDeleteFailures", null, value);
                OnPropertyChanged("Subject_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N subject_incidents
        /// </summary>
        [RelationshipSchemaName("subject_incidents")]
        public IEnumerable<Incident> subject_incidents
        {
            get { return GetRelatedEntities<Incident>("subject_incidents", null); }
            set
            {
                OnPropertyChanging("subject_incidents");
                SetRelatedEntities("subject_incidents", null, value);
                OnPropertyChanged("subject_incidents");
            }
        }

        /// <summary>
        ///     1:N subject_kb_articles
        /// </summary>
        [RelationshipSchemaName("subject_kb_articles")]
        public IEnumerable<KbArticle> subject_kb_articles
        {
            get { return GetRelatedEntities<KbArticle>("subject_kb_articles", null); }
            set
            {
                OnPropertyChanging("subject_kb_articles");
                SetRelatedEntities("subject_kb_articles", null, value);
                OnPropertyChanged("subject_kb_articles");
            }
        }

        /// <summary>
        ///     1:N subject_parent_subject
        /// </summary>
        [RelationshipSchemaName("subject_parent_subject", EntityRole.Referenced)]
        public IEnumerable<Subject> Referencedsubject_parent_subject
        {
            get { return GetRelatedEntities<Subject>("subject_parent_subject", EntityRole.Referenced); }
            set
            {
                OnPropertyChanging("Referencedsubject_parent_subject");
                SetRelatedEntities("subject_parent_subject", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedsubject_parent_subject");
            }
        }

        /// <summary>
        ///     1:N Subject_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("Subject_ProcessSessions")]
        public IEnumerable<ProcessSession> Subject_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("Subject_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Subject_ProcessSessions");
                SetRelatedEntities("Subject_ProcessSessions", null, value);
                OnPropertyChanged("Subject_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N subject_products
        /// </summary>
        [RelationshipSchemaName("subject_products")]
        public IEnumerable<Product> subject_products
        {
            get { return GetRelatedEntities<Product>("subject_products", null); }
            set
            {
                OnPropertyChanging("subject_products");
                SetRelatedEntities("subject_products", null, value);
                OnPropertyChanged("subject_products");
            }
        }

        /// <summary>
        ///     1:N subject_sales_literature
        /// </summary>
        [RelationshipSchemaName("subject_sales_literature")]
        public IEnumerable<SalesLiterature> subject_sales_literature
        {
            get { return GetRelatedEntities<SalesLiterature>("subject_sales_literature", null); }
            set
            {
                OnPropertyChanging("subject_sales_literature");
                SetRelatedEntities("subject_sales_literature", null, value);
                OnPropertyChanged("subject_sales_literature");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_subject
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_subject")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_subject
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_subject", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_subject");
                SetRelatedEntities("userentityinstancedata_subject", null, value);
                OnPropertyChanged("userentityinstancedata_subject");
            }
        }

        /// <summary>
        ///     N:1 lk_subject_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_subject_createdonbehalfby")]
        public SystemUser lk_subject_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_subject_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_subject_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_subject_modifiedonbehalfby")]
        public SystemUser lk_subject_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_subject_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_subjectbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_subjectbase_createdby")]
        public SystemUser lk_subjectbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_subjectbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_subjectbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_subjectbase_modifiedby")]
        public SystemUser lk_subjectbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_subjectbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 organization_subjects
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_subjects")]
        public Organization organization_subjects
        {
            get { return GetRelatedEntity<Organization>("organization_subjects", null); }
        }

        /// <summary>
        ///     N:1 subject_parent_subject
        /// </summary>
        [AttributeLogicalName("parentsubject")]
        [RelationshipSchemaName("subject_parent_subject", EntityRole.Referencing)]
        public Subject Referencingsubject_parent_subject
        {
            get { return GetRelatedEntity<Subject>("subject_parent_subject", EntityRole.Referencing); }
            set
            {
                OnPropertyChanging("Referencingsubject_parent_subject");
                SetRelatedEntity("subject_parent_subject", EntityRole.Referencing, value);
                OnPropertyChanged("Referencingsubject_parent_subject");
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