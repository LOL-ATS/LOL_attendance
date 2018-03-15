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
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOLDBDataSet = new LOL_attendance.LOLDBDataSet();
            this.comboBoxSitename = new System.Windows.Forms.ComboBox();
            this.lblSitemngr = new System.Windows.Forms.Label();
            this.lblSitename = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dataGridViewTS = new System.Windows.Forms.DataGridView();
            this.clmnEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnWorkingHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnReject = new System.Windows.Forms.Button();
            this.employeeTableAdapter = new LOL_attendance.LOLDBDataSetTableAdapters.employeeTableAdapter();
            this.lblTSStatus = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOLDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTS)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(88, 62);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 0;
            // 
            // comboBoxSitemngr
            // 
            this.comboBoxSitemngr.DisplayMember = "name";
            this.comboBoxSitemngr.FormattingEnabled = true;
            this.comboBoxSitemngr.Location = new System.Drawing.Point(88, 12);
            this.comboBoxSitemngr.Name = "comboBoxSitemngr";
            this.comboBoxSitemngr.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSitemngr.TabIndex = 1;
            this.comboBoxSitemngr.ValueMember = "name";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.lOLDBDataSet;
            // 
            // lOLDBDataSet
            // 
            this.lOLDBDataSet.DataSetName = "LOLDBDataSet";
            this.lOLDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxSitename
            // 
            this.comboBoxSitename.FormattingEnabled = true;
            this.comboBoxSitename.Location = new System.Drawing.Point(88, 37);
            this.comboBoxSitename.Name = "comboBoxSitename";
            this.comboBoxSitename.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSitename.TabIndex = 2;
            // 
            // lblSitemngr
            // 
            this.lblSitemngr.AutoSize = true;
            this.lblSitemngr.Location = new System.Drawing.Point(12, 16);
            this.lblSitemngr.Name = "lblSitemngr";
            this.lblSitemngr.Size = new System.Drawing.Size(70, 13);
            this.lblSitemngr.TabIndex = 3;
            this.lblSitemngr.Text = "Site Manager";
            // 
            // lblSitename
            // 
            this.lblSitename.AutoSize = true;
            this.lblSitename.Location = new System.Drawing.Point(12, 41);
            this.lblSitename.Name = "lblSitename";
            this.lblSitename.Size = new System.Drawing.Size(56, 13);
            this.lblSitename.TabIndex = 4;
            this.lblSitename.Text = "Site Name";
            this.lblSitename.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 66);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // dataGridViewTS
            // 
            this.dataGridViewTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnEmployeeName,
            this.clmnEmployeeId,
            this.clmnWorkingHours});
            this.dataGridViewTS.Location = new System.Drawing.Point(15, 102);
            this.dataGridViewTS.Name = "dataGridViewTS";
            this.dataGridViewTS.Size = new System.Drawing.Size(436, 174);
            this.dataGridViewTS.TabIndex = 6;
            // 
            // clmnEmployeeName
            // 
            this.clmnEmployeeName.HeaderText = "Employee Name";
            this.clmnEmployeeName.Name = "clmnEmployeeName";
            this.clmnEmployeeName.Width = 150;
            // 
            // clmnEmployeeId
            // 
            this.clmnEmployeeId.HeaderText = "Employee Id";
            this.clmnEmployeeId.Name = "clmnEmployeeId";
            // 
            // clmnWorkingHours
            // 
            this.clmnWorkingHours.HeaderText = "Working Hours";
            this.clmnWorkingHours.Name = "clmnWorkingHours";
            this.clmnWorkingHours.Width = 150;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(139, 282);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(376, 282);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(218, 282);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(75, 23);
            this.btnApprove.TabIndex = 9;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(309, 17);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status";
            // 
            // btnReject
            // 
            this.btnReject.Location = new System.Drawing.Point(297, 282);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(75, 23);
            this.btnReject.TabIndex = 12;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // lblTSStatus
            // 
            this.lblTSStatus.AutoSize = true;
            this.lblTSStatus.Location = new System.Drawing.Point(352, 17);
            this.lblTSStatus.Name = "lblTSStatus";
            this.lblTSStatus.Size = new System.Drawing.Size(29, 13);
            this.lblTSStatus.TabIndex = 13;
            this.lblTSStatus.Text = "New";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(370, 61);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmTimesheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 314);
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
            this.Name = "frmTimesheet";
            this.Text = "Site Timesheet";
            this.Load += new System.EventHandler(this.frmTimesheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOLDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTS)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnWorkingHours;
        private System.Windows.Forms.Button btnReject;
        private LOLDBDataSet lOLDBDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private LOLDBDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Label lblTSStatus;
        private System.Windows.Forms.Button btnSearch;
    }
}