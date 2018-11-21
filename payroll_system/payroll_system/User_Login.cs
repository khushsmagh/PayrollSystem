using System;
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


namespace payroll_system
{
    public partial class User_Login : Form
    {
        public static String str = "Server=199.103.60.77;Database=ssaini516;UID=ssaini516;Password=6384344933383240";
        SqlConnection con = new SqlConnection(str);
        public User_Login()
        {
            InitializeComponent();

        }

        private void User_Login_Load(object sender, EventArgs e)
        {
            try

            {
                con.Open();

            }

            catch (Exception es)

            {

                MessageBox.Show(es.Message);



            }

        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            if(usernameTextBox.Text == "Username")
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
            if(employeeNumberTextBox.Text == "")
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
            string userName = usernameTextBox.Text;
            MessageBox.Show(userName);
            int password = int.Parse(passwordTextBox.Text);
            var query = "select CustomerId from Customer where CustomerName  = " + "'"+ userName + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if(password == int.Parse(reader[0].ToString()))
                {
                    MessageBox.Show("succefully logged in");
                }
                else
                {
                    MessageBox.Show("password is wrong");
                }
            }
            reader.Close();
            con.Close();

        }
    }
}
