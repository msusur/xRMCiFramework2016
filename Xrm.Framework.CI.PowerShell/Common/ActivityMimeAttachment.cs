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
    ///     MIME attachment for an email activity.
    /// </summary>
    [DataContract]
    [EntityLogicalName("activitymimeattachment")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ActivityMimeAttachment : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "activitymimeattachment";

        public const int EntityTypeCode = 1001;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ActivityMimeAttachment() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the activity with which the email attachment is associated.
        /// </summary>
        [AttributeLogicalName("activityid")]
        [Obsolete]
        public EntityReference ActivityId
        {
            get { return GetAttributeValue<EntityReference>("activityid"); }
            set
            {
                OnPropertyChanging("ActivityId");
                SetAttributeValue("activityid", value);
                OnPropertyChanged("ActivityId");
            }
        }

        /// <summary>
        ///     Unique identifier of the email attachment.
        /// </summary>
        [AttributeLogicalName("activitymimeattachmentid")]
        public Guid? ActivityMimeAttachmentId
        {
            get { return GetAttributeValue<Guid?>("activitymimeattachmentid"); }
            set
            {
                OnPropertyChanging("ActivityMimeAttachmentId");
                SetAttributeValue("activitymimeattachmentid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ActivityMimeAttachmentId");
            }
        }

        [AttributeLogicalName("activitymimeattachmentid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ActivityMimeAttachmentId = value; }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("activitymimeattachmentidunique")]
        public Guid? ActivityMimeAttachmentIdUnique
        {
            get { return GetAttributeValue<Guid?>("activitymimeattachmentidunique"); }
            set
            {
                OnPropertyChanging("ActivityMimeAttachmentIdUnique");
                SetAttributeValue("activitymimeattachmentidunique", value);
                OnPropertyChanged("ActivityMimeAttachmentIdUnique");
            }
        }

        /// <summary>
        ///     Unique identifier of the attachment with which this activitymimeattachment is associated.
        /// </summary>
        [AttributeLogicalName("attachmentid")]
        public EntityReference AttachmentId
        {
            get { return GetAttributeValue<EntityReference>("attachmentid"); }
            set
            {
                OnPropertyChanging("AttachmentId");
                SetAttributeValue("attachmentid", value);
                OnPropertyChanged("AttachmentId");
            }
        }

        /// <summary>
        ///     Number of the email attachment.
        /// </summary>
        [AttributeLogicalName("attachmentnumber")]
        public int? AttachmentNumber
        {
            get { return GetAttributeValue<int?>("attachmentnumber"); }
            set
            {
                OnPropertyChanging("AttachmentNumber");
                SetAttributeValue("attachmentnumber", value);
                OnPropertyChanged("AttachmentNumber");
            }
        }

        /// <summary>
        ///     Contents of the email attachment.
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
        ///     File name of the attachment.
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
        ///     File size of the email attachment.
        /// </summary>
        [AttributeLogicalName("filesize")]
        public int? FileSize
        {
            get { return GetAttributeValue<int?>("filesize"); }
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
        ///     MIME type of the email attachment.
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
        ///     Unique identifier of the record with which the attachment is associated
        /// </summary>
        [AttributeLogicalName("objectid")]
        public EntityReference ObjectId
        {
            get { return GetAttributeValue<EntityReference>("objectid"); }
            set
            {
                OnPropertyChanging("ObjectId");
                SetAttributeValue("objectid", value);
                OnPropertyChanged("ObjectId");
            }
        }

        /// <summary>
        ///     Object Type Code of the entity that is associated with the attachment.
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
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("overwritetime")]
        public DateTime? OverwriteTime
        {
            get { return GetAttributeValue<DateTime?>("overwritetime"); }
        }

        /// <summary>
        ///     Unique identifier of the user or team who owns the activity_mime_attachment.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId
        {
            get { return GetAttributeValue<EntityReference>("ownerid"); }
        }

        /// <summary>
        ///     Unique identifier of the business unit that owns the activity mime attachment.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the activity mime attachment.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
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
        ///     Descriptive subject for the email attachment.
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
        ///     Version number of the activity mime attachment.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N ActivityMimeAttachment_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("ActivityMimeAttachment_AsyncOperations")]
        public IEnumerable<AsyncOperation> ActivityMimeAttachment_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("ActivityMimeAttachment_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("ActivityMimeAttachment_AsyncOperations");
                SetRelatedEntities("ActivityMimeAttachment_AsyncOperations", null, value);
                OnPropertyChanged("ActivityMimeAttachment_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N ActivityMimeAttachment_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("ActivityMimeAttachment_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> ActivityMimeAttachment_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("ActivityMimeAttachment_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("ActivityMimeAttachment_BulkDeleteFailures");
                SetRelatedEntities("ActivityMimeAttachment_BulkDeleteFailures", null, value);
                OnPropertyChanged("ActivityMimeAttachment_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_activitymimeattachment
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_activitymimeattachment")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_activitymimeattachment
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_activitymimeattachment", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_activitymimeattachment");
                SetRelatedEntities("userentityinstancedata_activitymimeattachment", null, value);
                OnPropertyChanged("userentityinstancedata_activitymimeattachment");
            }
        }

        /// <summary>
        ///     N:1 activity_pointer_activity_mime_attachment
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("activity_pointer_activity_mime_attachment")]
        public ActivityPointer activity_pointer_activity_mime_attachment
        {
            get { return GetRelatedEntity<ActivityPointer>("activity_pointer_activity_mime_attachment", null); }
            set
            {
                OnPropertyChanging("activity_pointer_activity_mime_attachment");
                SetRelatedEntity("activity_pointer_activity_mime_attachment", null, value);
                OnPropertyChanged("activity_pointer_activity_mime_attachment");
            }
        }

        /// <summary>
        ///     N:1 email_activity_mime_attachment
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("email_activity_mime_attachment")]
        public Email email_activity_mime_attachment
        {
            get { return GetRelatedEntity<Email>("email_activity_mime_attachment", null); }
            set
            {
                OnPropertyChanging("email_activity_mime_attachment");
                SetRelatedEntity("email_activity_mime_attachment", null, value);
                OnPropertyChanged("email_activity_mime_attachment");
            }
        }

        /// <summary>
        ///     N:1 template_activity_mime_attachments
        /// </summary>
        [AttributeLogicalName("objectid")]
        [RelationshipSchemaName("template_activity_mime_attachments")]
        public Template template_activity_mime_attachments
        {
            get { return GetRelatedEntity<Template>("template_activity_mime_attachments", null); }
            set
            {
                OnPropertyChanging("template_activity_mime_attachments");
                SetRelatedEntity("template_activity_mime_attachments", null, value);
                OnPropertyChanged("template_activity_mime_attachments");
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