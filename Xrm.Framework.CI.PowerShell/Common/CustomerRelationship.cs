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
    ///     Relationship between a customer and a partner in which either can be an account or contact.
    /// </summary>
    [DataContract]
    [EntityLogicalName("customerrelationship")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class CustomerRelationship : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "customerrelationship";

        public const int EntityTypeCode = 4502;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public CustomerRelationship() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the converse relationship of the customer relationship.
        /// </summary>
        [AttributeLogicalName("converserelationshipid")]
        public EntityReference ConverseRelationshipId
        {
            get { return GetAttributeValue<EntityReference>("converserelationshipid"); }
            set
            {
                OnPropertyChanging("ConverseRelationshipId");
                SetAttributeValue("converserelationshipid", value);
                OnPropertyChanged("ConverseRelationshipId");
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
        ///     Shows the date and time when the customer relationship was created. The date and time are displayed in the time
        ///     zone selected in Microsoft Dynamics CRM options.
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
        ///     Select the primary account or contact involved in the customer relationship.
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
        ///     Unique identifier of the customer relationship.
        /// </summary>
        [AttributeLogicalName("customerrelationshipid")]
        public Guid? CustomerRelationshipId
        {
            get { return GetAttributeValue<Guid?>("customerrelationshipid"); }
            set
            {
                OnPropertyChanging("CustomerRelationshipId");
                SetAttributeValue("customerrelationshipid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("CustomerRelationshipId");
            }
        }

        [AttributeLogicalName("customerrelationshipid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { CustomerRelationshipId = value; }
        }

        /// <summary>
        ///     Type additional information about the primary party's role in the customer relationship, such as the length or
        ///     quality of the relationship.
        /// </summary>
        [AttributeLogicalName("customerroledescription")]
        public string CustomerRoleDescription
        {
            get { return GetAttributeValue<string>("customerroledescription"); }
            set
            {
                OnPropertyChanging("CustomerRoleDescription");
                SetAttributeValue("customerroledescription", value);
                OnPropertyChanged("CustomerRoleDescription");
            }
        }

        /// <summary>
        ///     Choose the primary party's role or nature of the relationship the customer has with the second party. The field is
        ///     read-only until both parties have been selected. Administrators can configure role values under Business Management
        ///     in the Settings area.
        /// </summary>
        [AttributeLogicalName("customerroleid")]
        public EntityReference CustomerRoleId
        {
            get { return GetAttributeValue<EntityReference>("customerroleid"); }
            set
            {
                OnPropertyChanging("CustomerRoleId");
                SetAttributeValue("customerroleid", value);
                OnPropertyChanged("CustomerRoleId");
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
        ///     Shows who created the record on behalf of another user.
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
        ///     Unique identifier of the business unit that owns the customer relationship.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns the customer relationship.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns the customer relationship.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Select the secondary account or contact involved in the customer relationship.
        /// </summary>
        [AttributeLogicalName("partnerid")]
        public EntityReference PartnerId
        {
            get { return GetAttributeValue<EntityReference>("partnerid"); }
            set
            {
                OnPropertyChanging("PartnerId");
                SetAttributeValue("partnerid", value);
                OnPropertyChanged("PartnerId");
            }
        }

        /// <summary>
        ///     Type additional information about the secondary party's role in the customer relationship, such as the length or
        ///     quality of the relationship.
        /// </summary>
        [AttributeLogicalName("partnerroledescription")]
        public string PartnerRoleDescription
        {
            get { return GetAttributeValue<string>("partnerroledescription"); }
            set
            {
                OnPropertyChanging("PartnerRoleDescription");
                SetAttributeValue("partnerroledescription", value);
                OnPropertyChanged("PartnerRoleDescription");
            }
        }

        /// <summary>
        ///     Choose the secondary party's role or nature of the relationship the customer has with the primary party. The field
        ///     is read-only until both parties have been selected. Administrators can configure role values under Business
        ///     Management in the Settings area.
        /// </summary>
        [AttributeLogicalName("partnerroleid")]
        public EntityReference PartnerRoleId
        {
            get { return GetAttributeValue<EntityReference>("partnerroleid"); }
            set
            {
                OnPropertyChanging("PartnerRoleId");
                SetAttributeValue("partnerroleid", value);
                OnPropertyChanged("PartnerRoleId");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N customer_relationship_converse_relationship
        /// </summary>
        [RelationshipSchemaName("customer_relationship_converse_relationship", EntityRole.Referenced)]
        public IEnumerable<CustomerRelationship> Referencedcustomer_relationship_converse_relationship
        {
            get
            {
                return GetRelatedEntities<CustomerRelationship>("customer_relationship_converse_relationship",
                    EntityRole.Referenced);
            }
            set
            {
                OnPropertyChanging("Referencedcustomer_relationship_converse_relationship");
                SetRelatedEntities("customer_relationship_converse_relationship", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedcustomer_relationship_converse_relationship");
            }
        }

        /// <summary>
        ///     1:N CustomerRelationship_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("CustomerRelationship_AsyncOperations")]
        public IEnumerable<AsyncOperation> CustomerRelationship_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("CustomerRelationship_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("CustomerRelationship_AsyncOperations");
                SetRelatedEntities("CustomerRelationship_AsyncOperations", null, value);
                OnPropertyChanged("CustomerRelationship_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N CustomerRelationship_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("CustomerRelationship_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> CustomerRelationship_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("CustomerRelationship_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("CustomerRelationship_BulkDeleteFailures");
                SetRelatedEntities("CustomerRelationship_BulkDeleteFailures", null, value);
                OnPropertyChanged("CustomerRelationship_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N CustomerRelationship_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("CustomerRelationship_ProcessSessions")]
        public IEnumerable<ProcessSession> CustomerRelationship_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("CustomerRelationship_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("CustomerRelationship_ProcessSessions");
                SetRelatedEntities("CustomerRelationship_ProcessSessions", null, value);
                OnPropertyChanged("CustomerRelationship_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_customerrelationship
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_customerrelationship")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_customerrelationship
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_customerrelationship", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_customerrelationship");
                SetRelatedEntities("userentityinstancedata_customerrelationship", null, value);
                OnPropertyChanged("userentityinstancedata_customerrelationship");
            }
        }

        /// <summary>
        ///     N:1 account_customer_relationship_customer
        /// </summary>
        [AttributeLogicalName("customerid")]
        [RelationshipSchemaName("account_customer_relationship_customer")]
        public Account account_customer_relationship_customer
        {
            get { return GetRelatedEntity<Account>("account_customer_relationship_customer", null); }
            set
            {
                OnPropertyChanging("account_customer_relationship_customer");
                SetRelatedEntity("account_customer_relationship_customer", null, value);
                OnPropertyChanged("account_customer_relationship_customer");
            }
        }

        /// <summary>
        ///     N:1 account_customer_relationship_partner
        /// </summary>
        [AttributeLogicalName("partnerid")]
        [RelationshipSchemaName("account_customer_relationship_partner")]
        public Account account_customer_relationship_partner
        {
            get { return GetRelatedEntity<Account>("account_customer_relationship_partner", null); }
            set
            {
                OnPropertyChanging("account_customer_relationship_partner");
                SetRelatedEntity("account_customer_relationship_partner", null, value);
                OnPropertyChanged("account_customer_relationship_partner");
            }
        }

        /// <summary>
        ///     N:1 business_unit_customer_relationship
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_customer_relationship")]
        public BusinessUnit business_unit_customer_relationship
        {
            get { return GetRelatedEntity<BusinessUnit>("business_unit_customer_relationship", null); }
        }

        /// <summary>
        ///     N:1 contact_customer_relationship_customer
        /// </summary>
        [AttributeLogicalName("customerid")]
        [RelationshipSchemaName("contact_customer_relationship_customer")]
        public Contact contact_customer_relationship_customer
        {
            get { return GetRelatedEntity<Contact>("contact_customer_relationship_customer", null); }
            set
            {
                OnPropertyChanging("contact_customer_relationship_customer");
                SetRelatedEntity("contact_customer_relationship_customer", null, value);
                OnPropertyChanged("contact_customer_relationship_customer");
            }
        }

        /// <summary>
        ///     N:1 contact_customer_relationship_partner
        /// </summary>
        [AttributeLogicalName("partnerid")]
        [RelationshipSchemaName("contact_customer_relationship_partner")]
        public Contact contact_customer_relationship_partner
        {
            get { return GetRelatedEntity<Contact>("contact_customer_relationship_partner", null); }
            set
            {
                OnPropertyChanging("contact_customer_relationship_partner");
                SetRelatedEntity("contact_customer_relationship_partner", null, value);
                OnPropertyChanged("contact_customer_relationship_partner");
            }
        }

        /// <summary>
        ///     N:1 createdby_customer_relationship
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("createdby_customer_relationship")]
        public SystemUser createdby_customer_relationship
        {
            get { return GetRelatedEntity<SystemUser>("createdby_customer_relationship", null); }
        }

        /// <summary>
        ///     N:1 createdonbehalfby_customer_relationship
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("createdonbehalfby_customer_relationship")]
        public SystemUser createdonbehalfby_customer_relationship
        {
            get { return GetRelatedEntity<SystemUser>("createdonbehalfby_customer_relationship", null); }
        }

        /// <summary>
        ///     N:1 customer_relationship_converse_relationship
        /// </summary>
        [AttributeLogicalName("converserelationshipid")]
        [RelationshipSchemaName("customer_relationship_converse_relationship", EntityRole.Referencing)]
        public CustomerRelationship Referencingcustomer_relationship_converse_relationship
        {
            get
            {
                return GetRelatedEntity<CustomerRelationship>("customer_relationship_converse_relationship",
                    EntityRole.Referencing);
            }
            set
            {
                OnPropertyChanging("Referencingcustomer_relationship_converse_relationship");
                SetRelatedEntity("customer_relationship_converse_relationship", EntityRole.Referencing, value);
                OnPropertyChanged("Referencingcustomer_relationship_converse_relationship");
            }
        }

        /// <summary>
        ///     N:1 modifiedby_customer_relationship
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("modifiedby_customer_relationship")]
        public SystemUser modifiedby_customer_relationship
        {
            get { return GetRelatedEntity<SystemUser>("modifiedby_customer_relationship", null); }
        }

        /// <summary>
        ///     N:1 modifiedonbehalfby_customer_relationship
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("modifiedonbehalfby_customer_relationship")]
        public SystemUser modifiedonbehalfby_customer_relationship
        {
            get { return GetRelatedEntity<SystemUser>("modifiedonbehalfby_customer_relationship", null); }
        }

        /// <summary>
        ///     N:1 relationship_role_customer_role
        /// </summary>
        [AttributeLogicalName("customerroleid")]
        [RelationshipSchemaName("relationship_role_customer_role")]
        public RelationshipRole relationship_role_customer_role
        {
            get { return GetRelatedEntity<RelationshipRole>("relationship_role_customer_role", null); }
            set
            {
                OnPropertyChanging("relationship_role_customer_role");
                SetRelatedEntity("relationship_role_customer_role", null, value);
                OnPropertyChanged("relationship_role_customer_role");
            }
        }

        /// <summary>
        ///     N:1 relationship_role_partner_role
        /// </summary>
        [AttributeLogicalName("partnerroleid")]
        [RelationshipSchemaName("relationship_role_partner_role")]
        public RelationshipRole relationship_role_partner_role
        {
            get { return GetRelatedEntity<RelationshipRole>("relationship_role_partner_role", null); }
            set
            {
                OnPropertyChanging("relationship_role_partner_role");
                SetRelatedEntity("relationship_role_partner_role", null, value);
                OnPropertyChanged("relationship_role_partner_role");
            }
        }

        /// <summary>
        ///     N:1 team_customer_relationship
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_customer_relationship")]
        public Team team_customer_relationship
        {
            get { return GetRelatedEntity<Team>("team_customer_relationship", null); }
        }

        /// <summary>
        ///     N:1 user_customer_relationship
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_customer_relationship")]
        public SystemUser user_customer_relationship
        {
            get { return GetRelatedEntity<SystemUser>("user_customer_relationship", null); }
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