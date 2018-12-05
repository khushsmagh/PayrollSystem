using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payroll_system
{
    public class Timesheet
    {
        private DateTime StartDate;
        private DateTime EndDate;
        private int UserId;
        

        public static void PopulateTimesheet(DataGridView dg, int id)
        {
            for (int i = 0; i < PayrollQuery.GetTimesheetInfo(id).ToList().Count; i++)
            {
                dg.Rows.Add(
                    PayrollQuery.GetTimesheetInfo(id)[i].Date.ToString().Substring(0,10), 
                    PayrollQuery.GetTimesheetInfo(id)[i].Date.DayOfWeek,
                    PayrollQuery.GetTimesheetInfo(id)[i].CLockInTime,
                    PayrollQuery.GetTimesheetInfo(id)[i].ClockOutTime);
            }
        }

        

    }
}
