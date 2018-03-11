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
    //Created by Liana 
    public partial class frmTimesheet : Form
    {
        //connect to DB
        SqlConnection conn;
        SqlCommand cmd;
        string connStr = ConfigurationManager.ConnectionStrings["LOL_attendance.Properties.Settings.LOLDBConnectionString"].ConnectionString;
        
        SqlDataReader rdr;
        public frmTimesheet()
        {
            InitializeComponent();
            //bind Site Manager dropdown with values from db
            conn = new SqlConnection(connStr);
            cmd = new SqlCommand("SELECT e.name FROM employee e, role r WHERE e.role_id=r.id and r.name='Site Manager'", conn);
            
            conn.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    comboBoxSitemngr.Items.Add(rdr.GetString(0));
                }
            }
            conn.Close();

            //bind Site dropdown with values from db
            cmd = new SqlCommand("SELECT name FROM site", conn);

            conn.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    comboBoxSitename.Items.Add(rdr.GetString(0));
                }
            }
            conn.Close();


        }

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
            // TODO: This line of code loads data into the 'lOLDBDataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.lOLDBDataSet.employee);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
