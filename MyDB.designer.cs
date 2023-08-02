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

namespace ProjectService
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="danhlc_SA_Project")]
	public partial class MyDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertcustomer(customer instance);
    partial void Updatecustomer(customer instance);
    partial void Deletecustomer(customer instance);
    partial void Insertdepartment(department instance);
    partial void Updatedepartment(department instance);
    partial void Deletedepartment(department instance);
    partial void Insertreservation(reservation instance);
    partial void Updatereservation(reservation instance);
    partial void Deletereservation(reservation instance);
    #endregion
		
		public MyDBDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["danhlc_SA_ProjectConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MyDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<customer> customers
		{
			get
			{
				return this.GetTable<customer>();
			}
		}
		
		public System.Data.Linq.Table<department> departments
		{
			get
			{
				return this.GetTable<department>();
			}
		}
		
		public System.Data.Linq.Table<reservation> reservations
		{
			get
			{
				return this.GetTable<reservation>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.customer")]
	public partial class customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CusID;
		
		private string _Phone;
		
		private string _CusName;
		
		private System.DateTime _BDate;
		
		private string _Email;
		
		private EntitySet<reservation> _reservations;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCusIDChanging(int value);
    partial void OnCusIDChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnCusNameChanging(string value);
    partial void OnCusNameChanged();
    partial void OnBDateChanging(System.DateTime value);
    partial void OnBDateChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public customer()
		{
			this._reservations = new EntitySet<reservation>(new Action<reservation>(this.attach_reservations), new Action<reservation>(this.detach_reservations));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CusID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CusID
		{
			get
			{
				return this._CusID;
			}
			set
			{
				if ((this._CusID != value))
				{
					this.OnCusIDChanging(value);
					this.SendPropertyChanging();
					this._CusID = value;
					this.SendPropertyChanged("CusID");
					this.OnCusIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CusName", DbType="NVarChar(299) NOT NULL", CanBeNull=false)]
		public string CusName
		{
			get
			{
				return this._CusName;
			}
			set
			{
				if ((this._CusName != value))
				{
					this.OnCusNameChanging(value);
					this.SendPropertyChanging();
					this._CusName = value;
					this.SendPropertyChanged("CusName");
					this.OnCusNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BDate", DbType="Date NOT NULL")]
		public System.DateTime BDate
		{
			get
			{
				return this._BDate;
			}
			set
			{
				if ((this._BDate != value))
				{
					this.OnBDateChanging(value);
					this.SendPropertyChanging();
					this._BDate = value;
					this.SendPropertyChanged("BDate");
					this.OnBDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(299) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="customer_reservation", Storage="_reservations", ThisKey="CusID", OtherKey="CusID")]
		public EntitySet<reservation> reservations
		{
			get
			{
				return this._reservations;
			}
			set
			{
				this._reservations.Assign(value);
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
		
		private void attach_reservations(reservation entity)
		{
			this.SendPropertyChanging();
			entity.customer = this;
		}
		
		private void detach_reservations(reservation entity)
		{
			this.SendPropertyChanging();
			entity.customer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.department")]
	public partial class department : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DepID;
		
		private string _DepName;
		
		private EntitySet<reservation> _reservations;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDepIDChanging(int value);
    partial void OnDepIDChanged();
    partial void OnDepNameChanging(string value);
    partial void OnDepNameChanged();
    #endregion
		
		public department()
		{
			this._reservations = new EntitySet<reservation>(new Action<reservation>(this.attach_reservations), new Action<reservation>(this.detach_reservations));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int DepID
		{
			get
			{
				return this._DepID;
			}
			set
			{
				if ((this._DepID != value))
				{
					this.OnDepIDChanging(value);
					this.SendPropertyChanging();
					this._DepID = value;
					this.SendPropertyChanged("DepID");
					this.OnDepIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepName", DbType="NVarChar(299) NOT NULL", CanBeNull=false)]
		public string DepName
		{
			get
			{
				return this._DepName;
			}
			set
			{
				if ((this._DepName != value))
				{
					this.OnDepNameChanging(value);
					this.SendPropertyChanging();
					this._DepName = value;
					this.SendPropertyChanged("DepName");
					this.OnDepNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="department_reservation", Storage="_reservations", ThisKey="DepID", OtherKey="DepID")]
		public EntitySet<reservation> reservations
		{
			get
			{
				return this._reservations;
			}
			set
			{
				this._reservations.Assign(value);
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
		
		private void attach_reservations(reservation entity)
		{
			this.SendPropertyChanging();
			entity.department = this;
		}
		
		private void detach_reservations(reservation entity)
		{
			this.SendPropertyChanging();
			entity.department = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.reservation")]
	public partial class reservation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ResID;
		
		private System.DateTime _DateRes;
		
		private string _Description;
		
		private int _CusID;
		
		private int _DepID;
		
		private EntityRef<customer> _customer;
		
		private EntityRef<department> _department;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnResIDChanging(int value);
    partial void OnResIDChanged();
    partial void OnDateResChanging(System.DateTime value);
    partial void OnDateResChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnCusIDChanging(int value);
    partial void OnCusIDChanged();
    partial void OnDepIDChanging(int value);
    partial void OnDepIDChanged();
    #endregion
		
		public reservation()
		{
			this._customer = default(EntityRef<customer>);
			this._department = default(EntityRef<department>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ResID
		{
			get
			{
				return this._ResID;
			}
			set
			{
				if ((this._ResID != value))
				{
					this.OnResIDChanging(value);
					this.SendPropertyChanging();
					this._ResID = value;
					this.SendPropertyChanged("ResID");
					this.OnResIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateRes", DbType="DateTime NOT NULL")]
		public System.DateTime DateRes
		{
			get
			{
				return this._DateRes;
			}
			set
			{
				if ((this._DateRes != value))
				{
					this.OnDateResChanging(value);
					this.SendPropertyChanging();
					this._DateRes = value;
					this.SendPropertyChanged("DateRes");
					this.OnDateResChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(399) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CusID", DbType="Int NOT NULL")]
		public int CusID
		{
			get
			{
				return this._CusID;
			}
			set
			{
				if ((this._CusID != value))
				{
					if (this._customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCusIDChanging(value);
					this.SendPropertyChanging();
					this._CusID = value;
					this.SendPropertyChanged("CusID");
					this.OnCusIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepID", DbType="Int NOT NULL")]
		public int DepID
		{
			get
			{
				return this._DepID;
			}
			set
			{
				if ((this._DepID != value))
				{
					if (this._department.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDepIDChanging(value);
					this.SendPropertyChanging();
					this._DepID = value;
					this.SendPropertyChanged("DepID");
					this.OnDepIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="customer_reservation", Storage="_customer", ThisKey="CusID", OtherKey="CusID", IsForeignKey=true)]
		public customer customer
		{
			get
			{
				return this._customer.Entity;
			}
			set
			{
				customer previousValue = this._customer.Entity;
				if (((previousValue != value) 
							|| (this._customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._customer.Entity = null;
						previousValue.reservations.Remove(this);
					}
					this._customer.Entity = value;
					if ((value != null))
					{
						value.reservations.Add(this);
						this._CusID = value.CusID;
					}
					else
					{
						this._CusID = default(int);
					}
					this.SendPropertyChanged("customer");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="department_reservation", Storage="_department", ThisKey="DepID", OtherKey="DepID", IsForeignKey=true)]
		public department department
		{
			get
			{
				return this._department.Entity;
			}
			set
			{
				department previousValue = this._department.Entity;
				if (((previousValue != value) 
							|| (this._department.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._department.Entity = null;
						previousValue.reservations.Remove(this);
					}
					this._department.Entity = value;
					if ((value != null))
					{
						value.reservations.Add(this);
						this._DepID = value.DepID;
					}
					else
					{
						this._DepID = default(int);
					}
					this.SendPropertyChanged("department");
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