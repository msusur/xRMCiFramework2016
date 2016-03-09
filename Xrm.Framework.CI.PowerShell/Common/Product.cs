using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Xrm.Framework.CI.PowerShell.Common;

namespace Xrm.Framework.CI.Common.Entities
{
    /// <summary>
    ///     Information about products and their pricing information.
    /// </summary>
    [DataContract]
    [EntityLogicalName("product")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class Product : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "product";

        public const int EntityTypeCode = 1024;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public Product() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the user who created the product.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the product was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the product.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Current cost for the product item. Used in price calculations.
        /// </summary>
        [AttributeLogicalName("currentcost")]
        public Money CurrentCost
        {
            get { return GetAttributeValue<Money>("currentcost"); }
            set
            {
                OnPropertyChanging("CurrentCost");
                SetAttributeValue("currentcost", value);
                OnPropertyChanged("CurrentCost");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the current cost for the product item.
        /// </summary>
        [AttributeLogicalName("currentcost_base")]
        public Money CurrentCost_Base
        {
            get { return GetAttributeValue<Money>("currentcost_base"); }
        }

        /// <summary>
        ///     Default unit for the product.
        /// </summary>
        [AttributeLogicalName("defaultuomid")]
        public EntityReference DefaultUoMId
        {
            get { return GetAttributeValue<EntityReference>("defaultuomid"); }
            set
            {
                OnPropertyChanging("DefaultUoMId");
                SetAttributeValue("defaultuomid", value);
                OnPropertyChanged("DefaultUoMId");
            }
        }

        /// <summary>
        ///     Default unit group for the product.
        /// </summary>
        [AttributeLogicalName("defaultuomscheduleid")]
        public EntityReference DefaultUoMScheduleId
        {
            get { return GetAttributeValue<EntityReference>("defaultuomscheduleid"); }
            set
            {
                OnPropertyChanging("DefaultUoMScheduleId");
                SetAttributeValue("defaultuomscheduleid", value);
                OnPropertyChanged("DefaultUoMScheduleId");
            }
        }

        /// <summary>
        ///     Description of the product.
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
        ///     Shows the default image for the record.
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
        ///     Exchange rate for the currency associated with the product with respect to the base currency.
        /// </summary>
        [AttributeLogicalName("exchangerate")]
        public decimal? ExchangeRate
        {
            get { return GetAttributeValue<decimal?>("exchangerate"); }
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
        ///     Information that specifies whether the product is a kit.
        /// </summary>
        [AttributeLogicalName("iskit")]
        public bool? IsKit
        {
            get { return GetAttributeValue<bool?>("iskit"); }
            set
            {
                OnPropertyChanging("IsKit");
                SetAttributeValue("iskit", value);
                OnPropertyChanged("IsKit");
            }
        }

        /// <summary>
        ///     Information about whether the product is a stock item.
        /// </summary>
        [AttributeLogicalName("isstockitem")]
        public bool? IsStockItem
        {
            get { return GetAttributeValue<bool?>("isstockitem"); }
            set
            {
                OnPropertyChanging("IsStockItem");
                SetAttributeValue("isstockitem", value);
                OnPropertyChanged("IsStockItem");
            }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the product.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the product was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who last modified the product.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Name of the product.
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
        ///     Unique identifier of the organization associated with the product.
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
        ///     List price of the product.
        /// </summary>
        [AttributeLogicalName("price")]
        public Money Price
        {
            get { return GetAttributeValue<Money>("price"); }
            set
            {
                OnPropertyChanging("Price");
                SetAttributeValue("price", value);
                OnPropertyChanged("Price");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the list price of the product
        /// </summary>
        [AttributeLogicalName("price_base")]
        public Money Price_Base
        {
            get { return GetAttributeValue<Money>("price_base"); }
        }

        /// <summary>
        ///     Unique identifier of the price list associated with the product.
        /// </summary>
        [AttributeLogicalName("pricelevelid")]
        public EntityReference PriceLevelId
        {
            get { return GetAttributeValue<EntityReference>("pricelevelid"); }
            set
            {
                OnPropertyChanging("PriceLevelId");
                SetAttributeValue("pricelevelid", value);
                OnPropertyChanged("PriceLevelId");
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
        ///     Unique identifier of the product.
        /// </summary>
        [AttributeLogicalName("productid")]
        public Guid? ProductId
        {
            get { return GetAttributeValue<Guid?>("productid"); }
            set
            {
                OnPropertyChanging("ProductId");
                SetAttributeValue("productid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("ProductId");
            }
        }

        [AttributeLogicalName("productid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { ProductId = value; }
        }

        /// <summary>
        ///     User-defined product number.
        /// </summary>
        [AttributeLogicalName("productnumber")]
        public string ProductNumber
        {
            get { return GetAttributeValue<string>("productnumber"); }
            set
            {
                OnPropertyChanging("ProductNumber");
                SetAttributeValue("productnumber", value);
                OnPropertyChanged("ProductNumber");
            }
        }

        /// <summary>
        ///     Type of product.
        /// </summary>
        [AttributeLogicalName("producttypecode")]
        public OptionSetValue ProductTypeCode
        {
            get { return GetAttributeValue<OptionSetValue>("producttypecode"); }
            set
            {
                OnPropertyChanging("ProductTypeCode");
                SetAttributeValue("producttypecode", value);
                OnPropertyChanged("ProductTypeCode");
            }
        }

        /// <summary>
        ///     URL for the Website associated with the product.
        /// </summary>
        [AttributeLogicalName("producturl")]
        public string ProductUrl
        {
            get { return GetAttributeValue<string>("producturl"); }
            set
            {
                OnPropertyChanging("ProductUrl");
                SetAttributeValue("producturl", value);
                OnPropertyChanged("ProductUrl");
            }
        }

        /// <summary>
        ///     Number of decimal places that can be used in monetary amounts for the product.
        /// </summary>
        [AttributeLogicalName("quantitydecimal")]
        public int? QuantityDecimal
        {
            get { return GetAttributeValue<int?>("quantitydecimal"); }
            set
            {
                OnPropertyChanging("QuantityDecimal");
                SetAttributeValue("quantitydecimal", value);
                OnPropertyChanged("QuantityDecimal");
            }
        }

        /// <summary>
        ///     Quantity of the product in stock.
        /// </summary>
        [AttributeLogicalName("quantityonhand")]
        public decimal? QuantityOnHand
        {
            get { return GetAttributeValue<decimal?>("quantityonhand"); }
            set
            {
                OnPropertyChanging("QuantityOnHand");
                SetAttributeValue("quantityonhand", value);
                OnPropertyChanged("QuantityOnHand");
            }
        }

        /// <summary>
        ///     Product size.
        /// </summary>
        [AttributeLogicalName("size")]
        public string Size
        {
            get { return GetAttributeValue<string>("size"); }
            set
            {
                OnPropertyChanging("Size");
                SetAttributeValue("size", value);
                OnPropertyChanged("Size");
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
        ///     Standard cost of the product.
        /// </summary>
        [AttributeLogicalName("standardcost")]
        public Money StandardCost
        {
            get { return GetAttributeValue<Money>("standardcost"); }
            set
            {
                OnPropertyChanging("StandardCost");
                SetAttributeValue("standardcost", value);
                OnPropertyChanged("StandardCost");
            }
        }

        /// <summary>
        ///     Base currency equivalent of the standard cost of the product.
        /// </summary>
        [AttributeLogicalName("standardcost_base")]
        public Money StandardCost_Base
        {
            get { return GetAttributeValue<Money>("standardcost_base"); }
        }

        /// <summary>
        ///     Status of the product.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public ProductState? StateCode
        {
            get
            {
                var optionSet = GetAttributeValue<OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ProductState) (Enum.ToObject(typeof (ProductState), optionSet.Value)));
                }
                return null;
            }
        }

        /// <summary>
        ///     Reason for the status of the product.
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
        ///     Stock volume of the product.
        /// </summary>
        [AttributeLogicalName("stockvolume")]
        public decimal? StockVolume
        {
            get { return GetAttributeValue<decimal?>("stockvolume"); }
            set
            {
                OnPropertyChanging("StockVolume");
                SetAttributeValue("stockvolume", value);
                OnPropertyChanged("StockVolume");
            }
        }

        /// <summary>
        ///     Stock weight of the product.
        /// </summary>
        [AttributeLogicalName("stockweight")]
        public decimal? StockWeight
        {
            get { return GetAttributeValue<decimal?>("stockweight"); }
            set
            {
                OnPropertyChanging("StockWeight");
                SetAttributeValue("stockweight", value);
                OnPropertyChanged("StockWeight");
            }
        }

        /// <summary>
        ///     Unique identifier of the subject associated with the product.
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
        ///     Name of the product's supplier.
        /// </summary>
        [AttributeLogicalName("suppliername")]
        public string SupplierName
        {
            get { return GetAttributeValue<string>("suppliername"); }
            set
            {
                OnPropertyChanging("SupplierName");
                SetAttributeValue("suppliername", value);
                OnPropertyChanged("SupplierName");
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
        ///     Unique identifier of the currency associated with the product.
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
        ///     Name of the product vendor.
        /// </summary>
        [AttributeLogicalName("vendorname")]
        public string VendorName
        {
            get { return GetAttributeValue<string>("vendorname"); }
            set
            {
                OnPropertyChanging("VendorName");
                SetAttributeValue("vendorname", value);
                OnPropertyChanged("VendorName");
            }
        }

        /// <summary>
        ///     Part number for the vendor's product.
        /// </summary>
        [AttributeLogicalName("vendorpartnumber")]
        public string VendorPartNumber
        {
            get { return GetAttributeValue<string>("vendorpartnumber"); }
            set
            {
                OnPropertyChanging("VendorPartNumber");
                SetAttributeValue("vendorpartnumber", value);
                OnPropertyChanged("VendorPartNumber");
            }
        }

        /// <summary>
        ///     Version number of the product.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N opportunity_products
        /// </summary>
        [RelationshipSchemaName("opportunity_products")]
        public IEnumerable<OpportunityProduct> opportunity_products
        {
            get { return GetRelatedEntities<OpportunityProduct>("opportunity_products", null); }
            set
            {
                OnPropertyChanging("opportunity_products");
                SetRelatedEntities("opportunity_products", null, value);
                OnPropertyChanged("opportunity_products");
            }
        }

        /// <summary>
        ///     1:N Product_Annotation
        /// </summary>
        [RelationshipSchemaName("Product_Annotation")]
        public IEnumerable<Annotation> Product_Annotation
        {
            get { return GetRelatedEntities<Annotation>("Product_Annotation", null); }
            set
            {
                OnPropertyChanging("Product_Annotation");
                SetRelatedEntities("Product_Annotation", null, value);
                OnPropertyChanged("Product_Annotation");
            }
        }

        /// <summary>
        ///     1:N Product_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Product_AsyncOperations")]
        public IEnumerable<AsyncOperation> Product_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("Product_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("Product_AsyncOperations");
                SetRelatedEntities("Product_AsyncOperations", null, value);
                OnPropertyChanged("Product_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N Product_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("Product_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> Product_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("Product_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("Product_BulkDeleteFailures");
                SetRelatedEntities("Product_BulkDeleteFailures", null, value);
                OnPropertyChanged("Product_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     1:N product_contract_line_items
        /// </summary>
        [RelationshipSchemaName("product_contract_line_items")]
        public IEnumerable<ContractDetail> product_contract_line_items
        {
            get { return GetRelatedEntities<ContractDetail>("product_contract_line_items", null); }
            set
            {
                OnPropertyChanging("product_contract_line_items");
                SetRelatedEntities("product_contract_line_items", null, value);
                OnPropertyChanged("product_contract_line_items");
            }
        }

        /// <summary>
        ///     1:N product_incidents
        /// </summary>
        [RelationshipSchemaName("product_incidents")]
        public IEnumerable<Incident> product_incidents
        {
            get { return GetRelatedEntities<Incident>("product_incidents", null); }
            set
            {
                OnPropertyChanging("product_incidents");
                SetRelatedEntities("product_incidents", null, value);
                OnPropertyChanged("product_incidents");
            }
        }

        /// <summary>
        ///     1:N product_invoice_details
        /// </summary>
        [RelationshipSchemaName("product_invoice_details")]
        public IEnumerable<InvoiceDetail> product_invoice_details
        {
            get { return GetRelatedEntities<InvoiceDetail>("product_invoice_details", null); }
            set
            {
                OnPropertyChanging("product_invoice_details");
                SetRelatedEntities("product_invoice_details", null, value);
                OnPropertyChanged("product_invoice_details");
            }
        }

        /// <summary>
        ///     1:N product_order_details
        /// </summary>
        [RelationshipSchemaName("product_order_details")]
        public IEnumerable<SalesOrderDetail> product_order_details
        {
            get { return GetRelatedEntities<SalesOrderDetail>("product_order_details", null); }
            set
            {
                OnPropertyChanging("product_order_details");
                SetRelatedEntities("product_order_details", null, value);
                OnPropertyChanged("product_order_details");
            }
        }

        /// <summary>
        ///     1:N product_price_levels
        /// </summary>
        [RelationshipSchemaName("product_price_levels")]
        public IEnumerable<ProductPriceLevel> product_price_levels
        {
            get { return GetRelatedEntities<ProductPriceLevel>("product_price_levels", null); }
            set
            {
                OnPropertyChanging("product_price_levels");
                SetRelatedEntities("product_price_levels", null, value);
                OnPropertyChanged("product_price_levels");
            }
        }

        /// <summary>
        ///     1:N product_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("product_principalobjectattributeaccess")]
        public IEnumerable<PrincipalObjectAttributeAccess> product_principalobjectattributeaccess
        {
            get
            {
                return GetRelatedEntities<PrincipalObjectAttributeAccess>("product_principalobjectattributeaccess", null);
            }
            set
            {
                OnPropertyChanging("product_principalobjectattributeaccess");
                SetRelatedEntities("product_principalobjectattributeaccess", null, value);
                OnPropertyChanged("product_principalobjectattributeaccess");
            }
        }

        /// <summary>
        ///     1:N Product_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("Product_ProcessSessions")]
        public IEnumerable<ProcessSession> Product_ProcessSessions
        {
            get { return GetRelatedEntities<ProcessSession>("Product_ProcessSessions", null); }
            set
            {
                OnPropertyChanging("Product_ProcessSessions");
                SetRelatedEntities("Product_ProcessSessions", null, value);
                OnPropertyChanged("Product_ProcessSessions");
            }
        }

        /// <summary>
        ///     1:N product_quote_details
        /// </summary>
        [RelationshipSchemaName("product_quote_details")]
        public IEnumerable<QuoteDetail> product_quote_details
        {
            get { return GetRelatedEntities<QuoteDetail>("product_quote_details", null); }
            set
            {
                OnPropertyChanging("product_quote_details");
                SetRelatedEntities("product_quote_details", null, value);
                OnPropertyChanged("product_quote_details");
            }
        }

        /// <summary>
        ///     1:N Product_SharepointDocumentLocation
        /// </summary>
        [RelationshipSchemaName("Product_SharepointDocumentLocation")]
        public IEnumerable<SharePointDocumentLocation> Product_SharepointDocumentLocation
        {
            get { return GetRelatedEntities<SharePointDocumentLocation>("Product_SharepointDocumentLocation", null); }
            set
            {
                OnPropertyChanging("Product_SharepointDocumentLocation");
                SetRelatedEntities("Product_SharepointDocumentLocation", null, value);
                OnPropertyChanged("Product_SharepointDocumentLocation");
            }
        }

        /// <summary>
        ///     1:N userentityinstancedata_product
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_product")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_product
        {
            get { return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_product", null); }
            set
            {
                OnPropertyChanging("userentityinstancedata_product");
                SetRelatedEntities("userentityinstancedata_product", null, value);
                OnPropertyChanged("userentityinstancedata_product");
            }
        }

        /// <summary>
        ///     N:N campaignproduct_association
        /// </summary>
        [RelationshipSchemaName("campaignproduct_association")]
        public IEnumerable<Campaign> campaignproduct_association
        {
            get { return GetRelatedEntities<Campaign>("campaignproduct_association", null); }
            set
            {
                OnPropertyChanging("campaignproduct_association");
                SetRelatedEntities("campaignproduct_association", null, value);
                OnPropertyChanged("campaignproduct_association");
            }
        }

        /// <summary>
        ///     N:N competitorproduct_association
        /// </summary>
        [RelationshipSchemaName("competitorproduct_association")]
        public IEnumerable<Competitor> competitorproduct_association
        {
            get { return GetRelatedEntities<Competitor>("competitorproduct_association", null); }
            set
            {
                OnPropertyChanging("competitorproduct_association");
                SetRelatedEntities("competitorproduct_association", null, value);
                OnPropertyChanged("competitorproduct_association");
            }
        }

        /// <summary>
        ///     N:N leadproduct_association
        /// </summary>
        [RelationshipSchemaName("leadproduct_association")]
        public IEnumerable<Lead> leadproduct_association
        {
            get { return GetRelatedEntities<Lead>("leadproduct_association", null); }
            set
            {
                OnPropertyChanging("leadproduct_association");
                SetRelatedEntities("leadproduct_association", null, value);
                OnPropertyChanged("leadproduct_association");
            }
        }

        /// <summary>
        ///     N:N productassociation_association
        /// </summary>
        [RelationshipSchemaName("productassociation_association", EntityRole.Referencing)]
        public IEnumerable<Product> Referencingproductassociation_association
        {
            get { return GetRelatedEntities<Product>("productassociation_association", EntityRole.Referencing); }
            set
            {
                OnPropertyChanging("Referencingproductassociation_association");
                SetRelatedEntities("productassociation_association", EntityRole.Referencing, value);
                OnPropertyChanged("Referencingproductassociation_association");
            }
        }

        /// <summary>
        ///     N:N productassociation_association
        /// </summary>
        [RelationshipSchemaName("productassociation_association", EntityRole.Referenced)]
        public IEnumerable<Product> Referencedproductassociation_association
        {
            get { return GetRelatedEntities<Product>("productassociation_association", EntityRole.Referenced); }
            set
            {
                OnPropertyChanging("Referencedproductassociation_association");
                SetRelatedEntities("productassociation_association", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedproductassociation_association");
            }
        }

        /// <summary>
        ///     N:N productsalesliterature_association
        /// </summary>
        [RelationshipSchemaName("productsalesliterature_association")]
        public IEnumerable<SalesLiterature> productsalesliterature_association
        {
            get { return GetRelatedEntities<SalesLiterature>("productsalesliterature_association", null); }
            set
            {
                OnPropertyChanging("productsalesliterature_association");
                SetRelatedEntities("productsalesliterature_association", null, value);
                OnPropertyChanged("productsalesliterature_association");
            }
        }

        /// <summary>
        ///     N:N productsubstitute_association
        /// </summary>
        [RelationshipSchemaName("productsubstitute_association", EntityRole.Referencing)]
        public IEnumerable<Product> Referencingproductsubstitute_association
        {
            get { return GetRelatedEntities<Product>("productsubstitute_association", EntityRole.Referencing); }
            set
            {
                OnPropertyChanging("Referencingproductsubstitute_association");
                SetRelatedEntities("productsubstitute_association", EntityRole.Referencing, value);
                OnPropertyChanged("Referencingproductsubstitute_association");
            }
        }

        /// <summary>
        ///     N:N productsubstitute_association
        /// </summary>
        [RelationshipSchemaName("productsubstitute_association", EntityRole.Referenced)]
        public IEnumerable<Product> Referencedproductsubstitute_association
        {
            get { return GetRelatedEntities<Product>("productsubstitute_association", EntityRole.Referenced); }
            set
            {
                OnPropertyChanging("Referencedproductsubstitute_association");
                SetRelatedEntities("productsubstitute_association", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedproductsubstitute_association");
            }
        }

        /// <summary>
        ///     N:1 lk_product_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_product_createdonbehalfby")]
        public SystemUser lk_product_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_product_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_product_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_product_modifiedonbehalfby")]
        public SystemUser lk_product_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_product_modifiedonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_productbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_productbase_createdby")]
        public SystemUser lk_productbase_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_productbase_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_productbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_productbase_modifiedby")]
        public SystemUser lk_productbase_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_productbase_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 organization_products
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_products")]
        public Organization organization_products
        {
            get { return GetRelatedEntity<Organization>("organization_products", null); }
        }

        /// <summary>
        ///     N:1 price_level_products
        /// </summary>
        [AttributeLogicalName("pricelevelid")]
        [RelationshipSchemaName("price_level_products")]
        public PriceLevel price_level_products
        {
            get { return GetRelatedEntity<PriceLevel>("price_level_products", null); }
            set
            {
                OnPropertyChanging("price_level_products");
                SetRelatedEntity("price_level_products", null, value);
                OnPropertyChanged("price_level_products");
            }
        }

        /// <summary>
        ///     N:1 processstage_products
        /// </summary>
        [AttributeLogicalName("stageid")]
        [RelationshipSchemaName("processstage_products")]
        public ProcessStage processstage_products
        {
            get { return GetRelatedEntity<ProcessStage>("processstage_products", null); }
            set
            {
                OnPropertyChanging("processstage_products");
                SetRelatedEntity("processstage_products", null, value);
                OnPropertyChanged("processstage_products");
            }
        }

        /// <summary>
        ///     N:1 subject_products
        /// </summary>
        [AttributeLogicalName("subjectid")]
        [RelationshipSchemaName("subject_products")]
        public Subject subject_products
        {
            get { return GetRelatedEntity<Subject>("subject_products", null); }
            set
            {
                OnPropertyChanging("subject_products");
                SetRelatedEntity("subject_products", null, value);
                OnPropertyChanged("subject_products");
            }
        }

        /// <summary>
        ///     N:1 transactioncurrency_product
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("transactioncurrency_product")]
        public TransactionCurrency transactioncurrency_product
        {
            get { return GetRelatedEntity<TransactionCurrency>("transactioncurrency_product", null); }
            set
            {
                OnPropertyChanging("transactioncurrency_product");
                SetRelatedEntity("transactioncurrency_product", null, value);
                OnPropertyChanged("transactioncurrency_product");
            }
        }

        /// <summary>
        ///     N:1 unit_of_measurement_products
        /// </summary>
        [AttributeLogicalName("defaultuomid")]
        [RelationshipSchemaName("unit_of_measurement_products")]
        public UoM unit_of_measurement_products
        {
            get { return GetRelatedEntity<UoM>("unit_of_measurement_products", null); }
            set
            {
                OnPropertyChanging("unit_of_measurement_products");
                SetRelatedEntity("unit_of_measurement_products", null, value);
                OnPropertyChanged("unit_of_measurement_products");
            }
        }

        /// <summary>
        ///     N:1 unit_of_measurement_schedule_products
        /// </summary>
        [AttributeLogicalName("defaultuomscheduleid")]
        [RelationshipSchemaName("unit_of_measurement_schedule_products")]
        public UoMSchedule unit_of_measurement_schedule_products
        {
            get { return GetRelatedEntity<UoMSchedule>("unit_of_measurement_schedule_products", null); }
            set
            {
                OnPropertyChanging("unit_of_measurement_schedule_products");
                SetRelatedEntity("unit_of_measurement_schedule_products", null, value);
                OnPropertyChanged("unit_of_measurement_schedule_products");
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