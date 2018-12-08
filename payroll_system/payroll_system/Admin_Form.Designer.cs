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
            this.employeeTableBinding = new System.Windows.Forms.BindingSource(this.components);
            this.tScheduleTableAdapter = new payroll_system.PayrollDataSetTableAdapters.TScheduleTableAdapter();
            this.tEmployeeTableAdapter = new payroll_system.PayrollDataSetTableAdapters.TEmployeeTableAdapter();
            this.tTimesheetTableAdapter = new payroll_system.PayrollDataSetTableAdapters.TTimesheetTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.employeeTableBinding)).BeginInit();
            this.SuspendLayout();
            // 
            // adminTabControl
            // 
            this.adminTabControl.Controls.Add(this.employeeList);
            this.adminTabControl.Controls.Add(this.editSchedule);
            this.adminTabControl.Controls.Add(this.editTimesheet);
            this.adminTabControl.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTabControl.Location = new System.Drawing.Point(0, 60);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(1037, 457);
            this.adminTabControl.TabIndex = 0;
            // 
            // employeeList
            // 
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
            this.employeeList.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(693, 358);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(95, 31);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // timesheetRadioButton
            // 
            this.timesheetRadioButton.AutoSize = true;
            this.timesheetRadioButton.Location = new System.Drawing.Point(408, 359);
            this.timesheetRadioButton.Name = "timesheetRadioButton";
            this.timesheetRadioButton.Size = new System.Drawing.Size(120, 34);
            this.timesheetRadioButton.TabIndex = 3;
            this.timesheetRadioButton.TabStop = true;
            this.timesheetRadioButton.Text = "Timesheet";
            this.timesheetRadioButton.UseVisualStyleBackColor = true;
            // 
            // scheduleRadioButton
            // 
            this.scheduleRadioButton.AutoSize = true;
            this.scheduleRadioButton.Location = new System.Drawing.Point(184, 359);
            this.scheduleRadioButton.Name = "scheduleRadioButton";
            this.scheduleRadioButton.Size = new System.Drawing.Size(109, 34);
            this.scheduleRadioButton.TabIndex = 2;
            this.scheduleRadioButton.TabStop = true;
            this.scheduleRadioButton.Text = "Schedule";
            this.scheduleRadioButton.UseVisualStyleBackColor = true;
            // 
            // employeeListGridView
            // 
            this.employeeListGridView.AutoGenerateColumns = false;
            this.employeeListGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeeListGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.employeeListGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.employeeListGridView.Location = new System.Drawing.Point(6, 0);
            this.employeeListGridView.Name = "employeeListGridView";
            this.employeeListGridView.ReadOnly = true;
            this.employeeListGridView.RowTemplate.Height = 24;
            this.employeeListGridView.Size = new System.Drawing.Size(1026, 319);
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
            this.editSchedule.Controls.Add(this.editScheduleButton);
            this.editSchedule.Controls.Add(this.deleteSchedule);
            this.editSchedule.Controls.Add(this.editEmployeeScheduleDataGridView);
            this.editSchedule.Location = new System.Drawing.Point(4, 39);
            this.editSchedule.Name = "editSchedule";
            this.editSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.editSchedule.Size = new System.Drawing.Size(1029, 414);
            this.editSchedule.TabIndex = 1;
            this.editSchedule.Text = "Edit Schedule";
            this.editSchedule.UseVisualStyleBackColor = true;
            // 
            // editScheduleButton
            // 
            this.editScheduleButton.Location = new System.Drawing.Point(376, 371);
            this.editScheduleButton.Name = "editScheduleButton";
            this.editScheduleButton.Size = new System.Drawing.Size(97, 37);
            this.editScheduleButton.TabIndex = 3;
            this.editScheduleButton.Text = "Save";
            this.editScheduleButton.UseVisualStyleBackColor = true;
            this.editScheduleButton.Click += new System.EventHandler(this.editScheduleButton_Click);
            // 
            // deleteSchedule
            // 
            this.deleteSchedule.Location = new System.Drawing.Point(553, 371);
            this.deleteSchedule.Name = "deleteSchedule";
            this.deleteSchedule.Size = new System.Drawing.Size(97, 37);
            this.deleteSchedule.TabIndex = 2;
            this.deleteSchedule.Text = "Delete";
            this.deleteSchedule.UseVisualStyleBackColor = true;
            this.deleteSchedule.Click += new System.EventHandler(this.deleteSchedule_Click);
            // 
            // editEmployeeScheduleDataGridView
            // 
            this.editEmployeeScheduleDataGridView.AutoGenerateColumns = false;
            this.editEmployeeScheduleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.editEmployeeScheduleDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.editEmployeeScheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editEmployeeScheduleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scheduleIdDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn});
            this.editEmployeeScheduleDataGridView.DataSource = this.tScheduleBindingSource;
            this.editEmployeeScheduleDataGridView.Location = new System.Drawing.Point(3, 6);
            this.editEmployeeScheduleDataGridView.Name = "editEmployeeScheduleDataGridView";
            this.editEmployeeScheduleDataGridView.RowTemplate.Height = 24;
            this.editEmployeeScheduleDataGridView.Size = new System.Drawing.Size(1026, 340);
            this.editEmployeeScheduleDataGridView.TabIndex = 0;
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
            this.editTimesheet.Controls.Add(this.deleteTimesheetButton);
            this.editTimesheet.Controls.Add(this.editTimesheetButton);
            this.editTimesheet.Controls.Add(this.editEmployeeTimesheetDataGridView);
            this.editTimesheet.Location = new System.Drawing.Point(4, 39);
            this.editTimesheet.Name = "editTimesheet";
            this.editTimesheet.Size = new System.Drawing.Size(1029, 414);
            this.editTimesheet.TabIndex = 2;
            this.editTimesheet.Text = "Edit Timesheet";
            this.editTimesheet.UseVisualStyleBackColor = true;
            // 
            // deleteTimesheetButton
            // 
            this.deleteTimesheetButton.Location = new System.Drawing.Point(523, 357);
            this.deleteTimesheetButton.Name = "deleteTimesheetButton";
            this.deleteTimesheetButton.Size = new System.Drawing.Size(97, 37);
            this.deleteTimesheetButton.TabIndex = 4;
            this.deleteTimesheetButton.Text = "Delete";
            this.deleteTimesheetButton.UseVisualStyleBackColor = true;
            this.deleteTimesheetButton.Click += new System.EventHandler(this.deleteTimesheetButton_Click);
            // 
            // editTimesheetButton
            // 
            this.editTimesheetButton.Location = new System.Drawing.Point(356, 357);
            this.editTimesheetButton.Name = "editTimesheetButton";
            this.editTimesheetButton.Size = new System.Drawing.Size(97, 37);
            this.editTimesheetButton.TabIndex = 3;
            this.editTimesheetButton.Text = "Save";
            this.editTimesheetButton.UseVisualStyleBackColor = true;
            this.editTimesheetButton.Click += new System.EventHandler(this.editTimesheetButton_Click);
            // 
            // editEmployeeTimesheetDataGridView
            // 
            this.editEmployeeTimesheetDataGridView.AutoGenerateColumns = false;
            this.editEmployeeTimesheetDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.editEmployeeTimesheetDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.editEmployeeTimesheetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editEmployeeTimesheetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timesheetIdDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn2,
            this.dateDataGridViewTextBoxColumn1,
            this.cLockInTimeDataGridViewTextBoxColumn,
            this.clockOutTimeDataGridViewTextBoxColumn,
            this.totalHoursDataGridViewTextBoxColumn});
            this.editEmployeeTimesheetDataGridView.DataSource = this.tTimesheetBindingSource;
            this.editEmployeeTimesheetDataGridView.Location = new System.Drawing.Point(0, 3);
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
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::payroll_system.Properties.Resources.formbackground1;
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
            ((System.ComponentModel.ISupportInitialize)(this.employeeTableBinding)).EndInit();
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
    }
}