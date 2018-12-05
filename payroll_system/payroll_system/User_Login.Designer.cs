namespace payroll_system
{
    partial class User_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginButton = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.clockOutButton = new System.Windows.Forms.Button();
            this.clockInButton = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.employeeNumber = new System.Windows.Forms.Label();
            this.employeeNumberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(101, 325);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(110, 53);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 527);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // clockOutButton
            // 
            this.clockOutButton.Location = new System.Drawing.Point(520, 397);
            this.clockOutButton.Margin = new System.Windows.Forms.Padding(2);
            this.clockOutButton.Name = "clockOutButton";
            this.clockOutButton.Size = new System.Drawing.Size(110, 53);
            this.clockOutButton.TabIndex = 2;
            this.clockOutButton.Text = "Clock-out";
            this.clockOutButton.UseVisualStyleBackColor = true;
            this.clockOutButton.Click += new System.EventHandler(this.clockOutButton_Click);
            // 
            // clockInButton
            // 
            this.clockInButton.Location = new System.Drawing.Point(520, 268);
            this.clockInButton.Margin = new System.Windows.Forms.Padding(2);
            this.clockInButton.Name = "clockInButton";
            this.clockInButton.Size = new System.Drawing.Size(110, 53);
            this.clockInButton.TabIndex = 3;
            this.clockInButton.Text = "Clock-in";
            this.clockInButton.UseVisualStyleBackColor = true;
            this.clockInButton.Click += new System.EventHandler(this.clockInButton_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.Silver;
            this.usernameTextBox.Location = new System.Drawing.Point(87, 110);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(148, 29);
            this.usernameTextBox.TabIndex = 4;
            this.usernameTextBox.Text = "Username";
            this.usernameTextBox.Enter += new System.EventHandler(this.usernameTextBox_Enter);
            this.usernameTextBox.Leave += new System.EventHandler(this.usernameTextBox_Leave);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.Silver;
            this.passwordTextBox.Location = new System.Drawing.Point(87, 224);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(148, 29);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // employeeNumber
            // 
            this.employeeNumber.AutoSize = true;
            this.employeeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNumber.Location = new System.Drawing.Point(494, 102);
            this.employeeNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.employeeNumber.Name = "employeeNumber";
            this.employeeNumber.Size = new System.Drawing.Size(170, 24);
            this.employeeNumber.TabIndex = 7;
            this.employeeNumber.Text = "Employee Number";
            // 
            // employeeNumberTextBox
            // 
            this.employeeNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNumberTextBox.ForeColor = System.Drawing.Color.Silver;
            this.employeeNumberTextBox.Location = new System.Drawing.Point(498, 162);
            this.employeeNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.employeeNumberTextBox.Name = "employeeNumberTextBox";
            this.employeeNumberTextBox.Size = new System.Drawing.Size(148, 29);
            this.employeeNumberTextBox.TabIndex = 8;
            this.employeeNumberTextBox.Text = "12345";
            this.employeeNumberTextBox.Enter += new System.EventHandler(this.employeeNumberTextBox_Enter);
            this.employeeNumberTextBox.Leave += new System.EventHandler(this.employeeNumberTextBox_Leave);
            // 
            // User_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 527);
            this.Controls.Add(this.employeeNumberTextBox);
            this.Controls.Add(this.employeeNumber);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.clockInButton);
            this.Controls.Add(this.clockOutButton);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.loginButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "User_Login";
            this.Text = "User_Login";
            this.Load += new System.EventHandler(this.User_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button clockOutButton;
        private System.Windows.Forms.Button clockInButton;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label employeeNumber;
        private System.Windows.Forms.TextBox employeeNumberTextBox;
    }
}