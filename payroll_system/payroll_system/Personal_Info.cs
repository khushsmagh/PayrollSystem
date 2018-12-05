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
            string dobM = payroll.GetEmployeeInfo(EmployeeId).ToList()[0].DOB.Month.ToString();
            string dobD = payroll.GetEmployeeInfo(EmployeeId).ToList()[0].DOB.Day.ToString();
            string dobY = payroll.GetEmployeeInfo(EmployeeId).ToList()[0].DOB.Year.ToString();
            this.DateOfBirth = dobM + "-" + dobD + "-" + dobY;
            this.Position = payroll.GetEmployeeInfo(EmployeeId).ToList()[0].Position;
            this.DateHired = payroll.GetEmployeeInfo(EmployeeId).ToList()[0].DateHired.ToString();
            this.PayRate = payroll.GetEmployeeInfo(EmployeeId).ToList()[0].HourlyRate;
        }

    

    }
}
