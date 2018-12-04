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
        public static void PopulateSchedule(DataGridView dg, int userId)
        {
            for (int i = 0; i < PayrollQuery.GetScheduleInfo(userId).ToList().Count; i++)
            {
                dg.Rows.Add(PayrollQuery.GetScheduleInfo(userId).ToList()[i].Date.ToString().Substring(0, 10),
                    PayrollQuery.GetScheduleInfo(userId).ToList()[i].Date.DayOfWeek,
                    PayrollQuery.GetScheduleInfo(userId).ToList()[i].Shift);
            }
        }

    }
}
