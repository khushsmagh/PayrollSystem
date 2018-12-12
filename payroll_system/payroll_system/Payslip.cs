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

        public static void LoadPayslip(DataGridView payslipDataGrid, int id)
        {
            PayrollQuery payroll = new PayrollQuery();
            //employeeName = payroll.GetEmployeeInfo(UserId).ToList()[0].FirstName + payroll.GetEmployeeInfo(UserId).ToList()[0].LastName;
            payslipDataGrid.DataSource = payroll.GetUserPaySlip(id);
            payslipDataGrid.Columns.Remove("TEmployee");
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

        public List<TPayslip> AddPayslipToDB()
        {
            PayrollQuery pq = new PayrollQuery();
            var query = pq.AddToPayslip(UserId, DateStart, DateEnd, TotalHours, TotalPay);
            return query;
        }
        
    }
}
