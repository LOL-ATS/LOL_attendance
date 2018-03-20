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
            string role_name = "";
            if (rdr.HasRows)
            {
                rdr.Read();
                role_name = rdr.GetString(0);
            }
            conn.Close();

            txtBoxLogin.Text = row.Cells["login"].Value.ToString();
            txtBoxPass.Text = row.Cells["password"].Value.ToString();
            txtBoxName.Text = row.Cells["name"].Value.ToString();
            txtBoxSurname.Text = row.Cells["surname"].Value.ToString();
            txtBoxEmail.Text = row.Cells["email"].Value.ToString();
            txtBoxPhone.Text = row.Cells["phone"].Value.ToString();
            txtBoxAddress.Text = row.Cells["address"].Value.ToString();
            lblEmployeeIDValue.Text = row.Cells["id"].Value.ToString();
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
            txtBoxProjectName.Text = row.Cells["name"].Value.ToString();
            txtBoxPAddress.Text = row.Cells["address"].Value.ToString();
            cboPM.Text = mngr_name.ToString();

        }

        //Author:Liana 
        //Define project name by project ID
        private string ProjectNameByID(int projectID)
        {
            string projectName = "";

            //ProjectNameByID(Convert.ToInt32(row.Cells["proj_id"].Value.ToString()));

            conn = new SqlConnection(connstr);

            cmd = new SqlCommand("SELECT name FROM project WHERE id =" + projectID, conn);

            conn.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                rdr.Read();
                projectName = rdr.GetString(0);
            }
            conn.Close();
            return projectName;
        }

        //Author: Lana, Liana
        //Fill in fields at the left when user click on cell in gridview 
        private void dgdViewSite_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgdViewSite.Rows[e.RowIndex];

            string project_name = ProjectNameByID(Convert.ToInt32(row.Cells["proj_id"].Value.ToString()));

            conn = new SqlConnection(connstr);

            cmd = new SqlCommand("SELECT name FROM project WHERE id =" + Convert.ToInt32(row.Cells["proj_id"].Value.ToString()), conn);

            conn.Open();
            rdr = cmd.ExecuteReader();
            
            if (rdr.HasRows)
            {
                rdr.Read();
                project_name = rdr.GetString(0);
            }

            conn.Close();
            if (row.Cells["mngr_id"].Value.ToString() == "")
            {
                cboSiteManager.SelectedIndex = -1;
                lblSiteManagerIDValue.Text = "";
            }
            else
            {
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
                cboSiteManager.Text = sitemng_name.ToString();
                lblSiteManagerIDValue.Text = row.Cells["mngr_id"].Value.ToString();
                conn.Close();
            }

            txtBoxSiteName.Text = row.Cells["name"].Value.ToString();
            txtBoxSiteAddress.Text = row.Cells["address"].Value.ToString();
            lblSiteIDValue.Text = row.Cells["id"].Value.ToString();
            cboProject.Text = project_name.ToString();
            lblProjectIDOnSiteValue.Text = row.Cells["proj_id"].Value.ToString();
           
        }
        private bool IsExistingUserByLogin(string userLogin)
        {
            bool userExists = true;
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT login FROM employee WHERE login = '" + userLogin + "' and isActive = 'True'", conn);

            conn.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                rdr.Read();
                userExists = true;
            }
            else
            {
                userExists = false;
            }

            conn.Close();
            return userExists;
        }

        //Liana: define role ID by role name
        private int RoleIDByName(string roleName)
        {
            int roleID;

            //define role_id by role_name from db
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT id FROM role WHERE name='" + roleName + "'", conn);
            conn.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                rdr.Read();
                roleID = rdr.GetInt32(0);
            }
            else
            {
                roleID = -1;
            }
            conn.Close();
            return roleID;
        }

        //Author: Lana, Liana
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            //Liana: if employee does not exist create employee
            if (lblEmployeeIDValue.Text == "")
            {
                //Liana: if employee surname is not defined
                if (txtBoxSurname.Text == "")
                {
                    MessageBox.Show("Please input Surname");
                }
                //Liana: else employee surname is defined, create employee
                else
                {
                    //Liana: if role selected create employee
                    if (cboRole.SelectedIndex != -1)
                    {
                        if (cboRole.SelectedIndex == 3)
                        {
                            int roleID = 0;
                            //define role_id by role_name from db
                            roleID = RoleIDByName(cboRole.Text);

                            DataTable dt = new DataTable();

                            //create new user
                            cmd = new SqlCommand("INSERT INTO employee (name, surname, email, phone, address, role_id, isActive) VALUES (@name,@surname,@email,@phone,@address,@role_id,'True')", conn);
                            cmd.Parameters.AddWithValue("@name", txtBoxName.Text);
                            cmd.Parameters.AddWithValue("@surname", txtBoxSurname.Text);
                            cmd.Parameters.AddWithValue("@email", txtBoxEmail.Text);
                            cmd.Parameters.AddWithValue("@phone", txtBoxPhone.Text);
                            cmd.Parameters.AddWithValue("@address", txtBoxAddress.Text);
                            cmd.Parameters.AddWithValue("@role_id", roleID);
                            conn.Open();
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Employee successfully added");
                                ShowAllEmployees();
                                ClearUserInputFields();
                            }
                            conn.Close();
                        }
                        else
                        {
                            if (txtBoxLogin.Text == "")
                            {
                                MessageBox.Show("Please, fill in Login field");
                            }
                            else
                            {
                                if (IsExistingUserByLogin(txtBoxLogin.Text))
                                {
                                    MessageBox.Show("User with defined Login already exists");
                                }
                                else
                                { 
                                    if (txtBoxPass.Text == "")
                                    {
                                        MessageBox.Show("Please, fill in Password field");
                                    }
                                    else
                                    {
                                        int roleID = 0;
                                        //define role_id by role_name from db
                                        roleID = RoleIDByName(cboRole.Text);

                                        DataTable dt = new DataTable();

                                        //create new user
                                        cmd = new SqlCommand("INSERT INTO employee (login, password, name, surname, email, phone, address, role_id, isActive) VALUES (@login,@password,@name,@surname,@email,@phone,@address,@role_id,'True')", conn);
                                        cmd.Parameters.AddWithValue("@login", txtBoxLogin.Text);
                                        cmd.Parameters.AddWithValue("@password", txtBoxPass.Text);
                                        cmd.Parameters.AddWithValue("@name", txtBoxName.Text);
                                        cmd.Parameters.AddWithValue("@surname", txtBoxSurname.Text);
                                        cmd.Parameters.AddWithValue("@email", txtBoxEmail.Text);
                                        cmd.Parameters.AddWithValue("@phone", txtBoxPhone.Text);
                                        cmd.Parameters.AddWithValue("@address", txtBoxAddress.Text);
                                        cmd.Parameters.AddWithValue("@role_id", roleID);
                                        conn.Open();
                                        if (cmd.ExecuteNonQuery() == 1)
                                        {
                                            MessageBox.Show("Successfully added");
                                            ShowAllEmployees();
                                            ClearUserInputFields();
                                        }
                                        conn.Close();
                                    }
                                }
                            }
                        }
                    }
                    //Liana: if role is not selected show message
                    else
                    {
                        MessageBox.Show("Please, select role");
                    }
                }
            }
            //Liana: if employee ID defined show message employee already exists
            else
            {
                MessageBox.Show("Employee already exists");
            }

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
            lblEmployeeIDValue.Text = "";
        }
        //Author: Liana
        //check if project with such name already exists
        private bool IsExistingProject(string name)
        {
            bool projectExists=true;
            cmd = new SqlCommand("SELECT * FROM project WHERE name='" + name + "'", conn);

            conn.Open();
            if (cmd.ExecuteReader().HasRows)
            {
                projectExists = true;
            }
            else
            {
                projectExists = false;
            }
            conn.Close();
            return projectExists;
        }

        //Create new project
        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            if (lblProjectIDValue.Text == "")
            {
                if (txtBoxProjectName.Text == "" || txtBoxProjectName.Text =="Input name")
                {
                        MessageBox.Show("Please input Project name");
                }
                else
                {
                    if (IsExistingProject(txtBoxProjectName.Text))
                    {
                        MessageBox.Show("Project name already exists");
                    }
                    else
                    {
                        if (lblPMngrIDValue.Text == "")
                        {
                            cmd = new SqlCommand("INSERT INTO project (name, address, isActive) VALUES (@name,@address, 'True')", conn);

                            cmd.Parameters.AddWithValue("@name", txtBoxProjectName.Text);
                            cmd.Parameters.AddWithValue("@address", txtBoxPAddress.Text);

                            conn.Open();
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Successfully Added");
                                ClearProjectInputFields();
                                ShowAllProjects();
                            }
                            conn.Close();
                        }
                        else
                        {

                            cmd = new SqlCommand("INSERT INTO project (name, mngr_id, address, isActive) VALUES (@name,@mngr_id,@address, 'True')", conn);

                            cmd.Parameters.AddWithValue("@name", txtBoxProjectName.Text);
                            cmd.Parameters.AddWithValue("@address", txtBoxPAddress.Text);
                            cmd.Parameters.AddWithValue("@mngr_id", lblPMngrIDValue.Text);
                            conn.Open();
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Successfully Added");
                                ClearProjectInputFields();
                                ShowAllProjects();
                            }
                            conn.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Project already exists");
            }
        }
        //Liana: define employee ID by login
        private int EmployeeIDByLogin(string login)
        {
            int employee_id = 0;
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT e.id FROM employee e WHERE login ='" + login + "'", conn);
            conn.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                rdr.Read();
                employee_id = rdr.GetInt32(0);
            }
            else
            {
                employee_id = -1;
            }
            conn.Close();
            return employee_id;
        }

        //Liana: define employee id by role and surname 
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
                else
                {
                    employee_id = -1;
                }
                conn.Close();
                return employee_id;
            }
            else
                return -1;
        }

        //Author:Liana
        //Define project ID by name
        private int ProjectIDByName(string name)
        {
            int projectID = 0;
            if (name != "")
            {
                conn = new SqlConnection(connstr);
                cmd = new SqlCommand("SELECT id FROM project WHERE isActive = 'True' and name = '" + name + "'", conn);

                conn.Open();
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    projectID = rdr.GetInt32(0);
                }
                else
                {
                    projectID = -1;
                }
                conn.Close();
                return projectID;
            }
            else
                return -1;
        }


        //Author: Lana, Liana
        private void btnCreateSite_Click(object sender, EventArgs e)
        {
            if (lblSiteID.Text != "")
            {
                if (txtBoxSiteName.Text == "")
                {
                    MessageBox.Show("Please input Sitename");
                }
                else
                {
                    if (cboProject.SelectedItem == null)
                    {
                        MessageBox.Show("Please select Project");
                    }
                    else
                    {
                        if (cboSiteManager.SelectedItem == null)
                        {
                            //Lana:
                            //Define selected Project ID
                            int currentProjectID = 0;
                            currentProjectID = ProjectIDByName(cboProject.SelectedItem.ToString());

                            conn = new SqlConnection(connstr);
                            cmd = new SqlCommand("INSERT INTO site (name, address, proj_id, isActive) VALUES (@name,@address,@proj_id, 'True')", conn);

                            cmd.Parameters.AddWithValue("@name", txtBoxSiteName.Text);
                            cmd.Parameters.AddWithValue("@address", txtBoxSiteAddress.Text);
                            cmd.Parameters.AddWithValue("@proj_id", currentProjectID);

                            conn.Open();
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Successfully Added");
                                //Clear fields after Creating the Site
                                ClearSiteInputFields();
                                ShowAllSites();
                            }
                            conn.Close();
                        }
                        else
                        {
                            //Define selected SiteManager ID
                            int currentSiteManagerID = 0;

                            currentSiteManagerID = EmployeeIDByRoleAndSurname("Site Manager", cboSiteManager.SelectedItem.ToString());

                            //Define selected Project ID
                            int currentProjectID = 0;
                            currentProjectID = ProjectIDByName(cboProject.SelectedItem.ToString());

                            conn = new SqlConnection(connstr);
                            cmd = new SqlCommand("INSERT INTO site (name, mngr_id, address, proj_id, isActive) VALUES (@name,@mngr_id,@address,@proj_id, 'True')", conn);

                            cmd.Parameters.AddWithValue("@name", txtBoxSiteName.Text);
                            cmd.Parameters.AddWithValue("@address", txtBoxSiteAddress.Text);
                            cmd.Parameters.AddWithValue("@mngr_id", currentSiteManagerID);
                            cmd.Parameters.AddWithValue("@proj_id", currentProjectID);

                            conn.Open();
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Successfully Added");
                                //Clear fields after Creating the Site
                                ClearSiteInputFields();
                                ShowAllSites();
                            }
                            conn.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Site already exists");
            }
        }

        private void ClearSiteInputFields()
        {
            lblSiteIDValue.Text = "";
            txtBoxSiteName.Clear();
            txtBoxSiteAddress.Clear();
            lblProjectIDOnSiteValue.Text = "";
            lblSiteManagerIDValue.Text = "";
            cboProject.SelectedIndex = -1;
            cboSiteManager.SelectedIndex = -1;
        }

        private void btnShowAllSites_Click(object sender, EventArgs e)
        {
            ShowAllSites();
        }


        private void ShowAllSites()
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT id, mngr_id, name, proj_id, address FROM site where isActive='True'", conn);
            DataTable dt = new DataTable();

            conn.Open();
            rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                dt.Load(rdr);
                dgdViewSite.DataSource = dt;
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
                cmd = new SqlCommand("SELECT id, name, mngr_id, address FROM project where isActive='True'", conn);
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
                cmd = new SqlCommand("SELECT id, role_id, login, password, name, surname, email, phone, address FROM employee where isActive='True'", conn);
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
            //Liana: proceed if project id is defined
            if (lblProjectIDValue.Text != "")
            {
                //Liana: show error message if project name is undefind
                if (txtBoxProjectName.Text == "")
                {
                    MessageBox.Show("Please, fill in project name field");
                }
                //Liana: proceed if project name is defined
                else
                {
                    //Liana: proceed if there are no projects with defined project name or project name is not changed
                    if (ProjectIDByName(txtBoxProjectName.Text)==-1 || Convert.ToInt32(lblProjectIDValue.Text) == ProjectIDByName(txtBoxProjectName.Text))
                    {
                        conn = new SqlConnection(connstr);
                        //create SQL request for updating project
                        cmd = new SqlCommand("Update project Set name=@name,address=@address, mngr_id=@mngr_id WHERE ID=@id", conn);

                        cmd.Parameters.AddWithValue("@id", lblProjectIDValue.Text);
                        cmd.Parameters.AddWithValue("@mngr_id", lblPMngrIDValue.Text);
                        cmd.Parameters.AddWithValue("@name", txtBoxProjectName.Text);
                        cmd.Parameters.AddWithValue("@address", txtBoxPAddress.Text);
                        conn.Open();
                        //if request was succesful, clear all data in input fields and show all projects
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            ShowAllProjects();
                            ClearProjectInputFields();
                            MessageBox.Show("Project succesfully updated");
                        }
                        conn.Close();
                    }
                    //Liana: show error message if changed project name already exists
                    else 
                    {
                        MessageBox.Show("Project with such name already exists!");
                    }

                }
            }
            //Liana: show message if project ID is undefined
            else
            {
                MessageBox.Show("Please, select project for updating");
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            //Liana: if employee is not selected show message 
            if (lblEmployeeIDValue.Text == "")
            {
                MessageBox.Show("Please, select employee for updating");
            }
            //Liana: employee is selected proceed updating
            else
            {
                //Liana: if selected employee is worker
                if (cboRole.SelectedIndex == 3)
                {
                    //Liana: if employee surname is not defined
                    if (txtBoxSurname.Text == "")
                    {
                        MessageBox.Show("Please input Surname");
                    }
                    //Liana: else employee surname is defined, update employee
                    else
                    {
                        int roleID = 0;
                        //define role_id by role_name from db
                        roleID = RoleIDByName(cboRole.Text);

                        DataTable dt = new DataTable();

                        //update user
                        cmd = new SqlCommand("update employee set name=@name, surname=@surname, email=@email, phone=@phone, address=@address, role_id = @role_id where id=" +lblEmployeeIDValue.Text, conn);
                        cmd.Parameters.AddWithValue("@name", txtBoxName.Text);
                        cmd.Parameters.AddWithValue("@surname", txtBoxSurname.Text);
                        cmd.Parameters.AddWithValue("@email", txtBoxEmail.Text);
                        cmd.Parameters.AddWithValue("@phone", txtBoxPhone.Text);
                        cmd.Parameters.AddWithValue("@address", txtBoxAddress.Text);
                        cmd.Parameters.AddWithValue("@role_id", roleID);
                        conn.Open();
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Employee successfully updated");
                            ShowAllEmployees();
                            ClearUserInputFields();
                        }
                        conn.Close();
                    }
                }
                //if selected employee is not worker
                else
                {
                    //login should be filled in
                    if (txtBoxLogin.Text == "")
                    {
                        MessageBox.Show("Please, fill in Login field");
                    }
                    //proceed if login defined 
                    else
                    {
                        int employeeID=EmployeeIDByLogin(txtBoxLogin.Text);
                        //check login is not changed or it is new login
                        if (employeeID == Convert.ToInt32(lblEmployeeIDValue.Text)||employeeID == -1)
                        { 
                            //proceed updating if login does not exist in db yet
                            //show message if password is not set
                            if (txtBoxPass.Text == "")
                            {
                                MessageBox.Show("Please, fill in Password field");
                            }
                            //proceed if password is set
                            else
                            {
                                int roleID = 0;
                                //define role_id by role_name from db
                                roleID = RoleIDByName(cboRole.Text);

                                DataTable dt = new DataTable();

                                //create new user
                                cmd = new SqlCommand("update employee set login=@login, password=@password, name=@name, surname=@surname, email=@email, phone=@phone, address=@address, role_id =@role_id where id=" + lblEmployeeIDValue.Text, conn);
                                cmd.Parameters.AddWithValue("@login", txtBoxLogin.Text);
                                cmd.Parameters.AddWithValue("@password", txtBoxPass.Text);
                                cmd.Parameters.AddWithValue("@name", txtBoxName.Text);
                                cmd.Parameters.AddWithValue("@surname", txtBoxSurname.Text);
                                cmd.Parameters.AddWithValue("@email", txtBoxEmail.Text);
                                cmd.Parameters.AddWithValue("@phone", txtBoxPhone.Text);
                                cmd.Parameters.AddWithValue("@address", txtBoxAddress.Text);
                                cmd.Parameters.AddWithValue("@role_id", roleID);
                                conn.Open();
                                if (cmd.ExecuteNonQuery() == 1)
                                {
                                    MessageBox.Show("Successfully updated");
                                    ShowAllEmployees();
                                    ClearUserInputFields();
                                }
                                conn.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Another user with defined Login already exists");
                        }

                    }
                }
            }
        }

        //Author: Lana and Liana
        //Update info for site
        private void btnUpdateSite_Click(object sender, EventArgs e)
        {
            if (lblSiteIDValue.Text == "")
            {
                MessageBox.Show("Please, select site for updating");
            }
            else
            {
                if (txtBoxSiteName.Text == "")
                {
                    MessageBox.Show("Please, input Sitename");
                }
                else
                {
                    if (cboProject.SelectedItem == null)
                    {
                        MessageBox.Show("Please, select Project");
                    }
                    else
                    {
                        if (cboSiteManager.SelectedItem == null)
                        {
                            //Define selected Project ID
                            int currentProjectID = 0;
                            currentProjectID = ProjectIDByName(cboProject.SelectedItem.ToString());

                            conn = new SqlConnection(connstr);
                            cmd = new SqlCommand("Update site Set name=@name,address=@address, proj_id=@proj_id WHERE ID=@id", conn);

                            cmd.Parameters.AddWithValue("@name", txtBoxSiteName.Text);
                            cmd.Parameters.AddWithValue("@address", txtBoxSiteAddress.Text);
                            cmd.Parameters.AddWithValue("@proj_id", currentProjectID);
                            cmd.Parameters.AddWithValue("@id", lblSiteIDValue.Text);

                            conn.Open();
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Successfully updated");
                                //Clear fields after Creating the Site
                                ClearSiteInputFields();
                                ShowAllSites();
                            }
                            conn.Close();
                        }
                        else
                        {
                            //Define selected SiteManager ID
                            int currentSiteManagerID = 0;

                            currentSiteManagerID = EmployeeIDByRoleAndSurname("Site Manager", cboSiteManager.SelectedItem.ToString());

                            //Define selected Project ID
                            int currentProjectID = 0;
                            currentProjectID = ProjectIDByName(cboProject.SelectedItem.ToString());

                            conn = new SqlConnection(connstr);
                            cmd = new SqlCommand("Update site Set name=@name, mngr_id =@mngr_id, address=@address, proj_id=@proj_id WHERE ID=@id", conn);

                            cmd.Parameters.AddWithValue("@name", txtBoxSiteName.Text);
                            cmd.Parameters.AddWithValue("@address", txtBoxSiteAddress.Text);
                            cmd.Parameters.AddWithValue("@mngr_id", currentSiteManagerID);
                            cmd.Parameters.AddWithValue("@proj_id", currentProjectID);
                            cmd.Parameters.AddWithValue("@id", lblSiteIDValue.Text);

                            conn.Open();
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Successfully updated");
                                //Clear fields after Creating the Site
                                ClearSiteInputFields();
                                ShowAllSites();
                            }
                            conn.Close();
                        }
                    }
                }
            }
        }
        
        //Liana: Delete selected user by setting its isActive=False
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (lblEmployeeIDValue.Text == "")
            {
                MessageBox.Show("Please, select employee for deleting");
            }
            else
            {
                conn = new SqlConnection(connstr);
                cmd = new SqlCommand("update employee set isActive ='False' where id=@id", conn);

                cmd.Parameters.AddWithValue("@id", lblEmployeeIDValue.Text);

                conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Successfully Deleted");
                    ShowAllEmployees();
                    ClearUserInputFields();
                }
                conn.Close();
            }
        }

        private void txtBoxSearchByID_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT id, role_id, login, password, name, surname, email, phone, address FROM employee WHERE isActive='True' and surname LIKE'" + txtBoxSearchByID.Text + "%'", conn);
   
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
            cmd = new SqlCommand("SELECT id, name, mngr_id, address  FROM project WHERE isActive='True' and name LIKE'" + txtBoxSearchP.Text + "%'", conn);

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
            //Liana: sql query for make sql 
            cmd = new SqlCommand("SELECT id, mngr_id, name, proj_id, address FROM site WHERE isActive='True' and surname LIKE'" + txtBoxSiteSearch.Text + "%'", conn);

            DataTable dt = new DataTable();

            conn.Open();
            rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                dt.Load(rdr);
                dgdViewSite.DataSource = dt;
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
                    MessageBox.Show("Project deleted");
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Please, select project for deleting");
            }
        }

        //Author: Liana
        //Set Project Manager ID if value in Project Manager's drop-down changed

        private void cboPM_DropDownClosed(object sender, EventArgs e)
        {
            if (cboPM.SelectedItem  != null)
            {
                lblPMngrIDValue.Text = Convert.ToString(EmployeeIDByRoleAndSurname("Project Manager", cboPM.SelectedItem.ToString()));
            }

        }

        //Author: Liana
        // Clear all data in text fields for creating new project
        private void ClearProjectInputFields()
        {
            lblProjectIDValue.Text = "";
            lblPMngrIDValue.Text = "";
            cboPM.SelectedIndex = 0;
            txtBoxProjectName.Text = "Input name";
            txtBoxPAddress.Text = "Input Address";
        }

        //Author:Liana
        //Update dropdown lists for Project Manager, Project, Site Manager comboboxes when tab is changed 
        private void tabRegistration_Selecting(object sender, TabControlCancelEventArgs e)
        {
            switch (tabRegistration.SelectedIndex)
            {
                //Employee tab selected
                case 0:
                    {
                        //Values of Role drop-down is defined in form
                        break;
                    }
                //Project tab selected 
                case 1:
                    {
                        cboPM.Items.Clear();
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

                        break;
                    }
                case 2:
                    {
                        //Liana: remove all items from Projct dropdown
                        cboProject.Items.Clear();
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

                        //Liana: remove all items from SiteManager dropdown
                        cboSiteManager.Items.Clear();
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
                        break;
                    }
            }
        }

        //Liana: delete site by setting isActive=False
        private void btnDeleteSite_Click(object sender, EventArgs e)
        {
            if (lblSiteIDValue.Text == "")
            {
                MessageBox.Show("Please, select site for deleting");
            }
            else
            {
                conn = new SqlConnection(connstr);
                cmd = new SqlCommand("Update site Set isActive='FALSE' where id=@siteId", conn);

                cmd.Parameters.AddWithValue("@siteId", lblSiteIDValue.Text);

                conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Successfully Deleted");
                    ShowAllSites();
                    ClearSiteInputFields();
                }
                conn.Close();
            }

        }

        private void cboSiteManager_DropDownClosed(object sender, EventArgs e)
        {
            if (cboSiteManager.SelectedItem != null)
            {
                lblSiteManagerIDValue.Text = Convert.ToString(EmployeeIDByRoleAndSurname("Site Manager", cboSiteManager.SelectedItem.ToString()));
            }
        }

        //Author: Liana
        //Change project ID label when project name dropdown changed
        private void cboProject_DropDownClosed(object sender, EventArgs e)
        {
            if (cboProject.SelectedItem != null)
            {
                lblProjectIDOnSiteValue.Text = Convert.ToString(ProjectIDByName(cboProject.SelectedItem.ToString()));
            }

        }

        private void tabUser_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {

        }

        private void lblProjectName_Click(object sender, EventArgs e)
        {

        }
    }
}

