IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'PR_Employee')) DROP TABLE PR_Employee
Create Table PR_Employee (
EmployeeId int NOT NULL IDENTITY(1,1) PRIMARY KEY,
FirstName nvarchar(255) NOT NULL,
LastName nvarchar(255) NOT NULL,
DOB date NOT NULL,
DateHired date NOt NULL,
Position nvarchar(100) NOT NULL,
HourlyRate money NOT NULL,
)


IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'PR_Schedule')) DROP TABLE PR_Schedule
Create Table PR_Schedule (
EmployeeId  int FOREIGN KEY REFERENCES PR_Employee(EmployeeId ),
[Date] date NOT NULL,
[Shift] nvarchar(50) NOT NULL
)

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'PR_Timesheet')) DROP TABLE PR_Timesheet
Create Table PR_Timesheet (
EmployeeId  int FOREIGN KEY REFERENCES PR_Employee(EmployeeId ),
[Date] date NOT NULL,
CLockInTime time NOT NULL,
ClockOutTime time NOt NULL,
TotalHours numeric(4) NOT NULL,
)

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'PR_Payslip')) DROP TABLE PR_Payslip
Create Table PR_Payslip (
PaySlipId int NOT NULL IDENTITY(1,1) PRIMARY KEY,
EmployeeId  int FOREIGN KEY REFERENCES PR_Employee(EmployeeId ),
DateFrom date NOT NULL,
EndDate date NOT NULL,
TotalHours numeric(4) NOt NULL,
TotalMoney money NOT NULL,
)

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'PR_User_Login')) DROP TABLE PR_User_Login
Create Table PR_User_Login (
UserId int NOT NULL IDENTITY(1,1) PRIMARY KEY,
EmployeeId  int FOREIGN KEY REFERENCES PR_Employee(EmployeeId ),
UserName nvarchar(100) NOT NULL,
[Password] nvarchar(100) NOT NULL,
)


