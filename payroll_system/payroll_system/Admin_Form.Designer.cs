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
            this.editEmployeeInfoTextBox = new System.Windows.Forms.TextBox();
            this.employeeListGridView = new System.Windows.Forms.DataGridView();
            this.editSchedule = new System.Windows.Forms.TabPage();
            this.editEmployeeScheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.editTimesheet = new System.Windows.Forms.TabPage();
            this.editEmployeeTimesheetDataGridView = new System.Windows.Forms.DataGridView();
            this.employeeTableBinding = new System.Windows.Forms.BindingSource(this.components);
            this.AddSchedule = new System.Windows.Forms.Button();
            this.deleteSchedule = new System.Windows.Forms.Button();
            this.addTimesheet = new System.Windows.Forms.Button();
            this.editTimesheetButton = new System.Windows.Forms.Button();
            this.deleteTimesheetButton = new System.Windows.Forms.Button();
            this.editScheduleButton = new System.Windows.Forms.Button();
            this.adminTabControl.SuspendLayout();
            this.employeeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListGridView)).BeginInit();
            this.editSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editEmployeeScheduleDataGridView)).BeginInit();
            this.editTimesheet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editEmployeeTimesheetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTableBinding)).BeginInit();
            this.SuspendLayout();
            // 
            // adminTabControl
            // 
            this.adminTabControl.Controls.Add(this.employeeList);
            this.adminTabControl.Controls.Add(this.editSchedule);
            this.adminTabControl.Controls.Add(this.editTimesheet);
            this.adminTabControl.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTabControl.Location = new System.Drawing.Point(2, 102);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(860, 425);
            this.adminTabControl.TabIndex = 0;
            // 
            // employeeList
            // 
            this.employeeList.Controls.Add(this.editButton);
            this.employeeList.Controls.Add(this.timesheetRadioButton);
            this.employeeList.Controls.Add(this.scheduleRadioButton);
            this.employeeList.Controls.Add(this.editEmployeeInfoTextBox);
            this.employeeList.Controls.Add(this.employeeListGridView);
            this.employeeList.Location = new System.Drawing.Point(4, 39);
            this.employeeList.Name = "employeeList";
            this.employeeList.Padding = new System.Windows.Forms.Padding(3);
            this.employeeList.Size = new System.Drawing.Size(852, 382);
            this.employeeList.TabIndex = 0;
            this.employeeList.Text = "Employee List";
            this.employeeList.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(694, 332);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(95, 31);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // timesheetRadioButton
            // 
            this.timesheetRadioButton.AutoSize = true;
            this.timesheetRadioButton.Location = new System.Drawing.Point(447, 333);
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
            this.scheduleRadioButton.Location = new System.Drawing.Point(255, 333);
            this.scheduleRadioButton.Name = "scheduleRadioButton";
            this.scheduleRadioButton.Size = new System.Drawing.Size(109, 34);
            this.scheduleRadioButton.TabIndex = 2;
            this.scheduleRadioButton.TabStop = true;
            this.scheduleRadioButton.Text = "Schedule";
            this.scheduleRadioButton.UseVisualStyleBackColor = true;
            // 
            // editEmployeeInfoTextBox
            // 
            this.editEmployeeInfoTextBox.Location = new System.Drawing.Point(46, 329);
            this.editEmployeeInfoTextBox.Name = "editEmployeeInfoTextBox";
            this.editEmployeeInfoTextBox.Size = new System.Drawing.Size(153, 38);
            this.editEmployeeInfoTextBox.TabIndex = 1;
            this.editEmployeeInfoTextBox.TextChanged += new System.EventHandler(this.editEmployeeInfoTextBox_TextChanged);
            // 
            // employeeListGridView
            // 
            this.employeeListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeListGridView.Location = new System.Drawing.Point(46, 4);
            this.employeeListGridView.Name = "employeeListGridView";
            this.employeeListGridView.ReadOnly = true;
            this.employeeListGridView.RowTemplate.Height = 24;
            this.employeeListGridView.Size = new System.Drawing.Size(757, 319);
            this.employeeListGridView.TabIndex = 0;
            // 
            // editSchedule
            // 
            this.editSchedule.Controls.Add(this.editScheduleButton);
            this.editSchedule.Controls.Add(this.deleteSchedule);
            this.editSchedule.Controls.Add(this.AddSchedule);
            this.editSchedule.Controls.Add(this.editEmployeeScheduleDataGridView);
            this.editSchedule.Location = new System.Drawing.Point(4, 39);
            this.editSchedule.Name = "editSchedule";
            this.editSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.editSchedule.Size = new System.Drawing.Size(852, 382);
            this.editSchedule.TabIndex = 1;
            this.editSchedule.Text = "Edit Schedule";
            this.editSchedule.UseVisualStyleBackColor = true;
            // 
            // editEmployeeScheduleDataGridView
            // 
            this.editEmployeeScheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editEmployeeScheduleDataGridView.Location = new System.Drawing.Point(168, 6);
            this.editEmployeeScheduleDataGridView.Name = "editEmployeeScheduleDataGridView";
            this.editEmployeeScheduleDataGridView.RowTemplate.Height = 24;
            this.editEmployeeScheduleDataGridView.Size = new System.Drawing.Size(506, 267);
            this.editEmployeeScheduleDataGridView.TabIndex = 0;
            // 
            // editTimesheet
            // 
            this.editTimesheet.Controls.Add(this.deleteTimesheetButton);
            this.editTimesheet.Controls.Add(this.editTimesheetButton);
            this.editTimesheet.Controls.Add(this.addTimesheet);
            this.editTimesheet.Controls.Add(this.editEmployeeTimesheetDataGridView);
            this.editTimesheet.Location = new System.Drawing.Point(4, 39);
            this.editTimesheet.Name = "editTimesheet";
            this.editTimesheet.Size = new System.Drawing.Size(852, 382);
            this.editTimesheet.TabIndex = 2;
            this.editTimesheet.Text = "Edit Timesheet";
            this.editTimesheet.UseVisualStyleBackColor = true;
            // 
            // editEmployeeTimesheetDataGridView
            // 
            this.editEmployeeTimesheetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editEmployeeTimesheetDataGridView.Location = new System.Drawing.Point(46, 3);
            this.editEmployeeTimesheetDataGridView.Name = "editEmployeeTimesheetDataGridView";
            this.editEmployeeTimesheetDataGridView.RowTemplate.Height = 24;
            this.editEmployeeTimesheetDataGridView.Size = new System.Drawing.Size(767, 323);
            this.editEmployeeTimesheetDataGridView.TabIndex = 0;
            this.editEmployeeTimesheetDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectedEmployee);
            // 
            // AddSchedule
            // 
            this.AddSchedule.Location = new System.Drawing.Point(193, 313);
            this.AddSchedule.Name = "AddSchedule";
            this.AddSchedule.Size = new System.Drawing.Size(97, 37);
            this.AddSchedule.TabIndex = 1;
            this.AddSchedule.Text = "Add";
            this.AddSchedule.UseVisualStyleBackColor = true;
            // 
            // deleteSchedule
            // 
            this.deleteSchedule.Location = new System.Drawing.Point(545, 313);
            this.deleteSchedule.Name = "deleteSchedule";
            this.deleteSchedule.Size = new System.Drawing.Size(97, 37);
            this.deleteSchedule.TabIndex = 2;
            this.deleteSchedule.Text = "Delete";
            this.deleteSchedule.UseVisualStyleBackColor = true;
            // 
            // addTimesheet
            // 
            this.addTimesheet.Location = new System.Drawing.Point(183, 337);
            this.addTimesheet.Name = "addTimesheet";
            this.addTimesheet.Size = new System.Drawing.Size(97, 37);
            this.addTimesheet.TabIndex = 2;
            this.addTimesheet.Text = "Add";
            this.addTimesheet.UseVisualStyleBackColor = true;
            // 
            // editTimesheetButton
            // 
            this.editTimesheetButton.Location = new System.Drawing.Point(361, 337);
            this.editTimesheetButton.Name = "editTimesheetButton";
            this.editTimesheetButton.Size = new System.Drawing.Size(97, 37);
            this.editTimesheetButton.TabIndex = 3;
            this.editTimesheetButton.Text = "Edit";
            this.editTimesheetButton.UseVisualStyleBackColor = true;
            // 
            // deleteTimesheetButton
            // 
            this.deleteTimesheetButton.Location = new System.Drawing.Point(528, 337);
            this.deleteTimesheetButton.Name = "deleteTimesheetButton";
            this.deleteTimesheetButton.Size = new System.Drawing.Size(97, 37);
            this.deleteTimesheetButton.TabIndex = 4;
            this.deleteTimesheetButton.Text = "Delete";
            this.deleteTimesheetButton.UseVisualStyleBackColor = true;
            this.deleteTimesheetButton.Click += new System.EventHandler(this.deleteTimesheetButton_Click);
            // 
            // editScheduleButton
            // 
            this.editScheduleButton.Location = new System.Drawing.Point(368, 313);
            this.editScheduleButton.Name = "editScheduleButton";
            this.editScheduleButton.Size = new System.Drawing.Size(97, 37);
            this.editScheduleButton.TabIndex = 3;
            this.editScheduleButton.Text = "Edit";
            this.editScheduleButton.UseVisualStyleBackColor = true;
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 527);
            this.Controls.Add(this.adminTabControl);
            this.Name = "Admin_Form";
            this.Text = "Admin_Form";
            this.Load += new System.EventHandler(this.Admin_Form_Load);
            this.adminTabControl.ResumeLayout(false);
            this.employeeList.ResumeLayout(false);
            this.employeeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListGridView)).EndInit();
            this.editSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editEmployeeScheduleDataGridView)).EndInit();
            this.editTimesheet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editEmployeeTimesheetDataGridView)).EndInit();
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
        private System.Windows.Forms.TextBox editEmployeeInfoTextBox;
        private System.Windows.Forms.BindingSource employeeTableBinding;
        private System.Windows.Forms.DataGridView editEmployeeScheduleDataGridView;
        private System.Windows.Forms.DataGridView editEmployeeTimesheetDataGridView;
        private System.Windows.Forms.Button deleteSchedule;
        private System.Windows.Forms.Button AddSchedule;
        private System.Windows.Forms.Button deleteTimesheetButton;
        private System.Windows.Forms.Button editTimesheetButton;
        private System.Windows.Forms.Button addTimesheet;
        private System.Windows.Forms.Button editScheduleButton;
    }
}