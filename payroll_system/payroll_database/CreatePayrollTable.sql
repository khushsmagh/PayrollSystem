IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'PR_Employee')) DROP TABLE PR_Employee
Create Table PR_Employee (
EmployeeId int NOT NULL IDENTITY(1,1) PRIMARY KEY,
FirstName varchar(255) NOT NULL,
LastName varchar(255) NOT NULL,
DOB DATETIME2 NOT NULL,
DateHired datetime2 NOt NULL,
Position varchar(100) NOT NULL,
HourlyRate money NOT NULL,
)


IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'PR_Schedule')) DROP TABLE PR_Schedule
Create Table PR_Schedule (
ScheduleId int NOT NULL IDENTITY(1,1) PRIMARY KEY,
EmployeeId  int FOREIGN KEY REFERENCES PR_Employee(EmployeeId ),
DateOfWork datetime2 NOT NULL,
StartTime time NOT NULL,
EndTime time NOt NULL,
ShiftHours numeric(4) NOT NULL,
_Month varchar(100) NOT NULL,
_Year varchar(100) NOT NULL,
)

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'PR_Pay_slip')) DROP TABLE PR_Pay_slip
Create Table PR_Pay_slip (
PaySlipId int NOT NULL IDENTITY(1,1) PRIMARY KEY,
EmployeeId  int FOREIGN KEY REFERENCES PR_Employee(EmployeeId ),
DateFrom datetime2 NOT NULL,
EndDate datetime2 NOT NULL,
TotalHours numeric(4) NOt NULL,
TotalMoney money NOT NULL,
)

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'PR_User_Login')) DROP TABLE PR_User_Login
Create Table PR_User_Login (
UserId int NOT NULL IDENTITY(1,1) PRIMARY KEY,
EmployeeId  int FOREIGN KEY REFERENCES PR_Employee(EmployeeId ),
UserName nvarchar(100) NOT NULL,
_Password nvarchar(100) NOT NULL,
)


