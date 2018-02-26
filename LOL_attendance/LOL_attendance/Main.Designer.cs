namespace LOL_attendance
{
    partial class Main
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSSLUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSBUser = new System.Windows.Forms.ToolStripSplitButton();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMainBtn = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTimesheet = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.pnlMainBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(124, 163);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(150, 29);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSLUsername,
            this.tSSBUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(774, 38);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tSSLUsername
            // 
            this.tSSLUsername.Name = "tSSLUsername";
            this.tSSLUsername.Size = new System.Drawing.Size(122, 33);
            this.tSSLUsername.Text = "Username";
            // 
            // tSSBUser
            // 
            this.tSSBUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSSBUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.tSSBUser.Image = global::LOL_attendance.Properties.Resources.avatar;
            this.tSSBUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSSBUser.Name = "tSSBUser";
            this.tSSBUser.Size = new System.Drawing.Size(59, 36);
            this.tSSBUser.Text = "toolStripSplitButton1";
            this.tSSBUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tSSBUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tSSBUser.ButtonClick += new System.EventHandler(this.tSSBUser_ButtonClick);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.logoutToolStripMenuItem.Text = "Log out";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // pnlMainBtn
            // 
            this.pnlMainBtn.BackColor = System.Drawing.Color.Transparent;
            this.pnlMainBtn.Controls.Add(this.btnExit);
            this.pnlMainBtn.Controls.Add(this.btnTimesheet);
            this.pnlMainBtn.Controls.Add(this.btnReg);
            this.pnlMainBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlMainBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMainBtn.Location = new System.Drawing.Point(0, 38);
            this.pnlMainBtn.Name = "pnlMainBtn";
            this.pnlMainBtn.Size = new System.Drawing.Size(270, 491);
            this.pnlMainBtn.TabIndex = 7;
            this.pnlMainBtn.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(38, 205);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(194, 65);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTimesheet
            // 
            this.btnTimesheet.Location = new System.Drawing.Point(38, 115);
            this.btnTimesheet.Name = "btnTimesheet";
            this.btnTimesheet.Size = new System.Drawing.Size(194, 65);
            this.btnTimesheet.TabIndex = 5;
            this.btnTimesheet.Text = "Timesheets";
            this.btnTimesheet.UseVisualStyleBackColor = true;
            this.btnTimesheet.Click += new System.EventHandler(this.btnTimesheet_Click);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(38, 29);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(194, 65);
            this.btnReg.TabIndex = 4;
            this.btnReg.Text = "Registration";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::LOL_attendance.Properties.Resources.Lunch_Atop_a_skyscraper_1932_1120x840;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(774, 529);
            this.Controls.Add(this.pnlMainBtn);
            this.Controls.Add(this.statusStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Main";
            this.Text = "LOL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlMainBtn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel pnlMainBtn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTimesheet;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.ToolStripSplitButton tSSBUser;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tSSLUsername;
    }
}

