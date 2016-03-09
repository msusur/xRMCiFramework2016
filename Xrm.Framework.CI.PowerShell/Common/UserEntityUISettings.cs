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
    ///     Stores user settings for entity views.
    /// </summary>
    [DataContract]
    [EntityLogicalName("userentityuisettings")]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public class UserEntityUISettings : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string EntityLogicalName = "userentityuisettings";

        public const int EntityTypeCode = 2500;

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        public UserEntityUISettings() :
            base(EntityLogicalName)
        {
        }

        /// <summary>
        ///     Describes which entities are most recently inserted into email for this entity
        /// </summary>
        [AttributeLogicalName("insertintoemailmruxml")]
        public string InsertIntoEmailMRUXml
        {
            get { return GetAttributeValue<string>("insertintoemailmruxml"); }
            set
            {
                OnPropertyChanging("InsertIntoEmailMRUXml");
                SetAttributeValue("insertintoemailmruxml", value);
                OnPropertyChanged("InsertIntoEmailMRUXml");
            }
        }

        /// <summary>
        ///     Describes which forms are most recently viewed for this entity.
        /// </summary>
        [AttributeLogicalName("lastviewedformxml")]
        public string LastViewedFormXml
        {
            get { return GetAttributeValue<string>("lastviewedformxml"); }
            set
            {
                OnPropertyChanging("LastViewedFormXml");
                SetAttributeValue("lastviewedformxml", value);
                OnPropertyChanged("LastViewedFormXml");
            }
        }

        /// <summary>
        ///     List of most recently used lookup references for this entity
        /// </summary>
        [AttributeLogicalName("lookupmruxml")]
        public string LookupMRUXml
        {
            get { return GetAttributeValue<string>("lookupmruxml"); }
            set
            {
                OnPropertyChanging("LookupMRUXml");
                SetAttributeValue("lookupmruxml", value);
                OnPropertyChanged("LookupMRUXml");
            }
        }

        /// <summary>
        ///     Describes which tabs are most recently used for this entity
        /// </summary>
        [AttributeLogicalName("mruxml")]
        public string MRUXml
        {
            get { return GetAttributeValue<string>("mruxml"); }
            set
            {
                OnPropertyChanging("MRUXml");
                SetAttributeValue("mruxml", value);
                OnPropertyChanged("MRUXml");
            }
        }

        /// <summary>
        ///     Object Type Code
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
        ///     Unique identifier of the user or team who owns the settings.
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
        ///     Unique identifier of the business unit that owns this.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit
        {
            get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        ///     Unique identifier of the team who owns this saved view.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam
        {
            get { return GetAttributeValue<EntityReference>("owningteam"); }
        }

        /// <summary>
        ///     Unique identifier of the user who owns this saved view.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser
        {
            get { return GetAttributeValue<EntityReference>("owninguser"); }
        }

        /// <summary>
        ///     Describes the reading pane formatting of this entity
        /// </summary>
        [AttributeLogicalName("readingpanexml")]
        public string ReadingPaneXml
        {
            get { return GetAttributeValue<string>("readingpanexml"); }
            set
            {
                OnPropertyChanging("ReadingPaneXml");
                SetAttributeValue("readingpanexml", value);
                OnPropertyChanged("ReadingPaneXml");
            }
        }

        /// <summary>
        ///     Describes which objects are most recently viewed for this entity
        /// </summary>
        [AttributeLogicalName("recentlyviewedxml")]
        public string RecentlyViewedXml
        {
            get { return GetAttributeValue<string>("recentlyviewedxml"); }
            set
            {
                OnPropertyChanging("RecentlyViewedXml");
                SetAttributeValue("recentlyviewedxml", value);
                OnPropertyChanged("RecentlyViewedXml");
            }
        }

        /// <summary>
        ///     Determines whether a record type is exposed in the Outlook Address Book
        /// </summary>
        [AttributeLogicalName("showinaddressbook")]
        public bool? ShowInAddressBook
        {
            get { return GetAttributeValue<bool?>("showinaddressbook"); }
            set
            {
                OnPropertyChanging("ShowInAddressBook");
                SetAttributeValue("showinaddressbook", value);
                OnPropertyChanged("ShowInAddressBook");
            }
        }

        /// <summary>
        ///     Describes the tab ordering for this entity
        /// </summary>
        [AttributeLogicalName("taborderxml")]
        public string TabOrderXml
        {
            get { return GetAttributeValue<string>("taborderxml"); }
            set
            {
                OnPropertyChanging("TabOrderXml");
                SetAttributeValue("taborderxml", value);
                OnPropertyChanged("TabOrderXml");
            }
        }

        /// <summary>
        ///     Unique identifier user entity
        /// </summary>
        [AttributeLogicalName("userentityuisettingsid")]
        public Guid? UserEntityUISettingsId
        {
            get { return GetAttributeValue<Guid?>("userentityuisettingsid"); }
            set
            {
                OnPropertyChanging("UserEntityUISettingsId");
                SetAttributeValue("userentityuisettingsid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("UserEntityUISettingsId");
            }
        }

        [AttributeLogicalName("userentityuisettingsid")]
        public override Guid Id
        {
            get { return base.Id; }
            set { UserEntityUISettingsId = value; }
        }

        /// <summary>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get { return GetAttributeValue<long?>("versionnumber"); }
        }

        /// <summary>
        ///     1:N userentityinstancedata_userentityuisettings
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_userentityuisettings")]
        public IEnumerable<UserEntityInstanceData> userentityinstancedata_userentityuisettings
        {
            get
            {
                return GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_userentityuisettings", null);
            }
            set
            {
                OnPropertyChanging("userentityinstancedata_userentityuisettings");
                SetRelatedEntities("userentityinstancedata_userentityuisettings", null, value);
                OnPropertyChanged("userentityinstancedata_userentityuisettings");
            }
        }

        /// <summary>
        ///     N:1 team_userentityuisettings
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_userentityuisettings")]
        public Team team_userentityuisettings
        {
            get { return GetRelatedEntity<Team>("team_userentityuisettings", null); }
        }

        /// <summary>
        ///     N:1 userentityuisettings_businessunit
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("userentityuisettings_businessunit")]
        public BusinessUnit userentityuisettings_businessunit
        {
            get { return GetRelatedEntity<BusinessUnit>("userentityuisettings_businessunit", null); }
        }

        /// <summary>
        ///     N:1 userentityuisettings_owning_user
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("userentityuisettings_owning_user")]
        public SystemUser userentityuisettings_owning_user
        {
            get { return GetRelatedEntity<SystemUser>("userentityuisettings_owning_user", null); }
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