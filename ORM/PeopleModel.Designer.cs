﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Text;

[assembly: EdmSchemaAttribute()]

namespace ORM
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class SQLPersonDBEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new SQLPersonDBEntities object using the connection string found in the 'SQLPersonDBEntities' section of the application configuration file.
        /// </summary>
        public SQLPersonDBEntities() : base("name=SQLPersonDBEntities", "SQLPersonDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new SQLPersonDBEntities object.
        /// </summary>
        public SQLPersonDBEntities(string connectionString) : base(connectionString, "SQLPersonDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new SQLPersonDBEntities object.
        /// </summary>
        public SQLPersonDBEntities(EntityConnection connection) : base(connection, "SQLPersonDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Person> People
        {
            get
            {
                if ((_People == null))
                {
                    _People = base.CreateObjectSet<Person>("People");
                }
                return _People;
            }
        }
        private ObjectSet<Person> _People;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<sysdiagram> sysdiagrams
        {
            get
            {
                if ((_sysdiagrams == null))
                {
                    _sysdiagrams = base.CreateObjectSet<sysdiagram>("sysdiagrams");
                }
                return _sysdiagrams;
            }
        }
        private ObjectSet<sysdiagram> _sysdiagrams;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the People EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPeople(Person person)
        {
            base.AddObject("People", person);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the sysdiagrams EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTosysdiagrams(sysdiagram sysdiagram)
        {
            base.AddObject("sysdiagrams", sysdiagram);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SQLPersonDBModel", Name="Person")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Person : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Person object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        public static Person CreatePerson(global::System.Int32 id)
        {
            Person person = new Person();
            person.ID = id;
            return person;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String FName
        {
            get
            {
                return _FName;
            }
            set
            {
                OnFNameChanging(value);
                ReportPropertyChanging("FName");
                _FName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("FName");
                OnFNameChanged();
            }
        }
        private global::System.String _FName;
        partial void OnFNameChanging(global::System.String value);
        partial void OnFNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String LName
        {
            get
            {
                return _LName;
            }
            set
            {
                OnLNameChanging(value);
                ReportPropertyChanging("LName");
                _LName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("LName");
                OnLNameChanged();
            }
        }
        private global::System.String _LName;
        partial void OnLNameChanging(global::System.String value);
        partial void OnLNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> BirthDate
        {
            get
            {
                return _BirthDate;
            }
            set
            {
                OnBirthDateChanging(value);
                ReportPropertyChanging("BirthDate");
                _BirthDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("BirthDate");
                OnBirthDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _BirthDate;
        partial void OnBirthDateChanging(Nullable<global::System.DateTime> value);
        partial void OnBirthDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.Byte[] Photo
        {
            get
            {
                return StructuralObject.GetValidValue(_Photo);
            }
            set
            {
                OnPhotoChanging(value);
                ReportPropertyChanging("Photo");
                _Photo = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Photo");
                OnPhotoChanged();
            }
        }
        private global::System.Byte[] _Photo;
        partial void OnPhotoChanging(global::System.Byte[] value);
        partial void OnPhotoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String PhotoLink
        {
            get
            {
                return _PhotoLink;
            }
            set
            {
                OnPhotoLinkChanging(value);
                ReportPropertyChanging("PhotoLink");
                _PhotoLink = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("PhotoLink");
                OnPhotoLinkChanged();
            }
        }
        private global::System.String _PhotoLink;
        partial void OnPhotoLinkChanging(global::System.String value);
        partial void OnPhotoLinkChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String E_mail
        {
            get
            {
                return _E_mail;
            }
            set
            {
                OnE_mailChanging(value);
                ReportPropertyChanging("E_mail");
                _E_mail = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("E_mail");
                OnE_mailChanged();
            }
        }
        private global::System.String _E_mail;
        partial void OnE_mailChanging(global::System.String value);
        partial void OnE_mailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Phone
        {
            get
            {
                return _Phone;
            }
            set
            {
                OnPhoneChanging(value);
                ReportPropertyChanging("Phone");
                _Phone = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Phone");
                OnPhoneChanged();
            }
        }
        private global::System.String _Phone;
        partial void OnPhoneChanging(global::System.String value);
        partial void OnPhoneChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.Byte[] File
        {
            get
            {
                return StructuralObject.GetValidValue(_File);
            }
            set
            {
                OnFileChanging(value);
                ReportPropertyChanging("File");
                _File = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("File");
                OnFileChanged();
            }
        }
        private global::System.Byte[] _File;
        partial void OnFileChanging(global::System.Byte[] value);
        partial void OnFileChanged();

        #endregion
        public object this[int index]
        {
            get
            {
                object result = null;
                if (index < 0 || index > Length)
                {
                    throw new IndexOutOfRangeException();
                }
                switch (index)
                {
                    case 0:
                        result = ID;
                        break;
                    case 1:
                        result = FName;
                        break;
                    case 2:
                        result = LName;
                        break;
                    case 3:
                        result = BirthDate;
                        break;
                    case 4:
                        result = Photo;
                        break;
                    case 5:
                        result = PhotoLink;
                        break;
                    case 6:
                        result = E_mail;
                        break;
                    case 7:
                        result = Phone;
                        break;
                    case 8:
                        result = Description;
                        break;
                    case 9:
                        result = File;
                        break;
                }
                return result;
            }
            set
            {
                if (index < 0 || index > Length)
                {
                    throw new IndexOutOfRangeException();
                }
                switch (index)
                {
                    case 0:
                        if (value != null)
                        {
                            ID = int.Parse(value.ToString());
                        }
                        break;
                    case 1:
                        FName = value as string;
                        break;
                    case 2:
                        LName = value as string;
                        break;
                    case 3:
                        if (value != null)
                        {
                            BirthDate = Convert.ToDateTime(value as string);
                        }
                        else
                        {
                            BirthDate = null;
                        }
                        break;
                    case 4:
                        Photo = value != null ? Encoding.UTF8.GetBytes(value.ToString()) : null;
                        break;
                    case 5:
                        PhotoLink = value as string;
                        break;
                    case 6:
                        E_mail = value as string;
                        break;
                    case 7:
                        Phone = value as string;
                        break;
                    case 8:
                        Description = value as string;
                        break;
                    case 9:
                        File = value != null ? Encoding.UTF8.GetBytes(value as string) : null;
                        break;
                }
            }
        }
        public int Length
        {
            get
            {
                return 10;
            }
        }
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SQLPersonDBModel", Name="sysdiagram")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class sysdiagram : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new sysdiagram object.
        /// </summary>
        /// <param name="name">Initial value of the name property.</param>
        /// <param name="principal_id">Initial value of the principal_id property.</param>
        /// <param name="diagram_id">Initial value of the diagram_id property.</param>
        public static sysdiagram Createsysdiagram(global::System.String name, global::System.Int32 principal_id, global::System.Int32 diagram_id)
        {
            sysdiagram sysdiagram = new sysdiagram();
            sysdiagram.name = name;
            sysdiagram.principal_id = principal_id;
            sysdiagram.diagram_id = diagram_id;
            return sysdiagram;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 principal_id
        {
            get
            {
                return _principal_id;
            }
            set
            {
                Onprincipal_idChanging(value);
                ReportPropertyChanging("principal_id");
                _principal_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("principal_id");
                Onprincipal_idChanged();
            }
        }
        private global::System.Int32 _principal_id;
        partial void Onprincipal_idChanging(global::System.Int32 value);
        partial void Onprincipal_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 diagram_id
        {
            get
            {
                return _diagram_id;
            }
            set
            {
                if (_diagram_id != value)
                {
                    Ondiagram_idChanging(value);
                    ReportPropertyChanging("diagram_id");
                    _diagram_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("diagram_id");
                    Ondiagram_idChanged();
                }
            }
        }
        private global::System.Int32 _diagram_id;
        partial void Ondiagram_idChanging(global::System.Int32 value);
        partial void Ondiagram_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> version
        {
            get
            {
                return _version;
            }
            set
            {
                OnversionChanging(value);
                ReportPropertyChanging("version");
                _version = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("version");
                OnversionChanged();
            }
        }
        private Nullable<global::System.Int32> _version;
        partial void OnversionChanging(Nullable<global::System.Int32> value);
        partial void OnversionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.Byte[] definition
        {
            get
            {
                return StructuralObject.GetValidValue(_definition);
            }
            set
            {
                OndefinitionChanging(value);
                ReportPropertyChanging("definition");
                _definition = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("definition");
                OndefinitionChanged();
            }
        }
        private global::System.Byte[] _definition;
        partial void OndefinitionChanging(global::System.Byte[] value);
        partial void OndefinitionChanged();

        #endregion
    
    }

    #endregion
    
}
