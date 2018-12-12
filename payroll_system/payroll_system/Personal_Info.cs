using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payroll_system
{
    class Personal_Info
    {
        public int EmployeeId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string DateOfBirth { get; private set; }
        public string Position { get; private set; }
        public string DateHired { get; private set; }
        public decimal PayRate { get; private set; }


        public Personal_Info(int userId)
        {
            this.EmployeeId = userId;
            SetInfo();
        }

        private void SetInfo()
        {
            PayrollQuery payroll = new PayrollQuery();
            this.FirstName = payroll.GetEmployeeInfo(EmployeeId).ToList()[0].FirstName;
            this.LastName = payroll.GetEmployeeInfo(EmployeeId).ToList()[0].LastName;
            this.DateOfBirth = payroll.GetEmployeeInfo(EmployeeId).ToList()[0].DOB.ToShortDateString();
            this.Position = payroll.GetEmployeeInfo(EmployeeId).ToList()[0].Position;
            this.DateHired = payroll.GetEmployeeInfo(EmployeeId).ToList()[0].DateHired.ToShortDateString();
            this.PayRate = payroll.GetEmployeeInfo(EmployeeId).ToList()[0].HourlyRate;
        }

        public void LoadInfo(Label employeeName, Label firstN, Label lastN, Label dob, Label pos, Label dateH, Label hr)
        {
            employeeName.Text = FirstName + " " + LastName;
            firstN.Text = FirstName;
            lastN.Text = LastName;
            dob.Text = DateOfBirth;
            pos.Text = Position;
            dateH.Text = DateHired;
            hr.Text = "$ " + Math.Round(PayRate, 2).ToString();
        }
    

    }
}
