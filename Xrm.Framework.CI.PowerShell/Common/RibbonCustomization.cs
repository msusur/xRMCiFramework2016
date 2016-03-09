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
    ///     Ribbon customizations for the application ribbon and entity ribbon templates.
    /// </summary>
    [DataContract]
    [EntityLogicalName("ribboncustomization")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class RibbonCustomization : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "ribboncustomization";

        public const int EntityTypeCode = 1120;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public RibbonCustomization() :
            base(EntityLogicalName)
        {
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
        ///     Specifies which entity's ribbons this customization applies to. If null, then the customizations apply to the
        ///     global ribbons.
        /// </summary>
        [AttributeLogicalName("entity")]
        public string Entity
        {
            get { return GetAttributeValue<string>("entity"); }
            set
            {
                OnPropertyChanging("Entity");
                SetAttributeValue("entity", value);
                OnPropertyChanged("Entity");
            }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("ismanaged")]
        public bool? IsManaged
        {
            get { return GetAttributeValue<bool?>("ismanaged"); }
        }

        /// <summary>
        ///     Unique identifier of the organization.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
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
        /// </summary>
        [AttributeLogicalName("publishedon")]
        public DateTime? PublishedOn
        {
            get { return GetAttributeValue<DateTime?>("publishedon"); }
        }

        /// <summary>
        ///     Unique identifier.
        /// </summary>
        [AttributeLogicalName("ribboncustomizationid")]
        public Guid? RibbonCustomizationId
        {
            get { return GetAttributeValue<Guid?>("ribboncustomizationid"); }
            set
            {
                OnPropertyChanging("RibbonCustomizationId");
                SetAttributeValue("ribboncustomizationid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("RibbonCustomizationId");
            }
        }

        [AttributeLogicalName("ribboncustomizationid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { RibbonCustomizationId = value; }
        }

        /// <summary>
        ///     Unique identifier for this row.
        /// </summary>
        [AttributeLogicalName("ribboncustomizationuniqueid")]
        public Guid? RibbonCustomizationUniqueId
        {
            get { return GetAttributeValue<Guid?>("ribboncustomizationuniqueid"); }
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
        ///     Represents a version of customizations to be synchronized with the Microsoft Dynamics CRM client for Outlook.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N userentityinstancedata_ribboncustomization
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_ribboncustomization")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_ribboncustomization
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_ribboncustomization", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_ribboncustomization");
                SetRelatedEntities("userentityinstancedata_ribboncustomization", null, value);
                OnPropertyChanged("userentityinstancedata_ribboncustomization");
            }
        }

        /// <summary>
        ///     N:1 organization_ribbon_customization
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_ribbon_customization")]
        public Organization organization_ribbon_customization
        {
            get { return GetRelatedEntity<Organization>("organization_ribbon_customization", null); }
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