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
            cmd = new SqlCommand("SELECT surname FROM employee e, role r WHERE e.role_id=r.id and r.name='Project Manager' and e.isActive='True' ORDER BY surname ASC", conn);

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
            cmd = new SqlCommand("SELECT e.surname FROM employee e, role r WHERE e.role_id=r.id and r.name='Site Manager' and e.isActive ='True' ORDER BY surname ASC", conn);

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
            cmd = new SqlCommand("SELECT name FROM project where isActive='True' ORDER BY name ASC", conn);

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
     
        public int ID;
        private void dataGridViewEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgdViewEmployee.Rows[e.RowIndex];

            
            //DataTable dt = new DataTable();
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT name FROM role WHERE id =" + Convert.ToInt32(row.Cells["role_id"].Value.ToString()), conn);

            conn.Open();
            rdr = cmd.ExecuteReader();
            string role_name="";
            if (rdr.HasRows)
            {
                rdr.Read();
                role_name = rdr.GetString(0);
             }

            conn.Close();

            ID = Convert.ToInt32(row.Cells["id"].Value);
            //need to add role
            //need to add search by clicking on line but not on cell
            txtBoxLogin.Text = row.Cells["login"].Value.ToString();
            txtBoxPass.Text = row.Cells["password"].Value.ToString();
            txtBoxName.Text = row.Cells["name"].Value.ToString();
            txtBoxSurname.Text = row.Cells["surname"].Value.ToString();
            txtBoxEmail.Text = row.Cells["email"].Value.ToString();
            txtBoxPhone.Text = row.Cells["phone"].Value.ToString();
            txtBoxAddress.Text = row.Cells["address"].Value.ToString();
            cboRole.Text = role_name.ToString();

         }

        private void dataGridViewProject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgdViewProject.Rows[e.RowIndex];

            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT surname FROM employee WHERE id =" + Convert.ToInt32(row.Cells["mngr_id"].Value.ToString()), conn);

            conn.Open();
            rdr = cmd.ExecuteReader();
            string mngr_name = "";
            if (rdr.HasRows)
            {
                rdr.Read();
                mngr_name = rdr.GetString(0);
            }

            conn.Close();

            lblProjectIDValue.Text = row.Cells["id"].Value.ToString();
            lblPMngrIDValue.Text = row.Cells["mngr_id"].Value.ToString();
            txtBoxPMName.Text = row.Cells["name"].Value.ToString();
            txtBoxPAddress.Text = row.Cells["address"].Value.ToString();
            cboPM.Text = mngr_name.ToString();

        }

        private void dgdVieSite_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgdVieSite.Rows[e.RowIndex];

            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT name FROM project WHERE id =" + Convert.ToInt32(row.Cells["proj_id"].Value.ToString()), conn);

            conn.Open();
            rdr = cmd.ExecuteReader();
            string project_name = "";
            if (rdr.HasRows)
            {
                rdr.Read();
                project_name = rdr.GetString(0);
            }

            conn.Close();

            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT surname FROM employee WHERE id =" + Convert.ToInt32(row.Cells["mngr_id"].Value.ToString()), conn);

            conn.Open();
            rdr = cmd.ExecuteReader();
            string sitemng_name = "";
            if (rdr.HasRows)
            {
                rdr.Read();
                sitemng_name = rdr.GetString(0);
            }

            conn.Close();

            ID = Convert.ToInt32(row.Cells["id"].Value);
            //need to add pm id and mngr id
            txtBoxSiteName.Text = row.Cells["name"].Value.ToString();
            txtBoxSiteAddress.Text = row.Cells["address"].Value.ToString();
            cboProject.Text = project_name.ToString();
            cboSiteManager.Text = sitemng_name.ToString();


        }

        //Author: Lana
        private void btnCreateUser_Click(object sender, EventArgs e)
        {           
            int role_id = 0;
            DataTable dt = new DataTable();

            //define role_id by role_name from db
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT id FROM role WHERE name='" + cboRole.Text+ "'", conn);
            conn.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                rdr.Read();                
                role_id = rdr.GetInt32(0);
            }            
            conn.Close();
            //create new user
            cmd = new SqlCommand("INSERT INTO employee (login, password, name, surname, email, phone, address, role_id, isActive) VALUES (@login,@password,@name,@surname,@email,@phone,@address,@role_id,'True')", conn);
            cmd.Parameters.AddWithValue("@login", txtBoxLogin.Text);
            cmd.Parameters.AddWithValue("@password", txtBoxPass.Text);
            //need to add role
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
                lblUserStatus.Text = "Successfuly Added";
                ShowAllUsers();
                ClearUserInputFields();
            }
            conn.Close();

            //ClearAll();
            //Clear fields after Creating the User
            /*txtBoxLogin.Clear();
            txtBoxPass.Clear();
            txtBoxName.Clear();
            txtBoxSurname.Clear();
            txtBoxEmail.Clear();
            txtBoxPhone.Clear();
            txtBoxAddress.Clear();
            cboRole.SelectedIndex = -1;*/
        }

        //Author: Liana
        //Clear all input fields
        private void ClearUserInputFields()
        {
            //Clear fields after Creating the User
            txtBoxLogin.Clear();
            txtBoxPass.Clear();
            txtBoxName.Clear();
            txtBoxSurname.Clear();
            txtBoxEmail.Clear();
            txtBoxPhone.Clear();
            txtBoxAddress.Clear();
            cboRole.SelectedIndex = -1;
        }


        //Create new project
        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            //Author: Lana
            if (lblProjectIDValue.Text == "")
            {
                if (txtBoxPMName.Text == "" || txtBoxPMName.Text =="Input name")
                {
                    lblPStatus.ForeColor = System.Drawing.Color.Red;
                    lblPStatus.Text = "Please input Project name";
                }
                else
                {
                    //Define selected ProjectManager ID
                    int CurrentProjectManagerID = 0;
                    CurrentProjectManagerID = EmployeeIDByRoleAndSurname("Project Manager", cboPM.SelectedItem.ToString());

                    cmd = new SqlCommand("INSERT INTO project (name, mngr_id, address, isActive) VALUES (@name,@mngr_id,@address, 'True')", conn);

                    cmd.Parameters.AddWithValue("@name", txtBoxPMName.Text);
                    cmd.Parameters.AddWithValue("@address", txtBoxPAddress.Text);
                    cmd.Parameters.AddWithValue("@mngr_id", CurrentProjectManagerID);

                    conn.Open();
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        lblPStatus.ForeColor = System.Drawing.Color.Green;
                        lblPStatus.Text = "Successfully Added";
                    }
                    conn.Close();

                    ClearProjectInputFields();
                    ShowAllProjects();
                }
            }
            else
            {
                lblPStatus.ForeColor = System.Drawing.Color.Red;
                lblPStatus.Text = "Project already exists";
            }
        }

        private int EmployeeIDByRoleAndSurname(string employee_role, string employee_surname)
        {
            int employee_id = 0;
            if (employee_role != "" & employee_surname != "")
            {
                conn = new SqlConnection(connstr);
                cmd = new SqlCommand("SELECT e.id FROM employee e, role r WHERE e.role_id = r.id and r.name = '" + employee_role + "' and surname ='" + employee_surname + "'", conn);

                conn.Open();
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    employee_id = rdr.GetInt32(0);
                }
                conn.Close();
                return employee_id;
            }
            else
                return -1;
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


            cmd = new SqlCommand("INSERT INTO site (name, mngr_id, address, proj_id, isActive) VALUES (@name,@mngr_id,@address,@proj_id, 'True')", conn);

            cmd.Parameters.AddWithValue("@name", txtBoxSiteName.Text);
            cmd.Parameters.AddWithValue("@address", txtBoxSiteAddress.Text);
            cmd.Parameters.AddWithValue("@mngr_id", currentSiteManagerID);
            cmd.Parameters.AddWithValue("@proj_id", currentProjectID);

            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                lblSiteStatus.ForeColor = System.Drawing.Color.Green;
                lblSiteStatus.Text = "Successfully Added";
            }
            conn.Close();

            //Clear fields after Creating the Site
            txtBoxSiteName.Clear();
            txtBoxSiteAddress.Clear();
            cboProject.SelectedIndex = -1;
            cboSiteManager.SelectedIndex = -1;
        }

        private void btnShowAllSites_Click(object sender, EventArgs e)
        {
            ShowAllSites();
        }

        private void ShowAllUsers()
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT * FROM employee where isActive='True'", conn);
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

        private void ShowAllSites()
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT * FROM site where isActive='True'", conn);
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
                cmd = new SqlCommand("SELECT * FROM project where isActive='True'", conn);
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

        //Author: Lana
        //Make changes in Project and save 
        private void btnUpdateProject_Click(object sender, EventArgs e)
        {
            if (lblPMngrIDValue.Text != "")
            {
                conn = new SqlConnection(connstr);
                //create SQL request for updating project
                cmd = new SqlCommand("Update project Set name=@name,address=@address, mngr_id=@mngr_id WHERE ID=@id", conn);

                cmd.Parameters.AddWithValue("@id", lblProjectIDValue.Text);
                cmd.Parameters.AddWithValue("@mngr_id", lblPMngrIDValue.Text);
                cmd.Parameters.AddWithValue("@name", txtBoxPMName.Text);
                cmd.Parameters.AddWithValue("@address", txtBoxPAddress.Text);
                conn.Open();
                //if request was succesful, clear all data in input fields and show all projects
                if (cmd.ExecuteNonQuery() == 1)
                {
                    ShowAllProjects();
                    ClearProjectInputFields();
                    lblPStatus.ForeColor = System.Drawing.Color.Green;
                    lblPStatus.Text = "Project succesfully updated";
                }
                conn.Close();
            }
            else
            {
                lblPStatus.ForeColor = System.Drawing.Color.Red;
                lblPStatus.Text = "Please select Project for updating";
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("Update employee Set login=@login, password=@password,name=@name,surname=@surname,email=@email,phone=@phone,address=@address WHERE ID=@id", conn);

            cmd.Parameters.AddWithValue("@id", ID);
            cmd.Parameters.AddWithValue("@login", txtBoxLogin.Text);
            cmd.Parameters.AddWithValue("@password", txtBoxPass.Text);
            cmd.Parameters.AddWithValue("@name", txtBoxName.Text);
            cmd.Parameters.AddWithValue("@surname", txtBoxSurname.Text);
            cmd.Parameters.AddWithValue("@email", txtBoxEmail.Text);
            cmd.Parameters.AddWithValue("@phone", txtBoxPhone.Text);
            cmd.Parameters.AddWithValue("@address", txtBoxAddress.Text);

            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
             //   ShowAll();
                lblUserStatus.ForeColor = System.Drawing.Color.Green;
                lblUserStatus.Text = "Successfully Updated";
            }
            conn.Close();

        }

        private void btnUpdateSite_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("Update site Set name=@name,address=@address WHERE ID=@id", conn);

            //need to add manager id and project id
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.Parameters.AddWithValue("@name", txtBoxSiteName.Text);
            cmd.Parameters.AddWithValue("@address", txtBoxSiteAddress.Text);

            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                ShowAllSites();
                lblUserStatus.ForeColor = System.Drawing.Color.Green;
                lblUserStatus.Text = "Successfully Updated";
            }
            conn.Close();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("Update employee Set isActive='FALSE' where login=@login", conn);

            cmd.Parameters.AddWithValue("@login", txtBoxLogin.Text);

            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                ShowAllUsers();
                lblUserStatus.ForeColor = System.Drawing.Color.Green;
                lblUserStatus.Text = "Successfully Deleted";
            }
            conn.Close();
        }

        private void txtBoxSearchByID_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT * FROM employee WHERE surname LIKE'" + txtBoxSearchByID.Text + "%'", conn);
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
                MessageBox.Show("No data to show");
            }

        }


        private void txtBoxSearchP_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT * FROM project WHERE name LIKE'" + txtBoxSearchP.Text + "%'", conn);
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
                MessageBox.Show("No data to show");
            }
        }


        private void txtBoxSiteSearch_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT * FROM site WHERE surname LIKE'" + txtBoxSiteSearch.Text + "%'", conn);
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
                MessageBox.Show("No data to show");
            }
        }


        //Author: Liana
        //Delete project by setting isActive field to False
        private void btnDeleteProject_Click(object sender, EventArgs e)
        {
            if (lblPMngrIDValue.Text != "")
            {
                //make SQL query for updating Project
                conn = new SqlConnection(connstr);
                cmd = new SqlCommand("Update project Set isActive='FALSE' where id=@project_id", conn);

                cmd.Parameters.AddWithValue("@project_id", Convert.ToInt16(lblProjectIDValue.Text));

                conn.Open();
                // if query was succesful clear input fields, show all projects and show message 
                if (cmd.ExecuteNonQuery() == 1)
                {
                    ShowAllProjects();
                    ClearProjectInputFields();
                    lblPStatus.ForeColor = System.Drawing.Color.Green;
                    lblPStatus.Text = "Project deleted";
                }
                conn.Close();
            }
            else
            {
                lblPStatus.ForeColor = System.Drawing.Color.Red;
                lblPStatus.Text = "Please select Project for deleting";
            }
        }

        //Author: Liana
        //Set Project Manager ID if value in Project Manager's drop-down changed

        private void cboPM_DropDownClosed(object sender, EventArgs e)
        {
            if (cboPM.SelectedItem  != null)
            {
                lblPMngrIDValue.Text = Convert.ToString(EmployeeIDByRoleAndSurname("Project Manager", cboPM.SelectedItem.ToString()));
                /*
                conn = new SqlConnection(connstr);
                cmd = new SqlCommand("SELECT e.id FROM employee e, role r WHERE e.role_id = r.id and r.name = 'Project Manager' and isActive = 'True' and surname LIKE'" + cboPM.SelectedItem + "%'", conn);
                DataTable dt = new DataTable();

                conn.Open();
                rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    rdr.Read();
                    lblPMngrIDValue.Text = rdr[0].ToString();
                }
                else
                {
                    MessageBox.Show("No data to show");
                }*/
            }

        }
        //Author: Liana
        // Handle ClearAll button click
        private void btnClearAllProjects_Click(object sender, EventArgs e)
        {
            ClearProjectInputFields();
        }

        //Author: Liana
        // Clear all data in text fields for creating new project
        private void ClearProjectInputFields()
        {
            lblProjectIDValue.Text = "";
            lblPMngrIDValue.Text = "";
            cboPM.SelectedIndex = 0;
            txtBoxPMName.Text = "Input name";
            txtBoxPAddress.Text = "Input Address";
        }

    }
}

