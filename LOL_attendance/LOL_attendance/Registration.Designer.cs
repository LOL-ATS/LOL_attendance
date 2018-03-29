namespace LOL_attendance
{
    partial class frmRegistration
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
            this.tabRegistration = new System.Windows.Forms.TabControl();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.lblUserStatus = new System.Windows.Forms.Label();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.grpBoxSearchByName = new System.Windows.Forms.GroupBox();
            this.txtBoxSearchByID = new System.Windows.Forms.TextBox();
            this.dgdViewEmployee = new System.Windows.Forms.DataGridView();
            this.grpBoxUserInfo = new System.Windows.Forms.GroupBox();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.lblEmployeeIDValue = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtBoxSurname = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.tabProject = new System.Windows.Forms.TabPage();
            this.lblPStatus = new System.Windows.Forms.Label();
            this.btnDeleteProject = new System.Windows.Forms.Button();
            this.btnCreateProject = new System.Windows.Forms.Button();
            this.groupBoxProject = new System.Windows.Forms.GroupBox();
            this.lblMngrID = new System.Windows.Forms.Label();
            this.btnUpdateProject = new System.Windows.Forms.Button();
            this.lblPMngrIDValue = new System.Windows.Forms.Label();
            this.lblProjectID = new System.Windows.Forms.Label();
            this.lblProjectIDValue = new System.Windows.Forms.Label();
            this.lblPMName = new System.Windows.Forms.Label();
            this.lblProjectAAddress = new System.Windows.Forms.Label();
            this.cboPM = new System.Windows.Forms.ComboBox();
            this.txtBoxPAddress = new System.Windows.Forms.TextBox();
            this.txtBoxProjectName = new System.Windows.Forms.TextBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.txtBoxSearchP = new System.Windows.Forms.TextBox();
            this.dgdViewProject = new System.Windows.Forms.DataGridView();
            this.tabSite = new System.Windows.Forms.TabPage();
            this.lblSiteStatus = new System.Windows.Forms.Label();
            this.btnDeleteSite = new System.Windows.Forms.Button();
            this.grpBoxSiteName = new System.Windows.Forms.GroupBox();
            this.txtBoxSiteSearch = new System.Windows.Forms.TextBox();
            this.dgdViewSite = new System.Windows.Forms.DataGridView();
            this.grpBoxSiteInfo = new System.Windows.Forms.GroupBox();
            this.lblProjectIDOnSiteValue = new System.Windows.Forms.Label();
            this.btnUpdateSite = new System.Windows.Forms.Button();
            this.lblProjectIDOnSite = new System.Windows.Forms.Label();
            this.lblSiteManagerIDValue = new System.Windows.Forms.Label();
            this.lblSiteManagerID = new System.Windows.Forms.Label();
            this.lblSiteIDValue = new System.Windows.Forms.Label();
            this.lblSiteID = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.cboProject = new System.Windows.Forms.ComboBox();
            this.lblSiteManager = new System.Windows.Forms.Label();
            this.lblSiteAddress = new System.Windows.Forms.Label();
            this.cboSiteManager = new System.Windows.Forms.ComboBox();
            this.txtBoxSiteAddress = new System.Windows.Forms.TextBox();
            this.txtBoxSiteName = new System.Windows.Forms.TextBox();
            this.lblSiteName = new System.Windows.Forms.Label();
            this.btnCreateSite = new System.Windows.Forms.Button();
            this.tabRegistration.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.grpBoxSearchByName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdViewEmployee)).BeginInit();
            this.grpBoxUserInfo.SuspendLayout();
            this.tabProject.SuspendLayout();
            this.groupBoxProject.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdViewProject)).BeginInit();
            this.tabSite.SuspendLayout();
            this.grpBoxSiteName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdViewSite)).BeginInit();
            this.grpBoxSiteInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabRegistration
            // 
            this.tabRegistration.AccessibleDescription = "";
            this.tabRegistration.Controls.Add(this.tabUser);
            this.tabRegistration.Controls.Add(this.tabProject);
            this.tabRegistration.Controls.Add(this.tabSite);
            this.tabRegistration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRegistration.Location = new System.Drawing.Point(0, 0);
            this.tabRegistration.Margin = new System.Windows.Forms.Padding(4);
            this.tabRegistration.Name = "tabRegistration";
            this.tabRegistration.SelectedIndex = 0;
            this.tabRegistration.Size = new System.Drawing.Size(1176, 877);
            this.tabRegistration.TabIndex = 13;
            this.tabRegistration.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabRegistration_Selecting);
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.lblUserStatus);
            this.tabUser.Controls.Add(this.btnDeleteUser);
            this.tabUser.Controls.Add(this.grpBoxSearchByName);
            this.tabUser.Controls.Add(this.grpBoxUserInfo);
            this.tabUser.Controls.Add(this.btnCreateUser);
            this.tabUser.Controls.Add(this.txtBoxPass);
            this.tabUser.Controls.Add(this.lblPassword);
            this.tabUser.Controls.Add(this.txtBoxLogin);
            this.tabUser.Controls.Add(this.lblLogin);
            this.tabUser.Controls.Add(this.lblRole);
            this.tabUser.Controls.Add(this.cboRole);
            this.tabUser.Location = new System.Drawing.Point(8, 51);
            this.tabUser.Margin = new System.Windows.Forms.Padding(4);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(4);
            this.tabUser.Size = new System.Drawing.Size(1160, 818);
            this.tabUser.TabIndex = 0;
            this.tabUser.Text = "User";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // lblUserStatus
            // 
            this.lblUserStatus.AutoSize = true;
            this.lblUserStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserStatus.Location = new System.Drawing.Point(56, 502);
            this.lblUserStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserStatus.Name = "lblUserStatus";
            this.lblUserStatus.Size = new System.Drawing.Size(0, 37);
            this.lblUserStatus.TabIndex = 33;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.Location = new System.Drawing.Point(936, 742);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(180, 62);
            this.btnDeleteUser.TabIndex = 13;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // grpBoxSearchByName
            // 
            this.grpBoxSearchByName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxSearchByName.Controls.Add(this.txtBoxSearchByID);
            this.grpBoxSearchByName.Controls.Add(this.dgdViewEmployee);
            this.grpBoxSearchByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxSearchByName.Location = new System.Drawing.Point(548, 27);
            this.grpBoxSearchByName.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxSearchByName.Name = "grpBoxSearchByName";
            this.grpBoxSearchByName.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxSearchByName.Size = new System.Drawing.Size(578, 692);
            this.grpBoxSearchByName.TabIndex = 32;
            this.grpBoxSearchByName.TabStop = false;
            this.grpBoxSearchByName.Text = "Search by Surname";
            // 
            // txtBoxSearchByID
            // 
            this.txtBoxSearchByID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSearchByID.Location = new System.Drawing.Point(22, 83);
            this.txtBoxSearchByID.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxSearchByID.Name = "txtBoxSearchByID";
            this.txtBoxSearchByID.Size = new System.Drawing.Size(348, 44);
            this.txtBoxSearchByID.TabIndex = 9;
            this.txtBoxSearchByID.TextChanged += new System.EventHandler(this.txtBoxSearchByID_TextChanged);
            // 
            // dgdViewEmployee
            // 
            this.dgdViewEmployee.AllowUserToAddRows = false;
            this.dgdViewEmployee.AllowUserToDeleteRows = false;
            this.dgdViewEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgdViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgdViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdViewEmployee.Location = new System.Drawing.Point(22, 148);
            this.dgdViewEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.dgdViewEmployee.Name = "dgdViewEmployee";
            this.dgdViewEmployee.ReadOnly = true;
            this.dgdViewEmployee.RowHeadersVisible = false;
            this.dgdViewEmployee.RowTemplate.Height = 24;
            this.dgdViewEmployee.Size = new System.Drawing.Size(546, 516);
            this.dgdViewEmployee.TabIndex = 30;
            this.dgdViewEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployee_CellClick);
            // 
            // grpBoxUserInfo
            // 
            this.grpBoxUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpBoxUserInfo.Controls.Add(this.btnUpdateUser);
            this.grpBoxUserInfo.Controls.Add(this.lblEmployeeIDValue);
            this.grpBoxUserInfo.Controls.Add(this.lblEmployeeID);
            this.grpBoxUserInfo.Controls.Add(this.lblName);
            this.grpBoxUserInfo.Controls.Add(this.txtBoxAddress);
            this.grpBoxUserInfo.Controls.Add(this.lblAddress);
            this.grpBoxUserInfo.Controls.Add(this.txtBoxPhone);
            this.grpBoxUserInfo.Controls.Add(this.lblSurname);
            this.grpBoxUserInfo.Controls.Add(this.lblPhone);
            this.grpBoxUserInfo.Controls.Add(this.txtBoxSurname);
            this.grpBoxUserInfo.Controls.Add(this.txtBoxEmail);
            this.grpBoxUserInfo.Controls.Add(this.txtBoxName);
            this.grpBoxUserInfo.Controls.Add(this.lblEmail);
            this.grpBoxUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxUserInfo.Location = new System.Drawing.Point(14, 242);
            this.grpBoxUserInfo.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxUserInfo.Name = "grpBoxUserInfo";
            this.grpBoxUserInfo.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxUserInfo.Size = new System.Drawing.Size(524, 562);
            this.grpBoxUserInfo.TabIndex = 28;
            this.grpBoxUserInfo.TabStop = false;
            this.grpBoxUserInfo.Text = "User Information";
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdateUser.Enabled = false;
            this.btnUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.Location = new System.Drawing.Point(168, 473);
            this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(180, 62);
            this.btnUpdateUser.TabIndex = 12;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // lblEmployeeIDValue
            // 
            this.lblEmployeeIDValue.AutoSize = true;
            this.lblEmployeeIDValue.Location = new System.Drawing.Point(258, 58);
            this.lblEmployeeIDValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmployeeIDValue.Name = "lblEmployeeIDValue";
            this.lblEmployeeIDValue.Size = new System.Drawing.Size(0, 37);
            this.lblEmployeeIDValue.TabIndex = 29;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(8, 58);
            this.lblEmployeeID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(197, 37);
            this.lblEmployeeID.TabIndex = 28;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 115);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 37);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Name";
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.AcceptsReturn = true;
            this.txtBoxAddress.Location = new System.Drawing.Point(168, 392);
            this.txtBoxAddress.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(344, 44);
            this.txtBoxAddress.TabIndex = 8;
            this.txtBoxAddress.TextChanged += new System.EventHandler(this.FieldChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(8, 400);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(135, 37);
            this.lblAddress.TabIndex = 26;
            this.lblAddress.Text = "Address";
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Location = new System.Drawing.Point(168, 319);
            this.txtBoxPhone.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(344, 44);
            this.txtBoxPhone.TabIndex = 7;
            this.txtBoxPhone.TextChanged += new System.EventHandler(this.FieldChanged);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(8, 181);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(147, 37);
            this.lblSurname.TabIndex = 18;
            this.lblSurname.Text = "Surname";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(10, 327);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(109, 37);
            this.lblPhone.TabIndex = 24;
            this.lblPhone.Text = "Phone";
            // 
            // txtBoxSurname
            // 
            this.txtBoxSurname.Location = new System.Drawing.Point(168, 173);
            this.txtBoxSurname.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxSurname.Name = "txtBoxSurname";
            this.txtBoxSurname.Size = new System.Drawing.Size(344, 44);
            this.txtBoxSurname.TabIndex = 5;
            this.txtBoxSurname.TextChanged += new System.EventHandler(this.FieldChanged);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(168, 246);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(344, 44);
            this.txtBoxEmail.TabIndex = 6;
            this.txtBoxEmail.TextChanged += new System.EventHandler(this.FieldChanged);
            this.txtBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxEmail_Validating);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(168, 108);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(344, 44);
            this.txtBoxName.TabIndex = 4;
            this.txtBoxName.TextChanged += new System.EventHandler(this.FieldChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(10, 254);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(97, 37);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "Email";
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUser.Location = new System.Drawing.Point(738, 742);
            this.btnCreateUser.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(180, 62);
            this.btnCreateUser.TabIndex = 11;
            this.btnCreateUser.Text = "Create";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPass.Location = new System.Drawing.Point(182, 175);
            this.txtBoxPass.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.Size = new System.Drawing.Size(344, 44);
            this.txtBoxPass.TabIndex = 3;
            this.txtBoxPass.TextChanged += new System.EventHandler(this.FieldChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(22, 183);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(158, 37);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Password";
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLogin.Location = new System.Drawing.Point(182, 104);
            this.txtBoxLogin.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(344, 44);
            this.txtBoxLogin.TabIndex = 2;
            this.txtBoxLogin.TextChanged += new System.EventHandler(this.FieldChanged);
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(24, 112);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(96, 37);
            this.lblLogin.TabIndex = 12;
            this.lblLogin.Text = "Login";
            // 
            // lblRole
            // 
            this.lblRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(24, 46);
            this.lblRole.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(81, 37);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "Role";
            // 
            // cboRole
            // 
            this.cboRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Items.AddRange(new object[] {
            "Admin",
            "Project Manager",
            "Site Manager",
            "Worker"});
            this.cboRole.Location = new System.Drawing.Point(182, 33);
            this.cboRole.Margin = new System.Windows.Forms.Padding(6);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(344, 45);
            this.cboRole.TabIndex = 1;
            this.cboRole.SelectedIndexChanged += new System.EventHandler(this.FieldChanged);
            // 
            // tabProject
            // 
            this.tabProject.Controls.Add(this.lblPStatus);
            this.tabProject.Controls.Add(this.btnDeleteProject);
            this.tabProject.Controls.Add(this.btnCreateProject);
            this.tabProject.Controls.Add(this.groupBoxProject);
            this.tabProject.Controls.Add(this.groupBoxSearch);
            this.tabProject.Location = new System.Drawing.Point(8, 51);
            this.tabProject.Margin = new System.Windows.Forms.Padding(4);
            this.tabProject.Name = "tabProject";
            this.tabProject.Padding = new System.Windows.Forms.Padding(4);
            this.tabProject.Size = new System.Drawing.Size(1160, 818);
            this.tabProject.TabIndex = 1;
            this.tabProject.Text = "Project";
            this.tabProject.UseVisualStyleBackColor = true;
            // 
            // lblPStatus
            // 
            this.lblPStatus.AutoSize = true;
            this.lblPStatus.Location = new System.Drawing.Point(16, 515);
            this.lblPStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPStatus.Name = "lblPStatus";
            this.lblPStatus.Size = new System.Drawing.Size(0, 37);
            this.lblPStatus.TabIndex = 39;
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteProject.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDeleteProject.Location = new System.Drawing.Point(932, 729);
            this.btnDeleteProject.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Size = new System.Drawing.Size(180, 62);
            this.btnDeleteProject.TabIndex = 8;
            this.btnDeleteProject.Text = "Delete";
            this.btnDeleteProject.UseVisualStyleBackColor = true;
            this.btnDeleteProject.Click += new System.EventHandler(this.btnDeleteProject_Click);
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateProject.Location = new System.Drawing.Point(734, 729);
            this.btnCreateProject.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Size = new System.Drawing.Size(180, 62);
            this.btnCreateProject.TabIndex = 6;
            this.btnCreateProject.Text = "Create";
            this.btnCreateProject.UseVisualStyleBackColor = true;
            this.btnCreateProject.Click += new System.EventHandler(this.btnCreateProject_Click);
            // 
            // groupBoxProject
            // 
            this.groupBoxProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxProject.Controls.Add(this.lblMngrID);
            this.groupBoxProject.Controls.Add(this.btnUpdateProject);
            this.groupBoxProject.Controls.Add(this.lblPMngrIDValue);
            this.groupBoxProject.Controls.Add(this.lblProjectID);
            this.groupBoxProject.Controls.Add(this.lblProjectIDValue);
            this.groupBoxProject.Controls.Add(this.lblPMName);
            this.groupBoxProject.Controls.Add(this.lblProjectAAddress);
            this.groupBoxProject.Controls.Add(this.cboPM);
            this.groupBoxProject.Controls.Add(this.txtBoxPAddress);
            this.groupBoxProject.Controls.Add(this.txtBoxProjectName);
            this.groupBoxProject.Controls.Add(this.lblProjectName);
            this.groupBoxProject.Location = new System.Drawing.Point(12, 27);
            this.groupBoxProject.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxProject.Name = "groupBoxProject";
            this.groupBoxProject.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxProject.Size = new System.Drawing.Size(524, 679);
            this.groupBoxProject.TabIndex = 32;
            this.groupBoxProject.TabStop = false;
            this.groupBoxProject.Text = "Project Information";
            // 
            // lblMngrID
            // 
            this.lblMngrID.AutoSize = true;
            this.lblMngrID.Location = new System.Drawing.Point(14, 263);
            this.lblMngrID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMngrID.Name = "lblMngrID";
            this.lblMngrID.Size = new System.Drawing.Size(291, 37);
            this.lblMngrID.TabIndex = 33;
            this.lblMngrID.Text = "Project Manager ID";
            // 
            // btnUpdateProject
            // 
            this.btnUpdateProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateProject.Enabled = false;
            this.btnUpdateProject.Location = new System.Drawing.Point(162, 566);
            this.btnUpdateProject.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdateProject.Name = "btnUpdateProject";
            this.btnUpdateProject.Size = new System.Drawing.Size(180, 62);
            this.btnUpdateProject.TabIndex = 7;
            this.btnUpdateProject.Text = "Update";
            this.btnUpdateProject.UseVisualStyleBackColor = true;
            this.btnUpdateProject.Click += new System.EventHandler(this.btnUpdateProject_Click);
            // 
            // lblPMngrIDValue
            // 
            this.lblPMngrIDValue.AutoSize = true;
            this.lblPMngrIDValue.Location = new System.Drawing.Point(342, 263);
            this.lblPMngrIDValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPMngrIDValue.Name = "lblPMngrIDValue";
            this.lblPMngrIDValue.Size = new System.Drawing.Size(0, 37);
            this.lblPMngrIDValue.TabIndex = 32;
            // 
            // lblProjectID
            // 
            this.lblProjectID.AutoSize = true;
            this.lblProjectID.Location = new System.Drawing.Point(14, 83);
            this.lblProjectID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProjectID.Name = "lblProjectID";
            this.lblProjectID.Size = new System.Drawing.Size(156, 37);
            this.lblProjectID.TabIndex = 31;
            this.lblProjectID.Text = "Project ID";
            // 
            // lblProjectIDValue
            // 
            this.lblProjectIDValue.AutoSize = true;
            this.lblProjectIDValue.Location = new System.Drawing.Point(342, 83);
            this.lblProjectIDValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProjectIDValue.Name = "lblProjectIDValue";
            this.lblProjectIDValue.Size = new System.Drawing.Size(0, 37);
            this.lblProjectIDValue.TabIndex = 30;
            // 
            // lblPMName
            // 
            this.lblPMName.AutoSize = true;
            this.lblPMName.Location = new System.Drawing.Point(14, 327);
            this.lblPMName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPMName.Name = "lblPMName";
            this.lblPMName.Size = new System.Drawing.Size(251, 37);
            this.lblPMName.TabIndex = 29;
            this.lblPMName.Text = "Project Manager";
            // 
            // lblProjectAAddress
            // 
            this.lblProjectAAddress.AutoSize = true;
            this.lblProjectAAddress.Location = new System.Drawing.Point(14, 448);
            this.lblProjectAAddress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProjectAAddress.Name = "lblProjectAAddress";
            this.lblProjectAAddress.Size = new System.Drawing.Size(243, 37);
            this.lblProjectAAddress.TabIndex = 24;
            this.lblProjectAAddress.Text = "Project Address";
            // 
            // cboPM
            // 
            this.cboPM.FormattingEnabled = true;
            this.cboPM.Location = new System.Drawing.Point(20, 371);
            this.cboPM.Margin = new System.Windows.Forms.Padding(6);
            this.cboPM.Name = "cboPM";
            this.cboPM.Size = new System.Drawing.Size(492, 45);
            this.cboPM.TabIndex = 2;
            this.cboPM.SelectedIndexChanged += new System.EventHandler(this.FieldChanged);
            this.cboPM.DropDownClosed += new System.EventHandler(this.cboPM_DropDownClosed);
            // 
            // txtBoxPAddress
            // 
            this.txtBoxPAddress.Location = new System.Drawing.Point(20, 494);
            this.txtBoxPAddress.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxPAddress.Name = "txtBoxPAddress";
            this.txtBoxPAddress.Size = new System.Drawing.Size(492, 44);
            this.txtBoxPAddress.TabIndex = 3;
            this.txtBoxPAddress.TextChanged += new System.EventHandler(this.FieldChanged);
            // 
            // txtBoxProjectName
            // 
            this.txtBoxProjectName.Location = new System.Drawing.Point(20, 194);
            this.txtBoxProjectName.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxProjectName.Name = "txtBoxProjectName";
            this.txtBoxProjectName.Size = new System.Drawing.Size(492, 44);
            this.txtBoxProjectName.TabIndex = 1;
            this.txtBoxProjectName.TextChanged += new System.EventHandler(this.FieldChanged);
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(14, 148);
            this.lblProjectName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(211, 37);
            this.lblProjectName.TabIndex = 26;
            this.lblProjectName.Text = "Project Name";
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearch.Controls.Add(this.txtBoxSearchP);
            this.groupBoxSearch.Controls.Add(this.dgdViewProject);
            this.groupBoxSearch.Location = new System.Drawing.Point(548, 27);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSearch.Size = new System.Drawing.Size(574, 679);
            this.groupBoxSearch.TabIndex = 31;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search by Project Name";
            // 
            // txtBoxSearchP
            // 
            this.txtBoxSearchP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSearchP.Location = new System.Drawing.Point(22, 83);
            this.txtBoxSearchP.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxSearchP.Name = "txtBoxSearchP";
            this.txtBoxSearchP.Size = new System.Drawing.Size(344, 44);
            this.txtBoxSearchP.TabIndex = 4;
            this.txtBoxSearchP.TextChanged += new System.EventHandler(this.txtBoxSearchP_TextChanged);
            // 
            // dgdViewProject
            // 
            this.dgdViewProject.AllowUserToAddRows = false;
            this.dgdViewProject.AllowUserToDeleteRows = false;
            this.dgdViewProject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgdViewProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdViewProject.Location = new System.Drawing.Point(24, 148);
            this.dgdViewProject.Margin = new System.Windows.Forms.Padding(4);
            this.dgdViewProject.Name = "dgdViewProject";
            this.dgdViewProject.ReadOnly = true;
            this.dgdViewProject.RowTemplate.Height = 24;
            this.dgdViewProject.Size = new System.Drawing.Size(542, 503);
            this.dgdViewProject.TabIndex = 30;
            this.dgdViewProject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProject_CellClick);
            // 
            // tabSite
            // 
            this.tabSite.Controls.Add(this.lblSiteStatus);
            this.tabSite.Controls.Add(this.btnDeleteSite);
            this.tabSite.Controls.Add(this.grpBoxSiteName);
            this.tabSite.Controls.Add(this.grpBoxSiteInfo);
            this.tabSite.Controls.Add(this.btnCreateSite);
            this.tabSite.Location = new System.Drawing.Point(8, 51);
            this.tabSite.Margin = new System.Windows.Forms.Padding(4);
            this.tabSite.Name = "tabSite";
            this.tabSite.Padding = new System.Windows.Forms.Padding(4);
            this.tabSite.Size = new System.Drawing.Size(1160, 818);
            this.tabSite.TabIndex = 2;
            this.tabSite.Text = "Site";
            this.tabSite.UseVisualStyleBackColor = true;
            // 
            // lblSiteStatus
            // 
            this.lblSiteStatus.AutoSize = true;
            this.lblSiteStatus.Location = new System.Drawing.Point(16, 515);
            this.lblSiteStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSiteStatus.Name = "lblSiteStatus";
            this.lblSiteStatus.Size = new System.Drawing.Size(0, 37);
            this.lblSiteStatus.TabIndex = 39;
            // 
            // btnDeleteSite
            // 
            this.btnDeleteSite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteSite.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDeleteSite.Location = new System.Drawing.Point(932, 729);
            this.btnDeleteSite.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteSite.Name = "btnDeleteSite";
            this.btnDeleteSite.Size = new System.Drawing.Size(180, 62);
            this.btnDeleteSite.TabIndex = 9;
            this.btnDeleteSite.Text = "Delete";
            this.btnDeleteSite.UseVisualStyleBackColor = true;
            this.btnDeleteSite.Click += new System.EventHandler(this.btnDeleteSite_Click);
            // 
            // grpBoxSiteName
            // 
            this.grpBoxSiteName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxSiteName.Controls.Add(this.txtBoxSiteSearch);
            this.grpBoxSiteName.Controls.Add(this.dgdViewSite);
            this.grpBoxSiteName.Location = new System.Drawing.Point(546, 27);
            this.grpBoxSiteName.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxSiteName.Name = "grpBoxSiteName";
            this.grpBoxSiteName.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxSiteName.Size = new System.Drawing.Size(574, 679);
            this.grpBoxSiteName.TabIndex = 33;
            this.grpBoxSiteName.TabStop = false;
            this.grpBoxSiteName.Text = "Search by Site Name";
            // 
            // txtBoxSiteSearch
            // 
            this.txtBoxSiteSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSiteSearch.Location = new System.Drawing.Point(22, 83);
            this.txtBoxSiteSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxSiteSearch.Name = "txtBoxSiteSearch";
            this.txtBoxSiteSearch.Size = new System.Drawing.Size(344, 44);
            this.txtBoxSiteSearch.TabIndex = 5;
            this.txtBoxSiteSearch.TextChanged += new System.EventHandler(this.txtBoxSiteSearch_TextChanged);
            // 
            // dgdViewSite
            // 
            this.dgdViewSite.AllowUserToAddRows = false;
            this.dgdViewSite.AllowUserToDeleteRows = false;
            this.dgdViewSite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgdViewSite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdViewSite.Location = new System.Drawing.Point(24, 148);
            this.dgdViewSite.Margin = new System.Windows.Forms.Padding(4);
            this.dgdViewSite.Name = "dgdViewSite";
            this.dgdViewSite.ReadOnly = true;
            this.dgdViewSite.RowTemplate.Height = 24;
            this.dgdViewSite.Size = new System.Drawing.Size(542, 523);
            this.dgdViewSite.TabIndex = 30;
            this.dgdViewSite.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdViewSite_CellClick);
            // 
            // grpBoxSiteInfo
            // 
            this.grpBoxSiteInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpBoxSiteInfo.Controls.Add(this.lblProjectIDOnSiteValue);
            this.grpBoxSiteInfo.Controls.Add(this.btnUpdateSite);
            this.grpBoxSiteInfo.Controls.Add(this.lblProjectIDOnSite);
            this.grpBoxSiteInfo.Controls.Add(this.lblSiteManagerIDValue);
            this.grpBoxSiteInfo.Controls.Add(this.lblSiteManagerID);
            this.grpBoxSiteInfo.Controls.Add(this.lblSiteIDValue);
            this.grpBoxSiteInfo.Controls.Add(this.lblSiteID);
            this.grpBoxSiteInfo.Controls.Add(this.lblProject);
            this.grpBoxSiteInfo.Controls.Add(this.cboProject);
            this.grpBoxSiteInfo.Controls.Add(this.lblSiteManager);
            this.grpBoxSiteInfo.Controls.Add(this.lblSiteAddress);
            this.grpBoxSiteInfo.Controls.Add(this.cboSiteManager);
            this.grpBoxSiteInfo.Controls.Add(this.txtBoxSiteAddress);
            this.grpBoxSiteInfo.Controls.Add(this.txtBoxSiteName);
            this.grpBoxSiteInfo.Controls.Add(this.lblSiteName);
            this.grpBoxSiteInfo.Location = new System.Drawing.Point(12, 27);
            this.grpBoxSiteInfo.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxSiteInfo.Name = "grpBoxSiteInfo";
            this.grpBoxSiteInfo.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxSiteInfo.Size = new System.Drawing.Size(524, 764);
            this.grpBoxSiteInfo.TabIndex = 34;
            this.grpBoxSiteInfo.TabStop = false;
            this.grpBoxSiteInfo.Text = "Site Information";
            // 
            // lblProjectIDOnSiteValue
            // 
            this.lblProjectIDOnSiteValue.AutoSize = true;
            this.lblProjectIDOnSiteValue.Location = new System.Drawing.Point(354, 392);
            this.lblProjectIDOnSiteValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProjectIDOnSiteValue.Name = "lblProjectIDOnSiteValue";
            this.lblProjectIDOnSiteValue.Size = new System.Drawing.Size(0, 37);
            this.lblProjectIDOnSiteValue.TabIndex = 37;
            // 
            // btnUpdateSite
            // 
            this.btnUpdateSite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateSite.Enabled = false;
            this.btnUpdateSite.Location = new System.Drawing.Point(174, 662);
            this.btnUpdateSite.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdateSite.Name = "btnUpdateSite";
            this.btnUpdateSite.Size = new System.Drawing.Size(180, 62);
            this.btnUpdateSite.TabIndex = 8;
            this.btnUpdateSite.Text = "Update";
            this.btnUpdateSite.UseVisualStyleBackColor = true;
            this.btnUpdateSite.Click += new System.EventHandler(this.btnUpdateSite_Click);
            // 
            // lblProjectIDOnSite
            // 
            this.lblProjectIDOnSite.AutoSize = true;
            this.lblProjectIDOnSite.Location = new System.Drawing.Point(16, 392);
            this.lblProjectIDOnSite.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProjectIDOnSite.Name = "lblProjectIDOnSite";
            this.lblProjectIDOnSite.Size = new System.Drawing.Size(156, 37);
            this.lblProjectIDOnSite.TabIndex = 36;
            this.lblProjectIDOnSite.Text = "Project ID";
            // 
            // lblSiteManagerIDValue
            // 
            this.lblSiteManagerIDValue.AutoSize = true;
            this.lblSiteManagerIDValue.Location = new System.Drawing.Point(354, 221);
            this.lblSiteManagerIDValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSiteManagerIDValue.Name = "lblSiteManagerIDValue";
            this.lblSiteManagerIDValue.Size = new System.Drawing.Size(0, 37);
            this.lblSiteManagerIDValue.TabIndex = 35;
            // 
            // lblSiteManagerID
            // 
            this.lblSiteManagerID.AutoSize = true;
            this.lblSiteManagerID.Location = new System.Drawing.Point(16, 221);
            this.lblSiteManagerID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSiteManagerID.Name = "lblSiteManagerID";
            this.lblSiteManagerID.Size = new System.Drawing.Size(246, 37);
            this.lblSiteManagerID.TabIndex = 34;
            this.lblSiteManagerID.Text = "Site Manager ID";
            // 
            // lblSiteIDValue
            // 
            this.lblSiteIDValue.AutoSize = true;
            this.lblSiteIDValue.Location = new System.Drawing.Point(354, 65);
            this.lblSiteIDValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSiteIDValue.Name = "lblSiteIDValue";
            this.lblSiteIDValue.Size = new System.Drawing.Size(0, 37);
            this.lblSiteIDValue.TabIndex = 33;
            // 
            // lblSiteID
            // 
            this.lblSiteID.AutoSize = true;
            this.lblSiteID.Location = new System.Drawing.Point(16, 65);
            this.lblSiteID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSiteID.Name = "lblSiteID";
            this.lblSiteID.Size = new System.Drawing.Size(111, 37);
            this.lblSiteID.TabIndex = 32;
            this.lblSiteID.Text = "Site ID";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(16, 446);
            this.lblProject.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(116, 37);
            this.lblProject.TabIndex = 31;
            this.lblProject.Text = "Project";
            // 
            // cboProject
            // 
            this.cboProject.FormattingEnabled = true;
            this.cboProject.Location = new System.Drawing.Point(24, 492);
            this.cboProject.Margin = new System.Windows.Forms.Padding(6);
            this.cboProject.Name = "cboProject";
            this.cboProject.Size = new System.Drawing.Size(492, 45);
            this.cboProject.TabIndex = 3;
            this.cboProject.SelectedIndexChanged += new System.EventHandler(this.FieldChanged);
            this.cboProject.DropDownClosed += new System.EventHandler(this.cboProject_DropDownClosed);
            // 
            // lblSiteManager
            // 
            this.lblSiteManager.AutoSize = true;
            this.lblSiteManager.Location = new System.Drawing.Point(16, 279);
            this.lblSiteManager.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSiteManager.Name = "lblSiteManager";
            this.lblSiteManager.Size = new System.Drawing.Size(206, 37);
            this.lblSiteManager.TabIndex = 29;
            this.lblSiteManager.Text = "Site Manager";
            // 
            // lblSiteAddress
            // 
            this.lblSiteAddress.AutoSize = true;
            this.lblSiteAddress.Location = new System.Drawing.Point(16, 562);
            this.lblSiteAddress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSiteAddress.Name = "lblSiteAddress";
            this.lblSiteAddress.Size = new System.Drawing.Size(198, 37);
            this.lblSiteAddress.TabIndex = 24;
            this.lblSiteAddress.Text = "Site Address";
            // 
            // cboSiteManager
            // 
            this.cboSiteManager.FormattingEnabled = true;
            this.cboSiteManager.Location = new System.Drawing.Point(20, 323);
            this.cboSiteManager.Margin = new System.Windows.Forms.Padding(6);
            this.cboSiteManager.Name = "cboSiteManager";
            this.cboSiteManager.Size = new System.Drawing.Size(492, 45);
            this.cboSiteManager.TabIndex = 2;
            this.cboSiteManager.SelectedIndexChanged += new System.EventHandler(this.FieldChanged);
            this.cboSiteManager.DropDownClosed += new System.EventHandler(this.cboSiteManager_DropDownClosed);
            // 
            // txtBoxSiteAddress
            // 
            this.txtBoxSiteAddress.Location = new System.Drawing.Point(20, 606);
            this.txtBoxSiteAddress.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxSiteAddress.Name = "txtBoxSiteAddress";
            this.txtBoxSiteAddress.Size = new System.Drawing.Size(492, 44);
            this.txtBoxSiteAddress.TabIndex = 4;
            this.txtBoxSiteAddress.TextChanged += new System.EventHandler(this.FieldChanged);
            // 
            // txtBoxSiteName
            // 
            this.txtBoxSiteName.Location = new System.Drawing.Point(20, 158);
            this.txtBoxSiteName.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxSiteName.Name = "txtBoxSiteName";
            this.txtBoxSiteName.Size = new System.Drawing.Size(492, 44);
            this.txtBoxSiteName.TabIndex = 1;
            this.txtBoxSiteName.TextChanged += new System.EventHandler(this.FieldChanged);
            // 
            // lblSiteName
            // 
            this.lblSiteName.AutoSize = true;
            this.lblSiteName.Location = new System.Drawing.Point(14, 112);
            this.lblSiteName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSiteName.Name = "lblSiteName";
            this.lblSiteName.Size = new System.Drawing.Size(166, 37);
            this.lblSiteName.TabIndex = 26;
            this.lblSiteName.Text = "Site Name";
            // 
            // btnCreateSite
            // 
            this.btnCreateSite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateSite.Location = new System.Drawing.Point(740, 729);
            this.btnCreateSite.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreateSite.Name = "btnCreateSite";
            this.btnCreateSite.Size = new System.Drawing.Size(180, 62);
            this.btnCreateSite.TabIndex = 7;
            this.btnCreateSite.Text = "Create";
            this.btnCreateSite.UseVisualStyleBackColor = true;
            this.btnCreateSite.Click += new System.EventHandler(this.btnCreateSite_Click);
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 877);
            this.Controls.Add(this.tabRegistration);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1182, 886);
            this.Name = "frmRegistration";
            this.Text = "Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRegistration_Load);
            this.tabRegistration.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
            this.grpBoxSearchByName.ResumeLayout(false);
            this.grpBoxSearchByName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdViewEmployee)).EndInit();
            this.grpBoxUserInfo.ResumeLayout(false);
            this.grpBoxUserInfo.PerformLayout();
            this.tabProject.ResumeLayout(false);
            this.tabProject.PerformLayout();
            this.groupBoxProject.ResumeLayout(false);
            this.groupBoxProject.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdViewProject)).EndInit();
            this.tabSite.ResumeLayout(false);
            this.tabSite.PerformLayout();
            this.grpBoxSiteName.ResumeLayout(false);
            this.grpBoxSiteName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdViewSite)).EndInit();
            this.grpBoxSiteInfo.ResumeLayout(false);
            this.grpBoxSiteInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabProject;
        private System.Windows.Forms.TabPage tabSite;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBoxSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPMName;
        private System.Windows.Forms.ComboBox cboPM;
        private System.Windows.Forms.TextBox txtBoxProjectName;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.TextBox txtBoxPAddress;
        private System.Windows.Forms.Label lblProjectAAddress;
        private System.Windows.Forms.DataGridView dgdViewProject;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.TextBox txtBoxSearchP;
        private System.Windows.Forms.GroupBox groupBoxProject;
        private System.Windows.Forms.GroupBox grpBoxUserInfo;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.GroupBox grpBoxSearchByName;
        private System.Windows.Forms.TextBox txtBoxSearchByID;
        private System.Windows.Forms.GroupBox grpBoxSiteName;
        private System.Windows.Forms.TextBox txtBoxSiteSearch;
        private System.Windows.Forms.DataGridView dgdViewSite;
        private System.Windows.Forms.GroupBox grpBoxSiteInfo;
        private System.Windows.Forms.Label lblSiteManager;
        private System.Windows.Forms.Label lblSiteAddress;
        private System.Windows.Forms.ComboBox cboSiteManager;
        private System.Windows.Forms.TextBox txtBoxSiteAddress;
        private System.Windows.Forms.TextBox txtBoxSiteName;
        private System.Windows.Forms.Label lblSiteName;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.ComboBox cboProject;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label lblUserStatus;
        private System.Windows.Forms.Button btnUpdateProject;
        private System.Windows.Forms.Button btnDeleteProject;
        private System.Windows.Forms.Button btnCreateProject;
        private System.Windows.Forms.Button btnUpdateSite;
        private System.Windows.Forms.Button btnDeleteSite;
        private System.Windows.Forms.Button btnCreateSite;
        private System.Windows.Forms.Label lblPStatus;
        private System.Windows.Forms.Label lblSiteStatus;
        private System.Windows.Forms.DataGridView dgdViewEmployee;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Label lblProjectID;
        private System.Windows.Forms.Label lblProjectIDValue;
        private System.Windows.Forms.Label lblMngrID;
        private System.Windows.Forms.Label lblPMngrIDValue;
        private System.Windows.Forms.Label lblSiteID;
        private System.Windows.Forms.Label lblSiteIDValue;
        private System.Windows.Forms.Label lblSiteManagerIDValue;
        private System.Windows.Forms.Label lblSiteManagerID;
        private System.Windows.Forms.Label lblProjectIDOnSiteValue;
        private System.Windows.Forms.Label lblProjectIDOnSite;
        private System.Windows.Forms.Label lblEmployeeIDValue;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TabControl tabRegistration;
        private System.Windows.Forms.TabPage tabUser;
    }
}