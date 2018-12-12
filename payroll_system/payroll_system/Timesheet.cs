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

        public Timesheet(int userId, DateTime start, DateTime end)
        {
            this.UserId = userId;
            this.StartDate = start;
            this.EndDate = end;
        }
        

        public void PopulateTimesheet(DataGridView dg)
        {
            PayrollQuery pq = new PayrollQuery();
            DateTime dateInc = StartDate;
            dg.Rows.Clear();
            for (int i = 0; i <= (EndDate - StartDate).Days; i++)
            {
                string clockIn;
                string clockOut;
                string shift;
                try
                {
                    clockIn = pq.GetTimesheetInfo(UserId, dateInc)[0].CLockInTime.ToString();
                }
                catch (Exception)
                {
                    clockIn = "---";
                }
                try
                {
                    clockOut = pq.GetTimesheetInfo(UserId, dateInc)[0].ClockOutTime.ToString();
                }
                catch (Exception)
                {
                    clockOut = "---";
                }
                try
                {
                    shift = pq.GetScheduleInfo(UserId, dateInc)[0].Shift;
                }
                catch (Exception)
                {
                    shift = "OFF";
                }
                dg.Rows.Add(dateInc.ToString().Substring(0, 10),
                    dateInc.DayOfWeek, shift, clockIn, clockOut);
                dateInc = dateInc.AddDays(1);
            }
        }

        

    }
}
