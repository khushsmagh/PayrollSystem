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
	public partial class LINQToSQLDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPR_Employee(PR_Employee instance);
    partial void UpdatePR_Employee(PR_Employee instance);
    partial void DeletePR_Employee(PR_Employee instance);
    partial void InsertPR_Payslip(PR_Payslip instance);
    partial void UpdatePR_Payslip(PR_Payslip instance);
    partial void DeletePR_Payslip(PR_Payslip instance);
    partial void InsertPR_User_Login(PR_User_Login instance);
    partial void UpdatePR_User_Login(PR_User_Login instance);
    partial void DeletePR_User_Login(PR_User_Login instance);
    #endregion
		
		public LINQToSQLDataContext() : 
				base(global::payroll_system.Properties.Settings.Default.retailmgmtConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LINQToSQLDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQToSQLDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQToSQLDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQToSQLDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<PR_Employee> PR_Employees
		{
			get
			{
				return this.GetTable<PR_Employee>();
			}
		}
		
		public System.Data.Linq.Table<PR_Payslip> PR_Payslips
		{
			get
			{
				return this.GetTable<PR_Payslip>();
			}
		}
		
		public System.Data.Linq.Table<PR_Schedule> PR_Schedules
		{
			get
			{
				return this.GetTable<PR_Schedule>();
			}
		}
		
		public System.Data.Linq.Table<PR_Timesheet> PR_Timesheets
		{
			get
			{
				return this.GetTable<PR_Timesheet>();
			}
		}
		
		public System.Data.Linq.Table<PR_User_Login> PR_User_Logins
		{
			get
			{
				return this.GetTable<PR_User_Login>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PR_Employee")]
	public partial class PR_Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EmployeeId;
		
		private string _FirstName;
		
		private string _LastName;
		
		private System.DateTime _DOB;
		
		private System.DateTime _DateHired;
		
		private string _Position;
		
		private decimal _HourlyRate;
		
		private EntitySet<PR_Payslip> _PR_Payslips;
		
		private EntitySet<PR_User_Login> _PR_User_Logins;
		
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
		
		public PR_Employee()
		{
			this._PR_Payslips = new EntitySet<PR_Payslip>(new Action<PR_Payslip>(this.attach_PR_Payslips), new Action<PR_Payslip>(this.detach_PR_Payslips));
			this._PR_User_Logins = new EntitySet<PR_User_Login>(new Action<PR_User_Login>(this.attach_PR_User_Logins), new Action<PR_User_Login>(this.detach_PR_User_Logins));
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PR_Employee_PR_Payslip", Storage="_PR_Payslips", ThisKey="EmployeeId", OtherKey="EmployeeId")]
		public EntitySet<PR_Payslip> PR_Payslips
		{
			get
			{
				return this._PR_Payslips;
			}
			set
			{
				this._PR_Payslips.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PR_Employee_PR_User_Login", Storage="_PR_User_Logins", ThisKey="EmployeeId", OtherKey="EmployeeId")]
		public EntitySet<PR_User_Login> PR_User_Logins
		{
			get
			{
				return this._PR_User_Logins;
			}
			set
			{
				this._PR_User_Logins.Assign(value);
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
		
		private void attach_PR_Payslips(PR_Payslip entity)
		{
			this.SendPropertyChanging();
			entity.PR_Employee = this;
		}
		
		private void detach_PR_Payslips(PR_Payslip entity)
		{
			this.SendPropertyChanging();
			entity.PR_Employee = null;
		}
		
		private void attach_PR_User_Logins(PR_User_Login entity)
		{
			this.SendPropertyChanging();
			entity.PR_Employee = this;
		}
		
		private void detach_PR_User_Logins(PR_User_Login entity)
		{
			this.SendPropertyChanging();
			entity.PR_Employee = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PR_Payslip")]
	public partial class PR_Payslip : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PaySlipId;
		
		private System.Nullable<int> _EmployeeId;
		
		private System.DateTime _DateFrom;
		
		private System.DateTime _EndDate;
		
		private decimal _TotalHours;
		
		private decimal _TotalMoney;
		
		private EntityRef<PR_Employee> _PR_Employee;
		
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
		
		public PR_Payslip()
		{
			this._PR_Employee = default(EntityRef<PR_Employee>);
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
					if (this._PR_Employee.HasLoadedOrAssignedValue)
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PR_Employee_PR_Payslip", Storage="_PR_Employee", ThisKey="EmployeeId", OtherKey="EmployeeId", IsForeignKey=true)]
		public PR_Employee PR_Employee
		{
			get
			{
				return this._PR_Employee.Entity;
			}
			set
			{
				PR_Employee previousValue = this._PR_Employee.Entity;
				if (((previousValue != value) 
							|| (this._PR_Employee.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PR_Employee.Entity = null;
						previousValue.PR_Payslips.Remove(this);
					}
					this._PR_Employee.Entity = value;
					if ((value != null))
					{
						value.PR_Payslips.Add(this);
						this._EmployeeId = value.EmployeeId;
					}
					else
					{
						this._EmployeeId = default(Nullable<int>);
					}
					this.SendPropertyChanged("PR_Employee");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PR_Schedule")]
	public partial class PR_Schedule
	{
		
		private System.Nullable<int> _EmployeeId;
		
		private System.DateTime _Date;
		
		private string _Shift;
		
		public PR_Schedule()
		{
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PR_Timesheet")]
	public partial class PR_Timesheet
	{
		
		private System.Nullable<int> _EmployeeId;
		
		private System.DateTime _Date;
		
		private System.TimeSpan _CLockInTime;
		
		private System.TimeSpan _ClockOutTime;
		
		private decimal _TotalHours;
		
		public PR_Timesheet()
		{
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
					this._TotalHours = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PR_User_Login")]
	public partial class PR_User_Login : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserId;
		
		private System.Nullable<int> _EmployeeId;
		
		private string _UserName;
		
		private string _Password;
		
		private EntityRef<PR_Employee> _PR_Employee;
		
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
		
		public PR_User_Login()
		{
			this._PR_Employee = default(EntityRef<PR_Employee>);
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
					if (this._PR_Employee.HasLoadedOrAssignedValue)
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PR_Employee_PR_User_Login", Storage="_PR_Employee", ThisKey="EmployeeId", OtherKey="EmployeeId", IsForeignKey=true)]
		public PR_Employee PR_Employee
		{
			get
			{
				return this._PR_Employee.Entity;
			}
			set
			{
				PR_Employee previousValue = this._PR_Employee.Entity;
				if (((previousValue != value) 
							|| (this._PR_Employee.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PR_Employee.Entity = null;
						previousValue.PR_User_Logins.Remove(this);
					}
					this._PR_Employee.Entity = value;
					if ((value != null))
					{
						value.PR_User_Logins.Add(this);
						this._EmployeeId = value.EmployeeId;
					}
					else
					{
						this._EmployeeId = default(Nullable<int>);
					}
					this.SendPropertyChanged("PR_Employee");
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
