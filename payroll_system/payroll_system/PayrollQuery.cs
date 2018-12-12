using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payroll_system
{
    class PayrollQuery
    {
        public List<TEmployee> GetEmployeeDetails(string firstname)
        {
            LinqToSQLDataContext db = new LinqToSQLDataContext();
            var query = db.ExecuteQuery<TEmployee>(@"SELECT * FROM TEmployee WHERE FirstName = {0}", firstname);
            return query.ToList();
        }

        public List<TSchedule> GetEmployeeScheduled(string schedule)
        {
            LinqToSQLDataContext db = new LinqToSQLDataContext();
            var query = db.ExecuteQuery<TSchedule>(@"SELECT * FROM TSchedule WHERE [Date] = {0}", schedule);
            return query.ToList();
        }
        public List<TEmployee> GetEmployeeInfo(int id)
        {
            LinqToSQLDataContext db = new LinqToSQLDataContext();
            var query = db.ExecuteQuery<TEmployee>(@"SELECT * FROM TEmployee WHERE EmployeeId = {0}", id);
            return query.ToList();
        }

        public List<TSchedule> GetScheduleInfo(int id, DateTime date)
        {
            LinqToSQLDataContext db = new LinqToSQLDataContext();
            string sqlDate = "'" + date.ToShortDateString() + "'";
            var query = db.ExecuteQuery<TSchedule>(@"SELECT * FROM TSchedule WHERE EmployeeId = " + id + " AND [Date] = " + sqlDate);
            return query.ToList();

        }



        public List<TTimesheet> GetTimesheetInfo(int id, DateTime date)
        {
            LinqToSQLDataContext db = new LinqToSQLDataContext();
            string sqlDate = "'" + date.ToShortDateString() + "'";
            var query = db.ExecuteQuery<TTimesheet>(@"SELECT * FROM TTimesheet WHERE EmployeeId = " + id + " AND [Date] = " + sqlDate);
            return query.ToList();
        }

        public void AddToPayslip(int id, DateTime start, DateTime end, decimal totalHours, decimal totalMoney)
        {
            LinqToSQLDataContext db = new LinqToSQLDataContext();
            try
            {
                db.ExecuteQuery<TPayslip>(@"INSERT INTO TPayslip (EmployeeId, DateFrom, EndDate, TotalHours, ToTalMoney) 
                                        Values (" + id + ", '" + start.ToShortDateString() + "', '" + end.ToShortDateString() + "', " + totalHours + ", " + totalMoney + ")");
            }
            catch (Exception)
            {

            }
        }

        

        public List<TUserLogin> GetUserLoginsPermission(string nameOfuser)
        {
            LinqToSQLDataContext db = new LinqToSQLDataContext();
            var query = db.ExecuteQuery<TUserLogin>(@"SELECT * FROM TUserLogin where UserName = '" + nameOfuser + "'");
            return query.ToList();
        }

        public List<TPayslip> GetUserPaySlip(int empId)
        {
            LinqToSQLDataContext db = new LinqToSQLDataContext();
            var query = db.ExecuteQuery<TPayslip>(@"SELECT * FROM TPayslip where EmployeeId = {0}", empId);
            return query.ToList();
        }

        public List<TTimesheet> EmployeeClockIn(int EmpId)
        {
            DateTime dateTime = DateTime.Now;
            string time = "HH:mm:ss";
            string date = "yyyy-MM-dd";
            LinqToSQLDataContext db = new LinqToSQLDataContext();
            var checkIfEmpIsClockedIn = db.ExecuteQuery<TTimesheet>(@"SELECT * FROM TTimesheet WHERE EmployeeId = {0} AND [Date] = {1}", EmpId, dateTime.ToString(date)).ToList();
                
            if (checkIfEmpIsClockedIn.Count > 0)
            {
                if (checkIfEmpIsClockedIn[0].CLockInTime == TimeSpan.Zero)
                {
                    var query = db.ExecuteQuery<TTimesheet>(@"INSERT INTO [dbo].[TTimesheet] ([EmployeeId], [Date], [CLockInTime], [ClockOutTime], [TotalHours]) VALUES ({0}, {1}, {2}, {3}, {4});
                                                              SELECT TimesheetId, EmployeeId, Date, CLockInTime, ClockOutTime, TotalHours FROM TTimesheet WHERE (TimesheetId = SCOPE_IDENTITY())", EmpId, dateTime, dateTime.ToString(time), string.Empty, 0);
                    MessageBox.Show("Successfully clocked in");
                    return query.ToList();
                }
                else
                {
                    MessageBox.Show("you are already logged in");
                }
            }
            else
            {
                var query = db.ExecuteQuery<TTimesheet>(@"INSERT INTO [dbo].[TTimesheet] ([EmployeeId], [Date], [CLockInTime], [ClockOutTime], [TotalHours]) VALUES ({0}, {1}, {2}, {3}, {4});
                                                        SELECT TimesheetId, EmployeeId, Date, CLockInTime, ClockOutTime, TotalHours FROM TTimesheet WHERE (TimesheetId = SCOPE_IDENTITY())", EmpId, dateTime, dateTime.ToString(time), string.Empty, 0);
                MessageBox.Show("Successfully clocked in");
                return query.ToList();
            }
            return null;
        }

        public void EmployeeClockOut(int EmpId)
        {

            DateTime dateTime = DateTime.Now;
            string time = "HH:mm:ss";
            string date = "yyyy-MM-dd";
            LinqToSQLDataContext db = new LinqToSQLDataContext();
            var checkIfEmpIsClockedOut = db.ExecuteQuery<TTimesheet>(@"SELECT * FROM TTimesheet WHERE EmployeeId = {0} AND [Date] = {1}", EmpId, dateTime.ToString(date)).ToList();

            if (checkIfEmpIsClockedOut.Count > 0)
            {
                if (checkIfEmpIsClockedOut[0].CLockInTime == TimeSpan.Zero)
                {
                    MessageBox.Show("You have to first clock in");
                }
                else
                {
                    if (checkIfEmpIsClockedOut[0].ClockOutTime == TimeSpan.Zero)
                    {
                        var query = db.ExecuteQuery<TTimesheet>(@"UPDATE [dbo].[TTimesheet] SET  [ClockOutTime] = {0} WHERE ([EmployeeId] = {1}) AND ([Date] = {2});
                                                                  SELECT TimesheetId, EmployeeId, Date, CLockInTime, ClockOutTime, TotalHours FROM TTimesheet",
                                                                  dateTime.ToString(time), EmpId, dateTime.ToString(date));


                    }
                    else
                    {
                        MessageBox.Show("you are already clocked out");
                    }
                }
            }
            else
            {
                MessageBox.Show("You have to first clock in");
            }

        }

        public void InsertTotalHours(int EmpId)
        {
            DateTime dateTime = DateTime.Now;
            string time = "HH:mm:ss";
            string date = "yyyy-MM-dd";
            LinqToSQLDataContext db = new LinqToSQLDataContext();
            var getClockOutTime = db.ExecuteQuery<TTimesheet>(@"SELECT * FROM TTimesheet WHERE EmployeeId = {0} AND [Date] = {1}", EmpId, dateTime.ToString(date)).ToList();
            if (getClockOutTime[0].ClockOutTime != TimeSpan.Zero)
            {

                TimeSpan clockInTime = getClockOutTime[0].CLockInTime;
                TimeSpan clockOutTime = getClockOutTime[0].ClockOutTime;
                TimeSpan timeDiff = clockOutTime - clockInTime;

                decimal totalHours = Convert.ToDecimal(timeDiff.TotalHours);
                var insertTime = db.ExecuteQuery<TTimesheet>(@"UPDATE [dbo].[TTimesheet] SET  [TotalHours] = {0} WHERE ([EmployeeId] = {1}) AND ([Date] = {2});
                                                                        SELECT TimesheetId, EmployeeId, Date, CLockInTime, ClockOutTime, TotalHours FROM TTimesheet", totalHours, EmpId, dateTime.ToString(date));

                MessageBox.Show("successfully clockout");

            }
            else
            {
                MessageBox.Show("first clockout Yourself");
            }
        }
    }
}