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
    ///     Team template for an entity enabled for automatically created access teams.
    /// </summary>
    [DataContract]
    [EntityLogicalName("teamtemplate")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class TeamTemplate : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "teamtemplate";

        public const int EntityTypeCode = 92;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public TeamTemplate() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Unique identifier of the user who created the team template.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get { return GetAttributeValue<EntityReference>("createdby"); }
        }

        /// <summary>
        ///     Date and time when the team template was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get { return GetAttributeValue<DateTime?>("createdon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who created the team template.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        ///     Default access rights mask for the access teams associated with entity instances.
        /// </summary>
        [AttributeLogicalName("defaultaccessrightsmask")]
        public int? DefaultAccessRightsMask
        {
            get { return GetAttributeValue<int?>("defaultaccessrightsmask"); }
            set
            {
                OnPropertyChanging("DefaultAccessRightsMask");
                SetAttributeValue("defaultaccessrightsmask", value);
                OnPropertyChanged("DefaultAccessRightsMask");
            }
        }

        /// <summary>
        ///     Type additional information that describes the team.
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
        ///     Information about whether this team template is user-defined or system-defined.
        /// </summary>
        [AttributeLogicalName("issystem")]
        public bool? IsSystem
        {
            get { return GetAttributeValue<bool?>("issystem"); }
        }

        /// <summary>
        ///     Unique identifier of the user who last modified the team template.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedby"); }
        }

        /// <summary>
        ///     Date and time when the team template was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get { return GetAttributeValue<DateTime?>("modifiedon"); }
        }

        /// <summary>
        ///     Unique identifier of the delegate user who modified the team template.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        ///     Object type code of entity which is enabled for access teams
        /// </summary>
        [AttributeLogicalName("objecttypecode")]
        public int? ObjectTypeCode
        {
            get { return GetAttributeValue<int?>("objecttypecode"); }
            set
            {
                OnPropertyChanging("ObjectTypeCode");
                SetAttributeValue("objecttypecode", value);
                OnPropertyChanged("ObjectTypeCode");
            }
        }

        /// <summary>
        ///     Unique identifier of the team template.
        /// </summary>
        [AttributeLogicalName("teamtemplateid")]
        public Guid? TeamTemplateId
        {
            get { return GetAttributeValue<Guid?>("teamtemplateid"); }
            set
            {
                OnPropertyChanging("TeamTemplateId");
                SetAttributeValue("teamtemplateid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("TeamTemplateId");
            }
        }

        [AttributeLogicalName("teamtemplateid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { TeamTemplateId = value; }
        }

        /// <summary>
        ///     Type the name of the team template.
        /// </summary>
        [AttributeLogicalName("teamtemplatename")]
        public string TeamTemplateName
        {
            get { return GetAttributeValue<string>("teamtemplatename"); }
            set
            {
                OnPropertyChanging("TeamTemplateName");
                SetAttributeValue("teamtemplatename", value);
                OnPropertyChanged("TeamTemplateName");
            }
        }

        /// <summary>
        ///     1:N teamtemplate_Teams
        /// </summary>
        [RelationshipSchemaName("teamtemplate_Teams")]
        public IEnumerable<Team> teamtemplate_Teams
        {
            get { return GetRelatedEntities<Team>("teamtemplate_Teams", null); }
            set
            {
                OnPropertyChanging("teamtemplate_Teams");
                SetRelatedEntities("teamtemplate_Teams", null, value);
                OnPropertyChanged("teamtemplate_Teams");
            }
        }

        /// <summary>
        ///     N:1 lk_teamtemplate_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_teamtemplate_createdby")]
        public SystemUser lk_teamtemplate_createdby
        {
            get { return GetRelatedEntity<SystemUser>("lk_teamtemplate_createdby", null); }
        }

        /// <summary>
        ///     N:1 lk_teamtemplate_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_teamtemplate_createdonbehalfby")]
        public SystemUser lk_teamtemplate_createdonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_teamtemplate_createdonbehalfby", null); }
        }

        /// <summary>
        ///     N:1 lk_teamtemplate_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_teamtemplate_modifiedby")]
        public SystemUser lk_teamtemplate_modifiedby
        {
            get { return GetRelatedEntity<SystemUser>("lk_teamtemplate_modifiedby", null); }
        }

        /// <summary>
        ///     N:1 lk_teamtemplate_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_teamtemplate_modifiedonbehalfby")]
        public SystemUser lk_teamtemplate_modifiedonbehalfby
        {
            get { return GetRelatedEntity<SystemUser>("lk_teamtemplate_modifiedonbehalfby", null); }
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