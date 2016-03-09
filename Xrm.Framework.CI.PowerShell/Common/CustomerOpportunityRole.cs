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
    ///     Relationship between an account or contact and an opportunity.
    /// </summary>
    [DataContract]
    [EntityLogicalName("customeropportunityrole")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class CustomerOpportunityRole : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "customeropportunityrole";

        public const int EntityTypeCode = 4503;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public CustomerOpportunityRole() :
            base(EntityLogicalName)
        {
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
        ///     Select the account or contact associated to the opportunity, such as a strategic partner, third-party vendor, or
        ///     key decision maker.
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
        ///     Unique identifier of the opportunity relationship.
        /// </summary>
        [AttributeLogicalName("customeropportunityroleid")]
        public Guid? CustomerOpportunityRoleId
        {
            get { return GetAttributeValue<Guid?>("customeropportunityroleid"); }
            set
            {
                OnPropertyChanging("CustomerOpportunityRoleId");
                SetAttributeValue("customeropportunityroleid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("CustomerOpportunityRoleId");
            }
        }

        [AttributeLogicalName("customeropportunityroleid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { CustomerOpportunityRoleId = value; }
        }

        /// <summary>
        ///     Type additional information to describe the opportunity relationship, such as the length or quality of the
        ///     relationship.
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
        ///     Choose the opportunity that the specified account or contact is related to. The opportunity relationship will be
        ///     displayed in the Relationships view on the selected opportunity.
        /// </summary>
        [AttributeLogicalName("opportunityid")]
        public EntityReference OpportunityId
        {
            get { return GetAttributeValue<EntityReference>("opportunityid"); }
            set
            {
                OnPropertyChanging("OpportunityId");
                SetAttributeValue("opportunityid", value);
                OnPropertyChanged("OpportunityId");
            }
        }

        /// <summary>
        ///     Choose the role or nature of the relationship that the customer has with the opportunity. The field is read-only
        ///     until a customer has been selected. Administrators can configure role values under Business Management in the
        ///     Settings area.
        /// </summary>
        [AttributeLogicalName("opportunityroleid")]
        public EntityReference OpportunityRoleId
        {
            get { return GetAttributeValue<EntityReference>("opportunityroleid"); }
            set
            {
                OnPropertyChanging("OpportunityRoleId");
                SetAttributeValue("opportunityroleid", value);
                OnPropertyChanged("OpportunityRoleId");
            }
        }

        /// <summary>
        ///     Status of the opportunity.
        /// </summary>
        [AttributeLogicalName("opportunitystatecode")]
        public int? OpportunityStateCode
        {
            get { return GetAttributeValue<int?>("opportunitystatecode"); }
        }

        /// <summary>
        ///     Reason for the status of the opportunity.
        /// </summary>
        [AttributeLogicalName("opportunitystatuscode")]
        public int? OpportunityStatusCode
        {
            get { return GetAttributeValue<int?>("opportunitystatuscode"); }
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
        ///     Unique identifier of the user or team who owns the customer opportunity role.
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
        ///     Unique identifier for the business unit that owns the customer opportunity role.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the customer opportunity role.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the customer opportunity role.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Version number of the customer opportunity role.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N CustomerOpportunityRole_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("CustomerOpportunityRole_AsyncOperations")]
        public IEnumerable<AsyncOperation> CustomerOpportunityRole_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("CustomerOpportunityRole_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("CustomerOpportunityRole_AsyncOperations");
                SetRelatedEntities("CustomerOpportunityRole_AsyncOperations", null, value);
                OnPropertyChanged("CustomerOpportunityRole_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N CustomerOpportunityRole_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("CustomerOpportunityRole_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> CustomerOpportunityRole_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("CustomerOpportunityRole_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("CustomerOpportunityRole_BulkDeleteFailures");
                SetRelatedEntities("CustomerOpportunityRole_BulkDeleteFailures", null, value);
                OnPropertyChanged("CustomerOpportunityRole_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N CustomerOpportunityRole_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("CustomerOpportunityRole_ProcessSessions")]
        public IEnumerable<ProcessSession> CustomerOpportunityRole_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("CustomerOpportunityRole_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("CustomerOpportunityRole_ProcessSessions");
                SetRelatedEntities("CustomerOpportunityRole_ProcessSessions", null, value);
                OnPropertyChanged("CustomerOpportunityRole_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_customeropportunityrole
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_customeropportunityrole")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_customeropportunityrole
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_customeropportunityrole", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_customeropportunityrole");
                SetRelatedEntities("userentityinstancedata_customeropportunityrole", null, value);
                OnPropertyChanged("userentityinstancedata_customeropportunityrole");
            }
        }

        /// <summary>
        ///     N:1 account_customer_opportunity_roles
        /// </summary>
        [AttributeLogicalName("customerid")]
        [RelationshipSchemaName("account_customer_opportunity_roles")]
        public Account account_customer_opportunity_roles
        {
            get { return GetRelatedEntity<Account>("account_customer_opportunity_roles", null); }
            set
            {
                OnPropertyChanging("account_customer_opportunity_roles");
                SetRelatedEntity("account_customer_opportunity_roles", null, value);
                OnPropertyChanged("account_customer_opportunity_roles");
            }
        }

        /// <summary>
        ///     N:1 business_customer_opportunity_roles
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_customer_opportunity_roles")]
        public BusinessUnit business_customer_opportunity_roles
        {
            get { return GetRelatedEntity<BusinessUnit>("business_customer_opportunity_roles", null); }
        }

        /// <summary>
        ///     N:1 contact_customer_opportunity_roles
        /// </summary>
        [AttributeLogicalName("customerid")]
        [RelationshipSchemaName("contact_customer_opportunity_roles")]
        public Contact contact_customer_opportunity_roles
        {
            get { return GetRelatedEntity<Contact>("contact_customer_opportunity_roles", null); }
            set
            {
                OnPropertyChanging("contact_customer_opportunity_roles");
                SetRelatedEntity("contact_customer_opportunity_roles", null, value);
                OnPropertyChanged("contact_customer_opportunity_roles");
            }
        }

        /// <summary>
        ///     N:1 lk_customeropportunityrole_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_customeropportunityrole_createdby")]
        public SystemUser lk_customeropportunityrole_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_customeropportunityrole_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_customeropportunityrole_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_customeropportunityrole_createdonbehalfby")]
        public SystemUser lk_customeropportunityrole_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_customeropportunityrole_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_customeropportunityrole_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_customeropportunityrole_modifiedby")]
        public SystemUser lk_customeropportunityrole_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_customeropportunityrole_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_customeropportunityrole_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_customeropportunityrole_modifiedonbehalfby")]
        public SystemUser lk_customeropportunityrole_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_customeropportunityrole_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 opportunity_customer_opportunity_roles
        /// </summary>
        [AttributeLogicalName("opportunityid")]
        [RelationshipSchemaName("opportunity_customer_opportunity_roles")]
        public Opportunity opportunity_customer_opportunity_roles
        {
            get { return GetRelatedEntity<Opportunity>("opportunity_customer_opportunity_roles", null); }
            set
            {
                OnPropertyChanging("opportunity_customer_opportunity_roles");
                SetRelatedEntity("opportunity_customer_opportunity_roles", null, value);
                OnPropertyChanged("opportunity_customer_opportunity_roles");
            }
        }

        /// <summary>
        ///     N:1 relationship_role_customer_opportunity_roles
        /// </summary>
        [AttributeLogicalName("opportunityroleid")]
        [RelationshipSchemaName("relationship_role_customer_opportunity_roles")]
        public RelationshipRole relationship_role_customer_opportunity_roles
        {
            get { return GetRelatedEntity<RelationshipRole>("relationship_role_customer_opportunity_roles", null); }
            set
            {
                OnPropertyChanging("relationship_role_customer_opportunity_roles");
                SetRelatedEntity("relationship_role_customer_opportunity_roles", null, value);
                OnPropertyChanged("relationship_role_customer_opportunity_roles");
            }
        }

        /// <summary>
        ///     N:1 team_customer_opportunity_roles
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_customer_opportunity_roles")]
        public Team team_customer_opportunity_roles
        {
            get { return GetRelatedEntity<Team>("team_customer_opportunity_roles", null); }
        }

        /// <summary>
        ///     N:1 user_customer_opportunity_roles
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_customer_opportunity_roles")]
        public SystemUser user_customer_opportunity_roles
        {
            get { return GetRelatedEntity<SystemUser>("user_customer_opportunity_roles", null); }
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