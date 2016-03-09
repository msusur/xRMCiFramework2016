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
    ///     User-submitted bulk deletion job.
    /// </summary>
    [DataContract]
    [EntityLogicalName("bulkdeleteoperation")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class BulkDeleteOperation : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "bulkdeleteoperation";

        public const int EntityTypeCode = 4424;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public BulkDeleteOperation() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the system job that created this record
        /// </summary>
        [AttributeLogicalName("asyncoperationid")]
        public EntityReference AsyncOperationId
        {
            get { return GetAttributeValue<EntityReference>("asyncoperationid"); }
        }

        /// <summary>
        ///     Unique identifier of the bulk deletion job.
        /// </summary>
        [AttributeLogicalName("bulkdeleteoperationid")]
        public Guid? BulkDeleteOperationId
        {
            get { return GetAttributeValue<Guid?>("bulkdeleteoperationid"); }
        }

        [AttributeLogicalName("bulkdeleteoperationid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { base.Id = value; }
        }

        /// <summary>
        ///     Unique identifier of the user who created the bulk deletion job.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the bulk deletion job was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the bulkdeleteoperation.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Number of records that could not be deleted by the bulk deletion job.
        /// </summary>
        [AttributeLogicalName("failurecount")]
        public int? FailureCount
        {
            get { return GetAttributeValue<int?>("failurecount"); }
        }

        /// <summary>
        ///     Information about if recurrence is defined for the bulk deletion job.
        /// </summary>
        [AttributeLogicalName("isrecurring")]
        public bool? IsRecurring
        {
            get { return GetAttributeValue<bool?>("isrecurring"); }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the bulk deletion job.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the bulk deletion job record was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the bulkdeleteoperation.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the bulk deletion job.
        /// </summary>
        [AttributeLogicalName("name")]
        public string Name
        {
            get { return GetAttributeValue<string>("name"); }
        }

        /// <summary>
        ///     Next scheduled time for the bulk deletion job to run.
        /// </summary>
        [AttributeLogicalName("nextrun")]
        public DateTime? NextRun
        {
            get { return GetAttributeValue<DateTime?>("nextrun"); }
        }

        /// <summary>
        ///     Fetch XML of the ordered query set.
        /// </summary>
        [AttributeLogicalName("orderedquerysetxml")]
        public string OrderedQuerySetXml
        {
            get { return GetAttributeValue<string>("orderedquerysetxml"); }
        }

        /// <summary>
        ///     Unique identifier of the user or team who owns the bulk delete operation.
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId
        {
            get { return GetAttributeValue<EntityReference>("ownerid"); }
        }

        /// <summary>
        ///     Business unit that owns the bulk deletion job.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Business user what owns the bulk delete operation.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Index of the ordered query expression that defines the deletion set.
        /// </summary>
        [AttributeLogicalName("processingqeindex")]
        public int? ProcessingQEIndex
        {
            get { return GetAttributeValue<int?>("processingqeindex"); }
        }

        /// <summary>
        ///     Status of the bulk deletion job.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public BulkDeleteOperationState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return
                        ((BulkDeleteOperationState) (Enum.ToObject(typeof (BulkDeleteOperationState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the bulk deletion job.
        /// </summary>
        [AttributeLogicalName("statuscode")]
        public OptionSetValue StatusCode
        {
            get { return GetAttributeValue<OptionSetValue>("statuscode"); }
        }

        /// <summary>
        ///     Number of records deleted by the bulk deletion job.
        /// </summary>
        [AttributeLogicalName("successcount")]
        public int? SuccessCount
        {
            get { return GetAttributeValue<int?>("successcount"); }
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
        ///     1:N BulkDeleteOperation_BulkDeleteFailure
        /// </summary>
        [RelationshipSchemaName("BulkDeleteOperation_BulkDeleteFailure")]
        public IEnumerable<BulkDeleteFailure> BulkDeleteOperation_BulkDeleteFailure
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("BulkDeleteOperation_BulkDeleteFailure", null); }
            set
            {
                OnPropertyChanging("BulkDeleteOperation_BulkDeleteFailure");
                SetRelatedEntities("BulkDeleteOperation_BulkDeleteFailure", null, value);
                OnPropertyChanged("BulkDeleteOperation_BulkDeleteFailure");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_bulkdeleteoperation
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_bulkdeleteoperation")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_bulkdeleteoperation
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_bulkdeleteoperation", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_bulkdeleteoperation");
                SetRelatedEntities("userentityinstancedata_bulkdeleteoperation", null, value);
                OnPropertyChanged("userentityinstancedata_bulkdeleteoperation");
            }
        }

        /// <summary>
        ///     N:1 AsyncOperation_BulkDeleteOperation
        /// </summary>
        [AttributeLogicalName("asyncoperationid")]
        [RelationshipSchemaName("AsyncOperation_BulkDeleteOperation")]
        public AsyncOperation AsyncOperation_BulkDeleteOperation
        {
            get { return GetRelatedEntity<AsyncOperation>("AsyncOperation_BulkDeleteOperation", null); }
        }

        /// <summary>
        ///     N:1 lk_bulkdeleteoperation_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_bulkdeleteoperation_createdonbehalfby")]
        public SystemUser lk_bulkdeleteoperation_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_bulkdeleteoperation_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_bulkdeleteoperation_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_bulkdeleteoperation_modifiedonbehalfby")]
        public SystemUser lk_bulkdeleteoperation_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_bulkdeleteoperation_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_bulkdeleteoperationbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_bulkdeleteoperationbase_createdby")]
        public SystemUser lk_bulkdeleteoperationbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_bulkdeleteoperationbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_bulkdeleteoperationbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_bulkdeleteoperationbase_modifiedby")]
        public SystemUser lk_bulkdeleteoperationbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_bulkdeleteoperationbase_modifiedby", null); }
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