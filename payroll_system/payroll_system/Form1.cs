using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;

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
            Payslip.LoadPayslip(showPayslipOnDataGridView, this._UserId);      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPayslip.Print();
        }

        private void printPayslip_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.Editing_Circle_SGBerlin;
            Image image = bmp;
            PayrollQuery payroll = new PayrollQuery();
            int index = showPayslipOnDataGridView.CurrentRow.Index;
            employeeName = payroll.GetEmployeeInfo(_UserId).ToList()[0].FirstName + payroll.GetEmployeeInfo(_UserId).ToList()[0].LastName;
            dateFrom = showPayslipOnDataGridView.Rows[index].Cells["DateFrom"].Value.ToString();
            endDate = showPayslipOnDataGridView.Rows[index].Cells["EndDate"].Value.ToString();
            totalHours = (decimal)showPayslipOnDataGridView.Rows[index].Cells["TotalHours"].Value;
            totalMoney = totalHours * payroll.GetEmployeeInfo(_UserId)[0].HourlyRate;

            e.Graphics.DrawImage(bmp, 365, 0, 150,150);
            e.Graphics.DrawString("Employee Name : " + employeeName, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(300, 200));
            e.Graphics.DrawString("-----------------------------------------------------", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(300, 250));
            e.Graphics.DrawString("DateFrom : " + dateFrom.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(300, 300));
            e.Graphics.DrawString("-----------------------------------------------------", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(300, 350));
            e.Graphics.DrawString("EndDate : " + endDate.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(300, 400));
            e.Graphics.DrawString("-----------------------------------------------------", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(300, 450));
            e.Graphics.DrawString("TotalHours : " + totalHours.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(300, 500));
            e.Graphics.DrawString("-----------------------------------------------------", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(300, 550));
            e.Graphics.DrawString("TotalMoney :" + totalMoney.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(300, 600));
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
                showPayslipOnDataGridView.DataSource = payslip.AddPayslipToDB();
                Payslip.LoadPayslip(showPayslipOnDataGridView, this._UserId);
                //showPayslipOnDataGridView.Columns.Remove("TEmployee");
            }
            else
            {
                MessageBox.Show("Dates should 1 or more days apart");
            }

        }

        private void addToGoogleButton_Click_1(object sender, EventArgs e)
        {
            int getYeayOfDate;
            int getMonthOfDate;
            int getDayOfDate;

            var getShiftTime = ScheduleDataGrid.CurrentRow.Cells[2].Value.ToString();
            if(getShiftTime != "OFF")
            {
                var getDate = ScheduleDataGrid.CurrentRow.Cells[0].Value.ToString();
                string[] getShiftDate = getDate.Split('/');
                MessageBox.Show(getShiftDate.Length + " ::: " + getShiftDate.Count().ToString());
                if (getShiftDate.Length <= 1)
                {
                    getShiftDate = getDate.Split('-');
                    getYeayOfDate = Convert.ToInt32(getShiftDate[0]);
                    getMonthOfDate = Convert.ToInt32(getShiftDate[1]);
                    getDayOfDate = Convert.ToInt32(getShiftDate[2]);
                }
                else
                {
                    getYeayOfDate = Convert.ToInt32(getShiftDate[2]);
                    getMonthOfDate = Convert.ToInt32(getShiftDate[0]);
                    getDayOfDate = Convert.ToInt32(getShiftDate[1]);
                }

                string[] shift = getShiftTime.Split('-');

                var shiftStart = TimeSpan.ParseExact(shift[0], "hhmm", null);
                var shiftEnd = TimeSpan.ParseExact(shift[1], "hhmm", null);

                var shiftStartHours = shiftStart.Hours;
                var shiftStartMinutes = shiftStart.Minutes;
                var shiftEndHours = shiftEnd.Hours;
                var shiftEndMinutes = shiftEnd.Minutes;

                UserCredential credential = GoogleWebAuthorizationBroker.AuthorizeAsync
                (
                    new ClientSecrets
                    {
                        ClientId = "731857075546-qtta3f8nfjcd8gthqcfcq1ji5b8bdcmc.apps.googleusercontent.com",
                        ClientSecret = "1WSos4uhv0rmHrvL-WmUs5FC",
                    },
                    new[] { CalendarService.Scope.Calendar },
                    "user",
                        CancellationToken.None).Result;

                // Create the service.
                var service = new CalendarService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "AppForAddDateToCalender",
                });


                Event myEvent = new Event
                {
                    Summary = "Schedule",
                    Location = "Bow valley",
                    Start = new EventDateTime()
                    {
                        DateTime = new DateTime(getYeayOfDate, getMonthOfDate, getDayOfDate, shiftStartHours, shiftStartMinutes, 0),
                        TimeZone = "America/Los_Angeles"
                    },

                    End = new EventDateTime()
                    {
                        DateTime = new DateTime(getYeayOfDate, getMonthOfDate, getDayOfDate, shiftEndHours, shiftStartMinutes, 0),
                        TimeZone = "America/Los_Angeles"
                    },

                    Attendees = new List<EventAttendee>()
                {
                    new EventAttendee() { Email = "sodv2202.jks@gmail.com" }
                }
                };
                Event recurringEvent = service.Events.Insert(myEvent, "primary").Execute();
                MessageBox.Show("Your schedule has been successfully uploaded to google calendar");
            }
            else
            {
                MessageBox.Show("You have no shift on this day");
            }
            
        }
    }
}
