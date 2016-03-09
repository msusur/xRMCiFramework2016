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
    ///     Service request case associated with a contract.
    /// </summary>
    [DataContract]
    [EntityLogicalName("incident")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Incident : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "incident";

        public const int EntityTypeCode = 112;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Incident() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the account with which the case is associated.
        /// </summary>
        [AttributeLogicalName("accountid")]
        public EntityReference AccountId
        {
            get { return GetAttributeValue<EntityReference>("accountid"); }
        }

        /// <summary>
        ///     This attribute is used for Sample Service Business Processes.
        /// </summary>
        [AttributeLogicalName("activitiescomplete")]
        public bool? ActivitiesComplete
        {
            get { return GetAttributeValue<bool?>("activitiescomplete"); }
            set
            {
                OnPropertyChanging("ActivitiesComplete");
                SetAttributeValue("activitiescomplete", value);
                OnPropertyChanged("ActivitiesComplete");
            }
        }

        /// <summary>
        ///     Type the number of service units that were actually required to resolve the case.
        /// </summary>
        [AttributeLogicalName("actualserviceunits")]
        public int? ActualServiceUnits
        {
            get { return GetAttributeValue<int?>("actualserviceunits"); }
            set
            {
                OnPropertyChanging("ActualServiceUnits");
                SetAttributeValue("actualserviceunits", value);
                OnPropertyChanged("ActualServiceUnits");
            }
        }

        /// <summary>
        ///     Type the number of service units that were billed to the customer for the case.
        /// </summary>
        [AttributeLogicalName("billedserviceunits")]
        public int? BilledServiceUnits
        {
            get { return GetAttributeValue<int?>("billedserviceunits"); }
            set
            {
                OnPropertyChanging("BilledServiceUnits");
                SetAttributeValue("billedserviceunits", value);
                OnPropertyChanged("BilledServiceUnits");
            }
        }

        /// <summary>
        ///     Select how contact about the case was originated, such as email, phone, or web, for use in reporting and analysis.
        /// </summary>
        [AttributeLogicalName("caseorigincode")]
        public OptionSetValue CaseOriginCode
        {
            get { return GetAttributeValue<OptionSetValue>("caseorigincode"); }
            set
            {
                OnPropertyChanging("CaseOriginCode");
                SetAttributeValue("caseorigincode", value);
                OnPropertyChanged("CaseOriginCode");
            }
        }

        /// <summary>
        ///     Select the type of case to identify the incident for use in case routing and analysis.
        /// </summary>
        [AttributeLogicalName("casetypecode")]
        public OptionSetValue CaseTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("casetypecode"); }
            set
            {
                OnPropertyChanging("CaseTypeCode");
                SetAttributeValue("casetypecode", value);
                OnPropertyChanged("CaseTypeCode");
            }
        }

        /// <summary>
        ///     This attribute is used for Sample Service Business Processes.
        /// </summary>
        [AttributeLogicalName("checkemail")]
        public bool? CheckEmail
        {
            get { return GetAttributeValue<bool?>("checkemail"); }
            set
            {
                OnPropertyChanging("CheckEmail");
                SetAttributeValue("checkemail", value);
                OnPropertyChanged("CheckEmail");
            }
        }

        /// <summary>
        ///     Unique identifier of the contact associated with the case.
        /// </summary>
        [AttributeLogicalName("contactid")]
        public EntityReference ContactId
        {
            get { return GetAttributeValue<EntityReference>("contactid"); }
        }

        /// <summary>
        ///     Choose the contract line that the case should be logged under to make sure the customer is charged correctly.
        /// </summary>
        [AttributeLogicalName("contractdetailid")]
        public EntityReference ContractDetailId
        {
            get { return GetAttributeValue<EntityReference>("contractdetailid"); }
            set
            {
                OnPropertyChanging("ContractDetailId");
                SetAttributeValue("contractdetailid", value);
                OnPropertyChanged("ContractDetailId");
            }
        }

        /// <summary>
        ///     Choose the service contract that the case should be logged under to make sure the customer is eligible for support
        ///     services.
        /// </summary>
        [AttributeLogicalName("contractid")]
        public EntityReference ContractId
        {
            get { return GetAttributeValue<EntityReference>("contractid"); }
            set
            {
                OnPropertyChanging("ContractId");
                SetAttributeValue("contractid", value);
                OnPropertyChanged("ContractId");
            }
        }

        /// <summary>
        ///     Select the service level for the case to make sure the case is handled correctly.
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
        ///     Shows who created the record.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Shows the date and time when the record was created. The date and time are displayed in the time zone selected in
        ///     Microsoft Dynamics CRM options.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Shows who created the record on behalf of another user.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Select the customer account or contact to provide a quick link to additional customer details, such as account
        ///     information, activities, and opportunities.
        /// </summary>
        [AttributeLogicalName("customerid")]
        public EntityReference CustomerId
        {
            get { return GetAttributeValue<EntityReference>("customerid"); }
            set
            {
                OnPropertyChanging("CustomerId");
                SetAttributeValue("customerid", value);
                OnPropertyChanged("CustomerId");
            }
        }

        /// <summary>
        ///     Select the customer's level of satisfaction with the handling and resolution of the case.
        /// </summary>
        [AttributeLogicalName("customersatisfactioncode")]
        public OptionSetValue CustomerSatisfactionCode
        {
            get { return GetAttributeValue<OptionSetValue>("customersatisfactioncode"); }
            set
            {
                OnPropertyChanging("CustomerSatisfactionCode");
                SetAttributeValue("customersatisfactioncode", value);
                OnPropertyChanged("CustomerSatisfactionCode");
            }
        }

        /// <summary>
        ///     Type additional information to describe the case to assist the service team in reaching a resolution.
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
        ///     The default image for the entity.
        /// </summary>
        [AttributeLogicalName("entityimage")]
        public byte[] EntityImage
        {
            get { return GetAttributeValue<byte[]>("entityimage"); }
            set
            {
                OnPropertyChanging("EntityImage");
                SetAttributeValue("entityimage", value);
                OnPropertyChanged("EntityImage");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("entityimage_timestamp")]
        public long? EntityImage_Timestamp
        {
            get { return GetAttributeValue<long?>("entityimage_timestamp"); }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("entityimage_url")]
        public string EntityImage_URL
        {
            get { return GetAttributeValue<string>("entityimage_url"); }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("entityimageid")]
        public Guid? EntityImageId
        {
            get { return GetAttributeValue<Guid?>("entityimageid"); }
        }

        /// <summary>
        ///     Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the
        ///     record from the local currency to the system's default currency.
        /// </summary>
        [AttributeLogicalName("exchangerate")]
        public decimal? ExchangeRate
        {
            get { return GetAttributeValue<decimal?>("exchangerate"); }
        }

        /// <summary>
        ///     Select an existing case for the customer that has been populated. For internal use only.
        /// </summary>
        [AttributeLogicalName("existingcase")]
        public EntityReference ExistingCase
        {
            get { return GetAttributeValue<EntityReference>("existingcase"); }
            set
            {
                OnPropertyChanging("ExistingCase");
                SetAttributeValue("existingcase", value);
                OnPropertyChanged("ExistingCase");
            }
        }

        /// <summary>
        ///     Enter the date by which a customer service representative has to follow up with the customer on this case.
        /// </summary>
        [AttributeLogicalName("followupby")]
        public DateTime? FollowupBy
        {
            get { return GetAttributeValue<DateTime?>("followupby"); }
            set
            {
                OnPropertyChanging("FollowupBy");
                SetAttributeValue("followupby", value);
                OnPropertyChanged("FollowupBy");
            }
        }

        /// <summary>
        ///     This attribute is used for Sample Service Business Processes.
        /// </summary>
        [AttributeLogicalName("followuptaskcreated")]
        public bool? FollowUpTaskCreated
        {
            get { return GetAttributeValue<bool?>("followuptaskcreated"); }
            set
            {
                OnPropertyChanging("FollowUpTaskCreated");
                SetAttributeValue("followuptaskcreated", value);
                OnPropertyChanged("FollowUpTaskCreated");
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
        ///     Unique identifier of the case.
        /// </summary>
        [AttributeLogicalName("incidentid")]
        public Guid? IncidentId
        {
            get { return GetAttributeValue<Guid?>("incidentid"); }
            set
            {
                OnPropertyChanging("IncidentId");
                SetAttributeValue("incidentid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("IncidentId");
            }
        }

        [AttributeLogicalName("incidentid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { IncidentId = value; }
        }

        /// <summary>
        ///     Select the current stage of the service process for the case to assist service team members when they review or
        ///     transfer a case.
        /// </summary>
        [AttributeLogicalName("incidentstagecode")]
        public OptionSetValue IncidentStageCode
        {
            get { return GetAttributeValue<OptionSetValue>("incidentstagecode"); }
            set
            {
                OnPropertyChanging("IncidentStageCode");
                SetAttributeValue("incidentstagecode", value);
                OnPropertyChanged("IncidentStageCode");
            }
        }

        /// <summary>
        ///     For system use only.
        /// </summary>
        [AttributeLogicalName("isdecrementing")]
        public bool? IsDecrementing
        {
            get { return GetAttributeValue<bool?>("isdecrementing"); }
            set
            {
                OnPropertyChanging("IsDecrementing");
                SetAttributeValue("isdecrementing", value);
                OnPropertyChanged("IsDecrementing");
            }
        }

        /// <summary>
        ///     Choose the article that contains additional information or a resolution for the case, for reference during research
        ///     or follow up with the customer.
        /// </summary>
        [AttributeLogicalName("kbarticleid")]
        public EntityReference KbArticleId
        {
            get { return GetAttributeValue<EntityReference>("kbarticleid"); }
            set
            {
                OnPropertyChanging("KbArticleId");
                SetAttributeValue("kbarticleid", value);
                OnPropertyChanged("KbArticleId");
            }
        }

        /// <summary>
        ///     Shows who last updated the record.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected
        ///     in Microsoft Dynamics CRM options.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Shows who last updated the record on behalf of another user.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
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
        ///     Enter the user or team who is assigned to manage the record. This field is updated every time the record is
        ///     assigned to a different user.
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
        ///     Unique identifier of the business unit that owns the case.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the case.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the case.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Select the priority so that preferred customers or critical issues are handled quickly.
        /// </summary>
        [AttributeLogicalName("prioritycode")]
        public OptionSetValue PriorityCode
        {
            get { return GetAttributeValue<OptionSetValue>("prioritycode"); }
            set
            {
                OnPropertyChanging("PriorityCode");
                SetAttributeValue("prioritycode", value);
                OnPropertyChanged("PriorityCode");
            }
        }

        /// <summary>
        ///     Shows the ID of the process.
        /// </summary>
        [AttributeLogicalName("processid")]
        public Guid? ProcessId
        {
            get { return GetAttributeValue<Guid?>("processid"); }
            set
            {
                OnPropertyChanging("ProcessId");
                SetAttributeValue("processid", value);
                OnPropertyChanged("ProcessId");
            }
        }

        /// <summary>
        ///     Choose the product associated with the case to identify warranty, service, or other product issues and be able to
        ///     report the number of incidents for each product.
        /// </summary>
        [AttributeLogicalName("productid")]
        public EntityReference ProductId
        {
            get { return GetAttributeValue<EntityReference>("productid"); }
            set
            {
                OnPropertyChanging("ProductId");
                SetAttributeValue("productid", value);
                OnPropertyChanged("ProductId");
            }
        }

        /// <summary>
        ///     Type the serial number of the product that is associated with this case, so that the number of cases per product
        ///     can be reported.
        /// </summary>
        [AttributeLogicalName("productserialnumber")]
        public string ProductSerialNumber
        {
            get { return GetAttributeValue<string>("productserialnumber"); }
            set
            {
                OnPropertyChanging("ProductSerialNumber");
                SetAttributeValue("productserialnumber", value);
                OnPropertyChanged("ProductSerialNumber");
            }
        }

        /// <summary>
        ///     Choose the primary customer contact who submitted or is tasked with helping resolve the case. This lets you select
        ///     a contact to access phone, email, and other contact information for quick follow up on the case.
        /// </summary>
        [AttributeLogicalName("responsiblecontactid")]
        public EntityReference ResponsibleContactId
        {
            get { return GetAttributeValue<EntityReference>("responsiblecontactid"); }
            set
            {
                OnPropertyChanging("ResponsibleContactId");
                SetAttributeValue("responsiblecontactid", value);
                OnPropertyChanged("ResponsibleContactId");
            }
        }

        /// <summary>
        ///     Select the stage, in the case resolution process, that the case is in.
        /// </summary>
        [AttributeLogicalName("servicestage")]
        public OptionSetValue ServiceStage
        {
            get { return GetAttributeValue<OptionSetValue>("servicestage"); }
            set
            {
                OnPropertyChanging("ServiceStage");
                SetAttributeValue("servicestage", value);
                OnPropertyChanged("ServiceStage");
            }
        }

        /// <summary>
        ///     Select the severity of this case to indicate the incident's impact on the customer's business.
        /// </summary>
        [AttributeLogicalName("severitycode")]
        public OptionSetValue SeverityCode
        {
            get { return GetAttributeValue<OptionSetValue>("severitycode"); }
            set
            {
                OnPropertyChanging("SeverityCode");
                SetAttributeValue("severitycode", value);
                OnPropertyChanged("SeverityCode");
            }
        }

        /// <summary>
        ///     Shows the ID of the stage.
        /// </summary>
        [AttributeLogicalName("stageid")]
        public Guid? StageId
        {
            get { return GetAttributeValue<Guid?>("stageid"); }
            set
            {
                OnPropertyChanging("StageId");
                SetAttributeValue("stageid", value);
                OnPropertyChanged("StageId");
            }
        }

        /// <summary>
        ///     Shows whether the case is active, resolved, or canceled. Resolved and canceled cases are read-only and can't be
        ///     edited unless they are reactivated.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public IncidentState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((IncidentState) (Enum.ToObject(typeof (IncidentState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Select the case's status.
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
        ///     Choose the subject for the case, such as catalog request or product complaint, so customer service managers can
        ///     identify frequent requests or problem areas. Administrators can configure subjects under Business Management in the
        ///     Settings area.
        /// </summary>
        [AttributeLogicalName("subjectid")]
        public EntityReference SubjectId
        {
            get { return GetAttributeValue<EntityReference>("subjectid"); }
            set
            {
                OnPropertyChanging("SubjectId");
                SetAttributeValue("subjectid", value);
                OnPropertyChanged("SubjectId");
            }
        }

        /// <summary>
        ///     Shows the case number for customer reference and searching capabilities. This cannot be modified.
        /// </summary>
        [AttributeLogicalName("ticketnumber")]
        public string TicketNumber
        {
            get { return GetAttributeValue<string>("ticketnumber"); }
            set
            {
                OnPropertyChanging("TicketNumber");
                SetAttributeValue("ticketnumber", value);
                OnPropertyChanged("TicketNumber");
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
        ///     Type a subject or descriptive name, such as the request, issue, or company name, to identify the case in Microsoft
        ///     Dynamics CRM views.
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
        ///     Choose the local currency for the record to make sure budgets are reported in the correct currency.
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
        ///     Version number of the case.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N incident_activity_parties
        /// </summary>
        [RelationshipSchemaName("incident_activity_parties")]
        public IEnumerable<ActivityParty> incident_activity_parties
        {
            get { return GetRelatedEntities<ActivityParty>("incident_activity_parties", null); }
            set
            {
                OnPropertyChanging("incident_activity_parties");
                SetRelatedEntities("incident_activity_parties", null, value);
                OnPropertyChanged("incident_activity_parties");
            }
        }

        /// <summary>
        ///     1:N Incident_ActivityPointers
        /// </summary>
        [RelationshipSchemaName("Incident_ActivityPointers")]
        public IEnumerable<ActivityPointer> Incident_ActivityPointers
        {
            get { return GetRelatedEntities<ActivityPointer>("Incident_ActivityPointers", null); }
            set
            {
                OnPropertyChanging("Incident_ActivityPointers");
                SetRelatedEntities("Incident_ActivityPointers", null, value);
                OnPropertyChanged("Incident_ActivityPointers");
            }
        }

        /// <summary>
        ///     1:N Incident_Annotation
        /// </summary>
        [RelationshipSchemaName("Incident_Annotation")]
        public IEnumerable<Annotation> Incident_Annotation
        {
            get { return GetRelatedEntities<Annotation>("Incident_Annotation", null); }
            set
            {
                OnPropertyChanging("Incident_Annotation");
                SetRelatedEntities("Incident_Annotation", null, value);
                OnPropertyChanged("Incident_Annotation");
            }
        }

        /// <summary>
        ///     1:N Incident_Appointments
        /// </summary>
        [RelationshipSchemaName("Incident_Appointments")]
        public IEnumerable<Appointment> Incident_Appointments
        {
            get { return GetRelatedEntities<Appointment>("Incident_Appointments", null); }
            set
            {
                OnPropertyChanging("Incident_Appointments");
                SetRelatedEntities("Incident_Appointments", null, value);
                OnPropertyChanged("Incident_Appointments");
            }
        }

        /// <summary>
        ///     1:N Incident_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Incident_AsyncOperations")]
        public IEnumerable<AsyncOperation> Incident_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Incident_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Incident_AsyncOperations");
                SetRelatedEntities("Incident_AsyncOperations", null, value);
                OnPropertyChanged("Incident_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N Incident_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("Incident_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> Incident_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("Incident_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("Incident_BulkDeleteFailures");
                SetRelatedEntities("Incident_BulkDeleteFailures", null, value);
                OnPropertyChanged("Incident_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N incident_connections1
        /// </summary>
        [RelationshipSchemaName("incident_connections1")]
        public IEnumerable<Connection> incident_connections1
        {
            get { return GetRelatedEntities<Connection>("incident_connections1", null); }
            set
            {
                OnPropertyChanging("incident_connections1");
                SetRelatedEntities("incident_connections1", null, value);
                OnPropertyChanged("incident_connections1");
            }
        }

        /// <summary>
        ///     1:N incident_connections2
        /// </summary>
        [RelationshipSchemaName("incident_connections2")]
        public IEnumerable<Connection> incident_connections2
        {
            get { return GetRelatedEntities<Connection>("incident_connections2", null); }
            set
            {
                OnPropertyChanging("incident_connections2");
                SetRelatedEntities("incident_connections2", null, value);
                OnPropertyChanged("incident_connections2");
            }
        }

        /// <summary>
        ///     1:N Incident_DuplicateBaseRecord
        /// </summary>
        [RelationshipSchemaName("Incident_DuplicateBaseRecord")]
        public IEnumerable<DuplicateRecord> Incident_DuplicateBaseRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Incident_DuplicateBaseRecord", null); }
            set
            {
                OnPropertyChanging("Incident_DuplicateBaseRecord");
                SetRelatedEntities("Incident_DuplicateBaseRecord", null, value);
                OnPropertyChanged("Incident_DuplicateBaseRecord");
            }
        }

        /// <summary>
        ///     1:N Incident_DuplicateMatchingRecord
        /// </summary>
        [RelationshipSchemaName("Incident_DuplicateMatchingRecord")]
        public IEnumerable<DuplicateRecord> Incident_DuplicateMatchingRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("Incident_DuplicateMatchingRecord", null); }
            set
            {
                OnPropertyChanging("Incident_DuplicateMatchingRecord");
                SetRelatedEntities("Incident_DuplicateMatchingRecord", null, value);
                OnPropertyChanged("Incident_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        ///     1:N Incident_Emails
        /// </summary>
        [RelationshipSchemaName("Incident_Emails")]
        public IEnumerable<Email> Incident_Emails
        {
            get { return GetRelatedEntities<Email>("Incident_Emails", null); }
            set
            {
                OnPropertyChanging("Incident_Emails");
                SetRelatedEntities("Incident_Emails", null, value);
                OnPropertyChanged("Incident_Emails");
            }
        }

        /// <summary>
        ///     1:N incident_existingcase
        /// </summary>
        [RelationshipSchemaName("incident_existingcase", EntityRole.Referenced)]
        public IEnumerable<Incident> Referencedincident_existingcase
        {
            get { return GetRelatedEntities<Incident>("incident_existingcase", EntityRole.Referenced); }
            set
            {
                OnPropertyChanging("Referencedincident_existingcase");
                SetRelatedEntities("incident_existingcase", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedincident_existingcase");
            }
        }

        /// <summary>
        ///     1:N Incident_Faxes
        /// </summary>
        [RelationshipSchemaName("Incident_Faxes")]
        public IEnumerable<Fax> Incident_Faxes
        {
            get { return GetRelatedEntities<Fax>("Incident_Faxes", null); }
            set
            {
                OnPropertyChanging("Incident_Faxes");
                SetRelatedEntities("Incident_Faxes", null, value);
                OnPropertyChanged("Incident_Faxes");
            }
        }

        /// <summary>
        ///     1:N Incident_IncidentResolutions
        /// </summary>
        [RelationshipSchemaName("Incident_IncidentResolutions")]
        public IEnumerable<IncidentResolution> Incident_IncidentResolutions
        {
            get { return GetRelatedEntities<IncidentResolution>("Incident_IncidentResolutions", null); }
            set
            {
                OnPropertyChanging("Incident_IncidentResolutions");
                SetRelatedEntities("Incident_IncidentResolutions", null, value);
                OnPropertyChanged("Incident_IncidentResolutions");
            }
        }

        /// <summary>
        ///     1:N Incident_Letters
        /// </summary>
        [RelationshipSchemaName("Incident_Letters")]
        public IEnumerable<Letter> Incident_Letters
        {
            get { return GetRelatedEntities<Letter>("Incident_Letters", null); }
            set
            {
                OnPropertyChanging("Incident_Letters");
                SetRelatedEntities("Incident_Letters", null, value);
                OnPropertyChanged("Incident_Letters");
            }
        }

        /// <summary>
        ///     1:N Incident_Phonecalls
        /// </summary>
        [RelationshipSchemaName("Incident_Phonecalls")]
        public IEnumerable<PhoneCall> Incident_Phonecalls
        {
            get { return GetRelatedEntities<PhoneCall>("Incident_Phonecalls", null); }
            set
            {
                OnPropertyChanging("Incident_Phonecalls");
                SetRelatedEntities("Incident_Phonecalls", null, value);
                OnPropertyChanged("Incident_Phonecalls");
            }
        }

        /// <summary>
        ///     1:N incident_PostFollows
        /// </summary>
        [RelationshipSchemaName("incident_PostFollows")]
        public IEnumerable<PostFollow> incident_PostFollows
        {
            get { return GetRelatedEntities<PostFollow>("incident_PostFollows", null); }
            set
            {
                OnPropertyChanging("incident_PostFollows");
                SetRelatedEntities("incident_PostFollows", null, value);
                OnPropertyChanged("incident_PostFollows");
            }
        }

        /// <summary>
        ///     1:N incident_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("incident_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> incident_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntities<PrincipalObjectAttributeAccess>("incident_principalobjectattributeaccess",
                    null);
            }
            set
            {
                OnPropertyChanging("incident_principalobjectattributeaccess");
                SetRelatedEntities("incident_principalobjectattributeaccess", null, value);
                OnPropertyChanged("incident_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N Incident_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("Incident_ProcessSessions")]
        public IEnumerable<ProcessSession> Incident_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("Incident_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Incident_ProcessSessions");
                SetRelatedEntities("Incident_ProcessSessions", null, value);
                OnPropertyChanged("Incident_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N Incident_QueueItem
        /// </summary>
        [RelationshipSchemaName("Incident_QueueItem")]
        public IEnumerable<QueueItem> Incident_QueueItem
        {
            get { return GetRelatedEntities<QueueItem>("Incident_QueueItem", null); }
            set
            {
                OnPropertyChanging("Incident_QueueItem");
                SetRelatedEntities("Incident_QueueItem", null, value);
                OnPropertyChanged("Incident_QueueItem");
            }
        }

        /// <summary>
        ///     1:N Incident_RecurringAppointmentMasters
        /// </summary>
        [RelationshipSchemaName("Incident_RecurringAppointmentMasters")]
        public IEnumerable<RecurringAppointmentMaster> Incident_RecurringAppointmentMasters
        {
            get { return GetRelatedEntities<RecurringAppointmentMaster>("Incident_RecurringAppointmentMasters", null); }
            set
            {
                OnPropertyChanging("Incident_RecurringAppointmentMasters");
                SetRelatedEntities("Incident_RecurringAppointmentMasters", null, value);
                OnPropertyChanged("Incident_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        ///     1:N Incident_ServiceAppointments
        /// </summary>
        [RelationshipSchemaName("Incident_ServiceAppointments")]
        public IEnumerable<ServiceAppointment> Incident_ServiceAppointments
        {
            get { return GetRelatedEntities<ServiceAppointment>("Incident_ServiceAppointments", null); }
            set
            {
                OnPropertyChanging("Incident_ServiceAppointments");
                SetRelatedEntities("Incident_ServiceAppointments", null, value);
                OnPropertyChanged("Incident_ServiceAppointments");
            }
        }

        /// <summary>
        ///     1:N Incident_Tasks
        /// </summary>
        [RelationshipSchemaName("Incident_Tasks")]
        public IEnumerable<Task> Incident_Tasks
        {
            get { return GetRelatedEntities<Task>("Incident_Tasks", null); }
            set
            {
                OnPropertyChanging("Incident_Tasks");
                SetRelatedEntities("Incident_Tasks", null, value);
                OnPropertyChanged("Incident_Tasks");
            }
        }

        /// <summary>
        ///     1:N OriginatingCase_Lead
        /// </summary>
        [RelationshipSchemaName("OriginatingCase_Lead")]
        public IEnumerable<Lead> OriginatingCase_Lead
        {
            get { return GetRelatedEntities<Lead>("OriginatingCase_Lead", null); }
            set
            {
                OnPropertyChanging("OriginatingCase_Lead");
                SetRelatedEntities("OriginatingCase_Lead", null, value);
                OnPropertyChanged("OriginatingCase_Lead");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_incident
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_incident")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_incident
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_incident", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_incident");
                SetRelatedEntities("userentityinstancedata_incident", null, value);
                OnPropertyChanged("userentityinstancedata_incident");
            }
        }

        /// <summary>
        ///     N:1 business_unit_incidents
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_incidents")]
        public BusinessUnit business_unit_incidents
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_incidents", null); }
        }

        /// <summary>
        ///     N:1 contact_as_responsible_contact
        /// </summary>
        [AttributeLogicalName("responsiblecontactid")]
        [RelationshipSchemaName("contact_as_responsible_contact")]
        public Contact contact_as_responsible_contact
        {
            get { return GetRelatedEntity<Contact>("contact_as_responsible_contact", null); }
            set
            {
                OnPropertyChanging("contact_as_responsible_contact");
                SetRelatedEntity("contact_as_responsible_contact", null, value);
                OnPropertyChanged("contact_as_responsible_contact");
            }
        }

        /// <summary>
        ///     N:1 contract_cases
        /// </summary>
        [AttributeLogicalName("contractid")]
        [RelationshipSchemaName("contract_cases")]
        public Contract contract_cases
        {
            get { return GetRelatedEntity<Contract>("contract_cases", null); }
            set
            {
                OnPropertyChanging("contract_cases");
                SetRelatedEntity("contract_cases", null, value);
                OnPropertyChanged("contract_cases");
            }
        }

        /// <summary>
        ///     N:1 contract_detail_cases
        /// </summary>
        [AttributeLogicalName("contractdetailid")]
        [RelationshipSchemaName("contract_detail_cases")]
        public ContractDetail contract_detail_cases
        {
            get { return GetRelatedEntity<ContractDetail>("contract_detail_cases", null); }
            set
            {
                OnPropertyChanging("contract_detail_cases");
                SetRelatedEntity("contract_detail_cases", null, value);
                OnPropertyChanged("contract_detail_cases");
            }
        }

        /// <summary>
        ///     N:1 incident_customer_accounts
        /// </summary>
        [AttributeLogicalName("customerid")]
        [RelationshipSchemaName("incident_customer_accounts")]
        public Account incident_customer_accounts
        {
            get { return GetRelatedEntity<Account>("incident_customer_accounts", null); }
            set
            {
                OnPropertyChanging("incident_customer_accounts");
                SetRelatedEntity("incident_customer_accounts", null, value);
                OnPropertyChanged("incident_customer_accounts");
            }
        }

        /// <summary>
        ///     N:1 incident_customer_contacts
        /// </summary>
        [AttributeLogicalName("customerid")]
        [RelationshipSchemaName("incident_customer_contacts")]
        public Contact incident_customer_contacts
        {
            get { return GetRelatedEntity<Contact>("incident_customer_contacts", null); }
            set
            {
                OnPropertyChanging("incident_customer_contacts");
                SetRelatedEntity("incident_customer_contacts", null, value);
                OnPropertyChanged("incident_customer_contacts");
            }
        }

        /// <summary>
        ///     N:1 incident_existingcase
        /// </summary>
        [AttributeLogicalName("existingcase")]
        [RelationshipSchemaName("incident_existingcase", EntityRole.Referencing)]
        public Incident Referencingincident_existingcase
        {
            get { return GetRelatedEntity<Incident>("incident_existingcase", EntityRole.Referencing); }
            set
            {
                OnPropertyChanging("Referencingincident_existingcase");
                SetRelatedEntity("incident_existingcase", EntityRole.Referencing, value);
                OnPropertyChanged("Referencingincident_existingcase");
            }
        }

        /// <summary>
        ///     N:1 kbarticle_incidents
        /// </summary>
        [AttributeLogicalName("kbarticleid")]
        [RelationshipSchemaName("kbarticle_incidents")]
        public KbArticle kbarticle_incidents
        {
            get { return GetRelatedEntity<KbArticle>("kbarticle_incidents", null); }
            set
            {
                OnPropertyChanging("kbarticle_incidents");
                SetRelatedEntity("kbarticle_incidents", null, value);
                OnPropertyChanged("kbarticle_incidents");
            }
        }

        /// <summary>
        ///     N:1 lk_incidentbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_incidentbase_createdby")]
        public SystemUser lk_incidentbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_incidentbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_incidentbase_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_incidentbase_createdonbehalfby")]
        public SystemUser lk_incidentbase_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_incidentbase_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_incidentbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_incidentbase_modifiedby")]
        public SystemUser lk_incidentbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_incidentbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_incidentbase_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_incidentbase_modifiedonbehalfby")]
        public SystemUser lk_incidentbase_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_incidentbase_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 processstage_incident
        /// </summary>
        [AttributeLogicalName("stageid")]
        [RelationshipSchemaName("processstage_incident")]
        public ProcessStage processstage_incident
        {
            get { return GetRelatedEntity<ProcessStage>("processstage_incident", null); }
            set
            {
                OnPropertyChanging("processstage_incident");
                SetRelatedEntity("processstage_incident", null, value);
                OnPropertyChanged("processstage_incident");
            }
        }

        /// <summary>
        ///     N:1 product_incidents
        /// </summary>
        [AttributeLogicalName("productid")]
        [RelationshipSchemaName("product_incidents")]
        public Product product_incidents
        {
            get { return GetRelatedEntity<Product>("product_incidents", null); }
            set
            {
                OnPropertyChanging("product_incidents");
                SetRelatedEntity("product_incidents", null, value);
                OnPropertyChanged("product_incidents");
            }
        }

        /// <summary>
        ///     N:1 subject_incidents
        /// </summary>
        [AttributeLogicalName("subjectid")]
        [RelationshipSchemaName("subject_incidents")]
        public Subject subject_incidents
        {
            get { return GetRelatedEntity<Subject>("subject_incidents", null); }
            set
            {
                OnPropertyChanging("subject_incidents");
                SetRelatedEntity("subject_incidents", null, value);
                OnPropertyChanged("subject_incidents");
            }
        }

        /// <summary>
        ///     N:1 system_user_incidents
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("system_user_incidents")]
        public SystemUser system_user_incidents
        {
            get { return GetRelatedEntity<SystemUser>("system_user_incidents", null); }
        }

        /// <summary>
        ///     N:1 team_incidents
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_incidents")]
        public Team team_incidents
        {
            get { return GetRelatedEntity<Team>("team_incidents", null); }
        }

        /// <summary>
        ///     N:1 TransactionCurrency_Incident
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("TransactionCurrency_Incident")]
        public TransactionCurrency TransactionCurrency_Incident
        {
            get { return GetRelatedEntity<TransactionCurrency>("TransactionCurrency_Incident", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_Incident");
                SetRelatedEntity("TransactionCurrency_Incident", null, value);
                OnPropertyChanged("TransactionCurrency_Incident");
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