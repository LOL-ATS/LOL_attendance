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
            login formLogin = new login();
            formLogin.MdiParent = this;
            formLogin.TopMost = true;
            formLogin.Show();

        }
    }
}
