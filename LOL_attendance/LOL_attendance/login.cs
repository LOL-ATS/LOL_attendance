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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            this.Hide();
            /*
            if (txtUsername.Text == "admin" && txtPassword.Text == "123")
            { */
        
                Form frm = (Form)this.MdiParent;
                frm.Controls["pnlMainBtn"].Visible = true;
                StatusStrip SS = (StatusStrip)frm.Controls["StatusStrip1"];             
                SS.Items["tSSLUsername"].Text = "admin";
                SS.Enabled = true;
            /*

            }*/
        }

        private void login_Load(object sender, EventArgs e)
        {
            Left = (MdiParent.ClientRectangle.Width - Width) / 2;
            Top = (MdiParent.ClientRectangle.Height - Height) / 2;
        }
    }
}
