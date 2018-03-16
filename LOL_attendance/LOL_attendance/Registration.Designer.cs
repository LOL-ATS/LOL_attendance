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
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.lblUserStatus = new System.Windows.Forms.Label();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.grpBoxSearchByName = new System.Windows.Forms.GroupBox();
            this.btnShowAllID = new System.Windows.Forms.Button();
            this.txtBoxSearchByID = new System.Windows.Forms.TextBox();
            this.dgdViewEmployee = new System.Windows.Forms.DataGridView();
            this.grpBoxUserInfo = new System.Windows.Forms.GroupBox();
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
            this.btnUpdateProject = new System.Windows.Forms.Button();
            this.btnDeleteProject = new System.Windows.Forms.Button();
            this.btnCreateProject = new System.Windows.Forms.Button();
            this.groupBoxProject = new System.Windows.Forms.GroupBox();
            this.lblPMName = new System.Windows.Forms.Label();
            this.lblProjectAAddress = new System.Windows.Forms.Label();
            this.cboPM = new System.Windows.Forms.ComboBox();
            this.txtBoxPAddress = new System.Windows.Forms.TextBox();
            this.txtBoxPMName = new System.Windows.Forms.TextBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.btnShowAllProjects = new System.Windows.Forms.Button();
            this.txtBoxSearchP = new System.Windows.Forms.TextBox();
            this.dgdViewProject = new System.Windows.Forms.DataGridView();
            this.tabSite = new System.Windows.Forms.TabPage();
            this.lblSiteStatus = new System.Windows.Forms.Label();
            this.btnUpdateSite = new System.Windows.Forms.Button();
            this.btnDeleteSite = new System.Windows.Forms.Button();
            this.grpBoxSiteName = new System.Windows.Forms.GroupBox();
            this.btnShowAllSites = new System.Windows.Forms.Button();
            this.txtBoxSiteSearch = new System.Windows.Forms.TextBox();
            this.dgdVieSite = new System.Windows.Forms.DataGridView();
            this.grpBoxSiteInfo = new System.Windows.Forms.GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgdVieSite)).BeginInit();
            this.grpBoxSiteInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabRegistration
            // 
            this.tabRegistration.AccessibleDescription = "";
            this.tabRegistration.Controls.Add(this.tabUser);
            this.tabRegistration.Controls.Add(this.tabProject);
            this.tabRegistration.Controls.Add(this.tabSite);
            this.tabRegistration.Location = new System.Drawing.Point(12, 16);
            this.tabRegistration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabRegistration.Name = "tabRegistration";
            this.tabRegistration.SelectedIndex = 0;
            this.tabRegistration.Size = new System.Drawing.Size(495, 362);
            this.tabRegistration.TabIndex = 13;
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.btnUpdateUser);
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
            this.tabUser.Location = new System.Drawing.Point(4, 22);
            this.tabUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabUser.Size = new System.Drawing.Size(487, 336);
            this.tabUser.TabIndex = 0;
            this.tabUser.Text = "User";
            this.tabUser.UseVisualStyleBackColor = true;
            this.tabUser.Click += new System.EventHandler(this.tabUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(267, 270);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateUser.TabIndex = 34;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // lblUserStatus
            // 
            this.lblUserStatus.AutoSize = true;
            this.lblUserStatus.Location = new System.Drawing.Point(6, 262);
            this.lblUserStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserStatus.Name = "lblUserStatus";
            this.lblUserStatus.Size = new System.Drawing.Size(0, 13);
            this.lblUserStatus.TabIndex = 33;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDeleteUser.Location = new System.Drawing.Point(348, 270);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUser.TabIndex = 14;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // grpBoxSearchByName
            // 
            this.grpBoxSearchByName.Controls.Add(this.btnShowAllID);
            this.grpBoxSearchByName.Controls.Add(this.txtBoxSearchByID);
            this.grpBoxSearchByName.Controls.Add(this.dgdViewEmployee);
            this.grpBoxSearchByName.Location = new System.Drawing.Point(226, 9);
            this.grpBoxSearchByName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxSearchByName.Name = "grpBoxSearchByName";
            this.grpBoxSearchByName.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxSearchByName.Size = new System.Drawing.Size(195, 243);
            this.grpBoxSearchByName.TabIndex = 32;
            this.grpBoxSearchByName.TabStop = false;
            this.grpBoxSearchByName.Text = "Search by Name";
            this.grpBoxSearchByName.Enter += new System.EventHandler(this.grpBoxSearchByID_Enter);
            // 
            // btnShowAllID
            // 
            this.btnShowAllID.Location = new System.Drawing.Point(136, 24);
            this.btnShowAllID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowAllID.Name = "btnShowAllID";
            this.btnShowAllID.Size = new System.Drawing.Size(56, 19);
            this.btnShowAllID.TabIndex = 33;
            this.btnShowAllID.Text = "Show All";
            this.btnShowAllID.UseVisualStyleBackColor = true;
            this.btnShowAllID.Click += new System.EventHandler(this.btnShowAllID_Click);
            // 
            // txtBoxSearchByID
            // 
            this.txtBoxSearchByID.Location = new System.Drawing.Point(5, 26);
            this.txtBoxSearchByID.Name = "txtBoxSearchByID";
            this.txtBoxSearchByID.Size = new System.Drawing.Size(126, 20);
            this.txtBoxSearchByID.TabIndex = 32;
            // 
            // dgdViewEmployee
            // 
            this.dgdViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdViewEmployee.Location = new System.Drawing.Point(4, 52);
            this.dgdViewEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgdViewEmployee.Name = "dgdViewEmployee";
            this.dgdViewEmployee.RowTemplate.Height = 24;
            this.dgdViewEmployee.Size = new System.Drawing.Size(188, 181);
            this.dgdViewEmployee.TabIndex = 30;
            this.dgdViewEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployee_CellContentClick);
            // 
            // grpBoxUserInfo
            // 
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
            this.grpBoxUserInfo.Location = new System.Drawing.Point(0, 80);
            this.grpBoxUserInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxUserInfo.Name = "grpBoxUserInfo";
            this.grpBoxUserInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxUserInfo.Size = new System.Drawing.Size(222, 171);
            this.grpBoxUserInfo.TabIndex = 28;
            this.grpBoxUserInfo.TabStop = false;
            this.grpBoxUserInfo.Text = "User Information";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(5, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Name";
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.AcceptsReturn = true;
            this.txtBoxAddress.Location = new System.Drawing.Point(81, 125);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(120, 20);
            this.txtBoxAddress.TabIndex = 27;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(5, 128);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 26;
            this.lblAddress.Text = "Address";
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Location = new System.Drawing.Point(81, 101);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(120, 20);
            this.txtBoxPhone.TabIndex = 25;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(6, 52);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 18;
            this.lblSurname.Text = "Surname";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(4, 103);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 24;
            this.lblPhone.Text = "Phone";
            // 
            // txtBoxSurname
            // 
            this.txtBoxSurname.Location = new System.Drawing.Point(82, 48);
            this.txtBoxSurname.Name = "txtBoxSurname";
            this.txtBoxSurname.Size = new System.Drawing.Size(120, 20);
            this.txtBoxSurname.TabIndex = 19;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(81, 76);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(120, 20);
            this.txtBoxEmail.TabIndex = 23;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(82, 24);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(120, 20);
            this.txtBoxName.TabIndex = 21;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(4, 79);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "Email";
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(186, 270);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(75, 23);
            this.btnCreateUser.TabIndex = 10;
            this.btnCreateUser.Text = "Create";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Location = new System.Drawing.Point(81, 57);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.Size = new System.Drawing.Size(120, 20);
            this.txtBoxPass.TabIndex = 15;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(4, 59);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Password";
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Location = new System.Drawing.Point(82, 35);
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(120, 20);
            this.txtBoxLogin.TabIndex = 13;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(5, 37);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 12;
            this.lblLogin.Text = "Login";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(5, 13);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(29, 13);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "Role";
            this.lblRole.Click += new System.EventHandler(this.lblSitemngr_Click);
            // 
            // cboRole
            // 
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Items.AddRange(new object[] {
            "Admin",
            "Project Manager",
            "Site Manager",
            "Worker"});
            this.cboRole.Location = new System.Drawing.Point(81, 9);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(121, 21);
            this.cboRole.TabIndex = 4;
            this.cboRole.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabProject
            // 
            this.tabProject.Controls.Add(this.lblPStatus);
            this.tabProject.Controls.Add(this.btnUpdateProject);
            this.tabProject.Controls.Add(this.btnDeleteProject);
            this.tabProject.Controls.Add(this.btnCreateProject);
            this.tabProject.Controls.Add(this.groupBoxProject);
            this.tabProject.Controls.Add(this.groupBoxSearch);
            this.tabProject.Location = new System.Drawing.Point(4, 22);
            this.tabProject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabProject.Name = "tabProject";
            this.tabProject.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabProject.Size = new System.Drawing.Size(487, 336);
            this.tabProject.TabIndex = 1;
            this.tabProject.Text = "Project";
            this.tabProject.UseVisualStyleBackColor = true;
            // 
            // lblPStatus
            // 
            this.lblPStatus.AutoSize = true;
            this.lblPStatus.Location = new System.Drawing.Point(8, 268);
            this.lblPStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPStatus.Name = "lblPStatus";
            this.lblPStatus.Size = new System.Drawing.Size(0, 13);
            this.lblPStatus.TabIndex = 39;
            // 
            // btnUpdateProject
            // 
            this.btnUpdateProject.Location = new System.Drawing.Point(274, 275);
            this.btnUpdateProject.Name = "btnUpdateProject";
            this.btnUpdateProject.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateProject.TabIndex = 38;
            this.btnUpdateProject.Text = "Update";
            this.btnUpdateProject.UseVisualStyleBackColor = true;
            this.btnUpdateProject.Click += new System.EventHandler(this.btnUpdateProject_Click);
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDeleteProject.Location = new System.Drawing.Point(355, 275);
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProject.TabIndex = 37;
            this.btnDeleteProject.Text = "Delete";
            this.btnDeleteProject.UseVisualStyleBackColor = true;
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.Location = new System.Drawing.Point(193, 275);
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Size = new System.Drawing.Size(75, 23);
            this.btnCreateProject.TabIndex = 35;
            this.btnCreateProject.Text = "Create";
            this.btnCreateProject.UseVisualStyleBackColor = true;
            this.btnCreateProject.Click += new System.EventHandler(this.btnCreateProject_Click);
            // 
            // groupBoxProject
            // 
            this.groupBoxProject.Controls.Add(this.lblPMName);
            this.groupBoxProject.Controls.Add(this.lblProjectAAddress);
            this.groupBoxProject.Controls.Add(this.cboPM);
            this.groupBoxProject.Controls.Add(this.txtBoxPAddress);
            this.groupBoxProject.Controls.Add(this.txtBoxPMName);
            this.groupBoxProject.Controls.Add(this.lblProjectName);
            this.groupBoxProject.Location = new System.Drawing.Point(8, 18);
            this.groupBoxProject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxProject.Name = "groupBoxProject";
            this.groupBoxProject.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxProject.Size = new System.Drawing.Size(218, 236);
            this.groupBoxProject.TabIndex = 32;
            this.groupBoxProject.TabStop = false;
            this.groupBoxProject.Text = "Project Information";
            this.groupBoxProject.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblPMName
            // 
            this.lblPMName.AutoSize = true;
            this.lblPMName.Location = new System.Drawing.Point(1, 53);
            this.lblPMName.Name = "lblPMName";
            this.lblPMName.Size = new System.Drawing.Size(86, 13);
            this.lblPMName.TabIndex = 29;
            this.lblPMName.Text = "Rroject Manager";
            // 
            // lblProjectAAddress
            // 
            this.lblProjectAAddress.AutoSize = true;
            this.lblProjectAAddress.Location = new System.Drawing.Point(1, 79);
            this.lblProjectAAddress.Name = "lblProjectAAddress";
            this.lblProjectAAddress.Size = new System.Drawing.Size(81, 13);
            this.lblProjectAAddress.TabIndex = 24;
            this.lblProjectAAddress.Text = "Project Address";
            // 
            // cboPM
            // 
            this.cboPM.FormattingEnabled = true;
            this.cboPM.Location = new System.Drawing.Point(94, 54);
            this.cboPM.Name = "cboPM";
            this.cboPM.Size = new System.Drawing.Size(121, 21);
            this.cboPM.TabIndex = 28;
            this.cboPM.SelectedIndexChanged += new System.EventHandler(this.cboPM_SelectedIndexChanged);
            // 
            // txtBoxPAddress
            // 
            this.txtBoxPAddress.Location = new System.Drawing.Point(94, 77);
            this.txtBoxPAddress.Name = "txtBoxPAddress";
            this.txtBoxPAddress.Size = new System.Drawing.Size(120, 20);
            this.txtBoxPAddress.TabIndex = 25;
            // 
            // txtBoxPMName
            // 
            this.txtBoxPMName.Location = new System.Drawing.Point(94, 27);
            this.txtBoxPMName.Name = "txtBoxPMName";
            this.txtBoxPMName.Size = new System.Drawing.Size(120, 20);
            this.txtBoxPMName.TabIndex = 27;
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(0, 27);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(71, 13);
            this.lblProjectName.TabIndex = 26;
            this.lblProjectName.Text = "Project Name";
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.btnShowAllProjects);
            this.groupBoxSearch.Controls.Add(this.txtBoxSearchP);
            this.groupBoxSearch.Controls.Add(this.dgdViewProject);
            this.groupBoxSearch.Location = new System.Drawing.Point(231, 18);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxSearch.Size = new System.Drawing.Size(197, 236);
            this.groupBoxSearch.TabIndex = 31;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search by Project Name";
            // 
            // btnShowAllProjects
            // 
            this.btnShowAllProjects.Location = new System.Drawing.Point(136, 24);
            this.btnShowAllProjects.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowAllProjects.Name = "btnShowAllProjects";
            this.btnShowAllProjects.Size = new System.Drawing.Size(56, 19);
            this.btnShowAllProjects.TabIndex = 33;
            this.btnShowAllProjects.Text = "Show All";
            this.btnShowAllProjects.UseVisualStyleBackColor = true;
            this.btnShowAllProjects.Click += new System.EventHandler(this.btnShowAllProjects_Click);
            // 
            // txtBoxSearchP
            // 
            this.txtBoxSearchP.Location = new System.Drawing.Point(5, 26);
            this.txtBoxSearchP.Name = "txtBoxSearchP";
            this.txtBoxSearchP.Size = new System.Drawing.Size(126, 20);
            this.txtBoxSearchP.TabIndex = 32;
            // 
            // dgdViewProject
            // 
            this.dgdViewProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdViewProject.Location = new System.Drawing.Point(5, 53);
            this.dgdViewProject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgdViewProject.Name = "dgdViewProject";
            this.dgdViewProject.RowTemplate.Height = 24;
            this.dgdViewProject.Size = new System.Drawing.Size(188, 179);
            this.dgdViewProject.TabIndex = 30;
            this.dgdViewProject.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProject_CellContentClick);
            // 
            // tabSite
            // 
            this.tabSite.Controls.Add(this.lblSiteStatus);
            this.tabSite.Controls.Add(this.btnUpdateSite);
            this.tabSite.Controls.Add(this.btnDeleteSite);
            this.tabSite.Controls.Add(this.grpBoxSiteName);
            this.tabSite.Controls.Add(this.grpBoxSiteInfo);
            this.tabSite.Controls.Add(this.btnCreateSite);
            this.tabSite.Location = new System.Drawing.Point(4, 22);
            this.tabSite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabSite.Name = "tabSite";
            this.tabSite.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabSite.Size = new System.Drawing.Size(487, 336);
            this.tabSite.TabIndex = 2;
            this.tabSite.Text = "Site";
            this.tabSite.UseVisualStyleBackColor = true;
            // 
            // lblSiteStatus
            // 
            this.lblSiteStatus.AutoSize = true;
            this.lblSiteStatus.Location = new System.Drawing.Point(8, 268);
            this.lblSiteStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSiteStatus.Name = "lblSiteStatus";
            this.lblSiteStatus.Size = new System.Drawing.Size(0, 13);
            this.lblSiteStatus.TabIndex = 39;
            // 
            // btnUpdateSite
            // 
            this.btnUpdateSite.Location = new System.Drawing.Point(272, 280);
            this.btnUpdateSite.Name = "btnUpdateSite";
            this.btnUpdateSite.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateSite.TabIndex = 38;
            this.btnUpdateSite.Text = "Update";
            this.btnUpdateSite.UseVisualStyleBackColor = true;
            this.btnUpdateSite.Click += new System.EventHandler(this.btnUpdateSite_Click);
            // 
            // btnDeleteSite
            // 
            this.btnDeleteSite.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDeleteSite.Location = new System.Drawing.Point(352, 280);
            this.btnDeleteSite.Name = "btnDeleteSite";
            this.btnDeleteSite.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSite.TabIndex = 37;
            this.btnDeleteSite.Text = "Delete";
            this.btnDeleteSite.UseVisualStyleBackColor = true;
            // 
            // grpBoxSiteName
            // 
            this.grpBoxSiteName.Controls.Add(this.btnShowAllSites);
            this.grpBoxSiteName.Controls.Add(this.txtBoxSiteSearch);
            this.grpBoxSiteName.Controls.Add(this.dgdVieSite);
            this.grpBoxSiteName.Location = new System.Drawing.Point(229, 23);
            this.grpBoxSiteName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxSiteName.Name = "grpBoxSiteName";
            this.grpBoxSiteName.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxSiteName.Size = new System.Drawing.Size(197, 232);
            this.grpBoxSiteName.TabIndex = 33;
            this.grpBoxSiteName.TabStop = false;
            this.grpBoxSiteName.Text = "Search by Site Name";
            // 
            // btnShowAllSites
            // 
            this.btnShowAllSites.Location = new System.Drawing.Point(136, 24);
            this.btnShowAllSites.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowAllSites.Name = "btnShowAllSites";
            this.btnShowAllSites.Size = new System.Drawing.Size(56, 19);
            this.btnShowAllSites.TabIndex = 33;
            this.btnShowAllSites.Text = "Show All";
            this.btnShowAllSites.UseVisualStyleBackColor = true;
            this.btnShowAllSites.Click += new System.EventHandler(this.btnShowAllSites_Click);
            // 
            // txtBoxSiteSearch
            // 
            this.txtBoxSiteSearch.Location = new System.Drawing.Point(5, 26);
            this.txtBoxSiteSearch.Name = "txtBoxSiteSearch";
            this.txtBoxSiteSearch.Size = new System.Drawing.Size(126, 20);
            this.txtBoxSiteSearch.TabIndex = 32;
            // 
            // dgdVieSite
            // 
            this.dgdVieSite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdVieSite.Location = new System.Drawing.Point(4, 52);
            this.dgdVieSite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgdVieSite.Name = "dgdVieSite";
            this.dgdVieSite.RowTemplate.Height = 24;
            this.dgdVieSite.Size = new System.Drawing.Size(188, 175);
            this.dgdVieSite.TabIndex = 30;
            this.dgdVieSite.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdVieSite_CellContentClick);
            // 
            // grpBoxSiteInfo
            // 
            this.grpBoxSiteInfo.Controls.Add(this.lblProject);
            this.grpBoxSiteInfo.Controls.Add(this.cboProject);
            this.grpBoxSiteInfo.Controls.Add(this.lblSiteManager);
            this.grpBoxSiteInfo.Controls.Add(this.lblSiteAddress);
            this.grpBoxSiteInfo.Controls.Add(this.cboSiteManager);
            this.grpBoxSiteInfo.Controls.Add(this.txtBoxSiteAddress);
            this.grpBoxSiteInfo.Controls.Add(this.txtBoxSiteName);
            this.grpBoxSiteInfo.Controls.Add(this.lblSiteName);
            this.grpBoxSiteInfo.Location = new System.Drawing.Point(6, 23);
            this.grpBoxSiteInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxSiteInfo.Name = "grpBoxSiteInfo";
            this.grpBoxSiteInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxSiteInfo.Size = new System.Drawing.Size(218, 232);
            this.grpBoxSiteInfo.TabIndex = 34;
            this.grpBoxSiteInfo.TabStop = false;
            this.grpBoxSiteInfo.Text = "Site Information";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(0, 27);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(40, 13);
            this.lblProject.TabIndex = 31;
            this.lblProject.Text = "Project";
            // 
            // cboProject
            // 
            this.cboProject.FormattingEnabled = true;
            this.cboProject.Location = new System.Drawing.Point(92, 24);
            this.cboProject.Name = "cboProject";
            this.cboProject.Size = new System.Drawing.Size(121, 21);
            this.cboProject.TabIndex = 30;
            // 
            // lblSiteManager
            // 
            this.lblSiteManager.AutoSize = true;
            this.lblSiteManager.Location = new System.Drawing.Point(-1, 54);
            this.lblSiteManager.Name = "lblSiteManager";
            this.lblSiteManager.Size = new System.Drawing.Size(70, 13);
            this.lblSiteManager.TabIndex = 29;
            this.lblSiteManager.Text = "Site Manager";
            // 
            // lblSiteAddress
            // 
            this.lblSiteAddress.AutoSize = true;
            this.lblSiteAddress.Location = new System.Drawing.Point(-1, 104);
            this.lblSiteAddress.Name = "lblSiteAddress";
            this.lblSiteAddress.Size = new System.Drawing.Size(66, 13);
            this.lblSiteAddress.TabIndex = 24;
            this.lblSiteAddress.Text = "Site Address";
            // 
            // cboSiteManager
            // 
            this.cboSiteManager.FormattingEnabled = true;
            this.cboSiteManager.Location = new System.Drawing.Point(92, 52);
            this.cboSiteManager.Name = "cboSiteManager";
            this.cboSiteManager.Size = new System.Drawing.Size(121, 21);
            this.cboSiteManager.TabIndex = 28;
            // 
            // txtBoxSiteAddress
            // 
            this.txtBoxSiteAddress.Location = new System.Drawing.Point(92, 102);
            this.txtBoxSiteAddress.Name = "txtBoxSiteAddress";
            this.txtBoxSiteAddress.Size = new System.Drawing.Size(120, 20);
            this.txtBoxSiteAddress.TabIndex = 25;
            // 
            // txtBoxSiteName
            // 
            this.txtBoxSiteName.Location = new System.Drawing.Point(92, 78);
            this.txtBoxSiteName.Name = "txtBoxSiteName";
            this.txtBoxSiteName.Size = new System.Drawing.Size(120, 20);
            this.txtBoxSiteName.TabIndex = 27;
            this.txtBoxSiteName.TextChanged += new System.EventHandler(this.txtBoxSiteName_TextChanged);
            // 
            // lblSiteName
            // 
            this.lblSiteName.AutoSize = true;
            this.lblSiteName.Location = new System.Drawing.Point(-1, 78);
            this.lblSiteName.Name = "lblSiteName";
            this.lblSiteName.Size = new System.Drawing.Size(56, 13);
            this.lblSiteName.TabIndex = 26;
            this.lblSiteName.Text = "Site Name";
            this.lblSiteName.Click += new System.EventHandler(this.lblSiteName_Click);
            // 
            // btnCreateSite
            // 
            this.btnCreateSite.Location = new System.Drawing.Point(190, 280);
            this.btnCreateSite.Name = "btnCreateSite";
            this.btnCreateSite.Size = new System.Drawing.Size(75, 23);
            this.btnCreateSite.TabIndex = 35;
            this.btnCreateSite.Text = "Create";
            this.btnCreateSite.UseVisualStyleBackColor = true;
            this.btnCreateSite.Click += new System.EventHandler(this.btnCreateSite_Click);
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 425);
            this.Controls.Add(this.tabRegistration);
            this.Name = "frmRegistration";
            this.Text = "Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Registration_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgdVieSite)).EndInit();
            this.grpBoxSiteInfo.ResumeLayout(false);
            this.grpBoxSiteInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabRegistration;
        private System.Windows.Forms.TabPage tabUser;
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
        private System.Windows.Forms.TextBox txtBoxPMName;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.TextBox txtBoxPAddress;
        private System.Windows.Forms.Label lblProjectAAddress;
        private System.Windows.Forms.DataGridView dgdViewProject;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.TextBox txtBoxSearchP;
        private System.Windows.Forms.GroupBox groupBoxProject;
        private System.Windows.Forms.Button btnShowAllProjects;
        private System.Windows.Forms.GroupBox grpBoxUserInfo;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.GroupBox grpBoxSearchByName;
        private System.Windows.Forms.Button btnShowAllID;
        private System.Windows.Forms.TextBox txtBoxSearchByID;
        private System.Windows.Forms.GroupBox grpBoxSiteName;
        private System.Windows.Forms.Button btnShowAllSites;
        private System.Windows.Forms.TextBox txtBoxSiteSearch;
        private System.Windows.Forms.DataGridView dgdVieSite;
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
    }
}