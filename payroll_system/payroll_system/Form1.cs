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
    public partial class Payroll : Form
    {
        private int _UserId;
        public int UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                _UserId = value;
            }
        }
      

        public Payroll(int UserId)
        {
            this._UserId = UserId;
            InitializeComponent();
           
        }

        private void Payroll_Load(object sender, EventArgs e)
        {
            Personal_Info pi = new Personal_Info(_UserId);
            employee_name.Text = pi.FirstName + pi.LastName;
            first_name.Text = pi.FirstName;
            last_name.Text = pi.LastName;
            dob.Text = pi.DateOfBirth;
            position.Text = pi.Position;
            date_hired.Text = pi.DateHired;
            hourly_rate.Text = "$ " + Math.Round(pi.PayRate, 2).ToString();


            Schedule.PopulateSchedule(ScheduleDataGrid, _UserId);
            Timesheet.PopulateTimesheet(TimesheetDataGrid, _UserId);

        }

        

        
    }
}
