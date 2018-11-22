namespace payroll_system
{
    partial class Payroll
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.personal_Info = new System.Windows.Forms.TabPage();
            this.hourly_rate = new System.Windows.Forms.Label();
            this.date_hired = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.schedule = new System.Windows.Forms.TabPage();
            this.timesheet = new System.Windows.Forms.TabPage();
            this.payslip = new System.Windows.Forms.TabPage();
            this.employee_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.personal_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.personal_Info);
            this.tabControl1.Controls.Add(this.schedule);
            this.tabControl1.Controls.Add(this.timesheet);
            this.tabControl1.Controls.Add(this.payslip);
            this.tabControl1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 37);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(841, 478);
            this.tabControl1.TabIndex = 0;
            // 
            // personal_Info
            // 
            this.personal_Info.AutoScroll = true;
            this.personal_Info.BackColor = System.Drawing.Color.Transparent;
            this.personal_Info.Controls.Add(this.richTextBox1);
            this.personal_Info.Controls.Add(this.hourly_rate);
            this.personal_Info.Controls.Add(this.date_hired);
            this.personal_Info.Controls.Add(this.position);
            this.personal_Info.Controls.Add(this.dob);
            this.personal_Info.Controls.Add(this.last_name);
            this.personal_Info.Controls.Add(this.first_name);
            this.personal_Info.Controls.Add(this.label6);
            this.personal_Info.Controls.Add(this.label5);
            this.personal_Info.Controls.Add(this.label4);
            this.personal_Info.Controls.Add(this.label3);
            this.personal_Info.Controls.Add(this.label2);
            this.personal_Info.Controls.Add(this.label1);
            this.personal_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personal_Info.Location = new System.Drawing.Point(4, 32);
            this.personal_Info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personal_Info.Name = "personal_Info";
            this.personal_Info.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personal_Info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.personal_Info.Size = new System.Drawing.Size(833, 442);
            this.personal_Info.TabIndex = 0;
            this.personal_Info.Text = "Personal Info";
            // 
            // hourly_rate
            // 
            this.hourly_rate.AutoSize = true;
            this.hourly_rate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourly_rate.Location = new System.Drawing.Point(165, 244);
            this.hourly_rate.Name = "hourly_rate";
            this.hourly_rate.Size = new System.Drawing.Size(60, 19);
            this.hourly_rate.TabIndex = 12;
            this.hourly_rate.Text = "$ 0.00 ";
            // 
            // date_hired
            // 
            this.date_hired.AutoSize = true;
            this.date_hired.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_hired.Location = new System.Drawing.Point(165, 206);
            this.date_hired.Name = "date_hired";
            this.date_hired.Size = new System.Drawing.Size(113, 19);
            this.date_hired.TabIndex = 11;
            this.date_hired.Text = "MM/DD/YYYY";
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position.Location = new System.Drawing.Point(165, 166);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(67, 19);
            this.position.TabIndex = 10;
            this.position.Text = "Position";
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.Location = new System.Drawing.Point(165, 127);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(113, 19);
            this.dob.TabIndex = 9;
            this.dob.Text = "MM/DD/YYYY";
            // 
            // last_name
            // 
            this.last_name.AutoSize = true;
            this.last_name.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_name.Location = new System.Drawing.Point(165, 89);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(86, 19);
            this.last_name.TabIndex = 8;
            this.last_name.Text = "Last Name";
            // 
            // first_name
            // 
            this.first_name.AutoSize = true;
            this.first_name.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_name.Location = new System.Drawing.Point(165, 49);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(88, 19);
            this.first_name.TabIndex = 7;
            this.first_name.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Hourly Rate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date Hired:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Position:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date Of Birth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // schedule
            // 
            this.schedule.AutoScroll = true;
            this.schedule.Location = new System.Drawing.Point(4, 32);
            this.schedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.schedule.Name = "schedule";
            this.schedule.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.schedule.Size = new System.Drawing.Size(833, 442);
            this.schedule.TabIndex = 1;
            this.schedule.Text = "Schedule";
            this.schedule.UseVisualStyleBackColor = true;
            // 
            // timesheet
            // 
            this.timesheet.AutoScroll = true;
            this.timesheet.Location = new System.Drawing.Point(4, 32);
            this.timesheet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timesheet.Name = "timesheet";
            this.timesheet.Size = new System.Drawing.Size(833, 442);
            this.timesheet.TabIndex = 2;
            this.timesheet.Text = "Timesheet";
            this.timesheet.UseVisualStyleBackColor = true;
            // 
            // payslip
            // 
            this.payslip.AutoScroll = true;
            this.payslip.Location = new System.Drawing.Point(4, 32);
            this.payslip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.payslip.Name = "payslip";
            this.payslip.Size = new System.Drawing.Size(833, 442);
            this.payslip.TabIndex = 3;
            this.payslip.Text = "Pay Slip";
            this.payslip.UseVisualStyleBackColor = true;
            // 
            // employee_name
            // 
            this.employee_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.employee_name.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_name.Location = new System.Drawing.Point(483, 22);
            this.employee_name.Name = "employee_name";
            this.employee_name.Size = new System.Drawing.Size(304, 23);
            this.employee_name.TabIndex = 1;
            this.employee_name.Text = "Employee Name";
            this.employee_name.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::payroll_system.Properties.Resources.user_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(793, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(369, 321);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(326, 96);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // Payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(865, 527);
            this.Controls.Add(this.employee_name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Payroll";
            this.Text = "Payroll";
            this.tabControl1.ResumeLayout(false);
            this.personal_Info.ResumeLayout(false);
            this.personal_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage personal_Info;
        private System.Windows.Forms.TabPage schedule;
        private System.Windows.Forms.TabPage timesheet;
        private System.Windows.Forms.TabPage payslip;
        private System.Windows.Forms.Label employee_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label hourly_rate;
        private System.Windows.Forms.Label date_hired;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.Label last_name;
        private System.Windows.Forms.Label first_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

