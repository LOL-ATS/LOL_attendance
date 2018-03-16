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
            this.clmnEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnWorkingHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnReject = new System.Windows.Forms.Button();
            this.lblTSStatus = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnAdd2Ts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.comboBoxSitemngr.SelectedIndexChanged += new System.EventHandler(this.comboBoxSitemngr_SelectedIndexChanged);
            // 
            // comboBoxSitename
            // 
            this.comboBoxSitename.FormattingEnabled = true;
            this.comboBoxSitename.Location = new System.Drawing.Point(176, 71);
            this.comboBoxSitename.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxSitename.Name = "comboBoxSitename";
            this.comboBoxSitename.Size = new System.Drawing.Size(238, 33);
            this.comboBoxSitename.TabIndex = 2;
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
            this.dataGridViewTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnEmployeeName,
            this.clmnEmployeeId,
            this.clmnWorkingHours});
            this.dataGridViewTS.Location = new System.Drawing.Point(539, 196);
            this.dataGridViewTS.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridViewTS.Name = "dataGridViewTS";
            this.dataGridViewTS.Size = new System.Drawing.Size(624, 410);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected});
            this.dataGridView1.Location = new System.Drawing.Point(29, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(412, 423);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            // 
            // Selected
            // 
            this.Selected.HeaderText = "";
            this.Selected.Name = "Selected";
            this.Selected.Width = 5;
            // 
            // btnAdd2Ts
            // 
            this.btnAdd2Ts.Location = new System.Drawing.Point(455, 376);
            this.btnAdd2Ts.Name = "btnAdd2Ts";
            this.btnAdd2Ts.Size = new System.Drawing.Size(75, 62);
            this.btnAdd2Ts.TabIndex = 16;
            this.btnAdd2Ts.Text = ">>";
            this.btnAdd2Ts.UseVisualStyleBackColor = true;
            // 
            // frmTimesheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 677);
            this.Controls.Add(this.btnAdd2Ts);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnWorkingHours;
        private System.Windows.Forms.Button btnReject;

        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.Label lblTSStatus;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.Button btnAdd2Ts;
    }
}