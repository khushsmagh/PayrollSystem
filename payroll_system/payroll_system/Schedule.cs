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
            PayrollQuery payroll = new PayrollQuery();

            for (int i = 0; i < payroll.GetScheduleInfo(userId).ToList().Count; i++)
            {
                dg.Rows.Add(payroll.GetScheduleInfo(userId).ToList()[i].Date.ToString().Substring(0, 10),
                    payroll.GetScheduleInfo(userId).ToList()[i].Date.DayOfWeek,
                    payroll.GetScheduleInfo(userId).ToList()[i].Shift);
            }
        }

    }
}
