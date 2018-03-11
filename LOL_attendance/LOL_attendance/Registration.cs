using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace LOL_attendance
{
    public partial class frmRegistration : Form
    {
        //Liand and Lana: 
        //Add connection to DB
        
        SqlConnection conn;
        SqlCommand cmd;
        string connstr = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

        SqlDataReader rdr;

        public frmRegistration()
        {
            InitializeComponent();
           
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            Main frm = (Main)this.MdiParent;

            MessageBox.Show(frm.User.userRole.ToString());
        }

        private void lblSitemngr_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewProject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblSiteName_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxSiteName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            //int role_id=0;
            int role_id = 0;
            DataTable dt = new DataTable();

            //mySqlCommand = "SELECT id FROM role WHERE name = " + cboRole.Text;
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT id FROM role WHERE name='" + cboRole.Text+ "'", conn);
            conn.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                rdr.Read();                
                role_id = rdr.GetInt32(0);
                //MessageBox.Show("id: " + role_id);
            }

            
            
            conn.Close();

            cmd = new SqlCommand("INSERT INTO employee (login, password, name, surname, email, phone, address, role_id) VALUES (@login,@password,@name,@surname,@email,@phone,@address,@role_id)", conn);
            cmd.Parameters.AddWithValue("@login", txtBoxLogin.Text);
            cmd.Parameters.AddWithValue("@password", txtBoxPass.Text);
            cmd.Parameters.AddWithValue("@name", txtBoxName.Text);
            cmd.Parameters.AddWithValue("@surname", txtBoxSurname.Text);
            cmd.Parameters.AddWithValue("@email", txtBoxEmail.Text);
            cmd.Parameters.AddWithValue("@phone", txtBoxPhone.Text);
            cmd.Parameters.AddWithValue("@address", txtBoxAddress.Text);
            cmd.Parameters.AddWithValue("@role_id", role_id);
            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                lblUserStatus.ForeColor = System.Drawing.Color.Green;
                lblUserStatus.Text = "Successfuly added";
            }
            conn.Close();
        }

        private void tabUser_Click(object sender, EventArgs e)
        {

        }

        private void grpBoxSearchByID_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
