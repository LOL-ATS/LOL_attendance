﻿using System;
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
        //Liana and Lana: 
        //Add connection to DB
        
        SqlConnection conn;
        SqlCommand cmd;
        string connstr = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

        SqlDataReader rdr;

        public frmRegistration()
        {
            InitializeComponent();
            //Lana:
            //Fill in Project Manager dropdown with values from db
            conn = new SqlConnection(connstr);
            //Need to add ASC list order
            cmd = new SqlCommand("SELECT e.surname FROM employee e, role r WHERE e.role_id=r.id and r.name='Project Manager'", conn);

            conn.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    cboPM.Items.Add(rdr.GetString(0));
                }
            }
            conn.Close();
           

            //Lana:
            //Fill in Site Manager dropdown with values from db
            conn = new SqlConnection(connstr);
            //Need to add ASC list order
            cmd = new SqlCommand("SELECT e.surname FROM employee e, role r WHERE e.role_id=r.id and r.name='Site Manager'", conn);

            conn.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    cboSiteManager.Items.Add(rdr.GetString(0));
                }
            }
            conn.Close();
            

            //Lana:
            //Fill in Project dropdown with values from db
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT name FROM project ORDER BY name ASC", conn);

            conn.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    cboProject.Items.Add(rdr.GetString(0));
                }
            }
            conn.Close();
            
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

        //Add fields clearness after clicking on the button Create 
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

        private void cboPM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Add fields clearness after clicking on the button Create 
        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            //Lana:
            //Define selected ProjectManager ID
            int currentProjectManagerID = 0;
            
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT id FROM employee WHERE surname='" + cboPM.SelectedItem + "'", conn);

            conn.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                rdr.Read();
                currentProjectManagerID = rdr.GetInt32(0);
            }
            conn.Close();

            cmd = new SqlCommand("INSERT INTO project (name, mngr_id, address) VALUES (@name,@mngr_id,@address)", conn);

            cmd.Parameters.AddWithValue("@name", txtBoxPMName.Text);
            cmd.Parameters.AddWithValue("@address", txtBoxPAddress.Text);
            cmd.Parameters.AddWithValue("@mngr_id", currentProjectManagerID);

            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                lblPStatus.ForeColor = System.Drawing.Color.Green;
                lblPStatus.Text = "Successfully added!";
            }
            conn.Close();
        }
        //Add fields clearness after clicking on the button Create 
        private void btnCreateSite_Click(object sender, EventArgs e)
        {
            //Lana:
            //Define selected SiteManager ID
            int currentSiteManagerID = 0;

            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT id FROM employee WHERE surname='" + cboSiteManager.SelectedItem + "'", conn);

            conn.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                rdr.Read();
                currentSiteManagerID = rdr.GetInt32(0);
            }
            conn.Close();

            //Define selected Project ID
            int currentProjectID = 0;

            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT id FROM project WHERE name='" + cboProject.SelectedItem + "'", conn);

            conn.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                rdr.Read();
                currentProjectID = rdr.GetInt32(0);
            }
            conn.Close();


            cmd = new SqlCommand("INSERT INTO site (name, mngr_id, address, proj_id) VALUES (@name,@mngr_id,@address,@proj_id)", conn);

            cmd.Parameters.AddWithValue("@name", txtBoxSiteName.Text);
            cmd.Parameters.AddWithValue("@address", txtBoxSiteAddress.Text);
            cmd.Parameters.AddWithValue("@mngr_id", currentSiteManagerID);
            cmd.Parameters.AddWithValue("@proj_id", currentProjectID);

            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                lblSiteStatus.ForeColor = System.Drawing.Color.Green;
                lblSiteStatus.Text = "Successfully added!";
            }
            conn.Close();
        }

        private void btnShowAllSites_Click(object sender, EventArgs e)
        {
            ShowAll();
        }
        private void ShowAll()
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT * FROM site", conn);
            DataTable dt = new DataTable();

            conn.Open();
            rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                dt.Load(rdr);
                dgdVieSite.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No Data to show");
            }
            conn.Close();
        }

        private void btnShowAllProjects_Click(object sender, EventArgs e)
            {
                ShowAllProjects();
            }
            private void ShowAllProjects()
            {
                conn = new SqlConnection(connstr);
                cmd = new SqlCommand("SELECT * FROM project", conn);
                DataTable dt = new DataTable();

                conn.Open();
                rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    dt.Load(rdr);
                    dgdViewProject.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Data to show");
                }
                conn.Close();
            }

        private void btnShowAllID_Click(object sender, EventArgs e)
            {
                ShowAllEmployees();
            }
            private void ShowAllEmployees()
            {
                conn = new SqlConnection(connstr);
                cmd = new SqlCommand("SELECT * FROM employee", conn);
                DataTable dt = new DataTable();

                conn.Open();
                rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    dt.Load(rdr);
                    dgdViewEmployee.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Data to show");
                }
                conn.Close();
            }
    }
}

