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

namespace payroll_system
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="retailmgmt")]
	public partial class LinqToSQLDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTEmployee(TEmployee instance);
    partial void UpdateTEmployee(TEmployee instance);
    partial void DeleteTEmployee(TEmployee instance);
    partial void InsertTUserLogin(TUserLogin instance);
    partial void UpdateTUserLogin(TUserLogin instance);
    partial void DeleteTUserLogin(TUserLogin instance);
    partial void InsertTPayslip(TPayslip instance);
    partial void UpdateTPayslip(TPayslip instance);
    partial void DeleteTPayslip(TPayslip instance);
    #endregion
		
		public LinqToSQLDataContext() : 
				base(global::payroll_system.Properties.Settings.Default.retailmgmtConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSQLDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSQLDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSQLDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSQLDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TEmployee> TEmployees
		{
			get
			{
				return this.GetTable<TEmployee>();
			}
		}
		
		public System.Data.Linq.Table<TUserLogin> TUserLogins
		{
			get
			{
				return this.GetTable<TUserLogin>();
			}
		}
		
		public System.Data.Linq.Table<TPayslip> TPayslips
		{
			get
			{
				return this.GetTable<TPayslip>();
			}
		}
		
		public System.Data.Linq.Table<TSchedule> TSchedules
		{
			get
			{
				return this.GetTable<TSchedule>();
			}
		}
		
		public System.Data.Linq.Table<TTimesheet> TTimesheets
		{
			get
			{
				return this.GetTable<TTimesheet>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TEmployee")]
	public partial class TEmployee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EmployeeId;
		
		private string _FirstName;
		
		private string _LastName;
		
		private System.DateTime _DOB;
		
		private System.DateTime _DateHired;
		
		private string _Position;
		
		private decimal _HourlyRate;
		
		private EntitySet<TUserLogin> _TUserLogins;
		
		private EntitySet<TPayslip> _TPayslips;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmployeeIdChanging(int value);
    partial void OnEmployeeIdChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnDOBChanging(System.DateTime value);
    partial void OnDOBChanged();
    partial void OnDateHiredChanging(System.DateTime value);
    partial void OnDateHiredChanged();
    partial void OnPositionChanging(string value);
    partial void OnPositionChanged();
    partial void OnHourlyRateChanging(decimal value);
    partial void OnHourlyRateChanged();
    #endregion
		
		public TEmployee()
		{
			this._TUserLogins = new EntitySet<TUserLogin>(new Action<TUserLogin>(this.attach_TUserLogins), new Action<TUserLogin>(this.detach_TUserLogins));
			this._TPayslips = new EntitySet<TPayslip>(new Action<TPayslip>(this.attach_TPayslips), new Action<TPayslip>(this.detach_TPayslips));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int EmployeeId
		{
			get
			{
				return this._EmployeeId;
			}
			set
			{
				if ((this._EmployeeId != value))
				{
					this.OnEmployeeIdChanging(value);
					this.SendPropertyChanging();
					this._EmployeeId = value;
					this.SendPropertyChanged("EmployeeId");
					this.OnEmployeeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DOB", DbType="Date NOT NULL")]
		public System.DateTime DOB
		{
			get
			{
				return this._DOB;
			}
			set
			{
				if ((this._DOB != value))
				{
					this.OnDOBChanging(value);
					this.SendPropertyChanging();
					this._DOB = value;
					this.SendPropertyChanged("DOB");
					this.OnDOBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateHired", DbType="Date NOT NULL")]
		public System.DateTime DateHired
		{
			get
			{
				return this._DateHired;
			}
			set
			{
				if ((this._DateHired != value))
				{
					this.OnDateHiredChanging(value);
					this.SendPropertyChanging();
					this._DateHired = value;
					this.SendPropertyChanged("DateHired");
					this.OnDateHiredChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Position", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Position
		{
			get
			{
				return this._Position;
			}
			set
			{
				if ((this._Position != value))
				{
					this.OnPositionChanging(value);
					this.SendPropertyChanging();
					this._Position = value;
					this.SendPropertyChanged("Position");
					this.OnPositionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HourlyRate", DbType="Money NOT NULL")]
		public decimal HourlyRate
		{
			get
			{
				return this._HourlyRate;
			}
			set
			{
				if ((this._HourlyRate != value))
				{
					this.OnHourlyRateChanging(value);
					this.SendPropertyChanging();
					this._HourlyRate = value;
					this.SendPropertyChanged("HourlyRate");
					this.OnHourlyRateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TEmployee_TUserLogin", Storage="_TUserLogins", ThisKey="EmployeeId", OtherKey="EmployeeId")]
		public EntitySet<TUserLogin> TUserLogins
		{
			get
			{
				return this._TUserLogins;
			}
			set
			{
				this._TUserLogins.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TEmployee_TPayslip", Storage="_TPayslips", ThisKey="EmployeeId", OtherKey="EmployeeId")]
		public EntitySet<TPayslip> TPayslips
		{
			get
			{
				return this._TPayslips;
			}
			set
			{
				this._TPayslips.Assign(value);
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
		
		private void attach_TUserLogins(TUserLogin entity)
		{
			this.SendPropertyChanging();
			entity.TEmployee = this;
		}
		
		private void detach_TUserLogins(TUserLogin entity)
		{
			this.SendPropertyChanging();
			entity.TEmployee = null;
		}
		
		private void attach_TPayslips(TPayslip entity)
		{
			this.SendPropertyChanging();
			entity.TEmployee = this;
		}
		
		private void detach_TPayslips(TPayslip entity)
		{
			this.SendPropertyChanging();
			entity.TEmployee = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TUserLogin")]
	public partial class TUserLogin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserId;
		
		private System.Nullable<int> _EmployeeId;
		
		private string _UserName;
		
		private string _Password;
		
		private EntityRef<TEmployee> _TEmployee;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnEmployeeIdChanging(System.Nullable<int> value);
    partial void OnEmployeeIdChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public TUserLogin()
		{
			this._TEmployee = default(EntityRef<TEmployee>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeId", DbType="Int")]
		public System.Nullable<int> EmployeeId
		{
			get
			{
				return this._EmployeeId;
			}
			set
			{
				if ((this._EmployeeId != value))
				{
					if (this._TEmployee.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEmployeeIdChanging(value);
					this.SendPropertyChanging();
					this._EmployeeId = value;
					this.SendPropertyChanged("EmployeeId");
					this.OnEmployeeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TEmployee_TUserLogin", Storage="_TEmployee", ThisKey="EmployeeId", OtherKey="EmployeeId", IsForeignKey=true)]
		public TEmployee TEmployee
		{
			get
			{
				return this._TEmployee.Entity;
			}
			set
			{
				TEmployee previousValue = this._TEmployee.Entity;
				if (((previousValue != value) 
							|| (this._TEmployee.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TEmployee.Entity = null;
						previousValue.TUserLogins.Remove(this);
					}
					this._TEmployee.Entity = value;
					if ((value != null))
					{
						value.TUserLogins.Add(this);
						this._EmployeeId = value.EmployeeId;
					}
					else
					{
						this._EmployeeId = default(Nullable<int>);
					}
					this.SendPropertyChanged("TEmployee");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TPayslip")]
	public partial class TPayslip : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PaySlipId;
		
		private System.Nullable<int> _EmployeeId;
		
		private System.DateTime _DateFrom;
		
		private System.DateTime _EndDate;
		
		private decimal _TotalHours;
		
		private decimal _TotalMoney;
		
		private EntityRef<TEmployee> _TEmployee;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPaySlipIdChanging(int value);
    partial void OnPaySlipIdChanged();
    partial void OnEmployeeIdChanging(System.Nullable<int> value);
    partial void OnEmployeeIdChanged();
    partial void OnDateFromChanging(System.DateTime value);
    partial void OnDateFromChanged();
    partial void OnEndDateChanging(System.DateTime value);
    partial void OnEndDateChanged();
    partial void OnTotalHoursChanging(decimal value);
    partial void OnTotalHoursChanged();
    partial void OnTotalMoneyChanging(decimal value);
    partial void OnTotalMoneyChanged();
    #endregion
		
		public TPayslip()
		{
			this._TEmployee = default(EntityRef<TEmployee>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaySlipId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PaySlipId
		{
			get
			{
				return this._PaySlipId;
			}
			set
			{
				if ((this._PaySlipId != value))
				{
					this.OnPaySlipIdChanging(value);
					this.SendPropertyChanging();
					this._PaySlipId = value;
					this.SendPropertyChanged("PaySlipId");
					this.OnPaySlipIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeId", DbType="Int")]
		public System.Nullable<int> EmployeeId
		{
			get
			{
				return this._EmployeeId;
			}
			set
			{
				if ((this._EmployeeId != value))
				{
					if (this._TEmployee.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEmployeeIdChanging(value);
					this.SendPropertyChanging();
					this._EmployeeId = value;
					this.SendPropertyChanged("EmployeeId");
					this.OnEmployeeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateFrom", DbType="Date NOT NULL")]
		public System.DateTime DateFrom
		{
			get
			{
				return this._DateFrom;
			}
			set
			{
				if ((this._DateFrom != value))
				{
					this.OnDateFromChanging(value);
					this.SendPropertyChanging();
					this._DateFrom = value;
					this.SendPropertyChanged("DateFrom");
					this.OnDateFromChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndDate", DbType="Date NOT NULL")]
		public System.DateTime EndDate
		{
			get
			{
				return this._EndDate;
			}
			set
			{
				if ((this._EndDate != value))
				{
					this.OnEndDateChanging(value);
					this.SendPropertyChanging();
					this._EndDate = value;
					this.SendPropertyChanged("EndDate");
					this.OnEndDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalHours", DbType="Decimal(4,0) NOT NULL")]
		public decimal TotalHours
		{
			get
			{
				return this._TotalHours;
			}
			set
			{
				if ((this._TotalHours != value))
				{
					this.OnTotalHoursChanging(value);
					this.SendPropertyChanging();
					this._TotalHours = value;
					this.SendPropertyChanged("TotalHours");
					this.OnTotalHoursChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalMoney", DbType="Money NOT NULL")]
		public decimal TotalMoney
		{
			get
			{
				return this._TotalMoney;
			}
			set
			{
				if ((this._TotalMoney != value))
				{
					this.OnTotalMoneyChanging(value);
					this.SendPropertyChanging();
					this._TotalMoney = value;
					this.SendPropertyChanged("TotalMoney");
					this.OnTotalMoneyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TEmployee_TPayslip", Storage="_TEmployee", ThisKey="EmployeeId", OtherKey="EmployeeId", IsForeignKey=true)]
		public TEmployee TEmployee
		{
			get
			{
				return this._TEmployee.Entity;
			}
			set
			{
				TEmployee previousValue = this._TEmployee.Entity;
				if (((previousValue != value) 
							|| (this._TEmployee.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TEmployee.Entity = null;
						previousValue.TPayslips.Remove(this);
					}
					this._TEmployee.Entity = value;
					if ((value != null))
					{
						value.TPayslips.Add(this);
						this._EmployeeId = value.EmployeeId;
					}
					else
					{
						this._EmployeeId = default(Nullable<int>);
					}
					this.SendPropertyChanged("TEmployee");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TSchedule")]
	public partial class TSchedule
	{
		
		private int _ScheduleId;
		
		private System.Nullable<int> _EmployeeId;
		
		private System.DateTime _Date;
		
		private string _Shift;
		
		public TSchedule()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ScheduleId", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int ScheduleId
		{
			get
			{
				return this._ScheduleId;
			}
			set
			{
				if ((this._ScheduleId != value))
				{
					this._ScheduleId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeId", DbType="Int")]
		public System.Nullable<int> EmployeeId
		{
			get
			{
				return this._EmployeeId;
			}
			set
			{
				if ((this._EmployeeId != value))
				{
					this._EmployeeId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="Date NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this._Date = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Shift", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Shift
		{
			get
			{
				return this._Shift;
			}
			set
			{
				if ((this._Shift != value))
				{
					this._Shift = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TTimesheet")]
	public partial class TTimesheet
	{
		
		private int _TimesheetId;
		
		private System.Nullable<int> _EmployeeId;
		
		private System.DateTime _Date;
		
		private System.TimeSpan _CLockInTime;
		
		private System.TimeSpan _ClockOutTime;
		
		private decimal _TotalHours;
		
		public TTimesheet()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimesheetId", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int TimesheetId
		{
			get
			{
				return this._TimesheetId;
			}
			set
			{
				if ((this._TimesheetId != value))
				{
					this._TimesheetId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeId", DbType="Int")]
		public System.Nullable<int> EmployeeId
		{
			get
			{
				return this._EmployeeId;
			}
			set
			{
				if ((this._EmployeeId != value))
				{
					this._EmployeeId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="Date NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this._Date = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CLockInTime", DbType="Time NOT NULL")]
		public System.TimeSpan CLockInTime
		{
			get
			{
				return this._CLockInTime;
			}
			set
			{
				if ((this._CLockInTime != value))
				{
					this._CLockInTime = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClockOutTime", DbType="Time NOT NULL")]
		public System.TimeSpan ClockOutTime
		{
			get
			{
				return this._ClockOutTime;
			}
			set
			{
				if ((this._ClockOutTime != value))
				{
					this._ClockOutTime = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalHours", DbType="Decimal(4,2) NOT NULL")]
		public decimal TotalHours
		{
			get
			{
				return this._TotalHours;
			}
			set
			{
				if ((this._TotalHours != value))
				{
					this._TotalHours = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
