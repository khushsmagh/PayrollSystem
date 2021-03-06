﻿using System;
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
        public Admin_Form(int UserId)
        {
            this._UserId = UserId;
            InitializeComponent();
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {
            PayrollQuery payroll = new PayrollQuery();
            adminNameLabel.Text = payroll.GetEmployeeInfo(this._UserId).ToList()[0].FirstName + " " + payroll.GetEmployeeInfo(this._UserId).ToList()[0].LastName;
            // TODO: This line of code loads data into the 'payrollDataSet.TTimesheet' table. You can move, or remove it, as needed.
            this.tTimesheetTableAdapter.Fill(this.payrollDataSet.TTimesheet);
            // TODO: This line of code loads data into the 'payrollDataSet.TEmployee' table. You can move, or remove it, as needed.
            this.tEmployeeTableAdapter.Fill(this.payrollDataSet.TEmployee);
            // TODO: This line of code loads data into the 'payrollDataSet.TSchedule' table. You can move, or remove it, as needed.
            this.tScheduleTableAdapter.Fill(this.payrollDataSet.TSchedule);
        }

        private void deleteTimesheetButton_Click(object sender, EventArgs e)
        {
            try
            {
                int deleteEmployeeId = Convert.ToInt32(editEmployeeTimesheetDataGridView.CurrentRow.Cells[0].Value);
                tTimesheetTableAdapter.DeleteTimesheetQuery(deleteEmployeeId);
                tTimesheetTableAdapter.Fill(this.payrollDataSet.TTimesheet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong");
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
             int employee = Convert.ToInt32(employeeListGridView.CurrentRow.Cells[0].Value);
            try
            {
                if (scheduleRadioButton.Checked)
                {
                    adminTabControl.SelectedIndex = 1;
                    this.tScheduleTableAdapter.FillBySchedule(this.payrollDataSet.TSchedule , employee);
                }
                else if (timesheetRadioButton.Checked)
                {
                    adminTabControl.SelectedIndex = 2;
                    this.tTimesheetTableAdapter.FillByTimesheet(this.payrollDataSet.TTimesheet, employee);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong! Please check your input");
            }
        }

        private void editScheduleButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tScheduleBindingSource.EndEdit();
                tScheduleTableAdapter.Update(this.payrollDataSet.TSchedule);
                MessageBox.Show("Table has been updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong! Please check your input");
            }
        }

        private void editTimesheetButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tTimesheetBindingSource.EndEdit();
                tTimesheetTableAdapter.Update(this.payrollDataSet.TTimesheet);
                MessageBox.Show("Table has been updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong! Please check your input");
            }
        }

        private void deleteSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                int deleteScheduleId = Convert.ToInt32(editEmployeeScheduleDataGridView.CurrentRow.Cells[0].Value);
                MessageBox.Show("Are you sure you want to delete schedule at " + deleteScheduleId);
                tScheduleBindingSource.EndEdit();
                tScheduleTableAdapter.DeleteScheduleQuery(deleteScheduleId);
                tScheduleTableAdapter.Fill(this.payrollDataSet.TSchedule);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong! Please check your input");
            }
        }

        private void searchEmployeeDetailsButton_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = getEmployeeTextBox.Text;
                employeeTable = new DataTable();
                PayrollQuery pq = new PayrollQuery();
                searchDataGridView.DataSource = pq.GetEmployeeDetails(firstName);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong! Please check your input");
            }
        }

        private void searchScheduleForThatDateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string schedule = scheduleDate.Value.ToString().Substring(0, 10);
                PayrollQuery pq = new PayrollQuery();
                searchDataGridView.DataSource = pq.GetEmployeeScheduled(schedule);
                searchDataGridView.Columns.Remove("TEmployee");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong! Please check your input");
            }
        }
    }
}
