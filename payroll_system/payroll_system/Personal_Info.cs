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
            this.FirstName = PayrollQuery.GetEmployeeInfo(EmployeeId).ToList()[0].FirstName;
            this.LastName = PayrollQuery.GetEmployeeInfo(EmployeeId).ToList()[0].LastName;
            string dobM = PayrollQuery.GetEmployeeInfo(EmployeeId).ToList()[0].DOB.Month.ToString();
            string dobD = PayrollQuery.GetEmployeeInfo(EmployeeId).ToList()[0].DOB.Day.ToString();
            string dobY = PayrollQuery.GetEmployeeInfo(EmployeeId).ToList()[0].DOB.Year.ToString();
            this.DateOfBirth = dobM + "-" + dobD + "-" + dobY;
            this.Position = PayrollQuery.GetEmployeeInfo(EmployeeId).ToList()[0].Position;
            this.DateHired = PayrollQuery.GetEmployeeInfo(EmployeeId).ToList()[0].DateHired.ToString();
            this.PayRate = PayrollQuery.GetEmployeeInfo(EmployeeId).ToList()[0].HourlyRate;
        }

    

    }
}
