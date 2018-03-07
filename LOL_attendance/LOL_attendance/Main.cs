using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOL_attendance
{
    public partial class Main : Form
    {
        public string username="";
        public Main()
        {
            InitializeComponent();
           
             statusStrip1.Enabled = false;
            login formLogin = new login();
            formLogin.MdiParent = this;
            formLogin.TopMost = true;
            formLogin.Show();
           
        }

     

     
        private void btnReg_Click(object sender, EventArgs e)
        {
            frmRegistration formLogin = new frmRegistration();
            formLogin.MdiParent = this;
            formLogin.TopMost = true;
            formLogin.Show();
        }

        private void Main_Activated(object sender, EventArgs e)
        {
   
        }

        private void StLblUsername(object sender, EventArgs e)
        {

        }

        private void tSSBUser_ButtonClick(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMainBtn.Visible = false;
            statusStrip1.Enabled = false;
            this.Refresh();
            login formLogin = new login();
            formLogin.MdiParent = this;
            formLogin.TopMost = true;
            formLogin.Show();

        }
        protected override void OnResize(EventArgs e)
        {
            CenterForms();
            base.OnResize(e);
        }
        private void CenterForms()
        {
            foreach (var form in MdiChildren) //This will center all of the Child Forms
            {
                form.Left = (ClientRectangle.Width - form.Width) / 2;
                form.Top = (ClientRectangle.Height - form.Height) / 2;
            }

        }

        private void Main_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btnTimesheet_Click(object sender, EventArgs e)
        {
            frmTimesheet formLogin = new frmTimesheet();
            formLogin.MdiParent = this;
            formLogin.TopMost = true;
            formLogin.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            this.Close();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
