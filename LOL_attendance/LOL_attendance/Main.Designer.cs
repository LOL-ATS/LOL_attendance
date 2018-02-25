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
            this.btn_reg = new System.Windows.Forms.Button();
            this.btn_TS = new System.Windows.Forms.Button();
            this.btn_aprov = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnl_login = new System.Windows.Forms.Panel();
            this.txtb_username = new System.Windows.Forms.TextBox();
            this.txtb_psw = new System.Windows.Forms.TextBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_psw = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.stlbl_date = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.pnl_login.SuspendLayout();
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
            // btn_reg
            // 
            this.btn_reg.Location = new System.Drawing.Point(46, 61);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(285, 65);
            this.btn_reg.TabIndex = 0;
            this.btn_reg.Text = "Registration";
            this.btn_reg.UseVisualStyleBackColor = true;
            // 
            // btn_TS
            // 
            this.btn_TS.Location = new System.Drawing.Point(46, 147);
            this.btn_TS.Name = "btn_TS";
            this.btn_TS.Size = new System.Drawing.Size(285, 65);
            this.btn_TS.TabIndex = 1;
            this.btn_TS.Text = "Timesheets";
            this.btn_TS.UseVisualStyleBackColor = true;
            // 
            // btn_aprov
            // 
            this.btn_aprov.Location = new System.Drawing.Point(46, 235);
            this.btn_aprov.Name = "btn_aprov";
            this.btn_aprov.Size = new System.Drawing.Size(285, 65);
            this.btn_aprov.TabIndex = 2;
            this.btn_aprov.Text = "Approve";
            this.btn_aprov.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(46, 320);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(285, 65);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.stlbl_date});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(383, 38);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(62, 33);
            this.toolStripStatusLabel1.Text = "User";
            // 
            // pnl_login
            // 
            this.pnl_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_login.Controls.Add(this.btn_login);
            this.pnl_login.Controls.Add(this.lbl_psw);
            this.pnl_login.Controls.Add(this.lbl_user);
            this.pnl_login.Controls.Add(this.txtb_psw);
            this.pnl_login.Controls.Add(this.txtb_username);
            this.pnl_login.Location = new System.Drawing.Point(38, 63);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(299, 237);
            this.pnl_login.TabIndex = 5;
            // 
            // txtb_username
            // 
            this.txtb_username.Location = new System.Drawing.Point(134, 40);
            this.txtb_username.Name = "txtb_username";
            this.txtb_username.Size = new System.Drawing.Size(145, 31);
            this.txtb_username.TabIndex = 0;
            // 
            // txtb_psw
            // 
            this.txtb_psw.Location = new System.Drawing.Point(134, 87);
            this.txtb_psw.Name = "txtb_psw";
            this.txtb_psw.PasswordChar = '*';
            this.txtb_psw.Size = new System.Drawing.Size(145, 31);
            this.txtb_psw.TabIndex = 1;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(13, 43);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(119, 25);
            this.lbl_user.TabIndex = 2;
            this.lbl_user.Text = "User Name";
            // 
            // lbl_psw
            // 
            this.lbl_psw.AutoSize = true;
            this.lbl_psw.Location = new System.Drawing.Point(13, 90);
            this.lbl_psw.Name = "lbl_psw";
            this.lbl_psw.Size = new System.Drawing.Size(106, 25);
            this.lbl_psw.TabIndex = 3;
            this.lbl_psw.Text = "Password";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(53, 155);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(183, 49);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // stlbl_date
            // 
            this.stlbl_date.Name = "stlbl_date";
            this.stlbl_date.Size = new System.Drawing.Size(0, 33);
            this.stlbl_date.Click += new System.EventHandler(this.stlbl_date_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(383, 419);
            this.Controls.Add(this.pnl_login);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_aprov);
            this.Controls.Add(this.btn_TS);
            this.Controls.Add(this.btn_reg);
            this.Name = "Main";
            this.Text = "LOL";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnl_login.ResumeLayout(false);
            this.pnl_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.Button btn_TS;
        private System.Windows.Forms.Button btn_aprov;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel pnl_login;
        private System.Windows.Forms.TextBox txtb_username;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_psw;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.TextBox txtb_psw;
        private System.Windows.Forms.ToolStripStatusLabel stlbl_date;
    }
}

