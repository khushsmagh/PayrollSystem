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
        string employeeName;
        string dateFrom;
        string endDate;
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

        private void PaySlipClick(object sender, EventArgs e)
        {
            PayrollQuery payroll = new PayrollQuery();
            employeeName = payroll.GetEmployeeInfo(_UserId).ToList()[0].FirstName + payroll.GetEmployeeInfo(_UserId).ToList()[0].LastName;
            showPayslipOnDataGridView.DataSource = payroll.GetUserPaySlip(_UserId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPayslip.Print();
        }

        private void printPayslip_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PayrollQuery payroll = new PayrollQuery();
            int index = showPayslipOnDataGridView.CurrentRow.Index;
            dateFrom = showPayslipOnDataGridView.Rows[index].Cells["DateFrom"].Value.ToString();
            endDate = showPayslipOnDataGridView.Rows[index].Cells["EndDate"].Value.ToString();
            totalHours = (decimal)showPayslipOnDataGridView.Rows[index].Cells["TotalHours"].Value;
            totalMoney = totalHours * payroll.GetEmployeeInfo(_UserId)[0].HourlyRate;
            e.Graphics.DrawString("Employee Name : " + employeeName, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0, 0));
            e.Graphics.DrawString("DateFrom : " + dateFrom.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0, 25));
            e.Graphics.DrawString("EndDate : " + endDate.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0, 50));
            e.Graphics.DrawString("TotalHours : " + totalHours.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0, 75));
            e.Graphics.DrawString("TotalMoney :" + totalMoney.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0, 100));
        }




    }
}
