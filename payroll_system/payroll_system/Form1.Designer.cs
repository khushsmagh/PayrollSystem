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
            this.ScheduleDataGrid = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timesheet = new System.Windows.Forms.TabPage();
            this.TimesheetDataGrid = new System.Windows.Forms.DataGridView();
            this.TSDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TSDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClockIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClockOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payslip = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.showPayslipOnDataGridView = new System.Windows.Forms.DataGridView();
            this.employee_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printPayslip = new System.Drawing.Printing.PrintDocument();
            this.tabControl1.SuspendLayout();
            this.personal_Info.SuspendLayout();
            this.schedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleDataGrid)).BeginInit();
            this.timesheet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimesheetDataGrid)).BeginInit();
            this.payslip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPayslipOnDataGridView)).BeginInit();
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
            this.tabControl1.Location = new System.Drawing.Point(9, 31);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(631, 388);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.PaySlipClick);
            // 
            // personal_Info
            // 
            this.personal_Info.AutoScroll = true;
            this.personal_Info.BackColor = System.Drawing.Color.Transparent;
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
            this.personal_Info.Location = new System.Drawing.Point(4, 27);
            this.personal_Info.Margin = new System.Windows.Forms.Padding(2);
            this.personal_Info.Name = "personal_Info";
            this.personal_Info.Padding = new System.Windows.Forms.Padding(2);
            this.personal_Info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.personal_Info.Size = new System.Drawing.Size(623, 357);
            this.personal_Info.TabIndex = 0;
            this.personal_Info.Text = "Personal Info";
            // 
            // hourly_rate
            // 
            this.hourly_rate.AutoSize = true;
            this.hourly_rate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourly_rate.Location = new System.Drawing.Point(124, 198);
            this.hourly_rate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hourly_rate.Name = "hourly_rate";
            this.hourly_rate.Size = new System.Drawing.Size(52, 16);
            this.hourly_rate.TabIndex = 12;
            this.hourly_rate.Text = "$ 0.00 ";
            // 
            // date_hired
            // 
            this.date_hired.AutoSize = true;
            this.date_hired.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_hired.Location = new System.Drawing.Point(124, 167);
            this.date_hired.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.date_hired.Name = "date_hired";
            this.date_hired.Size = new System.Drawing.Size(94, 16);
            this.date_hired.TabIndex = 11;
            this.date_hired.Text = "MM/DD/YYYY";
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position.Location = new System.Drawing.Point(124, 135);
            this.position.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(58, 16);
            this.position.TabIndex = 10;
            this.position.Text = "Position";
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.Location = new System.Drawing.Point(124, 103);
            this.dob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(94, 16);
            this.dob.TabIndex = 9;
            this.dob.Text = "MM/DD/YYYY";
            // 
            // last_name
            // 
            this.last_name.AutoSize = true;
            this.last_name.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_name.Location = new System.Drawing.Point(124, 72);
            this.last_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(75, 16);
            this.last_name.TabIndex = 8;
            this.last_name.Text = "Last Name";
            // 
            // first_name
            // 
            this.first_name.AutoSize = true;
            this.first_name.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_name.Location = new System.Drawing.Point(124, 40);
            this.first_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(76, 16);
            this.first_name.TabIndex = 7;
            this.first_name.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Hourly Rate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date Hired:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Position:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date Of Birth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // schedule
            // 
            this.schedule.AutoScroll = true;
            this.schedule.Controls.Add(this.ScheduleDataGrid);
            this.schedule.Location = new System.Drawing.Point(4, 27);
            this.schedule.Margin = new System.Windows.Forms.Padding(2);
            this.schedule.Name = "schedule";
            this.schedule.Padding = new System.Windows.Forms.Padding(2);
            this.schedule.Size = new System.Drawing.Size(623, 357);
            this.schedule.TabIndex = 1;
            this.schedule.Text = "Schedule";
            this.schedule.UseVisualStyleBackColor = true;
            // 
            // ScheduleDataGrid
            // 
            this.ScheduleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Day,
            this.Shift});
            this.ScheduleDataGrid.Location = new System.Drawing.Point(19, 23);
            this.ScheduleDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.ScheduleDataGrid.Name = "ScheduleDataGrid";
            this.ScheduleDataGrid.RowTemplate.Height = 24;
            this.ScheduleDataGrid.Size = new System.Drawing.Size(586, 318);
            this.ScheduleDataGrid.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Day
            // 
            this.Day.HeaderText = "Day";
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            // 
            // Shift
            // 
            this.Shift.HeaderText = "Shift";
            this.Shift.Name = "Shift";
            this.Shift.ReadOnly = true;
            // 
            // timesheet
            // 
            this.timesheet.AutoScroll = true;
            this.timesheet.Controls.Add(this.TimesheetDataGrid);
            this.timesheet.Location = new System.Drawing.Point(4, 27);
            this.timesheet.Margin = new System.Windows.Forms.Padding(2);
            this.timesheet.Name = "timesheet";
            this.timesheet.Size = new System.Drawing.Size(623, 357);
            this.timesheet.TabIndex = 2;
            this.timesheet.Text = "Timesheet";
            this.timesheet.UseVisualStyleBackColor = true;
            // 
            // TimesheetDataGrid
            // 
            this.TimesheetDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TimesheetDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TSDate,
            this.TSDay,
            this.ClockIn,
            this.ClockOut});
            this.TimesheetDataGrid.Location = new System.Drawing.Point(14, 17);
            this.TimesheetDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.TimesheetDataGrid.Name = "TimesheetDataGrid";
            this.TimesheetDataGrid.RowTemplate.Height = 24;
            this.TimesheetDataGrid.Size = new System.Drawing.Size(595, 310);
            this.TimesheetDataGrid.TabIndex = 0;
            // 
            // TSDate
            // 
            this.TSDate.HeaderText = "Date";
            this.TSDate.Name = "TSDate";
            // 
            // TSDay
            // 
            this.TSDay.HeaderText = "Day";
            this.TSDay.Name = "TSDay";
            // 
            // ClockIn
            // 
            this.ClockIn.HeaderText = "ClockIn";
            this.ClockIn.Name = "ClockIn";
            // 
            // ClockOut
            // 
            this.ClockOut.HeaderText = "ClockOut";
            this.ClockOut.Name = "ClockOut";
            // 
            // payslip
            // 
            this.payslip.AutoScroll = true;
            this.payslip.Controls.Add(this.button1);
            this.payslip.Controls.Add(this.showPayslipOnDataGridView);
            this.payslip.Location = new System.Drawing.Point(4, 27);
            this.payslip.Margin = new System.Windows.Forms.Padding(2);
            this.payslip.Name = "payslip";
            this.payslip.Size = new System.Drawing.Size(623, 357);
            this.payslip.TabIndex = 3;
            this.payslip.Text = "Pay Slip";
            this.payslip.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showPayslipOnDataGridView
            // 
            this.showPayslipOnDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showPayslipOnDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.showPayslipOnDataGridView.Location = new System.Drawing.Point(0, 0);
            this.showPayslipOnDataGridView.Name = "showPayslipOnDataGridView";
            this.showPayslipOnDataGridView.Size = new System.Drawing.Size(623, 150);
            this.showPayslipOnDataGridView.TabIndex = 0;
            // 
            // employee_name
            // 
            this.employee_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.employee_name.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_name.Location = new System.Drawing.Point(391, 18);
            this.employee_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.employee_name.Name = "employee_name";
            this.employee_name.Size = new System.Drawing.Size(200, 19);
            this.employee_name.TabIndex = 1;
            this.employee_name.Text = "Employee Name";
            this.employee_name.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::payroll_system.Properties.Resources.user_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(595, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 41);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // printPayslip
            // 
            this.printPayslip.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printPayslip_PrintPage);
            // 
            // Payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(649, 428);
            this.Controls.Add(this.employee_name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Payroll";
            this.Text = "Payroll";
            this.Load += new System.EventHandler(this.Payroll_Load);
            this.tabControl1.ResumeLayout(false);
            this.personal_Info.ResumeLayout(false);
            this.personal_Info.PerformLayout();
            this.schedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleDataGrid)).EndInit();
            this.timesheet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TimesheetDataGrid)).EndInit();
            this.payslip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showPayslipOnDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView ScheduleDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift;
        private System.Windows.Forms.DataGridView TimesheetDataGrid;
        private System.Windows.Forms.Label hourly_rate;
        private System.Windows.Forms.Label date_hired;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.Label last_name;
        private System.Windows.Forms.Label first_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TSDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TSDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClockIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClockOut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView showPayslipOnDataGridView;
        private System.Drawing.Printing.PrintDocument printPayslip;
    }
}

