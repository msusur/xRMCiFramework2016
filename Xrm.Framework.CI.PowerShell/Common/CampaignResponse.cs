using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Xrm.Framework.CI.Common.Entities
{
    /// <summary>
    ///     Response from an existing or a potential new customer for a campaign.
    /// </summary>
    [DataContract]
    [EntityLogicalName("campaignresponse")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class CampaignResponse : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "campaignresponse";

        public const int EntityTypeCode = 4401;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public CampaignResponse() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the campaign response.
        /// </summary>
        [AttributeLogicalName("activityid")]
        public Guid? ActivityId
        {
            get { return GetAttributeValue<Guid?>("activityid"); }
            set
            {
                OnPropertyChanging("ActivityId");
                SetAttributeValue("activityid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ActivityId");
            }
        }

        [AttributeLogicalName("activityid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ActivityId = value; }
        }

        /// <summary>
        ///     Type of activity.
        /// </summary>
        [AttributeLogicalName("activitytypecode")]
        public string ActivityTypeCode
        {
            get { return GetAttributeValue<string>("activitytypecode"); }
        }

        /// <summary>
        ///     Type the number of minutes spent on this activity. The duration is used in reporting.
        /// </summary>
        [AttributeLogicalName("actualdurationminutes")]
        public int? ActualDurationMinutes
        {
            get { return GetAttributeValue<int?>("actualdurationminutes"); }
            set
            {
                OnPropertyChanging("ActualDurationMinutes");
                SetAttributeValue("actualdurationminutes", value);
                OnPropertyChanged("ActualDurationMinutes");
            }
        }

        /// <summary>
        ///     Enter the date when the campaign response was actually completed.
        /// </summary>
        [AttributeLogicalName("actualend")]
        public DateTime? ActualEnd
        {
            get { return GetAttributeValue<DateTime?>("actualend"); }
            set
            {
                OnPropertyChanging("ActualEnd");
                SetAttributeValue("actualend", value);
                OnPropertyChanged("ActualEnd");
            }
        }

        /// <summary>
        ///     Enter the actual start date and time for the campaign response.
        /// </summary>
        [AttributeLogicalName("actualstart")]
        public DateTime? ActualStart
        {
            get { return GetAttributeValue<DateTime?>("actualstart"); }
            set
            {
                OnPropertyChanging("ActualStart");
                SetAttributeValue("actualstart", value);
                OnPropertyChanged("ActualStart");
            }
        }

        /// <summary>
        ///     Type a category to identify the campaign response type, such as new business development or customer retention, to
        ///     tie the campaign response to a business group or function.
        /// </summary>
        [AttributeLogicalName("category")]
        public string Category
        {
            get { return GetAttributeValue<string>("category"); }
            set
            {
                OnPropertyChanging("Category");
                SetAttributeValue("category", value);
                OnPropertyChanged("Category");
            }
        }

        /// <summary>
        ///     Select how the response was received, such as phone, letter, fax, or email.
        /// </summary>
        [AttributeLogicalName("channeltypecode")]
        public OptionSetValue ChannelTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("channeltypecode"); }
            set
            {
                OnPropertyChanging("ChannelTypeCode");
                SetAttributeValue("channeltypecode", value);
                OnPropertyChanged("ChannelTypeCode");
            }
        }

        /// <summary>
        ///     Type the name of the company if the campaign response was received from a new prospect or customer.
        /// </summary>
        [AttributeLogicalName("companyname")]
        public string CompanyName
        {
            get { return GetAttributeValue<string>("companyname"); }
            set
            {
                OnPropertyChanging("CompanyName");
                SetAttributeValue("companyname", value);
                OnPropertyChanged("CompanyName");
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
        ///     Enter the account, contact, or lead that submitted the campaign response, if it was received from an existing
        ///     prospect or customer.
        /// </summary>
        [AttributeLogicalName("customer")]
        public IEnumerable<ActivityParty> Customer
        {
            get
            {
                var collection = GetAttributeValue<EntityCollection>("customer");
                if (((collection != null)
                     && (collection.Entities != null)))
                {
                    return Enumerable.Cast<ActivityParty>(collection.Entities);
                }
                return null;
            }
            set
            {
                OnPropertyChanging("Customer");
                if ((value == null))
                {
                    SetAttributeValue("customer", value);
                }
                else
                {
                    SetAttributeValue("customer", new EntityCollection(new List<Entity>(value)));
                }
                OnPropertyChanged("Customer");
            }
        }

        /// <summary>
        ///     Type additional information to describe the campaign response, such as key discussion points or objectives.
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
        ///     Type the responder's email address.
        /// </summary>
        [AttributeLogicalName("emailaddress")]
        public string EMailAddress
        {
            get { return GetAttributeValue<string>("emailaddress"); }
            set
            {
                OnPropertyChanging("EMailAddress");
                SetAttributeValue("emailaddress", value);
                OnPropertyChanged("EMailAddress");
            }
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
        ///     Type the responder's fax number.
        /// </summary>
        [AttributeLogicalName("fax")]
        public string Fax
        {
            get { return GetAttributeValue<string>("fax"); }
            set
            {
                OnPropertyChanging("Fax");
                SetAttributeValue("fax", value);
                OnPropertyChanged("Fax");
            }
        }

        /// <summary>
        ///     Type the responder's first name if the campaign response was received from a new prospect or customer.
        /// </summary>
        [AttributeLogicalName("firstname")]
        public string FirstName
        {
            get { return GetAttributeValue<string>("firstname"); }
            set
            {
                OnPropertyChanging("FirstName");
                SetAttributeValue("firstname", value);
                OnPropertyChanged("FirstName");
            }
        }

        /// <summary>
        ///     For system use only.
        /// </summary>
        [AttributeLogicalName("from")]
        public IEnumerable<ActivityParty> From
        {
            get
            {
                var collection = GetAttributeValue<EntityCollection>("from");
                if (((collection != null)
                     && (collection.Entities != null)))
                {
                    return Enumerable.Cast<ActivityParty>(collection.Entities);
                }
                return null;
            }
            set
            {
                OnPropertyChanging("From");
                if ((value == null))
                {
                    SetAttributeValue("from", value);
                }
                else
                {
                    SetAttributeValue("from", new EntityCollection(new List<Entity>(value)));
                }
                OnPropertyChanged("From");
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
        ///     Specifies whether the campaign response was billed as part of resolving a case.
        /// </summary>
        [AttributeLogicalName("isbilled")]
        public bool? IsBilled
        {
            get { return GetAttributeValue<bool?>("isbilled"); }
            set
            {
                OnPropertyChanging("IsBilled");
                SetAttributeValue("isbilled", value);
                OnPropertyChanged("IsBilled");
            }
        }

        /// <summary>
        ///     Information regarding whether the activity is a regular activity type or event type.
        /// </summary>
        [AttributeLogicalName("isregularactivity")]
        public bool? IsRegularActivity
        {
            get { return GetAttributeValue<bool?>("isregularactivity"); }
        }

        /// <summary>
        ///     Specifies whether the campaign response is created by a workflow rule.
        /// </summary>
        [AttributeLogicalName("isworkflowcreated")]
        public bool? IsWorkflowCreated
        {
            get { return GetAttributeValue<bool?>("isworkflowcreated"); }
            set
            {
                OnPropertyChanging("IsWorkflowCreated");
                SetAttributeValue("isworkflowcreated", value);
                OnPropertyChanged("IsWorkflowCreated");
            }
        }

        /// <summary>
        ///     Type the responder's last name if the campaign response was received from a new prospect or customer.
        /// </summary>
        [AttributeLogicalName("lastname")]
        public string LastName
        {
            get { return GetAttributeValue<string>("lastname"); }
            set
            {
                OnPropertyChanging("LastName");
                SetAttributeValue("lastname", value);
                OnPropertyChanged("LastName");
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
        ///     Choose the phone call, email, fax, letter, or appointment activity that led the prospect or customer to respond to
        ///     the campaign.
        /// </summary>
        [AttributeLogicalName("originatingactivityid")]
        public EntityReference OriginatingActivityId
        {
            get { return GetAttributeValue<EntityReference>("originatingactivityid"); }
            set
            {
                OnPropertyChanging("OriginatingActivityId");
                SetAttributeValue("originatingactivityid", value);
                OnPropertyChanged("OriginatingActivityId");
            }
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
        ///     Unique identifier for the business unit that owns the campaign response.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the campaign response.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the campaign response.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Enter the vendor account or contact to capture any third-party used to obtain the campaign response.
        /// </summary>
        [AttributeLogicalName("partner")]
        public IEnumerable<ActivityParty> Partner
        {
            get
            {
                var collection = GetAttributeValue<EntityCollection>("partner");
                if (((collection != null)
                     && (collection.Entities != null)))
                {
                    return Enumerable.Cast<ActivityParty>(collection.Entities);
                }
                return null;
            }
            set
            {
                OnPropertyChanging("Partner");
                if ((value == null))
                {
                    SetAttributeValue("partner", value);
                }
                else
                {
                    SetAttributeValue("partner", new EntityCollection(new List<Entity>(value)));
                }
                OnPropertyChanged("Partner");
            }
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
        ///     Type a promotional code to track sales related to the campaign response or to allow the responder to redeem a
        ///     discount offer.
        /// </summary>
        [AttributeLogicalName("promotioncodename")]
        public string PromotionCodeName
        {
            get { return GetAttributeValue<string>("promotioncodename"); }
            set
            {
                OnPropertyChanging("PromotionCodeName");
                SetAttributeValue("promotioncodename", value);
                OnPropertyChanged("PromotionCodeName");
            }
        }

        /// <summary>
        ///     Enter the date when the campaign response was received.
        /// </summary>
        [AttributeLogicalName("receivedon")]
        public DateTime? ReceivedOn
        {
            get { return GetAttributeValue<DateTime?>("receivedon"); }
            set
            {
                OnPropertyChanging("ReceivedOn");
                SetAttributeValue("receivedon", value);
                OnPropertyChanged("ReceivedOn");
            }
        }

        /// <summary>
        ///     Choose the parent campaign so that the campaign's response rate is tracked correctly.
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
        ///     Select the type of response from the prospect or customer to indicate their interest in the campaign.
        /// </summary>
        [AttributeLogicalName("responsecode")]
        public OptionSetValue ResponseCode
        {
            get { return GetAttributeValue<OptionSetValue>("responsecode"); }
            set
            {
                OnPropertyChanging("ResponseCode");
                SetAttributeValue("responsecode", value);
                OnPropertyChanged("ResponseCode");
            }
        }

        /// <summary>
        ///     Scheduled duration of the campaign response in minutes.
        /// </summary>
        [AttributeLogicalName("scheduleddurationminutes")]
        public int? ScheduledDurationMinutes
        {
            get { return GetAttributeValue<int?>("scheduleddurationminutes"); }
        }

        /// <summary>
        ///     Enter the expected due date and time for the activity to be completed to provide details about the timing of the
        ///     campaign response.
        /// </summary>
        [AttributeLogicalName("scheduledend")]
        public DateTime? ScheduledEnd
        {
            get { return GetAttributeValue<DateTime?>("scheduledend"); }
            set
            {
                OnPropertyChanging("ScheduledEnd");
                SetAttributeValue("scheduledend", value);
                OnPropertyChanged("ScheduledEnd");
            }
        }

        /// <summary>
        ///     Enter the expected start date and time for the activity to provide details about the timing of the campaign
        ///     response.
        /// </summary>
        [AttributeLogicalName("scheduledstart")]
        public DateTime? ScheduledStart
        {
            get { return GetAttributeValue<DateTime?>("scheduledstart"); }
            set
            {
                OnPropertyChanging("ScheduledStart");
                SetAttributeValue("scheduledstart", value);
                OnPropertyChanged("ScheduledStart");
            }
        }

        /// <summary>
        ///     Unique identifier for the associated service.
        /// </summary>
        [AttributeLogicalName("serviceid")]
        public EntityReference ServiceId
        {
            get { return GetAttributeValue<EntityReference>("serviceid"); }
            set
            {
                OnPropertyChanging("ServiceId");
                SetAttributeValue("serviceid", value);
                OnPropertyChanged("ServiceId");
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
        ///     Shows whether the campaign response is open, closed, or canceled. Closed and canceled campaign responses are
        ///     read-only and can't be edited.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public CampaignResponseState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((CampaignResponseState) (Enum.ToObject(typeof (CampaignResponseState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Select the campaign response's status.
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
        ///     Type a subcategory to identify the campaign response type and relate the activity to a specific product, sales
        ///     region, business group, or other function.
        /// </summary>
        [AttributeLogicalName("subcategory")]
        public string Subcategory
        {
            get { return GetAttributeValue<string>("subcategory"); }
            set
            {
                OnPropertyChanging("Subcategory");
                SetAttributeValue("subcategory", value);
                OnPropertyChanged("Subcategory");
            }
        }

        /// <summary>
        ///     Type a short description about the objective or primary topic of the campaign response.
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
        ///     Type the responder's primary phone number.
        /// </summary>
        [AttributeLogicalName("telephone")]
        public string Telephone
        {
            get { return GetAttributeValue<string>("telephone"); }
            set
            {
                OnPropertyChanging("Telephone");
                SetAttributeValue("telephone", value);
                OnPropertyChanged("Telephone");
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
        ///     Version number of the campaign response.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     Type the phonetic spelling of the company name, if specified in Japanese, to make sure the name is pronounced
        ///     correctly in phone calls and other communications.
        /// </summary>
        [AttributeLogicalName("yomicompanyname")]
        public string YomiCompanyName
        {
            get { return GetAttributeValue<string>("yomicompanyname"); }
            set
            {
                OnPropertyChanging("YomiCompanyName");
                SetAttributeValue("yomicompanyname", value);
                OnPropertyChanged("YomiCompanyName");
            }
        }

        /// <summary>
        ///     Type the phonetic spelling of the campaign responder's first name, if specified in Japanese, to make sure the name
        ///     is pronounced correctly in phone calls and other communications.
        /// </summary>
        [AttributeLogicalName("yomifirstname")]
        public string YomiFirstName
        {
            get { return GetAttributeValue<string>("yomifirstname"); }
            set
            {
                OnPropertyChanging("YomiFirstName");
                SetAttributeValue("yomifirstname", value);
                OnPropertyChanged("YomiFirstName");
            }
        }

        /// <summary>
        ///     Type the phonetic spelling of the campaign responder's last name, if specified in Japanese, to make sure the name
        ///     is pronounced correctly in phone calls and other communications.
        /// </summary>
        [AttributeLogicalName("yomilastname")]
        public string YomiLastName
        {
            get { return GetAttributeValue<string>("yomilastname"); }
            set
            {
                OnPropertyChanging("YomiLastName");
                SetAttributeValue("yomilastname", value);
                OnPropertyChanged("YomiLastName");
            }
        }

        /// <summary>
        ///     1:N campaignresponse_activity_parties
        /// </summary>
        [RelationshipSchemaName("campaignresponse_activity_parties")]
        public IEnumerable<ActivityParty> campaignresponse_activity_parties
        {
            get { return GetRelatedEntities<ActivityParty>("campaignresponse_activity_parties", null); }
            set
            {
                OnPropertyChanging("campaignresponse_activity_parties");
                SetRelatedEntities("campaignresponse_activity_parties", null, value);
                OnPropertyChanged("campaignresponse_activity_parties");
            }
        }

        /// <summary>
        ///     1:N CampaignResponse_Annotation
        /// </summary>
        [RelationshipSchemaName("CampaignResponse_Annotation")]
        public IEnumerable<Annotation> CampaignResponse_Annotation
        {
            get { return GetRelatedEntities<Annotation>("CampaignResponse_Annotation", null); }
            set
            {
                OnPropertyChanging("CampaignResponse_Annotation");
                SetRelatedEntities("CampaignResponse_Annotation", null, value);
                OnPropertyChanged("CampaignResponse_Annotation");
            }
        }

        /// <summary>
        ///     1:N CampaignResponse_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("CampaignResponse_AsyncOperations")]
        public IEnumerable<AsyncOperation> CampaignResponse_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("CampaignResponse_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("CampaignResponse_AsyncOperations");
                SetRelatedEntities("CampaignResponse_AsyncOperations", null, value);
                OnPropertyChanged("CampaignResponse_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N CampaignResponse_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("CampaignResponse_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> CampaignResponse_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("CampaignResponse_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("CampaignResponse_BulkDeleteFailures");
                SetRelatedEntities("CampaignResponse_BulkDeleteFailures", null, value);
                OnPropertyChanged("CampaignResponse_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N CampaignResponse_DuplicateBaseRecord
        /// </summary>
        [RelationshipSchemaName("CampaignResponse_DuplicateBaseRecord")]
        public IEnumerable<DuplicateRecord> CampaignResponse_DuplicateBaseRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("CampaignResponse_DuplicateBaseRecord", null); }
            set
            {
                OnPropertyChanging("CampaignResponse_DuplicateBaseRecord");
                SetRelatedEntities("CampaignResponse_DuplicateBaseRecord", null, value);
                OnPropertyChanged("CampaignResponse_DuplicateBaseRecord");
            }
        }

        /// <summary>
        ///     1:N CampaignResponse_DuplicateMatchingRecord
        /// </summary>
        [RelationshipSchemaName("CampaignResponse_DuplicateMatchingRecord")]
        public IEnumerable<DuplicateRecord> CampaignResponse_DuplicateMatchingRecord
        {
            get { return GetRelatedEntities<DuplicateRecord>("CampaignResponse_DuplicateMatchingRecord", null); }
            set
            {
                OnPropertyChanging("CampaignResponse_DuplicateMatchingRecord");
                SetRelatedEntities("CampaignResponse_DuplicateMatchingRecord", null, value);
                OnPropertyChanged("CampaignResponse_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        ///     1:N CampaignResponse_Lead
        /// </summary>
        [RelationshipSchemaName("CampaignResponse_Lead")]
        public IEnumerable<Lead> CampaignResponse_Lead
        {
            get { return GetRelatedEntities<Lead>("CampaignResponse_Lead", null); }
            set
            {
                OnPropertyChanging("CampaignResponse_Lead");
                SetRelatedEntities("CampaignResponse_Lead", null, value);
                OnPropertyChanged("CampaignResponse_Lead");
            }
        }

        /// <summary>
        ///     1:N campaignresponse_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("campaignresponse_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> campaignresponse_principalobjectattributeaccess
        {
            get
            {
                return
                    GetRelatedEntities<PrincipalObjectAttributeAccess>(
                        "campaignresponse_principalobjectattributeaccess", null);
            }
            set
            {
                OnPropertyChanging("campaignresponse_principalobjectattributeaccess");
                SetRelatedEntities("campaignresponse_principalobjectattributeaccess", null, value);
                OnPropertyChanged("campaignresponse_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N CampaignResponse_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("CampaignResponse_ProcessSessions")]
        public IEnumerable<ProcessSession> CampaignResponse_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("CampaignResponse_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("CampaignResponse_ProcessSessions");
                SetRelatedEntities("CampaignResponse_ProcessSessions", null, value);
                OnPropertyChanged("CampaignResponse_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N CampaignResponse_QueueItem
        /// </summary>
        [RelationshipSchemaName("CampaignResponse_QueueItem")]
        public IEnumerable<QueueItem> CampaignResponse_QueueItem
        {
            get { return GetRelatedEntities<QueueItem>("CampaignResponse_QueueItem", null); }
            set
            {
                OnPropertyChanging("CampaignResponse_QueueItem");
                SetRelatedEntities("CampaignResponse_QueueItem", null, value);
                OnPropertyChanged("CampaignResponse_QueueItem");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_campaignresponse
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_campaignresponse")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_campaignresponse
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_campaignresponse", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_campaignresponse");
                SetRelatedEntities("userentityinstancedata_campaignresponse", null, value);
                OnPropertyChanged("userentityinstancedata_campaignresponse");
            }
        }

        /// <summary>
        ///     N:1 activity_campaignresponse
        /// </summary>
        [AttributeLogicalName("originatingactivityid")]
        [RelationshipSchemaName("activity_campaignresponse")]
        public ActivityPointer activity_campaignresponse
        {
            get { return GetRelatedEntity<ActivityPointer>("activity_campaignresponse", null); }
            set
            {
                OnPropertyChanging("activity_campaignresponse");
                SetRelatedEntity("activity_campaignresponse", null, value);
                OnPropertyChanged("activity_campaignresponse");
            }
        }

        /// <summary>
        ///     N:1 activity_pointer_campaignresponse
        /// </summary>
        [AttributeLogicalName("activityid")]
        [RelationshipSchemaName("activity_pointer_campaignresponse")]
        public ActivityPointer activity_pointer_campaignresponse
        {
            get { return GetRelatedEntity<ActivityPointer>("activity_pointer_campaignresponse", null); }
            set
            {
                OnPropertyChanging("activity_pointer_campaignresponse");
                SetRelatedEntity("activity_pointer_campaignresponse", null, value);
                OnPropertyChanged("activity_pointer_campaignresponse");
            }
        }

        /// <summary>
        ///     N:1 appointment_campaignresponse
        /// </summary>
        [AttributeLogicalName("originatingactivityid")]
        [RelationshipSchemaName("appointment_campaignresponse")]
        public Appointment appointment_campaignresponse
        {
            get { return GetRelatedEntity<Appointment>("appointment_campaignresponse", null); }
            set
            {
                OnPropertyChanging("appointment_campaignresponse");
                SetRelatedEntity("appointment_campaignresponse", null, value);
                OnPropertyChanged("appointment_campaignresponse");
            }
        }

        /// <summary>
        ///     N:1 BulkOperation_CampaignResponse
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("BulkOperation_CampaignResponse")]
        public BulkOperation BulkOperation_CampaignResponse
        {
            get { return GetRelatedEntity<BulkOperation>("BulkOperation_CampaignResponse", null); }
            set
            {
                OnPropertyChanging("BulkOperation_CampaignResponse");
                SetRelatedEntity("BulkOperation_CampaignResponse", null, value);
                OnPropertyChanged("BulkOperation_CampaignResponse");
            }
        }

        /// <summary>
        ///     N:1 business_unit_campaignresponse_activities
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_campaignresponse_activities")]
        public BusinessUnit business_unit_campaignresponse_activities
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_campaignresponse_activities", null); }
        }

        /// <summary>
        ///     N:1 Campaign_CampaignResponses
        /// </summary>
        [AttributeLogicalName("regardingobjectid")]
        [RelationshipSchemaName("Campaign_CampaignResponses")]
        public Campaign Campaign_CampaignResponses
        {
            get { return GetRelatedEntity<Campaign>("Campaign_CampaignResponses", null); }
            set
            {
                OnPropertyChanging("Campaign_CampaignResponses");
                SetRelatedEntity("Campaign_CampaignResponses", null, value);
                OnPropertyChanged("Campaign_CampaignResponses");
            }
        }

        /// <summary>
        ///     N:1 email_campaignresponse
        /// </summary>
        [AttributeLogicalName("originatingactivityid")]
        [RelationshipSchemaName("email_campaignresponse")]
        public Email email_campaignresponse
        {
            get { return GetRelatedEntity<Email>("email_campaignresponse", null); }
            set
            {
                OnPropertyChanging("email_campaignresponse");
                SetRelatedEntity("email_campaignresponse", null, value);
                OnPropertyChanged("email_campaignresponse");
            }
        }

        /// <summary>
        ///     N:1 fax_campaignresponse
        /// </summary>
        [AttributeLogicalName("originatingactivityid")]
        [RelationshipSchemaName("fax_campaignresponse")]
        public Fax fax_campaignresponse
        {
            get { return GetRelatedEntity<Fax>("fax_campaignresponse", null); }
            set
            {
                OnPropertyChanging("fax_campaignresponse");
                SetRelatedEntity("fax_campaignresponse", null, value);
                OnPropertyChanged("fax_campaignresponse");
            }
        }

        /// <summary>
        ///     N:1 letter_campaignresponse
        /// </summary>
        [AttributeLogicalName("originatingactivityid")]
        [RelationshipSchemaName("letter_campaignresponse")]
        public Letter letter_campaignresponse
        {
            get { return GetRelatedEntity<Letter>("letter_campaignresponse", null); }
            set
            {
                OnPropertyChanging("letter_campaignresponse");
                SetRelatedEntity("letter_campaignresponse", null, value);
                OnPropertyChanged("letter_campaignresponse");
            }
        }

        /// <summary>
        ///     N:1 lk_campaignresponse_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_campaignresponse_createdby")]
        public SystemUser lk_campaignresponse_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_campaignresponse_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_campaignresponse_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_campaignresponse_createdonbehalfby")]
        public SystemUser lk_campaignresponse_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_campaignresponse_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_campaignresponse_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_campaignresponse_modifiedby")]
        public SystemUser lk_campaignresponse_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_campaignresponse_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_campaignresponse_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_campaignresponse_modifiedonbehalfby")]
        public SystemUser lk_campaignresponse_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_campaignresponse_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 phonecall_campaignresponse
        /// </summary>
        [AttributeLogicalName("originatingactivityid")]
        [RelationshipSchemaName("phonecall_campaignresponse")]
        public PhoneCall phonecall_campaignresponse
        {
            get { return GetRelatedEntity<PhoneCall>("phonecall_campaignresponse", null); }
            set
            {
                OnPropertyChanging("phonecall_campaignresponse");
                SetRelatedEntity("phonecall_campaignresponse", null, value);
                OnPropertyChanged("phonecall_campaignresponse");
            }
        }

        /// <summary>
        ///     N:1 processstage_campaignresponses
        /// </summary>
        [AttributeLogicalName("stageid")]
        [RelationshipSchemaName("processstage_campaignresponses")]
        public ProcessStage processstage_campaignresponses
        {
            get { return GetRelatedEntity<ProcessStage>("processstage_campaignresponses", null); }
            set
            {
                OnPropertyChanging("processstage_campaignresponses");
                SetRelatedEntity("processstage_campaignresponses", null, value);
                OnPropertyChanged("processstage_campaignresponses");
            }
        }

        /// <summary>
        ///     N:1 recurringappointmentmaster_campaignresponse
        /// </summary>
        [AttributeLogicalName("originatingactivityid")]
        [RelationshipSchemaName("recurringappointmentmaster_campaignresponse")]
        public RecurringAppointmentMaster recurringappointmentmaster_campaignresponse
        {
            get
            {
                return GetRelatedEntity<RecurringAppointmentMaster>("recurringappointmentmaster_campaignresponse", null);
            }
            set
            {
                OnPropertyChanging("recurringappointmentmaster_campaignresponse");
                SetRelatedEntity("recurringappointmentmaster_campaignresponse", null, value);
                OnPropertyChanged("recurringappointmentmaster_campaignresponse");
            }
        }

        /// <summary>
        ///     N:1 team_campaignresponse
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_campaignresponse")]
        public Team team_campaignresponse
        {
            get { return GetRelatedEntity<Team>("team_campaignresponse", null); }
        }

        /// <summary>
        ///     N:1 TransactionCurrency_CampaignResponse
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("TransactionCurrency_CampaignResponse")]
        public TransactionCurrency TransactionCurrency_CampaignResponse
        {
            get { return GetRelatedEntity<TransactionCurrency>("TransactionCurrency_CampaignResponse", null); }
            set
            {
                OnPropertyChanging("TransactionCurrency_CampaignResponse");
                SetRelatedEntity("TransactionCurrency_CampaignResponse", null, value);
                OnPropertyChanged("TransactionCurrency_CampaignResponse");
            }
        }

        /// <summary>
        ///     N:1 user_campaignresponse
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_campaignresponse")]
        public SystemUser user_campaignresponse
        {
            get { return GetRelatedEntity<SystemUser>("user_campaignresponse", null); }
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