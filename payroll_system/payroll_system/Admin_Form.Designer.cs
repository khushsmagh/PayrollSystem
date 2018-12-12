namespace payroll_system
{
    partial class Admin_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Form));
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.employeeList = new System.Windows.Forms.TabPage();
            this.editButton = new System.Windows.Forms.Button();
            this.timesheetRadioButton = new System.Windows.Forms.RadioButton();
            this.scheduleRadioButton = new System.Windows.Forms.RadioButton();
            this.employeeListGridView = new System.Windows.Forms.DataGridView();
            this.employeeIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateHiredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourlyRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payrollDataSet = new payroll_system.PayrollDataSet();
            this.editSchedule = new System.Windows.Forms.TabPage();
            this.editScheduleButton = new System.Windows.Forms.Button();
            this.deleteSchedule = new System.Windows.Forms.Button();
            this.editEmployeeScheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.scheduleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editTimesheet = new System.Windows.Forms.TabPage();
            this.deleteTimesheetButton = new System.Windows.Forms.Button();
            this.editTimesheetButton = new System.Windows.Forms.Button();
            this.editEmployeeTimesheetDataGridView = new System.Windows.Forms.DataGridView();
            this.timesheetIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLockInTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clockOutTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTimesheetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.searchScheduleForThatDateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.scheduleDate = new System.Windows.Forms.DateTimePicker();
            this.searchEmployeeDetailsButton = new System.Windows.Forms.Button();
            this.getEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchDataGridView = new System.Windows.Forms.DataGridView();
            this.employeeTableBinding = new System.Windows.Forms.BindingSource(this.components);
            this.tScheduleTableAdapter = new payroll_system.PayrollDataSetTableAdapters.TScheduleTableAdapter();
            this.tEmployeeTableAdapter = new payroll_system.PayrollDataSetTableAdapters.TEmployeeTableAdapter();
            this.tTimesheetTableAdapter = new payroll_system.PayrollDataSetTableAdapters.TTimesheetTableAdapter();
            this.payrollDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminTabControl.SuspendLayout();
            this.employeeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollDataSet)).BeginInit();
            this.editSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editEmployeeScheduleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tScheduleBindingSource)).BeginInit();
            this.editTimesheet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editEmployeeTimesheetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTimesheetBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTableBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adminTabControl
            // 
            this.adminTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminTabControl.Controls.Add(this.employeeList);
            this.adminTabControl.Controls.Add(this.editSchedule);
            this.adminTabControl.Controls.Add(this.editTimesheet);
            this.adminTabControl.Controls.Add(this.tabPage1);
            this.adminTabControl.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTabControl.Location = new System.Drawing.Point(0, 90);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(1037, 457);
            this.adminTabControl.TabIndex = 0;
            // 
            // employeeList
            // 
            this.employeeList.BackColor = System.Drawing.Color.PaleTurquoise;
            this.employeeList.Controls.Add(this.editButton);
            this.employeeList.Controls.Add(this.timesheetRadioButton);
            this.employeeList.Controls.Add(this.scheduleRadioButton);
            this.employeeList.Controls.Add(this.employeeListGridView);
            this.employeeList.Location = new System.Drawing.Point(4, 39);
            this.employeeList.Name = "employeeList";
            this.employeeList.Padding = new System.Windows.Forms.Padding(3);
            this.employeeList.Size = new System.Drawing.Size(1029, 414);
            this.employeeList.TabIndex = 0;
            this.employeeList.Text = "Employee List";
            // 
            // editButton
            // 
            this.editButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.editButton.BackColor = System.Drawing.Color.FloralWhite;
            this.editButton.BackgroundImage = global::payroll_system.Properties.Resources.Edit_icon__the_Noun_Project_30184__svg;
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Location = new System.Drawing.Point(692, 342);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(118, 51);
            this.editButton.TabIndex = 4;
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // timesheetRadioButton
            // 
            this.timesheetRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.timesheetRadioButton.AutoSize = true;
            this.timesheetRadioButton.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesheetRadioButton.Location = new System.Drawing.Point(408, 347);
            this.timesheetRadioButton.Name = "timesheetRadioButton";
            this.timesheetRadioButton.Size = new System.Drawing.Size(159, 47);
            this.timesheetRadioButton.TabIndex = 3;
            this.timesheetRadioButton.TabStop = true;
            this.timesheetRadioButton.Text = "Timesheet";
            this.timesheetRadioButton.UseVisualStyleBackColor = true;
            // 
            // scheduleRadioButton
            // 
            this.scheduleRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.scheduleRadioButton.AutoSize = true;
            this.scheduleRadioButton.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleRadioButton.Location = new System.Drawing.Point(184, 347);
            this.scheduleRadioButton.Name = "scheduleRadioButton";
            this.scheduleRadioButton.Size = new System.Drawing.Size(144, 47);
            this.scheduleRadioButton.TabIndex = 2;
            this.scheduleRadioButton.TabStop = true;
            this.scheduleRadioButton.Text = "Schedule";
            this.scheduleRadioButton.UseVisualStyleBackColor = true;
            // 
            // employeeListGridView
            // 
            this.employeeListGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeListGridView.AutoGenerateColumns = false;
            this.employeeListGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeeListGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.employeeListGridView.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.employeeListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIdDataGridViewTextBoxColumn1,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.dateHiredDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.hourlyRateDataGridViewTextBoxColumn});
            this.employeeListGridView.DataSource = this.tEmployeeBindingSource;
            this.employeeListGridView.Location = new System.Drawing.Point(3, 3);
            this.employeeListGridView.Name = "employeeListGridView";
            this.employeeListGridView.ReadOnly = true;
            this.employeeListGridView.RowTemplate.Height = 24;
            this.employeeListGridView.Size = new System.Drawing.Size(1023, 319);
            this.employeeListGridView.TabIndex = 0;
            // 
            // employeeIdDataGridViewTextBoxColumn1
            // 
            this.employeeIdDataGridViewTextBoxColumn1.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn1.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn1.Name = "employeeIdDataGridViewTextBoxColumn1";
            this.employeeIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateHiredDataGridViewTextBoxColumn
            // 
            this.dateHiredDataGridViewTextBoxColumn.DataPropertyName = "DateHired";
            this.dateHiredDataGridViewTextBoxColumn.HeaderText = "DateHired";
            this.dateHiredDataGridViewTextBoxColumn.Name = "dateHiredDataGridViewTextBoxColumn";
            this.dateHiredDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hourlyRateDataGridViewTextBoxColumn
            // 
            this.hourlyRateDataGridViewTextBoxColumn.DataPropertyName = "HourlyRate";
            this.hourlyRateDataGridViewTextBoxColumn.HeaderText = "HourlyRate";
            this.hourlyRateDataGridViewTextBoxColumn.Name = "hourlyRateDataGridViewTextBoxColumn";
            this.hourlyRateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tEmployeeBindingSource
            // 
            this.tEmployeeBindingSource.DataMember = "TEmployee";
            this.tEmployeeBindingSource.DataSource = this.payrollDataSet;
            // 
            // payrollDataSet
            // 
            this.payrollDataSet.DataSetName = "PayrollDataSet";
            this.payrollDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // editSchedule
            // 
            this.editSchedule.BackColor = System.Drawing.Color.PaleTurquoise;
            this.editSchedule.Controls.Add(this.editScheduleButton);
            this.editSchedule.Controls.Add(this.deleteSchedule);
            this.editSchedule.Controls.Add(this.editEmployeeScheduleDataGridView);
            this.editSchedule.Location = new System.Drawing.Point(4, 39);
            this.editSchedule.Name = "editSchedule";
            this.editSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.editSchedule.Size = new System.Drawing.Size(1029, 414);
            this.editSchedule.TabIndex = 1;
            this.editSchedule.Text = "Edit Schedule";
            // 
            // editScheduleButton
            // 
            this.editScheduleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.editScheduleButton.BackColor = System.Drawing.Color.FloralWhite;
            this.editScheduleButton.BackgroundImage = global::payroll_system.Properties.Resources.save_icon_1257065_640;
            this.editScheduleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editScheduleButton.Location = new System.Drawing.Point(354, 356);
            this.editScheduleButton.Name = "editScheduleButton";
            this.editScheduleButton.Size = new System.Drawing.Size(118, 51);
            this.editScheduleButton.TabIndex = 3;
            this.editScheduleButton.UseVisualStyleBackColor = false;
            this.editScheduleButton.Click += new System.EventHandler(this.editScheduleButton_Click);
            // 
            // deleteSchedule
            // 
            this.deleteSchedule.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteSchedule.BackColor = System.Drawing.Color.FloralWhite;
            this.deleteSchedule.BackgroundImage = global::payroll_system.Properties.Resources.Trash_Heas;
            this.deleteSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteSchedule.Location = new System.Drawing.Point(541, 356);
            this.deleteSchedule.Name = "deleteSchedule";
            this.deleteSchedule.Size = new System.Drawing.Size(118, 51);
            this.deleteSchedule.TabIndex = 2;
            this.deleteSchedule.UseVisualStyleBackColor = false;
            this.deleteSchedule.Click += new System.EventHandler(this.deleteSchedule_Click);
            // 
            // editEmployeeScheduleDataGridView
            // 
            this.editEmployeeScheduleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editEmployeeScheduleDataGridView.AutoGenerateColumns = false;
            this.editEmployeeScheduleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.editEmployeeScheduleDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.editEmployeeScheduleDataGridView.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.editEmployeeScheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editEmployeeScheduleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scheduleIdDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn});
            this.editEmployeeScheduleDataGridView.DataSource = this.tScheduleBindingSource;
            this.editEmployeeScheduleDataGridView.Location = new System.Drawing.Point(3, 3);
            this.editEmployeeScheduleDataGridView.Name = "editEmployeeScheduleDataGridView";
            this.editEmployeeScheduleDataGridView.RowTemplate.Height = 24;
            this.editEmployeeScheduleDataGridView.Size = new System.Drawing.Size(1023, 340);
            this.editEmployeeScheduleDataGridView.TabIndex = 0;
            this.editEmployeeScheduleDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.scheduleDataGridViewClick);
            // 
            // scheduleIdDataGridViewTextBoxColumn
            // 
            this.scheduleIdDataGridViewTextBoxColumn.DataPropertyName = "ScheduleId";
            this.scheduleIdDataGridViewTextBoxColumn.HeaderText = "ScheduleId";
            this.scheduleIdDataGridViewTextBoxColumn.Name = "scheduleIdDataGridViewTextBoxColumn";
            this.scheduleIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "Shift";
            this.shiftDataGridViewTextBoxColumn.HeaderText = "Shift";
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            // 
            // tScheduleBindingSource
            // 
            this.tScheduleBindingSource.DataMember = "TSchedule";
            this.tScheduleBindingSource.DataSource = this.payrollDataSet;
            // 
            // editTimesheet
            // 
            this.editTimesheet.BackColor = System.Drawing.Color.PaleTurquoise;
            this.editTimesheet.Controls.Add(this.deleteTimesheetButton);
            this.editTimesheet.Controls.Add(this.editTimesheetButton);
            this.editTimesheet.Controls.Add(this.editEmployeeTimesheetDataGridView);
            this.editTimesheet.Location = new System.Drawing.Point(4, 39);
            this.editTimesheet.Name = "editTimesheet";
            this.editTimesheet.Size = new System.Drawing.Size(1029, 414);
            this.editTimesheet.TabIndex = 2;
            this.editTimesheet.Text = "Edit Timesheet";
            // 
            // deleteTimesheetButton
            // 
            this.deleteTimesheetButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteTimesheetButton.BackColor = System.Drawing.Color.FloralWhite;
            this.deleteTimesheetButton.BackgroundImage = global::payroll_system.Properties.Resources.Trash_Heas;
            this.deleteTimesheetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteTimesheetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTimesheetButton.Location = new System.Drawing.Point(543, 343);
            this.deleteTimesheetButton.Name = "deleteTimesheetButton";
            this.deleteTimesheetButton.Size = new System.Drawing.Size(118, 51);
            this.deleteTimesheetButton.TabIndex = 4;
            this.deleteTimesheetButton.UseVisualStyleBackColor = false;
            this.deleteTimesheetButton.Click += new System.EventHandler(this.deleteTimesheetButton_Click);
            // 
            // editTimesheetButton
            // 
            this.editTimesheetButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.editTimesheetButton.BackColor = System.Drawing.Color.FloralWhite;
            this.editTimesheetButton.BackgroundImage = global::payroll_system.Properties.Resources.save_icon_1257065_640;
            this.editTimesheetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editTimesheetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTimesheetButton.Location = new System.Drawing.Point(363, 343);
            this.editTimesheetButton.Name = "editTimesheetButton";
            this.editTimesheetButton.Size = new System.Drawing.Size(118, 51);
            this.editTimesheetButton.TabIndex = 3;
            this.editTimesheetButton.UseVisualStyleBackColor = false;
            this.editTimesheetButton.Click += new System.EventHandler(this.editTimesheetButton_Click);
            // 
            // editEmployeeTimesheetDataGridView
            // 
            this.editEmployeeTimesheetDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editEmployeeTimesheetDataGridView.AutoGenerateColumns = false;
            this.editEmployeeTimesheetDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.editEmployeeTimesheetDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.editEmployeeTimesheetDataGridView.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.editEmployeeTimesheetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editEmployeeTimesheetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timesheetIdDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn2,
            this.dateDataGridViewTextBoxColumn1,
            this.cLockInTimeDataGridViewTextBoxColumn,
            this.clockOutTimeDataGridViewTextBoxColumn,
            this.totalHoursDataGridViewTextBoxColumn});
            this.editEmployeeTimesheetDataGridView.DataSource = this.tTimesheetBindingSource;
            this.editEmployeeTimesheetDataGridView.Location = new System.Drawing.Point(0, 0);
            this.editEmployeeTimesheetDataGridView.Name = "editEmployeeTimesheetDataGridView";
            this.editEmployeeTimesheetDataGridView.RowTemplate.Height = 24;
            this.editEmployeeTimesheetDataGridView.Size = new System.Drawing.Size(1029, 323);
            this.editEmployeeTimesheetDataGridView.TabIndex = 0;
            // 
            // timesheetIdDataGridViewTextBoxColumn
            // 
            this.timesheetIdDataGridViewTextBoxColumn.DataPropertyName = "TimesheetId";
            this.timesheetIdDataGridViewTextBoxColumn.HeaderText = "TimesheetId";
            this.timesheetIdDataGridViewTextBoxColumn.Name = "timesheetIdDataGridViewTextBoxColumn";
            this.timesheetIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIdDataGridViewTextBoxColumn2
            // 
            this.employeeIdDataGridViewTextBoxColumn2.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn2.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn2.Name = "employeeIdDataGridViewTextBoxColumn2";
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            // 
            // cLockInTimeDataGridViewTextBoxColumn
            // 
            this.cLockInTimeDataGridViewTextBoxColumn.DataPropertyName = "CLockInTime";
            this.cLockInTimeDataGridViewTextBoxColumn.HeaderText = "CLockInTime";
            this.cLockInTimeDataGridViewTextBoxColumn.Name = "cLockInTimeDataGridViewTextBoxColumn";
            // 
            // clockOutTimeDataGridViewTextBoxColumn
            // 
            this.clockOutTimeDataGridViewTextBoxColumn.DataPropertyName = "ClockOutTime";
            this.clockOutTimeDataGridViewTextBoxColumn.HeaderText = "ClockOutTime";
            this.clockOutTimeDataGridViewTextBoxColumn.Name = "clockOutTimeDataGridViewTextBoxColumn";
            // 
            // totalHoursDataGridViewTextBoxColumn
            // 
            this.totalHoursDataGridViewTextBoxColumn.DataPropertyName = "TotalHours";
            this.totalHoursDataGridViewTextBoxColumn.HeaderText = "TotalHours";
            this.totalHoursDataGridViewTextBoxColumn.Name = "totalHoursDataGridViewTextBoxColumn";
            // 
            // tTimesheetBindingSource
            // 
            this.tTimesheetBindingSource.DataMember = "TTimesheet";
            this.tTimesheetBindingSource.DataSource = this.payrollDataSet;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage1.Controls.Add(this.searchScheduleForThatDateButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.scheduleDate);
            this.tabPage1.Controls.Add(this.searchEmployeeDetailsButton);
            this.tabPage1.Controls.Add(this.getEmployeeTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.searchDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1029, 414);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Advanced Search";
            // 
            // searchScheduleForThatDateButton
            // 
            this.searchScheduleForThatDateButton.BackColor = System.Drawing.Color.FloralWhite;
            this.searchScheduleForThatDateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchScheduleForThatDateButton.BackgroundImage")));
            this.searchScheduleForThatDateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchScheduleForThatDateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchScheduleForThatDateButton.Location = new System.Drawing.Point(549, 96);
            this.searchScheduleForThatDateButton.Name = "searchScheduleForThatDateButton";
            this.searchScheduleForThatDateButton.Size = new System.Drawing.Size(103, 38);
            this.searchScheduleForThatDateButton.TabIndex = 6;
            this.searchScheduleForThatDateButton.UseVisualStyleBackColor = false;
            this.searchScheduleForThatDateButton.Click += new System.EventHandler(this.searchScheduleForThatDateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Get Schedule ";
            // 
            // scheduleDate
            // 
            this.scheduleDate.Location = new System.Drawing.Point(268, 96);
            this.scheduleDate.Name = "scheduleDate";
            this.scheduleDate.Size = new System.Drawing.Size(200, 38);
            this.scheduleDate.TabIndex = 4;
            // 
            // searchEmployeeDetailsButton
            // 
            this.searchEmployeeDetailsButton.BackColor = System.Drawing.Color.FloralWhite;
            this.searchEmployeeDetailsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchEmployeeDetailsButton.BackgroundImage")));
            this.searchEmployeeDetailsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchEmployeeDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchEmployeeDetailsButton.Location = new System.Drawing.Point(549, 21);
            this.searchEmployeeDetailsButton.Name = "searchEmployeeDetailsButton";
            this.searchEmployeeDetailsButton.Size = new System.Drawing.Size(103, 38);
            this.searchEmployeeDetailsButton.TabIndex = 3;
            this.searchEmployeeDetailsButton.UseVisualStyleBackColor = false;
            this.searchEmployeeDetailsButton.Click += new System.EventHandler(this.searchEmployeeDetailsButton_Click);
            // 
            // getEmployeeTextBox
            // 
            this.getEmployeeTextBox.Location = new System.Drawing.Point(268, 21);
            this.getEmployeeTextBox.Name = "getEmployeeTextBox";
            this.getEmployeeTextBox.Size = new System.Drawing.Size(200, 38);
            this.getEmployeeTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Get Employee Details";
            // 
            // searchDataGridView
            // 
            this.searchDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.searchDataGridView.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGridView.Location = new System.Drawing.Point(3, 175);
            this.searchDataGridView.Name = "searchDataGridView";
            this.searchDataGridView.RowTemplate.Height = 24;
            this.searchDataGridView.Size = new System.Drawing.Size(1023, 236);
            this.searchDataGridView.TabIndex = 0;
            // 
            // tScheduleTableAdapter
            // 
            this.tScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // tEmployeeTableAdapter
            // 
            this.tEmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // tTimesheetTableAdapter
            // 
            this.tTimesheetTableAdapter.ClearBeforeFill = true;
            // 
            // payrollDataSetBindingSource
            // 
            this.payrollDataSetBindingSource.DataSource = this.payrollDataSet;
            this.payrollDataSetBindingSource.Position = 0;
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::payroll_system.Properties.Resources.texture_1668079_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1039, 587);
            this.Controls.Add(this.adminTabControl);
            this.Name = "Admin_Form";
            this.Text = "Admin_Form";
            this.Load += new System.EventHandler(this.Admin_Form_Load);
            this.adminTabControl.ResumeLayout(false);
            this.employeeList.ResumeLayout(false);
            this.employeeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollDataSet)).EndInit();
            this.editSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editEmployeeScheduleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tScheduleBindingSource)).EndInit();
            this.editTimesheet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editEmployeeTimesheetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTimesheetBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTableBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl adminTabControl;
        private System.Windows.Forms.TabPage employeeList;
        private System.Windows.Forms.TabPage editSchedule;
        private System.Windows.Forms.TabPage editTimesheet;
        private System.Windows.Forms.DataGridView employeeListGridView;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.RadioButton timesheetRadioButton;
        private System.Windows.Forms.RadioButton scheduleRadioButton;
        private System.Windows.Forms.BindingSource employeeTableBinding;
        private System.Windows.Forms.DataGridView editEmployeeScheduleDataGridView;
        private System.Windows.Forms.DataGridView editEmployeeTimesheetDataGridView;
        private System.Windows.Forms.Button deleteSchedule;
        private System.Windows.Forms.Button deleteTimesheetButton;
        private System.Windows.Forms.Button editTimesheetButton;
        private System.Windows.Forms.Button editScheduleButton;
        private PayrollDataSet payrollDataSet;
        private System.Windows.Forms.BindingSource tScheduleBindingSource;
        private PayrollDataSetTableAdapters.TScheduleTableAdapter tScheduleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tEmployeeBindingSource;
        private PayrollDataSetTableAdapters.TEmployeeTableAdapter tEmployeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateHiredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourlyRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tTimesheetBindingSource;
        private PayrollDataSetTableAdapters.TTimesheetTableAdapter tTimesheetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn timesheetIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLockInTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clockOutTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView searchDataGridView;
        private System.Windows.Forms.BindingSource payrollDataSetBindingSource;
        private System.Windows.Forms.Button searchEmployeeDetailsButton;
        private System.Windows.Forms.TextBox getEmployeeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchScheduleForThatDateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker scheduleDate;
    }
}