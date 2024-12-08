﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyLichHoc.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QuanLyLichHoc")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSubject(Subject instance);
    partial void UpdateSubject(Subject instance);
    partial void DeleteSubject(Subject instance);
    #endregion
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Subject> Subjects
		{
			get
			{
				return this.GetTable<Subject>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Subjects")]
	public partial class Subject : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _subjectId;
		
		private string _subjectName;
		
		private string _creditHours;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnsubjectIdChanging(string value);
    partial void OnsubjectIdChanged();
    partial void OnsubjectNameChanging(string value);
    partial void OnsubjectNameChanged();
    partial void OncreditHoursChanging(string value);
    partial void OncreditHoursChanged();
    #endregion
		
		public Subject()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_subjectId", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string subjectId
		{
			get
			{
				return this._subjectId;
			}
			set
			{
				if ((this._subjectId != value))
				{
					this.OnsubjectIdChanging(value);
					this.SendPropertyChanging();
					this._subjectId = value;
					this.SendPropertyChanged("subjectId");
					this.OnsubjectIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_subjectName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string subjectName
		{
			get
			{
				return this._subjectName;
			}
			set
			{
				if ((this._subjectName != value))
				{
					this.OnsubjectNameChanging(value);
					this.SendPropertyChanging();
					this._subjectName = value;
					this.SendPropertyChanged("subjectName");
					this.OnsubjectNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_creditHours", DbType="VarChar(3)")]
		public string creditHours
		{
			get
			{
				return this._creditHours;
			}
			set
			{
				if ((this._creditHours != value))
				{
					this.OncreditHoursChanging(value);
					this.SendPropertyChanging();
					this._creditHours = value;
					this.SendPropertyChanged("creditHours");
					this.OncreditHoursChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
