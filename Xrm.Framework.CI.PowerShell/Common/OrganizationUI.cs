using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Xrm.Framework.CI.Common.Entities
{
    /// <summary>
    ///     Entity customizations including form layout and icons. Includes current and past versions.
    /// </summary>
    [DataContract]
    [EntityLogicalName("organizationui")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class OrganizationUI : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "organizationui";

        public const int EntityTypeCode = 1021;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public OrganizationUI() :
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
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("fieldxml")]
        public string FieldXml
        {
            get { return GetAttributeValue<string>("fieldxml"); }
            set
            {
                OnPropertyChanging("FieldXml");
                SetAttributeValue("fieldxml", value);
                OnPropertyChanged("FieldXml");
            }
        }

        /// <summary>
        ///     Unique identifier of the record type form.
        /// </summary>
        [AttributeLogicalName("formid")]
        public Guid? FormId
        {
            get { return GetAttributeValue<Guid?>("formid"); }
            set
            {
                OnPropertyChanging("FormId");
                SetAttributeValue("formid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("FormId");
            }
        }

        [AttributeLogicalName("formid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { FormId = value; }
        }

        /// <summary>
        ///     Unique identifier of the form used when synchronizing customizations for the Microsoft Dynamics CRM client for
        ///     Outlook.
        /// </summary>
        [AttributeLogicalName("formidunique")]
        public Guid? FormIdUnique
        {
            get { return GetAttributeValue<Guid?>("formidunique"); }
        }

        /// <summary>
        ///     XML representation of the form layout.
        /// </summary>
        [AttributeLogicalName("formxml")]
        public string FormXml
        {
            get { return GetAttributeValue<string>("formxml"); }
            set
            {
                OnPropertyChanging("FormXml");
                SetAttributeValue("formxml", value);
                OnPropertyChanged("FormXml");
            }
        }

        /// <summary>
        ///     Binary representation of the icon used in record type grid views.
        /// </summary>
        [AttributeLogicalName("gridicon")]
        public string GridIcon
        {
            get { return GetAttributeValue<string>("gridicon"); }
            set
            {
                OnPropertyChanging("GridIcon");
                SetAttributeValue("gridicon", value);
                OnPropertyChanged("GridIcon");
            }
        }

        /// <summary>
        ///     Information that specifies whether this component can be customized.
        /// </summary>
        [AttributeLogicalName("iscustomizable")]
        public BooleanManagedProperty IsCustomizable
        {
            get { return GetAttributeValue<BooleanManagedProperty>("iscustomizable"); }
            set
            {
                OnPropertyChanging("IsCustomizable");
                SetAttributeValue("iscustomizable", value);
                OnPropertyChanged("IsCustomizable");
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
        ///     Binary representation of the large icon used in the record type form.
        /// </summary>
        [AttributeLogicalName("largeentityicon")]
        public string LargeEntityIcon
        {
            get { return GetAttributeValue<string>("largeentityicon"); }
            set
            {
                OnPropertyChanging("LargeEntityIcon");
                SetAttributeValue("largeentityicon", value);
                OnPropertyChanged("LargeEntityIcon");
            }
        }

        /// <summary>
        ///     Code that represents the record type.
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
        ///     Unique identifier of the organization.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get { return GetAttributeValue<EntityReference>("organizationid"); }
        }

        /// <summary>
        ///     Binary representation of the large icon used in the Microsoft Dynamics CRM client for Outlook for this record type.
        /// </summary>
        [AttributeLogicalName("outlookshortcuticon")]
        public string OutlookShortcutIcon
        {
            get { return GetAttributeValue<string>("outlookshortcuticon"); }
            set
            {
                OnPropertyChanging("OutlookShortcutIcon");
                SetAttributeValue("outlookshortcuticon", value);
                OnPropertyChanged("OutlookShortcutIcon");
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
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("previewcolumnsetxml")]
        public string PreviewColumnsetXml
        {
            get { return GetAttributeValue<string>("previewcolumnsetxml"); }
            set
            {
                OnPropertyChanging("PreviewColumnsetXml");
                SetAttributeValue("previewcolumnsetxml", value);
                OnPropertyChanged("PreviewColumnsetXml");
            }
        }

        /// <summary>
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("previewxml")]
        public string PreviewXml
        {
            get { return GetAttributeValue<string>("previewxml"); }
            set
            {
                OnPropertyChanging("PreviewXml");
                SetAttributeValue("previewxml", value);
                OnPropertyChanged("PreviewXml");
            }
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
        ///     For internal use only.
        /// </summary>
        [AttributeLogicalName("version")]
        public int? Version
        {
            get { return GetAttributeValue<int?>("version"); }
            set
            {
                OnPropertyChanging("Version");
                SetAttributeValue("version", value);
                OnPropertyChanged("Version");
            }
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
        ///     N:1 lk_organizationui_organizationid
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("lk_organizationui_organizationid")]
        public Organization lk_organizationui_organizationid
        {
            get { return GetRelatedEntity<Organization>("lk_organizationui_organizationid", null); }
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