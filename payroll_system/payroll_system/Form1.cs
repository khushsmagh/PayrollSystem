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
            pi.LoadInfo(employee_name, first_name, last_name, dob, position, date_hired, hourly_rate);
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

  
        private void Schedule_Search_Button_Click(object sender, EventArgs e)
        {
            DateTime start = S_Start.Value;
            DateTime end = S_End.Value;
            if (end > start)
            {
                Schedule schedule = new Schedule(_UserId, start, end);
                schedule.PopulateSchedule(ScheduleDataGrid);
                ScheduleDataGrid.Update();
            }
            else
            {
                MessageBox.Show("End date should be greater the start date.");
            }
        }

        private void Timesheet_Search_Button_Click(object sender, EventArgs e)
        {
            DateTime start = TS_Start.Value;
            DateTime end = TS_End.Value;
            if (end > start)
            {
                Timesheet timesheet = new Timesheet(_UserId, start, end);
                timesheet.PopulateTimesheet(TimesheetDataGrid);
                ScheduleDataGrid.Update();
            }
            else
            {
                MessageBox.Show("End date should be greater the start date.");
            }
        }

        private void GeneratePayslip_Button_Click(object sender, EventArgs e)
        {
            if ((PS_EndDate.Value - PS_StartDate.Value).Days > 0)
            {
                Payslip payslip = new Payslip(this.UserId, PS_StartDate.Value, PS_EndDate.Value);
                payslip.AddPayslipToDB();
            }
            else
            {
                MessageBox.Show("Dates should 1 or more days apart");
            }
        }
    }
}
