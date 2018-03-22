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
            this.comboProjects = new System.Windows.Forms.ComboBox();
            this.comboBoxSitename = new System.Windows.Forms.ComboBox();
            this.lblSitemngr = new System.Windows.Forms.Label();
            this.lblSitename = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dataGridViewTS = new System.Windows.Forms.DataGridView();
            this.TsSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
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
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(93, 113);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(276, 26);
            this.dateTimePicker.TabIndex = 3;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // comboProjects
            // 
            this.comboProjects.DisplayMember = "name";
            this.comboProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProjects.FormattingEnabled = true;
            this.comboProjects.Location = new System.Drawing.Point(93, 19);
            this.comboProjects.Name = "comboProjects";
            this.comboProjects.Size = new System.Drawing.Size(276, 28);
            this.comboProjects.TabIndex = 1;
            this.comboProjects.ValueMember = "name";
            this.comboProjects.SelectedIndexChanged += new System.EventHandler(this.comboProjects_SelectedIndexChanged);
            // 
            // comboBoxSitename
            // 
            this.comboBoxSitename.Enabled = false;
            this.comboBoxSitename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSitename.FormattingEnabled = true;
            this.comboBoxSitename.Location = new System.Drawing.Point(93, 64);
            this.comboBoxSitename.Name = "comboBoxSitename";
            this.comboBoxSitename.Size = new System.Drawing.Size(276, 28);
            this.comboBoxSitename.TabIndex = 2;
            this.comboBoxSitename.SelectedIndexChanged += new System.EventHandler(this.comboBoxSitename_SelectedIndexChanged);
            // 
            // lblSitemngr
            // 
            this.lblSitemngr.AutoSize = true;
            this.lblSitemngr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSitemngr.Location = new System.Drawing.Point(5, 25);
            this.lblSitemngr.Name = "lblSitemngr";
            this.lblSitemngr.Size = new System.Drawing.Size(66, 20);
            this.lblSitemngr.TabIndex = 3;
            this.lblSitemngr.Text = "Projects";
            // 
            // lblSitename
            // 
            this.lblSitename.AutoSize = true;
            this.lblSitename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSitename.Location = new System.Drawing.Point(5, 71);
            this.lblSitename.Name = "lblSitename";
            this.lblSitename.Size = new System.Drawing.Size(83, 20);
            this.lblSitename.TabIndex = 4;
            this.lblSitename.Text = "Site Name";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(5, 117);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // dataGridViewTS
            // 
            this.dataGridViewTS.AllowUserToAddRows = false;
            this.dataGridViewTS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TsSelected});
            this.dataGridViewTS.Location = new System.Drawing.Point(298, 164);
            this.dataGridViewTS.Name = "dataGridViewTS";
            this.dataGridViewTS.RowHeadersVisible = false;
            this.dataGridViewTS.Size = new System.Drawing.Size(280, 228);
            this.dataGridViewTS.TabIndex = 6;
            // 
            // TsSelected
            // 
            this.TsSelected.HeaderText = "";
            this.TsSelected.Name = "TsSelected";
            this.TsSelected.Width = 5;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(296, 398);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 32);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.Location = new System.Drawing.Point(392, 398);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(90, 32);
            this.btnApprove.TabIndex = 8;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnReject
            // 
            this.btnReject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.Location = new System.Drawing.Point(488, 398);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(90, 32);
            this.btnReject.TabIndex = 9;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(392, 58);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 32);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEmploye
            // 
            this.dataGridViewEmploye.AllowUserToAddRows = false;
            this.dataGridViewEmploye.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewEmploye.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridViewEmploye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmploye.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected});
            this.dataGridViewEmploye.Location = new System.Drawing.Point(9, 164);
            this.dataGridViewEmploye.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewEmploye.Name = "dataGridViewEmploye";
            this.dataGridViewEmploye.RowHeadersVisible = false;
            this.dataGridViewEmploye.RowTemplate.Height = 33;
            this.dataGridViewEmploye.Size = new System.Drawing.Size(204, 228);
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
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(218, 216);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(75, 32);
            this.btnAddEmployee.TabIndex = 5;
            this.btnAddEmployee.Text = ">>";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnDelEmployee
            // 
            this.btnDelEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelEmployee.Location = new System.Drawing.Point(218, 252);
            this.btnDelEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelEmployee.Name = "btnDelEmployee";
            this.btnDelEmployee.Size = new System.Drawing.Size(75, 32);
            this.btnDelEmployee.TabIndex = 6;
            this.btnDelEmployee.Text = "<<";
            this.btnDelEmployee.UseVisualStyleBackColor = true;
            this.btnDelEmployee.Click += new System.EventHandler(this.btnDelEmployee_Click);
            // 
            // frmTimesheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 389);
            this.Controls.Add(this.btnDelEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.dataGridViewEmploye);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridViewTS);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblSitename);
            this.Controls.Add(this.lblSitemngr);
            this.Controls.Add(this.comboBoxSitename);
            this.Controls.Add(this.comboProjects);
            this.Controls.Add(this.dateTimePicker);
            this.MinimumSize = new System.Drawing.Size(602, 396);
            this.Name = "frmTimesheet";
            this.Text = "Site Timesheet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTimesheet_Load);
            this.Shown += new System.EventHandler(this.frmTimesheet_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmploye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboProjects;
        private System.Windows.Forms.ComboBox comboBoxSitename;
        private System.Windows.Forms.Label lblSitemngr;
        private System.Windows.Forms.Label lblSitename;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridView dataGridViewTS;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnReject;

        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridViewEmploye;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnDelEmployee;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TsSelected;
    }
}