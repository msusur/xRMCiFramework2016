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
    ///     Organization-owned entity customizations including form layout and dashboards.
    /// </summary>
    [DataContract]
    [EntityLogicalName("systemform")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class SystemForm : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "systemform";

        public const int EntityTypeCode = 1030;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public SystemForm() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the parent form.
        /// </summary>
        [AttributeLogicalName("ancestorformid")]
        public EntityReference AncestorFormId
        {
            get { return GetAttributeValue<EntityReference>("ancestorformid"); }
            set
            {
                OnPropertyChanging("AncestorFormId");
                SetAttributeValue("ancestorformid", value);
                OnPropertyChanged("AncestorFormId");
            }
        }

        /// <summary>
        ///     Information that specifies whether this component can be deleted.
        /// </summary>
        [AttributeLogicalName("canbedeleted")]
        public BooleanManagedProperty CanBeDeleted
        {
            get { return GetAttributeValue<BooleanManagedProperty>("canbedeleted"); }
            set
            {
                OnPropertyChanging("CanBeDeleted");
                SetAttributeValue("canbedeleted", value);
                OnPropertyChanged("CanBeDeleted");
            }
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
        ///     Description of the form or dashboard.
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
        ///     Specifies the state of the form.
        /// </summary>
        [AttributeLogicalName("formactivationstate")]
        public OptionSetValue FormActivationState
        {
            get { return GetAttributeValue<OptionSetValue>("formactivationstate"); }
            set
            {
                OnPropertyChanging("FormActivationState");
                SetAttributeValue("formactivationstate", value);
                OnPropertyChanged("FormActivationState");
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
        ///     Specifies whether this form is in the updated UI layout in Microsoft Dynamics CRM 2013 or Microsoft Dynamics CRM
        ///     Online Fall '13.
        /// </summary>
        [AttributeLogicalName("formpresentation")]
        public OptionSetValue FormPresentation
        {
            get { return GetAttributeValue<OptionSetValue>("formpresentation"); }
            set
            {
                OnPropertyChanging("FormPresentation");
                SetAttributeValue("formpresentation", value);
                OnPropertyChanged("FormPresentation");
            }
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
        ///     Version in which the form is introduced.
        /// </summary>
        [AttributeLogicalName("introducedversion")]
        public string IntroducedVersion
        {
            get { return GetAttributeValue<string>("introducedversion"); }
            set
            {
                OnPropertyChanging("IntroducedVersion");
                SetAttributeValue("introducedversion", value);
                OnPropertyChanged("IntroducedVersion");
            }
        }

        /// <summary>
        ///     Specifies whether this form is merged with the updated UI layout in Microsoft Dynamics CRM 2013 or Microsoft
        ///     Dynamics CRM Online Fall '13.
        /// </summary>
        [AttributeLogicalName("isairmerged")]
        public bool? IsAIRMerged
        {
            get { return GetAttributeValue<bool?>("isairmerged"); }
            set
            {
                OnPropertyChanging("IsAIRMerged");
                SetAttributeValue("isairmerged", value);
                OnPropertyChanged("IsAIRMerged");
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
        ///     Information that specifies whether the form or the dashboard is the system default.
        /// </summary>
        [AttributeLogicalName("isdefault")]
        public bool? IsDefault
        {
            get { return GetAttributeValue<bool?>("isdefault"); }
            set
            {
                OnPropertyChanging("IsDefault");
                SetAttributeValue("isdefault", value);
                OnPropertyChanged("IsDefault");
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
        ///     Name of the form.
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
        ///     Unique identifier of the associated solution.
        /// </summary>
        [AttributeLogicalName("solutionid")]
        public Guid? SolutionId
        {
            get { return GetAttributeValue<Guid?>("solutionid"); }
        }

        /// <summary>
        ///     Type of the form, for example, Dashboard or Preview.
        /// </summary>
        [AttributeLogicalName("type")]
        public OptionSetValue Type
        {
            get { return GetAttributeValue<OptionSetValue>("type"); }
            set
            {
                OnPropertyChanging("Type");
                SetAttributeValue("type", value);
                OnPropertyChanged("Type");
            }
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
        ///     1:N form_ancestor_form
        /// </summary>
        [RelationshipSchemaName("form_ancestor_form", EntityRole.Referenced)]
        public IEnumerable<SystemForm> Referencedform_ancestor_form
        {
            get { return GetRelatedEntities<SystemForm>("form_ancestor_form", EntityRole.Referenced); }
            set
            {
                OnPropertyChanging("Referencedform_ancestor_form");
                SetRelatedEntities("form_ancestor_form", EntityRole.Referenced, value);
                OnPropertyChanged("Referencedform_ancestor_form");
            }
        }

        /// <summary>
        ///     1:N processtrigger_systemform
        /// </summary>
        [RelationshipSchemaName("processtrigger_systemform")]
        public IEnumerable<ProcessTrigger> processtrigger_systemform
        {
            get { return GetRelatedEntities<ProcessTrigger>("processtrigger_systemform", null); }
            set
            {
                OnPropertyChanging("processtrigger_systemform");
                SetRelatedEntities("processtrigger_systemform", null, value);
                OnPropertyChanged("processtrigger_systemform");
            }
        }

        /// <summary>
        ///     1:N SystemForm_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("SystemForm_AsyncOperations")]
        public IEnumerable<AsyncOperation> SystemForm_AsyncOperations
        {
            get { return GetRelatedEntities<AsyncOperation>("SystemForm_AsyncOperations", null); }
            set
            {
                OnPropertyChanging("SystemForm_AsyncOperations");
                SetRelatedEntities("SystemForm_AsyncOperations", null, value);
                OnPropertyChanged("SystemForm_AsyncOperations");
            }
        }

        /// <summary>
        ///     1:N SystemForm_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("SystemForm_BulkDeleteFailures")]
        public IEnumerable<BulkDeleteFailure> SystemForm_BulkDeleteFailures
        {
            get { return GetRelatedEntities<BulkDeleteFailure>("SystemForm_BulkDeleteFailures", null); }
            set
            {
                OnPropertyChanging("SystemForm_BulkDeleteFailures");
                SetRelatedEntities("SystemForm_BulkDeleteFailures", null, value);
                OnPropertyChanged("SystemForm_BulkDeleteFailures");
            }
        }

        /// <summary>
        ///     N:1 form_ancestor_form
        /// </summary>
        [AttributeLogicalName("ancestorformid")]
        [RelationshipSchemaName("form_ancestor_form", EntityRole.Referencing)]
        public SystemForm Referencingform_ancestor_form
        {
            get { return GetRelatedEntity<SystemForm>("form_ancestor_form", EntityRole.Referencing); }
            set
            {
                OnPropertyChanging("Referencingform_ancestor_form");
                SetRelatedEntity("form_ancestor_form", EntityRole.Referencing, value);
                OnPropertyChanged("Referencingform_ancestor_form");
            }
        }

        /// <summary>
        ///     N:1 organization_systemforms
        /// </summary>
        [AttributeLogicalName("organizationid")]
        [RelationshipSchemaName("organization_systemforms")]
        public Organization organization_systemforms
        {
            get { return GetRelatedEntity<Organization>("organization_systemforms", null); }
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