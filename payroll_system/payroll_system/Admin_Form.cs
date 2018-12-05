using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payroll_system
{
    public partial class Admin_Form : Form
    {
        public DataTable employeeTable;
        public DataTable selectedEmployeeTable;
        public DataTable selectedEmployeeTimesheetTable;
        public Admin_Form()
        {
            InitializeComponent();
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {
            PopulateDataIntoForm();
        }

        private void editEmployeeInfoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void PopulateDataIntoForm()
        {
            employeeTable = new DataTable();
            LinqToSQLDataContext employeeData = new LinqToSQLDataContext();
            var query = employeeData.ExecuteQuery<TEmployee>(@"SELECT * FROM TEmployee").ToList();
            employeeListGridView.DataSource = query;
            ShowScheduleOfSelectedEmployee();
            ShowTimesheetOfSelectedEmployee();
        }

        public void ShowScheduleOfSelectedEmployee()
        {
            selectedEmployeeTable = new DataTable();
            LinqToSQLDataContext employeeData = new LinqToSQLDataContext();
            var query = employeeData.ExecuteQuery<TSchedule>(@"SELECT * FROM TSchedule").ToList();
            editEmployeeScheduleDataGridView.DataSource = query;
        }

        public void ShowTimesheetOfSelectedEmployee()
        {
            selectedEmployeeTimesheetTable = new DataTable();
            LinqToSQLDataContext employeeData = new LinqToSQLDataContext();
            var query = employeeData.ExecuteQuery<TTimesheet>(@"SELECT * FROM TTimesheet").ToList();
            editEmployeeTimesheetDataGridView.DataSource = query;
        }

        private void deleteTimesheetButton_Click(object sender, EventArgs e)
        {

        }

        private void selectedEmployee(object sender, DataGridViewCellEventArgs e)
        {
            var employeeId = editEmployeeTimesheetDataGridView.Rows[e.RowIndex].Cells[0].Value;
            MessageBox.Show(employeeId.ToString());
        }
    }
}
