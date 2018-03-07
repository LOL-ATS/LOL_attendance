using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Add namespaces for interaction to database
//added by Liana
using System.Data.SqlClient;
using System.Configuration;

namespace LOL_attendance
{
    public partial class frmTimesheet : Form
    {
        public frmTimesheet()
        {
            InitializeComponent();
        }

        //connect to DB
        //added by Liana
        /*
         string connStr = ConfigurationManager.ConnectionStrings["LOL_attendance.Properties.Settings.myConnection"].ConnectionString;
        */ 
        // changed by omid
        string connStr = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmTimesheet_Load(object sender, EventArgs e)
        {

        }

        private void btnApprove_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
