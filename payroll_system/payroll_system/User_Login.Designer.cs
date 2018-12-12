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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(90, 435);
            this.loginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(147, 65);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 682);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // clockOutButton
            // 
            this.clockOutButton.BackColor = System.Drawing.Color.Crimson;
            this.clockOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockOutButton.Location = new System.Drawing.Point(85, 462);
            this.clockOutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clockOutButton.Name = "clockOutButton";
            this.clockOutButton.Size = new System.Drawing.Size(147, 65);
            this.clockOutButton.TabIndex = 2;
            this.clockOutButton.Text = "Clock-out";
            this.clockOutButton.UseVisualStyleBackColor = false;
            this.clockOutButton.Click += new System.EventHandler(this.clockOutButton_Click);
            // 
            // clockInButton
            // 
            this.clockInButton.BackColor = System.Drawing.Color.GreenYellow;
            this.clockInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockInButton.Location = new System.Drawing.Point(85, 372);
            this.clockInButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clockInButton.Name = "clockInButton";
            this.clockInButton.Size = new System.Drawing.Size(147, 65);
            this.clockInButton.TabIndex = 3;
            this.clockInButton.Text = "Clock-in";
            this.clockInButton.UseVisualStyleBackColor = false;
            this.clockInButton.Click += new System.EventHandler(this.clockInButton_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.Silver;
            this.usernameTextBox.Location = new System.Drawing.Point(58, 282);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(196, 34);
            this.usernameTextBox.TabIndex = 4;
            this.usernameTextBox.Text = "Username";
            this.usernameTextBox.Enter += new System.EventHandler(this.usernameTextBox_Enter);
            this.usernameTextBox.Leave += new System.EventHandler(this.usernameTextBox_Leave);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.Silver;
            this.passwordTextBox.Location = new System.Drawing.Point(58, 359);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(196, 34);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // employeeNumber
            // 
            this.employeeNumber.AutoSize = true;
            this.employeeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNumber.Location = new System.Drawing.Point(56, 242);
            this.employeeNumber.Name = "employeeNumber";
            this.employeeNumber.Size = new System.Drawing.Size(215, 29);
            this.employeeNumber.TabIndex = 7;
            this.employeeNumber.Text = "Employee Number";
            // 
            // employeeNumberTextBox
            // 
            this.employeeNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNumberTextBox.ForeColor = System.Drawing.Color.Silver;
            this.employeeNumberTextBox.Location = new System.Drawing.Point(67, 304);
            this.employeeNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeNumberTextBox.Name = "employeeNumberTextBox";
            this.employeeNumberTextBox.Size = new System.Drawing.Size(196, 34);
            this.employeeNumberTextBox.TabIndex = 8;
            this.employeeNumberTextBox.Text = "12345";
            this.employeeNumberTextBox.Enter += new System.EventHandler(this.employeeNumberTextBox_Enter);
            this.employeeNumberTextBox.Leave += new System.EventHandler(this.employeeNumberTextBox_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.usernameTextBox);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.loginButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 682);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::payroll_system.Properties.Resources.user_297330_640;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(78, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 125);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.employeeNumber);
            this.groupBox2.Controls.Add(this.employeeNumberTextBox);
            this.groupBox2.Controls.Add(this.clockOutButton);
            this.groupBox2.Controls.Add(this.clockInButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(796, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 682);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ClockIn";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::payroll_system.Properties.Resources.www_maxpixel_net_Time_Indicating_Time_Of_Clock_Icon_Time_1606153;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(96, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 107);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::payroll_system.Properties.Resources.Editing_Circle_SGBerlin1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(431, 220);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(265, 256);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // User_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::payroll_system.Properties.Resources.texture_1668079_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1115, 682);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitter1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "User_Login";
            this.Text = "User_Login";
            this.Load += new System.EventHandler(this.User_Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}