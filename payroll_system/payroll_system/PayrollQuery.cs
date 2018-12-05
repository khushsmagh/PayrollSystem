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

        public List<TEmployee> GetEmployeeInfo(int id)
        {
            LinqToSQLDataContext db = new LinqToSQLDataContext();
            var query = db.ExecuteQuery<TEmployee>(@"SELECT * FROM TEmployee WHERE EmployeeId = {0}", id);
            return query.ToList();
        }

        public List<TSchedule> GetScheduleInfo(int id)
        {
            LinqToSQLDataContext db = new LinqToSQLDataContext();
            var query = db.ExecuteQuery<TSchedule>(@"SELECT * FROM TSchedule WHERE EmployeeId = {0}", id);
            return query.ToList();

        }

        public static List<TTimesheet> GetTimesheetInfo(int id)
        {
            LinqToSQLDataContext db = new LinqToSQLDataContext();
            var query = db.ExecuteQuery<TTimesheet>(@"SELECT * FROM TTimesheet WHERE EmployeeId = {0}", id);
            return query.ToList();
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

        public void EmployeeClockIn(int EmpId)
        {
            DateTime dateTime = DateTime.Now;
            string time = "HH:mm:ss";
            string date = "yyyy-MM-dd";
            LinqToSQLDataContext db = new LinqToSQLDataContext();
            var checkIfEmpIsClockedIn = db.ExecuteQuery<TTimesheet>(@"SELECT CLockInTime FROM TTimesheet WHERE EmployeeId = {0} AND [Date] = {1}",EmpId,dateTime.ToString(date)).ToList();
            if(checkIfEmpIsClockedIn[0].CLockInTime == TimeSpan.Zero)
            {
                var query = db.ExecuteQuery<TTimesheet>(@"INSERT INTO TTimesheet (EmployeeId, [Date], CLockInTime, ClockOutTime, TotalHours)
                                                          VALUES ({0},{1},{2},{3},{4})", EmpId, dateTime, dateTime.ToString(time), string.Empty, 0);
                MessageBox.Show("Successfully clocked in");
            }
            else
            {
                MessageBox.Show("you are already logged in");
            }
        }

        public void EmployeeClockOut(int EmpId)
        {
            DateTime dateTime = DateTime.Now;
            string time = "HH:mm:ss";
            string date = "yyyy-MM-dd";
            LinqToSQLDataContext db = new LinqToSQLDataContext();
            var checkIfEmpIsClockedOut = db.ExecuteQuery<TTimesheet>(@"SELECT ClockOutTime, CLockInTime FROM TTimesheet WHERE EmployeeId = {0} AND [Date] = {1}", EmpId, dateTime.ToString(date)).ToList();

            if (checkIfEmpIsClockedOut[0].ClockOutTime == TimeSpan.Zero)
            {
                TimeSpan clockInTime = checkIfEmpIsClockedOut[0].CLockInTime;
                TimeSpan clockOutTime = checkIfEmpIsClockedOut[0].ClockOutTime;
                TimeSpan timeDiff = clockOutTime.Subtract(clockInTime);
                decimal totalHours = Convert.ToDecimal(timeDiff.TotalHours);
                var query = db.ExecuteQuery<TTimesheet>(@"UPDATE TTimesheet SET ClockOutTime = {0}, TotalHours = {1} WHERE EmployeeId = {2} AND [Date] = {3}", dateTime.ToString(time), totalHours, EmpId, dateTime.ToString(date));
                MessageBox.Show("Successfully clocked out");
            }
            else
            {
                MessageBox.Show("you are already clocked out");
            }
        }
    }
}