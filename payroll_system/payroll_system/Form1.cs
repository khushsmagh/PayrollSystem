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
        int UserId = 1;
      

        public Payroll()
        {
            InitializeComponent();
           
        }

        private void Payroll_Load(object sender, EventArgs e)
        {
            string fn = PayrollQuery.GetEmployeeInfo(UserId).ToList()[0].FirstName;
            string ln = PayrollQuery.GetEmployeeInfo(UserId).ToList()[0].LastName;
            string dobM = PayrollQuery.GetEmployeeInfo(UserId).ToList()[0].DOB.Month.ToString();
            string dobD = PayrollQuery.GetEmployeeInfo(UserId).ToList()[0].DOB.Day.ToString();
            string dobY = PayrollQuery.GetEmployeeInfo(UserId).ToList()[0].DOB.Year.ToString();
            decimal hr = PayrollQuery.GetEmployeeInfo(UserId).ToList()[0].HourlyRate;

            employee_name.Text = fn + " " + ln;
            first_name.Text = fn;
            last_name.Text = ln;
            dob.Text = dobM + "/" + dobD + "/" + dobY;
            position.Text = PayrollQuery.GetEmployeeInfo(UserId).ToList()[0].Position;
            date_hired.Text = PayrollQuery.GetEmployeeInfo(UserId).ToList()[0].DateHired.ToString();
            hourly_rate.Text = "$ " + Math.Round(hr, 2).ToString();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
