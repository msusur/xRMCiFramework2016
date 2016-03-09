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
    ///     For internal use only.
    /// </summary>
    [DataContract]
    [EntityLogicalName("importjob")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class ImportJob : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "importjob";

        public const int EntityTypeCode = 9107;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public ImportJob() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Date and time when the import job was completed.
        /// </summary>
        [AttributeLogicalName("completedon")]
        public DateTime? CompletedOn
        {
            get { return GetAttributeValue<DateTime?>("completedon"); }
        }

        /// <summary>
        ///     Unique identifier of the user who created the importJob.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the import job record was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the import job record.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Unstructured data associated with the import job.
        /// </summary>
        [AttributeLogicalName("data")]
        public string Data
        {
            get { return GetAttributeValue<string>("data"); }
            set
            {
                OnPropertyChanging("Data");
                SetAttributeValue("data", value);
                OnPropertyChanged("Data");
            }
        }

        /// <summary>
        ///     Unique identifier of the import job.
        /// </summary>
        [AttributeLogicalName("importjobid")]
        public Guid? ImportJobId
        {
            get { return GetAttributeValue<Guid?>("importjobid"); }
            set
            {
                OnPropertyChanging("ImportJobId");
                SetAttributeValue("importjobid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ImportJobId");
            }
        }

        [AttributeLogicalName("importjobid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ImportJobId = value; }
        }

        /// <summary>
        ///     Unique identifier of the user who modified the importJob.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the import job was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who modified the import job record.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the import job.
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
        ///     Unique identifier of the organization associated with the importjob.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     Import Progress Percentage.
        /// </summary>
        [AttributeLogicalName("progress")]
        public double? Progress
        {
            get { return GetAttributeValue<double?>("progress"); }
            set
            {
                OnPropertyChanging("Progress");
                SetAttributeValue("progress", value);
                OnPropertyChanged("Progress");
            }
        }

        /// <summary>
        ///     Unique identifier of the solution.
        /// </summary>
        [AttributeLogicalName("solutionname")]
        public string SolutionName
        {
            get { return GetAttributeValue<string>("solutionname"); }
            set
            {
                OnPropertyChanging("SolutionName");
                SetAttributeValue("solutionname", value);
                OnPropertyChanged("SolutionName");
            }
        }

        /// <summary>
        ///     Date and time when the import job was started.
        /// </summary>
        [AttributeLogicalName("startedon")]
        public DateTime? StartedOn
        {
            get { return GetAttributeValue<DateTime?>("startedon"); }
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
        ///     1:N userentityinstancedata_importjob
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_importjob")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_importjob
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_importjob", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_importjob");
                SetRelatedEntities("userentityinstancedata_importjob", null, value);
                OnPropertyChanged("userentityinstancedata_importjob");
            }
        }

        /// <summary>
        ///     N:1 lk_importjobbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_importjobbase_createdby")]
        public SystemUser lk_importjobbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_importjobbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_importjobbase_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_importjobbase_createdonbehalfby")]
        public SystemUser lk_importjobbase_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_importjobbase_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_importjobbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_importjobbase_modifiedby")]
        public SystemUser lk_importjobbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_importjobbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_importjobbase_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_importjobbase_modifiedonbehalfby")]
        public SystemUser lk_importjobbase_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_importjobbase_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 organization_importjob
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_importjob")]
        public Organization organization_importjob
        {
            get { return GetRelatedEntity<Organization>("organization_importjob", null); }
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