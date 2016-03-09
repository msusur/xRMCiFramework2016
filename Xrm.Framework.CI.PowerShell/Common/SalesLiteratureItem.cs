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
    ///     Item in the sales literature collection.
    /// </summary>
    [DataContract]
    [EntityLogicalName("salesliteratureitem")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class SalesLiteratureItem : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "salesliteratureitem";

        public const int EntityTypeCode = 1070;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public SalesLiteratureItem() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Abstract of the document.
        /// </summary>
        [AttributeLogicalName("abstract")]
        public string Abstract
        {
            get { return GetAttributeValue<string>("abstract"); }
            set
            {
                OnPropertyChanging("Abstract");
                SetAttributeValue("abstract", value);
                OnPropertyChanged("Abstract");
            }
        }

        /// <summary>
        ///     URL of the Website on which the document is located.
        /// </summary>
        [AttributeLogicalName("attacheddocumenturl")]
        public string AttachedDocumentUrl
        {
            get { return GetAttributeValue<string>("attacheddocumenturl"); }
            set
            {
                OnPropertyChanging("AttachedDocumentUrl");
                SetAttributeValue("attacheddocumenturl", value);
                OnPropertyChanged("AttachedDocumentUrl");
            }
        }

        /// <summary>
        ///     Author name for the document.
        /// </summary>
        [AttributeLogicalName("authorname")]
        public string AuthorName
        {
            get { return GetAttributeValue<string>("authorname"); }
            set
            {
                OnPropertyChanging("AuthorName");
                SetAttributeValue("authorname", value);
                OnPropertyChanged("AuthorName");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who created the document.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the document was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the salesliteratureitem.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Shows the encoded contents of the sales literature document attachment.
        /// </summary>
        [AttributeLogicalName("documentbody")]
        public string DocumentBody
        {
            get { return GetAttributeValue<string>("documentbody"); }
            set
            {
                OnPropertyChanging("DocumentBody");
                SetAttributeValue("documentbody", value);
                OnPropertyChanged("DocumentBody");
            }
        }

        /// <summary>
        ///     File name of the document.
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
        ///     File size of the document.
        /// </summary>
        [AttributeLogicalName("filesize")]
        public int? FileSize
        {
            get { return GetAttributeValue<int?>("filesize"); }
        }

        /// <summary>
        ///     Select the file type of the document.
        /// </summary>
        [AttributeLogicalName("filetypecode")]
        public OptionSetValue FileTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("filetypecode"); }
            set
            {
                OnPropertyChanging("FileTypeCode");
                SetAttributeValue("filetypecode", value);
                OnPropertyChanged("FileTypeCode");
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
        ///     Tells whether the document can be shared with customers or is for internal use only.
        /// </summary>
        [AttributeLogicalName("iscustomerviewable")]
        public bool? IsCustomerViewable
        {
            get { return GetAttributeValue<bool?>("iscustomerviewable"); }
            set
            {
                OnPropertyChanging("IsCustomerViewable");
                SetAttributeValue("iscustomerviewable", value);
                OnPropertyChanged("IsCustomerViewable");
            }
        }

        /// <summary>
        ///     Keywords to use for searches in documents.
        /// </summary>
        [AttributeLogicalName("keywords")]
        public string KeyWords
        {
            get { return GetAttributeValue<string>("keywords"); }
            set
            {
                OnPropertyChanging("KeyWords");
                SetAttributeValue("keywords", value);
                OnPropertyChanged("KeyWords");
            }
        }

        /// <summary>
        ///     Shows the file type of the sales literature document attachment, such as text or document.
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
        ///     Unique identifier of the user who last modified the document.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the document was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the salesliteratureitem.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Unique identifier of the organization associated with the document.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public Guid? OrganizationId
        {
            get { return GetAttributeValue<Guid?>("organizationid"); }
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
        ///     Unique identifier of the sales literature that is associated with the individual item.
        /// </summary>
        [AttributeLogicalName("salesliteratureid")]
        public EntityReference SalesLiteratureId
        {
            get { return GetAttributeValue<EntityReference>("salesliteratureid"); }
            set
            {
                OnPropertyChanging("SalesLiteratureId");
                SetAttributeValue("salesliteratureid", value);
                OnPropertyChanged("SalesLiteratureId");
            }
        }

        /// <summary>
        ///     Unique identifier for the document.
        /// </summary>
        [AttributeLogicalName("salesliteratureitemid")]
        public Guid? SalesLiteratureItemId
        {
            get { return GetAttributeValue<Guid?>("salesliteratureitemid"); }
            set
            {
                OnPropertyChanging("SalesLiteratureItemId");
                SetAttributeValue("salesliteratureitemid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("SalesLiteratureItemId");
            }
        }

        [AttributeLogicalName("salesliteratureitemid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { SalesLiteratureItemId = value; }
        }

        /// <summary>
        ///     Type the title or name that describes the document.
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
        ///     Version number of the sales literature item.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N SalesLiteratureItem_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("SalesLiteratureItem_AsyncOperations")]
        public IEnumerable<AsyncOperation> SalesLiteratureItem_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("SalesLiteratureItem_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("SalesLiteratureItem_AsyncOperations");
                SetRelatedEntities("SalesLiteratureItem_AsyncOperations", null, value);
                OnPropertyChanged("SalesLiteratureItem_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N SalesLiteratureItem_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("SalesLiteratureItem_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> SalesLiteratureItem_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("SalesLiteratureItem_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("SalesLiteratureItem_BulkDeleteFailures");
                SetRelatedEntities("SalesLiteratureItem_BulkDeleteFailures", null, value);
                OnPropertyChanged("SalesLiteratureItem_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N SalesLiteratureItem_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("SalesLiteratureItem_ProcessSessions")]
        public IEnumerable<ProcessSession> SalesLiteratureItem_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("SalesLiteratureItem_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("SalesLiteratureItem_ProcessSessions");
                SetRelatedEntities("SalesLiteratureItem_ProcessSessions", null, value);
                OnPropertyChanged("SalesLiteratureItem_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_salesliteratureitem
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_salesliteratureitem")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_salesliteratureitem
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_salesliteratureitem", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_salesliteratureitem");
                SetRelatedEntities("userentityinstancedata_salesliteratureitem", null, value);
                OnPropertyChanged("userentityinstancedata_salesliteratureitem");
            }
        }

        /// <summary>
        ///     N:1 lk_salesliteratureitem_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_salesliteratureitem_createdonbehalfby")]
        public SystemUser lk_salesliteratureitem_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_salesliteratureitem_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_salesliteratureitem_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_salesliteratureitem_modifiedonbehalfby")]
        public SystemUser lk_salesliteratureitem_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_salesliteratureitem_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_salesliteratureitembase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_salesliteratureitembase_createdby")]
        public SystemUser lk_salesliteratureitembase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_salesliteratureitembase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_salesliteratureitembase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_salesliteratureitembase_modifiedby")]
        public SystemUser lk_salesliteratureitembase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_salesliteratureitembase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 sales_literature_items
        /// </summary>
        [AttributeLogicalName("salesliteratureid")]
        [RelationshipSchemaName("sales_literature_items")]
        public SalesLiterature sales_literature_items
        {
            get { return GetRelatedEntity<SalesLiterature>("sales_literature_items", null); }
            set
            {
                OnPropertyChanging("sales_literature_items");
                SetRelatedEntity("sales_literature_items", null, value);
                OnPropertyChanged("sales_literature_items");
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