﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Threading;

namespace payroll_system
{
    public partial class User_Login : Form
    {
        private int _EmpId;
        public int EmpId
        {
            get
            {
                return _EmpId;
            }
            set
            {
                _EmpId = value;
            }
        }

        public User_Login()
        {
            InitializeComponent();

        }

        private void User_Login_Load(object sender, EventArgs e)
        {


        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "Username")
            {
                usernameTextBox.Text = "";
            }
            usernameTextBox.ForeColor = Color.Black;
        }

        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "")
            {
                usernameTextBox.Text = "Username";
                usernameTextBox.ForeColor = Color.Silver;
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.Text = "Password";
                passwordTextBox.ForeColor = Color.Silver;
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Password")
            {
                passwordTextBox.Text = "";
            }
            passwordTextBox.ForeColor = Color.Black;
        }

        private void employeeNumberTextBox_Leave(object sender, EventArgs e)
        {
            if (employeeNumberTextBox.Text == "")
            {
                employeeNumberTextBox.Text = "12345";
                employeeNumberTextBox.ForeColor = Color.Silver;
            }
        }

        private void employeeNumberTextBox_Enter(object sender, EventArgs e)
        {
            if (employeeNumberTextBox.Text == "12345")
            {
                employeeNumberTextBox.Text = "";
            }
            employeeNumberTextBox.ForeColor = Color.Black;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            PayrollQuery pq = new PayrollQuery();
            string userName = usernameTextBox.Text;

            List<TUserLogin> userCredential = pq.GetUserLoginsPermission(userName);

            int empId = (int)userCredential[0].EmployeeId;

            string position = pq.GetEmployeeInfo(empId)[0].Position;

            string userPasswordFromDatabase = userCredential[0].Password;
            string inputPassword = passwordTextBox.Text;

            if (usernameTextBox.Text == "" & passwordTextBox.Text == "")
            {
                MessageBox.Show("fields are required");
            }
            else if (userPasswordFromDatabase == inputPassword)
            {
                if(position == "Admin")
                {
                    MessageBox.Show("loggin successfully");
                    Admin_Form admin = new Admin_Form();
                    admin.Show();
                }
                else
                {
                    MessageBox.Show("loggin successfully");
                    EmpId = Int32.Parse((pq.GetUserLoginsPermission(userName)[0].EmployeeId).ToString());
                    Payroll payroll = new Payroll(this._EmpId);
                    payroll.Show();
                }
                
            }
            else
            {
                MessageBox.Show("information is not correct");
                usernameTextBox.Text = string.Empty;
                passwordTextBox.Text = string.Empty;
            }

        }

        private void clockInButton_Click(object sender, EventArgs e)
        {
            EmpId = Int32.Parse(employeeNumberTextBox.Text);
            PayrollQuery pq = new PayrollQuery();
            pq.EmployeeClockIn(EmpId);
        }

        private void clockOutButton_Click(object sender, EventArgs e)
        {
            EmpId = Int32.Parse(employeeNumberTextBox.Text);
            PayrollQuery pq = new PayrollQuery();
            pq.EmployeeClockOut(EmpId);
        }
    }
}
