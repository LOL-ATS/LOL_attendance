namespace LOL_attendance
{
    partial class frmTimesheet
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSitemngr = new System.Windows.Forms.ComboBox();
            this.comboBoxSitename = new System.Windows.Forms.ComboBox();
            this.lblSitemngr = new System.Windows.Forms.Label();
            this.lblSitename = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dataGridViewTS = new System.Windows.Forms.DataGridView();
            this.TsSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmployeeSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnWorkingHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmployeeStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnReject = new System.Windows.Forms.Button();
            this.lblTSStatus = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridViewEmploye = new System.Windows.Forms.DataGridView();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnDelEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmploye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(176, 119);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(396, 31);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.Updatedata);
            // 
            // comboBoxSitemngr
            // 
            this.comboBoxSitemngr.DisplayMember = "name";
            this.comboBoxSitemngr.FormattingEnabled = true;
            this.comboBoxSitemngr.Location = new System.Drawing.Point(176, 23);
            this.comboBoxSitemngr.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxSitemngr.Name = "comboBoxSitemngr";
            this.comboBoxSitemngr.Size = new System.Drawing.Size(238, 33);
            this.comboBoxSitemngr.TabIndex = 1;
            this.comboBoxSitemngr.ValueMember = "name";
            this.comboBoxSitemngr.SelectedIndexChanged += new System.EventHandler(this.Updatedata);
            // 
            // comboBoxSitename
            // 
            this.comboBoxSitename.FormattingEnabled = true;
            this.comboBoxSitename.Location = new System.Drawing.Point(176, 71);
            this.comboBoxSitename.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxSitename.Name = "comboBoxSitename";
            this.comboBoxSitename.Size = new System.Drawing.Size(238, 33);
            this.comboBoxSitename.TabIndex = 2;
            this.comboBoxSitename.SelectedIndexChanged += new System.EventHandler(this.Updatedata);
            // 
            // lblSitemngr
            // 
            this.lblSitemngr.AutoSize = true;
            this.lblSitemngr.Location = new System.Drawing.Point(24, 31);
            this.lblSitemngr.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSitemngr.Name = "lblSitemngr";
            this.lblSitemngr.Size = new System.Drawing.Size(140, 25);
            this.lblSitemngr.TabIndex = 3;
            this.lblSitemngr.Text = "Site Manager";
            // 
            // lblSitename
            // 
            this.lblSitename.AutoSize = true;
            this.lblSitename.Location = new System.Drawing.Point(24, 79);
            this.lblSitename.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSitename.Name = "lblSitename";
            this.lblSitename.Size = new System.Drawing.Size(111, 25);
            this.lblSitename.TabIndex = 4;
            this.lblSitename.Text = "Site Name";
            this.lblSitename.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(24, 127);
            this.lblDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(57, 25);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // dataGridViewTS
            // 
            this.dataGridViewTS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TsSelected,
            this.clmnEmployeeId,
            this.clmnEmployeeName,
            this.clmnEmployeeSurname,
            this.clmnWorkingHours,
            this.clmnEmployeeStatus});
            this.dataGridViewTS.Location = new System.Drawing.Point(539, 196);
            this.dataGridViewTS.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridViewTS.Name = "dataGridViewTS";
            this.dataGridViewTS.RowHeadersVisible = false;
            this.dataGridViewTS.Size = new System.Drawing.Size(860, 410);
            this.dataGridViewTS.TabIndex = 6;
            // 
            // TsSelected
            // 
            this.TsSelected.HeaderText = "";
            this.TsSelected.Name = "TsSelected";
            this.TsSelected.Width = 33;
            // 
            // clmnEmployeeId
            // 
            this.clmnEmployeeId.HeaderText = "Id";
            this.clmnEmployeeId.Name = "clmnEmployeeId";
            this.clmnEmployeeId.Width = 74;
            // 
            // clmnEmployeeName
            // 
            this.clmnEmployeeName.HeaderText = "Name";
            this.clmnEmployeeName.Name = "clmnEmployeeName";
            this.clmnEmployeeName.Width = 113;
            // 
            // clmnEmployeeSurname
            // 
            this.clmnEmployeeSurname.HeaderText = "Surname";
            this.clmnEmployeeSurname.Name = "clmnEmployeeSurname";
            this.clmnEmployeeSurname.Width = 143;
            // 
            // clmnWorkingHours
            // 
            this.clmnWorkingHours.HeaderText = "Working Hours";
            this.clmnWorkingHours.Name = "clmnWorkingHours";
            this.clmnWorkingHours.Width = 183;
            // 
            // clmnEmployeeStatus
            // 
            this.clmnEmployeeStatus.HeaderText = "Status";
            this.clmnEmployeeStatus.Name = "clmnEmployeeStatus";
            this.clmnEmployeeStatus.Width = 118;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(539, 618);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 44);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1013, 618);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 44);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(697, 618);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(6);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(150, 44);
            this.btnApprove.TabIndex = 9;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(618, 33);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(73, 25);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status";
            // 
            // btnReject
            // 
            this.btnReject.Location = new System.Drawing.Point(855, 618);
            this.btnReject.Margin = new System.Windows.Forms.Padding(6);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(150, 44);
            this.btnReject.TabIndex = 12;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            // 
            // lblTSStatus
            // 
            this.lblTSStatus.AutoSize = true;
            this.lblTSStatus.Location = new System.Drawing.Point(704, 33);
            this.lblTSStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTSStatus.Name = "lblTSStatus";
            this.lblTSStatus.Size = new System.Drawing.Size(54, 25);
            this.lblTSStatus.TabIndex = 13;
            this.lblTSStatus.Text = "New";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(740, 117);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 44);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridViewEmploye
            // 
            this.dataGridViewEmploye.AllowUserToAddRows = false;
            this.dataGridViewEmploye.AllowUserToDeleteRows = false;
            this.dataGridViewEmploye.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridViewEmploye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmploye.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected});
            this.dataGridViewEmploye.Location = new System.Drawing.Point(29, 196);
            this.dataGridViewEmploye.Name = "dataGridViewEmploye";
            this.dataGridViewEmploye.RowHeadersVisible = false;
            this.dataGridViewEmploye.RowTemplate.Height = 33;
            this.dataGridViewEmploye.Size = new System.Drawing.Size(412, 423);
            this.dataGridViewEmploye.TabIndex = 15;
            // 
            // Selected
            // 
            this.Selected.HeaderText = "";
            this.Selected.Name = "Selected";
            this.Selected.Width = 5;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(455, 376);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(75, 62);
            this.btnAddEmployee.TabIndex = 16;
            this.btnAddEmployee.Text = ">>";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnDelEmployee
            // 
            this.btnDelEmployee.Location = new System.Drawing.Point(455, 308);
            this.btnDelEmployee.Name = "btnDelEmployee";
            this.btnDelEmployee.Size = new System.Drawing.Size(75, 62);
            this.btnDelEmployee.TabIndex = 17;
            this.btnDelEmployee.Text = "<<";
            this.btnDelEmployee.UseVisualStyleBackColor = true;
            // 
            // frmTimesheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 677);
            this.Controls.Add(this.btnDelEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.dataGridViewEmploye);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblTSStatus);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridViewTS);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblSitename);
            this.Controls.Add(this.lblSitemngr);
            this.Controls.Add(this.comboBoxSitename);
            this.Controls.Add(this.comboBoxSitemngr);
            this.Controls.Add(this.dateTimePicker);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmTimesheet";
            this.Text = "Site Timesheet";
            this.Load += new System.EventHandler(this.frmTimesheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmploye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBoxSitemngr;
        private System.Windows.Forms.ComboBox comboBoxSitename;
        private System.Windows.Forms.Label lblSitemngr;
        private System.Windows.Forms.Label lblSitename;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridView dataGridViewTS;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnReject;

        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.Label lblTSStatus;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridViewEmploye;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnDelEmployee;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TsSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmployeeSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnWorkingHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmployeeStatus;
    }
}