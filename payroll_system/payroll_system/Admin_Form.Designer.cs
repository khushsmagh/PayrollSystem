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
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.employeeList = new System.Windows.Forms.TabPage();
            this.editSchedule = new System.Windows.Forms.TabPage();
            this.editTimesheet = new System.Windows.Forms.TabPage();
            this.employeeListGridView = new System.Windows.Forms.DataGridView();
            this.editEmployeeInfoTextBox = new System.Windows.Forms.TextBox();
            this.scheduleRadioButton = new System.Windows.Forms.RadioButton();
            this.timesheetRadioButton = new System.Windows.Forms.RadioButton();
            this.editButton = new System.Windows.Forms.Button();
            this.adminTabControl.SuspendLayout();
            this.employeeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListGridView)).BeginInit();
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
            // editSchedule
            // 
            this.editSchedule.Location = new System.Drawing.Point(4, 39);
            this.editSchedule.Name = "editSchedule";
            this.editSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.editSchedule.Size = new System.Drawing.Size(852, 382);
            this.editSchedule.TabIndex = 1;
            this.editSchedule.Text = "Edit Schedule";
            this.editSchedule.UseVisualStyleBackColor = true;
            // 
            // editTimesheet
            // 
            this.editTimesheet.Location = new System.Drawing.Point(4, 39);
            this.editTimesheet.Name = "editTimesheet";
            this.editTimesheet.Size = new System.Drawing.Size(852, 382);
            this.editTimesheet.TabIndex = 2;
            this.editTimesheet.Text = "Edit Timesheet";
            this.editTimesheet.UseVisualStyleBackColor = true;
            // 
            // employeeListGridView
            // 
            this.employeeListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeListGridView.Location = new System.Drawing.Point(46, 4);
            this.employeeListGridView.Name = "employeeListGridView";
            this.employeeListGridView.RowTemplate.Height = 24;
            this.employeeListGridView.Size = new System.Drawing.Size(757, 319);
            this.employeeListGridView.TabIndex = 0;
            // 
            // editEmployeeInfoTextBox
            // 
            this.editEmployeeInfoTextBox.Location = new System.Drawing.Point(46, 329);
            this.editEmployeeInfoTextBox.Name = "editEmployeeInfoTextBox";
            this.editEmployeeInfoTextBox.Size = new System.Drawing.Size(153, 38);
            this.editEmployeeInfoTextBox.TabIndex = 1;
            this.editEmployeeInfoTextBox.TextChanged += new System.EventHandler(this.editEmployeeInfoTextBox_TextChanged);
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
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(694, 332);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(95, 31);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
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
    }
}