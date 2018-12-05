INSERT INTO TEmployee ( FirstName, LastName, DOB, DateHired, Position, HourlyRate)
VALUES 
('John' , 'Louis' ,'1991-05-20', '2018-10-15', 'Guard', 20),
('Khushveen', 'Smagh', '1991-03-04', '2018-10-15', 'Admin', 20),
('Sandeep', 'Saini', '1991-10-24', '2018-10-15', 'Stocker', 17),
('Hai', 'Do', '1986-11-20', '2018-09-11', 'Cashier', 25),
('Pablo', 'Winter', '1999-05-18', '2018-10-15', 'Stocker', 17),
('Brijesh', 'Patel', '1988-02-02', '2018-10-15', 'Stocker', 20),
('Anderson', 'Resende Viana', '1975-07-14', '2018-10-15', 'Guard', 21),
('Karamullah', 'Agha', '1995-10-24', '2018-10-15', 'Stocker', 17),
('Nico', 'Beekhuijs', '1970-03-09', '2018-09-01', 'Supervisor', 10),
('Parvir', 'Sandhu', '2001-01-22', '2018-10-15', 'Stocker', 17);

INSERT INTO TUserLogin (EmployeeId, UserName, [Password])
VALUES (1, 'johnl', 'johnl'),
(2, 'khushs', 'khushs'),
(3, 'sandeeps', 'sandeeps'),
(4, 'haid', 'haid'),
(5, 'pablow', 'pablow'),
(6, 'brijeshp', 'brijeshp'),
(7, 'andersonr', 'andersonr'),
(8, 'kara', 'kara'),
(9, 'nicob', 'nicob'),
(10, 'parvirs', 'parvirs');

INSERT INTO TSchedule (EmployeeId, [Date], [Shift])
VALUES (1, '2018-10-15', '0900-1700'),
(3, '2018-10-15', '0900-1700'),
(4, '2018-10-15', '1200-2000'),
(1, '2018-10-16', '0800-1600'),
(3, '2018-10-16', '0800-1600'),
(1, '2018-10-17', '0900-1700'),
(4, '2018-10-17', '0900-1700');


INSERT INTO TTimesheet (EmployeeId, [Date], CLockInTime, ClockOutTime, TotalHours)
VALUES (1, '2018-10-15', '09:00:00', '17:00:00', 8);