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
    ///     Log used to track bulk operation execution, successes, and failures.
    /// </summary>
    [DataContract]
    [EntityLogicalName("bulkoperationlog")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class BulkOperationLog : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "bulkoperationlog";

        public const int EntityTypeCode = 4405;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public BulkOperationLog() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Shows the data value at which an error occurred during the quick campaign.
        /// </summary>
        [AttributeLogicalName("additionalinfo")]
        public string AdditionalInfo
        {
            get { return GetAttributeValue<string>("additionalinfo"); }
            set
            {
                OnPropertyChanging("AdditionalInfo");
                SetAttributeValue("additionalinfo", value);
                OnPropertyChanged("AdditionalInfo");
            }
        }

        /// <summary>
        ///     Shows the quick campaign record that the log applies to. This information is used to relate log data to the parent
        ///     quick campaign.
        /// </summary>
        [AttributeLogicalName("bulkoperationid")]
        public EntityReference BulkOperationId
        {
            get { return GetAttributeValue<EntityReference>("bulkoperationid"); }
            set
            {
                OnPropertyChanging("BulkOperationId");
                SetAttributeValue("bulkoperationid", value);
                OnPropertyChanged("BulkOperationId");
            }
        }

        /// <summary>
        ///     Unique identifier of the bulk operation log.
        /// </summary>
        [AttributeLogicalName("bulkoperationlogid")]
        public Guid? BulkOperationLogId
        {
            get { return GetAttributeValue<Guid?>("bulkoperationlogid"); }
            set
            {
                OnPropertyChanging("BulkOperationLogId");
                SetAttributeValue("bulkoperationlogid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("BulkOperationLogId");
            }
        }

        [AttributeLogicalName("bulkoperationlogid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { BulkOperationLogId = value; }
        }

        /// <summary>
        ///     Choose the activity or other item created by the bulk operation.
        /// </summary>
        [AttributeLogicalName("createdobjectid")]
        public EntityReference CreatedObjectId
        {
            get { return GetAttributeValue<EntityReference>("createdobjectid"); }
            set
            {
                OnPropertyChanging("CreatedObjectId");
                SetAttributeValue("createdobjectid", value);
                OnPropertyChanged("CreatedObjectId");
            }
        }

        /// <summary>
        ///     Shows the error code that is used to troubleshoot issues in the bulk operation.
        /// </summary>
        [AttributeLogicalName("errornumber")]
        public int? ErrorNumber
        {
            get { return GetAttributeValue<int?>("errornumber"); }
        }

        /// <summary>
        ///     Unique identifier of the user or team who owns the bulk operation log.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId
        {
            get { return GetAttributeValue<EntityReference>("ownerid"); }
        }

        /// <summary>
        ///     Unique identifier of the business unit that owns the bulk operation log.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public Guid? OwningBusinessUnit
        {
            get { return GetAttributeValue<Guid?>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the bulk operation log.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public Guid? OwningUser
        {
            get { return GetAttributeValue<Guid?>("owninguser"); }
        }

        /// <summary>
        ///     Choose the account, contact, lead, or list that the bulk operation log item applies to.
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
        ///     1:N BulkOperationLog_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("BulkOperationLog_AsyncOperations")]
        public IEnumerable<AsyncOperation> BulkOperationLog_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("BulkOperationLog_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("BulkOperationLog_AsyncOperations");
                SetRelatedEntities("BulkOperationLog_AsyncOperations", null, value);
                OnPropertyChanged("BulkOperationLog_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N BulkOperationLog_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("BulkOperationLog_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> BulkOperationLog_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("BulkOperationLog_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("BulkOperationLog_BulkDeleteFailures");
                SetRelatedEntities("BulkOperationLog_BulkDeleteFailures", null, value);
                OnPropertyChanged("BulkOperationLog_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_bulkoperationlog
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_bulkoperationlog")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_bulkoperationlog
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_bulkoperationlog", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_bulkoperationlog");
                SetRelatedEntities("userentityinstancedata_bulkoperationlog", null, value);
                OnPropertyChanged("userentityinstancedata_bulkoperationlog");
            }
        }

        /// <summary>
        ///     N:1 activity_pointer_BulkOperation_logs
        /// </summary>
        [AttributeLogicalName("bulkoperationid")]
        [RelationshipSchemaName("activity_pointer_BulkOperation_logs")]
        public ActivityPointer activity_pointer_BulkOperation_logs
        {
            get { return GetRelatedEntity<ActivityPointer>("activity_pointer_BulkOperation_logs", null); }
            set
            {
                OnPropertyChanging("activity_pointer_BulkOperation_logs");
                SetRelatedEntity("activity_pointer_BulkOperation_logs", null, value);
                OnPropertyChanged("activity_pointer_BulkOperation_logs");
            }
        }

        /// <summary>
        ///     N:1 BulkOperation_logs
        /// </summary>
        [AttributeLogicalName("bulkoperationid")]
        [RelationshipSchemaName("BulkOperation_logs")]
        public BulkOperation BulkOperation_logs
        {
            get { return GetRelatedEntity<BulkOperation>("BulkOperation_logs", null); }
            set
            {
                OnPropertyChanging("BulkOperation_logs");
                SetRelatedEntity("BulkOperation_logs", null, value);
                OnPropertyChanged("BulkOperation_logs");
            }
        }

        /// <summary>
        ///     N:1 CreatedAccount_BulkOperationLogs2
        /// </summary>
        [AttributeLogicalName("createdobjectid")]
        [RelationshipSchemaName("CreatedAccount_BulkOperationLogs2")]
        public Account CreatedAccount_BulkOperationLogs2
        {
            get { return GetRelatedEntity<Account>("CreatedAccount_BulkOperationLogs2", null); }
            set
            {
                OnPropertyChanging("CreatedAccount_BulkOperationLogs2");
                SetRelatedEntity("CreatedAccount_BulkOperationLogs2", null, value);
                OnPropertyChanged("CreatedAccount_BulkOperationLogs2");
            }
        }

        /// <summary>
        ///     N:1 CreatedActivity_BulkOperationLogs
        /// </summary>
        [AttributeLogicalName("createdobjectid")]
        [RelationshipSchemaName("CreatedActivity_BulkOperationLogs")]
        public ActivityPointer CreatedActivity_BulkOperationLogs
        {
            get { return GetRelatedEntity<ActivityPointer>("CreatedActivity_BulkOperationLogs", null); }
            set
            {
                OnPropertyChanging("CreatedActivity_BulkOperationLogs");
                SetRelatedEntity("CreatedActivity_BulkOperationLogs", null, value);
                OnPropertyChanged("CreatedActivity_BulkOperationLogs");
            }
        }

        /// <summary>
        ///     N:1 CreatedContact_BulkOperationLogs
        /// </summary>
        [AttributeLogicalName("createdobjectid")]
        [RelationshipSchemaName("CreatedContact_BulkOperationLogs")]
        public Contact CreatedContact_BulkOperationLogs
        {
            get { return GetRelatedEntity<Contact>("CreatedContact_BulkOperationLogs", null); }
            set
            {
                OnPropertyChanging("CreatedContact_BulkOperationLogs");
                SetRelatedEntity("CreatedContact_BulkOperationLogs", null, value);
                OnPropertyChanged("CreatedContact_BulkOperationLogs");
            }
        }

        /// <summary>
        ///     N:1 CreatedLead_BulkOperationLogs
        /// </summary>
        [AttributeLogicalName("createdobjectid")]
        [RelationshipSchemaName("CreatedLead_BulkOperationLogs")]
        public Lead CreatedLead_BulkOperationLogs
        {
            get { return GetRelatedEntity<Lead>("CreatedLead_BulkOperationLogs", null); }
            set
            {
                OnPropertyChanging("CreatedLead_BulkOperationLogs");
                SetRelatedEntity("CreatedLead_BulkOperationLogs", null, value);
                OnPropertyChanged("CreatedLead_BulkOperationLogs");
            }
        }

        /// <summary>
        ///     N:1 CreatedOpportunity_BulkOperationLogs
        /// </summary>
        [AttributeLogicalName("createdobjectid")]
        [RelationshipSchemaName("CreatedOpportunity_BulkOperationLogs")]
        public Opportunity CreatedOpportunity_BulkOperationLogs
        {
            get { return GetRelatedEntity<Opportunity>("CreatedOpportunity_BulkOperationLogs", null); }
            set
            {
                OnPropertyChanging("CreatedOpportunity_BulkOperationLogs");
                SetRelatedEntity("CreatedOpportunity_BulkOperationLogs", null, value);
                OnPropertyChanged("CreatedOpportunity_BulkOperationLogs");
            }
        }

        /// <summary>
        ///     N:1 SourceAccount_BulkOperationLogs
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SourceAccount_BulkOperationLogs")]
        public Account SourceAccount_BulkOperationLogs
        {
            get { return GetRelatedEntity<Account>("SourceAccount_BulkOperationLogs", null); }
            set
            {
                OnPropertyChanging("SourceAccount_BulkOperationLogs");
                SetRelatedEntity("SourceAccount_BulkOperationLogs", null, value);
                OnPropertyChanged("SourceAccount_BulkOperationLogs");
            }
        }

        /// <summary>
        ///     N:1 SourceContact_BulkOperationLogs
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SourceContact_BulkOperationLogs")]
        public Contact SourceContact_BulkOperationLogs
        {
            get { return GetRelatedEntity<Contact>("SourceContact_BulkOperationLogs", null); }
            set
            {
                OnPropertyChanging("SourceContact_BulkOperationLogs");
                SetRelatedEntity("SourceContact_BulkOperationLogs", null, value);
                OnPropertyChanged("SourceContact_BulkOperationLogs");
            }
        }

        /// <summary>
        ///     N:1 SourceLead_BulkOperationLogs
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("SourceLead_BulkOperationLogs")]
        public Lead SourceLead_BulkOperationLogs
        {
            get { return GetRelatedEntity<Lead>("SourceLead_BulkOperationLogs", null); }
            set
            {
                OnPropertyChanging("SourceLead_BulkOperationLogs");
                SetRelatedEntity("SourceLead_BulkOperationLogs", null, value);
                OnPropertyChanged("SourceLead_BulkOperationLogs");
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