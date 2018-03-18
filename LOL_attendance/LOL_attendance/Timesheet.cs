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
        DataTable dtTimesheet= new DataTable();

        DataTable dtWorkers = new DataTable();
 
        string connStr = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
        int currentSiteID = 0;
        int currentSiteManagerID = 0;
        int currentProjectID = 0;
        int currentProjectManagerID = 0;
        public frmTimesheet()
        {
            InitializeComponent();
            dtTimesheet.Columns.Add("ID", typeof(Int32));
            dtTimesheet.Columns.Add("Name", typeof(String));
            dtTimesheet.Columns.Add("Surname", typeof(String));
            dtTimesheet.Columns.Add("Hours", typeof(TimeSpan));

        }

        private void frmTimesheet_Load(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand cmd;
            SqlDataReader rdr;
            conn = new SqlConnection(connStr);
            Main frm = (Main)this.MdiParent;
            this.Text = "Timesheet: " + frm.User.userfullname.ToString() + " ("+frm.User.userRole.ToString()+")";

            //Check Role of User
            if (frm.User.userRole == userClass.userRoles.SiteManager)
            {
                //-----------------Site Manager -------------------
                currentSiteManagerID = frm.User.userID;

                //*****bind Project dropdown with values from db*****
                //Liana: Fixed query for isActive flag
                cmd = new SqlCommand("SELECT p.id, p.name FROM project p, site s WHERE s.mngr_id=" + currentSiteManagerID.ToString() + " and p.id=s.proj_id and s.isActive='True' and p.isActive = 'True'", conn);


                DataTable dtproject = new DataTable();
                dtproject.Columns.Add("ID", typeof(Int32));
                dtproject.Columns.Add("Name", typeof(String));
                comboProjects.ValueMember = "id";
                comboProjects.DisplayMember = "name";

                conn.Open();
                rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    dtproject.Load(rdr);
                    comboProjects.DataSource = dtproject;
                    comboProjects.SelectedIndex = 0;
                    currentProjectID = (Int32)comboProjects.SelectedValue;
                }

                conn.Close();
            }
            else if (frm.User.userRole == userClass.userRoles.ProjectManager)
            {
                //-----------------Project Manager -------------------
                currentProjectManagerID = frm.User.userID;

                //*******bind Project dropdown with values from db******
                //Liana: change query to consider isActive flag
                cmd = new SqlCommand("SELECT id, name FROM project WHERE isActive='True' and mngr_id=" + currentProjectManagerID.ToString(), conn);
                DataTable dtproject = new DataTable();
                dtproject.Columns.Add("ID", typeof(Int32));
                dtproject.Columns.Add("Name", typeof(String));
                comboProjects.ValueMember = "id";
                comboProjects.DisplayMember = "name";

                conn.Open();
                rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    dtproject.Load(rdr);
                    comboProjects.DataSource = dtproject;
                    comboProjects.SelectedIndex = 0;
                    currentProjectID = (Int32)comboProjects.SelectedValue;
                }
                conn.Close();

               }
            //Liana: commented Admin part because Admin can't work on TS
            /*
            else if (frm.User.userRole == userClass.userRoles.Admin)
            {
                //-----------------  Admin  -------------------
                
                //*******bind Project dropdown with values from db******
                cmd = new SqlCommand("SELECT id, name FROM project", conn);
                DataTable dtproject = new DataTable();
                dtproject.Columns.Add("ID", typeof(Int32));
                dtproject.Columns.Add("Name", typeof(String));
                comboProjects.ValueMember = "id";
                comboProjects.DisplayMember = "name";

                conn.Open();
                rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    dtproject.Load(rdr);
                    comboProjects.DataSource = dtproject;
                    comboProjects.SelectedIndex = 0;
                    currentProjectID = (Int32)comboProjects.SelectedValue;
                }
                conn.Close();
            }
            */
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand cmd;
            SqlDataReader rdr;
            int rows = 0;
            rows = dataGridViewTS.RowCount;

            //define selected Site ID
            conn = new SqlConnection(connStr);
            cmd = new SqlCommand("SELECT id from site where name='" + comboBoxSitename.SelectedItem + "'", conn);
            conn.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                rdr.Read();
                currentSiteID = rdr.GetInt32(0);
            }
            conn.Close();
            //define selected Site Manager ID
            conn = new SqlConnection(connStr);
            cmd = new SqlCommand("SELECT id from employee where name='" + comboProjects.SelectedItem + "'", conn);

            conn.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                rdr.Read();
                currentSiteManagerID = rdr.GetInt32(0);
            }
            conn.Close();
            //saving TS rows in db
            int rowIndex = 0;
            int addedRows = 0;
            while (rows > 0)
            {
                rows = rows - 1;
                if (dataGridViewTS.Rows[rowIndex].Cells[1].Value != null)
                {
                    cmd = new SqlCommand("INSERT into timesheet (date, hours, employee_id, site_id, status) VALUES (@date, @hours, @employee_id, @site_id, 'Saved')", conn);
                    cmd.Parameters.AddWithValue("@date", dateTimePicker.Value.ToString("yyyy-MM-dd"));
                    
                    cmd.Parameters.AddWithValue("@hours", TimeSpan.Parse(dataGridViewTS.Rows[rowIndex].Cells[4].Value.ToString()));
                    //++need to add check for not null value 
                    cmd.Parameters.AddWithValue("@employee_id", Convert.ToInt32(dataGridViewTS.Rows[rowIndex].Cells[1].Value.ToString()));
                    cmd.Parameters.AddWithValue("@site_id", currentSiteID);

                    conn.Open();
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        addedRows++;
                        //lblUserStatus.ForeColor = System.Drawing.Color.Green;
                        //lblUserStatus.Text = "Successfuly added";
                    }
                    conn.Close();
                }
                rowIndex++;
            }

            if (addedRows > 0)
            {
                lblTSStatus.Text = "Saved";
                Updatedata();
            }

        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            int rows = dataGridViewTS.RowCount;
            SqlConnection conn;
            SqlCommand cmd;
            SqlDataReader rdr;
            //define selected Site ID
            conn = new SqlConnection(connStr);
            cmd = new SqlCommand("SELECT id from site where name='" + comboBoxSitename.SelectedItem + "'", conn);
            conn.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                rdr.Read();
                currentSiteID = rdr.GetInt32(0);
            }
            conn.Close();
            //define selected Site Manager ID
            conn = new SqlConnection(connStr);
            cmd = new SqlCommand("SELECT id from employee where name='" + comboProjects.SelectedItem + "'", conn);

            conn.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                rdr.Read();
                currentSiteManagerID = rdr.GetInt32(0);
            }
            conn.Close();
            //update TS's status for Approved in db
            int rowIndex = 0;
            int updatedRows = 0;
            while (rows > 0)
            {
                rows = rows - 1;
                if (dataGridViewTS.Rows[rowIndex].Cells[1].Value != null)
                {
                    cmd = new SqlCommand("UPDATE timesheet SET status = 'Approved', approved_by_id = " + currentSiteManagerID + "where date = '" + dateTimePicker.Value.ToString("yyyy-MM-dd") + "' and employee_id = @employee_id and site_id = @site_id", conn);
                    //cmd.Parameters.AddWithValue("@date", dateTimePicker.Value);
                    //cmd.Parameters.AddWithValue("@hours", TimeSpan.FromHours(Convert.ToDouble(dataGridViewTS.Rows[rowIndex].Cells[2].Value.ToString())));
                    //++need to add check for not null value 
                    cmd.Parameters.AddWithValue("@employee_id", Convert.ToInt32(dataGridViewTS.Rows[rowIndex].Cells[1].Value.ToString()));
                    cmd.Parameters.AddWithValue("@site_id", currentSiteID);

                    conn.Open();
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        updatedRows++;
                        //lblUserStatus.ForeColor = System.Drawing.Color.Green;
                        //lblUserStatus.Text = "Successfuly added";
                    }
                    conn.Close();
                }
                rowIndex++;
            }

            if (updatedRows > 0)
            {
                lblTSStatus.Text = "Saved" + Convert.ToString(updatedRows);
            }

        }

        private void Updatedata()
        {
            SqlConnection conn;
            SqlCommand cmd;
            SqlDataReader rdr;
            conn = new SqlConnection(connStr);
            //load Workers GridVew 
            //Liana: sql query to select all workers who does not have TS record for selected date and site 
            cmd = new SqlCommand("SELECT e.id, e.name, e.surname FROM employee e WHERE e.role_id=4 and not exists(select * from timesheet t where t.employee_id=e.id and date = '" + dateTimePicker.Value.ToString("yyyy-MM-dd") + "' and site_id =" + currentSiteID.ToString() + ")", conn);
            conn.Open();
            rdr = cmd.ExecuteReader();
            dtWorkers.Clear();
            if (rdr.HasRows)
            {        
                dtWorkers.Load(rdr);
                dataGridViewEmploye.DataSource = dtWorkers;
            }
            conn.Close();

            ////Get selected Site ID
            //conn = new SqlConnection(connStr);
            //cmd = new SqlCommand("SELECT id from site where name='" + comboBoxSitename.SelectedItem + "'", conn);
            //conn.Open();
            //rdr = cmd.ExecuteReader();
            //if (rdr.HasRows)
            //{
            //    rdr.Read();
            //    currentSiteID = rdr.GetInt32(0);
            //}
            //conn.Close();
           

            //----------------------------------------------------
            //Load TS regarding on date and site
            cmd = new SqlCommand("SELECT employee_id as ID, name, surname, hours, status FROM employee e, timesheet ts where e.id=ts.employee_id and date ='" + dateTimePicker.Value.ToString("yyyy-MM-dd") + "' and site_id = @site_id", conn);

            cmd.Parameters.AddWithValue("@site_id", currentSiteID);
            //Fill the Timesheet GrideView
            conn.Open();
            rdr = cmd.ExecuteReader();
            dtTimesheet.Clear();
            if (rdr.HasRows)
            {
                dtTimesheet.Load(rdr);
                dataGridViewTS.DataSource = dtTimesheet;
            }
            conn.Close();
            //----------------------------------------------------

        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
     

            foreach (DataGridViewRow row in dataGridViewEmploye.Rows)
            {
                Boolean chk = Convert.ToBoolean(row.Cells[0].Value);
                DataTable dt = new DataTable();
                if (chk)
                {
                    DataRow workRow = dtTimesheet.NewRow();
                    workRow[0] = (int)row.Cells[1].Value;
                    workRow[1] = row.Cells[2].Value.ToString();
                    workRow[2] = row.Cells[3].Value.ToString();
                    workRow[3] = TimeSpan.Parse("00:00");
                    dtTimesheet.Rows.Add(workRow);
                    dataGridViewTS.DataSource = dtTimesheet;
                }

            }

        }

        private void btnDelEmployee_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand cmd;
            conn = new SqlConnection(connStr);

            DialogResult dialogResult = MessageBox.Show("Selected records will be DELETE from this Timesheet except approveed records", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridViewTS.Rows)
                {
                    
                    Boolean chk = Convert.ToBoolean(row.Cells[0].Value);
                    DataTable dt = new DataTable();
                    if (chk==true && row.Cells[4].ToString()!="Approved")
                    {
                        
                        cmd = new SqlCommand("DELETE FROM timesheet WHERE employee_id=" + row.Cells[1].Value.ToString() + " and date ='" + dateTimePicker.Value.ToString("yyyy-MM-dd") + "' and site_id =" + currentSiteID.ToString(), conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        dtTimesheet.Rows.RemoveAt(row.Index);
                        dataGridViewTS.DataSource = dtTimesheet;

                    }

                }
            } 
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }


        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Updatedata();
        }

        private void comboProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand cmd;
            SqlDataReader rdr;
            conn = new SqlConnection(connStr);

            if (comboProjects.SelectedItem != null) currentProjectID = (Int32)comboProjects.SelectedValue;
            Main frm = (Main)this.MdiParent;

            //           MessageBox.Show(currentProjectID.ToString());
            // Check user role
            if (frm.User.userRole == userClass.userRoles.SiteManager)
            {
                //-----------------Site Manager -------------------
                currentSiteManagerID = frm.User.userID;

                //*****bind Sites dropdown with values from db *****
                DataTable dtsite = new DataTable();
                dtsite.Columns.Add("ID", typeof(Int32));
                dtsite.Columns.Add("Name", typeof(String));
                comboBoxSitename.ValueMember = "id";
                comboBoxSitename.DisplayMember = "name";
                //Liana: edit query to take into account isActive flag
                cmd = new SqlCommand("SELECT id, name FROM site WHERE isActive = 'True' and mngr_id=@SMid and proj_id=@Pid", conn);
                cmd.Parameters.AddWithValue("@SMid", currentSiteManagerID);
                cmd.Parameters.AddWithValue("@Pid", currentProjectID);

                conn.Open();
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    btnAddEmployee.Enabled = true;
                    btnDelEmployee.Enabled = true;
                    btnSave.Enabled = true;
                    btnReject.Enabled = true;
                    btnApprove.Enabled = true;
                    comboBoxSitename.Enabled = true;
                    dateTimePicker.Enabled = true;
                    dtsite.Load(rdr);
                    comboBoxSitename.DataSource = dtsite;
                    comboBoxSitename.SelectedIndex = 0;
                    currentProjectID = (Int32)comboBoxSitename.SelectedValue;
                }
                else
                {
                    comboBoxSitename.Enabled = false;
                    btnAddEmployee.Enabled = false;
                    btnDelEmployee.Enabled = false;
                    btnSave.Enabled = false;
                    btnReject.Enabled = false;
                    dateTimePicker.Enabled = false;
                    btnApprove.Enabled = false;
                    MessageBox.Show("There is no site for you!");
                }
                conn.Close();



            }
            else if (frm.User.userRole == userClass.userRoles.ProjectManager)
            {
                //-----------------Project Manager -------------------
                currentProjectManagerID = frm.User.userID;

                //*****bind Site dropdown with values from db******

                DataTable dtsite = new DataTable();
                dtsite.Columns.Add("ID", typeof(Int32));
                dtsite.Columns.Add("Name", typeof(String));
                comboBoxSitename.ValueMember = "id";
                comboBoxSitename.DisplayMember = "name";
                cmd = new SqlCommand("SELECT id, name FROM site WHERE proj_id=@pid", conn);
                //cmd.Parameters.AddWithValue("@PMid", currentProjectManagerID);
                currentProjectID = (Int32)comboProjects.SelectedValue;
                cmd.Parameters.AddWithValue("@Pid", currentProjectID);


                conn.Open();
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    btnAddEmployee.Enabled = true;
                    btnDelEmployee.Enabled = true;
                    btnSave.Enabled = true;
                    btnReject.Enabled = true;
                    btnApprove.Enabled = true;
                    comboBoxSitename.Enabled = true;
                    dateTimePicker.Enabled = true;
                    dtsite.Load(rdr);
                    comboBoxSitename.DataSource = dtsite;
                    comboBoxSitename.SelectedIndex = 0;
                }
                else
                {
                    comboBoxSitename.Enabled = false;
                    btnAddEmployee.Enabled = false;
                    btnDelEmployee.Enabled = false;
                    btnSave.Enabled = false;
                    btnReject.Enabled = false;
                    dateTimePicker.Enabled = false;
                    btnApprove.Enabled = false;
                    MessageBox.Show("There is no site for this project");
                }
                conn.Close();
            }
            else if (frm.User.userRole == userClass.userRoles.Admin)
            {
                //-----------------    Admin    -------------------
                currentProjectManagerID = frm.User.userID;

                //*****bind Site dropdown with values from db******

                DataTable dtsite = new DataTable();
                dtsite.Columns.Add("ID", typeof(Int32));
                dtsite.Columns.Add("Name", typeof(String));
                comboBoxSitename.ValueMember = "id";
                comboBoxSitename.DisplayMember = "name";
                cmd = new SqlCommand("SELECT id, name FROM site WHERE proj_id=@Pid", conn);
                cmd.Parameters.AddWithValue("@Pid", currentProjectID);


                conn.Open();
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    comboBoxSitename.Enabled = true;
                    dtsite.Load(rdr);
                    comboBoxSitename.DataSource = dtsite;
                    comboBoxSitename.SelectedIndex = 0;
                    currentProjectID = (Int32)comboBoxSitename.SelectedValue;
                }
                conn.Close();
            }

            Updatedata();
            

        }

        private void comboBoxSitename_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSitename.SelectedItem != null) currentSiteID = (Int32)comboBoxSitename.SelectedValue;
            else comboBoxSitename.Enabled = false;
 
//            MessageBox.Show(currentSiteID.ToString());
            Updatedata();
        }
    }
}
