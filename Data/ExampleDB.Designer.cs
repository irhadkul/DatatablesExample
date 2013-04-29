﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace DatatablesExample.Data
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ExampleEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ExampleEntities object using the connection string found in the 'ExampleEntities' section of the application configuration file.
        /// </summary>
        public ExampleEntities() : base("name=ExampleEntities", "ExampleEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ExampleEntities object.
        /// </summary>
        public ExampleEntities(string connectionString) : base(connectionString, "ExampleEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ExampleEntities object.
        /// </summary>
        public ExampleEntities(EntityConnection connection) : base(connection, "ExampleEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Function Imports
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="filterTerm">No Metadata Documentation available.</param>
        /// <param name="sortIndex">No Metadata Documentation available.</param>
        /// <param name="sortDirection">No Metadata Documentation available.</param>
        /// <param name="startRowNum">No Metadata Documentation available.</param>
        /// <param name="endRowNum">No Metadata Documentation available.</param>
        /// <param name="totalRowsCount">No Metadata Documentation available.</param>
        /// <param name="filteredRowsCount">No Metadata Documentation available.</param>
        public ObjectResult<pr_SearchPerson_Result> pr_SearchPerson(global::System.String filterTerm, Nullable<global::System.Int32> sortIndex, global::System.String sortDirection, Nullable<global::System.Int32> startRowNum, Nullable<global::System.Int32> endRowNum, ObjectParameter totalRowsCount, ObjectParameter filteredRowsCount)
        {
            ObjectParameter filterTermParameter;
            if (filterTerm != null)
            {
                filterTermParameter = new ObjectParameter("FilterTerm", filterTerm);
            }
            else
            {
                filterTermParameter = new ObjectParameter("FilterTerm", typeof(global::System.String));
            }
    
            ObjectParameter sortIndexParameter;
            if (sortIndex.HasValue)
            {
                sortIndexParameter = new ObjectParameter("SortIndex", sortIndex);
            }
            else
            {
                sortIndexParameter = new ObjectParameter("SortIndex", typeof(global::System.Int32));
            }
    
            ObjectParameter sortDirectionParameter;
            if (sortDirection != null)
            {
                sortDirectionParameter = new ObjectParameter("SortDirection", sortDirection);
            }
            else
            {
                sortDirectionParameter = new ObjectParameter("SortDirection", typeof(global::System.String));
            }
    
            ObjectParameter startRowNumParameter;
            if (startRowNum.HasValue)
            {
                startRowNumParameter = new ObjectParameter("StartRowNum", startRowNum);
            }
            else
            {
                startRowNumParameter = new ObjectParameter("StartRowNum", typeof(global::System.Int32));
            }
    
            ObjectParameter endRowNumParameter;
            if (endRowNum.HasValue)
            {
                endRowNumParameter = new ObjectParameter("EndRowNum", endRowNum);
            }
            else
            {
                endRowNumParameter = new ObjectParameter("EndRowNum", typeof(global::System.Int32));
            }
    
            return base.ExecuteFunction<pr_SearchPerson_Result>("pr_SearchPerson", filterTermParameter, sortIndexParameter, sortDirectionParameter, startRowNumParameter, endRowNumParameter, totalRowsCount, filteredRowsCount);
        }

        #endregion

    }

    #endregion

    #region ComplexTypes
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmComplexTypeAttribute(NamespaceName="ExampleModel", Name="pr_SearchPerson_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class pr_SearchPerson_Result : ComplexObject
    {
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> DateOfBirth
        {
            get
            {
                return _DateOfBirth;
            }
            set
            {
                OnDateOfBirthChanging(value);
                ReportPropertyChanging("DateOfBirth");
                _DateOfBirth = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DateOfBirth");
                OnDateOfBirthChanged();
            }
        }
        private Nullable<global::System.DateTime> _DateOfBirth;
        partial void OnDateOfBirthChanging(Nullable<global::System.DateTime> value);
        partial void OnDateOfBirthChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Nationality
        {
            get
            {
                return _Nationality;
            }
            set
            {
                OnNationalityChanging(value);
                ReportPropertyChanging("Nationality");
                _Nationality = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Nationality");
                OnNationalityChanged();
            }
        }
        private global::System.String _Nationality;
        partial void OnNationalityChanging(global::System.String value);
        partial void OnNationalityChanged();

        #endregion

    }

    #endregion

    
}
