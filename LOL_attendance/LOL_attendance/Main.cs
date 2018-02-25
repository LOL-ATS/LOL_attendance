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
        public Main()
        {
            InitializeComponent();
            stlbl_date.Text = DateTime.Now.Date.ToString();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            pnl_login.Visible = false;
        }

        private void stlbl_date_Click(object sender, EventArgs e)
        {

        }
    }
}
