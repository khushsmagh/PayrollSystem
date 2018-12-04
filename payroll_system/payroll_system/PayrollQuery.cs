using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll_system
{
    class PayrollQuery
    {
        
        public static IEnumerable<TEmployee> GetEmployeeInfo(int id)
        {
            LinqToSQLDataContext db = new LinqToSQLDataContext();
            var query = db.ExecuteQuery<TEmployee>(@"SELECT * FROM TEmployee WHERE EmployeeId = {0}", id);
            return query;
        }

        public static IEnumerable<TSchedule> GetScheduleInfo(int id)
        {
            LinqToSQLDataContext db = new LinqToSQLDataContext();
            var query = db.ExecuteQuery<TSchedule>(@"SELECT * FROM TSchedule WHERE EmployeeId = {0}", id);
            return query;

        }

        public static IEnumerable<TTimesheet> GetTimesheetInfo(int id)
        {
            LinqToSQLDataContext db = new LinqToSQLDataContext();
            var query = db.ExecuteQuery<TTimesheet>(@"SELECT * FROM TTimesheet WHERE EmployeeId = {0}", id);
            return query;
        }

        public List<TUserLogin> GetUserLoginsPermission(string nameOfuser)
        {
            LinqToSQLDataContext db = new LinqToSQLDataContext();
            var query = db.ExecuteQuery<TUserLogin>(@"SELECT * FROM TUserLogin where UserName = '" + nameOfuser + "'");
            return query.ToList();
        }

    }
}