IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'TEmployee')) DROP TABLE TEmployee
Create Table TEmployee (
EmployeeId int NOT NULL IDENTITY(1,1) PRIMARY KEY,
FirstName nvarchar(255) NOT NULL,
LastName nvarchar(255) NOT NULL,
DOB date NOT NULL,
DateHired date NOt NULL,
Position nvarchar(100) NOT NULL,
HourlyRate money NOT NULL,
)


IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'TSchedule')) DROP TABLE TSchedule
Create Table TSchedule (
ScheduleId int NOT NULL IDENTITY(1,1),
EmployeeId  int FOREIGN KEY REFERENCES TEmployee(EmployeeId ),
[Date] date NOT NULL,
[Shift] nvarchar(50) NOT NULL
)

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'TTimesheet')) DROP TABLE TTimesheet
Create Table TTimesheet (
TimesheetId int NOT NULL IDENTITY(1,1),
EmployeeId  int FOREIGN KEY REFERENCES TEmployee(EmployeeId ),
[Date] date NOT NULL,
CLockInTime time NOT NULL,
ClockOutTime time NOT NULL,
TotalHours numeric(4,2) NOT NULL,
)

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'TPayslip')) DROP TABLE TPayslip
Create Table TPayslip (
PaySlipId int NOT NULL IDENTITY(1,1) PRIMARY KEY,
EmployeeId  int FOREIGN KEY REFERENCES TEmployee(EmployeeId ),
DateFrom date NOT NULL,
EndDate date NOT NULL,
TotalHours numeric(4,2) NOt NULL,
TotalMoney money NOT NULL,
)

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'TUserLogin')) DROP TABLE TUserLogin
Create Table TUserLogin (
UserId int NOT NULL IDENTITY(1,1) PRIMARY KEY,
EmployeeId  int FOREIGN KEY REFERENCES TEmployee(EmployeeId ),
UserName nvarchar(100) NOT NULL,
[Password] nvarchar(100) NOT NULL,
)


