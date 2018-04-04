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
        //Lana: Add connection to DB
        SqlConnection conn;
        SqlCommand cmd;
        string connstr = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        SqlDataReader rdr;
        // Variable for identify update or insert 
        Boolean isUpdated;
        public int ID;

        public frmRegistration()
        {
            InitializeComponent();
        }

        //Lana: Employee tab: fill in text boxes with values from selected row of datagridview 
        private void dataGridViewEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgdViewEmployee.Rows[e.RowIndex];

            //Liana: fill text boxes by selected row data
            txtBoxLogin.Text = row.Cells["login"].Value.ToString();
            txtBoxPass.Text = row.Cells["password"].Value.ToString();
            txtBoxName.Text = row.Cells["name"].Value.ToString();
            txtBoxSurname.Text = row.Cells["surname"].Value.ToString();
            txtBoxEmail.Text = row.Cells["email"].Value.ToString();
            txtBoxPhone.Text = row.Cells["phone"].Value.ToString();
            txtBoxAddress.Text = row.Cells["address"].Value.ToString();
            lblEmployeeIDValue.Text = row.Cells["id"].Value.ToString();
            //Liana: select value in Role drop down list
            cboRole.SelectedIndex = (Int32)row.Cells["role_id"].Value - 1;
            //Omid: disable btn Update since nothing to update
            btnUpdateUser.Enabled = false;
            //Omid: set isUpdated flag to true
            isUpdated = true;
        }

        //Lana: Project tab: fill in text boxes with values from selected row of datagridview 
        private void dataGridViewProject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgdViewProject.Rows[e.RowIndex];
            //Liana: define manager surname by id
            Employee empl = new Employee();
            string mngr_surname = empl.GetSurnameByID(Convert.ToInt32(row.Cells["mngr_id"].Value.ToString()));

            //fill text boxes by selected row data
            lblProjectIDValue.Text = row.Cells["id"].Value.ToString();
            lblPMngrIDValue.Text = row.Cells["mngr_id"].Value.ToString();
            txtBoxProjectName.Text = row.Cells["name"].Value.ToString();
            txtBoxPAddress.Text = row.Cells["address"].Value.ToString();
            cboPM.Text = mngr_surname;

            btnUpdateProject.Enabled = false;
            btnUpdateProject.Text = "Update";
            isUpdated = true;
        }

        //Lana:
        //Fill in text boxes at the left when user click on cell in gridview 
        private void dgdViewSite_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgdViewSite.Rows[e.RowIndex];
            //Liana: define project name by ID
            Project proj = new Project();
            string project_name = proj.GetNameByID(Convert.ToInt32(row.Cells["proj_id"].Value.ToString()));
            // if site manager does not defined for selected site then ID is empty and drop down list shows nothing
            if (row.Cells["mngr_id"].Value.ToString() == "")
            {
                cboSiteManager.SelectedIndex = -1;
                lblSiteManagerIDValue.Text = "";
            }
            else
            {
                Employee empl = new Employee();
                string sitemng_surname = empl.GetSurnameByID(Convert.ToInt32(row.Cells["mngr_id"].Value.ToString()));

                cboSiteManager.Text = sitemng_surname;
                lblSiteManagerIDValue.Text = row.Cells["mngr_id"].Value.ToString();
             }
            //fill text boxes by selected row data

            txtBoxSiteName.Text = row.Cells["name"].Value.ToString();
            txtBoxSiteAddress.Text = row.Cells["address"].Value.ToString();
            lblSiteIDValue.Text = row.Cells["id"].Value.ToString();
            cboProject.Text = project_name.ToString();
            lblProjectIDOnSiteValue.Text = row.Cells["proj_id"].Value.ToString();
            btnUpdateSite.Enabled = false;
            btnUpdateSite.Text = "Update";
            isUpdated = true;
        }


        //Lana: to create new user clear all text fields
        //Rename button Update to Save
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            ClearUserInputFields();
            this.ActiveControl=cboRole;
            isUpdated = false;
            btnUpdateUser.Text = "Save";
        }

        //Lana:
        //Clear all input fields
        private void ClearUserInputFields()
        {
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

        //Lana: to create new project clear all input fields
        //Rename button Update to Save
        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            ClearProjectInputFields();
            this.ActiveControl = txtBoxProjectName;
            isUpdated = false;
            btnUpdateProject.Text = "Save";
        }


        //Omid:Create new site
        private void btnCreateSite_Click(object sender, EventArgs e)
        {
            ClearSiteInputFields();
            this.ActiveControl = txtBoxSiteName;
            isUpdated = false;
            btnUpdateSite.Text = "Save";
        }
        
        //omid:Clear site data in text boxes 
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

        //Lana:
        //Show all Data related to sites from DB in graidview
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
                conn.Close();
                DataGridViewRow row = dgdViewSite.Rows[0];
                // define project name by ID
                Project proj = new Project();
                string project_name = proj.GetNameByID(Convert.ToInt32(row.Cells["proj_id"].Value.ToString()));

                if (row.Cells["mngr_id"].Value.ToString() == "")
                {
                    cboSiteManager.SelectedIndex = -1;
                    lblSiteManagerIDValue.Text = "";
                }
                else
                {
                    Employee empl = new Employee();
                    string sitemng_name = empl.GetSurnameByID(Convert.ToInt32(row.Cells["mngr_id"].Value.ToString()));
                    cboSiteManager.Text = sitemng_name.ToString();
                    lblSiteManagerIDValue.Text = row.Cells["mngr_id"].Value.ToString();
                }
                txtBoxSiteName.Text = row.Cells["name"].Value.ToString();
                txtBoxSiteAddress.Text = row.Cells["address"].Value.ToString();
                lblSiteIDValue.Text = row.Cells["id"].Value.ToString();
                cboProject.Text = project_name.ToString();
                lblProjectIDOnSiteValue.Text = row.Cells["proj_id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("No Data to show");
                conn.Close();
            }
        }

        //Lana:
        //Show all Data related to Projects from DB
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

                //Fill text boxes
                DataGridViewRow row = dgdViewProject.Rows[0];

                Employee empl = new Employee();
                string mngr_name = empl.GetSurnameByID(Convert.ToInt32(row.Cells["mngr_id"].Value.ToString()));

                lblProjectIDValue.Text = row.Cells["id"].Value.ToString();
                lblPMngrIDValue.Text = row.Cells["mngr_id"].Value.ToString();
                txtBoxProjectName.Text = row.Cells["name"].Value.ToString();
                txtBoxPAddress.Text = row.Cells["address"].Value.ToString();
                cboPM.Text = mngr_name.ToString();

            }
            else
            {
                MessageBox.Show("No Data to show");
                conn.Close();
            }
        }

        //Lana:
        //Show all Data related to Employee from DB

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
                    // hide Role_ID, password columns 
                    dgdViewEmployee.Columns["role_id"].Visible = false;
                    dgdViewEmployee.Columns["password"].Visible = false;
                
                    txtBoxLogin.Text = dt.Rows[0]["login"].ToString();
                    txtBoxPass.Text = dt.Rows[0]["password"].ToString();
                    txtBoxName.Text = dt.Rows[0]["name"].ToString();
                    txtBoxSurname.Text = dt.Rows[0]["surname"].ToString();
                    txtBoxEmail.Text = dt.Rows[0]["email"].ToString();
                    txtBoxPhone.Text = dt.Rows[0]["phone"].ToString();
                    txtBoxAddress.Text = dt.Rows[0]["address"].ToString();
                    lblEmployeeIDValue.Text = dt.Rows[0]["id"].ToString();
                    cboRole.SelectedIndex = (Int32)dt.Rows[0]["role_id"]-1;
                    btnUpdateUser.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No Data to show");
                }
                conn.Close();
                btnUpdateUser.Enabled = false;
                isUpdated = true;
        }

        //Lana:
        //Updating Project's data
        private void btnUpdateProject_Click(object sender, EventArgs e)
        {
            //Liana: 
            //proceed if project id is defined
            if (isUpdated)
            {
                if (lblProjectIDValue.Text != "")
                {
                    //Liana: 
                    //show error message if project name is undefind
                    if (txtBoxProjectName.Text == "")
                    {
                        MessageBox.Show("Please, fill in project name field");
                    }
                    //Liana:
                    //proceed if project name is defined
                    else
                    {
                        //Liana: 
                        //proceed if there are no projects with defined project name or project name is not changed
                        Project proj = new Project();
                        int projID = 0;
                        projID = proj.GetIDByName(txtBoxProjectName.Text);
                        if (projID == -1 || Convert.ToInt32(lblProjectIDValue.Text) == projID)
                        {
                            conn = new SqlConnection(connstr);

                            //Lana:
                            //create SQL request for updating project
                            cmd = new SqlCommand("Update project Set name=@name,address=@address, mngr_id=@mngr_id WHERE ID=@id", conn);

                            cmd.Parameters.AddWithValue("@id", lblProjectIDValue.Text);
                            cmd.Parameters.AddWithValue("@mngr_id", lblPMngrIDValue.Text);
                            cmd.Parameters.AddWithValue("@name", txtBoxProjectName.Text);
                            cmd.Parameters.AddWithValue("@address", txtBoxPAddress.Text);
                            conn.Open();

                            //Lana:
                            //if request was succesful, clear all data in input fields and show all projects
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                ShowAllProjects();
                                //ClearProjectInputFields();
                                MessageBox.Show("Project succesfully updated");
                            }
                            conn.Close();
                        }
                        //Liana: 
                        //show error message if changed project name already exists
                        else
                        {
                            MessageBox.Show("Project with such name already exists!");
                        }

                    }
                }
                //Liana: 
                //show message if project ID is undefined
                else
                {
                    MessageBox.Show("Please, select project for updating");
                }
            }
            else
            {
                if (lblProjectIDValue.Text == "")
                {
                    if (txtBoxProjectName.Text == "" || txtBoxProjectName.Text == "")
                    {
                        MessageBox.Show("Please input Project name");
                    }
                    else
                    {
                        Project proj = new Project();
                        if (proj.IsExisting(txtBoxProjectName.Text))
                        {
                            MessageBox.Show("Project name already exists");
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
                                    ShowAllProjects();
                                }
                                conn.Close();
                            
                        }
                    }
                }
                else
                {
                    MessageBox.Show("This project already exists");
                }
            }
        }

        //Liana: Update employee info
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            //Liana: 
            //if employee is not selected show message 
            if (isUpdated)
            {
                //if selected employee is worker
                if (cboRole.SelectedIndex == 3)
                {
                    //if employee surname is not defined
                    if (txtBoxSurname.Text == "")
                    {
                        MessageBox.Show("Please input Surname");
                    }
                    //else employee surname is defined, update employee
                    else
                    {
                        int roleID = 0;

                        //Lana:
                        //define role_id by role_name from db
                        Role currentRole = new Role();
                        roleID = currentRole.GetIDByName(cboRole.Text);

                        DataTable dt = new DataTable();

                        //Lana:
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
                            btnUpdateUser.Enabled = false;
                            //ClearUserInputFields();
                        }
                        conn.Close();
                    }
                }
                //Liana:
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
                        Employee empl = new Employee();
                        int employeeID=empl.GetIDByLogin(txtBoxLogin.Text);
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
                                //Lana:
                                //define role_id by role_name from db
                                int roleID = 0;
                                Role currentRole = new Role();
                                roleID = currentRole.GetIDByName(cboRole.Text);

                                DataTable dt = new DataTable();

                                //Lana:
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
                                    btnUpdateUser.Enabled = false;
                                    //ClearUserInputFields();
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
            else
            {
                // if it is new Employee and ID is not defined yet
                if (lblEmployeeIDValue.Text == "")
                {
                    //Liana: 
                    //if employee surname is not defined
                    if (txtBoxSurname.Text == "")
                    {
                        MessageBox.Show("Please input Surname");
                    }
                    //Liana:
                    //else employee surname is defined, create employee
                    else
                    {
                        //Liana:
                        //if role selected create employee
                        if (cboRole.SelectedIndex != -1)
                        {
                            if (cboRole.SelectedIndex == 3)
                            {
                                int roleID = 0;
                                //Lana
                                //define role_id by role_name from db
                                Role currentRole = new Role();
                                roleID = currentRole.GetIDByName(cboRole.Text);

                                DataTable dt = new DataTable();

                                //Lana
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
                                    //ClearUserInputFields();
                                    btnUpdateUser.Enabled = false;
                                    btnUpdateUser.Text = "Update";
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
                                    Employee empl = new Employee();
                                    if (empl.IsExistingByLogin(txtBoxLogin.Text))
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

                                            //Lana:
                                            //define role_id by role_name from db
                                            Role currentRole = new Role();
                                            roleID = currentRole.GetIDByName(cboRole.Text);

                                            DataTable dt = new DataTable();

                                            //Lana:
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
                                                //ClearUserInputFields();
                                                btnUpdateUser.Enabled = false;
                                                btnUpdateUser.Text = "Update";
                                            }
                                            conn.Close();
                                        }
                                    }
                                }
                            }
                        }
                        //Liana: 
                        //if role is not selected show message
                        else
                        {
                            MessageBox.Show("Please, select role");
                        }
                    }
                }
                //Liana: 
                //if employee ID defined show message employee already exists
                else
                {
                    MessageBox.Show("This employee already exists");
                    ClearUserInputFields();
                }
            }
            
        }


        //Liana:
        //messages if fields are empty
        private void btnUpdateSite_Click(object sender, EventArgs e)
        {
            if (isUpdated)
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
                                //Lana:
                                //Define selected Project ID
                                int currentProjectID = 0;
                                Project proj = new Project();
                                currentProjectID = proj.GetIDByName(cboProject.SelectedItem.ToString());

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

                                    //Lana:
                                    //Clear fields after Creating the Site
                                    ShowAllSites();
                                    btnUpdateSite.Enabled = false;
                                }
                                conn.Close();
                            }
                            else
                            {
                                //Lana:
                                //Define selected SiteManager ID
                                int currentSiteManagerID = 0;
                                Employee empl = new Employee();
                                currentSiteManagerID = empl.GetIDByRoleAndSurname("Site Manager", cboSiteManager.SelectedItem.ToString());

                                //Lana:
                                //Define selected Project ID
                                int currentProjectID = 0;
                                Project proj = new Project();
                                currentProjectID = proj.GetIDByName(cboProject.SelectedItem.ToString());

                                //Lana:
                                //Update the fields
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
                                    //Lana:
                                    //Clear fields after Creating the Site
                                    //ClearSiteInputFields();
                                    ShowAllSites();
                                    btnUpdateSite.Enabled = false;

                                }
                                conn.Close();
                            }
                        }
                    }
                }
            }
            else
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
                                Project proj = new Project();
                                currentProjectID = proj.GetIDByName        (cboProject.SelectedItem.ToString());

                                conn = new SqlConnection(connstr);
                                cmd = new SqlCommand("INSERT INTO site (name, address, proj_id, isActive) VALUES (@name,@address,@proj_id, 'True')", conn);

                                cmd.Parameters.AddWithValue("@name", txtBoxSiteName.Text);
                                cmd.Parameters.AddWithValue("@address", txtBoxSiteAddress.Text);
                                cmd.Parameters.AddWithValue("@proj_id", currentProjectID);

                                conn.Open();
                                if (cmd.ExecuteNonQuery() == 1)
                                {
                                    MessageBox.Show("Successfully Added");

                                    //Lana:
                                    //Clear fields after Creating the Site
                                    btnUpdateSite.Text = "Update";
                                    isUpdated = false;
                                    ShowAllSites();
                                }
                                conn.Close();
                            }
                            else
                            {
                                //Lana:
                                //Define selected SiteManager ID
                                int currentSiteManagerID = 0;
                                Employee empl = new Employee();
                                currentSiteManagerID = empl.GetIDByRoleAndSurname("Site Manager", cboSiteManager.SelectedItem.ToString());

                                //Lana:
                                //Define selected Project ID
                                int currentProjectID = 0;
                                Project proj = new Project();
                                currentProjectID = proj.GetIDByName(cboProject.SelectedItem.ToString());

                                //Lana:
                                //Insert the values to DB
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

                                    //Lana:
                                    //Clear fields after Creating the Site
                                    btnUpdateSite.Text = "Update";
                                    isUpdated = false;
                                    ShowAllSites();
                                }
                                conn.Close();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("This site already exists");
                    ClearSiteInputFields();
                }
            }
        }

        //Liana: 
        //Delete selected user by setting its isActive=False
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
                    btnUpdateUser.Enabled = false;
                    //ClearUserInputFields();
                }
                conn.Close();
            }
        }

        //Lana:
        //Search in DB through UI
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

        //Lana:
        //Search in DB through UI
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

        //Lana:
        //Search in DB through UI
        private void txtBoxSiteSearch_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstr);
            //Liana: 
            //add Active into the search 
            cmd = new SqlCommand("SELECT id, mngr_id, name, proj_id, address FROM site WHERE isActive='True' and name LIKE'" + txtBoxSiteSearch.Text + "%'", conn);

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


        //Liana:
        //Delete project by setting isActive field to False
        private void btnDeleteProject_Click(object sender, EventArgs e)
        {
            if (lblPMngrIDValue.Text != "")
            {
                //Liana:
                //make SQL query for updating Project
                conn = new SqlConnection(connstr);
                cmd = new SqlCommand("Update project Set isActive='FALSE' where id=@project_id", conn);

                cmd.Parameters.AddWithValue("@project_id", Convert.ToInt16(lblProjectIDValue.Text));

                conn.Open();
                //Liana:
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

        //Liana:
        //Set Project Manager ID if value in Project Manager's drop-down changed

        private void cboPM_DropDownClosed(object sender, EventArgs e)
        {
            if (cboPM.SelectedItem  != null)
            {
                Employee empl = new Employee();
                lblPMngrIDValue.Text = Convert.ToString(empl.GetIDByRoleAndSurname("Project Manager", cboPM.SelectedItem.ToString()));
            }

        }

        //Liana:
        //Clear all data in text fields for creating new project
        private void ClearProjectInputFields()
        {
            lblProjectIDValue.Text = "";
            //lblPMngrIDValue.Text = "";
            //cboPM.SelectedIndex = 0;
            txtBoxProjectName.Text = "";
            txtBoxPAddress.Text = "";
        }

        //Liana:
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
                        //Liana: 
                        //remove all items from Projct dropdown
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

                        //Liana: 
                        //remove all items from SiteManager dropdown
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

        //Liana: 
        //delete site by setting isActive=False
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

        //Liana: change site manager ID if Site manager was changed
        private void cboSiteManager_DropDownClosed(object sender, EventArgs e)
        {
            if (cboSiteManager.SelectedItem != null)
            {
                Employee empl = new Employee();
                lblSiteManagerIDValue.Text = Convert.ToString(empl.GetIDByRoleAndSurname("Site Manager", cboSiteManager.SelectedItem.ToString()));
            }
        }

        //Liana:
        //Change project ID label when project name dropdown changed
        private void cboProject_DropDownClosed(object sender, EventArgs e)
        {
            if (cboProject.SelectedItem != null)
            {
                Project proj = new Project();
                lblProjectIDOnSiteValue.Text = Convert.ToString(proj.GetIDByName(cboProject.SelectedItem.ToString()));
            }

        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            ShowAllEmployees();
            ShowAllProjects();
            ShowAllSites();
            btnUpdateUser.Enabled = false;
        }

        private void FieldChanged(object sender, EventArgs e)
        {
            switch (tabRegistration.SelectedIndex)
            {
                case 0:

                    if (txtBoxName.Text != "" && txtBoxSurname.Text != "" )
                    {
                        btnUpdateUser.Enabled = true;
                    }
                    break;

                case 1:

                    if (txtBoxProjectName.Text != "")
                    {
                        btnUpdateProject.Enabled = true;
                    }
                    break;
                case 2:

                    if (txtBoxSiteName.Text != "" )
                    {
                        btnUpdateSite.Enabled = true;
                    }

                    break;
            }
          
        }

        private void txtBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (txtBoxEmail.Text.Length > 0)

            {

                if (!rEMail.IsMatch(txtBoxEmail.Text))

                {
                    MessageBox.Show("E-Mail is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxEmail.SelectAll();
                    e.Cancel = true;
                }

            }
        }
    }
}

