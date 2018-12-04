using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace payroll_system
{
    public partial class Payroll : Form
    {
        string employeeName;
        DateTime dateFrom;
        DateTime endDate;
        decimal totalHours;
        decimal totalMoney;

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
            PayrollQuery payroll = new PayrollQuery();

            string fn = payroll.GetEmployeeInfo(_UserId)[0].FirstName;
            string ln = payroll.GetEmployeeInfo(_UserId)[0].LastName;
            string dobM = payroll.GetEmployeeInfo(_UserId)[0].DOB.Month.ToString();
            string dobD = payroll.GetEmployeeInfo(_UserId)[0].DOB.Day.ToString();
            string dobY = payroll.GetEmployeeInfo(_UserId)[0].DOB.Year.ToString();
            decimal hr = payroll.GetEmployeeInfo(_UserId)[0].HourlyRate;

            employee_name.Text = fn + " " + ln;
            first_name.Text = fn;
            last_name.Text = ln;
            dob.Text = dobM + "/" + dobD + "/" + dobY;
            position.Text = payroll.GetEmployeeInfo(_UserId).ToList()[0].Position;
            date_hired.Text = payroll.GetEmployeeInfo(_UserId).ToList()[0].DateHired.ToString();
            hourly_rate.Text = "$ " + Math.Round(hr, 2).ToString();
        }

        private void PaySlipClick(object sender, EventArgs e)
        {
            PayrollQuery payroll = new PayrollQuery();
            employeeName = payroll.GetEmployeeInfo(_UserId).ToList()[0].FirstName + payroll.GetEmployeeInfo(_UserId).ToList()[0].LastName;
            dateFrom =  payroll.GetUserPaySlip(_UserId)[0].DateFrom;
            endDate = payroll.GetUserPaySlip(_UserId)[0].EndDate;
            totalHours = payroll.GetUserPaySlip(_UserId)[0].TotalHours;
            totalMoney = totalHours * payroll.GetEmployeeInfo(_UserId)[0].HourlyRate;
            dataGridView1.DataSource = payroll.GetUserPaySlip(_UserId);

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPayslip.Print();
        }

        private void printPayslip_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Employee Name : " + employeeName, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0, 0));
            e.Graphics.DrawString("DateFrom : " + dateFrom.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0, 25));
            e.Graphics.DrawString("EndDate : " + endDate.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0, 50));
            e.Graphics.DrawString("TotalHours : " + totalHours.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0, 75));
            e.Graphics.DrawString("TotalMoney :" + totalMoney.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0, 100));
        }
    }
}
