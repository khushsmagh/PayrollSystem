using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payroll_system
{
    public class Schedule
    {
        private DateTime StartDate;
        private DateTime EndDate;
        private int UserId;

        public Schedule(int userId, DateTime start, DateTime end)
        {
            this.UserId = userId;
            this.StartDate = start;
            this.EndDate = end;
        }


        public void PopulateSchedule(DataGridView dg)
        {
            PayrollQuery pq = new PayrollQuery();
            DateTime dateInc = StartDate;
            dg.Rows.Clear();
            for (int i = 0; i <= (EndDate - StartDate).Days; i++)
            {
                string shift;
                try
                {
                    shift = pq.GetScheduleInfo(UserId, dateInc)[0].Shift;
                }
                catch (Exception)
                {
                    shift = "OFF";
                }
                dg.Rows.Add(dateInc.ToString().Substring(0, 10),
                    dateInc.DayOfWeek, shift);
                dateInc = dateInc.AddDays(1);
            }
        }
    }
}
