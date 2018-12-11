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
            this.S_Search_Button = new System.Windows.Forms.Button();
            this.S_ToLabel = new System.Windows.Forms.Label();
            this.S_FromLabel = new System.Windows.Forms.Label();
            this.S_End = new System.Windows.Forms.DateTimePicker();
            this.S_Start = new System.Windows.Forms.DateTimePicker();
            this.ScheduleDataGrid = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timesheet = new System.Windows.Forms.TabPage();
            this.Timesheet_Search_Button = new System.Windows.Forms.Button();
            this.TS_ToLabel = new System.Windows.Forms.Label();
            this.TS_FromLabel = new System.Windows.Forms.Label();
            this.TS_End = new System.Windows.Forms.DateTimePicker();
            this.TS_Start = new System.Windows.Forms.DateTimePicker();
            this.TimesheetDataGrid = new System.Windows.Forms.DataGridView();
            this.TSDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TSDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TSSchedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClockIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClockOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payslip = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.showPayslipOnDataGridView = new System.Windows.Forms.DataGridView();
            this.employee_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printPayslip = new System.Drawing.Printing.PrintDocument();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PS_EndDate = new System.Windows.Forms.DateTimePicker();
            this.PS_StartDate = new System.Windows.Forms.DateTimePicker();
            this.GeneratePayslip_Button = new System.Windows.Forms.Button();
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
            this.tabControl1.Location = new System.Drawing.Point(12, 38);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(841, 478);
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
            this.schedule.Controls.Add(this.S_Search_Button);
            this.schedule.Controls.Add(this.S_ToLabel);
            this.schedule.Controls.Add(this.S_FromLabel);
            this.schedule.Controls.Add(this.S_End);
            this.schedule.Controls.Add(this.S_Start);
            this.schedule.Controls.Add(this.ScheduleDataGrid);
            this.schedule.Location = new System.Drawing.Point(4, 32);
            this.schedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.schedule.Name = "schedule";
            this.schedule.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.schedule.Size = new System.Drawing.Size(833, 442);
            this.schedule.TabIndex = 1;
            this.schedule.Text = "Schedule";
            this.schedule.UseVisualStyleBackColor = true;
            // 
            // S_Search_Button
            // 
            this.S_Search_Button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_Search_Button.Location = new System.Drawing.Point(127, 127);
            this.S_Search_Button.Name = "S_Search_Button";
            this.S_Search_Button.Size = new System.Drawing.Size(90, 33);
            this.S_Search_Button.TabIndex = 6;
            this.S_Search_Button.Text = "Search";
            this.S_Search_Button.UseVisualStyleBackColor = true;
            this.S_Search_Button.Click += new System.EventHandler(this.Schedule_Search_Button_Click);
            // 
            // S_ToLabel
            // 
            this.S_ToLabel.AutoSize = true;
            this.S_ToLabel.Location = new System.Drawing.Point(55, 84);
            this.S_ToLabel.Name = "S_ToLabel";
            this.S_ToLabel.Size = new System.Drawing.Size(41, 23);
            this.S_ToLabel.TabIndex = 5;
            this.S_ToLabel.Text = "To:";
            // 
            // S_FromLabel
            // 
            this.S_FromLabel.AutoSize = true;
            this.S_FromLabel.Location = new System.Drawing.Point(29, 34);
            this.S_FromLabel.Name = "S_FromLabel";
            this.S_FromLabel.Size = new System.Drawing.Size(67, 23);
            this.S_FromLabel.TabIndex = 4;
            this.S_FromLabel.Text = "From:";
            // 
            // S_End
            // 
            this.S_End.Location = new System.Drawing.Point(127, 80);
            this.S_End.Name = "S_End";
            this.S_End.Size = new System.Drawing.Size(264, 31);
            this.S_End.TabIndex = 3;
            // 
            // S_Start
            // 
            this.S_Start.Location = new System.Drawing.Point(127, 30);
            this.S_Start.Name = "S_Start";
            this.S_Start.Size = new System.Drawing.Size(264, 31);
            this.S_Start.TabIndex = 2;
            // 
            // ScheduleDataGrid
            // 
            this.ScheduleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Day,
            this.Shift});
            this.ScheduleDataGrid.Location = new System.Drawing.Point(25, 163);
            this.ScheduleDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ScheduleDataGrid.Name = "ScheduleDataGrid";
            this.ScheduleDataGrid.RowTemplate.Height = 24;
            this.ScheduleDataGrid.Size = new System.Drawing.Size(781, 241);
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
            this.timesheet.Controls.Add(this.Timesheet_Search_Button);
            this.timesheet.Controls.Add(this.TS_ToLabel);
            this.timesheet.Controls.Add(this.TS_FromLabel);
            this.timesheet.Controls.Add(this.TS_End);
            this.timesheet.Controls.Add(this.TS_Start);
            this.timesheet.Controls.Add(this.TimesheetDataGrid);
            this.timesheet.Location = new System.Drawing.Point(4, 32);
            this.timesheet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timesheet.Name = "timesheet";
            this.timesheet.Size = new System.Drawing.Size(833, 442);
            this.timesheet.TabIndex = 2;
            this.timesheet.Text = "Timesheet";
            this.timesheet.UseVisualStyleBackColor = true;
            // 
            // Timesheet_Search_Button
            // 
            this.Timesheet_Search_Button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timesheet_Search_Button.Location = new System.Drawing.Point(128, 126);
            this.Timesheet_Search_Button.Name = "Timesheet_Search_Button";
            this.Timesheet_Search_Button.Size = new System.Drawing.Size(90, 33);
            this.Timesheet_Search_Button.TabIndex = 11;
            this.Timesheet_Search_Button.Text = "Search";
            this.Timesheet_Search_Button.UseVisualStyleBackColor = true;
            this.Timesheet_Search_Button.Click += new System.EventHandler(this.Timesheet_Search_Button_Click);
            // 
            // TS_ToLabel
            // 
            this.TS_ToLabel.AutoSize = true;
            this.TS_ToLabel.Location = new System.Drawing.Point(56, 83);
            this.TS_ToLabel.Name = "TS_ToLabel";
            this.TS_ToLabel.Size = new System.Drawing.Size(41, 23);
            this.TS_ToLabel.TabIndex = 10;
            this.TS_ToLabel.Text = "To:";
            // 
            // TS_FromLabel
            // 
            this.TS_FromLabel.AutoSize = true;
            this.TS_FromLabel.Location = new System.Drawing.Point(30, 33);
            this.TS_FromLabel.Name = "TS_FromLabel";
            this.TS_FromLabel.Size = new System.Drawing.Size(67, 23);
            this.TS_FromLabel.TabIndex = 9;
            this.TS_FromLabel.Text = "From:";
            // 
            // TS_End
            // 
            this.TS_End.Location = new System.Drawing.Point(128, 79);
            this.TS_End.Name = "TS_End";
            this.TS_End.Size = new System.Drawing.Size(264, 31);
            this.TS_End.TabIndex = 8;
            // 
            // TS_Start
            // 
            this.TS_Start.Location = new System.Drawing.Point(128, 29);
            this.TS_Start.Name = "TS_Start";
            this.TS_Start.Size = new System.Drawing.Size(264, 31);
            this.TS_Start.TabIndex = 7;
            // 
            // TimesheetDataGrid
            // 
            this.TimesheetDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TimesheetDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TSDate,
            this.TSDay,
            this.TSSchedule,
            this.ClockIn,
            this.ClockOut});
            this.TimesheetDataGrid.Location = new System.Drawing.Point(25, 180);
            this.TimesheetDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TimesheetDataGrid.Name = "TimesheetDataGrid";
            this.TimesheetDataGrid.RowTemplate.Height = 24;
            this.TimesheetDataGrid.Size = new System.Drawing.Size(778, 245);
            this.TimesheetDataGrid.TabIndex = 0;
            // 
            // TSDate
            // 
            this.TSDate.HeaderText = "Date";
            this.TSDate.Name = "TSDate";
            this.TSDate.ReadOnly = true;
            // 
            // TSDay
            // 
            this.TSDay.HeaderText = "Day";
            this.TSDay.Name = "TSDay";
            this.TSDay.ReadOnly = true;
            // 
            // TSSchedule
            // 
            this.TSSchedule.HeaderText = "Schedule";
            this.TSSchedule.Name = "TSSchedule";
            this.TSSchedule.ReadOnly = true;
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
            this.ClockOut.ReadOnly = true;
            // 
            // payslip
            // 
            this.payslip.AutoScroll = true;
            this.payslip.Controls.Add(this.GeneratePayslip_Button);
            this.payslip.Controls.Add(this.label7);
            this.payslip.Controls.Add(this.label8);
            this.payslip.Controls.Add(this.PS_EndDate);
            this.payslip.Controls.Add(this.PS_StartDate);
            this.payslip.Controls.Add(this.button1);
            this.payslip.Controls.Add(this.showPayslipOnDataGridView);
            this.payslip.Location = new System.Drawing.Point(4, 32);
            this.payslip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.payslip.Name = "payslip";
            this.payslip.Size = new System.Drawing.Size(833, 442);
            this.payslip.TabIndex = 3;
            this.payslip.Text = "Pay Slip";
            this.payslip.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 192);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showPayslipOnDataGridView
            // 
            this.showPayslipOnDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showPayslipOnDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.showPayslipOnDataGridView.Location = new System.Drawing.Point(0, 0);
            this.showPayslipOnDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.showPayslipOnDataGridView.Name = "showPayslipOnDataGridView";
            this.showPayslipOnDataGridView.Size = new System.Drawing.Size(833, 185);
            this.showPayslipOnDataGridView.TabIndex = 0;
            // 
            // employee_name
            // 
            this.employee_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.employee_name.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_name.Location = new System.Drawing.Point(521, 22);
            this.employee_name.Name = "employee_name";
            this.employee_name.Size = new System.Drawing.Size(267, 23);
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
            // printPayslip
            // 
            this.printPayslip.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printPayslip_PrintPage);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "To:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "From:";
            // 
            // PS_EndDate
            // 
            this.PS_EndDate.Location = new System.Drawing.Point(123, 281);
            this.PS_EndDate.Name = "PS_EndDate";
            this.PS_EndDate.Size = new System.Drawing.Size(264, 31);
            this.PS_EndDate.TabIndex = 12;
            // 
            // PS_StartDate
            // 
            this.PS_StartDate.Location = new System.Drawing.Point(123, 231);
            this.PS_StartDate.Name = "PS_StartDate";
            this.PS_StartDate.Size = new System.Drawing.Size(264, 31);
            this.PS_StartDate.TabIndex = 11;
            // 
            // GeneratePayslip_Button
            // 
            this.GeneratePayslip_Button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneratePayslip_Button.Location = new System.Drawing.Point(123, 333);
            this.GeneratePayslip_Button.Name = "GeneratePayslip_Button";
            this.GeneratePayslip_Button.Size = new System.Drawing.Size(150, 29);
            this.GeneratePayslip_Button.TabIndex = 15;
            this.GeneratePayslip_Button.Text = "Generate PaySlip";
            this.GeneratePayslip_Button.UseVisualStyleBackColor = true;
            this.GeneratePayslip_Button.Click += new System.EventHandler(this.GeneratePayslip_Button_Click);
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
            this.Load += new System.EventHandler(this.Payroll_Load);
            this.tabControl1.ResumeLayout(false);
            this.personal_Info.ResumeLayout(false);
            this.personal_Info.PerformLayout();
            this.schedule.ResumeLayout(false);
            this.schedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleDataGrid)).EndInit();
            this.timesheet.ResumeLayout(false);
            this.timesheet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimesheetDataGrid)).EndInit();
            this.payslip.ResumeLayout(false);
            this.payslip.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView showPayslipOnDataGridView;
        private System.Drawing.Printing.PrintDocument printPayslip;
        private System.Windows.Forms.Label S_ToLabel;
        private System.Windows.Forms.Label S_FromLabel;
        private System.Windows.Forms.DateTimePicker S_End;
        private System.Windows.Forms.DateTimePicker S_Start;
        private System.Windows.Forms.Button S_Search_Button;
        private System.Windows.Forms.Button Timesheet_Search_Button;
        private System.Windows.Forms.Label TS_ToLabel;
        private System.Windows.Forms.Label TS_FromLabel;
        private System.Windows.Forms.DateTimePicker TS_End;
        private System.Windows.Forms.DateTimePicker TS_Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn TSDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TSDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TSSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClockIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClockOut;
        private System.Windows.Forms.Button GeneratePayslip_Button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker PS_EndDate;
        private System.Windows.Forms.DateTimePicker PS_StartDate;
    }
}

