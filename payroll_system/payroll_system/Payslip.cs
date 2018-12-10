using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payroll_system
{
    class Payslip
    {
        int UserId;
        DateTime DateStart;
        DateTime DateEnd;
        decimal TotalHours;
        decimal TotalPay;
        decimal PayRate;
        
        public Payslip(int userId, DateTime start, DateTime end)
        {
            PayrollQuery pq = new PayrollQuery();
            this.UserId = userId;
            this.DateStart = start;
            this.DateEnd = end;
            this.PayRate = pq.GetEmployeeInfo(UserId)[0].HourlyRate;
            
            CalculatePay();

        }


        void CalculatePay()
        {
            PayrollQuery pq = new PayrollQuery();
            DateTime date = DateStart;
            decimal hours;
            for(int i = 0; i < (DateEnd - DateStart).Days; i++)
            {
                try
                {
                    hours = pq.GetTimesheetInfo(UserId, date)[0].TotalHours;
                  
                }
                catch (Exception e)
                {
                    hours = 0;
                }
                TotalHours += hours;
                date = date.AddDays(1);
            }
            
            TotalPay = TotalHours * PayRate;
        }

        public void AddPayslipToDB()
        {
            PayrollQuery pq = new PayrollQuery();
            pq.AddToPayslip(UserId, DateStart, DateEnd, TotalHours, TotalPay);
        }
        
    }
}
